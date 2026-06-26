# MathHelper.RotateHeading Method

﻿MathHelper.RotateHeading Method 

|  |  |  |
| --- | --- | --- |
| MathHelperRotateHeading Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Rotates the specified heading the specified number of degrees, and returns the normalized result.

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
public static float RotateHeading(
	float heading,
	float degrees
)
```

```
Public Shared Function RotateHeading ( 
	heading As Single,
	degrees As Single
) As Single
```

```
public:
static float RotateHeading(
	float heading, 
	float degrees
)
```

#### Parameters

heading
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The heading to base the rotation on.

degrees
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The degrees to rotate.

#### Return Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The rotated and normalized heading.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.