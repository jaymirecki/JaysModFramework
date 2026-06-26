# Matrix Methods

﻿Matrix Methods

|  |  |  |
| --- | --- | --- |
| Matrix Methods | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The [Matrix](T_Rage_Matrix.htm) type exposes the following members.

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [Add(Matrix, Matrix)](M_Rage_Matrix_Add.htm) | Determines the sum of two matrices. |
| Public methodStatic member | [Add(Matrix, Matrix, Matrix)](M_Rage_Matrix_Add_1.htm) | Determines the sum of two matrices. |
| Public methodStatic member | [AffineTransformation(Single, Vector3, Quaternion, Vector3)](M_Rage_Matrix_AffineTransformation.htm) | Creates a 3D affine transformation matrix. |
| Public methodStatic member | [AffineTransformation(Single, Vector3, Quaternion, Vector3, Matrix)](M_Rage_Matrix_AffineTransformation_1.htm) | Creates a 3D affine transformation matrix. |
| Public methodStatic member | [AffineTransformation2D(Single, Vector2, Single, Vector2)](M_Rage_Matrix_AffineTransformation2D.htm) | Creates a 2D affine transformation matrix. |
| Public methodStatic member | [AffineTransformation2D(Single, Vector2, Single, Vector2, Matrix)](M_Rage_Matrix_AffineTransformation2D_1.htm) | Creates a 2D affine transformation matrix. |
| Public methodStatic member | [Billboard(Vector3, Vector3, Vector3, Vector3)](M_Rage_Matrix_Billboard.htm) | Creates a spherical billboard that rotates around a specified object position. |
| Public methodStatic member | [Billboard(Vector3, Vector3, Vector3, Vector3, Matrix)](M_Rage_Matrix_Billboard_1.htm) | Creates a spherical billboard that rotates around a specified object position. |
| Public method | [Decompose](M_Rage_Matrix_Decompose.htm) | Decomposes the matrix into its scalar, rotational, and translational elements. |
| Public method | [Determinant](M_Rage_Matrix_Determinant.htm) | Calculates the determinant of the matrix. |
| Public methodStatic member | [Divide(Matrix, Matrix)](M_Rage_Matrix_Divide.htm) | Determines the quotient of two matrices. |
| Public methodStatic member | [Divide(Matrix, Single)](M_Rage_Matrix_Divide_1.htm) | Scales a matrix by the given value. |
| Public methodStatic member | [Divide(Matrix, Matrix, Matrix)](M_Rage_Matrix_Divide_2.htm) | Determines the quotient of two matrices. |
| Public methodStatic member | [Divide(Matrix, Single, Matrix)](M_Rage_Matrix_Divide_3.htm) | Scales a matrix by the given value. |
| Public method | [Equals(Object)](M_Rage_Matrix_Equals_2.htm) | Returns a value that indicates whether the current instance is equal to a specified object. (Overrides [ValueTypeEquals(Object)](http://msdn2.microsoft.com/en-us/library/2dts52z7).) |
| Public method | [Equals(Matrix)](M_Rage_Matrix_Equals.htm) | Returns a value that indicates whether the current instance is equal to the specified object. |
| Public methodStatic member | [Equals(Matrix, Matrix)](M_Rage_Matrix_Equals_1.htm) | Determines whether the specified object instances are considered equal. |
| Public method | [GetHashCode](M_Rage_Matrix_GetHashCode.htm) | Returns the hash code for this instance. (Overrides [ValueTypeGetHashCode](http://msdn2.microsoft.com/en-us/library/y3509fc2).) |
| Public method | [Invert](M_Rage_Matrix_Invert.htm) | Inverts the matrix. |
| Public methodStatic member | [Invert(Matrix)](M_Rage_Matrix_Invert_1.htm) | Calculates the inverse of the specified matrix. |
| Public methodStatic member | [Invert(Matrix, Matrix)](M_Rage_Matrix_Invert_2.htm) | Calculates the inverse of the specified matrix. |
| Public methodStatic member | [Lerp(Matrix, Matrix, Single)](M_Rage_Matrix_Lerp.htm) | Performs a linear interpolation between two matricies. |
| Public methodStatic member | [Lerp(Matrix, Matrix, Single, Matrix)](M_Rage_Matrix_Lerp_1.htm) | Performs a linear interpolation between two matricies. |
| Public methodStatic member | [LookAtLH(Vector3, Vector3, Vector3)](M_Rage_Matrix_LookAtLH.htm) | Creates a left-handed, look-at matrix. |
| Public methodStatic member | [LookAtLH(Vector3, Vector3, Vector3, Matrix)](M_Rage_Matrix_LookAtLH_1.htm) | Creates a left-handed, look-at matrix. |
| Public methodStatic member | [LookAtRH(Vector3, Vector3, Vector3)](M_Rage_Matrix_LookAtRH.htm) | Creates a right-handed, look-at matrix. |
| Public methodStatic member | [LookAtRH(Vector3, Vector3, Vector3, Matrix)](M_Rage_Matrix_LookAtRH_1.htm) | Creates a right-handed, look-at matrix. |
| Public methodStatic member | [Multiply(Matrix, Matrix)](M_Rage_Matrix_Multiply_1.htm) | Determines the product of two matrices. |
| Public methodStatic member | [Multiply(Matrix, Single)](M_Rage_Matrix_Multiply_2.htm) | Scales a matrix by the given value. |
| Public methodStatic member | [Multiply(Matrix, Matrix, Matrix)](M_Rage_Matrix_Multiply_3.htm) | Determines the product of two matrices. |
| Public methodStatic member | [Multiply(Matrix, Single, Matrix)](M_Rage_Matrix_Multiply_4.htm) | Scales a matrix by the given value. |
| Public methodStatic member | [Multiply(Matrix, Matrix, Matrix)](M_Rage_Matrix_Multiply_5.htm) | Determines the products of of an array of matrices by a single matrix. |
| Public methodStatic member | [Multiply(Matrix, Matrix, Matrix)](M_Rage_Matrix_Multiply_7.htm) | Determines the products of two arrays of matrices. |
| Public methodStatic member | [Multiply(Matrix\*, Matrix\*, Matrix\*, Int32)](M_Rage_Matrix_Multiply.htm) | Determines the products of two arrays of matrices. |
| Public methodStatic member | [Multiply(Matrix, Matrix, Matrix, Int32, Int32)](M_Rage_Matrix_Multiply_6.htm) | Determines the products of of an array of matrices by a single matrix. |
| Public methodStatic member | [Multiply(Matrix, Matrix, Matrix, Int32, Int32)](M_Rage_Matrix_Multiply_8.htm) | Determines the products of two arrays of matrices. |
| Public methodStatic member | [Negate(Matrix)](M_Rage_Matrix_Negate.htm) | Negates a matrix. |
| Public methodStatic member | [Negate(Matrix, Matrix)](M_Rage_Matrix_Negate_1.htm) | Negates a matrix. |
| Public methodStatic member | [OrthoLH(Single, Single, Single, Single)](M_Rage_Matrix_OrthoLH.htm) | Creates a left-handed, orthographic projection matrix. |
| Public methodStatic member | [OrthoLH(Single, Single, Single, Single, Matrix)](M_Rage_Matrix_OrthoLH_1.htm) | Creates a left-handed, orthographic projection matrix. |
| Public methodStatic member | [OrthoOffCenterLH(Single, Single, Single, Single, Single, Single)](M_Rage_Matrix_OrthoOffCenterLH.htm) | Creates a left-handed, customized orthographic projection matrix. |
| Public methodStatic member | [OrthoOffCenterLH(Single, Single, Single, Single, Single, Single, Matrix)](M_Rage_Matrix_OrthoOffCenterLH_1.htm) | Creates a left-handed, customized orthographic projection matrix. |
| Public methodStatic member | [OrthoOffCenterRH(Single, Single, Single, Single, Single, Single)](M_Rage_Matrix_OrthoOffCenterRH.htm) | Creates a right-handed, customized orthographic projection matrix. |
| Public methodStatic member | [OrthoOffCenterRH(Single, Single, Single, Single, Single, Single, Matrix)](M_Rage_Matrix_OrthoOffCenterRH_1.htm) | Creates a right-handed, customized orthographic projection matrix. |
| Public methodStatic member | [OrthoRH(Single, Single, Single, Single)](M_Rage_Matrix_OrthoRH.htm) | Creates a right-handed, orthographic projection matrix. |
| Public methodStatic member | [OrthoRH(Single, Single, Single, Single, Matrix)](M_Rage_Matrix_OrthoRH_1.htm) | Creates a right-handed, orthographic projection matrix. |
| Public methodStatic member | [PerspectiveFovLH(Single, Single, Single, Single)](M_Rage_Matrix_PerspectiveFovLH.htm) | Creates a left-handed, perspective projection matrix based on a field of view. |
| Public methodStatic member | [PerspectiveFovLH(Single, Single, Single, Single, Matrix)](M_Rage_Matrix_PerspectiveFovLH_1.htm) | Creates a left-handed, perspective projection matrix based on a field of view. |
| Public methodStatic member | [PerspectiveFovRH(Single, Single, Single, Single)](M_Rage_Matrix_PerspectiveFovRH.htm) | Creates a right-handed, perspective projection matrix based on a field of view. |
| Public methodStatic member | [PerspectiveFovRH(Single, Single, Single, Single, Matrix)](M_Rage_Matrix_PerspectiveFovRH_1.htm) | Creates a right-handed, perspective projection matrix based on a field of view. |
| Public methodStatic member | [PerspectiveLH(Single, Single, Single, Single)](M_Rage_Matrix_PerspectiveLH.htm) | Creates a left-handed, perspective projection matrix. |
| Public methodStatic member | [PerspectiveLH(Single, Single, Single, Single, Matrix)](M_Rage_Matrix_PerspectiveLH_1.htm) | Creates a left-handed, perspective projection matrix. |
| Public methodStatic member | [PerspectiveOffCenterLH(Single, Single, Single, Single, Single, Single)](M_Rage_Matrix_PerspectiveOffCenterLH.htm) | Creates a left-handed, customized perspective projection matrix. |
| Public methodStatic member | [PerspectiveOffCenterLH(Single, Single, Single, Single, Single, Single, Matrix)](M_Rage_Matrix_PerspectiveOffCenterLH_1.htm) | Creates a left-handed, customized perspective projection matrix. |
| Public methodStatic member | [PerspectiveOffCenterRH(Single, Single, Single, Single, Single, Single)](M_Rage_Matrix_PerspectiveOffCenterRH.htm) | Creates a right-handed, customized perspective projection matrix. |
| Public methodStatic member | [PerspectiveOffCenterRH(Single, Single, Single, Single, Single, Single, Matrix)](M_Rage_Matrix_PerspectiveOffCenterRH_1.htm) | Creates a right-handed, customized perspective projection matrix. |
| Public methodStatic member | [PerspectiveRH(Single, Single, Single, Single)](M_Rage_Matrix_PerspectiveRH.htm) | Creates a right-handed, perspective projection matrix. |
| Public methodStatic member | [PerspectiveRH(Single, Single, Single, Single, Matrix)](M_Rage_Matrix_PerspectiveRH_1.htm) | Creates a right-handed, perspective projection matrix. |
| Public methodStatic member | [RotationAxis(Vector3, Single)](M_Rage_Matrix_RotationAxis.htm) | Creates a matrix that rotates around an arbitary axis. |
| Public methodStatic member | [RotationAxis(Vector3, Single, Matrix)](M_Rage_Matrix_RotationAxis_1.htm) | Creates a matrix that rotates around an arbitary axis. |
| Public methodStatic member | [RotationQuaternion(Quaternion)](M_Rage_Matrix_RotationQuaternion.htm) | Creates a rotation matrix from a quaternion. |
| Public methodStatic member | [RotationQuaternion(Quaternion, Matrix)](M_Rage_Matrix_RotationQuaternion_1.htm) | Creates a rotation matrix from a quaternion. |
| Public methodStatic member | [RotationX(Single)](M_Rage_Matrix_RotationX.htm) | Creates a matrix that rotates around the x-axis. |
| Public methodStatic member | [RotationX(Single, Matrix)](M_Rage_Matrix_RotationX_1.htm) | Creates a matrix that rotates around the x-axis. |
| Public methodStatic member | [RotationY(Single)](M_Rage_Matrix_RotationY.htm) | Creates a matrix that rotates around the y-axis. |
| Public methodStatic member | [RotationY(Single, Matrix)](M_Rage_Matrix_RotationY_1.htm) | Creates a matrix that rotates around the y-axis. |
| Public methodStatic member | [RotationYawPitchRoll(Single, Single, Single)](M_Rage_Matrix_RotationYawPitchRoll.htm) | Creates a rotation matrix with a specified yaw, pitch, and roll. |
| Public methodStatic member | [RotationYawPitchRoll(Single, Single, Single, Matrix)](M_Rage_Matrix_RotationYawPitchRoll_1.htm) | Creates a rotation matrix with a specified yaw, pitch, and roll. |
| Public methodStatic member | [RotationZ(Single)](M_Rage_Matrix_RotationZ.htm) | Creates a matrix that rotates around the z-axis. |
| Public methodStatic member | [RotationZ(Single, Matrix)](M_Rage_Matrix_RotationZ_1.htm) | Creates a matrix that rotates around the z-axis. |
| Public methodStatic member | [Scaling(Vector3)](M_Rage_Matrix_Scaling.htm) | Creates a matrix that scales along the x-axis, y-axis, and y-axis. |
| Public methodStatic member | [Scaling(Vector3, Matrix)](M_Rage_Matrix_Scaling_1.htm) | Creates a matrix that scales along the x-axis, y-axis, and y-axis. |
| Public methodStatic member | [Scaling(Single, Single, Single)](M_Rage_Matrix_Scaling_2.htm) | Creates a matrix that scales along the x-axis, y-axis, and y-axis. |
| Public methodStatic member | [Scaling(Single, Single, Single, Matrix)](M_Rage_Matrix_Scaling_3.htm) | Creates a matrix that scales along the x-axis, y-axis, and y-axis. |
| Public methodStatic member | [Subtract(Matrix, Matrix)](M_Rage_Matrix_Subtract.htm) | Determines the difference between two matrices. |
| Public methodStatic member | [Subtract(Matrix, Matrix, Matrix)](M_Rage_Matrix_Subtract_1.htm) | Determines the difference between two matrices. |
| Public method | [ToArray](M_Rage_Matrix_ToArray.htm) |  |
| Public method | [ToString](M_Rage_Matrix_ToString.htm) | Converts the value of the object to its equivalent string representation. (Overrides [ValueTypeToString](http://msdn2.microsoft.com/en-us/library/wb77sz3h).) |
| Public methodStatic member | [Transformation(Vector3, Quaternion, Vector3, Vector3, Quaternion, Vector3)](M_Rage_Matrix_Transformation.htm) | Creates a transformation matrix. |
| Public methodStatic member | [Transformation(Vector3, Quaternion, Vector3, Vector3, Quaternion, Vector3, Matrix)](M_Rage_Matrix_Transformation_1.htm) | Creates a transformation matrix. |
| Public methodStatic member | [Transformation2D(Vector2, Single, Vector2, Vector2, Single, Vector2)](M_Rage_Matrix_Transformation2D.htm) | Creates a 2D transformation matrix. |
| Public methodStatic member | [Transformation2D(Vector2, Single, Vector2, Vector2, Single, Vector2, Matrix)](M_Rage_Matrix_Transformation2D_1.htm) | Creates a 2D transformation matrix. |
| Public methodStatic member | [Translation(Vector3)](M_Rage_Matrix_Translation.htm) | Creates a translation matrix using the specified offsets. |
| Public methodStatic member | [Translation(Vector3, Matrix)](M_Rage_Matrix_Translation_1.htm) | Creates a translation matrix using the specified offsets. |
| Public methodStatic member | [Translation(Single, Single, Single)](M_Rage_Matrix_Translation_2.htm) | Creates a translation matrix using the specified offsets. |
| Public methodStatic member | [Translation(Single, Single, Single, Matrix)](M_Rage_Matrix_Translation_3.htm) | Creates a translation matrix using the specified offsets. |
| Public methodStatic member | [Transpose(Matrix)](M_Rage_Matrix_Transpose.htm) | Calculates the transpose of the specified matrix. |
| Public methodStatic member | [Transpose(Matrix, Matrix)](M_Rage_Matrix_Transpose_1.htm) | Calculates the transpose of the specified matrix. |

[Top](#mainBody)

See Also

#### Reference

[Matrix Structure](T_Rage_Matrix.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.