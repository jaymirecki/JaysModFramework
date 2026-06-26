# Ped.BlockPermanentEvents Property

﻿Ped.BlockPermanentEvents Property 

|  |  |  |
| --- | --- | --- |
| PedBlockPermanentEvents Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets whether permanent events are blocked for this [Ped](T_Rage_Ped.htm).

If permanent events are blocked, this [Ped](T_Rage_Ped.htm) will only do as it's told, and won't flee when shot at, etc.

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
public bool BlockPermanentEvents { set; }
```

```
Public WriteOnly Property BlockPermanentEvents As Boolean
	Set
```

```
public:
property bool BlockPermanentEvents {
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if permanent events are blocked; otherwise false.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.