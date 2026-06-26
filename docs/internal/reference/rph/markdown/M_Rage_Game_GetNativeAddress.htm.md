# Game.GetNativeAddress Method

﻿Game.GetNativeAddress Method 

|  |  |  |
| --- | --- | --- |
| GameGetNativeAddress Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the address of the native function with the specified name.

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
public static IntPtr GetNativeAddress(
	string name
)
```

```
Public Shared Function GetNativeAddress ( 
	name As String
) As IntPtr
```

```
public:
static IntPtr GetNativeAddress(
	String^ name
)
```

#### Parameters

name
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the native function.

#### Return Value

Type: [IntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8)  
If the native function exists, returns a [IntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8) representing the address of the native function; otherwise, returns [Zero](http://msdn2.microsoft.com/en-us/library/c61h0w61).

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.