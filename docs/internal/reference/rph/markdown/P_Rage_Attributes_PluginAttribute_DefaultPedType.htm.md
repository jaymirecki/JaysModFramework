# PluginAttribute.DefaultPedType Property

﻿PluginAttribute.DefaultPedType Property 

|  |  |  |
| --- | --- | --- |
| PluginAttributeDefaultPedType Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the full name of the default type that will be used to represent peds. The type must inherit from [Ped](T_Rage_Ped.htm). If null, [Ped](T_Rage_Ped.htm) will be used.

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
public string DefaultPedType { get; set; }
```

```
Public Property DefaultPedType As String
	Get
	Set
```

```
public:
property String^ DefaultPedType {
	String^ get ();
	void set (String^ value);
}
```

#### Property Value

Type: [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
The full name of the default type that will be used to represent peds. The type must inherit from [Ped](T_Rage_Ped.htm). If null, [Ped](T_Rage_Ped.htm) will be used..

See Also

#### Reference

[PluginAttribute Class](T_Rage_Attributes_PluginAttribute.htm)

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.