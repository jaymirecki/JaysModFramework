# Blip.Flash Method

﻿Blip.Flash Method 

|  |  |  |
| --- | --- | --- |
| BlipFlash Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Makes [Blip](T_Rage_Blip.htm) blip flash at the specified interval for the specified duration.

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
public void Flash(
	int interval,
	int duration
)
```

```
Public Sub Flash ( 
	interval As Integer,
	duration As Integer
)
```

```
public:
void Flash(
	int interval, 
	int duration
)
```

#### Parameters

interval
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The interval to flash at. Must be greater than zero.

duration
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The duration to flash for. If zero or less, the [Blip](T_Rage_Blip.htm) will flash forever.

See Also

#### Reference

[Blip Class](T_Rage_Blip.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.