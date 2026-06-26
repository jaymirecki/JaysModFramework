# Vehicle.Deform Method

﻿Vehicle.Deform Method 

|  |  |  |
| --- | --- | --- |
| VehicleDeform Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Applies deformation to this vehicle.

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
public void Deform(
	Vector3 offset,
	float radius,
	float amount
)
```

```
Public Sub Deform ( 
	offset As Vector3,
	radius As Single,
	amount As Single
)
```

```
public:
void Deform(
	Vector3 offset, 
	float radius, 
	float amount
)
```

#### Parameters

offset
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The offset to deform the vehicle at, in entity space.

radius
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The radius to apply the deformation in.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The amount of deformation to apply.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.