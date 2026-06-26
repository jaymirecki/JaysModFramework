# ConsoleCommand Class

﻿ConsoleCommand Class

|  |  |  |
| --- | --- | --- |
| ConsoleCommand Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.ConsoleCommands.ConsoleCommand"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemMarshalByRefObject](http://msdn2.microsoft.com/en-us/library/w4302s1f)  
    HookMarshalByRefObject  
      Rage.ConsoleCommandsConsoleCommand  
**Namespace:**
 [Rage.ConsoleCommands](N_Rage_ConsoleCommands.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
[SerializableAttribute]
public sealed class ConsoleCommand : HookMarshalByRefObject
```

```
<SerializableAttribute>
Public NotInheritable Class ConsoleCommand
	Inherits HookMarshalByRefObject
```

```
[SerializableAttribute]
public ref class ConsoleCommand sealed : public HookMarshalByRefObject
```

The ConsoleCommand type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleCommand](M_Rage_ConsoleCommands_ConsoleCommand__ctor.htm) | Initializes a new instance of the ConsoleCommand class |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Description](P_Rage_ConsoleCommands_ConsoleCommand_Description.htm) |  |
| Public property | [Method](P_Rage_ConsoleCommands_ConsoleCommand_Method.htm) |  |
| Public property | [Name](P_Rage_ConsoleCommands_ConsoleCommand_Name.htm) |  |
| Public property | [Parameters](P_Rage_ConsoleCommands_ConsoleCommand_Parameters.htm) |  |
| Public property | [Plugin](P_Rage_ConsoleCommands_ConsoleCommand_Plugin.htm) |  |
| Public property | [Source](P_Rage_ConsoleCommands_ConsoleCommand_Source.htm) |  |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [CreateConsoleCommand](M_Rage_ConsoleCommands_ConsoleCommand_CreateConsoleCommand.htm) |  |
| Public method | [Execute](M_Rage_ConsoleCommands_ConsoleCommand_Execute.htm) |  |
| Public method | [HasSameParameterTypes](M_Rage_ConsoleCommands_ConsoleCommand_HasSameParameterTypes.htm) |  |
| Public method | [ParseAndExecute](M_Rage_ConsoleCommands_ConsoleCommand_ParseAndExecute.htm) |  |

[Top](#mainBody)

Events

|  | Name | Description |
| --- | --- | --- |
| Public event | [Executed](E_Rage_ConsoleCommands_ConsoleCommand_Executed.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage.ConsoleCommands Namespace](N_Rage_ConsoleCommands.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.