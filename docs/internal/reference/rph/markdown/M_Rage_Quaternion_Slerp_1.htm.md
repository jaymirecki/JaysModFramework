# Quaternion.Slerp Method (Quaternion, Quaternion, Single, Quaternion)

﻿Quaternion.Slerp Method (Quaternion, Quaternion, Single, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionSlerp Method (Quaternion, Quaternion, Single, Quaternion) | RAGE Plugin Hook Documentation |  |

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
public static void Slerp(
	ref Quaternion start,
	ref Quaternion end,
	float amount,
	out Quaternion result
)
```

```
Public Shared Sub Slerp ( 
	ByRef start As Quaternion,
	ByRef end As Quaternion,
	amount As Single,
	<OutAttribute> ByRef result As Quaternion
)
```

```
public:
static void Slerp(
	Quaternion% start, 
	Quaternion% end, 
	float amount, 
	[OutAttribute] Quaternion% result
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

result
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    When the method completes, contains the spherical linear interpolation of the two quaternions.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Slerp Overload](Overload_Rage_Quaternion_Slerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.