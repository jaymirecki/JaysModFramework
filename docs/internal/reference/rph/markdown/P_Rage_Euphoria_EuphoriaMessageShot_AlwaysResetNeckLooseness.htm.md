# EuphoriaMessageShot.AlwaysResetNeckLooseness Property

﻿EuphoriaMessageShot.AlwaysResetNeckLooseness Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotAlwaysResetNeckLooseness Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Neck looseness always reset on shotNewBullet even if previous looseness ramp still running.

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
[EuphoriaParameterAttribute("alwaysResetNeckLooseness", Type = typeof(bool), 
	DefaultValue = true)]
public bool AlwaysResetNeckLooseness { get; set; }
```

```
<EuphoriaParameterAttribute("alwaysResetNeckLooseness", Type := GetType(Boolean), 
	DefaultValue := true)>
Public Property AlwaysResetNeckLooseness As Boolean
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"alwaysResetNeckLooseness", Type = typeof(bool), 
	DefaultValue = true)]
property bool AlwaysResetNeckLooseness {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.AlwaysResetNeckLooseness"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.