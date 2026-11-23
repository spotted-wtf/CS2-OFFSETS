pub const cs2_dumper = struct {
    pub const offsets = struct {
        pub const client_dll = struct {
            pub const dwWeaponC4: i64 = 0x24C2C00;
            pub const dwCSGOInput: i64 = 0x2574560;
            pub const dwGameRules: i64 = 0x255E3F8;
            pub const dwPlantedC4: i64 = 0x24C4F68;
            pub const dwEntityList: i64 = 0x27145B0;
            pub const dwGlobalVars: i64 = 0x222AAD0;
            pub const dwPrediction: i64 = 0x255E9C0;
            pub const dwViewAngles: i64 = 0x2574BE8;
            pub const dwViewMatrix: i64 = 0x25643D0;
            pub const dwViewRender: i64 = 0x2564D98;
            pub const dwGlowManager: i64 = 0x255B110;
            pub const dwSensitivity: i64 = 0x255BC48;
            pub const dwLocalPlayerPawn: i64 = 0x255EAB8;
            pub const dwGameEntitySystem: i64 = 0x27145B0;
            pub const dwLocalPlayerController: i64 = 0x2536300;
            pub const dwSensitivity_sensitivity: i64 = 0x58;
            pub const dwServerConfirmedReservation: i64 = 0x2575748;
            pub const dwGameEntitySystem_highestEntityIndex: i64 = 0x2120;
        };
        pub const engine2_dll = struct {
            pub const dwBuildNumber: i64 = 0x6B2D1C;
            pub const dwWindowWidth: i64 = 0x9B42D0;
            pub const dwWindowHeight: i64 = 0x9B42D4;
            pub const dwNetworkGameClient: i64 = 0x9AFB70;
            pub const dwNetworkGameClient_deltaTick: i64 = 0x24C;
            pub const dwNetworkGameClient_maxClients: i64 = 0x240;
            pub const dwNetworkGameClient_localPlayer: i64 = 0xF8;
            pub const dwNetworkGameClient_signOnState: i64 = 0x230;
            pub const dwNetworkGameClient_clientTickCount: i64 = 0x398;
            pub const dwNetworkGameClient_isBackgroundMap: i64 = 0x2C143F;
            pub const dwNetworkGameClient_serverTickCount: i64 = 0x24C;
        };
        pub const inputsystem_dll = struct {
            pub const dwInputSystem: i64 = 0x46BC0;
        };
        pub const matchmaking_dll = struct {
            pub const dwGameTypes: i64 = 0x1AEFC0;
        };
        pub const soundsystem_dll = struct {
            pub const dwSoundSystem: i64 = 0x532470;
            pub const dwSoundSystem_engineViewData: i64 = 0x6C;
        };
    };
};
