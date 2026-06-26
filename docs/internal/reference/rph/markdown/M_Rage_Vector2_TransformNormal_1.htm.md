# Vector2.TransformNormal Method (Vector2, Matrix, Vector2)

﻿Vector2.TransformNormal Method (Vector2, Matrix, Vector2)

|  |  |  |
| --- | --- | --- |
| Vector2TransformNormal Method (Vector2, Matrix, Vector2) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Performs a normal transformation using the given Matrix.

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
public static void TransformNormal(
	ref Vector2 normal,
	ref Matrix transformation,
	out Vector2 result
)
```

```
Public Shared Sub TransformNormal ( 
	ByRef normal As Vector2,
	ByRef transformation As Matrix,
	<OutAttribute> ByRef result As Vector2
)
```

```
public:
static void TransformNormal(
	Vector2% normal, 
	Matrix% transformation, 
	[OutAttribute] Vector2% result
)
```

#### Parameters

normal
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The normal vector to transform.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The transformation Matrix.

result
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    When the method completes, contains the transformed normal.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[TransformNormal Overload](Overload_Rage_Vector2_TransformNormal.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.