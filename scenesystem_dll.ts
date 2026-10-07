export namespace cs2_dumper {
    export namespace schemas {
        export namespace scenesystem_dll {
            export namespace SceneViewId_t {
                export const m_nViewId = 0x0;
                export const m_nFrameCount = 0x8;
            }
            export namespace CSSDSMsg_EndFrame {
                export const m_Views = 0x0;
            }
            export namespace CSSDSMsg_PreLayer {

            }
            export namespace CSSDSMsg_LayerBase {
                export const m_viewId = 0x0;
                export const m_ViewName = 0x10;
                export const m_nLayerId = 0x18;
                export const m_LayerName = 0x20;
                export const m_displayText = 0x28;
            }
            export namespace CSSDSMsg_PostLayer {

            }
            export namespace CSSDSMsg_ViewRender {
                export const m_viewId = 0x0;
                export const m_ViewName = 0x10;
            }
            export namespace CSSDSMsg_ViewTarget {
                export const m_Name = 0x0;
                export const m_nDepth = 0x24;
                export const m_nWidth = 0x10;
                export const m_nFormat = 0x2C;
                export const m_nHeight = 0x14;
                export const m_TextureId = 0x8;
                export const m_nNumMipLevels = 0x20;
                export const m_nRequestedWidth = 0x18;
                export const m_nRequestedHeight = 0x1C;
                export const m_nMultisampleNumSamples = 0x28;
            }
            export namespace CSSDSEndFrameViewInfo {
                export const m_nViewId = 0x0;
                export const m_ViewName = 0x8;
            }
            export namespace CSSDSMsg_ViewTargetList {
                export const m_viewId = 0x0;
                export const m_Targets = 0x18;
                export const m_ViewName = 0x10;
            }
            export namespace DisableShadows_t {
                export const kDisableShadows_All = 0x1;
                export const kDisableShadows_None = 0x0;
                export const kDisableShadows_Baked = 0x2;
                export const kDisableShadows_Realtime = 0x3;
                export const kDisableShadows_ReallyNone = 0x4;
            }
            export namespace DecalRtEncoding_t {
                export const kDecalMax = 0x2;
                export const kDecalMin = 0x0;
                export const kDecalBlood = 0x0;
                export const kDecalCloak = 0x1;
                export const kDecalDefault = 0x0;
                export const kDecalInvalid = 0xFF;
            }
            export namespace ESilhouetteType_t {
                export const SILHOUETTE_LPV = 0x4;
                export const SILHOUETTE_NONE = 0x0;
                export const SILHOUETTE_LIGHT = 0x1;
                export const SILHOUETTE_ENVMAP = 0x2;
            }
            export namespace SceneStatsSections_t {
                export const SCENE_STATS_ALL = 0xFF;
                export const SCENE_STATS_NONE = 0x0;
                export const SCENE_STATS_FRAME = 0x1;
                export const SCENE_STATS_CULLING = 0x4;
                export const SCENE_STATS_DEFAULT = 0x7F;
                export const SCENE_STATS_GEOMETRY = 0x2;
                export const SCENE_STATS_LIGHTING = 0x10;
                export const SCENE_STATS_INTERNALS = 0x40;
                export const SCENE_STATS_MATERIALS = 0x8;
                export const SCENE_STATS_RAYTRACING = 0x20;
                export const SCENE_STATS_RENDERDEVICE = 0x80;
            }
            export namespace ESceneObjectVisualization {
                export const SCENEOBJECT_VIS_LOD = 0x4;
                export const SCENEOBJECT_VIS_NONE = 0x0;
                export const SCENEOBJECT_VIS_OBJECT = 0x1;
                export const SCENEOBJECT_VIS_MATERIAL = 0x2;
                export const SCENEOBJECT_VIS_INSTANCING = 0x5;
                export const SCENEOBJECT_VIS_TEXTURE_SIZE = 0x3;
            }
            export namespace ESceneObjectMeshletVisualization {
                export const SCENEOBJECT_MESHLET_VIS_NONE = 0x0;
                export const SCENEOBJECT_MESHLET_VIS_CULLED = 0x2;
                export const SCENEOBJECT_MESHLET_VIS_MESHLET = 0x1;
            }
            export namespace ESceneViewDebugOverlaysListenerDataType_t {
                export const k_ESceneViewDebugOverlaysListenerDataType_Line = 0x4;
                export const k_ESceneViewDebugOverlaysListenerDataType_Sphere = 0x1;
                export const k_ESceneViewDebugOverlaysListenerDataType_Text3D = 0x6;
                export const k_ESceneViewDebugOverlaysListenerDataType_Capsule = 0x2;
                export const k_ESceneViewDebugOverlaysListenerDataType_Unknown = 0x0;
                export const k_ESceneViewDebugOverlaysListenerDataType_BoxAngles = 0x3;
                export const k_ESceneViewDebugOverlaysListenerDataType_SolidBoxAngles = 0x5;
            }
        }
    }
}
