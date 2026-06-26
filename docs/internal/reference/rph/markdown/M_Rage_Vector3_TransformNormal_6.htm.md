# Vector3.TransformNormal Method (Vector3[], Matrix, Vector3[], Int32, Int32)

﻿Vector3.TransformNormal Method (Vector3[], Matrix, Vector3[], Int32, Int32)

|  |  |  |
| --- | --- | --- |
| Vector3TransformNormal Method (Vector3, Matrix, Vector3, Int32, Int32) | RAGE Plugin Hook Documentation |  |

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
	Vector3[] normalsOut,
	int offset,
	int count
)
```

```
Public Shared Sub TransformNormal ( 
	normalsIn As Vector3(),
	ByRef transformation As Matrix,
	normalsOut As Vector3(),
	offset As Integer,
	count As Integer
)
```

```
public:
static void TransformNormal(
	array<Vector3>^ normalsIn, 
	Matrix% transformation, 
	array<Vector3>^ normalsOut, 
	int offset, 
	int count
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

offset
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The offset at which to begin transforming.

count
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The number of vectors to transform, or 0 to process the whole array.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[TransformNormal Overload](Overload_Rage_Vector3_TransformNormal.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.