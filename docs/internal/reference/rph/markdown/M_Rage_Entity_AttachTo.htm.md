# Entity.AttachTo Method

﻿Entity.AttachTo Method 

|  |  |  |
| --- | --- | --- |
| EntityAttachTo Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Attaches [Entity](T_Rage_Entity.htm) to another [Entity](T_Rage_Entity.htm).

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
public void AttachTo(
	Entity entity,
	int boneIndex,
	Vector3 offset,
	Rotator rotation
)
```

```
Public Sub AttachTo ( 
	entity As Entity,
	boneIndex As Integer,
	offset As Vector3,
	rotation As Rotator
)
```

```
public:
void AttachTo(
	Entity^ entity, 
	int boneIndex, 
	Vector3 offset, 
	Rotator rotation
)
```

#### Parameters

entity
:   Type: [RageEntity](T_Rage_Entity.htm)  
    The [Entity](T_Rage_Entity.htm) to attach this [Entity](T_Rage_Entity.htm) to.

boneIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index of the bone on the target [Entity](T_Rage_Entity.htm) to attach this [Entity](T_Rage_Entity.htm) to.

offset
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The offset in local space.

rotation
:   Type: [RageRotator](T_Rage_Rotator.htm)  
    The rotational offset in local space.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.