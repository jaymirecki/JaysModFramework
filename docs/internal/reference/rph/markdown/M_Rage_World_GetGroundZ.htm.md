# World.GetGroundZ Method

﻿World.GetGroundZ Method 

|  |  |  |
| --- | --- | --- |
| WorldGetGroundZ Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets the Z value of the ground surface at the specified position.

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
public static Nullable<float> GetGroundZ(
	Vector3 position,
	bool treatWaterAsGround,
	bool anyMeans
)
```

```
Public Shared Function GetGroundZ ( 
	position As Vector3,
	treatWaterAsGround As Boolean,
	anyMeans As Boolean
) As Nullable(Of Single)
```

```
public:
static Nullable<float> GetGroundZ(
	Vector3 position, 
	bool treatWaterAsGround, 
	bool anyMeans
)
```

#### Parameters

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The position to get the ground at.

treatWaterAsGround
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    if set to true water will be treated as ground as well; otherwise, over water, the sea bottom will be treated as ground.

anyMeans
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    if set to true, the method may execute over many ticks (0 ticks, to several thousand milliseconds), but will be able to find most positions, even if several kilometers from the player.

#### Return Value

Type: [Nullable](http://msdn2.microsoft.com/en-us/library/b3h38hb0)[Single](http://msdn2.microsoft.com/en-us/library/3www918f)  
If successful, returns the Z value of the ground surface; otherwise, returns null.

Remarks

Getting the ground Z value relies on world collision. World collision is normally only loaded around the player, so this method will work within a few hundred meters of the player.

If the specified position is at a location without world collision (eg. several kilometers from the player), the method will fail and return null, unless anyMeans is set to true.

Furthermore, the method will also fail if the specified position is below the ground surface, unless anyMeans is set to true.

If anyMeans is set to true; this method may take several ticks (yielding the fiber) to execute, depending on the position and world collision. For example, if the specified position is far away from the player, the method will first have to load world collision at the position, wait for it to load, then find the Z value at the position.

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.