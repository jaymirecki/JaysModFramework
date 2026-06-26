# Group Methods

﻿Group Methods

|  |  |  |
| --- | --- | --- |
| Group Methods | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [Group](T_Rage_Group.htm) type exposes the following members.

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [AddMember](M_Rage_Group_AddMember.htm) | Adds the specified [Ped](T_Rage_Ped.htm) to this group.  If this is the group's first member, it will become the leader. A group cannot be leaderless. |
| Public method | [Delete](M_Rage_Group_Delete.htm) | Deletes this group. |
| Public method | [Equals(Group)](M_Rage_Group_Equals.htm) | Indicates whether this instance equals the specified [Group](T_Rage_Group.htm) instance. |
| Public method | [Equals(IHandleable)](M_Rage_Group_Equals_1.htm) | Indicates whether this instance equals the specified [IHandleable](T_Rage_IHandleable.htm) instance. |
| Public method | [IsMember](M_Rage_Group_IsMember.htm) | Determines whether the specified [Ped](T_Rage_Ped.htm) is a member of this group. |
| Public method | [IsValid](M_Rage_Group_IsValid.htm) | Determines whether this instance still represents an existing entity within the game world. Calls to an invalid instance is illegal and will result in an exception. |
| Public method | [RemoveMember](M_Rage_Group_RemoveMember.htm) | Removes the specified [Ped](T_Rage_Ped.htm) from this group. The [Ped](T_Rage_Ped.htm) must be a member of this group. |
| Public method | [SetPedMemberVehicleSeatIndex](M_Rage_Group_SetPedMemberVehicleSeatIndex.htm) | Sets the index of the vehicle seat the specified member will use when the group enters a vehicle. |

[Top](#mainBody)

See Also

#### Reference

[Group Class](T_Rage_Group.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.