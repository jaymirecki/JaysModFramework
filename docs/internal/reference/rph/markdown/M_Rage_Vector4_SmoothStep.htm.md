# Vector4.SmoothStep Method (Vector4, Vector4, Single)

﻿Vector4.SmoothStep Method (Vector4, Vector4, Single)

|  |  |  |
| --- | --- | --- |
| Vector4SmoothStep Method (Vector4, Vector4, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Performs a cubic interpolation between two vectors.

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
public static Vector4 SmoothStep(
	Vector4 start,
	Vector4 end,
	float amount
)
```

```
Public Shared Function SmoothStep ( 
	start As Vector4,
	end As Vector4,
	amount As Single
) As Vector4
```

```
public:
static Vector4 SmoothStep(
	Vector4 start, 
	Vector4 end, 
	float amount
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

#### Return Value

Type: [Vector4](T_Rage_Vector4.htm)  
The cubic interpolation of the two vectors.

See Also

#### Reference

[Vector4 Structure](T_Rage_Vector4.htm)

[SmoothStep Overload](Overload_Rage_Vector4_SmoothStep.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.