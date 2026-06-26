# Vector3.DistanceSquared Method (Vector3, ISpatial)

﻿Vector3.DistanceSquared Method (Vector3, ISpatial)

|  |  |  |
| --- | --- | --- |
| Vector3DistanceSquared Method (Vector3, ISpatial) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Calculates the distance between a vector and a [ISpatial](T_Rage_ISpatial.htm), ignoring the Z-component.

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
public static float DistanceSquared(
	Vector3 value1,
	ISpatial spatialObject
)
```

```
Public Shared Function DistanceSquared ( 
	value1 As Vector3,
	spatialObject As ISpatial
) As Single
```

```
public:
static float DistanceSquared(
	Vector3 value1, 
	ISpatial^ spatialObject
)
```

#### Parameters

value1
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The first vector.

spatialObject
:   Type: [RageISpatial](T_Rage_ISpatial.htm)  
    The [ISpatial](T_Rage_ISpatial.htm).

#### Return Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The squared distance between the vector and the [ISpatial](T_Rage_ISpatial.htm).

Remarks

Distance squared is the value before taking the square root.
Distance squared can often be used in place of distance if relative comparisons are being made.
For example, consider three points A, B, and C. To determine whether B or C is further from A,
compare the distance between A and B to the distance between A and C. Calculating the two distances
involves two square roots, which are computationally expensive. However, using distance squared
provides the same information and avoids calculating two square roots.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[DistanceSquared Overload](Overload_Rage_Vector3_DistanceSquared.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.