# GameFiber.WaitWhile Method (Func(Boolean))

﻿GameFiber.WaitWhile Method (Func(Boolean))

|  |  |  |
| --- | --- | --- |
| GameFiberWaitWhile Method (FuncBoolean) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Yields the executing fiber while the specified condition is met. The condition is not checked while the game is paused.

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
public static void WaitWhile(
	Func<bool> condition
)
```

```
Public Shared Sub WaitWhile ( 
	condition As Func(Of Boolean)
)
```

```
public:
static void WaitWhile(
	Func<bool>^ condition
)
```

#### Parameters

condition
:   Type: [SystemFunc](http://msdn2.microsoft.com/en-us/library/bb534960)[Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    The condition.

Examples

See [SleepWhile(FuncBoolean, Int32)](M_Rage_GameFiber_SleepWhile.htm) for examples.

See Also

#### Reference

[GameFiber Class](T_Rage_GameFiber.htm)

[WaitWhile Overload](Overload_Rage_GameFiber_WaitWhile.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.