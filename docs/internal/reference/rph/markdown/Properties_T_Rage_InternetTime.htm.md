# InternetTime Properties

﻿InternetTime Properties

|  |  |  |
| --- | --- | --- |
| InternetTime Properties | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [InternetTime](T_Rage_InternetTime.htm) type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public propertyStatic member | [CanAccess](P_Rage_InternetTime_CanAccess.htm) | Gets a value indicating whether the time can be retrieved right now.  The time server can only be accessed once every five seconds. If less than five seconds have passed since the last call to GetCurrentDateTime(), this property will return false. |
| Public propertyStatic member | [LastTime](P_Rage_InternetTime_LastTime.htm) | Gets the last time retrieved from the server. |
| Public propertyStatic member | [TimeSinceLastAccess](P_Rage_InternetTime_TimeSinceLastAccess.htm) | Gets the time elapsed since the time was last retrieved from the server. |

[Top](#mainBody)

See Also

#### Reference

[InternetTime Class](T_Rage_InternetTime.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.