# Game.TerminateAllScripts Method

﻿Game.TerminateAllScripts Method 

|  |  |  |
| --- | --- | --- |
| GameTerminateAllScripts Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Terminates all scripts.

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
public static void TerminateAllScripts(
	params string[] exceptions
)
```

```
Public Shared Sub TerminateAllScripts ( 
	ParamArray exceptions As String()
)
```

```
public:
static void TerminateAllScripts(
	... array<String^>^ exceptions
)
```

#### Parameters

exceptions
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    An array of type [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf) containing the names of the scripts to not terminate.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.