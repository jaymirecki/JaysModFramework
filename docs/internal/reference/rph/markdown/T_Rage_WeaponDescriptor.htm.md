# WeaponDescriptor Class

﻿WeaponDescriptor Class

|  |  |  |
| --- | --- | --- |
| WeaponDescriptor Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.WeaponDescriptor"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageWeaponDescriptor  
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
public sealed class WeaponDescriptor : IEquatable<WeaponDescriptor>
```

```
Public NotInheritable Class WeaponDescriptor
	Implements IEquatable(Of WeaponDescriptor)
```

```
public ref class WeaponDescriptor sealed : IEquatable<WeaponDescriptor^>
```

The WeaponDescriptor type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [WeaponDescriptor](M_Rage_WeaponDescriptor__ctor.htm) | Initializes a new instance of the WeaponDescriptor class |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Ammo](P_Rage_WeaponDescriptor_Ammo.htm) | Gets the amount of ammo available for this weapon. |
| Public property | [Asset](P_Rage_WeaponDescriptor_Asset.htm) | Gets the asset of this weapon. |
| Public property | [Hash](P_Rage_WeaponDescriptor_Hash.htm) | Gets the hash of this weapon. |
| Public property | [LoadedAmmo](P_Rage_WeaponDescriptor_LoadedAmmo.htm) | Gets the amount of ammo currently in this weapon. |
| Public property | [MagazineSize](P_Rage_WeaponDescriptor_MagazineSize.htm) | Gets the amount of ammo this weapon will have in its magazine after reloading. |
| Public property | [MaximumAmmo](P_Rage_WeaponDescriptor_MaximumAmmo.htm) | Gets the maximum amount of ammo this weapon can hold. |
| Public property | [Ped](P_Rage_WeaponDescriptor_Ped.htm) | Gets the owning [Ped](P_Rage_WeaponDescriptor_Ped.htm) of this weapon. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Drop](M_Rage_WeaponDescriptor_Drop.htm) | Drops this weapon. If the weapon is in the owning [Ped](P_Rage_WeaponDescriptor_Ped.htm)'s hand, it will be physically dropped; otherwise, it will be placed on the ground in front of the [Ped](P_Rage_WeaponDescriptor_Ped.htm). |
| Public method | [DropToGround](M_Rage_WeaponDescriptor_DropToGround.htm) | Drops this weapon. The weapon will be placed on the ground in front of the [Ped](P_Rage_WeaponDescriptor_Ped.htm). |
| Public method | [Equals](M_Rage_WeaponDescriptor_Equals.htm) | Indicates whether the current WeaponDescriptor is equal to another WeaponDescriptor. |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [Equality](M_Rage_WeaponDescriptor_op_Equality.htm) |  |
| Public operatorStatic member | [(String to WeaponDescriptor)](M_Rage_WeaponDescriptor_op_Implicit_2.htm) |  |
| Public operatorStatic member | [(WeaponAsset to WeaponDescriptor)](M_Rage_WeaponDescriptor_op_Implicit.htm) |  |
| Public operatorStatic member | [(WeaponHash to WeaponDescriptor)](M_Rage_WeaponDescriptor_op_Implicit_1.htm) |  |
| Public operatorStatic member | [Inequality](M_Rage_WeaponDescriptor_op_Inequality.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.