# Vector2.Transform Method (Vector2, Matrix)

﻿Vector2.Transform Method (Vector2, Matrix)

|  |  |  |
| --- | --- | --- |
| Vector2Transform Method (Vector2, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Transforms a 2D vector by the given Matrix.

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
public static Vector4 Transform(
	Vector2 vector,
	Matrix transformation
)
```

```
Public Shared Function Transform ( 
	vector As Vector2,
	transformation As Matrix
) As Vector4
```

```
public:
static Vector4 Transform(
	Vector2 vector, 
	Matrix transformation
)
```

#### Parameters

vector
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The source vector.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The transformation Matrix.

#### Return Value

Type: [Vector4](T_Rage_Vector4.htm)  
The transformed Vector4.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Transform Overload](Overload_Rage_Vector2_Transform.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.