# Task.IsActive Property

﻿Task.IsActive Property 

|  |  |  |
| --- | --- | --- |
| TaskIsActive Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a value indicating whether this task is active.

A task is considered active if its status is not [None](T_Rage_TaskStatus.htm).

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
public bool IsActive { get; }
```

```
Public ReadOnly Property IsActive As Boolean
	Get
```

```
public:
property bool IsActive {
	bool get ();
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
Whether this task is active.

See Also

#### Reference

[Task Class](T_Rage_Task.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.