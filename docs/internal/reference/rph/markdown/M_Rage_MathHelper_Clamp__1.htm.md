# MathHelper.Clamp(T) Method

﻿MathHelper.Clamp(T) Method 

|  |  |  |
| --- | --- | --- |
| MathHelperClampT Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the specified value between the specified minimum and maximum values.

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
public static T Clamp<T>(
	T value,
	T minimum,
	T maximum
)
where T : Object, IComparable<T>
```

```
Public Shared Function Clamp(Of T As {Object, IComparable(Of T)}) ( 
	value As T,
	minimum As T,
	maximum As T
) As T
```

```
public:
generic<typename T>
where T : Object, IComparable<T>
static T Clamp(
	T value, 
	T minimum, 
	T maximum
)
```

#### Parameters

value
:   Type: T  

    [Missing <param name="value"/> documentation for "M:Rage.MathHelper.Clamp``1(``0,``0,``0)"]

minimum
:   Type: T  
    The minimum value.

maximum
:   Type: T  
    The maximum value.

#### Type Parameters

T
:   The type of the values specified.

#### Return Value

Type: T  
The resulting clamped value.

Exceptions

| Exception | Condition |
| --- | --- |
| [!:System.ArgumentException] | Thrown if minimum is greater than maximum. |

See Also

#### Reference

[MathHelper Class](T_Rage_MathHelper.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.