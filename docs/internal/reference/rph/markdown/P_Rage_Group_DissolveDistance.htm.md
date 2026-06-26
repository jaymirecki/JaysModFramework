# Group.DissolveDistance Property

﻿Group.DissolveDistance Property 

|  |  |  |
| --- | --- | --- |
| GroupDissolveDistance Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets the distance, in meters, at which members will automatically be removed from the group.

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
public float DissolveDistance { set; }
```

```
Public WriteOnly Property DissolveDistance As Single
	Set
```

```
public:
property float DissolveDistance {
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The distance, in meters, at which members will automatically be removed from the group.

Remarks

The default value is 30 meters.

See Also

#### Reference

[Group Class](T_Rage_Group.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.