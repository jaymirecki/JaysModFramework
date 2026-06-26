# Entity.Equals Method (IHandleable)

﻿Entity.Equals Method (IHandleable)

|  |  |  |
| --- | --- | --- |
| EntityEquals Method (IHandleable) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Indicates whether the current [IHandleable](T_Rage_IHandleable.htm) is equal to another [IHandleable](T_Rage_IHandleable.htm).

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
public virtual bool Equals(
	IHandleable obj
)
```

```
Public Overridable Function Equals ( 
	obj As IHandleable
) As Boolean
```

```
public:
virtual bool Equals(
	IHandleable^ obj
)
```

#### Parameters

obj
:   Type: [RageIHandleable](T_Rage_IHandleable.htm)  
    An [IHandleable](T_Rage_IHandleable.htm) to compare with this [IHandleable](T_Rage_IHandleable.htm).

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if the current [IHandleable](T_Rage_IHandleable.htm) is equal to the other [IHandleable](T_Rage_IHandleable.htm); otherwise, false.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Equals Overload](Overload_Rage_Entity_Equals.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.