# Vector4 Structure

﻿Vector4 Structure

|  |  |  |
| --- | --- | --- |
| Vector4 Structure | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Defines a four component vector.

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
[SerializableAttribute]
public struct Vector4 : IEquatable<Vector4>
```

```
<SerializableAttribute>
Public Structure Vector4
	Implements IEquatable(Of Vector4)
```

```
[SerializableAttribute]
public value class Vector4 : IEquatable<Vector4>
```

The Vector4 type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [Vector4(Single)](M_Rage_Vector4__ctor_2.htm) | Initializes a new instance of the Vector4 class. |
| Public method | [Vector4(Vector3, Single)](M_Rage_Vector4__ctor_1.htm) | Initializes a new instance of the Vector4 class. |
| Public method | [Vector4(Vector2, Single, Single)](M_Rage_Vector4__ctor.htm) | Initializes a new instance of the Vector4 class. |
| Public method | [Vector4(Single, Single, Single, Single)](M_Rage_Vector4__ctor_3.htm) | Initializes a new instance of the Vector4 class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Item](P_Rage_Vector4_Item.htm) |  |
| Public propertyStatic member | [SizeInBytes](P_Rage_Vector4_SizeInBytes.htm) | Gets the size of the Vector4 type, in bytes. |
| Public propertyStatic member | [UnitW](P_Rage_Vector4_UnitW.htm) | Gets the W unit Vector4 (0, 0, 0, 1). |
| Public propertyStatic member | [UnitX](P_Rage_Vector4_UnitX.htm) | Gets the X unit Vector4 (1, 0, 0, 0). |
| Public propertyStatic member | [UnitY](P_Rage_Vector4_UnitY.htm) | Gets the Y unit Vector4 (0, 1, 0, 0). |
| Public propertyStatic member | [UnitZ](P_Rage_Vector4_UnitZ.htm) | Gets the Z unit Vector4 (0, 0, 1, 0). |
| Public propertyStatic member | [Zero](P_Rage_Vector4_Zero.htm) | Gets a Vector4 with all of its components set to zero. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [Add(Vector4, Vector4)](M_Rage_Vector4_Add.htm) | Adds two vectors. |
| Public methodStatic member | [Add(Vector4, Vector4, Vector4)](M_Rage_Vector4_Add_1.htm) | Adds two vectors. |
| Public methodStatic member | [Barycentric(Vector4, Vector4, Vector4, Single, Single)](M_Rage_Vector4_Barycentric.htm) | Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 4D triangle. |
| Public methodStatic member | [Barycentric(Vector4, Vector4, Vector4, Single, Single, Vector4)](M_Rage_Vector4_Barycentric_1.htm) | Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 4D triangle. |
| Public methodStatic member | [CatmullRom(Vector4, Vector4, Vector4, Vector4, Single)](M_Rage_Vector4_CatmullRom.htm) | Performs a Catmull-Rom interpolation using the specified positions. |
| Public methodStatic member | [CatmullRom(Vector4, Vector4, Vector4, Vector4, Single, Vector4)](M_Rage_Vector4_CatmullRom_1.htm) | Performs a Catmull-Rom interpolation using the specified positions. |
| Public methodStatic member | [Clamp(Vector4, Vector4, Vector4)](M_Rage_Vector4_Clamp.htm) | Restricts a value to be within a specified range. |
| Public methodStatic member | [Clamp(Vector4, Vector4, Vector4, Vector4)](M_Rage_Vector4_Clamp_1.htm) | Restricts a value to be within a specified range. |
| Public methodStatic member | [Distance](M_Rage_Vector4_Distance.htm) | Calculates the distance between two vectors. |
| Public methodStatic member | [DistanceSquared](M_Rage_Vector4_DistanceSquared.htm) | Calculates the squared distance between two vectors. |
| Public methodStatic member | [Divide(Vector4, Single)](M_Rage_Vector4_Divide.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Divide(Vector4, Single, Vector4)](M_Rage_Vector4_Divide_1.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Dot](M_Rage_Vector4_Dot.htm) | Calculates the dot product of two vectors. |
| Public method | [Equals(Object)](M_Rage_Vector4_Equals_2.htm) | Returns a value that indicates whether the current instance is equal to a specified object. (Overrides [ValueTypeEquals(Object)](http://msdn2.microsoft.com/en-us/library/2dts52z7).) |
| Public method | [Equals(Vector4)](M_Rage_Vector4_Equals.htm) | Returns a value that indicates whether the current instance is equal to the specified object. |
| Public methodStatic member | [Equals(Vector4, Vector4)](M_Rage_Vector4_Equals_1.htm) | Determines whether the specified object instances are considered equal. |
| Public method | [GetHashCode](M_Rage_Vector4_GetHashCode.htm) | Returns the hash code for this instance. (Overrides [ValueTypeGetHashCode](http://msdn2.microsoft.com/en-us/library/y3509fc2).) |
| Public methodStatic member | [Hermite(Vector4, Vector4, Vector4, Vector4, Single)](M_Rage_Vector4_Hermite.htm) | Performs a Hermite spline interpolation. |
| Public methodStatic member | [Hermite(Vector4, Vector4, Vector4, Vector4, Single, Vector4)](M_Rage_Vector4_Hermite_1.htm) | Performs a Hermite spline interpolation. |
| Public method | [Length](M_Rage_Vector4_Length.htm) | Calculates the length of the vector. |
| Public method | [LengthSquared](M_Rage_Vector4_LengthSquared.htm) | Calculates the squared length of the vector. |
| Public methodStatic member | [Lerp(Vector4, Vector4, Single)](M_Rage_Vector4_Lerp.htm) | Performs a linear interpolation between two vectors. |
| Public methodStatic member | [Lerp(Vector4, Vector4, Single, Vector4)](M_Rage_Vector4_Lerp_1.htm) | Performs a linear interpolation between two vectors. |
| Public methodStatic member | [Maximize(Vector4, Vector4)](M_Rage_Vector4_Maximize.htm) | Returns a vector containing the largest components of the specified vectors. |
| Public methodStatic member | [Maximize(Vector4, Vector4, Vector4)](M_Rage_Vector4_Maximize_1.htm) | Returns a vector containing the smallest components of the specified vectors. |
| Public methodStatic member | [Minimize(Vector4, Vector4)](M_Rage_Vector4_Minimize.htm) | Returns a vector containing the smallest components of the specified vectors. |
| Public methodStatic member | [Minimize(Vector4, Vector4, Vector4)](M_Rage_Vector4_Minimize_1.htm) | Returns a vector containing the smallest components of the specified vectors. |
| Public methodStatic member | [Modulate(Vector4, Vector4)](M_Rage_Vector4_Modulate.htm) | Modulates a vector by another. |
| Public methodStatic member | [Modulate(Vector4, Vector4, Vector4)](M_Rage_Vector4_Modulate_1.htm) | Modulates a vector by another. |
| Public methodStatic member | [Multiply(Vector4, Single)](M_Rage_Vector4_Multiply.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Multiply(Vector4, Single, Vector4)](M_Rage_Vector4_Multiply_1.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Negate(Vector4)](M_Rage_Vector4_Negate.htm) | Reverses the direction of a given vector. |
| Public methodStatic member | [Negate(Vector4, Vector4)](M_Rage_Vector4_Negate_1.htm) | Reverses the direction of a given vector. |
| Public method | [Normalize](M_Rage_Vector4_Normalize.htm) | Converts the vector into a unit vector. |
| Public methodStatic member | [Normalize(Vector4)](M_Rage_Vector4_Normalize_1.htm) | Converts the vector into a unit vector. |
| Public methodStatic member | [Normalize(Vector4, Vector4)](M_Rage_Vector4_Normalize_2.htm) | Converts the vector into a unit vector. |
| Public methodStatic member | [SmoothStep(Vector4, Vector4, Single)](M_Rage_Vector4_SmoothStep.htm) | Performs a cubic interpolation between two vectors. |
| Public methodStatic member | [SmoothStep(Vector4, Vector4, Single, Vector4)](M_Rage_Vector4_SmoothStep_1.htm) | Performs a cubic interpolation between two vectors. |
| Public methodStatic member | [Subtract(Vector4, Vector4)](M_Rage_Vector4_Subtract.htm) | Subtracts two vectors. |
| Public methodStatic member | [Subtract(Vector4, Vector4, Vector4)](M_Rage_Vector4_Subtract_1.htm) | Subtracts two vectors. |
| Public method | [ToString](M_Rage_Vector4_ToString.htm) | Converts the value of the object to its equivalent string representation. (Overrides [ValueTypeToString](http://msdn2.microsoft.com/en-us/library/wb77sz3h).) |
| Public methodStatic member | [Transform(Vector4, Matrix)](M_Rage_Vector4_Transform.htm) | Transforms a 4D vector by the given Matrix. |
| Public methodStatic member | [Transform(Vector4, Quaternion)](M_Rage_Vector4_Transform_1.htm) | Transforms a 4D vector by the given Quaternion rotation. |
| Public methodStatic member | [Transform(Vector4, Matrix)](M_Rage_Vector4_Transform_4.htm) | Transforms an array of 4D vectors by the given Matrix. |
| Public methodStatic member | [Transform(Vector4, Quaternion)](M_Rage_Vector4_Transform_5.htm) | Transforms an array of 4D vectors by the given Quaternion rotation. |
| Public methodStatic member | [Transform(Vector4, Matrix, Vector4)](M_Rage_Vector4_Transform_2.htm) | Transforms a 4D vector by the given Matrix. |
| Public methodStatic member | [Transform(Vector4, Quaternion, Vector4)](M_Rage_Vector4_Transform_3.htm) | Transforms a 4D vector by the given Quaternion rotation. |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [Addition](M_Rage_Vector4_op_Addition.htm) | Adds two vectors. |
| Public operatorStatic member | [Division](M_Rage_Vector4_op_Division.htm) | Scales a vector by the given value. |
| Public operatorStatic member | [Equality](M_Rage_Vector4_op_Equality.htm) | Tests for equality between two objects. |
| Public operatorStatic member | [Inequality](M_Rage_Vector4_op_Inequality.htm) | Tests for inequality between two objects. |
| Public operatorStatic member | [Multiply(Single, Vector4)](M_Rage_Vector4_op_Multiply_1.htm) | Scales a vector by the given value. |
| Public operatorStatic member | [Multiply(Vector4, Single)](M_Rage_Vector4_op_Multiply.htm) | Scales a vector by the given value. |
| Public operatorStatic member | [Subtraction](M_Rage_Vector4_op_Subtraction.htm) | Subtracts two vectors. |
| Public operatorStatic member | [UnaryNegation](M_Rage_Vector4_op_UnaryNegation.htm) | Reverses the direction of a given vector. |

[Top](#mainBody)

Fields

|  | Name | Description |
| --- | --- | --- |
| Public field | [W](F_Rage_Vector4_W.htm) | Gets or sets the W component of the vector. |
| Public field | [X](F_Rage_Vector4_X.htm) | Gets or sets the X component of the vector. |
| Public field | [Y](F_Rage_Vector4_Y.htm) | Gets or sets the Y component of the vector. |
| Public field | [Z](F_Rage_Vector4_Z.htm) | Gets or sets the Z component of the vector. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.