# CleanupManager Class

﻿CleanupManager Class

|  |  |  |
| --- | --- | --- |
| CleanupManager Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Class for cleaning up [IDeletable](T_Rage_IDeletable.htm)s.

Examples

The following example spawns a car, and deletes it 3 seconds after it's been destroyed.
The CleanupManager removes the [IDeletable](T_Rage_IDeletable.htm)s that's been added to it, when it gets disposed.

C#

[Copy](# "Copy")

```
using(CleanupManager cleanupManager = new CleanupManager())
{
    Vector3 spawnPosition = playerVehicle.GetOffsetPosition(new Vector3(-3f, 7f, 0f));
    Vehicle car = new Vehicle("POLICE2", spawnPosition, playerVehicle.Heading);
    cleanupManager.Add(car);
    while (!car.IsDead)
    {
        GameFiber.Yield();
    }

    GameFiber.Sleep(3000);
}
```

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageCleanupManager  
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
public sealed class CleanupManager : IDisposable
```

```
Public NotInheritable Class CleanupManager
	Implements IDisposable
```

```
public ref class CleanupManager sealed : IDisposable
```

The CleanupManager type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [CleanupManager](M_Rage_CleanupManager__ctor.htm) | Initializes a new instance of the CleanupManager class. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Add](M_Rage_CleanupManager_Add.htm) | Adds the specified [IDeletable](T_Rage_IDeletable.htm) to this CleanupManager. |
| Public method | [Dispose](M_Rage_CleanupManager_Dispose.htm) | Finalizes an instance of the CleanupManager class. |
| Public method | [Remove](M_Rage_CleanupManager_Remove.htm) | Removes the specified [IDeletable](T_Rage_IDeletable.htm) from this CleanupManager. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.