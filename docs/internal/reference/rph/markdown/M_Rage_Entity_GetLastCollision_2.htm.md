# Entity.GetLastCollision Method (Vector3, Vector3, String)

﻿Entity.GetLastCollision Method (Vector3, Vector3, String)

|  |  |  |
| --- | --- | --- |
| EntityGetLastCollision Method (Vector3, Vector3, String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the last collision of this entity.

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
public bool GetLastCollision(
	out Vector3 position,
	out Vector3 normal,
	out string materialName
)
```

```
Public Function GetLastCollision ( 
	<OutAttribute> ByRef position As Vector3,
	<OutAttribute> ByRef normal As Vector3,
	<OutAttribute> ByRef materialName As String
) As Boolean
```

```
public:
bool GetLastCollision(
	[OutAttribute] Vector3% position, 
	[OutAttribute] Vector3% normal, 
	[OutAttribute] String^% materialName
)
```

#### Parameters

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position the collision occurred at.

normal
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The normal of the collision.

materialName
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the material the entity collided with.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
Returns true if this entity has collided with anything; otherwise, returns false.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[GetLastCollision Overload](Overload_Rage_Entity_GetLastCollision.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.