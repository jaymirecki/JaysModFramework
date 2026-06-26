# Camera.IsValid Method

﻿Camera.IsValid Method 

|  |  |  |
| --- | --- | --- |
| CameraIsValid Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Determines whether this instance still represents an existing entity within the game world. Calls to an invalid instance is illegal and will result in an exception.

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
public override sealed bool IsValid()
```

```
Public Overrides NotOverridable Function IsValid As Boolean
```

```
public:
virtual bool IsValid() override sealed
```

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
If this instance still represents an existing entity within the game world, returns true; otherwise, returns false.

#### Implements

[IHandleableIsValid](M_Rage_IHandleable_IsValid.htm)  

See Also

#### Reference

[Camera Class](T_Rage_Camera.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.