# Quaternion.Negate Method (Quaternion, Quaternion)

﻿Quaternion.Negate Method (Quaternion, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionNegate Method (Quaternion, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Reverses the direction of a given quaternion.

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
public static void Negate(
	ref Quaternion quaternion,
	out Quaternion result
)
```

```
Public Shared Sub Negate ( 
	ByRef quaternion As Quaternion,
	<OutAttribute> ByRef result As Quaternion
)
```

```
public:
static void Negate(
	Quaternion% quaternion, 
	[OutAttribute] Quaternion% result
)
```

#### Parameters

quaternion
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The quaternion to negate.

result
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    When the method completes, contains a quaternion facing in the opposite direction.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Negate Overload](Overload_Rage_Quaternion_Negate.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.