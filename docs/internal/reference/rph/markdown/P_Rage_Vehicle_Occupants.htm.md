# Vehicle.Occupants Property

﻿Vehicle.Occupants Property 

|  |  |  |
| --- | --- | --- |
| VehicleOccupants Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets all peds currently in this vehicle.

Includes the driver.

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
public Ped[] Occupants { get; }
```

```
Public ReadOnly Property Occupants As Ped()
	Get
```

```
public:
property array<Ped^>^ Occupants {
	array<Ped^>^ get ();
}
```

#### Property Value

Type: [Ped](T_Rage_Ped.htm)  
An array of type [Ped](T_Rage_Ped.htm), containing all the [Ped](T_Rage_Ped.htm)s currently in this vehicle. Including the driver.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.