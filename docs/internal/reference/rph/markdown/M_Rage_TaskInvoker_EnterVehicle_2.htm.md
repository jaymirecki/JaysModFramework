# TaskInvoker.EnterVehicle Method (Vehicle, Int32, Int32)

﻿TaskInvoker.EnterVehicle Method (Vehicle, Int32, Int32)

|  |  |  |
| --- | --- | --- |
| TaskInvokerEnterVehicle Method (Vehicle, Int32, Int32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Makes the [Ped](T_Rage_Ped.htm) enter the specified [Vehicle](T_Rage_Vehicle.htm).

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
public Task EnterVehicle(
	Vehicle vehicle,
	int timeOut,
	int seatIndex
)
```

```
Public Function EnterVehicle ( 
	vehicle As Vehicle,
	timeOut As Integer,
	seatIndex As Integer
) As Task
```

```
public:
Task^ EnterVehicle(
	Vehicle^ vehicle, 
	int timeOut, 
	int seatIndex
)
```

#### Parameters

vehicle
:   Type: [RageVehicle](T_Rage_Vehicle.htm)  
    The [Vehicle](T_Rage_Vehicle.htm) to enter.

timeOut
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The time out in milliseconds, to allow the task to complete. If the task times out, the [Ped](T_Rage_Ped.htm) will be warped into the specified [Vehicle](T_Rage_Vehicle.htm).

seatIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  

    The index of the seat the [Ped](T_Rage_Ped.htm) should get onto.

    If the specified index is -1, the [Ped](T_Rage_Ped.htm) will get into the driver's seat.

    If the specified index is -2, the [Ped](T_Rage_Ped.htm) will get into any free seat (TODO: VERIFY!).

    For regular cars, usually the seats are indexed as follows:

    | Index | Seat |
    | --- | --- |
    | 0 | Passenger seat |
    | 1 | Left rear |
    | 2 | Right rear |

#### Return Value

Type: [Task](T_Rage_Task.htm)  
An instance of [Task](T_Rage_Task.htm) that can be used to retrieve information about the task.

See Also

#### Reference

[TaskInvoker Class](T_Rage_TaskInvoker.htm)

[EnterVehicle Overload](Overload_Rage_TaskInvoker_EnterVehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.