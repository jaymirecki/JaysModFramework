# HandlingData.PercentSubmerged Property

﻿HandlingData.PercentSubmerged Property 

|  |  |  |
| --- | --- | --- |
| HandlingDataPercentSubmerged Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the drag coefficient on the RAGE physics archetype of the vehicle (proportional to velocity squared). Increase to simulate aerodynamic drag.

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
public float PercentSubmerged { get; set; }
```

```
Public Property PercentSubmerged As Single
	Get
	Set
```

```
public:
property float PercentSubmerged {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The percent submerged, in range 10 to 120.

See Also

#### Reference

[HandlingData Class](T_Rage_HandlingData.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.