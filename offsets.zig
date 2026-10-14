pub const cs2_dumper = struct {
    pub const offsets = struct {
        pub const client_dll = struct {
            pub const dwWeaponC4: i64 = 0x24C9B30;
            pub const dwCSGOInput: i64 = 0x257B640;
            pub const dwGameRules: i64 = 0x25651D0;
            pub const dwPlantedC4: i64 = 0x24CB3C0;
            pub const dwEntityList: i64 = 0x271A908;
            pub const dwGlobalVars: i64 = 0x2230090;
            pub const dwPrediction: i64 = 0x2565620;
            pub const dwViewAngles: i64 = 0x257BCC8;
            pub const dwViewMatrix: i64 = 0x256B020;
            pub const dwViewRender: i64 = 0x256B9E8;
            pub const dwGlowManager: i64 = 0x2561EF0;
            pub const dwLocalPlayerPawn: i64 = 0x2565718;
            pub const dwGameEntitySystem: i64 = 0x271A908;
            pub const dwLocalPlayerController: i64 = 0x253CB78;
            pub const dwGameEntitySystem_highestEntityIndex: i64 = 0x2120;
        };
        pub const engine2_dll = struct {
            pub const dwBuildNumber: i64 = 0x61CFEC;
            pub const dwWindowWidth: i64 = 0x91F338;
            pub const dwWindowHeight: i64 = 0x91F33C;
            pub const dwNetworkGameClient: i64 = 0x91AFC0;
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
            pub const dwGameTypes: i64 = 0x1B0FD0;
        };
        pub const soundsystem_dll = struct {
            pub const dwSoundSystem: i64 = 0x535350;
        };
    };
};
