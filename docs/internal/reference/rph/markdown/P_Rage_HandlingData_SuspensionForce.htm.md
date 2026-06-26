# HandlingData.SuspensionForce Property

﻿HandlingData.SuspensionForce Property 

|  |  |  |
| --- | --- | --- |
| HandlingDataSuspensionForce Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the suspension force. Lower limit for zero force at full extension is calculated using (1.0f / (force \* number of wheels)).

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
public float SuspensionForce { get; set; }
```

```
Public Property SuspensionForce As Single
	Get
	Set
```

```
public:
property float SuspensionForce {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The suspension force.

See Also

#### Reference

[HandlingData Class](T_Rage_HandlingData.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.