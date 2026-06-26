# Quaternion.Multiply Operator (Quaternion, Quaternion)

﻿Quaternion.Multiply Operator (Quaternion, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionMultiply Operator (Quaternion, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Multiplies a quaternion by another.

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
public static Quaternion operator *(
	Quaternion left,
	Quaternion right
)
```

```
Public Shared Operator * ( 
	left As Quaternion,
	right As Quaternion
) As Quaternion
```

```
public:
static Quaternion operator *(
	Quaternion left, 
	Quaternion right
)
```

#### Parameters

left
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The first quaternion to multiply.

right
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The second quaternion to multiply.

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
The multiplied quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Multiply Overload](Overload_Rage_Quaternion_op_Multiply.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.