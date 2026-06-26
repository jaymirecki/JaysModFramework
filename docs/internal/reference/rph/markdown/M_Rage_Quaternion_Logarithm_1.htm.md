# Quaternion.Logarithm Method (Quaternion, Quaternion)

﻿Quaternion.Logarithm Method (Quaternion, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionLogarithm Method (Quaternion, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Calculates the natural logarithm of the specified quaternion.

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
public static void Logarithm(
	ref Quaternion quaternion,
	out Quaternion result
)
```

```
Public Shared Sub Logarithm ( 
	ByRef quaternion As Quaternion,
	<OutAttribute> ByRef result As Quaternion
)
```

```
public:
static void Logarithm(
	Quaternion% quaternion, 
	[OutAttribute] Quaternion% result
)
```

#### Parameters

quaternion
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The quaternion whose logarithm will be calculated.

result
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    When the method completes, contains the natural logarithm of the quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Logarithm Overload](Overload_Rage_Quaternion_Logarithm.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.