# ConsoleVariableAttribute Class

﻿ConsoleVariableAttribute Class

|  |  |  |
| --- | --- | --- |
| ConsoleVariableAttribute Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.Attributes.ConsoleVariableAttribute"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemAttribute](http://msdn2.microsoft.com/en-us/library/e8kc3626)  
    Rage.AttributesConsoleVariableAttribute  
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
[AttributeUsageAttribute(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public class ConsoleVariableAttribute : Attribute
```

```
<SerializableAttribute>
<AttributeUsageAttribute(AttributeTargets.Property, Inherited := false, AllowMultiple := false)>
Public Class ConsoleVariableAttribute
	Inherits Attribute
```

```
[SerializableAttribute]
[AttributeUsageAttribute(AttributeTargets::Property, Inherited = false, AllowMultiple = false)]
public ref class ConsoleVariableAttribute : public Attribute
```

The ConsoleVariableAttribute type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [ConsoleVariableAttribute](M_Rage_Attributes_ConsoleVariableAttribute__ctor.htm) | Initializes a new instance of the ConsoleVariableAttribute class. |
| Public method | [ConsoleVariableAttribute(String)](M_Rage_Attributes_ConsoleVariableAttribute__ctor_1.htm) | Initializes a new instance of the ConsoleVariableAttribute class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Description](P_Rage_Attributes_ConsoleVariableAttribute_Description.htm) | Gets or sets the description of this console variable. |
| Public property | [Hidden](P_Rage_Attributes_ConsoleVariableAttribute_Hidden.htm) | Gets or sets whether this variable should be excluded from auto-completion. |
| Public property | [InitializedDelayed](P_Rage_Attributes_ConsoleVariableAttribute_InitializedDelayed.htm) | Gets or sets a value indicating whether this variable should be initialized delayed (i.e. when the script thread first ticks) or not. |
| Public property | [Name](P_Rage_Attributes_ConsoleVariableAttribute_Name.htm) | Gets or sets the name of this console variable. |
| Public property | [Transient](P_Rage_Attributes_ConsoleVariableAttribute_Transient.htm) | Gets or sets whether this variable should be excluded from being saved to the .ini file. |

[Top](#mainBody)

See Also

#### Reference

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.