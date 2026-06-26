# Fire.Offset Property

﻿Fire.Offset Property 

|  |  |  |
| --- | --- | --- |
| FireOffset Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the position of this instance.

If [ParentEntity](P_Rage_Fire_ParentEntity.htm) is null, this property has the same value as [Position](P_Rage_Fire_Position.htm); the position is in world space; otherwise it is relative to the parent entity.

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
public Vector3 Offset { get; set; }
```

```
Public Property Offset As Vector3
	Get
	Set
```

```
public:
property Vector3 Offset {
	Vector3 get ();
	void set (Vector3 value);
}
```

#### Property Value

Type: [Vector3](T_Rage_Vector3.htm)  

[Missing <value> documentation for "P:Rage.Fire.Offset"]

See Also

#### Reference

[Fire Class](T_Rage_Fire.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.