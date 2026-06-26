# Quaternion.Slerp Method (Quaternion, Quaternion, Single)

﻿Quaternion.Slerp Method (Quaternion, Quaternion, Single)

|  |  |  |
| --- | --- | --- |
| QuaternionSlerp Method (Quaternion, Quaternion, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Interpolates between two quaternions, using spherical linear interpolation.

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
public static Quaternion Slerp(
	Quaternion start,
	Quaternion end,
	float amount
)
```

```
Public Shared Function Slerp ( 
	start As Quaternion,
	end As Quaternion,
	amount As Single
) As Quaternion
```

```
public:
static Quaternion Slerp(
	Quaternion start, 
	Quaternion end, 
	float amount
)
```

#### Parameters

start
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    Start quaternion.

end
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    End quaternion.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Value between 0 and 1 indicating the weight of end.

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
The spherical linear interpolation of the two quaternions.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Slerp Overload](Overload_Rage_Quaternion_Slerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.