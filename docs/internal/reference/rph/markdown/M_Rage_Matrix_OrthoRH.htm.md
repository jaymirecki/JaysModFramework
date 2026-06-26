# Matrix.OrthoRH Method (Single, Single, Single, Single)

﻿Matrix.OrthoRH Method (Single, Single, Single, Single)

|  |  |  |
| --- | --- | --- |
| MatrixOrthoRH Method (Single, Single, Single, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a right-handed, orthographic projection matrix.

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
public static Matrix OrthoRH(
	float width,
	float height,
	float znear,
	float zfar
)
```

```
Public Shared Function OrthoRH ( 
	width As Single,
	height As Single,
	znear As Single,
	zfar As Single
) As Matrix
```

```
public:
static Matrix OrthoRH(
	float width, 
	float height, 
	float znear, 
	float zfar
)
```

#### Parameters

width
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Width of the viewing volume.

height
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Height of the viewing volume.

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

[OrthoRH Overload](Overload_Rage_Matrix_OrthoRH.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.