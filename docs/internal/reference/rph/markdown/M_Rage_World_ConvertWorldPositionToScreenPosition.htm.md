# World.ConvertWorldPositionToScreenPosition Method

﻿World.ConvertWorldPositionToScreenPosition Method 

|  |  |  |
| --- | --- | --- |
| WorldConvertWorldPositionToScreenPosition Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Converts the specified position from world space to screen space.

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
public static Vector2 ConvertWorldPositionToScreenPosition(
	Vector3 worldPosition
)
```

```
Public Shared Function ConvertWorldPositionToScreenPosition ( 
	worldPosition As Vector3
) As Vector2
```

```
public:
static Vector2 ConvertWorldPositionToScreenPosition(
	Vector3 worldPosition
)
```

#### Parameters

worldPosition
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position, in world space, to convert.

#### Return Value

Type: [Vector2](T_Rage_Vector2.htm)  
An instance of [Vector2](T_Rage_Vector2.htm) representing the screen space position of the specified world position.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.