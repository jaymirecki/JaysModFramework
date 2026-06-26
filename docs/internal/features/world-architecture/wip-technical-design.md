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

## Vocabulary

| Term | Category | Description |
|---|---|---|
| **Map** | Data | A definition in `Data/Maps/` describing required interiors, submaps, and entities to spawn. Has no knowledge of where it is placed in the world. |
| **Cell** | State | A runtime instance of a Map. Defined inline in a `WorldspaceDefinition`. Multiple Cells may reference the same Map definition. |
| **Overworld Cell** | — | A Cell activated by player proximity. `SpawnPoint` and `PresenceRadius` are on the Cell definition. |
| **Interior Cell** | — | A Cell activated by an explicit trigger (door, portal). No `PresenceRadius`. |

---

## Hierarchy

```
Worldspace
  └── Cells (inline in WorldspaceDefinition)
        ├── MapId → Map definition (Data/Maps/)
        │     ├── Required Interiors (by InteriorId enum)
        │     ├── Submaps (references to other Map definitions)
        │     ├── Props
        │     ├── Peds
        │     └── Vehicles
        ├── SpawnPoint      (overworld: presence zone center; player placement on first visit)
        └── PresenceRadius  (overworld cells only; null for interior cells)
```

---

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
    public List<CellDefinition> Cells { get; set; }
    public WorldspaceAmbientConfig Ambient { get; set; }
    public List<TransitionPointDefinition> TransitionPoints { get; set; }
    public WorldspaceTravelRestrictions TravelRestrictions { get; set; }
}

public class CellDefinition
{
    public string Id { get; set; }
    public string MapId { get; set; }

    // Overworld cells only
    public Vector3? SpawnPoint { get; set; }    // center of presence zone; player placement on first visit
    public float? PresenceRadius { get; set; }  // null for interior cells
}
```

---

## Maps

A Map is a data definition in `Data/Maps/`. It describes required interiors, entities to spawn, and submaps. It has no knowledge of where it is instantiated in the world — that is the Cell's responsibility.

```xml
<Map id="police_hq" displayName="Mission Row Police HQ">
  <ResetPeriodDays>3</ResetPeriodDays>
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

`ResetPeriodDays` is the number of in-game days after the player last visited this Cell before its `CellOwned` entities are reset. See [Cell State and Reset Lifecycle](#cell-state-and-reset-lifecycle).

---

## Submaps

A Map may reference other Maps as submaps. Submaps allow entity sets to be reused across Maps — for example, a standard police patrol (two patrol cars, one officer) defined once and included in multiple police station Maps.

```xml
<Map id="paleto_police_exterior">
  <ResetPeriodDays>3</ResetPeriodDays>
  <Submaps>
    <Submap ref="police_patrol_standard" />
  </Submaps>
  <Vehicles>
    <Vehicle model="police" ... />
  </Vehicles>
</Map>
```

`Map.Load(Framework, Cell)` expands submaps depth-first. All entities spawned during expansion — regardless of which Map definition they originate from — are tagged to the top-level Cell. `BornInCellId` is always the top-level Cell's Id; there is no concept of "born in a submap."

---

## Overworld Cell Activation

Overworld Cells are activated and deactivated by the `TickManager` based on player proximity to `Cell.SpawnPoint`:

- Player enters `PresenceRadius` → `Map.Load(Framework, Cell)` is called.
- Player exits `PresenceRadius` → cell unload sequence runs.

Interior Cells are activated by explicit triggers (doors, portals) rather than proximity. Their `SpawnPoint` is the player placement position on entry; their `PresenceRadius` is not set.

---

## Entity Handling at Map Load and Unload

### Load sequence

`Map.Load(Framework, Cell)` is called when a Cell activates. The `Cell` reference is threaded through all submap expansion.

1. Activate required interiors via `InteriorFactory`. Interior geometry must exist before entities are spawned.
2. Determine load type:
   - **First load or post-reset** (`Cell.LastVisited == null`): register `CellOwned` entities from Map XML and all submaps into `EntityRegistry`, tagging each with `BornInCellId = Cell.Id` and `Custody = CellOwned`.
   - **Reload** (`Cell.LastVisited != null`, entities already registered from a prior visit): skip registration.
3. Spawn all registered entities with `BornInCellId == Cell.Id` (and unregistered `Persistent`/`Unclaimed` entities whose saved `CurrentCellId` matches this Cell) whose `SpawnCondition` is met, in dependency order: Vehicles → Peds → Props.

### Unload sequence

1. `SyncLiveToPersistent()` on all spawned entities assigned to this Cell.
2. Despawn those entities (remove native handles; entities remain registered).
3. Set `Cell.LastVisited = CurrentInGameTime`.

---

## Cell State and Reset Lifecycle

### Cell State

```csharp
public class CellState
{
    public string CellId { get; set; }
    public GameDateTime? LastVisited { get; set; }  // null means never visited or already reset
}
```

`LastVisited` is the sole indicator of a cell's reset status:
- **Non-null**: cell has been visited and has not yet reset. The nightly check uses this to decide when to trigger a reset.
- **Null**: cell has never been visited, or has already been reset. The cell load sequence uses this to decide whether to recreate entities from Map XML.

`LastVisited` is set when the cell unloads:
- **Interior cells**: when the interior deactivates.
- **Overworld cells**: when the player exits `PresenceRadius`.

`LastVisited` is persisted across sessions via `CellVisitInfo` in `world.xml` (see [Save/Load — Technical Design](../save-load/wip-technical-design.md)). This ensures the reset timer continues from where it left off — a cell visited on session day 3 with a 5-day reset period will still reset on day 8, even if the player quit and returned. Templates contain no Cell visit data.

### Nightly Reset Check

Every in-game night, the `TickManager` evaluates all Cells with a known `LastVisited`:

```
for each Cell where LastVisited != null && Cell is not currently active:
  if CurrentInGameTime - Cell.LastVisited >= Map.ResetPeriodDays:
    deregister all entities where BornInCellId == Cell.Id && Custody == CellOwned
    Cell.LastVisited = null   // null signals first-load on next activation; dropped from CellVisits on next save
```

### What Reset Does and Does Not Affect

| Custody | Cell reset behaviour |
|---|---|
| `CellOwned` | Deregistered. Recreated from Map XML on next cell load. |
| `Unclaimed` | Not affected. Entity persists independently with its own cleanup clock. |
| `Persistent` | Not affected. Never cleaned up by the framework. |
| `Transient` | Not registered; irrelevant to reset. |

---

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

---

## Open Questions

### Entity Handoff Across Transitions

When the player transitions between worldspaces:
- The player's owned vehicle presumably travels with them.
- Companion peds may need an explicit "call to worldspace" behavior rather than automatic transfer.
- Design TBD.

### Ambient Config Transitions

Does weather/ambient change immediately on worldspace transition, or gradually? Design TBD.

### Worldspace Streaming

Cells likely need to activate and deactivate based on player proximity rather than all loading at once when a worldspace is entered. Streaming boundaries and activation radius design TBD.

---

## Related Documentation

- [Entity System — Technical Design](../entity-system/wip-technical-design.md)
- [Interior System — Technical Design](../interior-system/wip-technical-design.md)
- [Save/Load — Technical Design](../save-load/wip-technical-design.md)
- [ADR-0002: Interiors Not Data-Driven](../../architecture/decisions/adr-0002-interiors-not-data-driven.md)
