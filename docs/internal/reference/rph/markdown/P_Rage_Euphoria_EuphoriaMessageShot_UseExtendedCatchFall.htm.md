# EuphoriaMessageShot.UseExtendedCatchFall Property

﻿EuphoriaMessageShot.UseExtendedCatchFall Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotUseExtendedCatchFall Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Keep the character active instead of relaxing at the end of the catch fall.

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
[EuphoriaParameterAttribute("useExtendedCatchFall", Type = typeof(bool), 
	DefaultValue = false)]
public bool UseExtendedCatchFall { get; set; }
```

```
<EuphoriaParameterAttribute("useExtendedCatchFall", Type := GetType(Boolean), 
	DefaultValue := false)>
Public Property UseExtendedCatchFall As Boolean
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"useExtendedCatchFall", Type = typeof(bool), 
	DefaultValue = false)]
property bool UseExtendedCatchFall {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.UseExtendedCatchFall"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.