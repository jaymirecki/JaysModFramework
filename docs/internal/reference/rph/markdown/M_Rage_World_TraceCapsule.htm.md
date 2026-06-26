# World.TraceCapsule Method (Vector3, Vector3, Single, TraceFlags, Entity[])

﻿World.TraceCapsule Method (Vector3, Vector3, Single, TraceFlags, Entity[])

|  |  |  |
| --- | --- | --- |
| WorldTraceCapsule Method (Vector3, Vector3, Single, TraceFlags, Entity) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "M:Rage.World.TraceCapsule(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,Rage.Entity[])"]

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
[HandleProcessCorruptedStateExceptionsAttribute]
public static HitResult TraceCapsule(
	Vector3 start,
	Vector3 end,
	float radius,
	TraceFlags flags,
	params Entity[] entitiesToIgnore
)
```

```
<HandleProcessCorruptedStateExceptionsAttribute>
Public Shared Function TraceCapsule ( 
	start As Vector3,
	end As Vector3,
	radius As Single,
	flags As TraceFlags,
	ParamArray entitiesToIgnore As Entity()
) As HitResult
```

```
public:
[HandleProcessCorruptedStateExceptionsAttribute]
static HitResult TraceCapsule(
	Vector3 start, 
	Vector3 end, 
	float radius, 
	TraceFlags flags, 
	... array<Entity^>^ entitiesToIgnore
)
```

#### Parameters

start
:   Type: [RageVector3](T_Rage_Vector3.htm)  

    [Missing <param name="start"/> documentation for "M:Rage.World.TraceCapsule(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,Rage.Entity[])"]

end
:   Type: [RageVector3](T_Rage_Vector3.htm)  

    [Missing <param name="end"/> documentation for "M:Rage.World.TraceCapsule(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,Rage.Entity[])"]

radius
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  

    [Missing <param name="radius"/> documentation for "M:Rage.World.TraceCapsule(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,Rage.Entity[])"]

flags
:   Type: [RageTraceFlags](T_Rage_TraceFlags.htm)  

    [Missing <param name="flags"/> documentation for "M:Rage.World.TraceCapsule(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,Rage.Entity[])"]

entitiesToIgnore
:   Type: [RageEntity](T_Rage_Entity.htm)  

    [Missing <param name="entitiesToIgnore"/> documentation for "M:Rage.World.TraceCapsule(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,Rage.Entity[])"]

#### Return Value

Type: [HitResult](T_Rage_HitResult.htm)  

[Missing <returns> documentation for "M:Rage.World.TraceCapsule(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,Rage.Entity[])"]

See Also

#### Reference

[World Class](T_Rage_World.htm)

[TraceCapsule Overload](Overload_Rage_World_TraceCapsule.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.