# Matrix.Multiply Method (Matrix[], Matrix[], Matrix[], Int32, Int32)

﻿Matrix.Multiply Method (Matrix[], Matrix[], Matrix[], Int32, Int32)

|  |  |  |
| --- | --- | --- |
| MatrixMultiply Method (Matrix, Matrix, Matrix, Int32, Int32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines the products of two arrays of matrices.

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
	Matrix[] left,
	Matrix[] right,
	Matrix[] result,
	int offset,
	int count
)
```

```
Public Shared Sub Multiply ( 
	left As Matrix(),
	right As Matrix(),
	result As Matrix(),
	offset As Integer,
	count As Integer
)
```

```
public:
static void Multiply(
	array<Matrix>^ left, 
	array<Matrix>^ right, 
	array<Matrix>^ result, 
	int offset, 
	int count
)
```

#### Parameters

left
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The first matrix array to multiply.

right
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The second matrix array to multiply.

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The array of products of the two matrices.

offset
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The offset at which to begin the multiplication.

count
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The number of matrices to multiply, or 0 to process the entire array.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Multiply Overload](Overload_Rage_Matrix_Multiply.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.