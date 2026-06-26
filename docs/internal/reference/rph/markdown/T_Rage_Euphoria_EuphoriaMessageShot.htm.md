# EuphoriaMessageShot Class

﻿EuphoriaMessageShot Class

|  |  |  |
| --- | --- | --- |
| EuphoriaMessageShot Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

[Missing <summary> documentation for "T:Rage.Euphoria.EuphoriaMessageShot"]

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [Rage.EuphoriaEuphoriaMessage](T_Rage_Euphoria_EuphoriaMessage.htm)  
    Rage.EuphoriaEuphoriaMessageShot  
**Namespace:**
 [Rage.Euphoria](N_Rage_Euphoria.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
public class EuphoriaMessageShot : EuphoriaMessage
```

```
Public Class EuphoriaMessageShot
	Inherits EuphoriaMessage
```

```
public ref class EuphoriaMessageShot : public EuphoriaMessage
```

The EuphoriaMessageShot type exposes the following members.

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [EuphoriaMessageShot](M_Rage_Euphoria_EuphoriaMessageShot__ctor.htm) | Initializes a new instance of the EuphoriaMessageShot class |

[Top](#mainBody)

Properties

|  | Name | Description |
| --- | --- | --- |
| Public property | [AllowInjuredArm](P_Rage_Euphoria_EuphoriaMessageShot_AllowInjuredArm.htm) | Injured arm code runs if arm hit (turns and steps and bends injured arm). |
| Public property | [AllowInjuredLeg](P_Rage_Euphoria_EuphoriaMessageShot_AllowInjuredLeg.htm) | When false injured leg is not bent and character does not bend to reach it. |
| Public property | [AllowInjuredLowerLegReach](P_Rage_Euphoria_EuphoriaMessageShot_AllowInjuredLowerLegReach.htm) | When false don't try to reach for injured Lower Legs (shins/feet). |
| Public property | [AllowInjuredThighReach](P_Rage_Euphoria_EuphoriaMessageShot_AllowInjuredThighReach.htm) | When false don't try to reach for injured Thighs. |
| Public property | [AlwaysResetLooseness](P_Rage_Euphoria_EuphoriaMessageShot_AlwaysResetLooseness.htm) | Looseness always reset on shotNewBullet even if previous looseness ramp still running. Except for the neck which has it's own ramp. |
| Public property | [AlwaysResetNeckLooseness](P_Rage_Euphoria_EuphoriaMessageShot_AlwaysResetNeckLooseness.htm) | Neck looseness always reset on shotNewBullet even if previous looseness ramp still running. |
| Public property | [AngVelScale](P_Rage_Euphoria_EuphoriaMessageShot_AngVelScale.htm) | How much to scale the angular velocity coming in from animation of a part if it is in angVelScaleMask (otherwise scale by 1.0). |
| Public property | [AngVelScaleMask](P_Rage_Euphoria_EuphoriaMessageShot_AngVelScaleMask.htm) | Parts to scale the initial angular velocity by angVelScale (otherwize scale by 1.0). |
| Public property | [ArmStiffness](P_Rage_Euphoria_EuphoriaMessageShot_ArmStiffness.htm) | Arm stiffness. |
| Public property | [BodyStiffness](P_Rage_Euphoria_EuphoriaMessageShot_BodyStiffness.htm) | Stiffness of body. Feeds through to roll\_up. |
| Public property | [BulletProofVest](P_Rage_Euphoria_EuphoriaMessageShot_BulletProofVest.htm) | Looseness applied to spine is different if bulletProofVest is true. |
| Public property | [ChickenArms](P_Rage_Euphoria_EuphoriaMessageShot_ChickenArms.htm) | Type of reaction. |
| Public property | [CpainDuration](P_Rage_Euphoria_EuphoriaMessageShot_CpainDuration.htm) | Conscious pain duration at cpainMag/cpainTwistMag after cpainSmooth2Time. |
| Public property | [CpainMag](P_Rage_Euphoria_EuphoriaMessageShot_CpainMag.htm) | Conscious pain spine Lean(back/Forward) magnitude (Replaces spinePainMultiplier). |
| Public property | [CpainSmooth2Time](P_Rage_Euphoria_EuphoriaMessageShot_CpainSmooth2Time.htm) | Conscious pain duration ramping from zero to cpainMag/cpainTwistMag. |
| Public property | [CpainSmooth2Zero](P_Rage_Euphoria_EuphoriaMessageShot_CpainSmooth2Zero.htm) | Conscious pain ramping to zero after cpainSmooth2Time + cpainDuration (Replaces spinePainTime). |
| Public property | [CpainTwistMag](P_Rage_Euphoria_EuphoriaMessageShot_CpainTwistMag.htm) | Conscious pain spine Twist/Lean2Side magnitude Replaces spinePainTwistMultiplier). |
| Public property | [Crouching](P_Rage_Euphoria_EuphoriaMessageShot_Crouching.htm) | Is the guy crouching or not. |
| Public property | [CStrLowerMax](P_Rage_Euphoria_EuphoriaMessageShot_CStrLowerMax.htm) | Behaviour unknown. |
| Public property | [CStrLowerMin](P_Rage_Euphoria_EuphoriaMessageShot_CStrLowerMin.htm) | Behaviour unknown. |
| Public property | [CStrUpperMax](P_Rage_Euphoria_EuphoriaMessageShot_CStrUpperMax.htm) | Behaviour unknown. |
| Public property | [CStrUpperMin](P_Rage_Euphoria_EuphoriaMessageShot_CStrUpperMin.htm) | Proportions to what the strength would be normally. |
| Public property | [DeathTime](P_Rage_Euphoria_EuphoriaMessageShot_DeathTime.htm) | Time to death (HACK for underwater). If -ve don't ever die. |
| Public property | [ExagDuration](P_Rage_Euphoria_EuphoriaMessageShot_ExagDuration.htm) | Exaggerate bullet duration (at exagMag/exagTwistMag). |
| Public property | [ExagMag](P_Rage_Euphoria_EuphoriaMessageShot_ExagMag.htm) | Exaggerate bullet spine Lean magnitude. |
| Public property | [ExagSmooth2Zero](P_Rage_Euphoria_EuphoriaMessageShot_ExagSmooth2Zero.htm) | Exaggerate bullet duration ramping to zero after exagDuration. |
| Public property | [ExagTwistMag](P_Rage_Euphoria_EuphoriaMessageShot_ExagTwistMag.htm) | Exaggerate bullet spine Twist magnitude. |
| Public property | [ExagZeroTime](P_Rage_Euphoria_EuphoriaMessageShot_ExagZeroTime.htm) | Exaggerate bullet time spent at 0 spine lean/twist after exagDuration + exagSmooth2Zero. |
| Public property | [FallingReaction](P_Rage_Euphoria_EuphoriaMessageShot_FallingReaction.htm) | 0=Rollup, 1=Catchfall, 2=rollDownStairs, 3=smartFall. |
| Public property | [Fling](P_Rage_Euphoria_EuphoriaMessageShot_Fling.htm) | Type of reaction. |
| Public property | [FlingTime](P_Rage_Euphoria_EuphoriaMessageShot_FlingTime.htm) | Duration of the fling behaviour. |
| Public property | [FlingWidth](P_Rage_Euphoria_EuphoriaMessageShot_FlingWidth.htm) | Width of the fling behaviour. |
| Public property | [GrabHoldTime](P_Rage_Euphoria_EuphoriaMessageShot_GrabHoldTime.htm) | How long to hold for before returning to relaxed arm position. |
| Public property | [InitialNeckDamping](P_Rage_Euphoria_EuphoriaMessageShot_InitialNeckDamping.htm) | Intial damping of neck after being shot. |
| Public property | [InitialNeckDuration](P_Rage_Euphoria_EuphoriaMessageShot_InitialNeckDuration.htm) | Duration for which the neck stays at intial stiffness/damping. |
| Public property | [InitialNeckRampDuration](P_Rage_Euphoria_EuphoriaMessageShot_InitialNeckRampDuration.htm) | Duration of the ramp to bring the neck stiffness/damping back to normal levels. |
| Public property | [InitialNeckStiffness](P_Rage_Euphoria_EuphoriaMessageShot_InitialNeckStiffness.htm) | Initial stiffness of neck after being shot. |
| Public property | [InitialWeaknessRampDuration](P_Rage_Euphoria_EuphoriaMessageShot_InitialWeaknessRampDuration.htm) | Duration of the ramp to bring the character's upper body stiffness back to normal levels. |
| Public property | [InitialWeaknessZeroDuration](P_Rage_Euphoria_EuphoriaMessageShot_InitialWeaknessZeroDuration.htm) | Duration for which the character's upper body stays at minimum stiffness (not quite zero). |
| Public property | [KMult4Legs](P_Rage_Euphoria_EuphoriaMessageShot_KMult4Legs.htm) | How much to add to leg stiffnesses dependent on looseness. |
| Public property | [KMultOnLoose](P_Rage_Euphoria_EuphoriaMessageShot_KMultOnLoose.htm) | How much to add to upperbody stiffness dependent on looseness. |
| Public property | [Looseness4Fall](P_Rage_Euphoria_EuphoriaMessageShot_Looseness4Fall.htm) | How loose the character is made by a newBullet if falling. |
| Public property | [Looseness4Stagger](P_Rage_Euphoria_EuphoriaMessageShot_Looseness4Stagger.htm) | How loose the upperBody of the character is made by a newBullet if staggerFall is running (and not falling). Note atm the neck ramp values are ignored in staggerFall. |
| Public property | [LoosenessAmount](P_Rage_Euphoria_EuphoriaMessageShot_LoosenessAmount.htm) | How loose the character is made by a newBullet. between 0 and 1. |
| Public property | [Melee](P_Rage_Euphoria_EuphoriaMessageShot_Melee.htm) | Behaviour unknown. |
| Public property | [MinArmsLooseness](P_Rage_Euphoria_EuphoriaMessageShot_MinArmsLooseness.htm) | Minimum looseness to apply to the arms. |
| Public property | [MinLegsLooseness](P_Rage_Euphoria_EuphoriaMessageShot_MinLegsLooseness.htm) | Minimum looseness to apply to the Legs. |
| Public property | [Name](P_Rage_Euphoria_EuphoriaMessage_Name.htm) | (Inherited from [EuphoriaMessage](T_Rage_Euphoria_EuphoriaMessage.htm).) |
| Public property | [NeckDamping](P_Rage_Euphoria_EuphoriaMessageShot_NeckDamping.htm) | Damping of neck. |
| Public property | [NeckStiffness](P_Rage_Euphoria_EuphoriaMessageShot_NeckStiffness.htm) | Stiffness of neck. |
| Public property | [ReachForWound](P_Rage_Euphoria_EuphoriaMessageShot_ReachForWound.htm) | Type of reaction. |
| Public property | [SpineBlendExagCPain](P_Rage_Euphoria_EuphoriaMessageShot_SpineBlendExagCPain.htm) | True: spine is blended with zero pose, false: spine is blended with zero pose if not setting exag or cpain. |
| Public property | [SpineBlendZero](P_Rage_Euphoria_EuphoriaMessageShot_SpineBlendZero.htm) | Spine is always blended with zero pose this much and up to 1 as the character become stationary. If negative no blend is ever applied. |
| Public property | [SpineDamping](P_Rage_Euphoria_EuphoriaMessageShot_SpineDamping.htm) | Stiffness of body. Feeds through to roll\_up. |
| Public property | [StableHandsAndNeck](P_Rage_Euphoria_EuphoriaMessageShot_StableHandsAndNeck.htm) | Additional stability for hands and neck (less loose). |
| Public property | [TimeBeforeReachForWound](P_Rage_Euphoria_EuphoriaMessageShot_TimeBeforeReachForWound.htm) | Time, in seconds, before the character begins to grab for the wound on the first hit. |
| Public property | [UseCStrModulation](P_Rage_Euphoria_EuphoriaMessageShot_UseCStrModulation.htm) | If enabled upper and lower body strength scales with character strength, using the range given by parameters below. |
| Public property | [UseExtendedCatchFall](P_Rage_Euphoria_EuphoriaMessageShot_UseExtendedCatchFall.htm) | Keep the character active instead of relaxing at the end of the catch fall. |

[Top](#mainBody)

Methods

|  | Name | Description |
| --- | --- | --- |
| Public method | [PushArgument](M_Rage_Euphoria_EuphoriaMessage_PushArgument.htm) | Adds the specified argument to this [EuphoriaMessage](T_Rage_Euphoria_EuphoriaMessage.htm).  Note that this does not override existing arguments with the same name. If this is desired, use the [!:Rage::EuphoriaMessage::SetArgument] overload. (Inherited from [EuphoriaMessage](T_Rage_Euphoria_EuphoriaMessage.htm).) |
| Public method | [Reset](M_Rage_Euphoria_EuphoriaMessage_Reset.htm) | (Inherited from [EuphoriaMessage](T_Rage_Euphoria_EuphoriaMessage.htm).) |
| Public method | [SendTo](M_Rage_Euphoria_EuphoriaMessage_SendTo.htm) | (Inherited from [EuphoriaMessage](T_Rage_Euphoria_EuphoriaMessage.htm).) |
| Public method | [SetArgument](M_Rage_Euphoria_EuphoriaMessage_SetArgument.htm) | Sets the specified argument to this [EuphoriaMessage](T_Rage_Euphoria_EuphoriaMessage.htm).  Note that this overrides existing arguments with the same name. If this is not desired, use the [!:Rage::EuphoriaMessage::PushArgument] overload. (Inherited from [EuphoriaMessage](T_Rage_Euphoria_EuphoriaMessage.htm).) |

[Top](#mainBody)

See Also

#### Reference

[Rage.Euphoria Namespace](N_Rage_Euphoria.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.