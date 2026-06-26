# GraphicsEventArgs Class

﻿GraphicsEventArgs Class

|  |  |  |
| --- | --- | --- |
| GraphicsEventArgs Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Provides data for the [FrameRender](E_Rage_Game_FrameRender.htm) event.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemEventArgs](http://msdn2.microsoft.com/en-us/library/118wxtk3)  
    RageGraphicsEventArgs  
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
public sealed class GraphicsEventArgs : EventArgs
```

```
<SerializableAttribute>
Public NotInheritable Class GraphicsEventArgs
	Inherits EventArgs
```

```
[SerializableAttribute]
public ref class GraphicsEventArgs sealed : public EventArgs
```

The GraphicsEventArgs type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [GraphicsEventArgs](M_Rage_GraphicsEventArgs__ctor.htm) | Initializes a new instance of the GraphicsEventArgs class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Graphics](P_Rage_GraphicsEventArgs_Graphics.htm) | Gets the [Graphics](P_Rage_GraphicsEventArgs_Graphics.htm) object used for drawing on the screen. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.