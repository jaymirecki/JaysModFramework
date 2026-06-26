# Blip.DistanceTo Method (ISpatial)

﻿Blip.DistanceTo Method (ISpatial)

|  |  |  |
| --- | --- | --- |
| BlipDistanceTo Method (ISpatial) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance.

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
public float DistanceTo(
	ISpatial spatialObject
)
```

```
Public Function DistanceTo ( 
	spatialObject As ISpatial
) As Single
```

```
public:
virtual float DistanceTo(
	ISpatial^ spatialObject
) sealed
```

#### Parameters

spatialObject
:   Type: [RageISpatial](T_Rage_ISpatial.htm)  
    The [ISpatial](T_Rage_ISpatial.htm) to get the distance to.

#### Return Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
A [Single](http://msdn2.microsoft.com/en-us/library/3www918f) representing the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm).

#### Implements

[ISpatialDistanceTo(ISpatial)](M_Rage_ISpatial_DistanceTo.htm)  

See Also

#### Reference

[Blip Class](T_Rage_Blip.htm)

[DistanceTo Overload](Overload_Rage_Blip_DistanceTo.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.