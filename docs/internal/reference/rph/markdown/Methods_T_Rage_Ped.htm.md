# Ped Methods

﻿Ped Methods

|  |  |  |
| --- | --- | --- |
| Ped Methods | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [Ped](T_Rage_Ped.htm) type exposes the following members.

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [ApplyForce](M_Rage_Entity_ApplyForce.htm) | Applies force to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [AttachBlip](M_Rage_Entity_AttachBlip.htm) | Creates a new [Blip](T_Rage_Blip.htm) and attaches it to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [AttachTo](M_Rage_Entity_AttachTo.htm) | Attaches [Entity](T_Rage_Entity.htm) to another [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [ClearBlood](M_Rage_Ped_ClearBlood.htm) | Removes all blood decals from this [Ped](T_Rage_Ped.htm). |
| Public method | [ClearLastDamageBone](M_Rage_Ped_ClearLastDamageBone.htm) |  |
| Public method | [ClearLastVehicle](M_Rage_Ped_ClearLastVehicle.htm) |  |
| Public method | [ClearWetness](M_Rage_Ped_ClearWetness.htm) | Clears the wetness of this [Ped](T_Rage_Ped.htm). |
| Public method | [Clone](M_Rage_Ped_Clone.htm) |  |
| Public method | [Delete](M_Rage_Ped_Delete.htm) | Deletes this instance.  Any call to a non-existent instance is invalid and will cause an exception. (Overrides [EntityDelete](M_Rage_Entity_Delete.htm).) |
| Public method | [Detach](M_Rage_Entity_Detach.htm) | Detaches this [Entity](T_Rage_Entity.htm) from whichever [Entity](T_Rage_Entity.htm) it's currently attached to. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Dismiss](M_Rage_Entity_Dismiss.htm) | If this instance is marked as persistent, makes the entity non-persistent. Non-persistent entities will be deleted from the game world during clean ups.  This is equivalent to setting IsPersistent to false. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo(ISpatial)](M_Rage_Entity_DistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo(Vector3)](M_Rage_Entity_DistanceTo_1.htm) | Gets the distance from this instance to the specified position. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo2D(ISpatial)](M_Rage_Entity_DistanceTo2D.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo2D(Vector3)](M_Rage_Entity_DistanceTo2D_1.htm) | Gets the distance from this instance to the specified position. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Equals(Entity)](M_Rage_Entity_Equals.htm) | Indicates whether the current instance is equal to another instance of the same type. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Equals(IHandleable)](M_Rage_Entity_Equals_1.htm) | Indicates whether the current [IHandleable](T_Rage_IHandleable.htm) is equal to another [IHandleable](T_Rage_IHandleable.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Face(ISpatial)](M_Rage_Entity_Face.htm) | Sets the orientation of this instance to face the specified [ISpatial](T_Rage_ISpatial.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Face(Vector3)](M_Rage_Ped_Face.htm) | (Overrides [EntityFace(Vector3)](M_Rage_Entity_Face_1.htm).) |
| Public method | [GetAttachedBlip](M_Rage_Entity_GetAttachedBlip.htm) | Gets the first [Blip](T_Rage_Blip.htm) attached to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetAttachedBlips](M_Rage_Entity_GetAttachedBlips.htm) | Gets all [Blip](T_Rage_Blip.htm)s attached to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneAxes(Int32, Vector3, Vector3, Vector3)](M_Rage_Entity_GetBoneAxes.htm) | Gets the axes of the specified bone. That is, three vectors pointing right, forward and up, relative to the bone's orientation. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneAxes(String, Vector3, Vector3, Vector3)](M_Rage_Entity_GetBoneAxes_1.htm) | Gets the axes of the specified bone. That is, three vectors pointing right, forward and up, relative to the bone's orientation. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneAxes(PedBoneId, Vector3, Vector3, Vector3)](M_Rage_Ped_GetBoneAxes.htm) |  |
| Public method | [GetBoneIndex(String)](M_Rage_Entity_GetBoneIndex.htm) | Gets the index of a bone of this [Entity](T_Rage_Entity.htm), given the bone's name. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneIndex(PedBoneId)](M_Rage_Ped_GetBoneIndex.htm) |  |
| Public method | [GetBoneOrientation(Int32)](M_Rage_Entity_GetBoneOrientation.htm) | Gets the orientation of the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneOrientation(String)](M_Rage_Entity_GetBoneOrientation_1.htm) | Gets the orientation of the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneOrientation(PedBoneId)](M_Rage_Ped_GetBoneOrientation.htm) |  |
| Public method | [GetBonePosition(Int32)](M_Rage_Entity_GetBonePosition.htm) | Gets the position of the specified bone, in world space. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBonePosition(String)](M_Rage_Entity_GetBonePosition_1.htm) | Gets the position of the specified bone, in world space. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBonePosition(PedBoneId)](M_Rage_Ped_GetBonePosition.htm) |  |
| Public method | [GetBoneRotation(Int32)](M_Rage_Entity_GetBoneRotation.htm) | Gets the rotation of the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneRotation(String)](M_Rage_Entity_GetBoneRotation_1.htm) | Gets the rotation of the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetBoneRotation(PedBoneId)](M_Rage_Ped_GetBoneRotation.htm) |  |
| Public method | [GetDrawableVariationCount](M_Rage_Ped_GetDrawableVariationCount.htm) | Gets the number of drawable variations for the specified component of this [Ped](T_Rage_Ped.htm). |
| Public method | [GetLastCollision(Vector3)](M_Rage_Entity_GetLastCollision.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetLastCollision(Vector3, Vector3)](M_Rage_Entity_GetLastCollision_1.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetLastCollision(Vector3, Vector3, String)](M_Rage_Entity_GetLastCollision_2.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetNearbyPeds](M_Rage_Ped_GetNearbyPeds.htm) | Gets [Ped](T_Rage_Ped.htm)s near this [Ped](T_Rage_Ped.htm). |
| Public method | [GetNearbyVehicles](M_Rage_Ped_GetNearbyVehicles.htm) | Gets [Vehicle](T_Rage_Vehicle.htm)s near this [Ped](T_Rage_Ped.htm). |
| Public methodCode example | [GetOffsetPosition](M_Rage_Entity_GetOffsetPosition.htm) | Gets a position offset relative to this instance, based on the instance's position and direction. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionFront](M_Rage_Entity_GetOffsetPositionFront.htm) | Gets a position that is the specified offset towards the entity's front. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionRight](M_Rage_Entity_GetOffsetPositionRight.htm) | Gets a position that is the specified offset towards the entity's right. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionUp](M_Rage_Entity_GetOffsetPositionUp.htm) | Gets a position that is the specified offset towards the entity's top. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetPositionOffset](M_Rage_Entity_GetPositionOffset.htm) | Gets the offset to the specified world position, relative to this [Entity](T_Rage_Entity.htm).  This is essentially the opposite of [GetOffsetPosition(Vector3)](M_Rage_Entity_GetOffsetPosition.htm) (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetTextureVariationCount](M_Rage_Ped_GetTextureVariationCount.htm) | Gets the number of drawable variations for the specified component of this [Ped](T_Rage_Ped.htm). |
| Public method | [GetVariation](M_Rage_Ped_GetVariation.htm) | Gets the variation of this [Ped](T_Rage_Ped.htm). |
| Public method | [GiveHelmet](M_Rage_Ped_GiveHelmet.htm) | Gives this [Ped](T_Rage_Ped.htm) a new helmet of the specified type. |
| Public method | [HasBeenDamagedBy](M_Rage_Entity_HasBeenDamagedBy.htm) | Determines whether this entity has been damaged by the specified entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [HasBone(Int32)](M_Rage_Entity_HasBone.htm) | Determines whether this [Entity](T_Rage_Entity.htm) has the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [HasBone(String)](M_Rage_Entity_HasBone_1.htm) | Determines whether this [Entity](T_Rage_Entity.htm) has the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [IsBoneValid](M_Rage_Ped_IsBoneValid.htm) |  |
| Public method | [IsInAnyVehicle](M_Rage_Ped_IsInAnyVehicle.htm) | Gets whether this [Ped](T_Rage_Ped.htm) is in any [Vehicle](T_Rage_Vehicle.htm). |
| Public method | [IsInVehicle](M_Rage_Ped_IsInVehicle.htm) | Gets whether this [Ped](T_Rage_Ped.htm) is in the specified [Vehicle](T_Rage_Vehicle.htm). |
| Public method | [IsStandingOnVehicle](M_Rage_Ped_IsStandingOnVehicle.htm) | Determines whether this [Ped](T_Rage_Ped.htm) is standing on a vehicle. |
| Public method | [IsStandingOnVehicle(Vehicle)](M_Rage_Ped_IsStandingOnVehicle_1.htm) | Determines whether this [Ped](T_Rage_Ped.htm) is standing on the specified vehicle. |
| Public method | [IsTouching](M_Rage_Entity_IsTouching.htm) | Determines whether this entity is touching the specified entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [IsValid](M_Rage_Entity_IsValid.htm) | Determines whether this instance still represents an existing entity within the game world. Calls to an invalid instance is illegal and will result in an exception. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Kill](M_Rage_Ped_Kill.htm) | Kills this instance. |
| Public method | [KnockOffBike](M_Rage_Ped_KnockOffBike.htm) |  |
| Public method | [MakePersistent](M_Rage_Entity_MakePersistent.htm) | Makes this entity persistent. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [OpenParachute](M_Rage_Ped_OpenParachute.htm) |  |
| Public method | [PlayAmbientSpeech(String)](M_Rage_Ped_PlayAmbientSpeech.htm) | Plays the specified ambient speech. |
| Public method | [PlayAmbientSpeech(String, Boolean)](M_Rage_Ped_PlayAmbientSpeech_1.htm) | Plays the specified ambient speech. |
| Public methodCode example | [PlayAmbientSpeech(String, String, Int32, SpeechModifier)](M_Rage_Ped_PlayAmbientSpeech_2.htm) | Plays the specified ambient speech. |
| Public method | [RandomizeVariation](M_Rage_Ped_RandomizeVariation.htm) | Assigns random drawable and drawable texture indices to all components of this ped; however, it will not assign invalid compositions, eg. caucasian head on an african american body. It will not however, ensure non-silly outfits (Player characters in particular). |
| Public method | [RemoveHelmet](M_Rage_Ped_RemoveHelmet.htm) | Removes this [Ped](T_Rage_Ped.htm)'s current helmet. |
| Public method | [ResetVariation](M_Rage_Ped_ResetVariation.htm) | Assigns default drawable and drawable texture indices to all components of this ped. |
| Public method | [Resurrect](M_Rage_Ped_Resurrect.htm) | Resurrects this instance. |
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
| Public method | [SetTargetableByPlayer](M_Rage_Ped_SetTargetableByPlayer.htm) | Sets whether this [Ped](T_Rage_Ped.htm) can be targetted. |
| Public method | [SetVariation](M_Rage_Ped_SetVariation.htm) | Sets the variation of this [Ped](T_Rage_Ped.htm). |
| Public method | [SetWetnessHeight](M_Rage_Ped_SetWetnessHeight.htm) | Sets the height of the wetness of this [Ped](T_Rage_Ped.htm). |
| Public method | [TravelDistanceTo(ISpatial)](M_Rage_Entity_TravelDistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance, if using the road system. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [TravelDistanceTo(Vector3)](M_Rage_Entity_TravelDistanceTo_1.htm) | Gets the distance from this instance to the specified position, if using the road system. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [WarpIntoVehicle](M_Rage_Ped_WarpIntoVehicle.htm) | Warps this [Ped](T_Rage_Ped.htm) into the specified [Vehicle](T_Rage_Vehicle.htm). |

[Top](#mainBody)

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.