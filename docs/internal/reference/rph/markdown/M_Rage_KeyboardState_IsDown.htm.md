# KeyboardState.IsDown Method

﻿KeyboardState.IsDown Method 

|  |  |  |
| --- | --- | --- |
| KeyboardStateIsDown Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether the specified key is down.

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
public bool IsDown(
	Keys key
)
```

```
Public Function IsDown ( 
	key As Keys
) As Boolean
```

```
public:
bool IsDown(
	Keys key
)
```

#### Parameters

key
:   Type: [System.Windows.FormsKeys](http://msdn2.microsoft.com/en-us/library/xy8ebtbf)  
    The key to check.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
Returns true if the specified key is down; otherwise, returns false.

See Also

#### Reference

[KeyboardState Class](T_Rage_KeyboardState.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.