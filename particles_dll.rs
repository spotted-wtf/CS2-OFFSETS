#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod schemas {
        pub mod particles_dll {
            pub mod C_OP_Cull {
                pub const m_flCullEnd: i64 = 0x1E8;
                pub const m_flCullExp: i64 = 0x1EC;
                pub const m_flCullPerc: i64 = 0x1E0;
                pub const m_flCullStart: i64 = 0x1E4;
            }
            pub mod C_OP_Spin {

            }
            pub mod C_OP_Decay {
                pub const m_bRopeDecay: i64 = 0x1E0;
                pub const m_bForcePreserveParticleOrder: i64 = 0x1E1;
            }
            pub mod C_OP_Noise {
                pub const m_bAdditive: i64 = 0x1F0;
                pub const m_flOutputMax: i64 = 0x1E8;
                pub const m_flOutputMin: i64 = 0x1E4;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_fl4NoiseScale: i64 = 0x1EC;
                pub const m_flNoiseAnimationTimeScale: i64 = 0x1F4;
            }
            pub mod C_OP_FadeIn {
                pub const m_bProportional: i64 = 0x1EC;
                pub const m_flFadeInTimeExp: i64 = 0x1E8;
                pub const m_flFadeInTimeMax: i64 = 0x1E4;
                pub const m_flFadeInTimeMin: i64 = 0x1E0;
            }
            pub mod C_OP_SetVec {
                pub const m_Lerp: i64 = 0x8C0;
                pub const m_InputValue: i64 = 0x1E0;
                pub const m_nSetMethod: i64 = 0x8BC;
                pub const m_nOutputField: i64 = 0x8B8;
                pub const m_bNormalizedOutput: i64 = 0xA38;
            }
            pub mod CGeneralSpin {
                pub const m_nSpinRateDegrees: i64 = 0x1E0;
                pub const m_fSpinRateStopTime: i64 = 0x1EC;
                pub const m_nSpinRateMinDegrees: i64 = 0x1E4;
            }
            pub mod C_OP_FadeOut {
                pub const m_flFadeBias: i64 = 0x1EC;
                pub const m_bEaseInAndOut: i64 = 0x221;
                pub const m_bProportional: i64 = 0x220;
                pub const m_flFadeOutTimeExp: i64 = 0x1E8;
                pub const m_flFadeOutTimeMax: i64 = 0x1E4;
                pub const m_flFadeOutTimeMin: i64 = 0x1E0;
            }
            pub mod C_OP_SetToCP {
                pub const m_vecOffset: i64 = 0x1E4;
                pub const m_bOffsetLocal: i64 = 0x1F0;
                pub const m_nControlPointNumber: i64 = 0x1E0;
            }
            pub mod C_OP_SpinYaw {

            }
            pub mod C_OP_Callback {

            }
            pub mod C_OP_SetFloat {
                pub const m_Lerp: i64 = 0x360;
                pub const m_InputValue: i64 = 0x1E0;
                pub const m_nSetMethod: i64 = 0x35C;
                pub const m_nOutputField: i64 = 0x358;
            }
            pub mod CPAssignment_t {
                pub const m_Pos: i64 = 0x8;
                pub const m_nCPNumber: i64 = 0x0;
                pub const m_nOrientationMode: i64 = 0x6E0;
            }
            pub mod CPulseGraphDef {
                pub const m_Vars: i64 = 0x80;
                pub const m_Cells: i64 = 0x68;
                pub const m_Chunks: i64 = 0x50;
                pub const m_CallInfos: i64 = 0xE0;
                pub const m_Constants: i64 = 0xF8;
                pub const m_DomainValues: i64 = 0x110;
                pub const m_TempVarBanks: i64 = 0x98;
                pub const m_DomainSubType: i64 = 0x18;
                pub const m_ParentMapName: i64 = 0x30;
                pub const m_ParentXmlName: i64 = 0x40;
                pub const m_PublicOutputs: i64 = 0xB0;
                pub const m_InvokeBindings: i64 = 0xC8;
                pub const m_DomainIdentifier: i64 = 0x8;
                pub const m_OutputConnections: i64 = 0x140;
                pub const m_BlackboardReferences: i64 = 0x128;
            }
            pub mod C_INIT_InitVec {
                pub const m_InputValue: i64 = 0x1E8;
                pub const m_nSetMethod: i64 = 0x8C4;
                pub const m_nOutputField: i64 = 0x8C0;
                pub const m_bNormalizedOutput: i64 = 0x8C8;
                pub const m_bWritePreviousPosition: i64 = 0x8C9;
            }
            pub mod C_OP_Diffusion {
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_flRadiusScale: i64 = 0x1E0;
                pub const m_nVoxelGridResolution: i64 = 0x1E8;
            }
            pub mod C_OP_ModelCull {
                pub const m_bBoundBox: i64 = 0x1E4;
                pub const m_bUseBones: i64 = 0x1E6;
                pub const m_bCullOutside: i64 = 0x1E5;
                pub const m_HitboxSetName: i64 = 0x1E7;
                pub const m_nControlPointNumber: i64 = 0x1E0;
            }
            pub mod C_OP_PlaneCull {
                pub const m_bLocalSpace: i64 = 0x8C0;
                pub const m_flPlaneOffset: i64 = 0x8C4;
                pub const m_vecPlaneDirection: i64 = 0x1E8;
                pub const m_nPlaneControlPoint: i64 = 0x1E0;
            }
            pub mod C_OP_RtEnvCull {
                pub const m_nRTEnvCP: i64 = 0x27C;
                pub const m_RtEnvName: i64 = 0x1FA;
                pub const m_nComponent: i64 = 0x280;
                pub const m_vecTestDir: i64 = 0x1E0;
                pub const m_bCullOnMiss: i64 = 0x1F8;
                pub const m_vecTestNormal: i64 = 0x1EC;
                pub const m_bStickInsteadOfCull: i64 = 0x1F9;
            }
            pub mod C_OP_WindForce {
                pub const m_vForce: i64 = 0x1F0;
            }
            pub mod TextureGroup_t {
                pub const m_Gradient: i64 = 0x10;
                pub const m_bEnabled: i64 = 0x0;
                pub const m_hTexture: i64 = 0x8;
                pub const m_nTextureType: i64 = 0x28;
                pub const m_flTextureBlend: i64 = 0x38;
                pub const m_TextureControls: i64 = 0x1B0;
                pub const m_nTextureChannels: i64 = 0x2C;
                pub const m_nTextureBlendMode: i64 = 0x30;
                pub const m_bReplaceTextureWithGradient: i64 = 0x1;
            }
            pub mod CPathParameters {
                pub const m_flBulge: i64 = 0x10;
                pub const m_flMidPoint: i64 = 0x14;
                pub const m_vEndOffset: i64 = 0x30;
                pub const m_nBulgeControl: i64 = 0xC;
                pub const m_vMidPointOffset: i64 = 0x24;
                pub const m_vStartPointOffset: i64 = 0x18;
                pub const m_nEndControlPointNumber: i64 = 0x8;
                pub const m_nMidControlPointNumber: i64 = 0x4;
                pub const m_nStartControlPointNumber: i64 = 0x0;
            }
            pub mod CPulseCell_Base {
                pub const m_nEditorNodeID: i64 = 0x8;
            }
            pub mod CPulse_CallInfo {
                pub const m_PortName: i64 = 0x0;
                pub const m_nSrcChunk: i64 = 0x4C;
                pub const m_RegisterMap: i64 = 0x18;
                pub const m_CallMethodID: i64 = 0x48;
                pub const m_nEditorNodeID: i64 = 0x10;
                pub const m_nBreakDestChunk: i64 = 0x54;
                pub const m_nSrcInstruction: i64 = 0x50;
                pub const m_nBreakDestInstruction: i64 = 0x58;
            }
            pub mod CSpinUpdateBase {

            }
            pub mod C_INIT_AgeNoise {
                pub const m_bAbsVal: i64 = 0x1E8;
                pub const m_flAgeMax: i64 = 0x1F4;
                pub const m_flAgeMin: i64 = 0x1F0;
                pub const m_flOffset: i64 = 0x1EC;
                pub const m_bAbsValInv: i64 = 0x1E9;
                pub const m_flNoiseScale: i64 = 0x1F8;
                pub const m_vecOffsetLoc: i64 = 0x200;
                pub const m_flNoiseScaleLoc: i64 = 0x1FC;
            }
            pub mod C_INIT_RingWave {
                pub const m_flYaw: i64 = 0xC98;
                pub const m_flRoll: i64 = 0x9A8;
                pub const m_flPitch: i64 = 0xB20;
                pub const m_flThickness: i64 = 0x540;
                pub const m_TransformInput: i64 = 0x1E8;
                pub const m_bXYVelocityOnly: i64 = 0xE11;
                pub const m_flInitialRadius: i64 = 0x3C8;
                pub const m_bEvenDistribution: i64 = 0xE10;
                pub const m_flInitialSpeedMax: i64 = 0x830;
                pub const m_flInitialSpeedMin: i64 = 0x6B8;
                pub const m_flParticlesPerOrbit: i64 = 0x250;
            }
            pub mod C_OP_AlphaDecay {
                pub const m_flMinAlpha: i64 = 0x1E0;
            }
            pub mod C_OP_DampenToCP {
                pub const m_flRange: i64 = 0x1E4;
                pub const m_flScale: i64 = 0x1E8;
                pub const m_nControlPointNumber: i64 = 0x1E0;
            }
            pub mod C_OP_LerpScalar {
                pub const m_flOutput: i64 = 0x1E8;
                pub const m_flEndTime: i64 = 0x364;
                pub const m_flStartTime: i64 = 0x360;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_LerpVector {
                pub const m_flEndTime: i64 = 0x1F4;
                pub const m_vecOutput: i64 = 0x1E4;
                pub const m_nSetMethod: i64 = 0x1F8;
                pub const m_flStartTime: i64 = 0x1F0;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_LockPoints {
                pub const m_nMaxCol: i64 = 0x1E4;
                pub const m_nMaxRow: i64 = 0x1EC;
                pub const m_nMinCol: i64 = 0x1E0;
                pub const m_nMinRow: i64 = 0x1E8;
                pub const m_flBlendValue: i64 = 0x1F4;
                pub const m_nControlPoint: i64 = 0x1F0;
            }
            pub mod C_OP_LockToBone {
                pub const m_bRigid: i64 = 0x338;
                pub const m_bUseBones: i64 = 0x339;
                pub const m_flRotLerp: i64 = 0xA28;
                pub const m_modelInput: i64 = 0x1E0;
                pub const m_vecRotation: i64 = 0x350;
                pub const m_nFieldOutput: i64 = 0x33C;
                pub const m_HitboxSetName: i64 = 0x2B8;
                pub const m_flPrevPosScale: i64 = 0x2B4;
                pub const m_transformInput: i64 = 0x240;
                pub const m_flJumpThreshold: i64 = 0x2B0;
                pub const m_nFieldOutputPrev: i64 = 0x340;
                pub const m_nRotationSetType: i64 = 0x344;
                pub const m_flLifeTimeFadeEnd: i64 = 0x2AC;
                pub const m_bRigidRotationLock: i64 = 0x348;
                pub const m_flLifeTimeFadeStart: i64 = 0x2A8;
            }
            pub mod C_OP_NormalLock {
                pub const m_nControlPointNumber: i64 = 0x1E0;
            }
            pub mod C_OP_RemapSpeed {
                pub const m_flInputMax: i64 = 0x1E8;
                pub const m_flInputMin: i64 = 0x1E4;
                pub const m_nSetMethod: i64 = 0x1F4;
                pub const m_flOutputMax: i64 = 0x1F0;
                pub const m_flOutputMin: i64 = 0x1EC;
                pub const m_bIgnoreDelta: i64 = 0x1F8;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_RenderText {
                pub const m_DefaultText: i64 = 0x238;
                pub const m_OutlineColor: i64 = 0x230;
            }
            pub mod C_OP_SpinUpdate {

            }
            pub mod CPulseExecCursor {

            }
            pub mod C_INIT_InitFloat {
                pub const m_InputValue: i64 = 0x1E8;
                pub const m_nSetMethod: i64 = 0x364;
                pub const m_nOutputField: i64 = 0x360;
                pub const m_InputStrength: i64 = 0x368;
            }
            pub mod C_INIT_ModelCull {
                pub const m_bBoundBox: i64 = 0x1EC;
                pub const m_bUseBones: i64 = 0x1EE;
                pub const m_bCullOutside: i64 = 0x1ED;
                pub const m_HitboxSetName: i64 = 0x1EF;
                pub const m_nControlPointNumber: i64 = 0x1E8;
            }
            pub mod C_INIT_PlaneCull {
                pub const m_flDistance: i64 = 0x1F0;
                pub const m_bCullInside: i64 = 0x368;
                pub const m_nControlPoint: i64 = 0x1E8;
            }
            pub mod C_INIT_PointList {
                pub const m_pointList: i64 = 0x1F0;
                pub const m_bClosedLoop: i64 = 0x209;
                pub const m_nFieldOutput: i64 = 0x1E8;
                pub const m_bPlaceAlongPath: i64 = 0x208;
                pub const m_nNumPointsAlongPath: i64 = 0x20C;
            }
            pub mod C_INIT_RandomYaw {

            }
            pub mod C_INIT_RtEnvCull {
                pub const m_nRTEnvCP: i64 = 0x284;
                pub const m_RtEnvName: i64 = 0x203;
                pub const m_nComponent: i64 = 0x288;
                pub const m_vecTestDir: i64 = 0x1E8;
                pub const m_bCullOnMiss: i64 = 0x201;
                pub const m_bLifeAdjust: i64 = 0x202;
                pub const m_bUseVelocity: i64 = 0x200;
                pub const m_vecTestNormal: i64 = 0x1F4;
            }
            pub mod C_OP_ChladniWave {
                pub const m_b3D: i64 = 0x1580;
                pub const m_flInputMax: i64 = 0x360;
                pub const m_flInputMin: i64 = 0x1E8;
                pub const m_nSetMethod: i64 = 0x1578;
                pub const m_flOutputMax: i64 = 0x650;
                pub const m_flOutputMin: i64 = 0x4D8;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_vecHarmonics: i64 = 0xEA0;
                pub const m_vecWaveLength: i64 = 0x7C8;
                pub const m_nLocalSpaceControlPoint: i64 = 0x157C;
            }
            pub mod C_OP_ClampScalar {
                pub const m_flOutputMax: i64 = 0x360;
                pub const m_flOutputMin: i64 = 0x1E8;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_ClampVector {
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_vecOutputMax: i64 = 0x8C0;
                pub const m_vecOutputMin: i64 = 0x1E8;
            }
            pub mod C_OP_CycleScalar {
                pub const m_nCPScale: i64 = 0x1F4;
                pub const m_flEndValue: i64 = 0x1E8;
                pub const m_nDestField: i64 = 0x1E0;
                pub const m_nSetMethod: i64 = 0x200;
                pub const m_flCycleTime: i64 = 0x1EC;
                pub const m_nCPFieldMax: i64 = 0x1FC;
                pub const m_nCPFieldMin: i64 = 0x1F8;
                pub const m_flStartValue: i64 = 0x1E4;
                pub const m_bDoNotRepeatCycle: i64 = 0x1F0;
                pub const m_bSynchronizeParticles: i64 = 0x1F1;
            }
            pub mod C_OP_EndCapDecay {

            }
            pub mod C_OP_FadeAndKill {
                pub const m_flEndAlpha: i64 = 0x1F4;
                pub const m_flStartAlpha: i64 = 0x1F0;
                pub const m_flEndFadeInTime: i64 = 0x1E4;
                pub const m_flEndFadeOutTime: i64 = 0x1EC;
                pub const m_flStartFadeInTime: i64 = 0x1E0;
                pub const m_flStartFadeOutTime: i64 = 0x1E8;
                pub const m_bForcePreserveParticleOrder: i64 = 0x1F8;
            }
            pub mod C_OP_GlobalLight {
                pub const m_flScale: i64 = 0x1E0;
                pub const m_bClampLowerRange: i64 = 0x1E4;
                pub const m_bClampUpperRange: i64 = 0x1E5;
            }
            pub mod C_OP_MaxVelocity {
                pub const m_flMaxVelocity: i64 = 0x1E0;
                pub const m_flMinVelocity: i64 = 0x358;
            }
            pub mod C_OP_RadiusDecay {
                pub const m_flMinRadius: i64 = 0x1E0;
            }
            pub mod C_OP_RandomForce {
                pub const m_MaxForce: i64 = 0x1FC;
                pub const m_MinForce: i64 = 0x1F0;
            }
            pub mod C_OP_RemapCPtoCP {
                pub const m_flInputMax: i64 = 0x1FC;
                pub const m_flInputMin: i64 = 0x1F8;
                pub const m_bDerivative: i64 = 0x208;
                pub const m_flOutputMax: i64 = 0x204;
                pub const m_flOutputMin: i64 = 0x200;
                pub const m_nInputField: i64 = 0x1F0;
                pub const m_flInterpRate: i64 = 0x20C;
                pub const m_nOutputField: i64 = 0x1F4;
                pub const m_nInputControlPoint: i64 = 0x1E8;
                pub const m_nOutputControlPoint: i64 = 0x1EC;
            }
            pub mod C_OP_RemapScalar {
                pub const m_bOldCode: i64 = 0x1F8;
                pub const m_flInputMax: i64 = 0x1EC;
                pub const m_flInputMin: i64 = 0x1E8;
                pub const m_flOutputMax: i64 = 0x1F4;
                pub const m_flOutputMin: i64 = 0x1F0;
                pub const m_nFieldInput: i64 = 0x1E0;
                pub const m_nFieldOutput: i64 = 0x1E4;
            }
            pub mod C_OP_RenderBlobs {
                pub const m_nScaleCP: i64 = 0x6A0;
                pub const m_cubeWidth: i64 = 0x230;
                pub const m_hMaterial: i64 = 0x6D8;
                pub const m_MaterialVars: i64 = 0x6A8;
                pub const m_cutoffRadius: i64 = 0x3A8;
                pub const m_renderRadius: i64 = 0x520;
                pub const m_nIndexCountKb: i64 = 0x69C;
                pub const m_nVertexCountKb: i64 = 0x698;
            }
            pub mod C_OP_RenderRopes {
                pub const m_bClampV: i64 = 0x34EC;
                pub const m_flMaxSize: i64 = 0x2EE0;
                pub const m_flMinSize: i64 = 0x2EDC;
                pub const m_nScaleCP1: i64 = 0x34F0;
                pub const m_nScaleCP2: i64 = 0x34F4;
                pub const m_bClosedLoop: i64 = 0x3511;
                pub const m_flTessScale: i64 = 0x307C;
                pub const m_nSplitField: i64 = 0x3514;
                pub const m_flEndFadeDot: i64 = 0x2EF0;
                pub const m_bDrawAsOpaque: i64 = 0x3524;
                pub const m_bReverseOrder: i64 = 0x3510;
                pub const m_flEndFadeSize: i64 = 0x2EE8;
                pub const m_flRadiusTaper: i64 = 0x3070;
                pub const m_flStartFadeDot: i64 = 0x2EEC;
                pub const m_flStartFadeSize: i64 = 0x2EE4;
                pub const m_nMaxTesselation: i64 = 0x3078;
                pub const m_nMinTesselation: i64 = 0x3074;
                pub const m_bGenerateNormals: i64 = 0x3525;
                pub const m_bSortBySegmentID: i64 = 0x3518;
                pub const m_flTextureVOffset: i64 = 0x3370;
                pub const m_nOrientationType: i64 = 0x351C;
                pub const m_flSubPixelAAScale: i64 = 0x2EF8;
                pub const m_nTextureVParamsCP: i64 = 0x34E8;
                pub const m_flTextureVWorldSize: i64 = 0x3080;
                pub const m_flTextureVScrollRate: i64 = 0x31F8;
                pub const m_bEnableFadingAndClamping: i64 = 0x2ED8;
                pub const m_nVectorFieldForOrientation: i64 = 0x3520;
                pub const m_bUseScalarForTextureCoordinate: i64 = 0x3505;
                pub const m_nScalarFieldForTextureCoordinate: i64 = 0x3508;
                pub const m_flScalarAttributeTextureCoordScale: i64 = 0x350C;
                pub const m_flScaleVSizeByControlPointDistance: i64 = 0x34F8;
                pub const m_flScaleVOffsetByControlPointDistance: i64 = 0x3500;
                pub const m_flScaleVScrollByControlPointDistance: i64 = 0x34FC;
            }
            pub mod C_OP_RenderSound {
                pub const m_nChannel: i64 = 0x250;
                pub const m_nPitchField: i64 = 0x248;
                pub const m_flPitchScale: i64 = 0x238;
                pub const m_nCPReference: i64 = 0x254;
                pub const m_nSndLvlField: i64 = 0x240;
                pub const m_nVolumeField: i64 = 0x24C;
                pub const m_pszSoundName: i64 = 0x258;
                pub const m_flSndLvlScale: i64 = 0x234;
                pub const m_flVolumeScale: i64 = 0x23C;
                pub const m_nDurationField: i64 = 0x244;
                pub const m_flDurationScale: i64 = 0x230;
                pub const m_bSuppressStopSoundEvent: i64 = 0x358;
            }
            pub mod C_OP_SetVariable {
                pub const m_vecInput: i64 = 0x2B8;
                pub const m_floatInput: i64 = 0x990;
                pub const m_positionOffset: i64 = 0x2A0;
                pub const m_rotationOffset: i64 = 0x2AC;
                pub const m_transformInput: i64 = 0x238;
                pub const m_variableReference: i64 = 0x1E8;
            }
            pub mod C_OP_VectorNoise {
                pub const m_bOffset: i64 = 0x201;
                pub const m_bAdditive: i64 = 0x200;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_vecOutputMax: i64 = 0x1F0;
                pub const m_vecOutputMin: i64 = 0x1E4;
                pub const m_fl4NoiseScale: i64 = 0x1FC;
                pub const m_flNoiseAnimationTimeScale: i64 = 0x204;
            }
            pub mod ModelReference_t {
                pub const m_model: i64 = 0x0;
                pub const m_flRelativeProbabilityOfSpawn: i64 = 0x8;
            }
            pub mod CParticleFunction {
                pub const m_Notes: i64 = 0x1C0;
                pub const m_nToolsState: i64 = 0x184;
                pub const m_flOpStrength: i64 = 0x8;
                pub const m_nOpEndCapState: i64 = 0x180;
                pub const m_bDisableOperator: i64 = 0x1BA;
                pub const m_flOpTimeScaleMax: i64 = 0x1B4;
                pub const m_flOpTimeScaleMin: i64 = 0x1B0;
                pub const m_nOpTimeScaleSeed: i64 = 0x1AC;
                pub const m_flOpEndFadeInTime: i64 = 0x18C;
                pub const m_flOpTimeOffsetMax: i64 = 0x1A4;
                pub const m_flOpTimeOffsetMin: i64 = 0x1A0;
                pub const m_nOpTimeOffsetSeed: i64 = 0x1A8;
                pub const m_flOpEndFadeOutTime: i64 = 0x194;
                pub const m_flOpStartFadeInTime: i64 = 0x188;
                pub const m_bNormalizeToStopTime: i64 = 0x19C;
                pub const m_flOpStartFadeOutTime: i64 = 0x190;
                pub const m_flOpFadeOscillatePeriod: i64 = 0x198;
            }
            pub mod C_INIT_SkyVisCull {
                pub const m_nTraceSet: i64 = 0x8C0;
                pub const m_bCullOnSky: i64 = 0x8C4;
                pub const m_vecTestDir: i64 = 0x1E8;
            }
            pub mod C_OP_DensityForce {
                pub const m_flForceScale: i64 = 0x1F4;
                pub const m_flRadiusScale: i64 = 0x1F0;
                pub const m_flTargetDensity: i64 = 0x1F8;
            }
            pub mod C_OP_DistanceCull {
                pub const m_flDistance: i64 = 0x1F0;
                pub const m_nAttribute: i64 = 0x36C;
                pub const m_bCullInside: i64 = 0x368;
                pub const m_nControlPoint: i64 = 0x1E0;
                pub const m_vecPointOffset: i64 = 0x1E4;
            }
            pub mod C_OP_FadeInSimple {
                pub const m_flFadeInTime: i64 = 0x1E0;
                pub const m_nFieldOutput: i64 = 0x1E4;
            }
            pub mod C_OP_HSVShiftToCP {
                pub const m_nColorCP: i64 = 0x1E8;
                pub const m_nOutputCP: i64 = 0x1F0;
                pub const m_DefaultHSVColor: i64 = 0x1F4;
                pub const m_nColorGemEnableCP: i64 = 0x1EC;
            }
            pub mod C_OP_MoveToHitbox {
                pub const m_bUseBones: i64 = 0x338;
                pub const m_nLerpType: i64 = 0x33C;
                pub const m_modelInput: i64 = 0x1E0;
                pub const m_HitboxSetName: i64 = 0x2B8;
                pub const m_flPrevPosScale: i64 = 0x2B4;
                pub const m_transformInput: i64 = 0x240;
                pub const m_flInterpolation: i64 = 0x340;
                pub const m_flLifeTimeLerpEnd: i64 = 0x2B0;
                pub const m_flLifeTimeLerpStart: i64 = 0x2AC;
            }
            pub mod C_OP_NoiseEmitter {
                pub const m_bAbsVal: i64 = 0x200;
                pub const m_flOffset: i64 = 0x204;
                pub const m_bAbsValInv: i64 = 0x201;
                pub const m_flOutputMax: i64 = 0x20C;
                pub const m_flOutputMin: i64 = 0x208;
                pub const m_flStartTime: i64 = 0x1EC;
                pub const m_flNoiseScale: i64 = 0x210;
                pub const m_vecOffsetLoc: i64 = 0x218;
                pub const m_flEmissionScale: i64 = 0x1F0;
                pub const m_flWorldTimeScale: i64 = 0x224;
                pub const m_nWorldNoisePoint: i64 = 0x1FC;
                pub const m_flWorldNoiseScale: i64 = 0x214;
                pub const m_flEmissionDuration: i64 = 0x1E8;
                pub const m_nScaleControlPoint: i64 = 0x1F4;
                pub const m_nScaleControlPointField: i64 = 0x1F8;
            }
            pub mod C_OP_PositionLock {
                pub const m_flRange: i64 = 0x260;
                pub const m_bLockRot: i64 = 0x3E8;
                pub const m_vecScale: i64 = 0x3F0;
                pub const m_flRangeBias: i64 = 0x268;
                pub const m_nFieldOutput: i64 = 0xAC8;
                pub const m_flEndTime_exp: i64 = 0x25C;
                pub const m_flEndTime_max: i64 = 0x258;
                pub const m_flEndTime_min: i64 = 0x254;
                pub const m_TransformInput: i64 = 0x1E0;
                pub const m_flPrevPosScale: i64 = 0x3E4;
                pub const m_flJumpThreshold: i64 = 0x3E0;
                pub const m_flStartTime_exp: i64 = 0x250;
                pub const m_flStartTime_max: i64 = 0x24C;
                pub const m_flStartTime_min: i64 = 0x248;
                pub const m_nFieldOutputPrev: i64 = 0xACC;
            }
            pub mod C_OP_RenderCables {
                pub const m_hMaterial: i64 = 0xC00;
                pub const m_nRoundness: i64 = 0x14F8;
                pub const m_flTessScale: i64 = 0x14EC;
                pub const m_flAlphaScale: i64 = 0x3A8;
                pub const m_flRadiusScale: i64 = 0x230;
                pub const m_vecColorScale: i64 = 0x520;
                pub const m_bDrawCableCaps: i64 = 0x14E0;
                pub const m_flCapRoundness: i64 = 0x14E4;
                pub const m_MaterialVecVars: i64 = 0x1588;
                pub const m_nColorBlendType: i64 = 0xBF8;
                pub const m_nMaxTesselation: i64 = 0x14F4;
                pub const m_nMinTesselation: i64 = 0x14F0;
                pub const m_LightingTransform: i64 = 0x1500;
                pub const m_MaterialFloatVars: i64 = 0x1568;
                pub const m_flCapOffsetAmount: i64 = 0x14E8;
                pub const m_flColorMapOffsetU: i64 = 0x1078;
                pub const m_flColorMapOffsetV: i64 = 0xF00;
                pub const m_flNormalMapOffsetU: i64 = 0x1368;
                pub const m_flNormalMapOffsetV: i64 = 0x11F0;
                pub const m_nForceRoundnessFixed: i64 = 0x14FC;
                pub const m_nTextureRepetitionMode: i64 = 0xC08;
                pub const m_flTextureRepeatsPerSegment: i64 = 0xC10;
                pub const m_bOnlyRenderInEffectsBloomPass: i64 = 0x14FD;
                pub const m_flTextureRepeatsCircumference: i64 = 0xD88;
            }
            pub mod C_OP_RenderLights {
                pub const m_flMaxSize: i64 = 0x248;
                pub const m_flMinSize: i64 = 0x244;
                pub const m_bAnimateInFPS: i64 = 0x240;
                pub const m_flEndFadeSize: i64 = 0x250;
                pub const m_nAnimationType: i64 = 0x23C;
                pub const m_flAnimationRate: i64 = 0x238;
                pub const m_flStartFadeSize: i64 = 0x24C;
            }
            pub mod C_OP_RenderModels {
                pub const m_nLOD: i64 = 0x1FC0;
                pub const m_nSkin: i64 = 0x1AE0;
                pub const m_bOrientZ: i64 = 0x259;
                pub const m_ModelList: i64 = 0x238;
                pub const m_bAnimated: i64 = 0x16F8;
                pub const m_modelInput: i64 = 0x1F60;
                pub const m_bLocalScale: i64 = 0x16F0;
                pub const m_flRollScale: i64 = 0x24C8;
                pub const m_ActivityName: i64 = 0x1888;
                pub const m_EconSlotName: i64 = 0x1FC4;
                pub const m_MaterialVars: i64 = 0x1C58;
                pub const m_SequenceName: i64 = 0x1988;
                pub const m_flAlphaScale: i64 = 0x2350;
                pub const m_nAlpha2Field: i64 = 0x2640;
                pub const m_bCenterOffset: i64 = 0x25A;
                pub const m_bIgnoreNormal: i64 = 0x258;
                pub const m_bIgnoreRadius: i64 = 0x1010;
                pub const m_bSuppressTint: i64 = 0x20C5;
                pub const m_flRadiusScale: i64 = 0x21D8;
                pub const m_nModelScaleCP: i64 = 0x1014;
                pub const m_strLightStyle: i64 = 0x2D28;
                pub const m_vecColorScale: i64 = 0x2648;
                pub const m_bAcceptsDecals: i64 = 0x20CE;
                pub const m_bOriginalModel: i64 = 0x20C4;
                pub const m_flRenderFilter: i64 = 0x1C70;
                pub const m_nSizeCullBloat: i64 = 0x16F4;
                pub const m_nSubModelField: i64 = 0x254;
                pub const m_vecLocalOffset: i64 = 0x260;
                pub const m_ClothEffectName: i64 = 0x1A8A;
                pub const m_bDisableShadows: i64 = 0x20CC;
                pub const m_flAnimationRate: i64 = 0x1700;
                pub const m_nAnimationField: i64 = 0x1880;
                pub const m_nBodyGroupField: i64 = 0x250;
                pub const m_nColorBlendType: i64 = 0x2D20;
                pub const m_bManualAnimFrame: i64 = 0x187B;
                pub const m_bResetAnimOnStop: i64 = 0x187A;
                pub const m_flLightStyleTime: i64 = 0x2D30;
                pub const m_vecLocalRotation: i64 = 0x938;
                pub const m_hOverrideMaterial: i64 = 0x1AD0;
                pub const m_nManualFrameField: i64 = 0x1884;
                pub const m_szRenderAttribute: i64 = 0x20D2;
                pub const m_vecComponentScale: i64 = 0x1018;
                pub const m_nSubModelFieldType: i64 = 0x20C8;
                pub const m_bScaleAnimationRate: i64 = 0x1878;
                pub const m_bDisableDepthPrepass: i64 = 0x20CD;
                pub const m_nAnimationScaleField: i64 = 0x187C;
                pub const m_bEnableClothSimulation: i64 = 0x1A88;
                pub const m_bForceLoopingAnimation: i64 = 0x1879;
                pub const m_flManualModelSelection: i64 = 0x1DE8;
                pub const m_bDoNotDrawInParticlePass: i64 = 0x20D0;
                pub const m_bAllowApproximateTransforms: i64 = 0x20D1;
                pub const m_bDisableClothGroundCollision: i64 = 0x1A89;
                pub const m_bUseMixedResolutionRendering: i64 = 0x232;
                pub const m_bOnlyRenderInEffectsBloomPass: i64 = 0x230;
                pub const m_bOnlyRenderInEffectsWaterPass: i64 = 0x231;
                pub const m_bOverrideTranslucentMaterials: i64 = 0x1AD8;
                pub const m_bOnlyRenderInEffecsGameOverlay: i64 = 0x233;
                pub const m_bForceDrawInterlevedWithSiblings: i64 = 0x20CF;
            }
            pub mod C_OP_RenderPoints {
                pub const m_hMaterial: i64 = 0x230;
            }
            pub mod C_OP_RenderTrails {
                pub const m_bIgnoreDT: i64 = 0x3370;
                pub const m_flMaxLength: i64 = 0x3368;
                pub const m_flMinLength: i64 = 0x336C;
                pub const m_flEndFadeDot: i64 = 0x3360;
                pub const m_flLengthScale: i64 = 0x3378;
                pub const m_flRadiusTaper: i64 = 0x3D48;
                pub const m_flForwardShift: i64 = 0x4718;
                pub const m_flStartFadeDot: i64 = 0x335C;
                pub const m_nPrevPntSource: i64 = 0x3364;
                pub const m_nVertCropField: i64 = 0x4714;
                pub const m_nHorizCropField: i64 = 0x4710;
                pub const m_flHeadAlphaScale: i64 = 0x3BD0;
                pub const m_flTailAlphaScale: i64 = 0x4598;
                pub const m_flRadiusHeadTaper: i64 = 0x3380;
                pub const m_vecHeadColorScale: i64 = 0x34F8;
                pub const m_vecTailColorScale: i64 = 0x3EC0;
                pub const m_flLengthFadeInTime: i64 = 0x337C;
                pub const m_bFlipUVBasedOnPitchYaw: i64 = 0x471C;
                pub const m_bEnableFadingAndClamping: i64 = 0x3358;
                pub const m_flConstrainRadiusToLengthRatio: i64 = 0x3374;
            }
            pub mod C_OP_RotateVector {
                pub const m_flScale: i64 = 0x208;
                pub const m_bNormalize: i64 = 0x204;
                pub const m_flRotRateMax: i64 = 0x200;
                pub const m_flRotRateMin: i64 = 0x1FC;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_vecRotAxisMax: i64 = 0x1F0;
                pub const m_vecRotAxisMin: i64 = 0x1E4;
            }
            pub mod C_OP_SetUserEvent {
                pub const m_flInput: i64 = 0x1E0;
                pub const m_flRisingEdge: i64 = 0x358;
                pub const m_flFallingEdge: i64 = 0x4D8;
                pub const m_nRisingEventType: i64 = 0x4D0;
                pub const m_nFallingEventType: i64 = 0x650;
            }
            pub mod C_OP_TeleportBeam {
                pub const m_flAlpha: i64 = 0x210;
                pub const m_nCPMisc: i64 = 0x1E8;
                pub const m_nCPColor: i64 = 0x1EC;
                pub const m_vGravity: i64 = 0x1F8;
                pub const m_flArcSpeed: i64 = 0x20C;
                pub const m_nCPPosition: i64 = 0x1E0;
                pub const m_nCPVelocity: i64 = 0x1E4;
                pub const m_flSegmentBreak: i64 = 0x208;
                pub const m_nCPExtraArcData: i64 = 0x1F4;
                pub const m_nCPInvalidColor: i64 = 0x1F0;
                pub const m_flArcMaxDuration: i64 = 0x204;
            }
            pub mod PointDefinition_t {
                pub const m_vOffset: i64 = 0x8;
                pub const m_bLocalCoords: i64 = 0x4;
                pub const m_nControlPoint: i64 = 0x0;
            }
            pub mod TextureControls_t {
                pub const m_bClampUVs: i64 = 0xA49;
                pub const m_flZoomScale: i64 = 0x758;
                pub const m_flDistortion: i64 = 0x8D0;
                pub const m_nPerParticleZoom: i64 = 0xA60;
                pub const m_bRandomizeOffsets: i64 = 0xA48;
                pub const m_nPerParticleBlend: i64 = 0xA4C;
                pub const m_nPerParticleScale: i64 = 0xA50;
                pub const m_nPerParticleOffsetU: i64 = 0xA54;
                pub const m_nPerParticleOffsetV: i64 = 0xA58;
                pub const m_flFinalTextureScaleU: i64 = 0x0;
                pub const m_flFinalTextureScaleV: i64 = 0x178;
                pub const m_nPerParticleRotation: i64 = 0xA5C;
                pub const m_flFinalTextureOffsetU: i64 = 0x2F0;
                pub const m_flFinalTextureOffsetV: i64 = 0x468;
                pub const m_nPerParticleDistortion: i64 = 0xA64;
                pub const m_flFinalTextureUVRotation: i64 = 0x5E0;
            }
            pub mod CBaseTrailRenderer {
                pub const m_bClampV: i64 = 0x3350;
                pub const m_flMaxSize: i64 = 0x2EE4;
                pub const m_flMinSize: i64 = 0x2EE0;
                pub const m_flEndFadeSize: i64 = 0x3060;
                pub const m_flStartFadeSize: i64 = 0x2EE8;
                pub const m_nOrientationType: i64 = 0x2ED8;
                pub const m_flSubPixelAAScale: i64 = 0x31D8;
                pub const m_nOrientationControlPoint: i64 = 0x2EDC;
            }
            pub mod CPulseCell_Unknown {
                pub const m_UnknownKeys: i64 = 0x48;
            }
            pub mod CPulse_ResumePoint {

            }
            pub mod C_INIT_GlobalScale {
                pub const m_flScale: i64 = 0x1E8;
                pub const m_bScaleRadius: i64 = 0x1F4;
                pub const m_bScalePosition: i64 = 0x1F5;
                pub const m_bScaleVelocity: i64 = 0x1F6;
                pub const m_nControlPointNumber: i64 = 0x1F0;
                pub const m_nScaleControlPointNumber: i64 = 0x1EC;
            }
            pub mod C_INIT_RandomAlpha {
                pub const m_nAlphaMax: i64 = 0x1F0;
                pub const m_nAlphaMin: i64 = 0x1EC;
                pub const m_nFieldOutput: i64 = 0x1E8;
                pub const m_flAlphaRandExponent: i64 = 0x1FC;
            }
            pub mod C_INIT_RandomColor {
                pub const m_TintMax: i64 = 0x210;
                pub const m_TintMin: i64 = 0x20C;
                pub const m_nTintCP: i64 = 0x21C;
                pub const m_ColorMax: i64 = 0x208;
                pub const m_ColorMin: i64 = 0x204;
                pub const m_flTintPerc: i64 = 0x214;
                pub const m_nFieldOutput: i64 = 0x220;
                pub const m_nTintBlendMode: i64 = 0x224;
                pub const m_flUpdateThreshold: i64 = 0x218;
                pub const m_flLightAmplification: i64 = 0x228;
            }
            pub mod C_OP_BasicMovement {
                pub const m_fDrag: i64 = 0x8B8;
                pub const m_Gravity: i64 = 0x1E0;
                pub const m_bUseNewCode: i64 = 0xEA4;
                pub const m_massControls: i64 = 0xA30;
                pub const m_nMaxConstraintPasses: i64 = 0xEA0;
            }
            pub mod C_OP_BoxConstraint {
                pub const m_nCP: i64 = 0xF90;
                pub const m_vecMax: i64 = 0x8B8;
                pub const m_vecMin: i64 = 0x1E0;
                pub const m_bLocalSpace: i64 = 0xF94;
                pub const m_bAccountForRadius: i64 = 0xF95;
            }
            pub mod C_OP_ClientPhysics {
                pub const m_bDeleteSim: i64 = 0x53A;
                pub const m_bStartAsleep: i64 = 0x238;
                pub const m_nForcedSimId: i64 = 0x540;
                pub const m_nControlPoint: i64 = 0x53C;
                pub const m_bKillParticles: i64 = 0x539;
                pub const m_strPhysicsType: i64 = 0x230;
                pub const m_nColorBlendType: i64 = 0x544;
                pub const m_nMaxParticleCount: i64 = 0x534;
                pub const m_flPlayerWakeRadius: i64 = 0x240;
                pub const m_flVehicleWakeRadius: i64 = 0x3B8;
                pub const m_nForcedStatusEffects: i64 = 0x548;
                pub const m_nNoCollisionAttribute: i64 = 0x54C;
                pub const m_nZeroGravityAttribute: i64 = 0x550;
                pub const m_bRespectExclusionVolumes: i64 = 0x538;
                pub const m_bUseHighQualitySimulation: i64 = 0x530;
            }
            pub mod C_OP_FadeOutSimple {
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_flFadeOutTime: i64 = 0x1E0;
            }
            pub mod C_OP_QuantizeFloat {
                pub const m_InputValue: i64 = 0x1E0;
                pub const m_nOutputField: i64 = 0x358;
            }
            pub mod C_OP_RenderSprites {
                pub const m_bOutline: i64 = 0x37CC;
                pub const m_flMaxSize: i64 = 0x31D8;
                pub const m_flMinSize: i64 = 0x3060;
                pub const m_bSoftEdges: i64 = 0x37C1;
                pub const m_OutlineColor: i64 = 0x37D0;
                pub const m_flEndFadeDot: i64 = 0x37BC;
                pub const m_flEndFadeSize: i64 = 0x3640;
                pub const m_flOutlineEnd0: i64 = 0x37E0;
                pub const m_flOutlineEnd1: i64 = 0x37E4;
                pub const m_nLightingMode: i64 = 0x37E8;
                pub const m_nOutlineAlpha: i64 = 0x37D4;
                pub const m_bDistanceAlpha: i64 = 0x37C0;
                pub const m_flStartFadeDot: i64 = 0x37B8;
                pub const m_flOutlineStart0: i64 = 0x37D8;
                pub const m_flOutlineStart1: i64 = 0x37DC;
                pub const m_flShadowDensity: i64 = 0x41BC;
                pub const m_flStartFadeSize: i64 = 0x34C8;
                pub const m_bParticleShadows: i64 = 0x41B8;
                pub const m_nOrientationType: i64 = 0x3054;
                pub const m_flEdgeSoftnessEnd: i64 = 0x37C8;
                pub const m_flSubPixelAAScale: i64 = 0x3350;
                pub const m_nSequenceOverride: i64 = 0x2ED8;
                pub const m_flEdgeSoftnessStart: i64 = 0x37C4;
                pub const m_vecLightingOverride: i64 = 0x37F0;
                pub const m_flLightingTessellation: i64 = 0x3EC8;
                pub const m_bUseYawWithNormalAligned: i64 = 0x305C;
                pub const m_flLightingDirectionality: i64 = 0x4040;
                pub const m_nOrientationControlPoint: i64 = 0x3058;
                pub const m_bSequenceNumbersAreRawSequenceIndices: i64 = 0x3050;
            }
            pub mod C_OP_SetCPtoVector {
                pub const m_nCPInput: i64 = 0x1E0;
                pub const m_nFieldOutput: i64 = 0x1E4;
            }
            pub mod C_OP_VelocityDecay {
                pub const m_flMinVelocity: i64 = 0x1E0;
            }
            pub mod MaterialVariable_t {
                pub const m_flScale: i64 = 0xC;
                pub const m_strVariable: i64 = 0x0;
                pub const m_nVariableField: i64 = 0x8;
            }
            pub mod CPulseCell_BaseFlow {

            }
            pub mod CPulseCell_BaseLerp {
                pub const m_WakeResume: i64 = 0xD8;
            }
            pub mod CPulseCell_Timeline {
                pub const m_OnFinished: i64 = 0xF8;
                pub const m_TimelineEvents: i64 = 0xD8;
                pub const m_bWaitForChildOutflows: i64 = 0xF0;
            }
            pub mod C_INIT_CreateOnGrid {
                pub const m_bCenter: i64 = 0xABD;
                pub const m_bHollow: i64 = 0xABE;
                pub const m_nXCount: i64 = 0x1E8;
                pub const m_nYCount: i64 = 0x360;
                pub const m_nZCount: i64 = 0x4D8;
                pub const m_nXSpacing: i64 = 0x650;
                pub const m_nYSpacing: i64 = 0x7C8;
                pub const m_nZSpacing: i64 = 0x940;
                pub const m_bLocalSpace: i64 = 0xABC;
                pub const m_nControlPointNumber: i64 = 0xAB8;
            }
            pub mod C_INIT_DistanceCull {
                pub const m_flDistance: i64 = 0x1F0;
                pub const m_bCullInside: i64 = 0x368;
                pub const m_nControlPoint: i64 = 0x1E8;
            }
            pub mod C_INIT_NormalOffset {
                pub const m_OffsetMax: i64 = 0x1F4;
                pub const m_OffsetMin: i64 = 0x1E8;
                pub const m_bNormalize: i64 = 0x205;
                pub const m_bLocalCoords: i64 = 0x204;
                pub const m_nControlPointNumber: i64 = 0x200;
            }
            pub mod C_INIT_PositionWarp {
                pub const m_bUseCount: i64 = 0xFB1;
                pub const m_flWarpTime: i64 = 0xFA4;
                pub const m_vecWarpMax: i64 = 0x8C0;
                pub const m_vecWarpMin: i64 = 0x1E8;
                pub const m_bInvertWarp: i64 = 0xFB0;
                pub const m_flPrevPosScale: i64 = 0xFAC;
                pub const m_flWarpStartTime: i64 = 0xFA8;
                pub const m_nRadiusComponent: i64 = 0xFA0;
                pub const m_nControlPointNumber: i64 = 0xF9C;
                pub const m_nScaleControlPointNumber: i64 = 0xF98;
            }
            pub mod C_INIT_RandomRadius {
                pub const m_flRadiusMax: i64 = 0x1EC;
                pub const m_flRadiusMin: i64 = 0x1E8;
                pub const m_flRadiusRandExponent: i64 = 0x1F0;
            }
            pub mod C_INIT_RandomScalar {
                pub const m_flMax: i64 = 0x1EC;
                pub const m_flMin: i64 = 0x1E8;
                pub const m_flExponent: i64 = 0x1F0;
                pub const m_nFieldOutput: i64 = 0x1F4;
            }
            pub mod C_INIT_RandomVector {
                pub const m_vecMax: i64 = 0x1F4;
                pub const m_vecMin: i64 = 0x1E8;
                pub const m_nFieldOutput: i64 = 0x200;
                pub const m_randomnessParameters: i64 = 0x204;
            }
            pub mod C_INIT_StatusEffect {
                pub const m_nDetail2Combo: i64 = 0x1E8;
                pub const m_rimLightColor: i64 = 0x21C;
                pub const m_specularColor: i64 = 0x208;
                pub const m_flAmbientScale: i64 = 0x204;
                pub const m_flDetail2Scale: i64 = 0x1F0;
                pub const m_flRimLightScale: i64 = 0x220;
                pub const m_flSpecularScale: i64 = 0x20C;
                pub const m_flDetail2Rotation: i64 = 0x1EC;
                pub const m_flEnvMapIntensity: i64 = 0x200;
                pub const m_flSpecularExponent: i64 = 0x210;
                pub const m_flColorWarpIntensity: i64 = 0x1F8;
                pub const m_flDetail2BlendFactor: i64 = 0x1F4;
                pub const m_flSpecularBlendToFull: i64 = 0x218;
                pub const m_flMetalnessBlendToFull: i64 = 0x228;
                pub const m_flSelfIllumBlendToFull: i64 = 0x22C;
                pub const m_flDiffuseWarpBlendToFull: i64 = 0x1FC;
                pub const m_flSpecularExponentBlendToFull: i64 = 0x214;
                pub const m_flReflectionsTintByBaseBlendToNone: i64 = 0x224;
            }
            pub mod C_OP_ColorAdjustHSL {
                pub const m_flHueAdjust: i64 = 0x1E0;
                pub const m_flLightnessAdjust: i64 = 0x4D0;
                pub const m_flSaturationAdjust: i64 = 0x358;
            }
            pub mod C_OP_CurlNoiseForce {
                pub const m_vecOffset: i64 = 0xFA8;
                pub const m_nNoiseType: i64 = 0x1F0;
                pub const m_flWorleySeed: i64 = 0x1D58;
                pub const m_vecNoiseFreq: i64 = 0x1F8;
                pub const m_vecNoiseScale: i64 = 0x8D0;
                pub const m_vecOffsetRate: i64 = 0x1680;
                pub const m_flWorleyJitter: i64 = 0x1ED0;
            }
            pub mod C_OP_DecayOffscreen {
                pub const m_flOffscreenTime: i64 = 0x1E0;
            }
            pub mod C_OP_ParentVortices {
                pub const m_flForceScale: i64 = 0x1F0;
                pub const m_vecTwistAxis: i64 = 0x1F4;
                pub const m_bFlipBasedOnYaw: i64 = 0x200;
            }
            pub mod C_OP_RemapSpeedtoCP {
                pub const m_nField: i64 = 0x1F0;
                pub const m_bUseDeltaV: i64 = 0x204;
                pub const m_flInputMax: i64 = 0x1F8;
                pub const m_flInputMin: i64 = 0x1F4;
                pub const m_flOutputMax: i64 = 0x200;
                pub const m_flOutputMin: i64 = 0x1FC;
                pub const m_nInControlPointNumber: i64 = 0x1E8;
                pub const m_nOutControlPointNumber: i64 = 0x1EC;
            }
            pub mod C_OP_RenderAsModels {
                pub const m_ModelList: i64 = 0x230;
                pub const m_flModelScale: i64 = 0x24C;
                pub const m_nSizeCullBloat: i64 = 0x260;
                pub const m_bFitToModelSize: i64 = 0x250;
                pub const m_bNonUniformScaling: i64 = 0x251;
                pub const m_nXAxisScalingAttribute: i64 = 0x254;
                pub const m_nYAxisScalingAttribute: i64 = 0x258;
                pub const m_nZAxisScalingAttribute: i64 = 0x25C;
            }
            pub mod C_OP_SetGravityToCP {
                pub const m_flScale: i64 = 0x1F0;
                pub const m_nCPInput: i64 = 0x1E8;
                pub const m_bSetZDown: i64 = 0x36A;
                pub const m_nCPOutput: i64 = 0x1EC;
                pub const m_bSetPosition: i64 = 0x368;
                pub const m_bSetOrientation: i64 = 0x369;
            }
            pub mod IParticleCollection {

            }
            pub mod CBaseRendererSource2 {
                pub const m_bRefract: i64 = 0x2268;
                pub const m_nFogType: i64 = 0x1C74;
                pub const m_bTintByFOW: i64 = 0x1DF0;
                pub const m_flDepthBias: i64 = 0x2AE0;
                pub const m_flFogAmount: i64 = 0x1C78;
                pub const m_flRollScale: i64 = 0x520;
                pub const m_nShaderType: i64 = 0xD7C;
                pub const m_nSortMethod: i64 = 0x2C58;
                pub const m_flAlphaScale: i64 = 0x3A8;
                pub const m_nAlpha2Field: i64 = 0x698;
                pub const m_bAnimateInFPS: i64 = 0x1098;
                pub const m_bRefractSolid: i64 = 0x2269;
                pub const m_flRadiusScale: i64 = 0x230;
                pub const m_stencilTestID: i64 = 0x23F4;
                pub const m_vecColorScale: i64 = 0x6A0;
                pub const m_flBumpStrength: i64 = 0x1078;
                pub const m_flDesaturation: i64 = 0x1980;
                pub const m_flDiffuseClamp: i64 = 0x1680;
                pub const m_nAnimationType: i64 = 0x1094;
                pub const m_stencilWriteID: i64 = 0x2475;
                pub const m_bRefract2Passes: i64 = 0x226A;
                pub const m_flAddSelfAmount: i64 = 0x1808;
                pub const m_flAnimationRate: i64 = 0x1090;
                pub const m_flCenterXOffset: i64 = 0xD88;
                pub const m_flCenterYOffset: i64 = 0xF00;
                pub const m_flDiffuseAmount: i64 = 0x1508;
                pub const m_flRefractAmount: i64 = 0x2270;
                pub const m_nColorBlendType: i64 = 0xD78;
                pub const m_nFeatheringMode: i64 = 0x24FC;
                pub const m_bBlendFramesSeq0: i64 = 0x2C5C;
                pub const m_nOutputBlendMode: i64 = 0x17FC;
                pub const m_nRefractBlurType: i64 = 0x23EC;
                pub const m_vecTexturesInput: i64 = 0x1080;
                pub const m_flSelfIllumAmount: i64 = 0x1390;
                pub const m_strShaderOverride: i64 = 0xD80;
                pub const m_bDisableZBuffering: i64 = 0x24F8;
                pub const m_bReverseZBuffering: i64 = 0x24F7;
                pub const m_bTintByGlobalLight: i64 = 0x1DF1;
                pub const m_flFeatheringFilter: i64 = 0x27F0;
                pub const m_flOverbrightFactor: i64 = 0x1AF8;
                pub const m_nRefractBlurRadius: i64 = 0x23E8;
                pub const m_bStencilTestExclude: i64 = 0x2474;
                pub const m_flFeatheringMaxDist: i64 = 0x2678;
                pub const m_flFeatheringMinDist: i64 = 0x2500;
                pub const m_nAlphaReferenceType: i64 = 0x1DFC;
                pub const m_flMotionVectorScaleU: i64 = 0x10A0;
                pub const m_flMotionVectorScaleV: i64 = 0x1218;
                pub const m_nCropTextureOverride: i64 = 0x107C;
                pub const m_nHSVShiftControlPoint: i64 = 0x1C70;
                pub const m_nLightingControlPoint: i64 = 0x17F8;
                pub const m_bWriteStencilOnDepthFail: i64 = 0x24F6;
                pub const m_bWriteStencilOnDepthPass: i64 = 0x24F5;
                pub const m_flAlphaReferenceSoftness: i64 = 0x1E00;
                pub const m_bGammaCorrectVertexColors: i64 = 0x1800;
                pub const m_flFeatheringDepthMapFilter: i64 = 0x2968;
                pub const m_nPerParticleAlphaRefWindow: i64 = 0x1DF8;
                pub const m_nPerParticleAlphaReference: i64 = 0x1DF4;
                pub const m_bSaturateColorPreAlphaBlend: i64 = 0x1801;
                pub const m_bUseMixedResolutionRendering: i64 = 0x23F2;
                pub const m_flSourceAlphaValueToMapToOne: i64 = 0x20F0;
                pub const m_bOnlyRenderInEffectsBloomPass: i64 = 0x23F0;
                pub const m_bOnlyRenderInEffectsWaterPass: i64 = 0x23F1;
                pub const m_flSourceAlphaValueToMapToZero: i64 = 0x1F78;
                pub const m_bMaxLuminanceBlendingSequence0: i64 = 0x2C5D;
                pub const m_bOnlyRenderInEffecsGameOverlay: i64 = 0x23F3;
            }
            pub mod CPulseCell_BaseState {

            }
            pub mod CPulseCell_BaseValue {

            }
            pub mod CPulse_InvokeBinding {
                pub const m_FuncName: i64 = 0x30;
                pub const m_nSrcChunk: i64 = 0x44;
                pub const m_nCellIndex: i64 = 0x40;
                pub const m_RegisterMap: i64 = 0x0;
                pub const m_nSrcInstruction: i64 = 0x48;
            }
            pub mod C_INIT_CreateFromCPs {
                pub const m_nMaxCP: i64 = 0x1F0;
                pub const m_nMinCP: i64 = 0x1EC;
                pub const m_nIncrement: i64 = 0x1E8;
                pub const m_nDynamicCPCount: i64 = 0x1F8;
            }
            pub mod C_INIT_CreateOnModel {
                pub const m_bUseMesh: i64 = 0x1272;
                pub const m_bUseBones: i64 = 0x1271;
                pub const m_modelInput: i64 = 0x1E8;
                pub const m_flShellSize: i64 = 0x1278;
                pub const m_bLocalCoords: i64 = 0x1270;
                pub const m_HitboxSetName: i64 = 0x11F0;
                pub const m_nForceInModel: i64 = 0x2B0;
                pub const m_bScaleToVolume: i64 = 0x2B4;
                pub const m_flBoneVelocity: i64 = 0xB10;
                pub const m_nDesiredHitbox: i64 = 0x2B8;
                pub const m_transformInput: i64 = 0x248;
                pub const m_vecHitBoxScale: i64 = 0x438;
                pub const m_vecDirectionBias: i64 = 0xB18;
                pub const m_bEvenDistribution: i64 = 0x2B5;
                pub const m_flMaxBoneVelocity: i64 = 0xB14;
                pub const m_nHitboxValueFromControlPointIndex: i64 = 0x430;
            }
            pub mod C_INIT_CreationNoise {
                pub const m_bAbsVal: i64 = 0x1EC;
                pub const m_flOffset: i64 = 0x1F0;
                pub const m_bAbsValInv: i64 = 0x1ED;
                pub const m_flOutputMax: i64 = 0x1F8;
                pub const m_flOutputMin: i64 = 0x1F4;
                pub const m_flNoiseScale: i64 = 0x1FC;
                pub const m_nFieldOutput: i64 = 0x1E8;
                pub const m_vecOffsetLoc: i64 = 0x204;
                pub const m_flNoiseScaleLoc: i64 = 0x200;
                pub const m_flWorldTimeScale: i64 = 0x210;
            }
            pub mod C_INIT_QuantizeFloat {
                pub const m_InputValue: i64 = 0x1E8;
                pub const m_nOutputField: i64 = 0x360;
            }
            pub mod C_INIT_RandomYawFlip {
                pub const m_flPercent: i64 = 0x1E8;
            }
            pub mod C_INIT_ScaleVelocity {
                pub const m_vecScale: i64 = 0x1E8;
            }
            pub mod C_OP_CPVelocityForce {
                pub const m_flScale: i64 = 0x1F8;
                pub const m_nControlPointNumber: i64 = 0x1F0;
            }
            pub mod C_OP_CollideWithSelf {
                pub const m_flRadiusScale: i64 = 0x1E0;
                pub const m_flMinimumSpeed: i64 = 0x358;
            }
            pub mod C_OP_DecayClampCount {
                pub const m_nCount: i64 = 0x1E0;
            }
            pub mod C_OP_GameLiquidSpill {
                pub const m_flRadius: i64 = 0x520;
                pub const m_flExpirationTime: i64 = 0x3A8;
                pub const m_nAmountAttribute: i64 = 0x69C;
                pub const m_bCheckExposedToSky: i64 = 0x698;
                pub const m_flLiquidContentsField: i64 = 0x230;
            }
            pub mod C_OP_LagCompensation {
                pub const m_nLatencyCP: i64 = 0x1E4;
                pub const m_nLatencyCPField: i64 = 0x1E8;
                pub const m_nDesiredVelocityCP: i64 = 0x1E0;
                pub const m_nDesiredVelocityCPField: i64 = 0x1EC;
            }
            pub mod C_OP_LockToPointList {
                pub const m_pointList: i64 = 0x1E8;
                pub const m_bClosedLoop: i64 = 0x201;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_bPlaceAlongPath: i64 = 0x200;
                pub const m_nNumPointsAlongPath: i64 = 0x204;
            }
            pub mod C_OP_MaintainEmitter {
                pub const m_flScale: i64 = 0x4F8;
                pub const m_flStartTime: i64 = 0x360;
                pub const m_flEmissionRate: i64 = 0x4E0;
                pub const m_bFinalEmitOnStop: i64 = 0x4F1;
                pub const m_strSnapshotSubset: i64 = 0x4E8;
                pub const m_flEmissionDuration: i64 = 0x368;
                pub const m_bEmitInstantaneously: i64 = 0x4F0;
                pub const m_nParticlesToMaintain: i64 = 0x1E8;
                pub const m_nSnapshotControlPoint: i64 = 0x4E4;
            }
            pub mod C_OP_NormalizeVector {
                pub const m_flScale: i64 = 0x1E4;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_Orient2DRelToCP {
                pub const m_nCP: i64 = 0x1E8;
                pub const m_flRotOffset: i64 = 0x1E0;
                pub const m_nFieldOutput: i64 = 0x1EC;
                pub const m_flSpinStrength: i64 = 0x1E4;
            }
            pub mod C_OP_OscillateScalar {
                pub const m_nField: i64 = 0x1F0;
                pub const m_RateMax: i64 = 0x1E4;
                pub const m_RateMin: i64 = 0x1E0;
                pub const m_flOscAdd: i64 = 0x20C;
                pub const m_flOscMult: i64 = 0x208;
                pub const m_FrequencyMax: i64 = 0x1EC;
                pub const m_FrequencyMin: i64 = 0x1E8;
                pub const m_bProportional: i64 = 0x1F4;
                pub const m_flEndTime_max: i64 = 0x204;
                pub const m_flEndTime_min: i64 = 0x200;
                pub const m_bProportionalOp: i64 = 0x1F5;
                pub const m_flStartTime_max: i64 = 0x1FC;
                pub const m_flStartTime_min: i64 = 0x1F8;
            }
            pub mod C_OP_OscillateVector {
                pub const m_nField: i64 = 0x210;
                pub const m_RateMax: i64 = 0x1EC;
                pub const m_RateMin: i64 = 0x1E0;
                pub const m_bOffset: i64 = 0x216;
                pub const m_flOscAdd: i64 = 0x3A0;
                pub const m_flOscMult: i64 = 0x228;
                pub const m_flRateScale: i64 = 0x518;
                pub const m_FrequencyMax: i64 = 0x204;
                pub const m_FrequencyMin: i64 = 0x1F8;
                pub const m_bProportional: i64 = 0x214;
                pub const m_flEndTime_max: i64 = 0x224;
                pub const m_flEndTime_min: i64 = 0x220;
                pub const m_bProportionalOp: i64 = 0x215;
                pub const m_flStartTime_max: i64 = 0x21C;
                pub const m_flStartTime_min: i64 = 0x218;
            }
            pub mod C_OP_PinParticleToCP {
                pub const m_flAge: i64 = 0xD38;
                pub const m_vecOffset: i64 = 0x1E8;
                pub const m_bOffsetLocal: i64 = 0x8C0;
                pub const m_flBreakSpeed: i64 = 0xBC0;
                pub const m_flBreakValue: i64 = 0xEB8;
                pub const m_nPinBreakType: i64 = 0xA40;
                pub const m_flBreakDistance: i64 = 0xA48;
                pub const m_flInterpolation: i64 = 0x1030;
                pub const m_nParticleNumber: i64 = 0x8C8;
                pub const m_nParticleSelection: i64 = 0x8C4;
                pub const m_nControlPointNumber: i64 = 0x1E0;
                pub const m_bRetainInitialVelocity: i64 = 0x11A8;
                pub const m_nBreakControlPointNumber: i64 = 0xEB0;
                pub const m_nBreakControlPointNumber2: i64 = 0xEB4;
            }
            pub mod C_OP_RemapCPtoScalar {
                pub const m_nField: i64 = 0x1E8;
                pub const m_nCPInput: i64 = 0x1E0;
                pub const m_flEndTime: i64 = 0x200;
                pub const m_flInputMax: i64 = 0x1F0;
                pub const m_flInputMin: i64 = 0x1EC;
                pub const m_nSetMethod: i64 = 0x208;
                pub const m_flOutputMax: i64 = 0x1F8;
                pub const m_flOutputMin: i64 = 0x1F4;
                pub const m_flStartTime: i64 = 0x1FC;
                pub const m_flInterpRate: i64 = 0x204;
                pub const m_nFieldOutput: i64 = 0x1E4;
            }
            pub mod C_OP_RemapCPtoVector {
                pub const m_bOffset: i64 = 0x22C;
                pub const m_nCPInput: i64 = 0x1E0;
                pub const m_flEndTime: i64 = 0x220;
                pub const m_vInputMax: i64 = 0x1F8;
                pub const m_vInputMin: i64 = 0x1EC;
                pub const m_nSetMethod: i64 = 0x228;
                pub const m_vOutputMax: i64 = 0x210;
                pub const m_vOutputMin: i64 = 0x204;
                pub const m_bAccelerate: i64 = 0x22D;
                pub const m_flStartTime: i64 = 0x21C;
                pub const m_flInterpRate: i64 = 0x224;
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_nLocalSpaceCP: i64 = 0x1E8;
            }
            pub mod C_OP_RemapVectortoCP {
                pub const m_nFieldInput: i64 = 0x1E4;
                pub const m_nParticleNumber: i64 = 0x1E8;
                pub const m_nOutControlPointNumber: i64 = 0x1E0;
            }
            pub mod C_OP_RenderLightBeam {
                pub const m_flRange: i64 = 0x1080;
                pub const m_flSkirt: i64 = 0xF08;
                pub const m_flThickness: i64 = 0x11F8;
                pub const m_nMaxAllowed: i64 = 0x230;
                pub const m_vColorBlend: i64 = 0x238;
                pub const m_bCastShadows: i64 = 0xD88;
                pub const m_flBounceScale: i64 = 0xD90;
                pub const m_strLightStyle: i64 = 0x918;
                pub const m_bDynamicBounce: i64 = 0xD89;
                pub const m_flRenderFilter: i64 = 0x1EB8;
                pub const m_nColorBlendType: i64 = 0x910;
                pub const m_flInnerConeAngle: i64 = 0x1370;
                pub const m_flLightStyleTime: i64 = 0x920;
                pub const m_flOuterConeAngle: i64 = 0x14E8;
                pub const m_nFogLightingMode: i64 = 0x1D38;
                pub const m_bDebugOrientation: i64 = 0x2030;
                pub const m_flFogContribution: i64 = 0x1D40;
                pub const m_vecConeRotationOffset: i64 = 0x1660;
                pub const m_flNumberOfLightsToCreate: i64 = 0xC10;
                pub const m_flBrightnessLumensPerMeter: i64 = 0xA98;
            }
            pub mod C_OP_RenderProjected {
                pub const m_flRollScale: i64 = 0x6E0;
                pub const m_MaterialVars: i64 = 0x3D8;
                pub const m_flAlphaScale: i64 = 0x568;
                pub const m_nAlpha2Field: i64 = 0x858;
                pub const m_bProjectWater: i64 = 0x232;
                pub const m_bProjectWorld: i64 = 0x231;
                pub const m_flRadiusScale: i64 = 0x3F0;
                pub const m_vecColorScale: i64 = 0x860;
                pub const m_bFlipHorizontal: i64 = 0x233;
                pub const m_bOrientToNormal: i64 = 0x3D4;
                pub const m_nColorBlendType: i64 = 0xF38;
                pub const m_bProjectCharacter: i64 = 0x230;
                pub const m_flMaterialSelection: i64 = 0x258;
                pub const m_flAnimationTimeScale: i64 = 0x3D0;
                pub const m_flMaxProjectionDepth: i64 = 0x23C;
                pub const m_flMinProjectionDepth: i64 = 0x238;
                pub const m_vecProjectedMaterials: i64 = 0x240;
                pub const m_bEnableProjectedDepthControls: i64 = 0x234;
            }
            pub mod C_OP_RenderTreeShake {
                pub const m_flRadius: i64 = 0x238;
                pub const m_flTwistAmount: i64 = 0x248;
                pub const m_flPeakStrength: i64 = 0x230;
                pub const m_flRadialAmount: i64 = 0x24C;
                pub const m_flShakeDuration: i64 = 0x240;
                pub const m_flTransitionTime: i64 = 0x244;
                pub const m_nRadiusFieldOverride: i64 = 0x23C;
                pub const m_nPeakStrengthFieldOverride: i64 = 0x234;
                pub const m_flControlPointOrientationAmount: i64 = 0x250;
                pub const m_nControlPointForLinearDirection: i64 = 0x254;
            }
            pub mod C_OP_TurbulenceForce {
                pub const m_vecNoiseAmount0: i64 = 0x200;
                pub const m_vecNoiseAmount1: i64 = 0x20C;
                pub const m_vecNoiseAmount2: i64 = 0x218;
                pub const m_vecNoiseAmount3: i64 = 0x224;
                pub const m_flNoiseCoordScale0: i64 = 0x1F0;
                pub const m_flNoiseCoordScale1: i64 = 0x1F4;
                pub const m_flNoiseCoordScale2: i64 = 0x1F8;
                pub const m_flNoiseCoordScale3: i64 = 0x1FC;
            }
            pub mod C_OP_TwistAroundAxis {
                pub const m_TwistAxis: i64 = 0x1F4;
                pub const m_bLocalSpace: i64 = 0x200;
                pub const m_fForceAmount: i64 = 0x1F0;
                pub const m_nControlPointNumber: i64 = 0x204;
            }
            pub mod CPulseCell_LimitCount {
                pub const m_nLimitCount: i64 = 0x48;
            }
            pub mod C_INIT_PositionOffset {
                pub const m_OffsetMax: i64 = 0x8C0;
                pub const m_OffsetMin: i64 = 0x1E8;
                pub const m_bLocalCoords: i64 = 0x1000;
                pub const m_bProportional: i64 = 0x1001;
                pub const m_TransformInput: i64 = 0xF98;
                pub const m_randomnessParameters: i64 = 0x1004;
            }
            pub mod C_INIT_RandomLifeTime {
                pub const m_fLifetimeMax: i64 = 0x1EC;
                pub const m_fLifetimeMin: i64 = 0x1E8;
                pub const m_fLifetimeRandExponent: i64 = 0x1F0;
            }
            pub mod C_INIT_RandomRotation {

            }
            pub mod C_INIT_RandomSequence {
                pub const m_bLinear: i64 = 0x1F1;
                pub const m_bShuffle: i64 = 0x1F0;
                pub const m_WeightedList: i64 = 0x1F8;
                pub const m_nSequenceMax: i64 = 0x1EC;
                pub const m_nSequenceMin: i64 = 0x1E8;
            }
            pub mod C_INIT_SequenceFromCP {
                pub const m_nCP: i64 = 0x1EC;
                pub const m_vecOffset: i64 = 0x1F0;
                pub const m_bKillUnused: i64 = 0x1E8;
                pub const m_bRadiusScale: i64 = 0x1E9;
            }
            pub mod C_INIT_StatusEffectTf {
                pub const m_flSFXSScale: i64 = 0x1FC;
                pub const m_nDetailCombo: i64 = 0x218;
                pub const m_flSFXSOffsetX: i64 = 0x20C;
                pub const m_flSFXSOffsetY: i64 = 0x210;
                pub const m_flSFXSOffsetZ: i64 = 0x214;
                pub const m_flSFXSScrollX: i64 = 0x200;
                pub const m_flSFXSScrollY: i64 = 0x204;
                pub const m_flSFXSScrollZ: i64 = 0x208;
                pub const m_flSFXEnvMapAmount: i64 = 0x234;
                pub const m_flSFXNormalAmount: i64 = 0x1EC;
                pub const m_flSFXSDetailScale: i64 = 0x220;
                pub const m_flSFXSUseModelUVs: i64 = 0x230;
                pub const m_flSFXSDetailAmount: i64 = 0x21C;
                pub const m_flSFXSDetailScrollX: i64 = 0x224;
                pub const m_flSFXSDetailScrollY: i64 = 0x228;
                pub const m_flSFXSDetailScrollZ: i64 = 0x22C;
                pub const m_flSFXColorWarpAmount: i64 = 0x1E8;
                pub const m_flSFXMetalnessAmount: i64 = 0x1F0;
                pub const m_flSFXRoughnessAmount: i64 = 0x1F4;
                pub const m_flSFXSelfIllumAmount: i64 = 0x1F8;
            }
            pub mod C_INIT_VelocityFromCP {
                pub const m_velocityInput: i64 = 0x1E8;
                pub const m_bDirectionOnly: i64 = 0x92C;
                pub const m_transformInput: i64 = 0x8C0;
                pub const m_flVelocityScale: i64 = 0x928;
            }
            pub mod C_INIT_VelocityRandom {
                pub const m_bIgnoreDT: i64 = 0x1290;
                pub const m_fSpeedMax: i64 = 0x368;
                pub const m_fSpeedMin: i64 = 0x1F0;
                pub const m_nControlPointNumber: i64 = 0x1E8;
                pub const m_randomnessParameters: i64 = 0x1294;
                pub const m_LocalCoordinateSystemSpeedMax: i64 = 0xBB8;
                pub const m_LocalCoordinateSystemSpeedMin: i64 = 0x4E0;
            }
            pub mod C_OP_ColorInterpolate {
                pub const m_ColorFade: i64 = 0x1E0;
                pub const m_bEaseInOut: i64 = 0x1FC;
                pub const m_nFieldOutput: i64 = 0x1F8;
                pub const m_flFadeEndTime: i64 = 0x1F4;
                pub const m_flFadeStartTime: i64 = 0x1F0;
            }
            pub mod C_OP_EndCapTimedDecay {
                pub const m_flDecayTime: i64 = 0x1E0;
            }
            pub mod C_OP_LerpEndCapScalar {
                pub const m_flOutput: i64 = 0x1E4;
                pub const m_flLerpTime: i64 = 0x1E8;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_LerpEndCapVector {
                pub const m_vecOutput: i64 = 0x1E4;
                pub const m_flLerpTime: i64 = 0x1F0;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_PerParticleForce {
                pub const m_nCP: i64 = 0xA40;
                pub const m_vForce: i64 = 0x368;
                pub const m_flForceScale: i64 = 0x1F0;
            }
            pub mod C_OP_PlanarConstraint {
                pub const m_PlaneNormal: i64 = 0x1EC;
                pub const m_bUseOldCode: i64 = 0x4F0;
                pub const m_PointOnPlane: i64 = 0x1E0;
                pub const m_bGlobalNormal: i64 = 0x1FD;
                pub const m_bGlobalOrigin: i64 = 0x1FC;
                pub const m_flRadiusScale: i64 = 0x200;
                pub const m_nControlPointNumber: i64 = 0x1F8;
                pub const m_flMaximumDistanceToCP: i64 = 0x378;
            }
            pub mod C_OP_RampScalarLinear {
                pub const m_nField: i64 = 0x220;
                pub const m_RateMax: i64 = 0x1E4;
                pub const m_RateMin: i64 = 0x1E0;
                pub const m_flEndTime_max: i64 = 0x1F4;
                pub const m_flEndTime_min: i64 = 0x1F0;
                pub const m_bProportionalOp: i64 = 0x224;
                pub const m_flStartTime_max: i64 = 0x1EC;
                pub const m_flStartTime_min: i64 = 0x1E8;
            }
            pub mod C_OP_RampScalarSpline {
                pub const m_flBias: i64 = 0x1F8;
                pub const m_nField: i64 = 0x220;
                pub const m_RateMax: i64 = 0x1E4;
                pub const m_RateMin: i64 = 0x1E0;
                pub const m_bEaseOut: i64 = 0x225;
                pub const m_flEndTime_max: i64 = 0x1F4;
                pub const m_flEndTime_min: i64 = 0x1F0;
                pub const m_bProportionalOp: i64 = 0x224;
                pub const m_flStartTime_max: i64 = 0x1EC;
                pub const m_flStartTime_min: i64 = 0x1E8;
            }
            pub mod C_OP_RenderClothForce {

            }
            pub mod C_OP_RenderOmni2Light {
                pub const m_bFog: i64 = 0xF10;
                pub const m_flRange: i64 = 0x2A08;
                pub const m_flSkirt: i64 = 0x2890;
                pub const m_vNormal: i64 = 0x1210;
                pub const m_vTarget: i64 = 0x18E8;
                pub const m_flFOVAngle: i64 = 0x1FC0;
                pub const m_flFogScale: i64 = 0xF18;
                pub const m_nLightType: i64 = 0x230;
                pub const m_flBarnShape: i64 = 0x2138;
                pub const m_flBarnSoftX: i64 = 0x25A0;
                pub const m_flBarnSoftY: i64 = 0x2718;
                pub const m_nMaxAllowed: i64 = 0x234;
                pub const m_vColorBlend: i64 = 0x238;
                pub const m_bCastShadows: i64 = 0xD90;
                pub const m_hLightCookie: i64 = 0x2E70;
                pub const m_flBounceScale: i64 = 0xD98;
                pub const m_strLightStyle: i64 = 0x918;
                pub const m_bDynamicBounce: i64 = 0xD91;
                pub const m_flBarnNearSizeX: i64 = 0x22B0;
                pub const m_flBarnNearSizeY: i64 = 0x2428;
                pub const m_nBrightnessUnit: i64 = 0xA98;
                pub const m_nColorBlendType: i64 = 0x910;
                pub const m_bSphericalCookie: i64 = 0x2E78;
                pub const m_flInnerConeAngle: i64 = 0x2B80;
                pub const m_flLightStyleTime: i64 = 0x920;
                pub const m_flOuterConeAngle: i64 = 0x2CF8;
                pub const m_nOrientationType: i64 = 0x1208;
                pub const m_flLuminaireRadius: i64 = 0x1090;
                pub const m_flBrightnessLumens: i64 = 0xAA0;
                pub const m_flBrightnessCandelas: i64 = 0xC18;
            }
            pub mod C_OP_TimeVaryingForce {
                pub const m_EndingForce: i64 = 0x204;
                pub const m_StartingForce: i64 = 0x1F4;
                pub const m_flEndLerpTime: i64 = 0x200;
                pub const m_flStartLerpTime: i64 = 0x1F0;
            }
            pub mod CGeneralRandomRotation {
                pub const m_flDegrees: i64 = 0x1EC;
                pub const m_flDegreesMax: i64 = 0x1F4;
                pub const m_flDegreesMin: i64 = 0x1F0;
                pub const m_nFieldOutput: i64 = 0x1E8;
                pub const m_bRandomlyFlipDirection: i64 = 0x1FC;
                pub const m_flRotationRandExponent: i64 = 0x1F8;
            }
            pub mod CParticleFunctionForce {

            }
            pub mod CPulseCell_CursorQueue {
                pub const m_nCursorsAllowedToRunParallel: i64 = 0x128;
            }
            pub mod CPulseCell_FireCursors {
                pub const m_Outflows: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0xF8;
                pub const m_bWaitForChildOutflows: i64 = 0xF0;
            }
            pub mod CPulseCell_Inflow_Wait {
                pub const m_WakeResume: i64 = 0xD8;
            }
            pub mod CPulseCell_RaceCursors {
                pub const m_Outflows: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0xF0;
            }
            pub mod CPulseCell_Value_Curve {
                pub const m_Curve: i64 = 0x48;
            }
            pub mod C_INIT_CreateAlongPath {
                pub const m_fT: i64 = 0x360;
                pub const m_PathParams: i64 = 0x4E0;
                pub const m_vEndOffset: i64 = 0x524;
                pub const m_bSaveOffset: i64 = 0x530;
                pub const m_fMaxDistance: i64 = 0x1E8;
                pub const m_bUseRandomCPs: i64 = 0x520;
            }
            pub mod C_INIT_CreateWithinBox {
                pub const m_vecMax: i64 = 0x8C0;
                pub const m_vecMin: i64 = 0x1E8;
                pub const m_bLocalSpace: i64 = 0xF9C;
                pub const m_bUseNewCode: i64 = 0xFA8;
                pub const m_nControlPointNumber: i64 = 0xF98;
                pub const m_randomnessParameters: i64 = 0xFA0;
            }
            pub mod C_INIT_InheritVelocity {
                pub const m_flVelocityScale: i64 = 0x1EC;
                pub const m_nControlPointNumber: i64 = 0x1E8;
            }
            pub mod C_INIT_NormalAlignToCP {
                pub const m_transformInput: i64 = 0x1E8;
                pub const m_nControlPointAxis: i64 = 0x250;
            }
            pub mod C_INIT_Orient2DRelToCP {
                pub const m_nCP: i64 = 0x1E8;
                pub const m_flRotOffset: i64 = 0x1F0;
                pub const m_nFieldOutput: i64 = 0x1EC;
            }
            pub mod C_OP_ConstrainDistance {
                pub const m_CenterOffset: i64 = 0x538;
                pub const m_fMaxDistance: i64 = 0x358;
                pub const m_fMinDistance: i64 = 0x1E0;
                pub const m_bGlobalCenter: i64 = 0xC10;
                pub const m_nControlPointNumber: i64 = 0x4D0;
            }
            pub mod C_OP_ContinuousEmitter {
                pub const m_flEmitRate: i64 = 0x4D8;
                pub const m_nEventType: i64 = 0x65C;
                pub const m_flStartTime: i64 = 0x360;
                pub const m_flEmissionScale: i64 = 0x650;
                pub const m_nLimitPerUpdate: i64 = 0x670;
                pub const m_strSnapshotSubset: i64 = 0x668;
                pub const m_flEmissionDuration: i64 = 0x1E8;
                pub const m_nSnapshotControlPoint: i64 = 0x660;
                pub const m_bForceEmitOnLastUpdate: i64 = 0x675;
                pub const m_bForceEmitOnFirstUpdate: i64 = 0x674;
                pub const m_flScalePerParentParticle: i64 = 0x654;
                pub const m_bInitFromKilledParentParticles: i64 = 0x658;
            }
            pub mod C_OP_ControlpointLight {
                pub const m_flScale: i64 = 0x1E0;
                pub const m_bUseNormal: i64 = 0x6E8;
                pub const m_LightColor1: i64 = 0x6D0;
                pub const m_LightColor2: i64 = 0x6D4;
                pub const m_LightColor3: i64 = 0x6D8;
                pub const m_LightColor4: i64 = 0x6DC;
                pub const m_bLightType1: i64 = 0x6E0;
                pub const m_bLightType2: i64 = 0x6E1;
                pub const m_bLightType3: i64 = 0x6E2;
                pub const m_bLightType4: i64 = 0x6E3;
                pub const m_bUseHLambert: i64 = 0x6E9;
                pub const m_vecCPOffset1: i64 = 0x680;
                pub const m_vecCPOffset2: i64 = 0x68C;
                pub const m_vecCPOffset3: i64 = 0x698;
                pub const m_vecCPOffset4: i64 = 0x6A4;
                pub const m_LightZeroDist1: i64 = 0x6B4;
                pub const m_LightZeroDist2: i64 = 0x6BC;
                pub const m_LightZeroDist3: i64 = 0x6C4;
                pub const m_LightZeroDist4: i64 = 0x6CC;
                pub const m_bLightDynamic1: i64 = 0x6E4;
                pub const m_bLightDynamic2: i64 = 0x6E5;
                pub const m_bLightDynamic3: i64 = 0x6E6;
                pub const m_bLightDynamic4: i64 = 0x6E7;
                pub const m_nControlPoint1: i64 = 0x670;
                pub const m_nControlPoint2: i64 = 0x674;
                pub const m_nControlPoint3: i64 = 0x678;
                pub const m_nControlPoint4: i64 = 0x67C;
                pub const m_LightFiftyDist1: i64 = 0x6B0;
                pub const m_LightFiftyDist2: i64 = 0x6B8;
                pub const m_LightFiftyDist3: i64 = 0x6C0;
                pub const m_LightFiftyDist4: i64 = 0x6C8;
                pub const m_bClampLowerRange: i64 = 0x6EE;
                pub const m_bClampUpperRange: i64 = 0x6EF;
            }
            pub mod C_OP_EndCapTimedFreeze {
                pub const m_flFreezeTime: i64 = 0x1E0;
            }
            pub mod C_OP_ExternalWindForce {
                pub const m_vecScale: i64 = 0x8C8;
                pub const m_bSampleWind: i64 = 0xFA0;
                pub const m_bSampleWater: i64 = 0xFA1;
                pub const m_bSampleGravity: i64 = 0xFA3;
                pub const m_vecGravityForce: i64 = 0xFA8;
                pub const m_vecBuoyancyForce: i64 = 0x1978;
                pub const m_vecSamplePosition: i64 = 0x1F0;
                pub const m_flLocalGravityScale: i64 = 0x1688;
                pub const m_flLocalBuoyancyScale: i64 = 0x1800;
                pub const m_bDampenNearWaterPlane: i64 = 0xFA2;
                pub const m_bUseBasicMovementGravity: i64 = 0x1680;
            }
            pub mod C_OP_GameDecalRenderer {
                pub const m_vecEndPos: i64 = 0x928;
                pub const m_nEventType: i64 = 0x238;
                pub const m_flDecalSize: i64 = 0x1178;
                pub const m_vecStartPos: i64 = 0x250;
                pub const m_flTraceBloat: i64 = 0x1000;
                pub const m_flDecalRotation: i64 = 0x1468;
                pub const m_nCollisionGroup: i64 = 0x248;
                pub const m_sDecalGroupName: i64 = 0x230;
                pub const m_bNoDecalsOnOwner: i64 = 0x1CBB;
                pub const m_bVisualizeTraces: i64 = 0x1CBC;
                pub const m_nDecalGroupIndex: i64 = 0x12F0;
                pub const m_nInteractionMask: i64 = 0x240;
                pub const m_vModulationColor: i64 = 0x15E0;
                pub const m_bRandomDecalRotation: i64 = 0x1CB9;
                pub const m_bUseGameDefaultDecalSize: i64 = 0x1CB8;
                pub const m_bRandomlySelectDecalInGroup: i64 = 0x1CBA;
            }
            pub mod C_OP_InterpolateRadius {
                pub const m_flBias: i64 = 0x1F4;
                pub const m_flEndTime: i64 = 0x1E4;
                pub const m_flEndScale: i64 = 0x1EC;
                pub const m_flStartTime: i64 = 0x1E0;
                pub const m_flStartScale: i64 = 0x1E8;
                pub const m_bEaseInAndOut: i64 = 0x1F0;
            }
            pub mod C_OP_RemapScalarEndCap {
                pub const m_flInputMax: i64 = 0x1EC;
                pub const m_flInputMin: i64 = 0x1E8;
                pub const m_flOutputMax: i64 = 0x1F4;
                pub const m_flOutputMin: i64 = 0x1F0;
                pub const m_nFieldInput: i64 = 0x1E0;
                pub const m_nFieldOutput: i64 = 0x1E4;
            }
            pub mod C_OP_RenderGpuImplicit {
                pub const m_nScaleCP: i64 = 0x6A8;
                pub const m_fGridSize: i64 = 0x240;
                pub const m_hMaterial: i64 = 0x6B0;
                pub const m_fRadiusScale: i64 = 0x3B8;
                pub const m_nIndexCountKb: i64 = 0x238;
                pub const m_nVertexCountKb: i64 = 0x234;
                pub const m_fIsosurfaceThreshold: i64 = 0x530;
                pub const m_bUsePerParticleRadius: i64 = 0x230;
            }
            pub mod C_OP_RenderScreenShake {
                pub const m_nFilterCP: i64 = 0x250;
                pub const m_nRadiusField: i64 = 0x240;
                pub const m_flRadiusScale: i64 = 0x234;
                pub const m_nDurationField: i64 = 0x244;
                pub const m_flDurationScale: i64 = 0x230;
                pub const m_nAmplitudeField: i64 = 0x24C;
                pub const m_nFrequencyField: i64 = 0x248;
                pub const m_flAmplitudeScale: i64 = 0x23C;
                pub const m_flFrequencyScale: i64 = 0x238;
            }
            pub mod C_OP_SequenceFromModel {
                pub const m_flInputMax: i64 = 0x1F0;
                pub const m_flInputMin: i64 = 0x1EC;
                pub const m_nSetMethod: i64 = 0x1FC;
                pub const m_flOutputMax: i64 = 0x1F8;
                pub const m_flOutputMin: i64 = 0x1F4;
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_nFieldOutputAnim: i64 = 0x1E8;
                pub const m_nControlPointNumber: i64 = 0x1E0;
            }
            pub mod C_OP_SetFromCPSnapshot {
                pub const m_bPrev: i64 = 0x671;
                pub const m_bRandom: i64 = 0x1FC;
                pub const m_bReverse: i64 = 0x1FD;
                pub const m_bSubSample: i64 = 0x670;
                pub const m_nRandomSeed: i64 = 0x200;
                pub const m_nLocalSpaceCP: i64 = 0x1F8;
                pub const m_flInterpolation: i64 = 0x4F8;
                pub const m_nAttributeToRead: i64 = 0x1F0;
                pub const m_nAttributeToWrite: i64 = 0x1F4;
                pub const m_strSnapshotSubset: i64 = 0x1E8;
                pub const m_nSnapShotIncrement: i64 = 0x380;
                pub const m_nControlPointNumber: i64 = 0x1E0;
                pub const m_nSnapShotStartPoint: i64 = 0x208;
            }
            pub mod C_OP_SetSimulationRate {
                pub const m_flSimulationScale: i64 = 0x1E8;
            }
            pub mod C_OP_UpdateLightSource {
                pub const m_vColorTint: i64 = 0x1E0;
                pub const m_flRadiusScale: i64 = 0x1E8;
                pub const m_flBrightnessScale: i64 = 0x1E4;
                pub const m_flMaximumLightingRadius: i64 = 0x1F0;
                pub const m_flMinimumLightingRadius: i64 = 0x1EC;
                pub const m_flPositionDampingConstant: i64 = 0x1F4;
            }
            pub mod ParticleChildrenInfo_t {
                pub const m_bEndCap: i64 = 0xC;
                pub const m_flDelay: i64 = 0x8;
                pub const m_ChildRef: i64 = 0x0;
                pub const m_nDetailLevel: i64 = 0x10;
                pub const m_bDisableChild: i64 = 0xD;
            }
            pub mod ParticlePreviewState_t {
                pub const m_groundType: i64 = 0xC;
                pub const m_previewModel: i64 = 0x0;
                pub const m_sequenceName: i64 = 0x10;
                pub const m_hitboxSetName: i64 = 0x20;
                pub const m_vecBodyGroups: i64 = 0x30;
                pub const m_vecPreviewWind: i64 = 0x64;
                pub const m_flPlaybackSpeed: i64 = 0x48;
                pub const m_nModSpecificData: i64 = 0x8;
                pub const m_materialGroupName: i64 = 0x28;
                pub const m_vecPreviewGravity: i64 = 0x58;
                pub const m_bShouldDrawHitboxes: i64 = 0x50;
                pub const m_bAnimationNonLooping: i64 = 0x54;
                pub const m_bShouldDrawAttachments: i64 = 0x51;
                pub const m_flParticleSimulationRate: i64 = 0x4C;
                pub const m_bShouldDrawAttachmentNames: i64 = 0x52;
                pub const m_bSequenceNameIsAnimClipPath: i64 = 0x55;
                pub const m_bShouldDrawControlPointAxes: i64 = 0x53;
                pub const m_nFireParticleOnSequenceFrame: i64 = 0x18;
            }
            pub mod SequenceWeightedList_t {
                pub const m_nSequence: i64 = 0x0;
                pub const m_flRelativeWeight: i64 = 0x4;
            }
            pub mod CBasePulseGraphInstance {

            }
            pub mod CPulseCell_Inflow_Yield {
                pub const m_UnyieldResume: i64 = 0xD8;
            }
            pub mod CPulseCell_ReturnValues {

            }
            pub mod C_INIT_ChaoticAttractor {
                pub const m_flAParm: i64 = 0x1E8;
                pub const m_flBParm: i64 = 0x1EC;
                pub const m_flCParm: i64 = 0x1F0;
                pub const m_flDParm: i64 = 0x1F4;
                pub const m_flScale: i64 = 0x1F8;
                pub const m_nBaseCP: i64 = 0x204;
                pub const m_flSpeedMax: i64 = 0x200;
                pub const m_flSpeedMin: i64 = 0x1FC;
                pub const m_bUniformSpeed: i64 = 0x208;
            }
            pub mod C_INIT_CreateWithinCone {
                pub const m_flSpeed: i64 = 0x540;
                pub const m_flOffset: i64 = 0x6B8;
                pub const m_flInnerAngle: i64 = 0x250;
                pub const m_flOuterAngle: i64 = 0x3C8;
                pub const m_TransformInput: i64 = 0x1E8;
                pub const m_bCollapseOffset: i64 = 0x830;
                pub const m_randomnessParameters: i64 = 0x834;
            }
            pub mod C_INIT_DistanceToCPInit {
                pub const m_bLOS: i64 = 0x7D4;
                pub const m_nStartCP: i64 = 0x7D0;
                pub const m_nTraceSet: i64 = 0x858;
                pub const m_flInputMax: i64 = 0x368;
                pub const m_flInputMin: i64 = 0x1F0;
                pub const m_flLOSScale: i64 = 0x9D8;
                pub const m_nSetMethod: i64 = 0x9DC;
                pub const m_flOutputMax: i64 = 0x658;
                pub const m_flOutputMin: i64 = 0x4E0;
                pub const m_flRemapBias: i64 = 0x9F0;
                pub const m_bActiveRange: i64 = 0x9E0;
                pub const m_nFieldOutput: i64 = 0x1E8;
                pub const m_flMaxTraceLength: i64 = 0x860;
                pub const m_vecDistanceScale: i64 = 0x9E4;
                pub const m_CollisionGroupName: i64 = 0x7D5;
            }
            pub mod C_INIT_SequenceLifeTime {
                pub const m_flFramerate: i64 = 0x1E8;
            }
            pub mod C_INIT_SetHitboxToModel {
                pub const m_bUseBones: i64 = 0x8DD;
                pub const m_flShellSize: i64 = 0x960;
                pub const m_HitboxSetName: i64 = 0x8DE;
                pub const m_nForceInModel: i64 = 0x1EC;
                pub const m_nDesiredHitbox: i64 = 0x1F4;
                pub const m_vecHitBoxScale: i64 = 0x1F8;
                pub const m_bMaintainHitbox: i64 = 0x8DC;
                pub const m_vecDirectionBias: i64 = 0x8D0;
                pub const m_bEvenDistribution: i64 = 0x1F0;
                pub const m_nControlPointNumber: i64 = 0x1E8;
            }
            pub mod C_OP_DecayMaintainCount {
                pub const m_flScale: i64 = 0x200;
                pub const m_bKillNewest: i64 = 0x378;
                pub const m_flDecayDelay: i64 = 0x1E4;
                pub const m_bLifespanDecay: i64 = 0x1F8;
                pub const m_strSnapshotSubset: i64 = 0x1F0;
                pub const m_nParticlesToMaintain: i64 = 0x1E0;
                pub const m_nSnapshotControlPoint: i64 = 0x1E8;
            }
            pub mod C_OP_IntraParticleForce {
                pub const m_bUseAABB: i64 = 0x208;
                pub const m_flRepulsionMaxDistance: i64 = 0x200;
                pub const m_flRepulsionMaxStrength: i64 = 0x204;
                pub const m_flRepulsionMinDistance: i64 = 0x1FC;
                pub const m_flAttractionMaxDistance: i64 = 0x1F4;
                pub const m_flAttractionMaxStrength: i64 = 0x1F8;
                pub const m_flAttractionMinDistance: i64 = 0x1F0;
            }
            pub mod C_OP_RampCPLinearRandom {
                pub const m_vecRateMax: i64 = 0x1F8;
                pub const m_vecRateMin: i64 = 0x1EC;
                pub const m_nOutControlPointNumber: i64 = 0x1E8;
            }
            pub mod C_OP_RenderFlattenGrass {
                pub const m_flRadiusScale: i64 = 0x238;
                pub const m_flFlattenStrength: i64 = 0x230;
                pub const m_nStrengthFieldOverride: i64 = 0x234;
            }
            pub mod C_OP_RenderStatusEffect {
                pub const m_pTextureEnvMap: i64 = 0x260;
                pub const m_pTextureDetail2: i64 = 0x238;
                pub const m_pTextureColorWarp: i64 = 0x230;
                pub const m_pTextureDiffuseWarp: i64 = 0x240;
                pub const m_pTextureFresnelWarp: i64 = 0x250;
                pub const m_pTextureSpecularWarp: i64 = 0x258;
                pub const m_pTextureFresnelColorWarp: i64 = 0x248;
            }
            pub mod C_OP_SetFloatCollection {
                pub const m_Lerp: i64 = 0x360;
                pub const m_InputValue: i64 = 0x1E0;
                pub const m_nSetMethod: i64 = 0x35C;
                pub const m_nOutputField: i64 = 0x358;
            }
            pub mod CollisionGroupContext_t {
                pub const m_nCollisionGroupNumber: i64 = 0x0;
            }
            pub mod ControlPointReference_t {
                pub const m_bOffsetInLocalSpace: i64 = 0x10;
                pub const m_controlPointNameString: i64 = 0x0;
                pub const m_vOffsetFromControlPoint: i64 = 0x4;
            }
            pub mod SignatureOutflow_Resume {

            }
            pub mod CParticleFunctionEmitter {
                pub const m_nEmitterIndex: i64 = 0x1E0;
            }
            pub mod CPulseCell_Inflow_Method {
                pub const m_Args: i64 = 0xA0;
                pub const m_bIsPublic: i64 = 0x98;
                pub const m_MethodName: i64 = 0x80;
                pub const m_Description: i64 = 0x90;
                pub const m_ReturnValues: i64 = 0xB0;
            }
            pub mod CPulseCell_IntervalTimer {
                pub const m_Completed: i64 = 0xD8;
                pub const m_OnInterval: i64 = 0x120;
            }
            pub mod CPulseCell_Step_DebugLog {

            }
            pub mod CPulse_OutflowConnection {
                pub const m_nDestChunk: i64 = 0x10;
                pub const m_nInstruction: i64 = 0x14;
                pub const m_SourceOutflowName: i64 = 0x0;
                pub const m_OutflowRegisterMap: i64 = 0x18;
            }
            pub mod C_INIT_AddVectorToVector {
                pub const m_vecScale: i64 = 0x1E8;
                pub const m_vOffsetMax: i64 = 0x208;
                pub const m_vOffsetMin: i64 = 0x1FC;
                pub const m_nFieldInput: i64 = 0x1F8;
                pub const m_nFieldOutput: i64 = 0x1F4;
                pub const m_randomnessParameters: i64 = 0x214;
            }
            pub mod C_INIT_CreatePhyllotaxis {
                pub const m_fMinRad: i64 = 0x20C;
                pub const m_fRadBias: i64 = 0x208;
                pub const m_nScaleCP: i64 = 0x1EC;
                pub const m_fDistBias: i64 = 0x210;
                pub const m_nComponent: i64 = 0x1F0;
                pub const m_fpointAngle: i64 = 0x200;
                pub const m_fRadCentCore: i64 = 0x1F4;
                pub const m_fRadPerPoint: i64 = 0x1F8;
                pub const m_fsizeOverall: i64 = 0x204;
                pub const m_bUseOrigRadius: i64 = 0x216;
                pub const m_fRadPerPointTo: i64 = 0x1FC;
                pub const m_bUseLocalCoords: i64 = 0x214;
                pub const m_bUseWithContEmit: i64 = 0x215;
                pub const m_nControlPointNumber: i64 = 0x1E8;
            }
            pub mod C_INIT_InitVecCollection {
                pub const m_InputValue: i64 = 0x1E8;
                pub const m_nOutputField: i64 = 0x8C0;
            }
            pub mod C_INIT_MoveBetweenPoints {
                pub const m_bTrailBias: i64 = 0x944;
                pub const m_flSpeedMax: i64 = 0x360;
                pub const m_flSpeedMin: i64 = 0x1E8;
                pub const m_flEndOffset: i64 = 0x7C8;
                pub const m_flEndSpread: i64 = 0x4D8;
                pub const m_flStartOffset: i64 = 0x650;
                pub const m_nEndControlPointNumber: i64 = 0x940;
            }
            pub mod C_INIT_RandomTrailLength {
                pub const m_flMaxLength: i64 = 0x1EC;
                pub const m_flMinLength: i64 = 0x1E8;
                pub const m_flLengthRandExponent: i64 = 0x1F0;
            }
            pub mod C_OP_ConstrainLineLength {
                pub const m_flMaxDistance: i64 = 0x1E4;
                pub const m_flMinDistance: i64 = 0x1E0;
            }
            pub mod C_OP_DistanceBetweenVecs {
                pub const m_vecPoint1: i64 = 0x1E8;
                pub const m_vecPoint2: i64 = 0x8C0;
                pub const m_bDeltaTime: i64 = 0x157C;
                pub const m_flInputMax: i64 = 0x1110;
                pub const m_flInputMin: i64 = 0xF98;
                pub const m_nSetMethod: i64 = 0x1578;
                pub const m_flOutputMax: i64 = 0x1400;
                pub const m_flOutputMin: i64 = 0x1288;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_DistanceToTransform {
                pub const m_bLOS: i64 = 0x830;
                pub const m_bAdditive: i64 = 0x8C5;
                pub const m_nTraceSet: i64 = 0x8B4;
                pub const m_flInputMax: i64 = 0x360;
                pub const m_flInputMin: i64 = 0x1E8;
                pub const m_flLOSScale: i64 = 0x8BC;
                pub const m_nSetMethod: i64 = 0x8C0;
                pub const m_flOutputMax: i64 = 0x650;
                pub const m_flOutputMin: i64 = 0x4D8;
                pub const m_bActiveRange: i64 = 0x8C4;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_TransformStart: i64 = 0x7C8;
                pub const m_flMaxTraceLength: i64 = 0x8B8;
                pub const m_vecComponentScale: i64 = 0x8C8;
                pub const m_CollisionGroupName: i64 = 0x831;
            }
            pub mod C_OP_DragRelativeToPlane {
                pub const m_flFalloff: i64 = 0x358;
                pub const m_bDirectional: i64 = 0x4D0;
                pub const m_flDragAtPlane: i64 = 0x1E0;
                pub const m_vecPlaneNormal: i64 = 0x4D8;
                pub const m_nControlPointNumber: i64 = 0xBB0;
            }
            pub mod C_OP_ModelDampenMovement {
                pub const m_fDrag: i64 = 0x940;
                pub const m_bOutside: i64 = 0x1E5;
                pub const m_bBoundBox: i64 = 0x1E4;
                pub const m_bUseBones: i64 = 0x1E6;
                pub const m_vecPosOffset: i64 = 0x268;
                pub const m_HitboxSetName: i64 = 0x1E7;
                pub const m_nControlPointNumber: i64 = 0x1E0;
            }
            pub mod C_OP_OrientTo2dDirection {
                pub const m_vecInput: i64 = 0x1E0;
                pub const m_flRotOffset: i64 = 0x8B8;
                pub const m_nFieldOutput: i64 = 0x8C0;
                pub const m_flSpinStrength: i64 = 0x8BC;
            }
            pub mod C_OP_QuantizeCPComponent {
                pub const m_nCPOutput: i64 = 0x360;
                pub const m_flInputValue: i64 = 0x1E8;
                pub const m_flQuantizeValue: i64 = 0x368;
                pub const m_nOutVectorField: i64 = 0x364;
            }
            pub mod C_OP_RemapDotProductToCP {
                pub const m_nInputCP1: i64 = 0x1E8;
                pub const m_nInputCP2: i64 = 0x1EC;
                pub const m_nOutputCP: i64 = 0x1F0;
                pub const m_flInputMax: i64 = 0x370;
                pub const m_flInputMin: i64 = 0x1F8;
                pub const m_flOutputMax: i64 = 0x660;
                pub const m_flOutputMin: i64 = 0x4E8;
                pub const m_nOutVectorField: i64 = 0x1F4;
            }
            pub mod C_OP_RenderDeferredLight {
                pub const m_hTexture: i64 = 0x920;
                pub const m_flSpotFoV: i64 = 0x940;
                pub const m_bUseTexture: i64 = 0x91C;
                pub const m_flAlphaScale: i64 = 0x234;
                pub const m_nAlpha2Field: i64 = 0x238;
                pub const m_flRadiusScale: i64 = 0x230;
                pub const m_vecColorScale: i64 = 0x240;
                pub const m_flStartFalloff: i64 = 0x938;
                pub const m_flLightDistance: i64 = 0x934;
                pub const m_nColorBlendType: i64 = 0x918;
                pub const m_flDistanceFalloff: i64 = 0x93C;
                pub const m_bUseAlphaTestWindow: i64 = 0x91D;
                pub const m_nAlphaTestPointField: i64 = 0x928;
                pub const m_nAlphaTestRangeField: i64 = 0x92C;
                pub const m_nHSVShiftControlPoint: i64 = 0x944;
                pub const m_nAlphaTestSharpnessField: i64 = 0x930;
            }
            pub mod C_OP_RenderMaterialProxy {
                pub const m_flAlpha: i64 = 0xAA8;
                pub const m_nProxyType: i64 = 0x234;
                pub const m_MaterialVars: i64 = 0x238;
                pub const m_vecColorScale: i64 = 0x3D0;
                pub const m_nColorBlendType: i64 = 0xC20;
                pub const m_hOverrideMaterial: i64 = 0x250;
                pub const m_nMaterialControlPoint: i64 = 0x230;
                pub const m_flMaterialOverrideEnabled: i64 = 0x258;
            }
            pub mod C_OP_RenderStandardLight {
                pub const m_flPhi: i64 = 0xF08;
                pub const m_flTheta: i64 = 0xD90;
                pub const m_bIgnoreDT: i64 = 0x1810;
                pub const m_nPriority: i64 = 0x1678;
                pub const m_nLightType: i64 = 0x230;
                pub const m_bClosedLoop: i64 = 0x1801;
                pub const m_flIntensity: i64 = 0xA98;
                pub const m_flMaxLength: i64 = 0x1808;
                pub const m_flMinLength: i64 = 0x180C;
                pub const m_lightCookie: i64 = 0x1670;
                pub const m_nMaxAllowed: i64 = 0x234;
                pub const m_bCastShadows: i64 = 0xC10;
                pub const m_bReverseOrder: i64 = 0x1800;
                pub const m_flBounceScale: i64 = 0xC18;
                pub const m_flLengthScale: i64 = 0x1818;
                pub const m_strLightStyle: i64 = 0x918;
                pub const m_vecColorScale: i64 = 0x238;
                pub const m_bDynamicBounce: i64 = 0xC11;
                pub const m_bRenderDiffuse: i64 = 0x1668;
                pub const m_nPrevPntSource: i64 = 0x1804;
                pub const m_bRenderSpecular: i64 = 0x1669;
                pub const m_flCapsuleLength: i64 = 0x17FC;
                pub const m_nColorBlendType: i64 = 0x910;
                pub const m_flLightStyleTime: i64 = 0x920;
                pub const m_nFogLightingMode: i64 = 0x167C;
                pub const m_flFogContribution: i64 = 0x1680;
                pub const m_nAttenuationStyle: i64 = 0x11F8;
                pub const m_flFalloffLinearity: i64 = 0x1200;
                pub const m_flLengthFadeInTime: i64 = 0x181C;
                pub const m_flRadiusMultiplier: i64 = 0x1080;
                pub const m_flZeroPercentFalloff: i64 = 0x14F0;
                pub const m_flFiftyPercentFalloff: i64 = 0x1378;
                pub const m_nCapsuleLightBehavior: i64 = 0x17F8;
                pub const m_flConstrainRadiusToLengthRatio: i64 = 0x1814;
            }
            pub mod C_OP_RenderVRHapticEvent {
                pub const m_nHand: i64 = 0x230;
                pub const m_flAmplitude: i64 = 0x240;
                pub const m_nOutputField: i64 = 0x238;
                pub const m_nOutputHandCP: i64 = 0x234;
            }
            pub mod C_OP_SnapshotSkinToBones {
                pub const m_flPrevPosScale: i64 = 0x1F4;
                pub const m_bTransformRadii: i64 = 0x1E1;
                pub const m_flJumpThreshold: i64 = 0x1F0;
                pub const m_bTransformNormals: i64 = 0x1E0;
                pub const m_flLifeTimeFadeEnd: i64 = 0x1EC;
                pub const m_flLifeTimeFadeStart: i64 = 0x1E8;
                pub const m_nControlPointNumber: i64 = 0x1E4;
            }
            pub mod C_OP_StopAfterCPDuration {
                pub const m_flDuration: i64 = 0x1E8;
                pub const m_bPlayEndCap: i64 = 0x361;
                pub const m_bDestroyImmediately: i64 = 0x360;
            }
            pub mod C_OP_VectorFieldSnapshot {
                pub const m_vecScale: i64 = 0x368;
                pub const m_bSetVelocity: i64 = 0xA44;
                pub const m_flGridSpacing: i64 = 0xA48;
                pub const m_nLocalSpaceCP: i64 = 0x1E8;
                pub const m_bLockToSurface: i64 = 0xA45;
                pub const m_flInterpolation: i64 = 0x1F0;
                pub const m_nAttributeToWrite: i64 = 0x1E4;
                pub const m_flBoundaryDampening: i64 = 0xA40;
                pub const m_nControlPointNumber: i64 = 0x1E0;
            }
            pub mod CParticleBindingRealPulse {

            }
            pub mod CParticleFunctionOperator {

            }
            pub mod CParticleFunctionRenderer {
                pub const VisibilityInputs: i64 = 0x1E0;
                pub const m_bCannotBeRefracted: i64 = 0x228;
            }
            pub mod CParticleSystemDefinition {
                pub const m_Children: i64 = 0xB8;
                pub const m_Emitters: i64 = 0x28;
                pub const m_nGroupID: i64 = 0x260;
                pub const m_Operators: i64 = 0x58;
                pub const m_Renderers: i64 = 0xA0;
                pub const m_hFallback: i64 = 0x2F8;
                pub const m_hSnapshot: i64 = 0x2D8;
                pub const m_Constraints: i64 = 0x88;
                pub const m_bShouldSort: i64 = 0x378;
                pub const m_Initializers: i64 = 0x40;
                pub const m_bShouldBatch: i64 = 0x358;
                pub const m_flCullRadius: i64 = 0x2E8;
                pub const m_nMinCPULevel: i64 = 0x338;
                pub const m_nMinGPULevel: i64 = 0x33C;
                pub const m_ConstantColor: i64 = 0x2A8;
                pub const m_nMaxParticles: i64 = 0x25C;
                pub const m_BoundingBoxMax: i64 = 0x270;
                pub const m_BoundingBoxMin: i64 = 0x264;
                pub const m_ConstantNormal: i64 = 0x2AC;
                pub const m_flCullFillCost: i64 = 0x2EC;
                pub const m_nMinimumFrames: i64 = 0x330;
                pub const m_ForceGenerators: i64 = 0x70;
                pub const m_bInfiniteBounds: i64 = 0x284;
                pub const m_flDepthSortBias: i64 = 0x27C;
                pub const m_hLowViolenceDef: i64 = 0x308;
                pub const m_NamedValueDomain: i64 = 0x288;
                pub const m_NamedValueLocals: i64 = 0x290;
                pub const m_flConstantRadius: i64 = 0x2B8;
                pub const m_flMaximumSimTime: i64 = 0x324;
                pub const m_flMinimumSimTime: i64 = 0x328;
                pub const m_nBehaviorVersion: i64 = 0x8;
                pub const m_nViewModelEffect: i64 = 0x35C;
                pub const m_pszTargetLayerID: i64 = 0x368;
                pub const m_flAggregateRadius: i64 = 0x354;
                pub const m_flMaxDrawDistance: i64 = 0x344;
                pub const m_flMaximumTimeStep: i64 = 0x320;
                pub const m_flMinimumTimeStep: i64 = 0x32C;
                pub const m_nCullControlPoint: i64 = 0x2F0;
                pub const m_nFallbackMaxCount: i64 = 0x300;
                pub const m_nInitialParticles: i64 = 0x258;
                pub const m_bEnableNamedValues: i64 = 0x285;
                pub const m_bScreenSpaceEffect: i64 = 0x360;
                pub const m_flConstantLifespan: i64 = 0x2C4;
                pub const m_flConstantRotation: i64 = 0x2BC;
                pub const m_flPreSimulationTime: i64 = 0x318;
                pub const m_flStartFadeDistance: i64 = 0x348;
                pub const m_PreEmissionOperators: i64 = 0x10;
                pub const m_bIsGPUParticleSystem: i64 = 0x334;
                pub const m_flMaxCreationDistance: i64 = 0x34C;
                pub const m_hReferenceReplacement: i64 = 0x310;
                pub const m_nSnapshotControlPoint: i64 = 0x2D0;
                pub const m_pszCullReplacementName: i64 = 0x2E0;
                pub const m_flConstantRotationSpeed: i64 = 0x2C0;
                pub const m_flNoDrawTimeToGoToSleep: i64 = 0x340;
                pub const m_nConstantSequenceNumber: i64 = 0x2C8;
                pub const m_nSkipRenderControlPoint: i64 = 0x370;
                pub const m_nSortOverridePositionCP: i64 = 0x280;
                pub const m_nAllowRenderControlPoint: i64 = 0x374;
                pub const m_nConstantSequenceNumber1: i64 = 0x2CC;
                pub const m_flStopSimulationAfterTime: i64 = 0x31C;
                pub const m_controlPointConfigurations: i64 = 0x3C0;
                pub const m_bShouldHitboxesFallbackToSnapshot: i64 = 0x35A;
                pub const m_nAggregationMinAvailableParticles: i64 = 0x350;
                pub const m_bShouldHitboxesFallbackToRenderBounds: i64 = 0x359;
                pub const m_nFirstMultipleOverride_BackwardCompat: i64 = 0x178;
                pub const m_bShouldHitboxesFallbackToCollisionHulls: i64 = 0x35B;
            }
            pub mod CParticleVisibilityInputs {
                pub const m_nCPin: i64 = 0x4;
                pub const m_bRightEye: i64 = 0x44;
                pub const m_flInputMax: i64 = 0x10;
                pub const m_flInputMin: i64 = 0xC;
                pub const m_bDotCPAngles: i64 = 0x2C;
                pub const m_flCameraBias: i64 = 0x0;
                pub const m_flDotInputMax: i64 = 0x28;
                pub const m_flDotInputMin: i64 = 0x24;
                pub const m_flProxyRadius: i64 = 0x8;
                pub const m_flAlphaScaleMax: i64 = 0x34;
                pub const m_flAlphaScaleMin: i64 = 0x30;
                pub const m_bDotCameraAngles: i64 = 0x2D;
                pub const m_flRadiusScaleMax: i64 = 0x3C;
                pub const m_flRadiusScaleMin: i64 = 0x38;
                pub const m_flDistanceInputMax: i64 = 0x20;
                pub const m_flDistanceInputMin: i64 = 0x1C;
                pub const m_flInputPixelVisFade: i64 = 0x14;
                pub const m_flRadiusScaleFOVBase: i64 = 0x40;
                pub const m_flNoPixelVisibilityFallback: i64 = 0x18;
            }
            pub mod CPulseCell_Value_Gradient {
                pub const m_Gradient: i64 = 0x48;
            }
            pub mod C_INIT_CreateSpiralSphere {
                pub const m_flDensity: i64 = 0x250;
                pub const m_TransformInput: i64 = 0x1E8;
                pub const m_flInitialRadius: i64 = 0x3C8;
                pub const m_bUseParticleCount: i64 = 0x830;
                pub const m_flInitialSpeedMax: i64 = 0x6B8;
                pub const m_flInitialSpeedMin: i64 = 0x540;
            }
            pub mod C_INIT_InitFromCPSnapshot {
                pub const m_bRandom: i64 = 0x204;
                pub const m_bReverse: i64 = 0x205;
                pub const m_nRandomSeed: i64 = 0x4F8;
                pub const m_nLocalSpaceCP: i64 = 0x200;
                pub const m_nAttributeToRead: i64 = 0x1F8;
                pub const m_bLocalSpaceAngles: i64 = 0x4FC;
                pub const m_nAttributeToWrite: i64 = 0x1FC;
                pub const m_strSnapshotSubset: i64 = 0x1F0;
                pub const m_nSnapShotIncrement: i64 = 0x208;
                pub const m_nControlPointNumber: i64 = 0x1E8;
                pub const m_nManualSnapshotIndex: i64 = 0x380;
            }
            pub mod C_INIT_PositionOffsetToCP {
                pub const m_bLocalCoords: i64 = 0x1F0;
                pub const m_nControlPointNumberEnd: i64 = 0x1EC;
                pub const m_nControlPointNumberStart: i64 = 0x1E8;
            }
            pub mod C_INIT_PositionWarpScalar {
                pub const m_InputValue: i64 = 0x200;
                pub const m_vecWarpMax: i64 = 0x1F4;
                pub const m_vecWarpMin: i64 = 0x1E8;
                pub const m_flPrevPosScale: i64 = 0x378;
                pub const m_nControlPointNumber: i64 = 0x380;
                pub const m_nScaleControlPointNumber: i64 = 0x37C;
            }
            pub mod C_INIT_RadiusFromCPObject {
                pub const m_nControlPoint: i64 = 0x1E8;
            }
            pub mod C_INIT_SetHitboxToClosest {
                pub const m_bUseBones: i64 = 0x948;
                pub const m_nTestType: i64 = 0x94C;
                pub const m_HitboxSetName: i64 = 0x8C8;
                pub const m_flHybridRatio: i64 = 0x950;
                pub const m_nDesiredHitbox: i64 = 0x1EC;
                pub const m_vecHitBoxScale: i64 = 0x1F0;
                pub const m_bUpdatePosition: i64 = 0xAC8;
                pub const m_nControlPointNumber: i64 = 0x1E8;
                pub const m_bUseClosestPointOnHitbox: i64 = 0x949;
            }
            pub mod C_INIT_SetRigidAttachment {
                pub const m_bLocalSpace: i64 = 0x1F4;
                pub const m_nFieldInput: i64 = 0x1EC;
                pub const m_nFieldOutput: i64 = 0x1F0;
                pub const m_nControlPointNumber: i64 = 0x1E8;
            }
            pub mod C_INIT_VelocityFromNormal {
                pub const m_bIgnoreDt: i64 = 0x1F0;
                pub const m_fSpeedMax: i64 = 0x1EC;
                pub const m_fSpeedMin: i64 = 0x1E8;
            }
            pub mod C_OP_InstantaneousEmitter {
                pub const m_nEventType: i64 = 0x4DC;
                pub const m_flStartTime: i64 = 0x360;
                pub const m_nParticlesToEmit: i64 = 0x1E8;
                pub const m_strSnapshotSubset: i64 = 0x660;
                pub const m_nMaxEmittedPerFrame: i64 = 0x658;
                pub const m_flParentParticleScale: i64 = 0x4E0;
                pub const m_nSnapshotControlPoint: i64 = 0x65C;
                pub const m_flInitFromKilledParentParticles: i64 = 0x4D8;
            }
            pub mod C_OP_LazyCullCompareFloat {
                pub const m_flCullTime: i64 = 0x4D0;
                pub const m_flComparsion1: i64 = 0x1E0;
                pub const m_flComparsion2: i64 = 0x358;
            }
            pub mod C_OP_LerpToOtherAttribute {
                pub const m_nFieldInput: i64 = 0x35C;
                pub const m_nFieldOutput: i64 = 0x360;
                pub const m_flInterpolation: i64 = 0x1E0;
                pub const m_nFieldInputFrom: i64 = 0x358;
            }
            pub mod C_OP_RemapDensityToVector {
                pub const m_flDensityMax: i64 = 0x1EC;
                pub const m_flDensityMin: i64 = 0x1E8;
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_vecOutputMax: i64 = 0x1FC;
                pub const m_vecOutputMin: i64 = 0x1F0;
                pub const m_flRadiusScale: i64 = 0x1E0;
                pub const m_bUseParentDensity: i64 = 0x208;
                pub const m_nVoxelGridResolution: i64 = 0x20C;
            }
            pub mod C_OP_RemapGravityToVector {
                pub const m_vInput1: i64 = 0x1E0;
                pub const m_nSetMethod: i64 = 0x8BC;
                pub const m_nOutputField: i64 = 0x8B8;
                pub const m_bNormalizedOutput: i64 = 0x8C0;
            }
            pub mod C_OP_RemapModelVolumetoCP {
                pub const m_nField: i64 = 0x1F8;
                pub const m_bBBoxOnly: i64 = 0x20C;
                pub const m_bCubeRoot: i64 = 0x20D;
                pub const m_nBBoxType: i64 = 0x1E8;
                pub const m_flInputMax: i64 = 0x200;
                pub const m_flInputMin: i64 = 0x1FC;
                pub const m_flOutputMax: i64 = 0x208;
                pub const m_flOutputMin: i64 = 0x204;
                pub const m_nInControlPointNumber: i64 = 0x1EC;
                pub const m_nOutControlPointNumber: i64 = 0x1F0;
                pub const m_nOutControlPointMaxNumber: i64 = 0x1F4;
            }
            pub mod C_OP_RemapScalarOnceTimed {
                pub const m_flInputMax: i64 = 0x1F0;
                pub const m_flInputMin: i64 = 0x1EC;
                pub const m_flOutputMax: i64 = 0x1F8;
                pub const m_flOutputMin: i64 = 0x1F4;
                pub const m_flRemapTime: i64 = 0x1FC;
                pub const m_nFieldInput: i64 = 0x1E4;
                pub const m_nFieldOutput: i64 = 0x1E8;
                pub const m_bProportional: i64 = 0x1E0;
            }
            pub mod C_OP_RenderPostProcessing {
                pub const m_nPriority: i64 = 0x3B0;
                pub const m_hPostTexture: i64 = 0x3A8;
                pub const m_flPostProcessStrength: i64 = 0x230;
            }
            pub mod C_OP_RenderStatusEffectTf {
                pub const m_pTextureDetail: i64 = 0x258;
                pub const m_pTextureEnvMap: i64 = 0x260;
                pub const m_pTextureNormal: i64 = 0x238;
                pub const m_pTextureColorWarp: i64 = 0x230;
                pub const m_pTextureMetalness: i64 = 0x240;
                pub const m_pTextureRoughness: i64 = 0x248;
                pub const m_pTextureSelfIllum: i64 = 0x250;
            }
            pub mod C_OP_RestartAfterDuration {
                pub const m_nCP: i64 = 0x1E8;
                pub const m_nCPField: i64 = 0x1EC;
                pub const m_bOnlyChildren: i64 = 0x1F4;
                pub const m_flDurationMax: i64 = 0x1E4;
                pub const m_flDurationMin: i64 = 0x1E0;
                pub const m_nChildGroupID: i64 = 0x1F0;
            }
            pub mod C_OP_RopeSpringConstraint {
                pub const m_flRestLength: i64 = 0x1E0;
                pub const m_flMaxDistance: i64 = 0x4D0;
                pub const m_flMinDistance: i64 = 0x358;
                pub const m_flAdjustmentScale: i64 = 0x648;
                pub const m_flInitialRestingLength: i64 = 0x650;
            }
            pub mod C_OP_SetControlPointToHMD {
                pub const m_nCP1: i64 = 0x1E8;
                pub const m_vecCP1Pos: i64 = 0x1EC;
                pub const m_bOrientToHMD: i64 = 0x1F8;
            }
            pub mod C_OP_WaterImpulseRenderer {
                pub const m_vecPos: i64 = 0x230;
                pub const m_flShape: i64 = 0xBF8;
                pub const m_flRadius: i64 = 0x908;
                pub const m_flWobble: i64 = 0xEE8;
                pub const m_nEventType: i64 = 0x1064;
                pub const m_flMagnitude: i64 = 0xA80;
                pub const m_flWindSpeed: i64 = 0xD70;
                pub const m_bIsRadialWind: i64 = 0x1060;
            }
            pub mod C_OP_WorldTraceConstraint {
                pub const m_nCP: i64 = 0x1E0;
                pub const m_nIgnoreCP: i64 = 0x280;
                pub const m_nTraceSet: i64 = 0x1F8;
                pub const m_bBrushOnly: i64 = 0x27D;
                pub const m_bSetNormal: i64 = 0x881;
                pub const m_bWorldOnly: i64 = 0x27C;
                pub const m_flMinSpeed: i64 = 0x87C;
                pub const m_flStopSpeed: i64 = 0x888;
                pub const m_vecCpOffset: i64 = 0x1E4;
                pub const m_bDecayBounce: i64 = 0x878;
                pub const m_flRetestRate: i64 = 0x288;
                pub const m_bIncludeWater: i64 = 0x27E;
                pub const m_flRadiusScale: i64 = 0x298;
                pub const m_flSlideAmount: i64 = 0x588;
                pub const m_bKillonContact: i64 = 0x879;
                pub const m_flBounceAmount: i64 = 0x410;
                pub const m_nCollisionMode: i64 = 0x1F0;
                pub const m_flRandomDirScale: i64 = 0x700;
                pub const m_flTraceTolerance: i64 = 0x28C;
                pub const m_nCollisionModeMin: i64 = 0x1F4;
                pub const m_CollisionGroupName: i64 = 0x1FC;
                pub const m_nMaxTracesPerFrame: i64 = 0x294;
                pub const m_bKillonContactBounce: i64 = 0x880;
                pub const m_flCpMovementTolerance: i64 = 0x284;
                pub const m_nEntityStickDataField: i64 = 0xA00;
                pub const m_nStickOnCollisionField: i64 = 0x884;
                pub const m_nEntityStickNormalField: i64 = 0xA04;
                pub const m_flCollisionConfirmationSpeed: i64 = 0x290;
            }
            pub mod IParticleSystemDefinition {

            }
            pub mod OutflowWithRequirements_t {
                pub const m_Connection: i64 = 0x0;
                pub const m_RequirementNodeIDs: i64 = 0x50;
                pub const m_DestinationFlowNodeID: i64 = 0x48;
                pub const m_nCursorStateBlockIndex: i64 = 0x68;
            }
            pub mod RenderProjectedMaterial_t {
                pub const m_hMaterial: i64 = 0x0;
            }
            pub mod SignatureOutflow_Continue {

            }
            pub mod CPulseCell_BaseRequirement {

            }
            pub mod CPulseCell_Value_RandomInt {

            }
            pub mod CPulse_BlackboardReference {
                pub const m_nNodeID: i64 = 0x18;
                pub const m_NodeName: i64 = 0x20;
                pub const m_BlackboardResource: i64 = 0x8;
                pub const m_hBlackboardResource: i64 = 0x0;
            }
            pub mod C_INIT_ColorLitPerParticle {
                pub const m_TintMax: i64 = 0x20C;
                pub const m_TintMin: i64 = 0x208;
                pub const m_ColorMax: i64 = 0x204;
                pub const m_ColorMin: i64 = 0x200;
                pub const m_flTintPerc: i64 = 0x210;
                pub const m_nTintBlendMode: i64 = 0x214;
                pub const m_flLightAmplification: i64 = 0x218;
            }
            pub mod C_INIT_CreateInEpitrochoid {
                pub const m_flOffset: i64 = 0x3D0;
                pub const m_bUseCount: i64 = 0x838;
                pub const m_flRadius1: i64 = 0x548;
                pub const m_flRadius2: i64 = 0x6C0;
                pub const m_nComponent1: i64 = 0x1E8;
                pub const m_nComponent2: i64 = 0x1EC;
                pub const m_TransformInput: i64 = 0x1F0;
                pub const m_bUseLocalCoords: i64 = 0x839;
                pub const m_flParticleDensity: i64 = 0x258;
                pub const m_bOffsetExistingPos: i64 = 0x83A;
            }
            pub mod C_INIT_InitFloatCollection {
                pub const m_InputValue: i64 = 0x1E8;
                pub const m_nOutputField: i64 = 0x360;
            }
            pub mod C_INIT_RandomModelSequence {
                pub const m_hModel: i64 = 0x3E8;
                pub const m_ActivityName: i64 = 0x1E8;
                pub const m_SequenceName: i64 = 0x2E8;
            }
            pub mod C_INIT_RandomRotationSpeed {

            }
            pub mod C_INIT_RemapScalarToVector {
                pub const m_flEndTime: i64 = 0x214;
                pub const m_flInputMax: i64 = 0x1F4;
                pub const m_flInputMin: i64 = 0x1F0;
                pub const m_nSetMethod: i64 = 0x218;
                pub const m_flRemapBias: i64 = 0x224;
                pub const m_flStartTime: i64 = 0x210;
                pub const m_nFieldInput: i64 = 0x1E8;
                pub const m_bLocalCoords: i64 = 0x220;
                pub const m_nFieldOutput: i64 = 0x1EC;
                pub const m_vecOutputMax: i64 = 0x204;
                pub const m_vecOutputMin: i64 = 0x1F8;
                pub const m_nControlPointNumber: i64 = 0x21C;
            }
            pub mod C_INIT_StatusEffectCitadel {
                pub const m_flSFXSScale: i64 = 0x1FC;
                pub const m_nDetailCombo: i64 = 0x218;
                pub const m_flSFXSOffsetX: i64 = 0x20C;
                pub const m_flSFXSOffsetY: i64 = 0x210;
                pub const m_flSFXSOffsetZ: i64 = 0x214;
                pub const m_flSFXSScrollX: i64 = 0x200;
                pub const m_flSFXSScrollY: i64 = 0x204;
                pub const m_flSFXSScrollZ: i64 = 0x208;
                pub const m_flSFXNormalAmount: i64 = 0x1EC;
                pub const m_flSFXSDetailScale: i64 = 0x220;
                pub const m_flSFXSUseModelUVs: i64 = 0x230;
                pub const m_flSFXSDetailAmount: i64 = 0x21C;
                pub const m_flSFXSDetailScrollX: i64 = 0x224;
                pub const m_flSFXSDetailScrollY: i64 = 0x228;
                pub const m_flSFXSDetailScrollZ: i64 = 0x22C;
                pub const m_flSFXColorWarpAmount: i64 = 0x1E8;
                pub const m_flSFXMetalnessAmount: i64 = 0x1F0;
                pub const m_flSFXRoughnessAmount: i64 = 0x1F4;
                pub const m_flSFXSelfIllumAmount: i64 = 0x1F8;
            }
            pub mod C_OP_AttractToControlPoint {
                pub const m_fForceAmount: i64 = 0x200;
                pub const m_fFalloffPower: i64 = 0x4F0;
                pub const m_TransformInput: i64 = 0x4F8;
                pub const m_bApplyMinForce: i64 = 0x6D8;
                pub const m_fForceAmountMin: i64 = 0x560;
                pub const m_fMinimumDistance: i64 = 0x378;
                pub const m_vecComponentScale: i64 = 0x1F0;
            }
            pub mod C_OP_FadeAndKillForTracers {
                pub const m_flEndAlpha: i64 = 0x1F4;
                pub const m_flStartAlpha: i64 = 0x1F0;
                pub const m_flEndFadeInTime: i64 = 0x1E4;
                pub const m_flEndFadeOutTime: i64 = 0x1EC;
                pub const m_flStartFadeInTime: i64 = 0x1E0;
                pub const m_flStartFadeOutTime: i64 = 0x1E8;
            }
            pub mod C_OP_ForceControlPointStub {
                pub const m_ControlPoint: i64 = 0x1E8;
            }
            pub mod C_OP_InheritFromPeerSystem {
                pub const m_nGroupID: i64 = 0x1EC;
                pub const m_nIncrement: i64 = 0x1E8;
                pub const m_nFieldInput: i64 = 0x1E4;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_LerpToInitialPosition {
                pub const m_flScale: i64 = 0x368;
                pub const m_vecScale: i64 = 0x4E0;
                pub const m_nCacheField: i64 = 0x360;
                pub const m_flInterpolation: i64 = 0x1E8;
                pub const m_nControlPointNumber: i64 = 0x1E0;
            }
            pub mod C_OP_MovementPlaceOnGround {
                pub const m_nLerpCP: i64 = 0xACC;
                pub const m_nRefCP1: i64 = 0xAC4;
                pub const m_nRefCP2: i64 = 0xAC8;
                pub const m_flOffset: i64 = 0x1E0;
                pub const m_nIgnoreCP: i64 = 0xAE8;
                pub const m_nTraceSet: i64 = 0xAC0;
                pub const m_bSetNormal: i64 = 0xAE0;
                pub const m_flLerpRate: i64 = 0xA3C;
                pub const m_flTolerance: i64 = 0x35C;
                pub const m_vecTraceDir: i64 = 0x360;
                pub const m_bScaleOffset: i64 = 0xAE1;
                pub const m_bIncludeWater: i64 = 0xADD;
                pub const m_flTraceOffset: i64 = 0xA38;
                pub const m_bIncludeShotHull: i64 = 0xADC;
                pub const m_flMaxTraceLength: i64 = 0x358;
                pub const m_nPreserveOffsetCP: i64 = 0xAE4;
                pub const m_CollisionGroupName: i64 = 0xA40;
                pub const m_nTraceMissBehavior: i64 = 0xAD8;
            }
            pub mod C_OP_OscillateScalarSimple {
                pub const m_Rate: i64 = 0x1E0;
                pub const m_nField: i64 = 0x1E8;
                pub const m_flOscAdd: i64 = 0x1F0;
                pub const m_Frequency: i64 = 0x1E4;
                pub const m_flOscMult: i64 = 0x1EC;
            }
            pub mod C_OP_OscillateVectorSimple {
                pub const m_Rate: i64 = 0x1E0;
                pub const m_nField: i64 = 0x1F8;
                pub const m_bOffset: i64 = 0x204;
                pub const m_flOscAdd: i64 = 0x200;
                pub const m_Frequency: i64 = 0x1EC;
                pub const m_flOscMult: i64 = 0x1FC;
            }
            pub mod C_OP_RemapExternalWindToCP {
                pub const m_nCP: i64 = 0x1E8;
                pub const m_vecScale: i64 = 0x1F0;
                pub const m_nCPOutput: i64 = 0x1EC;
                pub const m_bSetMagnitude: i64 = 0x8C8;
                pub const m_nOutVectorField: i64 = 0x8CC;
            }
            pub mod C_OP_RemapVelocityToVector {
                pub const m_flScale: i64 = 0x1E4;
                pub const m_bNormalize: i64 = 0x1E8;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_RemapVisibilityScalar {
                pub const m_flInputMax: i64 = 0x1EC;
                pub const m_flInputMin: i64 = 0x1E8;
                pub const m_flOutputMax: i64 = 0x1F4;
                pub const m_flOutputMin: i64 = 0x1F0;
                pub const m_nFieldInput: i64 = 0x1E0;
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_flRadiusScale: i64 = 0x1F8;
            }
            pub mod C_OP_SetChildControlPoints {
                pub const m_bReverse: i64 = 0x368;
                pub const m_nOrientation: i64 = 0x36C;
                pub const m_nChildGroupID: i64 = 0x1E0;
                pub const m_bSetOrientation: i64 = 0x369;
                pub const m_nFirstSourcePoint: i64 = 0x1F0;
                pub const m_nNumControlPoints: i64 = 0x1E8;
                pub const m_nFirstControlPoint: i64 = 0x1E4;
            }
            pub mod C_OP_SetControlPointToHand {
                pub const m_nCP1: i64 = 0x1E8;
                pub const m_nHand: i64 = 0x1EC;
                pub const m_vecCP1Pos: i64 = 0x1F0;
                pub const m_bOrientToHand: i64 = 0x1FC;
            }
            pub mod C_OP_VelocityMatchingForce {
                pub const m_bUseAABB: i64 = 0x1F0;
                pub const m_flDirScale: i64 = 0x1E0;
                pub const m_flSpdScale: i64 = 0x1E4;
                pub const m_nCPBroadcast: i64 = 0x1F4;
                pub const m_flFacingStrength: i64 = 0x1EC;
                pub const m_flNeighborDistance: i64 = 0x1E8;
            }
            pub mod ParticlePreviewBodyGroup_t {
                pub const m_nValue: i64 = 0x8;
                pub const m_bodyGroupName: i64 = 0x0;
            }
            pub mod PulseNodeDynamicOutflows_t {
                pub const m_Outflows: i64 = 0x0;
            }
            pub mod PulseSelectorOutflowList_t {
                pub const m_Outflows: i64 = 0x0;
            }
            pub mod VecInputMaterialVariable_t {
                pub const m_vecInput: i64 = 0x8;
                pub const m_strVariable: i64 = 0x0;
            }
            pub mod CParticleFunctionConstraint {

            }
            pub mod CPulseCell_Inflow_GraphHook {
                pub const m_HookName: i64 = 0x80;
            }
            pub mod C_INIT_CreateFromPlaneCache {
                pub const m_bUseNormal: i64 = 0x201;
                pub const m_vecOffsetMax: i64 = 0x1F4;
                pub const m_vecOffsetMin: i64 = 0x1E8;
            }
            pub mod C_INIT_CreateSequentialPath {
                pub const m_bLoop: i64 = 0x1F0;
                pub const m_bCPPairs: i64 = 0x1F1;
                pub const m_PathParams: i64 = 0x200;
                pub const m_bSaveOffset: i64 = 0x1F2;
                pub const m_fMaxDistance: i64 = 0x1E8;
                pub const m_flNumToAssign: i64 = 0x1EC;
            }
            pub mod C_INIT_InitFromParentKilled {
                pub const m_nEventType: i64 = 0x1EC;
                pub const m_nAttributeToCopy: i64 = 0x1E8;
            }
            pub mod C_INIT_InitialVelocityNoise {
                pub const m_flOffset: i64 = 0x8D8;
                pub const m_bIgnoreDt: i64 = 0x1B58;
                pub const m_vecAbsVal: i64 = 0x1E8;
                pub const m_flNoiseScale: i64 = 0x1800;
                pub const m_vecAbsValInv: i64 = 0x1F4;
                pub const m_vecOffsetLoc: i64 = 0x200;
                pub const m_vecOutputMax: i64 = 0x1128;
                pub const m_vecOutputMin: i64 = 0xA50;
                pub const m_TransformInput: i64 = 0x1AF0;
                pub const m_flNoiseScaleLoc: i64 = 0x1978;
            }
            pub mod C_INIT_LifespanFromVelocity {
                pub const m_nTraceSet: i64 = 0x288;
                pub const m_nMaxPlanes: i64 = 0x200;
                pub const m_bIncludeWater: i64 = 0x298;
                pub const m_flTraceOffset: i64 = 0x1F4;
                pub const m_flMaxTraceLength: i64 = 0x1F8;
                pub const m_flTraceTolerance: i64 = 0x1FC;
                pub const m_vecComponentScale: i64 = 0x1E8;
                pub const m_CollisionGroupName: i64 = 0x208;
            }
            pub mod C_INIT_OffsetVectorToVector {
                pub const m_nFieldInput: i64 = 0x1E8;
                pub const m_nFieldOutput: i64 = 0x1EC;
                pub const m_vecOutputMax: i64 = 0x1FC;
                pub const m_vecOutputMin: i64 = 0x1F0;
                pub const m_randomnessParameters: i64 = 0x208;
            }
            pub mod C_INIT_RandomSecondSequence {
                pub const m_nSequenceMax: i64 = 0x1EC;
                pub const m_nSequenceMin: i64 = 0x1E8;
            }
            pub mod C_INIT_VelocityRadialRandom {
                pub const m_vecFwd: i64 = 0x8C8;
                pub const m_fSpeedMax: i64 = 0x1118;
                pub const m_fSpeedMin: i64 = 0xFA0;
                pub const m_vecPosition: i64 = 0x1F0;
                pub const m_bIgnoreDelta: i64 = 0x129D;
                pub const m_bPerParticleCenter: i64 = 0x1E8;
                pub const m_nControlPointNumber: i64 = 0x1EC;
                pub const m_vecLocalCoordinateSystemSpeedScale: i64 = 0x1290;
            }
            pub mod C_OP_ColorInterpolateRandom {
                pub const m_bEaseInOut: i64 = 0x218;
                pub const m_ColorFadeMax: i64 = 0x1FC;
                pub const m_ColorFadeMin: i64 = 0x1E0;
                pub const m_nFieldOutput: i64 = 0x214;
                pub const m_flFadeEndTime: i64 = 0x210;
                pub const m_flFadeStartTime: i64 = 0x20C;
            }
            pub mod C_OP_DistanceBetweenCPsToCP {
                pub const m_bLOS: i64 = 0x214;
                pub const m_nEndCP: i64 = 0x1EC;
                pub const m_bSetOnce: i64 = 0x1F8;
                pub const m_nStartCP: i64 = 0x1E8;
                pub const m_nOutputCP: i64 = 0x1F0;
                pub const m_nTraceSet: i64 = 0x298;
                pub const m_flInputMax: i64 = 0x200;
                pub const m_flInputMin: i64 = 0x1FC;
                pub const m_flLOSScale: i64 = 0x210;
                pub const m_nSetParent: i64 = 0x29C;
                pub const m_flOutputMax: i64 = 0x208;
                pub const m_flOutputMin: i64 = 0x204;
                pub const m_nOutputCPField: i64 = 0x1F4;
                pub const m_flMaxTraceLength: i64 = 0x20C;
                pub const m_CollisionGroupName: i64 = 0x215;
            }
            pub mod C_OP_LocalAccelerationForce {
                pub const m_nCP: i64 = 0x1F0;
                pub const m_nScaleCP: i64 = 0x1F4;
                pub const m_vecAccel: i64 = 0x1F8;
            }
            pub mod C_OP_MaintainSequentialPath {
                pub const m_bLoop: i64 = 0x64C;
                pub const m_PathParams: i64 = 0x650;
                pub const m_flTolerance: i64 = 0x648;
                pub const m_fMaxDistance: i64 = 0x1E0;
                pub const m_flNumToAssign: i64 = 0x358;
                pub const m_bUseParticleCount: i64 = 0x64D;
                pub const m_flCohesionStrength: i64 = 0x4D0;
            }
            pub mod C_OP_MovementMaintainOffset {
                pub const m_nCP: i64 = 0x1EC;
                pub const m_vecOffset: i64 = 0x1E0;
                pub const m_bRadiusScale: i64 = 0x1F0;
            }
            pub mod C_OP_PlayEndCapWhenFinished {
                pub const m_bIncludeChildren: i64 = 0x1E9;
                pub const m_bFireOnEmissionEnd: i64 = 0x1E8;
            }
            pub mod C_OP_RampScalarLinearSimple {
                pub const m_Rate: i64 = 0x1E0;
                pub const m_nField: i64 = 0x210;
                pub const m_flEndTime: i64 = 0x1E8;
                pub const m_flStartTime: i64 = 0x1E4;
            }
            pub mod C_OP_RampScalarSplineSimple {
                pub const m_Rate: i64 = 0x1E0;
                pub const m_nField: i64 = 0x210;
                pub const m_bEaseOut: i64 = 0x214;
                pub const m_flEndTime: i64 = 0x1E8;
                pub const m_flStartTime: i64 = 0x1E4;
            }
            pub mod C_OP_RemapVectorToRotations {
                pub const m_vecInput: i64 = 0x1E0;
                pub const m_vecRotation: i64 = 0x8B8;
            }
            pub mod C_OP_WorldCollideConstraint {

            }
            pub mod CParticleFunctionInitializer {
                pub const m_nAssociatedEmitterIndex: i64 = 0x1E0;
            }
            pub mod CParticleFunctionPreEmission {
                pub const m_bRunOnce: i64 = 0x1E0;
            }
            pub mod CPulseCell_Step_PublicOutput {
                pub const m_OutputIndex: i64 = 0x48;
            }
            pub mod CPulseCell_Value_RandomFloat {

            }
            pub mod CPulseCell_WaitForObservable {
                pub const m_OnTrue: i64 = 0x168;
                pub const m_Condition: i64 = 0xD8;
            }
            pub mod C_INIT_CheckParticleForWater {
                pub const m_flRadius: i64 = 0x1E8;
                pub const m_nSetMethod: i64 = 0x4E0;
                pub const m_nFieldOutput: i64 = 0x360;
                pub const m_flOutputRemap: i64 = 0x368;
            }
            pub mod C_INIT_CreateOnModelAtHeight {
                pub const m_bForceZ: i64 = 0x1E9;
                pub const m_bUseBones: i64 = 0x1E8;
                pub const m_nBiasType: i64 = 0x1120;
                pub const m_nHeightCP: i64 = 0x1F0;
                pub const m_bLocalCoords: i64 = 0x1124;
                pub const m_HitboxSetName: i64 = 0x1126;
                pub const m_vecHitBoxScale: i64 = 0x370;
                pub const m_bUseWaterHeight: i64 = 0x1F4;
                pub const m_flDesiredHeight: i64 = 0x1F8;
                pub const m_vecDirectionBias: i64 = 0xA48;
                pub const m_flMaxBoneVelocity: i64 = 0x1320;
                pub const m_bPreferMovingBoxes: i64 = 0x1125;
                pub const m_nControlPointNumber: i64 = 0x1EC;
                pub const m_flHitboxVelocityScale: i64 = 0x11A8;
            }
            pub mod C_INIT_CreateParticleImpulse {
                pub const m_InputRadius: i64 = 0x1E8;
                pub const m_nImpulseType: i64 = 0x658;
                pub const m_InputMagnitude: i64 = 0x360;
                pub const m_InputFalloffExp: i64 = 0x4E0;
                pub const m_nFalloffFunction: i64 = 0x4D8;
            }
            pub mod C_INIT_PositionPlaceOnGround {
                pub const m_flOffset: i64 = 0x1E8;
                pub const m_nIgnoreCP: i64 = 0xC60;
                pub const m_nTraceSet: i64 = 0xC30;
                pub const m_bSetNormal: i64 = 0xC4D;
                pub const m_nAttribute: i64 = 0xC48;
                pub const m_vecTraceDir: i64 = 0x4D8;
                pub const m_bSetPXYZOnly: i64 = 0xC4C;
                pub const m_bIncludeWater: i64 = 0xC44;
                pub const m_bOffsetonColOnly: i64 = 0xC54;
                pub const m_flMaxTraceLength: i64 = 0x360;
                pub const m_nPreserveOffsetCP: i64 = 0xC5C;
                pub const m_CollisionGroupName: i64 = 0xBB0;
                pub const m_nTraceMissBehavior: i64 = 0xC40;
                pub const m_flOffsetByRadiusFactor: i64 = 0xC58;
                pub const m_nGroundNormalAttribute: i64 = 0xC50;
            }
            pub mod C_INIT_RandomVectorComponent {
                pub const m_flMax: i64 = 0x1EC;
                pub const m_flMin: i64 = 0x1E8;
                pub const m_nComponent: i64 = 0x1F4;
                pub const m_nFieldOutput: i64 = 0x1F0;
            }
            pub mod C_OP_ConstrainDistanceToPath {
                pub const m_nFieldScale: i64 = 0x234;
                pub const m_fMinDistance: i64 = 0x1E0;
                pub const m_flTravelTime: i64 = 0x230;
                pub const m_nManualTField: i64 = 0x238;
                pub const m_PathParameters: i64 = 0x1F0;
                pub const m_flMaxDistance0: i64 = 0x1E4;
                pub const m_flMaxDistance1: i64 = 0x1EC;
                pub const m_flMaxDistanceMid: i64 = 0x1E8;
            }
            pub mod C_OP_MovementRigidAttachToCP {
                pub const m_nFieldInput: i64 = 0x1EC;
                pub const m_bOffsetLocal: i64 = 0x1F4;
                pub const m_nFieldOutput: i64 = 0x1F0;
                pub const m_nScaleCPField: i64 = 0x1E8;
                pub const m_nScaleControlPoint: i64 = 0x1E4;
                pub const m_nControlPointNumber: i64 = 0x1E0;
            }
            pub mod C_OP_RemapBoundingVolumetoCP {
                pub const m_flInputMax: i64 = 0x1F0;
                pub const m_flInputMin: i64 = 0x1EC;
                pub const m_flOutputMax: i64 = 0x1F8;
                pub const m_flOutputMin: i64 = 0x1F4;
                pub const m_nOutControlPointNumber: i64 = 0x1E8;
            }
            pub mod C_OP_RemapCPVelocityToVector {
                pub const m_flScale: i64 = 0x1E8;
                pub const m_bNormalize: i64 = 0x1EC;
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_nControlPoint: i64 = 0x1E0;
            }
            pub mod C_OP_RemapDotProductToScalar {
                pub const m_nInputCP1: i64 = 0x1E0;
                pub const m_nInputCP2: i64 = 0x1E4;
                pub const m_flInputMax: i64 = 0x1F0;
                pub const m_flInputMin: i64 = 0x1EC;
                pub const m_nSetMethod: i64 = 0x200;
                pub const m_flOutputMax: i64 = 0x1F8;
                pub const m_flOutputMin: i64 = 0x1F4;
                pub const m_bActiveRange: i64 = 0x204;
                pub const m_nFieldOutput: i64 = 0x1E8;
                pub const m_bUseParticleNormal: i64 = 0x205;
                pub const m_bUseParticleVelocity: i64 = 0x1FC;
            }
            pub mod C_OP_RenderVolumetricEmitter {
                pub const m_nType: i64 = 0x238;
                pub const m_vecPos: i64 = 0x248;
                pub const m_flSpeed: i64 = 0x16D0;
                pub const m_flRadius: i64 = 0x1848;
                pub const m_flDensity: i64 = 0x19C0;
                pub const m_flFalloff: i64 = 0x2118;
                pub const m_nEventType: i64 = 0x240;
                pub const m_flMagnitude: i64 = 0x1CB0;
                pub const m_vecVelocity: i64 = 0x920;
                pub const m_flKillRadius: i64 = 0x1E28;
                pub const m_flTemperature: i64 = 0x1B38;
                pub const m_nCreationType: i64 = 0x23C;
                pub const m_vPrevPosition: i64 = 0xFF8;
                pub const m_strChannelType: i64 = 0x230;
                pub const m_flKillDensityScale: i64 = 0x1FA0;
            }
            pub mod C_OP_SetControlPointRotation {
                pub const m_nCP: i64 = 0xA38;
                pub const m_nLocalCP: i64 = 0xA3C;
                pub const m_flRotRate: i64 = 0x8C0;
                pub const m_vecRotAxis: i64 = 0x1E8;
            }
            pub mod C_OP_SetControlPointToCenter {
                pub const m_nCP1: i64 = 0x1E8;
                pub const m_vecCP1Pos: i64 = 0x1EC;
                pub const m_nSetParent: i64 = 0x1FC;
                pub const m_bUseAvgParticlePos: i64 = 0x1F8;
            }
            pub mod C_OP_SetControlPointToPlayer {
                pub const m_nCP1: i64 = 0x1E8;
                pub const m_nPosition: i64 = 0x1FC;
                pub const m_nRadiusCP: i64 = 0x200;
                pub const m_vecCP1Pos: i64 = 0x1EC;
                pub const m_bOrientToEyes: i64 = 0x1F8;
                pub const m_nRadiusCPField: i64 = 0x204;
            }
            pub mod C_OP_SetPerChildControlPoint {
                pub const m_nChildGroupID: i64 = 0x1E0;
                pub const m_bSetOrientation: i64 = 0x4E0;
                pub const m_nFirstSourcePoint: i64 = 0x368;
                pub const m_nNumControlPoints: i64 = 0x1E8;
                pub const m_nOrientationField: i64 = 0x4E4;
                pub const m_nFirstControlPoint: i64 = 0x1E4;
                pub const m_nParticleIncrement: i64 = 0x1F0;
                pub const m_bNumBasedOnParticleCount: i64 = 0x4E8;
            }
            pub mod C_OP_ShapeMatchingConstraint {
                pub const m_flShapeRestorationTime: i64 = 0x1E0;
            }
            pub mod FloatInputMaterialVariable_t {
                pub const m_flInput: i64 = 0x8;
                pub const m_strVariable: i64 = 0x0;
            }
            pub mod ParticleControlPointDriver_t {
                pub const m_angOffset: i64 = 0x2C;
                pub const m_vecOffset: i64 = 0x20;
                pub const m_entityName: i64 = 0x38;
                pub const m_iAttachType: i64 = 0x10;
                pub const m_iControlPoint: i64 = 0x0;
                pub const m_attachmentName: i64 = 0x18;
            }
            pub mod CPulseCell_BaseYieldingInflow {
                pub const m_BaseFlow_WhileActive: i64 = 0x90;
                pub const m_BaseFlow_OnAfterCancel: i64 = 0x48;
            }
            pub mod CPulseCell_BooleanSwitchState {
                pub const m_WhenTrue: i64 = 0x168;
                pub const m_Condition: i64 = 0xD8;
                pub const m_WhenFalse: i64 = 0x1B0;
            }
            pub mod CPulseCell_IsRequirementValid {

            }
            pub mod C_INIT_CreateSequentialPathV2 {
                pub const m_bLoop: i64 = 0x4D8;
                pub const m_bCPPairs: i64 = 0x4D9;
                pub const m_PathParams: i64 = 0x4E0;
                pub const m_bSaveOffset: i64 = 0x4DA;
                pub const m_fMaxDistance: i64 = 0x1E8;
                pub const m_flNumToAssign: i64 = 0x360;
            }
            pub mod C_INIT_DistanceToNeighborCull {
                pub const m_flModify: i64 = 0x4E8;
                pub const m_flDistance: i64 = 0x1E8;
                pub const m_nSetMethod: i64 = 0x660;
                pub const m_bUseNeighbor: i64 = 0x664;
                pub const m_nFieldModify: i64 = 0x4E0;
                pub const m_bIncludeRadii: i64 = 0x360;
                pub const m_flLifespanOverlap: i64 = 0x368;
            }
            pub mod C_INIT_RemapQAnglesToRotation {
                pub const m_TransformInput: i64 = 0x1E8;
            }
            pub mod C_INIT_RemapTransformToVector {
                pub const m_bOffset: i64 = 0x2FC;
                pub const m_flEndTime: i64 = 0x2F4;
                pub const m_vInputMax: i64 = 0x1F8;
                pub const m_vInputMin: i64 = 0x1EC;
                pub const m_nSetMethod: i64 = 0x2F8;
                pub const m_vOutputMax: i64 = 0x210;
                pub const m_vOutputMin: i64 = 0x204;
                pub const m_bAccelerate: i64 = 0x2FD;
                pub const m_flRemapBias: i64 = 0x300;
                pub const m_flStartTime: i64 = 0x2F0;
                pub const m_nFieldOutput: i64 = 0x1E8;
                pub const m_TransformInput: i64 = 0x220;
                pub const m_LocalSpaceTransform: i64 = 0x288;
            }
            pub mod C_OP_CalculateVectorAttribute {
                pub const m_vStartValue: i64 = 0x1E0;
                pub const m_nFieldInput1: i64 = 0x1EC;
                pub const m_nFieldInput2: i64 = 0x1F4;
                pub const m_nFieldOutput: i64 = 0x22C;
                pub const m_flInputScale1: i64 = 0x1F0;
                pub const m_flInputScale2: i64 = 0x1F8;
                pub const m_vFinalOutputScale: i64 = 0x230;
                pub const m_nControlPointInput1: i64 = 0x1FC;
                pub const m_nControlPointInput2: i64 = 0x214;
                pub const m_flControlPointScale1: i64 = 0x210;
                pub const m_flControlPointScale2: i64 = 0x228;
            }
            pub mod C_OP_ExternalGameImpulseForce {
                pub const m_bRopes: i64 = 0x368;
                pub const m_bParticles: i64 = 0x36B;
                pub const m_bExplosions: i64 = 0x36A;
                pub const m_bRopesZOnly: i64 = 0x369;
                pub const m_flForceScale: i64 = 0x1F0;
            }
            pub mod C_OP_MovementLoopInsideSphere {
                pub const m_nCP: i64 = 0x1E0;
                pub const m_vecScale: i64 = 0x360;
                pub const m_flDistance: i64 = 0x1E8;
                pub const m_nDistSqrAttr: i64 = 0xA38;
            }
            pub mod C_OP_ReinitializeScalarEndCap {
                pub const m_flOutputMax: i64 = 0x1E8;
                pub const m_flOutputMin: i64 = 0x1E4;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_RemapTransformToVelocity {
                pub const m_TransformInput: i64 = 0x1E0;
            }
            pub mod C_OP_SetControlPointPositions {
                pub const m_nCP1: i64 = 0x1EC;
                pub const m_nCP2: i64 = 0x1F0;
                pub const m_nCP3: i64 = 0x1F4;
                pub const m_nCP4: i64 = 0x1F8;
                pub const m_bOrient: i64 = 0x1E9;
                pub const m_bSetOnce: i64 = 0x1EA;
                pub const m_vecCP1Pos: i64 = 0x1FC;
                pub const m_vecCP2Pos: i64 = 0x208;
                pub const m_vecCP3Pos: i64 = 0x214;
                pub const m_vecCP4Pos: i64 = 0x220;
                pub const m_nHeadLocation: i64 = 0x22C;
                pub const m_bUseWorldLocation: i64 = 0x1E8;
            }
            pub mod C_OP_SnapshotRigidSkinToBones {
                pub const m_bTransformRadii: i64 = 0x1E1;
                pub const m_bTransformNormals: i64 = 0x1E0;
                pub const m_nControlPointNumber: i64 = 0x1E4;
            }
            pub mod C_OP_SpringToVectorConstraint {
                pub const m_flRestLength: i64 = 0x1E0;
                pub const m_flMaxDistance: i64 = 0x4D0;
                pub const m_flMinDistance: i64 = 0x358;
                pub const m_flRestingLength: i64 = 0x648;
                pub const m_vecAnchorVector: i64 = 0x7C0;
            }
            pub mod CPulseCell_Inflow_EventHandler {
                pub const m_EventName: i64 = 0x80;
            }
            pub mod CPulseCell_Outflow_CycleRandom {
                pub const m_Outputs: i64 = 0x48;
            }
            pub mod C_INIT_RandomNamedModelElement {
                pub const m_names: i64 = 0x1F0;
                pub const m_hModel: i64 = 0x1E8;
                pub const m_bLinear: i64 = 0x209;
                pub const m_bShuffle: i64 = 0x208;
                pub const m_nFieldOutput: i64 = 0x20C;
                pub const m_bModelFromRenderer: i64 = 0x20A;
            }
            pub mod C_OP_DirectionBetweenVecsToVec {
                pub const m_vecPoint1: i64 = 0x1E8;
                pub const m_vecPoint2: i64 = 0x8C0;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_DistanceBetweenTransforms {
                pub const m_bLOS: i64 = 0x924;
                pub const m_nTraceSet: i64 = 0x920;
                pub const m_flInputMax: i64 = 0x430;
                pub const m_flInputMin: i64 = 0x2B8;
                pub const m_flLOSScale: i64 = 0x89C;
                pub const m_nSetMethod: i64 = 0x928;
                pub const m_flOutputMax: i64 = 0x720;
                pub const m_flOutputMin: i64 = 0x5A8;
                pub const m_TransformEnd: i64 = 0x250;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_TransformStart: i64 = 0x1E8;
                pub const m_flMaxTraceLength: i64 = 0x898;
                pub const m_CollisionGroupName: i64 = 0x8A0;
            }
            pub mod C_OP_LockToSavedSequentialPath {
                pub const m_bCPPairs: i64 = 0x1EC;
                pub const m_flFadeEnd: i64 = 0x1E8;
                pub const m_PathParams: i64 = 0x1F0;
                pub const m_flFadeStart: i64 = 0x1E4;
            }
            pub mod C_OP_PointVectorAtNextParticle {
                pub const m_bPrevious: i64 = 0x360;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_flInterpolation: i64 = 0x1E8;
            }
            pub mod C_OP_RenderStatusEffectCitadel {
                pub const m_pTextureDetail: i64 = 0x258;
                pub const m_pTextureNormal: i64 = 0x238;
                pub const m_pTextureColorWarp: i64 = 0x230;
                pub const m_pTextureMetalness: i64 = 0x240;
                pub const m_pTextureRoughness: i64 = 0x248;
                pub const m_pTextureSelfIllum: i64 = 0x250;
            }
            pub mod C_OP_RepeatedTriggerChildGroup {
                pub const m_flClusterSize: i64 = 0x368;
                pub const m_nChildGroupID: i64 = 0x1E8;
                pub const m_bLimitChildCount: i64 = 0x658;
                pub const m_flClusterCooldown: i64 = 0x4E0;
                pub const m_flClusterRefireTime: i64 = 0x1F0;
            }
            pub mod C_OP_ScreenSpaceDistanceToEdge {
                pub const m_nSetMethod: i64 = 0x4D8;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_flOutputRemap: i64 = 0x360;
                pub const m_flMaxDistFromEdge: i64 = 0x1E8;
            }
            pub mod C_OP_SelectivelyEnableChildren {
                pub const m_nFirstChild: i64 = 0x360;
                pub const m_nChildGroupID: i64 = 0x1E8;
                pub const m_bPlayEndcapOnStop: i64 = 0x650;
                pub const m_bDestroyImmediately: i64 = 0x651;
                pub const m_nNumChildrenToEnable: i64 = 0x4D8;
            }
            pub mod CPulseCell_Outflow_CycleOrdered {
                pub const m_Outputs: i64 = 0x48;
            }
            pub mod C_INIT_InitialRepulsionVelocity {
                pub const m_bInherit: i64 = 0x291;
                pub const m_nChildCP: i64 = 0x294;
                pub const m_nTraceSet: i64 = 0x268;
                pub const m_bTranslate: i64 = 0x289;
                pub const m_bPerParticle: i64 = 0x288;
                pub const m_vecOutputMax: i64 = 0x278;
                pub const m_vecOutputMin: i64 = 0x26C;
                pub const m_bProportional: i64 = 0x28A;
                pub const m_flTraceLength: i64 = 0x28C;
                pub const m_nChildGroupID: i64 = 0x298;
                pub const m_bPerParticleTR: i64 = 0x290;
                pub const m_CollisionGroupName: i64 = 0x1E8;
                pub const m_nControlPointNumber: i64 = 0x284;
            }
            pub mod C_INIT_InitialSequenceFromModel {
                pub const m_flInputMax: i64 = 0x1F8;
                pub const m_flInputMin: i64 = 0x1F4;
                pub const m_nSetMethod: i64 = 0x204;
                pub const m_flOutputMax: i64 = 0x200;
                pub const m_flOutputMin: i64 = 0x1FC;
                pub const m_nFieldOutput: i64 = 0x1EC;
                pub const m_nFieldOutputAnim: i64 = 0x1F0;
                pub const m_nControlPointNumber: i64 = 0x1E8;
            }
            pub mod C_INIT_RandomNamedModelBodyPart {

            }
            pub mod C_INIT_RandomNamedModelSequence {

            }
            pub mod C_OP_CollideWithParentParticles {
                pub const m_flRadiusScale: i64 = 0x358;
                pub const m_flParentRadiusScale: i64 = 0x1E0;
            }
            pub mod C_OP_DifferencePreviousParticle {
                pub const m_flInputMax: i64 = 0x1EC;
                pub const m_flInputMin: i64 = 0x1E8;
                pub const m_nSetMethod: i64 = 0x1F8;
                pub const m_flOutputMax: i64 = 0x1F4;
                pub const m_flOutputMin: i64 = 0x1F0;
                pub const m_nFieldInput: i64 = 0x1E0;
                pub const m_bActiveRange: i64 = 0x1FC;
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_bSetPreviousParticle: i64 = 0x1FD;
            }
            pub mod C_OP_InheritFromParentParticles {
                pub const m_flScale: i64 = 0x1E0;
                pub const m_nIncrement: i64 = 0x1E8;
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_bRandomDistribution: i64 = 0x1EC;
            }
            pub mod C_OP_LightningSnapshotGenerator {
                pub const m_flOffset: i64 = 0x370;
                pub const m_flUVScale: i64 = 0x7D8;
                pub const m_nCPEndPnt: i64 = 0x1F0;
                pub const m_flSegments: i64 = 0x1F8;
                pub const m_flUVOffset: i64 = 0x950;
                pub const m_flRadiusEnd: i64 = 0x13B0;
                pub const m_flSplitRate: i64 = 0xAC8;
                pub const m_nCPSnapshot: i64 = 0x1E8;
                pub const m_nCPStartPnt: i64 = 0x1EC;
                pub const m_flRecalcRate: i64 = 0x660;
                pub const m_flBranchTwist: i64 = 0x10B8;
                pub const m_flOffsetDecay: i64 = 0x4E8;
                pub const m_flRadiusStart: i64 = 0x1238;
                pub const m_flDedicatedPool: i64 = 0x1528;
                pub const m_nBranchBehavior: i64 = 0x1230;
                pub const m_bScaleBranchOffset: i64 = 0xF38;
                pub const m_flBranchOffsetScale: i64 = 0xF40;
                pub const m_bScaleBranchDistance: i64 = 0xDB8;
                pub const m_flBranchDistanceScale: i64 = 0xDC0;
                pub const m_flRecursionSplitScale: i64 = 0xC40;
            }
            pub mod C_OP_RemapDirectionToCPToVector {
                pub const m_nCP: i64 = 0x1E0;
                pub const m_flScale: i64 = 0x1E8;
                pub const m_bNormalize: i64 = 0x1FC;
                pub const m_flOffsetRot: i64 = 0x1EC;
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_vecOffsetAxis: i64 = 0x1F0;
                pub const m_nFieldStrength: i64 = 0x200;
            }
            pub mod C_OP_RemapParticleCountToScalar {
                pub const m_nInputMax: i64 = 0x360;
                pub const m_nInputMin: i64 = 0x1E8;
                pub const m_nSetMethod: i64 = 0x7CC;
                pub const m_flOutputMax: i64 = 0x650;
                pub const m_flOutputMin: i64 = 0x4D8;
                pub const m_bActiveRange: i64 = 0x7C8;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_RenderClientPhysicsImpulse {
                pub const m_flRadius: i64 = 0x230;
                pub const m_flMagnitude: i64 = 0x3A8;
                pub const m_nSimIdFilter: i64 = 0x520;
            }
            pub mod C_OP_RenderScreenVelocityRotate {
                pub const m_flForwardDegrees: i64 = 0x234;
                pub const m_flRotateRateDegrees: i64 = 0x230;
            }
            pub mod C_OP_SetControlPointOrientation {
                pub const m_nCP: i64 = 0x1EC;
                pub const m_bSetOnce: i64 = 0x1EB;
                pub const m_bRandomize: i64 = 0x1EA;
                pub const m_vecRotation: i64 = 0x1F4;
                pub const m_vecRotationB: i64 = 0x200;
                pub const m_nHeadLocation: i64 = 0x1F0;
                pub const m_flInterpolation: i64 = 0x210;
                pub const m_bUseWorldLocation: i64 = 0x1E8;
            }
            pub mod C_OP_SetControlPointsToParticle {
                pub const m_bReverse: i64 = 0x1F0;
                pub const m_nSetParent: i64 = 0x1F8;
                pub const m_nChildGroupID: i64 = 0x1E0;
                pub const m_bSetOrientation: i64 = 0x1F1;
                pub const m_nOrientationMode: i64 = 0x1F4;
                pub const m_nFirstSourcePoint: i64 = 0x1EC;
                pub const m_nNumControlPoints: i64 = 0x1E8;
                pub const m_nFirstControlPoint: i64 = 0x1E4;
            }
            pub mod PointDefinitionWithTimeValues_t {
                pub const m_flTimeDuration: i64 = 0x14;
            }
            pub mod CPulseCell_Inflow_BaseEntrypoint {
                pub const m_EntryChunk: i64 = 0x48;
                pub const m_RegisterMap: i64 = 0x50;
            }
            pub mod CPulseCell_Outflow_CycleShuffled {
                pub const m_Outputs: i64 = 0x48;
            }
            pub mod CPulseCell_WaitForCursorsWithTag {
                pub const m_bTagSelfWhenComplete: i64 = 0x128;
                pub const m_nDesiredKillPriority: i64 = 0x12C;
            }
            pub mod CRandomNumberGeneratorParameters {
                pub const m_nSeed: i64 = 0x4;
                pub const m_bDistributeEvenly: i64 = 0x0;
            }
            pub mod C_INIT_CreateFromParentParticles {
                pub const m_bSubFrame: i64 = 0x1F8;
                pub const m_flIncrement: i64 = 0x1EC;
                pub const m_nRandomSeed: i64 = 0x1F4;
                pub const m_flVelocityScale: i64 = 0x1E8;
                pub const m_bSetRopeSegmentID: i64 = 0x1F9;
                pub const m_bRandomDistribution: i64 = 0x1F0;
            }
            pub mod C_INIT_InitialVelocityFromHitbox {
                pub const m_bUseBones: i64 = 0x274;
                pub const m_HitboxSetName: i64 = 0x1F4;
                pub const m_flVelocityMax: i64 = 0x1EC;
                pub const m_flVelocityMin: i64 = 0x1E8;
                pub const m_nControlPointNumber: i64 = 0x1F0;
            }
            pub mod C_INIT_RandomNamedModelMeshGroup {

            }
            pub mod C_OP_ChooseRandomChildrenInGroup {
                pub const m_nChildGroupID: i64 = 0x1E8;
                pub const m_flNumberOfChildren: i64 = 0x1F0;
            }
            pub mod C_OP_DriveCPFromGlobalSoundFloat {
                pub const m_FieldName: i64 = 0x210;
                pub const m_StackName: i64 = 0x200;
                pub const m_flInputMax: i64 = 0x1F4;
                pub const m_flInputMin: i64 = 0x1F0;
                pub const m_flOutputMax: i64 = 0x1FC;
                pub const m_flOutputMin: i64 = 0x1F8;
                pub const m_OperatorName: i64 = 0x208;
                pub const m_nOutputField: i64 = 0x1EC;
                pub const m_nOutputControlPoint: i64 = 0x1E8;
            }
            pub mod C_OP_ForceBasedOnDistanceToPlane {
                pub const m_flMaxDist: i64 = 0x200;
                pub const m_flMinDist: i64 = 0x1F0;
                pub const m_flExponent: i64 = 0x220;
                pub const m_vecPlaneNormal: i64 = 0x210;
                pub const m_vecForceAtMaxDist: i64 = 0x204;
                pub const m_vecForceAtMinDist: i64 = 0x1F4;
                pub const m_nControlPointNumber: i64 = 0x21C;
            }
            pub mod C_OP_LockToSavedSequentialPathV2 {
                pub const m_bCPPairs: i64 = 0x1E8;
                pub const m_flFadeEnd: i64 = 0x1E4;
                pub const m_PathParams: i64 = 0x1F0;
                pub const m_flFadeStart: i64 = 0x1E0;
            }
            pub mod C_OP_PercentageBetweenTransforms {
                pub const m_flInputMax: i64 = 0x1E8;
                pub const m_flInputMin: i64 = 0x1E4;
                pub const m_nSetMethod: i64 = 0x2C8;
                pub const m_flOutputMax: i64 = 0x1F0;
                pub const m_flOutputMin: i64 = 0x1EC;
                pub const m_TransformEnd: i64 = 0x260;
                pub const m_bActiveRange: i64 = 0x2CC;
                pub const m_bRadialCheck: i64 = 0x2CD;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_TransformStart: i64 = 0x1F8;
            }
            pub mod C_OP_ReadFromNeighboringParticle {
                pub const m_nIncrement: i64 = 0x1E8;
                pub const m_nFieldInput: i64 = 0x1E0;
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_DistanceCheck: i64 = 0x1F0;
                pub const m_flInterpolation: i64 = 0x368;
            }
            pub mod C_OP_RemapAverageHitboxSpeedtoCP {
                pub const m_nField: i64 = 0x1F0;
                pub const m_flInputMax: i64 = 0x370;
                pub const m_flInputMin: i64 = 0x1F8;
                pub const m_flOutputMax: i64 = 0x660;
                pub const m_flOutputMin: i64 = 0x4E8;
                pub const m_HitboxSetName: i64 = 0xEB8;
                pub const m_nHitboxDataType: i64 = 0x1F4;
                pub const m_nInControlPointNumber: i64 = 0x1E8;
                pub const m_vecComparisonVelocity: i64 = 0x7E0;
                pub const m_nOutControlPointNumber: i64 = 0x1EC;
                pub const m_nHeightControlPointNumber: i64 = 0x7D8;
            }
            pub mod C_OP_RemapAverageScalarValuetoCP {
                pub const m_nField: i64 = 0x370;
                pub const m_nExpression: i64 = 0x1E8;
                pub const m_flOutputRemap: i64 = 0x378;
                pub const m_flDecimalPlaces: i64 = 0x1F0;
                pub const m_nOutVectorField: i64 = 0x36C;
                pub const m_nOutControlPointNumber: i64 = 0x368;
            }
            pub mod C_OP_RenderSimpleModelCollection {
                pub const m_hModel: i64 = 0x238;
                pub const m_modelInput: i64 = 0x240;
                pub const m_fDrawFilter: i64 = 0x420;
                pub const m_bCenterOffset: i64 = 0x230;
                pub const m_bAcceptsDecals: i64 = 0x41A;
                pub const m_fSizeCullScale: i64 = 0x2A0;
                pub const m_bDisableShadows: i64 = 0x418;
                pub const m_bDisableMotionBlur: i64 = 0x419;
                pub const m_nAngularVelocityField: i64 = 0x598;
            }
            pub mod C_OP_ScreenSpacePositionOfTarget {
                pub const m_bOututBehindness: i64 = 0x8B8;
                pub const m_nBehindSetMethod: i64 = 0xA38;
                pub const m_vecTargetPosition: i64 = 0x1E0;
                pub const m_nBehindFieldOutput: i64 = 0x8BC;
                pub const m_flBehindOutputRemap: i64 = 0x8C0;
            }
            pub mod C_OP_SetCPOrientationToDirection {
                pub const m_nInputControlPoint: i64 = 0x1E0;
                pub const m_nOutputControlPoint: i64 = 0x1E4;
            }
            pub mod C_OP_SetCPOrientationToPointAtCP {
                pub const m_nInputCP: i64 = 0x1E8;
                pub const m_nOutputCP: i64 = 0x1EC;
                pub const m_bPointAway: i64 = 0x36A;
                pub const m_b2DOrientation: i64 = 0x368;
                pub const m_flInterpolation: i64 = 0x1F0;
                pub const m_bAvoidSingularity: i64 = 0x369;
            }
            pub mod C_OP_SetControlPointFieldToWater {
                pub const m_nDestCP: i64 = 0x1EC;
                pub const m_nCPField: i64 = 0x1F0;
                pub const m_nSourceCP: i64 = 0x1E8;
            }
            pub mod C_OP_SetControlPointToCPVelocity {
                pub const m_nCPField: i64 = 0x1F8;
                pub const m_nCPInput: i64 = 0x1E8;
                pub const m_bNormalize: i64 = 0x1F0;
                pub const m_nCPOutputMag: i64 = 0x1F4;
                pub const m_nCPOutputVel: i64 = 0x1EC;
                pub const m_vecComparisonVelocity: i64 = 0x200;
            }
            pub mod CPulseCell_InlineNodeSkipSelector {
                pub const m_bAnd: i64 = 0x4C;
                pub const m_FailOutflow: i64 = 0x68;
                pub const m_PassOutflow: i64 = 0x50;
                pub const m_nFlowNodeID: i64 = 0x48;
            }
            pub mod CPulseCell_LimitCount__Criteria_t {
                pub const m_bLimitCountPasses: i64 = 0x0;
            }
            pub mod C_INIT_InheritFromParentParticles {
                pub const m_flScale: i64 = 0x1E8;
                pub const m_nIncrement: i64 = 0x1F0;
                pub const m_nRandomSeed: i64 = 0x1F8;
                pub const m_nFieldOutput: i64 = 0x1EC;
                pub const m_bRandomDistribution: i64 = 0x1F4;
            }
            pub mod C_INIT_RandomAlphaWindowThreshold {
                pub const m_flMax: i64 = 0x1EC;
                pub const m_flMin: i64 = 0x1E8;
                pub const m_flExponent: i64 = 0x1F0;
            }
            pub mod C_INIT_RemapParticleCountToScalar {
                pub const m_bWrap: i64 = 0x20A;
                pub const m_bInvert: i64 = 0x209;
                pub const m_nInputMax: i64 = 0x1F0;
                pub const m_nInputMin: i64 = 0x1EC;
                pub const m_nSetMethod: i64 = 0x204;
                pub const m_flOutputMax: i64 = 0x200;
                pub const m_flOutputMin: i64 = 0x1FC;
                pub const m_flRemapBias: i64 = 0x20C;
                pub const m_bActiveRange: i64 = 0x208;
                pub const m_nFieldOutput: i64 = 0x1E8;
                pub const m_nScaleControlPoint: i64 = 0x1F4;
                pub const m_nScaleControlPointField: i64 = 0x1F8;
            }
            pub mod C_OP_CreateParticleSystemRenderer {
                pub const m_vecCPs: i64 = 0x240;
                pub const m_hEffect: i64 = 0x230;
                pub const m_nEventType: i64 = 0x238;
                pub const m_AggregationPos: i64 = 0x258;
                pub const m_szParticleConfig: i64 = 0x250;
            }
            pub mod C_OP_InheritFromParentParticlesV2 {
                pub const m_flScale: i64 = 0x1E0;
                pub const m_bReverse: i64 = 0x4DA;
                pub const m_bSubSample: i64 = 0x4D8;
                pub const m_nIncrement: i64 = 0x360;
                pub const m_nFieldOutput: i64 = 0x358;
                pub const m_flInterpolation: i64 = 0x4E0;
                pub const m_bRandomDistribution: i64 = 0x4D9;
                pub const m_nMissingParentBehavior: i64 = 0x4DC;
            }
            pub mod C_OP_RemapNamedModelElementEndCap {
                pub const m_hModel: i64 = 0x1E0;
                pub const m_inNames: i64 = 0x1E8;
                pub const m_outNames: i64 = 0x200;
                pub const m_nFieldInput: i64 = 0x234;
                pub const m_nFieldOutput: i64 = 0x238;
                pub const m_fallbackNames: i64 = 0x218;
                pub const m_bModelFromRenderer: i64 = 0x230;
            }
            pub mod C_OP_RemapVectorComponentToScalar {
                pub const m_nComponent: i64 = 0x1E8;
                pub const m_nFieldInput: i64 = 0x1E0;
                pub const m_nFieldOutput: i64 = 0x1E4;
            }
            pub mod C_OP_SetControlPointToImpactPoint {
                pub const m_nCPIn: i64 = 0x1EC;
                pub const m_nCPOut: i64 = 0x1E8;
                pub const m_flOffset: i64 = 0x374;
                pub const m_nTraceSet: i64 = 0x404;
                pub const m_vecTraceDir: i64 = 0x378;
                pub const m_flUpdateRate: i64 = 0x1F0;
                pub const m_bIncludeWater: i64 = 0x40A;
                pub const m_flStartOffset: i64 = 0x370;
                pub const m_flTraceLength: i64 = 0x1F8;
                pub const m_bSetToEndpoint: i64 = 0x408;
                pub const m_CollisionGroupName: i64 = 0x384;
                pub const m_bTraceToClosestSurface: i64 = 0x409;
            }
            pub mod CParticleCollectionBindingInstance {

            }
            pub mod CParticleMassCalculationParameters {
                pub const m_flScale: i64 = 0x2F8;
                pub const m_flRadius: i64 = 0x8;
                pub const m_nMassMode: i64 = 0x0;
                pub const m_flNominalRadius: i64 = 0x180;
            }
            pub mod CPulseCell_BaseLerp__CursorState_t {
                pub const m_EndTime: i64 = 0x4;
                pub const m_StartTime: i64 = 0x0;
            }
            pub mod CPulseCell_Inflow_EntOutputHandler {
                pub const m_SourceEntity: i64 = 0x80;
                pub const m_SourceOutput: i64 = 0x90;
                pub const m_ExpectedParamType: i64 = 0xA0;
            }
            pub mod CPulseCell_PickBestOutflowSelector {
                pub const m_nCheckType: i64 = 0x48;
                pub const m_OutflowList: i64 = 0x50;
            }
            pub mod CPulseCell_Step_CallExternalMethod {
                pub const m_MethodName: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0x108;
                pub const m_ExpectedArgs: i64 = 0xF0;
                pub const m_nAsyncCallMode: i64 = 0x100;
                pub const m_nBlackboardIndex: i64 = 0xE8;
            }
            pub mod C_INIT_CreateWithinSphereTransform {
                pub const m_fSpeedMax: i64 = 0xDA0;
                pub const m_fSpeedMin: i64 = 0xC28;
                pub const m_fRadiusMax: i64 = 0x360;
                pub const m_fRadiusMin: i64 = 0x1E8;
                pub const m_bLocalCoords: i64 = 0xF1C;
                pub const m_nFieldOutput: i64 = 0x1CD0;
                pub const m_fSpeedRandExp: i64 = 0xF18;
                pub const m_TransformInput: i64 = 0xBC0;
                pub const m_nFieldVelocity: i64 = 0x1CD4;
                pub const m_vecDistanceBias: i64 = 0x4D8;
                pub const m_vecDistanceBiasAbs: i64 = 0xBB0;
                pub const m_LocalCoordinateSystemSpeedMax: i64 = 0x15F8;
                pub const m_LocalCoordinateSystemSpeedMin: i64 = 0xF20;
            }
            pub mod C_INIT_InitFromVectorFieldSnapshot {
                pub const m_vecScale: i64 = 0x1F8;
                pub const m_nLocalSpaceCP: i64 = 0x1EC;
                pub const m_nWeightUpdateCP: i64 = 0x1F0;
                pub const m_nControlPointNumber: i64 = 0x1E8;
                pub const m_bUseVerticalVelocity: i64 = 0x1F4;
            }
            pub mod C_INIT_ScreenSpacePositionOfTarget {
                pub const m_bOututBehindness: i64 = 0x8C0;
                pub const m_vecTargetPosition: i64 = 0x1E8;
                pub const m_nBehindFieldOutput: i64 = 0x8C4;
                pub const m_flBehindOutputRemap: i64 = 0x8C8;
            }
            pub mod C_OP_ModelSurfaceSnapshotGenerator {
                pub const m_bSetUV: i64 = 0x833;
                pub const m_bSetUp: i64 = 0x831;
                pub const m_bSetNormal: i64 = 0x830;
                pub const m_flUSpacing: i64 = 0x3C8;
                pub const m_flVSpacing: i64 = 0x540;
                pub const m_modelInput: i64 = 0x1F0;
                pub const m_bSetGravity: i64 = 0x832;
                pub const m_nCPSnapshot: i64 = 0x1E8;
                pub const m_flRecalcRate: i64 = 0x250;
                pub const m_flSurfaceOffset: i64 = 0x6B8;
            }
            pub mod C_OP_RemapNamedModelBodyPartEndCap {

            }
            pub mod C_OP_RemapNamedModelSequenceEndCap {

            }
            pub mod C_OP_ScreenSpaceRotateTowardTarget {
                pub const m_nSetMethod: i64 = 0xA30;
                pub const m_flOutputRemap: i64 = 0x8B8;
                pub const m_vecTargetPosition: i64 = 0x1E0;
                pub const m_flScreenEdgeAlignmentDistance: i64 = 0xA38;
            }
            pub mod C_OP_SetControlPointToWaterSurface {
                pub const m_nDestCP: i64 = 0x1EC;
                pub const m_nFlowCP: i64 = 0x1F0;
                pub const m_nActiveCP: i64 = 0x1F4;
                pub const m_nSourceCP: i64 = 0x1E8;
                pub const m_flRetestRate: i64 = 0x200;
                pub const m_nActiveCPField: i64 = 0x1F8;
                pub const m_bAdaptiveThreshold: i64 = 0x378;
            }
            pub mod C_OP_SetRandomControlPointPosition {
                pub const m_nCP1: i64 = 0x1EC;
                pub const m_bOrient: i64 = 0x1E9;
                pub const m_vecCPMaxPos: i64 = 0x37C;
                pub const m_vecCPMinPos: i64 = 0x370;
                pub const m_nHeadLocation: i64 = 0x1F0;
                pub const m_flReRandomRate: i64 = 0x1F8;
                pub const m_flInterpolation: i64 = 0x388;
                pub const m_bUseWorldLocation: i64 = 0x1E8;
            }
            pub mod C_OP_SetSingleControlPointPosition {
                pub const m_nCP1: i64 = 0x1EC;
                pub const m_bSetOnce: i64 = 0x1E8;
                pub const m_vecCP1Pos: i64 = 0x1F0;
                pub const m_transformInput: i64 = 0x8C8;
            }
            pub mod C_INIT_CreateWithinCapsuleTransform {
                pub const m_fHeight: i64 = 0x4D8;
                pub const m_fSpeedMax: i64 = 0x830;
                pub const m_fSpeedMin: i64 = 0x6B8;
                pub const m_fRadiusMax: i64 = 0x360;
                pub const m_fRadiusMin: i64 = 0x1E8;
                pub const m_nFieldOutput: i64 = 0x1760;
                pub const m_fSpeedRandExp: i64 = 0x9A8;
                pub const m_TransformInput: i64 = 0x650;
                pub const m_nFieldVelocity: i64 = 0x1764;
                pub const m_LocalCoordinateSystemSpeedMax: i64 = 0x1088;
                pub const m_LocalCoordinateSystemSpeedMin: i64 = 0x9B0;
            }
            pub mod C_INIT_RemapInitialVisibilityScalar {
                pub const m_flInputMax: i64 = 0x1F4;
                pub const m_flInputMin: i64 = 0x1F0;
                pub const m_flOutputMax: i64 = 0x1FC;
                pub const m_flOutputMin: i64 = 0x1F8;
                pub const m_nFieldOutput: i64 = 0x1EC;
            }
            pub mod C_OP_CPOffsetToPercentageBetweenCPs {
                pub const m_nEndCP: i64 = 0x1F0;
                pub const m_nInputCP: i64 = 0x1FC;
                pub const m_nOuputCP: i64 = 0x1F8;
                pub const m_nStartCP: i64 = 0x1EC;
                pub const m_nOffsetCP: i64 = 0x1F4;
                pub const m_vecOffset: i64 = 0x204;
                pub const m_flInputMax: i64 = 0x1E4;
                pub const m_flInputMin: i64 = 0x1E0;
                pub const m_flInputBias: i64 = 0x1E8;
                pub const m_bRadialCheck: i64 = 0x200;
                pub const m_bScaleOffset: i64 = 0x201;
            }
            pub mod C_OP_ConnectParentParticleToNearest {
                pub const m_bUseRadius: i64 = 0x1E8;
                pub const m_flRadiusScale: i64 = 0x1F0;
                pub const m_nFirstControlPoint: i64 = 0x1E0;
                pub const m_flParentRadiusScale: i64 = 0x368;
                pub const m_nSecondControlPoint: i64 = 0x1E4;
            }
            pub mod C_OP_CylindricalDistanceToTransform {
                pub const m_bCapsule: i64 = 0x89E;
                pub const m_bAdditive: i64 = 0x89D;
                pub const m_flInputMax: i64 = 0x360;
                pub const m_flInputMin: i64 = 0x1E8;
                pub const m_nSetMethod: i64 = 0x898;
                pub const m_flOutputMax: i64 = 0x650;
                pub const m_flOutputMin: i64 = 0x4D8;
                pub const m_TransformEnd: i64 = 0x830;
                pub const m_bActiveRange: i64 = 0x89C;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_TransformStart: i64 = 0x7C8;
            }
            pub mod C_OP_PinRopeSegmentParticleToParent {
                pub const m_flInterpolation: i64 = 0x360;
                pub const m_nParticleNumber: i64 = 0x1E8;
                pub const m_nParticleSelection: i64 = 0x1E0;
            }
            pub mod C_OP_RemapDistanceToLineSegmentBase {
                pub const m_nCP0: i64 = 0x1E0;
                pub const m_nCP1: i64 = 0x1E4;
                pub const m_bInfiniteLine: i64 = 0x1F0;
                pub const m_flMaxInputValue: i64 = 0x1EC;
                pub const m_flMinInputValue: i64 = 0x1E8;
            }
            pub mod C_OP_RemapNamedModelMeshGroupEndCap {

            }
            pub mod C_OP_RemapTransformOrientationToYaw {
                pub const m_flRotOffset: i64 = 0x24C;
                pub const m_nFieldOutput: i64 = 0x248;
                pub const m_TransformInput: i64 = 0x1E0;
                pub const m_flSpinStrength: i64 = 0x250;
            }
            pub mod C_OP_SetAttributeToScalarExpression {
                pub const m_flInput1: i64 = 0x1E8;
                pub const m_flInput2: i64 = 0x360;
                pub const m_nSetMethod: i64 = 0x654;
                pub const m_nExpression: i64 = 0x1E0;
                pub const m_nOutputField: i64 = 0x650;
                pub const m_flOutputRemap: i64 = 0x4D8;
            }
            pub mod C_OP_SetCPOrientationToGroundNormal {
                pub const m_nInputCP: i64 = 0x274;
                pub const m_nOutputCP: i64 = 0x278;
                pub const m_nTraceSet: i64 = 0x270;
                pub const m_flTolerance: i64 = 0x1E8;
                pub const m_flInterpRate: i64 = 0x1E0;
                pub const m_bIncludeWater: i64 = 0x288;
                pub const m_flTraceOffset: i64 = 0x1EC;
                pub const m_flMaxTraceLength: i64 = 0x1E4;
                pub const m_CollisionGroupName: i64 = 0x1F0;
            }
            pub mod C_OP_SetControlPointFromObjectScale {
                pub const m_nCPInput: i64 = 0x1E8;
                pub const m_nCPOutput: i64 = 0x1EC;
            }
            pub mod ParticleControlPointConfiguration_t {
                pub const m_name: i64 = 0x0;
                pub const m_drivers: i64 = 0x8;
                pub const m_previewState: i64 = 0x20;
            }
            pub mod CPulseCell_Timeline__TimelineEvent_t {
                pub const m_EventOutflow: i64 = 0x8;
                pub const m_flTimeFromPrevious: i64 = 0x0;
            }
            pub mod CPulseCell_WaitForCursorsWithTagBase {
                pub const m_WaitComplete: i64 = 0xE0;
                pub const m_nCursorsAllowedToWait: i64 = 0xD8;
            }
            pub mod C_OP_ControlPointToRadialScreenSpace {
                pub const m_nCPIn: i64 = 0x1E8;
                pub const m_nCPOut: i64 = 0x1F8;
                pub const m_vecCP1Pos: i64 = 0x1EC;
                pub const m_nCPOutField: i64 = 0x1FC;
                pub const m_nCPSSPosOut: i64 = 0x200;
            }
            pub mod C_OP_RemapNamedModelElementOnceTimed {
                pub const m_hModel: i64 = 0x1E0;
                pub const m_inNames: i64 = 0x1E8;
                pub const m_outNames: i64 = 0x200;
                pub const m_flRemapTime: i64 = 0x23C;
                pub const m_nFieldInput: i64 = 0x234;
                pub const m_nFieldOutput: i64 = 0x238;
                pub const m_bProportional: i64 = 0x231;
                pub const m_fallbackNames: i64 = 0x218;
                pub const m_bModelFromRenderer: i64 = 0x230;
            }
            pub mod C_OP_SetParentControlPointsToChildCP {
                pub const m_nChildGroupID: i64 = 0x1E8;
                pub const m_bSetOrientation: i64 = 0x1F8;
                pub const m_nFirstSourcePoint: i64 = 0x1F4;
                pub const m_nNumControlPoints: i64 = 0x1F0;
                pub const m_nChildControlPoint: i64 = 0x1EC;
            }
            pub mod C_INIT_RemapNamedModelElementToScalar {
                pub const m_names: i64 = 0x1F0;
                pub const m_hModel: i64 = 0x1E8;
                pub const m_values: i64 = 0x208;
                pub const m_nSetMethod: i64 = 0x228;
                pub const m_nFieldInput: i64 = 0x220;
                pub const m_nFieldOutput: i64 = 0x224;
                pub const m_bModelFromRenderer: i64 = 0x22C;
            }
            pub mod C_INIT_SetAttributeToScalarExpression {
                pub const m_flInput1: i64 = 0x1F0;
                pub const m_flInput2: i64 = 0x368;
                pub const m_nSetMethod: i64 = 0x65C;
                pub const m_nExpression: i64 = 0x1E8;
                pub const m_nOutputField: i64 = 0x658;
                pub const m_flOutputRemap: i64 = 0x4E0;
            }
            pub mod C_OP_MovementRotateParticleAroundAxis {
                pub const m_flRotRate: i64 = 0x8B8;
                pub const m_vecRotAxis: i64 = 0x1E0;
                pub const m_bLocalSpace: i64 = 0xA98;
                pub const m_TransformInput: i64 = 0xA30;
            }
            pub mod C_OP_RemapNamedModelBodyPartOnceTimed {

            }
            pub mod C_OP_RemapNamedModelSequenceOnceTimed {

            }
            pub mod C_OP_RemapParticleCountOnScalarEndCap {
                pub const m_nInputMax: i64 = 0x1E8;
                pub const m_nInputMin: i64 = 0x1E4;
                pub const m_bBackwards: i64 = 0x1F4;
                pub const m_nSetMethod: i64 = 0x1F8;
                pub const m_flOutputMax: i64 = 0x1F0;
                pub const m_flOutputMin: i64 = 0x1EC;
                pub const m_nFieldOutput: i64 = 0x1E0;
            }
            pub mod C_OP_RemapTransformVisibilityToScalar {
                pub const m_flRadius: i64 = 0x264;
                pub const m_flInputMax: i64 = 0x258;
                pub const m_flInputMin: i64 = 0x254;
                pub const m_nSetMethod: i64 = 0x1E0;
                pub const m_flOutputMax: i64 = 0x260;
                pub const m_flOutputMin: i64 = 0x25C;
                pub const m_nFieldOutput: i64 = 0x250;
                pub const m_TransformInput: i64 = 0x1E8;
            }
            pub mod C_OP_RemapTransformVisibilityToVector {
                pub const m_flRadius: i64 = 0x274;
                pub const m_flInputMax: i64 = 0x258;
                pub const m_flInputMin: i64 = 0x254;
                pub const m_nSetMethod: i64 = 0x1E0;
                pub const m_nFieldOutput: i64 = 0x250;
                pub const m_vecOutputMax: i64 = 0x268;
                pub const m_vecOutputMin: i64 = 0x25C;
                pub const m_TransformInput: i64 = 0x1E8;
            }
            pub mod C_OP_SetControlPointsToModelParticles {
                pub const m_bSkin: i64 = 0x2EC;
                pub const m_bAttachment: i64 = 0x2ED;
                pub const m_HitboxSetName: i64 = 0x1E0;
                pub const m_AttachmentName: i64 = 0x260;
                pub const m_nFirstSourcePoint: i64 = 0x2E8;
                pub const m_nNumControlPoints: i64 = 0x2E4;
                pub const m_nFirstControlPoint: i64 = 0x2E0;
            }
            pub mod CPulseCell_LimitCount__InstanceState_t {
                pub const m_nCurrentCount: i64 = 0x0;
            }
            pub mod C_INIT_RemapNamedModelBodyPartToScalar {

            }
            pub mod C_INIT_RemapNamedModelSequenceToScalar {

            }
            pub mod C_OP_PercentageBetweenTransformLerpCPs {
                pub const m_flInputMax: i64 = 0x1E8;
                pub const m_flInputMin: i64 = 0x1E4;
                pub const m_nSetMethod: i64 = 0x2D0;
                pub const m_TransformEnd: i64 = 0x258;
                pub const m_bActiveRange: i64 = 0x2D4;
                pub const m_bRadialCheck: i64 = 0x2D5;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_nOutputEndCP: i64 = 0x2C8;
                pub const m_TransformStart: i64 = 0x1F0;
                pub const m_nOutputStartCP: i64 = 0x2C0;
                pub const m_nOutputEndField: i64 = 0x2CC;
                pub const m_nOutputStartField: i64 = 0x2C4;
            }
            pub mod C_OP_PercentageBetweenTransformsVector {
                pub const m_flInputMax: i64 = 0x1E8;
                pub const m_flInputMin: i64 = 0x1E4;
                pub const m_nSetMethod: i64 = 0x2D8;
                pub const m_TransformEnd: i64 = 0x270;
                pub const m_bActiveRange: i64 = 0x2DC;
                pub const m_bRadialCheck: i64 = 0x2DD;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_vecOutputMax: i64 = 0x1F8;
                pub const m_vecOutputMin: i64 = 0x1EC;
                pub const m_TransformStart: i64 = 0x208;
            }
            pub mod C_OP_RemapNamedModelMeshGroupOnceTimed {

            }
            pub mod C_OP_SetControlPointToVectorExpression {
                pub const m_flLerp: i64 = 0xFA0;
                pub const m_vInput1: i64 = 0x1F0;
                pub const m_vInput2: i64 = 0x8C8;
                pub const m_nOutputCP: i64 = 0x1EC;
                pub const m_nExpression: i64 = 0x1E8;
                pub const m_bNormalizedOutput: i64 = 0x1118;
            }
            pub mod CPulseCell_IntervalTimer__CursorState_t {
                pub const m_EndTime: i64 = 0x4;
                pub const m_StartTime: i64 = 0x0;
                pub const m_flWaitInterval: i64 = 0x8;
                pub const m_flWaitIntervalHigh: i64 = 0xC;
                pub const m_bCompleteOnNextWake: i64 = 0x10;
            }
            pub mod C_INIT_RemapNamedModelMeshGroupToScalar {

            }
            pub mod C_OP_MovementMoveAlongSkinnedCPSnapshot {
                pub const m_flTValue: i64 = 0x368;
                pub const m_bSetNormal: i64 = 0x1E8;
                pub const m_bSetRadius: i64 = 0x1E9;
                pub const m_flInterpolation: i64 = 0x1F0;
                pub const m_nControlPointNumber: i64 = 0x1E0;
                pub const m_nSnapshotControlPointNumber: i64 = 0x1E4;
            }
            pub mod C_OP_RemapControlPointDirectionToVector {
                pub const m_flScale: i64 = 0x1E4;
                pub const m_nFieldOutput: i64 = 0x1E0;
                pub const m_nControlPointNumber: i64 = 0x1E8;
            }
            pub mod C_OP_RemapDistanceToLineSegmentToScalar {
                pub const m_nFieldOutput: i64 = 0x1F8;
                pub const m_flMaxOutputValue: i64 = 0x200;
                pub const m_flMinOutputValue: i64 = 0x1FC;
            }
            pub mod C_OP_RemapDistanceToLineSegmentToVector {
                pub const m_nFieldOutput: i64 = 0x1F8;
                pub const m_vMaxOutputValue: i64 = 0x208;
                pub const m_vMinOutputValue: i64 = 0x1FC;
            }
            pub mod C_INIT_InitSkinnedPositionFromCPSnapshot {
                pub const m_bRigid: i64 = 0x1F8;
                pub const m_bRandom: i64 = 0x1F0;
                pub const m_bIgnoreDt: i64 = 0x1FA;
                pub const m_bCopyAlpha: i64 = 0x395;
                pub const m_bCopyColor: i64 = 0x394;
                pub const m_bSetNormal: i64 = 0x1F9;
                pub const m_bSetRadius: i64 = 0x396;
                pub const m_nIndexType: i64 = 0x204;
                pub const m_flIncrement: i64 = 0x380;
                pub const m_flReadIndex: i64 = 0x208;
                pub const m_nRandomSeed: i64 = 0x1F4;
                pub const m_flBoneVelocity: i64 = 0x38C;
                pub const m_flBoneVelocityMax: i64 = 0x390;
                pub const m_nFullLoopIncrement: i64 = 0x384;
                pub const m_flMaxNormalVelocity: i64 = 0x200;
                pub const m_flMinNormalVelocity: i64 = 0x1FC;
                pub const m_nControlPointNumber: i64 = 0x1EC;
                pub const m_nSnapShotStartPoint: i64 = 0x388;
                pub const m_nSnapshotControlPointNumber: i64 = 0x1E8;
            }
            pub mod C_OP_SetFloatAttributeToVectorExpression {
                pub const m_vInput1: i64 = 0x1E8;
                pub const m_vInput2: i64 = 0x8C0;
                pub const m_nSetMethod: i64 = 0x1114;
                pub const m_nExpression: i64 = 0x1E0;
                pub const m_nOutputField: i64 = 0x1110;
                pub const m_flOutputRemap: i64 = 0xF98;
            }
            pub mod CPulseCell_IsRequirementValid__Criteria_t {
                pub const m_bIsValid: i64 = 0x0;
            }
            pub mod C_OP_ConstrainDistanceToUserSpecifiedPath {
                pub const m_pointList: i64 = 0x1F0;
                pub const m_bLoopedPath: i64 = 0x1EC;
                pub const m_flTimeScale: i64 = 0x1E8;
                pub const m_fMinDistance: i64 = 0x1E0;
                pub const m_flMaxDistance: i64 = 0x1E4;
            }
            pub mod C_OP_MultiSegmentDisplaySnapshotGenerator {
                pub const m_flValue: i64 = 0x200;
                pub const m_flRadius: i64 = 0x12B8;
                pub const m_flSpacing: i64 = 0x1430;
                pub const m_nSegCount: i64 = 0x1EC;
                pub const m_flMaxCount: i64 = 0x1720;
                pub const m_flMinCount: i64 = 0x15A8;
                pub const m_nInputType: i64 = 0x1F0;
                pub const m_nCPSnapshot: i64 = 0x1E8;
                pub const m_vecColorLit: i64 = 0xBE0;
                pub const m_bPrependEmpty: i64 = 0x1898;
                pub const m_flScollOffset: i64 = 0x378;
                pub const m_vecColorUnlit: i64 = 0x508;
                pub const m_SpecialCharList: i64 = 0x4F0;
                pub const m_strDefaultString: i64 = 0x1F8;
                pub const m_flDigitsAfterDecimal: i64 = 0x18A0;
            }
            pub mod C_OP_RemapTransformOrientationToRotations {
                pub const m_bUseQuat: i64 = 0x254;
                pub const m_vecRotation: i64 = 0x248;
                pub const m_bWriteNormal: i64 = 0x255;
                pub const m_TransformInput: i64 = 0x1E0;
            }
            pub mod C_OP_SetPerChildControlPointFromAttribute {
                pub const m_nCPField: i64 = 0x1FC;
                pub const m_nChildGroupID: i64 = 0x1E0;
                pub const m_nAttributeToRead: i64 = 0x1F8;
                pub const m_nFirstSourcePoint: i64 = 0x1F0;
                pub const m_nNumControlPoints: i64 = 0x1E8;
                pub const m_nFirstControlPoint: i64 = 0x1E4;
                pub const m_nParticleIncrement: i64 = 0x1EC;
                pub const m_bNumBasedOnParticleCount: i64 = 0x1F4;
            }
            pub mod C_OP_SetVectorAttributeToVectorExpression {
                pub const m_flLerp: i64 = 0xF98;
                pub const m_vInput1: i64 = 0x1E8;
                pub const m_vInput2: i64 = 0x8C0;
                pub const m_nSetMethod: i64 = 0x1114;
                pub const m_nExpression: i64 = 0x1E0;
                pub const m_nOutputField: i64 = 0x1110;
                pub const m_bNormalizedOutput: i64 = 0x1118;
            }
            pub mod C_INIT_SetFloatAttributeToVectorExpression {
                pub const m_vInput1: i64 = 0x1F0;
                pub const m_vInput2: i64 = 0x8C8;
                pub const m_nSetMethod: i64 = 0x111C;
                pub const m_nExpression: i64 = 0x1E8;
                pub const m_nOutputField: i64 = 0x1118;
                pub const m_flOutputRemap: i64 = 0xFA0;
            }
            pub mod C_OP_EnableChildrenFromParentParticleCount {
                pub const m_nFirstChild: i64 = 0x1EC;
                pub const m_nChildGroupID: i64 = 0x1E8;
                pub const m_bDisableChildren: i64 = 0x368;
                pub const m_bPlayEndcapOnStop: i64 = 0x369;
                pub const m_bDestroyImmediately: i64 = 0x36A;
                pub const m_nNumChildrenToEnable: i64 = 0x1F0;
            }
            pub mod C_OP_MovementSkinnedPositionFromCPSnapshot {
                pub const m_bRandom: i64 = 0x1E8;
                pub const m_bSetNormal: i64 = 0x1F0;
                pub const m_bSetRadius: i64 = 0x1F1;
                pub const m_nIndexType: i64 = 0x1F4;
                pub const m_flIncrement: i64 = 0x370;
                pub const m_flReadIndex: i64 = 0x1F8;
                pub const m_nRandomSeed: i64 = 0x1EC;
                pub const m_flInterpolation: i64 = 0x7D8;
                pub const m_nFullLoopIncrement: i64 = 0x4E8;
                pub const m_nControlPointNumber: i64 = 0x1E4;
                pub const m_nSnapShotStartPoint: i64 = 0x660;
                pub const m_nSnapshotControlPointNumber: i64 = 0x1E0;
            }
            pub mod C_OP_RemapCrossProductOfTwoVectorsToVector {
                pub const m_InputVec1: i64 = 0x1E0;
                pub const m_InputVec2: i64 = 0x8B8;
                pub const m_bNormalize: i64 = 0xF94;
                pub const m_nFieldOutput: i64 = 0xF90;
            }
            pub mod C_OP_RemapDensityGradientToVectorAttribute {
                pub const m_nFieldOutput: i64 = 0x1E4;
                pub const m_flRadiusScale: i64 = 0x1E0;
            }
            pub mod C_INIT_RemapTransformOrientationToRotations {
                pub const m_bUseQuat: i64 = 0x25C;
                pub const m_vecRotation: i64 = 0x250;
                pub const m_bWriteNormal: i64 = 0x25D;
                pub const m_TransformInput: i64 = 0x1E8;
            }
            pub mod C_INIT_SetVectorAttributeToVectorExpression {
                pub const m_flLerp: i64 = 0xFA0;
                pub const m_vInput1: i64 = 0x1F0;
                pub const m_vInput2: i64 = 0x8C8;
                pub const m_nSetMethod: i64 = 0x111C;
                pub const m_nExpression: i64 = 0x1E8;
                pub const m_nOutputField: i64 = 0x1118;
                pub const m_bNormalizedOutput: i64 = 0x1120;
            }
            pub mod C_OP_RemapControlPointOrientationToRotation {
                pub const m_nCP: i64 = 0x1E0;
                pub const m_nComponent: i64 = 0x1EC;
                pub const m_flOffsetRot: i64 = 0x1E8;
                pub const m_nFieldOutput: i64 = 0x1E4;
            }
            pub mod C_OP_SetControlPointFieldToScalarExpression {
                pub const m_flInput1: i64 = 0x1F0;
                pub const m_flInput2: i64 = 0x368;
                pub const m_nOutputCP: i64 = 0x658;
                pub const m_nExpression: i64 = 0x1E8;
                pub const m_flOutputRemap: i64 = 0x4E0;
                pub const m_flInterpolation: i64 = 0x660;
                pub const m_nOutVectorField: i64 = 0x65C;
            }
            pub mod C_OP_SetControlPointOrientationToCPVelocity {
                pub const m_nCPInput: i64 = 0x1E8;
                pub const m_nCPOutput: i64 = 0x1EC;
            }
            pub mod CPulseCell_Inflow_ObservableVariableListener {
                pub const m_bSelfReference: i64 = 0x82;
                pub const m_nBlackboardReference: i64 = 0x80;
            }
            pub mod C_OP_SetControlPointPositionToRandomActiveCP {
                pub const m_nCP1: i64 = 0x1E8;
                pub const m_flResetRate: i64 = 0x1F8;
                pub const m_nHeadLocationMax: i64 = 0x1F0;
                pub const m_nHeadLocationMin: i64 = 0x1EC;
            }
            pub mod C_OP_SetControlPointPositionToTimeOfDayValue {
                pub const m_vecDefaultValue: i64 = 0x26C;
                pub const m_nControlPointNumber: i64 = 0x1E8;
                pub const m_pszTimeOfDayParameter: i64 = 0x1EC;
            }
            pub mod PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                pub const m_OutflowID: i64 = 0x0;
                pub const m_Connection: i64 = 0x8;
            }
            pub mod C_OP_SetControlPointFieldFromVectorExpression {
                pub const m_flLerp: i64 = 0xFA0;
                pub const m_nOutputCP: i64 = 0x1290;
                pub const m_vecInput1: i64 = 0x1F0;
                pub const m_vecInput2: i64 = 0x8C8;
                pub const m_nExpression: i64 = 0x1E8;
                pub const m_flOutputRemap: i64 = 0x1118;
                pub const m_nOutVectorField: i64 = 0x1294;
            }
            pub mod C_INIT_RemapInitialDirectionToTransformToVector {
                pub const m_flScale: i64 = 0x254;
                pub const m_bNormalize: i64 = 0x268;
                pub const m_flOffsetRot: i64 = 0x258;
                pub const m_nFieldOutput: i64 = 0x250;
                pub const m_vecOffsetAxis: i64 = 0x25C;
                pub const m_TransformInput: i64 = 0x1E8;
            }
            pub mod C_INIT_RemapInitialTransformDirectionToRotation {
                pub const m_nComponent: i64 = 0x258;
                pub const m_flOffsetRot: i64 = 0x254;
                pub const m_nFieldOutput: i64 = 0x250;
                pub const m_TransformInput: i64 = 0x1E8;
            }
            pub mod CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                pub const m_nNextIndex: i64 = 0x0;
            }
            pub mod CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                pub const m_Shuffle: i64 = 0x0;
                pub const m_nNextShuffle: i64 = 0x20;
            }
            pub mod C_INIT_RemapParticleCountToNamedModelElementScalar {
                pub const m_hModel: i64 = 0x218;
                pub const m_outputMaxName: i64 = 0x228;
                pub const m_outputMinName: i64 = 0x220;
                pub const m_bModelFromRenderer: i64 = 0x230;
            }
            pub mod C_INIT_RemapParticleCountToNamedModelBodyPartScalar {

            }
            pub mod C_INIT_RemapParticleCountToNamedModelSequenceScalar {

            }
            pub mod C_INIT_RemapParticleCountToNamedModelMeshGroupScalar {

            }
            pub mod DetailCombo_t {
                pub const DETAIL_COMBO_ADD: i64 = 0x1;
                pub const DETAIL_COMBO_OFF: i64 = 0x0;
                pub const DETAIL_COMBO_MOD2X: i64 = 0x3;
                pub const DETAIL_COMBO_ADD_SELF_ILLUM: i64 = 0x2;
            }
            pub mod Detail2Combo_t {
                pub const DETAIL_2_COMBO_ADD: i64 = 0x1;
                pub const DETAIL_2_COMBO_MUL: i64 = 0x4;
                pub const DETAIL_2_COMBO_OFF: i64 = 0x0;
                pub const DETAIL_2_COMBO_MOD2X: i64 = 0x3;
                pub const DETAIL_2_COMBO_CROSSFADE: i64 = 0x5;
                pub const DETAIL_2_COMBO_UNINITIALIZED: i64 = -0x1;
                pub const DETAIL_2_COMBO_ADD_SELF_ILLUM: i64 = 0x2;
            }
            pub mod PetGroundType_t {
                pub const PET_GROUND_GRID: i64 = 0x1;
                pub const PET_GROUND_NONE: i64 = 0x0;
                pub const PET_GROUND_PLANE: i64 = 0x2;
            }
            pub mod BBoxVolumeType_t {
                pub const BBOX_RADIUS: i64 = 0x3;
                pub const BBOX_VOLUME: i64 = 0x0;
                pub const BBOX_MINS_MAXS: i64 = 0x2;
                pub const BBOX_DIMENSIONS: i64 = 0x1;
                pub const BBOX_SURFACE_AREA: i64 = 0x4;
            }
            pub mod BlurFilterType_t {
                pub const BLURFILTER_BOX: i64 = 0x1;
                pub const BLURFILTER_GAUSSIAN: i64 = 0x0;
            }
            pub mod HitboxLerpType_t {
                pub const HITBOX_LERP_CONSTANT: i64 = 0x1;
                pub const HITBOX_LERP_LIFETIME: i64 = 0x0;
            }
            pub mod ModelHitboxType_t {
                pub const MODEL_HITBOX_TYPE_SNAPSHOT: i64 = 0x3;
                pub const MODEL_HITBOX_TYPE_STANDARD: i64 = 0x0;
                pub const MODEL_HITBOX_TYPE_RAW_BONES: i64 = 0x1;
                pub const MODEL_HITBOX_TYPE_RENDERBOUNDS: i64 = 0x2;
            }
            pub mod ParticleFanType_t {
                pub const PARTICLE_FAN_TYPE_FAN: i64 = 0x0;
                pub const PARTICLE_FAN_TYPE_RADIAL: i64 = 0x2;
                pub const PARTICLE_FAN_TYPE_ROTOR_WASH: i64 = 0x1;
            }
            pub mod ParticleFogType_t {
                pub const PARTICLE_FOG_ENABLED: i64 = 0x1;
                pub const PARTICLE_FOG_DISABLED: i64 = 0x2;
                pub const PARTICLE_FOG_GAME_DEFAULT: i64 = 0x0;
            }
            pub mod ParticleMassMode_t {
                pub const PARTICLE_MASSMODE_RADIUS_CUBED: i64 = 0x0;
                pub const PARTICLE_MASSMODE_RADIUS_SQUARED: i64 = 0x2;
            }
            pub mod ParticleTopology_t {
                pub const PARTICLE_TOPOLOGY_TRIS: i64 = 0x2;
                pub const PARTICLE_TOPOLOGY_CUBES: i64 = 0x4;
                pub const PARTICLE_TOPOLOGY_LINES: i64 = 0x1;
                pub const PARTICLE_TOPOLOGY_QUADS: i64 = 0x3;
                pub const PARTICLE_TOPOLOGY_POINTS: i64 = 0x0;
            }
            pub mod ParticleTraceSet_t {
                pub const PARTICLE_TRACE_SET_ALL: i64 = 0x0;
                pub const PARTICLE_TRACE_SET_STATIC: i64 = 0x1;
                pub const PARTICLE_TRACE_SET_DYNAMIC: i64 = 0x3;
                pub const PARTICLE_TRACE_SET_STATIC_AND_KEYFRAMED: i64 = 0x2;
            }
            pub mod MaterialProxyType_t {
                pub const MATERIAL_PROXY_TINT: i64 = 0x1;
                pub const MATERIAL_PROXY_STATUS_EFFECT: i64 = 0x0;
            }
            pub mod ParticleEntityPos_t {
                pub const PARTICLE_EYES: i64 = 0x2;
                pub const PARTICLE_ABS_ORIGIN: i64 = 0x0;
                pub const PARTICLE_FLASHLIGHT: i64 = 0x3;
                pub const PARTICLE_WORLDSPACE_CENTER: i64 = 0x1;
            }
            pub mod ParticleSelection_t {
                pub const PARTICLE_SELECTION_LAST: i64 = 0x1;
                pub const PARTICLE_SELECTION_FIRST: i64 = 0x0;
                pub const PARTICLE_SELECTION_NUMBER: i64 = 0x2;
            }
            pub mod SnapshotIndexType_t {
                pub const SNAPSHOT_INDEX_DIRECT: i64 = 0x1;
                pub const SNAPSHOT_INDEX_INCREMENT: i64 = 0x0;
            }
            pub mod EventTypeSelection_t {
                pub const PARTICLE_EVENT_TYPE_MASK_NONE: i64 = 0x0;
                pub const PARTICLE_EVENT_TYPE_MASK_KILLED: i64 = 0x2;
                pub const PARTICLE_EVENT_TYPE_MASK_USER_1: i64 = 0x40;
                pub const PARTICLE_EVENT_TYPE_MASK_USER_2: i64 = 0x80;
                pub const PARTICLE_EVENT_TYPE_MASK_USER_3: i64 = 0x100;
                pub const PARTICLE_EVENT_TYPE_MASK_USER_4: i64 = 0x200;
                pub const PARTICLE_EVENT_TYPE_MASK_SPAWNED: i64 = 0x1;
                pub const PARTICLE_EVENT_TYPE_MASK_COLLISION: i64 = 0x4;
                pub const PARTICLE_EVENT_TYPE_MASK_KILLED_ON_CULL: i64 = 0x400;
                pub const PARTICLE_EVENT_TYPE_MASK_CULLED_ON_SPAWN: i64 = 0x800;
                pub const PARTICLE_EVENT_TYPE_MASK_FIRST_COLLISION: i64 = 0x8;
                pub const PARTICLE_EVENT_TYPE_MASK_COLLISION_STOPPED: i64 = 0x10;
                pub const PARTICLE_EVENT_TYPE_MASK_KILLED_ON_COLLISION: i64 = 0x20;
            }
            pub mod ParticleEndcapMode_t {
                pub const PARTICLE_ENDCAP_ALWAYS_ON: i64 = -0x1;
                pub const PARTICLE_ENDCAP_ENDCAP_ON: i64 = 0x1;
                pub const PARTICLE_ENDCAP_ENDCAP_OFF: i64 = 0x0;
            }
            pub mod ParticleToolsState_t {
                pub const PARTICLE_TOOLS_STATE_ALWAYS_ON: i64 = -0x1;
                pub const PARTICLE_TOOLS_STATE_GAME_ONLY: i64 = 0x1;
                pub const PARTICLE_TOOLS_STATE_TOOLS_ONLY: i64 = 0x0;
            }
            pub mod InheritableBoolType_t {
                pub const INHERITABLE_BOOL_TRUE: i64 = 0x2;
                pub const INHERITABLE_BOOL_FALSE: i64 = 0x1;
                pub const INHERITABLE_BOOL_INHERIT: i64 = 0x0;
            }
            pub mod ParticleDetailLevel_t {
                pub const PARTICLEDETAIL_LOW: i64 = 0x0;
                pub const PARTICLEDETAIL_HIGH: i64 = 0x2;
                pub const PARTICLEDETAIL_ULTRA: i64 = 0x3;
                pub const PARTICLEDETAIL_MEDIUM: i64 = 0x1;
            }
            pub mod ParticleImpulseType_t {
                pub const IMPULSE_TYPE_NONE: i64 = 0x0;
                pub const IMPULSE_TYPE_ROPE: i64 = 0x2;
                pub const IMPULSE_TYPE_GENERIC: i64 = 0x1;
                pub const IMPULSE_TYPE_EXPLOSION: i64 = 0x4;
                pub const IMPULSE_TYPE_PARTICLE_SYSTEM: i64 = 0x10;
                pub const IMPULSE_TYPE_EXPLOSION_UNDERWATER: i64 = 0x8;
            }
            pub mod ParticlePinDistance_t {
                pub const PARTICLE_PIN_SPEED: i64 = 0x9;
                pub const PARTICLE_PIN_DISTANCE_CP: i64 = 0x6;
                pub const PARTICLE_PIN_FLOAT_VALUE: i64 = 0xB;
                pub const PARTICLE_PIN_DISTANCE_LAST: i64 = 0x3;
                pub const PARTICLE_PIN_DISTANCE_NONE: i64 = -0x1;
                pub const PARTICLE_PIN_COLLECTION_AGE: i64 = 0xA;
                pub const PARTICLE_PIN_DISTANCE_FIRST: i64 = 0x2;
                pub const PARTICLE_PIN_DISTANCE_CENTER: i64 = 0x5;
                pub const PARTICLE_PIN_DISTANCE_FARTHEST: i64 = 0x1;
                pub const PARTICLE_PIN_DISTANCE_NEIGHBOR: i64 = 0x0;
                pub const PARTICLE_PIN_DISTANCE_CP_PAIR_BOTH: i64 = 0x8;
                pub const PARTICLE_PIN_DISTANCE_CP_PAIR_EITHER: i64 = 0x7;
            }
            pub mod PulseMethodCallMode_t {
                pub const ASYNC_FIRE_AND_FORGET: i64 = 0x1;
                pub const SYNC_WAIT_FOR_COMPLETION: i64 = 0x0;
            }
            pub mod ClosestPointTestType_t {
                pub const PARTICLE_CLOSEST_TYPE_BOX: i64 = 0x0;
                pub const PARTICLE_CLOSEST_TYPE_HYBRID: i64 = 0x2;
                pub const PARTICLE_CLOSEST_TYPE_CAPSULE: i64 = 0x1;
            }
            pub mod ParticleAttrBoxFlags_t {
                pub const PARTICLE_ATTR_BOX_FLAGS_NONE: i64 = 0x0;
                pub const PARTICLE_ATTR_BOX_FLAGS_WATER: i64 = 0x1;
                pub const PARTICLE_ATTR_BOX_FLAGS_ASLEEP: i64 = 0x8;
                pub const PARTICLE_ATTR_BOX_FLAGS_FROZEN: i64 = 0x10;
                pub const PARTICLE_ATTR_BOX_FLAGS_ON_FIRE: i64 = 0x2;
                pub const PARTICLE_ATTR_BOX_FLAGS_WAKE_DECAY: i64 = 0x80;
                pub const PARTICLE_ATTR_BOX_FLAGS_ELECTRIFIED: i64 = 0x4;
                pub const PARTICLE_ATTR_BOX_FLAGS_TIMED_DECAY: i64 = 0x20;
                pub const PARTICLE_ATTR_BOX_FLAGS_ZERO_GRAVITY: i64 = 0x200;
                pub const PARTICLE_ATTR_BOX_FLAGS_MOTION_DISABLED: i64 = 0x100;
                pub const PARTICLE_ATTR_BOX_FLAGS_DISABLE_NONSTATIC_COLLISION: i64 = 0x40;
            }
            pub mod ScalarExpressionType_t {
                pub const SCALAR_EXPRESSION_GT: i64 = 0x9;
                pub const SCALAR_EXPRESSION_LT: i64 = 0xA;
                pub const SCALAR_EXPRESSION_ADD: i64 = 0x0;
                pub const SCALAR_EXPRESSION_MAX: i64 = 0x6;
                pub const SCALAR_EXPRESSION_MIN: i64 = 0x5;
                pub const SCALAR_EXPRESSION_MOD: i64 = 0x7;
                pub const SCALAR_EXPRESSION_MUL: i64 = 0x2;
                pub const SCALAR_EXPRESSION_EQUAL: i64 = 0x8;
                pub const SCALAR_EXPRESSION_DIVIDE: i64 = 0x3;
                pub const SCALAR_EXPRESSION_INPUT_1: i64 = 0x4;
                pub const SCALAR_EXPRESSION_SUBTRACT: i64 = 0x1;
                pub const SCALAR_EXPRESSION_UNINITIALIZED: i64 = -0x1;
            }
            pub mod SpriteCardShaderType_t {
                pub const SPRITECARD_SHADER_BASE: i64 = 0x0;
                pub const SPRITECARD_SHADER_CUSTOM: i64 = 0x1;
            }
            pub mod VectorExpressionType_t {
                pub const VECTOR_EXPRESSION_ADD: i64 = 0x0;
                pub const VECTOR_EXPRESSION_MAX: i64 = 0x6;
                pub const VECTOR_EXPRESSION_MIN: i64 = 0x5;
                pub const VECTOR_EXPRESSION_MUL: i64 = 0x2;
                pub const VECTOR_EXPRESSION_LERP: i64 = 0x8;
                pub const VECTOR_EXPRESSION_DIVIDE: i64 = 0x3;
                pub const VECTOR_EXPRESSION_INPUT_1: i64 = 0x4;
                pub const VECTOR_EXPRESSION_SUBTRACT: i64 = 0x1;
                pub const VECTOR_EXPRESSION_CROSSPRODUCT: i64 = 0x7;
                pub const VECTOR_EXPRESSION_UNINITIALIZED: i64 = -0x1;
            }
            pub mod ParticleCollisionMask_t {
                pub const PARTICLE_MASK_ALL: i64 = -0x1;
                pub const PARTICLE_MASK_SHOT: i64 = 0x1C1003;
                pub const PARTICLE_MASK_SOLID: i64 = 0xC3001;
                pub const PARTICLE_MASK_WATER: i64 = 0x18000;
                pub const PARTICLE_MASK_OPAQUE: i64 = 0x80;
                pub const PARTICLE_MASK_NPCSOLID: i64 = 0xC3021;
                pub const PARTICLE_MASK_SHOT_HULL: i64 = 0x1C3001;
                pub const PARTICLE_MASK_SOLID_WATER: i64 = 0xDB001;
                pub const PARTICLE_MASK_SHOT_BRUSHONLY: i64 = 0x101001;
                pub const PARTICLE_MASK_DEFAULTPLAYERSOLID: i64 = 0xC3011;
            }
            pub mod ParticleCollisionMode_t {
                pub const COLLISION_MODE_DISABLED: i64 = -0x1;
                pub const COLLISION_MODE_USE_NEAREST_TRACE: i64 = 0x2;
                pub const COLLISION_MODE_INITIAL_TRACE_DOWN: i64 = 0x0;
                pub const COLLISION_MODE_PER_FRAME_PLANESET: i64 = 0x1;
                pub const COLLISION_MODE_PER_PARTICLE_TRACE: i64 = 0x3;
            }
            pub mod ParticleParentSetMode_t {
                pub const PARTICLE_SET_PARENT_NO: i64 = 0x0;
                pub const PARTICLE_SET_PARENT_ROOT: i64 = 0x2;
                pub const PARTICLE_SET_PARENT_IMMEDIATE: i64 = 0x1;
            }
            pub mod PulseBestOutflowRules_t {
                pub const SORT_BY_OUTFLOW_INDEX: i64 = 0x1;
                pub const SORT_BY_NUMBER_OF_VALID_CRITERIA: i64 = 0x0;
            }
            pub mod SpriteCardTextureType_t {
                pub const SPRITECARD_TEXTURE_ZOOM: i64 = 0x1;
                pub const SPRITECARD_TEXTURE_DEPTH: i64 = 0xA;
                pub const SPRITECARD_TEXTURE_DIFFUSE: i64 = 0x0;
                pub const SPRITECARD_TEXTURE_NORMALMAP: i64 = 0x5;
                pub const SPRITECARD_TEXTURE_UVDISTORTION: i64 = 0x3;
                pub const SPRITECARD_TEXTURE_ANIMMOTIONVEC: i64 = 0x6;
                pub const SPRITECARD_TEXTURE_1D_COLOR_LOOKUP: i64 = 0x2;
                pub const SPRITECARD_TEXTURE_UVDISTORTION_ZOOM: i64 = 0x4;
                pub const SPRITECARD_TEXTURE_ILLUMINATION_GRADIENT: i64 = 0xB;
                pub const SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_A: i64 = 0x7;
                pub const SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_B: i64 = 0x8;
                pub const SPRITECARD_TEXTURE_SPHERICAL_HARMONICS_C: i64 = 0x9;
            }
            pub mod TextureRepetitionMode_t {
                pub const TEXTURE_REPETITION_PATH: i64 = 0x1;
                pub const TEXTURE_REPETITION_PARTICLE: i64 = 0x0;
            }
            pub mod PFuncVisualizationType_t {
                pub const PFUNC_VISUALIZATION_BOX: i64 = 0x2;
                pub const PFUNC_VISUALIZATION_LINE: i64 = 0x5;
                pub const PFUNC_VISUALIZATION_RING: i64 = 0x3;
                pub const PFUNC_VISUALIZATION_PLANE: i64 = 0x4;
                pub const PFUNC_VISUALIZATION_CYLINDER: i64 = 0x6;
                pub const PFUNC_VISUALIZATION_SPHERE_SOLID: i64 = 0x1;
                pub const PFUNC_VISUALIZATION_SPHERE_WIREFRAME: i64 = 0x0;
            }
            pub mod ParticleCollisionGroup_t {
                pub const PARTICLE_COLLISION_GROUP_NPC: i64 = 0xC;
                pub const PARTICLE_COLLISION_GROUP_PROPS: i64 = 0x18;
                pub const PARTICLE_COLLISION_GROUP_DEBRIS: i64 = 0x5;
                pub const PARTICLE_COLLISION_GROUP_PLAYER: i64 = 0x8;
                pub const PARTICLE_COLLISION_GROUP_DEFAULT: i64 = 0x4;
                pub const PARTICLE_COLLISION_GROUP_VEHICLE: i64 = 0xA;
                pub const PARTICLE_COLLISION_GROUP_INTERACTIVE: i64 = 0x7;
            }
            pub mod ParticleHitboxBiasType_t {
                pub const PARTICLE_HITBOX_BIAS_ENTITY: i64 = 0x0;
                pub const PARTICLE_HITBOX_BIAS_HITBOX: i64 = 0x1;
            }
            pub mod ParticleLiquidContents_t {
                pub const PARTICLE_LIQUID_OIL: i64 = 0x1;
                pub const PARTICLE_LIQUID_NONE: i64 = 0x0;
                pub const PARTICLE_LIQUID_WATER: i64 = 0x2;
            }
            pub mod ParticleFalloffFunction_t {
                pub const PARTICLE_FALLOFF_LINEAR: i64 = 0x1;
                pub const PARTICLE_FALLOFF_CONSTANT: i64 = 0x0;
                pub const PARTICLE_FALLOFF_EXPONENTIAL: i64 = 0x2;
            }
            pub mod ParticleLightingQuality_t {
                pub const PARTICLE_LIGHTING_PER_PIXEL: i64 = -0x1;
                pub const PARTICLE_LIGHTING_PER_VERTEX: i64 = 0x1;
                pub const PARTICLE_LIGHTING_PER_PARTICLE: i64 = 0x0;
                pub const PARTICLE_LIGHTING_OVERRIDE_COLOR: i64 = 0x3;
                pub const PARTICLE_LIGHTING_ADD_EXTRA_LIGHT: i64 = 0x4;
                pub const PARTICLE_LIGHTING_OVERRIDE_POSITION: i64 = 0x2;
            }
            pub mod ParticleOrientationType_t {
                pub const PARTICLE_ORIENTATION_NONE: i64 = 0x0;
                pub const PARTICLE_ORIENTATION_NORMAL: i64 = 0x2;
                pub const PARTICLE_ORIENTATION_ROTATION: i64 = 0x4;
                pub const PARTICLE_ORIENTATION_VELOCITY: i64 = 0x1;
            }
            pub mod ParticleOutputBlendMode_t {
                pub const PARTICLE_OUTPUT_BLEND_MODE_ADD: i64 = 0x1;
                pub const PARTICLE_OUTPUT_BLEND_MODE_ALPHA: i64 = 0x0;
                pub const PARTICLE_OUTPUT_BLEND_MODE_MOD2X: i64 = 0x5;
                pub const PARTICLE_OUTPUT_BLEND_MODE_LIGHTEN: i64 = 0x6;
                pub const PARTICLE_OUTPUT_BLEND_MODE_BLEND_ADD: i64 = 0x2;
                pub const PARTICLE_OUTPUT_BLEND_MODE_HALF_BLEND_ADD: i64 = 0x3;
                pub const PARTICLE_OUTPUT_BLEND_MODE_NEG_HALF_BLEND_ADD: i64 = 0x4;
            }
            pub mod PulseCursorWakePriority_t {
                pub const WakeElegantly: i64 = 0x0;
                pub const WakeImmediate: i64 = 0x1;
            }
            pub mod ParticleControlPointAxis_t {
                pub const PARTICLE_CP_AXIS_X: i64 = 0x0;
                pub const PARTICLE_CP_AXIS_Y: i64 = 0x1;
                pub const PARTICLE_CP_AXIS_Z: i64 = 0x2;
                pub const PARTICLE_CP_AXIS_NEGATIVE_X: i64 = 0x3;
                pub const PARTICLE_CP_AXIS_NEGATIVE_Y: i64 = 0x4;
                pub const PARTICLE_CP_AXIS_NEGATIVE_Z: i64 = 0x5;
            }
            pub mod ParticleRotationLockType_t {
                pub const PARTICLE_ROTATION_LOCK_NONE: i64 = 0x0;
                pub const PARTICLE_ROTATION_LOCK_NORMAL: i64 = 0x2;
                pub const PARTICLE_ROTATION_LOCK_ROTATIONS: i64 = 0x1;
            }
            pub mod ParticleVRHandChoiceList_t {
                pub const PARTICLE_VRHAND_CP: i64 = 0x2;
                pub const PARTICLE_VRHAND_LEFT: i64 = 0x0;
                pub const PARTICLE_VRHAND_RIGHT: i64 = 0x1;
                pub const PARTICLE_VRHAND_CP_OBJECT: i64 = 0x3;
            }
            pub mod SpriteCardTextureChannel_t {
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_A: i64 = 0x2;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_B: i64 = 0xB;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_G: i64 = 0xA;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_R: i64 = 0x9;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_RGB: i64 = 0x0;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_RGBA: i64 = 0x1;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_A: i64 = 0x3;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_BALPHA: i64 = 0xE;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_GALPHA: i64 = 0xD;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_RALPHA: i64 = 0xC;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_A_RGBALPHA: i64 = 0x7;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_RGBMASK: i64 = 0x5;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_RGBA_RGBALPHA: i64 = 0x6;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_ALPHAMASK: i64 = 0x4;
                pub const SPRITECARD_TEXTURE_CHANNEL_MIX_RGB_A_RGBALPHA: i64 = 0x8;
            }
            pub mod ParticleSortingChoiceList_t {
                pub const PARTICLE_SORTING_NEAREST: i64 = 0x0;
                pub const PARTICLE_SORTING_CREATION_TIME: i64 = 0x1;
            }
            pub mod ParticleTraceMissBehavior_t {
                pub const PARTICLE_TRACE_MISS_BEHAVIOR_KILL: i64 = 0x1;
                pub const PARTICLE_TRACE_MISS_BEHAVIOR_NONE: i64 = 0x0;
                pub const PARTICLE_TRACE_MISS_BEHAVIOR_TRACE_END: i64 = 0x2;
            }
            pub mod PulseCursorCancelPriority_t {
                pub const _None: i64 = 0x0;
                pub const HardCancel: i64 = 0x3;
                pub const SoftCancel: i64 = 0x2;
                pub const CancelOnSucceeded: i64 = 0x1;
            }
            pub mod VectorFloatExpressionType_t {
                pub const VECTOR_FLOAT_EXPRESSION_DISTANCE: i64 = 0x1;
                pub const VECTOR_FLOAT_EXPRESSION_DOTPRODUCT: i64 = 0x0;
                pub const VECTOR_FLOAT_EXPRESSION_DISTANCESQR: i64 = 0x2;
                pub const VECTOR_FLOAT_EXPRESSION_INPUT1_NOISE: i64 = 0x5;
                pub const VECTOR_FLOAT_EXPRESSION_INPUT1_LENGTH: i64 = 0x3;
                pub const VECTOR_FLOAT_EXPRESSION_UNINITIALIZED: i64 = -0x1;
                pub const VECTOR_FLOAT_EXPRESSION_INPUT1_LENGTHSQR: i64 = 0x4;
            }
            pub mod ParticleAlphaReferenceType_t {
                pub const PARTICLE_ALPHA_REFERENCE_ALPHA_ALPHA: i64 = 0x0;
                pub const PARTICLE_ALPHA_REFERENCE_ALPHA_OPAQUE: i64 = 0x2;
                pub const PARTICLE_ALPHA_REFERENCE_OPAQUE_ALPHA: i64 = 0x1;
                pub const PARTICLE_ALPHA_REFERENCE_OPAQUE_OPAQUE: i64 = 0x3;
            }
            pub mod ParticleOrientationSetMode_t {
                pub const PARTICLE_ORIENTATION_SET_NONE: i64 = -0x1;
                pub const PARTICLE_ORIENTATION_SET_FROM_NORMAL: i64 = 0x1;
                pub const PARTICLE_ORIENTATION_SET_FROM_VELOCITY: i64 = 0x0;
                pub const PARTICLE_ORIENTATION_SET_FROM_ROTATIONS: i64 = 0x2;
            }
            pub mod SetStatisticExpressionType_t {
                pub const SET_EXPRESSION_MAX: i64 = 0x6;
                pub const SET_EXPRESSION_MIN: i64 = 0x5;
                pub const SET_EXPRESSION_SUM: i64 = 0x0;
                pub const SET_EXPRESSION_MEAN: i64 = 0x1;
                pub const SET_EXPRESSION_MODE: i64 = 0x3;
                pub const SET_EXPRESSION_MEDIAN: i64 = 0x2;
                pub const SET_EXPRESSION_UNINITIALIZED: i64 = -0x1;
                pub const SET_EXPRESSION_STANDARD_DEVIATION: i64 = 0x4;
            }
            pub mod SpriteCardPerParticleScale_t {
                pub const SPRITECARD_TEXTURE_PP_SCALE_YAW: i64 = 0x8;
                pub const SPRITECARD_TEXTURE_PP_SCALE_NONE: i64 = 0x0;
                pub const SPRITECARD_TEXTURE_PP_SCALE_ROLL: i64 = 0x7;
                pub const SPRITECARD_TEXTURE_PP_SCALE_PITCH: i64 = 0x9;
                pub const SPRITECARD_TEXTURE_PP_SCALE_RANDOM: i64 = 0xA;
                pub const SPRITECARD_TEXTURE_PP_SCALE_NEG_RANDOM: i64 = 0xB;
                pub const SPRITECARD_TEXTURE_PP_SCALE_RANDOM_TIME: i64 = 0xC;
                pub const SPRITECARD_TEXTURE_PP_SCALE_PARTICLE_AGE: i64 = 0x1;
                pub const SPRITECARD_TEXTURE_PP_SCALE_SHADER_RADIUS: i64 = 0x6;
                pub const SPRITECARD_TEXTURE_PP_SCALE_PARTICLE_ALPHA: i64 = 0x5;
                pub const SPRITECARD_TEXTURE_PP_SCALE_ANIMATION_FRAME: i64 = 0x2;
                pub const SPRITECARD_TEXTURE_PP_SCALE_NEG_RANDOM_TIME: i64 = 0xD;
                pub const SPRITECARD_TEXTURE_PP_SCALE_SHADER_EXTRA_DATA1: i64 = 0x3;
                pub const SPRITECARD_TEXTURE_PP_SCALE_SHADER_EXTRA_DATA2: i64 = 0x4;
            }
            pub mod ParticleDepthFeatheringMode_t {
                pub const PARTICLE_DEPTH_FEATHERING_OFF: i64 = 0x0;
                pub const PARTICLE_DEPTH_FEATHERING_ON_OPTIONAL: i64 = 0x1;
                pub const PARTICLE_DEPTH_FEATHERING_ON_REQUIRED: i64 = 0x2;
            }
            pub mod ParticleHitboxDataSelection_t {
                pub const PARTICLE_HITBOX_COUNT: i64 = 0x1;
                pub const PARTICLE_HITBOX_AVERAGE_SPEED: i64 = 0x0;
            }
            pub mod ParticleLightTypeChoiceList_t {
                pub const PARTICLE_LIGHT_TYPE_FX: i64 = 0x2;
                pub const PARTICLE_LIGHT_TYPE_SPOT: i64 = 0x1;
                pub const PARTICLE_LIGHT_TYPE_POINT: i64 = 0x0;
                pub const PARTICLE_LIGHT_TYPE_CAPSULE: i64 = 0x3;
            }
            pub mod ParticleLightUnitChoiceList_t {
                pub const PARTICLE_LIGHT_UNIT_LUMENS: i64 = 0x1;
                pub const PARTICLE_LIGHT_UNIT_CANDELAS: i64 = 0x0;
            }
            pub mod ParticleVolumetricSmokeType_t {
                pub const PARTICLE_VOLUMETRIC_SMOKE_TYPE_SINK: i64 = 0x1;
                pub const PARTICLE_VOLUMETRIC_SMOKE_TYPE_REPEL: i64 = 0x2;
                pub const PARTICLE_VOLUMETRIC_SMOKE_TYPE_TRACE: i64 = 0x3;
                pub const PARTICLE_VOLUMETRIC_SMOKE_TYPE_EMISSION: i64 = 0x0;
            }
            pub mod MissingParentInheritBehavior_t {
                pub const MISSING_PARENT_KILL: i64 = 0x0;
                pub const MISSING_PARENT_FIND_NEW: i64 = 0x1;
                pub const MISSING_PARENT_DO_NOTHING: i64 = -0x1;
                pub const MISSING_PARENT_SAME_INDEX: i64 = 0x2;
            }
            pub mod ParticleLightFogLightingMode_t {
                pub const PARTICLE_LIGHT_FOG_LIGHTING_MODE_NONE: i64 = 0x0;
                pub const PARTICLE_LIGHT_FOG_LIGHTING_MODE_DYNAMIC: i64 = 0x2;
                pub const PARTICLE_LIGHT_FOG_LIGHTING_MODE_DYNAMIC_NOSHADOWS: i64 = 0x4;
            }
            pub mod ParticleSequenceCropOverride_t {
                pub const PARTICLE_SEQUENCE_CROP_OVERRIDE_DEFAULT: i64 = -0x1;
                pub const PARTICLE_SEQUENCE_CROP_OVERRIDE_FORCE_ON: i64 = 0x1;
                pub const PARTICLE_SEQUENCE_CROP_OVERRIDE_FORCE_OFF: i64 = 0x0;
            }
            pub mod RenderModelSubModelFieldType_t {
                pub const SUBMODEL_AS_MESHGROUP_MASK: i64 = 0x2;
                pub const SUBMODEL_AS_MESHGROUP_INDEX: i64 = 0x1;
                pub const SUBMODEL_AS_BODYGROUP_SUBMODEL: i64 = 0x0;
                pub const SUBMODEL_IGNORED_USE_MODEL_DEFAULT_MESHGROUP_MASK: i64 = 0x3;
            }
            pub mod ParticleOrientationChoiceList_t {
                pub const PARTICLE_ORIENTATION_SCREEN_ALIGNED: i64 = 0x0;
                pub const PARTICLE_ORIENTATION_WORLD_Z_ALIGNED: i64 = 0x2;
                pub const PARTICLE_ORIENTATION_SCREEN_Z_ALIGNED: i64 = 0x1;
                pub const PARTICLE_ORIENTATION_FULL_3AXIS_ROTATION: i64 = 0x5;
                pub const PARTICLE_ORIENTATION_ALIGN_TO_PARTICLE_NORMAL: i64 = 0x3;
                pub const PARTICLE_ORIENTATION_SCREENALIGN_TO_PARTICLE_NORMAL: i64 = 0x4;
            }
            pub mod ParticleTextureLayerBlendType_t {
                pub const SPRITECARD_TEXTURE_BLEND_ADD: i64 = 0x3;
                pub const SPRITECARD_TEXTURE_BLEND_MOD2X: i64 = 0x1;
                pub const SPRITECARD_TEXTURE_BLEND_AVERAGE: i64 = 0x5;
                pub const SPRITECARD_TEXTURE_BLEND_REPLACE: i64 = 0x2;
                pub const SPRITECARD_TEXTURE_BLEND_MULTIPLY: i64 = 0x0;
                pub const SPRITECARD_TEXTURE_BLEND_SUBTRACT: i64 = 0x4;
                pub const SPRITECARD_TEXTURE_BLEND_LUMINANCE: i64 = 0x6;
            }
            pub mod ParticleLightBehaviorChoiceList_t {
                pub const PARTICLE_LIGHT_BEHAVIOR_ROPE: i64 = 0x1;
                pub const PARTICLE_LIGHT_BEHAVIOR_TRAILS: i64 = 0x2;
                pub const PARTICLE_LIGHT_BEHAVIOR_FOLLOW_DIRECTION: i64 = 0x0;
            }
            pub mod ParticleLightnintBranchBehavior_t {
                pub const PARTICLE_LIGHTNING_BRANCH_CURRENT_DIR: i64 = 0x0;
                pub const PARTICLE_LIGHTNING_BRANCH_ENDPOINT_DIR: i64 = 0x1;
            }
            pub mod ParticleOmni2LightTypeChoiceList_t {
                pub const PARTICLE_OMNI2_LIGHT_TYPE_BARN: i64 = 0x2;
                pub const PARTICLE_OMNI2_LIGHT_TYPE_POINT: i64 = 0x0;
                pub const PARTICLE_OMNI2_LIGHT_TYPE_SPHERE: i64 = 0x1;
            }
            pub mod ParticlePostProcessPriorityGroup_t {
                pub const PARTICLE_POST_PROCESS_PRIORITY_GLOBAL_UI: i64 = 0x5;
                pub const PARTICLE_POST_PROCESS_PRIORITY_LEVEL_VOLUME: i64 = 0x0;
                pub const PARTICLE_POST_PROCESS_PRIORITY_LEVEL_OVERRIDE: i64 = 0x1;
                pub const PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_EFFECT: i64 = 0x2;
                pub const PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_STATE_LOW: i64 = 0x3;
                pub const PARTICLE_POST_PROCESS_PRIORITY_GAMEPLAY_STATE_HIGH: i64 = 0x4;
            }
            pub mod StandardLightingAttenuationStyle_t {
                pub const LIGHT_STYLE_NEW: i64 = 0x1;
                pub const LIGHT_STYLE_OLD: i64 = 0x0;
            }
            pub mod ParticleMultiSegmentCountSelection_t {
                pub const PARTICLE_MULTISEGMENT_SEG_COUNT_7: i64 = 0x7;
                pub const PARTICLE_MULTISEGMENT_SEG_COUNT_14: i64 = 0xE;
                pub const PARTICLE_MULTISEGMENT_SEG_COUNT_16: i64 = 0x10;
            }
            pub mod ParticleMultiSegmentInputSelection_t {
                pub const PARTICLE_MULTISEGMENT_SELECTION_FLOAT: i64 = 0x0;
                pub const PARTICLE_MULTISEGMENT_SELECTION_STRING: i64 = 0x1;
            }
            pub mod ParticleVolumetricSmokeCreationType_t {
                pub const PARTICLE_VOLUMETRIC_SMOKE_TYPE_IMPULSE: i64 = 0x1;
                pub const PARTICLE_VOLUMETRIC_SMOKE_TYPE_CONTINUOUS: i64 = 0x0;
            }
            pub mod ParticleMultiSegmentSpecialCharacter_t {
                pub const PARTICLE_MULTISEGMENT_SPECIAL_NONE: i64 = -0x1;
                pub const PARTICLE_MULTISEGMENT_SPECIAL_COLON: i64 = 0x1;
                pub const PARTICLE_MULTISEGMENT_SPECIAL_DECIMAL: i64 = 0x0;
                pub const PARTICLE_MULTISEGMENT_SPECIAL_DEGREES: i64 = 0x2;
            }
            pub mod ParticleOmni2LighOrientationChoiceList_t {
                pub const PARTICLE_OMNI2_LIGHT_ORIENTATION_NORMAL: i64 = 0x1;
                pub const PARTICLE_OMNI2_LIGHT_ORIENTATION_TARGET: i64 = 0x3;
                pub const PARTICLE_OMNI2_LIGHT_ORIENTATION_ROTATIONS: i64 = 0x0;
                pub const PARTICLE_OMNI2_LIGHT_ORIENTATION_NORMAL_ROLL: i64 = 0x2;
                pub const PARTICLE_OMNI2_LIGHT_ORIENTATION_TARGET_ROLL: i64 = 0x4;
            }
        }
    }
}
