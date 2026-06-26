# Vehicle.FuelTankHealth Property

﻿Vehicle.FuelTankHealth Property 

|  |  |  |
| --- | --- | --- |
| VehicleFuelTankHealth Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the health of the car's fuel tank.

The fuel tank health ranges between 0.0f and 1000.0f.

When the fuel tank health is below 700.0f, fuel will start leaking.

When the fuel tank health is below 50.0f, the engine will be unable to start.

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
public float FuelTankHealth { get; set; }
```

```
Public Property FuelTankHealth As Single
	Get
	Set
```

```
public:
property float FuelTankHealth {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The health of the car's fuel tank.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.