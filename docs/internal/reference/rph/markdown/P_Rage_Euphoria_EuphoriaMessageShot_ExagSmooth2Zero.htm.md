# EuphoriaMessageShot.ExagSmooth2Zero Property

﻿EuphoriaMessageShot.ExagSmooth2Zero Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotExagSmooth2Zero Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Exaggerate bullet duration ramping to zero after exagDuration.

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
[EuphoriaParameterAttribute("exagSmooth2Zero", Type = typeof(float), 
	DefaultValue = 0f, MinimumValue = 0f, MaximumValue = 10f)]
public float ExagSmooth2Zero { get; set; }
```

```
<EuphoriaParameterAttribute("exagSmooth2Zero", Type := GetType(Single), 
	DefaultValue := 0F, MinimumValue := 0F, MaximumValue := 10F)>
Public Property ExagSmooth2Zero As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"exagSmooth2Zero", Type = typeof(float), 
	DefaultValue = 0f, MinimumValue = 0f, MaximumValue = 10f)]
property float ExagSmooth2Zero {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.ExagSmooth2Zero"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.