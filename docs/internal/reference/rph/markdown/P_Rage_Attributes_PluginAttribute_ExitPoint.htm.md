# PluginAttribute.ExitPoint Property

﻿PluginAttribute.ExitPoint Property 

|  |  |  |
| --- | --- | --- |
| PluginAttributeExitPoint Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Gets or sets the full name of the method to serve as exit point of the plugin (Eg. "EntryPoint.OnUnload". If null, the first found method that's static, returns void, takes a bool and is named "OnUnload" will be used.

**Namespace:**
 [Rage.Attributes](N_Rage_Attributes.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
public string ExitPoint { get; set; }
```

```
Public Property ExitPoint As String
	Get
	Set
```

```
public:
property String^ ExitPoint {
	String^ get ();
	void set (String^ value);
}
```

#### Property Value

Type: [String](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
The full name (type and method) of the method to call when the plugin is unloaded (either gracefully or forcefully).

Exceptions

| Exception | Condition |
| --- | --- |
| [ArgumentNullException](http://msdn2.microsoft.com/en-us/library/27426hcy) | Thrown if value is null. |

Remarks

The exit point must have the following signature (access modifier and name can be anything):

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
private static void OnUnload(bool isTerminating)
{
}
```

```
Private Shared Sub OnUnload(isTerminating As Boolean)
End Sub
```

No code example is currently available or this language may not be supported.

When the plugin is unloaded, all fibers are aborted, and then a new fiber is started to execute the exit method, which means that calls to GameFiber.Sleep(), etc. are valid.

If isTerminating is true, the plugin is being forcefully unloaded, in which case sleeping is illegal. Use the value of isTerminating to determine whether you can sleep or not.

While the exit method is executed on a fiber, new fibers cannot be started once the plugin is unloading and any attempt to do so will throw an exception.

See Also

#### Reference

[PluginAttribute Class](T_Rage_Attributes_PluginAttribute.htm)

[Rage.Attributes Namespace](N_Rage_Attributes.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.