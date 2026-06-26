# Game.IsPaused Property

﻿Game.IsPaused Property 

|  |  |  |
| --- | --- | --- |
| GameIsPaused Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets whether the game is paused.

The game cannot be paused in certain cases, eg. when the console is open.

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
public static bool IsPaused { get; set; }
```

```
Public Shared Property IsPaused As Boolean
	Get
	Set
```

```
public:
static property bool IsPaused {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if the game is paused; otherwise, false.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.