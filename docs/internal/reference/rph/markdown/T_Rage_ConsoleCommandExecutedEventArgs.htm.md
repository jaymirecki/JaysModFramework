# ConsoleCommandExecutedEventArgs Class

﻿ConsoleCommandExecutedEventArgs Class

|  |  |  |
| --- | --- | --- |
| ConsoleCommandExecutedEventArgs Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Provides data for the [!:ConsoleCommand::Executed] event

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemEventArgs](http://msdn2.microsoft.com/en-us/library/118wxtk3)  
    RageConsoleCommandExecutedEventArgs  
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
[SerializableAttribute]
public sealed class ConsoleCommandExecutedEventArgs : EventArgs
```

```
<SerializableAttribute>
Public NotInheritable Class ConsoleCommandExecutedEventArgs
	Inherits EventArgs
```

```
[SerializableAttribute]
public ref class ConsoleCommandExecutedEventArgs sealed : public EventArgs
```

The ConsoleCommandExecutedEventArgs type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleCommandExecutedEventArgs](M_Rage_ConsoleCommandExecutedEventArgs__ctor.htm) | Initializes a new instance of the ConsoleCommandExecutedEventArgs class |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Arguments](P_Rage_ConsoleCommandExecutedEventArgs_Arguments.htm) |  |
| Public property | [Command](P_Rage_ConsoleCommandExecutedEventArgs_Command.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.