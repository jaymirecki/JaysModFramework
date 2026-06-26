# EuphoriaMessageShot.AngVelScaleMask Property

﻿EuphoriaMessageShot.AngVelScaleMask Property 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShotAngVelScaleMask Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Parts to scale the initial angular velocity by angVelScale (otherwize scale by 1.0).

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
[EuphoriaParameterAttribute("angVelScaleMask", Type = typeof(string), 
	DefaultValue = "fb")]
public string AngVelScaleMask { get; set; }
```

```
<EuphoriaParameterAttribute("angVelScaleMask", Type := GetType(String), 
	DefaultValue := "fb")>
Public Property AngVelScaleMask As String
	Get
	Set
```

```
public:
[EuphoriaParameterAttribute(L"angVelScaleMask", Type = typeof(String), 
	DefaultValue = L"fb")]
property String^ AngVelScaleMask {
	String^ get ();
	void set (String^ value);
}
```

#### Property Value

Type: [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  

[Missing <value> documentation for "P:Rage.Euphoria.EuphoriaMessageShot.AngVelScaleMask"]

See Also

#### Reference

[EuphoriaMessageShot Class](T_Rage_Euphoria_EuphoriaMessageShot.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.