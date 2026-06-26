# Model Structure

﻿Model Structure

|  |  |  |
| --- | --- | --- |
| Model Structure | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.Model"]

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
public struct Model : IHashedAsset
```

```
<SerializableAttribute>
Public Structure Model
	Implements IHashedAsset
```

```
[SerializableAttribute]
public value class Model : IHashedAsset
```

The Model type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [Model(String)](M_Rage_Model__ctor.htm) | Initializes a new instance of the Model class. |
| Public method | [Model(UInt32)](M_Rage_Model__ctor_1.htm) | Initializes a new instance of the Model class. |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [Dimensions](P_Rage_Model_Dimensions.htm) | Gets the dimensions of this model. |
| Public property | [EmergencyLighting](P_Rage_Model_EmergencyLighting.htm) | Gets the emergency lighting settings associated with this model. |
| Public property | [Hash](P_Rage_Model_Hash.htm) | Gets the hash of this asset. |
| Public property | [IsAmphibious](P_Rage_Model_IsAmphibious.htm) | Gets a value indicating whether this model represents an amphibious vehicle. |
| Public property | [IsAmphibiousCar](P_Rage_Model_IsAmphibiousCar.htm) | Gets a value indicating whether this model represents an amphibious car. |
| Public property | [IsAmphibiousQuadBike](P_Rage_Model_IsAmphibiousQuadBike.htm) | Gets a value indicating whether this model represents an amphibious quad bike. |
| Public property | [IsBicycle](P_Rage_Model_IsBicycle.htm) | Gets a value indicating whether this model represents a bicycle. |
| Public property | [IsBigVehicle](P_Rage_Model_IsBigVehicle.htm) | Gets a value indicating whether this model represents a big vehicle. |
| Public property | [IsBike](P_Rage_Model_IsBike.htm) | Gets a value indicating whether this model represents a bike. |
| Public property | [IsBlimp](P_Rage_Model_IsBlimp.htm) | Gets a value indicating whether this model represents a blimp. |
| Public property | [IsBoat](P_Rage_Model_IsBoat.htm) | Gets a value indicating whether this model represents a boat. |
| Public property | [IsBus](P_Rage_Model_IsBus.htm) | Gets a value indicating whether this model represents a bus. |
| Public property | [IsCar](P_Rage_Model_IsCar.htm) | Gets a value indicating whether this model represents a car. |
| Public property | [IsCollisionLoaded](P_Rage_Model_IsCollisionLoaded.htm) | Gets a value indicating whether this model's collision has been loaded into memory. |
| Public property | [IsElectricVehicle](P_Rage_Model_IsElectricVehicle.htm) | Gets a value indicating whether this model represents an electric vehicle. |
| Public property | [IsEmergencyVehicle](P_Rage_Model_IsEmergencyVehicle.htm) | Gets a value indicating whether this model represents an emergency vehicle. |
| Public property | [IsHelicopter](P_Rage_Model_IsHelicopter.htm) | Gets a value indicating whether this model represents a helicopter. |
| Public property | [IsInCdImage](P_Rage_Model_IsInCdImage.htm) |  |
| Public property | [IsJetski](P_Rage_Model_IsJetski.htm) | Gets a value indicating whether this model represents a jetski. |
| Public property | [IsLawEnforcementVehicle](P_Rage_Model_IsLawEnforcementVehicle.htm) | Gets a value indicating whether this model represents a law enforcement vehicle. |
| Public property | [IsLoaded](P_Rage_Model_IsLoaded.htm) |  |
| Public property | [IsObject](P_Rage_Model_IsObject.htm) | Gets a value indicating whether this model represents an object. |
| Public property | [IsOffroadVehicle](P_Rage_Model_IsOffroadVehicle.htm) | Gets a value indicating whether this model represents an offroad vehicle. |
| Public property | [IsPed](P_Rage_Model_IsPed.htm) | Gets a value indicating whether this model represents a ped. |
| Public property | [IsPlane](P_Rage_Model_IsPlane.htm) | Gets a value indicating whether this model represents a plane. |
| Public property | [IsQuadBike](P_Rage_Model_IsQuadBike.htm) | Gets a value indicating whether this model represents a quad bike. |
| Public property | [IsSubmarine](P_Rage_Model_IsSubmarine.htm) | Gets a value indicating whether this model represents a submarine. |
| Public property | [IsTrailer](P_Rage_Model_IsTrailer.htm) | Gets a value indicating whether this model represents a trailer. |
| Public property | [IsTrain](P_Rage_Model_IsTrain.htm) | Gets a value indicating whether this model represents a train. |
| Public property | [IsValid](P_Rage_Model_IsValid.htm) |  |
| Public property | [IsVan](P_Rage_Model_IsVan.htm) | Gets a value indicating whether this model represents a van. |
| Public property | [IsVehicle](P_Rage_Model_IsVehicle.htm) | Gets a value indicating whether this model represents a vehicle. |
| Public propertyStatic member | [Models](P_Rage_Model_Models.htm) |  |
| Public property | [Name](P_Rage_Model_Name.htm) | Gets the name of this model. |
| Public property | [NumberOfSeats](P_Rage_Model_NumberOfSeats.htm) | If this instance represents a vehicle, gets the number of seats. |
| Public propertyStatic member | [ObjectModels](P_Rage_Model_ObjectModels.htm) |  |
| Public propertyStatic member | [PedModels](P_Rage_Model_PedModels.htm) |  |
| Public propertyStatic member | [RandomVehicleModel](P_Rage_Model_RandomVehicleModel.htm) |  |
| Public propertyStatic member | [VehicleModels](P_Rage_Model_VehicleModels.htm) |  |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [Dismiss](M_Rage_Model_Dismiss.htm) |  |
| Public method | [GetDimensions](M_Rage_Model_GetDimensions.htm) | Gets the dimensions of this model.  The rear bottom left relative offset from the origin of the model.  The front top right relative offset from the origin of the model. |
| Public method | [Load](M_Rage_Model_Load.htm) |  |
| Public method | [LoadAndWait](M_Rage_Model_LoadAndWait.htm) |  |
| Public method | [LoadCollision](M_Rage_Model_LoadCollision.htm) | Starts loading this asset's collision into memory. |
| Public method | [LoadCollisionAndWait](M_Rage_Model_LoadCollisionAndWait.htm) | Starts loading this asset's collision into memory and waits for it to finish loading. |

[Top](#mainBody)

Operators

|  | Name | Description |
| --- | --- | --- |
| Public operatorStatic member | [(String to Model)](M_Rage_Model_op_Implicit_2.htm) |  |
| Public operatorStatic member | [(UInt32 to Model)](M_Rage_Model_op_Implicit_3.htm) |  |
| Public operatorStatic member | [(Model to UInt32)](M_Rage_Model_op_Implicit.htm) |  |
| Public operatorStatic member | [(Model to Object)](M_Rage_Model_op_Implicit_1.htm) |  |

[Top](#mainBody)

See Also

#### Reference

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.