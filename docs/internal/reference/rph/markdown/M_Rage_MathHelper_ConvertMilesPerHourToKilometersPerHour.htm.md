# MathHelper.ConvertMilesPerHourToKilometersPerHour Method

﻿MathHelper.ConvertMilesPerHourToKilometersPerHour Method 

|  |  |  |
| --- | --- | --- |
| MathHelperConvertMilesPerHourToKilometersPerHour Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Converts the specified value from miles per hour to kilometers per hour.

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
public static float ConvertMilesPerHourToKilometersPerHour(
	float milesPerHour
)
```

```
Public Shared Function ConvertMilesPerHourToKilometersPerHour ( 
	milesPerHour As Single
) As Single
```

```
public:
static float ConvertMilesPerHourToKilometersPerHour(
	float milesPerHour
)
```

#### Parameters

milesPerHour
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The value, in miles per hour.

#### Return Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
A [Single](http://msdn2.microsoft.com/en-us/library/3www918f) representing the value in miles per hour.

Examples

The following example converts 31.0686 mph to km/h, and shows it in a notification.

[Copy](# "Copy")

```
float kilometersPerHour = MathHelper.ConvertMilesPerHourToKilometersPerHour(31.0686f);
Game.DisplayNotification("31.0686 mph is " + kilometersPerHour.ToString() + " km/h.");
```

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.