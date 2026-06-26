# GameFiber.ExecuteFor Method

﻿GameFiber.ExecuteFor Method 

|  |  |  |
| --- | --- | --- |
| GameFiberExecuteFor Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Calls the specified method once every tick on the calling [GameFiber](T_Rage_GameFiber.htm), for the specified duration.

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
public static void ExecuteFor(
	ThreadStart start,
	int duration
)
```

```
Public Shared Sub ExecuteFor ( 
	start As ThreadStart,
	duration As Integer
)
```

```
public:
static void ExecuteFor(
	ThreadStart^ start, 
	int duration
)
```

#### Parameters

start
:   Type: [System.ThreadingThreadStart](http://msdn2.microsoft.com/en-us/library/57s77029)  
    The method to call every tick.

duration
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The duration to keep calling the method for.

#### Return Value

Type:   
An instance of [GameFiber](T_Rage_GameFiber.htm) representing the created fiber.

See Also

#### Reference

[GameFiber Class](T_Rage_GameFiber.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.