JMF creates and manages it's own version of an interaction menu.
It doesn't seem possible to overwrite the native interaction menu, so we must create a new menu that activates on a different control.
The interaction menu could be implemented as a plugin, but it might also be so core to the framework that it shouldn't be considered a plugin.
The interaction menu contains some top-level options:
1. Debug - only available if the debugging is enabled, contains debug options like showing the current position, logging the current model, etc.
2. Plugins - a submenu that lists all available plugins in alphabetical order. Each plugin is itself a submenu that contains the settings for the plugin: whether it's enabled/disabled and any additional settings defined by the plugin
3. Plugin-defined top-level options - plugins (and any code really), likely in their onactivate function, can add menu items via something like `interactionmenu.add`. The order of these menu items should be consistent regardless of the order of plugin interaction, so they should either be alphabetized or have a priority weighting that the plugins can set.
4. New/Save/Load game - these should be in a submenu on the interaction menu, allows managing game state persistence.

At some point it would be nice to implement our own menu system, but to get off the ground we should use the LemonUI package.