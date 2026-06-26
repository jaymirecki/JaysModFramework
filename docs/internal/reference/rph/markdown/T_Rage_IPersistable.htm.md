# IPersistable Interface

﻿IPersistable Interface

|  |  |  |
| --- | --- | --- |
| IPersistable Interface | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents an object that can become persistent within the game world. Persistent objects will not be removed automatically during clean ups.

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
public interface IPersistable
```

```
Public Interface IPersistable
```

```
public interface class IPersistable
```

The IPersistable type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [IsPersistent](P_Rage_IPersistable_IsPersistent.htm) | Gets or sets a value indicating whether this instance is persistent within the game world. Persistent instances will not be removed automatically during clean ups. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Dismiss](M_Rage_IPersistable_Dismiss.htm) | If this instance is marked as persistent, makes the entity non-persistent. Non-persistent entities will be deleted from the game world during clean ups.  This is equivalent to setting IsPersistent to false. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.