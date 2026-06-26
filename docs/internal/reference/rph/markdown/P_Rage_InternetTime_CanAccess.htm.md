# InternetTime.CanAccess Property

﻿InternetTime.CanAccess Property 

|  |  |  |
| --- | --- | --- |
| InternetTimeCanAccess Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a value indicating whether the time can be retrieved right now.

The time server can only be accessed once every five seconds. If less than five seconds have passed since the last call to GetCurrentDateTime(), this property will return false.

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
public static bool CanAccess { get; }
```

```
Public Shared ReadOnly Property CanAccess As Boolean
	Get
```

```
public:
static property bool CanAccess {
	bool get ();
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if the time can be retrieved; otherwise, false.

See Also

#### Reference

[InternetTime Class](T_Rage_InternetTime.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.