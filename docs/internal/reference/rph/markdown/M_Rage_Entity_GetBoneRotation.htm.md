# Entity.GetBoneRotation Method (Int32)

﻿Entity.GetBoneRotation Method (Int32)

|  |  |  |
| --- | --- | --- |
| EntityGetBoneRotation Method (Int32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the rotation of the specified bone.

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
public Rotator GetBoneRotation(
	int boneIndex
)
```

```
Public Function GetBoneRotation ( 
	boneIndex As Integer
) As Rotator
```

```
public:
Rotator GetBoneRotation(
	int boneIndex
)
```

#### Parameters

boneIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index of the bone.

#### Return Value

Type: [Rotator](T_Rage_Rotator.htm)  
An instance of [Rotator](T_Rage_Rotator.htm) representing the rotation of the bone.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[GetBoneRotation Overload](Overload_Rage_Entity_GetBoneRotation.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.