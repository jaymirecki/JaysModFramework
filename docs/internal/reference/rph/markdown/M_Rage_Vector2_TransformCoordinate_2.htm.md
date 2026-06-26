# Vector2.TransformCoordinate Method (Vector2[], Matrix)

﻿Vector2.TransformCoordinate Method (Vector2[], Matrix)

|  |  |  |
| --- | --- | --- |
| Vector2TransformCoordinate Method (Vector2, Matrix) | RAGE Plugin Hook Documentation |  |

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
public static Vector2[] TransformCoordinate(
	Vector2[] coordinates,
	ref Matrix transformation
)
```

```
Public Shared Function TransformCoordinate ( 
	coordinates As Vector2(),
	ByRef transformation As Matrix
) As Vector2()
```

```
public:
static array<Vector2>^ TransformCoordinate(
	array<Vector2>^ coordinates, 
	Matrix% transformation
)
```

#### Parameters

coordinates
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The coordinate vectors to transform.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The transformation Matrix.

#### Return Value

Type: [Vector2](T_Rage_Vector2.htm)  
The transformed coordinates.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[TransformCoordinate Overload](Overload_Rage_Vector2_TransformCoordinate.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.