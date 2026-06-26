# Vehicle.VerticalFlightPhase Property

﻿Vehicle.VerticalFlightPhase Property 

|  |  |  |
| --- | --- | --- |
| VehicleVerticalFlightPhase Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the vertical flight phase. This adjusts the thruster angle on VTOL enabled planes.

Note that the game will interppolate this property to the value of [DesiredVerticalFlightPhase](P_Rage_Vehicle_DesiredVerticalFlightPhase.htm).

To have the plane remain at the specified value, set both properties to the same value.

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
public float VerticalFlightPhase { get; set; }
```

```
Public Property VerticalFlightPhase As Single
	Get
	Set
```

```
public:
property float VerticalFlightPhase {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
A value between 0.0f and 1.0f, indicating the vertical flight phase.

Remarks

This instance must represent a VTOL enabled plane.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.