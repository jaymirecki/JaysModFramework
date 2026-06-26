# TaskInvoker.CurrentTaskStatus Property

﻿TaskInvoker.CurrentTaskStatus Property 

|  |  |  |
| --- | --- | --- |
| TaskInvokerCurrentTaskStatus Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the status of the current task. If no task is running, returns [NoTask](T_Rage_TaskStatus.htm).

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
public TaskStatus CurrentTaskStatus { get; }
```

```
Public ReadOnly Property CurrentTaskStatus As TaskStatus
	Get
```

```
public:
property TaskStatus CurrentTaskStatus {
	TaskStatus get ();
}
```

#### Property Value

Type: [TaskStatus](T_Rage_TaskStatus.htm)  
The status of the current task.

Remarks

This property will only return the status of tasks invoked by the methods in this class (or tasks invoked through natives).

See Also

#### Reference

[TaskInvoker Class](T_Rage_TaskInvoker.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.