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
            inline constexpr std::ptrdiff_t LegacyGameUI001 = 0x22351A0;
            inline constexpr std::ptrdiff_t Source2Client002 = 0x2551600;
            inline constexpr std::ptrdiff_t Source2ClientUI001 = 0x22322A0;
            inline constexpr std::ptrdiff_t ClientToolsInfo_001 = 0x2227160;
            inline constexpr std::ptrdiff_t GameClientExports001 = 0x2223E08;
            inline constexpr std::ptrdiff_t Source2ClientConfig001 = 0x24AE080;
            inline constexpr std::ptrdiff_t Source2ClientPrediction001 = 0x25579C0;
            inline constexpr std::ptrdiff_t EmptyWorldService001_Client = 0x220AEA0;
            inline constexpr std::ptrdiff_t ClientBugBugServic001_Client = 0x2227190;
        }
        namespace server_dll {
            inline constexpr std::ptrdiff_t NavGameTest001 = 0x1E3C898;
            inline constexpr std::ptrdiff_t Source2Server001 = 0x1E1ADA0;
            inline constexpr std::ptrdiff_t customnavsystem001 = 0x1D924A8;
            inline constexpr std::ptrdiff_t ServerToolsInfo_001 = 0x1E1B7B8;
            inline constexpr std::ptrdiff_t Source2GameClients001 = 0x1E1ACE0;
            inline constexpr std::ptrdiff_t Source2GameDirector001 = 0x1F81A80;
            inline constexpr std::ptrdiff_t Source2GameEntities001 = 0x1E1AF60;
            inline constexpr std::ptrdiff_t Source2ServerConfig001 = 0x20FD3F8;
            inline constexpr std::ptrdiff_t EntitySubclassUtilsV001 = 0x1DA4B50;
            inline constexpr std::ptrdiff_t EmptyWorldService001_Server = 0x1DF4EA0;
        }
        namespace engine2_dll {
            inline constexpr std::ptrdiff_t BugService001 = 0x9703C0;
            inline constexpr std::ptrdiff_t EngineGameUI001 = 0x6B6430;
            inline constexpr std::ptrdiff_t HostStateMgr001 = 0x6B8FB0;
            inline constexpr std::ptrdiff_t INETSUPPORT_001 = 0x6B1980;
            inline constexpr std::ptrdiff_t ToolService_001 = 0x6B8E20;
            inline constexpr std::ptrdiff_t BugBugService001 = 0x6B8AD0;
            inline constexpr std::ptrdiff_t InputService_001 = 0x970AF0;
            inline constexpr std::ptrdiff_t KeyValueCache001 = 0x6B9060;
            inline constexpr std::ptrdiff_t SoundService_001 = 0x9B06D0;
            inline constexpr std::ptrdiff_t StatsService_001 = 0x9B0C10;
            inline constexpr std::ptrdiff_t VProfService_001 = 0x6B8E60;
            inline constexpr std::ptrdiff_t GameUIService_001 = 0x970810;
            inline constexpr std::ptrdiff_t RenderService_001 = 0x9B0250;
            inline constexpr std::ptrdiff_t MapListService_001 = 0x9AF960;
            inline constexpr std::ptrdiff_t NetworkService_001 = 0x6B8CE0;
            inline constexpr std::ptrdiff_t BenchmarkService001 = 0x6B89D0;
            inline constexpr std::ptrdiff_t EngineServiceMgr001 = 0x9B1680;
            inline constexpr std::ptrdiff_t ScreenshotService001 = 0x9B0520;
            inline constexpr std::ptrdiff_t NetworkP2PService_001 = 0x9AFE30;
            inline constexpr std::ptrdiff_t SplitScreenService_001 = 0x6B8D20;
            inline constexpr std::ptrdiff_t NetworkClientService_001 = 0x9AFAF0;
            inline constexpr std::ptrdiff_t NetworkServerService_001 = 0x9AFFE0;
            inline constexpr std::ptrdiff_t Source2EngineToClient001 = 0x6B5D40;
            inline constexpr std::ptrdiff_t Source2EngineToServer001 = 0x6B5E18;
            inline constexpr std::ptrdiff_t GameEventSystemClientV001 = 0x9B1970;
            inline constexpr std::ptrdiff_t GameEventSystemServerV001 = 0x9B1AA0;
            inline constexpr std::ptrdiff_t SimpleEngineLoopService_001 = 0x6B90C0;
            inline constexpr std::ptrdiff_t GameResourceServiceClientV001 = 0x6B8B10;
            inline constexpr std::ptrdiff_t GameResourceServiceServerV001 = 0x6B8B70;
            inline constexpr std::ptrdiff_t VENGINE_GAMEUIFUNCS_VERSION005 = 0x6B64C0;
            inline constexpr std::ptrdiff_t ClientServerEngineLoopService_001 = 0x9B1DE0;
            inline constexpr std::ptrdiff_t ClientServerSharedHandleSystem001 = 0x9B13D0;
            inline constexpr std::ptrdiff_t Source2EngineToClientStringTable001 = 0x6B5DA0;
            inline constexpr std::ptrdiff_t Source2EngineToServerStringTable001 = 0x6B5E40;
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
            inline constexpr std::ptrdiff_t ParticleSystemMgr003 = 0x65AEE0;
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
            inline constexpr std::ptrdiff_t GameTypes001 = 0x1AEFC0;
            inline constexpr std::ptrdiff_t MATCHFRAMEWORK_001 = 0x1B7080;
        }
        namespace scenesystem_dll {
            inline constexpr std::ptrdiff_t SceneUtils_001 = 0x676760;
            inline constexpr std::ptrdiff_t SceneSystem_002 = 0x91FB20;
            inline constexpr std::ptrdiff_t RenderingPipelines_001 = 0x675A00;
        }
        namespace soundsystem_dll {
            inline constexpr std::ptrdiff_t SoundSystem001 = 0x532470;
            inline constexpr std::ptrdiff_t VMixEditTool001 = 0x5941BBF;
            inline constexpr std::ptrdiff_t SoundOpSystem001 = 0x532B70;
            inline constexpr std::ptrdiff_t SoundOpSystemEdit001 = 0x532A80;
            inline constexpr std::ptrdiff_t SoundBugBugService001_Client = 0x532C90;
        }
        namespace pulse_system_dll {
            inline constexpr std::ptrdiff_t IPulseSystem_001 = 0x238120;
        }
        namespace schemasystem_dll {
            inline constexpr std::ptrdiff_t SchemaSystem_001 = 0x76710;
        }
        namespace networksystem_dll {
            inline constexpr std::ptrdiff_t NetworkSystemVersion001 = 0x28C450;
            inline constexpr std::ptrdiff_t NetworkMessagesVersion001 = 0x29EE00;
            inline constexpr std::ptrdiff_t SerializedEntitiesVersion001 = 0x28C530;
            inline constexpr std::ptrdiff_t FlattenedSerializersVersion001 = 0x272A30;
        }
        namespace worldrenderer_dll {
            inline constexpr std::ptrdiff_t WorldRendererMgr001 = 0x236D40;
        }
        namespace resourcesystem_dll {
            inline constexpr std::ptrdiff_t ResourceSystem013 = 0x89230;
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
