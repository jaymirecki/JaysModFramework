# Quaternion.Add Method (Quaternion, Quaternion, Quaternion)

﻿Quaternion.Add Method (Quaternion, Quaternion, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionAdd Method (Quaternion, Quaternion, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Adds two quaternions.

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
public static void Add(
	ref Quaternion left,
	ref Quaternion right,
	out Quaternion result
)
```

```
Public Shared Sub Add ( 
	ByRef left As Quaternion,
	ByRef right As Quaternion,
	<OutAttribute> ByRef result As Quaternion
)
```

```
public:
static void Add(
	Quaternion% left, 
	Quaternion% right, 
	[OutAttribute] Quaternion% result
)
```

#### Parameters

left
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The first quaternion to add.

right
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The second quaternion to add.

result
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    When the method completes, contains the sum of the two quaternions.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Add Overload](Overload_Rage_Quaternion_Add.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.