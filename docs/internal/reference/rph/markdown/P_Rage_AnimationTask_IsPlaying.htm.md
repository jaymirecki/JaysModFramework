# AnimationTask.IsPlaying Property

﻿AnimationTask.IsPlaying Property 

|  |  |  |
| --- | --- | --- |
| AnimationTaskIsPlaying Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets a value indicating whether the animation represented by this task is currently playing.

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
public bool IsPlaying { get; }
```

```
Public ReadOnly Property IsPlaying As Boolean
	Get
```

```
public:
property bool IsPlaying {
	bool get ();
}
```

#### Property Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
true if the animation is currently playing; otherwise false.

Remarks

Animations do not play on the tick they were started, so if calling this to check whether an animation has ended, make sure to yield for one tick after calling [TaskInvoker](T_Rage_TaskInvoker.htm).PlayAnimation().

See Also

#### Reference

[AnimationTask Class](T_Rage_AnimationTask.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.