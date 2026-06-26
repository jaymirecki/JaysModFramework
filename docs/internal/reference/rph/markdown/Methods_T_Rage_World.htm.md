# World Methods

﻿World Methods

|  |  |  |
| --- | --- | --- |
| World Methods | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [World](T_Rage_World.htm) type exposes the following members.

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [AddSpeedZone](M_Rage_World_AddSpeedZone.htm) | Adds a new speed zone limiting the maximum driving speed of AI-driven vehicles in an area. |
| Public methodStatic member | [CleanWorld](M_Rage_World_CleanWorld.htm) | Cleans the world. |
| Public methodStatic memberCode example | [ConvertScreenPositionToTrace](M_Rage_World_ConvertScreenPositionToTrace.htm) | Gets a trace start position and trace direction from the specified screen position. |
| Public methodStatic member | [ConvertWorldPositionToScreenPosition](M_Rage_World_ConvertWorldPositionToScreenPosition.htm) | Converts the specified position from world space to screen space. |
| Public methodStatic member | [EnumerateObjects](M_Rage_World_EnumerateObjects.htm) | Gets an enumerable collection of the [Object](T_Rage_Object.htm)s currently in the game world. |
| Public methodStatic member | [EnumeratePeds](M_Rage_World_EnumeratePeds.htm) | Gets an enumerable collection of the [Ped](T_Rage_Ped.htm)s currently in the game world. |
| Public methodStatic member | [EnumerateVehicles](M_Rage_World_EnumerateVehicles.htm) | Gets an enumerable collection of the [Vehicle](T_Rage_Vehicle.htm)s currently in the game world. |
| Public methodStatic member | [GetAllBlips](M_Rage_World_GetAllBlips.htm) | Gets all [Blip](T_Rage_Blip.htm)s currently in the game world. |
| Public methodStatic member | [GetAllEntities](M_Rage_World_GetAllEntities.htm) | Gets all entities currently in the game world. |
| Public methodStatic member | [GetAllFires](M_Rage_World_GetAllFires.htm) | Gets all fires currently in the game world. |
| Public methodStatic member | [GetAllGroups](M_Rage_World_GetAllGroups.htm) | Gets all currently existing [Group](T_Rage_Group.htm)s. |
| Public methodStatic member | [GetAllObjects](M_Rage_World_GetAllObjects.htm) | Gets all [Object](T_Rage_Object.htm)s currently in the game world. |
| Public methodStatic member | [GetAllPathNodeIds](M_Rage_World_GetAllPathNodeIds.htm) | Gets the IDs of all path nodes currently loaded. |
| Public methodStatic member | [GetAllPeds](M_Rage_World_GetAllPeds.htm) | Gets all [Ped](T_Rage_Ped.htm)s currently in the game world. |
| Public methodStatic member | [GetAllVehicles](M_Rage_World_GetAllVehicles.htm) | Gets all [Vehicle](T_Rage_Vehicle.htm)s currently in the game world. |
| Public methodStatic member | [GetAllWeapons](M_Rage_World_GetAllWeapons.htm) | Gets all [Weapon](T_Rage_Weapon.htm)s currently in the game world. |
| Public methodStatic member | [GetBlipByHandle](M_Rage_World_GetBlipByHandle.htm) | Gets an existing [Blip](T_Rage_Blip.htm) from the specified handle. |
| Public methodStatic member | [GetClosestEntity(Entity, Vector3)](M_Rage_World_GetClosestEntity.htm) | Gets the closest entity to the specified position, within the specified radius. |
| Public methodStatic member | [GetClosestEntity(Vector3, Single, GetEntitiesFlags)](M_Rage_World_GetClosestEntity_1.htm) |  |
| Public methodStatic member | [GetEntities(GetEntitiesFlags)](M_Rage_World_GetEntities.htm) |  |
| Public methodStatic member | [GetEntities(Vector3, Single, GetEntitiesFlags)](M_Rage_World_GetEntities_1.htm) |  |
| Public methodStatic member | [GetEntityByHandleEntityType](M_Rage_World_GetEntityByHandle__1.htm) | Gets an existing [Entity](T_Rage_Entity.htm) from the specified handle. |
| Public methodStatic member | [GetGroundZ](M_Rage_World_GetGroundZ.htm) | Gets the Z value of the ground surface at the specified position. |
| Public methodStatic member | [GetGroupByHandle](M_Rage_World_GetGroupByHandle.htm) | Gets an existing [Group](T_Rage_Group.htm) from the specified handle. |
| Public methodStatic member | [GetNextPositionOnStreet](M_Rage_World_GetNextPositionOnStreet.htm) |  |
| Public methodStatic member | [GetRandomPositionOnStreet](M_Rage_World_GetRandomPositionOnStreet.htm) | Gets a random street position. |
| Public methodStatic member | [GetStreetHash](M_Rage_World_GetStreetHash.htm) | Gets the hash of the name of the street at the given position. |
| Public methodStatic member | [GetStreetName(UInt32)](M_Rage_World_GetStreetName_1.htm) | Gets the name of the street given its hash. |
| Public methodStatic member | [GetStreetName(Vector3)](M_Rage_World_GetStreetName.htm) | Gets the name of the street at the given position. |
| Public methodStatic member | [GetWaypointBlip](M_Rage_World_GetWaypointBlip.htm) | Gets the waypoint blip set by the player. |
| Public methodStatic member | [IsPathNodeIdValid](M_Rage_World_IsPathNodeIdValid.htm) | Determines whether the specified value is a valid path node identifier. |
| Public methodStatic member | [LoadNorthYankton](M_Rage_World_LoadNorthYankton.htm) | Loads North Yankton into the game world. |
| Public methodStatic member | [RemoveSpeedZone](M_Rage_World_RemoveSpeedZone.htm) | Removes a speed zone given its handle. |
| Public methodStatic member | [SpawnExplosion](M_Rage_World_SpawnExplosion.htm) | Spawns an explosion at the specified position. |
| Public methodStatic member | [TeleportLocalPlayer](M_Rage_World_TeleportLocalPlayer.htm) | Teleports the local player to the specified position. |
| Public methodStatic member | [TraceBox](M_Rage_World_TraceBox.htm) |  |
| Public methodStatic member | [TraceCapsule(Vector3, Vector3, Single, TraceFlags, Entity)](M_Rage_World_TraceCapsule.htm) |  |
| Public methodStatic member | [TraceCapsule(Vector3, Vector3, Single, TraceFlags, PredicateEntity)](M_Rage_World_TraceCapsule_1.htm) |  |
| Public methodStatic member | [TraceExtent(Vector3, Vector3, Single, TraceFlags, Entity)](M_Rage_World_TraceExtent.htm) | **Obsolete.** |
| Public methodStatic member | [TraceExtent(Vector3, Vector3, Single, TraceFlags, PredicateEntity)](M_Rage_World_TraceExtent_1.htm) | **Obsolete.** |
| Public methodStatic member | [TraceLine(Vector3, Vector3, TraceFlags, Entity)](M_Rage_World_TraceLine.htm) |  |
| Public methodStatic member | [TraceLine(Vector3, Vector3, TraceFlags, PredicateEntity)](M_Rage_World_TraceLine_1.htm) |  |
| Public methodStatic member | [TraceLine(Vector3, Vector3, Single, TraceFlags, PredicateEntity)](M_Rage_World_TraceLine_2.htm) | **Obsolete.** |
| Public methodStatic member | [TransitionToWeather](M_Rage_World_TransitionToWeather.htm) | Starts transitioning the current weather to the specified weather, over the specified duration. |
| Public methodStatic member | [UnloadNorthYankton](M_Rage_World_UnloadNorthYankton.htm) | Unloads North Yankton from the game world. |

[Top](#mainBody)

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.