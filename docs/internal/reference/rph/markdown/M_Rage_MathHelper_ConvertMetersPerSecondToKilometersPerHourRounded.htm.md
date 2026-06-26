# MathHelper.ConvertMetersPerSecondToKilometersPerHourRounded Method

﻿MathHelper.ConvertMetersPerSecondToKilometersPerHourRounded Method 

|  |  |  |
| --- | --- | --- |
| MathHelperConvertMetersPerSecondToKilometersPerHourRounded Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Converts the specified value from meters per second to kilometers per hour and rounds the result.

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
public static int ConvertMetersPerSecondToKilometersPerHourRounded(
	float metersPerSecond
)
```

```
Public Shared Function ConvertMetersPerSecondToKilometersPerHourRounded ( 
	metersPerSecond As Single
) As Integer
```

```
public:
static int ConvertMetersPerSecondToKilometersPerHourRounded(
	float metersPerSecond
)
```

#### Parameters

metersPerSecond
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The value, in meters per second.

#### Return Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
A [Single](http://msdn2.microsoft.com/en-us/library/3www918f) representing the value in kilometers per hour.

Examples

The following example converts 13.8889 m/s to km/h, rounded, and shows it in a notification.

[Copy](# "Copy")

```
int kilometersPerHourRounded = MathHelper.ConvertMetersPerSecondToKilometersPerHourRounded(13.8889f);
Game.DisplayNotification("13.8889 m/s is ~" + kilometersPerHourRounded.ToString() + " km/h.");
```

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.