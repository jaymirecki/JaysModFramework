# Entity.HasBone Method (String)

﻿Entity.HasBone Method (String)

|  |  |  |
| --- | --- | --- |
| EntityHasBone Method (String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether this [Entity](T_Rage_Entity.htm) has the specified bone.

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
public bool HasBone(
	string boneName
)
```

```
Public Function HasBone ( 
	boneName As String
) As Boolean
```

```
public:
bool HasBone(
	String^ boneName
)
```

#### Parameters

boneName
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the bone.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
If this [Entity](T_Rage_Entity.htm) has the specified bone, returns true; otherwise, returns false.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[HasBone Overload](Overload_Rage_Entity_HasBone.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.