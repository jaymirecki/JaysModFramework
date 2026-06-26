# Vector2.Equality Operator

﻿Vector2.Equality Operator 

|  |  |  |
| --- | --- | --- |
| Vector2Equality Operator | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Tests for equality between two objects.

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
public static bool operator ==(
	Vector2 left,
	Vector2 right
)
```

```
Public Shared Operator = ( 
	left As Vector2,
	right As Vector2
) As Boolean
```

```
public:
static bool operator ==(
	Vector2 left, 
	Vector2 right
)
```

#### Parameters

left
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The first value to compare.

right
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The second value to compare.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if left has the same value as right; otherwise, false.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.