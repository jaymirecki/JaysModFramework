# Task.WaitForStatus Method (TaskStatus)

﻿Task.WaitForStatus Method (TaskStatus)

|  |  |  |
| --- | --- | --- |
| TaskWaitForStatus Method (TaskStatus) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sleeps the active GameFiber until the task reaches the specified status.

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
public void WaitForStatus(
	TaskStatus status
)
```

```
Public Sub WaitForStatus ( 
	status As TaskStatus
)
```

```
public:
void WaitForStatus(
	TaskStatus status
)
```

#### Parameters

status
:   Type: [RageTaskStatus](T_Rage_TaskStatus.htm)  
    The status to wait for.

See Also

#### Reference

[Task Class](T_Rage_Task.htm)

[WaitForStatus Overload](Overload_Rage_Task_WaitForStatus.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.