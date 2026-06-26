# Vehicle.BlipSiren Method

﻿Vehicle.BlipSiren Method 

|  |  |  |
| --- | --- | --- |
| VehicleBlipSiren Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Blips the siren.

This is identical to the blip that is played when the siren is briefly turned on and off, but does not turn on the light.

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
public void BlipSiren(
	bool evenIfOn
)
```

```
Public Sub BlipSiren ( 
	evenIfOn As Boolean
)
```

```
public:
void BlipSiren(
	bool evenIfOn
)
```

#### Parameters

evenIfOn
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If true, the siren will blip even if it's on; otherwise, it'll only blip if the siren is off. Note, that if the siren is on, and this parameter is true, this method will not return on the same tick.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.