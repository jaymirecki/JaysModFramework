---
type: adr
status: accepted
---

# ADR-0003: Engine-Free Core for GTA VI Portability

## Context

GTA VI is expected to eventually support modding. If the framework is tightly coupled to RPH and GTA V natives, porting to GTA VI would require a full rewrite. The framework's value — its systems, save model, world architecture, entity model, and plugin ecosystem — would not transfer.

## Decision

The `Core` project has **zero references** to RPH or GTA dlls.

All GTA-specific interactions are routed through abstraction interfaces defined in `Core`. RPH implementations of those interfaces live in the separate `Rph` project.

```
JaysModFramework.Core       // interfaces + business logic; no RPH/GTA references
JaysModFramework.Rph        // RPH implementations of Core interfaces
JaysModFramework.Tests      // references Core only; runs against fakes
Plugins/*                   // reference Core; use injected interfaces
```

The abstraction layer is the **porting boundary**. To port to GTA VI:
1. Write `JaysModFramework.GtaVI` implementing Core interfaces against the GTA VI native layer.
2. Core, tests, and all plugins are unmodified.

## Consequences

### Positive

- The framework's systems, entity model, and plugin ecosystem survive a platform transition.
- All business logic is fully unit-testable without a running game (see [Testing Strategy](../../workflows/wip-testing-strategy.md)).
- SHVDN support could be added later by implementing Core interfaces — without touching Core or any plugin.

### Negative

- Every GTA interaction must be abstracted, even simple ones. This adds interface overhead compared to calling natives directly.
- The interface layer must be designed carefully — leaking GTA-specific concepts through the interface defeats the purpose.

## Alternatives Considered

### Direct RPH/Native Coupling

Rejected. This would make testing impossible and GTA VI porting a full rewrite.

### Thin Wrapper Layer (no interface inversion)

Rejected. A wrapper that isn't behind an interface still ties tests and all consumers to the GTA binary. Dependency inversion is required for the testing strategy to work.

## Related Documentation

- [Tech Stack](../wip-tech-stack.md)
- [Testing Strategy](../../workflows/wip-testing-strategy.md)
- [ADR-0001: RPH vs SHVDN](adr-0001-rph-vs-shvdn.md)
