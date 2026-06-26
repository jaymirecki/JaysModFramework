# InternetTime.GetCurrentDateTime Method

﻿InternetTime.GetCurrentDateTime Method 

|  |  |  |
| --- | --- | --- |
| InternetTimeGetCurrentDateTime Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the current date and time from the internet.

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
public static DateTime GetCurrentDateTime()
```

```
Public Shared Function GetCurrentDateTime As DateTime
```

```
public:
static DateTime GetCurrentDateTime()
```

#### Return Value

Type: [DateTime](http://msdn2.microsoft.com/en-us/library/03ybds8y)  
A [DateTime](http://msdn2.microsoft.com/en-us/library/03ybds8y) representing the current time in UTC.

Remarks

The time server can only be accessed once every five seconds. If less than five seconds have passed since the last call to GetCurrentDateTime(), the time will be inferred from the last time returned. Note, that this limit is enforced across plugins.

See Also

#### Reference

[InternetTime Class](T_Rage_InternetTime.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.