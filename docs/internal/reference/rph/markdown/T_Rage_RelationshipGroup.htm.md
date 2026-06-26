# RelationshipGroup Structure

﻿RelationshipGroup Structure

|  |  |  |
| --- | --- | --- |
| RelationshipGroup Structure | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents a relationship group.

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
[SerializableAttribute]
public struct RelationshipGroup : IEquatable<RelationshipGroup>
```

```
<SerializableAttribute>
Public Structure RelationshipGroup
	Implements IEquatable(Of RelationshipGroup)
```

```
[SerializableAttribute]
public value class RelationshipGroup : IEquatable<RelationshipGroup>
```

The RelationshipGroup type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [RelationshipGroup](M_Rage_RelationshipGroup__ctor.htm) | Initializes a new instance of the RelationshipGroup class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public propertyStatic member | [AggressiveInvestigate](P_Rage_RelationshipGroup_AggressiveInvestigate.htm) | Gets the "AGGRESSIVE\_INVESTIGATE" relationship group. |
| Public propertyStatic member | [AmbientFriendEmpty](P_Rage_RelationshipGroup_AmbientFriendEmpty.htm) | Gets the "AmbFriendEmpty" relationship group. |
| Public propertyStatic member | [AmbientGangBallas](P_Rage_RelationshipGroup_AmbientGangBallas.htm) | Gets the "AMBIENT\_GANG\_BALLAS" relationship group. |
| Public propertyStatic member | [AmbientGangCult](P_Rage_RelationshipGroup_AmbientGangCult.htm) | Gets the "AMBIENT\_GANG\_CULT" relationship group. |
| Public propertyStatic member | [AmbientGangFamily](P_Rage_RelationshipGroup_AmbientGangFamily.htm) | Gets the "AMBIENT\_GANG\_FAMILY" relationship group. |
| Public propertyStatic member | [AmbientGangHillbilly](P_Rage_RelationshipGroup_AmbientGangHillbilly.htm) | Gets the "AMBIENT\_GANG\_HILLBILLY" relationship group. |
| Public propertyStatic member | [AmbientGangLost](P_Rage_RelationshipGroup_AmbientGangLost.htm) | Gets the "AMBIENT\_GANG\_LOST" relationship group. |
| Public propertyStatic member | [AmbientGangMarabunte](P_Rage_RelationshipGroup_AmbientGangMarabunte.htm) | Gets the "AMBIENT\_GANG\_MARABUNTE" relationship group. |
| Public propertyStatic member | [AmbientGangMexican](P_Rage_RelationshipGroup_AmbientGangMexican.htm) | Gets the "AMBIENT\_GANG\_MEXICAN" relationship group. |
| Public propertyStatic member | [AmbientGangSalva](P_Rage_RelationshipGroup_AmbientGangSalva.htm) | Gets the "AMBIENT\_GANG\_SALVA" relationship group. |
| Public propertyStatic member | [AmbientGangWeicheng](P_Rage_RelationshipGroup_AmbientGangWeicheng.htm) | Gets the "AMBIENT\_GANG\_WEICHENG" relationship group. |
| Public propertyStatic member | [Army](P_Rage_RelationshipGroup_Army.htm) | Gets the "ARMY" relationship group. |
| Public propertyStatic member | [Cop](P_Rage_RelationshipGroup_Cop.htm) | Gets the "COP" relationship group. |
| Public propertyStatic member | [Deer](P_Rage_RelationshipGroup_Deer.htm) | Gets the "DEER" relationship group. |
| Public propertyStatic member | [DomesticAnimal](P_Rage_RelationshipGroup_DomesticAnimal.htm) | Gets the "DOMESTIC\_ANIMAL" relationship group. |
| Public propertyStatic member | [FamilyFranklin](P_Rage_RelationshipGroup_FamilyFranklin.htm) | Gets the "FAMILY\_F" relationship group. |
| Public propertyStatic member | [FamilyMichael](P_Rage_RelationshipGroup_FamilyMichael.htm) | Gets the "FAMILY\_M" relationship group. |
| Public propertyStatic member | [FamilyTrevor](P_Rage_RelationshipGroup_FamilyTrevor.htm) | Gets the "FAMILY\_T" relationship group. |
| Public propertyStatic member | [Fireman](P_Rage_RelationshipGroup_Fireman.htm) | Gets the "FIREMAN" relationship group. |
| Public propertyStatic member | [Gang1](P_Rage_RelationshipGroup_Gang1.htm) | Gets the "GANG\_1" relationship group. |
| Public propertyStatic member | [Gang10](P_Rage_RelationshipGroup_Gang10.htm) | Gets the "GANG\_10" relationship group. |
| Public propertyStatic member | [Gang2](P_Rage_RelationshipGroup_Gang2.htm) | Gets the "GANG\_2" relationship group. |
| Public propertyStatic member | [Gang9](P_Rage_RelationshipGroup_Gang9.htm) | Gets the "GANG\_9" relationship group. |
| Public propertyStatic member | [GuardDog](P_Rage_RelationshipGroup_GuardDog.htm) | Gets the "GUARD\_DOG" relationship group. |
| Public property | [Hash](P_Rage_RelationshipGroup_Hash.htm) | Gets the hash of this group. |
| Public propertyStatic member | [HatesPlayer](P_Rage_RelationshipGroup_HatesPlayer.htm) | Gets the "HATES\_PLAYER" relationship group. |
| Public propertyStatic member | [Medic](P_Rage_RelationshipGroup_Medic.htm) | Gets the "MEDIC" relationship group. |
| Public property | [Name](P_Rage_RelationshipGroup_Name.htm) |  |
| Public propertyStatic member | [Player](P_Rage_RelationshipGroup_Player.htm) | Gets the "PLAYER" relationship group. |
| Public propertyStatic member | [Prisoner](P_Rage_RelationshipGroup_Prisoner.htm) | Gets the "PRISONER" relationship group. |
| Public propertyStatic member | [PrivateSecurity](P_Rage_RelationshipGroup_PrivateSecurity.htm) | Gets the "PRIVATE\_SECURITY" relationship group. |
| Public propertyStatic member | [SecurityGuard](P_Rage_RelationshipGroup_SecurityGuard.htm) | Gets the "SECURITY\_GUARD" relationship group. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [DoesRelationshipGroupExist(String)](M_Rage_RelationshipGroup_DoesRelationshipGroupExist.htm) |  |
| Public methodStatic member | [DoesRelationshipGroupExist(UInt32)](M_Rage_RelationshipGroup_DoesRelationshipGroupExist_1.htm) |  |
| Public method | [Equals](M_Rage_RelationshipGroup_Equals.htm) | Indicates whether this instance equals the specified RelationshipGroup instance. |
| Public methodCode example | [SetRelationshipWith](M_Rage_RelationshipGroup_SetRelationshipWith.htm) | Sets the relationship this group has with the specified relationship group. |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [Equality](M_Rage_RelationshipGroup_op_Equality.htm) | Determines whether the the first RelationshipGroup instance represents the same blip as the second RelationshipGroup instance. |
| Public operatorStatic member | [(String to RelationshipGroup)](M_Rage_RelationshipGroup_op_Implicit.htm) |  |
| Public operatorStatic member | [Inequality](M_Rage_RelationshipGroup_op_Inequality.htm) | Determines whether the the first RelationshipGroup instance represents a different blip than the second RelationshipGroup instance. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

[!:IEquatable{RelationshipGroup}]

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.