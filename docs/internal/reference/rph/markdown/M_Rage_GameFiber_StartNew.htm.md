# GameFiber.StartNew Method (ThreadStart)

﻿GameFiber.StartNew Method (ThreadStart)

|  |  |  |
| --- | --- | --- |
| GameFiberStartNew Method (ThreadStart) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Starts a new [GameFiber](T_Rage_GameFiber.htm) instance.

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
public static GameFiber StartNew(
	ThreadStart start
)
```

```
Public Shared Function StartNew ( 
	start As ThreadStart
) As GameFiber
```

```
public:
static GameFiber^ StartNew(
	ThreadStart^ start
)
```

#### Parameters

start
:   Type: [System.ThreadingThreadStart](http://msdn2.microsoft.com/en-us/library/57s77029)  
    The method to execute on the [GameFiber](T_Rage_GameFiber.htm).

#### Return Value

Type: [GameFiber](T_Rage_GameFiber.htm)  
An instance of [GameFiber](T_Rage_GameFiber.htm).

See Also

#### Reference

[GameFiber Class](T_Rage_GameFiber.htm)

[StartNew Overload](Overload_Rage_GameFiber_StartNew.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.