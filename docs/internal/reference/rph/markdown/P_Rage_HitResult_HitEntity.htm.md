# HitResult.HitEntity Property

﻿HitResult.HitEntity Property 

|  |  |  |
| --- | --- | --- |
| HitResultHitEntity Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the [Entity](T_Rage_Entity.htm) that was hit.

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
public Entity HitEntity {
	[HandleProcessCorruptedStateExceptionsAttribute]
	get;
 }
```

```
Public ReadOnly Property HitEntity As Entity
	<HandleProcessCorruptedStateExceptionsAttribute>
	Get
```

```
public:
property Entity^ HitEntity {
	[HandleProcessCorruptedStateExceptionsAttribute]
	Entity^ get ();
}
```

#### Property Value

Type: [Entity](T_Rage_Entity.htm)  
If the trace hit something, the [Entity](T_Rage_Entity.htm) that was hit; otherwise null.

See Also

#### Reference

[HitResult Structure](T_Rage_HitResult.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.