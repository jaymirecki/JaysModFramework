# Entity.GetOffsetPosition Method

﻿Entity.GetOffsetPosition Method 

|  |  |  |
| --- | --- | --- |
| EntityGetOffsetPosition Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a position offset relative to this instance, based on the instance's position and direction.

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
public Vector3 GetOffsetPosition(
	Vector3 offset
)
```

```
Public Function GetOffsetPosition ( 
	offset As Vector3
) As Vector3
```

```
public:
Vector3 GetOffsetPosition(
	Vector3 offset
)
```

#### Parameters

offset
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The offset.

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
A [Vector3](T_Rage_Vector3.htm) representing the offset position.

Examples

This example spawns a vehicle with the model "POLICE2", 7 meters in front, and 3 meters to the left of the player's character, facing the same direction as the player's character.

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
Ped playerPed = Game.LocalPlayer.Character;
Vector3 spawnPosition = playerPed.GetOffsetPosition(new Vector3(-3f, 7f, 0f));
Vehicle car = new Vehicle("POLICE2", spawnPosition, playerPed.Heading);
```

```
Dim playerPed As Ped = Game.LocalPlayer.Character
Dim spawnPosition As Vector3 = playerPed.GetOffsetPosition(New Vector3(-3F, 7F, 0F))
Dim car As New Vehicle("POLICE2", spawnPosition, playerPed.Heading)
```

```
Ped^ playerPed = Game::LocalPlayer->Character;
Vector3 spawnPosition = playerPed->GetOffsetPosition(Vector3(-3.0f, 7.0f, 0.0f));
Vehicle^ car = gcnew Vehicle("POLICE2", spawnPosition, playerPed->Heading);
```

Examples

This example spawns a vehicle with the model "POLICE2", 7 meters in front, and 3 meters to the left of the player's vehicle, facing the same direction as the player's vehicle.

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
Vehicle playerVehicle = Game.LocalPlayer.Character.CurrentVehicle;
if (playerVehicle != null && playerVehicle.IsValid())
{
    Vector3 spawnPosition = playerVehicle.GetOffsetPosition(new Vector3(-3f, 7f, 0f));
    Vehicle car = new Vehicle("POLICE2", spawnPosition, playerVehicle.Heading);
}
```

```
Dim playerVehicle As Vehicle = Game.LocalPlayer.Character.CurrentVehicle
If playerVehicle IsNot Nothing AndAlso playerVehicle.IsValid() Then
    Dim spawnPosition As Vector3 = playerVehicle.GetOffsetPosition(New Vector3(-3F, 7F, 0F))
    Dim car As New Vehicle("POLICE2", spawnPosition, playerVehicle.Heading)
End If
```

```
Vehicle^ playerVehicle = Game::LocalPlayer->Character->CurrentVehicle;
if (playerVehicle != nullptr && playerVehicle->IsValid())
{
    Vector3 spawnPosition = playerVehicle->GetOffsetPosition(Vector3(-3.0f, 7.0f, 0.0f));
    Vehicle^ car = gcnew Vehicle("POLICE2", spawnPosition, playerVehicle->Heading);
}
```

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.