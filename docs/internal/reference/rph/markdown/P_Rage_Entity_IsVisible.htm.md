# Entity.IsVisible Property

﻿Entity.IsVisible Property 

|  |  |  |
| --- | --- | --- |
| EntityIsVisible Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets a value indicating whether this instance is currently visible within the game world.

Invisible instances will still be processed but will not be rendered.

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
public virtual bool IsVisible { get; set; }
```

```
Public Overridable Property IsVisible As Boolean
	Get
	Set
```

```
public:
virtual property bool IsVisible {
	bool get ();
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  

[Missing <value> documentation for "P:Rage.Entity.IsVisible"]

#### Implements

[IVisualIsVisible](P_Rage_IVisual_IsVisible.htm)  

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.