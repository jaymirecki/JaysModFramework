# GetEntitiesFlags Enumeration

﻿GetEntitiesFlags Enumeration

|  |  |  |
| --- | --- | --- |
| GetEntitiesFlags Enumeration | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.GetEntitiesFlags"]

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
public enum GetEntitiesFlags
```

```
<FlagsAttribute>
Public Enumeration GetEntitiesFlags
```

```
[FlagsAttribute]
public enum class GetEntitiesFlags
```

Members

|  | Member name | Value | Description |
| --- | --- | --- | --- |
|  | ConsiderCars | 1 |  |
|  | ConsiderBikes | 2 |  |
|  | ConsiderBoats | 4 |  |
|  | ConsiderPlanes | 8 |  |
|  | ConsiderHelicopters | 16 |  |
|  | ConsiderTrains | 32 |  |
|  | ConsiderBicycles | 64 |  |
|  | ConsiderQuadBikes | 128 |  |
|  | ConsiderAirVehicles | 24 |  |
|  | ConsiderGroundVehicles | 227 |  |
|  | ConsiderAllVehicles | 255 |  |
|  | ConsiderHumanPeds | 256 |  |
|  | ConsiderAnimalPeds | 512 |  |
|  | ConsiderAllPeds | 768 |  |
|  | ConsiderAllObjects | 1024 |  |
|  | ExcludePoliceOfficers | 2048 |  |
|  | ExcludeOccupiedVehicles | 4096 |  |
|  | ExcludeEmptyVehicles | 8192 |  |
|  | ExcludePlayerVehicleIfDriver | 16384 |  |
|  | ExcludePlayerVehicleIfPassenger | 32768 |  |
|  | ExcludePlayerVehicle | 49152 |  |
|  | ExcludePlayerPed | 65536 |  |
|  | ExcludePoliceCars | 131072 |  |
|  | ExcludeAmbulances | 262144 |  |
|  | ExcludeFiretrucks | 524288 |  |
|  | ExcludeEmergencyVehicles | 917504 |  |

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.