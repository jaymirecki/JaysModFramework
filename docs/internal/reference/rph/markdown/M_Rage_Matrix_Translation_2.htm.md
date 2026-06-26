# Matrix.Translation Method (Single, Single, Single)

﻿Matrix.Translation Method (Single, Single, Single)

|  |  |  |
| --- | --- | --- |
| MatrixTranslation Method (Single, Single, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a translation matrix using the specified offsets.

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
public static Matrix Translation(
	float x,
	float y,
	float z
)
```

```
Public Shared Function Translation ( 
	x As Single,
	y As Single,
	z As Single
) As Matrix
```

```
public:
static Matrix Translation(
	float x, 
	float y, 
	float z
)
```

#### Parameters

x
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    X-coordinate offset.

y
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Y-coordinate offset.

z
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Z-coordinate offset.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The created translation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Translation Overload](Overload_Rage_Matrix_Translation.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.