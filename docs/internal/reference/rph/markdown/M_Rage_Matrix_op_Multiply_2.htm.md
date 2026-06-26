# Matrix.Multiply Operator (Single, Matrix)

﻿Matrix.Multiply Operator (Single, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixMultiply Operator (Single, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Scales a matrix by a given value.

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
public static Matrix operator *(
	float left,
	Matrix right
)
```

```
Public Shared Operator * ( 
	left As Single,
	right As Matrix
) As Matrix
```

```
public:
static Matrix operator *(
	float left, 
	Matrix right
)
```

#### Parameters

left
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The amount by which to scale.

right
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The matrix to scale.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The scaled matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Multiply Overload](Overload_Rage_Matrix_op_Multiply.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.