# Vehicle.AlarmTimeLeft Property

﻿Vehicle.AlarmTimeLeft Property 

|  |  |  |
| --- | --- | --- |
| VehicleAlarmTimeLeft Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets time left before the vehicle alarm stops.

If greater than zero, the vehicle alarm will be sounding.

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
public TimeSpan AlarmTimeLeft { get; set; }
```

```
Public Property AlarmTimeLeft As TimeSpan
	Get
	Set
```

```
public:
property TimeSpan AlarmTimeLeft {
	TimeSpan get ();
	void set (TimeSpan value);
}
```

#### Property Value

Type: [TimeSpan](http://msdn2.microsoft.com/en-us/library/269ew577)  
The time left before the vehicle alarm stops.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.