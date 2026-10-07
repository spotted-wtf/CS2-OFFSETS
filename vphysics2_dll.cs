public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class vphysics2_dll {
            public static partial class Dop26_t {
                public const long m_flSupport = 0x0;
            }
            public static partial class FeTri_t {
                public const long v2 = 0x14;
                public const long w1 = 0x8;
                public const long w2 = 0xC;
                public const long v1x = 0x10;
                public const long nNode = 0x0;
            }
            public static partial class FeQuad_t {
                public const long nNode = 0x0;
                public const long vShape = 0xC;
                public const long flSlack = 0x8;
            }
            public static partial class RnFace_t {
                public const long m_nEdge = 0x0;
            }
            public static partial class RnHull_t {
                public const long m_Edges = 0xC8;
                public const long m_Faces = 0xE0;
                public const long m_Bounds = 0x14;
                public const long m_nFlags = 0xA0;
                public const long m_Vertices = 0xB0;
                public const long m_flVolume = 0x68;
                public const long m_vCentroid = 0x0;
                public const long m_FacePlanes = 0x88;
                public const long m_pRegionSVM = 0xA8;
                public const long m_flSurfaceArea = 0x6C;
                public const long m_MassProperties = 0x38;
                public const long m_VertexPositions = 0x70;
                public const long m_flMaxAngularRadius = 0xC;
                public const long m_vOrthographicAreas = 0x2C;
                public const long m_flMinCentroidRadius = 0x10;
            }
            public static partial class RnMesh_t {
                public const long m_vMax = 0xC;
                public const long m_vMin = 0x0;
                public const long m_Nodes = 0x18;
                public const long m_Wings = 0x60;
                public const long m_nFlags = 0xB4;
                public const long m_Vertices = 0x30;
                public const long m_Materials = 0x90;
                public const long m_Triangles = 0x48;
                public const long m_nDebugFlags = 0xB8;
                public const long m_flSurfaceArea = 0xBC;
                public const long m_TriangleEdgeFlags = 0x78;
                public const long m_vOrthographicAreas = 0xA8;
            }
            public static partial class RnNode_t {
                public const long m_vMax = 0x10;
                public const long m_vMin = 0x0;
                public const long m_nChildren = 0xC;
                public const long m_nTriangleOffset = 0x1C;
            }
            public static partial class RnWing_t {
                public const long m_nIndex = 0x0;
            }
            public static partial class FePrism_t {
                public const long nNode = 0x0;
                public const long flVolume = 0xC;
            }
            public static partial class RnPlane_t {
                public const long m_vNormal = 0x0;
                public const long m_flOffset = 0xC;
            }
            public static partial class CRegionSVM {
                public const long m_Nodes = 0x18;
                public const long m_Planes = 0x0;
            }
            public static partial class CovMatrix3 {
                public const long m_flXY = 0xC;
                public const long m_flXZ = 0x10;
                public const long m_flYZ = 0x14;
                public const long m_vDiag = 0x0;
            }
            public static partial class RnVertex_t {
                public const long m_nEdge = 0x0;
            }
            public static partial class FeSimdTri_t {
                public const long v2 = 0x60;
                public const long w1 = 0x30;
                public const long w2 = 0x40;
                public const long v1x = 0x50;
                public const long nNode = 0x0;
            }
            public static partial class OldFeEdge_t {
                public const long t = 0x10;
                public const long c01 = 0x1C;
                public const long c02 = 0x20;
                public const long c03 = 0x24;
                public const long c04 = 0x28;
                public const long invA = 0xC;
                public const long m_flK = 0x0;
                public const long m_nNode = 0x40;
                public const long flThetaFactor = 0x18;
                public const long flThetaRelaxed = 0x14;
                public const long flAxialModelDist = 0x2C;
                public const long flAxialModelWeights = 0x30;
            }
            public static partial class RnCapsule_t {
                public const long m_vCenter = 0x0;
                public const long m_flRadius = 0x18;
            }
            public static partial class FeBoxRigid_t {
                public const long nNode = 0x20;
                public const long vSize = 0x24;
                public const long nFlags = 0x32;
                public const long tmFrame2 = 0x0;
                public const long nCollisionMask = 0x22;
                public const long nVertexMapIndex = 0x30;
            }
            public static partial class FeEdgeDesc_t {
                public const long nEdge = 0x0;
                public const long nSide = 0x4;
                public const long nVirtElem = 0xC;
            }
            public static partial class FeNodeBase_t {
                public const long nNode = 0x0;
                public const long nDummy = 0x2;
                public const long nNodeX0 = 0x8;
                public const long nNodeX1 = 0xA;
                public const long nNodeY0 = 0xC;
                public const long nNodeY1 = 0xE;
                public const long qAdjust = 0x10;
            }
            public static partial class FeSDFRigid_t {
                public const long nNode = 0x1C;
                public const long nFlags = 0x22;
                public const long m_nDepth = 0x48;
                public const long m_nWidth = 0x40;
                public const long m_nHeight = 0x44;
                public const long vLocalMax = 0xC;
                public const long vLocalMin = 0x0;
                public const long m_Distances = 0x28;
                public const long flBounciness = 0x18;
                public const long nCollisionMask = 0x1E;
                public const long nVertexMapIndex = 0x20;
            }
            public static partial class FeSimdQuad_t {
                public const long nNode = 0x0;
                public const long vShape = 0x30;
                public const long f4Slack = 0x20;
                public const long f4Weights = 0xF0;
            }
            public static partial class IPhysicsBody {

            }
            public static partial class RnBodyDesc_t {
                public const long m_bEnabled = 0xC7;
                public const long m_vGravity = 0xCC;
                public const long m_bSleeping = 0xC8;
                public const long m_flMassInv = 0x6C;
                public const long m_nBodyType = 0xB8;
                public const long m_vPosition = 0x8;
                public const long m_flGameMass = 0x70;
                public const long m_nGameFlags = 0xC0;
                public const long m_nGameIndex = 0xBC;
                public const long m_sDebugName = 0x0;
                public const long m_flTimeScale = 0xB4;
                public const long m_bDragEnabled = 0xCA;
                public const long m_qOrientation = 0x14;
                public const long m_nMassPriority = 0xC6;
                public const long m_flGravityScale = 0xB0;
                public const long m_flMassScaleInv = 0x74;
                public const long m_LocalInertiaInv = 0x48;
                public const long m_flBuoyancyScale = 0xAC;
                public const long m_flLinearDamping = 0x7C;
                public const long m_vLinearVelocity = 0x24;
                public const long m_flAngularDamping = 0x80;
                public const long m_vAngularVelocity = 0x30;
                public const long m_vLocalMassCenter = 0x3C;
                public const long m_flInertiaScaleInv = 0x78;
                public const long m_flLinearDragScale = 0x84;
                public const long m_flAngularDragScale = 0x88;
                public const long m_bSpeculativeEnabled = 0xD8;
                public const long m_bHasShadowController = 0xD9;
                public const long m_bIsContinuousEnabled = 0xC9;
                public const long m_vLastAwakeForceAccum = 0x94;
                public const long m_vLastAwakeTorqueAccum = 0xA0;
                public const long m_flLinearFluidDragScale = 0x8C;
                public const long m_nMinPositionIterations = 0xC5;
                public const long m_nMinVelocityIterations = 0xC4;
                public const long m_flAngularFluidDragScale = 0x90;
                public const long m_nDynamicContinuousContactBehavior = 0xDA;
            }
            public static partial class RnCompound_t {
                public const long m_Tree = 0x0;
                public const long m_Hulls = 0xF0;
                public const long m_Bounds = 0x130;
                public const long m_Meshes = 0x28;
                public const long m_Spheres = 0x110;
                public const long m_Capsules = 0x100;
                public const long m_flVolume = 0x158;
                public const long m_nShapeCount = 0x20;
                public const long m_flSurfaceArea = 0x154;
                public const long m_nHullBaseIndex = 0x18;
                public const long m_nMeshBaseIndex = 0x1C;
                public const long m_vOrthographicAreas = 0x148;
                public const long m_CompoundMaterialIndices = 0x120;
            }
            public static partial class RnHalfEdge_t {
                public const long m_nFace = 0x3;
                public const long m_nNext = 0x0;
                public const long m_nTwin = 0x1;
                public const long m_nOrigin = 0x2;
            }
            public static partial class RnHullDesc_t {
                public const long m_Hull = 0x18;
            }
            public static partial class RnMeshDesc_t {
                public const long m_Mesh = 0x18;
            }
            public static partial class RnTriangle_t {
                public const long m_nIndex = 0x0;
            }
            public static partial class CFeJiggleBone {
                public const long m_nFlags = 0x0;
                public const long m_vPoint0 = 0x80;
                public const long m_vPoint1 = 0x8C;
                public const long m_flLength = 0x4;
                public const long m_flMaxYaw = 0x2C;
                public const long m_flMinYaw = 0x28;
                public const long m_flRadius0 = 0x78;
                public const long m_flRadius1 = 0x7C;
                public const long m_flTipMass = 0x8;
                public const long m_flBaseMass = 0x48;
                public const long m_flMaxPitch = 0x3C;
                public const long m_flMinPitch = 0x38;
                public const long m_flBaseMaxUp = 0x64;
                public const long m_flBaseMinUp = 0x60;
                public const long m_flYawBounce = 0x34;
                public const long m_flAngleLimit = 0x24;
                public const long m_flYawDamping = 0x10;
                public const long m_flBaseDamping = 0x50;
                public const long m_flBaseMaxLeft = 0x58;
                public const long m_flBaseMinLeft = 0x54;
                public const long m_flPitchBounce = 0x44;
                public const long m_flYawFriction = 0x30;
                public const long m_flAlongDamping = 0x20;
                public const long m_flPitchDamping = 0x18;
                public const long m_flYawStiffness = 0xC;
                public const long m_nCollisionMask = 0x98;
                public const long m_flBaseStiffness = 0x4C;
                public const long m_flPitchFriction = 0x40;
                public const long m_flAlongStiffness = 0x1C;
                public const long m_flBaseMaxForward = 0x70;
                public const long m_flBaseMinForward = 0x6C;
                public const long m_flBaseUpFriction = 0x68;
                public const long m_flPitchStiffness = 0x14;
                public const long m_flBaseLeftFriction = 0x5C;
                public const long m_flBaseForwardFriction = 0x74;
            }
            public static partial class CFeMorphLayer {
                public const long m_Name = 0x0;
                public const long m_Nodes = 0x10;
                public const long m_Gravity = 0x40;
                public const long m_InitPos = 0x28;
                public const long m_nNameHash = 0x8;
                public const long m_GoalDamping = 0x70;
                public const long m_GoalStrength = 0x58;
            }
            public static partial class FeFitMatrix_t {
                public const long bone = 0x0;
                public const long nEnd = 0x2C;
                public const long nNode = 0x2E;
                public const long vCenter = 0x20;
                public const long nBeginDynamic = 0x30;
            }
            public static partial class FeFitWeight_t {
                public const long nNode = 0x4;
                public const long nDummy = 0x6;
                public const long flWeight = 0x0;
            }
            public static partial class FeSimdPrism_t {
                public const long nNode = 0x0;
                public const long flVolume = 0x30;
            }
            public static partial class FourVectors2D {
                public const long x = 0x0;
                public const long y = 0x10;
            }
            public static partial class IPhysicsJoint {

            }
            public static partial class RnShapeDesc_t {
                public const long m_UserFriendlyName = 0x8;
                public const long m_nToolMaterialHash = 0x14;
                public const long m_bUserFriendlyNameLong = 0x11;
                public const long m_nSurfacePropertyIndex = 0x4;
                public const long m_bUserFriendlyNameSealed = 0x10;
                public const long m_nCollisionAttributeIndex = 0x0;
            }
            public static partial class FeCtrlOffset_t {
                public const long vOffset = 0x0;
                public const long nCtrlChild = 0xE;
                public const long nCtrlParent = 0xC;
            }
            public static partial class FeDynKinLink_t {
                public const long m_nChild = 0x2;
                public const long m_nParent = 0x0;
            }
            public static partial class FeEffectDesc_t {
                public const long nType = 0xC;
                public const long sName = 0x0;
                public const long m_Params = 0x10;
                public const long nNameHash = 0x8;
            }
            public static partial class FeFollowNode_t {
                public const long flWeight = 0x4;
                public const long nChildNode = 0x2;
                public const long nParentNode = 0x0;
            }
            public static partial class FeHingeLimit_t {
                public const long nNode = 0x0;
                public const long nFlags = 0xC;
                public const long flWeight4 = 0x10;
                public const long flWeight5 = 0x14;
                public const long flAngleCenter = 0x18;
                public const long flAngleExtents = 0x1C;
            }
            public static partial class FeSoftParent_t {
                public const long flAlpha = 0x4;
                public const long nParent = 0x0;
            }
            public static partial class FeSourceEdge_t {
                public const long nNode = 0x0;
            }
            public static partial class RnSphereDesc_t {
                public const long m_Sphere = 0x18;
            }
            public static partial class FeSphereRigid_t {
                public const long nNode = 0x10;
                public const long nFlags = 0x16;
                public const long vSphere = 0x0;
                public const long nCollisionMask = 0x12;
                public const long nVertexMapIndex = 0x14;
            }
            public static partial class RnBlendVertex_t {
                public const long m_nFlags = 0xC;
                public const long m_nIndex0 = 0x2;
                public const long m_nIndex1 = 0x6;
                public const long m_nIndex2 = 0xA;
                public const long m_nWeight0 = 0x0;
                public const long m_nWeight1 = 0x4;
                public const long m_nWeight2 = 0x8;
                public const long m_nTargetIndex = 0xE;
            }
            public static partial class RnCapsuleDesc_t {
                public const long m_Capsule = 0x18;
            }
            public static partial class VPhysEntityId_t {
                public const long m_Id = 0x0;
            }
            public static partial class FeCtrlOsOffset_t {
                public const long nCtrlChild = 0x2;
                public const long nCtrlParent = 0x0;
            }
            public static partial class FeFitInfluence_t {
                public const long flWeight = 0x4;
                public const long nMatrixNode = 0x8;
                public const long nVertexNode = 0x0;
            }
            public static partial class FeKelagerBend2_t {
                public const long nNode = 0x10;
                public const long flWeight = 0x0;
                public const long flHeight0 = 0xC;
                public const long nReserved = 0x16;
            }
            public static partial class FeNodeStrayBox_t {
                public const long vMax = 0x10;
                public const long vMin = 0x0;
                public const long nNode = 0x1C;
                public const long nFlags = 0xC;
            }
            public static partial class FeNodeWindBase_t {
                public const long nNodeX0 = 0x0;
                public const long nNodeX1 = 0x2;
                public const long nNodeY0 = 0x4;
                public const long nNodeY1 = 0x6;
            }
            public static partial class FeSimdNodeBase_t {
                public const long nNode = 0x0;
                public const long nDummy = 0x28;
                public const long nNodeX0 = 0x8;
                public const long nNodeX1 = 0x10;
                public const long nNodeY0 = 0x18;
                public const long nNodeY1 = 0x20;
                public const long qAdjust = 0x30;
            }
            public static partial class FeTreeChildren_t {
                public const long nChild = 0x0;
            }
            public static partial class FeWeightedNode_t {
                public const long nNode = 0x0;
                public const long nWeight = 0x2;
            }
            public static partial class FourCovMatrices3 {
                public const long m_flXY = 0x30;
                public const long m_flXZ = 0x40;
                public const long m_flYZ = 0x50;
                public const long m_vDiag = 0x0;
            }
            public static partial class IPhysicsBodyList {

            }
            public static partial class RnCompoundDesc_t {
                public const long m_Compound = 0x18;
            }
            public static partial class RnCompoundTree_t {
                public const long m_Nodes = 0x0;
                public const long m_nStartIterationIndex = 0x10;
            }
            public static partial class FeAxialEdgeBend_t {
                public const long te = 0x0;
                public const long tv = 0x4;
                public const long nNode = 0x1C;
                public const long flDist = 0x8;
                public const long flWeight = 0xC;
            }
            public static partial class FeBandBendLimit_t {
                public const long nNode = 0x8;
                public const long flDistMax = 0x4;
                public const long flDistMin = 0x0;
            }
            public static partial class FeBoneMergeLink_t {
                public const long m_nChildNode = 0x4;
                public const long m_nParentHash = 0x0;
            }
            public static partial class FeBuildBoxRigid_t {
                public const long m_nPriority = 0x40;
                public const long m_nVertexMapHash = 0x44;
                public const long m_nAntitunnelGroupBits = 0x48;
            }
            public static partial class FeBuildSDFRigid_t {
                public const long m_nPriority = 0x50;
                public const long m_nVertexMapHash = 0x54;
                public const long m_nAntitunnelGroupBits = 0x58;
            }
            public static partial class FeRodConstraint_t {
                public const long nNode = 0x0;
                public const long flMaxDist = 0x4;
                public const long flMinDist = 0x8;
                public const long flWeight0 = 0xC;
                public const long flRelaxationFactor = 0x10;
            }
            public static partial class FeVertexMapDesc_t {
                public const long sName = 0x0;
                public const long nColor = 0xC;
                public const long nFlags = 0x10;
                public const long nNameHash = 0x8;
                public const long nMapOffset = 0x18;
                public const long nVertexBase = 0x14;
                public const long nVertexCount = 0x16;
                public const long vCenterOfMass = 0x20;
                public const long nNodeListCount = 0x32;
                public const long nNodeListOffset = 0x1C;
                public const long nScaleSourceNode = 0x30;
                public const long flVolumetricSolveStrength = 0x2C;
            }
            public static partial class PhysFeModelDesc_t {
                public const long m_Rods = 0x168;
                public const long m_Tris = 0x558;
                public const long m_Quads = 0xA8;
                public const long m_Ropes = 0x60;
                public const long m_Prisms = 0xF0;
                public const long m_Twists = 0x180;
                public const long m_Effects = 0x650;
                public const long m_CtrlHash = 0x0;
                public const long m_CtrlName = 0x18;
                public const long m_InitPose = 0x150;
                public const long m_SimdRods = 0x120;
                public const long m_SimdTris = 0xD8;
                public const long m_BoxRigids = 0x590;
                public const long m_FreeNodes = 0x450;
                public const long m_NodeBases = 0x78;
                public const long m_SDFRigids = 0x578;
                public const long m_SimdQuads = 0xC0;
                public const long m_flWindage = 0x6E8;
                public const long m_AxialEdges = 0x240;
                public const long m_FitWeights = 0x480;
                public const long m_LocalForce = 0x390;
                public const long m_LockToGoal = 0x680;
                public const long m_SimdPrisms = 0x108;
                public const long m_VertexMaps = 0x620;
                public const long m_flWindDrag = 0x6EC;
                public const long m_nNodeCount = 0x40;
                public const long m_nRopeCount = 0x58;
                public const long m_nTreeDepth = 0x54;
                public const long m_nTriCount1 = 0x570;
                public const long m_nTriCount2 = 0x572;
                public const long m_CtrlOffsets = 0x270;
                public const long m_DynKinLinks = 0x1C8;
                public const long m_FitMatrices = 0x468;
                public const long m_FollowNodes = 0x2A0;
                public const long m_HingeLimits = 0x198;
                public const long m_JiggleBones = 0x510;
                public const long m_MorphLayers = 0x5F0;
                public const long m_SkelParents = 0x698;
                public const long m_SourceElems = 0x528;
                public const long m_TreeParents = 0x408;
                public const long m_nQuadCount1 = 0x50;
                public const long m_nQuadCount2 = 0x52;
                public const long m_KelagerBends = 0x4E0;
                public const long m_LockToParent = 0x668;
                public const long m_MorphSetData = 0x608;
                public const long m_SimdRodsAnim = 0x138;
                public const long m_SphereRigids = 0x3D8;
                public const long m_TreeChildren = 0x438;
                public const long m_flLocalDrag1 = 0x720;
                public const long m_flLocalForce = 0x38;
                public const long m_nStaticNodes = 0x42;
                public const long m_CtrlOsOffsets = 0x288;
                public const long m_LocalRotation = 0x378;
                public const long m_NodeInvMasses = 0x258;
                public const long m_SimdNodeBases = 0x90;
                public const long m_AnimStrayRadii = 0x4B0;
                public const long m_BoneMergeLinks = 0x1E0;
                public const long m_NodeIntegrator = 0x2D0;
                public const long m_NodeStrayBoxes = 0x228;
                public const long m_ReverseOffsets = 0x498;
                public const long m_VertexSetNames = 0x5C0;
                public const long m_nReservedUint8 = 0x574;
                public const long m_nSimdTriCount1 = 0x48;
                public const long m_nSimdTriCount2 = 0x4A;
                public const long m_CollisionPlanes = 0x2B8;
                public const long m_CtrlSoftOffsets = 0x4F8;
                public const long m_DynNodeFriction = 0x360;
                public const long m_VertexMapValues = 0x638;
                public const long m_flLocalRotation = 0x3C;
                public const long m_nSimdQuadCount1 = 0x4C;
                public const long m_nSimdQuadCount2 = 0x4E;
                public const long m_AntiTunnelProbes = 0x1F8;
                public const long m_DynNodeVertexSet = 0x5A8;
                public const long m_DynNodeWindBases = 0x6B0;
                public const long m_SpringIntegrator = 0x2E8;
                public const long m_nExtraIterations = 0x577;
                public const long m_nStaticNodeFlags = 0x30;
                public const long m_flMotionSmoothCDT = 0x71C;
                public const long m_nDynamicNodeFlags = 0x34;
                public const long m_AntiTunnelBytecode = 0x1B0;
                public const long m_LegacyStretchForce = 0x330;
                public const long m_NodeCollisionRadii = 0x348;
                public const long m_SimdAnimStrayRadii = 0x4C8;
                public const long m_TreeCollisionMasks = 0x420;
                public const long m_flInternalPressure = 0x6E0;
                public const long m_SelfCollisionLayers = 0x6C8;
                public const long m_WorldCollisionNodes = 0x3F0;
                public const long m_flDefaultExpAirDrag = 0x700;
                public const long m_flDefaultVelAirDrag = 0x6FC;
                public const long m_nRotLockStaticNodes = 0x44;
                public const long m_SimdSpringIntegrator = 0x300;
                public const long m_TaperedCapsuleRigids = 0x3C0;
                public const long m_WorldCollisionParams = 0x318;
                public const long m_nExtraGoalIterations = 0x576;
                public const long m_AntiTunnelTargetNodes = 0x210;
                public const long m_flDefaultGravityScale = 0x6F8;
                public const long m_flDefaultTimeDilation = 0x6E4;
                public const long m_flDefaultThreadStretch = 0x6F4;
                public const long m_RigidColliderPriorities = 0x5D8;
                public const long m_TaperedCapsuleStretches = 0x3A8;
                public const long m_flDefaultExpQuadAirDrag = 0x708;
                public const long m_flDefaultSurfaceStretch = 0x6F0;
                public const long m_flDefaultVelQuadAirDrag = 0x704;
                public const long m_flRodVelocitySmoothRate = 0x70C;
                public const long m_flQuadVelocitySmoothRate = 0x710;
                public const long m_nExtraPressureIterations = 0x575;
                public const long m_nFirstPositionDrivenNode = 0x46;
                public const long m_flAddWorldCollisionRadius = 0x714;
                public const long m_GoalDampedSpringIntegrators = 0x540;
                public const long m_nRodVelocitySmoothIterations = 0x724;
                public const long m_nQuadVelocitySmoothIterations = 0x726;
                public const long m_flDefaultVolumetricSolveAmount = 0x718;
                public const long m_nNodeBaseJiggleboneDependsCount = 0x56;
            }
            public static partial class CFeNamedJiggleBone {
                public const long m_transform = 0x10;
                public const long m_jiggleBone = 0x34;
                public const long m_nJiggleParent = 0x30;
                public const long m_strParentBone = 0x0;
            }
            public static partial class CGenericShapeProxy {
                public const long m_verts = 0x30;
            }
            public static partial class FeCollisionPlane_t {
                public const long m_Plane = 0x4;
                public const long flStrength = 0x14;
                public const long nChildNode = 0x2;
                public const long nCtrlParent = 0x0;
            }
            public static partial class FeCtrlSoftOffset_t {
                public const long flAlpha = 0x10;
                public const long vOffset = 0x4;
                public const long nCtrlChild = 0x2;
                public const long nCtrlParent = 0x0;
            }
            public static partial class FeMorphLayerDepr_t {
                public const long m_Name = 0x0;
                public const long m_Nodes = 0x10;
                public const long m_nFlags = 0x88;
                public const long m_Gravity = 0x40;
                public const long m_InitPos = 0x28;
                public const long m_nNameHash = 0x8;
                public const long m_GoalDamping = 0x70;
                public const long m_GoalStrength = 0x58;
            }
            public static partial class FeNodeIntegrator_t {
                public const long flGravity = 0xC;
                public const long flPointDamping = 0x0;
                public const long flAnimationForceAttraction = 0x4;
                public const long flAnimationVertexAttraction = 0x8;
            }
            public static partial class FeProxyVertexMap_t {
                public const long m_Name = 0x0;
                public const long m_flWeight = 0x8;
            }
            public static partial class FeVertexMapBuild_t {
                public const long m_Color = 0xC;
                public const long m_Weights = 0x18;
                public const long m_nNameHash = 0x8;
                public const long m_VertexMapName = 0x0;
                public const long m_nScaleSourceNode = 0x14;
                public const long m_flVolumetricSolveStrength = 0x10;
            }
            public static partial class RnSoftbodySpring_t {
                public const long m_flLength = 0x4;
                public const long m_nParticle = 0x0;
            }
            public static partial class FeAnimStrayRadius_t {
                public const long nNode = 0x0;
                public const long flMaxDist = 0x4;
                public const long flRelaxationFactor = 0x8;
            }
            public static partial class FeAntiTunnelProbe_t {
                public const long flBias = 0x18;
                public const long nBegin = 0xC;
                public const long nCount = 0xA;
                public const long nFlags = 0x4;
                public const long flWeight = 0x0;
                public const long nProbeNode = 0x8;
                public const long flCurvatureRadius = 0x14;
                public const long flActivationDistance = 0x10;
            }
            public static partial class FeHingeLimitBuild_t {
                public const long nNode = 0x0;
                public const long nFlags = 0xC;
                public const long flLimitCW = 0x10;
                public const long flLimitCCW = 0x14;
            }
            public static partial class FeStiffHingeBuild_t {
                public const long nNode = 0x14;
                public const long flMaxAngle = 0x0;
                public const long flStrength = 0x4;
                public const long flMotionBias = 0x8;
            }
            public static partial class FeTwistConstraint_t {
                public const long nNodeEnd = 0x2;
                public const long nNodeOrient = 0x0;
                public const long flSwingRelax = 0x8;
                public const long flTwistRelax = 0x4;
            }
            public static partial class PhysicsParticleId_t {
                public const long m_Value = 0x0;
            }
            public static partial class RnSoftbodyCapsule_t {
                public const long m_vCenter = 0x0;
                public const long m_flRadius = 0x18;
                public const long m_nParticle = 0x1C;
            }
            public static partial class CFeIndexedJiggleBone {
                public const long m_nNode = 0x0;
                public const long m_jiggleBone = 0x8;
                public const long m_nJiggleParent = 0x4;
            }
            public static partial class FeBuildSphereRigid_t {
                public const long m_nPriority = 0x20;
                public const long m_nVertexMapHash = 0x24;
                public const long m_nAntitunnelGroupBits = 0x28;
            }
            public static partial class FeSpringIntegrator_t {
                public const long nNode = 0x0;
                public const long flNodeWeight0 = 0x10;
                public const long flSpringDamping = 0xC;
                public const long flSpringConstant = 0x8;
                public const long flSpringRestLength = 0x4;
            }
            public static partial class IPhysicsParticleRope {

            }
            public static partial class RnCompoundTreeNode_t {
                public const long m_vMax = 0xC;
                public const long m_vMin = 0x0;
                public const long m_nType = 0x0;
                public const long m_nSubtreeEndOrCompoundId = 0x0;
            }
            public static partial class RnSoftbodyParticle_t {
                public const long m_flMassInv = 0x0;
            }
            public static partial class FeNodeReverseOffset_t {
                public const long vOffset = 0x0;
                public const long nBoneCtrl = 0xC;
                public const long nTargetNode = 0xE;
            }
            public static partial class FeSimdRodConstraint_t {
                public const long nNode = 0x0;
                public const long f4MaxDist = 0x10;
                public const long f4MinDist = 0x20;
                public const long f4Weight0 = 0x30;
                public const long f4RelaxationFactor = 0x40;
            }
            public static partial class VertexPositionColor_t {
                public const long m_vPosition = 0x0;
            }
            public static partial class CFeVertexMapBuildArray {
                public const long m_Array = 0x0;
            }
            public static partial class IPhysAggregateInstance {
                public const long m_pSkeleton = 0x8;
                public const long m_bIsAxisAligned = 0x10;
            }
            public static partial class IPhysicsRagdollControl {

            }
            public static partial class VertexPositionNormal_t {
                public const long m_vNormal = 0xC;
                public const long m_vPosition = 0x0;
            }
            public static partial class constraint_axislimit_t {
                public const long flMaxRotation = 0x4;
                public const long flMinRotation = 0x0;
                public const long flMotorMaxTorque = 0xC;
                public const long flMotorTargetAngSpeed = 0x8;
            }
            public static partial class FeSimdAnimStrayRadius_t {
                public const long nNode = 0x0;
                public const long flMaxDist = 0x10;
                public const long flRelaxationFactor = 0x20;
            }
            public static partial class FeTaperedCapsuleRigid_t {
                public const long nNode = 0x20;
                public const long nFlags = 0x26;
                public const long vSphere = 0x0;
                public const long nCollisionMask = 0x22;
                public const long nVertexMapIndex = 0x24;
            }
            public static partial class FeAntiTunnelGroupBuild_t {
                public const long m_nCollisionMask = 0x4;
                public const long m_nVertexMapHash = 0x0;
            }
            public static partial class FeAntiTunnelProbeBuild_t {
                public const long flBias = 0x8;
                public const long nFlags = 0x10;
                public const long flWeight = 0x0;
                public const long nProbeNode = 0x14;
                public const long flCurvature = 0xC;
                public const long targetNodes = 0x18;
                public const long flActivationDistance = 0x4;
            }
            public static partial class FeRigidColliderIndices_t {
                public const long m_nBoxRigidIndex = 0x4;
                public const long m_nSDFRigidIndex = 0x6;
                public const long m_nSphereRigidIndex = 0x2;
                public const long m_nCollisionPlaneIndex = 0x8;
                public const long m_nTaperedCapsuleRigidIndex = 0x0;
            }
            public static partial class FeSimdSpringIntegrator_t {
                public const long nNode = 0x0;
                public const long flNodeWeight0 = 0x40;
                public const long flSpringDamping = 0x30;
                public const long flSpringConstant = 0x20;
                public const long flSpringRestLength = 0x10;
            }
            public static partial class FeWorldCollisionParams_t {
                public const long nListEnd = 0xA;
                public const long nListBegin = 0x8;
                public const long flWorldFriction = 0x0;
                public const long flGroundFriction = 0x4;
            }
            public static partial class IPhysicsMotionController {

            }
            public static partial class IPhysicsPlayerController {

            }
            public static partial class constraint_hingeparams_t {
                public const long hingeAxis = 0x18;
                public const long constraint = 0x28;
                public const long worldPosition = 0x0;
                public const long worldAxisDirection = 0xC;
            }
            public static partial class FeSimdRodConstraintAnim_t {
                public const long nNode = 0x0;
                public const long f4Weight0 = 0x10;
                public const long f4RelaxationFactor = 0x20;
            }
            public static partial class FeTaperedCapsuleStretch_t {
                public const long nNode = 0x0;
                public const long nDummy = 0x6;
                public const long flRadius = 0x8;
                public const long nCollisionMask = 0x4;
            }
            public static partial class CollisionDetailLayerInfo_t {
                public const long m_bIsQueryOnly = 0x10;
                public const long m_bNotPickable = 0x38;
                public const long m_sDescription = 0x0;
                public const long m_sFriendlyName = 0x8;
                public const long m_sParentDetailLayer = 0x18;
                public const long m_vecSubtreeDetailLayers = 0x20;
            }
            public static partial class FeModelSelfCollisionLayer_t {
                public const long m_Name = 0x0;
                public const long m_Nodes = 0x8;
                public const long m_nFlags = 0x24;
                public const long m_nEndIdx = 0x28;
                public const long m_flParentReaction = 0x20;
            }
            public static partial class FeBuildTaperedCapsuleRigid_t {
                public const long m_nPriority = 0x30;
                public const long m_nVertexMapHash = 0x34;
                public const long m_nAntitunnelGroupBits = 0x38;
            }
            public static partial class constraint_breakableparams_t {
                public const long isActive = 0x14;
                public const long strength = 0x0;
                public const long forceLimit = 0x4;
                public const long torqueLimit = 0x8;
                public const long bodyMassScale = 0xC;
            }
            public static partial class vphysics_save_cphysicsbody_t {
                public const long m_nOldPointer = 0xE0;
            }
            public static partial class vphysics_save_ragdoll_control_t {
                public const long m_nBodyCount = 0x34;
                public const long m_flMaxStretch = 0x8;
                public const long m_bIgnoreTeleport = 0xE;
                public const long m_vForceAccumulator = 0x28;
                public const long m_flMaxSpringFrequency = 0x4;
                public const long m_flMinSpringFrequency = 0x0;
                public const long m_bRequiresDynamicBodies = 0xD;
                public const long m_vLinearVelocityAccumulator = 0x10;
                public const long m_bSolidCollisionAtZeroWeight = 0xC;
                public const long m_vAngularVelocityAccumulator = 0x1C;
            }
            public static partial class CollisionDetailLayerInfo_t__Name_t {
                public const long m_nNameToken = 0x0;
                public const long m_sNameString = 0x8;
            }
            public static partial class JointAxis_t {
                public const long JOINT_AXIS_X = 0x0;
                public const long JOINT_AXIS_Y = 0x1;
                public const long JOINT_AXIS_Z = 0x2;
                public const long JOINT_AXIS_COUNT = 0x3;
            }
            public static partial class JointMotion_t {
                public const long JOINT_MOTION_FREE = 0x0;
                public const long JOINT_MOTION_COUNT = 0x2;
                public const long JOINT_MOTION_LOCKED = 0x1;
            }
            public static partial class PhysInterfaceId_t {
                public const long PIID_UNKNOWN = 0x0;
                public const long PIID_NUM_TYPES = 0x7;
                public const long PIID_IPHYSICSBODY = 0x1;
                public const long PIID_IPHYSICSJOINT = 0x3;
                public const long PIID_IPHYSAGGREGATE = 0x2;
                public const long PIID_IPHYSICSPARTICLEROPE = 0x5;
                public const long PIID_IPHYSICSRAGDOLLCONTROL = 0x6;
                public const long PIID_IPHYSICSMOTIONCONTROLLER = 0x4;
            }
            public static partial class PhysGenericShapeType_t {
                public const long GENERIC_SHAPE_AABB = 0x2;
                public const long GENERIC_SHAPE_HULL = 0x4;
                public const long GENERIC_SHAPE_POINT = 0x0;
                public const long GENERIC_SHAPE_SPHERE = 0x1;
                public const long GENERIC_SHAPE_CAPSULE = 0x3;
            }
            public static partial class DynamicContinuousContactBehavior_t {
                public const long DYNAMIC_CONTINUOUS_NEVER = 0x2;
                public const long DYNAMIC_CONTINUOUS_ALWAYS = 0x1;
                public const long DYNAMIC_CONTINUOUS_ALLOW_IF_REQUESTED_BY_OTHER_BODY = 0x0;
            }
        }
    }
}
