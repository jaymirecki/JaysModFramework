# Group.Equality Operator

﻿Group.Equality Operator 

|  |  |  |
| --- | --- | --- |
| GroupEquality Operator | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether the the first [Group](T_Rage_Group.htm) instance represents the same Group as the second [Group](T_Rage_Group.htm) instance.

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
public static bool operator ==(
	Group left,
	Group right
)
```

```
Public Shared Operator = ( 
	left As Group,
	right As Group
) As Boolean
```

```
public:
static bool operator ==(
	Group^ left, 
	Group^ right
)
```

#### Parameters

left
:   Type: [RageGroup](T_Rage_Group.htm)  
    The first [Group](T_Rage_Group.htm) instance.

right
:   Type: [RageGroup](T_Rage_Group.htm)  
    The first [Group](T_Rage_Group.htm) instance.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if the first instance represents the same Group as the second instance; otherwise, false.

See Also

#### Reference

[Group Class](T_Rage_Group.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.