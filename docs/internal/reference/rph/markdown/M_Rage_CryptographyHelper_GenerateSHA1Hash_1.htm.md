# CryptographyHelper.GenerateSHA1Hash Method (String)

﻿CryptographyHelper.GenerateSHA1Hash Method (String)

|  |  |  |
| --- | --- | --- |
| CryptographyHelperGenerateSHA1Hash Method (String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Generates a SHA-1 (Secure Hash Algorithm) checksum from the specified text.

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
public static string GenerateSHA1Hash(
	string text
)
```

```
Public Shared Function GenerateSHA1Hash ( 
	text As String
) As String
```

```
public:
static String^ GenerateSHA1Hash(
	String^ text
)
```

#### Parameters

text
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The text to generate the checksum from. Assumes UTF8 encoding.

#### Return Value

Type: [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
Returns the 40 byte checksum of the specified text.

See Also

#### Reference

[CryptographyHelper Class](T_Rage_CryptographyHelper.htm)

[GenerateSHA1Hash Overload](Overload_Rage_CryptographyHelper_GenerateSHA1Hash.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.