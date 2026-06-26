# Game.LogTrivialDebug Method

﻿Game.LogTrivialDebug Method 

|  |  |  |
| --- | --- | --- |
| GameLogTrivialDebug Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Logs the specified text to the RAGE Plugin Hook log file, if the current logging verbosity setting is equal to, or greater than [!:LoggingVerbosity::Trivial].

When the calling [Assembly](http://msdn2.microsoft.com/en-us/library/xbe1wdx9) is not compiled in DEBUG mode, calls to this method will not be compiled.

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
[ConditionalAttribute("DEBUG")]
public static void LogTrivialDebug(
	string text
)
```

```
<ConditionalAttribute("DEBUG")>
Public Shared Sub LogTrivialDebug ( 
	text As String
)
```

```
public:
[ConditionalAttribute(L"DEBUG")]
static void LogTrivialDebug(
	String^ text
)
```

#### Parameters

text
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The text to log.

Examples

Consider a plugin with the following source code:

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
void SpawnPoliceVehicle()
{
    new Vehicle("VEHICLE2", Game.LocalPlayer.Character.GetOffsetPosition(Vector3.RelativeFront * 7f), 0f);
    Game.LogDebug("Spawned police car");
}
```

```
Private Sub SpawnPoliceVehicle()
    New Vehicle("VEHICLE2", Game.LocalPlayer.Character.GetOffsetPosition(Vector3.RelativeFront * 7F), 0F)
    Game.LogDebug("Spawned police car")
End Sub
```

```
void SpawnPoliceVehicle()
{
    gcnew Vehicle("VEHICLE2", Game::LocalPlayer->Character->GetOffsetPosition(Vector3.RelativeFront * 7.0f), 0.0f);
    Game::LogDebug("Spawned police car");
}
```

When the plugin is compiled in DEBUG mode, the code is compiled to:

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
void SpawnPoliceVehicle()
{
    new Vehicle("VEHICLE2", Game.LocalPlayer.Character.GetOffsetPosition(Vector3.RelativeFront * 7f), 0f);
    Game.LogDebug("Spawned police car");
}
```

```
Private Sub SpawnPoliceVehicle()
    New Vehicle("VEHICLE2", Game.LocalPlayer.Character.GetOffsetPosition(Vector3.RelativeFront * 7F), 0F)
    Game.LogDebug("Spawned police car")
End Sub
```

```
void SpawnPoliceVehicle()
{
    gcnew Vehicle("VEHICLE2", Game::LocalPlayer->Character->GetOffsetPosition(Vector3.RelativeFront * 7.0f), 0.0f);
    Game::LogDebug("Spawned police car");
}
```

However, when the plugin is not compiled in DEBUG mode (Eg. RELEASE mode), the code is compiled to:

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
void SpawnPoliceVehicle()
{
    new Vehicle("VEHICLE2", Game.LocalPlayer.Character.GetOffsetPosition(Vector3.RelativeFront * 7f), 0f);
}
```

```
Private Sub SpawnPoliceVehicle()
    New Vehicle("VEHICLE2", Game.LocalPlayer.Character.GetOffsetPosition(Vector3.RelativeFront * 7F), 0F)
End Sub
```

```
void SpawnPoliceVehicle()
{
    gcnew Vehicle("VEHICLE2", Game::LocalPlayer->Character->GetOffsetPosition(Vector3.RelativeFront * 7.0f), 0.0f);
}
```

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.