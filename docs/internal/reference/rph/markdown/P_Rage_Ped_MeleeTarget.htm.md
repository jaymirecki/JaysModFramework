# Ped.MeleeTarget Property

﻿Ped.MeleeTarget Property 

|  |  |  |
| --- | --- | --- |
| PedMeleeTarget Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the [Ped](T_Rage_Ped.htm) this [Ped](T_Rage_Ped.htm) is performing a melee attack against.

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
public Ped MeleeTarget { get; }
```

```
Public ReadOnly Property MeleeTarget As Ped
	Get
```

```
public:
property Ped^ MeleeTarget {
	Ped^ get ();
}
```

#### Property Value

Type: [Ped](T_Rage_Ped.htm)  
The [Ped](T_Rage_Ped.htm) this [Ped](T_Rage_Ped.htm) is performing a melee attack agianst, or null if not melee attacking.

Remarks

This does not get the [Ped](T_Rage_Ped.htm) this [Ped](T_Rage_Ped.htm) is currently fighting against; it only returns a [Ped](T_Rage_Ped.htm) while the ped is doing an active attack, like punching, kicking, etc.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.