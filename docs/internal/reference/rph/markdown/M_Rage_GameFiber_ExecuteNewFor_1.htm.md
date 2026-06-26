# GameFiber.ExecuteNewFor Method (ThreadStart, String, Int32)

﻿GameFiber.ExecuteNewFor Method (ThreadStart, String, Int32)

|  |  |  |
| --- | --- | --- |
| GameFiberExecuteNewFor Method (ThreadStart, String, Int32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Calls the specified method once every tick on a new [GameFiber](T_Rage_GameFiber.htm), for the specified duration.

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
public static GameFiber ExecuteNewFor(
	ThreadStart start,
	string name,
	int duration
)
```

```
Public Shared Function ExecuteNewFor ( 
	start As ThreadStart,
	name As String,
	duration As Integer
) As GameFiber
```

```
public:
static GameFiber^ ExecuteNewFor(
	ThreadStart^ start, 
	String^ name, 
	int duration
)
```

#### Parameters

start
:   Type: [System.ThreadingThreadStart](http://msdn2.microsoft.com/en-us/library/57s77029)  
    The method to call every tick.

name
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the [GameFiber](T_Rage_GameFiber.htm).

duration
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The duration to keep calling the method for.

#### Return Value

Type: [GameFiber](T_Rage_GameFiber.htm)  
An instance of [GameFiber](T_Rage_GameFiber.htm) representing the created fiber.

See Also

#### Reference

[GameFiber Class](T_Rage_GameFiber.htm)

[ExecuteNewFor Overload](Overload_Rage_GameFiber_ExecuteNewFor.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.