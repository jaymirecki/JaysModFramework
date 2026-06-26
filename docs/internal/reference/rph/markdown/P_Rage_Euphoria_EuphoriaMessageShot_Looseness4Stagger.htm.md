# EuphoriaMessageShot.Looseness4Stagger Property

﻿EuphoriaMessageShot.Looseness4Stagger Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotLooseness4Stagger Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

How loose the upperBody of the character is made by a newBullet if staggerFall is running (and not falling). Note atm the neck ramp values are ignored in staggerFall.

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
[EuphoriaParameterAttribute("looseness4Stagger", Type = typeof(float), 
	DefaultValue = 0f, MinimumValue = 0f, MaximumValue = 1f)]
public float Looseness4Stagger { get; set; }
```

```
<EuphoriaParameterAttribute("looseness4Stagger", Type := GetType(Single), 
	DefaultValue := 0F, MinimumValue := 0F, MaximumValue := 1F)>
Public Property Looseness4Stagger As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"looseness4Stagger", Type = typeof(float), 
	DefaultValue = 0f, MinimumValue = 0f, MaximumValue = 1f)]
property float Looseness4Stagger {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.Looseness4Stagger"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.