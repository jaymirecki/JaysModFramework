# Game Class

﻿Game Class

|  |  |  |
| --- | --- | --- |
| Game Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Static class for various game settings and functions.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageGame  
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
public static class Game
```

```
Public NotInheritable Class Game
```

```
public ref class Game abstract sealed
```

The Game type exposes the following members.

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

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [AddConsoleCommands](M_Rage_Game_AddConsoleCommands.htm) | Adds console commands defined in the calling assembly. |
| Public methodStatic member | [AddConsoleCommands(MethodInfo)](M_Rage_Game_AddConsoleCommands_1.htm) | Adds console commands from the specified methods. |
| Public methodStatic member | [AddConsoleCommands(Type)](M_Rage_Game_AddConsoleCommands_2.htm) | Adds console commands from the specified types. |
| Public methodStatic member | [AllocateMemory](M_Rage_Game_AllocateMemory.htm) | Allocates a block of memory of the specified size using VirtualAlloc. |
| Public methodStatic member | [CreateTextureFromFile](M_Rage_Game_CreateTextureFromFile.htm) | Creates a new texture from the specified file. |
| Public methodStatic member | [DisableControlAction](M_Rage_Game_DisableControlAction.htm) |  |
| Public methodStatic member | [DisplayHelp(String)](M_Rage_Game_DisplayHelp.htm) | Displays the specified text in the help box. |
| Public methodStatic member | [DisplayHelp(String, Boolean)](M_Rage_Game_DisplayHelp_1.htm) | Displays the specified text in the help box. |
| Public methodStatic member | [DisplayHelp(String, Int32)](M_Rage_Game_DisplayHelp_2.htm) | Displays the specified text in the help box. |
| Public methodStatic member | [DisplayNotification(String)](M_Rage_Game_DisplayNotification.htm) | Adds a new notification above the map. |
| Public methodStatic member | [DisplayNotification(String, String, String, String, String)](M_Rage_Game_DisplayNotification_1.htm) | Adds a new notification above the map. |
| Public methodStatic member | [DisplaySubtitle(String)](M_Rage_Game_DisplaySubtitle.htm) | Displays the specified text in a subtitle.  The display duration will be automatically calculated based on the reading speed of the average human. |
| Public methodStatic member | [DisplaySubtitle(String, Int32)](M_Rage_Game_DisplaySubtitle_1.htm) | Displays the specified text in a subtitle for the specified duration. |
| Public methodStatic member | [FadeScreenIn(Int32)](M_Rage_Game_FadeScreenIn.htm) | Fades the screen in over the specified amount of time. |
| Public methodStatic member | [FadeScreenIn(Int32, Boolean)](M_Rage_Game_FadeScreenIn_1.htm) | Fades the screen in over the specified amount of time. |
| Public methodStatic member | [FadeScreenOut(Int32)](M_Rage_Game_FadeScreenOut.htm) | Fades the screen out over the specified amount of time. |
| Public methodStatic member | [FadeScreenOut(Int32, Boolean)](M_Rage_Game_FadeScreenOut_1.htm) | Fades the screen out over the specified amount of time. |
| Public methodStatic member | [FindAllOccurrencesOfPattern(String)](M_Rage_Game_FindAllOccurrencesOfPattern.htm) | Finds all occurrences of the specified pattern of bytes in the game's memory. |
| Public methodStatic member | [FindAllOccurrencesOfPattern(String, IntPtr)](M_Rage_Game_FindAllOccurrencesOfPattern_1.htm) | Finds all occurrences of the specified pattern of bytes in the game's memory. |
| Public methodStatic memberCode example | [FindPattern(String)](M_Rage_Game_FindPattern.htm) | Finds the specified pattern of bytes in the game's memory. |
| Public methodStatic memberCode example | [FindPattern(String, IntPtr)](M_Rage_Game_FindPattern_1.htm) | Finds the specified pattern of bytes in the game's memory. |
| Public methodStatic member | [FreeMemory](M_Rage_Game_FreeMemory.htm) | Frees the memory previously allocated by [AllocateMemory(Int64)](M_Rage_Game_AllocateMemory.htm), using VirtualFree. |
| Public methodStatic member | [GetAchievementProgress](M_Rage_Game_GetAchievementProgress.htm) | Gets the progress of the specified achievement. |
| Public methodStatic member | [GetClipboardText](M_Rage_Game_GetClipboardText.htm) | Gets the text in the clipboard. |
| Public methodStatic member | [GetHashKey](M_Rage_Game_GetHashKey.htm) | Computes the hash of the given text using Jenkin's one-at-a-time algorithm. |
| Public methodStatic member | [GetKeyboardState](M_Rage_Game_GetKeyboardState.htm) | Gets the current state of the keyboard. |
| Public methodStatic memberCode example | [GetLocalizedString](M_Rage_Game_GetLocalizedString.htm) | Gets the localized string from the specified localization string id. |
| Public methodStatic member | [GetMouseState](M_Rage_Game_GetMouseState.htm) | Gets the current state of the mouse. |
| Public methodStatic member | [GetMouseWheelDelta](M_Rage_Game_GetMouseWheelDelta.htm) | Gets the amount the mouse wheel has scrolled. |
| Public methodStatic member | [GetNativeAddress](M_Rage_Game_GetNativeAddress.htm) | Gets the address of the native function with the specified name. |
| Public methodStatic member | [GetRunningScripts](M_Rage_Game_GetRunningScripts.htm) | Gets the names of all currently running game scripts. |
| Public methodStatic member | [GetScriptGlobalVariableAddress](M_Rage_Game_GetScriptGlobalVariableAddress.htm) | Gets the address of the script global variable with the specified id. |
| Public methodStatic member | [HandleRespawn](M_Rage_Game_HandleRespawn.htm) | Marks the current respawning of the local player as completed, allowing normal game functions, like HUD, opening the menu, etc. |
| Public methodStatic member | [HasAchievementBeenPassed](M_Rage_Game_HasAchievementBeenPassed.htm) | Determines whether the specified achievement has been passed. |
| Public methodStatic member | [HideHelp](M_Rage_Game_HideHelp.htm) | Hides the current help box. |
| Public methodStatic member | [IsControlJustPressed](M_Rage_Game_IsControlJustPressed.htm) |  |
| Public methodStatic member | [IsControlJustReleased](M_Rage_Game_IsControlJustReleased.htm) |  |
| Public methodStatic member | [IsControllerButtonDown](M_Rage_Game_IsControllerButtonDown.htm) |  |
| Public methodStatic member | [IsControllerButtonDownRightNow](M_Rage_Game_IsControllerButtonDownRightNow.htm) |  |
| Public methodStatic member | [IsControlPressed](M_Rage_Game_IsControlPressed.htm) |  |
| Public methodStatic member | [IsKeyDown](M_Rage_Game_IsKeyDown.htm) |  |
| Public methodStatic member | [IsKeyDownRightNow](M_Rage_Game_IsKeyDownRightNow.htm) |  |
| Public methodStatic member | [LockMinimapAngle](M_Rage_Game_LockMinimapAngle.htm) | Locks the minimap to the specified angle. |
| Public methodStatic member | [LockMinimapPosition(Vector2)](M_Rage_Game_LockMinimapPosition.htm) | Locks the minimap to the specified world position. |
| Public methodStatic member | [LockMinimapPosition(Vector3)](M_Rage_Game_LockMinimapPosition_1.htm) | Locks the minimap to the specified world position. |
| Public methodStatic member | [LockMinimapPosition(Single, Single)](M_Rage_Game_LockMinimapPosition_2.htm) | Locks the minimap to the specified world position. |
| Public methodStatic member | [LogExtremelyVerbose](M_Rage_Game_LogExtremelyVerbose.htm) | Logs the specified text to the RAGE Plugin Hook log file, if the current logging verbosity setting is equal to, or greater than [!:LoggingVerbosity::ExtremelyVerbose]. |
| Public methodStatic member | [LogExtremelyVerboseDebug](M_Rage_Game_LogExtremelyVerboseDebug.htm) | Logs the specified text to the RAGE Plugin Hook log file, if the current logging verbosity setting is equal to, or greater than [!:LoggingVerbosity::ExtremelyVerbose].  When the calling [Assembly](http://msdn2.microsoft.com/en-us/library/xbe1wdx9) is not compiled in DEBUG mode, calls to this method will not be compiled. |
| Public methodStatic member | [LogTrivial](M_Rage_Game_LogTrivial.htm) | Logs the specified text to the RAGE Plugin Hook log file, if the current logging verbosity setting is equal to, or greater than [!:LoggingVerbosity::Trivial]. |
| Public methodStatic memberCode example | [LogTrivialDebug](M_Rage_Game_LogTrivialDebug.htm) | Logs the specified text to the RAGE Plugin Hook log file, if the current logging verbosity setting is equal to, or greater than [!:LoggingVerbosity::Trivial].  When the calling [Assembly](http://msdn2.microsoft.com/en-us/library/xbe1wdx9) is not compiled in DEBUG mode, calls to this method will not be compiled. |
| Public methodStatic member | [LogVerbose](M_Rage_Game_LogVerbose.htm) | Logs the specified text to the RAGE Plugin Hook log file, if the current logging verbosity setting is equal to, or greater than [!:LoggingVerbosity::Verbose]. |
| Public methodStatic member | [LogVerboseDebug](M_Rage_Game_LogVerboseDebug.htm) | Logs the specified text to the RAGE Plugin Hook log file, if the current logging verbosity setting is equal to, or greater than [!:LoggingVerbosity::Verbose].  When the calling [Assembly](http://msdn2.microsoft.com/en-us/library/xbe1wdx9) is not compiled in DEBUG mode, calls to this method will not be compiled. |
| Public methodStatic member | [LogVeryVerbose](M_Rage_Game_LogVeryVerbose.htm) | Logs the specified text to the RAGE Plugin Hook log file, if the current logging verbosity setting is equal to, or greater than [!:LoggingVerbosity::VeryVerbose]. |
| Public methodStatic member | [LogVeryVerboseDebug](M_Rage_Game_LogVeryVerboseDebug.htm) | Logs the specified text to the RAGE Plugin Hook log file, if the current logging verbosity setting is equal to, or greater than [!:LoggingVerbosity::VeryVerbose].  When the calling [Assembly](http://msdn2.microsoft.com/en-us/library/xbe1wdx9) is not compiled in DEBUG mode, calls to this method will not be compiled. |
| Public methodStatic member | [ReloadActivePlugin](M_Rage_Game_ReloadActivePlugin.htm) | Reloads the active plugin. |
| Public methodStatic member | [RemoveNotification](M_Rage_Game_RemoveNotification.htm) | Removes the specified notification. |
| Public methodStatic member | [SetClipboardText](M_Rage_Game_SetClipboardText.htm) | Sets the text in the clipboard. |
| Public methodStatic member | [SetRadarZoomLevelThisFrame](M_Rage_Game_SetRadarZoomLevelThisFrame.htm) | Sets the zoom level of the radar this frame. |
| Public methodStatic memberCode example | [SetRelationshipBetweenRelationshipGroups](M_Rage_Game_SetRelationshipBetweenRelationshipGroups.htm) | Sets the relationship between the specified relationship groups. |
| Public methodStatic member | [StartNewScript(String)](M_Rage_Game_StartNewScript.htm) | Starts a new instance of the game script with the specified name with a stack size of 1424. |
| Public methodStatic member | [StartNewScript(String, Int32)](M_Rage_Game_StartNewScript_1.htm) | Starts a new instance of the game script with the specified name and stack size. |
| Public methodStatic member | [TerminateActivePlugin](M_Rage_Game_TerminateActivePlugin.htm) | Terminates the active plugin. |
| Public methodStatic member | [TerminateAllScripts](M_Rage_Game_TerminateAllScripts.htm) | Terminates all scripts. |
| Public methodStatic member | [TerminateAllScriptsWithName](M_Rage_Game_TerminateAllScriptsWithName.htm) | Terminates all scripts with the specified name. |
| Public methodStatic member | [UnloadActivePlugin](M_Rage_Game_UnloadActivePlugin.htm) | Unloads the active plugin. |
| Public methodStatic member | [UnlockMinimapAngle](M_Rage_Game_UnlockMinimapAngle.htm) | Unlocks the angle of the minimap. |
| Public methodStatic member | [UnlockMinimapPosition](M_Rage_Game_UnlockMinimapPosition.htm) | Unlocks the position of the minimap. |

[Top](#mainBody)

Events

|  | Name | Description |
| --- | --- | --- |
| Public eventStatic member | [FrameRender](E_Rage_Game_FrameRender.htm) | Called on each tick to gather render calls.  This is not called on each frame, but rather each game tick, and draw calls get queued for the frame renderer.  This allows natives to be called from here; however, you may see flickering in the rendering because of this.  To avoid this, you can use [RawFrameRender](E_Rage_Game_RawFrameRender.htm) which gets called on each frame, but won't allow native calls. |
| Public eventStatic memberCode example | [RawFrameRender](E_Rage_Game_RawFrameRender.htm) | Called on each frame.  Natives cannot be called in here, and any attempt to may crash the game. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.