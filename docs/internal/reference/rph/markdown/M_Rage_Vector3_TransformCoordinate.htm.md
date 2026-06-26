# Vector3.TransformCoordinate Method (Vector3*, Matrix*, Vector3*, Int32)

﻿Vector3.TransformCoordinate Method (Vector3\*, Matrix\*, Vector3\*, Int32)

|  |  |  |
| --- | --- | --- |
| Vector3TransformCoordinate Method (Vector3, Matrix, Vector3, Int32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Performs a coordinate transformation using the given Matrix.

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
public static void TransformCoordinate(
	Vector3* coordinatesIn,
	Matrix* transformation,
	Vector3* coordinatesOut,
	int count
)
```

```
Visual Basic does not support APIs that consume or return unsafe types.
```

```
public:
static void TransformCoordinate(
	Vector3* coordinatesIn, 
	Matrix* transformation, 
	Vector3* coordinatesOut, 
	int count
)
```

#### Parameters

coordinatesIn
:   Type: [RageVector3](T_Rage_Vector3.htm)\*  
    The source coordinate vectors.

transformation
:   Type: [RageMatrix](T_Rage_Matrix.htm)\*  
    The transformation Matrix.

coordinatesOut
:   Type: [RageVector3](T_Rage_Vector3.htm)\*  
    The transformed coordinate Vector3s.

count
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The number of coordinate vectors to transform.

See Also

#### Reference

[Vector3 Structure](T_Rage_Vector3.htm)

[TransformCoordinate Overload](Overload_Rage_Vector3_TransformCoordinate.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.