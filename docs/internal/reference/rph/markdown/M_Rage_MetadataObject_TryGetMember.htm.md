# MetadataObject.TryGetMember Method

﻿MetadataObject.TryGetMember Method 

|  |  |  |
| --- | --- | --- |
| MetadataObjectTryGetMember Method | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "M:Rage.MetadataObject.TryGetMember(System.Dynamic.GetMemberBinder,System.Object@)"]

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
public override sealed bool TryGetMember(
	GetMemberBinder binder,
	out Object result
)
```

```
Public Overrides NotOverridable Function TryGetMember ( 
	binder As GetMemberBinder,
	<OutAttribute> ByRef result As Object
) As Boolean
```

```
public:
virtual bool TryGetMember(
	GetMemberBinder^ binder, 
	[OutAttribute] Object^% result
) override sealed
```

#### Parameters

binder
:   Type: [System.DynamicGetMemberBinder](http://msdn2.microsoft.com/en-us/library/dd487405)  

    [Missing <param name="binder"/> documentation for "M:Rage.MetadataObject.TryGetMember(System.Dynamic.GetMemberBinder,System.Object@)"]

result
:   Type: [SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  

    [Missing <param name="result"/> documentation for "M:Rage.MetadataObject.TryGetMember(System.Dynamic.GetMemberBinder,System.Object@)"]

#### Return Value

Type: [Boolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  

[Missing <returns> documentation for "M:Rage.MetadataObject.TryGetMember(System.Dynamic.GetMemberBinder,System.Object@)"]

See Also

#### Reference

[MetadataObject Class](T_Rage_MetadataObject.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.