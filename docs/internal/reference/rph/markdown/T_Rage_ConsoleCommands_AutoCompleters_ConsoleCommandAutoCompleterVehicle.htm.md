# ConsoleCommandAutoCompleterVehicle Class

﻿ConsoleCommandAutoCompleterVehicle Class

|  |  |  |
| --- | --- | --- |
| ConsoleCommandAutoCompleterVehicle Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.ConsoleCommands.AutoCompleters.ConsoleCommandAutoCompleterVehicle"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemMarshalByRefObject](http://msdn2.microsoft.com/en-us/library/w4302s1f)  
    HookMarshalByRefObject  
      [Rage.ConsoleCommands.AutoCompletersConsoleCommandParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter.htm)  
        [Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterHandleable](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable.htm)  
          Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterVehicle  
            [Rage.ConsoleCommands.AutoCompletersConsoleCommandAutoCompleterVehicleAliveOnly](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterVehicleAliveOnly.htm)  
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
public class ConsoleCommandAutoCompleterVehicle : ConsoleCommandAutoCompleterHandleable
```

```
<SerializableAttribute>
<ConsoleCommandParameterAutoCompleterAttribute(New Type() { ... })>
Public Class ConsoleCommandAutoCompleterVehicle
	Inherits ConsoleCommandAutoCompleterHandleable
```

```
[SerializableAttribute]
[ConsoleCommandParameterAutoCompleterAttribute(__gc new array<Type^>^ { ... })]
public ref class ConsoleCommandAutoCompleterVehicle : public ConsoleCommandAutoCompleterHandleable
```

The ConsoleCommandAutoCompleterVehicle type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleCommandAutoCompleterVehicle](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterVehicle__ctor.htm) | Initializes a new instance of the ConsoleCommandAutoCompleterVehicle class |

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
| Protected method | [CheckHandleable](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable_CheckHandleable.htm) | (Inherited from [ConsoleCommandAutoCompleterHandleable](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable.htm).) |
| Public method | [GetApplicableOption](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_GetApplicableOption.htm) | (Inherited from [ConsoleCommandParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter.htm).) |
| Public method | [GetApplicableOptions](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter_GetApplicableOptions.htm) | (Inherited from [ConsoleCommandParameterAutoCompleter](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandParameterAutoCompleter.htm).) |
| Protected method | [GetDecription](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable_GetDecription.htm) | (Inherited from [ConsoleCommandAutoCompleterHandleable](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable.htm).) |
| Protected method | [GetHandleables](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterVehicle_GetHandleables.htm) | (Overrides [ConsoleCommandAutoCompleterHandleableGetHandleables](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable_GetHandleables.htm).) |
| Protected method | [OrderOptions](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable_OrderOptions.htm) | (Inherited from [ConsoleCommandAutoCompleterHandleable](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable.htm).) |
| Public method | [UpdateOptions](M_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable_UpdateOptions.htm) | (Inherited from [ConsoleCommandAutoCompleterHandleable](T_Rage_ConsoleCommands_AutoCompleters_ConsoleCommandAutoCompleterHandleable.htm).) |

[Top](#mainBody)

See Also

#### Reference

[Rage.ConsoleCommands.AutoCompleters Namespace](N_Rage_ConsoleCommands_AutoCompleters.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.