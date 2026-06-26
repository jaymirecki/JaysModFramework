# PluginAttribute.PrefersSingleInstance Property

﻿PluginAttribute.PrefersSingleInstance Property 

|  |  |  |
| --- | --- | --- |
| PluginAttributePrefersSingleInstance Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets a value indicating whether this plugin prefers to only have one instance of itself loaded at any given time.

If true the plugin can still be loaded multiple times, but requires the force parameter of the LoadPlugin command to be set to true.

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
public bool PrefersSingleInstance { get; set; }
```

```
Public Property PrefersSingleInstance As Boolean
	Get
	Set
```

```
public:
property bool PrefersSingleInstance {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this plugin prefers a single instance; otherwise, false.

See Also

#### Reference

[PluginAttribute Class](T_Rage_Attributes_PluginAttribute.htm)

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.