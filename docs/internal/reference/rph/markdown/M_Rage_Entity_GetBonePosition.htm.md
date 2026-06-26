# Entity.GetBonePosition Method (Int32)

﻿Entity.GetBonePosition Method (Int32)

|  |  |  |
| --- | --- | --- |
| EntityGetBonePosition Method (Int32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the position of the specified bone, in world space.

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
public Vector3 GetBonePosition(
	int boneIndex
)
```

```
Public Function GetBonePosition ( 
	boneIndex As Integer
) As Vector3
```

```
public:
Vector3 GetBonePosition(
	int boneIndex
)
```

#### Parameters

boneIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index of the bone.

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
A [Vector3](T_Rage_Vector3.htm) representing the position of the specified bone, in world space.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[GetBonePosition Overload](Overload_Rage_Entity_GetBonePosition.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.