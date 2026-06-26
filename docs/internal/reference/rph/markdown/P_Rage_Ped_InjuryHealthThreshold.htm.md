# Ped.InjuryHealthThreshold Property

﻿Ped.InjuryHealthThreshold Property 

|  |  |  |
| --- | --- | --- |
| PedInjuryHealthThreshold Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the injury health threshold for this ped. A ped is considered injured when its health drops below this value.

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
public float InjuryHealthThreshold { get; set; }
```

```
Public Property InjuryHealthThreshold As Single
	Get
	Set
```

```
public:
property float InjuryHealthThreshold {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The injury health threshold. Should be above 0 and below [MaxHealth](P_Rage_Entity_MaxHealth.htm).

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.