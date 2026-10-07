pub const cs2_dumper = struct {
    pub const schemas = struct {
        pub const vphysics2_dll = struct {
            pub const Dop26_t = struct {
                pub const m_flSupport: i64 = 0x0;
            };
            pub const FeTri_t = struct {
                pub const v2: i64 = 0x14;
                pub const w1: i64 = 0x8;
                pub const w2: i64 = 0xC;
                pub const v1x: i64 = 0x10;
                pub const nNode: i64 = 0x0;
            };
            pub const FeQuad_t = struct {
                pub const nNode: i64 = 0x0;
                pub const vShape: i64 = 0xC;
                pub const flSlack: i64 = 0x8;
            };
            pub const RnFace_t = struct {
                pub const m_nEdge: i64 = 0x0;
            };
            pub const RnHull_t = struct {
                pub const m_Edges: i64 = 0xC8;
                pub const m_Faces: i64 = 0xE0;
                pub const m_Bounds: i64 = 0x14;
                pub const m_nFlags: i64 = 0xA0;
                pub const m_Vertices: i64 = 0xB0;
                pub const m_flVolume: i64 = 0x68;
                pub const m_vCentroid: i64 = 0x0;
                pub const m_FacePlanes: i64 = 0x88;
                pub const m_pRegionSVM: i64 = 0xA8;
                pub const m_flSurfaceArea: i64 = 0x6C;
                pub const m_MassProperties: i64 = 0x38;
                pub const m_VertexPositions: i64 = 0x70;
                pub const m_flMaxAngularRadius: i64 = 0xC;
                pub const m_vOrthographicAreas: i64 = 0x2C;
                pub const m_flMinCentroidRadius: i64 = 0x10;
            };
            pub const RnMesh_t = struct {
                pub const m_vMax: i64 = 0xC;
                pub const m_vMin: i64 = 0x0;
                pub const m_Nodes: i64 = 0x18;
                pub const m_Wings: i64 = 0x60;
                pub const m_nFlags: i64 = 0xB4;
                pub const m_Vertices: i64 = 0x30;
                pub const m_Materials: i64 = 0x90;
                pub const m_Triangles: i64 = 0x48;
                pub const m_nDebugFlags: i64 = 0xB8;
                pub const m_flSurfaceArea: i64 = 0xBC;
                pub const m_TriangleEdgeFlags: i64 = 0x78;
                pub const m_vOrthographicAreas: i64 = 0xA8;
            };
            pub const RnNode_t = struct {
                pub const m_vMax: i64 = 0x10;
                pub const m_vMin: i64 = 0x0;
                pub const m_nChildren: i64 = 0xC;
                pub const m_nTriangleOffset: i64 = 0x1C;
            };
            pub const RnWing_t = struct {
                pub const m_nIndex: i64 = 0x0;
            };
            pub const FePrism_t = struct {
                pub const nNode: i64 = 0x0;
                pub const flVolume: i64 = 0xC;
            };
            pub const RnPlane_t = struct {
                pub const m_vNormal: i64 = 0x0;
                pub const m_flOffset: i64 = 0xC;
            };
            pub const CRegionSVM = struct {
                pub const m_Nodes: i64 = 0x18;
                pub const m_Planes: i64 = 0x0;
            };
            pub const CovMatrix3 = struct {
                pub const m_flXY: i64 = 0xC;
                pub const m_flXZ: i64 = 0x10;
                pub const m_flYZ: i64 = 0x14;
                pub const m_vDiag: i64 = 0x0;
            };
            pub const RnVertex_t = struct {
                pub const m_nEdge: i64 = 0x0;
            };
            pub const FeSimdTri_t = struct {
                pub const v2: i64 = 0x60;
                pub const w1: i64 = 0x30;
                pub const w2: i64 = 0x40;
                pub const v1x: i64 = 0x50;
                pub const nNode: i64 = 0x0;
            };
            pub const OldFeEdge_t = struct {
                pub const t: i64 = 0x10;
                pub const c01: i64 = 0x1C;
                pub const c02: i64 = 0x20;
                pub const c03: i64 = 0x24;
                pub const c04: i64 = 0x28;
                pub const invA: i64 = 0xC;
                pub const m_flK: i64 = 0x0;
                pub const m_nNode: i64 = 0x40;
                pub const flThetaFactor: i64 = 0x18;
                pub const flThetaRelaxed: i64 = 0x14;
                pub const flAxialModelDist: i64 = 0x2C;
                pub const flAxialModelWeights: i64 = 0x30;
            };
            pub const RnCapsule_t = struct {
                pub const m_vCenter: i64 = 0x0;
                pub const m_flRadius: i64 = 0x18;
            };
            pub const FeBoxRigid_t = struct {
                pub const nNode: i64 = 0x20;
                pub const vSize: i64 = 0x24;
                pub const nFlags: i64 = 0x32;
                pub const tmFrame2: i64 = 0x0;
                pub const nCollisionMask: i64 = 0x22;
                pub const nVertexMapIndex: i64 = 0x30;
            };
            pub const FeEdgeDesc_t = struct {
                pub const nEdge: i64 = 0x0;
                pub const nSide: i64 = 0x4;
                pub const nVirtElem: i64 = 0xC;
            };
            pub const FeNodeBase_t = struct {
                pub const nNode: i64 = 0x0;
                pub const nDummy: i64 = 0x2;
                pub const nNodeX0: i64 = 0x8;
                pub const nNodeX1: i64 = 0xA;
                pub const nNodeY0: i64 = 0xC;
                pub const nNodeY1: i64 = 0xE;
                pub const qAdjust: i64 = 0x10;
            };
            pub const FeSDFRigid_t = struct {
                pub const nNode: i64 = 0x1C;
                pub const nFlags: i64 = 0x22;
                pub const m_nDepth: i64 = 0x48;
                pub const m_nWidth: i64 = 0x40;
                pub const m_nHeight: i64 = 0x44;
                pub const vLocalMax: i64 = 0xC;
                pub const vLocalMin: i64 = 0x0;
                pub const m_Distances: i64 = 0x28;
                pub const flBounciness: i64 = 0x18;
                pub const nCollisionMask: i64 = 0x1E;
                pub const nVertexMapIndex: i64 = 0x20;
            };
            pub const FeSimdQuad_t = struct {
                pub const nNode: i64 = 0x0;
                pub const vShape: i64 = 0x30;
                pub const f4Slack: i64 = 0x20;
                pub const f4Weights: i64 = 0xF0;
            };
            pub const IPhysicsBody = struct {

            };
            pub const RnBodyDesc_t = struct {
                pub const m_bEnabled: i64 = 0xC7;
                pub const m_vGravity: i64 = 0xCC;
                pub const m_bSleeping: i64 = 0xC8;
                pub const m_flMassInv: i64 = 0x6C;
                pub const m_nBodyType: i64 = 0xB8;
                pub const m_vPosition: i64 = 0x8;
                pub const m_flGameMass: i64 = 0x70;
                pub const m_nGameFlags: i64 = 0xC0;
                pub const m_nGameIndex: i64 = 0xBC;
                pub const m_sDebugName: i64 = 0x0;
                pub const m_flTimeScale: i64 = 0xB4;
                pub const m_bDragEnabled: i64 = 0xCA;
                pub const m_qOrientation: i64 = 0x14;
                pub const m_nMassPriority: i64 = 0xC6;
                pub const m_flGravityScale: i64 = 0xB0;
                pub const m_flMassScaleInv: i64 = 0x74;
                pub const m_LocalInertiaInv: i64 = 0x48;
                pub const m_flBuoyancyScale: i64 = 0xAC;
                pub const m_flLinearDamping: i64 = 0x7C;
                pub const m_vLinearVelocity: i64 = 0x24;
                pub const m_flAngularDamping: i64 = 0x80;
                pub const m_vAngularVelocity: i64 = 0x30;
                pub const m_vLocalMassCenter: i64 = 0x3C;
                pub const m_flInertiaScaleInv: i64 = 0x78;
                pub const m_flLinearDragScale: i64 = 0x84;
                pub const m_flAngularDragScale: i64 = 0x88;
                pub const m_bSpeculativeEnabled: i64 = 0xD8;
                pub const m_bHasShadowController: i64 = 0xD9;
                pub const m_bIsContinuousEnabled: i64 = 0xC9;
                pub const m_vLastAwakeForceAccum: i64 = 0x94;
                pub const m_vLastAwakeTorqueAccum: i64 = 0xA0;
                pub const m_flLinearFluidDragScale: i64 = 0x8C;
                pub const m_nMinPositionIterations: i64 = 0xC5;
                pub const m_nMinVelocityIterations: i64 = 0xC4;
                pub const m_flAngularFluidDragScale: i64 = 0x90;
                pub const m_nDynamicContinuousContactBehavior: i64 = 0xDA;
            };
            pub const RnCompound_t = struct {
                pub const m_Tree: i64 = 0x0;
                pub const m_Hulls: i64 = 0xF0;
                pub const m_Bounds: i64 = 0x130;
                pub const m_Meshes: i64 = 0x28;
                pub const m_Spheres: i64 = 0x110;
                pub const m_Capsules: i64 = 0x100;
                pub const m_flVolume: i64 = 0x158;
                pub const m_nShapeCount: i64 = 0x20;
                pub const m_flSurfaceArea: i64 = 0x154;
                pub const m_nHullBaseIndex: i64 = 0x18;
                pub const m_nMeshBaseIndex: i64 = 0x1C;
                pub const m_vOrthographicAreas: i64 = 0x148;
                pub const m_CompoundMaterialIndices: i64 = 0x120;
            };
            pub const RnHalfEdge_t = struct {
                pub const m_nFace: i64 = 0x3;
                pub const m_nNext: i64 = 0x0;
                pub const m_nTwin: i64 = 0x1;
                pub const m_nOrigin: i64 = 0x2;
            };
            pub const RnHullDesc_t = struct {
                pub const m_Hull: i64 = 0x18;
            };
            pub const RnMeshDesc_t = struct {
                pub const m_Mesh: i64 = 0x18;
            };
            pub const RnTriangle_t = struct {
                pub const m_nIndex: i64 = 0x0;
            };
            pub const CFeJiggleBone = struct {
                pub const m_nFlags: i64 = 0x0;
                pub const m_vPoint0: i64 = 0x80;
                pub const m_vPoint1: i64 = 0x8C;
                pub const m_flLength: i64 = 0x4;
                pub const m_flMaxYaw: i64 = 0x2C;
                pub const m_flMinYaw: i64 = 0x28;
                pub const m_flRadius0: i64 = 0x78;
                pub const m_flRadius1: i64 = 0x7C;
                pub const m_flTipMass: i64 = 0x8;
                pub const m_flBaseMass: i64 = 0x48;
                pub const m_flMaxPitch: i64 = 0x3C;
                pub const m_flMinPitch: i64 = 0x38;
                pub const m_flBaseMaxUp: i64 = 0x64;
                pub const m_flBaseMinUp: i64 = 0x60;
                pub const m_flYawBounce: i64 = 0x34;
                pub const m_flAngleLimit: i64 = 0x24;
                pub const m_flYawDamping: i64 = 0x10;
                pub const m_flBaseDamping: i64 = 0x50;
                pub const m_flBaseMaxLeft: i64 = 0x58;
                pub const m_flBaseMinLeft: i64 = 0x54;
                pub const m_flPitchBounce: i64 = 0x44;
                pub const m_flYawFriction: i64 = 0x30;
                pub const m_flAlongDamping: i64 = 0x20;
                pub const m_flPitchDamping: i64 = 0x18;
                pub const m_flYawStiffness: i64 = 0xC;
                pub const m_nCollisionMask: i64 = 0x98;
                pub const m_flBaseStiffness: i64 = 0x4C;
                pub const m_flPitchFriction: i64 = 0x40;
                pub const m_flAlongStiffness: i64 = 0x1C;
                pub const m_flBaseMaxForward: i64 = 0x70;
                pub const m_flBaseMinForward: i64 = 0x6C;
                pub const m_flBaseUpFriction: i64 = 0x68;
                pub const m_flPitchStiffness: i64 = 0x14;
                pub const m_flBaseLeftFriction: i64 = 0x5C;
                pub const m_flBaseForwardFriction: i64 = 0x74;
            };
            pub const CFeMorphLayer = struct {
                pub const m_Name: i64 = 0x0;
                pub const m_Nodes: i64 = 0x10;
                pub const m_Gravity: i64 = 0x40;
                pub const m_InitPos: i64 = 0x28;
                pub const m_nNameHash: i64 = 0x8;
                pub const m_GoalDamping: i64 = 0x70;
                pub const m_GoalStrength: i64 = 0x58;
            };
            pub const FeFitMatrix_t = struct {
                pub const bone: i64 = 0x0;
                pub const nEnd: i64 = 0x2C;
                pub const nNode: i64 = 0x2E;
                pub const vCenter: i64 = 0x20;
                pub const nBeginDynamic: i64 = 0x30;
            };
            pub const FeFitWeight_t = struct {
                pub const nNode: i64 = 0x4;
                pub const nDummy: i64 = 0x6;
                pub const flWeight: i64 = 0x0;
            };
            pub const FeSimdPrism_t = struct {
                pub const nNode: i64 = 0x0;
                pub const flVolume: i64 = 0x30;
            };
            pub const FourVectors2D = struct {
                pub const x: i64 = 0x0;
                pub const y: i64 = 0x10;
            };
            pub const IPhysicsJoint = struct {

            };
            pub const RnShapeDesc_t = struct {
                pub const m_UserFriendlyName: i64 = 0x8;
                pub const m_nToolMaterialHash: i64 = 0x14;
                pub const m_bUserFriendlyNameLong: i64 = 0x11;
                pub const m_nSurfacePropertyIndex: i64 = 0x4;
                pub const m_bUserFriendlyNameSealed: i64 = 0x10;
                pub const m_nCollisionAttributeIndex: i64 = 0x0;
            };
            pub const FeCtrlOffset_t = struct {
                pub const vOffset: i64 = 0x0;
                pub const nCtrlChild: i64 = 0xE;
                pub const nCtrlParent: i64 = 0xC;
            };
            pub const FeDynKinLink_t = struct {
                pub const m_nChild: i64 = 0x2;
                pub const m_nParent: i64 = 0x0;
            };
            pub const FeEffectDesc_t = struct {
                pub const nType: i64 = 0xC;
                pub const sName: i64 = 0x0;
                pub const m_Params: i64 = 0x10;
                pub const nNameHash: i64 = 0x8;
            };
            pub const FeFollowNode_t = struct {
                pub const flWeight: i64 = 0x4;
                pub const nChildNode: i64 = 0x2;
                pub const nParentNode: i64 = 0x0;
            };
            pub const FeHingeLimit_t = struct {
                pub const nNode: i64 = 0x0;
                pub const nFlags: i64 = 0xC;
                pub const flWeight4: i64 = 0x10;
                pub const flWeight5: i64 = 0x14;
                pub const flAngleCenter: i64 = 0x18;
                pub const flAngleExtents: i64 = 0x1C;
            };
            pub const FeSoftParent_t = struct {
                pub const flAlpha: i64 = 0x4;
                pub const nParent: i64 = 0x0;
            };
            pub const FeSourceEdge_t = struct {
                pub const nNode: i64 = 0x0;
            };
            pub const RnSphereDesc_t = struct {
                pub const m_Sphere: i64 = 0x18;
            };
            pub const FeSphereRigid_t = struct {
                pub const nNode: i64 = 0x10;
                pub const nFlags: i64 = 0x16;
                pub const vSphere: i64 = 0x0;
                pub const nCollisionMask: i64 = 0x12;
                pub const nVertexMapIndex: i64 = 0x14;
            };
            pub const RnBlendVertex_t = struct {
                pub const m_nFlags: i64 = 0xC;
                pub const m_nIndex0: i64 = 0x2;
                pub const m_nIndex1: i64 = 0x6;
                pub const m_nIndex2: i64 = 0xA;
                pub const m_nWeight0: i64 = 0x0;
                pub const m_nWeight1: i64 = 0x4;
                pub const m_nWeight2: i64 = 0x8;
                pub const m_nTargetIndex: i64 = 0xE;
            };
            pub const RnCapsuleDesc_t = struct {
                pub const m_Capsule: i64 = 0x18;
            };
            pub const VPhysEntityId_t = struct {
                pub const m_Id: i64 = 0x0;
            };
            pub const FeCtrlOsOffset_t = struct {
                pub const nCtrlChild: i64 = 0x2;
                pub const nCtrlParent: i64 = 0x0;
            };
            pub const FeFitInfluence_t = struct {
                pub const flWeight: i64 = 0x4;
                pub const nMatrixNode: i64 = 0x8;
                pub const nVertexNode: i64 = 0x0;
            };
            pub const FeKelagerBend2_t = struct {
                pub const nNode: i64 = 0x10;
                pub const flWeight: i64 = 0x0;
                pub const flHeight0: i64 = 0xC;
                pub const nReserved: i64 = 0x16;
            };
            pub const FeNodeStrayBox_t = struct {
                pub const vMax: i64 = 0x10;
                pub const vMin: i64 = 0x0;
                pub const nNode: i64 = 0x1C;
                pub const nFlags: i64 = 0xC;
            };
            pub const FeNodeWindBase_t = struct {
                pub const nNodeX0: i64 = 0x0;
                pub const nNodeX1: i64 = 0x2;
                pub const nNodeY0: i64 = 0x4;
                pub const nNodeY1: i64 = 0x6;
            };
            pub const FeSimdNodeBase_t = struct {
                pub const nNode: i64 = 0x0;
                pub const nDummy: i64 = 0x28;
                pub const nNodeX0: i64 = 0x8;
                pub const nNodeX1: i64 = 0x10;
                pub const nNodeY0: i64 = 0x18;
                pub const nNodeY1: i64 = 0x20;
                pub const qAdjust: i64 = 0x30;
            };
            pub const FeTreeChildren_t = struct {
                pub const nChild: i64 = 0x0;
            };
            pub const FeWeightedNode_t = struct {
                pub const nNode: i64 = 0x0;
                pub const nWeight: i64 = 0x2;
            };
            pub const FourCovMatrices3 = struct {
                pub const m_flXY: i64 = 0x30;
                pub const m_flXZ: i64 = 0x40;
                pub const m_flYZ: i64 = 0x50;
                pub const m_vDiag: i64 = 0x0;
            };
            pub const IPhysicsBodyList = struct {

            };
            pub const RnCompoundDesc_t = struct {
                pub const m_Compound: i64 = 0x18;
            };
            pub const RnCompoundTree_t = struct {
                pub const m_Nodes: i64 = 0x0;
                pub const m_nStartIterationIndex: i64 = 0x10;
            };
            pub const FeAxialEdgeBend_t = struct {
                pub const te: i64 = 0x0;
                pub const tv: i64 = 0x4;
                pub const nNode: i64 = 0x1C;
                pub const flDist: i64 = 0x8;
                pub const flWeight: i64 = 0xC;
            };
            pub const FeBandBendLimit_t = struct {
                pub const nNode: i64 = 0x8;
                pub const flDistMax: i64 = 0x4;
                pub const flDistMin: i64 = 0x0;
            };
            pub const FeBoneMergeLink_t = struct {
                pub const m_nChildNode: i64 = 0x4;
                pub const m_nParentHash: i64 = 0x0;
            };
            pub const FeBuildBoxRigid_t = struct {
                pub const m_nPriority: i64 = 0x40;
                pub const m_nVertexMapHash: i64 = 0x44;
                pub const m_nAntitunnelGroupBits: i64 = 0x48;
            };
            pub const FeBuildSDFRigid_t = struct {
                pub const m_nPriority: i64 = 0x50;
                pub const m_nVertexMapHash: i64 = 0x54;
                pub const m_nAntitunnelGroupBits: i64 = 0x58;
            };
            pub const FeRodConstraint_t = struct {
                pub const nNode: i64 = 0x0;
                pub const flMaxDist: i64 = 0x4;
                pub const flMinDist: i64 = 0x8;
                pub const flWeight0: i64 = 0xC;
                pub const flRelaxationFactor: i64 = 0x10;
            };
            pub const FeVertexMapDesc_t = struct {
                pub const sName: i64 = 0x0;
                pub const nColor: i64 = 0xC;
                pub const nFlags: i64 = 0x10;
                pub const nNameHash: i64 = 0x8;
                pub const nMapOffset: i64 = 0x18;
                pub const nVertexBase: i64 = 0x14;
                pub const nVertexCount: i64 = 0x16;
                pub const vCenterOfMass: i64 = 0x20;
                pub const nNodeListCount: i64 = 0x32;
                pub const nNodeListOffset: i64 = 0x1C;
                pub const nScaleSourceNode: i64 = 0x30;
                pub const flVolumetricSolveStrength: i64 = 0x2C;
            };
            pub const PhysFeModelDesc_t = struct {
                pub const m_Rods: i64 = 0x168;
                pub const m_Tris: i64 = 0x558;
                pub const m_Quads: i64 = 0xA8;
                pub const m_Ropes: i64 = 0x60;
                pub const m_Prisms: i64 = 0xF0;
                pub const m_Twists: i64 = 0x180;
                pub const m_Effects: i64 = 0x650;
                pub const m_CtrlHash: i64 = 0x0;
                pub const m_CtrlName: i64 = 0x18;
                pub const m_InitPose: i64 = 0x150;
                pub const m_SimdRods: i64 = 0x120;
                pub const m_SimdTris: i64 = 0xD8;
                pub const m_BoxRigids: i64 = 0x590;
                pub const m_FreeNodes: i64 = 0x450;
                pub const m_NodeBases: i64 = 0x78;
                pub const m_SDFRigids: i64 = 0x578;
                pub const m_SimdQuads: i64 = 0xC0;
                pub const m_flWindage: i64 = 0x6E8;
                pub const m_AxialEdges: i64 = 0x240;
                pub const m_FitWeights: i64 = 0x480;
                pub const m_LocalForce: i64 = 0x390;
                pub const m_LockToGoal: i64 = 0x680;
                pub const m_SimdPrisms: i64 = 0x108;
                pub const m_VertexMaps: i64 = 0x620;
                pub const m_flWindDrag: i64 = 0x6EC;
                pub const m_nNodeCount: i64 = 0x40;
                pub const m_nRopeCount: i64 = 0x58;
                pub const m_nTreeDepth: i64 = 0x54;
                pub const m_nTriCount1: i64 = 0x570;
                pub const m_nTriCount2: i64 = 0x572;
                pub const m_CtrlOffsets: i64 = 0x270;
                pub const m_DynKinLinks: i64 = 0x1C8;
                pub const m_FitMatrices: i64 = 0x468;
                pub const m_FollowNodes: i64 = 0x2A0;
                pub const m_HingeLimits: i64 = 0x198;
                pub const m_JiggleBones: i64 = 0x510;
                pub const m_MorphLayers: i64 = 0x5F0;
                pub const m_SkelParents: i64 = 0x698;
                pub const m_SourceElems: i64 = 0x528;
                pub const m_TreeParents: i64 = 0x408;
                pub const m_nQuadCount1: i64 = 0x50;
                pub const m_nQuadCount2: i64 = 0x52;
                pub const m_KelagerBends: i64 = 0x4E0;
                pub const m_LockToParent: i64 = 0x668;
                pub const m_MorphSetData: i64 = 0x608;
                pub const m_SimdRodsAnim: i64 = 0x138;
                pub const m_SphereRigids: i64 = 0x3D8;
                pub const m_TreeChildren: i64 = 0x438;
                pub const m_flLocalDrag1: i64 = 0x720;
                pub const m_flLocalForce: i64 = 0x38;
                pub const m_nStaticNodes: i64 = 0x42;
                pub const m_CtrlOsOffsets: i64 = 0x288;
                pub const m_LocalRotation: i64 = 0x378;
                pub const m_NodeInvMasses: i64 = 0x258;
                pub const m_SimdNodeBases: i64 = 0x90;
                pub const m_AnimStrayRadii: i64 = 0x4B0;
                pub const m_BoneMergeLinks: i64 = 0x1E0;
                pub const m_NodeIntegrator: i64 = 0x2D0;
                pub const m_NodeStrayBoxes: i64 = 0x228;
                pub const m_ReverseOffsets: i64 = 0x498;
                pub const m_VertexSetNames: i64 = 0x5C0;
                pub const m_nReservedUint8: i64 = 0x574;
                pub const m_nSimdTriCount1: i64 = 0x48;
                pub const m_nSimdTriCount2: i64 = 0x4A;
                pub const m_CollisionPlanes: i64 = 0x2B8;
                pub const m_CtrlSoftOffsets: i64 = 0x4F8;
                pub const m_DynNodeFriction: i64 = 0x360;
                pub const m_VertexMapValues: i64 = 0x638;
                pub const m_flLocalRotation: i64 = 0x3C;
                pub const m_nSimdQuadCount1: i64 = 0x4C;
                pub const m_nSimdQuadCount2: i64 = 0x4E;
                pub const m_AntiTunnelProbes: i64 = 0x1F8;
                pub const m_DynNodeVertexSet: i64 = 0x5A8;
                pub const m_DynNodeWindBases: i64 = 0x6B0;
                pub const m_SpringIntegrator: i64 = 0x2E8;
                pub const m_nExtraIterations: i64 = 0x577;
                pub const m_nStaticNodeFlags: i64 = 0x30;
                pub const m_flMotionSmoothCDT: i64 = 0x71C;
                pub const m_nDynamicNodeFlags: i64 = 0x34;
                pub const m_AntiTunnelBytecode: i64 = 0x1B0;
                pub const m_LegacyStretchForce: i64 = 0x330;
                pub const m_NodeCollisionRadii: i64 = 0x348;
                pub const m_SimdAnimStrayRadii: i64 = 0x4C8;
                pub const m_TreeCollisionMasks: i64 = 0x420;
                pub const m_flInternalPressure: i64 = 0x6E0;
                pub const m_SelfCollisionLayers: i64 = 0x6C8;
                pub const m_WorldCollisionNodes: i64 = 0x3F0;
                pub const m_flDefaultExpAirDrag: i64 = 0x700;
                pub const m_flDefaultVelAirDrag: i64 = 0x6FC;
                pub const m_nRotLockStaticNodes: i64 = 0x44;
                pub const m_SimdSpringIntegrator: i64 = 0x300;
                pub const m_TaperedCapsuleRigids: i64 = 0x3C0;
                pub const m_WorldCollisionParams: i64 = 0x318;
                pub const m_nExtraGoalIterations: i64 = 0x576;
                pub const m_AntiTunnelTargetNodes: i64 = 0x210;
                pub const m_flDefaultGravityScale: i64 = 0x6F8;
                pub const m_flDefaultTimeDilation: i64 = 0x6E4;
                pub const m_flDefaultThreadStretch: i64 = 0x6F4;
                pub const m_RigidColliderPriorities: i64 = 0x5D8;
                pub const m_TaperedCapsuleStretches: i64 = 0x3A8;
                pub const m_flDefaultExpQuadAirDrag: i64 = 0x708;
                pub const m_flDefaultSurfaceStretch: i64 = 0x6F0;
                pub const m_flDefaultVelQuadAirDrag: i64 = 0x704;
                pub const m_flRodVelocitySmoothRate: i64 = 0x70C;
                pub const m_flQuadVelocitySmoothRate: i64 = 0x710;
                pub const m_nExtraPressureIterations: i64 = 0x575;
                pub const m_nFirstPositionDrivenNode: i64 = 0x46;
                pub const m_flAddWorldCollisionRadius: i64 = 0x714;
                pub const m_GoalDampedSpringIntegrators: i64 = 0x540;
                pub const m_nRodVelocitySmoothIterations: i64 = 0x724;
                pub const m_nQuadVelocitySmoothIterations: i64 = 0x726;
                pub const m_flDefaultVolumetricSolveAmount: i64 = 0x718;
                pub const m_nNodeBaseJiggleboneDependsCount: i64 = 0x56;
            };
            pub const CFeNamedJiggleBone = struct {
                pub const m_transform: i64 = 0x10;
                pub const m_jiggleBone: i64 = 0x34;
                pub const m_nJiggleParent: i64 = 0x30;
                pub const m_strParentBone: i64 = 0x0;
            };
            pub const CGenericShapeProxy = struct {
                pub const m_verts: i64 = 0x30;
            };
            pub const FeCollisionPlane_t = struct {
                pub const m_Plane: i64 = 0x4;
                pub const flStrength: i64 = 0x14;
                pub const nChildNode: i64 = 0x2;
                pub const nCtrlParent: i64 = 0x0;
            };
            pub const FeCtrlSoftOffset_t = struct {
                pub const flAlpha: i64 = 0x10;
                pub const vOffset: i64 = 0x4;
                pub const nCtrlChild: i64 = 0x2;
                pub const nCtrlParent: i64 = 0x0;
            };
            pub const FeMorphLayerDepr_t = struct {
                pub const m_Name: i64 = 0x0;
                pub const m_Nodes: i64 = 0x10;
                pub const m_nFlags: i64 = 0x88;
                pub const m_Gravity: i64 = 0x40;
                pub const m_InitPos: i64 = 0x28;
                pub const m_nNameHash: i64 = 0x8;
                pub const m_GoalDamping: i64 = 0x70;
                pub const m_GoalStrength: i64 = 0x58;
            };
            pub const FeNodeIntegrator_t = struct {
                pub const flGravity: i64 = 0xC;
                pub const flPointDamping: i64 = 0x0;
                pub const flAnimationForceAttraction: i64 = 0x4;
                pub const flAnimationVertexAttraction: i64 = 0x8;
            };
            pub const FeProxyVertexMap_t = struct {
                pub const m_Name: i64 = 0x0;
                pub const m_flWeight: i64 = 0x8;
            };
            pub const FeVertexMapBuild_t = struct {
                pub const m_Color: i64 = 0xC;
                pub const m_Weights: i64 = 0x18;
                pub const m_nNameHash: i64 = 0x8;
                pub const m_VertexMapName: i64 = 0x0;
                pub const m_nScaleSourceNode: i64 = 0x14;
                pub const m_flVolumetricSolveStrength: i64 = 0x10;
            };
            pub const RnSoftbodySpring_t = struct {
                pub const m_flLength: i64 = 0x4;
                pub const m_nParticle: i64 = 0x0;
            };
            pub const FeAnimStrayRadius_t = struct {
                pub const nNode: i64 = 0x0;
                pub const flMaxDist: i64 = 0x4;
                pub const flRelaxationFactor: i64 = 0x8;
            };
            pub const FeAntiTunnelProbe_t = struct {
                pub const flBias: i64 = 0x18;
                pub const nBegin: i64 = 0xC;
                pub const nCount: i64 = 0xA;
                pub const nFlags: i64 = 0x4;
                pub const flWeight: i64 = 0x0;
                pub const nProbeNode: i64 = 0x8;
                pub const flCurvatureRadius: i64 = 0x14;
                pub const flActivationDistance: i64 = 0x10;
            };
            pub const FeHingeLimitBuild_t = struct {
                pub const nNode: i64 = 0x0;
                pub const nFlags: i64 = 0xC;
                pub const flLimitCW: i64 = 0x10;
                pub const flLimitCCW: i64 = 0x14;
            };
            pub const FeStiffHingeBuild_t = struct {
                pub const nNode: i64 = 0x14;
                pub const flMaxAngle: i64 = 0x0;
                pub const flStrength: i64 = 0x4;
                pub const flMotionBias: i64 = 0x8;
            };
            pub const FeTwistConstraint_t = struct {
                pub const nNodeEnd: i64 = 0x2;
                pub const nNodeOrient: i64 = 0x0;
                pub const flSwingRelax: i64 = 0x8;
                pub const flTwistRelax: i64 = 0x4;
            };
            pub const PhysicsParticleId_t = struct {
                pub const m_Value: i64 = 0x0;
            };
            pub const RnSoftbodyCapsule_t = struct {
                pub const m_vCenter: i64 = 0x0;
                pub const m_flRadius: i64 = 0x18;
                pub const m_nParticle: i64 = 0x1C;
            };
            pub const CFeIndexedJiggleBone = struct {
                pub const m_nNode: i64 = 0x0;
                pub const m_jiggleBone: i64 = 0x8;
                pub const m_nJiggleParent: i64 = 0x4;
            };
            pub const FeBuildSphereRigid_t = struct {
                pub const m_nPriority: i64 = 0x20;
                pub const m_nVertexMapHash: i64 = 0x24;
                pub const m_nAntitunnelGroupBits: i64 = 0x28;
            };
            pub const FeSpringIntegrator_t = struct {
                pub const nNode: i64 = 0x0;
                pub const flNodeWeight0: i64 = 0x10;
                pub const flSpringDamping: i64 = 0xC;
                pub const flSpringConstant: i64 = 0x8;
                pub const flSpringRestLength: i64 = 0x4;
            };
            pub const IPhysicsParticleRope = struct {

            };
            pub const RnCompoundTreeNode_t = struct {
                pub const m_vMax: i64 = 0xC;
                pub const m_vMin: i64 = 0x0;
                pub const m_nType: i64 = 0x0;
                pub const m_nSubtreeEndOrCompoundId: i64 = 0x0;
            };
            pub const RnSoftbodyParticle_t = struct {
                pub const m_flMassInv: i64 = 0x0;
            };
            pub const FeNodeReverseOffset_t = struct {
                pub const vOffset: i64 = 0x0;
                pub const nBoneCtrl: i64 = 0xC;
                pub const nTargetNode: i64 = 0xE;
            };
            pub const FeSimdRodConstraint_t = struct {
                pub const nNode: i64 = 0x0;
                pub const f4MaxDist: i64 = 0x10;
                pub const f4MinDist: i64 = 0x20;
                pub const f4Weight0: i64 = 0x30;
                pub const f4RelaxationFactor: i64 = 0x40;
            };
            pub const VertexPositionColor_t = struct {
                pub const m_vPosition: i64 = 0x0;
            };
            pub const CFeVertexMapBuildArray = struct {
                pub const m_Array: i64 = 0x0;
            };
            pub const IPhysAggregateInstance = struct {
                pub const m_pSkeleton: i64 = 0x8;
                pub const m_bIsAxisAligned: i64 = 0x10;
            };
            pub const IPhysicsRagdollControl = struct {

            };
            pub const VertexPositionNormal_t = struct {
                pub const m_vNormal: i64 = 0xC;
                pub const m_vPosition: i64 = 0x0;
            };
            pub const constraint_axislimit_t = struct {
                pub const flMaxRotation: i64 = 0x4;
                pub const flMinRotation: i64 = 0x0;
                pub const flMotorMaxTorque: i64 = 0xC;
                pub const flMotorTargetAngSpeed: i64 = 0x8;
            };
            pub const FeSimdAnimStrayRadius_t = struct {
                pub const nNode: i64 = 0x0;
                pub const flMaxDist: i64 = 0x10;
                pub const flRelaxationFactor: i64 = 0x20;
            };
            pub const FeTaperedCapsuleRigid_t = struct {
                pub const nNode: i64 = 0x20;
                pub const nFlags: i64 = 0x26;
                pub const vSphere: i64 = 0x0;
                pub const nCollisionMask: i64 = 0x22;
                pub const nVertexMapIndex: i64 = 0x24;
            };
            pub const FeAntiTunnelGroupBuild_t = struct {
                pub const m_nCollisionMask: i64 = 0x4;
                pub const m_nVertexMapHash: i64 = 0x0;
            };
            pub const FeAntiTunnelProbeBuild_t = struct {
                pub const flBias: i64 = 0x8;
                pub const nFlags: i64 = 0x10;
                pub const flWeight: i64 = 0x0;
                pub const nProbeNode: i64 = 0x14;
                pub const flCurvature: i64 = 0xC;
                pub const targetNodes: i64 = 0x18;
                pub const flActivationDistance: i64 = 0x4;
            };
            pub const FeRigidColliderIndices_t = struct {
                pub const m_nBoxRigidIndex: i64 = 0x4;
                pub const m_nSDFRigidIndex: i64 = 0x6;
                pub const m_nSphereRigidIndex: i64 = 0x2;
                pub const m_nCollisionPlaneIndex: i64 = 0x8;
                pub const m_nTaperedCapsuleRigidIndex: i64 = 0x0;
            };
            pub const FeSimdSpringIntegrator_t = struct {
                pub const nNode: i64 = 0x0;
                pub const flNodeWeight0: i64 = 0x40;
                pub const flSpringDamping: i64 = 0x30;
                pub const flSpringConstant: i64 = 0x20;
                pub const flSpringRestLength: i64 = 0x10;
            };
            pub const FeWorldCollisionParams_t = struct {
                pub const nListEnd: i64 = 0xA;
                pub const nListBegin: i64 = 0x8;
                pub const flWorldFriction: i64 = 0x0;
                pub const flGroundFriction: i64 = 0x4;
            };
            pub const IPhysicsMotionController = struct {

            };
            pub const IPhysicsPlayerController = struct {

            };
            pub const constraint_hingeparams_t = struct {
                pub const hingeAxis: i64 = 0x18;
                pub const constraint: i64 = 0x28;
                pub const worldPosition: i64 = 0x0;
                pub const worldAxisDirection: i64 = 0xC;
            };
            pub const FeSimdRodConstraintAnim_t = struct {
                pub const nNode: i64 = 0x0;
                pub const f4Weight0: i64 = 0x10;
                pub const f4RelaxationFactor: i64 = 0x20;
            };
            pub const FeTaperedCapsuleStretch_t = struct {
                pub const nNode: i64 = 0x0;
                pub const nDummy: i64 = 0x6;
                pub const flRadius: i64 = 0x8;
                pub const nCollisionMask: i64 = 0x4;
            };
            pub const CollisionDetailLayerInfo_t = struct {
                pub const m_bIsQueryOnly: i64 = 0x10;
                pub const m_bNotPickable: i64 = 0x38;
                pub const m_sDescription: i64 = 0x0;
                pub const m_sFriendlyName: i64 = 0x8;
                pub const m_sParentDetailLayer: i64 = 0x18;
                pub const m_vecSubtreeDetailLayers: i64 = 0x20;
            };
            pub const FeModelSelfCollisionLayer_t = struct {
                pub const m_Name: i64 = 0x0;
                pub const m_Nodes: i64 = 0x8;
                pub const m_nFlags: i64 = 0x24;
                pub const m_nEndIdx: i64 = 0x28;
                pub const m_flParentReaction: i64 = 0x20;
            };
            pub const FeBuildTaperedCapsuleRigid_t = struct {
                pub const m_nPriority: i64 = 0x30;
                pub const m_nVertexMapHash: i64 = 0x34;
                pub const m_nAntitunnelGroupBits: i64 = 0x38;
            };
            pub const constraint_breakableparams_t = struct {
                pub const isActive: i64 = 0x14;
                pub const strength: i64 = 0x0;
                pub const forceLimit: i64 = 0x4;
                pub const torqueLimit: i64 = 0x8;
                pub const bodyMassScale: i64 = 0xC;
            };
            pub const vphysics_save_cphysicsbody_t = struct {
                pub const m_nOldPointer: i64 = 0xE0;
            };
            pub const vphysics_save_ragdoll_control_t = struct {
                pub const m_nBodyCount: i64 = 0x34;
                pub const m_flMaxStretch: i64 = 0x8;
                pub const m_bIgnoreTeleport: i64 = 0xE;
                pub const m_vForceAccumulator: i64 = 0x28;
                pub const m_flMaxSpringFrequency: i64 = 0x4;
                pub const m_flMinSpringFrequency: i64 = 0x0;
                pub const m_bRequiresDynamicBodies: i64 = 0xD;
                pub const m_vLinearVelocityAccumulator: i64 = 0x10;
                pub const m_bSolidCollisionAtZeroWeight: i64 = 0xC;
                pub const m_vAngularVelocityAccumulator: i64 = 0x1C;
            };
            pub const CollisionDetailLayerInfo_t__Name_t = struct {
                pub const m_nNameToken: i64 = 0x0;
                pub const m_sNameString: i64 = 0x8;
            };
            pub const JointAxis_t = struct {
                pub const JOINT_AXIS_X: i64 = 0x0;
                pub const JOINT_AXIS_Y: i64 = 0x1;
                pub const JOINT_AXIS_Z: i64 = 0x2;
                pub const JOINT_AXIS_COUNT: i64 = 0x3;
            };
            pub const JointMotion_t = struct {
                pub const JOINT_MOTION_FREE: i64 = 0x0;
                pub const JOINT_MOTION_COUNT: i64 = 0x2;
                pub const JOINT_MOTION_LOCKED: i64 = 0x1;
            };
            pub const PhysInterfaceId_t = struct {
                pub const PIID_UNKNOWN: i64 = 0x0;
                pub const PIID_NUM_TYPES: i64 = 0x7;
                pub const PIID_IPHYSICSBODY: i64 = 0x1;
                pub const PIID_IPHYSICSJOINT: i64 = 0x3;
                pub const PIID_IPHYSAGGREGATE: i64 = 0x2;
                pub const PIID_IPHYSICSPARTICLEROPE: i64 = 0x5;
                pub const PIID_IPHYSICSRAGDOLLCONTROL: i64 = 0x6;
                pub const PIID_IPHYSICSMOTIONCONTROLLER: i64 = 0x4;
            };
            pub const PhysGenericShapeType_t = struct {
                pub const GENERIC_SHAPE_AABB: i64 = 0x2;
                pub const GENERIC_SHAPE_HULL: i64 = 0x4;
                pub const GENERIC_SHAPE_POINT: i64 = 0x0;
                pub const GENERIC_SHAPE_SPHERE: i64 = 0x1;
                pub const GENERIC_SHAPE_CAPSULE: i64 = 0x3;
            };
            pub const DynamicContinuousContactBehavior_t = struct {
                pub const DYNAMIC_CONTINUOUS_NEVER: i64 = 0x2;
                pub const DYNAMIC_CONTINUOUS_ALWAYS: i64 = 0x1;
                pub const DYNAMIC_CONTINUOUS_ALLOW_IF_REQUESTED_BY_OTHER_BODY: i64 = 0x0;
            };
        };
    };
};
