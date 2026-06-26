# Entity.GetPositionOffset Method

﻿Entity.GetPositionOffset Method 

|  |  |  |
| --- | --- | --- |
| EntityGetPositionOffset Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the offset to the specified world position, relative to this [Entity](T_Rage_Entity.htm).

This is essentially the opposite of [GetOffsetPosition(Vector3)](M_Rage_Entity_GetOffsetPosition.htm)

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
public Vector3 GetPositionOffset(
	Vector3 position
)
```

```
Public Function GetPositionOffset ( 
	position As Vector3
) As Vector3
```

```
public:
Vector3 GetPositionOffset(
	Vector3 position
)
```

#### Parameters

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The world position to get the relative offset to.

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
A [Vector3](T_Rage_Vector3.htm) representing the relative offset to the world position, where X is right, Y is forward, and Z is up.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.