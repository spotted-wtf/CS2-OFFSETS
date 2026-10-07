public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class worldrenderer_dll {
            public static partial class World_t {
                public const long m_worldNodes = 0x60;
                public const long m_entityLumps = 0xC0;
                public const long m_builderParams = 0x0;
                public const long m_worldLightingInfo = 0x78;
            }
            public static partial class NodeData_t {
                public const long m_vOrigin = 0x0;
                public const long m_vMaxBounds = 0x18;
                public const long m_vMinBounds = 0xC;
                public const long m_worldNodePrefix = 0x28;
            }
            public static partial class WorldNode_t {
                public const long m_rtProxies = 0x60;
                public const long m_layerNames = 0x108;
                public const long m_sceneObjects = 0x0;
                public const long m_grassFileName = 0x138;
                public const long m_nodeLightingInfo = 0x140;
                public const long m_materialOverrides = 0x90;
                public const long m_extraVertexStreams = 0xA8;
                public const long m_clutterSceneObjects = 0x48;
                public const long m_vertexAlbedoStreams = 0xD8;
                public const long m_visClusterMembership = 0x18;
                public const long m_aggregateSceneObjects = 0x30;
                public const long m_bHasBakedGeometryFlag = 0x188;
                public const long m_vertexEmissiveStreams = 0xF0;
                public const long m_sceneObjectLayerIndices = 0x120;
                public const long m_aggregateInstanceStreams = 0xC0;
                public const long m_extraVertexStreamOverrides = 0x78;
            }
            public static partial class ClutterTile_t {
                public const long m_BoundsWs = 0x8;
                public const long m_nLastInstance = 0x4;
                public const long m_nFirstInstance = 0x0;
            }
            public static partial class RTProxyBLAS_t {
                public const long m_boundLs = 0x14;
                public const long m_nBaseVertex = 0xC;
                public const long m_nFirstIndex = 0x0;
                public const long m_nIndexCount = 0x4;
                public const long m_albedoFormat = 0x12;
                public const long m_nVertexCount = 0x10;
                public const long m_nVBByteOffset = 0x8;
                public const long m_vVertexExtentLs = 0x38;
                public const long m_vVertexOriginLs = 0x2C;
            }
            public static partial class SceneObject_t {
                public const long m_skin = 0x50;
                public const long m_nObjectID = 0x0;
                public const long m_renderable = 0x88;
                public const long m_vTintColor = 0x3C;
                public const long m_vTransform = 0x4;
                public const long m_nLODOverride = 0x6A;
                public const long m_renderableModel = 0x80;
                public const long m_vLightingOrigin = 0x5C;
                public const long m_nObjectTypeFlags = 0x58;
                public const long m_flFadeEndDistance = 0x38;
                public const long m_flFadeStartDistance = 0x34;
                public const long m_nOverlayRenderOrder = 0x68;
                public const long m_flEmissiveLightingBoost = 0x74;
                public const long m_nCubeMapPrecomputedHandshake = 0x6C;
                public const long m_nLightProbeVolumePrecomputedHandshake = 0x70;
            }
            public static partial class CEntityIdentity {
                public const long m_name = 0x18;
                public const long m_flags = 0x30;
                public const long m_pNext = 0x58;
                public const long m_pPrev = 0x50;
                public const long m_PathIndex = 0x40;
                public const long m_pAttributes = 0x48;
                public const long m_designerName = 0x20;
                public const long m_pNextByClass = 0x68;
                public const long m_pPrevByClass = 0x60;
                public const long m_worldGroupId = 0x38;
                public const long m_fDataObjectTypes = 0x3C;
                public const long m_nameStringTableIndex = 0x14;
            }
            public static partial class CEntityInstance {
                public const long m_pEntity = 0x10;
                public const long m_CScriptComponent = 0x28;
                public const long m_iszPrivateVScripts = 0x8;
            }
            public static partial class CEntityComponent {

            }
            public static partial class CScriptComponent {
                public const long m_scriptClassName = 0x30;
            }
            public static partial class CVoxelVisibility {
                public const long m_NodeBlock = 0x6C;
                public const long m_MasksBlock = 0x8C;
                public const long m_flGridSize = 0x60;
                public const long m_nVisBlocks = 0x94;
                public const long m_vMaxBounds = 0x54;
                public const long m_vMinBounds = 0x48;
                public const long m_RegionBlock = 0x74;
                public const long m_nBaseClusterCount = 0x40;
                public const long m_nPVSBytesPerCluster = 0x44;
                public const long m_EnclosedClustersBlock = 0x84;
                public const long m_nSkyVisibilityCluster = 0x64;
                public const long m_nSunVisibilityCluster = 0x68;
                public const long m_EnclosedClusterListBlock = 0x7C;
            }
            public static partial class MaterialOverride_t {
                public const long m_pMaterial = 0x10;
                public const long m_nDrawCallIndex = 0x8;
                public const long m_nSubSceneObject = 0x4;
                public const long m_vLinearTintColor = 0x18;
            }
            public static partial class VMapResourceData_t {

            }
            public static partial class AggregateLODSetup_t {
                public const long m_vLODOrigin = 0x0;
                public const long m_fMaxObjectScale = 0xC;
                public const long m_fSwitchDistances = 0x10;
            }
            public static partial class AggregateMeshInfo_t {
                public const long m_vTintColor = 0xC;
                public const long m_objectFlags = 0x10;
                public const long m_bHasTransform = 0x5;
                public const long m_nLODGroupMask = 0x6;
                public const long m_nDrawCallIndex = 0x8;
                public const long m_nLODSetupIndex = 0xA;
                public const long m_fEmissiveFactor = 0x28;
                public const long m_instanceStreams = 0x24;
                public const long m_nInstanceStreamOffset = 0x18;
                public const long m_nVisClusterMemberCount = 0x4;
                public const long m_nVisClusterMemberOffset = 0x0;
                public const long m_nVertexAlbedoStreamOffset = 0x1C;
                public const long m_nVertexEmissiveStreamOffset = 0x20;
                public const long m_nLightProbeVolumePrecomputedHandshake = 0x14;
            }
            public static partial class BakedLightingInfo_t {
                public const long m_lightMaps = 0x18;
                public const long m_bakedShadows = 0x30;
                public const long m_nLPVEncoding = 0x13;
                public const long m_nVradQuality = 0x16;
                public const long m_bHasLightmaps = 0x10;
                public const long m_vLightmapUvScale = 0x8;
                public const long m_nLightmapEncoding = 0x14;
                public const long m_bCompressionEnabled = 0x12;
                public const long m_bBakedShadowsGamma20 = 0x11;
                public const long m_nChartPackIterations = 0x15;
                public const long m_nLightmapVersionNumber = 0x0;
                public const long m_nLightmapGameVersionNumber = 0x4;
            }
            public static partial class ClutterSceneObject_t {
                public const long m_flags = 0x18;
                public const long m_tiles = 0x80;
                public const long m_Bounds = 0x0;
                public const long m_nLayer = 0x1C;
                public const long m_flEndCullSize = 0xA8;
                public const long m_materialGroup = 0xA0;
                public const long m_instanceScales = 0x50;
                public const long m_flBeginCullSize = 0xA4;
                public const long m_renderableModel = 0x98;
                public const long m_instanceTintSrgb = 0x68;
                public const long m_instancePositions = 0x20;
            }
            public static partial class EntityKeyValueData_t {
                public const long m_connections = 0x8;
                public const long m_keyValuesData = 0x20;
            }
            public static partial class PermEntityLumpData_t {
                public const long m_name = 0x8;
                public const long m_childLumps = 0x10;
                public const long m_entityKeyValues = 0x28;
            }
            public static partial class WorldBuilderParams_t {
                public const long m_bakedLightingInfo = 0x8;
                public const long m_nCompileTimestamp = 0x50;
                public const long m_bBuildBakedLighting = 0x4;
                public const long m_flMinDrawVolumeSize = 0x0;
                public const long m_nCompileFingerprint = 0x58;
                public const long m_bAggregateInstanceStreams = 0x5;
            }
            public static partial class RTProxyInstanceInfo_t {
                public const long m_nFlags = 0x0;
                public const long m_nBLASCount = 0x4;
                public const long m_nBLASIndex = 0x8;
                public const long m_albedoFormat = 0x1;
                public const long m_emissiveFormat = 0x2;
                public const long m_vTintColorSRGB = 0x48;
                public const long m_fEmissiveFactor = 0x14;
                public const long m_mWorldFromLocal = 0x18;
                public const long m_nVertexAlbedoByteOffset = 0xC;
                public const long m_nVertexEmissiveByteOffset = 0x10;
            }
            public static partial class VoxelVisBlockOffset_t {
                public const long m_nOffset = 0x0;
                public const long m_nElementCount = 0x4;
            }
            public static partial class AggregateSceneObject_t {
                public const long m_nLayer = 0x8;
                public const long m_allFlags = 0x0;
                public const long m_anyFlags = 0x4;
                public const long m_lodSetups = 0x28;
                public const long m_instanceStream = 0xA;
                public const long m_aggregateMeshes = 0x10;
                public const long m_renderableModel = 0x70;
                public const long m_fragmentTransforms = 0x58;
                public const long m_vertexAlbedoStream = 0xC;
                public const long m_vertexEmissiveStream = 0xE;
                public const long m_visClusterMembership = 0x40;
            }
            public static partial class EntityIOConnectionData_t {
                public const long m_flDelay = 0x28;
                public const long m_paramMap = 0x30;
                public const long m_inputName = 0x18;
                public const long m_outputName = 0x0;
                public const long m_targetName = 0x10;
                public const long m_targetType = 0x8;
                public const long m_nTimesToFire = 0x2C;
                public const long m_overrideParam = 0x20;
            }
            public static partial class BaseSceneObjectOverride_t {
                public const long m_nSceneObjectIndex = 0x0;
            }
            public static partial class ExtraVertexStreamOverride_t {
                public const long m_nDrawCallIndex = 0x8;
                public const long m_nSubSceneObject = 0x4;
                public const long m_extraBufferBinding = 0x10;
                public const long m_nAdditionalMeshDrawPrimitiveFlags = 0xC;
            }
            public static partial class WorldNodeOnDiskBufferData_t {
                public const long m_pData = 0x20;
                public const long m_nElementCount = 0x0;
                public const long m_inputLayoutFields = 0x8;
                public const long m_nElementSizeInBytes = 0x4;
            }
            public static partial class AggregateRTProxySceneObject_t {
                public const long m_BLASes = 0x8;
                public const long m_IBData = 0x48;
                public const long m_VBData = 0x38;
                public const long m_nLayer = 0x0;
                public const long m_Instances = 0x20;
                public const long m_InstanceAlbedoData = 0x58;
                public const long m_InstanceEmissiveData = 0x68;
            }
            public static partial class AggregateInstanceStreamOnDiskData_t {
                public const long m_BufferData = 0x8;
                public const long m_DecodedSize = 0x0;
            }
            public static partial class InfoForResourceTypeVMapResourceData_t {

            }
            public static partial class AggregateVertexAlbedoStreamOnDiskData_t {
                public const long m_BufferData = 0x0;
            }
            public static partial class AggregateVertexEmissiveStreamOnDiskData_t {
                public const long m_BufferData = 0x0;
            }
            public static partial class BakedLightingInfo_t__BakedShadowAssignment_t {
                public const long m_nMapHash = 0x4;
                public const long m_nLightHash = 0x0;
                public const long m_nShadowChannel = 0x8;
            }
            public static partial class ObjectTypeFlags_t {
                public const long OBJECT_TYPE_NONE = 0x0;
                public const long OBJECT_TYPE_MODEL = 0x8;
                public const long OBJECT_TYPE_OVERLAY = 0x2000;
                public const long OBJECT_TYPE_NO_SHADOWS = 0x20;
                public const long OBJECT_TYPE_BLOCK_LIGHT = 0x10;
                public const long OBJECT_TYPE_BAKED_GEOMETRY = 0x20000;
                public const long OBJECT_TYPE_MODEL_HAS_LODS = 0x800;
                public const long OBJECT_TYPE_HAS_EMISSIVE_GI = 0x100000;
                public const long OBJECT_TYPE_STATIC_CUBE_MAP = 0x8000;
                public const long OBJECT_TYPE_RENDER_TO_CUBEMAPS = 0x400;
                public const long OBJECT_TYPE_DISABLE_VIS_CULLING = 0x10000;
                public const long OBJECT_TYPE_RENDER_WITH_DYNAMIC = 0x200;
                public const long OBJECT_TYPE_HAS_AGGREGATE_RTPROXY = 0x80000;
                public const long OBJECT_TYPE_NEEDS_DYNAMIC_SHADOWS = 0x40000;
                public const long OBJECT_TYPE_PRECOMPUTED_VISMEMBERS = 0x4000;
                public const long OBJECT_TYPE_DISABLED_IN_LOW_QUALITY = 0x80;
                public const long OBJECT_TYPE_WORLDSPACE_TEXURE_BLEND = 0x40;
            }
            public static partial class RTProxyInstanceFlags_t {
                public const long RTPROXY_INSTANCE_FLAG_NONE = 0x0;
                public const long RTPROXY_INSTANCE_UNIQUE_MESH = 0x1;
            }
            public static partial class AggregateInstanceStream_t {
                public const long AGGREGATE_INSTANCE_STREAM_NONE = 0x0;
                public const long AGGREGATE_INSTANCE_STREAM_VERTEXTINT_UNORM8 = 0x2;
                public const long AGGREGATE_INSTANCE_STREAM_LIGHTMAPUV_UNORM16 = 0x1;
                public const long AGGREGATE_INSTANCE_STREAM_VERTEXBLEND_UNORM8 = 0x4;
            }
        }
    }
}
