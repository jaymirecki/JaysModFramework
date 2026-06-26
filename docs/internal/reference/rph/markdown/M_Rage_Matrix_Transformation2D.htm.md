# Matrix.Transformation2D Method (Vector2, Single, Vector2, Vector2, Single, Vector2)

﻿Matrix.Transformation2D Method (Vector2, Single, Vector2, Vector2, Single, Vector2)

|  |  |  |
| --- | --- | --- |
| MatrixTransformation2D Method (Vector2, Single, Vector2, Vector2, Single, Vector2) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a 2D transformation matrix.

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
public static Matrix Transformation2D(
	Vector2 scalingCenter,
	float scalingRotation,
	Vector2 scaling,
	Vector2 rotationCenter,
	float rotation,
	Vector2 translation
)
```

```
Public Shared Function Transformation2D ( 
	scalingCenter As Vector2,
	scalingRotation As Single,
	scaling As Vector2,
	rotationCenter As Vector2,
	rotation As Single,
	translation As Vector2
) As Matrix
```

```
public:
static Matrix Transformation2D(
	Vector2 scalingCenter, 
	float scalingRotation, 
	Vector2 scaling, 
	Vector2 rotationCenter, 
	float rotation, 
	Vector2 translation
)
```

#### Parameters

scalingCenter
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    Center point of the scaling operation.

scalingRotation
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Scaling rotation amount.

scaling
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    Scaling factor.

rotationCenter
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The center of the rotation.

rotation
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The rotation of the transformation.

translation
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The translation factor of the transformation.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The created transformation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Transformation2D Overload](Overload_Rage_Matrix_Transformation2D.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.