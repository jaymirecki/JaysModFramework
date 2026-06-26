# OperatingSystemInfo.VersionNumber Property

﻿OperatingSystemInfo.VersionNumber Property 

|  |  |  |
| --- | --- | --- |
| OperatingSystemInfoVersionNumber Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the operating system version number.

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
public static Version VersionNumber { get; }
```

```
Public Shared ReadOnly Property VersionNumber As Version
	Get
```

```
public:
static property Version^ VersionNumber {
	Version^ get ();
}
```

#### Property Value

Type: [Version](http://msdn2.microsoft.com/en-us/library/hdxyt63s)  
The operating system version number.

Remarks

If the application is launched from Visual Studio, this will return 6.2 for Windows 8.1 and Windows 10.

See Also

#### Reference

[OperatingSystemInfo Class](T_Rage_OperatingSystemInfo.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.