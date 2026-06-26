# Game.DisplaySubtitle Method (String)

﻿Game.DisplaySubtitle Method (String)

|  |  |  |
| --- | --- | --- |
| GameDisplaySubtitle Method (String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Displays the specified text in a subtitle.

The display duration will be automatically calculated based on the reading speed of the average human.

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
public static void DisplaySubtitle(
	string text
)
```

```
Public Shared Sub DisplaySubtitle ( 
	text As String
)
```

```
public:
static void DisplaySubtitle(
	String^ text
)
```

#### Parameters

text
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The text to display.

Remarks

The display duration is calculated as 2 seconds + reading time for the text based on the reading speed of an average human.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[DisplaySubtitle Overload](Overload_Rage_Game_DisplaySubtitle.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.