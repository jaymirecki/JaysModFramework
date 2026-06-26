# Game Events

﻿Game Events

|  |  |  |
| --- | --- | --- |
| Game Events | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [Game](T_Rage_Game.htm) type exposes the following members.

Events

|  | Name | Description |
| --- | --- | --- |
| Public eventStatic member | [FrameRender](E_Rage_Game_FrameRender.htm) | Called on each tick to gather render calls.  This is not called on each frame, but rather each game tick, and draw calls get queued for the frame renderer.  This allows natives to be called from here; however, you may see flickering in the rendering because of this.  To avoid this, you can use [RawFrameRender](E_Rage_Game_RawFrameRender.htm) which gets called on each frame, but won't allow native calls. |
| Public eventStatic memberCode example | [RawFrameRender](E_Rage_Game_RawFrameRender.htm) | Called on each frame.  Natives cannot be called in here, and any attempt to may crash the game. |

[Top](#mainBody)

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.