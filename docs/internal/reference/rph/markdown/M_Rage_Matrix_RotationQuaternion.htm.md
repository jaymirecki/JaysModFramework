# Matrix.RotationQuaternion Method (Quaternion)

﻿Matrix.RotationQuaternion Method (Quaternion)

|  |  |  |
| --- | --- | --- |
| MatrixRotationQuaternion Method (Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a rotation matrix from a quaternion.

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
public static Matrix RotationQuaternion(
	Quaternion rotation
)
```

```
Public Shared Function RotationQuaternion ( 
	rotation As Quaternion
) As Matrix
```

```
public:
static Matrix RotationQuaternion(
	Quaternion rotation
)
```

#### Parameters

rotation
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The quaternion to use to build the matrix.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The created rotation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[RotationQuaternion Overload](Overload_Rage_Matrix_RotationQuaternion.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.