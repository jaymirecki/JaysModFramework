# Quaternion.Multiply Method (Quaternion, Quaternion, Quaternion)

﻿Quaternion.Multiply Method (Quaternion, Quaternion, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionMultiply Method (Quaternion, Quaternion, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Modulates a quaternion by another.

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
public static void Multiply(
	ref Quaternion left,
	ref Quaternion right,
	out Quaternion result
)
```

```
Public Shared Sub Multiply ( 
	ByRef left As Quaternion,
	ByRef right As Quaternion,
	<OutAttribute> ByRef result As Quaternion
)
```

```
public:
static void Multiply(
	Quaternion% left, 
	Quaternion% right, 
	[OutAttribute] Quaternion% result
)
```

#### Parameters

left
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The first quaternion to modulate.

right
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The second quaternion to modulate.

result
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    When the moethod completes, contains the modulated quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Multiply Overload](Overload_Rage_Quaternion_Multiply.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.