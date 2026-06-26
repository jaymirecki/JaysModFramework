# ConsoleCommandArgumentParser Class

﻿ConsoleCommandArgumentParser Class

|  |  |  |
| --- | --- | --- |
| ConsoleCommandArgumentParser Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Handles parsing the arguments for console commands.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  Rage.ConsoleCommands.ArgumentParsersConsoleCommandArgumentParser  
    [Rage.ConsoleCommands.ArgumentParsersConsoleCommandArgumentParserFractional](T_Rage_ConsoleCommands_ArgumentParsers_ConsoleCommandArgumentParserFractional.htm)  
    [Rage.ConsoleCommands.ArgumentParsersConsoleCommandArgumentParserInteger](T_Rage_ConsoleCommands_ArgumentParsers_ConsoleCommandArgumentParserInteger.htm)  
    [Rage.ConsoleCommands.ArgumentParsersConsoleCommandArgumentParserPed](T_Rage_ConsoleCommands_ArgumentParsers_ConsoleCommandArgumentParserPed.htm)  
    [Rage.ConsoleCommands.ArgumentParsersConsoleCommandArgumentParserVehicle](T_Rage_ConsoleCommands_ArgumentParsers_ConsoleCommandArgumentParserVehicle.htm)  
**Namespace:**
 [Rage.ConsoleCommands.ArgumentParsers](N_Rage_ConsoleCommands_ArgumentParsers.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
public abstract class ConsoleCommandArgumentParser
```

```
Public MustInherit Class ConsoleCommandArgumentParser
```

```
public ref class ConsoleCommandArgumentParser abstract
```

The ConsoleCommandArgumentParser type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleCommandArgumentParser](M_Rage_ConsoleCommands_ArgumentParsers_ConsoleCommandArgumentParser__ctor.htm) | Initializes a new instance of the ConsoleCommandArgumentParser class |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Parse](M_Rage_ConsoleCommands_ArgumentParsers_ConsoleCommandArgumentParser_Parse.htm) | When overriden in a derived class, parses the specified argument. |

[Top](#mainBody)

See Also

#### Reference

[Rage.ConsoleCommands.ArgumentParsers Namespace](N_Rage_ConsoleCommands_ArgumentParsers.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.