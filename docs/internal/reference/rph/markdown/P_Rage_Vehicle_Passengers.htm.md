# Vehicle.Passengers Property

﻿Vehicle.Passengers Property 

|  |  |  |
| --- | --- | --- |
| VehiclePassengers Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the passengers of this vehicle.

Does not include the driver.

If you need a passenger at a specific seat index, using [GetPedOnSeat(Int32)](M_Rage_Vehicle_GetPedOnSeat.htm) is more efficient.

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
public Ped[] Passengers { get; }
```

```
Public ReadOnly Property Passengers As Ped()
	Get
```

```
public:
property array<Ped^>^ Passengers {
	array<Ped^>^ get ();
}
```

#### Property Value

Type: [Ped](T_Rage_Ped.htm)  
An array of type [Ped](T_Rage_Ped.htm), containing all the [Ped](T_Rage_Ped.htm)s currently in this vehicle as passengers. Does not include the driver.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.