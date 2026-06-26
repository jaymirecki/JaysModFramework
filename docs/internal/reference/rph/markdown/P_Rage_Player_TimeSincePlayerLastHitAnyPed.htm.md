# Player.TimeSincePlayerLastHitAnyPed Property

﻿Player.TimeSincePlayerLastHitAnyPed Property 

|  |  |  |
| --- | --- | --- |
| PlayerTimeSincePlayerLastHitAnyPed Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the time since this player last hit any [Vehicle](T_Rage_Vehicle.htm) with a [Ped](T_Rage_Ped.htm).

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
public int TimeSincePlayerLastHitAnyPed { get; }
```

```
Public ReadOnly Property TimeSincePlayerLastHitAnyPed As Integer
	Get
```

```
public:
property int TimeSincePlayerLastHitAnyPed {
	int get ();
}
```

#### Property Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
The time since this player last hit any [Ped](T_Rage_Ped.htm) with a [Vehicle](T_Rage_Vehicle.htm), or -1 if this player hasn't hit any [Ped](T_Rage_Ped.htm)s.

See Also

#### Reference

[Player Class](T_Rage_Player.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.