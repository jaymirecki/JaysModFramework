# MathHelper.Choose(T) Method (T[])

﻿MathHelper.Choose(T) Method (T[])

|  |  |  |
| --- | --- | --- |
| MathHelperChooseT Method (T) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a random object from the specified array.

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
public static T Choose<T>(
	params T[] objects
)
```

```
Public Shared Function Choose(Of T) ( 
	ParamArray objects As T()
) As T
```

```
public:
generic<typename T>
static T Choose(
	... array<T>^ objects
)
```

#### Parameters

objects
:   Type: T  
    The objects to choose from. If null, the default value of T will be used.

#### Type Parameters

T
:   The type of object to choose from.

#### Return Value

Type: T  
A random object from the specified array.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Choose Overload](Overload_Rage_MathHelper_Choose.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.