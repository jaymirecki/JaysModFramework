# Vehicle.IsLockedForPlayer Method

﻿Vehicle.IsLockedForPlayer Method 

|  |  |  |
| --- | --- | --- |
| VehicleIsLockedForPlayer Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether this vehicle is locked for the specified [Player](T_Rage_Player.htm).

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
public bool IsLockedForPlayer(
	Player player
)
```

```
Public Function IsLockedForPlayer ( 
	player As Player
) As Boolean
```

```
public:
bool IsLockedForPlayer(
	Player^ player
)
```

#### Parameters

player
:   Type: [RagePlayer](T_Rage_Player.htm)  
    The player to get the lock status for.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
Returns true of this vehicle is locked for the specified [Player](T_Rage_Player.htm); otherwise, returns false

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.