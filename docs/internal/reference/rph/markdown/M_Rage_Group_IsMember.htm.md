# Group.IsMember Method

﻿Group.IsMember Method 

|  |  |  |
| --- | --- | --- |
| GroupIsMember Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether the specified [Ped](T_Rage_Ped.htm) is a member of this group.

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
public bool IsMember(
	Ped ped
)
```

```
Public Function IsMember ( 
	ped As Ped
) As Boolean
```

```
public:
bool IsMember(
	Ped^ ped
)
```

#### Parameters

ped
:   Type: [RagePed](T_Rage_Ped.htm)  
    The [Ped](T_Rage_Ped.htm) to check whether is a member of this group.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
Returns true if the specified [Ped](T_Rage_Ped.htm) is a member of this group; otherwise, returns false.

See Also

#### Reference

[Group Class](T_Rage_Group.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.