# Vector4.Multiply Method (Vector4, Single, Vector4)

﻿Vector4.Multiply Method (Vector4, Single, Vector4)

|  |  |  |
| --- | --- | --- |
| Vector4Multiply Method (Vector4, Single, Vector4) | RAGE Plugin Hook Documentation |  |

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
public static void Multiply(
	ref Vector4 vector,
	float scale,
	out Vector4 result
)
```

```
Public Shared Sub Multiply ( 
	ByRef vector As Vector4,
	scale As Single,
	<OutAttribute> ByRef result As Vector4
)
```

```
public:
static void Multiply(
	Vector4% vector, 
	float scale, 
	[OutAttribute] Vector4% result
)
```

#### Parameters

vector
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The vector to scale.

scale
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The amount by which to scale the vector.

result
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    When the method completes, contains the scaled vector.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[Multiply Overload](Overload_Rage_Vector4_Multiply.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.