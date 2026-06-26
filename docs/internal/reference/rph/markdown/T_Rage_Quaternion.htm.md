# Quaternion Structure

﻿Quaternion Structure

|  |  |  |
| --- | --- | --- |
| Quaternion Structure | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Defines a four dimensional mathematical quaternion.

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
public struct Quaternion : IEquatable<Quaternion>
```

```
<SerializableAttribute>
Public Structure Quaternion
	Implements IEquatable(Of Quaternion)
```

```
[SerializableAttribute]
public value class Quaternion : IEquatable<Quaternion>
```

The Quaternion type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [Quaternion(Vector3, Single)](M_Rage_Quaternion__ctor.htm) | Initializes a new instance of the Quaternion structure. |
| Public method | [Quaternion(Single, Single, Single, Single)](M_Rage_Quaternion__ctor_1.htm) | Initializes a new instance of the Quaternion structure. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Angle](P_Rage_Quaternion_Angle.htm) | Gets the angle of the quaternion. The quaternion must be normalized. |
| Public property | [Axis](P_Rage_Quaternion_Axis.htm) | Gets the axis components of the quaternion. The quaternion must be normalized. |
| Public propertyStatic member | [Identity](P_Rage_Quaternion_Identity.htm) | Gets the identity Quaternion (0, 0, 0, 1). |
| Public property | [IsIdentity](P_Rage_Quaternion_IsIdentity.htm) | Gets a value indicating whether this instance is an identity Quaternion. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [Add(Quaternion, Quaternion)](M_Rage_Quaternion_Add.htm) | Adds two quaternions. |
| Public methodStatic member | [Add(Quaternion, Quaternion, Quaternion)](M_Rage_Quaternion_Add_1.htm) | Adds two quaternions. |
| Public methodStatic member | [Barycentric(Quaternion, Quaternion, Quaternion, Single, Single)](M_Rage_Quaternion_Barycentric.htm) | Returns a Quaternion containing the 4D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 2D triangle. |
| Public methodStatic member | [Barycentric(Quaternion, Quaternion, Quaternion, Single, Single, Quaternion)](M_Rage_Quaternion_Barycentric_1.htm) | Returns a Quaternion containing the 4D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 2D triangle. |
| Public method | [Conjugate](M_Rage_Quaternion_Conjugate.htm) | Conjugates the quaternion. |
| Public methodStatic member | [Conjugate(Quaternion)](M_Rage_Quaternion_Conjugate_1.htm) | Conjugates a quaternion. |
| Public methodStatic member | [Conjugate(Quaternion, Quaternion)](M_Rage_Quaternion_Conjugate_2.htm) | Conjugates a quaternion. |
| Public methodStatic member | [Divide(Quaternion, Quaternion)](M_Rage_Quaternion_Divide.htm) | Divides a quaternion by another. |
| Public methodStatic member | [Divide(Quaternion, Quaternion, Quaternion)](M_Rage_Quaternion_Divide_1.htm) | Divides a quaternion by another. |
| Public methodStatic member | [Dot](M_Rage_Quaternion_Dot.htm) | Calculates the dot product of two quaternions. |
| Public method | [Equals(Object)](M_Rage_Quaternion_Equals_2.htm) | Returns a value that indicates whether the current instance is equal to a specified object. (Overrides [ValueTypeEquals(Object)](http://msdn2.microsoft.com/en-us/library/2dts52z7).) |
| Public method | [Equals(Quaternion)](M_Rage_Quaternion_Equals.htm) | Returns a value that indicates whether the current instance is equal to the specified object. |
| Public methodStatic member | [Equals(Quaternion, Quaternion)](M_Rage_Quaternion_Equals_1.htm) | Determines whether the specified object instances are considered equal. |
| Public methodStatic member | [Exponential(Quaternion)](M_Rage_Quaternion_Exponential.htm) | Exponentiates a quaternion. |
| Public methodStatic member | [Exponential(Quaternion, Quaternion)](M_Rage_Quaternion_Exponential_1.htm) | Exponentiates a quaternion. |
| Public methodStatic member | [FromAxes](M_Rage_Quaternion_FromAxes.htm) |  |
| Public methodStatic member | [FromRotation](M_Rage_Quaternion_FromRotation.htm) |  |
| Public method | [GetAxes](M_Rage_Quaternion_GetAxes.htm) |  |
| Public method | [GetAxis](M_Rage_Quaternion_GetAxis.htm) |  |
| Public method | [GetHashCode](M_Rage_Quaternion_GetHashCode.htm) | Returns the hash code for this instance. (Overrides [ValueTypeGetHashCode](http://msdn2.microsoft.com/en-us/library/y3509fc2).) |
| Public method | [Invert](M_Rage_Quaternion_Invert.htm) | Conjugates and renormalizes the quaternion. |
| Public methodStatic member | [Invert(Quaternion)](M_Rage_Quaternion_Invert_1.htm) | Conjugates and renormalizes the quaternion. |
| Public methodStatic member | [Invert(Quaternion, Quaternion)](M_Rage_Quaternion_Invert_2.htm) | Conjugates and renormalizes the quaternion. |
| Public method | [Length](M_Rage_Quaternion_Length.htm) | Calculates the length of the quaternion. |
| Public method | [LengthSquared](M_Rage_Quaternion_LengthSquared.htm) | Calculates the squared length of the quaternion. |
| Public methodStatic member | [Lerp(Quaternion, Quaternion, Single)](M_Rage_Quaternion_Lerp.htm) | Performs a linear interpolation between two quaternion. |
| Public methodStatic member | [Lerp(Quaternion, Quaternion, Single, Quaternion)](M_Rage_Quaternion_Lerp_1.htm) | Performs a linear interpolation between two quaternions. |
| Public methodStatic member | [Logarithm(Quaternion)](M_Rage_Quaternion_Logarithm.htm) | Calculates the natural logarithm of the specified quaternion. |
| Public methodStatic member | [Logarithm(Quaternion, Quaternion)](M_Rage_Quaternion_Logarithm_1.htm) | Calculates the natural logarithm of the specified quaternion. |
| Public methodStatic member | [Multiply(Quaternion, Quaternion)](M_Rage_Quaternion_Multiply.htm) | Modulates a quaternion by another. |
| Public methodStatic member | [Multiply(Quaternion, Single)](M_Rage_Quaternion_Multiply_1.htm) | Scales a quaternion by the given value. |
| Public methodStatic member | [Multiply(Quaternion, Quaternion, Quaternion)](M_Rage_Quaternion_Multiply_2.htm) | Modulates a quaternion by another. |
| Public methodStatic member | [Multiply(Quaternion, Single, Quaternion)](M_Rage_Quaternion_Multiply_3.htm) | Scales a quaternion by the given value. |
| Public methodStatic member | [Negate(Quaternion)](M_Rage_Quaternion_Negate.htm) | Reverses the direction of a given quaternion. |
| Public methodStatic member | [Negate(Quaternion, Quaternion)](M_Rage_Quaternion_Negate_1.htm) | Reverses the direction of a given quaternion. |
| Public method | [Normalize](M_Rage_Quaternion_Normalize.htm) | Converts the quaternion into a unit quaternion. |
| Public methodStatic member | [Normalize(Quaternion)](M_Rage_Quaternion_Normalize_1.htm) | Converts the quaternion into a unit quaternion. |
| Public methodStatic member | [Normalize(Quaternion, Quaternion)](M_Rage_Quaternion_Normalize_2.htm) | Converts the quaternion into a unit quaternion. |
| Public methodStatic member | [RotationAxis(Vector3, Single)](M_Rage_Quaternion_RotationAxis.htm) | Creates a quaternion given a rotation and an axis. |
| Public methodStatic member | [RotationAxis(Vector3, Single, Quaternion)](M_Rage_Quaternion_RotationAxis_1.htm) | Creates a quaternion given a rotation and an axis. |
| Public methodStatic member | [RotationMatrix(Matrix)](M_Rage_Quaternion_RotationMatrix.htm) | Creates a quaternion given a rotation matrix. |
| Public methodStatic member | [RotationMatrix(Matrix, Quaternion)](M_Rage_Quaternion_RotationMatrix_1.htm) | Creates a quaternion given a rotation matrix. |
| Public methodStatic member | [RotationYawPitchRoll(Single, Single, Single)](M_Rage_Quaternion_RotationYawPitchRoll.htm) | Creates a quaternion given a yaw, pitch, and roll value. |
| Public methodStatic member | [RotationYawPitchRoll(Single, Single, Single, Quaternion)](M_Rage_Quaternion_RotationYawPitchRoll_1.htm) | Creates a quaternion given a yaw, pitch, and roll value. |
| Public methodStatic member | [Slerp(Quaternion, Quaternion, Single)](M_Rage_Quaternion_Slerp.htm) | Interpolates between two quaternions, using spherical linear interpolation. |
| Public methodStatic member | [Slerp(Quaternion, Quaternion, Single, Quaternion)](M_Rage_Quaternion_Slerp_1.htm) | Interpolates between two quaternions, using spherical linear interpolation. |
| Public methodStatic member | [Squad(Quaternion, Quaternion, Quaternion, Quaternion, Single)](M_Rage_Quaternion_Squad.htm) | Interpolates between quaternions, using spherical quadrangle interpolation. |
| Public methodStatic member | [Squad(Quaternion, Quaternion, Quaternion, Quaternion, Single, Quaternion)](M_Rage_Quaternion_Squad_1.htm) | Interpolates between quaternions, using spherical quadrangle interpolation. |
| Public methodStatic member | [SquadSetup](M_Rage_Quaternion_SquadSetup.htm) | Sets up control points for spherical quadrangle interpolation. |
| Public methodStatic member | [Subtract(Quaternion, Quaternion)](M_Rage_Quaternion_Subtract.htm) | Subtracts two quaternions. |
| Public methodStatic member | [Subtract(Quaternion, Quaternion, Quaternion)](M_Rage_Quaternion_Subtract_1.htm) | Subtracts two quaternions. |
| Public method | [ToRotation](M_Rage_Quaternion_ToRotation.htm) |  |
| Public method | [ToString](M_Rage_Quaternion_ToString.htm) | Converts the value of the object to its equivalent string representation. (Overrides [ValueTypeToString](http://msdn2.microsoft.com/en-us/library/wb77sz3h).) |
| Public method | [ToVector](M_Rage_Quaternion_ToVector.htm) |  |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [Addition](M_Rage_Quaternion_op_Addition.htm) | Adds two quaternions. |
| Public operatorStatic member | [Division](M_Rage_Quaternion_op_Division.htm) | Divides a quaternion by another. |
| Public operatorStatic member | [Equality](M_Rage_Quaternion_op_Equality.htm) | Tests for equality between two objects. |
| Public operatorStatic member | [Inequality](M_Rage_Quaternion_op_Inequality.htm) | Tests for inequality between two objects. |
| Public operatorStatic member | [Multiply(Single, Quaternion)](M_Rage_Quaternion_op_Multiply_2.htm) | Scales a quaternion by the given value. |
| Public operatorStatic member | [Multiply(Quaternion, Quaternion)](M_Rage_Quaternion_op_Multiply.htm) | Multiplies a quaternion by another. |
| Public operatorStatic member | [Multiply(Quaternion, Single)](M_Rage_Quaternion_op_Multiply_1.htm) | Scales a quaternion by the given value. |
| Public operatorStatic member | [Subtraction](M_Rage_Quaternion_op_Subtraction.htm) | Subtracts two quaternions. |
| Public operatorStatic member | [UnaryNegation](M_Rage_Quaternion_op_UnaryNegation.htm) | Reverses the direction of a given quaternion. |

[Top](#mainBody)

Fields

|  | Name | Description |
| --- | --- | --- |
| Public field | [W](F_Rage_Quaternion_W.htm) | Gets or sets the W component of the quaternion. |
| Public field | [X](F_Rage_Quaternion_X.htm) | Gets or sets the X component of the quaternion. |
| Public field | [Y](F_Rage_Quaternion_Y.htm) | Gets or sets the Y component of the quaternion. |
| Public field | [Z](F_Rage_Quaternion_Z.htm) | Gets or sets the Z component of the quaternion. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.