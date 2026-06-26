# Vector2.Add Method (Vector2, Vector2, Vector2)

﻿Vector2.Add Method (Vector2, Vector2, Vector2)

|  |  |  |
| --- | --- | --- |
| Vector2Add Method (Vector2, Vector2, Vector2) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Adds two vectors.

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
public static void Add(
	ref Vector2 left,
	ref Vector2 right,
	out Vector2 result
)
```

```
Public Shared Sub Add ( 
	ByRef left As Vector2,
	ByRef right As Vector2,
	<OutAttribute> ByRef result As Vector2
)
```

```
public:
static void Add(
	Vector2% left, 
	Vector2% right, 
	[OutAttribute] Vector2% result
)
```

#### Parameters

left
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The first vector to add.

right
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The second vector to add.

result
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    When the method completes, contains the sum of the two vectors.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Add Overload](Overload_Rage_Vector2_Add.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.