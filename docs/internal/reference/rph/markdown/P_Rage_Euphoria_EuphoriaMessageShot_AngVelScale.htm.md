# EuphoriaMessageShot.AngVelScale Property

﻿EuphoriaMessageShot.AngVelScale Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotAngVelScale Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

How much to scale the angular velocity coming in from animation of a part if it is in angVelScaleMask (otherwise scale by 1.0).

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
[EuphoriaParameterAttribute("angVelScale", Type = typeof(float), DefaultValue = 1f, 
	MinimumValue = 0f, MaximumValue = 1f)]
public float AngVelScale { get; set; }
```

```
<EuphoriaParameterAttribute("angVelScale", Type := GetType(Single), 
	DefaultValue := 1F, MinimumValue := 0F, MaximumValue := 1F)>
Public Property AngVelScale As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"angVelScale", Type = typeof(float), 
	DefaultValue = 1f, MinimumValue = 0f, MaximumValue = 1f)]
property float AngVelScale {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.AngVelScale"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.