# VehicleDrivingFlags Enumeration

﻿VehicleDrivingFlags Enumeration

|  |  |  |
| --- | --- | --- |
| VehicleDrivingFlags Enumeration | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Flags for driving tasks.

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
[FlagsAttribute]
public enum VehicleDrivingFlags
```

```
<FlagsAttribute>
Public Enumeration VehicleDrivingFlags
```

```
[FlagsAttribute]
public enum class VehicleDrivingFlags
```

Members

|  | Member name | Value | Description |
| --- | --- | --- | --- |
|  | None | 0 |  |
|  | FollowTraffic | 1 |  |
|  | YieldToCrossingPedestrians | 2 |  |
|  | DriveAroundVehicles | 4 |  |
|  | DriveAroundPeds | 16 |  |
|  | DriveAroundObjects | 32 |  |
|  | RespectIntersections | 128 |  |
|  | AllowWrongWay | 512 |  |
|  | Reverse | 1024 |  |
|  | AllowMedianCrossing | 262144 |  |
|  | DriveBySight | 4194304 |  |
|  | IgnorePathFinding | 16777216 |  |
|  | AvoidHighways | 536870912 |  |
|  | StopAtDestination | 2147483648 |  |
|  | Normal | 183 |  |
|  | Emergency | 262710 |  |

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.