# Ped.GetVariation Method

﻿Ped.GetVariation Method 

|  |  |  |
| --- | --- | --- |
| PedGetVariation Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the variation of this [Ped](T_Rage_Ped.htm).

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
public void GetVariation(
	int componentIndex,
	out int drawableIndex,
	out int drawableTextureIndex
)
```

```
Public Sub GetVariation ( 
	componentIndex As Integer,
	<OutAttribute> ByRef drawableIndex As Integer,
	<OutAttribute> ByRef drawableTextureIndex As Integer
)
```

```
public:
void GetVariation(
	int componentIndex, 
	[OutAttribute] int% drawableIndex, 
	[OutAttribute] int% drawableTextureIndex
)
```

#### Parameters

componentIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index of the component to get the variation of.

drawableIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index of the drawable variation.

drawableTextureIndex
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The index of the drawable texture variation.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.