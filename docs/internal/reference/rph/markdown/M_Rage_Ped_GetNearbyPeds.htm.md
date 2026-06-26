# Ped.GetNearbyPeds Method

﻿Ped.GetNearbyPeds Method 

|  |  |  |
| --- | --- | --- |
| PedGetNearbyPeds Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets [Ped](T_Rage_Ped.htm)s near this [Ped](T_Rage_Ped.htm).

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
public Ped[] GetNearbyPeds(
	int maximumCount
)
```

```
Public Function GetNearbyPeds ( 
	maximumCount As Integer
) As Ped()
```

```
public:
array<Ped^>^ GetNearbyPeds(
	int maximumCount
)
```

#### Parameters

maximumCount
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The maximum number of nearby [Ped](T_Rage_Ped.htm)s to get. Must be between 1 and 16.

#### Return Value

Type: [Ped](T_Rage_Ped.htm)  
An array of type [Ped](T_Rage_Ped.htm) containing the nearby [Ped](T_Rage_Ped.htm)s.

Remarks

Several times a second, the game will collect [Ped](T_Rage_Ped.htm)s and [Vehicle](T_Rage_Vehicle.htm) that are near a [Ped](T_Rage_Ped.htm). This method retrieves that list, and thus is faster than for example World.GetAllPeds().

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.