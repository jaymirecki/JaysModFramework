# Matrix.RotationAxis Method (Vector3, Single)

﻿Matrix.RotationAxis Method (Vector3, Single)

|  |  |  |
| --- | --- | --- |
| MatrixRotationAxis Method (Vector3, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a matrix that rotates around an arbitary axis.

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
public static Matrix RotationAxis(
	Vector3 axis,
	float angle
)
```

```
Public Shared Function RotationAxis ( 
	axis As Vector3,
	angle As Single
) As Matrix
```

```
public:
static Matrix RotationAxis(
	Vector3 axis, 
	float angle
)
```

#### Parameters

axis
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The axis around which to rotate.

angle
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Angle of rotation in radians. Angles are measured clockwise when looking along the rotation axis toward the origin.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The created rotation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[RotationAxis Overload](Overload_Rage_Matrix_RotationAxis.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.