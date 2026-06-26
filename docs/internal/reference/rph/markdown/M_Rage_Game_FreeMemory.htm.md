# Game.FreeMemory Method

﻿Game.FreeMemory Method 

|  |  |  |
| --- | --- | --- |
| GameFreeMemory Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Frees the memory previously allocated by [AllocateMemory(Int64)](M_Rage_Game_AllocateMemory.htm), using VirtualFree.

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
public static void FreeMemory(
	IntPtr address
)
```

```
Public Shared Sub FreeMemory ( 
	address As IntPtr
)
```

```
public:
static void FreeMemory(
	IntPtr address
)
```

#### Parameters

address
:   Type: [SystemIntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8)  
    The address returned by [AllocateMemory(Int64)](M_Rage_Game_AllocateMemory.htm).

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.