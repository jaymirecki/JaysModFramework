# Game.AllocateMemory Method

﻿Game.AllocateMemory Method 

|  |  |  |
| --- | --- | --- |
| GameAllocateMemory Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Allocates a block of memory of the specified size using VirtualAlloc.

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
public static IntPtr AllocateMemory(
	long size
)
```

```
Public Shared Function AllocateMemory ( 
	size As Long
) As IntPtr
```

```
public:
static IntPtr AllocateMemory(
	long long size
)
```

#### Parameters

size
:   Type: [SystemInt64](http://msdn2.microsoft.com/en-us/library/6yy583ek)  
    The amount of bytes to allocate.

#### Return Value

Type: [IntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8)  
A [IntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8) representing the address of the allocated memory.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.