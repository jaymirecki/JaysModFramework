# Vector3 Structure

﻿Vector3 Structure

|  |  |  |
| --- | --- | --- |
| Vector3 Structure | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Defines a three component vector.

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
public struct Vector3 : IEquatable<Vector3>
```

```
<SerializableAttribute>
Public Structure Vector3
	Implements IEquatable(Of Vector3)
```

```
[SerializableAttribute]
public value class Vector3 : IEquatable<Vector3>
```

The Vector3 type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [Vector3(Single)](M_Rage_Vector3__ctor_1.htm) | Initializes a new instance of the Vector3 class. |
| Public method | [Vector3(Vector2, Single)](M_Rage_Vector3__ctor.htm) | Initializes a new instance of the Vector3 class. |
| Public method | [Vector3(Single, Single, Single)](M_Rage_Vector3__ctor_2.htm) | Initializes a new instance of the Vector3 class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Item](P_Rage_Vector3_Item.htm) |  |
| Public propertyStatic member | [RandomUnit](P_Rage_Vector3_RandomUnit.htm) | Returns a unit vector pointing in a random direction on the X and Y axes. |
| Public propertyStatic member | [RandomUnit2D](P_Rage_Vector3_RandomUnit2D.htm) | Returns a unit vector pointing in a random direction on the X and Y axes. |
| Public propertyStatic member | [RelativeBack](P_Rage_Vector3_RelativeBack.htm) | Returns the relative Back vector. (0,-1,0) |
| Public propertyStatic member | [RelativeBottom](P_Rage_Vector3_RelativeBottom.htm) | Returns the relative Bottom vector. (0,0,-1) |
| Public propertyStatic member | [RelativeFront](P_Rage_Vector3_RelativeFront.htm) | Returns the relative Front vector. (0,1,0) |
| Public propertyStatic member | [RelativeLeft](P_Rage_Vector3_RelativeLeft.htm) | Returns the relative Left vector. (-1,0,0) |
| Public propertyStatic member | [RelativeRight](P_Rage_Vector3_RelativeRight.htm) | Returns the relative Right vector. (1,0,0) |
| Public propertyStatic member | [RelativeTop](P_Rage_Vector3_RelativeTop.htm) | Returns the relative Top vector. (0,0,1) |
| Public propertyStatic member | [SizeInBytes](P_Rage_Vector3_SizeInBytes.htm) | Gets the size of the Vector3 type, in bytes. |
| Public propertyStatic member | [UnitX](P_Rage_Vector3_UnitX.htm) | Gets the X unit Vector3 (1, 0, 0). |
| Public propertyStatic member | [UnitY](P_Rage_Vector3_UnitY.htm) | Gets the Y unit Vector3 (0, 1, 0). |
| Public propertyStatic member | [UnitZ](P_Rage_Vector3_UnitZ.htm) | Gets the Z unit Vector3 (0, 0, 1). |
| Public propertyStatic member | [WorldDown](P_Rage_Vector3_WorldDown.htm) | Returns the world Down vector. (0,0,-1) |
| Public propertyStatic member | [WorldEast](P_Rage_Vector3_WorldEast.htm) | Returns the world East vector. (1,0,0) |
| Public propertyStatic member | [WorldNorth](P_Rage_Vector3_WorldNorth.htm) | Returns the world North vector. (0,1,0) |
| Public propertyStatic member | [WorldSouth](P_Rage_Vector3_WorldSouth.htm) | Returns the world South vector. (0,-1,0) |
| Public propertyStatic member | [WorldUp](P_Rage_Vector3_WorldUp.htm) | Returns the world Up vector. (0,0,1) |
| Public propertyStatic member | [WorldWest](P_Rage_Vector3_WorldWest.htm) | Returns the world West vector. (-1,0,0) |
| Public propertyStatic member | [Zero](P_Rage_Vector3_Zero.htm) | Gets a Vector3 with all of its components set to zero. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [Add(Vector3, Vector3)](M_Rage_Vector3_Add.htm) | Adds two vectors. |
| Public methodStatic member | [Add(Vector3, Vector3, Vector3)](M_Rage_Vector3_Add_1.htm) | Adds two vectors. |
| Public method | [Around(Single)](M_Rage_Vector3_Around.htm) | Gets a position that's exactly the specified distance from this position. |
| Public method | [Around(Single, Single)](M_Rage_Vector3_Around_1.htm) | Gets a position that's between the specified minimum and maximum distances from this position. |
| Public method | [Around2D(Single)](M_Rage_Vector3_Around2D.htm) | Gets a position that's exactly the specified distance from this position, with the same value on the Z-axis as this position. |
| Public method | [Around2D(Single, Single)](M_Rage_Vector3_Around2D_1.htm) | Gets a position that's between the specified minimum and maximum distances from this position, with the same value on the Z-axis as this position. |
| Public methodStatic member | [Barycentric(Vector3, Vector3, Vector3, Single, Single)](M_Rage_Vector3_Barycentric.htm) | Returns a Vector3 containing the 3D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 3D triangle. |
| Public methodStatic member | [Barycentric(Vector3, Vector3, Vector3, Single, Single, Vector3)](M_Rage_Vector3_Barycentric_1.htm) | Returns a Vector3 containing the 3D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 3D triangle. |
| Public methodStatic member | [CatmullRom(Vector3, Vector3, Vector3, Vector3, Single)](M_Rage_Vector3_CatmullRom.htm) | Performs a Catmull-Rom interpolation using the specified positions. |
| Public methodStatic member | [CatmullRom(Vector3, Vector3, Vector3, Vector3, Single, Vector3)](M_Rage_Vector3_CatmullRom_1.htm) | Performs a Catmull-Rom interpolation using the specified positions. |
| Public methodStatic member | [Clamp(Vector3, Vector3, Vector3)](M_Rage_Vector3_Clamp.htm) | Restricts a value to be within a specified range. |
| Public methodStatic member | [Clamp(Vector3, Vector3, Vector3, Vector3)](M_Rage_Vector3_Clamp_1.htm) | Restricts a value to be within a specified range. |
| Public methodStatic member | [Cross(Vector3, Vector3)](M_Rage_Vector3_Cross.htm) | Calculates the cross product of two vectors. |
| Public methodStatic member | [Cross(Vector3, Vector3, Vector3)](M_Rage_Vector3_Cross_1.htm) | Calculates the cross product of two vectors. |
| Public methodStatic member | [Distance(Vector3, ISpatial)](M_Rage_Vector3_Distance.htm) | Calculates the distance between a vector and a [ISpatial](T_Rage_ISpatial.htm) |
| Public methodStatic member | [Distance(Vector3, Vector3)](M_Rage_Vector3_Distance_1.htm) | Calculates the distance between two vectors. |
| Public methodStatic member | [Distance2D(Vector3, ISpatial)](M_Rage_Vector3_Distance2D.htm) | Calculates the distance between a vector and a [ISpatial](T_Rage_ISpatial.htm), ignoring the Z-component. |
| Public methodStatic member | [Distance2D(Vector3, Vector3)](M_Rage_Vector3_Distance2D_1.htm) | Calculates the distance between two vectors, ignoring the Z-component. |
| Public methodStatic member | [DistanceSquared(Vector3, ISpatial)](M_Rage_Vector3_DistanceSquared.htm) | Calculates the distance between a vector and a [ISpatial](T_Rage_ISpatial.htm), ignoring the Z-component. |
| Public methodStatic member | [DistanceSquared(Vector3, Vector3)](M_Rage_Vector3_DistanceSquared_1.htm) | Calculates the squared distance between two vectors. |
| Public method | [DistanceTo(ISpatial)](M_Rage_Vector3_DistanceTo.htm) |  |
| Public method | [DistanceTo(Vector3)](M_Rage_Vector3_DistanceTo_1.htm) |  |
| Public method | [DistanceTo2D(ISpatial)](M_Rage_Vector3_DistanceTo2D.htm) |  |
| Public method | [DistanceTo2D(Vector3)](M_Rage_Vector3_DistanceTo2D_1.htm) |  |
| Public methodStatic member | [Divide(Vector3, Single)](M_Rage_Vector3_Divide.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Divide(Vector3, Single, Vector3)](M_Rage_Vector3_Divide_1.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Dot](M_Rage_Vector3_Dot.htm) | Calculates the dot product of two vectors. |
| Public method | [Equals(Object)](M_Rage_Vector3_Equals_2.htm) | Returns a value that indicates whether the current instance is equal to a specified object. (Overrides [ValueTypeEquals(Object)](http://msdn2.microsoft.com/en-us/library/2dts52z7).) |
| Public method | [Equals(Vector3)](M_Rage_Vector3_Equals.htm) | Returns a value that indicates whether the current instance is equal to the specified object. |
| Public methodStatic member | [Equals(Vector3, Vector3)](M_Rage_Vector3_Equals_1.htm) | Determines whether the specified object instances are considered equal. |
| Public method | [GetHashCode](M_Rage_Vector3_GetHashCode.htm) | Returns the hash code for this instance. (Overrides [ValueTypeGetHashCode](http://msdn2.microsoft.com/en-us/library/y3509fc2).) |
| Public methodStatic member | [Hermite(Vector3, Vector3, Vector3, Vector3, Single)](M_Rage_Vector3_Hermite.htm) | Performs a Hermite spline interpolation. |
| Public methodStatic member | [Hermite(Vector3, Vector3, Vector3, Vector3, Single, Vector3)](M_Rage_Vector3_Hermite_1.htm) | Performs a Hermite spline interpolation. |
| Public method | [Length](M_Rage_Vector3_Length.htm) | Calculates the length of the vector. |
| Public method | [LengthSquared](M_Rage_Vector3_LengthSquared.htm) | Calculates the squared length of the vector. |
| Public methodStatic member | [Lerp(Vector3, Vector3, Single)](M_Rage_Vector3_Lerp.htm) | Performs a linear interpolation between two vectors. |
| Public methodStatic member | [Lerp(Vector3, Vector3, Single, Vector3)](M_Rage_Vector3_Lerp_1.htm) | Performs a linear interpolation between two vectors. |
| Public methodStatic member | [Maximize(Vector3, Vector3)](M_Rage_Vector3_Maximize.htm) | Returns a vector containing the largest components of the specified vectors. |
| Public methodStatic member | [Maximize(Vector3, Vector3, Vector3)](M_Rage_Vector3_Maximize_1.htm) | Returns a vector containing the smallest components of the specified vectors. |
| Public methodStatic member | [Minimize(Vector3, Vector3)](M_Rage_Vector3_Minimize.htm) | Returns a vector containing the smallest components of the specified vectors. |
| Public methodStatic member | [Minimize(Vector3, Vector3, Vector3)](M_Rage_Vector3_Minimize_1.htm) | Returns a vector containing the smallest components of the specified vectors. |
| Public methodStatic member | [Modulate(Vector3, Vector3)](M_Rage_Vector3_Modulate.htm) | Modulates a vector by another. |
| Public methodStatic member | [Modulate(Vector3, Vector3, Vector3)](M_Rage_Vector3_Modulate_1.htm) | Modulates a vector by another. |
| Public methodStatic member | [Multiply(Vector3, Single)](M_Rage_Vector3_Multiply.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Multiply(Vector3, Single, Vector3)](M_Rage_Vector3_Multiply_1.htm) | Scales a vector by the given value. |
| Public methodStatic member | [Negate(Vector3)](M_Rage_Vector3_Negate.htm) | Reverses the direction of a given vector. |
| Public methodStatic member | [Negate(Vector3, Vector3)](M_Rage_Vector3_Negate_1.htm) | Reverses the direction of a given vector. |
| Public method | [Normalize](M_Rage_Vector3_Normalize.htm) | Converts the vector into a unit vector. |
| Public methodStatic member | [Normalize(Vector3)](M_Rage_Vector3_Normalize_1.htm) | Converts the vector into a unit vector. |
| Public methodStatic member | [Normalize(Vector3, Vector3)](M_Rage_Vector3_Normalize_2.htm) | Converts the vector into a unit vector. |
| Public methodStatic member | [Project(Vector3, Single, Single, Single, Single, Single, Single, Matrix)](M_Rage_Vector3_Project.htm) | Projects a 3D vector from object space into screen space. |
| Public methodStatic member | [Project(Vector3, Single, Single, Single, Single, Single, Single, Matrix, Vector3)](M_Rage_Vector3_Project_1.htm) | Projects a 3D vector from object space into screen space. |
| Public method | [ProjectOnTo](M_Rage_Vector3_ProjectOnTo.htm) | Gets a new vector representing this vector projected onto the target vector. |
| Public methodStatic member | [Reflect(Vector3, Vector3)](M_Rage_Vector3_Reflect.htm) | Returns the reflection of a vector off a surface that has the specified normal. |
| Public methodStatic member | [Reflect(Vector3, Vector3, Vector3)](M_Rage_Vector3_Reflect_1.htm) | Returns the reflection of a vector off a surface that has the specified normal. |
| Public methodStatic member | [SmoothStep(Vector3, Vector3, Single)](M_Rage_Vector3_SmoothStep.htm) | Performs a cubic interpolation between two vectors. |
| Public methodStatic member | [SmoothStep(Vector3, Vector3, Single, Vector3)](M_Rage_Vector3_SmoothStep_1.htm) | Performs a cubic interpolation between two vectors. |
| Public methodStatic member | [Subtract(Vector3, Vector3)](M_Rage_Vector3_Subtract.htm) | Subtracts two vectors. |
| Public methodStatic member | [Subtract(Vector3, Vector3, Vector3)](M_Rage_Vector3_Subtract_1.htm) | Subtracts two vectors. |
| Public method | [ToNormalized](M_Rage_Vector3_ToNormalized.htm) |  |
| Public method | [ToQuaternion](M_Rage_Vector3_ToQuaternion.htm) |  |
| Public method | [ToRotator](M_Rage_Vector3_ToRotator.htm) |  |
| Public method | [ToString](M_Rage_Vector3_ToString.htm) | Converts the value of the object to its equivalent string representation. (Overrides [ValueTypeToString](http://msdn2.microsoft.com/en-us/library/wb77sz3h).) |
| Public methodStatic member | [Transform(Vector3, Matrix)](M_Rage_Vector3_Transform_2.htm) | Transforms a 3D vector by the given Matrix. |
| Public methodStatic member | [Transform(Vector3, Quaternion)](M_Rage_Vector3_Transform_3.htm) | Transforms a 3D vector by the given Quaternion rotation. |
| Public methodStatic member | [Transform(Vector3, Matrix)](M_Rage_Vector3_Transform_6.htm) | Transforms an array of 3D vectors by the given Matrix. |
| Public methodStatic member | [Transform(Vector3, Quaternion)](M_Rage_Vector3_Transform_9.htm) | Transforms an array of 3D vectors by the given Quaternion rotation. |
| Public methodStatic member | [Transform(Vector3, Matrix, Vector4)](M_Rage_Vector3_Transform_4.htm) | Transforms a 3D vector by the given Matrix. |
| Public methodStatic member | [Transform(Vector3, Quaternion, Vector4)](M_Rage_Vector3_Transform_5.htm) | Transforms a 3D vector by the given Quaternion rotation. |
| Public methodStatic member | [Transform(Vector3, Matrix, Vector4)](M_Rage_Vector3_Transform_7.htm) | Transforms an array of 3D vectors by the given Matrix. |
| Public methodStatic member | [Transform(Vector3\*, Matrix\*, Vector4\*, Int32)](M_Rage_Vector3_Transform.htm) | Transforms an array of 3D vectors by the given Matrix. |
| Public methodStatic member | [Transform(Vector3, Matrix, Vector4, Int32, Int32)](M_Rage_Vector3_Transform_8.htm) | Transforms an array of 3D vectors by the given Matrix. |
| Public methodStatic member | [Transform(Vector3\*, Int32, Matrix\*, Vector4\*, Int32, Int32)](M_Rage_Vector3_Transform_1.htm) | Transforms an array of 3D vectors by the given Matrix. |
| Public methodStatic member | [TransformCoordinate(Vector3, Matrix)](M_Rage_Vector3_TransformCoordinate_2.htm) | Performs a coordinate transformation using the given Matrix. |
| Public methodStatic member | [TransformCoordinate(Vector3, Matrix)](M_Rage_Vector3_TransformCoordinate_4.htm) | Performs a coordinate transformation using the given Matrix. |
| Public methodStatic member | [TransformCoordinate(Vector3, Matrix, Vector3)](M_Rage_Vector3_TransformCoordinate_3.htm) | Performs a coordinate transformation using the given Matrix. |
| Public methodStatic member | [TransformCoordinate(Vector3, Matrix, Vector3)](M_Rage_Vector3_TransformCoordinate_5.htm) | Performs a coordinate transformation using the given Matrix. |
| Public methodStatic member | [TransformCoordinate(Vector3\*, Matrix\*, Vector3\*, Int32)](M_Rage_Vector3_TransformCoordinate.htm) | Performs a coordinate transformation using the given Matrix. |
| Public methodStatic member | [TransformCoordinate(Vector3, Matrix, Vector3, Int32, Int32)](M_Rage_Vector3_TransformCoordinate_6.htm) | Performs a coordinate transformation using the given Matrix. |
| Public methodStatic member | [TransformCoordinate(Vector3\*, Int32, Matrix\*, Vector3\*, Int32, Int32)](M_Rage_Vector3_TransformCoordinate_1.htm) | Performs a coordinate transformation using the given Matrix. |
| Public methodStatic member | [TransformNormal(Vector3, Matrix)](M_Rage_Vector3_TransformNormal_2.htm) | Performs a normal transformation using the given Matrix. |
| Public methodStatic member | [TransformNormal(Vector3, Matrix)](M_Rage_Vector3_TransformNormal_4.htm) | Performs a normal transformation using the given Matrix. |
| Public methodStatic member | [TransformNormal(Vector3, Matrix, Vector3)](M_Rage_Vector3_TransformNormal_3.htm) | Performs a normal transformation using the given Matrix. |
| Public methodStatic member | [TransformNormal(Vector3, Matrix, Vector3)](M_Rage_Vector3_TransformNormal_5.htm) | Performs a normal transformation using the given Matrix. |
| Public methodStatic member | [TransformNormal(Vector3\*, Matrix\*, Vector3\*, Int32)](M_Rage_Vector3_TransformNormal.htm) | Performs a normal transformation using the given Matrix. |
| Public methodStatic member | [TransformNormal(Vector3, Matrix, Vector3, Int32, Int32)](M_Rage_Vector3_TransformNormal_6.htm) | Performs a normal transformation using the given Matrix. |
| Public methodStatic member | [TransformNormal(Vector3\*, Int32, Matrix\*, Vector3\*, Int32, Int32)](M_Rage_Vector3_TransformNormal_1.htm) | Performs a normal transformation using the given Matrix. |
| Public methodStatic member | [TravelDistance(Vector3, ISpatial)](M_Rage_Vector3_TravelDistance.htm) |  |
| Public methodStatic member | [TravelDistance(Vector3, Vector3)](M_Rage_Vector3_TravelDistance_1.htm) |  |
| Public method | [TravelDistanceTo(ISpatial)](M_Rage_Vector3_TravelDistanceTo.htm) |  |
| Public method | [TravelDistanceTo(Vector3)](M_Rage_Vector3_TravelDistanceTo_1.htm) |  |
| Public methodStatic member | [Unproject(Vector3, Single, Single, Single, Single, Single, Single, Matrix)](M_Rage_Vector3_Unproject.htm) | Projects a 3D vector from screen space into object space. |
| Public methodStatic member | [Unproject(Vector3, Single, Single, Single, Single, Single, Single, Matrix, Vector3)](M_Rage_Vector3_Unproject_1.htm) | Projects a 3D vector from screen space into object space. |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [Addition](M_Rage_Vector3_op_Addition.htm) | Adds two vectors. |
| Public operatorStatic member | [Division](M_Rage_Vector3_op_Division.htm) | Scales a vector by the given value. |
| Public operatorStatic member | [Equality](M_Rage_Vector3_op_Equality.htm) | Tests for equality between two objects. |
| Public operatorStatic member | [Inequality](M_Rage_Vector3_op_Inequality.htm) | Tests for inequality between two objects. |
| Public operatorStatic member | [Multiply(Single, Vector3)](M_Rage_Vector3_op_Multiply_1.htm) | Scales a vector by the given value. |
| Public operatorStatic member | [Multiply(Vector3, Single)](M_Rage_Vector3_op_Multiply.htm) | Scales a vector by the given value. |
| Public operatorStatic member | [Subtraction](M_Rage_Vector3_op_Subtraction.htm) | Subtracts two vectors. |
| Public operatorStatic member | [UnaryNegation](M_Rage_Vector3_op_UnaryNegation.htm) | Reverses the direction of a given vector. |

[Top](#mainBody)

Fields

|  | Name | Description |
| --- | --- | --- |
| Public field | [X](F_Rage_Vector3_X.htm) | Gets or sets the X component of the vector. |
| Public field | [Y](F_Rage_Vector3_Y.htm) | Gets or sets the Y component of the vector. |
| Public field | [Z](F_Rage_Vector3_Z.htm) | Gets or sets the Z component of the vector. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.