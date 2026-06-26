# Vector3.Project Method (Vector3, Single, Single, Single, Single, Single, Single, Matrix)

﻿Vector3.Project Method (Vector3, Single, Single, Single, Single, Single, Single, Matrix)

|  |  |  |
| --- | --- | --- |
| Vector3Project Method (Vector3, Single, Single, Single, Single, Single, Single, Matrix) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Projects a 3D vector from object space into screen space.

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
public static Vector3 Project(
	Vector3 vector,
	float x,
	float y,
	float width,
	float height,
	float minZ,
	float maxZ,
	Matrix worldViewProjection
)
```

```
Public Shared Function Project ( 
	vector As Vector3,
	x As Single,
	y As Single,
	width As Single,
	height As Single,
	minZ As Single,
	maxZ As Single,
	worldViewProjection As Matrix
) As Vector3
```

```
public:
static Vector3 Project(
	Vector3 vector, 
	float x, 
	float y, 
	float width, 
	float height, 
	float minZ, 
	float maxZ, 
	Matrix worldViewProjection
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

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
The vector in screen space.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Project Overload](Overload_Rage_Vector3_Project.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.