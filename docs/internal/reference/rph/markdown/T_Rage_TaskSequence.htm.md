# TaskSequence Class

﻿TaskSequence Class

|  |  |  |
| --- | --- | --- |
| TaskSequence Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

This class allows executing multiple tasks on a [Ped](T_Rage_Ped.htm) in sequence.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageTaskSequence  
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
public sealed class TaskSequence : IDisposable
```

```
Public NotInheritable Class TaskSequence
	Implements IDisposable
```

```
public ref class TaskSequence sealed : IDisposable
```

The TaskSequence type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [TaskSequence](M_Rage_TaskSequence__ctor.htm) | Initializes a new instance of the TaskSequence class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Ped](P_Rage_TaskSequence_Ped.htm) | Gets the [Ped](P_Rage_TaskSequence_Ped.htm) that owns this TaskSequence. |
| Public property | [Tasks](P_Rage_TaskSequence_Tasks.htm) | Gets an instance of [TaskInvoker](T_Rage_TaskInvoker.htm) for this TaskSequence that can be used to add tasks to it. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Dispose](M_Rage_TaskSequence_Dispose.htm) | Disposes an instance of the TaskSequence class. |
| Public method | [Execute](M_Rage_TaskSequence_Execute.htm) | Executes this TaskSequence. |
| Public method | [Execute(Boolean)](M_Rage_TaskSequence_Execute_1.htm) | Executes this TaskSequence. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.