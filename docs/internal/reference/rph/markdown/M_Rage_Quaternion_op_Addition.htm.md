# Quaternion.Addition Operator

﻿Quaternion.Addition Operator 

|  |  |  |
| --- | --- | --- |
| QuaternionAddition Operator | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Adds two quaternions.

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
public static Quaternion operator +(
	Quaternion left,
	Quaternion right
)
```

```
Public Shared Operator + ( 
	left As Quaternion,
	right As Quaternion
) As Quaternion
```

```
public:
static Quaternion operator +(
	Quaternion left, 
	Quaternion right
)
```

#### Parameters

left
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The first quaternion to add.

right
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The second quaternion to add.

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
The sum of the two quaternions.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.