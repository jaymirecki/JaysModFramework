# Game.DisableAutomaticRespawn Property

﻿Game.DisableAutomaticRespawn Property 

|  |  |  |
| --- | --- | --- |
| GameDisableAutomaticRespawn Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets a value indicating whether automatic respawns are disabled, allowing plugins to implement custom respawn systems.

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
public static bool DisableAutomaticRespawn { get; set; }
```

```
Public Shared Property DisableAutomaticRespawn As Boolean
	Get
	Set
```

```
public:
static property bool DisableAutomaticRespawn {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if automatic respawns are disabled. otherwise, false. Respawns the player if set to false and the player is dead.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.