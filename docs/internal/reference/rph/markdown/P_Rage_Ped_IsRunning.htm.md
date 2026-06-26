# Ped.IsRunning Property

﻿Ped.IsRunning Property 

|  |  |  |
| --- | --- | --- |
| PedIsRunning Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a value indicating whether this [Ped](T_Rage_Ped.htm) is running.

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
public bool IsRunning { get; }
```

```
Public ReadOnly Property IsRunning As Boolean
	Get
```

```
public:
property bool IsRunning {
	bool get ();
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this [Ped](T_Rage_Ped.htm) is running; otherwise, false.

Remarks

This property specifically returns whether the [Ped](T_Rage_Ped.htm) is running. Returns false if the [Ped](T_Rage_Ped.htm) is walking or sprinting.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.