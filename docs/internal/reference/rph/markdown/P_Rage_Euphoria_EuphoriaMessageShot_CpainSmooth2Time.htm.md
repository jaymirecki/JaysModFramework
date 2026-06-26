# EuphoriaMessageShot.CpainSmooth2Time Property

﻿EuphoriaMessageShot.CpainSmooth2Time Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotCpainSmooth2Time Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Conscious pain duration ramping from zero to cpainMag/cpainTwistMag.

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
[EuphoriaParameterAttribute("cpainSmooth2Time", Type = typeof(float), 
	DefaultValue = 0.2f, MinimumValue = 0f, MaximumValue = 10f)]
public float CpainSmooth2Time { get; set; }
```

```
<EuphoriaParameterAttribute("cpainSmooth2Time", Type := GetType(Single), 
	DefaultValue := 0.2F, MinimumValue := 0F, MaximumValue := 10F)>
Public Property CpainSmooth2Time As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"cpainSmooth2Time", Type = typeof(float), 
	DefaultValue = 0.2f, MinimumValue = 0f, MaximumValue = 10f)]
property float CpainSmooth2Time {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.CpainSmooth2Time"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.