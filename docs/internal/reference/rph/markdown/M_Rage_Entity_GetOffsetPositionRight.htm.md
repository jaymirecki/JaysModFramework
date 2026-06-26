# Entity.GetOffsetPositionRight Method

﻿Entity.GetOffsetPositionRight Method 

|  |  |  |
| --- | --- | --- |
| EntityGetOffsetPositionRight Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a position that is the specified offset towards the entity's right.

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
public Vector3 GetOffsetPositionRight(
	float offset
)
```

```
Public Function GetOffsetPositionRight ( 
	offset As Single
) As Vector3
```

```
public:
Vector3 GetOffsetPositionRight(
	float offset
)
```

#### Parameters

offset
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The offset in meters to offset the position by.

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
An instance of [Vector3](T_Rage_Vector3.htm) representing the offset position.

Remarks

This method does not get a position that is the specified meters TO the right of the entity, it simply gets a position that is offset from the entity's current position, along the entity's right vector, the specified distance.

It is simply a shortcut for:

C#

[Copy](# "Copy")

```
Vector3 position = entity.GetOffsetPosition(new Vector3(offset, 0f, 0f);
```

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.