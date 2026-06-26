#!/usr/bin/env python3
"""
RagePluginHook Documentation Index Generator

Parses markdown files to create a searchable index organized by class, namespace, and type.
Generates INDEX-SEARCHABLE.md with organized links to all documentation pages.
"""

import json
import re
from pathlib import Path
from collections import defaultdict
from typing import Dict, List, Tuple


def extract_title_from_markdown(file_path: Path) -> str:
    """Extract the main title/heading from a markdown file."""
    try:
        with open(file_path, 'r', encoding='utf-8') as f:
            for line in f:
                line = line.strip()
                if line.startswith('#') and not line.startswith('##'):
                    # Remove markdown heading symbols
                    return line.lstrip('#').strip()
    except:
        pass
    return file_path.stem


def categorize_page(file_name: str, title: str) -> Tuple[str, str]:
    """
    Determine the category and sort key for a page.
    Returns (category, sort_key)
    """
    # Extract category from filename
    if file_name.startswith('T_Rage_'):
        # Type/Class: T_Rage_Vector3
        class_name = file_name.replace('T_Rage_', '').replace('.htm.md', '')
        return ('Types & Classes', class_name)

    elif file_name.startswith('M_Rage_'):
        # Method: M_Rage_Vehicle_GetSeatCount
        match = re.match(r'M_Rage_([^_]+)_(.+)', file_name.replace('.htm.md', ''))
        if match:
            class_name = match.group(1)
            method_name = match.group(2)
            return (f'Methods - {class_name}', method_name)
        return ('Methods', 'Unknown')

    elif file_name.startswith('P_Rage_'):
        # Property: P_Rage_Vehicle_Model
        match = re.match(r'P_Rage_([^_]+)_(.+)', file_name.replace('.htm.md', ''))
        if match:
            class_name = match.group(1)
            prop_name = match.group(2)
            return (f'Properties - {class_name}', prop_name)
        return ('Properties', 'Unknown')

    elif file_name.startswith('N_Rage'):
        # Namespace: N_Rage
        return ('Namespaces', file_name.replace('N_Rage_', '').replace('.htm.md', ''))

    elif 'Getting' in title and 'Started' in title:
        return ('Getting Started', title)

    elif 'Console' in title:
        return ('Console', title)

    elif 'Version' in title or 'Changelog' in title:
        return ('Version History', title)

    elif 'Index' in file_name or 'index' in file_name:
        return ('Documentation Index', title)

    else:
        return ('Other Reference', title)


class RPHIndexGenerator:
    """Generate a searchable index for RPH documentation."""

    def __init__(self, markdown_dir: Path):
        self.markdown_dir = Path(markdown_dir)
        self.pages: Dict[str, Dict] = {}
        self.categories: Dict[str, List[Dict]] = defaultdict(list)

    def scan_markdown_files(self) -> None:
        """Scan all markdown files and extract metadata."""
        md_files = list(self.markdown_dir.glob('**/*.md'))
        print(f"Found {len(md_files)} markdown files")

        for file_path in md_files:
            file_name = file_path.name
            title = extract_title_from_markdown(file_path)
            category, sort_key = categorize_page(file_name, title)

            relative_path = file_path.relative_to(self.markdown_dir)

            page_info = {
                'title': title,
                'file': str(relative_path),
                'category': category,
                'sort_key': sort_key,
                'file_name': file_name,
            }

            self.pages[file_name] = page_info
            self.categories[category].append(page_info)

        # Sort within categories
        for category in self.categories:
            self.categories[category].sort(key=lambda x: x['sort_key'])

    def generate_markdown_index(self) -> str:
        """Generate a comprehensive markdown index."""
        lines = []

        lines.append("# RagePluginHook Documentation Index")
        lines.append("")
        lines.append("**Quick Navigation:**")
        lines.append("")

        # Quick links
        quick_links = [
            ('types', 'Types & Classes', 'Find class definitions and type information'),
            ('methods', 'Methods', 'Find method documentation'),
            ('properties', 'Properties', 'Find property documentation'),
            ('console', 'Console', 'Console API documentation'),
            ('getting-started', 'Getting Started', 'Getting started guides'),
        ]

        for anchor, display, desc in quick_links:
            lines.append(f"- [{display}](#{anchor}) — {desc}")

        lines.append("")
        lines.append("---")
        lines.append("")

        # Sort categories for better UX
        priority_categories = [
            'Getting Started',
            'Namespaces',
            'Types & Classes',
        ]
        other_categories = sorted([c for c in self.categories.keys() if c not in priority_categories])
        sorted_categories = priority_categories + other_categories

        for category in sorted_categories:
            if category not in self.categories:
                continue

            pages = self.categories[category]
            if not pages:
                continue

            # Create anchor from category
            anchor = category.lower().replace(' ', '-').replace('&', 'and')

            lines.append(f"## {category} {{#{anchor}}}")
            lines.append("")

            # Group by first letter for long categories
            if len(pages) > 30 and category.startswith('Methods - ') or category.startswith('Properties - '):
                # Keep methods/properties grouped by class
                lines.append("| Item | Documentation |")
                lines.append("|------|----------------|")
                for page in pages:
                    file_link = page['file'].replace('\\', '/')
                    lines.append(f"| `{page['sort_key']}` | [{page['title']}]({file_link}) |")
            else:
                # Regular list for smaller categories
                for page in pages:
                    file_link = page['file'].replace('\\', '/')
                    lines.append(f"- **{page['sort_key']}** — [{page['title']}]({file_link})")

            lines.append("")

        # Add search tips section
        lines.append("---")
        lines.append("")
        lines.append("## Search Tips")
        lines.append("")
        lines.append("### Finding Classes")
        lines.append("")
        lines.append("Classes are listed under **Types & Classes**. Common RPH classes:")
        lines.append("")
        common_classes = ['Vehicle', 'Ped', 'Entity', 'Camera', 'World', 'Game', 'Blip', 'Rope']
        for cls in common_classes:
            matching = [p for p in self.pages.values() if cls in p['title']]
            if matching:
                page = matching[0]
                file_link = page['file'].replace('\\', '/')
                lines.append(f"- [{cls}]({file_link})")

        lines.append("")
        lines.append("### Finding Methods by Class")
        lines.append("")
        lines.append("Methods are grouped by class. Look for sections like:")
        lines.append("- **Methods - Vehicle** — All Vehicle class methods")
        lines.append("- **Methods - Ped** — All Ped class methods")
        lines.append("- **Methods - Entity** — All Entity class methods")

        lines.append("")
        lines.append("### Namespace Overview")
        lines.append("")
        lines.append("All RPH classes are in the **Rage** namespace. See the Namespaces section for namespace documentation.")

        lines.append("")
        lines.append("---")
        lines.append("")
        lines.append(f"*Index generated from {len(self.pages)} documentation pages*")
        lines.append(f"*RPH Version: 0.56 ALPHA*")

        return '\n'.join(lines)

    def save_index(self, output_file: Path) -> None:
        """Save the generated index to a file."""
        content = self.generate_markdown_index()
        with open(output_file, 'w', encoding='utf-8') as f:
            f.write(content)
        print(f"✓ Index saved to {output_file}")


def main():
    """Main entry point."""
    markdown_dir = Path('.')

    if not markdown_dir.exists():
        markdown_dir = Path('./markdown')

    if not markdown_dir.exists():
        print(f"Error: markdown directory not found at {markdown_dir}")
        return

    generator = RPHIndexGenerator(markdown_dir)
    print(f"Scanning markdown files in {markdown_dir}...")
    generator.scan_markdown_files()

    print(f"Generating index for {len(generator.categories)} categories...")
    generator.save_index(markdown_dir / 'INDEX-SEARCHABLE.md')

    print("\nIndex Summary:")
    for category in sorted(generator.categories.keys()):
        count = len(generator.categories[category])
        print(f"  {category}: {count} pages")


if __name__ == '__main__':
    main()
