# Vehicle.HandlingData Property

﻿Vehicle.HandlingData Property 

|  |  |  |
| --- | --- | --- |
| VehicleHandlingData Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the handling data associated with this vehicle.

Note, that this is a reference to the global handling data for this type of vehicle, and changing it, will change the handling data of all vehicles of this type.

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
public HandlingData HandlingData { get; set; }
```

```
Public Property HandlingData As HandlingData
	Get
	Set
```

```
public:
property HandlingData^ HandlingData {
	HandlingData^ get ();
	void set (HandlingData^ value);
}
```

#### Property Value

Type: [HandlingData](T_Rage_HandlingData.htm)  
The handling data.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.