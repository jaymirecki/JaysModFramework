# Vector3.Reflect Method (Vector3, Vector3, Vector3)

﻿Vector3.Reflect Method (Vector3, Vector3, Vector3)

|  |  |  |
| --- | --- | --- |
| Vector3Reflect Method (Vector3, Vector3, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Returns the reflection of a vector off a surface that has the specified normal.

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
public static void Reflect(
	ref Vector3 vector,
	ref Vector3 normal,
	out Vector3 result
)
```

```
Public Shared Sub Reflect ( 
	ByRef vector As Vector3,
	ByRef normal As Vector3,
	<OutAttribute> ByRef result As Vector3
)
```

```
public:
static void Reflect(
	Vector3% vector, 
	Vector3% normal, 
	[OutAttribute] Vector3% result
)
```

#### Parameters

vector
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The source vector.

normal
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    Normal of the surface.

result
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    When the method completes, contains the reflected vector.

Remarks

Reflect only gives the direction of a reflection off a surface, it does not determine
whether the original vector was close enough to the surface to hit it.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Reflect Overload](Overload_Rage_Vector3_Reflect.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.