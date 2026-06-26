# Game.GetScriptGlobalVariableAddress Method

﻿Game.GetScriptGlobalVariableAddress Method 

|  |  |  |
| --- | --- | --- |
| GameGetScriptGlobalVariableAddress Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the address of the script global variable with the specified id.

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
public static IntPtr GetScriptGlobalVariableAddress(
	int globalId
)
```

```
Public Shared Function GetScriptGlobalVariableAddress ( 
	globalId As Integer
) As IntPtr
```

```
public:
static IntPtr GetScriptGlobalVariableAddress(
	int globalId
)
```

#### Parameters

globalId
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The global identifier.

#### Return Value

Type: [IntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8)  
An [IntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8) representing the address of the global variable.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.