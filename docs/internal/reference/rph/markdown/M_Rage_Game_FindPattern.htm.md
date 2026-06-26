# Game.FindPattern Method (String)

﻿Game.FindPattern Method (String)

|  |  |  |
| --- | --- | --- |
| GameFindPattern Method (String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Finds the specified pattern of bytes in the game's memory.

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
public static IntPtr FindPattern(
	string pattern
)
```

```
Public Shared Function FindPattern ( 
	pattern As String
) As IntPtr
```

```
public:
static IntPtr FindPattern(
	String^ pattern
)
```

#### Parameters

pattern
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The pattern to find. Wildcard ?? is supported.

#### Return Value

Type: [IntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8)  
An [IntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8) representing the memory location the pattern was found at, or [Zero](http://msdn2.microsoft.com/en-us/library/c61h0w61) if the pattern wasn't found.

Remarks

The pattern should be in the following format:

XX XX XX XX XX XX XX XX XX XX

Where each XX is a hexadecimal value representing the byte, or ?? to indicate a wildcard.

eg. "77 37 E8 ?? ?? ?? ?? 84 C0"

All white space is ignored.

Scan starts at the base address. Use overload to specify start address.

Even though the search algorithm is fast, you shouldn't be calling this every frame.

Ideally, you want to find all the patterns you need when your plugin initializes.

Examples

When a new game patch is released, the memory layout of the game process changes.
This means that variables, code, etc. is no longer at the same offsets as in a previous patch.
To overcome this problem, byte pattern scanning can be used to find the correct addresses.

The following example shows a method that uses FindPattern to locate a piece of code
that accesses the GameTime variable (The variable accessed by GET\_GAME\_TIMER),
and then gets the address of the variable.

C#

[Copy](# "Copy")

```
private static IntPtr gameTimeAddress;
private unsafe static uint GetGameTime()
{
    if (gameTimeAddress == IntPtr.Zero)
    {
        string pattern =
        "8B 05 ?? ?? ?? ??" +   // mov     eax, [????????]
        "05 D0 07 00 00" +      // add     eax, 7D0h
        "39 05 ?? ?? ?? ??" +   // cmp     [GameTime], eax
        "77 37" +               // ja      short ????????
        "E8 ?? ?? ?? ??";      // call    ????????
        IntPtr address = Game.FindPattern(pattern);
        if (address == IntPtr.Zero)
        {
            // Pattern not found.
            return 0u;
        }

        address += 11; // Brings the address to the cmp instruction (39 05 ?? ?? ?? ??).

        // The CMP instruction uses an offset to the variable, not an absolute address.
        // The offset is from the address of the next instruction.
        // The offset is the last 4 bytes of the instruction.
        long offset = (long)*(int*)(address + 2); // Read the offset (cmp instruction address + 2).
        gameTimeAddress = (IntPtr)(address.ToInt64() + 6 + offset); // Address of GameTime = address of cmp instruction + size of cmp instruction (to get to next instruction) + offset.
    }

    return *(uint*)gameTimeAddress;
}
```

See Also

#### Reference

[Game Class](T_Rage_Game.htm)

[FindPattern Overload](Overload_Rage_Game_FindPattern.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.