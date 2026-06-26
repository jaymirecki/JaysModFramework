# Vector4.Maximize Method (Vector4, Vector4, Vector4)

﻿Vector4.Maximize Method (Vector4, Vector4, Vector4)

|  |  |  |
| --- | --- | --- |
| Vector4Maximize Method (Vector4, Vector4, Vector4) | RAGE Plugin Hook Documentation |  |

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
	ref Vector4 value1,
	ref Vector4 value2,
	out Vector4 result
)
```

```
Public Shared Sub Maximize ( 
	ByRef value1 As Vector4,
	ByRef value2 As Vector4,
	<OutAttribute> ByRef result As Vector4
)
```

```
public:
static void Maximize(
	Vector4% value1, 
	Vector4% value2, 
	[OutAttribute] Vector4% result
)
```

#### Parameters

value1
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The first source vector.

value2
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The second source vector.

result
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    When the method completes, contains an new vector composed of the largest components of the source vectors.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[Maximize Overload](Overload_Rage_Vector4_Maximize.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.