# Vehicle Methods

﻿Vehicle Methods

|  |  |  |
| --- | --- | --- |
| Vehicle Methods | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [Vehicle](T_Rage_Vehicle.htm) type exposes the following members.

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [ApplyForce](M_Rage_Entity_ApplyForce.htm) | Applies force to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [ApplySirenSettingsFrom](M_Rage_Vehicle_ApplySirenSettingsFrom.htm) |  |
| Public method | [AreAllComponentsBroken](M_Rage_Vehicle_AreAllComponentsBroken.htm) |  |
| Public method | [AreAnyComponentsBroken](M_Rage_Vehicle_AreAnyComponentsBroken.htm) |  |
| Public method | [AttachBlip](M_Rage_Entity_AttachBlip.htm) | Creates a new [Blip](T_Rage_Blip.htm) and attaches it to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [AttachTo](M_Rage_Entity_AttachTo.htm) | Attaches [Entity](T_Rage_Entity.htm) to another [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [BlipSiren](M_Rage_Vehicle_BlipSiren.htm) | Blips the siren.  This is identical to the blip that is played when the siren is briefly turned on and off, but does not turn on the light. |
| Public method | [CreateRandomDriver](M_Rage_Vehicle_CreateRandomDriver.htm) | Creates a new [Ped](T_Rage_Ped.htm) with a random model in the driver's seat. |
| Public method | [Deform](M_Rage_Vehicle_Deform.htm) | Applies deformation to this vehicle. |
| Public method | [Delete](M_Rage_Entity_Delete.htm) | Deletes this instance.  Any call to a non-existent instance is invalid and will cause an exception. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Detach](M_Rage_Entity_Detach.htm) | Detaches this [Entity](T_Rage_Entity.htm) from whichever [Entity](T_Rage_Entity.htm) it's currently attached to. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DetachFromTowTruck](M_Rage_Vehicle_DetachFromTowTruck.htm) | Detaches this [Vehicle](T_Rage_Vehicle.htm) from the tow truck it's currently being towed by, if any. |
| Public method | [DetachTowedVehicle](M_Rage_Vehicle_DetachTowedVehicle.htm) | Detaches the [Vehicle](T_Rage_Vehicle.htm) currently being towed by this [Vehicle](T_Rage_Vehicle.htm).  This [Vehicle](T_Rage_Vehicle.htm) must have a towing device. |
| Public method | [DetachWindscreen](M_Rage_Vehicle_DetachWindscreen.htm) | Detaches the windscreen of this instance. |
| Public method | [Dismiss](M_Rage_Entity_Dismiss.htm) | If this instance is marked as persistent, makes the entity non-persistent. Non-persistent entities will be deleted from the game world during clean ups.  This is equivalent to setting IsPersistent to false. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo(ISpatial)](M_Rage_Entity_DistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo(Vector3)](M_Rage_Entity_DistanceTo_1.htm) | Gets the distance from this instance to the specified position. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo2D(ISpatial)](M_Rage_Entity_DistanceTo2D.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo2D(Vector3)](M_Rage_Entity_DistanceTo2D_1.htm) | Gets the distance from this instance to the specified position. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Equals(Entity)](M_Rage_Entity_Equals.htm) | Indicates whether the current instance is equal to another instance of the same type. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Equals(IHandleable)](M_Rage_Entity_Equals_1.htm) | Indicates whether the current [IHandleable](T_Rage_IHandleable.htm) is equal to another [IHandleable](T_Rage_IHandleable.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Explode](M_Rage_Vehicle_Explode.htm) | Explodes this instance. |
| Public method | [Explode(Boolean)](M_Rage_Vehicle_Explode_1.htm) | Explodes this instance. |
| Public method | [Face(ISpatial)](M_Rage_Entity_Face.htm) | Sets the orientation of this instance to face the specified [ISpatial](T_Rage_ISpatial.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Face(Vector3)](M_Rage_Entity_Face_1.htm) | Sets the orientation of this instance to face the specified position. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [FindTowTruck](M_Rage_Vehicle_FindTowTruck.htm) | Finds the tow truck currently towing this [Vehicle](T_Rage_Vehicle.htm). |
| Public method | [GetAttachedBlip](M_Rage_Entity_GetAttachedBlip.htm) | Gets the first [Blip](T_Rage_Blip.htm) attached to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetAttachedBlips](M_Rage_Entity_GetAttachedBlips.htm) | Gets all [Blip](T_Rage_Blip.htm)s attached to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneAxes(Int32, Vector3, Vector3, Vector3)](M_Rage_Entity_GetBoneAxes.htm) | Gets the axes of the specified bone. That is, three vectors pointing right, forward and up, relative to the bone's orientation. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneAxes(String, Vector3, Vector3, Vector3)](M_Rage_Entity_GetBoneAxes_1.htm) | Gets the axes of the specified bone. That is, three vectors pointing right, forward and up, relative to the bone's orientation. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneIndex](M_Rage_Entity_GetBoneIndex.htm) | Gets the index of a bone of this [Entity](T_Rage_Entity.htm), given the bone's name. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneOrientation(Int32)](M_Rage_Entity_GetBoneOrientation.htm) | Gets the orientation of the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneOrientation(String)](M_Rage_Entity_GetBoneOrientation_1.htm) | Gets the orientation of the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBonePosition(Int32)](M_Rage_Entity_GetBonePosition.htm) | Gets the position of the specified bone, in world space. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBonePosition(String)](M_Rage_Entity_GetBonePosition_1.htm) | Gets the position of the specified bone, in world space. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneRotation(Int32)](M_Rage_Entity_GetBoneRotation.htm) | Gets the rotation of the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneRotation(String)](M_Rage_Entity_GetBoneRotation_1.htm) | Gets the rotation of the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetDoors](M_Rage_Vehicle_GetDoors.htm) | Gets all doors of this [Vehicle](T_Rage_Vehicle.htm). |
| Public method | [GetFreePassengerSeatIndex](M_Rage_Vehicle_GetFreePassengerSeatIndex.htm) | Gets the first free index seat of this vehicle.  Does not include the driver's seat. |
| Public method | [GetFreeSeatIndex](M_Rage_Vehicle_GetFreeSeatIndex.htm) | Gets the first free index seat of this vehicle.  Includes the driver's seat. |
| Public method | [GetFreeSeatIndex(Int32, Int32)](M_Rage_Vehicle_GetFreeSeatIndex_1.htm) | Gets the first free index seat of this vehicle between the specified indices, both inclusive. |
| Public method | [GetLastCollision(Vector3)](M_Rage_Entity_GetLastCollision.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetLastCollision(Vector3, Vector3)](M_Rage_Entity_GetLastCollision_1.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetLastCollision(Vector3, Vector3, String)](M_Rage_Entity_GetLastCollision_2.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public methodCode example | [GetOffsetPosition](M_Rage_Entity_GetOffsetPosition.htm) | Gets a position offset relative to this instance, based on the instance's position and direction. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionFront](M_Rage_Entity_GetOffsetPositionFront.htm) | Gets a position that is the specified offset towards the entity's front. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionRight](M_Rage_Entity_GetOffsetPositionRight.htm) | Gets a position that is the specified offset towards the entity's right. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionUp](M_Rage_Entity_GetOffsetPositionUp.htm) | Gets a position that is the specified offset towards the entity's top. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetPedOnSeat](M_Rage_Vehicle_GetPedOnSeat.htm) | Gets the [Ped](T_Rage_Ped.htm) on the seat at the specified index. |
| Public method | [GetPositionOffset](M_Rage_Entity_GetPositionOffset.htm) | Gets the offset to the specified world position, relative to this [Entity](T_Rage_Entity.htm).  This is essentially the opposite of [GetOffsetPosition(Vector3)](M_Rage_Entity_GetOffsetPosition.htm) (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetPreviousPedOnSeat](M_Rage_Vehicle_GetPreviousPedOnSeat.htm) | Gets the [Ped](T_Rage_Ped.htm) that was previously on the seat at the specified index.  A [Ped](T_Rage_Ped.htm) is considered 'previous' when it leaves the vehicle. |
| Public method | [HasBeenDamagedBy](M_Rage_Entity_HasBeenDamagedBy.htm) | Determines whether this entity has been damaged by the specified entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [HasBone(Int32)](M_Rage_Entity_HasBone.htm) | Determines whether this [Entity](T_Rage_Entity.htm) has the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [HasBone(String)](M_Rage_Entity_HasBone_1.htm) | Determines whether this [Entity](T_Rage_Entity.htm) has the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [IsLockedForPlayer](M_Rage_Vehicle_IsLockedForPlayer.htm) | Determines whether this vehicle is locked for the specified [Player](T_Rage_Player.htm). |
| Public method | [IsSeatFree](M_Rage_Vehicle_IsSeatFree.htm) | Determines whether the seat at the specified index is free. |
| Public method | [IsTouching](M_Rage_Entity_IsTouching.htm) | Determines whether this entity is touching the specified entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [IsValid](M_Rage_Entity_IsValid.htm) | Determines whether this instance still represents an existing entity within the game world. Calls to an invalid instance is illegal and will result in an exception. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [MakePersistent](M_Rage_Vehicle_MakePersistent.htm) | Makes this vehicle and attached trailer persistent. (Overrides [EntityMakePersistent](M_Rage_Entity_MakePersistent.htm).) |
| Public method | [PunctureFuelTank](M_Rage_Vehicle_PunctureFuelTank.htm) | Punctures the fuel tank. |
| Public method | [Repair](M_Rage_Vehicle_Repair.htm) | Repairs this instance. |
| Public method | [RepairComponents](M_Rage_Vehicle_RepairComponents.htm) |  |
| Public method | [SetLockedForPlayer](M_Rage_Vehicle_SetLockedForPlayer.htm) | Sets whether this vehicle is locked for the specified [Player](T_Rage_Player.htm) |
| Public method | [SetPositionWithSnap](M_Rage_Entity_SetPositionWithSnap.htm) | Sets the position of this [Entity](T_Rage_Entity.htm) to the specified value.  Unlike [Position](P_Rage_Entity_Position.htm), if the specified position is in the ground, the position will be adjusted to place the entity above it. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [SetPositionX](M_Rage_Entity_SetPositionX.htm) | Sets X-component of the [Position](P_Rage_Entity_Position.htm) of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [SetPositionY](M_Rage_Entity_SetPositionY.htm) | Sets Y-component of the [Position](P_Rage_Entity_Position.htm) of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [SetPositionZ](M_Rage_Entity_SetPositionZ.htm) | Sets Z-component of the [Position](P_Rage_Entity_Position.htm) of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [SetQuaternionW](M_Rage_Entity_SetQuaternionW.htm) | Sets W-component of the [Quaternion](P_Rage_Entity_Quaternion.htm) of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [SetQuaternionX](M_Rage_Entity_SetQuaternionX.htm) | Sets X-component of the [Quaternion](P_Rage_Entity_Quaternion.htm) of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [SetQuaternionY](M_Rage_Entity_SetQuaternionY.htm) | Sets Y-component of the [Quaternion](P_Rage_Entity_Quaternion.htm) of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [SetQuaternionZ](M_Rage_Entity_SetQuaternionZ.htm) | Sets Z-component of the [Quaternion](P_Rage_Entity_Quaternion.htm) of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [SetRotationPitch](M_Rage_Entity_SetRotationPitch.htm) | Sets Pitch-component of the [Rotation](P_Rage_Entity_Rotation.htm) of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [SetRotationRoll](M_Rage_Entity_SetRotationRoll.htm) | Sets Roll-component of the [Rotation](P_Rage_Entity_Rotation.htm) of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [SetRotationYaw](M_Rage_Entity_SetRotationYaw.htm) | Sets Yaw-component of the [Rotation](P_Rage_Entity_Rotation.htm) of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [TowVehicle](M_Rage_Vehicle_TowVehicle.htm) | Attaches a [Vehicle](T_Rage_Vehicle.htm) to the towing device of this [Vehicle](T_Rage_Vehicle.htm).  This [Vehicle](T_Rage_Vehicle.htm) must have a towing device. |
| Public method | [TravelDistanceTo(ISpatial)](M_Rage_Entity_TravelDistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance, if using the road system. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [TravelDistanceTo(Vector3)](M_Rage_Entity_TravelDistanceTo_1.htm) | Gets the distance from this instance to the specified position, if using the road system. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Wash](M_Rage_Vehicle_Wash.htm) | Washes this instance. |

[Top](#mainBody)

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.