# World.Weather Property

﻿World.Weather Property 

|  |  |  |
| --- | --- | --- |
| WorldWeather Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the current weather.

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
public static WeatherType Weather { get; set; }
```

```
Public Shared Property Weather As WeatherType
	Get
	Set
```

```
public:
static property WeatherType Weather {
	WeatherType get ();
	void set (WeatherType value);
}
```

#### Property Value

Type: [WeatherType](T_Rage_WeatherType.htm)  
The current weather.

Exceptions

| Exception | Condition |
| --- | --- |
| [NotImplementedException](http://msdn2.microsoft.com/en-us/library/6byb74h9) | Thrown if the value is attempted retrieved. |

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.