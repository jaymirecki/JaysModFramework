# Vector3.Maximize Method (Vector3, Vector3, Vector3)

﻿Vector3.Maximize Method (Vector3, Vector3, Vector3)

|  |  |  |
| --- | --- | --- |
| Vector3Maximize Method (Vector3, Vector3, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Returns a vector containing the smallest components of the specified vectors.

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
public static void Maximize(
	ref Vector3 value1,
	ref Vector3 value2,
	out Vector3 result
)
```

```
Public Shared Sub Maximize ( 
	ByRef value1 As Vector3,
	ByRef value2 As Vector3,
	<OutAttribute> ByRef result As Vector3
)
```

```
public:
static void Maximize(
	Vector3% value1, 
	Vector3% value2, 
	[OutAttribute] Vector3% result
)
```

#### Parameters

value1
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The first source vector.

value2
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The second source vector.

result
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    When the method completes, contains an new vector composed of the largest components of the source vectors.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Maximize Overload](Overload_Rage_Vector3_Maximize.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.