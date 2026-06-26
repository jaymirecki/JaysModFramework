# Entity.SetPositionWithSnap Method

﻿Entity.SetPositionWithSnap Method 

|  |  |  |
| --- | --- | --- |
| EntitySetPositionWithSnap Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets the position of this [Entity](T_Rage_Entity.htm) to the specified value.

Unlike [Position](P_Rage_Entity_Position.htm), if the specified position is in the ground, the position will be adjusted to place the entity above it.

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
public void SetPositionWithSnap(
	Vector3 position
)
```

```
Public Sub SetPositionWithSnap ( 
	position As Vector3
)
```

```
public:
void SetPositionWithSnap(
	Vector3 position
)
```

#### Parameters

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.