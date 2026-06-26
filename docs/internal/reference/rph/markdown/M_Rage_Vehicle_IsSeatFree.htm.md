# Vehicle.IsSeatFree Method

﻿Vehicle.IsSeatFree Method 

|  |  |  |
| --- | --- | --- |
| VehicleIsSeatFree Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether the seat at the specified index is free.

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
public bool IsSeatFree(
	int seatIndex
)
```

```
Public Function IsSeatFree ( 
	seatIndex As Integer
) As Boolean
```

```
public:
bool IsSeatFree(
	int seatIndex
)
```

#### Parameters

seatIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index to check.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
Returns true if the seat at the specified index is free; otherwise, returns false.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.