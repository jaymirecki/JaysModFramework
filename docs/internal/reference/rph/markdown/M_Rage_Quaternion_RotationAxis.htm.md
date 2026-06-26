# Quaternion.RotationAxis Method (Vector3, Single)

﻿Quaternion.RotationAxis Method (Vector3, Single)

|  |  |  |
| --- | --- | --- |
| QuaternionRotationAxis Method (Vector3, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a quaternion given a rotation and an axis.

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
public static Quaternion RotationAxis(
	Vector3 axis,
	float angle
)
```

```
Public Shared Function RotationAxis ( 
	axis As Vector3,
	angle As Single
) As Quaternion
```

```
public:
static Quaternion RotationAxis(
	Vector3 axis, 
	float angle
)
```

#### Parameters

axis
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The axis of rotation.

angle
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The angle of rotation.

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
The newly created quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[RotationAxis Overload](Overload_Rage_Quaternion_RotationAxis.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.