# Task.WaitForCompletion Method (Int32)

﻿Task.WaitForCompletion Method (Int32)

|  |  |  |
| --- | --- | --- |
| TaskWaitForCompletion Method (Int32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sleeps the active GameFiber until the task completes.

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
public void WaitForCompletion(
	int timeout
)
```

```
Public Sub WaitForCompletion ( 
	timeout As Integer
)
```

```
public:
void WaitForCompletion(
	int timeout
)
```

#### Parameters

timeout
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The time, in milliseconds, to allow the task to complete. If -1, the method will never time out.

See Also

#### Reference

[Task Class](T_Rage_Task.htm)

[WaitForCompletion Overload](Overload_Rage_Task_WaitForCompletion.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.