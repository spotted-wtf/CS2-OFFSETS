export namespace cs2_dumper {
    export namespace schemas {
        export namespace vphysics2_dll {
            export namespace Dop26_t {
                export const m_flSupport = 0x0;
            }
            export namespace FeTri_t {
                export const v2 = 0x14;
                export const w1 = 0x8;
                export const w2 = 0xC;
                export const v1x = 0x10;
                export const nNode = 0x0;
            }
            export namespace FeQuad_t {
                export const nNode = 0x0;
                export const vShape = 0xC;
                export const flSlack = 0x8;
            }
            export namespace RnFace_t {
                export const m_nEdge = 0x0;
            }
            export namespace RnHull_t {
                export const m_Edges = 0xC8;
                export const m_Faces = 0xE0;
                export const m_Bounds = 0x14;
                export const m_nFlags = 0xA0;
                export const m_Vertices = 0xB0;
                export const m_flVolume = 0x68;
                export const m_vCentroid = 0x0;
                export const m_FacePlanes = 0x88;
                export const m_pRegionSVM = 0xA8;
                export const m_flSurfaceArea = 0x6C;
                export const m_MassProperties = 0x38;
                export const m_VertexPositions = 0x70;
                export const m_flMaxAngularRadius = 0xC;
                export const m_vOrthographicAreas = 0x2C;
                export const m_flMinCentroidRadius = 0x10;
            }
            export namespace RnMesh_t {
                export const m_vMax = 0xC;
                export const m_vMin = 0x0;
                export const m_Nodes = 0x18;
                export const m_Wings = 0x60;
                export const m_nFlags = 0xB4;
                export const m_Vertices = 0x30;
                export const m_Materials = 0x90;
                export const m_Triangles = 0x48;
                export const m_nDebugFlags = 0xB8;
                export const m_flSurfaceArea = 0xBC;
                export const m_TriangleEdgeFlags = 0x78;
                export const m_vOrthographicAreas = 0xA8;
            }
            export namespace RnNode_t {
                export const m_vMax = 0x10;
                export const m_vMin = 0x0;
                export const m_nChildren = 0xC;
                export const m_nTriangleOffset = 0x1C;
            }
            export namespace RnWing_t {
                export const m_nIndex = 0x0;
            }
            export namespace FePrism_t {
                export const nNode = 0x0;
                export const flVolume = 0xC;
            }
            export namespace RnPlane_t {
                export const m_vNormal = 0x0;
                export const m_flOffset = 0xC;
            }
            export namespace CRegionSVM {
                export const m_Nodes = 0x18;
                export const m_Planes = 0x0;
            }
            export namespace CovMatrix3 {
                export const m_flXY = 0xC;
                export const m_flXZ = 0x10;
                export const m_flYZ = 0x14;
                export const m_vDiag = 0x0;
            }
            export namespace RnVertex_t {
                export const m_nEdge = 0x0;
            }
            export namespace FeSimdTri_t {
                export const v2 = 0x60;
                export const w1 = 0x30;
                export const w2 = 0x40;
                export const v1x = 0x50;
                export const nNode = 0x0;
            }
            export namespace OldFeEdge_t {
                export const t = 0x10;
                export const c01 = 0x1C;
                export const c02 = 0x20;
                export const c03 = 0x24;
                export const c04 = 0x28;
                export const invA = 0xC;
                export const m_flK = 0x0;
                export const m_nNode = 0x40;
                export const flThetaFactor = 0x18;
                export const flThetaRelaxed = 0x14;
                export const flAxialModelDist = 0x2C;
                export const flAxialModelWeights = 0x30;
            }
            export namespace RnCapsule_t {
                export const m_vCenter = 0x0;
                export const m_flRadius = 0x18;
            }
            export namespace FeBoxRigid_t {
                export const nNode = 0x20;
                export const vSize = 0x24;
                export const nFlags = 0x32;
                export const tmFrame2 = 0x0;
                export const nCollisionMask = 0x22;
                export const nVertexMapIndex = 0x30;
            }
            export namespace FeEdgeDesc_t {
                export const nEdge = 0x0;
                export const nSide = 0x4;
                export const nVirtElem = 0xC;
            }
            export namespace FeNodeBase_t {
                export const nNode = 0x0;
                export const nDummy = 0x2;
                export const nNodeX0 = 0x8;
                export const nNodeX1 = 0xA;
                export const nNodeY0 = 0xC;
                export const nNodeY1 = 0xE;
                export const qAdjust = 0x10;
            }
            export namespace FeSDFRigid_t {
                export const nNode = 0x1C;
                export const nFlags = 0x22;
                export const m_nDepth = 0x48;
                export const m_nWidth = 0x40;
                export const m_nHeight = 0x44;
                export const vLocalMax = 0xC;
                export const vLocalMin = 0x0;
                export const m_Distances = 0x28;
                export const flBounciness = 0x18;
                export const nCollisionMask = 0x1E;
                export const nVertexMapIndex = 0x20;
            }
            export namespace FeSimdQuad_t {
                export const nNode = 0x0;
                export const vShape = 0x30;
                export const f4Slack = 0x20;
                export const f4Weights = 0xF0;
            }
            export namespace IPhysicsBody {

            }
            export namespace RnBodyDesc_t {
                export const m_bEnabled = 0xC7;
                export const m_vGravity = 0xCC;
                export const m_bSleeping = 0xC8;
                export const m_flMassInv = 0x6C;
                export const m_nBodyType = 0xB8;
                export const m_vPosition = 0x8;
                export const m_flGameMass = 0x70;
                export const m_nGameFlags = 0xC0;
                export const m_nGameIndex = 0xBC;
                export const m_sDebugName = 0x0;
                export const m_flTimeScale = 0xB4;
                export const m_bDragEnabled = 0xCA;
                export const m_qOrientation = 0x14;
                export const m_nMassPriority = 0xC6;
                export const m_flGravityScale = 0xB0;
                export const m_flMassScaleInv = 0x74;
                export const m_LocalInertiaInv = 0x48;
                export const m_flBuoyancyScale = 0xAC;
                export const m_flLinearDamping = 0x7C;
                export const m_vLinearVelocity = 0x24;
                export const m_flAngularDamping = 0x80;
                export const m_vAngularVelocity = 0x30;
                export const m_vLocalMassCenter = 0x3C;
                export const m_flInertiaScaleInv = 0x78;
                export const m_flLinearDragScale = 0x84;
                export const m_flAngularDragScale = 0x88;
                export const m_bSpeculativeEnabled = 0xD8;
                export const m_bHasShadowController = 0xD9;
                export const m_bIsContinuousEnabled = 0xC9;
                export const m_vLastAwakeForceAccum = 0x94;
                export const m_vLastAwakeTorqueAccum = 0xA0;
                export const m_flLinearFluidDragScale = 0x8C;
                export const m_nMinPositionIterations = 0xC5;
                export const m_nMinVelocityIterations = 0xC4;
                export const m_flAngularFluidDragScale = 0x90;
                export const m_nDynamicContinuousContactBehavior = 0xDA;
            }
            export namespace RnCompound_t {
                export const m_Tree = 0x0;
                export const m_Hulls = 0xF0;
                export const m_Bounds = 0x130;
                export const m_Meshes = 0x28;
                export const m_Spheres = 0x110;
                export const m_Capsules = 0x100;
                export const m_flVolume = 0x158;
                export const m_nShapeCount = 0x20;
                export const m_flSurfaceArea = 0x154;
                export const m_nHullBaseIndex = 0x18;
                export const m_nMeshBaseIndex = 0x1C;
                export const m_vOrthographicAreas = 0x148;
                export const m_CompoundMaterialIndices = 0x120;
            }
            export namespace RnHalfEdge_t {
                export const m_nFace = 0x3;
                export const m_nNext = 0x0;
                export const m_nTwin = 0x1;
                export const m_nOrigin = 0x2;
            }
            export namespace RnHullDesc_t {
                export const m_Hull = 0x18;
            }
            export namespace RnMeshDesc_t {
                export const m_Mesh = 0x18;
            }
            export namespace RnTriangle_t {
                export const m_nIndex = 0x0;
            }
            export namespace CFeJiggleBone {
                export const m_nFlags = 0x0;
                export const m_vPoint0 = 0x80;
                export const m_vPoint1 = 0x8C;
                export const m_flLength = 0x4;
                export const m_flMaxYaw = 0x2C;
                export const m_flMinYaw = 0x28;
                export const m_flRadius0 = 0x78;
                export const m_flRadius1 = 0x7C;
                export const m_flTipMass = 0x8;
                export const m_flBaseMass = 0x48;
                export const m_flMaxPitch = 0x3C;
                export const m_flMinPitch = 0x38;
                export const m_flBaseMaxUp = 0x64;
                export const m_flBaseMinUp = 0x60;
                export const m_flYawBounce = 0x34;
                export const m_flAngleLimit = 0x24;
                export const m_flYawDamping = 0x10;
                export const m_flBaseDamping = 0x50;
                export const m_flBaseMaxLeft = 0x58;
                export const m_flBaseMinLeft = 0x54;
                export const m_flPitchBounce = 0x44;
                export const m_flYawFriction = 0x30;
                export const m_flAlongDamping = 0x20;
                export const m_flPitchDamping = 0x18;
                export const m_flYawStiffness = 0xC;
                export const m_nCollisionMask = 0x98;
                export const m_flBaseStiffness = 0x4C;
                export const m_flPitchFriction = 0x40;
                export const m_flAlongStiffness = 0x1C;
                export const m_flBaseMaxForward = 0x70;
                export const m_flBaseMinForward = 0x6C;
                export const m_flBaseUpFriction = 0x68;
                export const m_flPitchStiffness = 0x14;
                export const m_flBaseLeftFriction = 0x5C;
                export const m_flBaseForwardFriction = 0x74;
            }
            export namespace CFeMorphLayer {
                export const m_Name = 0x0;
                export const m_Nodes = 0x10;
                export const m_Gravity = 0x40;
                export const m_InitPos = 0x28;
                export const m_nNameHash = 0x8;
                export const m_GoalDamping = 0x70;
                export const m_GoalStrength = 0x58;
            }
            export namespace FeFitMatrix_t {
                export const bone = 0x0;
                export const nEnd = 0x2C;
                export const nNode = 0x2E;
                export const vCenter = 0x20;
                export const nBeginDynamic = 0x30;
            }
            export namespace FeFitWeight_t {
                export const nNode = 0x4;
                export const nDummy = 0x6;
                export const flWeight = 0x0;
            }
            export namespace FeSimdPrism_t {
                export const nNode = 0x0;
                export const flVolume = 0x30;
            }
            export namespace FourVectors2D {
                export const x = 0x0;
                export const y = 0x10;
            }
            export namespace IPhysicsJoint {

            }
            export namespace RnShapeDesc_t {
                export const m_UserFriendlyName = 0x8;
                export const m_nToolMaterialHash = 0x14;
                export const m_bUserFriendlyNameLong = 0x11;
                export const m_nSurfacePropertyIndex = 0x4;
                export const m_bUserFriendlyNameSealed = 0x10;
                export const m_nCollisionAttributeIndex = 0x0;
            }
            export namespace FeCtrlOffset_t {
                export const vOffset = 0x0;
                export const nCtrlChild = 0xE;
                export const nCtrlParent = 0xC;
            }
            export namespace FeDynKinLink_t {
                export const m_nChild = 0x2;
                export const m_nParent = 0x0;
            }
            export namespace FeEffectDesc_t {
                export const nType = 0xC;
                export const sName = 0x0;
                export const m_Params = 0x10;
                export const nNameHash = 0x8;
            }
            export namespace FeFollowNode_t {
                export const flWeight = 0x4;
                export const nChildNode = 0x2;
                export const nParentNode = 0x0;
            }
            export namespace FeHingeLimit_t {
                export const nNode = 0x0;
                export const nFlags = 0xC;
                export const flWeight4 = 0x10;
                export const flWeight5 = 0x14;
                export const flAngleCenter = 0x18;
                export const flAngleExtents = 0x1C;
            }
            export namespace FeSoftParent_t {
                export const flAlpha = 0x4;
                export const nParent = 0x0;
            }
            export namespace FeSourceEdge_t {
                export const nNode = 0x0;
            }
            export namespace RnSphereDesc_t {
                export const m_Sphere = 0x18;
            }
            export namespace FeSphereRigid_t {
                export const nNode = 0x10;
                export const nFlags = 0x16;
                export const vSphere = 0x0;
                export const nCollisionMask = 0x12;
                export const nVertexMapIndex = 0x14;
            }
            export namespace RnBlendVertex_t {
                export const m_nFlags = 0xC;
                export const m_nIndex0 = 0x2;
                export const m_nIndex1 = 0x6;
                export const m_nIndex2 = 0xA;
                export const m_nWeight0 = 0x0;
                export const m_nWeight1 = 0x4;
                export const m_nWeight2 = 0x8;
                export const m_nTargetIndex = 0xE;
            }
            export namespace RnCapsuleDesc_t {
                export const m_Capsule = 0x18;
            }
            export namespace VPhysEntityId_t {
                export const m_Id = 0x0;
            }
            export namespace FeCtrlOsOffset_t {
                export const nCtrlChild = 0x2;
                export const nCtrlParent = 0x0;
            }
            export namespace FeFitInfluence_t {
                export const flWeight = 0x4;
                export const nMatrixNode = 0x8;
                export const nVertexNode = 0x0;
            }
            export namespace FeKelagerBend2_t {
                export const nNode = 0x10;
                export const flWeight = 0x0;
                export const flHeight0 = 0xC;
                export const nReserved = 0x16;
            }
            export namespace FeNodeStrayBox_t {
                export const vMax = 0x10;
                export const vMin = 0x0;
                export const nNode = 0x1C;
                export const nFlags = 0xC;
            }
            export namespace FeNodeWindBase_t {
                export const nNodeX0 = 0x0;
                export const nNodeX1 = 0x2;
                export const nNodeY0 = 0x4;
                export const nNodeY1 = 0x6;
            }
            export namespace FeSimdNodeBase_t {
                export const nNode = 0x0;
                export const nDummy = 0x28;
                export const nNodeX0 = 0x8;
                export const nNodeX1 = 0x10;
                export const nNodeY0 = 0x18;
                export const nNodeY1 = 0x20;
                export const qAdjust = 0x30;
            }
            export namespace FeTreeChildren_t {
                export const nChild = 0x0;
            }
            export namespace FeWeightedNode_t {
                export const nNode = 0x0;
                export const nWeight = 0x2;
            }
            export namespace FourCovMatrices3 {
                export const m_flXY = 0x30;
                export const m_flXZ = 0x40;
                export const m_flYZ = 0x50;
                export const m_vDiag = 0x0;
            }
            export namespace IPhysicsBodyList {

            }
            export namespace RnCompoundDesc_t {
                export const m_Compound = 0x18;
            }
            export namespace RnCompoundTree_t {
                export const m_Nodes = 0x0;
                export const m_nStartIterationIndex = 0x10;
            }
            export namespace FeAxialEdgeBend_t {
                export const te = 0x0;
                export const tv = 0x4;
                export const nNode = 0x1C;
                export const flDist = 0x8;
                export const flWeight = 0xC;
            }
            export namespace FeBandBendLimit_t {
                export const nNode = 0x8;
                export const flDistMax = 0x4;
                export const flDistMin = 0x0;
            }
            export namespace FeBoneMergeLink_t {
                export const m_nChildNode = 0x4;
                export const m_nParentHash = 0x0;
            }
            export namespace FeBuildBoxRigid_t {
                export const m_nPriority = 0x40;
                export const m_nVertexMapHash = 0x44;
                export const m_nAntitunnelGroupBits = 0x48;
            }
            export namespace FeBuildSDFRigid_t {
                export const m_nPriority = 0x50;
                export const m_nVertexMapHash = 0x54;
                export const m_nAntitunnelGroupBits = 0x58;
            }
            export namespace FeRodConstraint_t {
                export const nNode = 0x0;
                export const flMaxDist = 0x4;
                export const flMinDist = 0x8;
                export const flWeight0 = 0xC;
                export const flRelaxationFactor = 0x10;
            }
            export namespace FeVertexMapDesc_t {
                export const sName = 0x0;
                export const nColor = 0xC;
                export const nFlags = 0x10;
                export const nNameHash = 0x8;
                export const nMapOffset = 0x18;
                export const nVertexBase = 0x14;
                export const nVertexCount = 0x16;
                export const vCenterOfMass = 0x20;
                export const nNodeListCount = 0x32;
                export const nNodeListOffset = 0x1C;
                export const nScaleSourceNode = 0x30;
                export const flVolumetricSolveStrength = 0x2C;
            }
            export namespace PhysFeModelDesc_t {
                export const m_Rods = 0x168;
                export const m_Tris = 0x558;
                export const m_Quads = 0xA8;
                export const m_Ropes = 0x60;
                export const m_Prisms = 0xF0;
                export const m_Twists = 0x180;
                export const m_Effects = 0x650;
                export const m_CtrlHash = 0x0;
                export const m_CtrlName = 0x18;
                export const m_InitPose = 0x150;
                export const m_SimdRods = 0x120;
                export const m_SimdTris = 0xD8;
                export const m_BoxRigids = 0x590;
                export const m_FreeNodes = 0x450;
                export const m_NodeBases = 0x78;
                export const m_SDFRigids = 0x578;
                export const m_SimdQuads = 0xC0;
                export const m_flWindage = 0x6E8;
                export const m_AxialEdges = 0x240;
                export const m_FitWeights = 0x480;
                export const m_LocalForce = 0x390;
                export const m_LockToGoal = 0x680;
                export const m_SimdPrisms = 0x108;
                export const m_VertexMaps = 0x620;
                export const m_flWindDrag = 0x6EC;
                export const m_nNodeCount = 0x40;
                export const m_nRopeCount = 0x58;
                export const m_nTreeDepth = 0x54;
                export const m_nTriCount1 = 0x570;
                export const m_nTriCount2 = 0x572;
                export const m_CtrlOffsets = 0x270;
                export const m_DynKinLinks = 0x1C8;
                export const m_FitMatrices = 0x468;
                export const m_FollowNodes = 0x2A0;
                export const m_HingeLimits = 0x198;
                export const m_JiggleBones = 0x510;
                export const m_MorphLayers = 0x5F0;
                export const m_SkelParents = 0x698;
                export const m_SourceElems = 0x528;
                export const m_TreeParents = 0x408;
                export const m_nQuadCount1 = 0x50;
                export const m_nQuadCount2 = 0x52;
                export const m_KelagerBends = 0x4E0;
                export const m_LockToParent = 0x668;
                export const m_MorphSetData = 0x608;
                export const m_SimdRodsAnim = 0x138;
                export const m_SphereRigids = 0x3D8;
                export const m_TreeChildren = 0x438;
                export const m_flLocalDrag1 = 0x720;
                export const m_flLocalForce = 0x38;
                export const m_nStaticNodes = 0x42;
                export const m_CtrlOsOffsets = 0x288;
                export const m_LocalRotation = 0x378;
                export const m_NodeInvMasses = 0x258;
                export const m_SimdNodeBases = 0x90;
                export const m_AnimStrayRadii = 0x4B0;
                export const m_BoneMergeLinks = 0x1E0;
                export const m_NodeIntegrator = 0x2D0;
                export const m_NodeStrayBoxes = 0x228;
                export const m_ReverseOffsets = 0x498;
                export const m_VertexSetNames = 0x5C0;
                export const m_nReservedUint8 = 0x574;
                export const m_nSimdTriCount1 = 0x48;
                export const m_nSimdTriCount2 = 0x4A;
                export const m_CollisionPlanes = 0x2B8;
                export const m_CtrlSoftOffsets = 0x4F8;
                export const m_DynNodeFriction = 0x360;
                export const m_VertexMapValues = 0x638;
                export const m_flLocalRotation = 0x3C;
                export const m_nSimdQuadCount1 = 0x4C;
                export const m_nSimdQuadCount2 = 0x4E;
                export const m_AntiTunnelProbes = 0x1F8;
                export const m_DynNodeVertexSet = 0x5A8;
                export const m_DynNodeWindBases = 0x6B0;
                export const m_SpringIntegrator = 0x2E8;
                export const m_nExtraIterations = 0x577;
                export const m_nStaticNodeFlags = 0x30;
                export const m_flMotionSmoothCDT = 0x71C;
                export const m_nDynamicNodeFlags = 0x34;
                export const m_AntiTunnelBytecode = 0x1B0;
                export const m_LegacyStretchForce = 0x330;
                export const m_NodeCollisionRadii = 0x348;
                export const m_SimdAnimStrayRadii = 0x4C8;
                export const m_TreeCollisionMasks = 0x420;
                export const m_flInternalPressure = 0x6E0;
                export const m_SelfCollisionLayers = 0x6C8;
                export const m_WorldCollisionNodes = 0x3F0;
                export const m_flDefaultExpAirDrag = 0x700;
                export const m_flDefaultVelAirDrag = 0x6FC;
                export const m_nRotLockStaticNodes = 0x44;
                export const m_SimdSpringIntegrator = 0x300;
                export const m_TaperedCapsuleRigids = 0x3C0;
                export const m_WorldCollisionParams = 0x318;
                export const m_nExtraGoalIterations = 0x576;
                export const m_AntiTunnelTargetNodes = 0x210;
                export const m_flDefaultGravityScale = 0x6F8;
                export const m_flDefaultTimeDilation = 0x6E4;
                export const m_flDefaultThreadStretch = 0x6F4;
                export const m_RigidColliderPriorities = 0x5D8;
                export const m_TaperedCapsuleStretches = 0x3A8;
                export const m_flDefaultExpQuadAirDrag = 0x708;
                export const m_flDefaultSurfaceStretch = 0x6F0;
                export const m_flDefaultVelQuadAirDrag = 0x704;
                export const m_flRodVelocitySmoothRate = 0x70C;
                export const m_flQuadVelocitySmoothRate = 0x710;
                export const m_nExtraPressureIterations = 0x575;
                export const m_nFirstPositionDrivenNode = 0x46;
                export const m_flAddWorldCollisionRadius = 0x714;
                export const m_GoalDampedSpringIntegrators = 0x540;
                export const m_nRodVelocitySmoothIterations = 0x724;
                export const m_nQuadVelocitySmoothIterations = 0x726;
                export const m_flDefaultVolumetricSolveAmount = 0x718;
                export const m_nNodeBaseJiggleboneDependsCount = 0x56;
            }
            export namespace CFeNamedJiggleBone {
                export const m_transform = 0x10;
                export const m_jiggleBone = 0x34;
                export const m_nJiggleParent = 0x30;
                export const m_strParentBone = 0x0;
            }
            export namespace CGenericShapeProxy {
                export const m_verts = 0x30;
            }
            export namespace FeCollisionPlane_t {
                export const m_Plane = 0x4;
                export const flStrength = 0x14;
                export const nChildNode = 0x2;
                export const nCtrlParent = 0x0;
            }
            export namespace FeCtrlSoftOffset_t {
                export const flAlpha = 0x10;
                export const vOffset = 0x4;
                export const nCtrlChild = 0x2;
                export const nCtrlParent = 0x0;
            }
            export namespace FeMorphLayerDepr_t {
                export const m_Name = 0x0;
                export const m_Nodes = 0x10;
                export const m_nFlags = 0x88;
                export const m_Gravity = 0x40;
                export const m_InitPos = 0x28;
                export const m_nNameHash = 0x8;
                export const m_GoalDamping = 0x70;
                export const m_GoalStrength = 0x58;
            }
            export namespace FeNodeIntegrator_t {
                export const flGravity = 0xC;
                export const flPointDamping = 0x0;
                export const flAnimationForceAttraction = 0x4;
                export const flAnimationVertexAttraction = 0x8;
            }
            export namespace FeProxyVertexMap_t {
                export const m_Name = 0x0;
                export const m_flWeight = 0x8;
            }
            export namespace FeVertexMapBuild_t {
                export const m_Color = 0xC;
                export const m_Weights = 0x18;
                export const m_nNameHash = 0x8;
                export const m_VertexMapName = 0x0;
                export const m_nScaleSourceNode = 0x14;
                export const m_flVolumetricSolveStrength = 0x10;
            }
            export namespace RnSoftbodySpring_t {
                export const m_flLength = 0x4;
                export const m_nParticle = 0x0;
            }
            export namespace FeAnimStrayRadius_t {
                export const nNode = 0x0;
                export const flMaxDist = 0x4;
                export const flRelaxationFactor = 0x8;
            }
            export namespace FeAntiTunnelProbe_t {
                export const flBias = 0x18;
                export const nBegin = 0xC;
                export const nCount = 0xA;
                export const nFlags = 0x4;
                export const flWeight = 0x0;
                export const nProbeNode = 0x8;
                export const flCurvatureRadius = 0x14;
                export const flActivationDistance = 0x10;
            }
            export namespace FeHingeLimitBuild_t {
                export const nNode = 0x0;
                export const nFlags = 0xC;
                export const flLimitCW = 0x10;
                export const flLimitCCW = 0x14;
            }
            export namespace FeStiffHingeBuild_t {
                export const nNode = 0x14;
                export const flMaxAngle = 0x0;
                export const flStrength = 0x4;
                export const flMotionBias = 0x8;
            }
            export namespace FeTwistConstraint_t {
                export const nNodeEnd = 0x2;
                export const nNodeOrient = 0x0;
                export const flSwingRelax = 0x8;
                export const flTwistRelax = 0x4;
            }
            export namespace PhysicsParticleId_t {
                export const m_Value = 0x0;
            }
            export namespace RnSoftbodyCapsule_t {
                export const m_vCenter = 0x0;
                export const m_flRadius = 0x18;
                export const m_nParticle = 0x1C;
            }
            export namespace CFeIndexedJiggleBone {
                export const m_nNode = 0x0;
                export const m_jiggleBone = 0x8;
                export const m_nJiggleParent = 0x4;
            }
            export namespace FeBuildSphereRigid_t {
                export const m_nPriority = 0x20;
                export const m_nVertexMapHash = 0x24;
                export const m_nAntitunnelGroupBits = 0x28;
            }
            export namespace FeSpringIntegrator_t {
                export const nNode = 0x0;
                export const flNodeWeight0 = 0x10;
                export const flSpringDamping = 0xC;
                export const flSpringConstant = 0x8;
                export const flSpringRestLength = 0x4;
            }
            export namespace IPhysicsParticleRope {

            }
            export namespace RnCompoundTreeNode_t {
                export const m_vMax = 0xC;
                export const m_vMin = 0x0;
                export const m_nType = 0x0;
                export const m_nSubtreeEndOrCompoundId = 0x0;
            }
            export namespace RnSoftbodyParticle_t {
                export const m_flMassInv = 0x0;
            }
            export namespace FeNodeReverseOffset_t {
                export const vOffset = 0x0;
                export const nBoneCtrl = 0xC;
                export const nTargetNode = 0xE;
            }
            export namespace FeSimdRodConstraint_t {
                export const nNode = 0x0;
                export const f4MaxDist = 0x10;
                export const f4MinDist = 0x20;
                export const f4Weight0 = 0x30;
                export const f4RelaxationFactor = 0x40;
            }
            export namespace VertexPositionColor_t {
                export const m_vPosition = 0x0;
            }
            export namespace CFeVertexMapBuildArray {
                export const m_Array = 0x0;
            }
            export namespace IPhysAggregateInstance {
                export const m_pSkeleton = 0x8;
                export const m_bIsAxisAligned = 0x10;
            }
            export namespace IPhysicsRagdollControl {

            }
            export namespace VertexPositionNormal_t {
                export const m_vNormal = 0xC;
                export const m_vPosition = 0x0;
            }
            export namespace constraint_axislimit_t {
                export const flMaxRotation = 0x4;
                export const flMinRotation = 0x0;
                export const flMotorMaxTorque = 0xC;
                export const flMotorTargetAngSpeed = 0x8;
            }
            export namespace FeSimdAnimStrayRadius_t {
                export const nNode = 0x0;
                export const flMaxDist = 0x10;
                export const flRelaxationFactor = 0x20;
            }
            export namespace FeTaperedCapsuleRigid_t {
                export const nNode = 0x20;
                export const nFlags = 0x26;
                export const vSphere = 0x0;
                export const nCollisionMask = 0x22;
                export const nVertexMapIndex = 0x24;
            }
            export namespace FeAntiTunnelGroupBuild_t {
                export const m_nCollisionMask = 0x4;
                export const m_nVertexMapHash = 0x0;
            }
            export namespace FeAntiTunnelProbeBuild_t {
                export const flBias = 0x8;
                export const nFlags = 0x10;
                export const flWeight = 0x0;
                export const nProbeNode = 0x14;
                export const flCurvature = 0xC;
                export const targetNodes = 0x18;
                export const flActivationDistance = 0x4;
            }
            export namespace FeRigidColliderIndices_t {
                export const m_nBoxRigidIndex = 0x4;
                export const m_nSDFRigidIndex = 0x6;
                export const m_nSphereRigidIndex = 0x2;
                export const m_nCollisionPlaneIndex = 0x8;
                export const m_nTaperedCapsuleRigidIndex = 0x0;
            }
            export namespace FeSimdSpringIntegrator_t {
                export const nNode = 0x0;
                export const flNodeWeight0 = 0x40;
                export const flSpringDamping = 0x30;
                export const flSpringConstant = 0x20;
                export const flSpringRestLength = 0x10;
            }
            export namespace FeWorldCollisionParams_t {
                export const nListEnd = 0xA;
                export const nListBegin = 0x8;
                export const flWorldFriction = 0x0;
                export const flGroundFriction = 0x4;
            }
            export namespace IPhysicsMotionController {

            }
            export namespace IPhysicsPlayerController {

            }
            export namespace constraint_hingeparams_t {
                export const hingeAxis = 0x18;
                export const constraint = 0x28;
                export const worldPosition = 0x0;
                export const worldAxisDirection = 0xC;
            }
            export namespace FeSimdRodConstraintAnim_t {
                export const nNode = 0x0;
                export const f4Weight0 = 0x10;
                export const f4RelaxationFactor = 0x20;
            }
            export namespace FeTaperedCapsuleStretch_t {
                export const nNode = 0x0;
                export const nDummy = 0x6;
                export const flRadius = 0x8;
                export const nCollisionMask = 0x4;
            }
            export namespace CollisionDetailLayerInfo_t {
                export const m_bIsQueryOnly = 0x10;
                export const m_bNotPickable = 0x38;
                export const m_sDescription = 0x0;
                export const m_sFriendlyName = 0x8;
                export const m_sParentDetailLayer = 0x18;
                export const m_vecSubtreeDetailLayers = 0x20;
            }
            export namespace FeModelSelfCollisionLayer_t {
                export const m_Name = 0x0;
                export const m_Nodes = 0x8;
                export const m_nFlags = 0x24;
                export const m_nEndIdx = 0x28;
                export const m_flParentReaction = 0x20;
            }
            export namespace FeBuildTaperedCapsuleRigid_t {
                export const m_nPriority = 0x30;
                export const m_nVertexMapHash = 0x34;
                export const m_nAntitunnelGroupBits = 0x38;
            }
            export namespace constraint_breakableparams_t {
                export const isActive = 0x14;
                export const strength = 0x0;
                export const forceLimit = 0x4;
                export const torqueLimit = 0x8;
                export const bodyMassScale = 0xC;
            }
            export namespace vphysics_save_cphysicsbody_t {
                export const m_nOldPointer = 0xE0;
            }
            export namespace vphysics_save_ragdoll_control_t {
                export const m_nBodyCount = 0x34;
                export const m_flMaxStretch = 0x8;
                export const m_bIgnoreTeleport = 0xE;
                export const m_vForceAccumulator = 0x28;
                export const m_flMaxSpringFrequency = 0x4;
                export const m_flMinSpringFrequency = 0x0;
                export const m_bRequiresDynamicBodies = 0xD;
                export const m_vLinearVelocityAccumulator = 0x10;
                export const m_bSolidCollisionAtZeroWeight = 0xC;
                export const m_vAngularVelocityAccumulator = 0x1C;
            }
            export namespace CollisionDetailLayerInfo_t__Name_t {
                export const m_nNameToken = 0x0;
                export const m_sNameString = 0x8;
            }
            export namespace JointAxis_t {
                export const JOINT_AXIS_X = 0x0;
                export const JOINT_AXIS_Y = 0x1;
                export const JOINT_AXIS_Z = 0x2;
                export const JOINT_AXIS_COUNT = 0x3;
            }
            export namespace JointMotion_t {
                export const JOINT_MOTION_FREE = 0x0;
                export const JOINT_MOTION_COUNT = 0x2;
                export const JOINT_MOTION_LOCKED = 0x1;
            }
            export namespace PhysInterfaceId_t {
                export const PIID_UNKNOWN = 0x0;
                export const PIID_NUM_TYPES = 0x7;
                export const PIID_IPHYSICSBODY = 0x1;
                export const PIID_IPHYSICSJOINT = 0x3;
                export const PIID_IPHYSAGGREGATE = 0x2;
                export const PIID_IPHYSICSPARTICLEROPE = 0x5;
                export const PIID_IPHYSICSRAGDOLLCONTROL = 0x6;
                export const PIID_IPHYSICSMOTIONCONTROLLER = 0x4;
            }
            export namespace PhysGenericShapeType_t {
                export const GENERIC_SHAPE_AABB = 0x2;
                export const GENERIC_SHAPE_HULL = 0x4;
                export const GENERIC_SHAPE_POINT = 0x0;
                export const GENERIC_SHAPE_SPHERE = 0x1;
                export const GENERIC_SHAPE_CAPSULE = 0x3;
            }
            export namespace DynamicContinuousContactBehavior_t {
                export const DYNAMIC_CONTINUOUS_NEVER = 0x2;
                export const DYNAMIC_CONTINUOUS_ALWAYS = 0x1;
                export const DYNAMIC_CONTINUOUS_ALLOW_IF_REQUESTED_BY_OTHER_BODY = 0x0;
            }
        }
    }
}
