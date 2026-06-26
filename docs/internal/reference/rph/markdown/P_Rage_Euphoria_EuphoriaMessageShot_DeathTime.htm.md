# EuphoriaMessageShot.DeathTime Property

﻿EuphoriaMessageShot.DeathTime Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotDeathTime Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Time to death (HACK for underwater). If -ve don't ever die.

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
[EuphoriaParameterAttribute("deathTime", Type = typeof(float), DefaultValue = -1f, 
	MinimumValue = -1f, MaximumValue = 1000f)]
public float DeathTime { get; set; }
```

```
<EuphoriaParameterAttribute("deathTime", Type := GetType(Single), 
	DefaultValue := -1F, MinimumValue := -1F, MaximumValue := 1000F)>
Public Property DeathTime As Single
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"deathTime", Type = typeof(float), DefaultValue = -1f, 
	MinimumValue = -1f, MaximumValue = 1000f)]
property float DeathTime {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.DeathTime"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.