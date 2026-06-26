# ISpatial Interface

﻿ISpatial Interface

|  |  |  |
| --- | --- | --- |
| ISpatial Interface | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents an object that has a position.

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
public interface ISpatial
```

```
Public Interface ISpatial
```

```
public interface class ISpatial
```

The ISpatial type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Position](P_Rage_ISpatial_Position.htm) | Gets or sets the position of this instance. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [DistanceTo(ISpatial)](M_Rage_ISpatial_DistanceTo.htm) | Gets the distance from this instance to the specified ISpatial instance. |
| Public method | [DistanceTo(Vector3)](M_Rage_ISpatial_DistanceTo_1.htm) | Gets the distance from this instance to the specified position. |
| Public method | [DistanceTo2D(ISpatial)](M_Rage_ISpatial_DistanceTo2D.htm) | Gets the distance from this instance to the specified ISpatial instance. |
| Public method | [DistanceTo2D(Vector3)](M_Rage_ISpatial_DistanceTo2D_1.htm) | Gets the distance from this instance to the specified position. |
| Public method | [TravelDistanceTo(ISpatial)](M_Rage_ISpatial_TravelDistanceTo.htm) | Gets the distance from this instance to the specified ISpatial instance, if using the road system. |
| Public method | [TravelDistanceTo(Vector3)](M_Rage_ISpatial_TravelDistanceTo_1.htm) | Gets the distance from this instance to the specified position, if using the road system. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.