# Vector3.Unproject Method (Vector3, Single, Single, Single, Single, Single, Single, Matrix, Vector3)

﻿Vector3.Unproject Method (Vector3, Single, Single, Single, Single, Single, Single, Matrix, Vector3)

|  |  |  |
| --- | --- | --- |
| Vector3Unproject Method (Vector3, Single, Single, Single, Single, Single, Single, Matrix, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Projects a 3D vector from screen space into object space.

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
public static void Unproject(
	ref Vector3 vector,
	float x,
	float y,
	float width,
	float height,
	float minZ,
	float maxZ,
	ref Matrix worldViewProjection,
	out Vector3 result
)
```

```
Public Shared Sub Unproject ( 
	ByRef vector As Vector3,
	x As Single,
	y As Single,
	width As Single,
	height As Single,
	minZ As Single,
	maxZ As Single,
	ByRef worldViewProjection As Matrix,
	<OutAttribute> ByRef result As Vector3
)
```

```
public:
static void Unproject(
	Vector3% vector, 
	float x, 
	float y, 
	float width, 
	float height, 
	float minZ, 
	float maxZ, 
	Matrix% worldViewProjection, 
	[OutAttribute] Vector3% result
)
```

#### Parameters

vector
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The vector to project.

x
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The X position of the viewport.

y
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The Y position of the viewport.

width
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The width of the viewport.

height
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The height of the viewport.

minZ
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The minimum depth of the viewport.

maxZ
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The maximum depth of the viewport.

worldViewProjection
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    The combined world-view-projection matrix.

result
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    When the method completes, contains the vector in object space.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Unproject Overload](Overload_Rage_Vector3_Unproject.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.