# Matrix.Scaling Method (Single, Single, Single, Matrix)

﻿Matrix.Scaling Method (Single, Single, Single, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixScaling Method (Single, Single, Single, Matrix) | RAGE Plugin Hook Documentation |  |

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
public static void Scaling(
	float x,
	float y,
	float z,
	out Matrix result
)
```

```
Public Shared Sub Scaling ( 
	x As Single,
	y As Single,
	z As Single,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void Scaling(
	float x, 
	float y, 
	float z, 
	[OutAttribute] Matrix% result
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

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    When the method completes, contains the created scaling matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Scaling Overload](Overload_Rage_Matrix_Scaling.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.