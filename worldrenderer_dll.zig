pub const cs2_dumper = struct {
    pub const schemas = struct {
        pub const worldrenderer_dll = struct {
            pub const World_t = struct {
                pub const m_worldNodes: i64 = 0x60;
                pub const m_entityLumps: i64 = 0xC0;
                pub const m_builderParams: i64 = 0x0;
                pub const m_worldLightingInfo: i64 = 0x78;
            };
            pub const NodeData_t = struct {
                pub const m_vOrigin: i64 = 0x0;
                pub const m_vMaxBounds: i64 = 0x18;
                pub const m_vMinBounds: i64 = 0xC;
                pub const m_worldNodePrefix: i64 = 0x28;
            };
            pub const WorldNode_t = struct {
                pub const m_rtProxies: i64 = 0x60;
                pub const m_layerNames: i64 = 0x108;
                pub const m_sceneObjects: i64 = 0x0;
                pub const m_grassFileName: i64 = 0x138;
                pub const m_nodeLightingInfo: i64 = 0x140;
                pub const m_materialOverrides: i64 = 0x90;
                pub const m_extraVertexStreams: i64 = 0xA8;
                pub const m_clutterSceneObjects: i64 = 0x48;
                pub const m_vertexAlbedoStreams: i64 = 0xD8;
                pub const m_visClusterMembership: i64 = 0x18;
                pub const m_aggregateSceneObjects: i64 = 0x30;
                pub const m_bHasBakedGeometryFlag: i64 = 0x188;
                pub const m_vertexEmissiveStreams: i64 = 0xF0;
                pub const m_sceneObjectLayerIndices: i64 = 0x120;
                pub const m_aggregateInstanceStreams: i64 = 0xC0;
                pub const m_extraVertexStreamOverrides: i64 = 0x78;
            };
            pub const ClutterTile_t = struct {
                pub const m_BoundsWs: i64 = 0x8;
                pub const m_nLastInstance: i64 = 0x4;
                pub const m_nFirstInstance: i64 = 0x0;
            };
            pub const RTProxyBLAS_t = struct {
                pub const m_boundLs: i64 = 0x14;
                pub const m_nBaseVertex: i64 = 0xC;
                pub const m_nFirstIndex: i64 = 0x0;
                pub const m_nIndexCount: i64 = 0x4;
                pub const m_albedoFormat: i64 = 0x12;
                pub const m_nVertexCount: i64 = 0x10;
                pub const m_nVBByteOffset: i64 = 0x8;
                pub const m_vVertexExtentLs: i64 = 0x38;
                pub const m_vVertexOriginLs: i64 = 0x2C;
            };
            pub const SceneObject_t = struct {
                pub const m_skin: i64 = 0x50;
                pub const m_nObjectID: i64 = 0x0;
                pub const m_renderable: i64 = 0x88;
                pub const m_vTintColor: i64 = 0x3C;
                pub const m_vTransform: i64 = 0x4;
                pub const m_nLODOverride: i64 = 0x6A;
                pub const m_renderableModel: i64 = 0x80;
                pub const m_vLightingOrigin: i64 = 0x5C;
                pub const m_nObjectTypeFlags: i64 = 0x58;
                pub const m_flFadeEndDistance: i64 = 0x38;
                pub const m_flFadeStartDistance: i64 = 0x34;
                pub const m_nOverlayRenderOrder: i64 = 0x68;
                pub const m_flEmissiveLightingBoost: i64 = 0x74;
                pub const m_nCubeMapPrecomputedHandshake: i64 = 0x6C;
                pub const m_nLightProbeVolumePrecomputedHandshake: i64 = 0x70;
            };
            pub const CEntityIdentity = struct {
                pub const m_name: i64 = 0x18;
                pub const m_flags: i64 = 0x30;
                pub const m_pNext: i64 = 0x58;
                pub const m_pPrev: i64 = 0x50;
                pub const m_PathIndex: i64 = 0x40;
                pub const m_pAttributes: i64 = 0x48;
                pub const m_designerName: i64 = 0x20;
                pub const m_pNextByClass: i64 = 0x68;
                pub const m_pPrevByClass: i64 = 0x60;
                pub const m_worldGroupId: i64 = 0x38;
                pub const m_fDataObjectTypes: i64 = 0x3C;
                pub const m_nameStringTableIndex: i64 = 0x14;
            };
            pub const CEntityInstance = struct {
                pub const m_pEntity: i64 = 0x10;
                pub const m_CScriptComponent: i64 = 0x28;
                pub const m_iszPrivateVScripts: i64 = 0x8;
            };
            pub const CEntityComponent = struct {

            };
            pub const CScriptComponent = struct {
                pub const m_scriptClassName: i64 = 0x30;
            };
            pub const CVoxelVisibility = struct {
                pub const m_NodeBlock: i64 = 0x6C;
                pub const m_MasksBlock: i64 = 0x8C;
                pub const m_flGridSize: i64 = 0x60;
                pub const m_nVisBlocks: i64 = 0x94;
                pub const m_vMaxBounds: i64 = 0x54;
                pub const m_vMinBounds: i64 = 0x48;
                pub const m_RegionBlock: i64 = 0x74;
                pub const m_nBaseClusterCount: i64 = 0x40;
                pub const m_nPVSBytesPerCluster: i64 = 0x44;
                pub const m_EnclosedClustersBlock: i64 = 0x84;
                pub const m_nSkyVisibilityCluster: i64 = 0x64;
                pub const m_nSunVisibilityCluster: i64 = 0x68;
                pub const m_EnclosedClusterListBlock: i64 = 0x7C;
            };
            pub const MaterialOverride_t = struct {
                pub const m_pMaterial: i64 = 0x10;
                pub const m_nDrawCallIndex: i64 = 0x8;
                pub const m_nSubSceneObject: i64 = 0x4;
                pub const m_vLinearTintColor: i64 = 0x18;
            };
            pub const VMapResourceData_t = struct {

            };
            pub const AggregateLODSetup_t = struct {
                pub const m_vLODOrigin: i64 = 0x0;
                pub const m_fMaxObjectScale: i64 = 0xC;
                pub const m_fSwitchDistances: i64 = 0x10;
            };
            pub const AggregateMeshInfo_t = struct {
                pub const m_vTintColor: i64 = 0xC;
                pub const m_objectFlags: i64 = 0x10;
                pub const m_bHasTransform: i64 = 0x5;
                pub const m_nLODGroupMask: i64 = 0x6;
                pub const m_nDrawCallIndex: i64 = 0x8;
                pub const m_nLODSetupIndex: i64 = 0xA;
                pub const m_fEmissiveFactor: i64 = 0x28;
                pub const m_instanceStreams: i64 = 0x24;
                pub const m_nInstanceStreamOffset: i64 = 0x18;
                pub const m_nVisClusterMemberCount: i64 = 0x4;
                pub const m_nVisClusterMemberOffset: i64 = 0x0;
                pub const m_nVertexAlbedoStreamOffset: i64 = 0x1C;
                pub const m_nVertexEmissiveStreamOffset: i64 = 0x20;
                pub const m_nLightProbeVolumePrecomputedHandshake: i64 = 0x14;
            };
            pub const BakedLightingInfo_t = struct {
                pub const m_lightMaps: i64 = 0x18;
                pub const m_bakedShadows: i64 = 0x30;
                pub const m_nLPVEncoding: i64 = 0x13;
                pub const m_nVradQuality: i64 = 0x16;
                pub const m_bHasLightmaps: i64 = 0x10;
                pub const m_vLightmapUvScale: i64 = 0x8;
                pub const m_nLightmapEncoding: i64 = 0x14;
                pub const m_bCompressionEnabled: i64 = 0x12;
                pub const m_bBakedShadowsGamma20: i64 = 0x11;
                pub const m_nChartPackIterations: i64 = 0x15;
                pub const m_nLightmapVersionNumber: i64 = 0x0;
                pub const m_nLightmapGameVersionNumber: i64 = 0x4;
            };
            pub const ClutterSceneObject_t = struct {
                pub const m_flags: i64 = 0x18;
                pub const m_tiles: i64 = 0x80;
                pub const m_Bounds: i64 = 0x0;
                pub const m_nLayer: i64 = 0x1C;
                pub const m_flEndCullSize: i64 = 0xA8;
                pub const m_materialGroup: i64 = 0xA0;
                pub const m_instanceScales: i64 = 0x50;
                pub const m_flBeginCullSize: i64 = 0xA4;
                pub const m_renderableModel: i64 = 0x98;
                pub const m_instanceTintSrgb: i64 = 0x68;
                pub const m_instancePositions: i64 = 0x20;
            };
            pub const EntityKeyValueData_t = struct {
                pub const m_connections: i64 = 0x8;
                pub const m_keyValuesData: i64 = 0x20;
            };
            pub const PermEntityLumpData_t = struct {
                pub const m_name: i64 = 0x8;
                pub const m_childLumps: i64 = 0x10;
                pub const m_entityKeyValues: i64 = 0x28;
            };
            pub const WorldBuilderParams_t = struct {
                pub const m_bakedLightingInfo: i64 = 0x8;
                pub const m_nCompileTimestamp: i64 = 0x50;
                pub const m_bBuildBakedLighting: i64 = 0x4;
                pub const m_flMinDrawVolumeSize: i64 = 0x0;
                pub const m_nCompileFingerprint: i64 = 0x58;
                pub const m_bAggregateInstanceStreams: i64 = 0x5;
            };
            pub const RTProxyInstanceInfo_t = struct {
                pub const m_nFlags: i64 = 0x0;
                pub const m_nBLASCount: i64 = 0x4;
                pub const m_nBLASIndex: i64 = 0x8;
                pub const m_albedoFormat: i64 = 0x1;
                pub const m_emissiveFormat: i64 = 0x2;
                pub const m_vTintColorSRGB: i64 = 0x48;
                pub const m_fEmissiveFactor: i64 = 0x14;
                pub const m_mWorldFromLocal: i64 = 0x18;
                pub const m_nVertexAlbedoByteOffset: i64 = 0xC;
                pub const m_nVertexEmissiveByteOffset: i64 = 0x10;
            };
            pub const VoxelVisBlockOffset_t = struct {
                pub const m_nOffset: i64 = 0x0;
                pub const m_nElementCount: i64 = 0x4;
            };
            pub const AggregateSceneObject_t = struct {
                pub const m_nLayer: i64 = 0x8;
                pub const m_allFlags: i64 = 0x0;
                pub const m_anyFlags: i64 = 0x4;
                pub const m_lodSetups: i64 = 0x28;
                pub const m_instanceStream: i64 = 0xA;
                pub const m_aggregateMeshes: i64 = 0x10;
                pub const m_renderableModel: i64 = 0x70;
                pub const m_fragmentTransforms: i64 = 0x58;
                pub const m_vertexAlbedoStream: i64 = 0xC;
                pub const m_vertexEmissiveStream: i64 = 0xE;
                pub const m_visClusterMembership: i64 = 0x40;
            };
            pub const EntityIOConnectionData_t = struct {
                pub const m_flDelay: i64 = 0x28;
                pub const m_paramMap: i64 = 0x30;
                pub const m_inputName: i64 = 0x18;
                pub const m_outputName: i64 = 0x0;
                pub const m_targetName: i64 = 0x10;
                pub const m_targetType: i64 = 0x8;
                pub const m_nTimesToFire: i64 = 0x2C;
                pub const m_overrideParam: i64 = 0x20;
            };
            pub const BaseSceneObjectOverride_t = struct {
                pub const m_nSceneObjectIndex: i64 = 0x0;
            };
            pub const ExtraVertexStreamOverride_t = struct {
                pub const m_nDrawCallIndex: i64 = 0x8;
                pub const m_nSubSceneObject: i64 = 0x4;
                pub const m_extraBufferBinding: i64 = 0x10;
                pub const m_nAdditionalMeshDrawPrimitiveFlags: i64 = 0xC;
            };
            pub const WorldNodeOnDiskBufferData_t = struct {
                pub const m_pData: i64 = 0x20;
                pub const m_nElementCount: i64 = 0x0;
                pub const m_inputLayoutFields: i64 = 0x8;
                pub const m_nElementSizeInBytes: i64 = 0x4;
            };
            pub const AggregateRTProxySceneObject_t = struct {
                pub const m_BLASes: i64 = 0x8;
                pub const m_IBData: i64 = 0x48;
                pub const m_VBData: i64 = 0x38;
                pub const m_nLayer: i64 = 0x0;
                pub const m_Instances: i64 = 0x20;
                pub const m_InstanceAlbedoData: i64 = 0x58;
                pub const m_InstanceEmissiveData: i64 = 0x68;
            };
            pub const AggregateInstanceStreamOnDiskData_t = struct {
                pub const m_BufferData: i64 = 0x8;
                pub const m_DecodedSize: i64 = 0x0;
            };
            pub const InfoForResourceTypeVMapResourceData_t = struct {

            };
            pub const AggregateVertexAlbedoStreamOnDiskData_t = struct {
                pub const m_BufferData: i64 = 0x0;
            };
            pub const AggregateVertexEmissiveStreamOnDiskData_t = struct {
                pub const m_BufferData: i64 = 0x0;
            };
            pub const BakedLightingInfo_t__BakedShadowAssignment_t = struct {
                pub const m_nMapHash: i64 = 0x4;
                pub const m_nLightHash: i64 = 0x0;
                pub const m_nShadowChannel: i64 = 0x8;
            };
            pub const ObjectTypeFlags_t = struct {
                pub const OBJECT_TYPE_NONE: i64 = 0x0;
                pub const OBJECT_TYPE_MODEL: i64 = 0x8;
                pub const OBJECT_TYPE_OVERLAY: i64 = 0x2000;
                pub const OBJECT_TYPE_NO_SHADOWS: i64 = 0x20;
                pub const OBJECT_TYPE_BLOCK_LIGHT: i64 = 0x10;
                pub const OBJECT_TYPE_BAKED_GEOMETRY: i64 = 0x20000;
                pub const OBJECT_TYPE_MODEL_HAS_LODS: i64 = 0x800;
                pub const OBJECT_TYPE_HAS_EMISSIVE_GI: i64 = 0x100000;
                pub const OBJECT_TYPE_STATIC_CUBE_MAP: i64 = 0x8000;
                pub const OBJECT_TYPE_RENDER_TO_CUBEMAPS: i64 = 0x400;
                pub const OBJECT_TYPE_DISABLE_VIS_CULLING: i64 = 0x10000;
                pub const OBJECT_TYPE_RENDER_WITH_DYNAMIC: i64 = 0x200;
                pub const OBJECT_TYPE_HAS_AGGREGATE_RTPROXY: i64 = 0x80000;
                pub const OBJECT_TYPE_NEEDS_DYNAMIC_SHADOWS: i64 = 0x40000;
                pub const OBJECT_TYPE_PRECOMPUTED_VISMEMBERS: i64 = 0x4000;
                pub const OBJECT_TYPE_DISABLED_IN_LOW_QUALITY: i64 = 0x80;
                pub const OBJECT_TYPE_WORLDSPACE_TEXURE_BLEND: i64 = 0x40;
            };
            pub const RTProxyInstanceFlags_t = struct {
                pub const RTPROXY_INSTANCE_FLAG_NONE: i64 = 0x0;
                pub const RTPROXY_INSTANCE_UNIQUE_MESH: i64 = 0x1;
            };
            pub const AggregateInstanceStream_t = struct {
                pub const AGGREGATE_INSTANCE_STREAM_NONE: i64 = 0x0;
                pub const AGGREGATE_INSTANCE_STREAM_VERTEXTINT_UNORM8: i64 = 0x2;
                pub const AGGREGATE_INSTANCE_STREAM_LIGHTMAPUV_UNORM16: i64 = 0x1;
                pub const AGGREGATE_INSTANCE_STREAM_VERTEXBLEND_UNORM8: i64 = 0x4;
            };
        };
    };
};
