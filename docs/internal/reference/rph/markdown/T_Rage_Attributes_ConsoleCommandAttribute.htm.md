# ConsoleCommandAttribute Class

﻿ConsoleCommandAttribute Class

|  |  |  |
| --- | --- | --- |
| ConsoleCommandAttribute Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.Attributes.ConsoleCommandAttribute"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemAttribute](http://msdn2.microsoft.com/en-us/library/e8kc3626)  
    Rage.AttributesConsoleCommandAttribute  
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
[AttributeUsageAttribute(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public class ConsoleCommandAttribute : Attribute
```

```
<SerializableAttribute>
<AttributeUsageAttribute(AttributeTargets.Method, Inherited := false, AllowMultiple := false)>
Public Class ConsoleCommandAttribute
	Inherits Attribute
```

```
[SerializableAttribute]
[AttributeUsageAttribute(AttributeTargets::Method, Inherited = false, AllowMultiple = false)]
public ref class ConsoleCommandAttribute : public Attribute
```

The ConsoleCommandAttribute type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleCommandAttribute](M_Rage_Attributes_ConsoleCommandAttribute__ctor.htm) | Initializes a new instance of the ConsoleCommandAttribute class. |
| Public method | [ConsoleCommandAttribute(String)](M_Rage_Attributes_ConsoleCommandAttribute__ctor_1.htm) | Initializes a new instance of the ConsoleCommandAttribute class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Description](P_Rage_Attributes_ConsoleCommandAttribute_Description.htm) | Gets or sets the description of this console command. |
| Public property | [Name](P_Rage_Attributes_ConsoleCommandAttribute_Name.htm) | Gets or sets the name of this console command. |

[Top](#mainBody)

See Also

#### Reference

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.