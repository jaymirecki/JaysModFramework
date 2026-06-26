# Quaternion.RotationMatrix Method (Matrix)

﻿Quaternion.RotationMatrix Method (Matrix)

|  |  |  |
| --- | --- | --- |
| QuaternionRotationMatrix Method (Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a quaternion given a rotation matrix.

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
public static Quaternion RotationMatrix(
	Matrix matrix
)
```

```
Public Shared Function RotationMatrix ( 
	matrix As Matrix
) As Quaternion
```

```
public:
static Quaternion RotationMatrix(
	Matrix matrix
)
```

#### Parameters

matrix
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The rotation matrix.

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
The newly created quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[RotationMatrix Overload](Overload_Rage_Quaternion_RotationMatrix.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.