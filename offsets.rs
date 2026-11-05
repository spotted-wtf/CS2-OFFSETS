#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod offsets {
        pub mod client_dll {
            pub const dwWeaponC4: i64 = 0x24CF118;
            pub const dwCSGOInput: i64 = 0x2580A10;
            pub const dwGameRules: i64 = 0x256A3F8;
            pub const dwPlantedC4: i64 = 0x24D0B70;
            pub const dwEntityList: i64 = 0x271FBB8;
            pub const dwGlobalVars: i64 = 0x2235108;
            pub const dwPrediction: i64 = 0x256A850;
            pub const dwViewAngles: i64 = 0x2581098;
            pub const dwViewMatrix: i64 = 0x2570250;
            pub const dwViewRender: i64 = 0x2570C18;
            pub const dwGlowManager: i64 = 0x2567120;
            pub const dwLocalPlayerPawn: i64 = 0x256A948;
            pub const dwGameEntitySystem: i64 = 0x271FBB8;
            pub const dwLocalPlayerController: i64 = 0x2542548;
            pub const dwGameEntitySystem_highestEntityIndex: i64 = 0x2120;
        }
        pub mod engine2_dll {
            pub const dwBuildNumber: i64 = 0x6BA028;
            pub const dwWindowWidth: i64 = 0x9BCFE8;
            pub const dwWindowHeight: i64 = 0x9BCFEC;
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
            pub const dwSoundSystem: i64 = 0x532420;
        }
    }
}
