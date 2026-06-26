# World.GetBlipByHandle Method

﻿World.GetBlipByHandle Method 

|  |  |  |
| --- | --- | --- |
| WorldGetBlipByHandle Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets an existing [Blip](T_Rage_Blip.htm) from the specified handle.

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
public static Blip GetBlipByHandle(
	PoolHandle handle
)
```

```
Public Shared Function GetBlipByHandle ( 
	handle As PoolHandle
) As Blip
```

```
public:
static Blip^ GetBlipByHandle(
	PoolHandle handle
)
```

#### Parameters

handle
:   Type: [RagePoolHandle](T_Rage_PoolHandle.htm)  
    The handle of the blip.

#### Return Value

Type: [Blip](T_Rage_Blip.htm)  
An instance of [Blip](T_Rage_Blip.htm) representing the specified handle, or null if the blip doesn't exist.

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentException](http://msdn2.microsoft.com/en-us/library/3w1b3114) | Thrown if the specified handle does not represent a blip. |

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.