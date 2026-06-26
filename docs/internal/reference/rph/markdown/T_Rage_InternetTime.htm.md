# InternetTime Class

﻿InternetTime Class

|  |  |  |
| --- | --- | --- |
| InternetTime Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Class for getting the current time from the Internet.

This class uses the TIME protocol to get the current time from nist1-macon.macon.ga.us.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageInternetTime  
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
public static class InternetTime
```

```
Public NotInheritable Class InternetTime
```

```
public ref class InternetTime abstract sealed
```

The InternetTime type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public propertyStatic member | [CanAccess](P_Rage_InternetTime_CanAccess.htm) | Gets a value indicating whether the time can be retrieved right now.  The time server can only be accessed once every five seconds. If less than five seconds have passed since the last call to GetCurrentDateTime(), this property will return false. |
| Public propertyStatic member | [LastTime](P_Rage_InternetTime_LastTime.htm) | Gets the last time retrieved from the server. |
| Public propertyStatic member | [TimeSinceLastAccess](P_Rage_InternetTime_TimeSinceLastAccess.htm) | Gets the time elapsed since the time was last retrieved from the server. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [GetCurrentDateTime](M_Rage_InternetTime_GetCurrentDateTime.htm) | Gets the current date and time from the internet. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.