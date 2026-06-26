# Matrix.Transformation Method (Vector3, Quaternion, Vector3, Vector3, Quaternion, Vector3, Matrix)

﻿Matrix.Transformation Method (Vector3, Quaternion, Vector3, Vector3, Quaternion, Vector3, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixTransformation Method (Vector3, Quaternion, Vector3, Vector3, Quaternion, Vector3, Matrix) | RAGE Plugin Hook Documentation |  |

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
public static void Transformation(
	ref Vector3 scalingCenter,
	ref Quaternion scalingRotation,
	ref Vector3 scaling,
	ref Vector3 rotationCenter,
	ref Quaternion rotation,
	ref Vector3 translation,
	out Matrix result
)
```

```
Public Shared Sub Transformation ( 
	ByRef scalingCenter As Vector3,
	ByRef scalingRotation As Quaternion,
	ByRef scaling As Vector3,
	ByRef rotationCenter As Vector3,
	ByRef rotation As Quaternion,
	ByRef translation As Vector3,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void Transformation(
	Vector3% scalingCenter, 
	Quaternion% scalingRotation, 
	Vector3% scaling, 
	Vector3% rotationCenter, 
	Quaternion% rotation, 
	Vector3% translation, 
	[OutAttribute] Matrix% result
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

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    When the method completes, contains the created transformation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Transformation Overload](Overload_Rage_Matrix_Transformation.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.