# PedInventory.EquippedWeapon Property

﻿PedInventory.EquippedWeapon Property 

|  |  |  |
| --- | --- | --- |
| PedInventoryEquippedWeapon Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the weapon currently equipped by the owning [Ped](P_Rage_PedInventory_Ped.htm).

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
public WeaponDescriptor EquippedWeapon { get; set; }
```

```
Public Property EquippedWeapon As WeaponDescriptor
	Get
	Set
```

```
public:
property WeaponDescriptor^ EquippedWeapon {
	WeaponDescriptor^ get ();
	void set (WeaponDescriptor^ value);
}
```

#### Property Value

Type: [WeaponDescriptor](T_Rage_WeaponDescriptor.htm)  
An instance of [WeaponDescriptor](T_Rage_WeaponDescriptor.htm) representing the weapon currently equipped by the owning [Ped](P_Rage_PedInventory_Ped.htm); or null if no weapon is equipped.

See Also

#### Reference

[PedInventory Class](T_Rage_PedInventory.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.