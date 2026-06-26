# Vector3.Lerp Method (Vector3, Vector3, Single)

﻿Vector3.Lerp Method (Vector3, Vector3, Single)

|  |  |  |
| --- | --- | --- |
| Vector3Lerp Method (Vector3, Vector3, Single) | RAGE Plugin Hook Documentation |  |

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
public static Vector3 Lerp(
	Vector3 start,
	Vector3 end,
	float amount
)
```

```
Public Shared Function Lerp ( 
	start As Vector3,
	end As Vector3,
	amount As Single
) As Vector3
```

```
public:
static Vector3 Lerp(
	Vector3 start, 
	Vector3 end, 
	float amount
)
```

#### Parameters

start
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    Start vector.

end
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    End vector.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Value between 0 and 1 indicating the weight of end.

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
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

[Vector3 Structure](T_Rage_Vector3.htm)

[Lerp Overload](Overload_Rage_Vector3_Lerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.