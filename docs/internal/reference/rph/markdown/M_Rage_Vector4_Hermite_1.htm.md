# Vector4.Hermite Method (Vector4, Vector4, Vector4, Vector4, Single, Vector4)

﻿Vector4.Hermite Method (Vector4, Vector4, Vector4, Vector4, Single, Vector4)

|  |  |  |
| --- | --- | --- |
| Vector4Hermite Method (Vector4, Vector4, Vector4, Vector4, Single, Vector4) | RAGE Plugin Hook Documentation |  |

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
public static void Hermite(
	ref Vector4 value1,
	ref Vector4 tangent1,
	ref Vector4 value2,
	ref Vector4 tangent2,
	float amount,
	out Vector4 result
)
```

```
Public Shared Sub Hermite ( 
	ByRef value1 As Vector4,
	ByRef tangent1 As Vector4,
	ByRef value2 As Vector4,
	ByRef tangent2 As Vector4,
	amount As Single,
	<OutAttribute> ByRef result As Vector4
)
```

```
public:
static void Hermite(
	Vector4% value1, 
	Vector4% tangent1, 
	Vector4% value2, 
	Vector4% tangent2, 
	float amount, 
	[OutAttribute] Vector4% result
)
```

#### Parameters

value1
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    First source position vector.

tangent1
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    First source tangent vector.

value2
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    Second source position vector.

tangent2
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    Second source tangent vector.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Weighting factor.

result
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    When the method completes, contains the result of the Hermite spline interpolation.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[Hermite Overload](Overload_Rage_Vector4_Hermite.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.