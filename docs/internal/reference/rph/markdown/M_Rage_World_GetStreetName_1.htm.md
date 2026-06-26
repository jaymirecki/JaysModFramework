# World.GetStreetName Method (UInt32)

﻿World.GetStreetName Method (UInt32)

|  |  |  |
| --- | --- | --- |
| WorldGetStreetName Method (UInt32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the name of the street given its hash.

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
public static string GetStreetName(
	uint hash
)
```

```
Public Shared Function GetStreetName ( 
	hash As UInteger
) As String
```

```
public:
static String^ GetStreetName(
	unsigned int hash
)
```

#### Parameters

hash
:   Type: [SystemUInt32](http://msdn2.microsoft.com/en-us/library/ctys3981)  
    The hash to get the street name from.

#### Return Value

Type: [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
A [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf) representing the street name.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[GetStreetName Overload](Overload_Rage_World_GetStreetName.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.