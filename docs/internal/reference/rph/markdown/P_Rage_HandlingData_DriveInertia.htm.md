# HandlingData.DriveInertia Property

﻿HandlingData.DriveInertia Property 

|  |  |  |
| --- | --- | --- |
| HandlingDataDriveInertia Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the drive inertia. A lower drive inertia slows engine acceleration. If you want a vehicle with high torque but slow acceleration (e.g. a truck) lower the driver inertia but specify a high drive force.

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
public float DriveInertia { get; set; }
```

```
Public Property DriveInertia As Single
	Get
	Set
```

```
public:
property float DriveInertia {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The drive inertia.

See Also

#### Reference

[HandlingData Class](T_Rage_HandlingData.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.