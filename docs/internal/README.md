# Internal Documentation

This directory contains all internal documentation for JaysModFramework (JMF).

## Structure

| Directory | Purpose |
|---|---|
| [`product/`](product/vision.md) | Product vision and strategy |
| [`architecture/`](architecture/wip-overview.md) | System architecture, data model, tech stack, ADRs |
| [`features/`](features/) | Per-feature design documents |
| [`workflows/`](workflows/development-process.md) | Development and testing workflows |
| [`quality/`](quality/) | Coding standards and review guidelines |
| [`requirements/`](requirements/) | Functional and non-functional requirements |
| [`onboarding/`](onboarding/) | Getting started guides |

## Context Map

| Looking for | Go to |
|---|---|
| What we're building next | [Product Strategy](product/strategy.md) |
| Who the users are | [Personas](product/personas/) |
| Term definitions and abbreviations | [Glossary](product/glossary.md) |
| Game folder layout and config.xml structure | [File Structure](architecture/file-structure.md) |
| Why we chose RPH over SHVDN | [ADR-0001](architecture/decisions/adr-0001-rph-vs-shvdn.md) |
| Why interiors are code, not config | [ADR-0002](architecture/decisions/adr-0002-interiors-not-data-driven.md) |
| GTA VI portability strategy | [ADR-0003](architecture/decisions/adr-0003-gta6-portability.md) |
| Data folder structure and content mod patching | [ADR-0004](architecture/decisions/adr-0004-one-file-per-content-item.md) |
| Framework layer architecture and INativeFramework | [ADR-0005](architecture/decisions/adr-0005-framework-layer-architecture.md) |
| Settings loading and structure | [Settings](features/settings/requirements.md) |
| Logging levels, file output, and notifications | [Logger](features/logger/requirements.md) |
| Native UI notifications (Notify) | [UIService](features/ui-service/requirements.md) |
| Native tick and control-press events | [Lifecycle](features/lifecycle/requirements.md) |
| Menu and menu item abstractions, MenuService | [MenuService](features/menu-service/requirements.md) |
| How plugins register and tick | [Plugin System](features/plugin-system/technical-design.md) |
| Interaction menu requirements | [Interaction Menu Requirements](features/plugin-interaction-menu/requirements.md) |
| Interaction menu design | [Interaction Menu](features/plugin-interaction-menu/technical-design.md) |
| Siren Manager design | [Siren Manager](features/plugin-siren-manager/technical-design.md) |
| Entity system design | [Entity System](features/entity-system/wip-technical-design.md) |
| World / map / worldspace design | [World Architecture](features/world-architecture/wip-technical-design.md) |
| Save and load design | [Save/Load](features/save-load/wip-technical-design.md) |
| Interior activation design | [Interior System](features/interior-system/wip-technical-design.md) |
| Development loop and gates | [Development Process](workflows/development-process.md) |
| How to write tests | [Testing Strategy](workflows/wip-testing-strategy.md) |
| C# naming and file conventions | [Coding Standards](quality/coding-standards.md) |
| Core data types and relationships | [Data Model](architecture/wip-data-model.md) |
