# TaskInvoker Class

﻿TaskInvoker Class

|  |  |  |
| --- | --- | --- |
| TaskInvoker Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.TaskInvoker"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageTaskInvoker  
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
public sealed class TaskInvoker
```

```
<SerializableAttribute>
Public NotInheritable Class TaskInvoker
```

```
[SerializableAttribute]
public ref class TaskInvoker sealed
```

The TaskInvoker type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [CurrentTaskStatus](P_Rage_TaskInvoker_CurrentTaskStatus.htm) | Gets the status of the current task. If no task is running, returns [NoTask](T_Rage_TaskStatus.htm). |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [AchieveHeading(Single)](M_Rage_TaskInvoker_AchieveHeading.htm) |  |
| Public method | [AchieveHeading(Single, Int32)](M_Rage_TaskInvoker_AchieveHeading_1.htm) |  |
| Public method | [AimWeaponAt(Entity, Int32)](M_Rage_TaskInvoker_AimWeaponAt.htm) |  |
| Public method | [AimWeaponAt(Vector3, Int32)](M_Rage_TaskInvoker_AimWeaponAt_1.htm) |  |
| Public method | [ChaseWithGroundVehicle](M_Rage_TaskInvoker_ChaseWithGroundVehicle.htm) |  |
| Public method | [ChaseWithHelicopter](M_Rage_TaskInvoker_ChaseWithHelicopter.htm) |  |
| Public method | [ChaseWithPlane](M_Rage_TaskInvoker_ChaseWithPlane.htm) |  |
| Public method | [Clear](M_Rage_TaskInvoker_Clear.htm) | Clears the [Ped](T_Rage_Ped.htm)'s tasks. |
| Public method | [ClearImmediately](M_Rage_TaskInvoker_ClearImmediately.htm) | Clears the [Ped](T_Rage_Ped.htm)'s tasks immediately. |
| Public method | [ClearSecondary](M_Rage_TaskInvoker_ClearSecondary.htm) | Clears only the [Ped](T_Rage_Ped.htm)'s secondary task. |
| Public method | [Climb](M_Rage_TaskInvoker_Climb.htm) |  |
| Public method | [ClimbLadder](M_Rage_TaskInvoker_ClimbLadder.htm) |  |
| Public method | [Cower](M_Rage_TaskInvoker_Cower.htm) |  |
| Public method | [CruiseWithVehicle(Single)](M_Rage_TaskInvoker_CruiseWithVehicle_1.htm) | Makes the [Ped](T_Rage_Ped.htm) cruise with its current vehicle, using flag [F:<unknown type>.Normal]. |
| Public method | [CruiseWithVehicle(Single, VehicleDrivingFlags)](M_Rage_TaskInvoker_CruiseWithVehicle_2.htm) |  |
| Public method | [CruiseWithVehicle(Vehicle, Single, VehicleDrivingFlags)](M_Rage_TaskInvoker_CruiseWithVehicle.htm) |  |
| Public method | [DriveToPosition(Vector3, Single, VehicleDrivingFlags)](M_Rage_TaskInvoker_DriveToPosition.htm) |  |
| Public method | [DriveToPosition(Vector3, Single, VehicleDrivingFlags, Single)](M_Rage_TaskInvoker_DriveToPosition_1.htm) |  |
| Public method | [DriveToPosition(Vehicle, Vector3, Single, VehicleDrivingFlags, Single)](M_Rage_TaskInvoker_DriveToPosition_2.htm) |  |
| Public method | [EnterVehicle(Vehicle, Int32)](M_Rage_TaskInvoker_EnterVehicle.htm) | Makes the [Ped](T_Rage_Ped.htm) enter the specified [Vehicle](T_Rage_Vehicle.htm). |
| Public method | [EnterVehicle(Vehicle, Int32, EnterVehicleFlags)](M_Rage_TaskInvoker_EnterVehicle_1.htm) |  |
| Public method | [EnterVehicle(Vehicle, Int32, Int32)](M_Rage_TaskInvoker_EnterVehicle_2.htm) | Makes the [Ped](T_Rage_Ped.htm) enter the specified [Vehicle](T_Rage_Vehicle.htm). |
| Public method | [EnterVehicle(Vehicle, Int32, Single)](M_Rage_TaskInvoker_EnterVehicle_6.htm) |  |
| Public method | [EnterVehicle(Vehicle, Int32, Int32, EnterVehicleFlags)](M_Rage_TaskInvoker_EnterVehicle_3.htm) |  |
| Public method | [EnterVehicle(Vehicle, Int32, Int32, Single)](M_Rage_TaskInvoker_EnterVehicle_4.htm) |  |
| Public method | [EnterVehicle(Vehicle, Int32, Int32, Single, EnterVehicleFlags)](M_Rage_TaskInvoker_EnterVehicle_5.htm) |  |
| Public method | [ExitCover](M_Rage_TaskInvoker_ExitCover.htm) |  |
| Public method | [ExitCover(ExitCoverTaskFlags)](M_Rage_TaskInvoker_ExitCover_1.htm) |  |
| Public method | [ExitCover(ExitCoverTaskFlags, Vector3)](M_Rage_TaskInvoker_ExitCover_2.htm) |  |
| Public method | [FightAgainst(Ped)](M_Rage_TaskInvoker_FightAgainst.htm) |  |
| Public method | [FightAgainst(Ped, Int32)](M_Rage_TaskInvoker_FightAgainst_1.htm) |  |
| Public method | [FightAgainstClosestHatedTarget(Single)](M_Rage_TaskInvoker_FightAgainstClosestHatedTarget.htm) |  |
| Public method | [FightAgainstClosestHatedTarget(Single, Int32)](M_Rage_TaskInvoker_FightAgainstClosestHatedTarget_1.htm) |  |
| Public method | [FireWeaponAt(Entity, Int32, FiringPattern)](M_Rage_TaskInvoker_FireWeaponAt.htm) |  |
| Public method | [FireWeaponAt(Vector3, Int32, FiringPattern)](M_Rage_TaskInvoker_FireWeaponAt_1.htm) |  |
| Public method | [Flee(Ped, Single, Int32)](M_Rage_TaskInvoker_Flee.htm) |  |
| Public method | [Flee(Vector3, Single, Int32)](M_Rage_TaskInvoker_Flee_1.htm) |  |
| Public method | [FollowPointRoute](M_Rage_TaskInvoker_FollowPointRoute.htm) |  |
| Public method | [FollowToOffsetFromEntity](M_Rage_TaskInvoker_FollowToOffsetFromEntity.htm) |  |
| Public method | [GoStraightToPosition](M_Rage_TaskInvoker_GoStraightToPosition.htm) |  |
| Public method | [GoToOffsetFromEntity(Entity, Single, Single, Single)](M_Rage_TaskInvoker_GoToOffsetFromEntity_1.htm) |  |
| Public method | [GoToOffsetFromEntity(Entity, Int32, Single, Single, Single)](M_Rage_TaskInvoker_GoToOffsetFromEntity.htm) | Makes the [Ped](T_Rage_Ped.htm) go to an offset from the specified [Entity](T_Rage_Entity.htm). |
| Public method | [GoToWhileAiming(Entity, Single, Single)](M_Rage_TaskInvoker_GoToWhileAiming_2.htm) | Makes the [Ped](T_Rage_Ped.htm) go to the specified [Entity](T_Rage_Entity.htm) while aiming at it. |
| Public method | [GoToWhileAiming(Entity, Entity, Single, Single, Boolean, FiringPattern)](M_Rage_TaskInvoker_GoToWhileAiming.htm) |  |
| Public method | [GoToWhileAiming(Entity, Vector3, Single, Single, Boolean, FiringPattern)](M_Rage_TaskInvoker_GoToWhileAiming_1.htm) |  |
| Public method | [GoToWhileAiming(Vector3, Entity, Single, Single, Boolean, FiringPattern)](M_Rage_TaskInvoker_GoToWhileAiming_3.htm) |  |
| Public method | [GoToWhileAiming(Vector3, Vector3, Single, Single, Boolean, FiringPattern)](M_Rage_TaskInvoker_GoToWhileAiming_4.htm) |  |
| Public method | [Jump](M_Rage_TaskInvoker_Jump.htm) | Makes the [Ped](T_Rage_Ped.htm) jump. |
| Public method | [LandPlane(Vector3, Vector3)](M_Rage_TaskInvoker_LandPlane.htm) |  |
| Public method | [LandPlane(Vehicle, Vector3, Vector3)](M_Rage_TaskInvoker_LandPlane_1.htm) |  |
| Public method | [LeaveVehicle(LeaveVehicleFlags)](M_Rage_TaskInvoker_LeaveVehicle.htm) |  |
| Public method | [LeaveVehicle(Vehicle, LeaveVehicleFlags)](M_Rage_TaskInvoker_LeaveVehicle_1.htm) |  |
| Public method | [Parachute](M_Rage_TaskInvoker_Parachute.htm) |  |
| Public method | [ParachuteToTarget](M_Rage_TaskInvoker_ParachuteToTarget.htm) |  |
| Public method | [ParkVehicle(Vector3, Single)](M_Rage_TaskInvoker_ParkVehicle.htm) |  |
| Public method | [ParkVehicle(Vehicle, Vector3, Single)](M_Rage_TaskInvoker_ParkVehicle_1.htm) |  |
| Public method | [Pause](M_Rage_TaskInvoker_Pause.htm) |  |
| Public method | [PerformDrivingManeuver(VehicleManeuver)](M_Rage_TaskInvoker_PerformDrivingManeuver_2.htm) |  |
| Public method | [PerformDrivingManeuver(Vehicle, VehicleManeuver)](M_Rage_TaskInvoker_PerformDrivingManeuver.htm) |  |
| Public method | [PerformDrivingManeuver(Vehicle, VehicleManeuver, Int32)](M_Rage_TaskInvoker_PerformDrivingManeuver_1.htm) |  |
| Public method | [PlayAnimation(AnimationDictionary, String, Single, AnimationFlags)](M_Rage_TaskInvoker_PlayAnimation_1.htm) |  |
| Public method | [PlayAnimation(AnimationDictionary, String, Int32, Single, Single, Single, AnimationFlags)](M_Rage_TaskInvoker_PlayAnimation.htm) |  |
| Public method | [PutHandsUp](M_Rage_TaskInvoker_PutHandsUp.htm) |  |
| Public method | [RappelFromHelicopter](M_Rage_TaskInvoker_RappelFromHelicopter.htm) | Makes the [Ped](T_Rage_Ped.htm) rappel from the current vehicle. The vehicle must be a helicopter and the set the [Ped](T_Rage_Ped.htm) is on must support rappelling. |
| Public method | [ReactAndFlee](M_Rage_TaskInvoker_ReactAndFlee.htm) |  |
| Public method | [ReloadWeapon](M_Rage_TaskInvoker_ReloadWeapon.htm) |  |
| Public method | [ShuffleToAdjacentSeat](M_Rage_TaskInvoker_ShuffleToAdjacentSeat.htm) | Makes the [Ped](T_Rage_Ped.htm) shuffle to an adjacent seat in the [Ped](T_Rage_Ped.htm)'s current vehicle. |
| Public method | [ShuffleToAdjacentSeat(Vehicle)](M_Rage_TaskInvoker_ShuffleToAdjacentSeat_1.htm) | Makes the [Ped](T_Rage_Ped.htm) shuffle to an adjacent seat in the specified vehicle. |
| Public method | [SmashCarWindow](M_Rage_TaskInvoker_SmashCarWindow.htm) | Makes this [Ped](T_Rage_Ped.htm) smash the window at the seat of the vehicle it's currently sitting in. |
| Public method | [StandStill](M_Rage_TaskInvoker_StandStill.htm) |  |
| Public method | [TakeCoverAt](M_Rage_TaskInvoker_TakeCoverAt.htm) |  |
| Public method | [TakeCoverFrom(Ped, Int32)](M_Rage_TaskInvoker_TakeCoverFrom.htm) |  |
| Public method | [TakeCoverFrom(Vector3, Int32)](M_Rage_TaskInvoker_TakeCoverFrom_2.htm) |  |
| Public method | [TakeCoverFrom(Ped, Int32, Boolean)](M_Rage_TaskInvoker_TakeCoverFrom_1.htm) |  |
| Public method | [TakeCoverFrom(Vector3, Int32, Boolean)](M_Rage_TaskInvoker_TakeCoverFrom_3.htm) |  |
| Public method | [Wander](M_Rage_TaskInvoker_Wander.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.