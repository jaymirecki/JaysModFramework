# Task Class

﻿Task Class

|  |  |  |
| --- | --- | --- |
| Task Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents a task. This class cannot be inherited.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageTask  
    [RageAnimationTask](T_Rage_AnimationTask.htm)  
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
public class Task
```

```
Public Class Task
```

```
public ref class Task
```

The Task type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [IsActive](P_Rage_Task_IsActive.htm) | Gets a value indicating whether this task is active.  A task is considered active if its status is not [None](T_Rage_TaskStatus.htm). |
| Public property | [Name](P_Rage_Task_Name.htm) | Gets the name of the method that was used to invoke this task. Eg. "RappelFromHelicopter". |
| Public property | [Ped](P_Rage_Task_Ped.htm) | Gets the [Ped](P_Rage_Task_Ped.htm) this task is assigned to. |
| Public property | [Status](P_Rage_Task_Status.htm) | Gets the current status of this task. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [GetTask](M_Rage_Task_GetTask.htm) | Gets an instance of Task to check the status of a task invoked by the specified native. |
| Protected method | [IsValid](M_Rage_Task_IsValid.htm) |  |
| Public method | [WaitForCompletion](M_Rage_Task_WaitForCompletion.htm) | Sleeps the active GameFiber until the task completes. |
| Public method | [WaitForCompletion(Int32)](M_Rage_Task_WaitForCompletion_1.htm) | Sleeps the active GameFiber until the task completes. |
| Public method | [WaitForStatus(TaskStatus)](M_Rage_Task_WaitForStatus.htm) | Sleeps the active GameFiber until the task reaches the specified status. |
| Public method | [WaitForStatus(TaskStatus, Int32)](M_Rage_Task_WaitForStatus_1.htm) | Sleeps the active GameFiber until the task reaches the specified status. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.