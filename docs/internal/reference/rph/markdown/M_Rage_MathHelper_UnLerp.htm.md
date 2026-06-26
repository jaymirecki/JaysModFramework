# MathHelper.UnLerp Method (Double, Double, Double)

﻿MathHelper.UnLerp Method (Double, Double, Double)

|  |  |  |
| --- | --- | --- |
| MathHelperUnLerp Method (Double, Double, Double) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the original percentage provided to Lerp, given the start, end and lerped value.

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
public static double UnLerp(
	double start,
	double end,
	double lerpedValue
)
```

```
Public Shared Function UnLerp ( 
	start As Double,
	end As Double,
	lerpedValue As Double
) As Double
```

```
public:
static double UnLerp(
	double start, 
	double end, 
	double lerpedValue
)
```

#### Parameters

start
:   Type: [SystemDouble](http://msdn2.microsoft.com/en-us/library/643eft0t)  
    The start.

end
:   Type: [SystemDouble](http://msdn2.microsoft.com/en-us/library/643eft0t)  
    The end.

lerpedValue
:   Type: [SystemDouble](http://msdn2.microsoft.com/en-us/library/643eft0t)  
    The lerped value.

#### Return Value

Type: [Double](http://msdn2.microsoft.com/en-us/library/643eft0t)  
The lerp percentage.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[UnLerp Overload](Overload_Rage_MathHelper_UnLerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.