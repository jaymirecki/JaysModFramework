# PoolEnumerator(HT) Class

﻿PoolEnumerator(HT) Class

|  |  |  |
| --- | --- | --- |
| PoolEnumeratorHT Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.PoolEnumerator`1"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RagePoolEnumeratorHT  
    [RageAdvancedPoolEnumeratorHT](T_Rage_AdvancedPoolEnumerator_1.htm)  
    [RageSimplePoolEnumeratorHT](T_Rage_SimplePoolEnumerator_1.htm)  
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
public abstract class PoolEnumerator<HT> : IEnumerable<HT>, 
	IEnumerator<HT>
where HT : IHandleable
```

```
Public MustInherit Class PoolEnumerator(Of HT As IHandleable)
	Implements IEnumerable(Of HT), IEnumerator(Of HT)
```

```
generic<typename HT>
where HT : IHandleable
public ref class PoolEnumerator abstract : IEnumerable<HT>, 
	IEnumerator<HT>
```

#### Type Parameters

HT
:   [Missing <typeparam name="HT"/> documentation for "T:Rage.PoolEnumerator`1"]

The PoolEnumeratorHT type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Current](P_Rage_PoolEnumerator_1_Current.htm) |  |
| Public property | [Current2](P_Rage_PoolEnumerator_1_Current2.htm) |  |
| Protected property | [Pool](P_Rage_PoolEnumerator_1_Pool.htm) |  |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Dispose](M_Rage_PoolEnumerator_1_Dispose.htm) | Releases all resources used by the PoolEnumeratorHT |
| Protected method | [Dispose(Boolean)](M_Rage_PoolEnumerator_1_Dispose_1.htm) | Releases the unmanaged resources used by the PoolEnumeratorHT and optionally releases the managed resources |
| Public method | [GetEnumerator](M_Rage_PoolEnumerator_1_GetEnumerator.htm) |  |
| Public method | [GetEnumerator2](M_Rage_PoolEnumerator_1_GetEnumerator2.htm) |  |
| Protected method | [GetHandleableByAddress](M_Rage_PoolEnumerator_1_GetHandleableByAddress.htm) |  |
| Protected method | [GetPoolCapacity](M_Rage_PoolEnumerator_1_GetPoolCapacity.htm) |  |
| Protected method | [HasBeenModified](M_Rage_PoolEnumerator_1_HasBeenModified.htm) |  |
| Protected method | [Initialize](M_Rage_PoolEnumerator_1_Initialize.htm) |  |
| Protected method | [IsItemValid](M_Rage_PoolEnumerator_1_IsItemValid.htm) |  |
| Public method | [MoveNext](M_Rage_PoolEnumerator_1_MoveNext.htm) |  |
| Public method | [Reset](M_Rage_PoolEnumerator_1_Reset.htm) |  |
| Protected method | [TryGetItemAtIndex](M_Rage_PoolEnumerator_1_TryGetItemAtIndex.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.