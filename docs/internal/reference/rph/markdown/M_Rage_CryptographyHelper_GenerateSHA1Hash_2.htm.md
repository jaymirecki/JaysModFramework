# CryptographyHelper.GenerateSHA1Hash Method (String, Encoding)

﻿CryptographyHelper.GenerateSHA1Hash Method (String, Encoding)

|  |  |  |
| --- | --- | --- |
| CryptographyHelperGenerateSHA1Hash Method (String, Encoding) | RAGE Plugin Hook Documentation |  |

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
	string text,
	Encoding encoding
)
```

```
Public Shared Function GenerateSHA1Hash ( 
	text As String,
	encoding As Encoding
) As String
```

```
public:
static String^ GenerateSHA1Hash(
	String^ text, 
	Encoding^ encoding
)
```

#### Parameters

text
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The text to generate the checksum from.

encoding
:   Type: [System.TextEncoding](http://msdn2.microsoft.com/en-us/library/86hf4sb8)  
    The encoding of the text.

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