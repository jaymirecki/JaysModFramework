# World.GetEntityByHandle(EntityType) Method

﻿World.GetEntityByHandle(EntityType) Method 

|  |  |  |
| --- | --- | --- |
| WorldGetEntityByHandleEntityType Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets an existing [Entity](T_Rage_Entity.htm) from the specified handle.

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
public static EntityType GetEntityByHandle<EntityType>(
	PoolHandle handle
)
where EntityType : Entity
```

```
Public Shared Function GetEntityByHandle(Of EntityType As Entity) ( 
	handle As PoolHandle
) As EntityType
```

```
public:
generic<typename EntityType>
where EntityType : Entity
static EntityType GetEntityByHandle(
	PoolHandle handle
)
```

#### Parameters

handle
:   Type: [RagePoolHandle](T_Rage_PoolHandle.htm)  
    The handle of the entity.

#### Type Parameters

EntityType
:   [Missing <typeparam name="EntityType"/> documentation for "M:Rage.World.GetEntityByHandle``1(Rage.PoolHandle)"]

#### Return Value

Type: EntityType  
An instance of the specified derived sub class of [Entity](T_Rage_Entity.htm) representing the specified handle, or null if the entity doesn't exist.

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentException](http://msdn2.microsoft.com/en-us/library/3w1b3114) | Thrown if the specified handle does not represent an entity (Ped, Vehicle or Object). |

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.