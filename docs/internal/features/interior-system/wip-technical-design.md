---
type: technical-design
feature: interior-system
status: planned
related:
  - world-architecture
  - entity-system
---

# Interior System — Technical Design

## Problem

GTA V interiors have wildly different activation requirements:

- MLO interiors: require loading the MLO asset and optionally setting entity sets.
- IPL interiors: require requesting the IPL, sometimes with specific activation flags.
- Complex interiors (Casino, Nightclub): require multi-step custom activation sequences.

No single config schema can generalize across all of these without becoming either incomplete or unmanageably complex.

## Design

Each interior is identified by an enum value and encapsulated in a handler class. Maps reference interiors by enum name only.

### InteriorId Enum

```csharp
public enum InteriorId
{
    HighEndApartment_1,
    Casino,
    PoliceStation_MissionRow,
    // add entries here when adding new interiors
}
```

### IInteriorHandler Interface

```csharp
public interface IInteriorHandler
{
    Vector3 EntryPoint { get; }
    void Activate();
    void Deactivate();
}
```

### Generic Handlers

Common cases use parameterized generic handlers:

```csharp
// For MLO-based interiors
new MloInterior(mloName: "v_int_10", entryPoint: new Vector3(...))

// For IPL-based interiors
new IplInterior(iplName: "bkr_bi_hw1_13_int", entryPoint: new Vector3(...))
```

Edge cases (e.g. Casino, Nightclub) get a dedicated handler class with the full custom activation sequence.

### InteriorFactory

```csharp
public static class InteriorFactory
{
    public static IInteriorHandler GetHandler(InteriorId id) => id switch
    {
        InteriorId.PoliceStation_MissionRow => new MloInterior("v_sheriff2", new Vector3(...)),
        InteriorId.Casino                   => new CasinoInteriorHandler(),
        // ...
    };
}
```

## Adding a New Interior

1. Add an entry to `InteriorId`.
2. Implement or configure a handler:
   - For MLO: `new MloInterior(mloName, entryPoint)`.
   - For IPL: `new IplInterior(iplName, entryPoint)`.
   - For custom: implement `IInteriorHandler`.
3. Register the handler in `InteriorFactory`.
4. Reference the enum name in the map XML.

## Activation Order

Interiors are activated **before** map entities are spawned. Entity spawning may depend on interior geometry existing (e.g. props placed inside an interior room).

Map load sequence:
1. Activate required interiors via `InteriorFactory`.
2. Register map entities with the `EntityRegistry`.
3. Spawn entities.

## Related Documentation

- [ADR-0002: Interiors Not Data-Driven](../../architecture/decisions/adr-0002-interiors-not-data-driven.md)
- [World Architecture — Technical Design](../world-architecture/wip-technical-design.md)
