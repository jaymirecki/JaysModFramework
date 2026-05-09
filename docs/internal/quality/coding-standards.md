---
type: coding-standards
status: active
---

# Coding Standards

## Language and Runtime

C# targeting the .NET version compatible with RAGEPluginHook. All code in the repository is C#.

## Naming Conventions

Follow standard C# conventions:

| Element | Convention | Example |
|---|---|---|
| Classes, structs, enums | PascalCase | `EntityRegistry`, `SirenMode` |
| Interfaces | `I` prefix + PascalCase | `IPlugin`, `ITickable`, `IVehicle` |
| Methods | PascalCase | `SpawnAll()`, `CycleMode()` |
| Properties | PascalCase | `IsSpawned`, `CurrentMode` |
| Private fields | `_camelCase` | `_currentMode`, `_plugins` |
| Local variables | camelCase | `managedVehicle`, `spawnCondition` |
| Constants | PascalCase | `MaxSpawnDistance` |
| Enum values | PascalCase | `SirenMode.LightsOnly` |

## File Organization

- **One public type per file.** A file named `SirenManagerPlugin.cs` contains exactly the `SirenManagerPlugin` class.
- File name matches the type name exactly.
- Nested types are allowed when they are private implementation details of their containing type.

## Namespace Structure

Namespaces mirror the project and folder structure:

```
JaysModFramework.Core                   // root namespace for Core project
JaysModFramework.Core.Entities          // entity system types
JaysModFramework.Core.World             // world architecture types
JaysModFramework.Core.Plugins           // IPlugin, PluginRegistry, IFrameworkServices
JaysModFramework.Rph                    // root namespace for RPH project
JaysModFramework.Rph.Entities           // RPH entity implementations
JaysModFramework.Tests                  // root namespace for Tests project
```

## Project Isolation Rule

`JaysModFramework.Core` must have **zero references** to RPH or GTA dlls. This is a hard rule enforced by project structure. Any change that adds such a reference is rejected.

See [Testing Strategy](../workflows/wip-testing-strategy.md) and [ADR-0003](../architecture/decisions/adr-0003-gta6-portability.md).

## XML Conventions

- XML element and attribute names use PascalCase (matching C# property names for serialization symmetry).
- Required attributes must always be present; optional attributes should have documented defaults.
- Invalid XML should fail loudly at load time with a clear error message, not silently at spawn time.

## Comments

- Code should be self-documenting through good naming.
- Comments are for non-obvious constraints, workarounds, or invariants — not for explaining what the code does.
- No XML doc comments on obvious members (getters, trivial constructors).
- XML doc comments are appropriate on interface members that define contracts Pete the Plugin Modder will depend on.

## Related Documentation

- [Testing Strategy](../workflows/wip-testing-strategy.md)
- [Architecture Overview](../architecture/wip-overview.md)
- [ADR-0003: GTA VI Portability](../architecture/decisions/adr-0003-gta6-portability.md)
