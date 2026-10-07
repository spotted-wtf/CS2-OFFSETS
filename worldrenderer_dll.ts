export namespace cs2_dumper {
    export namespace schemas {
        export namespace worldrenderer_dll {
            export namespace World_t {
                export const m_worldNodes = 0x60;
                export const m_entityLumps = 0xC0;
                export const m_builderParams = 0x0;
                export const m_worldLightingInfo = 0x78;
            }
            export namespace NodeData_t {
                export const m_vOrigin = 0x0;
                export const m_vMaxBounds = 0x18;
                export const m_vMinBounds = 0xC;
                export const m_worldNodePrefix = 0x28;
            }
            export namespace WorldNode_t {
                export const m_rtProxies = 0x60;
                export const m_layerNames = 0x108;
                export const m_sceneObjects = 0x0;
                export const m_grassFileName = 0x138;
                export const m_nodeLightingInfo = 0x140;
                export const m_materialOverrides = 0x90;
                export const m_extraVertexStreams = 0xA8;
                export const m_clutterSceneObjects = 0x48;
                export const m_vertexAlbedoStreams = 0xD8;
                export const m_visClusterMembership = 0x18;
                export const m_aggregateSceneObjects = 0x30;
                export const m_bHasBakedGeometryFlag = 0x188;
                export const m_vertexEmissiveStreams = 0xF0;
                export const m_sceneObjectLayerIndices = 0x120;
                export const m_aggregateInstanceStreams = 0xC0;
                export const m_extraVertexStreamOverrides = 0x78;
            }
            export namespace ClutterTile_t {
                export const m_BoundsWs = 0x8;
                export const m_nLastInstance = 0x4;
                export const m_nFirstInstance = 0x0;
            }
            export namespace RTProxyBLAS_t {
                export const m_boundLs = 0x14;
                export const m_nBaseVertex = 0xC;
                export const m_nFirstIndex = 0x0;
                export const m_nIndexCount = 0x4;
                export const m_albedoFormat = 0x12;
                export const m_nVertexCount = 0x10;
                export const m_nVBByteOffset = 0x8;
                export const m_vVertexExtentLs = 0x38;
                export const m_vVertexOriginLs = 0x2C;
            }
            export namespace SceneObject_t {
                export const m_skin = 0x50;
                export const m_nObjectID = 0x0;
                export const m_renderable = 0x88;
                export const m_vTintColor = 0x3C;
                export const m_vTransform = 0x4;
                export const m_nLODOverride = 0x6A;
                export const m_renderableModel = 0x80;
                export const m_vLightingOrigin = 0x5C;
                export const m_nObjectTypeFlags = 0x58;
                export const m_flFadeEndDistance = 0x38;
                export const m_flFadeStartDistance = 0x34;
                export const m_nOverlayRenderOrder = 0x68;
                export const m_flEmissiveLightingBoost = 0x74;
                export const m_nCubeMapPrecomputedHandshake = 0x6C;
                export const m_nLightProbeVolumePrecomputedHandshake = 0x70;
            }
            export namespace CEntityIdentity {
                export const m_name = 0x18;
                export const m_flags = 0x30;
                export const m_pNext = 0x58;
                export const m_pPrev = 0x50;
                export const m_PathIndex = 0x40;
                export const m_pAttributes = 0x48;
                export const m_designerName = 0x20;
                export const m_pNextByClass = 0x68;
                export const m_pPrevByClass = 0x60;
                export const m_worldGroupId = 0x38;
                export const m_fDataObjectTypes = 0x3C;
                export const m_nameStringTableIndex = 0x14;
            }
            export namespace CEntityInstance {
                export const m_pEntity = 0x10;
                export const m_CScriptComponent = 0x28;
                export const m_iszPrivateVScripts = 0x8;
            }
            export namespace CEntityComponent {

            }
            export namespace CScriptComponent {
                export const m_scriptClassName = 0x30;
            }
            export namespace CVoxelVisibility {
                export const m_NodeBlock = 0x6C;
                export const m_MasksBlock = 0x8C;
                export const m_flGridSize = 0x60;
                export const m_nVisBlocks = 0x94;
                export const m_vMaxBounds = 0x54;
                export const m_vMinBounds = 0x48;
                export const m_RegionBlock = 0x74;
                export const m_nBaseClusterCount = 0x40;
                export const m_nPVSBytesPerCluster = 0x44;
                export const m_EnclosedClustersBlock = 0x84;
                export const m_nSkyVisibilityCluster = 0x64;
                export const m_nSunVisibilityCluster = 0x68;
                export const m_EnclosedClusterListBlock = 0x7C;
            }
            export namespace MaterialOverride_t {
                export const m_pMaterial = 0x10;
                export const m_nDrawCallIndex = 0x8;
                export const m_nSubSceneObject = 0x4;
                export const m_vLinearTintColor = 0x18;
            }
            export namespace VMapResourceData_t {

            }
            export namespace AggregateLODSetup_t {
                export const m_vLODOrigin = 0x0;
                export const m_fMaxObjectScale = 0xC;
                export const m_fSwitchDistances = 0x10;
            }
            export namespace AggregateMeshInfo_t {
                export const m_vTintColor = 0xC;
                export const m_objectFlags = 0x10;
                export const m_bHasTransform = 0x5;
                export const m_nLODGroupMask = 0x6;
                export const m_nDrawCallIndex = 0x8;
                export const m_nLODSetupIndex = 0xA;
                export const m_fEmissiveFactor = 0x28;
                export const m_instanceStreams = 0x24;
                export const m_nInstanceStreamOffset = 0x18;
                export const m_nVisClusterMemberCount = 0x4;
                export const m_nVisClusterMemberOffset = 0x0;
                export const m_nVertexAlbedoStreamOffset = 0x1C;
                export const m_nVertexEmissiveStreamOffset = 0x20;
                export const m_nLightProbeVolumePrecomputedHandshake = 0x14;
            }
            export namespace BakedLightingInfo_t {
                export const m_lightMaps = 0x18;
                export const m_bakedShadows = 0x30;
                export const m_nLPVEncoding = 0x13;
                export const m_nVradQuality = 0x16;
                export const m_bHasLightmaps = 0x10;
                export const m_vLightmapUvScale = 0x8;
                export const m_nLightmapEncoding = 0x14;
                export const m_bCompressionEnabled = 0x12;
                export const m_bBakedShadowsGamma20 = 0x11;
                export const m_nChartPackIterations = 0x15;
                export const m_nLightmapVersionNumber = 0x0;
                export const m_nLightmapGameVersionNumber = 0x4;
            }
            export namespace ClutterSceneObject_t {
                export const m_flags = 0x18;
                export const m_tiles = 0x80;
                export const m_Bounds = 0x0;
                export const m_nLayer = 0x1C;
                export const m_flEndCullSize = 0xA8;
                export const m_materialGroup = 0xA0;
                export const m_instanceScales = 0x50;
                export const m_flBeginCullSize = 0xA4;
                export const m_renderableModel = 0x98;
                export const m_instanceTintSrgb = 0x68;
                export const m_instancePositions = 0x20;
            }
            export namespace EntityKeyValueData_t {
                export const m_connections = 0x8;
                export const m_keyValuesData = 0x20;
            }
            export namespace PermEntityLumpData_t {
                export const m_name = 0x8;
                export const m_childLumps = 0x10;
                export const m_entityKeyValues = 0x28;
            }
            export namespace WorldBuilderParams_t {
                export const m_bakedLightingInfo = 0x8;
                export const m_nCompileTimestamp = 0x50;
                export const m_bBuildBakedLighting = 0x4;
                export const m_flMinDrawVolumeSize = 0x0;
                export const m_nCompileFingerprint = 0x58;
                export const m_bAggregateInstanceStreams = 0x5;
            }
            export namespace RTProxyInstanceInfo_t {
                export const m_nFlags = 0x0;
                export const m_nBLASCount = 0x4;
                export const m_nBLASIndex = 0x8;
                export const m_albedoFormat = 0x1;
                export const m_emissiveFormat = 0x2;
                export const m_vTintColorSRGB = 0x48;
                export const m_fEmissiveFactor = 0x14;
                export const m_mWorldFromLocal = 0x18;
                export const m_nVertexAlbedoByteOffset = 0xC;
                export const m_nVertexEmissiveByteOffset = 0x10;
            }
            export namespace VoxelVisBlockOffset_t {
                export const m_nOffset = 0x0;
                export const m_nElementCount = 0x4;
            }
            export namespace AggregateSceneObject_t {
                export const m_nLayer = 0x8;
                export const m_allFlags = 0x0;
                export const m_anyFlags = 0x4;
                export const m_lodSetups = 0x28;
                export const m_instanceStream = 0xA;
                export const m_aggregateMeshes = 0x10;
                export const m_renderableModel = 0x70;
                export const m_fragmentTransforms = 0x58;
                export const m_vertexAlbedoStream = 0xC;
                export const m_vertexEmissiveStream = 0xE;
                export const m_visClusterMembership = 0x40;
            }
            export namespace EntityIOConnectionData_t {
                export const m_flDelay = 0x28;
                export const m_paramMap = 0x30;
                export const m_inputName = 0x18;
                export const m_outputName = 0x0;
                export const m_targetName = 0x10;
                export const m_targetType = 0x8;
                export const m_nTimesToFire = 0x2C;
                export const m_overrideParam = 0x20;
            }
            export namespace BaseSceneObjectOverride_t {
                export const m_nSceneObjectIndex = 0x0;
            }
            export namespace ExtraVertexStreamOverride_t {
                export const m_nDrawCallIndex = 0x8;
                export const m_nSubSceneObject = 0x4;
                export const m_extraBufferBinding = 0x10;
                export const m_nAdditionalMeshDrawPrimitiveFlags = 0xC;
            }
            export namespace WorldNodeOnDiskBufferData_t {
                export const m_pData = 0x20;
                export const m_nElementCount = 0x0;
                export const m_inputLayoutFields = 0x8;
                export const m_nElementSizeInBytes = 0x4;
            }
            export namespace AggregateRTProxySceneObject_t {
                export const m_BLASes = 0x8;
                export const m_IBData = 0x48;
                export const m_VBData = 0x38;
                export const m_nLayer = 0x0;
                export const m_Instances = 0x20;
                export const m_InstanceAlbedoData = 0x58;
                export const m_InstanceEmissiveData = 0x68;
            }
            export namespace AggregateInstanceStreamOnDiskData_t {
                export const m_BufferData = 0x8;
                export const m_DecodedSize = 0x0;
            }
            export namespace InfoForResourceTypeVMapResourceData_t {

            }
            export namespace AggregateVertexAlbedoStreamOnDiskData_t {
                export const m_BufferData = 0x0;
            }
            export namespace AggregateVertexEmissiveStreamOnDiskData_t {
                export const m_BufferData = 0x0;
            }
            export namespace BakedLightingInfo_t__BakedShadowAssignment_t {
                export const m_nMapHash = 0x4;
                export const m_nLightHash = 0x0;
                export const m_nShadowChannel = 0x8;
            }
            export namespace ObjectTypeFlags_t {
                export const OBJECT_TYPE_NONE = 0x0;
                export const OBJECT_TYPE_MODEL = 0x8;
                export const OBJECT_TYPE_OVERLAY = 0x2000;
                export const OBJECT_TYPE_NO_SHADOWS = 0x20;
                export const OBJECT_TYPE_BLOCK_LIGHT = 0x10;
                export const OBJECT_TYPE_BAKED_GEOMETRY = 0x20000;
                export const OBJECT_TYPE_MODEL_HAS_LODS = 0x800;
                export const OBJECT_TYPE_HAS_EMISSIVE_GI = 0x100000;
                export const OBJECT_TYPE_STATIC_CUBE_MAP = 0x8000;
                export const OBJECT_TYPE_RENDER_TO_CUBEMAPS = 0x400;
                export const OBJECT_TYPE_DISABLE_VIS_CULLING = 0x10000;
                export const OBJECT_TYPE_RENDER_WITH_DYNAMIC = 0x200;
                export const OBJECT_TYPE_HAS_AGGREGATE_RTPROXY = 0x80000;
                export const OBJECT_TYPE_NEEDS_DYNAMIC_SHADOWS = 0x40000;
                export const OBJECT_TYPE_PRECOMPUTED_VISMEMBERS = 0x4000;
                export const OBJECT_TYPE_DISABLED_IN_LOW_QUALITY = 0x80;
                export const OBJECT_TYPE_WORLDSPACE_TEXURE_BLEND = 0x40;
            }
            export namespace RTProxyInstanceFlags_t {
                export const RTPROXY_INSTANCE_FLAG_NONE = 0x0;
                export const RTPROXY_INSTANCE_UNIQUE_MESH = 0x1;
            }
            export namespace AggregateInstanceStream_t {
                export const AGGREGATE_INSTANCE_STREAM_NONE = 0x0;
                export const AGGREGATE_INSTANCE_STREAM_VERTEXTINT_UNORM8 = 0x2;
                export const AGGREGATE_INSTANCE_STREAM_LIGHTMAPUV_UNORM16 = 0x1;
                export const AGGREGATE_INSTANCE_STREAM_VERTEXBLEND_UNORM8 = 0x4;
            }
        }
    }
}
