# Matrix.Invert Method (Matrix, Matrix)

﻿Matrix.Invert Method (Matrix, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixInvert Method (Matrix, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Calculates the inverse of the specified matrix.

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
public static void Invert(
	ref Matrix matrix,
	out Matrix result
)
```

```
Public Shared Sub Invert ( 
	ByRef matrix As Matrix,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void Invert(
	Matrix% matrix, 
	[OutAttribute] Matrix% result
)
```

#### Parameters

matrix
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The matrix whose inverse is to be calculated.

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    When the method completes, contains the inverse of the specified matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Invert Overload](Overload_Rage_Matrix_Invert.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.