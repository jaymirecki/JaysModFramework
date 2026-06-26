# Entity.GetBonePosition Method (String)

﻿Entity.GetBonePosition Method (String)

|  |  |  |
| --- | --- | --- |
| EntityGetBonePosition Method (String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the position of the specified bone, in world space.

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
public Vector3 GetBonePosition(
	string boneName
)
```

```
Public Function GetBonePosition ( 
	boneName As String
) As Vector3
```

```
public:
Vector3 GetBonePosition(
	String^ boneName
)
```

#### Parameters

boneName
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the bone. See [Bones List](bf3684c3-2590-44f1-bd57-6684824ae168.htm) for a list of bones.

#### Return Value

Type: [Vector3](T_Rage_Vector3.htm)  
A [Vector3](T_Rage_Vector3.htm) representing the position of the specified bone, in world space.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[GetBonePosition Overload](Overload_Rage_Entity_GetBonePosition.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.