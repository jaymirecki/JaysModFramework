# EuphoriaMessageShot.InitialNeckStiffness Property

﻿EuphoriaMessageShot.InitialNeckStiffness Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotInitialNeckStiffness Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Initial stiffness of neck after being shot.

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
[EuphoriaParameterAttribute("initialNeckStiffness", Type = typeof(float), 
	DefaultValue = 14f, MinimumValue = 3f, MaximumValue = 16f)]
public float InitialNeckStiffness { get; set; }
```

```
<EuphoriaParameterAttribute("initialNeckStiffness", Type := GetType(Single), 
	DefaultValue := 14F, MinimumValue := 3F, MaximumValue := 16F)>
Public Property InitialNeckStiffness As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"initialNeckStiffness", Type = typeof(float), 
	DefaultValue = 14f, MinimumValue = 3f, MaximumValue = 16f)]
property float InitialNeckStiffness {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.InitialNeckStiffness"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.