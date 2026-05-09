# Internal Documentation Strategy

This document defines the recommended internal documentation structure for the repository. The goal is to create a scalable, discoverable, and AI-friendly documentation system that provides clear context to both human contributors and coding agents.

---

# Guiding Principles

## 1. Co-locate Related Context

Keep related information together.

For example:

* Product requirements
* Technical designs
* Decisions
* Tasks

…should live within the same feature directory.

## 2. Separate Stable vs Evolving Knowledge

Examples:

* Product vision and personas change infrequently
* Feature implementation details evolve continuously

Organize documentation accordingly.

## 3. Optimize for Partial Reading

Contributors and coding agents will rarely read all documentation.

Each document should:

* Stand on its own
* Clearly link to related documents
* Contain concise summaries

## 4. Prefer Many Focused Documents

Avoid massive monolithic specifications.

Prefer:

* Small focused markdown files
* Feature-scoped documentation
* Explicit cross-linking

## 5. Make Relationships Explicit

Cross-link aggressively between:

* Features
* Personas
* Architecture
* Requirements
* Decisions

Treat documentation as a graph of knowledge rather than a strict hierarchy.

---

# Recommended Directory Structure

```text
/docs
  /internal
    /README.md

    /product
      /vision.md
      /strategy.md
      /personas/
        persona-<name>.md
      /user-journeys/
        journey-<name>.md
      /glossary.md

    /requirements
      /core-functional-requirements.md
      /non-functional-requirements.md
      /constraints.md

    /architecture
      /overview.md
      /system-context.md
      /data-model.md
      /api-design.md
      /tech-stack.md
      /patterns/
        pattern-<name>.md
      /decisions/
        adr-0001-<title>.md

    /features
      /<feature-name>/
        /README.md
        /product-requirements.md
        /technical-design.md
        /tasks.md
        /decisions.md
        /assets/
          <images, diagrams>

    /workflows
      /development-process.md
      /branching-strategy.md
      /release-process.md
      /testing-strategy.md

    /quality
      /coding-standards.md
      /review-guidelines.md
      /definition-of-done.md

    /agents
      /overview.md
      /context-map.md
      /rules.md
      /prompts/
        <task-specific prompts>

    /onboarding
      /quick-start.md
      /repo-tour.md
      /faq.md

    /assets
      /images
      /diagrams
```

---

# Section Descriptions

# `/product`

High-level product understanding and long-term context.

## Purpose

Defines:

* Why the product exists
* Who it serves
* Strategic direction
* Shared terminology

## Recommended Files

### `vision.md`

Defines:

* Product mission
* Long-term goals
* Core value proposition

### `strategy.md`

Defines:

* Product priorities
* Tradeoffs
* Business or platform direction

### `/personas`

One file per persona.

Each persona should include:

* Goals
* Motivations
* Frustrations
* Technical sophistication
* Common workflows

### `/user-journeys`

End-to-end workflows from the user perspective.

These are particularly valuable for:

* Feature design
* UX decisions
* Coding agents implementing workflows

### `glossary.md`

Defines shared terminology.

Use this to standardize:

* Business terms
* Technical terms
* Domain concepts
* Acronyms

---

# `/requirements`

Repository-wide requirements and constraints.

## Purpose

Defines rules and expectations that apply across multiple systems or features.

## Recommended Files

### `core-functional-requirements.md`

Defines fundamental product capabilities.

### `non-functional-requirements.md`

Defines:

* Performance expectations
* Reliability requirements
* Scalability goals
* Security expectations
* Accessibility standards

### `constraints.md`

Defines:

* Technical constraints
* Platform constraints
* Business limitations
* Regulatory considerations

---

# `/architecture`

System-wide technical understanding.

## Purpose

Documents how the system is structured and why major technical decisions were made.

## Recommended Files

### `overview.md`

High-level architecture overview.

Should include:

* Major systems
* Boundaries
* Data flow diagrams

### `system-context.md`

Defines:

* External systems
* Integrations
* Service boundaries
* Deployment relationships

### `data-model.md`

Documents:

* Core entities
* Relationships
* Ownership
* Persistence strategy

### `api-design.md`

Defines:

* API patterns
* Contracts
* Conventions
* Error handling expectations

### `tech-stack.md`

Documents:

* Core technologies
* Major libraries
* Infrastructure choices
* Rationale for selections

### `/patterns`

Reusable engineering patterns.

Examples:

* State management
* Caching
* Event handling
* Repository patterns
* Authentication flows

### `/decisions`

Architecture Decision Records (ADRs).

Recommended ADR format:

```md
# Title

## Context

## Decision

## Consequences

## Alternatives Considered
```

---

# `/features`

Feature-centric implementation documentation.

## Purpose

This is the primary working area for ongoing feature development.

Each feature should contain all relevant product and technical context in a single location.

## Recommended Structure

```text
/features/<feature-name>/
  README.md
  product-requirements.md
  technical-design.md
  tasks.md
  decisions.md
  /assets/
```

## Recommended Files

### `README.md`

Feature overview.

Should include:

* Summary
* Current status
* Related systems
* Links to supporting documents

### `product-requirements.md`

Defines:

* User stories
* Acceptance criteria
* Business rules
* Edge cases

### `technical-design.md`

Defines:

* Architecture
* Data flow
* APIs
* State management
* Persistence
* Technical tradeoffs

### `tasks.md`

Implementation checklist.

Can include:

* Milestones
* Subtasks
* Validation steps
* Release considerations

### `decisions.md`

Feature-scoped implementation decisions.

Use for lightweight decisions that do not warrant a repository-wide ADR.

### `/assets`

Feature-specific assets.

Examples:

* Screenshots
* Wireframes
* Diagrams
* Design mockups

---

# `/workflows`

Team and engineering process documentation.

## Purpose

Defines how contributors are expected to work within the repository.

## Recommended Files

### `development-process.md`

Defines:

* Development lifecycle
* Workflow expectations
* Feature implementation flow

### `branching-strategy.md`

Defines:

* Branch naming
* Merge expectations
* Release branches
* Hotfix process

### `release-process.md`

Defines:

* Deployment workflow
* Release validation
* Rollback process

### `testing-strategy.md`

Defines:

* Testing philosophy
* Required test coverage
* Integration testing expectations
* End-to-end testing approach

---

# `/quality`

Engineering quality standards.

## Purpose

Defines what “good” looks like for the repository.

## Recommended Files

### `coding-standards.md`

Defines:

* Naming conventions
* File organization
* Language-specific standards
* Documentation expectations

### `review-guidelines.md`

Defines:

* PR expectations
* Review checklist
* Common review criteria

### `definition-of-done.md`

Defines completion requirements.

Examples:

* Tests added
* Documentation updated
* Accessibility validated
* Performance reviewed

---

# `/agents`

AI and automation guidance.

## Purpose

Provides structured guidance for coding agents and automation workflows.

## Recommended Files

### `overview.md`

Defines:

* Expected agent responsibilities
* Supported workflows
* Scope limitations

### `context-map.md`

Defines where information lives.

Example:

```text
Feature requirements → /features/*
Architecture → /architecture/*
Personas → /product/personas/*
Repository rules → /quality/*
```

### `rules.md`

Hard repository constraints.

Examples:

* Do not change API contracts without updating API documentation
* All new features require tests
* Feature changes must update documentation

### `/prompts`

Reusable prompts for:

* PR reviews
* Test generation
* Feature implementation
* Refactoring
* Bug investigation

---

# `/onboarding`

New contributor guidance.

## Purpose

Reduce onboarding time for both humans and coding agents.

## Recommended Files

### `quick-start.md`

Defines:

* Environment setup
* Common commands
* First-run instructions

### `repo-tour.md`

Explains:

* Repository structure
* Important systems
* Where key logic lives

### `faq.md`

Common questions and troubleshooting guidance.

---

# `/assets`

Shared repository-wide assets.

## Purpose

Stores reusable visual documentation assets.

Examples:

* Shared diagrams
* Global screenshots
* Branding references

Feature-specific assets should remain within their corresponding feature directory whenever possible.

---

# Cross-Linking Requirements

Documentation should be heavily cross-linked.

Example:

```md
## Related Documentation

- Persona: ../../product/personas/persona-admin.md
- Architecture: ../../architecture/wip-data-model.md
- ADR: ../../architecture/decisions/adr-0003-authentication.md
```

This improves:

* Discoverability
* Contributor onboarding
* AI agent context retrieval

---

# AI-Friendly Documentation Practices

## Use Consistent Headings

Prefer predictable section names such as:

```md
## Requirements
## Architecture
## Edge Cases
## Risks
## Decisions
```

## Prefer Explicit Rules

Avoid vague guidance.

Bad:

```md
Handle errors normally.
```

Good:

```md
Return HTTP 400 for validation errors and HTTP 500 for unexpected server failures.
```

## Use Frontmatter Metadata

Recommended for machine readability.

Example:

```md
---
type: technical-design
feature: authentication
status: active
related:
  - api-design
  - user-management
---
```

---

# Recommended Prioritization

Suggested order for creating documentation in a new repository:

1. `/onboarding`
2. `/architecture`
3. `/quality`
4. `/product`
5. `/requirements`
6. `/features`
7. `/agents`
8. `/workflows`

---

# Summary

This documentation structure is designed to function as:

* A knowledge base
* A decision log
* A contributor onboarding system
* A machine-readable context graph for coding agents

The most important principles are:

* Feature-centric organization
* Strong cross-linking
* Predictable structure
* Explicit requirements
* Clear separation of stable and evolving knowledge
