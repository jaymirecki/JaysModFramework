# Vehicle.EmergencyLightingOverride Property

﻿Vehicle.EmergencyLightingOverride Property 

|  |  |  |
| --- | --- | --- |
| VehicleEmergencyLightingOverride Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the overriden emergency lighting settings for this vehicle.

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
public EmergencyLighting EmergencyLightingOverride { get; set; }
```

```
Public Property EmergencyLightingOverride As EmergencyLighting
	Get
	Set
```

```
public:
property EmergencyLighting^ EmergencyLightingOverride {
	EmergencyLighting^ get ();
	void set (EmergencyLighting^ value);
}
```

#### Property Value

Type: [EmergencyLighting](T_Rage_EmergencyLighting.htm)  
If overriden, the overriding emergency lighting settings; otherwise null.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.