# EmergencyLighting.Get Method

﻿EmergencyLighting.Get Method 

|  |  |  |
| --- | --- | --- |
| EmergencyLightingGet Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets all [EmergencyLighting](T_Rage_EmergencyLighting.htm) currently in memory.

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
public static EmergencyLighting[] Get(
	bool builtIn,
	bool custom
)
```

```
Public Shared Function Get ( 
	builtIn As Boolean,
	custom As Boolean
) As EmergencyLighting()
```

```
public:
static array<EmergencyLighting^>^ Get(
	bool builtIn, 
	bool custom
)
```

#### Parameters

builtIn
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If set to true, built in instances will be included.

custom
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    If set to true, custom instances will be included.

#### Return Value

Type: [EmergencyLighting](T_Rage_EmergencyLighting.htm)  
An array of type [EmergencyLighting](T_Rage_EmergencyLighting.htm) containing all types matching the specified arguments.

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentException](http://msdn2.microsoft.com/en-us/library/3w1b3114) | Thrown if both  and  are set to false. |

See Also

#### Reference

[EmergencyLighting Class](T_Rage_EmergencyLighting.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.