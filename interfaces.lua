return {
    ["cs2_dumper"] = {
        ["interfaces"] = {
            ["host_dll"] = {
                ["HostUtils001"] = 0x14F900,
                ["Source2Host001"] = 0x1402D0,
                ["GameModelInfo001"] = 0x13FFB0,
                ["GameSystem2HostHook"] = 0x13FFF0,
                ["DebugDrawQueueManager001"] = 0x13FF70,
                ["PredictionDiffManager001"] = 0x140100,
                ["SaveRestoreDataVersion001"] = 0x140230,
                ["SinglePlayerSharedMemory001"] = 0x140260,
            },
            ["tier0_dll"] = {
                ["VEngineCvar007"] = 0x3AC670,
                ["TestScriptMgr001"] = 0x3A1960,
                ["VProcessUtils002"] = 0x3A1820,
                ["VStringTokenSystem001"] = 0x3D3300,
            },
            ["client_dll"] = {
                ["LegacyGameUI001"] = 0x2245180,
                ["Source2Client002"] = 0x2564620,
                ["Source2ClientUI001"] = 0x2243900,
                ["ClientToolsInfo_001"] = 0x2238730,
                ["GameClientExports001"] = 0x22353D8,
                ["Source2ClientConfig001"] = 0x24C1160,
                ["Source2ClientPrediction001"] = 0x256A850,
                ["EmptyWorldService001_Client"] = 0x221C160,
                ["ClientBugBugServic001_Client"] = 0x2238760,
            },
            ["server_dll"] = {
                ["NavGameTest001"] = 0x1E54D38,
                ["Source2Server001"] = 0x1E33220,
                ["customnavsystem001"] = 0x1DAA558,
                ["ServerToolsInfo_001"] = 0x1E33C38,
                ["Source2GameClients001"] = 0x1E33160,
                ["Source2GameDirector001"] = 0x1F9D5D0,
                ["Source2GameEntities001"] = 0x1E333E0,
                ["Source2ServerConfig001"] = 0x2118EA8,
                ["EntitySubclassUtilsV001"] = 0x1DBCC60,
                ["EmptyWorldService001_Server"] = 0x1E0D0E0,
            },
            ["engine2_dll"] = {
                ["BugService001"] = 0x9790F0,
                ["EngineGameUI001"] = 0x6BD720,
                ["HostStateMgr001"] = 0x6C02A0,
                ["INETSUPPORT_001"] = 0x6B8C70,
                ["ToolService_001"] = 0x6C0110,
                ["BugBugService001"] = 0x6BFDC0,
                ["InputService_001"] = 0x979820,
                ["KeyValueCache001"] = 0x6C0350,
                ["SoundService_001"] = 0x9B93F0,
                ["StatsService_001"] = 0x9B9930,
                ["VProfService_001"] = 0x6C0150,
                ["GameUIService_001"] = 0x979540,
                ["RenderService_001"] = 0x9B8F80,
                ["MapListService_001"] = 0x9B8690,
                ["NetworkService_001"] = 0x6BFFD0,
                ["BenchmarkService001"] = 0x6BFCC0,
                ["EngineServiceMgr001"] = 0x9BA3B0,
                ["ScreenshotService001"] = 0x9B9240,
                ["NetworkP2PService_001"] = 0x9B8B60,
                ["SplitScreenService_001"] = 0x6C0010,
                ["NetworkClientService_001"] = 0x9B8820,
                ["NetworkServerService_001"] = 0x9B8D10,
                ["Source2EngineToClient001"] = 0x6BD030,
                ["Source2EngineToServer001"] = 0x6BD108,
                ["GameEventSystemClientV001"] = 0x9BA690,
                ["GameEventSystemServerV001"] = 0x9BA7C0,
                ["SimpleEngineLoopService_001"] = 0x6C03B0,
                ["GameResourceServiceClientV001"] = 0x6BFE00,
                ["GameResourceServiceServerV001"] = 0x6BFE60,
                ["VENGINE_GAMEUIFUNCS_VERSION005"] = 0x6BD7B0,
                ["ClientServerEngineLoopService_001"] = 0x9BAAE0,
                ["ClientServerSharedHandleSystem001"] = 0x9BA0F0,
                ["Source2EngineToClientStringTable001"] = 0x6BD090,
                ["Source2EngineToServerStringTable001"] = 0x6BD130,
            },
            ["vscript_dll"] = {
                ["VScriptManager010"] = 0x13E430,
            },
            ["localize_dll"] = {
                ["Localize_001"] = 0x59120,
            },
            ["panorama_dll"] = {
                ["PanoramaUIEngine001"] = 0x5895F0,
            },
            ["v8system_dll"] = {
                ["Source2V8System001"] = 0x34790,
            },
            ["navsystem_dll"] = {
                ["NavSystem001"] = 0x12C000,
            },
            ["particles_dll"] = {
                ["ParticleSystemMgr003"] = 0x65ADE0,
            },
            ["vphysics2_dll"] = {
                ["VPhysics2_Interface_001"] = 0x460E60,
            },
            ["imemanager_dll"] = {
                ["IMEManager001"] = 0x37AA0,
            },
            ["meshsystem_dll"] = {
                ["MeshSystem001"] = 0x180AB0,
            },
            ["steamaudio_dll"] = {
                ["SteamAudio001"] = 0x35C1A0,
            },
            ["inputsystem_dll"] = {
                ["InputSystemVersion001"] = 0x46BC0,
                ["InputStackSystemVersion001"] = 0x44E90,
            },
            ["matchmaking_dll"] = {
                ["GameTypes001"] = 0x1B0FD0,
                ["MATCHFRAMEWORK_001"] = 0x1B90A0,
            },
            ["scenesystem_dll"] = {
                ["SceneUtils_001"] = 0x676750,
                ["SceneSystem_002"] = 0x91FB20,
                ["RenderingPipelines_001"] = 0x6759F0,
            },
            ["soundsystem_dll"] = {
                ["SoundSystem001"] = 0x532420,
                ["VMixEditTool001"] = 0x5941C1F,
                ["SoundOpSystem001"] = 0x532B20,
                ["SoundOpSystemEdit001"] = 0x532A30,
                ["SoundBugBugService001_Client"] = 0x532C40,
            },
            ["pulse_system_dll"] = {
                ["IPulseSystem_001"] = 0x238120,
            },
            ["schemasystem_dll"] = {
                ["SchemaSystem_001"] = 0x76710,
            },
            ["networksystem_dll"] = {
                ["NetworkSystemVersion001"] = 0x2911A0,
                ["NetworkMessagesVersion001"] = 0x2A3F30,
                ["SerializedEntitiesVersion001"] = 0x291290,
                ["FlattenedSerializersVersion001"] = 0x277A50,
            },
            ["worldrenderer_dll"] = {
                ["WorldRendererMgr001"] = 0x236D40,
            },
            ["resourcesystem_dll"] = {
                ["ResourceSystem013"] = 0x89230,
            },
            ["scenefilecache_dll"] = {
                ["SceneFileCache002"] = 0x11D478,
                ["ResponseRulesCache001"] = 0x11D350,
            },
            ["animationsystem_dll"] = {
                ["AnimationSystem_001"] = 0x8375F8,
                ["AnimationSystemUtils_001"] = 0x83F6D8,
            },
            ["materialsystem2_dll"] = {
                ["TextLayout_001"] = 0x14BCC0,
                ["FontManager_001"] = 0x1638E0,
                ["MaterialUtils_001"] = 0x14BD30,
                ["VMaterialSystem2_001"] = 0x163530,
                ["PostProcessingSystem_001"] = 0x14BC60,
            },
            ["filesystem_stdio_dll"] = {
                ["VFileSystem017"] = 0x2143D0,
                ["VAsyncFileSystem2_001"] = 0x214610,
            },
            ["panoramauiclient_dll"] = {
                ["PanoramaUIClient001"] = 0x270710,
            },
            ["rendersystemdx11_dll"] = {
                ["RenderUtils_001"] = 0x434BD0,
                ["RenderDeviceMgr001"] = 0x4342F0,
                ["VRenderDeviceMgrBackdoor001"] = 0x434390,
            },
            ["panorama_text_pango_dll"] = {
                ["PanoramaTextServices001"] = 0x2BA9D0,
            },
        },
    },
}
