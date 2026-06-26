# Entity.GetBoneIndex Method

﻿Entity.GetBoneIndex Method 

|  |  |  |
| --- | --- | --- |
| EntityGetBoneIndex Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the index of a bone of this [Entity](T_Rage_Entity.htm), given the bone's name.

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
public int GetBoneIndex(
	string boneName
)
```

```
Public Function GetBoneIndex ( 
	boneName As String
) As Integer
```

```
public:
int GetBoneIndex(
	String^ boneName
)
```

#### Parameters

boneName
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the bone.

#### Return Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
A [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d) representing the index of the bone.

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentException](http://msdn2.microsoft.com/en-us/library/3w1b3114) | Thrown if this [Entity](T_Rage_Entity.htm) does not have a bone with the specified name. |

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.