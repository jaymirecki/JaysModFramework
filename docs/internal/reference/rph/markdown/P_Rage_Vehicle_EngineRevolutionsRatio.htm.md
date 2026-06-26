# Vehicle.EngineRevolutionsRatio Property

﻿Vehicle.EngineRevolutionsRatio Property 

|  |  |  |
| --- | --- | --- |
| VehicleEngineRevolutionsRatio Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the current engine revolutions ratio.

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
public float EngineRevolutionsRatio { get; }
```

```
Public ReadOnly Property EngineRevolutionsRatio As Single
	Get
```

```
public:
property float EngineRevolutionsRatio {
	float get ();
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
A value between 0.0F and 1.0F, indicating the ratio of the engine RPM.

Remarks

When the engine is off, the value will go to 0.0F. When the vehicle is idle, the value will be 0.2F. When the engine is running at maximum RPM, the value will be 1.0F.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.