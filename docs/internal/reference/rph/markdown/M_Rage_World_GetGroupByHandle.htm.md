# World.GetGroupByHandle Method

﻿World.GetGroupByHandle Method 

|  |  |  |
| --- | --- | --- |
| WorldGetGroupByHandle Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets an existing [Group](T_Rage_Group.htm) from the specified handle.

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
public static Group GetGroupByHandle(
	PoolHandle handle
)
```

```
Public Shared Function GetGroupByHandle ( 
	handle As PoolHandle
) As Group
```

```
public:
static Group^ GetGroupByHandle(
	PoolHandle handle
)
```

#### Parameters

handle
:   Type: [RagePoolHandle](T_Rage_PoolHandle.htm)  
    The handle of the group.

#### Return Value

Type: [Group](T_Rage_Group.htm)  
An instance of [Group](T_Rage_Group.htm) representing the specified handle, or null if the group doesn't exist.

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentException](http://msdn2.microsoft.com/en-us/library/3w1b3114) | Thrown if the specified handle does not represent a group. |

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.