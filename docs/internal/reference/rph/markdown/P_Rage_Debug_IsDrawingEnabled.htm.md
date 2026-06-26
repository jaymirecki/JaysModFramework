# Debug.IsDrawingEnabled Property

﻿Debug.IsDrawingEnabled Property 

|  |  |  |
| --- | --- | --- |
| DebugIsDrawingEnabled Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a value indicating whether calls made to the drawing methods of this class shouldn't be ignored.

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
public static bool IsDrawingEnabled { get; set; }
```

```
Public Shared Property IsDrawingEnabled As Boolean
	Get
	Set
```

```
public:
static property bool IsDrawingEnabled {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if calls to the drawing methods in this class should not be ignored; otherwise, false.

See Also

#### Reference

[Debug Class](T_Rage_Debug.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.