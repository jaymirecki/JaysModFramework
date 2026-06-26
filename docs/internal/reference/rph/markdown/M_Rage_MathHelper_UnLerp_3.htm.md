# MathHelper.UnLerp Method (Single, Single, Single)

﻿MathHelper.UnLerp Method (Single, Single, Single)

|  |  |  |
| --- | --- | --- |
| MathHelperUnLerp Method (Single, Single, Single) | RAGE Plugin Hook Documentation |  |

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
public static float UnLerp(
	float start,
	float end,
	float lerpedValue
)
```

```
Public Shared Function UnLerp ( 
	start As Single,
	end As Single,
	lerpedValue As Single
) As Single
```

```
public:
static float UnLerp(
	float start, 
	float end, 
	float lerpedValue
)
```

#### Parameters

start
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The start.

end
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The end.

lerpedValue
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The lerped value.

#### Return Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The lerp percentage.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[UnLerp Overload](Overload_Rage_MathHelper_UnLerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.