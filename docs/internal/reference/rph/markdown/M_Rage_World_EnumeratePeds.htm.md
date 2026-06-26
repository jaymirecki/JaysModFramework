# World.EnumeratePeds Method

﻿World.EnumeratePeds Method 

|  |  |  |
| --- | --- | --- |
| WorldEnumeratePeds Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets an enumerable collection of the [Ped](T_Rage_Ped.htm)s currently in the game world.

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
public static IEnumerable<Ped> EnumeratePeds()
```

```
Public Shared Function EnumeratePeds As IEnumerable(Of Ped)
```

```
public:
static IEnumerable<Ped^>^ EnumeratePeds()
```

#### Return Value

Type: [IEnumerable](http://msdn2.microsoft.com/en-us/library/9eekhta0)[Ped](T_Rage_Ped.htm)  
An enumerable collection of the [Ped](T_Rage_Ped.htm)s currently in the game world.

Remarks

Using this over [GetAllPeds](M_Rage_World_GetAllPeds.htm) can be faster because the iteration can be interrupted without retrieving all peds; however, if the collection is changed, enumeration may not continue.This method only returns valid instances, so it is not necessary to validate the peds before calling their members, unless the fiber it was called on has yielded since the call.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.