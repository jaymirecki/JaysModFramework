# Vehicle.CurrentGear Property

﻿Vehicle.CurrentGear Property 

|  |  |  |
| --- | --- | --- |
| VehicleCurrentGear Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the current gear of this vehicle.

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
public byte CurrentGear { get; }
```

```
Public ReadOnly Property CurrentGear As Byte
	Get
```

```
public:
property unsigned char CurrentGear {
	unsigned char get ();
}
```

#### Property Value

Type: [Byte](http://msdn2.microsoft.com/en-us/library/yyb1w04y)  
The current gear of this vehicle. Must be between 1 and 6, inclusive.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.