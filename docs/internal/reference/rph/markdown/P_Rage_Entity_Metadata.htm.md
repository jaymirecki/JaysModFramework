# Entity.Metadata Property

﻿Entity.Metadata Property 

|  |  |  |
| --- | --- | --- |
| EntityMetadata Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the [metadata](https://en.wikipedia.org/wiki/Metadata) associated with this instance.

The value of this property can be used to store data about this instance.  
Getting or setting metadata is done using the same syntax as getting or setting a property.  
Internally the value is added to a dictionary with the specified property name as key.

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
public Object Metadata { get; }
```

```
Public ReadOnly Property Metadata As Object
	Get
```

```
public:
property Object^ Metadata {
	Object^ get ();
}
```

#### Property Value

Type: [Object](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  

[Missing <value> documentation for "P:Rage.Entity.Metadata"]

#### Return Value

Type: [Object](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
An instance of [MetadataObject](T_Rage_MetadataObject.htm).

Examples

This example stores the integer 42 in the metadata of the player's [Ped](T_Rage_Ped.htm) with the key "MyValue".

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
Ped playerPed = Game.LocalPlayer.Character;
playerPed.Metadata.MyValue = 42;
```

```
Dim playerPed As Ped = Game.LocalPlayer.Character
playerPed.Metadata.MyValue = 42
```

```
Ped^ playerPed = Game::LocalPlayer->Character;
playerPed->Metadata->MyValue = 42;
```

This example gets the integer stored in the metadata with the key "MyValue" of the player's [Ped](T_Rage_Ped.htm).

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
Ped playerPed = Game.LocalPlayer.Character;
int value = playerPed.Metadata.MyValue;
```

```
Dim playerPed As Ped = Game.LocalPlayer.Character
Dim value As Integer = playerPed.Metadata.MyValue
```

```
Ped^ playerPed = Game::LocalPlayer->Character;
int value = playerPed->Metadata->MyValue;
```

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.