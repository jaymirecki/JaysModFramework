# Model.GetDimensions Method

﻿Model.GetDimensions Method 

|  |  |  |
| --- | --- | --- |
| ModelGetDimensions Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the dimensions of this model.

The rear bottom left relative offset from the origin of the model.

The front top right relative offset from the origin of the model.

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
public void GetDimensions(
	out Vector3 rearBottomLeft,
	out Vector3 frontTopRight
)
```

```
Public Sub GetDimensions ( 
	<OutAttribute> ByRef rearBottomLeft As Vector3,
	<OutAttribute> ByRef frontTopRight As Vector3
)
```

```
public:
void GetDimensions(
	[OutAttribute] Vector3% rearBottomLeft, 
	[OutAttribute] Vector3% frontTopRight
)
```

#### Parameters

rearBottomLeft
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The negative dimensions.

frontTopRight
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The positive dimensions.

See Also

#### Reference

[Model Structure](T_Rage_Model.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.