# TaskInvoker.GoToWhileAiming Method (Entity, Single, Single)

﻿TaskInvoker.GoToWhileAiming Method (Entity, Single, Single)

|  |  |  |
| --- | --- | --- |
| TaskInvokerGoToWhileAiming Method (Entity, Single, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Makes the [Ped](T_Rage_Ped.htm) go to the specified [Entity](T_Rage_Entity.htm) while aiming at it.

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
public Task GoToWhileAiming(
	Entity entity,
	float distanceThreshold,
	float aimingStartDistance
)
```

```
Public Function GoToWhileAiming ( 
	entity As Entity,
	distanceThreshold As Single,
	aimingStartDistance As Single
) As Task
```

```
public:
Task^ GoToWhileAiming(
	Entity^ entity, 
	float distanceThreshold, 
	float aimingStartDistance
)
```

#### Parameters

entity
:   Type: [RageEntity](T_Rage_Entity.htm)  
    The [Entity](T_Rage_Entity.htm) to go to.

distanceThreshold
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The distance from the entity to stop at.

aimingStartDistance
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The distance from the entity to begin aiming at it from.

#### Return Value

Type: [Task](T_Rage_Task.htm)  
An instance of [Task](T_Rage_Task.htm) that can be used to retrieve information about the task.

See Also

#### Reference

[TaskInvoker Class](T_Rage_TaskInvoker.htm)

[GoToWhileAiming Overload](Overload_Rage_TaskInvoker_GoToWhileAiming.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.