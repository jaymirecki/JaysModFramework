# Vector3.TransformCoordinate Method (Vector3[], Matrix)

﻿Vector3.TransformCoordinate Method (Vector3[], Matrix)

|  |  |  |
| --- | --- | --- |
| Vector3TransformCoordinate Method (Vector3, Matrix) | RAGE Plugin Hook Documentation |  |

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
public static Vector3[] TransformCoordinate(
	Vector3[] coordinates,
	ref Matrix transformation
)
```

```
Public Shared Function TransformCoordinate ( 
	coordinates As Vector3(),
	ByRef transformation As Matrix
) As Vector3()
```

```
public:
static array<Vector3>^ TransformCoordinate(
	array<Vector3>^ coordinates, 
	Matrix% transformation
)
```

#### Parameters

coordinates
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The coordinate vectors to transform.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The transformation Matrix.

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
The transformed coordinates.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[TransformCoordinate Overload](Overload_Rage_Vector3_TransformCoordinate.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.