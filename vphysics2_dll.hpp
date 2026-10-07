#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace schemas {
        namespace vphysics2_dll {
            namespace Dop26_t {
                inline constexpr std::ptrdiff_t m_flSupport = 0x0;
            }
            namespace FeTri_t {
                inline constexpr std::ptrdiff_t v2 = 0x14;
                inline constexpr std::ptrdiff_t w1 = 0x8;
                inline constexpr std::ptrdiff_t w2 = 0xC;
                inline constexpr std::ptrdiff_t v1x = 0x10;
                inline constexpr std::ptrdiff_t nNode = 0x0;
            }
            namespace FeQuad_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t vShape = 0xC;
                inline constexpr std::ptrdiff_t flSlack = 0x8;
            }
            namespace RnFace_t {
                inline constexpr std::ptrdiff_t m_nEdge = 0x0;
            }
            namespace RnHull_t {
                inline constexpr std::ptrdiff_t m_Edges = 0xC8;
                inline constexpr std::ptrdiff_t m_Faces = 0xE0;
                inline constexpr std::ptrdiff_t m_Bounds = 0x14;
                inline constexpr std::ptrdiff_t m_nFlags = 0xA0;
                inline constexpr std::ptrdiff_t m_Vertices = 0xB0;
                inline constexpr std::ptrdiff_t m_flVolume = 0x68;
                inline constexpr std::ptrdiff_t m_vCentroid = 0x0;
                inline constexpr std::ptrdiff_t m_FacePlanes = 0x88;
                inline constexpr std::ptrdiff_t m_pRegionSVM = 0xA8;
                inline constexpr std::ptrdiff_t m_flSurfaceArea = 0x6C;
                inline constexpr std::ptrdiff_t m_MassProperties = 0x38;
                inline constexpr std::ptrdiff_t m_VertexPositions = 0x70;
                inline constexpr std::ptrdiff_t m_flMaxAngularRadius = 0xC;
                inline constexpr std::ptrdiff_t m_vOrthographicAreas = 0x2C;
                inline constexpr std::ptrdiff_t m_flMinCentroidRadius = 0x10;
            }
            namespace RnMesh_t {
                inline constexpr std::ptrdiff_t m_vMax = 0xC;
                inline constexpr std::ptrdiff_t m_vMin = 0x0;
                inline constexpr std::ptrdiff_t m_Nodes = 0x18;
                inline constexpr std::ptrdiff_t m_Wings = 0x60;
                inline constexpr std::ptrdiff_t m_nFlags = 0xB4;
                inline constexpr std::ptrdiff_t m_Vertices = 0x30;
                inline constexpr std::ptrdiff_t m_Materials = 0x90;
                inline constexpr std::ptrdiff_t m_Triangles = 0x48;
                inline constexpr std::ptrdiff_t m_nDebugFlags = 0xB8;
                inline constexpr std::ptrdiff_t m_flSurfaceArea = 0xBC;
                inline constexpr std::ptrdiff_t m_TriangleEdgeFlags = 0x78;
                inline constexpr std::ptrdiff_t m_vOrthographicAreas = 0xA8;
            }
            namespace RnNode_t {
                inline constexpr std::ptrdiff_t m_vMax = 0x10;
                inline constexpr std::ptrdiff_t m_vMin = 0x0;
                inline constexpr std::ptrdiff_t m_nChildren = 0xC;
                inline constexpr std::ptrdiff_t m_nTriangleOffset = 0x1C;
            }
            namespace RnWing_t {
                inline constexpr std::ptrdiff_t m_nIndex = 0x0;
            }
            namespace FePrism_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t flVolume = 0xC;
            }
            namespace RnPlane_t {
                inline constexpr std::ptrdiff_t m_vNormal = 0x0;
                inline constexpr std::ptrdiff_t m_flOffset = 0xC;
            }
            namespace CRegionSVM {
                inline constexpr std::ptrdiff_t m_Nodes = 0x18;
                inline constexpr std::ptrdiff_t m_Planes = 0x0;
            }
            namespace CovMatrix3 {
                inline constexpr std::ptrdiff_t m_flXY = 0xC;
                inline constexpr std::ptrdiff_t m_flXZ = 0x10;
                inline constexpr std::ptrdiff_t m_flYZ = 0x14;
                inline constexpr std::ptrdiff_t m_vDiag = 0x0;
            }
            namespace RnVertex_t {
                inline constexpr std::ptrdiff_t m_nEdge = 0x0;
            }
            namespace FeSimdTri_t {
                inline constexpr std::ptrdiff_t v2 = 0x60;
                inline constexpr std::ptrdiff_t w1 = 0x30;
                inline constexpr std::ptrdiff_t w2 = 0x40;
                inline constexpr std::ptrdiff_t v1x = 0x50;
                inline constexpr std::ptrdiff_t nNode = 0x0;
            }
            namespace OldFeEdge_t {
                inline constexpr std::ptrdiff_t t = 0x10;
                inline constexpr std::ptrdiff_t c01 = 0x1C;
                inline constexpr std::ptrdiff_t c02 = 0x20;
                inline constexpr std::ptrdiff_t c03 = 0x24;
                inline constexpr std::ptrdiff_t c04 = 0x28;
                inline constexpr std::ptrdiff_t invA = 0xC;
                inline constexpr std::ptrdiff_t m_flK = 0x0;
                inline constexpr std::ptrdiff_t m_nNode = 0x40;
                inline constexpr std::ptrdiff_t flThetaFactor = 0x18;
                inline constexpr std::ptrdiff_t flThetaRelaxed = 0x14;
                inline constexpr std::ptrdiff_t flAxialModelDist = 0x2C;
                inline constexpr std::ptrdiff_t flAxialModelWeights = 0x30;
            }
            namespace RnCapsule_t {
                inline constexpr std::ptrdiff_t m_vCenter = 0x0;
                inline constexpr std::ptrdiff_t m_flRadius = 0x18;
            }
            namespace FeBoxRigid_t {
                inline constexpr std::ptrdiff_t nNode = 0x20;
                inline constexpr std::ptrdiff_t vSize = 0x24;
                inline constexpr std::ptrdiff_t nFlags = 0x32;
                inline constexpr std::ptrdiff_t tmFrame2 = 0x0;
                inline constexpr std::ptrdiff_t nCollisionMask = 0x22;
                inline constexpr std::ptrdiff_t nVertexMapIndex = 0x30;
            }
            namespace FeEdgeDesc_t {
                inline constexpr std::ptrdiff_t nEdge = 0x0;
                inline constexpr std::ptrdiff_t nSide = 0x4;
                inline constexpr std::ptrdiff_t nVirtElem = 0xC;
            }
            namespace FeNodeBase_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t nDummy = 0x2;
                inline constexpr std::ptrdiff_t nNodeX0 = 0x8;
                inline constexpr std::ptrdiff_t nNodeX1 = 0xA;
                inline constexpr std::ptrdiff_t nNodeY0 = 0xC;
                inline constexpr std::ptrdiff_t nNodeY1 = 0xE;
                inline constexpr std::ptrdiff_t qAdjust = 0x10;
            }
            namespace FeSDFRigid_t {
                inline constexpr std::ptrdiff_t nNode = 0x1C;
                inline constexpr std::ptrdiff_t nFlags = 0x22;
                inline constexpr std::ptrdiff_t m_nDepth = 0x48;
                inline constexpr std::ptrdiff_t m_nWidth = 0x40;
                inline constexpr std::ptrdiff_t m_nHeight = 0x44;
                inline constexpr std::ptrdiff_t vLocalMax = 0xC;
                inline constexpr std::ptrdiff_t vLocalMin = 0x0;
                inline constexpr std::ptrdiff_t m_Distances = 0x28;
                inline constexpr std::ptrdiff_t flBounciness = 0x18;
                inline constexpr std::ptrdiff_t nCollisionMask = 0x1E;
                inline constexpr std::ptrdiff_t nVertexMapIndex = 0x20;
            }
            namespace FeSimdQuad_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t vShape = 0x30;
                inline constexpr std::ptrdiff_t f4Slack = 0x20;
                inline constexpr std::ptrdiff_t f4Weights = 0xF0;
            }
            namespace IPhysicsBody {

            }
            namespace RnBodyDesc_t {
                inline constexpr std::ptrdiff_t m_bEnabled = 0xC7;
                inline constexpr std::ptrdiff_t m_vGravity = 0xCC;
                inline constexpr std::ptrdiff_t m_bSleeping = 0xC8;
                inline constexpr std::ptrdiff_t m_flMassInv = 0x6C;
                inline constexpr std::ptrdiff_t m_nBodyType = 0xB8;
                inline constexpr std::ptrdiff_t m_vPosition = 0x8;
                inline constexpr std::ptrdiff_t m_flGameMass = 0x70;
                inline constexpr std::ptrdiff_t m_nGameFlags = 0xC0;
                inline constexpr std::ptrdiff_t m_nGameIndex = 0xBC;
                inline constexpr std::ptrdiff_t m_sDebugName = 0x0;
                inline constexpr std::ptrdiff_t m_flTimeScale = 0xB4;
                inline constexpr std::ptrdiff_t m_bDragEnabled = 0xCA;
                inline constexpr std::ptrdiff_t m_qOrientation = 0x14;
                inline constexpr std::ptrdiff_t m_nMassPriority = 0xC6;
                inline constexpr std::ptrdiff_t m_flGravityScale = 0xB0;
                inline constexpr std::ptrdiff_t m_flMassScaleInv = 0x74;
                inline constexpr std::ptrdiff_t m_LocalInertiaInv = 0x48;
                inline constexpr std::ptrdiff_t m_flBuoyancyScale = 0xAC;
                inline constexpr std::ptrdiff_t m_flLinearDamping = 0x7C;
                inline constexpr std::ptrdiff_t m_vLinearVelocity = 0x24;
                inline constexpr std::ptrdiff_t m_flAngularDamping = 0x80;
                inline constexpr std::ptrdiff_t m_vAngularVelocity = 0x30;
                inline constexpr std::ptrdiff_t m_vLocalMassCenter = 0x3C;
                inline constexpr std::ptrdiff_t m_flInertiaScaleInv = 0x78;
                inline constexpr std::ptrdiff_t m_flLinearDragScale = 0x84;
                inline constexpr std::ptrdiff_t m_flAngularDragScale = 0x88;
                inline constexpr std::ptrdiff_t m_bSpeculativeEnabled = 0xD8;
                inline constexpr std::ptrdiff_t m_bHasShadowController = 0xD9;
                inline constexpr std::ptrdiff_t m_bIsContinuousEnabled = 0xC9;
                inline constexpr std::ptrdiff_t m_vLastAwakeForceAccum = 0x94;
                inline constexpr std::ptrdiff_t m_vLastAwakeTorqueAccum = 0xA0;
                inline constexpr std::ptrdiff_t m_flLinearFluidDragScale = 0x8C;
                inline constexpr std::ptrdiff_t m_nMinPositionIterations = 0xC5;
                inline constexpr std::ptrdiff_t m_nMinVelocityIterations = 0xC4;
                inline constexpr std::ptrdiff_t m_flAngularFluidDragScale = 0x90;
                inline constexpr std::ptrdiff_t m_nDynamicContinuousContactBehavior = 0xDA;
            }
            namespace RnCompound_t {
                inline constexpr std::ptrdiff_t m_Tree = 0x0;
                inline constexpr std::ptrdiff_t m_Hulls = 0xF0;
                inline constexpr std::ptrdiff_t m_Bounds = 0x130;
                inline constexpr std::ptrdiff_t m_Meshes = 0x28;
                inline constexpr std::ptrdiff_t m_Spheres = 0x110;
                inline constexpr std::ptrdiff_t m_Capsules = 0x100;
                inline constexpr std::ptrdiff_t m_flVolume = 0x158;
                inline constexpr std::ptrdiff_t m_nShapeCount = 0x20;
                inline constexpr std::ptrdiff_t m_flSurfaceArea = 0x154;
                inline constexpr std::ptrdiff_t m_nHullBaseIndex = 0x18;
                inline constexpr std::ptrdiff_t m_nMeshBaseIndex = 0x1C;
                inline constexpr std::ptrdiff_t m_vOrthographicAreas = 0x148;
                inline constexpr std::ptrdiff_t m_CompoundMaterialIndices = 0x120;
            }
            namespace RnHalfEdge_t {
                inline constexpr std::ptrdiff_t m_nFace = 0x3;
                inline constexpr std::ptrdiff_t m_nNext = 0x0;
                inline constexpr std::ptrdiff_t m_nTwin = 0x1;
                inline constexpr std::ptrdiff_t m_nOrigin = 0x2;
            }
            namespace RnHullDesc_t {
                inline constexpr std::ptrdiff_t m_Hull = 0x18;
            }
            namespace RnMeshDesc_t {
                inline constexpr std::ptrdiff_t m_Mesh = 0x18;
            }
            namespace RnTriangle_t {
                inline constexpr std::ptrdiff_t m_nIndex = 0x0;
            }
            namespace CFeJiggleBone {
                inline constexpr std::ptrdiff_t m_nFlags = 0x0;
                inline constexpr std::ptrdiff_t m_vPoint0 = 0x80;
                inline constexpr std::ptrdiff_t m_vPoint1 = 0x8C;
                inline constexpr std::ptrdiff_t m_flLength = 0x4;
                inline constexpr std::ptrdiff_t m_flMaxYaw = 0x2C;
                inline constexpr std::ptrdiff_t m_flMinYaw = 0x28;
                inline constexpr std::ptrdiff_t m_flRadius0 = 0x78;
                inline constexpr std::ptrdiff_t m_flRadius1 = 0x7C;
                inline constexpr std::ptrdiff_t m_flTipMass = 0x8;
                inline constexpr std::ptrdiff_t m_flBaseMass = 0x48;
                inline constexpr std::ptrdiff_t m_flMaxPitch = 0x3C;
                inline constexpr std::ptrdiff_t m_flMinPitch = 0x38;
                inline constexpr std::ptrdiff_t m_flBaseMaxUp = 0x64;
                inline constexpr std::ptrdiff_t m_flBaseMinUp = 0x60;
                inline constexpr std::ptrdiff_t m_flYawBounce = 0x34;
                inline constexpr std::ptrdiff_t m_flAngleLimit = 0x24;
                inline constexpr std::ptrdiff_t m_flYawDamping = 0x10;
                inline constexpr std::ptrdiff_t m_flBaseDamping = 0x50;
                inline constexpr std::ptrdiff_t m_flBaseMaxLeft = 0x58;
                inline constexpr std::ptrdiff_t m_flBaseMinLeft = 0x54;
                inline constexpr std::ptrdiff_t m_flPitchBounce = 0x44;
                inline constexpr std::ptrdiff_t m_flYawFriction = 0x30;
                inline constexpr std::ptrdiff_t m_flAlongDamping = 0x20;
                inline constexpr std::ptrdiff_t m_flPitchDamping = 0x18;
                inline constexpr std::ptrdiff_t m_flYawStiffness = 0xC;
                inline constexpr std::ptrdiff_t m_nCollisionMask = 0x98;
                inline constexpr std::ptrdiff_t m_flBaseStiffness = 0x4C;
                inline constexpr std::ptrdiff_t m_flPitchFriction = 0x40;
                inline constexpr std::ptrdiff_t m_flAlongStiffness = 0x1C;
                inline constexpr std::ptrdiff_t m_flBaseMaxForward = 0x70;
                inline constexpr std::ptrdiff_t m_flBaseMinForward = 0x6C;
                inline constexpr std::ptrdiff_t m_flBaseUpFriction = 0x68;
                inline constexpr std::ptrdiff_t m_flPitchStiffness = 0x14;
                inline constexpr std::ptrdiff_t m_flBaseLeftFriction = 0x5C;
                inline constexpr std::ptrdiff_t m_flBaseForwardFriction = 0x74;
            }
            namespace CFeMorphLayer {
                inline constexpr std::ptrdiff_t m_Name = 0x0;
                inline constexpr std::ptrdiff_t m_Nodes = 0x10;
                inline constexpr std::ptrdiff_t m_Gravity = 0x40;
                inline constexpr std::ptrdiff_t m_InitPos = 0x28;
                inline constexpr std::ptrdiff_t m_nNameHash = 0x8;
                inline constexpr std::ptrdiff_t m_GoalDamping = 0x70;
                inline constexpr std::ptrdiff_t m_GoalStrength = 0x58;
            }
            namespace FeFitMatrix_t {
                inline constexpr std::ptrdiff_t bone = 0x0;
                inline constexpr std::ptrdiff_t nEnd = 0x2C;
                inline constexpr std::ptrdiff_t nNode = 0x2E;
                inline constexpr std::ptrdiff_t vCenter = 0x20;
                inline constexpr std::ptrdiff_t nBeginDynamic = 0x30;
            }
            namespace FeFitWeight_t {
                inline constexpr std::ptrdiff_t nNode = 0x4;
                inline constexpr std::ptrdiff_t nDummy = 0x6;
                inline constexpr std::ptrdiff_t flWeight = 0x0;
            }
            namespace FeSimdPrism_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t flVolume = 0x30;
            }
            namespace FourVectors2D {
                inline constexpr std::ptrdiff_t x = 0x0;
                inline constexpr std::ptrdiff_t y = 0x10;
            }
            namespace IPhysicsJoint {

            }
            namespace RnShapeDesc_t {
                inline constexpr std::ptrdiff_t m_UserFriendlyName = 0x8;
                inline constexpr std::ptrdiff_t m_nToolMaterialHash = 0x14;
                inline constexpr std::ptrdiff_t m_bUserFriendlyNameLong = 0x11;
                inline constexpr std::ptrdiff_t m_nSurfacePropertyIndex = 0x4;
                inline constexpr std::ptrdiff_t m_bUserFriendlyNameSealed = 0x10;
                inline constexpr std::ptrdiff_t m_nCollisionAttributeIndex = 0x0;
            }
            namespace FeCtrlOffset_t {
                inline constexpr std::ptrdiff_t vOffset = 0x0;
                inline constexpr std::ptrdiff_t nCtrlChild = 0xE;
                inline constexpr std::ptrdiff_t nCtrlParent = 0xC;
            }
            namespace FeDynKinLink_t {
                inline constexpr std::ptrdiff_t m_nChild = 0x2;
                inline constexpr std::ptrdiff_t m_nParent = 0x0;
            }
            namespace FeEffectDesc_t {
                inline constexpr std::ptrdiff_t nType = 0xC;
                inline constexpr std::ptrdiff_t sName = 0x0;
                inline constexpr std::ptrdiff_t m_Params = 0x10;
                inline constexpr std::ptrdiff_t nNameHash = 0x8;
            }
            namespace FeFollowNode_t {
                inline constexpr std::ptrdiff_t flWeight = 0x4;
                inline constexpr std::ptrdiff_t nChildNode = 0x2;
                inline constexpr std::ptrdiff_t nParentNode = 0x0;
            }
            namespace FeHingeLimit_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t nFlags = 0xC;
                inline constexpr std::ptrdiff_t flWeight4 = 0x10;
                inline constexpr std::ptrdiff_t flWeight5 = 0x14;
                inline constexpr std::ptrdiff_t flAngleCenter = 0x18;
                inline constexpr std::ptrdiff_t flAngleExtents = 0x1C;
            }
            namespace FeSoftParent_t {
                inline constexpr std::ptrdiff_t flAlpha = 0x4;
                inline constexpr std::ptrdiff_t nParent = 0x0;
            }
            namespace FeSourceEdge_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
            }
            namespace RnSphereDesc_t {
                inline constexpr std::ptrdiff_t m_Sphere = 0x18;
            }
            namespace FeSphereRigid_t {
                inline constexpr std::ptrdiff_t nNode = 0x10;
                inline constexpr std::ptrdiff_t nFlags = 0x16;
                inline constexpr std::ptrdiff_t vSphere = 0x0;
                inline constexpr std::ptrdiff_t nCollisionMask = 0x12;
                inline constexpr std::ptrdiff_t nVertexMapIndex = 0x14;
            }
            namespace RnBlendVertex_t {
                inline constexpr std::ptrdiff_t m_nFlags = 0xC;
                inline constexpr std::ptrdiff_t m_nIndex0 = 0x2;
                inline constexpr std::ptrdiff_t m_nIndex1 = 0x6;
                inline constexpr std::ptrdiff_t m_nIndex2 = 0xA;
                inline constexpr std::ptrdiff_t m_nWeight0 = 0x0;
                inline constexpr std::ptrdiff_t m_nWeight1 = 0x4;
                inline constexpr std::ptrdiff_t m_nWeight2 = 0x8;
                inline constexpr std::ptrdiff_t m_nTargetIndex = 0xE;
            }
            namespace RnCapsuleDesc_t {
                inline constexpr std::ptrdiff_t m_Capsule = 0x18;
            }
            namespace VPhysEntityId_t {
                inline constexpr std::ptrdiff_t m_Id = 0x0;
            }
            namespace FeCtrlOsOffset_t {
                inline constexpr std::ptrdiff_t nCtrlChild = 0x2;
                inline constexpr std::ptrdiff_t nCtrlParent = 0x0;
            }
            namespace FeFitInfluence_t {
                inline constexpr std::ptrdiff_t flWeight = 0x4;
                inline constexpr std::ptrdiff_t nMatrixNode = 0x8;
                inline constexpr std::ptrdiff_t nVertexNode = 0x0;
            }
            namespace FeKelagerBend2_t {
                inline constexpr std::ptrdiff_t nNode = 0x10;
                inline constexpr std::ptrdiff_t flWeight = 0x0;
                inline constexpr std::ptrdiff_t flHeight0 = 0xC;
                inline constexpr std::ptrdiff_t nReserved = 0x16;
            }
            namespace FeNodeStrayBox_t {
                inline constexpr std::ptrdiff_t vMax = 0x10;
                inline constexpr std::ptrdiff_t vMin = 0x0;
                inline constexpr std::ptrdiff_t nNode = 0x1C;
                inline constexpr std::ptrdiff_t nFlags = 0xC;
            }
            namespace FeNodeWindBase_t {
                inline constexpr std::ptrdiff_t nNodeX0 = 0x0;
                inline constexpr std::ptrdiff_t nNodeX1 = 0x2;
                inline constexpr std::ptrdiff_t nNodeY0 = 0x4;
                inline constexpr std::ptrdiff_t nNodeY1 = 0x6;
            }
            namespace FeSimdNodeBase_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t nDummy = 0x28;
                inline constexpr std::ptrdiff_t nNodeX0 = 0x8;
                inline constexpr std::ptrdiff_t nNodeX1 = 0x10;
                inline constexpr std::ptrdiff_t nNodeY0 = 0x18;
                inline constexpr std::ptrdiff_t nNodeY1 = 0x20;
                inline constexpr std::ptrdiff_t qAdjust = 0x30;
            }
            namespace FeTreeChildren_t {
                inline constexpr std::ptrdiff_t nChild = 0x0;
            }
            namespace FeWeightedNode_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t nWeight = 0x2;
            }
            namespace FourCovMatrices3 {
                inline constexpr std::ptrdiff_t m_flXY = 0x30;
                inline constexpr std::ptrdiff_t m_flXZ = 0x40;
                inline constexpr std::ptrdiff_t m_flYZ = 0x50;
                inline constexpr std::ptrdiff_t m_vDiag = 0x0;
            }
            namespace IPhysicsBodyList {

            }
            namespace RnCompoundDesc_t {
                inline constexpr std::ptrdiff_t m_Compound = 0x18;
            }
            namespace RnCompoundTree_t {
                inline constexpr std::ptrdiff_t m_Nodes = 0x0;
                inline constexpr std::ptrdiff_t m_nStartIterationIndex = 0x10;
            }
            namespace FeAxialEdgeBend_t {
                inline constexpr std::ptrdiff_t te = 0x0;
                inline constexpr std::ptrdiff_t tv = 0x4;
                inline constexpr std::ptrdiff_t nNode = 0x1C;
                inline constexpr std::ptrdiff_t flDist = 0x8;
                inline constexpr std::ptrdiff_t flWeight = 0xC;
            }
            namespace FeBandBendLimit_t {
                inline constexpr std::ptrdiff_t nNode = 0x8;
                inline constexpr std::ptrdiff_t flDistMax = 0x4;
                inline constexpr std::ptrdiff_t flDistMin = 0x0;
            }
            namespace FeBoneMergeLink_t {
                inline constexpr std::ptrdiff_t m_nChildNode = 0x4;
                inline constexpr std::ptrdiff_t m_nParentHash = 0x0;
            }
            namespace FeBuildBoxRigid_t {
                inline constexpr std::ptrdiff_t m_nPriority = 0x40;
                inline constexpr std::ptrdiff_t m_nVertexMapHash = 0x44;
                inline constexpr std::ptrdiff_t m_nAntitunnelGroupBits = 0x48;
            }
            namespace FeBuildSDFRigid_t {
                inline constexpr std::ptrdiff_t m_nPriority = 0x50;
                inline constexpr std::ptrdiff_t m_nVertexMapHash = 0x54;
                inline constexpr std::ptrdiff_t m_nAntitunnelGroupBits = 0x58;
            }
            namespace FeRodConstraint_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t flMaxDist = 0x4;
                inline constexpr std::ptrdiff_t flMinDist = 0x8;
                inline constexpr std::ptrdiff_t flWeight0 = 0xC;
                inline constexpr std::ptrdiff_t flRelaxationFactor = 0x10;
            }
            namespace FeVertexMapDesc_t {
                inline constexpr std::ptrdiff_t sName = 0x0;
                inline constexpr std::ptrdiff_t nColor = 0xC;
                inline constexpr std::ptrdiff_t nFlags = 0x10;
                inline constexpr std::ptrdiff_t nNameHash = 0x8;
                inline constexpr std::ptrdiff_t nMapOffset = 0x18;
                inline constexpr std::ptrdiff_t nVertexBase = 0x14;
                inline constexpr std::ptrdiff_t nVertexCount = 0x16;
                inline constexpr std::ptrdiff_t vCenterOfMass = 0x20;
                inline constexpr std::ptrdiff_t nNodeListCount = 0x32;
                inline constexpr std::ptrdiff_t nNodeListOffset = 0x1C;
                inline constexpr std::ptrdiff_t nScaleSourceNode = 0x30;
                inline constexpr std::ptrdiff_t flVolumetricSolveStrength = 0x2C;
            }
            namespace PhysFeModelDesc_t {
                inline constexpr std::ptrdiff_t m_Rods = 0x168;
                inline constexpr std::ptrdiff_t m_Tris = 0x558;
                inline constexpr std::ptrdiff_t m_Quads = 0xA8;
                inline constexpr std::ptrdiff_t m_Ropes = 0x60;
                inline constexpr std::ptrdiff_t m_Prisms = 0xF0;
                inline constexpr std::ptrdiff_t m_Twists = 0x180;
                inline constexpr std::ptrdiff_t m_Effects = 0x650;
                inline constexpr std::ptrdiff_t m_CtrlHash = 0x0;
                inline constexpr std::ptrdiff_t m_CtrlName = 0x18;
                inline constexpr std::ptrdiff_t m_InitPose = 0x150;
                inline constexpr std::ptrdiff_t m_SimdRods = 0x120;
                inline constexpr std::ptrdiff_t m_SimdTris = 0xD8;
                inline constexpr std::ptrdiff_t m_BoxRigids = 0x590;
                inline constexpr std::ptrdiff_t m_FreeNodes = 0x450;
                inline constexpr std::ptrdiff_t m_NodeBases = 0x78;
                inline constexpr std::ptrdiff_t m_SDFRigids = 0x578;
                inline constexpr std::ptrdiff_t m_SimdQuads = 0xC0;
                inline constexpr std::ptrdiff_t m_flWindage = 0x6E8;
                inline constexpr std::ptrdiff_t m_AxialEdges = 0x240;
                inline constexpr std::ptrdiff_t m_FitWeights = 0x480;
                inline constexpr std::ptrdiff_t m_LocalForce = 0x390;
                inline constexpr std::ptrdiff_t m_LockToGoal = 0x680;
                inline constexpr std::ptrdiff_t m_SimdPrisms = 0x108;
                inline constexpr std::ptrdiff_t m_VertexMaps = 0x620;
                inline constexpr std::ptrdiff_t m_flWindDrag = 0x6EC;
                inline constexpr std::ptrdiff_t m_nNodeCount = 0x40;
                inline constexpr std::ptrdiff_t m_nRopeCount = 0x58;
                inline constexpr std::ptrdiff_t m_nTreeDepth = 0x54;
                inline constexpr std::ptrdiff_t m_nTriCount1 = 0x570;
                inline constexpr std::ptrdiff_t m_nTriCount2 = 0x572;
                inline constexpr std::ptrdiff_t m_CtrlOffsets = 0x270;
                inline constexpr std::ptrdiff_t m_DynKinLinks = 0x1C8;
                inline constexpr std::ptrdiff_t m_FitMatrices = 0x468;
                inline constexpr std::ptrdiff_t m_FollowNodes = 0x2A0;
                inline constexpr std::ptrdiff_t m_HingeLimits = 0x198;
                inline constexpr std::ptrdiff_t m_JiggleBones = 0x510;
                inline constexpr std::ptrdiff_t m_MorphLayers = 0x5F0;
                inline constexpr std::ptrdiff_t m_SkelParents = 0x698;
                inline constexpr std::ptrdiff_t m_SourceElems = 0x528;
                inline constexpr std::ptrdiff_t m_TreeParents = 0x408;
                inline constexpr std::ptrdiff_t m_nQuadCount1 = 0x50;
                inline constexpr std::ptrdiff_t m_nQuadCount2 = 0x52;
                inline constexpr std::ptrdiff_t m_KelagerBends = 0x4E0;
                inline constexpr std::ptrdiff_t m_LockToParent = 0x668;
                inline constexpr std::ptrdiff_t m_MorphSetData = 0x608;
                inline constexpr std::ptrdiff_t m_SimdRodsAnim = 0x138;
                inline constexpr std::ptrdiff_t m_SphereRigids = 0x3D8;
                inline constexpr std::ptrdiff_t m_TreeChildren = 0x438;
                inline constexpr std::ptrdiff_t m_flLocalDrag1 = 0x720;
                inline constexpr std::ptrdiff_t m_flLocalForce = 0x38;
                inline constexpr std::ptrdiff_t m_nStaticNodes = 0x42;
                inline constexpr std::ptrdiff_t m_CtrlOsOffsets = 0x288;
                inline constexpr std::ptrdiff_t m_LocalRotation = 0x378;
                inline constexpr std::ptrdiff_t m_NodeInvMasses = 0x258;
                inline constexpr std::ptrdiff_t m_SimdNodeBases = 0x90;
                inline constexpr std::ptrdiff_t m_AnimStrayRadii = 0x4B0;
                inline constexpr std::ptrdiff_t m_BoneMergeLinks = 0x1E0;
                inline constexpr std::ptrdiff_t m_NodeIntegrator = 0x2D0;
                inline constexpr std::ptrdiff_t m_NodeStrayBoxes = 0x228;
                inline constexpr std::ptrdiff_t m_ReverseOffsets = 0x498;
                inline constexpr std::ptrdiff_t m_VertexSetNames = 0x5C0;
                inline constexpr std::ptrdiff_t m_nReservedUint8 = 0x574;
                inline constexpr std::ptrdiff_t m_nSimdTriCount1 = 0x48;
                inline constexpr std::ptrdiff_t m_nSimdTriCount2 = 0x4A;
                inline constexpr std::ptrdiff_t m_CollisionPlanes = 0x2B8;
                inline constexpr std::ptrdiff_t m_CtrlSoftOffsets = 0x4F8;
                inline constexpr std::ptrdiff_t m_DynNodeFriction = 0x360;
                inline constexpr std::ptrdiff_t m_VertexMapValues = 0x638;
                inline constexpr std::ptrdiff_t m_flLocalRotation = 0x3C;
                inline constexpr std::ptrdiff_t m_nSimdQuadCount1 = 0x4C;
                inline constexpr std::ptrdiff_t m_nSimdQuadCount2 = 0x4E;
                inline constexpr std::ptrdiff_t m_AntiTunnelProbes = 0x1F8;
                inline constexpr std::ptrdiff_t m_DynNodeVertexSet = 0x5A8;
                inline constexpr std::ptrdiff_t m_DynNodeWindBases = 0x6B0;
                inline constexpr std::ptrdiff_t m_SpringIntegrator = 0x2E8;
                inline constexpr std::ptrdiff_t m_nExtraIterations = 0x577;
                inline constexpr std::ptrdiff_t m_nStaticNodeFlags = 0x30;
                inline constexpr std::ptrdiff_t m_flMotionSmoothCDT = 0x71C;
                inline constexpr std::ptrdiff_t m_nDynamicNodeFlags = 0x34;
                inline constexpr std::ptrdiff_t m_AntiTunnelBytecode = 0x1B0;
                inline constexpr std::ptrdiff_t m_LegacyStretchForce = 0x330;
                inline constexpr std::ptrdiff_t m_NodeCollisionRadii = 0x348;
                inline constexpr std::ptrdiff_t m_SimdAnimStrayRadii = 0x4C8;
                inline constexpr std::ptrdiff_t m_TreeCollisionMasks = 0x420;
                inline constexpr std::ptrdiff_t m_flInternalPressure = 0x6E0;
                inline constexpr std::ptrdiff_t m_SelfCollisionLayers = 0x6C8;
                inline constexpr std::ptrdiff_t m_WorldCollisionNodes = 0x3F0;
                inline constexpr std::ptrdiff_t m_flDefaultExpAirDrag = 0x700;
                inline constexpr std::ptrdiff_t m_flDefaultVelAirDrag = 0x6FC;
                inline constexpr std::ptrdiff_t m_nRotLockStaticNodes = 0x44;
                inline constexpr std::ptrdiff_t m_SimdSpringIntegrator = 0x300;
                inline constexpr std::ptrdiff_t m_TaperedCapsuleRigids = 0x3C0;
                inline constexpr std::ptrdiff_t m_WorldCollisionParams = 0x318;
                inline constexpr std::ptrdiff_t m_nExtraGoalIterations = 0x576;
                inline constexpr std::ptrdiff_t m_AntiTunnelTargetNodes = 0x210;
                inline constexpr std::ptrdiff_t m_flDefaultGravityScale = 0x6F8;
                inline constexpr std::ptrdiff_t m_flDefaultTimeDilation = 0x6E4;
                inline constexpr std::ptrdiff_t m_flDefaultThreadStretch = 0x6F4;
                inline constexpr std::ptrdiff_t m_RigidColliderPriorities = 0x5D8;
                inline constexpr std::ptrdiff_t m_TaperedCapsuleStretches = 0x3A8;
                inline constexpr std::ptrdiff_t m_flDefaultExpQuadAirDrag = 0x708;
                inline constexpr std::ptrdiff_t m_flDefaultSurfaceStretch = 0x6F0;
                inline constexpr std::ptrdiff_t m_flDefaultVelQuadAirDrag = 0x704;
                inline constexpr std::ptrdiff_t m_flRodVelocitySmoothRate = 0x70C;
                inline constexpr std::ptrdiff_t m_flQuadVelocitySmoothRate = 0x710;
                inline constexpr std::ptrdiff_t m_nExtraPressureIterations = 0x575;
                inline constexpr std::ptrdiff_t m_nFirstPositionDrivenNode = 0x46;
                inline constexpr std::ptrdiff_t m_flAddWorldCollisionRadius = 0x714;
                inline constexpr std::ptrdiff_t m_GoalDampedSpringIntegrators = 0x540;
                inline constexpr std::ptrdiff_t m_nRodVelocitySmoothIterations = 0x724;
                inline constexpr std::ptrdiff_t m_nQuadVelocitySmoothIterations = 0x726;
                inline constexpr std::ptrdiff_t m_flDefaultVolumetricSolveAmount = 0x718;
                inline constexpr std::ptrdiff_t m_nNodeBaseJiggleboneDependsCount = 0x56;
            }
            namespace CFeNamedJiggleBone {
                inline constexpr std::ptrdiff_t m_transform = 0x10;
                inline constexpr std::ptrdiff_t m_jiggleBone = 0x34;
                inline constexpr std::ptrdiff_t m_nJiggleParent = 0x30;
                inline constexpr std::ptrdiff_t m_strParentBone = 0x0;
            }
            namespace CGenericShapeProxy {
                inline constexpr std::ptrdiff_t m_verts = 0x30;
            }
            namespace FeCollisionPlane_t {
                inline constexpr std::ptrdiff_t m_Plane = 0x4;
                inline constexpr std::ptrdiff_t flStrength = 0x14;
                inline constexpr std::ptrdiff_t nChildNode = 0x2;
                inline constexpr std::ptrdiff_t nCtrlParent = 0x0;
            }
            namespace FeCtrlSoftOffset_t {
                inline constexpr std::ptrdiff_t flAlpha = 0x10;
                inline constexpr std::ptrdiff_t vOffset = 0x4;
                inline constexpr std::ptrdiff_t nCtrlChild = 0x2;
                inline constexpr std::ptrdiff_t nCtrlParent = 0x0;
            }
            namespace FeMorphLayerDepr_t {
                inline constexpr std::ptrdiff_t m_Name = 0x0;
                inline constexpr std::ptrdiff_t m_Nodes = 0x10;
                inline constexpr std::ptrdiff_t m_nFlags = 0x88;
                inline constexpr std::ptrdiff_t m_Gravity = 0x40;
                inline constexpr std::ptrdiff_t m_InitPos = 0x28;
                inline constexpr std::ptrdiff_t m_nNameHash = 0x8;
                inline constexpr std::ptrdiff_t m_GoalDamping = 0x70;
                inline constexpr std::ptrdiff_t m_GoalStrength = 0x58;
            }
            namespace FeNodeIntegrator_t {
                inline constexpr std::ptrdiff_t flGravity = 0xC;
                inline constexpr std::ptrdiff_t flPointDamping = 0x0;
                inline constexpr std::ptrdiff_t flAnimationForceAttraction = 0x4;
                inline constexpr std::ptrdiff_t flAnimationVertexAttraction = 0x8;
            }
            namespace FeProxyVertexMap_t {
                inline constexpr std::ptrdiff_t m_Name = 0x0;
                inline constexpr std::ptrdiff_t m_flWeight = 0x8;
            }
            namespace FeVertexMapBuild_t {
                inline constexpr std::ptrdiff_t m_Color = 0xC;
                inline constexpr std::ptrdiff_t m_Weights = 0x18;
                inline constexpr std::ptrdiff_t m_nNameHash = 0x8;
                inline constexpr std::ptrdiff_t m_VertexMapName = 0x0;
                inline constexpr std::ptrdiff_t m_nScaleSourceNode = 0x14;
                inline constexpr std::ptrdiff_t m_flVolumetricSolveStrength = 0x10;
            }
            namespace RnSoftbodySpring_t {
                inline constexpr std::ptrdiff_t m_flLength = 0x4;
                inline constexpr std::ptrdiff_t m_nParticle = 0x0;
            }
            namespace FeAnimStrayRadius_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t flMaxDist = 0x4;
                inline constexpr std::ptrdiff_t flRelaxationFactor = 0x8;
            }
            namespace FeAntiTunnelProbe_t {
                inline constexpr std::ptrdiff_t flBias = 0x18;
                inline constexpr std::ptrdiff_t nBegin = 0xC;
                inline constexpr std::ptrdiff_t nCount = 0xA;
                inline constexpr std::ptrdiff_t nFlags = 0x4;
                inline constexpr std::ptrdiff_t flWeight = 0x0;
                inline constexpr std::ptrdiff_t nProbeNode = 0x8;
                inline constexpr std::ptrdiff_t flCurvatureRadius = 0x14;
                inline constexpr std::ptrdiff_t flActivationDistance = 0x10;
            }
            namespace FeHingeLimitBuild_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t nFlags = 0xC;
                inline constexpr std::ptrdiff_t flLimitCW = 0x10;
                inline constexpr std::ptrdiff_t flLimitCCW = 0x14;
            }
            namespace FeStiffHingeBuild_t {
                inline constexpr std::ptrdiff_t nNode = 0x14;
                inline constexpr std::ptrdiff_t flMaxAngle = 0x0;
                inline constexpr std::ptrdiff_t flStrength = 0x4;
                inline constexpr std::ptrdiff_t flMotionBias = 0x8;
            }
            namespace FeTwistConstraint_t {
                inline constexpr std::ptrdiff_t nNodeEnd = 0x2;
                inline constexpr std::ptrdiff_t nNodeOrient = 0x0;
                inline constexpr std::ptrdiff_t flSwingRelax = 0x8;
                inline constexpr std::ptrdiff_t flTwistRelax = 0x4;
            }
            namespace PhysicsParticleId_t {
                inline constexpr std::ptrdiff_t m_Value = 0x0;
            }
            namespace RnSoftbodyCapsule_t {
                inline constexpr std::ptrdiff_t m_vCenter = 0x0;
                inline constexpr std::ptrdiff_t m_flRadius = 0x18;
                inline constexpr std::ptrdiff_t m_nParticle = 0x1C;
            }
            namespace CFeIndexedJiggleBone {
                inline constexpr std::ptrdiff_t m_nNode = 0x0;
                inline constexpr std::ptrdiff_t m_jiggleBone = 0x8;
                inline constexpr std::ptrdiff_t m_nJiggleParent = 0x4;
            }
            namespace FeBuildSphereRigid_t {
                inline constexpr std::ptrdiff_t m_nPriority = 0x20;
                inline constexpr std::ptrdiff_t m_nVertexMapHash = 0x24;
                inline constexpr std::ptrdiff_t m_nAntitunnelGroupBits = 0x28;
            }
            namespace FeSpringIntegrator_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t flNodeWeight0 = 0x10;
                inline constexpr std::ptrdiff_t flSpringDamping = 0xC;
                inline constexpr std::ptrdiff_t flSpringConstant = 0x8;
                inline constexpr std::ptrdiff_t flSpringRestLength = 0x4;
            }
            namespace IPhysicsParticleRope {

            }
            namespace RnCompoundTreeNode_t {
                inline constexpr std::ptrdiff_t m_vMax = 0xC;
                inline constexpr std::ptrdiff_t m_vMin = 0x0;
                inline constexpr std::ptrdiff_t m_nType = 0x0;
                inline constexpr std::ptrdiff_t m_nSubtreeEndOrCompoundId = 0x0;
            }
            namespace RnSoftbodyParticle_t {
                inline constexpr std::ptrdiff_t m_flMassInv = 0x0;
            }
            namespace FeNodeReverseOffset_t {
                inline constexpr std::ptrdiff_t vOffset = 0x0;
                inline constexpr std::ptrdiff_t nBoneCtrl = 0xC;
                inline constexpr std::ptrdiff_t nTargetNode = 0xE;
            }
            namespace FeSimdRodConstraint_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t f4MaxDist = 0x10;
                inline constexpr std::ptrdiff_t f4MinDist = 0x20;
                inline constexpr std::ptrdiff_t f4Weight0 = 0x30;
                inline constexpr std::ptrdiff_t f4RelaxationFactor = 0x40;
            }
            namespace VertexPositionColor_t {
                inline constexpr std::ptrdiff_t m_vPosition = 0x0;
            }
            namespace CFeVertexMapBuildArray {
                inline constexpr std::ptrdiff_t m_Array = 0x0;
            }
            namespace IPhysAggregateInstance {
                inline constexpr std::ptrdiff_t m_pSkeleton = 0x8;
                inline constexpr std::ptrdiff_t m_bIsAxisAligned = 0x10;
            }
            namespace IPhysicsRagdollControl {

            }
            namespace VertexPositionNormal_t {
                inline constexpr std::ptrdiff_t m_vNormal = 0xC;
                inline constexpr std::ptrdiff_t m_vPosition = 0x0;
            }
            namespace constraint_axislimit_t {
                inline constexpr std::ptrdiff_t flMaxRotation = 0x4;
                inline constexpr std::ptrdiff_t flMinRotation = 0x0;
                inline constexpr std::ptrdiff_t flMotorMaxTorque = 0xC;
                inline constexpr std::ptrdiff_t flMotorTargetAngSpeed = 0x8;
            }
            namespace FeSimdAnimStrayRadius_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t flMaxDist = 0x10;
                inline constexpr std::ptrdiff_t flRelaxationFactor = 0x20;
            }
            namespace FeTaperedCapsuleRigid_t {
                inline constexpr std::ptrdiff_t nNode = 0x20;
                inline constexpr std::ptrdiff_t nFlags = 0x26;
                inline constexpr std::ptrdiff_t vSphere = 0x0;
                inline constexpr std::ptrdiff_t nCollisionMask = 0x22;
                inline constexpr std::ptrdiff_t nVertexMapIndex = 0x24;
            }
            namespace FeAntiTunnelGroupBuild_t {
                inline constexpr std::ptrdiff_t m_nCollisionMask = 0x4;
                inline constexpr std::ptrdiff_t m_nVertexMapHash = 0x0;
            }
            namespace FeAntiTunnelProbeBuild_t {
                inline constexpr std::ptrdiff_t flBias = 0x8;
                inline constexpr std::ptrdiff_t nFlags = 0x10;
                inline constexpr std::ptrdiff_t flWeight = 0x0;
                inline constexpr std::ptrdiff_t nProbeNode = 0x14;
                inline constexpr std::ptrdiff_t flCurvature = 0xC;
                inline constexpr std::ptrdiff_t targetNodes = 0x18;
                inline constexpr std::ptrdiff_t flActivationDistance = 0x4;
            }
            namespace FeRigidColliderIndices_t {
                inline constexpr std::ptrdiff_t m_nBoxRigidIndex = 0x4;
                inline constexpr std::ptrdiff_t m_nSDFRigidIndex = 0x6;
                inline constexpr std::ptrdiff_t m_nSphereRigidIndex = 0x2;
                inline constexpr std::ptrdiff_t m_nCollisionPlaneIndex = 0x8;
                inline constexpr std::ptrdiff_t m_nTaperedCapsuleRigidIndex = 0x0;
            }
            namespace FeSimdSpringIntegrator_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t flNodeWeight0 = 0x40;
                inline constexpr std::ptrdiff_t flSpringDamping = 0x30;
                inline constexpr std::ptrdiff_t flSpringConstant = 0x20;
                inline constexpr std::ptrdiff_t flSpringRestLength = 0x10;
            }
            namespace FeWorldCollisionParams_t {
                inline constexpr std::ptrdiff_t nListEnd = 0xA;
                inline constexpr std::ptrdiff_t nListBegin = 0x8;
                inline constexpr std::ptrdiff_t flWorldFriction = 0x0;
                inline constexpr std::ptrdiff_t flGroundFriction = 0x4;
            }
            namespace IPhysicsMotionController {

            }
            namespace IPhysicsPlayerController {

            }
            namespace constraint_hingeparams_t {
                inline constexpr std::ptrdiff_t hingeAxis = 0x18;
                inline constexpr std::ptrdiff_t constraint = 0x28;
                inline constexpr std::ptrdiff_t worldPosition = 0x0;
                inline constexpr std::ptrdiff_t worldAxisDirection = 0xC;
            }
            namespace FeSimdRodConstraintAnim_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t f4Weight0 = 0x10;
                inline constexpr std::ptrdiff_t f4RelaxationFactor = 0x20;
            }
            namespace FeTaperedCapsuleStretch_t {
                inline constexpr std::ptrdiff_t nNode = 0x0;
                inline constexpr std::ptrdiff_t nDummy = 0x6;
                inline constexpr std::ptrdiff_t flRadius = 0x8;
                inline constexpr std::ptrdiff_t nCollisionMask = 0x4;
            }
            namespace CollisionDetailLayerInfo_t {
                inline constexpr std::ptrdiff_t m_bIsQueryOnly = 0x10;
                inline constexpr std::ptrdiff_t m_bNotPickable = 0x38;
                inline constexpr std::ptrdiff_t m_sDescription = 0x0;
                inline constexpr std::ptrdiff_t m_sFriendlyName = 0x8;
                inline constexpr std::ptrdiff_t m_sParentDetailLayer = 0x18;
                inline constexpr std::ptrdiff_t m_vecSubtreeDetailLayers = 0x20;
            }
            namespace FeModelSelfCollisionLayer_t {
                inline constexpr std::ptrdiff_t m_Name = 0x0;
                inline constexpr std::ptrdiff_t m_Nodes = 0x8;
                inline constexpr std::ptrdiff_t m_nFlags = 0x24;
                inline constexpr std::ptrdiff_t m_nEndIdx = 0x28;
                inline constexpr std::ptrdiff_t m_flParentReaction = 0x20;
            }
            namespace FeBuildTaperedCapsuleRigid_t {
                inline constexpr std::ptrdiff_t m_nPriority = 0x30;
                inline constexpr std::ptrdiff_t m_nVertexMapHash = 0x34;
                inline constexpr std::ptrdiff_t m_nAntitunnelGroupBits = 0x38;
            }
            namespace constraint_breakableparams_t {
                inline constexpr std::ptrdiff_t isActive = 0x14;
                inline constexpr std::ptrdiff_t strength = 0x0;
                inline constexpr std::ptrdiff_t forceLimit = 0x4;
                inline constexpr std::ptrdiff_t torqueLimit = 0x8;
                inline constexpr std::ptrdiff_t bodyMassScale = 0xC;
            }
            namespace vphysics_save_cphysicsbody_t {
                inline constexpr std::ptrdiff_t m_nOldPointer = 0xE0;
            }
            namespace vphysics_save_ragdoll_control_t {
                inline constexpr std::ptrdiff_t m_nBodyCount = 0x34;
                inline constexpr std::ptrdiff_t m_flMaxStretch = 0x8;
                inline constexpr std::ptrdiff_t m_bIgnoreTeleport = 0xE;
                inline constexpr std::ptrdiff_t m_vForceAccumulator = 0x28;
                inline constexpr std::ptrdiff_t m_flMaxSpringFrequency = 0x4;
                inline constexpr std::ptrdiff_t m_flMinSpringFrequency = 0x0;
                inline constexpr std::ptrdiff_t m_bRequiresDynamicBodies = 0xD;
                inline constexpr std::ptrdiff_t m_vLinearVelocityAccumulator = 0x10;
                inline constexpr std::ptrdiff_t m_bSolidCollisionAtZeroWeight = 0xC;
                inline constexpr std::ptrdiff_t m_vAngularVelocityAccumulator = 0x1C;
            }
            namespace CollisionDetailLayerInfo_t__Name_t {
                inline constexpr std::ptrdiff_t m_nNameToken = 0x0;
                inline constexpr std::ptrdiff_t m_sNameString = 0x8;
            }
            namespace JointAxis_t {
                inline constexpr std::ptrdiff_t JOINT_AXIS_X = 0x0;
                inline constexpr std::ptrdiff_t JOINT_AXIS_Y = 0x1;
                inline constexpr std::ptrdiff_t JOINT_AXIS_Z = 0x2;
                inline constexpr std::ptrdiff_t JOINT_AXIS_COUNT = 0x3;
            }
            namespace JointMotion_t {
                inline constexpr std::ptrdiff_t JOINT_MOTION_FREE = 0x0;
                inline constexpr std::ptrdiff_t JOINT_MOTION_COUNT = 0x2;
                inline constexpr std::ptrdiff_t JOINT_MOTION_LOCKED = 0x1;
            }
            namespace PhysInterfaceId_t {
                inline constexpr std::ptrdiff_t PIID_UNKNOWN = 0x0;
                inline constexpr std::ptrdiff_t PIID_NUM_TYPES = 0x7;
                inline constexpr std::ptrdiff_t PIID_IPHYSICSBODY = 0x1;
                inline constexpr std::ptrdiff_t PIID_IPHYSICSJOINT = 0x3;
                inline constexpr std::ptrdiff_t PIID_IPHYSAGGREGATE = 0x2;
                inline constexpr std::ptrdiff_t PIID_IPHYSICSPARTICLEROPE = 0x5;
                inline constexpr std::ptrdiff_t PIID_IPHYSICSRAGDOLLCONTROL = 0x6;
                inline constexpr std::ptrdiff_t PIID_IPHYSICSMOTIONCONTROLLER = 0x4;
            }
            namespace PhysGenericShapeType_t {
                inline constexpr std::ptrdiff_t GENERIC_SHAPE_AABB = 0x2;
                inline constexpr std::ptrdiff_t GENERIC_SHAPE_HULL = 0x4;
                inline constexpr std::ptrdiff_t GENERIC_SHAPE_POINT = 0x0;
                inline constexpr std::ptrdiff_t GENERIC_SHAPE_SPHERE = 0x1;
                inline constexpr std::ptrdiff_t GENERIC_SHAPE_CAPSULE = 0x3;
            }
            namespace DynamicContinuousContactBehavior_t {
                inline constexpr std::ptrdiff_t DYNAMIC_CONTINUOUS_NEVER = 0x2;
                inline constexpr std::ptrdiff_t DYNAMIC_CONTINUOUS_ALWAYS = 0x1;
                inline constexpr std::ptrdiff_t DYNAMIC_CONTINUOUS_ALLOW_IF_REQUESTED_BY_OTHER_BODY = 0x0;
            }
        }
    }
}
