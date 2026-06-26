# Vector3.Transform Method (Vector3, Matrix, Vector4)

﻿Vector3.Transform Method (Vector3, Matrix, Vector4)

|  |  |  |
| --- | --- | --- |
| Vector3Transform Method (Vector3, Matrix, Vector4) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Transforms a 3D vector by the given Matrix.

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
	ref Vector3 vector,
	ref Matrix transformation,
	out Vector4 result
)
```

```
Public Shared Sub Transform ( 
	ByRef vector As Vector3,
	ByRef transformation As Matrix,
	<OutAttribute> ByRef result As Vector4
)
```

```
public:
static void Transform(
	Vector3% vector, 
	Matrix% transformation, 
	[OutAttribute] Vector4% result
)
```

#### Parameters

vector
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The source vector.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The transformation Matrix.

result
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    When the method completes, contains the transformed Vector4.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Transform Overload](Overload_Rage_Vector3_Transform.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.