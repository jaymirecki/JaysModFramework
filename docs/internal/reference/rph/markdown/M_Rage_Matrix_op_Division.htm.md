# Matrix.Division Operator (Matrix, Matrix)

﻿Matrix.Division Operator (Matrix, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixDivision Operator (Matrix, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Divides two matricies.

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
public static Matrix operator /(
	Matrix left,
	Matrix right
)
```

```
Public Shared Operator / ( 
	left As Matrix,
	right As Matrix
) As Matrix
```

```
public:
static Matrix operator /(
	Matrix left, 
	Matrix right
)
```

#### Parameters

left
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The first matrix to divide.

right
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The second matrix to divide.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The quotient of the two matricies.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Division Overload](Overload_Rage_Matrix_op_Division.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.