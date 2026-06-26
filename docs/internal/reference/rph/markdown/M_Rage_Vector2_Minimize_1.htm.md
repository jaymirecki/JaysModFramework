# Vector2.Minimize Method (Vector2, Vector2, Vector2)

﻿Vector2.Minimize Method (Vector2, Vector2, Vector2)

|  |  |  |
| --- | --- | --- |
| Vector2Minimize Method (Vector2, Vector2, Vector2) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Returns a vector containing the smallest components of the specified vectors.

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
public static void Minimize(
	ref Vector2 value1,
	ref Vector2 value2,
	out Vector2 result
)
```

```
Public Shared Sub Minimize ( 
	ByRef value1 As Vector2,
	ByRef value2 As Vector2,
	<OutAttribute> ByRef result As Vector2
)
```

```
public:
static void Minimize(
	Vector2% value1, 
	Vector2% value2, 
	[OutAttribute] Vector2% result
)
```

#### Parameters

value1
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The first source vector.

value2
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The second source vector.

result
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    When the method completes, contains an new vector composed of the smallest components of the source vectors.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Minimize Overload](Overload_Rage_Vector2_Minimize.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.