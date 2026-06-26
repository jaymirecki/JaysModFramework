# Game.FadeScreenIn Method (Int32, Boolean)

﻿Game.FadeScreenIn Method (Int32, Boolean)

|  |  |  |
| --- | --- | --- |
| GameFadeScreenIn Method (Int32, Boolean) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Fades the screen in over the specified amount of time.

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
public static void FadeScreenIn(
	int ms,
	bool wait
)
```

```
Public Shared Sub FadeScreenIn ( 
	ms As Integer,
	wait As Boolean
)
```

```
public:
static void FadeScreenIn(
	int ms, 
	bool wait
)
```

#### Parameters

ms
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The time it takes to fade in, in milliseconds.

wait
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    Whether or not the call should block the current thread until the screen is faded in.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[FadeScreenIn Overload](Overload_Rage_Game_FadeScreenIn.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.