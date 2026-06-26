# Matrix.Translation Method (Vector3)

﻿Matrix.Translation Method (Vector3)

|  |  |  |
| --- | --- | --- |
| MatrixTranslation Method (Vector3) | RAGE Plugin Hook Documentation |  |

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
	Vector3 amount
)
```

```
Public Shared Function Translation ( 
	amount As Vector3
) As Matrix
```

```
public:
static Matrix Translation(
	Vector3 amount
)
```

#### Parameters

amount
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The offset for all three coordinate planes.

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