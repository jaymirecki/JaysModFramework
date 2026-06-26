# EuphoriaMessageShot.InitialNeckDamping Property

﻿EuphoriaMessageShot.InitialNeckDamping Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotInitialNeckDamping Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Intial damping of neck after being shot.

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
[EuphoriaParameterAttribute("initialNeckDamping", Type = typeof(float), 
	DefaultValue = 1f, MinimumValue = 0.1f, MaximumValue = 10f)]
public float InitialNeckDamping { get; set; }
```

```
<EuphoriaParameterAttribute("initialNeckDamping", Type := GetType(Single), 
	DefaultValue := 1F, MinimumValue := 0.1F, MaximumValue := 10F)>
Public Property InitialNeckDamping As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"initialNeckDamping", Type = typeof(float), 
	DefaultValue = 1f, MinimumValue = 0.1f, MaximumValue = 10f)]
property float InitialNeckDamping {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.InitialNeckDamping"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.