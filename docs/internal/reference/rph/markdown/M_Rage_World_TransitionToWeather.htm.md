# World.TransitionToWeather Method

﻿World.TransitionToWeather Method 

|  |  |  |
| --- | --- | --- |
| WorldTransitionToWeather Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Starts transitioning the current weather to the specified weather, over the specified duration.

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
public static void TransitionToWeather(
	WeatherType weatherType,
	float duration
)
```

```
Public Shared Sub TransitionToWeather ( 
	weatherType As WeatherType,
	duration As Single
)
```

```
public:
static void TransitionToWeather(
	WeatherType weatherType, 
	float duration
)
```

#### Parameters

weatherType
:   Type: [RageWeatherType](T_Rage_WeatherType.htm)  
    The type of the weather to transition to.

duration
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The duration the transition lasts, in seconds.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.