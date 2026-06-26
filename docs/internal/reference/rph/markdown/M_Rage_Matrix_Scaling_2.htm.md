# Matrix.Scaling Method (Single, Single, Single)

﻿Matrix.Scaling Method (Single, Single, Single)

|  |  |  |
| --- | --- | --- |
| MatrixScaling Method (Single, Single, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a matrix that scales along the x-axis, y-axis, and y-axis.

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
public static Matrix Scaling(
	float x,
	float y,
	float z
)
```

```
Public Shared Function Scaling ( 
	x As Single,
	y As Single,
	z As Single
) As Matrix
```

```
public:
static Matrix Scaling(
	float x, 
	float y, 
	float z
)
```

#### Parameters

x
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Scaling factor that is applied along the x-axis.

y
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Scaling factor that is applied along the y-axis.

z
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Scaling factor that is applied along the z-axis.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The created scaling matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Scaling Overload](Overload_Rage_Matrix_Scaling.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.