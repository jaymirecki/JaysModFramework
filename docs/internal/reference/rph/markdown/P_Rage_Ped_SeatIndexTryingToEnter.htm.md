# Ped.SeatIndexTryingToEnter Property

﻿Ped.SeatIndexTryingToEnter Property 

|  |  |  |
| --- | --- | --- |
| PedSeatIndexTryingToEnter Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the index of the seat this [Ped](T_Rage_Ped.htm) is currently trying to enter.

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
public int SeatIndexTryingToEnter { get; }
```

```
Public ReadOnly Property SeatIndexTryingToEnter As Integer
	Get
```

```
public:
property int SeatIndexTryingToEnter {
	int get ();
}
```

#### Property Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
The index of the seat this [Ped](T_Rage_Ped.htm) is trying to enter, or -3 if this [Ped](T_Rage_Ped.htm) is not trying to enter a [Vehicle](T_Rage_Vehicle.htm).

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.