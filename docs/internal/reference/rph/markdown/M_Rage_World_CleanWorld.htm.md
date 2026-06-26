# World.CleanWorld Method

﻿World.CleanWorld Method 

|  |  |  |
| --- | --- | --- |
| WorldCleanWorld Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Cleans the world.

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
public static void CleanWorld(
	bool livingPeds,
	bool deadPeds,
	bool livingVehicles,
	bool deadVehicles,
	bool persistentEntities,
	bool reloadWorld
)
```

```
Public Shared Sub CleanWorld ( 
	livingPeds As Boolean,
	deadPeds As Boolean,
	livingVehicles As Boolean,
	deadVehicles As Boolean,
	persistentEntities As Boolean,
	reloadWorld As Boolean
)
```

```
public:
static void CleanWorld(
	bool livingPeds, 
	bool deadPeds, 
	bool livingVehicles, 
	bool deadVehicles, 
	bool persistentEntities, 
	bool reloadWorld
)
```

#### Parameters

livingPeds
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If set to true, living [Ped](T_Rage_Ped.htm)s will be removed.

deadPeds
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If set to true, dead [Ped](T_Rage_Ped.htm)s will be removed.

livingVehicles
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If set to true, living [Vehicle](T_Rage_Vehicle.htm)s will be removed.

deadVehicles
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If set to true, destroyed [Vehicle](T_Rage_Vehicle.htm)s will be removed.

persistentEntities
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If set to true, persistent entities will be removed.

reloadWorld
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If set to true, the world will be reloaded.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.