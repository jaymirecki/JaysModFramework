# Matrix.RotationX Method (Single, Matrix)

﻿Matrix.RotationX Method (Single, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixRotationX Method (Single, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a matrix that rotates around the x-axis.

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
public static void RotationX(
	float angle,
	out Matrix result
)
```

```
Public Shared Sub RotationX ( 
	angle As Single,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void RotationX(
	float angle, 
	[OutAttribute] Matrix% result
)
```

#### Parameters

angle
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Angle of rotation in radians. Angles are measured clockwise when looking along the rotation axis toward the origin.

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    When the method completes, contains the created rotation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[RotationX Overload](Overload_Rage_Matrix_RotationX.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.