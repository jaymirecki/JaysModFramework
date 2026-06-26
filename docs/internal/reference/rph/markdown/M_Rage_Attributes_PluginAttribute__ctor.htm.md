# PluginAttribute Constructor

﻿PluginAttribute Constructor 

|  |  |  |
| --- | --- | --- |
| PluginAttribute Constructor | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Initializes a new instance of the [PluginAttribute](T_Rage_Attributes_PluginAttribute.htm) class.

**Namespace:**
 [Rage.Attributes](N_Rage_Attributes.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
public PluginAttribute(
	string name
)
```

```
Public Sub New ( 
	name As String
)
```

```
public:
PluginAttribute(
	String^ name
)
```

#### Parameters

name
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The human readable name of the plugin displayed to the end user.

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentNullException](http://msdn2.microsoft.com/en-us/library/27426hcy) | Thrown if the name parameter is null. |

See Also

#### Reference

[PluginAttribute Class](T_Rage_Attributes_PluginAttribute.htm)

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.