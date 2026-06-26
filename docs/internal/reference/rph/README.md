# RagePluginHook SDK Documentation

This directory contains reference documentation for the RagePluginHook (RPH) SDK, a scripting framework for Grand Theft Auto V modifications.

## Documentation Version

- **Latest documented version:** 0.56 ALPHA
- **Documentation source:** https://docs.ragepluginhook.net/
- **Last updated:** 2026-06-24

## Directory Structure

```
rph/
├── README.md                 # This file
├── download_docs.py          # Python script to fetch/update documentation
├── INDEX.json               # Generated index of all pages (created after download)
└── [documentation pages]    # HTML files organized by URL path
```

## Documentation Sections

The downloaded documentation includes:

- **Getting Started** - Plugin creation, execution model, and handleables
- **Console** - Access to the console and custom console commands
- **Version History** - Comprehensive changelog from v0.1 through v0.56
- **API Reference** - Detailed Rage namespace class and interface documentation

## Key Classes Documented

- Core: Entity, Vehicle, Ped, Camera, Blip
- Animation and asset systems
- Game interaction (controls, time, UI)
- Graphics and rendering
- Mathematical utilities
- File I/O and configuration
- Input handling and keyboard layouts

## Using the Documentation

### Viewing as HTML

1. After running the download script, open the `index.html` file in a web browser
2. All links within the documentation will work offline

### Viewing as Markdown

For easier reading and searching in your text editor or IDE, convert the HTML to Markdown:

```bash
python3 convert_to_markdown.py
```

This will:
- Convert all HTML files to Markdown using pandoc
- Preserve the original directory structure
- Generate `markdown/INDEX.md` with overview
- Create `markdown/MANIFEST.json` with file listing

**Requirements:** Pandoc must be installed:
```bash
# macOS
brew install pandoc

# Ubuntu/Debian
sudo apt-get install pandoc

# Windows (Chocolatey)
choco install pandoc

# Or visit: https://pandoc.org/installing.html
```

### Updating Documentation

To fetch the latest documentation from the official source:

```bash
python3 download_docs.py .
```

This will:
- Download all pages from https://docs.ragepluginhook.net/
- Crawl and follow all internal links
- Save pages in a directory structure matching the website
- Generate an INDEX.json with a list of all downloaded pages

**Note:** The download may take several minutes due to rate limiting (0.5s delay between requests).

After downloading, re-run the markdown conversion to update your markdown copy:

```bash
python3 convert_to_markdown.py
```

## Notes

- The official RPH documentation at https://docs.ragepluginhook.net/ appears to be the primary and most up-to-date source
- RPH is still in alpha, so API stability is not guaranteed
- For the latest version information and downloads, visit https://ragepluginhook.net/
- Reference this documentation in the main docs context map at `docs/internal/README.md`

## Related Documentation

- [RagePluginHook Official Site](https://ragepluginhook.net/)
- [Architecture Decision ADR-0001: RPH vs SHVDN](../architecture/decisions/adr-0001-rph-vs-shvdn.md)
- [Plugin System Design](../features/plugin-system/technical-design.md)
