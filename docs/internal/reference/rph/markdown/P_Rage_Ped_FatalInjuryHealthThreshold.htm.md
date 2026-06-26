# Ped.FatalInjuryHealthThreshold Property

﻿Ped.FatalInjuryHealthThreshold Property 

|  |  |  |
| --- | --- | --- |
| PedFatalInjuryHealthThreshold Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the fatal injury health threshold for this ped. A ped is considered dead when its health drops below this value.

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
public float FatalInjuryHealthThreshold { get; set; }
```

```
Public Property FatalInjuryHealthThreshold As Single
	Get
	Set
```

```
public:
property float FatalInjuryHealthThreshold {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The fatal injury health threshold. Should be below [MaxHealth](P_Rage_Entity_MaxHealth.htm).

Remarks

Note on player controlled peds: One of the game scripts will kill the player when their health drops below 100, regardless of this setting.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.