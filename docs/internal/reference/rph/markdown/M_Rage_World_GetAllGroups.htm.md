# World.GetAllGroups Method

﻿World.GetAllGroups Method 

|  |  |  |
| --- | --- | --- |
| WorldGetAllGroups Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets all currently existing [Group](T_Rage_Group.htm)s.

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
public static Group[] GetAllGroups()
```

```
Public Shared Function GetAllGroups As Group()
```

```
public:
static array<Group^>^ GetAllGroups()
```

#### Return Value

Type: [Group](T_Rage_Group.htm)  
An array of all currently existing [Group](T_Rage_Group.htm)s.

Remarks

This method only returns valid instances, so it is not necessary to validate the peds before calling their members, unless the fiber it was called on has yielded since the call.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.