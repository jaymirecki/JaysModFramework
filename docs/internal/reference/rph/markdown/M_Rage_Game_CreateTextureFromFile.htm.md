# Game.CreateTextureFromFile Method

﻿Game.CreateTextureFromFile Method 

|  |  |  |
| --- | --- | --- |
| GameCreateTextureFromFile Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Creates a new texture from the specified file.

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
public static Texture CreateTextureFromFile(
	string file
)
```

```
Public Shared Function CreateTextureFromFile ( 
	file As String
) As Texture
```

```
public:
static Texture^ CreateTextureFromFile(
	String^ file
)
```

#### Parameters

file
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The path to the file to create a texture from.

#### Return Value

Type: [Texture](T_Rage_Texture.htm)  
An instance of [Texture](T_Rage_Texture.htm) representing the created texture.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.