#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod interfaces {
        pub mod host_dll {
            pub const HostUtils001: i64 = 0x14F900;
            pub const Source2Host001: i64 = 0x1402D0;
            pub const GameModelInfo001: i64 = 0x13FFB0;
            pub const GameSystem2HostHook: i64 = 0x13FFF0;
            pub const DebugDrawQueueManager001: i64 = 0x13FF70;
            pub const PredictionDiffManager001: i64 = 0x140100;
            pub const SaveRestoreDataVersion001: i64 = 0x140230;
            pub const SinglePlayerSharedMemory001: i64 = 0x140260;
        }
        pub mod tier0_dll {
            pub const VEngineCvar007: i64 = 0x3AC670;
            pub const TestScriptMgr001: i64 = 0x3A1960;
            pub const VProcessUtils002: i64 = 0x3A1820;
            pub const VStringTokenSystem001: i64 = 0x3D3300;
        }
        pub mod client_dll {
            pub const LegacyGameUI001: i64 = 0x2244180;
            pub const Source2Client002: i64 = 0x25635A0;
            pub const Source2ClientUI001: i64 = 0x2242900;
            pub const ClientToolsInfo_001: i64 = 0x2237730;
            pub const GameClientExports001: i64 = 0x22343D8;
            pub const Source2ClientConfig001: i64 = 0x24C0150;
            pub const Source2ClientPrediction001: i64 = 0x25697D0;
            pub const EmptyWorldService001_Client: i64 = 0x221B160;
            pub const ClientBugBugServic001_Client: i64 = 0x2237760;
        }
        pub mod server_dll {
            pub const NavGameTest001: i64 = 0x1E58D38;
            pub const Source2Server001: i64 = 0x1E37220;
            pub const customnavsystem001: i64 = 0x1DAE558;
            pub const ServerToolsInfo_001: i64 = 0x1E37C38;
            pub const Source2GameClients001: i64 = 0x1E37160;
            pub const Source2GameDirector001: i64 = 0x1FA1510;
            pub const Source2GameEntities001: i64 = 0x1E373E0;
            pub const Source2ServerConfig001: i64 = 0x211CDE8;
            pub const EntitySubclassUtilsV001: i64 = 0x1DC0C40;
            pub const EmptyWorldService001_Server: i64 = 0x1E110C0;
        }
        pub mod engine2_dll {
            pub const BugService001: i64 = 0x9790F0;
            pub const EngineGameUI001: i64 = 0x6BD720;
            pub const HostStateMgr001: i64 = 0x6C02A0;
            pub const INETSUPPORT_001: i64 = 0x6B8C70;
            pub const ToolService_001: i64 = 0x6C0110;
            pub const BugBugService001: i64 = 0x6BFDC0;
            pub const InputService_001: i64 = 0x979820;
            pub const KeyValueCache001: i64 = 0x6C0350;
            pub const SoundService_001: i64 = 0x9B93F0;
            pub const StatsService_001: i64 = 0x9B9930;
            pub const VProfService_001: i64 = 0x6C0150;
            pub const GameUIService_001: i64 = 0x979540;
            pub const RenderService_001: i64 = 0x9B8F80;
            pub const MapListService_001: i64 = 0x9B8690;
            pub const NetworkService_001: i64 = 0x6BFFD0;
            pub const BenchmarkService001: i64 = 0x6BFCC0;
            pub const EngineServiceMgr001: i64 = 0x9BA3B0;
            pub const ScreenshotService001: i64 = 0x9B9240;
            pub const NetworkP2PService_001: i64 = 0x9B8B60;
            pub const SplitScreenService_001: i64 = 0x6C0010;
            pub const NetworkClientService_001: i64 = 0x9B8820;
            pub const NetworkServerService_001: i64 = 0x9B8D10;
            pub const Source2EngineToClient001: i64 = 0x6BD030;
            pub const Source2EngineToServer001: i64 = 0x6BD108;
            pub const GameEventSystemClientV001: i64 = 0x9BA690;
            pub const GameEventSystemServerV001: i64 = 0x9BA7C0;
            pub const SimpleEngineLoopService_001: i64 = 0x6C03B0;
            pub const GameResourceServiceClientV001: i64 = 0x6BFE00;
            pub const GameResourceServiceServerV001: i64 = 0x6BFE60;
            pub const VENGINE_GAMEUIFUNCS_VERSION005: i64 = 0x6BD7B0;
            pub const ClientServerEngineLoopService_001: i64 = 0x9BAAE0;
            pub const ClientServerSharedHandleSystem001: i64 = 0x9BA0F0;
            pub const Source2EngineToClientStringTable001: i64 = 0x6BD090;
            pub const Source2EngineToServerStringTable001: i64 = 0x6BD130;
        }
        pub mod vscript_dll {
            pub const VScriptManager010: i64 = 0x13E430;
        }
        pub mod localize_dll {
            pub const Localize_001: i64 = 0x59120;
        }
        pub mod panorama_dll {
            pub const PanoramaUIEngine001: i64 = 0x5895F0;
        }
        pub mod v8system_dll {
            pub const Source2V8System001: i64 = 0x34790;
        }
        pub mod navsystem_dll {
            pub const NavSystem001: i64 = 0x12C000;
        }
        pub mod particles_dll {
            pub const ParticleSystemMgr003: i64 = 0x65ADD0;
        }
        pub mod vphysics2_dll {
            pub const VPhysics2_Interface_001: i64 = 0x460E60;
        }
        pub mod imemanager_dll {
            pub const IMEManager001: i64 = 0x37AA0;
        }
        pub mod meshsystem_dll {
            pub const MeshSystem001: i64 = 0x180AB0;
        }
        pub mod steamaudio_dll {
            pub const SteamAudio001: i64 = 0x35C1A0;
        }
        pub mod inputsystem_dll {
            pub const InputSystemVersion001: i64 = 0x46BC0;
            pub const InputStackSystemVersion001: i64 = 0x44E90;
        }
        pub mod matchmaking_dll {
            pub const GameTypes001: i64 = 0x1B0FD0;
            pub const MATCHFRAMEWORK_001: i64 = 0x1B90A0;
        }
        pub mod scenesystem_dll {
            pub const SceneUtils_001: i64 = 0x676750;
            pub const SceneSystem_002: i64 = 0x91FB20;
            pub const RenderingPipelines_001: i64 = 0x6759F0;
        }
        pub mod soundsystem_dll {
            pub const SoundSystem001: i64 = 0x532420;
            pub const VMixEditTool001: i64 = 0x5941C1F;
            pub const SoundOpSystem001: i64 = 0x532B20;
            pub const SoundOpSystemEdit001: i64 = 0x532A30;
            pub const SoundBugBugService001_Client: i64 = 0x532C40;
        }
        pub mod pulse_system_dll {
            pub const IPulseSystem_001: i64 = 0x238120;
        }
        pub mod schemasystem_dll {
            pub const SchemaSystem_001: i64 = 0x76710;
        }
        pub mod networksystem_dll {
            pub const NetworkSystemVersion001: i64 = 0x2911A0;
            pub const NetworkMessagesVersion001: i64 = 0x2A3F30;
            pub const SerializedEntitiesVersion001: i64 = 0x291290;
            pub const FlattenedSerializersVersion001: i64 = 0x277A50;
        }
        pub mod worldrenderer_dll {
            pub const WorldRendererMgr001: i64 = 0x236D40;
        }
        pub mod resourcesystem_dll {
            pub const ResourceSystem013: i64 = 0x89230;
        }
        pub mod scenefilecache_dll {
            pub const SceneFileCache002: i64 = 0x11D478;
            pub const ResponseRulesCache001: i64 = 0x11D350;
        }
        pub mod animationsystem_dll {
            pub const AnimationSystem_001: i64 = 0x8375F8;
            pub const AnimationSystemUtils_001: i64 = 0x83F6D8;
        }
        pub mod materialsystem2_dll {
            pub const TextLayout_001: i64 = 0x14BCC0;
            pub const FontManager_001: i64 = 0x1638E0;
            pub const MaterialUtils_001: i64 = 0x14BD30;
            pub const VMaterialSystem2_001: i64 = 0x163530;
            pub const PostProcessingSystem_001: i64 = 0x14BC60;
        }
        pub mod filesystem_stdio_dll {
            pub const VFileSystem017: i64 = 0x2143D0;
            pub const VAsyncFileSystem2_001: i64 = 0x214610;
        }
        pub mod panoramauiclient_dll {
            pub const PanoramaUIClient001: i64 = 0x270710;
        }
        pub mod rendersystemdx11_dll {
            pub const RenderUtils_001: i64 = 0x434BD0;
            pub const RenderDeviceMgr001: i64 = 0x4342F0;
            pub const VRenderDeviceMgrBackdoor001: i64 = 0x434390;
        }
        pub mod panorama_text_pango_dll {
            pub const PanoramaTextServices001: i64 = 0x2BA9D0;
        }
    }
}
