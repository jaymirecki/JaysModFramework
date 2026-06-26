# KeyboardState.ReleasedKeys Property

﻿KeyboardState.ReleasedKeys Property 

|  |  |  |
| --- | --- | --- |
| KeyboardStateReleasedKeys Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets released keys.

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
public ICollection<Keys> ReleasedKeys { get; }
```

```
Public ReadOnly Property ReleasedKeys As ICollection(Of Keys)
	Get
```

```
public:
property ICollection<Keys>^ ReleasedKeys {
	ICollection<Keys>^ get ();
}
```

#### Property Value

Type: [ICollection](http://msdn2.microsoft.com/en-us/library/92t2ye13)[Keys](http://msdn2.microsoft.com/en-us/library/xy8ebtbf)  
A collection of type [Keys](http://msdn2.microsoft.com/en-us/library/xy8ebtbf), containing all currently released keys.

See Also

#### Reference

[KeyboardState Class](T_Rage_KeyboardState.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.