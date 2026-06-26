# Matrix.RotationZ Method (Single)

﻿Matrix.RotationZ Method (Single)

|  |  |  |
| --- | --- | --- |
| MatrixRotationZ Method (Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a matrix that rotates around the z-axis.

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
public static Matrix RotationZ(
	float angle
)
```

```
Public Shared Function RotationZ ( 
	angle As Single
) As Matrix
```

```
public:
static Matrix RotationZ(
	float angle
)
```

#### Parameters

angle
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Angle of rotation in radians. Angles are measured clockwise when looking along the rotation axis toward the origin.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The created rotation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[RotationZ Overload](Overload_Rage_Matrix_RotationZ.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.