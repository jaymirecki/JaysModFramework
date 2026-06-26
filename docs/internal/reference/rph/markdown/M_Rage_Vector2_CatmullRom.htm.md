# Vector2.CatmullRom Method (Vector2, Vector2, Vector2, Vector2, Single)

﻿Vector2.CatmullRom Method (Vector2, Vector2, Vector2, Vector2, Single)

|  |  |  |
| --- | --- | --- |
| Vector2CatmullRom Method (Vector2, Vector2, Vector2, Vector2, Single) | RAGE Plugin Hook Documentation |  |

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
public static Vector2 CatmullRom(
	Vector2 value1,
	Vector2 value2,
	Vector2 value3,
	Vector2 value4,
	float amount
)
```

```
Public Shared Function CatmullRom ( 
	value1 As Vector2,
	value2 As Vector2,
	value3 As Vector2,
	value4 As Vector2,
	amount As Single
) As Vector2
```

```
public:
static Vector2 CatmullRom(
	Vector2 value1, 
	Vector2 value2, 
	Vector2 value3, 
	Vector2 value4, 
	float amount
)
```

#### Parameters

value1
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The first position in the interpolation.

value2
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The second position in the interpolation.

value3
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The third position in the interpolation.

value4
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The fourth position in the interpolation.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Weighting factor.

#### Return Value

Type: [Vector2](T_Rage_Vector2.htm)  
A vector that is the result of the Catmull-Rom interpolation.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[CatmullRom Overload](Overload_Rage_Vector2_CatmullRom.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.