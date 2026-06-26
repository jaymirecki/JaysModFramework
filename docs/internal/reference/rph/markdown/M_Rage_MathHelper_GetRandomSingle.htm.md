# MathHelper.GetRandomSingle Method

﻿MathHelper.GetRandomSingle Method 

|  |  |  |
| --- | --- | --- |
| MathHelperGetRandomSingle Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a random single precision floating point number between the specified minimum and maximum value, inclusive.

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
public static float GetRandomSingle(
	float minimum,
	float maximum
)
```

```
Public Shared Function GetRandomSingle ( 
	minimum As Single,
	maximum As Single
) As Single
```

```
public:
static float GetRandomSingle(
	float minimum, 
	float maximum
)
```

#### Parameters

minimum
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The minimum value.

maximum
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The maximum value.

#### Return Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
A random single precision floating point number between minimum and maximum, inclusive.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.