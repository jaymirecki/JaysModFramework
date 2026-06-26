# Ped.IsInAnyVehicle Method

﻿Ped.IsInAnyVehicle Method 

|  |  |  |
| --- | --- | --- |
| PedIsInAnyVehicle Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets whether this [Ped](T_Rage_Ped.htm) is in any [Vehicle](T_Rage_Vehicle.htm).

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
public bool IsInAnyVehicle(
	bool atGetIn
)
```

```
Public Function IsInAnyVehicle ( 
	atGetIn As Boolean
) As Boolean
```

```
public:
bool IsInAnyVehicle(
	bool atGetIn
)
```

#### Parameters

atGetIn
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If true this method returns true if the ped is currently getting into the vehicle (that is, the ped has opened the door, and is about to get in); if false the method doesn't return true until the ped is sitting in the seat.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
If this instance is currently in any vehicle, returns true; otherwise, returns false.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.