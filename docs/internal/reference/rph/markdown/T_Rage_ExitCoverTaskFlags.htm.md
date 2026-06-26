# ExitCoverTaskFlags Enumeration

﻿ExitCoverTaskFlags Enumeration

|  |  |  |
| --- | --- | --- |
| ExitCoverTaskFlags Enumeration | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Flags for the [!:TaskInvoker::ExitCover] task.

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
public enum ExitCoverTaskFlags
```

```
Public Enumeration ExitCoverTaskFlags
```

```
public enum class ExitCoverTaskFlags
```

Members

|  | Member name | Value | Description |
| --- | --- | --- | --- |
|  | Simple | 1 | If this flag is specified, the ped will simply transition to standing. |
|  | AimAtPosition | 2 | If this flag is specified, the ped will transition from cover to aiming at the specified position. |
|  | TowardsTarget | 3 | If this flag is specified, the ped will take a few running steps towards the target it was taking cover from. |

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.