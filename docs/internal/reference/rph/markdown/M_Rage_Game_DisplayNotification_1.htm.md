# Game.DisplayNotification Method (String, String, String, String, String)

﻿Game.DisplayNotification Method (String, String, String, String, String)

|  |  |  |
| --- | --- | --- |
| GameDisplayNotification Method (String, String, String, String, String) | RAGE Plugin Hook Documentation |  |

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
	string textureDictionaryName,
	string textureName,
	string title,
	string subtitle,
	string text
)
```

```
Public Shared Function DisplayNotification ( 
	textureDictionaryName As String,
	textureName As String,
	title As String,
	subtitle As String,
	text As String
) As UInteger
```

```
public:
static unsigned int DisplayNotification(
	String^ textureDictionaryName, 
	String^ textureName, 
	String^ title, 
	String^ subtitle, 
	String^ text
)
```

#### Parameters

textureDictionaryName
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the game defined texture dictionary to display.

textureName
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the texture in the dictionary to display.

title
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The title of the notification. Any HTML tags will be stripped.

subtitle
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The subtitle of the notification. Any HTML tags will be stripped.

text
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  

    The text to display.

    Supports a small subset of HTML.

    Note, that while the limit for this parameter is ~960 characters, notifications displayed using this overload has a small visual limit. The smaller the font size, the more text can be displayed. Use the overload for long texts.

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