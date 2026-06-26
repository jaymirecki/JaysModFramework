# Vector2.TransformCoordinate Method (Vector2, Matrix, Vector2)

﻿Vector2.TransformCoordinate Method (Vector2, Matrix, Vector2)

|  |  |  |
| --- | --- | --- |
| Vector2TransformCoordinate Method (Vector2, Matrix, Vector2) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Performs a coordinate transformation using the given Matrix.

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
public static void TransformCoordinate(
	ref Vector2 coordinate,
	ref Matrix transformation,
	out Vector2 result
)
```

```
Public Shared Sub TransformCoordinate ( 
	ByRef coordinate As Vector2,
	ByRef transformation As Matrix,
	<OutAttribute> ByRef result As Vector2
)
```

```
public:
static void TransformCoordinate(
	Vector2% coordinate, 
	Matrix% transformation, 
	[OutAttribute] Vector2% result
)
```

#### Parameters

coordinate
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The coordinate vector to transform.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The transformation Matrix.

result
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    When the method completes, contains the transformed coordinates.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[TransformCoordinate Overload](Overload_Rage_Vector2_TransformCoordinate.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.