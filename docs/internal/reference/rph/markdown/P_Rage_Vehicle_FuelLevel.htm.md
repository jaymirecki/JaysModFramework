# Vehicle.FuelLevel Property

﻿Vehicle.FuelLevel Property 

|  |  |  |
| --- | --- | --- |
| VehicleFuelLevel Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the amount of fuel in this vehicle.

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
public float FuelLevel { get; set; }
```

```
Public Property FuelLevel As Single
	Get
	Set
```

```
public:
property float FuelLevel {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The amount of fuel in this vehicle.

Remarks

When the amount of fuel is below 6.5f, the vehicle will start misbehaving.

When the amount of fuel reaches 0.0f, the engine will die.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.