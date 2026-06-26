# Game Methods

﻿Game Methods

|  |  |  |
| --- | --- | --- |
| Game Methods | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [Game](T_Rage_Game.htm) type exposes the following members.

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

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.