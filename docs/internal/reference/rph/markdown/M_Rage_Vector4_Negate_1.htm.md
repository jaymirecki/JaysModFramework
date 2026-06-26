# Vector4.Negate Method (Vector4, Vector4)

﻿Vector4.Negate Method (Vector4, Vector4)

|  |  |  |
| --- | --- | --- |
| Vector4Negate Method (Vector4, Vector4) | RAGE Plugin Hook Documentation |  |

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
	ref Vector4 value,
	out Vector4 result
)
```

```
Public Shared Sub Negate ( 
	ByRef value As Vector4,
	<OutAttribute> ByRef result As Vector4
)
```

```
public:
static void Negate(
	Vector4% value, 
	[OutAttribute] Vector4% result
)
```

#### Parameters

value
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The vector to negate.

result
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    When the method completes, contains a vector facing in the opposite direction.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[Negate Overload](Overload_Rage_Vector4_Negate.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.