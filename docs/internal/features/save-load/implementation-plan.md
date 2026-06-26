---
type: implementation-plan
feature: save-load
status: in-progress
---

# Save/Load — Implementation Plan

## Overview

Implementation proceeds in two phases: **Load** (Phase 1), then **Save** (Phase 2). Validation uses in-game smoke tests triggered from the smoke test menu.

---

## MVP Scope

The initial implementation covers player and world state only. Entity and cell persistence are deferred until the world/entity systems are implemented.

**In Scope:**
- Load and save player state: position, heading, model, health, armor
- Load and save world state: weather, datetime
- Simple serialization to/from XML

**Out of Scope (deferred):**
- Entity persistence (vehicles, peds, props)
- Cell tracking and reset
- Save flags and spawn conditions
- Interior activation
- Outfit and inventory persistence
- Worldspace transitions
- Save slot management and rotation

---

## Phase 1: Load Implementation

### 1.1 Core Classes and Interfaces

**New classes:**
- `GameState` — top-level coordinator for load/save
- `WorldState` — holds world properties (weather, datetime)
- `PlayerState` — holds player ped snapshot (position, heading, model, health, armor)

**Modifications:**
- `Player` class: add `SetModel(string)` method (already may have `SetPosition`, `SetHeading`, etc.)

**Serializers:**
- `WorldStateSerializer` — read/write `world.xml`
- `PlayerStateSerializer` — read/write `player.xml`

### 1.2 Load Flow Implementation

1. **Deserialize from disk**
   - Read `world.xml` → `WorldState` (weather, datetime)
   - Read `player.xml` → `PlayerState` (position, heading, model, health, armor)

2. **Apply world state**
   - `_world.SetWeather(worldState.Weather)`
   - `_world.SetDateTime(worldState.DateTime)`

3. **Apply player state to live player ped**
   - `_world.Player.SetModel(playerState.Model)` ← must happen first (replaces native ped)
   - `_world.Player.SetPosition(playerState.Position)`
   - `_world.Player.SetHeading(playerState.Heading)`
   - `_world.Player.SetHealth(playerState.Health)`
   - `_world.Player.SetArmor(playerState.Armor)`

### 1.3 Classes and Methods Required

| Class | New/Modified | Methods | Notes |
|---|---|---|---|
| `GameState` | New | `Load(string path)`, `Save(string path)` | Orchestrates load/save flow |
| `WorldState` | New | — | Data class; weather, datetime |
| `PlayerState` | New | — | Data class; position, heading, model, health, armor |
| `WorldStateSerializer` | New | `Deserialize(path)`, `Serialize(path)` | XML I/O for `world.xml` |
| `PlayerStateSerializer` | New | `Deserialize(path)`, `Serialize(path)` | XML I/O for `player.xml` |
| `Player` | Modified | `SetModel(string)` | Apply player model on load |

---

## Phase 2: Save Implementation

### 2.1 Save Flow

1. Read live player ped state (position, heading, model, health, armor)
2. Read live world state (weather, datetime)
3. Serialize `WorldState` → `world.xml`
4. Serialize `PlayerState` → `player.xml`

### 2.2 New Classes

None required for MVP. (Save slot management deferred.)

---

## Smoke Tests

Smoke tests are triggered from an in-game menu and validate the load/save flow without requiring a full mission or progression.

### Test Data

**Smoke Test Save:**
- Location: `JMF/Saves/SmokeTest_1/`
- Contents:
  - `world.xml`: stormy weather, 12:00 (day 1, month 1, year 2012)
  - `player.xml`: model `trevor`, position (428, -982, 30.7), heading 270°, health 200, armor 100

### Test Scenarios

#### Test 1: Load Smoke Save
**Trigger:** Menu → "Smoke Tests" → "Load Save"
1. `GameState.Load("JMF/Saves/SmokeTest_1")`
2. **Verify:**
   - Player position matches save (428, -982, 30.7)
   - Player model is trevor
   - Player health is 200, armor is 100
   - World weather is stormy
   - World time is 12:00 (noon), January 1, 2012
3. **Output:** Log message "Smoke Test: Load passed" if all checks succeed

#### Test 2: Save and Verify Against Known Values
**Trigger:** Menu → "Smoke Tests" → "Load, Save, and Verify"
1. Load the smoke test save: `GameState.Load("JMF/Saves/SmokeTest_1")`
2. Save the loaded state to a temporary location: `GameState.Save("JMF/Saves/SmokeTest_Tmp")`
3. Load the temporary save: `GameState.Load("JMF/Saves/SmokeTest_Tmp")`
4. **Verify against known values:**
   - Player position is (428, -982, 30.7)
   - Player model is trevor
   - Player health is 200, armor is 100
   - World weather is stormy
   - World time is 12:00, January 1, 2012
5. **Output:** Log message "Smoke Test: Save and round-trip passed" if all checks succeed

---

## Implementation Checklist

### Phase 1: Load

- [ ] Create `WorldState` data class (weather, datetime)
- [ ] Create `PlayerState` data class (position, heading, model, health, armor)
- [ ] Create `WorldStateSerializer` — read/deserialize `world.xml`
- [ ] Create `PlayerStateSerializer` — read/deserialize `player.xml`
- [ ] Implement `Player.SetModel(string)` method
- [ ] Verify `Player` has position, heading, health, armor setters
- [ ] Create `GameState` class with `Load(string path)` method
- [ ] Implement `GameState.Load()` flow (deserialize → apply world → apply player)
- [ ] Create smoke test save file in `JMF/Saves/SmokeTest_1/`
- [ ] Create smoke test menu with "Load Save" trigger
- [ ] Implement smoke test verification (Test 1: Load Smoke Save)

### Phase 2: Save

- [ ] Create `WorldStateSerializer` — write/serialize `world.xml`
- [ ] Create `PlayerStateSerializer` — write/serialize `player.xml`
- [ ] Implement `GameState.Save(string path)` method
- [ ] Implement `GameState.Save()` flow (read world → read player → serialize)
- [ ] Implement smoke test "Load, Save, and Verify" trigger
- [ ] Implement smoke test verification (Test 2: Save and Verify Against Known Values)

---

## Related Documentation

- [Save/Load — Technical Design](wip-technical-design.md)
- [Entity System — Technical Design](../entity-system/wip-technical-design.md)
- [World Architecture — Technical Design](../world-architecture/wip-technical-design.md)
