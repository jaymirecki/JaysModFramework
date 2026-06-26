# Group.AddMember Method

﻿Group.AddMember Method 

|  |  |  |
| --- | --- | --- |
| GroupAddMember Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Adds the specified [Ped](T_Rage_Ped.htm) to this group.

If this is the group's first member, it will become the leader. A group cannot be leaderless.

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
public void AddMember(
	Ped ped
)
```

```
Public Sub AddMember ( 
	ped As Ped
)
```

```
public:
void AddMember(
	Ped^ ped
)
```

#### Parameters

ped
:   Type: [RagePed](T_Rage_Ped.htm)  
    The [Ped](T_Rage_Ped.htm).

See Also

#### Reference

[Group Class](T_Rage_Group.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.