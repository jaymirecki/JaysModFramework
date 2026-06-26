# Ped.RelationshipGroup Property

﻿Ped.RelationshipGroup Property 

|  |  |  |
| --- | --- | --- |
| PedRelationshipGroup Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the relationship group of this instance.

Relationship groups indicate the acquaintance between different types of Peds.

For instance, by default CIVMALE and CIVFEMALE are set to respect each other; however, this behaviour can be changed.

CIVMALE could be set to hate CIVFEMALE, and CIVFEMALE could be set to hate CIVMALE, and all civilians would start fighting each other on side, males vs females. (Granted that they're in those respective groups, as males could certainly be added to the CIVFEMALE group.

Groups can also have different acquaintances between each other. For instance, imagine three new groups: DEVELOPER, CUSTOMER and PIRATE, where Peds in the DEVELOPER relationship group hate Peds in the PIRATE group and like (not respect) Peds in the CUSTOMER group. Peds in the PIRATE group like the Peds in the DEVELOPER group, and are neutral towards people in the CUSTOMER group. Peds in the CUSTOMER group like Peds in the DEVELOPER group and dislike Peds in the PIRATE group.

Any Ped in the DEVELOPER group will attack Peds in the PIRATE group on sight, but Peds in the PIRATE group won't attack Peds in the DEVELOPER group because they like them.

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
public RelationshipGroup RelationshipGroup { get; set; }
```

```
Public Property RelationshipGroup As RelationshipGroup
	Get
	Set
```

```
public:
property RelationshipGroup RelationshipGroup {
	RelationshipGroup get ();
	void set (RelationshipGroup value);
}
```

#### Property Value

Type: [RelationshipGroup](T_Rage_RelationshipGroup.htm)  

[Missing <value> documentation for "P:Rage.Ped.RelationshipGroup"]

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.