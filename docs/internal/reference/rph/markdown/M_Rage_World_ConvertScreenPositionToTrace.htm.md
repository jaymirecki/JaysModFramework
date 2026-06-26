# World.ConvertScreenPositionToTrace Method

﻿World.ConvertScreenPositionToTrace Method 

|  |  |  |
| --- | --- | --- |
| WorldConvertScreenPositionToTrace Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a trace start position and trace direction from the specified screen position.

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
public static bool ConvertScreenPositionToTrace(
	Camera camera,
	Vector2 screenPosition,
	out Vector3 traceStartPosition,
	out Vector3 traceDirection
)
```

```
Public Shared Function ConvertScreenPositionToTrace ( 
	camera As Camera,
	screenPosition As Vector2,
	<OutAttribute> ByRef traceStartPosition As Vector3,
	<OutAttribute> ByRef traceDirection As Vector3
) As Boolean
```

```
public:
static bool ConvertScreenPositionToTrace(
	Camera^ camera, 
	Vector2 screenPosition, 
	[OutAttribute] Vector3% traceStartPosition, 
	[OutAttribute] Vector3% traceDirection
)
```

#### Parameters

camera
:   Type: [RageCamera](T_Rage_Camera.htm)  
    The camera currently being rendered.

screenPosition
:   Type: [RageVector2](T_Rage_Vector2.htm)  
    The screen position.

traceStartPosition
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The trace start position.

traceDirection
:   Type: [RageVector3](T_Rage_Vector3.htm)  
    The direction to trace in.

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
A [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50) indicating whether the call was successful. Will only be false if the current camera could not be determined.

Examples

The following example will get the position of the surface at the given screen position.

C#

[Copy](# "Copy")

```
Vector3? GetWorldPosition(Camera camera, Vector2 screenPosition)
{
    Vector3 traceStart;
    Vector3 traceDirection;
    if (World.ConvertScreenPositionToTrace(camera, screenPosition, out traceStart, out traceDirection))
    {
        Vector3 traceEnd = traceStart + traceDirection * 1000;
        HitResult hitResult = World.TraceLine(traceStart, traceEnd, TraceFlags.IntersectEverything);
        if (hitResult.Hit)
        {
            return hitResult.HitPosition;
        }
    }

    return null;
}
```

See Also

#### Reference

[World Class](T_Rage_World.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.