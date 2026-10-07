public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class scenesystem_dll {
            public static partial class SceneViewId_t {
                public const long m_nViewId = 0x0;
                public const long m_nFrameCount = 0x8;
            }
            public static partial class CSSDSMsg_EndFrame {
                public const long m_Views = 0x0;
            }
            public static partial class CSSDSMsg_PreLayer {

            }
            public static partial class CSSDSMsg_LayerBase {
                public const long m_viewId = 0x0;
                public const long m_ViewName = 0x10;
                public const long m_nLayerId = 0x18;
                public const long m_LayerName = 0x20;
                public const long m_displayText = 0x28;
            }
            public static partial class CSSDSMsg_PostLayer {

            }
            public static partial class CSSDSMsg_ViewRender {
                public const long m_viewId = 0x0;
                public const long m_ViewName = 0x10;
            }
            public static partial class CSSDSMsg_ViewTarget {
                public const long m_Name = 0x0;
                public const long m_nDepth = 0x24;
                public const long m_nWidth = 0x10;
                public const long m_nFormat = 0x2C;
                public const long m_nHeight = 0x14;
                public const long m_TextureId = 0x8;
                public const long m_nNumMipLevels = 0x20;
                public const long m_nRequestedWidth = 0x18;
                public const long m_nRequestedHeight = 0x1C;
                public const long m_nMultisampleNumSamples = 0x28;
            }
            public static partial class CSSDSEndFrameViewInfo {
                public const long m_nViewId = 0x0;
                public const long m_ViewName = 0x8;
            }
            public static partial class CSSDSMsg_ViewTargetList {
                public const long m_viewId = 0x0;
                public const long m_Targets = 0x18;
                public const long m_ViewName = 0x10;
            }
            public static partial class DisableShadows_t {
                public const long kDisableShadows_All = 0x1;
                public const long kDisableShadows_None = 0x0;
                public const long kDisableShadows_Baked = 0x2;
                public const long kDisableShadows_Realtime = 0x3;
                public const long kDisableShadows_ReallyNone = 0x4;
            }
            public static partial class DecalRtEncoding_t {
                public const long kDecalMax = 0x2;
                public const long kDecalMin = 0x0;
                public const long kDecalBlood = 0x0;
                public const long kDecalCloak = 0x1;
                public const long kDecalDefault = 0x0;
                public const long kDecalInvalid = 0xFF;
            }
            public static partial class ESilhouetteType_t {
                public const long SILHOUETTE_LPV = 0x4;
                public const long SILHOUETTE_NONE = 0x0;
                public const long SILHOUETTE_LIGHT = 0x1;
                public const long SILHOUETTE_ENVMAP = 0x2;
            }
            public static partial class SceneStatsSections_t {
                public const long SCENE_STATS_ALL = 0xFF;
                public const long SCENE_STATS_NONE = 0x0;
                public const long SCENE_STATS_FRAME = 0x1;
                public const long SCENE_STATS_CULLING = 0x4;
                public const long SCENE_STATS_DEFAULT = 0x7F;
                public const long SCENE_STATS_GEOMETRY = 0x2;
                public const long SCENE_STATS_LIGHTING = 0x10;
                public const long SCENE_STATS_INTERNALS = 0x40;
                public const long SCENE_STATS_MATERIALS = 0x8;
                public const long SCENE_STATS_RAYTRACING = 0x20;
                public const long SCENE_STATS_RENDERDEVICE = 0x80;
            }
            public static partial class ESceneObjectVisualization {
                public const long SCENEOBJECT_VIS_LOD = 0x4;
                public const long SCENEOBJECT_VIS_NONE = 0x0;
                public const long SCENEOBJECT_VIS_OBJECT = 0x1;
                public const long SCENEOBJECT_VIS_MATERIAL = 0x2;
                public const long SCENEOBJECT_VIS_INSTANCING = 0x5;
                public const long SCENEOBJECT_VIS_TEXTURE_SIZE = 0x3;
            }
            public static partial class ESceneObjectMeshletVisualization {
                public const long SCENEOBJECT_MESHLET_VIS_NONE = 0x0;
                public const long SCENEOBJECT_MESHLET_VIS_CULLED = 0x2;
                public const long SCENEOBJECT_MESHLET_VIS_MESHLET = 0x1;
            }
            public static partial class ESceneViewDebugOverlaysListenerDataType_t {
                public const long k_ESceneViewDebugOverlaysListenerDataType_Line = 0x4;
                public const long k_ESceneViewDebugOverlaysListenerDataType_Sphere = 0x1;
                public const long k_ESceneViewDebugOverlaysListenerDataType_Text3D = 0x6;
                public const long k_ESceneViewDebugOverlaysListenerDataType_Capsule = 0x2;
                public const long k_ESceneViewDebugOverlaysListenerDataType_Unknown = 0x0;
                public const long k_ESceneViewDebugOverlaysListenerDataType_BoxAngles = 0x3;
                public const long k_ESceneViewDebugOverlaysListenerDataType_SolidBoxAngles = 0x5;
            }
        }
    }
}
