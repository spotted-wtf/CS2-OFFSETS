#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod offsets {
        pub mod client_dll {
            pub const dwWeaponC4: i64 = 0x24CBEE8;
            pub const dwCSGOInput: i64 = 0x257D780;
            pub const dwGameRules: i64 = 0x2567188;
            pub const dwPlantedC4: i64 = 0x24CD930;
            pub const dwEntityList: i64 = 0x271C8B8;
            pub const dwGlobalVars: i64 = 0x2232088;
            pub const dwPrediction: i64 = 0x25675E0;
            pub const dwViewAngles: i64 = 0x257DE08;
            pub const dwViewMatrix: i64 = 0x256CFE0;
            pub const dwViewRender: i64 = 0x256D9A8;
            pub const dwGlowManager: i64 = 0x2563EB0;
            pub const dwLocalPlayerPawn: i64 = 0x25676D8;
            pub const dwGameEntitySystem: i64 = 0x271C8B8;
            pub const dwLocalPlayerController: i64 = 0x253EEF8;
            pub const dwGameEntitySystem_highestEntityIndex: i64 = 0x2120;
        }
        pub mod engine2_dll {
            pub const dwBuildNumber: i64 = 0x6BA02C;
            pub const dwWindowWidth: i64 = 0x9BCFF0;
            pub const dwWindowHeight: i64 = 0x9BCFF4;
            pub const dwNetworkGameClient: i64 = 0x9B88C0;
            pub const dwNetworkGameClient_deltaTick: i64 = 0x24C;
            pub const dwNetworkGameClient_maxClients: i64 = 0x240;
            pub const dwNetworkGameClient_localPlayer: i64 = 0xF8;
            pub const dwNetworkGameClient_signOnState: i64 = 0x230;
            pub const dwNetworkGameClient_clientTickCount: i64 = 0x398;
            pub const dwNetworkGameClient_isBackgroundMap: i64 = 0x2C143F;
            pub const dwNetworkGameClient_serverTickCount: i64 = 0x24C;
        }
        pub mod inputsystem_dll {
            pub const dwInputSystem: i64 = 0x46BC0;
        }
        pub mod matchmaking_dll {
            pub const dwGameTypes: i64 = 0x1B0FD0;
        }
        pub mod soundsystem_dll {
            pub const dwSoundSystem: i64 = 0x532460;
        }
    }
}
