#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace interfaces {
        namespace host_dll {
            inline constexpr std::ptrdiff_t HostUtils001 = 0x14F900;
            inline constexpr std::ptrdiff_t Source2Host001 = 0x1402D0;
            inline constexpr std::ptrdiff_t GameModelInfo001 = 0x13FFB0;
            inline constexpr std::ptrdiff_t GameSystem2HostHook = 0x13FFF0;
            inline constexpr std::ptrdiff_t DebugDrawQueueManager001 = 0x13FF70;
            inline constexpr std::ptrdiff_t PredictionDiffManager001 = 0x140100;
            inline constexpr std::ptrdiff_t SaveRestoreDataVersion001 = 0x140230;
            inline constexpr std::ptrdiff_t SinglePlayerSharedMemory001 = 0x140260;
        }
        namespace tier0_dll {
            inline constexpr std::ptrdiff_t VEngineCvar007 = 0x3AC670;
            inline constexpr std::ptrdiff_t TestScriptMgr001 = 0x3A1960;
            inline constexpr std::ptrdiff_t VProcessUtils002 = 0x3A1820;
            inline constexpr std::ptrdiff_t VStringTokenSystem001 = 0x3D3300;
        }
        namespace client_dll {
            inline constexpr std::ptrdiff_t LegacyGameUI001 = 0x2238010;
            inline constexpr std::ptrdiff_t Source2Client002 = 0x25560E0;
            inline constexpr std::ptrdiff_t Source2ClientUI001 = 0x2236890;
            inline constexpr std::ptrdiff_t ClientToolsInfo_001 = 0x222B6B0;
            inline constexpr std::ptrdiff_t GameClientExports001 = 0x2228358;
            inline constexpr std::ptrdiff_t Source2ClientConfig001 = 0x24B2C90;
            inline constexpr std::ptrdiff_t Source2ClientPrediction001 = 0x255C2D0;
            inline constexpr std::ptrdiff_t EmptyWorldService001_Client = 0x220F100;
            inline constexpr std::ptrdiff_t ClientBugBugServic001_Client = 0x222B6E0;
        }
        namespace server_dll {
            inline constexpr std::ptrdiff_t NavGameTest001 = 0x1E4ACA8;
            inline constexpr std::ptrdiff_t Source2Server001 = 0x1E291B0;
            inline constexpr std::ptrdiff_t customnavsystem001 = 0x1DA0528;
            inline constexpr std::ptrdiff_t ServerToolsInfo_001 = 0x1E29BC8;
            inline constexpr std::ptrdiff_t Source2GameClients001 = 0x1E290F0;
            inline constexpr std::ptrdiff_t Source2GameDirector001 = 0x1F930F0;
            inline constexpr std::ptrdiff_t Source2GameEntities001 = 0x1E29370;
            inline constexpr std::ptrdiff_t Source2ServerConfig001 = 0x210E998;
            inline constexpr std::ptrdiff_t EntitySubclassUtilsV001 = 0x1DB2C20;
            inline constexpr std::ptrdiff_t EmptyWorldService001_Server = 0x1E03070;
        }
        namespace engine2_dll {
            inline constexpr std::ptrdiff_t BugService001 = 0x8DB7F0;
            inline constexpr std::ptrdiff_t EngineGameUI001 = 0x6206E0;
            inline constexpr std::ptrdiff_t HostStateMgr001 = 0x623540;
            inline constexpr std::ptrdiff_t INETSUPPORT_001 = 0x61BC30;
            inline constexpr std::ptrdiff_t ToolService_001 = 0x6233B0;
            inline constexpr std::ptrdiff_t BugBugService001 = 0x622D80;
            inline constexpr std::ptrdiff_t InputService_001 = 0x8DBF20;
            inline constexpr std::ptrdiff_t KeyValueCache001 = 0x6235F0;
            inline constexpr std::ptrdiff_t SoundService_001 = 0x622FD0;
            inline constexpr std::ptrdiff_t StatsService_001 = 0x91BC80;
            inline constexpr std::ptrdiff_t VProfService_001 = 0x6233F0;
            inline constexpr std::ptrdiff_t GameUIService_001 = 0x8DBC40;
            inline constexpr std::ptrdiff_t RenderService_001 = 0x91B680;
            inline constexpr std::ptrdiff_t MapListService_001 = 0x91AD90;
            inline constexpr std::ptrdiff_t NetworkService_001 = 0x622F90;
            inline constexpr std::ptrdiff_t BenchmarkService001 = 0x622C80;
            inline constexpr std::ptrdiff_t EngineServiceMgr001 = 0x91C700;
            inline constexpr std::ptrdiff_t ScreenshotService001 = 0x91B940;
            inline constexpr std::ptrdiff_t NetworkP2PService_001 = 0x91B260;
            inline constexpr std::ptrdiff_t SplitScreenService_001 = 0x6232B0;
            inline constexpr std::ptrdiff_t NetworkClientService_001 = 0x91AF20;
            inline constexpr std::ptrdiff_t NetworkServerService_001 = 0x91B410;
            inline constexpr std::ptrdiff_t Source2EngineToClient001 = 0x61FFF0;
            inline constexpr std::ptrdiff_t Source2EngineToServer001 = 0x6200C8;
            inline constexpr std::ptrdiff_t GameEventSystemClientV001 = 0x91C9E0;
            inline constexpr std::ptrdiff_t GameEventSystemServerV001 = 0x91CB10;
            inline constexpr std::ptrdiff_t SimpleEngineLoopService_001 = 0x623650;
            inline constexpr std::ptrdiff_t GameResourceServiceClientV001 = 0x622DC0;
            inline constexpr std::ptrdiff_t GameResourceServiceServerV001 = 0x622E20;
            inline constexpr std::ptrdiff_t VENGINE_GAMEUIFUNCS_VERSION005 = 0x620770;
            inline constexpr std::ptrdiff_t ClientServerEngineLoopService_001 = 0x91CE30;
            inline constexpr std::ptrdiff_t ClientServerSharedHandleSystem001 = 0x91C440;
            inline constexpr std::ptrdiff_t Source2EngineToClientStringTable001 = 0x620050;
            inline constexpr std::ptrdiff_t Source2EngineToServerStringTable001 = 0x6200F0;
        }
        namespace vscript_dll {
            inline constexpr std::ptrdiff_t VScriptManager010 = 0x13E430;
        }
        namespace localize_dll {
            inline constexpr std::ptrdiff_t Localize_001 = 0x59120;
        }
        namespace panorama_dll {
            inline constexpr std::ptrdiff_t PanoramaUIEngine001 = 0x5895F0;
        }
        namespace v8system_dll {
            inline constexpr std::ptrdiff_t Source2V8System001 = 0x34790;
        }
        namespace navsystem_dll {
            inline constexpr std::ptrdiff_t NavSystem001 = 0x12C000;
        }
        namespace particles_dll {
            inline constexpr std::ptrdiff_t ParticleSystemMgr003 = 0x65AEB0;
        }
        namespace vphysics2_dll {
            inline constexpr std::ptrdiff_t VPhysics2_Interface_001 = 0x460E60;
        }
        namespace imemanager_dll {
            inline constexpr std::ptrdiff_t IMEManager001 = 0x37AA0;
        }
        namespace meshsystem_dll {
            inline constexpr std::ptrdiff_t MeshSystem001 = 0x180AB0;
        }
        namespace steamaudio_dll {
            inline constexpr std::ptrdiff_t SteamAudio001 = 0x35C1A0;
        }
        namespace inputsystem_dll {
            inline constexpr std::ptrdiff_t InputSystemVersion001 = 0x46BC0;
            inline constexpr std::ptrdiff_t InputStackSystemVersion001 = 0x44E90;
        }
        namespace matchmaking_dll {
            inline constexpr std::ptrdiff_t GameTypes001 = 0x1B0FD0;
            inline constexpr std::ptrdiff_t MATCHFRAMEWORK_001 = 0x1B90A0;
        }
        namespace scenesystem_dll {
            inline constexpr std::ptrdiff_t SceneUtils_001 = 0x676760;
            inline constexpr std::ptrdiff_t SceneSystem_002 = 0x91FB20;
            inline constexpr std::ptrdiff_t RenderingPipelines_001 = 0x675A00;
        }
        namespace soundsystem_dll {
            inline constexpr std::ptrdiff_t SoundSystem001 = 0x535350;
            inline constexpr std::ptrdiff_t VMixEditTool001 = 0x5943D7F;
            inline constexpr std::ptrdiff_t SoundOpSystem001 = 0x535A90;
            inline constexpr std::ptrdiff_t SoundOpSystemEdit001 = 0x5359A0;
            inline constexpr std::ptrdiff_t SoundBugBugService001_Client = 0x535BB0;
        }
        namespace pulse_system_dll {
            inline constexpr std::ptrdiff_t IPulseSystem_001 = 0x238120;
        }
        namespace schemasystem_dll {
            inline constexpr std::ptrdiff_t SchemaSystem_001 = 0x76710;
        }
        namespace networksystem_dll {
            inline constexpr std::ptrdiff_t NetworkSystemVersion001 = 0x2911A0;
            inline constexpr std::ptrdiff_t NetworkMessagesVersion001 = 0x2A3F30;
            inline constexpr std::ptrdiff_t SerializedEntitiesVersion001 = 0x291290;
            inline constexpr std::ptrdiff_t FlattenedSerializersVersion001 = 0x277A50;
        }
        namespace worldrenderer_dll {
            inline constexpr std::ptrdiff_t WorldRendererMgr001 = 0x236D00;
        }
        namespace resourcesystem_dll {
            inline constexpr std::ptrdiff_t ResourceSystem013 = 0x892B0;
        }
        namespace scenefilecache_dll {
            inline constexpr std::ptrdiff_t SceneFileCache002 = 0x11D478;
            inline constexpr std::ptrdiff_t ResponseRulesCache001 = 0x11D350;
        }
        namespace animationsystem_dll {
            inline constexpr std::ptrdiff_t AnimationSystem_001 = 0x8375F8;
            inline constexpr std::ptrdiff_t AnimationSystemUtils_001 = 0x83F6D8;
        }
        namespace materialsystem2_dll {
            inline constexpr std::ptrdiff_t TextLayout_001 = 0x14BCC0;
            inline constexpr std::ptrdiff_t FontManager_001 = 0x1638E0;
            inline constexpr std::ptrdiff_t MaterialUtils_001 = 0x14BD30;
            inline constexpr std::ptrdiff_t VMaterialSystem2_001 = 0x163530;
            inline constexpr std::ptrdiff_t PostProcessingSystem_001 = 0x14BC60;
        }
        namespace filesystem_stdio_dll {
            inline constexpr std::ptrdiff_t VFileSystem017 = 0x2143D0;
            inline constexpr std::ptrdiff_t VAsyncFileSystem2_001 = 0x214610;
        }
        namespace panoramauiclient_dll {
            inline constexpr std::ptrdiff_t PanoramaUIClient001 = 0x270710;
        }
        namespace rendersystemdx11_dll {
            inline constexpr std::ptrdiff_t RenderUtils_001 = 0x434BD0;
            inline constexpr std::ptrdiff_t RenderDeviceMgr001 = 0x4342F0;
            inline constexpr std::ptrdiff_t VRenderDeviceMgrBackdoor001 = 0x434390;
        }
        namespace panorama_text_pango_dll {
            inline constexpr std::ptrdiff_t PanoramaTextServices001 = 0x2BA9D0;
        }
    }
}
