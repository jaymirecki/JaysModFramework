# ConsoleCommandAutoCompleterVehicleAliveOnly Class

﻿ConsoleCommandAutoCompleterVehicleAliveOnly Class

|  |  |  |
| --- | --- | --- |
| ConsoleCommandAutoCompleterVehicleAliveOnly Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.ConsoleCommands.AutoCompleters.ConsoleCommandAutoCompleterVehicleAliveOnly"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemMarshalByRefObject](http://msdn2.microsoft.com/en-us/library/w4302s1f)  
    HookMarshalByRefObject  
      [Rage.ConsoleCommands.AutoCompletersConsoleCommandParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter.htm)  
        [Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterHandleable](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable.htm)  
          [Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterVehicle](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterVehicle.htm)  
            Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterVehicleAliveOnly  
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
[ConsoleCommandParameterAutoCompleterAttribute(new Type[] { ... })]
public sealed class ConsoleCommandAutoCompleterVehicleAliveOnly : ConsoleCommandAutoCompleterVehicle
```

```
<SerializableAttribute>
<ConsoleCommandParameterAutoCompleterAttribute(New Type() { ... })>
Public NotInheritable Class ConsoleCommandAutoCompleterVehicleAliveOnly
	Inherits ConsoleCommandAutoCompleterVehicle
```

```
[SerializableAttribute]
[ConsoleCommandParameterAutoCompleterAttribute(__gc new array<Type^>^ { ... })]
public ref class ConsoleCommandAutoCompleterVehicleAliveOnly sealed : public ConsoleCommandAutoCompleterVehicle
```

The ConsoleCommandAutoCompleterVehicleAliveOnly type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleCommandAutoCompleterVehicleAliveOnly](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterVehicleAliveOnly__ctor.htm) | Initializes a new instance of the ConsoleCommandAutoCompleterVehicleAliveOnly class |

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
| Public method | [GetApplicableOption](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_GetApplicableOption.htm) | (Inherited from [ConsoleCommandParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter.htm).) |
| Public method | [GetApplicableOptions](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_GetApplicableOptions.htm) | (Inherited from [ConsoleCommandParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter.htm).) |
| Public method | [UpdateOptions](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable_UpdateOptions.htm) | (Inherited from [ConsoleCommandAutoCompleterHandleable](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable.htm).) |

[Top](#mainBody)

See Also

#### Reference

[Rage.ConsoleCommands.AutoCompleters Namespace](N_Rage_ConsoleCommands_AutoCompleters.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.