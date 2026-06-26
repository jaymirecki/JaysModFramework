# EuphoriaMessageShot.NeckStiffness Property

﻿EuphoriaMessageShot.NeckStiffness Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotNeckStiffness Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Stiffness of neck.

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
[EuphoriaParameterAttribute("neckStiffness", Type = typeof(float), 
	DefaultValue = 14f, MinimumValue = 3f, MaximumValue = 16f)]
public float NeckStiffness { get; set; }
```

```
<EuphoriaParameterAttribute("neckStiffness", Type := GetType(Single), 
	DefaultValue := 14F, MinimumValue := 3F, MaximumValue := 16F)>
Public Property NeckStiffness As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"neckStiffness", Type = typeof(float), 
	DefaultValue = 14f, MinimumValue = 3f, MaximumValue = 16f)]
property float NeckStiffness {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.NeckStiffness"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.