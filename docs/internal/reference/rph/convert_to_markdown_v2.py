#!/usr/bin/env python3
"""
RagePluginHook HTML to Markdown Converter (v2 - Improved)

Uses markdownify library for cleaner conversion of complex HTML structures.
Falls back to pandoc with better options if markdownify is not available.
"""

import os
import sys
import subprocess
import shutil
from pathlib import Path
from typing import Tuple
import json
import re

try:
    from markdownify import markdownify as md
    HAS_MARKDOWNIFY = True
except ImportError:
    HAS_MARKDOWNIFY = False


class ImprovedHTMLToMarkdownConverter:
    """Convert HTML documentation to clean Markdown."""

    def __init__(self, html_dir="./html", output_dir="./markdown", index_output="./markdown/INDEX.md"):
        self.html_dir = Path(html_dir)
        self.output_dir = Path(output_dir)
        self.index_output = Path(index_output)
        self.converted_files = []
        self.failed_files = []

    def get_html_title(self, file_path: Path) -> str:
        """Extract title from HTML file if possible."""
        try:
            with open(file_path, 'r', encoding='utf-8', errors='ignore') as f:
                content = f.read(5000)  # Read first 5KB
                # Look for title in common locations
                match = re.search(r'<title[^>]*>([^<]+)</title>', content)
                if match:
                    title = match.group(1).strip()
                    if title and title != 'RAGE Plugin Hook Documentation':
                        return title
                # Try to find h1 or heading
                match = re.search(r'<h[1-3][^>]*>([^<]+)</h[1-3]>', content)
                if match:
                    return match.group(1).strip()
        except:
            pass
        return None

    def convert_with_markdownify(self, html_file: Path) -> Tuple[bool, str]:
        """Convert using markdownify library for cleaner output."""
        try:
            with open(html_file, 'r', encoding='utf-8', errors='ignore') as f:
                html_content = f.read()

            # Extract title for context
            title = self.get_html_title(html_file)

            # Convert using markdownify
            markdown_content = md(html_content, heading_style="atx")

            # Clean up the markdown
            markdown_content = self._clean_markdown(markdown_content, title)

            # Determine output path
            relative_path = html_file.relative_to(self.html_dir)
            output_file = self.output_dir / relative_path
            output_file = output_file.with_suffix('.md')

            # Create parent directories
            output_file.parent.mkdir(parents=True, exist_ok=True)

            # Write file
            with open(output_file, 'w', encoding='utf-8') as f:
                f.write(markdown_content)

            return True, str(relative_path)

        except Exception as e:
            return False, f"{html_file.name}: {str(e)}"

    def convert_with_pandoc(self, html_file: Path) -> Tuple[bool, str]:
        """Convert using pandoc with improved options."""
        try:
            relative_path = html_file.relative_to(self.html_dir)
            output_file = self.output_dir / relative_path
            output_file = output_file.with_suffix('.md')

            output_file.parent.mkdir(parents=True, exist_ok=True)

            # Use pandoc with native_divs to better handle complex HTML
            result = subprocess.run(
                [
                    "pandoc",
                    str(html_file),
                    "-f", "html-native_divs",
                    "-t", "markdown-native_divs",
                    "-o", str(output_file),
                    "--wrap=none",
                    "--strip-comments",
                    "-M", "title=",
                ],
                capture_output=True,
                text=True,
                timeout=30
            )

            if result.returncode == 0:
                # Clean up the output
                with open(output_file, 'r', encoding='utf-8') as f:
                    content = f.read()
                content = self._clean_markdown(content)
                with open(output_file, 'w', encoding='utf-8') as f:
                    f.write(content)
                return True, str(relative_path)
            else:
                return False, f"{relative_path}: {result.stderr[:100]}"

        except Exception as e:
            return False, f"{html_file.name}: {str(e)}"

    def _clean_markdown(self, content: str, title: str = None) -> str:
        """Clean up markdown content to remove cruft."""
        lines = content.split('\n')
        cleaned = []
        skip_until_blank = False

        for line in lines:
            # Skip lines with only colons or dashes (pandoc div remnants)
            if re.match(r'^[:]{3,}', line) or re.match(r'^-{3,}', line):
                continue

            # Skip empty divs and attributes
            if re.match(r'^:::.*$', line) or re.match(r'^\{[#\.].*\}', line):
                continue

            # Skip navigation elements
            if any(nav in line.lower() for nav in ['navigation', 'breadcrumb', 'sitemap']):
                continue

            # Clean up excessive whitespace
            if line.strip():
                cleaned.append(line)
            elif cleaned and cleaned[-1].strip():  # Keep single blank lines
                cleaned.append('')

        # Add title if provided
        result = '\n'.join(cleaned).strip()
        if title and not result.startswith('#'):
            result = f"# {title}\n\n{result}"

        return result

    def convert(self, max_files: int = None) -> None:
        """Convert all HTML files to Markdown."""
        if not self.html_dir.exists():
            print(f"✗ HTML directory not found: {self.html_dir}")
            return

        # Determine which converter to use
        if HAS_MARKDOWNIFY:
            print("Using markdownify for conversion (cleaner output)")
            converter_func = self.convert_with_markdownify
        else:
            print("Using pandoc for conversion")
            print("  (for better results: pip install markdownify)")
            converter_func = self.convert_with_pandoc

        print(f"\nStarting conversion...")
        print(f"Input directory:  {self.html_dir}")
        print(f"Output directory: {self.output_dir}")
        print("-" * 60)

        # Find all HTML files
        html_files = [f for f in self.html_dir.rglob("*") if f.is_file() and f.suffix.lower() in ['.html', '.htm']]

        if max_files:
            html_files = html_files[:max_files]

        total = len(html_files)
        print(f"Found {total} HTML files to convert\n")

        # Convert files
        for idx, html_file in enumerate(html_files, 1):
            success, message = converter_func(html_file)

            if success:
                self.converted_files.append(message)
                status = "✓"
            else:
                self.failed_files.append(message)
                status = "✗"

            if idx % 100 == 0 or idx == total:
                print(f"  [{idx}/{total}] {status} {message}")

        print("\n" + "-" * 60)
        print(f"Conversion complete!")
        print(f"  Converted: {len(self.converted_files)}")
        print(f"  Failed:    {len(self.failed_files)}")
        print(f"  Total:     {total}")

        if self.failed_files:
            print("\nFailed conversions (first 10):")
            for msg in self.failed_files[:10]:
                print(f"  - {msg}")

        self.generate_index()

    def generate_index(self) -> None:
        """Generate index markdown file."""
        index_content = """# RagePluginHook Documentation (Markdown)

Generated from HTML documentation at `docs.ragepluginhook.net`

**Version:** RAGE Plugin Hook 0.56 ALPHA

## Getting Started

This is the complete API reference for RagePluginHook. The documentation is organized by the original website structure.

### Navigation

- Browse the file tree to find documentation pages
- Each `.md` file corresponds to one API reference page
- Look for files with class names, methods, and properties

### Key Sections

- **Classes (T_Rage_*)** - Type/class definitions
- **Methods (M_Rage_*)** - Method documentation
- **Properties (P_Rage_*)** - Property documentation
- **Namespaces (N_Rage*)** - Namespace organization

### Tips for Navigation

1. Search for class names you're interested in
2. Look for "Getting Started" pages for tutorials
3. Check the Console documentation for scripting API
4. Review Version History for changes between versions

## Statistics

- **Total files converted:** {}
- **Conversion failures:** {}

## File Structure

```
markdown/
├── INDEX.md                    # This file
├── MANIFEST.json              # Complete file listing
└── [documentation pages]      # Organized by original website structure
```

## Reconverting

To reconvert the HTML files with the latest tools:

```bash
python3 convert_to_markdown_v2.py html markdown
```

---

*Generated on 2026-06-24 from official RPH documentation*
""".format(len(self.converted_files), len(self.failed_files))

        self.output_dir.mkdir(parents=True, exist_ok=True)

        try:
            with open(self.index_output, 'w', encoding='utf-8') as f:
                f.write(index_content)
            print(f"✓ Generated index: {self.index_output}")
        except Exception as e:
            print(f"✗ Failed to generate index: {e}")


def main():
    """Main entry point."""
    html_dir = sys.argv[1] if len(sys.argv) > 1 else "./html"
    output_dir = sys.argv[2] if len(sys.argv) > 2 else "./markdown"

    converter = ImprovedHTMLToMarkdownConverter(
        html_dir=html_dir,
        output_dir=output_dir
    )

    converter.convert()


if __name__ == '__main__':
    main()
