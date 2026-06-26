# Vector4.Division Operator

﻿Vector4.Division Operator 

|  |  |  |
| --- | --- | --- |
| Vector4Division Operator | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Scales a vector by the given value.

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
public static Vector4 operator /(
	Vector4 vector,
	float scale
)
```

```
Public Shared Operator / ( 
	vector As Vector4,
	scale As Single
) As Vector4
```

```
public:
static Vector4 operator /(
	Vector4 vector, 
	float scale
)
```

#### Parameters

vector
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The vector to scale.

scale
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The amount by which to scale the vector.

#### Return Value

Type: [Vector4](T_Rage_Vector4.htm)  
The scaled vector.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.