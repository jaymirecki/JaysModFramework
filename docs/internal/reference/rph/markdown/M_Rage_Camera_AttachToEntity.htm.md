# Camera.AttachToEntity Method

﻿Camera.AttachToEntity Method 

|  |  |  |
| --- | --- | --- |
| CameraAttachToEntity Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the state of this instance.

Attaches this instance to the specified [Entity](T_Rage_Entity.htm) at the specified offset.

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
public void AttachToEntity(
	Entity entity,
	Vector3 offset,
	bool relativeOffset
)
```

```
Public Sub AttachToEntity ( 
	entity As Entity,
	offset As Vector3,
	relativeOffset As Boolean
)
```

```
public:
void AttachToEntity(
	Entity^ entity, 
	Vector3 offset, 
	bool relativeOffset
)
```

#### Parameters

entity
:   Type: [RageEntity](T_Rage_Entity.htm)  
    The [Entity](T_Rage_Entity.htm) to attach to.

offset
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The offset at which to attach.

relativeOffset
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    A value indicating whether the offset is relative to the [Entity](T_Rage_Entity.htm).

See Also

#### Reference

[Camera Class](T_Rage_Camera.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.