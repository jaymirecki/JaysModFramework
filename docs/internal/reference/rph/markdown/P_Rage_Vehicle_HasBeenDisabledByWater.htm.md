# Vehicle.HasBeenDisabledByWater Property

﻿Vehicle.HasBeenDisabledByWater Property 

|  |  |  |
| --- | --- | --- |
| VehicleHasBeenDisabledByWater Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets whether this vehicle has been disabled by water. If this flag is set, the vehicle can't drive and the player can't enter it.
When this flag has been set manually, it is reset when exiting the vehicle, so it should be set when not in the vehicle.

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
public bool HasBeenDisabledByWater { get; set; }
```

```
Public Property HasBeenDisabledByWater As Boolean
	Get
	Set
```

```
public:
property bool HasBeenDisabledByWater {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
Whether this instance has been damaged by water.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.