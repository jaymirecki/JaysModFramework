# Vector3.Transform Method (Vector3[], Matrix, Vector4[], Int32, Int32)

﻿Vector3.Transform Method (Vector3[], Matrix, Vector4[], Int32, Int32)

|  |  |  |
| --- | --- | --- |
| Vector3Transform Method (Vector3, Matrix, Vector4, Int32, Int32) | RAGE Plugin Hook Documentation |  |

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
public static void Transform(
	Vector3[] vectorsIn,
	ref Matrix transformation,
	Vector4[] vectorsOut,
	int offset,
	int count
)
```

```
Public Shared Sub Transform ( 
	vectorsIn As Vector3(),
	ByRef transformation As Matrix,
	vectorsOut As Vector4(),
	offset As Integer,
	count As Integer
)
```

```
public:
static void Transform(
	array<Vector3>^ vectorsIn, 
	Matrix% transformation, 
	array<Vector4>^ vectorsOut, 
	int offset, 
	int count
)
```

#### Parameters

vectorsIn
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The source vectors.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The transformation Matrix.

vectorsOut
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The transformed Vector4s.

offset
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The offset at which to begin transforming.

count
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The number of vectors to transform, or 0 to process the whole array.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Transform Overload](Overload_Rage_Vector3_Transform.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.