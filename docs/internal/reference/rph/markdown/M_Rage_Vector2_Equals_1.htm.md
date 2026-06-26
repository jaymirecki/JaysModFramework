# Vector2.Equals Method (Vector2, Vector2)

﻿Vector2.Equals Method (Vector2, Vector2)

|  |  |  |
| --- | --- | --- |
| Vector2Equals Method (Vector2, Vector2) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether the specified object instances are considered equal.

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
public static bool Equals(
	ref Vector2 value1,
	ref Vector2 value2
)
```

```
Public Shared Function Equals ( 
	ByRef value1 As Vector2,
	ByRef value2 As Vector2
) As Boolean
```

```
public:
static bool Equals(
	Vector2% value1, 
	Vector2% value2
)
```

#### Parameters

value1
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The first value to compare.

value2
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The second value to compare.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if value1 is the same instance as value2 or
if both are null references or if value1.Equals(value2) returns true; otherwise, false.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Equals Overload](Overload_Rage_Vector2_Equals.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.