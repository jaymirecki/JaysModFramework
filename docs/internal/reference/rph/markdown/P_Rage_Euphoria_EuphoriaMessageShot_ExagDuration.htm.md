# EuphoriaMessageShot.ExagDuration Property

﻿EuphoriaMessageShot.ExagDuration Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotExagDuration Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Exaggerate bullet duration (at exagMag/exagTwistMag).

**Namespace:**
 [Rage.Euphoria](N_Rage_Euphoria.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
[EuphoriaParameterAttribute("exagDuration", Type = typeof(float), 
	DefaultValue = 0f, MinimumValue = 0f, MaximumValue = 10f)]
public float ExagDuration { get; set; }
```

```
<EuphoriaParameterAttribute("exagDuration", Type := GetType(Single), 
	DefaultValue := 0F, MinimumValue := 0F, MaximumValue := 10F)>
Public Property ExagDuration As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"exagDuration", Type = typeof(float), 
	DefaultValue = 0f, MinimumValue = 0f, MaximumValue = 10f)]
property float ExagDuration {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.ExagDuration"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.