# Vector2.Lerp Method (Vector2, Vector2, Single)

﻿Vector2.Lerp Method (Vector2, Vector2, Single)

|  |  |  |
| --- | --- | --- |
| Vector2Lerp Method (Vector2, Vector2, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Performs a linear interpolation between two vectors.

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
public static Vector2 Lerp(
	Vector2 start,
	Vector2 end,
	float amount
)
```

```
Public Shared Function Lerp ( 
	start As Vector2,
	end As Vector2,
	amount As Single
) As Vector2
```

```
public:
static Vector2 Lerp(
	Vector2 start, 
	Vector2 end, 
	float amount
)
```

#### Parameters

start
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    Start vector.

end
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    End vector.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Value between 0 and 1 indicating the weight of end.

#### Return Value

Type: [Vector2](T_Rage_Vector2.htm)  
The linear interpolation of the two vectors.

Remarks

This method performs the linear interpolation based on the following formula.

[Copy](# "Copy")

```
start + (end - start) * amount
```

Passing amount a value of 0 will cause start to be returned; a value of 1 will cause end to be returned.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[Lerp Overload](Overload_Rage_Vector2_Lerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.