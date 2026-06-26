# Ped.GetTextureVariationCount Method

﻿Ped.GetTextureVariationCount Method 

|  |  |  |
| --- | --- | --- |
| PedGetTextureVariationCount Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the number of drawable variations for the specified component of this [Ped](T_Rage_Ped.htm).

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
public int GetTextureVariationCount(
	int componentIndex,
	int drawableIndex
)
```

```
Public Function GetTextureVariationCount ( 
	componentIndex As Integer,
	drawableIndex As Integer
) As Integer
```

```
public:
int GetTextureVariationCount(
	int componentIndex, 
	int drawableIndex
)
```

#### Parameters

componentIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index of the component to get the number of drawable variations from.

drawableIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index of the drawable variation to get the number of texture variations from.

#### Return Value

Type: [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
The number of texture variations for the specified drawable variation for this [Ped](T_Rage_Ped.htm)

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.