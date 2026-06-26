# Matrix.Decompose Method

﻿Matrix.Decompose Method 

|  |  |  |
| --- | --- | --- |
| MatrixDecompose Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Decomposes the matrix into its scalar, rotational, and translational elements.

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
public bool Decompose(
	out Vector3 scale,
	out Quaternion rotation,
	out Vector3 translation
)
```

```
Public Function Decompose ( 
	<OutAttribute> ByRef scale As Vector3,
	<OutAttribute> ByRef rotation As Quaternion,
	<OutAttribute> ByRef translation As Vector3
) As Boolean
```

```
public:
bool Decompose(
	[OutAttribute] Vector3% scale, 
	[OutAttribute] Quaternion% rotation, 
	[OutAttribute] Vector3% translation
)
```

#### Parameters

scale
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    When the method completes, contains the scalar element of the matrix.

rotation
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    When the method completes, contains the translational element of the matrix.

translation
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    When the method completes, contains the rotational element of the matrix.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if the decomposition was successful; otherwise, false.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.