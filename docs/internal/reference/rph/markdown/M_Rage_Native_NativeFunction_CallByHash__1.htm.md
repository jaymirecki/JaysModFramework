# NativeFunction.CallByHash(ReturnType) Method (UInt64, NativeArgument[])

﻿NativeFunction.CallByHash(ReturnType) Method (UInt64, NativeArgument[])

|  |  |  |
| --- | --- | --- |
| NativeFunctionCallByHashReturnType Method (UInt64, NativeArgument) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Calls a native by its hash. This method should not be called directly. Use [!:Rage::NativeFunction::Natives] instead.

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
public static ReturnType CallByHash<ReturnType>(
	ulong nativeHash,
	params NativeArgument[] arguments
)
where ReturnType : struct, new()
```

```
Public Shared Function CallByHash(Of ReturnType As {Structure, New}) ( 
	nativeHash As ULong,
	ParamArray arguments As NativeArgument()
) As ReturnType
```

```
public:
generic<typename ReturnType>
where ReturnType : value class, gcnew()
static ReturnType CallByHash(
	unsigned long long nativeHash, 
	... array<NativeArgument^>^ arguments
)
```

#### Parameters

nativeHash
:   Type: [SystemUInt64](http://msdn2.microsoft.com/en-us/library/06cf7918)  
    The hash of the native to call.

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

[CallByHash Overload](Overload_Rage_Native_NativeFunction_CallByHash.htm)

[Rage.Native Namespace](N_Rage_Native.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.