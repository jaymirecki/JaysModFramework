# EmergencyLighting.Clone Method (String)

﻿EmergencyLighting.Clone Method (String)

|  |  |  |
| --- | --- | --- |
| EmergencyLightingClone Method (String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a new [EmergencyLighting](T_Rage_EmergencyLighting.htm) that is a copy of the current instance.

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
public EmergencyLighting Clone(
	string name
)
```

```
Public Function Clone ( 
	name As String
) As EmergencyLighting
```

```
public:
EmergencyLighting^ Clone(
	String^ name
)
```

#### Parameters

name
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the cloned copy. If null, a unique name will be assigned automatically.

#### Return Value

Type: [EmergencyLighting](T_Rage_EmergencyLighting.htm)  
A new [EmergencyLighting](T_Rage_EmergencyLighting.htm) that is a copy of this instance.

See Also

#### Reference

[EmergencyLighting Class](T_Rage_EmergencyLighting.htm)

[Clone Overload](Overload_Rage_EmergencyLighting_Clone.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.