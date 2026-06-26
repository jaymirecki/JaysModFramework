# EnterVehicleFlags Enumeration

﻿EnterVehicleFlags Enumeration

|  |  |  |
| --- | --- | --- |
| EnterVehicleFlags Enumeration | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Flags for the [!:TaskInvoker::EnterVehicle] task.

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
[FlagsAttribute]
public enum EnterVehicleFlags
```

```
<FlagsAttribute>
Public Enumeration EnterVehicleFlags
```

```
[FlagsAttribute]
public enum class EnterVehicleFlags
```

Members

|  | Member name | Value | Description |
| --- | --- | --- | --- |
|  | None | 0 |  |
|  | WarpTo | 2 |  |
|  | AllowJacking | 8 |  |
|  | WarpIn | 16 |  |
|  | EnterFromOppositeSide | 262144 |  |
|  | AbortAfterOpeningDoor | 524288 | **Obsolete.** |
|  | DoNotEnter | 524288 |  |

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.