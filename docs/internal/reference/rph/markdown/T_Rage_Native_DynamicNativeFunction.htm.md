# DynamicNativeFunction Class

﻿DynamicNativeFunction Class

|  |  |  |
| --- | --- | --- |
| DynamicNativeFunction Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents a dynamic object that can be used to invoke natives.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [System.DynamicDynamicObject](http://msdn2.microsoft.com/en-us/library/dd487439)  
    Rage.NativeDynamicNativeFunction  
**Namespace:**
 [Rage.Native](N_Rage_Native.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
public sealed class DynamicNativeFunction : DynamicObject
```

```
Public NotInheritable Class DynamicNativeFunction
	Inherits DynamicObject
```

```
public ref class DynamicNativeFunction sealed : public DynamicObject
```

The DynamicNativeFunction type exposes the following members.

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [TryInvokeMember](M_Rage_Native_DynamicNativeFunction_TryInvokeMember.htm) | (Overrides [DynamicObjectTryInvokeMember(InvokeMemberBinder, Object, Object)](http://msdn2.microsoft.com/en-us/library/dd487395).) |

[Top](#mainBody)

Examples

Calls made on the dynamic object will be resolved at runtime rather than compile time, so calling any non-existing method on this object will work at compile time, but may fail at runtime.
When the code runs, the name of the method will be resolved to a native name.
Names can be formatted in two ways. The native's actual name, or its name without underscores, in PascalCase. For example, the two following code snippets will invoke the native STOP\_PLAYER\_TELEPORT.

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
Rage.Native.NativeFunction.Natives.STOP_PLAYER_TELEPORT();
```

```
Rage.Native.NativeFunction.Natives.STOP_PLAYER_TELEPORT()
```

No code example is currently available or this language may not be supported.

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
Rage.Native.NativeFunction.Natives.StopPlayerTeleport();
```

```
Rage.Native.NativeFunction.Natives.StopPlayerTeleport()
```

No code example is currently available or this language may not be supported.

Arguments can be passed to natives using traditional method call syntax.
Certain types like [IHandleable](T_Rage_IHandleable.htm)s or [Player](T_Rage_Player.htm), will be converted to their handle, so it's unnecessary to call [Handle](P_Rage_IHandleable_Handle.htm) on an object:

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
Rage.Native.NativeFunction.Natives.SET_PLAYER_MODEL(Rage.Game.LocalPlayer, Rage.Game.GetHashKey("PLAYER_ZERO"));
```

```
Rage.Native.NativeFunction.Natives.SET_PLAYER_MODEL(Rage.Game.LocalPlayer, Rage.Game.GetHashKey("PLAYER_ZERO"))
```

No code example is currently available or this language may not be supported.

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
Rage.Native.NativeFunction.Natives.SetPlayerModel(Rage.Game.LocalPlayer, Rage.Game.GetHashKey("PLAYER_ZERO"));
```

```
Rage.Native.NativeFunction.Natives.SetPlayerModel(Rage.Game.LocalPlayer, Rage.Game.GetHashKey("PLAYER_ZERO"))
```

No code example is currently available or this language may not be supported.

Natives can also be called using their original 64-bit value (a.k.a. hash). To call a native by its hash, begin the method name with x followed by the 64-bit value:

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
Rage.Native.NativeFunction.Natives.x00A1CADD00108836(Rage.Game.LocalPlayer, Rage.Game.GetHashKey("PLAYER_ZERO"));
```

```
Rage.Native.NativeFunction.Natives.x00A1CADD00108836(Rage.Game.LocalPlayer, Rage.Game.GetHashKey("PLAYER_ZERO"))
```

No code example is currently available or this language may not be supported.

If a native returns a value, the return type must be indicated as the first and only generic type argument.

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
uint vehicleHandle = Rage.Native.NativeFunction.Natives.GetVehiclePedIsTryingToEnter<uint>(Rage.Game.LocalPlayer.Character);
```

```
Dim vehicleHandle As UInteger = Rage.Native.NativeFunction.Natives.GetVehiclePedIsTryingToEnter(Of UInteger)(Rage.Game.LocalPlayer.Character)
```

No code example is currently available or this language may not be supported.

If the native returns a handle to one of the most common [IHandleable](T_Rage_IHandleable.htm) types ([Ped](T_Rage_Ped.htm), [Vehicle](T_Rage_Vehicle.htm), [Object](T_Rage_Object.htm), [Blip](T_Rage_Blip.htm), [Group](T_Rage_Group.htm)), the return type can be specified as one of these types, and RAGE Plugin Hook will automatically convert the handle to the specified [IHandleable](T_Rage_IHandleable.htm) type.

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
Rage.Vehicle vehicle = Rage.Native.NativeFunction.Natives.GetVehiclePedIsTryingToEnter<Rage.Vehicle>(Rage.Game.LocalPlayer.Character);
```

```
Dim vehicle As Rage.Vehicle = Rage.Native.NativeFunction.Natives.GetVehiclePedIsTryingToEnter(Of Rage.Vehicle)(Rage.Game.LocalPlayer.Character)
```

No code example is currently available or this language may not be supported.

See Also

#### Reference

[Rage.Native Namespace](N_Rage_Native.htm)

[System.DynamicDynamicObject](http://msdn2.microsoft.com/en-us/library/dd487439)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.