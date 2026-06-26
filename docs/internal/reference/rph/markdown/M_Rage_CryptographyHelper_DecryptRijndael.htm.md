# CryptographyHelper.DecryptRijndael Method

﻿CryptographyHelper.DecryptRijndael Method 

|  |  |  |
| --- | --- | --- |
| CryptographyHelperDecryptRijndael Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Decrypts the specified byte array using AES (Advanced Encryption Standard).

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
public static byte[] DecryptRijndael(
	byte[] valueBytes,
	string password
)
```

```
Public Shared Function DecryptRijndael ( 
	valueBytes As Byte(),
	password As String
) As Byte()
```

```
public:
static array<unsigned char>^ DecryptRijndael(
	array<unsigned char>^ valueBytes, 
	String^ password
)
```

#### Parameters

valueBytes
:   Type: [SystemByte](http://msdn2.microsoft.com/en-us/library/yyb1w04y)  
    The data to decrypt.

password
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The password that was used to encrypt the data with.

#### Return Value

Type: [Byte](http://msdn2.microsoft.com/en-us/library/yyb1w04y)  
A byte array representing the decrypted data.

See Also

#### Reference

[CryptographyHelper Class](T_Rage_CryptographyHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.