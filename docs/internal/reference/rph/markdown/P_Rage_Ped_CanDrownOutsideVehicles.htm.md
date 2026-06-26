# Ped.CanDrownOutsideVehicles Property

﻿Ped.CanDrownOutsideVehicles Property 

|  |  |  |
| --- | --- | --- |
| PedCanDrownOutsideVehicles Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets a value indicating whether this [Ped](T_Rage_Ped.htm) is able to drown while in water, outside a vehicle. The value of this property has no influence on [CanDrownInVehicles](P_Rage_Ped_CanDrownInVehicles.htm).

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
public bool CanDrownOutsideVehicles { set; }
```

```
Public WriteOnly Property CanDrownOutsideVehicles As Boolean
	Set
```

```
public:
property bool CanDrownOutsideVehicles {
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this [Ped](T_Rage_Ped.htm) is able to drown while in water, outside a vehicle; otherwise, false.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.