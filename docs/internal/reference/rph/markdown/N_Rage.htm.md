# Rage Namespace

﻿Rage Namespace

|  |  |  |
| --- | --- | --- |
| Rage Namespace | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The base namespace for the API provided by RAGE Plugin Hook.

Classes

|  | Class | Description |
| --- | --- | --- |
| Public class | [AdvancedPoolEnumeratorHT](T_Rage_AdvancedPoolEnumerator_1.htm) |  |
| Public class | [AnimationTask](T_Rage_AnimationTask.htm) | Represents an animation task. This class cannot be inherited. |
| Public class | [Blip](T_Rage_Blip.htm) | Represents a [Blip](T_Rage_Blip.htm) in the game world.  Blips are used to mark entities of interest in either the game world, on the radar or both. |
| Public class | [Building](T_Rage_Building.htm) | Represents a building in the game world. |
| Public class | [Camera](T_Rage_Camera.htm) |  |
| Public classCode example | [CleanupManager](T_Rage_CleanupManager.htm) | Class for cleaning up [IDeletable](T_Rage_IDeletable.htm)s.  Examples  ---   The following example spawns a car, and deletes it 3 seconds after it's been destroyed. The CleanupManager removes the [IDeletable](T_Rage_IDeletable.htm)s that's been added to it, when it gets disposed. C#  [Copy](# "Copy")  ``` using(CleanupManager cleanupManager = new CleanupManager()) {     Vector3 spawnPosition = playerVehicle.GetOffsetPosition(new Vector3(-3f, 7f, 0f));     Vehicle car = new Vehicle("POLICE2", spawnPosition, playerVehicle.Heading);     cleanupManager.Add(car);     while (!car.IsDead)     {         GameFiber.Yield();     }      GameFiber.Sleep(3000); } ``` |
| Public class | [ConsoleCommandExecutedEventArgs](T_Rage_ConsoleCommandExecutedEventArgs.htm) | Provides data for the [!:ConsoleCommand::Executed] event |
| Public class | [CryptographyHelper](T_Rage_CryptographyHelper.htm) | A helper class for cryptography. |
| Public class | [Debug](T_Rage_Debug.htm) | A collection of methods for debugging. |
| Public class | [EmergencyLight](T_Rage_EmergencyLight.htm) |  |
| Public class | [EmergencyLighting](T_Rage_EmergencyLighting.htm) | Specifies settings for emergency lighting on vehicles. This class cannot be inherited. |
| Public class | [Entity](T_Rage_Entity.htm) | Represents an entity in the game world. |
| Public class | [Fire](T_Rage_Fire.htm) | Represents a fire. |
| Public class | [Game](T_Rage_Game.htm) | Static class for various game settings and functions. |
| Public class | [GameConsole](T_Rage_GameConsole.htm) | Provides access to the console of the hook. |
| Public class | [GameFiber](T_Rage_GameFiber.htm) | Represents a multi-tasking fiber. Natives can only be invoked from a fiber. Not meant to be inherited. |
| Public class | [Graphics](T_Rage_Graphics.htm) |  |
| Public class | [GraphicsEventArgs](T_Rage_GraphicsEventArgs.htm) | Provides data for the [FrameRender](E_Rage_Game_FrameRender.htm) event. |
| Public class | [Group](T_Rage_Group.htm) | Represents a group of [Ped](T_Rage_Ped.htm).    There can be up to 16 groups at any given time.  Empty groups are automatically deleted. |
| Public class | [GroupFormation](T_Rage_GroupFormation.htm) | Gets the formation info about this group. |
| Public class | [HandlingData](T_Rage_HandlingData.htm) |  |
| Public class | [InitializationFile](T_Rage_InitializationFile.htm) |  |
| Public class | [InteriorHelper](T_Rage_InteriorHelper.htm) |  |
| Public class | [InternetTime](T_Rage_InternetTime.htm) | Class for getting the current time from the Internet.  This class uses the TIME protocol to get the current time from nist1-macon.macon.ga.us. |
| Public class | [KeyboardLayoutCustom](T_Rage_KeyboardLayoutCustom.htm) |  |
| Public class | [KeyboardLayoutKeyDefinition](T_Rage_KeyboardLayoutKeyDefinition.htm) |  |
| Public class | [KeyboardState](T_Rage_KeyboardState.htm) |  |
| Public class | [KeyEventArgs](T_Rage_KeyEventArgs.htm) |  |
| Public class | [MathHelper](T_Rage_MathHelper.htm) | Static class with various functions for common conversions. |
| Public class | [MetadataObject](T_Rage_MetadataObject.htm) |  |
| Public class | [MouseState](T_Rage_MouseState.htm) |  |
| Public class | [Object](T_Rage_Object.htm) | Represents an object in the game world. |
| Public class | [ObjectPoolEnumerator](T_Rage_ObjectPoolEnumerator.htm) |  |
| Public class | [OnscreenPromptButtonClickedEventArgs](T_Rage_OnscreenPromptButtonClickedEventArgs.htm) |  |
| Public class | [OperatingSystemInfo](T_Rage_OperatingSystemInfo.htm) |  |
| Public class | [Ped](T_Rage_Ped.htm) | Represents a character in the game world. |
| Public class | [PedInventory](T_Rage_PedInventory.htm) |  |
| Public class | [PedPoolEnumerator](T_Rage_PedPoolEnumerator.htm) |  |
| Public class | [PedRunOverEventArgs](T_Rage_PedRunOverEventArgs.htm) | Provides data for events of peds getting run over. |
| Public class | [PedShotEventArgs](T_Rage_PedShotEventArgs.htm) | Provides data for events of peds getting shot. |
| Public class | [Player](T_Rage_Player.htm) | Represents a player. |
| Public class | [PoolEnumeratorHT](T_Rage_PoolEnumerator_1.htm) |  |
| Public class | [SimplePoolEnumeratorHT](T_Rage_SimplePoolEnumerator_1.htm) |  |
| Public class | [SpatialEventArgs](T_Rage_SpatialEventArgs.htm) | Provides data for spatial events. |
| Public class | [StaticFinalizer](T_Rage_StaticFinalizer.htm) |  |
| Public class | [Task](T_Rage_Task.htm) | Represents a task. This class cannot be inherited. |
| Public class | [TaskInvoker](T_Rage_TaskInvoker.htm) |  |
| Public class | [TaskSequence](T_Rage_TaskSequence.htm) | This class allows executing multiple tasks on a [Ped](T_Rage_Ped.htm) in sequence. |
| Public class | [Texture](T_Rage_Texture.htm) |  |
| Public class | [Vehicle](T_Rage_Vehicle.htm) | Represents a vehicle in the game world. |
| Public class | [VehicleDoor](T_Rage_VehicleDoor.htm) |  |
| Public class | [VehicleModder](T_Rage_VehicleModder.htm) |  |
| Public class | [VehiclePoolEnumerator](T_Rage_VehiclePoolEnumerator.htm) |  |
| Public class | [VehicleWheel](T_Rage_VehicleWheel.htm) |  |
| Public class | [VehicleWindow](T_Rage_VehicleWindow.htm) |  |
| Public class | [Weapon](T_Rage_Weapon.htm) |  |
| Public class | [WeaponDescriptor](T_Rage_WeaponDescriptor.htm) |  |
| Public class | [WeaponDescriptorCollection](T_Rage_WeaponDescriptorCollection.htm) |  |
| Public class | [World](T_Rage_World.htm) | Static class for various game world settings and functions. |

Structures

|  | Structure | Description |
| --- | --- | --- |
| Public structure | [AnimationDictionary](T_Rage_AnimationDictionary.htm) | Represents an animation dictionary. |
| Public structure | [AnimationSet](T_Rage_AnimationSet.htm) |  |
| Public structure | [DecisionMaker](T_Rage_DecisionMaker.htm) |  |
| Public structure | [HitResult](T_Rage_HitResult.htm) | Struct representing the result of a ray trace. |
| Public structure | [Matrix](T_Rage_Matrix.htm) | Defines a 4x4 matrix. |
| Public structure | [Model](T_Rage_Model.htm) |  |
| Public structure | [PoolHandle](T_Rage_PoolHandle.htm) | Represents the handle of an item in a pool.  The RAGE engine has a special array type known as a pool.  Pools are widely used throughout RAGE games to store things like [Ped](T_Rage_Ped.htm)s, [Vehicle](T_Rage_Vehicle.htm)s, [Weapon](T_Rage_Weapon.htm)s, [Blip](T_Rage_Blip.htm)s, etc.  Pools consist of slots, and each slot has an index ranging from 0 to the pools capacity.  Essentially each slot has a flag that indicates whether the slot is free, and a counter. The counter is purely to avoid duplicate handles in case that same slot is reused immediately after it's freed.  The handle is a composite number (32-bit unsigned integer) where the 24 most significant bits represent the item's index into the pool, and the last 8 bits represent the counter.  Eg. if an item is stored at index 4 and its counter is 7, the handle would be (4 << 8) | 7 = 1031 (0x00000407).  A handle is validated by comparing its counter to the counter in the slot indicated by the index in the handle. If the slot is occupied and the counters match, the handle is valid. These handles are used extensively in the engine's internal scripting system. If a native function takes an entity as parameter, it is by its handle. |
| Public structure | [Quaternion](T_Rage_Quaternion.htm) | Defines a four dimensional mathematical quaternion. |
| Public structure | [RelationshipGroup](T_Rage_RelationshipGroup.htm) | Represents a relationship group. |
| Public structure | [Rotator](T_Rage_Rotator.htm) | Represents a rotation. |
| Public structure | [Vector2](T_Rage_Vector2.htm) | Defines a two component vector. |
| Public structure | [Vector3](T_Rage_Vector3.htm) | Defines a three component vector. |
| Public structure | [Vector4](T_Rage_Vector4.htm) | Defines a four component vector. |
| Public structure | [VehicleDoorPropertyWrapper](T_Rage_VehicleDoorPropertyWrapper.htm) |  |
| Public structure | [VehicleWheelPropertyWrapper](T_Rage_VehicleWheelPropertyWrapper.htm) |  |
| Public structure | [VehicleWindowPropertyWrapper](T_Rage_VehicleWindowPropertyWrapper.htm) |  |
| Public structure | [WeaponAsset](T_Rage_WeaponAsset.htm) |  |

Interfaces

|  | Interface | Description |
| --- | --- | --- |
| Public interface | [IAddressable](T_Rage_IAddressable.htm) | Represents an object that has an address. |
| Public interface | [IAsset](T_Rage_IAsset.htm) | Represents a game asset. Game assets are blueprints that describe an object. For example, a weapon asset specifies what model a weapon will use, how fast it shoots, how many bullets it has, etc. |
| Public interface | [IBurnable](T_Rage_IBurnable.htm) | Represents an object that can burn. |
| Public interface | [IDeletable](T_Rage_IDeletable.htm) | Represents an object that can be deleted. |
| Public interface | [IDirectional](T_Rage_IDirectional.htm) | Represents an object that has a direction. |
| Public interface | [IFreezable](T_Rage_IFreezable.htm) | Represents an object that can be frozen. Frozen objects will not be processed by the physics engine. |
| Public interface | [IHandleable](T_Rage_IHandleable.htm) | Represents an object in a pool. |
| Public interface | [IHashedAsset](T_Rage_IHashedAsset.htm) | Represents a game asset. Game assets are blueprints that describe an object. For example, a weapon asset specifies what model a weapon will use, how fast it shoots, how many bullets it has, etc. |
| Public interface | [IKeyboardLayout](T_Rage_IKeyboardLayout.htm) |  |
| Public interface | [INamedAsset](T_Rage_INamedAsset.htm) | Represents a game asset. Game assets are blueprints that describe an object. For example, a weapon asset specifies what model a weapon will use, how fast it shoots, how many bullets it has, etc. |
| Public interface | [IPersistable](T_Rage_IPersistable.htm) | Represents an object that can become persistent within the game world. Persistent objects will not be removed automatically during clean ups. |
| Public interface | [IRenderable](T_Rage_IRenderable.htm) | Represents an object that can be rendered in the game world. |
| Public interface | [IRotatable](T_Rage_IRotatable.htm) | Represents an object that can be rotated. |
| Public interface | [ISpatial](T_Rage_ISpatial.htm) | Represents an object that has a position. |
| Public interface | [IVisual](T_Rage_IVisual.htm) | Represents an object that can be hidden in the game world. |

Enumerations

|  | Enumeration | Description |
| --- | --- | --- |
| Public enumeration | [Achievement](T_Rage_Achievement.htm) | Represents the game's achievements. |
| Public enumeration | [AnimationFlags](T_Rage_AnimationFlags.htm) |  |
| Public enumeration | [Axis](T_Rage_Axis.htm) | Specifies an axis. |
| Public enumeration | [BlipSprite](T_Rage_BlipSprite.htm) |  |
| Public enumeration | [CameraState](T_Rage_CameraState.htm) |  |
| Public enumeration | [ControllerButtons](T_Rage_ControllerButtons.htm) |  |
| Public enumeration | [EnterVehicleFlags](T_Rage_EnterVehicleFlags.htm) | Flags for the [!:TaskInvoker::EnterVehicle] task. |
| Public enumeration | [ExitCoverTaskFlags](T_Rage_ExitCoverTaskFlags.htm) | Flags for the [!:TaskInvoker::ExitCover] task. |
| Public enumeration | [FiringPattern](T_Rage_FiringPattern.htm) |  |
| Public enumeration | [GameControl](T_Rage_GameControl.htm) |  |
| Public enumeration | [GetEntitiesFlags](T_Rage_GetEntitiesFlags.htm) |  |
| Public enumeration | [GraphicsDrawCall](T_Rage_GraphicsDrawCall.htm) |  |
| Public enumeration | [GroupFormationType](T_Rage_GroupFormationType.htm) | Represents the various group formation types. |
| Public enumeration | [HelmetTypes](T_Rage_HelmetTypes.htm) | The various helmet types. |
| Public enumeration | [LeaveVehicleFlags](T_Rage_LeaveVehicleFlags.htm) | Flags for the [!:Rage::TaskInvoker::LeaveVehicle] task. |
| Public enumeration | [LicensePlateStyle](T_Rage_LicensePlateStyle.htm) |  |
| Public enumeration | [LicensePlateType](T_Rage_LicensePlateType.htm) |  |
| Public enumeration | [ParachuteLandingType](T_Rage_ParachuteLandingType.htm) | Represents the various landing types. |
| Public enumeration | [ParachuteState](T_Rage_ParachuteState.htm) | Represents the various parachute states. |
| Public enumeration | [PedBoneId](T_Rage_PedBoneId.htm) |  |
| Public enumeration | [RadioStation](T_Rage_RadioStation.htm) |  |
| Public enumeration | [RageGameType](T_Rage_RageGameType.htm) |  |
| Public enumeration | [Relationship](T_Rage_Relationship.htm) | Represents the relationships between relationship groups. |
| Public enumeration | [SpeechModifier](T_Rage_SpeechModifier.htm) |  |
| Public enumeration | [TaskStatus](T_Rage_TaskStatus.htm) | Indicates the status of a task. |
| Public enumeration | [TraceFlags](T_Rage_TraceFlags.htm) |  |
| Public enumeration | [VehicleClass](T_Rage_VehicleClass.htm) |  |
| Public enumeration | [VehicleComponents](T_Rage_VehicleComponents.htm) |  |
| Public enumeration | [VehicleConvertibleRoofState](T_Rage_VehicleConvertibleRoofState.htm) | Represents the state of the convertible roof of a vehicle. |
| Public enumeration | [VehicleDrivingFlags](T_Rage_VehicleDrivingFlags.htm) | Flags for driving tasks. |
| Public enumeration | [VehicleIndicatorLightsStatus](T_Rage_VehicleIndicatorLightsStatus.htm) | Represents the status of vehicle indicator lights. |
| Public enumeration | [VehicleLockStatus](T_Rage_VehicleLockStatus.htm) | Represents the status of vehicle locks. |
| Public enumeration | [VehicleManeuver](T_Rage_VehicleManeuver.htm) | Represents the possible driving maneuvers for [!:Rage::TaskInvoker::PerformDrivingManeuver]. |
| Public enumeration | [VehicleModType](T_Rage_VehicleModType.htm) |  |
| Public enumeration | [VehicleType](T_Rage_VehicleType.htm) |  |
| Public enumeration | [VehicleWheelType](T_Rage_VehicleWheelType.htm) |  |
| Public enumeration | [WeaponHash](T_Rage_WeaponHash.htm) |  |
| Public enumeration | [WeaponState](T_Rage_WeaponState.htm) |  |
| Public enumeration | [WeatherType](T_Rage_WeatherType.htm) |  |
| Public enumeration | [WindowsEdition](T_Rage_WindowsEdition.htm) |  |
| Public enumeration | [WindowsVersion](T_Rage_WindowsVersion.htm) |  |

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.