# Fire.DistanceTo2D Method (Vector3)

﻿Fire.DistanceTo2D Method (Vector3)

|  |  |  |
| --- | --- | --- |
| FireDistanceTo2D Method (Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the distance from this instance to the specified position.

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
public virtual float DistanceTo2D(
	Vector3 position
)
```

```
Public Overridable Function DistanceTo2D ( 
	position As Vector3
) As Single
```

```
public:
virtual float DistanceTo2D(
	Vector3 position
)
```

#### Parameters

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position to get the distance to.

#### Return Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
A [Single](http://msdn2.microsoft.com/en-us/library/3www918f) representing the distance from this instance to the specified position.

#### Implements

[ISpatialDistanceTo2D(Vector3)](M_Rage_ISpatial_DistanceTo2D_1.htm)  

See Also

#### Reference

[Fire Class](T_Rage_Fire.htm)

[DistanceTo2D Overload](Overload_Rage_Fire_DistanceTo2D.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.