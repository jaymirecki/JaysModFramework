# Building Class

﻿Building Class

|  |  |  |
| --- | --- | --- |
| Building Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents a building in the game world.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [RageEntity](T_Rage_Entity.htm)  
    RageBuilding  
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
[SerializableAttribute]
public sealed class Building : Entity
```

```
<SerializableAttribute>
Public NotInheritable Class Building
	Inherits Entity
```

```
[SerializableAttribute]
public ref class Building sealed : public Entity
```

The Building type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AbovePosition](P_Rage_Entity_AbovePosition.htm) | Gets a position directly above this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [AngularVelocity](P_Rage_Entity_AngularVelocity.htm) | Gets or sets the rotational velocity of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [BelowPosition](P_Rage_Entity_BelowPosition.htm) | Gets a position directly below this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [CanBeDamaged](P_Rage_Entity_CanBeDamaged.htm) | Gets or sets a value indicating whether this entity can be damaged. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [CollisionIgnoredEntity](P_Rage_Entity_CollisionIgnoredEntity.htm) | Gets or sets the [Entity](T_Rage_Entity.htm) this entity currently ignores collisions from. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [CreatedByTheCallingPlugin](P_Rage_Entity_CreatedByTheCallingPlugin.htm) | Gets a value indicating whether this instance was created by the calling plugin. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Direction](P_Rage_Entity_Direction.htm) | Gets or sets the direction of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [ForwardVector](P_Rage_Entity_ForwardVector.htm) | Gets the forward vector of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [FrontPosition](P_Rage_Entity_FrontPosition.htm) | Gets a position directly in front of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Handle](P_Rage_Entity_Handle.htm) | Gets the handle of this instance. Used to identify the instance within its pool. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HasBeenDamagedByAnyObject](P_Rage_Entity_HasBeenDamagedByAnyObject.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Object](T_Rage_Object.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HasBeenDamagedByAnyPed](P_Rage_Entity_HasBeenDamagedByAnyPed.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Ped](T_Rage_Ped.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HasBeenDamagedByAnyVehicle](P_Rage_Entity_HasBeenDamagedByAnyVehicle.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Vehicle](T_Rage_Vehicle.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Heading](P_Rage_Entity_Heading.htm) | Gets or sets the heading of this instance in degrees. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Health](P_Rage_Entity_Health.htm) | Gets or sets the health of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Height](P_Rage_Entity_Height.htm) | Gets the height of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HeightAboveGround](P_Rage_Entity_HeightAboveGround.htm) | Gets this entity's distance from the ground in 1D on the Z-axis.  The distance is measured from the entity's origin to the surface below the entity (Surfaces include roofs of buildings). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Invincible](P_Rage_Entity_Invincible.htm) | **Obsolete.**  Sets a value indicating whether this instance is invincible. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsAlive](P_Rage_Entity_IsAlive.htm) | Gets a value indicating whether this instance is alive. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsBulletProof](P_Rage_Entity_IsBulletProof.htm) | Gets or sets a value indicating whether this entity can take damage from bullets. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsCollisionEnabled](P_Rage_Entity_IsCollisionEnabled.htm) | Gets or sets a value indicating whether collision is enabled for this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsCollisionProof](P_Rage_Entity_IsCollisionProof.htm) | Gets or sets a value indicating whether this entity can take damage from collisions. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsDead](P_Rage_Entity_IsDead.htm) | Gets a value indicating whether this instance is dead. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsExplosionProof](P_Rage_Entity_IsExplosionProof.htm) | Gets or sets a value indicating whether this entity can take damage from explosions. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsFireProof](P_Rage_Entity_IsFireProof.htm) | Gets or sets a value indicating whether this entity can take damage from fire. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsGravityDisabled](P_Rage_Entity_IsGravityDisabled.htm) | Gets or sets a value indicating whether gravity is disabled for this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsInAir](P_Rage_Entity_IsInAir.htm) | (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsInvincible](P_Rage_Entity_IsInvincible.htm) | Sets a value indicating whether this instance is invincible. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsInWater](P_Rage_Entity_IsInWater.htm) | Gets a value indicating whether this entity is currently in water.  Returns true the moment any part of the entity is touching water. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsMeleeProof](P_Rage_Entity_IsMeleeProof.htm) | Gets or sets a value indicating whether this entity can take damage from melee attacks. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsOnFire](P_Rage_Entity_IsOnFire.htm) | Gets or sets a value indicating whether this [Entity](T_Rage_Entity.htm) is on fire. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsOnScreen](P_Rage_Entity_IsOnScreen.htm) | Gets a value indicating whether this instance is on the screen. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsPersistent](P_Rage_Entity_IsPersistent.htm) | Gets or sets a value indicating whether this instance is persistent within the game world. Persistent instances will not be removed automatically during clean ups. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsPositionFrozen](P_Rage_Entity_IsPositionFrozen.htm) | Sets a value indicating whether the position of this entity is frozen. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsRecordingCollisions](P_Rage_Entity_IsRecordingCollisions.htm) | Gets or sets a value indicating whether this entity is recording collisions. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsRendered](P_Rage_Entity_IsRendered.htm) | Gets a value indicating whether this instance is currently being rendered. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsUpsideDown](P_Rage_Entity_IsUpsideDown.htm) | Gets or sets a value indicating whether this entity is upside down. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsVisible](P_Rage_Entity_IsVisible.htm) | Gets or sets a value indicating whether this instance is currently visible within the game world.  Invisible instances will still be processed but will not be rendered. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [LeftPosition](P_Rage_Entity_LeftPosition.htm) | Gets a position directly to the left of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Length](P_Rage_Entity_Length.htm) | Gets the length of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [MaxHealth](P_Rage_Entity_MaxHealth.htm) | Gets or sets the maximum health of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [MemoryAddress](P_Rage_Entity_MemoryAddress.htm) | Gets the memory address of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public propertyCode example | [Metadata](P_Rage_Entity_Metadata.htm) | Gets the [metadata](https://en.wikipedia.org/wiki/Metadata) associated with this instance.  The value of this property can be used to store data about this instance.  Getting or setting metadata is done using the same syntax as getting or setting a property.  Internally the value is added to a dictionary with the specified property name as key. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Model](P_Rage_Entity_Model.htm) | Gets or sets the [Model](P_Rage_IRenderable_Model.htm) of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [NeedsCollision](P_Rage_Entity_NeedsCollision.htm) | Gets a value indicating whether this instance needs collision.  Entities not marked explicitly to need collision will still get collision, however, if other entities need collision, entities not marked as needing collision may lose it in favor of those. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Opacity](P_Rage_Entity_Opacity.htm) | Gets or sets the opacity of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Orientation](P_Rage_Entity_Orientation.htm) | Gets or sets the orientation of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Position](P_Rage_Entity_Position.htm) | Gets or sets the position of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Quaternion](P_Rage_Entity_Quaternion.htm) | **Obsolete.**  Gets or sets the quaternion of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [RearPosition](P_Rage_Entity_RearPosition.htm) | Gets a position directly behind this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [RightPosition](P_Rage_Entity_RightPosition.htm) | Gets a position directly to the right of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [RightVector](P_Rage_Entity_RightVector.htm) | Gets the right vector of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Rotation](P_Rage_Entity_Rotation.htm) | Gets or sets the rotation of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Speed](P_Rage_Entity_Speed.htm) | Gets the speed of this [Entity](T_Rage_Entity.htm) in meters per second.  This is equivalent of [Velocity](P_Rage_Entity_Velocity.htm).Length(). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [SubmersionLevel](P_Rage_Entity_SubmersionLevel.htm) | Gets a value indicating how submersed this entity is. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [UpVector](P_Rage_Entity_UpVector.htm) | Gets the up vector of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Velocity](P_Rage_Entity_Velocity.htm) | Gets or sets the velocity of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Width](P_Rage_Entity_Width.htm) | Gets the width of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [ApplyForce](M_Rage_Entity_ApplyForce.htm) | Applies force to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [AttachBlip](M_Rage_Entity_AttachBlip.htm) | Creates a new [Blip](T_Rage_Blip.htm) and attaches it to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [AttachTo](M_Rage_Entity_AttachTo.htm) | Attaches [Entity](T_Rage_Entity.htm) to another [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Delete](M_Rage_Entity_Delete.htm) | Deletes this instance.  Any call to a non-existent instance is invalid and will cause an exception. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Detach](M_Rage_Entity_Detach.htm) | Detaches this [Entity](T_Rage_Entity.htm) from whichever [Entity](T_Rage_Entity.htm) it's currently attached to. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Dismiss](M_Rage_Entity_Dismiss.htm) | If this instance is marked as persistent, makes the entity non-persistent. Non-persistent entities will be deleted from the game world during clean ups.  This is equivalent to setting IsPersistent to false. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo(ISpatial)](M_Rage_Entity_DistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo(Vector3)](M_Rage_Entity_DistanceTo_1.htm) | Gets the distance from this instance to the specified position. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo2D(ISpatial)](M_Rage_Entity_DistanceTo2D.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [DistanceTo2D(Vector3)](M_Rage_Entity_DistanceTo2D_1.htm) | Gets the distance from this instance to the specified position. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Equals(Entity)](M_Rage_Entity_Equals.htm) | Indicates whether the current instance is equal to another instance of the same type. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Equals(IHandleable)](M_Rage_Entity_Equals_1.htm) | Indicates whether the current [IHandleable](T_Rage_IHandleable.htm) is equal to another [IHandleable](T_Rage_IHandleable.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Face(ISpatial)](M_Rage_Entity_Face.htm) | Sets the orientation of this instance to face the specified [ISpatial](T_Rage_ISpatial.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [Face(Vector3)](M_Rage_Entity_Face_1.htm) | Sets the orientation of this instance to face the specified position. (Inherited from [Entity](T_Rage_Entity.htm).) |
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
| Public method | [GetLastCollision(Vector3)](M_Rage_Entity_GetLastCollision.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetLastCollision(Vector3, Vector3)](M_Rage_Entity_GetLastCollision_1.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetLastCollision(Vector3, Vector3, String)](M_Rage_Entity_GetLastCollision_2.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public methodCode example | [GetOffsetPosition](M_Rage_Entity_GetOffsetPosition.htm) | Gets a position offset relative to this instance, based on the instance's position and direction. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionFront](M_Rage_Entity_GetOffsetPositionFront.htm) | Gets a position that is the specified offset towards the entity's front. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionRight](M_Rage_Entity_GetOffsetPositionRight.htm) | Gets a position that is the specified offset towards the entity's right. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionUp](M_Rage_Entity_GetOffsetPositionUp.htm) | Gets a position that is the specified offset towards the entity's top. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetPositionOffset](M_Rage_Entity_GetPositionOffset.htm) | Gets the offset to the specified world position, relative to this [Entity](T_Rage_Entity.htm).  This is essentially the opposite of [GetOffsetPosition(Vector3)](M_Rage_Entity_GetOffsetPosition.htm) (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [HasBeenDamagedBy](M_Rage_Entity_HasBeenDamagedBy.htm) | Determines whether this entity has been damaged by the specified entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [HasBone(Int32)](M_Rage_Entity_HasBone.htm) | Determines whether this [Entity](T_Rage_Entity.htm) has the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [HasBone(String)](M_Rage_Entity_HasBone_1.htm) | Determines whether this [Entity](T_Rage_Entity.htm) has the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [IsTouching](M_Rage_Entity_IsTouching.htm) | Determines whether this entity is touching the specified entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [IsValid](M_Rage_Entity_IsValid.htm) | Determines whether this instance still represents an existing entity within the game world. Calls to an invalid instance is illegal and will result in an exception. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [MakePersistent](M_Rage_Entity_MakePersistent.htm) | Makes this entity persistent. (Inherited from [Entity](T_Rage_Entity.htm).) |
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
| Public method | [TravelDistanceTo(ISpatial)](M_Rage_Entity_TravelDistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance, if using the road system. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [TravelDistanceTo(Vector3)](M_Rage_Entity_TravelDistanceTo_1.htm) | Gets the distance from this instance to the specified position, if using the road system. (Inherited from [Entity](T_Rage_Entity.htm).) |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.