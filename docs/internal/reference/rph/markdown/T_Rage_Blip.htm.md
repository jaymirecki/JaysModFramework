# Blip Class

﻿Blip Class

|  |  |  |
| --- | --- | --- |
| Blip Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents a Blip in the game world.

Blips are used to mark entities of interest in either the game world, on the radar or both.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageBlip  
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
public sealed class Blip : IHandleable, IAddressable, 
	ISpatial, IDeletable
```

```
<SerializableAttribute>
Public NotInheritable Class Blip
	Implements IHandleable, IAddressable, ISpatial, IDeletable
```

```
[SerializableAttribute]
public ref class Blip sealed : IHandleable, 
	IAddressable, ISpatial, IDeletable
```

The Blip type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [Blip(Entity)](M_Rage_Blip__ctor.htm) | Initializes a new instance of the Blip class. |
| Public method | [Blip(Vector3)](M_Rage_Blip__ctor_1.htm) | Initializes a new instance of the Blip class. |
| Public method | [Blip(Vector3, Single)](M_Rage_Blip__ctor_2.htm) | Initializes a new instance of the Blip class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Alpha](P_Rage_Blip_Alpha.htm) | Gets or sets the alpha of this Blip. |
| Public property | [Angle](P_Rage_Blip_Angle.htm) | Sets the angle of this Blip, in degrees. |
| Public property | [Color](P_Rage_Blip_Color.htm) | Gets or sets the color of this Blip. |
| Public property | [Entity](P_Rage_Blip_Entity.htm) | Gets the [Entity](T_Rage_Entity.htm) that this Blip is attached to. |
| Public property | [Handle](P_Rage_Blip_Handle.htm) | Gets the handle of this instance. Used to identify the instance within its pool. |
| Public property | [IsFriendly](P_Rage_Blip_IsFriendly.htm) |  |
| Public property | [IsRouteEnabled](P_Rage_Blip_IsRouteEnabled.htm) | Sets a value indicating whether a route to this Blip is currently active. |
| Public property | [MemoryAddress](P_Rage_Blip_MemoryAddress.htm) | Gets the memory address of this instance. |
| Public property | [Name](P_Rage_Blip_Name.htm) | Gets or sets the name of this Blip. The name is what appears in the legends list on the map. |
| Public property | [NumberLabel](P_Rage_Blip_NumberLabel.htm) | Sets the number to be shown on this blip. |
| Public property | [Order](P_Rage_Blip_Order.htm) | Sets the order of this Blip. Blip with a higher order will be drawn on top of Blips with a lower order. |
| Public property | [Position](P_Rage_Blip_Position.htm) | Gets or sets the position of this instance. |
| Public property | [RouteColor](P_Rage_Blip_RouteColor.htm) | Gets or sets the color of the route to this Blip. |
| Public property | [Scale](P_Rage_Blip_Scale.htm) | Sets the scale of this Blip. |
| Public property | [Sprite](P_Rage_Blip_Sprite.htm) | Gets or sets the sprite of this Blip. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Delete](M_Rage_Blip_Delete.htm) | Deletes this instance.  Any call to a non-existent instance is invalid and will cause an exception. |
| Public method | [DisableRoute](M_Rage_Blip_DisableRoute.htm) | Disables the current route to this Blip. |
| Public method | [DistanceTo(ISpatial)](M_Rage_Blip_DistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. |
| Public method | [DistanceTo(Vector3)](M_Rage_Blip_DistanceTo_1.htm) | Gets the distance from this instance to the specified position. |
| Public method | [DistanceTo2D(ISpatial)](M_Rage_Blip_DistanceTo2D.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance. |
| Public method | [DistanceTo2D(Vector3)](M_Rage_Blip_DistanceTo2D_1.htm) | Gets the distance from this instance to the specified position. |
| Public method | [EnableRoute](M_Rage_Blip_EnableRoute.htm) | Enables a route to this Blip with the specified color. |
| Public method | [Equals(Blip)](M_Rage_Blip_Equals.htm) | Indicates whether this instance equals the specified Blip instance. |
| Public method | [Equals(IHandleable)](M_Rage_Blip_Equals_1.htm) | Indicates whether this instance equals the specified [IHandleable](T_Rage_IHandleable.htm) instance. |
| Public method | [Flash](M_Rage_Blip_Flash.htm) | Makes Blip blip flash at the specified interval for the specified duration. |
| Public method | [IsValid](M_Rage_Blip_IsValid.htm) | Determines whether this instance still represents an existing entity within the game world. Calls to an invalid instance is illegal and will result in an exception. |
| Public method | [RemoveNumberLabel](M_Rage_Blip_RemoveNumberLabel.htm) | Removes the number label from this blip. |
| Public method | [StopFlashing](M_Rage_Blip_StopFlashing.htm) | Stops the flashing of this Blip. |
| Public method | [TravelDistanceTo(ISpatial)](M_Rage_Blip_TravelDistanceTo.htm) | Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance, if using the road system. |
| Public method | [TravelDistanceTo(Vector3)](M_Rage_Blip_TravelDistanceTo_1.htm) | Gets the distance from this instance to the specified position, if using the road system. |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [Equality](M_Rage_Blip_op_Equality.htm) | Determines whether the the first Blip instance represents the same blip as the second Blip instance. |
| Public operatorStatic member | [(Blip to Boolean)](M_Rage_Blip_op_Implicit.htm) |  |
| Public operatorStatic member | [Inequality](M_Rage_Blip_op_Inequality.htm) | Determines whether the the first Blip instance represents a different blip than the second Blip instance. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.