# Entity.IsUpsideDown Property

﻿Entity.IsUpsideDown Property 

|  |  |  |
| --- | --- | --- |
| EntityIsUpsideDown Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets a value indicating whether this entity is upside down.

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
public bool IsUpsideDown { get; }
```

```
Public ReadOnly Property IsUpsideDown As Boolean
	Get
```

```
public:
property bool IsUpsideDown {
	bool get ();
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this entity is upside down; otherwise, false.

Remarks

An entity is considered upside down when the angle between the entity's up vector and the world aligned up vector exceeds 130°.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.