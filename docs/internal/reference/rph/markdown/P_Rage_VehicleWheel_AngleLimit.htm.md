# VehicleWheel.AngleLimit Property

﻿VehicleWheel.AngleLimit Property 

|  |  |  |
| --- | --- | --- |
| VehicleWheelAngleLimit Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the maximum number of degrees this wheel can turn when steering inwards.

This value also affects the maximum angle when turning outwards, however this value will be scaled to be a little larger.

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
public float AngleLimit { get; set; }
```

```
Public Property AngleLimit As Single
	Get
	Set
```

```
public:
property float AngleLimit {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The maximum number of degrees this wheel can turn when steering inwards.

See Also

#### Reference

[VehicleWheel Class](T_Rage_VehicleWheel.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.