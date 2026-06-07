---
type: architecture
status: active
---

# File Structure

## Game Folder Layout

```
GTA V/
├── Plugins/                      RPH plugin DLLs (managed by RPH)
└── JMF/                          JaysModFramework root folder
    ├── config.xml                Framework and plugin settings
    ├── JaysModFramework.log      Default log file location
    ├── Data/                     Content files (maps, vehicles, outfits, etc.)
    ├── Saves/                    Player save files
    └── Templates/                Template saves for new game creation (TBD)
```

The `JMF` folder and `config.xml` are created with defaults on first run if they do not exist.

## config.xml

Stores all framework and plugin settings. The root element is `<JmfConfig>`.

```xml
<JmfConfig>
  <Framework>
    <DebugMode>false</DebugMode>
    <MenuOpenControl>InteractionMenu</MenuOpenControl>
  </Framework>
  <Logger>
    <LogLocation>JMF/JaysModFramework.log</LogLocation>
    <LogLevel>Info</LogLevel>
    <NotificationLevel>Error</NotificationLevel>
  </Logger>
  <Plugins>
    <Plugin name="Sirens">
      <DefaultActivatedStatus>true</DefaultActivatedStatus>
      <ControllerButton>...</ControllerButton>
      <KeyboardKey>...</KeyboardKey>
    </Plugin>
  </Plugins>
</JmfConfig>
```

Plugin settings are keyed by `IPlugin.Name`. Property names in the XML match the plugin's `IPluginSettings` subclass property names.

## Data/

Content files loaded at runtime: maps, vehicle definitions, ped models, outfits, etc. Each content type gets its own subdirectory; each item gets its own file. See [ADR-0004](decisions/adr-0004-one-file-per-content-item.md) for the one-file-per-content-item convention.

```
Data/
├── Maps/
│   ├── MissionRowPD.xml
│   └── AirportTerminal.xml
├── Models/
│   └── Vehicles/
│       ├── Blista.xml
│       ├── Adder.xml
│       └── ...
├── Worldspaces/
│   ├── SanAndreas.xml
│   └── CayoPerico.xml
└── Outfits/
    └── ...
```

### Data/Models/Vehicles/

One file per vehicle model definition. The vehicle class is stored inside the XML, not encoded in the directory structure, so all models live in a single flat folder regardless of class.

```xml
<!-- Data/Models/Vehicles/Blista.xml -->
<VehicleModelDefinition>
  <Name>Blista</Name>
  <ModelName>blista</ModelName>
  <Class>Compacts</Class>
</VehicleModelDefinition>
```

`VehicleModelRepository` scans this directory at startup and provides `GetByClass(string className)` and a sorted `Classes` list. Content mods add files to the same directory; the framework detects duplicate `ModelName` values at load time and raises an error.

## Saves/

Player save files. See [Save/Load — Technical Design](../features/save-load/wip-technical-design.md).

## Templates/

Template saves used when starting a new game. Exact structure TBD.

## Related Documentation

- [Settings — Requirements](../features/settings/requirements.md)
- [Logger — Requirements](../features/logger/requirements.md)
- [ADR-0004: One File Per Content Item](decisions/adr-0004-one-file-per-content-item.md)
- [Save/Load — Technical Design](../features/save-load/wip-technical-design.md)
