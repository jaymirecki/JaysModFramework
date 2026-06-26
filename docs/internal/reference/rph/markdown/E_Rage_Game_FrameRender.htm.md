# Game.FrameRender Event

﻿Game.FrameRender Event

|  |  |  |
| --- | --- | --- |
| GameFrameRender Event | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Called on each tick to gather render calls.

This is not called on each frame, but rather each game tick, and draw calls get queued for the frame renderer.  
This allows natives to be called from here; however, you may see flickering in the rendering because of this.  
To avoid this, you can use [RawFrameRender](E_Rage_Game_RawFrameRender.htm) which gets called on each frame, but won't allow native calls.

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
public static event EventHandler<GraphicsEventArgs> FrameRender
```

```
Public Shared Event FrameRender As EventHandler(Of GraphicsEventArgs)
```

```
public:
static  event EventHandler<GraphicsEventArgs^>^ FrameRender {
	void add (EventHandler<GraphicsEventArgs^>^ value);
	void remove (EventHandler<GraphicsEventArgs^>^ value);
}
```

#### Value

Type: [SystemEventHandler](http://msdn2.microsoft.com/en-us/library/db0etb8x)[GraphicsEventArgs](T_Rage_GraphicsEventArgs.htm)

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.