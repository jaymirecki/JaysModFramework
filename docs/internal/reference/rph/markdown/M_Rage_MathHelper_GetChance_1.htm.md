# MathHelper.GetChance Method (Int32, Int32)

﻿MathHelper.GetChance Method (Int32, Int32)

|  |  |  |
| --- | --- | --- |
| MathHelperGetChance Method (Int32, Int32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a chance.

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
public static bool GetChance(
	int odds,
	int seed
)
```

```
Public Shared Function GetChance ( 
	odds As Integer,
	seed As Integer
) As Boolean
```

```
public:
static bool GetChance(
	int odds, 
	int seed
)
```

#### Parameters

odds
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The odds.

seed
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The seed.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
Returns true one out of odds times.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[GetChance Overload](Overload_Rage_MathHelper_GetChance.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.