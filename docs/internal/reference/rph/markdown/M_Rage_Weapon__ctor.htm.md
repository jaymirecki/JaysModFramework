# Weapon Constructor

﻿Weapon Constructor 

|  |  |  |
| --- | --- | --- |
| Weapon Constructor | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Initializes a new instance of the [Weapon](T_Rage_Weapon.htm) class.

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
public Weapon(
	WeaponAsset weaponAsset,
	Vector3 position,
	int ammoCount
)
```

```
Public Sub New ( 
	weaponAsset As WeaponAsset,
	position As Vector3,
	ammoCount As Integer
)
```

```
public:
Weapon(
	WeaponAsset weaponAsset, 
	Vector3 position, 
	int ammoCount
)
```

#### Parameters

weaponAsset
:   Type: [RageWeaponAsset](T_Rage_WeaponAsset.htm)  
    The weapon asset.

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position.

ammoCount
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The ammo count.

See Also

#### Reference

[Weapon Class](T_Rage_Weapon.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.