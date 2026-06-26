# Ped.IsInCoverFacingLeft Property

﻿Ped.IsInCoverFacingLeft Property 

|  |  |  |
| --- | --- | --- |
| PedIsInCoverFacingLeft Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a value indicating whether this [Ped](T_Rage_Ped.htm) is currently in cover and facing left.

A [Ped](T_Rage_Ped.htm) is considered in cover if it has fully entered the cover state. It is not in cover while moving into cover.

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
public bool IsInCoverFacingLeft { get; }
```

```
Public ReadOnly Property IsInCoverFacingLeft As Boolean
	Get
```

```
public:
property bool IsInCoverFacingLeft {
	bool get ();
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this [Ped](T_Rage_Ped.htm) is currently in cover and facing left; otherwise, false.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.