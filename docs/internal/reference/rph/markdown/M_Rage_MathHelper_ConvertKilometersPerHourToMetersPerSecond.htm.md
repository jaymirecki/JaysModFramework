# MathHelper.ConvertKilometersPerHourToMetersPerSecond Method

﻿MathHelper.ConvertKilometersPerHourToMetersPerSecond Method 

|  |  |  |
| --- | --- | --- |
| MathHelperConvertKilometersPerHourToMetersPerSecond Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Converts the specified value from kilometers per hour to meters per second.

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
public static float ConvertKilometersPerHourToMetersPerSecond(
	float kilometersPerHour
)
```

```
Public Shared Function ConvertKilometersPerHourToMetersPerSecond ( 
	kilometersPerHour As Single
) As Single
```

```
public:
static float ConvertKilometersPerHourToMetersPerSecond(
	float kilometersPerHour
)
```

#### Parameters

kilometersPerHour
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The value, in kilometers per hour.

#### Return Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
A [Single](http://msdn2.microsoft.com/en-us/library/3www918f) representing the value in meters per second.

Examples

The following example converts 50 km/h to m/s, and shows it in a notification.

[Copy](# "Copy")

```
float metersPerSecond = MathHelper.KilometersPerHourToMetersPerSecond(50f);
Game.DisplayNotification("50 km/h is " + metersPerSecond.ToString() + " m/s.");
```

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.