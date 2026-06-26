# Vector3.Around2D Method (Single, Single)

﻿Vector3.Around2D Method (Single, Single)

|  |  |  |
| --- | --- | --- |
| Vector3Around2D Method (Single, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a position that's between the specified minimum and maximum distances from this position, with the same value on the Z-axis as this position.

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
public Vector3 Around2D(
	float minimumDistance,
	float maximumDistance
)
```

```
Public Function Around2D ( 
	minimumDistance As Single,
	maximumDistance As Single
) As Vector3
```

```
public:
Vector3 Around2D(
	float minimumDistance, 
	float maximumDistance
)
```

#### Parameters

minimumDistance
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The minimum distance.

maximumDistance
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The maximum distance.

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
An instance of [Vector3](T_Rage_Vector3.htm) representing the new position.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[Around2D Overload](Overload_Rage_Vector3_Around2D.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.