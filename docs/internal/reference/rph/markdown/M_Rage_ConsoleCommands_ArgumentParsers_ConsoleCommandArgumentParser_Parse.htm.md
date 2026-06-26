# ConsoleCommandArgumentParser.Parse Method

﻿ConsoleCommandArgumentParser.Parse Method 

|  |  |  |
| --- | --- | --- |
| ConsoleCommandArgumentParserParse Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

When overriden in a derived class, parses the specified argument.

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
public abstract Object Parse(
	string argument
)
```

```
Public MustOverride Function Parse ( 
	argument As String
) As Object
```

```
public:
virtual Object^ Parse(
	String^ argument
) abstract
```

#### Parameters

argument
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The argument to parse.

#### Return Value

Type: [Object](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
If successful, returns the resulting [Object](http://msdn2.microsoft.com/en-us/library/e5kfa45b); otherwise, returns null.

See Also

#### Reference

[ConsoleCommandArgumentParser Class](T_Rage_ConsoleCommands_ArgumentParsers_ConsoleCommandArgumentParser.htm)

[Rage.ConsoleCommands.ArgumentParsers Namespace](N_Rage_ConsoleCommands_ArgumentParsers.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.