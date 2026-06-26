# Player.TimeSincePlayerLastDroveOnPavement Property

﻿Player.TimeSincePlayerLastDroveOnPavement Property 

|  |  |  |
| --- | --- | --- |
| PlayerTimeSincePlayerLastDroveOnPavement Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the time since this player last drove on pavement.

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
public int TimeSincePlayerLastDroveOnPavement { get; }
```

```
Public ReadOnly Property TimeSincePlayerLastDroveOnPavement As Integer
	Get
```

```
public:
property int TimeSincePlayerLastDroveOnPavement {
	int get ();
}
```

#### Property Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
The time since this player last drove on pavement, or -1 if this player hasn't driven on pavement.

See Also

#### Reference

[Player Class](T_Rage_Player.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.