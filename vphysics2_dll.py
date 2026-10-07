class cs2_dumper:
    class schemas:
        class vphysics2_dll:
            class Dop26_t:
                m_flSupport = 0x0
            class FeTri_t:
                v2 = 0x14
                w1 = 0x8
                w2 = 0xC
                v1x = 0x10
                nNode = 0x0
            class FeQuad_t:
                nNode = 0x0
                vShape = 0xC
                flSlack = 0x8
            class RnFace_t:
                m_nEdge = 0x0
            class RnHull_t:
                m_Edges = 0xC8
                m_Faces = 0xE0
                m_Bounds = 0x14
                m_nFlags = 0xA0
                m_Vertices = 0xB0
                m_flVolume = 0x68
                m_vCentroid = 0x0
                m_FacePlanes = 0x88
                m_pRegionSVM = 0xA8
                m_flSurfaceArea = 0x6C
                m_MassProperties = 0x38
                m_VertexPositions = 0x70
                m_flMaxAngularRadius = 0xC
                m_vOrthographicAreas = 0x2C
                m_flMinCentroidRadius = 0x10
            class RnMesh_t:
                m_vMax = 0xC
                m_vMin = 0x0
                m_Nodes = 0x18
                m_Wings = 0x60
                m_nFlags = 0xB4
                m_Vertices = 0x30
                m_Materials = 0x90
                m_Triangles = 0x48
                m_nDebugFlags = 0xB8
                m_flSurfaceArea = 0xBC
                m_TriangleEdgeFlags = 0x78
                m_vOrthographicAreas = 0xA8
            class RnNode_t:
                m_vMax = 0x10
                m_vMin = 0x0
                m_nChildren = 0xC
                m_nTriangleOffset = 0x1C
            class RnWing_t:
                m_nIndex = 0x0
            class FePrism_t:
                nNode = 0x0
                flVolume = 0xC
            class RnPlane_t:
                m_vNormal = 0x0
                m_flOffset = 0xC
            class CRegionSVM:
                m_Nodes = 0x18
                m_Planes = 0x0
            class CovMatrix3:
                m_flXY = 0xC
                m_flXZ = 0x10
                m_flYZ = 0x14
                m_vDiag = 0x0
            class RnVertex_t:
                m_nEdge = 0x0
            class FeSimdTri_t:
                v2 = 0x60
                w1 = 0x30
                w2 = 0x40
                v1x = 0x50
                nNode = 0x0
            class OldFeEdge_t:
                t = 0x10
                c01 = 0x1C
                c02 = 0x20
                c03 = 0x24
                c04 = 0x28
                invA = 0xC
                m_flK = 0x0
                m_nNode = 0x40
                flThetaFactor = 0x18
                flThetaRelaxed = 0x14
                flAxialModelDist = 0x2C
                flAxialModelWeights = 0x30
            class RnCapsule_t:
                m_vCenter = 0x0
                m_flRadius = 0x18
            class FeBoxRigid_t:
                nNode = 0x20
                vSize = 0x24
                nFlags = 0x32
                tmFrame2 = 0x0
                nCollisionMask = 0x22
                nVertexMapIndex = 0x30
            class FeEdgeDesc_t:
                nEdge = 0x0
                nSide = 0x4
                nVirtElem = 0xC
            class FeNodeBase_t:
                nNode = 0x0
                nDummy = 0x2
                nNodeX0 = 0x8
                nNodeX1 = 0xA
                nNodeY0 = 0xC
                nNodeY1 = 0xE
                qAdjust = 0x10
            class FeSDFRigid_t:
                nNode = 0x1C
                nFlags = 0x22
                m_nDepth = 0x48
                m_nWidth = 0x40
                m_nHeight = 0x44
                vLocalMax = 0xC
                vLocalMin = 0x0
                m_Distances = 0x28
                flBounciness = 0x18
                nCollisionMask = 0x1E
                nVertexMapIndex = 0x20
            class FeSimdQuad_t:
                nNode = 0x0
                vShape = 0x30
                f4Slack = 0x20
                f4Weights = 0xF0
            class IPhysicsBody:
                pass
            class RnBodyDesc_t:
                m_bEnabled = 0xC7
                m_vGravity = 0xCC
                m_bSleeping = 0xC8
                m_flMassInv = 0x6C
                m_nBodyType = 0xB8
                m_vPosition = 0x8
                m_flGameMass = 0x70
                m_nGameFlags = 0xC0
                m_nGameIndex = 0xBC
                m_sDebugName = 0x0
                m_flTimeScale = 0xB4
                m_bDragEnabled = 0xCA
                m_qOrientation = 0x14
                m_nMassPriority = 0xC6
                m_flGravityScale = 0xB0
                m_flMassScaleInv = 0x74
                m_LocalInertiaInv = 0x48
                m_flBuoyancyScale = 0xAC
                m_flLinearDamping = 0x7C
                m_vLinearVelocity = 0x24
                m_flAngularDamping = 0x80
                m_vAngularVelocity = 0x30
                m_vLocalMassCenter = 0x3C
                m_flInertiaScaleInv = 0x78
                m_flLinearDragScale = 0x84
                m_flAngularDragScale = 0x88
                m_bSpeculativeEnabled = 0xD8
                m_bHasShadowController = 0xD9
                m_bIsContinuousEnabled = 0xC9
                m_vLastAwakeForceAccum = 0x94
                m_vLastAwakeTorqueAccum = 0xA0
                m_flLinearFluidDragScale = 0x8C
                m_nMinPositionIterations = 0xC5
                m_nMinVelocityIterations = 0xC4
                m_flAngularFluidDragScale = 0x90
                m_nDynamicContinuousContactBehavior = 0xDA
            class RnCompound_t:
                m_Tree = 0x0
                m_Hulls = 0xF0
                m_Bounds = 0x130
                m_Meshes = 0x28
                m_Spheres = 0x110
                m_Capsules = 0x100
                m_flVolume = 0x158
                m_nShapeCount = 0x20
                m_flSurfaceArea = 0x154
                m_nHullBaseIndex = 0x18
                m_nMeshBaseIndex = 0x1C
                m_vOrthographicAreas = 0x148
                m_CompoundMaterialIndices = 0x120
            class RnHalfEdge_t:
                m_nFace = 0x3
                m_nNext = 0x0
                m_nTwin = 0x1
                m_nOrigin = 0x2
            class RnHullDesc_t:
                m_Hull = 0x18
            class RnMeshDesc_t:
                m_Mesh = 0x18
            class RnTriangle_t:
                m_nIndex = 0x0
            class CFeJiggleBone:
                m_nFlags = 0x0
                m_vPoint0 = 0x80
                m_vPoint1 = 0x8C
                m_flLength = 0x4
                m_flMaxYaw = 0x2C
                m_flMinYaw = 0x28
                m_flRadius0 = 0x78
                m_flRadius1 = 0x7C
                m_flTipMass = 0x8
                m_flBaseMass = 0x48
                m_flMaxPitch = 0x3C
                m_flMinPitch = 0x38
                m_flBaseMaxUp = 0x64
                m_flBaseMinUp = 0x60
                m_flYawBounce = 0x34
                m_flAngleLimit = 0x24
                m_flYawDamping = 0x10
                m_flBaseDamping = 0x50
                m_flBaseMaxLeft = 0x58
                m_flBaseMinLeft = 0x54
                m_flPitchBounce = 0x44
                m_flYawFriction = 0x30
                m_flAlongDamping = 0x20
                m_flPitchDamping = 0x18
                m_flYawStiffness = 0xC
                m_nCollisionMask = 0x98
                m_flBaseStiffness = 0x4C
                m_flPitchFriction = 0x40
                m_flAlongStiffness = 0x1C
                m_flBaseMaxForward = 0x70
                m_flBaseMinForward = 0x6C
                m_flBaseUpFriction = 0x68
                m_flPitchStiffness = 0x14
                m_flBaseLeftFriction = 0x5C
                m_flBaseForwardFriction = 0x74
            class CFeMorphLayer:
                m_Name = 0x0
                m_Nodes = 0x10
                m_Gravity = 0x40
                m_InitPos = 0x28
                m_nNameHash = 0x8
                m_GoalDamping = 0x70
                m_GoalStrength = 0x58
            class FeFitMatrix_t:
                bone = 0x0
                nEnd = 0x2C
                nNode = 0x2E
                vCenter = 0x20
                nBeginDynamic = 0x30
            class FeFitWeight_t:
                nNode = 0x4
                nDummy = 0x6
                flWeight = 0x0
            class FeSimdPrism_t:
                nNode = 0x0
                flVolume = 0x30
            class FourVectors2D:
                x = 0x0
                y = 0x10
            class IPhysicsJoint:
                pass
            class RnShapeDesc_t:
                m_UserFriendlyName = 0x8
                m_nToolMaterialHash = 0x14
                m_bUserFriendlyNameLong = 0x11
                m_nSurfacePropertyIndex = 0x4
                m_bUserFriendlyNameSealed = 0x10
                m_nCollisionAttributeIndex = 0x0
            class FeCtrlOffset_t:
                vOffset = 0x0
                nCtrlChild = 0xE
                nCtrlParent = 0xC
            class FeDynKinLink_t:
                m_nChild = 0x2
                m_nParent = 0x0
            class FeEffectDesc_t:
                nType = 0xC
                sName = 0x0
                m_Params = 0x10
                nNameHash = 0x8
            class FeFollowNode_t:
                flWeight = 0x4
                nChildNode = 0x2
                nParentNode = 0x0
            class FeHingeLimit_t:
                nNode = 0x0
                nFlags = 0xC
                flWeight4 = 0x10
                flWeight5 = 0x14
                flAngleCenter = 0x18
                flAngleExtents = 0x1C
            class FeSoftParent_t:
                flAlpha = 0x4
                nParent = 0x0
            class FeSourceEdge_t:
                nNode = 0x0
            class RnSphereDesc_t:
                m_Sphere = 0x18
            class FeSphereRigid_t:
                nNode = 0x10
                nFlags = 0x16
                vSphere = 0x0
                nCollisionMask = 0x12
                nVertexMapIndex = 0x14
            class RnBlendVertex_t:
                m_nFlags = 0xC
                m_nIndex0 = 0x2
                m_nIndex1 = 0x6
                m_nIndex2 = 0xA
                m_nWeight0 = 0x0
                m_nWeight1 = 0x4
                m_nWeight2 = 0x8
                m_nTargetIndex = 0xE
            class RnCapsuleDesc_t:
                m_Capsule = 0x18
            class VPhysEntityId_t:
                m_Id = 0x0
            class FeCtrlOsOffset_t:
                nCtrlChild = 0x2
                nCtrlParent = 0x0
            class FeFitInfluence_t:
                flWeight = 0x4
                nMatrixNode = 0x8
                nVertexNode = 0x0
            class FeKelagerBend2_t:
                nNode = 0x10
                flWeight = 0x0
                flHeight0 = 0xC
                nReserved = 0x16
            class FeNodeStrayBox_t:
                vMax = 0x10
                vMin = 0x0
                nNode = 0x1C
                nFlags = 0xC
            class FeNodeWindBase_t:
                nNodeX0 = 0x0
                nNodeX1 = 0x2
                nNodeY0 = 0x4
                nNodeY1 = 0x6
            class FeSimdNodeBase_t:
                nNode = 0x0
                nDummy = 0x28
                nNodeX0 = 0x8
                nNodeX1 = 0x10
                nNodeY0 = 0x18
                nNodeY1 = 0x20
                qAdjust = 0x30
            class FeTreeChildren_t:
                nChild = 0x0
            class FeWeightedNode_t:
                nNode = 0x0
                nWeight = 0x2
            class FourCovMatrices3:
                m_flXY = 0x30
                m_flXZ = 0x40
                m_flYZ = 0x50
                m_vDiag = 0x0
            class IPhysicsBodyList:
                pass
            class RnCompoundDesc_t:
                m_Compound = 0x18
            class RnCompoundTree_t:
                m_Nodes = 0x0
                m_nStartIterationIndex = 0x10
            class FeAxialEdgeBend_t:
                te = 0x0
                tv = 0x4
                nNode = 0x1C
                flDist = 0x8
                flWeight = 0xC
            class FeBandBendLimit_t:
                nNode = 0x8
                flDistMax = 0x4
                flDistMin = 0x0
            class FeBoneMergeLink_t:
                m_nChildNode = 0x4
                m_nParentHash = 0x0
            class FeBuildBoxRigid_t:
                m_nPriority = 0x40
                m_nVertexMapHash = 0x44
                m_nAntitunnelGroupBits = 0x48
            class FeBuildSDFRigid_t:
                m_nPriority = 0x50
                m_nVertexMapHash = 0x54
                m_nAntitunnelGroupBits = 0x58
            class FeRodConstraint_t:
                nNode = 0x0
                flMaxDist = 0x4
                flMinDist = 0x8
                flWeight0 = 0xC
                flRelaxationFactor = 0x10
            class FeVertexMapDesc_t:
                sName = 0x0
                nColor = 0xC
                nFlags = 0x10
                nNameHash = 0x8
                nMapOffset = 0x18
                nVertexBase = 0x14
                nVertexCount = 0x16
                vCenterOfMass = 0x20
                nNodeListCount = 0x32
                nNodeListOffset = 0x1C
                nScaleSourceNode = 0x30
                flVolumetricSolveStrength = 0x2C
            class PhysFeModelDesc_t:
                m_Rods = 0x168
                m_Tris = 0x558
                m_Quads = 0xA8
                m_Ropes = 0x60
                m_Prisms = 0xF0
                m_Twists = 0x180
                m_Effects = 0x650
                m_CtrlHash = 0x0
                m_CtrlName = 0x18
                m_InitPose = 0x150
                m_SimdRods = 0x120
                m_SimdTris = 0xD8
                m_BoxRigids = 0x590
                m_FreeNodes = 0x450
                m_NodeBases = 0x78
                m_SDFRigids = 0x578
                m_SimdQuads = 0xC0
                m_flWindage = 0x6E8
                m_AxialEdges = 0x240
                m_FitWeights = 0x480
                m_LocalForce = 0x390
                m_LockToGoal = 0x680
                m_SimdPrisms = 0x108
                m_VertexMaps = 0x620
                m_flWindDrag = 0x6EC
                m_nNodeCount = 0x40
                m_nRopeCount = 0x58
                m_nTreeDepth = 0x54
                m_nTriCount1 = 0x570
                m_nTriCount2 = 0x572
                m_CtrlOffsets = 0x270
                m_DynKinLinks = 0x1C8
                m_FitMatrices = 0x468
                m_FollowNodes = 0x2A0
                m_HingeLimits = 0x198
                m_JiggleBones = 0x510
                m_MorphLayers = 0x5F0
                m_SkelParents = 0x698
                m_SourceElems = 0x528
                m_TreeParents = 0x408
                m_nQuadCount1 = 0x50
                m_nQuadCount2 = 0x52
                m_KelagerBends = 0x4E0
                m_LockToParent = 0x668
                m_MorphSetData = 0x608
                m_SimdRodsAnim = 0x138
                m_SphereRigids = 0x3D8
                m_TreeChildren = 0x438
                m_flLocalDrag1 = 0x720
                m_flLocalForce = 0x38
                m_nStaticNodes = 0x42
                m_CtrlOsOffsets = 0x288
                m_LocalRotation = 0x378
                m_NodeInvMasses = 0x258
                m_SimdNodeBases = 0x90
                m_AnimStrayRadii = 0x4B0
                m_BoneMergeLinks = 0x1E0
                m_NodeIntegrator = 0x2D0
                m_NodeStrayBoxes = 0x228
                m_ReverseOffsets = 0x498
                m_VertexSetNames = 0x5C0
                m_nReservedUint8 = 0x574
                m_nSimdTriCount1 = 0x48
                m_nSimdTriCount2 = 0x4A
                m_CollisionPlanes = 0x2B8
                m_CtrlSoftOffsets = 0x4F8
                m_DynNodeFriction = 0x360
                m_VertexMapValues = 0x638
                m_flLocalRotation = 0x3C
                m_nSimdQuadCount1 = 0x4C
                m_nSimdQuadCount2 = 0x4E
                m_AntiTunnelProbes = 0x1F8
                m_DynNodeVertexSet = 0x5A8
                m_DynNodeWindBases = 0x6B0
                m_SpringIntegrator = 0x2E8
                m_nExtraIterations = 0x577
                m_nStaticNodeFlags = 0x30
                m_flMotionSmoothCDT = 0x71C
                m_nDynamicNodeFlags = 0x34
                m_AntiTunnelBytecode = 0x1B0
                m_LegacyStretchForce = 0x330
                m_NodeCollisionRadii = 0x348
                m_SimdAnimStrayRadii = 0x4C8
                m_TreeCollisionMasks = 0x420
                m_flInternalPressure = 0x6E0
                m_SelfCollisionLayers = 0x6C8
                m_WorldCollisionNodes = 0x3F0
                m_flDefaultExpAirDrag = 0x700
                m_flDefaultVelAirDrag = 0x6FC
                m_nRotLockStaticNodes = 0x44
                m_SimdSpringIntegrator = 0x300
                m_TaperedCapsuleRigids = 0x3C0
                m_WorldCollisionParams = 0x318
                m_nExtraGoalIterations = 0x576
                m_AntiTunnelTargetNodes = 0x210
                m_flDefaultGravityScale = 0x6F8
                m_flDefaultTimeDilation = 0x6E4
                m_flDefaultThreadStretch = 0x6F4
                m_RigidColliderPriorities = 0x5D8
                m_TaperedCapsuleStretches = 0x3A8
                m_flDefaultExpQuadAirDrag = 0x708
                m_flDefaultSurfaceStretch = 0x6F0
                m_flDefaultVelQuadAirDrag = 0x704
                m_flRodVelocitySmoothRate = 0x70C
                m_flQuadVelocitySmoothRate = 0x710
                m_nExtraPressureIterations = 0x575
                m_nFirstPositionDrivenNode = 0x46
                m_flAddWorldCollisionRadius = 0x714
                m_GoalDampedSpringIntegrators = 0x540
                m_nRodVelocitySmoothIterations = 0x724
                m_nQuadVelocitySmoothIterations = 0x726
                m_flDefaultVolumetricSolveAmount = 0x718
                m_nNodeBaseJiggleboneDependsCount = 0x56
            class CFeNamedJiggleBone:
                m_transform = 0x10
                m_jiggleBone = 0x34
                m_nJiggleParent = 0x30
                m_strParentBone = 0x0
            class CGenericShapeProxy:
                m_verts = 0x30
            class FeCollisionPlane_t:
                m_Plane = 0x4
                flStrength = 0x14
                nChildNode = 0x2
                nCtrlParent = 0x0
            class FeCtrlSoftOffset_t:
                flAlpha = 0x10
                vOffset = 0x4
                nCtrlChild = 0x2
                nCtrlParent = 0x0
            class FeMorphLayerDepr_t:
                m_Name = 0x0
                m_Nodes = 0x10
                m_nFlags = 0x88
                m_Gravity = 0x40
                m_InitPos = 0x28
                m_nNameHash = 0x8
                m_GoalDamping = 0x70
                m_GoalStrength = 0x58
            class FeNodeIntegrator_t:
                flGravity = 0xC
                flPointDamping = 0x0
                flAnimationForceAttraction = 0x4
                flAnimationVertexAttraction = 0x8
            class FeProxyVertexMap_t:
                m_Name = 0x0
                m_flWeight = 0x8
            class FeVertexMapBuild_t:
                m_Color = 0xC
                m_Weights = 0x18
                m_nNameHash = 0x8
                m_VertexMapName = 0x0
                m_nScaleSourceNode = 0x14
                m_flVolumetricSolveStrength = 0x10
            class RnSoftbodySpring_t:
                m_flLength = 0x4
                m_nParticle = 0x0
            class FeAnimStrayRadius_t:
                nNode = 0x0
                flMaxDist = 0x4
                flRelaxationFactor = 0x8
            class FeAntiTunnelProbe_t:
                flBias = 0x18
                nBegin = 0xC
                nCount = 0xA
                nFlags = 0x4
                flWeight = 0x0
                nProbeNode = 0x8
                flCurvatureRadius = 0x14
                flActivationDistance = 0x10
            class FeHingeLimitBuild_t:
                nNode = 0x0
                nFlags = 0xC
                flLimitCW = 0x10
                flLimitCCW = 0x14
            class FeStiffHingeBuild_t:
                nNode = 0x14
                flMaxAngle = 0x0
                flStrength = 0x4
                flMotionBias = 0x8
            class FeTwistConstraint_t:
                nNodeEnd = 0x2
                nNodeOrient = 0x0
                flSwingRelax = 0x8
                flTwistRelax = 0x4
            class PhysicsParticleId_t:
                m_Value = 0x0
            class RnSoftbodyCapsule_t:
                m_vCenter = 0x0
                m_flRadius = 0x18
                m_nParticle = 0x1C
            class CFeIndexedJiggleBone:
                m_nNode = 0x0
                m_jiggleBone = 0x8
                m_nJiggleParent = 0x4
            class FeBuildSphereRigid_t:
                m_nPriority = 0x20
                m_nVertexMapHash = 0x24
                m_nAntitunnelGroupBits = 0x28
            class FeSpringIntegrator_t:
                nNode = 0x0
                flNodeWeight0 = 0x10
                flSpringDamping = 0xC
                flSpringConstant = 0x8
                flSpringRestLength = 0x4
            class IPhysicsParticleRope:
                pass
            class RnCompoundTreeNode_t:
                m_vMax = 0xC
                m_vMin = 0x0
                m_nType = 0x0
                m_nSubtreeEndOrCompoundId = 0x0
            class RnSoftbodyParticle_t:
                m_flMassInv = 0x0
            class FeNodeReverseOffset_t:
                vOffset = 0x0
                nBoneCtrl = 0xC
                nTargetNode = 0xE
            class FeSimdRodConstraint_t:
                nNode = 0x0
                f4MaxDist = 0x10
                f4MinDist = 0x20
                f4Weight0 = 0x30
                f4RelaxationFactor = 0x40
            class VertexPositionColor_t:
                m_vPosition = 0x0
            class CFeVertexMapBuildArray:
                m_Array = 0x0
            class IPhysAggregateInstance:
                m_pSkeleton = 0x8
                m_bIsAxisAligned = 0x10
            class IPhysicsRagdollControl:
                pass
            class VertexPositionNormal_t:
                m_vNormal = 0xC
                m_vPosition = 0x0
            class constraint_axislimit_t:
                flMaxRotation = 0x4
                flMinRotation = 0x0
                flMotorMaxTorque = 0xC
                flMotorTargetAngSpeed = 0x8
            class FeSimdAnimStrayRadius_t:
                nNode = 0x0
                flMaxDist = 0x10
                flRelaxationFactor = 0x20
            class FeTaperedCapsuleRigid_t:
                nNode = 0x20
                nFlags = 0x26
                vSphere = 0x0
                nCollisionMask = 0x22
                nVertexMapIndex = 0x24
            class FeAntiTunnelGroupBuild_t:
                m_nCollisionMask = 0x4
                m_nVertexMapHash = 0x0
            class FeAntiTunnelProbeBuild_t:
                flBias = 0x8
                nFlags = 0x10
                flWeight = 0x0
                nProbeNode = 0x14
                flCurvature = 0xC
                targetNodes = 0x18
                flActivationDistance = 0x4
            class FeRigidColliderIndices_t:
                m_nBoxRigidIndex = 0x4
                m_nSDFRigidIndex = 0x6
                m_nSphereRigidIndex = 0x2
                m_nCollisionPlaneIndex = 0x8
                m_nTaperedCapsuleRigidIndex = 0x0
            class FeSimdSpringIntegrator_t:
                nNode = 0x0
                flNodeWeight0 = 0x40
                flSpringDamping = 0x30
                flSpringConstant = 0x20
                flSpringRestLength = 0x10
            class FeWorldCollisionParams_t:
                nListEnd = 0xA
                nListBegin = 0x8
                flWorldFriction = 0x0
                flGroundFriction = 0x4
            class IPhysicsMotionController:
                pass
            class IPhysicsPlayerController:
                pass
            class constraint_hingeparams_t:
                hingeAxis = 0x18
                constraint = 0x28
                worldPosition = 0x0
                worldAxisDirection = 0xC
            class FeSimdRodConstraintAnim_t:
                nNode = 0x0
                f4Weight0 = 0x10
                f4RelaxationFactor = 0x20
            class FeTaperedCapsuleStretch_t:
                nNode = 0x0
                nDummy = 0x6
                flRadius = 0x8
                nCollisionMask = 0x4
            class CollisionDetailLayerInfo_t:
                m_bIsQueryOnly = 0x10
                m_bNotPickable = 0x38
                m_sDescription = 0x0
                m_sFriendlyName = 0x8
                m_sParentDetailLayer = 0x18
                m_vecSubtreeDetailLayers = 0x20
            class FeModelSelfCollisionLayer_t:
                m_Name = 0x0
                m_Nodes = 0x8
                m_nFlags = 0x24
                m_nEndIdx = 0x28
                m_flParentReaction = 0x20
            class FeBuildTaperedCapsuleRigid_t:
                m_nPriority = 0x30
                m_nVertexMapHash = 0x34
                m_nAntitunnelGroupBits = 0x38
            class constraint_breakableparams_t:
                isActive = 0x14
                strength = 0x0
                forceLimit = 0x4
                torqueLimit = 0x8
                bodyMassScale = 0xC
            class vphysics_save_cphysicsbody_t:
                m_nOldPointer = 0xE0
            class vphysics_save_ragdoll_control_t:
                m_nBodyCount = 0x34
                m_flMaxStretch = 0x8
                m_bIgnoreTeleport = 0xE
                m_vForceAccumulator = 0x28
                m_flMaxSpringFrequency = 0x4
                m_flMinSpringFrequency = 0x0
                m_bRequiresDynamicBodies = 0xD
                m_vLinearVelocityAccumulator = 0x10
                m_bSolidCollisionAtZeroWeight = 0xC
                m_vAngularVelocityAccumulator = 0x1C
            class CollisionDetailLayerInfo_t__Name_t:
                m_nNameToken = 0x0
                m_sNameString = 0x8
            class JointAxis_t:
                JOINT_AXIS_X = 0x0
                JOINT_AXIS_Y = 0x1
                JOINT_AXIS_Z = 0x2
                JOINT_AXIS_COUNT = 0x3
            class JointMotion_t:
                JOINT_MOTION_FREE = 0x0
                JOINT_MOTION_COUNT = 0x2
                JOINT_MOTION_LOCKED = 0x1
            class PhysInterfaceId_t:
                PIID_UNKNOWN = 0x0
                PIID_NUM_TYPES = 0x7
                PIID_IPHYSICSBODY = 0x1
                PIID_IPHYSICSJOINT = 0x3
                PIID_IPHYSAGGREGATE = 0x2
                PIID_IPHYSICSPARTICLEROPE = 0x5
                PIID_IPHYSICSRAGDOLLCONTROL = 0x6
                PIID_IPHYSICSMOTIONCONTROLLER = 0x4
            class PhysGenericShapeType_t:
                GENERIC_SHAPE_AABB = 0x2
                GENERIC_SHAPE_HULL = 0x4
                GENERIC_SHAPE_POINT = 0x0
                GENERIC_SHAPE_SPHERE = 0x1
                GENERIC_SHAPE_CAPSULE = 0x3
            class DynamicContinuousContactBehavior_t:
                DYNAMIC_CONTINUOUS_NEVER = 0x2
                DYNAMIC_CONTINUOUS_ALWAYS = 0x1
                DYNAMIC_CONTINUOUS_ALLOW_IF_REQUESTED_BY_OTHER_BODY = 0x0
