# Matrix.Negate Method (Matrix, Matrix)

﻿Matrix.Negate Method (Matrix, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixNegate Method (Matrix, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Negates a matrix.

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
public static void Negate(
	ref Matrix matrix,
	out Matrix result
)
```

```
Public Shared Sub Negate ( 
	ByRef matrix As Matrix,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void Negate(
	Matrix% matrix, 
	[OutAttribute] Matrix% result
)
```

#### Parameters

matrix
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The matrix to be negated.

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    When the method completes, contains the negated matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Negate Overload](Overload_Rage_Matrix_Negate.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.