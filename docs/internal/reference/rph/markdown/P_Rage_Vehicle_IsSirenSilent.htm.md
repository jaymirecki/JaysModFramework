# Vehicle.IsSirenSilent Property

﻿Vehicle.IsSirenSilent Property 

|  |  |  |
| --- | --- | --- |
| VehicleIsSirenSilent Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets a value indicating whether the siren is silent.

If this vehicle is not an emergency vehicle, the method will have no effect.

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
public bool IsSirenSilent { get; set; }
```

```
Public Property IsSirenSilent As Boolean
	Get
	Set
```

```
public:
property bool IsSirenSilent {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if the siren is silent; otherwise, false

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.