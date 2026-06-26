# Matrix.Billboard Method (Vector3, Vector3, Vector3, Vector3)

﻿Matrix.Billboard Method (Vector3, Vector3, Vector3, Vector3)

|  |  |  |
| --- | --- | --- |
| MatrixBillboard Method (Vector3, Vector3, Vector3, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a spherical billboard that rotates around a specified object position.

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
public static Matrix Billboard(
	Vector3 objectPosition,
	Vector3 cameraPosition,
	Vector3 cameraUpVector,
	Vector3 cameraForwardVector
)
```

```
Public Shared Function Billboard ( 
	objectPosition As Vector3,
	cameraPosition As Vector3,
	cameraUpVector As Vector3,
	cameraForwardVector As Vector3
) As Matrix
```

```
public:
static Matrix Billboard(
	Vector3 objectPosition, 
	Vector3 cameraPosition, 
	Vector3 cameraUpVector, 
	Vector3 cameraForwardVector
)
```

#### Parameters

objectPosition
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position of the object around which the billboard will rotate.

cameraPosition
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position of the camera.

cameraUpVector
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The up vector of the camera.

cameraForwardVector
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The forward vector of the camera.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The created billboard matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Billboard Overload](Overload_Rage_Matrix_Billboard.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.