public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class animationsystem_dll {
            public static partial class CFlexOp {
                public const long m_Data = 0x4;
                public const long m_OpCode = 0x0;
            }
            public static partial class CHitBox {
                public const long m_CRC = 0x40;
                public const long m_name = 0x0;
                public const long m_nGroupId = 0x38;
                public const long m_sBoneName = 0x10;
                public const long m_nShapeType = 0x3C;
                public const long m_vMaxBounds = 0x24;
                public const long m_vMinBounds = 0x18;
                public const long m_cRenderColor = 0x44;
                public const long m_nHitBoxIndex = 0x48;
                public const long m_flShapeRadius = 0x30;
                public const long m_nBoneNameHash = 0x34;
                public const long m_bTranslationOnly = 0x3D;
                public const long m_sSurfaceProperty = 0x8;
            }
            public static partial class CNmClip {
                public const long m_skeleton = 0x0;
                public const long m_syncTrack = 0xC0;
                public const long m_flDuration = 0xC;
                public const long m_nNumFrames = 0x8;
                public const long m_rootMotion = 0x170;
                public const long m_bIsAdditive = 0x1C0;
                public const long m_floatChannelData = 0x98;
                public const long m_compressedPoseData = 0x10;
                public const long m_secondaryAnimations = 0x78;
                public const long m_compressedPoseOffsets = 0x38;
                public const long m_modelSpaceSamplingChain = 0x1C8;
                public const long m_trackCompressionSettings = 0x20;
                public const long m_modelSpaceBoneSamplingIndices = 0x1E0;
            }
            public static partial class CNmEvent {
                public const long m_syncID = 0x10;
                public const long m_flDuration = 0xC;
                public const long m_flStartTime = 0x8;
            }
            public static partial class LookData {
                public const long m_vLookTarget = 0x0;
            }
            public static partial class AnimTagID {
                public const long m_id = 0x0;
            }
            public static partial class CAnimBone {
                public const long m_pos = 0x14;
                public const long m_name = 0x0;
                public const long m_quat = 0x20;
                public const long m_flags = 0x44;
                public const long m_scale = 0x30;
                public const long m_parent = 0x10;
                public const long m_qAlignment = 0x34;
            }
            public static partial class CAnimData {
                public const long m_name = 0x10;
                public const long m_animArray = 0x20;
                public const long m_decoderArray = 0x38;
                public const long m_segmentArray = 0x58;
                public const long m_nMaxUniqueFrameIndex = 0x50;
            }
            public static partial class CAnimDesc {
                public const long fps = 0x18;
                public const long m_Data = 0x20;
                public const long m_name = 0x0;
                public const long m_flags = 0x10;
                public const long m_eventArray = 0x130;
                public const long m_vecRootMax = 0x188;
                public const long m_vecRootMin = 0x17C;
                public const long framestalltime = 0x178;
                public const long m_activityArray = 0x148;
                public const long m_movementArray = 0xF8;
                public const long m_hierarchyArray = 0x160;
                public const long m_sequenceParams = 0x1C8;
                public const long m_xInitialOffset = 0x110;
                public const long m_vecBoneWorldMax = 0x1B0;
                public const long m_vecBoneWorldMin = 0x198;
            }
            public static partial class CAnimEnum {
                public const long m_value = 0x0;
            }
            public static partial class CAnimFoot {
                public const long m_name = 0x0;
                public const long m_vBallOffset = 0x8;
                public const long m_vHeelOffset = 0x14;
                public const long m_toeBoneIndex = 0x24;
                public const long m_ankleBoneIndex = 0x20;
            }
            public static partial class CAnimUser {
                public const long m_name = 0x0;
                public const long m_nType = 0x10;
            }
            public static partial class CFlexDesc {
                public const long m_szFacs = 0x0;
            }
            public static partial class CFlexRule {
                public const long m_nFlex = 0x0;
                public const long m_FlexOps = 0x8;
            }
            public static partial class CNmTarget {
                public const long m_bIsSet = 0x2B;
                public const long m_boneID = 0x20;
                public const long m_transform = 0x0;
                public const long m_bHasOffsets = 0x2A;
                public const long m_bIsBoneTarget = 0x28;
                public const long m_bIsUsingBoneSpaceOffsets = 0x29;
            }
            public static partial class HSequence {
                public const long m_Value = 0x0;
            }
            public static partial class SlopeData {
                public const long m_vSlopeNormal = 0x0;
            }
            public static partial class TagSpan_t {
                public const long m_endCycle = 0x8;
                public const long m_tagIndex = 0x0;
                public const long m_startCycle = 0x4;
            }
            public static partial class TagStatus {
                public const long m_TagStatus = 0x0;
                public const long m_flTagStartAnimTime = 0x4;
            }
            public static partial class AnimNodeID {
                public const long m_id = 0x0;
            }
            public static partial class CAnimCycle {

            }
            public static partial class CCycleBase {
                public const long m_flCycle = 0x0;
            }
            public static partial class CFootCycle {

            }
            public static partial class CHitBoxSet {
                public const long m_name = 0x0;
                public const long m_HitBoxes = 0x10;
                public const long m_nNameHash = 0x8;
                public const long m_SourceFilename = 0x28;
            }
            public static partial class CMoodVData {
                public const long m_nMoodType = 0xE0;
                public const long m_sModelName = 0x0;
                public const long m_animationLayers = 0xE8;
            }
            public static partial class CMorphData {
                public const long m_name = 0x0;
                public const long m_morphRectDatas = 0x8;
            }
            public static partial class CNmIDEvent {
                public const long m_ID = 0x18;
                public const long m_secondaryID = 0x20;
            }
            public static partial class CSeqIKLock {
                public const long m_nLocalBone = 0x8;
                public const long m_flPosWeight = 0x0;
                public const long m_flAngleWeight = 0x4;
                public const long m_bBonesOrientedAlongPositiveX = 0xA;
            }
            public static partial class SampleCode {
                public const long m_subCode = 0x0;
            }
            public static partial class WeightList {
                public const long m_name = 0x0;
                public const long m_weights = 0x8;
            }
            public static partial class AnimParamID {
                public const long m_id = 0x0;
            }
            public static partial class AnimStateID {
                public const long m_id = 0x0;
            }
            public static partial class BlendItem_t {
                public const long m_tags = 0x0;
                public const long m_vPos = 0x2C;
                public const long m_pChild = 0x18;
                public const long m_hSequence = 0x28;
                public const long m_flDuration = 0x34;
                public const long m_bUseCustomDuration = 0x38;
            }
            public static partial class CAttachment {
                public const long m_name = 0x0;
                public const long m_nInfluences = 0x83;
                public const long m_influenceNames = 0x8;
                public const long m_bIgnoreRotation = 0x84;
                public const long m_influenceWeights = 0x74;
                public const long m_vInfluenceOffsets = 0x50;
                public const long m_vInfluenceRotations = 0x20;
                public const long m_bInfluenceRootTransform = 0x80;
            }
            public static partial class CBlendCurve {
                public const long m_flControlPoint1 = 0x0;
                public const long m_flControlPoint2 = 0x4;
            }
            public static partial class CCachedPose {
                public const long m_flCycle = 0x3C;
                public const long m_hSequence = 0x38;
                public const long m_transforms = 0x8;
                public const long m_morphWeights = 0x20;
            }
            public static partial class CFootMotion {
                public const long m_name = 0x18;
                public const long m_strides = 0x0;
                public const long m_bAdditive = 0x20;
            }
            public static partial class CFootStride {
                public const long m_definition = 0x0;
                public const long m_trajectories = 0x40;
            }
            public static partial class CMotionNode {
                public const long m_id = 0x20;
                public const long m_name = 0x18;
            }
            public static partial class CNmBitFlags {
                public const long m_flags = 0x0;
            }
            public static partial class CNmPoseTask {

            }
            public static partial class CNmSkeleton {
                public const long m_ID = 0x0;
                public const long m_boneIDs = 0x8;
                public const long m_parentIndices = 0x18;
                public const long m_contactConfigs = 0xC8;
                public const long m_bIsPropSkeleton = 0x64;
                public const long m_maskDefinitions = 0x88;
                public const long m_floatChannelSets = 0xB8;
                public const long m_secondarySkeletons = 0xA8;
                public const long m_nSpecialDependencyHash = 0xF8;
                public const long m_modelSpaceReferencePose = 0x48;
                public const long m_numBonesToSampleAtLowLOD = 0x60;
                public const long m_parentSpaceReferencePose = 0x30;
                public const long m_gameplayRelevantBoneIndices = 0xE0;
            }
            public static partial class CPoseHandle {
                public const long m_eType = 0x2;
                public const long m_nIndex = 0x0;
            }
            public static partial class CRenderMesh {
                public const long m_skeleton = 0xE0;
                public const long m_pGroomData = 0x230;
                public const long m_constraints = 0xD0;
                public const long m_sceneObjects = 0x10;
                public const long m_bEmbeddedMapMesh = 0x1F9;
                public const long m_meshDeformParams = 0x220;
                public const long m_bUseUV2ForCharting = 0x1F8;
            }
            public static partial class CRootMotion {
                public const long m_vUpOverride = 0x1C;
                public const long m_vVelocityMS = 0x10;
                public const long m_deltaTransform = 0x0;
            }
            public static partial class ConfigIndex {
                public const long m_nGroup = 0x0;
                public const long m_nConfig = 0x2;
            }
            public static partial class MotionIndex {
                public const long m_nGroup = 0x0;
                public const long m_nMotion = 0x2;
            }
            public static partial class NmPercent_t {
                public const long m_flValue = 0x0;
            }
            public static partial class ParamSpan_t {
                public const long m_hParam = 0x18;
                public const long m_samples = 0x0;
                public const long m_eParamType = 0x1A;
                public const long m_flEndCycle = 0x20;
                public const long m_flStartCycle = 0x1C;
            }
            public static partial class CAnimDecoder {
                public const long m_nType = 0x14;
                public const long m_szName = 0x0;
                public const long m_nVersion = 0x10;
            }
            public static partial class CAnimKeyData {
                public const long m_name = 0x0;
                public const long m_boneArray = 0x10;
                public const long m_userArray = 0x28;
                public const long m_morphArray = 0x40;
                public const long m_dataChannelArray = 0x60;
                public const long m_nChannelElements = 0x58;
            }
            public static partial class CAnimTagBase {
                public const long m_name = 0x18;
                public const long m_group = 0x28;
                public const long m_tagID = 0x30;
                public const long m_sComment = 0x20;
                public const long m_bIsReferenced = 0x48;
            }
            public static partial class CModelConfig {
                public const long m_Elements = 0x8;
                public const long m_bTopLevel = 0x20;
                public const long m_ConfigName = 0x0;
                public const long m_bActiveInEditorByDefault = 0x21;
            }
            public static partial class CMotionGraph {
                public const long m_tags = 0x28;
                public const long m_bLoop = 0x54;
                public const long m_pRootNode = 0x40;
                public const long m_paramSpans = 0x10;
                public const long m_nConfigCount = 0x50;
                public const long m_nParameterCount = 0x48;
                public const long m_nConfigStartIndex = 0x4C;
            }
            public static partial class CNmBlendTask {

            }
            public static partial class CNmFootEvent {
                public const long m_phase = 0x18;
            }
            public static partial class CNmScaleTask {

            }
            public static partial class CNmSyncTrack {
                public const long m_syncEvents = 0x0;
                public const long m_nStartEventOffset = 0xA8;
            }
            public static partial class CPulse_Chunk {
                public const long m_Registers = 0x10;
                public const long m_Instructions = 0x0;
                public const long m_nTempVarBank = 0x30;
                public const long m_InstructionDebugInfos = 0x20;
            }
            public static partial class CRenderGroom {
                public const long m_hairs = 0x0;
                public const long m_nHairCount = 0x80;
                public const long m_hSimParamsMat = 0x40;
                public const long m_nGroomGroupID = 0x8C;
                public const long m_nAttachBoneIdx = 0x90;
                public const long m_nAttachMeshIdx = 0x94;
                public const long m_nGuideHairCount = 0x7C;
                public const long m_bEnableSimulation = 0xAC;
                public const long m_nTotalVertexCount = 0x84;
                public const long m_nTotalSegmentCount = 0x88;
                public const long m_hairPositionOffsets = 0x18;
                public const long m_nAttachMeshDrawCallIdx = 0x98;
                public const long m_strandSegmentCountHist = 0x48;
                public const long m_nMaxSegmentsPerHairStrand = 0x78;
            }
            public static partial class CSeqCmdLayer {
                public const long m_cmd = 0x0;
                public const long m_flVar1 = 0xC;
                public const long m_flVar2 = 0x10;
                public const long m_bSpline = 0xA;
                public const long m_nDstResult = 0x6;
                public const long m_nSrcResult = 0x8;
                public const long m_nLineNumber = 0x14;
                public const long m_nLocalBonemask = 0x4;
                public const long m_nLocalReference = 0x2;
            }
            public static partial class CSeqScaleSet {
                public const long m_sName = 0x0;
                public const long m_bRootOffset = 0x10;
                public const long m_vRootOffset = 0x14;
                public const long m_nLocalBoneArray = 0x20;
                public const long m_flBoneScaleArray = 0x38;
            }
            public static partial class LookAtBone_t {
                public const long m_index = 0x0;
                public const long m_weight = 0x4;
            }
            public static partial class MovementData {
                public const long m_bHasPath = 0x68;
                public const long m_vMoveDir = 0xC;
                public const long m_bOnGround = 0xBC;
                public const long m_nFacingMode = 0x98;
                public const long m_bForceFacing = 0xA4;
                public const long m_bGoalChanged = 0x64;
                public const long m_vAcceleration = 0x20;
                public const long m_flGoalDistance = 0x4C;
                public const long m_flFacingHeading = 0x74;
                public const long m_goalWayPointPos = 0x0;
                public const long m_vFacingPosition = 0xC8;
                public const long m_flBoundaryRadius = 0x58;
                public const long m_flTargetMoveSpeed = 0x40;
                public const long m_nActiveMotorIndex = 0xB0;
                public const long m_flCurrentMoveSpeed = 0x34;
                public const long m_vManualFacingTarget = 0x8C;
                public const long m_vPrevFacingPosition = 0xDC;
                public const long m_vManualFacingDirection = 0x80;
            }
            public static partial class ScriptInfo_t {
                public const long m_code = 0x0;
                public const long m_eScriptType = 0x50;
                public const long m_paramsModified = 0x8;
                public const long m_proxyReadParams = 0x20;
                public const long m_proxyWriteParams = 0x38;
            }
            public static partial class SequenceData {
                public const long m_cycle = 0x4;
                public const long m_hSequence = 0x0;
            }
            public static partial class StanceInfo_t {
                public const long m_vPosition = 0x0;
                public const long m_flDirection = 0xC;
            }
            public static partial class CAnimActivity {
                public const long m_name = 0x0;
                public const long m_nFlags = 0x14;
                public const long m_nWeight = 0x18;
                public const long m_nActivity = 0x10;
            }
            public static partial class CAnimMovement {
                public const long v0 = 0x8;
                public const long v1 = 0xC;
                public const long angle = 0x10;
                public const long vector = 0x14;
                public const long endframe = 0x0;
                public const long position = 0x20;
                public const long motionflags = 0x4;
            }
            public static partial class CAnimNodePath {
                public const long m_path = 0x0;
                public const long m_nCount = 0x2C;
            }
            public static partial class CAnimSkeleton {
                public const long m_feet = 0x88;
                public const long m_parents = 0x70;
                public const long m_children = 0x58;
                public const long m_boneNames = 0x40;
                public const long m_morphNames = 0xA0;
                public const long m_lodBoneCounts = 0xB8;
                public const long m_localSpaceTransforms = 0x10;
                public const long m_modelSpaceTransforms = 0x28;
            }
            public static partial class CAudioAnimTag {
                public const long m_clipName = 0x58;
                public const long m_flVolume = 0x68;
                public const long m_bPlayOnClient = 0x6F;
                public const long m_bPlayOnServer = 0x6E;
                public const long m_attachmentName = 0x60;
                public const long m_bStopWhenTagEnds = 0x6C;
                public const long m_bStopWhenGraphEnds = 0x6D;
            }
            public static partial class CMorphSetData {
                public const long m_nWidth = 0x10;
                public const long m_nHeight = 0x14;
                public const long m_FlexDesc = 0x50;
                public const long m_FlexRules = 0x80;
                public const long m_morphDatas = 0x30;
                public const long m_bundleTypes = 0x18;
                public const long m_pTextureAtlas = 0x48;
                public const long m_FlexControllers = 0x68;
            }
            public static partial class CNmClothEvent {
                public const long m_type = 0x18;
                public const long m_flSpeedIn = 0x20;
                public const long m_effectName = 0x38;
                public const long m_flSpeedOut = 0x24;
                public const long m_flStiffness = 0x1C;
                public const long m_vertexSetName = 0x30;
                public const long m_flLengthSeconds = 0x28;
            }
            public static partial class CNmFootIKTask {
                public const long m_blendMode = 0x130;
                public const long m_leftTarget = 0xD0;
                public const long m_rightTarget = 0x100;
                public const long m_flBlendWeight = 0x134;
                public const long m_nLeftTargetBoneIdx = 0xC0;
                public const long m_leftTargetTransform = 0x80;
                public const long m_nRightTargetBoneIdx = 0xC4;
                public const long m_nLeftEffectorBoneIdx = 0x70;
                public const long m_rightTargetTransform = 0xA0;
                public const long m_bIsTargetInWorldSpace = 0x138;
                public const long m_nRightEffectorBoneIdx = 0x74;
                public const long m_bIsRunningFromDeserializedData = 0x139;
            }
            public static partial class CNmSampleTask {

            }
            public static partial class CNmSoundEvent {
                public const long m_name = 0x20;
                public const long m_tags = 0x38;
                public const long m_position = 0x28;
                public const long m_relevance = 0x18;
                public const long m_attachmentName = 0x30;
                public const long m_flDurationInterruptionThreshold = 0x44;
                public const long m_bContinuePlayingSoundAtDurationEnd = 0x40;
            }
            public static partial class CSeqAutoLayer {
                public const long m_end = 0x18;
                public const long m_peak = 0x10;
                public const long m_tail = 0x14;
                public const long m_flags = 0x4;
                public const long m_start = 0xC;
                public const long m_nLocalPose = 0x2;
                public const long m_nLocalReference = 0x0;
            }
            public static partial class CSeqS1SeqDesc {
                public const long m_fetch = 0x20;
                public const long m_flags = 0x10;
                public const long m_sName = 0x0;
                public const long m_footMotion = 0x108;
                public const long m_transition = 0xC8;
                public const long m_IKLockArray = 0xB0;
                public const long m_SequenceKeys = 0xD0;
                public const long m_activityArray = 0xF0;
                public const long m_autoLayerArray = 0x98;
                public const long m_nLocalWeightlist = 0x90;
                public const long m_LegacyKeyValueText = 0xE0;
            }
            public static partial class MotionDBIndex {
                public const long m_nIndex = 0x0;
            }
            public static partial class VPhysXJoint_t {
                public const long m_Tag = 0xC0;
                public const long m_nType = 0x0;
                public const long m_Frame1 = 0x10;
                public const long m_Frame2 = 0x30;
                public const long m_nBody1 = 0x2;
                public const long m_nBody2 = 0x4;
                public const long m_nFlags = 0x6;
                public const long m_SwingLimit = 0x74;
                public const long m_TwistLimit = 0x80;
                public const long m_flFriction = 0xAC;
                public const long m_flMaxForce = 0x6C;
                public const long m_LinearLimit = 0x54;
                public const long m_flMaxTorque = 0x98;
                public const long m_flElasticity = 0xB0;
                public const long m_flPlasticity = 0xB8;
                public const long m_bEnableCollision = 0x50;
                public const long m_flElasticDamping = 0xB4;
                public const long m_bEnableSwingLimit = 0x70;
                public const long m_bEnableTwistLimit = 0x7C;
                public const long m_flLinearFrequency = 0x9C;
                public const long m_bEnableLinearLimit = 0x53;
                public const long m_bEnableLinearMotor = 0x5C;
                public const long m_flAngularFrequency = 0xA4;
                public const long m_bEnableAngularMotor = 0x88;
                public const long m_flLinearDampingRatio = 0xA0;
                public const long m_flAngularDampingRatio = 0xA8;
                public const long m_vLinearTargetVelocity = 0x60;
                public const long m_vAngularTargetVelocity = 0x8C;
                public const long m_bIsLinearConstraintDisabled = 0x51;
                public const long m_bIsAngularConstraintDisabled = 0x52;
            }
            public static partial class VPhysXRange_t {
                public const long m_flMax = 0x4;
                public const long m_flMin = 0x0;
            }
            public static partial class CAddUpdateNode {
                public const long m_bApplyScale = 0x9B;
                public const long m_bUseModelSpace = 0x9A;
                public const long m_footMotionTiming = 0x94;
                public const long m_bApplyToFootMotion = 0x98;
                public const long m_bApplyChannelsSeparately = 0x99;
            }
            public static partial class CAimConstraint {
                public const long m_nUpType = 0x70;
                public const long m_qAimOffset = 0x60;
            }
            public static partial class CAnimDesc_Flag {
                public const long m_bDelta = 0x3;
                public const long m_bHidden = 0x2;
                public const long m_bLooping = 0x0;
                public const long m_bAllZeros = 0x1;
                public const long m_bModelDoc = 0x5;
                public const long m_bLegacyWorldspace = 0x4;
                public const long m_bAnimGraphAdditive = 0x7;
                public const long m_bImplicitSeqIgnoreDelta = 0x6;
            }
            public static partial class CHitBoxSetList {
                public const long m_HitBoxSets = 0x0;
            }
            public static partial class CMorphRectData {
                public const long m_nYTopDst = 0x2;
                public const long m_nXLeftDst = 0x0;
                public const long m_bundleDatas = 0x10;
                public const long m_flUWidthSrc = 0x4;
                public const long m_flVHeightSrc = 0x8;
            }
            public static partial class CMotionDataSet {
                public const long m_groups = 0x0;
                public const long m_nDimensionCount = 0x18;
            }
            public static partial class CNmLegacyEvent {
                public const long m_KV = 0x20;
                public const long m_animEventClassName = 0x18;
            }
            public static partial class CParticleInput {

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
            public static partial class CSeqCmdSeqDesc {
                public const long m_flFPS = 0x28;
                public const long m_flags = 0x10;
                public const long m_sName = 0x0;
                public const long m_eventArray = 0x48;
                public const long m_nSubCycles = 0x2C;
                public const long m_transition = 0x1C;
                public const long m_nFrameCount = 0x26;
                public const long m_activityArray = 0x60;
                public const long m_cmdLayerArray = 0x30;
                public const long m_numLocalResults = 0x2E;
                public const long m_poseSettingArray = 0x78;
                public const long m_nFrameRangeSequence = 0x24;
            }
            public static partial class CSeqMultiFetch {
                public const long m_flags = 0x0;
                public const long m_nGroupSize = 0x20;
                public const long m_nLocalPose = 0x28;
                public const long m_poseKeyArray0 = 0x30;
                public const long m_poseKeyArray1 = 0x48;
                public const long m_bFixedBlendWeight = 0x65;
                public const long m_localReferenceArray = 0x8;
                public const long m_flFixedBlendWeightVals = 0x68;
                public const long m_bCalculatePoseParameters = 0x64;
                public const long m_nLocalCyclePoseParameter = 0x60;
            }
            public static partial class CSeqTransition {
                public const long m_flFadeInTime = 0x0;
                public const long m_flFadeOutTime = 0x4;
            }
            public static partial class CStringAnimTag {

            }
            public static partial class AnimComponentID {
                public const long m_id = 0x0;
            }
            public static partial class CAnimAttachment {
                public const long m_numInfluences = 0x78;
                public const long m_influenceIndices = 0x60;
                public const long m_influenceOffsets = 0x30;
                public const long m_influenceWeights = 0x6C;
                public const long m_influenceRotations = 0x0;
            }
            public static partial class CAnimationGroup {
                public const long m_name = 0x18;
                public const long m_nFlags = 0x10;
                public const long m_decodeKey = 0x98;
                public const long m_szScripts = 0x110;
                public const long m_AdditionalExtRefs = 0x128;
                public const long m_directHSeqGroup_Handle = 0x90;
                public const long m_localHAnimArray_Handle = 0x60;
                public const long m_includedGroupArray_Handle = 0x78;
            }
            public static partial class CAnimationLayer {
                public const long m_nFlags = 0x38;
                public const long m_nOrder = 0x28;
                public const long m_flCycle = 0x10;
                public const long m_bLooping = 0x34;
                public const long m_flWeight = 0x1C;
                public const long m_hSequence = 0x0;
                public const long m_nPriority = 0x48;
                public const long m_flKillRate = 0x40;
                public const long m_flKillDelay = 0x44;
                public const long m_flPrevCycle = 0xC;
                public const long m_bSequenceFinished = 0x3C;
            }
            public static partial class CBaseConstraint {
                public const long m_name = 0x20;
                public const long m_slaves = 0x38;
                public const long m_targets = 0x48;
                public const long m_vUpVector = 0x28;
            }
            public static partial class CFlexController {
                public const long max = 0x14;
                public const long min = 0x10;
                public const long m_szName = 0x0;
                public const long m_szType = 0x8;
            }
            public static partial class CFootDefinition {
                public const long m_name = 0x0;
                public const long m_toeBoneName = 0x10;
                public const long m_vBallOffset = 0x18;
                public const long m_vHeelOffset = 0x24;
                public const long m_flFootLength = 0x30;
                public const long m_ankleBoneName = 0x8;
                public const long m_flTraceHeight = 0x38;
                public const long m_flTraceRadius = 0x3C;
                public const long m_flBindPoseDirectionMS = 0x34;
            }
            public static partial class CFootTrajectory {
                public const long m_vOffset = 0x8;
                public const long m_flProgression = 0x18;
                public const long m_flRotationOffset = 0x14;
            }
            public static partial class CLeafUpdateNode {

            }
            public static partial class CMotionSearchDB {
                public const long m_rootNode = 0x0;
                public const long m_codeIndices = 0xA0;
                public const long m_residualQuantizer = 0x80;
            }
            public static partial class CNPCPhysicsHull {
                public const long m_eType = 0x8;
                public const long m_sName = 0x0;
                public const long m_flCapsuleHeight = 0xC;
                public const long m_flCapsuleRadius = 0x10;
                public const long m_vCapsuleCenter1 = 0x14;
                public const long m_vCapsuleCenter2 = 0x20;
                public const long m_flGroundBoxWidth = 0x30;
                public const long m_flGroundBoxHeight = 0x2C;
            }
            public static partial class CNetworkedCycle {
                public const long m_resetCount = 0x28;
                public const long m_flCycleZeroTime = 0x1C;
                public const long m_flCycleUnclamped = 0x0;
                public const long m_flCyclesPerSecond = 0x10;
                public const long m_flPrevCycleUnclamped = 0x4;
            }
            public static partial class CNmContactEvent {
                public const long m_configID = 0x18;
                public const long m_audioInfo = 0x38;
                public const long m_probeBoneID = 0x20;
                public const long m_flProbeMaxDist = 0x34;
                public const long m_vBoneLocalProbeDir = 0x28;
            }
            public static partial class CNmZeroPoseTask {

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
            public static partial class CPulse_Constant {
                public const long m_Type = 0x0;
                public const long m_Value = 0x18;
            }
            public static partial class CPulse_Variable {
                public const long m_Name = 0x0;
                public const long m_Type = 0x18;
                public const long m_Metadata = 0x50;
                public const long m_Description = 0x10;
                public const long m_nKeysSource = 0x44;
                public const long m_DefaultValue = 0x30;
                public const long m_bIsObservable = 0x49;
                public const long m_nEditorNodeID = 0x4C;
                public const long m_bIsPublicBlackboardVariable = 0x48;
            }
            public static partial class CRagdollAnimTag {
                public const long m_profileName = 0x58;
            }
            public static partial class CRenderSkeleton {
                public const long m_bones = 0x0;
                public const long m_boneParents = 0x30;
                public const long m_nBoneWeightCount = 0x48;
            }
            public static partial class CRootUpdateNode {

            }
            public static partial class CSeqPoseSetting {
                public const long m_bX = 0x34;
                public const long m_bY = 0x35;
                public const long m_bZ = 0x36;
                public const long m_eType = 0x38;
                public const long m_flValue = 0x30;
                public const long m_sAttachment = 0x10;
                public const long m_sPoseParameter = 0x0;
                public const long m_sReferenceSequence = 0x20;
            }
            public static partial class CSeqSeqDescFlag {
                public const long m_bPost = 0x3;
                public const long m_bSnap = 0x1;
                public const long m_bMulti = 0x5;
                public const long m_bHidden = 0x4;
                public const long m_bLooping = 0x0;
                public const long m_bAutoplay = 0x2;
                public const long m_bModelDoc = 0xA;
                public const long m_bLegacyDelta = 0x6;
                public const long m_bLegacyRealtime = 0x9;
                public const long m_bLegacyCyclepose = 0x8;
                public const long m_bLegacyWorldspace = 0x7;
            }
            public static partial class FootFixedData_t {
                public const long m_nTagIndex = 0x38;
                public const long m_nFootIndex = 0x34;
                public const long m_vToeOffset = 0x0;
                public const long m_vHeelOffset = 0x10;
                public const long m_ikChainIndex = 0x2C;
                public const long m_flMaxIKLength = 0x30;
                public const long m_nAnkleBoneIndex = 0x24;
                public const long m_nTargetBoneIndex = 0x20;
                public const long m_flMaxRotationLeft = 0x3C;
                public const long m_flMaxRotationRight = 0x40;
                public const long m_nIKAnchorBoneIndex = 0x28;
            }
            public static partial class FootStepTrigger {
                public const long m_tags = 0x0;
                public const long m_nFootIndex = 0x18;
                public const long m_triggerPhase = 0x1C;
            }
            public static partial class IParticleEffect {

            }
            public static partial class MaterialGroup_t {
                public const long m_name = 0x0;
                public const long m_materials = 0x8;
            }
            public static partial class MoodAnimation_t {
                public const long m_sName = 0x0;
                public const long m_flWeight = 0x8;
            }
            public static partial class MotionBlendItem {
                public const long m_pChild = 0x0;
                public const long m_flKeyValue = 0x8;
            }
            public static partial class MotionSelection {
                public const long m_nSample = 0x54;
                public const long m_flStartTime = 0x48;
                public const long m_nConfigIndex = 0x24;
                public const long m_flCycleZeroTime = 0x30;
                public const long m_flPlaybackSpeed = 0x3C;
            }
            public static partial class PermModelData_t {
                public const long m_name = 0x0;
                public const long m_ExtParts = 0x60;
                public const long m_modelInfo = 0x8;
                public const long m_refMeshes = 0x78;
                public const long m_meshGroups = 0x150;
                public const long m_modelSkeleton = 0x188;
                public const long m_refAnimGroups = 0x120;
                public const long m_animGraph2Refs = 0x2C8;
                public const long m_materialGroups = 0x168;
                public const long m_refPhysicsData = 0xF0;
                public const long m_remappingTable = 0x230;
                public const long m_boneFlexDrivers = 0x260;
                public const long m_pModelConfigList = 0x278;
                public const long m_refLODGroupMasks = 0xC0;
                public const long m_refMeshGroupMasks = 0x90;
                public const long m_refPhysGroupMasks = 0xA8;
                public const long m_refSequenceGroups = 0x138;
                public const long m_vecNmSkeletonRefs = 0x2E0;
                public const long m_refAnimIncludeModels = 0x298;
                public const long m_refPhysicsHitboxData = 0x108;
                public const long m_remappingTableStarts = 0x248;
                public const long m_nDefaultMeshGroupMask = 0x180;
                public const long m_BodyGroupsHiddenInTools = 0x280;
                public const long m_lodGroupSwitchDistances = 0xD8;
                public const long m_AnimatedMaterialAttributes = 0x2B0;
            }
            public static partial class PermModelInfo_t {
                public const long m_flMass = 0x34;
                public const long m_nFlags = 0x0;
                public const long m_vHullMax = 0x10;
                public const long m_vHullMin = 0x4;
                public const long m_vViewMax = 0x28;
                public const long m_vViewMin = 0x1C;
                public const long m_keyValueText = 0x50;
                public const long m_vEyePosition = 0x38;
                public const long m_sSurfaceProperty = 0x48;
                public const long m_flMaxEyeDeflection = 0x44;
            }
            public static partial class PulseCursorID_t {
                public const long m_Value = 0x0;
            }
            public static partial class TraceSettings_t {
                public const long m_flTraceHeight = 0x0;
                public const long m_flTraceRadius = 0x4;
            }
            public static partial class AnimNodeOutputID {
                public const long m_id = 0x0;
            }
            public static partial class AnimScriptHandle {
                public const long m_id = 0x0;
            }
            public static partial class CAnimParamHandle {
                public const long m_type = 0x0;
                public const long m_index = 0x1;
            }
            public static partial class CAnimReplayFrame {
                public const long m_timeStamp = 0x80;
                public const long m_instanceData = 0x28;
                public const long m_inputDataBlocks = 0x10;
                public const long m_localToWorldTransform = 0x60;
                public const long m_startingLocalToWorldTransform = 0x40;
            }
            public static partial class CBlendUpdateNode {
                public const long m_bLoop = 0xD6;
                public const long m_damping = 0xB8;
                public const long m_bIsAngle = 0xD8;
                public const long m_children = 0x60;
                public const long m_paramIndex = 0xB4;
                public const long m_bSyncCycles = 0xD5;
                public const long m_sortedOrder = 0x78;
                public const long m_blendKeyType = 0xD0;
                public const long m_targetValues = 0x90;
                public const long m_bLockWhenWaning = 0xD7;
                public const long m_blendValueSource = 0xAC;
                public const long m_bLockBlendOnReset = 0xD4;
                public const long m_eLinearRootMotionBlendMode = 0xB0;
            }
            public static partial class CConstraintSlave {
                public const long m_sName = 0x28;
                public const long m_flWeight = 0x20;
                public const long m_nBoneHash = 0x1C;
                public const long m_vBasePosition = 0x10;
                public const long m_qBaseOrientation = 0x0;
            }
            public static partial class CDrawCullingData {
                public const long m_ConeAxis = 0x0;
                public const long m_ConeCutoff = 0x3;
            }
            public static partial class CFootFallAnimTag {
                public const long m_foot = 0x58;
            }
            public static partial class CModelConfigList {
                public const long m_Configs = 0x8;
                public const long m_bHideRenderColorInTools = 0x1;
                public const long m_bHideMaterialGroupInTools = 0x0;
            }
            public static partial class CMorphBundleData {
                public const long m_ranges = 0x20;
                public const long m_offsets = 0x8;
                public const long m_flVTopSrc = 0x4;
                public const long m_flULeftSrc = 0x0;
            }
            public static partial class CMorphConstraint {
                public const long m_flMax = 0x70;
                public const long m_flMin = 0x6C;
                public const long m_sTargetMorph = 0x60;
                public const long m_nSlaveChannel = 0x68;
            }
            public static partial class CMoverUpdateNode {
                public const long m_damping = 0x78;
                public const long m_bAdditive = 0xA4;
                public const long m_bLimitOnly = 0xA8;
                public const long m_facingTarget = 0x90;
                public const long m_hMoveVecParam = 0x94;
                public const long m_bApplyMovement = 0xA5;
                public const long m_bApplyRotation = 0xA7;
                public const long m_bOrientMovement = 0xA6;
                public const long m_hTurnToFaceParam = 0x98;
                public const long m_flTurnToFaceLimit = 0xA0;
                public const long m_hMoveHeadingParam = 0x96;
                public const long m_flTurnToFaceOffset = 0x9C;
            }
            public static partial class CNmBlendTaskBase {

            }
            public static partial class CNmGraphInstance {

            }
            public static partial class CNmParticleEvent {
                public const long m_tags = 0x30;
                public const long m_type = 0x1C;
                public const long m_config = 0x60;
                public const long m_target = 0x20;
                public const long m_relevance = 0x18;
                public const long m_bPlayEndCap = 0x3A;
                public const long m_attachmentType0 = 0x48;
                public const long m_attachmentType1 = 0x58;
                public const long m_effectForConfig = 0x68;
                public const long m_hParticleSystem = 0x28;
                public const long m_attachmentPoint0 = 0x40;
                public const long m_attachmentPoint1 = 0x50;
                public const long m_bDetachFromOwner = 0x39;
                public const long m_bStopImmediately = 0x38;
            }
            public static partial class CNmTwoBoneIKTask {
                public const long m_targetTransform = 0x80;
                public const long m_nEffectorBoneIdx = 0x70;
                public const long m_nEffectorTargetBoneIdx = 0x74;
            }
            public static partial class CParticleAnimTag {
                public const long m_bAggregate = 0x71;
                public const long m_configName = 0x68;
                public const long m_attachmentName = 0x78;
                public const long m_attachmentType = 0x80;
                public const long m_hParticleSystem = 0x58;
                public const long m_bDetachFromOwner = 0x70;
                public const long m_bStopWhenTagEnds = 0x72;
                public const long m_attachmentCP1Name = 0x88;
                public const long m_attachmentCP1Type = 0x90;
                public const long m_particleSystemName = 0x60;
                public const long m_bTagEndStopIsInstant = 0x73;
            }
            public static partial class CPointConstraint {

            }
            public static partial class CPulseExecCursor {

            }
            public static partial class CSceneObjectData {
                public const long m_meshlets = 0x38;
                public const long m_drawCalls = 0x18;
                public const long m_drawBounds = 0x28;
                public const long m_vMaxBounds = 0xC;
                public const long m_vMinBounds = 0x0;
                public const long m_vTintColor = 0x58;
                public const long m_rtProxyDrawCalls = 0x48;
            }
            public static partial class CSeqBoneMaskList {
                public const long m_sName = 0x0;
                public const long m_nLocalBoneArray = 0x10;
                public const long m_flBoneWeightArray = 0x28;
                public const long m_morphCtrlWeightArray = 0x48;
                public const long m_flDefaultMorphCtrlWeight = 0x40;
            }
            public static partial class CStateUpdateData {
                public const long m_name = 0x0;
                public const long m_actions = 0x28;
                public const long m_hScript = 0x8;
                public const long m_stateID = 0x40;
                public const long m_bIsEndState = 0x0;
                public const long m_bIsStartState = 0x0;
                public const long m_bIsPassthrough = 0x0;
                public const long m_transitionIndices = 0x10;
                public const long m_bIsPassthroughRootMotion = 0x0;
                public const long m_bPreEvaluatePassthroughTransitionPath = 0x0;
            }
            public static partial class CStaticPoseCache {
                public const long m_poses = 0x10;
                public const long m_nBoneCount = 0x28;
                public const long m_nMorphCount = 0x2C;
            }
            public static partial class CTwistConstraint {
                public const long m_bInverse = 0x60;
                public const long m_qChildBindRotation = 0x80;
                public const long m_qParentBindRotation = 0x70;
            }
            public static partial class CUnaryUpdateNode {
                public const long m_pChildNode = 0x60;
            }
            public static partial class CVectorQuantizer {
                public const long m_nCentroids = 0x18;
                public const long m_nDimensions = 0x1C;
                public const long m_centroidVectors = 0x0;
            }
            public static partial class PGDInstruction_t {
                public const long m_nVar = 0x4;
                public const long m_nCode = 0x0;
                public const long m_nReg0 = 0x8;
                public const long m_nReg1 = 0xA;
                public const long m_nReg2 = 0xC;
                public const long m_nChunk = 0x14;
                public const long m_nConstIdx = 0x20;
                public const long m_nTempVarIdx = 0x26;
                public const long m_nCallInfoIndex = 0x1C;
                public const long m_nDomainValueIdx = 0x22;
                public const long m_nDestInstruction = 0x18;
                public const long m_nInvokeBindingIndex = 0x10;
                public const long m_nBlackboardReferenceIdx = 0x24;
            }
            public static partial class PairedSequence_t {
                public const long m_sRole = 0x0;
                public const long m_hSequence = 0x10;
                public const long m_sSequenceName = 0x8;
            }
            public static partial class PulseDocNodeID_t {
                public const long m_Value = 0x0;
            }
            public static partial class SkeletonDemoDb_t {
                public const long m_CameraTrack = 0x18;
                public const long m_AnimCaptures = 0x0;
                public const long m_flRecordingTime = 0x30;
            }
            public static partial class VPhysXBodyPart_t {
                public const long m_flMass = 0x4;
                public const long m_nFlags = 0x0;
                public const long m_rnShape = 0x8;
                public const long m_nReserved = 0x72;
                public const long m_flLinearDrag = 0x80;
                public const long m_flAngularDrag = 0x84;
                public const long m_flInertiaScale = 0x74;
                public const long m_flLinearDamping = 0x78;
                public const long m_flAngularDamping = 0x7C;
                public const long m_bOverrideMassCenter = 0x88;
                public const long m_vMassCenterOverride = 0x8C;
                public const long m_nCollisionAttributeIndex = 0x70;
            }
            public static partial class CAnimFrameSegment {
                public const long m_container = 0x10;
                public const long m_nLocalChannel = 0x8;
                public const long m_nUniqueFrameIndex = 0x0;
                public const long m_nLocalElementMasks = 0x4;
            }
            public static partial class CAnimInputDamping {
                public const long m_fSpeedScale = 0xC;
                public const long m_speedFunction = 0x8;
                public const long m_fFallingSpeedScale = 0x10;
            }
            public static partial class CBinaryUpdateNode {
                public const long m_pChild1 = 0x60;
                public const long m_pChild2 = 0x70;
                public const long m_bResetChild1 = 0x88;
                public const long m_bResetChild2 = 0x89;
                public const long m_flTimingBlend = 0x84;
                public const long m_timingBehavior = 0x80;
            }
            public static partial class CBodyGroupAnimTag {
                public const long m_nPriority = 0x58;
                public const long m_bodyGroupSettings = 0x60;
            }
            public static partial class CBodyGroupSetting {
                public const long m_BodyGroupName = 0x0;
                public const long m_nBodyGroupOption = 0x8;
            }
            public static partial class CChoiceUpdateNode {
                public const long m_weights = 0x78;
                public const long m_children = 0x60;
                public const long m_blendTime = 0xB4;
                public const long m_bCrossFade = 0xB8;
                public const long m_blendTimes = 0x90;
                public const long m_blendMethod = 0xB0;
                public const long m_bResetChosen = 0xB9;
                public const long m_choiceMethod = 0xA8;
                public const long m_choiceChangeMethod = 0xAC;
                public const long m_bDontResetSameSelection = 0xBA;
            }
            public static partial class CChoreoUpdateNode {

            }
            public static partial class CConstraintTarget {
                public const long m_sName = 0x40;
                public const long m_qOffset = 0x20;
                public const long m_vOffset = 0x30;
                public const long m_flWeight = 0x48;
                public const long m_nBoneHash = 0x3C;
                public const long m_bIsAttachment = 0x59;
            }
            public static partial class CFootTrajectories {
                public const long m_trajectories = 0x0;
            }
            public static partial class CIntAnimParameter {
                public const long m_maxValue = 0x88;
                public const long m_minValue = 0x84;
                public const long m_defaultValue = 0x80;
            }
            public static partial class CLookAtUpdateNode {
                public const long m_target = 0x148;
                public const long m_paramIndex = 0x14C;
                public const long m_bResetChild = 0x150;
                public const long m_bLockWhenWaning = 0x151;
                public const long m_opFixedSettings = 0x70;
                public const long m_weightParamIndex = 0x14E;
            }
            public static partial class CMotionGraphGroup {
                public const long m_searchDB = 0x0;
                public const long m_motionGraphs = 0xB8;
                public const long m_sampleToConfig = 0xE8;
                public const long m_hIsActiveScript = 0x100;
                public const long m_motionGraphConfigs = 0xD0;
            }
            public static partial class CMotionSearchNode {
                public const long m_children = 0x0;
                public const long m_quantizer = 0x18;
                public const long m_sampleCodes = 0x38;
                public const long m_sampleIndices = 0x50;
                public const long m_selectableSamples = 0x68;
            }
            public static partial class CNmBodyGroupEvent {
                public const long m_target = 0x18;
                public const long m_groupName = 0x20;
                public const long m_choiceName = 0x28;
            }
            public static partial class CNmBoneWeightList {
                public const long m_boneIDs = 0xE0;
                public const long m_weights = 0xF8;
                public const long m_skeletonName = 0x0;
            }
            public static partial class CNmCameraDOFEvent {
                public const long m_curve = 0x18;
            }
            public static partial class CNmCameraFOVEvent {
                public const long m_curve = 0x18;
            }
            public static partial class CNmFollowBoneTask {

            }
            public static partial class CNmFrameSnapEvent {
                public const long m_frameSnapMode = 0x18;
            }
            public static partial class CNmRootMotionData {
                public const long m_nNumFrames = 0x18;
                public const long m_totalDelta = 0x30;
                public const long m_transforms = 0x0;
                public const long m_flAverageLinearVelocity = 0x1C;
                public const long m_flAverageAngularVelocityRadians = 0x20;
            }
            public static partial class COrientConstraint {

            }
            public static partial class CParamSpanUpdater {
                public const long m_spans = 0x0;
            }
            public static partial class CParentConstraint {

            }
            public static partial class CParticleProperty {

            }
            public static partial class CParticleVecInput {
                public const long m_nType = 0x10;
                public const long m_Gradient = 0x6A8;
                public const long m_NamedValue = 0x28;
                public const long m_vRandomMax = 0x6CC;
                public const long m_vRandomMin = 0x6C0;
                public const long m_FloatInterp = 0x510;
                public const long m_LiteralColor = 0x20;
                public const long m_nControlPoint = 0x7C;
                public const long m_vCPValueScale = 0x84;
                public const long m_vLiteralValue = 0x14;
                public const long m_flInterpInput0 = 0x688;
                public const long m_flInterpInput1 = 0x68C;
                public const long m_vCPRelativeDir = 0x9C;
                public const long m_vInterpOutput0 = 0x690;
                public const long m_vInterpOutput1 = 0x69C;
                public const long m_FloatComponentX = 0xA8;
                public const long m_FloatComponentY = 0x220;
                public const long m_FloatComponentZ = 0x398;
                public const long m_nVectorAttribute = 0x6C;
                public const long m_bFollowNamedValue = 0x68;
                public const long m_nDeltaControlPoint = 0x80;
                public const long m_vCPRelativePosition = 0x90;
                public const long m_vVectorAttributeScale = 0x70;
            }
            public static partial class CProductQuantizer {
                public const long m_nDimensions = 0x18;
                public const long m_subQuantizers = 0x0;
            }
            public static partial class CSeqAutoLayerFlag {
                public const long m_bPose = 0x5;
                public const long m_bPost = 0x0;
                public const long m_bLocal = 0x4;
                public const long m_bXFade = 0x2;
                public const long m_bSpline = 0x1;
                public const long m_bNoBlend = 0x3;
                public const long m_bSubtract = 0x7;
                public const long m_bFetchFrame = 0x6;
            }
            public static partial class CSeqPoseParamDesc {
                public const long m_flEnd = 0x14;
                public const long m_sName = 0x0;
                public const long m_flLoop = 0x18;
                public const long m_flStart = 0x10;
                public const long m_bLooping = 0x1C;
            }
            public static partial class CSeqSynthAnimDesc {
                public const long m_flags = 0x10;
                public const long m_sName = 0x0;
                public const long m_transition = 0x1C;
                public const long m_activityArray = 0x28;
                public const long m_nLocalBoneMask = 0x26;
                public const long m_nLocalBaseReference = 0x24;
            }
            public static partial class CSequenceTagSpans {
                public const long m_tags = 0x8;
                public const long m_sSequenceName = 0x0;
            }
            public static partial class FootFixedSettings {
                public const long m_nFootIndex = 0x3C;
                public const long m_traceSettings = 0x0;
                public const long m_bEnableTracing = 0x30;
                public const long m_flFootBaseLength = 0x20;
                public const long m_nDisableTagIndex = 0x38;
                public const long m_flMaxRotationLeft = 0x24;
                public const long m_flTraceAngleBlend = 0x34;
                public const long m_flMaxRotationRight = 0x28;
                public const long m_footstepLandedTagIndex = 0x2C;
                public const long m_vFootBaseBindPosePositionMS = 0x10;
            }
            public static partial class NetVarConfigIndex {
                public const long m_index = 0x0;
            }
            public static partial class NmSyncTrackTime_t {
                public const long m_nEventIdx = 0x0;
                public const long m_percentageThrough = 0x4;
            }
            public static partial class ParamSpanSample_t {
                public const long m_value = 0x0;
                public const long m_flCycle = 0x14;
            }
            public static partial class PerTickSettings_t {
                public const long m_bAwaken = 0x6B4;
                public const long m_updateID = 0x69C;
                public const long m_bIsClient = 0x6B6;
                public const long m_rootMotion = 0x60;
                public const long m_bTeleported = 0x6B5;
                public const long m_bIsPredicted = 0x6B7;
                public const long m_flLastTimeStep = 0x6A4;
                public const long m_flNextAnimTime = 0x6AC;
                public const long m_flPrevAnimTime = 0x6A8;
                public const long m_prevLocalToWorld = 0x20;
                public const long m_finalLocalToWorld = 0x40;
                public const long m_startingLocalToWorld = 0x0;
            }
            public static partial class PhysShapeMarkup_t {
                public const long m_sHitGroup = 0x8;
                public const long m_nShapeInBody = 0x4;
                public const long m_nBodyInAggregate = 0x0;
            }
            public static partial class AttachmentHandle_t {
                public const long m_Value = 0x0;
            }
            public static partial class CAnimActionUpdater {

            }
            public static partial class CAnimEncodedFrames {
                public const long m_nFrames = 0x10;
                public const long m_fileName = 0x0;
                public const long m_frameblockArray = 0x18;
                public const long m_nFramesPerBlock = 0x14;
                public const long m_usageDifferences = 0x30;
            }
            public static partial class CAnimParameterBase {
                public const long m_id = 0x30;
                public const long m_name = 0x18;
                public const long m_group = 0x28;
                public const long m_sComment = 0x20;
                public const long m_bIsReferenced = 0x69;
                public const long m_componentName = 0x48;
                public const long m_bNetworkingRequested = 0x68;
            }
            public static partial class CAnimScriptManager {
                public const long m_scriptInfo = 0x10;
            }
            public static partial class CAnimUpdateNodeRef {
                public const long m_nodeIndex = 0x8;
            }
            public static partial class CBlend2DUpdateNode {
                public const long m_tags = 0x78;
                public const long m_bLoop = 0xF0;
                public const long m_items = 0x60;
                public const long m_paramX = 0xDC;
                public const long m_paramY = 0xE4;
                public const long m_damping = 0xC0;
                public const long m_eBlendMode = 0xE8;
                public const long m_paramSpans = 0x90;
                public const long m_blendSourceX = 0xD8;
                public const long m_blendSourceY = 0xE0;
                public const long m_playbackSpeed = 0xEC;
                public const long m_bLockWhenWaning = 0xF2;
                public const long m_nodeItemIndices = 0xA8;
                public const long m_bLockBlendOnReset = 0xF1;
                public const long m_bAnimEventsAndTagsOnMostWeightedOnly = 0xF3;
            }
            public static partial class CBoneConstraintRbf {
                public const long m_inputBones = 0x20;
                public const long m_outputBones = 0x38;
            }
            public static partial class CBoolAnimParameter {
                public const long m_bDefaultValue = 0x80;
            }
            public static partial class CEnumAnimParameter {
                public const long m_enumOptions = 0x90;
                public const long m_defaultValue = 0x88;
                public const long m_vecEnumReferenced = 0xA8;
            }
            public static partial class CMeshletDescriptor {
                public const long m_PackedAABB = 0x0;
                public const long m_nBoneIndex = 0x16;
                public const long m_CullingData = 0x8;
                public const long m_nVertexCount = 0x14;
                public const long m_nVertexOffset = 0xC;
                public const long m_nTriangleCount = 0x15;
                public const long m_nTriangleOffset = 0x10;
            }
            public static partial class CMotionGraphConfig {
                public const long m_flDuration = 0x10;
                public const long m_paramValues = 0x0;
                public const long m_nMotionIndex = 0x14;
                public const long m_nSampleCount = 0x1C;
                public const long m_nSampleStart = 0x18;
            }
            public static partial class CMotionNodeBlend1D {
                public const long m_blendItems = 0x28;
                public const long m_nParamIndex = 0x40;
            }
            public static partial class CMoverInstanceData {
                public const long m_Rotation = 0x1C;
                public const long m_vMovement = 0x4;
                public const long m_flDampedValue = 0x0;
                public const long m_TargetOrientation = 0x20;
            }
            public static partial class CNewParticleEffect {
                public const long m_pNext = 0x10;
                public const long m_pPrev = 0x18;
                public const long m_hOwner = 0x50;
                public const long m_LastMax = 0x88;
                public const long m_LastMin = 0x7C;
                public const long m_bRemove = 0x0;
                public const long m_flScale = 0x4C;
                public const long m_RefCount = 0xD0;
                public const long m_bSimulate = 0x0;
                public const long m_bAllocated = 0x0;
                public const long m_bCanFreeze = 0x0;
                public const long m_pDebugName = 0x28;
                public const long m_pParticles = 0x20;
                public const long m_bDontRemove = 0x0;
                public const long m_bShouldSave = 0x0;
                public const long m_vSortOrigin = 0x40;
                public const long m_bForceNoDraw = 0x0;
                public const long m_bIsFirstFrame = 0x0;
                public const long m_bIsAsyncCreate = 0x0;
                public const long m_bAutoUpdateBBox = 0x0;
                public const long m_bShouldCheckFoW = 0x0;
                public const long m_bNeedsBBoxUpdate = 0x0;
                public const long m_nSplitScreenUser = 0x94;
                public const long m_bFreezeTargetState = 0x0;
                public const long m_vecAggregationCenter = 0x98;
                public const long m_bFreezeTransitionActive = 0x0;
                public const long m_bShouldPerformCullCheck = 0x0;
                public const long m_flFreezeTransitionStart = 0x70;
                public const long m_pOwningParticleProperty = 0x58;
                public const long m_bSuppressScreenSpaceEffect = 0x0;
                public const long m_flFreezeTransitionDuration = 0x74;
                public const long m_flFreezeTransitionOverride = 0x78;
                public const long m_bShouldSimulateDuringGamePaused = 0x0;
            }
            public static partial class CNmChainLookatTask {

            }
            public static partial class CNmFloatCurveEvent {
                public const long m_ID = 0x18;
                public const long m_curve = 0x20;
            }
            public static partial class CNmGraphDefinition {
                public const long m_skeleton = 0x8;
                public const long m_nodePaths = 0x150;
                public const long m_pUserData = 0x28;
                public const long m_resources = 0x168;
                public const long m_variationID = 0x0;
                public const long m_nRootNodeIdx = 0x48;
                public const long m_externalPoseSlots = 0xC8;
                public const long m_externalGraphSlots = 0xB0;
                public const long m_controlParameterIDs = 0x50;
                public const long m_virtualParameterIDs = 0x68;
                public const long m_referencedGraphSlots = 0x98;
                public const long m_persistentNodeIndices = 0x30;
                public const long m_supportedSecondarySkeletons = 0x10;
                public const long m_virtualParameterNodeIndices = 0x80;
            }
            public static partial class CNmRootMotionEvent {
                public const long m_flBlendTimeSeconds = 0x18;
            }
            public static partial class CNmTargetWarpEvent {
                public const long m_rule = 0x18;
                public const long m_algorithm = 0x19;
            }
            public static partial class CNmTransitionEvent {
                public const long m_ID = 0x20;
                public const long m_rule = 0x18;
            }
            public static partial class CPulseCell_Unknown {
                public const long m_UnknownKeys = 0x48;
            }
            public static partial class CPulse_DomainValue {
                public const long m_Value = 0x8;
                public const long m_nType = 0x0;
                public const long m_RequiredRuntimeType = 0x10;
            }
            public static partial class CPulse_ResumePoint {

            }
            public static partial class CPulse_TempVarInfo {
                public const long m_Name = 0x0;
                public const long m_Type = 0x10;
                public const long m_bIsObservable = 0x2C;
                public const long m_nEditorNodeID = 0x28;
            }
            public static partial class CRagdollUpdateNode {
                public const long m_nWeightListIndex = 0x70;
                public const long m_poseControlMethod = 0x74;
            }
            public static partial class CSeqMultiFetchFlag {
                public const long m_b0D = 0x2;
                public const long m_b1D = 0x3;
                public const long m_b2D = 0x4;
                public const long m_b2D_TRI = 0x5;
                public const long m_bCylepose = 0x1;
                public const long m_bRealtime = 0x0;
            }
            public static partial class CSequenceGroupData {
                public const long m_sName = 0x10;
                public const long m_nFlags = 0x20;
                public const long m_keyValues = 0x110;
                public const long m_localNodeName = 0xE8;
                public const long m_localBoneMaskArray = 0xA0;
                public const long m_localBoneNameArray = 0xD0;
                public const long m_localScaleSetArray = 0xB8;
                public const long m_localPoseParamArray = 0xF8;
                public const long m_localS1SeqDescArray = 0x40;
                public const long m_localCmdSeqDescArray = 0x88;
                public const long m_localMultiSeqDescArray = 0x58;
                public const long m_localSequenceNameArray = 0x28;
                public const long m_localSynthAnimDescArray = 0x70;
                public const long m_localIKAutoplayLockArray = 0x120;
            }
            public static partial class CTaskStatusAnimTag {

            }
            public static partial class ChainToSolveData_t {
                public const long m_nChainIndex = 0x0;
                public const long m_DebugSetting = 0x38;
                public const long m_vDebugOffset = 0x40;
                public const long m_SolverSettings = 0x4;
                public const long m_TargetSettings = 0x10;
                public const long m_flDebugNormalizedValue = 0x3C;
            }
            public static partial class IKSolverSettings_t {
                public const long m_SolverType = 0x0;
                public const long m_nNumIterations = 0x4;
                public const long m_EndEffectorRotationFixUpMode = 0x8;
            }
            public static partial class IKTargetSettings_t {
                public const long m_Bone = 0x8;
                public const long m_TargetSource = 0x0;
                public const long m_TargetCoordSystem = 0x20;
                public const long m_AnimgraphParameterNamePosition = 0x18;
                public const long m_AnimgraphParameterNameOrientation = 0x1C;
            }
            public static partial class PARTICLE_EHANDLE__ {
                public const long unused = 0x0;
            }
            public static partial class PairedSequenceData {
                public const long m_vecPairedSequences = 0x0;
            }
            public static partial class PermModelExtPart_t {
                public const long m_Name = 0x20;
                public const long m_nParent = 0x28;
                public const long m_refModel = 0x30;
                public const long m_Transform = 0x0;
            }
            public static partial class PhysSoftbodyDesc_t {
                public const long m_Springs = 0x30;
                public const long m_Capsules = 0x48;
                public const long m_InitPose = 0x60;
                public const long m_Particles = 0x18;
                public const long m_ParticleBoneHash = 0x0;
                public const long m_ParticleBoneName = 0x78;
            }
            public static partial class PulseRegisterMap_t {
                public const long m_Inparams = 0x0;
                public const long m_Outparams = 0x20;
                public const long m_InparamsWhichCanBeMoved = 0x10;
            }
            public static partial class AnimationSnapshot_t {
                public const long m_modelName = 0x118;
                public const long m_nEntIndex = 0x110;
            }
            public static partial class CAnimBoneDifference {
                public const long m_name = 0x0;
                public const long m_parent = 0x10;
                public const long m_posError = 0x20;
                public const long m_bHasMovement = 0x2D;
                public const long m_bHasRotation = 0x2C;
            }
            public static partial class CAnimFrameBlockAnim {
                public const long m_nEndFrame = 0x4;
                public const long m_nStartFrame = 0x0;
                public const long m_segmentIndexArray = 0x8;
            }
            public static partial class CAnimLocalHierarchy {
                public const long m_sBone = 0x0;
                public const long m_nEndFrame = 0x2C;
                public const long m_nPeakFrame = 0x24;
                public const long m_nTailFrame = 0x28;
                public const long m_sNewParent = 0x10;
                public const long m_nStartFrame = 0x20;
            }
            public static partial class CAnimParamHandleMap {
                public const long m_list = 0x0;
            }
            public static partial class CAnimSequenceParams {
                public const long m_flFadeInTime = 0x0;
                public const long m_flFadeOutTime = 0x4;
            }
            public static partial class CAnimUpdateNodeBase {
                public const long m_name = 0x50;
                public const long m_nodePath = 0x18;
                public const long m_networkMode = 0x48;
            }
            public static partial class CAnimUserDifference {
                public const long m_name = 0x0;
                public const long m_nType = 0x10;
            }
            public static partial class CBindPoseUpdateNode {

            }
            public static partial class CBoneConstraintBase {

            }
            public static partial class CBoneMaskUpdateNode {
                public const long m_blendSpace = 0x9C;
                public const long m_bUseBlendScale = 0xA4;
                public const long m_hBlendParameter = 0xAC;
                public const long m_blendValueSource = 0xA8;
                public const long m_footMotionTiming = 0xA0;
                public const long m_nWeightListIndex = 0x94;
                public const long m_flRootMotionBlend = 0x98;
            }
            public static partial class CChoiceInstanceData {
                public const long m_currentChoice = 0x10;
                public const long m_previousChoice = 0x1C;
                public const long m_flClipStartTime = 0x20;
                public const long m_choicePreviousCycle = 0x2C;
            }
            public static partial class CChoreoInstanceData {
                public const long m_AnimOverlay = 0x0;
            }
            public static partial class CFloatAnimParameter {
                public const long m_fMaxValue = 0x88;
                public const long m_fMinValue = 0x84;
                public const long m_bInterpolate = 0x8C;
                public const long m_fDefaultValue = 0x80;
            }
            public static partial class CFootLockUpdateNode {
                public const long m_bResetChild = 0x153;
                public const long m_flBlendTime = 0x13C;
                public const long m_footSettings = 0xE0;
                public const long m_bApplyHipShift = 0x151;
                public const long m_flHipShiftScale = 0x138;
                public const long m_hipShiftDamping = 0xF8;
                public const long m_opFixedSettings = 0x70;
                public const long m_rootHeightDamping = 0x110;
                public const long m_flStrideCurveScale = 0x128;
                public const long m_bModulateStepHeight = 0x152;
                public const long m_flMaxRootHeightOffset = 0x140;
                public const long m_flMinRootHeightOffset = 0x144;
                public const long m_flStrideCurveLimitScale = 0x12C;
                public const long m_bApplyFootRotationLimits = 0x150;
                public const long m_bEnableRootHeightDamping = 0x155;
                public const long m_flStepHeightDecreaseScale = 0x134;
                public const long m_flStepHeightIncreaseScale = 0x130;
                public const long m_bEnableVerticalCurvedPaths = 0x154;
                public const long m_flTiltPlaneRollSpringStrength = 0x14C;
                public const long m_flTiltPlanePitchSpringStrength = 0x148;
            }
            public static partial class CHitReactUpdateNode {
                public const long m_bResetChild = 0xCC;
                public const long m_hitBoneParam = 0xBE;
                public const long m_triggerParam = 0xBC;
                public const long m_hitOffsetParam = 0xC0;
                public const long m_opFixedSettings = 0x70;
                public const long m_hitStrengthParam = 0xC4;
                public const long m_hitDirectionParam = 0xC2;
                public const long m_flMinDelayBetweenHits = 0xC8;
            }
            public static partial class CModelConfigElement {
                public const long m_ElementName = 0x8;
                public const long m_NestedElements = 0x10;
            }
            public static partial class CMotionNodeSequence {
                public const long m_tags = 0x28;
                public const long m_hSequence = 0x40;
                public const long m_flPlaybackSpeed = 0x44;
            }
            public static partial class CNmFloatChannelData {
                public const long m_setID = 0x8;
                public const long m_skeleton = 0x0;
                public const long m_compressedData = 0x28;
                public const long m_channelSettings = 0x10;
                public const long m_compressedOffsets = 0x40;
            }
            public static partial class CNmOverlayBlendTask {

            }
            public static partial class CParticleFloatInput {
                public const long m_Curve = 0x130;
                public const long m_nType = 0x10;
                public const long m_flLOD0 = 0x98;
                public const long m_flLOD1 = 0x9C;
                public const long m_flLOD2 = 0xA0;
                public const long m_flLOD3 = 0xA4;
                public const long m_flInput0 = 0x100;
                public const long m_flInput1 = 0x104;
                public const long m_nMapType = 0x14;
                public const long m_flOutput0 = 0x108;
                public const long m_flOutput1 = 0x10C;
                public const long m_nBiasType = 0x124;
                public const long m_NamedValue = 0x20;
                public const long m_nInputMode = 0xF8;
                public const long m_nNoiseType = 0xD0;
                public const long m_nRoundType = 0x120;
                public const long m_flRandomMax = 0x78;
                public const long m_flRandomMin = 0x74;
                public const long m_nRandomMode = 0x84;
                public const long m_nRandomSeed = 0x80;
                public const long m_flMultFactor = 0xFC;
                public const long m_flNoiseScale = 0xB4;
                public const long m_bReverseOrder = 0x70;
                public const long m_flNoiseOffset = 0xC4;
                public const long m_nControlPoint = 0x60;
                public const long m_nNoiseOctaves = 0xC8;
                public const long m_flCompareValue = 0x170;
                public const long m_flLiteralValue = 0x18;
                public const long m_nNoiseModifier = 0xD4;
                public const long m_flBiasParameter = 0x128;
                public const long m_bUseBoundsCenter = 0xF4;
                public const long m_flNoiseOutputMax = 0xB0;
                public const long m_flNoiseOutputMin = 0xAC;
                public const long m_nNoiseTurbulence = 0xCC;
                public const long m_nScalarAttribute = 0x64;
                public const long m_nVectorAttribute = 0x68;
                public const long m_nVectorComponent = 0x6C;
                public const long m_flNotchedRangeMax = 0x114;
                public const long m_flNotchedRangeMin = 0x110;
                public const long m_strSnapshotSubset = 0x90;
                public const long m_bHasRandomSignFlip = 0x7C;
                public const long m_flNoCameraFallback = 0xF0;
                public const long m_vecNoiseOffsetRate = 0xB8;
                public const long m_bNoiseImgPreviewLive = 0xE4;
                public const long m_flNoiseTurbulenceMix = 0xDC;
                public const long m_flNotchedOutputInside = 0x11C;
                public const long m_flNoiseImgPreviewScale = 0xE0;
                public const long m_flNoiseTurbulenceScale = 0xD8;
                public const long m_flNotchedOutputOutside = 0x118;
                public const long m_nNoiseInputVectorAttribute = 0xA8;
            }
            public static partial class CParticleModelInput {
                public const long m_nType = 0x10;
                public const long m_NamedValue = 0x18;
                public const long m_nControlPoint = 0x58;
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
            public static partial class CPulse_PublicOutput {
                public const long m_Args = 0x18;
                public const long m_Name = 0x0;
                public const long m_Description = 0x10;
            }
            public static partial class CPulse_RegisterInfo {
                public const long m_Type = 0x8;
                public const long m_nReg = 0x0;
                public const long m_OriginName = 0x20;
                public const long m_nWrittenByInstruction = 0x58;
                public const long m_nLastReadByInstruction = 0x5C;
            }
            public static partial class CSelectorUpdateNode {
                public const long m_tags = 0x78;
                public const long m_children = 0x60;
                public const long m_nTagIndex = 0xA8;
                public const long m_blendCurve = 0x94;
                public const long m_hParameter = 0xA4;
                public const long m_flBlendTime = 0x9C;
                public const long m_eTagBehavior = 0xAC;
                public const long m_bResetOnChange = 0xB0;
                public const long m_bLockWhenWaning = 0xB1;
                public const long m_bSyncCyclesOnChange = 0xB2;
            }
            public static partial class CSequenceUpdateNode {
                public const long m_tags = 0x98;
                public const long m_duration = 0x7C;
                public const long m_hSequence = 0x78;
                public const long m_paramSpans = 0x80;
            }
            public static partial class CStateActionUpdater {
                public const long m_pAction = 0x0;
                public const long m_eBehavior = 0x8;
            }
            public static partial class CStateNodeStateData {
                public const long m_pChild = 0x0;
                public const long m_bExclusiveRootMotion = 0x0;
                public const long m_bExclusiveRootMotionFirstFrame = 0x0;
            }
            public static partial class CSubtractUpdateNode {
                public const long m_bUseModelSpace = 0x9A;
                public const long m_footMotionTiming = 0x94;
                public const long m_bApplyToFootMotion = 0x98;
                public const long m_bApplyChannelsSeparately = 0x99;
            }
            public static partial class CWarpSectionAnimTag {
                public const long m_bWarpPosition = 0x50;
                public const long m_bWarpOrientation = 0x51;
            }
            public static partial class CZeroPoseUpdateNode {

            }
            public static partial class ModelEmbeddedMesh_t {
                public const long m_Name = 0x0;
                public const long m_nDataBlock = 0x14;
                public const long m_nMeshIndex = 0x10;
                public const long m_nVBIBBlock = 0x68;
                public const long m_nMorphBlock = 0x18;
                public const long m_indexBuffers = 0x38;
                public const long m_toolsBuffers = 0x50;
                public const long m_nToolsVBBlock = 0x6C;
                public const long m_vertexBuffers = 0x20;
            }
            public static partial class ModelSkeletonData_t {
                public const long m_nFlag = 0x48;
                public const long m_nParent = 0x18;
                public const long m_boneName = 0x0;
                public const long m_boneSphere = 0x30;
                public const long m_bonePosParent = 0x60;
                public const long m_boneRotParent = 0x78;
                public const long m_boneScaleParent = 0x90;
            }
            public static partial class TwoBoneIKSettings_t {
                public const long m_flMaxTwist = 0x150;
                public const long m_targetType = 0x90;
                public const long m_nEndBoneIndex = 0x148;
                public const long m_hPositionParam = 0x124;
                public const long m_hRotationParam = 0x126;
                public const long m_bConstrainTwist = 0x14D;
                public const long m_endEffectorType = 0x0;
                public const long m_nFixedBoneIndex = 0x140;
                public const long m_targetBoneIndex = 0x120;
                public const long m_nMiddleBoneIndex = 0x144;
                public const long m_targetAttachment = 0xA0;
                public const long m_vLsFallbackHingeAxis = 0x130;
                public const long m_endEffectorAttachment = 0x10;
                public const long m_bAlwaysUseFallbackHinge = 0x128;
                public const long m_bMatchTargetOrientation = 0x14C;
            }
            public static partial class VPhysXConstraint2_t {
                public const long m_nChild = 0x6;
                public const long m_nFlags = 0x0;
                public const long m_params = 0x8;
                public const long m_nParent = 0x4;
            }
            public static partial class VPhysics2ShapeDef_t {
                public const long m_hulls = 0x20;
                public const long m_meshes = 0x30;
                public const long m_spheres = 0x0;
                public const long m_capsules = 0x10;
                public const long m_compounds = 0x40;
                public const long m_CollisionAttributeIndices = 0x50;
            }
            public static partial class CAimCameraUpdateNode {
                public const long m_opFixedSettings = 0x80;
                public const long m_hParameterPosition = 0x70;
                public const long m_hParameterCameraOnly = 0x76;
                public const long m_hParameterOrientation = 0x72;
                public const long m_hParameterPelvisOffset = 0x74;
                public const long m_hParameterCameraClearanceDistance = 0x7C;
                public const long m_hParameterWeaponDepenetrationDelta = 0x7A;
                public const long m_hParameterWeaponDepenetrationDistance = 0x78;
            }
            public static partial class CAimMatrixUpdateNode {
                public const long m_target = 0x168;
                public const long m_hSequence = 0x170;
                public const long m_paramIndex = 0x16C;
                public const long m_bResetChild = 0x174;
                public const long m_bLockWhenWaning = 0x175;
                public const long m_opFixedSettings = 0x70;
            }
            public static partial class CAnimDataChannelDesc {
                public const long m_nType = 0x24;
                public const long m_nFlags = 0x20;
                public const long m_szGrouping = 0x28;
                public const long m_szDescription = 0x38;
                public const long m_szChannelClass = 0x0;
                public const long m_szVariableName = 0x10;
                public const long m_nElementMaskArray = 0x78;
                public const long m_nElementIndexArray = 0x60;
                public const long m_szElementNameArray = 0x48;
            }
            public static partial class CAnimEventDefinition {
                public const long m_nFrame = 0x8;
                public const long m_flCycle = 0x10;
                public const long m_EventData = 0x18;
                public const long m_nEndFrame = 0xC;
                public const long m_flDuration = 0x14;
                public const long m_sEventName = 0x38;
                public const long m_sLegacyOptions = 0x28;
            }
            public static partial class CAnimMorphDifference {
                public const long m_name = 0x0;
            }
            public static partial class CBlend2DInstanceData {
                public const long m_flCycle = 0x44;
                public const long m_dampedValue = 0x8;
                public const long m_flPrevCycle = 0x48;
            }
            public static partial class CEditableMotionGraph {

            }
            public static partial class CFootCycleDefinition {
                public const long m_stanceCycle = 0x28;
                public const long m_footOffCycle = 0x30;
                public const long m_footLandCycle = 0x38;
                public const long m_footLiftCycle = 0x2C;
                public const long m_footStrikeCycle = 0x34;
                public const long m_vStancePositionMS = 0x0;
                public const long m_vToStrideStartPos = 0x1C;
                public const long m_flStanceDirectionMS = 0x18;
                public const long m_vMidpointPositionMS = 0xC;
            }
            public static partial class CLODComponentUpdater {
                public const long m_nServerLOD = 0x30;
            }
            public static partial class CNmAdditiveBlendTask {

            }
            public static partial class CNmFloatChannelSet_t {
                public const long m_ID = 0x0;
                public const long m_channelIDs = 0x8;
            }
            public static partial class CNmReferencePoseTask {

            }
            public static partial class CParticleVariableRef {
                public const long m_variableName = 0x0;
                public const long m_variableType = 0x38;
            }
            public static partial class CPathMetricEvaluator {
                public const long m_flDistance = 0x68;
                public const long m_pathTimeSamples = 0x50;
                public const long m_bExtrapolateMovement = 0x6C;
                public const long m_flMinExtrapolationSpeed = 0x70;
            }
            public static partial class CPerParticleVecInput {

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
            public static partial class CRenderBufferBinding {
                public const long m_hBuffer = 0x0;
                public const long m_nBindOffsetBytes = 0x10;
            }
            public static partial class CSymbolAnimParameter {
                public const long m_defaultValue = 0x80;
            }
            public static partial class CTiltTwistConstraint {
                public const long m_nSlaveAxis = 0x64;
                public const long m_nTargetAxis = 0x60;
            }
            public static partial class CTwoBoneIKUpdateNode {
                public const long m_opFixedData = 0x70;
            }
            public static partial class CVectorAnimParameter {
                public const long m_vectorType = 0x90;
                public const long m_bInterpolate = 0x8C;
                public const long m_defaultValue = 0x80;
            }
            public static partial class FollowAttachmentData {
                public const long m_boneIndex = 0x0;
                public const long m_attachmentHandle = 0x4;
            }
            public static partial class IKBoneNameAndIndex_t {
                public const long m_Name = 0x0;
            }
            public static partial class JiggleBoneSettings_t {
                public const long m_eSimSpace = 0x28;
                public const long m_flDamping = 0xC;
                public const long m_nBoneIndex = 0x0;
                public const long m_vBoundsMaxLS = 0x10;
                public const long m_vBoundsMinLS = 0x1C;
                public const long m_flMaxTimeStep = 0x8;
                public const long m_flSpringStrength = 0x4;
            }
            public static partial class ModelAnimGraph2Ref_t {
                public const long m_hGraph = 0x8;
                public const long m_sIdentifier = 0x0;
            }
            public static partial class MoodAnimationLayer_t {
                public const long m_sName = 0x0;
                public const long m_flFadeIn = 0x54;
                public const long m_flFadeOut = 0x58;
                public const long m_flEndOffset = 0x4C;
                public const long m_flIntensity = 0x28;
                public const long m_flNextStart = 0x3C;
                public const long m_flStartOffset = 0x44;
                public const long m_bActiveTalking = 0x9;
                public const long m_bScaleWithInts = 0x38;
                public const long m_flDurationScale = 0x30;
                public const long m_layerAnimations = 0x10;
                public const long m_bActiveListening = 0x8;
            }
            public static partial class NmContactAudioInfo_t {
                public const long m_audioTypeID = 0x8;
                public const long m_audioActionID = 0x0;
                public const long m_soundeventOverrideID = 0x10;
            }
            public static partial class RenderSkeletonBone_t {
                public const long m_bbox = 0x40;
                public const long m_boneName = 0x0;
                public const long m_parentName = 0x8;
                public const long m_invBindPose = 0x10;
                public const long m_flSphereRadius = 0x58;
            }
            public static partial class SkeletonBoneBounds_t {
                public const long m_vecSize = 0xC;
                public const long m_vecCenter = 0x0;
            }
            public static partial class CAnimComponentUpdater {
                public const long m_id = 0x20;
                public const long m_name = 0x18;
                public const long m_networkMode = 0x24;
                public const long m_bStartEnabled = 0x28;
            }
            public static partial class CAnimEncodeDifference {
                public const long m_boneArray = 0x0;
                public const long m_userArray = 0x30;
                public const long m_morphArray = 0x18;
                public const long m_bHasUserBitArray = 0x90;
                public const long m_bHasMorphBitArray = 0x78;
                public const long m_bHasMovementBitArray = 0x60;
                public const long m_bHasRotationBitArray = 0x48;
            }
            public static partial class CAnimGraphDebugReplay {
                public const long m_frameList = 0x48;
                public const long m_frameCount = 0x68;
                public const long m_startIndex = 0x60;
                public const long m_writeIndex = 0x64;
                public const long m_animGraphFileName = 0x40;
            }
            public static partial class CAnimMotorUpdaterBase {
                public const long m_name = 0x10;
                public const long m_bDefault = 0x18;
            }
            public static partial class CAnimUpdateSharedData {
                public const long m_nodes = 0x10;
                public const long m_settings = 0x78;
                public const long m_pSkeleton = 0xB0;
                public const long m_components = 0x48;
                public const long m_nodeIndexMap = 0x28;
                public const long m_rootNodePath = 0xB8;
                public const long m_scriptManager = 0x70;
                public const long m_pStaticPoseCache = 0xA8;
                public const long m_pParamListUpdater = 0x60;
                public const long m_pTagManagerUpdater = 0x68;
            }
            public static partial class CClothSettingsAnimTag {
                public const long m_flEaseIn = 0x5C;
                public const long m_flEaseOut = 0x60;
                public const long m_nVertexSet = 0x68;
                public const long m_flStiffness = 0x58;
            }
            public static partial class CEmitTagActionUpdater {
                public const long m_nTagIndex = 0x18;
                public const long m_bIsZeroDuration = 0x1C;
            }
            public static partial class CFollowPathUpdateNode {
                public const long m_hParam = 0xAC;
                public const long m_flScale = 0x7C;
                public const long m_flMaxAngle = 0x84;
                public const long m_flMinAngle = 0x80;
                public const long m_bScaleSpeed = 0x7A;
                public const long m_bTurnToFace = 0xB4;
                public const long m_turnDamping = 0x90;
                public const long m_facingTarget = 0xA8;
                public const long m_flBlendOutTime = 0x74;
                public const long m_bStopFeetAtGoal = 0x79;
                public const long m_flTurnToFaceOffset = 0xB0;
                public const long m_flSpeedScaleBlending = 0x88;
                public const long m_bBlockNonPathMovement = 0x78;
            }
            public static partial class CHandshakeAnimTagBase {
                public const long m_bIsDisableTag = 0x50;
            }
            public static partial class CJiggleBoneUpdateNode {
                public const long m_opFixedData = 0x70;
            }
            public static partial class CJumpHelperUpdateNode {
                public const long m_bScaleSpeed = 0xD3;
                public const long m_hTargetParam = 0xB0;
                public const long m_flJumpEndCycle = 0xC8;
                public const long m_bTranslationAxis = 0xD0;
                public const long m_flJumpStartCycle = 0xC4;
                public const long m_eCorrectionMethod = 0xCC;
                public const long m_flOriginalJumpDuration = 0xC0;
                public const long m_flOriginalJumpMovement = 0xB4;
            }
            public static partial class CLeanMatrixUpdateNode {
                public const long m_poses = 0x80;
                public const long m_damping = 0xA8;
                public const long m_hSequence = 0xE0;
                public const long m_flMaxValue = 0xE4;
                public const long m_paramIndex = 0xC4;
                public const long m_blendSource = 0xC0;
                public const long m_frameCorners = 0x5C;
                public const long m_verticalAxis = 0xC8;
                public const long m_horizontalAxis = 0xD4;
                public const long m_nSequenceMaxFrame = 0xE8;
            }
            public static partial class CLookComponentUpdater {
                public const long m_hLookPitch = 0x3A;
                public const long m_hLookTarget = 0x40;
                public const long m_hLookHeading = 0x34;
                public const long m_hLookDistance = 0x3C;
                public const long m_hLookDirection = 0x3E;
                public const long m_bNetworkLookTarget = 0x44;
                public const long m_hLookHeadingVelocity = 0x38;
                public const long m_hLookTargetWorldSpace = 0x42;
                public const long m_hLookHeadingNormalized = 0x36;
            }
            public static partial class CNmCachedPoseReadTask {

            }
            public static partial class CNmSyncTrack__Event_t {
                public const long m_ID = 0x0;
                public const long m_duration = 0xC;
                public const long m_startTime = 0x8;
            }
            public static partial class CPathAnimMotorUpdater {

            }
            public static partial class CPathHelperUpdateNode {
                public const long m_flStoppingRadius = 0x70;
                public const long m_flStoppingSpeedScale = 0x74;
            }
            public static partial class CPulseCell_LimitCount {
                public const long m_nLimitCount = 0x48;
            }
            public static partial class CRemapValueUpdateItem {
                public const long m_hParamIn = 0x0;
                public const long m_hParamOut = 0x2;
                public const long m_flMaxInputValue = 0x8;
                public const long m_flMinInputValue = 0x4;
                public const long m_flMaxOutputValue = 0x10;
                public const long m_flMinOutputValue = 0xC;
            }
            public static partial class CSpeedScaleUpdateNode {
                public const long m_paramIndex = 0x70;
            }
            public static partial class CStopAtGoalUpdateNode {
                public const long m_damping = 0x88;
                public const long m_flMaxScale = 0x7C;
                public const long m_flMinScale = 0x80;
                public const long m_flInnerRadius = 0x78;
                public const long m_flOuterRadius = 0x74;
            }
            public static partial class CTargetWarpUpdateNode {
                public const long m_eAngleMode = 0x74;
                public const long m_flMaxAngle = 0x94;
                public const long m_bWarpAroundCenter = 0x90;
                public const long m_eCorrectionMethod = 0x84;
                public const long m_hMoveHeadingParameter = 0x7E;
                public const long m_bOnlyWarpWhenTagIsFound = 0x8E;
                public const long m_eTargetWarpTimingMethod = 0x88;
                public const long m_hTargetPositionParameter = 0x78;
                public const long m_hTargetUpVectorParameter = 0x7A;
                public const long m_bTargetPositionIsWorldSpace = 0x8D;
                public const long m_hDesiredMoveHeadingParameter = 0x80;
                public const long m_hTargetFacePositionParameter = 0x7C;
                public const long m_bTargetFacePositionIsWorldSpace = 0x8C;
                public const long m_bWarpOrientationDuringTranslation = 0x8F;
            }
            public static partial class CTaskHandshakeAnimTag {

            }
            public static partial class CTransitionUpdateData {
                public const long m_bDisabled = 0x0;
                public const long m_srcStateIndex = 0x0;
                public const long m_destStateIndex = 0x1;
                public const long m_nHandshakeMaskToDisableFirst = 0x0;
            }
            public static partial class CTurnHelperUpdateNode {
                public const long m_facingTarget = 0x74;
                public const long m_turnDuration = 0x7C;
                public const long m_manualTurnOffset = 0x84;
                public const long m_bMatchChildDuration = 0x80;
                public const long m_turnStartTimeOffset = 0x78;
                public const long m_bUseManualTurnOffset = 0x88;
            }
            public static partial class CVirtualAnimParameter {
                public const long m_eParamType = 0x78;
                public const long m_expressionString = 0x70;
            }
            public static partial class ModelBoneFlexDriver_t {
                public const long m_boneName = 0x0;
                public const long m_controls = 0x10;
                public const long m_boneNameToken = 0x8;
            }
            public static partial class ModelMeshBufferData_t {
                public const long m_nBlockIndex = 0x0;
                public const long m_nBufferUsage = 0x14;
                public const long m_nElementCount = 0x4;
                public const long m_bCompressedZSTD = 0xF;
                public const long m_bCreateBufferSRV = 0x10;
                public const long m_bCreateBufferUAV = 0x11;
                public const long m_bCreateRawBuffer = 0x12;
                public const long m_inputLayoutFields = 0x18;
                public const long m_bMeshoptCompressed = 0xC;
                public const long m_bCreatePooledBuffer = 0x13;
                public const long m_nElementSizeInBytes = 0x8;
                public const long m_bMeshoptIndexSequence = 0xD;
                public const long m_nMeshoptMeshletEncodeVersion = 0xE;
            }
            public static partial class SkeletonAnimCapture_t {
                public const long m_Frames = 0xA8;
                public const long m_ModelName = 0x20;
                public const long m_nEntIndex = 0x0;
                public const long m_bPredicted = 0x64;
                public const long m_nEntParent = 0x4;
                public const long m_CaptureName = 0x28;
                public const long m_ModelBindPose = 0x30;
                public const long m_FeModelInitPose = 0x48;
                public const long m_nFlexControllers = 0x60;
                public const long m_ImportedCollision = 0x8;
            }
            public static partial class VPhysXAggregateData_t {
                public const long m_parts = 0x80;
                public const long m_joints = 0xC8;
                public const long m_nFlags = 0x0;
                public const long m_bindPose = 0x68;
                public const long m_pFeModel = 0xE0;
                public const long m_boneNames = 0x20;
                public const long m_bonesHash = 0x8;
                public const long m_indexHash = 0x50;
                public const long m_indexNames = 0x38;
                public const long m_boneParents = 0xE8;
                public const long m_nRefCounter = 0x2;
                public const long m_constraints2 = 0xB0;
                public const long m_shapeMarkups = 0x98;
                public const long m_debugPartNames = 0x130;
                public const long m_bCompoundsPacked = 0x4;
                public const long m_embeddedKeyvalues = 0x148;
                public const long m_collisionAttributes = 0x118;
                public const long m_surfacePropertyHashes = 0x100;
            }
            public static partial class CAnimGraphModelBinding {
                public const long m_modelName = 0x8;
                public const long m_pSharedData = 0x10;
            }
            public static partial class CAnimTagManagerUpdater {
                public const long m_tags = 0x38;
            }
            public static partial class CBlendNodeInstanceData {
                public const long m_flCycle = 0x4;
                public const long m_flDuration = 0x1C;
                public const long m_resetCount = 0x20;
                public const long m_dampedValue = 0x0;
                public const long m_flBlendValue = 0x10;
                public const long m_flPlaybackRate = 0xC;
                public const long m_flCycleZeroTime = 0x8;
            }
            public static partial class CConcreteAnimParameter {
                public const long m_bAutoReset = 0x79;
                public const long m_bGameWritable = 0x7A;
                public const long m_previewButton = 0x70;
                public const long m_bGraphWritable = 0x7B;
                public const long m_eNetworkSetting = 0x74;
                public const long m_bUseMostRecentValue = 0x78;
            }
            public static partial class CCycleClipInstanceData {
                public const long m_flCycle = 0x0;
                public const long m_flPrevCycle = 0xC;
            }
            public static partial class CDampedValueUpdateItem {
                public const long m_damping = 0x0;
                public const long m_hParamIn = 0x20;
                public const long m_hParamOut = 0x22;
            }
            public static partial class CDirectPlaybackTagData {
                public const long m_tags = 0x8;
                public const long m_sequenceName = 0x0;
            }
            public static partial class CFootPinningUpdateNode {
                public const long m_params = 0xB0;
                public const long m_bResetChild = 0xC8;
                public const long m_eTimingSource = 0xA8;
                public const long m_poseOpFixedData = 0x78;
            }
            public static partial class CFootstepLandedAnimTag {
                public const long m_BoneName = 0x70;
                public const long m_FootstepType = 0x58;
                public const long m_OverrideSoundName = 0x60;
                public const long m_footstepJumpPhase = 0x78;
                public const long m_DebugAnimSourceString = 0x68;
            }
            public static partial class CInputStreamUpdateNode {

            }
            public static partial class CMotionGraphUpdateNode {
                public const long m_pMotionGraph = 0x58;
            }
            public static partial class CMotionMetricEvaluator {
                public const long m_means = 0x18;
                public const long m_flWeight = 0x48;
                public const long m_standardDeviations = 0x30;
                public const long m_nDimensionStartIndex = 0x4C;
            }
            public static partial class CNmCachedPoseWriteTask {

            }
            public static partial class CNmModelSpaceBlendTask {

            }
            public static partial class CNmOrNode__CDefinition {
                public const long m_conditionNodeIndices = 0x10;
            }
            public static partial class CPerParticleFloatInput {

            }
            public static partial class CPhysSurfaceProperties {
                public const long m_name = 0x0;
                public const long m_bHidden = 0x18;
                public const long m_physics = 0x28;
                public const long m_nameHash = 0x8;
                public const long m_audioParams = 0xA8;
                public const long m_audioSounds = 0x48;
                public const long m_description = 0x20;
                public const long m_baseNameHash = 0xC;
                public const long m_vehicleParams = 0x40;
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
            public static partial class CPulseRuntimeMethodArg {
                public const long m_Name = 0x0;
                public const long m_Type = 0x40;
                public const long m_Description = 0x38;
            }
            public static partial class CSingleFrameUpdateNode {
                public const long m_actions = 0x58;
                public const long m_flCycle = 0x78;
                public const long m_hSequence = 0x74;
                public const long m_hPoseCacheHandle = 0x70;
            }
            public static partial class CSlopeComponentUpdater {
                public const long m_hSlopeAngle = 0x38;
                public const long m_hSlopeNormal = 0x40;
                public const long m_hSlopeHeading = 0x3E;
                public const long m_flTraceDistance = 0x34;
                public const long m_hSlopeAngleSide = 0x3C;
                public const long m_hSlopeAngleFront = 0x3A;
                public const long m_hSlopeNormal_WorldSpace = 0x42;
            }
            public static partial class CSolveIKTargetHandle_t {
                public const long m_positionHandle = 0x0;
                public const long m_orientationHandle = 0x2;
            }
            public static partial class CStanceScaleUpdateNode {
                public const long m_hParam = 0x70;
            }
            public static partial class CStateNodeInstanceData {
                public const long m_resetCount = 0x3C;
                public const long m_stateWeights = 0x0;
                public const long m_currentStateStartTime = 0x20;
                public const long m_vTransitionVelocityDeltaWS = 0x8;
            }
            public static partial class NmSyncTrackTimeRange_t {
                public const long m_endTime = 0x8;
                public const long m_startTime = 0x0;
            }
            public static partial class PulseGraphInstanceID_t {
                public const long m_Value = 0x0;
            }
            public static partial class PulseRuntimeVarIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class RenderHairStrandInfo_t {
                public const long m_nPackedBaseUv = 0x18;
                public const long m_nDataOffset_Segments = 0x24;
                public const long m_vGuideBary_vBaseBary = 0x8;
                public const long m_nPackedSurfaceNormalOs = 0x1C;
                public const long m_nPackedSurfaceTangentOs = 0x20;
                public const long m_vRootOffset_flLengthScale = 0x10;
                public const long m_nGuideHairIndices_nSurfaceTriIndex = 0x0;
            }
            public static partial class SelectorInstanceData_t {
                public const long m_weights = 0x0;
                public const long m_currentIndex = 0x14;
                public const long m_previousIndex = 0x18;
                public const long m_currentIndexStartTime = 0x8;
            }
            public static partial class AnimationSnapshotBase_t {
                public const long m_DecodeDump = 0x98;
                public const long m_flRealTime = 0x0;
                public const long m_rootToWorld = 0x10;
                public const long m_SnapshotType = 0x90;
                public const long m_boneSetupMask = 0x48;
                public const long m_bHasDecodeDump = 0x94;
                public const long m_boneTransforms = 0x60;
                public const long m_flexControllers = 0x78;
                public const long m_bBonesInWorldSpace = 0x40;
            }
            public static partial class CActionComponentUpdater {
                public const long m_actions = 0x30;
            }
            public static partial class CAnimGraphSettingsGroup {

            }
            public static partial class CAnimationGraphInstance {
                public const long m_bTagDispatchDirty = 0x329;
            }
            public static partial class CBasePulseGraphInstance {

            }
            public static partial class CCycleControlUpdateNode {
                public const long m_paramIndex = 0x74;
                public const long m_valueSource = 0x70;
                public const long m_bLockWhenWaning = 0x76;
            }
            public static partial class CFollowPathInstanceData {
                public const long m_flTurnAmount = 0xC;
                public const long m_flLastPathTime = 0x1C;
                public const long m_dampedTurnValue = 0x8;
                public const long m_flPredictionScale = 0x10;
                public const long m_xLastPredictedTransformsDeltas = 0x0;
            }
            public static partial class CFollowTargetUpdateNode {
                public const long m_opFixedData = 0x70;
                public const long m_hParameterPosition = 0x88;
                public const long m_hParameterOrientation = 0x8A;
            }
            public static partial class CLeanMatrixInstanceData {
                public const long m_flValueX = 0x4;
                public const long m_flValueY = 0x0;
            }
            public static partial class CMaterialDrawDescriptor {
                public const long m_flAlpha = 0x10;
                public const long m_material = 0x118;
                public const long m_vTintColor = 0x4;
                public const long m_flUvDensity = 0x0;
                public const long m_indexBuffer = 0xC8;
                public const long m_nBaseVertex = 0x54;
                public const long m_nIndexCount = 0x60;
                public const long m_nStartIndex = 0x5C;
                public const long m_nNumMeshlets = 0x18;
                public const long m_nVertexCount = 0x58;
                public const long m_rootBvhNodes = 0x40;
                public const long m_nFirstMeshlet = 0x20;
                public const long m_nPrimitiveType = 0x50;
                public const long m_rigidMeshParts = 0x30;
                public const long m_meshletPackedIVB = 0xE8;
                public const long m_nAppliedIndexOffset = 0x24;
                public const long m_nMeshletPackedIVBIndex = 0x2D;
                public const long m_nDepthVertexBufferIndex = 0x2C;
                public const long m_nEmissivePrimitiveCount = 0x28;
            }
            public static partial class CNmAndNode__CDefinition {
                public const long m_conditionNodeIndices = 0x10;
            }
            public static partial class CNmNotNode__CDefinition {
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmOrientationWarpEvent {

            }
            public static partial class CParticleTransformInput {
                public const long m_nType = 0x10;
                public const long m_NamedValue = 0x18;
                public const long m_nControlPoint = 0x5C;
                public const long m_bUseOrientation = 0x5A;
                public const long m_bFollowNamedValue = 0x58;
                public const long m_bSupportsDisabled = 0x59;
                public const long m_flEndCPGrowthTime = 0x64;
                public const long m_nControlPointRangeMax = 0x60;
            }
            public static partial class CPulseCell_Inflow_Yield {
                public const long m_UnyieldResume = 0xD8;
            }
            public static partial class CPulseCell_ReturnValues {

            }
            public static partial class CPulse_InstructionDebug {
                public const long m_nFlowNodeID = 0x0;
                public const long m_nValueNodeID = 0x4;
                public const long m_SequencePointName = 0x8;
            }
            public static partial class CPulse_OutputConnection {
                public const long m_Param = 0x30;
                public const long m_TargetInput = 0x20;
                public const long m_SourceOutput = 0x0;
                public const long m_TargetEntity = 0x10;
            }
            public static partial class CSequenceUpdateNodeBase {
                public const long m_bLoop = 0x70;
                public const long m_playbackSpeed = 0x6C;
            }
            public static partial class CSolveIKChainUpdateNode {
                public const long m_opFixedData = 0x88;
                public const long m_targetHandles = 0x70;
            }
            public static partial class CStateMachineUpdateNode {
                public const long m_stateData = 0xC8;
                public const long m_stateMachine = 0x70;
                public const long m_transitionData = 0xE0;
                public const long m_bBlockWaningTags = 0xFC;
                public const long m_bResetWhenActivated = 0xFE;
                public const long m_bLockStateWhenWaning = 0xFD;
            }
            public static partial class CStaticPoseCacheBuilder {

            }
            public static partial class CTurnHelperInstanceData {
                public const long m_duration = 0x8;
                public const long m_turnAmount = 0x0;
                public const long m_turnStartTime = 0x4;
            }
            public static partial class CWarpSectionAnimTagBase {

            }
            public static partial class HitReactFixedSettings_t {
                public const long m_flWhipDelay = 0x20;
                public const long m_flHipDipDelay = 0x40;
                public const long m_nHipBoneIndex = 0x30;
                public const long m_flMaxImpactForce = 0x8;
                public const long m_flMinImpactForce = 0xC;
                public const long m_flSpringStrength = 0x24;
                public const long m_nWeightListIndex = 0x0;
                public const long m_flMaxAngleRadians = 0x2C;
                public const long m_flWhipImpactScale = 0x10;
                public const long m_flPropagationScale = 0x1C;
                public const long m_nEffectedBoneCount = 0x4;
                public const long m_flDistanceFadeScale = 0x18;
                public const long m_flHipDipImpactScale = 0x3C;
                public const long m_flWhipSpringStrength = 0x28;
                public const long m_flCounterRotationScale = 0x14;
                public const long m_flHipDipSpringStrength = 0x38;
                public const long m_flHipBoneTranslationScale = 0x34;
            }
            public static partial class IAnimationGraphInstance {

            }
            public static partial class IKDemoCaptureSettings_t {
                public const long m_eMode = 0x8;
                public const long m_oneBoneEnd = 0x20;
                public const long m_ikChainName = 0x10;
                public const long m_oneBoneStart = 0x18;
                public const long m_parentBoneName = 0x0;
            }
            public static partial class LookAtOpFixedSettings_t {
                public const long m_bones = 0x98;
                public const long m_damping = 0x80;
                public const long m_attachment = 0x0;
                public const long m_flYawLimit = 0xB0;
                public const long m_flPitchLimit = 0xB4;
                public const long m_bUseHysteresis = 0xC3;
                public const long m_bRotateYawForward = 0xC0;
                public const long m_bTargetIsPosition = 0xC2;
                public const long m_bMaintainUpDirection = 0xC1;
                public const long m_flHysteresisInnerAngle = 0xB8;
                public const long m_flHysteresisOuterAngle = 0xBC;
            }
            public static partial class NmCompressionSettings_t {
                public const long m_scaleRange = 0x18;
                public const long m_bIsScaleStatic = 0x42;
                public const long m_constantRotation = 0x30;
                public const long m_nTrackReadOffset = 0x20;
                public const long m_bIsRotationStatic = 0x40;
                public const long m_translationRangeX = 0x0;
                public const long m_translationRangeY = 0x8;
                public const long m_translationRangeZ = 0x10;
                public const long m_bIsTranslationStatic = 0x41;
            }
            public static partial class PulseCursorYieldToken_t {
                public const long m_Value = 0x0;
            }
            public static partial class PulseRuntimeCellIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class SignatureOutflow_Resume {

            }
            public static partial class CAnimDemoCaptureSettings {
                public const long m_bones = 0x50;
                public const long m_ikChains = 0x68;
                public const long m_baseSequence = 0x40;
                public const long m_boneSelectionMode = 0x4C;
                public const long m_nBaseSequenceFrame = 0x48;
                public const long m_vecErrorRangeSplineScale = 0x10;
                public const long m_flIkRotation_MaxSplineError = 0x18;
                public const long m_vecErrorRangeSplineRotation = 0x0;
                public const long m_flIkTranslation_MaxSplineError = 0x1C;
                public const long m_vecErrorRangeQuantizationScale = 0x30;
                public const long m_vecErrorRangeSplineTranslation = 0x8;
                public const long m_flIkRotation_MaxQuantizationError = 0x38;
                public const long m_vecErrorRangeQuantizationRotation = 0x20;
                public const long m_flIkTranslation_MaxQuantizationError = 0x3C;
                public const long m_vecErrorRangeQuantizationTranslation = 0x28;
            }
            public static partial class CAnimStateMachineUpdater {
                public const long m_states = 0x8;
                public const long m_transitions = 0x20;
                public const long m_startStateIndex = 0x50;
            }
            public static partial class CExpressionActionUpdater {
                public const long m_hParam = 0x18;
                public const long m_hScript = 0x1C;
                public const long m_eParamType = 0x1A;
            }
            public static partial class CNmClipNode__CDefinition {
                public const long m_graphEvents = 0x18;
                public const long m_nDataSlotIdx = 0x14;
                public const long m_bAllowLooping = 0x13;
                public const long m_bSampleRootMotion = 0x12;
                public const long m_flSpeedMultiplier = 0x40;
                public const long m_nStartSyncEventOffset = 0x44;
                public const long m_nResetTimeValueNodeIdx = 0x16;
                public const long m_nPlayInReverseValueNodeIdx = 0x10;
            }
            public static partial class CNmContactAudioTypeVData {

            }
            public static partial class CNmPoseNode__CDefinition {

            }
            public static partial class CParticleRemapFloatInput {

            }
            public static partial class CPulseBreakpointLocation {
                public const long m_NodeID = 0x0;
                public const long m_PortName = 0x18;
                public const long m_bDeferBreak = 0x28;
                public const long m_SequencePoint = 0x8;
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
            public static partial class CQuaternionAnimParameter {
                public const long m_bInterpolate = 0x90;
                public const long m_defaultValue = 0x80;
            }
            public static partial class CRagdollComponentUpdater {
                public const long m_boneNames = 0x78;
                public const long m_boneIndices = 0x60;
                public const long m_weightLists = 0x90;
                public const long m_flMaxStretch = 0xC8;
                public const long m_ragdollNodePaths = 0x30;
                public const long m_boneToWeightIndices = 0xA8;
                public const long m_flSpringFrequencyMax = 0xC4;
                public const long m_flSpringFrequencyMin = 0xC0;
                public const long m_followAttachmentNodePaths = 0x48;
                public const long m_bSolidCollisionAtZeroWeight = 0xCC;
            }
            public static partial class CSequenceFinishedAnimTag {
                public const long m_sequenceName = 0x58;
            }
            public static partial class CStateNodeTransitionData {
                public const long m_curve = 0x0;
                public const long m_bReset = 0x0;
                public const long m_blendDuration = 0x8;
                public const long m_resetCycleValue = 0x10;
                public const long m_resetCycleOption = 0x0;
            }
            public static partial class JiggleBoneSettingsList_t {
                public const long m_boneSettings = 0x0;
            }
            public static partial class ParticleAttributeIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class PulseRuntimeChunkIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class VPhysXConstraintParams_t {
                public const long m_axes = 0x1C;
                public const long m_nType = 0x0;
                public const long m_anchor = 0x4;
                public const long m_nFlags = 0x3;
                public const long m_maxForce = 0x3C;
                public const long m_maxTorque = 0x40;
                public const long m_driveSpringX = 0xBC;
                public const long m_driveSpringY = 0xC0;
                public const long m_driveSpringZ = 0xC4;
                public const long m_goalPosition = 0x94;
                public const long m_driveDampingX = 0xC8;
                public const long m_driveDampingY = 0xCC;
                public const long m_driveDampingZ = 0xD0;
                public const long m_nRotateMotion = 0x2;
                public const long m_goalOrientation = 0xA0;
                public const long m_driveSpringSlerp = 0xDC;
                public const long m_driveSpringSwing = 0xD8;
                public const long m_driveSpringTwist = 0xD4;
                public const long m_linearLimitValue = 0x44;
                public const long m_nTranslateMotion = 0x1;
                public const long m_swing1LimitValue = 0x74;
                public const long m_swing2LimitValue = 0x84;
                public const long m_driveDampingSlerp = 0xE8;
                public const long m_driveDampingSwing = 0xE4;
                public const long m_driveDampingTwist = 0xE0;
                public const long m_linearLimitSpring = 0x4C;
                public const long m_swing1LimitSpring = 0x7C;
                public const long m_swing2LimitSpring = 0x8C;
                public const long m_linearLimitDamping = 0x50;
                public const long m_swing1LimitDamping = 0x80;
                public const long m_swing2LimitDamping = 0x90;
                public const long m_twistLowLimitValue = 0x54;
                public const long m_goalAngularVelocity = 0xB0;
                public const long m_twistHighLimitValue = 0x64;
                public const long m_twistLowLimitSpring = 0x5C;
                public const long m_solverIterationCount = 0xEC;
                public const long m_twistHighLimitSpring = 0x6C;
                public const long m_twistLowLimitDamping = 0x60;
                public const long m_twistHighLimitDamping = 0x70;
                public const long m_linearLimitRestitution = 0x48;
                public const long m_swing1LimitRestitution = 0x78;
                public const long m_swing2LimitRestitution = 0x88;
                public const long m_twistLowLimitRestitution = 0x58;
                public const long m_projectionLinearTolerance = 0xF0;
                public const long m_twistHighLimitRestitution = 0x68;
                public const long m_projectionAngularTolerance = 0xF4;
            }
            public static partial class BoneDemoCaptureSettings_t {
                public const long m_boneName = 0x0;
                public const long m_flErrorSplineScaleMax = 0x10;
                public const long m_flErrorSplineRotationMax = 0x8;
                public const long m_flErrorQuantizationScaleMax = 0x1C;
                public const long m_flErrorSplineTranslationMax = 0xC;
                public const long m_flErrorQuantizationRotationMax = 0x14;
                public const long m_flErrorQuantizationTranslationMax = 0x18;
            }
            public static partial class CAnimGraphNetworkSettings {
                public const long m_bNetworkingEnabled = 0x20;
            }
            public static partial class CAnimGraphSettingsManager {
                public const long m_settingsGroups = 0x18;
            }
            public static partial class CBoneConstraintDotToMorph {
                public const long m_flRemap = 0x38;
                public const long m_sBoneName = 0x20;
                public const long m_sTargetBoneName = 0x28;
                public const long m_sMorphChannelName = 0x30;
            }
            public static partial class CDirectPlaybackUpdateNode {
                public const long m_allTags = 0x78;
                public const long m_bFinishEarly = 0x74;
                public const long m_bResetOnFinish = 0x75;
            }
            public static partial class CFootAdjustmentUpdateNode {
                public const long m_clips = 0x78;
                public const long m_bResetChild = 0xA8;
                public const long m_facingTarget = 0x94;
                public const long m_flTurnTimeMax = 0x9C;
                public const long m_flTurnTimeMin = 0x98;
                public const long m_flStepHeightMax = 0xA0;
                public const long m_bAnimationDriven = 0xA9;
                public const long m_flStepHeightMaxAngle = 0xA4;
                public const long m_hBasePoseCacheHandle = 0x90;
            }
            public static partial class CFootCycleMetricEvaluator {
                public const long m_footIndices = 0x50;
            }
            public static partial class CMaterialAttributeAnimTag {
                public const long m_Color = 0x68;
                public const long m_flValue = 0x64;
                public const long m_AttributeName = 0x58;
                public const long m_AttributeType = 0x60;
            }
            public static partial class CMotionMatchingUpdateNode {
                public const long m_dataSet = 0x58;
                public const long m_metrics = 0x78;
                public const long m_weights = 0x90;
                public const long m_blendCurve = 0xEC;
                public const long m_bGoalAssist = 0x109;
                public const long m_flBlendTime = 0xF8;
                public const long m_flSampleRate = 0xF4;
                public const long m_bSearchEveryTick = 0xE0;
                public const long m_flSearchInterval = 0xE4;
                public const long m_bLockClipWhenWaning = 0xFC;
                public const long m_bSearchWhenClipEnds = 0xE8;
                public const long m_flGoalAssistDistance = 0x10C;
                public const long m_flSelectionThreshold = 0x100;
                public const long m_distanceScale_Damping = 0x118;
                public const long m_flGoalAssistTolerance = 0x110;
                public const long m_bEnableDistanceScaling = 0x140;
                public const long m_bSearchWhenGoalChanges = 0xE9;
                public const long m_flReselectionTimeWindow = 0x104;
                public const long m_flDistanceScale_MaxScale = 0x138;
                public const long m_flDistanceScale_MinScale = 0x13C;
                public const long m_bEnableRotationCorrection = 0x108;
                public const long m_flDistanceScale_InnerRadius = 0x134;
                public const long m_flDistanceScale_OuterRadius = 0x130;
            }
            public static partial class CMovementComponentUpdater {
                public const long m_motors = 0x30;
                public const long m_bNetworkPath = 0x71;
                public const long m_paramHandles = 0x73;
                public const long m_facingDamping = 0x48;
                public const long m_bNetworkFacing = 0x72;
                public const long m_bMoveVarsDisabled = 0x70;
                public const long m_flDefaultRunSpeed = 0x6C;
                public const long m_nDefaultMotorIndex = 0x68;
            }
            public static partial class CMovementHandshakeAnimTag {

            }
            public static partial class CNmGraphNode__CDefinition {
                public const long m_nNodeIdx = 0x8;
            }
            public static partial class CNmGraphVariationUserData {

            }
            public static partial class CNmMaterialAttributeEvent {
                public const long m_w = 0xF0;
                public const long m_x = 0x30;
                public const long m_y = 0x70;
                public const long m_z = 0xB0;
                public const long m_target = 0x18;
                public const long m_attributeName = 0x20;
                public const long m_attributeNameToken = 0x28;
            }
            public static partial class CNmScaleNode__CDefinition {
                public const long m_nMaskNodeIdx = 0x18;
                public const long m_nEnableNodeIdx = 0x1A;
            }
            public static partial class CNmStateNode__CDefinition {
                public const long m_exitEvents = 0x58;
                public const long m_bIsOffState = 0xAE;
                public const long m_entryEvents = 0x18;
                public const long m_executeEvents = 0x38;
                public const long m_nChildNodeIdx = 0x10;
                public const long m_timedElapsedEvents = 0x90;
                public const long m_nLayerWeightNodeIdx = 0xA8;
                public const long m_timedRemainingEvents = 0x78;
                public const long m_nLayerBoneMaskNodeIdx = 0xAC;
                public const long m_nLayerRootMotionWeightNodeIdx = 0xAA;
                public const long m_bUseActualElapsedTimeInStateForTimedEvents = 0xAF;
            }
            public static partial class CNmValueNode__CDefinition {

            }
            public static partial class CPairedSequenceUpdateNode {
                public const long m_sPairedSequenceRole = 0x78;
            }
            public static partial class CParticleBindingRealPulse {

            }
            public static partial class CPathAnimMotorUpdaterBase {
                public const long m_bLockToPath = 0x20;
            }
            public static partial class CPulseCell_Value_Gradient {
                public const long m_Gradient = 0x48;
            }
            public static partial class CStanceOverrideUpdateNode {
                public const long m_eMode = 0x9C;
                public const long m_hParameter = 0x98;
                public const long m_footStanceInfo = 0x70;
                public const long m_pStanceSourceNode = 0x88;
            }
            public static partial class CStateMachineInstanceData {
                public const long m_flTimeInState = 0x0;
                public const long m_prevStateIndex = 0x10;
                public const long m_currentTransitionIndex = 0x4;
                public const long m_scheduledTransitionIndex = 0x14;
            }
            public static partial class CTargetSelectorUpdateNode {
                public const long m_children = 0x68;
                public const long m_eAngleMode = 0x60;
                public const long m_hTargetPosition = 0x84;
                public const long m_bEnablePhaseMatching = 0x8E;
                public const long m_hMoveHeadingParameter = 0x88;
                public const long m_bTargetPositionIsWorldSpace = 0x8C;
                public const long m_hDesiredMoveHeadingParameter = 0x8A;
                public const long m_hTargetFacePositionParameter = 0x86;
                public const long m_bTargetFacePositionIsWorldSpace = 0x8D;
                public const long m_flPhaseMatchingMaxRootMotionSkip = 0x90;
            }
            public static partial class CWayPointHelperUpdateNode {
                public const long m_bOnlyGoals = 0x7C;
                public const long m_flEndCycle = 0x78;
                public const long m_flStartCycle = 0x74;
                public const long m_bPreventOvershoot = 0x7D;
                public const long m_bPreventUndershoot = 0x7E;
            }
            public static partial class DynamicMeshDeformParams_t {
                public const long m_flTensionStretchScale = 0x4;
                public const long m_flTensionCompressScale = 0x0;
                public const long m_bEnableEyeBulgeDeformation = 0xB;
                public const long m_bSmoothNormalsAcrossUvSeams = 0xA;
                public const long m_bRecomputeSmoothNormalsAfterAnimation = 0x8;
                public const long m_bComputeDynamicMeshTensionAfterAnimation = 0x9;
            }
            public static partial class NmBoneMaskSetDefinition_t {
                public const long m_ID = 0x0;
                public const long m_primaryWeightList = 0x8;
                public const long m_secondaryWeightLists = 0x118;
            }
            public static partial class OutflowWithRequirements_t {
                public const long m_Connection = 0x0;
                public const long m_RequirementNodeIDs = 0x50;
                public const long m_DestinationFlowNodeID = 0x48;
                public const long m_nCursorStateBlockIndex = 0x68;
            }
            public static partial class PulseRuntimeInvokeIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class PulseRuntimeOutputIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class PulseRuntimeStateOffset_t {
                public const long m_Value = 0x0;
            }
            public static partial class SignatureOutflow_Continue {

            }
            public static partial class AimCameraOpFixedSettings_t {
                public const long m_propJoints = 0x18;
                public const long m_nChainIndex = 0x0;
                public const long m_nCameraJointIndex = 0x4;
                public const long m_nPelvisJointIndex = 0x8;
                public const long m_nClavicleLeftJointIndex = 0xC;
                public const long m_nClavicleRightJointIndex = 0x10;
                public const long m_nDepenetrationJointIndex = 0x14;
            }
            public static partial class AimMatrixOpFixedSettings_t {
                public const long m_damping = 0x80;
                public const long m_attachment = 0x0;
                public const long m_eBlendMode = 0xC0;
                public const long m_flMaxYawAngle = 0xC4;
                public const long m_nBoneMaskIndex = 0xD0;
                public const long m_flMaxPitchAngle = 0xC8;
                public const long m_bUseBiasAndClamp = 0xD5;
                public const long m_poseCacheHandles = 0x98;
                public const long m_bTargetIsPosition = 0xD4;
                public const long m_nSequenceMaxFrame = 0xCC;
                public const long m_biasAndClampBlendCurve = 0xE0;
                public const long m_flBiasAndClampYawOffset = 0xD8;
                public const long m_flBiasAndClampPitchOffset = 0xDC;
            }
            public static partial class AnimationDecodeDebugDump_t {
                public const long m_elems = 0x8;
                public const long m_processingType = 0x0;
            }
            public static partial class CCPPScriptComponentUpdater {
                public const long m_scriptsToRun = 0x30;
            }
            public static partial class CFootStepTriggerUpdateNode {
                public const long m_triggers = 0x70;
                public const long m_flTolerance = 0x8C;
            }
            public static partial class CNmContactAudioActionVData {

            }
            public static partial class CNmEntityAttributeIntEvent {
                public const long m_nIntValue = 0x38;
            }
            public static partial class CNmFootIKNode__CDefinition {
                public const long m_blendMode = 0x34;
                public const long m_nEnabledNodeIdx = 0x2C;
                public const long m_flBlendTimeSeconds = 0x30;
                public const long m_leftEffectorBoneID = 0x18;
                public const long m_nLeftTargetNodeIdx = 0x28;
                public const long m_nRightTargetNodeIdx = 0x2A;
                public const long m_rightEffectorBoneID = 0x20;
                public const long m_bIsTargetInWorldSpace = 0x35;
            }
            public static partial class CNmStateNode__TimedEvent_t {
                public const long m_ID = 0x0;
                public const long m_flTimeValueSeconds = 0x8;
                public const long m_comparisionOperator = 0xC;
            }
            public static partial class COrientationWarpUpdateNode {
                public const long m_eMode = 0x74;
                public const long m_damping = 0x90;
                public const long m_hTargetParam = 0x78;
                public const long m_flTargetOffset = 0x84;
                public const long m_eRootMotionSource = 0xA8;
                public const long m_eTargetOffsetMode = 0x80;
                public const long m_hTargetOffsetParam = 0x88;
                public const long m_flMaxRootMotionScale = 0xAC;
                public const long m_hTargetPositionParam = 0x7A;
                public const long m_ePreferredRotationDirection = 0xB4;
                public const long m_flPreferredRotationThreshold = 0xB8;
                public const long m_hFallbackTargetPositionParam = 0x7C;
                public const long m_bEnablePreferredRotationDirection = 0xB0;
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
            public static partial class CSetParameterActionUpdater {
                public const long m_value = 0x1A;
                public const long m_hParam = 0x18;
            }
            public static partial class FollowAttachmentSettings_t {
                public const long m_boneIndex = 0x80;
                public const long m_attachment = 0x0;
                public const long m_bMatchRotation = 0x86;
                public const long m_attachmentHandle = 0x84;
                public const long m_bMatchTranslation = 0x85;
            }
            public static partial class MotionMatchingInstanceData {
                public const long m_currentSelection = 0x2C;
                public const long m_previousSelection = 0x84;
            }
            public static partial class ParticleNamedValueSource_t {
                public const long m_Name = 0x0;
                public const long m_IsPublic = 0x8;
                public const long m_ValueType = 0x10;
                public const long m_DefaultConfig = 0x28;
            }
            public static partial class PulseNodeDynamicOutflows_t {
                public const long m_Outflows = 0x0;
            }
            public static partial class PulseRuntimeTempVarIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class PulseSelectorOutflowList_t {
                public const long m_Outflows = 0x0;
            }
            public static partial class CAnimScriptComponentUpdater {
                public const long m_hScript = 0x30;
            }
            public static partial class CCycleControlClipUpdateNode {
                public const long m_tags = 0x60;
                public const long m_duration = 0x80;
                public const long m_hSequence = 0x7C;
                public const long m_paramIndex = 0x88;
                public const long m_valueSource = 0x84;
                public const long m_bLockWhenWaning = 0x8A;
            }
            public static partial class CDampedPathAnimMotorUpdater {
                public const long m_flMinSpeedScale = 0x30;
                public const long m_flSpringConstant = 0x38;
                public const long m_flAnticipationTime = 0x2C;
                public const long m_flMaxSpringTension = 0x40;
                public const long m_flMinSpringTension = 0x3C;
                public const long m_hAnticipationPosParam = 0x34;
                public const long m_hAnticipationHeadingParam = 0x36;
            }
            public static partial class CDirectPlaybackInstanceData {
                public const long m_weights = 0x14;
                public const long m_sequences = 0x24;
                public const long m_flFadeInTime = 0x118;
                public const long m_bResetPending = 0x130;
                public const long m_flFadeOutTime = 0x11C;
                public const long m_flForcedCycle = 0x120;
                public const long m_flTargetFacing = 0xC;
                public const long m_flInterpEndTime = 0x10;
                public const long m_vTargetPosition = 0x0;
                public const long m_currentSequenceData = 0x108;
                public const long m_currentSequenceIndex = 0x104;
                public const long m_SequenceCycleZeroTime = 0x138;
            }
            public static partial class CDirectionalBlendUpdateNode {
                public const long m_bLoop = 0xA8;
                public const long m_damping = 0x80;
                public const long m_duration = 0xA4;
                public const long m_hSequences = 0x5C;
                public const long m_paramIndex = 0x9C;
                public const long m_playbackSpeed = 0xA0;
                public const long m_blendValueSource = 0x98;
                public const long m_bLockBlendOnReset = 0xA9;
            }
            public static partial class CFollowAttachmentUpdateNode {
                public const long m_opFixedData = 0x70;
            }
            public static partial class CFootAdjustmentInstanceData {
                public const long m_flDuration = 0x18;
                public const long m_flStartTime = 0xC;
                public const long m_flStartHeadingWS = 0x3C;
            }
            public static partial class CModelConfigElement_Command {
                public const long m_Args = 0x50;
                public const long m_Command = 0x48;
            }
            public static partial class CNmBlend1DNode__CDefinition {
                public const long m_parameterization = 0x30;
            }
            public static partial class CNmBlend2DNode__CDefinition {
                public const long m_values = 0x28;
                public const long m_indices = 0x80;
                public const long m_hullIndices = 0xA8;
                public const long m_bAllowLooping = 0xC4;
                public const long m_sourceNodeIndices = 0x10;
                public const long m_nInputParameterNodeIdx0 = 0xC0;
                public const long m_nInputParameterNodeIdx1 = 0xC2;
            }
            public static partial class CNmConstIDNode__CDefinition {
                public const long m_value = 0x10;
            }
            public static partial class CNmEntityAttributeEventBase {
                public const long m_target = 0x18;
                public const long m_attributeName = 0x20;
            }
            public static partial class CNmIDEventNode__CDefinition {
                public const long m_defaultValue = 0x18;
                public const long m_eventConditionRules = 0x14;
                public const long m_nSourceStateNodeIdx = 0x10;
            }
            public static partial class CNmIDValueNode__CDefinition {

            }
            public static partial class CNmSyncTrack__EventMarker_t {
                public const long m_ID = 0x8;
                public const long m_startTime = 0x0;
            }
            public static partial class CParticleCollectionVecInput {

            }
            public static partial class CPhysSurfacePropertiesAudio {
                public const long m_reflectivity = 0x0;
                public const long m_hardThreshold = 0x10;
                public const long m_hardnessFactor = 0x4;
                public const long m_roughThreshold = 0xC;
                public const long m_roughnessFactor = 0x8;
                public const long m_flOcclusionFactor = 0x1C;
                public const long m_flStaticImpactVolume = 0x18;
                public const long m_hardVelocityThreshold = 0x14;
            }
            public static partial class CPulseCell_Inflow_GraphHook {
                public const long m_HookName = 0x80;
            }
            public static partial class CPulseGraphExecutionHistory {
                public const long m_vecHistory = 0x10;
                public const long m_mapCellDesc = 0x28;
                public const long m_nInstanceID = 0x0;
                public const long m_strFileName = 0x8;
                public const long m_mapCursorDesc = 0x50;
            }
            public static partial class CRemapValueComponentUpdater {
                public const long m_items = 0x30;
            }
            public static partial class CSlowDownOnSlopesUpdateNode {
                public const long m_flSlowDownStrength = 0x70;
            }
            public static partial class CWayPointHelperInstanceData {
                public const long m_vMovement = 0x0;
                public const long m_vRotation = 0xC;
                public const long m_vWaypointPosWS = 0x18;
                public const long m_bStopUpdatingWaypointPos = 0x24;
            }
            public static partial class FootLockPoseOpFixedSettings {
                public const long m_footInfo = 0x0;
                public const long m_bApplyTilt = 0x38;
                public const long m_ikSolverType = 0x34;
                public const long m_bApplyHipDrop = 0x39;
                public const long m_flMaxLegTwist = 0x48;
                public const long m_nHipBoneIndex = 0x30;
                public const long m_flLockBlendTime = 0x54;
                public const long m_flMaxFootHeight = 0x40;
                public const long m_flExtensionScale = 0x44;
                public const long m_bEnableStretching = 0x58;
                public const long m_flMaxStretchAmount = 0x5C;
                public const long m_hipDampingSettings = 0x18;
                public const long m_bEnableLockBreaking = 0x4C;
                public const long m_bApplyLegTwistLimits = 0x3C;
                public const long m_flLockBreakTolerance = 0x50;
                public const long m_bAlwaysUseFallbackHinge = 0x3A;
                public const long m_flStretchExtensionScale = 0x60;
                public const long m_bApplyFootRotationLimits = 0x3B;
            }
            public static partial class PulseRuntimeCallInfoIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class PulseRuntimeConstantIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class PulseRuntimeRegisterIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class VPhysXCollisionAttributes_t {
                public const long m_InteractAs = 0x8;
                public const long m_DetailLayers = 0x50;
                public const long m_InteractWith = 0x20;
                public const long m_CollisionGroup = 0x4;
                public const long m_InteractExclude = 0x38;
                public const long m_InteractAsStrings = 0x70;
                public const long m_DetailLayerStrings = 0xB8;
                public const long m_InteractWithStrings = 0x88;
                public const long m_CollisionGroupString = 0x68;
                public const long m_InteractExcludeStrings = 0xA0;
                public const long m_nIncludeDetailLayerCount = 0x0;
            }
            public static partial class CAnimParameterManagerUpdater {
                public const long m_parameters = 0x18;
                public const long m_autoResetMap = 0xA0;
                public const long m_idToIndexMap = 0x30;
                public const long m_indexToHandle = 0x70;
                public const long m_nameToIndexMap = 0x50;
                public const long m_autoResetParams = 0x88;
            }
            public static partial class CAnimationGraphVisualizerPie {
                public const long m_Color = 0x70;
                public const long m_vWsEnd = 0x60;
                public const long m_vWsStart = 0x50;
                public const long m_vWsCenter = 0x40;
            }
            public static partial class CBoneConstraintPoseSpaceBone {
                public const long m_inputList = 0x60;
            }
            public static partial class CBonePositionMetricEvaluator {
                public const long m_nBoneIndex = 0x50;
            }
            public static partial class CBoneVelocityMetricEvaluator {
                public const long m_nBoneIndex = 0x50;
            }
            public static partial class CDampedValueComponentUpdater {
                public const long m_items = 0x30;
            }
            public static partial class CFootPositionMetricEvaluator {
                public const long m_footIndices = 0x50;
                public const long m_bIgnoreSlope = 0x68;
            }
            public static partial class CFutureFacingMetricEvaluator {
                public const long m_flTime = 0x54;
                public const long m_flDistance = 0x50;
            }
            public static partial class CModelConfigElement_UserPick {
                public const long m_Choices = 0x48;
            }
            public static partial class CNmBoneMaskNode__CDefinition {
                public const long m_boneMaskID = 0x10;
            }
            public static partial class CNmCachedIDNode__CDefinition {
                public const long m_mode = 0x14;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmEntityAttributeFloatEvent {
                public const long m_FloatValue = 0x38;
            }
            public static partial class CNmIDSwitchNode__CDefinition {
                public const long m_trueValue = 0x20;
                public const long m_falseValue = 0x18;
                public const long m_nTrueValueNodeIdx = 0x12;
                public const long m_nFalseValueNodeIdx = 0x14;
                public const long m_nSwitchValueNodeIdx = 0x10;
            }
            public static partial class CNmSelectorNode__CDefinition {
                public const long m_optionNodeIndices = 0x10;
                public const long m_conditionNodeIndices = 0x28;
            }
            public static partial class CNmSkeleton__ContactConfig_t {
                public const long m_ID = 0x0;
                public const long m_nBoneIdx = 0x8;
                public const long m_audioInfo = 0x20;
                public const long m_flProbeMaxDist = 0x18;
                public const long m_vBoneLocalProbeDir = 0xC;
            }
            public static partial class CNmZeroPoseNode__CDefinition {

            }
            public static partial class CPlayerInputAnimMotorUpdater {
                public const long m_sampleTimes = 0x20;
                public const long m_bUseAcceleration = 0x48;
                public const long m_flSpringConstant = 0x3C;
                public const long m_hAnticipationPosParam = 0x44;
                public const long m_flAnticipationDistance = 0x40;
                public const long m_hAnticipationHeadingParam = 0x46;
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
            public static partial class CPulse_TempVarBankDefinition {
                public const long m_TempVars = 0x0;
            }
            public static partial class CVPhysXSurfacePropertiesList {
                public const long m_surfacePropertiesList = 0x0;
            }
            public static partial class FootPinningPoseOpFixedData_t {
                public const long m_footInfo = 0x0;
                public const long m_flBlendTime = 0x18;
                public const long m_flMaxLegTwist = 0x20;
                public const long m_nHipBoneIndex = 0x24;
                public const long m_flLockBreakDistance = 0x1C;
                public const long m_bApplyLegTwistLimits = 0x28;
                public const long m_bApplyFootRotationLimits = 0x29;
            }
            public static partial class ModelBoneFlexDriverControl_t {
                public const long m_flMax = 0x18;
                public const long m_flMin = 0x14;
                public const long m_flexController = 0x8;
                public const long m_nBoneComponent = 0x0;
                public const long m_flexControllerToken = 0x10;
            }
            public static partial class TargetSelectorInstanceData_t {
                public const long m_currentIndex = 0x0;
                public const long m_vMSRootMotionAnlyzerTarget = 0x1C;
            }
            public static partial class CAnimationGraphVisualizerAxis {
                public const long m_flAxisSize = 0x60;
                public const long m_xWsTransform = 0x40;
            }
            public static partial class CAnimationGraphVisualizerLine {
                public const long m_Color = 0x60;
                public const long m_vWsPositionEnd = 0x50;
                public const long m_vWsPositionStart = 0x40;
            }
            public static partial class CAnimationGraphVisualizerText {
                public const long m_Text = 0x58;
                public const long m_Color = 0x50;
                public const long m_vWsPosition = 0x40;
            }
            public static partial class CBoneConstraintPoseSpaceMorph {
                public const long m_bClamp = 0x60;
                public const long m_inputList = 0x48;
                public const long m_sBoneName = 0x20;
                public const long m_outputMorph = 0x30;
                public const long m_sAttachmentName = 0x28;
            }
            public static partial class CDemoSettingsComponentUpdater {
                public const long m_settings = 0x30;
            }
            public static partial class CDirectionalBlendInstanceData {
                public const long m_flCycle = 0x14;
                public const long m_resetCount = 0x40;
                public const long m_dampedValue = 0x0;
                public const long m_flPrevCycle = 0x18;
                public const long m_flPlaybackRate = 0x1C;
                public const long m_flCycleZeroTime = 0x28;
                public const long m_resetCycleValue = 0x34;
            }
            public static partial class CNmBodyGroupNode__CDefinition {
                public const long m_event = 0x20;
                public const long m_nEnabledNodeIdx = 0x18;
            }
            public static partial class CNmBoolValueNode__CDefinition {

            }
            public static partial class CNmConstBoolNode__CDefinition {
                public const long m_bValue = 0x10;
            }
            public static partial class CNmFloatEaseNode__CDefinition {
                public const long m_easingOp = 0x1A;
                public const long m_flEaseTime = 0x10;
                public const long m_flStartValue = 0x14;
                public const long m_bUseStartValue = 0x1B;
                public const long m_nInputValueNodeIdx = 0x18;
            }
            public static partial class CNmFloatMathNode__CDefinition {
                public const long m_flValueB = 0x18;
                public const long m_operator = 0x16;
                public const long m_nInputValueNodeIdxA = 0x10;
                public const long m_nInputValueNodeIdxB = 0x12;
                public const long m_bReturnNegatedResult = 0x15;
                public const long m_bReturnAbsoluteResult = 0x14;
            }
            public static partial class CNmIDToFloatNode__CDefinition {
                public const long m_IDs = 0x18;
                public const long m_values = 0x48;
                public const long m_defaultValue = 0x14;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmTwoBoneIKNode__CDefinition {
                public const long m_blendMode = 0x28;
                public const long m_effectorBoneID = 0x18;
                public const long m_nEnabledNodeIdx = 0x22;
                public const long m_flBlendTimeSeconds = 0x24;
                public const long m_bIsTargetInWorldSpace = 0x29;
                public const long m_flChainRotationWeight = 0x2C;
                public const long m_nEffectorTargetNodeIdx = 0x20;
            }
            public static partial class CParticleCollectionFloatInput {

            }
            public static partial class CPhysSurfacePropertiesPhysics {
                public const long m_density = 0x8;
                public const long m_friction = 0x0;
                public const long m_thickness = 0xC;
                public const long m_elasticity = 0x4;
                public const long m_softContactFrequency = 0x10;
                public const long m_softContactDampingRatio = 0x14;
            }
            public static partial class CPhysSurfacePropertiesVehicle {
                public const long m_wheelDrag = 0x0;
                public const long m_wheelFrictionScale = 0x4;
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
            public static partial class CStateMachineComponentUpdater {
                public const long m_stateMachine = 0x30;
            }
            public static partial class CTimeRemainingMetricEvaluator {
                public const long m_flMaxTimeRemaining = 0x54;
                public const long m_flMinTimeRemaining = 0x5C;
                public const long m_bMatchByTimeRemaining = 0x50;
                public const long m_bFilterByTimeRemaining = 0x58;
            }
            public static partial class CToggleComponentActionUpdater {
                public const long m_bSetEnabled = 0x1C;
                public const long m_componentID = 0x18;
            }
            public static partial class DampedPathMotorInstanceData_t {
                public const long m_bStopping = 0x24;
                public const long m_vVelocity = 0x0;
                public const long m_vAcceleration = 0xC;
            }
            public static partial class FollowTargetOpFixedSettings_t {
                public const long m_boneIndex = 0x0;
                public const long m_bBoneTarget = 0x4;
                public const long m_boneTargetIndex = 0x8;
                public const long m_bWorldCoodinateTarget = 0xC;
                public const long m_bMatchTargetOrientation = 0xD;
            }
            public static partial class PulseRuntimeEntrypointIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class SkeletonAnimCapture_t__Bone_t {
                public const long m_Name = 0x0;
                public const long m_nParent = 0x30;
                public const long m_BindPose = 0x10;
            }
            public static partial class CBlockSelectionMetricEvaluator {

            }
            public static partial class CFutureVelocityMetricEvaluator {
                public const long m_eMode = 0x5C;
                public const long m_flDistance = 0x50;
                public const long m_flTargetSpeed = 0x58;
                public const long m_flStoppingDistance = 0x54;
            }
            public static partial class CModelConfigElement_RandomPick {
                public const long m_Choices = 0x48;
                public const long m_ChoiceWeights = 0x60;
            }
            public static partial class CNmCachedBoolNode__CDefinition {
                public const long m_mode = 0x14;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmConstFloatNode__CDefinition {
                public const long m_flValue = 0x10;
            }
            public static partial class CNmFloatClampNode__CDefinition {
                public const long m_clampRange = 0x14;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmFloatCurveNode__CDefinition {
                public const long m_curve = 0x18;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmFloatRemapNode__CDefinition {
                public const long m_inputRange = 0x14;
                public const long m_outputRange = 0x1C;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmFloatValueNode__CDefinition {

            }
            public static partial class CNmFollowBoneNode__CDefinition {
                public const long m_bone = 0x18;
                public const long m_mode = 0x2A;
                public const long m_nEnabledNodeIdx = 0x28;
                public const long m_followTargetBone = 0x20;
            }
            public static partial class CNmIDSelectorNode__CDefinition {
                public const long m_values = 0x28;
                public const long m_defaultValue = 0x58;
                public const long m_conditionNodeIndices = 0x10;
            }
            public static partial class CNmLayerBlendNode__CDefinition {
                public const long m_nBaseNodeIdx = 0x10;
                public const long m_layerDefinition = 0x18;
                public const long m_bOnlySampleBaseRootMotion = 0x12;
            }
            public static partial class CNmSpeedScaleNode__CDefinition {

            }
            public static partial class CNmTargetInfoNode__CDefinition {
                public const long m_infoType = 0x14;
                public const long m_nInputValueNodeIdx = 0x10;
                public const long m_bIsWorldSpaceTarget = 0x18;
            }
            public static partial class CNmTargetWarpNode__CDefinition {
                public const long m_samplingMode = 0x14;
                public const long m_alignmentBoneID = 0x30;
                public const long m_targetUpdateRule = 0x15;
                public const long m_flMaxTangentLength = 0x1C;
                public const long m_nTargetValueNodeIdx = 0x12;
                public const long m_nClipReferenceNodeIdx = 0x10;
                public const long m_bAlignWithTargetAtLastWarpEvent = 0x16;
                public const long m_flLerpFallbackDistanceThreshold = 0x20;
                public const long m_flTargetUpdateDistanceThreshold = 0x24;
                public const long m_flSamplingPositionErrorThresholdSq = 0x18;
                public const long m_flTargetUpdateAngleThresholdRadians = 0x28;
            }
            public static partial class CNmTransitionNode__CDefinition {
                public const long m_flDuration = 0x18;
                public const long m_flTimeOffset = 0x20;
                public const long m_rootMotionBlend = 0x2B;
                public const long m_blendWeightEasing = 0x2A;
                public const long m_transitionOptions = 0x24;
                public const long m_nTargetStateNodeIdx = 0x10;
                public const long m_targetSyncIDNodeIdx = 0x28;
                public const long m_startBoneMaskNodeIdx = 0x16;
                public const long m_nDurationOverrideNodeIdx = 0x12;
                public const long m_timeOffsetOverrideNodeIdx = 0x14;
                public const long m_boneMaskBlendInTimePercentage = 0x1C;
            }
            public static partial class CNmVectorInfoNode__CDefinition {
                public const long m_desiredInfo = 0x12;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CPulseCell_Inflow_EventHandler {
                public const long m_EventName = 0x80;
            }
            public static partial class CPulseCell_Outflow_CycleRandom {
                public const long m_Outputs = 0x48;
            }
            public static partial class CStepsRemainingMetricEvaluator {
                public const long m_footIndices = 0x50;
                public const long m_flMinStepsRemaining = 0x68;
            }
            public static partial class PlayerInputMotorInstanceData_t {
                public const long m_vVelocityWS = 0xC;
                public const long m_vInputVectorWS = 0x0;
                public const long m_vAccelerationWS = 0x18;
            }
            public static partial class PulseRuntimeDomainValueIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class PulseRuntimeTempVarBankIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class SkeletonAnimCapture_t__Frame_t {
                public const long m_Stamp = 0x4;
                public const long m_flTime = 0x0;
                public const long m_Transform = 0x20;
                public const long m_bTeleport = 0x40;
                public const long m_FeModelPos = 0x90;
                public const long m_FeModelAnims = 0x78;
                public const long m_SimStateBones = 0x60;
                public const long m_CompositeBones = 0x48;
                public const long m_FlexControllerWeights = 0xA8;
            }
            public static partial class CAnimationGraphVisualizerSphere {
                public const long m_Color = 0x54;
                public const long m_flRadius = 0x50;
                public const long m_vWsPosition = 0x40;
            }
            public static partial class CCurrentVelocityMetricEvaluator {

            }
            public static partial class CModelConfigElement_RandomColor {
                public const long m_Gradient = 0x48;
            }
            public static partial class CNmCachedFloatNode__CDefinition {
                public const long m_mode = 0x14;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmChainLookatNode__CDefinition {
                public const long m_chainWeights = 0x40;
                public const long m_nChainLength = 0x70;
                public const long m_nEnabledNodeIdx = 0x3A;
                public const long m_endEffectorBoneID = 0x18;
                public const long m_endEffectorOffset = 0x2C;
                public const long m_flBlendTimeSeconds = 0x3C;
                public const long m_nLookatTargetNodeIdx = 0x38;
                public const long m_bIsTargetInWorldSpace = 0x71;
                public const long m_endEffectorForwardAxis = 0x20;
            }
            public static partial class CNmConstTargetNode__CDefinition {
                public const long m_value = 0x10;
            }
            public static partial class CNmConstVectorNode__CDefinition {
                public const long m_value = 0x10;
            }
            public static partial class CNmFloatRemapNode__RemapRange_t {
                public const long m_flEnd = 0x4;
                public const long m_flBegin = 0x0;
            }
            public static partial class CNmFloatSpringNode__CDefinition {
                public const long m_flHertz = 0x14;
                public const long m_flStartValue = 0x10;
                public const long m_bUseStartValue = 0x1E;
                public const long m_flDampingRatio = 0x18;
                public const long m_nInputValueNodeIdx = 0x1C;
            }
            public static partial class CNmFloatSwitchNode__CDefinition {
                public const long m_flTrueValue = 0x1C;
                public const long m_flFalseValue = 0x18;
                public const long m_nTrueValueNodeIdx = 0x12;
                public const long m_nFalseValueNodeIdx = 0x14;
                public const long m_nSwitchValueNodeIdx = 0x10;
            }
            public static partial class CNmIsTargetSetNode__CDefinition {
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmPassthroughNode__CDefinition {
                public const long m_nChildNodeIdx = 0x10;
            }
            public static partial class CNmTargetPointNode__CDefinition {
                public const long m_nInputValueNodeIdx = 0x10;
                public const long m_bIsWorldSpaceTarget = 0x12;
            }
            public static partial class CNmTargetValueNode__CDefinition {

            }
            public static partial class CNmVectorValueNode__CDefinition {

            }
            public static partial class CPairedSequenceComponentUpdater {

            }
            public static partial class CPulseCell_Outflow_CycleOrdered {
                public const long m_Outputs = 0x48;
            }
            public static partial class SkeletonAnimCapture_t__Camera_t {
                public const long m_flTime = 0x20;
                public const long m_tmCamera = 0x0;
            }
            public static partial class CModelConfigElement_SetBodygroup {
                public const long m_nChoice = 0x50;
                public const long m_GroupName = 0x48;
            }
            public static partial class CNmCachedTargetNode__CDefinition {
                public const long m_mode = 0x14;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmCachedVectorNode__CDefinition {
                public const long m_mode = 0x14;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmClipSelectorNode__CDefinition {
                public const long m_optionNodeIndices = 0x10;
                public const long m_conditionNodeIndices = 0x28;
            }
            public static partial class CNmExternalPoseNode__CDefinition {
                public const long m_bShouldSampleRootMotion = 0x10;
            }
            public static partial class CNmIDComparisonNode__CDefinition {
                public const long m_comparison = 0x12;
                public const long m_comparisionIDs = 0x18;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmSkeleton__SecondarySkeleton_t {
                public const long m_skeleton = 0x8;
                public const long m_attachToBoneID = 0x0;
            }
            public static partial class CNmStateMachineNode__CDefinition {
                public const long m_stateDefinitions = 0x10;
                public const long m_nDefaultStateIndex = 0x130;
            }
            public static partial class CNmTargetOffsetNode__CDefinition {
                public const long m_rotationOffset = 0x20;
                public const long m_translationOffset = 0x30;
                public const long m_bIsBoneSpaceOffset = 0x12;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmVectorCreateNode__CDefinition {
                public const long m_inputValueXNodeIdx = 0x12;
                public const long m_inputValueYNodeIdx = 0x14;
                public const long m_inputValueZNodeIdx = 0x16;
                public const long m_inputVectorValueNodeIdx = 0x10;
            }
            public static partial class CNmVectorNegateNode__CDefinition {
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CPhysSurfacePropertiesSoundNames {
                public const long m_break = 0x30;
                public const long m_strain = 0x38;
                public const long m_pushOff = 0x48;
                public const long m_rolling = 0x28;
                public const long m_resonant = 0x58;
                public const long m_skidStop = 0x50;
                public const long m_impactHard = 0x8;
                public const long m_impactSoft = 0x0;
                public const long m_meleeImpact = 0x40;
                public const long m_scrapeRough = 0x18;
                public const long m_bulletImpact = 0x20;
                public const long m_scrapeSmooth = 0x10;
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
            public static partial class AnimationDecodeDebugDumpElement_t {
                public const long m_decodeOps = 0x28;
                public const long m_modelName = 0x8;
                public const long m_poseParams = 0x10;
                public const long m_internalOps = 0x40;
                public const long m_decodedAnims = 0x58;
                public const long m_nEntityIndex = 0x0;
            }
            public static partial class CDistanceRemainingMetricEvaluator {
                public const long m_flMaxDistance = 0x50;
                public const long m_flMinDistance = 0x54;
                public const long m_bFilterGoalDistance = 0x61;
                public const long m_bFilterGoalOvershoot = 0x62;
                public const long m_bFilterFixedMinDistance = 0x60;
                public const long m_flMaxGoalOvershootScale = 0x5C;
                public const long m_flStartGoalFilterDistance = 0x58;
            }
            public static partial class CModelConfigElement_AttachedModel {
                public const long m_hModel = 0x58;
                public const long m_vOffset = 0x60;
                public const long m_aAngOffset = 0x6C;
                public const long m_EntityClass = 0x50;
                public const long m_InstanceName = 0x48;
                public const long m_AttachmentName = 0x78;
                public const long m_AttachmentType = 0x88;
                public const long m_bBoneMergeFlex = 0x8C;
                public const long m_bUserSpecifiedColor = 0x8D;
                public const long m_bCollideWithHierarchy = 0xA0;
                public const long m_BodygroupOnOtherModels = 0x90;
                public const long m_bCollideOutsideHierarchy = 0xA1;
                public const long m_LocalAttachmentOffsetName = 0x80;
                public const long m_MaterialGroupOnOtherModels = 0x98;
                public const long m_bUserSpecifiedMaterialGroup = 0x8E;
            }
            public static partial class CNmAnimationPoseNode__CDefinition {
                public const long m_nDataSlotIdx = 0x12;
                public const long m_bUseFramesAsInput = 0x20;
                public const long m_flUserSpecifiedTime = 0x1C;
                public const long m_inputTimeRemapRange = 0x14;
                public const long m_nPoseTimeValueNodeIdx = 0x10;
            }
            public static partial class CNmBoneMaskBlendNode__CDefinition {
                public const long m_nSourceMaskNodeIdx = 0x10;
                public const long m_nTargetMaskNodeIdx = 0x12;
                public const long m_nBlendWeightValueNodeIdx = 0x14;
            }
            public static partial class CNmBoneMaskValueNode__CDefinition {

            }
            public static partial class CNmClipReferenceNode__CDefinition {

            }
            public static partial class CNmDurationScaleNode__CDefinition {

            }
            public static partial class CNmFloatSelectorNode__CDefinition {
                public const long m_values = 0x28;
                public const long m_easingOp = 0x50;
                public const long m_flEaseTime = 0x4C;
                public const long m_flDefaultValue = 0x48;
                public const long m_conditionNodeIndices = 0x10;
            }
            public static partial class CNmReferencePoseNode__CDefinition {

            }
            public static partial class CNmTimeConditionNode__CDefinition {
                public const long m_type = 0x18;
                public const long m_operator = 0x19;
                public const long m_flComparand = 0x14;
                public const long m_nInputValueNodeIdx = 0x12;
                public const long m_sourceStateNodeIdx = 0x10;
            }
            public static partial class CNmVelocityBlendNode__CDefinition {

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
            public static partial class NmFloatCurveCompressionSettings_t {
                public const long m_range = 0x0;
                public const long m_bIsStatic = 0x8;
            }
            public static partial class ParticleNamedValueConfiguration_t {
                public const long m_ConfigName = 0x0;
                public const long m_ConfigValue = 0x8;
                public const long m_iAttachType = 0x20;
                public const long m_BoundValuePath = 0x18;
                public const long m_strEntityScope = 0x28;
                public const long m_strAttachmentName = 0x30;
            }
            public static partial class PulseGraphExecutionHistoryEntry_t {
                public const long childID = 0x30;
                public const long tagName = 0x20;
                public const long unFlags = 0x1C;
                public const long seqPoint = 0x8;
                public const long nCursorID = 0x0;
                public const long nEditorID = 0x4;
                public const long flExecTime = 0x18;
            }
            public static partial class SolveIKChainPoseOpFixedSettings_t {
                public const long m_ChainsToSolveData = 0x0;
            }
            public static partial class CModelConfigElement_SetRenderColor {
                public const long m_Color = 0x48;
            }
            public static partial class CNmBoneMaskSwitchNode__CDefinition {
                public const long m_nTrueValueNodeIdx = 0x12;
                public const long m_bSwitchDynamically = 0x1C;
                public const long m_flBlendTimeSeconds = 0x18;
                public const long m_nFalseValueNodeIdx = 0x14;
                public const long m_nSwitchValueNodeIdx = 0x10;
            }
            public static partial class CNmFloatAngleMathNode__CDefinition {
                public const long m_operation = 0x12;
                public const long m_nInputValueNodeIdx = 0x10;
            }
            public static partial class CNmSpeedScaleBaseNode__CDefinition {
                public const long m_nInputValueNodeIdx = 0x18;
                public const long m_flDefaultInputValue = 0x1C;
            }
            public static partial class CNmTargetSelectorNode__CDefinition {
                public const long m_alignmentBoneID = 0x38;
                public const long m_parameterNodeIdx = 0x30;
                public const long m_optionNodeIndices = 0x10;
                public const long m_bIsWorldSpaceTarget = 0x33;
                public const long m_bIgnoreInvalidOptions = 0x32;
                public const long m_flPositionScoreWeight = 0x2C;
                public const long m_flOrientationScoreWeight = 0x28;
            }
            public static partial class CParticleCollectionBindingInstance {

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
            public static partial class CNmFloatComparisonNode__CDefinition {
                public const long m_flEpsilon = 0x18;
                public const long m_comparison = 0x14;
                public const long m_flComparisonValue = 0x1C;
                public const long m_nInputValueNodeIdx = 0x10;
                public const long m_nComparandValueNodeIdx = 0x12;
            }
            public static partial class CNmFloatCurveEventNode__CDefinition {
                public const long m_eventID = 0x10;
                public const long m_flDefaultValue = 0x1C;
                public const long m_nDefaultNodeIdx = 0x18;
                public const long m_eventConditionRules = 0x20;
            }
            public static partial class CNmFootstepEventIDNode__CDefinition {
                public const long m_eventConditionRules = 0x14;
                public const long m_nSourceStateNodeIdx = 0x10;
            }
            public static partial class CNmIDBasedSelectorNode__CDefinition {
                public const long m_optionIDs = 0x28;
                public const long m_nFallbackNodeIdx = 0x5A;
                public const long m_nParameterNodeIdx = 0x58;
                public const long m_optionNodeIndices = 0x10;
                public const long m_bIgnoreInvalidOptions = 0x5C;
            }
            public static partial class CNmOrientationWarpNode__CDefinition {
                public const long m_samplingMode = 0x18;
                public const long m_alignmentMode = 0x17;
                public const long m_bIsOffsetNode = 0x14;
                public const long m_bWarpTranslation = 0x16;
                public const long m_nTargetValueNodeIdx = 0x12;
                public const long m_nClipReferenceNodeIdx = 0x10;
                public const long m_bIsOffsetRelativeToCharacter = 0x15;
            }
            public static partial class CNmReferencedGraphNode__CDefinition {
                public const long m_nFallbackNodeIdx = 0x12;
                public const long m_nReferencedGraphIdx = 0x10;
            }
            public static partial class CParticleCollectionRendererVecInput {

            }
            public static partial class SkeletonAnimCapture_t__FrameStamp_t {
                public const long m_flTime = 0x0;
                public const long m_flCurTime = 0xC;
                public const long m_bPredicted = 0x9;
                public const long m_flRealTime = 0x10;
                public const long m_nTickCount = 0x18;
                public const long m_nFrameCount = 0x14;
                public const long m_bTeleportTick = 0x8;
                public const long m_flEntitySimTime = 0x4;
            }
            public static partial class CModelConfigElement_SetMaterialGroup {
                public const long m_MaterialGroupName = 0x48;
            }
            public static partial class CNmBoneMaskSelectorNode__CDefinition {
                public const long m_maskNodeIndices = 0x18;
                public const long m_parameterValues = 0x30;
                public const long m_bSwitchDynamically = 0x14;
                public const long m_defaultMaskNodeIdx = 0x10;
                public const long m_flBlendTimeSeconds = 0x70;
                public const long m_parameterValueNodeIdx = 0x12;
            }
            public static partial class CNmCurrentSyncEventNode__CDefinition {
                public const long m_infoType = 0x12;
                public const long m_nSourceStateNodeIdx = 0x10;
            }
            public static partial class CNmIDEventConditionNode__CDefinition {
                public const long m_eventIDs = 0x18;
                public const long m_eventConditionRules = 0x14;
                public const long m_nSourceStateNodeIdx = 0x10;
            }
            public static partial class CNmLayerBlendNode__LayerDefinition_t {
                public const long m_blendMode = 0xB;
                public const long m_bIgnoreEvents = 0x9;
                public const long m_nInputNodeIdx = 0x0;
                public const long m_bIsSynchronized = 0x8;
                public const long m_nWeightValueNodeIdx = 0x2;
                public const long m_bIsStateMachineLayer = 0xA;
                public const long m_nBoneMaskValueNodeIdx = 0x4;
                public const long m_nRootMotionWeightValueNodeIdx = 0x6;
            }
            public static partial class CPulseCell_Timeline__TimelineEvent_t {
                public const long m_EventOutflow = 0x8;
                public const long m_flTimeFromPrevious = 0x0;
            }
            public static partial class CPulseCell_WaitForCursorsWithTagBase {
                public const long m_WaitComplete = 0xE0;
                public const long m_nCursorsAllowedToWait = 0xD8;
            }
            public static partial class PulseGraphExecutionHistoryNodeDesc_t {
                public const long strCellDesc = 0x0;
                public const long strBindingName = 0x10;
            }
            public static partial class CBoneConstraintPoseSpaceBone__Input_t {
                public const long m_inputValue = 0x0;
                public const long m_outputTransformList = 0x10;
            }
            public static partial class CNmIsExternalPoseSetNode__CDefinition {
                public const long m_nExternalPoseNodeIdx = 0x10;
            }
            public static partial class CParticleCollectionRendererFloatInput {

            }
            public static partial class CAnimationGraphVisualizerPrimitiveBase {
                public const long m_Type = 0x8;
                public const long m_OwningAnimNodePaths = 0xC;
                public const long m_nOwningAnimNodePathCount = 0x38;
            }
            public static partial class CBoneConstraintPoseSpaceMorph__Input_t {
                public const long m_inputValue = 0x0;
                public const long m_outputWeightList = 0x10;
            }
            public static partial class CNmClip__ModelSpaceSamplingChainLink_t {
                public const long m_nBoneIdx = 0x0;
                public const long m_nParentBoneIdx = 0x4;
                public const long m_nParentChainLinkIdx = 0x8;
            }
            public static partial class CNmControlParameterIDNode__CDefinition {

            }
            public static partial class CNmCurrentSyncEventIDNode__CDefinition {
                public const long m_nSourceStateNodeIdx = 0x10;
            }
            public static partial class CNmFloatChannelData__ChannelSettings_t {
                public const long m_range = 0x0;
                public const long m_bIsStatic = 0x8;
            }
            public static partial class CNmFootEventConditionNode__CDefinition {
                public const long m_phaseCondition = 0x12;
                public const long m_eventConditionRules = 0x14;
                public const long m_nSourceStateNodeIdx = 0x10;
            }
            public static partial class CNmGraphDefinition__ExternalPoseSlot_t {
                public const long m_slotID = 0x8;
                public const long m_nNodeIdx = 0x0;
            }
            public static partial class CNmParameterizedBlendNode__CDefinition {
                public const long m_bAllowLooping = 0x2A;
                public const long m_sourceNodeIndices = 0x10;
                public const long m_nInputParameterValueNodeIdx = 0x28;
            }
            public static partial class CNmRootMotionOverrideNode__CDefinition {
                public const long m_overrideFlags = 0x2C;
                public const long m_enabledNodeIdx = 0x20;
                public const long m_maxLinearVelocity = 0x24;
                public const long m_maxAngularVelocityRadians = 0x28;
                public const long m_linearVelocityLimitNodeIdx = 0x1C;
                public const long m_angularVelocityLimitNodeIdx = 0x1E;
                public const long m_desiredMovingVelocityNodeIdx = 0x18;
                public const long m_desiredFacingDirectionNodeIdx = 0x1A;
            }
            public static partial class CNmStateMachineNode__StateDefinition_t {
                public const long m_nStateNodeIdx = 0x0;
                public const long m_transitionDefinitions = 0x8;
                public const long m_nEntryConditionNodeIdx = 0x2;
            }
            public static partial class CNmTimeControlledClipNode__CDefinition {
                public const long m_graphEvents = 0x18;
                public const long m_nDataSlotIdx = 0x14;
                public const long m_bSampleRootMotion = 0x12;
                public const long m_nTimeValueNodeIdx = 0x16;
                public const long m_nPlayInReverseValueNodeIdx = 0x10;
            }
            public static partial class CNmVirtualParameterIDNode__CDefinition {
                public const long m_nChildNodeIdx = 0x10;
            }
            public static partial class CPulseCell_LimitCount__InstanceState_t {
                public const long m_nCurrentCount = 0x0;
            }
            public static partial class PulseGraphExecutionHistoryCursorDesc_t {
                public const long nSpawnNodeID = 0x18;
                public const long flLastReferenced = 0x20;
                public const long nRetiredAtNodeID = 0x1C;
                public const long nLastValidEntryIdx = 0x24;
                public const long vecAncestorCursorIDs = 0x0;
                public const long bWasAnObservableComputation = 0x28;
            }
            public static partial class PulseRuntimeBlackboardReferenceIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class CCurrentRotationVelocityMetricEvaluator {

            }
            public static partial class CNmFixedWeightBoneMaskNode__CDefinition {
                public const long m_flBoneWeight = 0x10;
            }
            public static partial class CNmGraphDefinition__ExternalGraphSlot_t {
                public const long m_slotID = 0x8;
                public const long m_nNodeIdx = 0x0;
            }
            public static partial class CNmGraphEventConditionNode__CDefinition {
                public const long m_conditions = 0x18;
                public const long m_eventConditionRules = 0x14;
                public const long m_nSourceStateNodeIdx = 0x10;
            }
            public static partial class CNmGraphEventConditionNode__Condition_t {
                public const long m_eventID = 0x0;
                public const long m_eventTypeCondition = 0x8;
            }
            public static partial class CNmIDBasedClipSelectorNode__CDefinition {
                public const long m_optionIDs = 0x28;
                public const long m_nFallbackNodeIdx = 0x5A;
                public const long m_nParameterNodeIdx = 0x58;
                public const long m_optionNodeIndices = 0x10;
                public const long m_bIgnoreInvalidOptions = 0x5C;
            }
            public static partial class CNmParameterizedBlendNode__BlendRange_t {
                public const long m_nInputIdx0 = 0x0;
                public const long m_nInputIdx1 = 0x2;
                public const long m_parameterValueRange = 0x4;
            }
            public static partial class CPulseCell_IntervalTimer__CursorState_t {
                public const long m_EndTime = 0x4;
                public const long m_StartTime = 0x0;
                public const long m_flWaitInterval = 0x8;
                public const long m_flWaitIntervalHigh = 0xC;
                public const long m_bCompleteOnNextWake = 0x10;
            }
            public static partial class CMaterialDrawDescriptor__RigidMeshPart_t {
                public const long m_nBoneIndex = 0x2;
                public const long m_nPrimitiveCount = 0x8;
                public const long m_nRigidBLASIndex = 0x0;
                public const long m_nStartIndexOffset = 0x4;
            }
            public static partial class CNmControlParameterBoolNode__CDefinition {

            }
            public static partial class CNmFloatRangeComparisonNode__CDefinition {
                public const long m_range = 0x10;
                public const long m_bIsInclusiveCheck = 0x1A;
                public const long m_nInputValueNodeIdx = 0x18;
            }
            public static partial class CNmVirtualParameterBoolNode__CDefinition {
                public const long m_nChildNodeIdx = 0x10;
            }
            public static partial class PermModelDataAnimatedMaterialAttribute_t {
                public const long m_nNumChannels = 0x8;
                public const long m_AttributeName = 0x0;
            }
            public static partial class CNmControlParameterFloatNode__CDefinition {

            }
            public static partial class CNmGraphDefinition__ReferencedGraphSlot_t {
                public const long m_nNodeIdx = 0x0;
                public const long m_dataSlotIdx = 0x2;
            }
            public static partial class CNmParameterizedSelectorNode__CDefinition {
                public const long m_optionWeights = 0x28;
                public const long m_bHasWeightsSet = 0x3B;
                public const long m_parameterNodeIdx = 0x38;
                public const long m_optionNodeIndices = 0x10;
                public const long m_bIgnoreInvalidOptions = 0x3A;
            }
            public static partial class CNmVirtualParameterFloatNode__CDefinition {
                public const long m_nChildNodeIdx = 0x10;
            }
            public static partial class CPulseCell_IsRequirementValid__Criteria_t {
                public const long m_bIsValid = 0x0;
            }
            public static partial class CSceneObjectData__RTProxyDrawDescriptor_t {
                public const long m_drawDesc = 0x8;
                public const long m_nSrcDrawIndex = 0x4;
                public const long m_fEmissiveFactor = 0x164;
                public const long m_mWorldFromLocal = 0x128;
                public const long m_nVertexAlbedoVB = 0x159;
                public const long m_nVertexEmissiveVB = 0x15F;
                public const long m_materialGroupToken = 0x0;
                public const long m_nVertexAlbedoFormat = 0x158;
                public const long m_nVertexAlbedoOffset = 0x15A;
                public const long m_nVertexAlbedoStride = 0x15C;
                public const long m_nVertexEmissiveFormat = 0x15E;
                public const long m_nVertexEmissiveOffset = 0x160;
                public const long m_nVertexEmissiveStride = 0x162;
            }
            public static partial class CNmControlParameterTargetNode__CDefinition {

            }
            public static partial class CNmControlParameterVectorNode__CDefinition {

            }
            public static partial class CNmVirtualParameterTargetNode__CDefinition {
                public const long m_nChildNodeIdx = 0x10;
            }
            public static partial class CNmVirtualParameterVectorNode__CDefinition {
                public const long m_nChildNodeIdx = 0x10;
            }
            public static partial class CNmStateCompletedConditionNode__CDefinition {
                public const long m_nSourceStateNodeIdx = 0x10;
                public const long m_flTransitionDurationSeconds = 0x14;
                public const long m_nTransitionDurationOverrideNodeIdx = 0x12;
            }
            public static partial class CNmStateMachineNode__TransitionDefinition_t {
                public const long m_bCanBeForced = 0x6;
                public const long m_nTargetStateIdx = 0x0;
                public const long m_nConditionNodeIdx = 0x2;
                public const long m_nTransitionNodeIdx = 0x4;
            }
            public static partial class CNmSyncEventIndexConditionNode__CDefinition {
                public const long m_triggerMode = 0x12;
                public const long m_syncEventIdx = 0x14;
                public const long m_nSourceStateNodeIdx = 0x10;
            }
            public static partial class CNmVelocityBasedSpeedScaleNode__CDefinition {

            }
            public static partial class CNmIDEventPercentageThroughNode__CDefinition {
                public const long m_eventID = 0x18;
                public const long m_eventConditionRules = 0x14;
                public const long m_nSourceStateNodeIdx = 0x10;
            }
            public static partial class CNmTransitionEventConditionNode__CDefinition {
                public const long m_requireRuleID = 0x10;
                public const long m_ruleCondition = 0x1E;
                public const long m_eventConditionRules = 0x18;
                public const long m_nSourceStateNodeIdx = 0x1C;
            }
            public static partial class CNmVirtualParameterBoneMaskNode__CDefinition {
                public const long m_nChildNodeIdx = 0x10;
            }
            public static partial class CPulseCell_Inflow_ObservableVariableListener {
                public const long m_bSelfReference = 0x82;
                public const long m_nBlackboardReference = 0x80;
            }
            public static partial class NmCompressionSettings_t__QuantizationRange_t {
                public const long m_flRangeStart = 0x0;
                public const long m_flRangeLength = 0x4;
            }
            public static partial class PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                public const long m_OutflowID = 0x0;
                public const long m_Connection = 0x8;
            }
            public static partial class CNmIsExternalGraphSlotFilledNode__CDefinition {
                public const long m_nExternalGraphNodeIdx = 0x10;
            }
            public static partial class CNmIsInactiveBranchConditionNode__CDefinition {

            }
            public static partial class CNmParameterizedBlendNode__Parameterization_t {
                public const long m_blendRanges = 0x0;
                public const long m_parameterRange = 0x48;
            }
            public static partial class CNmParameterizedClipSelectorNode__CDefinition {
                public const long m_optionWeights = 0x28;
                public const long m_bHasWeightsSet = 0x3B;
                public const long m_parameterNodeIdx = 0x38;
                public const long m_optionNodeIndices = 0x10;
                public const long m_bIgnoreInvalidOptions = 0x3A;
            }
            public static partial class CModelConfigElement_SetBodygroupOnAttachedModels {
                public const long m_nChoice = 0x50;
                public const long m_GroupName = 0x48;
            }
            public static partial class CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                public const long m_nNextIndex = 0x0;
            }
            public static partial class CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                public const long m_Shuffle = 0x0;
                public const long m_nNextShuffle = 0x20;
            }
            public static partial class CNmFootstepEventPercentageThroughNode__CDefinition {
                public const long m_phaseCondition = 0x12;
                public const long m_eventConditionRules = 0x14;
                public const long m_nSourceStateNodeIdx = 0x10;
            }
            public static partial class CModelConfigElement_SetMaterialGroupOnAttachedModels {
                public const long m_MaterialGroupName = 0x48;
            }
            public static partial class SeqCmd_t {
                public const long SeqCmd_Add = 0x4;
                public const long SeqCmd_Nop = 0x0;
                public const long SeqCmd_Copy = 0x7;
                public const long SeqCmd_Blend = 0x8;
                public const long SeqCmd_Scale = 0x6;
                public const long SeqCmd_Slerp = 0x3;
                public const long SeqCmd_Sequence = 0xA;
                public const long SeqCmd_Subtract = 0x5;
                public const long SeqCmd_Transform = 0x10;
                public const long SeqCmd_FetchCycle = 0xB;
                public const long SeqCmd_FetchFrame = 0xC;
                public const long SeqCmd_Worldspace = 0x9;
                public const long SeqCmd_LinearDelta = 0x1;
                public const long SeqCmd_IKRestoreAll = 0xE;
                public const long SeqCmd_IKLockInPlace = 0xD;
                public const long SeqCmd_FetchFrameRange = 0x2;
                public const long SeqCmd_ReverseSequence = 0xF;
            }
            public static partial class StepPhase {
                public const long StepPhase_InAir = 0x1;
                public const long StepPhase_OnGround = 0x0;
            }
            public static partial class FacingMode {
                public const long FacingMode_Path = 0x2;
                public const long FacingMode_Manual = 0x1;
                public const long FacingMode_Invalid = 0x0;
                public const long FacingMode_LookTarget = 0x3;
                public const long FacingMode_ManualPosition = 0x4;
            }
            public static partial class MoodType_t {
                public const long eMoodType_Body = 0x1;
                public const long eMoodType_Head = 0x0;
            }
            public static partial class PoseType_t {
                public const long POSETYPE_STATIC = 0x0;
                public const long POSETYPE_DYNAMIC = 0x1;
                public const long POSETYPE_INVALID = 0xFF;
            }
            public static partial class Blend2DMode {
                public const long Blend2DMode_General = 0x0;
                public const long Blend2DMode_Directional = 0x1;
            }
            public static partial class BlendKeyType {
                public const long BlendKey_Distance = 0x2;
                public const long BlendKey_Velocity = 0x1;
                public const long BlendKey_UserValue = 0x0;
                public const long BlendKey_RemainingDistance = 0x3;
            }
            public static partial class ChoiceMethod {
                public const long Iterate = 0x2;
                public const long IterateRandom = 0x3;
                public const long WeightedRandom = 0x0;
                public const long WeightedRandomNoRepeat = 0x1;
            }
            public static partial class FlexOpCode_t {
                public const long FLEX_OP_ABS = 0x1A;
                public const long FLEX_OP_ADD = 0x4;
                public const long FLEX_OP_COS = 0x19;
                public const long FLEX_OP_DIV = 0x7;
                public const long FLEX_OP_EXP = 0x9;
                public const long FLEX_OP_MAX = 0xD;
                public const long FLEX_OP_MIN = 0xE;
                public const long FLEX_OP_MUL = 0x6;
                public const long FLEX_OP_NEG = 0x8;
                public const long FLEX_OP_SIN = 0x18;
                public const long FLEX_OP_SUB = 0x5;
                public const long FLEX_OP_NWAY = 0x11;
                public const long FLEX_OP_OPEN = 0xA;
                public const long FLEX_OP_SQRT = 0x16;
                public const long FLEX_OP_CLOSE = 0xB;
                public const long FLEX_OP_COMBO = 0x12;
                public const long FLEX_OP_COMMA = 0xC;
                public const long FLEX_OP_CONST = 0x1;
                public const long FLEX_OP_2WAY_0 = 0xF;
                public const long FLEX_OP_2WAY_1 = 0x10;
                public const long FLEX_OP_FETCH1 = 0x2;
                public const long FLEX_OP_FETCH2 = 0x3;
                public const long FLEX_OP_DOMINATE = 0x13;
                public const long FLEX_OP_REMAPVALCLAMPED = 0x17;
                public const long FLEX_OP_DME_LOWER_EYELID = 0x14;
                public const long FLEX_OP_DME_UPPER_EYELID = 0x15;
            }
            public static partial class IKSolverType {
                public const long IKSOLVER_CCD = 0x4;
                public const long IKSOLVER_COUNT = 0x5;
                public const long IKSOLVER_Fabrik = 0x2;
                public const long IKSOLVER_Perlin = 0x0;
                public const long IKSOLVER_TwoBone = 0x1;
                public const long IKSOLVER_DogLeg3Bone = 0x3;
            }
            public static partial class IkTargetType {
                public const long IkTarget_Bone = 0x1;
                public const long IkTarget_Attachment = 0x0;
                public const long IkTarget_Parameter_ModelSpace = 0x2;
                public const long IkTarget_Parameter_WorldSpace = 0x3;
            }
            public static partial class IKChannelMode {
                public const long OneBone = 0x2;
                public const long TwoBone = 0x0;
                public const long OneBone_Translate = 0x3;
                public const long TwoBone_Translate = 0x1;
            }
            public static partial class NmFootPhase_t {
                public const long _None = 0x4;
                public const long LeftFootDown = 0x0;
                public const long RightFootDown = 0x2;
                public const long LeftFootPassing = 0x3;
                public const long RightFootPassing = 0x1;
            }
            public static partial class PFNoiseType_t {
                public const long PF_NOISE_TYPE_CURL = 0x3;
                public const long PF_NOISE_TYPE_PERLIN = 0x0;
                public const long PF_NOISE_TYPE_WORLEY = 0x2;
                public const long PF_NOISE_TYPE_SIMPLEX = 0x1;
            }
            public static partial class AnimScriptType {
                public const long ANIMSCRIPT_FUSE_GENERAL = 0x0;
                public const long ANIMSCRIPT_TYPE_INVALID = -0x1;
                public const long ANIMSCRIPT_FUSE_STATEMACHINE = 0x1;
            }
            public static partial class IKTargetSource {
                public const long IKTARGETSOURCE_Bone = 0x0;
                public const long IKTARGETSOURCE_COUNT = 0x2;
                public const long IKTARGETSOURCE_AnimgraphParameter = 0x1;
            }
            public static partial class AnimParamType_t {
                public const long ANIMPARAM_INT = 0x3;
                public const long ANIMPARAM_BOOL = 0x1;
                public const long ANIMPARAM_ENUM = 0x2;
                public const long ANIMPARAM_COUNT = 0x8;
                public const long ANIMPARAM_FLOAT = 0x4;
                public const long ANIMPARAM_VECTOR = 0x5;
                public const long ANIMPARAM_UNKNOWN = 0x0;
                public const long ANIMPARAM_QUATERNION = 0x6;
                public const long ANIMPARAM_GLOBALSYMBOL = 0x7;
            }
            public static partial class AnimValueSource {
                public const long SlopeYaw = 0x14;
                public const long LookPitch = 0x7;
                public const long MoveSpeed = 0x1;
                public const long Parameter = 0x9;
                public const long SlopeAngle = 0x12;
                public const long SlopePitch = 0x13;
                public const long LookHeading = 0x5;
                public const long MoveHeading = 0x0;
                public const long StrafeSpeed = 0x3;
                public const long ForwardSpeed = 0x2;
                public const long GoalDistance = 0x15;
                public const long LookDistance = 0x8;
                public const long MaxMoveSpeed = 0x1B;
                public const long SlopeHeading = 0x11;
                public const long FacingHeading = 0x4;
                public const long BoundaryRadius = 0xC;
                public const long FingerCurl_Ring = 0x1F;
                public const long RootMotionSpeed = 0x18;
                public const long TargetMoveSpeed = 0xE;
                public const long WayPointHeading = 0xA;
                public const long FingerCurl_Index = 0x1D;
                public const long FingerCurl_Pinky = 0x20;
                public const long FingerCurl_Thumb = 0x1C;
                public const long WayPointDistance = 0xB;
                public const long AccelerationSpeed = 0x10;
                public const long FingerCurl_Middle = 0x1E;
                public const long TargetMoveHeading = 0xD;
                public const long AccelerationHeading = 0xF;
                public const long RootMotionTurnSpeed = 0x19;
                public const long AccelerationFrontBack = 0x17;
                public const long AccelerationLeftRight = 0x16;
                public const long LookHeadingNormalized = 0x6;
                public const long FingerSplay_Ring_Pinky = 0x24;
                public const long FingerSplay_Middle_Ring = 0x23;
                public const long FingerSplay_Thumb_Index = 0x21;
                public const long FingerSplay_Index_Middle = 0x22;
                public const long MoveHeadingRelativeToLookHeading = 0x1A;
            }
            public static partial class AnimationType_t {
                public const long ANIMATION_TYPE_FIXED_RATE = 0x0;
                public const long ANIMATION_TYPE_FIT_LIFETIME = 0x1;
                public const long ANIMATION_TYPE_MANUAL_FRAMES = 0x2;
            }
            public static partial class NmIKBlendMode_t {
                public const long Pose = 0x1;
                public const long Effector = 0x0;
            }
            public static partial class TagActionStatus {
                public const long Fired = 0x2;
                public const long Active = 0x1;
                public const long Inactive = 0x0;
            }
            public static partial class AnimVectorSource {
                public const long LookTarget = 0x8;
                public const long SlopeNormal = 0x6;
                public const long Acceleration = 0x5;
                public const long GoalPosition = 0xB;
                public const long LookDirection = 0x2;
                public const long MoveDirection = 0x0;
                public const long FacingPosition = 0x1;
                public const long VectorParameter = 0x3;
                public const long WayPointPosition = 0xA;
                public const long WayPointDirection = 0x4;
                public const long RootMotionVelocity = 0xC;
                public const long LookTarget_WorldSpace = 0x9;
                public const long SlopeNormal_WorldSpace = 0x7;
                public const long ManualTarget_WorldSpace = 0xD;
            }
            public static partial class BinaryNodeTiming {
                public const long UseChild1 = 0x0;
                public const long UseChild2 = 0x1;
                public const long SyncChildren = 0x2;
            }
            public static partial class PulseValueType_t {
                public const long PVAL_INT = 0x1;
                public const long PVAL_BOOL = 0x0;
                public const long PVAL_VEC2 = 0x4;
                public const long PVAL_VEC3 = 0x5;
                public const long PVAL_VEC4 = 0x8;
                public const long PVAL_VOID = -0x1;
                public const long PVAL_ARRAY = 0x1C;
                public const long PVAL_COUNT = 0x21;
                public const long PVAL_FLOAT = 0x2;
                public const long PVAL_QANGLE = 0x6;
                public const long PVAL_STRING = 0x3;
                public const long PVAL_EHANDLE = 0xD;
                public const long PVAL_UNKNOWN = 0x18;
                public const long PVAL_VARIANT = 0x17;
                public const long PVAL_GAMETIME = 0xC;
                public const long PVAL_RESOURCE = 0xE;
                public const long PVAL_COLOR_RGB = 0xB;
                public const long PVAL_TRANSFORM = 0x9;
                public const long PVAL_CURSOR_FLOW = 0x16;
                public const long PVAL_ENTITY_NAME = 0x12;
                public const long PVAL_SCHEMA_ENUM = 0x19;
                public const long PVAL_SNDEVT_GUID = 0x10;
                public const long PVAL_SNDEVT_NAME = 0x11;
                public const long PVAL_TEST_HANDLE = 0x1B;
                public const long PVAL_TYPESAFE_INT = 0x14;
                public const long PVAL_VDATA_CHOICE = 0x20;
                public const long PVAL_ANIM_SEQUENCE = 0x1F;
                public const long PVAL_OPAQUE_HANDLE = 0x13;
                public const long PVAL_RESOURCE_NAME = 0xF;
                public const long PVAL_TYPESAFE_INT64 = 0x1D;
                public const long PVAL_VEC3_WORLDSPACE = 0x7;
                public const long PVAL_PARTICLE_EHANDLE = 0x1E;
                public const long PVAL_MODEL_MATERIAL_GROUP = 0x15;
                public const long PVAL_TRANSFORM_WORLDSPACE = 0xA;
                public const long PVAL_PANORAMA_PANEL_HANDLE = 0x1A;
            }
            public static partial class ResetCycleOption {
                public const long Beginning = 0x0;
                public const long FixedValue = 0x3;
                public const long SameTimeAsSource = 0x4;
                public const long SameCycleAsSource = 0x1;
                public const long InverseSourceCycle = 0x2;
            }
            public static partial class ScriptedMoveTo_t {
                public const long eWait = 0x0;
                public const long eTeleport = 0x4;
                public const long eWaitFacing = 0x5;
                public const long eMoveWithGait = 0x3;
                public const long eObsoleteBackCompat1 = 0x1;
                public const long eObsoleteBackCompat2 = 0x2;
            }
            public static partial class SeqPoseSetting_t {
                public const long SEQ_POSE_SETTING_CONSTANT = 0x0;
                public const long SEQ_POSE_SETTING_POSITION = 0x2;
                public const long SEQ_POSE_SETTING_ROTATION = 0x1;
                public const long SEQ_POSE_SETTING_VELOCITY = 0x3;
            }
            public static partial class AnimParamButton_t {
                public const long ANIMPARAM_BUTTON_A = 0x5;
                public const long ANIMPARAM_BUTTON_B = 0x6;
                public const long ANIMPARAM_BUTTON_X = 0x7;
                public const long ANIMPARAM_BUTTON_Y = 0x8;
                public const long ANIMPARAM_BUTTON_NONE = 0x0;
                public const long ANIMPARAM_BUTTON_DPAD_UP = 0x1;
                public const long ANIMPARAM_BUTTON_LTRIGGER = 0xB;
                public const long ANIMPARAM_BUTTON_RTRIGGER = 0xC;
                public const long ANIMPARAM_BUTTON_DPAD_DOWN = 0x3;
                public const long ANIMPARAM_BUTTON_DPAD_LEFT = 0x4;
                public const long ANIMPARAM_BUTTON_DPAD_RIGHT = 0x2;
                public const long ANIMPARAM_BUTTON_LEFT_SHOULDER = 0x9;
                public const long ANIMPARAM_BUTTON_RIGHT_SHOULDER = 0xA;
            }
            public static partial class ChoiceBlendMethod {
                public const long SingleBlendTime = 0x0;
                public const long PerChoiceBlendTimes = 0x1;
            }
            public static partial class FootFallTagFoot_t {
                public const long FOOT1 = 0x0;
                public const long FOOT2 = 0x1;
                public const long FOOT3 = 0x2;
                public const long FOOT4 = 0x3;
                public const long FOOT5 = 0x4;
                public const long FOOT6 = 0x5;
                public const long FOOT7 = 0x6;
                public const long FOOT8 = 0x7;
            }
            public static partial class IkEndEffectorType {
                public const long IkEndEffector_Bone = 0x1;
                public const long IkEndEffector_Attachment = 0x0;
            }
            public static partial class MorphBundleType_t {
                public const long MORPH_BUNDLE_TYPE_NONE = 0x0;
                public const long MORPH_BUNDLE_TYPE_COUNT = 0x3;
                public const long MORPH_BUNDLE_TYPE_NORMAL_WRINKLE = 0x2;
                public const long MORPH_BUNDLE_TYPE_POSITION_SPEED = 0x1;
            }
            public static partial class NmPoseBlendMode_t {
                public const long Overlay = 0x0;
                public const long Additive = 0x1;
                public const long ModelSpace = 0x2;
            }
            public static partial class PFNoiseModifier_t {
                public const long PF_NOISE_MODIFIER_NONE = 0x0;
                public const long PF_NOISE_MODIFIER_LINES = 0x1;
                public const long PF_NOISE_MODIFIER_RINGS = 0x3;
                public const long PF_NOISE_MODIFIER_CLUMPS = 0x2;
            }
            public static partial class ParticleVecType_t {
                public const long PVEC_TYPE_COUNT = 0x13;
                public const long PVEC_TYPE_INVALID = -0x1;
                public const long PVEC_TYPE_LITERAL = 0x0;
                public const long PVEC_TYPE_CP_DELTA = 0x11;
                public const long PVEC_TYPE_CP_VALUE = 0x7;
                public const long PVEC_TYPE_NAMED_VALUE = 0x2;
                public const long PVEC_TYPE_LITERAL_COLOR = 0x1;
                public const long PVEC_TYPE_RANDOM_UNIFORM = 0xF;
                public const long PVEC_TYPE_CP_RELATIVE_DIR = 0x9;
                public const long PVEC_TYPE_PARTICLE_VECTOR = 0x3;
                public const long PVEC_TYPE_FLOAT_COMPONENTS = 0xB;
                public const long PVEC_TYPE_PARTICLE_GRAVITY = 0x6;
                public const long PVEC_TYPE_FLOAT_INTERP_OPEN = 0xD;
                public const long PVEC_TYPE_PARTICLE_VELOCITY = 0x5;
                public const long PVEC_TYPE_CP_RELATIVE_POSITION = 0x8;
                public const long PVEC_TYPE_FLOAT_INTERP_CLAMPED = 0xC;
                public const long PVEC_TYPE_FLOAT_INTERP_GRADIENT = 0xE;
                public const long PVEC_TYPE_RANDOM_UNIFORM_OFFSET = 0x10;
                public const long PVEC_TYPE_CP_RELATIVE_RANDOM_DIR = 0xA;
                public const long PVEC_TYPE_CLOSEST_CAMERA_POSITION = 0x12;
                public const long PVEC_TYPE_PARTICLE_INITIAL_VECTOR = 0x4;
            }
            public static partial class PulseApiFeature_t {
                public const long AF_NONE = 0x0;
                public const long AF_ENTITIES = 0x1;
                public const long AF_PANORAMA = 0x2;
                public const long AF_PARTICLES = 0x8;
                public const long AF_FAKE_ENTITIES = 0x10;
                public const long AF_SELECTORS_WITHOUT_REQUIREMENTS = 0x20;
            }
            public static partial class AimMatrixBlendMode {
                public const long AimMatrixBlendMode_None = 0x0;
                public const long AimMatrixBlendMode_Additive = 0x1;
                public const long AimMatrixBlendMode_BoneMask = 0x3;
                public const long AimMatrixBlendMode_ModelSpaceAdditive = 0x2;
            }
            public static partial class BoneMaskBlendSpace {
                public const long BlendSpace_Model = 0x1;
                public const long BlendSpace_Parent = 0x0;
                public const long BlendSpace_Model_RotationOnly = 0x2;
                public const long BlendSpace_Model_TranslationOnly = 0x3;
            }
            public static partial class ChoiceChangeMethod {
                public const long OnReset = 0x0;
                public const long OnCycleEnd = 0x1;
                public const long OnResetOrCycleEnd = 0x2;
            }
            public static partial class FieldNetworkOption {
                public const long Auto = 0x0;
                public const long ForceEnable = 0x1;
                public const long ForceDisable = 0x2;
            }
            public static partial class HandshakeTagType_t {
                public const long eTask = 0x0;
                public const long eCount = 0x2;
                public const long eInvalid = -0x1;
                public const long eMovement = 0x1;
            }
            public static partial class JiggleBoneSimSpace {
                public const long SimSpace_Local = 0x0;
                public const long SimSpace_Model = 0x1;
                public const long SimSpace_World = 0x2;
            }
            public static partial class NmEasingFunction_t {
                public const long Back = 0x8;
                public const long Circ = 0x7;
                public const long Expo = 0x6;
                public const long Quad = 0x1;
                public const long Sine = 0x5;
                public const long Cubic = 0x2;
                public const long Quart = 0x3;
                public const long Quint = 0x4;
                public const long Linear = 0x0;
            }
            public static partial class NmFollowBoneMode_t {
                public const long RotationOnly = 0x1;
                public const long TranslationOnly = 0x2;
                public const long RotationAndTranslation = 0x0;
            }
            public static partial class NmGraphDebugMode_t {
                public const long On = 0x1;
                public const long Off = 0x0;
            }
            public static partial class NmGraphValueType_t {
                public const long ID = 0x2;
                public const long Bool = 0x1;
                public const long Pose = 0x7;
                public const long Float = 0x3;
                public const long Target = 0x5;
                public const long Vector = 0x4;
                public const long Special = 0x8;
                public const long Unknown = 0x0;
                public const long BoneMask = 0x6;
            }
            public static partial class NmTargetWarpRule_t {
                public const long WarpZ = 0x1;
                public const long WarpXY = 0x0;
                public const long WarpXYZ = 0x2;
                public const long FixedSection = 0x4;
                public const long RotationOnly = 0x3;
            }
            public static partial class NmTransitionRule_t {
                public const long AllowTransition = 0x0;
                public const long BlockTransition = 0x2;
                public const long ConditionallyAllowTransition = 0x1;
            }
            public static partial class RagdollPoseControl {
                public const long Absolute = 0x0;
            }
            public static partial class StanceOverrideMode {
                public const long Node = 0x1;
                public const long Sequence = 0x0;
            }
            public static partial class VelocityMetricMode {
                public const long DirectionOnly = 0x0;
                public const long MagnitudeOnly = 0x1;
                public const long DirectionAndMagnitude = 0x2;
            }
            public static partial class AnimNodeNetworkMode {
                public const long ClientSimulate = 0x1;
                public const long ServerAuthoritative = 0x0;
            }
            public static partial class CNmEventRelevance_t {
                public const long ClientOnly = 0x0;
                public const long ServerOnly = 0x1;
                public const long ClientAndServer = 0x2;
            }
            public static partial class FootstepJumpPhase_t {
                public const long Jumping = 0x2;
                public const long Landing = 0x4;
                public const long Unknown = 0x0;
                public const long NotJumping = 0x1;
            }
            public static partial class HandshakeTagState_t {
                public const long eActive = 0x1;
                public const long eInactive = 0x0;
                public const long eMomentarilyInactive = 0x2;
            }
            public static partial class NmCachedValueMode_t {
                public const long OnExit = 0x1;
                public const long OnEntry = 0x0;
            }
            public static partial class NmEasingOperation_t {
                public const long _None = 0x16;
                public const long InCirc = 0x13;
                public const long InExpo = 0x10;
                public const long InQuad = 0x1;
                public const long InSine = 0xD;
                public const long Linear = 0x0;
                public const long InCubic = 0x4;
                public const long InQuart = 0x7;
                public const long InQuint = 0xA;
                public const long OutCirc = 0x14;
                public const long OutExpo = 0x11;
                public const long OutQuad = 0x2;
                public const long OutSine = 0xE;
                public const long OutCubic = 0x5;
                public const long OutQuart = 0x8;
                public const long OutQuint = 0xB;
                public const long InOutCirc = 0x15;
                public const long InOutExpo = 0x12;
                public const long InOutQuad = 0x3;
                public const long InOutSine = 0xF;
                public const long InOutCubic = 0x6;
                public const long InOutQuart = 0x9;
                public const long InOutQuint = 0xC;
            }
            public static partial class PFNoiseTurbulence_t {
                public const long PF_NOISE_TURB_NONE = 0x0;
                public const long PF_NOISE_TURB_LOOPY = 0x3;
                public const long PF_NOISE_TURB_CONTRAST = 0x4;
                public const long PF_NOISE_TURB_FEEDBACK = 0x2;
                public const long PF_NOISE_TURB_ALTERNATE = 0x5;
                public const long PF_NOISE_TURB_HIGHLIGHT = 0x1;
            }
            public static partial class ParticleFloatType_t {
                public const long PF_TYPE_COUNT = 0x20;
                public const long PF_TYPE_INVALID = -0x1;
                public const long PF_TYPE_LITERAL = 0x0;
                public const long PF_TYPE_ENDCAP_AGE = 0x5;
                public const long PF_TYPE_NAMED_VALUE = 0x1;
                public const long PF_TYPE_PARTICLE_AGE = 0x13;
                public const long PF_TYPE_RANDOM_BIASED = 0x3;
                public const long PF_TYPE_COLLECTION_AGE = 0x4;
                public const long PF_TYPE_PARTICLE_FLOAT = 0x15;
                public const long PF_TYPE_PARTICLE_NOISE = 0x12;
                public const long PF_TYPE_PARTICLE_SPEED = 0x19;
                public const long PF_TYPE_RANDOM_UNIFORM = 0x2;
                public const long PF_TYPE_SNAPSHOT_COUNT = 0xD;
                public const long PF_TYPE_PARTICLE_NUMBER = 0x1A;
                public const long PF_TYPE_SNAPSHOT_CHANGED = 0xE;
                public const long PF_TYPE_CONTROL_POINT_SPEED = 0x8;
                public const long PF_TYPE_CONCURRENT_DEF_COUNT = 0xB;
                public const long PF_TYPE_CONTROL_POINT_IS_SET = 0xF;
                public const long PF_TYPE_PARTICLE_DETAIL_LEVEL = 0xA;
                public const long PF_TYPE_PARTICLE_ROPE_SEGMENT = 0x1C;
                public const long PF_TYPE_CONTROL_POINT_DISTANCE = 0x9;
                public const long PF_TYPE_PARTICLE_INITIAL_FLOAT = 0x16;
                public const long PF_TYPE_CLOSEST_CAMERA_DISTANCE = 0xC;
                public const long PF_TYPE_CONTROL_POINT_COMPONENT = 0x6;
                public const long PF_TYPE_PARTICLE_AGE_NORMALIZED = 0x14;
                public const long PF_TYPE_CONTROL_POINT_CHANGE_AGE = 0x7;
                public const long PF_TYPE_RENDERER_CAMERA_DISTANCE = 0x10;
                public const long PF_TYPE_PARTICLE_VECTOR_COMPONENT = 0x17;
                public const long PF_TYPE_PARTICLE_NUMBER_NORMALIZED = 0x1B;
                public const long PF_TYPE_RENDERER_CAMERA_DOT_PRODUCT = 0x11;
                public const long PF_TYPE_PARTICLE_ROPE_SEGMENT_NORMALIZED = 0x1D;
                public const long PF_TYPE_PARTICLE_INITIAL_VECTOR_COMPONENT = 0x18;
                public const long PF_TYPE_PARTICLE_SCREENSPACE_CAMERA_DISTANCE = 0x1E;
                public const long PF_TYPE_PARTICLE_SCREENSPACE_CAMERA_DOT_PRODUCT = 0x1F;
            }
            public static partial class ParticleModelType_t {
                public const long PM_TYPE_COUNT = 0x4;
                public const long PM_TYPE_INVALID = 0x0;
                public const long PM_TYPE_CONTROL_POINT = 0x3;
                public const long PM_TYPE_NAMED_VALUE_MODEL = 0x1;
                public const long PM_TYPE_NAMED_VALUE_EHANDLE = 0x2;
            }
            public static partial class ParticleSetMethod_t {
                public const long PARTICLE_SET_REPLACE_VALUE = 0x0;
                public const long PARTICLE_SET_RAMP_CURRENT_VALUE = 0x3;
                public const long PARTICLE_SET_SCALE_CURRENT_VALUE = 0x4;
                public const long PARTICLE_SET_SCALE_INITIAL_VALUE = 0x1;
                public const long PARTICLE_SET_ADD_TO_CURRENT_VALUE = 0x5;
                public const long PARTICLE_SET_ADD_TO_INITIAL_VALUE = 0x2;
            }
            public static partial class StateActionBehavior {
                public const long STATETAGBEHAVIOR_FIRE_ON_EXIT = 0x2;
                public const long STATETAGBEHAVIOR_FIRE_ON_ENTER = 0x1;
                public const long STATETAGBEHAVIOR_ACTIVE_WHILE_CURRENT = 0x0;
                public const long STATETAGBEHAVIOR_FIRE_ON_ENTER_AND_EXIT = 0x3;
                public const long STATETAGBEHAVIOR_ACTIVE_WHILE_FULLY_BLENDED = 0x4;
            }
            public static partial class BoneTransformSpace_t {
                public const long BoneTransformSpace_Model = 0x1;
                public const long BoneTransformSpace_World = 0x2;
                public const long BoneTransformSpace_Parent = 0x0;
                public const long BoneTransformSpace_Invalid = -0x1;
            }
            public static partial class DampingSpeedFunction {
                public const long Spring = 0x2;
                public const long Constant = 0x1;
                public const long NoDamping = 0x0;
                public const long AsymmetricSpring = 0x3;
            }
            public static partial class JumpCorrectionMethod {
                public const long ScaleMotion = 0x0;
                public const long AddCorrectionDelta = 0x1;
            }
            public static partial class MovementCapability_t {
                public const long eLean = 0x8;
                public const long eStop = 0x3;
                public const long eCount = 0xA;
                public const long eStart = 0x2;
                public const long eStrafe = 0x0;
                public const long eShuffle = 0x5;
                public const long eIdleTurn = 0x1;
                public const long eInstantStop = 0x4;
                public const long ePlantedTurn = 0x6;
                public const long eForwardStartOnly = 0x9;
                public const long eUseStartAsPlantedTurn = 0x7;
            }
            public static partial class NPCPhysicsHullType_t {
                public const long eInvalid = 0x0;
                public const long eGroundBox = 0x4;
                public const long eGroundCapsule = 0x1;
                public const long eGenericCapsule = 0x3;
                public const long eGroundCylinder = 0x5;
                public const long eCenteredCapsule = 0x2;
                public const long eCenteredCylinder = 0x6;
            }
            public static partial class ParticleAttachment_t {
                public const long PATTACH_POINT = 0x4;
                public const long PATTACH_INVALID = -0x1;
                public const long MAX_PATTACH_TYPES = 0x10;
                public const long PATTACH_ABSORIGIN = 0x0;
                public const long PATTACH_HEALTHBAR = 0xF;
                public const long PATTACH_MAIN_VIEW = 0xB;
                public const long PATTACH_WATERWAKE = 0xC;
                public const long PATTACH_EYES_FOLLOW = 0x6;
                public const long PATTACH_WORLDORIGIN = 0x8;
                public const long PATTACH_CUSTOMORIGIN = 0x2;
                public const long PATTACH_POINT_FOLLOW = 0x5;
                public const long PATTACH_CENTER_FOLLOW = 0xD;
                public const long PATTACH_OVERHEAD_FOLLOW = 0x7;
                public const long PATTACH_ROOTBONE_FOLLOW = 0x9;
                public const long PATTACH_ABSORIGIN_FOLLOW = 0x1;
                public const long PATTACH_CUSTOMORIGIN_FOLLOW = 0x3;
                public const long PATTACH_CUSTOM_GAME_STATE_1 = 0xE;
                public const long PATTACH_RENDERORIGIN_FOLLOW = 0xA;
            }
            public static partial class RenderMeshSlotType_t {
                public const long RENDERMESH_SLOT_INVALID = -0x1;
                public const long RENDERMESH_SLOT_PER_VERTEX = 0x0;
                public const long RENDERMESH_SLOT_PER_INSTANCE = 0x1;
            }
            public static partial class SharedMovementGait_t {
                public const long eFast = 0x2;
                public const long eSlow = 0x0;
                public const long eCount = 0x4;
                public const long eMedium = 0x1;
                public const long eInvalid = -0x1;
                public const long eVeryFast = 0x3;
            }
            public static partial class VertexAlbedoFormat_t {
                public const long VERTEX_ALBEDO_565 = 0x2;
                public const long VERTEX_ALBEDO_8888 = 0x1;
                public const long VERTEX_ALBEDO_NONE = 0x0;
            }
            public static partial class AnimParamVectorType_t {
                public const long ANIMPARAM_VECTOR_TYPE_NONE = 0x0;
                public const long ANIMPARAM_VECTOR_TYPE_POSITION_LS = 0x2;
                public const long ANIMPARAM_VECTOR_TYPE_POSITION_WS = 0x1;
                public const long ANIMPARAM_VECTOR_TYPE_DIRECTION_LS = 0x4;
                public const long ANIMPARAM_VECTOR_TYPE_DIRECTION_WS = 0x3;
            }
            public static partial class BinaryNodeChildOption {
                public const long Child1 = 0x0;
                public const long Child2 = 0x1;
            }
            public static partial class CNmClothEvent__Type_t {
                public const long Effect = 0x1;
                public const long Stiffen = 0x0;
            }
            public static partial class OrientationWarpMode_t {
                public const long eAngle = 0x1;
                public const long eInvalid = 0x0;
                public const long eWorldPosition = 0x2;
            }
            public static partial class PulseMethodCallMode_t {
                public const long ASYNC_FIRE_AND_FORGET = 0x1;
                public const long SYNC_WAIT_FOR_COMPLETION = 0x0;
            }
            public static partial class SelectorTagBehavior_t {
                public const long SelectorTagBehavior_OnWhileCurrent = 0x0;
                public const long SelectorTagBehavior_OffWhenFinished = 0x1;
                public const long SelectorTagBehavior_OffBeforeFinished = 0x2;
            }
            public static partial class TargetWarpAngleMode_t {
                public const long eMoveHeading = 0x1;
                public const long eFacingHeading = 0x0;
            }
            public static partial class CNmEventTargetEntity_t {
                public const long _Self = 0x0;
                public const long Custom = 0x3;
                public const long Weapon = 0x1;
                public const long HeldItem = 0x2;
            }
            public static partial class EDemoBoneSelectionMode {
                public const long CaptureAllBones = 0x0;
                public const long CaptureSelectedBones = 0x1;
            }
            public static partial class ModelMeshBufferUsage_t {
                public const long MESH_BUFFER_USAGE_IB = 0x2;
                public const long MESH_BUFFER_USAGE_VB = 0x1;
                public const long MESH_BUFFER_USAGE_NONE = 0x0;
                public const long MESH_BUFFER_USAGE_MESHLETS = 0x80;
                public const long MESH_BUFFER_USAGE_RT_PROXY = 0x10;
                public const long MESH_BUFFER_USAGE_ADJACENCY = 0x4;
                public const long MESH_BUFFER_USAGE_ALIAS_TABLE = 0x100;
                public const long MESH_BUFFER_USAGE_MESHLET_TRIS = 0x8;
                public const long MESH_BUFFER_USAGE_VERTEX_ALBEDO = 0x20;
                public const long MESH_BUFFER_USAGE_VERTEX_EMISSIVE = 0x40;
            }
            public static partial class NmFootPhaseCondition_t {
                public const long _None = 0x6;
                public const long LeftPhase = 0x4;
                public const long RightPhase = 0x5;
                public const long LeftFootDown = 0x0;
                public const long RightFootDown = 0x2;
                public const long LeftFootPassing = 0x1;
                public const long RightFootPassing = 0x3;
            }
            public static partial class NmFrameSnapEventMode_t {
                public const long Floor = 0x0;
                public const long Round = 0x1;
            }
            public static partial class ParticleFloatMapType_t {
                public const long PF_MAP_TYPE_MAX = 0x8;
                public const long PF_MAP_TYPE_MIN = 0x7;
                public const long PF_MAP_TYPE_MOD = 0x9;
                public const long PF_MAP_TYPE_MULT = 0x1;
                public const long PF_MAP_TYPE_COUNT = 0xA;
                public const long PF_MAP_TYPE_CURVE = 0x4;
                public const long PF_MAP_TYPE_REMAP = 0x2;
                public const long PF_MAP_TYPE_ROUND = 0x6;
                public const long PF_MAP_TYPE_DIRECT = 0x0;
                public const long PF_MAP_TYPE_INVALID = -0x1;
                public const long PF_MAP_TYPE_NOTCHED = 0x5;
                public const long PF_MAP_TYPE_REMAP_BIASED = 0x3;
            }
            public static partial class PulseDomainValueType_t {
                public const long COUNT = 0x2;
                public const long INVALID = -0x1;
                public const long PANEL_ID = 0x1;
                public const long ENTITY_NAME = 0x0;
            }
            public static partial class PulseInstructionCode_t {
                public const long EQ = 0x22;
                public const long LT = 0x20;
                public const long NE = 0x23;
                public const long OR = 0x25;
                public const long ADD = 0x1B;
                public const long AND = 0x24;
                public const long DIV = 0x1E;
                public const long LTE = 0x21;
                public const long MOD = 0x1F;
                public const long MUL = 0x1D;
                public const long NOP = 0x5;
                public const long NOT = 0x19;
                public const long SUB = 0x1C;
                public const long COPY = 0x18;
                public const long JUMP = 0x6;
                public const long SCALE = 0x26;
                public const long EQ_INT = 0x55;
                public const long LT_INT = 0x4E;
                public const long NEGATE = 0x1A;
                public const long NE_INT = 0x66;
                public const long ADD_INT = 0x36;
                public const long EQ_BOOL = 0x54;
                public const long EQ_VEC2 = 0x57;
                public const long EQ_VEC3 = 0x58;
                public const long EQ_VEC4 = 0x5A;
                public const long GET_VAR = 0x10;
                public const long INVALID = 0x0;
                public const long LTE_INT = 0x51;
                public const long MOD_INT = 0x4C;
                public const long MUL_INT = 0x49;
                public const long NE_BOOL = 0x65;
                public const long NE_VEC2 = 0x68;
                public const long NE_VEC3 = 0x69;
                public const long NE_VEC4 = 0x6B;
                public const long SET_VAR = 0xF;
                public const long SUB_INT = 0x40;
                public const long ADD_VEC2 = 0x39;
                public const long ADD_VEC3 = 0x3A;
                public const long ADD_VEC4 = 0x3D;
                public const long EQ_ARRAY = 0x63;
                public const long EQ_FLOAT = 0x56;
                public const long LT_FLOAT = 0x4F;
                public const long NE_ARRAY = 0x74;
                public const long NE_FLOAT = 0x67;
                public const long SUB_VEC2 = 0x42;
                public const long SUB_VEC3 = 0x43;
                public const long SUB_VEC4 = 0x46;
                public const long ADD_FLOAT = 0x37;
                public const long DIV_FLOAT = 0x4B;
                public const long EQ_STRING = 0x5B;
                public const long EQ_VEC3WS = 0x59;
                public const long GET_CONST = 0x15;
                public const long JUMP_COND = 0x7;
                public const long LTE_FLOAT = 0x52;
                public const long MOD_FLOAT = 0x4D;
                public const long MUL_FLOAT = 0x4A;
                public const long NE_STRING = 0x6C;
                public const long NE_VEC3WS = 0x6A;
                public const long SCALE_INV = 0x27;
                public const long SUB_FLOAT = 0x41;
                public const long ADD_STRING = 0x38;
                public const long CHUNK_LEAP = 0x8;
                public const long EQ_EHANDLE = 0x5E;
                public const long LOOP_BREAK = 0x4;
                public const long NEGATE_INT = 0x31;
                public const long NE_EHANDLE = 0x6F;
                public const long SCALE_VEC2 = 0x77;
                public const long SCALE_VEC3 = 0x76;
                public const long SCALE_VEC4 = 0x78;
                public const long CELL_INVOKE = 0xD;
                public const long EQ_GAMETIME = 0x64;
                public const long GET_TEMPVAR = 0x2D;
                public const long LT_GAMETIME = 0x50;
                public const long NEGATE_VEC2 = 0x33;
                public const long NEGATE_VEC3 = 0x34;
                public const long NEGATE_VEC4 = 0x35;
                public const long NE_GAMETIME = 0x75;
                public const long RETURN_VOID = 0x2;
                public const long SET_TEMPVAR = 0x2E;
                public const long EQ_COLOR_RGB = 0x62;
                public const long LTE_GAMETIME = 0x53;
                public const long NEGATE_FLOAT = 0x32;
                public const long NE_COLOR_RGB = 0x73;
                public const long RETURN_VALUE = 0x3;
                public const long SUB_GAMETIME = 0x48;
                public const long CONVERT_VALUE = 0x29;
                public const long ELEMENT_ACCESS = 0x28;
                public const long EQ_ENTITY_NAME = 0x5C;
                public const long EQ_SCHEMA_ENUM = 0x5D;
                public const long EQ_TEST_HANDLE = 0x61;
                public const long GET_VAR_DETACH = 0x11;
                public const long IMMEDIATE_HALT = 0x1;
                public const long LIBRARY_INVOKE = 0xE;
                public const long NE_ENTITY_NAME = 0x6D;
                public const long NE_SCHEMA_ENUM = 0x6E;
                public const long NE_TEST_HANDLE = 0x72;
                public const long SCALE_INV_VEC2 = 0x7A;
                public const long SCALE_INV_VEC3 = 0x79;
                public const long SCALE_INV_VEC4 = 0x7B;
                public const long ADD_VEC3WS_VEC3 = 0x3B;
                public const long ADD_VEC3_VEC3WS = 0x3C;
                public const long CHUNK_LEAP_COND = 0x9;
                public const long DETACH_REGISTER = 0x12;
                public const long EQ_PANEL_HANDLE = 0x5F;
                public const long NE_PANEL_HANDLE = 0x70;
                public const long PULSE_CALL_SYNC = 0xA;
                public const long SUB_VEC3WS_VEC3 = 0x44;
                public const long EQ_OPAQUE_HANDLE = 0x60;
                public const long GET_DOMAIN_VALUE = 0x17;
                public const long NE_OPAQUE_HANDLE = 0x71;
                public const long GET_ARRAY_ELEMENT = 0x16;
                public const long SUB_VEC3WS_VEC3WS = 0x45;
                public const long ADD_FLOAT_GAMETIME = 0x3F;
                public const long ADD_GAMETIME_FLOAT = 0x3E;
                public const long SET_VAR_OBSERVABLE = 0x14;
                public const long SUB_GAMETIME_FLOAT = 0x47;
                public const long ELEMENT_ACCESS_VEC2 = 0x7C;
                public const long ELEMENT_ACCESS_VEC3 = 0x7D;
                public const long ELEMENT_ACCESS_VEC4 = 0x7F;
                public const long LAST_SERIALIZED_CODE = 0x30;
                public const long REINTERPRET_INSTANCE = 0x2A;
                public const long ELEMENT_ACCESS_VEC3WS = 0x7E;
                public const long PULSE_CALL_ASYNC_FIRE = 0xB;
                public const long SET_TEMPVAR_OBSERVABLE = 0x2F;
                public const long ELEMENT_ACCESS_COLOR_RGB = 0x80;
                public const long GET_BLACKBOARD_REFERENCE = 0x2B;
                public const long GET_CONST_INLINE_STORAGE = 0x81;
                public const long SET_BLACKBOARD_REFERENCE = 0x2C;
                public const long SET_VAR_ARRAY_ELEMENT_1D = 0x13;
                public const long CREATE_CHILD_CURSOR_OUTFLOW = 0xC;
            }
            public static partial class TargetWarpTimingMethod {
                public const long ReachDestinationOnWarpTagEnd = 0x1;
                public const long ReachDestinationOnRootMotionEnd = 0x0;
            }
            public static partial class VPhysXJoint_t__Flags_t {
                public const long JOINT_FLAGS_NONE = 0x0;
                public const long JOINT_FLAGS_BODY1_FIXED = 0x1;
                public const long JOINT_FLAGS_USE_BLOCK_SOLVER = 0x2;
            }
            public static partial class AnimParamNetworkSetting {
                public const long Auto = 0x0;
                public const long NeverNetwork = 0x2;
                public const long AlwaysNetwork = 0x1;
            }
            public static partial class AnimationSnapshotType_t {
                public const long ANIMATION_SNAPSHOT_MAX = 0x6;
                public const long ANIMATION_SNAPSHOT_CLIENT_RENDER = 0x4;
                public const long ANIMATION_SNAPSHOT_FINAL_COMPOSITE = 0x5;
                public const long ANIMATION_SNAPSHOT_CLIENT_PREDICTION = 0x2;
                public const long ANIMATION_SNAPSHOT_CLIENT_SIMULATION = 0x1;
                public const long ANIMATION_SNAPSHOT_SERVER_SIMULATION = 0x0;
                public const long ANIMATION_SNAPSHOT_CLIENT_INTERPOLATION = 0x3;
            }
            public static partial class FootPinningTimingSource {
                public const long Tag = 0x1;
                public const long Parameter = 0x2;
                public const long FootMotion = 0x0;
            }
            public static partial class NmEventConditionRules_t {
                public const long OperatorOr = 0x4;
                public const long OperatorAnd = 0x5;
                public const long PreferHighestWeight = 0x2;
                public const long IgnoreInactiveEvents = 0x1;
                public const long SearchOnlyAnimEvents = 0x7;
                public const long PreferHighestProgress = 0x3;
                public const long SearchOnlyGraphEvents = 0x6;
                public const long LimitSearchToSourceState = 0x0;
                public const long SearchBothGraphAndAnimEvents = 0x8;
            }
            public static partial class NmRootMotionBlendMode_t {
                public const long Blend = 0x0;
                public const long Additive = 0x1;
                public const long IgnoreSource = 0x2;
                public const long IgnoreTarget = 0x3;
            }
            public static partial class NmTargetWarpAlgorithm_t {
                public const long Lerp = 0x0;
                public const long Bezier = 0x3;
                public const long Hermite = 0x1;
                public const long HermiteFeaturePreserving = 0x2;
            }
            public static partial class ParticleFloatBiasType_t {
                public const long PF_BIAS_TYPE_GAIN = 0x1;
                public const long PF_BIAS_TYPE_COUNT = 0x3;
                public const long PF_BIAS_TYPE_INVALID = -0x1;
                public const long PF_BIAS_TYPE_STANDARD = 0x0;
                public const long PF_BIAS_TYPE_EXPONENTIAL = 0x2;
            }
            public static partial class ParticleTransformType_t {
                public const long PT_TYPE_COUNT = 0x4;
                public const long PT_TYPE_INVALID = 0x0;
                public const long PT_TYPE_NAMED_VALUE = 0x1;
                public const long PT_TYPE_CONTROL_POINT = 0x2;
                public const long PT_TYPE_CONTROL_POINT_RANGE = 0x3;
            }
            public static partial class PulseBestOutflowRules_t {
                public const long SORT_BY_OUTFLOW_INDEX = 0x1;
                public const long SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0;
            }
            public static partial class CNmParticleEvent__Type_t {
                public const long Create = 0x0;
                public const long Create_CFG = 0x1;
            }
            public static partial class FootLockSubVisualization {
                public const long FOOTLOCKSUBVISUALIZATION_IKSolve = 0x1;
                public const long FOOTLOCKSUBVISUALIZATION_ReachabilityAnalysis = 0x0;
            }
            public static partial class IKTargetCoordinateSystem {
                public const long IKTARGETCOORDINATESYSTEM_COUNT = 0x2;
                public const long IKTARGETCOORDINATESYSTEM_ModelSpace = 0x1;
                public const long IKTARGETCOORDINATESYSTEM_WorldSpace = 0x0;
            }
            public static partial class MeshDrawPrimitiveFlags_t {
                public const long MESH_DRAW_FLAGS_NONE = 0x0;
                public const long MESH_DRAW_FLAGS_DRAW_LAST = 0x80;
                public const long MESH_DRAW_FLAGS_USE_SHADOW_FAST_PATH = 0x1;
                public const long MESH_DRAW_FLAGS_USE_COMPRESSED_NORMAL_TANGENT = 0x2;
                public const long MESH_DRAW_INPUT_LAYOUT_IS_NOT_MATCHED_TO_MATERIAL = 0x8;
                public const long MESH_DRAW_FLAGS_USE_COMPRESSED_PER_VERTEX_LIGHTING = 0x10;
                public const long MESH_DRAW_FLAGS_USE_UNCOMPRESSED_PER_VERTEX_LIGHTING = 0x20;
                public const long MESH_DRAW_FLAGS_CAN_BATCH_WITH_DYNAMIC_SHADER_CONSTANTS = 0x40;
            }
            public static partial class ModelBoneFlexComponent_t {
                public const long MODEL_BONE_FLEX_TX = 0x0;
                public const long MODEL_BONE_FLEX_TY = 0x1;
                public const long MODEL_BONE_FLEX_TZ = 0x2;
                public const long MODEL_BONE_FLEX_INVALID = -0x1;
            }
            public static partial class ParticleColorBlendMode_t {
                public const long PARTICLEBLEND_DARKEN = 0x2;
                public const long PARTICLEBLEND_DEFAULT = 0x0;
                public const long PARTICLEBLEND_LIGHTEN = 0x3;
                public const long PARTICLEBLEND_OVERLAY = 0x1;
                public const long PARTICLEBLEND_MULTIPLY = 0x4;
            }
            public static partial class ParticleColorBlendType_t {
                public const long PARTICLE_COLOR_BLEND_ADD = 0x3;
                public const long PARTICLE_COLOR_BLEND_MAX = 0x7;
                public const long PARTICLE_COLOR_BLEND_MIN = 0x8;
                public const long PARTICLE_COLOR_BLEND_MOD2X = 0x5;
                public const long PARTICLE_COLOR_BLEND_DIVIDE = 0x2;
                public const long PARTICLE_COLOR_BLEND_NEGATE = 0xB;
                public const long PARTICLE_COLOR_BLEND_SCREEN = 0x6;
                public const long PARTICLE_COLOR_BLEND_AVERAGE = 0xA;
                public const long PARTICLE_COLOR_BLEND_REPLACE = 0x9;
                public const long PARTICLE_COLOR_BLEND_MULTIPLY = 0x0;
                public const long PARTICLE_COLOR_BLEND_SUBTRACT = 0x4;
                public const long PARTICLE_COLOR_BLEND_LUMINANCE = 0xC;
                public const long PARTICLE_COLOR_BLEND_MULTIPLY2X = 0x1;
            }
            public static partial class ParticleFloatInputMode_t {
                public const long PF_INPUT_MODE_COUNT = 0x2;
                public const long PF_INPUT_MODE_LOOPED = 0x1;
                public const long PF_INPUT_MODE_CLAMPED = 0x0;
                public const long PF_INPUT_MODE_INVALID = -0x1;
            }
            public static partial class ParticleFloatRoundType_t {
                public const long PF_ROUND_TYPE_CEIL = 0x2;
                public const long PF_ROUND_TYPE_COUNT = 0x3;
                public const long PF_ROUND_TYPE_FLOOR = 0x1;
                public const long PF_ROUND_TYPE_INVALID = -0x1;
                public const long PF_ROUND_TYPE_NEAREST = 0x0;
            }
            public static partial class AnimationProcessingType_t {
                public const long ANIMATION_PROCESSING_MAX = 0x5;
                public const long ANIMATION_PROCESSING_CLIENT_RENDER = 0x4;
                public const long ANIMATION_PROCESSING_CLIENT_PREDICTION = 0x2;
                public const long ANIMATION_PROCESSING_CLIENT_SIMULATION = 0x1;
                public const long ANIMATION_PROCESSING_SERVER_SIMULATION = 0x0;
                public const long ANIMATION_PROCESSING_CLIENT_INTERPOLATION = 0x3;
            }
            public static partial class CNmSoundEvent__Position_t {
                public const long _None = 0x0;
                public const long World = 0x1;
                public const long EntityPos = 0x2;
                public const long EntityEyePos = 0x3;
                public const long EntityAttachment = 0x4;
            }
            public static partial class CNmTargetInfoNode__Info_t {
                public const long Distance = 0x2;
                public const long AngleVertical = 0x1;
                public const long AngleHorizontal = 0x0;
                public const long DeltaOrientationX = 0x5;
                public const long DeltaOrientationY = 0x6;
                public const long DeltaOrientationZ = 0x7;
                public const long DistanceVerticalOnly = 0x4;
                public const long DistanceHorizontalOnly = 0x3;
            }
            public static partial class CNmVectorInfoNode__Info_t {
                public const long X = 0x0;
                public const long Y = 0x1;
                public const long Z = 0x2;
                public const long Length = 0x3;
                public const long AngleVertical = 0x5;
                public const long AngleHorizontal = 0x4;
            }
            public static partial class ParticleFloatRandomMode_t {
                public const long PF_RANDOM_MODE_COUNT = 0x2;
                public const long PF_RANDOM_MODE_INVALID = -0x1;
                public const long PF_RANDOM_MODE_VARYING = 0x1;
                public const long PF_RANDOM_MODE_CONSTANT = 0x0;
            }
            public static partial class PermModelInfo_t__FlagEnum {
                public const long FLAG_MODEL_DOC = 0x800000;
                public const long FLAG_TRANSLUCENT = 0x1;
                public const long FLAG_NAV_GEN_HULL = 0x40;
                public const long FLAG_NAV_GEN_NONE = 0x20;
                public const long FLAG_NO_ANIM_EVENTS = 0x100000;
                public const long FLAG_NO_FORCED_FADE = 0x800;
                public const long FLAG_SOURCE1_IMPORT = 0x8;
                public const long FLAG_MODEL_PART_CHILD = 0x10;
                public const long FLAG_HAS_SKINNED_MESHES = 0x400;
                public const long FLAG_DO_NOT_CAST_SHADOWS = 0x20000;
                public const long FLAG_TRANSLUCENT_TWO_PASS = 0x2;
                public const long FLAG_ANIMATION_DRIVEN_FLEXES = 0x200000;
                public const long FLAG_FORCE_PHONEME_CROSSFADE = 0x1000;
                public const long FLAG_MODEL_IS_RUNTIME_COMBINED = 0x4;
                public const long FLAG_IMPLICIT_BIND_POSE_SEQUENCE = 0x400000;
            }
            public static partial class PulseCursorWakePriority_t {
                public const long WakeElegantly = 0x0;
                public const long WakeImmediate = 0x1;
            }
            public static partial class PulseVariableKeysSource_t {
                public const long CPP = 0x1;
                public const long XML = 0x4;
                public const long VMAP = 0x2;
                public const long VMDL = 0x3;
                public const long COUNT = 0x6;
                public const long VDATA = 0x5;
                public const long PRIVATE = 0x0;
            }
            public static partial class TargetSelectorAngleMode_t {
                public const long eMoveHeading = 0x1;
                public const long eFacingHeading = 0x0;
            }
            public static partial class GPUParticleCollisionMode_t {
                public const long PARTICLE_GPU_COLLISION_MODE_RT = 0x0;
                public const long PARTICLE_GPU_COLLISION_MODE_DEPTH = 0x1;
                public const long PARTICLE_GPU_COLLISION_MODE_HYBRID = 0x2;
            }
            public static partial class TargetWarpCorrectionMethod {
                public const long ScaleMotion = 0x0;
                public const long AddCorrectionDelta = 0x1;
            }
            public static partial class LinearRootMotionBlendMode_t {
                public const long LERP = 0x0;
                public const long NLERP = 0x1;
                public const long SLERP = 0x2;
            }
            public static partial class MatterialAttributeTagType_t {
                public const long MATERIAL_ATTRIBUTE_TAG_COLOR = 0x1;
                public const long MATERIAL_ATTRIBUTE_TAG_VALUE = 0x0;
            }
            public static partial class ModelConfigAttachmentType_t {
                public const long MODEL_CONFIG_ATTACHMENT_COUNT = 0x3;
                public const long MODEL_CONFIG_ATTACHMENT_INVALID = -0x1;
                public const long MODEL_CONFIG_ATTACHMENT_BONEMERGE = 0x2;
                public const long MODEL_CONFIG_ATTACHMENT_ROOT_RELATIVE = 0x1;
                public const long MODEL_CONFIG_ATTACHMENT_BONE_OR_ATTACHMENT = 0x0;
            }
            public static partial class NmGraphEventTypeCondition_t {
                public const long Any = 0x5;
                public const long Exit = 0x2;
                public const long Entry = 0x0;
                public const long Timed = 0x3;
                public const long Generic = 0x4;
                public const long FullyInState = 0x1;
            }
            public static partial class NmTransitionRuleCondition_t {
                public const long Blocked = 0x3;
                public const long AnyAllowed = 0x0;
                public const long FullyAllowed = 0x1;
                public const long ConditionallyAllowed = 0x2;
            }
            public static partial class PulseCursorCancelPriority_t {
                public const long _None = 0x0;
                public const long HardCancel = 0x3;
                public const long SoftCancel = 0x2;
                public const long CancelOnSucceeded = 0x1;
            }
            public static partial class PulseDurationStringFormat_t {
                public const long MM_SS_LEADING_ZERO = 0x0;
            }
            public static partial class CNmFloatMathNode__Operator_t {
                public const long Abs = 0x5;
                public const long Add = 0x0;
                public const long Div = 0x3;
                public const long Mod = 0x4;
                public const long Mul = 0x2;
                public const long Sub = 0x1;
                public const long Floor = 0x7;
                public const long Negate = 0x6;
                public const long Ceiling = 0x8;
                public const long IntegerPart = 0x9;
                public const long FractionalPart = 0xA;
                public const long InverseFractionalPart = 0xB;
            }
            public static partial class ParticleDirectionNoiseType_t {
                public const long PARTICLE_DIR_NOISE_CURL = 0x1;
                public const long PARTICLE_DIR_NOISE_PERLIN = 0x0;
                public const long PARTICLE_DIR_NOISE_WORLEY_BASIC = 0x2;
            }
            public static partial class ScriptedHeldWeaponBehavior_t {
                public const long eDrop = 0x2;
                public const long eDeploy = 0x1;
                public const long eHolster = 0x0;
                public const long eInvalid = -0x1;
            }
            public static partial class FootstepLandedFootSoundType_t {
                public const long FOOTSOUND_Left = 0x0;
                public const long FOOTSOUND_Right = 0x1;
                public const long FOOTSOUND_UseOverrideSound = 0x2;
            }
            public static partial class MorphFlexControllerRemapType_t {
                public const long MORPH_FLEXCONTROLLER_REMAP_2WAY = 0x1;
                public const long MORPH_FLEXCONTROLLER_REMAP_NWAY = 0x2;
                public const long MORPH_FLEXCONTROLLER_REMAP_EYELID = 0x3;
                public const long MORPH_FLEXCONTROLLER_REMAP_PASSTHRU = 0x0;
            }
            public static partial class EIKEndEffectorRotationFixUpMode {
                public const long _None = 0x0;
                public const long Count = 0x4;
                public const long LookAtTargetForward = 0x2;
                public const long MatchTargetOrientation = 0x1;
                public const long MaintainParentOrientation = 0x3;
            }
            public static partial class EPulseGraphExecutionHistoryFlag {
                public const long RETURN = 0x80;
                public const long NO_FLAGS = 0x0;
                public const long CALL_TO_PULSE = 0x40;
                public const long CURSOR_ADD_TAG = 0x1;
                public const long CURSOR_RETIRED = 0x4;
                public const long REQUIREMENT_FAIL = 0x20;
                public const long REQUIREMENT_PASS = 0x10;
                public const long CURSOR_REMOVE_TAG = 0x2;
                public const long CURSOR_CREATE_CHILD = 0x8;
            }
            public static partial class CNmTimeConditionNode__Operator_t {
                public const long LessThan = 0x0;
                public const long GreaterThan = 0x2;
                public const long LessThanEqual = 0x1;
                public const long GreaterThanEqual = 0x3;
            }
            public static partial class ModelSkeletonData_t__BoneFlags_t {
                public const long FLAG_MESH = 0x80;
                public const long FLAG_CLOTH = 0x8;
                public const long FLAG_HITBOX = 0x100;
                public const long FLAG_PHYSICS = 0x10;
                public const long FLAG_ANIMATION = 0x40;
                public const long FLAG_ATTACHMENT = 0x20;
                public const long FLAG_PROCEDURAL = 0x400000;
                public const long BLEND_PREALIGNED = 0x100000;
                public const long FLAG_RIGIDLENGTH = 0x200000;
                public const long FLAG_NO_BONE_FLAGS = 0x0;
                public const long FLAG_ALL_BONE_FLAGS = 0xFFFFF;
                public const long FLAG_BONEFLEXDRIVER = 0x4;
                public const long FLAG_BONE_MERGE_READ = 0x40000;
                public const long FLAG_BONE_MERGE_WRITE = 0x80000;
                public const long FLAG_BONE_USED_BY_VERTEX_LOD0 = 0x400;
                public const long FLAG_BONE_USED_BY_VERTEX_LOD1 = 0x800;
                public const long FLAG_BONE_USED_BY_VERTEX_LOD2 = 0x1000;
                public const long FLAG_BONE_USED_BY_VERTEX_LOD3 = 0x2000;
                public const long FLAG_BONE_USED_BY_VERTEX_LOD4 = 0x4000;
                public const long FLAG_BONE_USED_BY_VERTEX_LOD5 = 0x8000;
                public const long FLAG_BONE_USED_BY_VERTEX_LOD6 = 0x10000;
                public const long FLAG_BONE_USED_BY_VERTEX_LOD7 = 0x20000;
            }
            public static partial class SolveIKChainAnimNodeDebugSetting {
                public const long SOLVEIKCHAINANIMNODEDEBUGSETTING_Up = 0x5;
                public const long SOLVEIKCHAINANIMNODEDEBUGSETTING_Left = 0x6;
                public const long SOLVEIKCHAINANIMNODEDEBUGSETTING_None = 0x0;
                public const long SOLVEIKCHAINANIMNODEDEBUGSETTING_Forward = 0x4;
                public const long SOLVEIKCHAINANIMNODEDEBUGSETTING_X_Axis_Circle = 0x1;
                public const long SOLVEIKCHAINANIMNODEDEBUGSETTING_Y_Axis_Circle = 0x2;
                public const long SOLVEIKCHAINANIMNODEDEBUGSETTING_Z_Axis_Circle = 0x3;
            }
            public static partial class CNmIDComparisonNode__Comparison_t {
                public const long Matches = 0x0;
                public const long DoesntMatch = 0x1;
            }
            public static partial class CNmRootMotionData__SamplingMode_t {
                public const long Delta = 0x0;
                public const long WorldSpace = 0x1;
            }
            public static partial class OrientationWarpRootMotionSource_t {
                public const long eAnimationOnly = 0x1;
                public const long eProceduralOnly = 0x2;
                public const long eAnimationOrProcedural = 0x0;
            }
            public static partial class OrientationWarpTargetOffsetMode_t {
                public const long eParameter = 0x1;
                public const long eLiteralValue = 0x0;
                public const long eAnimationMovementHeading = 0x2;
                public const long eAnimationMovementHeadingAtEnd = 0x3;
            }
            public static partial class CNmFloatAngleMathNode__Operation_t {
                public const long ClampTo180 = 0x0;
                public const long ClampTo360 = 0x1;
                public const long FlipHemisphere = 0x2;
                public const long FlipHemisphereNegate = 0x3;
            }
            public static partial class VPhysXBodyPart_t__VPhysXFlagEnum_t {
                public const long FLAG_MASS = 0x8;
                public const long FLAG_JOINT = 0x4;
                public const long FLAG_STATIC = 0x1;
                public const long FLAG_KINEMATIC = 0x2;
                public const long FLAG_DISABLE_CCD = 0x20;
                public const long FLAG_ALWAYS_DYNAMIC_ON_CLIENT = 0x10;
            }
            public static partial class CNmCurrentSyncEventNode__InfoType_t {
                public const long IndexOnly = 0x1;
                public const long PercentageOnly = 0x2;
                public const long IndexAndPercentage = 0x0;
            }
            public static partial class CNmFloatComparisonNode__Comparison_t {
                public const long LessThan = 0x4;
                public const long NearEqual = 0x2;
                public const long GreaterThan = 0x3;
                public const long LessThanEqual = 0x1;
                public const long GreaterThanEqual = 0x0;
            }
            public static partial class CNmTargetWarpNode__TargetUpdateRule_t {
                public const long _None = 0x0;
                public const long Offset = 0x2;
                public const long Recalculate = 0x1;
                public const long RecalculateOrOffset = 0x3;
            }
            public static partial class CAnimationGraphVisualizerPrimitiveType {
                public const long ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Pie = 0x3;
                public const long ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Axis = 0x4;
                public const long ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Line = 0x2;
                public const long ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Text = 0x0;
                public const long ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Sphere = 0x1;
            }
            public static partial class CNmTimeConditionNode__ComparisonType_t {
                public const long ElapsedTime = 0x2;
                public const long PercentageThroughState = 0x0;
                public const long PercentageThroughSyncEvent = 0x1;
            }
            public static partial class CNmTransitionNode__TransitionOptions_t {
                public const long _None = 0x0;
                public const long Synchronized = 0x2;
                public const long ClampDuration = 0x1;
                public const long MatchSourceTime = 0x3;
                public const long MatchSyncEventID = 0x5;
                public const long MatchTimeInSeconds = 0x8;
                public const long MatchSyncEventIndex = 0x4;
                public const long OffsetTimeInSeconds = 0x9;
                public const long MatchSyncEventPercentage = 0x6;
                public const long PreferClosestSyncEventID = 0x7;
            }
            public static partial class VPhysXConstraintParams_t__EnumFlags0_t {
                public const long FLAG0_SHIFT_CONSTRAIN = 0x1;
                public const long FLAG0_SHIFT_INTERPENETRATE = 0x0;
                public const long FLAG0_SHIFT_BREAKABLE_FORCE = 0x2;
                public const long FLAG0_SHIFT_BREAKABLE_TORQUE = 0x3;
            }
            public static partial class CNmOrientationWarpNode__AlignmentMode_t {
                public const long MovementDirection = 0x0;
                public const long AnimationEndFacing = 0x1;
            }
            public static partial class VPhysXAggregateData_t__VPhysXFlagEnum_t {
                public const long FLAG_LEVEL_COLLISION = 0x10;
                public const long FLAG_IS_POLYSOUP_GEOMETRY = 0x1;
                public const long FLAG_IGNORE_SCALE_OBSOLETE_DO_NOT_USE = 0x20;
            }
            public static partial class CNmStateNode__TimedEvent_t__Comparison_t {
                public const long LessThanEqual = 0x0;
                public const long GreaterThanEqual = 0x1;
            }
            public static partial class CNmRootMotionOverrideNode__OverrideFlags_t {
                public const long AllowMoveX = 0x0;
                public const long AllowMoveY = 0x1;
                public const long AllowMoveZ = 0x2;
                public const long ListenForEvents = 0x4;
                public const long AllowFacingPitch = 0x3;
            }
            public static partial class CNmSyncEventIndexConditionNode__TriggerMode_t {
                public const long ExactlyAtEventIndex = 0x0;
                public const long GreaterThanEqualToEventIndex = 0x1;
            }
        }
    }
}
