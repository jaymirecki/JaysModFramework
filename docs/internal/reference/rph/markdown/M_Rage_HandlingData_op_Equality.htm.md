# HandlingData.Equality Operator

﻿HandlingData.Equality Operator 

|  |  |  |
| --- | --- | --- |
| HandlingDataEquality Operator | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether the the first [HandlingData](T_Rage_HandlingData.htm) instance represents the same handling data as the second [HandlingData](T_Rage_HandlingData.htm) instance.

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
public static bool operator ==(
	HandlingData left,
	HandlingData right
)
```

```
Public Shared Operator = ( 
	left As HandlingData,
	right As HandlingData
) As Boolean
```

```
public:
static bool operator ==(
	HandlingData^ left, 
	HandlingData^ right
)
```

#### Parameters

left
:   Type: [RageHandlingData](T_Rage_HandlingData.htm)  
    The first [HandlingData](T_Rage_HandlingData.htm) instance.

right
:   Type: [RageHandlingData](T_Rage_HandlingData.htm)  
    The first [HandlingData](T_Rage_HandlingData.htm) instance.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if the first instance represents the same handling data as the second instance; otherwise, false.

See Also

#### Reference

[HandlingData Class](T_Rage_HandlingData.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.