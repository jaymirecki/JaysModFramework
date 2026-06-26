# GameFiber.ExecuteWhile Method

﻿GameFiber.ExecuteWhile Method 

|  |  |  |
| --- | --- | --- |
| GameFiberExecuteWhile Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Calls the specified method once every tick on the calling [GameFiber](T_Rage_GameFiber.htm), while the specified condition is true.

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
public static void ExecuteWhile(
	ThreadStart start,
	Func<bool> condition
)
```

```
Public Shared Sub ExecuteWhile ( 
	start As ThreadStart,
	condition As Func(Of Boolean)
)
```

```
public:
static void ExecuteWhile(
	ThreadStart^ start, 
	Func<bool>^ condition
)
```

#### Parameters

start
:   Type: [System.ThreadingThreadStart](http://msdn2.microsoft.com/en-us/library/57s77029)  
    The method to call every tick.

condition
:   Type: [SystemFunc](http://msdn2.microsoft.com/en-us/library/bb534960)[Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  

    [Missing <param name="condition"/> documentation for "M:Rage.GameFiber.ExecuteWhile(System.Threading.ThreadStart,System.Func{System.Boolean})"]

#### Return Value

Type:   
An instance of [GameFiber](T_Rage_GameFiber.htm) representing the created fiber.

See Also

#### Reference

[GameFiber Class](T_Rage_GameFiber.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.