# MathHelper.Median(T) Method

﻿MathHelper.Median(T) Method 

|  |  |  |
| --- | --- | --- |
| MathHelperMedianT Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the median from the specified values.

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
public static T Median<T>(
	params T[] values
)
```

```
Public Shared Function Median(Of T) ( 
	ParamArray values As T()
) As T
```

```
public:
generic<typename T>
static T Median(
	... array<T>^ values
)
```

#### Parameters

values
:   Type: T  
    The values to get the median from.

#### Type Parameters

T
:   The type of the values specified.

#### Return Value

Type: T  
If the specified array has at least 1 value, returns the median; otherwise, returns the default value of [!:T].

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentNullException](http://msdn2.microsoft.com/en-us/library/27426hcy) | Thrown if values is null. |

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.