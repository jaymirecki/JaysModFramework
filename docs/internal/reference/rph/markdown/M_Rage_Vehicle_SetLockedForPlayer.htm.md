# Vehicle.SetLockedForPlayer Method

﻿Vehicle.SetLockedForPlayer Method 

|  |  |  |
| --- | --- | --- |
| VehicleSetLockedForPlayer Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets whether this vehicle is locked for the specified [Player](T_Rage_Player.htm)

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
public void SetLockedForPlayer(
	Player player,
	bool locked
)
```

```
Public Sub SetLockedForPlayer ( 
	player As Player,
	locked As Boolean
)
```

```
public:
void SetLockedForPlayer(
	Player^ player, 
	bool locked
)
```

#### Parameters

player
:   Type: [RagePlayer](T_Rage_Player.htm)  
    The player to set the lock status for.

locked
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    true to lock the vehicle for the specified player; false to unlock it.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.