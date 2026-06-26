# Ped.CanAttackFriendlies Property

﻿Ped.CanAttackFriendlies Property 

|  |  |  |
| --- | --- | --- |
| PedCanAttackFriendlies Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets a value indicating whether this [Ped](T_Rage_Ped.htm) can attack other [Ped](T_Rage_Ped.htm)s considered friendly to this [Ped](T_Rage_Ped.htm). Eg. [Ped](T_Rage_Ped.htm)s in the same relationship group, or that this [Ped](T_Rage_Ped.htm)'s relationship group respects.

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
public bool CanAttackFriendlies { set; }
```

```
Public WriteOnly Property CanAttackFriendlies As Boolean
	Set
```

```
public:
property bool CanAttackFriendlies {
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this [Ped](T_Rage_Ped.htm) can attack other [Ped](T_Rage_Ped.htm)s considered friendly to this [Ped](T_Rage_Ped.htm); otherwise, false.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.