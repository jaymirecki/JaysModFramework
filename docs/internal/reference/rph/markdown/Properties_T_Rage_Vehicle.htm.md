# Vehicle Properties

﻿Vehicle Properties

|  |  |  |
| --- | --- | --- |
| Vehicle Properties | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [Vehicle](T_Rage_Vehicle.htm) type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AbovePosition](P_Rage_Entity_AbovePosition.htm) | Gets a position directly above this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [AccelerationScale](P_Rage_Vehicle_AccelerationScale.htm) | Gets the acceleration scale. |
| Public property | [AlarmTimeLeft](P_Rage_Vehicle_AlarmTimeLeft.htm) | Gets or sets time left before the vehicle alarm stops.  If greater than zero, the vehicle alarm will be sounding. |
| Public property | [AngularVelocity](P_Rage_Entity_AngularVelocity.htm) | Gets or sets the rotational velocity of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [BelowPosition](P_Rage_Entity_BelowPosition.htm) | Gets a position directly below this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [CanBeDamaged](P_Rage_Entity_CanBeDamaged.htm) | Gets or sets a value indicating whether this entity can be damaged. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [CanTiresBurst](P_Rage_Vehicle_CanTiresBurst.htm) | Gets or sets a value indicating whether the tired of this vehicle can be burst. |
| Public property | [Class](P_Rage_Vehicle_Class.htm) |  |
| Public property | [CollisionIgnoredEntity](P_Rage_Entity_CollisionIgnoredEntity.htm) | Gets or sets the [Entity](T_Rage_Entity.htm) this entity currently ignores collisions from. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [ConvertibleRoofState](P_Rage_Vehicle_ConvertibleRoofState.htm) |  |
| Public property | [CreatedByTheCallingPlugin](P_Rage_Entity_CreatedByTheCallingPlugin.htm) | Gets a value indicating whether this instance was created by the calling plugin. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [CurrentGear](P_Rage_Vehicle_CurrentGear.htm) | Gets the current gear of this vehicle. |
| Public property | [DefaultEmergencyLighting](P_Rage_Vehicle_DefaultEmergencyLighting.htm) | Gets the default emergency lighting settings for this type of vehicle. |
| Public property | [DesiredVerticalFlightPhase](P_Rage_Vehicle_DesiredVerticalFlightPhase.htm) | Gets or sets the desired vertical flight phase. This adjusts the thruster angle on VTOL enabled planes.  [VerticalFlightPhase](P_Rage_Vehicle_VerticalFlightPhase.htm) will be interpolated towards the desired value. |
| Public property | [Direction](P_Rage_Entity_Direction.htm) | Gets or sets the direction of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [DirtLevel](P_Rage_Vehicle_DirtLevel.htm) | Gets or sets the dirt level of this vehicle. |
| Public property | [Doors](P_Rage_Vehicle_Doors.htm) | Gets the doors of this vehicle. |
| Public property | [DriveForce](P_Rage_Vehicle_DriveForce.htm) | Gets or sets the drive force of this vehicle. |
| Public property | [Driver](P_Rage_Vehicle_Driver.htm) | Gets the [Ped](T_Rage_Ped.htm) on the driver's seat of this vehicle. |
| Public property | [EmergencyLighting](P_Rage_Vehicle_EmergencyLighting.htm) | Gets the emergency lighting settings currently assigned to this vehicle. |
| Public property | [EmergencyLightingOverride](P_Rage_Vehicle_EmergencyLightingOverride.htm) | Gets or sets the overriden emergency lighting settings for this vehicle. |
| Public property | [EngineHealth](P_Rage_Vehicle_EngineHealth.htm) | Gets or sets the health of the car's engine.  The engine health ranges between 0.0f and 1000.0f.    When the engine health is below 400.0f, the engine will start to smoke.  When the engine health is 300.0f or below, the car's back fire will become smokey and sound worse.  When the engine health is below 300.0f, the car will have difficulties maintaining a stable acceleration.  When the engine health reaches 0.0f, the car's engine will die. |
| Public property | [EngineRevolutionsRatio](P_Rage_Vehicle_EngineRevolutionsRatio.htm) | Gets the current engine revolutions ratio. |
| Public property | [ForwardVector](P_Rage_Entity_ForwardVector.htm) | Gets the forward vector of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [FreePassengerSeatsCount](P_Rage_Vehicle_FreePassengerSeatsCount.htm) | Gets the number of free passenger seats in this vehicle.  Does not include the driver's seat. |
| Public property | [FreeSeatsCount](P_Rage_Vehicle_FreeSeatsCount.htm) | Gets the number of free seats in this vehicle.  Includes the driver's seat. |
| Public property | [FrontPosition](P_Rage_Entity_FrontPosition.htm) | Gets a position directly in front of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [FuelLevel](P_Rage_Vehicle_FuelLevel.htm) | Gets or sets the amount of fuel in this vehicle. |
| Public property | [FuelTankHealth](P_Rage_Vehicle_FuelTankHealth.htm) | Gets or sets the health of the car's fuel tank.  The fuel tank health ranges between 0.0f and 1000.0f.    When the fuel tank health is below 700.0f, fuel will start leaking.  When the fuel tank health is below 50.0f, the engine will be unable to start. |
| Public property | [Handle](P_Rage_Entity_Handle.htm) | Gets the handle of this instance. Used to identify the instance within its pool. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HandlingData](P_Rage_Vehicle_HandlingData.htm) | Gets or sets the handling data associated with this vehicle.  Note, that this is a reference to the global handling data for this type of vehicle, and changing it, will change the handling data of all vehicles of this type. |
| Public property | [HasBeenDamagedByAnyObject](P_Rage_Entity_HasBeenDamagedByAnyObject.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Object](T_Rage_Object.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HasBeenDamagedByAnyPed](P_Rage_Entity_HasBeenDamagedByAnyPed.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Ped](T_Rage_Ped.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HasBeenDamagedByAnyVehicle](P_Rage_Entity_HasBeenDamagedByAnyVehicle.htm) | Gets or sets a value indicating whether this entity has been damaged by any [Vehicle](T_Rage_Vehicle.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HasBeenDisabledByWater](P_Rage_Vehicle_HasBeenDisabledByWater.htm) | Gets or sets whether this vehicle has been disabled by water. If this flag is set, the vehicle can't drive and the player can't enter it. When this flag has been set manually, it is reset when exiting the vehicle, so it should be set when not in the vehicle. |
| Public property | [HasBombBay](P_Rage_Vehicle_HasBombBay.htm) | Gets a value indicating whether this vehicle has a bomb bay. |
| Public property | [HasDiggerArm](P_Rage_Vehicle_HasDiggerArm.htm) | Gets a value indicating whether this vehicle has a digger arm. |
| Public property | [HasDriver](P_Rage_Vehicle_HasDriver.htm) | Gets a value indicating whether this vehicle has a driver. |
| Public property | [HasForks](P_Rage_Vehicle_HasForks.htm) | Gets a value indicating whether this vehicle has forks. |
| Public property | [HasOccupants](P_Rage_Vehicle_HasOccupants.htm) | Gets a value indicating whether this vehicle has one or more occupants.  Includes the driver. |
| Public property | [HasPassengers](P_Rage_Vehicle_HasPassengers.htm) | Gets a value indicating whether this vehicle has one or more passengers.  Does not include the driver. |
| Public property | [HasRoof](P_Rage_Vehicle_HasRoof.htm) | Gets a value indicating whether this vehicle has a roof.  Returns true for convertibles, even when their roof is down. |
| Public property | [HasSiren](P_Rage_Vehicle_HasSiren.htm) | Gets a value indicating whether this vehicle has a siren. |
| Public property | [HasTowArm](P_Rage_Vehicle_HasTowArm.htm) | Gets a value indicating whether this vehicle has a tow arm. |
| Public property | [HasTracks](P_Rage_Vehicle_HasTracks.htm) | Gets a value indicating whether this vehicle has tracks. |
| Public property | [HasTrailer](P_Rage_Vehicle_HasTrailer.htm) | Gets a value indicating whether this vehicle has a trailer attached. |
| Public property | [HasTrailerHitch](P_Rage_Vehicle_HasTrailerHitch.htm) | Gets a value indicating whether this vehicle has a trailer hitch. |
| Public property | [Heading](P_Rage_Entity_Heading.htm) | Gets or sets the heading of this instance in degrees. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Health](P_Rage_Entity_Health.htm) | Gets or sets the health of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Height](P_Rage_Entity_Height.htm) | Gets the height of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [HeightAboveGround](P_Rage_Entity_HeightAboveGround.htm) | Gets this entity's distance from the ground in 1D on the Z-axis.  The distance is measured from the entity's origin to the surface below the entity (Surfaces include roofs of buildings). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IndicatorLightsStatus](P_Rage_Vehicle_IndicatorLightsStatus.htm) | Sets the status of the indicator lights on this vehicle. |
| Public property | [Invincible](P_Rage_Entity_Invincible.htm) | **Obsolete.**  Sets a value indicating whether this instance is invincible. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsAlarmSounding](P_Rage_Vehicle_IsAlarmSounding.htm) | Gets a value indicating whether this vehicle's alarm is sounding. |
| Public property | [IsAlive](P_Rage_Entity_IsAlive.htm) | Gets a value indicating whether this instance is alive. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsAmphibious](P_Rage_Vehicle_IsAmphibious.htm) | Gets a value indicating whether this vehicle is amphibious. |
| Public property | [IsAmphibiousCar](P_Rage_Vehicle_IsAmphibiousCar.htm) | Gets a value indicating whether this vehicle is an amphibious car. |
| Public property | [IsAmphibiousQuadBike](P_Rage_Vehicle_IsAmphibiousQuadBike.htm) | Gets a value indicating whether this vehicle is an amphibious quad bike. |
| Public property | [IsBicycle](P_Rage_Vehicle_IsBicycle.htm) | Gets a value indicating whether this vehicle is a bicycle. |
| Public property | [IsBig](P_Rage_Vehicle_IsBig.htm) | Gets a value indicating whether this is a big vehicle, like busses, trucks, semis, etc.  Does not return true for certain special vehicles like CUTTER. |
| Public property | [IsBike](P_Rage_Vehicle_IsBike.htm) | Gets a value indicating whether this vehicle is a bike. |
| Public property | [IsBlimp](P_Rage_Vehicle_IsBlimp.htm) | Gets a value indicating whether this vehicle is a blimp. |
| Public property | [IsBoat](P_Rage_Vehicle_IsBoat.htm) | Gets a value indicating whether this vehicle is a boat. |
| Public property | [IsBulletProof](P_Rage_Entity_IsBulletProof.htm) | Gets or sets a value indicating whether this entity can take damage from bullets. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsBurnoutForced](P_Rage_Vehicle_IsBurnoutForced.htm) | Sets a value indicating whether this vehicle is forced into a burnout. |
| Public property | [IsCar](P_Rage_Vehicle_IsCar.htm) | Gets a value indicating whether this vehicle is a car. |
| Public property | [IsCollisionEnabled](P_Rage_Entity_IsCollisionEnabled.htm) | Gets or sets a value indicating whether collision is enabled for this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsCollisionProof](P_Rage_Entity_IsCollisionProof.htm) | Gets or sets a value indicating whether this entity can take damage from collisions. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsConvertible](P_Rage_Vehicle_IsConvertible.htm) | Gets a value indicating whether this vehicle is a convertible. |
| Public property | [IsDead](P_Rage_Entity_IsDead.htm) | Gets a value indicating whether this instance is dead. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsDeformationEnabled](P_Rage_Vehicle_IsDeformationEnabled.htm) | Gets or sets a value indicating whether deformation is enabled for this vehicle.  If deformation is disabled, the car will still take damage, but will not become deform.  Lights, fenders, etc. will still take damage. |
| Public property | [IsDriveable](P_Rage_Vehicle_IsDriveable.htm) | Gets or sets whether this instance is driveable. |
| Public property | [IsEmpty](P_Rage_Vehicle_IsEmpty.htm) | Gets a value indicating whether this vehicle currently has no occupants. |
| Public property | [IsEngineOn](P_Rage_Vehicle_IsEngineOn.htm) | Gets or sets a value indicating whether the engine of this vehicle is on. |
| Public property | [IsEngineStarting](P_Rage_Vehicle_IsEngineStarting.htm) | Gets or sets a value indicating whether the engine of this vehicle is currently starting. |
| Public property | [IsExplosionProof](P_Rage_Entity_IsExplosionProof.htm) | Gets or sets a value indicating whether this entity can take damage from explosions. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsFireProof](P_Rage_Entity_IsFireProof.htm) | Gets or sets a value indicating whether this entity can take damage from fire. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsFull](P_Rage_Vehicle_IsFull.htm) | Gets a value indicating whether this vehicle currently is full. |
| Public property | [IsGravityDisabled](P_Rage_Entity_IsGravityDisabled.htm) | Gets or sets a value indicating whether gravity is disabled for this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsHandbrakeForced](P_Rage_Vehicle_IsHandbrakeForced.htm) | Gets or sets a value indicating whether this handbrake on this vehicle is forced on. |
| Public property | [IsHelicopter](P_Rage_Vehicle_IsHelicopter.htm) | Gets a value indicating whether this vehicle is a helicopter. |
| Public property | [IsInAir](P_Rage_Entity_IsInAir.htm) | (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsInBurnout](P_Rage_Vehicle_IsInBurnout.htm) | Gets a value indicating whether this vehicle is in a burnout. |
| Public property | [IsInteriorLightOn](P_Rage_Vehicle_IsInteriorLightOn.htm) | Gets or sets a value indicating whether the interior light in this vehicle is on. |
| Public property | [IsInvincible](P_Rage_Entity_IsInvincible.htm) | Sets a value indicating whether this instance is invincible. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsInWater](P_Rage_Entity_IsInWater.htm) | Gets a value indicating whether this entity is currently in water.  Returns true the moment any part of the entity is touching water. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsMeleeProof](P_Rage_Entity_IsMeleeProof.htm) | Gets or sets a value indicating whether this entity can take damage from melee attacks. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsOnAllWheels](P_Rage_Vehicle_IsOnAllWheels.htm) | Gets a value indicating whether all wheels of this vehicle are touching the ground. |
| Public property | [IsOnFire](P_Rage_Entity_IsOnFire.htm) | Gets or sets a value indicating whether this [Entity](T_Rage_Entity.htm) is on fire. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsOnScreen](P_Rage_Entity_IsOnScreen.htm) | Gets a value indicating whether this instance is on the screen. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsPersistent](P_Rage_Entity_IsPersistent.htm) | Gets or sets a value indicating whether this instance is persistent within the game world. Persistent instances will not be removed automatically during clean ups. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsPlane](P_Rage_Vehicle_IsPlane.htm) | Gets a value indicating whether this vehicle is a plane. |
| Public property | [IsPoliceVehicle](P_Rage_Vehicle_IsPoliceVehicle.htm) | Gets a value indicating whether this vehicle is a police vehicle. |
| Public property | [IsPositionFrozen](P_Rage_Entity_IsPositionFrozen.htm) | Sets a value indicating whether the position of this entity is frozen. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsQuadBike](P_Rage_Vehicle_IsQuadBike.htm) | Gets a value indicating whether this vehicle is a quad bike. |
| Public property | [IsRecordingCollisions](P_Rage_Entity_IsRecordingCollisions.htm) | Gets or sets a value indicating whether this entity is recording collisions. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsRendered](P_Rage_Entity_IsRendered.htm) | Gets a value indicating whether this instance is currently being rendered. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsSirenOn](P_Rage_Vehicle_IsSirenOn.htm) | Gets or sets a value indicating whether the siren is on.  If this vehicle is not an emergency vehicle, the method will have no effect. |
| Public property | [IsSirenSilent](P_Rage_Vehicle_IsSirenSilent.htm) | Gets or sets a value indicating whether the siren is silent.  If this vehicle is not an emergency vehicle, the method will have no effect. |
| Public property | [IsStolen](P_Rage_Vehicle_IsStolen.htm) | Gets or sets a value indicating whether this vehicle is stolen. |
| Public property | [IsStoppedAtTrafficLights](P_Rage_Vehicle_IsStoppedAtTrafficLights.htm) | Gets a value indicating whether this vehicle is currently stopped at traffic lights. |
| Public property | [IsSubmarine](P_Rage_Vehicle_IsSubmarine.htm) | Gets a value indicating whether this vehicle is a submarine. |
| Public property | [IsTaxiLightOn](P_Rage_Vehicle_IsTaxiLightOn.htm) | Gets or sets a value indicating whether the taxi lights are on.  If this vehicle is not a taxi, the method will have no effect. |
| Public property | [IsTrailer](P_Rage_Vehicle_IsTrailer.htm) | Gets a value indicating whether this vehicle is a trailer. |
| Public property | [IsTrain](P_Rage_Vehicle_IsTrain.htm) | Gets a value indicating whether this vehicle is a train. |
| Public property | [IsUpsideDown](P_Rage_Entity_IsUpsideDown.htm) | Gets or sets a value indicating whether this entity is upside down. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [IsVisible](P_Rage_Entity_IsVisible.htm) | Gets or sets a value indicating whether this instance is currently visible within the game world.  Invisible instances will still be processed but will not be rendered. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [LeftPosition](P_Rage_Entity_LeftPosition.htm) | Gets a position directly to the left of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Length](P_Rage_Entity_Length.htm) | Gets the length of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [LicensePlate](P_Rage_Vehicle_LicensePlate.htm) | Gets or sets the license plate of this vehicle. |
| Public property | [LicensePlateStyle](P_Rage_Vehicle_LicensePlateStyle.htm) |  |
| Public property | [LicensePlateType](P_Rage_Vehicle_LicensePlateType.htm) |  |
| Public property | [LockStatus](P_Rage_Vehicle_LockStatus.htm) | Gets or sets the lock status of this vehicle. |
| Public property | [MaxHealth](P_Rage_Entity_MaxHealth.htm) | Gets or sets the maximum health of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [MemoryAddress](P_Rage_Entity_MemoryAddress.htm) | Gets the memory address of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public propertyCode example | [Metadata](P_Rage_Entity_Metadata.htm) | Gets the [metadata](https://en.wikipedia.org/wiki/Metadata) associated with this instance.  The value of this property can be used to store data about this instance.  Getting or setting metadata is done using the same syntax as getting or setting a property.  Internally the value is added to a dictionary with the specified property name as key. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Model](P_Rage_Entity_Model.htm) | Gets or sets the [Model](P_Rage_IRenderable_Model.htm) of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Mods](P_Rage_Vehicle_Mods.htm) | Gets an instance of [VehicleModder](T_Rage_VehicleModder.htm) that can be used to change mods on this vehicle. |
| Public property | [MustBeHotwired](P_Rage_Vehicle_MustBeHotwired.htm) | Gets or sets a value indicating whether this vehicle must be hotwired before its engine can be turned on. |
| Public property | [NeedsCollision](P_Rage_Entity_NeedsCollision.htm) | Gets a value indicating whether this instance needs collision.  Entities not marked explicitly to need collision will still get collision, however, if other entities need collision, entities not marked as needing collision may lose it in favor of those. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [NumberOfGears](P_Rage_Vehicle_NumberOfGears.htm) | Gets or sets the number of gears this vehicle has. |
| Public property | [Occupants](P_Rage_Vehicle_Occupants.htm) | Gets all peds currently in this vehicle.  Includes the driver. |
| Public property | [Opacity](P_Rage_Entity_Opacity.htm) | Gets or sets the opacity of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Orientation](P_Rage_Entity_Orientation.htm) | Gets or sets the orientation of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [PassengerCapacity](P_Rage_Vehicle_PassengerCapacity.htm) | Gets the number of passengers this vehicle has seats for. Does not include the driver seat. |
| Public property | [PassengerCount](P_Rage_Vehicle_PassengerCount.htm) | Gets the number of passengers this vehicle currently has. Does not include the driver. |
| Public property | [Passengers](P_Rage_Vehicle_Passengers.htm) | Gets the passengers of this vehicle.  Does not include the driver.    If you need a passenger at a specific seat index, using [GetPedOnSeat(Int32)](M_Rage_Vehicle_GetPedOnSeat.htm) is more efficient. |
| Public property | [PearlescentColor](P_Rage_Vehicle_PearlescentColor.htm) | Gets or sets the pearlescent color of this vehicle. |
| Public property | [Position](P_Rage_Entity_Position.htm) | Gets or sets the position of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [PrimaryColor](P_Rage_Vehicle_PrimaryColor.htm) | Gets or sets the primary color of this vehicle. |
| Public property | [Quaternion](P_Rage_Entity_Quaternion.htm) | **Obsolete.**  Gets or sets the quaternion of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [RadioStation](P_Rage_Vehicle_RadioStation.htm) | Gets or sets the radio station of this vehicle. |
| Public property | [RearPosition](P_Rage_Entity_RearPosition.htm) | Gets a position directly behind this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [RightPosition](P_Rage_Entity_RightPosition.htm) | Gets a position directly to the right of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [RightVector](P_Rage_Entity_RightVector.htm) | Gets the right vector of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [RimColor](P_Rage_Vehicle_RimColor.htm) | Gets or sets the color of the rims on the wheels of this vehicle. The wheels must be custom. |
| Public property | [Rotation](P_Rage_Entity_Rotation.htm) | Gets or sets the rotation of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [SecondaryColor](P_Rage_Vehicle_SecondaryColor.htm) | Gets or sets the secondary color of this vehicle. |
| Public property | [ShouldVehiclesYieldToThisVehicle](P_Rage_Vehicle_ShouldVehiclesYieldToThisVehicle.htm) | Gets or sets whether other vehicles should yield to this vehicle.  This vehicle must be an emergency vehicle (Police, ambulance or fire truck). |
| Public property | [Speed](P_Rage_Entity_Speed.htm) | Gets the speed of this [Entity](T_Rage_Entity.htm) in meters per second.  This is equivalent of [Velocity](P_Rage_Entity_Velocity.htm).Length(). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [SteeringAngle](P_Rage_Vehicle_SteeringAngle.htm) | Gets or sets the steering angle. |
| Public property | [SteeringScale](P_Rage_Vehicle_SteeringScale.htm) | Gets or sets the steering scale. |
| Public property | [SubmersionLevel](P_Rage_Entity_SubmersionLevel.htm) | Gets a value indicating how submersed this entity is. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [TopSpeed](P_Rage_Vehicle_TopSpeed.htm) | Gets or sets the top speed of this vehicle. |
| Public property | [TowedVehicle](P_Rage_Vehicle_TowedVehicle.htm) | Gets the [Vehicle](T_Rage_Vehicle.htm) currently being towed by this [Vehicle](T_Rage_Vehicle.htm). |
| Public property | [TowingCraneRaisedAmount](P_Rage_Vehicle_TowingCraneRaisedAmount.htm) | Sets a value indicating how much the towing crane is raised.  This [Vehicle](T_Rage_Vehicle.htm) must have a towing device. |
| Public property | [Trailer](P_Rage_Vehicle_Trailer.htm) | Gets or sets the trailer on this vehicle. |
| Public property | [UpVector](P_Rage_Entity_UpVector.htm) | Gets the up vector of this instance. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Velocity](P_Rage_Entity_Velocity.htm) | Gets or sets the velocity of this entity. (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [VerticalFlightPhase](P_Rage_Vehicle_VerticalFlightPhase.htm) | Gets or sets the vertical flight phase. This adjusts the thruster angle on VTOL enabled planes.  Note that the game will interppolate this property to the value of [DesiredVerticalFlightPhase](P_Rage_Vehicle_DesiredVerticalFlightPhase.htm).  To have the plane remain at the specified value, set both properties to the same value. |
| Public property | [Wheels](P_Rage_Vehicle_Wheels.htm) | Gets the wheels of this vehicle. |
| Public property | [Width](P_Rage_Entity_Width.htm) | Gets the width of this [Entity](T_Rage_Entity.htm). (Inherited from [Entity](T_Rage_Entity.htm).) |
| Public property | [Windows](P_Rage_Vehicle_Windows.htm) | Gets the windows of this vehicle. |

[Top](#mainBody)

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.