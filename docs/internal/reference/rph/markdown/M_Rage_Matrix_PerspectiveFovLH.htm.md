# Matrix.PerspectiveFovLH Method (Single, Single, Single, Single)

﻿Matrix.PerspectiveFovLH Method (Single, Single, Single, Single)

|  |  |  |
| --- | --- | --- |
| MatrixPerspectiveFovLH Method (Single, Single, Single, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a left-handed, perspective projection matrix based on a field of view.

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
public static Matrix PerspectiveFovLH(
	float fov,
	float aspect,
	float znear,
	float zfar
)
```

```
Public Shared Function PerspectiveFovLH ( 
	fov As Single,
	aspect As Single,
	znear As Single,
	zfar As Single
) As Matrix
```

```
public:
static Matrix PerspectiveFovLH(
	float fov, 
	float aspect, 
	float znear, 
	float zfar
)
```

#### Parameters

fov
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Field of view in the y direction, in radians.

aspect
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Aspect ratio, defined as view space width divided by height.

znear
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Minimum z-value of the viewing volume.

zfar
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Maximum z-value of the viewing volume.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The created projection matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[PerspectiveFovLH Overload](Overload_Rage_Matrix_PerspectiveFovLH.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.