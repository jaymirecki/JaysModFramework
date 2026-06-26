# Quaternion.Exponential Method (Quaternion, Quaternion)

﻿Quaternion.Exponential Method (Quaternion, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionExponential Method (Quaternion, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Exponentiates a quaternion.

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
public static void Exponential(
	ref Quaternion quaternion,
	out Quaternion result
)
```

```
Public Shared Sub Exponential ( 
	ByRef quaternion As Quaternion,
	<OutAttribute> ByRef result As Quaternion
)
```

```
public:
static void Exponential(
	Quaternion% quaternion, 
	[OutAttribute] Quaternion% result
)
```

#### Parameters

quaternion
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The quaternion to exponentiate.

result
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    When the method completes, contains the exponentiated quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Exponential Overload](Overload_Rage_Quaternion_Exponential.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.