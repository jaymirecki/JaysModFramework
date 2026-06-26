# World.GetAllWeapons Method

﻿World.GetAllWeapons Method 

|  |  |  |
| --- | --- | --- |
| WorldGetAllWeapons Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets all [Weapon](T_Rage_Weapon.htm)s currently in the game world.

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
public static Weapon[] GetAllWeapons()
```

```
Public Shared Function GetAllWeapons As Weapon()
```

```
public:
static array<Weapon^>^ GetAllWeapons()
```

#### Return Value

Type: [Weapon](T_Rage_Weapon.htm)  
An array of all [Ped](T_Rage_Ped.htm)s currently in the game world.

Remarks

This method only returns valid instances, so it is not necessary to validate the peds before calling their members, unless the fiber it was called on has yielded since the call.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.