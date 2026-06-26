# PedInventory.EquippedWeaponObject Property

﻿PedInventory.EquippedWeaponObject Property 

|  |  |  |
| --- | --- | --- |
| PedInventoryEquippedWeaponObject Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the object representing this weapon in the world.

Only weapons in the game world, and equipped by [Ped](P_Rage_PedInventory_Ped.htm)s have an object. Holstered weapons do not.

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
public Weapon EquippedWeaponObject { get; }
```

```
Public ReadOnly Property EquippedWeaponObject As Weapon
	Get
```

```
public:
property Weapon^ EquippedWeaponObject {
	Weapon^ get ();
}
```

#### Property Value

Type: [Weapon](T_Rage_Weapon.htm)  
An instance of [Weapon](T_Rage_Weapon.htm) representing this weapon in the world; or null if not weapon is equipped.

See Also

#### Reference

[PedInventory Class](T_Rage_PedInventory.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.