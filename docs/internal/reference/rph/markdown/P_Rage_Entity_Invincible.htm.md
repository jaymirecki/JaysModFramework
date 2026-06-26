# Entity.Invincible Property

﻿Entity.Invincible Property 

|  |  |  |
| --- | --- | --- |
| EntityInvincible Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

**Note: This API is now obsolete.**

Sets a value indicating whether this instance is invincible.

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
[ObsoleteAttribute("Use IsInvincible instead. This property will be removed in an update.", 
	true)]
public bool Invincible { set; }
```

```
<ObsoleteAttribute("Use IsInvincible instead. This property will be removed in an update.", 
	true)>
Public WriteOnly Property Invincible As Boolean
	Set
```

```
public:
[ObsoleteAttribute(L"Use IsInvincible instead. This property will be removed in an update.", 
	true)]
property bool Invincible {
	void set (bool value);
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if this instance is invincible; otherwise, false.

See Also

#### Reference

[Entity Class](T_Rage_Entity.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.