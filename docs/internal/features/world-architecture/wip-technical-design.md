---
type: technical-design
feature: world-architecture
status: planned
related:
  - entity-system
  - interior-system
  - save-load
---

# World Architecture — Technical Design

## Hierarchy

```
Worldspace
  └── Maps (one or more)
        ├── Required Interiors (by InteriorId enum)
        ├── Props
        ├── Peds (map-local)
        └── Vehicles (map-local)
```

## Worldspaces

A worldspace represents a **contiguous fictional region** the player can travel across without loading screens.

Examples: San Andreas, Cayo Perico, Liberty City/Alderney (re-dressed via props and IPLs), Vice City.

**Key design principle**: worldspace is a _fictional geography concept_, not a technical map-loading concept. An "Alderney" worldspace might use the standard San Andreas GTA map geometry, dressed differently via props, IPLs, and ambient config. The worldspace definition describes the fiction; the map/prop/interior system handles the technical realization.

```csharp
public class WorldspaceDefinition
{
    public string Id { get; set; }
    public string DisplayName { get; set; }
    public GtaMapRegion BaseMapRegion { get; set; }  // SanAndreas, CayoPerico, NorthYankton
    public List<string> MapIds { get; set; }
    public WorldspaceAmbientConfig Ambient { get; set; }
    public List<TransitionPointDefinition> TransitionPoints { get; set; }
    public WorldspaceTravelRestrictions TravelRestrictions { get; set; }
}
```

## Maps

A map is a specific location or scene within a worldspace. Maps are defined entirely in XML.

```xml
<Map id="police_hq" displayName="Mission Row Police HQ"
     spawnX="428.0" spawnY="-982.0" spawnZ="30.7">
  <RequiredInteriors>
    <Interior ref="PoliceStation_MissionRow" />
  </RequiredInteriors>
  <Props>
    <Prop model="prop_cs_police_radio" x="432.1" y="-980.3" z="30.7" />
  </Props>
  <Peds>
    <Ped model="mp_m_freemode_01" tag="Desk_Sergeant" outfit="police_standard" />
  </Peds>
  <Vehicles>
    <!-- map-local vehicles -->
  </Vehicles>
</Map>
```

**Load order**: required interiors are activated before entities are spawned, because entities may depend on the interior geometry existing.

## Transition Points

Transition points connect worldspaces. Each has two sides (entry/exit) that reference each other by ID.

### Trigger Types

| Type | Description |
|---|---|
| Proximity zone | Player enters a defined radius |
| Map edge crossing | Direction-based; used for aircraft |
| Interaction point | Player interacts with a specific object or ped |

### Transition Types

| Type | Description |
|---|---|
| Fade out/in | Screen fades to black; world swaps; fades back in |
| Tunnel | Darkness masks the transition mid-tunnel |
| Seamless air | Map edge crossing for aircraft; no visible cut |
| Loading screen | Explicit loading screen displayed |

### Travel Restrictions

Transitions can restrict passage based on:
- Allowed travel methods (foot, road, air, sea).
- Save flags (quest progression gates).
- Inventory items (e.g. a ticket or pass).

## Entity Handling at Map Load

1. Activate required interiors (via `InteriorFactory`).
2. Register map-local entities with the `EntityRegistry`.
3. Call `SpawnAll()` (or let `TickManager` evaluate conditions and spawn on the next tick).

## Open Questions

### Entity Handoff Across Transitions

When the player transitions between worldspaces:
- The player's owned vehicle presumably travels with them.
- Companion peds may need an explicit "call to worldspace" behavior rather than automatic transfer.
- Design TBD.

### Ambient Config Transitions

Does weather/ambient change immediately on worldspace transition, or gradually? Design TBD.

### Worldspace Streaming

Maps likely need to activate and deactivate based on player proximity rather than all loading at once when a worldspace is entered. Streaming boundaries and activation radius design TBD.

## Related Documentation

- [Entity System — Technical Design](../entity-system/wip-technical-design.md)
- [Interior System — Technical Design](../interior-system/wip-technical-design.md)
- [Save/Load — Technical Design](../save-load/wip-technical-design.md)
- [ADR-0002: Interiors Not Data-Driven](../../architecture/decisions/adr-0002-interiors-not-data-driven.md)
