# Ped Constructor (Predicate(Model))

﻿Ped Constructor (Predicate(Model))

|  |  |  |
| --- | --- | --- |
| Ped Constructor (PredicateModel) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Initializes a new instance of the [Ped](T_Rage_Ped.htm) class.

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
public Ped(
	Predicate<Model> modelPredicate
)
```

```
Public Sub New ( 
	modelPredicate As Predicate(Of Model)
)
```

```
public:
Ped(
	Predicate<Model>^ modelPredicate
)
```

#### Parameters

modelPredicate
:   Type: [SystemPredicate](http://msdn2.microsoft.com/en-us/library/bfcke1bz)[Model](T_Rage_Model.htm)  
    A method that determines whether a model should be considered when choosing a random model for this [Ped](T_Rage_Ped.htm). Only Ped models will be passed to this method. Cannot be null.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Ped Overload](Overload_Rage_Ped__ctor.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.