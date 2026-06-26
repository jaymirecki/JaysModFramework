# EuphoriaMessageShot.FallingReaction Property

﻿EuphoriaMessageShot.FallingReaction Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotFallingReaction Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

0=Rollup, 1=Catchfall, 2=rollDownStairs, 3=smartFall.

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
[EuphoriaParameterAttribute("fallingReaction", Type = typeof(int), DefaultValue = 0, 
	MinimumValue = 0, MaximumValue = 3)]
public int FallingReaction { get; set; }
```

```
<EuphoriaParameterAttribute("fallingReaction", Type := GetType(Integer), 
	DefaultValue := 0, MinimumValue := 0, MaximumValue := 3)>
Public Property FallingReaction As Integer
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"fallingReaction", Type = typeof(int), 
	DefaultValue = 0, MinimumValue = 0, MaximumValue = 3)]
property int FallingReaction {
	int get ();
	void set (int value);
}
```

#### Property Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.FallingReaction"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.