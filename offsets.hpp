#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace offsets {
        namespace client_dll {
            inline constexpr std::ptrdiff_t dwWeaponC4 = 0x24C9B30;
            inline constexpr std::ptrdiff_t dwCSGOInput = 0x257B640;
            inline constexpr std::ptrdiff_t dwGameRules = 0x25651D0;
            inline constexpr std::ptrdiff_t dwPlantedC4 = 0x24CB3C0;
            inline constexpr std::ptrdiff_t dwEntityList = 0x271A908;
            inline constexpr std::ptrdiff_t dwGlobalVars = 0x2230090;
            inline constexpr std::ptrdiff_t dwPrediction = 0x2565620;
            inline constexpr std::ptrdiff_t dwViewAngles = 0x257BCC8;
            inline constexpr std::ptrdiff_t dwViewMatrix = 0x256B020;
            inline constexpr std::ptrdiff_t dwViewRender = 0x256B9E8;
            inline constexpr std::ptrdiff_t dwGlowManager = 0x2561EF0;
            inline constexpr std::ptrdiff_t dwLocalPlayerPawn = 0x2565718;
            inline constexpr std::ptrdiff_t dwGameEntitySystem = 0x271A908;
            inline constexpr std::ptrdiff_t dwLocalPlayerController = 0x253CB78;
            inline constexpr std::ptrdiff_t dwGameEntitySystem_highestEntityIndex = 0x2120;
        }
        namespace engine2_dll {
            inline constexpr std::ptrdiff_t dwBuildNumber = 0x61CFEC;
            inline constexpr std::ptrdiff_t dwWindowWidth = 0x91F338;
            inline constexpr std::ptrdiff_t dwWindowHeight = 0x91F33C;
            inline constexpr std::ptrdiff_t dwNetworkGameClient = 0x91AFC0;
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
            inline constexpr std::ptrdiff_t dwSoundSystem = 0x535350;
        }
    }
}
