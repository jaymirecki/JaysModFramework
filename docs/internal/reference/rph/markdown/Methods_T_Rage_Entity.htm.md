# Entity Methods

﻿Entity Methods

|  |  |  |
| --- | --- | --- |
| Entity Methods | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [Entity](T_Rage_Entity.htm) type exposes the following members.

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [ApplyForce](M_Rage_Entity_ApplyForce.htm) | Applies force to this instance. |
| Public method | [AttachBlip](M_Rage_Entity_AttachBlip.htm) | Creates a new [Blip](T_Rage_Blip.htm) and attaches it to this instance. |
| Public method | [AttachTo](M_Rage_Entity_AttachTo.htm) | Attaches [Entity](T_Rage_Entity.htm) to another [Entity](T_Rage_Entity.htm). |
| Public method | [Delete](M_Rage_Entity_Delete.htm) | Deletes this instance.  Any call to a non-existent instance is invalid and will cause an exception. |
| Public method | [Detach](M_Rage_Entity_Detach.htm) | Detaches this [Entity](T_Rage_Entity.htm) from whichever [Entity](T_Rage_Entity.htm) it's currently attached to. |
| Public method | [Dismiss](M_Rage_Entity_Dismiss.htm) | If this instance is marked as persistent, makes the entity non-persistent. Non-persistent entities will be deleted from the game world during clean ups.  This is equivalent to setting IsPersistent to false. |
| Public method | [DistanceTo(ISpatial)](M_Rage_Entity_DistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. |
| Public method | [DistanceTo(Vector3)](M_Rage_Entity_DistanceTo_1.htm) | Gets the distance from this instance to the specified position. |
| Public method | [DistanceTo2D(ISpatial)](M_Rage_Entity_DistanceTo2D.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. |
| Public method | [DistanceTo2D(Vector3)](M_Rage_Entity_DistanceTo2D_1.htm) | Gets the distance from this instance to the specified position. |
| Public method | [Equals(Entity)](M_Rage_Entity_Equals.htm) | Indicates whether the current instance is equal to another instance of the same type. |
| Public method | [Equals(IHandleable)](M_Rage_Entity_Equals_1.htm) | Indicates whether the current [IHandleable](T_Rage_IHandleable.htm) is equal to another [IHandleable](T_Rage_IHandleable.htm). |
| Public method | [Face(ISpatial)](M_Rage_Entity_Face.htm) | Sets the orientation of this instance to face the specified [ISpatial](T_Rage_ISpatial.htm). |
| Public method | [Face(Vector3)](M_Rage_Entity_Face_1.htm) | Sets the orientation of this instance to face the specified position. |
| Public method | [GetAttachedBlip](M_Rage_Entity_GetAttachedBlip.htm) | Gets the first [Blip](T_Rage_Blip.htm) attached to this instance. |
| Public method | [GetAttachedBlips](M_Rage_Entity_GetAttachedBlips.htm) | Gets all [Blip](T_Rage_Blip.htm)s attached to this instance. |
| Public method | [GetBoneAxes(Int32, Vector3, Vector3, Vector3)](M_Rage_Entity_GetBoneAxes.htm) | Gets the axes of the specified bone. That is, three vectors pointing right, forward and up, relative to the bone's orientation. |
| Public method | [GetBoneAxes(String, Vector3, Vector3, Vector3)](M_Rage_Entity_GetBoneAxes_1.htm) | Gets the axes of the specified bone. That is, three vectors pointing right, forward and up, relative to the bone's orientation. |
| Public method | [GetBoneIndex](M_Rage_Entity_GetBoneIndex.htm) | Gets the index of a bone of this [Entity](T_Rage_Entity.htm), given the bone's name. |
| Public method | [GetBoneOrientation(Int32)](M_Rage_Entity_GetBoneOrientation.htm) | Gets the orientation of the specified bone. |
| Public method | [GetBoneOrientation(String)](M_Rage_Entity_GetBoneOrientation_1.htm) | Gets the orientation of the specified bone. |
| Public method | [GetBonePosition(Int32)](M_Rage_Entity_GetBonePosition.htm) | Gets the position of the specified bone, in world space. |
| Public method | [GetBonePosition(String)](M_Rage_Entity_GetBonePosition_1.htm) | Gets the position of the specified bone, in world space. |
| Public method | [GetBoneRotation(Int32)](M_Rage_Entity_GetBoneRotation.htm) | Gets the rotation of the specified bone. |
| Public method | [GetBoneRotation(String)](M_Rage_Entity_GetBoneRotation_1.htm) | Gets the rotation of the specified bone. |
| Public method | [GetLastCollision(Vector3)](M_Rage_Entity_GetLastCollision.htm) | Gets the last collision of this entity. |
| Public method | [GetLastCollision(Vector3, Vector3)](M_Rage_Entity_GetLastCollision_1.htm) | Gets the last collision of this entity. |
| Public method | [GetLastCollision(Vector3, Vector3, String)](M_Rage_Entity_GetLastCollision_2.htm) | Gets the last collision of this entity. |
| Public methodCode example | [GetOffsetPosition](M_Rage_Entity_GetOffsetPosition.htm) | Gets a position offset relative to this instance, based on the instance's position and direction. |
| Public method | [GetOffsetPositionFront](M_Rage_Entity_GetOffsetPositionFront.htm) | Gets a position that is the specified offset towards the entity's front. |
| Public method | [GetOffsetPositionRight](M_Rage_Entity_GetOffsetPositionRight.htm) | Gets a position that is the specified offset towards the entity's right. |
| Public method | [GetOffsetPositionUp](M_Rage_Entity_GetOffsetPositionUp.htm) | Gets a position that is the specified offset towards the entity's top. |
| Public method | [GetPositionOffset](M_Rage_Entity_GetPositionOffset.htm) | Gets the offset to the specified world position, relative to this [Entity](T_Rage_Entity.htm).  This is essentially the opposite of [GetOffsetPosition(Vector3)](M_Rage_Entity_GetOffsetPosition.htm) |
| Public method | [HasBeenDamagedBy](M_Rage_Entity_HasBeenDamagedBy.htm) | Determines whether this entity has been damaged by the specified entity. |
| Public method | [HasBone(Int32)](M_Rage_Entity_HasBone.htm) | Determines whether this [Entity](T_Rage_Entity.htm) has the specified bone. |
| Public method | [HasBone(String)](M_Rage_Entity_HasBone_1.htm) | Determines whether this [Entity](T_Rage_Entity.htm) has the specified bone. |
| Public method | [IsTouching](M_Rage_Entity_IsTouching.htm) | Determines whether this entity is touching the specified entity. |
| Public method | [IsValid](M_Rage_Entity_IsValid.htm) | Determines whether this instance still represents an existing entity within the game world. Calls to an invalid instance is illegal and will result in an exception. |
| Public method | [MakePersistent](M_Rage_Entity_MakePersistent.htm) | Makes this entity persistent. |
| Public method | [SetPositionWithSnap](M_Rage_Entity_SetPositionWithSnap.htm) | Sets the position of this [Entity](T_Rage_Entity.htm) to the specified value.  Unlike [Position](P_Rage_Entity_Position.htm), if the specified position is in the ground, the position will be adjusted to place the entity above it. |
| Public method | [SetPositionX](M_Rage_Entity_SetPositionX.htm) | Sets X-component of the [Position](P_Rage_Entity_Position.htm) of this entity. |
| Public method | [SetPositionY](M_Rage_Entity_SetPositionY.htm) | Sets Y-component of the [Position](P_Rage_Entity_Position.htm) of this entity. |
| Public method | [SetPositionZ](M_Rage_Entity_SetPositionZ.htm) | Sets Z-component of the [Position](P_Rage_Entity_Position.htm) of this entity. |
| Public method | [SetQuaternionW](M_Rage_Entity_SetQuaternionW.htm) | Sets W-component of the [Quaternion](P_Rage_Entity_Quaternion.htm) of this entity. |
| Public method | [SetQuaternionX](M_Rage_Entity_SetQuaternionX.htm) | Sets X-component of the [Quaternion](P_Rage_Entity_Quaternion.htm) of this entity. |
| Public method | [SetQuaternionY](M_Rage_Entity_SetQuaternionY.htm) | Sets Y-component of the [Quaternion](P_Rage_Entity_Quaternion.htm) of this entity. |
| Public method | [SetQuaternionZ](M_Rage_Entity_SetQuaternionZ.htm) | Sets Z-component of the [Quaternion](P_Rage_Entity_Quaternion.htm) of this entity. |
| Public method | [SetRotationPitch](M_Rage_Entity_SetRotationPitch.htm) | Sets Pitch-component of the [Rotation](P_Rage_Entity_Rotation.htm) of this entity. |
| Public method | [SetRotationRoll](M_Rage_Entity_SetRotationRoll.htm) | Sets Roll-component of the [Rotation](P_Rage_Entity_Rotation.htm) of this entity. |
| Public method | [SetRotationYaw](M_Rage_Entity_SetRotationYaw.htm) | Sets Yaw-component of the [Rotation](P_Rage_Entity_Rotation.htm) of this entity. |
| Public method | [TravelDistanceTo(ISpatial)](M_Rage_Entity_TravelDistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance, if using the road system. |
| Public method | [TravelDistanceTo(Vector3)](M_Rage_Entity_TravelDistanceTo_1.htm) | Gets the distance from this instance to the specified position, if using the road system. |

[Top](#mainBody)

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.