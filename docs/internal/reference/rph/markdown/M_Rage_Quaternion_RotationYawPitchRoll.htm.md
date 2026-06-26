# Quaternion.RotationYawPitchRoll Method (Single, Single, Single)

﻿Quaternion.RotationYawPitchRoll Method (Single, Single, Single)

|  |  |  |
| --- | --- | --- |
| QuaternionRotationYawPitchRoll Method (Single, Single, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a quaternion given a yaw, pitch, and roll value.

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
public static Quaternion RotationYawPitchRoll(
	float yaw,
	float pitch,
	float roll
)
```

```
Public Shared Function RotationYawPitchRoll ( 
	yaw As Single,
	pitch As Single,
	roll As Single
) As Quaternion
```

```
public:
static Quaternion RotationYawPitchRoll(
	float yaw, 
	float pitch, 
	float roll
)
```

#### Parameters

yaw
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The yaw of rotation.

pitch
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The pitch of rotation.

roll
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The roll of rotation.

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
The newly created quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[RotationYawPitchRoll Overload](Overload_Rage_Quaternion_RotationYawPitchRoll.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.