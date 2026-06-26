# Vector2.Multiply Operator (Vector2, Single)

﻿Vector2.Multiply Operator (Vector2, Single)

|  |  |  |
| --- | --- | --- |
| Vector2Multiply Operator (Vector2, Single) | RAGE Plugin Hook Documentation |  |

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
public static Vector2 operator *(
	Vector2 vector,
	float scale
)
```

```
Public Shared Operator * ( 
	vector As Vector2,
	scale As Single
) As Vector2
```

```
public:
static Vector2 operator *(
	Vector2 vector, 
	float scale
)
```

#### Parameters

vector
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The vector to scale.

scale
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The amount by which to scale the vector.

#### Return Value

Type: [Vector2](T_Rage_Vector2.htm)  
The scaled vector.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Multiply Overload](Overload_Rage_Vector2_op_Multiply.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.