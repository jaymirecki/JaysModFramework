# VehicleManeuver Enumeration

﻿VehicleManeuver Enumeration

|  |  |  |
| --- | --- | --- |
| VehicleManeuver Enumeration | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents the possible driving maneuvers for [!:Rage::TaskInvoker::PerformDrivingManeuver].

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
public enum VehicleManeuver
```

```
Public Enumeration VehicleManeuver
```

```
public enum class VehicleManeuver
```

Members

|  | Member name | Value | Description |
| --- | --- | --- | --- |
|  | Wait | 1 | Sets acceleration to 0% and braking power to 20%.  Steering angle will not be touched, and can be set manually. |
|  | ReverseStraight75 | 3 | Sets acceleration to -75% and braking power to 0%.  Steering angle will be forced to 0°. |
|  | HandBrakeLeft | 4 | Sets acceleration to 0% and braking power to 0%. Handbrake will be engaged.  Steering angle will be forced to 40°. |
|  | HandBrakeRight | 5 | Sets acceleration to 0% and braking power to 0%. Handbrake will be engaged.  Steering angle will be forced to -40°. |
|  | HandBrakeStraight | 6 | Sets acceleration to 0% and braking power to 0%. Handbrake will be engaged.  Steering angle will be forced to 0°. |
|  | GoForwardLeft | 7 | Sets acceleration to 100% and braking power to 0%.  Steering angle will be forced to 40°. |
|  | GoForwardRight | 8 | Sets acceleration to 100% and braking power to 0%.  Steering angle will be forced to -40°. |
|  | GoForwardStraightHalfAcceleration | 9 | Sets acceleration to 50% and braking power to 0%.  Steering angle will be forced to 0°. |
|  | SwerveLeft | 10 | Sets acceleration to 0% and braking power to 0.1%.  Steering angle will be forced to 14.3239°. |
|  | SwerveRight | 11 | Sets acceleration to 0% and braking power to 0.1%.  Steering angle will be forced to -14.3239°. |
|  | ReverseLeft | 13 | Sets acceleration to -75% and braking power to 0%.  Steering angle will be forced to 40°. |
|  | ReverseRight | 14 | Sets acceleration to -75% and braking power to 0%.  Steering angle will be forced to -40°. |
|  | HeadOnCollision | 19 | Simulates a car reacting to an oncoming car, by handbraking left or right.  Sets acceleration to 0% and braking power to 100%. Handbrake will be engaged. |
|  | SwerveAndBrakeLeft | 20 | Sets acceleration to 0% and braking power to 30%.  Steering angle will be forced to 14.3239°. |
|  | SwerveAndBrakeRight | 21 | Sets acceleration to 0% and braking power to 30%.  Steering angle will be forced to -14.3239°. |
|  | ReverseStraight50 | 22 | Sets acceleration to -50% and braking power to 0%.  Steering angle will be forced to 0°. |
|  | GoForwardWithCustomSteeringAngle | 23 | Sets acceleration to 100% and braking power to 0%.  Steering angle will not be touched, and can be set manually. |
|  | GoForwardStraightBraking | 24 | Sets acceleration to 0% and braking power to 100%.  Steering angle will be forced to 0°. |
|  | HandBrakeUTurn | 25 | The vehicle will attempt to make a u-turn by turning the wheels and pulling the handbrake.  The vehicle will not attempt to gain enough speed first, and will fail to get all the way around if it isn't going fast enough when this maneuver is invoked. |
|  | UTurn | 26 | The vehicle will attempt to make a u-turn by turning the wheels.  The vehicle will not attempt to gain enough speed first, and will fail to get all the way around if it isn't going fast enough when this maneuver is invoked. |
|  | HandBrakeDrivingDirection | 27 | Will make the vehicle engage the handbrake, and steer the wheels towards the current movement direction, keeping the car as steady as possible. |
|  | ReverseStraight | 28 | Sets acceleration to -100% and braking power to 0%.  Steering angle will be forced to 0°. |
|  | BurnOut | 30 | Sets acceleration to 100% and braking power to 100%.  Steering angle will be forced to 0°. |
|  | RevEngine | 31 | Sets acceleration to 100% and braking power to 0%. Handbrake will be engaged.  Steering angle will be forced to 0°. |
|  | GoForwardStraight | 32 | Sets acceleration to 100% and braking power to 0%.  Steering angle will be forced to 0°. |
|  | SurfaceSubmarine | 33 | Brings a submarine to the water surface. |

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.