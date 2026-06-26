# Matrix.AffineTransformation2D Method (Single, Vector2, Single, Vector2, Matrix)

﻿Matrix.AffineTransformation2D Method (Single, Vector2, Single, Vector2, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixAffineTransformation2D Method (Single, Vector2, Single, Vector2, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a 2D affine transformation matrix.

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
public static void AffineTransformation2D(
	float scaling,
	ref Vector2 rotationCenter,
	float rotation,
	ref Vector2 translation,
	out Matrix result
)
```

```
Public Shared Sub AffineTransformation2D ( 
	scaling As Single,
	ByRef rotationCenter As Vector2,
	rotation As Single,
	ByRef translation As Vector2,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void AffineTransformation2D(
	float scaling, 
	Vector2% rotationCenter, 
	float rotation, 
	Vector2% translation, 
	[OutAttribute] Matrix% result
)
```

#### Parameters

scaling
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
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

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    When the method completes, contains the created affine transformation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[AffineTransformation2D Overload](Overload_Rage_Matrix_AffineTransformation2D.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.