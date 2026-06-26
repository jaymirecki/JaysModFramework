# Vector3.Lerp Method (Vector3, Vector3, Single, Vector3)

﻿Vector3.Lerp Method (Vector3, Vector3, Single, Vector3)

|  |  |  |
| --- | --- | --- |
| Vector3Lerp Method (Vector3, Vector3, Single, Vector3) | RAGE Plugin Hook Documentation |  |

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
public static void Lerp(
	ref Vector3 start,
	ref Vector3 end,
	float amount,
	out Vector3 result
)
```

```
Public Shared Sub Lerp ( 
	ByRef start As Vector3,
	ByRef end As Vector3,
	amount As Single,
	<OutAttribute> ByRef result As Vector3
)
```

```
public:
static void Lerp(
	Vector3% start, 
	Vector3% end, 
	float amount, 
	[OutAttribute] Vector3% result
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

result
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    When the method completes, contains the linear interpolation of the two vectors.

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