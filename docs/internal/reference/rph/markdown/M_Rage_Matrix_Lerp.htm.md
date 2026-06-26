# Matrix.Lerp Method (Matrix, Matrix, Single)

﻿Matrix.Lerp Method (Matrix, Matrix, Single)

|  |  |  |
| --- | --- | --- |
| MatrixLerp Method (Matrix, Matrix, Single) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Performs a linear interpolation between two matricies.

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
public static Matrix Lerp(
	Matrix start,
	Matrix end,
	float amount
)
```

```
Public Shared Function Lerp ( 
	start As Matrix,
	end As Matrix,
	amount As Single
) As Matrix
```

```
public:
static Matrix Lerp(
	Matrix start, 
	Matrix end, 
	float amount
)
```

#### Parameters

start
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    Start matrix.

end
:   Type: [RageMatrix](T_Rage_Matrix.htm)  
    End matrix.

amount
:   Type: [SystemSingle](http://msdn2.microsoft.com/en-us/library/3www918f)  
    Value between 0 and 1 indicating the weight of end.

#### Return Value

Type: [Matrix](T_Rage_Matrix.htm)  
The linear interpolation of the two matrices.

Remarks

This method performs the linear interpolation based on the following formula.

[Copy](# "Copy")

```
start + (end - start) * amount
```

Passing amount a value of 0 will cause start to be returned; a value of 1 will cause end to be returned.

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Lerp Overload](Overload_Rage_Matrix_Lerp.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.