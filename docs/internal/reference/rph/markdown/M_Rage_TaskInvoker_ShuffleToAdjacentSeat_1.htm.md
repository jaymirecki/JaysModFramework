# TaskInvoker.ShuffleToAdjacentSeat Method (Vehicle)

﻿TaskInvoker.ShuffleToAdjacentSeat Method (Vehicle)

|  |  |  |
| --- | --- | --- |
| TaskInvokerShuffleToAdjacentSeat Method (Vehicle) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Makes the [Ped](T_Rage_Ped.htm) shuffle to an adjacent seat in the specified vehicle.

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
public Task ShuffleToAdjacentSeat(
	Vehicle vehicle
)
```

```
Public Function ShuffleToAdjacentSeat ( 
	vehicle As Vehicle
) As Task
```

```
public:
Task^ ShuffleToAdjacentSeat(
	Vehicle^ vehicle
)
```

#### Parameters

vehicle
:   Type: [RageVehicle](T_Rage_Vehicle.htm)  

    The [Vehicle](T_Rage_Vehicle.htm) to shuffle to an adjacent seat in. This must be the [Ped](T_Rage_Ped.htm)'s current vehicle at the time the task is invoked.

    This can differ from the [Ped](T_Rage_Ped.htm) current vehicle if the task is not invoked immediately (Eg. through an instance of [TaskSequence](T_Rage_TaskSequence.htm)).

#### Return Value

Type: [Task](T_Rage_Task.htm)  
An instance of [Task](T_Rage_Task.htm) that can be used to retrieve information about the task.

See Also

#### Reference

[TaskInvoker Class](T_Rage_TaskInvoker.htm)

[ShuffleToAdjacentSeat Overload](Overload_Rage_TaskInvoker_ShuffleToAdjacentSeat.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.