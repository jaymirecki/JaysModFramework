# MathHelper.ConvertDirectionToHeading Method

﻿MathHelper.ConvertDirectionToHeading Method 

|  |  |  |
| --- | --- | --- |
| MathHelperConvertDirectionToHeading Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Converts the specified direction to a heading.

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
public static float ConvertDirectionToHeading(
	Vector3 direction
)
```

```
Public Shared Function ConvertDirectionToHeading ( 
	direction As Vector3
) As Single
```

```
public:
static float ConvertDirectionToHeading(
	Vector3 direction
)
```

#### Parameters

direction
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The direction to convert.

#### Return Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
A [Single](http://msdn2.microsoft.com/en-us/library/3www918f) representing the heading of the direction.

Remarks

Note that since a heading is horizontal, the pitch is lost.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.