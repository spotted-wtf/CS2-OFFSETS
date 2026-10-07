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
            export const LegacyGameUI001 = 0x223E0E0;
            export const Source2Client002 = 0x255C3A0;
            export const Source2ClientUI001 = 0x223C960;
            export const ClientToolsInfo_001 = 0x22317B0;
            export const GameClientExports001 = 0x222E458;
            export const Source2ClientConfig001 = 0x24B92B0;
            export const Source2ClientPrediction001 = 0x2562710;
            export const EmptyWorldService001_Client = 0x2215220;
            export const ClientBugBugServic001_Client = 0x22317E0;
        }
        export namespace server_dll {
            export const NavGameTest001 = 0x1E50DC8;
            export const Source2Server001 = 0x1E2F2A0;
            export const customnavsystem001 = 0x1DA64F0;
            export const ServerToolsInfo_001 = 0x1E2FCB8;
            export const Source2GameClients001 = 0x1E2F1E0;
            export const Source2GameDirector001 = 0x1F99730;
            export const Source2GameEntities001 = 0x1E2F460;
            export const Source2ServerConfig001 = 0x2114C98;
            export const EntitySubclassUtilsV001 = 0x1DB8BC0;
            export const EmptyWorldService001_Server = 0x1E09100;
        }
        export namespace engine2_dll {
            export const BugService001 = 0x8DB7F0;
            export const EngineGameUI001 = 0x6206E0;
            export const HostStateMgr001 = 0x623540;
            export const INETSUPPORT_001 = 0x61BC30;
            export const ToolService_001 = 0x6233B0;
            export const BugBugService001 = 0x622D80;
            export const InputService_001 = 0x8DBF20;
            export const KeyValueCache001 = 0x6235F0;
            export const SoundService_001 = 0x622FD0;
            export const StatsService_001 = 0x91BC80;
            export const VProfService_001 = 0x6233F0;
            export const GameUIService_001 = 0x8DBC40;
            export const RenderService_001 = 0x91B680;
            export const MapListService_001 = 0x91AD90;
            export const NetworkService_001 = 0x622F90;
            export const BenchmarkService001 = 0x622C80;
            export const EngineServiceMgr001 = 0x91C700;
            export const ScreenshotService001 = 0x91B940;
            export const NetworkP2PService_001 = 0x91B260;
            export const SplitScreenService_001 = 0x6232B0;
            export const NetworkClientService_001 = 0x91AF20;
            export const NetworkServerService_001 = 0x91B410;
            export const Source2EngineToClient001 = 0x61FFF0;
            export const Source2EngineToServer001 = 0x6200C8;
            export const GameEventSystemClientV001 = 0x91C9E0;
            export const GameEventSystemServerV001 = 0x91CB10;
            export const SimpleEngineLoopService_001 = 0x623650;
            export const GameResourceServiceClientV001 = 0x622DC0;
            export const GameResourceServiceServerV001 = 0x622E20;
            export const VENGINE_GAMEUIFUNCS_VERSION005 = 0x620770;
            export const ClientServerEngineLoopService_001 = 0x91CE30;
            export const ClientServerSharedHandleSystem001 = 0x91C440;
            export const Source2EngineToClientStringTable001 = 0x620050;
            export const Source2EngineToServerStringTable001 = 0x6200F0;
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
            export const ParticleSystemMgr003 = 0x65AEB0;
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
            export const GameTypes001 = 0x1B0FD0;
            export const MATCHFRAMEWORK_001 = 0x1B90A0;
        }
        export namespace scenesystem_dll {
            export const SceneUtils_001 = 0x676760;
            export const SceneSystem_002 = 0x91FB20;
            export const RenderingPipelines_001 = 0x675A00;
        }
        export namespace soundsystem_dll {
            export const SoundSystem001 = 0x535350;
            export const VMixEditTool001 = 0x5943D7F;
            export const SoundOpSystem001 = 0x535A90;
            export const SoundOpSystemEdit001 = 0x5359A0;
            export const SoundBugBugService001_Client = 0x535BB0;
        }
        export namespace pulse_system_dll {
            export const IPulseSystem_001 = 0x238120;
        }
        export namespace schemasystem_dll {
            export const SchemaSystem_001 = 0x76710;
        }
        export namespace networksystem_dll {
            export const NetworkSystemVersion001 = 0x2911A0;
            export const NetworkMessagesVersion001 = 0x2A3F30;
            export const SerializedEntitiesVersion001 = 0x291290;
            export const FlattenedSerializersVersion001 = 0x277A50;
        }
        export namespace worldrenderer_dll {
            export const WorldRendererMgr001 = 0x236D00;
        }
        export namespace resourcesystem_dll {
            export const ResourceSystem013 = 0x892B0;
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
