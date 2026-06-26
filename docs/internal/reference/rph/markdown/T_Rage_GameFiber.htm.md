# GameFiber Class

﻿GameFiber Class

|  |  |  |
| --- | --- | --- |
| GameFiber Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Represents a multi-tasking fiber. Natives can only be invoked from a fiber. Not meant to be inherited.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageGameFiber  
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
[SerializableAttribute]
public class GameFiber
```

```
<SerializableAttribute>
Public Class GameFiber
```

```
[SerializableAttribute]
public ref class GameFiber
```

The GameFiber type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [GameFiber(ThreadStart)](M_Rage_GameFiber__ctor.htm) | Initializes a new instance of the GameFiber class. |
| Public method | [GameFiber(ThreadStart, String)](M_Rage_GameFiber__ctor_1.htm) | Initializes a new instance of the GameFiber class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public propertyStatic member | [CanSleepNow](P_Rage_GameFiber_CanSleepNow.htm) | Gets a value indicating whether the calling code is executing in the active GameFiber instance. |
| Public property | [IsAlive](P_Rage_GameFiber_IsAlive.htm) | Gets a value indicating whether this instance is still running. |
| Public property | [IsEntryFiber](P_Rage_GameFiber_IsEntryFiber.htm) | Gets or sets a value indicating whether this fiber is the original fiber created when this plugin was loaded. |
| Public property | [IsHibernating](P_Rage_GameFiber_IsHibernating.htm) | Gets a value indicating whether this instance is hibernating. |
| Public property | [IsSleeping](P_Rage_GameFiber_IsSleeping.htm) | Gets a value indicating whether this instance is sleeping. |
| Public property | [Name](P_Rage_GameFiber_Name.htm) | Gets the name of this instance. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Abort](M_Rage_GameFiber_Abort.htm) | Aborts this instance. |
| Public methodStatic member | [ExecuteFor](M_Rage_GameFiber_ExecuteFor.htm) | Calls the specified method once every tick on the calling GameFiber, for the specified duration. |
| Public methodStatic member | [ExecuteNewFor(ThreadStart, Int32)](M_Rage_GameFiber_ExecuteNewFor.htm) | Calls the specified method once every tick on a new GameFiber, for the specified duration. |
| Public methodStatic member | [ExecuteNewFor(ThreadStart, String, Int32)](M_Rage_GameFiber_ExecuteNewFor_1.htm) | Calls the specified method once every tick on a new GameFiber, for the specified duration. |
| Public methodStatic member | [ExecuteNewWhile(ThreadStart, FuncBoolean)](M_Rage_GameFiber_ExecuteNewWhile.htm) | Calls the specified method once every tick on a new GameFiber, while the specified condition is true. |
| Public methodStatic member | [ExecuteNewWhile(ThreadStart, String, FuncBoolean)](M_Rage_GameFiber_ExecuteNewWhile_1.htm) | Calls the specified method once every tick on a new GameFiber, while the specified condition is true. |
| Public methodStatic member | [ExecuteWhile](M_Rage_GameFiber_ExecuteWhile.htm) | Calls the specified method once every tick on the calling GameFiber, while the specified condition is true. |
| Public methodStatic member | [Hibernate](M_Rage_GameFiber_Hibernate.htm) | Makes the active GameFiber sleep indefinitely.  Other GameFibers can awaken this instance by calling Wake() on the instance. |
| Protected method | [HibernateThis](M_Rage_GameFiber_HibernateThis.htm) | Hibernates this instance. Note that only the active GameFiber can be set to hibernate. |
| Public methodStatic member | [Sleep](M_Rage_GameFiber_Sleep.htm) | Sleeps the active instance the specified duration. |
| Protected method | [SleepThis](M_Rage_GameFiber_SleepThis.htm) | Sleeps this instance the specified duration. Note that only the active GameFiber can be set to sleep. |
| Public methodStatic memberCode example | [SleepUntil](M_Rage_GameFiber_SleepUntil.htm) | Yields the executing fiber until the specified condition is met. |
| Public methodStatic memberCode example | [SleepWhile](M_Rage_GameFiber_SleepWhile.htm) | Yields the executing fiber while the specified condition is met. |
| Public method | [Start](M_Rage_GameFiber_Start.htm) | Starts this instance. |
| Public methodStatic member | [StartNew(ThreadStart)](M_Rage_GameFiber_StartNew.htm) | Starts a new GameFiber instance. |
| Public methodStatic member | [StartNew(ThreadStart, String)](M_Rage_GameFiber_StartNew_1.htm) | Starts a new GameFiber instance. |
| Public methodStatic member | [Wait](M_Rage_GameFiber_Wait.htm) | Waits the active instance the specified duration.  Unlike sleep, wait is scaled based on game time dilation. |
| Protected method | [WaitThis](M_Rage_GameFiber_WaitThis.htm) | Waits this instance the specified duration. Note that only the active GameFiber can be set to wait.  Unlike sleep, wait is scaled based on game time dilation. |
| Public methodStatic memberCode example | [WaitUntil(FuncBoolean)](M_Rage_GameFiber_WaitUntil.htm) | Yields the executing fiber until the specified condition is met. The condition is not checked while the game is paused. |
| Public methodStatic memberCode example | [WaitUntil(FuncBoolean, Int32)](M_Rage_GameFiber_WaitUntil_1.htm) | Yields the executing fiber until the specified condition is met. The condition is not checked while the game is paused. |
| Public methodStatic memberCode example | [WaitWhile(FuncBoolean)](M_Rage_GameFiber_WaitWhile.htm) | Yields the executing fiber while the specified condition is met. The condition is not checked while the game is paused. |
| Public methodStatic memberCode example | [WaitWhile(FuncBoolean, Int32)](M_Rage_GameFiber_WaitWhile_1.htm) | Yields the executing fiber while the specified condition is met. The condition is not checked while the game is paused. |
| Public method | [Wake](M_Rage_GameFiber_Wake.htm) | Awakens this instance from hibernation. |
| Public methodStatic member | [Yield](M_Rage_GameFiber_Yield.htm) | Yields this instance allowing other instances to be processed. Equivalent to Sleep(0); |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.