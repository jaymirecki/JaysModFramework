# ConsoleCommandArgumentParserAttribute Class

﻿ConsoleCommandArgumentParserAttribute Class

|  |  |  |
| --- | --- | --- |
| ConsoleCommandArgumentParserAttribute Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Attribute to let argument parsers specify which types they support.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemAttribute](http://msdn2.microsoft.com/en-us/library/e8kc3626)  
    Rage.AttributesConsoleCommandArgumentParserAttribute  
**Namespace:**
 [Rage.Attributes](N_Rage_Attributes.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
[SerializableAttribute]
[AttributeUsageAttribute(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public class ConsoleCommandArgumentParserAttribute : Attribute
```

```
<SerializableAttribute>
<AttributeUsageAttribute(AttributeTargets.Class, Inherited := false, AllowMultiple := false)>
Public Class ConsoleCommandArgumentParserAttribute
	Inherits Attribute
```

```
[SerializableAttribute]
[AttributeUsageAttribute(AttributeTargets::Class, Inherited = false, AllowMultiple = false)]
public ref class ConsoleCommandArgumentParserAttribute : public Attribute
```

The ConsoleCommandArgumentParserAttribute type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleCommandArgumentParserAttribute](M_Rage_Attributes_ConsoleCommandArgumentParserAttribute__ctor.htm) | Initializes a new instance of the ConsoleCommandArgumentParserAttribute class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [SupportedTypes](P_Rage_Attributes_ConsoleCommandArgumentParserAttribute_SupportedTypes.htm) | Gets or sets the supported types of this parser. |

[Top](#mainBody)

See Also

#### Reference

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.