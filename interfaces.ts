export namespace cs2_dumper {
    export namespace interfaces {
        export namespace host_dll {
            export const HostUtils001 = 0x14F900;
            export const Source2Host001 = 0x1402D0;
            export const GameModelInfo001 = 0x13FFB0;
            export const GameSystem2HostHook = 0x13FFF0;
            export const DebugDrawQueueManager001 = 0x13FF70;
            export const PredictionDiffManager001 = 0x140100;
            export const SaveRestoreDataVersion001 = 0x140230;
            export const SinglePlayerSharedMemory001 = 0x140260;
        }
        export namespace tier0_dll {
            export const VEngineCvar007 = 0x3AC670;
            export const TestScriptMgr001 = 0x3A1960;
            export const VProcessUtils002 = 0x3A1820;
            export const VStringTokenSystem001 = 0x3D3300;
        }
        export namespace client_dll {
            export const LegacyGameUI001 = 0x22351A0;
            export const Source2Client002 = 0x2551080;
            export const Source2ClientUI001 = 0x22322A0;
            export const ClientToolsInfo_001 = 0x2227160;
            export const GameClientExports001 = 0x2223E08;
            export const Source2ClientConfig001 = 0x24ADB00;
            export const Source2ClientPrediction001 = 0x2557440;
            export const EmptyWorldService001_Client = 0x220AEA0;
            export const ClientBugBugServic001_Client = 0x2227190;
        }
        export namespace server_dll {
            export const NavGameTest001 = 0x1E3C898;
            export const Source2Server001 = 0x1E1ADA0;
            export const customnavsystem001 = 0x1D924A8;
            export const ServerToolsInfo_001 = 0x1E1B7B8;
            export const Source2GameClients001 = 0x1E1ACE0;
            export const Source2GameDirector001 = 0x1F81A80;
            export const Source2GameEntities001 = 0x1E1AF60;
            export const Source2ServerConfig001 = 0x20FD3F8;
            export const EntitySubclassUtilsV001 = 0x1DA4B50;
            export const EmptyWorldService001_Server = 0x1DF4EA0;
        }
        export namespace engine2_dll {
            export const BugService001 = 0x970360;
            export const EngineGameUI001 = 0x6B6430;
            export const HostStateMgr001 = 0x6B8FB0;
            export const INETSUPPORT_001 = 0x6B1980;
            export const ToolService_001 = 0x6B8E20;
            export const BugBugService001 = 0x6B8AD0;
            export const InputService_001 = 0x970A90;
            export const KeyValueCache001 = 0x6B9060;
            export const SoundService_001 = 0x9B0670;
            export const StatsService_001 = 0x9B0BB0;
            export const VProfService_001 = 0x6B8E60;
            export const GameUIService_001 = 0x9707B0;
            export const RenderService_001 = 0x9B01F0;
            export const MapListService_001 = 0x9AF900;
            export const NetworkService_001 = 0x6B8CE0;
            export const BenchmarkService001 = 0x6B89D0;
            export const EngineServiceMgr001 = 0x9B1620;
            export const ScreenshotService001 = 0x9B04C0;
            export const NetworkP2PService_001 = 0x9AFDD0;
            export const SplitScreenService_001 = 0x6B8D20;
            export const NetworkClientService_001 = 0x9AFA90;
            export const NetworkServerService_001 = 0x9AFF80;
            export const Source2EngineToClient001 = 0x6B5D40;
            export const Source2EngineToServer001 = 0x6B5E18;
            export const GameEventSystemClientV001 = 0x9B1910;
            export const GameEventSystemServerV001 = 0x9B1A40;
            export const SimpleEngineLoopService_001 = 0x6B90C0;
            export const GameResourceServiceClientV001 = 0x6B8B10;
            export const GameResourceServiceServerV001 = 0x6B8B70;
            export const VENGINE_GAMEUIFUNCS_VERSION005 = 0x6B64C0;
            export const ClientServerEngineLoopService_001 = 0x9B1D80;
            export const ClientServerSharedHandleSystem001 = 0x9B1370;
            export const Source2EngineToClientStringTable001 = 0x6B5DA0;
            export const Source2EngineToServerStringTable001 = 0x6B5E40;
        }
        export namespace vscript_dll {
            export const VScriptManager010 = 0x13E430;
        }
        export namespace localize_dll {
            export const Localize_001 = 0x59120;
        }
        export namespace panorama_dll {
            export const PanoramaUIEngine001 = 0x5895F0;
        }
        export namespace v8system_dll {
            export const Source2V8System001 = 0x34790;
        }
        export namespace navsystem_dll {
            export const NavSystem001 = 0x12C000;
        }
        export namespace particles_dll {
            export const ParticleSystemMgr003 = 0x65AEE0;
        }
        export namespace vphysics2_dll {
            export const VPhysics2_Interface_001 = 0x460E60;
        }
        export namespace imemanager_dll {
            export const IMEManager001 = 0x37AA0;
        }
        export namespace meshsystem_dll {
            export const MeshSystem001 = 0x180AB0;
        }
        export namespace steamaudio_dll {
            export const SteamAudio001 = 0x35C1A0;
        }
        export namespace inputsystem_dll {
            export const InputSystemVersion001 = 0x46BC0;
            export const InputStackSystemVersion001 = 0x44E90;
        }
        export namespace matchmaking_dll {
            export const GameTypes001 = 0x1AEFC0;
            export const MATCHFRAMEWORK_001 = 0x1B7080;
        }
        export namespace scenesystem_dll {
            export const SceneUtils_001 = 0x676760;
            export const SceneSystem_002 = 0x91FB20;
            export const RenderingPipelines_001 = 0x675A00;
        }
        export namespace soundsystem_dll {
            export const SoundSystem001 = 0x532470;
            export const VMixEditTool001 = 0x5941BBF;
            export const SoundOpSystem001 = 0x532B70;
            export const SoundOpSystemEdit001 = 0x532A80;
            export const SoundBugBugService001_Client = 0x532C90;
        }
        export namespace pulse_system_dll {
            export const IPulseSystem_001 = 0x238120;
        }
        export namespace schemasystem_dll {
            export const SchemaSystem_001 = 0x76710;
        }
        export namespace networksystem_dll {
            export const NetworkSystemVersion001 = 0x28C450;
            export const NetworkMessagesVersion001 = 0x29EE00;
            export const SerializedEntitiesVersion001 = 0x28C530;
            export const FlattenedSerializersVersion001 = 0x272A30;
        }
        export namespace worldrenderer_dll {
            export const WorldRendererMgr001 = 0x236D40;
        }
        export namespace resourcesystem_dll {
            export const ResourceSystem013 = 0x89230;
        }
        export namespace scenefilecache_dll {
            export const SceneFileCache002 = 0x11D478;
            export const ResponseRulesCache001 = 0x11D350;
        }
        export namespace animationsystem_dll {
            export const AnimationSystem_001 = 0x8375F8;
            export const AnimationSystemUtils_001 = 0x83F6D8;
        }
        export namespace materialsystem2_dll {
            export const TextLayout_001 = 0x14BCC0;
            export const FontManager_001 = 0x1638E0;
            export const MaterialUtils_001 = 0x14BD30;
            export const VMaterialSystem2_001 = 0x163530;
            export const PostProcessingSystem_001 = 0x14BC60;
        }
        export namespace filesystem_stdio_dll {
            export const VFileSystem017 = 0x2143D0;
            export const VAsyncFileSystem2_001 = 0x214610;
        }
        export namespace panoramauiclient_dll {
            export const PanoramaUIClient001 = 0x270710;
        }
        export namespace rendersystemdx11_dll {
            export const RenderUtils_001 = 0x434BD0;
            export const RenderDeviceMgr001 = 0x4342F0;
            export const VRenderDeviceMgrBackdoor001 = 0x434390;
        }
        export namespace panorama_text_pango_dll {
            export const PanoramaTextServices001 = 0x2BA9D0;
        }
    }
}
