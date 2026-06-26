# MathHelper.UnLerp Method (Int64, Int64, Int64)

﻿MathHelper.UnLerp Method (Int64, Int64, Int64)

|  |  |  |
| --- | --- | --- |
| MathHelperUnLerp Method (Int64, Int64, Int64) | RAGE Plugin Hook Documentation |  |

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
public static long UnLerp(
	long start,
	long end,
	long lerpedValue
)
```

```
Public Shared Function UnLerp ( 
	start As Long,
	end As Long,
	lerpedValue As Long
) As Long
```

```
public:
static long long UnLerp(
	long long start, 
	long long end, 
	long long lerpedValue
)
```

#### Parameters

start
:   Type: [SystemInt64](http://msdn2.microsoft.com/en-us/library/6yy583ek)  
    The start.

end
:   Type: [SystemInt64](http://msdn2.microsoft.com/en-us/library/6yy583ek)  
    The end.

lerpedValue
:   Type: [SystemInt64](http://msdn2.microsoft.com/en-us/library/6yy583ek)  
    The lerped value.

#### Return Value

Type: [Int64](http://msdn2.microsoft.com/en-us/library/6yy583ek)  
The lerp percentage.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[UnLerp Overload](Overload_Rage_MathHelper_UnLerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.