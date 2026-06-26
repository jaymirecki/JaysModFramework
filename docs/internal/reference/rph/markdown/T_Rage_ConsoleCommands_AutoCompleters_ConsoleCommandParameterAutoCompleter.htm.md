# ConsoleCommandParameterAutoCompleter Class

﻿ConsoleCommandParameterAutoCompleter Class

|  |  |  |
| --- | --- | --- |
| ConsoleCommandParameterAutoCompleter Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.ConsoleCommands.AutoCompleters.ConsoleCommandParameterAutoCompleter"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemMarshalByRefObject](http://msdn2.microsoft.com/en-us/library/w4302s1f)  
    HookMarshalByRefObject  
      Rage.ConsoleCommands.AutoCompletersConsoleCommandParameterAutoCompleter  
        [More...](#fullInheritance)**Namespace:**
 [Rage.ConsoleCommands.AutoCompleters](N_Rage_ConsoleCommands_AutoCompleters.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
[SerializableAttribute]
public abstract class ConsoleCommandParameterAutoCompleter : HookMarshalByRefObject
```

```
<SerializableAttribute>
Public MustInherit Class ConsoleCommandParameterAutoCompleter
	Inherits HookMarshalByRefObject
```

```
[SerializableAttribute]
public ref class ConsoleCommandParameterAutoCompleter abstract : public HookMarshalByRefObject
```

The ConsoleCommandParameterAutoCompleter type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleCommandParameterAutoCompleter](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter__ctor.htm) | Initializes a new instance of the ConsoleCommandParameterAutoCompleter class |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Options](P_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_Options.htm) |  |
| Public property | [Type](P_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_Type.htm) |  |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [CreateParameterAutoCompleterFromType](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_CreateParameterAutoCompleterFromType.htm) |  |
| Public methodStatic member | [FindDefaultAutoCompleterTypeForParameterType](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_FindDefaultAutoCompleterTypeForParameterType.htm) |  |
| Public method | [GetApplicableOption](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_GetApplicableOption.htm) |  |
| Public method | [GetApplicableOptions](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_GetApplicableOptions.htm) |  |
| Public method | [UpdateOptions](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_UpdateOptions.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage.ConsoleCommands.AutoCompleters Namespace](N_Rage_ConsoleCommands_AutoCompleters.htm)

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemMarshalByRefObject](http://msdn2.microsoft.com/en-us/library/w4302s1f)  
    HookMarshalByRefObject  
      Rage.ConsoleCommands.AutoCompletersConsoleCommandParameterAutoCompleter  
        [Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterBoolean](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterBoolean.htm)  
        [Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterHandleable](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable.htm)  
        [Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterModel](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterModel.htm)  
        [Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterWeapon](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterWeapon.htm)  
        [Rage.ConsoleCommands.AutoCompletersConsoleCommandFileNameParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandFileNameParameterAutoCompleter.htm)  
        [Rage.ConsoleCommands.AutoCompletersConsoleCommandParameterAutoCompleterEnum](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleterEnum.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.