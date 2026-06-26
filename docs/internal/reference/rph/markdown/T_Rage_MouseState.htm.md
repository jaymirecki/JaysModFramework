# MouseState Class

﻿MouseState Class

|  |  |  |
| --- | --- | --- |
| MouseState Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.MouseState"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [RageKeyboardState](T_Rage_KeyboardState.htm)  
    RageMouseState  
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
public sealed class MouseState : KeyboardState
```

```
<SerializableAttribute>
Public NotInheritable Class MouseState
	Inherits KeyboardState
```

```
[SerializableAttribute]
public ref class MouseState sealed : public KeyboardState
```

The MouseState type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [MouseState](M_Rage_MouseState__ctor.htm) | Initializes a new instance of the MouseState class |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AllKeys](P_Rage_KeyboardState_AllKeys.htm) | Gets all keys. (Inherited from [KeyboardState](T_Rage_KeyboardState.htm).) |
| Public property | [IsAltDown](P_Rage_KeyboardState_IsAltDown.htm) | Gets a value indicating whether either alt key is down. (Inherited from [KeyboardState](T_Rage_KeyboardState.htm).) |
| Public property | [IsControlDown](P_Rage_KeyboardState_IsControlDown.htm) | Gets a value indicating whether either control key is down. (Inherited from [KeyboardState](T_Rage_KeyboardState.htm).) |
| Public property | [IsLeftButtonDown](P_Rage_MouseState_IsLeftButtonDown.htm) |  |
| Public property | [IsLeftButtonUp](P_Rage_MouseState_IsLeftButtonUp.htm) |  |
| Public property | [IsMiddleButtonDown](P_Rage_MouseState_IsMiddleButtonDown.htm) |  |
| Public property | [IsMiddleButtonUp](P_Rage_MouseState_IsMiddleButtonUp.htm) |  |
| Public property | [IsRightButtonDown](P_Rage_MouseState_IsRightButtonDown.htm) |  |
| Public property | [IsRightButtonUp](P_Rage_MouseState_IsRightButtonUp.htm) |  |
| Public property | [IsShiftDown](P_Rage_KeyboardState_IsShiftDown.htm) | Gets a value indicating whether either shift key is down. (Inherited from [KeyboardState](T_Rage_KeyboardState.htm).) |
| Public property | [MouseWheelDelta](P_Rage_MouseState_MouseWheelDelta.htm) |  |
| Public property | [PressedKeys](P_Rage_KeyboardState_PressedKeys.htm) | Gets pressed keys. (Inherited from [KeyboardState](T_Rage_KeyboardState.htm).) |
| Public property | [ReleasedKeys](P_Rage_KeyboardState_ReleasedKeys.htm) | Gets released keys. (Inherited from [KeyboardState](T_Rage_KeyboardState.htm).) |
| Public property | [X](P_Rage_MouseState_X.htm) |  |
| Public property | [Y](P_Rage_MouseState_Y.htm) |  |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [IsDown](M_Rage_KeyboardState_IsDown.htm) | Determines whether the specified key is down. (Inherited from [KeyboardState](T_Rage_KeyboardState.htm).) |
| Public method | [IsUp](M_Rage_KeyboardState_IsUp.htm) | Determines whether the specified key is up. (Inherited from [KeyboardState](T_Rage_KeyboardState.htm).) |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.