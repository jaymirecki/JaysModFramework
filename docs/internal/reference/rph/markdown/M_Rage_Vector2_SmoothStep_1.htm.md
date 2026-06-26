# Vector2.SmoothStep Method (Vector2, Vector2, Single, Vector2)

﻿Vector2.SmoothStep Method (Vector2, Vector2, Single, Vector2)

|  |  |  |
| --- | --- | --- |
| Vector2SmoothStep Method (Vector2, Vector2, Single, Vector2) | RAGE Plugin Hook Documentation |  |

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
public static void SmoothStep(
	ref Vector2 start,
	ref Vector2 end,
	float amount,
	out Vector2 result
)
```

```
Public Shared Sub SmoothStep ( 
	ByRef start As Vector2,
	ByRef end As Vector2,
	amount As Single,
	<OutAttribute> ByRef result As Vector2
)
```

```
public:
static void SmoothStep(
	Vector2% start, 
	Vector2% end, 
	float amount, 
	[OutAttribute] Vector2% result
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

result
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    When the method completes, contains the cubic interpolation of the two vectors.

See Also

#### Reference

[Vector2 Structure](T_Rage_Vector2.htm)

[SmoothStep Overload](Overload_Rage_Vector2_SmoothStep.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.