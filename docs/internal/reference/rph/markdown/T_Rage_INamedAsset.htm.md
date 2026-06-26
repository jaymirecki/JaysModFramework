# INamedAsset Interface

﻿INamedAsset Interface

|  |  |  |
| --- | --- | --- |
| INamedAsset Interface | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents a game asset. Game assets are blueprints that describe an object. For example, a weapon asset specifies what model a weapon will use, how fast it shoots, how many bullets it has, etc.

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
public interface INamedAsset : IAsset
```

```
Public Interface INamedAsset
	Inherits IAsset
```

```
public interface class INamedAsset : IAsset
```

The INamedAsset type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [IsLoaded](P_Rage_IAsset_IsLoaded.htm) | Gets or sets a value indicating whether this asset has been loaded. (Inherited from [IAsset](T_Rage_IAsset.htm).) |
| Public property | [Name](P_Rage_INamedAsset_Name.htm) | Gets the name of this asset. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Dismiss](M_Rage_IAsset_Dismiss.htm) | Unloads this asset from memory. (Inherited from [IAsset](T_Rage_IAsset.htm).) |
| Public method | [Load](M_Rage_IAsset_Load.htm) | Starts loading this asset into memory. (Inherited from [IAsset](T_Rage_IAsset.htm).) |
| Public method | [LoadAndWait](M_Rage_IAsset_LoadAndWait.htm) | Starts loading this asset into memory and waits for it to finish loading. (Inherited from [IAsset](T_Rage_IAsset.htm).) |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

[RageWeaponAsset](T_Rage_WeaponAsset.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.