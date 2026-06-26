# Ped.GiveHelmet Method

﻿Ped.GiveHelmet Method 

|  |  |  |
| --- | --- | --- |
| PedGiveHelmet Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gives this [Ped](T_Rage_Ped.htm) a new helmet of the specified type.

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
public void GiveHelmet(
	bool canBeRemovedByPed,
	HelmetTypes helmetType,
	int textureIndex
)
```

```
Public Sub GiveHelmet ( 
	canBeRemovedByPed As Boolean,
	helmetType As HelmetTypes,
	textureIndex As Integer
)
```

```
public:
void GiveHelmet(
	bool canBeRemovedByPed, 
	HelmetTypes helmetType, 
	int textureIndex
)
```

#### Parameters

canBeRemovedByPed
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    Whether the helmet can be removed by the [Ped](T_Rage_Ped.htm).

helmetType
:   Type: [RageHelmetTypes](T_Rage_HelmetTypes.htm)  
    The type of helmet to give to this [Ped](T_Rage_Ped.htm).

textureIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index of the texture of the helmet.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.