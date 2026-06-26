# Matrix.Divide Method (Matrix, Single)

﻿Matrix.Divide Method (Matrix, Single)

|  |  |  |
| --- | --- | --- |
| MatrixDivide Method (Matrix, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Scales a matrix by the given value.

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
public static Matrix Divide(
	Matrix left,
	float right
)
```

```
Public Shared Function Divide ( 
	left As Matrix,
	right As Single
) As Matrix
```

```
public:
static Matrix Divide(
	Matrix left, 
	float right
)
```

#### Parameters

left
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The matrix to scale.

right
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The amount by which to scale.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The scaled matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Divide Overload](Overload_Rage_Matrix_Divide.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.