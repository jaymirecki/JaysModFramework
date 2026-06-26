# RelationshipGroup.SetRelationshipWith Method

﻿RelationshipGroup.SetRelationshipWith Method 

|  |  |  |
| --- | --- | --- |
| RelationshipGroupSetRelationshipWith Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets the relationship this group has with the specified relationship group.

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
public void SetRelationshipWith(
	RelationshipGroup group,
	Relationship relationship
)
```

```
Public Sub SetRelationshipWith ( 
	group As RelationshipGroup,
	relationship As Relationship
)
```

```
public:
void SetRelationshipWith(
	RelationshipGroup group, 
	Relationship relationship
)
```

#### Parameters

group
:   Type: [RageRelationshipGroup](T_Rage_RelationshipGroup.htm)  
    The group to set the relationship with.

relationship
:   Type: [RageRelationship](T_Rage_Relationship.htm)  
    The relationship this group has with the other.

Examples

The following example makes the group "COP" hate the group "CRIMINAL", but not "CRIMINAL" hate "COP".

[Copy](# "Copy")

```
RelationshipGroup("COP").SetRelationshipWith("CRIMINAL", Relationship.Hate);
```

To make both groups hate each other, the relationship must be set on both.

[Copy](# "Copy")

```
RelationshipGroup("COP").SetRelationshipWith("CRIMINAL", Relationship.Hate);
RelationshipGroup("CRIMINAL").SetRelationshipWith("COP", Relationship.Hate);
```

See Also

#### Reference

[RelationshipGroup Structure](T_Rage_RelationshipGroup.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.