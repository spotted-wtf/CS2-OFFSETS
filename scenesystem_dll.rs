#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod schemas {
        pub mod scenesystem_dll {
            pub mod SceneViewId_t {
                pub const m_nViewId: i64 = 0x0;
                pub const m_nFrameCount: i64 = 0x8;
            }
            pub mod CSSDSMsg_EndFrame {
                pub const m_Views: i64 = 0x0;
            }
            pub mod CSSDSMsg_PreLayer {

            }
            pub mod CSSDSMsg_LayerBase {
                pub const m_viewId: i64 = 0x0;
                pub const m_ViewName: i64 = 0x10;
                pub const m_nLayerId: i64 = 0x18;
                pub const m_LayerName: i64 = 0x20;
                pub const m_displayText: i64 = 0x28;
            }
            pub mod CSSDSMsg_PostLayer {

            }
            pub mod CSSDSMsg_ViewRender {
                pub const m_viewId: i64 = 0x0;
                pub const m_ViewName: i64 = 0x10;
            }
            pub mod CSSDSMsg_ViewTarget {
                pub const m_Name: i64 = 0x0;
                pub const m_nDepth: i64 = 0x24;
                pub const m_nWidth: i64 = 0x10;
                pub const m_nFormat: i64 = 0x2C;
                pub const m_nHeight: i64 = 0x14;
                pub const m_TextureId: i64 = 0x8;
                pub const m_nNumMipLevels: i64 = 0x20;
                pub const m_nRequestedWidth: i64 = 0x18;
                pub const m_nRequestedHeight: i64 = 0x1C;
                pub const m_nMultisampleNumSamples: i64 = 0x28;
            }
            pub mod CSSDSEndFrameViewInfo {
                pub const m_nViewId: i64 = 0x0;
                pub const m_ViewName: i64 = 0x8;
            }
            pub mod CSSDSMsg_ViewTargetList {
                pub const m_viewId: i64 = 0x0;
                pub const m_Targets: i64 = 0x18;
                pub const m_ViewName: i64 = 0x10;
            }
            pub mod DisableShadows_t {
                pub const kDisableShadows_All: i64 = 0x1;
                pub const kDisableShadows_None: i64 = 0x0;
                pub const kDisableShadows_Baked: i64 = 0x2;
                pub const kDisableShadows_Realtime: i64 = 0x3;
                pub const kDisableShadows_ReallyNone: i64 = 0x4;
            }
            pub mod DecalRtEncoding_t {
                pub const kDecalMax: i64 = 0x2;
                pub const kDecalMin: i64 = 0x0;
                pub const kDecalBlood: i64 = 0x0;
                pub const kDecalCloak: i64 = 0x1;
                pub const kDecalDefault: i64 = 0x0;
                pub const kDecalInvalid: i64 = 0xFF;
            }
            pub mod ESilhouetteType_t {
                pub const SILHOUETTE_LPV: i64 = 0x4;
                pub const SILHOUETTE_NONE: i64 = 0x0;
                pub const SILHOUETTE_LIGHT: i64 = 0x1;
                pub const SILHOUETTE_ENVMAP: i64 = 0x2;
            }
            pub mod SceneStatsSections_t {
                pub const SCENE_STATS_ALL: i64 = 0xFF;
                pub const SCENE_STATS_NONE: i64 = 0x0;
                pub const SCENE_STATS_FRAME: i64 = 0x1;
                pub const SCENE_STATS_CULLING: i64 = 0x4;
                pub const SCENE_STATS_DEFAULT: i64 = 0x7F;
                pub const SCENE_STATS_GEOMETRY: i64 = 0x2;
                pub const SCENE_STATS_LIGHTING: i64 = 0x10;
                pub const SCENE_STATS_INTERNALS: i64 = 0x40;
                pub const SCENE_STATS_MATERIALS: i64 = 0x8;
                pub const SCENE_STATS_RAYTRACING: i64 = 0x20;
                pub const SCENE_STATS_RENDERDEVICE: i64 = 0x80;
            }
            pub mod ESceneObjectVisualization {
                pub const SCENEOBJECT_VIS_LOD: i64 = 0x4;
                pub const SCENEOBJECT_VIS_NONE: i64 = 0x0;
                pub const SCENEOBJECT_VIS_OBJECT: i64 = 0x1;
                pub const SCENEOBJECT_VIS_MATERIAL: i64 = 0x2;
                pub const SCENEOBJECT_VIS_INSTANCING: i64 = 0x5;
                pub const SCENEOBJECT_VIS_TEXTURE_SIZE: i64 = 0x3;
            }
            pub mod ESceneObjectMeshletVisualization {
                pub const SCENEOBJECT_MESHLET_VIS_NONE: i64 = 0x0;
                pub const SCENEOBJECT_MESHLET_VIS_CULLED: i64 = 0x2;
                pub const SCENEOBJECT_MESHLET_VIS_MESHLET: i64 = 0x1;
            }
            pub mod ESceneViewDebugOverlaysListenerDataType_t {
                pub const k_ESceneViewDebugOverlaysListenerDataType_Line: i64 = 0x4;
                pub const k_ESceneViewDebugOverlaysListenerDataType_Sphere: i64 = 0x1;
                pub const k_ESceneViewDebugOverlaysListenerDataType_Text3D: i64 = 0x6;
                pub const k_ESceneViewDebugOverlaysListenerDataType_Capsule: i64 = 0x2;
                pub const k_ESceneViewDebugOverlaysListenerDataType_Unknown: i64 = 0x0;
                pub const k_ESceneViewDebugOverlaysListenerDataType_BoxAngles: i64 = 0x3;
                pub const k_ESceneViewDebugOverlaysListenerDataType_SolidBoxAngles: i64 = 0x5;
            }
        }
    }
}
