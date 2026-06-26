# Quaternion.Divide Method (Quaternion, Quaternion, Quaternion)

﻿Quaternion.Divide Method (Quaternion, Quaternion, Quaternion)

|  |  |  |
| --- | --- | --- |
| QuaternionDivide Method (Quaternion, Quaternion, Quaternion) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Divides a quaternion by another.

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
public static void Divide(
	ref Quaternion left,
	ref Quaternion right,
	out Quaternion result
)
```

```
Public Shared Sub Divide ( 
	ByRef left As Quaternion,
	ByRef right As Quaternion,
	<OutAttribute> ByRef result As Quaternion
)
```

```
public:
static void Divide(
	Quaternion% left, 
	Quaternion% right, 
	[OutAttribute] Quaternion% result
)
```

#### Parameters

left
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The first quaternion to divide.

right
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  
    The second quaternion to divide.

result
:   Type: [RageQuaternion](T_Rage_Quaternion.htm)  

    [Missing <param name="result"/> documentation for "M:Rage.Quaternion.Divide(Rage.Quaternion@,Rage.Quaternion@,Rage.Quaternion@)"]

#### Return Value

Type:   
The divided quaternion.

See Also

#### Reference

[Quaternion Structure](T_Rage_Quaternion.htm)

[Divide Overload](Overload_Rage_Quaternion_Divide.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.