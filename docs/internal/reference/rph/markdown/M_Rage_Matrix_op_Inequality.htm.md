# Matrix.Inequality Operator

﻿Matrix.Inequality Operator 

|  |  |  |
| --- | --- | --- |
| MatrixInequality Operator | RAGE Plugin Hook Documentation |  |

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
	Matrix left,
	Matrix right
)
```

```
Public Shared Operator <> ( 
	left As Matrix,
	right As Matrix
) As Boolean
```

```
public:
static bool operator !=(
	Matrix left, 
	Matrix right
)
```

#### Parameters

left
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The first value to compare.

right
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The second value to compare.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if left has a different value than right; otherwise, false.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.