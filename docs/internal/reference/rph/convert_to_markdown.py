#!/usr/bin/env python3
"""
RagePluginHook HTML to Markdown Converter

Converts downloaded HTML documentation to Markdown format using pandoc.
Preserves directory structure and handles batch conversion with progress reporting.
"""

import os
import sys
import subprocess
import shutil
from pathlib import Path
from typing import Tuple, List
import json


class HTMLToMarkdownConverter:
    """Convert HTML documentation to Markdown."""

    def __init__(self, html_dir="./html", output_dir="./markdown", index_output="./markdown/INDEX.md"):
        self.html_dir = Path(html_dir)
        self.output_dir = Path(output_dir)
        self.index_output = Path(index_output)
        self.converted_files = []
        self.failed_files = []
        self.skipped_files = []

    def check_pandoc(self) -> bool:
        """Check if pandoc is installed."""
        try:
            result = subprocess.run(
                ["pandoc", "--version"],
                capture_output=True,
                text=True,
                timeout=5
            )
            if result.returncode == 0:
                version_line = result.stdout.split('\n')[0]
                print(f"✓ Pandoc found: {version_line}")
                return True
        except (subprocess.TimeoutExpired, FileNotFoundError):
            pass
        return False

    def install_pandoc(self) -> bool:
        """Suggest or attempt to install pandoc."""
        print("\n✗ Pandoc is not installed.")
        print("\nTo install pandoc:")
        print("  macOS (brew):     brew install pandoc")
        print("  Ubuntu/Debian:    sudo apt-get install pandoc")
        print("  Windows (choco):  choco install pandoc")
        print("  Or visit: https://pandoc.org/installing.html")
        return False

    def convert_file(self, html_file: Path) -> Tuple[bool, str]:
        """
        Convert a single HTML file to Markdown.

        Returns: (success, message)
        """
        try:
            # Determine output path
            relative_path = html_file.relative_to(self.html_dir)
            output_file = self.output_dir / relative_path
            output_file = output_file.with_suffix('.md')

            # Create parent directories
            output_file.parent.mkdir(parents=True, exist_ok=True)

            # Convert using pandoc with better options for cleaner markdown
            result = subprocess.run(
                [
                    "pandoc",
                    str(html_file),
                    "-f", "html",
                    "-t", "markdown",
                    "-o", str(output_file),
                    "--wrap=none",  # Don't wrap long lines
                    "--strip-comments",  # Remove HTML comments
                    "--markdown-headings=atx",  # Use # style headings
                    "-M", "title=RPH Documentation",
                    "--no-highlight",  # Don't use code highlighting syntax
                    "--extract-media=/tmp/rph-media",  # Extract media to temp (we don't need it)
                ],
                capture_output=True,
                text=True,
                timeout=30
            )

            if result.returncode == 0:
                return True, str(relative_path)
            else:
                error = result.stderr.strip() if result.stderr else "Unknown error"
                return False, f"{relative_path}: {error}"

        except subprocess.TimeoutExpired:
            return False, f"{html_file.name}: Conversion timeout"
        except Exception as e:
            return False, f"{html_file.name}: {str(e)}"

    def should_convert(self, file_path: Path) -> bool:
        """Check if a file should be converted."""
        # Skip if it's already a markdown file
        if file_path.suffix == '.md':
            return False
        # Only convert HTML files
        if file_path.suffix.lower() not in ['.html', '.htm']:
            return False
        return True

    def convert(self, max_files: int = None) -> None:
        """Convert all HTML files to Markdown."""
        if not self.html_dir.exists():
            print(f"✗ HTML directory not found: {self.html_dir}")
            return

        if not self.check_pandoc():
            if not self.install_pandoc():
                print("\nCannot continue without pandoc.")
                return

        print(f"\nStarting conversion...")
        print(f"Input directory:  {self.html_dir}")
        print(f"Output directory: {self.output_dir}")
        print("-" * 60)

        # Find all HTML files
        html_files = [f for f in self.html_dir.rglob("*") if f.is_file() and self.should_convert(f)]

        if max_files:
            html_files = html_files[:max_files]

        total = len(html_files)
        print(f"Found {total} HTML files to convert\n")

        # Convert files
        for idx, html_file in enumerate(html_files, 1):
            success, message = self.convert_file(html_file)

            if success:
                self.converted_files.append(message)
                status = "✓"
            else:
                self.failed_files.append(message)
                status = "✗"

            if idx % 50 == 0 or idx == total:
                print(f"  [{idx}/{total}] {status} {message}")

        print("\n" + "-" * 60)
        print(f"Conversion complete!")
        print(f"  Converted: {len(self.converted_files)}")
        print(f"  Failed:    {len(self.failed_files)}")
        print(f"  Total:     {total}")

        if self.failed_files:
            print("\nFailed conversions:")
            for msg in self.failed_files[:10]:  # Show first 10
                print(f"  - {msg}")
            if len(self.failed_files) > 10:
                print(f"  ... and {len(self.failed_files) - 10} more")

        # Generate index
        self.generate_index()

    def generate_index(self) -> None:
        """Generate an index markdown file listing all converted files."""
        index_content = f"""# RagePluginHook Documentation (Markdown)

Generated from HTML documentation at `docs.ragepluginhook.net`

## Statistics

- **Total files converted:** {len(self.converted_files)}
- **Conversion failures:** {len(self.failed_files)}
- **Total HTML files:** {len(self.converted_files) + len(self.failed_files)}

## File Structure

The documentation is organized by the original website structure:

```
markdown/
├── index.md                    # Main index page
├── html/
│   ├── [documentation pages]   # One .md file per original HTML page
```

## Viewing the Documentation

1. Start with `index.md` for the main table of contents
2. Follow links to navigate between pages
3. Each markdown file corresponds to one documentation page

## Notes

- Pandoc conversion may not preserve all HTML formatting perfectly
- Complex tables or special formatting may require manual review
- Internal links within the documentation should still work

## Reconverting Documentation

To reconvert the HTML files (e.g., after updating with `download_docs.py`):

```bash
python3 convert_to_markdown.py
```

This will overwrite existing markdown files.
"""

        # Create output directory for index
        self.output_dir.mkdir(parents=True, exist_ok=True)

        # Write index file
        try:
            with open(self.index_output, 'w', encoding='utf-8') as f:
                f.write(index_content)
            print(f"✓ Generated index: {self.index_output}")
        except Exception as e:
            print(f"✗ Failed to generate index: {e}")

        # Also save a JSON manifest
        manifest = {
            "type": "markdown_documentation",
            "source": "docs.ragepluginhook.net",
            "total_converted": len(self.converted_files),
            "total_failed": len(self.failed_files),
            "output_directory": str(self.output_dir),
            "files": sorted(self.converted_files)
        }

        manifest_file = self.output_dir / "MANIFEST.json"
        try:
            with open(manifest_file, 'w', encoding='utf-8') as f:
                json.dump(manifest, f, indent=2)
            print(f"✓ Generated manifest: {manifest_file}")
        except Exception as e:
            print(f"✗ Failed to generate manifest: {e}")


def main():
    """Main entry point."""
    html_dir = sys.argv[1] if len(sys.argv) > 1 else "./html"
    output_dir = sys.argv[2] if len(sys.argv) > 2 else "./markdown"

    converter = HTMLToMarkdownConverter(
        html_dir=html_dir,
        output_dir=output_dir
    )

    converter.convert()


if __name__ == '__main__':
    main()
