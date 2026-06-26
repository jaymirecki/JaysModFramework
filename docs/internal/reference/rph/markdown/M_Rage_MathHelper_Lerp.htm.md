# MathHelper.Lerp Method (Double, Double, Single)

﻿MathHelper.Lerp Method (Double, Double, Single)

|  |  |  |
| --- | --- | --- |
| MathHelperLerp Method (Double, Double, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a new value between the specified start and end values, designated by the percentage.

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
public static double Lerp(
	double start,
	double end,
	float percent
)
```

```
Public Shared Function Lerp ( 
	start As Double,
	end As Double,
	percent As Single
) As Double
```

```
public:
static double Lerp(
	double start, 
	double end, 
	float percent
)
```

#### Parameters

start
:   Type: [SystemDouble](http://msdn2.microsoft.com/en-us/library/643eft0t)  
    The start.

end
:   Type: [SystemDouble](http://msdn2.microsoft.com/en-us/library/643eft0t)  
    The end.

percent
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The percent.

#### Return Value

Type: [Double](http://msdn2.microsoft.com/en-us/library/643eft0t)  
The new value.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Lerp Overload](Overload_Rage_MathHelper_Lerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.