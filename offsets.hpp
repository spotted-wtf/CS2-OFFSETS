#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace offsets {
        namespace client_dll {
            inline constexpr std::ptrdiff_t dwWeaponC4 = 0x24CE108;
            inline constexpr std::ptrdiff_t dwCSGOInput = 0x257F980;
            inline constexpr std::ptrdiff_t dwGameRules = 0x2569378;
            inline constexpr std::ptrdiff_t dwPlantedC4 = 0x24CFB60;
            inline constexpr std::ptrdiff_t dwEntityList = 0x271EB28;
            inline constexpr std::ptrdiff_t dwGlobalVars = 0x2234108;
            inline constexpr std::ptrdiff_t dwPrediction = 0x25697D0;
            inline constexpr std::ptrdiff_t dwViewAngles = 0x2580008;
            inline constexpr std::ptrdiff_t dwViewMatrix = 0x256F1D0;
            inline constexpr std::ptrdiff_t dwViewRender = 0x256FB98;
            inline constexpr std::ptrdiff_t dwGlowManager = 0x25660A0;
            inline constexpr std::ptrdiff_t dwLocalPlayerPawn = 0x25698C8;
            inline constexpr std::ptrdiff_t dwGameEntitySystem = 0x271EB28;
            inline constexpr std::ptrdiff_t dwLocalPlayerController = 0x25413F8;
            inline constexpr std::ptrdiff_t dwGameEntitySystem_highestEntityIndex = 0x2120;
        }
        namespace engine2_dll {
            inline constexpr std::ptrdiff_t dwBuildNumber = 0x6BA028;
            inline constexpr std::ptrdiff_t dwWindowWidth = 0x9BCFE8;
            inline constexpr std::ptrdiff_t dwWindowHeight = 0x9BCFEC;
            inline constexpr std::ptrdiff_t dwNetworkGameClient = 0x9B88C0;
            inline constexpr std::ptrdiff_t dwNetworkGameClient_deltaTick = 0x24C;
            inline constexpr std::ptrdiff_t dwNetworkGameClient_maxClients = 0x240;
            inline constexpr std::ptrdiff_t dwNetworkGameClient_localPlayer = 0xF8;
            inline constexpr std::ptrdiff_t dwNetworkGameClient_signOnState = 0x230;
            inline constexpr std::ptrdiff_t dwNetworkGameClient_clientTickCount = 0x398;
            inline constexpr std::ptrdiff_t dwNetworkGameClient_isBackgroundMap = 0x2C143F;
            inline constexpr std::ptrdiff_t dwNetworkGameClient_serverTickCount = 0x24C;
        }
        namespace inputsystem_dll {
            inline constexpr std::ptrdiff_t dwInputSystem = 0x46BC0;
        }
        namespace matchmaking_dll {
            inline constexpr std::ptrdiff_t dwGameTypes = 0x1B0FD0;
        }
        namespace soundsystem_dll {
            inline constexpr std::ptrdiff_t dwSoundSystem = 0x532420;
        }
    }
}
