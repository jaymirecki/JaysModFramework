# Matrix.Scaling Method (Vector3)

﻿Matrix.Scaling Method (Vector3)

|  |  |  |
| --- | --- | --- |
| MatrixScaling Method (Vector3) | RAGE Plugin Hook Documentation |  |

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
	Vector3 scale
)
```

```
Public Shared Function Scaling ( 
	scale As Vector3
) As Matrix
```

```
public:
static Matrix Scaling(
	Vector3 scale
)
```

#### Parameters

scale
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    Scaling factor for all three axes.

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