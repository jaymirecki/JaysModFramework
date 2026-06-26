# Quaternion.Normalize Method (Quaternion, Quaternion)

﻿Quaternion.Normalize Method (Quaternion, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionNormalize Method (Quaternion, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Converts the quaternion into a unit quaternion.

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
public static void Normalize(
	ref Quaternion quaternion,
	out Quaternion result
)
```

```
Public Shared Sub Normalize ( 
	ByRef quaternion As Quaternion,
	<OutAttribute> ByRef result As Quaternion
)
```

```
public:
static void Normalize(
	Quaternion% quaternion, 
	[OutAttribute] Quaternion% result
)
```

#### Parameters

quaternion
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The quaternion to normalize.

result
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    When the method completes, contains the normalized quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Normalize Overload](Overload_Rage_Quaternion_Normalize.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.