# TaskInvoker.CruiseWithVehicle Method (Single)

﻿TaskInvoker.CruiseWithVehicle Method (Single)

|  |  |  |
| --- | --- | --- |
| TaskInvokerCruiseWithVehicle Method (Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Makes the [Ped](T_Rage_Ped.htm) cruise with its current vehicle, using flag [F:<unknown type>.Normal].

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
public Task CruiseWithVehicle(
	float speed
)
```

```
Public Function CruiseWithVehicle ( 
	speed As Single
) As Task
```

```
public:
Task^ CruiseWithVehicle(
	float speed
)
```

#### Parameters

speed
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The speed to drive at, in meters per second.

#### Return Value

Type: [Task](T_Rage_Task.htm)  
An instance of [Task](T_Rage_Task.htm) that can be used to retrieve information about the task.

See Also

#### Reference

[TaskInvoker Class](T_Rage_TaskInvoker.htm)

[CruiseWithVehicle Overload](Overload_Rage_TaskInvoker_CruiseWithVehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.