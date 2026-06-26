# Matrix.LookAtLH Method (Vector3, Vector3, Vector3, Matrix)

﻿Matrix.LookAtLH Method (Vector3, Vector3, Vector3, Matrix)

|  |  |  |
| --- | --- | --- |
| MatrixLookAtLH Method (Vector3, Vector3, Vector3, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a left-handed, look-at matrix.

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
public static void LookAtLH(
	ref Vector3 eye,
	ref Vector3 target,
	ref Vector3 up,
	out Matrix result
)
```

```
Public Shared Sub LookAtLH ( 
	ByRef eye As Vector3,
	ByRef target As Vector3,
	ByRef up As Vector3,
	<OutAttribute> ByRef result As Matrix
)
```

```
public:
static void LookAtLH(
	Vector3% eye, 
	Vector3% target, 
	Vector3% up, 
	[OutAttribute] Matrix% result
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

result
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    When the method completes, contains the created look-at matrix.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[LookAtLH Overload](Overload_Rage_Matrix_LookAtLH.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.