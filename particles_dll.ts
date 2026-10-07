export namespace cs2_dumper {
    export namespace schemas {
        export namespace particles_dll {
            export namespace C_OP_Cull {
                export const m_flCullEnd = 0x1E8;
                export const m_flCullExp = 0x1EC;
                export const m_flCullPerc = 0x1E0;
                export const m_flCullStart = 0x1E4;
            }
            export namespace C_OP_Spin {

            }
            export namespace C_OP_Decay {
                export const m_bRopeDecay = 0x1E0;
                export const m_bForcePreserveParticleOrder = 0x1E1;
            }
            export namespace C_OP_Noise {
                export const m_bAdditive = 0x1F0;
                export const m_flOutputMax = 0x1E8;
                export const m_flOutputMin = 0x1E4;
                export const m_nFieldOutput = 0x1E0;
                export const m_fl4NoiseScale = 0x1EC;
                export const m_flNoiseAnimationTimeScale = 0x1F4;
            }
            export namespace C_OP_FadeIn {
                export const m_bProportional = 0x1EC;
                export const m_flFadeInTimeExp = 0x1E8;
                export const m_flFadeInTimeMax = 0x1E4;
                export const m_flFadeInTimeMin = 0x1E0;
            }
            export namespace C_OP_SetVec {
                export const m_Lerp = 0x8C0;
                export const m_InputValue = 0x1E0;
                export const m_nSetMethod = 0x8BC;
                export const m_nOutputField = 0x8B8;
                export const m_bNormalizedOutput = 0xA38;
            }
            export namespace CGeneralSpin {
                export const m_nSpinRateDegrees = 0x1E0;
                export const m_fSpinRateStopTime = 0x1EC;
                export const m_nSpinRateMinDegrees = 0x1E4;
            }
            export namespace C_OP_FadeOut {
                export const m_flFadeBias = 0x1EC;
                export const m_bEaseInAndOut = 0x221;
                export const m_bProportional = 0x220;
                export const m_flFadeOutTimeExp = 0x1E8;
                export const m_flFadeOutTimeMax = 0x1E4;
                export const m_flFadeOutTimeMin = 0x1E0;
            }
            export namespace C_OP_SetToCP {
                export const m_vecOffset = 0x1E4;
                export const m_bOffsetLocal = 0x1F0;
                export const m_nControlPointNumber = 0x1E0;
            }
            export namespace C_OP_SpinYaw {

            }
            export namespace C_OP_Callback {

            }
            export namespace C_OP_SetFloat {
                export const m_Lerp = 0x360;
                export const m_InputValue = 0x1E0;
                export const m_nSetMethod = 0x35C;
                export const m_nOutputField = 0x358;
            }
            export namespace CPAssignment_t {
                export const m_Pos = 0x8;
                export const m_nCPNumber = 0x0;
                export const m_nOrientationMode = 0x6E0;
            }
            export namespace CPulseGraphDef {
                export const m_Vars = 0x80;
                export const m_Cells = 0x68;
                export const m_Chunks = 0x50;
                export const m_CallInfos = 0xE0;
                export const m_Constants = 0xF8;
                export const m_DomainValues = 0x110;
                export const m_TempVarBanks = 0x98;
                export const m_DomainSubType = 0x18;
                export const m_ParentMapName = 0x30;
                export const m_ParentXmlName = 0x40;
                export const m_PublicOutputs = 0xB0;
                export const m_InvokeBindings = 0xC8;
                export const m_DomainIdentifier = 0x8;
                export const m_OutputConnections = 0x140;
                export const m_BlackboardReferences = 0x128;
            }
            export namespace C_INIT_InitVec {
                export const m_InputValue = 0x1E8;
                export const m_nSetMethod = 0x8C4;
                export const m_nOutputField = 0x8C0;
                export const m_bNormalizedOutput = 0x8C8;
                export const m_bWritePreviousPosition = 0x8C9;
            }
            export namespace C_OP_Diffusion {
                export const m_nFieldOutput = 0x1E4;
                export const m_flRadiusScale = 0x1E0;
                export const m_nVoxelGridResolution = 0x1E8;
            }
            export namespace C_OP_ModelCull {
                export const m_bBoundBox = 0x1E4;
                export const m_bUseBones = 0x1E6;
                export const m_bCullOutside = 0x1E5;
                export const m_HitboxSetName = 0x1E7;
                export const m_nControlPointNumber = 0x1E0;
            }
            export namespace C_OP_PlaneCull {
                export const m_bLocalSpace = 0x8C0;
                export const m_flPlaneOffset = 0x8C4;
                export const m_vecPlaneDirection = 0x1E8;
                export const m_nPlaneControlPoint = 0x1E0;
            }
            export namespace C_OP_RtEnvCull {
                export const m_nRTEnvCP = 0x27C;
                export const m_RtEnvName = 0x1FA;
                export const m_nComponent = 0x280;
                export const m_vecTestDir = 0x1E0;
                export const m_bCullOnMiss = 0x1F8;
                export const m_vecTestNormal = 0x1EC;
                export const m_bStickInsteadOfCull = 0x1F9;
            }
            export namespace C_OP_WindForce {
                export const m_vForce = 0x1F0;
            }
            export namespace TextureGroup_t {
                export const m_Gradient = 0x10;
                export const m_bEnabled = 0x0;
                export const m_hTexture = 0x8;
                export const m_nTextureType = 0x28;
                export const m_flTextureBlend = 0x38;
                export const m_TextureControls = 0x1B0;
                export const m_nTextureChannels = 0x2C;
                export const m_nTextureBlendMode = 0x30;
                export const m_bReplaceTextureWithGradient = 0x1;
            }
            export namespace CPathParameters {
                export const m_flBulge = 0x10;
                export const m_flMidPoint = 0x14;
                export const m_vEndOffset = 0x30;
                export const m_nBulgeControl = 0xC;
                export const m_vMidPointOffset = 0x24;
                export const m_vStartPointOffset = 0x18;
                export const m_nEndControlPointNumber = 0x8;
                export const m_nMidControlPointNumber = 0x4;
                export const m_nStartControlPointNumber = 0x0;
            }
            export namespace CPulseCell_Base {
                export const m_nEditorNodeID = 0x8;
            }
            export namespace CPulse_CallInfo {
                export const m_PortName = 0x0;
                export const m_nSrcChunk = 0x4C;
                export const m_RegisterMap = 0x18;
                export const m_CallMethodID = 0x48;
                export const m_nEditorNodeID = 0x10;
                export const m_nBreakDestChunk = 0x54;
                export const m_nSrcInstruction = 0x50;
                export const m_nBreakDestInstruction = 0x58;
            }
            export namespace CSpinUpdateBase {

            }
            export namespace C_INIT_AgeNoise {
                export const m_bAbsVal = 0x1E8;
                export const m_flAgeMax = 0x1F4;
                export const m_flAgeMin = 0x1F0;
                export const m_flOffset = 0x1EC;
                export const m_bAbsValInv = 0x1E9;
                export const m_flNoiseScale = 0x1F8;
                export const m_vecOffsetLoc = 0x200;
                export const m_flNoiseScaleLoc = 0x1FC;
            }
            export namespace C_INIT_RingWave {
                export const m_flYaw = 0xC98;
                export const m_flRoll = 0x9A8;
                export const m_flPitch = 0xB20;
                export const m_flThickness = 0x540;
                export const m_TransformInput = 0x1E8;
                export const m_bXYVelocityOnly = 0xE11;
                export const m_flInitialRadius = 0x3C8;
                export const m_bEvenDistribution = 0xE10;
                export const m_flInitialSpeedMax = 0x830;
                export const m_flInitialSpeedMin = 0x6B8;
                export const m_flParticlesPerOrbit = 0x250;
            }
            export namespace C_OP_AlphaDecay {
                export const m_flMinAlpha = 0x1E0;
            }
            export namespace C_OP_DampenToCP {
                export const m_flRange = 0x1E4;
                export const m_flScale = 0x1E8;
                export const m_nControlPointNumber = 0x1E0;
            }
            export namespace C_OP_LerpScalar {
                export const m_flOutput = 0x1E8;
                export const m_flEndTime = 0x364;
                export const m_flStartTime = 0x360;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_LerpVector {
                export const m_flEndTime = 0x1F4;
                export const m_vecOutput = 0x1E4;
                export const m_nSetMethod = 0x1F8;
                export const m_flStartTime = 0x1F0;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_LockPoints {
                export const m_nMaxCol = 0x1E4;
                export const m_nMaxRow = 0x1EC;
                export const m_nMinCol = 0x1E0;
                export const m_nMinRow = 0x1E8;
                export const m_flBlendValue = 0x1F4;
                export const m_nControlPoint = 0x1F0;
            }
            export namespace C_OP_LockToBone {
                export const m_bRigid = 0x338;
                export const m_bUseBones = 0x339;
                export const m_flRotLerp = 0xA28;
                export const m_modelInput = 0x1E0;
                export const m_vecRotation = 0x350;
                export const m_nFieldOutput = 0x33C;
                export const m_HitboxSetName = 0x2B8;
                export const m_flPrevPosScale = 0x2B4;
                export const m_transformInput = 0x240;
                export const m_flJumpThreshold = 0x2B0;
                export const m_nFieldOutputPrev = 0x340;
                export const m_nRotationSetType = 0x344;
                export const m_flLifeTimeFadeEnd = 0x2AC;
                export const m_bRigidRotationLock = 0x348;
                export const m_flLifeTimeFadeStart = 0x2A8;
            }
            export namespace C_OP_NormalLock {
                export const m_nControlPointNumber = 0x1E0;
            }
            export namespace C_OP_RemapSpeed {
                export const m_flInputMax = 0x1E8;
                export const m_flInputMin = 0x1E4;
                export const m_nSetMethod = 0x1F4;
                export const m_flOutputMax = 0x1F0;
                export const m_flOutputMin = 0x1EC;
                export const m_bIgnoreDelta = 0x1F8;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_RenderText {
                export const m_DefaultText = 0x238;
                export const m_OutlineColor = 0x230;
            }
            export namespace C_OP_SpinUpdate {

            }
            export namespace CPulseExecCursor {

            }
            export namespace C_INIT_InitFloat {
                export const m_InputValue = 0x1E8;
                export const m_nSetMethod = 0x364;
                export const m_nOutputField = 0x360;
                export const m_InputStrength = 0x368;
            }
            export namespace C_INIT_ModelCull {
                export const m_bBoundBox = 0x1EC;
                export const m_bUseBones = 0x1EE;
                export const m_bCullOutside = 0x1ED;
                export const m_HitboxSetName = 0x1EF;
                export const m_nControlPointNumber = 0x1E8;
            }
            export namespace C_INIT_PlaneCull {
                export const m_flDistance = 0x1F0;
                export const m_bCullInside = 0x368;
                export const m_nControlPoint = 0x1E8;
            }
            export namespace C_INIT_PointList {
                export const m_pointList = 0x1F0;
                export const m_bClosedLoop = 0x209;
                export const m_nFieldOutput = 0x1E8;
                export const m_bPlaceAlongPath = 0x208;
                export const m_nNumPointsAlongPath = 0x20C;
            }
            export namespace C_INIT_RandomYaw {

            }
            export namespace C_INIT_RtEnvCull {
                export const m_nRTEnvCP = 0x284;
                export const m_RtEnvName = 0x203;
                export const m_nComponent = 0x288;
                export const m_vecTestDir = 0x1E8;
                export const m_bCullOnMiss = 0x201;
                export const m_bLifeAdjust = 0x202;
                export const m_bUseVelocity = 0x200;
                export const m_vecTestNormal = 0x1F4;
            }
            export namespace C_OP_ChladniWave {
                export const m_b3D = 0x1580;
                export const m_flInputMax = 0x360;
                export const m_flInputMin = 0x1E8;
                export const m_nSetMethod = 0x1578;
                export const m_flOutputMax = 0x650;
                export const m_flOutputMin = 0x4D8;
                export const m_nFieldOutput = 0x1E0;
                export const m_vecHarmonics = 0xEA0;
                export const m_vecWaveLength = 0x7C8;
                export const m_nLocalSpaceControlPoint = 0x157C;
            }
            export namespace C_OP_ClampScalar {
                export const m_flOutputMax = 0x360;
                export const m_flOutputMin = 0x1E8;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_ClampVector {
                export const m_nFieldOutput = 0x1E0;
                export const m_vecOutputMax = 0x8C0;
                export const m_vecOutputMin = 0x1E8;
            }
            export namespace C_OP_CycleScalar {
                export const m_nCPScale = 0x1F4;
                export const m_flEndValue = 0x1E8;
                export const m_nDestField = 0x1E0;
                export const m_nSetMethod = 0x200;
                export const m_flCycleTime = 0x1EC;
                export const m_nCPFieldMax = 0x1FC;
                export const m_nCPFieldMin = 0x1F8;
                export const m_flStartValue = 0x1E4;
                export const m_bDoNotRepeatCycle = 0x1F0;
                export const m_bSynchronizeParticles = 0x1F1;
            }
            export namespace C_OP_EndCapDecay {

            }
            export namespace C_OP_FadeAndKill {
                export const m_flEndAlpha = 0x1F4;
                export const m_flStartAlpha = 0x1F0;
                export const m_flEndFadeInTime = 0x1E4;
                export const m_flEndFadeOutTime = 0x1EC;
                export const m_flStartFadeInTime = 0x1E0;
                export const m_flStartFadeOutTime = 0x1E8;
                export const m_bForcePreserveParticleOrder = 0x1F8;
            }
            export namespace C_OP_GlobalLight {
                export const m_flScale = 0x1E0;
                export const m_bClampLowerRange = 0x1E4;
                export const m_bClampUpperRange = 0x1E5;
            }
            export namespace C_OP_MaxVelocity {
                export const m_flMaxVelocity = 0x1E0;
                export const m_flMinVelocity = 0x358;
            }
            export namespace C_OP_RadiusDecay {
                export const m_flMinRadius = 0x1E0;
            }
            export namespace C_OP_RandomForce {
                export const m_MaxForce = 0x1FC;
                export const m_MinForce = 0x1F0;
            }
            export namespace C_OP_RemapCPtoCP {
                export const m_flInputMax = 0x1FC;
                export const m_flInputMin = 0x1F8;
                export const m_bDerivative = 0x208;
                export const m_flOutputMax = 0x204;
                export const m_flOutputMin = 0x200;
                export const m_nInputField = 0x1F0;
                export const m_flInterpRate = 0x20C;
                export const m_nOutputField = 0x1F4;
                export const m_nInputControlPoint = 0x1E8;
                export const m_nOutputControlPoint = 0x1EC;
            }
            export namespace C_OP_RemapScalar {
                export const m_bOldCode = 0x1F8;
                export const m_flInputMax = 0x1EC;
                export const m_flInputMin = 0x1E8;
                export const m_flOutputMax = 0x1F4;
                export const m_flOutputMin = 0x1F0;
                export const m_nFieldInput = 0x1E0;
                export const m_nFieldOutput = 0x1E4;
            }
            export namespace C_OP_RenderBlobs {
                export const m_nScaleCP = 0x6A0;
                export const m_cubeWidth = 0x230;
                export const m_hMaterial = 0x6D8;
                export const m_MaterialVars = 0x6A8;
                export const m_cutoffRadius = 0x3A8;
                export const m_renderRadius = 0x520;
                export const m_nIndexCountKb = 0x69C;
                export const m_nVertexCountKb = 0x698;
            }
            export namespace C_OP_RenderRopes {
                export const m_bClampV = 0x34EC;
                export const m_flMaxSize = 0x2EE0;
                export const m_flMinSize = 0x2EDC;
                export const m_nScaleCP1 = 0x34F0;
                export const m_nScaleCP2 = 0x34F4;
                export const m_bClosedLoop = 0x3511;
                export const m_flTessScale = 0x307C;
                export const m_nSplitField = 0x3514;
                export const m_flEndFadeDot = 0x2EF0;
                export const m_bDrawAsOpaque = 0x3524;
                export const m_bReverseOrder = 0x3510;
                export const m_flEndFadeSize = 0x2EE8;
                export const m_flRadiusTaper = 0x3070;
                export const m_flStartFadeDot = 0x2EEC;
                export const m_flStartFadeSize = 0x2EE4;
                export const m_nMaxTesselation = 0x3078;
                export const m_nMinTesselation = 0x3074;
                export const m_bGenerateNormals = 0x3525;
                export const m_bSortBySegmentID = 0x3518;
                export const m_flTextureVOffset = 0x3370;
                export const m_nOrientationType = 0x351C;
                export const m_flSubPixelAAScale = 0x2EF8;
                export const m_nTextureVParamsCP = 0x34E8;
                export const m_flTextureVWorldSize = 0x3080;
                export const m_flTextureVScrollRate = 0x31F8;
                export const m_bEnableFadingAndClamping = 0x2ED8;
                export const m_nVectorFieldForOrientation = 0x3520;
                export const m_bUseScalarForTextureCoordinate = 0x3505;
                export const m_nScalarFieldForTextureCoordinate = 0x3508;
                export const m_flScalarAttributeTextureCoordScale = 0x350C;
                export const m_flScaleVSizeByControlPointDistance = 0x34F8;
                export const m_flScaleVOffsetByControlPointDistance = 0x3500;
                export const m_flScaleVScrollByControlPointDistance = 0x34FC;
            }
            export namespace C_OP_RenderSound {
                export const m_nChannel = 0x250;
                export const m_nPitchField = 0x248;
                export const m_flPitchScale = 0x238;
                export const m_nCPReference = 0x254;
                export const m_nSndLvlField = 0x240;
                export const m_nVolumeField = 0x24C;
                export const m_pszSoundName = 0x258;
                export const m_flSndLvlScale = 0x234;
                export const m_flVolumeScale = 0x23C;
                export const m_nDurationField = 0x244;
                export const m_flDurationScale = 0x230;
                export const m_bSuppressStopSoundEvent = 0x358;
            }
            export namespace C_OP_SetVariable {
                export const m_vecInput = 0x2B8;
                export const m_floatInput = 0x990;
                export const m_positionOffset = 0x2A0;
                export const m_rotationOffset = 0x2AC;
                export const m_transformInput = 0x238;
                export const m_variableReference = 0x1E8;
            }
            export namespace C_OP_VectorNoise {
                export const m_bOffset = 0x201;
                export const m_bAdditive = 0x200;
                export const m_nFieldOutput = 0x1E0;
                export const m_vecOutputMax = 0x1F0;
                export const m_vecOutputMin = 0x1E4;
                export const m_fl4NoiseScale = 0x1FC;
                export const m_flNoiseAnimationTimeScale = 0x204;
            }
            export namespace ModelReference_t {
                export const m_model = 0x0;
                export const m_flRelativeProbabilityOfSpawn = 0x8;
            }
            export namespace CParticleFunction {
                export const m_Notes = 0x1C0;
                export const m_nToolsState = 0x184;
                export const m_flOpStrength = 0x8;
                export const m_nOpEndCapState = 0x180;
                export const m_bDisableOperator = 0x1BA;
                export const m_flOpTimeScaleMax = 0x1B4;
                export const m_flOpTimeScaleMin = 0x1B0;
                export const m_nOpTimeScaleSeed = 0x1AC;
                export const m_flOpEndFadeInTime = 0x18C;
                export const m_flOpTimeOffsetMax = 0x1A4;
                export const m_flOpTimeOffsetMin = 0x1A0;
                export const m_nOpTimeOffsetSeed = 0x1A8;
                export const m_flOpEndFadeOutTime = 0x194;
                export const m_flOpStartFadeInTime = 0x188;
                export const m_bNormalizeToStopTime = 0x19C;
                export const m_flOpStartFadeOutTime = 0x190;
                export const m_flOpFadeOscillatePeriod = 0x198;
            }
            export namespace C_INIT_SkyVisCull {
                export const m_nTraceSet = 0x8C0;
                export const m_bCullOnSky = 0x8C4;
                export const m_vecTestDir = 0x1E8;
            }
            export namespace C_OP_DensityForce {
                export const m_flForceScale = 0x1F4;
                export const m_flRadiusScale = 0x1F0;
                export const m_flTargetDensity = 0x1F8;
            }
            export namespace C_OP_DistanceCull {
                export const m_flDistance = 0x1F0;
                export const m_nAttribute = 0x36C;
                export const m_bCullInside = 0x368;
                export const m_nControlPoint = 0x1E0;
                export const m_vecPointOffset = 0x1E4;
            }
            export namespace C_OP_FadeInSimple {
                export const m_flFadeInTime = 0x1E0;
                export const m_nFieldOutput = 0x1E4;
            }
            export namespace C_OP_HSVShiftToCP {
                export const m_nColorCP = 0x1E8;
                export const m_nOutputCP = 0x1F0;
                export const m_DefaultHSVColor = 0x1F4;
                export const m_nColorGemEnableCP = 0x1EC;
            }
            export namespace C_OP_MoveToHitbox {
                export const m_bUseBones = 0x338;
                export const m_nLerpType = 0x33C;
                export const m_modelInput = 0x1E0;
                export const m_HitboxSetName = 0x2B8;
                export const m_flPrevPosScale = 0x2B4;
                export const m_transformInput = 0x240;
                export const m_flInterpolation = 0x340;
                export const m_flLifeTimeLerpEnd = 0x2B0;
                export const m_flLifeTimeLerpStart = 0x2AC;
            }
            export namespace C_OP_NoiseEmitter {
                export const m_bAbsVal = 0x200;
                export const m_flOffset = 0x204;
                export const m_bAbsValInv = 0x201;
                export const m_flOutputMax = 0x20C;
                export const m_flOutputMin = 0x208;
                export const m_flStartTime = 0x1EC;
                export const m_flNoiseScale = 0x210;
                export const m_vecOffsetLoc = 0x218;
                export const m_flEmissionScale = 0x1F0;
                export const m_flWorldTimeScale = 0x224;
                export const m_nWorldNoisePoint = 0x1FC;
                export const m_flWorldNoiseScale = 0x214;
                export const m_flEmissionDuration = 0x1E8;
                export const m_nScaleControlPoint = 0x1F4;
                export const m_nScaleControlPointField = 0x1F8;
            }
            export namespace C_OP_PositionLock {
                export const m_flRange = 0x260;
                export const m_bLockRot = 0x3E8;
                export const m_vecScale = 0x3F0;
                export const m_flRangeBias = 0x268;
                export const m_nFieldOutput = 0xAC8;
                export const m_flEndTime_exp = 0x25C;
                export const m_flEndTime_max = 0x258;
                export const m_flEndTime_min = 0x254;
                export const m_TransformInput = 0x1E0;
                export const m_flPrevPosScale = 0x3E4;
                export const m_flJumpThreshold = 0x3E0;
                export const m_flStartTime_exp = 0x250;
                export const m_flStartTime_max = 0x24C;
                export const m_flStartTime_min = 0x248;
                export const m_nFieldOutputPrev = 0xACC;
            }
            export namespace C_OP_RenderCables {
                export const m_hMaterial = 0xC00;
                export const m_nRoundness = 0x14F8;
                export const m_flTessScale = 0x14EC;
                export const m_flAlphaScale = 0x3A8;
                export const m_flRadiusScale = 0x230;
                export const m_vecColorScale = 0x520;
                export const m_bDrawCableCaps = 0x14E0;
                export const m_flCapRoundness = 0x14E4;
                export const m_MaterialVecVars = 0x1588;
                export const m_nColorBlendType = 0xBF8;
                export const m_nMaxTesselation = 0x14F4;
                export const m_nMinTesselation = 0x14F0;
                export const m_LightingTransform = 0x1500;
                export const m_MaterialFloatVars = 0x1568;
                export const m_flCapOffsetAmount = 0x14E8;
                export const m_flColorMapOffsetU = 0x1078;
                export const m_flColorMapOffsetV = 0xF00;
                export const m_flNormalMapOffsetU = 0x1368;
                export const m_flNormalMapOffsetV = 0x11F0;
                export const m_nForceRoundnessFixed = 0x14FC;
                export const m_nTextureRepetitionMode = 0xC08;
                export const m_flTextureRepeatsPerSegment = 0xC10;
                export const m_bOnlyRenderInEffectsBloomPass = 0x14FD;
                export const m_flTextureRepeatsCircumference = 0xD88;
            }
            export namespace C_OP_RenderLights {
                export const m_flMaxSize = 0x248;
                export const m_flMinSize = 0x244;
                export const m_bAnimateInFPS = 0x240;
                export const m_flEndFadeSize = 0x250;
                export const m_nAnimationType = 0x23C;
                export const m_flAnimationRate = 0x238;
                export const m_flStartFadeSize = 0x24C;
            }
            export namespace C_OP_RenderModels {
                export const m_nLOD = 0x1FC0;
                export const m_nSkin = 0x1AE0;
                export const m_bOrientZ = 0x259;
                export const m_ModelList = 0x238;
                export const m_bAnimated = 0x16F8;
                export const m_modelInput = 0x1F60;
                export const m_bLocalScale = 0x16F0;
                export const m_flRollScale = 0x24C8;
                export const m_ActivityName = 0x1888;
                export const m_EconSlotName = 0x1FC4;
                export const m_MaterialVars = 0x1C58;
                export const m_SequenceName = 0x1988;
                export const m_flAlphaScale = 0x2350;
                export const m_nAlpha2Field = 0x2640;
                export const m_bCenterOffset = 0x25A;
                export const m_bIgnoreNormal = 0x258;
                export const m_bIgnoreRadius = 0x1010;
                export const m_bSuppressTint = 0x20C5;
                export const m_flRadiusScale = 0x21D8;
                export const m_nModelScaleCP = 0x1014;
                export const m_strLightStyle = 0x2D28;
                export const m_vecColorScale = 0x2648;
                export const m_bAcceptsDecals = 0x20CE;
                export const m_bOriginalModel = 0x20C4;
                export const m_flRenderFilter = 0x1C70;
                export const m_nSizeCullBloat = 0x16F4;
                export const m_nSubModelField = 0x254;
                export const m_vecLocalOffset = 0x260;
                export const m_ClothEffectName = 0x1A8A;
                export const m_bDisableShadows = 0x20CC;
                export const m_flAnimationRate = 0x1700;
                export const m_nAnimationField = 0x1880;
                export const m_nBodyGroupField = 0x250;
                export const m_nColorBlendType = 0x2D20;
                export const m_bManualAnimFrame = 0x187B;
                export const m_bResetAnimOnStop = 0x187A;
                export const m_flLightStyleTime = 0x2D30;
                export const m_vecLocalRotation = 0x938;
                export const m_hOverrideMaterial = 0x1AD0;
                export const m_nManualFrameField = 0x1884;
                export const m_szRenderAttribute = 0x20D2;
                export const m_vecComponentScale = 0x1018;
                export const m_nSubModelFieldType = 0x20C8;
                export const m_bScaleAnimationRate = 0x1878;
                export const m_bDisableDepthPrepass = 0x20CD;
                export const m_nAnimationScaleField = 0x187C;
                export const m_bEnableClothSimulation = 0x1A88;
                export const m_bForceLoopingAnimation = 0x1879;
                export const m_flManualModelSelection = 0x1DE8;
                export const m_bDoNotDrawInParticlePass = 0x20D0;
                export const m_bAllowApproximateTransforms = 0x20D1;
                export const m_bDisableClothGroundCollision = 0x1A89;
                export const m_bUseMixedResolutionRendering = 0x232;
                export const m_bOnlyRenderInEffectsBloomPass = 0x230;
                export const m_bOnlyRenderInEffectsWaterPass = 0x231;
                export const m_bOverrideTranslucentMaterials = 0x1AD8;
                export const m_bOnlyRenderInEffecsGameOverlay = 0x233;
                export const m_bForceDrawInterlevedWithSiblings = 0x20CF;
            }
            export namespace C_OP_RenderPoints {
                export const m_hMaterial = 0x230;
            }
            export namespace C_OP_RenderTrails {
                export const m_bIgnoreDT = 0x3370;
                export const m_flMaxLength = 0x3368;
                export const m_flMinLength = 0x336C;
                export const m_flEndFadeDot = 0x3360;
                export const m_flLengthScale = 0x3378;
                export const m_flRadiusTaper = 0x3D48;
                export const m_flForwardShift = 0x4718;
                export const m_flStartFadeDot = 0x335C;
                export const m_nPrevPntSource = 0x3364;
                export const m_nVertCropField = 0x4714;
                export const m_nHorizCropField = 0x4710;
                export const m_flHeadAlphaScale = 0x3BD0;
                export const m_flTailAlphaScale = 0x4598;
                export const m_flRadiusHeadTaper = 0x3380;
                export const m_vecHeadColorScale = 0x34F8;
                export const m_vecTailColorScale = 0x3EC0;
                export const m_flLengthFadeInTime = 0x337C;
                export const m_bFlipUVBasedOnPitchYaw = 0x471C;
                export const m_bEnableFadingAndClamping = 0x3358;
                export const m_flConstrainRadiusToLengthRatio = 0x3374;
            }
            export namespace C_OP_RotateVector {
                export const m_flScale = 0x208;
                export const m_bNormalize = 0x204;
                export const m_flRotRateMax = 0x200;
                export const m_flRotRateMin = 0x1FC;
                export const m_nFieldOutput = 0x1E0;
                export const m_vecRotAxisMax = 0x1F0;
                export const m_vecRotAxisMin = 0x1E4;
            }
            export namespace C_OP_SetUserEvent {
                export const m_flInput = 0x1E0;
                export const m_flRisingEdge = 0x358;
                export const m_flFallingEdge = 0x4D8;
                export const m_nRisingEventType = 0x4D0;
                export const m_nFallingEventType = 0x650;
            }
            export namespace C_OP_TeleportBeam {
                export const m_flAlpha = 0x210;
                export const m_nCPMisc = 0x1E8;
                export const m_nCPColor = 0x1EC;
                export const m_vGravity = 0x1F8;
                export const m_flArcSpeed = 0x20C;
                export const m_nCPPosition = 0x1E0;
                export const m_nCPVelocity = 0x1E4;
                export const m_flSegmentBreak = 0x208;
                export const m_nCPExtraArcData = 0x1F4;
                export const m_nCPInvalidColor = 0x1F0;
                export const m_flArcMaxDuration = 0x204;
            }
            export namespace PointDefinition_t {
                export const m_vOffset = 0x8;
                export const m_bLocalCoords = 0x4;
                export const m_nControlPoint = 0x0;
            }
            export namespace TextureControls_t {
                export const m_bClampUVs = 0xA49;
                export const m_flZoomScale = 0x758;
                export const m_flDistortion = 0x8D0;
                export const m_nPerParticleZoom = 0xA60;
                export const m_bRandomizeOffsets = 0xA48;
                export const m_nPerParticleBlend = 0xA4C;
                export const m_nPerParticleScale = 0xA50;
                export const m_nPerParticleOffsetU = 0xA54;
                export const m_nPerParticleOffsetV = 0xA58;
                export const m_flFinalTextureScaleU = 0x0;
                export const m_flFinalTextureScaleV = 0x178;
                export const m_nPerParticleRotation = 0xA5C;
                export const m_flFinalTextureOffsetU = 0x2F0;
                export const m_flFinalTextureOffsetV = 0x468;
                export const m_nPerParticleDistortion = 0xA64;
                export const m_flFinalTextureUVRotation = 0x5E0;
            }
            export namespace CBaseTrailRenderer {
                export const m_bClampV = 0x3350;
                export const m_flMaxSize = 0x2EE4;
                export const m_flMinSize = 0x2EE0;
                export const m_flEndFadeSize = 0x3060;
                export const m_flStartFadeSize = 0x2EE8;
                export const m_nOrientationType = 0x2ED8;
                export const m_flSubPixelAAScale = 0x31D8;
                export const m_nOrientationControlPoint = 0x2EDC;
            }
            export namespace CPulseCell_Unknown {
                export const m_UnknownKeys = 0x48;
            }
            export namespace CPulse_ResumePoint {

            }
            export namespace C_INIT_GlobalScale {
                export const m_flScale = 0x1E8;
                export const m_bScaleRadius = 0x1F4;
                export const m_bScalePosition = 0x1F5;
                export const m_bScaleVelocity = 0x1F6;
                export const m_nControlPointNumber = 0x1F0;
                export const m_nScaleControlPointNumber = 0x1EC;
            }
            export namespace C_INIT_RandomAlpha {
                export const m_nAlphaMax = 0x1F0;
                export const m_nAlphaMin = 0x1EC;
                export const m_nFieldOutput = 0x1E8;
                export const m_flAlphaRandExponent = 0x1FC;
            }
            export namespace C_INIT_RandomColor {
                export const m_TintMax = 0x210;
                export const m_TintMin = 0x20C;
                export const m_nTintCP = 0x21C;
                export const m_ColorMax = 0x208;
                export const m_ColorMin = 0x204;
                export const m_flTintPerc = 0x214;
                export const m_nFieldOutput = 0x220;
                export const m_nTintBlendMode = 0x224;
                export const m_flUpdateThreshold = 0x218;
                export const m_flLightAmplification = 0x228;
            }
            export namespace C_OP_BasicMovement {
                export const m_fDrag = 0x8B8;
                export const m_Gravity = 0x1E0;
                export const m_bUseNewCode = 0xEA4;
                export const m_massControls = 0xA30;
                export const m_nMaxConstraintPasses = 0xEA0;
            }
            export namespace C_OP_BoxConstraint {
                export const m_nCP = 0xF90;
                export const m_vecMax = 0x8B8;
                export const m_vecMin = 0x1E0;
                export const m_bLocalSpace = 0xF94;
                export const m_bAccountForRadius = 0xF95;
            }
            export namespace C_OP_ClientPhysics {
                export const m_bDeleteSim = 0x53A;
                export const m_bStartAsleep = 0x238;
                export const m_nForcedSimId = 0x540;
                export const m_nControlPoint = 0x53C;
                export const m_bKillParticles = 0x539;
                export const m_strPhysicsType = 0x230;
                export const m_nColorBlendType = 0x544;
                export const m_nMaxParticleCount = 0x534;
                export const m_flPlayerWakeRadius = 0x240;
                export const m_flVehicleWakeRadius = 0x3B8;
                export const m_nForcedStatusEffects = 0x548;
                export const m_nNoCollisionAttribute = 0x54C;
                export const m_nZeroGravityAttribute = 0x550;
                export const m_bRespectExclusionVolumes = 0x538;
                export const m_bUseHighQualitySimulation = 0x530;
            }
            export namespace C_OP_FadeOutSimple {
                export const m_nFieldOutput = 0x1E4;
                export const m_flFadeOutTime = 0x1E0;
            }
            export namespace C_OP_QuantizeFloat {
                export const m_InputValue = 0x1E0;
                export const m_nOutputField = 0x358;
            }
            export namespace C_OP_RenderSprites {
                export const m_bOutline = 0x37CC;
                export const m_flMaxSize = 0x31D8;
                export const m_flMinSize = 0x3060;
                export const m_bSoftEdges = 0x37C1;
                export const m_OutlineColor = 0x37D0;
                export const m_flEndFadeDot = 0x37BC;
                export const m_flEndFadeSize = 0x3640;
                export const m_flOutlineEnd0 = 0x37E0;
                export const m_flOutlineEnd1 = 0x37E4;
                export const m_nLightingMode = 0x37E8;
                export const m_nOutlineAlpha = 0x37D4;
                export const m_bDistanceAlpha = 0x37C0;
                export const m_flStartFadeDot = 0x37B8;
                export const m_flOutlineStart0 = 0x37D8;
                export const m_flOutlineStart1 = 0x37DC;
                export const m_flShadowDensity = 0x41BC;
                export const m_flStartFadeSize = 0x34C8;
                export const m_bParticleShadows = 0x41B8;
                export const m_nOrientationType = 0x3054;
                export const m_flEdgeSoftnessEnd = 0x37C8;
                export const m_flSubPixelAAScale = 0x3350;
                export const m_nSequenceOverride = 0x2ED8;
                export const m_flEdgeSoftnessStart = 0x37C4;
                export const m_vecLightingOverride = 0x37F0;
                export const m_flLightingTessellation = 0x3EC8;
                export const m_bUseYawWithNormalAligned = 0x305C;
                export const m_flLightingDirectionality = 0x4040;
                export const m_nOrientationControlPoint = 0x3058;
                export const m_bSequenceNumbersAreRawSequenceIndices = 0x3050;
            }
            export namespace C_OP_SetCPtoVector {
                export const m_nCPInput = 0x1E0;
                export const m_nFieldOutput = 0x1E4;
            }
            export namespace C_OP_VelocityDecay {
                export const m_flMinVelocity = 0x1E0;
            }
            export namespace MaterialVariable_t {
                export const m_flScale = 0xC;
                export const m_strVariable = 0x0;
                export const m_nVariableField = 0x8;
            }
            export namespace CPulseCell_BaseFlow {

            }
            export namespace CPulseCell_BaseLerp {
                export const m_WakeResume = 0xD8;
            }
            export namespace CPulseCell_Timeline {
                export const m_OnFinished = 0xF8;
                export const m_TimelineEvents = 0xD8;
                export const m_bWaitForChildOutflows = 0xF0;
            }
            export namespace C_INIT_CreateOnGrid {
                export const m_bCenter = 0xABD;
                export const m_bHollow = 0xABE;
                export const m_nXCount = 0x1E8;
                export const m_nYCount = 0x360;
                export const m_nZCount = 0x4D8;
                export const m_nXSpacing = 0x650;
                export const m_nYSpacing = 0x7C8;
                export const m_nZSpacing = 0x940;
                export const m_bLocalSpace = 0xABC;
                export const m_nControlPointNumber = 0xAB8;
            }
            export namespace C_INIT_DistanceCull {
                export const m_flDistance = 0x1F0;
                export const m_bCullInside = 0x368;
                export const m_nControlPoint = 0x1E8;
            }
            export namespace C_INIT_NormalOffset {
                export const m_OffsetMax = 0x1F4;
                export const m_OffsetMin = 0x1E8;
                export const m_bNormalize = 0x205;
                export const m_bLocalCoords = 0x204;
                export const m_nControlPointNumber = 0x200;
            }
            export namespace C_INIT_PositionWarp {
                export const m_bUseCount = 0xFB1;
                export const m_flWarpTime = 0xFA4;
                export const m_vecWarpMax = 0x8C0;
                export const m_vecWarpMin = 0x1E8;
                export const m_bInvertWarp = 0xFB0;
                export const m_flPrevPosScale = 0xFAC;
                export const m_flWarpStartTime = 0xFA8;
                export const m_nRadiusComponent = 0xFA0;
                export const m_nControlPointNumber = 0xF9C;
                export const m_nScaleControlPointNumber = 0xF98;
            }
            export namespace C_INIT_RandomRadius {
                export const m_flRadiusMax = 0x1EC;
                export const m_flRadiusMin = 0x1E8;
                export const m_flRadiusRandExponent = 0x1F0;
            }
            export namespace C_INIT_RandomScalar {
                export const m_flMax = 0x1EC;
                export const m_flMin = 0x1E8;
                export const m_flExponent = 0x1F0;
                export const m_nFieldOutput = 0x1F4;
            }
            export namespace C_INIT_RandomVector {
                export const m_vecMax = 0x1F4;
                export const m_vecMin = 0x1E8;
                export const m_nFieldOutput = 0x200;
                export const m_randomnessParameters = 0x204;
            }
            export namespace C_INIT_StatusEffect {
                export const m_nDetail2Combo = 0x1E8;
                export const m_rimLightColor = 0x21C;
                export const m_specularColor = 0x208;
                export const m_flAmbientScale = 0x204;
                export const m_flDetail2Scale = 0x1F0;
                export const m_flRimLightScale = 0x220;
                export const m_flSpecularScale = 0x20C;
                export const m_flDetail2Rotation = 0x1EC;
                export const m_flEnvMapIntensity = 0x200;
                export const m_flSpecularExponent = 0x210;
                export const m_flColorWarpIntensity = 0x1F8;
                export const m_flDetail2BlendFactor = 0x1F4;
                export const m_flSpecularBlendToFull = 0x218;
                export const m_flMetalnessBlendToFull = 0x228;
                export const m_flSelfIllumBlendToFull = 0x22C;
                export const m_flDiffuseWarpBlendToFull = 0x1FC;
                export const m_flSpecularExponentBlendToFull = 0x214;
                export const m_flReflectionsTintByBaseBlendToNone = 0x224;
            }
            export namespace C_OP_ColorAdjustHSL {
                export const m_flHueAdjust = 0x1E0;
                export const m_flLightnessAdjust = 0x4D0;
                export const m_flSaturationAdjust = 0x358;
            }
            export namespace C_OP_CurlNoiseForce {
                export const m_vecOffset = 0xFA8;
                export const m_nNoiseType = 0x1F0;
                export const m_flWorleySeed = 0x1D58;
                export const m_vecNoiseFreq = 0x1F8;
                export const m_vecNoiseScale = 0x8D0;
                export const m_vecOffsetRate = 0x1680;
                export const m_flWorleyJitter = 0x1ED0;
            }
            export namespace C_OP_DecayOffscreen {
                export const m_flOffscreenTime = 0x1E0;
            }
            export namespace C_OP_ParentVortices {
                export const m_flForceScale = 0x1F0;
                export const m_vecTwistAxis = 0x1F4;
                export const m_bFlipBasedOnYaw = 0x200;
            }
            export namespace C_OP_RemapSpeedtoCP {
                export const m_nField = 0x1F0;
                export const m_bUseDeltaV = 0x204;
                export const m_flInputMax = 0x1F8;
                export const m_flInputMin = 0x1F4;
                export const m_flOutputMax = 0x200;
                export const m_flOutputMin = 0x1FC;
                export const m_nInControlPointNumber = 0x1E8;
                export const m_nOutControlPointNumber = 0x1EC;
            }
            export namespace C_OP_RenderAsModels {
                export const m_ModelList = 0x230;
                export const m_flModelScale = 0x24C;
                export const m_nSizeCullBloat = 0x260;
                export const m_bFitToModelSize = 0x250;
                export const m_bNonUniformScaling = 0x251;
                export const m_nXAxisScalingAttribute = 0x254;
                export const m_nYAxisScalingAttribute = 0x258;
                export const m_nZAxisScalingAttribute = 0x25C;
            }
            export namespace C_OP_SetGravityToCP {
                export const m_flScale = 0x1F0;
                export const m_nCPInput = 0x1E8;
                export const m_bSetZDown = 0x36A;
                export const m_nCPOutput = 0x1EC;
                export const m_bSetPosition = 0x368;
                export const m_bSetOrientation = 0x369;
            }
            export namespace IParticleCollection {

            }
            export namespace CBaseRendererSource2 {
                export const m_bRefract = 0x2268;
                export const m_nFogType = 0x1C74;
                export const m_bTintByFOW = 0x1DF0;
                export const m_flDepthBias = 0x2AE0;
                export const m_flFogAmount = 0x1C78;
                export const m_flRollScale = 0x520;
                export const m_nShaderType = 0xD7C;
                export const m_nSortMethod = 0x2C58;
                export const m_flAlphaScale = 0x3A8;
                export const m_nAlpha2Field = 0x698;
                export const m_bAnimateInFPS = 0x1098;
                export const m_bRefractSolid = 0x2269;
                export const m_flRadiusScale = 0x230;
                export const m_stencilTestID = 0x23F4;
                export const m_vecColorScale = 0x6A0;
                export const m_flBumpStrength = 0x1078;
                export const m_flDesaturation = 0x1980;
                export const m_flDiffuseClamp = 0x1680;
                export const m_nAnimationType = 0x1094;
                export const m_stencilWriteID = 0x2475;
                export const m_bRefract2Passes = 0x226A;
                export const m_flAddSelfAmount = 0x1808;
                export const m_flAnimationRate = 0x1090;
                export const m_flCenterXOffset = 0xD88;
                export const m_flCenterYOffset = 0xF00;
                export const m_flDiffuseAmount = 0x1508;
                export const m_flRefractAmount = 0x2270;
                export const m_nColorBlendType = 0xD78;
                export const m_nFeatheringMode = 0x24FC;
                export const m_bBlendFramesSeq0 = 0x2C5C;
                export const m_nOutputBlendMode = 0x17FC;
                export const m_nRefractBlurType = 0x23EC;
                export const m_vecTexturesInput = 0x1080;
                export const m_flSelfIllumAmount = 0x1390;
                export const m_strShaderOverride = 0xD80;
                export const m_bDisableZBuffering = 0x24F8;
                export const m_bReverseZBuffering = 0x24F7;
                export const m_bTintByGlobalLight = 0x1DF1;
                export const m_flFeatheringFilter = 0x27F0;
                export const m_flOverbrightFactor = 0x1AF8;
                export const m_nRefractBlurRadius = 0x23E8;
                export const m_bStencilTestExclude = 0x2474;
                export const m_flFeatheringMaxDist = 0x2678;
                export const m_flFeatheringMinDist = 0x2500;
                export const m_nAlphaReferenceType = 0x1DFC;
                export const m_flMotionVectorScaleU = 0x10A0;
                export const m_flMotionVectorScaleV = 0x1218;
                export const m_nCropTextureOverride = 0x107C;
                export const m_nHSVShiftControlPoint = 0x1C70;
                export const m_nLightingControlPoint = 0x17F8;
                export const m_bWriteStencilOnDepthFail = 0x24F6;
                export const m_bWriteStencilOnDepthPass = 0x24F5;
                export const m_flAlphaReferenceSoftness = 0x1E00;
                export const m_bGammaCorrectVertexColors = 0x1800;
                export const m_flFeatheringDepthMapFilter = 0x2968;
                export const m_nPerParticleAlphaRefWindow = 0x1DF8;
                export const m_nPerParticleAlphaReference = 0x1DF4;
                export const m_bSaturateColorPreAlphaBlend = 0x1801;
                export const m_bUseMixedResolutionRendering = 0x23F2;
                export const m_flSourceAlphaValueToMapToOne = 0x20F0;
                export const m_bOnlyRenderInEffectsBloomPass = 0x23F0;
                export const m_bOnlyRenderInEffectsWaterPass = 0x23F1;
                export const m_flSourceAlphaValueToMapToZero = 0x1F78;
                export const m_bMaxLuminanceBlendingSequence0 = 0x2C5D;
                export const m_bOnlyRenderInEffecsGameOverlay = 0x23F3;
            }
            export namespace CPulseCell_BaseState {

            }
            export namespace CPulseCell_BaseValue {

            }
            export namespace CPulse_InvokeBinding {
                export const m_FuncName = 0x30;
                export const m_nSrcChunk = 0x44;
                export const m_nCellIndex = 0x40;
                export const m_RegisterMap = 0x0;
                export const m_nSrcInstruction = 0x48;
            }
            export namespace C_INIT_CreateFromCPs {
                export const m_nMaxCP = 0x1F0;
                export const m_nMinCP = 0x1EC;
                export const m_nIncrement = 0x1E8;
                export const m_nDynamicCPCount = 0x1F8;
            }
            export namespace C_INIT_CreateOnModel {
                export const m_bUseMesh = 0x1272;
                export const m_bUseBones = 0x1271;
                export const m_modelInput = 0x1E8;
                export const m_flShellSize = 0x1278;
                export const m_bLocalCoords = 0x1270;
                export const m_HitboxSetName = 0x11F0;
                export const m_nForceInModel = 0x2B0;
                export const m_bScaleToVolume = 0x2B4;
                export const m_flBoneVelocity = 0xB10;
                export const m_nDesiredHitbox = 0x2B8;
                export const m_transformInput = 0x248;
                export const m_vecHitBoxScale = 0x438;
                export const m_vecDirectionBias = 0xB18;
                export const m_bEvenDistribution = 0x2B5;
                export const m_flMaxBoneVelocity = 0xB14;
                export const m_nHitboxValueFromControlPointIndex = 0x430;
            }
            export namespace C_INIT_CreationNoise {
                export const m_bAbsVal = 0x1EC;
                export const m_flOffset = 0x1F0;
                export const m_bAbsValInv = 0x1ED;
                export const m_flOutputMax = 0x1F8;
                export const m_flOutputMin = 0x1F4;
                export const m_flNoiseScale = 0x1FC;
                export const m_nFieldOutput = 0x1E8;
                export const m_vecOffsetLoc = 0x204;
                export const m_flNoiseScaleLoc = 0x200;
                export const m_flWorldTimeScale = 0x210;
            }
            export namespace C_INIT_QuantizeFloat {
                export const m_InputValue = 0x1E8;
                export const m_nOutputField = 0x360;
            }
            export namespace C_INIT_RandomYawFlip {
                export const m_flPercent = 0x1E8;
            }
            export namespace C_INIT_ScaleVelocity {
                export const m_vecScale = 0x1E8;
            }
            export namespace C_OP_CPVelocityForce {
                export const m_flScale = 0x1F8;
                export const m_nControlPointNumber = 0x1F0;
            }
            export namespace C_OP_CollideWithSelf {
                export const m_flRadiusScale = 0x1E0;
                export const m_flMinimumSpeed = 0x358;
            }
            export namespace C_OP_DecayClampCount {
                export const m_nCount = 0x1E0;
            }
            export namespace C_OP_GameLiquidSpill {
                export const m_flRadius = 0x520;
                export const m_flExpirationTime = 0x3A8;
                export const m_nAmountAttribute = 0x69C;
                export const m_bCheckExposedToSky = 0x698;
                export const m_flLiquidContentsField = 0x230;
            }
            export namespace C_OP_LagCompensation {
                export const m_nLatencyCP = 0x1E4;
                export const m_nLatencyCPField = 0x1E8;
                export const m_nDesiredVelocityCP = 0x1E0;
                export const m_nDesiredVelocityCPField = 0x1EC;
            }
            export namespace C_OP_LockToPointList {
                export const m_pointList = 0x1E8;
                export const m_bClosedLoop = 0x201;
                export const m_nFieldOutput = 0x1E0;
                export const m_bPlaceAlongPath = 0x200;
                export const m_nNumPointsAlongPath = 0x204;
            }
            export namespace C_OP_MaintainEmitter {
                export const m_flScale = 0x4F8;
                export const m_flStartTime = 0x360;
                export const m_flEmissionRate = 0x4E0;
                export const m_bFinalEmitOnStop = 0x4F1;
                export const m_strSnapshotSubset = 0x4E8;
                export const m_flEmissionDuration = 0x368;
                export const m_bEmitInstantaneously = 0x4F0;
                export const m_nParticlesToMaintain = 0x1E8;
                export const m_nSnapshotControlPoint = 0x4E4;
            }
            export namespace C_OP_NormalizeVector {
                export const m_flScale = 0x1E4;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_Orient2DRelToCP {
                export const m_nCP = 0x1E8;
                export const m_flRotOffset = 0x1E0;
                export const m_nFieldOutput = 0x1EC;
                export const m_flSpinStrength = 0x1E4;
            }
            export namespace C_OP_OscillateScalar {
                export const m_nField = 0x1F0;
                export const m_RateMax = 0x1E4;
                export const m_RateMin = 0x1E0;
                export const m_flOscAdd = 0x20C;
                export const m_flOscMult = 0x208;
                export const m_FrequencyMax = 0x1EC;
                export const m_FrequencyMin = 0x1E8;
                export const m_bProportional = 0x1F4;
                export const m_flEndTime_max = 0x204;
                export const m_flEndTime_min = 0x200;
                export const m_bProportionalOp = 0x1F5;
                export const m_flStartTime_max = 0x1FC;
                export const m_flStartTime_min = 0x1F8;
            }
            export namespace C_OP_OscillateVector {
                export const m_nField = 0x210;
                export const m_RateMax = 0x1EC;
                export const m_RateMin = 0x1E0;
                export const m_bOffset = 0x216;
                export const m_flOscAdd = 0x3A0;
                export const m_flOscMult = 0x228;
                export const m_flRateScale = 0x518;
                export const m_FrequencyMax = 0x204;
                export const m_FrequencyMin = 0x1F8;
                export const m_bProportional = 0x214;
                export const m_flEndTime_max = 0x224;
                export const m_flEndTime_min = 0x220;
                export const m_bProportionalOp = 0x215;
                export const m_flStartTime_max = 0x21C;
                export const m_flStartTime_min = 0x218;
            }
            export namespace C_OP_PinParticleToCP {
                export const m_flAge = 0xD38;
                export const m_vecOffset = 0x1E8;
                export const m_bOffsetLocal = 0x8C0;
                export const m_flBreakSpeed = 0xBC0;
                export const m_flBreakValue = 0xEB8;
                export const m_nPinBreakType = 0xA40;
                export const m_flBreakDistance = 0xA48;
                export const m_flInterpolation = 0x1030;
                export const m_nParticleNumber = 0x8C8;
                export const m_nParticleSelection = 0x8C4;
                export const m_nControlPointNumber = 0x1E0;
                export const m_bRetainInitialVelocity = 0x11A8;
                export const m_nBreakControlPointNumber = 0xEB0;
                export const m_nBreakControlPointNumber2 = 0xEB4;
            }
            export namespace C_OP_RemapCPtoScalar {
                export const m_nField = 0x1E8;
                export const m_nCPInput = 0x1E0;
                export const m_flEndTime = 0x200;
                export const m_flInputMax = 0x1F0;
                export const m_flInputMin = 0x1EC;
                export const m_nSetMethod = 0x208;
                export const m_flOutputMax = 0x1F8;
                export const m_flOutputMin = 0x1F4;
                export const m_flStartTime = 0x1FC;
                export const m_flInterpRate = 0x204;
                export const m_nFieldOutput = 0x1E4;
            }
            export namespace C_OP_RemapCPtoVector {
                export const m_bOffset = 0x22C;
                export const m_nCPInput = 0x1E0;
                export const m_flEndTime = 0x220;
                export const m_vInputMax = 0x1F8;
                export const m_vInputMin = 0x1EC;
                export const m_nSetMethod = 0x228;
                export const m_vOutputMax = 0x210;
                export const m_vOutputMin = 0x204;
                export const m_bAccelerate = 0x22D;
                export const m_flStartTime = 0x21C;
                export const m_flInterpRate = 0x224;
                export const m_nFieldOutput = 0x1E4;
                export const m_nLocalSpaceCP = 0x1E8;
            }
            export namespace C_OP_RemapVectortoCP {
                export const m_nFieldInput = 0x1E4;
                export const m_nParticleNumber = 0x1E8;
                export const m_nOutControlPointNumber = 0x1E0;
            }
            export namespace C_OP_RenderLightBeam {
                export const m_flRange = 0x1080;
                export const m_flSkirt = 0xF08;
                export const m_flThickness = 0x11F8;
                export const m_nMaxAllowed = 0x230;
                export const m_vColorBlend = 0x238;
                export const m_bCastShadows = 0xD88;
                export const m_flBounceScale = 0xD90;
                export const m_strLightStyle = 0x918;
                export const m_bDynamicBounce = 0xD89;
                export const m_flRenderFilter = 0x1EB8;
                export const m_nColorBlendType = 0x910;
                export const m_flInnerConeAngle = 0x1370;
                export const m_flLightStyleTime = 0x920;
                export const m_flOuterConeAngle = 0x14E8;
                export const m_nFogLightingMode = 0x1D38;
                export const m_bDebugOrientation = 0x2030;
                export const m_flFogContribution = 0x1D40;
                export const m_vecConeRotationOffset = 0x1660;
                export const m_flNumberOfLightsToCreate = 0xC10;
                export const m_flBrightnessLumensPerMeter = 0xA98;
            }
            export namespace C_OP_RenderProjected {
                export const m_flRollScale = 0x6E0;
                export const m_MaterialVars = 0x3D8;
                export const m_flAlphaScale = 0x568;
                export const m_nAlpha2Field = 0x858;
                export const m_bProjectWater = 0x232;
                export const m_bProjectWorld = 0x231;
                export const m_flRadiusScale = 0x3F0;
                export const m_vecColorScale = 0x860;
                export const m_bFlipHorizontal = 0x233;
                export const m_bOrientToNormal = 0x3D4;
                export const m_nColorBlendType = 0xF38;
                export const m_bProjectCharacter = 0x230;
                export const m_flMaterialSelection = 0x258;
                export const m_flAnimationTimeScale = 0x3D0;
                export const m_flMaxProjectionDepth = 0x23C;
                export const m_flMinProjectionDepth = 0x238;
                export const m_vecProjectedMaterials = 0x240;
                export const m_bEnableProjectedDepthControls = 0x234;
            }
            export namespace C_OP_RenderTreeShake {
                export const m_flRadius = 0x238;
                export const m_flTwistAmount = 0x248;
                export const m_flPeakStrength = 0x230;
                export const m_flRadialAmount = 0x24C;
                export const m_flShakeDuration = 0x240;
                export const m_flTransitionTime = 0x244;
                export const m_nRadiusFieldOverride = 0x23C;
                export const m_nPeakStrengthFieldOverride = 0x234;
                export const m_flControlPointOrientationAmount = 0x250;
                export const m_nControlPointForLinearDirection = 0x254;
            }
            export namespace C_OP_TurbulenceForce {
                export const m_vecNoiseAmount0 = 0x200;
                export const m_vecNoiseAmount1 = 0x20C;
                export const m_vecNoiseAmount2 = 0x218;
                export const m_vecNoiseAmount3 = 0x224;
                export const m_flNoiseCoordScale0 = 0x1F0;
                export const m_flNoiseCoordScale1 = 0x1F4;
                export const m_flNoiseCoordScale2 = 0x1F8;
                export const m_flNoiseCoordScale3 = 0x1FC;
            }
            export namespace C_OP_TwistAroundAxis {
                export const m_TwistAxis = 0x1F4;
                export const m_bLocalSpace = 0x200;
                export const m_fForceAmount = 0x1F0;
                export const m_nControlPointNumber = 0x204;
            }
            export namespace CPulseCell_LimitCount {
                export const m_nLimitCount = 0x48;
            }
            export namespace C_INIT_PositionOffset {
                export const m_OffsetMax = 0x8C0;
                export const m_OffsetMin = 0x1E8;
                export const m_bLocalCoords = 0x1000;
                export const m_bProportional = 0x1001;
                export const m_TransformInput = 0xF98;
                export const m_randomnessParameters = 0x1004;
            }
            export namespace C_INIT_RandomLifeTime {
                export const m_fLifetimeMax = 0x1EC;
                export const m_fLifetimeMin = 0x1E8;
                export const m_fLifetimeRandExponent = 0x1F0;
            }
            export namespace C_INIT_RandomRotation {

            }
            export namespace C_INIT_RandomSequence {
                export const m_bLinear = 0x1F1;
                export const m_bShuffle = 0x1F0;
                export const m_WeightedList = 0x1F8;
                export const m_nSequenceMax = 0x1EC;
                export const m_nSequenceMin = 0x1E8;
            }
            export namespace C_INIT_SequenceFromCP {
                export const m_nCP = 0x1EC;
                export const m_vecOffset = 0x1F0;
                export const m_bKillUnused = 0x1E8;
                export const m_bRadiusScale = 0x1E9;
            }
            export namespace C_INIT_StatusEffectTf {
                export const m_flSFXSScale = 0x1FC;
                export const m_nDetailCombo = 0x218;
                export const m_flSFXSOffsetX = 0x20C;
                export const m_flSFXSOffsetY = 0x210;
                export const m_flSFXSOffsetZ = 0x214;
                export const m_flSFXSScrollX = 0x200;
                export const m_flSFXSScrollY = 0x204;
                export const m_flSFXSScrollZ = 0x208;
                export const m_flSFXEnvMapAmount = 0x234;
                export const m_flSFXNormalAmount = 0x1EC;
                export const m_flSFXSDetailScale = 0x220;
                export const m_flSFXSUseModelUVs = 0x230;
                export const m_flSFXSDetailAmount = 0x21C;
                export const m_flSFXSDetailScrollX = 0x224;
                export const m_flSFXSDetailScrollY = 0x228;
                export const m_flSFXSDetailScrollZ = 0x22C;
                export const m_flSFXColorWarpAmount = 0x1E8;
                export const m_flSFXMetalnessAmount = 0x1F0;
                export const m_flSFXRoughnessAmount = 0x1F4;
                export const m_flSFXSelfIllumAmount = 0x1F8;
            }
            export namespace C_INIT_VelocityFromCP {
                export const m_velocityInput = 0x1E8;
                export const m_bDirectionOnly = 0x92C;
                export const m_transformInput = 0x8C0;
                export const m_flVelocityScale = 0x928;
            }
            export namespace C_INIT_VelocityRandom {
                export const m_bIgnoreDT = 0x1290;
                export const m_fSpeedMax = 0x368;
                export const m_fSpeedMin = 0x1F0;
                export const m_nControlPointNumber = 0x1E8;
                export const m_randomnessParameters = 0x1294;
                export const m_LocalCoordinateSystemSpeedMax = 0xBB8;
                export const m_LocalCoordinateSystemSpeedMin = 0x4E0;
            }
            export namespace C_OP_ColorInterpolate {
                export const m_ColorFade = 0x1E0;
                export const m_bEaseInOut = 0x1FC;
                export const m_nFieldOutput = 0x1F8;
                export const m_flFadeEndTime = 0x1F4;
                export const m_flFadeStartTime = 0x1F0;
            }
            export namespace C_OP_EndCapTimedDecay {
                export const m_flDecayTime = 0x1E0;
            }
            export namespace C_OP_LerpEndCapScalar {
                export const m_flOutput = 0x1E4;
                export const m_flLerpTime = 0x1E8;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_LerpEndCapVector {
                export const m_vecOutput = 0x1E4;
                export const m_flLerpTime = 0x1F0;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_PerParticleForce {
                export const m_nCP = 0xA40;
                export const m_vForce = 0x368;
                export const m_flForceScale = 0x1F0;
            }
            export namespace C_OP_PlanarConstraint {
                export const m_PlaneNormal = 0x1EC;
                export const m_bUseOldCode = 0x4F0;
                export const m_PointOnPlane = 0x1E0;
                export const m_bGlobalNormal = 0x1FD;
                export const m_bGlobalOrigin = 0x1FC;
                export const m_flRadiusScale = 0x200;
                export const m_nControlPointNumber = 0x1F8;
                export const m_flMaximumDistanceToCP = 0x378;
            }
            export namespace C_OP_RampScalarLinear {
                export const m_nField = 0x220;
                export const m_RateMax = 0x1E4;
                export const m_RateMin = 0x1E0;
                export const m_flEndTime_max = 0x1F4;
                export const m_flEndTime_min = 0x1F0;
                export const m_bProportionalOp = 0x224;
                export const m_flStartTime_max = 0x1EC;
                export const m_flStartTime_min = 0x1E8;
            }
            export namespace C_OP_RampScalarSpline {
                export const m_flBias = 0x1F8;
                export const m_nField = 0x220;
                export const m_RateMax = 0x1E4;
                export const m_RateMin = 0x1E0;
                export const m_bEaseOut = 0x225;
                export const m_flEndTime_max = 0x1F4;
                export const m_flEndTime_min = 0x1F0;
                export const m_bProportionalOp = 0x224;
                export const m_flStartTime_max = 0x1EC;
                export const m_flStartTime_min = 0x1E8;
            }
            export namespace C_OP_RenderClothForce {

            }
            export namespace C_OP_RenderOmni2Light {
                export const m_bFog = 0xF10;
                export const m_flRange = 0x2A08;
                export const m_flSkirt = 0x2890;
                export const m_vNormal = 0x1210;
                export const m_vTarget = 0x18E8;
                export const m_flFOVAngle = 0x1FC0;
                export const m_flFogScale = 0xF18;
                export const m_nLightType = 0x230;
                export const m_flBarnShape = 0x2138;
                export const m_flBarnSoftX = 0x25A0;
                export const m_flBarnSoftY = 0x2718;
                export const m_nMaxAllowed = 0x234;
                export const m_vColorBlend = 0x238;
                export const m_bCastShadows = 0xD90;
                export const m_hLightCookie = 0x2E70;
                export const m_flBounceScale = 0xD98;
                export const m_strLightStyle = 0x918;
                export const m_bDynamicBounce = 0xD91;
                export const m_flBarnNearSizeX = 0x22B0;
                export const m_flBarnNearSizeY = 0x2428;
                export const m_nBrightnessUnit = 0xA98;
                export const m_nColorBlendType = 0x910;
                export const m_bSphericalCookie = 0x2E78;
                export const m_flInnerConeAngle = 0x2B80;
                export const m_flLightStyleTime = 0x920;
                export const m_flOuterConeAngle = 0x2CF8;
                export const m_nOrientationType = 0x1208;
                export const m_flLuminaireRadius = 0x1090;
                export const m_flBrightnessLumens = 0xAA0;
                export const m_flBrightnessCandelas = 0xC18;
            }
            export namespace C_OP_TimeVaryingForce {
                export const m_EndingForce = 0x204;
                export const m_StartingForce = 0x1F4;
                export const m_flEndLerpTime = 0x200;
                export const m_flStartLerpTime = 0x1F0;
            }
            export namespace CGeneralRandomRotation {
                export const m_flDegrees = 0x1EC;
                export const m_flDegreesMax = 0x1F4;
                export const m_flDegreesMin = 0x1F0;
                export const m_nFieldOutput = 0x1E8;
                export const m_bRandomlyFlipDirection = 0x1FC;
                export const m_flRotationRandExponent = 0x1F8;
            }
            export namespace CParticleFunctionForce {

            }
            export namespace CPulseCell_CursorQueue {
                export const m_nCursorsAllowedToRunParallel = 0x128;
            }
            export namespace CPulseCell_FireCursors {
                export const m_Outflows = 0xD8;
                export const m_OnFinished = 0xF8;
                export const m_bWaitForChildOutflows = 0xF0;
            }
            export namespace CPulseCell_Inflow_Wait {
                export const m_WakeResume = 0xD8;
            }
            export namespace CPulseCell_RaceCursors {
                export const m_Outflows = 0xD8;
                export const m_OnFinished = 0xF0;
            }
            export namespace CPulseCell_Value_Curve {
                export const m_Curve = 0x48;
            }
            export namespace C_INIT_CreateAlongPath {
                export const m_fT = 0x360;
                export const m_PathParams = 0x4E0;
                export const m_vEndOffset = 0x524;
                export const m_bSaveOffset = 0x530;
                export const m_fMaxDistance = 0x1E8;
                export const m_bUseRandomCPs = 0x520;
            }
            export namespace C_INIT_CreateWithinBox {
                export const m_vecMax = 0x8C0;
                export const m_vecMin = 0x1E8;
                export const m_bLocalSpace = 0xF9C;
                export const m_bUseNewCode = 0xFA8;
                export const m_nControlPointNumber = 0xF98;
                export const m_randomnessParameters = 0xFA0;
            }
            export namespace C_INIT_InheritVelocity {
                export const m_flVelocityScale = 0x1EC;
                export const m_nControlPointNumber = 0x1E8;
            }
            export namespace C_INIT_NormalAlignToCP {
                export const m_transformInput = 0x1E8;
                export const m_nControlPointAxis = 0x250;
            }
            export namespace C_INIT_Orient2DRelToCP {
                export const m_nCP = 0x1E8;
                export const m_flRotOffset = 0x1F0;
                export const m_nFieldOutput = 0x1EC;
            }
            export namespace C_OP_ConstrainDistance {
                export const m_CenterOffset = 0x538;
                export const m_fMaxDistance = 0x358;
                export const m_fMinDistance = 0x1E0;
                export const m_bGlobalCenter = 0xC10;
                export const m_nControlPointNumber = 0x4D0;
            }
            export namespace C_OP_ContinuousEmitter {
                export const m_flEmitRate = 0x4D8;
                export const m_nEventType = 0x65C;
                export const m_flStartTime = 0x360;
                export const m_flEmissionScale = 0x650;
                export const m_nLimitPerUpdate = 0x670;
                export const m_strSnapshotSubset = 0x668;
                export const m_flEmissionDuration = 0x1E8;
                export const m_nSnapshotControlPoint = 0x660;
                export const m_bForceEmitOnLastUpdate = 0x675;
                export const m_bForceEmitOnFirstUpdate = 0x674;
                export const m_flScalePerParentParticle = 0x654;
                export const m_bInitFromKilledParentParticles = 0x658;
            }
            export namespace C_OP_ControlpointLight {
                export const m_flScale = 0x1E0;
                export const m_bUseNormal = 0x6E8;
                export const m_LightColor1 = 0x6D0;
                export const m_LightColor2 = 0x6D4;
                export const m_LightColor3 = 0x6D8;
                export const m_LightColor4 = 0x6DC;
                export const m_bLightType1 = 0x6E0;
                export const m_bLightType2 = 0x6E1;
                export const m_bLightType3 = 0x6E2;
                export const m_bLightType4 = 0x6E3;
                export const m_bUseHLambert = 0x6E9;
                export const m_vecCPOffset1 = 0x680;
                export const m_vecCPOffset2 = 0x68C;
                export const m_vecCPOffset3 = 0x698;
                export const m_vecCPOffset4 = 0x6A4;
                export const m_LightZeroDist1 = 0x6B4;
                export const m_LightZeroDist2 = 0x6BC;
                export const m_LightZeroDist3 = 0x6C4;
                export const m_LightZeroDist4 = 0x6CC;
                export const m_bLightDynamic1 = 0x6E4;
                export const m_bLightDynamic2 = 0x6E5;
                export const m_bLightDynamic3 = 0x6E6;
                export const m_bLightDynamic4 = 0x6E7;
                export const m_nControlPoint1 = 0x670;
                export const m_nControlPoint2 = 0x674;
                export const m_nControlPoint3 = 0x678;
                export const m_nControlPoint4 = 0x67C;
                export const m_LightFiftyDist1 = 0x6B0;
                export const m_LightFiftyDist2 = 0x6B8;
                export const m_LightFiftyDist3 = 0x6C0;
                export const m_LightFiftyDist4 = 0x6C8;
                export const m_bClampLowerRange = 0x6EE;
                export const m_bClampUpperRange = 0x6EF;
            }
            export namespace C_OP_EndCapTimedFreeze {
                export const m_flFreezeTime = 0x1E0;
            }
            export namespace C_OP_ExternalWindForce {
                export const m_vecScale = 0x8C8;
                export const m_bSampleWind = 0xFA0;
                export const m_bSampleWater = 0xFA1;
                export const m_bSampleGravity = 0xFA3;
                export const m_vecGravityForce = 0xFA8;
                export const m_vecBuoyancyForce = 0x1978;
                export const m_vecSamplePosition = 0x1F0;
                export const m_flLocalGravityScale = 0x1688;
                export const m_flLocalBuoyancyScale = 0x1800;
                export const m_bDampenNearWaterPlane = 0xFA2;
                export const m_bUseBasicMovementGravity = 0x1680;
            }
            export namespace C_OP_GameDecalRenderer {
                export const m_vecEndPos = 0x928;
                export const m_nEventType = 0x238;
                export const m_flDecalSize = 0x1178;
                export const m_vecStartPos = 0x250;
                export const m_flTraceBloat = 0x1000;
                export const m_flDecalRotation = 0x1468;
                export const m_nCollisionGroup = 0x248;
                export const m_sDecalGroupName = 0x230;
                export const m_bNoDecalsOnOwner = 0x1CBB;
                export const m_bVisualizeTraces = 0x1CBC;
                export const m_nDecalGroupIndex = 0x12F0;
                export const m_nInteractionMask = 0x240;
                export const m_vModulationColor = 0x15E0;
                export const m_bRandomDecalRotation = 0x1CB9;
                export const m_bUseGameDefaultDecalSize = 0x1CB8;
                export const m_bRandomlySelectDecalInGroup = 0x1CBA;
            }
            export namespace C_OP_InterpolateRadius {
                export const m_flBias = 0x1F4;
                export const m_flEndTime = 0x1E4;
                export const m_flEndScale = 0x1EC;
                export const m_flStartTime = 0x1E0;
                export const m_flStartScale = 0x1E8;
                export const m_bEaseInAndOut = 0x1F0;
            }
            export namespace C_OP_RemapScalarEndCap {
                export const m_flInputMax = 0x1EC;
                export const m_flInputMin = 0x1E8;
                export const m_flOutputMax = 0x1F4;
                export const m_flOutputMin = 0x1F0;
                export const m_nFieldInput = 0x1E0;
                export const m_nFieldOutput = 0x1E4;
            }
            export namespace C_OP_RenderGpuImplicit {
                export const m_nScaleCP = 0x6A8;
                export const m_fGridSize = 0x240;
                export const m_hMaterial = 0x6B0;
                export const m_fRadiusScale = 0x3B8;
                export const m_nIndexCountKb = 0x238;
                export const m_nVertexCountKb = 0x234;
                export const m_fIsosurfaceThreshold = 0x530;
                export const m_bUsePerParticleRadius = 0x230;
            }
            export namespace C_OP_RenderScreenShake {
                export const m_nFilterCP = 0x250;
                export const m_nRadiusField = 0x240;
                export const m_flRadiusScale = 0x234;
                export const m_nDurationField = 0x244;
                export const m_flDurationScale = 0x230;
                export const m_nAmplitudeField = 0x24C;
                export const m_nFrequencyField = 0x248;
                export const m_flAmplitudeScale = 0x23C;
                export const m_flFrequencyScale = 0x238;
            }
            export namespace C_OP_SequenceFromModel {
                export const m_flInputMax = 0x1F0;
                export const m_flInputMin = 0x1EC;
                export const m_nSetMethod = 0x1FC;
                export const m_flOutputMax = 0x1F8;
                export const m_flOutputMin = 0x1F4;
                export const m_nFieldOutput = 0x1E4;
                export const m_nFieldOutputAnim = 0x1E8;
                export const m_nControlPointNumber = 0x1E0;
            }
            export namespace C_OP_SetFromCPSnapshot {
                export const m_bPrev = 0x671;
                export const m_bRandom = 0x1FC;
                export const m_bReverse = 0x1FD;
                export const m_bSubSample = 0x670;
                export const m_nRandomSeed = 0x200;
                export const m_nLocalSpaceCP = 0x1F8;
                export const m_flInterpolation = 0x4F8;
                export const m_nAttributeToRead = 0x1F0;
                export const m_nAttributeToWrite = 0x1F4;
                export const m_strSnapshotSubset = 0x1E8;
                export const m_nSnapShotIncrement = 0x380;
                export const m_nControlPointNumber = 0x1E0;
                export const m_nSnapShotStartPoint = 0x208;
            }
            export namespace C_OP_SetSimulationRate {
                export const m_flSimulationScale = 0x1E8;
            }
            export namespace C_OP_UpdateLightSource {
                export const m_vColorTint = 0x1E0;
                export const m_flRadiusScale = 0x1E8;
                export const m_flBrightnessScale = 0x1E4;
                export const m_flMaximumLightingRadius = 0x1F0;
                export const m_flMinimumLightingRadius = 0x1EC;
                export const m_flPositionDampingConstant = 0x1F4;
            }
            export namespace ParticleChildrenInfo_t {
                export const m_bEndCap = 0xC;
                export const m_flDelay = 0x8;
                export const m_ChildRef = 0x0;
                export const m_nDetailLevel = 0x10;
                export const m_bDisableChild = 0xD;
            }
            export namespace ParticlePreviewState_t {
                export const m_groundType = 0xC;
                export const m_previewModel = 0x0;
                export const m_sequenceName = 0x10;
                export const m_hitboxSetName = 0x20;
                export const m_vecBodyGroups = 0x30;
                export const m_vecPreviewWind = 0x64;
                export const m_flPlaybackSpeed = 0x48;
                export const m_nModSpecificData = 0x8;
                export const m_materialGroupName = 0x28;
                export const m_vecPreviewGravity = 0x58;
                export const m_bShouldDrawHitboxes = 0x50;
                export const m_bAnimationNonLooping = 0x54;
                export const m_bShouldDrawAttachments = 0x51;
                export const m_flParticleSimulationRate = 0x4C;
                export const m_bShouldDrawAttachmentNames = 0x52;
                export const m_bSequenceNameIsAnimClipPath = 0x55;
                export const m_bShouldDrawControlPointAxes = 0x53;
                export const m_nFireParticleOnSequenceFrame = 0x18;
            }
            export namespace SequenceWeightedList_t {
                export const m_nSequence = 0x0;
                export const m_flRelativeWeight = 0x4;
            }
            export namespace CBasePulseGraphInstance {

            }
            export namespace CPulseCell_Inflow_Yield {
                export const m_UnyieldResume = 0xD8;
            }
            export namespace CPulseCell_ReturnValues {

            }
            export namespace C_INIT_ChaoticAttractor {
                export const m_flAParm = 0x1E8;
                export const m_flBParm = 0x1EC;
                export const m_flCParm = 0x1F0;
                export const m_flDParm = 0x1F4;
                export const m_flScale = 0x1F8;
                export const m_nBaseCP = 0x204;
                export const m_flSpeedMax = 0x200;
                export const m_flSpeedMin = 0x1FC;
                export const m_bUniformSpeed = 0x208;
            }
            export namespace C_INIT_CreateWithinCone {
                export const m_flSpeed = 0x540;
                export const m_flOffset = 0x6B8;
                export const m_flInnerAngle = 0x250;
                export const m_flOuterAngle = 0x3C8;
                export const m_TransformInput = 0x1E8;
                export const m_bCollapseOffset = 0x830;
                export const m_randomnessParameters = 0x834;
            }
            export namespace C_INIT_DistanceToCPInit {
                export const m_bLOS = 0x7D4;
                export const m_nStartCP = 0x7D0;
                export const m_nTraceSet = 0x858;
                export const m_flInputMax = 0x368;
                export const m_flInputMin = 0x1F0;
                export const m_flLOSScale = 0x9D8;
                export const m_nSetMethod = 0x9DC;
                export const m_flOutputMax = 0x658;
                export const m_flOutputMin = 0x4E0;
                export const m_flRemapBias = 0x9F0;
                export const m_bActiveRange = 0x9E0;
                export const m_nFieldOutput = 0x1E8;
                export const m_flMaxTraceLength = 0x860;
                export const m_vecDistanceScale = 0x9E4;
                export const m_CollisionGroupName = 0x7D5;
            }
            export namespace C_INIT_SequenceLifeTime {
                export const m_flFramerate = 0x1E8;
            }
            export namespace C_INIT_SetHitboxToModel {
                export const m_bUseBones = 0x8DD;
                export const m_flShellSize = 0x960;
                export const m_HitboxSetName = 0x8DE;
                export const m_nForceInModel = 0x1EC;
                export const m_nDesiredHitbox = 0x1F4;
                export const m_vecHitBoxScale = 0x1F8;
                export const m_bMaintainHitbox = 0x8DC;
                export const m_vecDirectionBias = 0x8D0;
                export const m_bEvenDistribution = 0x1F0;
                export const m_nControlPointNumber = 0x1E8;
            }
            export namespace C_OP_DecayMaintainCount {
                export const m_flScale = 0x200;
                export const m_bKillNewest = 0x378;
                export const m_flDecayDelay = 0x1E4;
                export const m_bLifespanDecay = 0x1F8;
                export const m_strSnapshotSubset = 0x1F0;
                export const m_nParticlesToMaintain = 0x1E0;
                export const m_nSnapshotControlPoint = 0x1E8;
            }
            export namespace C_OP_IntraParticleForce {
                export const m_bUseAABB = 0x208;
                export const m_flRepulsionMaxDistance = 0x200;
                export const m_flRepulsionMaxStrength = 0x204;
                export const m_flRepulsionMinDistance = 0x1FC;
                export const m_flAttractionMaxDistance = 0x1F4;
                export const m_flAttractionMaxStrength = 0x1F8;
                export const m_flAttractionMinDistance = 0x1F0;
            }
            export namespace C_OP_RampCPLinearRandom {
                export const m_vecRateMax = 0x1F8;
                export const m_vecRateMin = 0x1EC;
                export const m_nOutControlPointNumber = 0x1E8;
            }
            export namespace C_OP_RenderFlattenGrass {
                export const m_flRadiusScale = 0x238;
                export const m_flFlattenStrength = 0x230;
                export const m_nStrengthFieldOverride = 0x234;
            }
            export namespace C_OP_RenderStatusEffect {
                export const m_pTextureEnvMap = 0x260;
                export const m_pTextureDetail2 = 0x238;
                export const m_pTextureColorWarp = 0x230;
                export const m_pTextureDiffuseWarp = 0x240;
                export const m_pTextureFresnelWarp = 0x250;
                export const m_pTextureSpecularWarp = 0x258;
                export const m_pTextureFresnelColorWarp = 0x248;
            }
            export namespace C_OP_SetFloatCollection {
                export const m_Lerp = 0x360;
                export const m_InputValue = 0x1E0;
                export const m_nSetMethod = 0x35C;
                export const m_nOutputField = 0x358;
            }
            export namespace CollisionGroupContext_t {
                export const m_nCollisionGroupNumber = 0x0;
            }
            export namespace ControlPointReference_t {
                export const m_bOffsetInLocalSpace = 0x10;
                export const m_controlPointNameString = 0x0;
                export const m_vOffsetFromControlPoint = 0x4;
            }
            export namespace SignatureOutflow_Resume {

            }
            export namespace CParticleFunctionEmitter {
                export const m_nEmitterIndex = 0x1E0;
            }
            export namespace CPulseCell_Inflow_Method {
                export const m_Args = 0xA0;
                export const m_bIsPublic = 0x98;
                export const m_MethodName = 0x80;
                export const m_Description = 0x90;
                export const m_ReturnValues = 0xB0;
            }
            export namespace CPulseCell_IntervalTimer {
                export const m_Completed = 0xD8;
                export const m_OnInterval = 0x120;
            }
            export namespace CPulseCell_Step_DebugLog {

            }
            export namespace CPulse_OutflowConnection {
                export const m_nDestChunk = 0x10;
                export const m_nInstruction = 0x14;
                export const m_SourceOutflowName = 0x0;
                export const m_OutflowRegisterMap = 0x18;
            }
            export namespace C_INIT_AddVectorToVector {
                export const m_vecScale = 0x1E8;
                export const m_vOffsetMax = 0x208;
                export const m_vOffsetMin = 0x1FC;
                export const m_nFieldInput = 0x1F8;
                export const m_nFieldOutput = 0x1F4;
                export const m_randomnessParameters = 0x214;
            }
            export namespace C_INIT_CreatePhyllotaxis {
                export const m_fMinRad = 0x20C;
                export const m_fRadBias = 0x208;
                export const m_nScaleCP = 0x1EC;
                export const m_fDistBias = 0x210;
                export const m_nComponent = 0x1F0;
                export const m_fpointAngle = 0x200;
                export const m_fRadCentCore = 0x1F4;
                export const m_fRadPerPoint = 0x1F8;
                export const m_fsizeOverall = 0x204;
                export const m_bUseOrigRadius = 0x216;
                export const m_fRadPerPointTo = 0x1FC;
                export const m_bUseLocalCoords = 0x214;
                export const m_bUseWithContEmit = 0x215;
                export const m_nControlPointNumber = 0x1E8;
            }
            export namespace C_INIT_InitVecCollection {
                export const m_InputValue = 0x1E8;
                export const m_nOutputField = 0x8C0;
            }
            export namespace C_INIT_MoveBetweenPoints {
                export const m_bTrailBias = 0x944;
                export const m_flSpeedMax = 0x360;
                export const m_flSpeedMin = 0x1E8;
                export const m_flEndOffset = 0x7C8;
                export const m_flEndSpread = 0x4D8;
                export const m_flStartOffset = 0x650;
                export const m_nEndControlPointNumber = 0x940;
            }
            export namespace C_INIT_RandomTrailLength {
                export const m_flMaxLength = 0x1EC;
                export const m_flMinLength = 0x1E8;
                export const m_flLengthRandExponent = 0x1F0;
            }
            export namespace C_OP_ConstrainLineLength {
                export const m_flMaxDistance = 0x1E4;
                export const m_flMinDistance = 0x1E0;
            }
            export namespace C_OP_DistanceBetweenVecs {
                export const m_vecPoint1 = 0x1E8;
                export const m_vecPoint2 = 0x8C0;
                export const m_bDeltaTime = 0x157C;
                export const m_flInputMax = 0x1110;
                export const m_flInputMin = 0xF98;
                export const m_nSetMethod = 0x1578;
                export const m_flOutputMax = 0x1400;
                export const m_flOutputMin = 0x1288;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_DistanceToTransform {
                export const m_bLOS = 0x830;
                export const m_bAdditive = 0x8C5;
                export const m_nTraceSet = 0x8B4;
                export const m_flInputMax = 0x360;
                export const m_flInputMin = 0x1E8;
                export const m_flLOSScale = 0x8BC;
                export const m_nSetMethod = 0x8C0;
                export const m_flOutputMax = 0x650;
                export const m_flOutputMin = 0x4D8;
                export const m_bActiveRange = 0x8C4;
                export const m_nFieldOutput = 0x1E0;
                export const m_TransformStart = 0x7C8;
                export const m_flMaxTraceLength = 0x8B8;
                export const m_vecComponentScale = 0x8C8;
                export const m_CollisionGroupName = 0x831;
            }
            export namespace C_OP_DragRelativeToPlane {
                export const m_flFalloff = 0x358;
                export const m_bDirectional = 0x4D0;
                export const m_flDragAtPlane = 0x1E0;
                export const m_vecPlaneNormal = 0x4D8;
                export const m_nControlPointNumber = 0xBB0;
            }
            export namespace C_OP_ModelDampenMovement {
                export const m_fDrag = 0x940;
                export const m_bOutside = 0x1E5;
                export const m_bBoundBox = 0x1E4;
                export const m_bUseBones = 0x1E6;
                export const m_vecPosOffset = 0x268;
                export const m_HitboxSetName = 0x1E7;
                export const m_nControlPointNumber = 0x1E0;
            }
            export namespace C_OP_OrientTo2dDirection {
                export const m_vecInput = 0x1E0;
                export const m_flRotOffset = 0x8B8;
                export const m_nFieldOutput = 0x8C0;
                export const m_flSpinStrength = 0x8BC;
            }
            export namespace C_OP_QuantizeCPComponent {
                export const m_nCPOutput = 0x360;
                export const m_flInputValue = 0x1E8;
                export const m_flQuantizeValue = 0x368;
                export const m_nOutVectorField = 0x364;
            }
            export namespace C_OP_RemapDotProductToCP {
                export const m_nInputCP1 = 0x1E8;
                export const m_nInputCP2 = 0x1EC;
                export const m_nOutputCP = 0x1F0;
                export const m_flInputMax = 0x370;
                export const m_flInputMin = 0x1F8;
                export const m_flOutputMax = 0x660;
                export const m_flOutputMin = 0x4E8;
                export const m_nOutVectorField = 0x1F4;
            }
            export namespace C_OP_RenderDeferredLight {
                export const m_hTexture = 0x920;
                export const m_flSpotFoV = 0x940;
                export const m_bUseTexture = 0x91C;
                export const m_flAlphaScale = 0x234;
                export const m_nAlpha2Field = 0x238;
                export const m_flRadiusScale = 0x230;
                export const m_vecColorScale = 0x240;
                export const m_flStartFalloff = 0x938;
                export const m_flLightDistance = 0x934;
                export const m_nColorBlendType = 0x918;
                export const m_flDistanceFalloff = 0x93C;
                export const m_bUseAlphaTestWindow = 0x91D;
                export const m_nAlphaTestPointField = 0x928;
                export const m_nAlphaTestRangeField = 0x92C;
                export const m_nHSVShiftControlPoint = 0x944;
                export const m_nAlphaTestSharpnessField = 0x930;
            }
            export namespace C_OP_RenderMaterialProxy {
                export const m_flAlpha = 0xAA8;
                export const m_nProxyType = 0x234;
                export const m_MaterialVars = 0x238;
                export const m_vecColorScale = 0x3D0;
                export const m_nColorBlendType = 0xC20;
                export const m_hOverrideMaterial = 0x250;
                export const m_nMaterialControlPoint = 0x230;
                export const m_flMaterialOverrideEnabled = 0x258;
            }
            export namespace C_OP_RenderStandardLight {
                export const m_flPhi = 0xF08;
                export const m_flTheta = 0xD90;
                export const m_bIgnoreDT = 0x1810;
                export const m_nPriority = 0x1678;
                export const m_nLightType = 0x230;
                export const m_bClosedLoop = 0x1801;
                export const m_flIntensity = 0xA98;
                export const m_flMaxLength = 0x1808;
                export const m_flMinLength = 0x180C;
                export const m_lightCookie = 0x1670;
                export const m_nMaxAllowed = 0x234;
                export const m_bCastShadows = 0xC10;
                export const m_bReverseOrder = 0x1800;
                export const m_flBounceScale = 0xC18;
                export const m_flLengthScale = 0x1818;
                export const m_strLightStyle = 0x918;
                export const m_vecColorScale = 0x238;
                export const m_bDynamicBounce = 0xC11;
                export const m_bRenderDiffuse = 0x1668;
                export const m_nPrevPntSource = 0x1804;
                export const m_bRenderSpecular = 0x1669;
                export const m_flCapsuleLength = 0x17FC;
                export const m_nColorBlendType = 0x910;
                export const m_flLightStyleTime = 0x920;
                export const m_nFogLightingMode = 0x167C;
                export const m_flFogContribution = 0x1680;
                export const m_nAttenuationStyle = 0x11F8;
                export const m_flFalloffLinearity = 0x1200;
                export const m_flLengthFadeInTime = 0x181C;
                export const m_flRadiusMultiplier = 0x1080;
                export const m_flZeroPercentFalloff = 0x14F0;
                export const m_flFiftyPercentFalloff = 0x1378;
                export const m_nCapsuleLightBehavior = 0x17F8;
                export const m_flConstrainRadiusToLengthRatio = 0x1814;
            }
            export namespace C_OP_RenderVRHapticEvent {
                export const m_nHand = 0x230;
                export const m_flAmplitude = 0x240;
                export const m_nOutputField = 0x238;
                export const m_nOutputHandCP = 0x234;
            }
            export namespace C_OP_SnapshotSkinToBones {
                export const m_flPrevPosScale = 0x1F4;
                export const m_bTransformRadii = 0x1E1;
                export const m_flJumpThreshold = 0x1F0;
                export const m_bTransformNormals = 0x1E0;
                export const m_flLifeTimeFadeEnd = 0x1EC;
                export const m_flLifeTimeFadeStart = 0x1E8;
                export const m_nControlPointNumber = 0x1E4;
            }
            export namespace C_OP_StopAfterCPDuration {
                export const m_flDuration = 0x1E8;
                export const m_bPlayEndCap = 0x361;
                export const m_bDestroyImmediately = 0x360;
            }
            export namespace C_OP_VectorFieldSnapshot {
                export const m_vecScale = 0x368;
                export const m_bSetVelocity = 0xA44;
                export const m_flGridSpacing = 0xA48;
                export const m_nLocalSpaceCP = 0x1E8;
                export const m_bLockToSurface = 0xA45;
                export const m_flInterpolation = 0x1F0;
                export const m_nAttributeToWrite = 0x1E4;
                export const m_flBoundaryDampening = 0xA40;
                export const m_nControlPointNumber = 0x1E0;
            }
            export namespace CParticleBindingRealPulse {

            }
            export namespace CParticleFunctionOperator {

            }
            export namespace CParticleFunctionRenderer {
                export const VisibilityInputs = 0x1E0;
                export const m_bCannotBeRefracted = 0x228;
            }
            export namespace CParticleSystemDefinition {
                export const m_Children = 0xB8;
                export const m_Emitters = 0x28;
                export const m_nGroupID = 0x260;
                export const m_Operators = 0x58;
                export const m_Renderers = 0xA0;
                export const m_hFallback = 0x2F8;
                export const m_hSnapshot = 0x2D8;
                export const m_Constraints = 0x88;
                export const m_bShouldSort = 0x378;
                export const m_Initializers = 0x40;
                export const m_bShouldBatch = 0x358;
                export const m_flCullRadius = 0x2E8;
                export const m_nMinCPULevel = 0x338;
                export const m_nMinGPULevel = 0x33C;
                export const m_ConstantColor = 0x2A8;
                export const m_nMaxParticles = 0x25C;
                export const m_BoundingBoxMax = 0x270;
                export const m_BoundingBoxMin = 0x264;
                export const m_ConstantNormal = 0x2AC;
                export const m_flCullFillCost = 0x2EC;
                export const m_nMinimumFrames = 0x330;
                export const m_ForceGenerators = 0x70;
                export const m_bInfiniteBounds = 0x284;
                export const m_flDepthSortBias = 0x27C;
                export const m_hLowViolenceDef = 0x308;
                export const m_NamedValueDomain = 0x288;
                export const m_NamedValueLocals = 0x290;
                export const m_flConstantRadius = 0x2B8;
                export const m_flMaximumSimTime = 0x324;
                export const m_flMinimumSimTime = 0x328;
                export const m_nBehaviorVersion = 0x8;
                export const m_nViewModelEffect = 0x35C;
                export const m_pszTargetLayerID = 0x368;
                export const m_flAggregateRadius = 0x354;
                export const m_flMaxDrawDistance = 0x344;
                export const m_flMaximumTimeStep = 0x320;
                export const m_flMinimumTimeStep = 0x32C;
                export const m_nCullControlPoint = 0x2F0;
                export const m_nFallbackMaxCount = 0x300;
                export const m_nInitialParticles = 0x258;
                export const m_bEnableNamedValues = 0x285;
                export const m_bScreenSpaceEffect = 0x360;
                export const m_flConstantLifespan = 0x2C4;
                export const m_flConstantRotation = 0x2BC;
                export const m_flPreSimulationTime = 0x318;
                export const m_flStartFadeDistance = 0x348;
                export const m_PreEmissionOperators = 0x10;
                export const m_bIsGPUParticleSystem = 0x334;
                export const m_flMaxCreationDistance = 0x34C;
                export const m_hReferenceReplacement = 0x310;
                export const m_nSnapshotControlPoint = 0x2D0;
                export const m_pszCullReplacementName = 0x2E0;
                export const m_flConstantRotationSpeed = 0x2C0;
                export const m_flNoDrawTimeToGoToSleep = 0x340;
                export const m_nConstantSequenceNumber = 0x2C8;
                export const m_nSkipRenderControlPoint = 0x370;
                export const m_nSortOverridePositionCP = 0x280;
                export const m_nAllowRenderControlPoint = 0x374;
                export const m_nConstantSequenceNumber1 = 0x2CC;
                export const m_flStopSimulationAfterTime = 0x31C;
                export const m_controlPointConfigurations = 0x3C0;
                export const m_bShouldHitboxesFallbackToSnapshot = 0x35A;
                export const m_nAggregationMinAvailableParticles = 0x350;
                export const m_bShouldHitboxesFallbackToRenderBounds = 0x359;
                export const m_nFirstMultipleOverride_BackwardCompat = 0x178;
                export const m_bShouldHitboxesFallbackToCollisionHulls = 0x35B;
            }
            export namespace CParticleVisibilityInputs {
                export const m_nCPin = 0x4;
                export const m_bRightEye = 0x44;
                export const m_flInputMax = 0x10;
                export const m_flInputMin = 0xC;
                export const m_bDotCPAngles = 0x2C;
                export const m_flCameraBias = 0x0;
                export const m_flDotInputMax = 0x28;
                export const m_flDotInputMin = 0x24;
                export const m_flProxyRadius = 0x8;
                export const m_flAlphaScaleMax = 0x34;
                export const m_flAlphaScaleMin = 0x30;
                export const m_bDotCameraAngles = 0x2D;
                export const m_flRadiusScaleMax = 0x3C;
                export const m_flRadiusScaleMin = 0x38;
                export const m_flDistanceInputMax = 0x20;
                export const m_flDistanceInputMin = 0x1C;
                export const m_flInputPixelVisFade = 0x14;
                export const m_flRadiusScaleFOVBase = 0x40;
                export const m_flNoPixelVisibilityFallback = 0x18;
            }
            export namespace CPulseCell_Value_Gradient {
                export const m_Gradient = 0x48;
            }
            export namespace C_INIT_CreateSpiralSphere {
                export const m_flDensity = 0x250;
                export const m_TransformInput = 0x1E8;
                export const m_flInitialRadius = 0x3C8;
                export const m_bUseParticleCount = 0x830;
                export const m_flInitialSpeedMax = 0x6B8;
                export const m_flInitialSpeedMin = 0x540;
            }
            export namespace C_INIT_InitFromCPSnapshot {
                export const m_bRandom = 0x204;
                export const m_bReverse = 0x205;
                export const m_nRandomSeed = 0x4F8;
                export const m_nLocalSpaceCP = 0x200;
                export const m_nAttributeToRead = 0x1F8;
                export const m_bLocalSpaceAngles = 0x4FC;
                export const m_nAttributeToWrite = 0x1FC;
                export const m_strSnapshotSubset = 0x1F0;
                export const m_nSnapShotIncrement = 0x208;
                export const m_nControlPointNumber = 0x1E8;
                export const m_nManualSnapshotIndex = 0x380;
            }
            export namespace C_INIT_PositionOffsetToCP {
                export const m_bLocalCoords = 0x1F0;
                export const m_nControlPointNumberEnd = 0x1EC;
                export const m_nControlPointNumberStart = 0x1E8;
            }
            export namespace C_INIT_PositionWarpScalar {
                export const m_InputValue = 0x200;
                export const m_vecWarpMax = 0x1F4;
                export const m_vecWarpMin = 0x1E8;
                export const m_flPrevPosScale = 0x378;
                export const m_nControlPointNumber = 0x380;
                export const m_nScaleControlPointNumber = 0x37C;
            }
            export namespace C_INIT_RadiusFromCPObject {
                export const m_nControlPoint = 0x1E8;
            }
            export namespace C_INIT_SetHitboxToClosest {
                export const m_bUseBones = 0x948;
                export const m_nTestType = 0x94C;
                export const m_HitboxSetName = 0x8C8;
                export const m_flHybridRatio = 0x950;
                export const m_nDesiredHitbox = 0x1EC;
                export const m_vecHitBoxScale = 0x1F0;
                export const m_bUpdatePosition = 0xAC8;
                export const m_nControlPointNumber = 0x1E8;
                export const m_bUseClosestPointOnHitbox = 0x949;
            }
            export namespace C_INIT_SetRigidAttachment {
                export const m_bLocalSpace = 0x1F4;
                export const m_nFieldInput = 0x1EC;
                export const m_nFieldOutput = 0x1F0;
                export const m_nControlPointNumber = 0x1E8;
            }
            export namespace C_INIT_VelocityFromNormal {
                export const m_bIgnoreDt = 0x1F0;
                export const m_fSpeedMax = 0x1EC;
                export const m_fSpeedMin = 0x1E8;
            }
            export namespace C_OP_InstantaneousEmitter {
                export const m_nEventType = 0x4DC;
                export const m_flStartTime = 0x360;
                export const m_nParticlesToEmit = 0x1E8;
                export const m_strSnapshotSubset = 0x660;
                export const m_nMaxEmittedPerFrame = 0x658;
                export const m_flParentParticleScale = 0x4E0;
                export const m_nSnapshotControlPoint = 0x65C;
                export const m_flInitFromKilledParentParticles = 0x4D8;
            }
            export namespace C_OP_LazyCullCompareFloat {
                export const m_flCullTime = 0x4D0;
                export const m_flComparsion1 = 0x1E0;
                export const m_flComparsion2 = 0x358;
            }
            export namespace C_OP_LerpToOtherAttribute {
                export const m_nFieldInput = 0x35C;
                export const m_nFieldOutput = 0x360;
                export const m_flInterpolation = 0x1E0;
                export const m_nFieldInputFrom = 0x358;
            }
            export namespace C_OP_RemapDensityToVector {
                export const m_flDensityMax = 0x1EC;
                export const m_flDensityMin = 0x1E8;
                export const m_nFieldOutput = 0x1E4;
                export const m_vecOutputMax = 0x1FC;
                export const m_vecOutputMin = 0x1F0;
                export const m_flRadiusScale = 0x1E0;
                export const m_bUseParentDensity = 0x208;
                export const m_nVoxelGridResolution = 0x20C;
            }
            export namespace C_OP_RemapGravityToVector {
                export const m_vInput1 = 0x1E0;
                export const m_nSetMethod = 0x8BC;
                export const m_nOutputField = 0x8B8;
                export const m_bNormalizedOutput = 0x8C0;
            }
            export namespace C_OP_RemapModelVolumetoCP {
                export const m_nField = 0x1F8;
                export const m_bBBoxOnly = 0x20C;
                export const m_bCubeRoot = 0x20D;
                export const m_nBBoxType = 0x1E8;
                export const m_flInputMax = 0x200;
                export const m_flInputMin = 0x1FC;
                export const m_flOutputMax = 0x208;
                export const m_flOutputMin = 0x204;
                export const m_nInControlPointNumber = 0x1EC;
                export const m_nOutControlPointNumber = 0x1F0;
                export const m_nOutControlPointMaxNumber = 0x1F4;
            }
            export namespace C_OP_RemapScalarOnceTimed {
                export const m_flInputMax = 0x1F0;
                export const m_flInputMin = 0x1EC;
                export const m_flOutputMax = 0x1F8;
                export const m_flOutputMin = 0x1F4;
                export const m_flRemapTime = 0x1FC;
                export const m_nFieldInput = 0x1E4;
                export const m_nFieldOutput = 0x1E8;
                export const m_bProportional = 0x1E0;
            }
            export namespace C_OP_RenderPostProcessing {
                export const m_nPriority = 0x3B0;
                export const m_hPostTexture = 0x3A8;
                export const m_flPostProcessStrength = 0x230;
            }
            export namespace C_OP_RenderStatusEffectTf {
                export const m_pTextureDetail = 0x258;
                export const m_pTextureEnvMap = 0x260;
                export const m_pTextureNormal = 0x238;
                export const m_pTextureColorWarp = 0x230;
                export const m_pTextureMetalness = 0x240;
                export const m_pTextureRoughness = 0x248;
                export const m_pTextureSelfIllum = 0x250;
            }
            export namespace C_OP_RestartAfterDuration {
                export const m_nCP = 0x1E8;
                export const m_nCPField = 0x1EC;
                export const m_bOnlyChildren = 0x1F4;
                export const m_flDurationMax = 0x1E4;
                export const m_flDurationMin = 0x1E0;
                export const m_nChildGroupID = 0x1F0;
            }
            export namespace C_OP_RopeSpringConstraint {
                export const m_flRestLength = 0x1E0;
                export const m_flMaxDistance = 0x4D0;
                export const m_flMinDistance = 0x358;
                export const m_flAdjustmentScale = 0x648;
                export const m_flInitialRestingLength = 0x650;
            }
            export namespace C_OP_SetControlPointToHMD {
                export const m_nCP1 = 0x1E8;
                export const m_vecCP1Pos = 0x1EC;
                export const m_bOrientToHMD = 0x1F8;
            }
            export namespace C_OP_WaterImpulseRenderer {
                export const m_vecPos = 0x230;
                export const m_flShape = 0xBF8;
                export const m_flRadius = 0x908;
                export const m_flWobble = 0xEE8;
                export const m_nEventType = 0x1064;
                export const m_flMagnitude = 0xA80;
                export const m_flWindSpeed = 0xD70;
                export const m_bIsRadialWind = 0x1060;
            }
            export namespace C_OP_WorldTraceConstraint {
                export const m_nCP = 0x1E0;
                export const m_nIgnoreCP = 0x280;
                export const m_nTraceSet = 0x1F8;
                export const m_bBrushOnly = 0x27D;
                export const m_bSetNormal = 0x881;
                export const m_bWorldOnly = 0x27C;
                export const m_flMinSpeed = 0x87C;
                export const m_flStopSpeed = 0x888;
                export const m_vecCpOffset = 0x1E4;
                export const m_bDecayBounce = 0x878;
                export const m_flRetestRate = 0x288;
                export const m_bIncludeWater = 0x27E;
                export const m_flRadiusScale = 0x298;
                export const m_flSlideAmount = 0x588;
                export const m_bKillonContact = 0x879;
                export const m_flBounceAmount = 0x410;
                export const m_nCollisionMode = 0x1F0;
                export const m_flRandomDirScale = 0x700;
                export const m_flTraceTolerance = 0x28C;
                export const m_nCollisionModeMin = 0x1F4;
                export const m_CollisionGroupName = 0x1FC;
                export const m_nMaxTracesPerFrame = 0x294;
                export const m_bKillonContactBounce = 0x880;
                export const m_flCpMovementTolerance = 0x284;
                export const m_nEntityStickDataField = 0xA00;
                export const m_nStickOnCollisionField = 0x884;
                export const m_nEntityStickNormalField = 0xA04;
                export const m_flCollisionConfirmationSpeed = 0x290;
            }
            export namespace IParticleSystemDefinition {

            }
            export namespace OutflowWithRequirements_t {
                export const m_Connection = 0x0;
                export const m_RequirementNodeIDs = 0x50;
                export const m_DestinationFlowNodeID = 0x48;
                export const m_nCursorStateBlockIndex = 0x68;
            }
            export namespace RenderProjectedMaterial_t {
                export const m_hMaterial = 0x0;
            }
            export namespace SignatureOutflow_Continue {

            }
            export namespace CPulseCell_BaseRequirement {

            }
            export namespace CPulseCell_Value_RandomInt {

            }
            export namespace CPulse_BlackboardReference {
                export const m_nNodeID = 0x18;
                export const m_NodeName = 0x20;
                export const m_BlackboardResource = 0x8;
                export const m_hBlackboardResource = 0x0;
            }
            export namespace C_INIT_ColorLitPerParticle {
                export const m_TintMax = 0x20C;
                export const m_TintMin = 0x208;
                export const m_ColorMax = 0x204;
                export const m_ColorMin = 0x200;
                export const m_flTintPerc = 0x210;
                export const m_nTintBlendMode = 0x214;
                export const m_flLightAmplification = 0x218;
            }
            export namespace C_INIT_CreateInEpitrochoid {
                export const m_flOffset = 0x3D0;
                export const m_bUseCount = 0x838;
                export const m_flRadius1 = 0x548;
                export const m_flRadius2 = 0x6C0;
                export const m_nComponent1 = 0x1E8;
                export const m_nComponent2 = 0x1EC;
                export const m_TransformInput = 0x1F0;
                export const m_bUseLocalCoords = 0x839;
                export const m_flParticleDensity = 0x258;
                export const m_bOffsetExistingPos = 0x83A;
            }
            export namespace C_INIT_InitFloatCollection {
                export const m_InputValue = 0x1E8;
                export const m_nOutputField = 0x360;
            }
            export namespace C_INIT_RandomModelSequence {
                export const m_hModel = 0x3E8;
                export const m_ActivityName = 0x1E8;
                export const m_SequenceName = 0x2E8;
            }
            export namespace C_INIT_RandomRotationSpeed {

            }
            export namespace C_INIT_RemapScalarToVector {
                export const m_flEndTime = 0x214;
                export const m_flInputMax = 0x1F4;
                export const m_flInputMin = 0x1F0;
                export const m_nSetMethod = 0x218;
                export const m_flRemapBias = 0x224;
                export const m_flStartTime = 0x210;
                export const m_nFieldInput = 0x1E8;
                export const m_bLocalCoords = 0x220;
                export const m_nFieldOutput = 0x1EC;
                export const m_vecOutputMax = 0x204;
                export const m_vecOutputMin = 0x1F8;
                export const m_nControlPointNumber = 0x21C;
            }
            export namespace C_INIT_StatusEffectCitadel {
                export const m_flSFXSScale = 0x1FC;
                export const m_nDetailCombo = 0x218;
                export const m_flSFXSOffsetX = 0x20C;
                export const m_flSFXSOffsetY = 0x210;
                export const m_flSFXSOffsetZ = 0x214;
                export const m_flSFXSScrollX = 0x200;
                export const m_flSFXSScrollY = 0x204;
                export const m_flSFXSScrollZ = 0x208;
                export const m_flSFXNormalAmount = 0x1EC;
                export const m_flSFXSDetailScale = 0x220;
                export const m_flSFXSUseModelUVs = 0x230;
                export const m_flSFXSDetailAmount = 0x21C;
                export const m_flSFXSDetailScrollX = 0x224;
                export const m_flSFXSDetailScrollY = 0x228;
                export const m_flSFXSDetailScrollZ = 0x22C;
                export const m_flSFXColorWarpAmount = 0x1E8;
                export const m_flSFXMetalnessAmount = 0x1F0;
                export const m_flSFXRoughnessAmount = 0x1F4;
                export const m_flSFXSelfIllumAmount = 0x1F8;
            }
            export namespace C_OP_AttractToControlPoint {
                export const m_fForceAmount = 0x200;
                export const m_fFalloffPower = 0x4F0;
                export const m_TransformInput = 0x4F8;
                export const m_bApplyMinForce = 0x6D8;
                export const m_fForceAmountMin = 0x560;
                export const m_fMinimumDistance = 0x378;
                export const m_vecComponentScale = 0x1F0;
            }
            export namespace C_OP_FadeAndKillForTracers {
                export const m_flEndAlpha = 0x1F4;
                export const m_flStartAlpha = 0x1F0;
                export const m_flEndFadeInTime = 0x1E4;
                export const m_flEndFadeOutTime = 0x1EC;
                export const m_flStartFadeInTime = 0x1E0;
                export const m_flStartFadeOutTime = 0x1E8;
            }
            export namespace C_OP_ForceControlPointStub {
                export const m_ControlPoint = 0x1E8;
            }
            export namespace C_OP_InheritFromPeerSystem {
                export const m_nGroupID = 0x1EC;
                export const m_nIncrement = 0x1E8;
                export const m_nFieldInput = 0x1E4;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_LerpToInitialPosition {
                export const m_flScale = 0x368;
                export const m_vecScale = 0x4E0;
                export const m_nCacheField = 0x360;
                export const m_flInterpolation = 0x1E8;
                export const m_nControlPointNumber = 0x1E0;
            }
            export namespace C_OP_MovementPlaceOnGround {
                export const m_nLerpCP = 0xACC;
                export const m_nRefCP1 = 0xAC4;
                export const m_nRefCP2 = 0xAC8;
                export const m_flOffset = 0x1E0;
                export const m_nIgnoreCP = 0xAE8;
                export const m_nTraceSet = 0xAC0;
                export const m_bSetNormal = 0xAE0;
                export const m_flLerpRate = 0xA3C;
                export const m_flTolerance = 0x35C;
                export const m_vecTraceDir = 0x360;
                export const m_bScaleOffset = 0xAE1;
                export const m_bIncludeWater = 0xADD;
                export const m_flTraceOffset = 0xA38;
                export const m_bIncludeShotHull = 0xADC;
                export const m_flMaxTraceLength = 0x358;
                export const m_nPreserveOffsetCP = 0xAE4;
                export const m_CollisionGroupName = 0xA40;
                export const m_nTraceMissBehavior = 0xAD8;
            }
            export namespace C_OP_OscillateScalarSimple {
                export const m_Rate = 0x1E0;
                export const m_nField = 0x1E8;
                export const m_flOscAdd = 0x1F0;
                export const m_Frequency = 0x1E4;
                export const m_flOscMult = 0x1EC;
            }
            export namespace C_OP_OscillateVectorSimple {
                export const m_Rate = 0x1E0;
                export const m_nField = 0x1F8;
                export const m_bOffset = 0x204;
                export const m_flOscAdd = 0x200;
                export const m_Frequency = 0x1EC;
                export const m_flOscMult = 0x1FC;
            }
            export namespace C_OP_RemapExternalWindToCP {
                export const m_nCP = 0x1E8;
                export const m_vecScale = 0x1F0;
                export const m_nCPOutput = 0x1EC;
                export const m_bSetMagnitude = 0x8C8;
                export const m_nOutVectorField = 0x8CC;
            }
            export namespace C_OP_RemapVelocityToVector {
                export const m_flScale = 0x1E4;
                export const m_bNormalize = 0x1E8;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_RemapVisibilityScalar {
                export const m_flInputMax = 0x1EC;
                export const m_flInputMin = 0x1E8;
                export const m_flOutputMax = 0x1F4;
                export const m_flOutputMin = 0x1F0;
                export const m_nFieldInput = 0x1E0;
                export const m_nFieldOutput = 0x1E4;
                export const m_flRadiusScale = 0x1F8;
            }
            export namespace C_OP_SetChildControlPoints {
                export const m_bReverse = 0x368;
                export const m_nOrientation = 0x36C;
                export const m_nChildGroupID = 0x1E0;
                export const m_bSetOrientation = 0x369;
                export const m_nFirstSourcePoint = 0x1F0;
                export const m_nNumControlPoints = 0x1E8;
                export const m_nFirstControlPoint = 0x1E4;
            }
            export namespace C_OP_SetControlPointToHand {
                export const m_nCP1 = 0x1E8;
                export const m_nHand = 0x1EC;
                export const m_vecCP1Pos = 0x1F0;
                export const m_bOrientToHand = 0x1FC;
            }
            export namespace C_OP_VelocityMatchingForce {
                export const m_bUseAABB = 0x1F0;
                export const m_flDirScale = 0x1E0;
                export const m_flSpdScale = 0x1E4;
                export const m_nCPBroadcast = 0x1F4;
                export const m_flFacingStrength = 0x1EC;
                export const m_flNeighborDistance = 0x1E8;
            }
            export namespace ParticlePreviewBodyGroup_t {
                export const m_nValue = 0x8;
                export const m_bodyGroupName = 0x0;
            }
            export namespace PulseNodeDynamicOutflows_t {
                export const m_Outflows = 0x0;
            }
            export namespace PulseSelectorOutflowList_t {
                export const m_Outflows = 0x0;
            }
            export namespace VecInputMaterialVariable_t {
                export const m_vecInput = 0x8;
                export const m_strVariable = 0x0;
            }
            export namespace CParticleFunctionConstraint {

            }
            export namespace CPulseCell_Inflow_GraphHook {
                export const m_HookName = 0x80;
            }
            export namespace C_INIT_CreateFromPlaneCache {
                export const m_bUseNormal = 0x201;
                export const m_vecOffsetMax = 0x1F4;
                export const m_vecOffsetMin = 0x1E8;
            }
            export namespace C_INIT_CreateSequentialPath {
                export const m_bLoop = 0x1F0;
                export const m_bCPPairs = 0x1F1;
                export const m_PathParams = 0x200;
                export const m_bSaveOffset = 0x1F2;
                export const m_fMaxDistance = 0x1E8;
                export const m_flNumToAssign = 0x1EC;
            }
            export namespace C_INIT_InitFromParentKilled {
                export const m_nEventType = 0x1EC;
                export const m_nAttributeToCopy = 0x1E8;
            }
            export namespace C_INIT_InitialVelocityNoise {
                export const m_flOffset = 0x8D8;
                export const m_bIgnoreDt = 0x1B58;
                export const m_vecAbsVal = 0x1E8;
                export const m_flNoiseScale = 0x1800;
                export const m_vecAbsValInv = 0x1F4;
                export const m_vecOffsetLoc = 0x200;
                export const m_vecOutputMax = 0x1128;
                export const m_vecOutputMin = 0xA50;
                export const m_TransformInput = 0x1AF0;
                export const m_flNoiseScaleLoc = 0x1978;
            }
            export namespace C_INIT_LifespanFromVelocity {
                export const m_nTraceSet = 0x288;
                export const m_nMaxPlanes = 0x200;
                export const m_bIncludeWater = 0x298;
                export const m_flTraceOffset = 0x1F4;
                export const m_flMaxTraceLength = 0x1F8;
                export const m_flTraceTolerance = 0x1FC;
                export const m_vecComponentScale = 0x1E8;
                export const m_CollisionGroupName = 0x208;
            }
            export namespace C_INIT_OffsetVectorToVector {
                export const m_nFieldInput = 0x1E8;
                export const m_nFieldOutput = 0x1EC;
                export const m_vecOutputMax = 0x1FC;
                export const m_vecOutputMin = 0x1F0;
                export const m_randomnessParameters = 0x208;
            }
            export namespace C_INIT_RandomSecondSequence {
                export const m_nSequenceMax = 0x1EC;
                export const m_nSequenceMin = 0x1E8;
            }
            export namespace C_INIT_VelocityRadialRandom {
                export const m_vecFwd = 0x8C8;
                export const m_fSpeedMax = 0x1118;
                export const m_fSpeedMin = 0xFA0;
                export const m_vecPosition = 0x1F0;
                export const m_bIgnoreDelta = 0x129D;
                export const m_bPerParticleCenter = 0x1E8;
                export const m_nControlPointNumber = 0x1EC;
                export const m_vecLocalCoordinateSystemSpeedScale = 0x1290;
            }
            export namespace C_OP_ColorInterpolateRandom {
                export const m_bEaseInOut = 0x218;
                export const m_ColorFadeMax = 0x1FC;
                export const m_ColorFadeMin = 0x1E0;
                export const m_nFieldOutput = 0x214;
                export const m_flFadeEndTime = 0x210;
                export const m_flFadeStartTime = 0x20C;
            }
            export namespace C_OP_DistanceBetweenCPsToCP {
                export const m_bLOS = 0x214;
                export const m_nEndCP = 0x1EC;
                export const m_bSetOnce = 0x1F8;
                export const m_nStartCP = 0x1E8;
                export const m_nOutputCP = 0x1F0;
                export const m_nTraceSet = 0x298;
                export const m_flInputMax = 0x200;
                export const m_flInputMin = 0x1FC;
                export const m_flLOSScale = 0x210;
                export const m_nSetParent = 0x29C;
                export const m_flOutputMax = 0x208;
                export const m_flOutputMin = 0x204;
                export const m_nOutputCPField = 0x1F4;
                export const m_flMaxTraceLength = 0x20C;
                export const m_CollisionGroupName = 0x215;
            }
            export namespace C_OP_LocalAccelerationForce {
                export const m_nCP = 0x1F0;
                export const m_nScaleCP = 0x1F4;
                export const m_vecAccel = 0x1F8;
            }
            export namespace C_OP_MaintainSequentialPath {
                export const m_bLoop = 0x64C;
                export const m_PathParams = 0x650;
                export const m_flTolerance = 0x648;
                export const m_fMaxDistance = 0x1E0;
                export const m_flNumToAssign = 0x358;
                export const m_bUseParticleCount = 0x64D;
                export const m_flCohesionStrength = 0x4D0;
            }
            export namespace C_OP_MovementMaintainOffset {
                export const m_nCP = 0x1EC;
                export const m_vecOffset = 0x1E0;
                export const m_bRadiusScale = 0x1F0;
            }
            export namespace C_OP_PlayEndCapWhenFinished {
                export const m_bIncludeChildren = 0x1E9;
                export const m_bFireOnEmissionEnd = 0x1E8;
            }
            export namespace C_OP_RampScalarLinearSimple {
                export const m_Rate = 0x1E0;
                export const m_nField = 0x210;
                export const m_flEndTime = 0x1E8;
                export const m_flStartTime = 0x1E4;
            }
            export namespace C_OP_RampScalarSplineSimple {
                export const m_Rate = 0x1E0;
                export const m_nField = 0x210;
                export const m_bEaseOut = 0x214;
                export const m_flEndTime = 0x1E8;
                export const m_flStartTime = 0x1E4;
            }
            export namespace C_OP_RemapVectorToRotations {
                export const m_vecInput = 0x1E0;
                export const m_vecRotation = 0x8B8;
            }
            export namespace C_OP_WorldCollideConstraint {

            }
            export namespace CParticleFunctionInitializer {
                export const m_nAssociatedEmitterIndex = 0x1E0;
            }
            export namespace CParticleFunctionPreEmission {
                export const m_bRunOnce = 0x1E0;
            }
            export namespace CPulseCell_Step_PublicOutput {
                export const m_OutputIndex = 0x48;
            }
            export namespace CPulseCell_Value_RandomFloat {

            }
            export namespace CPulseCell_WaitForObservable {
                export const m_OnTrue = 0x168;
                export const m_Condition = 0xD8;
            }
            export namespace C_INIT_CheckParticleForWater {
                export const m_flRadius = 0x1E8;
                export const m_nSetMethod = 0x4E0;
                export const m_nFieldOutput = 0x360;
                export const m_flOutputRemap = 0x368;
            }
            export namespace C_INIT_CreateOnModelAtHeight {
                export const m_bForceZ = 0x1E9;
                export const m_bUseBones = 0x1E8;
                export const m_nBiasType = 0x1120;
                export const m_nHeightCP = 0x1F0;
                export const m_bLocalCoords = 0x1124;
                export const m_HitboxSetName = 0x1126;
                export const m_vecHitBoxScale = 0x370;
                export const m_bUseWaterHeight = 0x1F4;
                export const m_flDesiredHeight = 0x1F8;
                export const m_vecDirectionBias = 0xA48;
                export const m_flMaxBoneVelocity = 0x1320;
                export const m_bPreferMovingBoxes = 0x1125;
                export const m_nControlPointNumber = 0x1EC;
                export const m_flHitboxVelocityScale = 0x11A8;
            }
            export namespace C_INIT_CreateParticleImpulse {
                export const m_InputRadius = 0x1E8;
                export const m_nImpulseType = 0x658;
                export const m_InputMagnitude = 0x360;
                export const m_InputFalloffExp = 0x4E0;
                export const m_nFalloffFunction = 0x4D8;
            }
            export namespace C_INIT_PositionPlaceOnGround {
                export const m_flOffset = 0x1E8;
                export const m_nIgnoreCP = 0xC60;
                export const m_nTraceSet = 0xC30;
                export const m_bSetNormal = 0xC4D;
                export const m_nAttribute = 0xC48;
                export const m_vecTraceDir = 0x4D8;
                export const m_bSetPXYZOnly = 0xC4C;
                export const m_bIncludeWater = 0xC44;
                export const m_bOffsetonColOnly = 0xC54;
                export const m_flMaxTraceLength = 0x360;
                export const m_nPreserveOffsetCP = 0xC5C;
                export const m_CollisionGroupName = 0xBB0;
                export const m_nTraceMissBehavior = 0xC40;
                export const m_flOffsetByRadiusFactor = 0xC58;
                export const m_nGroundNormalAttribute = 0xC50;
            }
            export namespace C_INIT_RandomVectorComponent {
                export const m_flMax = 0x1EC;
                export const m_flMin = 0x1E8;
                export const m_nComponent = 0x1F4;
                export const m_nFieldOutput = 0x1F0;
            }
            export namespace C_OP_ConstrainDistanceToPath {
                export const m_nFieldScale = 0x234;
                export const m_fMinDistance = 0x1E0;
                export const m_flTravelTime = 0x230;
                export const m_nManualTField = 0x238;
                export const m_PathParameters = 0x1F0;
                export const m_flMaxDistance0 = 0x1E4;
                export const m_flMaxDistance1 = 0x1EC;
                export const m_flMaxDistanceMid = 0x1E8;
            }
            export namespace C_OP_MovementRigidAttachToCP {
                export const m_nFieldInput = 0x1EC;
                export const m_bOffsetLocal = 0x1F4;
                export const m_nFieldOutput = 0x1F0;
                export const m_nScaleCPField = 0x1E8;
                export const m_nScaleControlPoint = 0x1E4;
                export const m_nControlPointNumber = 0x1E0;
            }
            export namespace C_OP_RemapBoundingVolumetoCP {
                export const m_flInputMax = 0x1F0;
                export const m_flInputMin = 0x1EC;
                export const m_flOutputMax = 0x1F8;
                export const m_flOutputMin = 0x1F4;
                export const m_nOutControlPointNumber = 0x1E8;
            }
            export namespace C_OP_RemapCPVelocityToVector {
                export const m_flScale = 0x1E8;
                export const m_bNormalize = 0x1EC;
                export const m_nFieldOutput = 0x1E4;
                export const m_nControlPoint = 0x1E0;
            }
            export namespace C_OP_RemapDotProductToScalar {
                export const m_nInputCP1 = 0x1E0;
                export const m_nInputCP2 = 0x1E4;
                export const m_flInputMax = 0x1F0;
                export const m_flInputMin = 0x1EC;
                export const m_nSetMethod = 0x200;
                export const m_flOutputMax = 0x1F8;
                export const m_flOutputMin = 0x1F4;
                export const m_bActiveRange = 0x204;
                export const m_nFieldOutput = 0x1E8;
                export const m_bUseParticleNormal = 0x205;
                export const m_bUseParticleVelocity = 0x1FC;
            }
            export namespace C_OP_RenderVolumetricEmitter {
                export const m_nType = 0x238;
                export const m_vecPos = 0x248;
                export const m_flSpeed = 0x16D0;
                export const m_flRadius = 0x1848;
                export const m_flDensity = 0x19C0;
                export const m_flFalloff = 0x2118;
                export const m_nEventType = 0x240;
                export const m_flMagnitude = 0x1CB0;
                export const m_vecVelocity = 0x920;
                export const m_flKillRadius = 0x1E28;
                export const m_flTemperature = 0x1B38;
                export const m_nCreationType = 0x23C;
                export const m_vPrevPosition = 0xFF8;
                export const m_strChannelType = 0x230;
                export const m_flKillDensityScale = 0x1FA0;
            }
            export namespace C_OP_SetControlPointRotation {
                export const m_nCP = 0xA38;
                export const m_nLocalCP = 0xA3C;
                export const m_flRotRate = 0x8C0;
                export const m_vecRotAxis = 0x1E8;
            }
            export namespace C_OP_SetControlPointToCenter {
                export const m_nCP1 = 0x1E8;
                export const m_vecCP1Pos = 0x1EC;
                export const m_nSetParent = 0x1FC;
                export const m_bUseAvgParticlePos = 0x1F8;
            }
            export namespace C_OP_SetControlPointToPlayer {
                export const m_nCP1 = 0x1E8;
                export const m_nPosition = 0x1FC;
                export const m_nRadiusCP = 0x200;
                export const m_vecCP1Pos = 0x1EC;
                export const m_bOrientToEyes = 0x1F8;
                export const m_nRadiusCPField = 0x204;
            }
            export namespace C_OP_SetPerChildControlPoint {
                export const m_nChildGroupID = 0x1E0;
                export const m_bSetOrientation = 0x4E0;
                export const m_nFirstSourcePoint = 0x368;
                export const m_nNumControlPoints = 0x1E8;
                export const m_nOrientationField = 0x4E4;
                export const m_nFirstControlPoint = 0x1E4;
                export const m_nParticleIncrement = 0x1F0;
                export const m_bNumBasedOnParticleCount = 0x4E8;
            }
            export namespace C_OP_ShapeMatchingConstraint {
                export const m_flShapeRestorationTime = 0x1E0;
            }
            export namespace FloatInputMaterialVariable_t {
                export const m_flInput = 0x8;
                export const m_strVariable = 0x0;
            }
            export namespace ParticleControlPointDriver_t {
                export const m_angOffset = 0x2C;
                export const m_vecOffset = 0x20;
                export const m_entityName = 0x38;
                export const m_iAttachType = 0x10;
                export const m_iControlPoint = 0x0;
                export const m_attachmentName = 0x18;
            }
            export namespace CPulseCell_BaseYieldingInflow {
                export const m_BaseFlow_WhileActive = 0x90;
                export const m_BaseFlow_OnAfterCancel = 0x48;
            }
            export namespace CPulseCell_BooleanSwitchState {
                export const m_WhenTrue = 0x168;
                export const m_Condition = 0xD8;
                export const m_WhenFalse = 0x1B0;
            }
            export namespace CPulseCell_IsRequirementValid {

            }
            export namespace C_INIT_CreateSequentialPathV2 {
                export const m_bLoop = 0x4D8;
                export const m_bCPPairs = 0x4D9;
                export const m_PathParams = 0x4E0;
                export const m_bSaveOffset = 0x4DA;
                export const m_fMaxDistance = 0x1E8;
                export const m_flNumToAssign = 0x360;
            }
            export namespace C_INIT_DistanceToNeighborCull {
                export const m_flModify = 0x4E8;
                export const m_flDistance = 0x1E8;
                export const m_nSetMethod = 0x660;
                export const m_bUseNeighbor = 0x664;
                export const m_nFieldModify = 0x4E0;
                export const m_bIncludeRadii = 0x360;
                export const m_flLifespanOverlap = 0x368;
            }
            export namespace C_INIT_RemapQAnglesToRotation {
                export const m_TransformInput = 0x1E8;
            }
            export namespace C_INIT_RemapTransformToVector {
                export const m_bOffset = 0x2FC;
                export const m_flEndTime = 0x2F4;
                export const m_vInputMax = 0x1F8;
                export const m_vInputMin = 0x1EC;
                export const m_nSetMethod = 0x2F8;
                export const m_vOutputMax = 0x210;
                export const m_vOutputMin = 0x204;
                export const m_bAccelerate = 0x2FD;
                export const m_flRemapBias = 0x300;
                export const m_flStartTime = 0x2F0;
                export const m_nFieldOutput = 0x1E8;
                export const m_TransformInput = 0x220;
                export const m_LocalSpaceTransform = 0x288;
            }
            export namespace C_OP_CalculateVectorAttribute {
                export const m_vStartValue = 0x1E0;
                export const m_nFieldInput1 = 0x1EC;
                export const m_nFieldInput2 = 0x1F4;
                export const m_nFieldOutput = 0x22C;
                export const m_flInputScale1 = 0x1F0;
                export const m_flInputScale2 = 0x1F8;
                export const m_vFinalOutputScale = 0x230;
                export const m_nControlPointInput1 = 0x1FC;
                export const m_nControlPointInput2 = 0x214;
                export const m_flControlPointScale1 = 0x210;
                export const m_flControlPointScale2 = 0x228;
            }
            export namespace C_OP_ExternalGameImpulseForce {
                export const m_bRopes = 0x368;
                export const m_bParticles = 0x36B;
                export const m_bExplosions = 0x36A;
                export const m_bRopesZOnly = 0x369;
                export const m_flForceScale = 0x1F0;
            }
            export namespace C_OP_MovementLoopInsideSphere {
                export const m_nCP = 0x1E0;
                export const m_vecScale = 0x360;
                export const m_flDistance = 0x1E8;
                export const m_nDistSqrAttr = 0xA38;
            }
            export namespace C_OP_ReinitializeScalarEndCap {
                export const m_flOutputMax = 0x1E8;
                export const m_flOutputMin = 0x1E4;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_RemapTransformToVelocity {
                export const m_TransformInput = 0x1E0;
            }
            export namespace C_OP_SetControlPointPositions {
                export const m_nCP1 = 0x1EC;
                export const m_nCP2 = 0x1F0;
                export const m_nCP3 = 0x1F4;
                export const m_nCP4 = 0x1F8;
                export const m_bOrient = 0x1E9;
                export const m_bSetOnce = 0x1EA;
                export const m_vecCP1Pos = 0x1FC;
                export const m_vecCP2Pos = 0x208;
                export const m_vecCP3Pos = 0x214;
                export const m_vecCP4Pos = 0x220;
                export const m_nHeadLocation = 0x22C;
                export const m_bUseWorldLocation = 0x1E8;
            }
            export namespace C_OP_SnapshotRigidSkinToBones {
                export const m_bTransformRadii = 0x1E1;
                export const m_bTransformNormals = 0x1E0;
                export const m_nControlPointNumber = 0x1E4;
            }
            export namespace C_OP_SpringToVectorConstraint {
                export const m_flRestLength = 0x1E0;
                export const m_flMaxDistance = 0x4D0;
                export const m_flMinDistance = 0x358;
                export const m_flRestingLength = 0x648;
                export const m_vecAnchorVector = 0x7C0;
            }
            export namespace CPulseCell_Inflow_EventHandler {
                export const m_EventName = 0x80;
            }
            export namespace CPulseCell_Outflow_CycleRandom {
                export const m_Outputs = 0x48;
            }
            export namespace C_INIT_RandomNamedModelElement {
                export const m_names = 0x1F0;
                export const m_hModel = 0x1E8;
                export const m_bLinear = 0x209;
                export const m_bShuffle = 0x208;
                export const m_nFieldOutput = 0x20C;
                export const m_bModelFromRenderer = 0x20A;
            }
            export namespace C_OP_DirectionBetweenVecsToVec {
                export const m_vecPoint1 = 0x1E8;
                export const m_vecPoint2 = 0x8C0;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_DistanceBetweenTransforms {
                export const m_bLOS = 0x924;
                export const m_nTraceSet = 0x920;
                export const m_flInputMax = 0x430;
                export const m_flInputMin = 0x2B8;
                export const m_flLOSScale = 0x89C;
                export const m_nSetMethod = 0x928;
                export const m_flOutputMax = 0x720;
                export const m_flOutputMin = 0x5A8;
                export const m_TransformEnd = 0x250;
                export const m_nFieldOutput = 0x1E0;
                export const m_TransformStart = 0x1E8;
                export const m_flMaxTraceLength = 0x898;
                export const m_CollisionGroupName = 0x8A0;
            }
            export namespace C_OP_LockToSavedSequentialPath {
                export const m_bCPPairs = 0x1EC;
                export const m_flFadeEnd = 0x1E8;
                export const m_PathParams = 0x1F0;
                export const m_flFadeStart = 0x1E4;
            }
            export namespace C_OP_PointVectorAtNextParticle {
                export const m_bPrevious = 0x360;
                export const m_nFieldOutput = 0x1E0;
                export const m_flInterpolation = 0x1E8;
            }
            export namespace C_OP_RenderStatusEffectCitadel {
                export const m_pTextureDetail = 0x258;
                export const m_pTextureNormal = 0x238;
                export const m_pTextureColorWarp = 0x230;
                export const m_pTextureMetalness = 0x240;
                export const m_pTextureRoughness = 0x248;
                export const m_pTextureSelfIllum = 0x250;
            }
            export namespace C_OP_RepeatedTriggerChildGroup {
                export const m_flClusterSize = 0x368;
                export const m_nChildGroupID = 0x1E8;
                export const m_bLimitChildCount = 0x658;
                export const m_flClusterCooldown = 0x4E0;
                export const m_flClusterRefireTime = 0x1F0;
            }
            export namespace C_OP_ScreenSpaceDistanceToEdge {
                export const m_nSetMethod = 0x4D8;
                export const m_nFieldOutput = 0x1E0;
                export const m_flOutputRemap = 0x360;
                export const m_flMaxDistFromEdge = 0x1E8;
            }
            export namespace C_OP_SelectivelyEnableChildren {
                export const m_nFirstChild = 0x360;
                export const m_nChildGroupID = 0x1E8;
                export const m_bPlayEndcapOnStop = 0x650;
                export const m_bDestroyImmediately = 0x651;
                export const m_nNumChildrenToEnable = 0x4D8;
            }
            export namespace CPulseCell_Outflow_CycleOrdered {
                export const m_Outputs = 0x48;
            }
            export namespace C_INIT_InitialRepulsionVelocity {
                export const m_bInherit = 0x291;
                export const m_nChildCP = 0x294;
                export const m_nTraceSet = 0x268;
                export const m_bTranslate = 0x289;
                export const m_bPerParticle = 0x288;
                export const m_vecOutputMax = 0x278;
                export const m_vecOutputMin = 0x26C;
                export const m_bProportional = 0x28A;
                export const m_flTraceLength = 0x28C;
                export const m_nChildGroupID = 0x298;
                export const m_bPerParticleTR = 0x290;
                export const m_CollisionGroupName = 0x1E8;
                export const m_nControlPointNumber = 0x284;
            }
            export namespace C_INIT_InitialSequenceFromModel {
                export const m_flInputMax = 0x1F8;
                export const m_flInputMin = 0x1F4;
                export const m_nSetMethod = 0x204;
                export const m_flOutputMax = 0x200;
                export const m_flOutputMin = 0x1FC;
                export const m_nFieldOutput = 0x1EC;
                export const m_nFieldOutputAnim = 0x1F0;
                export const m_nControlPointNumber = 0x1E8;
            }
            export namespace C_INIT_RandomNamedModelBodyPart {

            }
            export namespace C_INIT_RandomNamedModelSequence {

            }
            export namespace C_OP_CollideWithParentParticles {
                export const m_flRadiusScale = 0x358;
                export const m_flParentRadiusScale = 0x1E0;
            }
            export namespace C_OP_DifferencePreviousParticle {
                export const m_flInputMax = 0x1EC;
                export const m_flInputMin = 0x1E8;
                export const m_nSetMethod = 0x1F8;
                export const m_flOutputMax = 0x1F4;
                export const m_flOutputMin = 0x1F0;
                export const m_nFieldInput = 0x1E0;
                export const m_bActiveRange = 0x1FC;
                export const m_nFieldOutput = 0x1E4;
                export const m_bSetPreviousParticle = 0x1FD;
            }
            export namespace C_OP_InheritFromParentParticles {
                export const m_flScale = 0x1E0;
                export const m_nIncrement = 0x1E8;
                export const m_nFieldOutput = 0x1E4;
                export const m_bRandomDistribution = 0x1EC;
            }
            export namespace C_OP_LightningSnapshotGenerator {
                export const m_flOffset = 0x370;
                export const m_flUVScale = 0x7D8;
                export const m_nCPEndPnt = 0x1F0;
                export const m_flSegments = 0x1F8;
                export const m_flUVOffset = 0x950;
                export const m_flRadiusEnd = 0x13B0;
                export const m_flSplitRate = 0xAC8;
                export const m_nCPSnapshot = 0x1E8;
                export const m_nCPStartPnt = 0x1EC;
                export const m_flRecalcRate = 0x660;
                export const m_flBranchTwist = 0x10B8;
                export const m_flOffsetDecay = 0x4E8;
                export const m_flRadiusStart = 0x1238;
                export const m_flDedicatedPool = 0x1528;
                export const m_nBranchBehavior = 0x1230;
                export const m_bScaleBranchOffset = 0xF38;
                export const m_flBranchOffsetScale = 0xF40;
                export const m_bScaleBranchDistance = 0xDB8;
                export const m_flBranchDistanceScale = 0xDC0;
                export const m_flRecursionSplitScale = 0xC40;
            }
            export namespace C_OP_RemapDirectionToCPToVector {
                export const m_nCP = 0x1E0;
                export const m_flScale = 0x1E8;
                export const m_bNormalize = 0x1FC;
                export const m_flOffsetRot = 0x1EC;
                export const m_nFieldOutput = 0x1E4;
                export const m_vecOffsetAxis = 0x1F0;
                export const m_nFieldStrength = 0x200;
            }
            export namespace C_OP_RemapParticleCountToScalar {
                export const m_nInputMax = 0x360;
                export const m_nInputMin = 0x1E8;
                export const m_nSetMethod = 0x7CC;
                export const m_flOutputMax = 0x650;
                export const m_flOutputMin = 0x4D8;
                export const m_bActiveRange = 0x7C8;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_RenderClientPhysicsImpulse {
                export const m_flRadius = 0x230;
                export const m_flMagnitude = 0x3A8;
                export const m_nSimIdFilter = 0x520;
            }
            export namespace C_OP_RenderScreenVelocityRotate {
                export const m_flForwardDegrees = 0x234;
                export const m_flRotateRateDegrees = 0x230;
            }
            export namespace C_OP_SetControlPointOrientation {
                export const m_nCP = 0x1EC;
                export const m_bSetOnce = 0x1EB;
                export const m_bRandomize = 0x1EA;
                export const m_vecRotation = 0x1F4;
                export const m_vecRotationB = 0x200;
                export const m_nHeadLocation = 0x1F0;
                export const m_flInterpolation = 0x210;
                export const m_bUseWorldLocation = 0x1E8;
            }
            export namespace C_OP_SetControlPointsToParticle {
                export const m_bReverse = 0x1F0;
                export const m_nSetParent = 0x1F8;
                export const m_nChildGroupID = 0x1E0;
                export const m_bSetOrientation = 0x1F1;
                export const m_nOrientationMode = 0x1F4;
                export const m_nFirstSourcePoint = 0x1EC;
                export const m_nNumControlPoints = 0x1E8;
                export const m_nFirstControlPoint = 0x1E4;
            }
            export namespace PointDefinitionWithTimeValues_t {
                export const m_flTimeDuration = 0x14;
            }
            export namespace CPulseCell_Inflow_BaseEntrypoint {
                export const m_EntryChunk = 0x48;
                export const m_RegisterMap = 0x50;
            }
            export namespace CPulseCell_Outflow_CycleShuffled {
                export const m_Outputs = 0x48;
            }
            export namespace CPulseCell_WaitForCursorsWithTag {
                export const m_bTagSelfWhenComplete = 0x128;
                export const m_nDesiredKillPriority = 0x12C;
            }
            export namespace CRandomNumberGeneratorParameters {
                export const m_nSeed = 0x4;
                export const m_bDistributeEvenly = 0x0;
            }
            export namespace C_INIT_CreateFromParentParticles {
                export const m_bSubFrame = 0x1F8;
                export const m_flIncrement = 0x1EC;
                export const m_nRandomSeed = 0x1F4;
                export const m_flVelocityScale = 0x1E8;
                export const m_bSetRopeSegmentID = 0x1F9;
                export const m_bRandomDistribution = 0x1F0;
            }
            export namespace C_INIT_InitialVelocityFromHitbox {
                export const m_bUseBones = 0x274;
                export const m_HitboxSetName = 0x1F4;
                export const m_flVelocityMax = 0x1EC;
                export const m_flVelocityMin = 0x1E8;
                export const m_nControlPointNumber = 0x1F0;
            }
            export namespace C_INIT_RandomNamedModelMeshGroup {

            }
            export namespace C_OP_ChooseRandomChildrenInGroup {
                export const m_nChildGroupID = 0x1E8;
                export const m_flNumberOfChildren = 0x1F0;
            }
            export namespace C_OP_DriveCPFromGlobalSoundFloat {
                export const m_FieldName = 0x210;
                export const m_StackName = 0x200;
                export const m_flInputMax = 0x1F4;
                export const m_flInputMin = 0x1F0;
                export const m_flOutputMax = 0x1FC;
                export const m_flOutputMin = 0x1F8;
                export const m_OperatorName = 0x208;
                export const m_nOutputField = 0x1EC;
                export const m_nOutputControlPoint = 0x1E8;
            }
            export namespace C_OP_ForceBasedOnDistanceToPlane {
                export const m_flMaxDist = 0x200;
                export const m_flMinDist = 0x1F0;
                export const m_flExponent = 0x220;
                export const m_vecPlaneNormal = 0x210;
                export const m_vecForceAtMaxDist = 0x204;
                export const m_vecForceAtMinDist = 0x1F4;
                export const m_nControlPointNumber = 0x21C;
            }
            export namespace C_OP_LockToSavedSequentialPathV2 {
                export const m_bCPPairs = 0x1E8;
                export const m_flFadeEnd = 0x1E4;
                export const m_PathParams = 0x1F0;
                export const m_flFadeStart = 0x1E0;
            }
            export namespace C_OP_PercentageBetweenTransforms {
                export const m_flInputMax = 0x1E8;
                export const m_flInputMin = 0x1E4;
                export const m_nSetMethod = 0x2C8;
                export const m_flOutputMax = 0x1F0;
                export const m_flOutputMin = 0x1EC;
                export const m_TransformEnd = 0x260;
                export const m_bActiveRange = 0x2CC;
                export const m_bRadialCheck = 0x2CD;
                export const m_nFieldOutput = 0x1E0;
                export const m_TransformStart = 0x1F8;
            }
            export namespace C_OP_ReadFromNeighboringParticle {
                export const m_nIncrement = 0x1E8;
                export const m_nFieldInput = 0x1E0;
                export const m_nFieldOutput = 0x1E4;
                export const m_DistanceCheck = 0x1F0;
                export const m_flInterpolation = 0x368;
            }
            export namespace C_OP_RemapAverageHitboxSpeedtoCP {
                export const m_nField = 0x1F0;
                export const m_flInputMax = 0x370;
                export const m_flInputMin = 0x1F8;
                export const m_flOutputMax = 0x660;
                export const m_flOutputMin = 0x4E8;
                export const m_HitboxSetName = 0xEB8;
                export const m_nHitboxDataType = 0x1F4;
                export const m_nInControlPointNumber = 0x1E8;
                export const m_vecComparisonVelocity = 0x7E0;
                export const m_nOutControlPointNumber = 0x1EC;
                export const m_nHeightControlPointNumber = 0x7D8;
            }
            export namespace C_OP_RemapAverageScalarValuetoCP {
                export const m_nField = 0x370;
                export const m_nExpression = 0x1E8;
                export const m_flOutputRemap = 0x378;
                export const m_flDecimalPlaces = 0x1F0;
                export const m_nOutVectorField = 0x36C;
                export const m_nOutControlPointNumber = 0x368;
            }
            export namespace C_OP_RenderSimpleModelCollection {
                export const m_hModel = 0x238;
                export const m_modelInput = 0x240;
                export const m_fDrawFilter = 0x420;
                export const m_bCenterOffset = 0x230;
                export const m_bAcceptsDecals = 0x41A;
                export const m_fSizeCullScale = 0x2A0;
                export const m_bDisableShadows = 0x418;
                export const m_bDisableMotionBlur = 0x419;
                export const m_nAngularVelocityField = 0x598;
            }
            export namespace C_OP_ScreenSpacePositionOfTarget {
                export const m_bOututBehindness = 0x8B8;
                export const m_nBehindSetMethod = 0xA38;
                export const m_vecTargetPosition = 0x1E0;
                export const m_nBehindFieldOutput = 0x8BC;
                export const m_flBehindOutputRemap = 0x8C0;
            }
            export namespace C_OP_SetCPOrientationToDirection {
                export const m_nInputControlPoint = 0x1E0;
                export const m_nOutputControlPoint = 0x1E4;
            }
            export namespace C_OP_SetCPOrientationToPointAtCP {
                export const m_nInputCP = 0x1E8;
                export const m_nOutputCP = 0x1EC;
                export const m_bPointAway = 0x36A;
                export const m_b2DOrientation = 0x368;
                export const m_flInterpolation = 0x1F0;
                export const m_bAvoidSingularity = 0x369;
            }
            export namespace C_OP_SetControlPointFieldToWater {
                export const m_nDestCP = 0x1EC;
                export const m_nCPField = 0x1F0;
                export const m_nSourceCP = 0x1E8;
            }
            export namespace C_OP_SetControlPointToCPVelocity {
                export const m_nCPField = 0x1F8;
                export const m_nCPInput = 0x1E8;
                export const m_bNormalize = 0x1F0;
                export const m_nCPOutputMag = 0x1F4;
                export const m_nCPOutputVel = 0x1EC;
                export const m_vecComparisonVelocity = 0x200;
            }
            export namespace CPulseCell_InlineNodeSkipSelector {
                export const m_bAnd = 0x4C;
                export const m_FailOutflow = 0x68;
                export const m_PassOutflow = 0x50;
                export const m_nFlowNodeID = 0x48;
            }
            export namespace CPulseCell_LimitCount__Criteria_t {
                export const m_bLimitCountPasses = 0x0;
            }
            export namespace C_INIT_InheritFromParentParticles {
                export const m_flScale = 0x1E8;
                export const m_nIncrement = 0x1F0;
                export const m_nRandomSeed = 0x1F8;
                export const m_nFieldOutput = 0x1EC;
                export const m_bRandomDistribution = 0x1F4;
            }
            export namespace C_INIT_RandomAlphaWindowThreshold {
                export const m_flMax = 0x1EC;
                export const m_flMin = 0x1E8;
                export const m_flExponent = 0x1F0;
            }
            export namespace C_INIT_RemapParticleCountToScalar {
                export const m_bWrap = 0x20A;
                export const m_bInvert = 0x209;
                export const m_nInputMax = 0x1F0;
                export const m_nInputMin = 0x1EC;
                export const m_nSetMethod = 0x204;
                export const m_flOutputMax = 0x200;
                export const m_flOutputMin = 0x1FC;
                export const m_flRemapBias = 0x20C;
                export const m_bActiveRange = 0x208;
                export const m_nFieldOutput = 0x1E8;
                export const m_nScaleControlPoint = 0x1F4;
                export const m_nScaleControlPointField = 0x1F8;
            }
            export namespace C_OP_CreateParticleSystemRenderer {
                export const m_vecCPs = 0x240;
                export const m_hEffect = 0x230;
                export const m_nEventType = 0x238;
                export const m_AggregationPos = 0x258;
                export const m_szParticleConfig = 0x250;
            }
            export namespace C_OP_InheritFromParentParticlesV2 {
                export const m_flScale = 0x1E0;
                export const m_bReverse = 0x4DA;
                export const m_bSubSample = 0x4D8;
                export const m_nIncrement = 0x360;
                export const m_nFieldOutput = 0x358;
                export const m_flInterpolation = 0x4E0;
                export const m_bRandomDistribution = 0x4D9;
                export const m_nMissingParentBehavior = 0x4DC;
            }
            export namespace C_OP_RemapNamedModelElementEndCap {
                export const m_hModel = 0x1E0;
                export const m_inNames = 0x1E8;
                export const m_outNames = 0x200;
                export const m_nFieldInput = 0x234;
                export const m_nFieldOutput = 0x238;
                export const m_fallbackNames = 0x218;
                export const m_bModelFromRenderer = 0x230;
            }
            export namespace C_OP_RemapVectorComponentToScalar {
                export const m_nComponent = 0x1E8;
                export const m_nFieldInput = 0x1E0;
                export const m_nFieldOutput = 0x1E4;
            }
            export namespace C_OP_SetControlPointToImpactPoint {
                export const m_nCPIn = 0x1EC;
                export const m_nCPOut = 0x1E8;
                export const m_flOffset = 0x374;
                export const m_nTraceSet = 0x404;
                export const m_vecTraceDir = 0x378;
                export const m_flUpdateRate = 0x1F0;
                export const m_bIncludeWater = 0x40A;
                export const m_flStartOffset = 0x370;
                export const m_flTraceLength = 0x1F8;
                export const m_bSetToEndpoint = 0x408;
                export const m_CollisionGroupName = 0x384;
                export const m_bTraceToClosestSurface = 0x409;
            }
            export namespace CParticleCollectionBindingInstance {

            }
            export namespace CParticleMassCalculationParameters {
                export const m_flScale = 0x2F8;
                export const m_flRadius = 0x8;
                export const m_nMassMode = 0x0;
                export const m_flNominalRadius = 0x180;
            }
            export namespace CPulseCell_BaseLerp__CursorState_t {
                export const m_EndTime = 0x4;
                export const m_StartTime = 0x0;
            }
            export namespace CPulseCell_Inflow_EntOutputHandler {
                export const m_SourceEntity = 0x80;
                export const m_SourceOutput = 0x90;
                export const m_ExpectedParamType = 0xA0;
            }
            export namespace CPulseCell_PickBestOutflowSelector {
                export const m_nCheckType = 0x48;
                export const m_OutflowList = 0x50;
            }
            export namespace CPulseCell_Step_CallExternalMethod {
                export const m_MethodName = 0xD8;
                export const m_OnFinished = 0x108;
                export const m_ExpectedArgs = 0xF0;
                export const m_nAsyncCallMode = 0x100;
                export const m_nBlackboardIndex = 0xE8;
            }
            export namespace C_INIT_CreateWithinSphereTransform {
                export const m_fSpeedMax = 0xDA0;
                export const m_fSpeedMin = 0xC28;
                export const m_fRadiusMax = 0x360;
                export const m_fRadiusMin = 0x1E8;
                export const m_bLocalCoords = 0xF1C;
                export const m_nFieldOutput = 0x1CD0;
                export const m_fSpeedRandExp = 0xF18;
                export const m_TransformInput = 0xBC0;
                export const m_nFieldVelocity = 0x1CD4;
                export const m_vecDistanceBias = 0x4D8;
                export const m_vecDistanceBiasAbs = 0xBB0;
                export const m_LocalCoordinateSystemSpeedMax = 0x15F8;
                export const m_LocalCoordinateSystemSpeedMin = 0xF20;
            }
            export namespace C_INIT_InitFromVectorFieldSnapshot {
                export const m_vecScale = 0x1F8;
                export const m_nLocalSpaceCP = 0x1EC;
                export const m_nWeightUpdateCP = 0x1F0;
                export const m_nControlPointNumber = 0x1E8;
                export const m_bUseVerticalVelocity = 0x1F4;
            }
            export namespace C_INIT_ScreenSpacePositionOfTarget {
                export const m_bOututBehindness = 0x8C0;
                export const m_vecTargetPosition = 0x1E8;
                export const m_nBehindFieldOutput = 0x8C4;
                export const m_flBehindOutputRemap = 0x8C8;
            }
            export namespace C_OP_ModelSurfaceSnapshotGenerator {
                export const m_bSetUV = 0x833;
                export const m_bSetUp = 0x831;
                export const m_bSetNormal = 0x830;
                export const m_flUSpacing = 0x3C8;
                export const m_flVSpacing = 0x540;
                export const m_modelInput = 0x1F0;
                export const m_bSetGravity = 0x832;
                export const m_nCPSnapshot = 0x1E8;
                export const m_flRecalcRate = 0x250;
                export const m_flSurfaceOffset = 0x6B8;
            }
            export namespace C_OP_RemapNamedModelBodyPartEndCap {

            }
            export namespace C_OP_RemapNamedModelSequenceEndCap {

            }
            export namespace C_OP_ScreenSpaceRotateTowardTarget {
                export const m_nSetMethod = 0xA30;
                export const m_flOutputRemap = 0x8B8;
                export const m_vecTargetPosition = 0x1E0;
                export const m_flScreenEdgeAlignmentDistance = 0xA38;
            }
            export namespace C_OP_SetControlPointToWaterSurface {
                export const m_nDestCP = 0x1EC;
                export const m_nFlowCP = 0x1F0;
                export const m_nActiveCP = 0x1F4;
                export const m_nSourceCP = 0x1E8;
                export const m_flRetestRate = 0x200;
                export const m_nActiveCPField = 0x1F8;
                export const m_bAdaptiveThreshold = 0x378;
            }
            export namespace C_OP_SetRandomControlPointPosition {
                export const m_nCP1 = 0x1EC;
                export const m_bOrient = 0x1E9;
                export const m_vecCPMaxPos = 0x37C;
                export const m_vecCPMinPos = 0x370;
                export const m_nHeadLocation = 0x1F0;
                export const m_flReRandomRate = 0x1F8;
                export const m_flInterpolation = 0x388;
                export const m_bUseWorldLocation = 0x1E8;
            }
            export namespace C_OP_SetSingleControlPointPosition {
                export const m_nCP1 = 0x1EC;
                export const m_bSetOnce = 0x1E8;
                export const m_vecCP1Pos = 0x1F0;
                export const m_transformInput = 0x8C8;
            }
            export namespace C_INIT_CreateWithinCapsuleTransform {
                export const m_fHeight = 0x4D8;
                export const m_fSpeedMax = 0x830;
                export const m_fSpeedMin = 0x6B8;
                export const m_fRadiusMax = 0x360;
                export const m_fRadiusMin = 0x1E8;
                export const m_nFieldOutput = 0x1760;
                export const m_fSpeedRandExp = 0x9A8;
                export const m_TransformInput = 0x650;
                export const m_nFieldVelocity = 0x1764;
                export const m_LocalCoordinateSystemSpeedMax = 0x1088;
                export const m_LocalCoordinateSystemSpeedMin = 0x9B0;
            }
            export namespace C_INIT_RemapInitialVisibilityScalar {
                export const m_flInputMax = 0x1F4;
                export const m_flInputMin = 0x1F0;
                export const m_flOutputMax = 0x1FC;
                export const m_flOutputMin = 0x1F8;
                export const m_nFieldOutput = 0x1EC;
            }
            export namespace C_OP_CPOffsetToPercentageBetweenCPs {
                export const m_nEndCP = 0x1F0;
                export const m_nInputCP = 0x1FC;
                export const m_nOuputCP = 0x1F8;
                export const m_nStartCP = 0x1EC;
                export const m_nOffsetCP = 0x1F4;
                export const m_vecOffset = 0x204;
                export const m_flInputMax = 0x1E4;
                export const m_flInputMin = 0x1E0;
                export const m_flInputBias = 0x1E8;
                export const m_bRadialCheck = 0x200;
                export const m_bScaleOffset = 0x201;
            }
            export namespace C_OP_ConnectParentParticleToNearest {
                export const m_bUseRadius = 0x1E8;
                export const m_flRadiusScale = 0x1F0;
                export const m_nFirstControlPoint = 0x1E0;
                export const m_flParentRadiusScale = 0x368;
                export const m_nSecondControlPoint = 0x1E4;
            }
            export namespace C_OP_CylindricalDistanceToTransform {
                export const m_bCapsule = 0x89E;
                export const m_bAdditive = 0x89D;
                export const m_flInputMax = 0x360;
                export const m_flInputMin = 0x1E8;
                export const m_nSetMethod = 0x898;
                export const m_flOutputMax = 0x650;
                export const m_flOutputMin = 0x4D8;
                export const m_TransformEnd = 0x830;
                export const m_bActiveRange = 0x89C;
                export const m_nFieldOutput = 0x1E0;
                export const m_TransformStart = 0x7C8;
            }
            export namespace C_OP_PinRopeSegmentParticleToParent {
                export const m_flInterpolation = 0x360;
                export const m_nParticleNumber = 0x1E8;
                export const m_nParticleSelection = 0x1E0;
            }
            export namespace C_OP_RemapDistanceToLineSegmentBase {
                export const m_nCP0 = 0x1E0;
                export const m_nCP1 = 0x1E4;
                export const m_bInfiniteLine = 0x1F0;
                export const m_flMaxInputValue = 0x1EC;
                export const m_flMinInputValue = 0x1E8;
            }
            export namespace C_OP_RemapNamedModelMeshGroupEndCap {

            }
            export namespace C_OP_RemapTransformOrientationToYaw {
                export const m_flRotOffset = 0x24C;
                export const m_nFieldOutput = 0x248;
                export const m_TransformInput = 0x1E0;
                export const m_flSpinStrength = 0x250;
            }
            export namespace C_OP_SetAttributeToScalarExpression {
                export const m_flInput1 = 0x1E8;
                export const m_flInput2 = 0x360;
                export const m_nSetMethod = 0x654;
                export const m_nExpression = 0x1E0;
                export const m_nOutputField = 0x650;
                export const m_flOutputRemap = 0x4D8;
            }
            export namespace C_OP_SetCPOrientationToGroundNormal {
                export const m_nInputCP = 0x274;
                export const m_nOutputCP = 0x278;
                export const m_nTraceSet = 0x270;
                export const m_flTolerance = 0x1E8;
                export const m_flInterpRate = 0x1E0;
                export const m_bIncludeWater = 0x288;
                export const m_flTraceOffset = 0x1EC;
                export const m_flMaxTraceLength = 0x1E4;
                export const m_CollisionGroupName = 0x1F0;
            }
            export namespace C_OP_SetControlPointFromObjectScale {
                export const m_nCPInput = 0x1E8;
                export const m_nCPOutput = 0x1EC;
            }
            export namespace ParticleControlPointConfiguration_t {
                export const m_name = 0x0;
                export const m_drivers = 0x8;
                export const m_previewState = 0x20;
            }
            export namespace CPulseCell_Timeline__TimelineEvent_t {
                export const m_EventOutflow = 0x8;
                export const m_flTimeFromPrevious = 0x0;
            }
            export namespace CPulseCell_WaitForCursorsWithTagBase {
                export const m_WaitComplete = 0xE0;
                export const m_nCursorsAllowedToWait = 0xD8;
            }
            export namespace C_OP_ControlPointToRadialScreenSpace {
                export const m_nCPIn = 0x1E8;
                export const m_nCPOut = 0x1F8;
                export const m_vecCP1Pos = 0x1EC;
                export const m_nCPOutField = 0x1FC;
                export const m_nCPSSPosOut = 0x200;
            }
            export namespace C_OP_RemapNamedModelElementOnceTimed {
                export const m_hModel = 0x1E0;
                export const m_inNames = 0x1E8;
                export const m_outNames = 0x200;
                export const m_flRemapTime = 0x23C;
                export const m_nFieldInput = 0x234;
                export const m_nFieldOutput = 0x238;
                export const m_bProportional = 0x231;
                export const m_fallbackNames = 0x218;
                export const m_bModelFromRenderer = 0x230;
            }
            export namespace C_OP_SetParentControlPointsToChildCP {
                export const m_nChildGroupID = 0x1E8;
                export const m_bSetOrientation = 0x1F8;
                export const m_nFirstSourcePoint = 0x1F4;
                export const m_nNumControlPoints = 0x1F0;
                export const m_nChildControlPoint = 0x1EC;
            }
            export namespace C_INIT_RemapNamedModelElementToScalar {
                export const m_names = 0x1F0;
                export const m_hModel = 0x1E8;
                export const m_values = 0x208;
                export const m_nSetMethod = 0x228;
                export const m_nFieldInput = 0x220;
                export const m_nFieldOutput = 0x224;
                export const m_bModelFromRenderer = 0x22C;
            }
            export namespace C_INIT_SetAttributeToScalarExpression {
                export const m_flInput1 = 0x1F0;
                export const m_flInput2 = 0x368;
                export const m_nSetMethod = 0x65C;
                export const m_nExpression = 0x1E8;
                export const m_nOutputField = 0x658;
                export const m_flOutputRemap = 0x4E0;
            }
            export namespace C_OP_MovementRotateParticleAroundAxis {
                export const m_flRotRate = 0x8B8;
                export const m_vecRotAxis = 0x1E0;
                export const m_bLocalSpace = 0xA98;
                export const m_TransformInput = 0xA30;
            }
            export namespace C_OP_RemapNamedModelBodyPartOnceTimed {

            }
            export namespace C_OP_RemapNamedModelSequenceOnceTimed {

            }
            export namespace C_OP_RemapParticleCountOnScalarEndCap {
                export const m_nInputMax = 0x1E8;
                export const m_nInputMin = 0x1E4;
                export const m_bBackwards = 0x1F4;
                export const m_nSetMethod = 0x1F8;
                export const m_flOutputMax = 0x1F0;
                export const m_flOutputMin = 0x1EC;
                export const m_nFieldOutput = 0x1E0;
            }
            export namespace C_OP_RemapTransformVisibilityToScalar {
                export const m_flRadius = 0x264;
                export const m_flInputMax = 0x258;
                export const m_flInputMin = 0x254;
                export const m_nSetMethod = 0x1E0;
                export const m_flOutputMax = 0x260;
                export const m_flOutputMin = 0x25C;
                export const m_nFieldOutput = 0x250;
                export const m_TransformInput = 0x1E8;
            }
            export namespace C_OP_RemapTransformVisibilityToVector {
                export const m_flRadius = 0x274;
                export const m_flInputMax = 0x258;
                export const m_flInputMin = 0x254;
                export const m_nSetMethod = 0x1E0;
                export const m_nFieldOutput = 0x250;
                export const m_vecOutputMax = 0x268;
                export const m_vecOutputMin = 0x25C;
                export const m_TransformInput = 0x1E8;
            }
            export namespace C_OP_SetControlPointsToModelParticles {
                export const m_bSkin = 0x2EC;
                export const m_bAttachment = 0x2ED;
                export const m_HitboxSetName = 0x1E0;
                export const m_AttachmentName = 0x260;
                export const m_nFirstSourcePoint = 0x2E8;
                export const m_nNumControlPoints = 0x2E4;
                export const m_nFirstControlPoint = 0x2E0;
            }
            export namespace CPulseCell_LimitCount__InstanceState_t {
                export const m_nCurrentCount = 0x0;
            }
            export namespace C_INIT_RemapNamedModelBodyPartToScalar {

            }
            export namespace C_INIT_RemapNamedModelSequenceToScalar {

            }
            export namespace C_OP_PercentageBetweenTransformLerpCPs {
                export const m_flInputMax = 0x1E8;
                export const m_flInputMin = 0x1E4;
                export const m_nSetMethod = 0x2D0;
                export const m_TransformEnd = 0x258;
                export const m_bActiveRange = 0x2D4;
                export const m_bRadialCheck = 0x2D5;
                export const m_nFieldOutput = 0x1E0;
                export const m_nOutputEndCP = 0x2C8;
                export const m_TransformStart = 0x1F0;
                export const m_nOutputStartCP = 0x2C0;
                export const m_nOutputEndField = 0x2CC;
                export const m_nOutputStartField = 0x2C4;
            }
            export namespace C_OP_PercentageBetweenTransformsVector {
                export const m_flInputMax = 0x1E8;
                export const m_flInputMin = 0x1E4;
                export const m_nSetMethod = 0x2D8;
                export const m_TransformEnd = 0x270;
                export const m_bActiveRange = 0x2DC;
                export const m_bRadialCheck = 0x2DD;
                export const m_nFieldOutput = 0x1E0;
                export const m_vecOutputMax = 0x1F8;
                export const m_vecOutputMin = 0x1EC;
                export const m_TransformStart = 0x208;
            }
            export namespace C_OP_RemapNamedModelMeshGroupOnceTimed {

            }
            export namespace C_OP_SetControlPointToVectorExpression {
                export const m_flLerp = 0xFA0;
                export const m_vInput1 = 0x1F0;
                export const m_vInput2 = 0x8C8;
                export const m_nOutputCP = 0x1EC;
                export const m_nExpression = 0x1E8;
                export const m_bNormalizedOutput = 0x1118;
            }
            export namespace CPulseCell_IntervalTimer__CursorState_t {
                export const m_EndTime = 0x4;
                export const m_StartTime = 0x0;
                export const m_flWaitInterval = 0x8;
                export const m_flWaitIntervalHigh = 0xC;
                export const m_bCompleteOnNextWake = 0x10;
            }
            export namespace C_INIT_RemapNamedModelMeshGroupToScalar {

            }
            export namespace C_OP_MovementMoveAlongSkinnedCPSnapshot {
                export const m_flTValue = 0x368;
                export const m_bSetNormal = 0x1E8;
                export const m_bSetRadius = 0x1E9;
                export const m_flInterpolation = 0x1F0;
                export const m_nControlPointNumber = 0x1E0;
                export const m_nSnapshotControlPointNumber = 0x1E4;
            }
            export namespace C_OP_RemapControlPointDirectionToVector {
                export const m_flScale = 0x1E4;
                export const m_nFieldOutput = 0x1E0;
                export const m_nControlPointNumber = 0x1E8;
            }
            export namespace C_OP_RemapDistanceToLineSegmentToScalar {
                export const m_nFieldOutput = 0x1F8;
                export const m_flMaxOutputValue = 0x200;
                export const m_flMinOutputValue = 0x1FC;
            }
            export namespace C_OP_RemapDistanceToLineSegmentToVector {
                export const m_nFieldOutput = 0x1F8;
                export const m_vMaxOutputValue = 0x208;
                export const m_vMinOutputValue = 0x1FC;
            }
            export namespace C_INIT_InitSkinnedPositionFromCPSnapshot {
                export const m_bRigid = 0x1F8;
                export const m_bRandom = 0x1F0;
                export const m_bIgnoreDt = 0x1FA;
                export const m_bCopyAlpha = 0x395;
                export const m_bCopyColor = 0x394;
                export const m_bSetNormal = 0x1F9;
                export const m_bSetRadius = 0x396;
                export const m_nIndexType = 0x204;
                export const m_flIncrement = 0x380;
                export const m_flReadIndex = 0x208;
                export const m_nRandomSeed = 0x1F4;
                export const m_flBoneVelocity = 0x38C;
                export const m_flBoneVelocityMax = 0x390;
                export const m_nFullLoopIncrement = 0x384;
                export const m_flMaxNormalVelocity = 0x200;
                export const m_flMinNormalVelocity = 0x1FC;
                export const m_nControlPointNumber = 0x1EC;
                export const m_nSnapShotStartPoint = 0x388;
                export const m_nSnapshotControlPointNumber = 0x1E8;
            }
            export namespace C_OP_SetFloatAttributeToVectorExpression {
                export const m_vInput1 = 0x1E8;
                export const m_vInput2 = 0x8C0;
                export const m_nSetMethod = 0x1114;
                export const m_nExpression = 0x1E0;
                export const m_nOutputField = 0x1110;
                export const m_flOutputRemap = 0xF98;
            }
            export namespace CPulseCell_IsRequirementValid__Criteria_t {
                export const m_bIsValid = 0x0;
            }
            export namespace C_OP_ConstrainDistanceToUserSpecifiedPath {
                export const m_pointList = 0x1F0;
                export const m_bLoopedPath = 0x1EC;
                export const m_flTimeScale = 0x1E8;
                export const m_fMinDistance = 0x1E0;
                export const m_flMaxDistance = 0x1E4;
            }
            export namespace C_OP_MultiSegmentDisplaySnapshotGenerator {
                export const m_flValue = 0x200;
                export const m_flRadius = 0x12B8;
                export const m_flSpacing = 0x1430;
                export const m_nSegCount = 0x1EC;
                export const m_flMaxCount = 0x1720;
                export const m_flMinCount = 0x15A8;
                export const m_nInputType = 0x1F0;
                export const m_nCPSnapshot = 0x1E8;
                export const m_vecColorLit = 0xBE0;
                export const m_bPrependEmpty = 0x1898;
                export const m_flScollOffset = 0x378;
                export const m_vecColorUnlit = 0x508;
                export const m_SpecialCharList = 0x4F0;
                export const m_strDefaultString = 0x1F8;
                export const m_flDigitsAfterDecimal = 0x18A0;
            }
            export namespace C_OP_RemapTransformOrientationToRotations {
                export const m_bUseQuat = 0x254;
                export const m_vecRotation = 0x248;
                export const m_bWriteNormal = 0x255;
                export const m_TransformInput = 0x1E0;
            }
            export namespace C_OP_SetPerChildControlPointFromAttribute {
                export const m_nCPField = 0x1FC;
                export const m_nChildGroupID = 0x1E0;
                export const m_nAttributeToRead = 0x1F8;
                export const m_nFirstSourcePoint = 0x1F0;
                export const m_nNumControlPoints = 0x1E8;
                export const m_nFirstControlPoint = 0x1E4;
                export const m_nParticleIncrement = 0x1EC;
                export const m_bNumBasedOnParticleCount = 0x1F4;
            }
            export namespace C_OP_SetVectorAttributeToVectorExpression {
                export const m_flLerp = 0xF98;
                export const m_vInput1 = 0x1E8;
                export const m_vInput2 = 0x8C0;
                export const m_nSetMethod = 0x1114;
                export const m_nExpression = 0x1E0;
                export const m_nOutputField = 0x1110;
                export const m_bNormalizedOutput = 0x1118;
            }
            export namespace C_INIT_SetFloatAttributeToVectorExpression {
                export const m_vInput1 = 0x1F0;
                export const m_vInput2 = 0x8C8;
                export const m_nSetMethod = 0x111C;
                export const m_nExpression = 0x1E8;
                export const m_nOutputField = 0x1118;
                export const m_flOutputRemap = 0xFA0;
            }
            export namespace C_OP_EnableChildrenFromParentParticleCount {
                export const m_nFirstChild = 0x1EC;
                export const m_nChildGroupID = 0x1E8;
                export const m_bDisableChildren = 0x368;
                export const m_bPlayEndcapOnStop = 0x369;
                export const m_bDestroyImmediately = 0x36A;
                export const m_nNumChildrenToEnable = 0x1F0;
            }
            export namespace C_OP_MovementSkinnedPositionFromCPSnapshot {
                export const m_bRandom = 0x1E8;
                export const m_bSetNormal = 0x1F0;
                export const m_bSetRadius = 0x1F1;
                export const m_nIndexType = 0x1F4;
                export const m_flIncrement = 0x370;
                export const m_flReadIndex = 0x1F8;
                export const m_nRandomSeed = 0x1EC;
                export const m_flInterpolation = 0x7D8;
                export const m_nFullLoopIncrement = 0x4E8;
                export const m_nControlPointNumber = 0x1E4;
                export const m_nSnapShotStartPoint = 0x660;
                export const m_nSnapshotControlPointNumber = 0x1E0;
            }
            export namespace C_OP_RemapCrossProductOfTwoVectorsToVector {
                export const m_InputVec1 = 0x1E0;
                export const m_InputVec2 = 0x8B8;
                export const m_bNormalize = 0xF94;
                export const m_nFieldOutput = 0xF90;
            }
            export namespace C_OP_RemapDensityGradientToVectorAttribute {
                export const m_nFieldOutput = 0x1E4;
                export const m_flRadiusScale = 0x1E0;
            }
            export namespace C_INIT_RemapTransformOrientationToRotations {
                export const m_bUseQuat = 0x25C;
                export const m_vecRotation = 0x250;
                export const m_bWriteNormal = 0x25D;
                export const m_TransformInput = 0x1E8;
            }
            export namespace C_INIT_SetVectorAttributeToVectorExpression {
                export const m_flLerp = 0xFA0;
                export const m_vInput1 = 0x1F0;
                export const m_vInput2 = 0x8C8;
                export const m_nSetMethod = 0x111C;
                export const m_nExpression = 0x1E8;
                export const m_nOutputField = 0x1118;
                export const m_bNormalizedOutput = 0x1120;
            }
            export namespace C_OP_RemapControlPointOrientationToRotation {
                export const m_nCP = 0x1E0;
                export const m_nComponent = 0x1EC;
                export const m_flOffsetRot = 0x1E8;
                export const m_nFieldOutput = 0x1E4;
            }
            export namespace C_OP_SetControlPointFieldToScalarExpression {
                export const m_flInput1 = 0x1F0;
                export const m_flInput2 = 0x368;
                export const m_nOutputCP = 0x658;
                export const m_nExpression = 0x1E8;
                export const m_flOutputRemap = 0x4E0;
                export const m_flInterpolation = 0x660;
                export const m_nOutVectorField = 0x65C;
            }
            export namespace C_OP_SetControlPointOrientationToCPVelocity {
                export const m_nCPInput = 0x1E8;
                export const m_nCPOutput = 0x1EC;
            }
            export namespace CPulseCell_Inflow_ObservableVariableListener {
                export const m_bSelfReference = 0x82;
                export const m_nBlackboardReference = 0x80;
            }
            export namespace C_OP_SetControlPointPositionToRandomActiveCP {
                export const m_nCP1 = 0x1E8;
                export const m_flResetRate = 0x1F8;
                export const m_nHeadLocationMax = 0x1F0;
                export const m_nHeadLocationMin = 0x1EC;
            }
            export namespace C_OP_SetControlPointPositionToTimeOfDayValue {
                export const m_vecDefaultValue = 0x26C;
                export const m_nControlPointNumber = 0x1E8;
                export const m_pszTimeOfDayParameter = 0x1EC;
            }
            export namespace PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                export const m_OutflowID = 0x0;
                export const m_Connection = 0x8;
            }
            export namespace C_OP_SetControlPointFieldFromVectorExpression {
                export const m_flLerp = 0xFA0;
                export const m_nOutputCP = 0x1290;
                export const m_vecInput1 = 0x1F0;
                export const m_vecInput2 = 0x8C8;
                export const m_nExpression = 0x1E8;
                export const m_flOutputRemap = 0x1118;
                export const m_nOutVectorField = 0x1294;
            }
            export namespace C_INIT_RemapInitialDirectionToTransformToVector {
                export const m_flScale = 0x254;
                export const m_bNormalize = 0x268;
                export const m_flOffsetRot = 0x258;
                export const m_nFieldOutput = 0x250;
                export const m_vecOffsetAxis = 0x25C;
                export const m_TransformInput = 0x1E8;
            }
            export namespace C_INIT_RemapInitialTransformDirectionToRotation {
                export const m_nComponent = 0x258;
                export const m_flOffsetRot = 0x254;
                export const m_nFieldOutput = 0x250;
                export const m_TransformInput = 0x1E8;
            }
            export namespace CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                export const m_nNextIndex = 0x0;
            }
            export namespace CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                export const m_Shuffle = 0x0;
                export const m_nNextShuffle = 0x20;
            }
            export namespace C_INIT_RemapParticleCountToNamedModelElementScalar {
                export const m_hModel = 0x218;
                export const m_outputMaxName = 0x228;
                export const m_outputMinName = 0x220;
                export const m_bModelFromRenderer = 0x230;
            }
            export namespace C_INIT_RemapParticleCountToNamedModelBodyPartScalar {

            }
            export namespace C_INIT_RemapParticleCountToNamedModelSequenceScalar {

            }
            export namespace C_INIT_RemapParticleCountToNamedModelMeshGroupScalar {

            }
            export namespace DetailCombo_t {
                export const DETAIL_COMBO_ADD = 0x1;
                export const DETAIL_COMBO_OFF = 0x0;
                export const DETAIL_COMBO_MOD2X = 0x3;
                export const DETAIL_COMBO_ADD_SELF_ILLUM = 0x2;
            }
            export namespace Detail2Combo_t {
                export const DETAIL_2_COMBO_ADD = 0x1;
                export const DETAIL_2_COMBO_MUL = 0x4;
                export const DETAIL_2_COMBO_OFF = 0x0;
                export const DETAIL_2_COMBO_MOD2X = 0x3;
                export const DETAIL_2_COMBO_CROSSFADE = 0x5;
                export const DETAIL_2_COMBO_UNINITIALIZED = -0x1;
                export const DETAIL_2_COMBO_ADD_SELF_ILLUM = 0x2;
            }
            export namespace PetGroundType_t {
                export const PET_GROUND_GRID = 0x1;
                export const PET_GROUND_NONE = 0x0;
                export const PET_GROUND_PLANE = 0x2;
            }
            export namespace BBoxVolumeType_t {
                export const BBOX_RADIUS = 0x3;
                export const BBOX_VOLUME = 0x0;
                export const BBOX_MINS_MAXS = 0x2;
                export const BBOX_DIMENSIONS = 0x1;
                export const BBOX_SURFACE_AREA = 0x4;
            }
            export namespace BlurFilterType_t {
                export const BLURFILTER_BOX = 0x1;
                export const BLURFILTER_GAUSSIAN = 0x0;
            }
            export namespace HitboxLerpType_t {
                export const HITBOX_LERP_CONSTANT = 0x1;
                export const HITBOX_LERP_LIFETIME = 0x0;
            }
            export namespace ModelHitboxType_t {
                export const MODEL_HITBOX_TYPE_SNAPSHOT = 0x3;
                export const MODEL_HITBOX_TYPE_STANDARD = 0x0;
                export const MODEL_HITBOX_TYPE_RAW_BONES = 0x1;
                export const MODEL_HITBOX_TYPE_RENDERBOUNDS = 0x2;
            }
            export namespace ParticleFanType_t {
                export const PARTICLE_FAN_TYPE_FAN = 0x0;
                export const PARTICLE_FAN_TYPE_RADIAL = 0x2;
                export const PARTICLE_FAN_TYPE_ROTOR_WASH = 0x1;
            }
            export namespace ParticleFogType_t {
                export const PARTICLE_FOG_ENABLED = 0x1;
                export const PARTICLE_FOG_DISABLED = 0x2;
                export const PARTICLE_FOG_GAME_DEFAULT = 0x0;
            }
            export namespace ParticleMassMode_t {
                export const PARTICLE_MASSMODE_RADIUS_CUBED = 0x0;
                export const PARTICLE_MASSMODE_RADIUS_SQUARED = 0x2;
            }
            export namespace ParticleTopology_t {
                export const PARTICLE_TOPOLOGY_TRIS = 0x2;
                export const PARTICLE_TOPOLOGY_CUBES = 0x4;
                export const PARTICLE_TOPOLOGY_LINES = 0x1;
                export const PARTICLE_TOPOLOGY_QUADS = 0x3;
                export const PARTICLE_TOPOLOGY_POINTS = 0x0;
            }
            export namespace ParticleTraceSet_t {
                export const PARTICLE_TRACE_SET_ALL = 0x0;
                export const PARTICLE_TRACE_SET_STATIC = 0x1;
                export const PARTICLE_TRACE_SET_DYNAMIC = 0x3;
                export const PARTICLE_TRACE_SET_STATIC_AND_KEYFRAMED = 0x2;
            }
            export namespace MaterialProxyType_t {
                export const MATERIAL_PROXY_TINT = 0x1;
                export const MATERIAL_PROXY_STATUS_EFFECT = 0x0;
            }
            export namespace ParticleEntityPos_t {
                export const PARTICLE_EYES = 0x2;
                export const PARTICLE_ABS_ORIGIN = 0x0;
                export const PARTICLE_FLASHLIGHT = 0x3;
                export const PARTICLE_WORLDSPACE_CENTER = 0x1;
            }
            export namespace ParticleSelection_t {
                export const PARTICLE_SELECTION_LAST = 0x1;
                export const PARTICLE_SELECTION_FIRST = 0x0;
                export const PARTICLE_SELECTION_NUMBER = 0x2;
            }
            export namespace SnapshotIndexType_t {
                export const SNAPSHOT_INDEX_DIRECT = 0x1;
                export const SNAPSHOT_INDEX_INCREMENT = 0x0;
            }
            export namespace EventTypeSelection_t {
                export const PARTICLE_EVENT_TYPE_MASK_NONE = 0x0;
                export const PARTICLE_EVENT_TYPE_MASK_KILLED = 0x2;
                export const PARTICLE_EVENT_TYPE_MASK_USER_1 = 0x40;
                export const PARTICLE_EVENT_TYPE_MASK_USER_2 = 0x80;
                export const PARTICLE_EVENT_TYPE_MASK_USER_3 = 0x100;
                export const PARTICLE_EVENT_TYPE_MASK_USER_4 = 0x200;
                export const PARTICLE_EVENT_TYPE_MASK_SPAWNED = 0x1;
                export const PARTICLE_EVENT_TYPE_MASK_COLLISION = 0x4;
                export const PARTICLE_EVENT_TYPE_MASK_KILLED_ON_CULL = 0x400;
                export const PARTICLE_EVENT_TYPE_MASK_CULLED_ON_SPAWN = 0x800;
                export const PARTICLE_EVENT_TYPE_MASK_FIRST_COLLISION = 0x8;
                export const PARTICLE_EVENT_TYPE_MASK_COLLISION_STOPPED = 0x10;
                export const PARTICLE_EVENT_TYPE_MASK_KILLED_ON_COLLISION = 0x20;
            }
            export namespace ParticleEndcapMode_t {
                export const PARTICLE_ENDCAP_ALWAYS_ON = -0x1;
                export const PARTICLE_ENDCAP_ENDCAP_ON = 0x1;
                export const PARTICLE_ENDCAP_ENDCAP_OFF = 0x0;
            }
            export namespace ParticleToolsState_t {
                export const PARTICLE_TOOLS_STATE_ALWAYS_ON = -0x1;
                export const PARTICLE_TOOLS_STATE_GAME_ONLY = 0x1;
                export const PARTICLE_TOOLS_STATE_TOOLS_ONLY = 0x0;
            }
            export namespace InheritableBoolType_t {
                export const INHERITABLE_BOOL_TRUE = 0x2;
                export const INHERITABLE_BOOL_FALSE = 0x1;
                export const INHERITABLE_BOOL_INHERIT = 0x0;
            }
            export namespace ParticleDetailLevel_t {
                export const PARTICLEDETAIL_LOW = 0x0;
                export const PARTICLEDETAIL_HIGH = 0x2;
                export const PARTICLEDETAIL_ULTRA = 0x3;
                export const PARTICLEDETAIL_MEDIUM = 0x1;
            }
            export namespace ParticleImpulseType_t {
                export const IMPULSE_TYPE_NONE = 0x0;
                export const IMPULSE_TYPE_ROPE = 0x2;
                export const IMPULSE_TYPE_GENERIC = 0x1;
                export const IMPULSE_TYPE_EXPLOSION = 0x4;
                export const IMPULSE_TYPE_PARTICLE_SYSTEM = 0x10;
                export const IMPULSE_TYPE_EXPLOSION_UNDERWATER = 0x8;
            }
            export namespace ParticlePinDistance_t {
                export const PARTICLE_PIN_SPEED = 0x9;
                export const PARTICLE_PIN_DISTANCE_CP = 0x6;
                export const PARTICLE_PIN_FLOAT_VALUE = 0xB;
                export const PARTICLE_PIN_DISTANCE_LAST = 0x3;
                export const PARTICLE_PIN_DISTANCE_NONE = -0x1;
                export const PARTICLE_PIN_COLLECTION_AGE = 0xA;
                export const PARTICLE_PIN_DISTANCE_FIRST = 0x2;
                export const PARTICLE_PIN_DISTANCE_CENTER = 0x5;
                export const PARTICLE_PIN_DISTANCE_FARTHEST = 0x1;
                export const PARTICLE_PIN_DISTANCE_NEIGHBOR = 0x0;
                export const PARTICLE_PIN_DISTANCE_CP_PAIR_BOTH = 0x8;
                export const PARTICLE_PIN_DISTANCE_CP_PAIR_EITHER = 0x7;
            }
            export namespace PulseMethodCallMode_t {
                export const ASYNC_FIRE_AND_FORGET = 0x1;
                export const SYNC_WAIT_FOR_COMPLETION = 0x0;
            }
            export namespace ClosestPointTestType_t {
                export const PARTICLE_CLOSEST_TYPE_BOX = 0x0;
                export const PARTICLE_CLOSEST_TYPE_HYBRID = 0x2;
                export const PARTICLE_CLOSEST_TYPE_CAPSULE = 0x1;
            }
            export namespace ParticleAttrBoxFlags_t {
                export const PARTICLE_ATTR_BOX_FLAGS_NONE = 0x0;
                export const PARTICLE_ATTR_BOX_FLAGS_WATER = 0x1;
                export const PARTICLE_ATTR_BOX_FLAGS_ASLEEP = 0x8;
                export const PARTICLE_ATTR_BOX_FLAGS_FROZEN = 0x10;
                export const PARTICLE_ATTR_BOX_FLAGS_ON_FIRE = 0x2;
                export const PARTICLE_ATTR_BOX_FLAGS_WAKE_DECAY = 0x80;
                export const PARTICLE_ATTR_BOX_FLAGS_ELECTRIFIED = 0x4;
                export const PARTICLE_ATTR_BOX_FLAGS_TIMED_DECAY = 0x20;
                export const PARTICLE_ATTR_BOX_FLAGS_ZERO_GRAVITY = 0x200;
                export const PARTICLE_ATTR_BOX_FLAGS_MOTION_DISABLED = 0x100;
                export const PARTICLE_ATTR_BOX_FLAGS_DISABLE_NONSTATIC_COLLISION = 0x40;
            }
            export namespace ScalarExpressionType_t {
                export const SCALAR_EXPRESSION_GT = 0x9;
                export const SCALAR_EXPRESSION_LT = 0xA;
                export const SCALAR_EXPRESSION_ADD = 0x0;
                export const SCALAR_EXPRESSION_MAX = 0x6;
                export const SCALAR_EXPRESSION_MIN = 0x5;
                export const SCALAR_EXPRESSION_MOD = 0x7;
                export const SCALAR_EXPRESSION_MUL = 0x2;
                export const SCALAR_EXPRESSION_EQUAL = 0x8;
                export const SCALAR_EXPRESSION_DIVIDE = 0x3;
                export const SCALAR_EXPRESSION_INPUT_1 = 0x4;
                export const SCALAR_EXPRESSION_SUBTRACT = 0x1;
                export const SCALAR_EXPRESSION_UNINITIALIZED = -0x1;
            }
            export namespace SpriteCardShaderType_t {
                export const SPRITECARD_SHADER_BASE = 0x0;
                export const SPRITECARD_SHADER_CUSTOM = 0x1;
            }
            export namespace VectorExpressionType_t {
                export const VECTOR_EXPRESSION_ADD = 0x0;
                export const VECTOR_EXPRESSION_MAX = 0x6;
                export const VECTOR_EXPRESSION_MIN = 0x5;
                export const VECTOR_EXPRESSION_MUL = 0x2;
                export const VECTOR_EXPRESSION_LERP = 0x8;
                export const VECTOR_EXPRESSION_DIVIDE = 0x3;
                export const VECTOR_EXPRESSION_INPUT_1 = 0x4;
                export const VECTOR_EXPRESSION_SUBTRACT = 0x1;
                export const VECTOR_EXPRESSION_CROSSPRODUCT = 0x7;
                export const VECTOR_EXPRESSION_UNINITIALIZED = -0x1;
            }
            export namespace ParticleCollisionMask_t {
                export const PARTICLE_MASK_ALL = -0x1;
                export const PARTICLE_MASK_SHOT = 0x1C1003;
                export const PARTICLE_MASK_SOLID = 0xC3001;
                export const PARTICLE_MASK_WATER = 0x18000;
                export const PARTICLE_MASK_OPAQUE = 0x80;
                export const PARTICLE_MASK_NPCSOLID = 0xC3021;
                export const PARTICLE_MASK_SHOT_HULL = 0x1C3001;
                export const PARTICLE_MASK_SOLID_WATER = 0xDB001;
                export const PARTICLE_MASK_SHOT_BRUSHONLY = 0x101001;
                export const PARTICLE_MASK_DEFAULTPLAYERSOLID = 0xC3011;
            }
            export namespace ParticleCollisionMode_t {
                export const COLLISION_MODE_DISABLED = -0x1;
                export const COLLISION_MODE_USE_NEAREST_TRACE = 0x2;
                export const COLLISION_MODE_INITIAL_TRACE_DOWN = 0x0;
                export const COLLISION_MODE_PER_FRAME_PLANESET = 0x1;
                export const COLLISION_MODE_PER_PARTICLE_TRACE = 0x3;
            }
            export namespace ParticleParentSetMode_t {
                export const PARTICLE_SET_PARENT_NO = 0x0;
                export const PARTICLE_SET_PARENT_ROOT = 0x2;
                export const PARTICLE_SET_PARENT_IMMEDIATE = 0x1;
            }
            export namespace PulseBestOutflowRules_t {
                export const SORT_BY_OUTFLOW_INDEX = 0x1;
                export const SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0;
            }
            export namespace SpriteCardTextureType_t {
                export const SPRITECARD_TEXTURE_ZOOM = 0x1;
                export const SPRITECARD_TEXTURE_DEPTH = 0xA;
                export const SPRITECARD_TEXTURE_DIFFUSE = 0x0;
                export const SPRITECARD_TEXTURE_NORMALMAP = 0x5;
                export const SPRITECARD_TEXTURE_UVDISTORTION = 0x3;
                export const SPRITECARD_TEXTURE_ANIMMOTIONVEC = 0x6;
                export const SPRITECARD_TEXTURE_1D_COLOR_LOOKUP = 0x2;
                export const SPRITECARD_TEXTURE_UVDISTORTION_ZOOM = 0x4;
                export const SPRITECARD_TEXTURE_ILLUMINATION_GRADIENT = 0xB;
                export const SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_A = 0x7;
                export const SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_B = 0x8;
                export const SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_C = 0x9;
            }
            export namespace TextureRepetitionMode_t {
                export const TEXTURE_REPETITION_PATH = 0x1;
                export const TEXTURE_REPETITION_PARTICLE = 0x0;
            }
            export namespace PFuncVisualizationType_t {
                export const PFUNC_VISUALIZATION_BOX = 0x2;
                export const PFUNC_VISUALIZATION_LINE = 0x5;
                export const PFUNC_VISUALIZATION_RING = 0x3;
                export const PFUNC_VISUALIZATION_PLANE = 0x4;
                export const PFUNC_VISUALIZATION_CYLINDER = 0x6;
                export const PFUNC_VISUALIZATION_SPHERE_SOLID = 0x1;
                export const PFUNC_VISUALIZATION_SPHERE_WIREFRAME = 0x0;
            }
            export namespace ParticleCollisionGroup_t {
                export const PARTICLE_COLLISION_GROUP_NPC = 0xC;
                export const PARTICLE_COLLISION_GROUP_PROPS = 0x18;
                export const PARTICLE_COLLISION_GROUP_DEBRIS = 0x5;
                export const PARTICLE_COLLISION_GROUP_PLAYER = 0x8;
                export const PARTICLE_COLLISION_GROUP_DEFAULT = 0x4;
                export const PARTICLE_COLLISION_GROUP_VEHICLE = 0xA;
                export const PARTICLE_COLLISION_GROUP_INTERACTIVE = 0x7;
            }
            export namespace ParticleHitboxBiasType_t {
                export const PARTICLE_HITBOX_BIAS_ENTITY = 0x0;
                export const PARTICLE_HITBOX_BIAS_HITBOX = 0x1;
            }
            export namespace ParticleLiquidContents_t {
                export const PARTICLE_LIQUID_OIL = 0x1;
                export const PARTICLE_LIQUID_NONE = 0x0;
                export const PARTICLE_LIQUID_WATER = 0x2;
            }
            export namespace ParticleFalloffFunction_t {
                export const PARTICLE_FALLOFF_LINEAR = 0x1;
                export const PARTICLE_FALLOFF_CONSTANT = 0x0;
                export const PARTICLE_FALLOFF_EXPONENTIAL = 0x2;
            }
            export namespace ParticleLightingQuality_t {
                export const PARTICLE_LIGHTING_PER_PIXEL = -0x1;
                export const PARTICLE_LIGHTING_PER_VERTEX = 0x1;
                export const PARTICLE_LIGHTING_PER_PARTICLE = 0x0;
                export const PARTICLE_LIGHTING_OVERRIDE_COLOR = 0x3;
                export const PARTICLE_LIGHTING_ADD_EXTRA_LIGHT = 0x4;
                export const PARTICLE_LIGHTING_OVERRIDE_POSITION = 0x2;
            }
            export namespace ParticleOrientationType_t {
                export const PARTICLE_ORIENTATION_NONE = 0x0;
                export const PARTICLE_ORIENTATION_NORMAL = 0x2;
                export const PARTICLE_ORIENTATION_ROTATION = 0x4;
                export const PARTICLE_ORIENTATION_VELOCITY = 0x1;
            }
            export namespace ParticleOutputBlendMode_t {
                export const PARTICLE_OUTPUT_BLEND_MODE_ADD = 0x1;
                export const PARTICLE_OUTPUT_BLEND_MODE_ALPHA = 0x0;
                export const PARTICLE_OUTPUT_BLEND_MODE_MOD2X = 0x5;
                export const PARTICLE_OUTPUT_BLEND_MODE_LIGHTEN = 0x6;
                export const PARTICLE_OUTPUT_BLEND_MODE_BLEND_ADD = 0x2;
                export const PARTICLE_OUTPUT_BLEND_MODE_HALF_BLEND_ADD = 0x3;
                export const PARTICLE_OUTPUT_BLEND_MODE_NEG_HALF_BLEND_ADD = 0x4;
            }
            export namespace PulseCursorWakePriority_t {
                export const WakeElegantly = 0x0;
                export const WakeImmediate = 0x1;
            }
            export namespace ParticleControlPointAxis_t {
                export const PARTICLE_CP_AXIS_X = 0x0;
                export const PARTICLE_CP_AXIS_Y = 0x1;
                export const PARTICLE_CP_AXIS_Z = 0x2;
                export const PARTICLE_CP_AXIS_NEGATIVE_X = 0x3;
                export const PARTICLE_CP_AXIS_NEGATIVE_Y = 0x4;
                export const PARTICLE_CP_AXIS_NEGATIVE_Z = 0x5;
            }
            export namespace ParticleRotationLockType_t {
                export const PARTICLE_ROTATION_LOCK_NONE = 0x0;
                export const PARTICLE_ROTATION_LOCK_NORMAL = 0x2;
                export const PARTICLE_ROTATION_LOCK_ROTATIONS = 0x1;
            }
            export namespace ParticleVRHandChoiceList_t {
                export const PARTICLE_VRHAND_CP = 0x2;
                export const PARTICLE_VRHAND_LEFT = 0x0;
                export const PARTICLE_VRHAND_RIGHT = 0x1;
                export const PARTICLE_VRHAND_CP_OBJECT = 0x3;
            }
            export namespace SpriteCardTextureChannel_t {
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_A = 0x2;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_B = 0xB;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_G = 0xA;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_R = 0x9;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_RGB = 0x0;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_RGBA = 0x1;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_A = 0x3;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_BALPHA = 0xE;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_GALPHA = 0xD;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_RALPHA = 0xC;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_A_RGBALPHA = 0x7;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_RGBMASK = 0x5;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_RGBA_RGBALPHA = 0x6;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_ALPHAMASK = 0x4;
                export const SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_A_RGBALPHA = 0x8;
            }
            export namespace ParticleSortingChoiceList_t {
                export const PARTICLE_SORTING_NEAREST = 0x0;
                export const PARTICLE_SORTING_CREATION_TIME = 0x1;
            }
            export namespace ParticleTraceMissBehavior_t {
                export const PARTICLE_TRACE_MISS_BEHAVIOR_KILL = 0x1;
                export const PARTICLE_TRACE_MISS_BEHAVIOR_NONE = 0x0;
                export const PARTICLE_TRACE_MISS_BEHAVIOR_TRACE_END = 0x2;
            }
            export namespace PulseCursorCancelPriority_t {
                export const _None = 0x0;
                export const HardCancel = 0x3;
                export const SoftCancel = 0x2;
                export const CancelOnSucceeded = 0x1;
            }
            export namespace VectorFloatExpressionType_t {
                export const VECTOR_FLOAT_EXPRESSION_DISTANCE = 0x1;
                export const VECTOR_FLOAT_EXPRESSION_DOTPRODUCT = 0x0;
                export const VECTOR_FLOAT_EXPRESSION_DISTANCESQR = 0x2;
                export const VECTOR_FLOAT_EXPRESSION_INPUT1_NOISE = 0x5;
                export const VECTOR_FLOAT_EXPRESSION_INPUT1_LENGTH = 0x3;
                export const VECTOR_FLOAT_EXPRESSION_UNINITIALIZED = -0x1;
                export const VECTOR_FLOAT_EXPRESSION_INPUT1_LENGTHSQR = 0x4;
            }
            export namespace ParticleAlphaReferenceType_t {
                export const PARTICLE_ALPHA_REFERENCE_ALPHA_ALPHA = 0x0;
                export const PARTICLE_ALPHA_REFERENCE_ALPHA_OPAQUE = 0x2;
                export const PARTICLE_ALPHA_REFERENCE_OPAQUE_ALPHA = 0x1;
                export const PARTICLE_ALPHA_REFERENCE_OPAQUE_OPAQUE = 0x3;
            }
            export namespace ParticleOrientationSetMode_t {
                export const PARTICLE_ORIENTATION_SET_NONE = -0x1;
                export const PARTICLE_ORIENTATION_SET_FROM_NORMAL = 0x1;
                export const PARTICLE_ORIENTATION_SET_FROM_VELOCITY = 0x0;
                export const PARTICLE_ORIENTATION_SET_FROM_ROTATIONS = 0x2;
            }
            export namespace SetStatisticExpressionType_t {
                export const SET_EXPRESSION_MAX = 0x6;
                export const SET_EXPRESSION_MIN = 0x5;
                export const SET_EXPRESSION_SUM = 0x0;
                export const SET_EXPRESSION_MEAN = 0x1;
                export const SET_EXPRESSION_MODE = 0x3;
                export const SET_EXPRESSION_MEDIAN = 0x2;
                export const SET_EXPRESSION_UNINITIALIZED = -0x1;
                export const SET_EXPRESSION_STANDARD_DEVIATION = 0x4;
            }
            export namespace SpriteCardPerParticleScale_t {
                export const SPRITECARD_TEXTURE_PP_SCALE_YAW = 0x8;
                export const SPRITECARD_TEXTURE_PP_SCALE_NONE = 0x0;
                export const SPRITECARD_TEXTURE_PP_SCALE_ROLL = 0x7;
                export const SPRITECARD_TEXTURE_PP_SCALE_PITCH = 0x9;
                export const SPRITECARD_TEXTURE_PP_SCALE_RANDOM = 0xA;
                export const SPRITECARD_TEXTURE_PP_SCALE_NEG_RANDOM = 0xB;
                export const SPRITECARD_TEXTURE_PP_SCALE_RANDOM_TIME = 0xC;
                export const SPRITECARD_TEXTURE_PP_SCALE_PARTICLE_AGE = 0x1;
                export const SPRITECARD_TEXTURE_PP_SCALE_SHADER_RADIUS = 0x6;
                export const SPRITECARD_TEXTURE_PP_SCALE_PARTICLE_ALPHA = 0x5;
                export const SPRITECARD_TEXTURE_PP_SCALE_ANIMATION_FRAME = 0x2;
                export const SPRITECARD_TEXTURE_PP_SCALE_NEG_RANDOM_TIME = 0xD;
                export const SPRITECARD_TEXTURE_PP_SCALE_SHADER_EXTRA_DATA1 = 0x3;
                export const SPRITECARD_TEXTURE_PP_SCALE_SHADER_EXTRA_DATA2 = 0x4;
            }
            export namespace ParticleDepthFeatheringMode_t {
                export const PARTICLE_DEPTH_FEATHERING_OFF = 0x0;
                export const PARTICLE_DEPTH_FEATHERING_ON_OPTIONAL = 0x1;
                export const PARTICLE_DEPTH_FEATHERING_ON_REQUIRED = 0x2;
            }
            export namespace ParticleHitboxDataSelection_t {
                export const PARTICLE_HITBOX_COUNT = 0x1;
                export const PARTICLE_HITBOX_AVERAGE_SPEED = 0x0;
            }
            export namespace ParticleLightTypeChoiceList_t {
                export const PARTICLE_LIGHT_TYPE_FX = 0x2;
                export const PARTICLE_LIGHT_TYPE_SPOT = 0x1;
                export const PARTICLE_LIGHT_TYPE_POINT = 0x0;
                export const PARTICLE_LIGHT_TYPE_CAPSULE = 0x3;
            }
            export namespace ParticleLightUnitChoiceList_t {
                export const PARTICLE_LIGHT_UNIT_LUMENS = 0x1;
                export const PARTICLE_LIGHT_UNIT_CANDELAS = 0x0;
            }
            export namespace ParticleVolumetricSmokeType_t {
                export const PARTICLE_VOLUMETRIC_SMOKE_TYPE_SINK = 0x1;
                export const PARTICLE_VOLUMETRIC_SMOKE_TYPE_REPEL = 0x2;
                export const PARTICLE_VOLUMETRIC_SMOKE_TYPE_TRACE = 0x3;
                export const PARTICLE_VOLUMETRIC_SMOKE_TYPE_EMISSION = 0x0;
            }
            export namespace MissingParentInheritBehavior_t {
                export const MISSING_PARENT_KILL = 0x0;
                export const MISSING_PARENT_FIND_NEW = 0x1;
                export const MISSING_PARENT_DO_NOTHING = -0x1;
                export const MISSING_PARENT_SAME_INDEX = 0x2;
            }
            export namespace ParticleLightFogLightingMode_t {
                export const PARTICLE_LIGHT_FOG_LIGHTING_MODE_NONE = 0x0;
                export const PARTICLE_LIGHT_FOG_LIGHTING_MODE_DYNAMIC = 0x2;
                export const PARTICLE_LIGHT_FOG_LIGHTING_MODE_DYNAMIC_NOSHADOWS = 0x4;
            }
            export namespace ParticleSequenceCropOverride_t {
                export const PARTICLE_SEQUENCE_CROP_OVERRIDE_DEFAULT = -0x1;
                export const PARTICLE_SEQUENCE_CROP_OVERRIDE_FORCE_ON = 0x1;
                export const PARTICLE_SEQUENCE_CROP_OVERRIDE_FORCE_OFF = 0x0;
            }
            export namespace RenderModelSubModelFieldType_t {
                export const SUBMODEL_AS_MESHGROUP_MASK = 0x2;
                export const SUBMODEL_AS_MESHGROUP_INDEX = 0x1;
                export const SUBMODEL_AS_BODYGROUP_SUBMODEL = 0x0;
                export const SUBMODEL_IGNORED_USE_MODEL_DEFAULT_MESHGROUP_MASK = 0x3;
            }
            export namespace ParticleOrientationChoiceList_t {
                export const PARTICLE_ORIENTATION_SCREEN_ALIGNED = 0x0;
                export const PARTICLE_ORIENTATION_WORLD_Z_ALIGNED = 0x2;
                export const PARTICLE_ORIENTATION_SCREEN_Z_ALIGNED = 0x1;
                export const PARTICLE_ORIENTATION_FULL_3AXIS_ROTATION = 0x5;
                export const PARTICLE_ORIENTATION_ALIGN_TO_PARTICLE_NORMAL = 0x3;
                export const PARTICLE_ORIENTATION_SCREENALIGN_TO_PARTICLE_NORMAL = 0x4;
            }
            export namespace ParticleTextureLayerBlendType_t {
                export const SPRITECARD_TEXTURE_BLEND_ADD = 0x3;
                export const SPRITECARD_TEXTURE_BLEND_MOD2X = 0x1;
                export const SPRITECARD_TEXTURE_BLEND_AVERAGE = 0x5;
                export const SPRITECARD_TEXTURE_BLEND_REPLACE = 0x2;
                export const SPRITECARD_TEXTURE_BLEND_MULTIPLY = 0x0;
                export const SPRITECARD_TEXTURE_BLEND_SUBTRACT = 0x4;
                export const SPRITECARD_TEXTURE_BLEND_LUMINANCE = 0x6;
            }
            export namespace ParticleLightBehaviorChoiceList_t {
                export const PARTICLE_LIGHT_BEHAVIOR_ROPE = 0x1;
                export const PARTICLE_LIGHT_BEHAVIOR_TRAILS = 0x2;
                export const PARTICLE_LIGHT_BEHAVIOR_FOLLOW_DIRECTION = 0x0;
            }
            export namespace ParticleLightnintBranchBehavior_t {
                export const PARTICLE_LIGHTNING_BRANCH_CURRENT_DIR = 0x0;
                export const PARTICLE_LIGHTNING_BRANCH_ENDPOINT_DIR = 0x1;
            }
            export namespace ParticleOmni2LightTypeChoiceList_t {
                export const PARTICLE_OMNI2_LIGHT_TYPE_BARN = 0x2;
                export const PARTICLE_OMNI2_LIGHT_TYPE_POINT = 0x0;
                export const PARTICLE_OMNI2_LIGHT_TYPE_SPHERE = 0x1;
            }
            export namespace ParticlePostProcessPriorityGroup_t {
                export const PARTICLE_POST_PROCESS_PRIORITY_GLOBAL_UI = 0x5;
                export const PARTICLE_POST_PROCESS_PRIORITY_LEVEL_VOLUME = 0x0;
                export const PARTICLE_POST_PROCESS_PRIORITY_LEVEL_OVERRIDE = 0x1;
                export const PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_EFFECT = 0x2;
                export const PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_STATE_LOW = 0x3;
                export const PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_STATE_HIGH = 0x4;
            }
            export namespace StandardLightingAttenuationStyle_t {
                export const LIGHT_STYLE_NEW = 0x1;
                export const LIGHT_STYLE_OLD = 0x0;
            }
            export namespace ParticleMultiSegmentCountSelection_t {
                export const PARTICLE_MULTISEGMENT_SEG_COUNT_7 = 0x7;
                export const PARTICLE_MULTISEGMENT_SEG_COUNT_14 = 0xE;
                export const PARTICLE_MULTISEGMENT_SEG_COUNT_16 = 0x10;
            }
            export namespace ParticleMultiSegmentInputSelection_t {
                export const PARTICLE_MULTISEGMENT_SELECTION_FLOAT = 0x0;
                export const PARTICLE_MULTISEGMENT_SELECTION_STRING = 0x1;
            }
            export namespace ParticleVolumetricSmokeCreationType_t {
                export const PARTICLE_VOLUMETRIC_SMOKE_TYPE_IMPULSE = 0x1;
                export const PARTICLE_VOLUMETRIC_SMOKE_TYPE_CONTINUOUS = 0x0;
            }
            export namespace ParticleMultiSegmentSpecialCharacter_t {
                export const PARTICLE_MULTISEGMENT_SPECIAL_NONE = -0x1;
                export const PARTICLE_MULTISEGMENT_SPECIAL_COLON = 0x1;
                export const PARTICLE_MULTISEGMENT_SPECIAL_DECIMAL = 0x0;
                export const PARTICLE_MULTISEGMENT_SPECIAL_DEGREES = 0x2;
            }
            export namespace ParticleOmni2LighOrientationChoiceList_t {
                export const PARTICLE_OMNI2_LIGHT_ORIENTATION_NORMAL = 0x1;
                export const PARTICLE_OMNI2_LIGHT_ORIENTATION_TARGET = 0x3;
                export const PARTICLE_OMNI2_LIGHT_ORIENTATION_ROTATIONS = 0x0;
                export const PARTICLE_OMNI2_LIGHT_ORIENTATION_NORMAL_ROLL = 0x2;
                export const PARTICLE_OMNI2_LIGHT_ORIENTATION_TARGET_ROLL = 0x4;
            }
        }
    }
}
