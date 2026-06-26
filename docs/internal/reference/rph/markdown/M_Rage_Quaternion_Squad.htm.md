# Quaternion.Squad Method (Quaternion, Quaternion, Quaternion, Quaternion, Single)

﻿Quaternion.Squad Method (Quaternion, Quaternion, Quaternion, Quaternion, Single)

|  |  |  |
| --- | --- | --- |
| QuaternionSquad Method (Quaternion, Quaternion, Quaternion, Quaternion, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Interpolates between quaternions, using spherical quadrangle interpolation.

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
public static Quaternion Squad(
	Quaternion source1,
	Quaternion source2,
	Quaternion source3,
	Quaternion source4,
	float amount
)
```

```
Public Shared Function Squad ( 
	source1 As Quaternion,
	source2 As Quaternion,
	source3 As Quaternion,
	source4 As Quaternion,
	amount As Single
) As Quaternion
```

```
public:
static Quaternion Squad(
	Quaternion source1, 
	Quaternion source2, 
	Quaternion source3, 
	Quaternion source4, 
	float amount
)
```

#### Parameters

source1
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    First source quaternion.

source2
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    Second source quaternion.

source3
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    Thrid source quaternion.

source4
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    Fourth source quaternion.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Value between 0 and 1 indicating the weight of interpolation.

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
The spherical quadrangle interpolation of the quaternions.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Squad Overload](Overload_Rage_Quaternion_Squad.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.