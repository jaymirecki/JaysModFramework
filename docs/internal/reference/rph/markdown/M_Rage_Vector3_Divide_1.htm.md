# Vector3.Divide Method (Vector3, Single, Vector3)

﻿Vector3.Divide Method (Vector3, Single, Vector3)

|  |  |  |
| --- | --- | --- |
| Vector3Divide Method (Vector3, Single, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Scales a vector by the given value.

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
public static void Divide(
	ref Vector3 vector,
	float scale,
	out Vector3 result
)
```

```
Public Shared Sub Divide ( 
	ByRef vector As Vector3,
	scale As Single,
	<OutAttribute> ByRef result As Vector3
)
```

```
public:
static void Divide(
	Vector3% vector, 
	float scale, 
	[OutAttribute] Vector3% result
)
```

#### Parameters

vector
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The vector to scale.

scale
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The amount by which to scale the vector.

result
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    When the method completes, contains the scaled vector.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Divide Overload](Overload_Rage_Vector3_Divide.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.