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

Content files loaded at runtime: maps, vehicle definitions, ped models, outfits, etc. See [ADR-0004](decisions/adr-0004-one-file-per-content-item.md) for the one-file-per-content-item convention.

## Saves/

Player save files. See [Save/Load — Technical Design](../features/save-load/wip-technical-design.md).

## Templates/

Template saves used when starting a new game. Exact structure TBD.

## Related Documentation

- [Settings — Requirements](../features/settings/requirements.md)
- [Logger — Requirements](../features/logger/requirements.md)
- [ADR-0004: One File Per Content Item](decisions/adr-0004-one-file-per-content-item.md)
- [Save/Load — Technical Design](../features/save-load/wip-technical-design.md)
