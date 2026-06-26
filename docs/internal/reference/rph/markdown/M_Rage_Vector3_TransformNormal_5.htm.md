# Vector3.TransformNormal Method (Vector3[], Matrix, Vector3[])

﻿Vector3.TransformNormal Method (Vector3[], Matrix, Vector3[])

|  |  |  |
| --- | --- | --- |
| Vector3TransformNormal Method (Vector3, Matrix, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Performs a normal transformation using the given Matrix.

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
public static void TransformNormal(
	Vector3[] normalsIn,
	ref Matrix transformation,
	Vector3[] normalsOut
)
```

```
Public Shared Sub TransformNormal ( 
	normalsIn As Vector3(),
	ByRef transformation As Matrix,
	normalsOut As Vector3()
)
```

```
public:
static void TransformNormal(
	array<Vector3>^ normalsIn, 
	Matrix% transformation, 
	array<Vector3>^ normalsOut
)
```

#### Parameters

normalsIn
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The source vectors.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The transformation Matrix.

normalsOut
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The transformed Vector3s.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[TransformNormal Overload](Overload_Rage_Vector3_TransformNormal.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.