# Game.DisplayHelp Method (String, Int32)

﻿Game.DisplayHelp Method (String, Int32)

|  |  |  |
| --- | --- | --- |
| GameDisplayHelp Method (String, Int32) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Displays the specified text in the help box.

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
public static void DisplayHelp(
	string text,
	int duration
)
```

```
Public Shared Sub DisplayHelp ( 
	text As String,
	duration As Integer
)
```

```
public:
static void DisplayHelp(
	String^ text, 
	int duration
)
```

#### Parameters

text
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The text to display.

duration
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The duration to display the help box, in milliseconds. If a negative value is specified, the duration will default to 8 seconds.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[DisplayHelp Overload](Overload_Rage_Game_DisplayHelp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.