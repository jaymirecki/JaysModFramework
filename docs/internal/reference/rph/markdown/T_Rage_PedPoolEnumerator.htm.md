# PedPoolEnumerator Class

﻿PedPoolEnumerator Class

|  |  |  |
| --- | --- | --- |
| PedPoolEnumerator Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.PedPoolEnumerator"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [RagePoolEnumerator](T_Rage_PoolEnumerator_1.htm)[Ped](T_Rage_Ped.htm)  
    [RageSimplePoolEnumerator](T_Rage_SimplePoolEnumerator_1.htm)[Ped](T_Rage_Ped.htm)  
      RagePedPoolEnumerator  
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
public class PedPoolEnumerator : SimplePoolEnumerator<Ped>
```

```
Public Class PedPoolEnumerator
	Inherits SimplePoolEnumerator(Of Ped)
```

```
public ref class PedPoolEnumerator : public SimplePoolEnumerator<Ped^>
```

The PedPoolEnumerator type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [PedPoolEnumerator](M_Rage_PedPoolEnumerator__ctor.htm) | Initializes a new instance of the PedPoolEnumerator class |

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
| Protected method | [GetHandleableByAddress](M_Rage_PedPoolEnumerator_GetHandleableByAddress.htm) | (Overrides [PoolEnumeratorHTGetHandleableByAddress(UInt64)](M_Rage_PoolEnumerator_1_GetHandleableByAddress.htm).) |
| Protected method | [GetPoolCapacity](M_Rage_SimplePoolEnumerator_1_GetPoolCapacity.htm) | (Inherited from [SimplePoolEnumeratorHT](T_Rage_SimplePoolEnumerator_1.htm).) |
| Protected method | [HasBeenModified](M_Rage_SimplePoolEnumerator_1_HasBeenModified.htm) | (Inherited from [SimplePoolEnumeratorHT](T_Rage_SimplePoolEnumerator_1.htm).) |
| Protected method | [Initialize](M_Rage_SimplePoolEnumerator_1_Initialize.htm) | (Inherited from [SimplePoolEnumeratorHT](T_Rage_SimplePoolEnumerator_1.htm).) |
| Protected method | [IsItemValid](M_Rage_PedPoolEnumerator_IsItemValid.htm) | (Overrides [PoolEnumeratorHTIsItemValid(UInt64)](M_Rage_PoolEnumerator_1_IsItemValid.htm).) |
| Public method | [MoveNext](M_Rage_PoolEnumerator_1_MoveNext.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Public method | [Reset](M_Rage_PoolEnumerator_1_Reset.htm) | (Inherited from [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm).) |
| Protected method | [TryGetItemAtIndex](M_Rage_SimplePoolEnumerator_1_TryGetItemAtIndex.htm) | (Inherited from [SimplePoolEnumeratorHT](T_Rage_SimplePoolEnumerator_1.htm).) |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.