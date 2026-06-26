# Vector4.CatmullRom Method (Vector4, Vector4, Vector4, Vector4, Single, Vector4)

﻿Vector4.CatmullRom Method (Vector4, Vector4, Vector4, Vector4, Single, Vector4)

|  |  |  |
| --- | --- | --- |
| Vector4CatmullRom Method (Vector4, Vector4, Vector4, Vector4, Single, Vector4) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Performs a Catmull-Rom interpolation using the specified positions.

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
public static void CatmullRom(
	ref Vector4 value1,
	ref Vector4 value2,
	ref Vector4 value3,
	ref Vector4 value4,
	float amount,
	out Vector4 result
)
```

```
Public Shared Sub CatmullRom ( 
	ByRef value1 As Vector4,
	ByRef value2 As Vector4,
	ByRef value3 As Vector4,
	ByRef value4 As Vector4,
	amount As Single,
	<OutAttribute> ByRef result As Vector4
)
```

```
public:
static void CatmullRom(
	Vector4% value1, 
	Vector4% value2, 
	Vector4% value3, 
	Vector4% value4, 
	float amount, 
	[OutAttribute] Vector4% result
)
```

#### Parameters

value1
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The first position in the interpolation.

value2
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The second position in the interpolation.

value3
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The third position in the interpolation.

value4
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    The fourth position in the interpolation.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Weighting factor.

result
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    When the method completes, contains the result of the Catmull-Rom interpolation.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[CatmullRom Overload](Overload_Rage_Vector4_CatmullRom.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.