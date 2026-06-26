# World.RemoveSpeedZone Method

﻿World.RemoveSpeedZone Method 

|  |  |  |
| --- | --- | --- |
| WorldRemoveSpeedZone Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Removes a speed zone given its handle.

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
public static bool RemoveSpeedZone(
	uint speedZoneHandle
)
```

```
Public Shared Function RemoveSpeedZone ( 
	speedZoneHandle As UInteger
) As Boolean
```

```
public:
static bool RemoveSpeedZone(
	unsigned int speedZoneHandle
)
```

#### Parameters

speedZoneHandle
:   Type: [SystemUInt32](http://msdn2.microsoft.com/en-us/library/ctys3981)  
    The handle of the speed zone to remove.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
A value indicating whether the removal was successful.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.