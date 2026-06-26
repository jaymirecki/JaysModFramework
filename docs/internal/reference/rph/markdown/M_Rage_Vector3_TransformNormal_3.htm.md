# Vector3.TransformNormal Method (Vector3, Matrix, Vector3)

﻿Vector3.TransformNormal Method (Vector3, Matrix, Vector3)

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
	ref Vector3 normal,
	ref Matrix transformation,
	out Vector3 result
)
```

```
Public Shared Sub TransformNormal ( 
	ByRef normal As Vector3,
	ByRef transformation As Matrix,
	<OutAttribute> ByRef result As Vector3
)
```

```
public:
static void TransformNormal(
	Vector3% normal, 
	Matrix% transformation, 
	[OutAttribute] Vector3% result
)
```

#### Parameters

normal
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The normal vector to transform.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The transformation Matrix.

result
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    When the method completes, contains the transformed normal.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[TransformNormal Overload](Overload_Rage_Vector3_TransformNormal.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.