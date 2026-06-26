# Matrix.Equals Method (Matrix, Matrix)

﻿Matrix.Equals Method (Matrix, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixEquals Method (Matrix, Matrix) | RAGE Plugin Hook Documentation |  |

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
	ref Matrix value1,
	ref Matrix value2
)
```

```
Public Shared Function Equals ( 
	ByRef value1 As Matrix,
	ByRef value2 As Matrix
) As Boolean
```

```
public:
static bool Equals(
	Matrix% value1, 
	Matrix% value2
)
```

#### Parameters

value1
:   Type: [RageMatrix](T_Rage_Matrix.htm)

value2
:   Type: [RageMatrix](T_Rage_Matrix.htm)

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if value1 is the same instance as value2 or
if both are null references or if value1.Equals(value2) returns true; otherwise, false.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Equals Overload](Overload_Rage_Matrix_Equals.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.