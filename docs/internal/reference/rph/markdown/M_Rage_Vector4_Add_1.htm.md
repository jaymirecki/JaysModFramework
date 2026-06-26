# Vector4.Add Method (Vector4, Vector4, Vector4)

﻿Vector4.Add Method (Vector4, Vector4, Vector4)

|  |  |  |
| --- | --- | --- |
| Vector4Add Method (Vector4, Vector4, Vector4) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Adds two vectors.

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
public static void Add(
	ref Vector4 left,
	ref Vector4 right,
	out Vector4 result
)
```

```
Public Shared Sub Add ( 
	ByRef left As Vector4,
	ByRef right As Vector4,
	<OutAttribute> ByRef result As Vector4
)
```

```
public:
static void Add(
	Vector4% left, 
	Vector4% right, 
	[OutAttribute] Vector4% result
)
```

#### Parameters

left
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The first vector to add.

right
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The second vector to add.

result
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    When the method completes, contains the sum of the two vectors.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[Add Overload](Overload_Rage_Vector4_Add.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.