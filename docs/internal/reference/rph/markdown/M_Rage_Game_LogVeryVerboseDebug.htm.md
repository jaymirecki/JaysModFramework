# Game.LogVeryVerboseDebug Method

﻿Game.LogVeryVerboseDebug Method 

|  |  |  |
| --- | --- | --- |
| GameLogVeryVerboseDebug Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Logs the specified text to the RAGE Plugin Hook log file, if the current logging verbosity setting is equal to, or greater than [!:LoggingVerbosity::VeryVerbose].

When the calling [Assembly](http://msdn2.microsoft.com/en-us/library/xbe1wdx9) is not compiled in DEBUG mode, calls to this method will not be compiled.

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
[ConditionalAttribute("DEBUG")]
public static void LogVeryVerboseDebug(
	string text
)
```

```
<ConditionalAttribute("DEBUG")>
Public Shared Sub LogVeryVerboseDebug ( 
	text As String
)
```

```
public:
[ConditionalAttribute(L"DEBUG")]
static void LogVeryVerboseDebug(
	String^ text
)
```

#### Parameters

text
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The text to log.

Remarks

See [LogTrivialDebug(String)](M_Rage_Game_LogTrivialDebug.htm) for an example.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.