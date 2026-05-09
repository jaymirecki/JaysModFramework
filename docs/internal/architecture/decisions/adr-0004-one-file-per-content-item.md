---
type: adr
status: accepted
---

# ADR-0004: One File Per Content Item

## Context

Content data (worldspaces, maps, vehicle models, outfits, etc.) must be stored somewhere the framework can load it and content modders can extend it. Two obvious structures exist:

**Option A — one file per content type:**
```
Data/
  Worldspaces.xml      ← all worldspaces in one file
  Maps.xml             ← all maps in one file
  VehicleModels.xml
```

**Option B — one file per content item:**
```
Data/
  Worldspaces/
    SanAndreas.xml
    CayoPerico.xml
  Maps/
    MissionRowPD.xml
    AirportTerminal.xml
  VehicleModels/
    ...
```

The choice has direct impact on how content mods are installed and removed.

## Decision

Use **one file per content item** (Option B), with one folder per content type.

The `dist/Data/` folder in the repository contains the core content files. Content mods ship as additional files dropped into the same folder structure.

## Consequences

### Positive

**Trivial mod installation**: a content mod is a folder of XML files. Installing means copying them into `Data/`. No file needs to be opened or edited.

**Trivial mod removal**: delete the files that belong to the mod. No need to locate and excise content from a shared XML file.

**No merge conflicts between mods**: two mods adding different worldspaces each ship a separate file. They coexist without conflict as long as they don't define items with the same ID. (ID collision is still possible but is a content-level problem, not a structural one.)

**Natural discoverability**: `Data/Worldspaces/` lists exactly the worldspaces that exist. No need to open a file to see what's registered.

### Negative

**More files to load**: the framework must enumerate and load all files in each type directory rather than reading a single known file path. This is a straightforward directory scan, not a significant complexity cost.

**ID collision risk**: two mods can both ship a file called `CayoPerico.xml` and define a worldspace with the same ID. Content modders are expected to prefix their filenames and IDs with a unique mod identifier (e.g. `DesertStrikeCayoPerico.xml`). The framework detects duplicate IDs at load time and raises a clear error — it does not silently override.

## Alternatives Considered

### Option A — One File Per Content Type

Rejected. Installing a content mod requires the player to open a shared XML file and paste content into it. Removing the mod requires them to locate and delete exactly those entries. This creates a fragile, error-prone workflow that is a known frustration in other moddable games. The patching workflow described in Option B is the primary reason this decision exists.

## Naming Convention: PascalCase

Folder names and file names both use **PascalCase**.

```
Data/
  Worldspaces/
    SanAndreas.xml
    CayoPerico.xml
  Maps/
    MissionRowPD.xml
  VehicleModels/
    ...
```

### Rationale

The meaningful choice is between PascalCase and snake_case. kebab-case and camelCase are eliminated:

- **kebab-case**: hyphens have no precedent in GTA V files or C#, and are not valid in C# identifiers.
- **camelCase**: lowercase first word creates visual inconsistency at the folder level; no filesystem precedent in either ecosystem.

**GTA V's own convention** is lowercase with underscores for filenames and folders (`vehicles.meta`, `vehicle_models.ymt`, `dlc_patch/`). However, GTA V's *XML content* uses PascalCase for type names and attributes — the same split we already have. GTA V's lowercase filesystem convention applies to its own internal RPF archives, not to user-authored content in an external mod folder.

**C#'s convention** is PascalCase for types, filenames, and namespaces throughout. Our XML element and attribute names are already PascalCase (coding standards decision: match C# property names for serialization symmetry).

Introducing snake_case for content file and folder names would create a second naming convention that exists nowhere else in the project. PascalCase extends what is already established consistently.

### Mod prefix convention

Content mods must prefix their filenames and content IDs with a unique mod identifier to avoid collision with core content and other mods:

```
Data/
  Worldspaces/
    SanAndreas.xml          ← core content
    DesertStrikeSonora.xml  ← mod content, prefixed with mod name
```

The prefix should be PascalCase and meaningful enough to be globally unique (e.g. the mod's name). The framework enforces uniqueness of IDs at load time and raises an error on collision rather than silently overriding.

## Related Documentation

- [World Architecture — Technical Design](../../features/world-architecture/wip-technical-design.md)
- [Data Model](../wip-data-model.md)
- [Persona: Carla the Content Modder](../../product/personas/persona-carla-the-content-modder.md)
