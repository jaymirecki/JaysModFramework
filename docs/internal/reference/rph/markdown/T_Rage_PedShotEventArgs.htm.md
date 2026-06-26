# PedShotEventArgs Class

﻿PedShotEventArgs Class

|  |  |  |
| --- | --- | --- |
| PedShotEventArgs Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Provides data for events of peds getting shot.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemEventArgs](http://msdn2.microsoft.com/en-us/library/118wxtk3)  
    [RageSpatialEventArgs](T_Rage_SpatialEventArgs.htm)  
      RagePedShotEventArgs  
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
public sealed class PedShotEventArgs : SpatialEventArgs
```

```
<SerializableAttribute>
Public NotInheritable Class PedShotEventArgs
	Inherits SpatialEventArgs
```

```
[SerializableAttribute]
public ref class PedShotEventArgs sealed : public SpatialEventArgs
```

The PedShotEventArgs type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [PedShotEventArgs](M_Rage_PedShotEventArgs__ctor.htm) | Initializes a new instance of the PedShotEventArgs class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Position](P_Rage_SpatialEventArgs_Position.htm) | (Inherited from [SpatialEventArgs](T_Rage_SpatialEventArgs.htm).) |
| Public property | [Shooter](P_Rage_PedShotEventArgs_Shooter.htm) |  |
| Public property | [Victim](P_Rage_PedShotEventArgs_Victim.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.