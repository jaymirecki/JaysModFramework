# Vehicle.EngineHealth Property

﻿Vehicle.EngineHealth Property 

|  |  |  |
| --- | --- | --- |
| VehicleEngineHealth Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the health of the car's engine.

The engine health ranges between 0.0f and 1000.0f.

When the engine health is below 400.0f, the engine will start to smoke.

When the engine health is 300.0f or below, the car's back fire will become smokey and sound worse.

When the engine health is below 300.0f, the car will have difficulties maintaining a stable acceleration.

When the engine health reaches 0.0f, the car's engine will die.

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
public float EngineHealth { get; set; }
```

```
Public Property EngineHealth As Single
	Get
	Set
```

```
public:
property float EngineHealth {
	float get ();
	void set (float value);
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The health of the car's engine.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.