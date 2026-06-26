# Matrix.LookAtRH Method (Vector3, Vector3, Vector3)

﻿Matrix.LookAtRH Method (Vector3, Vector3, Vector3)

|  |  |  |
| --- | --- | --- |
| MatrixLookAtRH Method (Vector3, Vector3, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a right-handed, look-at matrix.

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
public static Matrix LookAtRH(
	Vector3 eye,
	Vector3 target,
	Vector3 up
)
```

```
Public Shared Function LookAtRH ( 
	eye As Vector3,
	target As Vector3,
	up As Vector3
) As Matrix
```

```
public:
static Matrix LookAtRH(
	Vector3 eye, 
	Vector3 target, 
	Vector3 up
)
```

#### Parameters

eye
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position of the viewer's eye.

target
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The camera look-at target.

up
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The camera's up vector.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The created look-at matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[LookAtRH Overload](Overload_Rage_Matrix_LookAtRH.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.