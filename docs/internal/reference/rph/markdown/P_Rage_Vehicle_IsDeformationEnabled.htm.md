# Vehicle.IsDeformationEnabled Property

﻿Vehicle.IsDeformationEnabled Property 

|  |  |  |
| --- | --- | --- |
| VehicleIsDeformationEnabled Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets a value indicating whether deformation is enabled for this vehicle.

If deformation is disabled, the car will still take damage, but will not become deform.

Lights, fenders, etc. will still take damage.

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
public bool IsDeformationEnabled { get; set; }
```

```
Public Property IsDeformationEnabled As Boolean
	Get
	Set
```

```
public:
property bool IsDeformationEnabled {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if deformation is enabled for this vehicle; otherwise false.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.