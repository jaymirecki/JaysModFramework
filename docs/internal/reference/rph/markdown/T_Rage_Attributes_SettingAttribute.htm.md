# SettingAttribute Class

﻿SettingAttribute Class

|  |  |  |
| --- | --- | --- |
| SettingAttribute Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Provides information about a setting for the RAGE Plugin Hook.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemAttribute](http://msdn2.microsoft.com/en-us/library/e8kc3626)  
    Rage.AttributesSettingAttribute  
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
[AttributeUsageAttribute(AttributeTargets.All, Inherited = false)]
public class SettingAttribute : Attribute
```

```
<SerializableAttribute>
<AttributeUsageAttribute(AttributeTargets.All, Inherited := false)>
Public Class SettingAttribute
	Inherits Attribute
```

```
[SerializableAttribute]
[AttributeUsageAttribute(AttributeTargets::All, Inherited = false)]
public ref class SettingAttribute : public Attribute
```

The SettingAttribute type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [SettingAttribute](M_Rage_Attributes_SettingAttribute__ctor.htm) | Initializes a new instance of the SettingAttribute class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [DefaultValue](P_Rage_Attributes_SettingAttribute_DefaultValue.htm) | Gets the default value of the setting. |
| Public property | [Name](P_Rage_Attributes_SettingAttribute_Name.htm) | Gets the name of the setting. |
| Public property | [Type](P_Rage_Attributes_SettingAttribute_Type.htm) | Gets the type of the setting. |

[Top](#mainBody)

See Also

#### Reference

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.