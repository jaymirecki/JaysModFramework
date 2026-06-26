# Quaternion.Multiply Method (Quaternion, Single, Quaternion)

﻿Quaternion.Multiply Method (Quaternion, Single, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionMultiply Method (Quaternion, Single, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Scales a quaternion by the given value.

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
	ref Quaternion quaternion,
	float scale,
	out Quaternion result
)
```

```
Public Shared Sub Multiply ( 
	ByRef quaternion As Quaternion,
	scale As Single,
	<OutAttribute> ByRef result As Quaternion
)
```

```
public:
static void Multiply(
	Quaternion% quaternion, 
	float scale, 
	[OutAttribute] Quaternion% result
)
```

#### Parameters

quaternion
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The quaternion to scale.

scale
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The amount by which to scale the quaternion.

result
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    When the method completes, contains the scaled quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Multiply Overload](Overload_Rage_Quaternion_Multiply.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.