# Debug.IsAttached Property

﻿Debug.IsAttached Property 

|  |  |  |
| --- | --- | --- |
| DebugIsAttached Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a value indicating whether a debugger is attached to this instance of the game.

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
public static bool IsAttached {
	[ConditionalAttribute("DEBUG")]
	get;
 }
```

```
Public Shared ReadOnly Property IsAttached As Boolean
	<ConditionalAttribute("DEBUG")>
	Get
```

```
public:
static property bool IsAttached {
	[ConditionalAttribute(L"DEBUG")]
	bool get ();
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  

[Missing <value> documentation for "P:Rage.Debug.IsAttached"]

Remarks

Calls to this method are only compiled when your plugin is compiled in DEBUG mode.

See Also

#### Reference

[Debug Class](T_Rage_Debug.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.