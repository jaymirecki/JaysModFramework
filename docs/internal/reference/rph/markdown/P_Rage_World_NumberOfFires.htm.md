# World.NumberOfFires Property

﻿World.NumberOfFires Property 

|  |  |  |
| --- | --- | --- |
| WorldNumberOfFires Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the total number of fires currently in the game world.

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
public static int NumberOfFires { get; }
```

```
Public Shared ReadOnly Property NumberOfFires As Integer
	Get
```

```
public:
static property int NumberOfFires {
	int get ();
}
```

#### Property Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
The number of fires currently in the game world.

Remarks

Retrieving the value of this property is an O(1) operation.

A total of 128 fires can exist at the same time.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.