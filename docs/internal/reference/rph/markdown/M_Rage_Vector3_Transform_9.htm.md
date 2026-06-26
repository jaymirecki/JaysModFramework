# Vector3.Transform Method (Vector3[], Quaternion)

﻿Vector3.Transform Method (Vector3[], Quaternion)

|  |  |  |
| --- | --- | --- |
| Vector3Transform Method (Vector3, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Transforms an array of 3D vectors by the given Quaternion rotation.

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
public static Vector4[] Transform(
	Vector3[] vectors,
	ref Quaternion rotation
)
```

```
Public Shared Function Transform ( 
	vectors As Vector3(),
	ByRef rotation As Quaternion
) As Vector4()
```

```
public:
static array<Vector4>^ Transform(
	array<Vector3>^ vectors, 
	Quaternion% rotation
)
```

#### Parameters

vectors
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The vectors to rotate.

rotation
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The Quaternion rotation to apply.

#### Return Value

Type: [Vector4](T_Rage_Vector4.htm)  
The transformed Vector4.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Transform Overload](Overload_Rage_Vector3_Transform.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.