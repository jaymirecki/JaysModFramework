# TaskInvoker.ShuffleToAdjacentSeat Method

﻿TaskInvoker.ShuffleToAdjacentSeat Method 

|  |  |  |
| --- | --- | --- |
| TaskInvokerShuffleToAdjacentSeat Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Makes the [Ped](T_Rage_Ped.htm) shuffle to an adjacent seat in the [Ped](T_Rage_Ped.htm)'s current vehicle.

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
public Task ShuffleToAdjacentSeat()
```

```
Public Function ShuffleToAdjacentSeat As Task
```

```
public:
Task^ ShuffleToAdjacentSeat()
```

#### Return Value

Type: [Task](T_Rage_Task.htm)  
An instance of [Task](T_Rage_Task.htm) that can be used to retrieve information about the task.

Remarks

Be careful with this overload. The vehicle to use will be set to the vehicle the [Ped](T_Rage_Ped.htm) is in when this function is called, which may cause the wrong vehicle to be used, eg. if this task is part of a [TaskSequence](T_Rage_TaskSequence.htm).

See Also

#### Reference

[TaskInvoker Class](T_Rage_TaskInvoker.htm)

[ShuffleToAdjacentSeat Overload](Overload_Rage_TaskInvoker_ShuffleToAdjacentSeat.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.