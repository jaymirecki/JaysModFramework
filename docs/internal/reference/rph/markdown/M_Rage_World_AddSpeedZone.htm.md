# World.AddSpeedZone Method

﻿World.AddSpeedZone Method 

|  |  |  |
| --- | --- | --- |
| WorldAddSpeedZone Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Adds a new speed zone limiting the maximum driving speed of AI-driven vehicles in an area.

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
public static uint AddSpeedZone(
	Vector3 position,
	float radius,
	float maxSpeed
)
```

```
Public Shared Function AddSpeedZone ( 
	position As Vector3,
	radius As Single,
	maxSpeed As Single
) As UInteger
```

```
public:
static unsigned int AddSpeedZone(
	Vector3 position, 
	float radius, 
	float maxSpeed
)
```

#### Parameters

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position to add the speed zone at.

radius
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The radius of the speed zone.

maxSpeed
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The maximum speed allowed by the speed zone.

#### Return Value

Type: [UInt32](http://msdn2.microsoft.com/en-us/library/ctys3981)  
An unsigned int representing the handle of the created speed zone.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.