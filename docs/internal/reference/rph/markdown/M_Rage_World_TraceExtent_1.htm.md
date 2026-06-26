# World.TraceExtent Method (Vector3, Vector3, Single, TraceFlags, Predicate(Entity))

﻿World.TraceExtent Method (Vector3, Vector3, Single, TraceFlags, Predicate(Entity))

|  |  |  |
| --- | --- | --- |
| WorldTraceExtent Method (Vector3, Vector3, Single, TraceFlags, PredicateEntity) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

**Note: This API is now obsolete.**

[Missing <summary> documentation for "M:Rage.World.TraceExtent(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,System.Predicate{Rage.Entity})"]

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
[ObsoleteAttribute("Use TraceCapsule instead.", true)]
[HandleProcessCorruptedStateExceptionsAttribute]
public static HitResult TraceExtent(
	Vector3 start,
	Vector3 end,
	float radius,
	TraceFlags flags,
	Predicate<Entity> entityPredicate
)
```

```
<ObsoleteAttribute("Use TraceCapsule instead.", true)>
<HandleProcessCorruptedStateExceptionsAttribute>
Public Shared Function TraceExtent ( 
	start As Vector3,
	end As Vector3,
	radius As Single,
	flags As TraceFlags,
	entityPredicate As Predicate(Of Entity)
) As HitResult
```

```
public:
[ObsoleteAttribute(L"Use TraceCapsule instead.", true)]
[HandleProcessCorruptedStateExceptionsAttribute]
static HitResult TraceExtent(
	Vector3 start, 
	Vector3 end, 
	float radius, 
	TraceFlags flags, 
	Predicate<Entity^>^ entityPredicate
)
```

#### Parameters

start
:   Type: [RageVector3](T_Rage_Vector3.htm)  

    [Missing <param name="start"/> documentation for "M:Rage.World.TraceExtent(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,System.Predicate{Rage.Entity})"]

end
:   Type: [RageVector3](T_Rage_Vector3.htm)  

    [Missing <param name="end"/> documentation for "M:Rage.World.TraceExtent(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,System.Predicate{Rage.Entity})"]

radius
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  

    [Missing <param name="radius"/> documentation for "M:Rage.World.TraceExtent(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,System.Predicate{Rage.Entity})"]

flags
:   Type: [RageTraceFlags](T_Rage_TraceFlags.htm)  

    [Missing <param name="flags"/> documentation for "M:Rage.World.TraceExtent(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,System.Predicate{Rage.Entity})"]

entityPredicate
:   Type: [SystemPredicate](http://msdn2.microsoft.com/en-us/library/bfcke1bz)[Entity](T_Rage_Entity.htm)  

    [Missing <param name="entityPredicate"/> documentation for "M:Rage.World.TraceExtent(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,System.Predicate{Rage.Entity})"]

#### Return Value

Type: [HitResult](T_Rage_HitResult.htm)  

[Missing <returns> documentation for "M:Rage.World.TraceExtent(Rage.Vector3,Rage.Vector3,System.Single,Rage.TraceFlags,System.Predicate{Rage.Entity})"]

See Also

#### Reference

[World Class](T_Rage_World.htm)

[TraceExtent Overload](Overload_Rage_World_TraceExtent.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.