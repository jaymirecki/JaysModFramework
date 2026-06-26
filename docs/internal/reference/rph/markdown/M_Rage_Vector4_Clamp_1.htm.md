# Vector4.Clamp Method (Vector4, Vector4, Vector4, Vector4)

﻿Vector4.Clamp Method (Vector4, Vector4, Vector4, Vector4)

|  |  |  |
| --- | --- | --- |
| Vector4Clamp Method (Vector4, Vector4, Vector4, Vector4) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Restricts a value to be within a specified range.

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
public static void Clamp(
	ref Vector4 value,
	ref Vector4 min,
	ref Vector4 max,
	out Vector4 result
)
```

```
Public Shared Sub Clamp ( 
	ByRef value As Vector4,
	ByRef min As Vector4,
	ByRef max As Vector4,
	<OutAttribute> ByRef result As Vector4
)
```

```
public:
static void Clamp(
	Vector4% value, 
	Vector4% min, 
	Vector4% max, 
	[OutAttribute] Vector4% result
)
```

#### Parameters

value
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The value to clamp.

min
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The minimum value.

max
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The maximum value.

result
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    When the method completes, contains the clamped value.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[Clamp Overload](Overload_Rage_Vector4_Clamp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.