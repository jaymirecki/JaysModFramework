# SimplePoolEnumerator(HT) Class

﻿SimplePoolEnumerator(HT) Class

|  |  |  |
| --- | --- | --- |
| SimplePoolEnumeratorHT Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.SimplePoolEnumerator`1"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [RagePoolEnumerator](T_Rage_PoolEnumerator_1.htm)HT  
    RageSimplePoolEnumeratorHT  
      [RageObjectPoolEnumerator](T_Rage_ObjectPoolEnumerator.htm)  
      [RagePedPoolEnumerator](T_Rage_PedPoolEnumerator.htm)  
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
public abstract class SimplePoolEnumerator<HT> : PoolEnumerator<HT>
where HT : IHandleable
```

```
Public MustInherit Class SimplePoolEnumerator(Of HT As IHandleable)
	Inherits PoolEnumerator(Of HT)
```

```
generic<typename HT>
where HT : IHandleable
public ref class SimplePoolEnumerator abstract : public PoolEnumerator<HT>
```

#### Type Parameters

HT
:   [Missing <typeparam name="HT"/> documentation for "T:Rage.SimplePoolEnumerator`1"]

The SimplePoolEnumeratorHT type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [SimplePoolEnumeratorHT](M_Rage_SimplePoolEnumerator_1__ctor.htm) | Initializes a new instance of the SimplePoolEnumeratorHT class |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Current](P_Rage_PoolEnumerator_1_Current.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Public property | [Current2](P_Rage_PoolEnumerator_1_Current2.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Protected property | [Pool](P_Rage_PoolEnumerator_1_Pool.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Dispose](M_Rage_PoolEnumerator_1_Dispose.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Protected method | [Dispose(Boolean)](M_Rage_PoolEnumerator_1_Dispose_1.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Public method | [GetEnumerator](M_Rage_PoolEnumerator_1_GetEnumerator.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Public method | [GetEnumerator2](M_Rage_PoolEnumerator_1_GetEnumerator2.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Protected method | [GetHandleableByAddress](M_Rage_PoolEnumerator_1_GetHandleableByAddress.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Protected method | [GetPoolCapacity](M_Rage_SimplePoolEnumerator_1_GetPoolCapacity.htm) | (Overrides [PoolEnumeratorHTGetPoolCapacity](M_Rage_PoolEnumerator_1_GetPoolCapacity.htm).) |
| Protected method | [HasBeenModified](M_Rage_SimplePoolEnumerator_1_HasBeenModified.htm) | (Overrides [PoolEnumeratorHTHasBeenModified](M_Rage_PoolEnumerator_1_HasBeenModified.htm).) |
| Protected method | [Initialize](M_Rage_SimplePoolEnumerator_1_Initialize.htm) | (Overrides [PoolEnumeratorHTInitialize](M_Rage_PoolEnumerator_1_Initialize.htm).) |
| Protected method | [IsItemValid](M_Rage_PoolEnumerator_1_IsItemValid.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Public method | [MoveNext](M_Rage_PoolEnumerator_1_MoveNext.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Public method | [Reset](M_Rage_PoolEnumerator_1_Reset.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Protected method | [TryGetItemAtIndex](M_Rage_SimplePoolEnumerator_1_TryGetItemAtIndex.htm) | (Overrides [PoolEnumeratorHTTryGetItemAtIndex(Int32)](M_Rage_PoolEnumerator_1_TryGetItemAtIndex.htm).) |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.