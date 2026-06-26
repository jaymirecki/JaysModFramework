# MathHelper.Faculty Method

﻿MathHelper.Faculty Method 

|  |  |  |
| --- | --- | --- |
| MathHelperFaculty Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the faculty of the specified number.

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
public static int Faculty(
	int number
)
```

```
Public Shared Function Faculty ( 
	number As Integer
) As Integer
```

```
public:
static int Faculty(
	int number
)
```

#### Parameters

number
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The number.

#### Return Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
The faculty of the specified number.

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentOutOfRangeException](http://msdn2.microsoft.com/en-us/library/8xt94y6e) | Thrown if the specified number is negative. |

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.