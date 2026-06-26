# Game.FrameCount Property

﻿Game.FrameCount Property 

|  |  |  |
| --- | --- | --- |
| GameFrameCount Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the total number of frames that's been rendered this session.

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
public static uint FrameCount { get; }
```

```
Public Shared ReadOnly Property FrameCount As UInteger
	Get
```

```
public:
static property unsigned int FrameCount {
	unsigned int get ();
}
```

#### Property Value

Type: [UInt32](http://msdn2.microsoft.com/en-us/library/ctys3981)  
The total number of frames that's been rendered this session.

Remarks

The frame count does not increase while the game is paused.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.