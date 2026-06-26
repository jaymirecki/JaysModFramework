# Entity.IsCollisionProof Property

﻿Entity.IsCollisionProof Property 

|  |  |  |
| --- | --- | --- |
| EntityIsCollisionProof Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets a value indicating whether this entity can take damage from collisions.

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
public bool IsCollisionProof { get; set; }
```

```
Public Property IsCollisionProof As Boolean
	Get
	Set
```

```
public:
property bool IsCollisionProof {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this entity can take damage from collisions; otherwise, false.

Remarks

Collision involves any kind of impact to the entity, whether getting hit by vehicles or falling from high altitudes.

Melee attacks, however, are not considered collisions.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.