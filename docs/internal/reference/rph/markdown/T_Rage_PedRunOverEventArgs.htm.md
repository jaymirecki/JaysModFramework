# PedRunOverEventArgs Class

﻿PedRunOverEventArgs Class

|  |  |  |
| --- | --- | --- |
| PedRunOverEventArgs Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Provides data for events of peds getting run over.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemEventArgs](http://msdn2.microsoft.com/en-us/library/118wxtk3)  
    [RageSpatialEventArgs](T_Rage_SpatialEventArgs.htm)  
      RagePedRunOverEventArgs  
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
public sealed class PedRunOverEventArgs : SpatialEventArgs
```

```
<SerializableAttribute>
Public NotInheritable Class PedRunOverEventArgs
	Inherits SpatialEventArgs
```

```
[SerializableAttribute]
public ref class PedRunOverEventArgs sealed : public SpatialEventArgs
```

The PedRunOverEventArgs type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [PedRunOverEventArgs](M_Rage_PedRunOverEventArgs__ctor.htm) | Initializes a new instance of the PedRunOverEventArgs class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Ped](P_Rage_PedRunOverEventArgs_Ped.htm) |  |
| Public property | [Position](P_Rage_SpatialEventArgs_Position.htm) | (Inherited from [SpatialEventArgs](T_Rage_SpatialEventArgs.htm).) |
| Public property | [Vehicle](P_Rage_PedRunOverEventArgs_Vehicle.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.