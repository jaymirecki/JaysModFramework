# Entity.IsDead Property

﻿Entity.IsDead Property 

|  |  |  |
| --- | --- | --- |
| EntityIsDead Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a value indicating whether this instance is dead.

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
public bool IsDead { get; }
```

```
Public ReadOnly Property IsDead As Boolean
	Get
```

```
public:
property bool IsDead {
	bool get ();
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this instance is dead; otherwise, false.

Remarks

Different types of entities are considered dead under different circumstances.

* [Ped](T_Rage_Ped.htm)s are considered dead when their [!:Rage::Ped::Health] drops below their fatal injury threshold value (See [!:Rage::Ped::FatalInjuryThreshold]).
* [Vehicle](T_Rage_Vehicle.htm)s are considered dead when they're specifically marked as such (Eg. after going into water).
* Any other type is considered dead when their health drops below 0.001f.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.