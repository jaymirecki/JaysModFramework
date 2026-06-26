# Vector2 Structure

﻿Vector2 Structure

|  |  |  |
| --- | --- | --- |
| Vector2 Structure | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Defines a two component vector.

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
public struct Vector2 : IEquatable<Vector2>
```

```
<SerializableAttribute>
Public Structure Vector2
	Implements IEquatable(Of Vector2)
```

```
[SerializableAttribute]
public value class Vector2 : IEquatable<Vector2>
```

The Vector2 type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [Vector2(Single)](M_Rage_Vector2__ctor.htm) | Initializes a new instance of the Vector2 class. |
| Public method | [Vector2(Single, Single)](M_Rage_Vector2__ctor_1.htm) | Initializes a new instance of the Vector2 class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Item](P_Rage_Vector2_Item.htm) |  |
| Public propertyStatic member | [SizeInBytes](P_Rage_Vector2_SizeInBytes.htm) | Gets the size of the Vector2 type, in bytes. |
| Public propertyStatic member | [UnitX](P_Rage_Vector2_UnitX.htm) | Gets the X unit Vector2 (1, 0). |
| Public propertyStatic member | [UnitY](P_Rage_Vector2_UnitY.htm) | Gets the Y unit Vector2 (0, 1). |
| Public propertyStatic member | [Zero](P_Rage_Vector2_Zero.htm) | Gets a Vector2 with all of its components set to zero. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [Add(Vector2, Vector2)](M_Rage_Vector2_Add.htm) | Adds two vectors. |
| Public methodStatic member | [Add(Vector2, Vector2, Vector2)](M_Rage_Vector2_Add_1.htm) | Adds two vectors. |
| Public methodStatic member | [Barycentric(Vector2, Vector2, Vector2, Single, Single)](M_Rage_Vector2_Barycentric.htm) | Returns a Vector2 containing the 2D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 2D triangle. |
| Public methodStatic member | [Barycentric(Vector2, Vector2, Vector2, Single, Single, Vector2)](M_Rage_Vector2_Barycentric_1.htm) | Returns a Vector2 containing the 2D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 2D triangle. |
| Public methodStatic member | [CatmullRom(Vector2, Vector2, Vector2, Vector2, Single)](M_Rage_Vector2_CatmullRom.htm) | Performs a Catmull-Rom interpolation using the specified positions. |
| Public methodStatic member | [CatmullRom(Vector2, Vector2, Vector2, Vector2, Single, Vector2)](M_Rage_Vector2_CatmullRom_1.htm) | Performs a Catmull-Rom interpolation using the specified positions. |
| Public methodStatic member | [Clamp(Vector2, Vector2, Vector2)](M_Rage_Vector2_Clamp.htm) | Restricts a value to be within a specified range. |
| Public methodStatic member | [Clamp(Vector2, Vector2, Vector2, Vector2)](M_Rage_Vector2_Clamp_1.htm) | Restricts a value to be within a specified range. |
| Public methodStatic member | [Distance](M_Rage_Vector2_Distance.htm) | Calculates the distance between two vectors. |
| Public methodStatic member | [DistanceSquared](M_Rage_Vector2_DistanceSquared.htm) | Calculates the squared distance between two vectors. |
| Public method | [DistanceTo](M_Rage_Vector2_DistanceTo.htm) |  |
| Public methodStatic member | [Divide(Vector2, Single)](M_Rage_Vector2_Divide.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Divide(Vector2, Single, Vector2)](M_Rage_Vector2_Divide_1.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Dot](M_Rage_Vector2_Dot.htm) | Calculates the dot product of two vectors. |
| Public method | [Equals(Object)](M_Rage_Vector2_Equals_2.htm) | Returns a value that indicates whether the current instance is equal to a specified object. (Overrides [ValueTypeEquals(Object)](http://msdn2.microsoft.com/en-us/library/2dts52z7).) |
| Public method | [Equals(Vector2)](M_Rage_Vector2_Equals.htm) | Returns a value that indicates whether the current instance is equal to the specified object. |
| Public methodStatic member | [Equals(Vector2, Vector2)](M_Rage_Vector2_Equals_1.htm) | Determines whether the specified object instances are considered equal. |
| Public method | [GetHashCode](M_Rage_Vector2_GetHashCode.htm) | Returns the hash code for this instance. (Overrides [ValueTypeGetHashCode](http://msdn2.microsoft.com/en-us/library/y3509fc2).) |
| Public methodStatic member | [Hermite(Vector2, Vector2, Vector2, Vector2, Single)](M_Rage_Vector2_Hermite.htm) | Performs a Hermite spline interpolation. |
| Public methodStatic member | [Hermite(Vector2, Vector2, Vector2, Vector2, Single, Vector2)](M_Rage_Vector2_Hermite_1.htm) | Performs a Hermite spline interpolation. |
| Public method | [Length](M_Rage_Vector2_Length.htm) | Calculates the length of the vector. |
| Public method | [LengthSquared](M_Rage_Vector2_LengthSquared.htm) | Calculates the squared length of the vector. |
| Public methodStatic member | [Lerp(Vector2, Vector2, Single)](M_Rage_Vector2_Lerp.htm) | Performs a linear interpolation between two vectors. |
| Public methodStatic member | [Lerp(Vector2, Vector2, Single, Vector2)](M_Rage_Vector2_Lerp_1.htm) | Performs a linear interpolation between two vectors. |
| Public methodStatic member | [Maximize(Vector2, Vector2)](M_Rage_Vector2_Maximize.htm) | Returns a vector containing the largest components of the specified vectors. |
| Public methodStatic member | [Maximize(Vector2, Vector2, Vector2)](M_Rage_Vector2_Maximize_1.htm) | Returns a vector containing the smallest components of the specified vectors. |
| Public methodStatic member | [Minimize(Vector2, Vector2)](M_Rage_Vector2_Minimize.htm) | Returns a vector containing the smallest components of the specified vectors. |
| Public methodStatic member | [Minimize(Vector2, Vector2, Vector2)](M_Rage_Vector2_Minimize_1.htm) | Returns a vector containing the smallest components of the specified vectors. |
| Public methodStatic member | [Modulate(Vector2, Vector2)](M_Rage_Vector2_Modulate.htm) | Modulates a vector by another. |
| Public methodStatic member | [Modulate(Vector2, Vector2, Vector2)](M_Rage_Vector2_Modulate_1.htm) | Modulates a vector by another. |
| Public methodStatic member | [Multiply(Vector2, Single)](M_Rage_Vector2_Multiply.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Multiply(Vector2, Single, Vector2)](M_Rage_Vector2_Multiply_1.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Negate(Vector2)](M_Rage_Vector2_Negate.htm) | Reverses the direction of a given vector. |
| Public methodStatic member | [Negate(Vector2, Vector2)](M_Rage_Vector2_Negate_1.htm) | Reverses the direction of a given vector. |
| Public method | [Normalize](M_Rage_Vector2_Normalize.htm) | Converts the vector into a unit vector. |
| Public methodStatic member | [Normalize(Vector2)](M_Rage_Vector2_Normalize_1.htm) | Converts the vector into a unit vector. |
| Public methodStatic member | [Normalize(Vector2, Vector2)](M_Rage_Vector2_Normalize_2.htm) | Converts the vector into a unit vector. |
| Public method | [ProjectOnTo](M_Rage_Vector2_ProjectOnTo.htm) |  |
| Public methodStatic member | [SmoothStep(Vector2, Vector2, Single)](M_Rage_Vector2_SmoothStep.htm) | Performs a cubic interpolation between two vectors. |
| Public methodStatic member | [SmoothStep(Vector2, Vector2, Single, Vector2)](M_Rage_Vector2_SmoothStep_1.htm) | Performs a cubic interpolation between two vectors. |
| Public methodStatic member | [Subtract(Vector2, Vector2)](M_Rage_Vector2_Subtract.htm) | Subtracts two vectors. |
| Public methodStatic member | [Subtract(Vector2, Vector2, Vector2)](M_Rage_Vector2_Subtract_1.htm) | Subtracts two vectors. |
| Public method | [ToString](M_Rage_Vector2_ToString.htm) | Converts the value of the object to its equivalent string representation. (Overrides [ValueTypeToString](http://msdn2.microsoft.com/en-us/library/wb77sz3h).) |
| Public methodStatic member | [Transform(Vector2, Matrix)](M_Rage_Vector2_Transform.htm) | Transforms a 2D vector by the given Matrix. |
| Public methodStatic member | [Transform(Vector2, Quaternion)](M_Rage_Vector2_Transform_1.htm) | Transforms a 2D vector by the given Quaternion rotation. |
| Public methodStatic member | [Transform(Vector2, Matrix)](M_Rage_Vector2_Transform_4.htm) | Transforms an array of 2D vectors by the given Matrix. |
| Public methodStatic member | [Transform(Vector2, Quaternion)](M_Rage_Vector2_Transform_5.htm) | Transforms an array of 2D vectors by the given Quaternion rotation. |
| Public methodStatic member | [Transform(Vector2, Matrix, Vector4)](M_Rage_Vector2_Transform_2.htm) | Transforms a 2D vector by the given Matrix. |
| Public methodStatic member | [Transform(Vector2, Quaternion, Vector4)](M_Rage_Vector2_Transform_3.htm) | Transforms a 2D vector by the given Quaternion rotation. |
| Public methodStatic member | [TransformCoordinate(Vector2, Matrix)](M_Rage_Vector2_TransformCoordinate.htm) | Performs a coordinate transformation using the given Matrix. |
| Public methodStatic member | [TransformCoordinate(Vector2, Matrix)](M_Rage_Vector2_TransformCoordinate_2.htm) | Performs a coordinate transformation using the given Matrix. |
| Public methodStatic member | [TransformCoordinate(Vector2, Matrix, Vector2)](M_Rage_Vector2_TransformCoordinate_1.htm) | Performs a coordinate transformation using the given Matrix. |
| Public methodStatic member | [TransformNormal(Vector2, Matrix)](M_Rage_Vector2_TransformNormal.htm) | Performs a normal transformation using the given Matrix. |
| Public methodStatic member | [TransformNormal(Vector2, Matrix)](M_Rage_Vector2_TransformNormal_2.htm) | Performs a normal transformation using the given Matrix. |
| Public methodStatic member | [TransformNormal(Vector2, Matrix, Vector2)](M_Rage_Vector2_TransformNormal_1.htm) | Performs a normal transformation using the given Matrix. |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [Addition](M_Rage_Vector2_op_Addition.htm) | Adds two vectors. |
| Public operatorStatic member | [Division](M_Rage_Vector2_op_Division.htm) | Scales a vector by the given value. |
| Public operatorStatic member | [Equality](M_Rage_Vector2_op_Equality.htm) | Tests for equality between two objects. |
| Public operatorStatic member | [Inequality](M_Rage_Vector2_op_Inequality.htm) | Tests for inequality between two objects. |
| Public operatorStatic member | [Multiply(Single, Vector2)](M_Rage_Vector2_op_Multiply_1.htm) | Scales a vector by the given value. |
| Public operatorStatic member | [Multiply(Vector2, Single)](M_Rage_Vector2_op_Multiply.htm) | Scales a vector by the given value. |
| Public operatorStatic member | [Subtraction](M_Rage_Vector2_op_Subtraction.htm) | Subtracts two vectors. |
| Public operatorStatic member | [UnaryNegation](M_Rage_Vector2_op_UnaryNegation.htm) | Reverses the direction of a given vector. |

[Top](#mainBody)

Fields

|  | Name | Description |
| --- | --- | --- |
| Public field | [X](F_Rage_Vector2_X.htm) | Gets or sets the X component of the vector. |
| Public field | [Y](F_Rage_Vector2_Y.htm) | Gets or sets the Y component of the vector. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.