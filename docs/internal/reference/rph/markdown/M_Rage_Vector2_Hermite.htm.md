# Vector2.Hermite Method (Vector2, Vector2, Vector2, Vector2, Single)

﻿Vector2.Hermite Method (Vector2, Vector2, Vector2, Vector2, Single)

|  |  |  |
| --- | --- | --- |
| Vector2Hermite Method (Vector2, Vector2, Vector2, Vector2, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Performs a Hermite spline interpolation.

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
public static Vector2 Hermite(
	Vector2 value1,
	Vector2 tangent1,
	Vector2 value2,
	Vector2 tangent2,
	float amount
)
```

```
Public Shared Function Hermite ( 
	value1 As Vector2,
	tangent1 As Vector2,
	value2 As Vector2,
	tangent2 As Vector2,
	amount As Single
) As Vector2
```

```
public:
static Vector2 Hermite(
	Vector2 value1, 
	Vector2 tangent1, 
	Vector2 value2, 
	Vector2 tangent2, 
	float amount
)
```

#### Parameters

value1
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    First source position vector.

tangent1
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    First source tangent vector.

value2
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    Second source position vector.

tangent2
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    Second source tangent vector.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Weighting factor.

#### Return Value

Type: [Vector2](T_Rage_Vector2.htm)  
The result of the Hermite spline interpolation.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Hermite Overload](Overload_Rage_Vector2_Hermite.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.