# NativeFunction.CallByAddress(ReturnType) Method (IntPtr, NativeArgument[])

﻿NativeFunction.CallByAddress(ReturnType) Method (IntPtr, NativeArgument[])

|  |  |  |
| --- | --- | --- |
| NativeFunctionCallByAddressReturnType Method (IntPtr, NativeArgument) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Calls a native by its address. This method should not be called directly. Use [!:Rage::NativeFunction::Natives] instead.

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
[HandleProcessCorruptedStateExceptionsAttribute]
public static ReturnType CallByAddress<ReturnType>(
	IntPtr address,
	params NativeArgument[] arguments
)
where ReturnType : struct, new()
```

```
<HandleProcessCorruptedStateExceptionsAttribute>
Public Shared Function CallByAddress(Of ReturnType As {Structure, New}) ( 
	address As IntPtr,
	ParamArray arguments As NativeArgument()
) As ReturnType
```

```
public:
[HandleProcessCorruptedStateExceptionsAttribute]
generic<typename ReturnType>
where ReturnType : value class, gcnew()
static ReturnType CallByAddress(
	IntPtr address, 
	... array<NativeArgument^>^ arguments
)
```

#### Parameters

address
:   Type: [SystemIntPtr](http://msdn2.microsoft.com/en-us/library/5he14kz8)  
    The address of the native to call.

arguments
:   Type: [Rage.NativeNativeArgument](T_Rage_Native_NativeArgument.htm)  
    The arguments to pass to the native.

#### Type Parameters

ReturnType
:   The type of the return value. If the native doesn't return a value pass int.

#### Return Value

Type: ReturnType  
An instance of [!:ReturnType] representing the return value of the native.

Remarks

This method should not be called directly. Use [!:Rage::NativeFunction::Natives] instead.

See Also

#### Reference

[NativeFunction Class](T_Rage_Native_NativeFunction.htm)

[CallByAddress Overload](Overload_Rage_Native_NativeFunction_CallByAddress.htm)

[Rage.Native Namespace](N_Rage_Native.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.