# Ped.SeatIndex Property

﻿Ped.SeatIndex Property 

|  |  |  |
| --- | --- | --- |
| PedSeatIndex Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the index of the seat this [Ped](T_Rage_Ped.htm) is currently on.

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
public int SeatIndex { get; }
```

```
Public ReadOnly Property SeatIndex As Integer
	Get
```

```
public:
property int SeatIndex {
	int get ();
}
```

#### Property Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
The index of the seat.

Exceptions

| Exception | Condition |
| --- | --- |
| [InvalidOperationException](http://msdn2.microsoft.com/en-us/library/2asft85a) | Thrown if the [Ped](T_Rage_Ped.htm) is not in a vehicle. |

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.