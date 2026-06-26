# Quaternion.Barycentric Method (Quaternion, Quaternion, Quaternion, Single, Single)

﻿Quaternion.Barycentric Method (Quaternion, Quaternion, Quaternion, Single, Single)

|  |  |  |
| --- | --- | --- |
| QuaternionBarycentric Method (Quaternion, Quaternion, Quaternion, Single, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Returns a [Quaternion](T_Rage_Quaternion.htm) containing the 4D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 2D triangle.

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
public static Quaternion Barycentric(
	Quaternion source1,
	Quaternion source2,
	Quaternion source3,
	float weight1,
	float weight2
)
```

```
Public Shared Function Barycentric ( 
	source1 As Quaternion,
	source2 As Quaternion,
	source3 As Quaternion,
	weight1 As Single,
	weight2 As Single
) As Quaternion
```

```
public:
static Quaternion Barycentric(
	Quaternion source1, 
	Quaternion source2, 
	Quaternion source3, 
	float weight1, 
	float weight2
)
```

#### Parameters

source1
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    A [Quaternion](T_Rage_Quaternion.htm) containing the 4D Cartesian coordinates of vertex 1 of the triangle.

source2
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    A [Quaternion](T_Rage_Quaternion.htm) containing the 4D Cartesian coordinates of vertex 2 of the triangle.

source3
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    A [Quaternion](T_Rage_Quaternion.htm) containing the 4D Cartesian coordinates of vertex 3 of the triangle.

weight1
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in source2).

weight2
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in source3).

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
A new [Quaternion](T_Rage_Quaternion.htm) containing the 4D Cartesian coordinates of the specified point.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Barycentric Overload](Overload_Rage_Quaternion_Barycentric.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.