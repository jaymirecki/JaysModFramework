# Entity.NeedsCollision Property

﻿Entity.NeedsCollision Property 

|  |  |  |
| --- | --- | --- |
| EntityNeedsCollision Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a value indicating whether this instance needs collision.

Entities not marked explicitly to need collision will still get collision, however, if other entities need collision, entities not marked as needing collision may lose it in favor of those.

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
public bool NeedsCollision { set; }
```

```
Public WriteOnly Property NeedsCollision As Boolean
	Set
```

```
public:
property bool NeedsCollision {
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this entity needs collision; otherwise, false.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.