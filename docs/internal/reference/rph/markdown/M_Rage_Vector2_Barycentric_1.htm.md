# Vector2.Barycentric Method (Vector2, Vector2, Vector2, Single, Single, Vector2)

﻿Vector2.Barycentric Method (Vector2, Vector2, Vector2, Single, Single, Vector2)

|  |  |  |
| --- | --- | --- |
| Vector2Barycentric Method (Vector2, Vector2, Vector2, Single, Single, Vector2) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Returns a [Vector2](T_Rage_Vector2.htm) containing the 2D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 2D triangle.

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
public static void Barycentric(
	ref Vector2 value1,
	ref Vector2 value2,
	ref Vector2 value3,
	float amount1,
	float amount2,
	out Vector2 result
)
```

```
Public Shared Sub Barycentric ( 
	ByRef value1 As Vector2,
	ByRef value2 As Vector2,
	ByRef value3 As Vector2,
	amount1 As Single,
	amount2 As Single,
	<OutAttribute> ByRef result As Vector2
)
```

```
public:
static void Barycentric(
	Vector2% value1, 
	Vector2% value2, 
	Vector2% value3, 
	float amount1, 
	float amount2, 
	[OutAttribute] Vector2% result
)
```

#### Parameters

value1
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    A [Vector2](T_Rage_Vector2.htm) containing the 2D Cartesian coordinates of vertex 1 of the triangle.

value2
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    A [Vector2](T_Rage_Vector2.htm) containing the 2D Cartesian coordinates of vertex 2 of the triangle.

value3
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    A [Vector2](T_Rage_Vector2.htm) containing the 2D Cartesian coordinates of vertex 3 of the triangle.

amount1
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

amount2
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

result
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    When the method completes, contains the 2D Cartesian coordinates of the specified point.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Barycentric Overload](Overload_Rage_Vector2_Barycentric.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.