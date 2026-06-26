# Vector4.Lerp Method (Vector4, Vector4, Single, Vector4)

﻿Vector4.Lerp Method (Vector4, Vector4, Single, Vector4)

|  |  |  |
| --- | --- | --- |
| Vector4Lerp Method (Vector4, Vector4, Single, Vector4) | RAGE Plugin Hook Documentation |  |

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
	ref Vector4 start,
	ref Vector4 end,
	float amount,
	out Vector4 result
)
```

```
Public Shared Sub Lerp ( 
	ByRef start As Vector4,
	ByRef end As Vector4,
	amount As Single,
	<OutAttribute> ByRef result As Vector4
)
```

```
public:
static void Lerp(
	Vector4% start, 
	Vector4% end, 
	float amount, 
	[OutAttribute] Vector4% result
)
```

#### Parameters

start
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    Start vector.

end
:   Type: [RageVector4](T_Rage_Vector4.htm)  
    End vector.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Value between 0 and 1 indicating the weight of end.

result
:   Type: [RageVector4](T_Rage_Vector4.htm)  
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

[Vector4 Structure](T_Rage_Vector4.htm)

[Lerp Overload](Overload_Rage_Vector4_Lerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.