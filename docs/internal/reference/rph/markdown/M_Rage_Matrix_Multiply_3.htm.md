# Matrix.Multiply Method (Matrix, Matrix, Matrix)

﻿Matrix.Multiply Method (Matrix, Matrix, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixMultiply Method (Matrix, Matrix, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines the product of two matrices.

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
public static void Multiply(
	ref Matrix left,
	ref Matrix right,
	out Matrix result
)
```

```
Public Shared Sub Multiply ( 
	ByRef left As Matrix,
	ByRef right As Matrix,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void Multiply(
	Matrix% left, 
	Matrix% right, 
	[OutAttribute] Matrix% result
)
```

#### Parameters

left
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The first matrix to multiply.

right
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The second matrix to multiply.

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The product of the two matrices.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Multiply Overload](Overload_Rage_Matrix_Multiply.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.