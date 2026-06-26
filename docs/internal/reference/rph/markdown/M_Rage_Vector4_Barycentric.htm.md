# Vector4.Barycentric Method (Vector4, Vector4, Vector4, Single, Single)

﻿Vector4.Barycentric Method (Vector4, Vector4, Vector4, Single, Single)

|  |  |  |
| --- | --- | --- |
| Vector4Barycentric Method (Vector4, Vector4, Vector4, Single, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Returns a [Vector4](T_Rage_Vector4.htm) containing the 4D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 4D triangle.

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
public static Vector4 Barycentric(
	Vector4 value1,
	Vector4 value2,
	Vector4 value3,
	float amount1,
	float amount2
)
```

```
Public Shared Function Barycentric ( 
	value1 As Vector4,
	value2 As Vector4,
	value3 As Vector4,
	amount1 As Single,
	amount2 As Single
) As Vector4
```

```
public:
static Vector4 Barycentric(
	Vector4 value1, 
	Vector4 value2, 
	Vector4 value3, 
	float amount1, 
	float amount2
)
```

#### Parameters

value1
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    A [Vector4](T_Rage_Vector4.htm) containing the 4D Cartesian coordinates of vertex 1 of the triangle.

value2
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    A [Vector4](T_Rage_Vector4.htm) containing the 4D Cartesian coordinates of vertex 2 of the triangle.

value3
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    A [Vector4](T_Rage_Vector4.htm) containing the 4D Cartesian coordinates of vertex 3 of the triangle.

amount1
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

amount2
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

#### Return Value

Type: [Vector4](T_Rage_Vector4.htm)  
A new [Vector4](T_Rage_Vector4.htm) containing the 4D Cartesian coordinates of the specified point.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[Barycentric Overload](Overload_Rage_Vector4_Barycentric.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.