public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class particles_dll {
            public static partial class C_OP_Cull {
                public const long m_flCullEnd = 0x1E8;
                public const long m_flCullExp = 0x1EC;
                public const long m_flCullPerc = 0x1E0;
                public const long m_flCullStart = 0x1E4;
            }
            public static partial class C_OP_Spin {

            }
            public static partial class C_OP_Decay {
                public const long m_bRopeDecay = 0x1E0;
                public const long m_bForcePreserveParticleOrder = 0x1E1;
            }
            public static partial class C_OP_Noise {
                public const long m_bAdditive = 0x1F0;
                public const long m_flOutputMax = 0x1E8;
                public const long m_flOutputMin = 0x1E4;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_fl4NoiseScale = 0x1EC;
                public const long m_flNoiseAnimationTimeScale = 0x1F4;
            }
            public static partial class C_OP_FadeIn {
                public const long m_bProportional = 0x1EC;
                public const long m_flFadeInTimeExp = 0x1E8;
                public const long m_flFadeInTimeMax = 0x1E4;
                public const long m_flFadeInTimeMin = 0x1E0;
            }
            public static partial class C_OP_SetVec {
                public const long m_Lerp = 0x8C0;
                public const long m_InputValue = 0x1E0;
                public const long m_nSetMethod = 0x8BC;
                public const long m_nOutputField = 0x8B8;
                public const long m_bNormalizedOutput = 0xA38;
            }
            public static partial class CGeneralSpin {
                public const long m_nSpinRateDegrees = 0x1E0;
                public const long m_fSpinRateStopTime = 0x1EC;
                public const long m_nSpinRateMinDegrees = 0x1E4;
            }
            public static partial class C_OP_FadeOut {
                public const long m_flFadeBias = 0x1EC;
                public const long m_bEaseInAndOut = 0x221;
                public const long m_bProportional = 0x220;
                public const long m_flFadeOutTimeExp = 0x1E8;
                public const long m_flFadeOutTimeMax = 0x1E4;
                public const long m_flFadeOutTimeMin = 0x1E0;
            }
            public static partial class C_OP_SetToCP {
                public const long m_vecOffset = 0x1E4;
                public const long m_bOffsetLocal = 0x1F0;
                public const long m_nControlPointNumber = 0x1E0;
            }
            public static partial class C_OP_SpinYaw {

            }
            public static partial class C_OP_Callback {

            }
            public static partial class C_OP_SetFloat {
                public const long m_Lerp = 0x360;
                public const long m_InputValue = 0x1E0;
                public const long m_nSetMethod = 0x35C;
                public const long m_nOutputField = 0x358;
            }
            public static partial class CPAssignment_t {
                public const long m_Pos = 0x8;
                public const long m_nCPNumber = 0x0;
                public const long m_nOrientationMode = 0x6E0;
            }
            public static partial class CPulseGraphDef {
                public const long m_Vars = 0x80;
                public const long m_Cells = 0x68;
                public const long m_Chunks = 0x50;
                public const long m_CallInfos = 0xE0;
                public const long m_Constants = 0xF8;
                public const long m_DomainValues = 0x110;
                public const long m_TempVarBanks = 0x98;
                public const long m_DomainSubType = 0x18;
                public const long m_ParentMapName = 0x30;
                public const long m_ParentXmlName = 0x40;
                public const long m_PublicOutputs = 0xB0;
                public const long m_InvokeBindings = 0xC8;
                public const long m_DomainIdentifier = 0x8;
                public const long m_OutputConnections = 0x140;
                public const long m_BlackboardReferences = 0x128;
            }
            public static partial class C_INIT_InitVec {
                public const long m_InputValue = 0x1E8;
                public const long m_nSetMethod = 0x8C4;
                public const long m_nOutputField = 0x8C0;
                public const long m_bNormalizedOutput = 0x8C8;
                public const long m_bWritePreviousPosition = 0x8C9;
            }
            public static partial class C_OP_Diffusion {
                public const long m_nFieldOutput = 0x1E4;
                public const long m_flRadiusScale = 0x1E0;
                public const long m_nVoxelGridResolution = 0x1E8;
            }
            public static partial class C_OP_ModelCull {
                public const long m_bBoundBox = 0x1E4;
                public const long m_bUseBones = 0x1E6;
                public const long m_bCullOutside = 0x1E5;
                public const long m_HitboxSetName = 0x1E7;
                public const long m_nControlPointNumber = 0x1E0;
            }
            public static partial class C_OP_PlaneCull {
                public const long m_bLocalSpace = 0x8C0;
                public const long m_flPlaneOffset = 0x8C4;
                public const long m_vecPlaneDirection = 0x1E8;
                public const long m_nPlaneControlPoint = 0x1E0;
            }
            public static partial class C_OP_RtEnvCull {
                public const long m_nRTEnvCP = 0x27C;
                public const long m_RtEnvName = 0x1FA;
                public const long m_nComponent = 0x280;
                public const long m_vecTestDir = 0x1E0;
                public const long m_bCullOnMiss = 0x1F8;
                public const long m_vecTestNormal = 0x1EC;
                public const long m_bStickInsteadOfCull = 0x1F9;
            }
            public static partial class C_OP_WindForce {
                public const long m_vForce = 0x1F0;
            }
            public static partial class TextureGroup_t {
                public const long m_Gradient = 0x10;
                public const long m_bEnabled = 0x0;
                public const long m_hTexture = 0x8;
                public const long m_nTextureType = 0x28;
                public const long m_flTextureBlend = 0x38;
                public const long m_TextureControls = 0x1B0;
                public const long m_nTextureChannels = 0x2C;
                public const long m_nTextureBlendMode = 0x30;
                public const long m_bReplaceTextureWithGradient = 0x1;
            }
            public static partial class CPathParameters {
                public const long m_flBulge = 0x10;
                public const long m_flMidPoint = 0x14;
                public const long m_vEndOffset = 0x30;
                public const long m_nBulgeControl = 0xC;
                public const long m_vMidPointOffset = 0x24;
                public const long m_vStartPointOffset = 0x18;
                public const long m_nEndControlPointNumber = 0x8;
                public const long m_nMidControlPointNumber = 0x4;
                public const long m_nStartControlPointNumber = 0x0;
            }
            public static partial class CPulseCell_Base {
                public const long m_nEditorNodeID = 0x8;
            }
            public static partial class CPulse_CallInfo {
                public const long m_PortName = 0x0;
                public const long m_nSrcChunk = 0x4C;
                public const long m_RegisterMap = 0x18;
                public const long m_CallMethodID = 0x48;
                public const long m_nEditorNodeID = 0x10;
                public const long m_nBreakDestChunk = 0x54;
                public const long m_nSrcInstruction = 0x50;
                public const long m_nBreakDestInstruction = 0x58;
            }
            public static partial class CSpinUpdateBase {

            }
            public static partial class C_INIT_AgeNoise {
                public const long m_bAbsVal = 0x1E8;
                public const long m_flAgeMax = 0x1F4;
                public const long m_flAgeMin = 0x1F0;
                public const long m_flOffset = 0x1EC;
                public const long m_bAbsValInv = 0x1E9;
                public const long m_flNoiseScale = 0x1F8;
                public const long m_vecOffsetLoc = 0x200;
                public const long m_flNoiseScaleLoc = 0x1FC;
            }
            public static partial class C_INIT_RingWave {
                public const long m_flYaw = 0xC98;
                public const long m_flRoll = 0x9A8;
                public const long m_flPitch = 0xB20;
                public const long m_flThickness = 0x540;
                public const long m_TransformInput = 0x1E8;
                public const long m_bXYVelocityOnly = 0xE11;
                public const long m_flInitialRadius = 0x3C8;
                public const long m_bEvenDistribution = 0xE10;
                public const long m_flInitialSpeedMax = 0x830;
                public const long m_flInitialSpeedMin = 0x6B8;
                public const long m_flParticlesPerOrbit = 0x250;
            }
            public static partial class C_OP_AlphaDecay {
                public const long m_flMinAlpha = 0x1E0;
            }
            public static partial class C_OP_DampenToCP {
                public const long m_flRange = 0x1E4;
                public const long m_flScale = 0x1E8;
                public const long m_nControlPointNumber = 0x1E0;
            }
            public static partial class C_OP_LerpScalar {
                public const long m_flOutput = 0x1E8;
                public const long m_flEndTime = 0x364;
                public const long m_flStartTime = 0x360;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_LerpVector {
                public const long m_flEndTime = 0x1F4;
                public const long m_vecOutput = 0x1E4;
                public const long m_nSetMethod = 0x1F8;
                public const long m_flStartTime = 0x1F0;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_LockPoints {
                public const long m_nMaxCol = 0x1E4;
                public const long m_nMaxRow = 0x1EC;
                public const long m_nMinCol = 0x1E0;
                public const long m_nMinRow = 0x1E8;
                public const long m_flBlendValue = 0x1F4;
                public const long m_nControlPoint = 0x1F0;
            }
            public static partial class C_OP_LockToBone {
                public const long m_bRigid = 0x338;
                public const long m_bUseBones = 0x339;
                public const long m_flRotLerp = 0xA28;
                public const long m_modelInput = 0x1E0;
                public const long m_vecRotation = 0x350;
                public const long m_nFieldOutput = 0x33C;
                public const long m_HitboxSetName = 0x2B8;
                public const long m_flPrevPosScale = 0x2B4;
                public const long m_transformInput = 0x240;
                public const long m_flJumpThreshold = 0x2B0;
                public const long m_nFieldOutputPrev = 0x340;
                public const long m_nRotationSetType = 0x344;
                public const long m_flLifeTimeFadeEnd = 0x2AC;
                public const long m_bRigidRotationLock = 0x348;
                public const long m_flLifeTimeFadeStart = 0x2A8;
            }
            public static partial class C_OP_NormalLock {
                public const long m_nControlPointNumber = 0x1E0;
            }
            public static partial class C_OP_RemapSpeed {
                public const long m_flInputMax = 0x1E8;
                public const long m_flInputMin = 0x1E4;
                public const long m_nSetMethod = 0x1F4;
                public const long m_flOutputMax = 0x1F0;
                public const long m_flOutputMin = 0x1EC;
                public const long m_bIgnoreDelta = 0x1F8;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_RenderText {
                public const long m_DefaultText = 0x238;
                public const long m_OutlineColor = 0x230;
            }
            public static partial class C_OP_SpinUpdate {

            }
            public static partial class CPulseExecCursor {

            }
            public static partial class C_INIT_InitFloat {
                public const long m_InputValue = 0x1E8;
                public const long m_nSetMethod = 0x364;
                public const long m_nOutputField = 0x360;
                public const long m_InputStrength = 0x368;
            }
            public static partial class C_INIT_ModelCull {
                public const long m_bBoundBox = 0x1EC;
                public const long m_bUseBones = 0x1EE;
                public const long m_bCullOutside = 0x1ED;
                public const long m_HitboxSetName = 0x1EF;
                public const long m_nControlPointNumber = 0x1E8;
            }
            public static partial class C_INIT_PlaneCull {
                public const long m_flDistance = 0x1F0;
                public const long m_bCullInside = 0x368;
                public const long m_nControlPoint = 0x1E8;
            }
            public static partial class C_INIT_PointList {
                public const long m_pointList = 0x1F0;
                public const long m_bClosedLoop = 0x209;
                public const long m_nFieldOutput = 0x1E8;
                public const long m_bPlaceAlongPath = 0x208;
                public const long m_nNumPointsAlongPath = 0x20C;
            }
            public static partial class C_INIT_RandomYaw {

            }
            public static partial class C_INIT_RtEnvCull {
                public const long m_nRTEnvCP = 0x284;
                public const long m_RtEnvName = 0x203;
                public const long m_nComponent = 0x288;
                public const long m_vecTestDir = 0x1E8;
                public const long m_bCullOnMiss = 0x201;
                public const long m_bLifeAdjust = 0x202;
                public const long m_bUseVelocity = 0x200;
                public const long m_vecTestNormal = 0x1F4;
            }
            public static partial class C_OP_ChladniWave {
                public const long m_b3D = 0x1580;
                public const long m_flInputMax = 0x360;
                public const long m_flInputMin = 0x1E8;
                public const long m_nSetMethod = 0x1578;
                public const long m_flOutputMax = 0x650;
                public const long m_flOutputMin = 0x4D8;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_vecHarmonics = 0xEA0;
                public const long m_vecWaveLength = 0x7C8;
                public const long m_nLocalSpaceControlPoint = 0x157C;
            }
            public static partial class C_OP_ClampScalar {
                public const long m_flOutputMax = 0x360;
                public const long m_flOutputMin = 0x1E8;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_ClampVector {
                public const long m_nFieldOutput = 0x1E0;
                public const long m_vecOutputMax = 0x8C0;
                public const long m_vecOutputMin = 0x1E8;
            }
            public static partial class C_OP_CycleScalar {
                public const long m_nCPScale = 0x1F4;
                public const long m_flEndValue = 0x1E8;
                public const long m_nDestField = 0x1E0;
                public const long m_nSetMethod = 0x200;
                public const long m_flCycleTime = 0x1EC;
                public const long m_nCPFieldMax = 0x1FC;
                public const long m_nCPFieldMin = 0x1F8;
                public const long m_flStartValue = 0x1E4;
                public const long m_bDoNotRepeatCycle = 0x1F0;
                public const long m_bSynchronizeParticles = 0x1F1;
            }
            public static partial class C_OP_EndCapDecay {

            }
            public static partial class C_OP_FadeAndKill {
                public const long m_flEndAlpha = 0x1F4;
                public const long m_flStartAlpha = 0x1F0;
                public const long m_flEndFadeInTime = 0x1E4;
                public const long m_flEndFadeOutTime = 0x1EC;
                public const long m_flStartFadeInTime = 0x1E0;
                public const long m_flStartFadeOutTime = 0x1E8;
                public const long m_bForcePreserveParticleOrder = 0x1F8;
            }
            public static partial class C_OP_GlobalLight {
                public const long m_flScale = 0x1E0;
                public const long m_bClampLowerRange = 0x1E4;
                public const long m_bClampUpperRange = 0x1E5;
            }
            public static partial class C_OP_MaxVelocity {
                public const long m_flMaxVelocity = 0x1E0;
                public const long m_flMinVelocity = 0x358;
            }
            public static partial class C_OP_RadiusDecay {
                public const long m_flMinRadius = 0x1E0;
            }
            public static partial class C_OP_RandomForce {
                public const long m_MaxForce = 0x1FC;
                public const long m_MinForce = 0x1F0;
            }
            public static partial class C_OP_RemapCPtoCP {
                public const long m_flInputMax = 0x1FC;
                public const long m_flInputMin = 0x1F8;
                public const long m_bDerivative = 0x208;
                public const long m_flOutputMax = 0x204;
                public const long m_flOutputMin = 0x200;
                public const long m_nInputField = 0x1F0;
                public const long m_flInterpRate = 0x20C;
                public const long m_nOutputField = 0x1F4;
                public const long m_nInputControlPoint = 0x1E8;
                public const long m_nOutputControlPoint = 0x1EC;
            }
            public static partial class C_OP_RemapScalar {
                public const long m_bOldCode = 0x1F8;
                public const long m_flInputMax = 0x1EC;
                public const long m_flInputMin = 0x1E8;
                public const long m_flOutputMax = 0x1F4;
                public const long m_flOutputMin = 0x1F0;
                public const long m_nFieldInput = 0x1E0;
                public const long m_nFieldOutput = 0x1E4;
            }
            public static partial class C_OP_RenderBlobs {
                public const long m_nScaleCP = 0x6A0;
                public const long m_cubeWidth = 0x230;
                public const long m_hMaterial = 0x6D8;
                public const long m_MaterialVars = 0x6A8;
                public const long m_cutoffRadius = 0x3A8;
                public const long m_renderRadius = 0x520;
                public const long m_nIndexCountKb = 0x69C;
                public const long m_nVertexCountKb = 0x698;
            }
            public static partial class C_OP_RenderRopes {
                public const long m_bClampV = 0x34EC;
                public const long m_flMaxSize = 0x2EE0;
                public const long m_flMinSize = 0x2EDC;
                public const long m_nScaleCP1 = 0x34F0;
                public const long m_nScaleCP2 = 0x34F4;
                public const long m_bClosedLoop = 0x3511;
                public const long m_flTessScale = 0x307C;
                public const long m_nSplitField = 0x3514;
                public const long m_flEndFadeDot = 0x2EF0;
                public const long m_bDrawAsOpaque = 0x3524;
                public const long m_bReverseOrder = 0x3510;
                public const long m_flEndFadeSize = 0x2EE8;
                public const long m_flRadiusTaper = 0x3070;
                public const long m_flStartFadeDot = 0x2EEC;
                public const long m_flStartFadeSize = 0x2EE4;
                public const long m_nMaxTesselation = 0x3078;
                public const long m_nMinTesselation = 0x3074;
                public const long m_bGenerateNormals = 0x3525;
                public const long m_bSortBySegmentID = 0x3518;
                public const long m_flTextureVOffset = 0x3370;
                public const long m_nOrientationType = 0x351C;
                public const long m_flSubPixelAAScale = 0x2EF8;
                public const long m_nTextureVParamsCP = 0x34E8;
                public const long m_flTextureVWorldSize = 0x3080;
                public const long m_flTextureVScrollRate = 0x31F8;
                public const long m_bEnableFadingAndClamping = 0x2ED8;
                public const long m_nVectorFieldForOrientation = 0x3520;
                public const long m_bUseScalarForTextureCoordinate = 0x3505;
                public const long m_nScalarFieldForTextureCoordinate = 0x3508;
                public const long m_flScalarAttributeTextureCoordScale = 0x350C;
                public const long m_flScaleVSizeByControlPointDistance = 0x34F8;
                public const long m_flScaleVOffsetByControlPointDistance = 0x3500;
                public const long m_flScaleVScrollByControlPointDistance = 0x34FC;
            }
            public static partial class C_OP_RenderSound {
                public const long m_nChannel = 0x250;
                public const long m_nPitchField = 0x248;
                public const long m_flPitchScale = 0x238;
                public const long m_nCPReference = 0x254;
                public const long m_nSndLvlField = 0x240;
                public const long m_nVolumeField = 0x24C;
                public const long m_pszSoundName = 0x258;
                public const long m_flSndLvlScale = 0x234;
                public const long m_flVolumeScale = 0x23C;
                public const long m_nDurationField = 0x244;
                public const long m_flDurationScale = 0x230;
                public const long m_bSuppressStopSoundEvent = 0x358;
            }
            public static partial class C_OP_SetVariable {
                public const long m_vecInput = 0x2B8;
                public const long m_floatInput = 0x990;
                public const long m_positionOffset = 0x2A0;
                public const long m_rotationOffset = 0x2AC;
                public const long m_transformInput = 0x238;
                public const long m_variableReference = 0x1E8;
            }
            public static partial class C_OP_VectorNoise {
                public const long m_bOffset = 0x201;
                public const long m_bAdditive = 0x200;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_vecOutputMax = 0x1F0;
                public const long m_vecOutputMin = 0x1E4;
                public const long m_fl4NoiseScale = 0x1FC;
                public const long m_flNoiseAnimationTimeScale = 0x204;
            }
            public static partial class ModelReference_t {
                public const long m_model = 0x0;
                public const long m_flRelativeProbabilityOfSpawn = 0x8;
            }
            public static partial class CParticleFunction {
                public const long m_Notes = 0x1C0;
                public const long m_nToolsState = 0x184;
                public const long m_flOpStrength = 0x8;
                public const long m_nOpEndCapState = 0x180;
                public const long m_bDisableOperator = 0x1BA;
                public const long m_flOpTimeScaleMax = 0x1B4;
                public const long m_flOpTimeScaleMin = 0x1B0;
                public const long m_nOpTimeScaleSeed = 0x1AC;
                public const long m_flOpEndFadeInTime = 0x18C;
                public const long m_flOpTimeOffsetMax = 0x1A4;
                public const long m_flOpTimeOffsetMin = 0x1A0;
                public const long m_nOpTimeOffsetSeed = 0x1A8;
                public const long m_flOpEndFadeOutTime = 0x194;
                public const long m_flOpStartFadeInTime = 0x188;
                public const long m_bNormalizeToStopTime = 0x19C;
                public const long m_flOpStartFadeOutTime = 0x190;
                public const long m_flOpFadeOscillatePeriod = 0x198;
            }
            public static partial class C_INIT_SkyVisCull {
                public const long m_nTraceSet = 0x8C0;
                public const long m_bCullOnSky = 0x8C4;
                public const long m_vecTestDir = 0x1E8;
            }
            public static partial class C_OP_DensityForce {
                public const long m_flForceScale = 0x1F4;
                public const long m_flRadiusScale = 0x1F0;
                public const long m_flTargetDensity = 0x1F8;
            }
            public static partial class C_OP_DistanceCull {
                public const long m_flDistance = 0x1F0;
                public const long m_nAttribute = 0x36C;
                public const long m_bCullInside = 0x368;
                public const long m_nControlPoint = 0x1E0;
                public const long m_vecPointOffset = 0x1E4;
            }
            public static partial class C_OP_FadeInSimple {
                public const long m_flFadeInTime = 0x1E0;
                public const long m_nFieldOutput = 0x1E4;
            }
            public static partial class C_OP_HSVShiftToCP {
                public const long m_nColorCP = 0x1E8;
                public const long m_nOutputCP = 0x1F0;
                public const long m_DefaultHSVColor = 0x1F4;
                public const long m_nColorGemEnableCP = 0x1EC;
            }
            public static partial class C_OP_MoveToHitbox {
                public const long m_bUseBones = 0x338;
                public const long m_nLerpType = 0x33C;
                public const long m_modelInput = 0x1E0;
                public const long m_HitboxSetName = 0x2B8;
                public const long m_flPrevPosScale = 0x2B4;
                public const long m_transformInput = 0x240;
                public const long m_flInterpolation = 0x340;
                public const long m_flLifeTimeLerpEnd = 0x2B0;
                public const long m_flLifeTimeLerpStart = 0x2AC;
            }
            public static partial class C_OP_NoiseEmitter {
                public const long m_bAbsVal = 0x200;
                public const long m_flOffset = 0x204;
                public const long m_bAbsValInv = 0x201;
                public const long m_flOutputMax = 0x20C;
                public const long m_flOutputMin = 0x208;
                public const long m_flStartTime = 0x1EC;
                public const long m_flNoiseScale = 0x210;
                public const long m_vecOffsetLoc = 0x218;
                public const long m_flEmissionScale = 0x1F0;
                public const long m_flWorldTimeScale = 0x224;
                public const long m_nWorldNoisePoint = 0x1FC;
                public const long m_flWorldNoiseScale = 0x214;
                public const long m_flEmissionDuration = 0x1E8;
                public const long m_nScaleControlPoint = 0x1F4;
                public const long m_nScaleControlPointField = 0x1F8;
            }
            public static partial class C_OP_PositionLock {
                public const long m_flRange = 0x260;
                public const long m_bLockRot = 0x3E8;
                public const long m_vecScale = 0x3F0;
                public const long m_flRangeBias = 0x268;
                public const long m_nFieldOutput = 0xAC8;
                public const long m_flEndTime_exp = 0x25C;
                public const long m_flEndTime_max = 0x258;
                public const long m_flEndTime_min = 0x254;
                public const long m_TransformInput = 0x1E0;
                public const long m_flPrevPosScale = 0x3E4;
                public const long m_flJumpThreshold = 0x3E0;
                public const long m_flStartTime_exp = 0x250;
                public const long m_flStartTime_max = 0x24C;
                public const long m_flStartTime_min = 0x248;
                public const long m_nFieldOutputPrev = 0xACC;
            }
            public static partial class C_OP_RenderCables {
                public const long m_hMaterial = 0xC00;
                public const long m_nRoundness = 0x14F8;
                public const long m_flTessScale = 0x14EC;
                public const long m_flAlphaScale = 0x3A8;
                public const long m_flRadiusScale = 0x230;
                public const long m_vecColorScale = 0x520;
                public const long m_bDrawCableCaps = 0x14E0;
                public const long m_flCapRoundness = 0x14E4;
                public const long m_MaterialVecVars = 0x1588;
                public const long m_nColorBlendType = 0xBF8;
                public const long m_nMaxTesselation = 0x14F4;
                public const long m_nMinTesselation = 0x14F0;
                public const long m_LightingTransform = 0x1500;
                public const long m_MaterialFloatVars = 0x1568;
                public const long m_flCapOffsetAmount = 0x14E8;
                public const long m_flColorMapOffsetU = 0x1078;
                public const long m_flColorMapOffsetV = 0xF00;
                public const long m_flNormalMapOffsetU = 0x1368;
                public const long m_flNormalMapOffsetV = 0x11F0;
                public const long m_nForceRoundnessFixed = 0x14FC;
                public const long m_nTextureRepetitionMode = 0xC08;
                public const long m_flTextureRepeatsPerSegment = 0xC10;
                public const long m_bOnlyRenderInEffectsBloomPass = 0x14FD;
                public const long m_flTextureRepeatsCircumference = 0xD88;
            }
            public static partial class C_OP_RenderLights {
                public const long m_flMaxSize = 0x248;
                public const long m_flMinSize = 0x244;
                public const long m_bAnimateInFPS = 0x240;
                public const long m_flEndFadeSize = 0x250;
                public const long m_nAnimationType = 0x23C;
                public const long m_flAnimationRate = 0x238;
                public const long m_flStartFadeSize = 0x24C;
            }
            public static partial class C_OP_RenderModels {
                public const long m_nLOD = 0x1FC0;
                public const long m_nSkin = 0x1AE0;
                public const long m_bOrientZ = 0x259;
                public const long m_ModelList = 0x238;
                public const long m_bAnimated = 0x16F8;
                public const long m_modelInput = 0x1F60;
                public const long m_bLocalScale = 0x16F0;
                public const long m_flRollScale = 0x24C8;
                public const long m_ActivityName = 0x1888;
                public const long m_EconSlotName = 0x1FC4;
                public const long m_MaterialVars = 0x1C58;
                public const long m_SequenceName = 0x1988;
                public const long m_flAlphaScale = 0x2350;
                public const long m_nAlpha2Field = 0x2640;
                public const long m_bCenterOffset = 0x25A;
                public const long m_bIgnoreNormal = 0x258;
                public const long m_bIgnoreRadius = 0x1010;
                public const long m_bSuppressTint = 0x20C5;
                public const long m_flRadiusScale = 0x21D8;
                public const long m_nModelScaleCP = 0x1014;
                public const long m_strLightStyle = 0x2D28;
                public const long m_vecColorScale = 0x2648;
                public const long m_bAcceptsDecals = 0x20CE;
                public const long m_bOriginalModel = 0x20C4;
                public const long m_flRenderFilter = 0x1C70;
                public const long m_nSizeCullBloat = 0x16F4;
                public const long m_nSubModelField = 0x254;
                public const long m_vecLocalOffset = 0x260;
                public const long m_ClothEffectName = 0x1A8A;
                public const long m_bDisableShadows = 0x20CC;
                public const long m_flAnimationRate = 0x1700;
                public const long m_nAnimationField = 0x1880;
                public const long m_nBodyGroupField = 0x250;
                public const long m_nColorBlendType = 0x2D20;
                public const long m_bManualAnimFrame = 0x187B;
                public const long m_bResetAnimOnStop = 0x187A;
                public const long m_flLightStyleTime = 0x2D30;
                public const long m_vecLocalRotation = 0x938;
                public const long m_hOverrideMaterial = 0x1AD0;
                public const long m_nManualFrameField = 0x1884;
                public const long m_szRenderAttribute = 0x20D2;
                public const long m_vecComponentScale = 0x1018;
                public const long m_nSubModelFieldType = 0x20C8;
                public const long m_bScaleAnimationRate = 0x1878;
                public const long m_bDisableDepthPrepass = 0x20CD;
                public const long m_nAnimationScaleField = 0x187C;
                public const long m_bEnableClothSimulation = 0x1A88;
                public const long m_bForceLoopingAnimation = 0x1879;
                public const long m_flManualModelSelection = 0x1DE8;
                public const long m_bDoNotDrawInParticlePass = 0x20D0;
                public const long m_bAllowApproximateTransforms = 0x20D1;
                public const long m_bDisableClothGroundCollision = 0x1A89;
                public const long m_bUseMixedResolutionRendering = 0x232;
                public const long m_bOnlyRenderInEffectsBloomPass = 0x230;
                public const long m_bOnlyRenderInEffectsWaterPass = 0x231;
                public const long m_bOverrideTranslucentMaterials = 0x1AD8;
                public const long m_bOnlyRenderInEffecsGameOverlay = 0x233;
                public const long m_bForceDrawInterlevedWithSiblings = 0x20CF;
            }
            public static partial class C_OP_RenderPoints {
                public const long m_hMaterial = 0x230;
            }
            public static partial class C_OP_RenderTrails {
                public const long m_bIgnoreDT = 0x3370;
                public const long m_flMaxLength = 0x3368;
                public const long m_flMinLength = 0x336C;
                public const long m_flEndFadeDot = 0x3360;
                public const long m_flLengthScale = 0x3378;
                public const long m_flRadiusTaper = 0x3D48;
                public const long m_flForwardShift = 0x4718;
                public const long m_flStartFadeDot = 0x335C;
                public const long m_nPrevPntSource = 0x3364;
                public const long m_nVertCropField = 0x4714;
                public const long m_nHorizCropField = 0x4710;
                public const long m_flHeadAlphaScale = 0x3BD0;
                public const long m_flTailAlphaScale = 0x4598;
                public const long m_flRadiusHeadTaper = 0x3380;
                public const long m_vecHeadColorScale = 0x34F8;
                public const long m_vecTailColorScale = 0x3EC0;
                public const long m_flLengthFadeInTime = 0x337C;
                public const long m_bFlipUVBasedOnPitchYaw = 0x471C;
                public const long m_bEnableFadingAndClamping = 0x3358;
                public const long m_flConstrainRadiusToLengthRatio = 0x3374;
            }
            public static partial class C_OP_RotateVector {
                public const long m_flScale = 0x208;
                public const long m_bNormalize = 0x204;
                public const long m_flRotRateMax = 0x200;
                public const long m_flRotRateMin = 0x1FC;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_vecRotAxisMax = 0x1F0;
                public const long m_vecRotAxisMin = 0x1E4;
            }
            public static partial class C_OP_SetUserEvent {
                public const long m_flInput = 0x1E0;
                public const long m_flRisingEdge = 0x358;
                public const long m_flFallingEdge = 0x4D8;
                public const long m_nRisingEventType = 0x4D0;
                public const long m_nFallingEventType = 0x650;
            }
            public static partial class C_OP_TeleportBeam {
                public const long m_flAlpha = 0x210;
                public const long m_nCPMisc = 0x1E8;
                public const long m_nCPColor = 0x1EC;
                public const long m_vGravity = 0x1F8;
                public const long m_flArcSpeed = 0x20C;
                public const long m_nCPPosition = 0x1E0;
                public const long m_nCPVelocity = 0x1E4;
                public const long m_flSegmentBreak = 0x208;
                public const long m_nCPExtraArcData = 0x1F4;
                public const long m_nCPInvalidColor = 0x1F0;
                public const long m_flArcMaxDuration = 0x204;
            }
            public static partial class PointDefinition_t {
                public const long m_vOffset = 0x8;
                public const long m_bLocalCoords = 0x4;
                public const long m_nControlPoint = 0x0;
            }
            public static partial class TextureControls_t {
                public const long m_bClampUVs = 0xA49;
                public const long m_flZoomScale = 0x758;
                public const long m_flDistortion = 0x8D0;
                public const long m_nPerParticleZoom = 0xA60;
                public const long m_bRandomizeOffsets = 0xA48;
                public const long m_nPerParticleBlend = 0xA4C;
                public const long m_nPerParticleScale = 0xA50;
                public const long m_nPerParticleOffsetU = 0xA54;
                public const long m_nPerParticleOffsetV = 0xA58;
                public const long m_flFinalTextureScaleU = 0x0;
                public const long m_flFinalTextureScaleV = 0x178;
                public const long m_nPerParticleRotation = 0xA5C;
                public const long m_flFinalTextureOffsetU = 0x2F0;
                public const long m_flFinalTextureOffsetV = 0x468;
                public const long m_nPerParticleDistortion = 0xA64;
                public const long m_flFinalTextureUVRotation = 0x5E0;
            }
            public static partial class CBaseTrailRenderer {
                public const long m_bClampV = 0x3350;
                public const long m_flMaxSize = 0x2EE4;
                public const long m_flMinSize = 0x2EE0;
                public const long m_flEndFadeSize = 0x3060;
                public const long m_flStartFadeSize = 0x2EE8;
                public const long m_nOrientationType = 0x2ED8;
                public const long m_flSubPixelAAScale = 0x31D8;
                public const long m_nOrientationControlPoint = 0x2EDC;
            }
            public static partial class CPulseCell_Unknown {
                public const long m_UnknownKeys = 0x48;
            }
            public static partial class CPulse_ResumePoint {

            }
            public static partial class C_INIT_GlobalScale {
                public const long m_flScale = 0x1E8;
                public const long m_bScaleRadius = 0x1F4;
                public const long m_bScalePosition = 0x1F5;
                public const long m_bScaleVelocity = 0x1F6;
                public const long m_nControlPointNumber = 0x1F0;
                public const long m_nScaleControlPointNumber = 0x1EC;
            }
            public static partial class C_INIT_RandomAlpha {
                public const long m_nAlphaMax = 0x1F0;
                public const long m_nAlphaMin = 0x1EC;
                public const long m_nFieldOutput = 0x1E8;
                public const long m_flAlphaRandExponent = 0x1FC;
            }
            public static partial class C_INIT_RandomColor {
                public const long m_TintMax = 0x210;
                public const long m_TintMin = 0x20C;
                public const long m_nTintCP = 0x21C;
                public const long m_ColorMax = 0x208;
                public const long m_ColorMin = 0x204;
                public const long m_flTintPerc = 0x214;
                public const long m_nFieldOutput = 0x220;
                public const long m_nTintBlendMode = 0x224;
                public const long m_flUpdateThreshold = 0x218;
                public const long m_flLightAmplification = 0x228;
            }
            public static partial class C_OP_BasicMovement {
                public const long m_fDrag = 0x8B8;
                public const long m_Gravity = 0x1E0;
                public const long m_bUseNewCode = 0xEA4;
                public const long m_massControls = 0xA30;
                public const long m_nMaxConstraintPasses = 0xEA0;
            }
            public static partial class C_OP_BoxConstraint {
                public const long m_nCP = 0xF90;
                public const long m_vecMax = 0x8B8;
                public const long m_vecMin = 0x1E0;
                public const long m_bLocalSpace = 0xF94;
                public const long m_bAccountForRadius = 0xF95;
            }
            public static partial class C_OP_ClientPhysics {
                public const long m_bDeleteSim = 0x53A;
                public const long m_bStartAsleep = 0x238;
                public const long m_nForcedSimId = 0x540;
                public const long m_nControlPoint = 0x53C;
                public const long m_bKillParticles = 0x539;
                public const long m_strPhysicsType = 0x230;
                public const long m_nColorBlendType = 0x544;
                public const long m_nMaxParticleCount = 0x534;
                public const long m_flPlayerWakeRadius = 0x240;
                public const long m_flVehicleWakeRadius = 0x3B8;
                public const long m_nForcedStatusEffects = 0x548;
                public const long m_nNoCollisionAttribute = 0x54C;
                public const long m_nZeroGravityAttribute = 0x550;
                public const long m_bRespectExclusionVolumes = 0x538;
                public const long m_bUseHighQualitySimulation = 0x530;
            }
            public static partial class C_OP_FadeOutSimple {
                public const long m_nFieldOutput = 0x1E4;
                public const long m_flFadeOutTime = 0x1E0;
            }
            public static partial class C_OP_QuantizeFloat {
                public const long m_InputValue = 0x1E0;
                public const long m_nOutputField = 0x358;
            }
            public static partial class C_OP_RenderSprites {
                public const long m_bOutline = 0x37CC;
                public const long m_flMaxSize = 0x31D8;
                public const long m_flMinSize = 0x3060;
                public const long m_bSoftEdges = 0x37C1;
                public const long m_OutlineColor = 0x37D0;
                public const long m_flEndFadeDot = 0x37BC;
                public const long m_flEndFadeSize = 0x3640;
                public const long m_flOutlineEnd0 = 0x37E0;
                public const long m_flOutlineEnd1 = 0x37E4;
                public const long m_nLightingMode = 0x37E8;
                public const long m_nOutlineAlpha = 0x37D4;
                public const long m_bDistanceAlpha = 0x37C0;
                public const long m_flStartFadeDot = 0x37B8;
                public const long m_flOutlineStart0 = 0x37D8;
                public const long m_flOutlineStart1 = 0x37DC;
                public const long m_flShadowDensity = 0x41BC;
                public const long m_flStartFadeSize = 0x34C8;
                public const long m_bParticleShadows = 0x41B8;
                public const long m_nOrientationType = 0x3054;
                public const long m_flEdgeSoftnessEnd = 0x37C8;
                public const long m_flSubPixelAAScale = 0x3350;
                public const long m_nSequenceOverride = 0x2ED8;
                public const long m_flEdgeSoftnessStart = 0x37C4;
                public const long m_vecLightingOverride = 0x37F0;
                public const long m_flLightingTessellation = 0x3EC8;
                public const long m_bUseYawWithNormalAligned = 0x305C;
                public const long m_flLightingDirectionality = 0x4040;
                public const long m_nOrientationControlPoint = 0x3058;
                public const long m_bSequenceNumbersAreRawSequenceIndices = 0x3050;
            }
            public static partial class C_OP_SetCPtoVector {
                public const long m_nCPInput = 0x1E0;
                public const long m_nFieldOutput = 0x1E4;
            }
            public static partial class C_OP_VelocityDecay {
                public const long m_flMinVelocity = 0x1E0;
            }
            public static partial class MaterialVariable_t {
                public const long m_flScale = 0xC;
                public const long m_strVariable = 0x0;
                public const long m_nVariableField = 0x8;
            }
            public static partial class CPulseCell_BaseFlow {

            }
            public static partial class CPulseCell_BaseLerp {
                public const long m_WakeResume = 0xD8;
            }
            public static partial class CPulseCell_Timeline {
                public const long m_OnFinished = 0xF8;
                public const long m_TimelineEvents = 0xD8;
                public const long m_bWaitForChildOutflows = 0xF0;
            }
            public static partial class C_INIT_CreateOnGrid {
                public const long m_bCenter = 0xABD;
                public const long m_bHollow = 0xABE;
                public const long m_nXCount = 0x1E8;
                public const long m_nYCount = 0x360;
                public const long m_nZCount = 0x4D8;
                public const long m_nXSpacing = 0x650;
                public const long m_nYSpacing = 0x7C8;
                public const long m_nZSpacing = 0x940;
                public const long m_bLocalSpace = 0xABC;
                public const long m_nControlPointNumber = 0xAB8;
            }
            public static partial class C_INIT_DistanceCull {
                public const long m_flDistance = 0x1F0;
                public const long m_bCullInside = 0x368;
                public const long m_nControlPoint = 0x1E8;
            }
            public static partial class C_INIT_NormalOffset {
                public const long m_OffsetMax = 0x1F4;
                public const long m_OffsetMin = 0x1E8;
                public const long m_bNormalize = 0x205;
                public const long m_bLocalCoords = 0x204;
                public const long m_nControlPointNumber = 0x200;
            }
            public static partial class C_INIT_PositionWarp {
                public const long m_bUseCount = 0xFB1;
                public const long m_flWarpTime = 0xFA4;
                public const long m_vecWarpMax = 0x8C0;
                public const long m_vecWarpMin = 0x1E8;
                public const long m_bInvertWarp = 0xFB0;
                public const long m_flPrevPosScale = 0xFAC;
                public const long m_flWarpStartTime = 0xFA8;
                public const long m_nRadiusComponent = 0xFA0;
                public const long m_nControlPointNumber = 0xF9C;
                public const long m_nScaleControlPointNumber = 0xF98;
            }
            public static partial class C_INIT_RandomRadius {
                public const long m_flRadiusMax = 0x1EC;
                public const long m_flRadiusMin = 0x1E8;
                public const long m_flRadiusRandExponent = 0x1F0;
            }
            public static partial class C_INIT_RandomScalar {
                public const long m_flMax = 0x1EC;
                public const long m_flMin = 0x1E8;
                public const long m_flExponent = 0x1F0;
                public const long m_nFieldOutput = 0x1F4;
            }
            public static partial class C_INIT_RandomVector {
                public const long m_vecMax = 0x1F4;
                public const long m_vecMin = 0x1E8;
                public const long m_nFieldOutput = 0x200;
                public const long m_randomnessParameters = 0x204;
            }
            public static partial class C_INIT_StatusEffect {
                public const long m_nDetail2Combo = 0x1E8;
                public const long m_rimLightColor = 0x21C;
                public const long m_specularColor = 0x208;
                public const long m_flAmbientScale = 0x204;
                public const long m_flDetail2Scale = 0x1F0;
                public const long m_flRimLightScale = 0x220;
                public const long m_flSpecularScale = 0x20C;
                public const long m_flDetail2Rotation = 0x1EC;
                public const long m_flEnvMapIntensity = 0x200;
                public const long m_flSpecularExponent = 0x210;
                public const long m_flColorWarpIntensity = 0x1F8;
                public const long m_flDetail2BlendFactor = 0x1F4;
                public const long m_flSpecularBlendToFull = 0x218;
                public const long m_flMetalnessBlendToFull = 0x228;
                public const long m_flSelfIllumBlendToFull = 0x22C;
                public const long m_flDiffuseWarpBlendToFull = 0x1FC;
                public const long m_flSpecularExponentBlendToFull = 0x214;
                public const long m_flReflectionsTintByBaseBlendToNone = 0x224;
            }
            public static partial class C_OP_ColorAdjustHSL {
                public const long m_flHueAdjust = 0x1E0;
                public const long m_flLightnessAdjust = 0x4D0;
                public const long m_flSaturationAdjust = 0x358;
            }
            public static partial class C_OP_CurlNoiseForce {
                public const long m_vecOffset = 0xFA8;
                public const long m_nNoiseType = 0x1F0;
                public const long m_flWorleySeed = 0x1D58;
                public const long m_vecNoiseFreq = 0x1F8;
                public const long m_vecNoiseScale = 0x8D0;
                public const long m_vecOffsetRate = 0x1680;
                public const long m_flWorleyJitter = 0x1ED0;
            }
            public static partial class C_OP_DecayOffscreen {
                public const long m_flOffscreenTime = 0x1E0;
            }
            public static partial class C_OP_ParentVortices {
                public const long m_flForceScale = 0x1F0;
                public const long m_vecTwistAxis = 0x1F4;
                public const long m_bFlipBasedOnYaw = 0x200;
            }
            public static partial class C_OP_RemapSpeedtoCP {
                public const long m_nField = 0x1F0;
                public const long m_bUseDeltaV = 0x204;
                public const long m_flInputMax = 0x1F8;
                public const long m_flInputMin = 0x1F4;
                public const long m_flOutputMax = 0x200;
                public const long m_flOutputMin = 0x1FC;
                public const long m_nInControlPointNumber = 0x1E8;
                public const long m_nOutControlPointNumber = 0x1EC;
            }
            public static partial class C_OP_RenderAsModels {
                public const long m_ModelList = 0x230;
                public const long m_flModelScale = 0x24C;
                public const long m_nSizeCullBloat = 0x260;
                public const long m_bFitToModelSize = 0x250;
                public const long m_bNonUniformScaling = 0x251;
                public const long m_nXAxisScalingAttribute = 0x254;
                public const long m_nYAxisScalingAttribute = 0x258;
                public const long m_nZAxisScalingAttribute = 0x25C;
            }
            public static partial class C_OP_SetGravityToCP {
                public const long m_flScale = 0x1F0;
                public const long m_nCPInput = 0x1E8;
                public const long m_bSetZDown = 0x36A;
                public const long m_nCPOutput = 0x1EC;
                public const long m_bSetPosition = 0x368;
                public const long m_bSetOrientation = 0x369;
            }
            public static partial class IParticleCollection {

            }
            public static partial class CBaseRendererSource2 {
                public const long m_bRefract = 0x2268;
                public const long m_nFogType = 0x1C74;
                public const long m_bTintByFOW = 0x1DF0;
                public const long m_flDepthBias = 0x2AE0;
                public const long m_flFogAmount = 0x1C78;
                public const long m_flRollScale = 0x520;
                public const long m_nShaderType = 0xD7C;
                public const long m_nSortMethod = 0x2C58;
                public const long m_flAlphaScale = 0x3A8;
                public const long m_nAlpha2Field = 0x698;
                public const long m_bAnimateInFPS = 0x1098;
                public const long m_bRefractSolid = 0x2269;
                public const long m_flRadiusScale = 0x230;
                public const long m_stencilTestID = 0x23F4;
                public const long m_vecColorScale = 0x6A0;
                public const long m_flBumpStrength = 0x1078;
                public const long m_flDesaturation = 0x1980;
                public const long m_flDiffuseClamp = 0x1680;
                public const long m_nAnimationType = 0x1094;
                public const long m_stencilWriteID = 0x2475;
                public const long m_bRefract2Passes = 0x226A;
                public const long m_flAddSelfAmount = 0x1808;
                public const long m_flAnimationRate = 0x1090;
                public const long m_flCenterXOffset = 0xD88;
                public const long m_flCenterYOffset = 0xF00;
                public const long m_flDiffuseAmount = 0x1508;
                public const long m_flRefractAmount = 0x2270;
                public const long m_nColorBlendType = 0xD78;
                public const long m_nFeatheringMode = 0x24FC;
                public const long m_bBlendFramesSeq0 = 0x2C5C;
                public const long m_nOutputBlendMode = 0x17FC;
                public const long m_nRefractBlurType = 0x23EC;
                public const long m_vecTexturesInput = 0x1080;
                public const long m_flSelfIllumAmount = 0x1390;
                public const long m_strShaderOverride = 0xD80;
                public const long m_bDisableZBuffering = 0x24F8;
                public const long m_bReverseZBuffering = 0x24F7;
                public const long m_bTintByGlobalLight = 0x1DF1;
                public const long m_flFeatheringFilter = 0x27F0;
                public const long m_flOverbrightFactor = 0x1AF8;
                public const long m_nRefractBlurRadius = 0x23E8;
                public const long m_bStencilTestExclude = 0x2474;
                public const long m_flFeatheringMaxDist = 0x2678;
                public const long m_flFeatheringMinDist = 0x2500;
                public const long m_nAlphaReferenceType = 0x1DFC;
                public const long m_flMotionVectorScaleU = 0x10A0;
                public const long m_flMotionVectorScaleV = 0x1218;
                public const long m_nCropTextureOverride = 0x107C;
                public const long m_nHSVShiftControlPoint = 0x1C70;
                public const long m_nLightingControlPoint = 0x17F8;
                public const long m_bWriteStencilOnDepthFail = 0x24F6;
                public const long m_bWriteStencilOnDepthPass = 0x24F5;
                public const long m_flAlphaReferenceSoftness = 0x1E00;
                public const long m_bGammaCorrectVertexColors = 0x1800;
                public const long m_flFeatheringDepthMapFilter = 0x2968;
                public const long m_nPerParticleAlphaRefWindow = 0x1DF8;
                public const long m_nPerParticleAlphaReference = 0x1DF4;
                public const long m_bSaturateColorPreAlphaBlend = 0x1801;
                public const long m_bUseMixedResolutionRendering = 0x23F2;
                public const long m_flSourceAlphaValueToMapToOne = 0x20F0;
                public const long m_bOnlyRenderInEffectsBloomPass = 0x23F0;
                public const long m_bOnlyRenderInEffectsWaterPass = 0x23F1;
                public const long m_flSourceAlphaValueToMapToZero = 0x1F78;
                public const long m_bMaxLuminanceBlendingSequence0 = 0x2C5D;
                public const long m_bOnlyRenderInEffecsGameOverlay = 0x23F3;
            }
            public static partial class CPulseCell_BaseState {

            }
            public static partial class CPulseCell_BaseValue {

            }
            public static partial class CPulse_InvokeBinding {
                public const long m_FuncName = 0x30;
                public const long m_nSrcChunk = 0x44;
                public const long m_nCellIndex = 0x40;
                public const long m_RegisterMap = 0x0;
                public const long m_nSrcInstruction = 0x48;
            }
            public static partial class C_INIT_CreateFromCPs {
                public const long m_nMaxCP = 0x1F0;
                public const long m_nMinCP = 0x1EC;
                public const long m_nIncrement = 0x1E8;
                public const long m_nDynamicCPCount = 0x1F8;
            }
            public static partial class C_INIT_CreateOnModel {
                public const long m_bUseMesh = 0x1272;
                public const long m_bUseBones = 0x1271;
                public const long m_modelInput = 0x1E8;
                public const long m_flShellSize = 0x1278;
                public const long m_bLocalCoords = 0x1270;
                public const long m_HitboxSetName = 0x11F0;
                public const long m_nForceInModel = 0x2B0;
                public const long m_bScaleToVolume = 0x2B4;
                public const long m_flBoneVelocity = 0xB10;
                public const long m_nDesiredHitbox = 0x2B8;
                public const long m_transformInput = 0x248;
                public const long m_vecHitBoxScale = 0x438;
                public const long m_vecDirectionBias = 0xB18;
                public const long m_bEvenDistribution = 0x2B5;
                public const long m_flMaxBoneVelocity = 0xB14;
                public const long m_nHitboxValueFromControlPointIndex = 0x430;
            }
            public static partial class C_INIT_CreationNoise {
                public const long m_bAbsVal = 0x1EC;
                public const long m_flOffset = 0x1F0;
                public const long m_bAbsValInv = 0x1ED;
                public const long m_flOutputMax = 0x1F8;
                public const long m_flOutputMin = 0x1F4;
                public const long m_flNoiseScale = 0x1FC;
                public const long m_nFieldOutput = 0x1E8;
                public const long m_vecOffsetLoc = 0x204;
                public const long m_flNoiseScaleLoc = 0x200;
                public const long m_flWorldTimeScale = 0x210;
            }
            public static partial class C_INIT_QuantizeFloat {
                public const long m_InputValue = 0x1E8;
                public const long m_nOutputField = 0x360;
            }
            public static partial class C_INIT_RandomYawFlip {
                public const long m_flPercent = 0x1E8;
            }
            public static partial class C_INIT_ScaleVelocity {
                public const long m_vecScale = 0x1E8;
            }
            public static partial class C_OP_CPVelocityForce {
                public const long m_flScale = 0x1F8;
                public const long m_nControlPointNumber = 0x1F0;
            }
            public static partial class C_OP_CollideWithSelf {
                public const long m_flRadiusScale = 0x1E0;
                public const long m_flMinimumSpeed = 0x358;
            }
            public static partial class C_OP_DecayClampCount {
                public const long m_nCount = 0x1E0;
            }
            public static partial class C_OP_GameLiquidSpill {
                public const long m_flRadius = 0x520;
                public const long m_flExpirationTime = 0x3A8;
                public const long m_nAmountAttribute = 0x69C;
                public const long m_bCheckExposedToSky = 0x698;
                public const long m_flLiquidContentsField = 0x230;
            }
            public static partial class C_OP_LagCompensation {
                public const long m_nLatencyCP = 0x1E4;
                public const long m_nLatencyCPField = 0x1E8;
                public const long m_nDesiredVelocityCP = 0x1E0;
                public const long m_nDesiredVelocityCPField = 0x1EC;
            }
            public static partial class C_OP_LockToPointList {
                public const long m_pointList = 0x1E8;
                public const long m_bClosedLoop = 0x201;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_bPlaceAlongPath = 0x200;
                public const long m_nNumPointsAlongPath = 0x204;
            }
            public static partial class C_OP_MaintainEmitter {
                public const long m_flScale = 0x4F8;
                public const long m_flStartTime = 0x360;
                public const long m_flEmissionRate = 0x4E0;
                public const long m_bFinalEmitOnStop = 0x4F1;
                public const long m_strSnapshotSubset = 0x4E8;
                public const long m_flEmissionDuration = 0x368;
                public const long m_bEmitInstantaneously = 0x4F0;
                public const long m_nParticlesToMaintain = 0x1E8;
                public const long m_nSnapshotControlPoint = 0x4E4;
            }
            public static partial class C_OP_NormalizeVector {
                public const long m_flScale = 0x1E4;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_Orient2DRelToCP {
                public const long m_nCP = 0x1E8;
                public const long m_flRotOffset = 0x1E0;
                public const long m_nFieldOutput = 0x1EC;
                public const long m_flSpinStrength = 0x1E4;
            }
            public static partial class C_OP_OscillateScalar {
                public const long m_nField = 0x1F0;
                public const long m_RateMax = 0x1E4;
                public const long m_RateMin = 0x1E0;
                public const long m_flOscAdd = 0x20C;
                public const long m_flOscMult = 0x208;
                public const long m_FrequencyMax = 0x1EC;
                public const long m_FrequencyMin = 0x1E8;
                public const long m_bProportional = 0x1F4;
                public const long m_flEndTime_max = 0x204;
                public const long m_flEndTime_min = 0x200;
                public const long m_bProportionalOp = 0x1F5;
                public const long m_flStartTime_max = 0x1FC;
                public const long m_flStartTime_min = 0x1F8;
            }
            public static partial class C_OP_OscillateVector {
                public const long m_nField = 0x210;
                public const long m_RateMax = 0x1EC;
                public const long m_RateMin = 0x1E0;
                public const long m_bOffset = 0x216;
                public const long m_flOscAdd = 0x3A0;
                public const long m_flOscMult = 0x228;
                public const long m_flRateScale = 0x518;
                public const long m_FrequencyMax = 0x204;
                public const long m_FrequencyMin = 0x1F8;
                public const long m_bProportional = 0x214;
                public const long m_flEndTime_max = 0x224;
                public const long m_flEndTime_min = 0x220;
                public const long m_bProportionalOp = 0x215;
                public const long m_flStartTime_max = 0x21C;
                public const long m_flStartTime_min = 0x218;
            }
            public static partial class C_OP_PinParticleToCP {
                public const long m_flAge = 0xD38;
                public const long m_vecOffset = 0x1E8;
                public const long m_bOffsetLocal = 0x8C0;
                public const long m_flBreakSpeed = 0xBC0;
                public const long m_flBreakValue = 0xEB8;
                public const long m_nPinBreakType = 0xA40;
                public const long m_flBreakDistance = 0xA48;
                public const long m_flInterpolation = 0x1030;
                public const long m_nParticleNumber = 0x8C8;
                public const long m_nParticleSelection = 0x8C4;
                public const long m_nControlPointNumber = 0x1E0;
                public const long m_bRetainInitialVelocity = 0x11A8;
                public const long m_nBreakControlPointNumber = 0xEB0;
                public const long m_nBreakControlPointNumber2 = 0xEB4;
            }
            public static partial class C_OP_RemapCPtoScalar {
                public const long m_nField = 0x1E8;
                public const long m_nCPInput = 0x1E0;
                public const long m_flEndTime = 0x200;
                public const long m_flInputMax = 0x1F0;
                public const long m_flInputMin = 0x1EC;
                public const long m_nSetMethod = 0x208;
                public const long m_flOutputMax = 0x1F8;
                public const long m_flOutputMin = 0x1F4;
                public const long m_flStartTime = 0x1FC;
                public const long m_flInterpRate = 0x204;
                public const long m_nFieldOutput = 0x1E4;
            }
            public static partial class C_OP_RemapCPtoVector {
                public const long m_bOffset = 0x22C;
                public const long m_nCPInput = 0x1E0;
                public const long m_flEndTime = 0x220;
                public const long m_vInputMax = 0x1F8;
                public const long m_vInputMin = 0x1EC;
                public const long m_nSetMethod = 0x228;
                public const long m_vOutputMax = 0x210;
                public const long m_vOutputMin = 0x204;
                public const long m_bAccelerate = 0x22D;
                public const long m_flStartTime = 0x21C;
                public const long m_flInterpRate = 0x224;
                public const long m_nFieldOutput = 0x1E4;
                public const long m_nLocalSpaceCP = 0x1E8;
            }
            public static partial class C_OP_RemapVectortoCP {
                public const long m_nFieldInput = 0x1E4;
                public const long m_nParticleNumber = 0x1E8;
                public const long m_nOutControlPointNumber = 0x1E0;
            }
            public static partial class C_OP_RenderLightBeam {
                public const long m_flRange = 0x1080;
                public const long m_flSkirt = 0xF08;
                public const long m_flThickness = 0x11F8;
                public const long m_nMaxAllowed = 0x230;
                public const long m_vColorBlend = 0x238;
                public const long m_bCastShadows = 0xD88;
                public const long m_flBounceScale = 0xD90;
                public const long m_strLightStyle = 0x918;
                public const long m_bDynamicBounce = 0xD89;
                public const long m_flRenderFilter = 0x1EB8;
                public const long m_nColorBlendType = 0x910;
                public const long m_flInnerConeAngle = 0x1370;
                public const long m_flLightStyleTime = 0x920;
                public const long m_flOuterConeAngle = 0x14E8;
                public const long m_nFogLightingMode = 0x1D38;
                public const long m_bDebugOrientation = 0x2030;
                public const long m_flFogContribution = 0x1D40;
                public const long m_vecConeRotationOffset = 0x1660;
                public const long m_flNumberOfLightsToCreate = 0xC10;
                public const long m_flBrightnessLumensPerMeter = 0xA98;
            }
            public static partial class C_OP_RenderProjected {
                public const long m_flRollScale = 0x6E0;
                public const long m_MaterialVars = 0x3D8;
                public const long m_flAlphaScale = 0x568;
                public const long m_nAlpha2Field = 0x858;
                public const long m_bProjectWater = 0x232;
                public const long m_bProjectWorld = 0x231;
                public const long m_flRadiusScale = 0x3F0;
                public const long m_vecColorScale = 0x860;
                public const long m_bFlipHorizontal = 0x233;
                public const long m_bOrientToNormal = 0x3D4;
                public const long m_nColorBlendType = 0xF38;
                public const long m_bProjectCharacter = 0x230;
                public const long m_flMaterialSelection = 0x258;
                public const long m_flAnimationTimeScale = 0x3D0;
                public const long m_flMaxProjectionDepth = 0x23C;
                public const long m_flMinProjectionDepth = 0x238;
                public const long m_vecProjectedMaterials = 0x240;
                public const long m_bEnableProjectedDepthControls = 0x234;
            }
            public static partial class C_OP_RenderTreeShake {
                public const long m_flRadius = 0x238;
                public const long m_flTwistAmount = 0x248;
                public const long m_flPeakStrength = 0x230;
                public const long m_flRadialAmount = 0x24C;
                public const long m_flShakeDuration = 0x240;
                public const long m_flTransitionTime = 0x244;
                public const long m_nRadiusFieldOverride = 0x23C;
                public const long m_nPeakStrengthFieldOverride = 0x234;
                public const long m_flControlPointOrientationAmount = 0x250;
                public const long m_nControlPointForLinearDirection = 0x254;
            }
            public static partial class C_OP_TurbulenceForce {
                public const long m_vecNoiseAmount0 = 0x200;
                public const long m_vecNoiseAmount1 = 0x20C;
                public const long m_vecNoiseAmount2 = 0x218;
                public const long m_vecNoiseAmount3 = 0x224;
                public const long m_flNoiseCoordScale0 = 0x1F0;
                public const long m_flNoiseCoordScale1 = 0x1F4;
                public const long m_flNoiseCoordScale2 = 0x1F8;
                public const long m_flNoiseCoordScale3 = 0x1FC;
            }
            public static partial class C_OP_TwistAroundAxis {
                public const long m_TwistAxis = 0x1F4;
                public const long m_bLocalSpace = 0x200;
                public const long m_fForceAmount = 0x1F0;
                public const long m_nControlPointNumber = 0x204;
            }
            public static partial class CPulseCell_LimitCount {
                public const long m_nLimitCount = 0x48;
            }
            public static partial class C_INIT_PositionOffset {
                public const long m_OffsetMax = 0x8C0;
                public const long m_OffsetMin = 0x1E8;
                public const long m_bLocalCoords = 0x1000;
                public const long m_bProportional = 0x1001;
                public const long m_TransformInput = 0xF98;
                public const long m_randomnessParameters = 0x1004;
            }
            public static partial class C_INIT_RandomLifeTime {
                public const long m_fLifetimeMax = 0x1EC;
                public const long m_fLifetimeMin = 0x1E8;
                public const long m_fLifetimeRandExponent = 0x1F0;
            }
            public static partial class C_INIT_RandomRotation {

            }
            public static partial class C_INIT_RandomSequence {
                public const long m_bLinear = 0x1F1;
                public const long m_bShuffle = 0x1F0;
                public const long m_WeightedList = 0x1F8;
                public const long m_nSequenceMax = 0x1EC;
                public const long m_nSequenceMin = 0x1E8;
            }
            public static partial class C_INIT_SequenceFromCP {
                public const long m_nCP = 0x1EC;
                public const long m_vecOffset = 0x1F0;
                public const long m_bKillUnused = 0x1E8;
                public const long m_bRadiusScale = 0x1E9;
            }
            public static partial class C_INIT_StatusEffectTf {
                public const long m_flSFXSScale = 0x1FC;
                public const long m_nDetailCombo = 0x218;
                public const long m_flSFXSOffsetX = 0x20C;
                public const long m_flSFXSOffsetY = 0x210;
                public const long m_flSFXSOffsetZ = 0x214;
                public const long m_flSFXSScrollX = 0x200;
                public const long m_flSFXSScrollY = 0x204;
                public const long m_flSFXSScrollZ = 0x208;
                public const long m_flSFXEnvMapAmount = 0x234;
                public const long m_flSFXNormalAmount = 0x1EC;
                public const long m_flSFXSDetailScale = 0x220;
                public const long m_flSFXSUseModelUVs = 0x230;
                public const long m_flSFXSDetailAmount = 0x21C;
                public const long m_flSFXSDetailScrollX = 0x224;
                public const long m_flSFXSDetailScrollY = 0x228;
                public const long m_flSFXSDetailScrollZ = 0x22C;
                public const long m_flSFXColorWarpAmount = 0x1E8;
                public const long m_flSFXMetalnessAmount = 0x1F0;
                public const long m_flSFXRoughnessAmount = 0x1F4;
                public const long m_flSFXSelfIllumAmount = 0x1F8;
            }
            public static partial class C_INIT_VelocityFromCP {
                public const long m_velocityInput = 0x1E8;
                public const long m_bDirectionOnly = 0x92C;
                public const long m_transformInput = 0x8C0;
                public const long m_flVelocityScale = 0x928;
            }
            public static partial class C_INIT_VelocityRandom {
                public const long m_bIgnoreDT = 0x1290;
                public const long m_fSpeedMax = 0x368;
                public const long m_fSpeedMin = 0x1F0;
                public const long m_nControlPointNumber = 0x1E8;
                public const long m_randomnessParameters = 0x1294;
                public const long m_LocalCoordinateSystemSpeedMax = 0xBB8;
                public const long m_LocalCoordinateSystemSpeedMin = 0x4E0;
            }
            public static partial class C_OP_ColorInterpolate {
                public const long m_ColorFade = 0x1E0;
                public const long m_bEaseInOut = 0x1FC;
                public const long m_nFieldOutput = 0x1F8;
                public const long m_flFadeEndTime = 0x1F4;
                public const long m_flFadeStartTime = 0x1F0;
            }
            public static partial class C_OP_EndCapTimedDecay {
                public const long m_flDecayTime = 0x1E0;
            }
            public static partial class C_OP_LerpEndCapScalar {
                public const long m_flOutput = 0x1E4;
                public const long m_flLerpTime = 0x1E8;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_LerpEndCapVector {
                public const long m_vecOutput = 0x1E4;
                public const long m_flLerpTime = 0x1F0;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_PerParticleForce {
                public const long m_nCP = 0xA40;
                public const long m_vForce = 0x368;
                public const long m_flForceScale = 0x1F0;
            }
            public static partial class C_OP_PlanarConstraint {
                public const long m_PlaneNormal = 0x1EC;
                public const long m_bUseOldCode = 0x4F0;
                public const long m_PointOnPlane = 0x1E0;
                public const long m_bGlobalNormal = 0x1FD;
                public const long m_bGlobalOrigin = 0x1FC;
                public const long m_flRadiusScale = 0x200;
                public const long m_nControlPointNumber = 0x1F8;
                public const long m_flMaximumDistanceToCP = 0x378;
            }
            public static partial class C_OP_RampScalarLinear {
                public const long m_nField = 0x220;
                public const long m_RateMax = 0x1E4;
                public const long m_RateMin = 0x1E0;
                public const long m_flEndTime_max = 0x1F4;
                public const long m_flEndTime_min = 0x1F0;
                public const long m_bProportionalOp = 0x224;
                public const long m_flStartTime_max = 0x1EC;
                public const long m_flStartTime_min = 0x1E8;
            }
            public static partial class C_OP_RampScalarSpline {
                public const long m_flBias = 0x1F8;
                public const long m_nField = 0x220;
                public const long m_RateMax = 0x1E4;
                public const long m_RateMin = 0x1E0;
                public const long m_bEaseOut = 0x225;
                public const long m_flEndTime_max = 0x1F4;
                public const long m_flEndTime_min = 0x1F0;
                public const long m_bProportionalOp = 0x224;
                public const long m_flStartTime_max = 0x1EC;
                public const long m_flStartTime_min = 0x1E8;
            }
            public static partial class C_OP_RenderClothForce {

            }
            public static partial class C_OP_RenderOmni2Light {
                public const long m_bFog = 0xF10;
                public const long m_flRange = 0x2A08;
                public const long m_flSkirt = 0x2890;
                public const long m_vNormal = 0x1210;
                public const long m_vTarget = 0x18E8;
                public const long m_flFOVAngle = 0x1FC0;
                public const long m_flFogScale = 0xF18;
                public const long m_nLightType = 0x230;
                public const long m_flBarnShape = 0x2138;
                public const long m_flBarnSoftX = 0x25A0;
                public const long m_flBarnSoftY = 0x2718;
                public const long m_nMaxAllowed = 0x234;
                public const long m_vColorBlend = 0x238;
                public const long m_bCastShadows = 0xD90;
                public const long m_hLightCookie = 0x2E70;
                public const long m_flBounceScale = 0xD98;
                public const long m_strLightStyle = 0x918;
                public const long m_bDynamicBounce = 0xD91;
                public const long m_flBarnNearSizeX = 0x22B0;
                public const long m_flBarnNearSizeY = 0x2428;
                public const long m_nBrightnessUnit = 0xA98;
                public const long m_nColorBlendType = 0x910;
                public const long m_bSphericalCookie = 0x2E78;
                public const long m_flInnerConeAngle = 0x2B80;
                public const long m_flLightStyleTime = 0x920;
                public const long m_flOuterConeAngle = 0x2CF8;
                public const long m_nOrientationType = 0x1208;
                public const long m_flLuminaireRadius = 0x1090;
                public const long m_flBrightnessLumens = 0xAA0;
                public const long m_flBrightnessCandelas = 0xC18;
            }
            public static partial class C_OP_TimeVaryingForce {
                public const long m_EndingForce = 0x204;
                public const long m_StartingForce = 0x1F4;
                public const long m_flEndLerpTime = 0x200;
                public const long m_flStartLerpTime = 0x1F0;
            }
            public static partial class CGeneralRandomRotation {
                public const long m_flDegrees = 0x1EC;
                public const long m_flDegreesMax = 0x1F4;
                public const long m_flDegreesMin = 0x1F0;
                public const long m_nFieldOutput = 0x1E8;
                public const long m_bRandomlyFlipDirection = 0x1FC;
                public const long m_flRotationRandExponent = 0x1F8;
            }
            public static partial class CParticleFunctionForce {

            }
            public static partial class CPulseCell_CursorQueue {
                public const long m_nCursorsAllowedToRunParallel = 0x128;
            }
            public static partial class CPulseCell_FireCursors {
                public const long m_Outflows = 0xD8;
                public const long m_OnFinished = 0xF8;
                public const long m_bWaitForChildOutflows = 0xF0;
            }
            public static partial class CPulseCell_Inflow_Wait {
                public const long m_WakeResume = 0xD8;
            }
            public static partial class CPulseCell_RaceCursors {
                public const long m_Outflows = 0xD8;
                public const long m_OnFinished = 0xF0;
            }
            public static partial class CPulseCell_Value_Curve {
                public const long m_Curve = 0x48;
            }
            public static partial class C_INIT_CreateAlongPath {
                public const long m_fT = 0x360;
                public const long m_PathParams = 0x4E0;
                public const long m_vEndOffset = 0x524;
                public const long m_bSaveOffset = 0x530;
                public const long m_fMaxDistance = 0x1E8;
                public const long m_bUseRandomCPs = 0x520;
            }
            public static partial class C_INIT_CreateWithinBox {
                public const long m_vecMax = 0x8C0;
                public const long m_vecMin = 0x1E8;
                public const long m_bLocalSpace = 0xF9C;
                public const long m_bUseNewCode = 0xFA8;
                public const long m_nControlPointNumber = 0xF98;
                public const long m_randomnessParameters = 0xFA0;
            }
            public static partial class C_INIT_InheritVelocity {
                public const long m_flVelocityScale = 0x1EC;
                public const long m_nControlPointNumber = 0x1E8;
            }
            public static partial class C_INIT_NormalAlignToCP {
                public const long m_transformInput = 0x1E8;
                public const long m_nControlPointAxis = 0x250;
            }
            public static partial class C_INIT_Orient2DRelToCP {
                public const long m_nCP = 0x1E8;
                public const long m_flRotOffset = 0x1F0;
                public const long m_nFieldOutput = 0x1EC;
            }
            public static partial class C_OP_ConstrainDistance {
                public const long m_CenterOffset = 0x538;
                public const long m_fMaxDistance = 0x358;
                public const long m_fMinDistance = 0x1E0;
                public const long m_bGlobalCenter = 0xC10;
                public const long m_nControlPointNumber = 0x4D0;
            }
            public static partial class C_OP_ContinuousEmitter {
                public const long m_flEmitRate = 0x4D8;
                public const long m_nEventType = 0x65C;
                public const long m_flStartTime = 0x360;
                public const long m_flEmissionScale = 0x650;
                public const long m_nLimitPerUpdate = 0x670;
                public const long m_strSnapshotSubset = 0x668;
                public const long m_flEmissionDuration = 0x1E8;
                public const long m_nSnapshotControlPoint = 0x660;
                public const long m_bForceEmitOnLastUpdate = 0x675;
                public const long m_bForceEmitOnFirstUpdate = 0x674;
                public const long m_flScalePerParentParticle = 0x654;
                public const long m_bInitFromKilledParentParticles = 0x658;
            }
            public static partial class C_OP_ControlpointLight {
                public const long m_flScale = 0x1E0;
                public const long m_bUseNormal = 0x6E8;
                public const long m_LightColor1 = 0x6D0;
                public const long m_LightColor2 = 0x6D4;
                public const long m_LightColor3 = 0x6D8;
                public const long m_LightColor4 = 0x6DC;
                public const long m_bLightType1 = 0x6E0;
                public const long m_bLightType2 = 0x6E1;
                public const long m_bLightType3 = 0x6E2;
                public const long m_bLightType4 = 0x6E3;
                public const long m_bUseHLambert = 0x6E9;
                public const long m_vecCPOffset1 = 0x680;
                public const long m_vecCPOffset2 = 0x68C;
                public const long m_vecCPOffset3 = 0x698;
                public const long m_vecCPOffset4 = 0x6A4;
                public const long m_LightZeroDist1 = 0x6B4;
                public const long m_LightZeroDist2 = 0x6BC;
                public const long m_LightZeroDist3 = 0x6C4;
                public const long m_LightZeroDist4 = 0x6CC;
                public const long m_bLightDynamic1 = 0x6E4;
                public const long m_bLightDynamic2 = 0x6E5;
                public const long m_bLightDynamic3 = 0x6E6;
                public const long m_bLightDynamic4 = 0x6E7;
                public const long m_nControlPoint1 = 0x670;
                public const long m_nControlPoint2 = 0x674;
                public const long m_nControlPoint3 = 0x678;
                public const long m_nControlPoint4 = 0x67C;
                public const long m_LightFiftyDist1 = 0x6B0;
                public const long m_LightFiftyDist2 = 0x6B8;
                public const long m_LightFiftyDist3 = 0x6C0;
                public const long m_LightFiftyDist4 = 0x6C8;
                public const long m_bClampLowerRange = 0x6EE;
                public const long m_bClampUpperRange = 0x6EF;
            }
            public static partial class C_OP_EndCapTimedFreeze {
                public const long m_flFreezeTime = 0x1E0;
            }
            public static partial class C_OP_ExternalWindForce {
                public const long m_vecScale = 0x8C8;
                public const long m_bSampleWind = 0xFA0;
                public const long m_bSampleWater = 0xFA1;
                public const long m_bSampleGravity = 0xFA3;
                public const long m_vecGravityForce = 0xFA8;
                public const long m_vecBuoyancyForce = 0x1978;
                public const long m_vecSamplePosition = 0x1F0;
                public const long m_flLocalGravityScale = 0x1688;
                public const long m_flLocalBuoyancyScale = 0x1800;
                public const long m_bDampenNearWaterPlane = 0xFA2;
                public const long m_bUseBasicMovementGravity = 0x1680;
            }
            public static partial class C_OP_GameDecalRenderer {
                public const long m_vecEndPos = 0x928;
                public const long m_nEventType = 0x238;
                public const long m_flDecalSize = 0x1178;
                public const long m_vecStartPos = 0x250;
                public const long m_flTraceBloat = 0x1000;
                public const long m_flDecalRotation = 0x1468;
                public const long m_nCollisionGroup = 0x248;
                public const long m_sDecalGroupName = 0x230;
                public const long m_bNoDecalsOnOwner = 0x1CBB;
                public const long m_bVisualizeTraces = 0x1CBC;
                public const long m_nDecalGroupIndex = 0x12F0;
                public const long m_nInteractionMask = 0x240;
                public const long m_vModulationColor = 0x15E0;
                public const long m_bRandomDecalRotation = 0x1CB9;
                public const long m_bUseGameDefaultDecalSize = 0x1CB8;
                public const long m_bRandomlySelectDecalInGroup = 0x1CBA;
            }
            public static partial class C_OP_InterpolateRadius {
                public const long m_flBias = 0x1F4;
                public const long m_flEndTime = 0x1E4;
                public const long m_flEndScale = 0x1EC;
                public const long m_flStartTime = 0x1E0;
                public const long m_flStartScale = 0x1E8;
                public const long m_bEaseInAndOut = 0x1F0;
            }
            public static partial class C_OP_RemapScalarEndCap {
                public const long m_flInputMax = 0x1EC;
                public const long m_flInputMin = 0x1E8;
                public const long m_flOutputMax = 0x1F4;
                public const long m_flOutputMin = 0x1F0;
                public const long m_nFieldInput = 0x1E0;
                public const long m_nFieldOutput = 0x1E4;
            }
            public static partial class C_OP_RenderGpuImplicit {
                public const long m_nScaleCP = 0x6A8;
                public const long m_fGridSize = 0x240;
                public const long m_hMaterial = 0x6B0;
                public const long m_fRadiusScale = 0x3B8;
                public const long m_nIndexCountKb = 0x238;
                public const long m_nVertexCountKb = 0x234;
                public const long m_fIsosurfaceThreshold = 0x530;
                public const long m_bUsePerParticleRadius = 0x230;
            }
            public static partial class C_OP_RenderScreenShake {
                public const long m_nFilterCP = 0x250;
                public const long m_nRadiusField = 0x240;
                public const long m_flRadiusScale = 0x234;
                public const long m_nDurationField = 0x244;
                public const long m_flDurationScale = 0x230;
                public const long m_nAmplitudeField = 0x24C;
                public const long m_nFrequencyField = 0x248;
                public const long m_flAmplitudeScale = 0x23C;
                public const long m_flFrequencyScale = 0x238;
            }
            public static partial class C_OP_SequenceFromModel {
                public const long m_flInputMax = 0x1F0;
                public const long m_flInputMin = 0x1EC;
                public const long m_nSetMethod = 0x1FC;
                public const long m_flOutputMax = 0x1F8;
                public const long m_flOutputMin = 0x1F4;
                public const long m_nFieldOutput = 0x1E4;
                public const long m_nFieldOutputAnim = 0x1E8;
                public const long m_nControlPointNumber = 0x1E0;
            }
            public static partial class C_OP_SetFromCPSnapshot {
                public const long m_bPrev = 0x671;
                public const long m_bRandom = 0x1FC;
                public const long m_bReverse = 0x1FD;
                public const long m_bSubSample = 0x670;
                public const long m_nRandomSeed = 0x200;
                public const long m_nLocalSpaceCP = 0x1F8;
                public const long m_flInterpolation = 0x4F8;
                public const long m_nAttributeToRead = 0x1F0;
                public const long m_nAttributeToWrite = 0x1F4;
                public const long m_strSnapshotSubset = 0x1E8;
                public const long m_nSnapShotIncrement = 0x380;
                public const long m_nControlPointNumber = 0x1E0;
                public const long m_nSnapShotStartPoint = 0x208;
            }
            public static partial class C_OP_SetSimulationRate {
                public const long m_flSimulationScale = 0x1E8;
            }
            public static partial class C_OP_UpdateLightSource {
                public const long m_vColorTint = 0x1E0;
                public const long m_flRadiusScale = 0x1E8;
                public const long m_flBrightnessScale = 0x1E4;
                public const long m_flMaximumLightingRadius = 0x1F0;
                public const long m_flMinimumLightingRadius = 0x1EC;
                public const long m_flPositionDampingConstant = 0x1F4;
            }
            public static partial class ParticleChildrenInfo_t {
                public const long m_bEndCap = 0xC;
                public const long m_flDelay = 0x8;
                public const long m_ChildRef = 0x0;
                public const long m_nDetailLevel = 0x10;
                public const long m_bDisableChild = 0xD;
            }
            public static partial class ParticlePreviewState_t {
                public const long m_groundType = 0xC;
                public const long m_previewModel = 0x0;
                public const long m_sequenceName = 0x10;
                public const long m_hitboxSetName = 0x20;
                public const long m_vecBodyGroups = 0x30;
                public const long m_vecPreviewWind = 0x64;
                public const long m_flPlaybackSpeed = 0x48;
                public const long m_nModSpecificData = 0x8;
                public const long m_materialGroupName = 0x28;
                public const long m_vecPreviewGravity = 0x58;
                public const long m_bShouldDrawHitboxes = 0x50;
                public const long m_bAnimationNonLooping = 0x54;
                public const long m_bShouldDrawAttachments = 0x51;
                public const long m_flParticleSimulationRate = 0x4C;
                public const long m_bShouldDrawAttachmentNames = 0x52;
                public const long m_bSequenceNameIsAnimClipPath = 0x55;
                public const long m_bShouldDrawControlPointAxes = 0x53;
                public const long m_nFireParticleOnSequenceFrame = 0x18;
            }
            public static partial class SequenceWeightedList_t {
                public const long m_nSequence = 0x0;
                public const long m_flRelativeWeight = 0x4;
            }
            public static partial class CBasePulseGraphInstance {

            }
            public static partial class CPulseCell_Inflow_Yield {
                public const long m_UnyieldResume = 0xD8;
            }
            public static partial class CPulseCell_ReturnValues {

            }
            public static partial class C_INIT_ChaoticAttractor {
                public const long m_flAParm = 0x1E8;
                public const long m_flBParm = 0x1EC;
                public const long m_flCParm = 0x1F0;
                public const long m_flDParm = 0x1F4;
                public const long m_flScale = 0x1F8;
                public const long m_nBaseCP = 0x204;
                public const long m_flSpeedMax = 0x200;
                public const long m_flSpeedMin = 0x1FC;
                public const long m_bUniformSpeed = 0x208;
            }
            public static partial class C_INIT_CreateWithinCone {
                public const long m_flSpeed = 0x540;
                public const long m_flOffset = 0x6B8;
                public const long m_flInnerAngle = 0x250;
                public const long m_flOuterAngle = 0x3C8;
                public const long m_TransformInput = 0x1E8;
                public const long m_bCollapseOffset = 0x830;
                public const long m_randomnessParameters = 0x834;
            }
            public static partial class C_INIT_DistanceToCPInit {
                public const long m_bLOS = 0x7D4;
                public const long m_nStartCP = 0x7D0;
                public const long m_nTraceSet = 0x858;
                public const long m_flInputMax = 0x368;
                public const long m_flInputMin = 0x1F0;
                public const long m_flLOSScale = 0x9D8;
                public const long m_nSetMethod = 0x9DC;
                public const long m_flOutputMax = 0x658;
                public const long m_flOutputMin = 0x4E0;
                public const long m_flRemapBias = 0x9F0;
                public const long m_bActiveRange = 0x9E0;
                public const long m_nFieldOutput = 0x1E8;
                public const long m_flMaxTraceLength = 0x860;
                public const long m_vecDistanceScale = 0x9E4;
                public const long m_CollisionGroupName = 0x7D5;
            }
            public static partial class C_INIT_SequenceLifeTime {
                public const long m_flFramerate = 0x1E8;
            }
            public static partial class C_INIT_SetHitboxToModel {
                public const long m_bUseBones = 0x8DD;
                public const long m_flShellSize = 0x960;
                public const long m_HitboxSetName = 0x8DE;
                public const long m_nForceInModel = 0x1EC;
                public const long m_nDesiredHitbox = 0x1F4;
                public const long m_vecHitBoxScale = 0x1F8;
                public const long m_bMaintainHitbox = 0x8DC;
                public const long m_vecDirectionBias = 0x8D0;
                public const long m_bEvenDistribution = 0x1F0;
                public const long m_nControlPointNumber = 0x1E8;
            }
            public static partial class C_OP_DecayMaintainCount {
                public const long m_flScale = 0x200;
                public const long m_bKillNewest = 0x378;
                public const long m_flDecayDelay = 0x1E4;
                public const long m_bLifespanDecay = 0x1F8;
                public const long m_strSnapshotSubset = 0x1F0;
                public const long m_nParticlesToMaintain = 0x1E0;
                public const long m_nSnapshotControlPoint = 0x1E8;
            }
            public static partial class C_OP_IntraParticleForce {
                public const long m_bUseAABB = 0x208;
                public const long m_flRepulsionMaxDistance = 0x200;
                public const long m_flRepulsionMaxStrength = 0x204;
                public const long m_flRepulsionMinDistance = 0x1FC;
                public const long m_flAttractionMaxDistance = 0x1F4;
                public const long m_flAttractionMaxStrength = 0x1F8;
                public const long m_flAttractionMinDistance = 0x1F0;
            }
            public static partial class C_OP_RampCPLinearRandom {
                public const long m_vecRateMax = 0x1F8;
                public const long m_vecRateMin = 0x1EC;
                public const long m_nOutControlPointNumber = 0x1E8;
            }
            public static partial class C_OP_RenderFlattenGrass {
                public const long m_flRadiusScale = 0x238;
                public const long m_flFlattenStrength = 0x230;
                public const long m_nStrengthFieldOverride = 0x234;
            }
            public static partial class C_OP_RenderStatusEffect {
                public const long m_pTextureEnvMap = 0x260;
                public const long m_pTextureDetail2 = 0x238;
                public const long m_pTextureColorWarp = 0x230;
                public const long m_pTextureDiffuseWarp = 0x240;
                public const long m_pTextureFresnelWarp = 0x250;
                public const long m_pTextureSpecularWarp = 0x258;
                public const long m_pTextureFresnelColorWarp = 0x248;
            }
            public static partial class C_OP_SetFloatCollection {
                public const long m_Lerp = 0x360;
                public const long m_InputValue = 0x1E0;
                public const long m_nSetMethod = 0x35C;
                public const long m_nOutputField = 0x358;
            }
            public static partial class CollisionGroupContext_t {
                public const long m_nCollisionGroupNumber = 0x0;
            }
            public static partial class ControlPointReference_t {
                public const long m_bOffsetInLocalSpace = 0x10;
                public const long m_controlPointNameString = 0x0;
                public const long m_vOffsetFromControlPoint = 0x4;
            }
            public static partial class SignatureOutflow_Resume {

            }
            public static partial class CParticleFunctionEmitter {
                public const long m_nEmitterIndex = 0x1E0;
            }
            public static partial class CPulseCell_Inflow_Method {
                public const long m_Args = 0xA0;
                public const long m_bIsPublic = 0x98;
                public const long m_MethodName = 0x80;
                public const long m_Description = 0x90;
                public const long m_ReturnValues = 0xB0;
            }
            public static partial class CPulseCell_IntervalTimer {
                public const long m_Completed = 0xD8;
                public const long m_OnInterval = 0x120;
            }
            public static partial class CPulseCell_Step_DebugLog {

            }
            public static partial class CPulse_OutflowConnection {
                public const long m_nDestChunk = 0x10;
                public const long m_nInstruction = 0x14;
                public const long m_SourceOutflowName = 0x0;
                public const long m_OutflowRegisterMap = 0x18;
            }
            public static partial class C_INIT_AddVectorToVector {
                public const long m_vecScale = 0x1E8;
                public const long m_vOffsetMax = 0x208;
                public const long m_vOffsetMin = 0x1FC;
                public const long m_nFieldInput = 0x1F8;
                public const long m_nFieldOutput = 0x1F4;
                public const long m_randomnessParameters = 0x214;
            }
            public static partial class C_INIT_CreatePhyllotaxis {
                public const long m_fMinRad = 0x20C;
                public const long m_fRadBias = 0x208;
                public const long m_nScaleCP = 0x1EC;
                public const long m_fDistBias = 0x210;
                public const long m_nComponent = 0x1F0;
                public const long m_fpointAngle = 0x200;
                public const long m_fRadCentCore = 0x1F4;
                public const long m_fRadPerPoint = 0x1F8;
                public const long m_fsizeOverall = 0x204;
                public const long m_bUseOrigRadius = 0x216;
                public const long m_fRadPerPointTo = 0x1FC;
                public const long m_bUseLocalCoords = 0x214;
                public const long m_bUseWithContEmit = 0x215;
                public const long m_nControlPointNumber = 0x1E8;
            }
            public static partial class C_INIT_InitVecCollection {
                public const long m_InputValue = 0x1E8;
                public const long m_nOutputField = 0x8C0;
            }
            public static partial class C_INIT_MoveBetweenPoints {
                public const long m_bTrailBias = 0x944;
                public const long m_flSpeedMax = 0x360;
                public const long m_flSpeedMin = 0x1E8;
                public const long m_flEndOffset = 0x7C8;
                public const long m_flEndSpread = 0x4D8;
                public const long m_flStartOffset = 0x650;
                public const long m_nEndControlPointNumber = 0x940;
            }
            public static partial class C_INIT_RandomTrailLength {
                public const long m_flMaxLength = 0x1EC;
                public const long m_flMinLength = 0x1E8;
                public const long m_flLengthRandExponent = 0x1F0;
            }
            public static partial class C_OP_ConstrainLineLength {
                public const long m_flMaxDistance = 0x1E4;
                public const long m_flMinDistance = 0x1E0;
            }
            public static partial class C_OP_DistanceBetweenVecs {
                public const long m_vecPoint1 = 0x1E8;
                public const long m_vecPoint2 = 0x8C0;
                public const long m_bDeltaTime = 0x157C;
                public const long m_flInputMax = 0x1110;
                public const long m_flInputMin = 0xF98;
                public const long m_nSetMethod = 0x1578;
                public const long m_flOutputMax = 0x1400;
                public const long m_flOutputMin = 0x1288;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_DistanceToTransform {
                public const long m_bLOS = 0x830;
                public const long m_bAdditive = 0x8C5;
                public const long m_nTraceSet = 0x8B4;
                public const long m_flInputMax = 0x360;
                public const long m_flInputMin = 0x1E8;
                public const long m_flLOSScale = 0x8BC;
                public const long m_nSetMethod = 0x8C0;
                public const long m_flOutputMax = 0x650;
                public const long m_flOutputMin = 0x4D8;
                public const long m_bActiveRange = 0x8C4;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_TransformStart = 0x7C8;
                public const long m_flMaxTraceLength = 0x8B8;
                public const long m_vecComponentScale = 0x8C8;
                public const long m_CollisionGroupName = 0x831;
            }
            public static partial class C_OP_DragRelativeToPlane {
                public const long m_flFalloff = 0x358;
                public const long m_bDirectional = 0x4D0;
                public const long m_flDragAtPlane = 0x1E0;
                public const long m_vecPlaneNormal = 0x4D8;
                public const long m_nControlPointNumber = 0xBB0;
            }
            public static partial class C_OP_ModelDampenMovement {
                public const long m_fDrag = 0x940;
                public const long m_bOutside = 0x1E5;
                public const long m_bBoundBox = 0x1E4;
                public const long m_bUseBones = 0x1E6;
                public const long m_vecPosOffset = 0x268;
                public const long m_HitboxSetName = 0x1E7;
                public const long m_nControlPointNumber = 0x1E0;
            }
            public static partial class C_OP_OrientTo2dDirection {
                public const long m_vecInput = 0x1E0;
                public const long m_flRotOffset = 0x8B8;
                public const long m_nFieldOutput = 0x8C0;
                public const long m_flSpinStrength = 0x8BC;
            }
            public static partial class C_OP_QuantizeCPComponent {
                public const long m_nCPOutput = 0x360;
                public const long m_flInputValue = 0x1E8;
                public const long m_flQuantizeValue = 0x368;
                public const long m_nOutVectorField = 0x364;
            }
            public static partial class C_OP_RemapDotProductToCP {
                public const long m_nInputCP1 = 0x1E8;
                public const long m_nInputCP2 = 0x1EC;
                public const long m_nOutputCP = 0x1F0;
                public const long m_flInputMax = 0x370;
                public const long m_flInputMin = 0x1F8;
                public const long m_flOutputMax = 0x660;
                public const long m_flOutputMin = 0x4E8;
                public const long m_nOutVectorField = 0x1F4;
            }
            public static partial class C_OP_RenderDeferredLight {
                public const long m_hTexture = 0x920;
                public const long m_flSpotFoV = 0x940;
                public const long m_bUseTexture = 0x91C;
                public const long m_flAlphaScale = 0x234;
                public const long m_nAlpha2Field = 0x238;
                public const long m_flRadiusScale = 0x230;
                public const long m_vecColorScale = 0x240;
                public const long m_flStartFalloff = 0x938;
                public const long m_flLightDistance = 0x934;
                public const long m_nColorBlendType = 0x918;
                public const long m_flDistanceFalloff = 0x93C;
                public const long m_bUseAlphaTestWindow = 0x91D;
                public const long m_nAlphaTestPointField = 0x928;
                public const long m_nAlphaTestRangeField = 0x92C;
                public const long m_nHSVShiftControlPoint = 0x944;
                public const long m_nAlphaTestSharpnessField = 0x930;
            }
            public static partial class C_OP_RenderMaterialProxy {
                public const long m_flAlpha = 0xAA8;
                public const long m_nProxyType = 0x234;
                public const long m_MaterialVars = 0x238;
                public const long m_vecColorScale = 0x3D0;
                public const long m_nColorBlendType = 0xC20;
                public const long m_hOverrideMaterial = 0x250;
                public const long m_nMaterialControlPoint = 0x230;
                public const long m_flMaterialOverrideEnabled = 0x258;
            }
            public static partial class C_OP_RenderStandardLight {
                public const long m_flPhi = 0xF08;
                public const long m_flTheta = 0xD90;
                public const long m_bIgnoreDT = 0x1810;
                public const long m_nPriority = 0x1678;
                public const long m_nLightType = 0x230;
                public const long m_bClosedLoop = 0x1801;
                public const long m_flIntensity = 0xA98;
                public const long m_flMaxLength = 0x1808;
                public const long m_flMinLength = 0x180C;
                public const long m_lightCookie = 0x1670;
                public const long m_nMaxAllowed = 0x234;
                public const long m_bCastShadows = 0xC10;
                public const long m_bReverseOrder = 0x1800;
                public const long m_flBounceScale = 0xC18;
                public const long m_flLengthScale = 0x1818;
                public const long m_strLightStyle = 0x918;
                public const long m_vecColorScale = 0x238;
                public const long m_bDynamicBounce = 0xC11;
                public const long m_bRenderDiffuse = 0x1668;
                public const long m_nPrevPntSource = 0x1804;
                public const long m_bRenderSpecular = 0x1669;
                public const long m_flCapsuleLength = 0x17FC;
                public const long m_nColorBlendType = 0x910;
                public const long m_flLightStyleTime = 0x920;
                public const long m_nFogLightingMode = 0x167C;
                public const long m_flFogContribution = 0x1680;
                public const long m_nAttenuationStyle = 0x11F8;
                public const long m_flFalloffLinearity = 0x1200;
                public const long m_flLengthFadeInTime = 0x181C;
                public const long m_flRadiusMultiplier = 0x1080;
                public const long m_flZeroPercentFalloff = 0x14F0;
                public const long m_flFiftyPercentFalloff = 0x1378;
                public const long m_nCapsuleLightBehavior = 0x17F8;
                public const long m_flConstrainRadiusToLengthRatio = 0x1814;
            }
            public static partial class C_OP_RenderVRHapticEvent {
                public const long m_nHand = 0x230;
                public const long m_flAmplitude = 0x240;
                public const long m_nOutputField = 0x238;
                public const long m_nOutputHandCP = 0x234;
            }
            public static partial class C_OP_SnapshotSkinToBones {
                public const long m_flPrevPosScale = 0x1F4;
                public const long m_bTransformRadii = 0x1E1;
                public const long m_flJumpThreshold = 0x1F0;
                public const long m_bTransformNormals = 0x1E0;
                public const long m_flLifeTimeFadeEnd = 0x1EC;
                public const long m_flLifeTimeFadeStart = 0x1E8;
                public const long m_nControlPointNumber = 0x1E4;
            }
            public static partial class C_OP_StopAfterCPDuration {
                public const long m_flDuration = 0x1E8;
                public const long m_bPlayEndCap = 0x361;
                public const long m_bDestroyImmediately = 0x360;
            }
            public static partial class C_OP_VectorFieldSnapshot {
                public const long m_vecScale = 0x368;
                public const long m_bSetVelocity = 0xA44;
                public const long m_flGridSpacing = 0xA48;
                public const long m_nLocalSpaceCP = 0x1E8;
                public const long m_bLockToSurface = 0xA45;
                public const long m_flInterpolation = 0x1F0;
                public const long m_nAttributeToWrite = 0x1E4;
                public const long m_flBoundaryDampening = 0xA40;
                public const long m_nControlPointNumber = 0x1E0;
            }
            public static partial class CParticleBindingRealPulse {

            }
            public static partial class CParticleFunctionOperator {

            }
            public static partial class CParticleFunctionRenderer {
                public const long VisibilityInputs = 0x1E0;
                public const long m_bCannotBeRefracted = 0x228;
            }
            public static partial class CParticleSystemDefinition {
                public const long m_Children = 0xB8;
                public const long m_Emitters = 0x28;
                public const long m_nGroupID = 0x260;
                public const long m_Operators = 0x58;
                public const long m_Renderers = 0xA0;
                public const long m_hFallback = 0x2F8;
                public const long m_hSnapshot = 0x2D8;
                public const long m_Constraints = 0x88;
                public const long m_bShouldSort = 0x378;
                public const long m_Initializers = 0x40;
                public const long m_bShouldBatch = 0x358;
                public const long m_flCullRadius = 0x2E8;
                public const long m_nMinCPULevel = 0x338;
                public const long m_nMinGPULevel = 0x33C;
                public const long m_ConstantColor = 0x2A8;
                public const long m_nMaxParticles = 0x25C;
                public const long m_BoundingBoxMax = 0x270;
                public const long m_BoundingBoxMin = 0x264;
                public const long m_ConstantNormal = 0x2AC;
                public const long m_flCullFillCost = 0x2EC;
                public const long m_nMinimumFrames = 0x330;
                public const long m_ForceGenerators = 0x70;
                public const long m_bInfiniteBounds = 0x284;
                public const long m_flDepthSortBias = 0x27C;
                public const long m_hLowViolenceDef = 0x308;
                public const long m_NamedValueDomain = 0x288;
                public const long m_NamedValueLocals = 0x290;
                public const long m_flConstantRadius = 0x2B8;
                public const long m_flMaximumSimTime = 0x324;
                public const long m_flMinimumSimTime = 0x328;
                public const long m_nBehaviorVersion = 0x8;
                public const long m_nViewModelEffect = 0x35C;
                public const long m_pszTargetLayerID = 0x368;
                public const long m_flAggregateRadius = 0x354;
                public const long m_flMaxDrawDistance = 0x344;
                public const long m_flMaximumTimeStep = 0x320;
                public const long m_flMinimumTimeStep = 0x32C;
                public const long m_nCullControlPoint = 0x2F0;
                public const long m_nFallbackMaxCount = 0x300;
                public const long m_nInitialParticles = 0x258;
                public const long m_bEnableNamedValues = 0x285;
                public const long m_bScreenSpaceEffect = 0x360;
                public const long m_flConstantLifespan = 0x2C4;
                public const long m_flConstantRotation = 0x2BC;
                public const long m_flPreSimulationTime = 0x318;
                public const long m_flStartFadeDistance = 0x348;
                public const long m_PreEmissionOperators = 0x10;
                public const long m_bIsGPUParticleSystem = 0x334;
                public const long m_flMaxCreationDistance = 0x34C;
                public const long m_hReferenceReplacement = 0x310;
                public const long m_nSnapshotControlPoint = 0x2D0;
                public const long m_pszCullReplacementName = 0x2E0;
                public const long m_flConstantRotationSpeed = 0x2C0;
                public const long m_flNoDrawTimeToGoToSleep = 0x340;
                public const long m_nConstantSequenceNumber = 0x2C8;
                public const long m_nSkipRenderControlPoint = 0x370;
                public const long m_nSortOverridePositionCP = 0x280;
                public const long m_nAllowRenderControlPoint = 0x374;
                public const long m_nConstantSequenceNumber1 = 0x2CC;
                public const long m_flStopSimulationAfterTime = 0x31C;
                public const long m_controlPointConfigurations = 0x3C0;
                public const long m_bShouldHitboxesFallbackToSnapshot = 0x35A;
                public const long m_nAggregationMinAvailableParticles = 0x350;
                public const long m_bShouldHitboxesFallbackToRenderBounds = 0x359;
                public const long m_nFirstMultipleOverride_BackwardCompat = 0x178;
                public const long m_bShouldHitboxesFallbackToCollisionHulls = 0x35B;
            }
            public static partial class CParticleVisibilityInputs {
                public const long m_nCPin = 0x4;
                public const long m_bRightEye = 0x44;
                public const long m_flInputMax = 0x10;
                public const long m_flInputMin = 0xC;
                public const long m_bDotCPAngles = 0x2C;
                public const long m_flCameraBias = 0x0;
                public const long m_flDotInputMax = 0x28;
                public const long m_flDotInputMin = 0x24;
                public const long m_flProxyRadius = 0x8;
                public const long m_flAlphaScaleMax = 0x34;
                public const long m_flAlphaScaleMin = 0x30;
                public const long m_bDotCameraAngles = 0x2D;
                public const long m_flRadiusScaleMax = 0x3C;
                public const long m_flRadiusScaleMin = 0x38;
                public const long m_flDistanceInputMax = 0x20;
                public const long m_flDistanceInputMin = 0x1C;
                public const long m_flInputPixelVisFade = 0x14;
                public const long m_flRadiusScaleFOVBase = 0x40;
                public const long m_flNoPixelVisibilityFallback = 0x18;
            }
            public static partial class CPulseCell_Value_Gradient {
                public const long m_Gradient = 0x48;
            }
            public static partial class C_INIT_CreateSpiralSphere {
                public const long m_flDensity = 0x250;
                public const long m_TransformInput = 0x1E8;
                public const long m_flInitialRadius = 0x3C8;
                public const long m_bUseParticleCount = 0x830;
                public const long m_flInitialSpeedMax = 0x6B8;
                public const long m_flInitialSpeedMin = 0x540;
            }
            public static partial class C_INIT_InitFromCPSnapshot {
                public const long m_bRandom = 0x204;
                public const long m_bReverse = 0x205;
                public const long m_nRandomSeed = 0x4F8;
                public const long m_nLocalSpaceCP = 0x200;
                public const long m_nAttributeToRead = 0x1F8;
                public const long m_bLocalSpaceAngles = 0x4FC;
                public const long m_nAttributeToWrite = 0x1FC;
                public const long m_strSnapshotSubset = 0x1F0;
                public const long m_nSnapShotIncrement = 0x208;
                public const long m_nControlPointNumber = 0x1E8;
                public const long m_nManualSnapshotIndex = 0x380;
            }
            public static partial class C_INIT_PositionOffsetToCP {
                public const long m_bLocalCoords = 0x1F0;
                public const long m_nControlPointNumberEnd = 0x1EC;
                public const long m_nControlPointNumberStart = 0x1E8;
            }
            public static partial class C_INIT_PositionWarpScalar {
                public const long m_InputValue = 0x200;
                public const long m_vecWarpMax = 0x1F4;
                public const long m_vecWarpMin = 0x1E8;
                public const long m_flPrevPosScale = 0x378;
                public const long m_nControlPointNumber = 0x380;
                public const long m_nScaleControlPointNumber = 0x37C;
            }
            public static partial class C_INIT_RadiusFromCPObject {
                public const long m_nControlPoint = 0x1E8;
            }
            public static partial class C_INIT_SetHitboxToClosest {
                public const long m_bUseBones = 0x948;
                public const long m_nTestType = 0x94C;
                public const long m_HitboxSetName = 0x8C8;
                public const long m_flHybridRatio = 0x950;
                public const long m_nDesiredHitbox = 0x1EC;
                public const long m_vecHitBoxScale = 0x1F0;
                public const long m_bUpdatePosition = 0xAC8;
                public const long m_nControlPointNumber = 0x1E8;
                public const long m_bUseClosestPointOnHitbox = 0x949;
            }
            public static partial class C_INIT_SetRigidAttachment {
                public const long m_bLocalSpace = 0x1F4;
                public const long m_nFieldInput = 0x1EC;
                public const long m_nFieldOutput = 0x1F0;
                public const long m_nControlPointNumber = 0x1E8;
            }
            public static partial class C_INIT_VelocityFromNormal {
                public const long m_bIgnoreDt = 0x1F0;
                public const long m_fSpeedMax = 0x1EC;
                public const long m_fSpeedMin = 0x1E8;
            }
            public static partial class C_OP_InstantaneousEmitter {
                public const long m_nEventType = 0x4DC;
                public const long m_flStartTime = 0x360;
                public const long m_nParticlesToEmit = 0x1E8;
                public const long m_strSnapshotSubset = 0x660;
                public const long m_nMaxEmittedPerFrame = 0x658;
                public const long m_flParentParticleScale = 0x4E0;
                public const long m_nSnapshotControlPoint = 0x65C;
                public const long m_flInitFromKilledParentParticles = 0x4D8;
            }
            public static partial class C_OP_LazyCullCompareFloat {
                public const long m_flCullTime = 0x4D0;
                public const long m_flComparsion1 = 0x1E0;
                public const long m_flComparsion2 = 0x358;
            }
            public static partial class C_OP_LerpToOtherAttribute {
                public const long m_nFieldInput = 0x35C;
                public const long m_nFieldOutput = 0x360;
                public const long m_flInterpolation = 0x1E0;
                public const long m_nFieldInputFrom = 0x358;
            }
            public static partial class C_OP_RemapDensityToVector {
                public const long m_flDensityMax = 0x1EC;
                public const long m_flDensityMin = 0x1E8;
                public const long m_nFieldOutput = 0x1E4;
                public const long m_vecOutputMax = 0x1FC;
                public const long m_vecOutputMin = 0x1F0;
                public const long m_flRadiusScale = 0x1E0;
                public const long m_bUseParentDensity = 0x208;
                public const long m_nVoxelGridResolution = 0x20C;
            }
            public static partial class C_OP_RemapGravityToVector {
                public const long m_vInput1 = 0x1E0;
                public const long m_nSetMethod = 0x8BC;
                public const long m_nOutputField = 0x8B8;
                public const long m_bNormalizedOutput = 0x8C0;
            }
            public static partial class C_OP_RemapModelVolumetoCP {
                public const long m_nField = 0x1F8;
                public const long m_bBBoxOnly = 0x20C;
                public const long m_bCubeRoot = 0x20D;
                public const long m_nBBoxType = 0x1E8;
                public const long m_flInputMax = 0x200;
                public const long m_flInputMin = 0x1FC;
                public const long m_flOutputMax = 0x208;
                public const long m_flOutputMin = 0x204;
                public const long m_nInControlPointNumber = 0x1EC;
                public const long m_nOutControlPointNumber = 0x1F0;
                public const long m_nOutControlPointMaxNumber = 0x1F4;
            }
            public static partial class C_OP_RemapScalarOnceTimed {
                public const long m_flInputMax = 0x1F0;
                public const long m_flInputMin = 0x1EC;
                public const long m_flOutputMax = 0x1F8;
                public const long m_flOutputMin = 0x1F4;
                public const long m_flRemapTime = 0x1FC;
                public const long m_nFieldInput = 0x1E4;
                public const long m_nFieldOutput = 0x1E8;
                public const long m_bProportional = 0x1E0;
            }
            public static partial class C_OP_RenderPostProcessing {
                public const long m_nPriority = 0x3B0;
                public const long m_hPostTexture = 0x3A8;
                public const long m_flPostProcessStrength = 0x230;
            }
            public static partial class C_OP_RenderStatusEffectTf {
                public const long m_pTextureDetail = 0x258;
                public const long m_pTextureEnvMap = 0x260;
                public const long m_pTextureNormal = 0x238;
                public const long m_pTextureColorWarp = 0x230;
                public const long m_pTextureMetalness = 0x240;
                public const long m_pTextureRoughness = 0x248;
                public const long m_pTextureSelfIllum = 0x250;
            }
            public static partial class C_OP_RestartAfterDuration {
                public const long m_nCP = 0x1E8;
                public const long m_nCPField = 0x1EC;
                public const long m_bOnlyChildren = 0x1F4;
                public const long m_flDurationMax = 0x1E4;
                public const long m_flDurationMin = 0x1E0;
                public const long m_nChildGroupID = 0x1F0;
            }
            public static partial class C_OP_RopeSpringConstraint {
                public const long m_flRestLength = 0x1E0;
                public const long m_flMaxDistance = 0x4D0;
                public const long m_flMinDistance = 0x358;
                public const long m_flAdjustmentScale = 0x648;
                public const long m_flInitialRestingLength = 0x650;
            }
            public static partial class C_OP_SetControlPointToHMD {
                public const long m_nCP1 = 0x1E8;
                public const long m_vecCP1Pos = 0x1EC;
                public const long m_bOrientToHMD = 0x1F8;
            }
            public static partial class C_OP_WaterImpulseRenderer {
                public const long m_vecPos = 0x230;
                public const long m_flShape = 0xBF8;
                public const long m_flRadius = 0x908;
                public const long m_flWobble = 0xEE8;
                public const long m_nEventType = 0x1064;
                public const long m_flMagnitude = 0xA80;
                public const long m_flWindSpeed = 0xD70;
                public const long m_bIsRadialWind = 0x1060;
            }
            public static partial class C_OP_WorldTraceConstraint {
                public const long m_nCP = 0x1E0;
                public const long m_nIgnoreCP = 0x280;
                public const long m_nTraceSet = 0x1F8;
                public const long m_bBrushOnly = 0x27D;
                public const long m_bSetNormal = 0x881;
                public const long m_bWorldOnly = 0x27C;
                public const long m_flMinSpeed = 0x87C;
                public const long m_flStopSpeed = 0x888;
                public const long m_vecCpOffset = 0x1E4;
                public const long m_bDecayBounce = 0x878;
                public const long m_flRetestRate = 0x288;
                public const long m_bIncludeWater = 0x27E;
                public const long m_flRadiusScale = 0x298;
                public const long m_flSlideAmount = 0x588;
                public const long m_bKillonContact = 0x879;
                public const long m_flBounceAmount = 0x410;
                public const long m_nCollisionMode = 0x1F0;
                public const long m_flRandomDirScale = 0x700;
                public const long m_flTraceTolerance = 0x28C;
                public const long m_nCollisionModeMin = 0x1F4;
                public const long m_CollisionGroupName = 0x1FC;
                public const long m_nMaxTracesPerFrame = 0x294;
                public const long m_bKillonContactBounce = 0x880;
                public const long m_flCpMovementTolerance = 0x284;
                public const long m_nEntityStickDataField = 0xA00;
                public const long m_nStickOnCollisionField = 0x884;
                public const long m_nEntityStickNormalField = 0xA04;
                public const long m_flCollisionConfirmationSpeed = 0x290;
            }
            public static partial class IParticleSystemDefinition {

            }
            public static partial class OutflowWithRequirements_t {
                public const long m_Connection = 0x0;
                public const long m_RequirementNodeIDs = 0x50;
                public const long m_DestinationFlowNodeID = 0x48;
                public const long m_nCursorStateBlockIndex = 0x68;
            }
            public static partial class RenderProjectedMaterial_t {
                public const long m_hMaterial = 0x0;
            }
            public static partial class SignatureOutflow_Continue {

            }
            public static partial class CPulseCell_BaseRequirement {

            }
            public static partial class CPulseCell_Value_RandomInt {

            }
            public static partial class CPulse_BlackboardReference {
                public const long m_nNodeID = 0x18;
                public const long m_NodeName = 0x20;
                public const long m_BlackboardResource = 0x8;
                public const long m_hBlackboardResource = 0x0;
            }
            public static partial class C_INIT_ColorLitPerParticle {
                public const long m_TintMax = 0x20C;
                public const long m_TintMin = 0x208;
                public const long m_ColorMax = 0x204;
                public const long m_ColorMin = 0x200;
                public const long m_flTintPerc = 0x210;
                public const long m_nTintBlendMode = 0x214;
                public const long m_flLightAmplification = 0x218;
            }
            public static partial class C_INIT_CreateInEpitrochoid {
                public const long m_flOffset = 0x3D0;
                public const long m_bUseCount = 0x838;
                public const long m_flRadius1 = 0x548;
                public const long m_flRadius2 = 0x6C0;
                public const long m_nComponent1 = 0x1E8;
                public const long m_nComponent2 = 0x1EC;
                public const long m_TransformInput = 0x1F0;
                public const long m_bUseLocalCoords = 0x839;
                public const long m_flParticleDensity = 0x258;
                public const long m_bOffsetExistingPos = 0x83A;
            }
            public static partial class C_INIT_InitFloatCollection {
                public const long m_InputValue = 0x1E8;
                public const long m_nOutputField = 0x360;
            }
            public static partial class C_INIT_RandomModelSequence {
                public const long m_hModel = 0x3E8;
                public const long m_ActivityName = 0x1E8;
                public const long m_SequenceName = 0x2E8;
            }
            public static partial class C_INIT_RandomRotationSpeed {

            }
            public static partial class C_INIT_RemapScalarToVector {
                public const long m_flEndTime = 0x214;
                public const long m_flInputMax = 0x1F4;
                public const long m_flInputMin = 0x1F0;
                public const long m_nSetMethod = 0x218;
                public const long m_flRemapBias = 0x224;
                public const long m_flStartTime = 0x210;
                public const long m_nFieldInput = 0x1E8;
                public const long m_bLocalCoords = 0x220;
                public const long m_nFieldOutput = 0x1EC;
                public const long m_vecOutputMax = 0x204;
                public const long m_vecOutputMin = 0x1F8;
                public const long m_nControlPointNumber = 0x21C;
            }
            public static partial class C_INIT_StatusEffectCitadel {
                public const long m_flSFXSScale = 0x1FC;
                public const long m_nDetailCombo = 0x218;
                public const long m_flSFXSOffsetX = 0x20C;
                public const long m_flSFXSOffsetY = 0x210;
                public const long m_flSFXSOffsetZ = 0x214;
                public const long m_flSFXSScrollX = 0x200;
                public const long m_flSFXSScrollY = 0x204;
                public const long m_flSFXSScrollZ = 0x208;
                public const long m_flSFXNormalAmount = 0x1EC;
                public const long m_flSFXSDetailScale = 0x220;
                public const long m_flSFXSUseModelUVs = 0x230;
                public const long m_flSFXSDetailAmount = 0x21C;
                public const long m_flSFXSDetailScrollX = 0x224;
                public const long m_flSFXSDetailScrollY = 0x228;
                public const long m_flSFXSDetailScrollZ = 0x22C;
                public const long m_flSFXColorWarpAmount = 0x1E8;
                public const long m_flSFXMetalnessAmount = 0x1F0;
                public const long m_flSFXRoughnessAmount = 0x1F4;
                public const long m_flSFXSelfIllumAmount = 0x1F8;
            }
            public static partial class C_OP_AttractToControlPoint {
                public const long m_fForceAmount = 0x200;
                public const long m_fFalloffPower = 0x4F0;
                public const long m_TransformInput = 0x4F8;
                public const long m_bApplyMinForce = 0x6D8;
                public const long m_fForceAmountMin = 0x560;
                public const long m_fMinimumDistance = 0x378;
                public const long m_vecComponentScale = 0x1F0;
            }
            public static partial class C_OP_FadeAndKillForTracers {
                public const long m_flEndAlpha = 0x1F4;
                public const long m_flStartAlpha = 0x1F0;
                public const long m_flEndFadeInTime = 0x1E4;
                public const long m_flEndFadeOutTime = 0x1EC;
                public const long m_flStartFadeInTime = 0x1E0;
                public const long m_flStartFadeOutTime = 0x1E8;
            }
            public static partial class C_OP_ForceControlPointStub {
                public const long m_ControlPoint = 0x1E8;
            }
            public static partial class C_OP_InheritFromPeerSystem {
                public const long m_nGroupID = 0x1EC;
                public const long m_nIncrement = 0x1E8;
                public const long m_nFieldInput = 0x1E4;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_LerpToInitialPosition {
                public const long m_flScale = 0x368;
                public const long m_vecScale = 0x4E0;
                public const long m_nCacheField = 0x360;
                public const long m_flInterpolation = 0x1E8;
                public const long m_nControlPointNumber = 0x1E0;
            }
            public static partial class C_OP_MovementPlaceOnGround {
                public const long m_nLerpCP = 0xACC;
                public const long m_nRefCP1 = 0xAC4;
                public const long m_nRefCP2 = 0xAC8;
                public const long m_flOffset = 0x1E0;
                public const long m_nIgnoreCP = 0xAE8;
                public const long m_nTraceSet = 0xAC0;
                public const long m_bSetNormal = 0xAE0;
                public const long m_flLerpRate = 0xA3C;
                public const long m_flTolerance = 0x35C;
                public const long m_vecTraceDir = 0x360;
                public const long m_bScaleOffset = 0xAE1;
                public const long m_bIncludeWater = 0xADD;
                public const long m_flTraceOffset = 0xA38;
                public const long m_bIncludeShotHull = 0xADC;
                public const long m_flMaxTraceLength = 0x358;
                public const long m_nPreserveOffsetCP = 0xAE4;
                public const long m_CollisionGroupName = 0xA40;
                public const long m_nTraceMissBehavior = 0xAD8;
            }
            public static partial class C_OP_OscillateScalarSimple {
                public const long m_Rate = 0x1E0;
                public const long m_nField = 0x1E8;
                public const long m_flOscAdd = 0x1F0;
                public const long m_Frequency = 0x1E4;
                public const long m_flOscMult = 0x1EC;
            }
            public static partial class C_OP_OscillateVectorSimple {
                public const long m_Rate = 0x1E0;
                public const long m_nField = 0x1F8;
                public const long m_bOffset = 0x204;
                public const long m_flOscAdd = 0x200;
                public const long m_Frequency = 0x1EC;
                public const long m_flOscMult = 0x1FC;
            }
            public static partial class C_OP_RemapExternalWindToCP {
                public const long m_nCP = 0x1E8;
                public const long m_vecScale = 0x1F0;
                public const long m_nCPOutput = 0x1EC;
                public const long m_bSetMagnitude = 0x8C8;
                public const long m_nOutVectorField = 0x8CC;
            }
            public static partial class C_OP_RemapVelocityToVector {
                public const long m_flScale = 0x1E4;
                public const long m_bNormalize = 0x1E8;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_RemapVisibilityScalar {
                public const long m_flInputMax = 0x1EC;
                public const long m_flInputMin = 0x1E8;
                public const long m_flOutputMax = 0x1F4;
                public const long m_flOutputMin = 0x1F0;
                public const long m_nFieldInput = 0x1E0;
                public const long m_nFieldOutput = 0x1E4;
                public const long m_flRadiusScale = 0x1F8;
            }
            public static partial class C_OP_SetChildControlPoints {
                public const long m_bReverse = 0x368;
                public const long m_nOrientation = 0x36C;
                public const long m_nChildGroupID = 0x1E0;
                public const long m_bSetOrientation = 0x369;
                public const long m_nFirstSourcePoint = 0x1F0;
                public const long m_nNumControlPoints = 0x1E8;
                public const long m_nFirstControlPoint = 0x1E4;
            }
            public static partial class C_OP_SetControlPointToHand {
                public const long m_nCP1 = 0x1E8;
                public const long m_nHand = 0x1EC;
                public const long m_vecCP1Pos = 0x1F0;
                public const long m_bOrientToHand = 0x1FC;
            }
            public static partial class C_OP_VelocityMatchingForce {
                public const long m_bUseAABB = 0x1F0;
                public const long m_flDirScale = 0x1E0;
                public const long m_flSpdScale = 0x1E4;
                public const long m_nCPBroadcast = 0x1F4;
                public const long m_flFacingStrength = 0x1EC;
                public const long m_flNeighborDistance = 0x1E8;
            }
            public static partial class ParticlePreviewBodyGroup_t {
                public const long m_nValue = 0x8;
                public const long m_bodyGroupName = 0x0;
            }
            public static partial class PulseNodeDynamicOutflows_t {
                public const long m_Outflows = 0x0;
            }
            public static partial class PulseSelectorOutflowList_t {
                public const long m_Outflows = 0x0;
            }
            public static partial class VecInputMaterialVariable_t {
                public const long m_vecInput = 0x8;
                public const long m_strVariable = 0x0;
            }
            public static partial class CParticleFunctionConstraint {

            }
            public static partial class CPulseCell_Inflow_GraphHook {
                public const long m_HookName = 0x80;
            }
            public static partial class C_INIT_CreateFromPlaneCache {
                public const long m_bUseNormal = 0x201;
                public const long m_vecOffsetMax = 0x1F4;
                public const long m_vecOffsetMin = 0x1E8;
            }
            public static partial class C_INIT_CreateSequentialPath {
                public const long m_bLoop = 0x1F0;
                public const long m_bCPPairs = 0x1F1;
                public const long m_PathParams = 0x200;
                public const long m_bSaveOffset = 0x1F2;
                public const long m_fMaxDistance = 0x1E8;
                public const long m_flNumToAssign = 0x1EC;
            }
            public static partial class C_INIT_InitFromParentKilled {
                public const long m_nEventType = 0x1EC;
                public const long m_nAttributeToCopy = 0x1E8;
            }
            public static partial class C_INIT_InitialVelocityNoise {
                public const long m_flOffset = 0x8D8;
                public const long m_bIgnoreDt = 0x1B58;
                public const long m_vecAbsVal = 0x1E8;
                public const long m_flNoiseScale = 0x1800;
                public const long m_vecAbsValInv = 0x1F4;
                public const long m_vecOffsetLoc = 0x200;
                public const long m_vecOutputMax = 0x1128;
                public const long m_vecOutputMin = 0xA50;
                public const long m_TransformInput = 0x1AF0;
                public const long m_flNoiseScaleLoc = 0x1978;
            }
            public static partial class C_INIT_LifespanFromVelocity {
                public const long m_nTraceSet = 0x288;
                public const long m_nMaxPlanes = 0x200;
                public const long m_bIncludeWater = 0x298;
                public const long m_flTraceOffset = 0x1F4;
                public const long m_flMaxTraceLength = 0x1F8;
                public const long m_flTraceTolerance = 0x1FC;
                public const long m_vecComponentScale = 0x1E8;
                public const long m_CollisionGroupName = 0x208;
            }
            public static partial class C_INIT_OffsetVectorToVector {
                public const long m_nFieldInput = 0x1E8;
                public const long m_nFieldOutput = 0x1EC;
                public const long m_vecOutputMax = 0x1FC;
                public const long m_vecOutputMin = 0x1F0;
                public const long m_randomnessParameters = 0x208;
            }
            public static partial class C_INIT_RandomSecondSequence {
                public const long m_nSequenceMax = 0x1EC;
                public const long m_nSequenceMin = 0x1E8;
            }
            public static partial class C_INIT_VelocityRadialRandom {
                public const long m_vecFwd = 0x8C8;
                public const long m_fSpeedMax = 0x1118;
                public const long m_fSpeedMin = 0xFA0;
                public const long m_vecPosition = 0x1F0;
                public const long m_bIgnoreDelta = 0x129D;
                public const long m_bPerParticleCenter = 0x1E8;
                public const long m_nControlPointNumber = 0x1EC;
                public const long m_vecLocalCoordinateSystemSpeedScale = 0x1290;
            }
            public static partial class C_OP_ColorInterpolateRandom {
                public const long m_bEaseInOut = 0x218;
                public const long m_ColorFadeMax = 0x1FC;
                public const long m_ColorFadeMin = 0x1E0;
                public const long m_nFieldOutput = 0x214;
                public const long m_flFadeEndTime = 0x210;
                public const long m_flFadeStartTime = 0x20C;
            }
            public static partial class C_OP_DistanceBetweenCPsToCP {
                public const long m_bLOS = 0x214;
                public const long m_nEndCP = 0x1EC;
                public const long m_bSetOnce = 0x1F8;
                public const long m_nStartCP = 0x1E8;
                public const long m_nOutputCP = 0x1F0;
                public const long m_nTraceSet = 0x298;
                public const long m_flInputMax = 0x200;
                public const long m_flInputMin = 0x1FC;
                public const long m_flLOSScale = 0x210;
                public const long m_nSetParent = 0x29C;
                public const long m_flOutputMax = 0x208;
                public const long m_flOutputMin = 0x204;
                public const long m_nOutputCPField = 0x1F4;
                public const long m_flMaxTraceLength = 0x20C;
                public const long m_CollisionGroupName = 0x215;
            }
            public static partial class C_OP_LocalAccelerationForce {
                public const long m_nCP = 0x1F0;
                public const long m_nScaleCP = 0x1F4;
                public const long m_vecAccel = 0x1F8;
            }
            public static partial class C_OP_MaintainSequentialPath {
                public const long m_bLoop = 0x64C;
                public const long m_PathParams = 0x650;
                public const long m_flTolerance = 0x648;
                public const long m_fMaxDistance = 0x1E0;
                public const long m_flNumToAssign = 0x358;
                public const long m_bUseParticleCount = 0x64D;
                public const long m_flCohesionStrength = 0x4D0;
            }
            public static partial class C_OP_MovementMaintainOffset {
                public const long m_nCP = 0x1EC;
                public const long m_vecOffset = 0x1E0;
                public const long m_bRadiusScale = 0x1F0;
            }
            public static partial class C_OP_PlayEndCapWhenFinished {
                public const long m_bIncludeChildren = 0x1E9;
                public const long m_bFireOnEmissionEnd = 0x1E8;
            }
            public static partial class C_OP_RampScalarLinearSimple {
                public const long m_Rate = 0x1E0;
                public const long m_nField = 0x210;
                public const long m_flEndTime = 0x1E8;
                public const long m_flStartTime = 0x1E4;
            }
            public static partial class C_OP_RampScalarSplineSimple {
                public const long m_Rate = 0x1E0;
                public const long m_nField = 0x210;
                public const long m_bEaseOut = 0x214;
                public const long m_flEndTime = 0x1E8;
                public const long m_flStartTime = 0x1E4;
            }
            public static partial class C_OP_RemapVectorToRotations {
                public const long m_vecInput = 0x1E0;
                public const long m_vecRotation = 0x8B8;
            }
            public static partial class C_OP_WorldCollideConstraint {

            }
            public static partial class CParticleFunctionInitializer {
                public const long m_nAssociatedEmitterIndex = 0x1E0;
            }
            public static partial class CParticleFunctionPreEmission {
                public const long m_bRunOnce = 0x1E0;
            }
            public static partial class CPulseCell_Step_PublicOutput {
                public const long m_OutputIndex = 0x48;
            }
            public static partial class CPulseCell_Value_RandomFloat {

            }
            public static partial class CPulseCell_WaitForObservable {
                public const long m_OnTrue = 0x168;
                public const long m_Condition = 0xD8;
            }
            public static partial class C_INIT_CheckParticleForWater {
                public const long m_flRadius = 0x1E8;
                public const long m_nSetMethod = 0x4E0;
                public const long m_nFieldOutput = 0x360;
                public const long m_flOutputRemap = 0x368;
            }
            public static partial class C_INIT_CreateOnModelAtHeight {
                public const long m_bForceZ = 0x1E9;
                public const long m_bUseBones = 0x1E8;
                public const long m_nBiasType = 0x1120;
                public const long m_nHeightCP = 0x1F0;
                public const long m_bLocalCoords = 0x1124;
                public const long m_HitboxSetName = 0x1126;
                public const long m_vecHitBoxScale = 0x370;
                public const long m_bUseWaterHeight = 0x1F4;
                public const long m_flDesiredHeight = 0x1F8;
                public const long m_vecDirectionBias = 0xA48;
                public const long m_flMaxBoneVelocity = 0x1320;
                public const long m_bPreferMovingBoxes = 0x1125;
                public const long m_nControlPointNumber = 0x1EC;
                public const long m_flHitboxVelocityScale = 0x11A8;
            }
            public static partial class C_INIT_CreateParticleImpulse {
                public const long m_InputRadius = 0x1E8;
                public const long m_nImpulseType = 0x658;
                public const long m_InputMagnitude = 0x360;
                public const long m_InputFalloffExp = 0x4E0;
                public const long m_nFalloffFunction = 0x4D8;
            }
            public static partial class C_INIT_PositionPlaceOnGround {
                public const long m_flOffset = 0x1E8;
                public const long m_nIgnoreCP = 0xC60;
                public const long m_nTraceSet = 0xC30;
                public const long m_bSetNormal = 0xC4D;
                public const long m_nAttribute = 0xC48;
                public const long m_vecTraceDir = 0x4D8;
                public const long m_bSetPXYZOnly = 0xC4C;
                public const long m_bIncludeWater = 0xC44;
                public const long m_bOffsetonColOnly = 0xC54;
                public const long m_flMaxTraceLength = 0x360;
                public const long m_nPreserveOffsetCP = 0xC5C;
                public const long m_CollisionGroupName = 0xBB0;
                public const long m_nTraceMissBehavior = 0xC40;
                public const long m_flOffsetByRadiusFactor = 0xC58;
                public const long m_nGroundNormalAttribute = 0xC50;
            }
            public static partial class C_INIT_RandomVectorComponent {
                public const long m_flMax = 0x1EC;
                public const long m_flMin = 0x1E8;
                public const long m_nComponent = 0x1F4;
                public const long m_nFieldOutput = 0x1F0;
            }
            public static partial class C_OP_ConstrainDistanceToPath {
                public const long m_nFieldScale = 0x234;
                public const long m_fMinDistance = 0x1E0;
                public const long m_flTravelTime = 0x230;
                public const long m_nManualTField = 0x238;
                public const long m_PathParameters = 0x1F0;
                public const long m_flMaxDistance0 = 0x1E4;
                public const long m_flMaxDistance1 = 0x1EC;
                public const long m_flMaxDistanceMid = 0x1E8;
            }
            public static partial class C_OP_MovementRigidAttachToCP {
                public const long m_nFieldInput = 0x1EC;
                public const long m_bOffsetLocal = 0x1F4;
                public const long m_nFieldOutput = 0x1F0;
                public const long m_nScaleCPField = 0x1E8;
                public const long m_nScaleControlPoint = 0x1E4;
                public const long m_nControlPointNumber = 0x1E0;
            }
            public static partial class C_OP_RemapBoundingVolumetoCP {
                public const long m_flInputMax = 0x1F0;
                public const long m_flInputMin = 0x1EC;
                public const long m_flOutputMax = 0x1F8;
                public const long m_flOutputMin = 0x1F4;
                public const long m_nOutControlPointNumber = 0x1E8;
            }
            public static partial class C_OP_RemapCPVelocityToVector {
                public const long m_flScale = 0x1E8;
                public const long m_bNormalize = 0x1EC;
                public const long m_nFieldOutput = 0x1E4;
                public const long m_nControlPoint = 0x1E0;
            }
            public static partial class C_OP_RemapDotProductToScalar {
                public const long m_nInputCP1 = 0x1E0;
                public const long m_nInputCP2 = 0x1E4;
                public const long m_flInputMax = 0x1F0;
                public const long m_flInputMin = 0x1EC;
                public const long m_nSetMethod = 0x200;
                public const long m_flOutputMax = 0x1F8;
                public const long m_flOutputMin = 0x1F4;
                public const long m_bActiveRange = 0x204;
                public const long m_nFieldOutput = 0x1E8;
                public const long m_bUseParticleNormal = 0x205;
                public const long m_bUseParticleVelocity = 0x1FC;
            }
            public static partial class C_OP_RenderVolumetricEmitter {
                public const long m_nType = 0x238;
                public const long m_vecPos = 0x248;
                public const long m_flSpeed = 0x16D0;
                public const long m_flRadius = 0x1848;
                public const long m_flDensity = 0x19C0;
                public const long m_flFalloff = 0x2118;
                public const long m_nEventType = 0x240;
                public const long m_flMagnitude = 0x1CB0;
                public const long m_vecVelocity = 0x920;
                public const long m_flKillRadius = 0x1E28;
                public const long m_flTemperature = 0x1B38;
                public const long m_nCreationType = 0x23C;
                public const long m_vPrevPosition = 0xFF8;
                public const long m_strChannelType = 0x230;
                public const long m_flKillDensityScale = 0x1FA0;
            }
            public static partial class C_OP_SetControlPointRotation {
                public const long m_nCP = 0xA38;
                public const long m_nLocalCP = 0xA3C;
                public const long m_flRotRate = 0x8C0;
                public const long m_vecRotAxis = 0x1E8;
            }
            public static partial class C_OP_SetControlPointToCenter {
                public const long m_nCP1 = 0x1E8;
                public const long m_vecCP1Pos = 0x1EC;
                public const long m_nSetParent = 0x1FC;
                public const long m_bUseAvgParticlePos = 0x1F8;
            }
            public static partial class C_OP_SetControlPointToPlayer {
                public const long m_nCP1 = 0x1E8;
                public const long m_nPosition = 0x1FC;
                public const long m_nRadiusCP = 0x200;
                public const long m_vecCP1Pos = 0x1EC;
                public const long m_bOrientToEyes = 0x1F8;
                public const long m_nRadiusCPField = 0x204;
            }
            public static partial class C_OP_SetPerChildControlPoint {
                public const long m_nChildGroupID = 0x1E0;
                public const long m_bSetOrientation = 0x4E0;
                public const long m_nFirstSourcePoint = 0x368;
                public const long m_nNumControlPoints = 0x1E8;
                public const long m_nOrientationField = 0x4E4;
                public const long m_nFirstControlPoint = 0x1E4;
                public const long m_nParticleIncrement = 0x1F0;
                public const long m_bNumBasedOnParticleCount = 0x4E8;
            }
            public static partial class C_OP_ShapeMatchingConstraint {
                public const long m_flShapeRestorationTime = 0x1E0;
            }
            public static partial class FloatInputMaterialVariable_t {
                public const long m_flInput = 0x8;
                public const long m_strVariable = 0x0;
            }
            public static partial class ParticleControlPointDriver_t {
                public const long m_angOffset = 0x2C;
                public const long m_vecOffset = 0x20;
                public const long m_entityName = 0x38;
                public const long m_iAttachType = 0x10;
                public const long m_iControlPoint = 0x0;
                public const long m_attachmentName = 0x18;
            }
            public static partial class CPulseCell_BaseYieldingInflow {
                public const long m_BaseFlow_WhileActive = 0x90;
                public const long m_BaseFlow_OnAfterCancel = 0x48;
            }
            public static partial class CPulseCell_BooleanSwitchState {
                public const long m_WhenTrue = 0x168;
                public const long m_Condition = 0xD8;
                public const long m_WhenFalse = 0x1B0;
            }
            public static partial class CPulseCell_IsRequirementValid {

            }
            public static partial class C_INIT_CreateSequentialPathV2 {
                public const long m_bLoop = 0x4D8;
                public const long m_bCPPairs = 0x4D9;
                public const long m_PathParams = 0x4E0;
                public const long m_bSaveOffset = 0x4DA;
                public const long m_fMaxDistance = 0x1E8;
                public const long m_flNumToAssign = 0x360;
            }
            public static partial class C_INIT_DistanceToNeighborCull {
                public const long m_flModify = 0x4E8;
                public const long m_flDistance = 0x1E8;
                public const long m_nSetMethod = 0x660;
                public const long m_bUseNeighbor = 0x664;
                public const long m_nFieldModify = 0x4E0;
                public const long m_bIncludeRadii = 0x360;
                public const long m_flLifespanOverlap = 0x368;
            }
            public static partial class C_INIT_RemapQAnglesToRotation {
                public const long m_TransformInput = 0x1E8;
            }
            public static partial class C_INIT_RemapTransformToVector {
                public const long m_bOffset = 0x2FC;
                public const long m_flEndTime = 0x2F4;
                public const long m_vInputMax = 0x1F8;
                public const long m_vInputMin = 0x1EC;
                public const long m_nSetMethod = 0x2F8;
                public const long m_vOutputMax = 0x210;
                public const long m_vOutputMin = 0x204;
                public const long m_bAccelerate = 0x2FD;
                public const long m_flRemapBias = 0x300;
                public const long m_flStartTime = 0x2F0;
                public const long m_nFieldOutput = 0x1E8;
                public const long m_TransformInput = 0x220;
                public const long m_LocalSpaceTransform = 0x288;
            }
            public static partial class C_OP_CalculateVectorAttribute {
                public const long m_vStartValue = 0x1E0;
                public const long m_nFieldInput1 = 0x1EC;
                public const long m_nFieldInput2 = 0x1F4;
                public const long m_nFieldOutput = 0x22C;
                public const long m_flInputScale1 = 0x1F0;
                public const long m_flInputScale2 = 0x1F8;
                public const long m_vFinalOutputScale = 0x230;
                public const long m_nControlPointInput1 = 0x1FC;
                public const long m_nControlPointInput2 = 0x214;
                public const long m_flControlPointScale1 = 0x210;
                public const long m_flControlPointScale2 = 0x228;
            }
            public static partial class C_OP_ExternalGameImpulseForce {
                public const long m_bRopes = 0x368;
                public const long m_bParticles = 0x36B;
                public const long m_bExplosions = 0x36A;
                public const long m_bRopesZOnly = 0x369;
                public const long m_flForceScale = 0x1F0;
            }
            public static partial class C_OP_MovementLoopInsideSphere {
                public const long m_nCP = 0x1E0;
                public const long m_vecScale = 0x360;
                public const long m_flDistance = 0x1E8;
                public const long m_nDistSqrAttr = 0xA38;
            }
            public static partial class C_OP_ReinitializeScalarEndCap {
                public const long m_flOutputMax = 0x1E8;
                public const long m_flOutputMin = 0x1E4;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_RemapTransformToVelocity {
                public const long m_TransformInput = 0x1E0;
            }
            public static partial class C_OP_SetControlPointPositions {
                public const long m_nCP1 = 0x1EC;
                public const long m_nCP2 = 0x1F0;
                public const long m_nCP3 = 0x1F4;
                public const long m_nCP4 = 0x1F8;
                public const long m_bOrient = 0x1E9;
                public const long m_bSetOnce = 0x1EA;
                public const long m_vecCP1Pos = 0x1FC;
                public const long m_vecCP2Pos = 0x208;
                public const long m_vecCP3Pos = 0x214;
                public const long m_vecCP4Pos = 0x220;
                public const long m_nHeadLocation = 0x22C;
                public const long m_bUseWorldLocation = 0x1E8;
            }
            public static partial class C_OP_SnapshotRigidSkinToBones {
                public const long m_bTransformRadii = 0x1E1;
                public const long m_bTransformNormals = 0x1E0;
                public const long m_nControlPointNumber = 0x1E4;
            }
            public static partial class C_OP_SpringToVectorConstraint {
                public const long m_flRestLength = 0x1E0;
                public const long m_flMaxDistance = 0x4D0;
                public const long m_flMinDistance = 0x358;
                public const long m_flRestingLength = 0x648;
                public const long m_vecAnchorVector = 0x7C0;
            }
            public static partial class CPulseCell_Inflow_EventHandler {
                public const long m_EventName = 0x80;
            }
            public static partial class CPulseCell_Outflow_CycleRandom {
                public const long m_Outputs = 0x48;
            }
            public static partial class C_INIT_RandomNamedModelElement {
                public const long m_names = 0x1F0;
                public const long m_hModel = 0x1E8;
                public const long m_bLinear = 0x209;
                public const long m_bShuffle = 0x208;
                public const long m_nFieldOutput = 0x20C;
                public const long m_bModelFromRenderer = 0x20A;
            }
            public static partial class C_OP_DirectionBetweenVecsToVec {
                public const long m_vecPoint1 = 0x1E8;
                public const long m_vecPoint2 = 0x8C0;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_DistanceBetweenTransforms {
                public const long m_bLOS = 0x924;
                public const long m_nTraceSet = 0x920;
                public const long m_flInputMax = 0x430;
                public const long m_flInputMin = 0x2B8;
                public const long m_flLOSScale = 0x89C;
                public const long m_nSetMethod = 0x928;
                public const long m_flOutputMax = 0x720;
                public const long m_flOutputMin = 0x5A8;
                public const long m_TransformEnd = 0x250;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_TransformStart = 0x1E8;
                public const long m_flMaxTraceLength = 0x898;
                public const long m_CollisionGroupName = 0x8A0;
            }
            public static partial class C_OP_LockToSavedSequentialPath {
                public const long m_bCPPairs = 0x1EC;
                public const long m_flFadeEnd = 0x1E8;
                public const long m_PathParams = 0x1F0;
                public const long m_flFadeStart = 0x1E4;
            }
            public static partial class C_OP_PointVectorAtNextParticle {
                public const long m_bPrevious = 0x360;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_flInterpolation = 0x1E8;
            }
            public static partial class C_OP_RenderStatusEffectCitadel {
                public const long m_pTextureDetail = 0x258;
                public const long m_pTextureNormal = 0x238;
                public const long m_pTextureColorWarp = 0x230;
                public const long m_pTextureMetalness = 0x240;
                public const long m_pTextureRoughness = 0x248;
                public const long m_pTextureSelfIllum = 0x250;
            }
            public static partial class C_OP_RepeatedTriggerChildGroup {
                public const long m_flClusterSize = 0x368;
                public const long m_nChildGroupID = 0x1E8;
                public const long m_bLimitChildCount = 0x658;
                public const long m_flClusterCooldown = 0x4E0;
                public const long m_flClusterRefireTime = 0x1F0;
            }
            public static partial class C_OP_ScreenSpaceDistanceToEdge {
                public const long m_nSetMethod = 0x4D8;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_flOutputRemap = 0x360;
                public const long m_flMaxDistFromEdge = 0x1E8;
            }
            public static partial class C_OP_SelectivelyEnableChildren {
                public const long m_nFirstChild = 0x360;
                public const long m_nChildGroupID = 0x1E8;
                public const long m_bPlayEndcapOnStop = 0x650;
                public const long m_bDestroyImmediately = 0x651;
                public const long m_nNumChildrenToEnable = 0x4D8;
            }
            public static partial class CPulseCell_Outflow_CycleOrdered {
                public const long m_Outputs = 0x48;
            }
            public static partial class C_INIT_InitialRepulsionVelocity {
                public const long m_bInherit = 0x291;
                public const long m_nChildCP = 0x294;
                public const long m_nTraceSet = 0x268;
                public const long m_bTranslate = 0x289;
                public const long m_bPerParticle = 0x288;
                public const long m_vecOutputMax = 0x278;
                public const long m_vecOutputMin = 0x26C;
                public const long m_bProportional = 0x28A;
                public const long m_flTraceLength = 0x28C;
                public const long m_nChildGroupID = 0x298;
                public const long m_bPerParticleTR = 0x290;
                public const long m_CollisionGroupName = 0x1E8;
                public const long m_nControlPointNumber = 0x284;
            }
            public static partial class C_INIT_InitialSequenceFromModel {
                public const long m_flInputMax = 0x1F8;
                public const long m_flInputMin = 0x1F4;
                public const long m_nSetMethod = 0x204;
                public const long m_flOutputMax = 0x200;
                public const long m_flOutputMin = 0x1FC;
                public const long m_nFieldOutput = 0x1EC;
                public const long m_nFieldOutputAnim = 0x1F0;
                public const long m_nControlPointNumber = 0x1E8;
            }
            public static partial class C_INIT_RandomNamedModelBodyPart {

            }
            public static partial class C_INIT_RandomNamedModelSequence {

            }
            public static partial class C_OP_CollideWithParentParticles {
                public const long m_flRadiusScale = 0x358;
                public const long m_flParentRadiusScale = 0x1E0;
            }
            public static partial class C_OP_DifferencePreviousParticle {
                public const long m_flInputMax = 0x1EC;
                public const long m_flInputMin = 0x1E8;
                public const long m_nSetMethod = 0x1F8;
                public const long m_flOutputMax = 0x1F4;
                public const long m_flOutputMin = 0x1F0;
                public const long m_nFieldInput = 0x1E0;
                public const long m_bActiveRange = 0x1FC;
                public const long m_nFieldOutput = 0x1E4;
                public const long m_bSetPreviousParticle = 0x1FD;
            }
            public static partial class C_OP_InheritFromParentParticles {
                public const long m_flScale = 0x1E0;
                public const long m_nIncrement = 0x1E8;
                public const long m_nFieldOutput = 0x1E4;
                public const long m_bRandomDistribution = 0x1EC;
            }
            public static partial class C_OP_LightningSnapshotGenerator {
                public const long m_flOffset = 0x370;
                public const long m_flUVScale = 0x7D8;
                public const long m_nCPEndPnt = 0x1F0;
                public const long m_flSegments = 0x1F8;
                public const long m_flUVOffset = 0x950;
                public const long m_flRadiusEnd = 0x13B0;
                public const long m_flSplitRate = 0xAC8;
                public const long m_nCPSnapshot = 0x1E8;
                public const long m_nCPStartPnt = 0x1EC;
                public const long m_flRecalcRate = 0x660;
                public const long m_flBranchTwist = 0x10B8;
                public const long m_flOffsetDecay = 0x4E8;
                public const long m_flRadiusStart = 0x1238;
                public const long m_flDedicatedPool = 0x1528;
                public const long m_nBranchBehavior = 0x1230;
                public const long m_bScaleBranchOffset = 0xF38;
                public const long m_flBranchOffsetScale = 0xF40;
                public const long m_bScaleBranchDistance = 0xDB8;
                public const long m_flBranchDistanceScale = 0xDC0;
                public const long m_flRecursionSplitScale = 0xC40;
            }
            public static partial class C_OP_RemapDirectionToCPToVector {
                public const long m_nCP = 0x1E0;
                public const long m_flScale = 0x1E8;
                public const long m_bNormalize = 0x1FC;
                public const long m_flOffsetRot = 0x1EC;
                public const long m_nFieldOutput = 0x1E4;
                public const long m_vecOffsetAxis = 0x1F0;
                public const long m_nFieldStrength = 0x200;
            }
            public static partial class C_OP_RemapParticleCountToScalar {
                public const long m_nInputMax = 0x360;
                public const long m_nInputMin = 0x1E8;
                public const long m_nSetMethod = 0x7CC;
                public const long m_flOutputMax = 0x650;
                public const long m_flOutputMin = 0x4D8;
                public const long m_bActiveRange = 0x7C8;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_RenderClientPhysicsImpulse {
                public const long m_flRadius = 0x230;
                public const long m_flMagnitude = 0x3A8;
                public const long m_nSimIdFilter = 0x520;
            }
            public static partial class C_OP_RenderScreenVelocityRotate {
                public const long m_flForwardDegrees = 0x234;
                public const long m_flRotateRateDegrees = 0x230;
            }
            public static partial class C_OP_SetControlPointOrientation {
                public const long m_nCP = 0x1EC;
                public const long m_bSetOnce = 0x1EB;
                public const long m_bRandomize = 0x1EA;
                public const long m_vecRotation = 0x1F4;
                public const long m_vecRotationB = 0x200;
                public const long m_nHeadLocation = 0x1F0;
                public const long m_flInterpolation = 0x210;
                public const long m_bUseWorldLocation = 0x1E8;
            }
            public static partial class C_OP_SetControlPointsToParticle {
                public const long m_bReverse = 0x1F0;
                public const long m_nSetParent = 0x1F8;
                public const long m_nChildGroupID = 0x1E0;
                public const long m_bSetOrientation = 0x1F1;
                public const long m_nOrientationMode = 0x1F4;
                public const long m_nFirstSourcePoint = 0x1EC;
                public const long m_nNumControlPoints = 0x1E8;
                public const long m_nFirstControlPoint = 0x1E4;
            }
            public static partial class PointDefinitionWithTimeValues_t {
                public const long m_flTimeDuration = 0x14;
            }
            public static partial class CPulseCell_Inflow_BaseEntrypoint {
                public const long m_EntryChunk = 0x48;
                public const long m_RegisterMap = 0x50;
            }
            public static partial class CPulseCell_Outflow_CycleShuffled {
                public const long m_Outputs = 0x48;
            }
            public static partial class CPulseCell_WaitForCursorsWithTag {
                public const long m_bTagSelfWhenComplete = 0x128;
                public const long m_nDesiredKillPriority = 0x12C;
            }
            public static partial class CRandomNumberGeneratorParameters {
                public const long m_nSeed = 0x4;
                public const long m_bDistributeEvenly = 0x0;
            }
            public static partial class C_INIT_CreateFromParentParticles {
                public const long m_bSubFrame = 0x1F8;
                public const long m_flIncrement = 0x1EC;
                public const long m_nRandomSeed = 0x1F4;
                public const long m_flVelocityScale = 0x1E8;
                public const long m_bSetRopeSegmentID = 0x1F9;
                public const long m_bRandomDistribution = 0x1F0;
            }
            public static partial class C_INIT_InitialVelocityFromHitbox {
                public const long m_bUseBones = 0x274;
                public const long m_HitboxSetName = 0x1F4;
                public const long m_flVelocityMax = 0x1EC;
                public const long m_flVelocityMin = 0x1E8;
                public const long m_nControlPointNumber = 0x1F0;
            }
            public static partial class C_INIT_RandomNamedModelMeshGroup {

            }
            public static partial class C_OP_ChooseRandomChildrenInGroup {
                public const long m_nChildGroupID = 0x1E8;
                public const long m_flNumberOfChildren = 0x1F0;
            }
            public static partial class C_OP_DriveCPFromGlobalSoundFloat {
                public const long m_FieldName = 0x210;
                public const long m_StackName = 0x200;
                public const long m_flInputMax = 0x1F4;
                public const long m_flInputMin = 0x1F0;
                public const long m_flOutputMax = 0x1FC;
                public const long m_flOutputMin = 0x1F8;
                public const long m_OperatorName = 0x208;
                public const long m_nOutputField = 0x1EC;
                public const long m_nOutputControlPoint = 0x1E8;
            }
            public static partial class C_OP_ForceBasedOnDistanceToPlane {
                public const long m_flMaxDist = 0x200;
                public const long m_flMinDist = 0x1F0;
                public const long m_flExponent = 0x220;
                public const long m_vecPlaneNormal = 0x210;
                public const long m_vecForceAtMaxDist = 0x204;
                public const long m_vecForceAtMinDist = 0x1F4;
                public const long m_nControlPointNumber = 0x21C;
            }
            public static partial class C_OP_LockToSavedSequentialPathV2 {
                public const long m_bCPPairs = 0x1E8;
                public const long m_flFadeEnd = 0x1E4;
                public const long m_PathParams = 0x1F0;
                public const long m_flFadeStart = 0x1E0;
            }
            public static partial class C_OP_PercentageBetweenTransforms {
                public const long m_flInputMax = 0x1E8;
                public const long m_flInputMin = 0x1E4;
                public const long m_nSetMethod = 0x2C8;
                public const long m_flOutputMax = 0x1F0;
                public const long m_flOutputMin = 0x1EC;
                public const long m_TransformEnd = 0x260;
                public const long m_bActiveRange = 0x2CC;
                public const long m_bRadialCheck = 0x2CD;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_TransformStart = 0x1F8;
            }
            public static partial class C_OP_ReadFromNeighboringParticle {
                public const long m_nIncrement = 0x1E8;
                public const long m_nFieldInput = 0x1E0;
                public const long m_nFieldOutput = 0x1E4;
                public const long m_DistanceCheck = 0x1F0;
                public const long m_flInterpolation = 0x368;
            }
            public static partial class C_OP_RemapAverageHitboxSpeedtoCP {
                public const long m_nField = 0x1F0;
                public const long m_flInputMax = 0x370;
                public const long m_flInputMin = 0x1F8;
                public const long m_flOutputMax = 0x660;
                public const long m_flOutputMin = 0x4E8;
                public const long m_HitboxSetName = 0xEB8;
                public const long m_nHitboxDataType = 0x1F4;
                public const long m_nInControlPointNumber = 0x1E8;
                public const long m_vecComparisonVelocity = 0x7E0;
                public const long m_nOutControlPointNumber = 0x1EC;
                public const long m_nHeightControlPointNumber = 0x7D8;
            }
            public static partial class C_OP_RemapAverageScalarValuetoCP {
                public const long m_nField = 0x370;
                public const long m_nExpression = 0x1E8;
                public const long m_flOutputRemap = 0x378;
                public const long m_flDecimalPlaces = 0x1F0;
                public const long m_nOutVectorField = 0x36C;
                public const long m_nOutControlPointNumber = 0x368;
            }
            public static partial class C_OP_RenderSimpleModelCollection {
                public const long m_hModel = 0x238;
                public const long m_modelInput = 0x240;
                public const long m_fDrawFilter = 0x420;
                public const long m_bCenterOffset = 0x230;
                public const long m_bAcceptsDecals = 0x41A;
                public const long m_fSizeCullScale = 0x2A0;
                public const long m_bDisableShadows = 0x418;
                public const long m_bDisableMotionBlur = 0x419;
                public const long m_nAngularVelocityField = 0x598;
            }
            public static partial class C_OP_ScreenSpacePositionOfTarget {
                public const long m_bOututBehindness = 0x8B8;
                public const long m_nBehindSetMethod = 0xA38;
                public const long m_vecTargetPosition = 0x1E0;
                public const long m_nBehindFieldOutput = 0x8BC;
                public const long m_flBehindOutputRemap = 0x8C0;
            }
            public static partial class C_OP_SetCPOrientationToDirection {
                public const long m_nInputControlPoint = 0x1E0;
                public const long m_nOutputControlPoint = 0x1E4;
            }
            public static partial class C_OP_SetCPOrientationToPointAtCP {
                public const long m_nInputCP = 0x1E8;
                public const long m_nOutputCP = 0x1EC;
                public const long m_bPointAway = 0x36A;
                public const long m_b2DOrientation = 0x368;
                public const long m_flInterpolation = 0x1F0;
                public const long m_bAvoidSingularity = 0x369;
            }
            public static partial class C_OP_SetControlPointFieldToWater {
                public const long m_nDestCP = 0x1EC;
                public const long m_nCPField = 0x1F0;
                public const long m_nSourceCP = 0x1E8;
            }
            public static partial class C_OP_SetControlPointToCPVelocity {
                public const long m_nCPField = 0x1F8;
                public const long m_nCPInput = 0x1E8;
                public const long m_bNormalize = 0x1F0;
                public const long m_nCPOutputMag = 0x1F4;
                public const long m_nCPOutputVel = 0x1EC;
                public const long m_vecComparisonVelocity = 0x200;
            }
            public static partial class CPulseCell_InlineNodeSkipSelector {
                public const long m_bAnd = 0x4C;
                public const long m_FailOutflow = 0x68;
                public const long m_PassOutflow = 0x50;
                public const long m_nFlowNodeID = 0x48;
            }
            public static partial class CPulseCell_LimitCount__Criteria_t {
                public const long m_bLimitCountPasses = 0x0;
            }
            public static partial class C_INIT_InheritFromParentParticles {
                public const long m_flScale = 0x1E8;
                public const long m_nIncrement = 0x1F0;
                public const long m_nRandomSeed = 0x1F8;
                public const long m_nFieldOutput = 0x1EC;
                public const long m_bRandomDistribution = 0x1F4;
            }
            public static partial class C_INIT_RandomAlphaWindowThreshold {
                public const long m_flMax = 0x1EC;
                public const long m_flMin = 0x1E8;
                public const long m_flExponent = 0x1F0;
            }
            public static partial class C_INIT_RemapParticleCountToScalar {
                public const long m_bWrap = 0x20A;
                public const long m_bInvert = 0x209;
                public const long m_nInputMax = 0x1F0;
                public const long m_nInputMin = 0x1EC;
                public const long m_nSetMethod = 0x204;
                public const long m_flOutputMax = 0x200;
                public const long m_flOutputMin = 0x1FC;
                public const long m_flRemapBias = 0x20C;
                public const long m_bActiveRange = 0x208;
                public const long m_nFieldOutput = 0x1E8;
                public const long m_nScaleControlPoint = 0x1F4;
                public const long m_nScaleControlPointField = 0x1F8;
            }
            public static partial class C_OP_CreateParticleSystemRenderer {
                public const long m_vecCPs = 0x240;
                public const long m_hEffect = 0x230;
                public const long m_nEventType = 0x238;
                public const long m_AggregationPos = 0x258;
                public const long m_szParticleConfig = 0x250;
            }
            public static partial class C_OP_InheritFromParentParticlesV2 {
                public const long m_flScale = 0x1E0;
                public const long m_bReverse = 0x4DA;
                public const long m_bSubSample = 0x4D8;
                public const long m_nIncrement = 0x360;
                public const long m_nFieldOutput = 0x358;
                public const long m_flInterpolation = 0x4E0;
                public const long m_bRandomDistribution = 0x4D9;
                public const long m_nMissingParentBehavior = 0x4DC;
            }
            public static partial class C_OP_RemapNamedModelElementEndCap {
                public const long m_hModel = 0x1E0;
                public const long m_inNames = 0x1E8;
                public const long m_outNames = 0x200;
                public const long m_nFieldInput = 0x234;
                public const long m_nFieldOutput = 0x238;
                public const long m_fallbackNames = 0x218;
                public const long m_bModelFromRenderer = 0x230;
            }
            public static partial class C_OP_RemapVectorComponentToScalar {
                public const long m_nComponent = 0x1E8;
                public const long m_nFieldInput = 0x1E0;
                public const long m_nFieldOutput = 0x1E4;
            }
            public static partial class C_OP_SetControlPointToImpactPoint {
                public const long m_nCPIn = 0x1EC;
                public const long m_nCPOut = 0x1E8;
                public const long m_flOffset = 0x374;
                public const long m_nTraceSet = 0x404;
                public const long m_vecTraceDir = 0x378;
                public const long m_flUpdateRate = 0x1F0;
                public const long m_bIncludeWater = 0x40A;
                public const long m_flStartOffset = 0x370;
                public const long m_flTraceLength = 0x1F8;
                public const long m_bSetToEndpoint = 0x408;
                public const long m_CollisionGroupName = 0x384;
                public const long m_bTraceToClosestSurface = 0x409;
            }
            public static partial class CParticleCollectionBindingInstance {

            }
            public static partial class CParticleMassCalculationParameters {
                public const long m_flScale = 0x2F8;
                public const long m_flRadius = 0x8;
                public const long m_nMassMode = 0x0;
                public const long m_flNominalRadius = 0x180;
            }
            public static partial class CPulseCell_BaseLerp__CursorState_t {
                public const long m_EndTime = 0x4;
                public const long m_StartTime = 0x0;
            }
            public static partial class CPulseCell_Inflow_EntOutputHandler {
                public const long m_SourceEntity = 0x80;
                public const long m_SourceOutput = 0x90;
                public const long m_ExpectedParamType = 0xA0;
            }
            public static partial class CPulseCell_PickBestOutflowSelector {
                public const long m_nCheckType = 0x48;
                public const long m_OutflowList = 0x50;
            }
            public static partial class CPulseCell_Step_CallExternalMethod {
                public const long m_MethodName = 0xD8;
                public const long m_OnFinished = 0x108;
                public const long m_ExpectedArgs = 0xF0;
                public const long m_nAsyncCallMode = 0x100;
                public const long m_nBlackboardIndex = 0xE8;
            }
            public static partial class C_INIT_CreateWithinSphereTransform {
                public const long m_fSpeedMax = 0xDA0;
                public const long m_fSpeedMin = 0xC28;
                public const long m_fRadiusMax = 0x360;
                public const long m_fRadiusMin = 0x1E8;
                public const long m_bLocalCoords = 0xF1C;
                public const long m_nFieldOutput = 0x1CD0;
                public const long m_fSpeedRandExp = 0xF18;
                public const long m_TransformInput = 0xBC0;
                public const long m_nFieldVelocity = 0x1CD4;
                public const long m_vecDistanceBias = 0x4D8;
                public const long m_vecDistanceBiasAbs = 0xBB0;
                public const long m_LocalCoordinateSystemSpeedMax = 0x15F8;
                public const long m_LocalCoordinateSystemSpeedMin = 0xF20;
            }
            public static partial class C_INIT_InitFromVectorFieldSnapshot {
                public const long m_vecScale = 0x1F8;
                public const long m_nLocalSpaceCP = 0x1EC;
                public const long m_nWeightUpdateCP = 0x1F0;
                public const long m_nControlPointNumber = 0x1E8;
                public const long m_bUseVerticalVelocity = 0x1F4;
            }
            public static partial class C_INIT_ScreenSpacePositionOfTarget {
                public const long m_bOututBehindness = 0x8C0;
                public const long m_vecTargetPosition = 0x1E8;
                public const long m_nBehindFieldOutput = 0x8C4;
                public const long m_flBehindOutputRemap = 0x8C8;
            }
            public static partial class C_OP_ModelSurfaceSnapshotGenerator {
                public const long m_bSetUV = 0x833;
                public const long m_bSetUp = 0x831;
                public const long m_bSetNormal = 0x830;
                public const long m_flUSpacing = 0x3C8;
                public const long m_flVSpacing = 0x540;
                public const long m_modelInput = 0x1F0;
                public const long m_bSetGravity = 0x832;
                public const long m_nCPSnapshot = 0x1E8;
                public const long m_flRecalcRate = 0x250;
                public const long m_flSurfaceOffset = 0x6B8;
            }
            public static partial class C_OP_RemapNamedModelBodyPartEndCap {

            }
            public static partial class C_OP_RemapNamedModelSequenceEndCap {

            }
            public static partial class C_OP_ScreenSpaceRotateTowardTarget {
                public const long m_nSetMethod = 0xA30;
                public const long m_flOutputRemap = 0x8B8;
                public const long m_vecTargetPosition = 0x1E0;
                public const long m_flScreenEdgeAlignmentDistance = 0xA38;
            }
            public static partial class C_OP_SetControlPointToWaterSurface {
                public const long m_nDestCP = 0x1EC;
                public const long m_nFlowCP = 0x1F0;
                public const long m_nActiveCP = 0x1F4;
                public const long m_nSourceCP = 0x1E8;
                public const long m_flRetestRate = 0x200;
                public const long m_nActiveCPField = 0x1F8;
                public const long m_bAdaptiveThreshold = 0x378;
            }
            public static partial class C_OP_SetRandomControlPointPosition {
                public const long m_nCP1 = 0x1EC;
                public const long m_bOrient = 0x1E9;
                public const long m_vecCPMaxPos = 0x37C;
                public const long m_vecCPMinPos = 0x370;
                public const long m_nHeadLocation = 0x1F0;
                public const long m_flReRandomRate = 0x1F8;
                public const long m_flInterpolation = 0x388;
                public const long m_bUseWorldLocation = 0x1E8;
            }
            public static partial class C_OP_SetSingleControlPointPosition {
                public const long m_nCP1 = 0x1EC;
                public const long m_bSetOnce = 0x1E8;
                public const long m_vecCP1Pos = 0x1F0;
                public const long m_transformInput = 0x8C8;
            }
            public static partial class C_INIT_CreateWithinCapsuleTransform {
                public const long m_fHeight = 0x4D8;
                public const long m_fSpeedMax = 0x830;
                public const long m_fSpeedMin = 0x6B8;
                public const long m_fRadiusMax = 0x360;
                public const long m_fRadiusMin = 0x1E8;
                public const long m_nFieldOutput = 0x1760;
                public const long m_fSpeedRandExp = 0x9A8;
                public const long m_TransformInput = 0x650;
                public const long m_nFieldVelocity = 0x1764;
                public const long m_LocalCoordinateSystemSpeedMax = 0x1088;
                public const long m_LocalCoordinateSystemSpeedMin = 0x9B0;
            }
            public static partial class C_INIT_RemapInitialVisibilityScalar {
                public const long m_flInputMax = 0x1F4;
                public const long m_flInputMin = 0x1F0;
                public const long m_flOutputMax = 0x1FC;
                public const long m_flOutputMin = 0x1F8;
                public const long m_nFieldOutput = 0x1EC;
            }
            public static partial class C_OP_CPOffsetToPercentageBetweenCPs {
                public const long m_nEndCP = 0x1F0;
                public const long m_nInputCP = 0x1FC;
                public const long m_nOuputCP = 0x1F8;
                public const long m_nStartCP = 0x1EC;
                public const long m_nOffsetCP = 0x1F4;
                public const long m_vecOffset = 0x204;
                public const long m_flInputMax = 0x1E4;
                public const long m_flInputMin = 0x1E0;
                public const long m_flInputBias = 0x1E8;
                public const long m_bRadialCheck = 0x200;
                public const long m_bScaleOffset = 0x201;
            }
            public static partial class C_OP_ConnectParentParticleToNearest {
                public const long m_bUseRadius = 0x1E8;
                public const long m_flRadiusScale = 0x1F0;
                public const long m_nFirstControlPoint = 0x1E0;
                public const long m_flParentRadiusScale = 0x368;
                public const long m_nSecondControlPoint = 0x1E4;
            }
            public static partial class C_OP_CylindricalDistanceToTransform {
                public const long m_bCapsule = 0x89E;
                public const long m_bAdditive = 0x89D;
                public const long m_flInputMax = 0x360;
                public const long m_flInputMin = 0x1E8;
                public const long m_nSetMethod = 0x898;
                public const long m_flOutputMax = 0x650;
                public const long m_flOutputMin = 0x4D8;
                public const long m_TransformEnd = 0x830;
                public const long m_bActiveRange = 0x89C;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_TransformStart = 0x7C8;
            }
            public static partial class C_OP_PinRopeSegmentParticleToParent {
                public const long m_flInterpolation = 0x360;
                public const long m_nParticleNumber = 0x1E8;
                public const long m_nParticleSelection = 0x1E0;
            }
            public static partial class C_OP_RemapDistanceToLineSegmentBase {
                public const long m_nCP0 = 0x1E0;
                public const long m_nCP1 = 0x1E4;
                public const long m_bInfiniteLine = 0x1F0;
                public const long m_flMaxInputValue = 0x1EC;
                public const long m_flMinInputValue = 0x1E8;
            }
            public static partial class C_OP_RemapNamedModelMeshGroupEndCap {

            }
            public static partial class C_OP_RemapTransformOrientationToYaw {
                public const long m_flRotOffset = 0x24C;
                public const long m_nFieldOutput = 0x248;
                public const long m_TransformInput = 0x1E0;
                public const long m_flSpinStrength = 0x250;
            }
            public static partial class C_OP_SetAttributeToScalarExpression {
                public const long m_flInput1 = 0x1E8;
                public const long m_flInput2 = 0x360;
                public const long m_nSetMethod = 0x654;
                public const long m_nExpression = 0x1E0;
                public const long m_nOutputField = 0x650;
                public const long m_flOutputRemap = 0x4D8;
            }
            public static partial class C_OP_SetCPOrientationToGroundNormal {
                public const long m_nInputCP = 0x274;
                public const long m_nOutputCP = 0x278;
                public const long m_nTraceSet = 0x270;
                public const long m_flTolerance = 0x1E8;
                public const long m_flInterpRate = 0x1E0;
                public const long m_bIncludeWater = 0x288;
                public const long m_flTraceOffset = 0x1EC;
                public const long m_flMaxTraceLength = 0x1E4;
                public const long m_CollisionGroupName = 0x1F0;
            }
            public static partial class C_OP_SetControlPointFromObjectScale {
                public const long m_nCPInput = 0x1E8;
                public const long m_nCPOutput = 0x1EC;
            }
            public static partial class ParticleControlPointConfiguration_t {
                public const long m_name = 0x0;
                public const long m_drivers = 0x8;
                public const long m_previewState = 0x20;
            }
            public static partial class CPulseCell_Timeline__TimelineEvent_t {
                public const long m_EventOutflow = 0x8;
                public const long m_flTimeFromPrevious = 0x0;
            }
            public static partial class CPulseCell_WaitForCursorsWithTagBase {
                public const long m_WaitComplete = 0xE0;
                public const long m_nCursorsAllowedToWait = 0xD8;
            }
            public static partial class C_OP_ControlPointToRadialScreenSpace {
                public const long m_nCPIn = 0x1E8;
                public const long m_nCPOut = 0x1F8;
                public const long m_vecCP1Pos = 0x1EC;
                public const long m_nCPOutField = 0x1FC;
                public const long m_nCPSSPosOut = 0x200;
            }
            public static partial class C_OP_RemapNamedModelElementOnceTimed {
                public const long m_hModel = 0x1E0;
                public const long m_inNames = 0x1E8;
                public const long m_outNames = 0x200;
                public const long m_flRemapTime = 0x23C;
                public const long m_nFieldInput = 0x234;
                public const long m_nFieldOutput = 0x238;
                public const long m_bProportional = 0x231;
                public const long m_fallbackNames = 0x218;
                public const long m_bModelFromRenderer = 0x230;
            }
            public static partial class C_OP_SetParentControlPointsToChildCP {
                public const long m_nChildGroupID = 0x1E8;
                public const long m_bSetOrientation = 0x1F8;
                public const long m_nFirstSourcePoint = 0x1F4;
                public const long m_nNumControlPoints = 0x1F0;
                public const long m_nChildControlPoint = 0x1EC;
            }
            public static partial class C_INIT_RemapNamedModelElementToScalar {
                public const long m_names = 0x1F0;
                public const long m_hModel = 0x1E8;
                public const long m_values = 0x208;
                public const long m_nSetMethod = 0x228;
                public const long m_nFieldInput = 0x220;
                public const long m_nFieldOutput = 0x224;
                public const long m_bModelFromRenderer = 0x22C;
            }
            public static partial class C_INIT_SetAttributeToScalarExpression {
                public const long m_flInput1 = 0x1F0;
                public const long m_flInput2 = 0x368;
                public const long m_nSetMethod = 0x65C;
                public const long m_nExpression = 0x1E8;
                public const long m_nOutputField = 0x658;
                public const long m_flOutputRemap = 0x4E0;
            }
            public static partial class C_OP_MovementRotateParticleAroundAxis {
                public const long m_flRotRate = 0x8B8;
                public const long m_vecRotAxis = 0x1E0;
                public const long m_bLocalSpace = 0xA98;
                public const long m_TransformInput = 0xA30;
            }
            public static partial class C_OP_RemapNamedModelBodyPartOnceTimed {

            }
            public static partial class C_OP_RemapNamedModelSequenceOnceTimed {

            }
            public static partial class C_OP_RemapParticleCountOnScalarEndCap {
                public const long m_nInputMax = 0x1E8;
                public const long m_nInputMin = 0x1E4;
                public const long m_bBackwards = 0x1F4;
                public const long m_nSetMethod = 0x1F8;
                public const long m_flOutputMax = 0x1F0;
                public const long m_flOutputMin = 0x1EC;
                public const long m_nFieldOutput = 0x1E0;
            }
            public static partial class C_OP_RemapTransformVisibilityToScalar {
                public const long m_flRadius = 0x264;
                public const long m_flInputMax = 0x258;
                public const long m_flInputMin = 0x254;
                public const long m_nSetMethod = 0x1E0;
                public const long m_flOutputMax = 0x260;
                public const long m_flOutputMin = 0x25C;
                public const long m_nFieldOutput = 0x250;
                public const long m_TransformInput = 0x1E8;
            }
            public static partial class C_OP_RemapTransformVisibilityToVector {
                public const long m_flRadius = 0x274;
                public const long m_flInputMax = 0x258;
                public const long m_flInputMin = 0x254;
                public const long m_nSetMethod = 0x1E0;
                public const long m_nFieldOutput = 0x250;
                public const long m_vecOutputMax = 0x268;
                public const long m_vecOutputMin = 0x25C;
                public const long m_TransformInput = 0x1E8;
            }
            public static partial class C_OP_SetControlPointsToModelParticles {
                public const long m_bSkin = 0x2EC;
                public const long m_bAttachment = 0x2ED;
                public const long m_HitboxSetName = 0x1E0;
                public const long m_AttachmentName = 0x260;
                public const long m_nFirstSourcePoint = 0x2E8;
                public const long m_nNumControlPoints = 0x2E4;
                public const long m_nFirstControlPoint = 0x2E0;
            }
            public static partial class CPulseCell_LimitCount__InstanceState_t {
                public const long m_nCurrentCount = 0x0;
            }
            public static partial class C_INIT_RemapNamedModelBodyPartToScalar {

            }
            public static partial class C_INIT_RemapNamedModelSequenceToScalar {

            }
            public static partial class C_OP_PercentageBetweenTransformLerpCPs {
                public const long m_flInputMax = 0x1E8;
                public const long m_flInputMin = 0x1E4;
                public const long m_nSetMethod = 0x2D0;
                public const long m_TransformEnd = 0x258;
                public const long m_bActiveRange = 0x2D4;
                public const long m_bRadialCheck = 0x2D5;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_nOutputEndCP = 0x2C8;
                public const long m_TransformStart = 0x1F0;
                public const long m_nOutputStartCP = 0x2C0;
                public const long m_nOutputEndField = 0x2CC;
                public const long m_nOutputStartField = 0x2C4;
            }
            public static partial class C_OP_PercentageBetweenTransformsVector {
                public const long m_flInputMax = 0x1E8;
                public const long m_flInputMin = 0x1E4;
                public const long m_nSetMethod = 0x2D8;
                public const long m_TransformEnd = 0x270;
                public const long m_bActiveRange = 0x2DC;
                public const long m_bRadialCheck = 0x2DD;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_vecOutputMax = 0x1F8;
                public const long m_vecOutputMin = 0x1EC;
                public const long m_TransformStart = 0x208;
            }
            public static partial class C_OP_RemapNamedModelMeshGroupOnceTimed {

            }
            public static partial class C_OP_SetControlPointToVectorExpression {
                public const long m_flLerp = 0xFA0;
                public const long m_vInput1 = 0x1F0;
                public const long m_vInput2 = 0x8C8;
                public const long m_nOutputCP = 0x1EC;
                public const long m_nExpression = 0x1E8;
                public const long m_bNormalizedOutput = 0x1118;
            }
            public static partial class CPulseCell_IntervalTimer__CursorState_t {
                public const long m_EndTime = 0x4;
                public const long m_StartTime = 0x0;
                public const long m_flWaitInterval = 0x8;
                public const long m_flWaitIntervalHigh = 0xC;
                public const long m_bCompleteOnNextWake = 0x10;
            }
            public static partial class C_INIT_RemapNamedModelMeshGroupToScalar {

            }
            public static partial class C_OP_MovementMoveAlongSkinnedCPSnapshot {
                public const long m_flTValue = 0x368;
                public const long m_bSetNormal = 0x1E8;
                public const long m_bSetRadius = 0x1E9;
                public const long m_flInterpolation = 0x1F0;
                public const long m_nControlPointNumber = 0x1E0;
                public const long m_nSnapshotControlPointNumber = 0x1E4;
            }
            public static partial class C_OP_RemapControlPointDirectionToVector {
                public const long m_flScale = 0x1E4;
                public const long m_nFieldOutput = 0x1E0;
                public const long m_nControlPointNumber = 0x1E8;
            }
            public static partial class C_OP_RemapDistanceToLineSegmentToScalar {
                public const long m_nFieldOutput = 0x1F8;
                public const long m_flMaxOutputValue = 0x200;
                public const long m_flMinOutputValue = 0x1FC;
            }
            public static partial class C_OP_RemapDistanceToLineSegmentToVector {
                public const long m_nFieldOutput = 0x1F8;
                public const long m_vMaxOutputValue = 0x208;
                public const long m_vMinOutputValue = 0x1FC;
            }
            public static partial class C_INIT_InitSkinnedPositionFromCPSnapshot {
                public const long m_bRigid = 0x1F8;
                public const long m_bRandom = 0x1F0;
                public const long m_bIgnoreDt = 0x1FA;
                public const long m_bCopyAlpha = 0x395;
                public const long m_bCopyColor = 0x394;
                public const long m_bSetNormal = 0x1F9;
                public const long m_bSetRadius = 0x396;
                public const long m_nIndexType = 0x204;
                public const long m_flIncrement = 0x380;
                public const long m_flReadIndex = 0x208;
                public const long m_nRandomSeed = 0x1F4;
                public const long m_flBoneVelocity = 0x38C;
                public const long m_flBoneVelocityMax = 0x390;
                public const long m_nFullLoopIncrement = 0x384;
                public const long m_flMaxNormalVelocity = 0x200;
                public const long m_flMinNormalVelocity = 0x1FC;
                public const long m_nControlPointNumber = 0x1EC;
                public const long m_nSnapShotStartPoint = 0x388;
                public const long m_nSnapshotControlPointNumber = 0x1E8;
            }
            public static partial class C_OP_SetFloatAttributeToVectorExpression {
                public const long m_vInput1 = 0x1E8;
                public const long m_vInput2 = 0x8C0;
                public const long m_nSetMethod = 0x1114;
                public const long m_nExpression = 0x1E0;
                public const long m_nOutputField = 0x1110;
                public const long m_flOutputRemap = 0xF98;
            }
            public static partial class CPulseCell_IsRequirementValid__Criteria_t {
                public const long m_bIsValid = 0x0;
            }
            public static partial class C_OP_ConstrainDistanceToUserSpecifiedPath {
                public const long m_pointList = 0x1F0;
                public const long m_bLoopedPath = 0x1EC;
                public const long m_flTimeScale = 0x1E8;
                public const long m_fMinDistance = 0x1E0;
                public const long m_flMaxDistance = 0x1E4;
            }
            public static partial class C_OP_MultiSegmentDisplaySnapshotGenerator {
                public const long m_flValue = 0x200;
                public const long m_flRadius = 0x12B8;
                public const long m_flSpacing = 0x1430;
                public const long m_nSegCount = 0x1EC;
                public const long m_flMaxCount = 0x1720;
                public const long m_flMinCount = 0x15A8;
                public const long m_nInputType = 0x1F0;
                public const long m_nCPSnapshot = 0x1E8;
                public const long m_vecColorLit = 0xBE0;
                public const long m_bPrependEmpty = 0x1898;
                public const long m_flScollOffset = 0x378;
                public const long m_vecColorUnlit = 0x508;
                public const long m_SpecialCharList = 0x4F0;
                public const long m_strDefaultString = 0x1F8;
                public const long m_flDigitsAfterDecimal = 0x18A0;
            }
            public static partial class C_OP_RemapTransformOrientationToRotations {
                public const long m_bUseQuat = 0x254;
                public const long m_vecRotation = 0x248;
                public const long m_bWriteNormal = 0x255;
                public const long m_TransformInput = 0x1E0;
            }
            public static partial class C_OP_SetPerChildControlPointFromAttribute {
                public const long m_nCPField = 0x1FC;
                public const long m_nChildGroupID = 0x1E0;
                public const long m_nAttributeToRead = 0x1F8;
                public const long m_nFirstSourcePoint = 0x1F0;
                public const long m_nNumControlPoints = 0x1E8;
                public const long m_nFirstControlPoint = 0x1E4;
                public const long m_nParticleIncrement = 0x1EC;
                public const long m_bNumBasedOnParticleCount = 0x1F4;
            }
            public static partial class C_OP_SetVectorAttributeToVectorExpression {
                public const long m_flLerp = 0xF98;
                public const long m_vInput1 = 0x1E8;
                public const long m_vInput2 = 0x8C0;
                public const long m_nSetMethod = 0x1114;
                public const long m_nExpression = 0x1E0;
                public const long m_nOutputField = 0x1110;
                public const long m_bNormalizedOutput = 0x1118;
            }
            public static partial class C_INIT_SetFloatAttributeToVectorExpression {
                public const long m_vInput1 = 0x1F0;
                public const long m_vInput2 = 0x8C8;
                public const long m_nSetMethod = 0x111C;
                public const long m_nExpression = 0x1E8;
                public const long m_nOutputField = 0x1118;
                public const long m_flOutputRemap = 0xFA0;
            }
            public static partial class C_OP_EnableChildrenFromParentParticleCount {
                public const long m_nFirstChild = 0x1EC;
                public const long m_nChildGroupID = 0x1E8;
                public const long m_bDisableChildren = 0x368;
                public const long m_bPlayEndcapOnStop = 0x369;
                public const long m_bDestroyImmediately = 0x36A;
                public const long m_nNumChildrenToEnable = 0x1F0;
            }
            public static partial class C_OP_MovementSkinnedPositionFromCPSnapshot {
                public const long m_bRandom = 0x1E8;
                public const long m_bSetNormal = 0x1F0;
                public const long m_bSetRadius = 0x1F1;
                public const long m_nIndexType = 0x1F4;
                public const long m_flIncrement = 0x370;
                public const long m_flReadIndex = 0x1F8;
                public const long m_nRandomSeed = 0x1EC;
                public const long m_flInterpolation = 0x7D8;
                public const long m_nFullLoopIncrement = 0x4E8;
                public const long m_nControlPointNumber = 0x1E4;
                public const long m_nSnapShotStartPoint = 0x660;
                public const long m_nSnapshotControlPointNumber = 0x1E0;
            }
            public static partial class C_OP_RemapCrossProductOfTwoVectorsToVector {
                public const long m_InputVec1 = 0x1E0;
                public const long m_InputVec2 = 0x8B8;
                public const long m_bNormalize = 0xF94;
                public const long m_nFieldOutput = 0xF90;
            }
            public static partial class C_OP_RemapDensityGradientToVectorAttribute {
                public const long m_nFieldOutput = 0x1E4;
                public const long m_flRadiusScale = 0x1E0;
            }
            public static partial class C_INIT_RemapTransformOrientationToRotations {
                public const long m_bUseQuat = 0x25C;
                public const long m_vecRotation = 0x250;
                public const long m_bWriteNormal = 0x25D;
                public const long m_TransformInput = 0x1E8;
            }
            public static partial class C_INIT_SetVectorAttributeToVectorExpression {
                public const long m_flLerp = 0xFA0;
                public const long m_vInput1 = 0x1F0;
                public const long m_vInput2 = 0x8C8;
                public const long m_nSetMethod = 0x111C;
                public const long m_nExpression = 0x1E8;
                public const long m_nOutputField = 0x1118;
                public const long m_bNormalizedOutput = 0x1120;
            }
            public static partial class C_OP_RemapControlPointOrientationToRotation {
                public const long m_nCP = 0x1E0;
                public const long m_nComponent = 0x1EC;
                public const long m_flOffsetRot = 0x1E8;
                public const long m_nFieldOutput = 0x1E4;
            }
            public static partial class C_OP_SetControlPointFieldToScalarExpression {
                public const long m_flInput1 = 0x1F0;
                public const long m_flInput2 = 0x368;
                public const long m_nOutputCP = 0x658;
                public const long m_nExpression = 0x1E8;
                public const long m_flOutputRemap = 0x4E0;
                public const long m_flInterpolation = 0x660;
                public const long m_nOutVectorField = 0x65C;
            }
            public static partial class C_OP_SetControlPointOrientationToCPVelocity {
                public const long m_nCPInput = 0x1E8;
                public const long m_nCPOutput = 0x1EC;
            }
            public static partial class CPulseCell_Inflow_ObservableVariableListener {
                public const long m_bSelfReference = 0x82;
                public const long m_nBlackboardReference = 0x80;
            }
            public static partial class C_OP_SetControlPointPositionToRandomActiveCP {
                public const long m_nCP1 = 0x1E8;
                public const long m_flResetRate = 0x1F8;
                public const long m_nHeadLocationMax = 0x1F0;
                public const long m_nHeadLocationMin = 0x1EC;
            }
            public static partial class C_OP_SetControlPointPositionToTimeOfDayValue {
                public const long m_vecDefaultValue = 0x26C;
                public const long m_nControlPointNumber = 0x1E8;
                public const long m_pszTimeOfDayParameter = 0x1EC;
            }
            public static partial class PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                public const long m_OutflowID = 0x0;
                public const long m_Connection = 0x8;
            }
            public static partial class C_OP_SetControlPointFieldFromVectorExpression {
                public const long m_flLerp = 0xFA0;
                public const long m_nOutputCP = 0x1290;
                public const long m_vecInput1 = 0x1F0;
                public const long m_vecInput2 = 0x8C8;
                public const long m_nExpression = 0x1E8;
                public const long m_flOutputRemap = 0x1118;
                public const long m_nOutVectorField = 0x1294;
            }
            public static partial class C_INIT_RemapInitialDirectionToTransformToVector {
                public const long m_flScale = 0x254;
                public const long m_bNormalize = 0x268;
                public const long m_flOffsetRot = 0x258;
                public const long m_nFieldOutput = 0x250;
                public const long m_vecOffsetAxis = 0x25C;
                public const long m_TransformInput = 0x1E8;
            }
            public static partial class C_INIT_RemapInitialTransformDirectionToRotation {
                public const long m_nComponent = 0x258;
                public const long m_flOffsetRot = 0x254;
                public const long m_nFieldOutput = 0x250;
                public const long m_TransformInput = 0x1E8;
            }
            public static partial class CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                public const long m_nNextIndex = 0x0;
            }
            public static partial class CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                public const long m_Shuffle = 0x0;
                public const long m_nNextShuffle = 0x20;
            }
            public static partial class C_INIT_RemapParticleCountToNamedModelElementScalar {
                public const long m_hModel = 0x218;
                public const long m_outputMaxName = 0x228;
                public const long m_outputMinName = 0x220;
                public const long m_bModelFromRenderer = 0x230;
            }
            public static partial class C_INIT_RemapParticleCountToNamedModelBodyPartScalar {

            }
            public static partial class C_INIT_RemapParticleCountToNamedModelSequenceScalar {

            }
            public static partial class C_INIT_RemapParticleCountToNamedModelMeshGroupScalar {

            }
            public static partial class DetailCombo_t {
                public const long DETAIL_COMBO_ADD = 0x1;
                public const long DETAIL_COMBO_OFF = 0x0;
                public const long DETAIL_COMBO_MOD2X = 0x3;
                public const long DETAIL_COMBO_ADD_SELF_ILLUM = 0x2;
            }
            public static partial class Detail2Combo_t {
                public const long DETAIL_2_COMBO_ADD = 0x1;
                public const long DETAIL_2_COMBO_MUL = 0x4;
                public const long DETAIL_2_COMBO_OFF = 0x0;
                public const long DETAIL_2_COMBO_MOD2X = 0x3;
                public const long DETAIL_2_COMBO_CROSSFADE = 0x5;
                public const long DETAIL_2_COMBO_UNINITIALIZED = -0x1;
                public const long DETAIL_2_COMBO_ADD_SELF_ILLUM = 0x2;
            }
            public static partial class PetGroundType_t {
                public const long PET_GROUND_GRID = 0x1;
                public const long PET_GROUND_NONE = 0x0;
                public const long PET_GROUND_PLANE = 0x2;
            }
            public static partial class BBoxVolumeType_t {
                public const long BBOX_RADIUS = 0x3;
                public const long BBOX_VOLUME = 0x0;
                public const long BBOX_MINS_MAXS = 0x2;
                public const long BBOX_DIMENSIONS = 0x1;
                public const long BBOX_SURFACE_AREA = 0x4;
            }
            public static partial class BlurFilterType_t {
                public const long BLURFILTER_BOX = 0x1;
                public const long BLURFILTER_GAUSSIAN = 0x0;
            }
            public static partial class HitboxLerpType_t {
                public const long HITBOX_LERP_CONSTANT = 0x1;
                public const long HITBOX_LERP_LIFETIME = 0x0;
            }
            public static partial class ModelHitboxType_t {
                public const long MODEL_HITBOX_TYPE_SNAPSHOT = 0x3;
                public const long MODEL_HITBOX_TYPE_STANDARD = 0x0;
                public const long MODEL_HITBOX_TYPE_RAW_BONES = 0x1;
                public const long MODEL_HITBOX_TYPE_RENDERBOUNDS = 0x2;
            }
            public static partial class ParticleFanType_t {
                public const long PARTICLE_FAN_TYPE_FAN = 0x0;
                public const long PARTICLE_FAN_TYPE_RADIAL = 0x2;
                public const long PARTICLE_FAN_TYPE_ROTOR_WASH = 0x1;
            }
            public static partial class ParticleFogType_t {
                public const long PARTICLE_FOG_ENABLED = 0x1;
                public const long PARTICLE_FOG_DISABLED = 0x2;
                public const long PARTICLE_FOG_GAME_DEFAULT = 0x0;
            }
            public static partial class ParticleMassMode_t {
                public const long PARTICLE_MASSMODE_RADIUS_CUBED = 0x0;
                public const long PARTICLE_MASSMODE_RADIUS_SQUARED = 0x2;
            }
            public static partial class ParticleTopology_t {
                public const long PARTICLE_TOPOLOGY_TRIS = 0x2;
                public const long PARTICLE_TOPOLOGY_CUBES = 0x4;
                public const long PARTICLE_TOPOLOGY_LINES = 0x1;
                public const long PARTICLE_TOPOLOGY_QUADS = 0x3;
                public const long PARTICLE_TOPOLOGY_POINTS = 0x0;
            }
            public static partial class ParticleTraceSet_t {
                public const long PARTICLE_TRACE_SET_ALL = 0x0;
                public const long PARTICLE_TRACE_SET_STATIC = 0x1;
                public const long PARTICLE_TRACE_SET_DYNAMIC = 0x3;
                public const long PARTICLE_TRACE_SET_STATIC_AND_KEYFRAMED = 0x2;
            }
            public static partial class MaterialProxyType_t {
                public const long MATERIAL_PROXY_TINT = 0x1;
                public const long MATERIAL_PROXY_STATUS_EFFECT = 0x0;
            }
            public static partial class ParticleEntityPos_t {
                public const long PARTICLE_EYES = 0x2;
                public const long PARTICLE_ABS_ORIGIN = 0x0;
                public const long PARTICLE_FLASHLIGHT = 0x3;
                public const long PARTICLE_WORLDSPACE_CENTER = 0x1;
            }
            public static partial class ParticleSelection_t {
                public const long PARTICLE_SELECTION_LAST = 0x1;
                public const long PARTICLE_SELECTION_FIRST = 0x0;
                public const long PARTICLE_SELECTION_NUMBER = 0x2;
            }
            public static partial class SnapshotIndexType_t {
                public const long SNAPSHOT_INDEX_DIRECT = 0x1;
                public const long SNAPSHOT_INDEX_INCREMENT = 0x0;
            }
            public static partial class EventTypeSelection_t {
                public const long PARTICLE_EVENT_TYPE_MASK_NONE = 0x0;
                public const long PARTICLE_EVENT_TYPE_MASK_KILLED = 0x2;
                public const long PARTICLE_EVENT_TYPE_MASK_USER_1 = 0x40;
                public const long PARTICLE_EVENT_TYPE_MASK_USER_2 = 0x80;
                public const long PARTICLE_EVENT_TYPE_MASK_USER_3 = 0x100;
                public const long PARTICLE_EVENT_TYPE_MASK_USER_4 = 0x200;
                public const long PARTICLE_EVENT_TYPE_MASK_SPAWNED = 0x1;
                public const long PARTICLE_EVENT_TYPE_MASK_COLLISION = 0x4;
                public const long PARTICLE_EVENT_TYPE_MASK_KILLED_ON_CULL = 0x400;
                public const long PARTICLE_EVENT_TYPE_MASK_CULLED_ON_SPAWN = 0x800;
                public const long PARTICLE_EVENT_TYPE_MASK_FIRST_COLLISION = 0x8;
                public const long PARTICLE_EVENT_TYPE_MASK_COLLISION_STOPPED = 0x10;
                public const long PARTICLE_EVENT_TYPE_MASK_KILLED_ON_COLLISION = 0x20;
            }
            public static partial class ParticleEndcapMode_t {
                public const long PARTICLE_ENDCAP_ALWAYS_ON = -0x1;
                public const long PARTICLE_ENDCAP_ENDCAP_ON = 0x1;
                public const long PARTICLE_ENDCAP_ENDCAP_OFF = 0x0;
            }
            public static partial class ParticleToolsState_t {
                public const long PARTICLE_TOOLS_STATE_ALWAYS_ON = -0x1;
                public const long PARTICLE_TOOLS_STATE_GAME_ONLY = 0x1;
                public const long PARTICLE_TOOLS_STATE_TOOLS_ONLY = 0x0;
            }
            public static partial class InheritableBoolType_t {
                public const long INHERITABLE_BOOL_TRUE = 0x2;
                public const long INHERITABLE_BOOL_FALSE = 0x1;
                public const long INHERITABLE_BOOL_INHERIT = 0x0;
            }
            public static partial class ParticleDetailLevel_t {
                public const long PARTICLEDETAIL_LOW = 0x0;
                public const long PARTICLEDETAIL_HIGH = 0x2;
                public const long PARTICLEDETAIL_ULTRA = 0x3;
                public const long PARTICLEDETAIL_MEDIUM = 0x1;
            }
            public static partial class ParticleImpulseType_t {
                public const long IMPULSE_TYPE_NONE = 0x0;
                public const long IMPULSE_TYPE_ROPE = 0x2;
                public const long IMPULSE_TYPE_GENERIC = 0x1;
                public const long IMPULSE_TYPE_EXPLOSION = 0x4;
                public const long IMPULSE_TYPE_PARTICLE_SYSTEM = 0x10;
                public const long IMPULSE_TYPE_EXPLOSION_UNDERWATER = 0x8;
            }
            public static partial class ParticlePinDistance_t {
                public const long PARTICLE_PIN_SPEED = 0x9;
                public const long PARTICLE_PIN_DISTANCE_CP = 0x6;
                public const long PARTICLE_PIN_FLOAT_VALUE = 0xB;
                public const long PARTICLE_PIN_DISTANCE_LAST = 0x3;
                public const long PARTICLE_PIN_DISTANCE_NONE = -0x1;
                public const long PARTICLE_PIN_COLLECTION_AGE = 0xA;
                public const long PARTICLE_PIN_DISTANCE_FIRST = 0x2;
                public const long PARTICLE_PIN_DISTANCE_CENTER = 0x5;
                public const long PARTICLE_PIN_DISTANCE_FARTHEST = 0x1;
                public const long PARTICLE_PIN_DISTANCE_NEIGHBOR = 0x0;
                public const long PARTICLE_PIN_DISTANCE_CP_PAIR_BOTH = 0x8;
                public const long PARTICLE_PIN_DISTANCE_CP_PAIR_EITHER = 0x7;
            }
            public static partial class PulseMethodCallMode_t {
                public const long ASYNC_FIRE_AND_FORGET = 0x1;
                public const long SYNC_WAIT_FOR_COMPLETION = 0x0;
            }
            public static partial class ClosestPointTestType_t {
                public const long PARTICLE_CLOSEST_TYPE_BOX = 0x0;
                public const long PARTICLE_CLOSEST_TYPE_HYBRID = 0x2;
                public const long PARTICLE_CLOSEST_TYPE_CAPSULE = 0x1;
            }
            public static partial class ParticleAttrBoxFlags_t {
                public const long PARTICLE_ATTR_BOX_FLAGS_NONE = 0x0;
                public const long PARTICLE_ATTR_BOX_FLAGS_WATER = 0x1;
                public const long PARTICLE_ATTR_BOX_FLAGS_ASLEEP = 0x8;
                public const long PARTICLE_ATTR_BOX_FLAGS_FROZEN = 0x10;
                public const long PARTICLE_ATTR_BOX_FLAGS_ON_FIRE = 0x2;
                public const long PARTICLE_ATTR_BOX_FLAGS_WAKE_DECAY = 0x80;
                public const long PARTICLE_ATTR_BOX_FLAGS_ELECTRIFIED = 0x4;
                public const long PARTICLE_ATTR_BOX_FLAGS_TIMED_DECAY = 0x20;
                public const long PARTICLE_ATTR_BOX_FLAGS_ZERO_GRAVITY = 0x200;
                public const long PARTICLE_ATTR_BOX_FLAGS_MOTION_DISABLED = 0x100;
                public const long PARTICLE_ATTR_BOX_FLAGS_DISABLE_NONSTATIC_COLLISION = 0x40;
            }
            public static partial class ScalarExpressionType_t {
                public const long SCALAR_EXPRESSION_GT = 0x9;
                public const long SCALAR_EXPRESSION_LT = 0xA;
                public const long SCALAR_EXPRESSION_ADD = 0x0;
                public const long SCALAR_EXPRESSION_MAX = 0x6;
                public const long SCALAR_EXPRESSION_MIN = 0x5;
                public const long SCALAR_EXPRESSION_MOD = 0x7;
                public const long SCALAR_EXPRESSION_MUL = 0x2;
                public const long SCALAR_EXPRESSION_EQUAL = 0x8;
                public const long SCALAR_EXPRESSION_DIVIDE = 0x3;
                public const long SCALAR_EXPRESSION_INPUT_1 = 0x4;
                public const long SCALAR_EXPRESSION_SUBTRACT = 0x1;
                public const long SCALAR_EXPRESSION_UNINITIALIZED = -0x1;
            }
            public static partial class SpriteCardShaderType_t {
                public const long SPRITECARD_SHADER_BASE = 0x0;
                public const long SPRITECARD_SHADER_CUSTOM = 0x1;
            }
            public static partial class VectorExpressionType_t {
                public const long VECTOR_EXPRESSION_ADD = 0x0;
                public const long VECTOR_EXPRESSION_MAX = 0x6;
                public const long VECTOR_EXPRESSION_MIN = 0x5;
                public const long VECTOR_EXPRESSION_MUL = 0x2;
                public const long VECTOR_EXPRESSION_LERP = 0x8;
                public const long VECTOR_EXPRESSION_DIVIDE = 0x3;
                public const long VECTOR_EXPRESSION_INPUT_1 = 0x4;
                public const long VECTOR_EXPRESSION_SUBTRACT = 0x1;
                public const long VECTOR_EXPRESSION_CROSSPRODUCT = 0x7;
                public const long VECTOR_EXPRESSION_UNINITIALIZED = -0x1;
            }
            public static partial class ParticleCollisionMask_t {
                public const long PARTICLE_MASK_ALL = -0x1;
                public const long PARTICLE_MASK_SHOT = 0x1C1003;
                public const long PARTICLE_MASK_SOLID = 0xC3001;
                public const long PARTICLE_MASK_WATER = 0x18000;
                public const long PARTICLE_MASK_OPAQUE = 0x80;
                public const long PARTICLE_MASK_NPCSOLID = 0xC3021;
                public const long PARTICLE_MASK_SHOT_HULL = 0x1C3001;
                public const long PARTICLE_MASK_SOLID_WATER = 0xDB001;
                public const long PARTICLE_MASK_SHOT_BRUSHONLY = 0x101001;
                public const long PARTICLE_MASK_DEFAULTPLAYERSOLID = 0xC3011;
            }
            public static partial class ParticleCollisionMode_t {
                public const long COLLISION_MODE_DISABLED = -0x1;
                public const long COLLISION_MODE_USE_NEAREST_TRACE = 0x2;
                public const long COLLISION_MODE_INITIAL_TRACE_DOWN = 0x0;
                public const long COLLISION_MODE_PER_FRAME_PLANESET = 0x1;
                public const long COLLISION_MODE_PER_PARTICLE_TRACE = 0x3;
            }
            public static partial class ParticleParentSetMode_t {
                public const long PARTICLE_SET_PARENT_NO = 0x0;
                public const long PARTICLE_SET_PARENT_ROOT = 0x2;
                public const long PARTICLE_SET_PARENT_IMMEDIATE = 0x1;
            }
            public static partial class PulseBestOutflowRules_t {
                public const long SORT_BY_OUTFLOW_INDEX = 0x1;
                public const long SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0;
            }
            public static partial class SpriteCardTextureType_t {
                public const long SPRITECARD_TEXTURE_ZOOM = 0x1;
                public const long SPRITECARD_TEXTURE_DEPTH = 0xA;
                public const long SPRITECARD_TEXTURE_DIFFUSE = 0x0;
                public const long SPRITECARD_TEXTURE_NORMALMAP = 0x5;
                public const long SPRITECARD_TEXTURE_UVDISTORTION = 0x3;
                public const long SPRITECARD_TEXTURE_ANIMMOTIONVEC = 0x6;
                public const long SPRITECARD_TEXTURE_1D_COLOR_LOOKUP = 0x2;
                public const long SPRITECARD_TEXTURE_UVDISTORTION_ZOOM = 0x4;
                public const long SPRITECARD_TEXTURE_ILLUMINATION_GRADIENT = 0xB;
                public const long SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_A = 0x7;
                public const long SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_B = 0x8;
                public const long SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_C = 0x9;
            }
            public static partial class TextureRepetitionMode_t {
                public const long TEXTURE_REPETITION_PATH = 0x1;
                public const long TEXTURE_REPETITION_PARTICLE = 0x0;
            }
            public static partial class PFuncVisualizationType_t {
                public const long PFUNC_VISUALIZATION_BOX = 0x2;
                public const long PFUNC_VISUALIZATION_LINE = 0x5;
                public const long PFUNC_VISUALIZATION_RING = 0x3;
                public const long PFUNC_VISUALIZATION_PLANE = 0x4;
                public const long PFUNC_VISUALIZATION_CYLINDER = 0x6;
                public const long PFUNC_VISUALIZATION_SPHERE_SOLID = 0x1;
                public const long PFUNC_VISUALIZATION_SPHERE_WIREFRAME = 0x0;
            }
            public static partial class ParticleCollisionGroup_t {
                public const long PARTICLE_COLLISION_GROUP_NPC = 0xC;
                public const long PARTICLE_COLLISION_GROUP_PROPS = 0x18;
                public const long PARTICLE_COLLISION_GROUP_DEBRIS = 0x5;
                public const long PARTICLE_COLLISION_GROUP_PLAYER = 0x8;
                public const long PARTICLE_COLLISION_GROUP_DEFAULT = 0x4;
                public const long PARTICLE_COLLISION_GROUP_VEHICLE = 0xA;
                public const long PARTICLE_COLLISION_GROUP_INTERACTIVE = 0x7;
            }
            public static partial class ParticleHitboxBiasType_t {
                public const long PARTICLE_HITBOX_BIAS_ENTITY = 0x0;
                public const long PARTICLE_HITBOX_BIAS_HITBOX = 0x1;
            }
            public static partial class ParticleLiquidContents_t {
                public const long PARTICLE_LIQUID_OIL = 0x1;
                public const long PARTICLE_LIQUID_NONE = 0x0;
                public const long PARTICLE_LIQUID_WATER = 0x2;
            }
            public static partial class ParticleFalloffFunction_t {
                public const long PARTICLE_FALLOFF_LINEAR = 0x1;
                public const long PARTICLE_FALLOFF_CONSTANT = 0x0;
                public const long PARTICLE_FALLOFF_EXPONENTIAL = 0x2;
            }
            public static partial class ParticleLightingQuality_t {
                public const long PARTICLE_LIGHTING_PER_PIXEL = -0x1;
                public const long PARTICLE_LIGHTING_PER_VERTEX = 0x1;
                public const long PARTICLE_LIGHTING_PER_PARTICLE = 0x0;
                public const long PARTICLE_LIGHTING_OVERRIDE_COLOR = 0x3;
                public const long PARTICLE_LIGHTING_ADD_EXTRA_LIGHT = 0x4;
                public const long PARTICLE_LIGHTING_OVERRIDE_POSITION = 0x2;
            }
            public static partial class ParticleOrientationType_t {
                public const long PARTICLE_ORIENTATION_NONE = 0x0;
                public const long PARTICLE_ORIENTATION_NORMAL = 0x2;
                public const long PARTICLE_ORIENTATION_ROTATION = 0x4;
                public const long PARTICLE_ORIENTATION_VELOCITY = 0x1;
            }
            public static partial class ParticleOutputBlendMode_t {
                public const long PARTICLE_OUTPUT_BLEND_MODE_ADD = 0x1;
                public const long PARTICLE_OUTPUT_BLEND_MODE_ALPHA = 0x0;
                public const long PARTICLE_OUTPUT_BLEND_MODE_MOD2X = 0x5;
                public const long PARTICLE_OUTPUT_BLEND_MODE_LIGHTEN = 0x6;
                public const long PARTICLE_OUTPUT_BLEND_MODE_BLEND_ADD = 0x2;
                public const long PARTICLE_OUTPUT_BLEND_MODE_HALF_BLEND_ADD = 0x3;
                public const long PARTICLE_OUTPUT_BLEND_MODE_NEG_HALF_BLEND_ADD = 0x4;
            }
            public static partial class PulseCursorWakePriority_t {
                public const long WakeElegantly = 0x0;
                public const long WakeImmediate = 0x1;
            }
            public static partial class ParticleControlPointAxis_t {
                public const long PARTICLE_CP_AXIS_X = 0x0;
                public const long PARTICLE_CP_AXIS_Y = 0x1;
                public const long PARTICLE_CP_AXIS_Z = 0x2;
                public const long PARTICLE_CP_AXIS_NEGATIVE_X = 0x3;
                public const long PARTICLE_CP_AXIS_NEGATIVE_Y = 0x4;
                public const long PARTICLE_CP_AXIS_NEGATIVE_Z = 0x5;
            }
            public static partial class ParticleRotationLockType_t {
                public const long PARTICLE_ROTATION_LOCK_NONE = 0x0;
                public const long PARTICLE_ROTATION_LOCK_NORMAL = 0x2;
                public const long PARTICLE_ROTATION_LOCK_ROTATIONS = 0x1;
            }
            public static partial class ParticleVRHandChoiceList_t {
                public const long PARTICLE_VRHAND_CP = 0x2;
                public const long PARTICLE_VRHAND_LEFT = 0x0;
                public const long PARTICLE_VRHAND_RIGHT = 0x1;
                public const long PARTICLE_VRHAND_CP_OBJECT = 0x3;
            }
            public static partial class SpriteCardTextureChannel_t {
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_A = 0x2;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_B = 0xB;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_G = 0xA;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_R = 0x9;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_RGB = 0x0;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_RGBA = 0x1;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_A = 0x3;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_BALPHA = 0xE;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_GALPHA = 0xD;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_RALPHA = 0xC;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_A_RGBALPHA = 0x7;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_RGBMASK = 0x5;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_RGBA_RGBALPHA = 0x6;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_ALPHAMASK = 0x4;
                public const long SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_A_RGBALPHA = 0x8;
            }
            public static partial class ParticleSortingChoiceList_t {
                public const long PARTICLE_SORTING_NEAREST = 0x0;
                public const long PARTICLE_SORTING_CREATION_TIME = 0x1;
            }
            public static partial class ParticleTraceMissBehavior_t {
                public const long PARTICLE_TRACE_MISS_BEHAVIOR_KILL = 0x1;
                public const long PARTICLE_TRACE_MISS_BEHAVIOR_NONE = 0x0;
                public const long PARTICLE_TRACE_MISS_BEHAVIOR_TRACE_END = 0x2;
            }
            public static partial class PulseCursorCancelPriority_t {
                public const long _None = 0x0;
                public const long HardCancel = 0x3;
                public const long SoftCancel = 0x2;
                public const long CancelOnSucceeded = 0x1;
            }
            public static partial class VectorFloatExpressionType_t {
                public const long VECTOR_FLOAT_EXPRESSION_DISTANCE = 0x1;
                public const long VECTOR_FLOAT_EXPRESSION_DOTPRODUCT = 0x0;
                public const long VECTOR_FLOAT_EXPRESSION_DISTANCESQR = 0x2;
                public const long VECTOR_FLOAT_EXPRESSION_INPUT1_NOISE = 0x5;
                public const long VECTOR_FLOAT_EXPRESSION_INPUT1_LENGTH = 0x3;
                public const long VECTOR_FLOAT_EXPRESSION_UNINITIALIZED = -0x1;
                public const long VECTOR_FLOAT_EXPRESSION_INPUT1_LENGTHSQR = 0x4;
            }
            public static partial class ParticleAlphaReferenceType_t {
                public const long PARTICLE_ALPHA_REFERENCE_ALPHA_ALPHA = 0x0;
                public const long PARTICLE_ALPHA_REFERENCE_ALPHA_OPAQUE = 0x2;
                public const long PARTICLE_ALPHA_REFERENCE_OPAQUE_ALPHA = 0x1;
                public const long PARTICLE_ALPHA_REFERENCE_OPAQUE_OPAQUE = 0x3;
            }
            public static partial class ParticleOrientationSetMode_t {
                public const long PARTICLE_ORIENTATION_SET_NONE = -0x1;
                public const long PARTICLE_ORIENTATION_SET_FROM_NORMAL = 0x1;
                public const long PARTICLE_ORIENTATION_SET_FROM_VELOCITY = 0x0;
                public const long PARTICLE_ORIENTATION_SET_FROM_ROTATIONS = 0x2;
            }
            public static partial class SetStatisticExpressionType_t {
                public const long SET_EXPRESSION_MAX = 0x6;
                public const long SET_EXPRESSION_MIN = 0x5;
                public const long SET_EXPRESSION_SUM = 0x0;
                public const long SET_EXPRESSION_MEAN = 0x1;
                public const long SET_EXPRESSION_MODE = 0x3;
                public const long SET_EXPRESSION_MEDIAN = 0x2;
                public const long SET_EXPRESSION_UNINITIALIZED = -0x1;
                public const long SET_EXPRESSION_STANDARD_DEVIATION = 0x4;
            }
            public static partial class SpriteCardPerParticleScale_t {
                public const long SPRITECARD_TEXTURE_PP_SCALE_YAW = 0x8;
                public const long SPRITECARD_TEXTURE_PP_SCALE_NONE = 0x0;
                public const long SPRITECARD_TEXTURE_PP_SCALE_ROLL = 0x7;
                public const long SPRITECARD_TEXTURE_PP_SCALE_PITCH = 0x9;
                public const long SPRITECARD_TEXTURE_PP_SCALE_RANDOM = 0xA;
                public const long SPRITECARD_TEXTURE_PP_SCALE_NEG_RANDOM = 0xB;
                public const long SPRITECARD_TEXTURE_PP_SCALE_RANDOM_TIME = 0xC;
                public const long SPRITECARD_TEXTURE_PP_SCALE_PARTICLE_AGE = 0x1;
                public const long SPRITECARD_TEXTURE_PP_SCALE_SHADER_RADIUS = 0x6;
                public const long SPRITECARD_TEXTURE_PP_SCALE_PARTICLE_ALPHA = 0x5;
                public const long SPRITECARD_TEXTURE_PP_SCALE_ANIMATION_FRAME = 0x2;
                public const long SPRITECARD_TEXTURE_PP_SCALE_NEG_RANDOM_TIME = 0xD;
                public const long SPRITECARD_TEXTURE_PP_SCALE_SHADER_EXTRA_DATA1 = 0x3;
                public const long SPRITECARD_TEXTURE_PP_SCALE_SHADER_EXTRA_DATA2 = 0x4;
            }
            public static partial class ParticleDepthFeatheringMode_t {
                public const long PARTICLE_DEPTH_FEATHERING_OFF = 0x0;
                public const long PARTICLE_DEPTH_FEATHERING_ON_OPTIONAL = 0x1;
                public const long PARTICLE_DEPTH_FEATHERING_ON_REQUIRED = 0x2;
            }
            public static partial class ParticleHitboxDataSelection_t {
                public const long PARTICLE_HITBOX_COUNT = 0x1;
                public const long PARTICLE_HITBOX_AVERAGE_SPEED = 0x0;
            }
            public static partial class ParticleLightTypeChoiceList_t {
                public const long PARTICLE_LIGHT_TYPE_FX = 0x2;
                public const long PARTICLE_LIGHT_TYPE_SPOT = 0x1;
                public const long PARTICLE_LIGHT_TYPE_POINT = 0x0;
                public const long PARTICLE_LIGHT_TYPE_CAPSULE = 0x3;
            }
            public static partial class ParticleLightUnitChoiceList_t {
                public const long PARTICLE_LIGHT_UNIT_LUMENS = 0x1;
                public const long PARTICLE_LIGHT_UNIT_CANDELAS = 0x0;
            }
            public static partial class ParticleVolumetricSmokeType_t {
                public const long PARTICLE_VOLUMETRIC_SMOKE_TYPE_SINK = 0x1;
                public const long PARTICLE_VOLUMETRIC_SMOKE_TYPE_REPEL = 0x2;
                public const long PARTICLE_VOLUMETRIC_SMOKE_TYPE_TRACE = 0x3;
                public const long PARTICLE_VOLUMETRIC_SMOKE_TYPE_EMISSION = 0x0;
            }
            public static partial class MissingParentInheritBehavior_t {
                public const long MISSING_PARENT_KILL = 0x0;
                public const long MISSING_PARENT_FIND_NEW = 0x1;
                public const long MISSING_PARENT_DO_NOTHING = -0x1;
                public const long MISSING_PARENT_SAME_INDEX = 0x2;
            }
            public static partial class ParticleLightFogLightingMode_t {
                public const long PARTICLE_LIGHT_FOG_LIGHTING_MODE_NONE = 0x0;
                public const long PARTICLE_LIGHT_FOG_LIGHTING_MODE_DYNAMIC = 0x2;
                public const long PARTICLE_LIGHT_FOG_LIGHTING_MODE_DYNAMIC_NOSHADOWS = 0x4;
            }
            public static partial class ParticleSequenceCropOverride_t {
                public const long PARTICLE_SEQUENCE_CROP_OVERRIDE_DEFAULT = -0x1;
                public const long PARTICLE_SEQUENCE_CROP_OVERRIDE_FORCE_ON = 0x1;
                public const long PARTICLE_SEQUENCE_CROP_OVERRIDE_FORCE_OFF = 0x0;
            }
            public static partial class RenderModelSubModelFieldType_t {
                public const long SUBMODEL_AS_MESHGROUP_MASK = 0x2;
                public const long SUBMODEL_AS_MESHGROUP_INDEX = 0x1;
                public const long SUBMODEL_AS_BODYGROUP_SUBMODEL = 0x0;
                public const long SUBMODEL_IGNORED_USE_MODEL_DEFAULT_MESHGROUP_MASK = 0x3;
            }
            public static partial class ParticleOrientationChoiceList_t {
                public const long PARTICLE_ORIENTATION_SCREEN_ALIGNED = 0x0;
                public const long PARTICLE_ORIENTATION_WORLD_Z_ALIGNED = 0x2;
                public const long PARTICLE_ORIENTATION_SCREEN_Z_ALIGNED = 0x1;
                public const long PARTICLE_ORIENTATION_FULL_3AXIS_ROTATION = 0x5;
                public const long PARTICLE_ORIENTATION_ALIGN_TO_PARTICLE_NORMAL = 0x3;
                public const long PARTICLE_ORIENTATION_SCREENALIGN_TO_PARTICLE_NORMAL = 0x4;
            }
            public static partial class ParticleTextureLayerBlendType_t {
                public const long SPRITECARD_TEXTURE_BLEND_ADD = 0x3;
                public const long SPRITECARD_TEXTURE_BLEND_MOD2X = 0x1;
                public const long SPRITECARD_TEXTURE_BLEND_AVERAGE = 0x5;
                public const long SPRITECARD_TEXTURE_BLEND_REPLACE = 0x2;
                public const long SPRITECARD_TEXTURE_BLEND_MULTIPLY = 0x0;
                public const long SPRITECARD_TEXTURE_BLEND_SUBTRACT = 0x4;
                public const long SPRITECARD_TEXTURE_BLEND_LUMINANCE = 0x6;
            }
            public static partial class ParticleLightBehaviorChoiceList_t {
                public const long PARTICLE_LIGHT_BEHAVIOR_ROPE = 0x1;
                public const long PARTICLE_LIGHT_BEHAVIOR_TRAILS = 0x2;
                public const long PARTICLE_LIGHT_BEHAVIOR_FOLLOW_DIRECTION = 0x0;
            }
            public static partial class ParticleLightnintBranchBehavior_t {
                public const long PARTICLE_LIGHTNING_BRANCH_CURRENT_DIR = 0x0;
                public const long PARTICLE_LIGHTNING_BRANCH_ENDPOINT_DIR = 0x1;
            }
            public static partial class ParticleOmni2LightTypeChoiceList_t {
                public const long PARTICLE_OMNI2_LIGHT_TYPE_BARN = 0x2;
                public const long PARTICLE_OMNI2_LIGHT_TYPE_POINT = 0x0;
                public const long PARTICLE_OMNI2_LIGHT_TYPE_SPHERE = 0x1;
            }
            public static partial class ParticlePostProcessPriorityGroup_t {
                public const long PARTICLE_POST_PROCESS_PRIORITY_GLOBAL_UI = 0x5;
                public const long PARTICLE_POST_PROCESS_PRIORITY_LEVEL_VOLUME = 0x0;
                public const long PARTICLE_POST_PROCESS_PRIORITY_LEVEL_OVERRIDE = 0x1;
                public const long PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_EFFECT = 0x2;
                public const long PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_STATE_LOW = 0x3;
                public const long PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_STATE_HIGH = 0x4;
            }
            public static partial class StandardLightingAttenuationStyle_t {
                public const long LIGHT_STYLE_NEW = 0x1;
                public const long LIGHT_STYLE_OLD = 0x0;
            }
            public static partial class ParticleMultiSegmentCountSelection_t {
                public const long PARTICLE_MULTISEGMENT_SEG_COUNT_7 = 0x7;
                public const long PARTICLE_MULTISEGMENT_SEG_COUNT_14 = 0xE;
                public const long PARTICLE_MULTISEGMENT_SEG_COUNT_16 = 0x10;
            }
            public static partial class ParticleMultiSegmentInputSelection_t {
                public const long PARTICLE_MULTISEGMENT_SELECTION_FLOAT = 0x0;
                public const long PARTICLE_MULTISEGMENT_SELECTION_STRING = 0x1;
            }
            public static partial class ParticleVolumetricSmokeCreationType_t {
                public const long PARTICLE_VOLUMETRIC_SMOKE_TYPE_IMPULSE = 0x1;
                public const long PARTICLE_VOLUMETRIC_SMOKE_TYPE_CONTINUOUS = 0x0;
            }
            public static partial class ParticleMultiSegmentSpecialCharacter_t {
                public const long PARTICLE_MULTISEGMENT_SPECIAL_NONE = -0x1;
                public const long PARTICLE_MULTISEGMENT_SPECIAL_COLON = 0x1;
                public const long PARTICLE_MULTISEGMENT_SPECIAL_DECIMAL = 0x0;
                public const long PARTICLE_MULTISEGMENT_SPECIAL_DEGREES = 0x2;
            }
            public static partial class ParticleOmni2LighOrientationChoiceList_t {
                public const long PARTICLE_OMNI2_LIGHT_ORIENTATION_NORMAL = 0x1;
                public const long PARTICLE_OMNI2_LIGHT_ORIENTATION_TARGET = 0x3;
                public const long PARTICLE_OMNI2_LIGHT_ORIENTATION_ROTATIONS = 0x0;
                public const long PARTICLE_OMNI2_LIGHT_ORIENTATION_NORMAL_ROLL = 0x2;
                public const long PARTICLE_OMNI2_LIGHT_ORIENTATION_TARGET_ROLL = 0x4;
            }
        }
    }
}
