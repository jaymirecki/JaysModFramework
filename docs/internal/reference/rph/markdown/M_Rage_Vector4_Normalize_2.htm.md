# Vector4.Normalize Method (Vector4, Vector4)

﻿Vector4.Normalize Method (Vector4, Vector4)

|  |  |  |
| --- | --- | --- |
| Vector4Normalize Method (Vector4, Vector4) | RAGE Plugin Hook Documentation |  |

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
	ref Vector4 vector,
	out Vector4 result
)
```

```
Public Shared Sub Normalize ( 
	ByRef vector As Vector4,
	<OutAttribute> ByRef result As Vector4
)
```

```
public:
static void Normalize(
	Vector4% vector, 
	[OutAttribute] Vector4% result
)
```

#### Parameters

vector
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The vector to normalize.

result
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    When the method completes, contains the normalized vector.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[Normalize Overload](Overload_Rage_Vector4_Normalize.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.