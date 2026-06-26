# Entity Class

﻿Entity Class

|  |  |  |
| --- | --- | --- |
| Entity Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents an entity in the game world.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageEntity  
    [RageBuilding](T_Rage_Building.htm)  
    [RageCamera](T_Rage_Camera.htm)  
    [RageObject](T_Rage_Object.htm)  
    [RagePed](T_Rage_Ped.htm)  
    [RageVehicle](T_Rage_Vehicle.htm)  
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
public abstract class Entity : IHandleable, 
	IAddressable, ISpatial, IRotatable, IDeletable, IPersistable, 
	IRenderable, IVisual
```

```
<SerializableAttribute>
Public MustInherit Class Entity
	Implements IHandleable, IAddressable, ISpatial, IRotatable, 
	IDeletable, IPersistable, IRenderable, IVisual
```

```
[SerializableAttribute]
public ref class Entity abstract : IHandleable, 
	IAddressable, ISpatial, IRotatable, IDeletable, IPersistable, 
	IRenderable, IVisual
```

The Entity type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AbovePosition](P_Rage_Entity_AbovePosition.htm) | Gets a position directly above this Entity. |
| Public property | [AngularVelocity](P_Rage_Entity_AngularVelocity.htm) | Gets or sets the rotational velocity of this entity. |
| Public property | [BelowPosition](P_Rage_Entity_BelowPosition.htm) | Gets a position directly below this Entity. |
| Public property | [CanBeDamaged](P_Rage_Entity_CanBeDamaged.htm) | Gets or sets a value indicating whether this entity can be damaged. |
| Public property | [CollisionIgnoredEntity](P_Rage_Entity_CollisionIgnoredEntity.htm) | Gets or sets the Entity this entity currently ignores collisions from. |
| Public property | [CreatedByTheCallingPlugin](P_Rage_Entity_CreatedByTheCallingPlugin.htm) | Gets a value indicating whether this instance was created by the calling plugin. |
| Public property | [Direction](P_Rage_Entity_Direction.htm) | Gets or sets the direction of this instance. |
| Public property | [ForwardVector](P_Rage_Entity_ForwardVector.htm) | Gets the forward vector of this instance. |
| Public property | [FrontPosition](P_Rage_Entity_FrontPosition.htm) | Gets a position directly in front of this Entity. |
| Public property | [Handle](P_Rage_Entity_Handle.htm) | Gets the handle of this instance. Used to identify the instance within its pool. |
| Public property | [HasBeenDamagedByAnyObject](P_Rage_Entity_HasBeenDamagedByAnyObject.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Object](T_Rage_Object.htm). |
| Public property | [HasBeenDamagedByAnyPed](P_Rage_Entity_HasBeenDamagedByAnyPed.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Ped](T_Rage_Ped.htm). |
| Public property | [HasBeenDamagedByAnyVehicle](P_Rage_Entity_HasBeenDamagedByAnyVehicle.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Vehicle](T_Rage_Vehicle.htm). |
| Public property | [Heading](P_Rage_Entity_Heading.htm) | Gets or sets the heading of this instance in degrees. |
| Public property | [Health](P_Rage_Entity_Health.htm) | Gets or sets the health of this instance. |
| Public property | [Height](P_Rage_Entity_Height.htm) | Gets the height of this Entity. |
| Public property | [HeightAboveGround](P_Rage_Entity_HeightAboveGround.htm) | Gets this entity's distance from the ground in 1D on the Z-axis.  The distance is measured from the entity's origin to the surface below the entity (Surfaces include roofs of buildings). |
| Public property | [Invincible](P_Rage_Entity_Invincible.htm) | **Obsolete.**  Sets a value indicating whether this instance is invincible. |
| Public property | [IsAlive](P_Rage_Entity_IsAlive.htm) | Gets a value indicating whether this instance is alive. |
| Public property | [IsBulletProof](P_Rage_Entity_IsBulletProof.htm) | Gets or sets a value indicating whether this entity can take damage from bullets. |
| Public property | [IsCollisionEnabled](P_Rage_Entity_IsCollisionEnabled.htm) | Gets or sets a value indicating whether collision is enabled for this entity. |
| Public property | [IsCollisionProof](P_Rage_Entity_IsCollisionProof.htm) | Gets or sets a value indicating whether this entity can take damage from collisions. |
| Public property | [IsDead](P_Rage_Entity_IsDead.htm) | Gets a value indicating whether this instance is dead. |
| Public property | [IsExplosionProof](P_Rage_Entity_IsExplosionProof.htm) | Gets or sets a value indicating whether this entity can take damage from explosions. |
| Public property | [IsFireProof](P_Rage_Entity_IsFireProof.htm) | Gets or sets a value indicating whether this entity can take damage from fire. |
| Public property | [IsGravityDisabled](P_Rage_Entity_IsGravityDisabled.htm) | Gets or sets a value indicating whether gravity is disabled for this entity. |
| Public property | [IsInAir](P_Rage_Entity_IsInAir.htm) |  |
| Public property | [IsInvincible](P_Rage_Entity_IsInvincible.htm) | Sets a value indicating whether this instance is invincible. |
| Public property | [IsInWater](P_Rage_Entity_IsInWater.htm) | Gets a value indicating whether this entity is currently in water.  Returns true the moment any part of the entity is touching water. |
| Public property | [IsMeleeProof](P_Rage_Entity_IsMeleeProof.htm) | Gets or sets a value indicating whether this entity can take damage from melee attacks. |
| Public property | [IsOnFire](P_Rage_Entity_IsOnFire.htm) | Gets or sets a value indicating whether this Entity is on fire. |
| Public property | [IsOnScreen](P_Rage_Entity_IsOnScreen.htm) | Gets a value indicating whether this instance is on the screen. |
| Public property | [IsPersistent](P_Rage_Entity_IsPersistent.htm) | Gets or sets a value indicating whether this instance is persistent within the game world. Persistent instances will not be removed automatically during clean ups. |
| Public property | [IsPositionFrozen](P_Rage_Entity_IsPositionFrozen.htm) | Sets a value indicating whether the position of this entity is frozen. |
| Public property | [IsRecordingCollisions](P_Rage_Entity_IsRecordingCollisions.htm) | Gets or sets a value indicating whether this entity is recording collisions. |
| Public property | [IsRendered](P_Rage_Entity_IsRendered.htm) | Gets a value indicating whether this instance is currently being rendered. |
| Public property | [IsUpsideDown](P_Rage_Entity_IsUpsideDown.htm) | Gets or sets a value indicating whether this entity is upside down. |
| Public property | [IsVisible](P_Rage_Entity_IsVisible.htm) | Gets or sets a value indicating whether this instance is currently visible within the game world.  Invisible instances will still be processed but will not be rendered. |
| Public property | [LeftPosition](P_Rage_Entity_LeftPosition.htm) | Gets a position directly to the left of this Entity. |
| Public property | [Length](P_Rage_Entity_Length.htm) | Gets the length of this Entity. |
| Public property | [MaxHealth](P_Rage_Entity_MaxHealth.htm) | Gets or sets the maximum health of this instance. |
| Public property | [MemoryAddress](P_Rage_Entity_MemoryAddress.htm) | Gets the memory address of this instance. |
| Public propertyCode example | [Metadata](P_Rage_Entity_Metadata.htm) | Gets the [metadata](https://en.wikipedia.org/wiki/Metadata) associated with this instance.  The value of this property can be used to store data about this instance.  Getting or setting metadata is done using the same syntax as getting or setting a property.  Internally the value is added to a dictionary with the specified property name as key. |
| Public property | [Model](P_Rage_Entity_Model.htm) | Gets or sets the [Model](P_Rage_IRenderable_Model.htm) of this instance. |
| Public property | [NeedsCollision](P_Rage_Entity_NeedsCollision.htm) | Gets a value indicating whether this instance needs collision.  Entities not marked explicitly to need collision will still get collision, however, if other entities need collision, entities not marked as needing collision may lose it in favor of those. |
| Public property | [Opacity](P_Rage_Entity_Opacity.htm) | Gets or sets the opacity of this instance. |
| Public property | [Orientation](P_Rage_Entity_Orientation.htm) | Gets or sets the orientation of this instance. |
| Public property | [Position](P_Rage_Entity_Position.htm) | Gets or sets the position of this instance. |
| Public property | [Quaternion](P_Rage_Entity_Quaternion.htm) | **Obsolete.**  Gets or sets the quaternion of this instance. |
| Public property | [RearPosition](P_Rage_Entity_RearPosition.htm) | Gets a position directly behind this Entity. |
| Public property | [RightPosition](P_Rage_Entity_RightPosition.htm) | Gets a position directly to the right of this Entity. |
| Public property | [RightVector](P_Rage_Entity_RightVector.htm) | Gets the right vector of this instance. |
| Public property | [Rotation](P_Rage_Entity_Rotation.htm) | Gets or sets the rotation of this instance. |
| Public property | [Speed](P_Rage_Entity_Speed.htm) | Gets the speed of this Entity in meters per second.  This is equivalent of [Velocity](P_Rage_Entity_Velocity.htm).Length(). |
| Public property | [SubmersionLevel](P_Rage_Entity_SubmersionLevel.htm) | Gets a value indicating how submersed this entity is. |
| Public property | [UpVector](P_Rage_Entity_UpVector.htm) | Gets the up vector of this instance. |
| Public property | [Velocity](P_Rage_Entity_Velocity.htm) | Gets or sets the velocity of this entity. |
| Public property | [Width](P_Rage_Entity_Width.htm) | Gets the width of this Entity. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [ApplyForce](M_Rage_Entity_ApplyForce.htm) | Applies force to this instance. |
| Public method | [AttachBlip](M_Rage_Entity_AttachBlip.htm) | Creates a new [Blip](T_Rage_Blip.htm) and attaches it to this instance. |
| Public method | [AttachTo](M_Rage_Entity_AttachTo.htm) | Attaches Entity to another Entity. |
| Public method | [Delete](M_Rage_Entity_Delete.htm) | Deletes this instance.  Any call to a non-existent instance is invalid and will cause an exception. |
| Public method | [Detach](M_Rage_Entity_Detach.htm) | Detaches this Entity from whichever Entity it's currently attached to. |
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
| Public method | [GetBoneIndex](M_Rage_Entity_GetBoneIndex.htm) | Gets the index of a bone of this Entity, given the bone's name. |
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
| Public method | [GetPositionOffset](M_Rage_Entity_GetPositionOffset.htm) | Gets the offset to the specified world position, relative to this Entity.  This is essentially the opposite of [GetOffsetPosition(Vector3)](M_Rage_Entity_GetOffsetPosition.htm) |
| Public method | [HasBeenDamagedBy](M_Rage_Entity_HasBeenDamagedBy.htm) | Determines whether this entity has been damaged by the specified entity. |
| Public method | [HasBone(Int32)](M_Rage_Entity_HasBone.htm) | Determines whether this Entity has the specified bone. |
| Public method | [HasBone(String)](M_Rage_Entity_HasBone_1.htm) | Determines whether this Entity has the specified bone. |
| Public method | [IsTouching](M_Rage_Entity_IsTouching.htm) | Determines whether this entity is touching the specified entity. |
| Public method | [IsValid](M_Rage_Entity_IsValid.htm) | Determines whether this instance still represents an existing entity within the game world. Calls to an invalid instance is illegal and will result in an exception. |
| Public method | [MakePersistent](M_Rage_Entity_MakePersistent.htm) | Makes this entity persistent. |
| Public method | [SetPositionWithSnap](M_Rage_Entity_SetPositionWithSnap.htm) | Sets the position of this Entity to the specified value.  Unlike [Position](P_Rage_Entity_Position.htm), if the specified position is in the ground, the position will be adjusted to place the entity above it. |
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

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [Equality](M_Rage_Entity_op_Equality.htm) |  |
| Public operatorStatic member | [(Entity to Boolean)](M_Rage_Entity_op_Implicit.htm) |  |
| Public operatorStatic member | [Inequality](M_Rage_Entity_op_Inequality.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

[RagePed](T_Rage_Ped.htm)

[RageVehicle](T_Rage_Vehicle.htm)

[RageWeapon](T_Rage_Weapon.htm)

[RageCamera](T_Rage_Camera.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.