# PluginAttribute.DefaultObjectType Property

﻿PluginAttribute.DefaultObjectType Property 

|  |  |  |
| --- | --- | --- |
| PluginAttributeDefaultObjectType Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the full name of the default type that will be used to represent objects. The type must inherit from [!:Rage::Object]. If null, [!:Rage::Object] will be used.

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
public string DefaultObjectType { get; set; }
```

```
Public Property DefaultObjectType As String
	Get
	Set
```

```
public:
property String^ DefaultObjectType {
	String^ get ();
	void set (String^ value);
}
```

#### Property Value

Type: [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
The full name of the default type that will be used to represent vehicles. The type must inherit from [!:Rage::Object]. If null, [!:Rage::Object] will be used..

See Also

#### Reference

[PluginAttribute Class](T_Rage_Attributes_PluginAttribute.htm)

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.