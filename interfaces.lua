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
                ["LegacyGameUI001"] = 0x22351A0,
                ["Source2Client002"] = 0x2551080,
                ["Source2ClientUI001"] = 0x22322A0,
                ["ClientToolsInfo_001"] = 0x2227160,
                ["GameClientExports001"] = 0x2223E08,
                ["Source2ClientConfig001"] = 0x24ADB00,
                ["Source2ClientPrediction001"] = 0x2557440,
                ["EmptyWorldService001_Client"] = 0x220AEA0,
                ["ClientBugBugServic001_Client"] = 0x2227190,
            },
            ["server_dll"] = {
                ["NavGameTest001"] = 0x1E3C898,
                ["Source2Server001"] = 0x1E1ADA0,
                ["customnavsystem001"] = 0x1D924A8,
                ["ServerToolsInfo_001"] = 0x1E1B7B8,
                ["Source2GameClients001"] = 0x1E1ACE0,
                ["Source2GameDirector001"] = 0x1F81A80,
                ["Source2GameEntities001"] = 0x1E1AF60,
                ["Source2ServerConfig001"] = 0x20FD3F8,
                ["EntitySubclassUtilsV001"] = 0x1DA4B50,
                ["EmptyWorldService001_Server"] = 0x1DF4EA0,
            },
            ["engine2_dll"] = {
                ["BugService001"] = 0x9703C0,
                ["EngineGameUI001"] = 0x6B6430,
                ["HostStateMgr001"] = 0x6B8FB0,
                ["INETSUPPORT_001"] = 0x6B1980,
                ["ToolService_001"] = 0x6B8E20,
                ["BugBugService001"] = 0x6B8AD0,
                ["InputService_001"] = 0x970AF0,
                ["KeyValueCache001"] = 0x6B9060,
                ["SoundService_001"] = 0x9B06D0,
                ["StatsService_001"] = 0x9B0C10,
                ["VProfService_001"] = 0x6B8E60,
                ["GameUIService_001"] = 0x970810,
                ["RenderService_001"] = 0x9B0250,
                ["MapListService_001"] = 0x9AF960,
                ["NetworkService_001"] = 0x6B8CE0,
                ["BenchmarkService001"] = 0x6B89D0,
                ["EngineServiceMgr001"] = 0x9B1680,
                ["ScreenshotService001"] = 0x9B0520,
                ["NetworkP2PService_001"] = 0x9AFE30,
                ["SplitScreenService_001"] = 0x6B8D20,
                ["NetworkClientService_001"] = 0x9AFAF0,
                ["NetworkServerService_001"] = 0x9AFFE0,
                ["Source2EngineToClient001"] = 0x6B5D40,
                ["Source2EngineToServer001"] = 0x6B5E18,
                ["GameEventSystemClientV001"] = 0x9B1970,
                ["GameEventSystemServerV001"] = 0x9B1AA0,
                ["SimpleEngineLoopService_001"] = 0x6B90C0,
                ["GameResourceServiceClientV001"] = 0x6B8B10,
                ["GameResourceServiceServerV001"] = 0x6B8B70,
                ["VENGINE_GAMEUIFUNCS_VERSION005"] = 0x6B64C0,
                ["ClientServerEngineLoopService_001"] = 0x9B1DE0,
                ["ClientServerSharedHandleSystem001"] = 0x9B13D0,
                ["Source2EngineToClientStringTable001"] = 0x6B5DA0,
                ["Source2EngineToServerStringTable001"] = 0x6B5E40,
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
                ["ParticleSystemMgr003"] = 0x65AEE0,
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
                ["GameTypes001"] = 0x1AEFC0,
                ["MATCHFRAMEWORK_001"] = 0x1B7080,
            },
            ["scenesystem_dll"] = {
                ["SceneUtils_001"] = 0x676760,
                ["SceneSystem_002"] = 0x91FB20,
                ["RenderingPipelines_001"] = 0x675A00,
            },
            ["soundsystem_dll"] = {
                ["SoundSystem001"] = 0x532470,
                ["VMixEditTool001"] = 0x5941BBF,
                ["SoundOpSystem001"] = 0x532B70,
                ["SoundOpSystemEdit001"] = 0x532A80,
                ["SoundBugBugService001_Client"] = 0x532C90,
            },
            ["pulse_system_dll"] = {
                ["IPulseSystem_001"] = 0x238120,
            },
            ["schemasystem_dll"] = {
                ["SchemaSystem_001"] = 0x76710,
            },
            ["networksystem_dll"] = {
                ["NetworkSystemVersion001"] = 0x28C450,
                ["NetworkMessagesVersion001"] = 0x29EE00,
                ["SerializedEntitiesVersion001"] = 0x28C530,
                ["FlattenedSerializersVersion001"] = 0x272A30,
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
