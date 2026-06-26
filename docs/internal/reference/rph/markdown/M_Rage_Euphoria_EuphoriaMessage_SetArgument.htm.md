# EuphoriaMessage.SetArgument Method

﻿EuphoriaMessage.SetArgument Method 

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageSetArgument Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Sets the specified argument to this [EuphoriaMessage](T_Rage_Euphoria_EuphoriaMessage.htm).

Note that this overrides existing arguments with the same name. If this is not desired, use the [!:Rage::EuphoriaMessage::PushArgument] overload.

**Namespace:**
 [Rage.Euphoria](N_Rage_Euphoria.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
public void SetArgument(
	string name,
	Object value
)
```

```
Public Sub SetArgument ( 
	name As String,
	value As Object
)
```

```
public:
void SetArgument(
	String^ name, 
	Object^ value
)
```

#### Parameters

name
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the argument.

value
:   Type: [SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
    The value of the argument.
    The following types are supported:
    [Int32](http://msdn2.microsoft.com/en-us/library/td2s409d)[Single](http://msdn2.microsoft.com/en-us/library/3www918f)[Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)[String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)[!:Rage::Vector3][!:Rage::IHandleable] (Rage.Vehicle, Rage.Ped, Rage.Object, etc.)
    [PoolHandle](T_Rage_PoolHandle.htm)

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentException](http://msdn2.microsoft.com/en-us/library/3w1b3114) | Thrown if the specified value is of an unsupported type. |

See Also

#### Reference

[EuphoriaMessage Class](T_Rage_Euphoria_EuphoriaMessage.htm)

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.