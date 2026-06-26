# World.GetClosestEntity Method (Entity[], Vector3)

﻿World.GetClosestEntity Method (Entity[], Vector3)

|  |  |  |
| --- | --- | --- |
| WorldGetClosestEntity Method (Entity, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the closest entity to the specified position, within the specified radius.

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
public static Entity GetClosestEntity(
	Entity[] entities,
	Vector3 position
)
```

```
Public Shared Function GetClosestEntity ( 
	entities As Entity(),
	position As Vector3
) As Entity
```

```
public:
static Entity^ GetClosestEntity(
	array<Entity^>^ entities, 
	Vector3 position
)
```

#### Parameters

entities
:   Type: [RageEntity](T_Rage_Entity.htm)  
    The array to pick the closest entity from.

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position to get the closest entity to.

#### Return Value

Type: [Entity](T_Rage_Entity.htm)  
If the entities is non-empty, returns an instance of [Entity](T_Rage_Entity.htm) representing the closest entity; otherwise, returns null.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[GetClosestEntity Overload](Overload_Rage_World_GetClosestEntity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.