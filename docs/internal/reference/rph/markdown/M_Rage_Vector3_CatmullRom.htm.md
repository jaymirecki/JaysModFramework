# Vector3.CatmullRom Method (Vector3, Vector3, Vector3, Vector3, Single)

﻿Vector3.CatmullRom Method (Vector3, Vector3, Vector3, Vector3, Single)

|  |  |  |
| --- | --- | --- |
| Vector3CatmullRom Method (Vector3, Vector3, Vector3, Vector3, Single) | RAGE Plugin Hook Documentation |  |

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
public static Vector3 CatmullRom(
	Vector3 value1,
	Vector3 value2,
	Vector3 value3,
	Vector3 value4,
	float amount
)
```

```
Public Shared Function CatmullRom ( 
	value1 As Vector3,
	value2 As Vector3,
	value3 As Vector3,
	value4 As Vector3,
	amount As Single
) As Vector3
```

```
public:
static Vector3 CatmullRom(
	Vector3 value1, 
	Vector3 value2, 
	Vector3 value3, 
	Vector3 value4, 
	float amount
)
```

#### Parameters

value1
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The first position in the interpolation.

value2
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The second position in the interpolation.

value3
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The third position in the interpolation.

value4
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The fourth position in the interpolation.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Weighting factor.

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
A vector that is the result of the Catmull-Rom interpolation.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[CatmullRom Overload](Overload_Rage_Vector3_CatmullRom.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.