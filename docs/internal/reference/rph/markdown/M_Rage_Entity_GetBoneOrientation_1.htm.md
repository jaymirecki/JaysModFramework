# Entity.GetBoneOrientation Method (String)

﻿Entity.GetBoneOrientation Method (String)

|  |  |  |
| --- | --- | --- |
| EntityGetBoneOrientation Method (String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the orientation of the specified bone.

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
public Quaternion GetBoneOrientation(
	string boneName
)
```

```
Public Function GetBoneOrientation ( 
	boneName As String
) As Quaternion
```

```
public:
Quaternion GetBoneOrientation(
	String^ boneName
)
```

#### Parameters

boneName
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the bone.

#### Return Value

Type: [Quaternion](T_Rage_Quaternion.htm)  
An instance of [Quaternion](T_Rage_Quaternion.htm) representing the orientation of the bone.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[GetBoneOrientation Overload](Overload_Rage_Entity_GetBoneOrientation.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.