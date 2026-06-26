# PedRunOverEventArgs Constructor

﻿PedRunOverEventArgs Constructor 

|  |  |  |
| --- | --- | --- |
| PedRunOverEventArgs Constructor | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Initializes a new instance of the [PedRunOverEventArgs](T_Rage_PedRunOverEventArgs.htm) class.

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
public PedRunOverEventArgs(
	Vector3 position,
	Ped ped,
	Vehicle vehicle
)
```

```
Public Sub New ( 
	position As Vector3,
	ped As Ped,
	vehicle As Vehicle
)
```

```
public:
PedRunOverEventArgs(
	Vector3 position, 
	Ped^ ped, 
	Vehicle^ vehicle
)
```

#### Parameters

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position the event occurred at.

ped
:   Type: [RagePed](T_Rage_Ped.htm)  
    The ped that got hit.

vehicle
:   Type: [RageVehicle](T_Rage_Vehicle.htm)  
    The vehicle that hit the ped.

See Also

#### Reference

[PedRunOverEventArgs Class](T_Rage_PedRunOverEventArgs.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.