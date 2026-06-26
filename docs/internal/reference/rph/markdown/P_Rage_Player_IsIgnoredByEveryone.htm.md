# Player.IsIgnoredByEveryone Property

﻿Player.IsIgnoredByEveryone Property 

|  |  |  |
| --- | --- | --- |
| PlayerIsIgnoredByEveryone Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets a value indicating whether this player is ignored by everyone.

If the player is ignored, [Ped](T_Rage_Ped.htm)s will still react to the player, but will not fire.

Does not prevent the player from getting a wanted level.

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
public bool IsIgnoredByEveryone { get; set; }
```

```
Public Property IsIgnoredByEveryone As Boolean
	Get
	Set
```

```
public:
property bool IsIgnoredByEveryone {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this player is ignored by everyone; otherwise false.

See Also

#### Reference

[Player Class](T_Rage_Player.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.