# Quaternion.Division Operator

﻿Quaternion.Division Operator 

|  |  |  |
| --- | --- | --- |
| QuaternionDivision Operator | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Divides a quaternion by another.

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
public static Quaternion operator /(
	Quaternion left,
	float right
)
```

```
Public Shared Operator / ( 
	left As Quaternion,
	right As Single
) As Quaternion
```

```
public:
static Quaternion operator /(
	Quaternion left, 
	float right
)
```

#### Parameters

left
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The first quaternion to divide.

right
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The second quaternion to divide.

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
The divided quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.