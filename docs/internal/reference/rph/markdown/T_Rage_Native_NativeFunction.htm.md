# NativeFunction Class

﻿NativeFunction Class

|  |  |  |
| --- | --- | --- |
| NativeFunction Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

A collection of methods for invoking natives.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  Rage.NativeNativeFunction  
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
[SerializableAttribute]
public static class NativeFunction
```

```
<SerializableAttribute>
Public NotInheritable Class NativeFunction
```

```
[SerializableAttribute]
public ref class NativeFunction abstract sealed
```

The NativeFunction type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public propertyStatic member | [Natives](P_Rage_Native_NativeFunction_Natives.htm) | Gets an object that can be used to invoke natives. See [DynamicNativeFunction](T_Rage_Native_DynamicNativeFunction.htm) for more information. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [Call](M_Rage_Native_NativeFunction_Call.htm) |  |
| Public methodStatic member | [CallByAddress(IntPtr, Type, NativeArgument)](M_Rage_Native_NativeFunction_CallByAddress.htm) | Calls a native by its address. This method should not be called directly. Use [!:Rage::NativeFunction::Natives] instead. |
| Public methodStatic member | [CallByAddressReturnType(IntPtr, NativeArgument)](M_Rage_Native_NativeFunction_CallByAddress__1.htm) | Calls a native by its address. This method should not be called directly. Use [!:Rage::NativeFunction::Natives] instead. |
| Public methodStatic member | [CallByHash(UInt64, Type, NativeArgument)](M_Rage_Native_NativeFunction_CallByHash.htm) | Calls a native by its hash. This method should not be called directly. Use [!:Rage::NativeFunction::Natives] instead. |
| Public methodStatic member | [CallByHashReturnType(UInt64, NativeArgument)](M_Rage_Native_NativeFunction_CallByHash__1.htm) | Calls a native by its hash. This method should not be called directly. Use [!:Rage::NativeFunction::Natives] instead. |
| Public methodStatic member | [CallByName(String, Type, NativeArgument)](M_Rage_Native_NativeFunction_CallByName.htm) | Calls a native by its name. This method should not be called directly. Use [!:Rage::NativeFunction::Natives] instead. |
| Public methodStatic member | [CallByNameReturnType(String, NativeArgument)](M_Rage_Native_NativeFunction_CallByName__1.htm) | Calls a native by its name. This method should not be called directly. Use [!:Rage::NativeFunction::Natives] instead. |

[Top](#mainBody)

See Also

#### Reference

[Rage.Native Namespace](N_Rage_Native.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.