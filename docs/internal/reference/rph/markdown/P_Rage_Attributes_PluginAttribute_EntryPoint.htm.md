# PluginAttribute.EntryPoint Property

﻿PluginAttribute.EntryPoint Property 

|  |  |  |
| --- | --- | --- |
| PluginAttributeEntryPoint Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the full name of the method to serve as entry point of the plugin (Eg. "EntryPoint.Main". If null, the first found method that's static, returns void and is named "Main" will be used.

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
public string EntryPoint { get; set; }
```

```
Public Property EntryPoint As String
	Get
	Set
```

```
public:
property String^ EntryPoint {
	String^ get ();
	void set (String^ value);
}
```

#### Property Value

Type: [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
The full name (type and method) of the method to call when the plugin is loaded.

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentNullException](http://msdn2.microsoft.com/en-us/library/27426hcy) | Thrown if value is null. |

See Also

#### Reference

[PluginAttribute Class](T_Rage_Attributes_PluginAttribute.htm)

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.