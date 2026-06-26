# Game.HasAchievementBeenPassed Method

﻿Game.HasAchievementBeenPassed Method 

|  |  |  |
| --- | --- | --- |
| GameHasAchievementBeenPassed Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether the specified achievement has been passed.

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
public static bool HasAchievementBeenPassed(
	Achievement achievement
)
```

```
Public Shared Function HasAchievementBeenPassed ( 
	achievement As Achievement
) As Boolean
```

```
public:
static bool HasAchievementBeenPassed(
	Achievement achievement
)
```

#### Parameters

achievement
:   Type: [RageAchievement](T_Rage_Achievement.htm)  
    The achievement identifier.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if the achievement has been passed; otherwise, false

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.