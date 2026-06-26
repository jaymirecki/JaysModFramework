# Matrix.Add Method (Matrix, Matrix, Matrix)

﻿Matrix.Add Method (Matrix, Matrix, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixAdd Method (Matrix, Matrix, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines the sum of two matrices.

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
public static void Add(
	ref Matrix left,
	ref Matrix right,
	out Matrix result
)
```

```
Public Shared Sub Add ( 
	ByRef left As Matrix,
	ByRef right As Matrix,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void Add(
	Matrix% left, 
	Matrix% right, 
	[OutAttribute] Matrix% result
)
```

#### Parameters

left
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The first matrix to add.

right
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The second matrix to add.

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    When the method completes, contains the sum of the two matrices.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Add Overload](Overload_Rage_Matrix_Add.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.