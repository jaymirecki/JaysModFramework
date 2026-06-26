# Entity.Quaternion Property

﻿Entity.Quaternion Property 

|  |  |  |
| --- | --- | --- |
| EntityQuaternion Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

**Note: This API is now obsolete.**

Gets or sets the quaternion of this instance.

**Namespace:**
 [Rage](N_Rage.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
[ObsoleteAttribute("Use Orientation instead. This property will be removed in a future update.", 
	true)]
public virtual Quaternion Quaternion { get; set; }
```

```
<ObsoleteAttribute("Use Orientation instead. This property will be removed in a future update.", 
	true)>
Public Overridable Property Quaternion As Quaternion
	Get
	Set
```

```
public:
[ObsoleteAttribute(L"Use Orientation instead. This property will be removed in a future update.", 
	true)]
virtual property Quaternion Quaternion {
	Quaternion get ();
	void set (Quaternion value);
}
```

#### Property Value

Type: [Quaternion](T_Rage_Quaternion.htm)  

[Missing <value> documentation for "P:Rage.Entity.Quaternion"]

#### Implements

[IRotatableQuaternion](P_Rage_IRotatable_Quaternion.htm)  

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.