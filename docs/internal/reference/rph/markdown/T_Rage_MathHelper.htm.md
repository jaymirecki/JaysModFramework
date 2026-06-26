# MathHelper Class

﻿MathHelper Class

|  |  |  |
| --- | --- | --- |
| MathHelper Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Static class with various functions for common conversions.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  RageMathHelper  
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
public static class MathHelper
```

```
Public NotInheritable Class MathHelper
```

```
public ref class MathHelper abstract sealed
```

The MathHelper type exposes the following members.

Properties

|  | Name | Description |
| --- | --- | --- |
| Public propertyStatic member | [RandomizationSeed](P_Rage_MathHelper_RandomizationSeed.htm) |  |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public methodStatic member | [AreDigitsIdentical](M_Rage_MathHelper_AreDigitsIdentical.htm) | Gets whether all digits in the specified number are identical. |
| Public methodStatic member | [AverageT](M_Rage_MathHelper_Average__1.htm) |  |
| Public methodStatic member | [ChooseT(ICollectionT)](M_Rage_MathHelper_Choose__1.htm) | Gets a random object from the specified collection. |
| Public methodStatic member | [ChooseT(T)](M_Rage_MathHelper_Choose__1_1.htm) | Gets a random object from the specified array. |
| Public methodStatic member | [ClampT](M_Rage_MathHelper_Clamp__1.htm) | Gets the specified value between the specified minimum and maximum values. |
| Public methodStatic member | [ConvertDegreesToRadians](M_Rage_MathHelper_ConvertDegreesToRadians.htm) | Converts the specified angle in degrees to its equivalent in radians. |
| Public methodStatic member | [ConvertDirectionToHeading](M_Rage_MathHelper_ConvertDirectionToHeading.htm) | Converts the specified direction to a heading. |
| Public methodStatic member | [ConvertHeadingToDirection](M_Rage_MathHelper_ConvertHeadingToDirection.htm) | Converts the specified heading to its equivalent direction. |
| Public methodStatic memberCode example | [ConvertKilometersPerHourToMetersPerSecond](M_Rage_MathHelper_ConvertKilometersPerHourToMetersPerSecond.htm) | Converts the specified value from kilometers per hour to meters per second. |
| Public methodStatic memberCode example | [ConvertKilometersPerHourToMilesPerHour](M_Rage_MathHelper_ConvertKilometersPerHourToMilesPerHour.htm) | Converts the specified value from kilometers per hour to miles per hour. |
| Public methodStatic memberCode example | [ConvertMetersPerSecondToKilometersPerHour](M_Rage_MathHelper_ConvertMetersPerSecondToKilometersPerHour.htm) | Converts the specified value from meters per second to kilometers per hour. |
| Public methodStatic memberCode example | [ConvertMetersPerSecondToKilometersPerHourRounded](M_Rage_MathHelper_ConvertMetersPerSecondToKilometersPerHourRounded.htm) | Converts the specified value from meters per second to kilometers per hour and rounds the result. |
| Public methodStatic member | [ConvertMetersPerSecondToMilesPerHour](M_Rage_MathHelper_ConvertMetersPerSecondToMilesPerHour.htm) | Converts the specified value from meters per second to miles per hour. |
| Public methodStatic memberCode example | [ConvertMilesPerHourToKilometersPerHour](M_Rage_MathHelper_ConvertMilesPerHourToKilometersPerHour.htm) | Converts the specified value from miles per hour to kilometers per hour. |
| Public methodStatic member | [ConvertMilesPerHourToMetersPerSecond](M_Rage_MathHelper_ConvertMilesPerHourToMetersPerSecond.htm) | Converts the specified value from miles per hour to meters per second. |
| Public methodStatic member | [ConvertRadiansToDegrees(Double)](M_Rage_MathHelper_ConvertRadiansToDegrees.htm) | Converts the specified angle in radians to its equivalent in degrees. |
| Public methodStatic member | [ConvertRadiansToDegrees(Single)](M_Rage_MathHelper_ConvertRadiansToDegrees_1.htm) | Converts the specified angle in radians to its equivalent in degrees. |
| Public methodStatic member | [Faculty](M_Rage_MathHelper_Faculty.htm) | Gets the faculty of the specified number. |
| Public methodStatic member | [GetChance(Int32)](M_Rage_MathHelper_GetChance.htm) | Gets a chance. |
| Public methodStatic member | [GetChance(Int32, Int32)](M_Rage_MathHelper_GetChance_1.htm) | Gets a chance. |
| Public methodStatic member | [GetNumberLength](M_Rage_MathHelper_GetNumberLength.htm) | Gets the length of the specified number. |
| Public methodStatic member | [GetOffsetPosition](M_Rage_MathHelper_GetOffsetPosition.htm) |  |
| Public methodStatic member | [GetRandomAlphaNumericCharacter](M_Rage_MathHelper_GetRandomAlphaNumericCharacter.htm) | Gets a random alpha numeric character. |
| Public methodStatic member | [GetRandomDouble](M_Rage_MathHelper_GetRandomDouble.htm) | Gets a random double precision floating point number between the specified minimum and maximum value, inclusive. |
| Public methodStatic member | [GetRandomInteger(Int32)](M_Rage_MathHelper_GetRandomInteger.htm) | Gets a random integer between 0, inclusive, and the specified maximum value, exclusive. |
| Public methodStatic member | [GetRandomInteger(Int32, Int32)](M_Rage_MathHelper_GetRandomInteger_1.htm) | Gets a random integer between the specified minimum and maximum value, inclusive. |
| Public methodStatic member | [GetRandomSingle](M_Rage_MathHelper_GetRandomSingle.htm) | Gets a random single precision floating point number between the specified minimum and maximum value, inclusive. |
| Public methodStatic member | [InterpolateLinearlyTo(Single, Single, Single, Single)](M_Rage_MathHelper_InterpolateLinearlyTo_3.htm) |  |
| Public methodStatic member | [InterpolateLinearlyTo(Rotator, Rotator, Single, Single)](M_Rage_MathHelper_InterpolateLinearlyTo.htm) |  |
| Public methodStatic member | [InterpolateLinearlyTo(Vector2, Vector2, Single, Single)](M_Rage_MathHelper_InterpolateLinearlyTo_1.htm) |  |
| Public methodStatic member | [InterpolateLinearlyTo(Vector3, Vector3, Single, Single)](M_Rage_MathHelper_InterpolateLinearlyTo_2.htm) |  |
| Public methodStatic member | [InterpolateTo(Single, Single, Single, Single)](M_Rage_MathHelper_InterpolateTo_3.htm) |  |
| Public methodStatic member | [InterpolateTo(Rotator, Rotator, Single, Single)](M_Rage_MathHelper_InterpolateTo.htm) |  |
| Public methodStatic member | [InterpolateTo(Vector2, Vector2, Single, Single)](M_Rage_MathHelper_InterpolateTo_1.htm) |  |
| Public methodStatic member | [InterpolateTo(Vector3, Vector3, Single, Single)](M_Rage_MathHelper_InterpolateTo_2.htm) |  |
| Public methodStatic member | [IsPowerOfTwo](M_Rage_MathHelper_IsPowerOfTwo.htm) | Determines whether the specified number is a power of two. |
| Public methodStatic member | [IsZeroOrPowerOfTwo](M_Rage_MathHelper_IsZeroOrPowerOfTwo.htm) | Determines whether the specified number is zero or a power of two. |
| Public methodStatic member | [Lerp(Double, Double, Single)](M_Rage_MathHelper_Lerp.htm) | Gets a new value between the specified start and end values, designated by the percentage. |
| Public methodStatic member | [Lerp(Int32, Int32, Single)](M_Rage_MathHelper_Lerp_1.htm) | Gets a new value between the specified start and end values, designated by the percentage. |
| Public methodStatic member | [Lerp(Int64, Int64, Single)](M_Rage_MathHelper_Lerp_2.htm) | Gets a new value between the specified start and end values, designated by the percentage. |
| Public methodStatic member | [Lerp(Single, Single, Single)](M_Rage_MathHelper_Lerp_3.htm) | Gets a new value between the specified start and end values, designated by the percentage. |
| Public methodStatic member | [MaxT](M_Rage_MathHelper_Max__1.htm) |  |
| Public methodStatic member | [MedianT](M_Rage_MathHelper_Median__1.htm) | Gets the median from the specified values. |
| Public methodStatic member | [MinT](M_Rage_MathHelper_Min__1.htm) |  |
| Public methodStatic member | [Normalize](M_Rage_MathHelper_Normalize.htm) | Normalizes the specified value. |
| Public methodStatic member | [NormalizeHeading](M_Rage_MathHelper_NormalizeHeading.htm) | Normalizes the specified heading. |
| Public methodStatic member | [RotateHeading](M_Rage_MathHelper_RotateHeading.htm) | Rotates the specified heading the specified number of degrees, and returns the normalized result. |
| Public methodStatic member | [RoundToLowerTenth(Int32)](M_Rage_MathHelper_RoundToLowerTenth.htm) | Rounds the specified integer to the nearest lower tenth. |
| Public methodStatic member | [RoundToLowerTenth(Single)](M_Rage_MathHelper_RoundToLowerTenth_1.htm) | Rounds the specified float to the nearest lower tenth integer. |
| Public methodStatic member | [Square(Double)](M_Rage_MathHelper_Square.htm) | Gets the specified value multiplied by itself. |
| Public methodStatic member | [Square(Int32)](M_Rage_MathHelper_Square_1.htm) | Gets the specified value multiplied by itself. |
| Public methodStatic member | [Square(Int64)](M_Rage_MathHelper_Square_2.htm) | Gets the specified value multiplied by itself. |
| Public methodStatic member | [Square(Single)](M_Rage_MathHelper_Square_3.htm) | Gets the specified value multiplied by itself. |
| Public methodStatic member | [UnLerp(Double, Double, Double)](M_Rage_MathHelper_UnLerp.htm) | Gets the original percentage provided to Lerp, given the start, end and lerped value. |
| Public methodStatic member | [UnLerp(Int32, Int32, Int32)](M_Rage_MathHelper_UnLerp_1.htm) | Gets the original percentage provided to Lerp, given the start, end and lerped value. |
| Public methodStatic member | [UnLerp(Int64, Int64, Int64)](M_Rage_MathHelper_UnLerp_2.htm) | Gets the original percentage provided to Lerp, given the start, end and lerped value. |
| Public methodStatic member | [UnLerp(Single, Single, Single)](M_Rage_MathHelper_UnLerp_3.htm) | Gets the original percentage provided to Lerp, given the start, end and lerped value. |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.