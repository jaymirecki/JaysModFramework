# Game.FindAllOccurrencesOfPattern Method (String, IntPtr)

﻿Game.FindAllOccurrencesOfPattern Method (String, IntPtr)

|  |  |  |
| --- | --- | --- |
| GameFindAllOccurrencesOfPattern Method (String, IntPtr) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Finds all occurrences of the specified pattern of bytes in the game's memory.

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
public static IntPtr[] FindAllOccurrencesOfPattern(
	string pattern,
	IntPtr startAddress
)
```

```
Public Shared Function FindAllOccurrencesOfPattern ( 
	pattern As String,
	startAddress As IntPtr
) As IntPtr()
```

```
public:
static array<IntPtr>^ FindAllOccurrencesOfPattern(
	String^ pattern, 
	IntPtr startAddress
)
```

#### Parameters

pattern
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The pattern to find. Wildcard ?? is supported.

startAddress
:   Type: [SystemIntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8)  
    The address to start searching at. If [Zero](http://msdn2.microsoft.com/en-us/library/c61h0w61), search is started at the base address.

#### Return Value

Type: [IntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8)  
An [IntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8) representing the memory location the pattern was found at, or [Zero](http://msdn2.microsoft.com/en-us/library/c61h0w61) if the pattern wasn't found.

Remarks

The pattern should be in the following format:

XX XX XX XX XX XX XX XX XX XX

Where each XX is a hexadecimal value representing the byte, or ?? to indicate a wildcard.

eg. "77 37 E8 ?? ?? ?? ?? 84 C0"

All white space is ignored.

Even though the search algorithm is fast, you shouldn't be calling this every frame.

Ideally, you want to find all the patterns you need when your plugin initializes.

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[FindAllOccurrencesOfPattern Overload](Overload_Rage_Game_FindAllOccurrencesOfPattern.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.