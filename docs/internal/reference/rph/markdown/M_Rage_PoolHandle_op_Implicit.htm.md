# PoolHandle Implicit Conversion (PoolHandle to UInt32)

﻿PoolHandle Implicit Conversion (PoolHandle to UInt32)

|  |  |  |
| --- | --- | --- |
| PoolHandle  Conversion (PoolHandle to UInt32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Converts the specified [PoolHandle](T_Rage_PoolHandle.htm) to a [UInt32](http://msdn2.microsoft.com/en-us/library/ctys3981).

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
public static implicit operator uint (
	PoolHandle poolHandle
)
```

```
Public Shared Widening Operator CType ( 
	poolHandle As PoolHandle
) As UInteger
```

```
static implicit operator unsigned int (
	PoolHandle poolHandle
)
```

#### Parameters

poolHandle
:   Type: [RagePoolHandle](T_Rage_PoolHandle.htm)  
    The pool handle.

#### Return Value

Type: [UInt32](http://msdn2.microsoft.com/en-us/library/ctys3981)  
The result of the operator.

See Also

#### Reference

[PoolHandle Structure](T_Rage_PoolHandle.htm)

[Overload](Overload_Rage_PoolHandle_op_Implicit.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.