# Vector4.Inequality Operator

﻿Vector4.Inequality Operator 

|  |  |  |
| --- | --- | --- |
| Vector4Inequality Operator | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Tests for inequality between two objects.

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
public static bool operator !=(
	Vector4 left,
	Vector4 right
)
```

```
Public Shared Operator <> ( 
	left As Vector4,
	right As Vector4
) As Boolean
```

```
public:
static bool operator !=(
	Vector4 left, 
	Vector4 right
)
```

#### Parameters

left
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The first value to compare.

right
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The second value to compare.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if left has a different value than right; otherwise, false.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.