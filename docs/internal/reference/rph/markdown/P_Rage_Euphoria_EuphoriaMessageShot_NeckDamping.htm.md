# EuphoriaMessageShot.NeckDamping Property

﻿EuphoriaMessageShot.NeckDamping Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotNeckDamping Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Damping of neck.

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
[EuphoriaParameterAttribute("neckDamping", Type = typeof(float), DefaultValue = 1f, 
	MinimumValue = 0.1f, MaximumValue = 2f)]
public float NeckDamping { get; set; }
```

```
<EuphoriaParameterAttribute("neckDamping", Type := GetType(Single), 
	DefaultValue := 1F, MinimumValue := 0.1F, MaximumValue := 2F)>
Public Property NeckDamping As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"neckDamping", Type = typeof(float), 
	DefaultValue = 1f, MinimumValue = 0.1f, MaximumValue = 2f)]
property float NeckDamping {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.NeckDamping"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.