# Group.Leader Property

﻿Group.Leader Property 

|  |  |  |
| --- | --- | --- |
| GroupLeader Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the leader of this group. When setting, if the specified [Ped](T_Rage_Ped.htm) is not a member of this group, it will become a member.

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
public Ped Leader { get; set; }
```

```
Public Property Leader As Ped
	Get
	Set
```

```
public:
property Ped^ Leader {
	Ped^ get ();
	void set (Ped^ value);
}
```

#### Property Value

Type: [Ped](T_Rage_Ped.htm)  
The leader of this group.

See Also

#### Reference

[Group Class](T_Rage_Group.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.