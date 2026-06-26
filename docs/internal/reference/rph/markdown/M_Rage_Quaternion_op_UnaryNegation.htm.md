# Quaternion.UnaryNegation Operator

﻿Quaternion.UnaryNegation Operator 

|  |  |  |
| --- | --- | --- |
| QuaternionUnaryNegation Operator | RAGE Plugin Hook Documentation |  |

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
public static Quaternion operator -(
	Quaternion quaternion
)
```

```
Public Shared Operator - ( 
	quaternion As Quaternion
) As Quaternion
```

```
public:
static Quaternion operator -(
	Quaternion quaternion
)
```

#### Parameters

quaternion
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The quaternion to negate.

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
A quaternion facing in the opposite direction.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.