# Matrix.RotationYawPitchRoll Method (Single, Single, Single, Matrix)

﻿Matrix.RotationYawPitchRoll Method (Single, Single, Single, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixRotationYawPitchRoll Method (Single, Single, Single, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a rotation matrix with a specified yaw, pitch, and roll.

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
public static void RotationYawPitchRoll(
	float yaw,
	float pitch,
	float roll,
	out Matrix result
)
```

```
Public Shared Sub RotationYawPitchRoll ( 
	yaw As Single,
	pitch As Single,
	roll As Single,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void RotationYawPitchRoll(
	float yaw, 
	float pitch, 
	float roll, 
	[OutAttribute] Matrix% result
)
```

#### Parameters

yaw
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Yaw around the y-axis, in radians.

pitch
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Pitch around the x-axis, in radians.

roll
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Roll around the z-axis, in radians.

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    When the method completes, contains the created rotation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[RotationYawPitchRoll Overload](Overload_Rage_Matrix_RotationYawPitchRoll.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.