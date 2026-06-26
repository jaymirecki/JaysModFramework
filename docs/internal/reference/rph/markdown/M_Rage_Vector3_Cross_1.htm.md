# Vector3.Cross Method (Vector3, Vector3, Vector3)

﻿Vector3.Cross Method (Vector3, Vector3, Vector3)

|  |  |  |
| --- | --- | --- |
| Vector3Cross Method (Vector3, Vector3, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Calculates the cross product of two vectors.

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
public static void Cross(
	ref Vector3 left,
	ref Vector3 right,
	out Vector3 result
)
```

```
Public Shared Sub Cross ( 
	ByRef left As Vector3,
	ByRef right As Vector3,
	<OutAttribute> ByRef result As Vector3
)
```

```
public:
static void Cross(
	Vector3% left, 
	Vector3% right, 
	[OutAttribute] Vector3% result
)
```

#### Parameters

left
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    First source vector.

right
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    Second source vector.

result
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The cross product of the two vectors.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Cross Overload](Overload_Rage_Vector3_Cross.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.