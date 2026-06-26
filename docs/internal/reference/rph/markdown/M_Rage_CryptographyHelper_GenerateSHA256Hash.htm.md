# CryptographyHelper.GenerateSHA256Hash Method (Stream)

﻿CryptographyHelper.GenerateSHA256Hash Method (Stream)

|  |  |  |
| --- | --- | --- |
| CryptographyHelperGenerateSHA256Hash Method (Stream) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Generates a SHA-256 (Secure Hash Algorithm) checksum from the specified stream.

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
public static string GenerateSHA256Hash(
	Stream stream
)
```

```
Public Shared Function GenerateSHA256Hash ( 
	stream As Stream
) As String
```

```
public:
static String^ GenerateSHA256Hash(
	Stream^ stream
)
```

#### Parameters

stream
:   Type: [System.IOStream](http://msdn2.microsoft.com/en-us/library/8f86tw9e)  
    The stream to generate the checksum from. Reading starts from the current position.

#### Return Value

Type: [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
Returns the 64 byte checksum of the data in the specified stream.

See Also

#### Reference

[CryptographyHelper Class](T_Rage_CryptographyHelper.htm)

[GenerateSHA256Hash Overload](Overload_Rage_CryptographyHelper_GenerateSHA256Hash.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.