# MathHelper.GetNumberLength Method

﻿MathHelper.GetNumberLength Method 

|  |  |  |
| --- | --- | --- |
| MathHelperGetNumberLength Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the length of the specified number.

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
public static int GetNumberLength(
	long number
)
```

```
Public Shared Function GetNumberLength ( 
	number As Long
) As Integer
```

```
public:
static int GetNumberLength(
	long long number
)
```

#### Parameters

number
:   Type: [SystemInt64](http://msdn2.microsoft.com/en-us/library/6yy583ek)  
    The number to get the length of.

#### Return Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
The number of digits in the specified number.

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentException](http://msdn2.microsoft.com/en-us/library/3w1b3114) | Thrown if the specified value is too small. |

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.