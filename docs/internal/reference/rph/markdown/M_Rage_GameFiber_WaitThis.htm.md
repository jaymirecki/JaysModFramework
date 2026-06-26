# GameFiber.WaitThis Method

﻿GameFiber.WaitThis Method 

|  |  |  |
| --- | --- | --- |
| GameFiberWaitThis Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Waits this instance the specified duration. Note that only the active [GameFiber](T_Rage_GameFiber.htm) can be set to wait.

Unlike sleep, wait is scaled based on game time dilation.

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
protected virtual void WaitThis(
	int duration
)
```

```
Protected Overridable Sub WaitThis ( 
	duration As Integer
)
```

```
protected:
virtual void WaitThis(
	int duration
)
```

#### Parameters

duration
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The duration, in milliseconds, to wait the fiber for.

See Also

#### Reference

[GameFiber Class](T_Rage_GameFiber.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.