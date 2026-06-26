# NativeArgument Class

﻿NativeArgument Class

|  |  |  |
| --- | --- | --- |
| NativeArgument Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents an argument for a call to a native.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  Rage.NativeNativeArgument  
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
public sealed class NativeArgument : IDisposable
```

```
<SerializableAttribute>
Public NotInheritable Class NativeArgument
	Implements IDisposable
```

```
[SerializableAttribute]
public ref class NativeArgument sealed : IDisposable
```

The NativeArgument type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [NativeArgument(Boolean)](M_Rage_Native_NativeArgument__ctor_6.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Boolean\*)](M_Rage_Native_NativeArgument__ctor_7.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Byte)](M_Rage_Native_NativeArgument__ctor_8.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Int32)](M_Rage_Native_NativeArgument__ctor_9.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Int32\*)](M_Rage_Native_NativeArgument__ctor_10.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Int64)](M_Rage_Native_NativeArgument__ctor_11.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Int64\*)](M_Rage_Native_NativeArgument__ctor_12.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(IntPtr)](M_Rage_Native_NativeArgument__ctor_13.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(SByte\*)](M_Rage_Native_NativeArgument__ctor_14.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Single)](M_Rage_Native_NativeArgument__ctor_15.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Single\*)](M_Rage_Native_NativeArgument__ctor_16.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(UInt32)](M_Rage_Native_NativeArgument__ctor_17.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(UInt32\*)](M_Rage_Native_NativeArgument__ctor_18.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(UInt64)](M_Rage_Native_NativeArgument__ctor_19.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(UInt64\*)](M_Rage_Native_NativeArgument__ctor_20.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Void\*)](M_Rage_Native_NativeArgument__ctor_21.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(IHandleable)](M_Rage_Native_NativeArgument__ctor.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Model)](M_Rage_Native_NativeArgument__ctor_1.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(NativePointer)](M_Rage_Native_NativeArgument__ctor_2.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(NativeString)](M_Rage_Native_NativeArgument__ctor_3.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Player)](M_Rage_Native_NativeArgument__ctor_4.htm) | Initializes a new instance of the NativeArgument class |
| Public method | [NativeArgument(Vector3\*)](M_Rage_Native_NativeArgument__ctor_5.htm) | Initializes a new instance of the NativeArgument class |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [IsPointer](P_Rage_Native_NativeArgument_IsPointer.htm) |  |
| Public property | [IsString](P_Rage_Native_NativeArgument_IsString.htm) |  |
| Public property | [ParameterType](P_Rage_Native_NativeArgument_ParameterType.htm) |  |
| Public property | [Value](P_Rage_Native_NativeArgument_Value.htm) |  |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [CleanUp](M_Rage_Native_NativeArgument_CleanUp.htm) |  |
| Public method | [Dispose](M_Rage_Native_NativeArgument_Dispose.htm) | Releases all resources used by the NativeArgument |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [(Boolean to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_6.htm) |  |
| Public operatorStatic member | [(Boolean\* to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_7.htm) |  |
| Public operatorStatic member | [(Byte to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_8.htm) |  |
| Public operatorStatic member | [(Int32 to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_9.htm) |  |
| Public operatorStatic member | [(Int32\* to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_10.htm) |  |
| Public operatorStatic member | [(Int64 to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_11.htm) |  |
| Public operatorStatic member | [(Int64\* to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_12.htm) |  |
| Public operatorStatic member | [(IntPtr to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_13.htm) |  |
| Public operatorStatic member | [(SByte\* to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_14.htm) |  |
| Public operatorStatic member | [(Single to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_15.htm) |  |
| Public operatorStatic member | [(Single\* to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_16.htm) |  |
| Public operatorStatic member | [(String to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_17.htm) |  |
| Public operatorStatic member | [(UInt32 to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_18.htm) |  |
| Public operatorStatic member | [(UInt32\* to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_19.htm) |  |
| Public operatorStatic member | [(UInt64 to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_20.htm) |  |
| Public operatorStatic member | [(UInt64\* to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_21.htm) |  |
| Public operatorStatic member | [(Void\* to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_22.htm) |  |
| Public operatorStatic member | [(IHandleable to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit.htm) |  |
| Public operatorStatic member | [(Model to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_1.htm) |  |
| Public operatorStatic member | [(NativePointer to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_2.htm) |  |
| Public operatorStatic member | [(NativeString to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_3.htm) |  |
| Public operatorStatic member | [(Player to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_4.htm) |  |
| Public operatorStatic member | [(Vector3\* to NativeArgument)](M_Rage_Native_NativeArgument_op_Implicit_5.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage.Native Namespace](N_Rage_Native.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.