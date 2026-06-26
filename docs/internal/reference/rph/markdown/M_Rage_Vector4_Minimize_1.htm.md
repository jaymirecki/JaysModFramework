# Vector4.Minimize Method (Vector4, Vector4, Vector4)

﻿Vector4.Minimize Method (Vector4, Vector4, Vector4)

|  |  |  |
| --- | --- | --- |
| Vector4Minimize Method (Vector4, Vector4, Vector4) | RAGE Plugin Hook Documentation |  |

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
public static void Minimize(
	ref Vector4 value1,
	ref Vector4 value2,
	out Vector4 result
)
```

```
Public Shared Sub Minimize ( 
	ByRef value1 As Vector4,
	ByRef value2 As Vector4,
	<OutAttribute> ByRef result As Vector4
)
```

```
public:
static void Minimize(
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
    When the method completes, contains an new vector composed of the smallest components of the source vectors.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[Minimize Overload](Overload_Rage_Vector4_Minimize.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.