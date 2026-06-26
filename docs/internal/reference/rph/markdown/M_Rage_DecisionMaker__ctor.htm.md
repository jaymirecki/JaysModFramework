# DecisionMaker Constructor (String)

﻿DecisionMaker Constructor (String)

|  |  |  |
| --- | --- | --- |
| DecisionMaker Constructor (String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Initializes a new instance of the [DecisionMaker](T_Rage_DecisionMaker.htm) class.

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
public DecisionMaker(
	string name
)
```

```
Public Sub New ( 
	name As String
)
```

```
public:
DecisionMaker(
	String^ name
)
```

#### Parameters

name
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the decision maker.

Examples

The following names are used by the game: PLAYER, COP, FIREMAN, MEDIC, OFFDUTY\_EMT, SECURITY, SWAT, EMPTY, BASE, DEFAULT, GANG, FAMILY, GULL, HEN, RAT, FISH, SHARK, HORSE, DOMESTICANIMAL, DOG, WILDANIMAL, COUGAR, SMALLANIMAL, CAT, RABBIT.
Note that certain decision makers inherit responses from another decision maker. For instance, COP inherits from BASE.

See Also

#### Reference

[DecisionMaker Structure](T_Rage_DecisionMaker.htm)

[DecisionMaker Overload](Overload_Rage_DecisionMaker__ctor.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.