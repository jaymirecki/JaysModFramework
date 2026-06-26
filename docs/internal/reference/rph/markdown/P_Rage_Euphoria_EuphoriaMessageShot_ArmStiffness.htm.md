# EuphoriaMessageShot.ArmStiffness Property

﻿EuphoriaMessageShot.ArmStiffness Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotArmStiffness Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Arm stiffness.

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
[EuphoriaParameterAttribute("armStiffness", Type = typeof(float), 
	DefaultValue = 10f, MinimumValue = 6f, MaximumValue = 16f)]
public float ArmStiffness { get; set; }
```

```
<EuphoriaParameterAttribute("armStiffness", Type := GetType(Single), 
	DefaultValue := 10F, MinimumValue := 6F, MaximumValue := 16F)>
Public Property ArmStiffness As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"armStiffness", Type = typeof(float), 
	DefaultValue = 10f, MinimumValue = 6f, MaximumValue = 16f)]
property float ArmStiffness {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.ArmStiffness"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.