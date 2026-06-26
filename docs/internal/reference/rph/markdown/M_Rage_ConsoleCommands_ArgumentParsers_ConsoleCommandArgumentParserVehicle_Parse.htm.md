# ConsoleCommandArgumentParserVehicle.Parse Method

﻿ConsoleCommandArgumentParserVehicle.Parse Method 

|  |  |  |
| --- | --- | --- |
| ConsoleCommandArgumentParserVehicleParse Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Parses the specified argument as a [Vehicle](T_Rage_Vehicle.htm).

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
public override sealed Object Parse(
	string argument
)
```

```
Public Overrides NotOverridable Function Parse ( 
	argument As String
) As Object
```

```
public:
virtual Object^ Parse(
	String^ argument
) override sealed
```

#### Parameters

argument
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The argument to parse.

#### Return Value

Type: [Object](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
If successful, returns the resulting [Vehicle](T_Rage_Vehicle.htm); otherwise, returns null.

See Also

#### Reference

[ConsoleCommandArgumentParserVehicle Class](T_Rage_ConsoleCommands_ArgumentParsers_ConsoleCommandArgumentParserVehicle.htm)

[Rage.ConsoleCommands.ArgumentParsers Namespace](N_Rage_ConsoleCommands_ArgumentParsers.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.