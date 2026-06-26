# Task.WaitForStatus Method (TaskStatus, Int32)

﻿Task.WaitForStatus Method (TaskStatus, Int32)

|  |  |  |
| --- | --- | --- |
| TaskWaitForStatus Method (TaskStatus, Int32) | RAGE Plugin Hook Documentation |  |

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
public virtual bool WaitForStatus(
	TaskStatus status,
	int timeout
)
```

```
Public Overridable Function WaitForStatus ( 
	status As TaskStatus,
	timeout As Integer
) As Boolean
```

```
public:
virtual bool WaitForStatus(
	TaskStatus status, 
	int timeout
)
```

#### Parameters

status
:   Type: [RageTaskStatus](T_Rage_TaskStatus.htm)  
    The status to wait for.

timeout
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The time, in milliseconds, to allow the task to reach the specified status. If -1, the method will never time out.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
If the task reached the status before timing out, returns true; otherwise, returns false.

See Also

#### Reference

[Task Class](T_Rage_Task.htm)

[WaitForStatus Overload](Overload_Rage_Task_WaitForStatus.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.