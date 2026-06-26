# RelationshipGroup.Equality Operator

﻿RelationshipGroup.Equality Operator 

|  |  |  |
| --- | --- | --- |
| RelationshipGroupEquality Operator | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether the the first [RelationshipGroup](T_Rage_RelationshipGroup.htm) instance represents the same blip as the second [RelationshipGroup](T_Rage_RelationshipGroup.htm) instance.

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
	RelationshipGroup left,
	RelationshipGroup right
)
```

```
Public Shared Operator = ( 
	left As RelationshipGroup,
	right As RelationshipGroup
) As Boolean
```

```
public:
static bool operator ==(
	RelationshipGroup left, 
	RelationshipGroup right
)
```

#### Parameters

left
:   Type: [RageRelationshipGroup](T_Rage_RelationshipGroup.htm)  
    The first [RelationshipGroup](T_Rage_RelationshipGroup.htm) instance.

right
:   Type: [RageRelationshipGroup](T_Rage_RelationshipGroup.htm)  
    The first [RelationshipGroup](T_Rage_RelationshipGroup.htm) instance.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if the first instance represents the same blip as the second instance; otherwise, false.

See Also

#### Reference

[RelationshipGroup Structure](T_Rage_RelationshipGroup.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.