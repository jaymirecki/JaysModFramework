# EuphoriaMessageShot.CpainDuration Property

﻿EuphoriaMessageShot.CpainDuration Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotCpainDuration Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Conscious pain duration at cpainMag/cpainTwistMag after cpainSmooth2Time.

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
[EuphoriaParameterAttribute("cpainDuration", Type = typeof(float), 
	DefaultValue = 0f, MinimumValue = 0f, MaximumValue = 10f)]
public float CpainDuration { get; set; }
```

```
<EuphoriaParameterAttribute("cpainDuration", Type := GetType(Single), 
	DefaultValue := 0F, MinimumValue := 0F, MaximumValue := 10F)>
Public Property CpainDuration As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"cpainDuration", Type = typeof(float), 
	DefaultValue = 0f, MinimumValue = 0f, MaximumValue = 10f)]
property float CpainDuration {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.CpainDuration"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.