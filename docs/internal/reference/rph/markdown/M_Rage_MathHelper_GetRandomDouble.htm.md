# MathHelper.GetRandomDouble Method

﻿MathHelper.GetRandomDouble Method 

|  |  |  |
| --- | --- | --- |
| MathHelperGetRandomDouble Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a random double precision floating point number between the specified minimum and maximum value, inclusive.

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
public static double GetRandomDouble(
	double minimum,
	double maximum
)
```

```
Public Shared Function GetRandomDouble ( 
	minimum As Double,
	maximum As Double
) As Double
```

```
public:
static double GetRandomDouble(
	double minimum, 
	double maximum
)
```

#### Parameters

minimum
:   Type: [SystemDouble](http://msdn2.microsoft.com/en-us/library/643eft0t)  
    The minimum value.

maximum
:   Type: [SystemDouble](http://msdn2.microsoft.com/en-us/library/643eft0t)  
    The maximum value.

#### Return Value

Type: [Double](http://msdn2.microsoft.com/en-us/library/643eft0t)  
A random double precision floating point number between minimum and maximum, inclusive.

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.