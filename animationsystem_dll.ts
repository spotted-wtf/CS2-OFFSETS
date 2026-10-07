export namespace cs2_dumper {
    export namespace schemas {
        export namespace animationsystem_dll {
            export namespace CFlexOp {
                export const m_Data = 0x4;
                export const m_OpCode = 0x0;
            }
            export namespace CHitBox {
                export const m_CRC = 0x40;
                export const m_name = 0x0;
                export const m_nGroupId = 0x38;
                export const m_sBoneName = 0x10;
                export const m_nShapeType = 0x3C;
                export const m_vMaxBounds = 0x24;
                export const m_vMinBounds = 0x18;
                export const m_cRenderColor = 0x44;
                export const m_nHitBoxIndex = 0x48;
                export const m_flShapeRadius = 0x30;
                export const m_nBoneNameHash = 0x34;
                export const m_bTranslationOnly = 0x3D;
                export const m_sSurfaceProperty = 0x8;
            }
            export namespace CNmClip {
                export const m_skeleton = 0x0;
                export const m_syncTrack = 0xC0;
                export const m_flDuration = 0xC;
                export const m_nNumFrames = 0x8;
                export const m_rootMotion = 0x170;
                export const m_bIsAdditive = 0x1C0;
                export const m_floatChannelData = 0x98;
                export const m_compressedPoseData = 0x10;
                export const m_secondaryAnimations = 0x78;
                export const m_compressedPoseOffsets = 0x38;
                export const m_modelSpaceSamplingChain = 0x1C8;
                export const m_trackCompressionSettings = 0x20;
                export const m_modelSpaceBoneSamplingIndices = 0x1E0;
            }
            export namespace CNmEvent {
                export const m_syncID = 0x10;
                export const m_flDuration = 0xC;
                export const m_flStartTime = 0x8;
            }
            export namespace LookData {
                export const m_vLookTarget = 0x0;
            }
            export namespace AnimTagID {
                export const m_id = 0x0;
            }
            export namespace CAnimBone {
                export const m_pos = 0x14;
                export const m_name = 0x0;
                export const m_quat = 0x20;
                export const m_flags = 0x44;
                export const m_scale = 0x30;
                export const m_parent = 0x10;
                export const m_qAlignment = 0x34;
            }
            export namespace CAnimData {
                export const m_name = 0x10;
                export const m_animArray = 0x20;
                export const m_decoderArray = 0x38;
                export const m_segmentArray = 0x58;
                export const m_nMaxUniqueFrameIndex = 0x50;
            }
            export namespace CAnimDesc {
                export const fps = 0x18;
                export const m_Data = 0x20;
                export const m_name = 0x0;
                export const m_flags = 0x10;
                export const m_eventArray = 0x130;
                export const m_vecRootMax = 0x188;
                export const m_vecRootMin = 0x17C;
                export const framestalltime = 0x178;
                export const m_activityArray = 0x148;
                export const m_movementArray = 0xF8;
                export const m_hierarchyArray = 0x160;
                export const m_sequenceParams = 0x1C8;
                export const m_xInitialOffset = 0x110;
                export const m_vecBoneWorldMax = 0x1B0;
                export const m_vecBoneWorldMin = 0x198;
            }
            export namespace CAnimEnum {
                export const m_value = 0x0;
            }
            export namespace CAnimFoot {
                export const m_name = 0x0;
                export const m_vBallOffset = 0x8;
                export const m_vHeelOffset = 0x14;
                export const m_toeBoneIndex = 0x24;
                export const m_ankleBoneIndex = 0x20;
            }
            export namespace CAnimUser {
                export const m_name = 0x0;
                export const m_nType = 0x10;
            }
            export namespace CFlexDesc {
                export const m_szFacs = 0x0;
            }
            export namespace CFlexRule {
                export const m_nFlex = 0x0;
                export const m_FlexOps = 0x8;
            }
            export namespace CNmTarget {
                export const m_bIsSet = 0x2B;
                export const m_boneID = 0x20;
                export const m_transform = 0x0;
                export const m_bHasOffsets = 0x2A;
                export const m_bIsBoneTarget = 0x28;
                export const m_bIsUsingBoneSpaceOffsets = 0x29;
            }
            export namespace HSequence {
                export const m_Value = 0x0;
            }
            export namespace SlopeData {
                export const m_vSlopeNormal = 0x0;
            }
            export namespace TagSpan_t {
                export const m_endCycle = 0x8;
                export const m_tagIndex = 0x0;
                export const m_startCycle = 0x4;
            }
            export namespace TagStatus {
                export const m_TagStatus = 0x0;
                export const m_flTagStartAnimTime = 0x4;
            }
            export namespace AnimNodeID {
                export const m_id = 0x0;
            }
            export namespace CAnimCycle {

            }
            export namespace CCycleBase {
                export const m_flCycle = 0x0;
            }
            export namespace CFootCycle {

            }
            export namespace CHitBoxSet {
                export const m_name = 0x0;
                export const m_HitBoxes = 0x10;
                export const m_nNameHash = 0x8;
                export const m_SourceFilename = 0x28;
            }
            export namespace CMoodVData {
                export const m_nMoodType = 0xE0;
                export const m_sModelName = 0x0;
                export const m_animationLayers = 0xE8;
            }
            export namespace CMorphData {
                export const m_name = 0x0;
                export const m_morphRectDatas = 0x8;
            }
            export namespace CNmIDEvent {
                export const m_ID = 0x18;
                export const m_secondaryID = 0x20;
            }
            export namespace CSeqIKLock {
                export const m_nLocalBone = 0x8;
                export const m_flPosWeight = 0x0;
                export const m_flAngleWeight = 0x4;
                export const m_bBonesOrientedAlongPositiveX = 0xA;
            }
            export namespace SampleCode {
                export const m_subCode = 0x0;
            }
            export namespace WeightList {
                export const m_name = 0x0;
                export const m_weights = 0x8;
            }
            export namespace AnimParamID {
                export const m_id = 0x0;
            }
            export namespace AnimStateID {
                export const m_id = 0x0;
            }
            export namespace BlendItem_t {
                export const m_tags = 0x0;
                export const m_vPos = 0x2C;
                export const m_pChild = 0x18;
                export const m_hSequence = 0x28;
                export const m_flDuration = 0x34;
                export const m_bUseCustomDuration = 0x38;
            }
            export namespace CAttachment {
                export const m_name = 0x0;
                export const m_nInfluences = 0x83;
                export const m_influenceNames = 0x8;
                export const m_bIgnoreRotation = 0x84;
                export const m_influenceWeights = 0x74;
                export const m_vInfluenceOffsets = 0x50;
                export const m_vInfluenceRotations = 0x20;
                export const m_bInfluenceRootTransform = 0x80;
            }
            export namespace CBlendCurve {
                export const m_flControlPoint1 = 0x0;
                export const m_flControlPoint2 = 0x4;
            }
            export namespace CCachedPose {
                export const m_flCycle = 0x3C;
                export const m_hSequence = 0x38;
                export const m_transforms = 0x8;
                export const m_morphWeights = 0x20;
            }
            export namespace CFootMotion {
                export const m_name = 0x18;
                export const m_strides = 0x0;
                export const m_bAdditive = 0x20;
            }
            export namespace CFootStride {
                export const m_definition = 0x0;
                export const m_trajectories = 0x40;
            }
            export namespace CMotionNode {
                export const m_id = 0x20;
                export const m_name = 0x18;
            }
            export namespace CNmBitFlags {
                export const m_flags = 0x0;
            }
            export namespace CNmPoseTask {

            }
            export namespace CNmSkeleton {
                export const m_ID = 0x0;
                export const m_boneIDs = 0x8;
                export const m_parentIndices = 0x18;
                export const m_contactConfigs = 0xC8;
                export const m_bIsPropSkeleton = 0x64;
                export const m_maskDefinitions = 0x88;
                export const m_floatChannelSets = 0xB8;
                export const m_secondarySkeletons = 0xA8;
                export const m_nSpecialDependencyHash = 0xF8;
                export const m_modelSpaceReferencePose = 0x48;
                export const m_numBonesToSampleAtLowLOD = 0x60;
                export const m_parentSpaceReferencePose = 0x30;
                export const m_gameplayRelevantBoneIndices = 0xE0;
            }
            export namespace CPoseHandle {
                export const m_eType = 0x2;
                export const m_nIndex = 0x0;
            }
            export namespace CRenderMesh {
                export const m_skeleton = 0xE0;
                export const m_pGroomData = 0x230;
                export const m_constraints = 0xD0;
                export const m_sceneObjects = 0x10;
                export const m_bEmbeddedMapMesh = 0x1F9;
                export const m_meshDeformParams = 0x220;
                export const m_bUseUV2ForCharting = 0x1F8;
            }
            export namespace CRootMotion {
                export const m_vUpOverride = 0x1C;
                export const m_vVelocityMS = 0x10;
                export const m_deltaTransform = 0x0;
            }
            export namespace ConfigIndex {
                export const m_nGroup = 0x0;
                export const m_nConfig = 0x2;
            }
            export namespace MotionIndex {
                export const m_nGroup = 0x0;
                export const m_nMotion = 0x2;
            }
            export namespace NmPercent_t {
                export const m_flValue = 0x0;
            }
            export namespace ParamSpan_t {
                export const m_hParam = 0x18;
                export const m_samples = 0x0;
                export const m_eParamType = 0x1A;
                export const m_flEndCycle = 0x20;
                export const m_flStartCycle = 0x1C;
            }
            export namespace CAnimDecoder {
                export const m_nType = 0x14;
                export const m_szName = 0x0;
                export const m_nVersion = 0x10;
            }
            export namespace CAnimKeyData {
                export const m_name = 0x0;
                export const m_boneArray = 0x10;
                export const m_userArray = 0x28;
                export const m_morphArray = 0x40;
                export const m_dataChannelArray = 0x60;
                export const m_nChannelElements = 0x58;
            }
            export namespace CAnimTagBase {
                export const m_name = 0x18;
                export const m_group = 0x28;
                export const m_tagID = 0x30;
                export const m_sComment = 0x20;
                export const m_bIsReferenced = 0x48;
            }
            export namespace CModelConfig {
                export const m_Elements = 0x8;
                export const m_bTopLevel = 0x20;
                export const m_ConfigName = 0x0;
                export const m_bActiveInEditorByDefault = 0x21;
            }
            export namespace CMotionGraph {
                export const m_tags = 0x28;
                export const m_bLoop = 0x54;
                export const m_pRootNode = 0x40;
                export const m_paramSpans = 0x10;
                export const m_nConfigCount = 0x50;
                export const m_nParameterCount = 0x48;
                export const m_nConfigStartIndex = 0x4C;
            }
            export namespace CNmBlendTask {

            }
            export namespace CNmFootEvent {
                export const m_phase = 0x18;
            }
            export namespace CNmScaleTask {

            }
            export namespace CNmSyncTrack {
                export const m_syncEvents = 0x0;
                export const m_nStartEventOffset = 0xA8;
            }
            export namespace CPulse_Chunk {
                export const m_Registers = 0x10;
                export const m_Instructions = 0x0;
                export const m_nTempVarBank = 0x30;
                export const m_InstructionDebugInfos = 0x20;
            }
            export namespace CRenderGroom {
                export const m_hairs = 0x0;
                export const m_nHairCount = 0x80;
                export const m_hSimParamsMat = 0x40;
                export const m_nGroomGroupID = 0x8C;
                export const m_nAttachBoneIdx = 0x90;
                export const m_nAttachMeshIdx = 0x94;
                export const m_nGuideHairCount = 0x7C;
                export const m_bEnableSimulation = 0xAC;
                export const m_nTotalVertexCount = 0x84;
                export const m_nTotalSegmentCount = 0x88;
                export const m_hairPositionOffsets = 0x18;
                export const m_nAttachMeshDrawCallIdx = 0x98;
                export const m_strandSegmentCountHist = 0x48;
                export const m_nMaxSegmentsPerHairStrand = 0x78;
            }
            export namespace CSeqCmdLayer {
                export const m_cmd = 0x0;
                export const m_flVar1 = 0xC;
                export const m_flVar2 = 0x10;
                export const m_bSpline = 0xA;
                export const m_nDstResult = 0x6;
                export const m_nSrcResult = 0x8;
                export const m_nLineNumber = 0x14;
                export const m_nLocalBonemask = 0x4;
                export const m_nLocalReference = 0x2;
            }
            export namespace CSeqScaleSet {
                export const m_sName = 0x0;
                export const m_bRootOffset = 0x10;
                export const m_vRootOffset = 0x14;
                export const m_nLocalBoneArray = 0x20;
                export const m_flBoneScaleArray = 0x38;
            }
            export namespace LookAtBone_t {
                export const m_index = 0x0;
                export const m_weight = 0x4;
            }
            export namespace MovementData {
                export const m_bHasPath = 0x68;
                export const m_vMoveDir = 0xC;
                export const m_bOnGround = 0xBC;
                export const m_nFacingMode = 0x98;
                export const m_bForceFacing = 0xA4;
                export const m_bGoalChanged = 0x64;
                export const m_vAcceleration = 0x20;
                export const m_flGoalDistance = 0x4C;
                export const m_flFacingHeading = 0x74;
                export const m_goalWayPointPos = 0x0;
                export const m_vFacingPosition = 0xC8;
                export const m_flBoundaryRadius = 0x58;
                export const m_flTargetMoveSpeed = 0x40;
                export const m_nActiveMotorIndex = 0xB0;
                export const m_flCurrentMoveSpeed = 0x34;
                export const m_vManualFacingTarget = 0x8C;
                export const m_vPrevFacingPosition = 0xDC;
                export const m_vManualFacingDirection = 0x80;
            }
            export namespace ScriptInfo_t {
                export const m_code = 0x0;
                export const m_eScriptType = 0x50;
                export const m_paramsModified = 0x8;
                export const m_proxyReadParams = 0x20;
                export const m_proxyWriteParams = 0x38;
            }
            export namespace SequenceData {
                export const m_cycle = 0x4;
                export const m_hSequence = 0x0;
            }
            export namespace StanceInfo_t {
                export const m_vPosition = 0x0;
                export const m_flDirection = 0xC;
            }
            export namespace CAnimActivity {
                export const m_name = 0x0;
                export const m_nFlags = 0x14;
                export const m_nWeight = 0x18;
                export const m_nActivity = 0x10;
            }
            export namespace CAnimMovement {
                export const v0 = 0x8;
                export const v1 = 0xC;
                export const angle = 0x10;
                export const vector = 0x14;
                export const endframe = 0x0;
                export const position = 0x20;
                export const motionflags = 0x4;
            }
            export namespace CAnimNodePath {
                export const m_path = 0x0;
                export const m_nCount = 0x2C;
            }
            export namespace CAnimSkeleton {
                export const m_feet = 0x88;
                export const m_parents = 0x70;
                export const m_children = 0x58;
                export const m_boneNames = 0x40;
                export const m_morphNames = 0xA0;
                export const m_lodBoneCounts = 0xB8;
                export const m_localSpaceTransforms = 0x10;
                export const m_modelSpaceTransforms = 0x28;
            }
            export namespace CAudioAnimTag {
                export const m_clipName = 0x58;
                export const m_flVolume = 0x68;
                export const m_bPlayOnClient = 0x6F;
                export const m_bPlayOnServer = 0x6E;
                export const m_attachmentName = 0x60;
                export const m_bStopWhenTagEnds = 0x6C;
                export const m_bStopWhenGraphEnds = 0x6D;
            }
            export namespace CMorphSetData {
                export const m_nWidth = 0x10;
                export const m_nHeight = 0x14;
                export const m_FlexDesc = 0x50;
                export const m_FlexRules = 0x80;
                export const m_morphDatas = 0x30;
                export const m_bundleTypes = 0x18;
                export const m_pTextureAtlas = 0x48;
                export const m_FlexControllers = 0x68;
            }
            export namespace CNmClothEvent {
                export const m_type = 0x18;
                export const m_flSpeedIn = 0x20;
                export const m_effectName = 0x38;
                export const m_flSpeedOut = 0x24;
                export const m_flStiffness = 0x1C;
                export const m_vertexSetName = 0x30;
                export const m_flLengthSeconds = 0x28;
            }
            export namespace CNmFootIKTask {
                export const m_blendMode = 0x130;
                export const m_leftTarget = 0xD0;
                export const m_rightTarget = 0x100;
                export const m_flBlendWeight = 0x134;
                export const m_nLeftTargetBoneIdx = 0xC0;
                export const m_leftTargetTransform = 0x80;
                export const m_nRightTargetBoneIdx = 0xC4;
                export const m_nLeftEffectorBoneIdx = 0x70;
                export const m_rightTargetTransform = 0xA0;
                export const m_bIsTargetInWorldSpace = 0x138;
                export const m_nRightEffectorBoneIdx = 0x74;
                export const m_bIsRunningFromDeserializedData = 0x139;
            }
            export namespace CNmSampleTask {

            }
            export namespace CNmSoundEvent {
                export const m_name = 0x20;
                export const m_tags = 0x38;
                export const m_position = 0x28;
                export const m_relevance = 0x18;
                export const m_attachmentName = 0x30;
                export const m_flDurationInterruptionThreshold = 0x44;
                export const m_bContinuePlayingSoundAtDurationEnd = 0x40;
            }
            export namespace CSeqAutoLayer {
                export const m_end = 0x18;
                export const m_peak = 0x10;
                export const m_tail = 0x14;
                export const m_flags = 0x4;
                export const m_start = 0xC;
                export const m_nLocalPose = 0x2;
                export const m_nLocalReference = 0x0;
            }
            export namespace CSeqS1SeqDesc {
                export const m_fetch = 0x20;
                export const m_flags = 0x10;
                export const m_sName = 0x0;
                export const m_footMotion = 0x108;
                export const m_transition = 0xC8;
                export const m_IKLockArray = 0xB0;
                export const m_SequenceKeys = 0xD0;
                export const m_activityArray = 0xF0;
                export const m_autoLayerArray = 0x98;
                export const m_nLocalWeightlist = 0x90;
                export const m_LegacyKeyValueText = 0xE0;
            }
            export namespace MotionDBIndex {
                export const m_nIndex = 0x0;
            }
            export namespace VPhysXJoint_t {
                export const m_Tag = 0xC0;
                export const m_nType = 0x0;
                export const m_Frame1 = 0x10;
                export const m_Frame2 = 0x30;
                export const m_nBody1 = 0x2;
                export const m_nBody2 = 0x4;
                export const m_nFlags = 0x6;
                export const m_SwingLimit = 0x74;
                export const m_TwistLimit = 0x80;
                export const m_flFriction = 0xAC;
                export const m_flMaxForce = 0x6C;
                export const m_LinearLimit = 0x54;
                export const m_flMaxTorque = 0x98;
                export const m_flElasticity = 0xB0;
                export const m_flPlasticity = 0xB8;
                export const m_bEnableCollision = 0x50;
                export const m_flElasticDamping = 0xB4;
                export const m_bEnableSwingLimit = 0x70;
                export const m_bEnableTwistLimit = 0x7C;
                export const m_flLinearFrequency = 0x9C;
                export const m_bEnableLinearLimit = 0x53;
                export const m_bEnableLinearMotor = 0x5C;
                export const m_flAngularFrequency = 0xA4;
                export const m_bEnableAngularMotor = 0x88;
                export const m_flLinearDampingRatio = 0xA0;
                export const m_flAngularDampingRatio = 0xA8;
                export const m_vLinearTargetVelocity = 0x60;
                export const m_vAngularTargetVelocity = 0x8C;
                export const m_bIsLinearConstraintDisabled = 0x51;
                export const m_bIsAngularConstraintDisabled = 0x52;
            }
            export namespace VPhysXRange_t {
                export const m_flMax = 0x4;
                export const m_flMin = 0x0;
            }
            export namespace CAddUpdateNode {
                export const m_bApplyScale = 0x9B;
                export const m_bUseModelSpace = 0x9A;
                export const m_footMotionTiming = 0x94;
                export const m_bApplyToFootMotion = 0x98;
                export const m_bApplyChannelsSeparately = 0x99;
            }
            export namespace CAimConstraint {
                export const m_nUpType = 0x70;
                export const m_qAimOffset = 0x60;
            }
            export namespace CAnimDesc_Flag {
                export const m_bDelta = 0x3;
                export const m_bHidden = 0x2;
                export const m_bLooping = 0x0;
                export const m_bAllZeros = 0x1;
                export const m_bModelDoc = 0x5;
                export const m_bLegacyWorldspace = 0x4;
                export const m_bAnimGraphAdditive = 0x7;
                export const m_bImplicitSeqIgnoreDelta = 0x6;
            }
            export namespace CHitBoxSetList {
                export const m_HitBoxSets = 0x0;
            }
            export namespace CMorphRectData {
                export const m_nYTopDst = 0x2;
                export const m_nXLeftDst = 0x0;
                export const m_bundleDatas = 0x10;
                export const m_flUWidthSrc = 0x4;
                export const m_flVHeightSrc = 0x8;
            }
            export namespace CMotionDataSet {
                export const m_groups = 0x0;
                export const m_nDimensionCount = 0x18;
            }
            export namespace CNmLegacyEvent {
                export const m_KV = 0x20;
                export const m_animEventClassName = 0x18;
            }
            export namespace CParticleInput {

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
            export namespace CSeqCmdSeqDesc {
                export const m_flFPS = 0x28;
                export const m_flags = 0x10;
                export const m_sName = 0x0;
                export const m_eventArray = 0x48;
                export const m_nSubCycles = 0x2C;
                export const m_transition = 0x1C;
                export const m_nFrameCount = 0x26;
                export const m_activityArray = 0x60;
                export const m_cmdLayerArray = 0x30;
                export const m_numLocalResults = 0x2E;
                export const m_poseSettingArray = 0x78;
                export const m_nFrameRangeSequence = 0x24;
            }
            export namespace CSeqMultiFetch {
                export const m_flags = 0x0;
                export const m_nGroupSize = 0x20;
                export const m_nLocalPose = 0x28;
                export const m_poseKeyArray0 = 0x30;
                export const m_poseKeyArray1 = 0x48;
                export const m_bFixedBlendWeight = 0x65;
                export const m_localReferenceArray = 0x8;
                export const m_flFixedBlendWeightVals = 0x68;
                export const m_bCalculatePoseParameters = 0x64;
                export const m_nLocalCyclePoseParameter = 0x60;
            }
            export namespace CSeqTransition {
                export const m_flFadeInTime = 0x0;
                export const m_flFadeOutTime = 0x4;
            }
            export namespace CStringAnimTag {

            }
            export namespace AnimComponentID {
                export const m_id = 0x0;
            }
            export namespace CAnimAttachment {
                export const m_numInfluences = 0x78;
                export const m_influenceIndices = 0x60;
                export const m_influenceOffsets = 0x30;
                export const m_influenceWeights = 0x6C;
                export const m_influenceRotations = 0x0;
            }
            export namespace CAnimationGroup {
                export const m_name = 0x18;
                export const m_nFlags = 0x10;
                export const m_decodeKey = 0x98;
                export const m_szScripts = 0x110;
                export const m_AdditionalExtRefs = 0x128;
                export const m_directHSeqGroup_Handle = 0x90;
                export const m_localHAnimArray_Handle = 0x60;
                export const m_includedGroupArray_Handle = 0x78;
            }
            export namespace CAnimationLayer {
                export const m_nFlags = 0x38;
                export const m_nOrder = 0x28;
                export const m_flCycle = 0x10;
                export const m_bLooping = 0x34;
                export const m_flWeight = 0x1C;
                export const m_hSequence = 0x0;
                export const m_nPriority = 0x48;
                export const m_flKillRate = 0x40;
                export const m_flKillDelay = 0x44;
                export const m_flPrevCycle = 0xC;
                export const m_bSequenceFinished = 0x3C;
            }
            export namespace CBaseConstraint {
                export const m_name = 0x20;
                export const m_slaves = 0x38;
                export const m_targets = 0x48;
                export const m_vUpVector = 0x28;
            }
            export namespace CFlexController {
                export const max = 0x14;
                export const min = 0x10;
                export const m_szName = 0x0;
                export const m_szType = 0x8;
            }
            export namespace CFootDefinition {
                export const m_name = 0x0;
                export const m_toeBoneName = 0x10;
                export const m_vBallOffset = 0x18;
                export const m_vHeelOffset = 0x24;
                export const m_flFootLength = 0x30;
                export const m_ankleBoneName = 0x8;
                export const m_flTraceHeight = 0x38;
                export const m_flTraceRadius = 0x3C;
                export const m_flBindPoseDirectionMS = 0x34;
            }
            export namespace CFootTrajectory {
                export const m_vOffset = 0x8;
                export const m_flProgression = 0x18;
                export const m_flRotationOffset = 0x14;
            }
            export namespace CLeafUpdateNode {

            }
            export namespace CMotionSearchDB {
                export const m_rootNode = 0x0;
                export const m_codeIndices = 0xA0;
                export const m_residualQuantizer = 0x80;
            }
            export namespace CNPCPhysicsHull {
                export const m_eType = 0x8;
                export const m_sName = 0x0;
                export const m_flCapsuleHeight = 0xC;
                export const m_flCapsuleRadius = 0x10;
                export const m_vCapsuleCenter1 = 0x14;
                export const m_vCapsuleCenter2 = 0x20;
                export const m_flGroundBoxWidth = 0x30;
                export const m_flGroundBoxHeight = 0x2C;
            }
            export namespace CNetworkedCycle {
                export const m_resetCount = 0x28;
                export const m_flCycleZeroTime = 0x1C;
                export const m_flCycleUnclamped = 0x0;
                export const m_flCyclesPerSecond = 0x10;
                export const m_flPrevCycleUnclamped = 0x4;
            }
            export namespace CNmContactEvent {
                export const m_configID = 0x18;
                export const m_audioInfo = 0x38;
                export const m_probeBoneID = 0x20;
                export const m_flProbeMaxDist = 0x34;
                export const m_vBoneLocalProbeDir = 0x28;
            }
            export namespace CNmZeroPoseTask {

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
            export namespace CPulse_Constant {
                export const m_Type = 0x0;
                export const m_Value = 0x18;
            }
            export namespace CPulse_Variable {
                export const m_Name = 0x0;
                export const m_Type = 0x18;
                export const m_Metadata = 0x50;
                export const m_Description = 0x10;
                export const m_nKeysSource = 0x44;
                export const m_DefaultValue = 0x30;
                export const m_bIsObservable = 0x49;
                export const m_nEditorNodeID = 0x4C;
                export const m_bIsPublicBlackboardVariable = 0x48;
            }
            export namespace CRagdollAnimTag {
                export const m_profileName = 0x58;
            }
            export namespace CRenderSkeleton {
                export const m_bones = 0x0;
                export const m_boneParents = 0x30;
                export const m_nBoneWeightCount = 0x48;
            }
            export namespace CRootUpdateNode {

            }
            export namespace CSeqPoseSetting {
                export const m_bX = 0x34;
                export const m_bY = 0x35;
                export const m_bZ = 0x36;
                export const m_eType = 0x38;
                export const m_flValue = 0x30;
                export const m_sAttachment = 0x10;
                export const m_sPoseParameter = 0x0;
                export const m_sReferenceSequence = 0x20;
            }
            export namespace CSeqSeqDescFlag {
                export const m_bPost = 0x3;
                export const m_bSnap = 0x1;
                export const m_bMulti = 0x5;
                export const m_bHidden = 0x4;
                export const m_bLooping = 0x0;
                export const m_bAutoplay = 0x2;
                export const m_bModelDoc = 0xA;
                export const m_bLegacyDelta = 0x6;
                export const m_bLegacyRealtime = 0x9;
                export const m_bLegacyCyclepose = 0x8;
                export const m_bLegacyWorldspace = 0x7;
            }
            export namespace FootFixedData_t {
                export const m_nTagIndex = 0x38;
                export const m_nFootIndex = 0x34;
                export const m_vToeOffset = 0x0;
                export const m_vHeelOffset = 0x10;
                export const m_ikChainIndex = 0x2C;
                export const m_flMaxIKLength = 0x30;
                export const m_nAnkleBoneIndex = 0x24;
                export const m_nTargetBoneIndex = 0x20;
                export const m_flMaxRotationLeft = 0x3C;
                export const m_flMaxRotationRight = 0x40;
                export const m_nIKAnchorBoneIndex = 0x28;
            }
            export namespace FootStepTrigger {
                export const m_tags = 0x0;
                export const m_nFootIndex = 0x18;
                export const m_triggerPhase = 0x1C;
            }
            export namespace IParticleEffect {

            }
            export namespace MaterialGroup_t {
                export const m_name = 0x0;
                export const m_materials = 0x8;
            }
            export namespace MoodAnimation_t {
                export const m_sName = 0x0;
                export const m_flWeight = 0x8;
            }
            export namespace MotionBlendItem {
                export const m_pChild = 0x0;
                export const m_flKeyValue = 0x8;
            }
            export namespace MotionSelection {
                export const m_nSample = 0x54;
                export const m_flStartTime = 0x48;
                export const m_nConfigIndex = 0x24;
                export const m_flCycleZeroTime = 0x30;
                export const m_flPlaybackSpeed = 0x3C;
            }
            export namespace PermModelData_t {
                export const m_name = 0x0;
                export const m_ExtParts = 0x60;
                export const m_modelInfo = 0x8;
                export const m_refMeshes = 0x78;
                export const m_meshGroups = 0x150;
                export const m_modelSkeleton = 0x188;
                export const m_refAnimGroups = 0x120;
                export const m_animGraph2Refs = 0x2C8;
                export const m_materialGroups = 0x168;
                export const m_refPhysicsData = 0xF0;
                export const m_remappingTable = 0x230;
                export const m_boneFlexDrivers = 0x260;
                export const m_pModelConfigList = 0x278;
                export const m_refLODGroupMasks = 0xC0;
                export const m_refMeshGroupMasks = 0x90;
                export const m_refPhysGroupMasks = 0xA8;
                export const m_refSequenceGroups = 0x138;
                export const m_vecNmSkeletonRefs = 0x2E0;
                export const m_refAnimIncludeModels = 0x298;
                export const m_refPhysicsHitboxData = 0x108;
                export const m_remappingTableStarts = 0x248;
                export const m_nDefaultMeshGroupMask = 0x180;
                export const m_BodyGroupsHiddenInTools = 0x280;
                export const m_lodGroupSwitchDistances = 0xD8;
                export const m_AnimatedMaterialAttributes = 0x2B0;
            }
            export namespace PermModelInfo_t {
                export const m_flMass = 0x34;
                export const m_nFlags = 0x0;
                export const m_vHullMax = 0x10;
                export const m_vHullMin = 0x4;
                export const m_vViewMax = 0x28;
                export const m_vViewMin = 0x1C;
                export const m_keyValueText = 0x50;
                export const m_vEyePosition = 0x38;
                export const m_sSurfaceProperty = 0x48;
                export const m_flMaxEyeDeflection = 0x44;
            }
            export namespace PulseCursorID_t {
                export const m_Value = 0x0;
            }
            export namespace TraceSettings_t {
                export const m_flTraceHeight = 0x0;
                export const m_flTraceRadius = 0x4;
            }
            export namespace AnimNodeOutputID {
                export const m_id = 0x0;
            }
            export namespace AnimScriptHandle {
                export const m_id = 0x0;
            }
            export namespace CAnimParamHandle {
                export const m_type = 0x0;
                export const m_index = 0x1;
            }
            export namespace CAnimReplayFrame {
                export const m_timeStamp = 0x80;
                export const m_instanceData = 0x28;
                export const m_inputDataBlocks = 0x10;
                export const m_localToWorldTransform = 0x60;
                export const m_startingLocalToWorldTransform = 0x40;
            }
            export namespace CBlendUpdateNode {
                export const m_bLoop = 0xD6;
                export const m_damping = 0xB8;
                export const m_bIsAngle = 0xD8;
                export const m_children = 0x60;
                export const m_paramIndex = 0xB4;
                export const m_bSyncCycles = 0xD5;
                export const m_sortedOrder = 0x78;
                export const m_blendKeyType = 0xD0;
                export const m_targetValues = 0x90;
                export const m_bLockWhenWaning = 0xD7;
                export const m_blendValueSource = 0xAC;
                export const m_bLockBlendOnReset = 0xD4;
                export const m_eLinearRootMotionBlendMode = 0xB0;
            }
            export namespace CConstraintSlave {
                export const m_sName = 0x28;
                export const m_flWeight = 0x20;
                export const m_nBoneHash = 0x1C;
                export const m_vBasePosition = 0x10;
                export const m_qBaseOrientation = 0x0;
            }
            export namespace CDrawCullingData {
                export const m_ConeAxis = 0x0;
                export const m_ConeCutoff = 0x3;
            }
            export namespace CFootFallAnimTag {
                export const m_foot = 0x58;
            }
            export namespace CModelConfigList {
                export const m_Configs = 0x8;
                export const m_bHideRenderColorInTools = 0x1;
                export const m_bHideMaterialGroupInTools = 0x0;
            }
            export namespace CMorphBundleData {
                export const m_ranges = 0x20;
                export const m_offsets = 0x8;
                export const m_flVTopSrc = 0x4;
                export const m_flULeftSrc = 0x0;
            }
            export namespace CMorphConstraint {
                export const m_flMax = 0x70;
                export const m_flMin = 0x6C;
                export const m_sTargetMorph = 0x60;
                export const m_nSlaveChannel = 0x68;
            }
            export namespace CMoverUpdateNode {
                export const m_damping = 0x78;
                export const m_bAdditive = 0xA4;
                export const m_bLimitOnly = 0xA8;
                export const m_facingTarget = 0x90;
                export const m_hMoveVecParam = 0x94;
                export const m_bApplyMovement = 0xA5;
                export const m_bApplyRotation = 0xA7;
                export const m_bOrientMovement = 0xA6;
                export const m_hTurnToFaceParam = 0x98;
                export const m_flTurnToFaceLimit = 0xA0;
                export const m_hMoveHeadingParam = 0x96;
                export const m_flTurnToFaceOffset = 0x9C;
            }
            export namespace CNmBlendTaskBase {

            }
            export namespace CNmGraphInstance {

            }
            export namespace CNmParticleEvent {
                export const m_tags = 0x30;
                export const m_type = 0x1C;
                export const m_config = 0x60;
                export const m_target = 0x20;
                export const m_relevance = 0x18;
                export const m_bPlayEndCap = 0x3A;
                export const m_attachmentType0 = 0x48;
                export const m_attachmentType1 = 0x58;
                export const m_effectForConfig = 0x68;
                export const m_hParticleSystem = 0x28;
                export const m_attachmentPoint0 = 0x40;
                export const m_attachmentPoint1 = 0x50;
                export const m_bDetachFromOwner = 0x39;
                export const m_bStopImmediately = 0x38;
            }
            export namespace CNmTwoBoneIKTask {
                export const m_targetTransform = 0x80;
                export const m_nEffectorBoneIdx = 0x70;
                export const m_nEffectorTargetBoneIdx = 0x74;
            }
            export namespace CParticleAnimTag {
                export const m_bAggregate = 0x71;
                export const m_configName = 0x68;
                export const m_attachmentName = 0x78;
                export const m_attachmentType = 0x80;
                export const m_hParticleSystem = 0x58;
                export const m_bDetachFromOwner = 0x70;
                export const m_bStopWhenTagEnds = 0x72;
                export const m_attachmentCP1Name = 0x88;
                export const m_attachmentCP1Type = 0x90;
                export const m_particleSystemName = 0x60;
                export const m_bTagEndStopIsInstant = 0x73;
            }
            export namespace CPointConstraint {

            }
            export namespace CPulseExecCursor {

            }
            export namespace CSceneObjectData {
                export const m_meshlets = 0x38;
                export const m_drawCalls = 0x18;
                export const m_drawBounds = 0x28;
                export const m_vMaxBounds = 0xC;
                export const m_vMinBounds = 0x0;
                export const m_vTintColor = 0x58;
                export const m_rtProxyDrawCalls = 0x48;
            }
            export namespace CSeqBoneMaskList {
                export const m_sName = 0x0;
                export const m_nLocalBoneArray = 0x10;
                export const m_flBoneWeightArray = 0x28;
                export const m_morphCtrlWeightArray = 0x48;
                export const m_flDefaultMorphCtrlWeight = 0x40;
            }
            export namespace CStateUpdateData {
                export const m_name = 0x0;
                export const m_actions = 0x28;
                export const m_hScript = 0x8;
                export const m_stateID = 0x40;
                export const m_bIsEndState = 0x0;
                export const m_bIsStartState = 0x0;
                export const m_bIsPassthrough = 0x0;
                export const m_transitionIndices = 0x10;
                export const m_bIsPassthroughRootMotion = 0x0;
                export const m_bPreEvaluatePassthroughTransitionPath = 0x0;
            }
            export namespace CStaticPoseCache {
                export const m_poses = 0x10;
                export const m_nBoneCount = 0x28;
                export const m_nMorphCount = 0x2C;
            }
            export namespace CTwistConstraint {
                export const m_bInverse = 0x60;
                export const m_qChildBindRotation = 0x80;
                export const m_qParentBindRotation = 0x70;
            }
            export namespace CUnaryUpdateNode {
                export const m_pChildNode = 0x60;
            }
            export namespace CVectorQuantizer {
                export const m_nCentroids = 0x18;
                export const m_nDimensions = 0x1C;
                export const m_centroidVectors = 0x0;
            }
            export namespace PGDInstruction_t {
                export const m_nVar = 0x4;
                export const m_nCode = 0x0;
                export const m_nReg0 = 0x8;
                export const m_nReg1 = 0xA;
                export const m_nReg2 = 0xC;
                export const m_nChunk = 0x14;
                export const m_nConstIdx = 0x20;
                export const m_nTempVarIdx = 0x26;
                export const m_nCallInfoIndex = 0x1C;
                export const m_nDomainValueIdx = 0x22;
                export const m_nDestInstruction = 0x18;
                export const m_nInvokeBindingIndex = 0x10;
                export const m_nBlackboardReferenceIdx = 0x24;
            }
            export namespace PairedSequence_t {
                export const m_sRole = 0x0;
                export const m_hSequence = 0x10;
                export const m_sSequenceName = 0x8;
            }
            export namespace PulseDocNodeID_t {
                export const m_Value = 0x0;
            }
            export namespace SkeletonDemoDb_t {
                export const m_CameraTrack = 0x18;
                export const m_AnimCaptures = 0x0;
                export const m_flRecordingTime = 0x30;
            }
            export namespace VPhysXBodyPart_t {
                export const m_flMass = 0x4;
                export const m_nFlags = 0x0;
                export const m_rnShape = 0x8;
                export const m_nReserved = 0x72;
                export const m_flLinearDrag = 0x80;
                export const m_flAngularDrag = 0x84;
                export const m_flInertiaScale = 0x74;
                export const m_flLinearDamping = 0x78;
                export const m_flAngularDamping = 0x7C;
                export const m_bOverrideMassCenter = 0x88;
                export const m_vMassCenterOverride = 0x8C;
                export const m_nCollisionAttributeIndex = 0x70;
            }
            export namespace CAnimFrameSegment {
                export const m_container = 0x10;
                export const m_nLocalChannel = 0x8;
                export const m_nUniqueFrameIndex = 0x0;
                export const m_nLocalElementMasks = 0x4;
            }
            export namespace CAnimInputDamping {
                export const m_fSpeedScale = 0xC;
                export const m_speedFunction = 0x8;
                export const m_fFallingSpeedScale = 0x10;
            }
            export namespace CBinaryUpdateNode {
                export const m_pChild1 = 0x60;
                export const m_pChild2 = 0x70;
                export const m_bResetChild1 = 0x88;
                export const m_bResetChild2 = 0x89;
                export const m_flTimingBlend = 0x84;
                export const m_timingBehavior = 0x80;
            }
            export namespace CBodyGroupAnimTag {
                export const m_nPriority = 0x58;
                export const m_bodyGroupSettings = 0x60;
            }
            export namespace CBodyGroupSetting {
                export const m_BodyGroupName = 0x0;
                export const m_nBodyGroupOption = 0x8;
            }
            export namespace CChoiceUpdateNode {
                export const m_weights = 0x78;
                export const m_children = 0x60;
                export const m_blendTime = 0xB4;
                export const m_bCrossFade = 0xB8;
                export const m_blendTimes = 0x90;
                export const m_blendMethod = 0xB0;
                export const m_bResetChosen = 0xB9;
                export const m_choiceMethod = 0xA8;
                export const m_choiceChangeMethod = 0xAC;
                export const m_bDontResetSameSelection = 0xBA;
            }
            export namespace CChoreoUpdateNode {

            }
            export namespace CConstraintTarget {
                export const m_sName = 0x40;
                export const m_qOffset = 0x20;
                export const m_vOffset = 0x30;
                export const m_flWeight = 0x48;
                export const m_nBoneHash = 0x3C;
                export const m_bIsAttachment = 0x59;
            }
            export namespace CFootTrajectories {
                export const m_trajectories = 0x0;
            }
            export namespace CIntAnimParameter {
                export const m_maxValue = 0x88;
                export const m_minValue = 0x84;
                export const m_defaultValue = 0x80;
            }
            export namespace CLookAtUpdateNode {
                export const m_target = 0x148;
                export const m_paramIndex = 0x14C;
                export const m_bResetChild = 0x150;
                export const m_bLockWhenWaning = 0x151;
                export const m_opFixedSettings = 0x70;
                export const m_weightParamIndex = 0x14E;
            }
            export namespace CMotionGraphGroup {
                export const m_searchDB = 0x0;
                export const m_motionGraphs = 0xB8;
                export const m_sampleToConfig = 0xE8;
                export const m_hIsActiveScript = 0x100;
                export const m_motionGraphConfigs = 0xD0;
            }
            export namespace CMotionSearchNode {
                export const m_children = 0x0;
                export const m_quantizer = 0x18;
                export const m_sampleCodes = 0x38;
                export const m_sampleIndices = 0x50;
                export const m_selectableSamples = 0x68;
            }
            export namespace CNmBodyGroupEvent {
                export const m_target = 0x18;
                export const m_groupName = 0x20;
                export const m_choiceName = 0x28;
            }
            export namespace CNmBoneWeightList {
                export const m_boneIDs = 0xE0;
                export const m_weights = 0xF8;
                export const m_skeletonName = 0x0;
            }
            export namespace CNmCameraDOFEvent {
                export const m_curve = 0x18;
            }
            export namespace CNmCameraFOVEvent {
                export const m_curve = 0x18;
            }
            export namespace CNmFollowBoneTask {

            }
            export namespace CNmFrameSnapEvent {
                export const m_frameSnapMode = 0x18;
            }
            export namespace CNmRootMotionData {
                export const m_nNumFrames = 0x18;
                export const m_totalDelta = 0x30;
                export const m_transforms = 0x0;
                export const m_flAverageLinearVelocity = 0x1C;
                export const m_flAverageAngularVelocityRadians = 0x20;
            }
            export namespace COrientConstraint {

            }
            export namespace CParamSpanUpdater {
                export const m_spans = 0x0;
            }
            export namespace CParentConstraint {

            }
            export namespace CParticleProperty {

            }
            export namespace CParticleVecInput {
                export const m_nType = 0x10;
                export const m_Gradient = 0x6A8;
                export const m_NamedValue = 0x28;
                export const m_vRandomMax = 0x6CC;
                export const m_vRandomMin = 0x6C0;
                export const m_FloatInterp = 0x510;
                export const m_LiteralColor = 0x20;
                export const m_nControlPoint = 0x7C;
                export const m_vCPValueScale = 0x84;
                export const m_vLiteralValue = 0x14;
                export const m_flInterpInput0 = 0x688;
                export const m_flInterpInput1 = 0x68C;
                export const m_vCPRelativeDir = 0x9C;
                export const m_vInterpOutput0 = 0x690;
                export const m_vInterpOutput1 = 0x69C;
                export const m_FloatComponentX = 0xA8;
                export const m_FloatComponentY = 0x220;
                export const m_FloatComponentZ = 0x398;
                export const m_nVectorAttribute = 0x6C;
                export const m_bFollowNamedValue = 0x68;
                export const m_nDeltaControlPoint = 0x80;
                export const m_vCPRelativePosition = 0x90;
                export const m_vVectorAttributeScale = 0x70;
            }
            export namespace CProductQuantizer {
                export const m_nDimensions = 0x18;
                export const m_subQuantizers = 0x0;
            }
            export namespace CSeqAutoLayerFlag {
                export const m_bPose = 0x5;
                export const m_bPost = 0x0;
                export const m_bLocal = 0x4;
                export const m_bXFade = 0x2;
                export const m_bSpline = 0x1;
                export const m_bNoBlend = 0x3;
                export const m_bSubtract = 0x7;
                export const m_bFetchFrame = 0x6;
            }
            export namespace CSeqPoseParamDesc {
                export const m_flEnd = 0x14;
                export const m_sName = 0x0;
                export const m_flLoop = 0x18;
                export const m_flStart = 0x10;
                export const m_bLooping = 0x1C;
            }
            export namespace CSeqSynthAnimDesc {
                export const m_flags = 0x10;
                export const m_sName = 0x0;
                export const m_transition = 0x1C;
                export const m_activityArray = 0x28;
                export const m_nLocalBoneMask = 0x26;
                export const m_nLocalBaseReference = 0x24;
            }
            export namespace CSequenceTagSpans {
                export const m_tags = 0x8;
                export const m_sSequenceName = 0x0;
            }
            export namespace FootFixedSettings {
                export const m_nFootIndex = 0x3C;
                export const m_traceSettings = 0x0;
                export const m_bEnableTracing = 0x30;
                export const m_flFootBaseLength = 0x20;
                export const m_nDisableTagIndex = 0x38;
                export const m_flMaxRotationLeft = 0x24;
                export const m_flTraceAngleBlend = 0x34;
                export const m_flMaxRotationRight = 0x28;
                export const m_footstepLandedTagIndex = 0x2C;
                export const m_vFootBaseBindPosePositionMS = 0x10;
            }
            export namespace NetVarConfigIndex {
                export const m_index = 0x0;
            }
            export namespace NmSyncTrackTime_t {
                export const m_nEventIdx = 0x0;
                export const m_percentageThrough = 0x4;
            }
            export namespace ParamSpanSample_t {
                export const m_value = 0x0;
                export const m_flCycle = 0x14;
            }
            export namespace PerTickSettings_t {
                export const m_bAwaken = 0x6B4;
                export const m_updateID = 0x69C;
                export const m_bIsClient = 0x6B6;
                export const m_rootMotion = 0x60;
                export const m_bTeleported = 0x6B5;
                export const m_bIsPredicted = 0x6B7;
                export const m_flLastTimeStep = 0x6A4;
                export const m_flNextAnimTime = 0x6AC;
                export const m_flPrevAnimTime = 0x6A8;
                export const m_prevLocalToWorld = 0x20;
                export const m_finalLocalToWorld = 0x40;
                export const m_startingLocalToWorld = 0x0;
            }
            export namespace PhysShapeMarkup_t {
                export const m_sHitGroup = 0x8;
                export const m_nShapeInBody = 0x4;
                export const m_nBodyInAggregate = 0x0;
            }
            export namespace AttachmentHandle_t {
                export const m_Value = 0x0;
            }
            export namespace CAnimActionUpdater {

            }
            export namespace CAnimEncodedFrames {
                export const m_nFrames = 0x10;
                export const m_fileName = 0x0;
                export const m_frameblockArray = 0x18;
                export const m_nFramesPerBlock = 0x14;
                export const m_usageDifferences = 0x30;
            }
            export namespace CAnimParameterBase {
                export const m_id = 0x30;
                export const m_name = 0x18;
                export const m_group = 0x28;
                export const m_sComment = 0x20;
                export const m_bIsReferenced = 0x69;
                export const m_componentName = 0x48;
                export const m_bNetworkingRequested = 0x68;
            }
            export namespace CAnimScriptManager {
                export const m_scriptInfo = 0x10;
            }
            export namespace CAnimUpdateNodeRef {
                export const m_nodeIndex = 0x8;
            }
            export namespace CBlend2DUpdateNode {
                export const m_tags = 0x78;
                export const m_bLoop = 0xF0;
                export const m_items = 0x60;
                export const m_paramX = 0xDC;
                export const m_paramY = 0xE4;
                export const m_damping = 0xC0;
                export const m_eBlendMode = 0xE8;
                export const m_paramSpans = 0x90;
                export const m_blendSourceX = 0xD8;
                export const m_blendSourceY = 0xE0;
                export const m_playbackSpeed = 0xEC;
                export const m_bLockWhenWaning = 0xF2;
                export const m_nodeItemIndices = 0xA8;
                export const m_bLockBlendOnReset = 0xF1;
                export const m_bAnimEventsAndTagsOnMostWeightedOnly = 0xF3;
            }
            export namespace CBoneConstraintRbf {
                export const m_inputBones = 0x20;
                export const m_outputBones = 0x38;
            }
            export namespace CBoolAnimParameter {
                export const m_bDefaultValue = 0x80;
            }
            export namespace CEnumAnimParameter {
                export const m_enumOptions = 0x90;
                export const m_defaultValue = 0x88;
                export const m_vecEnumReferenced = 0xA8;
            }
            export namespace CMeshletDescriptor {
                export const m_PackedAABB = 0x0;
                export const m_nBoneIndex = 0x16;
                export const m_CullingData = 0x8;
                export const m_nVertexCount = 0x14;
                export const m_nVertexOffset = 0xC;
                export const m_nTriangleCount = 0x15;
                export const m_nTriangleOffset = 0x10;
            }
            export namespace CMotionGraphConfig {
                export const m_flDuration = 0x10;
                export const m_paramValues = 0x0;
                export const m_nMotionIndex = 0x14;
                export const m_nSampleCount = 0x1C;
                export const m_nSampleStart = 0x18;
            }
            export namespace CMotionNodeBlend1D {
                export const m_blendItems = 0x28;
                export const m_nParamIndex = 0x40;
            }
            export namespace CMoverInstanceData {
                export const m_Rotation = 0x1C;
                export const m_vMovement = 0x4;
                export const m_flDampedValue = 0x0;
                export const m_TargetOrientation = 0x20;
            }
            export namespace CNewParticleEffect {
                export const m_pNext = 0x10;
                export const m_pPrev = 0x18;
                export const m_hOwner = 0x50;
                export const m_LastMax = 0x88;
                export const m_LastMin = 0x7C;
                export const m_bRemove = 0x0;
                export const m_flScale = 0x4C;
                export const m_RefCount = 0xD0;
                export const m_bSimulate = 0x0;
                export const m_bAllocated = 0x0;
                export const m_bCanFreeze = 0x0;
                export const m_pDebugName = 0x28;
                export const m_pParticles = 0x20;
                export const m_bDontRemove = 0x0;
                export const m_bShouldSave = 0x0;
                export const m_vSortOrigin = 0x40;
                export const m_bForceNoDraw = 0x0;
                export const m_bIsFirstFrame = 0x0;
                export const m_bIsAsyncCreate = 0x0;
                export const m_bAutoUpdateBBox = 0x0;
                export const m_bShouldCheckFoW = 0x0;
                export const m_bNeedsBBoxUpdate = 0x0;
                export const m_nSplitScreenUser = 0x94;
                export const m_bFreezeTargetState = 0x0;
                export const m_vecAggregationCenter = 0x98;
                export const m_bFreezeTransitionActive = 0x0;
                export const m_bShouldPerformCullCheck = 0x0;
                export const m_flFreezeTransitionStart = 0x70;
                export const m_pOwningParticleProperty = 0x58;
                export const m_bSuppressScreenSpaceEffect = 0x0;
                export const m_flFreezeTransitionDuration = 0x74;
                export const m_flFreezeTransitionOverride = 0x78;
                export const m_bShouldSimulateDuringGamePaused = 0x0;
            }
            export namespace CNmChainLookatTask {

            }
            export namespace CNmFloatCurveEvent {
                export const m_ID = 0x18;
                export const m_curve = 0x20;
            }
            export namespace CNmGraphDefinition {
                export const m_skeleton = 0x8;
                export const m_nodePaths = 0x150;
                export const m_pUserData = 0x28;
                export const m_resources = 0x168;
                export const m_variationID = 0x0;
                export const m_nRootNodeIdx = 0x48;
                export const m_externalPoseSlots = 0xC8;
                export const m_externalGraphSlots = 0xB0;
                export const m_controlParameterIDs = 0x50;
                export const m_virtualParameterIDs = 0x68;
                export const m_referencedGraphSlots = 0x98;
                export const m_persistentNodeIndices = 0x30;
                export const m_supportedSecondarySkeletons = 0x10;
                export const m_virtualParameterNodeIndices = 0x80;
            }
            export namespace CNmRootMotionEvent {
                export const m_flBlendTimeSeconds = 0x18;
            }
            export namespace CNmTargetWarpEvent {
                export const m_rule = 0x18;
                export const m_algorithm = 0x19;
            }
            export namespace CNmTransitionEvent {
                export const m_ID = 0x20;
                export const m_rule = 0x18;
            }
            export namespace CPulseCell_Unknown {
                export const m_UnknownKeys = 0x48;
            }
            export namespace CPulse_DomainValue {
                export const m_Value = 0x8;
                export const m_nType = 0x0;
                export const m_RequiredRuntimeType = 0x10;
            }
            export namespace CPulse_ResumePoint {

            }
            export namespace CPulse_TempVarInfo {
                export const m_Name = 0x0;
                export const m_Type = 0x10;
                export const m_bIsObservable = 0x2C;
                export const m_nEditorNodeID = 0x28;
            }
            export namespace CRagdollUpdateNode {
                export const m_nWeightListIndex = 0x70;
                export const m_poseControlMethod = 0x74;
            }
            export namespace CSeqMultiFetchFlag {
                export const m_b0D = 0x2;
                export const m_b1D = 0x3;
                export const m_b2D = 0x4;
                export const m_b2D_TRI = 0x5;
                export const m_bCylepose = 0x1;
                export const m_bRealtime = 0x0;
            }
            export namespace CSequenceGroupData {
                export const m_sName = 0x10;
                export const m_nFlags = 0x20;
                export const m_keyValues = 0x110;
                export const m_localNodeName = 0xE8;
                export const m_localBoneMaskArray = 0xA0;
                export const m_localBoneNameArray = 0xD0;
                export const m_localScaleSetArray = 0xB8;
                export const m_localPoseParamArray = 0xF8;
                export const m_localS1SeqDescArray = 0x40;
                export const m_localCmdSeqDescArray = 0x88;
                export const m_localMultiSeqDescArray = 0x58;
                export const m_localSequenceNameArray = 0x28;
                export const m_localSynthAnimDescArray = 0x70;
                export const m_localIKAutoplayLockArray = 0x120;
            }
            export namespace CTaskStatusAnimTag {

            }
            export namespace ChainToSolveData_t {
                export const m_nChainIndex = 0x0;
                export const m_DebugSetting = 0x38;
                export const m_vDebugOffset = 0x40;
                export const m_SolverSettings = 0x4;
                export const m_TargetSettings = 0x10;
                export const m_flDebugNormalizedValue = 0x3C;
            }
            export namespace IKSolverSettings_t {
                export const m_SolverType = 0x0;
                export const m_nNumIterations = 0x4;
                export const m_EndEffectorRotationFixUpMode = 0x8;
            }
            export namespace IKTargetSettings_t {
                export const m_Bone = 0x8;
                export const m_TargetSource = 0x0;
                export const m_TargetCoordSystem = 0x20;
                export const m_AnimgraphParameterNamePosition = 0x18;
                export const m_AnimgraphParameterNameOrientation = 0x1C;
            }
            export namespace PARTICLE_EHANDLE__ {
                export const unused = 0x0;
            }
            export namespace PairedSequenceData {
                export const m_vecPairedSequences = 0x0;
            }
            export namespace PermModelExtPart_t {
                export const m_Name = 0x20;
                export const m_nParent = 0x28;
                export const m_refModel = 0x30;
                export const m_Transform = 0x0;
            }
            export namespace PhysSoftbodyDesc_t {
                export const m_Springs = 0x30;
                export const m_Capsules = 0x48;
                export const m_InitPose = 0x60;
                export const m_Particles = 0x18;
                export const m_ParticleBoneHash = 0x0;
                export const m_ParticleBoneName = 0x78;
            }
            export namespace PulseRegisterMap_t {
                export const m_Inparams = 0x0;
                export const m_Outparams = 0x20;
                export const m_InparamsWhichCanBeMoved = 0x10;
            }
            export namespace AnimationSnapshot_t {
                export const m_modelName = 0x118;
                export const m_nEntIndex = 0x110;
            }
            export namespace CAnimBoneDifference {
                export const m_name = 0x0;
                export const m_parent = 0x10;
                export const m_posError = 0x20;
                export const m_bHasMovement = 0x2D;
                export const m_bHasRotation = 0x2C;
            }
            export namespace CAnimFrameBlockAnim {
                export const m_nEndFrame = 0x4;
                export const m_nStartFrame = 0x0;
                export const m_segmentIndexArray = 0x8;
            }
            export namespace CAnimLocalHierarchy {
                export const m_sBone = 0x0;
                export const m_nEndFrame = 0x2C;
                export const m_nPeakFrame = 0x24;
                export const m_nTailFrame = 0x28;
                export const m_sNewParent = 0x10;
                export const m_nStartFrame = 0x20;
            }
            export namespace CAnimParamHandleMap {
                export const m_list = 0x0;
            }
            export namespace CAnimSequenceParams {
                export const m_flFadeInTime = 0x0;
                export const m_flFadeOutTime = 0x4;
            }
            export namespace CAnimUpdateNodeBase {
                export const m_name = 0x50;
                export const m_nodePath = 0x18;
                export const m_networkMode = 0x48;
            }
            export namespace CAnimUserDifference {
                export const m_name = 0x0;
                export const m_nType = 0x10;
            }
            export namespace CBindPoseUpdateNode {

            }
            export namespace CBoneConstraintBase {

            }
            export namespace CBoneMaskUpdateNode {
                export const m_blendSpace = 0x9C;
                export const m_bUseBlendScale = 0xA4;
                export const m_hBlendParameter = 0xAC;
                export const m_blendValueSource = 0xA8;
                export const m_footMotionTiming = 0xA0;
                export const m_nWeightListIndex = 0x94;
                export const m_flRootMotionBlend = 0x98;
            }
            export namespace CChoiceInstanceData {
                export const m_currentChoice = 0x10;
                export const m_previousChoice = 0x1C;
                export const m_flClipStartTime = 0x20;
                export const m_choicePreviousCycle = 0x2C;
            }
            export namespace CChoreoInstanceData {
                export const m_AnimOverlay = 0x0;
            }
            export namespace CFloatAnimParameter {
                export const m_fMaxValue = 0x88;
                export const m_fMinValue = 0x84;
                export const m_bInterpolate = 0x8C;
                export const m_fDefaultValue = 0x80;
            }
            export namespace CFootLockUpdateNode {
                export const m_bResetChild = 0x153;
                export const m_flBlendTime = 0x13C;
                export const m_footSettings = 0xE0;
                export const m_bApplyHipShift = 0x151;
                export const m_flHipShiftScale = 0x138;
                export const m_hipShiftDamping = 0xF8;
                export const m_opFixedSettings = 0x70;
                export const m_rootHeightDamping = 0x110;
                export const m_flStrideCurveScale = 0x128;
                export const m_bModulateStepHeight = 0x152;
                export const m_flMaxRootHeightOffset = 0x140;
                export const m_flMinRootHeightOffset = 0x144;
                export const m_flStrideCurveLimitScale = 0x12C;
                export const m_bApplyFootRotationLimits = 0x150;
                export const m_bEnableRootHeightDamping = 0x155;
                export const m_flStepHeightDecreaseScale = 0x134;
                export const m_flStepHeightIncreaseScale = 0x130;
                export const m_bEnableVerticalCurvedPaths = 0x154;
                export const m_flTiltPlaneRollSpringStrength = 0x14C;
                export const m_flTiltPlanePitchSpringStrength = 0x148;
            }
            export namespace CHitReactUpdateNode {
                export const m_bResetChild = 0xCC;
                export const m_hitBoneParam = 0xBE;
                export const m_triggerParam = 0xBC;
                export const m_hitOffsetParam = 0xC0;
                export const m_opFixedSettings = 0x70;
                export const m_hitStrengthParam = 0xC4;
                export const m_hitDirectionParam = 0xC2;
                export const m_flMinDelayBetweenHits = 0xC8;
            }
            export namespace CModelConfigElement {
                export const m_ElementName = 0x8;
                export const m_NestedElements = 0x10;
            }
            export namespace CMotionNodeSequence {
                export const m_tags = 0x28;
                export const m_hSequence = 0x40;
                export const m_flPlaybackSpeed = 0x44;
            }
            export namespace CNmFloatChannelData {
                export const m_setID = 0x8;
                export const m_skeleton = 0x0;
                export const m_compressedData = 0x28;
                export const m_channelSettings = 0x10;
                export const m_compressedOffsets = 0x40;
            }
            export namespace CNmOverlayBlendTask {

            }
            export namespace CParticleFloatInput {
                export const m_Curve = 0x130;
                export const m_nType = 0x10;
                export const m_flLOD0 = 0x98;
                export const m_flLOD1 = 0x9C;
                export const m_flLOD2 = 0xA0;
                export const m_flLOD3 = 0xA4;
                export const m_flInput0 = 0x100;
                export const m_flInput1 = 0x104;
                export const m_nMapType = 0x14;
                export const m_flOutput0 = 0x108;
                export const m_flOutput1 = 0x10C;
                export const m_nBiasType = 0x124;
                export const m_NamedValue = 0x20;
                export const m_nInputMode = 0xF8;
                export const m_nNoiseType = 0xD0;
                export const m_nRoundType = 0x120;
                export const m_flRandomMax = 0x78;
                export const m_flRandomMin = 0x74;
                export const m_nRandomMode = 0x84;
                export const m_nRandomSeed = 0x80;
                export const m_flMultFactor = 0xFC;
                export const m_flNoiseScale = 0xB4;
                export const m_bReverseOrder = 0x70;
                export const m_flNoiseOffset = 0xC4;
                export const m_nControlPoint = 0x60;
                export const m_nNoiseOctaves = 0xC8;
                export const m_flCompareValue = 0x170;
                export const m_flLiteralValue = 0x18;
                export const m_nNoiseModifier = 0xD4;
                export const m_flBiasParameter = 0x128;
                export const m_bUseBoundsCenter = 0xF4;
                export const m_flNoiseOutputMax = 0xB0;
                export const m_flNoiseOutputMin = 0xAC;
                export const m_nNoiseTurbulence = 0xCC;
                export const m_nScalarAttribute = 0x64;
                export const m_nVectorAttribute = 0x68;
                export const m_nVectorComponent = 0x6C;
                export const m_flNotchedRangeMax = 0x114;
                export const m_flNotchedRangeMin = 0x110;
                export const m_strSnapshotSubset = 0x90;
                export const m_bHasRandomSignFlip = 0x7C;
                export const m_flNoCameraFallback = 0xF0;
                export const m_vecNoiseOffsetRate = 0xB8;
                export const m_bNoiseImgPreviewLive = 0xE4;
                export const m_flNoiseTurbulenceMix = 0xDC;
                export const m_flNotchedOutputInside = 0x11C;
                export const m_flNoiseImgPreviewScale = 0xE0;
                export const m_flNoiseTurbulenceScale = 0xD8;
                export const m_flNotchedOutputOutside = 0x118;
                export const m_nNoiseInputVectorAttribute = 0xA8;
            }
            export namespace CParticleModelInput {
                export const m_nType = 0x10;
                export const m_NamedValue = 0x18;
                export const m_nControlPoint = 0x58;
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
            export namespace CPulse_PublicOutput {
                export const m_Args = 0x18;
                export const m_Name = 0x0;
                export const m_Description = 0x10;
            }
            export namespace CPulse_RegisterInfo {
                export const m_Type = 0x8;
                export const m_nReg = 0x0;
                export const m_OriginName = 0x20;
                export const m_nWrittenByInstruction = 0x58;
                export const m_nLastReadByInstruction = 0x5C;
            }
            export namespace CSelectorUpdateNode {
                export const m_tags = 0x78;
                export const m_children = 0x60;
                export const m_nTagIndex = 0xA8;
                export const m_blendCurve = 0x94;
                export const m_hParameter = 0xA4;
                export const m_flBlendTime = 0x9C;
                export const m_eTagBehavior = 0xAC;
                export const m_bResetOnChange = 0xB0;
                export const m_bLockWhenWaning = 0xB1;
                export const m_bSyncCyclesOnChange = 0xB2;
            }
            export namespace CSequenceUpdateNode {
                export const m_tags = 0x98;
                export const m_duration = 0x7C;
                export const m_hSequence = 0x78;
                export const m_paramSpans = 0x80;
            }
            export namespace CStateActionUpdater {
                export const m_pAction = 0x0;
                export const m_eBehavior = 0x8;
            }
            export namespace CStateNodeStateData {
                export const m_pChild = 0x0;
                export const m_bExclusiveRootMotion = 0x0;
                export const m_bExclusiveRootMotionFirstFrame = 0x0;
            }
            export namespace CSubtractUpdateNode {
                export const m_bUseModelSpace = 0x9A;
                export const m_footMotionTiming = 0x94;
                export const m_bApplyToFootMotion = 0x98;
                export const m_bApplyChannelsSeparately = 0x99;
            }
            export namespace CWarpSectionAnimTag {
                export const m_bWarpPosition = 0x50;
                export const m_bWarpOrientation = 0x51;
            }
            export namespace CZeroPoseUpdateNode {

            }
            export namespace ModelEmbeddedMesh_t {
                export const m_Name = 0x0;
                export const m_nDataBlock = 0x14;
                export const m_nMeshIndex = 0x10;
                export const m_nVBIBBlock = 0x68;
                export const m_nMorphBlock = 0x18;
                export const m_indexBuffers = 0x38;
                export const m_toolsBuffers = 0x50;
                export const m_nToolsVBBlock = 0x6C;
                export const m_vertexBuffers = 0x20;
            }
            export namespace ModelSkeletonData_t {
                export const m_nFlag = 0x48;
                export const m_nParent = 0x18;
                export const m_boneName = 0x0;
                export const m_boneSphere = 0x30;
                export const m_bonePosParent = 0x60;
                export const m_boneRotParent = 0x78;
                export const m_boneScaleParent = 0x90;
            }
            export namespace TwoBoneIKSettings_t {
                export const m_flMaxTwist = 0x150;
                export const m_targetType = 0x90;
                export const m_nEndBoneIndex = 0x148;
                export const m_hPositionParam = 0x124;
                export const m_hRotationParam = 0x126;
                export const m_bConstrainTwist = 0x14D;
                export const m_endEffectorType = 0x0;
                export const m_nFixedBoneIndex = 0x140;
                export const m_targetBoneIndex = 0x120;
                export const m_nMiddleBoneIndex = 0x144;
                export const m_targetAttachment = 0xA0;
                export const m_vLsFallbackHingeAxis = 0x130;
                export const m_endEffectorAttachment = 0x10;
                export const m_bAlwaysUseFallbackHinge = 0x128;
                export const m_bMatchTargetOrientation = 0x14C;
            }
            export namespace VPhysXConstraint2_t {
                export const m_nChild = 0x6;
                export const m_nFlags = 0x0;
                export const m_params = 0x8;
                export const m_nParent = 0x4;
            }
            export namespace VPhysics2ShapeDef_t {
                export const m_hulls = 0x20;
                export const m_meshes = 0x30;
                export const m_spheres = 0x0;
                export const m_capsules = 0x10;
                export const m_compounds = 0x40;
                export const m_CollisionAttributeIndices = 0x50;
            }
            export namespace CAimCameraUpdateNode {
                export const m_opFixedSettings = 0x80;
                export const m_hParameterPosition = 0x70;
                export const m_hParameterCameraOnly = 0x76;
                export const m_hParameterOrientation = 0x72;
                export const m_hParameterPelvisOffset = 0x74;
                export const m_hParameterCameraClearanceDistance = 0x7C;
                export const m_hParameterWeaponDepenetrationDelta = 0x7A;
                export const m_hParameterWeaponDepenetrationDistance = 0x78;
            }
            export namespace CAimMatrixUpdateNode {
                export const m_target = 0x168;
                export const m_hSequence = 0x170;
                export const m_paramIndex = 0x16C;
                export const m_bResetChild = 0x174;
                export const m_bLockWhenWaning = 0x175;
                export const m_opFixedSettings = 0x70;
            }
            export namespace CAnimDataChannelDesc {
                export const m_nType = 0x24;
                export const m_nFlags = 0x20;
                export const m_szGrouping = 0x28;
                export const m_szDescription = 0x38;
                export const m_szChannelClass = 0x0;
                export const m_szVariableName = 0x10;
                export const m_nElementMaskArray = 0x78;
                export const m_nElementIndexArray = 0x60;
                export const m_szElementNameArray = 0x48;
            }
            export namespace CAnimEventDefinition {
                export const m_nFrame = 0x8;
                export const m_flCycle = 0x10;
                export const m_EventData = 0x18;
                export const m_nEndFrame = 0xC;
                export const m_flDuration = 0x14;
                export const m_sEventName = 0x38;
                export const m_sLegacyOptions = 0x28;
            }
            export namespace CAnimMorphDifference {
                export const m_name = 0x0;
            }
            export namespace CBlend2DInstanceData {
                export const m_flCycle = 0x44;
                export const m_dampedValue = 0x8;
                export const m_flPrevCycle = 0x48;
            }
            export namespace CEditableMotionGraph {

            }
            export namespace CFootCycleDefinition {
                export const m_stanceCycle = 0x28;
                export const m_footOffCycle = 0x30;
                export const m_footLandCycle = 0x38;
                export const m_footLiftCycle = 0x2C;
                export const m_footStrikeCycle = 0x34;
                export const m_vStancePositionMS = 0x0;
                export const m_vToStrideStartPos = 0x1C;
                export const m_flStanceDirectionMS = 0x18;
                export const m_vMidpointPositionMS = 0xC;
            }
            export namespace CLODComponentUpdater {
                export const m_nServerLOD = 0x30;
            }
            export namespace CNmAdditiveBlendTask {

            }
            export namespace CNmFloatChannelSet_t {
                export const m_ID = 0x0;
                export const m_channelIDs = 0x8;
            }
            export namespace CNmReferencePoseTask {

            }
            export namespace CParticleVariableRef {
                export const m_variableName = 0x0;
                export const m_variableType = 0x38;
            }
            export namespace CPathMetricEvaluator {
                export const m_flDistance = 0x68;
                export const m_pathTimeSamples = 0x50;
                export const m_bExtrapolateMovement = 0x6C;
                export const m_flMinExtrapolationSpeed = 0x70;
            }
            export namespace CPerParticleVecInput {

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
            export namespace CRenderBufferBinding {
                export const m_hBuffer = 0x0;
                export const m_nBindOffsetBytes = 0x10;
            }
            export namespace CSymbolAnimParameter {
                export const m_defaultValue = 0x80;
            }
            export namespace CTiltTwistConstraint {
                export const m_nSlaveAxis = 0x64;
                export const m_nTargetAxis = 0x60;
            }
            export namespace CTwoBoneIKUpdateNode {
                export const m_opFixedData = 0x70;
            }
            export namespace CVectorAnimParameter {
                export const m_vectorType = 0x90;
                export const m_bInterpolate = 0x8C;
                export const m_defaultValue = 0x80;
            }
            export namespace FollowAttachmentData {
                export const m_boneIndex = 0x0;
                export const m_attachmentHandle = 0x4;
            }
            export namespace IKBoneNameAndIndex_t {
                export const m_Name = 0x0;
            }
            export namespace JiggleBoneSettings_t {
                export const m_eSimSpace = 0x28;
                export const m_flDamping = 0xC;
                export const m_nBoneIndex = 0x0;
                export const m_vBoundsMaxLS = 0x10;
                export const m_vBoundsMinLS = 0x1C;
                export const m_flMaxTimeStep = 0x8;
                export const m_flSpringStrength = 0x4;
            }
            export namespace ModelAnimGraph2Ref_t {
                export const m_hGraph = 0x8;
                export const m_sIdentifier = 0x0;
            }
            export namespace MoodAnimationLayer_t {
                export const m_sName = 0x0;
                export const m_flFadeIn = 0x54;
                export const m_flFadeOut = 0x58;
                export const m_flEndOffset = 0x4C;
                export const m_flIntensity = 0x28;
                export const m_flNextStart = 0x3C;
                export const m_flStartOffset = 0x44;
                export const m_bActiveTalking = 0x9;
                export const m_bScaleWithInts = 0x38;
                export const m_flDurationScale = 0x30;
                export const m_layerAnimations = 0x10;
                export const m_bActiveListening = 0x8;
            }
            export namespace NmContactAudioInfo_t {
                export const m_audioTypeID = 0x8;
                export const m_audioActionID = 0x0;
                export const m_soundeventOverrideID = 0x10;
            }
            export namespace RenderSkeletonBone_t {
                export const m_bbox = 0x40;
                export const m_boneName = 0x0;
                export const m_parentName = 0x8;
                export const m_invBindPose = 0x10;
                export const m_flSphereRadius = 0x58;
            }
            export namespace SkeletonBoneBounds_t {
                export const m_vecSize = 0xC;
                export const m_vecCenter = 0x0;
            }
            export namespace CAnimComponentUpdater {
                export const m_id = 0x20;
                export const m_name = 0x18;
                export const m_networkMode = 0x24;
                export const m_bStartEnabled = 0x28;
            }
            export namespace CAnimEncodeDifference {
                export const m_boneArray = 0x0;
                export const m_userArray = 0x30;
                export const m_morphArray = 0x18;
                export const m_bHasUserBitArray = 0x90;
                export const m_bHasMorphBitArray = 0x78;
                export const m_bHasMovementBitArray = 0x60;
                export const m_bHasRotationBitArray = 0x48;
            }
            export namespace CAnimGraphDebugReplay {
                export const m_frameList = 0x48;
                export const m_frameCount = 0x68;
                export const m_startIndex = 0x60;
                export const m_writeIndex = 0x64;
                export const m_animGraphFileName = 0x40;
            }
            export namespace CAnimMotorUpdaterBase {
                export const m_name = 0x10;
                export const m_bDefault = 0x18;
            }
            export namespace CAnimUpdateSharedData {
                export const m_nodes = 0x10;
                export const m_settings = 0x78;
                export const m_pSkeleton = 0xB0;
                export const m_components = 0x48;
                export const m_nodeIndexMap = 0x28;
                export const m_rootNodePath = 0xB8;
                export const m_scriptManager = 0x70;
                export const m_pStaticPoseCache = 0xA8;
                export const m_pParamListUpdater = 0x60;
                export const m_pTagManagerUpdater = 0x68;
            }
            export namespace CClothSettingsAnimTag {
                export const m_flEaseIn = 0x5C;
                export const m_flEaseOut = 0x60;
                export const m_nVertexSet = 0x68;
                export const m_flStiffness = 0x58;
            }
            export namespace CEmitTagActionUpdater {
                export const m_nTagIndex = 0x18;
                export const m_bIsZeroDuration = 0x1C;
            }
            export namespace CFollowPathUpdateNode {
                export const m_hParam = 0xAC;
                export const m_flScale = 0x7C;
                export const m_flMaxAngle = 0x84;
                export const m_flMinAngle = 0x80;
                export const m_bScaleSpeed = 0x7A;
                export const m_bTurnToFace = 0xB4;
                export const m_turnDamping = 0x90;
                export const m_facingTarget = 0xA8;
                export const m_flBlendOutTime = 0x74;
                export const m_bStopFeetAtGoal = 0x79;
                export const m_flTurnToFaceOffset = 0xB0;
                export const m_flSpeedScaleBlending = 0x88;
                export const m_bBlockNonPathMovement = 0x78;
            }
            export namespace CHandshakeAnimTagBase {
                export const m_bIsDisableTag = 0x50;
            }
            export namespace CJiggleBoneUpdateNode {
                export const m_opFixedData = 0x70;
            }
            export namespace CJumpHelperUpdateNode {
                export const m_bScaleSpeed = 0xD3;
                export const m_hTargetParam = 0xB0;
                export const m_flJumpEndCycle = 0xC8;
                export const m_bTranslationAxis = 0xD0;
                export const m_flJumpStartCycle = 0xC4;
                export const m_eCorrectionMethod = 0xCC;
                export const m_flOriginalJumpDuration = 0xC0;
                export const m_flOriginalJumpMovement = 0xB4;
            }
            export namespace CLeanMatrixUpdateNode {
                export const m_poses = 0x80;
                export const m_damping = 0xA8;
                export const m_hSequence = 0xE0;
                export const m_flMaxValue = 0xE4;
                export const m_paramIndex = 0xC4;
                export const m_blendSource = 0xC0;
                export const m_frameCorners = 0x5C;
                export const m_verticalAxis = 0xC8;
                export const m_horizontalAxis = 0xD4;
                export const m_nSequenceMaxFrame = 0xE8;
            }
            export namespace CLookComponentUpdater {
                export const m_hLookPitch = 0x3A;
                export const m_hLookTarget = 0x40;
                export const m_hLookHeading = 0x34;
                export const m_hLookDistance = 0x3C;
                export const m_hLookDirection = 0x3E;
                export const m_bNetworkLookTarget = 0x44;
                export const m_hLookHeadingVelocity = 0x38;
                export const m_hLookTargetWorldSpace = 0x42;
                export const m_hLookHeadingNormalized = 0x36;
            }
            export namespace CNmCachedPoseReadTask {

            }
            export namespace CNmSyncTrack__Event_t {
                export const m_ID = 0x0;
                export const m_duration = 0xC;
                export const m_startTime = 0x8;
            }
            export namespace CPathAnimMotorUpdater {

            }
            export namespace CPathHelperUpdateNode {
                export const m_flStoppingRadius = 0x70;
                export const m_flStoppingSpeedScale = 0x74;
            }
            export namespace CPulseCell_LimitCount {
                export const m_nLimitCount = 0x48;
            }
            export namespace CRemapValueUpdateItem {
                export const m_hParamIn = 0x0;
                export const m_hParamOut = 0x2;
                export const m_flMaxInputValue = 0x8;
                export const m_flMinInputValue = 0x4;
                export const m_flMaxOutputValue = 0x10;
                export const m_flMinOutputValue = 0xC;
            }
            export namespace CSpeedScaleUpdateNode {
                export const m_paramIndex = 0x70;
            }
            export namespace CStopAtGoalUpdateNode {
                export const m_damping = 0x88;
                export const m_flMaxScale = 0x7C;
                export const m_flMinScale = 0x80;
                export const m_flInnerRadius = 0x78;
                export const m_flOuterRadius = 0x74;
            }
            export namespace CTargetWarpUpdateNode {
                export const m_eAngleMode = 0x74;
                export const m_flMaxAngle = 0x94;
                export const m_bWarpAroundCenter = 0x90;
                export const m_eCorrectionMethod = 0x84;
                export const m_hMoveHeadingParameter = 0x7E;
                export const m_bOnlyWarpWhenTagIsFound = 0x8E;
                export const m_eTargetWarpTimingMethod = 0x88;
                export const m_hTargetPositionParameter = 0x78;
                export const m_hTargetUpVectorParameter = 0x7A;
                export const m_bTargetPositionIsWorldSpace = 0x8D;
                export const m_hDesiredMoveHeadingParameter = 0x80;
                export const m_hTargetFacePositionParameter = 0x7C;
                export const m_bTargetFacePositionIsWorldSpace = 0x8C;
                export const m_bWarpOrientationDuringTranslation = 0x8F;
            }
            export namespace CTaskHandshakeAnimTag {

            }
            export namespace CTransitionUpdateData {
                export const m_bDisabled = 0x0;
                export const m_srcStateIndex = 0x0;
                export const m_destStateIndex = 0x1;
                export const m_nHandshakeMaskToDisableFirst = 0x0;
            }
            export namespace CTurnHelperUpdateNode {
                export const m_facingTarget = 0x74;
                export const m_turnDuration = 0x7C;
                export const m_manualTurnOffset = 0x84;
                export const m_bMatchChildDuration = 0x80;
                export const m_turnStartTimeOffset = 0x78;
                export const m_bUseManualTurnOffset = 0x88;
            }
            export namespace CVirtualAnimParameter {
                export const m_eParamType = 0x78;
                export const m_expressionString = 0x70;
            }
            export namespace ModelBoneFlexDriver_t {
                export const m_boneName = 0x0;
                export const m_controls = 0x10;
                export const m_boneNameToken = 0x8;
            }
            export namespace ModelMeshBufferData_t {
                export const m_nBlockIndex = 0x0;
                export const m_nBufferUsage = 0x14;
                export const m_nElementCount = 0x4;
                export const m_bCompressedZSTD = 0xF;
                export const m_bCreateBufferSRV = 0x10;
                export const m_bCreateBufferUAV = 0x11;
                export const m_bCreateRawBuffer = 0x12;
                export const m_inputLayoutFields = 0x18;
                export const m_bMeshoptCompressed = 0xC;
                export const m_bCreatePooledBuffer = 0x13;
                export const m_nElementSizeInBytes = 0x8;
                export const m_bMeshoptIndexSequence = 0xD;
                export const m_nMeshoptMeshletEncodeVersion = 0xE;
            }
            export namespace SkeletonAnimCapture_t {
                export const m_Frames = 0xA8;
                export const m_ModelName = 0x20;
                export const m_nEntIndex = 0x0;
                export const m_bPredicted = 0x64;
                export const m_nEntParent = 0x4;
                export const m_CaptureName = 0x28;
                export const m_ModelBindPose = 0x30;
                export const m_FeModelInitPose = 0x48;
                export const m_nFlexControllers = 0x60;
                export const m_ImportedCollision = 0x8;
            }
            export namespace VPhysXAggregateData_t {
                export const m_parts = 0x80;
                export const m_joints = 0xC8;
                export const m_nFlags = 0x0;
                export const m_bindPose = 0x68;
                export const m_pFeModel = 0xE0;
                export const m_boneNames = 0x20;
                export const m_bonesHash = 0x8;
                export const m_indexHash = 0x50;
                export const m_indexNames = 0x38;
                export const m_boneParents = 0xE8;
                export const m_nRefCounter = 0x2;
                export const m_constraints2 = 0xB0;
                export const m_shapeMarkups = 0x98;
                export const m_debugPartNames = 0x130;
                export const m_bCompoundsPacked = 0x4;
                export const m_embeddedKeyvalues = 0x148;
                export const m_collisionAttributes = 0x118;
                export const m_surfacePropertyHashes = 0x100;
            }
            export namespace CAnimGraphModelBinding {
                export const m_modelName = 0x8;
                export const m_pSharedData = 0x10;
            }
            export namespace CAnimTagManagerUpdater {
                export const m_tags = 0x38;
            }
            export namespace CBlendNodeInstanceData {
                export const m_flCycle = 0x4;
                export const m_flDuration = 0x1C;
                export const m_resetCount = 0x20;
                export const m_dampedValue = 0x0;
                export const m_flBlendValue = 0x10;
                export const m_flPlaybackRate = 0xC;
                export const m_flCycleZeroTime = 0x8;
            }
            export namespace CConcreteAnimParameter {
                export const m_bAutoReset = 0x79;
                export const m_bGameWritable = 0x7A;
                export const m_previewButton = 0x70;
                export const m_bGraphWritable = 0x7B;
                export const m_eNetworkSetting = 0x74;
                export const m_bUseMostRecentValue = 0x78;
            }
            export namespace CCycleClipInstanceData {
                export const m_flCycle = 0x0;
                export const m_flPrevCycle = 0xC;
            }
            export namespace CDampedValueUpdateItem {
                export const m_damping = 0x0;
                export const m_hParamIn = 0x20;
                export const m_hParamOut = 0x22;
            }
            export namespace CDirectPlaybackTagData {
                export const m_tags = 0x8;
                export const m_sequenceName = 0x0;
            }
            export namespace CFootPinningUpdateNode {
                export const m_params = 0xB0;
                export const m_bResetChild = 0xC8;
                export const m_eTimingSource = 0xA8;
                export const m_poseOpFixedData = 0x78;
            }
            export namespace CFootstepLandedAnimTag {
                export const m_BoneName = 0x70;
                export const m_FootstepType = 0x58;
                export const m_OverrideSoundName = 0x60;
                export const m_footstepJumpPhase = 0x78;
                export const m_DebugAnimSourceString = 0x68;
            }
            export namespace CInputStreamUpdateNode {

            }
            export namespace CMotionGraphUpdateNode {
                export const m_pMotionGraph = 0x58;
            }
            export namespace CMotionMetricEvaluator {
                export const m_means = 0x18;
                export const m_flWeight = 0x48;
                export const m_standardDeviations = 0x30;
                export const m_nDimensionStartIndex = 0x4C;
            }
            export namespace CNmCachedPoseWriteTask {

            }
            export namespace CNmModelSpaceBlendTask {

            }
            export namespace CNmOrNode__CDefinition {
                export const m_conditionNodeIndices = 0x10;
            }
            export namespace CPerParticleFloatInput {

            }
            export namespace CPhysSurfaceProperties {
                export const m_name = 0x0;
                export const m_bHidden = 0x18;
                export const m_physics = 0x28;
                export const m_nameHash = 0x8;
                export const m_audioParams = 0xA8;
                export const m_audioSounds = 0x48;
                export const m_description = 0x20;
                export const m_baseNameHash = 0xC;
                export const m_vehicleParams = 0x40;
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
            export namespace CPulseRuntimeMethodArg {
                export const m_Name = 0x0;
                export const m_Type = 0x40;
                export const m_Description = 0x38;
            }
            export namespace CSingleFrameUpdateNode {
                export const m_actions = 0x58;
                export const m_flCycle = 0x78;
                export const m_hSequence = 0x74;
                export const m_hPoseCacheHandle = 0x70;
            }
            export namespace CSlopeComponentUpdater {
                export const m_hSlopeAngle = 0x38;
                export const m_hSlopeNormal = 0x40;
                export const m_hSlopeHeading = 0x3E;
                export const m_flTraceDistance = 0x34;
                export const m_hSlopeAngleSide = 0x3C;
                export const m_hSlopeAngleFront = 0x3A;
                export const m_hSlopeNormal_WorldSpace = 0x42;
            }
            export namespace CSolveIKTargetHandle_t {
                export const m_positionHandle = 0x0;
                export const m_orientationHandle = 0x2;
            }
            export namespace CStanceScaleUpdateNode {
                export const m_hParam = 0x70;
            }
            export namespace CStateNodeInstanceData {
                export const m_resetCount = 0x3C;
                export const m_stateWeights = 0x0;
                export const m_currentStateStartTime = 0x20;
                export const m_vTransitionVelocityDeltaWS = 0x8;
            }
            export namespace NmSyncTrackTimeRange_t {
                export const m_endTime = 0x8;
                export const m_startTime = 0x0;
            }
            export namespace PulseGraphInstanceID_t {
                export const m_Value = 0x0;
            }
            export namespace PulseRuntimeVarIndex_t {
                export const m_Value = 0x0;
            }
            export namespace RenderHairStrandInfo_t {
                export const m_nPackedBaseUv = 0x18;
                export const m_nDataOffset_Segments = 0x24;
                export const m_vGuideBary_vBaseBary = 0x8;
                export const m_nPackedSurfaceNormalOs = 0x1C;
                export const m_nPackedSurfaceTangentOs = 0x20;
                export const m_vRootOffset_flLengthScale = 0x10;
                export const m_nGuideHairIndices_nSurfaceTriIndex = 0x0;
            }
            export namespace SelectorInstanceData_t {
                export const m_weights = 0x0;
                export const m_currentIndex = 0x14;
                export const m_previousIndex = 0x18;
                export const m_currentIndexStartTime = 0x8;
            }
            export namespace AnimationSnapshotBase_t {
                export const m_DecodeDump = 0x98;
                export const m_flRealTime = 0x0;
                export const m_rootToWorld = 0x10;
                export const m_SnapshotType = 0x90;
                export const m_boneSetupMask = 0x48;
                export const m_bHasDecodeDump = 0x94;
                export const m_boneTransforms = 0x60;
                export const m_flexControllers = 0x78;
                export const m_bBonesInWorldSpace = 0x40;
            }
            export namespace CActionComponentUpdater {
                export const m_actions = 0x30;
            }
            export namespace CAnimGraphSettingsGroup {

            }
            export namespace CAnimationGraphInstance {
                export const m_bTagDispatchDirty = 0x329;
            }
            export namespace CBasePulseGraphInstance {

            }
            export namespace CCycleControlUpdateNode {
                export const m_paramIndex = 0x74;
                export const m_valueSource = 0x70;
                export const m_bLockWhenWaning = 0x76;
            }
            export namespace CFollowPathInstanceData {
                export const m_flTurnAmount = 0xC;
                export const m_flLastPathTime = 0x1C;
                export const m_dampedTurnValue = 0x8;
                export const m_flPredictionScale = 0x10;
                export const m_xLastPredictedTransformsDeltas = 0x0;
            }
            export namespace CFollowTargetUpdateNode {
                export const m_opFixedData = 0x70;
                export const m_hParameterPosition = 0x88;
                export const m_hParameterOrientation = 0x8A;
            }
            export namespace CLeanMatrixInstanceData {
                export const m_flValueX = 0x4;
                export const m_flValueY = 0x0;
            }
            export namespace CMaterialDrawDescriptor {
                export const m_flAlpha = 0x10;
                export const m_material = 0x118;
                export const m_vTintColor = 0x4;
                export const m_flUvDensity = 0x0;
                export const m_indexBuffer = 0xC8;
                export const m_nBaseVertex = 0x54;
                export const m_nIndexCount = 0x60;
                export const m_nStartIndex = 0x5C;
                export const m_nNumMeshlets = 0x18;
                export const m_nVertexCount = 0x58;
                export const m_rootBvhNodes = 0x40;
                export const m_nFirstMeshlet = 0x20;
                export const m_nPrimitiveType = 0x50;
                export const m_rigidMeshParts = 0x30;
                export const m_meshletPackedIVB = 0xE8;
                export const m_nAppliedIndexOffset = 0x24;
                export const m_nMeshletPackedIVBIndex = 0x2D;
                export const m_nDepthVertexBufferIndex = 0x2C;
                export const m_nEmissivePrimitiveCount = 0x28;
            }
            export namespace CNmAndNode__CDefinition {
                export const m_conditionNodeIndices = 0x10;
            }
            export namespace CNmNotNode__CDefinition {
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmOrientationWarpEvent {

            }
            export namespace CParticleTransformInput {
                export const m_nType = 0x10;
                export const m_NamedValue = 0x18;
                export const m_nControlPoint = 0x5C;
                export const m_bUseOrientation = 0x5A;
                export const m_bFollowNamedValue = 0x58;
                export const m_bSupportsDisabled = 0x59;
                export const m_flEndCPGrowthTime = 0x64;
                export const m_nControlPointRangeMax = 0x60;
            }
            export namespace CPulseCell_Inflow_Yield {
                export const m_UnyieldResume = 0xD8;
            }
            export namespace CPulseCell_ReturnValues {

            }
            export namespace CPulse_InstructionDebug {
                export const m_nFlowNodeID = 0x0;
                export const m_nValueNodeID = 0x4;
                export const m_SequencePointName = 0x8;
            }
            export namespace CPulse_OutputConnection {
                export const m_Param = 0x30;
                export const m_TargetInput = 0x20;
                export const m_SourceOutput = 0x0;
                export const m_TargetEntity = 0x10;
            }
            export namespace CSequenceUpdateNodeBase {
                export const m_bLoop = 0x70;
                export const m_playbackSpeed = 0x6C;
            }
            export namespace CSolveIKChainUpdateNode {
                export const m_opFixedData = 0x88;
                export const m_targetHandles = 0x70;
            }
            export namespace CStateMachineUpdateNode {
                export const m_stateData = 0xC8;
                export const m_stateMachine = 0x70;
                export const m_transitionData = 0xE0;
                export const m_bBlockWaningTags = 0xFC;
                export const m_bResetWhenActivated = 0xFE;
                export const m_bLockStateWhenWaning = 0xFD;
            }
            export namespace CStaticPoseCacheBuilder {

            }
            export namespace CTurnHelperInstanceData {
                export const m_duration = 0x8;
                export const m_turnAmount = 0x0;
                export const m_turnStartTime = 0x4;
            }
            export namespace CWarpSectionAnimTagBase {

            }
            export namespace HitReactFixedSettings_t {
                export const m_flWhipDelay = 0x20;
                export const m_flHipDipDelay = 0x40;
                export const m_nHipBoneIndex = 0x30;
                export const m_flMaxImpactForce = 0x8;
                export const m_flMinImpactForce = 0xC;
                export const m_flSpringStrength = 0x24;
                export const m_nWeightListIndex = 0x0;
                export const m_flMaxAngleRadians = 0x2C;
                export const m_flWhipImpactScale = 0x10;
                export const m_flPropagationScale = 0x1C;
                export const m_nEffectedBoneCount = 0x4;
                export const m_flDistanceFadeScale = 0x18;
                export const m_flHipDipImpactScale = 0x3C;
                export const m_flWhipSpringStrength = 0x28;
                export const m_flCounterRotationScale = 0x14;
                export const m_flHipDipSpringStrength = 0x38;
                export const m_flHipBoneTranslationScale = 0x34;
            }
            export namespace IAnimationGraphInstance {

            }
            export namespace IKDemoCaptureSettings_t {
                export const m_eMode = 0x8;
                export const m_oneBoneEnd = 0x20;
                export const m_ikChainName = 0x10;
                export const m_oneBoneStart = 0x18;
                export const m_parentBoneName = 0x0;
            }
            export namespace LookAtOpFixedSettings_t {
                export const m_bones = 0x98;
                export const m_damping = 0x80;
                export const m_attachment = 0x0;
                export const m_flYawLimit = 0xB0;
                export const m_flPitchLimit = 0xB4;
                export const m_bUseHysteresis = 0xC3;
                export const m_bRotateYawForward = 0xC0;
                export const m_bTargetIsPosition = 0xC2;
                export const m_bMaintainUpDirection = 0xC1;
                export const m_flHysteresisInnerAngle = 0xB8;
                export const m_flHysteresisOuterAngle = 0xBC;
            }
            export namespace NmCompressionSettings_t {
                export const m_scaleRange = 0x18;
                export const m_bIsScaleStatic = 0x42;
                export const m_constantRotation = 0x30;
                export const m_nTrackReadOffset = 0x20;
                export const m_bIsRotationStatic = 0x40;
                export const m_translationRangeX = 0x0;
                export const m_translationRangeY = 0x8;
                export const m_translationRangeZ = 0x10;
                export const m_bIsTranslationStatic = 0x41;
            }
            export namespace PulseCursorYieldToken_t {
                export const m_Value = 0x0;
            }
            export namespace PulseRuntimeCellIndex_t {
                export const m_Value = 0x0;
            }
            export namespace SignatureOutflow_Resume {

            }
            export namespace CAnimDemoCaptureSettings {
                export const m_bones = 0x50;
                export const m_ikChains = 0x68;
                export const m_baseSequence = 0x40;
                export const m_boneSelectionMode = 0x4C;
                export const m_nBaseSequenceFrame = 0x48;
                export const m_vecErrorRangeSplineScale = 0x10;
                export const m_flIkRotation_MaxSplineError = 0x18;
                export const m_vecErrorRangeSplineRotation = 0x0;
                export const m_flIkTranslation_MaxSplineError = 0x1C;
                export const m_vecErrorRangeQuantizationScale = 0x30;
                export const m_vecErrorRangeSplineTranslation = 0x8;
                export const m_flIkRotation_MaxQuantizationError = 0x38;
                export const m_vecErrorRangeQuantizationRotation = 0x20;
                export const m_flIkTranslation_MaxQuantizationError = 0x3C;
                export const m_vecErrorRangeQuantizationTranslation = 0x28;
            }
            export namespace CAnimStateMachineUpdater {
                export const m_states = 0x8;
                export const m_transitions = 0x20;
                export const m_startStateIndex = 0x50;
            }
            export namespace CExpressionActionUpdater {
                export const m_hParam = 0x18;
                export const m_hScript = 0x1C;
                export const m_eParamType = 0x1A;
            }
            export namespace CNmClipNode__CDefinition {
                export const m_graphEvents = 0x18;
                export const m_nDataSlotIdx = 0x14;
                export const m_bAllowLooping = 0x13;
                export const m_bSampleRootMotion = 0x12;
                export const m_flSpeedMultiplier = 0x40;
                export const m_nStartSyncEventOffset = 0x44;
                export const m_nResetTimeValueNodeIdx = 0x16;
                export const m_nPlayInReverseValueNodeIdx = 0x10;
            }
            export namespace CNmContactAudioTypeVData {

            }
            export namespace CNmPoseNode__CDefinition {

            }
            export namespace CParticleRemapFloatInput {

            }
            export namespace CPulseBreakpointLocation {
                export const m_NodeID = 0x0;
                export const m_PortName = 0x18;
                export const m_bDeferBreak = 0x28;
                export const m_SequencePoint = 0x8;
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
            export namespace CQuaternionAnimParameter {
                export const m_bInterpolate = 0x90;
                export const m_defaultValue = 0x80;
            }
            export namespace CRagdollComponentUpdater {
                export const m_boneNames = 0x78;
                export const m_boneIndices = 0x60;
                export const m_weightLists = 0x90;
                export const m_flMaxStretch = 0xC8;
                export const m_ragdollNodePaths = 0x30;
                export const m_boneToWeightIndices = 0xA8;
                export const m_flSpringFrequencyMax = 0xC4;
                export const m_flSpringFrequencyMin = 0xC0;
                export const m_followAttachmentNodePaths = 0x48;
                export const m_bSolidCollisionAtZeroWeight = 0xCC;
            }
            export namespace CSequenceFinishedAnimTag {
                export const m_sequenceName = 0x58;
            }
            export namespace CStateNodeTransitionData {
                export const m_curve = 0x0;
                export const m_bReset = 0x0;
                export const m_blendDuration = 0x8;
                export const m_resetCycleValue = 0x10;
                export const m_resetCycleOption = 0x0;
            }
            export namespace JiggleBoneSettingsList_t {
                export const m_boneSettings = 0x0;
            }
            export namespace ParticleAttributeIndex_t {
                export const m_Value = 0x0;
            }
            export namespace PulseRuntimeChunkIndex_t {
                export const m_Value = 0x0;
            }
            export namespace VPhysXConstraintParams_t {
                export const m_axes = 0x1C;
                export const m_nType = 0x0;
                export const m_anchor = 0x4;
                export const m_nFlags = 0x3;
                export const m_maxForce = 0x3C;
                export const m_maxTorque = 0x40;
                export const m_driveSpringX = 0xBC;
                export const m_driveSpringY = 0xC0;
                export const m_driveSpringZ = 0xC4;
                export const m_goalPosition = 0x94;
                export const m_driveDampingX = 0xC8;
                export const m_driveDampingY = 0xCC;
                export const m_driveDampingZ = 0xD0;
                export const m_nRotateMotion = 0x2;
                export const m_goalOrientation = 0xA0;
                export const m_driveSpringSlerp = 0xDC;
                export const m_driveSpringSwing = 0xD8;
                export const m_driveSpringTwist = 0xD4;
                export const m_linearLimitValue = 0x44;
                export const m_nTranslateMotion = 0x1;
                export const m_swing1LimitValue = 0x74;
                export const m_swing2LimitValue = 0x84;
                export const m_driveDampingSlerp = 0xE8;
                export const m_driveDampingSwing = 0xE4;
                export const m_driveDampingTwist = 0xE0;
                export const m_linearLimitSpring = 0x4C;
                export const m_swing1LimitSpring = 0x7C;
                export const m_swing2LimitSpring = 0x8C;
                export const m_linearLimitDamping = 0x50;
                export const m_swing1LimitDamping = 0x80;
                export const m_swing2LimitDamping = 0x90;
                export const m_twistLowLimitValue = 0x54;
                export const m_goalAngularVelocity = 0xB0;
                export const m_twistHighLimitValue = 0x64;
                export const m_twistLowLimitSpring = 0x5C;
                export const m_solverIterationCount = 0xEC;
                export const m_twistHighLimitSpring = 0x6C;
                export const m_twistLowLimitDamping = 0x60;
                export const m_twistHighLimitDamping = 0x70;
                export const m_linearLimitRestitution = 0x48;
                export const m_swing1LimitRestitution = 0x78;
                export const m_swing2LimitRestitution = 0x88;
                export const m_twistLowLimitRestitution = 0x58;
                export const m_projectionLinearTolerance = 0xF0;
                export const m_twistHighLimitRestitution = 0x68;
                export const m_projectionAngularTolerance = 0xF4;
            }
            export namespace BoneDemoCaptureSettings_t {
                export const m_boneName = 0x0;
                export const m_flErrorSplineScaleMax = 0x10;
                export const m_flErrorSplineRotationMax = 0x8;
                export const m_flErrorQuantizationScaleMax = 0x1C;
                export const m_flErrorSplineTranslationMax = 0xC;
                export const m_flErrorQuantizationRotationMax = 0x14;
                export const m_flErrorQuantizationTranslationMax = 0x18;
            }
            export namespace CAnimGraphNetworkSettings {
                export const m_bNetworkingEnabled = 0x20;
            }
            export namespace CAnimGraphSettingsManager {
                export const m_settingsGroups = 0x18;
            }
            export namespace CBoneConstraintDotToMorph {
                export const m_flRemap = 0x38;
                export const m_sBoneName = 0x20;
                export const m_sTargetBoneName = 0x28;
                export const m_sMorphChannelName = 0x30;
            }
            export namespace CDirectPlaybackUpdateNode {
                export const m_allTags = 0x78;
                export const m_bFinishEarly = 0x74;
                export const m_bResetOnFinish = 0x75;
            }
            export namespace CFootAdjustmentUpdateNode {
                export const m_clips = 0x78;
                export const m_bResetChild = 0xA8;
                export const m_facingTarget = 0x94;
                export const m_flTurnTimeMax = 0x9C;
                export const m_flTurnTimeMin = 0x98;
                export const m_flStepHeightMax = 0xA0;
                export const m_bAnimationDriven = 0xA9;
                export const m_flStepHeightMaxAngle = 0xA4;
                export const m_hBasePoseCacheHandle = 0x90;
            }
            export namespace CFootCycleMetricEvaluator {
                export const m_footIndices = 0x50;
            }
            export namespace CMaterialAttributeAnimTag {
                export const m_Color = 0x68;
                export const m_flValue = 0x64;
                export const m_AttributeName = 0x58;
                export const m_AttributeType = 0x60;
            }
            export namespace CMotionMatchingUpdateNode {
                export const m_dataSet = 0x58;
                export const m_metrics = 0x78;
                export const m_weights = 0x90;
                export const m_blendCurve = 0xEC;
                export const m_bGoalAssist = 0x109;
                export const m_flBlendTime = 0xF8;
                export const m_flSampleRate = 0xF4;
                export const m_bSearchEveryTick = 0xE0;
                export const m_flSearchInterval = 0xE4;
                export const m_bLockClipWhenWaning = 0xFC;
                export const m_bSearchWhenClipEnds = 0xE8;
                export const m_flGoalAssistDistance = 0x10C;
                export const m_flSelectionThreshold = 0x100;
                export const m_distanceScale_Damping = 0x118;
                export const m_flGoalAssistTolerance = 0x110;
                export const m_bEnableDistanceScaling = 0x140;
                export const m_bSearchWhenGoalChanges = 0xE9;
                export const m_flReselectionTimeWindow = 0x104;
                export const m_flDistanceScale_MaxScale = 0x138;
                export const m_flDistanceScale_MinScale = 0x13C;
                export const m_bEnableRotationCorrection = 0x108;
                export const m_flDistanceScale_InnerRadius = 0x134;
                export const m_flDistanceScale_OuterRadius = 0x130;
            }
            export namespace CMovementComponentUpdater {
                export const m_motors = 0x30;
                export const m_bNetworkPath = 0x71;
                export const m_paramHandles = 0x73;
                export const m_facingDamping = 0x48;
                export const m_bNetworkFacing = 0x72;
                export const m_bMoveVarsDisabled = 0x70;
                export const m_flDefaultRunSpeed = 0x6C;
                export const m_nDefaultMotorIndex = 0x68;
            }
            export namespace CMovementHandshakeAnimTag {

            }
            export namespace CNmGraphNode__CDefinition {
                export const m_nNodeIdx = 0x8;
            }
            export namespace CNmGraphVariationUserData {

            }
            export namespace CNmMaterialAttributeEvent {
                export const m_w = 0xF0;
                export const m_x = 0x30;
                export const m_y = 0x70;
                export const m_z = 0xB0;
                export const m_target = 0x18;
                export const m_attributeName = 0x20;
                export const m_attributeNameToken = 0x28;
            }
            export namespace CNmScaleNode__CDefinition {
                export const m_nMaskNodeIdx = 0x18;
                export const m_nEnableNodeIdx = 0x1A;
            }
            export namespace CNmStateNode__CDefinition {
                export const m_exitEvents = 0x58;
                export const m_bIsOffState = 0xAE;
                export const m_entryEvents = 0x18;
                export const m_executeEvents = 0x38;
                export const m_nChildNodeIdx = 0x10;
                export const m_timedElapsedEvents = 0x90;
                export const m_nLayerWeightNodeIdx = 0xA8;
                export const m_timedRemainingEvents = 0x78;
                export const m_nLayerBoneMaskNodeIdx = 0xAC;
                export const m_nLayerRootMotionWeightNodeIdx = 0xAA;
                export const m_bUseActualElapsedTimeInStateForTimedEvents = 0xAF;
            }
            export namespace CNmValueNode__CDefinition {

            }
            export namespace CPairedSequenceUpdateNode {
                export const m_sPairedSequenceRole = 0x78;
            }
            export namespace CParticleBindingRealPulse {

            }
            export namespace CPathAnimMotorUpdaterBase {
                export const m_bLockToPath = 0x20;
            }
            export namespace CPulseCell_Value_Gradient {
                export const m_Gradient = 0x48;
            }
            export namespace CStanceOverrideUpdateNode {
                export const m_eMode = 0x9C;
                export const m_hParameter = 0x98;
                export const m_footStanceInfo = 0x70;
                export const m_pStanceSourceNode = 0x88;
            }
            export namespace CStateMachineInstanceData {
                export const m_flTimeInState = 0x0;
                export const m_prevStateIndex = 0x10;
                export const m_currentTransitionIndex = 0x4;
                export const m_scheduledTransitionIndex = 0x14;
            }
            export namespace CTargetSelectorUpdateNode {
                export const m_children = 0x68;
                export const m_eAngleMode = 0x60;
                export const m_hTargetPosition = 0x84;
                export const m_bEnablePhaseMatching = 0x8E;
                export const m_hMoveHeadingParameter = 0x88;
                export const m_bTargetPositionIsWorldSpace = 0x8C;
                export const m_hDesiredMoveHeadingParameter = 0x8A;
                export const m_hTargetFacePositionParameter = 0x86;
                export const m_bTargetFacePositionIsWorldSpace = 0x8D;
                export const m_flPhaseMatchingMaxRootMotionSkip = 0x90;
            }
            export namespace CWayPointHelperUpdateNode {
                export const m_bOnlyGoals = 0x7C;
                export const m_flEndCycle = 0x78;
                export const m_flStartCycle = 0x74;
                export const m_bPreventOvershoot = 0x7D;
                export const m_bPreventUndershoot = 0x7E;
            }
            export namespace DynamicMeshDeformParams_t {
                export const m_flTensionStretchScale = 0x4;
                export const m_flTensionCompressScale = 0x0;
                export const m_bEnableEyeBulgeDeformation = 0xB;
                export const m_bSmoothNormalsAcrossUvSeams = 0xA;
                export const m_bRecomputeSmoothNormalsAfterAnimation = 0x8;
                export const m_bComputeDynamicMeshTensionAfterAnimation = 0x9;
            }
            export namespace NmBoneMaskSetDefinition_t {
                export const m_ID = 0x0;
                export const m_primaryWeightList = 0x8;
                export const m_secondaryWeightLists = 0x118;
            }
            export namespace OutflowWithRequirements_t {
                export const m_Connection = 0x0;
                export const m_RequirementNodeIDs = 0x50;
                export const m_DestinationFlowNodeID = 0x48;
                export const m_nCursorStateBlockIndex = 0x68;
            }
            export namespace PulseRuntimeInvokeIndex_t {
                export const m_Value = 0x0;
            }
            export namespace PulseRuntimeOutputIndex_t {
                export const m_Value = 0x0;
            }
            export namespace PulseRuntimeStateOffset_t {
                export const m_Value = 0x0;
            }
            export namespace SignatureOutflow_Continue {

            }
            export namespace AimCameraOpFixedSettings_t {
                export const m_propJoints = 0x18;
                export const m_nChainIndex = 0x0;
                export const m_nCameraJointIndex = 0x4;
                export const m_nPelvisJointIndex = 0x8;
                export const m_nClavicleLeftJointIndex = 0xC;
                export const m_nClavicleRightJointIndex = 0x10;
                export const m_nDepenetrationJointIndex = 0x14;
            }
            export namespace AimMatrixOpFixedSettings_t {
                export const m_damping = 0x80;
                export const m_attachment = 0x0;
                export const m_eBlendMode = 0xC0;
                export const m_flMaxYawAngle = 0xC4;
                export const m_nBoneMaskIndex = 0xD0;
                export const m_flMaxPitchAngle = 0xC8;
                export const m_bUseBiasAndClamp = 0xD5;
                export const m_poseCacheHandles = 0x98;
                export const m_bTargetIsPosition = 0xD4;
                export const m_nSequenceMaxFrame = 0xCC;
                export const m_biasAndClampBlendCurve = 0xE0;
                export const m_flBiasAndClampYawOffset = 0xD8;
                export const m_flBiasAndClampPitchOffset = 0xDC;
            }
            export namespace AnimationDecodeDebugDump_t {
                export const m_elems = 0x8;
                export const m_processingType = 0x0;
            }
            export namespace CCPPScriptComponentUpdater {
                export const m_scriptsToRun = 0x30;
            }
            export namespace CFootStepTriggerUpdateNode {
                export const m_triggers = 0x70;
                export const m_flTolerance = 0x8C;
            }
            export namespace CNmContactAudioActionVData {

            }
            export namespace CNmEntityAttributeIntEvent {
                export const m_nIntValue = 0x38;
            }
            export namespace CNmFootIKNode__CDefinition {
                export const m_blendMode = 0x34;
                export const m_nEnabledNodeIdx = 0x2C;
                export const m_flBlendTimeSeconds = 0x30;
                export const m_leftEffectorBoneID = 0x18;
                export const m_nLeftTargetNodeIdx = 0x28;
                export const m_nRightTargetNodeIdx = 0x2A;
                export const m_rightEffectorBoneID = 0x20;
                export const m_bIsTargetInWorldSpace = 0x35;
            }
            export namespace CNmStateNode__TimedEvent_t {
                export const m_ID = 0x0;
                export const m_flTimeValueSeconds = 0x8;
                export const m_comparisionOperator = 0xC;
            }
            export namespace COrientationWarpUpdateNode {
                export const m_eMode = 0x74;
                export const m_damping = 0x90;
                export const m_hTargetParam = 0x78;
                export const m_flTargetOffset = 0x84;
                export const m_eRootMotionSource = 0xA8;
                export const m_eTargetOffsetMode = 0x80;
                export const m_hTargetOffsetParam = 0x88;
                export const m_flMaxRootMotionScale = 0xAC;
                export const m_hTargetPositionParam = 0x7A;
                export const m_ePreferredRotationDirection = 0xB4;
                export const m_flPreferredRotationThreshold = 0xB8;
                export const m_hFallbackTargetPositionParam = 0x7C;
                export const m_bEnablePreferredRotationDirection = 0xB0;
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
            export namespace CSetParameterActionUpdater {
                export const m_value = 0x1A;
                export const m_hParam = 0x18;
            }
            export namespace FollowAttachmentSettings_t {
                export const m_boneIndex = 0x80;
                export const m_attachment = 0x0;
                export const m_bMatchRotation = 0x86;
                export const m_attachmentHandle = 0x84;
                export const m_bMatchTranslation = 0x85;
            }
            export namespace MotionMatchingInstanceData {
                export const m_currentSelection = 0x2C;
                export const m_previousSelection = 0x84;
            }
            export namespace ParticleNamedValueSource_t {
                export const m_Name = 0x0;
                export const m_IsPublic = 0x8;
                export const m_ValueType = 0x10;
                export const m_DefaultConfig = 0x28;
            }
            export namespace PulseNodeDynamicOutflows_t {
                export const m_Outflows = 0x0;
            }
            export namespace PulseRuntimeTempVarIndex_t {
                export const m_Value = 0x0;
            }
            export namespace PulseSelectorOutflowList_t {
                export const m_Outflows = 0x0;
            }
            export namespace CAnimScriptComponentUpdater {
                export const m_hScript = 0x30;
            }
            export namespace CCycleControlClipUpdateNode {
                export const m_tags = 0x60;
                export const m_duration = 0x80;
                export const m_hSequence = 0x7C;
                export const m_paramIndex = 0x88;
                export const m_valueSource = 0x84;
                export const m_bLockWhenWaning = 0x8A;
            }
            export namespace CDampedPathAnimMotorUpdater {
                export const m_flMinSpeedScale = 0x30;
                export const m_flSpringConstant = 0x38;
                export const m_flAnticipationTime = 0x2C;
                export const m_flMaxSpringTension = 0x40;
                export const m_flMinSpringTension = 0x3C;
                export const m_hAnticipationPosParam = 0x34;
                export const m_hAnticipationHeadingParam = 0x36;
            }
            export namespace CDirectPlaybackInstanceData {
                export const m_weights = 0x14;
                export const m_sequences = 0x24;
                export const m_flFadeInTime = 0x118;
                export const m_bResetPending = 0x130;
                export const m_flFadeOutTime = 0x11C;
                export const m_flForcedCycle = 0x120;
                export const m_flTargetFacing = 0xC;
                export const m_flInterpEndTime = 0x10;
                export const m_vTargetPosition = 0x0;
                export const m_currentSequenceData = 0x108;
                export const m_currentSequenceIndex = 0x104;
                export const m_SequenceCycleZeroTime = 0x138;
            }
            export namespace CDirectionalBlendUpdateNode {
                export const m_bLoop = 0xA8;
                export const m_damping = 0x80;
                export const m_duration = 0xA4;
                export const m_hSequences = 0x5C;
                export const m_paramIndex = 0x9C;
                export const m_playbackSpeed = 0xA0;
                export const m_blendValueSource = 0x98;
                export const m_bLockBlendOnReset = 0xA9;
            }
            export namespace CFollowAttachmentUpdateNode {
                export const m_opFixedData = 0x70;
            }
            export namespace CFootAdjustmentInstanceData {
                export const m_flDuration = 0x18;
                export const m_flStartTime = 0xC;
                export const m_flStartHeadingWS = 0x3C;
            }
            export namespace CModelConfigElement_Command {
                export const m_Args = 0x50;
                export const m_Command = 0x48;
            }
            export namespace CNmBlend1DNode__CDefinition {
                export const m_parameterization = 0x30;
            }
            export namespace CNmBlend2DNode__CDefinition {
                export const m_values = 0x28;
                export const m_indices = 0x80;
                export const m_hullIndices = 0xA8;
                export const m_bAllowLooping = 0xC4;
                export const m_sourceNodeIndices = 0x10;
                export const m_nInputParameterNodeIdx0 = 0xC0;
                export const m_nInputParameterNodeIdx1 = 0xC2;
            }
            export namespace CNmConstIDNode__CDefinition {
                export const m_value = 0x10;
            }
            export namespace CNmEntityAttributeEventBase {
                export const m_target = 0x18;
                export const m_attributeName = 0x20;
            }
            export namespace CNmIDEventNode__CDefinition {
                export const m_defaultValue = 0x18;
                export const m_eventConditionRules = 0x14;
                export const m_nSourceStateNodeIdx = 0x10;
            }
            export namespace CNmIDValueNode__CDefinition {

            }
            export namespace CNmSyncTrack__EventMarker_t {
                export const m_ID = 0x8;
                export const m_startTime = 0x0;
            }
            export namespace CParticleCollectionVecInput {

            }
            export namespace CPhysSurfacePropertiesAudio {
                export const m_reflectivity = 0x0;
                export const m_hardThreshold = 0x10;
                export const m_hardnessFactor = 0x4;
                export const m_roughThreshold = 0xC;
                export const m_roughnessFactor = 0x8;
                export const m_flOcclusionFactor = 0x1C;
                export const m_flStaticImpactVolume = 0x18;
                export const m_hardVelocityThreshold = 0x14;
            }
            export namespace CPulseCell_Inflow_GraphHook {
                export const m_HookName = 0x80;
            }
            export namespace CPulseGraphExecutionHistory {
                export const m_vecHistory = 0x10;
                export const m_mapCellDesc = 0x28;
                export const m_nInstanceID = 0x0;
                export const m_strFileName = 0x8;
                export const m_mapCursorDesc = 0x50;
            }
            export namespace CRemapValueComponentUpdater {
                export const m_items = 0x30;
            }
            export namespace CSlowDownOnSlopesUpdateNode {
                export const m_flSlowDownStrength = 0x70;
            }
            export namespace CWayPointHelperInstanceData {
                export const m_vMovement = 0x0;
                export const m_vRotation = 0xC;
                export const m_vWaypointPosWS = 0x18;
                export const m_bStopUpdatingWaypointPos = 0x24;
            }
            export namespace FootLockPoseOpFixedSettings {
                export const m_footInfo = 0x0;
                export const m_bApplyTilt = 0x38;
                export const m_ikSolverType = 0x34;
                export const m_bApplyHipDrop = 0x39;
                export const m_flMaxLegTwist = 0x48;
                export const m_nHipBoneIndex = 0x30;
                export const m_flLockBlendTime = 0x54;
                export const m_flMaxFootHeight = 0x40;
                export const m_flExtensionScale = 0x44;
                export const m_bEnableStretching = 0x58;
                export const m_flMaxStretchAmount = 0x5C;
                export const m_hipDampingSettings = 0x18;
                export const m_bEnableLockBreaking = 0x4C;
                export const m_bApplyLegTwistLimits = 0x3C;
                export const m_flLockBreakTolerance = 0x50;
                export const m_bAlwaysUseFallbackHinge = 0x3A;
                export const m_flStretchExtensionScale = 0x60;
                export const m_bApplyFootRotationLimits = 0x3B;
            }
            export namespace PulseRuntimeCallInfoIndex_t {
                export const m_Value = 0x0;
            }
            export namespace PulseRuntimeConstantIndex_t {
                export const m_Value = 0x0;
            }
            export namespace PulseRuntimeRegisterIndex_t {
                export const m_Value = 0x0;
            }
            export namespace VPhysXCollisionAttributes_t {
                export const m_InteractAs = 0x8;
                export const m_DetailLayers = 0x50;
                export const m_InteractWith = 0x20;
                export const m_CollisionGroup = 0x4;
                export const m_InteractExclude = 0x38;
                export const m_InteractAsStrings = 0x70;
                export const m_DetailLayerStrings = 0xB8;
                export const m_InteractWithStrings = 0x88;
                export const m_CollisionGroupString = 0x68;
                export const m_InteractExcludeStrings = 0xA0;
                export const m_nIncludeDetailLayerCount = 0x0;
            }
            export namespace CAnimParameterManagerUpdater {
                export const m_parameters = 0x18;
                export const m_autoResetMap = 0xA0;
                export const m_idToIndexMap = 0x30;
                export const m_indexToHandle = 0x70;
                export const m_nameToIndexMap = 0x50;
                export const m_autoResetParams = 0x88;
            }
            export namespace CAnimationGraphVisualizerPie {
                export const m_Color = 0x70;
                export const m_vWsEnd = 0x60;
                export const m_vWsStart = 0x50;
                export const m_vWsCenter = 0x40;
            }
            export namespace CBoneConstraintPoseSpaceBone {
                export const m_inputList = 0x60;
            }
            export namespace CBonePositionMetricEvaluator {
                export const m_nBoneIndex = 0x50;
            }
            export namespace CBoneVelocityMetricEvaluator {
                export const m_nBoneIndex = 0x50;
            }
            export namespace CDampedValueComponentUpdater {
                export const m_items = 0x30;
            }
            export namespace CFootPositionMetricEvaluator {
                export const m_footIndices = 0x50;
                export const m_bIgnoreSlope = 0x68;
            }
            export namespace CFutureFacingMetricEvaluator {
                export const m_flTime = 0x54;
                export const m_flDistance = 0x50;
            }
            export namespace CModelConfigElement_UserPick {
                export const m_Choices = 0x48;
            }
            export namespace CNmBoneMaskNode__CDefinition {
                export const m_boneMaskID = 0x10;
            }
            export namespace CNmCachedIDNode__CDefinition {
                export const m_mode = 0x14;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmEntityAttributeFloatEvent {
                export const m_FloatValue = 0x38;
            }
            export namespace CNmIDSwitchNode__CDefinition {
                export const m_trueValue = 0x20;
                export const m_falseValue = 0x18;
                export const m_nTrueValueNodeIdx = 0x12;
                export const m_nFalseValueNodeIdx = 0x14;
                export const m_nSwitchValueNodeIdx = 0x10;
            }
            export namespace CNmSelectorNode__CDefinition {
                export const m_optionNodeIndices = 0x10;
                export const m_conditionNodeIndices = 0x28;
            }
            export namespace CNmSkeleton__ContactConfig_t {
                export const m_ID = 0x0;
                export const m_nBoneIdx = 0x8;
                export const m_audioInfo = 0x20;
                export const m_flProbeMaxDist = 0x18;
                export const m_vBoneLocalProbeDir = 0xC;
            }
            export namespace CNmZeroPoseNode__CDefinition {

            }
            export namespace CPlayerInputAnimMotorUpdater {
                export const m_sampleTimes = 0x20;
                export const m_bUseAcceleration = 0x48;
                export const m_flSpringConstant = 0x3C;
                export const m_hAnticipationPosParam = 0x44;
                export const m_flAnticipationDistance = 0x40;
                export const m_hAnticipationHeadingParam = 0x46;
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
            export namespace CPulse_TempVarBankDefinition {
                export const m_TempVars = 0x0;
            }
            export namespace CVPhysXSurfacePropertiesList {
                export const m_surfacePropertiesList = 0x0;
            }
            export namespace FootPinningPoseOpFixedData_t {
                export const m_footInfo = 0x0;
                export const m_flBlendTime = 0x18;
                export const m_flMaxLegTwist = 0x20;
                export const m_nHipBoneIndex = 0x24;
                export const m_flLockBreakDistance = 0x1C;
                export const m_bApplyLegTwistLimits = 0x28;
                export const m_bApplyFootRotationLimits = 0x29;
            }
            export namespace ModelBoneFlexDriverControl_t {
                export const m_flMax = 0x18;
                export const m_flMin = 0x14;
                export const m_flexController = 0x8;
                export const m_nBoneComponent = 0x0;
                export const m_flexControllerToken = 0x10;
            }
            export namespace TargetSelectorInstanceData_t {
                export const m_currentIndex = 0x0;
                export const m_vMSRootMotionAnlyzerTarget = 0x1C;
            }
            export namespace CAnimationGraphVisualizerAxis {
                export const m_flAxisSize = 0x60;
                export const m_xWsTransform = 0x40;
            }
            export namespace CAnimationGraphVisualizerLine {
                export const m_Color = 0x60;
                export const m_vWsPositionEnd = 0x50;
                export const m_vWsPositionStart = 0x40;
            }
            export namespace CAnimationGraphVisualizerText {
                export const m_Text = 0x58;
                export const m_Color = 0x50;
                export const m_vWsPosition = 0x40;
            }
            export namespace CBoneConstraintPoseSpaceMorph {
                export const m_bClamp = 0x60;
                export const m_inputList = 0x48;
                export const m_sBoneName = 0x20;
                export const m_outputMorph = 0x30;
                export const m_sAttachmentName = 0x28;
            }
            export namespace CDemoSettingsComponentUpdater {
                export const m_settings = 0x30;
            }
            export namespace CDirectionalBlendInstanceData {
                export const m_flCycle = 0x14;
                export const m_resetCount = 0x40;
                export const m_dampedValue = 0x0;
                export const m_flPrevCycle = 0x18;
                export const m_flPlaybackRate = 0x1C;
                export const m_flCycleZeroTime = 0x28;
                export const m_resetCycleValue = 0x34;
            }
            export namespace CNmBodyGroupNode__CDefinition {
                export const m_event = 0x20;
                export const m_nEnabledNodeIdx = 0x18;
            }
            export namespace CNmBoolValueNode__CDefinition {

            }
            export namespace CNmConstBoolNode__CDefinition {
                export const m_bValue = 0x10;
            }
            export namespace CNmFloatEaseNode__CDefinition {
                export const m_easingOp = 0x1A;
                export const m_flEaseTime = 0x10;
                export const m_flStartValue = 0x14;
                export const m_bUseStartValue = 0x1B;
                export const m_nInputValueNodeIdx = 0x18;
            }
            export namespace CNmFloatMathNode__CDefinition {
                export const m_flValueB = 0x18;
                export const m_operator = 0x16;
                export const m_nInputValueNodeIdxA = 0x10;
                export const m_nInputValueNodeIdxB = 0x12;
                export const m_bReturnNegatedResult = 0x15;
                export const m_bReturnAbsoluteResult = 0x14;
            }
            export namespace CNmIDToFloatNode__CDefinition {
                export const m_IDs = 0x18;
                export const m_values = 0x48;
                export const m_defaultValue = 0x14;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmTwoBoneIKNode__CDefinition {
                export const m_blendMode = 0x28;
                export const m_effectorBoneID = 0x18;
                export const m_nEnabledNodeIdx = 0x22;
                export const m_flBlendTimeSeconds = 0x24;
                export const m_bIsTargetInWorldSpace = 0x29;
                export const m_flChainRotationWeight = 0x2C;
                export const m_nEffectorTargetNodeIdx = 0x20;
            }
            export namespace CParticleCollectionFloatInput {

            }
            export namespace CPhysSurfacePropertiesPhysics {
                export const m_density = 0x8;
                export const m_friction = 0x0;
                export const m_thickness = 0xC;
                export const m_elasticity = 0x4;
                export const m_softContactFrequency = 0x10;
                export const m_softContactDampingRatio = 0x14;
            }
            export namespace CPhysSurfacePropertiesVehicle {
                export const m_wheelDrag = 0x0;
                export const m_wheelFrictionScale = 0x4;
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
            export namespace CStateMachineComponentUpdater {
                export const m_stateMachine = 0x30;
            }
            export namespace CTimeRemainingMetricEvaluator {
                export const m_flMaxTimeRemaining = 0x54;
                export const m_flMinTimeRemaining = 0x5C;
                export const m_bMatchByTimeRemaining = 0x50;
                export const m_bFilterByTimeRemaining = 0x58;
            }
            export namespace CToggleComponentActionUpdater {
                export const m_bSetEnabled = 0x1C;
                export const m_componentID = 0x18;
            }
            export namespace DampedPathMotorInstanceData_t {
                export const m_bStopping = 0x24;
                export const m_vVelocity = 0x0;
                export const m_vAcceleration = 0xC;
            }
            export namespace FollowTargetOpFixedSettings_t {
                export const m_boneIndex = 0x0;
                export const m_bBoneTarget = 0x4;
                export const m_boneTargetIndex = 0x8;
                export const m_bWorldCoodinateTarget = 0xC;
                export const m_bMatchTargetOrientation = 0xD;
            }
            export namespace PulseRuntimeEntrypointIndex_t {
                export const m_Value = 0x0;
            }
            export namespace SkeletonAnimCapture_t__Bone_t {
                export const m_Name = 0x0;
                export const m_nParent = 0x30;
                export const m_BindPose = 0x10;
            }
            export namespace CBlockSelectionMetricEvaluator {

            }
            export namespace CFutureVelocityMetricEvaluator {
                export const m_eMode = 0x5C;
                export const m_flDistance = 0x50;
                export const m_flTargetSpeed = 0x58;
                export const m_flStoppingDistance = 0x54;
            }
            export namespace CModelConfigElement_RandomPick {
                export const m_Choices = 0x48;
                export const m_ChoiceWeights = 0x60;
            }
            export namespace CNmCachedBoolNode__CDefinition {
                export const m_mode = 0x14;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmConstFloatNode__CDefinition {
                export const m_flValue = 0x10;
            }
            export namespace CNmFloatClampNode__CDefinition {
                export const m_clampRange = 0x14;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmFloatCurveNode__CDefinition {
                export const m_curve = 0x18;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmFloatRemapNode__CDefinition {
                export const m_inputRange = 0x14;
                export const m_outputRange = 0x1C;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmFloatValueNode__CDefinition {

            }
            export namespace CNmFollowBoneNode__CDefinition {
                export const m_bone = 0x18;
                export const m_mode = 0x2A;
                export const m_nEnabledNodeIdx = 0x28;
                export const m_followTargetBone = 0x20;
            }
            export namespace CNmIDSelectorNode__CDefinition {
                export const m_values = 0x28;
                export const m_defaultValue = 0x58;
                export const m_conditionNodeIndices = 0x10;
            }
            export namespace CNmLayerBlendNode__CDefinition {
                export const m_nBaseNodeIdx = 0x10;
                export const m_layerDefinition = 0x18;
                export const m_bOnlySampleBaseRootMotion = 0x12;
            }
            export namespace CNmSpeedScaleNode__CDefinition {

            }
            export namespace CNmTargetInfoNode__CDefinition {
                export const m_infoType = 0x14;
                export const m_nInputValueNodeIdx = 0x10;
                export const m_bIsWorldSpaceTarget = 0x18;
            }
            export namespace CNmTargetWarpNode__CDefinition {
                export const m_samplingMode = 0x14;
                export const m_alignmentBoneID = 0x30;
                export const m_targetUpdateRule = 0x15;
                export const m_flMaxTangentLength = 0x1C;
                export const m_nTargetValueNodeIdx = 0x12;
                export const m_nClipReferenceNodeIdx = 0x10;
                export const m_bAlignWithTargetAtLastWarpEvent = 0x16;
                export const m_flLerpFallbackDistanceThreshold = 0x20;
                export const m_flTargetUpdateDistanceThreshold = 0x24;
                export const m_flSamplingPositionErrorThresholdSq = 0x18;
                export const m_flTargetUpdateAngleThresholdRadians = 0x28;
            }
            export namespace CNmTransitionNode__CDefinition {
                export const m_flDuration = 0x18;
                export const m_flTimeOffset = 0x20;
                export const m_rootMotionBlend = 0x2B;
                export const m_blendWeightEasing = 0x2A;
                export const m_transitionOptions = 0x24;
                export const m_nTargetStateNodeIdx = 0x10;
                export const m_targetSyncIDNodeIdx = 0x28;
                export const m_startBoneMaskNodeIdx = 0x16;
                export const m_nDurationOverrideNodeIdx = 0x12;
                export const m_timeOffsetOverrideNodeIdx = 0x14;
                export const m_boneMaskBlendInTimePercentage = 0x1C;
            }
            export namespace CNmVectorInfoNode__CDefinition {
                export const m_desiredInfo = 0x12;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CPulseCell_Inflow_EventHandler {
                export const m_EventName = 0x80;
            }
            export namespace CPulseCell_Outflow_CycleRandom {
                export const m_Outputs = 0x48;
            }
            export namespace CStepsRemainingMetricEvaluator {
                export const m_footIndices = 0x50;
                export const m_flMinStepsRemaining = 0x68;
            }
            export namespace PlayerInputMotorInstanceData_t {
                export const m_vVelocityWS = 0xC;
                export const m_vInputVectorWS = 0x0;
                export const m_vAccelerationWS = 0x18;
            }
            export namespace PulseRuntimeDomainValueIndex_t {
                export const m_Value = 0x0;
            }
            export namespace PulseRuntimeTempVarBankIndex_t {
                export const m_Value = 0x0;
            }
            export namespace SkeletonAnimCapture_t__Frame_t {
                export const m_Stamp = 0x4;
                export const m_flTime = 0x0;
                export const m_Transform = 0x20;
                export const m_bTeleport = 0x40;
                export const m_FeModelPos = 0x90;
                export const m_FeModelAnims = 0x78;
                export const m_SimStateBones = 0x60;
                export const m_CompositeBones = 0x48;
                export const m_FlexControllerWeights = 0xA8;
            }
            export namespace CAnimationGraphVisualizerSphere {
                export const m_Color = 0x54;
                export const m_flRadius = 0x50;
                export const m_vWsPosition = 0x40;
            }
            export namespace CCurrentVelocityMetricEvaluator {

            }
            export namespace CModelConfigElement_RandomColor {
                export const m_Gradient = 0x48;
            }
            export namespace CNmCachedFloatNode__CDefinition {
                export const m_mode = 0x14;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmChainLookatNode__CDefinition {
                export const m_chainWeights = 0x40;
                export const m_nChainLength = 0x70;
                export const m_nEnabledNodeIdx = 0x3A;
                export const m_endEffectorBoneID = 0x18;
                export const m_endEffectorOffset = 0x2C;
                export const m_flBlendTimeSeconds = 0x3C;
                export const m_nLookatTargetNodeIdx = 0x38;
                export const m_bIsTargetInWorldSpace = 0x71;
                export const m_endEffectorForwardAxis = 0x20;
            }
            export namespace CNmConstTargetNode__CDefinition {
                export const m_value = 0x10;
            }
            export namespace CNmConstVectorNode__CDefinition {
                export const m_value = 0x10;
            }
            export namespace CNmFloatRemapNode__RemapRange_t {
                export const m_flEnd = 0x4;
                export const m_flBegin = 0x0;
            }
            export namespace CNmFloatSpringNode__CDefinition {
                export const m_flHertz = 0x14;
                export const m_flStartValue = 0x10;
                export const m_bUseStartValue = 0x1E;
                export const m_flDampingRatio = 0x18;
                export const m_nInputValueNodeIdx = 0x1C;
            }
            export namespace CNmFloatSwitchNode__CDefinition {
                export const m_flTrueValue = 0x1C;
                export const m_flFalseValue = 0x18;
                export const m_nTrueValueNodeIdx = 0x12;
                export const m_nFalseValueNodeIdx = 0x14;
                export const m_nSwitchValueNodeIdx = 0x10;
            }
            export namespace CNmIsTargetSetNode__CDefinition {
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmPassthroughNode__CDefinition {
                export const m_nChildNodeIdx = 0x10;
            }
            export namespace CNmTargetPointNode__CDefinition {
                export const m_nInputValueNodeIdx = 0x10;
                export const m_bIsWorldSpaceTarget = 0x12;
            }
            export namespace CNmTargetValueNode__CDefinition {

            }
            export namespace CNmVectorValueNode__CDefinition {

            }
            export namespace CPairedSequenceComponentUpdater {

            }
            export namespace CPulseCell_Outflow_CycleOrdered {
                export const m_Outputs = 0x48;
            }
            export namespace SkeletonAnimCapture_t__Camera_t {
                export const m_flTime = 0x20;
                export const m_tmCamera = 0x0;
            }
            export namespace CModelConfigElement_SetBodygroup {
                export const m_nChoice = 0x50;
                export const m_GroupName = 0x48;
            }
            export namespace CNmCachedTargetNode__CDefinition {
                export const m_mode = 0x14;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmCachedVectorNode__CDefinition {
                export const m_mode = 0x14;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmClipSelectorNode__CDefinition {
                export const m_optionNodeIndices = 0x10;
                export const m_conditionNodeIndices = 0x28;
            }
            export namespace CNmExternalPoseNode__CDefinition {
                export const m_bShouldSampleRootMotion = 0x10;
            }
            export namespace CNmIDComparisonNode__CDefinition {
                export const m_comparison = 0x12;
                export const m_comparisionIDs = 0x18;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmSkeleton__SecondarySkeleton_t {
                export const m_skeleton = 0x8;
                export const m_attachToBoneID = 0x0;
            }
            export namespace CNmStateMachineNode__CDefinition {
                export const m_stateDefinitions = 0x10;
                export const m_nDefaultStateIndex = 0x130;
            }
            export namespace CNmTargetOffsetNode__CDefinition {
                export const m_rotationOffset = 0x20;
                export const m_translationOffset = 0x30;
                export const m_bIsBoneSpaceOffset = 0x12;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmVectorCreateNode__CDefinition {
                export const m_inputValueXNodeIdx = 0x12;
                export const m_inputValueYNodeIdx = 0x14;
                export const m_inputValueZNodeIdx = 0x16;
                export const m_inputVectorValueNodeIdx = 0x10;
            }
            export namespace CNmVectorNegateNode__CDefinition {
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CPhysSurfacePropertiesSoundNames {
                export const m_break = 0x30;
                export const m_strain = 0x38;
                export const m_pushOff = 0x48;
                export const m_rolling = 0x28;
                export const m_resonant = 0x58;
                export const m_skidStop = 0x50;
                export const m_impactHard = 0x8;
                export const m_impactSoft = 0x0;
                export const m_meleeImpact = 0x40;
                export const m_scrapeRough = 0x18;
                export const m_bulletImpact = 0x20;
                export const m_scrapeSmooth = 0x10;
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
            export namespace AnimationDecodeDebugDumpElement_t {
                export const m_decodeOps = 0x28;
                export const m_modelName = 0x8;
                export const m_poseParams = 0x10;
                export const m_internalOps = 0x40;
                export const m_decodedAnims = 0x58;
                export const m_nEntityIndex = 0x0;
            }
            export namespace CDistanceRemainingMetricEvaluator {
                export const m_flMaxDistance = 0x50;
                export const m_flMinDistance = 0x54;
                export const m_bFilterGoalDistance = 0x61;
                export const m_bFilterGoalOvershoot = 0x62;
                export const m_bFilterFixedMinDistance = 0x60;
                export const m_flMaxGoalOvershootScale = 0x5C;
                export const m_flStartGoalFilterDistance = 0x58;
            }
            export namespace CModelConfigElement_AttachedModel {
                export const m_hModel = 0x58;
                export const m_vOffset = 0x60;
                export const m_aAngOffset = 0x6C;
                export const m_EntityClass = 0x50;
                export const m_InstanceName = 0x48;
                export const m_AttachmentName = 0x78;
                export const m_AttachmentType = 0x88;
                export const m_bBoneMergeFlex = 0x8C;
                export const m_bUserSpecifiedColor = 0x8D;
                export const m_bCollideWithHierarchy = 0xA0;
                export const m_BodygroupOnOtherModels = 0x90;
                export const m_bCollideOutsideHierarchy = 0xA1;
                export const m_LocalAttachmentOffsetName = 0x80;
                export const m_MaterialGroupOnOtherModels = 0x98;
                export const m_bUserSpecifiedMaterialGroup = 0x8E;
            }
            export namespace CNmAnimationPoseNode__CDefinition {
                export const m_nDataSlotIdx = 0x12;
                export const m_bUseFramesAsInput = 0x20;
                export const m_flUserSpecifiedTime = 0x1C;
                export const m_inputTimeRemapRange = 0x14;
                export const m_nPoseTimeValueNodeIdx = 0x10;
            }
            export namespace CNmBoneMaskBlendNode__CDefinition {
                export const m_nSourceMaskNodeIdx = 0x10;
                export const m_nTargetMaskNodeIdx = 0x12;
                export const m_nBlendWeightValueNodeIdx = 0x14;
            }
            export namespace CNmBoneMaskValueNode__CDefinition {

            }
            export namespace CNmClipReferenceNode__CDefinition {

            }
            export namespace CNmDurationScaleNode__CDefinition {

            }
            export namespace CNmFloatSelectorNode__CDefinition {
                export const m_values = 0x28;
                export const m_easingOp = 0x50;
                export const m_flEaseTime = 0x4C;
                export const m_flDefaultValue = 0x48;
                export const m_conditionNodeIndices = 0x10;
            }
            export namespace CNmReferencePoseNode__CDefinition {

            }
            export namespace CNmTimeConditionNode__CDefinition {
                export const m_type = 0x18;
                export const m_operator = 0x19;
                export const m_flComparand = 0x14;
                export const m_nInputValueNodeIdx = 0x12;
                export const m_sourceStateNodeIdx = 0x10;
            }
            export namespace CNmVelocityBlendNode__CDefinition {

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
            export namespace NmFloatCurveCompressionSettings_t {
                export const m_range = 0x0;
                export const m_bIsStatic = 0x8;
            }
            export namespace ParticleNamedValueConfiguration_t {
                export const m_ConfigName = 0x0;
                export const m_ConfigValue = 0x8;
                export const m_iAttachType = 0x20;
                export const m_BoundValuePath = 0x18;
                export const m_strEntityScope = 0x28;
                export const m_strAttachmentName = 0x30;
            }
            export namespace PulseGraphExecutionHistoryEntry_t {
                export const childID = 0x30;
                export const tagName = 0x20;
                export const unFlags = 0x1C;
                export const seqPoint = 0x8;
                export const nCursorID = 0x0;
                export const nEditorID = 0x4;
                export const flExecTime = 0x18;
            }
            export namespace SolveIKChainPoseOpFixedSettings_t {
                export const m_ChainsToSolveData = 0x0;
            }
            export namespace CModelConfigElement_SetRenderColor {
                export const m_Color = 0x48;
            }
            export namespace CNmBoneMaskSwitchNode__CDefinition {
                export const m_nTrueValueNodeIdx = 0x12;
                export const m_bSwitchDynamically = 0x1C;
                export const m_flBlendTimeSeconds = 0x18;
                export const m_nFalseValueNodeIdx = 0x14;
                export const m_nSwitchValueNodeIdx = 0x10;
            }
            export namespace CNmFloatAngleMathNode__CDefinition {
                export const m_operation = 0x12;
                export const m_nInputValueNodeIdx = 0x10;
            }
            export namespace CNmSpeedScaleBaseNode__CDefinition {
                export const m_nInputValueNodeIdx = 0x18;
                export const m_flDefaultInputValue = 0x1C;
            }
            export namespace CNmTargetSelectorNode__CDefinition {
                export const m_alignmentBoneID = 0x38;
                export const m_parameterNodeIdx = 0x30;
                export const m_optionNodeIndices = 0x10;
                export const m_bIsWorldSpaceTarget = 0x33;
                export const m_bIgnoreInvalidOptions = 0x32;
                export const m_flPositionScoreWeight = 0x2C;
                export const m_flOrientationScoreWeight = 0x28;
            }
            export namespace CParticleCollectionBindingInstance {

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
            export namespace CNmFloatComparisonNode__CDefinition {
                export const m_flEpsilon = 0x18;
                export const m_comparison = 0x14;
                export const m_flComparisonValue = 0x1C;
                export const m_nInputValueNodeIdx = 0x10;
                export const m_nComparandValueNodeIdx = 0x12;
            }
            export namespace CNmFloatCurveEventNode__CDefinition {
                export const m_eventID = 0x10;
                export const m_flDefaultValue = 0x1C;
                export const m_nDefaultNodeIdx = 0x18;
                export const m_eventConditionRules = 0x20;
            }
            export namespace CNmFootstepEventIDNode__CDefinition {
                export const m_eventConditionRules = 0x14;
                export const m_nSourceStateNodeIdx = 0x10;
            }
            export namespace CNmIDBasedSelectorNode__CDefinition {
                export const m_optionIDs = 0x28;
                export const m_nFallbackNodeIdx = 0x5A;
                export const m_nParameterNodeIdx = 0x58;
                export const m_optionNodeIndices = 0x10;
                export const m_bIgnoreInvalidOptions = 0x5C;
            }
            export namespace CNmOrientationWarpNode__CDefinition {
                export const m_samplingMode = 0x18;
                export const m_alignmentMode = 0x17;
                export const m_bIsOffsetNode = 0x14;
                export const m_bWarpTranslation = 0x16;
                export const m_nTargetValueNodeIdx = 0x12;
                export const m_nClipReferenceNodeIdx = 0x10;
                export const m_bIsOffsetRelativeToCharacter = 0x15;
            }
            export namespace CNmReferencedGraphNode__CDefinition {
                export const m_nFallbackNodeIdx = 0x12;
                export const m_nReferencedGraphIdx = 0x10;
            }
            export namespace CParticleCollectionRendererVecInput {

            }
            export namespace SkeletonAnimCapture_t__FrameStamp_t {
                export const m_flTime = 0x0;
                export const m_flCurTime = 0xC;
                export const m_bPredicted = 0x9;
                export const m_flRealTime = 0x10;
                export const m_nTickCount = 0x18;
                export const m_nFrameCount = 0x14;
                export const m_bTeleportTick = 0x8;
                export const m_flEntitySimTime = 0x4;
            }
            export namespace CModelConfigElement_SetMaterialGroup {
                export const m_MaterialGroupName = 0x48;
            }
            export namespace CNmBoneMaskSelectorNode__CDefinition {
                export const m_maskNodeIndices = 0x18;
                export const m_parameterValues = 0x30;
                export const m_bSwitchDynamically = 0x14;
                export const m_defaultMaskNodeIdx = 0x10;
                export const m_flBlendTimeSeconds = 0x70;
                export const m_parameterValueNodeIdx = 0x12;
            }
            export namespace CNmCurrentSyncEventNode__CDefinition {
                export const m_infoType = 0x12;
                export const m_nSourceStateNodeIdx = 0x10;
            }
            export namespace CNmIDEventConditionNode__CDefinition {
                export const m_eventIDs = 0x18;
                export const m_eventConditionRules = 0x14;
                export const m_nSourceStateNodeIdx = 0x10;
            }
            export namespace CNmLayerBlendNode__LayerDefinition_t {
                export const m_blendMode = 0xB;
                export const m_bIgnoreEvents = 0x9;
                export const m_nInputNodeIdx = 0x0;
                export const m_bIsSynchronized = 0x8;
                export const m_nWeightValueNodeIdx = 0x2;
                export const m_bIsStateMachineLayer = 0xA;
                export const m_nBoneMaskValueNodeIdx = 0x4;
                export const m_nRootMotionWeightValueNodeIdx = 0x6;
            }
            export namespace CPulseCell_Timeline__TimelineEvent_t {
                export const m_EventOutflow = 0x8;
                export const m_flTimeFromPrevious = 0x0;
            }
            export namespace CPulseCell_WaitForCursorsWithTagBase {
                export const m_WaitComplete = 0xE0;
                export const m_nCursorsAllowedToWait = 0xD8;
            }
            export namespace PulseGraphExecutionHistoryNodeDesc_t {
                export const strCellDesc = 0x0;
                export const strBindingName = 0x10;
            }
            export namespace CBoneConstraintPoseSpaceBone__Input_t {
                export const m_inputValue = 0x0;
                export const m_outputTransformList = 0x10;
            }
            export namespace CNmIsExternalPoseSetNode__CDefinition {
                export const m_nExternalPoseNodeIdx = 0x10;
            }
            export namespace CParticleCollectionRendererFloatInput {

            }
            export namespace CAnimationGraphVisualizerPrimitiveBase {
                export const m_Type = 0x8;
                export const m_OwningAnimNodePaths = 0xC;
                export const m_nOwningAnimNodePathCount = 0x38;
            }
            export namespace CBoneConstraintPoseSpaceMorph__Input_t {
                export const m_inputValue = 0x0;
                export const m_outputWeightList = 0x10;
            }
            export namespace CNmClip__ModelSpaceSamplingChainLink_t {
                export const m_nBoneIdx = 0x0;
                export const m_nParentBoneIdx = 0x4;
                export const m_nParentChainLinkIdx = 0x8;
            }
            export namespace CNmControlParameterIDNode__CDefinition {

            }
            export namespace CNmCurrentSyncEventIDNode__CDefinition {
                export const m_nSourceStateNodeIdx = 0x10;
            }
            export namespace CNmFloatChannelData__ChannelSettings_t {
                export const m_range = 0x0;
                export const m_bIsStatic = 0x8;
            }
            export namespace CNmFootEventConditionNode__CDefinition {
                export const m_phaseCondition = 0x12;
                export const m_eventConditionRules = 0x14;
                export const m_nSourceStateNodeIdx = 0x10;
            }
            export namespace CNmGraphDefinition__ExternalPoseSlot_t {
                export const m_slotID = 0x8;
                export const m_nNodeIdx = 0x0;
            }
            export namespace CNmParameterizedBlendNode__CDefinition {
                export const m_bAllowLooping = 0x2A;
                export const m_sourceNodeIndices = 0x10;
                export const m_nInputParameterValueNodeIdx = 0x28;
            }
            export namespace CNmRootMotionOverrideNode__CDefinition {
                export const m_overrideFlags = 0x2C;
                export const m_enabledNodeIdx = 0x20;
                export const m_maxLinearVelocity = 0x24;
                export const m_maxAngularVelocityRadians = 0x28;
                export const m_linearVelocityLimitNodeIdx = 0x1C;
                export const m_angularVelocityLimitNodeIdx = 0x1E;
                export const m_desiredMovingVelocityNodeIdx = 0x18;
                export const m_desiredFacingDirectionNodeIdx = 0x1A;
            }
            export namespace CNmStateMachineNode__StateDefinition_t {
                export const m_nStateNodeIdx = 0x0;
                export const m_transitionDefinitions = 0x8;
                export const m_nEntryConditionNodeIdx = 0x2;
            }
            export namespace CNmTimeControlledClipNode__CDefinition {
                export const m_graphEvents = 0x18;
                export const m_nDataSlotIdx = 0x14;
                export const m_bSampleRootMotion = 0x12;
                export const m_nTimeValueNodeIdx = 0x16;
                export const m_nPlayInReverseValueNodeIdx = 0x10;
            }
            export namespace CNmVirtualParameterIDNode__CDefinition {
                export const m_nChildNodeIdx = 0x10;
            }
            export namespace CPulseCell_LimitCount__InstanceState_t {
                export const m_nCurrentCount = 0x0;
            }
            export namespace PulseGraphExecutionHistoryCursorDesc_t {
                export const nSpawnNodeID = 0x18;
                export const flLastReferenced = 0x20;
                export const nRetiredAtNodeID = 0x1C;
                export const nLastValidEntryIdx = 0x24;
                export const vecAncestorCursorIDs = 0x0;
                export const bWasAnObservableComputation = 0x28;
            }
            export namespace PulseRuntimeBlackboardReferenceIndex_t {
                export const m_Value = 0x0;
            }
            export namespace CCurrentRotationVelocityMetricEvaluator {

            }
            export namespace CNmFixedWeightBoneMaskNode__CDefinition {
                export const m_flBoneWeight = 0x10;
            }
            export namespace CNmGraphDefinition__ExternalGraphSlot_t {
                export const m_slotID = 0x8;
                export const m_nNodeIdx = 0x0;
            }
            export namespace CNmGraphEventConditionNode__CDefinition {
                export const m_conditions = 0x18;
                export const m_eventConditionRules = 0x14;
                export const m_nSourceStateNodeIdx = 0x10;
            }
            export namespace CNmGraphEventConditionNode__Condition_t {
                export const m_eventID = 0x0;
                export const m_eventTypeCondition = 0x8;
            }
            export namespace CNmIDBasedClipSelectorNode__CDefinition {
                export const m_optionIDs = 0x28;
                export const m_nFallbackNodeIdx = 0x5A;
                export const m_nParameterNodeIdx = 0x58;
                export const m_optionNodeIndices = 0x10;
                export const m_bIgnoreInvalidOptions = 0x5C;
            }
            export namespace CNmParameterizedBlendNode__BlendRange_t {
                export const m_nInputIdx0 = 0x0;
                export const m_nInputIdx1 = 0x2;
                export const m_parameterValueRange = 0x4;
            }
            export namespace CPulseCell_IntervalTimer__CursorState_t {
                export const m_EndTime = 0x4;
                export const m_StartTime = 0x0;
                export const m_flWaitInterval = 0x8;
                export const m_flWaitIntervalHigh = 0xC;
                export const m_bCompleteOnNextWake = 0x10;
            }
            export namespace CMaterialDrawDescriptor__RigidMeshPart_t {
                export const m_nBoneIndex = 0x2;
                export const m_nPrimitiveCount = 0x8;
                export const m_nRigidBLASIndex = 0x0;
                export const m_nStartIndexOffset = 0x4;
            }
            export namespace CNmControlParameterBoolNode__CDefinition {

            }
            export namespace CNmFloatRangeComparisonNode__CDefinition {
                export const m_range = 0x10;
                export const m_bIsInclusiveCheck = 0x1A;
                export const m_nInputValueNodeIdx = 0x18;
            }
            export namespace CNmVirtualParameterBoolNode__CDefinition {
                export const m_nChildNodeIdx = 0x10;
            }
            export namespace PermModelDataAnimatedMaterialAttribute_t {
                export const m_nNumChannels = 0x8;
                export const m_AttributeName = 0x0;
            }
            export namespace CNmControlParameterFloatNode__CDefinition {

            }
            export namespace CNmGraphDefinition__ReferencedGraphSlot_t {
                export const m_nNodeIdx = 0x0;
                export const m_dataSlotIdx = 0x2;
            }
            export namespace CNmParameterizedSelectorNode__CDefinition {
                export const m_optionWeights = 0x28;
                export const m_bHasWeightsSet = 0x3B;
                export const m_parameterNodeIdx = 0x38;
                export const m_optionNodeIndices = 0x10;
                export const m_bIgnoreInvalidOptions = 0x3A;
            }
            export namespace CNmVirtualParameterFloatNode__CDefinition {
                export const m_nChildNodeIdx = 0x10;
            }
            export namespace CPulseCell_IsRequirementValid__Criteria_t {
                export const m_bIsValid = 0x0;
            }
            export namespace CSceneObjectData__RTProxyDrawDescriptor_t {
                export const m_drawDesc = 0x8;
                export const m_nSrcDrawIndex = 0x4;
                export const m_fEmissiveFactor = 0x164;
                export const m_mWorldFromLocal = 0x128;
                export const m_nVertexAlbedoVB = 0x159;
                export const m_nVertexEmissiveVB = 0x15F;
                export const m_materialGroupToken = 0x0;
                export const m_nVertexAlbedoFormat = 0x158;
                export const m_nVertexAlbedoOffset = 0x15A;
                export const m_nVertexAlbedoStride = 0x15C;
                export const m_nVertexEmissiveFormat = 0x15E;
                export const m_nVertexEmissiveOffset = 0x160;
                export const m_nVertexEmissiveStride = 0x162;
            }
            export namespace CNmControlParameterTargetNode__CDefinition {

            }
            export namespace CNmControlParameterVectorNode__CDefinition {

            }
            export namespace CNmVirtualParameterTargetNode__CDefinition {
                export const m_nChildNodeIdx = 0x10;
            }
            export namespace CNmVirtualParameterVectorNode__CDefinition {
                export const m_nChildNodeIdx = 0x10;
            }
            export namespace CNmStateCompletedConditionNode__CDefinition {
                export const m_nSourceStateNodeIdx = 0x10;
                export const m_flTransitionDurationSeconds = 0x14;
                export const m_nTransitionDurationOverrideNodeIdx = 0x12;
            }
            export namespace CNmStateMachineNode__TransitionDefinition_t {
                export const m_bCanBeForced = 0x6;
                export const m_nTargetStateIdx = 0x0;
                export const m_nConditionNodeIdx = 0x2;
                export const m_nTransitionNodeIdx = 0x4;
            }
            export namespace CNmSyncEventIndexConditionNode__CDefinition {
                export const m_triggerMode = 0x12;
                export const m_syncEventIdx = 0x14;
                export const m_nSourceStateNodeIdx = 0x10;
            }
            export namespace CNmVelocityBasedSpeedScaleNode__CDefinition {

            }
            export namespace CNmIDEventPercentageThroughNode__CDefinition {
                export const m_eventID = 0x18;
                export const m_eventConditionRules = 0x14;
                export const m_nSourceStateNodeIdx = 0x10;
            }
            export namespace CNmTransitionEventConditionNode__CDefinition {
                export const m_requireRuleID = 0x10;
                export const m_ruleCondition = 0x1E;
                export const m_eventConditionRules = 0x18;
                export const m_nSourceStateNodeIdx = 0x1C;
            }
            export namespace CNmVirtualParameterBoneMaskNode__CDefinition {
                export const m_nChildNodeIdx = 0x10;
            }
            export namespace CPulseCell_Inflow_ObservableVariableListener {
                export const m_bSelfReference = 0x82;
                export const m_nBlackboardReference = 0x80;
            }
            export namespace NmCompressionSettings_t__QuantizationRange_t {
                export const m_flRangeStart = 0x0;
                export const m_flRangeLength = 0x4;
            }
            export namespace PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                export const m_OutflowID = 0x0;
                export const m_Connection = 0x8;
            }
            export namespace CNmIsExternalGraphSlotFilledNode__CDefinition {
                export const m_nExternalGraphNodeIdx = 0x10;
            }
            export namespace CNmIsInactiveBranchConditionNode__CDefinition {

            }
            export namespace CNmParameterizedBlendNode__Parameterization_t {
                export const m_blendRanges = 0x0;
                export const m_parameterRange = 0x48;
            }
            export namespace CNmParameterizedClipSelectorNode__CDefinition {
                export const m_optionWeights = 0x28;
                export const m_bHasWeightsSet = 0x3B;
                export const m_parameterNodeIdx = 0x38;
                export const m_optionNodeIndices = 0x10;
                export const m_bIgnoreInvalidOptions = 0x3A;
            }
            export namespace CModelConfigElement_SetBodygroupOnAttachedModels {
                export const m_nChoice = 0x50;
                export const m_GroupName = 0x48;
            }
            export namespace CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                export const m_nNextIndex = 0x0;
            }
            export namespace CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                export const m_Shuffle = 0x0;
                export const m_nNextShuffle = 0x20;
            }
            export namespace CNmFootstepEventPercentageThroughNode__CDefinition {
                export const m_phaseCondition = 0x12;
                export const m_eventConditionRules = 0x14;
                export const m_nSourceStateNodeIdx = 0x10;
            }
            export namespace CModelConfigElement_SetMaterialGroupOnAttachedModels {
                export const m_MaterialGroupName = 0x48;
            }
            export namespace SeqCmd_t {
                export const SeqCmd_Add = 0x4;
                export const SeqCmd_Nop = 0x0;
                export const SeqCmd_Copy = 0x7;
                export const SeqCmd_Blend = 0x8;
                export const SeqCmd_Scale = 0x6;
                export const SeqCmd_Slerp = 0x3;
                export const SeqCmd_Sequence = 0xA;
                export const SeqCmd_Subtract = 0x5;
                export const SeqCmd_Transform = 0x10;
                export const SeqCmd_FetchCycle = 0xB;
                export const SeqCmd_FetchFrame = 0xC;
                export const SeqCmd_Worldspace = 0x9;
                export const SeqCmd_LinearDelta = 0x1;
                export const SeqCmd_IKRestoreAll = 0xE;
                export const SeqCmd_IKLockInPlace = 0xD;
                export const SeqCmd_FetchFrameRange = 0x2;
                export const SeqCmd_ReverseSequence = 0xF;
            }
            export namespace StepPhase {
                export const StepPhase_InAir = 0x1;
                export const StepPhase_OnGround = 0x0;
            }
            export namespace FacingMode {
                export const FacingMode_Path = 0x2;
                export const FacingMode_Manual = 0x1;
                export const FacingMode_Invalid = 0x0;
                export const FacingMode_LookTarget = 0x3;
                export const FacingMode_ManualPosition = 0x4;
            }
            export namespace MoodType_t {
                export const eMoodType_Body = 0x1;
                export const eMoodType_Head = 0x0;
            }
            export namespace PoseType_t {
                export const POSETYPE_STATIC = 0x0;
                export const POSETYPE_DYNAMIC = 0x1;
                export const POSETYPE_INVALID = 0xFF;
            }
            export namespace Blend2DMode {
                export const Blend2DMode_General = 0x0;
                export const Blend2DMode_Directional = 0x1;
            }
            export namespace BlendKeyType {
                export const BlendKey_Distance = 0x2;
                export const BlendKey_Velocity = 0x1;
                export const BlendKey_UserValue = 0x0;
                export const BlendKey_RemainingDistance = 0x3;
            }
            export namespace ChoiceMethod {
                export const Iterate = 0x2;
                export const IterateRandom = 0x3;
                export const WeightedRandom = 0x0;
                export const WeightedRandomNoRepeat = 0x1;
            }
            export namespace FlexOpCode_t {
                export const FLEX_OP_ABS = 0x1A;
                export const FLEX_OP_ADD = 0x4;
                export const FLEX_OP_COS = 0x19;
                export const FLEX_OP_DIV = 0x7;
                export const FLEX_OP_EXP = 0x9;
                export const FLEX_OP_MAX = 0xD;
                export const FLEX_OP_MIN = 0xE;
                export const FLEX_OP_MUL = 0x6;
                export const FLEX_OP_NEG = 0x8;
                export const FLEX_OP_SIN = 0x18;
                export const FLEX_OP_SUB = 0x5;
                export const FLEX_OP_NWAY = 0x11;
                export const FLEX_OP_OPEN = 0xA;
                export const FLEX_OP_SQRT = 0x16;
                export const FLEX_OP_CLOSE = 0xB;
                export const FLEX_OP_COMBO = 0x12;
                export const FLEX_OP_COMMA = 0xC;
                export const FLEX_OP_CONST = 0x1;
                export const FLEX_OP_2WAY_0 = 0xF;
                export const FLEX_OP_2WAY_1 = 0x10;
                export const FLEX_OP_FETCH1 = 0x2;
                export const FLEX_OP_FETCH2 = 0x3;
                export const FLEX_OP_DOMINATE = 0x13;
                export const FLEX_OP_REMAPVALCLAMPED = 0x17;
                export const FLEX_OP_DME_LOWER_EYELID = 0x14;
                export const FLEX_OP_DME_UPPER_EYELID = 0x15;
            }
            export namespace IKSolverType {
                export const IKSOLVER_CCD = 0x4;
                export const IKSOLVER_COUNT = 0x5;
                export const IKSOLVER_Fabrik = 0x2;
                export const IKSOLVER_Perlin = 0x0;
                export const IKSOLVER_TwoBone = 0x1;
                export const IKSOLVER_DogLeg3Bone = 0x3;
            }
            export namespace IkTargetType {
                export const IkTarget_Bone = 0x1;
                export const IkTarget_Attachment = 0x0;
                export const IkTarget_Parameter_ModelSpace = 0x2;
                export const IkTarget_Parameter_WorldSpace = 0x3;
            }
            export namespace IKChannelMode {
                export const OneBone = 0x2;
                export const TwoBone = 0x0;
                export const OneBone_Translate = 0x3;
                export const TwoBone_Translate = 0x1;
            }
            export namespace NmFootPhase_t {
                export const _None = 0x4;
                export const LeftFootDown = 0x0;
                export const RightFootDown = 0x2;
                export const LeftFootPassing = 0x3;
                export const RightFootPassing = 0x1;
            }
            export namespace PFNoiseType_t {
                export const PF_NOISE_TYPE_CURL = 0x3;
                export const PF_NOISE_TYPE_PERLIN = 0x0;
                export const PF_NOISE_TYPE_WORLEY = 0x2;
                export const PF_NOISE_TYPE_SIMPLEX = 0x1;
            }
            export namespace AnimScriptType {
                export const ANIMSCRIPT_FUSE_GENERAL = 0x0;
                export const ANIMSCRIPT_TYPE_INVALID = -0x1;
                export const ANIMSCRIPT_FUSE_STATEMACHINE = 0x1;
            }
            export namespace IKTargetSource {
                export const IKTARGETSOURCE_Bone = 0x0;
                export const IKTARGETSOURCE_COUNT = 0x2;
                export const IKTARGETSOURCE_AnimgraphParameter = 0x1;
            }
            export namespace AnimParamType_t {
                export const ANIMPARAM_INT = 0x3;
                export const ANIMPARAM_BOOL = 0x1;
                export const ANIMPARAM_ENUM = 0x2;
                export const ANIMPARAM_COUNT = 0x8;
                export const ANIMPARAM_FLOAT = 0x4;
                export const ANIMPARAM_VECTOR = 0x5;
                export const ANIMPARAM_UNKNOWN = 0x0;
                export const ANIMPARAM_QUATERNION = 0x6;
                export const ANIMPARAM_GLOBALSYMBOL = 0x7;
            }
            export namespace AnimValueSource {
                export const SlopeYaw = 0x14;
                export const LookPitch = 0x7;
                export const MoveSpeed = 0x1;
                export const Parameter = 0x9;
                export const SlopeAngle = 0x12;
                export const SlopePitch = 0x13;
                export const LookHeading = 0x5;
                export const MoveHeading = 0x0;
                export const StrafeSpeed = 0x3;
                export const ForwardSpeed = 0x2;
                export const GoalDistance = 0x15;
                export const LookDistance = 0x8;
                export const MaxMoveSpeed = 0x1B;
                export const SlopeHeading = 0x11;
                export const FacingHeading = 0x4;
                export const BoundaryRadius = 0xC;
                export const FingerCurl_Ring = 0x1F;
                export const RootMotionSpeed = 0x18;
                export const TargetMoveSpeed = 0xE;
                export const WayPointHeading = 0xA;
                export const FingerCurl_Index = 0x1D;
                export const FingerCurl_Pinky = 0x20;
                export const FingerCurl_Thumb = 0x1C;
                export const WayPointDistance = 0xB;
                export const AccelerationSpeed = 0x10;
                export const FingerCurl_Middle = 0x1E;
                export const TargetMoveHeading = 0xD;
                export const AccelerationHeading = 0xF;
                export const RootMotionTurnSpeed = 0x19;
                export const AccelerationFrontBack = 0x17;
                export const AccelerationLeftRight = 0x16;
                export const LookHeadingNormalized = 0x6;
                export const FingerSplay_Ring_Pinky = 0x24;
                export const FingerSplay_Middle_Ring = 0x23;
                export const FingerSplay_Thumb_Index = 0x21;
                export const FingerSplay_Index_Middle = 0x22;
                export const MoveHeadingRelativeToLookHeading = 0x1A;
            }
            export namespace AnimationType_t {
                export const ANIMATION_TYPE_FIXED_RATE = 0x0;
                export const ANIMATION_TYPE_FIT_LIFETIME = 0x1;
                export const ANIMATION_TYPE_MANUAL_FRAMES = 0x2;
            }
            export namespace NmIKBlendMode_t {
                export const Pose = 0x1;
                export const Effector = 0x0;
            }
            export namespace TagActionStatus {
                export const Fired = 0x2;
                export const Active = 0x1;
                export const Inactive = 0x0;
            }
            export namespace AnimVectorSource {
                export const LookTarget = 0x8;
                export const SlopeNormal = 0x6;
                export const Acceleration = 0x5;
                export const GoalPosition = 0xB;
                export const LookDirection = 0x2;
                export const MoveDirection = 0x0;
                export const FacingPosition = 0x1;
                export const VectorParameter = 0x3;
                export const WayPointPosition = 0xA;
                export const WayPointDirection = 0x4;
                export const RootMotionVelocity = 0xC;
                export const LookTarget_WorldSpace = 0x9;
                export const SlopeNormal_WorldSpace = 0x7;
                export const ManualTarget_WorldSpace = 0xD;
            }
            export namespace BinaryNodeTiming {
                export const UseChild1 = 0x0;
                export const UseChild2 = 0x1;
                export const SyncChildren = 0x2;
            }
            export namespace PulseValueType_t {
                export const PVAL_INT = 0x1;
                export const PVAL_BOOL = 0x0;
                export const PVAL_VEC2 = 0x4;
                export const PVAL_VEC3 = 0x5;
                export const PVAL_VEC4 = 0x8;
                export const PVAL_VOID = -0x1;
                export const PVAL_ARRAY = 0x1C;
                export const PVAL_COUNT = 0x21;
                export const PVAL_FLOAT = 0x2;
                export const PVAL_QANGLE = 0x6;
                export const PVAL_STRING = 0x3;
                export const PVAL_EHANDLE = 0xD;
                export const PVAL_UNKNOWN = 0x18;
                export const PVAL_VARIANT = 0x17;
                export const PVAL_GAMETIME = 0xC;
                export const PVAL_RESOURCE = 0xE;
                export const PVAL_COLOR_RGB = 0xB;
                export const PVAL_TRANSFORM = 0x9;
                export const PVAL_CURSOR_FLOW = 0x16;
                export const PVAL_ENTITY_NAME = 0x12;
                export const PVAL_SCHEMA_ENUM = 0x19;
                export const PVAL_SNDEVT_GUID = 0x10;
                export const PVAL_SNDEVT_NAME = 0x11;
                export const PVAL_TEST_HANDLE = 0x1B;
                export const PVAL_TYPESAFE_INT = 0x14;
                export const PVAL_VDATA_CHOICE = 0x20;
                export const PVAL_ANIM_SEQUENCE = 0x1F;
                export const PVAL_OPAQUE_HANDLE = 0x13;
                export const PVAL_RESOURCE_NAME = 0xF;
                export const PVAL_TYPESAFE_INT64 = 0x1D;
                export const PVAL_VEC3_WORLDSPACE = 0x7;
                export const PVAL_PARTICLE_EHANDLE = 0x1E;
                export const PVAL_MODEL_MATERIAL_GROUP = 0x15;
                export const PVAL_TRANSFORM_WORLDSPACE = 0xA;
                export const PVAL_PANORAMA_PANEL_HANDLE = 0x1A;
            }
            export namespace ResetCycleOption {
                export const Beginning = 0x0;
                export const FixedValue = 0x3;
                export const SameTimeAsSource = 0x4;
                export const SameCycleAsSource = 0x1;
                export const InverseSourceCycle = 0x2;
            }
            export namespace ScriptedMoveTo_t {
                export const eWait = 0x0;
                export const eTeleport = 0x4;
                export const eWaitFacing = 0x5;
                export const eMoveWithGait = 0x3;
                export const eObsoleteBackCompat1 = 0x1;
                export const eObsoleteBackCompat2 = 0x2;
            }
            export namespace SeqPoseSetting_t {
                export const SEQ_POSE_SETTING_CONSTANT = 0x0;
                export const SEQ_POSE_SETTING_POSITION = 0x2;
                export const SEQ_POSE_SETTING_ROTATION = 0x1;
                export const SEQ_POSE_SETTING_VELOCITY = 0x3;
            }
            export namespace AnimParamButton_t {
                export const ANIMPARAM_BUTTON_A = 0x5;
                export const ANIMPARAM_BUTTON_B = 0x6;
                export const ANIMPARAM_BUTTON_X = 0x7;
                export const ANIMPARAM_BUTTON_Y = 0x8;
                export const ANIMPARAM_BUTTON_NONE = 0x0;
                export const ANIMPARAM_BUTTON_DPAD_UP = 0x1;
                export const ANIMPARAM_BUTTON_LTRIGGER = 0xB;
                export const ANIMPARAM_BUTTON_RTRIGGER = 0xC;
                export const ANIMPARAM_BUTTON_DPAD_DOWN = 0x3;
                export const ANIMPARAM_BUTTON_DPAD_LEFT = 0x4;
                export const ANIMPARAM_BUTTON_DPAD_RIGHT = 0x2;
                export const ANIMPARAM_BUTTON_LEFT_SHOULDER = 0x9;
                export const ANIMPARAM_BUTTON_RIGHT_SHOULDER = 0xA;
            }
            export namespace ChoiceBlendMethod {
                export const SingleBlendTime = 0x0;
                export const PerChoiceBlendTimes = 0x1;
            }
            export namespace FootFallTagFoot_t {
                export const FOOT1 = 0x0;
                export const FOOT2 = 0x1;
                export const FOOT3 = 0x2;
                export const FOOT4 = 0x3;
                export const FOOT5 = 0x4;
                export const FOOT6 = 0x5;
                export const FOOT7 = 0x6;
                export const FOOT8 = 0x7;
            }
            export namespace IkEndEffectorType {
                export const IkEndEffector_Bone = 0x1;
                export const IkEndEffector_Attachment = 0x0;
            }
            export namespace MorphBundleType_t {
                export const MORPH_BUNDLE_TYPE_NONE = 0x0;
                export const MORPH_BUNDLE_TYPE_COUNT = 0x3;
                export const MORPH_BUNDLE_TYPE_NORMAL_WRINKLE = 0x2;
                export const MORPH_BUNDLE_TYPE_POSITION_SPEED = 0x1;
            }
            export namespace NmPoseBlendMode_t {
                export const Overlay = 0x0;
                export const Additive = 0x1;
                export const ModelSpace = 0x2;
            }
            export namespace PFNoiseModifier_t {
                export const PF_NOISE_MODIFIER_NONE = 0x0;
                export const PF_NOISE_MODIFIER_LINES = 0x1;
                export const PF_NOISE_MODIFIER_RINGS = 0x3;
                export const PF_NOISE_MODIFIER_CLUMPS = 0x2;
            }
            export namespace ParticleVecType_t {
                export const PVEC_TYPE_COUNT = 0x13;
                export const PVEC_TYPE_INVALID = -0x1;
                export const PVEC_TYPE_LITERAL = 0x0;
                export const PVEC_TYPE_CP_DELTA = 0x11;
                export const PVEC_TYPE_CP_VALUE = 0x7;
                export const PVEC_TYPE_NAMED_VALUE = 0x2;
                export const PVEC_TYPE_LITERAL_COLOR = 0x1;
                export const PVEC_TYPE_RANDOM_UNIFORM = 0xF;
                export const PVEC_TYPE_CP_RELATIVE_DIR = 0x9;
                export const PVEC_TYPE_PARTICLE_VECTOR = 0x3;
                export const PVEC_TYPE_FLOAT_COMPONENTS = 0xB;
                export const PVEC_TYPE_PARTICLE_GRAVITY = 0x6;
                export const PVEC_TYPE_FLOAT_INTERP_OPEN = 0xD;
                export const PVEC_TYPE_PARTICLE_VELOCITY = 0x5;
                export const PVEC_TYPE_CP_RELATIVE_POSITION = 0x8;
                export const PVEC_TYPE_FLOAT_INTERP_CLAMPED = 0xC;
                export const PVEC_TYPE_FLOAT_INTERP_GRADIENT = 0xE;
                export const PVEC_TYPE_RANDOM_UNIFORM_OFFSET = 0x10;
                export const PVEC_TYPE_CP_RELATIVE_RANDOM_DIR = 0xA;
                export const PVEC_TYPE_CLOSEST_CAMERA_POSITION = 0x12;
                export const PVEC_TYPE_PARTICLE_INITIAL_VECTOR = 0x4;
            }
            export namespace PulseApiFeature_t {
                export const AF_NONE = 0x0;
                export const AF_ENTITIES = 0x1;
                export const AF_PANORAMA = 0x2;
                export const AF_PARTICLES = 0x8;
                export const AF_FAKE_ENTITIES = 0x10;
                export const AF_SELECTORS_WITHOUT_REQUIREMENTS = 0x20;
            }
            export namespace AimMatrixBlendMode {
                export const AimMatrixBlendMode_None = 0x0;
                export const AimMatrixBlendMode_Additive = 0x1;
                export const AimMatrixBlendMode_BoneMask = 0x3;
                export const AimMatrixBlendMode_ModelSpaceAdditive = 0x2;
            }
            export namespace BoneMaskBlendSpace {
                export const BlendSpace_Model = 0x1;
                export const BlendSpace_Parent = 0x0;
                export const BlendSpace_Model_RotationOnly = 0x2;
                export const BlendSpace_Model_TranslationOnly = 0x3;
            }
            export namespace ChoiceChangeMethod {
                export const OnReset = 0x0;
                export const OnCycleEnd = 0x1;
                export const OnResetOrCycleEnd = 0x2;
            }
            export namespace FieldNetworkOption {
                export const Auto = 0x0;
                export const ForceEnable = 0x1;
                export const ForceDisable = 0x2;
            }
            export namespace HandshakeTagType_t {
                export const eTask = 0x0;
                export const eCount = 0x2;
                export const eInvalid = -0x1;
                export const eMovement = 0x1;
            }
            export namespace JiggleBoneSimSpace {
                export const SimSpace_Local = 0x0;
                export const SimSpace_Model = 0x1;
                export const SimSpace_World = 0x2;
            }
            export namespace NmEasingFunction_t {
                export const Back = 0x8;
                export const Circ = 0x7;
                export const Expo = 0x6;
                export const Quad = 0x1;
                export const Sine = 0x5;
                export const Cubic = 0x2;
                export const Quart = 0x3;
                export const Quint = 0x4;
                export const Linear = 0x0;
            }
            export namespace NmFollowBoneMode_t {
                export const RotationOnly = 0x1;
                export const TranslationOnly = 0x2;
                export const RotationAndTranslation = 0x0;
            }
            export namespace NmGraphDebugMode_t {
                export const On = 0x1;
                export const Off = 0x0;
            }
            export namespace NmGraphValueType_t {
                export const ID = 0x2;
                export const Bool = 0x1;
                export const Pose = 0x7;
                export const Float = 0x3;
                export const Target = 0x5;
                export const Vector = 0x4;
                export const Special = 0x8;
                export const Unknown = 0x0;
                export const BoneMask = 0x6;
            }
            export namespace NmTargetWarpRule_t {
                export const WarpZ = 0x1;
                export const WarpXY = 0x0;
                export const WarpXYZ = 0x2;
                export const FixedSection = 0x4;
                export const RotationOnly = 0x3;
            }
            export namespace NmTransitionRule_t {
                export const AllowTransition = 0x0;
                export const BlockTransition = 0x2;
                export const ConditionallyAllowTransition = 0x1;
            }
            export namespace RagdollPoseControl {
                export const Absolute = 0x0;
            }
            export namespace StanceOverrideMode {
                export const Node = 0x1;
                export const Sequence = 0x0;
            }
            export namespace VelocityMetricMode {
                export const DirectionOnly = 0x0;
                export const MagnitudeOnly = 0x1;
                export const DirectionAndMagnitude = 0x2;
            }
            export namespace AnimNodeNetworkMode {
                export const ClientSimulate = 0x1;
                export const ServerAuthoritative = 0x0;
            }
            export namespace CNmEventRelevance_t {
                export const ClientOnly = 0x0;
                export const ServerOnly = 0x1;
                export const ClientAndServer = 0x2;
            }
            export namespace FootstepJumpPhase_t {
                export const Jumping = 0x2;
                export const Landing = 0x4;
                export const Unknown = 0x0;
                export const NotJumping = 0x1;
            }
            export namespace HandshakeTagState_t {
                export const eActive = 0x1;
                export const eInactive = 0x0;
                export const eMomentarilyInactive = 0x2;
            }
            export namespace NmCachedValueMode_t {
                export const OnExit = 0x1;
                export const OnEntry = 0x0;
            }
            export namespace NmEasingOperation_t {
                export const _None = 0x16;
                export const InCirc = 0x13;
                export const InExpo = 0x10;
                export const InQuad = 0x1;
                export const InSine = 0xD;
                export const Linear = 0x0;
                export const InCubic = 0x4;
                export const InQuart = 0x7;
                export const InQuint = 0xA;
                export const OutCirc = 0x14;
                export const OutExpo = 0x11;
                export const OutQuad = 0x2;
                export const OutSine = 0xE;
                export const OutCubic = 0x5;
                export const OutQuart = 0x8;
                export const OutQuint = 0xB;
                export const InOutCirc = 0x15;
                export const InOutExpo = 0x12;
                export const InOutQuad = 0x3;
                export const InOutSine = 0xF;
                export const InOutCubic = 0x6;
                export const InOutQuart = 0x9;
                export const InOutQuint = 0xC;
            }
            export namespace PFNoiseTurbulence_t {
                export const PF_NOISE_TURB_NONE = 0x0;
                export const PF_NOISE_TURB_LOOPY = 0x3;
                export const PF_NOISE_TURB_CONTRAST = 0x4;
                export const PF_NOISE_TURB_FEEDBACK = 0x2;
                export const PF_NOISE_TURB_ALTERNATE = 0x5;
                export const PF_NOISE_TURB_HIGHLIGHT = 0x1;
            }
            export namespace ParticleFloatType_t {
                export const PF_TYPE_COUNT = 0x20;
                export const PF_TYPE_INVALID = -0x1;
                export const PF_TYPE_LITERAL = 0x0;
                export const PF_TYPE_ENDCAP_AGE = 0x5;
                export const PF_TYPE_NAMED_VALUE = 0x1;
                export const PF_TYPE_PARTICLE_AGE = 0x13;
                export const PF_TYPE_RANDOM_BIASED = 0x3;
                export const PF_TYPE_COLLECTION_AGE = 0x4;
                export const PF_TYPE_PARTICLE_FLOAT = 0x15;
                export const PF_TYPE_PARTICLE_NOISE = 0x12;
                export const PF_TYPE_PARTICLE_SPEED = 0x19;
                export const PF_TYPE_RANDOM_UNIFORM = 0x2;
                export const PF_TYPE_SNAPSHOT_COUNT = 0xD;
                export const PF_TYPE_PARTICLE_NUMBER = 0x1A;
                export const PF_TYPE_SNAPSHOT_CHANGED = 0xE;
                export const PF_TYPE_CONTROL_POINT_SPEED = 0x8;
                export const PF_TYPE_CONCURRENT_DEF_COUNT = 0xB;
                export const PF_TYPE_CONTROL_POINT_IS_SET = 0xF;
                export const PF_TYPE_PARTICLE_DETAIL_LEVEL = 0xA;
                export const PF_TYPE_PARTICLE_ROPE_SEGMENT = 0x1C;
                export const PF_TYPE_CONTROL_POINT_DISTANCE = 0x9;
                export const PF_TYPE_PARTICLE_INITIAL_FLOAT = 0x16;
                export const PF_TYPE_CLOSEST_CAMERA_DISTANCE = 0xC;
                export const PF_TYPE_CONTROL_POINT_COMPONENT = 0x6;
                export const PF_TYPE_PARTICLE_AGE_NORMALIZED = 0x14;
                export const PF_TYPE_CONTROL_POINT_CHANGE_AGE = 0x7;
                export const PF_TYPE_RENDERER_CAMERA_DISTANCE = 0x10;
                export const PF_TYPE_PARTICLE_VECTOR_COMPONENT = 0x17;
                export const PF_TYPE_PARTICLE_NUMBER_NORMALIZED = 0x1B;
                export const PF_TYPE_RENDERER_CAMERA_DOT_PRODUCT = 0x11;
                export const PF_TYPE_PARTICLE_ROPE_SEGMENT_NORMALIZED = 0x1D;
                export const PF_TYPE_PARTICLE_INITIAL_VECTOR_COMPONENT = 0x18;
                export const PF_TYPE_PARTICLE_SCREENSPACE_CAMERA_DISTANCE = 0x1E;
                export const PF_TYPE_PARTICLE_SCREENSPACE_CAMERA_DOT_PRODUCT = 0x1F;
            }
            export namespace ParticleModelType_t {
                export const PM_TYPE_COUNT = 0x4;
                export const PM_TYPE_INVALID = 0x0;
                export const PM_TYPE_CONTROL_POINT = 0x3;
                export const PM_TYPE_NAMED_VALUE_MODEL = 0x1;
                export const PM_TYPE_NAMED_VALUE_EHANDLE = 0x2;
            }
            export namespace ParticleSetMethod_t {
                export const PARTICLE_SET_REPLACE_VALUE = 0x0;
                export const PARTICLE_SET_RAMP_CURRENT_VALUE = 0x3;
                export const PARTICLE_SET_SCALE_CURRENT_VALUE = 0x4;
                export const PARTICLE_SET_SCALE_INITIAL_VALUE = 0x1;
                export const PARTICLE_SET_ADD_TO_CURRENT_VALUE = 0x5;
                export const PARTICLE_SET_ADD_TO_INITIAL_VALUE = 0x2;
            }
            export namespace StateActionBehavior {
                export const STATETAGBEHAVIOR_FIRE_ON_EXIT = 0x2;
                export const STATETAGBEHAVIOR_FIRE_ON_ENTER = 0x1;
                export const STATETAGBEHAVIOR_ACTIVE_WHILE_CURRENT = 0x0;
                export const STATETAGBEHAVIOR_FIRE_ON_ENTER_AND_EXIT = 0x3;
                export const STATETAGBEHAVIOR_ACTIVE_WHILE_FULLY_BLENDED = 0x4;
            }
            export namespace BoneTransformSpace_t {
                export const BoneTransformSpace_Model = 0x1;
                export const BoneTransformSpace_World = 0x2;
                export const BoneTransformSpace_Parent = 0x0;
                export const BoneTransformSpace_Invalid = -0x1;
            }
            export namespace DampingSpeedFunction {
                export const Spring = 0x2;
                export const Constant = 0x1;
                export const NoDamping = 0x0;
                export const AsymmetricSpring = 0x3;
            }
            export namespace JumpCorrectionMethod {
                export const ScaleMotion = 0x0;
                export const AddCorrectionDelta = 0x1;
            }
            export namespace MovementCapability_t {
                export const eLean = 0x8;
                export const eStop = 0x3;
                export const eCount = 0xA;
                export const eStart = 0x2;
                export const eStrafe = 0x0;
                export const eShuffle = 0x5;
                export const eIdleTurn = 0x1;
                export const eInstantStop = 0x4;
                export const ePlantedTurn = 0x6;
                export const eForwardStartOnly = 0x9;
                export const eUseStartAsPlantedTurn = 0x7;
            }
            export namespace NPCPhysicsHullType_t {
                export const eInvalid = 0x0;
                export const eGroundBox = 0x4;
                export const eGroundCapsule = 0x1;
                export const eGenericCapsule = 0x3;
                export const eGroundCylinder = 0x5;
                export const eCenteredCapsule = 0x2;
                export const eCenteredCylinder = 0x6;
            }
            export namespace ParticleAttachment_t {
                export const PATTACH_POINT = 0x4;
                export const PATTACH_INVALID = -0x1;
                export const MAX_PATTACH_TYPES = 0x10;
                export const PATTACH_ABSORIGIN = 0x0;
                export const PATTACH_HEALTHBAR = 0xF;
                export const PATTACH_MAIN_VIEW = 0xB;
                export const PATTACH_WATERWAKE = 0xC;
                export const PATTACH_EYES_FOLLOW = 0x6;
                export const PATTACH_WORLDORIGIN = 0x8;
                export const PATTACH_CUSTOMORIGIN = 0x2;
                export const PATTACH_POINT_FOLLOW = 0x5;
                export const PATTACH_CENTER_FOLLOW = 0xD;
                export const PATTACH_OVERHEAD_FOLLOW = 0x7;
                export const PATTACH_ROOTBONE_FOLLOW = 0x9;
                export const PATTACH_ABSORIGIN_FOLLOW = 0x1;
                export const PATTACH_CUSTOMORIGIN_FOLLOW = 0x3;
                export const PATTACH_CUSTOM_GAME_STATE_1 = 0xE;
                export const PATTACH_RENDERORIGIN_FOLLOW = 0xA;
            }
            export namespace RenderMeshSlotType_t {
                export const RENDERMESH_SLOT_INVALID = -0x1;
                export const RENDERMESH_SLOT_PER_VERTEX = 0x0;
                export const RENDERMESH_SLOT_PER_INSTANCE = 0x1;
            }
            export namespace SharedMovementGait_t {
                export const eFast = 0x2;
                export const eSlow = 0x0;
                export const eCount = 0x4;
                export const eMedium = 0x1;
                export const eInvalid = -0x1;
                export const eVeryFast = 0x3;
            }
            export namespace VertexAlbedoFormat_t {
                export const VERTEX_ALBEDO_565 = 0x2;
                export const VERTEX_ALBEDO_8888 = 0x1;
                export const VERTEX_ALBEDO_NONE = 0x0;
            }
            export namespace AnimParamVectorType_t {
                export const ANIMPARAM_VECTOR_TYPE_NONE = 0x0;
                export const ANIMPARAM_VECTOR_TYPE_POSITION_LS = 0x2;
                export const ANIMPARAM_VECTOR_TYPE_POSITION_WS = 0x1;
                export const ANIMPARAM_VECTOR_TYPE_DIRECTION_LS = 0x4;
                export const ANIMPARAM_VECTOR_TYPE_DIRECTION_WS = 0x3;
            }
            export namespace BinaryNodeChildOption {
                export const Child1 = 0x0;
                export const Child2 = 0x1;
            }
            export namespace CNmClothEvent__Type_t {
                export const Effect = 0x1;
                export const Stiffen = 0x0;
            }
            export namespace OrientationWarpMode_t {
                export const eAngle = 0x1;
                export const eInvalid = 0x0;
                export const eWorldPosition = 0x2;
            }
            export namespace PulseMethodCallMode_t {
                export const ASYNC_FIRE_AND_FORGET = 0x1;
                export const SYNC_WAIT_FOR_COMPLETION = 0x0;
            }
            export namespace SelectorTagBehavior_t {
                export const SelectorTagBehavior_OnWhileCurrent = 0x0;
                export const SelectorTagBehavior_OffWhenFinished = 0x1;
                export const SelectorTagBehavior_OffBeforeFinished = 0x2;
            }
            export namespace TargetWarpAngleMode_t {
                export const eMoveHeading = 0x1;
                export const eFacingHeading = 0x0;
            }
            export namespace CNmEventTargetEntity_t {
                export const _Self = 0x0;
                export const Custom = 0x3;
                export const Weapon = 0x1;
                export const HeldItem = 0x2;
            }
            export namespace EDemoBoneSelectionMode {
                export const CaptureAllBones = 0x0;
                export const CaptureSelectedBones = 0x1;
            }
            export namespace ModelMeshBufferUsage_t {
                export const MESH_BUFFER_USAGE_IB = 0x2;
                export const MESH_BUFFER_USAGE_VB = 0x1;
                export const MESH_BUFFER_USAGE_NONE = 0x0;
                export const MESH_BUFFER_USAGE_MESHLETS = 0x80;
                export const MESH_BUFFER_USAGE_RT_PROXY = 0x10;
                export const MESH_BUFFER_USAGE_ADJACENCY = 0x4;
                export const MESH_BUFFER_USAGE_ALIAS_TABLE = 0x100;
                export const MESH_BUFFER_USAGE_MESHLET_TRIS = 0x8;
                export const MESH_BUFFER_USAGE_VERTEX_ALBEDO = 0x20;
                export const MESH_BUFFER_USAGE_VERTEX_EMISSIVE = 0x40;
            }
            export namespace NmFootPhaseCondition_t {
                export const _None = 0x6;
                export const LeftPhase = 0x4;
                export const RightPhase = 0x5;
                export const LeftFootDown = 0x0;
                export const RightFootDown = 0x2;
                export const LeftFootPassing = 0x1;
                export const RightFootPassing = 0x3;
            }
            export namespace NmFrameSnapEventMode_t {
                export const Floor = 0x0;
                export const Round = 0x1;
            }
            export namespace ParticleFloatMapType_t {
                export const PF_MAP_TYPE_MAX = 0x8;
                export const PF_MAP_TYPE_MIN = 0x7;
                export const PF_MAP_TYPE_MOD = 0x9;
                export const PF_MAP_TYPE_MULT = 0x1;
                export const PF_MAP_TYPE_COUNT = 0xA;
                export const PF_MAP_TYPE_CURVE = 0x4;
                export const PF_MAP_TYPE_REMAP = 0x2;
                export const PF_MAP_TYPE_ROUND = 0x6;
                export const PF_MAP_TYPE_DIRECT = 0x0;
                export const PF_MAP_TYPE_INVALID = -0x1;
                export const PF_MAP_TYPE_NOTCHED = 0x5;
                export const PF_MAP_TYPE_REMAP_BIASED = 0x3;
            }
            export namespace PulseDomainValueType_t {
                export const COUNT = 0x2;
                export const INVALID = -0x1;
                export const PANEL_ID = 0x1;
                export const ENTITY_NAME = 0x0;
            }
            export namespace PulseInstructionCode_t {
                export const EQ = 0x22;
                export const LT = 0x20;
                export const NE = 0x23;
                export const OR = 0x25;
                export const ADD = 0x1B;
                export const AND = 0x24;
                export const DIV = 0x1E;
                export const LTE = 0x21;
                export const MOD = 0x1F;
                export const MUL = 0x1D;
                export const NOP = 0x5;
                export const NOT = 0x19;
                export const SUB = 0x1C;
                export const COPY = 0x18;
                export const JUMP = 0x6;
                export const SCALE = 0x26;
                export const EQ_INT = 0x55;
                export const LT_INT = 0x4E;
                export const NEGATE = 0x1A;
                export const NE_INT = 0x66;
                export const ADD_INT = 0x36;
                export const EQ_BOOL = 0x54;
                export const EQ_VEC2 = 0x57;
                export const EQ_VEC3 = 0x58;
                export const EQ_VEC4 = 0x5A;
                export const GET_VAR = 0x10;
                export const INVALID = 0x0;
                export const LTE_INT = 0x51;
                export const MOD_INT = 0x4C;
                export const MUL_INT = 0x49;
                export const NE_BOOL = 0x65;
                export const NE_VEC2 = 0x68;
                export const NE_VEC3 = 0x69;
                export const NE_VEC4 = 0x6B;
                export const SET_VAR = 0xF;
                export const SUB_INT = 0x40;
                export const ADD_VEC2 = 0x39;
                export const ADD_VEC3 = 0x3A;
                export const ADD_VEC4 = 0x3D;
                export const EQ_ARRAY = 0x63;
                export const EQ_FLOAT = 0x56;
                export const LT_FLOAT = 0x4F;
                export const NE_ARRAY = 0x74;
                export const NE_FLOAT = 0x67;
                export const SUB_VEC2 = 0x42;
                export const SUB_VEC3 = 0x43;
                export const SUB_VEC4 = 0x46;
                export const ADD_FLOAT = 0x37;
                export const DIV_FLOAT = 0x4B;
                export const EQ_STRING = 0x5B;
                export const EQ_VEC3WS = 0x59;
                export const GET_CONST = 0x15;
                export const JUMP_COND = 0x7;
                export const LTE_FLOAT = 0x52;
                export const MOD_FLOAT = 0x4D;
                export const MUL_FLOAT = 0x4A;
                export const NE_STRING = 0x6C;
                export const NE_VEC3WS = 0x6A;
                export const SCALE_INV = 0x27;
                export const SUB_FLOAT = 0x41;
                export const ADD_STRING = 0x38;
                export const CHUNK_LEAP = 0x8;
                export const EQ_EHANDLE = 0x5E;
                export const LOOP_BREAK = 0x4;
                export const NEGATE_INT = 0x31;
                export const NE_EHANDLE = 0x6F;
                export const SCALE_VEC2 = 0x77;
                export const SCALE_VEC3 = 0x76;
                export const SCALE_VEC4 = 0x78;
                export const CELL_INVOKE = 0xD;
                export const EQ_GAMETIME = 0x64;
                export const GET_TEMPVAR = 0x2D;
                export const LT_GAMETIME = 0x50;
                export const NEGATE_VEC2 = 0x33;
                export const NEGATE_VEC3 = 0x34;
                export const NEGATE_VEC4 = 0x35;
                export const NE_GAMETIME = 0x75;
                export const RETURN_VOID = 0x2;
                export const SET_TEMPVAR = 0x2E;
                export const EQ_COLOR_RGB = 0x62;
                export const LTE_GAMETIME = 0x53;
                export const NEGATE_FLOAT = 0x32;
                export const NE_COLOR_RGB = 0x73;
                export const RETURN_VALUE = 0x3;
                export const SUB_GAMETIME = 0x48;
                export const CONVERT_VALUE = 0x29;
                export const ELEMENT_ACCESS = 0x28;
                export const EQ_ENTITY_NAME = 0x5C;
                export const EQ_SCHEMA_ENUM = 0x5D;
                export const EQ_TEST_HANDLE = 0x61;
                export const GET_VAR_DETACH = 0x11;
                export const IMMEDIATE_HALT = 0x1;
                export const LIBRARY_INVOKE = 0xE;
                export const NE_ENTITY_NAME = 0x6D;
                export const NE_SCHEMA_ENUM = 0x6E;
                export const NE_TEST_HANDLE = 0x72;
                export const SCALE_INV_VEC2 = 0x7A;
                export const SCALE_INV_VEC3 = 0x79;
                export const SCALE_INV_VEC4 = 0x7B;
                export const ADD_VEC3WS_VEC3 = 0x3B;
                export const ADD_VEC3_VEC3WS = 0x3C;
                export const CHUNK_LEAP_COND = 0x9;
                export const DETACH_REGISTER = 0x12;
                export const EQ_PANEL_HANDLE = 0x5F;
                export const NE_PANEL_HANDLE = 0x70;
                export const PULSE_CALL_SYNC = 0xA;
                export const SUB_VEC3WS_VEC3 = 0x44;
                export const EQ_OPAQUE_HANDLE = 0x60;
                export const GET_DOMAIN_VALUE = 0x17;
                export const NE_OPAQUE_HANDLE = 0x71;
                export const GET_ARRAY_ELEMENT = 0x16;
                export const SUB_VEC3WS_VEC3WS = 0x45;
                export const ADD_FLOAT_GAMETIME = 0x3F;
                export const ADD_GAMETIME_FLOAT = 0x3E;
                export const SET_VAR_OBSERVABLE = 0x14;
                export const SUB_GAMETIME_FLOAT = 0x47;
                export const ELEMENT_ACCESS_VEC2 = 0x7C;
                export const ELEMENT_ACCESS_VEC3 = 0x7D;
                export const ELEMENT_ACCESS_VEC4 = 0x7F;
                export const LAST_SERIALIZED_CODE = 0x30;
                export const REINTERPRET_INSTANCE = 0x2A;
                export const ELEMENT_ACCESS_VEC3WS = 0x7E;
                export const PULSE_CALL_ASYNC_FIRE = 0xB;
                export const SET_TEMPVAR_OBSERVABLE = 0x2F;
                export const ELEMENT_ACCESS_COLOR_RGB = 0x80;
                export const GET_BLACKBOARD_REFERENCE = 0x2B;
                export const GET_CONST_INLINE_STORAGE = 0x81;
                export const SET_BLACKBOARD_REFERENCE = 0x2C;
                export const SET_VAR_ARRAY_ELEMENT_1D = 0x13;
                export const CREATE_CHILD_CURSOR_OUTFLOW = 0xC;
            }
            export namespace TargetWarpTimingMethod {
                export const ReachDestinationOnWarpTagEnd = 0x1;
                export const ReachDestinationOnRootMotionEnd = 0x0;
            }
            export namespace VPhysXJoint_t__Flags_t {
                export const JOINT_FLAGS_NONE = 0x0;
                export const JOINT_FLAGS_BODY1_FIXED = 0x1;
                export const JOINT_FLAGS_USE_BLOCK_SOLVER = 0x2;
            }
            export namespace AnimParamNetworkSetting {
                export const Auto = 0x0;
                export const NeverNetwork = 0x2;
                export const AlwaysNetwork = 0x1;
            }
            export namespace AnimationSnapshotType_t {
                export const ANIMATION_SNAPSHOT_MAX = 0x6;
                export const ANIMATION_SNAPSHOT_CLIENT_RENDER = 0x4;
                export const ANIMATION_SNAPSHOT_FINAL_COMPOSITE = 0x5;
                export const ANIMATION_SNAPSHOT_CLIENT_PREDICTION = 0x2;
                export const ANIMATION_SNAPSHOT_CLIENT_SIMULATION = 0x1;
                export const ANIMATION_SNAPSHOT_SERVER_SIMULATION = 0x0;
                export const ANIMATION_SNAPSHOT_CLIENT_INTERPOLATION = 0x3;
            }
            export namespace FootPinningTimingSource {
                export const Tag = 0x1;
                export const Parameter = 0x2;
                export const FootMotion = 0x0;
            }
            export namespace NmEventConditionRules_t {
                export const OperatorOr = 0x4;
                export const OperatorAnd = 0x5;
                export const PreferHighestWeight = 0x2;
                export const IgnoreInactiveEvents = 0x1;
                export const SearchOnlyAnimEvents = 0x7;
                export const PreferHighestProgress = 0x3;
                export const SearchOnlyGraphEvents = 0x6;
                export const LimitSearchToSourceState = 0x0;
                export const SearchBothGraphAndAnimEvents = 0x8;
            }
            export namespace NmRootMotionBlendMode_t {
                export const Blend = 0x0;
                export const Additive = 0x1;
                export const IgnoreSource = 0x2;
                export const IgnoreTarget = 0x3;
            }
            export namespace NmTargetWarpAlgorithm_t {
                export const Lerp = 0x0;
                export const Bezier = 0x3;
                export const Hermite = 0x1;
                export const HermiteFeaturePreserving = 0x2;
            }
            export namespace ParticleFloatBiasType_t {
                export const PF_BIAS_TYPE_GAIN = 0x1;
                export const PF_BIAS_TYPE_COUNT = 0x3;
                export const PF_BIAS_TYPE_INVALID = -0x1;
                export const PF_BIAS_TYPE_STANDARD = 0x0;
                export const PF_BIAS_TYPE_EXPONENTIAL = 0x2;
            }
            export namespace ParticleTransformType_t {
                export const PT_TYPE_COUNT = 0x4;
                export const PT_TYPE_INVALID = 0x0;
                export const PT_TYPE_NAMED_VALUE = 0x1;
                export const PT_TYPE_CONTROL_POINT = 0x2;
                export const PT_TYPE_CONTROL_POINT_RANGE = 0x3;
            }
            export namespace PulseBestOutflowRules_t {
                export const SORT_BY_OUTFLOW_INDEX = 0x1;
                export const SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0;
            }
            export namespace CNmParticleEvent__Type_t {
                export const Create = 0x0;
                export const Create_CFG = 0x1;
            }
            export namespace FootLockSubVisualization {
                export const FOOTLOCKSUBVISUALIZATION_IKSolve = 0x1;
                export const FOOTLOCKSUBVISUALIZATION_ReachabilityAnalysis = 0x0;
            }
            export namespace IKTargetCoordinateSystem {
                export const IKTARGETCOORDINATESYSTEM_COUNT = 0x2;
                export const IKTARGETCOORDINATESYSTEM_ModelSpace = 0x1;
                export const IKTARGETCOORDINATESYSTEM_WorldSpace = 0x0;
            }
            export namespace MeshDrawPrimitiveFlags_t {
                export const MESH_DRAW_FLAGS_NONE = 0x0;
                export const MESH_DRAW_FLAGS_DRAW_LAST = 0x80;
                export const MESH_DRAW_FLAGS_USE_SHADOW_FAST_PATH = 0x1;
                export const MESH_DRAW_FLAGS_USE_COMPRESSED_NORMAL_TANGENT = 0x2;
                export const MESH_DRAW_INPUT_LAYOUT_IS_NOT_MATCHED_TO_MATERIAL = 0x8;
                export const MESH_DRAW_FLAGS_USE_COMPRESSED_PER_VERTEX_LIGHTING = 0x10;
                export const MESH_DRAW_FLAGS_USE_UNCOMPRESSED_PER_VERTEX_LIGHTING = 0x20;
                export const MESH_DRAW_FLAGS_CAN_BATCH_WITH_DYNAMIC_SHADER_CONSTANTS = 0x40;
            }
            export namespace ModelBoneFlexComponent_t {
                export const MODEL_BONE_FLEX_TX = 0x0;
                export const MODEL_BONE_FLEX_TY = 0x1;
                export const MODEL_BONE_FLEX_TZ = 0x2;
                export const MODEL_BONE_FLEX_INVALID = -0x1;
            }
            export namespace ParticleColorBlendMode_t {
                export const PARTICLEBLEND_DARKEN = 0x2;
                export const PARTICLEBLEND_DEFAULT = 0x0;
                export const PARTICLEBLEND_LIGHTEN = 0x3;
                export const PARTICLEBLEND_OVERLAY = 0x1;
                export const PARTICLEBLEND_MULTIPLY = 0x4;
            }
            export namespace ParticleColorBlendType_t {
                export const PARTICLE_COLOR_BLEND_ADD = 0x3;
                export const PARTICLE_COLOR_BLEND_MAX = 0x7;
                export const PARTICLE_COLOR_BLEND_MIN = 0x8;
                export const PARTICLE_COLOR_BLEND_MOD2X = 0x5;
                export const PARTICLE_COLOR_BLEND_DIVIDE = 0x2;
                export const PARTICLE_COLOR_BLEND_NEGATE = 0xB;
                export const PARTICLE_COLOR_BLEND_SCREEN = 0x6;
                export const PARTICLE_COLOR_BLEND_AVERAGE = 0xA;
                export const PARTICLE_COLOR_BLEND_REPLACE = 0x9;
                export const PARTICLE_COLOR_BLEND_MULTIPLY = 0x0;
                export const PARTICLE_COLOR_BLEND_SUBTRACT = 0x4;
                export const PARTICLE_COLOR_BLEND_LUMINANCE = 0xC;
                export const PARTICLE_COLOR_BLEND_MULTIPLY2X = 0x1;
            }
            export namespace ParticleFloatInputMode_t {
                export const PF_INPUT_MODE_COUNT = 0x2;
                export const PF_INPUT_MODE_LOOPED = 0x1;
                export const PF_INPUT_MODE_CLAMPED = 0x0;
                export const PF_INPUT_MODE_INVALID = -0x1;
            }
            export namespace ParticleFloatRoundType_t {
                export const PF_ROUND_TYPE_CEIL = 0x2;
                export const PF_ROUND_TYPE_COUNT = 0x3;
                export const PF_ROUND_TYPE_FLOOR = 0x1;
                export const PF_ROUND_TYPE_INVALID = -0x1;
                export const PF_ROUND_TYPE_NEAREST = 0x0;
            }
            export namespace AnimationProcessingType_t {
                export const ANIMATION_PROCESSING_MAX = 0x5;
                export const ANIMATION_PROCESSING_CLIENT_RENDER = 0x4;
                export const ANIMATION_PROCESSING_CLIENT_PREDICTION = 0x2;
                export const ANIMATION_PROCESSING_CLIENT_SIMULATION = 0x1;
                export const ANIMATION_PROCESSING_SERVER_SIMULATION = 0x0;
                export const ANIMATION_PROCESSING_CLIENT_INTERPOLATION = 0x3;
            }
            export namespace CNmSoundEvent__Position_t {
                export const _None = 0x0;
                export const World = 0x1;
                export const EntityPos = 0x2;
                export const EntityEyePos = 0x3;
                export const EntityAttachment = 0x4;
            }
            export namespace CNmTargetInfoNode__Info_t {
                export const Distance = 0x2;
                export const AngleVertical = 0x1;
                export const AngleHorizontal = 0x0;
                export const DeltaOrientationX = 0x5;
                export const DeltaOrientationY = 0x6;
                export const DeltaOrientationZ = 0x7;
                export const DistanceVerticalOnly = 0x4;
                export const DistanceHorizontalOnly = 0x3;
            }
            export namespace CNmVectorInfoNode__Info_t {
                export const X = 0x0;
                export const Y = 0x1;
                export const Z = 0x2;
                export const Length = 0x3;
                export const AngleVertical = 0x5;
                export const AngleHorizontal = 0x4;
            }
            export namespace ParticleFloatRandomMode_t {
                export const PF_RANDOM_MODE_COUNT = 0x2;
                export const PF_RANDOM_MODE_INVALID = -0x1;
                export const PF_RANDOM_MODE_VARYING = 0x1;
                export const PF_RANDOM_MODE_CONSTANT = 0x0;
            }
            export namespace PermModelInfo_t__FlagEnum {
                export const FLAG_MODEL_DOC = 0x800000;
                export const FLAG_TRANSLUCENT = 0x1;
                export const FLAG_NAV_GEN_HULL = 0x40;
                export const FLAG_NAV_GEN_NONE = 0x20;
                export const FLAG_NO_ANIM_EVENTS = 0x100000;
                export const FLAG_NO_FORCED_FADE = 0x800;
                export const FLAG_SOURCE1_IMPORT = 0x8;
                export const FLAG_MODEL_PART_CHILD = 0x10;
                export const FLAG_HAS_SKINNED_MESHES = 0x400;
                export const FLAG_DO_NOT_CAST_SHADOWS = 0x20000;
                export const FLAG_TRANSLUCENT_TWO_PASS = 0x2;
                export const FLAG_ANIMATION_DRIVEN_FLEXES = 0x200000;
                export const FLAG_FORCE_PHONEME_CROSSFADE = 0x1000;
                export const FLAG_MODEL_IS_RUNTIME_COMBINED = 0x4;
                export const FLAG_IMPLICIT_BIND_POSE_SEQUENCE = 0x400000;
            }
            export namespace PulseCursorWakePriority_t {
                export const WakeElegantly = 0x0;
                export const WakeImmediate = 0x1;
            }
            export namespace PulseVariableKeysSource_t {
                export const CPP = 0x1;
                export const XML = 0x4;
                export const VMAP = 0x2;
                export const VMDL = 0x3;
                export const COUNT = 0x6;
                export const VDATA = 0x5;
                export const PRIVATE = 0x0;
            }
            export namespace TargetSelectorAngleMode_t {
                export const eMoveHeading = 0x1;
                export const eFacingHeading = 0x0;
            }
            export namespace GPUParticleCollisionMode_t {
                export const PARTICLE_GPU_COLLISION_MODE_RT = 0x0;
                export const PARTICLE_GPU_COLLISION_MODE_DEPTH = 0x1;
                export const PARTICLE_GPU_COLLISION_MODE_HYBRID = 0x2;
            }
            export namespace TargetWarpCorrectionMethod {
                export const ScaleMotion = 0x0;
                export const AddCorrectionDelta = 0x1;
            }
            export namespace LinearRootMotionBlendMode_t {
                export const LERP = 0x0;
                export const NLERP = 0x1;
                export const SLERP = 0x2;
            }
            export namespace MatterialAttributeTagType_t {
                export const MATERIAL_ATTRIBUTE_TAG_COLOR = 0x1;
                export const MATERIAL_ATTRIBUTE_TAG_VALUE = 0x0;
            }
            export namespace ModelConfigAttachmentType_t {
                export const MODEL_CONFIG_ATTACHMENT_COUNT = 0x3;
                export const MODEL_CONFIG_ATTACHMENT_INVALID = -0x1;
                export const MODEL_CONFIG_ATTACHMENT_BONEMERGE = 0x2;
                export const MODEL_CONFIG_ATTACHMENT_ROOT_RELATIVE = 0x1;
                export const MODEL_CONFIG_ATTACHMENT_BONE_OR_ATTACHMENT = 0x0;
            }
            export namespace NmGraphEventTypeCondition_t {
                export const Any = 0x5;
                export const Exit = 0x2;
                export const Entry = 0x0;
                export const Timed = 0x3;
                export const Generic = 0x4;
                export const FullyInState = 0x1;
            }
            export namespace NmTransitionRuleCondition_t {
                export const Blocked = 0x3;
                export const AnyAllowed = 0x0;
                export const FullyAllowed = 0x1;
                export const ConditionallyAllowed = 0x2;
            }
            export namespace PulseCursorCancelPriority_t {
                export const _None = 0x0;
                export const HardCancel = 0x3;
                export const SoftCancel = 0x2;
                export const CancelOnSucceeded = 0x1;
            }
            export namespace PulseDurationStringFormat_t {
                export const MM_SS_LEADING_ZERO = 0x0;
            }
            export namespace CNmFloatMathNode__Operator_t {
                export const Abs = 0x5;
                export const Add = 0x0;
                export const Div = 0x3;
                export const Mod = 0x4;
                export const Mul = 0x2;
                export const Sub = 0x1;
                export const Floor = 0x7;
                export const Negate = 0x6;
                export const Ceiling = 0x8;
                export const IntegerPart = 0x9;
                export const FractionalPart = 0xA;
                export const InverseFractionalPart = 0xB;
            }
            export namespace ParticleDirectionNoiseType_t {
                export const PARTICLE_DIR_NOISE_CURL = 0x1;
                export const PARTICLE_DIR_NOISE_PERLIN = 0x0;
                export const PARTICLE_DIR_NOISE_WORLEY_BASIC = 0x2;
            }
            export namespace ScriptedHeldWeaponBehavior_t {
                export const eDrop = 0x2;
                export const eDeploy = 0x1;
                export const eHolster = 0x0;
                export const eInvalid = -0x1;
            }
            export namespace FootstepLandedFootSoundType_t {
                export const FOOTSOUND_Left = 0x0;
                export const FOOTSOUND_Right = 0x1;
                export const FOOTSOUND_UseOverrideSound = 0x2;
            }
            export namespace MorphFlexControllerRemapType_t {
                export const MORPH_FLEXCONTROLLER_REMAP_2WAY = 0x1;
                export const MORPH_FLEXCONTROLLER_REMAP_NWAY = 0x2;
                export const MORPH_FLEXCONTROLLER_REMAP_EYELID = 0x3;
                export const MORPH_FLEXCONTROLLER_REMAP_PASSTHRU = 0x0;
            }
            export namespace EIKEndEffectorRotationFixUpMode {
                export const _None = 0x0;
                export const Count = 0x4;
                export const LookAtTargetForward = 0x2;
                export const MatchTargetOrientation = 0x1;
                export const MaintainParentOrientation = 0x3;
            }
            export namespace EPulseGraphExecutionHistoryFlag {
                export const RETURN = 0x80;
                export const NO_FLAGS = 0x0;
                export const CALL_TO_PULSE = 0x40;
                export const CURSOR_ADD_TAG = 0x1;
                export const CURSOR_RETIRED = 0x4;
                export const REQUIREMENT_FAIL = 0x20;
                export const REQUIREMENT_PASS = 0x10;
                export const CURSOR_REMOVE_TAG = 0x2;
                export const CURSOR_CREATE_CHILD = 0x8;
            }
            export namespace CNmTimeConditionNode__Operator_t {
                export const LessThan = 0x0;
                export const GreaterThan = 0x2;
                export const LessThanEqual = 0x1;
                export const GreaterThanEqual = 0x3;
            }
            export namespace ModelSkeletonData_t__BoneFlags_t {
                export const FLAG_MESH = 0x80;
                export const FLAG_CLOTH = 0x8;
                export const FLAG_HITBOX = 0x100;
                export const FLAG_PHYSICS = 0x10;
                export const FLAG_ANIMATION = 0x40;
                export const FLAG_ATTACHMENT = 0x20;
                export const FLAG_PROCEDURAL = 0x400000;
                export const BLEND_PREALIGNED = 0x100000;
                export const FLAG_RIGIDLENGTH = 0x200000;
                export const FLAG_NO_BONE_FLAGS = 0x0;
                export const FLAG_ALL_BONE_FLAGS = 0xFFFFF;
                export const FLAG_BONEFLEXDRIVER = 0x4;
                export const FLAG_BONE_MERGE_READ = 0x40000;
                export const FLAG_BONE_MERGE_WRITE = 0x80000;
                export const FLAG_BONE_USED_BY_VERTEX_LOD0 = 0x400;
                export const FLAG_BONE_USED_BY_VERTEX_LOD1 = 0x800;
                export const FLAG_BONE_USED_BY_VERTEX_LOD2 = 0x1000;
                export const FLAG_BONE_USED_BY_VERTEX_LOD3 = 0x2000;
                export const FLAG_BONE_USED_BY_VERTEX_LOD4 = 0x4000;
                export const FLAG_BONE_USED_BY_VERTEX_LOD5 = 0x8000;
                export const FLAG_BONE_USED_BY_VERTEX_LOD6 = 0x10000;
                export const FLAG_BONE_USED_BY_VERTEX_LOD7 = 0x20000;
            }
            export namespace SolveIKChainAnimNodeDebugSetting {
                export const SOLVEIKCHAINANIMNODEDEBUGSETTING_Up = 0x5;
                export const SOLVEIKCHAINANIMNODEDEBUGSETTING_Left = 0x6;
                export const SOLVEIKCHAINANIMNODEDEBUGSETTING_None = 0x0;
                export const SOLVEIKCHAINANIMNODEDEBUGSETTING_Forward = 0x4;
                export const SOLVEIKCHAINANIMNODEDEBUGSETTING_X_Axis_Circle = 0x1;
                export const SOLVEIKCHAINANIMNODEDEBUGSETTING_Y_Axis_Circle = 0x2;
                export const SOLVEIKCHAINANIMNODEDEBUGSETTING_Z_Axis_Circle = 0x3;
            }
            export namespace CNmIDComparisonNode__Comparison_t {
                export const Matches = 0x0;
                export const DoesntMatch = 0x1;
            }
            export namespace CNmRootMotionData__SamplingMode_t {
                export const Delta = 0x0;
                export const WorldSpace = 0x1;
            }
            export namespace OrientationWarpRootMotionSource_t {
                export const eAnimationOnly = 0x1;
                export const eProceduralOnly = 0x2;
                export const eAnimationOrProcedural = 0x0;
            }
            export namespace OrientationWarpTargetOffsetMode_t {
                export const eParameter = 0x1;
                export const eLiteralValue = 0x0;
                export const eAnimationMovementHeading = 0x2;
                export const eAnimationMovementHeadingAtEnd = 0x3;
            }
            export namespace CNmFloatAngleMathNode__Operation_t {
                export const ClampTo180 = 0x0;
                export const ClampTo360 = 0x1;
                export const FlipHemisphere = 0x2;
                export const FlipHemisphereNegate = 0x3;
            }
            export namespace VPhysXBodyPart_t__VPhysXFlagEnum_t {
                export const FLAG_MASS = 0x8;
                export const FLAG_JOINT = 0x4;
                export const FLAG_STATIC = 0x1;
                export const FLAG_KINEMATIC = 0x2;
                export const FLAG_DISABLE_CCD = 0x20;
                export const FLAG_ALWAYS_DYNAMIC_ON_CLIENT = 0x10;
            }
            export namespace CNmCurrentSyncEventNode__InfoType_t {
                export const IndexOnly = 0x1;
                export const PercentageOnly = 0x2;
                export const IndexAndPercentage = 0x0;
            }
            export namespace CNmFloatComparisonNode__Comparison_t {
                export const LessThan = 0x4;
                export const NearEqual = 0x2;
                export const GreaterThan = 0x3;
                export const LessThanEqual = 0x1;
                export const GreaterThanEqual = 0x0;
            }
            export namespace CNmTargetWarpNode__TargetUpdateRule_t {
                export const _None = 0x0;
                export const Offset = 0x2;
                export const Recalculate = 0x1;
                export const RecalculateOrOffset = 0x3;
            }
            export namespace CAnimationGraphVisualizerPrimitiveType {
                export const ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Pie = 0x3;
                export const ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Axis = 0x4;
                export const ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Line = 0x2;
                export const ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Text = 0x0;
                export const ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Sphere = 0x1;
            }
            export namespace CNmTimeConditionNode__ComparisonType_t {
                export const ElapsedTime = 0x2;
                export const PercentageThroughState = 0x0;
                export const PercentageThroughSyncEvent = 0x1;
            }
            export namespace CNmTransitionNode__TransitionOptions_t {
                export const _None = 0x0;
                export const Synchronized = 0x2;
                export const ClampDuration = 0x1;
                export const MatchSourceTime = 0x3;
                export const MatchSyncEventID = 0x5;
                export const MatchTimeInSeconds = 0x8;
                export const MatchSyncEventIndex = 0x4;
                export const OffsetTimeInSeconds = 0x9;
                export const MatchSyncEventPercentage = 0x6;
                export const PreferClosestSyncEventID = 0x7;
            }
            export namespace VPhysXConstraintParams_t__EnumFlags0_t {
                export const FLAG0_SHIFT_CONSTRAIN = 0x1;
                export const FLAG0_SHIFT_INTERPENETRATE = 0x0;
                export const FLAG0_SHIFT_BREAKABLE_FORCE = 0x2;
                export const FLAG0_SHIFT_BREAKABLE_TORQUE = 0x3;
            }
            export namespace CNmOrientationWarpNode__AlignmentMode_t {
                export const MovementDirection = 0x0;
                export const AnimationEndFacing = 0x1;
            }
            export namespace VPhysXAggregateData_t__VPhysXFlagEnum_t {
                export const FLAG_LEVEL_COLLISION = 0x10;
                export const FLAG_IS_POLYSOUP_GEOMETRY = 0x1;
                export const FLAG_IGNORE_SCALE_OBSOLETE_DO_NOT_USE = 0x20;
            }
            export namespace CNmStateNode__TimedEvent_t__Comparison_t {
                export const LessThanEqual = 0x0;
                export const GreaterThanEqual = 0x1;
            }
            export namespace CNmRootMotionOverrideNode__OverrideFlags_t {
                export const AllowMoveX = 0x0;
                export const AllowMoveY = 0x1;
                export const AllowMoveZ = 0x2;
                export const ListenForEvents = 0x4;
                export const AllowFacingPitch = 0x3;
            }
            export namespace CNmSyncEventIndexConditionNode__TriggerMode_t {
                export const ExactlyAtEventIndex = 0x0;
                export const GreaterThanEqualToEventIndex = 0x1;
            }
        }
    }
}
