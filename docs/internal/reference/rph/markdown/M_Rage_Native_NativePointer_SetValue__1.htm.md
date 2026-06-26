# NativePointer.SetValue(ReturnType) Method

﻿NativePointer.SetValue(ReturnType) Method 

|  |  |  |
| --- | --- | --- |
| NativePointerSetValueReturnType Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "M:Rage.Native.NativePointer.SetValue``1(``0)"]

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
public void SetValue<ReturnType>(
	ReturnType value
)
where ReturnType : struct, new()
```

```
Public Sub SetValue(Of ReturnType As {Structure, New}) ( 
	value As ReturnType
)
```

```
public:
generic<typename ReturnType>
where ReturnType : value class, gcnew()
void SetValue(
	ReturnType value
)
```

#### Parameters

value
:   Type: ReturnType  

    [Missing <param name="value"/> documentation for "M:Rage.Native.NativePointer.SetValue``1(``0)"]

#### Type Parameters

ReturnType
:   [Missing <typeparam name="ReturnType"/> documentation for "M:Rage.Native.NativePointer.SetValue``1(``0)"]

See Also

#### Reference

[NativePointer Class](T_Rage_Native_NativePointer.htm)

[Rage.Native Namespace](N_Rage_Native.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.