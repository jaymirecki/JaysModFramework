# Debug.AttachAndBreak Method

﻿Debug.AttachAndBreak Method 

|  |  |  |
| --- | --- | --- |
| DebugAttachAndBreak Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Prompts the user to attach a debugger to this instance of the game, then breaks.

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
public static void AttachAndBreak()
```

```
<ConditionalAttribute("DEBUG")>
Public Shared Sub AttachAndBreak
```

```
public:
[ConditionalAttribute(L"DEBUG")]
static void AttachAndBreak()
```

Remarks

Calls to this method are only compiled when your plugin is compiled in DEBUG mode.

See Also

#### Reference

[Debug Class](T_Rage_Debug.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.