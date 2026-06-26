# EuphoriaMessageShot.AlwaysResetLooseness Property

﻿EuphoriaMessageShot.AlwaysResetLooseness Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotAlwaysResetLooseness Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Looseness always reset on shotNewBullet even if previous looseness ramp still running. Except for the neck which has it's own ramp.

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
[EuphoriaParameterAttribute("alwaysResetLooseness", Type = typeof(bool), 
	DefaultValue = true)]
public bool AlwaysResetLooseness { get; set; }
```

```
<EuphoriaParameterAttribute("alwaysResetLooseness", Type := GetType(Boolean), 
	DefaultValue := true)>
Public Property AlwaysResetLooseness As Boolean
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"alwaysResetLooseness", Type = typeof(bool), 
	DefaultValue = true)]
property bool AlwaysResetLooseness {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.AlwaysResetLooseness"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.