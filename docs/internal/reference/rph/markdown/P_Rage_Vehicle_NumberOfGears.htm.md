# Vehicle.NumberOfGears Property

﻿Vehicle.NumberOfGears Property 

|  |  |  |
| --- | --- | --- |
| VehicleNumberOfGears Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the number of gears this vehicle has.

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
public byte NumberOfGears { get; set; }
```

```
Public Property NumberOfGears As Byte
	Get
	Set
```

```
public:
property unsigned char NumberOfGears {
	unsigned char get ();
	void set (unsigned char value);
}
```

#### Property Value

Type: [Byte](http://msdn2.microsoft.com/en-us/library/yyb1w04y)  
The number of gears this vehicle has. Must be between 1 and 6, inclusive.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.