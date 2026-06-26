# Game.GetLocalizedString Method

﻿Game.GetLocalizedString Method 

|  |  |  |
| --- | --- | --- |
| GameGetLocalizedString Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the localized string from the specified localization string id.

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
public static string GetLocalizedString(
	string localizationStringId
)
```

```
Public Shared Function GetLocalizedString ( 
	localizationStringId As String
) As String
```

```
public:
static String^ GetLocalizedString(
	String^ localizationStringId
)
```

#### Parameters

localizationStringId
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The localization string identifier.

#### Return Value

Type: [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
If successful, returns a [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf) representing the localized version of the specified localization string; otherwise, returns null.

Examples

This example will display a notification with "White Shorts" if the game language is set to english.

[Copy](# "Copy")

```
Game.DisplayNotification(Game.GetLocalizedString("LEGS_P1_14_0"));
```

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.