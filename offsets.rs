#![allow(non_upper_case_globals, non_snake_case)]
pub mod cs2_dumper {
    pub mod offsets {
        pub mod client_dll {
            pub const dwWeaponC4: i64 = 0x24BB680;
            pub const dwCSGOInput: i64 = 0x256CFE0;
            pub const dwGameRules: i64 = 0x2556E78;
            pub const dwPlantedC4: i64 = 0x24BD9E8;
            pub const dwEntityList: i64 = 0x270C680;
            pub const dwGlobalVars: i64 = 0x2223AD0;
            pub const dwPrediction: i64 = 0x2557440;
            pub const dwViewAngles: i64 = 0x256D668;
            pub const dwViewMatrix: i64 = 0x255CE50;
            pub const dwViewRender: i64 = 0x255D818;
            pub const dwGlowManager: i64 = 0x2553B90;
            pub const dwSensitivity: i64 = 0x25546C8;
            pub const dwLocalPlayerPawn: i64 = 0x2557538;
            pub const dwGameEntitySystem: i64 = 0x270C680;
            pub const dwLocalPlayerController: i64 = 0x252ED78;
            pub const dwSensitivity_sensitivity: i64 = 0x58;
            pub const dwServerConfirmedReservation: i64 = 0x256E1C8;
            pub const dwGameEntitySystem_highestEntityIndex: i64 = 0x2120;
        }
        pub mod engine2_dll {
            pub const dwBuildNumber: i64 = 0x6B2D18;
            pub const dwWindowWidth: i64 = 0x9B4290;
            pub const dwWindowHeight: i64 = 0x9B4294;
            pub const dwNetworkGameClient: i64 = 0x9AFB30;
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
            pub const dwGameTypes: i64 = 0x1AEFC0;
        }
        pub mod soundsystem_dll {
            pub const dwSoundSystem: i64 = 0x532470;
            pub const dwSoundSystem_engineViewData: i64 = 0x6C;
        }
    }
}
