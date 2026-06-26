# TaskStatus Enumeration

﻿TaskStatus Enumeration

|  |  |  |
| --- | --- | --- |
| TaskStatus Enumeration | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Indicates the status of a task.

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
public enum TaskStatus
```

```
Public Enumeration TaskStatus
```

```
public enum class TaskStatus
```

Members

|  | Member name | Value | Description |
| --- | --- | --- | --- |
|  | Unknown | -1 | The current status of the task is unknown. Note, this value is never returned by the game. |
|  | Preparing | 0 | Means the [Ped](T_Rage_Ped.htm) is waiting for events preventing it from performing its task, to end. Eg. if the task is issued while the [Ped](T_Rage_Ped.htm) is ragdolled. |
|  | NoTask | 3 | The status returned by [!:Rage::TaskInvoker::CurrentTaskStatus] when the current task hasn't been invoked by a plugin or game script. |
|  | None | 7 | The task has not been performed yet, or has been done. |
|  | Interrupted | 2 | The task was temporarily interrupted, eg. if the [Ped](T_Rage_Ped.htm) is walking, and the player walks into the [Ped](T_Rage_Ped.htm) so it stumbles. |
|  | InProgress | 1 | The task is currently being performed by the [Ped](T_Rage_Ped.htm). |

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.