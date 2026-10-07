return {
    ["cs2_dumper"] = {
        ["schemas"] = {
            ["scenesystem_dll"] = {
                ["SceneViewId_t"] = {
                    ["m_nViewId"] = 0x0,
                    ["m_nFrameCount"] = 0x8,
                },
                ["CSSDSMsg_EndFrame"] = {
                    ["m_Views"] = 0x0,
                },
                ["CSSDSMsg_PreLayer"] = {

                },
                ["CSSDSMsg_LayerBase"] = {
                    ["m_viewId"] = 0x0,
                    ["m_ViewName"] = 0x10,
                    ["m_nLayerId"] = 0x18,
                    ["m_LayerName"] = 0x20,
                    ["m_displayText"] = 0x28,
                },
                ["CSSDSMsg_PostLayer"] = {

                },
                ["CSSDSMsg_ViewRender"] = {
                    ["m_viewId"] = 0x0,
                    ["m_ViewName"] = 0x10,
                },
                ["CSSDSMsg_ViewTarget"] = {
                    ["m_Name"] = 0x0,
                    ["m_nDepth"] = 0x24,
                    ["m_nWidth"] = 0x10,
                    ["m_nFormat"] = 0x2C,
                    ["m_nHeight"] = 0x14,
                    ["m_TextureId"] = 0x8,
                    ["m_nNumMipLevels"] = 0x20,
                    ["m_nRequestedWidth"] = 0x18,
                    ["m_nRequestedHeight"] = 0x1C,
                    ["m_nMultisampleNumSamples"] = 0x28,
                },
                ["CSSDSEndFrameViewInfo"] = {
                    ["m_nViewId"] = 0x0,
                    ["m_ViewName"] = 0x8,
                },
                ["CSSDSMsg_ViewTargetList"] = {
                    ["m_viewId"] = 0x0,
                    ["m_Targets"] = 0x18,
                    ["m_ViewName"] = 0x10,
                },
                ["DisableShadows_t"] = {
                    ["kDisableShadows_All"] = 0x1,
                    ["kDisableShadows_None"] = 0x0,
                    ["kDisableShadows_Baked"] = 0x2,
                    ["kDisableShadows_Realtime"] = 0x3,
                    ["kDisableShadows_ReallyNone"] = 0x4,
                },
                ["DecalRtEncoding_t"] = {
                    ["kDecalMax"] = 0x2,
                    ["kDecalMin"] = 0x0,
                    ["kDecalBlood"] = 0x0,
                    ["kDecalCloak"] = 0x1,
                    ["kDecalDefault"] = 0x0,
                    ["kDecalInvalid"] = 0xFF,
                },
                ["ESilhouetteType_t"] = {
                    ["SILHOUETTE_LPV"] = 0x4,
                    ["SILHOUETTE_NONE"] = 0x0,
                    ["SILHOUETTE_LIGHT"] = 0x1,
                    ["SILHOUETTE_ENVMAP"] = 0x2,
                },
                ["SceneStatsSections_t"] = {
                    ["SCENE_STATS_ALL"] = 0xFF,
                    ["SCENE_STATS_NONE"] = 0x0,
                    ["SCENE_STATS_FRAME"] = 0x1,
                    ["SCENE_STATS_CULLING"] = 0x4,
                    ["SCENE_STATS_DEFAULT"] = 0x7F,
                    ["SCENE_STATS_GEOMETRY"] = 0x2,
                    ["SCENE_STATS_LIGHTING"] = 0x10,
                    ["SCENE_STATS_INTERNALS"] = 0x40,
                    ["SCENE_STATS_MATERIALS"] = 0x8,
                    ["SCENE_STATS_RAYTRACING"] = 0x20,
                    ["SCENE_STATS_RENDERDEVICE"] = 0x80,
                },
                ["ESceneObjectVisualization"] = {
                    ["SCENEOBJECT_VIS_LOD"] = 0x4,
                    ["SCENEOBJECT_VIS_NONE"] = 0x0,
                    ["SCENEOBJECT_VIS_OBJECT"] = 0x1,
                    ["SCENEOBJECT_VIS_MATERIAL"] = 0x2,
                    ["SCENEOBJECT_VIS_INSTANCING"] = 0x5,
                    ["SCENEOBJECT_VIS_TEXTURE_SIZE"] = 0x3,
                },
                ["ESceneObjectMeshletVisualization"] = {
                    ["SCENEOBJECT_MESHLET_VIS_NONE"] = 0x0,
                    ["SCENEOBJECT_MESHLET_VIS_CULLED"] = 0x2,
                    ["SCENEOBJECT_MESHLET_VIS_MESHLET"] = 0x1,
                },
                ["ESceneViewDebugOverlaysListenerDataType_t"] = {
                    ["k_ESceneViewDebugOverlaysListenerDataType_Line"] = 0x4,
                    ["k_ESceneViewDebugOverlaysListenerDataType_Sphere"] = 0x1,
                    ["k_ESceneViewDebugOverlaysListenerDataType_Text3D"] = 0x6,
                    ["k_ESceneViewDebugOverlaysListenerDataType_Capsule"] = 0x2,
                    ["k_ESceneViewDebugOverlaysListenerDataType_Unknown"] = 0x0,
                    ["k_ESceneViewDebugOverlaysListenerDataType_BoxAngles"] = 0x3,
                    ["k_ESceneViewDebugOverlaysListenerDataType_SolidBoxAngles"] = 0x5,
                },
            },
        },
    },
}
