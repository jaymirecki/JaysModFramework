# Vector3.Transform Method (Vector3[], Matrix)

﻿Vector3.Transform Method (Vector3[], Matrix)

|  |  |  |
| --- | --- | --- |
| Vector3Transform Method (Vector3, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Transforms an array of 3D vectors by the given Matrix.

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
	ref Matrix transformation
)
```

```
Public Shared Function Transform ( 
	vectors As Vector3(),
	ByRef transformation As Matrix
) As Vector4()
```

```
public:
static array<Vector4>^ Transform(
	array<Vector3>^ vectors, 
	Matrix% transformation
)
```

#### Parameters

vectors
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The source vectors.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The transformation Matrix.

#### Return Value

Type: [Vector4](T_Rage_Vector4.htm)  
The transformed Vector4s.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Transform Overload](Overload_Rage_Vector3_Transform.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.