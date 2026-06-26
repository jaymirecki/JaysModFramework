# IRotatable Interface

﻿IRotatable Interface

|  |  |  |
| --- | --- | --- |
| IRotatable Interface | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents an object that can be rotated.

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
public interface IRotatable
```

```
Public Interface IRotatable
```

```
public interface class IRotatable
```

The IRotatable type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Direction](P_Rage_IRotatable_Direction.htm) | Gets or sets the direction of this instance. |
| Public property | [Orientation](P_Rage_IRotatable_Orientation.htm) | Gets or sets the orientation of this instance. |
| Public property | [Quaternion](P_Rage_IRotatable_Quaternion.htm) | **Obsolete.**  Gets or sets the quaternion of this instance. |
| Public property | [Rotation](P_Rage_IRotatable_Rotation.htm) | Gets or sets the rotation of this instance. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Face(ISpatial)](M_Rage_IRotatable_Face.htm) | Sets the orientation of this instance to face the specified [ISpatial](T_Rage_ISpatial.htm). |
| Public method | [Face(Vector3)](M_Rage_IRotatable_Face_1.htm) | Sets the orientation of this instance to face the specified position. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.