# Vector3.Normalize Method (Vector3, Vector3)

﻿Vector3.Normalize Method (Vector3, Vector3)

|  |  |  |
| --- | --- | --- |
| Vector3Normalize Method (Vector3, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Converts the vector into a unit vector.

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
public static void Normalize(
	ref Vector3 vector,
	out Vector3 result
)
```

```
Public Shared Sub Normalize ( 
	ByRef vector As Vector3,
	<OutAttribute> ByRef result As Vector3
)
```

```
public:
static void Normalize(
	Vector3% vector, 
	[OutAttribute] Vector3% result
)
```

#### Parameters

vector
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The vector to normalize.

result
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    When the method completes, contains the normalized vector.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Normalize Overload](Overload_Rage_Vector3_Normalize.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.