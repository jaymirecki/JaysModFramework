# VehicleWheel.Temperature Property

﻿VehicleWheel.Temperature Property 

|  |  |  |
| --- | --- | --- |
| VehicleWheelTemperature Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets a value representing the temperature of this wheel.

If the temperature gets too high, the tire will burst.

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
public float Temperature { get; set; }
```

```
Public Property Temperature As Single
	Get
	Set
```

```
public:
property float Temperature {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The floating point value between 0.0f and 59.0f representing the temperature of this wheel.

See Also

#### Reference

[VehicleWheel Class](T_Rage_VehicleWheel.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.