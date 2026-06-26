# Fire.OwningEntity Property

﻿Fire.OwningEntity Property 

|  |  |  |
| --- | --- | --- |
| FireOwningEntity Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the entity this fire belongs to.

Damage inflicted by fires is attributed to the owner.

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
public Entity OwningEntity { get; set; }
```

```
Public Property OwningEntity As Entity
	Get
	Set
```

```
public:
property Entity^ OwningEntity {
	Entity^ get ();
	void set (Entity^ value);
}
```

#### Property Value

Type: [Entity](T_Rage_Entity.htm)  
The entity this fire belongs to.

See Also

#### Reference

[Fire Class](T_Rage_Fire.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.