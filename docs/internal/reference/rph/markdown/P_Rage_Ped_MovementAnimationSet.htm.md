# Ped.MovementAnimationSet Property

﻿Ped.MovementAnimationSet Property 

|  |  |  |
| --- | --- | --- |
| PedMovementAnimationSet Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the [AnimationSet](T_Rage_AnimationSet.htm) used by this [Ped](T_Rage_Ped.htm) for movement.

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
public Nullable<AnimationSet> MovementAnimationSet { get; set; }
```

```
Public Property MovementAnimationSet As Nullable(Of AnimationSet)
	Get
	Set
```

```
public:
property Nullable<AnimationSet> MovementAnimationSet {
	Nullable<AnimationSet> get ();
	void set (Nullable<AnimationSet> value);
}
```

#### Property Value

Type: [Nullable](http://msdn2.microsoft.com/en-us/library/b3h38hb0)[AnimationSet](T_Rage_AnimationSet.htm)  
The [AnimationSet](T_Rage_AnimationSet.htm) used by this [Ped](T_Rage_Ped.htm) for movement. If null the original [AnimationSet](T_Rage_AnimationSet.htm) will be restored.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.