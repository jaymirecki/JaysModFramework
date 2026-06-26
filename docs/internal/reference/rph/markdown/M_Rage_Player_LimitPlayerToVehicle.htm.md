# Player.LimitPlayerToVehicle Method

﻿Player.LimitPlayerToVehicle Method 

|  |  |  |
| --- | --- | --- |
| PlayerLimitPlayerToVehicle Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Limits the player to the specified [Vehicle](T_Rage_Vehicle.htm). The player will be unable to enter any other [Vehicle](T_Rage_Vehicle.htm).

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
public void LimitPlayerToVehicle(
	Vehicle vehicle
)
```

```
Public Sub LimitPlayerToVehicle ( 
	vehicle As Vehicle
)
```

```
public:
void LimitPlayerToVehicle(
	Vehicle^ vehicle
)
```

#### Parameters

vehicle
:   Type: [RageVehicle](T_Rage_Vehicle.htm)  
    The [Vehicle](T_Rage_Vehicle.htm) to limit the player to. If null, the limit will be removed.

See Also

#### Reference

[Player Class](T_Rage_Player.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.