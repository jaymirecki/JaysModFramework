# Entity.HasBeenDamagedBy Method

﻿Entity.HasBeenDamagedBy Method 

|  |  |  |
| --- | --- | --- |
| EntityHasBeenDamagedBy Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether this entity has been damaged by the specified entity.

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
public bool HasBeenDamagedBy(
	Entity entity
)
```

```
Public Function HasBeenDamagedBy ( 
	entity As Entity
) As Boolean
```

```
public:
bool HasBeenDamagedBy(
	Entity^ entity
)
```

#### Parameters

entity
:   Type: [RageEntity](T_Rage_Entity.htm)  
    The entity to determine whether this entity has been damaged by.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
Returns true if this entity has been damaged by the specified entity; otherwise, returns false.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.