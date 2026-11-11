pub const cs2_dumper = struct {
    pub const offsets = struct {
        pub const client_dll = struct {
            pub const dwWeaponC4: i64 = 0x24B83B0;
            pub const dwCSGOInput: i64 = 0x2569E30;
            pub const dwGameRules: i64 = 0x25537E8;
            pub const dwPlantedC4: i64 = 0x24B9B90;
            pub const dwEntityList: i64 = 0x2709010;
            pub const dwGlobalVars: i64 = 0x2221AB8;
            pub const dwPrediction: i64 = 0x2553C40;
            pub const dwViewAngles: i64 = 0x256A4B8;
            pub const dwViewMatrix: i64 = 0x2559640;
            pub const dwViewRender: i64 = 0x255A008;
            pub const dwGlowManager: i64 = 0x2550500;
            pub const dwLocalPlayerPawn: i64 = 0x2553D38;
            pub const dwGameEntitySystem: i64 = 0x2709010;
            pub const dwLocalPlayerController: i64 = 0x252B0C8;
            pub const dwGameEntitySystem_highestEntityIndex: i64 = 0x2120;
        };
        pub const engine2_dll = struct {
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
        };
        pub const inputsystem_dll = struct {
            pub const dwInputSystem: i64 = 0x46BC0;
        };
        pub const matchmaking_dll = struct {
            pub const dwGameTypes: i64 = 0x1AEFC0;
        };
        pub const soundsystem_dll = struct {
            pub const dwSoundSystem: i64 = 0x532470;
        };
    };
};
