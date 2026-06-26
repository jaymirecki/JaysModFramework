# GameConsole Class

﻿GameConsole Class

|  |  |  |
| --- | --- | --- |
| GameConsole Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Provides access to the console of the hook.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemMarshalByRefObject](http://msdn2.microsoft.com/en-us/library/w4302s1f)  
    HookMarshalByRefObject  
      RageGameConsole  
**Namespace:**
 [Rage](N_Rage.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
[SerializableAttribute]
public sealed class GameConsole : HookMarshalByRefObject
```

```
<SerializableAttribute>
Public NotInheritable Class GameConsole
	Inherits HookMarshalByRefObject
```

```
[SerializableAttribute]
public ref class GameConsole sealed : public HookMarshalByRefObject
```

The GameConsole type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [IsOpen](P_Rage_GameConsole_IsOpen.htm) | Gets a value indicating whether the console is open. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Print](M_Rage_GameConsole_Print.htm) | Adds an empty entry to the console output. |
| Public method | [Print(String)](M_Rage_GameConsole_Print_1.htm) | Adds an entry with the specified text to the console output. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.