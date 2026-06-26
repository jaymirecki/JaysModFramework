# Entity.ApplyForce Method

﻿Entity.ApplyForce Method 

|  |  |  |
| --- | --- | --- |
| EntityApplyForce Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Applies force to this instance.

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
public void ApplyForce(
	Vector3 force,
	Vector3 offset,
	bool isForceRelative,
	bool isOffsetRelative
)
```

```
Public Sub ApplyForce ( 
	force As Vector3,
	offset As Vector3,
	isForceRelative As Boolean,
	isOffsetRelative As Boolean
)
```

```
public:
void ApplyForce(
	Vector3 force, 
	Vector3 offset, 
	bool isForceRelative, 
	bool isOffsetRelative
)
```

#### Parameters

force
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The direction and magnitude of the force to apply.

offset
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The offset to apply the force at.

isForceRelative
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If set to true, the force will be applied relative to the entity; otherwise, it'll be applied relative to the world.

isOffsetRelative
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If set to true, the offset is relative to the entity; otherwise, the offset is a world position.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.