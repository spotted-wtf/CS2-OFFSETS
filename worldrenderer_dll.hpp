#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace schemas {
        namespace worldrenderer_dll {
            namespace World_t {
                inline constexpr std::ptrdiff_t m_worldNodes = 0x60;
                inline constexpr std::ptrdiff_t m_entityLumps = 0xC0;
                inline constexpr std::ptrdiff_t m_builderParams = 0x0;
                inline constexpr std::ptrdiff_t m_worldLightingInfo = 0x78;
            }
            namespace NodeData_t {
                inline constexpr std::ptrdiff_t m_vOrigin = 0x0;
                inline constexpr std::ptrdiff_t m_vMaxBounds = 0x18;
                inline constexpr std::ptrdiff_t m_vMinBounds = 0xC;
                inline constexpr std::ptrdiff_t m_worldNodePrefix = 0x28;
            }
            namespace WorldNode_t {
                inline constexpr std::ptrdiff_t m_rtProxies = 0x60;
                inline constexpr std::ptrdiff_t m_layerNames = 0x108;
                inline constexpr std::ptrdiff_t m_sceneObjects = 0x0;
                inline constexpr std::ptrdiff_t m_grassFileName = 0x138;
                inline constexpr std::ptrdiff_t m_nodeLightingInfo = 0x140;
                inline constexpr std::ptrdiff_t m_materialOverrides = 0x90;
                inline constexpr std::ptrdiff_t m_extraVertexStreams = 0xA8;
                inline constexpr std::ptrdiff_t m_clutterSceneObjects = 0x48;
                inline constexpr std::ptrdiff_t m_vertexAlbedoStreams = 0xD8;
                inline constexpr std::ptrdiff_t m_visClusterMembership = 0x18;
                inline constexpr std::ptrdiff_t m_aggregateSceneObjects = 0x30;
                inline constexpr std::ptrdiff_t m_bHasBakedGeometryFlag = 0x188;
                inline constexpr std::ptrdiff_t m_vertexEmissiveStreams = 0xF0;
                inline constexpr std::ptrdiff_t m_sceneObjectLayerIndices = 0x120;
                inline constexpr std::ptrdiff_t m_aggregateInstanceStreams = 0xC0;
                inline constexpr std::ptrdiff_t m_extraVertexStreamOverrides = 0x78;
            }
            namespace ClutterTile_t {
                inline constexpr std::ptrdiff_t m_BoundsWs = 0x8;
                inline constexpr std::ptrdiff_t m_nLastInstance = 0x4;
                inline constexpr std::ptrdiff_t m_nFirstInstance = 0x0;
            }
            namespace RTProxyBLAS_t {
                inline constexpr std::ptrdiff_t m_boundLs = 0x14;
                inline constexpr std::ptrdiff_t m_nBaseVertex = 0xC;
                inline constexpr std::ptrdiff_t m_nFirstIndex = 0x0;
                inline constexpr std::ptrdiff_t m_nIndexCount = 0x4;
                inline constexpr std::ptrdiff_t m_albedoFormat = 0x12;
                inline constexpr std::ptrdiff_t m_nVertexCount = 0x10;
                inline constexpr std::ptrdiff_t m_nVBByteOffset = 0x8;
                inline constexpr std::ptrdiff_t m_vVertexExtentLs = 0x38;
                inline constexpr std::ptrdiff_t m_vVertexOriginLs = 0x2C;
            }
            namespace SceneObject_t {
                inline constexpr std::ptrdiff_t m_skin = 0x50;
                inline constexpr std::ptrdiff_t m_nObjectID = 0x0;
                inline constexpr std::ptrdiff_t m_renderable = 0x88;
                inline constexpr std::ptrdiff_t m_vTintColor = 0x3C;
                inline constexpr std::ptrdiff_t m_vTransform = 0x4;
                inline constexpr std::ptrdiff_t m_nLODOverride = 0x6A;
                inline constexpr std::ptrdiff_t m_renderableModel = 0x80;
                inline constexpr std::ptrdiff_t m_vLightingOrigin = 0x5C;
                inline constexpr std::ptrdiff_t m_nObjectTypeFlags = 0x58;
                inline constexpr std::ptrdiff_t m_flFadeEndDistance = 0x38;
                inline constexpr std::ptrdiff_t m_flFadeStartDistance = 0x34;
                inline constexpr std::ptrdiff_t m_nOverlayRenderOrder = 0x68;
                inline constexpr std::ptrdiff_t m_flEmissiveLightingBoost = 0x74;
                inline constexpr std::ptrdiff_t m_nCubeMapPrecomputedHandshake = 0x6C;
                inline constexpr std::ptrdiff_t m_nLightProbeVolumePrecomputedHandshake = 0x70;
            }
            namespace CEntityIdentity {
                inline constexpr std::ptrdiff_t m_name = 0x18;
                inline constexpr std::ptrdiff_t m_flags = 0x30;
                inline constexpr std::ptrdiff_t m_pNext = 0x58;
                inline constexpr std::ptrdiff_t m_pPrev = 0x50;
                inline constexpr std::ptrdiff_t m_PathIndex = 0x40;
                inline constexpr std::ptrdiff_t m_pAttributes = 0x48;
                inline constexpr std::ptrdiff_t m_designerName = 0x20;
                inline constexpr std::ptrdiff_t m_pNextByClass = 0x68;
                inline constexpr std::ptrdiff_t m_pPrevByClass = 0x60;
                inline constexpr std::ptrdiff_t m_worldGroupId = 0x38;
                inline constexpr std::ptrdiff_t m_fDataObjectTypes = 0x3C;
                inline constexpr std::ptrdiff_t m_nameStringTableIndex = 0x14;
            }
            namespace CEntityInstance {
                inline constexpr std::ptrdiff_t m_pEntity = 0x10;
                inline constexpr std::ptrdiff_t m_CScriptComponent = 0x28;
                inline constexpr std::ptrdiff_t m_iszPrivateVScripts = 0x8;
            }
            namespace CEntityComponent {

            }
            namespace CScriptComponent {
                inline constexpr std::ptrdiff_t m_scriptClassName = 0x30;
            }
            namespace CVoxelVisibility {
                inline constexpr std::ptrdiff_t m_NodeBlock = 0x6C;
                inline constexpr std::ptrdiff_t m_MasksBlock = 0x8C;
                inline constexpr std::ptrdiff_t m_flGridSize = 0x60;
                inline constexpr std::ptrdiff_t m_nVisBlocks = 0x94;
                inline constexpr std::ptrdiff_t m_vMaxBounds = 0x54;
                inline constexpr std::ptrdiff_t m_vMinBounds = 0x48;
                inline constexpr std::ptrdiff_t m_RegionBlock = 0x74;
                inline constexpr std::ptrdiff_t m_nBaseClusterCount = 0x40;
                inline constexpr std::ptrdiff_t m_nPVSBytesPerCluster = 0x44;
                inline constexpr std::ptrdiff_t m_EnclosedClustersBlock = 0x84;
                inline constexpr std::ptrdiff_t m_nSkyVisibilityCluster = 0x64;
                inline constexpr std::ptrdiff_t m_nSunVisibilityCluster = 0x68;
                inline constexpr std::ptrdiff_t m_EnclosedClusterListBlock = 0x7C;
            }
            namespace MaterialOverride_t {
                inline constexpr std::ptrdiff_t m_pMaterial = 0x10;
                inline constexpr std::ptrdiff_t m_nDrawCallIndex = 0x8;
                inline constexpr std::ptrdiff_t m_nSubSceneObject = 0x4;
                inline constexpr std::ptrdiff_t m_vLinearTintColor = 0x18;
            }
            namespace VMapResourceData_t {

            }
            namespace AggregateLODSetup_t {
                inline constexpr std::ptrdiff_t m_vLODOrigin = 0x0;
                inline constexpr std::ptrdiff_t m_fMaxObjectScale = 0xC;
                inline constexpr std::ptrdiff_t m_fSwitchDistances = 0x10;
            }
            namespace AggregateMeshInfo_t {
                inline constexpr std::ptrdiff_t m_vTintColor = 0xC;
                inline constexpr std::ptrdiff_t m_objectFlags = 0x10;
                inline constexpr std::ptrdiff_t m_bHasTransform = 0x5;
                inline constexpr std::ptrdiff_t m_nLODGroupMask = 0x6;
                inline constexpr std::ptrdiff_t m_nDrawCallIndex = 0x8;
                inline constexpr std::ptrdiff_t m_nLODSetupIndex = 0xA;
                inline constexpr std::ptrdiff_t m_fEmissiveFactor = 0x28;
                inline constexpr std::ptrdiff_t m_instanceStreams = 0x24;
                inline constexpr std::ptrdiff_t m_nInstanceStreamOffset = 0x18;
                inline constexpr std::ptrdiff_t m_nVisClusterMemberCount = 0x4;
                inline constexpr std::ptrdiff_t m_nVisClusterMemberOffset = 0x0;
                inline constexpr std::ptrdiff_t m_nVertexAlbedoStreamOffset = 0x1C;
                inline constexpr std::ptrdiff_t m_nVertexEmissiveStreamOffset = 0x20;
                inline constexpr std::ptrdiff_t m_nLightProbeVolumePrecomputedHandshake = 0x14;
            }
            namespace BakedLightingInfo_t {
                inline constexpr std::ptrdiff_t m_lightMaps = 0x18;
                inline constexpr std::ptrdiff_t m_bakedShadows = 0x30;
                inline constexpr std::ptrdiff_t m_nLPVEncoding = 0x13;
                inline constexpr std::ptrdiff_t m_nVradQuality = 0x16;
                inline constexpr std::ptrdiff_t m_bHasLightmaps = 0x10;
                inline constexpr std::ptrdiff_t m_vLightmapUvScale = 0x8;
                inline constexpr std::ptrdiff_t m_nLightmapEncoding = 0x14;
                inline constexpr std::ptrdiff_t m_bCompressionEnabled = 0x12;
                inline constexpr std::ptrdiff_t m_bBakedShadowsGamma20 = 0x11;
                inline constexpr std::ptrdiff_t m_nChartPackIterations = 0x15;
                inline constexpr std::ptrdiff_t m_nLightmapVersionNumber = 0x0;
                inline constexpr std::ptrdiff_t m_nLightmapGameVersionNumber = 0x4;
            }
            namespace ClutterSceneObject_t {
                inline constexpr std::ptrdiff_t m_flags = 0x18;
                inline constexpr std::ptrdiff_t m_tiles = 0x80;
                inline constexpr std::ptrdiff_t m_Bounds = 0x0;
                inline constexpr std::ptrdiff_t m_nLayer = 0x1C;
                inline constexpr std::ptrdiff_t m_flEndCullSize = 0xA8;
                inline constexpr std::ptrdiff_t m_materialGroup = 0xA0;
                inline constexpr std::ptrdiff_t m_instanceScales = 0x50;
                inline constexpr std::ptrdiff_t m_flBeginCullSize = 0xA4;
                inline constexpr std::ptrdiff_t m_renderableModel = 0x98;
                inline constexpr std::ptrdiff_t m_instanceTintSrgb = 0x68;
                inline constexpr std::ptrdiff_t m_instancePositions = 0x20;
            }
            namespace EntityKeyValueData_t {
                inline constexpr std::ptrdiff_t m_connections = 0x8;
                inline constexpr std::ptrdiff_t m_keyValuesData = 0x20;
            }
            namespace PermEntityLumpData_t {
                inline constexpr std::ptrdiff_t m_name = 0x8;
                inline constexpr std::ptrdiff_t m_childLumps = 0x10;
                inline constexpr std::ptrdiff_t m_entityKeyValues = 0x28;
            }
            namespace WorldBuilderParams_t {
                inline constexpr std::ptrdiff_t m_bakedLightingInfo = 0x8;
                inline constexpr std::ptrdiff_t m_nCompileTimestamp = 0x50;
                inline constexpr std::ptrdiff_t m_bBuildBakedLighting = 0x4;
                inline constexpr std::ptrdiff_t m_flMinDrawVolumeSize = 0x0;
                inline constexpr std::ptrdiff_t m_nCompileFingerprint = 0x58;
                inline constexpr std::ptrdiff_t m_bAggregateInstanceStreams = 0x5;
            }
            namespace RTProxyInstanceInfo_t {
                inline constexpr std::ptrdiff_t m_nFlags = 0x0;
                inline constexpr std::ptrdiff_t m_nBLASCount = 0x4;
                inline constexpr std::ptrdiff_t m_nBLASIndex = 0x8;
                inline constexpr std::ptrdiff_t m_albedoFormat = 0x1;
                inline constexpr std::ptrdiff_t m_emissiveFormat = 0x2;
                inline constexpr std::ptrdiff_t m_vTintColorSRGB = 0x48;
                inline constexpr std::ptrdiff_t m_fEmissiveFactor = 0x14;
                inline constexpr std::ptrdiff_t m_mWorldFromLocal = 0x18;
                inline constexpr std::ptrdiff_t m_nVertexAlbedoByteOffset = 0xC;
                inline constexpr std::ptrdiff_t m_nVertexEmissiveByteOffset = 0x10;
            }
            namespace VoxelVisBlockOffset_t {
                inline constexpr std::ptrdiff_t m_nOffset = 0x0;
                inline constexpr std::ptrdiff_t m_nElementCount = 0x4;
            }
            namespace AggregateSceneObject_t {
                inline constexpr std::ptrdiff_t m_nLayer = 0x8;
                inline constexpr std::ptrdiff_t m_allFlags = 0x0;
                inline constexpr std::ptrdiff_t m_anyFlags = 0x4;
                inline constexpr std::ptrdiff_t m_lodSetups = 0x28;
                inline constexpr std::ptrdiff_t m_instanceStream = 0xA;
                inline constexpr std::ptrdiff_t m_aggregateMeshes = 0x10;
                inline constexpr std::ptrdiff_t m_renderableModel = 0x70;
                inline constexpr std::ptrdiff_t m_fragmentTransforms = 0x58;
                inline constexpr std::ptrdiff_t m_vertexAlbedoStream = 0xC;
                inline constexpr std::ptrdiff_t m_vertexEmissiveStream = 0xE;
                inline constexpr std::ptrdiff_t m_visClusterMembership = 0x40;
            }
            namespace EntityIOConnectionData_t {
                inline constexpr std::ptrdiff_t m_flDelay = 0x28;
                inline constexpr std::ptrdiff_t m_paramMap = 0x30;
                inline constexpr std::ptrdiff_t m_inputName = 0x18;
                inline constexpr std::ptrdiff_t m_outputName = 0x0;
                inline constexpr std::ptrdiff_t m_targetName = 0x10;
                inline constexpr std::ptrdiff_t m_targetType = 0x8;
                inline constexpr std::ptrdiff_t m_nTimesToFire = 0x2C;
                inline constexpr std::ptrdiff_t m_overrideParam = 0x20;
            }
            namespace BaseSceneObjectOverride_t {
                inline constexpr std::ptrdiff_t m_nSceneObjectIndex = 0x0;
            }
            namespace ExtraVertexStreamOverride_t {
                inline constexpr std::ptrdiff_t m_nDrawCallIndex = 0x8;
                inline constexpr std::ptrdiff_t m_nSubSceneObject = 0x4;
                inline constexpr std::ptrdiff_t m_extraBufferBinding = 0x10;
                inline constexpr std::ptrdiff_t m_nAdditionalMeshDrawPrimitiveFlags = 0xC;
            }
            namespace WorldNodeOnDiskBufferData_t {
                inline constexpr std::ptrdiff_t m_pData = 0x20;
                inline constexpr std::ptrdiff_t m_nElementCount = 0x0;
                inline constexpr std::ptrdiff_t m_inputLayoutFields = 0x8;
                inline constexpr std::ptrdiff_t m_nElementSizeInBytes = 0x4;
            }
            namespace AggregateRTProxySceneObject_t {
                inline constexpr std::ptrdiff_t m_BLASes = 0x8;
                inline constexpr std::ptrdiff_t m_IBData = 0x48;
                inline constexpr std::ptrdiff_t m_VBData = 0x38;
                inline constexpr std::ptrdiff_t m_nLayer = 0x0;
                inline constexpr std::ptrdiff_t m_Instances = 0x20;
                inline constexpr std::ptrdiff_t m_InstanceAlbedoData = 0x58;
                inline constexpr std::ptrdiff_t m_InstanceEmissiveData = 0x68;
            }
            namespace AggregateInstanceStreamOnDiskData_t {
                inline constexpr std::ptrdiff_t m_BufferData = 0x8;
                inline constexpr std::ptrdiff_t m_DecodedSize = 0x0;
            }
            namespace InfoForResourceTypeVMapResourceData_t {

            }
            namespace AggregateVertexAlbedoStreamOnDiskData_t {
                inline constexpr std::ptrdiff_t m_BufferData = 0x0;
            }
            namespace AggregateVertexEmissiveStreamOnDiskData_t {
                inline constexpr std::ptrdiff_t m_BufferData = 0x0;
            }
            namespace BakedLightingInfo_t__BakedShadowAssignment_t {
                inline constexpr std::ptrdiff_t m_nMapHash = 0x4;
                inline constexpr std::ptrdiff_t m_nLightHash = 0x0;
                inline constexpr std::ptrdiff_t m_nShadowChannel = 0x8;
            }
            namespace ObjectTypeFlags_t {
                inline constexpr std::ptrdiff_t OBJECT_TYPE_NONE = 0x0;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_MODEL = 0x8;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_OVERLAY = 0x2000;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_NO_SHADOWS = 0x20;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_BLOCK_LIGHT = 0x10;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_BAKED_GEOMETRY = 0x20000;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_MODEL_HAS_LODS = 0x800;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_HAS_EMISSIVE_GI = 0x100000;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_STATIC_CUBE_MAP = 0x8000;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_RENDER_TO_CUBEMAPS = 0x400;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_DISABLE_VIS_CULLING = 0x10000;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_RENDER_WITH_DYNAMIC = 0x200;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_HAS_AGGREGATE_RTPROXY = 0x80000;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_NEEDS_DYNAMIC_SHADOWS = 0x40000;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_PRECOMPUTED_VISMEMBERS = 0x4000;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_DISABLED_IN_LOW_QUALITY = 0x80;
                inline constexpr std::ptrdiff_t OBJECT_TYPE_WORLDSPACE_TEXURE_BLEND = 0x40;
            }
            namespace RTProxyInstanceFlags_t {
                inline constexpr std::ptrdiff_t RTPROXY_INSTANCE_FLAG_NONE = 0x0;
                inline constexpr std::ptrdiff_t RTPROXY_INSTANCE_UNIQUE_MESH = 0x1;
            }
            namespace AggregateInstanceStream_t {
                inline constexpr std::ptrdiff_t AGGREGATE_INSTANCE_STREAM_NONE = 0x0;
                inline constexpr std::ptrdiff_t AGGREGATE_INSTANCE_STREAM_VERTEXTINT_UNORM8 = 0x2;
                inline constexpr std::ptrdiff_t AGGREGATE_INSTANCE_STREAM_LIGHTMAPUV_UNORM16 = 0x1;
                inline constexpr std::ptrdiff_t AGGREGATE_INSTANCE_STREAM_VERTEXBLEND_UNORM8 = 0x4;
            }
        }
    }
}
