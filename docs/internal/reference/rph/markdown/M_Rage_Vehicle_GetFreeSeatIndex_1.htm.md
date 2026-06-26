# Vehicle.GetFreeSeatIndex Method (Int32, Int32)

﻿Vehicle.GetFreeSeatIndex Method (Int32, Int32)

|  |  |  |
| --- | --- | --- |
| VehicleGetFreeSeatIndex Method (Int32, Int32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the first free index seat of this vehicle between the specified indices, both inclusive.

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
public Nullable<int> GetFreeSeatIndex(
	int minimumSeatIndex,
	int maximumSeatIndex
)
```

```
Public Function GetFreeSeatIndex ( 
	minimumSeatIndex As Integer,
	maximumSeatIndex As Integer
) As Nullable(Of Integer)
```

```
public:
Nullable<int> GetFreeSeatIndex(
	int minimumSeatIndex, 
	int maximumSeatIndex
)
```

#### Parameters

minimumSeatIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  

    [Missing <param name="minimumSeatIndex"/> documentation for "M:Rage.Vehicle.GetFreeSeatIndex(System.Int32,System.Int32)"]

maximumSeatIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  

    [Missing <param name="maximumSeatIndex"/> documentation for "M:Rage.Vehicle.GetFreeSeatIndex(System.Int32,System.Int32)"]

#### Return Value

Type: [Nullable](http://msdn2.microsoft.com/en-us/library/b3h38hb0)[Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
If a seat is found, returns the seat index; Otherwise, returns null.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[GetFreeSeatIndex Overload](Overload_Rage_Vehicle_GetFreeSeatIndex.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.