# VehicleWheel.IsSteeringWheel Property

﻿VehicleWheel.IsSteeringWheel Property 

|  |  |  |
| --- | --- | --- |
| VehicleWheelIsSteeringWheel Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets a value indicating whether this wheel is used for turning the vehicle.

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
public bool IsSteeringWheel { get; set; }
```

```
Public Property IsSteeringWheel As Boolean
	Get
	Set
```

```
public:
property bool IsSteeringWheel {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this wheel is used for turning the vehicle; otherwise false.

Remarks

Which way the wheel turns is determined by the sign of AngleLimit.

See Also

#### Reference

[VehicleWheel Class](T_Rage_VehicleWheel.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.