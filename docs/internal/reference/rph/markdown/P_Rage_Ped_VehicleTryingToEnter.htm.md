# Ped.VehicleTryingToEnter Property

﻿Ped.VehicleTryingToEnter Property 

|  |  |  |
| --- | --- | --- |
| PedVehicleTryingToEnter Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the [Vehicle](T_Rage_Vehicle.htm) this [Ped](T_Rage_Ped.htm) is currently trying to enter.

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
public Vehicle VehicleTryingToEnter { get; }
```

```
Public ReadOnly Property VehicleTryingToEnter As Vehicle
	Get
```

```
public:
property Vehicle^ VehicleTryingToEnter {
	Vehicle^ get ();
}
```

#### Property Value

Type: [Vehicle](T_Rage_Vehicle.htm)  
The [Vehicle](T_Rage_Vehicle.htm) this [Ped](T_Rage_Ped.htm) is currently trying to enter; or null if this [Ped](T_Rage_Ped.htm) is not trying to enter a [Vehicle](T_Rage_Vehicle.htm).

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.