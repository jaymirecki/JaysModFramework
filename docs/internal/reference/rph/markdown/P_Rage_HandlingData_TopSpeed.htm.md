# HandlingData.TopSpeed Property

﻿HandlingData.TopSpeed Property 

|  |  |  |
| --- | --- | --- |
| HandlingDataTopSpeed Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the max speed in top gear (used when configuring gears).

This value is initialized using InitialDriveMaxFlatVel in handlingdata.meta multiplied by 1.2f.

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
public float TopSpeed { get; set; }
```

```
Public Property TopSpeed As Single
	Get
	Set
```

```
public:
property float TopSpeed {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The max speed in top gear.

See Also

#### Reference

[HandlingData Class](T_Rage_HandlingData.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.