# Vector2.Transform Method (Vector2[], Matrix)

﻿Vector2.Transform Method (Vector2[], Matrix)

|  |  |  |
| --- | --- | --- |
| Vector2Transform Method (Vector2, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Transforms an array of 2D vectors by the given Matrix.

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
	Vector2[] vectors,
	ref Matrix transformation
)
```

```
Public Shared Function Transform ( 
	vectors As Vector2(),
	ByRef transformation As Matrix
) As Vector4()
```

```
public:
static array<Vector4>^ Transform(
	array<Vector2>^ vectors, 
	Matrix% transformation
)
```

#### Parameters

vectors
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The source vectors.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The transformation Matrix.

#### Return Value

Type: [Vector4](T_Rage_Vector4.htm)  
The transformed Vector4s.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Transform Overload](Overload_Rage_Vector2_Transform.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.