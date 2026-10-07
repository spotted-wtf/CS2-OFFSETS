pub const cs2_dumper = struct {
    pub const interfaces = struct {
        pub const host_dll = struct {
            pub const HostUtils001: i64 = 0x14F900;
            pub const Source2Host001: i64 = 0x1402D0;
            pub const GameModelInfo001: i64 = 0x13FFB0;
            pub const GameSystem2HostHook: i64 = 0x13FFF0;
            pub const DebugDrawQueueManager001: i64 = 0x13FF70;
            pub const PredictionDiffManager001: i64 = 0x140100;
            pub const SaveRestoreDataVersion001: i64 = 0x140230;
            pub const SinglePlayerSharedMemory001: i64 = 0x140260;
        };
        pub const tier0_dll = struct {
            pub const VEngineCvar007: i64 = 0x3AC670;
            pub const TestScriptMgr001: i64 = 0x3A1960;
            pub const VProcessUtils002: i64 = 0x3A1820;
            pub const VStringTokenSystem001: i64 = 0x3D3300;
        };
        pub const client_dll = struct {
            pub const LegacyGameUI001: i64 = 0x223E0E0;
            pub const Source2Client002: i64 = 0x255C3A0;
            pub const Source2ClientUI001: i64 = 0x223C960;
            pub const ClientToolsInfo_001: i64 = 0x22317B0;
            pub const GameClientExports001: i64 = 0x222E458;
            pub const Source2ClientConfig001: i64 = 0x24B92B0;
            pub const Source2ClientPrediction001: i64 = 0x2562710;
            pub const EmptyWorldService001_Client: i64 = 0x2215220;
            pub const ClientBugBugServic001_Client: i64 = 0x22317E0;
        };
        pub const server_dll = struct {
            pub const NavGameTest001: i64 = 0x1E50DC8;
            pub const Source2Server001: i64 = 0x1E2F2A0;
            pub const customnavsystem001: i64 = 0x1DA64F0;
            pub const ServerToolsInfo_001: i64 = 0x1E2FCB8;
            pub const Source2GameClients001: i64 = 0x1E2F1E0;
            pub const Source2GameDirector001: i64 = 0x1F99730;
            pub const Source2GameEntities001: i64 = 0x1E2F460;
            pub const Source2ServerConfig001: i64 = 0x2114C98;
            pub const EntitySubclassUtilsV001: i64 = 0x1DB8BC0;
            pub const EmptyWorldService001_Server: i64 = 0x1E09100;
        };
        pub const engine2_dll = struct {
            pub const BugService001: i64 = 0x8DB7F0;
            pub const EngineGameUI001: i64 = 0x6206E0;
            pub const HostStateMgr001: i64 = 0x623540;
            pub const INETSUPPORT_001: i64 = 0x61BC30;
            pub const ToolService_001: i64 = 0x6233B0;
            pub const BugBugService001: i64 = 0x622D80;
            pub const InputService_001: i64 = 0x8DBF20;
            pub const KeyValueCache001: i64 = 0x6235F0;
            pub const SoundService_001: i64 = 0x622FD0;
            pub const StatsService_001: i64 = 0x91BC80;
            pub const VProfService_001: i64 = 0x6233F0;
            pub const GameUIService_001: i64 = 0x8DBC40;
            pub const RenderService_001: i64 = 0x91B680;
            pub const MapListService_001: i64 = 0x91AD90;
            pub const NetworkService_001: i64 = 0x622F90;
            pub const BenchmarkService001: i64 = 0x622C80;
            pub const EngineServiceMgr001: i64 = 0x91C700;
            pub const ScreenshotService001: i64 = 0x91B940;
            pub const NetworkP2PService_001: i64 = 0x91B260;
            pub const SplitScreenService_001: i64 = 0x6232B0;
            pub const NetworkClientService_001: i64 = 0x91AF20;
            pub const NetworkServerService_001: i64 = 0x91B410;
            pub const Source2EngineToClient001: i64 = 0x61FFF0;
            pub const Source2EngineToServer001: i64 = 0x6200C8;
            pub const GameEventSystemClientV001: i64 = 0x91C9E0;
            pub const GameEventSystemServerV001: i64 = 0x91CB10;
            pub const SimpleEngineLoopService_001: i64 = 0x623650;
            pub const GameResourceServiceClientV001: i64 = 0x622DC0;
            pub const GameResourceServiceServerV001: i64 = 0x622E20;
            pub const VENGINE_GAMEUIFUNCS_VERSION005: i64 = 0x620770;
            pub const ClientServerEngineLoopService_001: i64 = 0x91CE30;
            pub const ClientServerSharedHandleSystem001: i64 = 0x91C440;
            pub const Source2EngineToClientStringTable001: i64 = 0x620050;
            pub const Source2EngineToServerStringTable001: i64 = 0x6200F0;
        };
        pub const vscript_dll = struct {
            pub const VScriptManager010: i64 = 0x13E430;
        };
        pub const localize_dll = struct {
            pub const Localize_001: i64 = 0x59120;
        };
        pub const panorama_dll = struct {
            pub const PanoramaUIEngine001: i64 = 0x5895F0;
        };
        pub const v8system_dll = struct {
            pub const Source2V8System001: i64 = 0x34790;
        };
        pub const navsystem_dll = struct {
            pub const NavSystem001: i64 = 0x12C000;
        };
        pub const particles_dll = struct {
            pub const ParticleSystemMgr003: i64 = 0x65AEB0;
        };
        pub const vphysics2_dll = struct {
            pub const VPhysics2_Interface_001: i64 = 0x460E60;
        };
        pub const imemanager_dll = struct {
            pub const IMEManager001: i64 = 0x37AA0;
        };
        pub const meshsystem_dll = struct {
            pub const MeshSystem001: i64 = 0x180AB0;
        };
        pub const steamaudio_dll = struct {
            pub const SteamAudio001: i64 = 0x35C1A0;
        };
        pub const inputsystem_dll = struct {
            pub const InputSystemVersion001: i64 = 0x46BC0;
            pub const InputStackSystemVersion001: i64 = 0x44E90;
        };
        pub const matchmaking_dll = struct {
            pub const GameTypes001: i64 = 0x1B0FD0;
            pub const MATCHFRAMEWORK_001: i64 = 0x1B90A0;
        };
        pub const scenesystem_dll = struct {
            pub const SceneUtils_001: i64 = 0x676760;
            pub const SceneSystem_002: i64 = 0x91FB20;
            pub const RenderingPipelines_001: i64 = 0x675A00;
        };
        pub const soundsystem_dll = struct {
            pub const SoundSystem001: i64 = 0x535350;
            pub const VMixEditTool001: i64 = 0x5943D7F;
            pub const SoundOpSystem001: i64 = 0x535A90;
            pub const SoundOpSystemEdit001: i64 = 0x5359A0;
            pub const SoundBugBugService001_Client: i64 = 0x535BB0;
        };
        pub const pulse_system_dll = struct {
            pub const IPulseSystem_001: i64 = 0x238120;
        };
        pub const schemasystem_dll = struct {
            pub const SchemaSystem_001: i64 = 0x76710;
        };
        pub const networksystem_dll = struct {
            pub const NetworkSystemVersion001: i64 = 0x2911A0;
            pub const NetworkMessagesVersion001: i64 = 0x2A3F30;
            pub const SerializedEntitiesVersion001: i64 = 0x291290;
            pub const FlattenedSerializersVersion001: i64 = 0x277A50;
        };
        pub const worldrenderer_dll = struct {
            pub const WorldRendererMgr001: i64 = 0x236D00;
        };
        pub const resourcesystem_dll = struct {
            pub const ResourceSystem013: i64 = 0x892B0;
        };
        pub const scenefilecache_dll = struct {
            pub const SceneFileCache002: i64 = 0x11D478;
            pub const ResponseRulesCache001: i64 = 0x11D350;
        };
        pub const animationsystem_dll = struct {
            pub const AnimationSystem_001: i64 = 0x8375F8;
            pub const AnimationSystemUtils_001: i64 = 0x83F6D8;
        };
        pub const materialsystem2_dll = struct {
            pub const TextLayout_001: i64 = 0x14BCC0;
            pub const FontManager_001: i64 = 0x1638E0;
            pub const MaterialUtils_001: i64 = 0x14BD30;
            pub const VMaterialSystem2_001: i64 = 0x163530;
            pub const PostProcessingSystem_001: i64 = 0x14BC60;
        };
        pub const filesystem_stdio_dll = struct {
            pub const VFileSystem017: i64 = 0x2143D0;
            pub const VAsyncFileSystem2_001: i64 = 0x214610;
        };
        pub const panoramauiclient_dll = struct {
            pub const PanoramaUIClient001: i64 = 0x270710;
        };
        pub const rendersystemdx11_dll = struct {
            pub const RenderUtils_001: i64 = 0x434BD0;
            pub const RenderDeviceMgr001: i64 = 0x4342F0;
            pub const VRenderDeviceMgrBackdoor001: i64 = 0x434390;
        };
        pub const panorama_text_pango_dll = struct {
            pub const PanoramaTextServices001: i64 = 0x2BA9D0;
        };
    };
};
