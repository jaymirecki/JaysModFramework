# EuphoriaMessageShot.BodyStiffness Property

﻿EuphoriaMessageShot.BodyStiffness Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotBodyStiffness Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Stiffness of body. Feeds through to roll\_up.

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
[EuphoriaParameterAttribute("bodyStiffness", Type = typeof(float), 
	DefaultValue = 11f, MinimumValue = 6f, MaximumValue = 16f)]
public float BodyStiffness { get; set; }
```

```
<EuphoriaParameterAttribute("bodyStiffness", Type := GetType(Single), 
	DefaultValue := 11F, MinimumValue := 6F, MaximumValue := 16F)>
Public Property BodyStiffness As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"bodyStiffness", Type = typeof(float), 
	DefaultValue = 11f, MinimumValue = 6f, MaximumValue = 16f)]
property float BodyStiffness {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.BodyStiffness"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.