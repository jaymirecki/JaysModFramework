# Entity.Face Method (ISpatial)

﻿Entity.Face Method (ISpatial)

|  |  |  |
| --- | --- | --- |
| EntityFace Method (ISpatial) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets the orientation of this instance to face the specified [ISpatial](T_Rage_ISpatial.htm).

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
public virtual void Face(
	ISpatial spatialObject
)
```

```
Public Overridable Sub Face ( 
	spatialObject As ISpatial
)
```

```
public:
virtual void Face(
	ISpatial^ spatialObject
)
```

#### Parameters

spatialObject
:   Type: [RageISpatial](T_Rage_ISpatial.htm)  
    The [ISpatial](T_Rage_ISpatial.htm) to make this instance face.

#### Implements

[IRotatableFace(ISpatial)](M_Rage_IRotatable_Face.htm)  

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Face Overload](Overload_Rage_Entity_Face.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.