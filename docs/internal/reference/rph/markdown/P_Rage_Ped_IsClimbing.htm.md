# Ped.IsClimbing Property

﻿Ped.IsClimbing Property 

|  |  |  |
| --- | --- | --- |
| PedIsClimbing Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a value indicating whether this [Ped](T_Rage_Ped.htm) is currently climbing.

A [Ped](T_Rage_Ped.htm) is considered climbing if performing one of the following actions.

* Climbing up.
* Vaulting.
* Stepping up.
* Stepping over.
* Climbing a ladder.

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
public bool IsClimbing { get; }
```

```
Public ReadOnly Property IsClimbing As Boolean
	Get
```

```
public:
property bool IsClimbing {
	bool get ();
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this [Ped](T_Rage_Ped.htm) is currently climbing; otherwise, false.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.