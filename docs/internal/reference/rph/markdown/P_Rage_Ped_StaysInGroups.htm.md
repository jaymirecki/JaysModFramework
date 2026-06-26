# Ped.StaysInGroups Property

﻿Ped.StaysInGroups Property 

|  |  |  |
| --- | --- | --- |
| PedStaysInGroups Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets a value indicating whether this [Ped](T_Rage_Ped.htm) will stay in its group unless explicitly removed.

If the value of this property is false, this [Ped](T_Rage_Ped.htm) will be removed from its group if it gets farther away from its leader than the [Group](T_Rage_Group.htm)'s [!:Rage::Group::DissolveDistance].

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
public bool StaysInGroups { set; }
```

```
Public WriteOnly Property StaysInGroups As Boolean
	Set
```

```
public:
property bool StaysInGroups {
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this [Ped](T_Rage_Ped.htm) will stay in its group; otherwise, false.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.