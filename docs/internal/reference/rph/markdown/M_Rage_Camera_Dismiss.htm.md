# Camera.Dismiss Method

﻿Camera.Dismiss Method 

|  |  |  |
| --- | --- | --- |
| CameraDismiss Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

If this instance is marked as persistent, makes the entity non-persistent. Non-persistent entities will be deleted from the game world during clean ups.

This is equivalent to setting IsPersistent to false.

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
public override sealed void Dismiss()
```

```
Public Overrides NotOverridable Sub Dismiss
```

```
public:
virtual void Dismiss() override sealed
```

#### Implements

[IPersistableDismiss](M_Rage_IPersistable_Dismiss.htm)  

See Also

#### Reference

[Camera Class](T_Rage_Camera.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.