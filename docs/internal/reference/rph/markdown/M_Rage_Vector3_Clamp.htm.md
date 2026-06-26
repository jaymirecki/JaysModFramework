# Vector3.Clamp Method (Vector3, Vector3, Vector3)

﻿Vector3.Clamp Method (Vector3, Vector3, Vector3)

|  |  |  |
| --- | --- | --- |
| Vector3Clamp Method (Vector3, Vector3, Vector3) | RAGE Plugin Hook Documentation |  |

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
public static Vector3 Clamp(
	Vector3 value,
	Vector3 min,
	Vector3 max
)
```

```
Public Shared Function Clamp ( 
	value As Vector3,
	min As Vector3,
	max As Vector3
) As Vector3
```

```
public:
static Vector3 Clamp(
	Vector3 value, 
	Vector3 min, 
	Vector3 max
)
```

#### Parameters

value
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The value to clamp.

min
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The minimum value.

max
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The maximum value.

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
The clamped value.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Clamp Overload](Overload_Rage_Vector3_Clamp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.