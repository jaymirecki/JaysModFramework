# GameFiber.WaitUntil Method (Func(Boolean), Int32)

﻿GameFiber.WaitUntil Method (Func(Boolean), Int32)

|  |  |  |
| --- | --- | --- |
| GameFiberWaitUntil Method (FuncBoolean, Int32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Yields the executing fiber until the specified condition is met. The condition is not checked while the game is paused.

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
public static void WaitUntil(
	Func<bool> condition,
	int timeOut
)
```

```
Public Shared Sub WaitUntil ( 
	condition As Func(Of Boolean),
	timeOut As Integer
)
```

```
public:
static void WaitUntil(
	Func<bool>^ condition, 
	int timeOut
)
```

#### Parameters

condition
:   Type: [SystemFunc](http://msdn2.microsoft.com/en-us/library/bb534960)[Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    The condition.

timeOut
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The maximum time to wait. If set to 0, the call will not time out.

Examples

See [SleepUntil(FuncBoolean, Int32)](M_Rage_GameFiber_SleepUntil.htm) for examples.

See Also

#### Reference

[GameFiber Class](T_Rage_GameFiber.htm)

[WaitUntil Overload](Overload_Rage_GameFiber_WaitUntil.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.