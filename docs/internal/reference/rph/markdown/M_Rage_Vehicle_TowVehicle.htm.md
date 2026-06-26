# Vehicle.TowVehicle Method

﻿Vehicle.TowVehicle Method 

|  |  |  |
| --- | --- | --- |
| VehicleTowVehicle Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Attaches a [Vehicle](T_Rage_Vehicle.htm) to the towing device of this [Vehicle](T_Rage_Vehicle.htm).

This [Vehicle](T_Rage_Vehicle.htm) must have a towing device.

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
public void TowVehicle(
	Vehicle vehicle,
	bool front
)
```

```
Public Sub TowVehicle ( 
	vehicle As Vehicle,
	front As Boolean
)
```

```
public:
void TowVehicle(
	Vehicle^ vehicle, 
	bool front
)
```

#### Parameters

vehicle
:   Type: [RageVehicle](T_Rage_Vehicle.htm)  
    The [Vehicle](T_Rage_Vehicle.htm) to tow.

front
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If true, the hook will be attached to the front of the specified vehicle; otherwise, the rear.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.