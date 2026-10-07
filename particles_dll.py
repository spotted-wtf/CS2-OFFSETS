class cs2_dumper:
    class schemas:
        class particles_dll:
            class C_OP_Cull:
                m_flCullEnd = 0x1E8
                m_flCullExp = 0x1EC
                m_flCullPerc = 0x1E0
                m_flCullStart = 0x1E4
            class C_OP_Spin:
                pass
            class C_OP_Decay:
                m_bRopeDecay = 0x1E0
                m_bForcePreserveParticleOrder = 0x1E1
            class C_OP_Noise:
                m_bAdditive = 0x1F0
                m_flOutputMax = 0x1E8
                m_flOutputMin = 0x1E4
                m_nFieldOutput = 0x1E0
                m_fl4NoiseScale = 0x1EC
                m_flNoiseAnimationTimeScale = 0x1F4
            class C_OP_FadeIn:
                m_bProportional = 0x1EC
                m_flFadeInTimeExp = 0x1E8
                m_flFadeInTimeMax = 0x1E4
                m_flFadeInTimeMin = 0x1E0
            class C_OP_SetVec:
                m_Lerp = 0x8C0
                m_InputValue = 0x1E0
                m_nSetMethod = 0x8BC
                m_nOutputField = 0x8B8
                m_bNormalizedOutput = 0xA38
            class CGeneralSpin:
                m_nSpinRateDegrees = 0x1E0
                m_fSpinRateStopTime = 0x1EC
                m_nSpinRateMinDegrees = 0x1E4
            class C_OP_FadeOut:
                m_flFadeBias = 0x1EC
                m_bEaseInAndOut = 0x221
                m_bProportional = 0x220
                m_flFadeOutTimeExp = 0x1E8
                m_flFadeOutTimeMax = 0x1E4
                m_flFadeOutTimeMin = 0x1E0
            class C_OP_SetToCP:
                m_vecOffset = 0x1E4
                m_bOffsetLocal = 0x1F0
                m_nControlPointNumber = 0x1E0
            class C_OP_SpinYaw:
                pass
            class C_OP_Callback:
                pass
            class C_OP_SetFloat:
                m_Lerp = 0x360
                m_InputValue = 0x1E0
                m_nSetMethod = 0x35C
                m_nOutputField = 0x358
            class CPAssignment_t:
                m_Pos = 0x8
                m_nCPNumber = 0x0
                m_nOrientationMode = 0x6E0
            class CPulseGraphDef:
                m_Vars = 0x80
                m_Cells = 0x68
                m_Chunks = 0x50
                m_CallInfos = 0xE0
                m_Constants = 0xF8
                m_DomainValues = 0x110
                m_TempVarBanks = 0x98
                m_DomainSubType = 0x18
                m_ParentMapName = 0x30
                m_ParentXmlName = 0x40
                m_PublicOutputs = 0xB0
                m_InvokeBindings = 0xC8
                m_DomainIdentifier = 0x8
                m_OutputConnections = 0x140
                m_BlackboardReferences = 0x128
            class C_INIT_InitVec:
                m_InputValue = 0x1E8
                m_nSetMethod = 0x8C4
                m_nOutputField = 0x8C0
                m_bNormalizedOutput = 0x8C8
                m_bWritePreviousPosition = 0x8C9
            class C_OP_Diffusion:
                m_nFieldOutput = 0x1E4
                m_flRadiusScale = 0x1E0
                m_nVoxelGridResolution = 0x1E8
            class C_OP_ModelCull:
                m_bBoundBox = 0x1E4
                m_bUseBones = 0x1E6
                m_bCullOutside = 0x1E5
                m_HitboxSetName = 0x1E7
                m_nControlPointNumber = 0x1E0
            class C_OP_PlaneCull:
                m_bLocalSpace = 0x8C0
                m_flPlaneOffset = 0x8C4
                m_vecPlaneDirection = 0x1E8
                m_nPlaneControlPoint = 0x1E0
            class C_OP_RtEnvCull:
                m_nRTEnvCP = 0x27C
                m_RtEnvName = 0x1FA
                m_nComponent = 0x280
                m_vecTestDir = 0x1E0
                m_bCullOnMiss = 0x1F8
                m_vecTestNormal = 0x1EC
                m_bStickInsteadOfCull = 0x1F9
            class C_OP_WindForce:
                m_vForce = 0x1F0
            class TextureGroup_t:
                m_Gradient = 0x10
                m_bEnabled = 0x0
                m_hTexture = 0x8
                m_nTextureType = 0x28
                m_flTextureBlend = 0x38
                m_TextureControls = 0x1B0
                m_nTextureChannels = 0x2C
                m_nTextureBlendMode = 0x30
                m_bReplaceTextureWithGradient = 0x1
            class CPathParameters:
                m_flBulge = 0x10
                m_flMidPoint = 0x14
                m_vEndOffset = 0x30
                m_nBulgeControl = 0xC
                m_vMidPointOffset = 0x24
                m_vStartPointOffset = 0x18
                m_nEndControlPointNumber = 0x8
                m_nMidControlPointNumber = 0x4
                m_nStartControlPointNumber = 0x0
            class CPulseCell_Base:
                m_nEditorNodeID = 0x8
            class CPulse_CallInfo:
                m_PortName = 0x0
                m_nSrcChunk = 0x4C
                m_RegisterMap = 0x18
                m_CallMethodID = 0x48
                m_nEditorNodeID = 0x10
                m_nBreakDestChunk = 0x54
                m_nSrcInstruction = 0x50
                m_nBreakDestInstruction = 0x58
            class CSpinUpdateBase:
                pass
            class C_INIT_AgeNoise:
                m_bAbsVal = 0x1E8
                m_flAgeMax = 0x1F4
                m_flAgeMin = 0x1F0
                m_flOffset = 0x1EC
                m_bAbsValInv = 0x1E9
                m_flNoiseScale = 0x1F8
                m_vecOffsetLoc = 0x200
                m_flNoiseScaleLoc = 0x1FC
            class C_INIT_RingWave:
                m_flYaw = 0xC98
                m_flRoll = 0x9A8
                m_flPitch = 0xB20
                m_flThickness = 0x540
                m_TransformInput = 0x1E8
                m_bXYVelocityOnly = 0xE11
                m_flInitialRadius = 0x3C8
                m_bEvenDistribution = 0xE10
                m_flInitialSpeedMax = 0x830
                m_flInitialSpeedMin = 0x6B8
                m_flParticlesPerOrbit = 0x250
            class C_OP_AlphaDecay:
                m_flMinAlpha = 0x1E0
            class C_OP_DampenToCP:
                m_flRange = 0x1E4
                m_flScale = 0x1E8
                m_nControlPointNumber = 0x1E0
            class C_OP_LerpScalar:
                m_flOutput = 0x1E8
                m_flEndTime = 0x364
                m_flStartTime = 0x360
                m_nFieldOutput = 0x1E0
            class C_OP_LerpVector:
                m_flEndTime = 0x1F4
                m_vecOutput = 0x1E4
                m_nSetMethod = 0x1F8
                m_flStartTime = 0x1F0
                m_nFieldOutput = 0x1E0
            class C_OP_LockPoints:
                m_nMaxCol = 0x1E4
                m_nMaxRow = 0x1EC
                m_nMinCol = 0x1E0
                m_nMinRow = 0x1E8
                m_flBlendValue = 0x1F4
                m_nControlPoint = 0x1F0
            class C_OP_LockToBone:
                m_bRigid = 0x338
                m_bUseBones = 0x339
                m_flRotLerp = 0xA28
                m_modelInput = 0x1E0
                m_vecRotation = 0x350
                m_nFieldOutput = 0x33C
                m_HitboxSetName = 0x2B8
                m_flPrevPosScale = 0x2B4
                m_transformInput = 0x240
                m_flJumpThreshold = 0x2B0
                m_nFieldOutputPrev = 0x340
                m_nRotationSetType = 0x344
                m_flLifeTimeFadeEnd = 0x2AC
                m_bRigidRotationLock = 0x348
                m_flLifeTimeFadeStart = 0x2A8
            class C_OP_NormalLock:
                m_nControlPointNumber = 0x1E0
            class C_OP_RemapSpeed:
                m_flInputMax = 0x1E8
                m_flInputMin = 0x1E4
                m_nSetMethod = 0x1F4
                m_flOutputMax = 0x1F0
                m_flOutputMin = 0x1EC
                m_bIgnoreDelta = 0x1F8
                m_nFieldOutput = 0x1E0
            class C_OP_RenderText:
                m_DefaultText = 0x238
                m_OutlineColor = 0x230
            class C_OP_SpinUpdate:
                pass
            class CPulseExecCursor:
                pass
            class C_INIT_InitFloat:
                m_InputValue = 0x1E8
                m_nSetMethod = 0x364
                m_nOutputField = 0x360
                m_InputStrength = 0x368
            class C_INIT_ModelCull:
                m_bBoundBox = 0x1EC
                m_bUseBones = 0x1EE
                m_bCullOutside = 0x1ED
                m_HitboxSetName = 0x1EF
                m_nControlPointNumber = 0x1E8
            class C_INIT_PlaneCull:
                m_flDistance = 0x1F0
                m_bCullInside = 0x368
                m_nControlPoint = 0x1E8
            class C_INIT_PointList:
                m_pointList = 0x1F0
                m_bClosedLoop = 0x209
                m_nFieldOutput = 0x1E8
                m_bPlaceAlongPath = 0x208
                m_nNumPointsAlongPath = 0x20C
            class C_INIT_RandomYaw:
                pass
            class C_INIT_RtEnvCull:
                m_nRTEnvCP = 0x284
                m_RtEnvName = 0x203
                m_nComponent = 0x288
                m_vecTestDir = 0x1E8
                m_bCullOnMiss = 0x201
                m_bLifeAdjust = 0x202
                m_bUseVelocity = 0x200
                m_vecTestNormal = 0x1F4
            class C_OP_ChladniWave:
                m_b3D = 0x1580
                m_flInputMax = 0x360
                m_flInputMin = 0x1E8
                m_nSetMethod = 0x1578
                m_flOutputMax = 0x650
                m_flOutputMin = 0x4D8
                m_nFieldOutput = 0x1E0
                m_vecHarmonics = 0xEA0
                m_vecWaveLength = 0x7C8
                m_nLocalSpaceControlPoint = 0x157C
            class C_OP_ClampScalar:
                m_flOutputMax = 0x360
                m_flOutputMin = 0x1E8
                m_nFieldOutput = 0x1E0
            class C_OP_ClampVector:
                m_nFieldOutput = 0x1E0
                m_vecOutputMax = 0x8C0
                m_vecOutputMin = 0x1E8
            class C_OP_CycleScalar:
                m_nCPScale = 0x1F4
                m_flEndValue = 0x1E8
                m_nDestField = 0x1E0
                m_nSetMethod = 0x200
                m_flCycleTime = 0x1EC
                m_nCPFieldMax = 0x1FC
                m_nCPFieldMin = 0x1F8
                m_flStartValue = 0x1E4
                m_bDoNotRepeatCycle = 0x1F0
                m_bSynchronizeParticles = 0x1F1
            class C_OP_EndCapDecay:
                pass
            class C_OP_FadeAndKill:
                m_flEndAlpha = 0x1F4
                m_flStartAlpha = 0x1F0
                m_flEndFadeInTime = 0x1E4
                m_flEndFadeOutTime = 0x1EC
                m_flStartFadeInTime = 0x1E0
                m_flStartFadeOutTime = 0x1E8
                m_bForcePreserveParticleOrder = 0x1F8
            class C_OP_GlobalLight:
                m_flScale = 0x1E0
                m_bClampLowerRange = 0x1E4
                m_bClampUpperRange = 0x1E5
            class C_OP_MaxVelocity:
                m_flMaxVelocity = 0x1E0
                m_flMinVelocity = 0x358
            class C_OP_RadiusDecay:
                m_flMinRadius = 0x1E0
            class C_OP_RandomForce:
                m_MaxForce = 0x1FC
                m_MinForce = 0x1F0
            class C_OP_RemapCPtoCP:
                m_flInputMax = 0x1FC
                m_flInputMin = 0x1F8
                m_bDerivative = 0x208
                m_flOutputMax = 0x204
                m_flOutputMin = 0x200
                m_nInputField = 0x1F0
                m_flInterpRate = 0x20C
                m_nOutputField = 0x1F4
                m_nInputControlPoint = 0x1E8
                m_nOutputControlPoint = 0x1EC
            class C_OP_RemapScalar:
                m_bOldCode = 0x1F8
                m_flInputMax = 0x1EC
                m_flInputMin = 0x1E8
                m_flOutputMax = 0x1F4
                m_flOutputMin = 0x1F0
                m_nFieldInput = 0x1E0
                m_nFieldOutput = 0x1E4
            class C_OP_RenderBlobs:
                m_nScaleCP = 0x6A0
                m_cubeWidth = 0x230
                m_hMaterial = 0x6D8
                m_MaterialVars = 0x6A8
                m_cutoffRadius = 0x3A8
                m_renderRadius = 0x520
                m_nIndexCountKb = 0x69C
                m_nVertexCountKb = 0x698
            class C_OP_RenderRopes:
                m_bClampV = 0x34EC
                m_flMaxSize = 0x2EE0
                m_flMinSize = 0x2EDC
                m_nScaleCP1 = 0x34F0
                m_nScaleCP2 = 0x34F4
                m_bClosedLoop = 0x3511
                m_flTessScale = 0x307C
                m_nSplitField = 0x3514
                m_flEndFadeDot = 0x2EF0
                m_bDrawAsOpaque = 0x3524
                m_bReverseOrder = 0x3510
                m_flEndFadeSize = 0x2EE8
                m_flRadiusTaper = 0x3070
                m_flStartFadeDot = 0x2EEC
                m_flStartFadeSize = 0x2EE4
                m_nMaxTesselation = 0x3078
                m_nMinTesselation = 0x3074
                m_bGenerateNormals = 0x3525
                m_bSortBySegmentID = 0x3518
                m_flTextureVOffset = 0x3370
                m_nOrientationType = 0x351C
                m_flSubPixelAAScale = 0x2EF8
                m_nTextureVParamsCP = 0x34E8
                m_flTextureVWorldSize = 0x3080
                m_flTextureVScrollRate = 0x31F8
                m_bEnableFadingAndClamping = 0x2ED8
                m_nVectorFieldForOrientation = 0x3520
                m_bUseScalarForTextureCoordinate = 0x3505
                m_nScalarFieldForTextureCoordinate = 0x3508
                m_flScalarAttributeTextureCoordScale = 0x350C
                m_flScaleVSizeByControlPointDistance = 0x34F8
                m_flScaleVOffsetByControlPointDistance = 0x3500
                m_flScaleVScrollByControlPointDistance = 0x34FC
            class C_OP_RenderSound:
                m_nChannel = 0x250
                m_nPitchField = 0x248
                m_flPitchScale = 0x238
                m_nCPReference = 0x254
                m_nSndLvlField = 0x240
                m_nVolumeField = 0x24C
                m_pszSoundName = 0x258
                m_flSndLvlScale = 0x234
                m_flVolumeScale = 0x23C
                m_nDurationField = 0x244
                m_flDurationScale = 0x230
                m_bSuppressStopSoundEvent = 0x358
            class C_OP_SetVariable:
                m_vecInput = 0x2B8
                m_floatInput = 0x990
                m_positionOffset = 0x2A0
                m_rotationOffset = 0x2AC
                m_transformInput = 0x238
                m_variableReference = 0x1E8
            class C_OP_VectorNoise:
                m_bOffset = 0x201
                m_bAdditive = 0x200
                m_nFieldOutput = 0x1E0
                m_vecOutputMax = 0x1F0
                m_vecOutputMin = 0x1E4
                m_fl4NoiseScale = 0x1FC
                m_flNoiseAnimationTimeScale = 0x204
            class ModelReference_t:
                m_model = 0x0
                m_flRelativeProbabilityOfSpawn = 0x8
            class CParticleFunction:
                m_Notes = 0x1C0
                m_nToolsState = 0x184
                m_flOpStrength = 0x8
                m_nOpEndCapState = 0x180
                m_bDisableOperator = 0x1BA
                m_flOpTimeScaleMax = 0x1B4
                m_flOpTimeScaleMin = 0x1B0
                m_nOpTimeScaleSeed = 0x1AC
                m_flOpEndFadeInTime = 0x18C
                m_flOpTimeOffsetMax = 0x1A4
                m_flOpTimeOffsetMin = 0x1A0
                m_nOpTimeOffsetSeed = 0x1A8
                m_flOpEndFadeOutTime = 0x194
                m_flOpStartFadeInTime = 0x188
                m_bNormalizeToStopTime = 0x19C
                m_flOpStartFadeOutTime = 0x190
                m_flOpFadeOscillatePeriod = 0x198
            class C_INIT_SkyVisCull:
                m_nTraceSet = 0x8C0
                m_bCullOnSky = 0x8C4
                m_vecTestDir = 0x1E8
            class C_OP_DensityForce:
                m_flForceScale = 0x1F4
                m_flRadiusScale = 0x1F0
                m_flTargetDensity = 0x1F8
            class C_OP_DistanceCull:
                m_flDistance = 0x1F0
                m_nAttribute = 0x36C
                m_bCullInside = 0x368
                m_nControlPoint = 0x1E0
                m_vecPointOffset = 0x1E4
            class C_OP_FadeInSimple:
                m_flFadeInTime = 0x1E0
                m_nFieldOutput = 0x1E4
            class C_OP_HSVShiftToCP:
                m_nColorCP = 0x1E8
                m_nOutputCP = 0x1F0
                m_DefaultHSVColor = 0x1F4
                m_nColorGemEnableCP = 0x1EC
            class C_OP_MoveToHitbox:
                m_bUseBones = 0x338
                m_nLerpType = 0x33C
                m_modelInput = 0x1E0
                m_HitboxSetName = 0x2B8
                m_flPrevPosScale = 0x2B4
                m_transformInput = 0x240
                m_flInterpolation = 0x340
                m_flLifeTimeLerpEnd = 0x2B0
                m_flLifeTimeLerpStart = 0x2AC
            class C_OP_NoiseEmitter:
                m_bAbsVal = 0x200
                m_flOffset = 0x204
                m_bAbsValInv = 0x201
                m_flOutputMax = 0x20C
                m_flOutputMin = 0x208
                m_flStartTime = 0x1EC
                m_flNoiseScale = 0x210
                m_vecOffsetLoc = 0x218
                m_flEmissionScale = 0x1F0
                m_flWorldTimeScale = 0x224
                m_nWorldNoisePoint = 0x1FC
                m_flWorldNoiseScale = 0x214
                m_flEmissionDuration = 0x1E8
                m_nScaleControlPoint = 0x1F4
                m_nScaleControlPointField = 0x1F8
            class C_OP_PositionLock:
                m_flRange = 0x260
                m_bLockRot = 0x3E8
                m_vecScale = 0x3F0
                m_flRangeBias = 0x268
                m_nFieldOutput = 0xAC8
                m_flEndTime_exp = 0x25C
                m_flEndTime_max = 0x258
                m_flEndTime_min = 0x254
                m_TransformInput = 0x1E0
                m_flPrevPosScale = 0x3E4
                m_flJumpThreshold = 0x3E0
                m_flStartTime_exp = 0x250
                m_flStartTime_max = 0x24C
                m_flStartTime_min = 0x248
                m_nFieldOutputPrev = 0xACC
            class C_OP_RenderCables:
                m_hMaterial = 0xC00
                m_nRoundness = 0x14F8
                m_flTessScale = 0x14EC
                m_flAlphaScale = 0x3A8
                m_flRadiusScale = 0x230
                m_vecColorScale = 0x520
                m_bDrawCableCaps = 0x14E0
                m_flCapRoundness = 0x14E4
                m_MaterialVecVars = 0x1588
                m_nColorBlendType = 0xBF8
                m_nMaxTesselation = 0x14F4
                m_nMinTesselation = 0x14F0
                m_LightingTransform = 0x1500
                m_MaterialFloatVars = 0x1568
                m_flCapOffsetAmount = 0x14E8
                m_flColorMapOffsetU = 0x1078
                m_flColorMapOffsetV = 0xF00
                m_flNormalMapOffsetU = 0x1368
                m_flNormalMapOffsetV = 0x11F0
                m_nForceRoundnessFixed = 0x14FC
                m_nTextureRepetitionMode = 0xC08
                m_flTextureRepeatsPerSegment = 0xC10
                m_bOnlyRenderInEffectsBloomPass = 0x14FD
                m_flTextureRepeatsCircumference = 0xD88
            class C_OP_RenderLights:
                m_flMaxSize = 0x248
                m_flMinSize = 0x244
                m_bAnimateInFPS = 0x240
                m_flEndFadeSize = 0x250
                m_nAnimationType = 0x23C
                m_flAnimationRate = 0x238
                m_flStartFadeSize = 0x24C
            class C_OP_RenderModels:
                m_nLOD = 0x1FC0
                m_nSkin = 0x1AE0
                m_bOrientZ = 0x259
                m_ModelList = 0x238
                m_bAnimated = 0x16F8
                m_modelInput = 0x1F60
                m_bLocalScale = 0x16F0
                m_flRollScale = 0x24C8
                m_ActivityName = 0x1888
                m_EconSlotName = 0x1FC4
                m_MaterialVars = 0x1C58
                m_SequenceName = 0x1988
                m_flAlphaScale = 0x2350
                m_nAlpha2Field = 0x2640
                m_bCenterOffset = 0x25A
                m_bIgnoreNormal = 0x258
                m_bIgnoreRadius = 0x1010
                m_bSuppressTint = 0x20C5
                m_flRadiusScale = 0x21D8
                m_nModelScaleCP = 0x1014
                m_strLightStyle = 0x2D28
                m_vecColorScale = 0x2648
                m_bAcceptsDecals = 0x20CE
                m_bOriginalModel = 0x20C4
                m_flRenderFilter = 0x1C70
                m_nSizeCullBloat = 0x16F4
                m_nSubModelField = 0x254
                m_vecLocalOffset = 0x260
                m_ClothEffectName = 0x1A8A
                m_bDisableShadows = 0x20CC
                m_flAnimationRate = 0x1700
                m_nAnimationField = 0x1880
                m_nBodyGroupField = 0x250
                m_nColorBlendType = 0x2D20
                m_bManualAnimFrame = 0x187B
                m_bResetAnimOnStop = 0x187A
                m_flLightStyleTime = 0x2D30
                m_vecLocalRotation = 0x938
                m_hOverrideMaterial = 0x1AD0
                m_nManualFrameField = 0x1884
                m_szRenderAttribute = 0x20D2
                m_vecComponentScale = 0x1018
                m_nSubModelFieldType = 0x20C8
                m_bScaleAnimationRate = 0x1878
                m_bDisableDepthPrepass = 0x20CD
                m_nAnimationScaleField = 0x187C
                m_bEnableClothSimulation = 0x1A88
                m_bForceLoopingAnimation = 0x1879
                m_flManualModelSelection = 0x1DE8
                m_bDoNotDrawInParticlePass = 0x20D0
                m_bAllowApproximateTransforms = 0x20D1
                m_bDisableClothGroundCollision = 0x1A89
                m_bUseMixedResolutionRendering = 0x232
                m_bOnlyRenderInEffectsBloomPass = 0x230
                m_bOnlyRenderInEffectsWaterPass = 0x231
                m_bOverrideTranslucentMaterials = 0x1AD8
                m_bOnlyRenderInEffecsGameOverlay = 0x233
                m_bForceDrawInterlevedWithSiblings = 0x20CF
            class C_OP_RenderPoints:
                m_hMaterial = 0x230
            class C_OP_RenderTrails:
                m_bIgnoreDT = 0x3370
                m_flMaxLength = 0x3368
                m_flMinLength = 0x336C
                m_flEndFadeDot = 0x3360
                m_flLengthScale = 0x3378
                m_flRadiusTaper = 0x3D48
                m_flForwardShift = 0x4718
                m_flStartFadeDot = 0x335C
                m_nPrevPntSource = 0x3364
                m_nVertCropField = 0x4714
                m_nHorizCropField = 0x4710
                m_flHeadAlphaScale = 0x3BD0
                m_flTailAlphaScale = 0x4598
                m_flRadiusHeadTaper = 0x3380
                m_vecHeadColorScale = 0x34F8
                m_vecTailColorScale = 0x3EC0
                m_flLengthFadeInTime = 0x337C
                m_bFlipUVBasedOnPitchYaw = 0x471C
                m_bEnableFadingAndClamping = 0x3358
                m_flConstrainRadiusToLengthRatio = 0x3374
            class C_OP_RotateVector:
                m_flScale = 0x208
                m_bNormalize = 0x204
                m_flRotRateMax = 0x200
                m_flRotRateMin = 0x1FC
                m_nFieldOutput = 0x1E0
                m_vecRotAxisMax = 0x1F0
                m_vecRotAxisMin = 0x1E4
            class C_OP_SetUserEvent:
                m_flInput = 0x1E0
                m_flRisingEdge = 0x358
                m_flFallingEdge = 0x4D8
                m_nRisingEventType = 0x4D0
                m_nFallingEventType = 0x650
            class C_OP_TeleportBeam:
                m_flAlpha = 0x210
                m_nCPMisc = 0x1E8
                m_nCPColor = 0x1EC
                m_vGravity = 0x1F8
                m_flArcSpeed = 0x20C
                m_nCPPosition = 0x1E0
                m_nCPVelocity = 0x1E4
                m_flSegmentBreak = 0x208
                m_nCPExtraArcData = 0x1F4
                m_nCPInvalidColor = 0x1F0
                m_flArcMaxDuration = 0x204
            class PointDefinition_t:
                m_vOffset = 0x8
                m_bLocalCoords = 0x4
                m_nControlPoint = 0x0
            class TextureControls_t:
                m_bClampUVs = 0xA49
                m_flZoomScale = 0x758
                m_flDistortion = 0x8D0
                m_nPerParticleZoom = 0xA60
                m_bRandomizeOffsets = 0xA48
                m_nPerParticleBlend = 0xA4C
                m_nPerParticleScale = 0xA50
                m_nPerParticleOffsetU = 0xA54
                m_nPerParticleOffsetV = 0xA58
                m_flFinalTextureScaleU = 0x0
                m_flFinalTextureScaleV = 0x178
                m_nPerParticleRotation = 0xA5C
                m_flFinalTextureOffsetU = 0x2F0
                m_flFinalTextureOffsetV = 0x468
                m_nPerParticleDistortion = 0xA64
                m_flFinalTextureUVRotation = 0x5E0
            class CBaseTrailRenderer:
                m_bClampV = 0x3350
                m_flMaxSize = 0x2EE4
                m_flMinSize = 0x2EE0
                m_flEndFadeSize = 0x3060
                m_flStartFadeSize = 0x2EE8
                m_nOrientationType = 0x2ED8
                m_flSubPixelAAScale = 0x31D8
                m_nOrientationControlPoint = 0x2EDC
            class CPulseCell_Unknown:
                m_UnknownKeys = 0x48
            class CPulse_ResumePoint:
                pass
            class C_INIT_GlobalScale:
                m_flScale = 0x1E8
                m_bScaleRadius = 0x1F4
                m_bScalePosition = 0x1F5
                m_bScaleVelocity = 0x1F6
                m_nControlPointNumber = 0x1F0
                m_nScaleControlPointNumber = 0x1EC
            class C_INIT_RandomAlpha:
                m_nAlphaMax = 0x1F0
                m_nAlphaMin = 0x1EC
                m_nFieldOutput = 0x1E8
                m_flAlphaRandExponent = 0x1FC
            class C_INIT_RandomColor:
                m_TintMax = 0x210
                m_TintMin = 0x20C
                m_nTintCP = 0x21C
                m_ColorMax = 0x208
                m_ColorMin = 0x204
                m_flTintPerc = 0x214
                m_nFieldOutput = 0x220
                m_nTintBlendMode = 0x224
                m_flUpdateThreshold = 0x218
                m_flLightAmplification = 0x228
            class C_OP_BasicMovement:
                m_fDrag = 0x8B8
                m_Gravity = 0x1E0
                m_bUseNewCode = 0xEA4
                m_massControls = 0xA30
                m_nMaxConstraintPasses = 0xEA0
            class C_OP_BoxConstraint:
                m_nCP = 0xF90
                m_vecMax = 0x8B8
                m_vecMin = 0x1E0
                m_bLocalSpace = 0xF94
                m_bAccountForRadius = 0xF95
            class C_OP_ClientPhysics:
                m_bDeleteSim = 0x53A
                m_bStartAsleep = 0x238
                m_nForcedSimId = 0x540
                m_nControlPoint = 0x53C
                m_bKillParticles = 0x539
                m_strPhysicsType = 0x230
                m_nColorBlendType = 0x544
                m_nMaxParticleCount = 0x534
                m_flPlayerWakeRadius = 0x240
                m_flVehicleWakeRadius = 0x3B8
                m_nForcedStatusEffects = 0x548
                m_nNoCollisionAttribute = 0x54C
                m_nZeroGravityAttribute = 0x550
                m_bRespectExclusionVolumes = 0x538
                m_bUseHighQualitySimulation = 0x530
            class C_OP_FadeOutSimple:
                m_nFieldOutput = 0x1E4
                m_flFadeOutTime = 0x1E0
            class C_OP_QuantizeFloat:
                m_InputValue = 0x1E0
                m_nOutputField = 0x358
            class C_OP_RenderSprites:
                m_bOutline = 0x37CC
                m_flMaxSize = 0x31D8
                m_flMinSize = 0x3060
                m_bSoftEdges = 0x37C1
                m_OutlineColor = 0x37D0
                m_flEndFadeDot = 0x37BC
                m_flEndFadeSize = 0x3640
                m_flOutlineEnd0 = 0x37E0
                m_flOutlineEnd1 = 0x37E4
                m_nLightingMode = 0x37E8
                m_nOutlineAlpha = 0x37D4
                m_bDistanceAlpha = 0x37C0
                m_flStartFadeDot = 0x37B8
                m_flOutlineStart0 = 0x37D8
                m_flOutlineStart1 = 0x37DC
                m_flShadowDensity = 0x41BC
                m_flStartFadeSize = 0x34C8
                m_bParticleShadows = 0x41B8
                m_nOrientationType = 0x3054
                m_flEdgeSoftnessEnd = 0x37C8
                m_flSubPixelAAScale = 0x3350
                m_nSequenceOverride = 0x2ED8
                m_flEdgeSoftnessStart = 0x37C4
                m_vecLightingOverride = 0x37F0
                m_flLightingTessellation = 0x3EC8
                m_bUseYawWithNormalAligned = 0x305C
                m_flLightingDirectionality = 0x4040
                m_nOrientationControlPoint = 0x3058
                m_bSequenceNumbersAreRawSequenceIndices = 0x3050
            class C_OP_SetCPtoVector:
                m_nCPInput = 0x1E0
                m_nFieldOutput = 0x1E4
            class C_OP_VelocityDecay:
                m_flMinVelocity = 0x1E0
            class MaterialVariable_t:
                m_flScale = 0xC
                m_strVariable = 0x0
                m_nVariableField = 0x8
            class CPulseCell_BaseFlow:
                pass
            class CPulseCell_BaseLerp:
                m_WakeResume = 0xD8
            class CPulseCell_Timeline:
                m_OnFinished = 0xF8
                m_TimelineEvents = 0xD8
                m_bWaitForChildOutflows = 0xF0
            class C_INIT_CreateOnGrid:
                m_bCenter = 0xABD
                m_bHollow = 0xABE
                m_nXCount = 0x1E8
                m_nYCount = 0x360
                m_nZCount = 0x4D8
                m_nXSpacing = 0x650
                m_nYSpacing = 0x7C8
                m_nZSpacing = 0x940
                m_bLocalSpace = 0xABC
                m_nControlPointNumber = 0xAB8
            class C_INIT_DistanceCull:
                m_flDistance = 0x1F0
                m_bCullInside = 0x368
                m_nControlPoint = 0x1E8
            class C_INIT_NormalOffset:
                m_OffsetMax = 0x1F4
                m_OffsetMin = 0x1E8
                m_bNormalize = 0x205
                m_bLocalCoords = 0x204
                m_nControlPointNumber = 0x200
            class C_INIT_PositionWarp:
                m_bUseCount = 0xFB1
                m_flWarpTime = 0xFA4
                m_vecWarpMax = 0x8C0
                m_vecWarpMin = 0x1E8
                m_bInvertWarp = 0xFB0
                m_flPrevPosScale = 0xFAC
                m_flWarpStartTime = 0xFA8
                m_nRadiusComponent = 0xFA0
                m_nControlPointNumber = 0xF9C
                m_nScaleControlPointNumber = 0xF98
            class C_INIT_RandomRadius:
                m_flRadiusMax = 0x1EC
                m_flRadiusMin = 0x1E8
                m_flRadiusRandExponent = 0x1F0
            class C_INIT_RandomScalar:
                m_flMax = 0x1EC
                m_flMin = 0x1E8
                m_flExponent = 0x1F0
                m_nFieldOutput = 0x1F4
            class C_INIT_RandomVector:
                m_vecMax = 0x1F4
                m_vecMin = 0x1E8
                m_nFieldOutput = 0x200
                m_randomnessParameters = 0x204
            class C_INIT_StatusEffect:
                m_nDetail2Combo = 0x1E8
                m_rimLightColor = 0x21C
                m_specularColor = 0x208
                m_flAmbientScale = 0x204
                m_flDetail2Scale = 0x1F0
                m_flRimLightScale = 0x220
                m_flSpecularScale = 0x20C
                m_flDetail2Rotation = 0x1EC
                m_flEnvMapIntensity = 0x200
                m_flSpecularExponent = 0x210
                m_flColorWarpIntensity = 0x1F8
                m_flDetail2BlendFactor = 0x1F4
                m_flSpecularBlendToFull = 0x218
                m_flMetalnessBlendToFull = 0x228
                m_flSelfIllumBlendToFull = 0x22C
                m_flDiffuseWarpBlendToFull = 0x1FC
                m_flSpecularExponentBlendToFull = 0x214
                m_flReflectionsTintByBaseBlendToNone = 0x224
            class C_OP_ColorAdjustHSL:
                m_flHueAdjust = 0x1E0
                m_flLightnessAdjust = 0x4D0
                m_flSaturationAdjust = 0x358
            class C_OP_CurlNoiseForce:
                m_vecOffset = 0xFA8
                m_nNoiseType = 0x1F0
                m_flWorleySeed = 0x1D58
                m_vecNoiseFreq = 0x1F8
                m_vecNoiseScale = 0x8D0
                m_vecOffsetRate = 0x1680
                m_flWorleyJitter = 0x1ED0
            class C_OP_DecayOffscreen:
                m_flOffscreenTime = 0x1E0
            class C_OP_ParentVortices:
                m_flForceScale = 0x1F0
                m_vecTwistAxis = 0x1F4
                m_bFlipBasedOnYaw = 0x200
            class C_OP_RemapSpeedtoCP:
                m_nField = 0x1F0
                m_bUseDeltaV = 0x204
                m_flInputMax = 0x1F8
                m_flInputMin = 0x1F4
                m_flOutputMax = 0x200
                m_flOutputMin = 0x1FC
                m_nInControlPointNumber = 0x1E8
                m_nOutControlPointNumber = 0x1EC
            class C_OP_RenderAsModels:
                m_ModelList = 0x230
                m_flModelScale = 0x24C
                m_nSizeCullBloat = 0x260
                m_bFitToModelSize = 0x250
                m_bNonUniformScaling = 0x251
                m_nXAxisScalingAttribute = 0x254
                m_nYAxisScalingAttribute = 0x258
                m_nZAxisScalingAttribute = 0x25C
            class C_OP_SetGravityToCP:
                m_flScale = 0x1F0
                m_nCPInput = 0x1E8
                m_bSetZDown = 0x36A
                m_nCPOutput = 0x1EC
                m_bSetPosition = 0x368
                m_bSetOrientation = 0x369
            class IParticleCollection:
                pass
            class CBaseRendererSource2:
                m_bRefract = 0x2268
                m_nFogType = 0x1C74
                m_bTintByFOW = 0x1DF0
                m_flDepthBias = 0x2AE0
                m_flFogAmount = 0x1C78
                m_flRollScale = 0x520
                m_nShaderType = 0xD7C
                m_nSortMethod = 0x2C58
                m_flAlphaScale = 0x3A8
                m_nAlpha2Field = 0x698
                m_bAnimateInFPS = 0x1098
                m_bRefractSolid = 0x2269
                m_flRadiusScale = 0x230
                m_stencilTestID = 0x23F4
                m_vecColorScale = 0x6A0
                m_flBumpStrength = 0x1078
                m_flDesaturation = 0x1980
                m_flDiffuseClamp = 0x1680
                m_nAnimationType = 0x1094
                m_stencilWriteID = 0x2475
                m_bRefract2Passes = 0x226A
                m_flAddSelfAmount = 0x1808
                m_flAnimationRate = 0x1090
                m_flCenterXOffset = 0xD88
                m_flCenterYOffset = 0xF00
                m_flDiffuseAmount = 0x1508
                m_flRefractAmount = 0x2270
                m_nColorBlendType = 0xD78
                m_nFeatheringMode = 0x24FC
                m_bBlendFramesSeq0 = 0x2C5C
                m_nOutputBlendMode = 0x17FC
                m_nRefractBlurType = 0x23EC
                m_vecTexturesInput = 0x1080
                m_flSelfIllumAmount = 0x1390
                m_strShaderOverride = 0xD80
                m_bDisableZBuffering = 0x24F8
                m_bReverseZBuffering = 0x24F7
                m_bTintByGlobalLight = 0x1DF1
                m_flFeatheringFilter = 0x27F0
                m_flOverbrightFactor = 0x1AF8
                m_nRefractBlurRadius = 0x23E8
                m_bStencilTestExclude = 0x2474
                m_flFeatheringMaxDist = 0x2678
                m_flFeatheringMinDist = 0x2500
                m_nAlphaReferenceType = 0x1DFC
                m_flMotionVectorScaleU = 0x10A0
                m_flMotionVectorScaleV = 0x1218
                m_nCropTextureOverride = 0x107C
                m_nHSVShiftControlPoint = 0x1C70
                m_nLightingControlPoint = 0x17F8
                m_bWriteStencilOnDepthFail = 0x24F6
                m_bWriteStencilOnDepthPass = 0x24F5
                m_flAlphaReferenceSoftness = 0x1E00
                m_bGammaCorrectVertexColors = 0x1800
                m_flFeatheringDepthMapFilter = 0x2968
                m_nPerParticleAlphaRefWindow = 0x1DF8
                m_nPerParticleAlphaReference = 0x1DF4
                m_bSaturateColorPreAlphaBlend = 0x1801
                m_bUseMixedResolutionRendering = 0x23F2
                m_flSourceAlphaValueToMapToOne = 0x20F0
                m_bOnlyRenderInEffectsBloomPass = 0x23F0
                m_bOnlyRenderInEffectsWaterPass = 0x23F1
                m_flSourceAlphaValueToMapToZero = 0x1F78
                m_bMaxLuminanceBlendingSequence0 = 0x2C5D
                m_bOnlyRenderInEffecsGameOverlay = 0x23F3
            class CPulseCell_BaseState:
                pass
            class CPulseCell_BaseValue:
                pass
            class CPulse_InvokeBinding:
                m_FuncName = 0x30
                m_nSrcChunk = 0x44
                m_nCellIndex = 0x40
                m_RegisterMap = 0x0
                m_nSrcInstruction = 0x48
            class C_INIT_CreateFromCPs:
                m_nMaxCP = 0x1F0
                m_nMinCP = 0x1EC
                m_nIncrement = 0x1E8
                m_nDynamicCPCount = 0x1F8
            class C_INIT_CreateOnModel:
                m_bUseMesh = 0x1272
                m_bUseBones = 0x1271
                m_modelInput = 0x1E8
                m_flShellSize = 0x1278
                m_bLocalCoords = 0x1270
                m_HitboxSetName = 0x11F0
                m_nForceInModel = 0x2B0
                m_bScaleToVolume = 0x2B4
                m_flBoneVelocity = 0xB10
                m_nDesiredHitbox = 0x2B8
                m_transformInput = 0x248
                m_vecHitBoxScale = 0x438
                m_vecDirectionBias = 0xB18
                m_bEvenDistribution = 0x2B5
                m_flMaxBoneVelocity = 0xB14
                m_nHitboxValueFromControlPointIndex = 0x430
            class C_INIT_CreationNoise:
                m_bAbsVal = 0x1EC
                m_flOffset = 0x1F0
                m_bAbsValInv = 0x1ED
                m_flOutputMax = 0x1F8
                m_flOutputMin = 0x1F4
                m_flNoiseScale = 0x1FC
                m_nFieldOutput = 0x1E8
                m_vecOffsetLoc = 0x204
                m_flNoiseScaleLoc = 0x200
                m_flWorldTimeScale = 0x210
            class C_INIT_QuantizeFloat:
                m_InputValue = 0x1E8
                m_nOutputField = 0x360
            class C_INIT_RandomYawFlip:
                m_flPercent = 0x1E8
            class C_INIT_ScaleVelocity:
                m_vecScale = 0x1E8
            class C_OP_CPVelocityForce:
                m_flScale = 0x1F8
                m_nControlPointNumber = 0x1F0
            class C_OP_CollideWithSelf:
                m_flRadiusScale = 0x1E0
                m_flMinimumSpeed = 0x358
            class C_OP_DecayClampCount:
                m_nCount = 0x1E0
            class C_OP_GameLiquidSpill:
                m_flRadius = 0x520
                m_flExpirationTime = 0x3A8
                m_nAmountAttribute = 0x69C
                m_bCheckExposedToSky = 0x698
                m_flLiquidContentsField = 0x230
            class C_OP_LagCompensation:
                m_nLatencyCP = 0x1E4
                m_nLatencyCPField = 0x1E8
                m_nDesiredVelocityCP = 0x1E0
                m_nDesiredVelocityCPField = 0x1EC
            class C_OP_LockToPointList:
                m_pointList = 0x1E8
                m_bClosedLoop = 0x201
                m_nFieldOutput = 0x1E0
                m_bPlaceAlongPath = 0x200
                m_nNumPointsAlongPath = 0x204
            class C_OP_MaintainEmitter:
                m_flScale = 0x4F8
                m_flStartTime = 0x360
                m_flEmissionRate = 0x4E0
                m_bFinalEmitOnStop = 0x4F1
                m_strSnapshotSubset = 0x4E8
                m_flEmissionDuration = 0x368
                m_bEmitInstantaneously = 0x4F0
                m_nParticlesToMaintain = 0x1E8
                m_nSnapshotControlPoint = 0x4E4
            class C_OP_NormalizeVector:
                m_flScale = 0x1E4
                m_nFieldOutput = 0x1E0
            class C_OP_Orient2DRelToCP:
                m_nCP = 0x1E8
                m_flRotOffset = 0x1E0
                m_nFieldOutput = 0x1EC
                m_flSpinStrength = 0x1E4
            class C_OP_OscillateScalar:
                m_nField = 0x1F0
                m_RateMax = 0x1E4
                m_RateMin = 0x1E0
                m_flOscAdd = 0x20C
                m_flOscMult = 0x208
                m_FrequencyMax = 0x1EC
                m_FrequencyMin = 0x1E8
                m_bProportional = 0x1F4
                m_flEndTime_max = 0x204
                m_flEndTime_min = 0x200
                m_bProportionalOp = 0x1F5
                m_flStartTime_max = 0x1FC
                m_flStartTime_min = 0x1F8
            class C_OP_OscillateVector:
                m_nField = 0x210
                m_RateMax = 0x1EC
                m_RateMin = 0x1E0
                m_bOffset = 0x216
                m_flOscAdd = 0x3A0
                m_flOscMult = 0x228
                m_flRateScale = 0x518
                m_FrequencyMax = 0x204
                m_FrequencyMin = 0x1F8
                m_bProportional = 0x214
                m_flEndTime_max = 0x224
                m_flEndTime_min = 0x220
                m_bProportionalOp = 0x215
                m_flStartTime_max = 0x21C
                m_flStartTime_min = 0x218
            class C_OP_PinParticleToCP:
                m_flAge = 0xD38
                m_vecOffset = 0x1E8
                m_bOffsetLocal = 0x8C0
                m_flBreakSpeed = 0xBC0
                m_flBreakValue = 0xEB8
                m_nPinBreakType = 0xA40
                m_flBreakDistance = 0xA48
                m_flInterpolation = 0x1030
                m_nParticleNumber = 0x8C8
                m_nParticleSelection = 0x8C4
                m_nControlPointNumber = 0x1E0
                m_bRetainInitialVelocity = 0x11A8
                m_nBreakControlPointNumber = 0xEB0
                m_nBreakControlPointNumber2 = 0xEB4
            class C_OP_RemapCPtoScalar:
                m_nField = 0x1E8
                m_nCPInput = 0x1E0
                m_flEndTime = 0x200
                m_flInputMax = 0x1F0
                m_flInputMin = 0x1EC
                m_nSetMethod = 0x208
                m_flOutputMax = 0x1F8
                m_flOutputMin = 0x1F4
                m_flStartTime = 0x1FC
                m_flInterpRate = 0x204
                m_nFieldOutput = 0x1E4
            class C_OP_RemapCPtoVector:
                m_bOffset = 0x22C
                m_nCPInput = 0x1E0
                m_flEndTime = 0x220
                m_vInputMax = 0x1F8
                m_vInputMin = 0x1EC
                m_nSetMethod = 0x228
                m_vOutputMax = 0x210
                m_vOutputMin = 0x204
                m_bAccelerate = 0x22D
                m_flStartTime = 0x21C
                m_flInterpRate = 0x224
                m_nFieldOutput = 0x1E4
                m_nLocalSpaceCP = 0x1E8
            class C_OP_RemapVectortoCP:
                m_nFieldInput = 0x1E4
                m_nParticleNumber = 0x1E8
                m_nOutControlPointNumber = 0x1E0
            class C_OP_RenderLightBeam:
                m_flRange = 0x1080
                m_flSkirt = 0xF08
                m_flThickness = 0x11F8
                m_nMaxAllowed = 0x230
                m_vColorBlend = 0x238
                m_bCastShadows = 0xD88
                m_flBounceScale = 0xD90
                m_strLightStyle = 0x918
                m_bDynamicBounce = 0xD89
                m_flRenderFilter = 0x1EB8
                m_nColorBlendType = 0x910
                m_flInnerConeAngle = 0x1370
                m_flLightStyleTime = 0x920
                m_flOuterConeAngle = 0x14E8
                m_nFogLightingMode = 0x1D38
                m_bDebugOrientation = 0x2030
                m_flFogContribution = 0x1D40
                m_vecConeRotationOffset = 0x1660
                m_flNumberOfLightsToCreate = 0xC10
                m_flBrightnessLumensPerMeter = 0xA98
            class C_OP_RenderProjected:
                m_flRollScale = 0x6E0
                m_MaterialVars = 0x3D8
                m_flAlphaScale = 0x568
                m_nAlpha2Field = 0x858
                m_bProjectWater = 0x232
                m_bProjectWorld = 0x231
                m_flRadiusScale = 0x3F0
                m_vecColorScale = 0x860
                m_bFlipHorizontal = 0x233
                m_bOrientToNormal = 0x3D4
                m_nColorBlendType = 0xF38
                m_bProjectCharacter = 0x230
                m_flMaterialSelection = 0x258
                m_flAnimationTimeScale = 0x3D0
                m_flMaxProjectionDepth = 0x23C
                m_flMinProjectionDepth = 0x238
                m_vecProjectedMaterials = 0x240
                m_bEnableProjectedDepthControls = 0x234
            class C_OP_RenderTreeShake:
                m_flRadius = 0x238
                m_flTwistAmount = 0x248
                m_flPeakStrength = 0x230
                m_flRadialAmount = 0x24C
                m_flShakeDuration = 0x240
                m_flTransitionTime = 0x244
                m_nRadiusFieldOverride = 0x23C
                m_nPeakStrengthFieldOverride = 0x234
                m_flControlPointOrientationAmount = 0x250
                m_nControlPointForLinearDirection = 0x254
            class C_OP_TurbulenceForce:
                m_vecNoiseAmount0 = 0x200
                m_vecNoiseAmount1 = 0x20C
                m_vecNoiseAmount2 = 0x218
                m_vecNoiseAmount3 = 0x224
                m_flNoiseCoordScale0 = 0x1F0
                m_flNoiseCoordScale1 = 0x1F4
                m_flNoiseCoordScale2 = 0x1F8
                m_flNoiseCoordScale3 = 0x1FC
            class C_OP_TwistAroundAxis:
                m_TwistAxis = 0x1F4
                m_bLocalSpace = 0x200
                m_fForceAmount = 0x1F0
                m_nControlPointNumber = 0x204
            class CPulseCell_LimitCount:
                m_nLimitCount = 0x48
            class C_INIT_PositionOffset:
                m_OffsetMax = 0x8C0
                m_OffsetMin = 0x1E8
                m_bLocalCoords = 0x1000
                m_bProportional = 0x1001
                m_TransformInput = 0xF98
                m_randomnessParameters = 0x1004
            class C_INIT_RandomLifeTime:
                m_fLifetimeMax = 0x1EC
                m_fLifetimeMin = 0x1E8
                m_fLifetimeRandExponent = 0x1F0
            class C_INIT_RandomRotation:
                pass
            class C_INIT_RandomSequence:
                m_bLinear = 0x1F1
                m_bShuffle = 0x1F0
                m_WeightedList = 0x1F8
                m_nSequenceMax = 0x1EC
                m_nSequenceMin = 0x1E8
            class C_INIT_SequenceFromCP:
                m_nCP = 0x1EC
                m_vecOffset = 0x1F0
                m_bKillUnused = 0x1E8
                m_bRadiusScale = 0x1E9
            class C_INIT_StatusEffectTf:
                m_flSFXSScale = 0x1FC
                m_nDetailCombo = 0x218
                m_flSFXSOffsetX = 0x20C
                m_flSFXSOffsetY = 0x210
                m_flSFXSOffsetZ = 0x214
                m_flSFXSScrollX = 0x200
                m_flSFXSScrollY = 0x204
                m_flSFXSScrollZ = 0x208
                m_flSFXEnvMapAmount = 0x234
                m_flSFXNormalAmount = 0x1EC
                m_flSFXSDetailScale = 0x220
                m_flSFXSUseModelUVs = 0x230
                m_flSFXSDetailAmount = 0x21C
                m_flSFXSDetailScrollX = 0x224
                m_flSFXSDetailScrollY = 0x228
                m_flSFXSDetailScrollZ = 0x22C
                m_flSFXColorWarpAmount = 0x1E8
                m_flSFXMetalnessAmount = 0x1F0
                m_flSFXRoughnessAmount = 0x1F4
                m_flSFXSelfIllumAmount = 0x1F8
            class C_INIT_VelocityFromCP:
                m_velocityInput = 0x1E8
                m_bDirectionOnly = 0x92C
                m_transformInput = 0x8C0
                m_flVelocityScale = 0x928
            class C_INIT_VelocityRandom:
                m_bIgnoreDT = 0x1290
                m_fSpeedMax = 0x368
                m_fSpeedMin = 0x1F0
                m_nControlPointNumber = 0x1E8
                m_randomnessParameters = 0x1294
                m_LocalCoordinateSystemSpeedMax = 0xBB8
                m_LocalCoordinateSystemSpeedMin = 0x4E0
            class C_OP_ColorInterpolate:
                m_ColorFade = 0x1E0
                m_bEaseInOut = 0x1FC
                m_nFieldOutput = 0x1F8
                m_flFadeEndTime = 0x1F4
                m_flFadeStartTime = 0x1F0
            class C_OP_EndCapTimedDecay:
                m_flDecayTime = 0x1E0
            class C_OP_LerpEndCapScalar:
                m_flOutput = 0x1E4
                m_flLerpTime = 0x1E8
                m_nFieldOutput = 0x1E0
            class C_OP_LerpEndCapVector:
                m_vecOutput = 0x1E4
                m_flLerpTime = 0x1F0
                m_nFieldOutput = 0x1E0
            class C_OP_PerParticleForce:
                m_nCP = 0xA40
                m_vForce = 0x368
                m_flForceScale = 0x1F0
            class C_OP_PlanarConstraint:
                m_PlaneNormal = 0x1EC
                m_bUseOldCode = 0x4F0
                m_PointOnPlane = 0x1E0
                m_bGlobalNormal = 0x1FD
                m_bGlobalOrigin = 0x1FC
                m_flRadiusScale = 0x200
                m_nControlPointNumber = 0x1F8
                m_flMaximumDistanceToCP = 0x378
            class C_OP_RampScalarLinear:
                m_nField = 0x220
                m_RateMax = 0x1E4
                m_RateMin = 0x1E0
                m_flEndTime_max = 0x1F4
                m_flEndTime_min = 0x1F0
                m_bProportionalOp = 0x224
                m_flStartTime_max = 0x1EC
                m_flStartTime_min = 0x1E8
            class C_OP_RampScalarSpline:
                m_flBias = 0x1F8
                m_nField = 0x220
                m_RateMax = 0x1E4
                m_RateMin = 0x1E0
                m_bEaseOut = 0x225
                m_flEndTime_max = 0x1F4
                m_flEndTime_min = 0x1F0
                m_bProportionalOp = 0x224
                m_flStartTime_max = 0x1EC
                m_flStartTime_min = 0x1E8
            class C_OP_RenderClothForce:
                pass
            class C_OP_RenderOmni2Light:
                m_bFog = 0xF10
                m_flRange = 0x2A08
                m_flSkirt = 0x2890
                m_vNormal = 0x1210
                m_vTarget = 0x18E8
                m_flFOVAngle = 0x1FC0
                m_flFogScale = 0xF18
                m_nLightType = 0x230
                m_flBarnShape = 0x2138
                m_flBarnSoftX = 0x25A0
                m_flBarnSoftY = 0x2718
                m_nMaxAllowed = 0x234
                m_vColorBlend = 0x238
                m_bCastShadows = 0xD90
                m_hLightCookie = 0x2E70
                m_flBounceScale = 0xD98
                m_strLightStyle = 0x918
                m_bDynamicBounce = 0xD91
                m_flBarnNearSizeX = 0x22B0
                m_flBarnNearSizeY = 0x2428
                m_nBrightnessUnit = 0xA98
                m_nColorBlendType = 0x910
                m_bSphericalCookie = 0x2E78
                m_flInnerConeAngle = 0x2B80
                m_flLightStyleTime = 0x920
                m_flOuterConeAngle = 0x2CF8
                m_nOrientationType = 0x1208
                m_flLuminaireRadius = 0x1090
                m_flBrightnessLumens = 0xAA0
                m_flBrightnessCandelas = 0xC18
            class C_OP_TimeVaryingForce:
                m_EndingForce = 0x204
                m_StartingForce = 0x1F4
                m_flEndLerpTime = 0x200
                m_flStartLerpTime = 0x1F0
            class CGeneralRandomRotation:
                m_flDegrees = 0x1EC
                m_flDegreesMax = 0x1F4
                m_flDegreesMin = 0x1F0
                m_nFieldOutput = 0x1E8
                m_bRandomlyFlipDirection = 0x1FC
                m_flRotationRandExponent = 0x1F8
            class CParticleFunctionForce:
                pass
            class CPulseCell_CursorQueue:
                m_nCursorsAllowedToRunParallel = 0x128
            class CPulseCell_FireCursors:
                m_Outflows = 0xD8
                m_OnFinished = 0xF8
                m_bWaitForChildOutflows = 0xF0
            class CPulseCell_Inflow_Wait:
                m_WakeResume = 0xD8
            class CPulseCell_RaceCursors:
                m_Outflows = 0xD8
                m_OnFinished = 0xF0
            class CPulseCell_Value_Curve:
                m_Curve = 0x48
            class C_INIT_CreateAlongPath:
                m_fT = 0x360
                m_PathParams = 0x4E0
                m_vEndOffset = 0x524
                m_bSaveOffset = 0x530
                m_fMaxDistance = 0x1E8
                m_bUseRandomCPs = 0x520
            class C_INIT_CreateWithinBox:
                m_vecMax = 0x8C0
                m_vecMin = 0x1E8
                m_bLocalSpace = 0xF9C
                m_bUseNewCode = 0xFA8
                m_nControlPointNumber = 0xF98
                m_randomnessParameters = 0xFA0
            class C_INIT_InheritVelocity:
                m_flVelocityScale = 0x1EC
                m_nControlPointNumber = 0x1E8
            class C_INIT_NormalAlignToCP:
                m_transformInput = 0x1E8
                m_nControlPointAxis = 0x250
            class C_INIT_Orient2DRelToCP:
                m_nCP = 0x1E8
                m_flRotOffset = 0x1F0
                m_nFieldOutput = 0x1EC
            class C_OP_ConstrainDistance:
                m_CenterOffset = 0x538
                m_fMaxDistance = 0x358
                m_fMinDistance = 0x1E0
                m_bGlobalCenter = 0xC10
                m_nControlPointNumber = 0x4D0
            class C_OP_ContinuousEmitter:
                m_flEmitRate = 0x4D8
                m_nEventType = 0x65C
                m_flStartTime = 0x360
                m_flEmissionScale = 0x650
                m_nLimitPerUpdate = 0x670
                m_strSnapshotSubset = 0x668
                m_flEmissionDuration = 0x1E8
                m_nSnapshotControlPoint = 0x660
                m_bForceEmitOnLastUpdate = 0x675
                m_bForceEmitOnFirstUpdate = 0x674
                m_flScalePerParentParticle = 0x654
                m_bInitFromKilledParentParticles = 0x658
            class C_OP_ControlpointLight:
                m_flScale = 0x1E0
                m_bUseNormal = 0x6E8
                m_LightColor1 = 0x6D0
                m_LightColor2 = 0x6D4
                m_LightColor3 = 0x6D8
                m_LightColor4 = 0x6DC
                m_bLightType1 = 0x6E0
                m_bLightType2 = 0x6E1
                m_bLightType3 = 0x6E2
                m_bLightType4 = 0x6E3
                m_bUseHLambert = 0x6E9
                m_vecCPOffset1 = 0x680
                m_vecCPOffset2 = 0x68C
                m_vecCPOffset3 = 0x698
                m_vecCPOffset4 = 0x6A4
                m_LightZeroDist1 = 0x6B4
                m_LightZeroDist2 = 0x6BC
                m_LightZeroDist3 = 0x6C4
                m_LightZeroDist4 = 0x6CC
                m_bLightDynamic1 = 0x6E4
                m_bLightDynamic2 = 0x6E5
                m_bLightDynamic3 = 0x6E6
                m_bLightDynamic4 = 0x6E7
                m_nControlPoint1 = 0x670
                m_nControlPoint2 = 0x674
                m_nControlPoint3 = 0x678
                m_nControlPoint4 = 0x67C
                m_LightFiftyDist1 = 0x6B0
                m_LightFiftyDist2 = 0x6B8
                m_LightFiftyDist3 = 0x6C0
                m_LightFiftyDist4 = 0x6C8
                m_bClampLowerRange = 0x6EE
                m_bClampUpperRange = 0x6EF
            class C_OP_EndCapTimedFreeze:
                m_flFreezeTime = 0x1E0
            class C_OP_ExternalWindForce:
                m_vecScale = 0x8C8
                m_bSampleWind = 0xFA0
                m_bSampleWater = 0xFA1
                m_bSampleGravity = 0xFA3
                m_vecGravityForce = 0xFA8
                m_vecBuoyancyForce = 0x1978
                m_vecSamplePosition = 0x1F0
                m_flLocalGravityScale = 0x1688
                m_flLocalBuoyancyScale = 0x1800
                m_bDampenNearWaterPlane = 0xFA2
                m_bUseBasicMovementGravity = 0x1680
            class C_OP_GameDecalRenderer:
                m_vecEndPos = 0x928
                m_nEventType = 0x238
                m_flDecalSize = 0x1178
                m_vecStartPos = 0x250
                m_flTraceBloat = 0x1000
                m_flDecalRotation = 0x1468
                m_nCollisionGroup = 0x248
                m_sDecalGroupName = 0x230
                m_bNoDecalsOnOwner = 0x1CBB
                m_bVisualizeTraces = 0x1CBC
                m_nDecalGroupIndex = 0x12F0
                m_nInteractionMask = 0x240
                m_vModulationColor = 0x15E0
                m_bRandomDecalRotation = 0x1CB9
                m_bUseGameDefaultDecalSize = 0x1CB8
                m_bRandomlySelectDecalInGroup = 0x1CBA
            class C_OP_InterpolateRadius:
                m_flBias = 0x1F4
                m_flEndTime = 0x1E4
                m_flEndScale = 0x1EC
                m_flStartTime = 0x1E0
                m_flStartScale = 0x1E8
                m_bEaseInAndOut = 0x1F0
            class C_OP_RemapScalarEndCap:
                m_flInputMax = 0x1EC
                m_flInputMin = 0x1E8
                m_flOutputMax = 0x1F4
                m_flOutputMin = 0x1F0
                m_nFieldInput = 0x1E0
                m_nFieldOutput = 0x1E4
            class C_OP_RenderGpuImplicit:
                m_nScaleCP = 0x6A8
                m_fGridSize = 0x240
                m_hMaterial = 0x6B0
                m_fRadiusScale = 0x3B8
                m_nIndexCountKb = 0x238
                m_nVertexCountKb = 0x234
                m_fIsosurfaceThreshold = 0x530
                m_bUsePerParticleRadius = 0x230
            class C_OP_RenderScreenShake:
                m_nFilterCP = 0x250
                m_nRadiusField = 0x240
                m_flRadiusScale = 0x234
                m_nDurationField = 0x244
                m_flDurationScale = 0x230
                m_nAmplitudeField = 0x24C
                m_nFrequencyField = 0x248
                m_flAmplitudeScale = 0x23C
                m_flFrequencyScale = 0x238
            class C_OP_SequenceFromModel:
                m_flInputMax = 0x1F0
                m_flInputMin = 0x1EC
                m_nSetMethod = 0x1FC
                m_flOutputMax = 0x1F8
                m_flOutputMin = 0x1F4
                m_nFieldOutput = 0x1E4
                m_nFieldOutputAnim = 0x1E8
                m_nControlPointNumber = 0x1E0
            class C_OP_SetFromCPSnapshot:
                m_bPrev = 0x671
                m_bRandom = 0x1FC
                m_bReverse = 0x1FD
                m_bSubSample = 0x670
                m_nRandomSeed = 0x200
                m_nLocalSpaceCP = 0x1F8
                m_flInterpolation = 0x4F8
                m_nAttributeToRead = 0x1F0
                m_nAttributeToWrite = 0x1F4
                m_strSnapshotSubset = 0x1E8
                m_nSnapShotIncrement = 0x380
                m_nControlPointNumber = 0x1E0
                m_nSnapShotStartPoint = 0x208
            class C_OP_SetSimulationRate:
                m_flSimulationScale = 0x1E8
            class C_OP_UpdateLightSource:
                m_vColorTint = 0x1E0
                m_flRadiusScale = 0x1E8
                m_flBrightnessScale = 0x1E4
                m_flMaximumLightingRadius = 0x1F0
                m_flMinimumLightingRadius = 0x1EC
                m_flPositionDampingConstant = 0x1F4
            class ParticleChildrenInfo_t:
                m_bEndCap = 0xC
                m_flDelay = 0x8
                m_ChildRef = 0x0
                m_nDetailLevel = 0x10
                m_bDisableChild = 0xD
            class ParticlePreviewState_t:
                m_groundType = 0xC
                m_previewModel = 0x0
                m_sequenceName = 0x10
                m_hitboxSetName = 0x20
                m_vecBodyGroups = 0x30
                m_vecPreviewWind = 0x64
                m_flPlaybackSpeed = 0x48
                m_nModSpecificData = 0x8
                m_materialGroupName = 0x28
                m_vecPreviewGravity = 0x58
                m_bShouldDrawHitboxes = 0x50
                m_bAnimationNonLooping = 0x54
                m_bShouldDrawAttachments = 0x51
                m_flParticleSimulationRate = 0x4C
                m_bShouldDrawAttachmentNames = 0x52
                m_bSequenceNameIsAnimClipPath = 0x55
                m_bShouldDrawControlPointAxes = 0x53
                m_nFireParticleOnSequenceFrame = 0x18
            class SequenceWeightedList_t:
                m_nSequence = 0x0
                m_flRelativeWeight = 0x4
            class CBasePulseGraphInstance:
                pass
            class CPulseCell_Inflow_Yield:
                m_UnyieldResume = 0xD8
            class CPulseCell_ReturnValues:
                pass
            class C_INIT_ChaoticAttractor:
                m_flAParm = 0x1E8
                m_flBParm = 0x1EC
                m_flCParm = 0x1F0
                m_flDParm = 0x1F4
                m_flScale = 0x1F8
                m_nBaseCP = 0x204
                m_flSpeedMax = 0x200
                m_flSpeedMin = 0x1FC
                m_bUniformSpeed = 0x208
            class C_INIT_CreateWithinCone:
                m_flSpeed = 0x540
                m_flOffset = 0x6B8
                m_flInnerAngle = 0x250
                m_flOuterAngle = 0x3C8
                m_TransformInput = 0x1E8
                m_bCollapseOffset = 0x830
                m_randomnessParameters = 0x834
            class C_INIT_DistanceToCPInit:
                m_bLOS = 0x7D4
                m_nStartCP = 0x7D0
                m_nTraceSet = 0x858
                m_flInputMax = 0x368
                m_flInputMin = 0x1F0
                m_flLOSScale = 0x9D8
                m_nSetMethod = 0x9DC
                m_flOutputMax = 0x658
                m_flOutputMin = 0x4E0
                m_flRemapBias = 0x9F0
                m_bActiveRange = 0x9E0
                m_nFieldOutput = 0x1E8
                m_flMaxTraceLength = 0x860
                m_vecDistanceScale = 0x9E4
                m_CollisionGroupName = 0x7D5
            class C_INIT_SequenceLifeTime:
                m_flFramerate = 0x1E8
            class C_INIT_SetHitboxToModel:
                m_bUseBones = 0x8DD
                m_flShellSize = 0x960
                m_HitboxSetName = 0x8DE
                m_nForceInModel = 0x1EC
                m_nDesiredHitbox = 0x1F4
                m_vecHitBoxScale = 0x1F8
                m_bMaintainHitbox = 0x8DC
                m_vecDirectionBias = 0x8D0
                m_bEvenDistribution = 0x1F0
                m_nControlPointNumber = 0x1E8
            class C_OP_DecayMaintainCount:
                m_flScale = 0x200
                m_bKillNewest = 0x378
                m_flDecayDelay = 0x1E4
                m_bLifespanDecay = 0x1F8
                m_strSnapshotSubset = 0x1F0
                m_nParticlesToMaintain = 0x1E0
                m_nSnapshotControlPoint = 0x1E8
            class C_OP_IntraParticleForce:
                m_bUseAABB = 0x208
                m_flRepulsionMaxDistance = 0x200
                m_flRepulsionMaxStrength = 0x204
                m_flRepulsionMinDistance = 0x1FC
                m_flAttractionMaxDistance = 0x1F4
                m_flAttractionMaxStrength = 0x1F8
                m_flAttractionMinDistance = 0x1F0
            class C_OP_RampCPLinearRandom:
                m_vecRateMax = 0x1F8
                m_vecRateMin = 0x1EC
                m_nOutControlPointNumber = 0x1E8
            class C_OP_RenderFlattenGrass:
                m_flRadiusScale = 0x238
                m_flFlattenStrength = 0x230
                m_nStrengthFieldOverride = 0x234
            class C_OP_RenderStatusEffect:
                m_pTextureEnvMap = 0x260
                m_pTextureDetail2 = 0x238
                m_pTextureColorWarp = 0x230
                m_pTextureDiffuseWarp = 0x240
                m_pTextureFresnelWarp = 0x250
                m_pTextureSpecularWarp = 0x258
                m_pTextureFresnelColorWarp = 0x248
            class C_OP_SetFloatCollection:
                m_Lerp = 0x360
                m_InputValue = 0x1E0
                m_nSetMethod = 0x35C
                m_nOutputField = 0x358
            class CollisionGroupContext_t:
                m_nCollisionGroupNumber = 0x0
            class ControlPointReference_t:
                m_bOffsetInLocalSpace = 0x10
                m_controlPointNameString = 0x0
                m_vOffsetFromControlPoint = 0x4
            class SignatureOutflow_Resume:
                pass
            class CParticleFunctionEmitter:
                m_nEmitterIndex = 0x1E0
            class CPulseCell_Inflow_Method:
                m_Args = 0xA0
                m_bIsPublic = 0x98
                m_MethodName = 0x80
                m_Description = 0x90
                m_ReturnValues = 0xB0
            class CPulseCell_IntervalTimer:
                m_Completed = 0xD8
                m_OnInterval = 0x120
            class CPulseCell_Step_DebugLog:
                pass
            class CPulse_OutflowConnection:
                m_nDestChunk = 0x10
                m_nInstruction = 0x14
                m_SourceOutflowName = 0x0
                m_OutflowRegisterMap = 0x18
            class C_INIT_AddVectorToVector:
                m_vecScale = 0x1E8
                m_vOffsetMax = 0x208
                m_vOffsetMin = 0x1FC
                m_nFieldInput = 0x1F8
                m_nFieldOutput = 0x1F4
                m_randomnessParameters = 0x214
            class C_INIT_CreatePhyllotaxis:
                m_fMinRad = 0x20C
                m_fRadBias = 0x208
                m_nScaleCP = 0x1EC
                m_fDistBias = 0x210
                m_nComponent = 0x1F0
                m_fpointAngle = 0x200
                m_fRadCentCore = 0x1F4
                m_fRadPerPoint = 0x1F8
                m_fsizeOverall = 0x204
                m_bUseOrigRadius = 0x216
                m_fRadPerPointTo = 0x1FC
                m_bUseLocalCoords = 0x214
                m_bUseWithContEmit = 0x215
                m_nControlPointNumber = 0x1E8
            class C_INIT_InitVecCollection:
                m_InputValue = 0x1E8
                m_nOutputField = 0x8C0
            class C_INIT_MoveBetweenPoints:
                m_bTrailBias = 0x944
                m_flSpeedMax = 0x360
                m_flSpeedMin = 0x1E8
                m_flEndOffset = 0x7C8
                m_flEndSpread = 0x4D8
                m_flStartOffset = 0x650
                m_nEndControlPointNumber = 0x940
            class C_INIT_RandomTrailLength:
                m_flMaxLength = 0x1EC
                m_flMinLength = 0x1E8
                m_flLengthRandExponent = 0x1F0
            class C_OP_ConstrainLineLength:
                m_flMaxDistance = 0x1E4
                m_flMinDistance = 0x1E0
            class C_OP_DistanceBetweenVecs:
                m_vecPoint1 = 0x1E8
                m_vecPoint2 = 0x8C0
                m_bDeltaTime = 0x157C
                m_flInputMax = 0x1110
                m_flInputMin = 0xF98
                m_nSetMethod = 0x1578
                m_flOutputMax = 0x1400
                m_flOutputMin = 0x1288
                m_nFieldOutput = 0x1E0
            class C_OP_DistanceToTransform:
                m_bLOS = 0x830
                m_bAdditive = 0x8C5
                m_nTraceSet = 0x8B4
                m_flInputMax = 0x360
                m_flInputMin = 0x1E8
                m_flLOSScale = 0x8BC
                m_nSetMethod = 0x8C0
                m_flOutputMax = 0x650
                m_flOutputMin = 0x4D8
                m_bActiveRange = 0x8C4
                m_nFieldOutput = 0x1E0
                m_TransformStart = 0x7C8
                m_flMaxTraceLength = 0x8B8
                m_vecComponentScale = 0x8C8
                m_CollisionGroupName = 0x831
            class C_OP_DragRelativeToPlane:
                m_flFalloff = 0x358
                m_bDirectional = 0x4D0
                m_flDragAtPlane = 0x1E0
                m_vecPlaneNormal = 0x4D8
                m_nControlPointNumber = 0xBB0
            class C_OP_ModelDampenMovement:
                m_fDrag = 0x940
                m_bOutside = 0x1E5
                m_bBoundBox = 0x1E4
                m_bUseBones = 0x1E6
                m_vecPosOffset = 0x268
                m_HitboxSetName = 0x1E7
                m_nControlPointNumber = 0x1E0
            class C_OP_OrientTo2dDirection:
                m_vecInput = 0x1E0
                m_flRotOffset = 0x8B8
                m_nFieldOutput = 0x8C0
                m_flSpinStrength = 0x8BC
            class C_OP_QuantizeCPComponent:
                m_nCPOutput = 0x360
                m_flInputValue = 0x1E8
                m_flQuantizeValue = 0x368
                m_nOutVectorField = 0x364
            class C_OP_RemapDotProductToCP:
                m_nInputCP1 = 0x1E8
                m_nInputCP2 = 0x1EC
                m_nOutputCP = 0x1F0
                m_flInputMax = 0x370
                m_flInputMin = 0x1F8
                m_flOutputMax = 0x660
                m_flOutputMin = 0x4E8
                m_nOutVectorField = 0x1F4
            class C_OP_RenderDeferredLight:
                m_hTexture = 0x920
                m_flSpotFoV = 0x940
                m_bUseTexture = 0x91C
                m_flAlphaScale = 0x234
                m_nAlpha2Field = 0x238
                m_flRadiusScale = 0x230
                m_vecColorScale = 0x240
                m_flStartFalloff = 0x938
                m_flLightDistance = 0x934
                m_nColorBlendType = 0x918
                m_flDistanceFalloff = 0x93C
                m_bUseAlphaTestWindow = 0x91D
                m_nAlphaTestPointField = 0x928
                m_nAlphaTestRangeField = 0x92C
                m_nHSVShiftControlPoint = 0x944
                m_nAlphaTestSharpnessField = 0x930
            class C_OP_RenderMaterialProxy:
                m_flAlpha = 0xAA8
                m_nProxyType = 0x234
                m_MaterialVars = 0x238
                m_vecColorScale = 0x3D0
                m_nColorBlendType = 0xC20
                m_hOverrideMaterial = 0x250
                m_nMaterialControlPoint = 0x230
                m_flMaterialOverrideEnabled = 0x258
            class C_OP_RenderStandardLight:
                m_flPhi = 0xF08
                m_flTheta = 0xD90
                m_bIgnoreDT = 0x1810
                m_nPriority = 0x1678
                m_nLightType = 0x230
                m_bClosedLoop = 0x1801
                m_flIntensity = 0xA98
                m_flMaxLength = 0x1808
                m_flMinLength = 0x180C
                m_lightCookie = 0x1670
                m_nMaxAllowed = 0x234
                m_bCastShadows = 0xC10
                m_bReverseOrder = 0x1800
                m_flBounceScale = 0xC18
                m_flLengthScale = 0x1818
                m_strLightStyle = 0x918
                m_vecColorScale = 0x238
                m_bDynamicBounce = 0xC11
                m_bRenderDiffuse = 0x1668
                m_nPrevPntSource = 0x1804
                m_bRenderSpecular = 0x1669
                m_flCapsuleLength = 0x17FC
                m_nColorBlendType = 0x910
                m_flLightStyleTime = 0x920
                m_nFogLightingMode = 0x167C
                m_flFogContribution = 0x1680
                m_nAttenuationStyle = 0x11F8
                m_flFalloffLinearity = 0x1200
                m_flLengthFadeInTime = 0x181C
                m_flRadiusMultiplier = 0x1080
                m_flZeroPercentFalloff = 0x14F0
                m_flFiftyPercentFalloff = 0x1378
                m_nCapsuleLightBehavior = 0x17F8
                m_flConstrainRadiusToLengthRatio = 0x1814
            class C_OP_RenderVRHapticEvent:
                m_nHand = 0x230
                m_flAmplitude = 0x240
                m_nOutputField = 0x238
                m_nOutputHandCP = 0x234
            class C_OP_SnapshotSkinToBones:
                m_flPrevPosScale = 0x1F4
                m_bTransformRadii = 0x1E1
                m_flJumpThreshold = 0x1F0
                m_bTransformNormals = 0x1E0
                m_flLifeTimeFadeEnd = 0x1EC
                m_flLifeTimeFadeStart = 0x1E8
                m_nControlPointNumber = 0x1E4
            class C_OP_StopAfterCPDuration:
                m_flDuration = 0x1E8
                m_bPlayEndCap = 0x361
                m_bDestroyImmediately = 0x360
            class C_OP_VectorFieldSnapshot:
                m_vecScale = 0x368
                m_bSetVelocity = 0xA44
                m_flGridSpacing = 0xA48
                m_nLocalSpaceCP = 0x1E8
                m_bLockToSurface = 0xA45
                m_flInterpolation = 0x1F0
                m_nAttributeToWrite = 0x1E4
                m_flBoundaryDampening = 0xA40
                m_nControlPointNumber = 0x1E0
            class CParticleBindingRealPulse:
                pass
            class CParticleFunctionOperator:
                pass
            class CParticleFunctionRenderer:
                VisibilityInputs = 0x1E0
                m_bCannotBeRefracted = 0x228
            class CParticleSystemDefinition:
                m_Children = 0xB8
                m_Emitters = 0x28
                m_nGroupID = 0x260
                m_Operators = 0x58
                m_Renderers = 0xA0
                m_hFallback = 0x2F8
                m_hSnapshot = 0x2D8
                m_Constraints = 0x88
                m_bShouldSort = 0x378
                m_Initializers = 0x40
                m_bShouldBatch = 0x358
                m_flCullRadius = 0x2E8
                m_nMinCPULevel = 0x338
                m_nMinGPULevel = 0x33C
                m_ConstantColor = 0x2A8
                m_nMaxParticles = 0x25C
                m_BoundingBoxMax = 0x270
                m_BoundingBoxMin = 0x264
                m_ConstantNormal = 0x2AC
                m_flCullFillCost = 0x2EC
                m_nMinimumFrames = 0x330
                m_ForceGenerators = 0x70
                m_bInfiniteBounds = 0x284
                m_flDepthSortBias = 0x27C
                m_hLowViolenceDef = 0x308
                m_NamedValueDomain = 0x288
                m_NamedValueLocals = 0x290
                m_flConstantRadius = 0x2B8
                m_flMaximumSimTime = 0x324
                m_flMinimumSimTime = 0x328
                m_nBehaviorVersion = 0x8
                m_nViewModelEffect = 0x35C
                m_pszTargetLayerID = 0x368
                m_flAggregateRadius = 0x354
                m_flMaxDrawDistance = 0x344
                m_flMaximumTimeStep = 0x320
                m_flMinimumTimeStep = 0x32C
                m_nCullControlPoint = 0x2F0
                m_nFallbackMaxCount = 0x300
                m_nInitialParticles = 0x258
                m_bEnableNamedValues = 0x285
                m_bScreenSpaceEffect = 0x360
                m_flConstantLifespan = 0x2C4
                m_flConstantRotation = 0x2BC
                m_flPreSimulationTime = 0x318
                m_flStartFadeDistance = 0x348
                m_PreEmissionOperators = 0x10
                m_bIsGPUParticleSystem = 0x334
                m_flMaxCreationDistance = 0x34C
                m_hReferenceReplacement = 0x310
                m_nSnapshotControlPoint = 0x2D0
                m_pszCullReplacementName = 0x2E0
                m_flConstantRotationSpeed = 0x2C0
                m_flNoDrawTimeToGoToSleep = 0x340
                m_nConstantSequenceNumber = 0x2C8
                m_nSkipRenderControlPoint = 0x370
                m_nSortOverridePositionCP = 0x280
                m_nAllowRenderControlPoint = 0x374
                m_nConstantSequenceNumber1 = 0x2CC
                m_flStopSimulationAfterTime = 0x31C
                m_controlPointConfigurations = 0x3C0
                m_bShouldHitboxesFallbackToSnapshot = 0x35A
                m_nAggregationMinAvailableParticles = 0x350
                m_bShouldHitboxesFallbackToRenderBounds = 0x359
                m_nFirstMultipleOverride_BackwardCompat = 0x178
                m_bShouldHitboxesFallbackToCollisionHulls = 0x35B
            class CParticleVisibilityInputs:
                m_nCPin = 0x4
                m_bRightEye = 0x44
                m_flInputMax = 0x10
                m_flInputMin = 0xC
                m_bDotCPAngles = 0x2C
                m_flCameraBias = 0x0
                m_flDotInputMax = 0x28
                m_flDotInputMin = 0x24
                m_flProxyRadius = 0x8
                m_flAlphaScaleMax = 0x34
                m_flAlphaScaleMin = 0x30
                m_bDotCameraAngles = 0x2D
                m_flRadiusScaleMax = 0x3C
                m_flRadiusScaleMin = 0x38
                m_flDistanceInputMax = 0x20
                m_flDistanceInputMin = 0x1C
                m_flInputPixelVisFade = 0x14
                m_flRadiusScaleFOVBase = 0x40
                m_flNoPixelVisibilityFallback = 0x18
            class CPulseCell_Value_Gradient:
                m_Gradient = 0x48
            class C_INIT_CreateSpiralSphere:
                m_flDensity = 0x250
                m_TransformInput = 0x1E8
                m_flInitialRadius = 0x3C8
                m_bUseParticleCount = 0x830
                m_flInitialSpeedMax = 0x6B8
                m_flInitialSpeedMin = 0x540
            class C_INIT_InitFromCPSnapshot:
                m_bRandom = 0x204
                m_bReverse = 0x205
                m_nRandomSeed = 0x4F8
                m_nLocalSpaceCP = 0x200
                m_nAttributeToRead = 0x1F8
                m_bLocalSpaceAngles = 0x4FC
                m_nAttributeToWrite = 0x1FC
                m_strSnapshotSubset = 0x1F0
                m_nSnapShotIncrement = 0x208
                m_nControlPointNumber = 0x1E8
                m_nManualSnapshotIndex = 0x380
            class C_INIT_PositionOffsetToCP:
                m_bLocalCoords = 0x1F0
                m_nControlPointNumberEnd = 0x1EC
                m_nControlPointNumberStart = 0x1E8
            class C_INIT_PositionWarpScalar:
                m_InputValue = 0x200
                m_vecWarpMax = 0x1F4
                m_vecWarpMin = 0x1E8
                m_flPrevPosScale = 0x378
                m_nControlPointNumber = 0x380
                m_nScaleControlPointNumber = 0x37C
            class C_INIT_RadiusFromCPObject:
                m_nControlPoint = 0x1E8
            class C_INIT_SetHitboxToClosest:
                m_bUseBones = 0x948
                m_nTestType = 0x94C
                m_HitboxSetName = 0x8C8
                m_flHybridRatio = 0x950
                m_nDesiredHitbox = 0x1EC
                m_vecHitBoxScale = 0x1F0
                m_bUpdatePosition = 0xAC8
                m_nControlPointNumber = 0x1E8
                m_bUseClosestPointOnHitbox = 0x949
            class C_INIT_SetRigidAttachment:
                m_bLocalSpace = 0x1F4
                m_nFieldInput = 0x1EC
                m_nFieldOutput = 0x1F0
                m_nControlPointNumber = 0x1E8
            class C_INIT_VelocityFromNormal:
                m_bIgnoreDt = 0x1F0
                m_fSpeedMax = 0x1EC
                m_fSpeedMin = 0x1E8
            class C_OP_InstantaneousEmitter:
                m_nEventType = 0x4DC
                m_flStartTime = 0x360
                m_nParticlesToEmit = 0x1E8
                m_strSnapshotSubset = 0x660
                m_nMaxEmittedPerFrame = 0x658
                m_flParentParticleScale = 0x4E0
                m_nSnapshotControlPoint = 0x65C
                m_flInitFromKilledParentParticles = 0x4D8
            class C_OP_LazyCullCompareFloat:
                m_flCullTime = 0x4D0
                m_flComparsion1 = 0x1E0
                m_flComparsion2 = 0x358
            class C_OP_LerpToOtherAttribute:
                m_nFieldInput = 0x35C
                m_nFieldOutput = 0x360
                m_flInterpolation = 0x1E0
                m_nFieldInputFrom = 0x358
            class C_OP_RemapDensityToVector:
                m_flDensityMax = 0x1EC
                m_flDensityMin = 0x1E8
                m_nFieldOutput = 0x1E4
                m_vecOutputMax = 0x1FC
                m_vecOutputMin = 0x1F0
                m_flRadiusScale = 0x1E0
                m_bUseParentDensity = 0x208
                m_nVoxelGridResolution = 0x20C
            class C_OP_RemapGravityToVector:
                m_vInput1 = 0x1E0
                m_nSetMethod = 0x8BC
                m_nOutputField = 0x8B8
                m_bNormalizedOutput = 0x8C0
            class C_OP_RemapModelVolumetoCP:
                m_nField = 0x1F8
                m_bBBoxOnly = 0x20C
                m_bCubeRoot = 0x20D
                m_nBBoxType = 0x1E8
                m_flInputMax = 0x200
                m_flInputMin = 0x1FC
                m_flOutputMax = 0x208
                m_flOutputMin = 0x204
                m_nInControlPointNumber = 0x1EC
                m_nOutControlPointNumber = 0x1F0
                m_nOutControlPointMaxNumber = 0x1F4
            class C_OP_RemapScalarOnceTimed:
                m_flInputMax = 0x1F0
                m_flInputMin = 0x1EC
                m_flOutputMax = 0x1F8
                m_flOutputMin = 0x1F4
                m_flRemapTime = 0x1FC
                m_nFieldInput = 0x1E4
                m_nFieldOutput = 0x1E8
                m_bProportional = 0x1E0
            class C_OP_RenderPostProcessing:
                m_nPriority = 0x3B0
                m_hPostTexture = 0x3A8
                m_flPostProcessStrength = 0x230
            class C_OP_RenderStatusEffectTf:
                m_pTextureDetail = 0x258
                m_pTextureEnvMap = 0x260
                m_pTextureNormal = 0x238
                m_pTextureColorWarp = 0x230
                m_pTextureMetalness = 0x240
                m_pTextureRoughness = 0x248
                m_pTextureSelfIllum = 0x250
            class C_OP_RestartAfterDuration:
                m_nCP = 0x1E8
                m_nCPField = 0x1EC
                m_bOnlyChildren = 0x1F4
                m_flDurationMax = 0x1E4
                m_flDurationMin = 0x1E0
                m_nChildGroupID = 0x1F0
            class C_OP_RopeSpringConstraint:
                m_flRestLength = 0x1E0
                m_flMaxDistance = 0x4D0
                m_flMinDistance = 0x358
                m_flAdjustmentScale = 0x648
                m_flInitialRestingLength = 0x650
            class C_OP_SetControlPointToHMD:
                m_nCP1 = 0x1E8
                m_vecCP1Pos = 0x1EC
                m_bOrientToHMD = 0x1F8
            class C_OP_WaterImpulseRenderer:
                m_vecPos = 0x230
                m_flShape = 0xBF8
                m_flRadius = 0x908
                m_flWobble = 0xEE8
                m_nEventType = 0x1064
                m_flMagnitude = 0xA80
                m_flWindSpeed = 0xD70
                m_bIsRadialWind = 0x1060
            class C_OP_WorldTraceConstraint:
                m_nCP = 0x1E0
                m_nIgnoreCP = 0x280
                m_nTraceSet = 0x1F8
                m_bBrushOnly = 0x27D
                m_bSetNormal = 0x881
                m_bWorldOnly = 0x27C
                m_flMinSpeed = 0x87C
                m_flStopSpeed = 0x888
                m_vecCpOffset = 0x1E4
                m_bDecayBounce = 0x878
                m_flRetestRate = 0x288
                m_bIncludeWater = 0x27E
                m_flRadiusScale = 0x298
                m_flSlideAmount = 0x588
                m_bKillonContact = 0x879
                m_flBounceAmount = 0x410
                m_nCollisionMode = 0x1F0
                m_flRandomDirScale = 0x700
                m_flTraceTolerance = 0x28C
                m_nCollisionModeMin = 0x1F4
                m_CollisionGroupName = 0x1FC
                m_nMaxTracesPerFrame = 0x294
                m_bKillonContactBounce = 0x880
                m_flCpMovementTolerance = 0x284
                m_nEntityStickDataField = 0xA00
                m_nStickOnCollisionField = 0x884
                m_nEntityStickNormalField = 0xA04
                m_flCollisionConfirmationSpeed = 0x290
            class IParticleSystemDefinition:
                pass
            class OutflowWithRequirements_t:
                m_Connection = 0x0
                m_RequirementNodeIDs = 0x50
                m_DestinationFlowNodeID = 0x48
                m_nCursorStateBlockIndex = 0x68
            class RenderProjectedMaterial_t:
                m_hMaterial = 0x0
            class SignatureOutflow_Continue:
                pass
            class CPulseCell_BaseRequirement:
                pass
            class CPulseCell_Value_RandomInt:
                pass
            class CPulse_BlackboardReference:
                m_nNodeID = 0x18
                m_NodeName = 0x20
                m_BlackboardResource = 0x8
                m_hBlackboardResource = 0x0
            class C_INIT_ColorLitPerParticle:
                m_TintMax = 0x20C
                m_TintMin = 0x208
                m_ColorMax = 0x204
                m_ColorMin = 0x200
                m_flTintPerc = 0x210
                m_nTintBlendMode = 0x214
                m_flLightAmplification = 0x218
            class C_INIT_CreateInEpitrochoid:
                m_flOffset = 0x3D0
                m_bUseCount = 0x838
                m_flRadius1 = 0x548
                m_flRadius2 = 0x6C0
                m_nComponent1 = 0x1E8
                m_nComponent2 = 0x1EC
                m_TransformInput = 0x1F0
                m_bUseLocalCoords = 0x839
                m_flParticleDensity = 0x258
                m_bOffsetExistingPos = 0x83A
            class C_INIT_InitFloatCollection:
                m_InputValue = 0x1E8
                m_nOutputField = 0x360
            class C_INIT_RandomModelSequence:
                m_hModel = 0x3E8
                m_ActivityName = 0x1E8
                m_SequenceName = 0x2E8
            class C_INIT_RandomRotationSpeed:
                pass
            class C_INIT_RemapScalarToVector:
                m_flEndTime = 0x214
                m_flInputMax = 0x1F4
                m_flInputMin = 0x1F0
                m_nSetMethod = 0x218
                m_flRemapBias = 0x224
                m_flStartTime = 0x210
                m_nFieldInput = 0x1E8
                m_bLocalCoords = 0x220
                m_nFieldOutput = 0x1EC
                m_vecOutputMax = 0x204
                m_vecOutputMin = 0x1F8
                m_nControlPointNumber = 0x21C
            class C_INIT_StatusEffectCitadel:
                m_flSFXSScale = 0x1FC
                m_nDetailCombo = 0x218
                m_flSFXSOffsetX = 0x20C
                m_flSFXSOffsetY = 0x210
                m_flSFXSOffsetZ = 0x214
                m_flSFXSScrollX = 0x200
                m_flSFXSScrollY = 0x204
                m_flSFXSScrollZ = 0x208
                m_flSFXNormalAmount = 0x1EC
                m_flSFXSDetailScale = 0x220
                m_flSFXSUseModelUVs = 0x230
                m_flSFXSDetailAmount = 0x21C
                m_flSFXSDetailScrollX = 0x224
                m_flSFXSDetailScrollY = 0x228
                m_flSFXSDetailScrollZ = 0x22C
                m_flSFXColorWarpAmount = 0x1E8
                m_flSFXMetalnessAmount = 0x1F0
                m_flSFXRoughnessAmount = 0x1F4
                m_flSFXSelfIllumAmount = 0x1F8
            class C_OP_AttractToControlPoint:
                m_fForceAmount = 0x200
                m_fFalloffPower = 0x4F0
                m_TransformInput = 0x4F8
                m_bApplyMinForce = 0x6D8
                m_fForceAmountMin = 0x560
                m_fMinimumDistance = 0x378
                m_vecComponentScale = 0x1F0
            class C_OP_FadeAndKillForTracers:
                m_flEndAlpha = 0x1F4
                m_flStartAlpha = 0x1F0
                m_flEndFadeInTime = 0x1E4
                m_flEndFadeOutTime = 0x1EC
                m_flStartFadeInTime = 0x1E0
                m_flStartFadeOutTime = 0x1E8
            class C_OP_ForceControlPointStub:
                m_ControlPoint = 0x1E8
            class C_OP_InheritFromPeerSystem:
                m_nGroupID = 0x1EC
                m_nIncrement = 0x1E8
                m_nFieldInput = 0x1E4
                m_nFieldOutput = 0x1E0
            class C_OP_LerpToInitialPosition:
                m_flScale = 0x368
                m_vecScale = 0x4E0
                m_nCacheField = 0x360
                m_flInterpolation = 0x1E8
                m_nControlPointNumber = 0x1E0
            class C_OP_MovementPlaceOnGround:
                m_nLerpCP = 0xACC
                m_nRefCP1 = 0xAC4
                m_nRefCP2 = 0xAC8
                m_flOffset = 0x1E0
                m_nIgnoreCP = 0xAE8
                m_nTraceSet = 0xAC0
                m_bSetNormal = 0xAE0
                m_flLerpRate = 0xA3C
                m_flTolerance = 0x35C
                m_vecTraceDir = 0x360
                m_bScaleOffset = 0xAE1
                m_bIncludeWater = 0xADD
                m_flTraceOffset = 0xA38
                m_bIncludeShotHull = 0xADC
                m_flMaxTraceLength = 0x358
                m_nPreserveOffsetCP = 0xAE4
                m_CollisionGroupName = 0xA40
                m_nTraceMissBehavior = 0xAD8
            class C_OP_OscillateScalarSimple:
                m_Rate = 0x1E0
                m_nField = 0x1E8
                m_flOscAdd = 0x1F0
                m_Frequency = 0x1E4
                m_flOscMult = 0x1EC
            class C_OP_OscillateVectorSimple:
                m_Rate = 0x1E0
                m_nField = 0x1F8
                m_bOffset = 0x204
                m_flOscAdd = 0x200
                m_Frequency = 0x1EC
                m_flOscMult = 0x1FC
            class C_OP_RemapExternalWindToCP:
                m_nCP = 0x1E8
                m_vecScale = 0x1F0
                m_nCPOutput = 0x1EC
                m_bSetMagnitude = 0x8C8
                m_nOutVectorField = 0x8CC
            class C_OP_RemapVelocityToVector:
                m_flScale = 0x1E4
                m_bNormalize = 0x1E8
                m_nFieldOutput = 0x1E0
            class C_OP_RemapVisibilityScalar:
                m_flInputMax = 0x1EC
                m_flInputMin = 0x1E8
                m_flOutputMax = 0x1F4
                m_flOutputMin = 0x1F0
                m_nFieldInput = 0x1E0
                m_nFieldOutput = 0x1E4
                m_flRadiusScale = 0x1F8
            class C_OP_SetChildControlPoints:
                m_bReverse = 0x368
                m_nOrientation = 0x36C
                m_nChildGroupID = 0x1E0
                m_bSetOrientation = 0x369
                m_nFirstSourcePoint = 0x1F0
                m_nNumControlPoints = 0x1E8
                m_nFirstControlPoint = 0x1E4
            class C_OP_SetControlPointToHand:
                m_nCP1 = 0x1E8
                m_nHand = 0x1EC
                m_vecCP1Pos = 0x1F0
                m_bOrientToHand = 0x1FC
            class C_OP_VelocityMatchingForce:
                m_bUseAABB = 0x1F0
                m_flDirScale = 0x1E0
                m_flSpdScale = 0x1E4
                m_nCPBroadcast = 0x1F4
                m_flFacingStrength = 0x1EC
                m_flNeighborDistance = 0x1E8
            class ParticlePreviewBodyGroup_t:
                m_nValue = 0x8
                m_bodyGroupName = 0x0
            class PulseNodeDynamicOutflows_t:
                m_Outflows = 0x0
            class PulseSelectorOutflowList_t:
                m_Outflows = 0x0
            class VecInputMaterialVariable_t:
                m_vecInput = 0x8
                m_strVariable = 0x0
            class CParticleFunctionConstraint:
                pass
            class CPulseCell_Inflow_GraphHook:
                m_HookName = 0x80
            class C_INIT_CreateFromPlaneCache:
                m_bUseNormal = 0x201
                m_vecOffsetMax = 0x1F4
                m_vecOffsetMin = 0x1E8
            class C_INIT_CreateSequentialPath:
                m_bLoop = 0x1F0
                m_bCPPairs = 0x1F1
                m_PathParams = 0x200
                m_bSaveOffset = 0x1F2
                m_fMaxDistance = 0x1E8
                m_flNumToAssign = 0x1EC
            class C_INIT_InitFromParentKilled:
                m_nEventType = 0x1EC
                m_nAttributeToCopy = 0x1E8
            class C_INIT_InitialVelocityNoise:
                m_flOffset = 0x8D8
                m_bIgnoreDt = 0x1B58
                m_vecAbsVal = 0x1E8
                m_flNoiseScale = 0x1800
                m_vecAbsValInv = 0x1F4
                m_vecOffsetLoc = 0x200
                m_vecOutputMax = 0x1128
                m_vecOutputMin = 0xA50
                m_TransformInput = 0x1AF0
                m_flNoiseScaleLoc = 0x1978
            class C_INIT_LifespanFromVelocity:
                m_nTraceSet = 0x288
                m_nMaxPlanes = 0x200
                m_bIncludeWater = 0x298
                m_flTraceOffset = 0x1F4
                m_flMaxTraceLength = 0x1F8
                m_flTraceTolerance = 0x1FC
                m_vecComponentScale = 0x1E8
                m_CollisionGroupName = 0x208
            class C_INIT_OffsetVectorToVector:
                m_nFieldInput = 0x1E8
                m_nFieldOutput = 0x1EC
                m_vecOutputMax = 0x1FC
                m_vecOutputMin = 0x1F0
                m_randomnessParameters = 0x208
            class C_INIT_RandomSecondSequence:
                m_nSequenceMax = 0x1EC
                m_nSequenceMin = 0x1E8
            class C_INIT_VelocityRadialRandom:
                m_vecFwd = 0x8C8
                m_fSpeedMax = 0x1118
                m_fSpeedMin = 0xFA0
                m_vecPosition = 0x1F0
                m_bIgnoreDelta = 0x129D
                m_bPerParticleCenter = 0x1E8
                m_nControlPointNumber = 0x1EC
                m_vecLocalCoordinateSystemSpeedScale = 0x1290
            class C_OP_ColorInterpolateRandom:
                m_bEaseInOut = 0x218
                m_ColorFadeMax = 0x1FC
                m_ColorFadeMin = 0x1E0
                m_nFieldOutput = 0x214
                m_flFadeEndTime = 0x210
                m_flFadeStartTime = 0x20C
            class C_OP_DistanceBetweenCPsToCP:
                m_bLOS = 0x214
                m_nEndCP = 0x1EC
                m_bSetOnce = 0x1F8
                m_nStartCP = 0x1E8
                m_nOutputCP = 0x1F0
                m_nTraceSet = 0x298
                m_flInputMax = 0x200
                m_flInputMin = 0x1FC
                m_flLOSScale = 0x210
                m_nSetParent = 0x29C
                m_flOutputMax = 0x208
                m_flOutputMin = 0x204
                m_nOutputCPField = 0x1F4
                m_flMaxTraceLength = 0x20C
                m_CollisionGroupName = 0x215
            class C_OP_LocalAccelerationForce:
                m_nCP = 0x1F0
                m_nScaleCP = 0x1F4
                m_vecAccel = 0x1F8
            class C_OP_MaintainSequentialPath:
                m_bLoop = 0x64C
                m_PathParams = 0x650
                m_flTolerance = 0x648
                m_fMaxDistance = 0x1E0
                m_flNumToAssign = 0x358
                m_bUseParticleCount = 0x64D
                m_flCohesionStrength = 0x4D0
            class C_OP_MovementMaintainOffset:
                m_nCP = 0x1EC
                m_vecOffset = 0x1E0
                m_bRadiusScale = 0x1F0
            class C_OP_PlayEndCapWhenFinished:
                m_bIncludeChildren = 0x1E9
                m_bFireOnEmissionEnd = 0x1E8
            class C_OP_RampScalarLinearSimple:
                m_Rate = 0x1E0
                m_nField = 0x210
                m_flEndTime = 0x1E8
                m_flStartTime = 0x1E4
            class C_OP_RampScalarSplineSimple:
                m_Rate = 0x1E0
                m_nField = 0x210
                m_bEaseOut = 0x214
                m_flEndTime = 0x1E8
                m_flStartTime = 0x1E4
            class C_OP_RemapVectorToRotations:
                m_vecInput = 0x1E0
                m_vecRotation = 0x8B8
            class C_OP_WorldCollideConstraint:
                pass
            class CParticleFunctionInitializer:
                m_nAssociatedEmitterIndex = 0x1E0
            class CParticleFunctionPreEmission:
                m_bRunOnce = 0x1E0
            class CPulseCell_Step_PublicOutput:
                m_OutputIndex = 0x48
            class CPulseCell_Value_RandomFloat:
                pass
            class CPulseCell_WaitForObservable:
                m_OnTrue = 0x168
                m_Condition = 0xD8
            class C_INIT_CheckParticleForWater:
                m_flRadius = 0x1E8
                m_nSetMethod = 0x4E0
                m_nFieldOutput = 0x360
                m_flOutputRemap = 0x368
            class C_INIT_CreateOnModelAtHeight:
                m_bForceZ = 0x1E9
                m_bUseBones = 0x1E8
                m_nBiasType = 0x1120
                m_nHeightCP = 0x1F0
                m_bLocalCoords = 0x1124
                m_HitboxSetName = 0x1126
                m_vecHitBoxScale = 0x370
                m_bUseWaterHeight = 0x1F4
                m_flDesiredHeight = 0x1F8
                m_vecDirectionBias = 0xA48
                m_flMaxBoneVelocity = 0x1320
                m_bPreferMovingBoxes = 0x1125
                m_nControlPointNumber = 0x1EC
                m_flHitboxVelocityScale = 0x11A8
            class C_INIT_CreateParticleImpulse:
                m_InputRadius = 0x1E8
                m_nImpulseType = 0x658
                m_InputMagnitude = 0x360
                m_InputFalloffExp = 0x4E0
                m_nFalloffFunction = 0x4D8
            class C_INIT_PositionPlaceOnGround:
                m_flOffset = 0x1E8
                m_nIgnoreCP = 0xC60
                m_nTraceSet = 0xC30
                m_bSetNormal = 0xC4D
                m_nAttribute = 0xC48
                m_vecTraceDir = 0x4D8
                m_bSetPXYZOnly = 0xC4C
                m_bIncludeWater = 0xC44
                m_bOffsetonColOnly = 0xC54
                m_flMaxTraceLength = 0x360
                m_nPreserveOffsetCP = 0xC5C
                m_CollisionGroupName = 0xBB0
                m_nTraceMissBehavior = 0xC40
                m_flOffsetByRadiusFactor = 0xC58
                m_nGroundNormalAttribute = 0xC50
            class C_INIT_RandomVectorComponent:
                m_flMax = 0x1EC
                m_flMin = 0x1E8
                m_nComponent = 0x1F4
                m_nFieldOutput = 0x1F0
            class C_OP_ConstrainDistanceToPath:
                m_nFieldScale = 0x234
                m_fMinDistance = 0x1E0
                m_flTravelTime = 0x230
                m_nManualTField = 0x238
                m_PathParameters = 0x1F0
                m_flMaxDistance0 = 0x1E4
                m_flMaxDistance1 = 0x1EC
                m_flMaxDistanceMid = 0x1E8
            class C_OP_MovementRigidAttachToCP:
                m_nFieldInput = 0x1EC
                m_bOffsetLocal = 0x1F4
                m_nFieldOutput = 0x1F0
                m_nScaleCPField = 0x1E8
                m_nScaleControlPoint = 0x1E4
                m_nControlPointNumber = 0x1E0
            class C_OP_RemapBoundingVolumetoCP:
                m_flInputMax = 0x1F0
                m_flInputMin = 0x1EC
                m_flOutputMax = 0x1F8
                m_flOutputMin = 0x1F4
                m_nOutControlPointNumber = 0x1E8
            class C_OP_RemapCPVelocityToVector:
                m_flScale = 0x1E8
                m_bNormalize = 0x1EC
                m_nFieldOutput = 0x1E4
                m_nControlPoint = 0x1E0
            class C_OP_RemapDotProductToScalar:
                m_nInputCP1 = 0x1E0
                m_nInputCP2 = 0x1E4
                m_flInputMax = 0x1F0
                m_flInputMin = 0x1EC
                m_nSetMethod = 0x200
                m_flOutputMax = 0x1F8
                m_flOutputMin = 0x1F4
                m_bActiveRange = 0x204
                m_nFieldOutput = 0x1E8
                m_bUseParticleNormal = 0x205
                m_bUseParticleVelocity = 0x1FC
            class C_OP_RenderVolumetricEmitter:
                m_nType = 0x238
                m_vecPos = 0x248
                m_flSpeed = 0x16D0
                m_flRadius = 0x1848
                m_flDensity = 0x19C0
                m_flFalloff = 0x2118
                m_nEventType = 0x240
                m_flMagnitude = 0x1CB0
                m_vecVelocity = 0x920
                m_flKillRadius = 0x1E28
                m_flTemperature = 0x1B38
                m_nCreationType = 0x23C
                m_vPrevPosition = 0xFF8
                m_strChannelType = 0x230
                m_flKillDensityScale = 0x1FA0
            class C_OP_SetControlPointRotation:
                m_nCP = 0xA38
                m_nLocalCP = 0xA3C
                m_flRotRate = 0x8C0
                m_vecRotAxis = 0x1E8
            class C_OP_SetControlPointToCenter:
                m_nCP1 = 0x1E8
                m_vecCP1Pos = 0x1EC
                m_nSetParent = 0x1FC
                m_bUseAvgParticlePos = 0x1F8
            class C_OP_SetControlPointToPlayer:
                m_nCP1 = 0x1E8
                m_nPosition = 0x1FC
                m_nRadiusCP = 0x200
                m_vecCP1Pos = 0x1EC
                m_bOrientToEyes = 0x1F8
                m_nRadiusCPField = 0x204
            class C_OP_SetPerChildControlPoint:
                m_nChildGroupID = 0x1E0
                m_bSetOrientation = 0x4E0
                m_nFirstSourcePoint = 0x368
                m_nNumControlPoints = 0x1E8
                m_nOrientationField = 0x4E4
                m_nFirstControlPoint = 0x1E4
                m_nParticleIncrement = 0x1F0
                m_bNumBasedOnParticleCount = 0x4E8
            class C_OP_ShapeMatchingConstraint:
                m_flShapeRestorationTime = 0x1E0
            class FloatInputMaterialVariable_t:
                m_flInput = 0x8
                m_strVariable = 0x0
            class ParticleControlPointDriver_t:
                m_angOffset = 0x2C
                m_vecOffset = 0x20
                m_entityName = 0x38
                m_iAttachType = 0x10
                m_iControlPoint = 0x0
                m_attachmentName = 0x18
            class CPulseCell_BaseYieldingInflow:
                m_BaseFlow_WhileActive = 0x90
                m_BaseFlow_OnAfterCancel = 0x48
            class CPulseCell_BooleanSwitchState:
                m_WhenTrue = 0x168
                m_Condition = 0xD8
                m_WhenFalse = 0x1B0
            class CPulseCell_IsRequirementValid:
                pass
            class C_INIT_CreateSequentialPathV2:
                m_bLoop = 0x4D8
                m_bCPPairs = 0x4D9
                m_PathParams = 0x4E0
                m_bSaveOffset = 0x4DA
                m_fMaxDistance = 0x1E8
                m_flNumToAssign = 0x360
            class C_INIT_DistanceToNeighborCull:
                m_flModify = 0x4E8
                m_flDistance = 0x1E8
                m_nSetMethod = 0x660
                m_bUseNeighbor = 0x664
                m_nFieldModify = 0x4E0
                m_bIncludeRadii = 0x360
                m_flLifespanOverlap = 0x368
            class C_INIT_RemapQAnglesToRotation:
                m_TransformInput = 0x1E8
            class C_INIT_RemapTransformToVector:
                m_bOffset = 0x2FC
                m_flEndTime = 0x2F4
                m_vInputMax = 0x1F8
                m_vInputMin = 0x1EC
                m_nSetMethod = 0x2F8
                m_vOutputMax = 0x210
                m_vOutputMin = 0x204
                m_bAccelerate = 0x2FD
                m_flRemapBias = 0x300
                m_flStartTime = 0x2F0
                m_nFieldOutput = 0x1E8
                m_TransformInput = 0x220
                m_LocalSpaceTransform = 0x288
            class C_OP_CalculateVectorAttribute:
                m_vStartValue = 0x1E0
                m_nFieldInput1 = 0x1EC
                m_nFieldInput2 = 0x1F4
                m_nFieldOutput = 0x22C
                m_flInputScale1 = 0x1F0
                m_flInputScale2 = 0x1F8
                m_vFinalOutputScale = 0x230
                m_nControlPointInput1 = 0x1FC
                m_nControlPointInput2 = 0x214
                m_flControlPointScale1 = 0x210
                m_flControlPointScale2 = 0x228
            class C_OP_ExternalGameImpulseForce:
                m_bRopes = 0x368
                m_bParticles = 0x36B
                m_bExplosions = 0x36A
                m_bRopesZOnly = 0x369
                m_flForceScale = 0x1F0
            class C_OP_MovementLoopInsideSphere:
                m_nCP = 0x1E0
                m_vecScale = 0x360
                m_flDistance = 0x1E8
                m_nDistSqrAttr = 0xA38
            class C_OP_ReinitializeScalarEndCap:
                m_flOutputMax = 0x1E8
                m_flOutputMin = 0x1E4
                m_nFieldOutput = 0x1E0
            class C_OP_RemapTransformToVelocity:
                m_TransformInput = 0x1E0
            class C_OP_SetControlPointPositions:
                m_nCP1 = 0x1EC
                m_nCP2 = 0x1F0
                m_nCP3 = 0x1F4
                m_nCP4 = 0x1F8
                m_bOrient = 0x1E9
                m_bSetOnce = 0x1EA
                m_vecCP1Pos = 0x1FC
                m_vecCP2Pos = 0x208
                m_vecCP3Pos = 0x214
                m_vecCP4Pos = 0x220
                m_nHeadLocation = 0x22C
                m_bUseWorldLocation = 0x1E8
            class C_OP_SnapshotRigidSkinToBones:
                m_bTransformRadii = 0x1E1
                m_bTransformNormals = 0x1E0
                m_nControlPointNumber = 0x1E4
            class C_OP_SpringToVectorConstraint:
                m_flRestLength = 0x1E0
                m_flMaxDistance = 0x4D0
                m_flMinDistance = 0x358
                m_flRestingLength = 0x648
                m_vecAnchorVector = 0x7C0
            class CPulseCell_Inflow_EventHandler:
                m_EventName = 0x80
            class CPulseCell_Outflow_CycleRandom:
                m_Outputs = 0x48
            class C_INIT_RandomNamedModelElement:
                m_names = 0x1F0
                m_hModel = 0x1E8
                m_bLinear = 0x209
                m_bShuffle = 0x208
                m_nFieldOutput = 0x20C
                m_bModelFromRenderer = 0x20A
            class C_OP_DirectionBetweenVecsToVec:
                m_vecPoint1 = 0x1E8
                m_vecPoint2 = 0x8C0
                m_nFieldOutput = 0x1E0
            class C_OP_DistanceBetweenTransforms:
                m_bLOS = 0x924
                m_nTraceSet = 0x920
                m_flInputMax = 0x430
                m_flInputMin = 0x2B8
                m_flLOSScale = 0x89C
                m_nSetMethod = 0x928
                m_flOutputMax = 0x720
                m_flOutputMin = 0x5A8
                m_TransformEnd = 0x250
                m_nFieldOutput = 0x1E0
                m_TransformStart = 0x1E8
                m_flMaxTraceLength = 0x898
                m_CollisionGroupName = 0x8A0
            class C_OP_LockToSavedSequentialPath:
                m_bCPPairs = 0x1EC
                m_flFadeEnd = 0x1E8
                m_PathParams = 0x1F0
                m_flFadeStart = 0x1E4
            class C_OP_PointVectorAtNextParticle:
                m_bPrevious = 0x360
                m_nFieldOutput = 0x1E0
                m_flInterpolation = 0x1E8
            class C_OP_RenderStatusEffectCitadel:
                m_pTextureDetail = 0x258
                m_pTextureNormal = 0x238
                m_pTextureColorWarp = 0x230
                m_pTextureMetalness = 0x240
                m_pTextureRoughness = 0x248
                m_pTextureSelfIllum = 0x250
            class C_OP_RepeatedTriggerChildGroup:
                m_flClusterSize = 0x368
                m_nChildGroupID = 0x1E8
                m_bLimitChildCount = 0x658
                m_flClusterCooldown = 0x4E0
                m_flClusterRefireTime = 0x1F0
            class C_OP_ScreenSpaceDistanceToEdge:
                m_nSetMethod = 0x4D8
                m_nFieldOutput = 0x1E0
                m_flOutputRemap = 0x360
                m_flMaxDistFromEdge = 0x1E8
            class C_OP_SelectivelyEnableChildren:
                m_nFirstChild = 0x360
                m_nChildGroupID = 0x1E8
                m_bPlayEndcapOnStop = 0x650
                m_bDestroyImmediately = 0x651
                m_nNumChildrenToEnable = 0x4D8
            class CPulseCell_Outflow_CycleOrdered:
                m_Outputs = 0x48
            class C_INIT_InitialRepulsionVelocity:
                m_bInherit = 0x291
                m_nChildCP = 0x294
                m_nTraceSet = 0x268
                m_bTranslate = 0x289
                m_bPerParticle = 0x288
                m_vecOutputMax = 0x278
                m_vecOutputMin = 0x26C
                m_bProportional = 0x28A
                m_flTraceLength = 0x28C
                m_nChildGroupID = 0x298
                m_bPerParticleTR = 0x290
                m_CollisionGroupName = 0x1E8
                m_nControlPointNumber = 0x284
            class C_INIT_InitialSequenceFromModel:
                m_flInputMax = 0x1F8
                m_flInputMin = 0x1F4
                m_nSetMethod = 0x204
                m_flOutputMax = 0x200
                m_flOutputMin = 0x1FC
                m_nFieldOutput = 0x1EC
                m_nFieldOutputAnim = 0x1F0
                m_nControlPointNumber = 0x1E8
            class C_INIT_RandomNamedModelBodyPart:
                pass
            class C_INIT_RandomNamedModelSequence:
                pass
            class C_OP_CollideWithParentParticles:
                m_flRadiusScale = 0x358
                m_flParentRadiusScale = 0x1E0
            class C_OP_DifferencePreviousParticle:
                m_flInputMax = 0x1EC
                m_flInputMin = 0x1E8
                m_nSetMethod = 0x1F8
                m_flOutputMax = 0x1F4
                m_flOutputMin = 0x1F0
                m_nFieldInput = 0x1E0
                m_bActiveRange = 0x1FC
                m_nFieldOutput = 0x1E4
                m_bSetPreviousParticle = 0x1FD
            class C_OP_InheritFromParentParticles:
                m_flScale = 0x1E0
                m_nIncrement = 0x1E8
                m_nFieldOutput = 0x1E4
                m_bRandomDistribution = 0x1EC
            class C_OP_LightningSnapshotGenerator:
                m_flOffset = 0x370
                m_flUVScale = 0x7D8
                m_nCPEndPnt = 0x1F0
                m_flSegments = 0x1F8
                m_flUVOffset = 0x950
                m_flRadiusEnd = 0x13B0
                m_flSplitRate = 0xAC8
                m_nCPSnapshot = 0x1E8
                m_nCPStartPnt = 0x1EC
                m_flRecalcRate = 0x660
                m_flBranchTwist = 0x10B8
                m_flOffsetDecay = 0x4E8
                m_flRadiusStart = 0x1238
                m_flDedicatedPool = 0x1528
                m_nBranchBehavior = 0x1230
                m_bScaleBranchOffset = 0xF38
                m_flBranchOffsetScale = 0xF40
                m_bScaleBranchDistance = 0xDB8
                m_flBranchDistanceScale = 0xDC0
                m_flRecursionSplitScale = 0xC40
            class C_OP_RemapDirectionToCPToVector:
                m_nCP = 0x1E0
                m_flScale = 0x1E8
                m_bNormalize = 0x1FC
                m_flOffsetRot = 0x1EC
                m_nFieldOutput = 0x1E4
                m_vecOffsetAxis = 0x1F0
                m_nFieldStrength = 0x200
            class C_OP_RemapParticleCountToScalar:
                m_nInputMax = 0x360
                m_nInputMin = 0x1E8
                m_nSetMethod = 0x7CC
                m_flOutputMax = 0x650
                m_flOutputMin = 0x4D8
                m_bActiveRange = 0x7C8
                m_nFieldOutput = 0x1E0
            class C_OP_RenderClientPhysicsImpulse:
                m_flRadius = 0x230
                m_flMagnitude = 0x3A8
                m_nSimIdFilter = 0x520
            class C_OP_RenderScreenVelocityRotate:
                m_flForwardDegrees = 0x234
                m_flRotateRateDegrees = 0x230
            class C_OP_SetControlPointOrientation:
                m_nCP = 0x1EC
                m_bSetOnce = 0x1EB
                m_bRandomize = 0x1EA
                m_vecRotation = 0x1F4
                m_vecRotationB = 0x200
                m_nHeadLocation = 0x1F0
                m_flInterpolation = 0x210
                m_bUseWorldLocation = 0x1E8
            class C_OP_SetControlPointsToParticle:
                m_bReverse = 0x1F0
                m_nSetParent = 0x1F8
                m_nChildGroupID = 0x1E0
                m_bSetOrientation = 0x1F1
                m_nOrientationMode = 0x1F4
                m_nFirstSourcePoint = 0x1EC
                m_nNumControlPoints = 0x1E8
                m_nFirstControlPoint = 0x1E4
            class PointDefinitionWithTimeValues_t:
                m_flTimeDuration = 0x14
            class CPulseCell_Inflow_BaseEntrypoint:
                m_EntryChunk = 0x48
                m_RegisterMap = 0x50
            class CPulseCell_Outflow_CycleShuffled:
                m_Outputs = 0x48
            class CPulseCell_WaitForCursorsWithTag:
                m_bTagSelfWhenComplete = 0x128
                m_nDesiredKillPriority = 0x12C
            class CRandomNumberGeneratorParameters:
                m_nSeed = 0x4
                m_bDistributeEvenly = 0x0
            class C_INIT_CreateFromParentParticles:
                m_bSubFrame = 0x1F8
                m_flIncrement = 0x1EC
                m_nRandomSeed = 0x1F4
                m_flVelocityScale = 0x1E8
                m_bSetRopeSegmentID = 0x1F9
                m_bRandomDistribution = 0x1F0
            class C_INIT_InitialVelocityFromHitbox:
                m_bUseBones = 0x274
                m_HitboxSetName = 0x1F4
                m_flVelocityMax = 0x1EC
                m_flVelocityMin = 0x1E8
                m_nControlPointNumber = 0x1F0
            class C_INIT_RandomNamedModelMeshGroup:
                pass
            class C_OP_ChooseRandomChildrenInGroup:
                m_nChildGroupID = 0x1E8
                m_flNumberOfChildren = 0x1F0
            class C_OP_DriveCPFromGlobalSoundFloat:
                m_FieldName = 0x210
                m_StackName = 0x200
                m_flInputMax = 0x1F4
                m_flInputMin = 0x1F0
                m_flOutputMax = 0x1FC
                m_flOutputMin = 0x1F8
                m_OperatorName = 0x208
                m_nOutputField = 0x1EC
                m_nOutputControlPoint = 0x1E8
            class C_OP_ForceBasedOnDistanceToPlane:
                m_flMaxDist = 0x200
                m_flMinDist = 0x1F0
                m_flExponent = 0x220
                m_vecPlaneNormal = 0x210
                m_vecForceAtMaxDist = 0x204
                m_vecForceAtMinDist = 0x1F4
                m_nControlPointNumber = 0x21C
            class C_OP_LockToSavedSequentialPathV2:
                m_bCPPairs = 0x1E8
                m_flFadeEnd = 0x1E4
                m_PathParams = 0x1F0
                m_flFadeStart = 0x1E0
            class C_OP_PercentageBetweenTransforms:
                m_flInputMax = 0x1E8
                m_flInputMin = 0x1E4
                m_nSetMethod = 0x2C8
                m_flOutputMax = 0x1F0
                m_flOutputMin = 0x1EC
                m_TransformEnd = 0x260
                m_bActiveRange = 0x2CC
                m_bRadialCheck = 0x2CD
                m_nFieldOutput = 0x1E0
                m_TransformStart = 0x1F8
            class C_OP_ReadFromNeighboringParticle:
                m_nIncrement = 0x1E8
                m_nFieldInput = 0x1E0
                m_nFieldOutput = 0x1E4
                m_DistanceCheck = 0x1F0
                m_flInterpolation = 0x368
            class C_OP_RemapAverageHitboxSpeedtoCP:
                m_nField = 0x1F0
                m_flInputMax = 0x370
                m_flInputMin = 0x1F8
                m_flOutputMax = 0x660
                m_flOutputMin = 0x4E8
                m_HitboxSetName = 0xEB8
                m_nHitboxDataType = 0x1F4
                m_nInControlPointNumber = 0x1E8
                m_vecComparisonVelocity = 0x7E0
                m_nOutControlPointNumber = 0x1EC
                m_nHeightControlPointNumber = 0x7D8
            class C_OP_RemapAverageScalarValuetoCP:
                m_nField = 0x370
                m_nExpression = 0x1E8
                m_flOutputRemap = 0x378
                m_flDecimalPlaces = 0x1F0
                m_nOutVectorField = 0x36C
                m_nOutControlPointNumber = 0x368
            class C_OP_RenderSimpleModelCollection:
                m_hModel = 0x238
                m_modelInput = 0x240
                m_fDrawFilter = 0x420
                m_bCenterOffset = 0x230
                m_bAcceptsDecals = 0x41A
                m_fSizeCullScale = 0x2A0
                m_bDisableShadows = 0x418
                m_bDisableMotionBlur = 0x419
                m_nAngularVelocityField = 0x598
            class C_OP_ScreenSpacePositionOfTarget:
                m_bOututBehindness = 0x8B8
                m_nBehindSetMethod = 0xA38
                m_vecTargetPosition = 0x1E0
                m_nBehindFieldOutput = 0x8BC
                m_flBehindOutputRemap = 0x8C0
            class C_OP_SetCPOrientationToDirection:
                m_nInputControlPoint = 0x1E0
                m_nOutputControlPoint = 0x1E4
            class C_OP_SetCPOrientationToPointAtCP:
                m_nInputCP = 0x1E8
                m_nOutputCP = 0x1EC
                m_bPointAway = 0x36A
                m_b2DOrientation = 0x368
                m_flInterpolation = 0x1F0
                m_bAvoidSingularity = 0x369
            class C_OP_SetControlPointFieldToWater:
                m_nDestCP = 0x1EC
                m_nCPField = 0x1F0
                m_nSourceCP = 0x1E8
            class C_OP_SetControlPointToCPVelocity:
                m_nCPField = 0x1F8
                m_nCPInput = 0x1E8
                m_bNormalize = 0x1F0
                m_nCPOutputMag = 0x1F4
                m_nCPOutputVel = 0x1EC
                m_vecComparisonVelocity = 0x200
            class CPulseCell_InlineNodeSkipSelector:
                m_bAnd = 0x4C
                m_FailOutflow = 0x68
                m_PassOutflow = 0x50
                m_nFlowNodeID = 0x48
            class CPulseCell_LimitCount__Criteria_t:
                m_bLimitCountPasses = 0x0
            class C_INIT_InheritFromParentParticles:
                m_flScale = 0x1E8
                m_nIncrement = 0x1F0
                m_nRandomSeed = 0x1F8
                m_nFieldOutput = 0x1EC
                m_bRandomDistribution = 0x1F4
            class C_INIT_RandomAlphaWindowThreshold:
                m_flMax = 0x1EC
                m_flMin = 0x1E8
                m_flExponent = 0x1F0
            class C_INIT_RemapParticleCountToScalar:
                m_bWrap = 0x20A
                m_bInvert = 0x209
                m_nInputMax = 0x1F0
                m_nInputMin = 0x1EC
                m_nSetMethod = 0x204
                m_flOutputMax = 0x200
                m_flOutputMin = 0x1FC
                m_flRemapBias = 0x20C
                m_bActiveRange = 0x208
                m_nFieldOutput = 0x1E8
                m_nScaleControlPoint = 0x1F4
                m_nScaleControlPointField = 0x1F8
            class C_OP_CreateParticleSystemRenderer:
                m_vecCPs = 0x240
                m_hEffect = 0x230
                m_nEventType = 0x238
                m_AggregationPos = 0x258
                m_szParticleConfig = 0x250
            class C_OP_InheritFromParentParticlesV2:
                m_flScale = 0x1E0
                m_bReverse = 0x4DA
                m_bSubSample = 0x4D8
                m_nIncrement = 0x360
                m_nFieldOutput = 0x358
                m_flInterpolation = 0x4E0
                m_bRandomDistribution = 0x4D9
                m_nMissingParentBehavior = 0x4DC
            class C_OP_RemapNamedModelElementEndCap:
                m_hModel = 0x1E0
                m_inNames = 0x1E8
                m_outNames = 0x200
                m_nFieldInput = 0x234
                m_nFieldOutput = 0x238
                m_fallbackNames = 0x218
                m_bModelFromRenderer = 0x230
            class C_OP_RemapVectorComponentToScalar:
                m_nComponent = 0x1E8
                m_nFieldInput = 0x1E0
                m_nFieldOutput = 0x1E4
            class C_OP_SetControlPointToImpactPoint:
                m_nCPIn = 0x1EC
                m_nCPOut = 0x1E8
                m_flOffset = 0x374
                m_nTraceSet = 0x404
                m_vecTraceDir = 0x378
                m_flUpdateRate = 0x1F0
                m_bIncludeWater = 0x40A
                m_flStartOffset = 0x370
                m_flTraceLength = 0x1F8
                m_bSetToEndpoint = 0x408
                m_CollisionGroupName = 0x384
                m_bTraceToClosestSurface = 0x409
            class CParticleCollectionBindingInstance:
                pass
            class CParticleMassCalculationParameters:
                m_flScale = 0x2F8
                m_flRadius = 0x8
                m_nMassMode = 0x0
                m_flNominalRadius = 0x180
            class CPulseCell_BaseLerp__CursorState_t:
                m_EndTime = 0x4
                m_StartTime = 0x0
            class CPulseCell_Inflow_EntOutputHandler:
                m_SourceEntity = 0x80
                m_SourceOutput = 0x90
                m_ExpectedParamType = 0xA0
            class CPulseCell_PickBestOutflowSelector:
                m_nCheckType = 0x48
                m_OutflowList = 0x50
            class CPulseCell_Step_CallExternalMethod:
                m_MethodName = 0xD8
                m_OnFinished = 0x108
                m_ExpectedArgs = 0xF0
                m_nAsyncCallMode = 0x100
                m_nBlackboardIndex = 0xE8
            class C_INIT_CreateWithinSphereTransform:
                m_fSpeedMax = 0xDA0
                m_fSpeedMin = 0xC28
                m_fRadiusMax = 0x360
                m_fRadiusMin = 0x1E8
                m_bLocalCoords = 0xF1C
                m_nFieldOutput = 0x1CD0
                m_fSpeedRandExp = 0xF18
                m_TransformInput = 0xBC0
                m_nFieldVelocity = 0x1CD4
                m_vecDistanceBias = 0x4D8
                m_vecDistanceBiasAbs = 0xBB0
                m_LocalCoordinateSystemSpeedMax = 0x15F8
                m_LocalCoordinateSystemSpeedMin = 0xF20
            class C_INIT_InitFromVectorFieldSnapshot:
                m_vecScale = 0x1F8
                m_nLocalSpaceCP = 0x1EC
                m_nWeightUpdateCP = 0x1F0
                m_nControlPointNumber = 0x1E8
                m_bUseVerticalVelocity = 0x1F4
            class C_INIT_ScreenSpacePositionOfTarget:
                m_bOututBehindness = 0x8C0
                m_vecTargetPosition = 0x1E8
                m_nBehindFieldOutput = 0x8C4
                m_flBehindOutputRemap = 0x8C8
            class C_OP_ModelSurfaceSnapshotGenerator:
                m_bSetUV = 0x833
                m_bSetUp = 0x831
                m_bSetNormal = 0x830
                m_flUSpacing = 0x3C8
                m_flVSpacing = 0x540
                m_modelInput = 0x1F0
                m_bSetGravity = 0x832
                m_nCPSnapshot = 0x1E8
                m_flRecalcRate = 0x250
                m_flSurfaceOffset = 0x6B8
            class C_OP_RemapNamedModelBodyPartEndCap:
                pass
            class C_OP_RemapNamedModelSequenceEndCap:
                pass
            class C_OP_ScreenSpaceRotateTowardTarget:
                m_nSetMethod = 0xA30
                m_flOutputRemap = 0x8B8
                m_vecTargetPosition = 0x1E0
                m_flScreenEdgeAlignmentDistance = 0xA38
            class C_OP_SetControlPointToWaterSurface:
                m_nDestCP = 0x1EC
                m_nFlowCP = 0x1F0
                m_nActiveCP = 0x1F4
                m_nSourceCP = 0x1E8
                m_flRetestRate = 0x200
                m_nActiveCPField = 0x1F8
                m_bAdaptiveThreshold = 0x378
            class C_OP_SetRandomControlPointPosition:
                m_nCP1 = 0x1EC
                m_bOrient = 0x1E9
                m_vecCPMaxPos = 0x37C
                m_vecCPMinPos = 0x370
                m_nHeadLocation = 0x1F0
                m_flReRandomRate = 0x1F8
                m_flInterpolation = 0x388
                m_bUseWorldLocation = 0x1E8
            class C_OP_SetSingleControlPointPosition:
                m_nCP1 = 0x1EC
                m_bSetOnce = 0x1E8
                m_vecCP1Pos = 0x1F0
                m_transformInput = 0x8C8
            class C_INIT_CreateWithinCapsuleTransform:
                m_fHeight = 0x4D8
                m_fSpeedMax = 0x830
                m_fSpeedMin = 0x6B8
                m_fRadiusMax = 0x360
                m_fRadiusMin = 0x1E8
                m_nFieldOutput = 0x1760
                m_fSpeedRandExp = 0x9A8
                m_TransformInput = 0x650
                m_nFieldVelocity = 0x1764
                m_LocalCoordinateSystemSpeedMax = 0x1088
                m_LocalCoordinateSystemSpeedMin = 0x9B0
            class C_INIT_RemapInitialVisibilityScalar:
                m_flInputMax = 0x1F4
                m_flInputMin = 0x1F0
                m_flOutputMax = 0x1FC
                m_flOutputMin = 0x1F8
                m_nFieldOutput = 0x1EC
            class C_OP_CPOffsetToPercentageBetweenCPs:
                m_nEndCP = 0x1F0
                m_nInputCP = 0x1FC
                m_nOuputCP = 0x1F8
                m_nStartCP = 0x1EC
                m_nOffsetCP = 0x1F4
                m_vecOffset = 0x204
                m_flInputMax = 0x1E4
                m_flInputMin = 0x1E0
                m_flInputBias = 0x1E8
                m_bRadialCheck = 0x200
                m_bScaleOffset = 0x201
            class C_OP_ConnectParentParticleToNearest:
                m_bUseRadius = 0x1E8
                m_flRadiusScale = 0x1F0
                m_nFirstControlPoint = 0x1E0
                m_flParentRadiusScale = 0x368
                m_nSecondControlPoint = 0x1E4
            class C_OP_CylindricalDistanceToTransform:
                m_bCapsule = 0x89E
                m_bAdditive = 0x89D
                m_flInputMax = 0x360
                m_flInputMin = 0x1E8
                m_nSetMethod = 0x898
                m_flOutputMax = 0x650
                m_flOutputMin = 0x4D8
                m_TransformEnd = 0x830
                m_bActiveRange = 0x89C
                m_nFieldOutput = 0x1E0
                m_TransformStart = 0x7C8
            class C_OP_PinRopeSegmentParticleToParent:
                m_flInterpolation = 0x360
                m_nParticleNumber = 0x1E8
                m_nParticleSelection = 0x1E0
            class C_OP_RemapDistanceToLineSegmentBase:
                m_nCP0 = 0x1E0
                m_nCP1 = 0x1E4
                m_bInfiniteLine = 0x1F0
                m_flMaxInputValue = 0x1EC
                m_flMinInputValue = 0x1E8
            class C_OP_RemapNamedModelMeshGroupEndCap:
                pass
            class C_OP_RemapTransformOrientationToYaw:
                m_flRotOffset = 0x24C
                m_nFieldOutput = 0x248
                m_TransformInput = 0x1E0
                m_flSpinStrength = 0x250
            class C_OP_SetAttributeToScalarExpression:
                m_flInput1 = 0x1E8
                m_flInput2 = 0x360
                m_nSetMethod = 0x654
                m_nExpression = 0x1E0
                m_nOutputField = 0x650
                m_flOutputRemap = 0x4D8
            class C_OP_SetCPOrientationToGroundNormal:
                m_nInputCP = 0x274
                m_nOutputCP = 0x278
                m_nTraceSet = 0x270
                m_flTolerance = 0x1E8
                m_flInterpRate = 0x1E0
                m_bIncludeWater = 0x288
                m_flTraceOffset = 0x1EC
                m_flMaxTraceLength = 0x1E4
                m_CollisionGroupName = 0x1F0
            class C_OP_SetControlPointFromObjectScale:
                m_nCPInput = 0x1E8
                m_nCPOutput = 0x1EC
            class ParticleControlPointConfiguration_t:
                m_name = 0x0
                m_drivers = 0x8
                m_previewState = 0x20
            class CPulseCell_Timeline__TimelineEvent_t:
                m_EventOutflow = 0x8
                m_flTimeFromPrevious = 0x0
            class CPulseCell_WaitForCursorsWithTagBase:
                m_WaitComplete = 0xE0
                m_nCursorsAllowedToWait = 0xD8
            class C_OP_ControlPointToRadialScreenSpace:
                m_nCPIn = 0x1E8
                m_nCPOut = 0x1F8
                m_vecCP1Pos = 0x1EC
                m_nCPOutField = 0x1FC
                m_nCPSSPosOut = 0x200
            class C_OP_RemapNamedModelElementOnceTimed:
                m_hModel = 0x1E0
                m_inNames = 0x1E8
                m_outNames = 0x200
                m_flRemapTime = 0x23C
                m_nFieldInput = 0x234
                m_nFieldOutput = 0x238
                m_bProportional = 0x231
                m_fallbackNames = 0x218
                m_bModelFromRenderer = 0x230
            class C_OP_SetParentControlPointsToChildCP:
                m_nChildGroupID = 0x1E8
                m_bSetOrientation = 0x1F8
                m_nFirstSourcePoint = 0x1F4
                m_nNumControlPoints = 0x1F0
                m_nChildControlPoint = 0x1EC
            class C_INIT_RemapNamedModelElementToScalar:
                m_names = 0x1F0
                m_hModel = 0x1E8
                m_values = 0x208
                m_nSetMethod = 0x228
                m_nFieldInput = 0x220
                m_nFieldOutput = 0x224
                m_bModelFromRenderer = 0x22C
            class C_INIT_SetAttributeToScalarExpression:
                m_flInput1 = 0x1F0
                m_flInput2 = 0x368
                m_nSetMethod = 0x65C
                m_nExpression = 0x1E8
                m_nOutputField = 0x658
                m_flOutputRemap = 0x4E0
            class C_OP_MovementRotateParticleAroundAxis:
                m_flRotRate = 0x8B8
                m_vecRotAxis = 0x1E0
                m_bLocalSpace = 0xA98
                m_TransformInput = 0xA30
            class C_OP_RemapNamedModelBodyPartOnceTimed:
                pass
            class C_OP_RemapNamedModelSequenceOnceTimed:
                pass
            class C_OP_RemapParticleCountOnScalarEndCap:
                m_nInputMax = 0x1E8
                m_nInputMin = 0x1E4
                m_bBackwards = 0x1F4
                m_nSetMethod = 0x1F8
                m_flOutputMax = 0x1F0
                m_flOutputMin = 0x1EC
                m_nFieldOutput = 0x1E0
            class C_OP_RemapTransformVisibilityToScalar:
                m_flRadius = 0x264
                m_flInputMax = 0x258
                m_flInputMin = 0x254
                m_nSetMethod = 0x1E0
                m_flOutputMax = 0x260
                m_flOutputMin = 0x25C
                m_nFieldOutput = 0x250
                m_TransformInput = 0x1E8
            class C_OP_RemapTransformVisibilityToVector:
                m_flRadius = 0x274
                m_flInputMax = 0x258
                m_flInputMin = 0x254
                m_nSetMethod = 0x1E0
                m_nFieldOutput = 0x250
                m_vecOutputMax = 0x268
                m_vecOutputMin = 0x25C
                m_TransformInput = 0x1E8
            class C_OP_SetControlPointsToModelParticles:
                m_bSkin = 0x2EC
                m_bAttachment = 0x2ED
                m_HitboxSetName = 0x1E0
                m_AttachmentName = 0x260
                m_nFirstSourcePoint = 0x2E8
                m_nNumControlPoints = 0x2E4
                m_nFirstControlPoint = 0x2E0
            class CPulseCell_LimitCount__InstanceState_t:
                m_nCurrentCount = 0x0
            class C_INIT_RemapNamedModelBodyPartToScalar:
                pass
            class C_INIT_RemapNamedModelSequenceToScalar:
                pass
            class C_OP_PercentageBetweenTransformLerpCPs:
                m_flInputMax = 0x1E8
                m_flInputMin = 0x1E4
                m_nSetMethod = 0x2D0
                m_TransformEnd = 0x258
                m_bActiveRange = 0x2D4
                m_bRadialCheck = 0x2D5
                m_nFieldOutput = 0x1E0
                m_nOutputEndCP = 0x2C8
                m_TransformStart = 0x1F0
                m_nOutputStartCP = 0x2C0
                m_nOutputEndField = 0x2CC
                m_nOutputStartField = 0x2C4
            class C_OP_PercentageBetweenTransformsVector:
                m_flInputMax = 0x1E8
                m_flInputMin = 0x1E4
                m_nSetMethod = 0x2D8
                m_TransformEnd = 0x270
                m_bActiveRange = 0x2DC
                m_bRadialCheck = 0x2DD
                m_nFieldOutput = 0x1E0
                m_vecOutputMax = 0x1F8
                m_vecOutputMin = 0x1EC
                m_TransformStart = 0x208
            class C_OP_RemapNamedModelMeshGroupOnceTimed:
                pass
            class C_OP_SetControlPointToVectorExpression:
                m_flLerp = 0xFA0
                m_vInput1 = 0x1F0
                m_vInput2 = 0x8C8
                m_nOutputCP = 0x1EC
                m_nExpression = 0x1E8
                m_bNormalizedOutput = 0x1118
            class CPulseCell_IntervalTimer__CursorState_t:
                m_EndTime = 0x4
                m_StartTime = 0x0
                m_flWaitInterval = 0x8
                m_flWaitIntervalHigh = 0xC
                m_bCompleteOnNextWake = 0x10
            class C_INIT_RemapNamedModelMeshGroupToScalar:
                pass
            class C_OP_MovementMoveAlongSkinnedCPSnapshot:
                m_flTValue = 0x368
                m_bSetNormal = 0x1E8
                m_bSetRadius = 0x1E9
                m_flInterpolation = 0x1F0
                m_nControlPointNumber = 0x1E0
                m_nSnapshotControlPointNumber = 0x1E4
            class C_OP_RemapControlPointDirectionToVector:
                m_flScale = 0x1E4
                m_nFieldOutput = 0x1E0
                m_nControlPointNumber = 0x1E8
            class C_OP_RemapDistanceToLineSegmentToScalar:
                m_nFieldOutput = 0x1F8
                m_flMaxOutputValue = 0x200
                m_flMinOutputValue = 0x1FC
            class C_OP_RemapDistanceToLineSegmentToVector:
                m_nFieldOutput = 0x1F8
                m_vMaxOutputValue = 0x208
                m_vMinOutputValue = 0x1FC
            class C_INIT_InitSkinnedPositionFromCPSnapshot:
                m_bRigid = 0x1F8
                m_bRandom = 0x1F0
                m_bIgnoreDt = 0x1FA
                m_bCopyAlpha = 0x395
                m_bCopyColor = 0x394
                m_bSetNormal = 0x1F9
                m_bSetRadius = 0x396
                m_nIndexType = 0x204
                m_flIncrement = 0x380
                m_flReadIndex = 0x208
                m_nRandomSeed = 0x1F4
                m_flBoneVelocity = 0x38C
                m_flBoneVelocityMax = 0x390
                m_nFullLoopIncrement = 0x384
                m_flMaxNormalVelocity = 0x200
                m_flMinNormalVelocity = 0x1FC
                m_nControlPointNumber = 0x1EC
                m_nSnapShotStartPoint = 0x388
                m_nSnapshotControlPointNumber = 0x1E8
            class C_OP_SetFloatAttributeToVectorExpression:
                m_vInput1 = 0x1E8
                m_vInput2 = 0x8C0
                m_nSetMethod = 0x1114
                m_nExpression = 0x1E0
                m_nOutputField = 0x1110
                m_flOutputRemap = 0xF98
            class CPulseCell_IsRequirementValid__Criteria_t:
                m_bIsValid = 0x0
            class C_OP_ConstrainDistanceToUserSpecifiedPath:
                m_pointList = 0x1F0
                m_bLoopedPath = 0x1EC
                m_flTimeScale = 0x1E8
                m_fMinDistance = 0x1E0
                m_flMaxDistance = 0x1E4
            class C_OP_MultiSegmentDisplaySnapshotGenerator:
                m_flValue = 0x200
                m_flRadius = 0x12B8
                m_flSpacing = 0x1430
                m_nSegCount = 0x1EC
                m_flMaxCount = 0x1720
                m_flMinCount = 0x15A8
                m_nInputType = 0x1F0
                m_nCPSnapshot = 0x1E8
                m_vecColorLit = 0xBE0
                m_bPrependEmpty = 0x1898
                m_flScollOffset = 0x378
                m_vecColorUnlit = 0x508
                m_SpecialCharList = 0x4F0
                m_strDefaultString = 0x1F8
                m_flDigitsAfterDecimal = 0x18A0
            class C_OP_RemapTransformOrientationToRotations:
                m_bUseQuat = 0x254
                m_vecRotation = 0x248
                m_bWriteNormal = 0x255
                m_TransformInput = 0x1E0
            class C_OP_SetPerChildControlPointFromAttribute:
                m_nCPField = 0x1FC
                m_nChildGroupID = 0x1E0
                m_nAttributeToRead = 0x1F8
                m_nFirstSourcePoint = 0x1F0
                m_nNumControlPoints = 0x1E8
                m_nFirstControlPoint = 0x1E4
                m_nParticleIncrement = 0x1EC
                m_bNumBasedOnParticleCount = 0x1F4
            class C_OP_SetVectorAttributeToVectorExpression:
                m_flLerp = 0xF98
                m_vInput1 = 0x1E8
                m_vInput2 = 0x8C0
                m_nSetMethod = 0x1114
                m_nExpression = 0x1E0
                m_nOutputField = 0x1110
                m_bNormalizedOutput = 0x1118
            class C_INIT_SetFloatAttributeToVectorExpression:
                m_vInput1 = 0x1F0
                m_vInput2 = 0x8C8
                m_nSetMethod = 0x111C
                m_nExpression = 0x1E8
                m_nOutputField = 0x1118
                m_flOutputRemap = 0xFA0
            class C_OP_EnableChildrenFromParentParticleCount:
                m_nFirstChild = 0x1EC
                m_nChildGroupID = 0x1E8
                m_bDisableChildren = 0x368
                m_bPlayEndcapOnStop = 0x369
                m_bDestroyImmediately = 0x36A
                m_nNumChildrenToEnable = 0x1F0
            class C_OP_MovementSkinnedPositionFromCPSnapshot:
                m_bRandom = 0x1E8
                m_bSetNormal = 0x1F0
                m_bSetRadius = 0x1F1
                m_nIndexType = 0x1F4
                m_flIncrement = 0x370
                m_flReadIndex = 0x1F8
                m_nRandomSeed = 0x1EC
                m_flInterpolation = 0x7D8
                m_nFullLoopIncrement = 0x4E8
                m_nControlPointNumber = 0x1E4
                m_nSnapShotStartPoint = 0x660
                m_nSnapshotControlPointNumber = 0x1E0
            class C_OP_RemapCrossProductOfTwoVectorsToVector:
                m_InputVec1 = 0x1E0
                m_InputVec2 = 0x8B8
                m_bNormalize = 0xF94
                m_nFieldOutput = 0xF90
            class C_OP_RemapDensityGradientToVectorAttribute:
                m_nFieldOutput = 0x1E4
                m_flRadiusScale = 0x1E0
            class C_INIT_RemapTransformOrientationToRotations:
                m_bUseQuat = 0x25C
                m_vecRotation = 0x250
                m_bWriteNormal = 0x25D
                m_TransformInput = 0x1E8
            class C_INIT_SetVectorAttributeToVectorExpression:
                m_flLerp = 0xFA0
                m_vInput1 = 0x1F0
                m_vInput2 = 0x8C8
                m_nSetMethod = 0x111C
                m_nExpression = 0x1E8
                m_nOutputField = 0x1118
                m_bNormalizedOutput = 0x1120
            class C_OP_RemapControlPointOrientationToRotation:
                m_nCP = 0x1E0
                m_nComponent = 0x1EC
                m_flOffsetRot = 0x1E8
                m_nFieldOutput = 0x1E4
            class C_OP_SetControlPointFieldToScalarExpression:
                m_flInput1 = 0x1F0
                m_flInput2 = 0x368
                m_nOutputCP = 0x658
                m_nExpression = 0x1E8
                m_flOutputRemap = 0x4E0
                m_flInterpolation = 0x660
                m_nOutVectorField = 0x65C
            class C_OP_SetControlPointOrientationToCPVelocity:
                m_nCPInput = 0x1E8
                m_nCPOutput = 0x1EC
            class CPulseCell_Inflow_ObservableVariableListener:
                m_bSelfReference = 0x82
                m_nBlackboardReference = 0x80
            class C_OP_SetControlPointPositionToRandomActiveCP:
                m_nCP1 = 0x1E8
                m_flResetRate = 0x1F8
                m_nHeadLocationMax = 0x1F0
                m_nHeadLocationMin = 0x1EC
            class C_OP_SetControlPointPositionToTimeOfDayValue:
                m_vecDefaultValue = 0x26C
                m_nControlPointNumber = 0x1E8
                m_pszTimeOfDayParameter = 0x1EC
            class PulseNodeDynamicOutflows_t__DynamicOutflow_t:
                m_OutflowID = 0x0
                m_Connection = 0x8
            class C_OP_SetControlPointFieldFromVectorExpression:
                m_flLerp = 0xFA0
                m_nOutputCP = 0x1290
                m_vecInput1 = 0x1F0
                m_vecInput2 = 0x8C8
                m_nExpression = 0x1E8
                m_flOutputRemap = 0x1118
                m_nOutVectorField = 0x1294
            class C_INIT_RemapInitialDirectionToTransformToVector:
                m_flScale = 0x254
                m_bNormalize = 0x268
                m_flOffsetRot = 0x258
                m_nFieldOutput = 0x250
                m_vecOffsetAxis = 0x25C
                m_TransformInput = 0x1E8
            class C_INIT_RemapInitialTransformDirectionToRotation:
                m_nComponent = 0x258
                m_flOffsetRot = 0x254
                m_nFieldOutput = 0x250
                m_TransformInput = 0x1E8
            class CPulseCell_Outflow_CycleOrdered__InstanceState_t:
                m_nNextIndex = 0x0
            class CPulseCell_Outflow_CycleShuffled__InstanceState_t:
                m_Shuffle = 0x0
                m_nNextShuffle = 0x20
            class C_INIT_RemapParticleCountToNamedModelElementScalar:
                m_hModel = 0x218
                m_outputMaxName = 0x228
                m_outputMinName = 0x220
                m_bModelFromRenderer = 0x230
            class C_INIT_RemapParticleCountToNamedModelBodyPartScalar:
                pass
            class C_INIT_RemapParticleCountToNamedModelSequenceScalar:
                pass
            class C_INIT_RemapParticleCountToNamedModelMeshGroupScalar:
                pass
            class DetailCombo_t:
                DETAIL_COMBO_ADD = 0x1
                DETAIL_COMBO_OFF = 0x0
                DETAIL_COMBO_MOD2X = 0x3
                DETAIL_COMBO_ADD_SELF_ILLUM = 0x2
            class Detail2Combo_t:
                DETAIL_2_COMBO_ADD = 0x1
                DETAIL_2_COMBO_MUL = 0x4
                DETAIL_2_COMBO_OFF = 0x0
                DETAIL_2_COMBO_MOD2X = 0x3
                DETAIL_2_COMBO_CROSSFADE = 0x5
                DETAIL_2_COMBO_UNINITIALIZED = -0x1
                DETAIL_2_COMBO_ADD_SELF_ILLUM = 0x2
            class PetGroundType_t:
                PET_GROUND_GRID = 0x1
                PET_GROUND_NONE = 0x0
                PET_GROUND_PLANE = 0x2
            class BBoxVolumeType_t:
                BBOX_RADIUS = 0x3
                BBOX_VOLUME = 0x0
                BBOX_MINS_MAXS = 0x2
                BBOX_DIMENSIONS = 0x1
                BBOX_SURFACE_AREA = 0x4
            class BlurFilterType_t:
                BLURFILTER_BOX = 0x1
                BLURFILTER_GAUSSIAN = 0x0
            class HitboxLerpType_t:
                HITBOX_LERP_CONSTANT = 0x1
                HITBOX_LERP_LIFETIME = 0x0
            class ModelHitboxType_t:
                MODEL_HITBOX_TYPE_SNAPSHOT = 0x3
                MODEL_HITBOX_TYPE_STANDARD = 0x0
                MODEL_HITBOX_TYPE_RAW_BONES = 0x1
                MODEL_HITBOX_TYPE_RENDERBOUNDS = 0x2
            class ParticleFanType_t:
                PARTICLE_FAN_TYPE_FAN = 0x0
                PARTICLE_FAN_TYPE_RADIAL = 0x2
                PARTICLE_FAN_TYPE_ROTOR_WASH = 0x1
            class ParticleFogType_t:
                PARTICLE_FOG_ENABLED = 0x1
                PARTICLE_FOG_DISABLED = 0x2
                PARTICLE_FOG_GAME_DEFAULT = 0x0
            class ParticleMassMode_t:
                PARTICLE_MASSMODE_RADIUS_CUBED = 0x0
                PARTICLE_MASSMODE_RADIUS_SQUARED = 0x2
            class ParticleTopology_t:
                PARTICLE_TOPOLOGY_TRIS = 0x2
                PARTICLE_TOPOLOGY_CUBES = 0x4
                PARTICLE_TOPOLOGY_LINES = 0x1
                PARTICLE_TOPOLOGY_QUADS = 0x3
                PARTICLE_TOPOLOGY_POINTS = 0x0
            class ParticleTraceSet_t:
                PARTICLE_TRACE_SET_ALL = 0x0
                PARTICLE_TRACE_SET_STATIC = 0x1
                PARTICLE_TRACE_SET_DYNAMIC = 0x3
                PARTICLE_TRACE_SET_STATIC_AND_KEYFRAMED = 0x2
            class MaterialProxyType_t:
                MATERIAL_PROXY_TINT = 0x1
                MATERIAL_PROXY_STATUS_EFFECT = 0x0
            class ParticleEntityPos_t:
                PARTICLE_EYES = 0x2
                PARTICLE_ABS_ORIGIN = 0x0
                PARTICLE_FLASHLIGHT = 0x3
                PARTICLE_WORLDSPACE_CENTER = 0x1
            class ParticleSelection_t:
                PARTICLE_SELECTION_LAST = 0x1
                PARTICLE_SELECTION_FIRST = 0x0
                PARTICLE_SELECTION_NUMBER = 0x2
            class SnapshotIndexType_t:
                SNAPSHOT_INDEX_DIRECT = 0x1
                SNAPSHOT_INDEX_INCREMENT = 0x0
            class EventTypeSelection_t:
                PARTICLE_EVENT_TYPE_MASK_NONE = 0x0
                PARTICLE_EVENT_TYPE_MASK_KILLED = 0x2
                PARTICLE_EVENT_TYPE_MASK_USER_1 = 0x40
                PARTICLE_EVENT_TYPE_MASK_USER_2 = 0x80
                PARTICLE_EVENT_TYPE_MASK_USER_3 = 0x100
                PARTICLE_EVENT_TYPE_MASK_USER_4 = 0x200
                PARTICLE_EVENT_TYPE_MASK_SPAWNED = 0x1
                PARTICLE_EVENT_TYPE_MASK_COLLISION = 0x4
                PARTICLE_EVENT_TYPE_MASK_KILLED_ON_CULL = 0x400
                PARTICLE_EVENT_TYPE_MASK_CULLED_ON_SPAWN = 0x800
                PARTICLE_EVENT_TYPE_MASK_FIRST_COLLISION = 0x8
                PARTICLE_EVENT_TYPE_MASK_COLLISION_STOPPED = 0x10
                PARTICLE_EVENT_TYPE_MASK_KILLED_ON_COLLISION = 0x20
            class ParticleEndcapMode_t:
                PARTICLE_ENDCAP_ALWAYS_ON = -0x1
                PARTICLE_ENDCAP_ENDCAP_ON = 0x1
                PARTICLE_ENDCAP_ENDCAP_OFF = 0x0
            class ParticleToolsState_t:
                PARTICLE_TOOLS_STATE_ALWAYS_ON = -0x1
                PARTICLE_TOOLS_STATE_GAME_ONLY = 0x1
                PARTICLE_TOOLS_STATE_TOOLS_ONLY = 0x0
            class InheritableBoolType_t:
                INHERITABLE_BOOL_TRUE = 0x2
                INHERITABLE_BOOL_FALSE = 0x1
                INHERITABLE_BOOL_INHERIT = 0x0
            class ParticleDetailLevel_t:
                PARTICLEDETAIL_LOW = 0x0
                PARTICLEDETAIL_HIGH = 0x2
                PARTICLEDETAIL_ULTRA = 0x3
                PARTICLEDETAIL_MEDIUM = 0x1
            class ParticleImpulseType_t:
                IMPULSE_TYPE_NONE = 0x0
                IMPULSE_TYPE_ROPE = 0x2
                IMPULSE_TYPE_GENERIC = 0x1
                IMPULSE_TYPE_EXPLOSION = 0x4
                IMPULSE_TYPE_PARTICLE_SYSTEM = 0x10
                IMPULSE_TYPE_EXPLOSION_UNDERWATER = 0x8
            class ParticlePinDistance_t:
                PARTICLE_PIN_SPEED = 0x9
                PARTICLE_PIN_DISTANCE_CP = 0x6
                PARTICLE_PIN_FLOAT_VALUE = 0xB
                PARTICLE_PIN_DISTANCE_LAST = 0x3
                PARTICLE_PIN_DISTANCE_NONE = -0x1
                PARTICLE_PIN_COLLECTION_AGE = 0xA
                PARTICLE_PIN_DISTANCE_FIRST = 0x2
                PARTICLE_PIN_DISTANCE_CENTER = 0x5
                PARTICLE_PIN_DISTANCE_FARTHEST = 0x1
                PARTICLE_PIN_DISTANCE_NEIGHBOR = 0x0
                PARTICLE_PIN_DISTANCE_CP_PAIR_BOTH = 0x8
                PARTICLE_PIN_DISTANCE_CP_PAIR_EITHER = 0x7
            class PulseMethodCallMode_t:
                ASYNC_FIRE_AND_FORGET = 0x1
                SYNC_WAIT_FOR_COMPLETION = 0x0
            class ClosestPointTestType_t:
                PARTICLE_CLOSEST_TYPE_BOX = 0x0
                PARTICLE_CLOSEST_TYPE_HYBRID = 0x2
                PARTICLE_CLOSEST_TYPE_CAPSULE = 0x1
            class ParticleAttrBoxFlags_t:
                PARTICLE_ATTR_BOX_FLAGS_NONE = 0x0
                PARTICLE_ATTR_BOX_FLAGS_WATER = 0x1
                PARTICLE_ATTR_BOX_FLAGS_ASLEEP = 0x8
                PARTICLE_ATTR_BOX_FLAGS_FROZEN = 0x10
                PARTICLE_ATTR_BOX_FLAGS_ON_FIRE = 0x2
                PARTICLE_ATTR_BOX_FLAGS_WAKE_DECAY = 0x80
                PARTICLE_ATTR_BOX_FLAGS_ELECTRIFIED = 0x4
                PARTICLE_ATTR_BOX_FLAGS_TIMED_DECAY = 0x20
                PARTICLE_ATTR_BOX_FLAGS_ZERO_GRAVITY = 0x200
                PARTICLE_ATTR_BOX_FLAGS_MOTION_DISABLED = 0x100
                PARTICLE_ATTR_BOX_FLAGS_DISABLE_NONSTATIC_COLLISION = 0x40
            class ScalarExpressionType_t:
                SCALAR_EXPRESSION_GT = 0x9
                SCALAR_EXPRESSION_LT = 0xA
                SCALAR_EXPRESSION_ADD = 0x0
                SCALAR_EXPRESSION_MAX = 0x6
                SCALAR_EXPRESSION_MIN = 0x5
                SCALAR_EXPRESSION_MOD = 0x7
                SCALAR_EXPRESSION_MUL = 0x2
                SCALAR_EXPRESSION_EQUAL = 0x8
                SCALAR_EXPRESSION_DIVIDE = 0x3
                SCALAR_EXPRESSION_INPUT_1 = 0x4
                SCALAR_EXPRESSION_SUBTRACT = 0x1
                SCALAR_EXPRESSION_UNINITIALIZED = -0x1
            class SpriteCardShaderType_t:
                SPRITECARD_SHADER_BASE = 0x0
                SPRITECARD_SHADER_CUSTOM = 0x1
            class VectorExpressionType_t:
                VECTOR_EXPRESSION_ADD = 0x0
                VECTOR_EXPRESSION_MAX = 0x6
                VECTOR_EXPRESSION_MIN = 0x5
                VECTOR_EXPRESSION_MUL = 0x2
                VECTOR_EXPRESSION_LERP = 0x8
                VECTOR_EXPRESSION_DIVIDE = 0x3
                VECTOR_EXPRESSION_INPUT_1 = 0x4
                VECTOR_EXPRESSION_SUBTRACT = 0x1
                VECTOR_EXPRESSION_CROSSPRODUCT = 0x7
                VECTOR_EXPRESSION_UNINITIALIZED = -0x1
            class ParticleCollisionMask_t:
                PARTICLE_MASK_ALL = -0x1
                PARTICLE_MASK_SHOT = 0x1C1003
                PARTICLE_MASK_SOLID = 0xC3001
                PARTICLE_MASK_WATER = 0x18000
                PARTICLE_MASK_OPAQUE = 0x80
                PARTICLE_MASK_NPCSOLID = 0xC3021
                PARTICLE_MASK_SHOT_HULL = 0x1C3001
                PARTICLE_MASK_SOLID_WATER = 0xDB001
                PARTICLE_MASK_SHOT_BRUSHONLY = 0x101001
                PARTICLE_MASK_DEFAULTPLAYERSOLID = 0xC3011
            class ParticleCollisionMode_t:
                COLLISION_MODE_DISABLED = -0x1
                COLLISION_MODE_USE_NEAREST_TRACE = 0x2
                COLLISION_MODE_INITIAL_TRACE_DOWN = 0x0
                COLLISION_MODE_PER_FRAME_PLANESET = 0x1
                COLLISION_MODE_PER_PARTICLE_TRACE = 0x3
            class ParticleParentSetMode_t:
                PARTICLE_SET_PARENT_NO = 0x0
                PARTICLE_SET_PARENT_ROOT = 0x2
                PARTICLE_SET_PARENT_IMMEDIATE = 0x1
            class PulseBestOutflowRules_t:
                SORT_BY_OUTFLOW_INDEX = 0x1
                SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0
            class SpriteCardTextureType_t:
                SPRITECARD_TEXTURE_ZOOM = 0x1
                SPRITECARD_TEXTURE_DEPTH = 0xA
                SPRITECARD_TEXTURE_DIFFUSE = 0x0
                SPRITECARD_TEXTURE_NORMALMAP = 0x5
                SPRITECARD_TEXTURE_UVDISTORTION = 0x3
                SPRITECARD_TEXTURE_ANIMMOTIONVEC = 0x6
                SPRITECARD_TEXTURE_1D_COLOR_LOOKUP = 0x2
                SPRITECARD_TEXTURE_UVDISTORTION_ZOOM = 0x4
                SPRITECARD_TEXTURE_ILLUMINATION_GRADIENT = 0xB
                SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_A = 0x7
                SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_B = 0x8
                SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_C = 0x9
            class TextureRepetitionMode_t:
                TEXTURE_REPETITION_PATH = 0x1
                TEXTURE_REPETITION_PARTICLE = 0x0
            class PFuncVisualizationType_t:
                PFUNC_VISUALIZATION_BOX = 0x2
                PFUNC_VISUALIZATION_LINE = 0x5
                PFUNC_VISUALIZATION_RING = 0x3
                PFUNC_VISUALIZATION_PLANE = 0x4
                PFUNC_VISUALIZATION_CYLINDER = 0x6
                PFUNC_VISUALIZATION_SPHERE_SOLID = 0x1
                PFUNC_VISUALIZATION_SPHERE_WIREFRAME = 0x0
            class ParticleCollisionGroup_t:
                PARTICLE_COLLISION_GROUP_NPC = 0xC
                PARTICLE_COLLISION_GROUP_PROPS = 0x18
                PARTICLE_COLLISION_GROUP_DEBRIS = 0x5
                PARTICLE_COLLISION_GROUP_PLAYER = 0x8
                PARTICLE_COLLISION_GROUP_DEFAULT = 0x4
                PARTICLE_COLLISION_GROUP_VEHICLE = 0xA
                PARTICLE_COLLISION_GROUP_INTERACTIVE = 0x7
            class ParticleHitboxBiasType_t:
                PARTICLE_HITBOX_BIAS_ENTITY = 0x0
                PARTICLE_HITBOX_BIAS_HITBOX = 0x1
            class ParticleLiquidContents_t:
                PARTICLE_LIQUID_OIL = 0x1
                PARTICLE_LIQUID_NONE = 0x0
                PARTICLE_LIQUID_WATER = 0x2
            class ParticleFalloffFunction_t:
                PARTICLE_FALLOFF_LINEAR = 0x1
                PARTICLE_FALLOFF_CONSTANT = 0x0
                PARTICLE_FALLOFF_EXPONENTIAL = 0x2
            class ParticleLightingQuality_t:
                PARTICLE_LIGHTING_PER_PIXEL = -0x1
                PARTICLE_LIGHTING_PER_VERTEX = 0x1
                PARTICLE_LIGHTING_PER_PARTICLE = 0x0
                PARTICLE_LIGHTING_OVERRIDE_COLOR = 0x3
                PARTICLE_LIGHTING_ADD_EXTRA_LIGHT = 0x4
                PARTICLE_LIGHTING_OVERRIDE_POSITION = 0x2
            class ParticleOrientationType_t:
                PARTICLE_ORIENTATION_NONE = 0x0
                PARTICLE_ORIENTATION_NORMAL = 0x2
                PARTICLE_ORIENTATION_ROTATION = 0x4
                PARTICLE_ORIENTATION_VELOCITY = 0x1
            class ParticleOutputBlendMode_t:
                PARTICLE_OUTPUT_BLEND_MODE_ADD = 0x1
                PARTICLE_OUTPUT_BLEND_MODE_ALPHA = 0x0
                PARTICLE_OUTPUT_BLEND_MODE_MOD2X = 0x5
                PARTICLE_OUTPUT_BLEND_MODE_LIGHTEN = 0x6
                PARTICLE_OUTPUT_BLEND_MODE_BLEND_ADD = 0x2
                PARTICLE_OUTPUT_BLEND_MODE_HALF_BLEND_ADD = 0x3
                PARTICLE_OUTPUT_BLEND_MODE_NEG_HALF_BLEND_ADD = 0x4
            class PulseCursorWakePriority_t:
                WakeElegantly = 0x0
                WakeImmediate = 0x1
            class ParticleControlPointAxis_t:
                PARTICLE_CP_AXIS_X = 0x0
                PARTICLE_CP_AXIS_Y = 0x1
                PARTICLE_CP_AXIS_Z = 0x2
                PARTICLE_CP_AXIS_NEGATIVE_X = 0x3
                PARTICLE_CP_AXIS_NEGATIVE_Y = 0x4
                PARTICLE_CP_AXIS_NEGATIVE_Z = 0x5
            class ParticleRotationLockType_t:
                PARTICLE_ROTATION_LOCK_NONE = 0x0
                PARTICLE_ROTATION_LOCK_NORMAL = 0x2
                PARTICLE_ROTATION_LOCK_ROTATIONS = 0x1
            class ParticleVRHandChoiceList_t:
                PARTICLE_VRHAND_CP = 0x2
                PARTICLE_VRHAND_LEFT = 0x0
                PARTICLE_VRHAND_RIGHT = 0x1
                PARTICLE_VRHAND_CP_OBJECT = 0x3
            class SpriteCardTextureChannel_t:
                SPRITECARD_TEXTURE_CHANNEL_MIX_A = 0x2
                SPRITECARD_TEXTURE_CHANNEL_MIX_B = 0xB
                SPRITECARD_TEXTURE_CHANNEL_MIX_G = 0xA
                SPRITECARD_TEXTURE_CHANNEL_MIX_R = 0x9
                SPRITECARD_TEXTURE_CHANNEL_MIX_RGB = 0x0
                SPRITECARD_TEXTURE_CHANNEL_MIX_RGBA = 0x1
                SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_A = 0x3
                SPRITECARD_TEXTURE_CHANNEL_MIX_BALPHA = 0xE
                SPRITECARD_TEXTURE_CHANNEL_MIX_GALPHA = 0xD
                SPRITECARD_TEXTURE_CHANNEL_MIX_RALPHA = 0xC
                SPRITECARD_TEXTURE_CHANNEL_MIX_A_RGBALPHA = 0x7
                SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_RGBMASK = 0x5
                SPRITECARD_TEXTURE_CHANNEL_MIX_RGBA_RGBALPHA = 0x6
                SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_ALPHAMASK = 0x4
                SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_A_RGBALPHA = 0x8
            class ParticleSortingChoiceList_t:
                PARTICLE_SORTING_NEAREST = 0x0
                PARTICLE_SORTING_CREATION_TIME = 0x1
            class ParticleTraceMissBehavior_t:
                PARTICLE_TRACE_MISS_BEHAVIOR_KILL = 0x1
                PARTICLE_TRACE_MISS_BEHAVIOR_NONE = 0x0
                PARTICLE_TRACE_MISS_BEHAVIOR_TRACE_END = 0x2
            class PulseCursorCancelPriority_t:
                _None = 0x0
                HardCancel = 0x3
                SoftCancel = 0x2
                CancelOnSucceeded = 0x1
            class VectorFloatExpressionType_t:
                VECTOR_FLOAT_EXPRESSION_DISTANCE = 0x1
                VECTOR_FLOAT_EXPRESSION_DOTPRODUCT = 0x0
                VECTOR_FLOAT_EXPRESSION_DISTANCESQR = 0x2
                VECTOR_FLOAT_EXPRESSION_INPUT1_NOISE = 0x5
                VECTOR_FLOAT_EXPRESSION_INPUT1_LENGTH = 0x3
                VECTOR_FLOAT_EXPRESSION_UNINITIALIZED = -0x1
                VECTOR_FLOAT_EXPRESSION_INPUT1_LENGTHSQR = 0x4
            class ParticleAlphaReferenceType_t:
                PARTICLE_ALPHA_REFERENCE_ALPHA_ALPHA = 0x0
                PARTICLE_ALPHA_REFERENCE_ALPHA_OPAQUE = 0x2
                PARTICLE_ALPHA_REFERENCE_OPAQUE_ALPHA = 0x1
                PARTICLE_ALPHA_REFERENCE_OPAQUE_OPAQUE = 0x3
            class ParticleOrientationSetMode_t:
                PARTICLE_ORIENTATION_SET_NONE = -0x1
                PARTICLE_ORIENTATION_SET_FROM_NORMAL = 0x1
                PARTICLE_ORIENTATION_SET_FROM_VELOCITY = 0x0
                PARTICLE_ORIENTATION_SET_FROM_ROTATIONS = 0x2
            class SetStatisticExpressionType_t:
                SET_EXPRESSION_MAX = 0x6
                SET_EXPRESSION_MIN = 0x5
                SET_EXPRESSION_SUM = 0x0
                SET_EXPRESSION_MEAN = 0x1
                SET_EXPRESSION_MODE = 0x3
                SET_EXPRESSION_MEDIAN = 0x2
                SET_EXPRESSION_UNINITIALIZED = -0x1
                SET_EXPRESSION_STANDARD_DEVIATION = 0x4
            class SpriteCardPerParticleScale_t:
                SPRITECARD_TEXTURE_PP_SCALE_YAW = 0x8
                SPRITECARD_TEXTURE_PP_SCALE_NONE = 0x0
                SPRITECARD_TEXTURE_PP_SCALE_ROLL = 0x7
                SPRITECARD_TEXTURE_PP_SCALE_PITCH = 0x9
                SPRITECARD_TEXTURE_PP_SCALE_RANDOM = 0xA
                SPRITECARD_TEXTURE_PP_SCALE_NEG_RANDOM = 0xB
                SPRITECARD_TEXTURE_PP_SCALE_RANDOM_TIME = 0xC
                SPRITECARD_TEXTURE_PP_SCALE_PARTICLE_AGE = 0x1
                SPRITECARD_TEXTURE_PP_SCALE_SHADER_RADIUS = 0x6
                SPRITECARD_TEXTURE_PP_SCALE_PARTICLE_ALPHA = 0x5
                SPRITECARD_TEXTURE_PP_SCALE_ANIMATION_FRAME = 0x2
                SPRITECARD_TEXTURE_PP_SCALE_NEG_RANDOM_TIME = 0xD
                SPRITECARD_TEXTURE_PP_SCALE_SHADER_EXTRA_DATA1 = 0x3
                SPRITECARD_TEXTURE_PP_SCALE_SHADER_EXTRA_DATA2 = 0x4
            class ParticleDepthFeatheringMode_t:
                PARTICLE_DEPTH_FEATHERING_OFF = 0x0
                PARTICLE_DEPTH_FEATHERING_ON_OPTIONAL = 0x1
                PARTICLE_DEPTH_FEATHERING_ON_REQUIRED = 0x2
            class ParticleHitboxDataSelection_t:
                PARTICLE_HITBOX_COUNT = 0x1
                PARTICLE_HITBOX_AVERAGE_SPEED = 0x0
            class ParticleLightTypeChoiceList_t:
                PARTICLE_LIGHT_TYPE_FX = 0x2
                PARTICLE_LIGHT_TYPE_SPOT = 0x1
                PARTICLE_LIGHT_TYPE_POINT = 0x0
                PARTICLE_LIGHT_TYPE_CAPSULE = 0x3
            class ParticleLightUnitChoiceList_t:
                PARTICLE_LIGHT_UNIT_LUMENS = 0x1
                PARTICLE_LIGHT_UNIT_CANDELAS = 0x0
            class ParticleVolumetricSmokeType_t:
                PARTICLE_VOLUMETRIC_SMOKE_TYPE_SINK = 0x1
                PARTICLE_VOLUMETRIC_SMOKE_TYPE_REPEL = 0x2
                PARTICLE_VOLUMETRIC_SMOKE_TYPE_TRACE = 0x3
                PARTICLE_VOLUMETRIC_SMOKE_TYPE_EMISSION = 0x0
            class MissingParentInheritBehavior_t:
                MISSING_PARENT_KILL = 0x0
                MISSING_PARENT_FIND_NEW = 0x1
                MISSING_PARENT_DO_NOTHING = -0x1
                MISSING_PARENT_SAME_INDEX = 0x2
            class ParticleLightFogLightingMode_t:
                PARTICLE_LIGHT_FOG_LIGHTING_MODE_NONE = 0x0
                PARTICLE_LIGHT_FOG_LIGHTING_MODE_DYNAMIC = 0x2
                PARTICLE_LIGHT_FOG_LIGHTING_MODE_DYNAMIC_NOSHADOWS = 0x4
            class ParticleSequenceCropOverride_t:
                PARTICLE_SEQUENCE_CROP_OVERRIDE_DEFAULT = -0x1
                PARTICLE_SEQUENCE_CROP_OVERRIDE_FORCE_ON = 0x1
                PARTICLE_SEQUENCE_CROP_OVERRIDE_FORCE_OFF = 0x0
            class RenderModelSubModelFieldType_t:
                SUBMODEL_AS_MESHGROUP_MASK = 0x2
                SUBMODEL_AS_MESHGROUP_INDEX = 0x1
                SUBMODEL_AS_BODYGROUP_SUBMODEL = 0x0
                SUBMODEL_IGNORED_USE_MODEL_DEFAULT_MESHGROUP_MASK = 0x3
            class ParticleOrientationChoiceList_t:
                PARTICLE_ORIENTATION_SCREEN_ALIGNED = 0x0
                PARTICLE_ORIENTATION_WORLD_Z_ALIGNED = 0x2
                PARTICLE_ORIENTATION_SCREEN_Z_ALIGNED = 0x1
                PARTICLE_ORIENTATION_FULL_3AXIS_ROTATION = 0x5
                PARTICLE_ORIENTATION_ALIGN_TO_PARTICLE_NORMAL = 0x3
                PARTICLE_ORIENTATION_SCREENALIGN_TO_PARTICLE_NORMAL = 0x4
            class ParticleTextureLayerBlendType_t:
                SPRITECARD_TEXTURE_BLEND_ADD = 0x3
                SPRITECARD_TEXTURE_BLEND_MOD2X = 0x1
                SPRITECARD_TEXTURE_BLEND_AVERAGE = 0x5
                SPRITECARD_TEXTURE_BLEND_REPLACE = 0x2
                SPRITECARD_TEXTURE_BLEND_MULTIPLY = 0x0
                SPRITECARD_TEXTURE_BLEND_SUBTRACT = 0x4
                SPRITECARD_TEXTURE_BLEND_LUMINANCE = 0x6
            class ParticleLightBehaviorChoiceList_t:
                PARTICLE_LIGHT_BEHAVIOR_ROPE = 0x1
                PARTICLE_LIGHT_BEHAVIOR_TRAILS = 0x2
                PARTICLE_LIGHT_BEHAVIOR_FOLLOW_DIRECTION = 0x0
            class ParticleLightnintBranchBehavior_t:
                PARTICLE_LIGHTNING_BRANCH_CURRENT_DIR = 0x0
                PARTICLE_LIGHTNING_BRANCH_ENDPOINT_DIR = 0x1
            class ParticleOmni2LightTypeChoiceList_t:
                PARTICLE_OMNI2_LIGHT_TYPE_BARN = 0x2
                PARTICLE_OMNI2_LIGHT_TYPE_POINT = 0x0
                PARTICLE_OMNI2_LIGHT_TYPE_SPHERE = 0x1
            class ParticlePostProcessPriorityGroup_t:
                PARTICLE_POST_PROCESS_PRIORITY_GLOBAL_UI = 0x5
                PARTICLE_POST_PROCESS_PRIORITY_LEVEL_VOLUME = 0x0
                PARTICLE_POST_PROCESS_PRIORITY_LEVEL_OVERRIDE = 0x1
                PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_EFFECT = 0x2
                PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_STATE_LOW = 0x3
                PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_STATE_HIGH = 0x4
            class StandardLightingAttenuationStyle_t:
                LIGHT_STYLE_NEW = 0x1
                LIGHT_STYLE_OLD = 0x0
            class ParticleMultiSegmentCountSelection_t:
                PARTICLE_MULTISEGMENT_SEG_COUNT_7 = 0x7
                PARTICLE_MULTISEGMENT_SEG_COUNT_14 = 0xE
                PARTICLE_MULTISEGMENT_SEG_COUNT_16 = 0x10
            class ParticleMultiSegmentInputSelection_t:
                PARTICLE_MULTISEGMENT_SELECTION_FLOAT = 0x0
                PARTICLE_MULTISEGMENT_SELECTION_STRING = 0x1
            class ParticleVolumetricSmokeCreationType_t:
                PARTICLE_VOLUMETRIC_SMOKE_TYPE_IMPULSE = 0x1
                PARTICLE_VOLUMETRIC_SMOKE_TYPE_CONTINUOUS = 0x0
            class ParticleMultiSegmentSpecialCharacter_t:
                PARTICLE_MULTISEGMENT_SPECIAL_NONE = -0x1
                PARTICLE_MULTISEGMENT_SPECIAL_COLON = 0x1
                PARTICLE_MULTISEGMENT_SPECIAL_DECIMAL = 0x0
                PARTICLE_MULTISEGMENT_SPECIAL_DEGREES = 0x2
            class ParticleOmni2LighOrientationChoiceList_t:
                PARTICLE_OMNI2_LIGHT_ORIENTATION_NORMAL = 0x1
                PARTICLE_OMNI2_LIGHT_ORIENTATION_TARGET = 0x3
                PARTICLE_OMNI2_LIGHT_ORIENTATION_ROTATIONS = 0x0
                PARTICLE_OMNI2_LIGHT_ORIENTATION_NORMAL_ROLL = 0x2
                PARTICLE_OMNI2_LIGHT_ORIENTATION_TARGET_ROLL = 0x4
