# PluginAttribute Class

﻿PluginAttribute Class

|  |  |  |
| --- | --- | --- |
| PluginAttribute Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Provides details about a plugin to the RAGE Plugin Hook. This assembly attribute is required for all plugins.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemAttribute](http://msdn2.microsoft.com/en-us/library/e8kc3626)  
    Rage.AttributesPluginAttribute  
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
[AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false, AllowMultiple = true)]
public class PluginAttribute : Attribute
```

```
<SerializableAttribute>
<AttributeUsageAttribute(AttributeTargets.Assembly, Inherited := false, AllowMultiple := true)>
Public Class PluginAttribute
	Inherits Attribute
```

```
[SerializableAttribute]
[AttributeUsageAttribute(AttributeTargets::Assembly, Inherited = false, AllowMultiple = true)]
public ref class PluginAttribute : public Attribute
```

The PluginAttribute type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [PluginAttribute](M_Rage_Attributes_PluginAttribute__ctor.htm) | Initializes a new instance of the PluginAttribute class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Author](P_Rage_Attributes_PluginAttribute_Author.htm) | Gets or sets the author of the plugin. |
| Public property | [DefaultObjectType](P_Rage_Attributes_PluginAttribute_DefaultObjectType.htm) | Gets or sets the full name of the default type that will be used to represent objects. The type must inherit from [!:Rage::Object]. If null, [!:Rage::Object] will be used. |
| Public property | [DefaultPedType](P_Rage_Attributes_PluginAttribute_DefaultPedType.htm) | Gets or sets the full name of the default type that will be used to represent peds. The type must inherit from [Ped](T_Rage_Ped.htm). If null, [Ped](T_Rage_Ped.htm) will be used. |
| Public property | [DefaultVehicleType](P_Rage_Attributes_PluginAttribute_DefaultVehicleType.htm) | Gets or sets the full name of the default type that will be used to represent vehicles. The type must inherit from [Vehicle](T_Rage_Vehicle.htm). If null, [Vehicle](T_Rage_Vehicle.htm) will be used. |
| Public property | [Description](P_Rage_Attributes_PluginAttribute_Description.htm) | Gets or sets the description of the plugin. |
| Public property | [EntryPoint](P_Rage_Attributes_PluginAttribute_EntryPoint.htm) | Gets or sets the full name of the method to serve as entry point of the plugin (Eg. "EntryPoint.Main". If null, the first found method that's static, returns void and is named "Main" will be used. |
| Public property | [ExitPoint](P_Rage_Attributes_PluginAttribute_ExitPoint.htm) | Gets or sets the full name of the method to serve as exit point of the plugin (Eg. "EntryPoint.OnUnload". If null, the first found method that's static, returns void, takes a bool and is named "OnUnload" will be used. |
| Public property | [Name](P_Rage_Attributes_PluginAttribute_Name.htm) | Gets or sets the name of the plugin. |
| Public property | [PrefersSingleInstance](P_Rage_Attributes_PluginAttribute_PrefersSingleInstance.htm) | Gets or sets a value indicating whether this plugin prefers to only have one instance of itself loaded at any given time.  If true the plugin can still be loaded multiple times, but requires the force parameter of the LoadPlugin command to be set to true. |
| Public property | [ShouldTickInPauseMenu](P_Rage_Attributes_PluginAttribute_ShouldTickInPauseMenu.htm) | Gets or sets a value indicating whether this plugin should tick while the pause menu is open. |
| Public property | [SupportUrl](P_Rage_Attributes_PluginAttribute_SupportUrl.htm) | Gets or sets the support URL for this plugin. If specified, this URL will be presented to the user if the plugin crashes (Or if the game crashes while the plugin was ticking). |

[Top](#mainBody)

See Also

#### Reference

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.