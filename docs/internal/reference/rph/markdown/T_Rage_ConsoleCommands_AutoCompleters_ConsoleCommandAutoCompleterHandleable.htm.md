# ConsoleCommandAutoCompleterHandleable Class

﻿ConsoleCommandAutoCompleterHandleable Class

|  |  |  |
| --- | --- | --- |
| ConsoleCommandAutoCompleterHandleable Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.ConsoleCommands.AutoCompleters.ConsoleCommandAutoCompleterHandleable"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemMarshalByRefObject](http://msdn2.microsoft.com/en-us/library/w4302s1f)  
    HookMarshalByRefObject  
      [Rage.ConsoleCommands.AutoCompletersConsoleCommandParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter.htm)  
        Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterHandleable  
          [Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterEntity](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterEntity.htm)  
          [Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterPed](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterPed.htm)  
          [Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterVehicle](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterVehicle.htm)  
**Namespace:**
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
public abstract class ConsoleCommandAutoCompleterHandleable : ConsoleCommandParameterAutoCompleter
```

```
<SerializableAttribute>
Public MustInherit Class ConsoleCommandAutoCompleterHandleable
	Inherits ConsoleCommandParameterAutoCompleter
```

```
[SerializableAttribute]
public ref class ConsoleCommandAutoCompleterHandleable abstract : public ConsoleCommandParameterAutoCompleter
```

The ConsoleCommandAutoCompleterHandleable type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleCommandAutoCompleterHandleable](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable__ctor.htm) | Initializes a new instance of the ConsoleCommandAutoCompleterHandleable class |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Options](P_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_Options.htm) | (Inherited from [ConsoleCommandParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter.htm).) |
| Public property | [Type](P_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_Type.htm) | (Inherited from [ConsoleCommandParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter.htm).) |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Protected method | [CheckHandleable](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable_CheckHandleable.htm) |  |
| Public method | [GetApplicableOption](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_GetApplicableOption.htm) | (Inherited from [ConsoleCommandParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter.htm).) |
| Public method | [GetApplicableOptions](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_GetApplicableOptions.htm) | (Inherited from [ConsoleCommandParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter.htm).) |
| Protected method | [GetDecription](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable_GetDecription.htm) |  |
| Protected method | [GetHandleables](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable_GetHandleables.htm) |  |
| Protected method | [OrderOptions](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable_OrderOptions.htm) |  |
| Public method | [UpdateOptions](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable_UpdateOptions.htm) | (Overrides [ConsoleCommandParameterAutoCompleterUpdateOptions](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_UpdateOptions.htm).) |

[Top](#mainBody)

See Also

#### Reference

[Rage.ConsoleCommands.AutoCompleters Namespace](N_Rage_ConsoleCommands_AutoCompleters.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.