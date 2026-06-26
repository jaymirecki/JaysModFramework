# ConsoleCommandParameter Class

﻿ConsoleCommandParameter Class

|  |  |  |
| --- | --- | --- |
| ConsoleCommandParameter Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.ConsoleCommands.ConsoleCommandParameter"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemMarshalByRefObject](http://msdn2.microsoft.com/en-us/library/w4302s1f)  
    HookMarshalByRefObject  
      Rage.ConsoleCommandsConsoleCommandParameter  
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
public sealed class ConsoleCommandParameter : HookMarshalByRefObject
```

```
<SerializableAttribute>
Public NotInheritable Class ConsoleCommandParameter
	Inherits HookMarshalByRefObject
```

```
[SerializableAttribute]
public ref class ConsoleCommandParameter sealed : public HookMarshalByRefObject
```

The ConsoleCommandParameter type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleCommandParameter(String, String, ConsoleCommandParameterType)](M_Rage_ConsoleCommands_ConsoleCommandParameter__ctor.htm) | Initializes a new instance of the ConsoleCommandParameter class |
| Public method | [ConsoleCommandParameter(String, String, Type)](M_Rage_ConsoleCommands_ConsoleCommandParameter__ctor_1.htm) | Initializes a new instance of the ConsoleCommandParameter class |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AutoCompleter](P_Rage_ConsoleCommands_ConsoleCommandParameter_AutoCompleter.htm) |  |
| Public property | [CustomType](P_Rage_ConsoleCommands_ConsoleCommandParameter_CustomType.htm) |  |
| Public property | [CustomTypeNameOrKeyword](P_Rage_ConsoleCommands_ConsoleCommandParameter_CustomTypeNameOrKeyword.htm) |  |
| Public property | [DefaultValue](P_Rage_ConsoleCommands_ConsoleCommandParameter_DefaultValue.htm) |  |
| Public property | [Description](P_Rage_ConsoleCommands_ConsoleCommandParameter_Description.htm) |  |
| Public property | [Name](P_Rage_ConsoleCommands_ConsoleCommandParameter_Name.htm) |  |
| Public property | [Type](P_Rage_ConsoleCommands_ConsoleCommandParameter_Type.htm) |  |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [GetArgumentParser](M_Rage_ConsoleCommands_ConsoleCommandParameter_GetArgumentParser.htm) |  |
| Public method | [ParseArgument](M_Rage_ConsoleCommands_ConsoleCommandParameter_ParseArgument.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage.ConsoleCommands Namespace](N_Rage_ConsoleCommands.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.