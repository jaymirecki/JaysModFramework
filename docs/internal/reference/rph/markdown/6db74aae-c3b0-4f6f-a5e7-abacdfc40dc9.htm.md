# Custom Console Commands

﻿Custom Console Commands

|  |  |  |
| --- | --- | --- |
| Custom Console Commands | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Plugins can define their own console commands.

Custom console commands in plugins are defined by defining static methods in static classes and marking them with the [ConsoleCommandAttribute](T_Rage_Attributes_ConsoleCommandAttribute.htm) attribute.  
If a name is not provided for the [ConsoleCommandAttribute](T_Rage_Attributes_ConsoleCommandAttribute.htm) attribute, the console command will be registered with the name of the method.  
If the method name starts with "Command\_", this tag will be removed from the registered name. Eg. if the method name is "Command\_RemoveAllPedsAndVehicles", the console command will be named "RemoveAllPedsAndVehicles".  

This is an example of a custom console command that removes all [Ped](T_Rage_Ped.htm)s and [Vehicle](T_Rage_Vehicle.htm)s, except players, and the local player's vehicle from the game world.

C#

[Copy](# "Copy")

```
public static class MyConsoleCommands
{
    [Rage.Attributes.ConsoleCommand]
    public static void Command_RemoveAllPedsAndVehicles()
    {
        foreach(Ped ped in World.GetAllPeds())
        {
            if (!ped.IsPlayer)
            {
                ped.Delete();
            }
        }

        Vehicle playersVehicle = Game.LocalPlayer.Character.CurrentVehicle;
        foreach(Vehicle vehicle in World.GetAllVehicles())
        {
            if (!playersVehicle.Exists() || vehicle != playersVehicle)
            {
                vehicle.Delete();
            }
        }
    }
}
```

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.