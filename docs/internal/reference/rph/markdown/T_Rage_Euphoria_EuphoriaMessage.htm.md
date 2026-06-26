# EuphoriaMessage Class

﻿EuphoriaMessage Class

|  |  |  |
| --- | --- | --- |
| EuphoriaMessage Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.Euphoria.EuphoriaMessage"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  Rage.EuphoriaEuphoriaMessage  
    [Rage.EuphoriaEuphoriaMessageShot](T_Rage_Euphoria_EuphoriaMessageShot.htm)  
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
[SerializableAttribute]
public class EuphoriaMessage
```

```
<SerializableAttribute>
Public Class EuphoriaMessage
```

```
[SerializableAttribute]
public ref class EuphoriaMessage
```

The EuphoriaMessage type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [EuphoriaMessage](M_Rage_Euphoria_EuphoriaMessage__ctor.htm) | Initializes a new instance of the EuphoriaMessage class |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Name](P_Rage_Euphoria_EuphoriaMessage_Name.htm) |  |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [PushArgument](M_Rage_Euphoria_EuphoriaMessage_PushArgument.htm) | Adds the specified argument to this EuphoriaMessage.  Note that this does not override existing arguments with the same name. If this is desired, use the [!:Rage::EuphoriaMessage::SetArgument] overload. |
| Public method | [Reset](M_Rage_Euphoria_EuphoriaMessage_Reset.htm) |  |
| Public method | [SendTo](M_Rage_Euphoria_EuphoriaMessage_SendTo.htm) |  |
| Public method | [SetArgument](M_Rage_Euphoria_EuphoriaMessage_SetArgument.htm) | Sets the specified argument to this EuphoriaMessage.  Note that this overrides existing arguments with the same name. If this is not desired, use the [!:Rage::EuphoriaMessage::PushArgument] overload. |

[Top](#mainBody)

See Also

#### Reference

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.