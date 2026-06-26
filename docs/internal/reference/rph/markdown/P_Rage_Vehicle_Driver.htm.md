# Vehicle.Driver Property

﻿Vehicle.Driver Property 

|  |  |  |
| --- | --- | --- |
| VehicleDriver Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the [Ped](T_Rage_Ped.htm) on the driver's seat of this vehicle.

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
public Ped Driver { get; }
```

```
Public ReadOnly Property Driver As Ped
	Get
```

```
public:
property Ped^ Driver {
	Ped^ get ();
}
```

#### Property Value

Type: [Ped](T_Rage_Ped.htm)  
If the vehicle has a driver, returns the driver; otherwise, returns null.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.