# World.EnumerateVehicles Method

﻿World.EnumerateVehicles Method 

|  |  |  |
| --- | --- | --- |
| WorldEnumerateVehicles Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets an enumerable collection of the [Vehicle](T_Rage_Vehicle.htm)s currently in the game world.

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
public static IEnumerable<Vehicle> EnumerateVehicles()
```

```
Public Shared Function EnumerateVehicles As IEnumerable(Of Vehicle)
```

```
public:
static IEnumerable<Vehicle^>^ EnumerateVehicles()
```

#### Return Value

Type: [IEnumerable](http://msdn2.microsoft.com/en-us/library/9eekhta0)[Vehicle](T_Rage_Vehicle.htm)  
An enumerable collection of the [Vehicle](T_Rage_Vehicle.htm)s currently in the game world.

Remarks

Using this over [GetAllVehicles](M_Rage_World_GetAllVehicles.htm) can be faster because the iteration can be interrupted without retrieving all vehicles; however, if the collection is changed, enumeration may not continue.This method only returns valid instances, so it is not necessary to validate the peds before calling their members, unless the fiber it was called on has yielded since the call.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.