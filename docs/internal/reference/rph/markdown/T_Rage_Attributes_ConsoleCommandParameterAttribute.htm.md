# ConsoleCommandParameterAttribute Class

﻿ConsoleCommandParameterAttribute Class

|  |  |  |
| --- | --- | --- |
| ConsoleCommandParameterAttribute Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Attribute to describe parameters of console commands.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemAttribute](http://msdn2.microsoft.com/en-us/library/e8kc3626)  
    Rage.AttributesConsoleCommandParameterAttribute  
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
[AttributeUsageAttribute(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
public class ConsoleCommandParameterAttribute : Attribute
```

```
<SerializableAttribute>
<AttributeUsageAttribute(AttributeTargets.Parameter, Inherited := false, AllowMultiple := false)>
Public Class ConsoleCommandParameterAttribute
	Inherits Attribute
```

```
[SerializableAttribute]
[AttributeUsageAttribute(AttributeTargets::Parameter, Inherited = false, AllowMultiple = false)]
public ref class ConsoleCommandParameterAttribute : public Attribute
```

The ConsoleCommandParameterAttribute type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleCommandParameterAttribute](M_Rage_Attributes_ConsoleCommandParameterAttribute__ctor.htm) | Initializes a new instance of the [ConsoleCommandAttribute](T_Rage_Attributes_ConsoleCommandAttribute.htm) class. |
| Public method | [ConsoleCommandParameterAttribute(String)](M_Rage_Attributes_ConsoleCommandParameterAttribute__ctor_1.htm) | Initializes a new instance of the [ConsoleCommandAttribute](T_Rage_Attributes_ConsoleCommandAttribute.htm) class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AutoCompleterType](P_Rage_Attributes_ConsoleCommandParameterAttribute_AutoCompleterType.htm) | Gets or sets the type of the automatic completer. |
| Public property | [Description](P_Rage_Attributes_ConsoleCommandParameterAttribute_Description.htm) | Gets or sets the description of this parameter. |
| Public property | [Name](P_Rage_Attributes_ConsoleCommandParameterAttribute_Name.htm) | Gets or sets the name of this parameter. |
| Public property | [NoAutoCompletion](P_Rage_Attributes_ConsoleCommandParameterAttribute_NoAutoCompletion.htm) | Gets or sets whether this parameter should have no automatic completion. |

[Top](#mainBody)

See Also

#### Reference

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.