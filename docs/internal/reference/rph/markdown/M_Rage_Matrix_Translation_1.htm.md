# Matrix.Translation Method (Vector3, Matrix)

﻿Matrix.Translation Method (Vector3, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixTranslation Method (Vector3, Matrix) | RAGE Plugin Hook Documentation |  |

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
public static void Translation(
	ref Vector3 amount,
	out Matrix result
)
```

```
Public Shared Sub Translation ( 
	ByRef amount As Vector3,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void Translation(
	Vector3% amount, 
	[OutAttribute] Matrix% result
)
```

#### Parameters

amount
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The offset for all three coordinate planes.

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    When the method completes, contains the created translation matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Translation Overload](Overload_Rage_Matrix_Translation.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.