# Quaternion.SquadSetup Method

﻿Quaternion.SquadSetup Method 

|  |  |  |
| --- | --- | --- |
| QuaternionSquadSetup Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets up control points for spherical quadrangle interpolation.

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
public static Quaternion[] SquadSetup(
	Quaternion source1,
	Quaternion source2,
	Quaternion source3,
	Quaternion source4
)
```

```
Public Shared Function SquadSetup ( 
	source1 As Quaternion,
	source2 As Quaternion,
	source3 As Quaternion,
	source4 As Quaternion
) As Quaternion()
```

```
public:
static array<Quaternion>^ SquadSetup(
	Quaternion source1, 
	Quaternion source2, 
	Quaternion source3, 
	Quaternion source4
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
    Third source quaternion.

source4
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    Fourth source quaternion.

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
An array of three quaternions that represent control points for spherical quadrangle interpolation.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.