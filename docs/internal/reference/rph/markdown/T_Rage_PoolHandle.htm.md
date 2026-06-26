# PoolHandle Structure

﻿PoolHandle Structure

|  |  |  |
| --- | --- | --- |
| PoolHandle Structure | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents the handle of an item in a pool.

The RAGE engine has a special array type known as a pool.  
Pools are widely used throughout RAGE games to store things like [Ped](T_Rage_Ped.htm)s, [Vehicle](T_Rage_Vehicle.htm)s, [Weapon](T_Rage_Weapon.htm)s, [Blip](T_Rage_Blip.htm)s, etc.  
Pools consist of slots, and each slot has an index ranging from 0 to the pools capacity.  
Essentially each slot has a flag that indicates whether the slot is free, and a counter. The counter is purely to avoid duplicate handles in case that same slot is reused immediately after it's freed.  
The handle is a composite number (32-bit unsigned integer) where the 24 most significant bits represent the item's index into the pool, and the last 8 bits represent the counter.  
Eg. if an item is stored at index 4 and its counter is 7, the handle would be (4 << 8) | 7 = 1031 (0x00000407).  
A handle is validated by comparing its counter to the counter in the slot indicated by the index in the handle. If the slot is occupied and the counters match, the handle is valid.
These handles are used extensively in the engine's internal scripting system. If a native function takes an entity as parameter, it is by its handle.

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
public struct PoolHandle
```

```
<SerializableAttribute>
Public Structure PoolHandle
```

```
[SerializableAttribute]
public value class PoolHandle
```

The PoolHandle type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [PoolHandle](M_Rage_PoolHandle__ctor.htm) | Initializes a new instance of the PoolHandle class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Counter](P_Rage_PoolHandle_Counter.htm) | Gets or sets the counter of this PoolHandle. |
| Public property | [Index](P_Rage_PoolHandle_Index.htm) | Gets or sets the index of this PoolHandle. |
| Public property | [IsZero](P_Rage_PoolHandle_IsZero.htm) | Gets a value indicating whether this PoolHandle is zero. |
| Public property | [Value](P_Rage_PoolHandle_Value.htm) | Gets or sets the value of this PoolHandle. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [ToString](M_Rage_PoolHandle_ToString.htm) | (Overrides [ValueTypeToString](http://msdn2.microsoft.com/en-us/library/wb77sz3h).) |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [(UInt32 to PoolHandle)](M_Rage_PoolHandle_op_Implicit_1.htm) | Converts the specified [UInt32](http://msdn2.microsoft.com/en-us/library/ctys3981) to a PoolHandle. |
| Public operatorStatic member | [(PoolHandle to UInt32)](M_Rage_PoolHandle_op_Implicit.htm) | Converts the specified PoolHandle to a [UInt32](http://msdn2.microsoft.com/en-us/library/ctys3981). |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.