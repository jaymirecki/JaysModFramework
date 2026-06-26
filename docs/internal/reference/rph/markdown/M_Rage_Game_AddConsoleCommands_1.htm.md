# Game.AddConsoleCommands Method (MethodInfo[])

﻿Game.AddConsoleCommands Method (MethodInfo[])

|  |  |  |
| --- | --- | --- |
| GameAddConsoleCommands Method (MethodInfo) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Adds console commands from the specified methods.

**Namespace:**
 [Rage](N_Rage.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
public static void AddConsoleCommands(
	MethodInfo[] methods
)
```

```
Public Shared Sub AddConsoleCommands ( 
	methods As MethodInfo()
)
```

```
public:
static void AddConsoleCommands(
	array<MethodInfo^>^ methods
)
```

#### Parameters

methods
:   Type: [System.ReflectionMethodInfo](http://msdn2.microsoft.com/en-us/library/1wa35kh5)  
    The methods to add as console commands. The methods must be static and marked with the [!:Rage::Attributes::ConsoleCommand] attribute.

Remarks

Methods already added within the calling plugin, will not be added again.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[AddConsoleCommands Overload](Overload_Rage_Game_AddConsoleCommands.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.