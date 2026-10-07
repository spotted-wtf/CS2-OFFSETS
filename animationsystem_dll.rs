#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod schemas {
        pub mod animationsystem_dll {
            pub mod CFlexOp {
                pub const m_Data: i64 = 0x4;
                pub const m_OpCode: i64 = 0x0;
            }
            pub mod CHitBox {
                pub const m_CRC: i64 = 0x40;
                pub const m_name: i64 = 0x0;
                pub const m_nGroupId: i64 = 0x38;
                pub const m_sBoneName: i64 = 0x10;
                pub const m_nShapeType: i64 = 0x3C;
                pub const m_vMaxBounds: i64 = 0x24;
                pub const m_vMinBounds: i64 = 0x18;
                pub const m_cRenderColor: i64 = 0x44;
                pub const m_nHitBoxIndex: i64 = 0x48;
                pub const m_flShapeRadius: i64 = 0x30;
                pub const m_nBoneNameHash: i64 = 0x34;
                pub const m_bTranslationOnly: i64 = 0x3D;
                pub const m_sSurfaceProperty: i64 = 0x8;
            }
            pub mod CNmClip {
                pub const m_skeleton: i64 = 0x0;
                pub const m_syncTrack: i64 = 0xC0;
                pub const m_flDuration: i64 = 0xC;
                pub const m_nNumFrames: i64 = 0x8;
                pub const m_rootMotion: i64 = 0x170;
                pub const m_bIsAdditive: i64 = 0x1C0;
                pub const m_floatChannelData: i64 = 0x98;
                pub const m_compressedPoseData: i64 = 0x10;
                pub const m_secondaryAnimations: i64 = 0x78;
                pub const m_compressedPoseOffsets: i64 = 0x38;
                pub const m_modelSpaceSamplingChain: i64 = 0x1C8;
                pub const m_trackCompressionSettings: i64 = 0x20;
                pub const m_modelSpaceBoneSamplingIndices: i64 = 0x1E0;
            }
            pub mod CNmEvent {
                pub const m_syncID: i64 = 0x10;
                pub const m_flDuration: i64 = 0xC;
                pub const m_flStartTime: i64 = 0x8;
            }
            pub mod LookData {
                pub const m_vLookTarget: i64 = 0x0;
            }
            pub mod AnimTagID {
                pub const m_id: i64 = 0x0;
            }
            pub mod CAnimBone {
                pub const m_pos: i64 = 0x14;
                pub const m_name: i64 = 0x0;
                pub const m_quat: i64 = 0x20;
                pub const m_flags: i64 = 0x44;
                pub const m_scale: i64 = 0x30;
                pub const m_parent: i64 = 0x10;
                pub const m_qAlignment: i64 = 0x34;
            }
            pub mod CAnimData {
                pub const m_name: i64 = 0x10;
                pub const m_animArray: i64 = 0x20;
                pub const m_decoderArray: i64 = 0x38;
                pub const m_segmentArray: i64 = 0x58;
                pub const m_nMaxUniqueFrameIndex: i64 = 0x50;
            }
            pub mod CAnimDesc {
                pub const fps: i64 = 0x18;
                pub const m_Data: i64 = 0x20;
                pub const m_name: i64 = 0x0;
                pub const m_flags: i64 = 0x10;
                pub const m_eventArray: i64 = 0x130;
                pub const m_vecRootMax: i64 = 0x188;
                pub const m_vecRootMin: i64 = 0x17C;
                pub const framestalltime: i64 = 0x178;
                pub const m_activityArray: i64 = 0x148;
                pub const m_movementArray: i64 = 0xF8;
                pub const m_hierarchyArray: i64 = 0x160;
                pub const m_sequenceParams: i64 = 0x1C8;
                pub const m_xInitialOffset: i64 = 0x110;
                pub const m_vecBoneWorldMax: i64 = 0x1B0;
                pub const m_vecBoneWorldMin: i64 = 0x198;
            }
            pub mod CAnimEnum {
                pub const m_value: i64 = 0x0;
            }
            pub mod CAnimFoot {
                pub const m_name: i64 = 0x0;
                pub const m_vBallOffset: i64 = 0x8;
                pub const m_vHeelOffset: i64 = 0x14;
                pub const m_toeBoneIndex: i64 = 0x24;
                pub const m_ankleBoneIndex: i64 = 0x20;
            }
            pub mod CAnimUser {
                pub const m_name: i64 = 0x0;
                pub const m_nType: i64 = 0x10;
            }
            pub mod CFlexDesc {
                pub const m_szFacs: i64 = 0x0;
            }
            pub mod CFlexRule {
                pub const m_nFlex: i64 = 0x0;
                pub const m_FlexOps: i64 = 0x8;
            }
            pub mod CNmTarget {
                pub const m_bIsSet: i64 = 0x2B;
                pub const m_boneID: i64 = 0x20;
                pub const m_transform: i64 = 0x0;
                pub const m_bHasOffsets: i64 = 0x2A;
                pub const m_bIsBoneTarget: i64 = 0x28;
                pub const m_bIsUsingBoneSpaceOffsets: i64 = 0x29;
            }
            pub mod HSequence {
                pub const m_Value: i64 = 0x0;
            }
            pub mod SlopeData {
                pub const m_vSlopeNormal: i64 = 0x0;
            }
            pub mod TagSpan_t {
                pub const m_endCycle: i64 = 0x8;
                pub const m_tagIndex: i64 = 0x0;
                pub const m_startCycle: i64 = 0x4;
            }
            pub mod TagStatus {
                pub const m_TagStatus: i64 = 0x0;
                pub const m_flTagStartAnimTime: i64 = 0x4;
            }
            pub mod AnimNodeID {
                pub const m_id: i64 = 0x0;
            }
            pub mod CAnimCycle {

            }
            pub mod CCycleBase {
                pub const m_flCycle: i64 = 0x0;
            }
            pub mod CFootCycle {

            }
            pub mod CHitBoxSet {
                pub const m_name: i64 = 0x0;
                pub const m_HitBoxes: i64 = 0x10;
                pub const m_nNameHash: i64 = 0x8;
                pub const m_SourceFilename: i64 = 0x28;
            }
            pub mod CMoodVData {
                pub const m_nMoodType: i64 = 0xE0;
                pub const m_sModelName: i64 = 0x0;
                pub const m_animationLayers: i64 = 0xE8;
            }
            pub mod CMorphData {
                pub const m_name: i64 = 0x0;
                pub const m_morphRectDatas: i64 = 0x8;
            }
            pub mod CNmIDEvent {
                pub const m_ID: i64 = 0x18;
                pub const m_secondaryID: i64 = 0x20;
            }
            pub mod CSeqIKLock {
                pub const m_nLocalBone: i64 = 0x8;
                pub const m_flPosWeight: i64 = 0x0;
                pub const m_flAngleWeight: i64 = 0x4;
                pub const m_bBonesOrientedAlongPositiveX: i64 = 0xA;
            }
            pub mod SampleCode {
                pub const m_subCode: i64 = 0x0;
            }
            pub mod WeightList {
                pub const m_name: i64 = 0x0;
                pub const m_weights: i64 = 0x8;
            }
            pub mod AnimParamID {
                pub const m_id: i64 = 0x0;
            }
            pub mod AnimStateID {
                pub const m_id: i64 = 0x0;
            }
            pub mod BlendItem_t {
                pub const m_tags: i64 = 0x0;
                pub const m_vPos: i64 = 0x2C;
                pub const m_pChild: i64 = 0x18;
                pub const m_hSequence: i64 = 0x28;
                pub const m_flDuration: i64 = 0x34;
                pub const m_bUseCustomDuration: i64 = 0x38;
            }
            pub mod CAttachment {
                pub const m_name: i64 = 0x0;
                pub const m_nInfluences: i64 = 0x83;
                pub const m_influenceNames: i64 = 0x8;
                pub const m_bIgnoreRotation: i64 = 0x84;
                pub const m_influenceWeights: i64 = 0x74;
                pub const m_vInfluenceOffsets: i64 = 0x50;
                pub const m_vInfluenceRotations: i64 = 0x20;
                pub const m_bInfluenceRootTransform: i64 = 0x80;
            }
            pub mod CBlendCurve {
                pub const m_flControlPoint1: i64 = 0x0;
                pub const m_flControlPoint2: i64 = 0x4;
            }
            pub mod CCachedPose {
                pub const m_flCycle: i64 = 0x3C;
                pub const m_hSequence: i64 = 0x38;
                pub const m_transforms: i64 = 0x8;
                pub const m_morphWeights: i64 = 0x20;
            }
            pub mod CFootMotion {
                pub const m_name: i64 = 0x18;
                pub const m_strides: i64 = 0x0;
                pub const m_bAdditive: i64 = 0x20;
            }
            pub mod CFootStride {
                pub const m_definition: i64 = 0x0;
                pub const m_trajectories: i64 = 0x40;
            }
            pub mod CMotionNode {
                pub const m_id: i64 = 0x20;
                pub const m_name: i64 = 0x18;
            }
            pub mod CNmBitFlags {
                pub const m_flags: i64 = 0x0;
            }
            pub mod CNmPoseTask {

            }
            pub mod CNmSkeleton {
                pub const m_ID: i64 = 0x0;
                pub const m_boneIDs: i64 = 0x8;
                pub const m_parentIndices: i64 = 0x18;
                pub const m_contactConfigs: i64 = 0xC8;
                pub const m_bIsPropSkeleton: i64 = 0x64;
                pub const m_maskDefinitions: i64 = 0x88;
                pub const m_floatChannelSets: i64 = 0xB8;
                pub const m_secondarySkeletons: i64 = 0xA8;
                pub const m_nSpecialDependencyHash: i64 = 0xF8;
                pub const m_modelSpaceReferencePose: i64 = 0x48;
                pub const m_numBonesToSampleAtLowLOD: i64 = 0x60;
                pub const m_parentSpaceReferencePose: i64 = 0x30;
                pub const m_gameplayRelevantBoneIndices: i64 = 0xE0;
            }
            pub mod CPoseHandle {
                pub const m_eType: i64 = 0x2;
                pub const m_nIndex: i64 = 0x0;
            }
            pub mod CRenderMesh {
                pub const m_skeleton: i64 = 0xE0;
                pub const m_pGroomData: i64 = 0x230;
                pub const m_constraints: i64 = 0xD0;
                pub const m_sceneObjects: i64 = 0x10;
                pub const m_bEmbeddedMapMesh: i64 = 0x1F9;
                pub const m_meshDeformParams: i64 = 0x220;
                pub const m_bUseUV2ForCharting: i64 = 0x1F8;
            }
            pub mod CRootMotion {
                pub const m_vUpOverride: i64 = 0x1C;
                pub const m_vVelocityMS: i64 = 0x10;
                pub const m_deltaTransform: i64 = 0x0;
            }
            pub mod ConfigIndex {
                pub const m_nGroup: i64 = 0x0;
                pub const m_nConfig: i64 = 0x2;
            }
            pub mod MotionIndex {
                pub const m_nGroup: i64 = 0x0;
                pub const m_nMotion: i64 = 0x2;
            }
            pub mod NmPercent_t {
                pub const m_flValue: i64 = 0x0;
            }
            pub mod ParamSpan_t {
                pub const m_hParam: i64 = 0x18;
                pub const m_samples: i64 = 0x0;
                pub const m_eParamType: i64 = 0x1A;
                pub const m_flEndCycle: i64 = 0x20;
                pub const m_flStartCycle: i64 = 0x1C;
            }
            pub mod CAnimDecoder {
                pub const m_nType: i64 = 0x14;
                pub const m_szName: i64 = 0x0;
                pub const m_nVersion: i64 = 0x10;
            }
            pub mod CAnimKeyData {
                pub const m_name: i64 = 0x0;
                pub const m_boneArray: i64 = 0x10;
                pub const m_userArray: i64 = 0x28;
                pub const m_morphArray: i64 = 0x40;
                pub const m_dataChannelArray: i64 = 0x60;
                pub const m_nChannelElements: i64 = 0x58;
            }
            pub mod CAnimTagBase {
                pub const m_name: i64 = 0x18;
                pub const m_group: i64 = 0x28;
                pub const m_tagID: i64 = 0x30;
                pub const m_sComment: i64 = 0x20;
                pub const m_bIsReferenced: i64 = 0x48;
            }
            pub mod CModelConfig {
                pub const m_Elements: i64 = 0x8;
                pub const m_bTopLevel: i64 = 0x20;
                pub const m_ConfigName: i64 = 0x0;
                pub const m_bActiveInEditorByDefault: i64 = 0x21;
            }
            pub mod CMotionGraph {
                pub const m_tags: i64 = 0x28;
                pub const m_bLoop: i64 = 0x54;
                pub const m_pRootNode: i64 = 0x40;
                pub const m_paramSpans: i64 = 0x10;
                pub const m_nConfigCount: i64 = 0x50;
                pub const m_nParameterCount: i64 = 0x48;
                pub const m_nConfigStartIndex: i64 = 0x4C;
            }
            pub mod CNmBlendTask {

            }
            pub mod CNmFootEvent {
                pub const m_phase: i64 = 0x18;
            }
            pub mod CNmScaleTask {

            }
            pub mod CNmSyncTrack {
                pub const m_syncEvents: i64 = 0x0;
                pub const m_nStartEventOffset: i64 = 0xA8;
            }
            pub mod CPulse_Chunk {
                pub const m_Registers: i64 = 0x10;
                pub const m_Instructions: i64 = 0x0;
                pub const m_nTempVarBank: i64 = 0x30;
                pub const m_InstructionDebugInfos: i64 = 0x20;
            }
            pub mod CRenderGroom {
                pub const m_hairs: i64 = 0x0;
                pub const m_nHairCount: i64 = 0x80;
                pub const m_hSimParamsMat: i64 = 0x40;
                pub const m_nGroomGroupID: i64 = 0x8C;
                pub const m_nAttachBoneIdx: i64 = 0x90;
                pub const m_nAttachMeshIdx: i64 = 0x94;
                pub const m_nGuideHairCount: i64 = 0x7C;
                pub const m_bEnableSimulation: i64 = 0xAC;
                pub const m_nTotalVertexCount: i64 = 0x84;
                pub const m_nTotalSegmentCount: i64 = 0x88;
                pub const m_hairPositionOffsets: i64 = 0x18;
                pub const m_nAttachMeshDrawCallIdx: i64 = 0x98;
                pub const m_strandSegmentCountHist: i64 = 0x48;
                pub const m_nMaxSegmentsPerHairStrand: i64 = 0x78;
            }
            pub mod CSeqCmdLayer {
                pub const m_cmd: i64 = 0x0;
                pub const m_flVar1: i64 = 0xC;
                pub const m_flVar2: i64 = 0x10;
                pub const m_bSpline: i64 = 0xA;
                pub const m_nDstResult: i64 = 0x6;
                pub const m_nSrcResult: i64 = 0x8;
                pub const m_nLineNumber: i64 = 0x14;
                pub const m_nLocalBonemask: i64 = 0x4;
                pub const m_nLocalReference: i64 = 0x2;
            }
            pub mod CSeqScaleSet {
                pub const m_sName: i64 = 0x0;
                pub const m_bRootOffset: i64 = 0x10;
                pub const m_vRootOffset: i64 = 0x14;
                pub const m_nLocalBoneArray: i64 = 0x20;
                pub const m_flBoneScaleArray: i64 = 0x38;
            }
            pub mod LookAtBone_t {
                pub const m_index: i64 = 0x0;
                pub const m_weight: i64 = 0x4;
            }
            pub mod MovementData {
                pub const m_bHasPath: i64 = 0x68;
                pub const m_vMoveDir: i64 = 0xC;
                pub const m_bOnGround: i64 = 0xBC;
                pub const m_nFacingMode: i64 = 0x98;
                pub const m_bForceFacing: i64 = 0xA4;
                pub const m_bGoalChanged: i64 = 0x64;
                pub const m_vAcceleration: i64 = 0x20;
                pub const m_flGoalDistance: i64 = 0x4C;
                pub const m_flFacingHeading: i64 = 0x74;
                pub const m_goalWayPointPos: i64 = 0x0;
                pub const m_vFacingPosition: i64 = 0xC8;
                pub const m_flBoundaryRadius: i64 = 0x58;
                pub const m_flTargetMoveSpeed: i64 = 0x40;
                pub const m_nActiveMotorIndex: i64 = 0xB0;
                pub const m_flCurrentMoveSpeed: i64 = 0x34;
                pub const m_vManualFacingTarget: i64 = 0x8C;
                pub const m_vPrevFacingPosition: i64 = 0xDC;
                pub const m_vManualFacingDirection: i64 = 0x80;
            }
            pub mod ScriptInfo_t {
                pub const m_code: i64 = 0x0;
                pub const m_eScriptType: i64 = 0x50;
                pub const m_paramsModified: i64 = 0x8;
                pub const m_proxyReadParams: i64 = 0x20;
                pub const m_proxyWriteParams: i64 = 0x38;
            }
            pub mod SequenceData {
                pub const m_cycle: i64 = 0x4;
                pub const m_hSequence: i64 = 0x0;
            }
            pub mod StanceInfo_t {
                pub const m_vPosition: i64 = 0x0;
                pub const m_flDirection: i64 = 0xC;
            }
            pub mod CAnimActivity {
                pub const m_name: i64 = 0x0;
                pub const m_nFlags: i64 = 0x14;
                pub const m_nWeight: i64 = 0x18;
                pub const m_nActivity: i64 = 0x10;
            }
            pub mod CAnimMovement {
                pub const v0: i64 = 0x8;
                pub const v1: i64 = 0xC;
                pub const angle: i64 = 0x10;
                pub const vector: i64 = 0x14;
                pub const endframe: i64 = 0x0;
                pub const position: i64 = 0x20;
                pub const motionflags: i64 = 0x4;
            }
            pub mod CAnimNodePath {
                pub const m_path: i64 = 0x0;
                pub const m_nCount: i64 = 0x2C;
            }
            pub mod CAnimSkeleton {
                pub const m_feet: i64 = 0x88;
                pub const m_parents: i64 = 0x70;
                pub const m_children: i64 = 0x58;
                pub const m_boneNames: i64 = 0x40;
                pub const m_morphNames: i64 = 0xA0;
                pub const m_lodBoneCounts: i64 = 0xB8;
                pub const m_localSpaceTransforms: i64 = 0x10;
                pub const m_modelSpaceTransforms: i64 = 0x28;
            }
            pub mod CAudioAnimTag {
                pub const m_clipName: i64 = 0x58;
                pub const m_flVolume: i64 = 0x68;
                pub const m_bPlayOnClient: i64 = 0x6F;
                pub const m_bPlayOnServer: i64 = 0x6E;
                pub const m_attachmentName: i64 = 0x60;
                pub const m_bStopWhenTagEnds: i64 = 0x6C;
                pub const m_bStopWhenGraphEnds: i64 = 0x6D;
            }
            pub mod CMorphSetData {
                pub const m_nWidth: i64 = 0x10;
                pub const m_nHeight: i64 = 0x14;
                pub const m_FlexDesc: i64 = 0x50;
                pub const m_FlexRules: i64 = 0x80;
                pub const m_morphDatas: i64 = 0x30;
                pub const m_bundleTypes: i64 = 0x18;
                pub const m_pTextureAtlas: i64 = 0x48;
                pub const m_FlexControllers: i64 = 0x68;
            }
            pub mod CNmClothEvent {
                pub const m_type: i64 = 0x18;
                pub const m_flSpeedIn: i64 = 0x20;
                pub const m_effectName: i64 = 0x38;
                pub const m_flSpeedOut: i64 = 0x24;
                pub const m_flStiffness: i64 = 0x1C;
                pub const m_vertexSetName: i64 = 0x30;
                pub const m_flLengthSeconds: i64 = 0x28;
            }
            pub mod CNmFootIKTask {
                pub const m_blendMode: i64 = 0x130;
                pub const m_leftTarget: i64 = 0xD0;
                pub const m_rightTarget: i64 = 0x100;
                pub const m_flBlendWeight: i64 = 0x134;
                pub const m_nLeftTargetBoneIdx: i64 = 0xC0;
                pub const m_leftTargetTransform: i64 = 0x80;
                pub const m_nRightTargetBoneIdx: i64 = 0xC4;
                pub const m_nLeftEffectorBoneIdx: i64 = 0x70;
                pub const m_rightTargetTransform: i64 = 0xA0;
                pub const m_bIsTargetInWorldSpace: i64 = 0x138;
                pub const m_nRightEffectorBoneIdx: i64 = 0x74;
                pub const m_bIsRunningFromDeserializedData: i64 = 0x139;
            }
            pub mod CNmSampleTask {

            }
            pub mod CNmSoundEvent {
                pub const m_name: i64 = 0x20;
                pub const m_tags: i64 = 0x38;
                pub const m_position: i64 = 0x28;
                pub const m_relevance: i64 = 0x18;
                pub const m_attachmentName: i64 = 0x30;
                pub const m_flDurationInterruptionThreshold: i64 = 0x44;
                pub const m_bContinuePlayingSoundAtDurationEnd: i64 = 0x40;
            }
            pub mod CSeqAutoLayer {
                pub const m_end: i64 = 0x18;
                pub const m_peak: i64 = 0x10;
                pub const m_tail: i64 = 0x14;
                pub const m_flags: i64 = 0x4;
                pub const m_start: i64 = 0xC;
                pub const m_nLocalPose: i64 = 0x2;
                pub const m_nLocalReference: i64 = 0x0;
            }
            pub mod CSeqS1SeqDesc {
                pub const m_fetch: i64 = 0x20;
                pub const m_flags: i64 = 0x10;
                pub const m_sName: i64 = 0x0;
                pub const m_footMotion: i64 = 0x108;
                pub const m_transition: i64 = 0xC8;
                pub const m_IKLockArray: i64 = 0xB0;
                pub const m_SequenceKeys: i64 = 0xD0;
                pub const m_activityArray: i64 = 0xF0;
                pub const m_autoLayerArray: i64 = 0x98;
                pub const m_nLocalWeightlist: i64 = 0x90;
                pub const m_LegacyKeyValueText: i64 = 0xE0;
            }
            pub mod MotionDBIndex {
                pub const m_nIndex: i64 = 0x0;
            }
            pub mod VPhysXJoint_t {
                pub const m_Tag: i64 = 0xC0;
                pub const m_nType: i64 = 0x0;
                pub const m_Frame1: i64 = 0x10;
                pub const m_Frame2: i64 = 0x30;
                pub const m_nBody1: i64 = 0x2;
                pub const m_nBody2: i64 = 0x4;
                pub const m_nFlags: i64 = 0x6;
                pub const m_SwingLimit: i64 = 0x74;
                pub const m_TwistLimit: i64 = 0x80;
                pub const m_flFriction: i64 = 0xAC;
                pub const m_flMaxForce: i64 = 0x6C;
                pub const m_LinearLimit: i64 = 0x54;
                pub const m_flMaxTorque: i64 = 0x98;
                pub const m_flElasticity: i64 = 0xB0;
                pub const m_flPlasticity: i64 = 0xB8;
                pub const m_bEnableCollision: i64 = 0x50;
                pub const m_flElasticDamping: i64 = 0xB4;
                pub const m_bEnableSwingLimit: i64 = 0x70;
                pub const m_bEnableTwistLimit: i64 = 0x7C;
                pub const m_flLinearFrequency: i64 = 0x9C;
                pub const m_bEnableLinearLimit: i64 = 0x53;
                pub const m_bEnableLinearMotor: i64 = 0x5C;
                pub const m_flAngularFrequency: i64 = 0xA4;
                pub const m_bEnableAngularMotor: i64 = 0x88;
                pub const m_flLinearDampingRatio: i64 = 0xA0;
                pub const m_flAngularDampingRatio: i64 = 0xA8;
                pub const m_vLinearTargetVelocity: i64 = 0x60;
                pub const m_vAngularTargetVelocity: i64 = 0x8C;
                pub const m_bIsLinearConstraintDisabled: i64 = 0x51;
                pub const m_bIsAngularConstraintDisabled: i64 = 0x52;
            }
            pub mod VPhysXRange_t {
                pub const m_flMax: i64 = 0x4;
                pub const m_flMin: i64 = 0x0;
            }
            pub mod CAddUpdateNode {
                pub const m_bApplyScale: i64 = 0x9B;
                pub const m_bUseModelSpace: i64 = 0x9A;
                pub const m_footMotionTiming: i64 = 0x94;
                pub const m_bApplyToFootMotion: i64 = 0x98;
                pub const m_bApplyChannelsSeparately: i64 = 0x99;
            }
            pub mod CAimConstraint {
                pub const m_nUpType: i64 = 0x70;
                pub const m_qAimOffset: i64 = 0x60;
            }
            pub mod CAnimDesc_Flag {
                pub const m_bDelta: i64 = 0x3;
                pub const m_bHidden: i64 = 0x2;
                pub const m_bLooping: i64 = 0x0;
                pub const m_bAllZeros: i64 = 0x1;
                pub const m_bModelDoc: i64 = 0x5;
                pub const m_bLegacyWorldspace: i64 = 0x4;
                pub const m_bAnimGraphAdditive: i64 = 0x7;
                pub const m_bImplicitSeqIgnoreDelta: i64 = 0x6;
            }
            pub mod CHitBoxSetList {
                pub const m_HitBoxSets: i64 = 0x0;
            }
            pub mod CMorphRectData {
                pub const m_nYTopDst: i64 = 0x2;
                pub const m_nXLeftDst: i64 = 0x0;
                pub const m_bundleDatas: i64 = 0x10;
                pub const m_flUWidthSrc: i64 = 0x4;
                pub const m_flVHeightSrc: i64 = 0x8;
            }
            pub mod CMotionDataSet {
                pub const m_groups: i64 = 0x0;
                pub const m_nDimensionCount: i64 = 0x18;
            }
            pub mod CNmLegacyEvent {
                pub const m_KV: i64 = 0x20;
                pub const m_animEventClassName: i64 = 0x18;
            }
            pub mod CParticleInput {

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
            pub mod CSeqCmdSeqDesc {
                pub const m_flFPS: i64 = 0x28;
                pub const m_flags: i64 = 0x10;
                pub const m_sName: i64 = 0x0;
                pub const m_eventArray: i64 = 0x48;
                pub const m_nSubCycles: i64 = 0x2C;
                pub const m_transition: i64 = 0x1C;
                pub const m_nFrameCount: i64 = 0x26;
                pub const m_activityArray: i64 = 0x60;
                pub const m_cmdLayerArray: i64 = 0x30;
                pub const m_numLocalResults: i64 = 0x2E;
                pub const m_poseSettingArray: i64 = 0x78;
                pub const m_nFrameRangeSequence: i64 = 0x24;
            }
            pub mod CSeqMultiFetch {
                pub const m_flags: i64 = 0x0;
                pub const m_nGroupSize: i64 = 0x20;
                pub const m_nLocalPose: i64 = 0x28;
                pub const m_poseKeyArray0: i64 = 0x30;
                pub const m_poseKeyArray1: i64 = 0x48;
                pub const m_bFixedBlendWeight: i64 = 0x65;
                pub const m_localReferenceArray: i64 = 0x8;
                pub const m_flFixedBlendWeightVals: i64 = 0x68;
                pub const m_bCalculatePoseParameters: i64 = 0x64;
                pub const m_nLocalCyclePoseParameter: i64 = 0x60;
            }
            pub mod CSeqTransition {
                pub const m_flFadeInTime: i64 = 0x0;
                pub const m_flFadeOutTime: i64 = 0x4;
            }
            pub mod CStringAnimTag {

            }
            pub mod AnimComponentID {
                pub const m_id: i64 = 0x0;
            }
            pub mod CAnimAttachment {
                pub const m_numInfluences: i64 = 0x78;
                pub const m_influenceIndices: i64 = 0x60;
                pub const m_influenceOffsets: i64 = 0x30;
                pub const m_influenceWeights: i64 = 0x6C;
                pub const m_influenceRotations: i64 = 0x0;
            }
            pub mod CAnimationGroup {
                pub const m_name: i64 = 0x18;
                pub const m_nFlags: i64 = 0x10;
                pub const m_decodeKey: i64 = 0x98;
                pub const m_szScripts: i64 = 0x110;
                pub const m_AdditionalExtRefs: i64 = 0x128;
                pub const m_directHSeqGroup_Handle: i64 = 0x90;
                pub const m_localHAnimArray_Handle: i64 = 0x60;
                pub const m_includedGroupArray_Handle: i64 = 0x78;
            }
            pub mod CAnimationLayer {
                pub const m_nFlags: i64 = 0x38;
                pub const m_nOrder: i64 = 0x28;
                pub const m_flCycle: i64 = 0x10;
                pub const m_bLooping: i64 = 0x34;
                pub const m_flWeight: i64 = 0x1C;
                pub const m_hSequence: i64 = 0x0;
                pub const m_nPriority: i64 = 0x48;
                pub const m_flKillRate: i64 = 0x40;
                pub const m_flKillDelay: i64 = 0x44;
                pub const m_flPrevCycle: i64 = 0xC;
                pub const m_bSequenceFinished: i64 = 0x3C;
            }
            pub mod CBaseConstraint {
                pub const m_name: i64 = 0x20;
                pub const m_slaves: i64 = 0x38;
                pub const m_targets: i64 = 0x48;
                pub const m_vUpVector: i64 = 0x28;
            }
            pub mod CFlexController {
                pub const max: i64 = 0x14;
                pub const min: i64 = 0x10;
                pub const m_szName: i64 = 0x0;
                pub const m_szType: i64 = 0x8;
            }
            pub mod CFootDefinition {
                pub const m_name: i64 = 0x0;
                pub const m_toeBoneName: i64 = 0x10;
                pub const m_vBallOffset: i64 = 0x18;
                pub const m_vHeelOffset: i64 = 0x24;
                pub const m_flFootLength: i64 = 0x30;
                pub const m_ankleBoneName: i64 = 0x8;
                pub const m_flTraceHeight: i64 = 0x38;
                pub const m_flTraceRadius: i64 = 0x3C;
                pub const m_flBindPoseDirectionMS: i64 = 0x34;
            }
            pub mod CFootTrajectory {
                pub const m_vOffset: i64 = 0x8;
                pub const m_flProgression: i64 = 0x18;
                pub const m_flRotationOffset: i64 = 0x14;
            }
            pub mod CLeafUpdateNode {

            }
            pub mod CMotionSearchDB {
                pub const m_rootNode: i64 = 0x0;
                pub const m_codeIndices: i64 = 0xA0;
                pub const m_residualQuantizer: i64 = 0x80;
            }
            pub mod CNPCPhysicsHull {
                pub const m_eType: i64 = 0x8;
                pub const m_sName: i64 = 0x0;
                pub const m_flCapsuleHeight: i64 = 0xC;
                pub const m_flCapsuleRadius: i64 = 0x10;
                pub const m_vCapsuleCenter1: i64 = 0x14;
                pub const m_vCapsuleCenter2: i64 = 0x20;
                pub const m_flGroundBoxWidth: i64 = 0x30;
                pub const m_flGroundBoxHeight: i64 = 0x2C;
            }
            pub mod CNetworkedCycle {
                pub const m_resetCount: i64 = 0x28;
                pub const m_flCycleZeroTime: i64 = 0x1C;
                pub const m_flCycleUnclamped: i64 = 0x0;
                pub const m_flCyclesPerSecond: i64 = 0x10;
                pub const m_flPrevCycleUnclamped: i64 = 0x4;
            }
            pub mod CNmContactEvent {
                pub const m_configID: i64 = 0x18;
                pub const m_audioInfo: i64 = 0x38;
                pub const m_probeBoneID: i64 = 0x20;
                pub const m_flProbeMaxDist: i64 = 0x34;
                pub const m_vBoneLocalProbeDir: i64 = 0x28;
            }
            pub mod CNmZeroPoseTask {

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
            pub mod CPulse_Constant {
                pub const m_Type: i64 = 0x0;
                pub const m_Value: i64 = 0x18;
            }
            pub mod CPulse_Variable {
                pub const m_Name: i64 = 0x0;
                pub const m_Type: i64 = 0x18;
                pub const m_Metadata: i64 = 0x50;
                pub const m_Description: i64 = 0x10;
                pub const m_nKeysSource: i64 = 0x44;
                pub const m_DefaultValue: i64 = 0x30;
                pub const m_bIsObservable: i64 = 0x49;
                pub const m_nEditorNodeID: i64 = 0x4C;
                pub const m_bIsPublicBlackboardVariable: i64 = 0x48;
            }
            pub mod CRagdollAnimTag {
                pub const m_profileName: i64 = 0x58;
            }
            pub mod CRenderSkeleton {
                pub const m_bones: i64 = 0x0;
                pub const m_boneParents: i64 = 0x30;
                pub const m_nBoneWeightCount: i64 = 0x48;
            }
            pub mod CRootUpdateNode {

            }
            pub mod CSeqPoseSetting {
                pub const m_bX: i64 = 0x34;
                pub const m_bY: i64 = 0x35;
                pub const m_bZ: i64 = 0x36;
                pub const m_eType: i64 = 0x38;
                pub const m_flValue: i64 = 0x30;
                pub const m_sAttachment: i64 = 0x10;
                pub const m_sPoseParameter: i64 = 0x0;
                pub const m_sReferenceSequence: i64 = 0x20;
            }
            pub mod CSeqSeqDescFlag {
                pub const m_bPost: i64 = 0x3;
                pub const m_bSnap: i64 = 0x1;
                pub const m_bMulti: i64 = 0x5;
                pub const m_bHidden: i64 = 0x4;
                pub const m_bLooping: i64 = 0x0;
                pub const m_bAutoplay: i64 = 0x2;
                pub const m_bModelDoc: i64 = 0xA;
                pub const m_bLegacyDelta: i64 = 0x6;
                pub const m_bLegacyRealtime: i64 = 0x9;
                pub const m_bLegacyCyclepose: i64 = 0x8;
                pub const m_bLegacyWorldspace: i64 = 0x7;
            }
            pub mod FootFixedData_t {
                pub const m_nTagIndex: i64 = 0x38;
                pub const m_nFootIndex: i64 = 0x34;
                pub const m_vToeOffset: i64 = 0x0;
                pub const m_vHeelOffset: i64 = 0x10;
                pub const m_ikChainIndex: i64 = 0x2C;
                pub const m_flMaxIKLength: i64 = 0x30;
                pub const m_nAnkleBoneIndex: i64 = 0x24;
                pub const m_nTargetBoneIndex: i64 = 0x20;
                pub const m_flMaxRotationLeft: i64 = 0x3C;
                pub const m_flMaxRotationRight: i64 = 0x40;
                pub const m_nIKAnchorBoneIndex: i64 = 0x28;
            }
            pub mod FootStepTrigger {
                pub const m_tags: i64 = 0x0;
                pub const m_nFootIndex: i64 = 0x18;
                pub const m_triggerPhase: i64 = 0x1C;
            }
            pub mod IParticleEffect {

            }
            pub mod MaterialGroup_t {
                pub const m_name: i64 = 0x0;
                pub const m_materials: i64 = 0x8;
            }
            pub mod MoodAnimation_t {
                pub const m_sName: i64 = 0x0;
                pub const m_flWeight: i64 = 0x8;
            }
            pub mod MotionBlendItem {
                pub const m_pChild: i64 = 0x0;
                pub const m_flKeyValue: i64 = 0x8;
            }
            pub mod MotionSelection {
                pub const m_nSample: i64 = 0x54;
                pub const m_flStartTime: i64 = 0x48;
                pub const m_nConfigIndex: i64 = 0x24;
                pub const m_flCycleZeroTime: i64 = 0x30;
                pub const m_flPlaybackSpeed: i64 = 0x3C;
            }
            pub mod PermModelData_t {
                pub const m_name: i64 = 0x0;
                pub const m_ExtParts: i64 = 0x60;
                pub const m_modelInfo: i64 = 0x8;
                pub const m_refMeshes: i64 = 0x78;
                pub const m_meshGroups: i64 = 0x150;
                pub const m_modelSkeleton: i64 = 0x188;
                pub const m_refAnimGroups: i64 = 0x120;
                pub const m_animGraph2Refs: i64 = 0x2C8;
                pub const m_materialGroups: i64 = 0x168;
                pub const m_refPhysicsData: i64 = 0xF0;
                pub const m_remappingTable: i64 = 0x230;
                pub const m_boneFlexDrivers: i64 = 0x260;
                pub const m_pModelConfigList: i64 = 0x278;
                pub const m_refLODGroupMasks: i64 = 0xC0;
                pub const m_refMeshGroupMasks: i64 = 0x90;
                pub const m_refPhysGroupMasks: i64 = 0xA8;
                pub const m_refSequenceGroups: i64 = 0x138;
                pub const m_vecNmSkeletonRefs: i64 = 0x2E0;
                pub const m_refAnimIncludeModels: i64 = 0x298;
                pub const m_refPhysicsHitboxData: i64 = 0x108;
                pub const m_remappingTableStarts: i64 = 0x248;
                pub const m_nDefaultMeshGroupMask: i64 = 0x180;
                pub const m_BodyGroupsHiddenInTools: i64 = 0x280;
                pub const m_lodGroupSwitchDistances: i64 = 0xD8;
                pub const m_AnimatedMaterialAttributes: i64 = 0x2B0;
            }
            pub mod PermModelInfo_t {
                pub const m_flMass: i64 = 0x34;
                pub const m_nFlags: i64 = 0x0;
                pub const m_vHullMax: i64 = 0x10;
                pub const m_vHullMin: i64 = 0x4;
                pub const m_vViewMax: i64 = 0x28;
                pub const m_vViewMin: i64 = 0x1C;
                pub const m_keyValueText: i64 = 0x50;
                pub const m_vEyePosition: i64 = 0x38;
                pub const m_sSurfaceProperty: i64 = 0x48;
                pub const m_flMaxEyeDeflection: i64 = 0x44;
            }
            pub mod PulseCursorID_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod TraceSettings_t {
                pub const m_flTraceHeight: i64 = 0x0;
                pub const m_flTraceRadius: i64 = 0x4;
            }
            pub mod AnimNodeOutputID {
                pub const m_id: i64 = 0x0;
            }
            pub mod AnimScriptHandle {
                pub const m_id: i64 = 0x0;
            }
            pub mod CAnimParamHandle {
                pub const m_type: i64 = 0x0;
                pub const m_index: i64 = 0x1;
            }
            pub mod CAnimReplayFrame {
                pub const m_timeStamp: i64 = 0x80;
                pub const m_instanceData: i64 = 0x28;
                pub const m_inputDataBlocks: i64 = 0x10;
                pub const m_localToWorldTransform: i64 = 0x60;
                pub const m_startingLocalToWorldTransform: i64 = 0x40;
            }
            pub mod CBlendUpdateNode {
                pub const m_bLoop: i64 = 0xD6;
                pub const m_damping: i64 = 0xB8;
                pub const m_bIsAngle: i64 = 0xD8;
                pub const m_children: i64 = 0x60;
                pub const m_paramIndex: i64 = 0xB4;
                pub const m_bSyncCycles: i64 = 0xD5;
                pub const m_sortedOrder: i64 = 0x78;
                pub const m_blendKeyType: i64 = 0xD0;
                pub const m_targetValues: i64 = 0x90;
                pub const m_bLockWhenWaning: i64 = 0xD7;
                pub const m_blendValueSource: i64 = 0xAC;
                pub const m_bLockBlendOnReset: i64 = 0xD4;
                pub const m_eLinearRootMotionBlendMode: i64 = 0xB0;
            }
            pub mod CConstraintSlave {
                pub const m_sName: i64 = 0x28;
                pub const m_flWeight: i64 = 0x20;
                pub const m_nBoneHash: i64 = 0x1C;
                pub const m_vBasePosition: i64 = 0x10;
                pub const m_qBaseOrientation: i64 = 0x0;
            }
            pub mod CDrawCullingData {
                pub const m_ConeAxis: i64 = 0x0;
                pub const m_ConeCutoff: i64 = 0x3;
            }
            pub mod CFootFallAnimTag {
                pub const m_foot: i64 = 0x58;
            }
            pub mod CModelConfigList {
                pub const m_Configs: i64 = 0x8;
                pub const m_bHideRenderColorInTools: i64 = 0x1;
                pub const m_bHideMaterialGroupInTools: i64 = 0x0;
            }
            pub mod CMorphBundleData {
                pub const m_ranges: i64 = 0x20;
                pub const m_offsets: i64 = 0x8;
                pub const m_flVTopSrc: i64 = 0x4;
                pub const m_flULeftSrc: i64 = 0x0;
            }
            pub mod CMorphConstraint {
                pub const m_flMax: i64 = 0x70;
                pub const m_flMin: i64 = 0x6C;
                pub const m_sTargetMorph: i64 = 0x60;
                pub const m_nSlaveChannel: i64 = 0x68;
            }
            pub mod CMoverUpdateNode {
                pub const m_damping: i64 = 0x78;
                pub const m_bAdditive: i64 = 0xA4;
                pub const m_bLimitOnly: i64 = 0xA8;
                pub const m_facingTarget: i64 = 0x90;
                pub const m_hMoveVecParam: i64 = 0x94;
                pub const m_bApplyMovement: i64 = 0xA5;
                pub const m_bApplyRotation: i64 = 0xA7;
                pub const m_bOrientMovement: i64 = 0xA6;
                pub const m_hTurnToFaceParam: i64 = 0x98;
                pub const m_flTurnToFaceLimit: i64 = 0xA0;
                pub const m_hMoveHeadingParam: i64 = 0x96;
                pub const m_flTurnToFaceOffset: i64 = 0x9C;
            }
            pub mod CNmBlendTaskBase {

            }
            pub mod CNmGraphInstance {

            }
            pub mod CNmParticleEvent {
                pub const m_tags: i64 = 0x30;
                pub const m_type: i64 = 0x1C;
                pub const m_config: i64 = 0x60;
                pub const m_target: i64 = 0x20;
                pub const m_relevance: i64 = 0x18;
                pub const m_bPlayEndCap: i64 = 0x3A;
                pub const m_attachmentType0: i64 = 0x48;
                pub const m_attachmentType1: i64 = 0x58;
                pub const m_effectForConfig: i64 = 0x68;
                pub const m_hParticleSystem: i64 = 0x28;
                pub const m_attachmentPoint0: i64 = 0x40;
                pub const m_attachmentPoint1: i64 = 0x50;
                pub const m_bDetachFromOwner: i64 = 0x39;
                pub const m_bStopImmediately: i64 = 0x38;
            }
            pub mod CNmTwoBoneIKTask {
                pub const m_targetTransform: i64 = 0x80;
                pub const m_nEffectorBoneIdx: i64 = 0x70;
                pub const m_nEffectorTargetBoneIdx: i64 = 0x74;
            }
            pub mod CParticleAnimTag {
                pub const m_bAggregate: i64 = 0x71;
                pub const m_configName: i64 = 0x68;
                pub const m_attachmentName: i64 = 0x78;
                pub const m_attachmentType: i64 = 0x80;
                pub const m_hParticleSystem: i64 = 0x58;
                pub const m_bDetachFromOwner: i64 = 0x70;
                pub const m_bStopWhenTagEnds: i64 = 0x72;
                pub const m_attachmentCP1Name: i64 = 0x88;
                pub const m_attachmentCP1Type: i64 = 0x90;
                pub const m_particleSystemName: i64 = 0x60;
                pub const m_bTagEndStopIsInstant: i64 = 0x73;
            }
            pub mod CPointConstraint {

            }
            pub mod CPulseExecCursor {

            }
            pub mod CSceneObjectData {
                pub const m_meshlets: i64 = 0x38;
                pub const m_drawCalls: i64 = 0x18;
                pub const m_drawBounds: i64 = 0x28;
                pub const m_vMaxBounds: i64 = 0xC;
                pub const m_vMinBounds: i64 = 0x0;
                pub const m_vTintColor: i64 = 0x58;
                pub const m_rtProxyDrawCalls: i64 = 0x48;
            }
            pub mod CSeqBoneMaskList {
                pub const m_sName: i64 = 0x0;
                pub const m_nLocalBoneArray: i64 = 0x10;
                pub const m_flBoneWeightArray: i64 = 0x28;
                pub const m_morphCtrlWeightArray: i64 = 0x48;
                pub const m_flDefaultMorphCtrlWeight: i64 = 0x40;
            }
            pub mod CStateUpdateData {
                pub const m_name: i64 = 0x0;
                pub const m_actions: i64 = 0x28;
                pub const m_hScript: i64 = 0x8;
                pub const m_stateID: i64 = 0x40;
                pub const m_bIsEndState: i64 = 0x0;
                pub const m_bIsStartState: i64 = 0x0;
                pub const m_bIsPassthrough: i64 = 0x0;
                pub const m_transitionIndices: i64 = 0x10;
                pub const m_bIsPassthroughRootMotion: i64 = 0x0;
                pub const m_bPreEvaluatePassthroughTransitionPath: i64 = 0x0;
            }
            pub mod CStaticPoseCache {
                pub const m_poses: i64 = 0x10;
                pub const m_nBoneCount: i64 = 0x28;
                pub const m_nMorphCount: i64 = 0x2C;
            }
            pub mod CTwistConstraint {
                pub const m_bInverse: i64 = 0x60;
                pub const m_qChildBindRotation: i64 = 0x80;
                pub const m_qParentBindRotation: i64 = 0x70;
            }
            pub mod CUnaryUpdateNode {
                pub const m_pChildNode: i64 = 0x60;
            }
            pub mod CVectorQuantizer {
                pub const m_nCentroids: i64 = 0x18;
                pub const m_nDimensions: i64 = 0x1C;
                pub const m_centroidVectors: i64 = 0x0;
            }
            pub mod PGDInstruction_t {
                pub const m_nVar: i64 = 0x4;
                pub const m_nCode: i64 = 0x0;
                pub const m_nReg0: i64 = 0x8;
                pub const m_nReg1: i64 = 0xA;
                pub const m_nReg2: i64 = 0xC;
                pub const m_nChunk: i64 = 0x14;
                pub const m_nConstIdx: i64 = 0x20;
                pub const m_nTempVarIdx: i64 = 0x26;
                pub const m_nCallInfoIndex: i64 = 0x1C;
                pub const m_nDomainValueIdx: i64 = 0x22;
                pub const m_nDestInstruction: i64 = 0x18;
                pub const m_nInvokeBindingIndex: i64 = 0x10;
                pub const m_nBlackboardReferenceIdx: i64 = 0x24;
            }
            pub mod PairedSequence_t {
                pub const m_sRole: i64 = 0x0;
                pub const m_hSequence: i64 = 0x10;
                pub const m_sSequenceName: i64 = 0x8;
            }
            pub mod PulseDocNodeID_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod SkeletonDemoDb_t {
                pub const m_CameraTrack: i64 = 0x18;
                pub const m_AnimCaptures: i64 = 0x0;
                pub const m_flRecordingTime: i64 = 0x30;
            }
            pub mod VPhysXBodyPart_t {
                pub const m_flMass: i64 = 0x4;
                pub const m_nFlags: i64 = 0x0;
                pub const m_rnShape: i64 = 0x8;
                pub const m_nReserved: i64 = 0x72;
                pub const m_flLinearDrag: i64 = 0x80;
                pub const m_flAngularDrag: i64 = 0x84;
                pub const m_flInertiaScale: i64 = 0x74;
                pub const m_flLinearDamping: i64 = 0x78;
                pub const m_flAngularDamping: i64 = 0x7C;
                pub const m_bOverrideMassCenter: i64 = 0x88;
                pub const m_vMassCenterOverride: i64 = 0x8C;
                pub const m_nCollisionAttributeIndex: i64 = 0x70;
            }
            pub mod CAnimFrameSegment {
                pub const m_container: i64 = 0x10;
                pub const m_nLocalChannel: i64 = 0x8;
                pub const m_nUniqueFrameIndex: i64 = 0x0;
                pub const m_nLocalElementMasks: i64 = 0x4;
            }
            pub mod CAnimInputDamping {
                pub const m_fSpeedScale: i64 = 0xC;
                pub const m_speedFunction: i64 = 0x8;
                pub const m_fFallingSpeedScale: i64 = 0x10;
            }
            pub mod CBinaryUpdateNode {
                pub const m_pChild1: i64 = 0x60;
                pub const m_pChild2: i64 = 0x70;
                pub const m_bResetChild1: i64 = 0x88;
                pub const m_bResetChild2: i64 = 0x89;
                pub const m_flTimingBlend: i64 = 0x84;
                pub const m_timingBehavior: i64 = 0x80;
            }
            pub mod CBodyGroupAnimTag {
                pub const m_nPriority: i64 = 0x58;
                pub const m_bodyGroupSettings: i64 = 0x60;
            }
            pub mod CBodyGroupSetting {
                pub const m_BodyGroupName: i64 = 0x0;
                pub const m_nBodyGroupOption: i64 = 0x8;
            }
            pub mod CChoiceUpdateNode {
                pub const m_weights: i64 = 0x78;
                pub const m_children: i64 = 0x60;
                pub const m_blendTime: i64 = 0xB4;
                pub const m_bCrossFade: i64 = 0xB8;
                pub const m_blendTimes: i64 = 0x90;
                pub const m_blendMethod: i64 = 0xB0;
                pub const m_bResetChosen: i64 = 0xB9;
                pub const m_choiceMethod: i64 = 0xA8;
                pub const m_choiceChangeMethod: i64 = 0xAC;
                pub const m_bDontResetSameSelection: i64 = 0xBA;
            }
            pub mod CChoreoUpdateNode {

            }
            pub mod CConstraintTarget {
                pub const m_sName: i64 = 0x40;
                pub const m_qOffset: i64 = 0x20;
                pub const m_vOffset: i64 = 0x30;
                pub const m_flWeight: i64 = 0x48;
                pub const m_nBoneHash: i64 = 0x3C;
                pub const m_bIsAttachment: i64 = 0x59;
            }
            pub mod CFootTrajectories {
                pub const m_trajectories: i64 = 0x0;
            }
            pub mod CIntAnimParameter {
                pub const m_maxValue: i64 = 0x88;
                pub const m_minValue: i64 = 0x84;
                pub const m_defaultValue: i64 = 0x80;
            }
            pub mod CLookAtUpdateNode {
                pub const m_target: i64 = 0x148;
                pub const m_paramIndex: i64 = 0x14C;
                pub const m_bResetChild: i64 = 0x150;
                pub const m_bLockWhenWaning: i64 = 0x151;
                pub const m_opFixedSettings: i64 = 0x70;
                pub const m_weightParamIndex: i64 = 0x14E;
            }
            pub mod CMotionGraphGroup {
                pub const m_searchDB: i64 = 0x0;
                pub const m_motionGraphs: i64 = 0xB8;
                pub const m_sampleToConfig: i64 = 0xE8;
                pub const m_hIsActiveScript: i64 = 0x100;
                pub const m_motionGraphConfigs: i64 = 0xD0;
            }
            pub mod CMotionSearchNode {
                pub const m_children: i64 = 0x0;
                pub const m_quantizer: i64 = 0x18;
                pub const m_sampleCodes: i64 = 0x38;
                pub const m_sampleIndices: i64 = 0x50;
                pub const m_selectableSamples: i64 = 0x68;
            }
            pub mod CNmBodyGroupEvent {
                pub const m_target: i64 = 0x18;
                pub const m_groupName: i64 = 0x20;
                pub const m_choiceName: i64 = 0x28;
            }
            pub mod CNmBoneWeightList {
                pub const m_boneIDs: i64 = 0xE0;
                pub const m_weights: i64 = 0xF8;
                pub const m_skeletonName: i64 = 0x0;
            }
            pub mod CNmCameraDOFEvent {
                pub const m_curve: i64 = 0x18;
            }
            pub mod CNmCameraFOVEvent {
                pub const m_curve: i64 = 0x18;
            }
            pub mod CNmFollowBoneTask {

            }
            pub mod CNmFrameSnapEvent {
                pub const m_frameSnapMode: i64 = 0x18;
            }
            pub mod CNmRootMotionData {
                pub const m_nNumFrames: i64 = 0x18;
                pub const m_totalDelta: i64 = 0x30;
                pub const m_transforms: i64 = 0x0;
                pub const m_flAverageLinearVelocity: i64 = 0x1C;
                pub const m_flAverageAngularVelocityRadians: i64 = 0x20;
            }
            pub mod COrientConstraint {

            }
            pub mod CParamSpanUpdater {
                pub const m_spans: i64 = 0x0;
            }
            pub mod CParentConstraint {

            }
            pub mod CParticleProperty {

            }
            pub mod CParticleVecInput {
                pub const m_nType: i64 = 0x10;
                pub const m_Gradient: i64 = 0x6A8;
                pub const m_NamedValue: i64 = 0x28;
                pub const m_vRandomMax: i64 = 0x6CC;
                pub const m_vRandomMin: i64 = 0x6C0;
                pub const m_FloatInterp: i64 = 0x510;
                pub const m_LiteralColor: i64 = 0x20;
                pub const m_nControlPoint: i64 = 0x7C;
                pub const m_vCPValueScale: i64 = 0x84;
                pub const m_vLiteralValue: i64 = 0x14;
                pub const m_flInterpInput0: i64 = 0x688;
                pub const m_flInterpInput1: i64 = 0x68C;
                pub const m_vCPRelativeDir: i64 = 0x9C;
                pub const m_vInterpOutput0: i64 = 0x690;
                pub const m_vInterpOutput1: i64 = 0x69C;
                pub const m_FloatComponentX: i64 = 0xA8;
                pub const m_FloatComponentY: i64 = 0x220;
                pub const m_FloatComponentZ: i64 = 0x398;
                pub const m_nVectorAttribute: i64 = 0x6C;
                pub const m_bFollowNamedValue: i64 = 0x68;
                pub const m_nDeltaControlPoint: i64 = 0x80;
                pub const m_vCPRelativePosition: i64 = 0x90;
                pub const m_vVectorAttributeScale: i64 = 0x70;
            }
            pub mod CProductQuantizer {
                pub const m_nDimensions: i64 = 0x18;
                pub const m_subQuantizers: i64 = 0x0;
            }
            pub mod CSeqAutoLayerFlag {
                pub const m_bPose: i64 = 0x5;
                pub const m_bPost: i64 = 0x0;
                pub const m_bLocal: i64 = 0x4;
                pub const m_bXFade: i64 = 0x2;
                pub const m_bSpline: i64 = 0x1;
                pub const m_bNoBlend: i64 = 0x3;
                pub const m_bSubtract: i64 = 0x7;
                pub const m_bFetchFrame: i64 = 0x6;
            }
            pub mod CSeqPoseParamDesc {
                pub const m_flEnd: i64 = 0x14;
                pub const m_sName: i64 = 0x0;
                pub const m_flLoop: i64 = 0x18;
                pub const m_flStart: i64 = 0x10;
                pub const m_bLooping: i64 = 0x1C;
            }
            pub mod CSeqSynthAnimDesc {
                pub const m_flags: i64 = 0x10;
                pub const m_sName: i64 = 0x0;
                pub const m_transition: i64 = 0x1C;
                pub const m_activityArray: i64 = 0x28;
                pub const m_nLocalBoneMask: i64 = 0x26;
                pub const m_nLocalBaseReference: i64 = 0x24;
            }
            pub mod CSequenceTagSpans {
                pub const m_tags: i64 = 0x8;
                pub const m_sSequenceName: i64 = 0x0;
            }
            pub mod FootFixedSettings {
                pub const m_nFootIndex: i64 = 0x3C;
                pub const m_traceSettings: i64 = 0x0;
                pub const m_bEnableTracing: i64 = 0x30;
                pub const m_flFootBaseLength: i64 = 0x20;
                pub const m_nDisableTagIndex: i64 = 0x38;
                pub const m_flMaxRotationLeft: i64 = 0x24;
                pub const m_flTraceAngleBlend: i64 = 0x34;
                pub const m_flMaxRotationRight: i64 = 0x28;
                pub const m_footstepLandedTagIndex: i64 = 0x2C;
                pub const m_vFootBaseBindPosePositionMS: i64 = 0x10;
            }
            pub mod NetVarConfigIndex {
                pub const m_index: i64 = 0x0;
            }
            pub mod NmSyncTrackTime_t {
                pub const m_nEventIdx: i64 = 0x0;
                pub const m_percentageThrough: i64 = 0x4;
            }
            pub mod ParamSpanSample_t {
                pub const m_value: i64 = 0x0;
                pub const m_flCycle: i64 = 0x14;
            }
            pub mod PerTickSettings_t {
                pub const m_bAwaken: i64 = 0x6B4;
                pub const m_updateID: i64 = 0x69C;
                pub const m_bIsClient: i64 = 0x6B6;
                pub const m_rootMotion: i64 = 0x60;
                pub const m_bTeleported: i64 = 0x6B5;
                pub const m_bIsPredicted: i64 = 0x6B7;
                pub const m_flLastTimeStep: i64 = 0x6A4;
                pub const m_flNextAnimTime: i64 = 0x6AC;
                pub const m_flPrevAnimTime: i64 = 0x6A8;
                pub const m_prevLocalToWorld: i64 = 0x20;
                pub const m_finalLocalToWorld: i64 = 0x40;
                pub const m_startingLocalToWorld: i64 = 0x0;
            }
            pub mod PhysShapeMarkup_t {
                pub const m_sHitGroup: i64 = 0x8;
                pub const m_nShapeInBody: i64 = 0x4;
                pub const m_nBodyInAggregate: i64 = 0x0;
            }
            pub mod AttachmentHandle_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod CAnimActionUpdater {

            }
            pub mod CAnimEncodedFrames {
                pub const m_nFrames: i64 = 0x10;
                pub const m_fileName: i64 = 0x0;
                pub const m_frameblockArray: i64 = 0x18;
                pub const m_nFramesPerBlock: i64 = 0x14;
                pub const m_usageDifferences: i64 = 0x30;
            }
            pub mod CAnimParameterBase {
                pub const m_id: i64 = 0x30;
                pub const m_name: i64 = 0x18;
                pub const m_group: i64 = 0x28;
                pub const m_sComment: i64 = 0x20;
                pub const m_bIsReferenced: i64 = 0x69;
                pub const m_componentName: i64 = 0x48;
                pub const m_bNetworkingRequested: i64 = 0x68;
            }
            pub mod CAnimScriptManager {
                pub const m_scriptInfo: i64 = 0x10;
            }
            pub mod CAnimUpdateNodeRef {
                pub const m_nodeIndex: i64 = 0x8;
            }
            pub mod CBlend2DUpdateNode {
                pub const m_tags: i64 = 0x78;
                pub const m_bLoop: i64 = 0xF0;
                pub const m_items: i64 = 0x60;
                pub const m_paramX: i64 = 0xDC;
                pub const m_paramY: i64 = 0xE4;
                pub const m_damping: i64 = 0xC0;
                pub const m_eBlendMode: i64 = 0xE8;
                pub const m_paramSpans: i64 = 0x90;
                pub const m_blendSourceX: i64 = 0xD8;
                pub const m_blendSourceY: i64 = 0xE0;
                pub const m_playbackSpeed: i64 = 0xEC;
                pub const m_bLockWhenWaning: i64 = 0xF2;
                pub const m_nodeItemIndices: i64 = 0xA8;
                pub const m_bLockBlendOnReset: i64 = 0xF1;
                pub const m_bAnimEventsAndTagsOnMostWeightedOnly: i64 = 0xF3;
            }
            pub mod CBoneConstraintRbf {
                pub const m_inputBones: i64 = 0x20;
                pub const m_outputBones: i64 = 0x38;
            }
            pub mod CBoolAnimParameter {
                pub const m_bDefaultValue: i64 = 0x80;
            }
            pub mod CEnumAnimParameter {
                pub const m_enumOptions: i64 = 0x90;
                pub const m_defaultValue: i64 = 0x88;
                pub const m_vecEnumReferenced: i64 = 0xA8;
            }
            pub mod CMeshletDescriptor {
                pub const m_PackedAABB: i64 = 0x0;
                pub const m_nBoneIndex: i64 = 0x16;
                pub const m_CullingData: i64 = 0x8;
                pub const m_nVertexCount: i64 = 0x14;
                pub const m_nVertexOffset: i64 = 0xC;
                pub const m_nTriangleCount: i64 = 0x15;
                pub const m_nTriangleOffset: i64 = 0x10;
            }
            pub mod CMotionGraphConfig {
                pub const m_flDuration: i64 = 0x10;
                pub const m_paramValues: i64 = 0x0;
                pub const m_nMotionIndex: i64 = 0x14;
                pub const m_nSampleCount: i64 = 0x1C;
                pub const m_nSampleStart: i64 = 0x18;
            }
            pub mod CMotionNodeBlend1D {
                pub const m_blendItems: i64 = 0x28;
                pub const m_nParamIndex: i64 = 0x40;
            }
            pub mod CMoverInstanceData {
                pub const m_Rotation: i64 = 0x1C;
                pub const m_vMovement: i64 = 0x4;
                pub const m_flDampedValue: i64 = 0x0;
                pub const m_TargetOrientation: i64 = 0x20;
            }
            pub mod CNewParticleEffect {
                pub const m_pNext: i64 = 0x10;
                pub const m_pPrev: i64 = 0x18;
                pub const m_hOwner: i64 = 0x50;
                pub const m_LastMax: i64 = 0x88;
                pub const m_LastMin: i64 = 0x7C;
                pub const m_bRemove: i64 = 0x0;
                pub const m_flScale: i64 = 0x4C;
                pub const m_RefCount: i64 = 0xD0;
                pub const m_bSimulate: i64 = 0x0;
                pub const m_bAllocated: i64 = 0x0;
                pub const m_bCanFreeze: i64 = 0x0;
                pub const m_pDebugName: i64 = 0x28;
                pub const m_pParticles: i64 = 0x20;
                pub const m_bDontRemove: i64 = 0x0;
                pub const m_bShouldSave: i64 = 0x0;
                pub const m_vSortOrigin: i64 = 0x40;
                pub const m_bForceNoDraw: i64 = 0x0;
                pub const m_bIsFirstFrame: i64 = 0x0;
                pub const m_bIsAsyncCreate: i64 = 0x0;
                pub const m_bAutoUpdateBBox: i64 = 0x0;
                pub const m_bShouldCheckFoW: i64 = 0x0;
                pub const m_bNeedsBBoxUpdate: i64 = 0x0;
                pub const m_nSplitScreenUser: i64 = 0x94;
                pub const m_bFreezeTargetState: i64 = 0x0;
                pub const m_vecAggregationCenter: i64 = 0x98;
                pub const m_bFreezeTransitionActive: i64 = 0x0;
                pub const m_bShouldPerformCullCheck: i64 = 0x0;
                pub const m_flFreezeTransitionStart: i64 = 0x70;
                pub const m_pOwningParticleProperty: i64 = 0x58;
                pub const m_bSuppressScreenSpaceEffect: i64 = 0x0;
                pub const m_flFreezeTransitionDuration: i64 = 0x74;
                pub const m_flFreezeTransitionOverride: i64 = 0x78;
                pub const m_bShouldSimulateDuringGamePaused: i64 = 0x0;
            }
            pub mod CNmChainLookatTask {

            }
            pub mod CNmFloatCurveEvent {
                pub const m_ID: i64 = 0x18;
                pub const m_curve: i64 = 0x20;
            }
            pub mod CNmGraphDefinition {
                pub const m_skeleton: i64 = 0x8;
                pub const m_nodePaths: i64 = 0x150;
                pub const m_pUserData: i64 = 0x28;
                pub const m_resources: i64 = 0x168;
                pub const m_variationID: i64 = 0x0;
                pub const m_nRootNodeIdx: i64 = 0x48;
                pub const m_externalPoseSlots: i64 = 0xC8;
                pub const m_externalGraphSlots: i64 = 0xB0;
                pub const m_controlParameterIDs: i64 = 0x50;
                pub const m_virtualParameterIDs: i64 = 0x68;
                pub const m_referencedGraphSlots: i64 = 0x98;
                pub const m_persistentNodeIndices: i64 = 0x30;
                pub const m_supportedSecondarySkeletons: i64 = 0x10;
                pub const m_virtualParameterNodeIndices: i64 = 0x80;
            }
            pub mod CNmRootMotionEvent {
                pub const m_flBlendTimeSeconds: i64 = 0x18;
            }
            pub mod CNmTargetWarpEvent {
                pub const m_rule: i64 = 0x18;
                pub const m_algorithm: i64 = 0x19;
            }
            pub mod CNmTransitionEvent {
                pub const m_ID: i64 = 0x20;
                pub const m_rule: i64 = 0x18;
            }
            pub mod CPulseCell_Unknown {
                pub const m_UnknownKeys: i64 = 0x48;
            }
            pub mod CPulse_DomainValue {
                pub const m_Value: i64 = 0x8;
                pub const m_nType: i64 = 0x0;
                pub const m_RequiredRuntimeType: i64 = 0x10;
            }
            pub mod CPulse_ResumePoint {

            }
            pub mod CPulse_TempVarInfo {
                pub const m_Name: i64 = 0x0;
                pub const m_Type: i64 = 0x10;
                pub const m_bIsObservable: i64 = 0x2C;
                pub const m_nEditorNodeID: i64 = 0x28;
            }
            pub mod CRagdollUpdateNode {
                pub const m_nWeightListIndex: i64 = 0x70;
                pub const m_poseControlMethod: i64 = 0x74;
            }
            pub mod CSeqMultiFetchFlag {
                pub const m_b0D: i64 = 0x2;
                pub const m_b1D: i64 = 0x3;
                pub const m_b2D: i64 = 0x4;
                pub const m_b2D_TRI: i64 = 0x5;
                pub const m_bCylepose: i64 = 0x1;
                pub const m_bRealtime: i64 = 0x0;
            }
            pub mod CSequenceGroupData {
                pub const m_sName: i64 = 0x10;
                pub const m_nFlags: i64 = 0x20;
                pub const m_keyValues: i64 = 0x110;
                pub const m_localNodeName: i64 = 0xE8;
                pub const m_localBoneMaskArray: i64 = 0xA0;
                pub const m_localBoneNameArray: i64 = 0xD0;
                pub const m_localScaleSetArray: i64 = 0xB8;
                pub const m_localPoseParamArray: i64 = 0xF8;
                pub const m_localS1SeqDescArray: i64 = 0x40;
                pub const m_localCmdSeqDescArray: i64 = 0x88;
                pub const m_localMultiSeqDescArray: i64 = 0x58;
                pub const m_localSequenceNameArray: i64 = 0x28;
                pub const m_localSynthAnimDescArray: i64 = 0x70;
                pub const m_localIKAutoplayLockArray: i64 = 0x120;
            }
            pub mod CTaskStatusAnimTag {

            }
            pub mod ChainToSolveData_t {
                pub const m_nChainIndex: i64 = 0x0;
                pub const m_DebugSetting: i64 = 0x38;
                pub const m_vDebugOffset: i64 = 0x40;
                pub const m_SolverSettings: i64 = 0x4;
                pub const m_TargetSettings: i64 = 0x10;
                pub const m_flDebugNormalizedValue: i64 = 0x3C;
            }
            pub mod IKSolverSettings_t {
                pub const m_SolverType: i64 = 0x0;
                pub const m_nNumIterations: i64 = 0x4;
                pub const m_EndEffectorRotationFixUpMode: i64 = 0x8;
            }
            pub mod IKTargetSettings_t {
                pub const m_Bone: i64 = 0x8;
                pub const m_TargetSource: i64 = 0x0;
                pub const m_TargetCoordSystem: i64 = 0x20;
                pub const m_AnimgraphParameterNamePosition: i64 = 0x18;
                pub const m_AnimgraphParameterNameOrientation: i64 = 0x1C;
            }
            pub mod PARTICLE_EHANDLE__ {
                pub const unused: i64 = 0x0;
            }
            pub mod PairedSequenceData {
                pub const m_vecPairedSequences: i64 = 0x0;
            }
            pub mod PermModelExtPart_t {
                pub const m_Name: i64 = 0x20;
                pub const m_nParent: i64 = 0x28;
                pub const m_refModel: i64 = 0x30;
                pub const m_Transform: i64 = 0x0;
            }
            pub mod PhysSoftbodyDesc_t {
                pub const m_Springs: i64 = 0x30;
                pub const m_Capsules: i64 = 0x48;
                pub const m_InitPose: i64 = 0x60;
                pub const m_Particles: i64 = 0x18;
                pub const m_ParticleBoneHash: i64 = 0x0;
                pub const m_ParticleBoneName: i64 = 0x78;
            }
            pub mod PulseRegisterMap_t {
                pub const m_Inparams: i64 = 0x0;
                pub const m_Outparams: i64 = 0x20;
                pub const m_InparamsWhichCanBeMoved: i64 = 0x10;
            }
            pub mod AnimationSnapshot_t {
                pub const m_modelName: i64 = 0x118;
                pub const m_nEntIndex: i64 = 0x110;
            }
            pub mod CAnimBoneDifference {
                pub const m_name: i64 = 0x0;
                pub const m_parent: i64 = 0x10;
                pub const m_posError: i64 = 0x20;
                pub const m_bHasMovement: i64 = 0x2D;
                pub const m_bHasRotation: i64 = 0x2C;
            }
            pub mod CAnimFrameBlockAnim {
                pub const m_nEndFrame: i64 = 0x4;
                pub const m_nStartFrame: i64 = 0x0;
                pub const m_segmentIndexArray: i64 = 0x8;
            }
            pub mod CAnimLocalHierarchy {
                pub const m_sBone: i64 = 0x0;
                pub const m_nEndFrame: i64 = 0x2C;
                pub const m_nPeakFrame: i64 = 0x24;
                pub const m_nTailFrame: i64 = 0x28;
                pub const m_sNewParent: i64 = 0x10;
                pub const m_nStartFrame: i64 = 0x20;
            }
            pub mod CAnimParamHandleMap {
                pub const m_list: i64 = 0x0;
            }
            pub mod CAnimSequenceParams {
                pub const m_flFadeInTime: i64 = 0x0;
                pub const m_flFadeOutTime: i64 = 0x4;
            }
            pub mod CAnimUpdateNodeBase {
                pub const m_name: i64 = 0x50;
                pub const m_nodePath: i64 = 0x18;
                pub const m_networkMode: i64 = 0x48;
            }
            pub mod CAnimUserDifference {
                pub const m_name: i64 = 0x0;
                pub const m_nType: i64 = 0x10;
            }
            pub mod CBindPoseUpdateNode {

            }
            pub mod CBoneConstraintBase {

            }
            pub mod CBoneMaskUpdateNode {
                pub const m_blendSpace: i64 = 0x9C;
                pub const m_bUseBlendScale: i64 = 0xA4;
                pub const m_hBlendParameter: i64 = 0xAC;
                pub const m_blendValueSource: i64 = 0xA8;
                pub const m_footMotionTiming: i64 = 0xA0;
                pub const m_nWeightListIndex: i64 = 0x94;
                pub const m_flRootMotionBlend: i64 = 0x98;
            }
            pub mod CChoiceInstanceData {
                pub const m_currentChoice: i64 = 0x10;
                pub const m_previousChoice: i64 = 0x1C;
                pub const m_flClipStartTime: i64 = 0x20;
                pub const m_choicePreviousCycle: i64 = 0x2C;
            }
            pub mod CChoreoInstanceData {
                pub const m_AnimOverlay: i64 = 0x0;
            }
            pub mod CFloatAnimParameter {
                pub const m_fMaxValue: i64 = 0x88;
                pub const m_fMinValue: i64 = 0x84;
                pub const m_bInterpolate: i64 = 0x8C;
                pub const m_fDefaultValue: i64 = 0x80;
            }
            pub mod CFootLockUpdateNode {
                pub const m_bResetChild: i64 = 0x153;
                pub const m_flBlendTime: i64 = 0x13C;
                pub const m_footSettings: i64 = 0xE0;
                pub const m_bApplyHipShift: i64 = 0x151;
                pub const m_flHipShiftScale: i64 = 0x138;
                pub const m_hipShiftDamping: i64 = 0xF8;
                pub const m_opFixedSettings: i64 = 0x70;
                pub const m_rootHeightDamping: i64 = 0x110;
                pub const m_flStrideCurveScale: i64 = 0x128;
                pub const m_bModulateStepHeight: i64 = 0x152;
                pub const m_flMaxRootHeightOffset: i64 = 0x140;
                pub const m_flMinRootHeightOffset: i64 = 0x144;
                pub const m_flStrideCurveLimitScale: i64 = 0x12C;
                pub const m_bApplyFootRotationLimits: i64 = 0x150;
                pub const m_bEnableRootHeightDamping: i64 = 0x155;
                pub const m_flStepHeightDecreaseScale: i64 = 0x134;
                pub const m_flStepHeightIncreaseScale: i64 = 0x130;
                pub const m_bEnableVerticalCurvedPaths: i64 = 0x154;
                pub const m_flTiltPlaneRollSpringStrength: i64 = 0x14C;
                pub const m_flTiltPlanePitchSpringStrength: i64 = 0x148;
            }
            pub mod CHitReactUpdateNode {
                pub const m_bResetChild: i64 = 0xCC;
                pub const m_hitBoneParam: i64 = 0xBE;
                pub const m_triggerParam: i64 = 0xBC;
                pub const m_hitOffsetParam: i64 = 0xC0;
                pub const m_opFixedSettings: i64 = 0x70;
                pub const m_hitStrengthParam: i64 = 0xC4;
                pub const m_hitDirectionParam: i64 = 0xC2;
                pub const m_flMinDelayBetweenHits: i64 = 0xC8;
            }
            pub mod CModelConfigElement {
                pub const m_ElementName: i64 = 0x8;
                pub const m_NestedElements: i64 = 0x10;
            }
            pub mod CMotionNodeSequence {
                pub const m_tags: i64 = 0x28;
                pub const m_hSequence: i64 = 0x40;
                pub const m_flPlaybackSpeed: i64 = 0x44;
            }
            pub mod CNmFloatChannelData {
                pub const m_setID: i64 = 0x8;
                pub const m_skeleton: i64 = 0x0;
                pub const m_compressedData: i64 = 0x28;
                pub const m_channelSettings: i64 = 0x10;
                pub const m_compressedOffsets: i64 = 0x40;
            }
            pub mod CNmOverlayBlendTask {

            }
            pub mod CParticleFloatInput {
                pub const m_Curve: i64 = 0x130;
                pub const m_nType: i64 = 0x10;
                pub const m_flLOD0: i64 = 0x98;
                pub const m_flLOD1: i64 = 0x9C;
                pub const m_flLOD2: i64 = 0xA0;
                pub const m_flLOD3: i64 = 0xA4;
                pub const m_flInput0: i64 = 0x100;
                pub const m_flInput1: i64 = 0x104;
                pub const m_nMapType: i64 = 0x14;
                pub const m_flOutput0: i64 = 0x108;
                pub const m_flOutput1: i64 = 0x10C;
                pub const m_nBiasType: i64 = 0x124;
                pub const m_NamedValue: i64 = 0x20;
                pub const m_nInputMode: i64 = 0xF8;
                pub const m_nNoiseType: i64 = 0xD0;
                pub const m_nRoundType: i64 = 0x120;
                pub const m_flRandomMax: i64 = 0x78;
                pub const m_flRandomMin: i64 = 0x74;
                pub const m_nRandomMode: i64 = 0x84;
                pub const m_nRandomSeed: i64 = 0x80;
                pub const m_flMultFactor: i64 = 0xFC;
                pub const m_flNoiseScale: i64 = 0xB4;
                pub const m_bReverseOrder: i64 = 0x70;
                pub const m_flNoiseOffset: i64 = 0xC4;
                pub const m_nControlPoint: i64 = 0x60;
                pub const m_nNoiseOctaves: i64 = 0xC8;
                pub const m_flCompareValue: i64 = 0x170;
                pub const m_flLiteralValue: i64 = 0x18;
                pub const m_nNoiseModifier: i64 = 0xD4;
                pub const m_flBiasParameter: i64 = 0x128;
                pub const m_bUseBoundsCenter: i64 = 0xF4;
                pub const m_flNoiseOutputMax: i64 = 0xB0;
                pub const m_flNoiseOutputMin: i64 = 0xAC;
                pub const m_nNoiseTurbulence: i64 = 0xCC;
                pub const m_nScalarAttribute: i64 = 0x64;
                pub const m_nVectorAttribute: i64 = 0x68;
                pub const m_nVectorComponent: i64 = 0x6C;
                pub const m_flNotchedRangeMax: i64 = 0x114;
                pub const m_flNotchedRangeMin: i64 = 0x110;
                pub const m_strSnapshotSubset: i64 = 0x90;
                pub const m_bHasRandomSignFlip: i64 = 0x7C;
                pub const m_flNoCameraFallback: i64 = 0xF0;
                pub const m_vecNoiseOffsetRate: i64 = 0xB8;
                pub const m_bNoiseImgPreviewLive: i64 = 0xE4;
                pub const m_flNoiseTurbulenceMix: i64 = 0xDC;
                pub const m_flNotchedOutputInside: i64 = 0x11C;
                pub const m_flNoiseImgPreviewScale: i64 = 0xE0;
                pub const m_flNoiseTurbulenceScale: i64 = 0xD8;
                pub const m_flNotchedOutputOutside: i64 = 0x118;
                pub const m_nNoiseInputVectorAttribute: i64 = 0xA8;
            }
            pub mod CParticleModelInput {
                pub const m_nType: i64 = 0x10;
                pub const m_NamedValue: i64 = 0x18;
                pub const m_nControlPoint: i64 = 0x58;
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
            pub mod CPulse_PublicOutput {
                pub const m_Args: i64 = 0x18;
                pub const m_Name: i64 = 0x0;
                pub const m_Description: i64 = 0x10;
            }
            pub mod CPulse_RegisterInfo {
                pub const m_Type: i64 = 0x8;
                pub const m_nReg: i64 = 0x0;
                pub const m_OriginName: i64 = 0x20;
                pub const m_nWrittenByInstruction: i64 = 0x58;
                pub const m_nLastReadByInstruction: i64 = 0x5C;
            }
            pub mod CSelectorUpdateNode {
                pub const m_tags: i64 = 0x78;
                pub const m_children: i64 = 0x60;
                pub const m_nTagIndex: i64 = 0xA8;
                pub const m_blendCurve: i64 = 0x94;
                pub const m_hParameter: i64 = 0xA4;
                pub const m_flBlendTime: i64 = 0x9C;
                pub const m_eTagBehavior: i64 = 0xAC;
                pub const m_bResetOnChange: i64 = 0xB0;
                pub const m_bLockWhenWaning: i64 = 0xB1;
                pub const m_bSyncCyclesOnChange: i64 = 0xB2;
            }
            pub mod CSequenceUpdateNode {
                pub const m_tags: i64 = 0x98;
                pub const m_duration: i64 = 0x7C;
                pub const m_hSequence: i64 = 0x78;
                pub const m_paramSpans: i64 = 0x80;
            }
            pub mod CStateActionUpdater {
                pub const m_pAction: i64 = 0x0;
                pub const m_eBehavior: i64 = 0x8;
            }
            pub mod CStateNodeStateData {
                pub const m_pChild: i64 = 0x0;
                pub const m_bExclusiveRootMotion: i64 = 0x0;
                pub const m_bExclusiveRootMotionFirstFrame: i64 = 0x0;
            }
            pub mod CSubtractUpdateNode {
                pub const m_bUseModelSpace: i64 = 0x9A;
                pub const m_footMotionTiming: i64 = 0x94;
                pub const m_bApplyToFootMotion: i64 = 0x98;
                pub const m_bApplyChannelsSeparately: i64 = 0x99;
            }
            pub mod CWarpSectionAnimTag {
                pub const m_bWarpPosition: i64 = 0x50;
                pub const m_bWarpOrientation: i64 = 0x51;
            }
            pub mod CZeroPoseUpdateNode {

            }
            pub mod ModelEmbeddedMesh_t {
                pub const m_Name: i64 = 0x0;
                pub const m_nDataBlock: i64 = 0x14;
                pub const m_nMeshIndex: i64 = 0x10;
                pub const m_nVBIBBlock: i64 = 0x68;
                pub const m_nMorphBlock: i64 = 0x18;
                pub const m_indexBuffers: i64 = 0x38;
                pub const m_toolsBuffers: i64 = 0x50;
                pub const m_nToolsVBBlock: i64 = 0x6C;
                pub const m_vertexBuffers: i64 = 0x20;
            }
            pub mod ModelSkeletonData_t {
                pub const m_nFlag: i64 = 0x48;
                pub const m_nParent: i64 = 0x18;
                pub const m_boneName: i64 = 0x0;
                pub const m_boneSphere: i64 = 0x30;
                pub const m_bonePosParent: i64 = 0x60;
                pub const m_boneRotParent: i64 = 0x78;
                pub const m_boneScaleParent: i64 = 0x90;
            }
            pub mod TwoBoneIKSettings_t {
                pub const m_flMaxTwist: i64 = 0x150;
                pub const m_targetType: i64 = 0x90;
                pub const m_nEndBoneIndex: i64 = 0x148;
                pub const m_hPositionParam: i64 = 0x124;
                pub const m_hRotationParam: i64 = 0x126;
                pub const m_bConstrainTwist: i64 = 0x14D;
                pub const m_endEffectorType: i64 = 0x0;
                pub const m_nFixedBoneIndex: i64 = 0x140;
                pub const m_targetBoneIndex: i64 = 0x120;
                pub const m_nMiddleBoneIndex: i64 = 0x144;
                pub const m_targetAttachment: i64 = 0xA0;
                pub const m_vLsFallbackHingeAxis: i64 = 0x130;
                pub const m_endEffectorAttachment: i64 = 0x10;
                pub const m_bAlwaysUseFallbackHinge: i64 = 0x128;
                pub const m_bMatchTargetOrientation: i64 = 0x14C;
            }
            pub mod VPhysXConstraint2_t {
                pub const m_nChild: i64 = 0x6;
                pub const m_nFlags: i64 = 0x0;
                pub const m_params: i64 = 0x8;
                pub const m_nParent: i64 = 0x4;
            }
            pub mod VPhysics2ShapeDef_t {
                pub const m_hulls: i64 = 0x20;
                pub const m_meshes: i64 = 0x30;
                pub const m_spheres: i64 = 0x0;
                pub const m_capsules: i64 = 0x10;
                pub const m_compounds: i64 = 0x40;
                pub const m_CollisionAttributeIndices: i64 = 0x50;
            }
            pub mod CAimCameraUpdateNode {
                pub const m_opFixedSettings: i64 = 0x80;
                pub const m_hParameterPosition: i64 = 0x70;
                pub const m_hParameterCameraOnly: i64 = 0x76;
                pub const m_hParameterOrientation: i64 = 0x72;
                pub const m_hParameterPelvisOffset: i64 = 0x74;
                pub const m_hParameterCameraClearanceDistance: i64 = 0x7C;
                pub const m_hParameterWeaponDepenetrationDelta: i64 = 0x7A;
                pub const m_hParameterWeaponDepenetrationDistance: i64 = 0x78;
            }
            pub mod CAimMatrixUpdateNode {
                pub const m_target: i64 = 0x168;
                pub const m_hSequence: i64 = 0x170;
                pub const m_paramIndex: i64 = 0x16C;
                pub const m_bResetChild: i64 = 0x174;
                pub const m_bLockWhenWaning: i64 = 0x175;
                pub const m_opFixedSettings: i64 = 0x70;
            }
            pub mod CAnimDataChannelDesc {
                pub const m_nType: i64 = 0x24;
                pub const m_nFlags: i64 = 0x20;
                pub const m_szGrouping: i64 = 0x28;
                pub const m_szDescription: i64 = 0x38;
                pub const m_szChannelClass: i64 = 0x0;
                pub const m_szVariableName: i64 = 0x10;
                pub const m_nElementMaskArray: i64 = 0x78;
                pub const m_nElementIndexArray: i64 = 0x60;
                pub const m_szElementNameArray: i64 = 0x48;
            }
            pub mod CAnimEventDefinition {
                pub const m_nFrame: i64 = 0x8;
                pub const m_flCycle: i64 = 0x10;
                pub const m_EventData: i64 = 0x18;
                pub const m_nEndFrame: i64 = 0xC;
                pub const m_flDuration: i64 = 0x14;
                pub const m_sEventName: i64 = 0x38;
                pub const m_sLegacyOptions: i64 = 0x28;
            }
            pub mod CAnimMorphDifference {
                pub const m_name: i64 = 0x0;
            }
            pub mod CBlend2DInstanceData {
                pub const m_flCycle: i64 = 0x44;
                pub const m_dampedValue: i64 = 0x8;
                pub const m_flPrevCycle: i64 = 0x48;
            }
            pub mod CEditableMotionGraph {

            }
            pub mod CFootCycleDefinition {
                pub const m_stanceCycle: i64 = 0x28;
                pub const m_footOffCycle: i64 = 0x30;
                pub const m_footLandCycle: i64 = 0x38;
                pub const m_footLiftCycle: i64 = 0x2C;
                pub const m_footStrikeCycle: i64 = 0x34;
                pub const m_vStancePositionMS: i64 = 0x0;
                pub const m_vToStrideStartPos: i64 = 0x1C;
                pub const m_flStanceDirectionMS: i64 = 0x18;
                pub const m_vMidpointPositionMS: i64 = 0xC;
            }
            pub mod CLODComponentUpdater {
                pub const m_nServerLOD: i64 = 0x30;
            }
            pub mod CNmAdditiveBlendTask {

            }
            pub mod CNmFloatChannelSet_t {
                pub const m_ID: i64 = 0x0;
                pub const m_channelIDs: i64 = 0x8;
            }
            pub mod CNmReferencePoseTask {

            }
            pub mod CParticleVariableRef {
                pub const m_variableName: i64 = 0x0;
                pub const m_variableType: i64 = 0x38;
            }
            pub mod CPathMetricEvaluator {
                pub const m_flDistance: i64 = 0x68;
                pub const m_pathTimeSamples: i64 = 0x50;
                pub const m_bExtrapolateMovement: i64 = 0x6C;
                pub const m_flMinExtrapolationSpeed: i64 = 0x70;
            }
            pub mod CPerParticleVecInput {

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
            pub mod CRenderBufferBinding {
                pub const m_hBuffer: i64 = 0x0;
                pub const m_nBindOffsetBytes: i64 = 0x10;
            }
            pub mod CSymbolAnimParameter {
                pub const m_defaultValue: i64 = 0x80;
            }
            pub mod CTiltTwistConstraint {
                pub const m_nSlaveAxis: i64 = 0x64;
                pub const m_nTargetAxis: i64 = 0x60;
            }
            pub mod CTwoBoneIKUpdateNode {
                pub const m_opFixedData: i64 = 0x70;
            }
            pub mod CVectorAnimParameter {
                pub const m_vectorType: i64 = 0x90;
                pub const m_bInterpolate: i64 = 0x8C;
                pub const m_defaultValue: i64 = 0x80;
            }
            pub mod FollowAttachmentData {
                pub const m_boneIndex: i64 = 0x0;
                pub const m_attachmentHandle: i64 = 0x4;
            }
            pub mod IKBoneNameAndIndex_t {
                pub const m_Name: i64 = 0x0;
            }
            pub mod JiggleBoneSettings_t {
                pub const m_eSimSpace: i64 = 0x28;
                pub const m_flDamping: i64 = 0xC;
                pub const m_nBoneIndex: i64 = 0x0;
                pub const m_vBoundsMaxLS: i64 = 0x10;
                pub const m_vBoundsMinLS: i64 = 0x1C;
                pub const m_flMaxTimeStep: i64 = 0x8;
                pub const m_flSpringStrength: i64 = 0x4;
            }
            pub mod ModelAnimGraph2Ref_t {
                pub const m_hGraph: i64 = 0x8;
                pub const m_sIdentifier: i64 = 0x0;
            }
            pub mod MoodAnimationLayer_t {
                pub const m_sName: i64 = 0x0;
                pub const m_flFadeIn: i64 = 0x54;
                pub const m_flFadeOut: i64 = 0x58;
                pub const m_flEndOffset: i64 = 0x4C;
                pub const m_flIntensity: i64 = 0x28;
                pub const m_flNextStart: i64 = 0x3C;
                pub const m_flStartOffset: i64 = 0x44;
                pub const m_bActiveTalking: i64 = 0x9;
                pub const m_bScaleWithInts: i64 = 0x38;
                pub const m_flDurationScale: i64 = 0x30;
                pub const m_layerAnimations: i64 = 0x10;
                pub const m_bActiveListening: i64 = 0x8;
            }
            pub mod NmContactAudioInfo_t {
                pub const m_audioTypeID: i64 = 0x8;
                pub const m_audioActionID: i64 = 0x0;
                pub const m_soundeventOverrideID: i64 = 0x10;
            }
            pub mod RenderSkeletonBone_t {
                pub const m_bbox: i64 = 0x40;
                pub const m_boneName: i64 = 0x0;
                pub const m_parentName: i64 = 0x8;
                pub const m_invBindPose: i64 = 0x10;
                pub const m_flSphereRadius: i64 = 0x58;
            }
            pub mod SkeletonBoneBounds_t {
                pub const m_vecSize: i64 = 0xC;
                pub const m_vecCenter: i64 = 0x0;
            }
            pub mod CAnimComponentUpdater {
                pub const m_id: i64 = 0x20;
                pub const m_name: i64 = 0x18;
                pub const m_networkMode: i64 = 0x24;
                pub const m_bStartEnabled: i64 = 0x28;
            }
            pub mod CAnimEncodeDifference {
                pub const m_boneArray: i64 = 0x0;
                pub const m_userArray: i64 = 0x30;
                pub const m_morphArray: i64 = 0x18;
                pub const m_bHasUserBitArray: i64 = 0x90;
                pub const m_bHasMorphBitArray: i64 = 0x78;
                pub const m_bHasMovementBitArray: i64 = 0x60;
                pub const m_bHasRotationBitArray: i64 = 0x48;
            }
            pub mod CAnimGraphDebugReplay {
                pub const m_frameList: i64 = 0x48;
                pub const m_frameCount: i64 = 0x68;
                pub const m_startIndex: i64 = 0x60;
                pub const m_writeIndex: i64 = 0x64;
                pub const m_animGraphFileName: i64 = 0x40;
            }
            pub mod CAnimMotorUpdaterBase {
                pub const m_name: i64 = 0x10;
                pub const m_bDefault: i64 = 0x18;
            }
            pub mod CAnimUpdateSharedData {
                pub const m_nodes: i64 = 0x10;
                pub const m_settings: i64 = 0x78;
                pub const m_pSkeleton: i64 = 0xB0;
                pub const m_components: i64 = 0x48;
                pub const m_nodeIndexMap: i64 = 0x28;
                pub const m_rootNodePath: i64 = 0xB8;
                pub const m_scriptManager: i64 = 0x70;
                pub const m_pStaticPoseCache: i64 = 0xA8;
                pub const m_pParamListUpdater: i64 = 0x60;
                pub const m_pTagManagerUpdater: i64 = 0x68;
            }
            pub mod CClothSettingsAnimTag {
                pub const m_flEaseIn: i64 = 0x5C;
                pub const m_flEaseOut: i64 = 0x60;
                pub const m_nVertexSet: i64 = 0x68;
                pub const m_flStiffness: i64 = 0x58;
            }
            pub mod CEmitTagActionUpdater {
                pub const m_nTagIndex: i64 = 0x18;
                pub const m_bIsZeroDuration: i64 = 0x1C;
            }
            pub mod CFollowPathUpdateNode {
                pub const m_hParam: i64 = 0xAC;
                pub const m_flScale: i64 = 0x7C;
                pub const m_flMaxAngle: i64 = 0x84;
                pub const m_flMinAngle: i64 = 0x80;
                pub const m_bScaleSpeed: i64 = 0x7A;
                pub const m_bTurnToFace: i64 = 0xB4;
                pub const m_turnDamping: i64 = 0x90;
                pub const m_facingTarget: i64 = 0xA8;
                pub const m_flBlendOutTime: i64 = 0x74;
                pub const m_bStopFeetAtGoal: i64 = 0x79;
                pub const m_flTurnToFaceOffset: i64 = 0xB0;
                pub const m_flSpeedScaleBlending: i64 = 0x88;
                pub const m_bBlockNonPathMovement: i64 = 0x78;
            }
            pub mod CHandshakeAnimTagBase {
                pub const m_bIsDisableTag: i64 = 0x50;
            }
            pub mod CJiggleBoneUpdateNode {
                pub const m_opFixedData: i64 = 0x70;
            }
            pub mod CJumpHelperUpdateNode {
                pub const m_bScaleSpeed: i64 = 0xD3;
                pub const m_hTargetParam: i64 = 0xB0;
                pub const m_flJumpEndCycle: i64 = 0xC8;
                pub const m_bTranslationAxis: i64 = 0xD0;
                pub const m_flJumpStartCycle: i64 = 0xC4;
                pub const m_eCorrectionMethod: i64 = 0xCC;
                pub const m_flOriginalJumpDuration: i64 = 0xC0;
                pub const m_flOriginalJumpMovement: i64 = 0xB4;
            }
            pub mod CLeanMatrixUpdateNode {
                pub const m_poses: i64 = 0x80;
                pub const m_damping: i64 = 0xA8;
                pub const m_hSequence: i64 = 0xE0;
                pub const m_flMaxValue: i64 = 0xE4;
                pub const m_paramIndex: i64 = 0xC4;
                pub const m_blendSource: i64 = 0xC0;
                pub const m_frameCorners: i64 = 0x5C;
                pub const m_verticalAxis: i64 = 0xC8;
                pub const m_horizontalAxis: i64 = 0xD4;
                pub const m_nSequenceMaxFrame: i64 = 0xE8;
            }
            pub mod CLookComponentUpdater {
                pub const m_hLookPitch: i64 = 0x3A;
                pub const m_hLookTarget: i64 = 0x40;
                pub const m_hLookHeading: i64 = 0x34;
                pub const m_hLookDistance: i64 = 0x3C;
                pub const m_hLookDirection: i64 = 0x3E;
                pub const m_bNetworkLookTarget: i64 = 0x44;
                pub const m_hLookHeadingVelocity: i64 = 0x38;
                pub const m_hLookTargetWorldSpace: i64 = 0x42;
                pub const m_hLookHeadingNormalized: i64 = 0x36;
            }
            pub mod CNmCachedPoseReadTask {

            }
            pub mod CNmSyncTrack__Event_t {
                pub const m_ID: i64 = 0x0;
                pub const m_duration: i64 = 0xC;
                pub const m_startTime: i64 = 0x8;
            }
            pub mod CPathAnimMotorUpdater {

            }
            pub mod CPathHelperUpdateNode {
                pub const m_flStoppingRadius: i64 = 0x70;
                pub const m_flStoppingSpeedScale: i64 = 0x74;
            }
            pub mod CPulseCell_LimitCount {
                pub const m_nLimitCount: i64 = 0x48;
            }
            pub mod CRemapValueUpdateItem {
                pub const m_hParamIn: i64 = 0x0;
                pub const m_hParamOut: i64 = 0x2;
                pub const m_flMaxInputValue: i64 = 0x8;
                pub const m_flMinInputValue: i64 = 0x4;
                pub const m_flMaxOutputValue: i64 = 0x10;
                pub const m_flMinOutputValue: i64 = 0xC;
            }
            pub mod CSpeedScaleUpdateNode {
                pub const m_paramIndex: i64 = 0x70;
            }
            pub mod CStopAtGoalUpdateNode {
                pub const m_damping: i64 = 0x88;
                pub const m_flMaxScale: i64 = 0x7C;
                pub const m_flMinScale: i64 = 0x80;
                pub const m_flInnerRadius: i64 = 0x78;
                pub const m_flOuterRadius: i64 = 0x74;
            }
            pub mod CTargetWarpUpdateNode {
                pub const m_eAngleMode: i64 = 0x74;
                pub const m_flMaxAngle: i64 = 0x94;
                pub const m_bWarpAroundCenter: i64 = 0x90;
                pub const m_eCorrectionMethod: i64 = 0x84;
                pub const m_hMoveHeadingParameter: i64 = 0x7E;
                pub const m_bOnlyWarpWhenTagIsFound: i64 = 0x8E;
                pub const m_eTargetWarpTimingMethod: i64 = 0x88;
                pub const m_hTargetPositionParameter: i64 = 0x78;
                pub const m_hTargetUpVectorParameter: i64 = 0x7A;
                pub const m_bTargetPositionIsWorldSpace: i64 = 0x8D;
                pub const m_hDesiredMoveHeadingParameter: i64 = 0x80;
                pub const m_hTargetFacePositionParameter: i64 = 0x7C;
                pub const m_bTargetFacePositionIsWorldSpace: i64 = 0x8C;
                pub const m_bWarpOrientationDuringTranslation: i64 = 0x8F;
            }
            pub mod CTaskHandshakeAnimTag {

            }
            pub mod CTransitionUpdateData {
                pub const m_bDisabled: i64 = 0x0;
                pub const m_srcStateIndex: i64 = 0x0;
                pub const m_destStateIndex: i64 = 0x1;
                pub const m_nHandshakeMaskToDisableFirst: i64 = 0x0;
            }
            pub mod CTurnHelperUpdateNode {
                pub const m_facingTarget: i64 = 0x74;
                pub const m_turnDuration: i64 = 0x7C;
                pub const m_manualTurnOffset: i64 = 0x84;
                pub const m_bMatchChildDuration: i64 = 0x80;
                pub const m_turnStartTimeOffset: i64 = 0x78;
                pub const m_bUseManualTurnOffset: i64 = 0x88;
            }
            pub mod CVirtualAnimParameter {
                pub const m_eParamType: i64 = 0x78;
                pub const m_expressionString: i64 = 0x70;
            }
            pub mod ModelBoneFlexDriver_t {
                pub const m_boneName: i64 = 0x0;
                pub const m_controls: i64 = 0x10;
                pub const m_boneNameToken: i64 = 0x8;
            }
            pub mod ModelMeshBufferData_t {
                pub const m_nBlockIndex: i64 = 0x0;
                pub const m_nBufferUsage: i64 = 0x14;
                pub const m_nElementCount: i64 = 0x4;
                pub const m_bCompressedZSTD: i64 = 0xF;
                pub const m_bCreateBufferSRV: i64 = 0x10;
                pub const m_bCreateBufferUAV: i64 = 0x11;
                pub const m_bCreateRawBuffer: i64 = 0x12;
                pub const m_inputLayoutFields: i64 = 0x18;
                pub const m_bMeshoptCompressed: i64 = 0xC;
                pub const m_bCreatePooledBuffer: i64 = 0x13;
                pub const m_nElementSizeInBytes: i64 = 0x8;
                pub const m_bMeshoptIndexSequence: i64 = 0xD;
                pub const m_nMeshoptMeshletEncodeVersion: i64 = 0xE;
            }
            pub mod SkeletonAnimCapture_t {
                pub const m_Frames: i64 = 0xA8;
                pub const m_ModelName: i64 = 0x20;
                pub const m_nEntIndex: i64 = 0x0;
                pub const m_bPredicted: i64 = 0x64;
                pub const m_nEntParent: i64 = 0x4;
                pub const m_CaptureName: i64 = 0x28;
                pub const m_ModelBindPose: i64 = 0x30;
                pub const m_FeModelInitPose: i64 = 0x48;
                pub const m_nFlexControllers: i64 = 0x60;
                pub const m_ImportedCollision: i64 = 0x8;
            }
            pub mod VPhysXAggregateData_t {
                pub const m_parts: i64 = 0x80;
                pub const m_joints: i64 = 0xC8;
                pub const m_nFlags: i64 = 0x0;
                pub const m_bindPose: i64 = 0x68;
                pub const m_pFeModel: i64 = 0xE0;
                pub const m_boneNames: i64 = 0x20;
                pub const m_bonesHash: i64 = 0x8;
                pub const m_indexHash: i64 = 0x50;
                pub const m_indexNames: i64 = 0x38;
                pub const m_boneParents: i64 = 0xE8;
                pub const m_nRefCounter: i64 = 0x2;
                pub const m_constraints2: i64 = 0xB0;
                pub const m_shapeMarkups: i64 = 0x98;
                pub const m_debugPartNames: i64 = 0x130;
                pub const m_bCompoundsPacked: i64 = 0x4;
                pub const m_embeddedKeyvalues: i64 = 0x148;
                pub const m_collisionAttributes: i64 = 0x118;
                pub const m_surfacePropertyHashes: i64 = 0x100;
            }
            pub mod CAnimGraphModelBinding {
                pub const m_modelName: i64 = 0x8;
                pub const m_pSharedData: i64 = 0x10;
            }
            pub mod CAnimTagManagerUpdater {
                pub const m_tags: i64 = 0x38;
            }
            pub mod CBlendNodeInstanceData {
                pub const m_flCycle: i64 = 0x4;
                pub const m_flDuration: i64 = 0x1C;
                pub const m_resetCount: i64 = 0x20;
                pub const m_dampedValue: i64 = 0x0;
                pub const m_flBlendValue: i64 = 0x10;
                pub const m_flPlaybackRate: i64 = 0xC;
                pub const m_flCycleZeroTime: i64 = 0x8;
            }
            pub mod CConcreteAnimParameter {
                pub const m_bAutoReset: i64 = 0x79;
                pub const m_bGameWritable: i64 = 0x7A;
                pub const m_previewButton: i64 = 0x70;
                pub const m_bGraphWritable: i64 = 0x7B;
                pub const m_eNetworkSetting: i64 = 0x74;
                pub const m_bUseMostRecentValue: i64 = 0x78;
            }
            pub mod CCycleClipInstanceData {
                pub const m_flCycle: i64 = 0x0;
                pub const m_flPrevCycle: i64 = 0xC;
            }
            pub mod CDampedValueUpdateItem {
                pub const m_damping: i64 = 0x0;
                pub const m_hParamIn: i64 = 0x20;
                pub const m_hParamOut: i64 = 0x22;
            }
            pub mod CDirectPlaybackTagData {
                pub const m_tags: i64 = 0x8;
                pub const m_sequenceName: i64 = 0x0;
            }
            pub mod CFootPinningUpdateNode {
                pub const m_params: i64 = 0xB0;
                pub const m_bResetChild: i64 = 0xC8;
                pub const m_eTimingSource: i64 = 0xA8;
                pub const m_poseOpFixedData: i64 = 0x78;
            }
            pub mod CFootstepLandedAnimTag {
                pub const m_BoneName: i64 = 0x70;
                pub const m_FootstepType: i64 = 0x58;
                pub const m_OverrideSoundName: i64 = 0x60;
                pub const m_footstepJumpPhase: i64 = 0x78;
                pub const m_DebugAnimSourceString: i64 = 0x68;
            }
            pub mod CInputStreamUpdateNode {

            }
            pub mod CMotionGraphUpdateNode {
                pub const m_pMotionGraph: i64 = 0x58;
            }
            pub mod CMotionMetricEvaluator {
                pub const m_means: i64 = 0x18;
                pub const m_flWeight: i64 = 0x48;
                pub const m_standardDeviations: i64 = 0x30;
                pub const m_nDimensionStartIndex: i64 = 0x4C;
            }
            pub mod CNmCachedPoseWriteTask {

            }
            pub mod CNmModelSpaceBlendTask {

            }
            pub mod CNmOrNode__CDefinition {
                pub const m_conditionNodeIndices: i64 = 0x10;
            }
            pub mod CPerParticleFloatInput {

            }
            pub mod CPhysSurfaceProperties {
                pub const m_name: i64 = 0x0;
                pub const m_bHidden: i64 = 0x18;
                pub const m_physics: i64 = 0x28;
                pub const m_nameHash: i64 = 0x8;
                pub const m_audioParams: i64 = 0xA8;
                pub const m_audioSounds: i64 = 0x48;
                pub const m_description: i64 = 0x20;
                pub const m_baseNameHash: i64 = 0xC;
                pub const m_vehicleParams: i64 = 0x40;
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
            pub mod CPulseRuntimeMethodArg {
                pub const m_Name: i64 = 0x0;
                pub const m_Type: i64 = 0x40;
                pub const m_Description: i64 = 0x38;
            }
            pub mod CSingleFrameUpdateNode {
                pub const m_actions: i64 = 0x58;
                pub const m_flCycle: i64 = 0x78;
                pub const m_hSequence: i64 = 0x74;
                pub const m_hPoseCacheHandle: i64 = 0x70;
            }
            pub mod CSlopeComponentUpdater {
                pub const m_hSlopeAngle: i64 = 0x38;
                pub const m_hSlopeNormal: i64 = 0x40;
                pub const m_hSlopeHeading: i64 = 0x3E;
                pub const m_flTraceDistance: i64 = 0x34;
                pub const m_hSlopeAngleSide: i64 = 0x3C;
                pub const m_hSlopeAngleFront: i64 = 0x3A;
                pub const m_hSlopeNormal_WorldSpace: i64 = 0x42;
            }
            pub mod CSolveIKTargetHandle_t {
                pub const m_positionHandle: i64 = 0x0;
                pub const m_orientationHandle: i64 = 0x2;
            }
            pub mod CStanceScaleUpdateNode {
                pub const m_hParam: i64 = 0x70;
            }
            pub mod CStateNodeInstanceData {
                pub const m_resetCount: i64 = 0x3C;
                pub const m_stateWeights: i64 = 0x0;
                pub const m_currentStateStartTime: i64 = 0x20;
                pub const m_vTransitionVelocityDeltaWS: i64 = 0x8;
            }
            pub mod NmSyncTrackTimeRange_t {
                pub const m_endTime: i64 = 0x8;
                pub const m_startTime: i64 = 0x0;
            }
            pub mod PulseGraphInstanceID_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod PulseRuntimeVarIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod RenderHairStrandInfo_t {
                pub const m_nPackedBaseUv: i64 = 0x18;
                pub const m_nDataOffset_Segments: i64 = 0x24;
                pub const m_vGuideBary_vBaseBary: i64 = 0x8;
                pub const m_nPackedSurfaceNormalOs: i64 = 0x1C;
                pub const m_nPackedSurfaceTangentOs: i64 = 0x20;
                pub const m_vRootOffset_flLengthScale: i64 = 0x10;
                pub const m_nGuideHairIndices_nSurfaceTriIndex: i64 = 0x0;
            }
            pub mod SelectorInstanceData_t {
                pub const m_weights: i64 = 0x0;
                pub const m_currentIndex: i64 = 0x14;
                pub const m_previousIndex: i64 = 0x18;
                pub const m_currentIndexStartTime: i64 = 0x8;
            }
            pub mod AnimationSnapshotBase_t {
                pub const m_DecodeDump: i64 = 0x98;
                pub const m_flRealTime: i64 = 0x0;
                pub const m_rootToWorld: i64 = 0x10;
                pub const m_SnapshotType: i64 = 0x90;
                pub const m_boneSetupMask: i64 = 0x48;
                pub const m_bHasDecodeDump: i64 = 0x94;
                pub const m_boneTransforms: i64 = 0x60;
                pub const m_flexControllers: i64 = 0x78;
                pub const m_bBonesInWorldSpace: i64 = 0x40;
            }
            pub mod CActionComponentUpdater {
                pub const m_actions: i64 = 0x30;
            }
            pub mod CAnimGraphSettingsGroup {

            }
            pub mod CAnimationGraphInstance {
                pub const m_bTagDispatchDirty: i64 = 0x329;
            }
            pub mod CBasePulseGraphInstance {

            }
            pub mod CCycleControlUpdateNode {
                pub const m_paramIndex: i64 = 0x74;
                pub const m_valueSource: i64 = 0x70;
                pub const m_bLockWhenWaning: i64 = 0x76;
            }
            pub mod CFollowPathInstanceData {
                pub const m_flTurnAmount: i64 = 0xC;
                pub const m_flLastPathTime: i64 = 0x1C;
                pub const m_dampedTurnValue: i64 = 0x8;
                pub const m_flPredictionScale: i64 = 0x10;
                pub const m_xLastPredictedTransformsDeltas: i64 = 0x0;
            }
            pub mod CFollowTargetUpdateNode {
                pub const m_opFixedData: i64 = 0x70;
                pub const m_hParameterPosition: i64 = 0x88;
                pub const m_hParameterOrientation: i64 = 0x8A;
            }
            pub mod CLeanMatrixInstanceData {
                pub const m_flValueX: i64 = 0x4;
                pub const m_flValueY: i64 = 0x0;
            }
            pub mod CMaterialDrawDescriptor {
                pub const m_flAlpha: i64 = 0x10;
                pub const m_material: i64 = 0x118;
                pub const m_vTintColor: i64 = 0x4;
                pub const m_flUvDensity: i64 = 0x0;
                pub const m_indexBuffer: i64 = 0xC8;
                pub const m_nBaseVertex: i64 = 0x54;
                pub const m_nIndexCount: i64 = 0x60;
                pub const m_nStartIndex: i64 = 0x5C;
                pub const m_nNumMeshlets: i64 = 0x18;
                pub const m_nVertexCount: i64 = 0x58;
                pub const m_rootBvhNodes: i64 = 0x40;
                pub const m_nFirstMeshlet: i64 = 0x20;
                pub const m_nPrimitiveType: i64 = 0x50;
                pub const m_rigidMeshParts: i64 = 0x30;
                pub const m_meshletPackedIVB: i64 = 0xE8;
                pub const m_nAppliedIndexOffset: i64 = 0x24;
                pub const m_nMeshletPackedIVBIndex: i64 = 0x2D;
                pub const m_nDepthVertexBufferIndex: i64 = 0x2C;
                pub const m_nEmissivePrimitiveCount: i64 = 0x28;
            }
            pub mod CNmAndNode__CDefinition {
                pub const m_conditionNodeIndices: i64 = 0x10;
            }
            pub mod CNmNotNode__CDefinition {
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmOrientationWarpEvent {

            }
            pub mod CParticleTransformInput {
                pub const m_nType: i64 = 0x10;
                pub const m_NamedValue: i64 = 0x18;
                pub const m_nControlPoint: i64 = 0x5C;
                pub const m_bUseOrientation: i64 = 0x5A;
                pub const m_bFollowNamedValue: i64 = 0x58;
                pub const m_bSupportsDisabled: i64 = 0x59;
                pub const m_flEndCPGrowthTime: i64 = 0x64;
                pub const m_nControlPointRangeMax: i64 = 0x60;
            }
            pub mod CPulseCell_Inflow_Yield {
                pub const m_UnyieldResume: i64 = 0xD8;
            }
            pub mod CPulseCell_ReturnValues {

            }
            pub mod CPulse_InstructionDebug {
                pub const m_nFlowNodeID: i64 = 0x0;
                pub const m_nValueNodeID: i64 = 0x4;
                pub const m_SequencePointName: i64 = 0x8;
            }
            pub mod CPulse_OutputConnection {
                pub const m_Param: i64 = 0x30;
                pub const m_TargetInput: i64 = 0x20;
                pub const m_SourceOutput: i64 = 0x0;
                pub const m_TargetEntity: i64 = 0x10;
            }
            pub mod CSequenceUpdateNodeBase {
                pub const m_bLoop: i64 = 0x70;
                pub const m_playbackSpeed: i64 = 0x6C;
            }
            pub mod CSolveIKChainUpdateNode {
                pub const m_opFixedData: i64 = 0x88;
                pub const m_targetHandles: i64 = 0x70;
            }
            pub mod CStateMachineUpdateNode {
                pub const m_stateData: i64 = 0xC8;
                pub const m_stateMachine: i64 = 0x70;
                pub const m_transitionData: i64 = 0xE0;
                pub const m_bBlockWaningTags: i64 = 0xFC;
                pub const m_bResetWhenActivated: i64 = 0xFE;
                pub const m_bLockStateWhenWaning: i64 = 0xFD;
            }
            pub mod CStaticPoseCacheBuilder {

            }
            pub mod CTurnHelperInstanceData {
                pub const m_duration: i64 = 0x8;
                pub const m_turnAmount: i64 = 0x0;
                pub const m_turnStartTime: i64 = 0x4;
            }
            pub mod CWarpSectionAnimTagBase {

            }
            pub mod HitReactFixedSettings_t {
                pub const m_flWhipDelay: i64 = 0x20;
                pub const m_flHipDipDelay: i64 = 0x40;
                pub const m_nHipBoneIndex: i64 = 0x30;
                pub const m_flMaxImpactForce: i64 = 0x8;
                pub const m_flMinImpactForce: i64 = 0xC;
                pub const m_flSpringStrength: i64 = 0x24;
                pub const m_nWeightListIndex: i64 = 0x0;
                pub const m_flMaxAngleRadians: i64 = 0x2C;
                pub const m_flWhipImpactScale: i64 = 0x10;
                pub const m_flPropagationScale: i64 = 0x1C;
                pub const m_nEffectedBoneCount: i64 = 0x4;
                pub const m_flDistanceFadeScale: i64 = 0x18;
                pub const m_flHipDipImpactScale: i64 = 0x3C;
                pub const m_flWhipSpringStrength: i64 = 0x28;
                pub const m_flCounterRotationScale: i64 = 0x14;
                pub const m_flHipDipSpringStrength: i64 = 0x38;
                pub const m_flHipBoneTranslationScale: i64 = 0x34;
            }
            pub mod IAnimationGraphInstance {

            }
            pub mod IKDemoCaptureSettings_t {
                pub const m_eMode: i64 = 0x8;
                pub const m_oneBoneEnd: i64 = 0x20;
                pub const m_ikChainName: i64 = 0x10;
                pub const m_oneBoneStart: i64 = 0x18;
                pub const m_parentBoneName: i64 = 0x0;
            }
            pub mod LookAtOpFixedSettings_t {
                pub const m_bones: i64 = 0x98;
                pub const m_damping: i64 = 0x80;
                pub const m_attachment: i64 = 0x0;
                pub const m_flYawLimit: i64 = 0xB0;
                pub const m_flPitchLimit: i64 = 0xB4;
                pub const m_bUseHysteresis: i64 = 0xC3;
                pub const m_bRotateYawForward: i64 = 0xC0;
                pub const m_bTargetIsPosition: i64 = 0xC2;
                pub const m_bMaintainUpDirection: i64 = 0xC1;
                pub const m_flHysteresisInnerAngle: i64 = 0xB8;
                pub const m_flHysteresisOuterAngle: i64 = 0xBC;
            }
            pub mod NmCompressionSettings_t {
                pub const m_scaleRange: i64 = 0x18;
                pub const m_bIsScaleStatic: i64 = 0x42;
                pub const m_constantRotation: i64 = 0x30;
                pub const m_nTrackReadOffset: i64 = 0x20;
                pub const m_bIsRotationStatic: i64 = 0x40;
                pub const m_translationRangeX: i64 = 0x0;
                pub const m_translationRangeY: i64 = 0x8;
                pub const m_translationRangeZ: i64 = 0x10;
                pub const m_bIsTranslationStatic: i64 = 0x41;
            }
            pub mod PulseCursorYieldToken_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod PulseRuntimeCellIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod SignatureOutflow_Resume {

            }
            pub mod CAnimDemoCaptureSettings {
                pub const m_bones: i64 = 0x50;
                pub const m_ikChains: i64 = 0x68;
                pub const m_baseSequence: i64 = 0x40;
                pub const m_boneSelectionMode: i64 = 0x4C;
                pub const m_nBaseSequenceFrame: i64 = 0x48;
                pub const m_vecErrorRangeSplineScale: i64 = 0x10;
                pub const m_flIkRotation_MaxSplineError: i64 = 0x18;
                pub const m_vecErrorRangeSplineRotation: i64 = 0x0;
                pub const m_flIkTranslation_MaxSplineError: i64 = 0x1C;
                pub const m_vecErrorRangeQuantizationScale: i64 = 0x30;
                pub const m_vecErrorRangeSplineTranslation: i64 = 0x8;
                pub const m_flIkRotation_MaxQuantizationError: i64 = 0x38;
                pub const m_vecErrorRangeQuantizationRotation: i64 = 0x20;
                pub const m_flIkTranslation_MaxQuantizationError: i64 = 0x3C;
                pub const m_vecErrorRangeQuantizationTranslation: i64 = 0x28;
            }
            pub mod CAnimStateMachineUpdater {
                pub const m_states: i64 = 0x8;
                pub const m_transitions: i64 = 0x20;
                pub const m_startStateIndex: i64 = 0x50;
            }
            pub mod CExpressionActionUpdater {
                pub const m_hParam: i64 = 0x18;
                pub const m_hScript: i64 = 0x1C;
                pub const m_eParamType: i64 = 0x1A;
            }
            pub mod CNmClipNode__CDefinition {
                pub const m_graphEvents: i64 = 0x18;
                pub const m_nDataSlotIdx: i64 = 0x14;
                pub const m_bAllowLooping: i64 = 0x13;
                pub const m_bSampleRootMotion: i64 = 0x12;
                pub const m_flSpeedMultiplier: i64 = 0x40;
                pub const m_nStartSyncEventOffset: i64 = 0x44;
                pub const m_nResetTimeValueNodeIdx: i64 = 0x16;
                pub const m_nPlayInReverseValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmContactAudioTypeVData {

            }
            pub mod CNmPoseNode__CDefinition {

            }
            pub mod CParticleRemapFloatInput {

            }
            pub mod CPulseBreakpointLocation {
                pub const m_NodeID: i64 = 0x0;
                pub const m_PortName: i64 = 0x18;
                pub const m_bDeferBreak: i64 = 0x28;
                pub const m_SequencePoint: i64 = 0x8;
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
            pub mod CQuaternionAnimParameter {
                pub const m_bInterpolate: i64 = 0x90;
                pub const m_defaultValue: i64 = 0x80;
            }
            pub mod CRagdollComponentUpdater {
                pub const m_boneNames: i64 = 0x78;
                pub const m_boneIndices: i64 = 0x60;
                pub const m_weightLists: i64 = 0x90;
                pub const m_flMaxStretch: i64 = 0xC8;
                pub const m_ragdollNodePaths: i64 = 0x30;
                pub const m_boneToWeightIndices: i64 = 0xA8;
                pub const m_flSpringFrequencyMax: i64 = 0xC4;
                pub const m_flSpringFrequencyMin: i64 = 0xC0;
                pub const m_followAttachmentNodePaths: i64 = 0x48;
                pub const m_bSolidCollisionAtZeroWeight: i64 = 0xCC;
            }
            pub mod CSequenceFinishedAnimTag {
                pub const m_sequenceName: i64 = 0x58;
            }
            pub mod CStateNodeTransitionData {
                pub const m_curve: i64 = 0x0;
                pub const m_bReset: i64 = 0x0;
                pub const m_blendDuration: i64 = 0x8;
                pub const m_resetCycleValue: i64 = 0x10;
                pub const m_resetCycleOption: i64 = 0x0;
            }
            pub mod JiggleBoneSettingsList_t {
                pub const m_boneSettings: i64 = 0x0;
            }
            pub mod ParticleAttributeIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod PulseRuntimeChunkIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod VPhysXConstraintParams_t {
                pub const m_axes: i64 = 0x1C;
                pub const m_nType: i64 = 0x0;
                pub const m_anchor: i64 = 0x4;
                pub const m_nFlags: i64 = 0x3;
                pub const m_maxForce: i64 = 0x3C;
                pub const m_maxTorque: i64 = 0x40;
                pub const m_driveSpringX: i64 = 0xBC;
                pub const m_driveSpringY: i64 = 0xC0;
                pub const m_driveSpringZ: i64 = 0xC4;
                pub const m_goalPosition: i64 = 0x94;
                pub const m_driveDampingX: i64 = 0xC8;
                pub const m_driveDampingY: i64 = 0xCC;
                pub const m_driveDampingZ: i64 = 0xD0;
                pub const m_nRotateMotion: i64 = 0x2;
                pub const m_goalOrientation: i64 = 0xA0;
                pub const m_driveSpringSlerp: i64 = 0xDC;
                pub const m_driveSpringSwing: i64 = 0xD8;
                pub const m_driveSpringTwist: i64 = 0xD4;
                pub const m_linearLimitValue: i64 = 0x44;
                pub const m_nTranslateMotion: i64 = 0x1;
                pub const m_swing1LimitValue: i64 = 0x74;
                pub const m_swing2LimitValue: i64 = 0x84;
                pub const m_driveDampingSlerp: i64 = 0xE8;
                pub const m_driveDampingSwing: i64 = 0xE4;
                pub const m_driveDampingTwist: i64 = 0xE0;
                pub const m_linearLimitSpring: i64 = 0x4C;
                pub const m_swing1LimitSpring: i64 = 0x7C;
                pub const m_swing2LimitSpring: i64 = 0x8C;
                pub const m_linearLimitDamping: i64 = 0x50;
                pub const m_swing1LimitDamping: i64 = 0x80;
                pub const m_swing2LimitDamping: i64 = 0x90;
                pub const m_twistLowLimitValue: i64 = 0x54;
                pub const m_goalAngularVelocity: i64 = 0xB0;
                pub const m_twistHighLimitValue: i64 = 0x64;
                pub const m_twistLowLimitSpring: i64 = 0x5C;
                pub const m_solverIterationCount: i64 = 0xEC;
                pub const m_twistHighLimitSpring: i64 = 0x6C;
                pub const m_twistLowLimitDamping: i64 = 0x60;
                pub const m_twistHighLimitDamping: i64 = 0x70;
                pub const m_linearLimitRestitution: i64 = 0x48;
                pub const m_swing1LimitRestitution: i64 = 0x78;
                pub const m_swing2LimitRestitution: i64 = 0x88;
                pub const m_twistLowLimitRestitution: i64 = 0x58;
                pub const m_projectionLinearTolerance: i64 = 0xF0;
                pub const m_twistHighLimitRestitution: i64 = 0x68;
                pub const m_projectionAngularTolerance: i64 = 0xF4;
            }
            pub mod BoneDemoCaptureSettings_t {
                pub const m_boneName: i64 = 0x0;
                pub const m_flErrorSplineScaleMax: i64 = 0x10;
                pub const m_flErrorSplineRotationMax: i64 = 0x8;
                pub const m_flErrorQuantizationScaleMax: i64 = 0x1C;
                pub const m_flErrorSplineTranslationMax: i64 = 0xC;
                pub const m_flErrorQuantizationRotationMax: i64 = 0x14;
                pub const m_flErrorQuantizationTranslationMax: i64 = 0x18;
            }
            pub mod CAnimGraphNetworkSettings {
                pub const m_bNetworkingEnabled: i64 = 0x20;
            }
            pub mod CAnimGraphSettingsManager {
                pub const m_settingsGroups: i64 = 0x18;
            }
            pub mod CBoneConstraintDotToMorph {
                pub const m_flRemap: i64 = 0x38;
                pub const m_sBoneName: i64 = 0x20;
                pub const m_sTargetBoneName: i64 = 0x28;
                pub const m_sMorphChannelName: i64 = 0x30;
            }
            pub mod CDirectPlaybackUpdateNode {
                pub const m_allTags: i64 = 0x78;
                pub const m_bFinishEarly: i64 = 0x74;
                pub const m_bResetOnFinish: i64 = 0x75;
            }
            pub mod CFootAdjustmentUpdateNode {
                pub const m_clips: i64 = 0x78;
                pub const m_bResetChild: i64 = 0xA8;
                pub const m_facingTarget: i64 = 0x94;
                pub const m_flTurnTimeMax: i64 = 0x9C;
                pub const m_flTurnTimeMin: i64 = 0x98;
                pub const m_flStepHeightMax: i64 = 0xA0;
                pub const m_bAnimationDriven: i64 = 0xA9;
                pub const m_flStepHeightMaxAngle: i64 = 0xA4;
                pub const m_hBasePoseCacheHandle: i64 = 0x90;
            }
            pub mod CFootCycleMetricEvaluator {
                pub const m_footIndices: i64 = 0x50;
            }
            pub mod CMaterialAttributeAnimTag {
                pub const m_Color: i64 = 0x68;
                pub const m_flValue: i64 = 0x64;
                pub const m_AttributeName: i64 = 0x58;
                pub const m_AttributeType: i64 = 0x60;
            }
            pub mod CMotionMatchingUpdateNode {
                pub const m_dataSet: i64 = 0x58;
                pub const m_metrics: i64 = 0x78;
                pub const m_weights: i64 = 0x90;
                pub const m_blendCurve: i64 = 0xEC;
                pub const m_bGoalAssist: i64 = 0x109;
                pub const m_flBlendTime: i64 = 0xF8;
                pub const m_flSampleRate: i64 = 0xF4;
                pub const m_bSearchEveryTick: i64 = 0xE0;
                pub const m_flSearchInterval: i64 = 0xE4;
                pub const m_bLockClipWhenWaning: i64 = 0xFC;
                pub const m_bSearchWhenClipEnds: i64 = 0xE8;
                pub const m_flGoalAssistDistance: i64 = 0x10C;
                pub const m_flSelectionThreshold: i64 = 0x100;
                pub const m_distanceScale_Damping: i64 = 0x118;
                pub const m_flGoalAssistTolerance: i64 = 0x110;
                pub const m_bEnableDistanceScaling: i64 = 0x140;
                pub const m_bSearchWhenGoalChanges: i64 = 0xE9;
                pub const m_flReselectionTimeWindow: i64 = 0x104;
                pub const m_flDistanceScale_MaxScale: i64 = 0x138;
                pub const m_flDistanceScale_MinScale: i64 = 0x13C;
                pub const m_bEnableRotationCorrection: i64 = 0x108;
                pub const m_flDistanceScale_InnerRadius: i64 = 0x134;
                pub const m_flDistanceScale_OuterRadius: i64 = 0x130;
            }
            pub mod CMovementComponentUpdater {
                pub const m_motors: i64 = 0x30;
                pub const m_bNetworkPath: i64 = 0x71;
                pub const m_paramHandles: i64 = 0x73;
                pub const m_facingDamping: i64 = 0x48;
                pub const m_bNetworkFacing: i64 = 0x72;
                pub const m_bMoveVarsDisabled: i64 = 0x70;
                pub const m_flDefaultRunSpeed: i64 = 0x6C;
                pub const m_nDefaultMotorIndex: i64 = 0x68;
            }
            pub mod CMovementHandshakeAnimTag {

            }
            pub mod CNmGraphNode__CDefinition {
                pub const m_nNodeIdx: i64 = 0x8;
            }
            pub mod CNmGraphVariationUserData {

            }
            pub mod CNmMaterialAttributeEvent {
                pub const m_w: i64 = 0xF0;
                pub const m_x: i64 = 0x30;
                pub const m_y: i64 = 0x70;
                pub const m_z: i64 = 0xB0;
                pub const m_target: i64 = 0x18;
                pub const m_attributeName: i64 = 0x20;
                pub const m_attributeNameToken: i64 = 0x28;
            }
            pub mod CNmScaleNode__CDefinition {
                pub const m_nMaskNodeIdx: i64 = 0x18;
                pub const m_nEnableNodeIdx: i64 = 0x1A;
            }
            pub mod CNmStateNode__CDefinition {
                pub const m_exitEvents: i64 = 0x58;
                pub const m_bIsOffState: i64 = 0xAE;
                pub const m_entryEvents: i64 = 0x18;
                pub const m_executeEvents: i64 = 0x38;
                pub const m_nChildNodeIdx: i64 = 0x10;
                pub const m_timedElapsedEvents: i64 = 0x90;
                pub const m_nLayerWeightNodeIdx: i64 = 0xA8;
                pub const m_timedRemainingEvents: i64 = 0x78;
                pub const m_nLayerBoneMaskNodeIdx: i64 = 0xAC;
                pub const m_nLayerRootMotionWeightNodeIdx: i64 = 0xAA;
                pub const m_bUseActualElapsedTimeInStateForTimedEvents: i64 = 0xAF;
            }
            pub mod CNmValueNode__CDefinition {

            }
            pub mod CPairedSequenceUpdateNode {
                pub const m_sPairedSequenceRole: i64 = 0x78;
            }
            pub mod CParticleBindingRealPulse {

            }
            pub mod CPathAnimMotorUpdaterBase {
                pub const m_bLockToPath: i64 = 0x20;
            }
            pub mod CPulseCell_Value_Gradient {
                pub const m_Gradient: i64 = 0x48;
            }
            pub mod CStanceOverrideUpdateNode {
                pub const m_eMode: i64 = 0x9C;
                pub const m_hParameter: i64 = 0x98;
                pub const m_footStanceInfo: i64 = 0x70;
                pub const m_pStanceSourceNode: i64 = 0x88;
            }
            pub mod CStateMachineInstanceData {
                pub const m_flTimeInState: i64 = 0x0;
                pub const m_prevStateIndex: i64 = 0x10;
                pub const m_currentTransitionIndex: i64 = 0x4;
                pub const m_scheduledTransitionIndex: i64 = 0x14;
            }
            pub mod CTargetSelectorUpdateNode {
                pub const m_children: i64 = 0x68;
                pub const m_eAngleMode: i64 = 0x60;
                pub const m_hTargetPosition: i64 = 0x84;
                pub const m_bEnablePhaseMatching: i64 = 0x8E;
                pub const m_hMoveHeadingParameter: i64 = 0x88;
                pub const m_bTargetPositionIsWorldSpace: i64 = 0x8C;
                pub const m_hDesiredMoveHeadingParameter: i64 = 0x8A;
                pub const m_hTargetFacePositionParameter: i64 = 0x86;
                pub const m_bTargetFacePositionIsWorldSpace: i64 = 0x8D;
                pub const m_flPhaseMatchingMaxRootMotionSkip: i64 = 0x90;
            }
            pub mod CWayPointHelperUpdateNode {
                pub const m_bOnlyGoals: i64 = 0x7C;
                pub const m_flEndCycle: i64 = 0x78;
                pub const m_flStartCycle: i64 = 0x74;
                pub const m_bPreventOvershoot: i64 = 0x7D;
                pub const m_bPreventUndershoot: i64 = 0x7E;
            }
            pub mod DynamicMeshDeformParams_t {
                pub const m_flTensionStretchScale: i64 = 0x4;
                pub const m_flTensionCompressScale: i64 = 0x0;
                pub const m_bEnableEyeBulgeDeformation: i64 = 0xB;
                pub const m_bSmoothNormalsAcrossUvSeams: i64 = 0xA;
                pub const m_bRecomputeSmoothNormalsAfterAnimation: i64 = 0x8;
                pub const m_bComputeDynamicMeshTensionAfterAnimation: i64 = 0x9;
            }
            pub mod NmBoneMaskSetDefinition_t {
                pub const m_ID: i64 = 0x0;
                pub const m_primaryWeightList: i64 = 0x8;
                pub const m_secondaryWeightLists: i64 = 0x118;
            }
            pub mod OutflowWithRequirements_t {
                pub const m_Connection: i64 = 0x0;
                pub const m_RequirementNodeIDs: i64 = 0x50;
                pub const m_DestinationFlowNodeID: i64 = 0x48;
                pub const m_nCursorStateBlockIndex: i64 = 0x68;
            }
            pub mod PulseRuntimeInvokeIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod PulseRuntimeOutputIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod PulseRuntimeStateOffset_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod SignatureOutflow_Continue {

            }
            pub mod AimCameraOpFixedSettings_t {
                pub const m_propJoints: i64 = 0x18;
                pub const m_nChainIndex: i64 = 0x0;
                pub const m_nCameraJointIndex: i64 = 0x4;
                pub const m_nPelvisJointIndex: i64 = 0x8;
                pub const m_nClavicleLeftJointIndex: i64 = 0xC;
                pub const m_nClavicleRightJointIndex: i64 = 0x10;
                pub const m_nDepenetrationJointIndex: i64 = 0x14;
            }
            pub mod AimMatrixOpFixedSettings_t {
                pub const m_damping: i64 = 0x80;
                pub const m_attachment: i64 = 0x0;
                pub const m_eBlendMode: i64 = 0xC0;
                pub const m_flMaxYawAngle: i64 = 0xC4;
                pub const m_nBoneMaskIndex: i64 = 0xD0;
                pub const m_flMaxPitchAngle: i64 = 0xC8;
                pub const m_bUseBiasAndClamp: i64 = 0xD5;
                pub const m_poseCacheHandles: i64 = 0x98;
                pub const m_bTargetIsPosition: i64 = 0xD4;
                pub const m_nSequenceMaxFrame: i64 = 0xCC;
                pub const m_biasAndClampBlendCurve: i64 = 0xE0;
                pub const m_flBiasAndClampYawOffset: i64 = 0xD8;
                pub const m_flBiasAndClampPitchOffset: i64 = 0xDC;
            }
            pub mod AnimationDecodeDebugDump_t {
                pub const m_elems: i64 = 0x8;
                pub const m_processingType: i64 = 0x0;
            }
            pub mod CCPPScriptComponentUpdater {
                pub const m_scriptsToRun: i64 = 0x30;
            }
            pub mod CFootStepTriggerUpdateNode {
                pub const m_triggers: i64 = 0x70;
                pub const m_flTolerance: i64 = 0x8C;
            }
            pub mod CNmContactAudioActionVData {

            }
            pub mod CNmEntityAttributeIntEvent {
                pub const m_nIntValue: i64 = 0x38;
            }
            pub mod CNmFootIKNode__CDefinition {
                pub const m_blendMode: i64 = 0x34;
                pub const m_nEnabledNodeIdx: i64 = 0x2C;
                pub const m_flBlendTimeSeconds: i64 = 0x30;
                pub const m_leftEffectorBoneID: i64 = 0x18;
                pub const m_nLeftTargetNodeIdx: i64 = 0x28;
                pub const m_nRightTargetNodeIdx: i64 = 0x2A;
                pub const m_rightEffectorBoneID: i64 = 0x20;
                pub const m_bIsTargetInWorldSpace: i64 = 0x35;
            }
            pub mod CNmStateNode__TimedEvent_t {
                pub const m_ID: i64 = 0x0;
                pub const m_flTimeValueSeconds: i64 = 0x8;
                pub const m_comparisionOperator: i64 = 0xC;
            }
            pub mod COrientationWarpUpdateNode {
                pub const m_eMode: i64 = 0x74;
                pub const m_damping: i64 = 0x90;
                pub const m_hTargetParam: i64 = 0x78;
                pub const m_flTargetOffset: i64 = 0x84;
                pub const m_eRootMotionSource: i64 = 0xA8;
                pub const m_eTargetOffsetMode: i64 = 0x80;
                pub const m_hTargetOffsetParam: i64 = 0x88;
                pub const m_flMaxRootMotionScale: i64 = 0xAC;
                pub const m_hTargetPositionParam: i64 = 0x7A;
                pub const m_ePreferredRotationDirection: i64 = 0xB4;
                pub const m_flPreferredRotationThreshold: i64 = 0xB8;
                pub const m_hFallbackTargetPositionParam: i64 = 0x7C;
                pub const m_bEnablePreferredRotationDirection: i64 = 0xB0;
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
            pub mod CSetParameterActionUpdater {
                pub const m_value: i64 = 0x1A;
                pub const m_hParam: i64 = 0x18;
            }
            pub mod FollowAttachmentSettings_t {
                pub const m_boneIndex: i64 = 0x80;
                pub const m_attachment: i64 = 0x0;
                pub const m_bMatchRotation: i64 = 0x86;
                pub const m_attachmentHandle: i64 = 0x84;
                pub const m_bMatchTranslation: i64 = 0x85;
            }
            pub mod MotionMatchingInstanceData {
                pub const m_currentSelection: i64 = 0x2C;
                pub const m_previousSelection: i64 = 0x84;
            }
            pub mod ParticleNamedValueSource_t {
                pub const m_Name: i64 = 0x0;
                pub const m_IsPublic: i64 = 0x8;
                pub const m_ValueType: i64 = 0x10;
                pub const m_DefaultConfig: i64 = 0x28;
            }
            pub mod PulseNodeDynamicOutflows_t {
                pub const m_Outflows: i64 = 0x0;
            }
            pub mod PulseRuntimeTempVarIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod PulseSelectorOutflowList_t {
                pub const m_Outflows: i64 = 0x0;
            }
            pub mod CAnimScriptComponentUpdater {
                pub const m_hScript: i64 = 0x30;
            }
            pub mod CCycleControlClipUpdateNode {
                pub const m_tags: i64 = 0x60;
                pub const m_duration: i64 = 0x80;
                pub const m_hSequence: i64 = 0x7C;
                pub const m_paramIndex: i64 = 0x88;
                pub const m_valueSource: i64 = 0x84;
                pub const m_bLockWhenWaning: i64 = 0x8A;
            }
            pub mod CDampedPathAnimMotorUpdater {
                pub const m_flMinSpeedScale: i64 = 0x30;
                pub const m_flSpringConstant: i64 = 0x38;
                pub const m_flAnticipationTime: i64 = 0x2C;
                pub const m_flMaxSpringTension: i64 = 0x40;
                pub const m_flMinSpringTension: i64 = 0x3C;
                pub const m_hAnticipationPosParam: i64 = 0x34;
                pub const m_hAnticipationHeadingParam: i64 = 0x36;
            }
            pub mod CDirectPlaybackInstanceData {
                pub const m_weights: i64 = 0x14;
                pub const m_sequences: i64 = 0x24;
                pub const m_flFadeInTime: i64 = 0x118;
                pub const m_bResetPending: i64 = 0x130;
                pub const m_flFadeOutTime: i64 = 0x11C;
                pub const m_flForcedCycle: i64 = 0x120;
                pub const m_flTargetFacing: i64 = 0xC;
                pub const m_flInterpEndTime: i64 = 0x10;
                pub const m_vTargetPosition: i64 = 0x0;
                pub const m_currentSequenceData: i64 = 0x108;
                pub const m_currentSequenceIndex: i64 = 0x104;
                pub const m_SequenceCycleZeroTime: i64 = 0x138;
            }
            pub mod CDirectionalBlendUpdateNode {
                pub const m_bLoop: i64 = 0xA8;
                pub const m_damping: i64 = 0x80;
                pub const m_duration: i64 = 0xA4;
                pub const m_hSequences: i64 = 0x5C;
                pub const m_paramIndex: i64 = 0x9C;
                pub const m_playbackSpeed: i64 = 0xA0;
                pub const m_blendValueSource: i64 = 0x98;
                pub const m_bLockBlendOnReset: i64 = 0xA9;
            }
            pub mod CFollowAttachmentUpdateNode {
                pub const m_opFixedData: i64 = 0x70;
            }
            pub mod CFootAdjustmentInstanceData {
                pub const m_flDuration: i64 = 0x18;
                pub const m_flStartTime: i64 = 0xC;
                pub const m_flStartHeadingWS: i64 = 0x3C;
            }
            pub mod CModelConfigElement_Command {
                pub const m_Args: i64 = 0x50;
                pub const m_Command: i64 = 0x48;
            }
            pub mod CNmBlend1DNode__CDefinition {
                pub const m_parameterization: i64 = 0x30;
            }
            pub mod CNmBlend2DNode__CDefinition {
                pub const m_values: i64 = 0x28;
                pub const m_indices: i64 = 0x80;
                pub const m_hullIndices: i64 = 0xA8;
                pub const m_bAllowLooping: i64 = 0xC4;
                pub const m_sourceNodeIndices: i64 = 0x10;
                pub const m_nInputParameterNodeIdx0: i64 = 0xC0;
                pub const m_nInputParameterNodeIdx1: i64 = 0xC2;
            }
            pub mod CNmConstIDNode__CDefinition {
                pub const m_value: i64 = 0x10;
            }
            pub mod CNmEntityAttributeEventBase {
                pub const m_target: i64 = 0x18;
                pub const m_attributeName: i64 = 0x20;
            }
            pub mod CNmIDEventNode__CDefinition {
                pub const m_defaultValue: i64 = 0x18;
                pub const m_eventConditionRules: i64 = 0x14;
                pub const m_nSourceStateNodeIdx: i64 = 0x10;
            }
            pub mod CNmIDValueNode__CDefinition {

            }
            pub mod CNmSyncTrack__EventMarker_t {
                pub const m_ID: i64 = 0x8;
                pub const m_startTime: i64 = 0x0;
            }
            pub mod CParticleCollectionVecInput {

            }
            pub mod CPhysSurfacePropertiesAudio {
                pub const m_reflectivity: i64 = 0x0;
                pub const m_hardThreshold: i64 = 0x10;
                pub const m_hardnessFactor: i64 = 0x4;
                pub const m_roughThreshold: i64 = 0xC;
                pub const m_roughnessFactor: i64 = 0x8;
                pub const m_flOcclusionFactor: i64 = 0x1C;
                pub const m_flStaticImpactVolume: i64 = 0x18;
                pub const m_hardVelocityThreshold: i64 = 0x14;
            }
            pub mod CPulseCell_Inflow_GraphHook {
                pub const m_HookName: i64 = 0x80;
            }
            pub mod CPulseGraphExecutionHistory {
                pub const m_vecHistory: i64 = 0x10;
                pub const m_mapCellDesc: i64 = 0x28;
                pub const m_nInstanceID: i64 = 0x0;
                pub const m_strFileName: i64 = 0x8;
                pub const m_mapCursorDesc: i64 = 0x50;
            }
            pub mod CRemapValueComponentUpdater {
                pub const m_items: i64 = 0x30;
            }
            pub mod CSlowDownOnSlopesUpdateNode {
                pub const m_flSlowDownStrength: i64 = 0x70;
            }
            pub mod CWayPointHelperInstanceData {
                pub const m_vMovement: i64 = 0x0;
                pub const m_vRotation: i64 = 0xC;
                pub const m_vWaypointPosWS: i64 = 0x18;
                pub const m_bStopUpdatingWaypointPos: i64 = 0x24;
            }
            pub mod FootLockPoseOpFixedSettings {
                pub const m_footInfo: i64 = 0x0;
                pub const m_bApplyTilt: i64 = 0x38;
                pub const m_ikSolverType: i64 = 0x34;
                pub const m_bApplyHipDrop: i64 = 0x39;
                pub const m_flMaxLegTwist: i64 = 0x48;
                pub const m_nHipBoneIndex: i64 = 0x30;
                pub const m_flLockBlendTime: i64 = 0x54;
                pub const m_flMaxFootHeight: i64 = 0x40;
                pub const m_flExtensionScale: i64 = 0x44;
                pub const m_bEnableStretching: i64 = 0x58;
                pub const m_flMaxStretchAmount: i64 = 0x5C;
                pub const m_hipDampingSettings: i64 = 0x18;
                pub const m_bEnableLockBreaking: i64 = 0x4C;
                pub const m_bApplyLegTwistLimits: i64 = 0x3C;
                pub const m_flLockBreakTolerance: i64 = 0x50;
                pub const m_bAlwaysUseFallbackHinge: i64 = 0x3A;
                pub const m_flStretchExtensionScale: i64 = 0x60;
                pub const m_bApplyFootRotationLimits: i64 = 0x3B;
            }
            pub mod PulseRuntimeCallInfoIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod PulseRuntimeConstantIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod PulseRuntimeRegisterIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod VPhysXCollisionAttributes_t {
                pub const m_InteractAs: i64 = 0x8;
                pub const m_DetailLayers: i64 = 0x50;
                pub const m_InteractWith: i64 = 0x20;
                pub const m_CollisionGroup: i64 = 0x4;
                pub const m_InteractExclude: i64 = 0x38;
                pub const m_InteractAsStrings: i64 = 0x70;
                pub const m_DetailLayerStrings: i64 = 0xB8;
                pub const m_InteractWithStrings: i64 = 0x88;
                pub const m_CollisionGroupString: i64 = 0x68;
                pub const m_InteractExcludeStrings: i64 = 0xA0;
                pub const m_nIncludeDetailLayerCount: i64 = 0x0;
            }
            pub mod CAnimParameterManagerUpdater {
                pub const m_parameters: i64 = 0x18;
                pub const m_autoResetMap: i64 = 0xA0;
                pub const m_idToIndexMap: i64 = 0x30;
                pub const m_indexToHandle: i64 = 0x70;
                pub const m_nameToIndexMap: i64 = 0x50;
                pub const m_autoResetParams: i64 = 0x88;
            }
            pub mod CAnimationGraphVisualizerPie {
                pub const m_Color: i64 = 0x70;
                pub const m_vWsEnd: i64 = 0x60;
                pub const m_vWsStart: i64 = 0x50;
                pub const m_vWsCenter: i64 = 0x40;
            }
            pub mod CBoneConstraintPoseSpaceBone {
                pub const m_inputList: i64 = 0x60;
            }
            pub mod CBonePositionMetricEvaluator {
                pub const m_nBoneIndex: i64 = 0x50;
            }
            pub mod CBoneVelocityMetricEvaluator {
                pub const m_nBoneIndex: i64 = 0x50;
            }
            pub mod CDampedValueComponentUpdater {
                pub const m_items: i64 = 0x30;
            }
            pub mod CFootPositionMetricEvaluator {
                pub const m_footIndices: i64 = 0x50;
                pub const m_bIgnoreSlope: i64 = 0x68;
            }
            pub mod CFutureFacingMetricEvaluator {
                pub const m_flTime: i64 = 0x54;
                pub const m_flDistance: i64 = 0x50;
            }
            pub mod CModelConfigElement_UserPick {
                pub const m_Choices: i64 = 0x48;
            }
            pub mod CNmBoneMaskNode__CDefinition {
                pub const m_boneMaskID: i64 = 0x10;
            }
            pub mod CNmCachedIDNode__CDefinition {
                pub const m_mode: i64 = 0x14;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmEntityAttributeFloatEvent {
                pub const m_FloatValue: i64 = 0x38;
            }
            pub mod CNmIDSwitchNode__CDefinition {
                pub const m_trueValue: i64 = 0x20;
                pub const m_falseValue: i64 = 0x18;
                pub const m_nTrueValueNodeIdx: i64 = 0x12;
                pub const m_nFalseValueNodeIdx: i64 = 0x14;
                pub const m_nSwitchValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmSelectorNode__CDefinition {
                pub const m_optionNodeIndices: i64 = 0x10;
                pub const m_conditionNodeIndices: i64 = 0x28;
            }
            pub mod CNmSkeleton__ContactConfig_t {
                pub const m_ID: i64 = 0x0;
                pub const m_nBoneIdx: i64 = 0x8;
                pub const m_audioInfo: i64 = 0x20;
                pub const m_flProbeMaxDist: i64 = 0x18;
                pub const m_vBoneLocalProbeDir: i64 = 0xC;
            }
            pub mod CNmZeroPoseNode__CDefinition {

            }
            pub mod CPlayerInputAnimMotorUpdater {
                pub const m_sampleTimes: i64 = 0x20;
                pub const m_bUseAcceleration: i64 = 0x48;
                pub const m_flSpringConstant: i64 = 0x3C;
                pub const m_hAnticipationPosParam: i64 = 0x44;
                pub const m_flAnticipationDistance: i64 = 0x40;
                pub const m_hAnticipationHeadingParam: i64 = 0x46;
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
            pub mod CPulse_TempVarBankDefinition {
                pub const m_TempVars: i64 = 0x0;
            }
            pub mod CVPhysXSurfacePropertiesList {
                pub const m_surfacePropertiesList: i64 = 0x0;
            }
            pub mod FootPinningPoseOpFixedData_t {
                pub const m_footInfo: i64 = 0x0;
                pub const m_flBlendTime: i64 = 0x18;
                pub const m_flMaxLegTwist: i64 = 0x20;
                pub const m_nHipBoneIndex: i64 = 0x24;
                pub const m_flLockBreakDistance: i64 = 0x1C;
                pub const m_bApplyLegTwistLimits: i64 = 0x28;
                pub const m_bApplyFootRotationLimits: i64 = 0x29;
            }
            pub mod ModelBoneFlexDriverControl_t {
                pub const m_flMax: i64 = 0x18;
                pub const m_flMin: i64 = 0x14;
                pub const m_flexController: i64 = 0x8;
                pub const m_nBoneComponent: i64 = 0x0;
                pub const m_flexControllerToken: i64 = 0x10;
            }
            pub mod TargetSelectorInstanceData_t {
                pub const m_currentIndex: i64 = 0x0;
                pub const m_vMSRootMotionAnlyzerTarget: i64 = 0x1C;
            }
            pub mod CAnimationGraphVisualizerAxis {
                pub const m_flAxisSize: i64 = 0x60;
                pub const m_xWsTransform: i64 = 0x40;
            }
            pub mod CAnimationGraphVisualizerLine {
                pub const m_Color: i64 = 0x60;
                pub const m_vWsPositionEnd: i64 = 0x50;
                pub const m_vWsPositionStart: i64 = 0x40;
            }
            pub mod CAnimationGraphVisualizerText {
                pub const m_Text: i64 = 0x58;
                pub const m_Color: i64 = 0x50;
                pub const m_vWsPosition: i64 = 0x40;
            }
            pub mod CBoneConstraintPoseSpaceMorph {
                pub const m_bClamp: i64 = 0x60;
                pub const m_inputList: i64 = 0x48;
                pub const m_sBoneName: i64 = 0x20;
                pub const m_outputMorph: i64 = 0x30;
                pub const m_sAttachmentName: i64 = 0x28;
            }
            pub mod CDemoSettingsComponentUpdater {
                pub const m_settings: i64 = 0x30;
            }
            pub mod CDirectionalBlendInstanceData {
                pub const m_flCycle: i64 = 0x14;
                pub const m_resetCount: i64 = 0x40;
                pub const m_dampedValue: i64 = 0x0;
                pub const m_flPrevCycle: i64 = 0x18;
                pub const m_flPlaybackRate: i64 = 0x1C;
                pub const m_flCycleZeroTime: i64 = 0x28;
                pub const m_resetCycleValue: i64 = 0x34;
            }
            pub mod CNmBodyGroupNode__CDefinition {
                pub const m_event: i64 = 0x20;
                pub const m_nEnabledNodeIdx: i64 = 0x18;
            }
            pub mod CNmBoolValueNode__CDefinition {

            }
            pub mod CNmConstBoolNode__CDefinition {
                pub const m_bValue: i64 = 0x10;
            }
            pub mod CNmFloatEaseNode__CDefinition {
                pub const m_easingOp: i64 = 0x1A;
                pub const m_flEaseTime: i64 = 0x10;
                pub const m_flStartValue: i64 = 0x14;
                pub const m_bUseStartValue: i64 = 0x1B;
                pub const m_nInputValueNodeIdx: i64 = 0x18;
            }
            pub mod CNmFloatMathNode__CDefinition {
                pub const m_flValueB: i64 = 0x18;
                pub const m_operator: i64 = 0x16;
                pub const m_nInputValueNodeIdxA: i64 = 0x10;
                pub const m_nInputValueNodeIdxB: i64 = 0x12;
                pub const m_bReturnNegatedResult: i64 = 0x15;
                pub const m_bReturnAbsoluteResult: i64 = 0x14;
            }
            pub mod CNmIDToFloatNode__CDefinition {
                pub const m_IDs: i64 = 0x18;
                pub const m_values: i64 = 0x48;
                pub const m_defaultValue: i64 = 0x14;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmTwoBoneIKNode__CDefinition {
                pub const m_blendMode: i64 = 0x28;
                pub const m_effectorBoneID: i64 = 0x18;
                pub const m_nEnabledNodeIdx: i64 = 0x22;
                pub const m_flBlendTimeSeconds: i64 = 0x24;
                pub const m_bIsTargetInWorldSpace: i64 = 0x29;
                pub const m_flChainRotationWeight: i64 = 0x2C;
                pub const m_nEffectorTargetNodeIdx: i64 = 0x20;
            }
            pub mod CParticleCollectionFloatInput {

            }
            pub mod CPhysSurfacePropertiesPhysics {
                pub const m_density: i64 = 0x8;
                pub const m_friction: i64 = 0x0;
                pub const m_thickness: i64 = 0xC;
                pub const m_elasticity: i64 = 0x4;
                pub const m_softContactFrequency: i64 = 0x10;
                pub const m_softContactDampingRatio: i64 = 0x14;
            }
            pub mod CPhysSurfacePropertiesVehicle {
                pub const m_wheelDrag: i64 = 0x0;
                pub const m_wheelFrictionScale: i64 = 0x4;
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
            pub mod CStateMachineComponentUpdater {
                pub const m_stateMachine: i64 = 0x30;
            }
            pub mod CTimeRemainingMetricEvaluator {
                pub const m_flMaxTimeRemaining: i64 = 0x54;
                pub const m_flMinTimeRemaining: i64 = 0x5C;
                pub const m_bMatchByTimeRemaining: i64 = 0x50;
                pub const m_bFilterByTimeRemaining: i64 = 0x58;
            }
            pub mod CToggleComponentActionUpdater {
                pub const m_bSetEnabled: i64 = 0x1C;
                pub const m_componentID: i64 = 0x18;
            }
            pub mod DampedPathMotorInstanceData_t {
                pub const m_bStopping: i64 = 0x24;
                pub const m_vVelocity: i64 = 0x0;
                pub const m_vAcceleration: i64 = 0xC;
            }
            pub mod FollowTargetOpFixedSettings_t {
                pub const m_boneIndex: i64 = 0x0;
                pub const m_bBoneTarget: i64 = 0x4;
                pub const m_boneTargetIndex: i64 = 0x8;
                pub const m_bWorldCoodinateTarget: i64 = 0xC;
                pub const m_bMatchTargetOrientation: i64 = 0xD;
            }
            pub mod PulseRuntimeEntrypointIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod SkeletonAnimCapture_t__Bone_t {
                pub const m_Name: i64 = 0x0;
                pub const m_nParent: i64 = 0x30;
                pub const m_BindPose: i64 = 0x10;
            }
            pub mod CBlockSelectionMetricEvaluator {

            }
            pub mod CFutureVelocityMetricEvaluator {
                pub const m_eMode: i64 = 0x5C;
                pub const m_flDistance: i64 = 0x50;
                pub const m_flTargetSpeed: i64 = 0x58;
                pub const m_flStoppingDistance: i64 = 0x54;
            }
            pub mod CModelConfigElement_RandomPick {
                pub const m_Choices: i64 = 0x48;
                pub const m_ChoiceWeights: i64 = 0x60;
            }
            pub mod CNmCachedBoolNode__CDefinition {
                pub const m_mode: i64 = 0x14;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmConstFloatNode__CDefinition {
                pub const m_flValue: i64 = 0x10;
            }
            pub mod CNmFloatClampNode__CDefinition {
                pub const m_clampRange: i64 = 0x14;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmFloatCurveNode__CDefinition {
                pub const m_curve: i64 = 0x18;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmFloatRemapNode__CDefinition {
                pub const m_inputRange: i64 = 0x14;
                pub const m_outputRange: i64 = 0x1C;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmFloatValueNode__CDefinition {

            }
            pub mod CNmFollowBoneNode__CDefinition {
                pub const m_bone: i64 = 0x18;
                pub const m_mode: i64 = 0x2A;
                pub const m_nEnabledNodeIdx: i64 = 0x28;
                pub const m_followTargetBone: i64 = 0x20;
            }
            pub mod CNmIDSelectorNode__CDefinition {
                pub const m_values: i64 = 0x28;
                pub const m_defaultValue: i64 = 0x58;
                pub const m_conditionNodeIndices: i64 = 0x10;
            }
            pub mod CNmLayerBlendNode__CDefinition {
                pub const m_nBaseNodeIdx: i64 = 0x10;
                pub const m_layerDefinition: i64 = 0x18;
                pub const m_bOnlySampleBaseRootMotion: i64 = 0x12;
            }
            pub mod CNmSpeedScaleNode__CDefinition {

            }
            pub mod CNmTargetInfoNode__CDefinition {
                pub const m_infoType: i64 = 0x14;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
                pub const m_bIsWorldSpaceTarget: i64 = 0x18;
            }
            pub mod CNmTargetWarpNode__CDefinition {
                pub const m_samplingMode: i64 = 0x14;
                pub const m_alignmentBoneID: i64 = 0x30;
                pub const m_targetUpdateRule: i64 = 0x15;
                pub const m_flMaxTangentLength: i64 = 0x1C;
                pub const m_nTargetValueNodeIdx: i64 = 0x12;
                pub const m_nClipReferenceNodeIdx: i64 = 0x10;
                pub const m_bAlignWithTargetAtLastWarpEvent: i64 = 0x16;
                pub const m_flLerpFallbackDistanceThreshold: i64 = 0x20;
                pub const m_flTargetUpdateDistanceThreshold: i64 = 0x24;
                pub const m_flSamplingPositionErrorThresholdSq: i64 = 0x18;
                pub const m_flTargetUpdateAngleThresholdRadians: i64 = 0x28;
            }
            pub mod CNmTransitionNode__CDefinition {
                pub const m_flDuration: i64 = 0x18;
                pub const m_flTimeOffset: i64 = 0x20;
                pub const m_rootMotionBlend: i64 = 0x2B;
                pub const m_blendWeightEasing: i64 = 0x2A;
                pub const m_transitionOptions: i64 = 0x24;
                pub const m_nTargetStateNodeIdx: i64 = 0x10;
                pub const m_targetSyncIDNodeIdx: i64 = 0x28;
                pub const m_startBoneMaskNodeIdx: i64 = 0x16;
                pub const m_nDurationOverrideNodeIdx: i64 = 0x12;
                pub const m_timeOffsetOverrideNodeIdx: i64 = 0x14;
                pub const m_boneMaskBlendInTimePercentage: i64 = 0x1C;
            }
            pub mod CNmVectorInfoNode__CDefinition {
                pub const m_desiredInfo: i64 = 0x12;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CPulseCell_Inflow_EventHandler {
                pub const m_EventName: i64 = 0x80;
            }
            pub mod CPulseCell_Outflow_CycleRandom {
                pub const m_Outputs: i64 = 0x48;
            }
            pub mod CStepsRemainingMetricEvaluator {
                pub const m_footIndices: i64 = 0x50;
                pub const m_flMinStepsRemaining: i64 = 0x68;
            }
            pub mod PlayerInputMotorInstanceData_t {
                pub const m_vVelocityWS: i64 = 0xC;
                pub const m_vInputVectorWS: i64 = 0x0;
                pub const m_vAccelerationWS: i64 = 0x18;
            }
            pub mod PulseRuntimeDomainValueIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod PulseRuntimeTempVarBankIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod SkeletonAnimCapture_t__Frame_t {
                pub const m_Stamp: i64 = 0x4;
                pub const m_flTime: i64 = 0x0;
                pub const m_Transform: i64 = 0x20;
                pub const m_bTeleport: i64 = 0x40;
                pub const m_FeModelPos: i64 = 0x90;
                pub const m_FeModelAnims: i64 = 0x78;
                pub const m_SimStateBones: i64 = 0x60;
                pub const m_CompositeBones: i64 = 0x48;
                pub const m_FlexControllerWeights: i64 = 0xA8;
            }
            pub mod CAnimationGraphVisualizerSphere {
                pub const m_Color: i64 = 0x54;
                pub const m_flRadius: i64 = 0x50;
                pub const m_vWsPosition: i64 = 0x40;
            }
            pub mod CCurrentVelocityMetricEvaluator {

            }
            pub mod CModelConfigElement_RandomColor {
                pub const m_Gradient: i64 = 0x48;
            }
            pub mod CNmCachedFloatNode__CDefinition {
                pub const m_mode: i64 = 0x14;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmChainLookatNode__CDefinition {
                pub const m_chainWeights: i64 = 0x40;
                pub const m_nChainLength: i64 = 0x70;
                pub const m_nEnabledNodeIdx: i64 = 0x3A;
                pub const m_endEffectorBoneID: i64 = 0x18;
                pub const m_endEffectorOffset: i64 = 0x2C;
                pub const m_flBlendTimeSeconds: i64 = 0x3C;
                pub const m_nLookatTargetNodeIdx: i64 = 0x38;
                pub const m_bIsTargetInWorldSpace: i64 = 0x71;
                pub const m_endEffectorForwardAxis: i64 = 0x20;
            }
            pub mod CNmConstTargetNode__CDefinition {
                pub const m_value: i64 = 0x10;
            }
            pub mod CNmConstVectorNode__CDefinition {
                pub const m_value: i64 = 0x10;
            }
            pub mod CNmFloatRemapNode__RemapRange_t {
                pub const m_flEnd: i64 = 0x4;
                pub const m_flBegin: i64 = 0x0;
            }
            pub mod CNmFloatSpringNode__CDefinition {
                pub const m_flHertz: i64 = 0x14;
                pub const m_flStartValue: i64 = 0x10;
                pub const m_bUseStartValue: i64 = 0x1E;
                pub const m_flDampingRatio: i64 = 0x18;
                pub const m_nInputValueNodeIdx: i64 = 0x1C;
            }
            pub mod CNmFloatSwitchNode__CDefinition {
                pub const m_flTrueValue: i64 = 0x1C;
                pub const m_flFalseValue: i64 = 0x18;
                pub const m_nTrueValueNodeIdx: i64 = 0x12;
                pub const m_nFalseValueNodeIdx: i64 = 0x14;
                pub const m_nSwitchValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmIsTargetSetNode__CDefinition {
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmPassthroughNode__CDefinition {
                pub const m_nChildNodeIdx: i64 = 0x10;
            }
            pub mod CNmTargetPointNode__CDefinition {
                pub const m_nInputValueNodeIdx: i64 = 0x10;
                pub const m_bIsWorldSpaceTarget: i64 = 0x12;
            }
            pub mod CNmTargetValueNode__CDefinition {

            }
            pub mod CNmVectorValueNode__CDefinition {

            }
            pub mod CPairedSequenceComponentUpdater {

            }
            pub mod CPulseCell_Outflow_CycleOrdered {
                pub const m_Outputs: i64 = 0x48;
            }
            pub mod SkeletonAnimCapture_t__Camera_t {
                pub const m_flTime: i64 = 0x20;
                pub const m_tmCamera: i64 = 0x0;
            }
            pub mod CModelConfigElement_SetBodygroup {
                pub const m_nChoice: i64 = 0x50;
                pub const m_GroupName: i64 = 0x48;
            }
            pub mod CNmCachedTargetNode__CDefinition {
                pub const m_mode: i64 = 0x14;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmCachedVectorNode__CDefinition {
                pub const m_mode: i64 = 0x14;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmClipSelectorNode__CDefinition {
                pub const m_optionNodeIndices: i64 = 0x10;
                pub const m_conditionNodeIndices: i64 = 0x28;
            }
            pub mod CNmExternalPoseNode__CDefinition {
                pub const m_bShouldSampleRootMotion: i64 = 0x10;
            }
            pub mod CNmIDComparisonNode__CDefinition {
                pub const m_comparison: i64 = 0x12;
                pub const m_comparisionIDs: i64 = 0x18;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmSkeleton__SecondarySkeleton_t {
                pub const m_skeleton: i64 = 0x8;
                pub const m_attachToBoneID: i64 = 0x0;
            }
            pub mod CNmStateMachineNode__CDefinition {
                pub const m_stateDefinitions: i64 = 0x10;
                pub const m_nDefaultStateIndex: i64 = 0x130;
            }
            pub mod CNmTargetOffsetNode__CDefinition {
                pub const m_rotationOffset: i64 = 0x20;
                pub const m_translationOffset: i64 = 0x30;
                pub const m_bIsBoneSpaceOffset: i64 = 0x12;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmVectorCreateNode__CDefinition {
                pub const m_inputValueXNodeIdx: i64 = 0x12;
                pub const m_inputValueYNodeIdx: i64 = 0x14;
                pub const m_inputValueZNodeIdx: i64 = 0x16;
                pub const m_inputVectorValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmVectorNegateNode__CDefinition {
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CPhysSurfacePropertiesSoundNames {
                pub const m_break: i64 = 0x30;
                pub const m_strain: i64 = 0x38;
                pub const m_pushOff: i64 = 0x48;
                pub const m_rolling: i64 = 0x28;
                pub const m_resonant: i64 = 0x58;
                pub const m_skidStop: i64 = 0x50;
                pub const m_impactHard: i64 = 0x8;
                pub const m_impactSoft: i64 = 0x0;
                pub const m_meleeImpact: i64 = 0x40;
                pub const m_scrapeRough: i64 = 0x18;
                pub const m_bulletImpact: i64 = 0x20;
                pub const m_scrapeSmooth: i64 = 0x10;
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
            pub mod AnimationDecodeDebugDumpElement_t {
                pub const m_decodeOps: i64 = 0x28;
                pub const m_modelName: i64 = 0x8;
                pub const m_poseParams: i64 = 0x10;
                pub const m_internalOps: i64 = 0x40;
                pub const m_decodedAnims: i64 = 0x58;
                pub const m_nEntityIndex: i64 = 0x0;
            }
            pub mod CDistanceRemainingMetricEvaluator {
                pub const m_flMaxDistance: i64 = 0x50;
                pub const m_flMinDistance: i64 = 0x54;
                pub const m_bFilterGoalDistance: i64 = 0x61;
                pub const m_bFilterGoalOvershoot: i64 = 0x62;
                pub const m_bFilterFixedMinDistance: i64 = 0x60;
                pub const m_flMaxGoalOvershootScale: i64 = 0x5C;
                pub const m_flStartGoalFilterDistance: i64 = 0x58;
            }
            pub mod CModelConfigElement_AttachedModel {
                pub const m_hModel: i64 = 0x58;
                pub const m_vOffset: i64 = 0x60;
                pub const m_aAngOffset: i64 = 0x6C;
                pub const m_EntityClass: i64 = 0x50;
                pub const m_InstanceName: i64 = 0x48;
                pub const m_AttachmentName: i64 = 0x78;
                pub const m_AttachmentType: i64 = 0x88;
                pub const m_bBoneMergeFlex: i64 = 0x8C;
                pub const m_bUserSpecifiedColor: i64 = 0x8D;
                pub const m_bCollideWithHierarchy: i64 = 0xA0;
                pub const m_BodygroupOnOtherModels: i64 = 0x90;
                pub const m_bCollideOutsideHierarchy: i64 = 0xA1;
                pub const m_LocalAttachmentOffsetName: i64 = 0x80;
                pub const m_MaterialGroupOnOtherModels: i64 = 0x98;
                pub const m_bUserSpecifiedMaterialGroup: i64 = 0x8E;
            }
            pub mod CNmAnimationPoseNode__CDefinition {
                pub const m_nDataSlotIdx: i64 = 0x12;
                pub const m_bUseFramesAsInput: i64 = 0x20;
                pub const m_flUserSpecifiedTime: i64 = 0x1C;
                pub const m_inputTimeRemapRange: i64 = 0x14;
                pub const m_nPoseTimeValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmBoneMaskBlendNode__CDefinition {
                pub const m_nSourceMaskNodeIdx: i64 = 0x10;
                pub const m_nTargetMaskNodeIdx: i64 = 0x12;
                pub const m_nBlendWeightValueNodeIdx: i64 = 0x14;
            }
            pub mod CNmBoneMaskValueNode__CDefinition {

            }
            pub mod CNmClipReferenceNode__CDefinition {

            }
            pub mod CNmDurationScaleNode__CDefinition {

            }
            pub mod CNmFloatSelectorNode__CDefinition {
                pub const m_values: i64 = 0x28;
                pub const m_easingOp: i64 = 0x50;
                pub const m_flEaseTime: i64 = 0x4C;
                pub const m_flDefaultValue: i64 = 0x48;
                pub const m_conditionNodeIndices: i64 = 0x10;
            }
            pub mod CNmReferencePoseNode__CDefinition {

            }
            pub mod CNmTimeConditionNode__CDefinition {
                pub const m_type: i64 = 0x18;
                pub const m_operator: i64 = 0x19;
                pub const m_flComparand: i64 = 0x14;
                pub const m_nInputValueNodeIdx: i64 = 0x12;
                pub const m_sourceStateNodeIdx: i64 = 0x10;
            }
            pub mod CNmVelocityBlendNode__CDefinition {

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
            pub mod NmFloatCurveCompressionSettings_t {
                pub const m_range: i64 = 0x0;
                pub const m_bIsStatic: i64 = 0x8;
            }
            pub mod ParticleNamedValueConfiguration_t {
                pub const m_ConfigName: i64 = 0x0;
                pub const m_ConfigValue: i64 = 0x8;
                pub const m_iAttachType: i64 = 0x20;
                pub const m_BoundValuePath: i64 = 0x18;
                pub const m_strEntityScope: i64 = 0x28;
                pub const m_strAttachmentName: i64 = 0x30;
            }
            pub mod PulseGraphExecutionHistoryEntry_t {
                pub const childID: i64 = 0x30;
                pub const tagName: i64 = 0x20;
                pub const unFlags: i64 = 0x1C;
                pub const seqPoint: i64 = 0x8;
                pub const nCursorID: i64 = 0x0;
                pub const nEditorID: i64 = 0x4;
                pub const flExecTime: i64 = 0x18;
            }
            pub mod SolveIKChainPoseOpFixedSettings_t {
                pub const m_ChainsToSolveData: i64 = 0x0;
            }
            pub mod CModelConfigElement_SetRenderColor {
                pub const m_Color: i64 = 0x48;
            }
            pub mod CNmBoneMaskSwitchNode__CDefinition {
                pub const m_nTrueValueNodeIdx: i64 = 0x12;
                pub const m_bSwitchDynamically: i64 = 0x1C;
                pub const m_flBlendTimeSeconds: i64 = 0x18;
                pub const m_nFalseValueNodeIdx: i64 = 0x14;
                pub const m_nSwitchValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmFloatAngleMathNode__CDefinition {
                pub const m_operation: i64 = 0x12;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmSpeedScaleBaseNode__CDefinition {
                pub const m_nInputValueNodeIdx: i64 = 0x18;
                pub const m_flDefaultInputValue: i64 = 0x1C;
            }
            pub mod CNmTargetSelectorNode__CDefinition {
                pub const m_alignmentBoneID: i64 = 0x38;
                pub const m_parameterNodeIdx: i64 = 0x30;
                pub const m_optionNodeIndices: i64 = 0x10;
                pub const m_bIsWorldSpaceTarget: i64 = 0x33;
                pub const m_bIgnoreInvalidOptions: i64 = 0x32;
                pub const m_flPositionScoreWeight: i64 = 0x2C;
                pub const m_flOrientationScoreWeight: i64 = 0x28;
            }
            pub mod CParticleCollectionBindingInstance {

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
            pub mod CNmFloatComparisonNode__CDefinition {
                pub const m_flEpsilon: i64 = 0x18;
                pub const m_comparison: i64 = 0x14;
                pub const m_flComparisonValue: i64 = 0x1C;
                pub const m_nInputValueNodeIdx: i64 = 0x10;
                pub const m_nComparandValueNodeIdx: i64 = 0x12;
            }
            pub mod CNmFloatCurveEventNode__CDefinition {
                pub const m_eventID: i64 = 0x10;
                pub const m_flDefaultValue: i64 = 0x1C;
                pub const m_nDefaultNodeIdx: i64 = 0x18;
                pub const m_eventConditionRules: i64 = 0x20;
            }
            pub mod CNmFootstepEventIDNode__CDefinition {
                pub const m_eventConditionRules: i64 = 0x14;
                pub const m_nSourceStateNodeIdx: i64 = 0x10;
            }
            pub mod CNmIDBasedSelectorNode__CDefinition {
                pub const m_optionIDs: i64 = 0x28;
                pub const m_nFallbackNodeIdx: i64 = 0x5A;
                pub const m_nParameterNodeIdx: i64 = 0x58;
                pub const m_optionNodeIndices: i64 = 0x10;
                pub const m_bIgnoreInvalidOptions: i64 = 0x5C;
            }
            pub mod CNmOrientationWarpNode__CDefinition {
                pub const m_samplingMode: i64 = 0x18;
                pub const m_alignmentMode: i64 = 0x17;
                pub const m_bIsOffsetNode: i64 = 0x14;
                pub const m_bWarpTranslation: i64 = 0x16;
                pub const m_nTargetValueNodeIdx: i64 = 0x12;
                pub const m_nClipReferenceNodeIdx: i64 = 0x10;
                pub const m_bIsOffsetRelativeToCharacter: i64 = 0x15;
            }
            pub mod CNmReferencedGraphNode__CDefinition {
                pub const m_nFallbackNodeIdx: i64 = 0x12;
                pub const m_nReferencedGraphIdx: i64 = 0x10;
            }
            pub mod CParticleCollectionRendererVecInput {

            }
            pub mod SkeletonAnimCapture_t__FrameStamp_t {
                pub const m_flTime: i64 = 0x0;
                pub const m_flCurTime: i64 = 0xC;
                pub const m_bPredicted: i64 = 0x9;
                pub const m_flRealTime: i64 = 0x10;
                pub const m_nTickCount: i64 = 0x18;
                pub const m_nFrameCount: i64 = 0x14;
                pub const m_bTeleportTick: i64 = 0x8;
                pub const m_flEntitySimTime: i64 = 0x4;
            }
            pub mod CModelConfigElement_SetMaterialGroup {
                pub const m_MaterialGroupName: i64 = 0x48;
            }
            pub mod CNmBoneMaskSelectorNode__CDefinition {
                pub const m_maskNodeIndices: i64 = 0x18;
                pub const m_parameterValues: i64 = 0x30;
                pub const m_bSwitchDynamically: i64 = 0x14;
                pub const m_defaultMaskNodeIdx: i64 = 0x10;
                pub const m_flBlendTimeSeconds: i64 = 0x70;
                pub const m_parameterValueNodeIdx: i64 = 0x12;
            }
            pub mod CNmCurrentSyncEventNode__CDefinition {
                pub const m_infoType: i64 = 0x12;
                pub const m_nSourceStateNodeIdx: i64 = 0x10;
            }
            pub mod CNmIDEventConditionNode__CDefinition {
                pub const m_eventIDs: i64 = 0x18;
                pub const m_eventConditionRules: i64 = 0x14;
                pub const m_nSourceStateNodeIdx: i64 = 0x10;
            }
            pub mod CNmLayerBlendNode__LayerDefinition_t {
                pub const m_blendMode: i64 = 0xB;
                pub const m_bIgnoreEvents: i64 = 0x9;
                pub const m_nInputNodeIdx: i64 = 0x0;
                pub const m_bIsSynchronized: i64 = 0x8;
                pub const m_nWeightValueNodeIdx: i64 = 0x2;
                pub const m_bIsStateMachineLayer: i64 = 0xA;
                pub const m_nBoneMaskValueNodeIdx: i64 = 0x4;
                pub const m_nRootMotionWeightValueNodeIdx: i64 = 0x6;
            }
            pub mod CPulseCell_Timeline__TimelineEvent_t {
                pub const m_EventOutflow: i64 = 0x8;
                pub const m_flTimeFromPrevious: i64 = 0x0;
            }
            pub mod CPulseCell_WaitForCursorsWithTagBase {
                pub const m_WaitComplete: i64 = 0xE0;
                pub const m_nCursorsAllowedToWait: i64 = 0xD8;
            }
            pub mod PulseGraphExecutionHistoryNodeDesc_t {
                pub const strCellDesc: i64 = 0x0;
                pub const strBindingName: i64 = 0x10;
            }
            pub mod CBoneConstraintPoseSpaceBone__Input_t {
                pub const m_inputValue: i64 = 0x0;
                pub const m_outputTransformList: i64 = 0x10;
            }
            pub mod CNmIsExternalPoseSetNode__CDefinition {
                pub const m_nExternalPoseNodeIdx: i64 = 0x10;
            }
            pub mod CParticleCollectionRendererFloatInput {

            }
            pub mod CAnimationGraphVisualizerPrimitiveBase {
                pub const m_Type: i64 = 0x8;
                pub const m_OwningAnimNodePaths: i64 = 0xC;
                pub const m_nOwningAnimNodePathCount: i64 = 0x38;
            }
            pub mod CBoneConstraintPoseSpaceMorph__Input_t {
                pub const m_inputValue: i64 = 0x0;
                pub const m_outputWeightList: i64 = 0x10;
            }
            pub mod CNmClip__ModelSpaceSamplingChainLink_t {
                pub const m_nBoneIdx: i64 = 0x0;
                pub const m_nParentBoneIdx: i64 = 0x4;
                pub const m_nParentChainLinkIdx: i64 = 0x8;
            }
            pub mod CNmControlParameterIDNode__CDefinition {

            }
            pub mod CNmCurrentSyncEventIDNode__CDefinition {
                pub const m_nSourceStateNodeIdx: i64 = 0x10;
            }
            pub mod CNmFloatChannelData__ChannelSettings_t {
                pub const m_range: i64 = 0x0;
                pub const m_bIsStatic: i64 = 0x8;
            }
            pub mod CNmFootEventConditionNode__CDefinition {
                pub const m_phaseCondition: i64 = 0x12;
                pub const m_eventConditionRules: i64 = 0x14;
                pub const m_nSourceStateNodeIdx: i64 = 0x10;
            }
            pub mod CNmGraphDefinition__ExternalPoseSlot_t {
                pub const m_slotID: i64 = 0x8;
                pub const m_nNodeIdx: i64 = 0x0;
            }
            pub mod CNmParameterizedBlendNode__CDefinition {
                pub const m_bAllowLooping: i64 = 0x2A;
                pub const m_sourceNodeIndices: i64 = 0x10;
                pub const m_nInputParameterValueNodeIdx: i64 = 0x28;
            }
            pub mod CNmRootMotionOverrideNode__CDefinition {
                pub const m_overrideFlags: i64 = 0x2C;
                pub const m_enabledNodeIdx: i64 = 0x20;
                pub const m_maxLinearVelocity: i64 = 0x24;
                pub const m_maxAngularVelocityRadians: i64 = 0x28;
                pub const m_linearVelocityLimitNodeIdx: i64 = 0x1C;
                pub const m_angularVelocityLimitNodeIdx: i64 = 0x1E;
                pub const m_desiredMovingVelocityNodeIdx: i64 = 0x18;
                pub const m_desiredFacingDirectionNodeIdx: i64 = 0x1A;
            }
            pub mod CNmStateMachineNode__StateDefinition_t {
                pub const m_nStateNodeIdx: i64 = 0x0;
                pub const m_transitionDefinitions: i64 = 0x8;
                pub const m_nEntryConditionNodeIdx: i64 = 0x2;
            }
            pub mod CNmTimeControlledClipNode__CDefinition {
                pub const m_graphEvents: i64 = 0x18;
                pub const m_nDataSlotIdx: i64 = 0x14;
                pub const m_bSampleRootMotion: i64 = 0x12;
                pub const m_nTimeValueNodeIdx: i64 = 0x16;
                pub const m_nPlayInReverseValueNodeIdx: i64 = 0x10;
            }
            pub mod CNmVirtualParameterIDNode__CDefinition {
                pub const m_nChildNodeIdx: i64 = 0x10;
            }
            pub mod CPulseCell_LimitCount__InstanceState_t {
                pub const m_nCurrentCount: i64 = 0x0;
            }
            pub mod PulseGraphExecutionHistoryCursorDesc_t {
                pub const nSpawnNodeID: i64 = 0x18;
                pub const flLastReferenced: i64 = 0x20;
                pub const nRetiredAtNodeID: i64 = 0x1C;
                pub const nLastValidEntryIdx: i64 = 0x24;
                pub const vecAncestorCursorIDs: i64 = 0x0;
                pub const bWasAnObservableComputation: i64 = 0x28;
            }
            pub mod PulseRuntimeBlackboardReferenceIndex_t {
                pub const m_Value: i64 = 0x0;
            }
            pub mod CCurrentRotationVelocityMetricEvaluator {

            }
            pub mod CNmFixedWeightBoneMaskNode__CDefinition {
                pub const m_flBoneWeight: i64 = 0x10;
            }
            pub mod CNmGraphDefinition__ExternalGraphSlot_t {
                pub const m_slotID: i64 = 0x8;
                pub const m_nNodeIdx: i64 = 0x0;
            }
            pub mod CNmGraphEventConditionNode__CDefinition {
                pub const m_conditions: i64 = 0x18;
                pub const m_eventConditionRules: i64 = 0x14;
                pub const m_nSourceStateNodeIdx: i64 = 0x10;
            }
            pub mod CNmGraphEventConditionNode__Condition_t {
                pub const m_eventID: i64 = 0x0;
                pub const m_eventTypeCondition: i64 = 0x8;
            }
            pub mod CNmIDBasedClipSelectorNode__CDefinition {
                pub const m_optionIDs: i64 = 0x28;
                pub const m_nFallbackNodeIdx: i64 = 0x5A;
                pub const m_nParameterNodeIdx: i64 = 0x58;
                pub const m_optionNodeIndices: i64 = 0x10;
                pub const m_bIgnoreInvalidOptions: i64 = 0x5C;
            }
            pub mod CNmParameterizedBlendNode__BlendRange_t {
                pub const m_nInputIdx0: i64 = 0x0;
                pub const m_nInputIdx1: i64 = 0x2;
                pub const m_parameterValueRange: i64 = 0x4;
            }
            pub mod CPulseCell_IntervalTimer__CursorState_t {
                pub const m_EndTime: i64 = 0x4;
                pub const m_StartTime: i64 = 0x0;
                pub const m_flWaitInterval: i64 = 0x8;
                pub const m_flWaitIntervalHigh: i64 = 0xC;
                pub const m_bCompleteOnNextWake: i64 = 0x10;
            }
            pub mod CMaterialDrawDescriptor__RigidMeshPart_t {
                pub const m_nBoneIndex: i64 = 0x2;
                pub const m_nPrimitiveCount: i64 = 0x8;
                pub const m_nRigidBLASIndex: i64 = 0x0;
                pub const m_nStartIndexOffset: i64 = 0x4;
            }
            pub mod CNmControlParameterBoolNode__CDefinition {

            }
            pub mod CNmFloatRangeComparisonNode__CDefinition {
                pub const m_range: i64 = 0x10;
                pub const m_bIsInclusiveCheck: i64 = 0x1A;
                pub const m_nInputValueNodeIdx: i64 = 0x18;
            }
            pub mod CNmVirtualParameterBoolNode__CDefinition {
                pub const m_nChildNodeIdx: i64 = 0x10;
            }
            pub mod PermModelDataAnimatedMaterialAttribute_t {
                pub const m_nNumChannels: i64 = 0x8;
                pub const m_AttributeName: i64 = 0x0;
            }
            pub mod CNmControlParameterFloatNode__CDefinition {

            }
            pub mod CNmGraphDefinition__ReferencedGraphSlot_t {
                pub const m_nNodeIdx: i64 = 0x0;
                pub const m_dataSlotIdx: i64 = 0x2;
            }
            pub mod CNmParameterizedSelectorNode__CDefinition {
                pub const m_optionWeights: i64 = 0x28;
                pub const m_bHasWeightsSet: i64 = 0x3B;
                pub const m_parameterNodeIdx: i64 = 0x38;
                pub const m_optionNodeIndices: i64 = 0x10;
                pub const m_bIgnoreInvalidOptions: i64 = 0x3A;
            }
            pub mod CNmVirtualParameterFloatNode__CDefinition {
                pub const m_nChildNodeIdx: i64 = 0x10;
            }
            pub mod CPulseCell_IsRequirementValid__Criteria_t {
                pub const m_bIsValid: i64 = 0x0;
            }
            pub mod CSceneObjectData__RTProxyDrawDescriptor_t {
                pub const m_drawDesc: i64 = 0x8;
                pub const m_nSrcDrawIndex: i64 = 0x4;
                pub const m_fEmissiveFactor: i64 = 0x164;
                pub const m_mWorldFromLocal: i64 = 0x128;
                pub const m_nVertexAlbedoVB: i64 = 0x159;
                pub const m_nVertexEmissiveVB: i64 = 0x15F;
                pub const m_materialGroupToken: i64 = 0x0;
                pub const m_nVertexAlbedoFormat: i64 = 0x158;
                pub const m_nVertexAlbedoOffset: i64 = 0x15A;
                pub const m_nVertexAlbedoStride: i64 = 0x15C;
                pub const m_nVertexEmissiveFormat: i64 = 0x15E;
                pub const m_nVertexEmissiveOffset: i64 = 0x160;
                pub const m_nVertexEmissiveStride: i64 = 0x162;
            }
            pub mod CNmControlParameterTargetNode__CDefinition {

            }
            pub mod CNmControlParameterVectorNode__CDefinition {

            }
            pub mod CNmVirtualParameterTargetNode__CDefinition {
                pub const m_nChildNodeIdx: i64 = 0x10;
            }
            pub mod CNmVirtualParameterVectorNode__CDefinition {
                pub const m_nChildNodeIdx: i64 = 0x10;
            }
            pub mod CNmStateCompletedConditionNode__CDefinition {
                pub const m_nSourceStateNodeIdx: i64 = 0x10;
                pub const m_flTransitionDurationSeconds: i64 = 0x14;
                pub const m_nTransitionDurationOverrideNodeIdx: i64 = 0x12;
            }
            pub mod CNmStateMachineNode__TransitionDefinition_t {
                pub const m_bCanBeForced: i64 = 0x6;
                pub const m_nTargetStateIdx: i64 = 0x0;
                pub const m_nConditionNodeIdx: i64 = 0x2;
                pub const m_nTransitionNodeIdx: i64 = 0x4;
            }
            pub mod CNmSyncEventIndexConditionNode__CDefinition {
                pub const m_triggerMode: i64 = 0x12;
                pub const m_syncEventIdx: i64 = 0x14;
                pub const m_nSourceStateNodeIdx: i64 = 0x10;
            }
            pub mod CNmVelocityBasedSpeedScaleNode__CDefinition {

            }
            pub mod CNmIDEventPercentageThroughNode__CDefinition {
                pub const m_eventID: i64 = 0x18;
                pub const m_eventConditionRules: i64 = 0x14;
                pub const m_nSourceStateNodeIdx: i64 = 0x10;
            }
            pub mod CNmTransitionEventConditionNode__CDefinition {
                pub const m_requireRuleID: i64 = 0x10;
                pub const m_ruleCondition: i64 = 0x1E;
                pub const m_eventConditionRules: i64 = 0x18;
                pub const m_nSourceStateNodeIdx: i64 = 0x1C;
            }
            pub mod CNmVirtualParameterBoneMaskNode__CDefinition {
                pub const m_nChildNodeIdx: i64 = 0x10;
            }
            pub mod CPulseCell_Inflow_ObservableVariableListener {
                pub const m_bSelfReference: i64 = 0x82;
                pub const m_nBlackboardReference: i64 = 0x80;
            }
            pub mod NmCompressionSettings_t__QuantizationRange_t {
                pub const m_flRangeStart: i64 = 0x0;
                pub const m_flRangeLength: i64 = 0x4;
            }
            pub mod PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                pub const m_OutflowID: i64 = 0x0;
                pub const m_Connection: i64 = 0x8;
            }
            pub mod CNmIsExternalGraphSlotFilledNode__CDefinition {
                pub const m_nExternalGraphNodeIdx: i64 = 0x10;
            }
            pub mod CNmIsInactiveBranchConditionNode__CDefinition {

            }
            pub mod CNmParameterizedBlendNode__Parameterization_t {
                pub const m_blendRanges: i64 = 0x0;
                pub const m_parameterRange: i64 = 0x48;
            }
            pub mod CNmParameterizedClipSelectorNode__CDefinition {
                pub const m_optionWeights: i64 = 0x28;
                pub const m_bHasWeightsSet: i64 = 0x3B;
                pub const m_parameterNodeIdx: i64 = 0x38;
                pub const m_optionNodeIndices: i64 = 0x10;
                pub const m_bIgnoreInvalidOptions: i64 = 0x3A;
            }
            pub mod CModelConfigElement_SetBodygroupOnAttachedModels {
                pub const m_nChoice: i64 = 0x50;
                pub const m_GroupName: i64 = 0x48;
            }
            pub mod CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                pub const m_nNextIndex: i64 = 0x0;
            }
            pub mod CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                pub const m_Shuffle: i64 = 0x0;
                pub const m_nNextShuffle: i64 = 0x20;
            }
            pub mod CNmFootstepEventPercentageThroughNode__CDefinition {
                pub const m_phaseCondition: i64 = 0x12;
                pub const m_eventConditionRules: i64 = 0x14;
                pub const m_nSourceStateNodeIdx: i64 = 0x10;
            }
            pub mod CModelConfigElement_SetMaterialGroupOnAttachedModels {
                pub const m_MaterialGroupName: i64 = 0x48;
            }
            pub mod SeqCmd_t {
                pub const SeqCmd_Add: i64 = 0x4;
                pub const SeqCmd_Nop: i64 = 0x0;
                pub const SeqCmd_Copy: i64 = 0x7;
                pub const SeqCmd_Blend: i64 = 0x8;
                pub const SeqCmd_Scale: i64 = 0x6;
                pub const SeqCmd_Slerp: i64 = 0x3;
                pub const SeqCmd_Sequence: i64 = 0xA;
                pub const SeqCmd_Subtract: i64 = 0x5;
                pub const SeqCmd_Transform: i64 = 0x10;
                pub const SeqCmd_FetchCycle: i64 = 0xB;
                pub const SeqCmd_FetchFrame: i64 = 0xC;
                pub const SeqCmd_Worldspace: i64 = 0x9;
                pub const SeqCmd_LinearDelta: i64 = 0x1;
                pub const SeqCmd_IKRestoreAll: i64 = 0xE;
                pub const SeqCmd_IKLockInPlace: i64 = 0xD;
                pub const SeqCmd_FetchFrameRange: i64 = 0x2;
                pub const SeqCmd_ReverseSequence: i64 = 0xF;
            }
            pub mod StepPhase {
                pub const StepPhase_InAir: i64 = 0x1;
                pub const StepPhase_OnGround: i64 = 0x0;
            }
            pub mod FacingMode {
                pub const FacingMode_Path: i64 = 0x2;
                pub const FacingMode_Manual: i64 = 0x1;
                pub const FacingMode_Invalid: i64 = 0x0;
                pub const FacingMode_LookTarget: i64 = 0x3;
                pub const FacingMode_ManualPosition: i64 = 0x4;
            }
            pub mod MoodType_t {
                pub const eMoodType_Body: i64 = 0x1;
                pub const eMoodType_Head: i64 = 0x0;
            }
            pub mod PoseType_t {
                pub const POSETYPE_STATIC: i64 = 0x0;
                pub const POSETYPE_DYNAMIC: i64 = 0x1;
                pub const POSETYPE_INVALID: i64 = 0xFF;
            }
            pub mod Blend2DMode {
                pub const Blend2DMode_General: i64 = 0x0;
                pub const Blend2DMode_Directional: i64 = 0x1;
            }
            pub mod BlendKeyType {
                pub const BlendKey_Distance: i64 = 0x2;
                pub const BlendKey_Velocity: i64 = 0x1;
                pub const BlendKey_UserValue: i64 = 0x0;
                pub const BlendKey_RemainingDistance: i64 = 0x3;
            }
            pub mod ChoiceMethod {
                pub const Iterate: i64 = 0x2;
                pub const IterateRandom: i64 = 0x3;
                pub const WeightedRandom: i64 = 0x0;
                pub const WeightedRandomNoRepeat: i64 = 0x1;
            }
            pub mod FlexOpCode_t {
                pub const FLEX_OP_ABS: i64 = 0x1A;
                pub const FLEX_OP_ADD: i64 = 0x4;
                pub const FLEX_OP_COS: i64 = 0x19;
                pub const FLEX_OP_DIV: i64 = 0x7;
                pub const FLEX_OP_EXP: i64 = 0x9;
                pub const FLEX_OP_MAX: i64 = 0xD;
                pub const FLEX_OP_MIN: i64 = 0xE;
                pub const FLEX_OP_MUL: i64 = 0x6;
                pub const FLEX_OP_NEG: i64 = 0x8;
                pub const FLEX_OP_SIN: i64 = 0x18;
                pub const FLEX_OP_SUB: i64 = 0x5;
                pub const FLEX_OP_NWAY: i64 = 0x11;
                pub const FLEX_OP_OPEN: i64 = 0xA;
                pub const FLEX_OP_SQRT: i64 = 0x16;
                pub const FLEX_OP_CLOSE: i64 = 0xB;
                pub const FLEX_OP_COMBO: i64 = 0x12;
                pub const FLEX_OP_COMMA: i64 = 0xC;
                pub const FLEX_OP_CONST: i64 = 0x1;
                pub const FLEX_OP_2WAY_0: i64 = 0xF;
                pub const FLEX_OP_2WAY_1: i64 = 0x10;
                pub const FLEX_OP_FETCH1: i64 = 0x2;
                pub const FLEX_OP_FETCH2: i64 = 0x3;
                pub const FLEX_OP_DOMINATE: i64 = 0x13;
                pub const FLEX_OP_REMAPVALCLAMPED: i64 = 0x17;
                pub const FLEX_OP_DME_LOWER_EYELID: i64 = 0x14;
                pub const FLEX_OP_DME_UPPER_EYELID: i64 = 0x15;
            }
            pub mod IKSolverType {
                pub const IKSOLVER_CCD: i64 = 0x4;
                pub const IKSOLVER_COUNT: i64 = 0x5;
                pub const IKSOLVER_Fabrik: i64 = 0x2;
                pub const IKSOLVER_Perlin: i64 = 0x0;
                pub const IKSOLVER_TwoBone: i64 = 0x1;
                pub const IKSOLVER_DogLeg3Bone: i64 = 0x3;
            }
            pub mod IkTargetType {
                pub const IkTarget_Bone: i64 = 0x1;
                pub const IkTarget_Attachment: i64 = 0x0;
                pub const IkTarget_Parameter_ModelSpace: i64 = 0x2;
                pub const IkTarget_Parameter_WorldSpace: i64 = 0x3;
            }
            pub mod IKChannelMode {
                pub const OneBone: i64 = 0x2;
                pub const TwoBone: i64 = 0x0;
                pub const OneBone_Translate: i64 = 0x3;
                pub const TwoBone_Translate: i64 = 0x1;
            }
            pub mod NmFootPhase_t {
                pub const _None: i64 = 0x4;
                pub const LeftFootDown: i64 = 0x0;
                pub const RightFootDown: i64 = 0x2;
                pub const LeftFootPassing: i64 = 0x3;
                pub const RightFootPassing: i64 = 0x1;
            }
            pub mod PFNoiseType_t {
                pub const PF_NOISE_TYPE_CURL: i64 = 0x3;
                pub const PF_NOISE_TYPE_PERLIN: i64 = 0x0;
                pub const PF_NOISE_TYPE_WORLEY: i64 = 0x2;
                pub const PF_NOISE_TYPE_SIMPLEX: i64 = 0x1;
            }
            pub mod AnimScriptType {
                pub const ANIMSCRIPT_FUSE_GENERAL: i64 = 0x0;
                pub const ANIMSCRIPT_TYPE_INVALID: i64 = -0x1;
                pub const ANIMSCRIPT_FUSE_STATEMACHINE: i64 = 0x1;
            }
            pub mod IKTargetSource {
                pub const IKTARGETSOURCE_Bone: i64 = 0x0;
                pub const IKTARGETSOURCE_COUNT: i64 = 0x2;
                pub const IKTARGETSOURCE_AnimgraphParameter: i64 = 0x1;
            }
            pub mod AnimParamType_t {
                pub const ANIMPARAM_INT: i64 = 0x3;
                pub const ANIMPARAM_BOOL: i64 = 0x1;
                pub const ANIMPARAM_ENUM: i64 = 0x2;
                pub const ANIMPARAM_COUNT: i64 = 0x8;
                pub const ANIMPARAM_FLOAT: i64 = 0x4;
                pub const ANIMPARAM_VECTOR: i64 = 0x5;
                pub const ANIMPARAM_UNKNOWN: i64 = 0x0;
                pub const ANIMPARAM_QUATERNION: i64 = 0x6;
                pub const ANIMPARAM_GLOBALSYMBOL: i64 = 0x7;
            }
            pub mod AnimValueSource {
                pub const SlopeYaw: i64 = 0x14;
                pub const LookPitch: i64 = 0x7;
                pub const MoveSpeed: i64 = 0x1;
                pub const Parameter: i64 = 0x9;
                pub const SlopeAngle: i64 = 0x12;
                pub const SlopePitch: i64 = 0x13;
                pub const LookHeading: i64 = 0x5;
                pub const MoveHeading: i64 = 0x0;
                pub const StrafeSpeed: i64 = 0x3;
                pub const ForwardSpeed: i64 = 0x2;
                pub const GoalDistance: i64 = 0x15;
                pub const LookDistance: i64 = 0x8;
                pub const MaxMoveSpeed: i64 = 0x1B;
                pub const SlopeHeading: i64 = 0x11;
                pub const FacingHeading: i64 = 0x4;
                pub const BoundaryRadius: i64 = 0xC;
                pub const FingerCurl_Ring: i64 = 0x1F;
                pub const RootMotionSpeed: i64 = 0x18;
                pub const TargetMoveSpeed: i64 = 0xE;
                pub const WayPointHeading: i64 = 0xA;
                pub const FingerCurl_Index: i64 = 0x1D;
                pub const FingerCurl_Pinky: i64 = 0x20;
                pub const FingerCurl_Thumb: i64 = 0x1C;
                pub const WayPointDistance: i64 = 0xB;
                pub const AccelerationSpeed: i64 = 0x10;
                pub const FingerCurl_Middle: i64 = 0x1E;
                pub const TargetMoveHeading: i64 = 0xD;
                pub const AccelerationHeading: i64 = 0xF;
                pub const RootMotionTurnSpeed: i64 = 0x19;
                pub const AccelerationFrontBack: i64 = 0x17;
                pub const AccelerationLeftRight: i64 = 0x16;
                pub const LookHeadingNormalized: i64 = 0x6;
                pub const FingerSplay_Ring_Pinky: i64 = 0x24;
                pub const FingerSplay_Middle_Ring: i64 = 0x23;
                pub const FingerSplay_Thumb_Index: i64 = 0x21;
                pub const FingerSplay_Index_Middle: i64 = 0x22;
                pub const MoveHeadingRelativeToLookHeading: i64 = 0x1A;
            }
            pub mod AnimationType_t {
                pub const ANIMATION_TYPE_FIXED_RATE: i64 = 0x0;
                pub const ANIMATION_TYPE_FIT_LIFETIME: i64 = 0x1;
                pub const ANIMATION_TYPE_MANUAL_FRAMES: i64 = 0x2;
            }
            pub mod NmIKBlendMode_t {
                pub const Pose: i64 = 0x1;
                pub const Effector: i64 = 0x0;
            }
            pub mod TagActionStatus {
                pub const Fired: i64 = 0x2;
                pub const Active: i64 = 0x1;
                pub const Inactive: i64 = 0x0;
            }
            pub mod AnimVectorSource {
                pub const LookTarget: i64 = 0x8;
                pub const SlopeNormal: i64 = 0x6;
                pub const Acceleration: i64 = 0x5;
                pub const GoalPosition: i64 = 0xB;
                pub const LookDirection: i64 = 0x2;
                pub const MoveDirection: i64 = 0x0;
                pub const FacingPosition: i64 = 0x1;
                pub const VectorParameter: i64 = 0x3;
                pub const WayPointPosition: i64 = 0xA;
                pub const WayPointDirection: i64 = 0x4;
                pub const RootMotionVelocity: i64 = 0xC;
                pub const LookTarget_WorldSpace: i64 = 0x9;
                pub const SlopeNormal_WorldSpace: i64 = 0x7;
                pub const ManualTarget_WorldSpace: i64 = 0xD;
            }
            pub mod BinaryNodeTiming {
                pub const UseChild1: i64 = 0x0;
                pub const UseChild2: i64 = 0x1;
                pub const SyncChildren: i64 = 0x2;
            }
            pub mod PulseValueType_t {
                pub const PVAL_INT: i64 = 0x1;
                pub const PVAL_BOOL: i64 = 0x0;
                pub const PVAL_VEC2: i64 = 0x4;
                pub const PVAL_VEC3: i64 = 0x5;
                pub const PVAL_VEC4: i64 = 0x8;
                pub const PVAL_VOID: i64 = -0x1;
                pub const PVAL_ARRAY: i64 = 0x1C;
                pub const PVAL_COUNT: i64 = 0x21;
                pub const PVAL_FLOAT: i64 = 0x2;
                pub const PVAL_QANGLE: i64 = 0x6;
                pub const PVAL_STRING: i64 = 0x3;
                pub const PVAL_EHANDLE: i64 = 0xD;
                pub const PVAL_UNKNOWN: i64 = 0x18;
                pub const PVAL_VARIANT: i64 = 0x17;
                pub const PVAL_GAMETIME: i64 = 0xC;
                pub const PVAL_RESOURCE: i64 = 0xE;
                pub const PVAL_COLOR_RGB: i64 = 0xB;
                pub const PVAL_TRANSFORM: i64 = 0x9;
                pub const PVAL_CURSOR_FLOW: i64 = 0x16;
                pub const PVAL_ENTITY_NAME: i64 = 0x12;
                pub const PVAL_SCHEMA_ENUM: i64 = 0x19;
                pub const PVAL_SNDEVT_GUID: i64 = 0x10;
                pub const PVAL_SNDEVT_NAME: i64 = 0x11;
                pub const PVAL_TEST_HANDLE: i64 = 0x1B;
                pub const PVAL_TYPESAFE_INT: i64 = 0x14;
                pub const PVAL_VDATA_CHOICE: i64 = 0x20;
                pub const PVAL_ANIM_SEQUENCE: i64 = 0x1F;
                pub const PVAL_OPAQUE_HANDLE: i64 = 0x13;
                pub const PVAL_RESOURCE_NAME: i64 = 0xF;
                pub const PVAL_TYPESAFE_INT64: i64 = 0x1D;
                pub const PVAL_VEC3_WORLDSPACE: i64 = 0x7;
                pub const PVAL_PARTICLE_EHANDLE: i64 = 0x1E;
                pub const PVAL_MODEL_MATERIAL_GROUP: i64 = 0x15;
                pub const PVAL_TRANSFORM_WORLDSPACE: i64 = 0xA;
                pub const PVAL_PANORAMA_PANEL_HANDLE: i64 = 0x1A;
            }
            pub mod ResetCycleOption {
                pub const Beginning: i64 = 0x0;
                pub const FixedValue: i64 = 0x3;
                pub const SameTimeAsSource: i64 = 0x4;
                pub const SameCycleAsSource: i64 = 0x1;
                pub const InverseSourceCycle: i64 = 0x2;
            }
            pub mod ScriptedMoveTo_t {
                pub const eWait: i64 = 0x0;
                pub const eTeleport: i64 = 0x4;
                pub const eWaitFacing: i64 = 0x5;
                pub const eMoveWithGait: i64 = 0x3;
                pub const eObsoleteBackCompat1: i64 = 0x1;
                pub const eObsoleteBackCompat2: i64 = 0x2;
            }
            pub mod SeqPoseSetting_t {
                pub const SEQ_POSE_SETTING_CONSTANT: i64 = 0x0;
                pub const SEQ_POSE_SETTING_POSITION: i64 = 0x2;
                pub const SEQ_POSE_SETTING_ROTATION: i64 = 0x1;
                pub const SEQ_POSE_SETTING_VELOCITY: i64 = 0x3;
            }
            pub mod AnimParamButton_t {
                pub const ANIMPARAM_BUTTON_A: i64 = 0x5;
                pub const ANIMPARAM_BUTTON_B: i64 = 0x6;
                pub const ANIMPARAM_BUTTON_X: i64 = 0x7;
                pub const ANIMPARAM_BUTTON_Y: i64 = 0x8;
                pub const ANIMPARAM_BUTTON_NONE: i64 = 0x0;
                pub const ANIMPARAM_BUTTON_DPAD_UP: i64 = 0x1;
                pub const ANIMPARAM_BUTTON_LTRIGGER: i64 = 0xB;
                pub const ANIMPARAM_BUTTON_RTRIGGER: i64 = 0xC;
                pub const ANIMPARAM_BUTTON_DPAD_DOWN: i64 = 0x3;
                pub const ANIMPARAM_BUTTON_DPAD_LEFT: i64 = 0x4;
                pub const ANIMPARAM_BUTTON_DPAD_RIGHT: i64 = 0x2;
                pub const ANIMPARAM_BUTTON_LEFT_SHOULDER: i64 = 0x9;
                pub const ANIMPARAM_BUTTON_RIGHT_SHOULDER: i64 = 0xA;
            }
            pub mod ChoiceBlendMethod {
                pub const SingleBlendTime: i64 = 0x0;
                pub const PerChoiceBlendTimes: i64 = 0x1;
            }
            pub mod FootFallTagFoot_t {
                pub const FOOT1: i64 = 0x0;
                pub const FOOT2: i64 = 0x1;
                pub const FOOT3: i64 = 0x2;
                pub const FOOT4: i64 = 0x3;
                pub const FOOT5: i64 = 0x4;
                pub const FOOT6: i64 = 0x5;
                pub const FOOT7: i64 = 0x6;
                pub const FOOT8: i64 = 0x7;
            }
            pub mod IkEndEffectorType {
                pub const IkEndEffector_Bone: i64 = 0x1;
                pub const IkEndEffector_Attachment: i64 = 0x0;
            }
            pub mod MorphBundleType_t {
                pub const MORPH_BUNDLE_TYPE_NONE: i64 = 0x0;
                pub const MORPH_BUNDLE_TYPE_COUNT: i64 = 0x3;
                pub const MORPH_BUNDLE_TYPE_NORMAL_WRINKLE: i64 = 0x2;
                pub const MORPH_BUNDLE_TYPE_POSITION_SPEED: i64 = 0x1;
            }
            pub mod NmPoseBlendMode_t {
                pub const Overlay: i64 = 0x0;
                pub const Additive: i64 = 0x1;
                pub const ModelSpace: i64 = 0x2;
            }
            pub mod PFNoiseModifier_t {
                pub const PF_NOISE_MODIFIER_NONE: i64 = 0x0;
                pub const PF_NOISE_MODIFIER_LINES: i64 = 0x1;
                pub const PF_NOISE_MODIFIER_RINGS: i64 = 0x3;
                pub const PF_NOISE_MODIFIER_CLUMPS: i64 = 0x2;
            }
            pub mod ParticleVecType_t {
                pub const PVEC_TYPE_COUNT: i64 = 0x13;
                pub const PVEC_TYPE_INVALID: i64 = -0x1;
                pub const PVEC_TYPE_LITERAL: i64 = 0x0;
                pub const PVEC_TYPE_CP_DELTA: i64 = 0x11;
                pub const PVEC_TYPE_CP_VALUE: i64 = 0x7;
                pub const PVEC_TYPE_NAMED_VALUE: i64 = 0x2;
                pub const PVEC_TYPE_LITERAL_COLOR: i64 = 0x1;
                pub const PVEC_TYPE_RANDOM_UNIFORM: i64 = 0xF;
                pub const PVEC_TYPE_CP_RELATIVE_DIR: i64 = 0x9;
                pub const PVEC_TYPE_PARTICLE_VECTOR: i64 = 0x3;
                pub const PVEC_TYPE_FLOAT_COMPONENTS: i64 = 0xB;
                pub const PVEC_TYPE_PARTICLE_GRAVITY: i64 = 0x6;
                pub const PVEC_TYPE_FLOAT_INTERP_OPEN: i64 = 0xD;
                pub const PVEC_TYPE_PARTICLE_VELOCITY: i64 = 0x5;
                pub const PVEC_TYPE_CP_RELATIVE_POSITION: i64 = 0x8;
                pub const PVEC_TYPE_FLOAT_INTERP_CLAMPED: i64 = 0xC;
                pub const PVEC_TYPE_FLOAT_INTERP_GRADIENT: i64 = 0xE;
                pub const PVEC_TYPE_RANDOM_UNIFORM_OFFSET: i64 = 0x10;
                pub const PVEC_TYPE_CP_RELATIVE_RANDOM_DIR: i64 = 0xA;
                pub const PVEC_TYPE_CLOSEST_CAMERA_POSITION: i64 = 0x12;
                pub const PVEC_TYPE_PARTICLE_INITIAL_VECTOR: i64 = 0x4;
            }
            pub mod PulseApiFeature_t {
                pub const AF_NONE: i64 = 0x0;
                pub const AF_ENTITIES: i64 = 0x1;
                pub const AF_PANORAMA: i64 = 0x2;
                pub const AF_PARTICLES: i64 = 0x8;
                pub const AF_FAKE_ENTITIES: i64 = 0x10;
                pub const AF_SELECTORS_WITHOUT_REQUIREMENTS: i64 = 0x20;
            }
            pub mod AimMatrixBlendMode {
                pub const AimMatrixBlendMode_None: i64 = 0x0;
                pub const AimMatrixBlendMode_Additive: i64 = 0x1;
                pub const AimMatrixBlendMode_BoneMask: i64 = 0x3;
                pub const AimMatrixBlendMode_ModelSpaceAdditive: i64 = 0x2;
            }
            pub mod BoneMaskBlendSpace {
                pub const BlendSpace_Model: i64 = 0x1;
                pub const BlendSpace_Parent: i64 = 0x0;
                pub const BlendSpace_Model_RotationOnly: i64 = 0x2;
                pub const BlendSpace_Model_TranslationOnly: i64 = 0x3;
            }
            pub mod ChoiceChangeMethod {
                pub const OnReset: i64 = 0x0;
                pub const OnCycleEnd: i64 = 0x1;
                pub const OnResetOrCycleEnd: i64 = 0x2;
            }
            pub mod FieldNetworkOption {
                pub const Auto: i64 = 0x0;
                pub const ForceEnable: i64 = 0x1;
                pub const ForceDisable: i64 = 0x2;
            }
            pub mod HandshakeTagType_t {
                pub const eTask: i64 = 0x0;
                pub const eCount: i64 = 0x2;
                pub const eInvalid: i64 = -0x1;
                pub const eMovement: i64 = 0x1;
            }
            pub mod JiggleBoneSimSpace {
                pub const SimSpace_Local: i64 = 0x0;
                pub const SimSpace_Model: i64 = 0x1;
                pub const SimSpace_World: i64 = 0x2;
            }
            pub mod NmEasingFunction_t {
                pub const Back: i64 = 0x8;
                pub const Circ: i64 = 0x7;
                pub const Expo: i64 = 0x6;
                pub const Quad: i64 = 0x1;
                pub const Sine: i64 = 0x5;
                pub const Cubic: i64 = 0x2;
                pub const Quart: i64 = 0x3;
                pub const Quint: i64 = 0x4;
                pub const Linear: i64 = 0x0;
            }
            pub mod NmFollowBoneMode_t {
                pub const RotationOnly: i64 = 0x1;
                pub const TranslationOnly: i64 = 0x2;
                pub const RotationAndTranslation: i64 = 0x0;
            }
            pub mod NmGraphDebugMode_t {
                pub const On: i64 = 0x1;
                pub const Off: i64 = 0x0;
            }
            pub mod NmGraphValueType_t {
                pub const ID: i64 = 0x2;
                pub const Bool: i64 = 0x1;
                pub const Pose: i64 = 0x7;
                pub const Float: i64 = 0x3;
                pub const Target: i64 = 0x5;
                pub const Vector: i64 = 0x4;
                pub const Special: i64 = 0x8;
                pub const Unknown: i64 = 0x0;
                pub const BoneMask: i64 = 0x6;
            }
            pub mod NmTargetWarpRule_t {
                pub const WarpZ: i64 = 0x1;
                pub const WarpXY: i64 = 0x0;
                pub const WarpXYZ: i64 = 0x2;
                pub const FixedSection: i64 = 0x4;
                pub const RotationOnly: i64 = 0x3;
            }
            pub mod NmTransitionRule_t {
                pub const AllowTransition: i64 = 0x0;
                pub const BlockTransition: i64 = 0x2;
                pub const ConditionallyAllowTransition: i64 = 0x1;
            }
            pub mod RagdollPoseControl {
                pub const Absolute: i64 = 0x0;
            }
            pub mod StanceOverrideMode {
                pub const Node: i64 = 0x1;
                pub const Sequence: i64 = 0x0;
            }
            pub mod VelocityMetricMode {
                pub const DirectionOnly: i64 = 0x0;
                pub const MagnitudeOnly: i64 = 0x1;
                pub const DirectionAndMagnitude: i64 = 0x2;
            }
            pub mod AnimNodeNetworkMode {
                pub const ClientSimulate: i64 = 0x1;
                pub const ServerAuthoritative: i64 = 0x0;
            }
            pub mod CNmEventRelevance_t {
                pub const ClientOnly: i64 = 0x0;
                pub const ServerOnly: i64 = 0x1;
                pub const ClientAndServer: i64 = 0x2;
            }
            pub mod FootstepJumpPhase_t {
                pub const Jumping: i64 = 0x2;
                pub const Landing: i64 = 0x4;
                pub const Unknown: i64 = 0x0;
                pub const NotJumping: i64 = 0x1;
            }
            pub mod HandshakeTagState_t {
                pub const eActive: i64 = 0x1;
                pub const eInactive: i64 = 0x0;
                pub const eMomentarilyInactive: i64 = 0x2;
            }
            pub mod NmCachedValueMode_t {
                pub const OnExit: i64 = 0x1;
                pub const OnEntry: i64 = 0x0;
            }
            pub mod NmEasingOperation_t {
                pub const _None: i64 = 0x16;
                pub const InCirc: i64 = 0x13;
                pub const InExpo: i64 = 0x10;
                pub const InQuad: i64 = 0x1;
                pub const InSine: i64 = 0xD;
                pub const Linear: i64 = 0x0;
                pub const InCubic: i64 = 0x4;
                pub const InQuart: i64 = 0x7;
                pub const InQuint: i64 = 0xA;
                pub const OutCirc: i64 = 0x14;
                pub const OutExpo: i64 = 0x11;
                pub const OutQuad: i64 = 0x2;
                pub const OutSine: i64 = 0xE;
                pub const OutCubic: i64 = 0x5;
                pub const OutQuart: i64 = 0x8;
                pub const OutQuint: i64 = 0xB;
                pub const InOutCirc: i64 = 0x15;
                pub const InOutExpo: i64 = 0x12;
                pub const InOutQuad: i64 = 0x3;
                pub const InOutSine: i64 = 0xF;
                pub const InOutCubic: i64 = 0x6;
                pub const InOutQuart: i64 = 0x9;
                pub const InOutQuint: i64 = 0xC;
            }
            pub mod PFNoiseTurbulence_t {
                pub const PF_NOISE_TURB_NONE: i64 = 0x0;
                pub const PF_NOISE_TURB_LOOPY: i64 = 0x3;
                pub const PF_NOISE_TURB_CONTRAST: i64 = 0x4;
                pub const PF_NOISE_TURB_FEEDBACK: i64 = 0x2;
                pub const PF_NOISE_TURB_ALTERNATE: i64 = 0x5;
                pub const PF_NOISE_TURB_HIGHLIGHT: i64 = 0x1;
            }
            pub mod ParticleFloatType_t {
                pub const PF_TYPE_COUNT: i64 = 0x20;
                pub const PF_TYPE_INVALID: i64 = -0x1;
                pub const PF_TYPE_LITERAL: i64 = 0x0;
                pub const PF_TYPE_ENDCAP_AGE: i64 = 0x5;
                pub const PF_TYPE_NAMED_VALUE: i64 = 0x1;
                pub const PF_TYPE_PARTICLE_AGE: i64 = 0x13;
                pub const PF_TYPE_RANDOM_BIASED: i64 = 0x3;
                pub const PF_TYPE_COLLECTION_AGE: i64 = 0x4;
                pub const PF_TYPE_PARTICLE_FLOAT: i64 = 0x15;
                pub const PF_TYPE_PARTICLE_NOISE: i64 = 0x12;
                pub const PF_TYPE_PARTICLE_SPEED: i64 = 0x19;
                pub const PF_TYPE_RANDOM_UNIFORM: i64 = 0x2;
                pub const PF_TYPE_SNAPSHOT_COUNT: i64 = 0xD;
                pub const PF_TYPE_PARTICLE_NUMBER: i64 = 0x1A;
                pub const PF_TYPE_SNAPSHOT_CHANGED: i64 = 0xE;
                pub const PF_TYPE_CONTROL_POINT_SPEED: i64 = 0x8;
                pub const PF_TYPE_CONCURRENT_DEF_COUNT: i64 = 0xB;
                pub const PF_TYPE_CONTROL_POINT_IS_SET: i64 = 0xF;
                pub const PF_TYPE_PARTICLE_DETAIL_LEVEL: i64 = 0xA;
                pub const PF_TYPE_PARTICLE_ROPE_SEGMENT: i64 = 0x1C;
                pub const PF_TYPE_CONTROL_POINT_DISTANCE: i64 = 0x9;
                pub const PF_TYPE_PARTICLE_INITIAL_FLOAT: i64 = 0x16;
                pub const PF_TYPE_CLOSEST_CAMERA_DISTANCE: i64 = 0xC;
                pub const PF_TYPE_CONTROL_POINT_COMPONENT: i64 = 0x6;
                pub const PF_TYPE_PARTICLE_AGE_NORMALIZED: i64 = 0x14;
                pub const PF_TYPE_CONTROL_POINT_CHANGE_AGE: i64 = 0x7;
                pub const PF_TYPE_RENDERER_CAMERA_DISTANCE: i64 = 0x10;
                pub const PF_TYPE_PARTICLE_VECTOR_COMPONENT: i64 = 0x17;
                pub const PF_TYPE_PARTICLE_NUMBER_NORMALIZED: i64 = 0x1B;
                pub const PF_TYPE_RENDERER_CAMERA_DOT_PRODUCT: i64 = 0x11;
                pub const PF_TYPE_PARTICLE_ROPE_SEGMENT_NORMALIZED: i64 = 0x1D;
                pub const PF_TYPE_PARTICLE_INITIAL_VECTOR_COMPONENT: i64 = 0x18;
                pub const PF_TYPE_PARTICLE_SCREENSPACE_CAMERA_DISTANCE: i64 = 0x1E;
                pub const PF_TYPE_PARTICLE_SCREENSPACE_CAMERA_DOT_PRODUCT: i64 = 0x1F;
            }
            pub mod ParticleModelType_t {
                pub const PM_TYPE_COUNT: i64 = 0x4;
                pub const PM_TYPE_INVALID: i64 = 0x0;
                pub const PM_TYPE_CONTROL_POINT: i64 = 0x3;
                pub const PM_TYPE_NAMED_VALUE_MODEL: i64 = 0x1;
                pub const PM_TYPE_NAMED_VALUE_EHANDLE: i64 = 0x2;
            }
            pub mod ParticleSetMethod_t {
                pub const PARTICLE_SET_REPLACE_VALUE: i64 = 0x0;
                pub const PARTICLE_SET_RAMP_CURRENT_VALUE: i64 = 0x3;
                pub const PARTICLE_SET_SCALE_CURRENT_VALUE: i64 = 0x4;
                pub const PARTICLE_SET_SCALE_INITIAL_VALUE: i64 = 0x1;
                pub const PARTICLE_SET_ADD_TO_CURRENT_VALUE: i64 = 0x5;
                pub const PARTICLE_SET_ADD_TO_INITIAL_VALUE: i64 = 0x2;
            }
            pub mod StateActionBehavior {
                pub const STATETAGBEHAVIOR_FIRE_ON_EXIT: i64 = 0x2;
                pub const STATETAGBEHAVIOR_FIRE_ON_ENTER: i64 = 0x1;
                pub const STATETAGBEHAVIOR_ACTIVE_WHILE_CURRENT: i64 = 0x0;
                pub const STATETAGBEHAVIOR_FIRE_ON_ENTER_AND_EXIT: i64 = 0x3;
                pub const STATETAGBEHAVIOR_ACTIVE_WHILE_FULLY_BLENDED: i64 = 0x4;
            }
            pub mod BoneTransformSpace_t {
                pub const BoneTransformSpace_Model: i64 = 0x1;
                pub const BoneTransformSpace_World: i64 = 0x2;
                pub const BoneTransformSpace_Parent: i64 = 0x0;
                pub const BoneTransformSpace_Invalid: i64 = -0x1;
            }
            pub mod DampingSpeedFunction {
                pub const Spring: i64 = 0x2;
                pub const Constant: i64 = 0x1;
                pub const NoDamping: i64 = 0x0;
                pub const AsymmetricSpring: i64 = 0x3;
            }
            pub mod JumpCorrectionMethod {
                pub const ScaleMotion: i64 = 0x0;
                pub const AddCorrectionDelta: i64 = 0x1;
            }
            pub mod MovementCapability_t {
                pub const eLean: i64 = 0x8;
                pub const eStop: i64 = 0x3;
                pub const eCount: i64 = 0xA;
                pub const eStart: i64 = 0x2;
                pub const eStrafe: i64 = 0x0;
                pub const eShuffle: i64 = 0x5;
                pub const eIdleTurn: i64 = 0x1;
                pub const eInstantStop: i64 = 0x4;
                pub const ePlantedTurn: i64 = 0x6;
                pub const eForwardStartOnly: i64 = 0x9;
                pub const eUseStartAsPlantedTurn: i64 = 0x7;
            }
            pub mod NPCPhysicsHullType_t {
                pub const eInvalid: i64 = 0x0;
                pub const eGroundBox: i64 = 0x4;
                pub const eGroundCapsule: i64 = 0x1;
                pub const eGenericCapsule: i64 = 0x3;
                pub const eGroundCylinder: i64 = 0x5;
                pub const eCenteredCapsule: i64 = 0x2;
                pub const eCenteredCylinder: i64 = 0x6;
            }
            pub mod ParticleAttachment_t {
                pub const PATTACH_POINT: i64 = 0x4;
                pub const PATTACH_INVALID: i64 = -0x1;
                pub const MAX_PATTACH_TYPES: i64 = 0x10;
                pub const PATTACH_ABSORIGIN: i64 = 0x0;
                pub const PATTACH_HEALTHBAR: i64 = 0xF;
                pub const PATTACH_MAIN_VIEW: i64 = 0xB;
                pub const PATTACH_WATERWAKE: i64 = 0xC;
                pub const PATTACH_EYES_FOLLOW: i64 = 0x6;
                pub const PATTACH_WORLDORIGIN: i64 = 0x8;
                pub const PATTACH_CUSTOMORIGIN: i64 = 0x2;
                pub const PATTACH_POINT_FOLLOW: i64 = 0x5;
                pub const PATTACH_CENTER_FOLLOW: i64 = 0xD;
                pub const PATTACH_OVERHEAD_FOLLOW: i64 = 0x7;
                pub const PATTACH_ROOTBONE_FOLLOW: i64 = 0x9;
                pub const PATTACH_ABSORIGIN_FOLLOW: i64 = 0x1;
                pub const PATTACH_CUSTOMORIGIN_FOLLOW: i64 = 0x3;
                pub const PATTACH_CUSTOM_GAME_STATE_1: i64 = 0xE;
                pub const PATTACH_RENDERORIGIN_FOLLOW: i64 = 0xA;
            }
            pub mod RenderMeshSlotType_t {
                pub const RENDERMESH_SLOT_INVALID: i64 = -0x1;
                pub const RENDERMESH_SLOT_PER_VERTEX: i64 = 0x0;
                pub const RENDERMESH_SLOT_PER_INSTANCE: i64 = 0x1;
            }
            pub mod SharedMovementGait_t {
                pub const eFast: i64 = 0x2;
                pub const eSlow: i64 = 0x0;
                pub const eCount: i64 = 0x4;
                pub const eMedium: i64 = 0x1;
                pub const eInvalid: i64 = -0x1;
                pub const eVeryFast: i64 = 0x3;
            }
            pub mod VertexAlbedoFormat_t {
                pub const VERTEX_ALBEDO_565: i64 = 0x2;
                pub const VERTEX_ALBEDO_8888: i64 = 0x1;
                pub const VERTEX_ALBEDO_NONE: i64 = 0x0;
            }
            pub mod AnimParamVectorType_t {
                pub const ANIMPARAM_VECTOR_TYPE_NONE: i64 = 0x0;
                pub const ANIMPARAM_VECTOR_TYPE_POSITION_LS: i64 = 0x2;
                pub const ANIMPARAM_VECTOR_TYPE_POSITION_WS: i64 = 0x1;
                pub const ANIMPARAM_VECTOR_TYPE_DIRECTION_LS: i64 = 0x4;
                pub const ANIMPARAM_VECTOR_TYPE_DIRECTION_WS: i64 = 0x3;
            }
            pub mod BinaryNodeChildOption {
                pub const Child1: i64 = 0x0;
                pub const Child2: i64 = 0x1;
            }
            pub mod CNmClothEvent__Type_t {
                pub const Effect: i64 = 0x1;
                pub const Stiffen: i64 = 0x0;
            }
            pub mod OrientationWarpMode_t {
                pub const eAngle: i64 = 0x1;
                pub const eInvalid: i64 = 0x0;
                pub const eWorldPosition: i64 = 0x2;
            }
            pub mod PulseMethodCallMode_t {
                pub const ASYNC_FIRE_AND_FORGET: i64 = 0x1;
                pub const SYNC_WAIT_FOR_COMPLETION: i64 = 0x0;
            }
            pub mod SelectorTagBehavior_t {
                pub const SelectorTagBehavior_OnWhileCurrent: i64 = 0x0;
                pub const SelectorTagBehavior_OffWhenFinished: i64 = 0x1;
                pub const SelectorTagBehavior_OffBeforeFinished: i64 = 0x2;
            }
            pub mod TargetWarpAngleMode_t {
                pub const eMoveHeading: i64 = 0x1;
                pub const eFacingHeading: i64 = 0x0;
            }
            pub mod CNmEventTargetEntity_t {
                pub const _Self: i64 = 0x0;
                pub const Custom: i64 = 0x3;
                pub const Weapon: i64 = 0x1;
                pub const HeldItem: i64 = 0x2;
            }
            pub mod EDemoBoneSelectionMode {
                pub const CaptureAllBones: i64 = 0x0;
                pub const CaptureSelectedBones: i64 = 0x1;
            }
            pub mod ModelMeshBufferUsage_t {
                pub const MESH_BUFFER_USAGE_IB: i64 = 0x2;
                pub const MESH_BUFFER_USAGE_VB: i64 = 0x1;
                pub const MESH_BUFFER_USAGE_NONE: i64 = 0x0;
                pub const MESH_BUFFER_USAGE_MESHLETS: i64 = 0x80;
                pub const MESH_BUFFER_USAGE_RT_PROXY: i64 = 0x10;
                pub const MESH_BUFFER_USAGE_ADJACENCY: i64 = 0x4;
                pub const MESH_BUFFER_USAGE_ALIAS_TABLE: i64 = 0x100;
                pub const MESH_BUFFER_USAGE_MESHLET_TRIS: i64 = 0x8;
                pub const MESH_BUFFER_USAGE_VERTEX_ALBEDO: i64 = 0x20;
                pub const MESH_BUFFER_USAGE_VERTEX_EMISSIVE: i64 = 0x40;
            }
            pub mod NmFootPhaseCondition_t {
                pub const _None: i64 = 0x6;
                pub const LeftPhase: i64 = 0x4;
                pub const RightPhase: i64 = 0x5;
                pub const LeftFootDown: i64 = 0x0;
                pub const RightFootDown: i64 = 0x2;
                pub const LeftFootPassing: i64 = 0x1;
                pub const RightFootPassing: i64 = 0x3;
            }
            pub mod NmFrameSnapEventMode_t {
                pub const Floor: i64 = 0x0;
                pub const Round: i64 = 0x1;
            }
            pub mod ParticleFloatMapType_t {
                pub const PF_MAP_TYPE_MAX: i64 = 0x8;
                pub const PF_MAP_TYPE_MIN: i64 = 0x7;
                pub const PF_MAP_TYPE_MOD: i64 = 0x9;
                pub const PF_MAP_TYPE_MULT: i64 = 0x1;
                pub const PF_MAP_TYPE_COUNT: i64 = 0xA;
                pub const PF_MAP_TYPE_CURVE: i64 = 0x4;
                pub const PF_MAP_TYPE_REMAP: i64 = 0x2;
                pub const PF_MAP_TYPE_ROUND: i64 = 0x6;
                pub const PF_MAP_TYPE_DIRECT: i64 = 0x0;
                pub const PF_MAP_TYPE_INVALID: i64 = -0x1;
                pub const PF_MAP_TYPE_NOTCHED: i64 = 0x5;
                pub const PF_MAP_TYPE_REMAP_BIASED: i64 = 0x3;
            }
            pub mod PulseDomainValueType_t {
                pub const COUNT: i64 = 0x2;
                pub const INVALID: i64 = -0x1;
                pub const PANEL_ID: i64 = 0x1;
                pub const ENTITY_NAME: i64 = 0x0;
            }
            pub mod PulseInstructionCode_t {
                pub const EQ: i64 = 0x22;
                pub const LT: i64 = 0x20;
                pub const NE: i64 = 0x23;
                pub const OR: i64 = 0x25;
                pub const ADD: i64 = 0x1B;
                pub const AND: i64 = 0x24;
                pub const DIV: i64 = 0x1E;
                pub const LTE: i64 = 0x21;
                pub const MOD: i64 = 0x1F;
                pub const MUL: i64 = 0x1D;
                pub const NOP: i64 = 0x5;
                pub const NOT: i64 = 0x19;
                pub const SUB: i64 = 0x1C;
                pub const COPY: i64 = 0x18;
                pub const JUMP: i64 = 0x6;
                pub const SCALE: i64 = 0x26;
                pub const EQ_INT: i64 = 0x55;
                pub const LT_INT: i64 = 0x4E;
                pub const NEGATE: i64 = 0x1A;
                pub const NE_INT: i64 = 0x66;
                pub const ADD_INT: i64 = 0x36;
                pub const EQ_BOOL: i64 = 0x54;
                pub const EQ_VEC2: i64 = 0x57;
                pub const EQ_VEC3: i64 = 0x58;
                pub const EQ_VEC4: i64 = 0x5A;
                pub const GET_VAR: i64 = 0x10;
                pub const INVALID: i64 = 0x0;
                pub const LTE_INT: i64 = 0x51;
                pub const MOD_INT: i64 = 0x4C;
                pub const MUL_INT: i64 = 0x49;
                pub const NE_BOOL: i64 = 0x65;
                pub const NE_VEC2: i64 = 0x68;
                pub const NE_VEC3: i64 = 0x69;
                pub const NE_VEC4: i64 = 0x6B;
                pub const SET_VAR: i64 = 0xF;
                pub const SUB_INT: i64 = 0x40;
                pub const ADD_VEC2: i64 = 0x39;
                pub const ADD_VEC3: i64 = 0x3A;
                pub const ADD_VEC4: i64 = 0x3D;
                pub const EQ_ARRAY: i64 = 0x63;
                pub const EQ_FLOAT: i64 = 0x56;
                pub const LT_FLOAT: i64 = 0x4F;
                pub const NE_ARRAY: i64 = 0x74;
                pub const NE_FLOAT: i64 = 0x67;
                pub const SUB_VEC2: i64 = 0x42;
                pub const SUB_VEC3: i64 = 0x43;
                pub const SUB_VEC4: i64 = 0x46;
                pub const ADD_FLOAT: i64 = 0x37;
                pub const DIV_FLOAT: i64 = 0x4B;
                pub const EQ_STRING: i64 = 0x5B;
                pub const EQ_VEC3WS: i64 = 0x59;
                pub const GET_CONST: i64 = 0x15;
                pub const JUMP_COND: i64 = 0x7;
                pub const LTE_FLOAT: i64 = 0x52;
                pub const MOD_FLOAT: i64 = 0x4D;
                pub const MUL_FLOAT: i64 = 0x4A;
                pub const NE_STRING: i64 = 0x6C;
                pub const NE_VEC3WS: i64 = 0x6A;
                pub const SCALE_INV: i64 = 0x27;
                pub const SUB_FLOAT: i64 = 0x41;
                pub const ADD_STRING: i64 = 0x38;
                pub const CHUNK_LEAP: i64 = 0x8;
                pub const EQ_EHANDLE: i64 = 0x5E;
                pub const LOOP_BREAK: i64 = 0x4;
                pub const NEGATE_INT: i64 = 0x31;
                pub const NE_EHANDLE: i64 = 0x6F;
                pub const SCALE_VEC2: i64 = 0x77;
                pub const SCALE_VEC3: i64 = 0x76;
                pub const SCALE_VEC4: i64 = 0x78;
                pub const CELL_INVOKE: i64 = 0xD;
                pub const EQ_GAMETIME: i64 = 0x64;
                pub const GET_TEMPVAR: i64 = 0x2D;
                pub const LT_GAMETIME: i64 = 0x50;
                pub const NEGATE_VEC2: i64 = 0x33;
                pub const NEGATE_VEC3: i64 = 0x34;
                pub const NEGATE_VEC4: i64 = 0x35;
                pub const NE_GAMETIME: i64 = 0x75;
                pub const RETURN_VOID: i64 = 0x2;
                pub const SET_TEMPVAR: i64 = 0x2E;
                pub const EQ_COLOR_RGB: i64 = 0x62;
                pub const LTE_GAMETIME: i64 = 0x53;
                pub const NEGATE_FLOAT: i64 = 0x32;
                pub const NE_COLOR_RGB: i64 = 0x73;
                pub const RETURN_VALUE: i64 = 0x3;
                pub const SUB_GAMETIME: i64 = 0x48;
                pub const CONVERT_VALUE: i64 = 0x29;
                pub const ELEMENT_ACCESS: i64 = 0x28;
                pub const EQ_ENTITY_NAME: i64 = 0x5C;
                pub const EQ_SCHEMA_ENUM: i64 = 0x5D;
                pub const EQ_TEST_HANDLE: i64 = 0x61;
                pub const GET_VAR_DETACH: i64 = 0x11;
                pub const IMMEDIATE_HALT: i64 = 0x1;
                pub const LIBRARY_INVOKE: i64 = 0xE;
                pub const NE_ENTITY_NAME: i64 = 0x6D;
                pub const NE_SCHEMA_ENUM: i64 = 0x6E;
                pub const NE_TEST_HANDLE: i64 = 0x72;
                pub const SCALE_INV_VEC2: i64 = 0x7A;
                pub const SCALE_INV_VEC3: i64 = 0x79;
                pub const SCALE_INV_VEC4: i64 = 0x7B;
                pub const ADD_VEC3WS_VEC3: i64 = 0x3B;
                pub const ADD_VEC3_VEC3WS: i64 = 0x3C;
                pub const CHUNK_LEAP_COND: i64 = 0x9;
                pub const DETACH_REGISTER: i64 = 0x12;
                pub const EQ_PANEL_HANDLE: i64 = 0x5F;
                pub const NE_PANEL_HANDLE: i64 = 0x70;
                pub const PULSE_CALL_SYNC: i64 = 0xA;
                pub const SUB_VEC3WS_VEC3: i64 = 0x44;
                pub const EQ_OPAQUE_HANDLE: i64 = 0x60;
                pub const GET_DOMAIN_VALUE: i64 = 0x17;
                pub const NE_OPAQUE_HANDLE: i64 = 0x71;
                pub const GET_ARRAY_ELEMENT: i64 = 0x16;
                pub const SUB_VEC3WS_VEC3WS: i64 = 0x45;
                pub const ADD_FLOAT_GAMETIME: i64 = 0x3F;
                pub const ADD_GAMETIME_FLOAT: i64 = 0x3E;
                pub const SET_VAR_OBSERVABLE: i64 = 0x14;
                pub const SUB_GAMETIME_FLOAT: i64 = 0x47;
                pub const ELEMENT_ACCESS_VEC2: i64 = 0x7C;
                pub const ELEMENT_ACCESS_VEC3: i64 = 0x7D;
                pub const ELEMENT_ACCESS_VEC4: i64 = 0x7F;
                pub const LAST_SERIALIZED_CODE: i64 = 0x30;
                pub const REINTERPRET_INSTANCE: i64 = 0x2A;
                pub const ELEMENT_ACCESS_VEC3WS: i64 = 0x7E;
                pub const PULSE_CALL_ASYNC_FIRE: i64 = 0xB;
                pub const SET_TEMPVAR_OBSERVABLE: i64 = 0x2F;
                pub const ELEMENT_ACCESS_COLOR_RGB: i64 = 0x80;
                pub const GET_BLACKBOARD_REFERENCE: i64 = 0x2B;
                pub const GET_CONST_INLINE_STORAGE: i64 = 0x81;
                pub const SET_BLACKBOARD_REFERENCE: i64 = 0x2C;
                pub const SET_VAR_ARRAY_ELEMENT_1D: i64 = 0x13;
                pub const CREATE_CHILD_CURSOR_OUTFLOW: i64 = 0xC;
            }
            pub mod TargetWarpTimingMethod {
                pub const ReachDestinationOnWarpTagEnd: i64 = 0x1;
                pub const ReachDestinationOnRootMotionEnd: i64 = 0x0;
            }
            pub mod VPhysXJoint_t__Flags_t {
                pub const JOINT_FLAGS_NONE: i64 = 0x0;
                pub const JOINT_FLAGS_BODY1_FIXED: i64 = 0x1;
                pub const JOINT_FLAGS_USE_BLOCK_SOLVER: i64 = 0x2;
            }
            pub mod AnimParamNetworkSetting {
                pub const Auto: i64 = 0x0;
                pub const NeverNetwork: i64 = 0x2;
                pub const AlwaysNetwork: i64 = 0x1;
            }
            pub mod AnimationSnapshotType_t {
                pub const ANIMATION_SNAPSHOT_MAX: i64 = 0x6;
                pub const ANIMATION_SNAPSHOT_CLIENT_RENDER: i64 = 0x4;
                pub const ANIMATION_SNAPSHOT_FINAL_COMPOSITE: i64 = 0x5;
                pub const ANIMATION_SNAPSHOT_CLIENT_PREDICTION: i64 = 0x2;
                pub const ANIMATION_SNAPSHOT_CLIENT_SIMULATION: i64 = 0x1;
                pub const ANIMATION_SNAPSHOT_SERVER_SIMULATION: i64 = 0x0;
                pub const ANIMATION_SNAPSHOT_CLIENT_INTERPOLATION: i64 = 0x3;
            }
            pub mod FootPinningTimingSource {
                pub const Tag: i64 = 0x1;
                pub const Parameter: i64 = 0x2;
                pub const FootMotion: i64 = 0x0;
            }
            pub mod NmEventConditionRules_t {
                pub const OperatorOr: i64 = 0x4;
                pub const OperatorAnd: i64 = 0x5;
                pub const PreferHighestWeight: i64 = 0x2;
                pub const IgnoreInactiveEvents: i64 = 0x1;
                pub const SearchOnlyAnimEvents: i64 = 0x7;
                pub const PreferHighestProgress: i64 = 0x3;
                pub const SearchOnlyGraphEvents: i64 = 0x6;
                pub const LimitSearchToSourceState: i64 = 0x0;
                pub const SearchBothGraphAndAnimEvents: i64 = 0x8;
            }
            pub mod NmRootMotionBlendMode_t {
                pub const Blend: i64 = 0x0;
                pub const Additive: i64 = 0x1;
                pub const IgnoreSource: i64 = 0x2;
                pub const IgnoreTarget: i64 = 0x3;
            }
            pub mod NmTargetWarpAlgorithm_t {
                pub const Lerp: i64 = 0x0;
                pub const Bezier: i64 = 0x3;
                pub const Hermite: i64 = 0x1;
                pub const HermiteFeaturePreserving: i64 = 0x2;
            }
            pub mod ParticleFloatBiasType_t {
                pub const PF_BIAS_TYPE_GAIN: i64 = 0x1;
                pub const PF_BIAS_TYPE_COUNT: i64 = 0x3;
                pub const PF_BIAS_TYPE_INVALID: i64 = -0x1;
                pub const PF_BIAS_TYPE_STANDARD: i64 = 0x0;
                pub const PF_BIAS_TYPE_EXPONENTIAL: i64 = 0x2;
            }
            pub mod ParticleTransformType_t {
                pub const PT_TYPE_COUNT: i64 = 0x4;
                pub const PT_TYPE_INVALID: i64 = 0x0;
                pub const PT_TYPE_NAMED_VALUE: i64 = 0x1;
                pub const PT_TYPE_CONTROL_POINT: i64 = 0x2;
                pub const PT_TYPE_CONTROL_POINT_RANGE: i64 = 0x3;
            }
            pub mod PulseBestOutflowRules_t {
                pub const SORT_BY_OUTFLOW_INDEX: i64 = 0x1;
                pub const SORT_BY_NUMBER_OF_VALID_CRITERIA: i64 = 0x0;
            }
            pub mod CNmParticleEvent__Type_t {
                pub const Create: i64 = 0x0;
                pub const Create_CFG: i64 = 0x1;
            }
            pub mod FootLockSubVisualization {
                pub const FOOTLOCKSUBVISUALIZATION_IKSolve: i64 = 0x1;
                pub const FOOTLOCKSUBVISUALIZATION_ReachabilityAnalysis: i64 = 0x0;
            }
            pub mod IKTargetCoordinateSystem {
                pub const IKTARGETCOORDINATESYSTEM_COUNT: i64 = 0x2;
                pub const IKTARGETCOORDINATESYSTEM_ModelSpace: i64 = 0x1;
                pub const IKTARGETCOORDINATESYSTEM_WorldSpace: i64 = 0x0;
            }
            pub mod MeshDrawPrimitiveFlags_t {
                pub const MESH_DRAW_FLAGS_NONE: i64 = 0x0;
                pub const MESH_DRAW_FLAGS_DRAW_LAST: i64 = 0x80;
                pub const MESH_DRAW_FLAGS_USE_SHADOW_FAST_PATH: i64 = 0x1;
                pub const MESH_DRAW_FLAGS_USE_COMPRESSED_NORMAL_TANGENT: i64 = 0x2;
                pub const MESH_DRAW_INPUT_LAYOUT_IS_NOT_MATCHED_TO_MATERIAL: i64 = 0x8;
                pub const MESH_DRAW_FLAGS_USE_COMPRESSED_PER_VERTEX_LIGHTING: i64 = 0x10;
                pub const MESH_DRAW_FLAGS_USE_UNCOMPRESSED_PER_VERTEX_LIGHTING: i64 = 0x20;
                pub const MESH_DRAW_FLAGS_CAN_BATCH_WITH_DYNAMIC_SHADER_CONSTANTS: i64 = 0x40;
            }
            pub mod ModelBoneFlexComponent_t {
                pub const MODEL_BONE_FLEX_TX: i64 = 0x0;
                pub const MODEL_BONE_FLEX_TY: i64 = 0x1;
                pub const MODEL_BONE_FLEX_TZ: i64 = 0x2;
                pub const MODEL_BONE_FLEX_INVALID: i64 = -0x1;
            }
            pub mod ParticleColorBlendMode_t {
                pub const PARTICLEBLEND_DARKEN: i64 = 0x2;
                pub const PARTICLEBLEND_DEFAULT: i64 = 0x0;
                pub const PARTICLEBLEND_LIGHTEN: i64 = 0x3;
                pub const PARTICLEBLEND_OVERLAY: i64 = 0x1;
                pub const PARTICLEBLEND_MULTIPLY: i64 = 0x4;
            }
            pub mod ParticleColorBlendType_t {
                pub const PARTICLE_COLOR_BLEND_ADD: i64 = 0x3;
                pub const PARTICLE_COLOR_BLEND_MAX: i64 = 0x7;
                pub const PARTICLE_COLOR_BLEND_MIN: i64 = 0x8;
                pub const PARTICLE_COLOR_BLEND_MOD2X: i64 = 0x5;
                pub const PARTICLE_COLOR_BLEND_DIVIDE: i64 = 0x2;
                pub const PARTICLE_COLOR_BLEND_NEGATE: i64 = 0xB;
                pub const PARTICLE_COLOR_BLEND_SCREEN: i64 = 0x6;
                pub const PARTICLE_COLOR_BLEND_AVERAGE: i64 = 0xA;
                pub const PARTICLE_COLOR_BLEND_REPLACE: i64 = 0x9;
                pub const PARTICLE_COLOR_BLEND_MULTIPLY: i64 = 0x0;
                pub const PARTICLE_COLOR_BLEND_SUBTRACT: i64 = 0x4;
                pub const PARTICLE_COLOR_BLEND_LUMINANCE: i64 = 0xC;
                pub const PARTICLE_COLOR_BLEND_MULTIPLY2X: i64 = 0x1;
            }
            pub mod ParticleFloatInputMode_t {
                pub const PF_INPUT_MODE_COUNT: i64 = 0x2;
                pub const PF_INPUT_MODE_LOOPED: i64 = 0x1;
                pub const PF_INPUT_MODE_CLAMPED: i64 = 0x0;
                pub const PF_INPUT_MODE_INVALID: i64 = -0x1;
            }
            pub mod ParticleFloatRoundType_t {
                pub const PF_ROUND_TYPE_CEIL: i64 = 0x2;
                pub const PF_ROUND_TYPE_COUNT: i64 = 0x3;
                pub const PF_ROUND_TYPE_FLOOR: i64 = 0x1;
                pub const PF_ROUND_TYPE_INVALID: i64 = -0x1;
                pub const PF_ROUND_TYPE_NEAREST: i64 = 0x0;
            }
            pub mod AnimationProcessingType_t {
                pub const ANIMATION_PROCESSING_MAX: i64 = 0x5;
                pub const ANIMATION_PROCESSING_CLIENT_RENDER: i64 = 0x4;
                pub const ANIMATION_PROCESSING_CLIENT_PREDICTION: i64 = 0x2;
                pub const ANIMATION_PROCESSING_CLIENT_SIMULATION: i64 = 0x1;
                pub const ANIMATION_PROCESSING_SERVER_SIMULATION: i64 = 0x0;
                pub const ANIMATION_PROCESSING_CLIENT_INTERPOLATION: i64 = 0x3;
            }
            pub mod CNmSoundEvent__Position_t {
                pub const _None: i64 = 0x0;
                pub const World: i64 = 0x1;
                pub const EntityPos: i64 = 0x2;
                pub const EntityEyePos: i64 = 0x3;
                pub const EntityAttachment: i64 = 0x4;
            }
            pub mod CNmTargetInfoNode__Info_t {
                pub const Distance: i64 = 0x2;
                pub const AngleVertical: i64 = 0x1;
                pub const AngleHorizontal: i64 = 0x0;
                pub const DeltaOrientationX: i64 = 0x5;
                pub const DeltaOrientationY: i64 = 0x6;
                pub const DeltaOrientationZ: i64 = 0x7;
                pub const DistanceVerticalOnly: i64 = 0x4;
                pub const DistanceHorizontalOnly: i64 = 0x3;
            }
            pub mod CNmVectorInfoNode__Info_t {
                pub const X: i64 = 0x0;
                pub const Y: i64 = 0x1;
                pub const Z: i64 = 0x2;
                pub const Length: i64 = 0x3;
                pub const AngleVertical: i64 = 0x5;
                pub const AngleHorizontal: i64 = 0x4;
            }
            pub mod ParticleFloatRandomMode_t {
                pub const PF_RANDOM_MODE_COUNT: i64 = 0x2;
                pub const PF_RANDOM_MODE_INVALID: i64 = -0x1;
                pub const PF_RANDOM_MODE_VARYING: i64 = 0x1;
                pub const PF_RANDOM_MODE_CONSTANT: i64 = 0x0;
            }
            pub mod PermModelInfo_t__FlagEnum {
                pub const FLAG_MODEL_DOC: i64 = 0x800000;
                pub const FLAG_TRANSLUCENT: i64 = 0x1;
                pub const FLAG_NAV_GEN_HULL: i64 = 0x40;
                pub const FLAG_NAV_GEN_NONE: i64 = 0x20;
                pub const FLAG_NO_ANIM_EVENTS: i64 = 0x100000;
                pub const FLAG_NO_FORCED_FADE: i64 = 0x800;
                pub const FLAG_SOURCE1_IMPORT: i64 = 0x8;
                pub const FLAG_MODEL_PART_CHILD: i64 = 0x10;
                pub const FLAG_HAS_SKINNED_MESHES: i64 = 0x400;
                pub const FLAG_DO_NOT_CAST_SHADOWS: i64 = 0x20000;
                pub const FLAG_TRANSLUCENT_TWO_PASS: i64 = 0x2;
                pub const FLAG_ANIMATION_DRIVEN_FLEXES: i64 = 0x200000;
                pub const FLAG_FORCE_PHONEME_CROSSFADE: i64 = 0x1000;
                pub const FLAG_MODEL_IS_RUNTIME_COMBINED: i64 = 0x4;
                pub const FLAG_IMPLICIT_BIND_POSE_SEQUENCE: i64 = 0x400000;
            }
            pub mod PulseCursorWakePriority_t {
                pub const WakeElegantly: i64 = 0x0;
                pub const WakeImmediate: i64 = 0x1;
            }
            pub mod PulseVariableKeysSource_t {
                pub const CPP: i64 = 0x1;
                pub const XML: i64 = 0x4;
                pub const VMAP: i64 = 0x2;
                pub const VMDL: i64 = 0x3;
                pub const COUNT: i64 = 0x6;
                pub const VDATA: i64 = 0x5;
                pub const PRIVATE: i64 = 0x0;
            }
            pub mod TargetSelectorAngleMode_t {
                pub const eMoveHeading: i64 = 0x1;
                pub const eFacingHeading: i64 = 0x0;
            }
            pub mod GPUParticleCollisionMode_t {
                pub const PARTICLE_GPU_COLLISION_MODE_RT: i64 = 0x0;
                pub const PARTICLE_GPU_COLLISION_MODE_DEPTH: i64 = 0x1;
                pub const PARTICLE_GPU_COLLISION_MODE_HYBRID: i64 = 0x2;
            }
            pub mod TargetWarpCorrectionMethod {
                pub const ScaleMotion: i64 = 0x0;
                pub const AddCorrectionDelta: i64 = 0x1;
            }
            pub mod LinearRootMotionBlendMode_t {
                pub const LERP: i64 = 0x0;
                pub const NLERP: i64 = 0x1;
                pub const SLERP: i64 = 0x2;
            }
            pub mod MatterialAttributeTagType_t {
                pub const MATERIAL_ATTRIBUTE_TAG_COLOR: i64 = 0x1;
                pub const MATERIAL_ATTRIBUTE_TAG_VALUE: i64 = 0x0;
            }
            pub mod ModelConfigAttachmentType_t {
                pub const MODEL_CONFIG_ATTACHMENT_COUNT: i64 = 0x3;
                pub const MODEL_CONFIG_ATTACHMENT_INVALID: i64 = -0x1;
                pub const MODEL_CONFIG_ATTACHMENT_BONEMERGE: i64 = 0x2;
                pub const MODEL_CONFIG_ATTACHMENT_ROOT_RELATIVE: i64 = 0x1;
                pub const MODEL_CONFIG_ATTACHMENT_BONE_OR_ATTACHMENT: i64 = 0x0;
            }
            pub mod NmGraphEventTypeCondition_t {
                pub const Any: i64 = 0x5;
                pub const Exit: i64 = 0x2;
                pub const Entry: i64 = 0x0;
                pub const Timed: i64 = 0x3;
                pub const Generic: i64 = 0x4;
                pub const FullyInState: i64 = 0x1;
            }
            pub mod NmTransitionRuleCondition_t {
                pub const Blocked: i64 = 0x3;
                pub const AnyAllowed: i64 = 0x0;
                pub const FullyAllowed: i64 = 0x1;
                pub const ConditionallyAllowed: i64 = 0x2;
            }
            pub mod PulseCursorCancelPriority_t {
                pub const _None: i64 = 0x0;
                pub const HardCancel: i64 = 0x3;
                pub const SoftCancel: i64 = 0x2;
                pub const CancelOnSucceeded: i64 = 0x1;
            }
            pub mod PulseDurationStringFormat_t {
                pub const MM_SS_LEADING_ZERO: i64 = 0x0;
            }
            pub mod CNmFloatMathNode__Operator_t {
                pub const Abs: i64 = 0x5;
                pub const Add: i64 = 0x0;
                pub const Div: i64 = 0x3;
                pub const Mod: i64 = 0x4;
                pub const Mul: i64 = 0x2;
                pub const Sub: i64 = 0x1;
                pub const Floor: i64 = 0x7;
                pub const Negate: i64 = 0x6;
                pub const Ceiling: i64 = 0x8;
                pub const IntegerPart: i64 = 0x9;
                pub const FractionalPart: i64 = 0xA;
                pub const InverseFractionalPart: i64 = 0xB;
            }
            pub mod ParticleDirectionNoiseType_t {
                pub const PARTICLE_DIR_NOISE_CURL: i64 = 0x1;
                pub const PARTICLE_DIR_NOISE_PERLIN: i64 = 0x0;
                pub const PARTICLE_DIR_NOISE_WORLEY_BASIC: i64 = 0x2;
            }
            pub mod ScriptedHeldWeaponBehavior_t {
                pub const eDrop: i64 = 0x2;
                pub const eDeploy: i64 = 0x1;
                pub const eHolster: i64 = 0x0;
                pub const eInvalid: i64 = -0x1;
            }
            pub mod FootstepLandedFootSoundType_t {
                pub const FOOTSOUND_Left: i64 = 0x0;
                pub const FOOTSOUND_Right: i64 = 0x1;
                pub const FOOTSOUND_UseOverrideSound: i64 = 0x2;
            }
            pub mod MorphFlexControllerRemapType_t {
                pub const MORPH_FLEXCONTROLLER_REMAP_2WAY: i64 = 0x1;
                pub const MORPH_FLEXCONTROLLER_REMAP_NWAY: i64 = 0x2;
                pub const MORPH_FLEXCONTROLLER_REMAP_EYELID: i64 = 0x3;
                pub const MORPH_FLEXCONTROLLER_REMAP_PASSTHRU: i64 = 0x0;
            }
            pub mod EIKEndEffectorRotationFixUpMode {
                pub const _None: i64 = 0x0;
                pub const Count: i64 = 0x4;
                pub const LookAtTargetForward: i64 = 0x2;
                pub const MatchTargetOrientation: i64 = 0x1;
                pub const MaintainParentOrientation: i64 = 0x3;
            }
            pub mod EPulseGraphExecutionHistoryFlag {
                pub const RETURN: i64 = 0x80;
                pub const NO_FLAGS: i64 = 0x0;
                pub const CALL_TO_PULSE: i64 = 0x40;
                pub const CURSOR_ADD_TAG: i64 = 0x1;
                pub const CURSOR_RETIRED: i64 = 0x4;
                pub const REQUIREMENT_FAIL: i64 = 0x20;
                pub const REQUIREMENT_PASS: i64 = 0x10;
                pub const CURSOR_REMOVE_TAG: i64 = 0x2;
                pub const CURSOR_CREATE_CHILD: i64 = 0x8;
            }
            pub mod CNmTimeConditionNode__Operator_t {
                pub const LessThan: i64 = 0x0;
                pub const GreaterThan: i64 = 0x2;
                pub const LessThanEqual: i64 = 0x1;
                pub const GreaterThanEqual: i64 = 0x3;
            }
            pub mod ModelSkeletonData_t__BoneFlags_t {
                pub const FLAG_MESH: i64 = 0x80;
                pub const FLAG_CLOTH: i64 = 0x8;
                pub const FLAG_HITBOX: i64 = 0x100;
                pub const FLAG_PHYSICS: i64 = 0x10;
                pub const FLAG_ANIMATION: i64 = 0x40;
                pub const FLAG_ATTACHMENT: i64 = 0x20;
                pub const FLAG_PROCEDURAL: i64 = 0x400000;
                pub const BLEND_PREALIGNED: i64 = 0x100000;
                pub const FLAG_RIGIDLENGTH: i64 = 0x200000;
                pub const FLAG_NO_BONE_FLAGS: i64 = 0x0;
                pub const FLAG_ALL_BONE_FLAGS: i64 = 0xFFFFF;
                pub const FLAG_BONEFLEXDRIVER: i64 = 0x4;
                pub const FLAG_BONE_MERGE_READ: i64 = 0x40000;
                pub const FLAG_BONE_MERGE_WRITE: i64 = 0x80000;
                pub const FLAG_BONE_USED_BY_VERTEX_LOD0: i64 = 0x400;
                pub const FLAG_BONE_USED_BY_VERTEX_LOD1: i64 = 0x800;
                pub const FLAG_BONE_USED_BY_VERTEX_LOD2: i64 = 0x1000;
                pub const FLAG_BONE_USED_BY_VERTEX_LOD3: i64 = 0x2000;
                pub const FLAG_BONE_USED_BY_VERTEX_LOD4: i64 = 0x4000;
                pub const FLAG_BONE_USED_BY_VERTEX_LOD5: i64 = 0x8000;
                pub const FLAG_BONE_USED_BY_VERTEX_LOD6: i64 = 0x10000;
                pub const FLAG_BONE_USED_BY_VERTEX_LOD7: i64 = 0x20000;
            }
            pub mod SolveIKChainAnimNodeDebugSetting {
                pub const SOLVEIKCHAINANIMNODEDEBUGSETTING_Up: i64 = 0x5;
                pub const SOLVEIKCHAINANIMNODEDEBUGSETTING_Left: i64 = 0x6;
                pub const SOLVEIKCHAINANIMNODEDEBUGSETTING_None: i64 = 0x0;
                pub const SOLVEIKCHAINANIMNODEDEBUGSETTING_Forward: i64 = 0x4;
                pub const SOLVEIKCHAINANIMNODEDEBUGSETTING_X_Axis_Circle: i64 = 0x1;
                pub const SOLVEIKCHAINANIMNODEDEBUGSETTING_Y_Axis_Circle: i64 = 0x2;
                pub const SOLVEIKCHAINANIMNODEDEBUGSETTING_Z_Axis_Circle: i64 = 0x3;
            }
            pub mod CNmIDComparisonNode__Comparison_t {
                pub const Matches: i64 = 0x0;
                pub const DoesntMatch: i64 = 0x1;
            }
            pub mod CNmRootMotionData__SamplingMode_t {
                pub const Delta: i64 = 0x0;
                pub const WorldSpace: i64 = 0x1;
            }
            pub mod OrientationWarpRootMotionSource_t {
                pub const eAnimationOnly: i64 = 0x1;
                pub const eProceduralOnly: i64 = 0x2;
                pub const eAnimationOrProcedural: i64 = 0x0;
            }
            pub mod OrientationWarpTargetOffsetMode_t {
                pub const eParameter: i64 = 0x1;
                pub const eLiteralValue: i64 = 0x0;
                pub const eAnimationMovementHeading: i64 = 0x2;
                pub const eAnimationMovementHeadingAtEnd: i64 = 0x3;
            }
            pub mod CNmFloatAngleMathNode__Operation_t {
                pub const ClampTo180: i64 = 0x0;
                pub const ClampTo360: i64 = 0x1;
                pub const FlipHemisphere: i64 = 0x2;
                pub const FlipHemisphereNegate: i64 = 0x3;
            }
            pub mod VPhysXBodyPart_t__VPhysXFlagEnum_t {
                pub const FLAG_MASS: i64 = 0x8;
                pub const FLAG_JOINT: i64 = 0x4;
                pub const FLAG_STATIC: i64 = 0x1;
                pub const FLAG_KINEMATIC: i64 = 0x2;
                pub const FLAG_DISABLE_CCD: i64 = 0x20;
                pub const FLAG_ALWAYS_DYNAMIC_ON_CLIENT: i64 = 0x10;
            }
            pub mod CNmCurrentSyncEventNode__InfoType_t {
                pub const IndexOnly: i64 = 0x1;
                pub const PercentageOnly: i64 = 0x2;
                pub const IndexAndPercentage: i64 = 0x0;
            }
            pub mod CNmFloatComparisonNode__Comparison_t {
                pub const LessThan: i64 = 0x4;
                pub const NearEqual: i64 = 0x2;
                pub const GreaterThan: i64 = 0x3;
                pub const LessThanEqual: i64 = 0x1;
                pub const GreaterThanEqual: i64 = 0x0;
            }
            pub mod CNmTargetWarpNode__TargetUpdateRule_t {
                pub const _None: i64 = 0x0;
                pub const Offset: i64 = 0x2;
                pub const Recalculate: i64 = 0x1;
                pub const RecalculateOrOffset: i64 = 0x3;
            }
            pub mod CAnimationGraphVisualizerPrimitiveType {
                pub const ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Pie: i64 = 0x3;
                pub const ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Axis: i64 = 0x4;
                pub const ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Line: i64 = 0x2;
                pub const ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Text: i64 = 0x0;
                pub const ANIMATIONGRAPHVISUALIZERPRIMITIVETYPE_Sphere: i64 = 0x1;
            }
            pub mod CNmTimeConditionNode__ComparisonType_t {
                pub const ElapsedTime: i64 = 0x2;
                pub const PercentageThroughState: i64 = 0x0;
                pub const PercentageThroughSyncEvent: i64 = 0x1;
            }
            pub mod CNmTransitionNode__TransitionOptions_t {
                pub const _None: i64 = 0x0;
                pub const Synchronized: i64 = 0x2;
                pub const ClampDuration: i64 = 0x1;
                pub const MatchSourceTime: i64 = 0x3;
                pub const MatchSyncEventID: i64 = 0x5;
                pub const MatchTimeInSeconds: i64 = 0x8;
                pub const MatchSyncEventIndex: i64 = 0x4;
                pub const OffsetTimeInSeconds: i64 = 0x9;
                pub const MatchSyncEventPercentage: i64 = 0x6;
                pub const PreferClosestSyncEventID: i64 = 0x7;
            }
            pub mod VPhysXConstraintParams_t__EnumFlags0_t {
                pub const FLAG0_SHIFT_CONSTRAIN: i64 = 0x1;
                pub const FLAG0_SHIFT_INTERPENETRATE: i64 = 0x0;
                pub const FLAG0_SHIFT_BREAKABLE_FORCE: i64 = 0x2;
                pub const FLAG0_SHIFT_BREAKABLE_TORQUE: i64 = 0x3;
            }
            pub mod CNmOrientationWarpNode__AlignmentMode_t {
                pub const MovementDirection: i64 = 0x0;
                pub const AnimationEndFacing: i64 = 0x1;
            }
            pub mod VPhysXAggregateData_t__VPhysXFlagEnum_t {
                pub const FLAG_LEVEL_COLLISION: i64 = 0x10;
                pub const FLAG_IS_POLYSOUP_GEOMETRY: i64 = 0x1;
                pub const FLAG_IGNORE_SCALE_OBSOLETE_DO_NOT_USE: i64 = 0x20;
            }
            pub mod CNmStateNode__TimedEvent_t__Comparison_t {
                pub const LessThanEqual: i64 = 0x0;
                pub const GreaterThanEqual: i64 = 0x1;
            }
            pub mod CNmRootMotionOverrideNode__OverrideFlags_t {
                pub const AllowMoveX: i64 = 0x0;
                pub const AllowMoveY: i64 = 0x1;
                pub const AllowMoveZ: i64 = 0x2;
                pub const ListenForEvents: i64 = 0x4;
                pub const AllowFacingPitch: i64 = 0x3;
            }
            pub mod CNmSyncEventIndexConditionNode__TriggerMode_t {
                pub const ExactlyAtEventIndex: i64 = 0x0;
                pub const GreaterThanEqualToEventIndex: i64 = 0x1;
            }
        }
    }
}
