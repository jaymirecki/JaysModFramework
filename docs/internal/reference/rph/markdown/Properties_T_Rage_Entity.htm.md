# Entity Properties

﻿Entity Properties

|  |  |  |
| --- | --- | --- |
| Entity Properties | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [Entity](T_Rage_Entity.htm) type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AbovePosition](P_Rage_Entity_AbovePosition.htm) | Gets a position directly above this [Entity](T_Rage_Entity.htm). |
| Public property | [AngularVelocity](P_Rage_Entity_AngularVelocity.htm) | Gets or sets the rotational velocity of this entity. |
| Public property | [BelowPosition](P_Rage_Entity_BelowPosition.htm) | Gets a position directly below this [Entity](T_Rage_Entity.htm). |
| Public property | [CanBeDamaged](P_Rage_Entity_CanBeDamaged.htm) | Gets or sets a value indicating whether this entity can be damaged. |
| Public property | [CollisionIgnoredEntity](P_Rage_Entity_CollisionIgnoredEntity.htm) | Gets or sets the [Entity](T_Rage_Entity.htm) this entity currently ignores collisions from. |
| Public property | [CreatedByTheCallingPlugin](P_Rage_Entity_CreatedByTheCallingPlugin.htm) | Gets a value indicating whether this instance was created by the calling plugin. |
| Public property | [Direction](P_Rage_Entity_Direction.htm) | Gets or sets the direction of this instance. |
| Public property | [ForwardVector](P_Rage_Entity_ForwardVector.htm) | Gets the forward vector of this instance. |
| Public property | [FrontPosition](P_Rage_Entity_FrontPosition.htm) | Gets a position directly in front of this [Entity](T_Rage_Entity.htm). |
| Public property | [Handle](P_Rage_Entity_Handle.htm) | Gets the handle of this instance. Used to identify the instance within its pool. |
| Public property | [HasBeenDamagedByAnyObject](P_Rage_Entity_HasBeenDamagedByAnyObject.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Object](T_Rage_Object.htm). |
| Public property | [HasBeenDamagedByAnyPed](P_Rage_Entity_HasBeenDamagedByAnyPed.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Ped](T_Rage_Ped.htm). |
| Public property | [HasBeenDamagedByAnyVehicle](P_Rage_Entity_HasBeenDamagedByAnyVehicle.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Vehicle](T_Rage_Vehicle.htm). |
| Public property | [Heading](P_Rage_Entity_Heading.htm) | Gets or sets the heading of this instance in degrees. |
| Public property | [Health](P_Rage_Entity_Health.htm) | Gets or sets the health of this instance. |
| Public property | [Height](P_Rage_Entity_Height.htm) | Gets the height of this [Entity](T_Rage_Entity.htm). |
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
| Public property | [IsOnFire](P_Rage_Entity_IsOnFire.htm) | Gets or sets a value indicating whether this [Entity](T_Rage_Entity.htm) is on fire. |
| Public property | [IsOnScreen](P_Rage_Entity_IsOnScreen.htm) | Gets a value indicating whether this instance is on the screen. |
| Public property | [IsPersistent](P_Rage_Entity_IsPersistent.htm) | Gets or sets a value indicating whether this instance is persistent within the game world. Persistent instances will not be removed automatically during clean ups. |
| Public property | [IsPositionFrozen](P_Rage_Entity_IsPositionFrozen.htm) | Sets a value indicating whether the position of this entity is frozen. |
| Public property | [IsRecordingCollisions](P_Rage_Entity_IsRecordingCollisions.htm) | Gets or sets a value indicating whether this entity is recording collisions. |
| Public property | [IsRendered](P_Rage_Entity_IsRendered.htm) | Gets a value indicating whether this instance is currently being rendered. |
| Public property | [IsUpsideDown](P_Rage_Entity_IsUpsideDown.htm) | Gets or sets a value indicating whether this entity is upside down. |
| Public property | [IsVisible](P_Rage_Entity_IsVisible.htm) | Gets or sets a value indicating whether this instance is currently visible within the game world.  Invisible instances will still be processed but will not be rendered. |
| Public property | [LeftPosition](P_Rage_Entity_LeftPosition.htm) | Gets a position directly to the left of this [Entity](T_Rage_Entity.htm). |
| Public property | [Length](P_Rage_Entity_Length.htm) | Gets the length of this [Entity](T_Rage_Entity.htm). |
| Public property | [MaxHealth](P_Rage_Entity_MaxHealth.htm) | Gets or sets the maximum health of this instance. |
| Public property | [MemoryAddress](P_Rage_Entity_MemoryAddress.htm) | Gets the memory address of this instance. |
| Public propertyCode example | [Metadata](P_Rage_Entity_Metadata.htm) | Gets the [metadata](https://en.wikipedia.org/wiki/Metadata) associated with this instance.  The value of this property can be used to store data about this instance.  Getting or setting metadata is done using the same syntax as getting or setting a property.  Internally the value is added to a dictionary with the specified property name as key. |
| Public property | [Model](P_Rage_Entity_Model.htm) | Gets or sets the [Model](P_Rage_IRenderable_Model.htm) of this instance. |
| Public property | [NeedsCollision](P_Rage_Entity_NeedsCollision.htm) | Gets a value indicating whether this instance needs collision.  Entities not marked explicitly to need collision will still get collision, however, if other entities need collision, entities not marked as needing collision may lose it in favor of those. |
| Public property | [Opacity](P_Rage_Entity_Opacity.htm) | Gets or sets the opacity of this instance. |
| Public property | [Orientation](P_Rage_Entity_Orientation.htm) | Gets or sets the orientation of this instance. |
| Public property | [Position](P_Rage_Entity_Position.htm) | Gets or sets the position of this instance. |
| Public property | [Quaternion](P_Rage_Entity_Quaternion.htm) | **Obsolete.**  Gets or sets the quaternion of this instance. |
| Public property | [RearPosition](P_Rage_Entity_RearPosition.htm) | Gets a position directly behind this [Entity](T_Rage_Entity.htm). |
| Public property | [RightPosition](P_Rage_Entity_RightPosition.htm) | Gets a position directly to the right of this [Entity](T_Rage_Entity.htm). |
| Public property | [RightVector](P_Rage_Entity_RightVector.htm) | Gets the right vector of this instance. |
| Public property | [Rotation](P_Rage_Entity_Rotation.htm) | Gets or sets the rotation of this instance. |
| Public property | [Speed](P_Rage_Entity_Speed.htm) | Gets the speed of this [Entity](T_Rage_Entity.htm) in meters per second.  This is equivalent of [Velocity](P_Rage_Entity_Velocity.htm).Length(). |
| Public property | [SubmersionLevel](P_Rage_Entity_SubmersionLevel.htm) | Gets a value indicating how submersed this entity is. |
| Public property | [UpVector](P_Rage_Entity_UpVector.htm) | Gets the up vector of this instance. |
| Public property | [Velocity](P_Rage_Entity_Velocity.htm) | Gets or sets the velocity of this entity. |
| Public property | [Width](P_Rage_Entity_Width.htm) | Gets the width of this [Entity](T_Rage_Entity.htm). |

[Top](#mainBody)

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.