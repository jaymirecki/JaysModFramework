# Matrix.Subtraction Operator

﻿Matrix.Subtraction Operator 

|  |  |  |
| --- | --- | --- |
| MatrixSubtraction Operator | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Subtracts two matricies.

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
public static Matrix operator -(
	Matrix left,
	Matrix right
)
```

```
Public Shared Operator - ( 
	left As Matrix,
	right As Matrix
) As Matrix
```

```
public:
static Matrix operator -(
	Matrix left, 
	Matrix right
)
```

#### Parameters

left
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The first matrix to subtract.

right
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The second matrix to subtract.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The difference between the two matricies.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.