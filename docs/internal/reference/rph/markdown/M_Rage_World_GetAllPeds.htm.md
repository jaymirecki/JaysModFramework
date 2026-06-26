# World.GetAllPeds Method

﻿World.GetAllPeds Method 

|  |  |  |
| --- | --- | --- |
| WorldGetAllPeds Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets all [Ped](T_Rage_Ped.htm)s currently in the game world.

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
public static Ped[] GetAllPeds()
```

```
Public Shared Function GetAllPeds As Ped()
```

```
public:
static array<Ped^>^ GetAllPeds()
```

#### Return Value

Type: [Ped](T_Rage_Ped.htm)  
An array of all [Ped](T_Rage_Ped.htm)s currently in the game world.

Remarks

This method only returns valid instances, so it is not necessary to validate the peds before calling their members, unless the fiber it was called on has yielded since the call.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.