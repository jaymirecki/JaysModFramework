# Game.DisplayNotification Method (String)

﻿Game.DisplayNotification Method (String)

|  |  |  |
| --- | --- | --- |
| GameDisplayNotification Method (String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Adds a new notification above the map.

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
public static uint DisplayNotification(
	string text
)
```

```
Public Shared Function DisplayNotification ( 
	text As String
) As UInteger
```

```
public:
static unsigned int DisplayNotification(
	String^ text
)
```

#### Parameters

text
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  

    The text to display.

    Supports a small subset of HTML.

    Note, that while the limit for this parameter is ~960 characters, the notification can only visually contain around ~800 characters of default sized text. The limit of ~960 characters can still be reached for texts that are shorter than 800 characters, eg. lots of HTML encoding.

#### Return Value

Type: [UInt32](http://msdn2.microsoft.com/en-us/library/ctys3981)  
An unsigned 32-bit integer, representing the handle to the notification.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[DisplayNotification Overload](Overload_Rage_Game_DisplayNotification.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.