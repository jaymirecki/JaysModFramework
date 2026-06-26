# World.TeleportLocalPlayer Method

﻿World.TeleportLocalPlayer Method 

|  |  |  |
| --- | --- | --- |
| WorldTeleportLocalPlayer Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Teleports the local player to the specified position.

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
public static void TeleportLocalPlayer(
	Vector3 position,
	bool toGround
)
```

```
Public Shared Sub TeleportLocalPlayer ( 
	position As Vector3,
	toGround As Boolean
)
```

```
public:
static void TeleportLocalPlayer(
	Vector3 position, 
	bool toGround
)
```

#### Parameters

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position to teleport the local player to.

toGround
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  

    If true, the Z component of the position will be ignored, and the player will be placed on the ground.

    Note, that this requires execution over multiple ticks! (That is, the plugin will yield during execution of this method, if this parameter is set to true>)

    If the game is paused, it be unpaused.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.