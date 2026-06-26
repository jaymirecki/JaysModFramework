# EmergencyLighting.Name Property

﻿EmergencyLighting.Name Property 

|  |  |  |
| --- | --- | --- |
| EmergencyLightingName Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the name of this instance.

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
public string Name { get; set; }
```

```
Public Property Name As String
	Get
	Set
```

```
public:
property String^ Name {
	String^ get ();
	void set (String^ value);
}
```

#### Property Value

Type: [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
The name of this instance. Cannot be null.

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentNullException](http://msdn2.microsoft.com/en-us/library/27426hcy) | Thrown if the value is null. |

See Also

#### Reference

[EmergencyLighting Class](T_Rage_EmergencyLighting.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.