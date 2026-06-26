# MathHelper.Lerp Method (Int32, Int32, Single)

﻿MathHelper.Lerp Method (Int32, Int32, Single)

|  |  |  |
| --- | --- | --- |
| MathHelperLerp Method (Int32, Int32, Single) | RAGE Plugin Hook Documentation |  |

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
public static int Lerp(
	int start,
	int end,
	float percent
)
```

```
Public Shared Function Lerp ( 
	start As Integer,
	end As Integer,
	percent As Single
) As Integer
```

```
public:
static int Lerp(
	int start, 
	int end, 
	float percent
)
```

#### Parameters

start
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The start.

end
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The end.

percent
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The percent.

#### Return Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
The new value.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Lerp Overload](Overload_Rage_MathHelper_Lerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.