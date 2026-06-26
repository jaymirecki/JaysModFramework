# World.IsPathNodeIdValid Method

﻿World.IsPathNodeIdValid Method 

|  |  |  |
| --- | --- | --- |
| WorldIsPathNodeIdValid Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether the specified value is a valid path node identifier.

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
public static bool IsPathNodeIdValid(
	uint pathNodeId
)
```

```
Public Shared Function IsPathNodeIdValid ( 
	pathNodeId As UInteger
) As Boolean
```

```
public:
static bool IsPathNodeIdValid(
	unsigned int pathNodeId
)
```

#### Parameters

pathNodeId
:   Type: [SystemUInt32](http://msdn2.microsoft.com/en-us/library/ctys3981)  
    The path node identifier.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
Returns true if the specified value is a valid path node identifier; otherwise, returns false.

Remarks

This is not a simple pathNodeId != 0 check.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.