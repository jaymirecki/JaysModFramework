# Vector2.Clamp Method (Vector2, Vector2, Vector2, Vector2)

﻿Vector2.Clamp Method (Vector2, Vector2, Vector2, Vector2)

|  |  |  |
| --- | --- | --- |
| Vector2Clamp Method (Vector2, Vector2, Vector2, Vector2) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Restricts a value to be within a specified range.

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
public static void Clamp(
	ref Vector2 value,
	ref Vector2 min,
	ref Vector2 max,
	out Vector2 result
)
```

```
Public Shared Sub Clamp ( 
	ByRef value As Vector2,
	ByRef min As Vector2,
	ByRef max As Vector2,
	<OutAttribute> ByRef result As Vector2
)
```

```
public:
static void Clamp(
	Vector2% value, 
	Vector2% min, 
	Vector2% max, 
	[OutAttribute] Vector2% result
)
```

#### Parameters

value
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The value to clamp.

min
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The minimum value.

max
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The maximum value.

result
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    When the method completes, contains the clamped value.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Clamp Overload](Overload_Rage_Vector2_Clamp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.