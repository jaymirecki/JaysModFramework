# Game.StartNewScript Method (String)

﻿Game.StartNewScript Method (String)

|  |  |  |
| --- | --- | --- |
| GameStartNewScript Method (String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Starts a new instance of the game script with the specified name with a stack size of 1424.

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
public static uint StartNewScript(
	string name
)
```

```
Public Shared Function StartNewScript ( 
	name As String
) As UInteger
```

```
public:
static unsigned int StartNewScript(
	String^ name
)
```

#### Parameters

name
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name.

#### Return Value

Type: [UInt32](http://msdn2.microsoft.com/en-us/library/ctys3981)  
An unsigned int representing a handle to the started script.

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentException](http://msdn2.microsoft.com/en-us/library/3w1b3114) | Thrown if the specified name does not represent a valid script. |

Remarks

If the specified script has not already been loaded, this method is not guaranteed to return on the same tick.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[StartNewScript Overload](Overload_Rage_Game_StartNewScript.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.