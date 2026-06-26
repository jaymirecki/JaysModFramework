# EuphoriaMessageShot.InitialWeaknessRampDuration Property

﻿EuphoriaMessageShot.InitialWeaknessRampDuration Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotInitialWeaknessRampDuration Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Duration of the ramp to bring the character's upper body stiffness back to normal levels.

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
[EuphoriaParameterAttribute("initialWeaknessRampDuration", Type = typeof(float), 
	DefaultValue = 0.4f, MinimumValue = 0f, MaximumValue = 10f)]
public float InitialWeaknessRampDuration { get; set; }
```

```
<EuphoriaParameterAttribute("initialWeaknessRampDuration", Type := GetType(Single), 
	DefaultValue := 0.4F, MinimumValue := 0F, MaximumValue := 10F)>
Public Property InitialWeaknessRampDuration As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"initialWeaknessRampDuration", Type = typeof(float), 
	DefaultValue = 0.4f, MinimumValue = 0f, MaximumValue = 10f)]
property float InitialWeaknessRampDuration {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.InitialWeaknessRampDuration"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.