# Vehicle.IsBig Property

﻿Vehicle.IsBig Property 

|  |  |  |
| --- | --- | --- |
| VehicleIsBig Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a value indicating whether this is a big vehicle, like busses, trucks, semis, etc.

Does not return true for certain special vehicles like CUTTER.

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
public bool IsBig { get; }
```

```
Public ReadOnly Property IsBig As Boolean
	Get
```

```
public:
property bool IsBig {
	bool get ();
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this is a big vehicle; otherwise, false.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.