# Vector2.Transform Method (Vector2, Quaternion)

﻿Vector2.Transform Method (Vector2, Quaternion)

|  |  |  |
| --- | --- | --- |
| Vector2Transform Method (Vector2, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Transforms a 2D vector by the given Quaternion rotation.

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
public static Vector4 Transform(
	Vector2 vector,
	Quaternion rotation
)
```

```
Public Shared Function Transform ( 
	vector As Vector2,
	rotation As Quaternion
) As Vector4
```

```
public:
static Vector4 Transform(
	Vector2 vector, 
	Quaternion rotation
)
```

#### Parameters

vector
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The vector to rotate.

rotation
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The Quaternion rotation to apply.

#### Return Value

Type: [Vector4](T_Rage_Vector4.htm)  
The transformed Vector4.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Transform Overload](Overload_Rage_Vector2_Transform.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.