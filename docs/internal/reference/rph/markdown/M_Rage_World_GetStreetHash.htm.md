# World.GetStreetHash Method

﻿World.GetStreetHash Method 

|  |  |  |
| --- | --- | --- |
| WorldGetStreetHash Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the hash of the name of the street at the given position.

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
public static uint GetStreetHash(
	Vector3 position
)
```

```
Public Shared Function GetStreetHash ( 
	position As Vector3
) As UInteger
```

```
public:
static unsigned int GetStreetHash(
	Vector3 position
)
```

#### Parameters

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position to get the street name hash from.

#### Return Value

Type: [UInt32](http://msdn2.microsoft.com/en-us/library/ctys3981)  
An unsigned int representing the street name hash.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.