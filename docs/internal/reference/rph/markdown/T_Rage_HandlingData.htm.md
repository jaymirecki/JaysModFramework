# HandlingData Class

﻿HandlingData Class

|  |  |  |
| --- | --- | --- |
| HandlingData Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.HandlingData"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageHandlingData  
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
public sealed class HandlingData : IHandleable, 
	IAddressable
```

```
Public NotInheritable Class HandlingData
	Implements IHandleable, IAddressable
```

```
public ref class HandlingData sealed : IHandleable, 
	IAddressable
```

The HandlingData type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AntiRollBarBiasFront](P_Rage_HandlingData_AntiRollBarBiasFront.htm) | Gets or sets the bias between front and rear for the anti-roll bar. |
| Public property | [AntiRollBarForce](P_Rage_HandlingData_AntiRollBarForce.htm) | Gets or sets the spring constant that is transmitted to the opposite wheel when under compression. Larger numbers result in a larger force being applied. |
| Public property | [BrakeForce](P_Rage_HandlingData_BrakeForce.htm) |  |
| Public property | [CamberStiffnesss](P_Rage_HandlingData_CamberStiffnesss.htm) |  |
| Public property | [CenterOfMassOffset](P_Rage_HandlingData_CenterOfMassOffset.htm) |  |
| Public property | [ClutchChangeRateScaleDownShift](P_Rage_HandlingData_ClutchChangeRateScaleDownShift.htm) | Gets or sets the clutch speed multiplier on down shifts. |
| Public property | [ClutchChangeRateScaleUpShift](P_Rage_HandlingData_ClutchChangeRateScaleUpShift.htm) | Gets or sets the clutch speed multiplier on up shifts. |
| Public property | [CollisionDamageMultiplier](P_Rage_HandlingData_CollisionDamageMultiplier.htm) |  |
| Public property | [DamageFlags](P_Rage_HandlingData_DamageFlags.htm) |  |
| Public property | [DeformationDamageMultiplier](P_Rage_HandlingData_DeformationDamageMultiplier.htm) |  |
| Public property | [DriveInertia](P_Rage_HandlingData_DriveInertia.htm) | Gets or sets the drive inertia. A lower drive inertia slows engine acceleration. If you want a vehicle with high torque but slow acceleration (e.g. a truck) lower the driver inertia but specify a high drive force. |
| Public property | [EngineDamageMultiplier](P_Rage_HandlingData_EngineDamageMultiplier.htm) |  |
| Public property | [HandBrakeForce](P_Rage_HandlingData_HandBrakeForce.htm) |  |
| Public property | [Handle](P_Rage_HandlingData_Handle.htm) |  |
| Public property | [HandlingFlags](P_Rage_HandlingData_HandlingFlags.htm) |  |
| Public property | [Hash](P_Rage_HandlingData_Hash.htm) |  |
| Public property | [InertiaMultiplier](P_Rage_HandlingData_InertiaMultiplier.htm) |  |
| Public property | [InitialDriveForce](P_Rage_HandlingData_InitialDriveForce.htm) | Gets or sets the power engine produces in top gear. |
| Public property | [InitialDriveGears](P_Rage_HandlingData_InitialDriveGears.htm) | Gets or sets the number of gears (excluding reverse). |
| Public property | [Mass](P_Rage_HandlingData_Mass.htm) |  |
| Public property | [MemoryAddress](P_Rage_HandlingData_MemoryAddress.htm) |  |
| Public property | [ModelFlags](P_Rage_HandlingData_ModelFlags.htm) |  |
| Public property | [MonetaryValue](P_Rage_HandlingData_MonetaryValue.htm) |  |
| Public property | [OilVolume](P_Rage_HandlingData_OilVolume.htm) |  |
| Public property | [PercentSubmerged](P_Rage_HandlingData_PercentSubmerged.htm) | Gets or sets the drag coefficient on the RAGE physics archetype of the vehicle (proportional to velocity squared). Increase to simulate aerodynamic drag. |
| Public property | [PetrolTankVolume](P_Rage_HandlingData_PetrolTankVolume.htm) |  |
| Public property | [RollCenterHeightFront](P_Rage_HandlingData_RollCenterHeightFront.htm) |  |
| Public property | [RollCenterHeightRear](P_Rage_HandlingData_RollCenterHeightRear.htm) |  |
| Public property | [SeatOffsetDistanceX](P_Rage_HandlingData_SeatOffsetDistanceX.htm) |  |
| Public property | [SeatOffsetDistanceY](P_Rage_HandlingData_SeatOffsetDistanceY.htm) |  |
| Public property | [SeatOffsetDistanceZ](P_Rage_HandlingData_SeatOffsetDistanceZ.htm) |  |
| Public property | [SteeringLock](P_Rage_HandlingData_SteeringLock.htm) |  |
| Public property | [SuspensionBiasFront](P_Rage_HandlingData_SuspensionBiasFront.htm) | Gets or sets damping scale bias between front and rear wheels. if more wheels at back (e.g. trucks) front suspension should be stronger. |
| Public property | [SuspensionCompressionDamping](P_Rage_HandlingData_SuspensionCompressionDamping.htm) |  |
| Public property | [SuspensionForce](P_Rage_HandlingData_SuspensionForce.htm) | Gets or sets the suspension force. Lower limit for zero force at full extension is calculated using (1.0f / (force \* number of wheels)). |
| Public property | [SuspensionLowerLimit](P_Rage_HandlingData_SuspensionLowerLimit.htm) | Gets or sets how far the wheels can move down from their original position. |
| Public property | [SuspensionRaise](P_Rage_HandlingData_SuspensionRaise.htm) | Gets or sets the adjustment from artist positioning. |
| Public property | [SuspensionReboundDamping](P_Rage_HandlingData_SuspensionReboundDamping.htm) |  |
| Public property | [SuspensionUpperLimit](P_Rage_HandlingData_SuspensionUpperLimit.htm) | Gets or sets how far the wheels can move up from their original position. |
| Public property | [TopSpeed](P_Rage_HandlingData_TopSpeed.htm) | Gets or sets the max speed in top gear (used when configuring gears).  This value is initialized using InitialDriveMaxFlatVel in handlingdata.meta multiplied by 1.2f. |
| Public property | [TractionBiasFront](P_Rage_HandlingData_TractionBiasFront.htm) |  |
| Public property | [TractionCurveMaximum](P_Rage_HandlingData_TractionCurveMaximum.htm) |  |
| Public property | [TractionCurveMinimum](P_Rage_HandlingData_TractionCurveMinimum.htm) |  |
| Public property | [TractionLossMultiplier](P_Rage_HandlingData_TractionLossMultiplier.htm) | Gets or sets how much traction is affected by material grip differences from 1.0f. |
| Public property | [TractionSpringDeltaMaximum](P_Rage_HandlingData_TractionSpringDeltaMaximum.htm) | Gets or sets the maximum distance for traction spring. |
| Public property | [WeaponDamageMultiplier](P_Rage_HandlingData_WeaponDamageMultiplier.htm) |  |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Equals(HandlingData)](M_Rage_HandlingData_Equals.htm) | Indicates whether this instance equals the specified HandlingData instance. |
| Public method | [Equals(IHandleable)](M_Rage_HandlingData_Equals_1.htm) | Indicates whether this instance equals the specified [IHandleable](T_Rage_IHandleable.htm) instance. |
| Public methodStatic member | [GetByHash](M_Rage_HandlingData_GetByHash.htm) |  |
| Public methodStatic member | [GetByName](M_Rage_HandlingData_GetByName.htm) |  |
| Public method | [IsValid](M_Rage_HandlingData_IsValid.htm) |  |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [Equality](M_Rage_HandlingData_op_Equality.htm) | Determines whether the the first HandlingData instance represents the same handling data as the second HandlingData instance. |
| Public operatorStatic member | [Inequality](M_Rage_HandlingData_op_Inequality.htm) | Determines whether the the first HandlingData instance represents a different handling data than the second HandlingData instance. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.