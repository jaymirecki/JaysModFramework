#!/usr/bin/env python3
"""
RagePluginHook Documentation Scraper

Downloads and saves the RPH SDK documentation from https://docs.ragepluginhook.net/
to a local directory structure for offline reference.
"""

import os
import sys
import time
from urllib.parse import urljoin, urlparse
from urllib.request import urlopen, Request
from html.parser import HTMLParser
import json
from pathlib import Path


class LinkExtractor(HTMLParser):
    """Extract links from HTML content."""

    def __init__(self, base_url):
        super().__init__()
        self.links = set()
        self.base_url = base_url

    def handle_starttag(self, tag, attrs):
        if tag == 'a':
            for attr, value in attrs:
                if attr == 'href' and value:
                    # Normalize the URL
                    absolute_url = urljoin(self.base_url, value)
                    # Only keep links within the docs domain
                    if 'docs.ragepluginhook.net' in absolute_url:
                        # Remove fragments and query params
                        clean_url = absolute_url.split('#')[0].split('?')[0]
                        self.links.add(clean_url)


class RPHDocsScraper:
    """Scraper for RagePluginHook documentation."""

    def __init__(self, base_url="https://docs.ragepluginhook.net/", output_dir="./rph_docs"):
        self.base_url = base_url
        self.output_dir = Path(output_dir)
        self.output_dir.mkdir(parents=True, exist_ok=True)
        self.visited_urls = set()
        self.failed_urls = []
        self.index = []

    def get_url_path(self, url):
        """Convert URL to local file path."""
        parsed = urlparse(url)
        # Remove the domain from the path
        path = parsed.path.lstrip('/')

        # Default to index.html for root
        if not path or path.endswith('/'):
            path = os.path.join(path, 'index.html')
        # Add .html extension if not present
        elif not path.endswith('.html'):
            path = path + '.html'

        return path

    def save_page(self, url, content):
        """Save HTML content to file."""
        relative_path = self.get_url_path(url)
        file_path = self.output_dir / relative_path

        # Create parent directories
        file_path.parent.mkdir(parents=True, exist_ok=True)

        # Write file
        try:
            with open(file_path, 'w', encoding='utf-8') as f:
                f.write(content)
            print(f"✓ Saved: {relative_path}")
            return True
        except Exception as e:
            print(f"✗ Failed to save {relative_path}: {e}")
            return False

    def fetch_page(self, url):
        """Fetch a single page and return HTML content."""
        try:
            headers = {
                'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36'
            }
            req = Request(url, headers=headers)
            with urlopen(req, timeout=10) as response:
                return response.read().decode('utf-8')
        except Exception as e:
            print(f"✗ Failed to fetch {url}: {e}")
            return None

    def extract_links(self, url, html_content):
        """Extract all links from HTML content."""
        try:
            extractor = LinkExtractor(url)
            extractor.feed(html_content)
            return extractor.links
        except Exception as e:
            print(f"⚠ Failed to extract links from {url}: {e}")
            return set()

    def scrape(self, start_url=None, max_pages=None):
        """Scrape all documentation pages."""
        if start_url is None:
            start_url = self.base_url

        to_visit = [start_url]
        page_count = 0

        print(f"Starting scrape of {self.base_url}")
        print(f"Output directory: {self.output_dir}")
        print("-" * 60)

        while to_visit and (max_pages is None or page_count < max_pages):
            url = to_visit.pop(0)

            # Skip if already visited
            if url in self.visited_urls:
                continue

            self.visited_urls.add(url)
            print(f"Fetching ({page_count + 1}): {url}")

            # Fetch the page
            content = self.fetch_page(url)
            if content is None:
                self.failed_urls.append(url)
                continue

            # Save the page
            if self.save_page(url, content):
                page_count += 1
                self.index.append({
                    'url': url,
                    'local_path': self.get_url_path(url)
                })

            # Extract and queue new links
            new_links = self.extract_links(url, content)
            for link in new_links:
                if link not in self.visited_urls:
                    to_visit.append(link)

            # Be nice to the server
            time.sleep(0.5)

        print("-" * 60)
        print(f"Scrape complete!")
        print(f"Pages downloaded: {page_count}")
        print(f"URLs visited: {len(self.visited_urls)}")
        print(f"Failed URLs: {len(self.failed_urls)}")

        if self.failed_urls:
            print("\nFailed to fetch:")
            for url in self.failed_urls:
                print(f"  - {url}")

        # Save index
        self.save_index()

    def save_index(self):
        """Save an index of all downloaded pages."""
        index_file = self.output_dir / 'INDEX.json'
        try:
            with open(index_file, 'w', encoding='utf-8') as f:
                json.dump({
                    'base_url': self.base_url,
                    'pages': self.index,
                    'total_pages': len(self.index),
                    'timestamp': time.strftime('%Y-%m-%d %H:%M:%S')
                }, f, indent=2)
            print(f"✓ Saved index: {index_file}")
        except Exception as e:
            print(f"✗ Failed to save index: {e}")


def main():
    """Main entry point."""
    # Get output directory from command line or use default
    output_dir = sys.argv[1] if len(sys.argv) > 1 else "."

    scraper = RPHDocsScraper(
        base_url="https://docs.ragepluginhook.net/",
        output_dir=output_dir
    )

    # Start scraping
    # Set max_pages to None to scrape everything, or a number to limit
    scraper.scrape(max_pages=None)


if __name__ == '__main__':
    main()
