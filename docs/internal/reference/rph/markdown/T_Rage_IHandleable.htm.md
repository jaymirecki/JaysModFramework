# IHandleable Interface

﻿IHandleable Interface

|  |  |  |
| --- | --- | --- |
| IHandleable Interface | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents an object in a pool.

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
public interface IHandleable : IEquatable<IHandleable>
```

```
Public Interface IHandleable
	Inherits IEquatable(Of IHandleable)
```

```
public interface class IHandleable : IEquatable<IHandleable^>
```

The IHandleable type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Handle](P_Rage_IHandleable_Handle.htm) | Gets the handle of this instance. Used to identify the instance within its pool. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [IsValid](M_Rage_IHandleable_IsValid.htm) | Determines whether this instance still represents an existing entity within the game world. Calls to an invalid instance is illegal and will result in an exception. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

[RagePoolHandle](T_Rage_PoolHandle.htm)

[RageEntity](T_Rage_Entity.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.