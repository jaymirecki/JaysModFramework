# Quaternion.RotationAxis Method (Vector3, Single, Quaternion)

﻿Quaternion.RotationAxis Method (Vector3, Single, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionRotationAxis Method (Vector3, Single, Quaternion) | RAGE Plugin Hook Documentation |  |

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
public static void RotationAxis(
	ref Vector3 axis,
	float angle,
	out Quaternion result
)
```

```
Public Shared Sub RotationAxis ( 
	ByRef axis As Vector3,
	angle As Single,
	<OutAttribute> ByRef result As Quaternion
)
```

```
public:
static void RotationAxis(
	Vector3% axis, 
	float angle, 
	[OutAttribute] Quaternion% result
)
```

#### Parameters

axis
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The axis of rotation.

angle
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The angle of rotation.

result
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    When the method completes, contains the newly created quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[RotationAxis Overload](Overload_Rage_Quaternion_RotationAxis.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.