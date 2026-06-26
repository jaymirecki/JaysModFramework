# Matrix.Item Property

﻿Matrix.Item Property 

|  |  |  |
| --- | --- | --- |
| MatrixItem Property | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "P:Rage.Matrix.Item(System.Int32,System.Int32)"]

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
[BrowsableAttribute(false)]
public float this[
	int row,
	int column
] { get; set; }
```

```
<BrowsableAttribute(false)>
Public Default Property Item ( 
	row As Integer,
	column As Integer
) As Single
	Get
	Set
```

```
public:
[BrowsableAttribute(false)]
property float default[int row, int column] {
	float get (int row, int column);
	void set (int row, int column, float value);
}
```

#### Parameters

row
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)

column
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)

#### Property Value

Type: [Single](http://msdn2.microsoft.com/en-us/library/3www918f)  

[Missing <value> documentation for "P:Rage.Matrix.Item(System.Int32,System.Int32)"]

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.