# Vector2.Negate Method (Vector2, Vector2)

﻿Vector2.Negate Method (Vector2, Vector2)

|  |  |  |
| --- | --- | --- |
| Vector2Negate Method (Vector2, Vector2) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Reverses the direction of a given vector.

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
public static void Negate(
	ref Vector2 value,
	out Vector2 result
)
```

```
Public Shared Sub Negate ( 
	ByRef value As Vector2,
	<OutAttribute> ByRef result As Vector2
)
```

```
public:
static void Negate(
	Vector2% value, 
	[OutAttribute] Vector2% result
)
```

#### Parameters

value
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The vector to negate.

result
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    When the method completes, contains a vector facing in the opposite direction.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Negate Overload](Overload_Rage_Vector2_Negate.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.