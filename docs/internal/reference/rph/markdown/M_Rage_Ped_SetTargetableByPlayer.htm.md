# Ped.SetTargetableByPlayer Method

﻿Ped.SetTargetableByPlayer Method 

|  |  |  |
| --- | --- | --- |
| PedSetTargetableByPlayer Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets whether this [Ped](T_Rage_Ped.htm) can be targetted.

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
public void SetTargetableByPlayer(
	Player player,
	bool value
)
```

```
Public Sub SetTargetableByPlayer ( 
	player As Player,
	value As Boolean
)
```

```
public:
void SetTargetableByPlayer(
	Player^ player, 
	bool value
)
```

#### Parameters

player
:   Type: [RagePlayer](T_Rage_Player.htm)  
    The player.

value
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    Whether this [Ped](T_Rage_Ped.htm) can be targetted by the specified [Player](T_Rage_Player.htm).

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.