# NativeFunction.CallByHash Method (UInt64, Type, NativeArgument[])

﻿NativeFunction.CallByHash Method (UInt64, Type, NativeArgument[])

|  |  |  |
| --- | --- | --- |
| NativeFunctionCallByHash Method (UInt64, Type, NativeArgument) | RAGE Plugin Hook Documentation |  |

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
public static Object CallByHash(
	ulong nativeHash,
	Type returnType,
	params NativeArgument[] arguments
)
```

```
Public Shared Function CallByHash ( 
	nativeHash As ULong,
	returnType As Type,
	ParamArray arguments As NativeArgument()
) As Object
```

```
public:
static Object^ CallByHash(
	unsigned long long nativeHash, 
	Type^ returnType, 
	... array<NativeArgument^>^ arguments
)
```

#### Parameters

nativeHash
:   Type: [SystemUInt64](http://msdn2.microsoft.com/en-us/library/06cf7918)  
    The hash of the native to call.

returnType
:   Type: [SystemType](http://msdn2.microsoft.com/en-us/library/42892f65)  
    The type of the return value. If the native doesn't return a value pass int.

arguments
:   Type: [Rage.NativeNativeArgument](T_Rage_Native_NativeArgument.htm)  
    The arguments to pass to the native.

#### Return Value

Type: [Object](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
An instance of the specified return type representing the return value of the native.

Remarks

This method should not be called directly. Use [!:Rage::NativeFunction::Natives] instead.

See Also

#### Reference

[NativeFunction Class](T_Rage_Native_NativeFunction.htm)

[CallByHash Overload](Overload_Rage_Native_NativeFunction_CallByHash.htm)

[Rage.Native Namespace](N_Rage_Native.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.