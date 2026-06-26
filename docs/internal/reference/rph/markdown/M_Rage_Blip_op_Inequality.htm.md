# Blip.Inequality Operator

﻿Blip.Inequality Operator 

|  |  |  |
| --- | --- | --- |
| BlipInequality Operator | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether the the first [Blip](T_Rage_Blip.htm) instance represents a different blip than the second [Blip](T_Rage_Blip.htm) instance.

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
public static bool operator !=(
	Blip left,
	Blip right
)
```

```
Public Shared Operator <> ( 
	left As Blip,
	right As Blip
) As Boolean
```

```
public:
static bool operator !=(
	Blip^ left, 
	Blip^ right
)
```

#### Parameters

left
:   Type: [RageBlip](T_Rage_Blip.htm)  
    The first [Blip](T_Rage_Blip.htm) instance.

right
:   Type: [RageBlip](T_Rage_Blip.htm)  
    The first [Blip](T_Rage_Blip.htm) instance.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if the first instance does not represent the same blip as the second instance; otherwise, false.

See Also

#### Reference

[Blip Class](T_Rage_Blip.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.