# Vector2.Divide Method (Vector2, Single, Vector2)

﻿Vector2.Divide Method (Vector2, Single, Vector2)

|  |  |  |
| --- | --- | --- |
| Vector2Divide Method (Vector2, Single, Vector2) | RAGE Plugin Hook Documentation |  |

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
public static void Divide(
	ref Vector2 vector,
	float scale,
	out Vector2 result
)
```

```
Public Shared Sub Divide ( 
	ByRef vector As Vector2,
	scale As Single,
	<OutAttribute> ByRef result As Vector2
)
```

```
public:
static void Divide(
	Vector2% vector, 
	float scale, 
	[OutAttribute] Vector2% result
)
```

#### Parameters

vector
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The vector to scale.

scale
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The amount by which to scale the vector.

result
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    When the method completes, contains the scaled vector.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Divide Overload](Overload_Rage_Vector2_Divide.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.