# Ped Class

﻿Ped Class

|  |  |  |
| --- | --- | --- |
| Ped Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents a character in the game world.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [RageEntity](T_Rage_Entity.htm)  
    RagePed  
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
public class Ped : Entity
```

```
<SerializableAttribute>
Public Class Ped
	Inherits Entity
```

```
[SerializableAttribute]
public ref class Ped : public Entity
```

The Ped type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [Ped](M_Rage_Ped__ctor.htm) | Initializes a new instance of the Ped class. |
| Public method | [Ped(PredicateModel)](M_Rage_Ped__ctor_5.htm) | Initializes a new instance of the Ped class. |
| Protected method | [Ped(PoolHandle)](M_Rage_Ped__ctor_2.htm) | Initializes a new instance of the Ped class. |
| Public method | [Ped(Vector3)](M_Rage_Ped__ctor_3.htm) | Initializes a new instance of the Ped class. |
| Public method | [Ped(PredicateModel, Vector3)](M_Rage_Ped__ctor_6.htm) | Initializes a new instance of the Ped class. |
| Public method | [Ped(Vector3, Single)](M_Rage_Ped__ctor_4.htm) | Initializes a new instance of the Ped class. |
| Public method | [Ped(Model, Vector3, Single)](M_Rage_Ped__ctor_1.htm) | Initializes a new instance of the Ped class. |
| Public method | [Ped(PredicateModel, Vector3, Single)](M_Rage_Ped__ctor_7.htm) | Initializes a new instance of the Ped class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AbovePosition](P_Rage_Entity_AbovePosition.htm) | Gets a position directly above this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Accuracy](P_Rage_Ped_Accuracy.htm) | Gets or sets a value indicating how well this instance aims. |
| Public property | [Alertness](P_Rage_Ped_Alertness.htm) |  |
| Public property | [AngularVelocity](P_Rage_Entity_AngularVelocity.htm) | Gets or sets the rotational velocity of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Armor](P_Rage_Ped_Armor.htm) |  |
| Public property | [BelowPosition](P_Rage_Entity_BelowPosition.htm) | Gets a position directly below this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [BlockPermanentEvents](P_Rage_Ped_BlockPermanentEvents.htm) | Sets whether permanent events are blocked for this Ped.  If permanent events are blocked, this Ped will only do as it's told, and won't flee when shot at, etc. |
| Public property | [CanAttackFriendlies](P_Rage_Ped_CanAttackFriendlies.htm) | Sets a value indicating whether this Ped can attack other Peds considered friendly to this Ped. Eg. Peds in the same relationship group, or that this Ped's relationship group respects. |
| Public property | [CanBeDamaged](P_Rage_Entity_CanBeDamaged.htm) | Gets or sets a value indicating whether this entity can be damaged. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [CanBeKnockedOffBikes](P_Rage_Ped_CanBeKnockedOffBikes.htm) |  |
| Public property | [CanBePulledOutOfVehicles](P_Rage_Ped_CanBePulledOutOfVehicles.htm) |  |
| Public property | [CanBeShotInVehicles](P_Rage_Ped_CanBeShotInVehicles.htm) | Sets a value indicating whether this Ped is able to take damage from gun fire while in a vehicle. |
| Public property | [CanBeTargetted](P_Rage_Ped_CanBeTargetted.htm) | Sets a value indicating whether this Ped can be targetted by players. |
| Public property | [CanDrownInVehicles](P_Rage_Ped_CanDrownInVehicles.htm) | Sets a value indicating whether this Ped is able to drown while in a vehicle. The value of this property has no influence on [CanDrownOutsideVehicles](P_Rage_Ped_CanDrownOutsideVehicles.htm). |
| Public property | [CanDrownOutsideVehicles](P_Rage_Ped_CanDrownOutsideVehicles.htm) | Sets a value indicating whether this Ped is able to drown while in water, outside a vehicle. The value of this property has no influence on [CanDrownInVehicles](P_Rage_Ped_CanDrownInVehicles.htm). |
| Public property | [CanFlyThroughWindshields](P_Rage_Ped_CanFlyThroughWindshields.htm) |  |
| Public property | [CanOnlyBeDamagedByPlayer](P_Rage_Ped_CanOnlyBeDamagedByPlayer.htm) | Gets a value indicating whether this instance can only be damaged by a player. |
| Public property | [CanPlayAmbientAnimations](P_Rage_Ped_CanPlayAmbientAnimations.htm) |  |
| Public property | [CanPlayGestureAnimations](P_Rage_Ped_CanPlayGestureAnimations.htm) |  |
| Public property | [CanPlayVisemeAnimations](P_Rage_Ped_CanPlayVisemeAnimations.htm) |  |
| Public property | [CanRagdoll](P_Rage_Ped_CanRagdoll.htm) | Gets or sets a value indicating whether this Ped can ragdoll. |
| Public property | [CollisionIgnoredEntity](P_Rage_Entity_CollisionIgnoredEntity.htm) | Gets or sets the [Entity](T_Rage_Entity.htm) this entity currently ignores collisions from. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [CombatTarget](P_Rage_Ped_CombatTarget.htm) | Gets the Ped this Ped is combatting. |
| Public property | [CreatedByTheCallingPlugin](P_Rage_Entity_CreatedByTheCallingPlugin.htm) | Gets a value indicating whether this instance was created by the calling plugin. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [CurrentVehicle](P_Rage_Ped_CurrentVehicle.htm) | Gets the [Vehicle](T_Rage_Vehicle.htm) this ped is currently in, or null if this ped is currently not in any [Vehicle](T_Rage_Vehicle.htm). |
| Public property | [DecisionMaker](P_Rage_Ped_DecisionMaker.htm) |  |
| Public property | [DiesInstantlyInWater](P_Rage_Ped_DiesInstantlyInWater.htm) |  |
| Public property | [Direction](P_Rage_Entity_Direction.htm) | Gets or sets the direction of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [DropsCurrentWeaponOnDeath](P_Rage_Ped_DropsCurrentWeaponOnDeath.htm) |  |
| Public property | [FatalInjuryHealthThreshold](P_Rage_Ped_FatalInjuryHealthThreshold.htm) | Gets or sets the fatal injury health threshold for this ped. A ped is considered dead when its health drops below this value. |
| Public property | [FiringPattern](P_Rage_Ped_FiringPattern.htm) | Sets the firing pattern used by this Ped in fire fights. |
| Public property | [ForwardVector](P_Rage_Entity_ForwardVector.htm) | Gets the forward vector of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [FrontPosition](P_Rage_Entity_FrontPosition.htm) | Gets a position directly in front of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Group](P_Rage_Ped_Group.htm) | Gets the group this Ped is currently in. |
| Public property | [Handle](P_Rage_Entity_Handle.htm) | Gets the handle of this instance. Used to identify the instance within its pool. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HasBeenDamagedByAnyObject](P_Rage_Entity_HasBeenDamagedByAnyObject.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Object](T_Rage_Object.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HasBeenDamagedByAnyPed](P_Rage_Entity_HasBeenDamagedByAnyPed.htm) | Gets or sets a value indicating whether this entity has been damaged by any Ped. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HasBeenDamagedByAnyVehicle](P_Rage_Entity_HasBeenDamagedByAnyVehicle.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Vehicle](T_Rage_Vehicle.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Heading](P_Rage_Entity_Heading.htm) | Gets or sets the heading of this instance in degrees. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Health](P_Rage_Entity_Health.htm) | Gets or sets the health of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HearingRange](P_Rage_Ped_HearingRange.htm) |  |
| Public property | [Height](P_Rage_Entity_Height.htm) | Gets the height of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HeightAboveGround](P_Rage_Entity_HeightAboveGround.htm) | Gets this entity's distance from the ground in 1D on the Z-axis.  The distance is measured from the entity's origin to the surface below the entity (Surfaces include roofs of buildings). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [InjuryHealthThreshold](P_Rage_Ped_InjuryHealthThreshold.htm) | Gets or sets the injury health threshold for this ped. A ped is considered injured when its health drops below this value. |
| Public property | [Inventory](P_Rage_Ped_Inventory.htm) |  |
| Public property | [Invincible](P_Rage_Entity_Invincible.htm) | **Obsolete.**  Sets a value indicating whether this instance is invincible. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsAiming](P_Rage_Ped_IsAiming.htm) | Gets a value indicating whether this Ped is aiming. |
| Public property | [IsAimingFromCover](P_Rage_Ped_IsAimingFromCover.htm) | Gets a value indicating whether this Ped is aiming from cover. |
| Public property | [IsAlive](P_Rage_Entity_IsAlive.htm) | Gets a value indicating whether this instance is alive. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsAnySpeechPlaying](P_Rage_Ped_IsAnySpeechPlaying.htm) |  |
| Public property | [IsArmIkEnabled](P_Rage_Ped_IsArmIkEnabled.htm) |  |
| Public property | [IsBailingOutOfVehicle](P_Rage_Ped_IsBailingOutOfVehicle.htm) | Gets a value indicating whether this Ped is bailing out of a vehicle. |
| Public property | [IsBeingJacked](P_Rage_Ped_IsBeingJacked.htm) | Gets a value indicating whether this Ped is currently being pulled or otherwise being moved out of a vehicle by another Ped. |
| Public property | [IsBeingStealthKilled](P_Rage_Ped_IsBeingStealthKilled.htm) | Gets a value indicating whether this Ped is currently being stealth killed. |
| Public property | [IsBulletProof](P_Rage_Entity_IsBulletProof.htm) | Gets or sets a value indicating whether this entity can take damage from bullets. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsClimbing](P_Rage_Ped_IsClimbing.htm) | Gets a value indicating whether this Ped is currently climbing.  A Ped is considered climbing if performing one of the following actions.   * Climbing up. * Vaulting. * Stepping up. * Stepping over. * Climbing a ladder. |
| Public property | [IsCollisionEnabled](P_Rage_Entity_IsCollisionEnabled.htm) | Gets or sets a value indicating whether collision is enabled for this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsCollisionProof](P_Rage_Entity_IsCollisionProof.htm) | Gets or sets a value indicating whether this entity can take damage from collisions. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsCuffed](P_Rage_Ped_IsCuffed.htm) |  |
| Public property | [IsCurrentWeaponSilenced](P_Rage_Ped_IsCurrentWeaponSilenced.htm) |  |
| Public property | [IsDead](P_Rage_Entity_IsDead.htm) | Gets a value indicating whether this instance is dead. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsDiving](P_Rage_Ped_IsDiving.htm) | Gets a value indicating whether this Ped is currently diving. |
| Public property | [IsDoingDriveby](P_Rage_Ped_IsDoingDriveby.htm) | Gets a value indicating whether this Ped is aiming from a vehicle. |
| Public property | [IsExplosionProof](P_Rage_Entity_IsExplosionProof.htm) | Gets or sets a value indicating whether this entity can take damage from explosions. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsFalling](P_Rage_Ped_IsFalling.htm) | Gets a value indicating whether this Ped is currently falling. |
| Public property | [IsFatallyInjured](P_Rage_Ped_IsFatallyInjured.htm) | **Obsolete.**  Gets a value indicating whether this ped's health is below its fatally injured threshold. |
| Public property | [IsFemale](P_Rage_Ped_IsFemale.htm) | Gets a value indicating whether this Ped is a female. |
| Public property | [IsFireProof](P_Rage_Entity_IsFireProof.htm) | Gets or sets a value indicating whether this entity can take damage from fire. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsFleeing](P_Rage_Ped_IsFleeing.htm) | Gets a value indicating whether this Ped is currently fleeing. |
| Public property | [IsGettingIntoVehicle](P_Rage_Ped_IsGettingIntoVehicle.htm) | Gets a value indicating whether this instance is getting into a vehicle. |
| Public property | [IsGettingUp](P_Rage_Ped_IsGettingUp.htm) | Gets a value indicating whether this Ped is getting up. |
| Public property | [IsGoingIntoCover](P_Rage_Ped_IsGoingIntoCover.htm) | Gets a value indicating whether this Ped is currently going into cover. |
| Public property | [IsGravityDisabled](P_Rage_Entity_IsGravityDisabled.htm) | Gets or sets a value indicating whether gravity is disabled for this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsHangingOnToVehicle](P_Rage_Ped_IsHangingOnToVehicle.htm) |  |
| Public property | [IsHeadIkEnabled](P_Rage_Ped_IsHeadIkEnabled.htm) |  |
| Public property | [IsHuman](P_Rage_Ped_IsHuman.htm) | Gets a value indicating whether this Ped is a human. |
| Public property | [IsInAir](P_Rage_Entity_IsInAir.htm) | (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsInAirVehicle](P_Rage_Ped_IsInAirVehicle.htm) | Gets a value indicating whether this Ped is in an air vehicle. |
| Public property | [IsInAnyPoliceVehicle](P_Rage_Ped_IsInAnyPoliceVehicle.htm) | Gets a value indicating whether this Ped is in a police vehicle. |
| Public property | [IsInBoat](P_Rage_Ped_IsInBoat.htm) | Gets a value indicating whether this Ped is in a boat. |
| Public property | [IsInCombat](P_Rage_Ped_IsInCombat.htm) | Gets a value indicating whether this Ped is in combat. The Ped must be AI-controlled. |
| Public property | [IsInCover](P_Rage_Ped_IsInCover.htm) | Gets a value indicating whether this Ped is currently in cover.  A Ped is considered in cover if it has fully entered the cover state. It is not in cover while moving into cover. |
| Public property | [IsInCoverFacingLeft](P_Rage_Ped_IsInCoverFacingLeft.htm) | Gets a value indicating whether this Ped is currently in cover and facing left.  A Ped is considered in cover if it has fully entered the cover state. It is not in cover while moving into cover. |
| Public property | [IsInCoverFacingRight](P_Rage_Ped_IsInCoverFacingRight.htm) | Gets a value indicating whether this Ped is currently in cover and facing right.  A Ped is considered in cover if it has fully entered the cover state. It is not in cover while moving into cover. |
| Public property | [IsInHelicopter](P_Rage_Ped_IsInHelicopter.htm) | Gets a value indicating whether this Ped is in a helicopter. |
| Public property | [IsInjured](P_Rage_Ped_IsInjured.htm) | Gets a value indicating whether this ped's health is below its injured threshold. |
| Public property | [IsInMeleeCombat](P_Rage_Ped_IsInMeleeCombat.htm) | Gets a value indicating whether this Ped is in melee combat. The Ped must be AI-controlled. |
| Public property | [IsInParachuteFreeFall](P_Rage_Ped_IsInParachuteFreeFall.htm) | Gets a value indicating whether this Ped is in a parachute free fall. |
| Public property | [IsInPlane](P_Rage_Ped_IsInPlane.htm) | Gets a value indicating whether this Ped is in a plane. |
| Public property | [IsInSeaVehicle](P_Rage_Ped_IsInSeaVehicle.htm) | Gets a value indicating whether this Ped is in a vehicle operating on or under water. |
| Public property | [IsInStealthMode](P_Rage_Ped_IsInStealthMode.htm) |  |
| Public property | [IsInSubmersible](P_Rage_Ped_IsInSubmersible.htm) | Gets a value indicating whether this Ped is in a submersible. |
| Public property | [IsInTaxi](P_Rage_Ped_IsInTaxi.htm) | Gets a value indicating whether this Ped is in a taxi, passenger or otherwise. |
| Public property | [IsInvincible](P_Rage_Entity_IsInvincible.htm) | Sets a value indicating whether this instance is invincible. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsInWater](P_Rage_Entity_IsInWater.htm) | Gets a value indicating whether this entity is currently in water.  Returns true the moment any part of the entity is touching water. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsInWrithe](P_Rage_Ped_IsInWrithe.htm) |  |
| Public property | [IsJacking](P_Rage_Ped_IsJacking.htm) | Gets a value indicating whether this Ped is currently pulling or otherwise moving another Ped out of a vehicle. |
| Public property | [IsJumping](P_Rage_Ped_IsJumping.htm) | Gets a value indicating whether this Ped is currently jumping. |
| Public property | [IsLegIkEnabled](P_Rage_Ped_IsLegIkEnabled.htm) |  |
| Public property | [IsLocalPlayer](P_Rage_Ped_IsLocalPlayer.htm) | Gets a value indicating whether this instance is the local player's current Ped. |
| Public property | [IsMale](P_Rage_Ped_IsMale.htm) | Gets a value indicating whether this Ped is a male. |
| Public property | [IsMeleeProof](P_Rage_Entity_IsMeleeProof.htm) | Gets or sets a value indicating whether this entity can take damage from melee attacks. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsOnBike](P_Rage_Ped_IsOnBike.htm) | Gets a value indicating whether this Ped is on a bike. |
| Public property | [IsOnFire](P_Rage_Entity_IsOnFire.htm) | Gets or sets a value indicating whether this [Entity](T_Rage_Entity.htm) is on fire. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsOnFoot](P_Rage_Ped_IsOnFoot.htm) | Gets a value indicating whether this Ped is on foot. |
| Public property | [IsOnScreen](P_Rage_Entity_IsOnScreen.htm) | Gets a value indicating whether this instance is on the screen. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsPainAudioEnabled](P_Rage_Ped_IsPainAudioEnabled.htm) | Sets a value indicating whether pain audio is enabled for this instance. |
| Public property | [IsPassenger](P_Rage_Ped_IsPassenger.htm) | Gets a value indicating whether this Ped is currently on a non-driver seat in a vehicle. |
| Public property | [IsPerformingStealthKill](P_Rage_Ped_IsPerformingStealthKill.htm) | Gets a value indicating whether this Ped is currently performing a stealth kill. |
| Public property | [IsPersistent](P_Rage_Entity_IsPersistent.htm) | Gets or sets a value indicating whether this instance is persistent within the game world. Persistent instances will not be removed automatically during clean ups. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsPlantingBomb](P_Rage_Ped_IsPlantingBomb.htm) | Gets a value indicating whether this Ped is currently planting a bomb. |
| Public property | [IsPlayer](P_Rage_Ped_IsPlayer.htm) | Gets a value indicating whether this instance is the any player's current Ped. |
| Public property | [IsPositionFrozen](P_Rage_Entity_IsPositionFrozen.htm) | Sets a value indicating whether the position of this entity is frozen. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsRagdoll](P_Rage_Ped_IsRagdoll.htm) | Gets or sets a value indicating whether this Ped is currently ragdolled. |
| Public property | [IsRecordingCollisions](P_Rage_Entity_IsRecordingCollisions.htm) | Gets or sets a value indicating whether this entity is recording collisions. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsReloading](P_Rage_Ped_IsReloading.htm) | Gets a value indicating whether this Ped is reloading. |
| Public property | [IsRendered](P_Rage_Entity_IsRendered.htm) | Gets a value indicating whether this instance is currently being rendered. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsRingtonePlaying](P_Rage_Ped_IsRingtonePlaying.htm) |  |
| Public property | [IsRunning](P_Rage_Ped_IsRunning.htm) | Gets a value indicating whether this Ped is running. |
| Public property | [IsShooting](P_Rage_Ped_IsShooting.htm) | Gets a value indicating whether this instance is currently firing a weapon. |
| Public property | [IsSprinting](P_Rage_Ped_IsSprinting.htm) | Gets a value indicating whether this Ped is sprinting. |
| Public property | [IsStill](P_Rage_Ped_IsStill.htm) | Gets a value indicating whether this Ped is not moving. |
| Public property | [IsStopped](P_Rage_Ped_IsStopped.htm) | Gets a value indicating whether this instance is currently standing still. |
| Public property | [IsStunned](P_Rage_Ped_IsStunned.htm) |  |
| Public property | [IsSwimming](P_Rage_Ped_IsSwimming.htm) | Gets a value indicating whether this Ped is currently swimming. |
| Public property | [IsTorsoIkEnabled](P_Rage_Ped_IsTorsoIkEnabled.htm) |  |
| Public property | [IsUpsideDown](P_Rage_Entity_IsUpsideDown.htm) | Gets or sets a value indicating whether this entity is upside down. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsVaulting](P_Rage_Ped_IsVaulting.htm) | Gets a value indicating whether this Ped is vaulting over an obstacle. |
| Public property | [IsVisible](P_Rage_Entity_IsVisible.htm) | Gets or sets a value indicating whether this instance is currently visible within the game world.  Invisible instances will still be processed but will not be rendered. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsWalking](P_Rage_Ped_IsWalking.htm) | Gets a value indicating whether this Ped is walking. |
| Public property | [IsWeaponReadyToShoot](P_Rage_Ped_IsWeaponReadyToShoot.htm) |  |
| Public property | [IsWearingHelmet](P_Rage_Ped_IsWearingHelmet.htm) | Gets a value indicating whether this Ped is currently wearing a helmet. |
| Public property | [Jacker](P_Rage_Ped_Jacker.htm) | Gets the Ped currently jacking this Ped. |
| Public property | [JackingTarget](P_Rage_Ped_JackingTarget.htm) | Gets the Ped currently being jacked by this Ped. |
| Public property | [KeepTasks](P_Rage_Ped_KeepTasks.htm) | Sets whether this Ped will keep tasks assigned. |
| Public property | [LastDamageBone](P_Rage_Ped_LastDamageBone.htm) |  |
| Public property | [LastEuphoriaMessageName](P_Rage_Ped_LastEuphoriaMessageName.htm) | Gets the name of the Euphoria message that was last dispatched to this Ped. |
| Public property | [LastVehicle](P_Rage_Ped_LastVehicle.htm) | Gets the last [Vehicle](T_Rage_Vehicle.htm) this ped was in. |
| Public property | [LeftPosition](P_Rage_Entity_LeftPosition.htm) | Gets a position directly to the left of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Length](P_Rage_Entity_Length.htm) | Gets the length of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [MaxHealth](P_Rage_Entity_MaxHealth.htm) | Gets or sets the maximum health of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [MeleeTarget](P_Rage_Ped_MeleeTarget.htm) | Gets the Ped this Ped is performing a melee attack against. |
| Public property | [MemoryAddress](P_Rage_Entity_MemoryAddress.htm) | Gets the memory address of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public propertyCode example | [Metadata](P_Rage_Entity_Metadata.htm) | Gets the [metadata](https://en.wikipedia.org/wiki/Metadata) associated with this instance.  The value of this property can be used to store data about this instance.  Getting or setting metadata is done using the same syntax as getting or setting a property.  Internally the value is added to a dictionary with the specified property name as key. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [MinimumGroundTimeForStungun](P_Rage_Ped_MinimumGroundTimeForStungun.htm) |  |
| Public property | [Model](P_Rage_Entity_Model.htm) | Gets or sets the [Model](P_Rage_IRenderable_Model.htm) of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Money](P_Rage_Ped_Money.htm) |  |
| Public property | [MovementAnimationSet](P_Rage_Ped_MovementAnimationSet.htm) | Gets or sets the [AnimationSet](T_Rage_AnimationSet.htm) used by this Ped for movement. |
| Public property | [NeedsCollision](P_Rage_Entity_NeedsCollision.htm) | Gets a value indicating whether this instance needs collision.  Entities not marked explicitly to need collision will still get collision, however, if other entities need collision, entities not marked as needing collision may lose it in favor of those. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Opacity](P_Rage_Entity_Opacity.htm) | Gets or sets the opacity of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Orientation](P_Rage_Entity_Orientation.htm) | Gets or sets the orientation of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [ParachuteLandingType](P_Rage_Ped_ParachuteLandingType.htm) | Gets the parachute landing type of this Ped. |
| Public property | [ParachuteState](P_Rage_Ped_ParachuteState.htm) | Gets the parachute state of this Ped. |
| Public property | [Position](P_Rage_Entity_Position.htm) | Gets or sets the position of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Quaternion](P_Rage_Entity_Quaternion.htm) | **Obsolete.**  Gets or sets the quaternion of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [RearPosition](P_Rage_Entity_RearPosition.htm) | Gets a position directly behind this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [RelationshipGroup](P_Rage_Ped_RelationshipGroup.htm) | Gets or sets the relationship group of this instance.  Relationship groups indicate the acquaintance between different types of Peds.  For instance, by default CIVMALE and CIVFEMALE are set to respect each other; however, this behaviour can be changed.  CIVMALE could be set to hate CIVFEMALE, and CIVFEMALE could be set to hate CIVMALE, and all civilians would start fighting each other on side, males vs females. (Granted that they're in those respective groups, as males could certainly be added to the CIVFEMALE group.  Groups can also have different acquaintances between each other. For instance, imagine three new groups: DEVELOPER, CUSTOMER and PIRATE, where Peds in the DEVELOPER relationship group hate Peds in the PIRATE group and like (not respect) Peds in the CUSTOMER group. Peds in the PIRATE group like the Peds in the DEVELOPER group, and are neutral towards people in the CUSTOMER group. Peds in the CUSTOMER group like Peds in the DEVELOPER group and dislike Peds in the PIRATE group.  Any Ped in the DEVELOPER group will attack Peds in the PIRATE group on sight, but Peds in the PIRATE group won't attack Peds in the DEVELOPER group because they like them. |
| Public property | [RightPosition](P_Rage_Entity_RightPosition.htm) | Gets a position directly to the right of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [RightVector](P_Rage_Entity_RightVector.htm) | Gets the right vector of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Rotation](P_Rage_Entity_Rotation.htm) | Gets or sets the rotation of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [SeatIndex](P_Rage_Ped_SeatIndex.htm) | Gets the index of the seat this Ped is currently on. |
| Public property | [SeatIndexTryingToEnter](P_Rage_Ped_SeatIndexTryingToEnter.htm) | Gets the index of the seat this Ped is currently trying to enter. |
| Public property | [Speed](P_Rage_Entity_Speed.htm) | Gets the speed of this [Entity](T_Rage_Entity.htm) in meters per second.  This is equivalent of [Velocity](P_Rage_Entity_Velocity.htm).Length(). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [StaysInGroups](P_Rage_Ped_StaysInGroups.htm) | Sets a value indicating whether this Ped will stay in its group unless explicitly removed.  If the value of this property is false, this Ped will be removed from its group if it gets farther away from its leader than the [Group](T_Rage_Group.htm)'s [!:Rage::Group::DissolveDistance]. |
| Public property | [StaysInVehiclesWhenJacked](P_Rage_Ped_StaysInVehiclesWhenJacked.htm) |  |
| Public property | [SubmersionLevel](P_Rage_Entity_SubmersionLevel.htm) | Gets a value indicating how submersed this entity is. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Tasks](P_Rage_Ped_Tasks.htm) | Gets an instance of [TaskInvoker](T_Rage_TaskInvoker.htm) for this Ped that can be used to invoke tasks on this Ped. |
| Public property | [UpVector](P_Rage_Entity_UpVector.htm) | Gets the up vector of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [VehicleTryingToEnter](P_Rage_Ped_VehicleTryingToEnter.htm) | Gets the [Vehicle](T_Rage_Vehicle.htm) this Ped is currently trying to enter. |
| Public property | [Velocity](P_Rage_Entity_Velocity.htm) | Gets or sets the velocity of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [VisionRange](P_Rage_Ped_VisionRange.htm) |  |
| Public property | [VisualFieldMaximumHorizontalAngle](P_Rage_Ped_VisualFieldMaximumHorizontalAngle.htm) |  |
| Public property | [VisualFieldMaximumVerticalAngle](P_Rage_Ped_VisualFieldMaximumVerticalAngle.htm) |  |
| Public property | [VisualFieldMinimumHorizontalAngle](P_Rage_Ped_VisualFieldMinimumHorizontalAngle.htm) |  |
| Public property | [VisualFieldMinimumVerticalAngle](P_Rage_Ped_VisualFieldMinimumVerticalAngle.htm) |  |
| Public property | [Voice](P_Rage_Ped_Voice.htm) | Sets the voice of this Ped. |
| Public property | [Width](P_Rage_Entity_Width.htm) | Gets the width of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [WillGetOutOfUpsideDownVehiclesAutomatically](P_Rage_Ped_WillGetOutOfUpsideDownVehiclesAutomatically.htm) |  |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [ApplyForce](M_Rage_Entity_ApplyForce.htm) | Applies force to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [AttachBlip](M_Rage_Entity_AttachBlip.htm) | Creates a new [Blip](T_Rage_Blip.htm) and attaches it to this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [AttachTo](M_Rage_Entity_AttachTo.htm) | Attaches [Entity](T_Rage_Entity.htm) to another [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [ClearBlood](M_Rage_Ped_ClearBlood.htm) | Removes all blood decals from this Ped. |
| Public method | [ClearLastDamageBone](M_Rage_Ped_ClearLastDamageBone.htm) |  |
| Public method | [ClearLastVehicle](M_Rage_Ped_ClearLastVehicle.htm) |  |
| Public method | [ClearWetness](M_Rage_Ped_ClearWetness.htm) | Clears the wetness of this Ped. |
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
| Public method | [GetDrawableVariationCount](M_Rage_Ped_GetDrawableVariationCount.htm) | Gets the number of drawable variations for the specified component of this Ped. |
| Public method | [GetLastCollision(Vector3)](M_Rage_Entity_GetLastCollision.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetLastCollision(Vector3, Vector3)](M_Rage_Entity_GetLastCollision_1.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetLastCollision(Vector3, Vector3, String)](M_Rage_Entity_GetLastCollision_2.htm) | Gets the last collision of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetNearbyPeds](M_Rage_Ped_GetNearbyPeds.htm) | Gets Peds near this Ped. |
| Public method | [GetNearbyVehicles](M_Rage_Ped_GetNearbyVehicles.htm) | Gets [Vehicle](T_Rage_Vehicle.htm)s near this Ped. |
| Public methodCode example | [GetOffsetPosition](M_Rage_Entity_GetOffsetPosition.htm) | Gets a position offset relative to this instance, based on the instance's position and direction. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionFront](M_Rage_Entity_GetOffsetPositionFront.htm) | Gets a position that is the specified offset towards the entity's front. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionRight](M_Rage_Entity_GetOffsetPositionRight.htm) | Gets a position that is the specified offset towards the entity's right. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetOffsetPositionUp](M_Rage_Entity_GetOffsetPositionUp.htm) | Gets a position that is the specified offset towards the entity's top. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetPositionOffset](M_Rage_Entity_GetPositionOffset.htm) | Gets the offset to the specified world position, relative to this [Entity](T_Rage_Entity.htm).  This is essentially the opposite of [GetOffsetPosition(Vector3)](M_Rage_Entity_GetOffsetPosition.htm) (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [GetTextureVariationCount](M_Rage_Ped_GetTextureVariationCount.htm) | Gets the number of drawable variations for the specified component of this Ped. |
| Public method | [GetVariation](M_Rage_Ped_GetVariation.htm) | Gets the variation of this Ped. |
| Public method | [GiveHelmet](M_Rage_Ped_GiveHelmet.htm) | Gives this Ped a new helmet of the specified type. |
| Public method | [HasBeenDamagedBy](M_Rage_Entity_HasBeenDamagedBy.htm) | Determines whether this entity has been damaged by the specified entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [HasBone(Int32)](M_Rage_Entity_HasBone.htm) | Determines whether this [Entity](T_Rage_Entity.htm) has the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [HasBone(String)](M_Rage_Entity_HasBone_1.htm) | Determines whether this [Entity](T_Rage_Entity.htm) has the specified bone. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [IsBoneValid](M_Rage_Ped_IsBoneValid.htm) |  |
| Public method | [IsInAnyVehicle](M_Rage_Ped_IsInAnyVehicle.htm) | Gets whether this Ped is in any [Vehicle](T_Rage_Vehicle.htm). |
| Public method | [IsInVehicle](M_Rage_Ped_IsInVehicle.htm) | Gets whether this Ped is in the specified [Vehicle](T_Rage_Vehicle.htm). |
| Public method | [IsStandingOnVehicle](M_Rage_Ped_IsStandingOnVehicle.htm) | Determines whether this Ped is standing on a vehicle. |
| Public method | [IsStandingOnVehicle(Vehicle)](M_Rage_Ped_IsStandingOnVehicle_1.htm) | Determines whether this Ped is standing on the specified vehicle. |
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
| Public method | [RemoveHelmet](M_Rage_Ped_RemoveHelmet.htm) | Removes this Ped's current helmet. |
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
| Public method | [SetTargetableByPlayer](M_Rage_Ped_SetTargetableByPlayer.htm) | Sets whether this Ped can be targetted. |
| Public method | [SetVariation](M_Rage_Ped_SetVariation.htm) | Sets the variation of this Ped. |
| Public method | [SetWetnessHeight](M_Rage_Ped_SetWetnessHeight.htm) | Sets the height of the wetness of this Ped. |
| Public method | [TravelDistanceTo(ISpatial)](M_Rage_Entity_TravelDistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance, if using the road system. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [TravelDistanceTo(Vector3)](M_Rage_Entity_TravelDistanceTo_1.htm) | Gets the distance from this instance to the specified position, if using the road system. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public method | [WarpIntoVehicle](M_Rage_Ped_WarpIntoVehicle.htm) | Warps this Ped into the specified [Vehicle](T_Rage_Vehicle.htm). |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.