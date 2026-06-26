# World.SpawnExplosion Method

﻿World.SpawnExplosion Method 

|  |  |  |
| --- | --- | --- |
| WorldSpawnExplosion Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Spawns an explosion at the specified position.

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
public static void SpawnExplosion(
	Vector3 position,
	int explosionType,
	float radius,
	bool audible,
	bool invisible,
	float cameraShakeAmount
)
```

```
Public Shared Sub SpawnExplosion ( 
	position As Vector3,
	explosionType As Integer,
	radius As Single,
	audible As Boolean,
	invisible As Boolean,
	cameraShakeAmount As Single
)
```

```
public:
static void SpawnExplosion(
	Vector3 position, 
	int explosionType, 
	float radius, 
	bool audible, 
	bool invisible, 
	float cameraShakeAmount
)
```

#### Parameters

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position to spawn the explosion at.

explosionType
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The type of explosion.

radius
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The radius.

audible
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    true if the explosion should be audible; otherwise, false.

invisible
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    true if the explosion should be invisible; otherwise, false.

cameraShakeAmount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    The amount of camera shake to apply.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.