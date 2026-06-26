# PoolHandle Implicit Conversion (UInt32 to PoolHandle)

﻿PoolHandle Implicit Conversion (UInt32 to PoolHandle)

|  |  |  |
| --- | --- | --- |
| PoolHandle  Conversion (UInt32 to PoolHandle) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Converts the specified [UInt32](http://msdn2.microsoft.com/en-us/library/ctys3981) to a [PoolHandle](T_Rage_PoolHandle.htm).

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
public static implicit operator PoolHandle (
	uint value
)
```

```
Public Shared Widening Operator CType ( 
	value As UInteger
) As PoolHandle
```

```
static implicit operator PoolHandle (
	unsigned int value
)
```

#### Parameters

value
:   Type: [SystemUInt32](http://msdn2.microsoft.com/en-us/library/ctys3981)  
    The 32-bit unsigned integer representing the handle.

#### Return Value

Type: [PoolHandle](T_Rage_PoolHandle.htm)  
The result of the operator.

See Also

#### Reference

[PoolHandle Structure](T_Rage_PoolHandle.htm)

[Overload](Overload_Rage_PoolHandle_op_Implicit.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.