# Game.RawFrameRender Event

﻿Game.RawFrameRender Event

|  |  |  |
| --- | --- | --- |
| GameRawFrameRender Event | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Called on each frame.

Natives cannot be called in here, and any attempt to may crash the game.

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
public static event EventHandler<GraphicsEventArgs> RawFrameRender
```

```
Public Shared Event RawFrameRender As EventHandler(Of GraphicsEventArgs)
```

```
public:
static  event EventHandler<GraphicsEventArgs^>^ RawFrameRender {
	void add (EventHandler<GraphicsEventArgs^>^ value);
	void remove (EventHandler<GraphicsEventArgs^>^ value);
}
```

#### Value

Type: [SystemEventHandler](http://msdn2.microsoft.com/en-us/library/db0etb8x)[GraphicsEventArgs](T_Rage_GraphicsEventArgs.htm)

Examples

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.