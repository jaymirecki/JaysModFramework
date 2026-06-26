# DynamicNativeFunction.TryInvokeMember Method

﻿DynamicNativeFunction.TryInvokeMember Method 

|  |  |  |
| --- | --- | --- |
| DynamicNativeFunctionTryInvokeMember Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "M:Rage.Native.DynamicNativeFunction.TryInvokeMember(System.Dynamic.InvokeMemberBinder,System.Object[],System.Object@)"]

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
public override sealed bool TryInvokeMember(
	InvokeMemberBinder binder,
	Object[] args,
	out Object result
)
```

```
Public Overrides NotOverridable Function TryInvokeMember ( 
	binder As InvokeMemberBinder,
	args As Object(),
	<OutAttribute> ByRef result As Object
) As Boolean
```

```
public:
virtual bool TryInvokeMember(
	InvokeMemberBinder^ binder, 
	array<Object^>^ args, 
	[OutAttribute] Object^% result
) override sealed
```

#### Parameters

binder
:   Type: [System.DynamicInvokeMemberBinder](http://msdn2.microsoft.com/en-us/library/dd487319)  

    [Missing <param name="binder"/> documentation for "M:Rage.Native.DynamicNativeFunction.TryInvokeMember(System.Dynamic.InvokeMemberBinder,System.Object[],System.Object@)"]

args
:   Type: [SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  

    [Missing <param name="args"/> documentation for "M:Rage.Native.DynamicNativeFunction.TryInvokeMember(System.Dynamic.InvokeMemberBinder,System.Object[],System.Object@)"]

result
:   Type: [SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  

    [Missing <param name="result"/> documentation for "M:Rage.Native.DynamicNativeFunction.TryInvokeMember(System.Dynamic.InvokeMemberBinder,System.Object[],System.Object@)"]

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  

[Missing <returns> documentation for "M:Rage.Native.DynamicNativeFunction.TryInvokeMember(System.Dynamic.InvokeMemberBinder,System.Object[],System.Object@)"]

See Also

#### Reference

[DynamicNativeFunction Class](T_Rage_Native_DynamicNativeFunction.htm)

[Rage.Native Namespace](N_Rage_Native.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.