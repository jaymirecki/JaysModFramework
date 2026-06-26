# Matrix.Transformation Method (Vector3, Quaternion, Vector3, Vector3, Quaternion, Vector3)

﻿Matrix.Transformation Method (Vector3, Quaternion, Vector3, Vector3, Quaternion, Vector3)

|  |  |  |
| --- | --- | --- |
| MatrixTransformation Method (Vector3, Quaternion, Vector3, Vector3, Quaternion, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a transformation matrix.

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
public static Matrix Transformation(
	Vector3 scalingCenter,
	Quaternion scalingRotation,
	Vector3 scaling,
	Vector3 rotationCenter,
	Quaternion rotation,
	Vector3 translation
)
```

```
Public Shared Function Transformation ( 
	scalingCenter As Vector3,
	scalingRotation As Quaternion,
	scaling As Vector3,
	rotationCenter As Vector3,
	rotation As Quaternion,
	translation As Vector3
) As Matrix
```

```
public:
static Matrix Transformation(
	Vector3 scalingCenter, 
	Quaternion scalingRotation, 
	Vector3 scaling, 
	Vector3 rotationCenter, 
	Quaternion rotation, 
	Vector3 translation
)
```

#### Parameters

scalingCenter
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    Center point of the scaling operation.

scalingRotation
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    Scaling rotation amount.

scaling
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    Scaling factor.

rotationCenter
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The center of the rotation.

rotation
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The rotation of the transformation.

translation
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The translation factor of the transformation.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The created transformation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Transformation Overload](Overload_Rage_Matrix_Transformation.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.