# Vehicle.GetPreviousPedOnSeat Method

﻿Vehicle.GetPreviousPedOnSeat Method 

|  |  |  |
| --- | --- | --- |
| VehicleGetPreviousPedOnSeat Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the [Ped](T_Rage_Ped.htm) that was previously on the seat at the specified index.

A [Ped](T_Rage_Ped.htm) is considered 'previous' when it leaves the vehicle.

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
public Ped GetPreviousPedOnSeat(
	int seatIndex
)
```

```
Public Function GetPreviousPedOnSeat ( 
	seatIndex As Integer
) As Ped
```

```
public:
Ped^ GetPreviousPedOnSeat(
	int seatIndex
)
```

#### Parameters

seatIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index to get the [Ped](T_Rage_Ped.htm) from.

#### Return Value

Type: [Ped](T_Rage_Ped.htm)  
If a [Ped](T_Rage_Ped.htm) is on the specified seat, returns the [Ped](T_Rage_Ped.htm); otherwise, returns null

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.