# Game.SetRelationshipBetweenRelationshipGroups Method

﻿Game.SetRelationshipBetweenRelationshipGroups Method 

|  |  |  |
| --- | --- | --- |
| GameSetRelationshipBetweenRelationshipGroups Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets the relationship between the specified relationship groups.

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
public static void SetRelationshipBetweenRelationshipGroups(
	RelationshipGroup sourceGroup,
	RelationshipGroup targetGroup,
	Relationship relationship
)
```

```
Public Shared Sub SetRelationshipBetweenRelationshipGroups ( 
	sourceGroup As RelationshipGroup,
	targetGroup As RelationshipGroup,
	relationship As Relationship
)
```

```
public:
static void SetRelationshipBetweenRelationshipGroups(
	RelationshipGroup sourceGroup, 
	RelationshipGroup targetGroup, 
	Relationship relationship
)
```

#### Parameters

sourceGroup
:   Type: [RageRelationshipGroup](T_Rage_RelationshipGroup.htm)  
    The source group.

targetGroup
:   Type: [RageRelationshipGroup](T_Rage_RelationshipGroup.htm)  
    The target group.

relationship
:   Type: [RageRelationship](T_Rage_Relationship.htm)  
    The relationship.

Examples

The following example makes the group "COP" hate the group "CRIMINAL", but not "CRIMINAL" hate "COP".

[Copy](# "Copy")

```
Game.SetRelationshipBetweenRelationshipGroups("COP", "CRIMINAL", Relationship.Hate);
```

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.