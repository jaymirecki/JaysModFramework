# Vehicle Constructor (Predicate(Model), Vector3)

﻿Vehicle Constructor (Predicate(Model), Vector3)

|  |  |  |
| --- | --- | --- |
| Vehicle Constructor (PredicateModel, Vector3) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Initializes a new instance of the [Vehicle](T_Rage_Vehicle.htm) class.

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
public Vehicle(
	Predicate<Model> modelPredicate,
	Vector3 position
)
```

```
Public Sub New ( 
	modelPredicate As Predicate(Of Model),
	position As Vector3
)
```

```
public:
Vehicle(
	Predicate<Model>^ modelPredicate, 
	Vector3 position
)
```

#### Parameters

modelPredicate
:   Type: [SystemPredicate](http://msdn2.microsoft.com/en-us/library/bfcke1bz)[Model](T_Rage_Model.htm)  
    A method that determines whether a model should be considered when choosing a random model for this [Vehicle](T_Rage_Vehicle.htm). Only vehicle models will be passed to this method. Cannot be null.

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position to spawn at.

See Also

#### Reference

[Vehicle Class](T_Rage_Vehicle.htm)

[Vehicle Overload](Overload_Rage_Vehicle__ctor.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.