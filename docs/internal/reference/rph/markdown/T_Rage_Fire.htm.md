# Fire Class

﻿Fire Class

|  |  |  |
| --- | --- | --- |
| Fire Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents a fire.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageFire  
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
public class Fire : ISpatial, IDeletable
```

```
Public Class Fire
	Implements ISpatial, IDeletable
```

```
public ref class Fire : ISpatial, IDeletable
```

The Fire type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [DesiredBurnDuration](P_Rage_Fire_DesiredBurnDuration.htm) | Gets or sets the desired burn duration. |
| Public property | [ElapsedBurnDuration](P_Rage_Fire_ElapsedBurnDuration.htm) | Gets or sets how long this fire has been burning for. |
| Public property | [Offset](P_Rage_Fire_Offset.htm) | Gets or sets the position of this instance.  If [ParentEntity](P_Rage_Fire_ParentEntity.htm) is null, this property has the same value as [Position](P_Rage_Fire_Position.htm); the position is in world space; otherwise it is relative to the parent entity. |
| Public property | [OwningEntity](P_Rage_Fire_OwningEntity.htm) | Gets or sets the entity this fire belongs to.  Damage inflicted by fires is attributed to the owner. |
| Public property | [ParentEntity](P_Rage_Fire_ParentEntity.htm) | Gets the entity this fire is attached to. |
| Public property | [Position](P_Rage_Fire_Position.htm) | Gets or sets the position of this instance. |
| Public property | [SpreadRadius](P_Rage_Fire_SpreadRadius.htm) | Gets or sets how far the fire spreads. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Delete](M_Rage_Fire_Delete.htm) | Deletes this instance.  Any call to a non-existent instance is invalid and will cause an exception. |
| Public method | [DistanceTo(ISpatial)](M_Rage_Fire_DistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. |
| Public method | [DistanceTo(Vector3)](M_Rage_Fire_DistanceTo_1.htm) | Gets the distance from this instance to the specified position. |
| Public method | [DistanceTo2D(ISpatial)](M_Rage_Fire_DistanceTo2D.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. |
| Public method | [DistanceTo2D(Vector3)](M_Rage_Fire_DistanceTo2D_1.htm) | Gets the distance from this instance to the specified position. |
| Public method | [IsValid](M_Rage_Fire_IsValid.htm) | Determines whether this instance still represents an existing fire within the game world. Calls to an invalid instance is illegal and will result in an exception. |
| Public method | [TravelDistanceTo(ISpatial)](M_Rage_Fire_TravelDistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance, if using the road system. |
| Public method | [TravelDistanceTo(Vector3)](M_Rage_Fire_TravelDistanceTo_1.htm) | Gets the distance from this instance to the specified position, if using the road system. |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [(Fire to Boolean)](M_Rage_Fire_op_Implicit.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

[RageISpatial](T_Rage_ISpatial.htm)

[RageIDeletable](T_Rage_IDeletable.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.