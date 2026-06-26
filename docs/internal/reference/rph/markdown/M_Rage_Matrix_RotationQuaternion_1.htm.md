# Matrix.RotationQuaternion Method (Quaternion, Matrix)

﻿Matrix.RotationQuaternion Method (Quaternion, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixRotationQuaternion Method (Quaternion, Matrix) | RAGE Plugin Hook Documentation |  |

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
public static void RotationQuaternion(
	ref Quaternion rotation,
	out Matrix result
)
```

```
Public Shared Sub RotationQuaternion ( 
	ByRef rotation As Quaternion,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void RotationQuaternion(
	Quaternion% rotation, 
	[OutAttribute] Matrix% result
)
```

#### Parameters

rotation
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The quaternion to use to build the matrix.

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The created rotation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[RotationQuaternion Overload](Overload_Rage_Matrix_RotationQuaternion.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.