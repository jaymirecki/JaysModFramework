# MathHelper.UnLerp Method (Int32, Int32, Int32)

﻿MathHelper.UnLerp Method (Int32, Int32, Int32)

|  |  |  |
| --- | --- | --- |
| MathHelperUnLerp Method (Int32, Int32, Int32) | RAGE Plugin Hook Documentation |  |

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
public static int UnLerp(
	int start,
	int end,
	int lerpedValue
)
```

```
Public Shared Function UnLerp ( 
	start As Integer,
	end As Integer,
	lerpedValue As Integer
) As Integer
```

```
public:
static int UnLerp(
	int start, 
	int end, 
	int lerpedValue
)
```

#### Parameters

start
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The start.

end
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The end.

lerpedValue
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The lerped value.

#### Return Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
The lerp percentage.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[UnLerp Overload](Overload_Rage_MathHelper_UnLerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.