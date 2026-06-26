# Game Properties

﻿Game Properties

|  |  |  |
| --- | --- | --- |
| Game Properties | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [Game](T_Rage_Game.htm) type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public propertyStatic member | [AlwaysReceiveKeyEvents](P_Rage_Game_AlwaysReceiveKeyEvents.htm) | Gets or sets a value indicating whether this plugin will still receive key events even if input focus is set to an active form. |
| Public propertyStatic member | [BuildNumber](P_Rage_Game_BuildNumber.htm) | Gets the build number of the game. |
| Public propertyStatic member | [Console](P_Rage_Game_Console.htm) | Gets the console. |
| Public propertyStatic member | [DisableAutomaticRespawn](P_Rage_Game_DisableAutomaticRespawn.htm) | Gets or sets a value indicating whether automatic respawns are disabled, allowing plugins to implement custom respawn systems. |
| Public propertyStatic member | [FadeScreenOutOnDeath](P_Rage_Game_FadeScreenOutOnDeath.htm) | Gets or sets a value indicating whether the game will fade out the screen when the player dies. |
| Public propertyStatic member | [FrameCount](P_Rage_Game_FrameCount.htm) | Gets the total number of frames that's been rendered this session. |
| Public propertyStatic member | [FrameRate](P_Rage_Game_FrameRate.htm) | Gets the current frame rate. |
| Public propertyStatic member | [FrameTime](P_Rage_Game_FrameTime.htm) | Gets the time it currently takes to render a frame, in milliseconds. |
| Public propertyStatic member | [GameTime](P_Rage_Game_GameTime.htm) | Gets the game time in milliseconds. Unlike [TickCount](http://msdn2.microsoft.com/en-us/library/hs383dc1) this value is scaled based on the game time dilation. |
| Public propertyStatic member | [IsAltKeyDownRightNow](P_Rage_Game_IsAltKeyDownRightNow.htm) | Gets a value indicating whether either alt key is down. |
| Public propertyStatic member | [IsControlKeyDownRightNow](P_Rage_Game_IsControlKeyDownRightNow.htm) | Gets a value indicating whether either control key is down. |
| Public propertyStatic member | [IsControllerConnected](P_Rage_Game_IsControllerConnected.htm) | Gets a value indicating whether a gamepad is connected. |
| Public propertyStatic member | [IsFullMapRevealForced](P_Rage_Game_IsFullMapRevealForced.htm) | Sets a value indicating whether the entire map is currently forced to be revealed. |
| Public propertyStatic member | [IsLoading](P_Rage_Game_IsLoading.htm) | Gets a value indicating whether the game is currently displaying the loading screen. |
| Public propertyStatic member | [IsMissionActive](P_Rage_Game_IsMissionActive.htm) | Gets or sets a value indicating whether a mission is currently active. |
| Public propertyStatic member | [IsPaused](P_Rage_Game_IsPaused.htm) | Gets or sets whether the game is paused.  The game cannot be paused in certain cases, eg. when the console is open. |
| Public propertyStatic member | [IsScreenFadedIn](P_Rage_Game_IsScreenFadedIn.htm) | Gets a value indicating whether the screen is currently faded in. |
| Public propertyStatic member | [IsScreenFadedOut](P_Rage_Game_IsScreenFadedOut.htm) | Gets a value indicating whether the screen is currently faded out. |
| Public propertyStatic member | [IsScreenFadingIn](P_Rage_Game_IsScreenFadingIn.htm) | Gets a value indicating whether the screen is currently fading in. |
| Public propertyStatic member | [IsScreenFadingOut](P_Rage_Game_IsScreenFadingOut.htm) | Gets a value indicating whether the screen is currently fading out. |
| Public propertyStatic member | [IsShiftKeyDownRightNow](P_Rage_Game_IsShiftKeyDownRightNow.htm) | Gets a value indicating whether either shift key is down. |
| Public propertyStatic member | [LocalPlayer](P_Rage_Game_LocalPlayer.htm) | Gets the local [Player](T_Rage_Player.htm) instance. |
| Public propertyStatic member | [MaxWantedLevel](P_Rage_Game_MaxWantedLevel.htm) | Gets or sets the maximum wanted level. |
| Public propertyStatic member | [ProductVersion](P_Rage_Game_ProductVersion.htm) | Gets the product version of the game. |
| Public propertyStatic member | [Resolution](P_Rage_Game_Resolution.htm) | Gets the current game resolution.  This is the resolution of the game window, not the actual screen resolution.  When the game is running in full screen mode, this will be the same as the screen resolution. |
| Public propertyStatic member | [ShowPoliceBlipsOnRadar](P_Rage_Game_ShowPoliceBlipsOnRadar.htm) | Sets a value indicating whether blips representing police units should be shown on the radar when the local player is wanted. |
| Public propertyStatic member | [TickCount](P_Rage_Game_TickCount.htm) |  |
| Public propertyStatic member | [TimeScale](P_Rage_Game_TimeScale.htm) | Gets or sets the time scale multiplier. |

[Top](#mainBody)

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.