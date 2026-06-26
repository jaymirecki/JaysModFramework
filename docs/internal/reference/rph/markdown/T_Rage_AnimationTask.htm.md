# AnimationTask Class

﻿AnimationTask Class

|  |  |  |
| --- | --- | --- |
| AnimationTask Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents an animation task. This class cannot be inherited.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [RageTask](T_Rage_Task.htm)  
    RageAnimationTask  
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
public sealed class AnimationTask : Task
```

```
Public NotInheritable Class AnimationTask
	Inherits Task
```

```
public ref class AnimationTask sealed : public Task
```

The AnimationTask type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AnimationDictionary](P_Rage_AnimationTask_AnimationDictionary.htm) |  |
| Public property | [AnimationName](P_Rage_AnimationTask_AnimationName.htm) |  |
| Public property | [CurrentTime](P_Rage_AnimationTask_CurrentTime.htm) | Gets or sets the current time of the animation being played by this task, in seconds. |
| Public property | [CurrentTimeRatio](P_Rage_AnimationTask_CurrentTimeRatio.htm) | Gets or sets the current time ratio of the animation being played by this task. |
| Public property | [IsActive](P_Rage_Task_IsActive.htm) | Gets a value indicating whether this task is active.  A task is considered active if its status is not [None](T_Rage_TaskStatus.htm). (Inherited from [Task](T_Rage_Task.htm).) |
| Public property | [IsPlaying](P_Rage_AnimationTask_IsPlaying.htm) | Gets a value indicating whether the animation represented by this task is currently playing. |
| Public property | [Length](P_Rage_AnimationTask_Length.htm) | Gets the length of the animation represented by this task, in seconds. |
| Public property | [Name](P_Rage_Task_Name.htm) | Gets the name of the method that was used to invoke this task. Eg. "RappelFromHelicopter". (Inherited from [Task](T_Rage_Task.htm).) |
| Public property | [Ped](P_Rage_Task_Ped.htm) | Gets the [Ped](P_Rage_Task_Ped.htm) this task is assigned to. (Inherited from [Task](T_Rage_Task.htm).) |
| Public property | [PlayRate](P_Rage_AnimationTask_PlayRate.htm) | Sets the speed multiplier of the animation being played by this task. |
| Public property | [RemainingTimeRatio](P_Rage_AnimationTask_RemainingTimeRatio.htm) | Gets or sets the remaining time ratio of the animation being played by this task. |
| Public property | [Status](P_Rage_Task_Status.htm) | Gets the current status of this task. (Inherited from [Task](T_Rage_Task.htm).) |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [WaitForCompletion](M_Rage_Task_WaitForCompletion.htm) | Sleeps the active GameFiber until the task completes. (Inherited from [Task](T_Rage_Task.htm).) |
| Public method | [WaitForCompletion(Int32)](M_Rage_Task_WaitForCompletion_1.htm) | Sleeps the active GameFiber until the task completes. (Inherited from [Task](T_Rage_Task.htm).) |
| Public method | [WaitForStatus(TaskStatus)](M_Rage_Task_WaitForStatus.htm) | Sleeps the active GameFiber until the task reaches the specified status. (Inherited from [Task](T_Rage_Task.htm).) |
| Public method | [WaitForStatus(TaskStatus, Int32)](M_Rage_Task_WaitForStatus_1.htm) | Sleeps the active GameFiber until the task reaches the specified status. (Inherited from [Task](T_Rage_Task.htm).) |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.