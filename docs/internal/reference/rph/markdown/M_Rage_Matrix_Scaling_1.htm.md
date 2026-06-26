# Matrix.Scaling Method (Vector3, Matrix)

﻿Matrix.Scaling Method (Vector3, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixScaling Method (Vector3, Matrix) | RAGE Plugin Hook Documentation |  |

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
	ref Vector3 scale,
	out Matrix result
)
```

```
Public Shared Sub Scaling ( 
	ByRef scale As Vector3,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void Scaling(
	Vector3% scale, 
	[OutAttribute] Matrix% result
)
```

#### Parameters

scale
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    Scaling factor for all three axes.

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