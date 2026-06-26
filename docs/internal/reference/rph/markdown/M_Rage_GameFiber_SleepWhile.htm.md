# GameFiber.SleepWhile Method

﻿GameFiber.SleepWhile Method 

|  |  |  |
| --- | --- | --- |
| GameFiberSleepWhile Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Yields the executing fiber while the specified condition is met.

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
public static void SleepWhile(
	Func<bool> condition,
	int timeOut
)
```

```
Public Shared Sub SleepWhile ( 
	condition As Func(Of Boolean),
	timeOut As Integer
)
```

```
public:
static void SleepWhile(
	Func<bool>^ condition, 
	int timeOut
)
```

#### Parameters

condition
:   Type: [SystemFunc](http://msdn2.microsoft.com/en-us/library/bb534960)[Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    The condition.

timeOut
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The maximum time to sleep. If set to 0, the call will not time out.

Examples

The following statement:

C#

[Copy](# "Copy")

```
GameFiber.SleepWhile(() => vehicle && vehicle.Speed < FiftyKilometersPerHour, 30000);
```

Is equivalent to the following piece of code:

C#

[Copy](# "Copy")

```
ulong startTime = Game.TickCount;
while (vehicle && vehicle.Speed < FiftyKilometersPerHour)
{
    if (Game.TickCount > startTime + 5000)
    {
        break;
    }

    GameFiber.Yield();
}
```

Examples

The following statement:

C#

[Copy](# "Copy")

```
GameFiber.SleepWhile(() => vehicle && vehicle.Speed < FiftyKilometersPerHour, 0);
```

Is equivalent to the following piece of code:

C#

[Copy](# "Copy")

```
while (vehicle && vehicle.Speed < FiftyKilometersPerHour)
{
    GameFiber.Yield();
}
```

See Also

#### Reference

[GameFiber Class](T_Rage_GameFiber.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.