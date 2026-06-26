# Matrix.PerspectiveOffCenterLH Method (Single, Single, Single, Single, Single, Single)

﻿Matrix.PerspectiveOffCenterLH Method (Single, Single, Single, Single, Single, Single)

|  |  |  |
| --- | --- | --- |
| MatrixPerspectiveOffCenterLH Method (Single, Single, Single, Single, Single, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a left-handed, customized perspective projection matrix.

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
public static Matrix PerspectiveOffCenterLH(
	float left,
	float right,
	float bottom,
	float top,
	float znear,
	float zfar
)
```

```
Public Shared Function PerspectiveOffCenterLH ( 
	left As Single,
	right As Single,
	bottom As Single,
	top As Single,
	znear As Single,
	zfar As Single
) As Matrix
```

```
public:
static Matrix PerspectiveOffCenterLH(
	float left, 
	float right, 
	float bottom, 
	float top, 
	float znear, 
	float zfar
)
```

#### Parameters

left
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Minimum x-value of the viewing volume.

right
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Maximum x-value of the viewing volume.

bottom
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Minimum y-value of the viewing volume.

top
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Maximum y-value of the viewing volume.

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

[PerspectiveOffCenterLH Overload](Overload_Rage_Matrix_PerspectiveOffCenterLH.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.