# Debug.DrawArrowDebug Method

﻿Debug.DrawArrowDebug Method 

|  |  |  |
| --- | --- | --- |
| DebugDrawArrowDebug Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "M:Rage.Debug.DrawArrowDebug(Rage.Vector3,Rage.Vector3,Rage.Rotator,System.Single,System.Drawing.Color)"]

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
[ConditionalAttribute("DEBUG")]
public static void DrawArrowDebug(
	Vector3 position,
	Vector3 direction,
	Rotator rotationOffset,
	float scale,
	Color color
)
```

```
<ConditionalAttribute("DEBUG")>
Public Shared Sub DrawArrowDebug ( 
	position As Vector3,
	direction As Vector3,
	rotationOffset As Rotator,
	scale As Single,
	color As Color
)
```

```
public:
[ConditionalAttribute(L"DEBUG")]
static void DrawArrowDebug(
	Vector3 position, 
	Vector3 direction, 
	Rotator rotationOffset, 
	float scale, 
	Color color
)
```

#### Parameters

position
:   Type: [RageVector3](T_Rage_Vector3.htm)  

    [Missing <param name="position"/> documentation for "M:Rage.Debug.DrawArrowDebug(Rage.Vector3,Rage.Vector3,Rage.Rotator,System.Single,System.Drawing.Color)"]

direction
:   Type: [RageVector3](T_Rage_Vector3.htm)  

    [Missing <param name="direction"/> documentation for "M:Rage.Debug.DrawArrowDebug(Rage.Vector3,Rage.Vector3,Rage.Rotator,System.Single,System.Drawing.Color)"]

rotationOffset
:   Type: [RageRotator](T_Rage_Rotator.htm)  

    [Missing <param name="rotationOffset"/> documentation for "M:Rage.Debug.DrawArrowDebug(Rage.Vector3,Rage.Vector3,Rage.Rotator,System.Single,System.Drawing.Color)"]

scale
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  

    [Missing <param name="scale"/> documentation for "M:Rage.Debug.DrawArrowDebug(Rage.Vector3,Rage.Vector3,Rage.Rotator,System.Single,System.Drawing.Color)"]

color
:   Type: [System.DrawingColor](http://msdn2.microsoft.com/en-us/library/14w97wkc)  

    [Missing <param name="color"/> documentation for "M:Rage.Debug.DrawArrowDebug(Rage.Vector3,Rage.Vector3,Rage.Rotator,System.Single,System.Drawing.Color)"]

See Also

#### Reference

[Debug Class](T_Rage_Debug.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.