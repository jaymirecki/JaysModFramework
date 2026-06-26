# Quaternion.Conjugate Method (Quaternion, Quaternion)

﻿Quaternion.Conjugate Method (Quaternion, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionConjugate Method (Quaternion, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Conjugates a quaternion.

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
public static void Conjugate(
	ref Quaternion quaternion,
	out Quaternion result
)
```

```
Public Shared Sub Conjugate ( 
	ByRef quaternion As Quaternion,
	<OutAttribute> ByRef result As Quaternion
)
```

```
public:
static void Conjugate(
	Quaternion% quaternion, 
	[OutAttribute] Quaternion% result
)
```

#### Parameters

quaternion
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The quaternion to conjugate.

result
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    When the method completes, contains the conjugated quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Conjugate Overload](Overload_Rage_Quaternion_Conjugate.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.