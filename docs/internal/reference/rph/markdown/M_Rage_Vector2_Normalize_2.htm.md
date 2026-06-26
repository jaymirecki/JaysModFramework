# Vector2.Normalize Method (Vector2, Vector2)

﻿Vector2.Normalize Method (Vector2, Vector2)

|  |  |  |
| --- | --- | --- |
| Vector2Normalize Method (Vector2, Vector2) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Converts the vector into a unit vector.

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
public static void Normalize(
	ref Vector2 vector,
	out Vector2 result
)
```

```
Public Shared Sub Normalize ( 
	ByRef vector As Vector2,
	<OutAttribute> ByRef result As Vector2
)
```

```
public:
static void Normalize(
	Vector2% vector, 
	[OutAttribute] Vector2% result
)
```

#### Parameters

vector
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The vector to normalize.

result
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    When the method completes, contains the normalized vector.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Normalize Overload](Overload_Rage_Vector2_Normalize.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.