# Entity.HeightAboveGround Property

﻿Entity.HeightAboveGround Property 

|  |  |  |
| --- | --- | --- |
| EntityHeightAboveGround Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets this entity's distance from the ground in 1D on the Z-axis.

The distance is measured from the entity's origin to the surface below the entity (Surfaces include roofs of buildings).

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
public float HeightAboveGround { get; }
```

```
Public ReadOnly Property HeightAboveGround As Single
	Get
```

```
public:
property float HeightAboveGround {
	float get ();
}
```

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
The height above ground.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.