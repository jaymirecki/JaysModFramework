# Fire.TravelDistanceTo Method (ISpatial)

﻿Fire.TravelDistanceTo Method (ISpatial)

|  |  |  |
| --- | --- | --- |
| FireTravelDistanceTo Method (ISpatial) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm) instance, if using the road system.

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
public virtual float TravelDistanceTo(
	ISpatial spatialObject
)
```

```
Public Overridable Function TravelDistanceTo ( 
	spatialObject As ISpatial
) As Single
```

```
public:
virtual float TravelDistanceTo(
	ISpatial^ spatialObject
)
```

#### Parameters

spatialObject
:   Type: [RageISpatial](T_Rage_ISpatial.htm)  
    The [ISpatial](T_Rage_ISpatial.htm) to get the distance to.

#### Return Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
A [Single](http://msdn2.microsoft.com/en-us/library/3www918f) representing the distance from this instance to the specified [ISpatial](T_Rage_ISpatial.htm), if using the road system.

#### Implements

[ISpatialTravelDistanceTo(ISpatial)](M_Rage_ISpatial_TravelDistanceTo.htm)  

See Also

#### Reference

[Fire Class](T_Rage_Fire.htm)

[TravelDistanceTo Overload](Overload_Rage_Fire_TravelDistanceTo.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.