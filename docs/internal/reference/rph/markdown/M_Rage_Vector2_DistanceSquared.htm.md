# Vector2.DistanceSquared Method

﻿Vector2.DistanceSquared Method 

|  |  |  |
| --- | --- | --- |
| Vector2DistanceSquared Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Calculates the squared distance between two vectors.

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
	Vector2 value1,
	Vector2 value2
)
```

```
Public Shared Function DistanceSquared ( 
	value1 As Vector2,
	value2 As Vector2
) As Single
```

```
public:
static float DistanceSquared(
	Vector2 value1, 
	Vector2 value2
)
```

#### Parameters

value1
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The first vector.

value2
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The second vector.

#### Return Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The squared distance between the two vectors.

Remarks

Distance squared is the value before taking the square root.
Distance squared can often be used in place of distance if relative comparisons are being made.
For example, consider three points A, B, and C. To determine whether B or C is further from A,
compare the distance between A and B to the distance between A and C. Calculating the two distances
involves two square roots, which are computationally expensive. However, using distance squared
provides the same information and avoids calculating two square roots.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.