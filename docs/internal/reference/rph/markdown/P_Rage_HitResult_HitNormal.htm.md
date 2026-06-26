# HitResult.HitNormal Property

﻿HitResult.HitNormal Property 

|  |  |  |
| --- | --- | --- |
| HitResultHitNormal Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the normal of the surface that was hit.

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
public Vector3 HitNormal { get; }
```

```
Public ReadOnly Property HitNormal As Vector3
	Get
```

```
public:
property Vector3 HitNormal {
	Vector3 get ();
}
```

#### Property Value

Type: [Vector3](T_Rage_Vector3.htm)  
If the trace hit something, the normal of the surface that was hit; otherwise [Zero](P_Rage_Vector3_Zero.htm).

See Also

#### Reference

[HitResult Structure](T_Rage_HitResult.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.