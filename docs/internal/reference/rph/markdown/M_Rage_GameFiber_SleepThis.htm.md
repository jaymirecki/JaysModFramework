# GameFiber.SleepThis Method

﻿GameFiber.SleepThis Method 

|  |  |  |
| --- | --- | --- |
| GameFiberSleepThis Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sleeps this instance the specified duration. Note that only the active [GameFiber](T_Rage_GameFiber.htm) can be set to sleep.

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
protected virtual void SleepThis(
	int duration
)
```

```
Protected Overridable Sub SleepThis ( 
	duration As Integer
)
```

```
protected:
virtual void SleepThis(
	int duration
)
```

#### Parameters

duration
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The duration, in milliseconds, to sleep the fiber for.

See Also

#### Reference

[GameFiber Class](T_Rage_GameFiber.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.