# Entity.GetBoneAxes Method (Int32, Vector3, Vector3, Vector3)

﻿Entity.GetBoneAxes Method (Int32, Vector3, Vector3, Vector3)

|  |  |  |
| --- | --- | --- |
| EntityGetBoneAxes Method (Int32, Vector3, Vector3, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the axes of the specified bone. That is, three vectors pointing right, forward and up, relative to the bone's orientation.

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
public void GetBoneAxes(
	int boneIndex,
	out Vector3 right,
	out Vector3 forward,
	out Vector3 up
)
```

```
Public Sub GetBoneAxes ( 
	boneIndex As Integer,
	<OutAttribute> ByRef right As Vector3,
	<OutAttribute> ByRef forward As Vector3,
	<OutAttribute> ByRef up As Vector3
)
```

```
public:
void GetBoneAxes(
	int boneIndex, 
	[OutAttribute] Vector3% right, 
	[OutAttribute] Vector3% forward, 
	[OutAttribute] Vector3% up
)
```

#### Parameters

boneIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index of the bone.

right
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The right axis.

forward
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The forward axis.

up
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The up axis.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[GetBoneAxes Overload](Overload_Rage_Entity_GetBoneAxes.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.