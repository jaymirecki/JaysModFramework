# CryptographyHelper.GenerateMD5Hash Method (String)

﻿CryptographyHelper.GenerateMD5Hash Method (String)

|  |  |  |
| --- | --- | --- |
| CryptographyHelperGenerateMD5Hash Method (String) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Generates an MD5 (Message Digest 5) checksum from the specified text.

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
public static string GenerateMD5Hash(
	string text
)
```

```
Public Shared Function GenerateMD5Hash ( 
	text As String
) As String
```

```
public:
static String^ GenerateMD5Hash(
	String^ text
)
```

#### Parameters

text
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The text to generate the checksum from. Assumes UTF8 encoding.

#### Return Value

Type: [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
Returns the 32 byte checksum of the specified text.

See Also

#### Reference

[CryptographyHelper Class](T_Rage_CryptographyHelper.htm)

[GenerateMD5Hash Overload](Overload_Rage_CryptographyHelper_GenerateMD5Hash.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.