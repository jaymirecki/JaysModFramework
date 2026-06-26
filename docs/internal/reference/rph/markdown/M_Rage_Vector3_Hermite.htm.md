# Vector3.Hermite Method (Vector3, Vector3, Vector3, Vector3, Single)

﻿Vector3.Hermite Method (Vector3, Vector3, Vector3, Vector3, Single)

|  |  |  |
| --- | --- | --- |
| Vector3Hermite Method (Vector3, Vector3, Vector3, Vector3, Single) | RAGE Plugin Hook Documentation |  |

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
public static Vector3 Hermite(
	Vector3 value1,
	Vector3 tangent1,
	Vector3 value2,
	Vector3 tangent2,
	float amount
)
```

```
Public Shared Function Hermite ( 
	value1 As Vector3,
	tangent1 As Vector3,
	value2 As Vector3,
	tangent2 As Vector3,
	amount As Single
) As Vector3
```

```
public:
static Vector3 Hermite(
	Vector3 value1, 
	Vector3 tangent1, 
	Vector3 value2, 
	Vector3 tangent2, 
	float amount
)
```

#### Parameters

value1
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    First source position vector.

tangent1
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    First source tangent vector.

value2
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    Second source position vector.

tangent2
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    Second source tangent vector.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Weighting factor.

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
The result of the Hermite spline interpolation.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Hermite Overload](Overload_Rage_Vector3_Hermite.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.