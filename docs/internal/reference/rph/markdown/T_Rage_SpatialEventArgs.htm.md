# SpatialEventArgs Class

﻿SpatialEventArgs Class

|  |  |  |
| --- | --- | --- |
| SpatialEventArgs Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Provides data for spatial events.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemEventArgs](http://msdn2.microsoft.com/en-us/library/118wxtk3)  
    RageSpatialEventArgs  
      [RagePedRunOverEventArgs](T_Rage_PedRunOverEventArgs.htm)  
      [RagePedShotEventArgs](T_Rage_PedShotEventArgs.htm)  
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
public abstract class SpatialEventArgs : EventArgs
```

```
<SerializableAttribute>
Public MustInherit Class SpatialEventArgs
	Inherits EventArgs
```

```
[SerializableAttribute]
public ref class SpatialEventArgs abstract : public EventArgs
```

The SpatialEventArgs type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [SpatialEventArgs](M_Rage_SpatialEventArgs__ctor.htm) | Initializes a new instance of the SpatialEventArgs class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Position](P_Rage_SpatialEventArgs_Position.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.