# GameFiber Methods

﻿GameFiber Methods

|  |  |  |
| --- | --- | --- |
| GameFiber Methods | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [GameFiber](T_Rage_GameFiber.htm) type exposes the following members.

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Abort](M_Rage_GameFiber_Abort.htm) | Aborts this instance. |
| Public methodStatic member | [ExecuteFor](M_Rage_GameFiber_ExecuteFor.htm) | Calls the specified method once every tick on the calling [GameFiber](T_Rage_GameFiber.htm), for the specified duration. |
| Public methodStatic member | [ExecuteNewFor(ThreadStart, Int32)](M_Rage_GameFiber_ExecuteNewFor.htm) | Calls the specified method once every tick on a new [GameFiber](T_Rage_GameFiber.htm), for the specified duration. |
| Public methodStatic member | [ExecuteNewFor(ThreadStart, String, Int32)](M_Rage_GameFiber_ExecuteNewFor_1.htm) | Calls the specified method once every tick on a new [GameFiber](T_Rage_GameFiber.htm), for the specified duration. |
| Public methodStatic member | [ExecuteNewWhile(ThreadStart, FuncBoolean)](M_Rage_GameFiber_ExecuteNewWhile.htm) | Calls the specified method once every tick on a new [GameFiber](T_Rage_GameFiber.htm), while the specified condition is true. |
| Public methodStatic member | [ExecuteNewWhile(ThreadStart, String, FuncBoolean)](M_Rage_GameFiber_ExecuteNewWhile_1.htm) | Calls the specified method once every tick on a new [GameFiber](T_Rage_GameFiber.htm), while the specified condition is true. |
| Public methodStatic member | [ExecuteWhile](M_Rage_GameFiber_ExecuteWhile.htm) | Calls the specified method once every tick on the calling [GameFiber](T_Rage_GameFiber.htm), while the specified condition is true. |
| Public methodStatic member | [Hibernate](M_Rage_GameFiber_Hibernate.htm) | Makes the active [GameFiber](T_Rage_GameFiber.htm) sleep indefinitely.  Other [GameFiber](T_Rage_GameFiber.htm)s can awaken this instance by calling Wake() on the instance. |
| Protected method | [HibernateThis](M_Rage_GameFiber_HibernateThis.htm) | Hibernates this instance. Note that only the active [GameFiber](T_Rage_GameFiber.htm) can be set to hibernate. |
| Public methodStatic member | [Sleep](M_Rage_GameFiber_Sleep.htm) | Sleeps the active instance the specified duration. |
| Protected method | [SleepThis](M_Rage_GameFiber_SleepThis.htm) | Sleeps this instance the specified duration. Note that only the active [GameFiber](T_Rage_GameFiber.htm) can be set to sleep. |
| Public methodStatic memberCode example | [SleepUntil](M_Rage_GameFiber_SleepUntil.htm) | Yields the executing fiber until the specified condition is met. |
| Public methodStatic memberCode example | [SleepWhile](M_Rage_GameFiber_SleepWhile.htm) | Yields the executing fiber while the specified condition is met. |
| Public method | [Start](M_Rage_GameFiber_Start.htm) | Starts this instance. |
| Public methodStatic member | [StartNew(ThreadStart)](M_Rage_GameFiber_StartNew.htm) | Starts a new [GameFiber](T_Rage_GameFiber.htm) instance. |
| Public methodStatic member | [StartNew(ThreadStart, String)](M_Rage_GameFiber_StartNew_1.htm) | Starts a new [GameFiber](T_Rage_GameFiber.htm) instance. |
| Public methodStatic member | [Wait](M_Rage_GameFiber_Wait.htm) | Waits the active instance the specified duration.  Unlike sleep, wait is scaled based on game time dilation. |
| Protected method | [WaitThis](M_Rage_GameFiber_WaitThis.htm) | Waits this instance the specified duration. Note that only the active [GameFiber](T_Rage_GameFiber.htm) can be set to wait.  Unlike sleep, wait is scaled based on game time dilation. |
| Public methodStatic memberCode example | [WaitUntil(FuncBoolean)](M_Rage_GameFiber_WaitUntil.htm) | Yields the executing fiber until the specified condition is met. The condition is not checked while the game is paused. |
| Public methodStatic memberCode example | [WaitUntil(FuncBoolean, Int32)](M_Rage_GameFiber_WaitUntil_1.htm) | Yields the executing fiber until the specified condition is met. The condition is not checked while the game is paused. |
| Public methodStatic memberCode example | [WaitWhile(FuncBoolean)](M_Rage_GameFiber_WaitWhile.htm) | Yields the executing fiber while the specified condition is met. The condition is not checked while the game is paused. |
| Public methodStatic memberCode example | [WaitWhile(FuncBoolean, Int32)](M_Rage_GameFiber_WaitWhile_1.htm) | Yields the executing fiber while the specified condition is met. The condition is not checked while the game is paused. |
| Public method | [Wake](M_Rage_GameFiber_Wake.htm) | Awakens this instance from hibernation. |
| Public methodStatic member | [Yield](M_Rage_GameFiber_Yield.htm) | Yields this instance allowing other instances to be processed. Equivalent to Sleep(0); |

[Top](#mainBody)

See Also

#### Reference

[GameFiber Class](T_Rage_GameFiber.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.