pub const cs2_dumper = struct {
    pub const offsets = struct {
        pub const client_dll = struct {
            pub const dwWeaponC4: i64 = 0x24CE108;
            pub const dwCSGOInput: i64 = 0x257F980;
            pub const dwGameRules: i64 = 0x2569378;
            pub const dwPlantedC4: i64 = 0x24CFB60;
            pub const dwEntityList: i64 = 0x271EB08;
            pub const dwGlobalVars: i64 = 0x2234108;
            pub const dwPrediction: i64 = 0x25697D0;
            pub const dwViewAngles: i64 = 0x2580008;
            pub const dwViewMatrix: i64 = 0x256F1D0;
            pub const dwViewRender: i64 = 0x256FB98;
            pub const dwGlowManager: i64 = 0x25660A0;
            pub const dwLocalPlayerPawn: i64 = 0x25698C8;
            pub const dwGameEntitySystem: i64 = 0x271EB08;
            pub const dwLocalPlayerController: i64 = 0x25413F8;
            pub const dwGameEntitySystem_highestEntityIndex: i64 = 0x2120;
        };
        pub const engine2_dll = struct {
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
        };
        pub const inputsystem_dll = struct {
            pub const dwInputSystem: i64 = 0x46BC0;
        };
        pub const matchmaking_dll = struct {
            pub const dwGameTypes: i64 = 0x1B0FD0;
        };
        pub const soundsystem_dll = struct {
            pub const dwSoundSystem: i64 = 0x532420;
        };
    };
};
