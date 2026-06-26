# Group Class

﻿Group Class

|  |  |  |
| --- | --- | --- |
| Group Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents a group of [Ped](T_Rage_Ped.htm).

There can be up to 16 groups at any given time.

Empty groups are automatically deleted.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageGroup  
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
public sealed class Group : IHandleable
```

```
Public NotInheritable Class Group
	Implements IHandleable
```

```
public ref class Group sealed : IHandleable
```

The Group type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [Group](M_Rage_Group__ctor.htm) | Initializes a new instance of the Group class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Count](P_Rage_Group_Count.htm) | Gets the number of members in this group. |
| Public property | [DissolveDistance](P_Rage_Group_DissolveDistance.htm) | Sets the distance, in meters, at which members will automatically be removed from the group. |
| Public property | [Formation](P_Rage_Group_Formation.htm) |  |
| Public property | [Handle](P_Rage_Group_Handle.htm) | Gets the handle of this instance. Used to identify the instance within its pool. |
| Public property | [Leader](P_Rage_Group_Leader.htm) | Gets or sets the leader of this group. When setting, if the specified [Ped](T_Rage_Ped.htm) is not a member of this group, it will become a member. |
| Public property | [Members](P_Rage_Group_Members.htm) | Gets the members of this group. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [AddMember](M_Rage_Group_AddMember.htm) | Adds the specified [Ped](T_Rage_Ped.htm) to this group.  If this is the group's first member, it will become the leader. A group cannot be leaderless. |
| Public method | [Delete](M_Rage_Group_Delete.htm) | Deletes this group. |
| Public method | [Equals(Group)](M_Rage_Group_Equals.htm) | Indicates whether this instance equals the specified Group instance. |
| Public method | [Equals(IHandleable)](M_Rage_Group_Equals_1.htm) | Indicates whether this instance equals the specified [IHandleable](T_Rage_IHandleable.htm) instance. |
| Public method | [IsMember](M_Rage_Group_IsMember.htm) | Determines whether the specified [Ped](T_Rage_Ped.htm) is a member of this group. |
| Public method | [IsValid](M_Rage_Group_IsValid.htm) | Determines whether this instance still represents an existing entity within the game world. Calls to an invalid instance is illegal and will result in an exception. |
| Public method | [RemoveMember](M_Rage_Group_RemoveMember.htm) | Removes the specified [Ped](T_Rage_Ped.htm) from this group. The [Ped](T_Rage_Ped.htm) must be a member of this group. |
| Public method | [SetPedMemberVehicleSeatIndex](M_Rage_Group_SetPedMemberVehicleSeatIndex.htm) | Sets the index of the vehicle seat the specified member will use when the group enters a vehicle. |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [Equality](M_Rage_Group_op_Equality.htm) | Determines whether the the first Group instance represents the same Group as the second Group instance. |
| Public operatorStatic member | [(Group to Boolean)](M_Rage_Group_op_Implicit.htm) |  |
| Public operatorStatic member | [Inequality](M_Rage_Group_op_Inequality.htm) | Determines whether the the first Group instance represents a different Group than the second Group instance. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.