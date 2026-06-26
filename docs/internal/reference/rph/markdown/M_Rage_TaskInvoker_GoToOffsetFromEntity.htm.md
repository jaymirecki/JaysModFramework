# TaskInvoker.GoToOffsetFromEntity Method (Entity, Int32, Single, Single, Single)

﻿TaskInvoker.GoToOffsetFromEntity Method (Entity, Int32, Single, Single, Single)

|  |  |  |
| --- | --- | --- |
| TaskInvokerGoToOffsetFromEntity Method (Entity, Int32, Single, Single, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Makes the [Ped](T_Rage_Ped.htm) go to an offset from the specified [Entity](T_Rage_Entity.htm).

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
public Task GoToOffsetFromEntity(
	Entity entity,
	int timeOut,
	float positionOffset,
	float angularOffset,
	float speed
)
```

```
Public Function GoToOffsetFromEntity ( 
	entity As Entity,
	timeOut As Integer,
	positionOffset As Single,
	angularOffset As Single,
	speed As Single
) As Task
```

```
public:
Task^ GoToOffsetFromEntity(
	Entity^ entity, 
	int timeOut, 
	float positionOffset, 
	float angularOffset, 
	float speed
)
```

#### Parameters

entity
:   Type: [RageEntity](T_Rage_Entity.htm)  
    The [Entity](T_Rage_Entity.htm) to go to.

timeOut
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The time out in milliseconds, to allow the task to complete. If the task times out, the task will be cancelled.

positionOffset
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  

    [Missing <param name="positionOffset"/> documentation for "M:Rage.TaskInvoker.GoToOffsetFromEntity(Rage.Entity,System.Int32,System.Single,System.Single,System.Single)"]

angularOffset
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The angular offset in degrees from the front of the [Entity](T_Rage_Entity.htm).

speed
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The speed to move at, in meters per second. The Ped will move using the animation closest to the specified speed.

#### Return Value

Type: [Task](T_Rage_Task.htm)  
An instance of [Task](T_Rage_Task.htm) that can be used to retrieve information about the task.

See Also

#### Reference

[TaskInvoker Class](T_Rage_TaskInvoker.htm)

[GoToOffsetFromEntity Overload](Overload_Rage_TaskInvoker_GoToOffsetFromEntity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.