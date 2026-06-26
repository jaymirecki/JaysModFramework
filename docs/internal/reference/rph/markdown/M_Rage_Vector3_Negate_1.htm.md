# Vector3.Negate Method (Vector3, Vector3)

﻿Vector3.Negate Method (Vector3, Vector3)

|  |  |  |
| --- | --- | --- |
| Vector3Negate Method (Vector3, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Reverses the direction of a given vector.

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
public static void Negate(
	ref Vector3 value,
	out Vector3 result
)
```

```
Public Shared Sub Negate ( 
	ByRef value As Vector3,
	<OutAttribute> ByRef result As Vector3
)
```

```
public:
static void Negate(
	Vector3% value, 
	[OutAttribute] Vector3% result
)
```

#### Parameters

value
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The vector to negate.

result
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    When the method completes, contains a vector facing in the opposite direction.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Negate Overload](Overload_Rage_Vector3_Negate.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.