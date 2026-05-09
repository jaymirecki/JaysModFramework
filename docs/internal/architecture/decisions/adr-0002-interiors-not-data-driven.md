---
type: adr
status: accepted
---

# ADR-0002: Interiors Are Code, Not Config

## Context

GTA V interiors vary dramatically in how they are activated:

- Some use MLO (Map Level of Detail) loading.
- Some use IPL (Interior Placement List) activation with specific flags.
- Some require entity set manipulation.
- Some require custom activation sequences in a specific order.
- Some (e.g. the Casino) have unique, non-generalizable activation logic.

A data-driven approach would require either an extremely complex config schema that still can't cover all edge cases, or a lowest-common-denominator schema that can't correctly activate unusual interiors.

## Decision

Interiors are **code, not config**.

- Each interior is identified by an `InteriorId` enum value.
- Each interior's activation logic is fully encapsulated in a handler class implementing `IInteriorHandler`.
- Map XML files reference interiors by enum name only — activation details never appear in content files.

```csharp
public enum InteriorId
{
    HighEndApartment_1,
    Casino,
    PoliceStation_MissionRow,
    // ...
}

public interface IInteriorHandler
{
    Vector3 EntryPoint { get; }
    void Activate();
    void Deactivate();
}
```

An `InteriorFactory` maps each `InteriorId` to its handler. Common cases use a generic `MloInterior` or `IplInterior` handler parameterized with the appropriate values. Edge cases (e.g. Casino) get a dedicated handler class.

**Adding a new interior**: add enum entry → implement/configure handler → register in factory. Explicit, checklist-driven, no schema design required.

## Consequences

### Positive

- Each interior's activation is fully correct and fully isolated.
- Edge cases are first-class, not workarounds.
- Content files remain clean — they reference `PoliceStation_MissionRow`, not a blob of activation flags.
- Adding a simple interior (MLO or IPL) takes ~5 lines of code using the generic handler.

### Negative

- Adding any new interior, even a simple one, requires a code change and a build.
- Interior definitions are scattered across handler classes, not browsable in a single config file.

## Alternatives Considered

### Data-Driven Interior Config

Rejected. The variety of activation mechanisms makes a complete schema impractical. Any schema that covers common cases leaves edge cases broken; any schema that covers all cases becomes too complex to maintain.

## Related Documentation

- [Interior System — Technical Design](../../features/interior-system/wip-technical-design.md)
- [World Architecture — Technical Design](../../features/world-architecture/wip-technical-design.md)
