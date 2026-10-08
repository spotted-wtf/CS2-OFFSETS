pub const cs2_dumper = struct {
    pub const schemas = struct {
        pub const client_dll = struct {
            pub const C_C4 = struct {
                pub const m_fArmedTime: i64 = 0x1F2C;
                pub const m_nSpotRules: i64 = 0x1F50;
                pub const m_bBombPlanted: i64 = 0x1F5B;
                pub const m_bStartedArming: i64 = 0x1F28;
                pub const m_bIsPlantingViaUse: i64 = 0x1F31;
                pub const m_bPlayedArmingBeeps: i64 = 0x1F54;
                pub const m_eActiveLightEffect: i64 = 0x1F24;
                pub const m_entitySpottedState: i64 = 0x1F38;
                pub const m_bBombPlacedAnimation: i64 = 0x1F30;
                pub const m_activeLightParticleIndex: i64 = 0x1F20;
            };
            pub const C_AK47 = struct {

            };
            pub const C_Beam = struct {
                pub const m_fSpeed: i64 = 0x1134;
                pub const m_fWidth: i64 = 0x111C;
                pub const m_flFrame: i64 = 0x1138;
                pub const m_flDamage: i64 = 0x10A4;
                pub const m_fEndWidth: i64 = 0x1120;
                pub const m_nBeamType: i64 = 0x10E0;
                pub const m_vecEndPos: i64 = 0x1140;
                pub const m_bTurnedOff: i64 = 0x113C;
                pub const m_fAmplitude: i64 = 0x112C;
                pub const m_fHaloScale: i64 = 0x1128;
                pub const m_flFireTime: i64 = 0x10A0;
                pub const m_hEndEntity: i64 = 0x114C;
                pub const m_nBeamFlags: i64 = 0x10E4;
                pub const m_nHaloIndex: i64 = 0x10D8;
                pub const m_fFadeLength: i64 = 0x1124;
                pub const m_fStartFrame: i64 = 0x1130;
                pub const m_flFrameRate: i64 = 0x1098;
                pub const m_nAttachIndex: i64 = 0x1110;
                pub const m_nNumBeamEnts: i64 = 0x10A8;
                pub const m_hAttachEntity: i64 = 0x10E8;
                pub const m_hBaseMaterial: i64 = 0x10D0;
                pub const m_flHDRColorScale: i64 = 0x109C;
                pub const m_queryHandleHalo: i64 = 0x10AC;
            };
            pub const C_Fish = struct {
                pub const m_x: i64 = 0x12EC;
                pub const m_y: i64 = 0x12F0;
                pub const m_z: i64 = 0x12F4;
                pub const m_pos: i64 = 0x1268;
                pub const m_vel: i64 = 0x1274;
                pub const m_angle: i64 = 0x12F8;
                pub const m_angles: i64 = 0x1280;
                pub const m_buoyancy: i64 = 0x1298;
                pub const m_actualPos: i64 = 0x12C0;
                pub const m_gotUpdate: i64 = 0x12E8;
                pub const m_deathAngle: i64 = 0x1294;
                pub const m_deathDepth: i64 = 0x1290;
                pub const m_poolOrigin: i64 = 0x12D8;
                pub const m_waterLevel: i64 = 0x12E4;
                pub const m_wiggleRate: i64 = 0x12BC;
                pub const m_wigglePhase: i64 = 0x12B8;
                pub const m_wiggleTimer: i64 = 0x12A0;
                pub const m_actualAngles: i64 = 0x12CC;
                pub const m_averageError: i64 = 0x1354;
                pub const m_errorHistory: i64 = 0x12FC;
                pub const m_localLifeState: i64 = 0x128C;
                pub const m_errorHistoryCount: i64 = 0x1350;
                pub const m_errorHistoryIndex: i64 = 0x134C;
            };
            pub const C_Item = struct {
                pub const m_pReticleHintTextName: i64 = 0x1918;
            };
            pub const C_Team = struct {
                pub const m_iScore: i64 = 0x630;
                pub const m_aPlayers: i64 = 0x618;
                pub const m_szTeamname: i64 = 0x634;
                pub const m_aPlayerControllers: i64 = 0x600;
            };
            pub const C_Knife = struct {
                pub const m_bFirstAttack: i64 = 0x1F20;
            };
            pub const C_World = struct {

            };
            pub const CInfoFan = struct {
                pub const m_flCurveDistRange: i64 = 0x648;
                pub const m_fFanForceMaxRadius: i64 = 0x640;
                pub const m_fFanForceMinRadius: i64 = 0x644;
                pub const m_FanForceCurveString: i64 = 0x650;
            };
            pub const CMapInfo = struct {
                pub const m_flBombRadius: i64 = 0x604;
                pub const m_iBuyingStatus: i64 = 0x600;
                pub const m_iHostageCount: i64 = 0x614;
                pub const m_bGPUCullSkybox: i64 = 0x61A;
                pub const m_iPetPopulation: i64 = 0x608;
                pub const m_flEnvRainStrength: i64 = 0x61C;
                pub const m_flEnvWetnessCoverage: i64 = 0x628;
                pub const m_bUseNormalSpawnsForDM: i64 = 0x60C;
                pub const m_bRainTraceToSkyEnabled: i64 = 0x619;
                pub const m_flBotMaxVisionDistance: i64 = 0x610;
                pub const m_flEnvWetnessDryingAmount: i64 = 0x62C;
                pub const m_bFadePlayerVisibilityFarZ: i64 = 0x618;
                pub const m_flEnvPuddleRippleStrength: i64 = 0x620;
                pub const m_flEnvPuddleRippleDirection: i64 = 0x624;
                pub const m_bDisableAutoGeneratedDMSpawns: i64 = 0x60D;
            };
            pub const C_CSTeam = struct {
                pub const m_iClanID: i64 = 0x950;
                pub const m_bSurrendered: i64 = 0x8BC;
                pub const m_scoreOvertime: i64 = 0x8C8;
                pub const m_scoreFirstHalf: i64 = 0x8C0;
                pub const m_szClanTeamname: i64 = 0x8CC;
                pub const m_numMapVictories: i64 = 0x8B8;
                pub const m_scoreSecondHalf: i64 = 0x8C4;
                pub const m_szTeamFlagImage: i64 = 0x954;
                pub const m_szTeamLogoImage: i64 = 0x95C;
                pub const m_szTeamMatchStat: i64 = 0x6B8;
            };
            pub const C_DEagle = struct {

            };
            pub const C_EnvSky = struct {
                pub const m_bEnabled: i64 = 0x10CC;
                pub const m_nFogType: i64 = 0x10B8;
                pub const m_vTintColor: i64 = 0x10AC;
                pub const m_flFogMaxEnd: i64 = 0x10C8;
                pub const m_flFogMinEnd: i64 = 0x10C0;
                pub const m_hSkyMaterial: i64 = 0x1098;
                pub const m_flFogMaxStart: i64 = 0x10C4;
                pub const m_flFogMinStart: i64 = 0x10BC;
                pub const m_bStartDisabled: i64 = 0x10A8;
                pub const m_flBrightnessScale: i64 = 0x10B4;
                pub const m_vTintColorLightingOnly: i64 = 0x10B0;
                pub const m_hSkyMaterialLightingOnly: i64 = 0x10A0;
            };
            pub const C_Sprite = struct {
                pub const m_flFrame: i64 = 0x10AC;
                pub const m_flSpeed: i64 = 0x1110;
                pub const m_flDieTime: i64 = 0x10B0;
                pub const m_flLastTime: i64 = 0x10DC;
                pub const m_flMaxFrame: i64 = 0x10E0;
                pub const m_flDestScale: i64 = 0x10E8;
                pub const m_nAttachment: i64 = 0x10A4;
                pub const m_nBrightness: i64 = 0x10C0;
                pub const m_flStartScale: i64 = 0x10E4;
                pub const m_nSpriteWidth: i64 = 0x1108;
                pub const m_flSpriteScale: i64 = 0x10C8;
                pub const m_nSpriteHeight: i64 = 0x110C;
                pub const m_flGlowProxySize: i64 = 0x10D4;
                pub const m_flHDRColorScale: i64 = 0x10D8;
                pub const m_flScaleDuration: i64 = 0x10CC;
                pub const m_hSpriteMaterial: i64 = 0x1098;
                pub const m_nDestBrightness: i64 = 0x10F4;
                pub const m_bWorldSpaceScale: i64 = 0x10D0;
                pub const m_flScaleTimeStart: i64 = 0x10EC;
                pub const m_nStartBrightness: i64 = 0x10F0;
                pub const m_flSpriteFramerate: i64 = 0x10A8;
                pub const m_hAttachedToEntity: i64 = 0x10A0;
                pub const m_flBrightnessDuration: i64 = 0x10C4;
                pub const m_flBrightnessTimeStart: i64 = 0x10F8;
            };
            pub const CBaseProp = struct {
                pub const m_iShapeType: i64 = 0x126C;
                pub const m_bModelOverrodeBlockLOS: i64 = 0x1268;
                pub const m_mPreferredCatchTransform: i64 = 0x1280;
                pub const m_bConformToCollisionBounds: i64 = 0x1270;
            };
            pub const CPathNode = struct {
                pub const m_hPath: i64 = 0x650;
                pub const m_xWSPrevParent: i64 = 0x630;
                pub const m_vInTangentLocal: i64 = 0x600;
                pub const m_vOutTangentLocal: i64 = 0x60C;
                pub const m_strPathNodeParameter: i64 = 0x620;
                pub const m_strParentPathUniqueID: i64 = 0x618;
            };
            pub const CTimeline = struct {
                pub const m_bStopped: i64 = 0x220;
                pub const m_flValues: i64 = 0x10;
                pub const m_flInterval: i64 = 0x214;
                pub const m_flFinalValue: i64 = 0x218;
                pub const m_nBucketCount: i64 = 0x210;
                pub const m_nValueCounts: i64 = 0x110;
                pub const m_nCompressionType: i64 = 0x21C;
            };
            pub const C_Chicken = struct {
                pub const m_owner: i64 = 0x14C4;
                pub const m_leader: i64 = 0x14C0;
                pub const m_bIsPreviewModel: i64 = 0x1AE0;
                pub const m_AttributeManager: i64 = 0x14C8;
                pub const m_hWaterWakeParticles: i64 = 0x1ADC;
                pub const m_bSpawnDyingParticles: i64 = 0x1B68;
                pub const m_bAttributesInitialized: i64 = 0x1AD8;
            };
            pub const C_EnvWind = struct {
                pub const m_EnvWindShared: i64 = 0x600;
            };
            pub const C_Hostage = struct {
                pub const m_vel: i64 = 0x1328;
                pub const m_isInit: i64 = 0x13A8;
                pub const m_leader: i64 = 0x1308;
                pub const m_lookAt: i64 = 0x1380;
                pub const m_isRescued: i64 = 0x1334;
                pub const m_blinkTimer: i64 = 0x1368;
                pub const m_reuseTimer: i64 = 0x1310;
                pub const m_eyeAttachment: i64 = 0x13A9;
                pub const m_fLastGrabTime: i64 = 0x1344;
                pub const m_nHostageState: i64 = 0x1338;
                pub const m_vecGrabbedPos: i64 = 0x1348;
                pub const m_chestAttachment: i64 = 0x13AA;
                pub const m_flDropStartTime: i64 = 0x135C;
                pub const m_hHostageGrabber: i64 = 0x1340;
                pub const m_jumpedThisFrame: i64 = 0x1335;
                pub const m_lookAroundTimer: i64 = 0x1390;
                pub const m_pPredictionOwner: i64 = 0x13B0;
                pub const m_bHandsHaveBeenCut: i64 = 0x133C;
                pub const m_flGrabSuccessTime: i64 = 0x1358;
                pub const m_flRescueStartTime: i64 = 0x1354;
                pub const m_entitySpottedState: i64 = 0x12F0;
                pub const m_flDeadOrRescuedTime: i64 = 0x1360;
                pub const m_fNewestAlphaThinkTime: i64 = 0x13B8;
            };
            pub const C_Inferno = struct {
                pub const m_blosCheck: i64 = 0x8664;
                pub const m_fireCount: i64 = 0x1A48;
                pub const m_maxBounds: i64 = 0x8680;
                pub const m_minBounds: i64 = 0x8674;
                pub const m_BurnNormal: i64 = 0x1748;
                pub const m_nlosperiod: i64 = 0x8668;
                pub const m_nInfernoType: i64 = 0x1A4C;
                pub const m_drawableCount: i64 = 0x8660;
                pub const m_firePositions: i64 = 0x1108;
                pub const m_lastFireCount: i64 = 0x1A58;
                pub const m_maxFireHeight: i64 = 0x8670;
                pub const m_nFireLifetime: i64 = 0x1A50;
                pub const m_bFireIsBurning: i64 = 0x1708;
                pub const m_maxFireHalfWidth: i64 = 0x866C;
                pub const m_bInPostEffectTime: i64 = 0x1A54;
                pub const m_fireParentPositions: i64 = 0x1408;
                pub const m_nfxFireDamageEffect: i64 = 0x10D8;
                pub const m_flLastGrassBurnThink: i64 = 0x868C;
                pub const m_nFireEffectTickBegin: i64 = 0x1A5C;
                pub const m_hInfernoDecalsSnapshot: i64 = 0x1100;
                pub const m_hInfernoPointsSnapshot: i64 = 0x10E0;
                pub const m_hInfernoFillerPointsSnapshot: i64 = 0x10E8;
                pub const m_hInfernoOutlinePointsSnapshot: i64 = 0x10F0;
                pub const m_hInfernoClimbingOutlinePointsSnapshot: i64 = 0x10F8;
            };
            pub const C_PhysBox = struct {

            };
            pub const CCashStack = struct {
                pub const m_nCashStackValue: i64 = 0x1098;
            };
            pub const CFilterLOS = struct {

            };
            pub const CFuncWater = struct {
                pub const m_BuoyancyHelper: i64 = 0x1098;
            };
            pub const C_BaseDoor = struct {
                pub const m_bIsUsable: i64 = 0x1098;
            };
            pub const C_EnvDecal = struct {
                pub const m_flDepth: i64 = 0x10A8;
                pub const m_flWidth: i64 = 0x10A0;
                pub const m_flHeight: i64 = 0x10A4;
                pub const m_nRenderOrder: i64 = 0x10AC;
                pub const m_hDecalMaterial: i64 = 0x1098;
                pub const m_bProjectOnWater: i64 = 0x10B2;
                pub const m_bProjectOnWorld: i64 = 0x10B0;
                pub const m_flDepthSortBias: i64 = 0x10B4;
                pub const m_bProjectOnCharacters: i64 = 0x10B1;
            };
            pub const TimedEvent = struct {
                pub const m_fNextEvent: i64 = 0x4;
                pub const m_TimeBetweenEvents: i64 = 0x0;
            };
            pub const CBaseFilter = struct {
                pub const m_OnFail: i64 = 0x620;
                pub const m_OnPass: i64 = 0x608;
                pub const m_bNegated: i64 = 0x600;
            };
            pub const CBombTarget = struct {
                pub const m_bBombPlantedHere: i64 = 0x1180;
            };
            pub const CEffectData = struct {
                pub const m_fFlags: i64 = 0x63;
                pub const m_nColor: i64 = 0x62;
                pub const m_vStart: i64 = 0x14;
                pub const m_flScale: i64 = 0x40;
                pub const m_hEntity: i64 = 0x38;
                pub const m_nHitBox: i64 = 0x60;
                pub const m_vAngles: i64 = 0x2C;
                pub const m_vNormal: i64 = 0x20;
                pub const m_vOrigin: i64 = 0x8;
                pub const m_flRadius: i64 = 0x48;
                pub const m_nMaterial: i64 = 0x5E;
                pub const m_nPenetrate: i64 = 0x5C;
                pub const m_flMagnitude: i64 = 0x44;
                pub const m_iEffectName: i64 = 0x6C;
                pub const m_nDamageType: i64 = 0x58;
                pub const m_hOtherEntity: i64 = 0x3C;
                pub const m_nEffectIndex: i64 = 0x50;
                pub const m_nSurfaceProp: i64 = 0x4C;
                pub const m_nAttachmentName: i64 = 0x68;
                pub const m_nAttachmentIndex: i64 = 0x64;
            };
            pub const CFilterName = struct {
                pub const m_iFilterName: i64 = 0x638;
            };
            pub const CFilterTeam = struct {
                pub const m_iFilterTeam: i64 = 0x638;
            };
            pub const CInfoTarget = struct {

            };
            pub const CLogicRelay = struct {
                pub const m_OnSpawn: i64 = 0x600;
                pub const m_OnTrigger: i64 = 0x618;
                pub const m_bDisabled: i64 = 0x630;
                pub const m_bTriggerOnce: i64 = 0x632;
                pub const m_bFastRetrigger: i64 = 0x633;
                pub const m_bWaitForRefire: i64 = 0x631;
                pub const m_bPassthoughCaller: i64 = 0x634;
            };
            pub const CModelState = struct {
                pub const m_hModel: i64 = 0xA0;
                pub const m_ModelName: i64 = 0xA8;
                pub const m_nForceLOD: i64 = 0x2A3;
                pub const m_MeshGroupMask: i64 = 0x208;
                pub const m_nIdealMotionType: i64 = 0x2A2;
                pub const m_nBodyGroupChoices: i64 = 0x258;
                pub const m_nClothUpdateFlags: i64 = 0x2A4;
                pub const m_flRootBoneOffset_x: i64 = 0xE8;
                pub const m_flRootBoneOffset_y: i64 = 0xEC;
                pub const m_flRootBoneOffset_z: i64 = 0xF0;
                pub const m_pVPhysicsAggregate: i64 = 0xE0;
                pub const m_bClientClothCreationSuppressed: i64 = 0x110;
                pub const m_nAnimStateNoInterpSerialNumber: i64 = 0x200;
                pub const m_nRootBoneOffsetResetSerialNumber: i64 = 0xF4;
            };
            pub const CPathSimple = struct {
                pub const m_pathString: i64 = 0x700;
                pub const m_bClosedLoop: i64 = 0x708;
                pub const m_CPathQueryComponent: i64 = 0x610;
            };
            pub const CTriggerFan = struct {
                pub const m_flForce: i64 = 0x11B4;
                pub const m_bFalloff: i64 = 0x11B8;
                pub const m_hInfoFan: i64 = 0x11B0;
                pub const m_RampTimer: i64 = 0x11C0;
                pub const m_vDirection: i64 = 0x118C;
                pub const m_qNoiseDelta: i64 = 0x11A0;
                pub const m_vFanOriginOffset: i64 = 0x1180;
                pub const m_bPushTowardsInfoTarget: i64 = 0x1198;
                pub const m_bPushAwayFromInfoTarget: i64 = 0x1199;
            };
            pub const C_BarnLight = struct {
                pub const m_nFog: i64 = 0x1200;
                pub const m_Color: i64 = 0x10A0;
                pub const m_vShear: i64 = 0x11B4;
                pub const m_flRange: i64 = 0x11B0;
                pub const m_flShape: i64 = 0x1190;
                pub const m_flSkirt: i64 = 0x119C;
                pub const m_flSoftX: i64 = 0x1194;
                pub const m_flSoftY: i64 = 0x1198;
                pub const m_bEnabled: i64 = 0x1098;
                pub const m_StyleEvent: i64 = 0x1128;
                pub const m_flFogScale: i64 = 0x120C;
                pub const m_nColorMode: i64 = 0x109C;
                pub const m_VisClusters: i64 = 0x1388;
                pub const m_flSkirtNear: i64 = 0x11A0;
                pub const m_nFogShadows: i64 = 0x1208;
                pub const m_vSizeParams: i64 = 0x11A4;
                pub const m_flBrightness: i64 = 0x10A8;
                pub const m_hLightCookie: i64 = 0x1188;
                pub const m_nBounceLight: i64 = 0x11E4;
                pub const m_nCastShadows: i64 = 0x11D4;
                pub const m_nDirectLight: i64 = 0x10B0;
                pub const m_flBounceScale: i64 = 0x11E8;
                pub const m_flFadeSizeEnd: i64 = 0x1214;
                pub const m_flFogStrength: i64 = 0x1204;
                pub const m_bContactShadow: i64 = 0x11E0;
                pub const m_flMinRoughness: i64 = 0x11EC;
                pub const m_nShadowMapSize: i64 = 0x11D8;
                pub const m_flFadeSizeStart: i64 = 0x1210;
                pub const m_flLuminaireSize: i64 = 0x10C4;
                pub const m_nLuminaireShape: i64 = 0x10C0;
                pub const m_nShadowPriority: i64 = 0x11DC;
                pub const m_vAlternateColor: i64 = 0x11F0;
                pub const m_LightStyleEvents: i64 = 0x10F8;
                pub const m_LightStyleString: i64 = 0x10D0;
                pub const m_LightStyleTargets: i64 = 0x1110;
                pub const m_bInitialBoneSetup: i64 = 0x1380;
                pub const m_flBrightnessScale: i64 = 0x10AC;
                pub const m_nBakedShadowIndex: i64 = 0x10B4;
                pub const m_nLightMapUniqueId: i64 = 0x10BC;
                pub const m_flColorTemperature: i64 = 0x10A4;
                pub const m_nLightPathUniqueId: i64 = 0x10B8;
                pub const m_flShadowFadeSizeEnd: i64 = 0x121C;
                pub const m_bForceShadowsEnabled: i64 = 0x11E1;
                pub const m_flLightStyleStartTime: i64 = 0x10D8;
                pub const m_flLuminaireAnisotropy: i64 = 0x10C8;
                pub const m_flShadowFadeSizeStart: i64 = 0x1218;
                pub const m_nPrecomputedSubFrusta: i64 = 0x1260;
                pub const m_vPrecomputedOBBAngles: i64 = 0x1248;
                pub const m_vPrecomputedOBBExtent: i64 = 0x1254;
                pub const m_vPrecomputedOBBOrigin: i64 = 0x123C;
                pub const m_vPrecomputedBoundsMaxs: i64 = 0x1230;
                pub const m_vPrecomputedBoundsMins: i64 = 0x1224;
                pub const m_vPrecomputedOBBAngles0: i64 = 0x1270;
                pub const m_vPrecomputedOBBAngles1: i64 = 0x1294;
                pub const m_vPrecomputedOBBAngles2: i64 = 0x12B8;
                pub const m_vPrecomputedOBBAngles3: i64 = 0x12DC;
                pub const m_vPrecomputedOBBAngles4: i64 = 0x1300;
                pub const m_vPrecomputedOBBAngles5: i64 = 0x1324;
                pub const m_vPrecomputedOBBExtent0: i64 = 0x127C;
                pub const m_vPrecomputedOBBExtent1: i64 = 0x12A0;
                pub const m_vPrecomputedOBBExtent2: i64 = 0x12C4;
                pub const m_vPrecomputedOBBExtent3: i64 = 0x12E8;
                pub const m_vPrecomputedOBBExtent4: i64 = 0x130C;
                pub const m_vPrecomputedOBBExtent5: i64 = 0x1330;
                pub const m_vPrecomputedOBBOrigin0: i64 = 0x1264;
                pub const m_vPrecomputedOBBOrigin1: i64 = 0x1288;
                pub const m_vPrecomputedOBBOrigin2: i64 = 0x12AC;
                pub const m_vPrecomputedOBBOrigin3: i64 = 0x12D0;
                pub const m_vPrecomputedOBBOrigin4: i64 = 0x12F4;
                pub const m_vPrecomputedOBBOrigin5: i64 = 0x1318;
                pub const m_QueuedLightStyleStrings: i64 = 0x10E0;
                pub const m_bPrecomputedFieldsValid: i64 = 0x1220;
                pub const m_nBakeSpecularToCubemaps: i64 = 0x11C0;
                pub const m_fAlternateColorBrightness: i64 = 0x11FC;
                pub const m_vBakeSpecularToCubemapsSize: i64 = 0x11C4;
                pub const m_flBakeSpecularToCubemapsScale: i64 = 0x11D0;
            };
            pub const C_Breakable = struct {

            };
            pub const C_Flashbang = struct {

            };
            pub const C_FuncBrush = struct {

            };
            pub const C_FuncMover = struct {

            };
            pub const C_GameRules = struct {
                pub const m_bGamePaused: i64 = 0x38;
                pub const __m_pChainEntity: i64 = 0x8;
                pub const m_nPauseStartTick: i64 = 0x34;
                pub const m_nTotalPausedTicks: i64 = 0x30;
            };
            pub const C_HEGrenade = struct {

            };
            pub const C_OmniLight = struct {
                pub const m_bShowLight: i64 = 0x13B0;
                pub const m_flInnerAngle: i64 = 0x13A8;
                pub const m_flOuterAngle: i64 = 0x13AC;
            };
            pub const C_PlantedC4 = struct {
                pub const m_flC4Blow: i64 = 0x12B8;
                pub const m_nBombSite: i64 = 0x128C;
                pub const m_flNextBeep: i64 = 0x12B4;
                pub const m_flNextGlow: i64 = 0x12B0;
                pub const m_bRadarFlash: i64 = 0x1900;
                pub const m_bBombDefused: i64 = 0x12DC;
                pub const m_bBombTicking: i64 = 0x1288;
                pub const m_bC4Activated: i64 = 0x12D0;
                pub const m_bHasExploded: i64 = 0x12BD;
                pub const m_hBombDefuser: i64 = 0x12E0;
                pub const m_pBombDefuser: i64 = 0x1904;
                pub const m_bBeingDefused: i64 = 0x12C4;
                pub const m_flTimerLength: i64 = 0x12C0;
                pub const m_bTenSecWarning: i64 = 0x12D1;
                pub const m_flDefuseLength: i64 = 0x12D4;
                pub const m_bExplodeWarning: i64 = 0x12CC;
                pub const m_bTriggerWarning: i64 = 0x12C8;
                pub const m_fLastDefuseTime: i64 = 0x1908;
                pub const m_AttributeManager: i64 = 0x12E8;
                pub const m_bCannotBeDefused: i64 = 0x12BC;
                pub const m_pPredictionOwner: i64 = 0x1910;
                pub const m_flDefuseCountDown: i64 = 0x12D8;
                pub const m_entitySpottedState: i64 = 0x1298;
                pub const m_hDefuserMultimeter: i64 = 0x18F8;
                pub const m_flNextRadarFlashTime: i64 = 0x18FC;
                pub const m_nSourceSoundscapeHash: i64 = 0x1290;
                pub const m_vecC4ExplodeSpectateAng: i64 = 0x1924;
                pub const m_vecC4ExplodeSpectatePos: i64 = 0x1918;
                pub const m_flC4ExplodeSpectateDuration: i64 = 0x1930;
            };
            pub const C_RectLight = struct {
                pub const m_bShowLight: i64 = 0x13A8;
            };
            pub const C_SkyCamera = struct {
                pub const m_pNext: i64 = 0x698;
                pub const m_bUseAngles: i64 = 0x694;
                pub const m_skyboxData: i64 = 0x600;
                pub const m_skyboxSlotToken: i64 = 0x690;
            };
            pub const C_WeaponAWP = struct {

            };
            pub const C_WeaponAug = struct {

            };
            pub const C_WeaponMP7 = struct {

            };
            pub const C_WeaponMP9 = struct {

            };
            pub const C_WeaponP90 = struct {

            };
            pub const fogparams_t = struct {
                pub const end: i64 = 0x28;
                pub const farz: i64 = 0x2C;
                pub const blend: i64 = 0x65;
                pub const start: i64 = 0x24;
                pub const enable: i64 = 0x64;
                pub const duration: i64 = 0x54;
                pub const exponent: i64 = 0x34;
                pub const lerptime: i64 = 0x50;
                pub const endLerpTo: i64 = 0x48;
                pub const dirPrimary: i64 = 0x8;
                pub const m_bPadding: i64 = 0x67;
                pub const maxdensity: i64 = 0x30;
                pub const scattering: i64 = 0x5C;
                pub const m_bPadding2: i64 = 0x66;
                pub const startLerpTo: i64 = 0x44;
                pub const colorPrimary: i64 = 0x14;
                pub const HDRColorScale: i64 = 0x38;
                pub const colorSecondary: i64 = 0x18;
                pub const locallightscale: i64 = 0x60;
                pub const skyboxFogFactor: i64 = 0x3C;
                pub const maxdensityLerpTo: i64 = 0x4C;
                pub const blendtobackground: i64 = 0x58;
                pub const colorPrimaryLerpTo: i64 = 0x1C;
                pub const colorSecondaryLerpTo: i64 = 0x20;
                pub const skyboxFogFactorLerpTo: i64 = 0x40;
            };
            pub const CFilterClass = struct {
                pub const m_iFilterClass: i64 = 0x638;
            };
            pub const CFilterModel = struct {
                pub const m_iFilterModel: i64 = 0x638;
            };
            pub const CPointOrient = struct {
                pub const m_bActive: i64 = 0x60C;
                pub const m_hTarget: i64 = 0x608;
                pub const m_nConstraint: i64 = 0x614;
                pub const m_flMaxTurnRate: i64 = 0x618;
                pub const m_flLastGameTime: i64 = 0x61C;
                pub const m_nGoalDirection: i64 = 0x610;
                pub const m_iszSpawnTargetName: i64 = 0x600;
            };
            pub const C_BaseButton = struct {
                pub const m_usable: i64 = 0x109C;
                pub const m_glowEntity: i64 = 0x1098;
                pub const m_szDisplayText: i64 = 0x10A0;
            };
            pub const C_BaseEntity = struct {
                pub const m_fFlags: i64 = 0x3F4;
                pub const m_hThink: i64 = 0x550;
                pub const m_iEFlags: i64 = 0x374;
                pub const m_iHealth: i64 = 0x34C;
                pub const m_MoveType: i64 = 0x525;
                pub const m_fEffects: i64 = 0x52C;
                pub const m_iTeamNum: i64 = 0x3E7;
                pub const m_ListEntry: i64 = 0x3C8;
                pub const m_Particles: i64 = 0x578;
                pub const m_lifeState: i64 = 0x354;
                pub const m_flAnimTime: i64 = 0x3B4;
                pub const m_flFriction: i64 = 0x538;
                pub const m_iMaxHealth: i64 = 0x348;
                pub const m_nBloodType: i64 = 0x5F8;
                pub const m_nWaterType: i64 = 0x378;
                pub const m_pCollision: i64 = 0x340;
                pub const m_spawnflags: i64 = 0x3E8;
                pub const m_MoveCollide: i64 = 0x524;
                pub const m_flTimeScale: i64 = 0x544;
                pub const m_nSubclassID: i64 = 0x380;
                pub const m_vecVelocity: i64 = 0x430;
                pub const m_bPredictable: i64 = 0x569;
                pub const m_bTakesDamage: i64 = 0x355;
                pub const m_dependencies: i64 = 0x5B8;
                pub const m_flCreateTime: i64 = 0x3E0;
                pub const m_flElasticity: i64 = 0x53C;
                pub const m_flWaterLevel: i64 = 0x528;
                pub const m_hOwnerEntity: i64 = 0x520;
                pub const m_fBBoxVisFlags: i64 = 0x560;
                pub const m_hEffectEntity: i64 = 0x51C;
                pub const m_hGroundEntity: i64 = 0x530;
                pub const m_nCreationTick: i64 = 0x5D0;
                pub const m_nPlatformType: i64 = 0x360;
                pub const m_CBodyComponent: i64 = 0x30;
                pub const m_EntClientFlags: i64 = 0x3E4;
                pub const m_flGravityScale: i64 = 0x540;
                pub const m_hOldMoveParent: i64 = 0x574;
                pub const m_nLastThinkTick: i64 = 0x328;
                pub const m_nNextThinkTick: i64 = 0x3EC;
                pub const m_pGameSceneNode: i64 = 0x330;
                pub const m_vecAbsVelocity: i64 = 0x3F8;
                pub const m_vecAngVelocity: i64 = 0x5A8;
                pub const m_aThinkFunctions: i64 = 0x398;
                pub const m_nActualMoveType: i64 = 0x526;
                pub const m_nSimulationTick: i64 = 0x390;
                pub const m_sUniqueHammerID: i64 = 0x5F0;
                pub const m_tokLayerMatchID: i64 = 0x37C;
                pub const m_vecBaseVelocity: i64 = 0x510;
                pub const m_bAnimTimeChanged: i64 = 0x5E1;
                pub const m_bGravityDisabled: i64 = 0x549;
                pub const m_flSimulationTime: i64 = 0x3B8;
                pub const m_nGroundBodyIndex: i64 = 0x534;
                pub const m_nTakeDamageFlags: i64 = 0x358;
                pub const m_pRenderComponent: i64 = 0x338;
                pub const m_vecServerVelocity: i64 = 0x404;
                pub const m_DataChangeEventRef: i64 = 0x5B4;
                pub const m_bAnimatedEveryTick: i64 = 0x548;
                pub const m_bClientSideRagdoll: i64 = 0x3E6;
                pub const m_flProxyRandomValue: i64 = 0x370;
                pub const m_bPredictionEligible: i64 = 0x37A;
                pub const m_flDamageAccumulator: i64 = 0x350;
                pub const m_flActualGravityScale: i64 = 0x564;
                pub const m_flNavIgnoreUntilTime: i64 = 0x54C;
                pub const m_iCurrentThinkContext: i64 = 0x394;
                pub const m_nNoInterpolationTick: i64 = 0x368;
                pub const m_ubInterpolationFrame: i64 = 0x361;
                pub const m_bRenderWithViewModels: i64 = 0x56A;
                pub const m_bDisabledContextThinks: i64 = 0x3B0;
                pub const m_bSimulationTimeChanged: i64 = 0x5E2;
                pub const m_hSceneObjectController: i64 = 0x364;
                pub const m_nLastPredictableCommand: i64 = 0x570;
                pub const m_NetworkTransmitComponent: i64 = 0x38;
                pub const m_bGravityActuallyDisabled: i64 = 0x568;
                pub const m_nFirstPredictableCommand: i64 = 0x56C;
                pub const m_bApplyLayerMatchIDToModel: i64 = 0x37B;
                pub const m_nSceneObjectOverrideFlags: i64 = 0x3BC;
                pub const m_bInterpolateEvenWithNoModel: i64 = 0x379;
                pub const m_bHasAddedVarsToInterpolation: i64 = 0x3BE;
                pub const m_bHasSuccessfullyInterpolated: i64 = 0x3BD;
                pub const m_nInterpolationLatchDirtyFlags: i64 = 0x3C0;
                pub const m_nVisibilityNoInterpolationTick: i64 = 0x36C;
                pub const m_bRenderEvenWhenNotSuccessfullyInterpolated: i64 = 0x3BF;
            };
            pub const C_BaseToggle = struct {

            };
            pub const C_EconEntity = struct {
                pub const m_iOldTeam: i64 = 0x18DC;
                pub const m_bClientside: i64 = 0x18B8;
                pub const m_hOldProvidee: i64 = 0x18F8;
                pub const m_nFallbackSeed: i64 = 0x18AC;
                pub const m_flFallbackWear: i64 = 0x18B0;
                pub const m_flFlexDelayTime: i64 = 0x1278;
                pub const m_AttributeManager: i64 = 0x1290;
                pub const m_bAttachmentDirty: i64 = 0x18E0;
                pub const m_nFallbackPaintKit: i64 = 0x18A8;
                pub const m_nFallbackStatTrak: i64 = 0x18B4;
                pub const m_vecAttachedModels: i64 = 0x1900;
                pub const m_flFlexDelayedWeight: i64 = 0x1280;
                pub const m_nUnloadedModelIndex: i64 = 0x18E4;
                pub const m_OriginalOwnerXuidLow: i64 = 0x18A0;
                pub const m_hViewmodelAttachment: i64 = 0x18D8;
                pub const m_vecAttachedParticles: i64 = 0x18C0;
                pub const m_OriginalOwnerXuidHigh: i64 = 0x18A4;
                pub const m_bAttributesInitialized: i64 = 0x1288;
                pub const m_bParticleSystemsCreated: i64 = 0x18B9;
                pub const m_iNumOwnerValidationRetries: i64 = 0x18E8;
            };
            pub const C_EnvCubemap = struct {
                pub const m_Entity_bEnabled: i64 = 0x6E0;
                pub const m_Entity_bMoveable: i64 = 0x6A8;
                pub const m_Entity_nPriority: i64 = 0x6B4;
                pub const m_Entity_nHandshake: i64 = 0x6AC;
                pub const m_Entity_bDefaultEnvMap: i64 = 0x6CD;
                pub const m_Entity_bIndoorCubeMap: i64 = 0x6CF;
                pub const m_Entity_bStartDisabled: i64 = 0x6CC;
                pub const m_Entity_flDiffuseScale: i64 = 0x6C8;
                pub const m_Entity_flEdgeFadeDist: i64 = 0x6B8;
                pub const m_Entity_vEdgeFadeDists: i64 = 0x6BC;
                pub const m_Entity_hCubemapTexture: i64 = 0x680;
                pub const m_Entity_vBoxProjectMaxs: i64 = 0x69C;
                pub const m_Entity_vBoxProjectMins: i64 = 0x690;
                pub const m_Entity_flInfluenceRadius: i64 = 0x68C;
                pub const m_Entity_bDefaultSpecEnvMap: i64 = 0x6CE;
                pub const m_Entity_bCustomCubemapTexture: i64 = 0x688;
                pub const m_Entity_nEnvCubeMapArrayIndex: i64 = 0x6B0;
                pub const m_Entity_bCopyDiffuseFromDefaultCubemap: i64 = 0x6D0;
            };
            pub const C_FuncLadder = struct {
                pub const m_Dismounts: i64 = 0x10A8;
                pub const m_bDisabled: i64 = 0x10E8;
                pub const m_bHasSlack: i64 = 0x10EA;
                pub const m_bFakeLadder: i64 = 0x10E9;
                pub const m_vecLocalTop: i64 = 0x10C0;
                pub const m_vecLadderDir: i64 = 0x1098;
                pub const m_flAutoRideSpeed: i64 = 0x10E4;
                pub const m_vecPlayerMountPositionTop: i64 = 0x10CC;
                pub const m_vecPlayerMountPositionBottom: i64 = 0x10D8;
            };
            pub const C_HandleTest = struct {
                pub const m_Handle: i64 = 0x600;
                pub const m_bSendHandle: i64 = 0x604;
            };
            pub const C_Multimeter = struct {
                pub const m_hTargetC4: i64 = 0x1268;
            };
            pub const C_PhysMagnet = struct {
                pub const m_aAttachedObjects: i64 = 0x1280;
                pub const m_aAttachedObjectsFromServer: i64 = 0x1268;
            };
            pub const C_PlayerPing = struct {
                pub const m_iType: i64 = 0x638;
                pub const m_bUrgent: i64 = 0x63C;
                pub const m_hPlayer: i64 = 0x630;
                pub const m_szPlaceName: i64 = 0x63D;
                pub const m_hPingedEntity: i64 = 0x634;
            };
            pub const C_WeaponM249 = struct {

            };
            pub const C_WeaponM4A1 = struct {

            };
            pub const C_WeaponMag7 = struct {

            };
            pub const C_WeaponNOVA = struct {

            };
            pub const C_WeaponP250 = struct {

            };
            pub const C_WeaponTec9 = struct {

            };
            pub const FilterHealth = struct {
                pub const m_iHealthMax: i64 = 0x640;
                pub const m_iHealthMin: i64 = 0x63C;
                pub const m_bAdrenalineActive: i64 = 0x638;
            };
            pub const screenfade_t = struct {
                pub const End: i64 = 0x4;
                pub const Flags: i64 = 0x10;
                pub const Reset: i64 = 0x8;
                pub const Speed: i64 = 0x0;
                pub const m_Color: i64 = 0xC;
            };
            pub const CDamageRecord = struct {
                pub const m_flDamage: i64 = 0x64;
                pub const m_iNumHits: i64 = 0x6C;
                pub const m_killType: i64 = 0x75;
                pub const m_DamagerXuid: i64 = 0x50;
                pub const m_PlayerDamager: i64 = 0x30;
                pub const m_RecipientXuid: i64 = 0x58;
                pub const m_bIsOtherEnemy: i64 = 0x74;
                pub const m_PlayerRecipient: i64 = 0x34;
                pub const m_flBulletsDamage: i64 = 0x60;
                pub const m_iLastBulletUpdate: i64 = 0x70;
                pub const m_szPlayerDamagerName: i64 = 0x40;
                pub const m_flActualHealthRemoved: i64 = 0x68;
                pub const m_szPlayerRecipientName: i64 = 0x48;
                pub const m_hPlayerControllerDamager: i64 = 0x38;
                pub const m_hPlayerControllerRecipient: i64 = 0x3C;
            };
            pub const CGlowProperty = struct {
                pub const m_bGlowing: i64 = 0x51;
                pub const m_bFlashing: i64 = 0x44;
                pub const m_iGlowTeam: i64 = 0x34;
                pub const m_iGlowType: i64 = 0x30;
                pub const m_fGlowColor: i64 = 0x8;
                pub const m_flGlowTime: i64 = 0x48;
                pub const m_nGlowRange: i64 = 0x38;
                pub const m_nGlowRangeMin: i64 = 0x3C;
                pub const m_flGlowStartTime: i64 = 0x4C;
                pub const m_glowColorOverride: i64 = 0x40;
                pub const m_bEligibleForScreenHighlight: i64 = 0x50;
            };
            pub const C_BaseGrenade = struct {
                pub const m_bIsLive: i64 = 0x126A;
                pub const m_flDamage: i64 = 0x1278;
                pub const m_hThrower: i64 = 0x1290;
                pub const m_DmgRadius: i64 = 0x126C;
                pub const m_bHasWarnedAI: i64 = 0x1268;
                pub const m_flNextAttack: i64 = 0x12A8;
                pub const m_flWarnAITime: i64 = 0x1274;
                pub const m_ExplosionSound: i64 = 0x1288;
                pub const m_flDetonateTime: i64 = 0x1270;
                pub const m_iszBounceSound: i64 = 0x1280;
                pub const m_bIsSmokeGrenade: i64 = 0x1269;
                pub const m_hOriginalThrower: i64 = 0x12AC;
            };
            pub const C_BaseTrigger = struct {
                pub const m_hFilter: i64 = 0x1178;
                pub const m_bDisabled: i64 = 0x117C;
                pub const m_OnEndTouch: i64 = 0x10C8;
                pub const m_OnTouching: i64 = 0x10F8;
                pub const m_iFilterName: i64 = 0x1170;
                pub const m_OnStartTouch: i64 = 0x1098;
                pub const m_OnEndTouchAll: i64 = 0x10E0;
                pub const m_OnNotTouching: i64 = 0x1128;
                pub const m_OnStartTouchAll: i64 = 0x10B0;
                pub const m_OnTouchingChanged: i64 = 0x1140;
                pub const m_hTouchingEntities: i64 = 0x1158;
                pub const m_OnTouchingEachEntity: i64 = 0x1110;
            };
            pub const C_CSGameRules = struct {
                pub const m_bLogoMap: i64 = 0xA5;
                pub const m_bTCantBuy: i64 = 0x9B4;
                pub const m_gamePhase: i64 = 0x84;
                pub const m_bCTCantBuy: i64 = 0x9B5;
                pub const m_bIsValveDS: i64 = 0xA4;
                pub const m_iRoundTime: i64 = 0x68;
                pub const m_MatchDevice: i64 = 0xAC;
                pub const m_RetakeRules: i64 = 0xDA0;
                pub const m_iFreezeTime: i64 = 0x64;
                pub const m_nCTTimeOuts: i64 = 0x5C;
                pub const m_bBombDropped: i64 = 0x9A8;
                pub const m_bBombPlanted: i64 = 0x8C7;
                pub const m_bGameRestart: i64 = 0x78;
                pub const m_vMinimapMaxs: i64 = 0xC2C;
                pub const m_vMinimapMins: i64 = 0xC20;
                pub const m_bFreezePeriod: i64 = 0x40;
                pub const m_bIsHltvActive: i64 = 0x8C6;
                pub const m_bWarmupPeriod: i64 = 0x41;
                pub const m_numBestOfMaps: i64 = 0x9A0;
                pub const m_bMapHasBuyZone: i64 = 0x9B;
                pub const m_nMatchEndCount: i64 = 0xEF8;
                pub const m_nRoundEndCount: i64 = 0xF44;
                pub const m_pGameModeRules: i64 = 0xD98;
                pub const m_szMatchStatTxt: i64 = 0x4B8;
                pub const m_eRoundEndReason: i64 = 0xF0C;
                pub const m_eRoundWinReason: i64 = 0x9B0;
                pub const m_fMatchStartTime: i64 = 0x6C;
                pub const m_fRoundStartTime: i64 = 0x70;
                pub const m_flGameStartTime: i64 = 0x7C;
                pub const m_iRoundEndLegacy: i64 = 0xF40;
                pub const m_iRoundWinStatus: i64 = 0x9AC;
                pub const m_ullLocalMatchID: i64 = 0xC58;
                pub const m_bCTTimeOutActive: i64 = 0x4D;
                pub const m_bHasMatchStarted: i64 = 0xB0;
                pub const m_bIsDroppingItems: i64 = 0x8C4;
                pub const m_bIsQuestEligible: i64 = 0x8C5;
                pub const m_bRoundEndNoMusic: i64 = 0xF3C;
                pub const m_bTeamIntroPeriod: i64 = 0xF04;
                pub const m_fWarmupPeriodEnd: i64 = 0x44;
                pub const m_nOvertimePlaying: i64 = 0x90;
                pub const m_nRoundStartCount: i64 = 0xF4C;
                pub const m_sRoundEndMessage: i64 = 0xF30;
                pub const m_bMapHasBombTarget: i64 = 0x99;
                pub const m_bMapHasRescueZone: i64 = 0x9A;
                pub const m_bTechnicalTimeOut: i64 = 0x60;
                pub const m_flNextRespawnWave: i64 = 0xBA0;
                pub const m_totalRoundsPlayed: i64 = 0x88;
                pub const m_bAnyHostageReached: i64 = 0x98;
                pub const m_fWarmupPeriodStart: i64 = 0x48;
                pub const m_flRestartRoundTime: i64 = 0x74;
                pub const m_iHostagesRemaining: i64 = 0x94;
                pub const m_iRoundEndTimerTime: i64 = 0xF14;
                pub const m_nNextMapInMapgroup: i64 = 0xB4;
                pub const m_nTTeamIntroVariant: i64 = 0xEFC;
                pub const m_nTerroristTimeOuts: i64 = 0x58;
                pub const m_iRoundEndWinnerTeam: i64 = 0xF08;
                pub const m_iSpectatorSlotCount: i64 = 0xA8;
                pub const m_nCTTeamIntroVariant: i64 = 0xF00;
                pub const m_TeamRespawnWaveTimes: i64 = 0xB20;
                pub const m_bIsQueuedMatchmaking: i64 = 0x9C;
                pub const m_flCTTimeOutRemaining: i64 = 0x54;
                pub const m_flLastPerfSampleTime: i64 = 0x4F58;
                pub const m_iRoundEndPlayerCount: i64 = 0xF38;
                pub const m_iRoundEndFunFactData1: i64 = 0xF24;
                pub const m_iRoundEndFunFactData2: i64 = 0xF28;
                pub const m_iRoundEndFunFactData3: i64 = 0xF2C;
                pub const m_sRoundEndFunFactToken: i64 = 0xF18;
                pub const m_szTournamentEventName: i64 = 0xB8;
                pub const m_bMatchWaitingForResume: i64 = 0x61;
                pub const m_iNumConsecutiveCTLoses: i64 = 0xCB4;
                pub const m_iRoundStartRoundNumber: i64 = 0xF48;
                pub const m_nEndMatchMapVoteWinner: i64 = 0xCB0;
                pub const m_nHalloweenMaskListSeed: i64 = 0x9A4;
                pub const m_nQueuedMatchmakingMode: i64 = 0xA0;
                pub const m_nRoundsPlayedThisPhase: i64 = 0x8C;
                pub const m_szTournamentEventStage: i64 = 0x2B8;
                pub const m_bTerroristTimeOutActive: i64 = 0x4C;
                pub const m_arrProhibitedItemIndices: i64 = 0x8C8;
                pub const m_bRoundEndShowTimerDefend: i64 = 0xF10;
                pub const m_iMatchStats_RoundResults: i64 = 0x9B8;
                pub const m_nMatchAbortedEarlyReason: i64 = 0xD78;
                pub const m_timeUntilNextPhaseStarts: i64 = 0x80;
                pub const m_nTournamentPredictionsPct: i64 = 0x8B8;
                pub const m_bPlayAllStepSoundsOnServer: i64 = 0xA6;
                pub const m_flCMMItemDropRevealEndTime: i64 = 0x8C0;
                pub const m_iMatchStats_PlayersAlive_T: i64 = 0xAA8;
                pub const m_iRoundEndFunFactPlayerSlot: i64 = 0xF20;
                pub const m_nEndMatchMapGroupVoteTypes: i64 = 0xC60;
                pub const m_szTournamentPredictionsTxt: i64 = 0x6B8;
                pub const m_bSwitchingTeamsAtRoundReset: i64 = 0xD7D;
                pub const m_flTerroristTimeOutRemaining: i64 = 0x50;
                pub const m_iMatchStats_PlayersAlive_CT: i64 = 0xA30;
                pub const m_bHasTriggeredRoundStartMusic: i64 = 0xD7C;
                pub const m_flCMMItemDropRevealStartTime: i64 = 0x8BC;
                pub const m_nEndMatchMapGroupVoteOptions: i64 = 0xC88;
                pub const m_MinimapVerticalSectionHeights: i64 = 0xC38;
                pub const m_iNumConsecutiveTerroristLoses: i64 = 0xCB8;
                pub const m_arrTournamentActiveCasterAccounts: i64 = 0x990;
            };
            pub const C_DynamicProp = struct {
                pub const m_glowColor: i64 = 0x1480;
                pub const m_nGlowTeam: i64 = 0x1484;
                pub const m_nGlowRange: i64 = 0x1478;
                pub const m_iszIdleAnim: i64 = 0x1460;
                pub const m_bUseAnimGraph: i64 = 0x13E2;
                pub const m_nGlowRangeMin: i64 = 0x147C;
                pub const m_bStartDisabled: i64 = 0x146D;
                pub const m_bCreateNonSolid: i64 = 0x1471;
                pub const m_bIsOverrideProp: i64 = 0x1472;
                pub const m_bRandomizeCycle: i64 = 0x146C;
                pub const m_pOutputAnimOver: i64 = 0x1400;
                pub const m_OnAnimReachedEnd: i64 = 0x1448;
                pub const m_bForceNpcExclude: i64 = 0x146F;
                pub const m_pOutputAnimBegun: i64 = 0x13E8;
                pub const m_iCachedFrameCount: i64 = 0x1488;
                pub const m_iInitialGlowState: i64 = 0x1474;
                pub const m_nIdleAnimLoopMode: i64 = 0x1468;
                pub const m_OnAnimReachedStart: i64 = 0x1430;
                pub const m_vecCachedRenderMaxs: i64 = 0x1498;
                pub const m_vecCachedRenderMins: i64 = 0x148C;
                pub const m_bFiredStartEndOutput: i64 = 0x146E;
                pub const m_bGraphControllerEnabled: i64 = 0x13E0;
                pub const m_bUseHitboxesForRenderBox: i64 = 0x13E1;
                pub const m_pOutputAnimLoopCycleOver: i64 = 0x1418;
                pub const m_bCreateMovableSurfaceGraph: i64 = 0x1470;
            };
            pub const C_EntityFlame = struct {
                pub const m_bCheapEffect: i64 = 0x62C;
                pub const m_hEntAttached: i64 = 0x600;
                pub const m_hOldAttached: i64 = 0x628;
            };
            pub const C_FuncMonitor = struct {
                pub const m_bEnabled: i64 = 0x10B4;
                pub const m_targetCamera: i64 = 0x1098;
                pub const m_bDraw3DSkybox: i64 = 0x10B5;
                pub const m_hTargetCamera: i64 = 0x10B0;
                pub const m_bRenderShadows: i64 = 0x10A4;
                pub const m_brushModelName: i64 = 0x10A8;
                pub const m_nResolutionEnum: i64 = 0x10A0;
                pub const m_bUseUniqueColorTarget: i64 = 0x10A5;
            };
            pub const C_GlobalLight = struct {
                pub const m_WindClothForceHandle: i64 = 0xAC0;
            };
            pub const C_GradientFog = struct {
                pub const m_flFarZ: i64 = 0x61C;
                pub const m_fogColor: i64 = 0x62C;
                pub const m_bIsEnabled: i64 = 0x639;
                pub const m_flFadeTime: i64 = 0x634;
                pub const m_flFogStrength: i64 = 0x630;
                pub const m_bStartDisabled: i64 = 0x638;
                pub const m_flFogEndHeight: i64 = 0x618;
                pub const m_flFogMaxOpacity: i64 = 0x620;
                pub const m_flFogEndDistance: i64 = 0x60C;
                pub const m_flFogStartHeight: i64 = 0x614;
                pub const m_bHeightFogEnabled: i64 = 0x610;
                pub const m_flFogStartDistance: i64 = 0x608;
                pub const m_hGradientFogTexture: i64 = 0x600;
                pub const m_flFogFalloffExponent: i64 = 0x624;
                pub const m_flFogVerticalExponent: i64 = 0x628;
                pub const m_bGradientFogNeedsTextures: i64 = 0x63A;
            };
            pub const C_ItemDogtags = struct {
                pub const m_OwningPlayer: i64 = 0x1A18;
                pub const m_KillingPlayer: i64 = 0x1A1C;
            };
            pub const C_LightEntity = struct {
                pub const m_CLightComponent: i64 = 0x1098;
            };
            pub const C_PhysicsProp = struct {
                pub const m_bAwake: i64 = 0x13E0;
            };
            pub const C_PointCamera = struct {
                pub const m_FOV: i64 = 0x600;
                pub const m_bIsOn: i64 = 0x654;
                pub const m_pNext: i64 = 0x658;
                pub const m_bNoSky: i64 = 0x624;
                pub const m_flZFar: i64 = 0x62C;
                pub const m_bActive: i64 = 0x61C;
                pub const m_flZNear: i64 = 0x630;
                pub const m_FogColor: i64 = 0x60C;
                pub const m_flFogEnd: i64 = 0x614;
                pub const m_TargetFOV: i64 = 0x64C;
                pub const m_Resolution: i64 = 0x604;
                pub const m_bFogEnable: i64 = 0x608;
                pub const m_flFogStart: i64 = 0x610;
                pub const m_bCanHLTVUse: i64 = 0x634;
                pub const m_bDofEnabled: i64 = 0x636;
                pub const m_fBrightness: i64 = 0x628;
                pub const m_flAspectRatio: i64 = 0x620;
                pub const m_flDofFarCrisp: i64 = 0x640;
                pub const m_flDofFarBlurry: i64 = 0x644;
                pub const m_flDofNearCrisp: i64 = 0x63C;
                pub const m_flDofNearBlurry: i64 = 0x638;
                pub const m_flFogMaxDensity: i64 = 0x618;
                pub const m_DegreesPerSecond: i64 = 0x650;
                pub const m_bAlignWithParent: i64 = 0x635;
                pub const m_flDofTiltToGround: i64 = 0x648;
                pub const m_bUseScreenAspectRatio: i64 = 0x61D;
            };
            pub const C_PointEntity = struct {

            };
            pub const C_RagdollProp = struct {
                pub const m_ragPos: i64 = 0x1280;
                pub const m_ragAngles: i64 = 0x1298;
                pub const m_ragEnabled: i64 = 0x1268;
                pub const m_flBlendWeight: i64 = 0x12B0;
                pub const m_hRagdollSource: i64 = 0x12B4;
                pub const m_iEyeAttachment: i64 = 0x12B8;
                pub const m_flBlendWeightCurrent: i64 = 0x12BC;
                pub const m_parentPhysicsBoneIndices: i64 = 0x12C0;
                pub const m_worldSpaceBoneComputationOrder: i64 = 0x12D8;
            };
            pub const C_SceneEntity = struct {
                pub const m_hOwner: i64 = 0x618;
                pub const m_bPaused: i64 = 0x609;
                pub const m_hActorList: i64 = 0x620;
                pub const m_bClientOnly: i64 = 0x616;
                pub const m_bWasPlaying: i64 = 0x638;
                pub const m_QueuedEvents: i64 = 0x648;
                pub const m_bMultiplayer: i64 = 0x60A;
                pub const m_flCurrentTime: i64 = 0x660;
                pub const m_bAutogenerated: i64 = 0x60B;
                pub const m_bIsPlayingBack: i64 = 0x608;
                pub const m_flForceClientTime: i64 = 0x610;
                pub const m_nSceneStringIndex: i64 = 0x614;
                pub const m_bAllRequirementsComplete: i64 = 0x60C;
            };
            pub const C_WaterBullet = struct {

            };
            pub const C_WeaponBizon = struct {

            };
            pub const C_WeaponCZ75a = struct {
                pub const m_bMagazineRemoved: i64 = 0x1F50;
            };
            pub const C_WeaponElite = struct {

            };
            pub const C_WeaponFamas = struct {

            };
            pub const C_WeaponG3SG1 = struct {

            };
            pub const C_WeaponGlock = struct {

            };
            pub const C_WeaponMAC10 = struct {

            };
            pub const C_WeaponMP5SD = struct {

            };
            pub const C_WeaponNegev = struct {

            };
            pub const C_WeaponSG556 = struct {

            };
            pub const C_WeaponSSG08 = struct {

            };
            pub const C_WeaponTaser = struct {
                pub const m_fFireTime: i64 = 0x1F50;
                pub const m_nLastAttackTick: i64 = 0x1F54;
            };
            pub const C_WeaponUMP45 = struct {

            };
            pub const IntervalTimer = struct {
                pub const m_timestamp: i64 = 0x8;
                pub const m_nWorldGroupId: i64 = 0xC;
            };
            pub const audioparams_t = struct {
                pub const localBits: i64 = 0x6C;
                pub const localSound: i64 = 0x8;
                pub const soundEventHash: i64 = 0x74;
                pub const soundscapeIndex: i64 = 0x68;
                pub const soundscapeEntityListIndex: i64 = 0x70;
            };
            pub const screenshake_t = struct {
                pub const angle: i64 = 0x20;
                pub const offset: i64 = 0x14;
                pub const endtime: i64 = 0x0;
                pub const duration: i64 = 0x4;
                pub const amplitude: i64 = 0x8;
                pub const direction: i64 = 0x28;
                pub const frequency: i64 = 0xC;
                pub const nextShake: i64 = 0x10;
                pub const nShakeType: i64 = 0x34;
            };
            pub const sky3dparams_t = struct {
                pub const fog: i64 = 0x20;
                pub const scale: i64 = 0x8;
                pub const origin: i64 = 0xC;
                pub const m_nWorldGroupID: i64 = 0x88;
                pub const bClip3DSkyBoxNearToWorldFar: i64 = 0x18;
                pub const flClip3DSkyBoxNearToWorldFarOffset: i64 = 0x1C;
            };
            pub const CAttributeList = struct {
                pub const m_pManager: i64 = 0x70;
                pub const m_Attributes: i64 = 0x8;
            };
            pub const CBaseAnimGraph = struct {
                pub const m_vecForce: i64 = 0x1184;
                pub const m_nForceBone: i64 = 0x1190;
                pub const m_RagdollPose: i64 = 0x11B8;
                pub const m_bBuiltRagdoll: i64 = 0x11A0;
                pub const m_bRagdollEnabled: i64 = 0x1200;
                pub const m_pRagdollControl: i64 = 0x11B0;
                pub const m_bRagdollClientSide: i64 = 0x1201;
                pub const m_pClientsideRagdoll: i64 = 0x1198;
                pub const m_OnLayerCycleUpdated: i64 = 0x1140;
                pub const m_pMainGraphController: i64 = 0x1130;
                pub const m_graphControllerManager: i64 = 0x1098;
                pub const m_bAnimGraphUpdateEnabled: i64 = 0x1180;
                pub const m_bSuppressAnimEventSounds: i64 = 0x113A;
                pub const m_bAnimationUpdateScheduled: i64 = 0x1181;
                pub const m_OnExternalChoreoGraphChanged: i64 = 0x1160;
                pub const m_bShouldUpdateTransformations: i64 = 0x1202;
                pub const m_bHasAnimatedMaterialAttributes: i64 = 0x1210;
                pub const m_bInitiallyPopulateInterpHistory: i64 = 0x1138;
            };
            pub const CBodyComponent = struct {
                pub const m_pSceneNode: i64 = 0x8;
                pub const __m_pChainEntity: i64 = 0x48;
            };
            pub const CEnvSoundscape = struct {
                pub const m_OnPlay: i64 = 0x600;
                pub const m_flRadius: i64 = 0x618;
                pub const m_bDisabled: i64 = 0x67C;
                pub const m_positionNames: i64 = 0x638;
                pub const m_soundEventHash: i64 = 0x688;
                pub const m_soundEventName: i64 = 0x620;
                pub const m_soundscapeName: i64 = 0x680;
                pub const m_soundscapeIndex: i64 = 0x62C;
                pub const m_hProxySoundscape: i64 = 0x678;
                pub const m_bOverrideWithEvent: i64 = 0x628;
                pub const m_soundscapeEntityListId: i64 = 0x630;
            };
            pub const CGameSceneNode = struct {
                pub const m_name: i64 = 0x10C;
                pub const m_pChild: i64 = 0x40;
                pub const m_pOwner: i64 = 0x30;
                pub const m_flScale: i64 = 0xC4;
                pub const m_hParent: i64 = 0x70;
                pub const m_pParent: i64 = 0x38;
                pub const m_bDormant: i64 = 0x103;
                pub const m_vecOrigin: i64 = 0x80;
                pub const m_flAbsScale: i64 = 0xE0;
                pub const m_angRotation: i64 = 0xB8;
                pub const m_nodeToWorld: i64 = 0x10;
                pub const m_pNextSibling: i64 = 0x48;
                pub const m_vecAbsOrigin: i64 = 0xC8;
                pub const m_angAbsRotation: i64 = 0xD4;
                pub const m_bBoneMergeFlex: i64 = 0x0;
                pub const m_flWrappedScale: i64 = 0xFC;
                pub const m_nHierarchyType: i64 = 0x108;
                pub const m_bDirtyHierarchy: i64 = 0x0;
                pub const m_nLatchAbsOrigin: i64 = 0x0;
                pub const m_flClientLocalScale: i64 = 0x124;
                pub const m_nHierarchicalDepth: i64 = 0x107;
                pub const m_bDirtyBoneMergeInfo: i64 = 0x0;
                pub const m_hierarchyAttachName: i64 = 0x120;
                pub const m_vecWrappedLocalOrigin: i64 = 0xE4;
                pub const m_bDebugAbsOriginChanges: i64 = 0x102;
                pub const m_bNetworkedScaleChanged: i64 = 0x0;
                pub const m_angWrappedLocalRotation: i64 = 0xF0;
                pub const m_bNetworkedAnglesChanged: i64 = 0x0;
                pub const m_nParentAttachmentOrBone: i64 = 0x100;
                pub const m_bDirtyBoneMergeBoneToRoot: i64 = 0x0;
                pub const m_bForceParentToBeNetworked: i64 = 0x104;
                pub const m_bNetworkedPositionChanged: i64 = 0x0;
                pub const m_bWillBeCallingPostDataUpdate: i64 = 0x0;
                pub const m_nDoNotSetAnimTimeInInvalidatePhysicsCount: i64 = 0x109;
            };
            pub const CGrenadeTracer = struct {
                pub const m_nType: i64 = 0x10B4;
                pub const m_flTracerDuration: i64 = 0x10B0;
            };
            pub const CLogicalEntity = struct {

            };
            pub const CPointTemplate = struct {
                pub const m_iszWorldName: i64 = 0x600;
                pub const m_OnEntitySpawned: i64 = 0x668;
                pub const m_flTimeoutInterval: i64 = 0x618;
                pub const m_ScriptCallbackScope: i64 = 0x660;
                pub const m_ScriptSpawnCallback: i64 = 0x658;
                pub const m_iszEntityFilterName: i64 = 0x610;
                pub const m_ownerSpawnGroupType: i64 = 0x624;
                pub const m_SpawnedEntityHandles: i64 = 0x640;
                pub const m_clientOnlyEntityBehavior: i64 = 0x620;
                pub const m_createdSpawnGroupHandles: i64 = 0x628;
                pub const m_iszSource2EntityLumpName: i64 = 0x608;
                pub const m_bAsynchronouslySpawnEntities: i64 = 0x61C;
            };
            pub const CPulseGraphDef = struct {
                pub const m_Vars: i64 = 0x80;
                pub const m_Cells: i64 = 0x68;
                pub const m_Chunks: i64 = 0x50;
                pub const m_CallInfos: i64 = 0xE0;
                pub const m_Constants: i64 = 0xF8;
                pub const m_DomainValues: i64 = 0x110;
                pub const m_TempVarBanks: i64 = 0x98;
                pub const m_DomainSubType: i64 = 0x18;
                pub const m_ParentMapName: i64 = 0x30;
                pub const m_ParentXmlName: i64 = 0x40;
                pub const m_PublicOutputs: i64 = 0xB0;
                pub const m_InvokeBindings: i64 = 0xC8;
                pub const m_DomainIdentifier: i64 = 0x8;
                pub const m_OutputConnections: i64 = 0x140;
                pub const m_BlackboardReferences: i64 = 0x128;
            };
            pub const CSMatchStats_t = struct {
                pub const m_iEnemy3Ks: i64 = 0x70;
                pub const m_iEnemy4Ks: i64 = 0x6C;
                pub const m_iEnemy5Ks: i64 = 0x68;
                pub const m_iEnemyKnifeKills: i64 = 0x74;
                pub const m_iEnemyTaserKills: i64 = 0x78;
            };
            pub const CWaterSplasher = struct {

            };
            pub const C_BasePropDoor = struct {
                pub const m_bLocked: i64 = 0x14C5;
                pub const m_bNoNPCs: i64 = 0x14C6;
                pub const m_hMaster: i64 = 0x14E0;
                pub const m_eDoorState: i64 = 0x14C0;
                pub const m_closedAngles: i64 = 0x14D4;
                pub const m_modelChanged: i64 = 0x14C4;
                pub const m_closedPosition: i64 = 0x14C8;
                pub const m_vWhereToSetLightingOrigin: i64 = 0x14E4;
            };
            pub const C_CSPlayerPawn = struct {
                pub const m_bIsScoped: i64 = 0x1EA0;
                pub const m_ArmorValue: i64 = 0x1ECC;
                pub const m_EconGloves: i64 = 0x1770;
                pub const m_bInBuyZone: i64 = 0x15E0;
                pub const m_bInLanding: i64 = 0x15E2;
                pub const m_bIsWalking: i64 = 0x1E80;
                pub const m_bInBombZone: i64 = 0x15E9;
                pub const m_bIsDefusing: i64 = 0x1EA2;
                pub const m_bLeftHanded: i64 = 0x1DB8;
                pub const m_bPrevHelmet: i64 = 0x15CF;
                pub const m_bResumeZoom: i64 = 0x1EA1;
                pub const m_flModifier0: i64 = 0x3510;
                pub const m_iIDEntIndex: i64 = 0x36DC;
                pub const m_iShotsFired: i64 = 0x1EB4;
                pub const m_angEyeAngles: i64 = 0x3600;
                pub const m_bOldIsScoped: i64 = 0x1EDC;
                pub const m_bPrevDefuser: i64 = 0x15CE;
                pub const m_lastLandTime: i64 = 0x1D84;
                pub const m_pBuyServices: i64 = 0x1580;
                pub const m_unWeaponHash: i64 = 0x15DC;
                pub const m_bHasDeathInfo: i64 = 0x1EDD;
                pub const m_flFlinchStack: i64 = 0x1EB8;
                pub const m_hHudModelArms: i64 = 0x1DA8;
                pub const m_nPrevArmorVal: i64 = 0x15D0;
                pub const m_pGlowServices: i64 = 0x1588;
                pub const m_bIsBuyMenuOpen: i64 = 0x15EA;
                pub const m_flViewmodelFOV: i64 = 0x1DCC;
                pub const m_iOldIDEntIndex: i64 = 0x36FC;
                pub const m_nWhichBombZone: i64 = 0x1EB0;
                pub const m_arrOldEyeAngles: i64 = 0x36A0;
                pub const m_bHasFemaleVoice: i64 = 0x15B0;
                pub const m_bInNoDefuseArea: i64 = 0x1EAC;
                pub const m_flDeathInfoTime: i64 = 0x1EE0;
                pub const m_flEmitSoundTime: i64 = 0x1EA8;
                pub const m_pBulletServices: i64 = 0x1570;
                pub const m_qDeathEyeAngles: i64 = 0x1DAC;
                pub const m_szLastPlaceName: i64 = 0x15BC;
                pub const m_bGunGameImmunity: i64 = 0x3508;
                pub const m_bWaitForNoAttack: i64 = 0x1EC0;
                pub const m_iRetakesOffering: i64 = 0x1758;
                pub const m_nLastKillerIndex: i64 = 0x1ED8;
                pub const m_pHostageServices: i64 = 0x1578;
                pub const m_bKilledByHeadshot: i64 = 0x1EC9;
                pub const m_bOnGroundLastTick: i64 = 0x1D88;
                pub const m_flOldFallVelocity: i64 = 0x15B8;
                pub const m_holdTargetIDTimer: i64 = 0x3700;
                pub const m_iTargetItemEntIdx: i64 = 0x36F8;
                pub const m_pAimPunchServices: i64 = 0x1598;
                pub const m_bIsGrabbingHostage: i64 = 0x1EA3;
                pub const m_delayTargetIDTimer: i64 = 0x36E0;
                pub const m_entitySpottedState: i64 = 0x1E88;
                pub const m_fMolotovDamageTime: i64 = 0x3514;
                pub const m_flLandingStartTime: i64 = 0x15E4;
                pub const m_flTimeOfLastInjury: i64 = 0x15EC;
                pub const m_flVelocityModifier: i64 = 0x1EBC;
                pub const m_flViewmodelOffsetX: i64 = 0x1DC0;
                pub const m_flViewmodelOffsetY: i64 = 0x1DC4;
                pub const m_flViewmodelOffsetZ: i64 = 0x1DC8;
                pub const m_nEconGlovesChanged: i64 = 0x1D20;
                pub const m_nRagdollDamageBone: i64 = 0x1D24;
                pub const m_vecBulletHitModels: i64 = 0x1E68;
                pub const m_vecDeathInfoOrigin: i64 = 0x1EE4;
                pub const m_vecStashedVelocity: i64 = 0x1F4C;
                pub const m_vRagdollDamageForce: i64 = 0x1D28;
                pub const m_GunGameImmunityColor: i64 = 0x1E18;
                pub const m_angEyeAnglesVelocity: i64 = 0x36D0;
                pub const m_arrOldEyeAnglesTimes: i64 = 0x3690;
                pub const m_bInHostageRescueZone: i64 = 0x15E8;
                pub const m_bNeedToReApplyGloves: i64 = 0x176D;
                pub const m_bPreviouslyInBuyZone: i64 = 0x15E1;
                pub const m_bRetakesHasDefuseKit: i64 = 0x1760;
                pub const m_bRetakesMVPLastRound: i64 = 0x1761;
                pub const m_flLandingTimeSeconds: i64 = 0x15B4;
                pub const m_flNextSprayDecalTime: i64 = 0x15F0;
                pub const m_hActiveMinimapVolume: i64 = 0x1DA4;
                pub const m_iRetakesMVPBoostItem: i64 = 0x1764;
                pub const m_iRetakesOfferingCard: i64 = 0x175C;
                pub const m_ignoreLadderJumpTime: i64 = 0x1EC4;
                pub const m_nPlayerInfernoBodyFx: i64 = 0x3580;
                pub const m_pDamageReactServices: i64 = 0x15A0;
                pub const m_unPreviousWeaponHash: i64 = 0x15D8;
                pub const m_vRagdollServerOrigin: i64 = 0x1D78;
                pub const m_angStashedShootAngles: i64 = 0x1F28;
                pub const m_bMustSyncRagdollState: i64 = 0x1D21;
                pub const m_flLastFiredWeaponTime: i64 = 0x15AC;
                pub const m_nPrevGrenadeAmmoCount: i64 = 0x15D4;
                pub const m_bRagdollDamageHeadshot: i64 = 0x1D74;
                pub const m_bShouldAutobuyDMWeapons: i64 = 0x3500;
                pub const m_fSwitchedHandednessTime: i64 = 0x1DBC;
                pub const m_pActionTrackingServices: i64 = 0x1590;
                pub const m_unCurrentEquipmentValue: i64 = 0x1ED0;
                pub const m_flInterpolatedInaccuracy: i64 = 0x1F58;
                pub const m_bGrenadeParametersStashed: i64 = 0x1F24;
                pub const m_grenadeParameterStashTime: i64 = 0x1F20;
                pub const m_szRagdollDamageWeaponName: i64 = 0x1D34;
                pub const m_vecPlayerPatchEconIndices: i64 = 0x1DD0;
                pub const m_fImmuneToGunGameDamageTime: i64 = 0x3504;
                pub const m_unRoundStartEquipmentValue: i64 = 0x1ED2;
                pub const m_RetakesMVPBoostExtraUtility: i64 = 0x1768;
                pub const m_iBlockingUseActionInProgress: i64 = 0x1EA4;
                pub const m_unFreezetimeEndEquipmentValue: i64 = 0x1ED4;
                pub const m_fImmuneToGunGameDamageTimeLast: i64 = 0x350C;
                pub const m_vecStashedGrenadeThrowPosition: i64 = 0x1F34;
                pub const m_flHealthShotBoostExpirationTime: i64 = 0x15A8;
                pub const m_vecStashedGrenadeThrowPawnCenter: i64 = 0x1F40;
            };
            pub const C_CSWeaponBase = struct {
                pub const m_donated: i64 = 0x1B64;
                pub const m_bInReload: i64 = 0x1A3C;
                pub const m_bStealthy: i64 = 0x1A58;
                pub const m_bUIWeapon: i64 = 0x1B22;
                pub const m_nDropTick: i64 = 0x1B3C;
                pub const m_bBurstMode: i64 = 0x1A2C;
                pub const m_hPrevOwner: i64 = 0x1B38;
                pub const m_weaponMode: i64 = 0x1A00;
                pub const m_bSilencerOn: i64 = 0x1A51;
                pub const m_nDeployTick: i64 = 0x1A40;
                pub const m_bFireOnEmpty: i64 = 0x19E4;
                pub const m_iRecoilIndex: i64 = 0x1A24;
                pub const m_bIsHauledBack: i64 = 0x1A50;
                pub const m_bWasOwnedByCT: i64 = 0x1B6C;
                pub const m_fLastShotTime: i64 = 0x1B68;
                pub const m_flRecoilIndex: i64 = 0x1A28;
                pub const m_OnPlayerPickup: i64 = 0x19E8;
                pub const m_bCanBePickedUp: i64 = 0x1B30;
                pub const m_iIronSightMode: i64 = 0x1C80;
                pub const m_bInspectPending: i64 = 0x19B4;
                pub const m_bVisualsDataSet: i64 = 0x1B21;
                pub const m_flDroppedAtTime: i64 = 0x1A48;
                pub const m_flLastShakeTime: i64 = 0x1D6C;
                pub const m_flWatTickOffset: i64 = 0x1D58;
                pub const m_fAccuracyPenalty: i64 = 0x1A18;
                pub const m_bInspectShouldLoop: i64 = 0x19B5;
                pub const m_IronSightController: i64 = 0x1BD0;
                pub const m_bDroppedNearBuyZone: i64 = 0x1A70;
                pub const m_flTurningInaccuracy: i64 = 0x1A14;
                pub const m_iOriginalTeamNumber: i64 = 0x1A68;
                pub const m_bWasOwnedByTerrorist: i64 = 0x1B6D;
                pub const m_nextPrevOwnerUseTime: i64 = 0x1B34;
                pub const m_bReloadHeldSinceStart: i64 = 0x1A60;
                pub const m_flAttackHoldStartTime: i64 = 0x1A44;
                pub const m_iMostRecentTeamNumber: i64 = 0x1A6C;
                pub const m_nLastEmptySoundCmdNum: i64 = 0x19E0;
                pub const m_bInSilentReloadSection: i64 = 0x1A59;
                pub const m_flStealthHoldStartTime: i64 = 0x1A5C;
                pub const m_flPostponeFireReadyFrac: i64 = 0x1A38;
                pub const m_nPostponeFireReadyTicks: i64 = 0x1A34;
                pub const m_fAccuracySmoothedForZoom: i64 = 0x1A20;
                pub const m_flLastAccuracyUpdateTime: i64 = 0x1A1C;
                pub const m_flTurningInaccuracyDelta: i64 = 0x1A04;
                pub const m_iWeaponGameplayAnimState: i64 = 0x19A8;
                pub const m_nCustomEconReloadEventId: i64 = 0x1B24;
                pub const m_flLastBurstModeChangeTime: i64 = 0x1A30;
                pub const m_flLastLOSTraceFailureTime: i64 = 0x1CF8;
                pub const m_bClearWeaponIdentifyingUGC: i64 = 0x1B20;
                pub const m_flNextClientFireBulletTime: i64 = 0x1B70;
                pub const m_flWeaponActionPlaybackRate: i64 = 0x1A64;
                pub const m_bWasActiveWeaponWhenDropped: i64 = 0x1B40;
                pub const m_flInspectCancelCompleteTime: i64 = 0x19B0;
                pub const m_flNextAttackRenderTimeOffset: i64 = 0x1A74;
                pub const m_flTimeSilencerSwitchComplete: i64 = 0x1A54;
                pub const m_vecTurningInaccuracyEyeDirLast: i64 = 0x1A08;
                pub const m_flWeaponGameplayAnimStateTimestamp: i64 = 0x19AC;
                pub const m_flNextClientFireBulletTime_Repredict: i64 = 0x1B74;
            };
            pub const C_DecoyGrenade = struct {

            };
            pub const C_DynamicLight = struct {
                pub const m_Flags: i64 = 0x1098;
                pub const m_Radius: i64 = 0x109C;
                pub const m_Exponent: i64 = 0x10A0;
                pub const m_InnerAngle: i64 = 0x10A4;
                pub const m_LightStyle: i64 = 0x1099;
                pub const m_OuterAngle: i64 = 0x10A8;
                pub const m_SpotRadius: i64 = 0x10AC;
            };
            pub const C_EconItemView = struct {
                pub const m_iItemID: i64 = 0x1C8;
                pub const m_iAccountID: i64 = 0x1D8;
                pub const m_iItemIDLow: i64 = 0x1D4;
                pub const m_iItemIDHigh: i64 = 0x1D0;
                pub const m_bDisallowSOC: i64 = 0x1E9;
                pub const m_bInitialized: i64 = 0x1E8;
                pub const m_bIsStoreItem: i64 = 0x1EA;
                pub const m_bIsTradeItem: i64 = 0x1EB;
                pub const m_iEntityLevel: i64 = 0x1C0;
                pub const m_szCustomName: i64 = 0x2F8;
                pub const m_AttributeList: i64 = 0x208;
                pub const m_unClientFlags: i64 = 0x1FD;
                pub const m_iEntityQuality: i64 = 0x1BC;
                pub const m_iEntityQuantity: i64 = 0x1EC;
                pub const m_iOriginOverride: i64 = 0x1F8;
                pub const m_iRarityOverride: i64 = 0x1F0;
                pub const m_ubStyleOverride: i64 = 0x1FC;
                pub const m_bInitializedTags: i64 = 0x5A8;
                pub const m_iQualityOverride: i64 = 0x1F4;
                pub const m_iInventoryPosition: i64 = 0x1DC;
                pub const m_iItemDefinitionIndex: i64 = 0x1BA;
                pub const m_szCustomNameOverride: i64 = 0x399;
                pub const m_szCustomNameOverride2: i64 = 0x43A;
                pub const m_szCustomNameOverride3: i64 = 0x4DB;
                pub const m_nInventoryImageRgbaWidth: i64 = 0x80;
                pub const m_bInventoryImageTriedCache: i64 = 0x61;
                pub const m_nInventoryImageRgbaHeight: i64 = 0x84;
                pub const m_NetworkedDynamicAttributes: i64 = 0x280;
                pub const m_szCurrentLoadCachedFileName: i64 = 0x88;
                pub const m_bInventoryImageRgbaRequested: i64 = 0x60;
                pub const m_bRestoreCustomMaterialAfterPrecache: i64 = 0x1B8;
            };
            pub const C_EconWearable = struct {
                pub const m_nForceSkin: i64 = 0x1918;
                pub const m_bAlwaysAllow: i64 = 0x191C;
            };
            pub const C_FuncConveyor = struct {
                pub const m_flTargetSpeed: i64 = 0x10AC;
                pub const m_flFrictionScale: i64 = 0x10BC;
                pub const m_hConveyorModels: i64 = 0x10C0;
                pub const m_nTransitionStartTick: i64 = 0x10B0;
                pub const m_vecMoveDirEntitySpace: i64 = 0x10A0;
                pub const m_flCurrentConveyorSpeed: i64 = 0x10DC;
                pub const m_flTransitionStartSpeed: i64 = 0x10B8;
                pub const m_flCurrentConveyorOffset: i64 = 0x10D8;
                pub const m_nTransitionDurationTicks: i64 = 0x10B4;
            };
            pub const C_FuncRotating = struct {

            };
            pub const C_RopeKeyframe = struct {
                pub const m_Slack: i64 = 0x136A;
                pub const m_Width: i64 = 0x1374;
                pub const m_Subdiv: i64 = 0x1366;
                pub const m_vWindDir: i64 = 0x13B8;
                pub const m_RopeFlags: i64 = 0x10D8;
                pub const m_hEndPoint: i64 = 0x1360;
                pub const m_hMaterial: i64 = 0x1388;
                pub const m_nSegments: i64 = 0x1358;
                pub const m_vColorMod: i64 = 0x13C4;
                pub const m_RopeLength: i64 = 0x1368;
                pub const m_bApplyWind: i64 = 0x10A8;
                pub const m_vecImpulse: i64 = 0x1394;
                pub const m_flCurScroll: i64 = 0x10D0;
                pub const m_hStartPoint: i64 = 0x135C;
                pub const m_TextureScale: i64 = 0x136C;
                pub const m_nChangeCount: i64 = 0x1371;
                pub const m_TextureHeight: i64 = 0x1390;
                pub const m_fLockedPoints: i64 = 0x1370;
                pub const m_flScrollSpeed: i64 = 0x10D4;
                pub const m_iEndAttachment: i64 = 0x1365;
                pub const m_PhysicsDelegate: i64 = 0x1378;
                pub const m_bPhysicsInitted: i64 = 0x0;
                pub const m_bPrevEndPointPos: i64 = 0x10B4;
                pub const m_flTimeToNextGust: i64 = 0x13B4;
                pub const m_iStartAttachment: i64 = 0x1364;
                pub const m_vPrevEndPointPos: i64 = 0x10B8;
                pub const m_bNewDataThisFrame: i64 = 0x0;
                pub const m_fPrevLockedPoints: i64 = 0x10AC;
                pub const m_flCurrentGustTimer: i64 = 0x13AC;
                pub const m_vecPreviousImpulse: i64 = 0x13A0;
                pub const m_flCurrentGustLifetime: i64 = 0x13B0;
                pub const m_LinksTouchingSomething: i64 = 0x10A0;
                pub const m_iForcePointMoveCounter: i64 = 0x10B0;
                pub const m_iRopeMaterialModelIndex: i64 = 0x10E0;
                pub const m_nLinksTouchingSomething: i64 = 0x10A4;
                pub const m_bConstrainBetweenEndpoints: i64 = 0x1400;
                pub const m_vCachedEndPointAttachmentPos: i64 = 0x13D0;
                pub const m_bEndPointAttachmentAnglesDirty: i64 = 0x0;
                pub const m_vCachedEndPointAttachmentAngle: i64 = 0x13E8;
                pub const m_bEndPointAttachmentPositionsDirty: i64 = 0x0;
            };
            pub const C_SmokeGrenade = struct {

            };
            pub const C_SpotlightEnd = struct {
                pub const m_Radius: i64 = 0x109C;
                pub const m_flLightScale: i64 = 0x1098;
            };
            pub const C_WeaponSCAR20 = struct {

            };
            pub const C_WeaponXM1014 = struct {

            };
            pub const CountdownTimer = struct {
                pub const m_duration: i64 = 0x8;
                pub const m_timescale: i64 = 0x10;
                pub const m_timestamp: i64 = 0xC;
                pub const m_nWorldGroupId: i64 = 0x14;
            };
            pub const CBuoyancyHelper = struct {
                pub const m_nFluidType: i64 = 0x18;
                pub const m_pController: i64 = 0x8;
                pub const m_vecWheelDrag: i64 = 0x78;
                pub const m_flFluidDensity: i64 = 0x1C;
                pub const m_bNeutrallyBuoyant: i64 = 0x2C;
                pub const m_vecWheelFrictionScales: i64 = 0x48;
                pub const m_flNeutrallyBuoyantGravity: i64 = 0x20;
                pub const m_flNeutrallyBuoyantLinearDamping: i64 = 0x24;
                pub const m_flNeutrallyBuoyantAngularDamping: i64 = 0x28;
                pub const m_vecFractionOfWheelSubmergedForWheelDrag: i64 = 0x60;
                pub const m_vecFractionOfWheelSubmergedForWheelFriction: i64 = 0x30;
            };
            pub const CCSRadarElement = struct {
                pub const m_nTeamFilter: i64 = 0x620;
                pub const m_nElementType: i64 = 0x618;
                pub const m_nElementColor: i64 = 0x61C;
            };
            pub const CEntityIdentity = struct {
                pub const m_name: i64 = 0x18;
                pub const m_flags: i64 = 0x30;
                pub const m_pNext: i64 = 0x58;
                pub const m_pPrev: i64 = 0x50;
                pub const m_PathIndex: i64 = 0x40;
                pub const m_pAttributes: i64 = 0x48;
                pub const m_designerName: i64 = 0x20;
                pub const m_pNextByClass: i64 = 0x68;
                pub const m_pPrevByClass: i64 = 0x60;
                pub const m_worldGroupId: i64 = 0x38;
                pub const m_fDataObjectTypes: i64 = 0x3C;
                pub const m_nameStringTableIndex: i64 = 0x14;
            };
            pub const CEntityInstance = struct {
                pub const m_pEntity: i64 = 0x10;
                pub const m_CScriptComponent: i64 = 0x28;
                pub const m_iszPrivateVScripts: i64 = 0x8;
            };
            pub const CFilterMultiple = struct {
                pub const m_hFilter: i64 = 0x690;
                pub const m_iFilterName: i64 = 0x640;
                pub const m_nFilterType: i64 = 0x638;
            };
            pub const CInfoWorldLayer = struct {
                pub const m_layerName: i64 = 0x620;
                pub const m_worldName: i64 = 0x618;
                pub const m_bEntitiesSpawned: i64 = 0x629;
                pub const m_hLayerSpawnGroup: i64 = 0x62C;
                pub const m_bWorldLayerVisible: i64 = 0x628;
                pub const m_bCreateAsChildSpawnGroup: i64 = 0x62A;
                pub const m_pOutputOnEntitiesSpawned: i64 = 0x600;
                pub const m_bWorldLayerActuallyVisible: i64 = 0x630;
            };
            pub const CLightComponent = struct {
                pub const m_Color: i64 = 0x78;
                pub const m_flPhi: i64 = 0xA4;
                pub const m_nStyle: i64 = 0xD4;
                pub const m_Pattern: i64 = 0xD8;
                pub const m_flRange: i64 = 0x8C;
                pub const m_flTheta: i64 = 0xA0;
                pub const m_SkyColor: i64 = 0x190;
                pub const m_bEnabled: i64 = 0x140;
                pub const m_bFlicker: i64 = 0x141;
                pub const m_flFalloff: i64 = 0x90;
                pub const m_nCascades: i64 = 0xB0;
                pub const m_flBrightness: i64 = 0x80;
                pub const m_hLightCookie: i64 = 0xA8;
                pub const m_nBounceLight: i64 = 0x128;
                pub const m_nCastShadows: i64 = 0xB4;
                pub const m_nDirectLight: i64 = 0x124;
                pub const m_nShadowWidth: i64 = 0xB8;
                pub const m_bMixedShadows: i64 = 0x19D;
                pub const m_flBounceScale: i64 = 0x12C;
                pub const m_flFadeMaxDist: i64 = 0x134;
                pub const m_flFadeMinDist: i64 = 0x130;
                pub const m_nShadowHeight: i64 = 0xBC;
                pub const __m_pChainEntity: i64 = 0x38;
                pub const m_SecondaryColor: i64 = 0x7C;
                pub const m_bRenderDiffuse: i64 = 0xC0;
                pub const m_flAttenuation0: i64 = 0x94;
                pub const m_flAttenuation1: i64 = 0x98;
                pub const m_flAttenuation2: i64 = 0x9C;
                pub const m_flMinRoughness: i64 = 0x1A8;
                pub const m_flSkyIntensity: i64 = 0x194;
                pub const m_flCapsuleLength: i64 = 0x1A4;
                pub const m_flNearClipPlane: i64 = 0x18C;
                pub const m_nRenderSpecular: i64 = 0xC4;
                pub const m_nShadowPriority: i64 = 0x110;
                pub const m_SkyAmbientBounce: i64 = 0x198;
                pub const m_flBrightnessMult: i64 = 0x88;
                pub const m_nFogLightingMode: i64 = 0x184;
                pub const m_bRenderToCubemaps: i64 = 0x120;
                pub const m_flBrightnessScale: i64 = 0x84;
                pub const m_flOrthoLightWidth: i64 = 0xCC;
                pub const m_nBakedShadowIndex: i64 = 0x114;
                pub const m_nLightMapUniqueId: i64 = 0x11C;
                pub const m_bUseSecondaryColor: i64 = 0x19C;
                pub const m_flOrthoLightHeight: i64 = 0xD0;
                pub const m_nLightPathUniqueId: i64 = 0x118;
                pub const m_bAllowSSTGeneration: i64 = 0x121;
                pub const m_bRenderTransmissive: i64 = 0xC8;
                pub const m_bUsesBakedShadowing: i64 = 0x10C;
                pub const m_flShadowFadeMaxDist: i64 = 0x13C;
                pub const m_flShadowFadeMinDist: i64 = 0x138;
                pub const m_flLightStyleStartTime: i64 = 0x1A0;
                pub const m_flPrecomputedMaxRange: i64 = 0x180;
                pub const m_vPrecomputedOBBAngles: i64 = 0x168;
                pub const m_vPrecomputedOBBExtent: i64 = 0x174;
                pub const m_vPrecomputedOBBOrigin: i64 = 0x15C;
                pub const m_vPrecomputedBoundsMaxs: i64 = 0x150;
                pub const m_vPrecomputedBoundsMins: i64 = 0x144;
                pub const m_bPrecomputedFieldsValid: i64 = 0x142;
                pub const m_flFogContributionStength: i64 = 0x188;
                pub const m_flShadowCascadeCrossFade: i64 = 0xE4;
                pub const m_flShadowCascadeDistance0: i64 = 0xEC;
                pub const m_flShadowCascadeDistance1: i64 = 0xF0;
                pub const m_flShadowCascadeDistance2: i64 = 0xF4;
                pub const m_flShadowCascadeDistance3: i64 = 0xF8;
                pub const m_nShadowCascadeResolution0: i64 = 0xFC;
                pub const m_nShadowCascadeResolution1: i64 = 0x100;
                pub const m_nShadowCascadeResolution2: i64 = 0x104;
                pub const m_nShadowCascadeResolution3: i64 = 0x108;
                pub const m_flShadowCascadeDistanceFade: i64 = 0xE8;
                pub const m_nCascadeRenderStaticObjects: i64 = 0xE0;
                pub const m_bAmbientOcclusionProxyOverride: i64 = 0x1AC;
                pub const m_hAmbientOcclusionProxyPosition0: i64 = 0x1B0;
                pub const m_hAmbientOcclusionProxyPosition1: i64 = 0x1B4;
                pub const m_hAmbientOcclusionProxyPosition2: i64 = 0x1B8;
                pub const m_hAmbientOcclusionProxyPosition3: i64 = 0x1BC;
                pub const m_flAmbientOcclusionProxyStrength0: i64 = 0x1C0;
                pub const m_flAmbientOcclusionProxyStrength1: i64 = 0x1C4;
                pub const m_flAmbientOcclusionProxyStrength2: i64 = 0x1C8;
                pub const m_flAmbientOcclusionProxyStrength3: i64 = 0x1CC;
                pub const m_flAmbientOcclusionProxyConeAngle0: i64 = 0x1D4;
                pub const m_flAmbientOcclusionProxyConeAngle1: i64 = 0x1D8;
                pub const m_flAmbientOcclusionProxyConeAngle2: i64 = 0x1DC;
                pub const m_flAmbientOcclusionProxyConeAngle3: i64 = 0x1E0;
                pub const m_flAmbientOcclusionProxyAmbientStrength: i64 = 0x1D0;
            };
            pub const CPulseCell_Base = struct {
                pub const m_nEditorNodeID: i64 = 0x8;
            };
            pub const CPulse_CallInfo = struct {
                pub const m_PortName: i64 = 0x0;
                pub const m_nSrcChunk: i64 = 0x4C;
                pub const m_RegisterMap: i64 = 0x18;
                pub const m_CallMethodID: i64 = 0x48;
                pub const m_nEditorNodeID: i64 = 0x10;
                pub const m_nBreakDestChunk: i64 = 0x54;
                pub const m_nSrcInstruction: i64 = 0x50;
                pub const m_nBreakDestInstruction: i64 = 0x58;
            };
            pub const CRagdollManager = struct {
                pub const m_iCurrentMaxRagdollCount: i64 = 0x600;
            };
            pub const CSpriteOriented = struct {

            };
            pub const C_BaseCSGrenade = struct {
                pub const m_bRedraw: i64 = 0x1F21;
                pub const m_fDropTime: i64 = 0x1FA8;
                pub const m_bJumpThrow: i64 = 0x1F24;
                pub const m_bPinPulled: i64 = 0x1F23;
                pub const m_fThrowTime: i64 = 0x1F28;
                pub const m_fPinPullTime: i64 = 0x1FAC;
                pub const m_nNextHoldTick: i64 = 0x1FB4;
                pub const m_bJustPulledPin: i64 = 0x1FB0;
                pub const m_flNextHoldFrac: i64 = 0x1FB8;
                pub const m_bIsHeldByPlayer: i64 = 0x1F22;
                pub const m_bThrowAnimating: i64 = 0x1F25;
                pub const m_flThrowStrength: i64 = 0x1F30;
                pub const m_bClientPredictDelete: i64 = 0x1F20;
                pub const m_hSwitchToWeaponAfterThrow: i64 = 0x1FBC;
            };
            pub const C_BreakableProp = struct {
                pub const m_OnBreak: i64 = 0x12F8;
                pub const m_hBreaker: i64 = 0x1364;
                pub const m_OnStartDeath: i64 = 0x12E0;
                pub const m_OnTakeDamage: i64 = 0x1330;
                pub const m_explodeDamage: i64 = 0x138C;
                pub const m_explodeRadius: i64 = 0x1390;
                pub const m_hLastAttacker: i64 = 0x13D4;
                pub const m_iMinHealthDmg: i64 = 0x134C;
                pub const m_explosionDelay: i64 = 0x13A0;
                pub const m_sExplosionType: i64 = 0x1398;
                pub const m_OnHealthChanged: i64 = 0x1310;
                pub const m_PerformanceMode: i64 = 0x1368;
                pub const m_flDefBurstScale: i64 = 0x1354;
                pub const m_flPressureDelay: i64 = 0x1350;
                pub const m_vDefBurstOffset: i64 = 0x1358;
                pub const m_hPhysicsAttacker: i64 = 0x13C8;
                pub const m_explosionModifier: i64 = 0x13C0;
                pub const m_impactEnergyScale: i64 = 0x1348;
                pub const m_CPropDataComponent: i64 = 0x12A0;
                pub const m_flDefaultFadeScale: i64 = 0x13D0;
                pub const m_explosionCustomSound: i64 = 0x13B8;
                pub const m_BreakableContentsType: i64 = 0x1370;
                pub const m_explosionBuildupSound: i64 = 0x13A8;
                pub const m_explosionCustomEffect: i64 = 0x13B0;
                pub const m_bHasBreakPiecesOrCommands: i64 = 0x1388;
                pub const m_flPreventDamageBeforeTime: i64 = 0x136C;
                pub const m_flLastPhysicsInfluenceTime: i64 = 0x13CC;
                pub const m_strBreakableContentsParticleOverride: i64 = 0x1380;
                pub const m_strBreakableContentsPropGroupOverride: i64 = 0x1378;
            };
            pub const C_ClientRagdoll = struct {
                pub const m_bFadeOut: i64 = 0x1268;
                pub const m_bFadingOut: i64 = 0x1286;
                pub const m_bImportant: i64 = 0x1269;
                pub const m_flScaleEnd: i64 = 0x1288;
                pub const m_flEffectTime: i64 = 0x126C;
                pub const m_iMaxFriction: i64 = 0x127C;
                pub const m_iMinFriction: i64 = 0x1278;
                pub const m_flScaleTimeEnd: i64 = 0x12D8;
                pub const m_gibDespawnTime: i64 = 0x1270;
                pub const m_iEyeAttachment: i64 = 0x1285;
                pub const m_bReleaseRagdoll: i64 = 0x1284;
                pub const m_flScaleTimeStart: i64 = 0x12B0;
                pub const m_iCurrentFriction: i64 = 0x1274;
                pub const m_iFrictionAnimState: i64 = 0x1280;
            };
            pub const C_EnvCubemapBox = struct {

            };
            pub const C_EnvCubemapFog = struct {
                pub const m_bActive: i64 = 0x624;
                pub const m_flLODBias: i64 = 0x620;
                pub const m_bFirstTime: i64 = 0x6F9;
                pub const m_hSkyMaterial: i64 = 0x630;
                pub const m_iszSkyEntity: i64 = 0x638;
                pub const m_flEndDistance: i64 = 0x600;
                pub const m_bStartDisabled: i64 = 0x625;
                pub const m_flFogHeightEnd: i64 = 0x614;
                pub const m_nHeightFogType: i64 = 0x640;
                pub const m_flFogMaxOpacity: i64 = 0x628;
                pub const m_flStartDistance: i64 = 0x604;
                pub const m_bHasHeightFogEnd: i64 = 0x6F8;
                pub const m_flFogHeightStart: i64 = 0x618;
                pub const m_flFogHeightWidth: i64 = 0x610;
                pub const m_nDistanceFogType: i64 = 0x64C;
                pub const m_bHeightFogEnabled: i64 = 0x60C;
                pub const m_hFogCubemapTexture: i64 = 0x6F0;
                pub const m_nCubemapSourceType: i64 = 0x62C;
                pub const m_flFogHeightExponent: i64 = 0x61C;
                pub const m_nFogHeightBlendMode: i64 = 0x644;
                pub const m_HeightFogCurveString: i64 = 0x658;
                pub const m_flFogFalloffExponent: i64 = 0x608;
                pub const m_DistanceFogCurveString: i64 = 0x650;
                pub const m_nFogHeightCoordinateSpace: i64 = 0x648;
            };
            pub const C_EnvWindShared = struct {
                pub const m_iMaxGust: i64 = 0x1A;
                pub const m_iMaxWind: i64 = 0x12;
                pub const m_iMinGust: i64 = 0x18;
                pub const m_iMinWind: i64 = 0x10;
                pub const m_location: i64 = 0x30;
                pub const m_hEntOwner: i64 = 0x3C;
                pub const m_iWindSeed: i64 = 0xC;
                pub const m_windRadius: i64 = 0x14;
                pub const m_flStartTime: i64 = 0x8;
                pub const m_flGustDuration: i64 = 0x24;
                pub const m_flMaxGustDelay: i64 = 0x20;
                pub const m_flMinGustDelay: i64 = 0x1C;
                pub const m_iGustDirChange: i64 = 0x28;
                pub const m_iInitialWindDir: i64 = 0x2A;
                pub const m_flInitialWindSpeed: i64 = 0x2C;
            };
            pub const C_FogController = struct {
                pub const m_fog: i64 = 0x600;
                pub const m_bUseAngles: i64 = 0x668;
                pub const m_iChangedVariables: i64 = 0x66C;
            };
            pub const C_NametagModule = struct {
                pub const m_strNametagString: i64 = 0x1270;
            };
            pub const C_Precipitation = struct {
                pub const m_flDensity: i64 = 0x1180;
                pub const m_pParticleDef: i64 = 0x1198;
                pub const m_flParticleInnerDist: i64 = 0x1190;
                pub const m_tParticlePrecipTraceTimer: i64 = 0x11AC;
                pub const m_bParticlePrecipInitialized: i64 = 0x11B5;
                pub const m_bActiveParticlePrecipEmitter: i64 = 0x11B4;
                pub const m_nAvailableSheetSequencesMaxIndex: i64 = 0x11B8;
                pub const m_bHasSimulatedSinceLastSceneObjectUpdate: i64 = 0x11B6;
            };
            pub const C_TeamplayRules = struct {

            };
            pub const C_TriggerVolume = struct {

            };
            pub const C_WeaponGalilAR = struct {

            };
            pub const C_WeaponHKP2000 = struct {

            };
            pub const inv_image_map_t = struct {
                pub const map_name: i64 = 0x0;
                pub const map_rotation: i64 = 0x8;
            };
            pub const CBasePlayerVData = struct {
                pub const m_flUseRange: i64 = 0x24C;
                pub const m_sModelName: i64 = 0x28;
                pub const m_nWaterSpeed: i64 = 0x248;
                pub const m_flCrouchTime: i64 = 0x254;
                pub const m_flHoldBreathTime: i64 = 0x238;
                pub const m_nDrowningDamageMax: i64 = 0x244;
                pub const m_flUseAngleTolerance: i64 = 0x250;
                pub const m_flArmDamageMultiplier: i64 = 0x218;
                pub const m_flLegDamageMultiplier: i64 = 0x228;
                pub const m_sModelNameAg2Override: i64 = 0x108;
                pub const m_flHeadDamageMultiplier: i64 = 0x1E8;
                pub const m_nDrowningDamageInitial: i64 = 0x240;
                pub const m_flChestDamageMultiplier: i64 = 0x1F8;
                pub const m_flDrowningDamageInterval: i64 = 0x23C;
                pub const m_flStomachDamageMultiplier: i64 = 0x208;
            };
            pub const CBrokenGlassTrap = struct {

            };
            pub const CCSGameModeRules = struct {
                pub const __m_pChainEntity: i64 = 0x8;
            };
            pub const CCSMinimapVolume = struct {
                pub const m_strMinimapName: i64 = 0x1180;
            };
            pub const CChoreoComponent = struct {
                pub const m_hOwner: i64 = 0x30;
                pub const __m_pChainEntity: i64 = 0x8;
                pub const m_nNextSceneEventId: i64 = 0x70;
                pub const m_flAllowResponsesEndTime: i64 = 0x74;
                pub const m_nExernalChoreoGraphCount: i64 = 0x34;
                pub const m_sActiveExternalChoreoGraphSlotID: i64 = 0x38;
            };
            pub const CEntityComponent = struct {

            };
            pub const CFilterProximity = struct {
                pub const m_flRadius: i64 = 0x638;
            };
            pub const CGlobalLightBase = struct {
                pub const m_flFOV: i64 = 0x80;
                pub const m_flFarZ: i64 = 0x88;
                pub const m_flNearZ: i64 = 0x84;
                pub const m_hEnvSky: i64 = 0x4BC;
                pub const m_bEnabled: i64 = 0x69;
                pub const m_hEnvWind: i64 = 0x4B8;
                pub const m_flViewFoV: i64 = 0xEC;
                pub const m_vFowColor: i64 = 0xC8;
                pub const m_LightColor: i64 = 0x6C;
                pub const m_ViewAngles: i64 = 0xE0;
                pub const m_ViewOrigin: i64 = 0xD4;
                pub const m_bSpotLight: i64 = 0x10;
                pub const m_WorldPoints: i64 = 0xF0;
                pub const m_flCloudScale: i64 = 0x90;
                pub const m_flLightScale: i64 = 0xBC;
                pub const m_AmbientColor1: i64 = 0x70;
                pub const m_AmbientColor2: i64 = 0x74;
                pub const m_AmbientColor3: i64 = 0x78;
                pub const m_SpecularColor: i64 = 0x64;
                pub const m_flCloud1Speed: i64 = 0x94;
                pub const m_flCloud2Speed: i64 = 0x9C;
                pub const m_flFoWDarkness: i64 = 0xC0;
                pub const m_flGroundScale: i64 = 0xB8;
                pub const m_flSunDistance: i64 = 0x7C;
                pub const m_bEnableShadows: i64 = 0x8C;
                pub const m_bStartDisabled: i64 = 0x68;
                pub const m_ShadowDirection: i64 = 0x2C;
                pub const m_SpotLightAngles: i64 = 0x20;
                pub const m_SpotLightOrigin: i64 = 0x14;
                pub const m_flAmbientScale1: i64 = 0xB0;
                pub const m_flAmbientScale2: i64 = 0xB4;
                pub const m_flSpecularPower: i64 = 0x5C;
                pub const m_AmbientDirection: i64 = 0x38;
                pub const m_vFogOffsetLayer0: i64 = 0x4A8;
                pub const m_vFogOffsetLayer1: i64 = 0x4B0;
                pub const m_SpecularDirection: i64 = 0x44;
                pub const m_bOldEnableShadows: i64 = 0x8D;
                pub const m_flCloud1Direction: i64 = 0x98;
                pub const m_flCloud2Direction: i64 = 0xA0;
                pub const m_flSpecularIndependence: i64 = 0x60;
                pub const m_bEnableSeparateSkyboxFog: i64 = 0xC4;
                pub const m_InspectorSpecularDirection: i64 = 0x50;
                pub const m_bBackgroundClearNotRequired: i64 = 0x8E;
            };
            pub const CHitboxComponent = struct {
                pub const m_flBoundsExpandRadius: i64 = 0x14;
            };
            pub const CNoiseStreamData = struct {
                pub const m_Stream: i64 = 0x0;
            };
            pub const CPulseExecCursor = struct {

            };
            pub const CRenderComponent = struct {
                pub const __m_pChainEntity: i64 = 0x10;
                pub const m_bEnableRendering: i64 = 0x58;
                pub const m_nSplitscreenFlags: i64 = 0x54;
                pub const m_bInterpolationReadyToDraw: i64 = 0xA8;
                pub const m_bIsRenderingWithViewModels: i64 = 0x50;
            };
            pub const CScriptComponent = struct {
                pub const m_scriptClassName: i64 = 0x30;
            };
            pub const CSkyboxReference = struct {
                pub const m_hSkyCamera: i64 = 0x604;
                pub const m_worldGroupId: i64 = 0x600;
            };
            pub const C_BasePlayerPawn = struct {
                pub const v_angle: i64 = 0x13A8;
                pub const m_iHideHUD: i64 = 0x13C0;
                pub const m_skybox3d: i64 = 0x13C8;
                pub const m_vOldOrigin: i64 = 0x14A4;
                pub const m_flDeathTime: i64 = 0x1458;
                pub const m_hController: i64 = 0x14BC;
                pub const m_pUseServices: i64 = 0x1318;
                pub const m_pItemServices: i64 = 0x12F8;
                pub const v_anglePrevious: i64 = 0x13B4;
                pub const m_pWaterServices: i64 = 0x1310;
                pub const m_pCameraServices: i64 = 0x1328;
                pub const m_pWeaponServices: i64 = 0x12F0;
                pub const m_pAutoaimServices: i64 = 0x1300;
                pub const m_pMovementServices: i64 = 0x1330;
                pub const m_pObserverServices: i64 = 0x1308;
                pub const m_flMouseSensitivity: i64 = 0x14A0;
                pub const m_hDefaultController: i64 = 0x14C0;
                pub const m_vecPredictionError: i64 = 0x1460;
                pub const m_flOldSimulationTime: i64 = 0x14B0;
                pub const m_pFlashlightServices: i64 = 0x1320;
                pub const m_flLastCameraSetupTime: i64 = 0x1498;
                pub const m_flPredictionErrorTime: i64 = 0x146C;
                pub const m_ServerViewAngleChanges: i64 = 0x1340;
                pub const m_flFOVSensitivityAdjust: i64 = 0x149C;
                pub const m_nLastExecutedCommandTick: i64 = 0x14B8;
                pub const m_nLastExecutedCommandNumber: i64 = 0x14B4;
                pub const m_vecLastCameraSetupLocalOrigin: i64 = 0x148C;
                pub const m_bIsSwappingToPredictableController: i64 = 0x14C4;
            };
            pub const C_BulletHitModel = struct {
                pub const m_bIsHit: i64 = 0x12A0;
                pub const m_matLocal: i64 = 0x1268;
                pub const m_iBoneIndex: i64 = 0x1298;
                pub const m_vecStartPos: i64 = 0x12A8;
                pub const m_flTimeCreated: i64 = 0x12A4;
                pub const m_hPlayerParent: i64 = 0x129C;
            };
            pub const C_CSObserverPawn = struct {
                pub const m_hDetectParentChange: i64 = 0x1568;
            };
            pub const C_CSPetPlacement = struct {

            };
            pub const C_CommandContext = struct {
                pub const command_number: i64 = 0xA0;
                pub const needsprocessing: i64 = 0x0;
            };
            pub const C_CsmFovOverride = struct {
                pub const m_cameraName: i64 = 0x600;
                pub const m_flCsmFovOverrideValue: i64 = 0x608;
            };
            pub const C_EntityDissolve = struct {
                pub const m_nMagnitude: i64 = 0x10C0;
                pub const m_flStartTime: i64 = 0x10A0;
                pub const m_bCoreExplode: i64 = 0x10D4;
                pub const m_flFadeInStart: i64 = 0x10A4;
                pub const m_nDissolveType: i64 = 0x10BC;
                pub const m_flFadeInLength: i64 = 0x10A8;
                pub const m_flFadeOutStart: i64 = 0x10B4;
                pub const m_flFadeOutLength: i64 = 0x10B8;
                pub const m_flNextSparkTime: i64 = 0x10D0;
                pub const m_vDissolverOrigin: i64 = 0x10C4;
                pub const m_bLinkedToServerEnt: i64 = 0x10D5;
                pub const m_flFadeOutModelStart: i64 = 0x10AC;
                pub const m_flFadeOutModelLength: i64 = 0x10B0;
            };
            pub const C_EnvShakeVolume = struct {
                pub const m_vBoxMaxs: i64 = 0x624;
                pub const m_vBoxMins: i64 = 0x618;
                pub const m_flAmplitude: i64 = 0x630;
                pub const m_flFrequency: i64 = 0x634;
                pub const m_flRollScale: i64 = 0x63C;
                pub const m_flFalloffDistance: i64 = 0x638;
            };
            pub const C_FuncMoveLinear = struct {

            };
            pub const C_FuncTrackTrain = struct {
                pub const m_flRadius: i64 = 0x109C;
                pub const m_nLongAxis: i64 = 0x1098;
                pub const m_flLineLength: i64 = 0x10A0;
            };
            pub const C_GameRulesProxy = struct {

            };
            pub const C_KeychainModule = struct {
                pub const m_nKeychainSeed: i64 = 0x1274;
                pub const m_nKeychainDefID: i64 = 0x1270;
            };
            pub const C_MolotovGrenade = struct {

            };
            pub const C_MultiplayRules = struct {

            };
            pub const C_ParticleSystem = struct {
                pub const m_bActive: i64 = 0x1298;
                pub const m_bFrozen: i64 = 0x1299;
                pub const m_bNoRamp: i64 = 0x13FA;
                pub const m_bNoSave: i64 = 0x13F8;
                pub const m_clrTint: i64 = 0x161C;
                pub const m_nDataCP: i64 = 0x1608;
                pub const m_nTintCP: i64 = 0x1618;
                pub const m_bNoFreeze: i64 = 0x13F9;
                pub const m_nStopType: i64 = 0x12A0;
                pub const m_bOldActive: i64 = 0x1640;
                pub const m_bOldFrozen: i64 = 0x1641;
                pub const m_flStartTime: i64 = 0x12B0;
                pub const m_bStartActive: i64 = 0x13FB;
                pub const m_flPreSimTime: i64 = 0x12B4;
                pub const m_iEffectIndex: i64 = 0x12A8;
                pub const m_iszEffectName: i64 = 0x1400;
                pub const m_strDataString: i64 = 0x13F0;
                pub const m_vecDataCPValue: i64 = 0x160C;
                pub const m_hControlPointEnts: i64 = 0x12EC;
                pub const m_szSnapshotFileName: i64 = 0x1098;
                pub const m_bDataStringLocalized: i64 = 0x13EC;
                pub const m_iszControlPointNames: i64 = 0x1408;
                pub const m_vServerControlPoints: i64 = 0x12B8;
                pub const m_flFreezeTransitionDuration: i64 = 0x129C;
                pub const m_bAnimateDuringGameplayPause: i64 = 0x12A4;
                pub const m_iServerControlPointAssignments: i64 = 0x12E8;
            };
            pub const C_PointWorldText = struct {
                pub const m_Color: i64 = 0x1360;
                pub const m_FontName: i64 = 0x12C0;
                pub const m_bEnabled: i64 = 0x1340;
                pub const m_flFontSize: i64 = 0x1348;
                pub const m_bFullbright: i64 = 0x1341;
                pub const m_messageText: i64 = 0x10C0;
                pub const m_nTextWidthPx: i64 = 0x10B8;
                pub const m_flDepthOffset: i64 = 0x134C;
                pub const m_nReorientMode: i64 = 0x136C;
                pub const m_nTextHeightPx: i64 = 0x10BC;
                pub const m_bDrawBackground: i64 = 0x1350;
                pub const m_nJustifyVertical: i64 = 0x1368;
                pub const m_flWorldUnitsPerPx: i64 = 0x1344;
                pub const m_nJustifyHorizontal: i64 = 0x1364;
                pub const m_flBackgroundWorldToUV: i64 = 0x135C;
                pub const m_BackgroundMaterialName: i64 = 0x1300;
                pub const m_flBackgroundBorderWidth: i64 = 0x1354;
                pub const m_bForceRecreateNextUpdate: i64 = 0x10A0;
                pub const m_flBackgroundBorderHeight: i64 = 0x1358;
            };
            pub const C_StattrakModule = struct {
                pub const m_bKnife: i64 = 0x1270;
            };
            pub const C_TintController = struct {

            };
            pub const C_TriggerPhysics = struct {
                pub const m_flFrequency: i64 = 0x1198;
                pub const m_linearForce: i64 = 0x1194;
                pub const m_linearLimit: i64 = 0x1184;
                pub const m_angularLimit: i64 = 0x118C;
                pub const m_gravityScale: i64 = 0x1180;
                pub const m_linearDamping: i64 = 0x1188;
                pub const m_angularDamping: i64 = 0x1190;
                pub const m_flDampingRatio: i64 = 0x119C;
                pub const m_bCollapseToForcePoint: i64 = 0x11AC;
                pub const m_vecLinearForcePointAt: i64 = 0x11A0;
                pub const m_vecLinearForceDirection: i64 = 0x11BC;
                pub const m_vecLinearForcePointAtWorld: i64 = 0x11B0;
                pub const m_bConvertToDebrisWhenPossible: i64 = 0x11C9;
                pub const m_bForceDirectionIsInLocalSpace: i64 = 0x11C8;
            };
            pub const C_VoteController = struct {
                pub const m_bTypeDirty: i64 = 0x631;
                pub const m_bVotesDirty: i64 = 0x630;
                pub const m_bIsYesNoVote: i64 = 0x632;
                pub const m_iOnlyTeamToVote: i64 = 0x614;
                pub const m_nPotentialVotes: i64 = 0x62C;
                pub const m_nVoteOptionCount: i64 = 0x618;
                pub const m_iActiveIssueIndex: i64 = 0x610;
            };
            pub const C_WeaponBaseItem = struct {
                pub const m_bRedraw: i64 = 0x1F21;
                pub const m_bSequenceInProgress: i64 = 0x1F20;
            };
            pub const C_WeaponRevolver = struct {

            };
            pub const C_WeaponSawedoff = struct {

            };
            pub const FilterDamageType = struct {
                pub const m_iDamageType: i64 = 0x638;
            };
            pub const inv_image_data_t = struct {
                pub const map: i64 = 0x0;
                pub const item: i64 = 0x10;
                pub const camera: i64 = 0x30;
                pub const light0: i64 = 0xA0;
                pub const light1: i64 = 0xC0;
                pub const lightsun: i64 = 0x68;
                pub const lightfill: i64 = 0x84;
                pub const clearcolor: i64 = 0xE0;
            };
            pub const inv_image_item_t = struct {
                pub const angle: i64 = 0xC;
                pub const position: i64 = 0x0;
                pub const pose_sequence: i64 = 0x18;
            };
            pub const CAttributeManager = struct {
                pub const m_hOuter: i64 = 0x24;
                pub const m_Providers: i64 = 0x8;
                pub const m_ProviderType: i64 = 0x2C;
                pub const m_CachedResults: i64 = 0x30;
                pub const m_bPreventLoopback: i64 = 0x28;
                pub const m_iReapplyProvisionParity: i64 = 0x20;
            };
            pub const CChoreoInfoTarget = struct {

            };
            pub const CFlashlightEffect = struct {
                pub const m_bIsOn: i64 = 0x10;
                pub const m_flFov: i64 = 0x4C;
                pub const m_flFarZ: i64 = 0x50;
                pub const m_textureName: i64 = 0x70;
                pub const m_bCastsShadows: i64 = 0x58;
                pub const m_flLinearAtten: i64 = 0x54;
                pub const m_FlashlightTexture: i64 = 0x60;
                pub const m_MuzzleFlashTexture: i64 = 0x68;
                pub const m_bMuzzleFlashEnabled: i64 = 0x20;
                pub const m_vecMuzzleFlashOrigin: i64 = 0x40;
                pub const m_flCurrentPullBackDist: i64 = 0x5C;
                pub const m_flMuzzleFlashBrightness: i64 = 0x24;
                pub const m_quatMuzzleFlashOrientation: i64 = 0x30;
            };
            pub const CSPerRoundStats_t = struct {
                pub const m_iKills: i64 = 0x30;
                pub const m_iDamage: i64 = 0x3C;
                pub const m_iDeaths: i64 = 0x34;
                pub const m_iAssists: i64 = 0x38;
                pub const m_iLiveTime: i64 = 0x4C;
                pub const m_iObjective: i64 = 0x54;
                pub const m_iCashEarned: i64 = 0x58;
                pub const m_iKillReward: i64 = 0x48;
                pub const m_iMoneySaved: i64 = 0x44;
                pub const m_iHeadShotKills: i64 = 0x50;
                pub const m_iUtilityDamage: i64 = 0x5C;
                pub const m_iEnemiesFlashed: i64 = 0x60;
                pub const m_iEquipmentValue: i64 = 0x40;
            };
            pub const CSkeletonInstance = struct {
                pub const m_modelState: i64 = 0x140;
                pub const m_nHitboxSet: i64 = 0x3FC;
                pub const m_materialGroup: i64 = 0x3F8;
                pub const m_bDirtyMotionType: i64 = 0x3F2;
                pub const m_bUseParentRenderBounds: i64 = 0x3F0;
                pub const m_bDisableSolidCollisionsForHierarchy: i64 = 0x3F1;
                pub const m_bIsGeneratingLatchedParentSpaceState: i64 = 0x3F3;
            };
            pub const C_BaseModelEntity = struct {
                pub const m_Glow: i64 = 0xDE8;
                pub const m_Collision: i64 = 0xD30;
                pub const m_clrRender: i64 = 0xCA0;
                pub const m_nRenderFX: i64 = 0xC81;
                pub const m_iOldHealth: i64 = 0xC7C;
                pub const m_fadeMaxDist: i64 = 0xE48;
                pub const m_fadeMinDist: i64 = 0xE44;
                pub const m_flFadeScale: i64 = 0xE4C;
                pub const m_nRenderMode: i64 = 0xC80;
                pub const m_vecViewOffset: i64 = 0xF60;
                pub const m_bNoInterpolate: i64 = 0xD2A;
                pub const m_nObjectCulling: i64 = 0xE54;
                pub const m_CHitboxComponent: i64 = 0xB00;
                pub const m_CRenderComponent: i64 = 0xAF8;
                pub const m_bAllowFadeInView: i64 = 0xC82;
                pub const m_bodyGroupChoices: i64 = 0xF38;
                pub const m_flShadowStrength: i64 = 0xE50;
                pub const m_pChoreoComponent: i64 = 0xB18;
                pub const m_bInitModelEffects: i64 = 0xC78;
                pub const m_bRenderToCubemaps: i64 = 0xD28;
                pub const m_bodyGroupRequests: i64 = 0xE60;
                pub const m_ClientOverrideTint: i64 = 0x1048;
                pub const m_bDoingModelEffects: i64 = 0xC79;
                pub const m_flGlowBackfaceMult: i64 = 0xE40;
                pub const m_bvDisabledHitGroups: i64 = 0x1088;
                pub const m_vecRenderAttributes: i64 = 0xCA8;
                pub const m_pClientAlphaProperty: i64 = 0x1040;
                pub const m_bUseClientOverrideTint: i64 = 0x104C;
                pub const m_nRequiredDecalRtEncoding: i64 = 0xE55;
                pub const m_bodyGroupTotalRequestCount: i64 = 0xE58;
                pub const m_bExpandRenderBoundsToIncludeCloth: i64 = 0xD29;
                pub const m_pDestructiblePartsSystemComponent: i64 = 0xB50;
                pub const m_nDestructiblePartInitialStateDestructed0: i64 = 0xB20;
                pub const m_nDestructiblePartInitialStateDestructed1: i64 = 0xB24;
                pub const m_nDestructiblePartInitialStateDestructed2: i64 = 0xB28;
                pub const m_nDestructiblePartInitialStateDestructed3: i64 = 0xB2C;
                pub const m_nDestructiblePartInitialStateDestructed4: i64 = 0xB30;
                pub const m_nDestructiblePartInitialStateDestructed0_PartIndex: i64 = 0xB34;
                pub const m_nDestructiblePartInitialStateDestructed1_PartIndex: i64 = 0xB38;
                pub const m_nDestructiblePartInitialStateDestructed2_PartIndex: i64 = 0xB3C;
                pub const m_nDestructiblePartInitialStateDestructed3_PartIndex: i64 = 0xB40;
                pub const m_nDestructiblePartInitialStateDestructed4_PartIndex: i64 = 0xB44;
                pub const m_bDestructiblePartInitialStateDestructed0_GenerateBreakpieces: i64 = 0xB48;
                pub const m_bDestructiblePartInitialStateDestructed1_GenerateBreakpieces: i64 = 0xB49;
                pub const m_bDestructiblePartInitialStateDestructed2_GenerateBreakpieces: i64 = 0xB4A;
                pub const m_bDestructiblePartInitialStateDestructed3_GenerateBreakpieces: i64 = 0xB4B;
                pub const m_bDestructiblePartInitialStateDestructed4_GenerateBreakpieces: i64 = 0xB4C;
            };
            pub const C_CS2HudModelArms = struct {

            };
            pub const C_CS2HudModelBase = struct {

            };
            pub const C_CSWeaponBaseGun = struct {
                pub const m_zoomLevel: i64 = 0x1F20;
                pub const m_inPrecache: i64 = 0x1F3C;
                pub const m_bNeedsBoltAction: i64 = 0x1F3D;
                pub const m_iSilencerBodygroup: i64 = 0x1F28;
                pub const m_silencedModelIndex: i64 = 0x1F38;
                pub const m_iBurstShotsRemaining: i64 = 0x1F24;
                pub const m_nRevolverCylinderIdx: i64 = 0x1F40;
            };
            pub const C_ColorCorrection = struct {
                pub const m_bMaster: i64 = 0x825;
                pub const m_bEnabled: i64 = 0x824;
                pub const m_bFadingIn: i64 = 0x830;
                pub const m_vecOrigin: i64 = 0x600;
                pub const m_MaxFalloff: i64 = 0x610;
                pub const m_MinFalloff: i64 = 0x60C;
                pub const m_bExclusive: i64 = 0x827;
                pub const m_bClientSide: i64 = 0x826;
                pub const m_flCurWeight: i64 = 0x620;
                pub const m_flMaxWeight: i64 = 0x61C;
                pub const m_flFadeDuration: i64 = 0x83C;
                pub const m_flFadeStartTime: i64 = 0x838;
                pub const m_bEnabledOnClient: i64 = 0x828;
                pub const m_flFadeInDuration: i64 = 0x614;
                pub const m_flFadeOutDuration: i64 = 0x618;
                pub const m_flFadeStartWeight: i64 = 0x834;
                pub const m_netlookupFilename: i64 = 0x624;
                pub const m_flCurWeightOnClient: i64 = 0x82C;
            };
            pub const C_DecoyProjectile = struct {
                pub const m_nDecoyShotTick: i64 = 0x1348;
                pub const m_flTimeParticleEffectSpawn: i64 = 0x1370;
                pub const m_nClientLastKnownDecoyShotTick: i64 = 0x134C;
            };
            pub const C_EnvParticleGlow = struct {
                pub const m_ColorTint: i64 = 0x1674;
                pub const m_flAlphaScale: i64 = 0x1668;
                pub const m_flRadiusScale: i64 = 0x166C;
                pub const m_flSelfIllumScale: i64 = 0x1670;
                pub const m_hTextureOverride: i64 = 0x1678;
            };
            pub const C_FootstepControl = struct {
                pub const m_source: i64 = 0x1180;
                pub const m_destination: i64 = 0x1188;
            };
            pub const C_Item_Healthshot = struct {

            };
            pub const C_LightSpotEntity = struct {

            };
            pub const C_LocalTempEntity = struct {
                pub const x: i64 = 0x1274;
                pub const y: i64 = 0x1278;
                pub const die: i64 = 0x126C;
                pub const flags: i64 = 0x1268;
                pub const hitSound: i64 = 0x1284;
                pub const priority: i64 = 0x1288;
                pub const fadeSpeed: i64 = 0x127C;
                pub const m_flFrame: i64 = 0x12C0;
                pub const tentOffset: i64 = 0x128C;
                pub const m_vecNormal: i64 = 0x12A8;
                pub const bounceFactor: i64 = 0x1280;
                pub const m_flFrameMax: i64 = 0x1270;
                pub const m_flFrameRate: i64 = 0x12BC;
                pub const m_flSpriteScale: i64 = 0x12B4;
                pub const m_nFlickerFrame: i64 = 0x12B8;
                pub const m_pszImpactEffect: i64 = 0x12C8;
                pub const tempent_renderamt: i64 = 0x12A4;
                pub const m_vecPrevAbsOrigin: i64 = 0x12F8;
                pub const m_pszParticleEffect: i64 = 0x12D0;
                pub const m_bParticleCollision: i64 = 0x12D8;
                pub const m_vecTempEntVelocity: i64 = 0x12EC;
                pub const m_iLastCollisionFrame: i64 = 0x12DC;
                pub const m_vLastCollisionOrigin: i64 = 0x12E0;
                pub const m_vecTempEntAngVelocity: i64 = 0x1298;
                pub const m_vecTempEntAcceleration: i64 = 0x1304;
            };
            pub const C_PointCameraVFOV = struct {
                pub const m_flVerticalFOV: i64 = 0x660;
            };
            pub const C_RetakeGameRules = struct {
                pub const m_iBombSite: i64 = 0x144;
                pub const m_nMatchSeed: i64 = 0x138;
                pub const m_hBombPlanter: i64 = 0x148;
                pub const m_bBlockersPresent: i64 = 0x13C;
                pub const m_bRoundInProgress: i64 = 0x13D;
                pub const m_iFirstSecondHalfRound: i64 = 0x140;
            };
            pub const C_SingleplayRules = struct {

            };
            pub const C_SkyCameraVolume = struct {
                pub const m_hTarget: i64 = 0x630;
                pub const m_vBoxMaxs: i64 = 0x624;
                pub const m_vBoxMins: i64 = 0x618;
                pub const m_nPriority: i64 = 0x634;
                pub const m_bIsEnabled: i64 = 0x638;
                pub const m_vBlurOrigin: i64 = 0x63C;
                pub const m_iszTargetName: i64 = 0x650;
                pub const m_bStartDisabled: i64 = 0x64A;
                pub const m_bSkyboxBlurEffect: i64 = 0x639;
                pub const m_bSkyboxReceivesWorldCsm: i64 = 0x648;
                pub const m_bWorldReceivesSkyboxCsm: i64 = 0x649;
            };
            pub const C_TriggerBuoyancy = struct {
                pub const m_BuoyancyHelper: i64 = 0x1180;
                pub const m_flFluidDensity: i64 = 0x1298;
            };
            pub const C_TriggerMultiple = struct {

            };
            pub const C_WeaponFiveSeven = struct {

            };
            pub const SequenceHistory_t = struct {
                pub const m_hSequence: i64 = 0x0;
                pub const m_nSeqLoopMode: i64 = 0xC;
                pub const m_flPlaybackRate: i64 = 0x10;
                pub const m_flSeqStartTime: i64 = 0x4;
                pub const m_flSeqFixedCycle: i64 = 0x8;
                pub const m_flCyclesPerSecond: i64 = 0x14;
            };
            pub const CCSCustomHudLayout = struct {
                pub const m_strLayout: i64 = 0x618;
                pub const m_bObservable: i64 = 0x620;
                pub const m_vecPanelIds: i64 = 0x798;
                pub const m_vecClassNames: i64 = 0x7B0;
                pub const m_globalLayoutState: i64 = 0x690;
                pub const m_vecPlayerLayoutStates: i64 = 0x628;
                pub const m_vecDialogVariableNames: i64 = 0x7C8;
            };
            pub const CCSWeaponBaseVData = struct {
                pub const m_nPrice: i64 = 0x70C;
                pub const m_szName: i64 = 0x720;
                pub const m_flRange: i64 = 0x830;
                pub const m_nDamage: i64 = 0x820;
                pub const m_GearSlot: i64 = 0x700;
                pub const m_flSpread: i64 = 0x750;
                pub const m_nZoomFOV1: i64 = 0x7F8;
                pub const m_nZoomFOV2: i64 = 0x7FC;
                pub const m_WeaponType: i64 = 0x520;
                pub const m_flMaxSpeed: i64 = 0x748;
                pub const m_nKillAward: i64 = 0x710;
                pub const m_bIsFullAuto: i64 = 0x72D;
                pub const m_bIsRevolver: i64 = 0x71E;
                pub const m_flCycleTime: i64 = 0x738;
                pub const m_flZoomTime0: i64 = 0x800;
                pub const m_flZoomTime1: i64 = 0x804;
                pub const m_flZoomTime2: i64 = 0x808;
                pub const m_nNumBullets: i64 = 0x730;
                pub const m_nRecoilSeed: i64 = 0x7D4;
                pub const m_nSpreadSeed: i64 = 0x7D8;
                pub const m_nZoomLevels: i64 = 0x7F4;
                pub const m_szAnimClass: i64 = 0x868;
                pub const m_vSmokeColor: i64 = 0x85C;
                pub const m_bMeleeWeapon: i64 = 0x71C;
                pub const m_flArmorRatio: i64 = 0x828;
                pub const m_bHasBurstMode: i64 = 0x71D;
                pub const m_eSilencerType: i64 = 0x728;
                pub const m_flPenetration: i64 = 0x82C;
                pub const m_flRecoilAngle: i64 = 0x790;
                pub const m_vecMuzzlePos0: i64 = 0x608;
                pub const m_vecMuzzlePos1: i64 = 0x614;
                pub const m_WeaponCategory: i64 = 0x524;
                pub const m_bShowCrosshair: i64 = 0x72C;
                pub const m_flIronSightFOV: i64 = 0x814;
                pub const m_szAnimSkeleton: i64 = 0x528;
                pub const m_flRangeModifier: i64 = 0x834;
                pub const m_flThrowVelocity: i64 = 0x858;
                pub const m_nBurstShotCount: i64 = 0x7CC;
                pub const m_GearSlotPosition: i64 = 0x704;
                pub const m_flDeployDuration: i64 = 0x7C4;
                pub const m_flInaccuracyFire: i64 = 0x780;
                pub const m_flInaccuracyJump: i64 = 0x768;
                pub const m_flInaccuracyLand: i64 = 0x770;
                pub const m_flInaccuracyMove: i64 = 0x788;
                pub const m_nTracerFrequency: i64 = 0x7B0;
                pub const m_szTracerParticle: i64 = 0x620;
                pub const m_bUnzoomsAfterShot: i64 = 0x7F0;
                pub const m_flInaccuracyStand: i64 = 0x760;
                pub const m_flRecoilMagnitude: i64 = 0x7A0;
                pub const m_DefaultLoadoutSlot: i64 = 0x708;
                pub const m_bAllowBurstHolster: i64 = 0x7D0;
                pub const m_flInaccuracyCrouch: i64 = 0x758;
                pub const m_flInaccuracyLadder: i64 = 0x778;
                pub const m_flInaccuracyReload: i64 = 0x7C0;
                pub const m_szUseRadioSubtitle: i64 = 0x7E8;
                pub const m_flRecoveryTimeStand: i64 = 0x844;
                pub const m_bReloadsSingleShells: i64 = 0x734;
                pub const m_flHeadshotMultiplier: i64 = 0x824;
                pub const m_flInaccuracyJumpApex: i64 = 0x7BC;
                pub const m_flIronSightLooseness: i64 = 0x81C;
                pub const m_flRecoveryTimeCrouch: i64 = 0x840;
                pub const m_flRecoilAngleVariance: i64 = 0x798;
                pub const m_bCannotShootUnderwater: i64 = 0x71F;
                pub const m_flInaccuracyPitchShift: i64 = 0x7E0;
                pub const m_flIronSightPullUpSpeed: i64 = 0x80C;
                pub const m_nPrimaryReserveAmmoMax: i64 = 0x714;
                pub const m_flAttackMovespeedFactor: i64 = 0x7DC;
                pub const m_flInaccuracyJumpInitial: i64 = 0x7B8;
                pub const m_flIronSightPivotForward: i64 = 0x818;
                pub const m_flIronSightPutDownSpeed: i64 = 0x810;
                pub const m_flTimeBetweenBurstShots: i64 = 0x744;
                pub const m_bHideViewModelWhenZoomed: i64 = 0x7F1;
                pub const m_flRecoveryTimeStandFinal: i64 = 0x84C;
                pub const m_nSecondaryReserveAmmoMax: i64 = 0x718;
                pub const m_flRecoilMagnitudeVariance: i64 = 0x7A8;
                pub const m_flRecoveryTimeCrouchFinal: i64 = 0x848;
                pub const m_flCycleTimeWhenInBurstMode: i64 = 0x740;
                pub const m_nRecoveryTransitionEndBullet: i64 = 0x854;
                pub const m_flFlinchVelocityModifierLarge: i64 = 0x838;
                pub const m_flFlinchVelocityModifierSmall: i64 = 0x83C;
                pub const m_flInaccuracyAltSoundThreshold: i64 = 0x7E4;
                pub const m_nRecoveryTransitionStartBullet: i64 = 0x850;
                pub const m_flDisallowAttackAfterReloadStartDuration: i64 = 0x7C8;
            };
            pub const CCollisionProperty = struct {
                pub const m_vecMaxs: i64 = 0x4C;
                pub const m_vecMins: i64 = 0x40;
                pub const m_nSolidType: i64 = 0x5B;
                pub const m_triggerBloat: i64 = 0x5C;
                pub const m_usSolidFlags: i64 = 0x5A;
                pub const m_nSurroundType: i64 = 0x5D;
                pub const m_CollisionGroup: i64 = 0x5E;
                pub const m_nEnablePhysics: i64 = 0x5F;
                pub const m_flCapsuleRadius: i64 = 0xAC;
                pub const m_vCapsuleCenter1: i64 = 0x94;
                pub const m_vCapsuleCenter2: i64 = 0xA0;
                pub const m_flBoundingRadius: i64 = 0x60;
                pub const m_collisionAttribute: i64 = 0x10;
                pub const m_vecSurroundingMaxs: i64 = 0x7C;
                pub const m_vecSurroundingMins: i64 = 0x88;
                pub const m_vecSpecifiedSurroundingMaxs: i64 = 0x70;
                pub const m_vecSpecifiedSurroundingMins: i64 = 0x64;
            };
            pub const CEconItemAttribute = struct {
                pub const m_flValue: i64 = 0x34;
                pub const m_bSetBonus: i64 = 0x40;
                pub const m_flInitialValue: i64 = 0x38;
                pub const m_nRefundableCurrency: i64 = 0x3C;
                pub const m_iAttributeDefinitionIndex: i64 = 0x30;
            };
            pub const CExplosionTypeData = struct {
                pub const m_DecalType: i64 = 0xF8;
                pub const m_SoundName: i64 = 0x0;
                pub const m_bHasForces: i64 = 0xF1;
                pub const m_bIsIncindiary: i64 = 0xF0;
                pub const m_ParticleEffect: i64 = 0x10;
            };
            pub const CFilterMassGreater = struct {
                pub const m_fFilterMass: i64 = 0x638;
            };
            pub const CFuncRetakeBarrier = struct {

            };
            pub const CHostageRescueZone = struct {

            };
            pub const CInterpolatedValue = struct {
                pub const m_flEndTime: i64 = 0x4;
                pub const m_flEndValue: i64 = 0xC;
                pub const m_flStartTime: i64 = 0x0;
                pub const m_nInterpType: i64 = 0x10;
                pub const m_flStartValue: i64 = 0x8;
            };
            pub const CPropDataComponent = struct {
                pub const m_flDmgModClub: i64 = 0x14;
                pub const m_flDmgModFire: i64 = 0x1C;
                pub const m_nInteractions: i64 = 0x30;
                pub const m_flDmgModBullet: i64 = 0x10;
                pub const m_iszBasePropData: i64 = 0x28;
                pub const m_flDmgModExplosive: i64 = 0x18;
                pub const m_bSpawnMotionDisabled: i64 = 0x34;
                pub const m_nMotionDisabledSpawnFlag: i64 = 0x3C;
                pub const m_iszPhysicsDamageTableName: i64 = 0x20;
                pub const m_nDisableTakePhysicsDamageSpawnFlag: i64 = 0x38;
            };
            pub const CPulseCell_Unknown = struct {
                pub const m_UnknownKeys: i64 = 0x48;
            };
            pub const CPulse_ResumePoint = struct {

            };
            pub const C_BasePlayerWeapon = struct {
                pub const m_iClip1: i64 = 0x1928;
                pub const m_iClip2: i64 = 0x192C;
                pub const m_pReserveAmmo: i64 = 0x1930;
                pub const m_nNextPrimaryAttackTick: i64 = 0x1918;
                pub const m_nNextSecondaryAttackTick: i64 = 0x1920;
                pub const m_flNextPrimaryAttackTickRatio: i64 = 0x191C;
                pub const m_flNextSecondaryAttackTickRatio: i64 = 0x1924;
            };
            pub const C_CS2HudModelAddon = struct {

            };
            pub const C_CSGameRulesProxy = struct {
                pub const m_pGameRules: i64 = 0x600;
            };
            pub const C_CSPlayerPawnBase = struct {
                pub const m_iPlayerState: i64 = 0x14E4;
                pub const m_bFlashBuildUp: i64 = 0x1508;
                pub const m_pPingServices: i64 = 0x14D8;
                pub const m_flLastSmokeAge: i64 = 0x1534;
                pub const m_flFlashBangTime: i64 = 0x14FC;
                pub const m_flFlashDuration: i64 = 0x1510;
                pub const m_flFlashMaxAlpha: i64 = 0x150C;
                pub const m_flClientDeathTime: i64 = 0x14F8;
                pub const m_fNextThinkPushAway: i64 = 0x151C;
                pub const m_bHasMovedSinceSpawn: i64 = 0x14E8;
                pub const m_flFlashOverlayAlpha: i64 = 0x1504;
                pub const m_hOriginalController: i64 = 0x1560;
                pub const m_previousPlayerState: i64 = 0x14E0;
                pub const m_flLastSpawnTimeIndex: i64 = 0x14EC;
                pub const m_iProgressBarDuration: i64 = 0x14F0;
                pub const m_flMusicRoundStartTime: i64 = 0x1528;
                pub const m_flFlashScreenshotAlpha: i64 = 0x1500;
                pub const m_flProgressBarStartTime: i64 = 0x14F4;
                pub const m_vLastSmokeOverlayColor: i64 = 0x1538;
                pub const m_bFlashDspHasBeenCleared: i64 = 0x1509;
                pub const m_flCurrentMusicStartTime: i64 = 0x1524;
                pub const m_flLastSmokeOverlayAlpha: i64 = 0x1530;
                pub const m_bDeferStartMusicOnWarmup: i64 = 0x152C;
                pub const m_nClientHealthFadeParityValue: i64 = 0x1518;
                pub const m_bFlashScreenshotHasBeenGrabbed: i64 = 0x150A;
                pub const m_flClientHealthFadeChangeTimestamp: i64 = 0x1514;
            };
            pub const C_CSPlayerResource = struct {
                pub const m_bHostageAlive: i64 = 0x600;
                pub const m_hostageRescueX: i64 = 0x660;
                pub const m_hostageRescueY: i64 = 0x670;
                pub const m_hostageRescueZ: i64 = 0x680;
                pub const m_bombsiteCenterA: i64 = 0x648;
                pub const m_bombsiteCenterB: i64 = 0x654;
                pub const m_iHostageEntityIDs: i64 = 0x618;
                pub const m_foundGoalPositions: i64 = 0x691;
                pub const m_bEndMatchNextMapAllVoted: i64 = 0x690;
                pub const m_isHostageFollowingSomeone: i64 = 0x60C;
            };
            pub const C_FireCrackerBlast = struct {

            };
            pub const C_LightOrthoEntity = struct {

            };
            pub const C_ModelPointEntity = struct {

            };
            pub const C_PathParticleRope = struct {
                pub const m_flSlack: i64 = 0x634;
                pub const m_flRadius: i64 = 0x638;
                pub const m_ColorTint: i64 = 0x63C;
                pub const m_bStartActive: i64 = 0x608;
                pub const m_iEffectIndex: i64 = 0x648;
                pub const m_nEffectState: i64 = 0x640;
                pub const m_iszEffectName: i64 = 0x610;
                pub const m_PathNodes_Name: i64 = 0x618;
                pub const m_PathNodes_Color: i64 = 0x698;
                pub const m_flParticleSpacing: i64 = 0x630;
                pub const m_PathNodes_Position: i64 = 0x650;
                pub const m_PathNodes_TangentIn: i64 = 0x668;
                pub const m_flMaxSimulationTime: i64 = 0x60C;
                pub const m_PathNodes_PinEnabled: i64 = 0x6B0;
                pub const m_PathNodes_TangentOut: i64 = 0x680;
                pub const m_PathNodes_RadiusScale: i64 = 0x6C8;
            };
            pub const C_PlayerSprayDecal = struct {
                pub const m_nEntity: i64 = 0x10DC;
                pub const m_nHitbox: i64 = 0x10E0;
                pub const m_nPlayer: i64 = 0x10D8;
                pub const m_nTintID: i64 = 0x10E8;
                pub const m_vecLeft: i64 = 0x10C0;
                pub const m_nVersion: i64 = 0x10EC;
                pub const m_rtGcTime: i64 = 0x10A4;
                pub const m_vecStart: i64 = 0x10B4;
                pub const m_nUniqueID: i64 = 0x1098;
                pub const m_unTraceID: i64 = 0x10A0;
                pub const m_vecEndPos: i64 = 0x10A8;
                pub const m_vecNormal: i64 = 0x10CC;
                pub const m_ubSignature: i64 = 0x10ED;
                pub const m_unAccountID: i64 = 0x109C;
                pub const m_flCreationTime: i64 = 0x10E4;
                pub const m_SprayRenderHelper: i64 = 0x1178;
            };
            pub const C_PlayerVisibility = struct {
                pub const m_bIsEnabled: i64 = 0x611;
                pub const m_flFadeTime: i64 = 0x60C;
                pub const m_bStartDisabled: i64 = 0x610;
                pub const m_flVisibilityStrength: i64 = 0x600;
                pub const m_flFogDistanceMultiplier: i64 = 0x604;
                pub const m_flFogMaxDensityMultiplier: i64 = 0x608;
            };
            pub const C_PointClientUIHUD = struct {
                pub const m_flDPI: i64 = 0x1254;
                pub const m_flWidth: i64 = 0x124C;
                pub const m_flHeight: i64 = 0x1250;
                pub const m_bIgnoreInput: i64 = 0x1248;
                pub const m_flDepthOffset: i64 = 0x125C;
                pub const m_unOrientation: i64 = 0x126C;
                pub const m_vecCSSClasses: i64 = 0x1278;
                pub const m_unOwnerContext: i64 = 0x1260;
                pub const m_unVerticalAlign: i64 = 0x1268;
                pub const m_bCheckCSSClasses: i64 = 0x10D0;
                pub const m_unHorizontalAlign: i64 = 0x1264;
                pub const m_flInteractDistance: i64 = 0x1258;
                pub const m_bAllowInteractionFromAllSceneWorlds: i64 = 0x1270;
            };
            pub const C_PropDoorRotating = struct {

            };
            pub const C_SoundEventEntity = struct {
                pub const m_hSource: i64 = 0x6B4;
                pub const m_bStopOnNew: i64 = 0x602;
                pub const m_bSaveRestore: i64 = 0x603;
                pub const m_iszSoundName: i64 = 0x698;
                pub const m_bStartOnSpawn: i64 = 0x600;
                pub const m_onGUIDChanged: i64 = 0x620;
                pub const m_bToLocalPlayer: i64 = 0x601;
                pub const m_bClientSideOnly: i64 = 0x0;
                pub const m_bSavedIsPlaying: i64 = 0x604;
                pub const m_onSoundFinished: i64 = 0x650;
                pub const m_iszAttachmentName: i64 = 0x618;
                pub const m_flClientCullRadius: i64 = 0x668;
                pub const m_flSavedElapsedTime: i64 = 0x608;
                pub const m_iszSourceEntityName: i64 = 0x610;
                pub const m_nEntityIndexSelection: i64 = 0x6B8;
            };
            pub const C_WorldModelGloves = struct {

            };
            pub const inv_image_camera_t = struct {
                pub const zfar: i64 = 0x18;
                pub const angle: i64 = 0x0;
                pub const fov_h: i64 = 0xC;
                pub const fov_v: i64 = 0x10;
                pub const znear: i64 = 0x14;
                pub const target: i64 = 0x1C;
                pub const target_nudge: i64 = 0x28;
                pub const orbit_distance: i64 = 0x34;
            };
            pub const shard_model_desc_t = struct {
                pub const m_solid: i64 = 0x20;
                pub const m_nModelID: i64 = 0x8;
                pub const m_bHasParent: i64 = 0x74;
                pub const m_vecPanelSize: i64 = 0x24;
                pub const m_bParentFrozen: i64 = 0x75;
                pub const m_hMaterialBase: i64 = 0x10;
                pub const m_vecPanelVertices: i64 = 0x40;
                pub const m_vecStressPositionA: i64 = 0x2C;
                pub const m_vecStressPositionB: i64 = 0x34;
                pub const m_flGlassHalfThickness: i64 = 0x70;
                pub const m_vInitialPanelVertices: i64 = 0x58;
                pub const m_SurfacePropStringToken: i64 = 0x78;
                pub const m_hMaterialDamageOverlay: i64 = 0x18;
            };
            pub const ActiveModelConfig_t = struct {
                pub const m_Name: i64 = 0x38;
                pub const m_Handle: i64 = 0x30;
                pub const m_AssociatedEntities: i64 = 0x40;
                pub const m_AssociatedEntityNames: i64 = 0x58;
            };
            pub const CBodyComponentPoint = struct {
                pub const m_sceneNode: i64 = 0x80;
            };
            pub const CCSPlayerController = struct {
                pub const m_iMVPs: i64 = 0x970;
                pub const m_iPing: i64 = 0x838;
                pub const m_iScore: i64 = 0x954;
                pub const m_szClan: i64 = 0x868;
                pub const m_eMvpReason: i64 = 0x964;
                pub const m_iPawnArmor: i64 = 0x93C;
                pub const m_nFirstKill: i64 = 0x960;
                pub const m_nKillCount: i64 = 0x961;
                pub const m_bMvpNoMusic: i64 = 0x962;
                pub const m_hPlayerPawn: i64 = 0x92C;
                pub const m_iDraftIndex: i64 = 0x8F8;
                pub const m_iMusicKitID: i64 = 0x968;
                pub const m_iPawnHealth: i64 = 0x938;
                pub const m_bPawnIsAlive: i64 = 0x934;
                pub const m_hObserverPawn: i64 = 0x930;
                pub const m_iCoachingTeam: i64 = 0x888;
                pub const m_iMusicKitMVPs: i64 = 0x96C;
                pub const m_unClanId32bit: i64 = 0x870;
                pub const m_bPawnHasHelmet: i64 = 0x941;
                pub const m_bScoreReported: i64 = 0x90D;
                pub const m_bCannotBeKicked: i64 = 0x908;
                pub const m_bControllingBot: i64 = 0x920;
                pub const m_bPawnHasDefuser: i64 = 0x940;
                pub const m_flForceTeamTime: i64 = 0x854;
                pub const m_iPendingTeamNum: i64 = 0x850;
                pub const m_pDamageServices: i64 = 0x830;
                pub const m_recentKillQueue: i64 = 0x958;
                pub const m_unActiveQuestId: i64 = 0x8BC;
                pub const m_iCompetitiveWins: i64 = 0x8A4;
                pub const m_iPawnLifetimeEnd: i64 = 0x948;
                pub const m_nPlayerDominated: i64 = 0x890;
                pub const m_szCrosshairCodes: i64 = 0x848;
                pub const m_bEverPlayedOnTeam: i64 = 0x85C;
                pub const m_sSanitizedClanTag: i64 = 0x880;
                pub const m_bIsPlayerNameDirty: i64 = 0x974;
                pub const m_iCompTeammateColor: i64 = 0x858;
                pub const m_iPawnBotDifficulty: i64 = 0x94C;
                pub const m_iPawnLifetimeStart: i64 = 0x944;
                pub const m_nDisconnectionTick: i64 = 0x910;
                pub const m_pInventoryServices: i64 = 0x820;
                pub const m_bEverFullyConnected: i64 = 0x909;
                pub const m_iCompetitiveRanking: i64 = 0x8A0;
                pub const m_nPlayerDominatingMe: i64 = 0x898;
                pub const m_iCompetitiveRankType: i64 = 0x8A8;
                pub const m_nEndMatchNextMapVote: i64 = 0x8B8;
                pub const m_nQuestProgressReason: i64 = 0x8C4;
                pub const m_pInGameMoneyServices: i64 = 0x818;
                pub const m_sSanitizedPlayerName: i64 = 0x878;
                pub const m_rtActiveMissionPeriod: i64 = 0x8C0;
                pub const m_bCanControlObservedBot: i64 = 0x928;
                pub const m_nPawnCharacterDefIndex: i64 = 0x942;
                pub const m_unPlayerTvControlFlags: i64 = 0x8C8;
                pub const m_bAbandonAllowsSurrender: i64 = 0x90A;
                pub const m_pActionTrackingServices: i64 = 0x828;
                pub const m_uiAbandonRecordedReason: i64 = 0x900;
                pub const m_nBotsControlledThisRound: i64 = 0x924;
                pub const m_uiCommunicationMuteFlags: i64 = 0x840;
                pub const m_bHasCommunicationAbuseMute: i64 = 0x83C;
                pub const m_bHasControlledBotThisRound: i64 = 0x921;
                pub const m_eNetworkDisconnectionReason: i64 = 0x904;
                pub const m_flPreviousForceJoinTeamTime: i64 = 0x860;
                pub const m_bFireBulletsSeedSynchronized: i64 = 0x97C;
                pub const m_bAbandonOffersInstantSurrender: i64 = 0x90B;
                pub const m_bDisconnection1MinWarningPrinted: i64 = 0x90C;
                pub const m_hOriginalControllerOfCurrentPawn: i64 = 0x950;
                pub const m_iCompetitiveRankingPredicted_Tie: i64 = 0x8B4;
                pub const m_iCompetitiveRankingPredicted_Win: i64 = 0x8AC;
                pub const m_iCompetitiveRankingPredicted_Loss: i64 = 0x8B0;
                pub const m_msQueuedModeDisconnectionTimestamp: i64 = 0x8FC;
                pub const m_bHasBeenControlledByPlayerThisRound: i64 = 0x922;
            };
            pub const CCSPlayerLegacyJump = struct {
                pub const m_bOldJumpPressed: i64 = 0x10;
                pub const m_flJumpPressedTime: i64 = 0x14;
            };
            pub const CCSPlayerModernJump = struct {
                pub const m_nLastLandedTick: i64 = 0x20;
                pub const m_flLastLandedFrac: i64 = 0x24;
                pub const m_flLastLandedVelocityX: i64 = 0x28;
                pub const m_flLastLandedVelocityY: i64 = 0x2C;
                pub const m_flLastLandedVelocityZ: i64 = 0x30;
                pub const m_nLastActualJumpPressTick: i64 = 0x10;
                pub const m_nLastUsableJumpPressTick: i64 = 0x18;
                pub const m_flLastActualJumpPressFrac: i64 = 0x14;
                pub const m_flLastUsableJumpPressFrac: i64 = 0x1C;
            };
            pub const CEnvSoundscapeProxy = struct {
                pub const m_MainSoundscapeName: i64 = 0x690;
            };
            pub const CFilterAttributeInt = struct {
                pub const m_sAttributeName: i64 = 0x638;
            };
            pub const CInfoParticleTarget = struct {

            };
            pub const CInventoryImageData = struct {
                pub const name: i64 = 0x8;
                pub const m_nNodeType: i64 = 0x0;
                pub const inventory_image_data: i64 = 0x10;
            };
            pub const CPathQueryComponent = struct {

            };
            pub const CPlayer_UseServices = struct {

            };
            pub const CPointChildModifier = struct {
                pub const m_bOrphanInsteadOfDeletingChildrenOnRemove: i64 = 0x600;
            };
            pub const CPrecipitationVData = struct {
                pub const m_nRTEnvCP: i64 = 0x2D4;
                pub const m_szModifier: i64 = 0x2E0;
                pub const m_nAttachType: i64 = 0x2CC;
                pub const m_snapshotFilter: i64 = 0x2EC;
                pub const m_flInnerDistance: i64 = 0x2C8;
                pub const m_nRTEnvCPComponent: i64 = 0x2D8;
                pub const m_bBatchSameVolumeType: i64 = 0x2D0;
                pub const m_nUseSnapshotFromSurfaceGraph: i64 = 0x2E8;
                pub const m_szParticlePrecipitationEffect: i64 = 0x28;
                pub const m_szParticlePrecipitationPostEffect: i64 = 0x1E8;
                pub const m_szParticlePrecipitationPuddleEffect: i64 = 0x108;
            };
            pub const CPulseCell_BaseFlow = struct {

            };
            pub const CPulseCell_BaseLerp = struct {
                pub const m_WakeResume: i64 = 0xD8;
            };
            pub const CPulseCell_Timeline = struct {
                pub const m_OnFinished: i64 = 0xF8;
                pub const m_TimelineEvents: i64 = 0xD8;
                pub const m_bWaitForChildOutflows: i64 = 0xF0;
            };
            pub const C_CS2HudModelWeapon = struct {

            };
            pub const C_CSGO_PreviewModel = struct {
                pub const m_defaultAnim: i64 = 0x1268;
                pub const m_flInitialModelScale: i64 = 0x1274;
                pub const m_sInitialWeaponState: i64 = 0x1278;
                pub const m_nDefaultAnimLoopMode: i64 = 0x1270;
            };
            pub const C_CSMinimapBoundary = struct {

            };
            pub const C_EnvWindClientside = struct {
                pub const m_EnvWindShared: i64 = 0x600;
            };
            pub const C_IncendiaryGrenade = struct {

            };
            pub const C_InfoVisibilityBox = struct {
                pub const m_nMode: i64 = 0x604;
                pub const m_bEnabled: i64 = 0x614;
                pub const m_vBoxSize: i64 = 0x608;
            };
            pub const C_MolotovProjectile = struct {
                pub const m_bIsIncGrenade: i64 = 0x1348;
            };
            pub const C_TriggerLerpObject = struct {

            };
            pub const C_WeaponUSPSilencer = struct {

            };
            pub const C_fogplayerparams_t = struct {
                pub const m_hCtrl: i64 = 0x8;
                pub const m_NewColor: i64 = 0x28;
                pub const m_OldColor: i64 = 0x10;
                pub const m_flNewEnd: i64 = 0x30;
                pub const m_flOldEnd: i64 = 0x18;
                pub const m_flNewFarZ: i64 = 0x3C;
                pub const m_flOldFarZ: i64 = 0x24;
                pub const m_flNewStart: i64 = 0x2C;
                pub const m_flOldStart: i64 = 0x14;
                pub const m_flNewMaxDensity: i64 = 0x34;
                pub const m_flOldMaxDensity: i64 = 0x1C;
                pub const m_flTransitionTime: i64 = 0xC;
                pub const m_flNewHDRColorScale: i64 = 0x38;
                pub const m_flOldHDRColorScale: i64 = 0x20;
            };
            pub const CompositeMaterial_t = struct {
                pub const m_FinalKVs: i64 = 0x58;
                pub const m_TargetKVs: i64 = 0x8;
                pub const m_PreGenerationKVs: i64 = 0x18;
                pub const m_vecGeneratedTextures: i64 = 0x80;
            };
            pub const CCSObservableElement = struct {
                pub const m_nTeamFilter: i64 = 0x628;
                pub const m_hObservableModelEntity: i64 = 0x620;
                pub const m_hObservableModelEntity2: i64 = 0x624;
                pub const m_iszObservableModelEntity: i64 = 0x618;
            };
            pub const CClientAlphaProperty = struct {
                pub const m_nAlpha: i64 = 0x17;
                pub const m_nRenderFX: i64 = 0x0;
                pub const m_flFadeScale: i64 = 0x18;
                pub const m_nRenderMode: i64 = 0x0;
                pub const m_nDistFadeEnd: i64 = 0x12;
                pub const m_nDesyncOffset: i64 = 0x0;
                pub const m_bAlphaOverride: i64 = 0x0;
                pub const m_nDistFadeStart: i64 = 0x10;
                pub const m_flRenderFxDuration: i64 = 0x20;
                pub const m_flRenderFxStartTime: i64 = 0x1C;
                pub const m_bShadowAlphaOverride: i64 = 0x0;
            };
            pub const CGameSceneNodeHandle = struct {
                pub const m_name: i64 = 0xC;
                pub const m_hOwner: i64 = 0x8;
            };
            pub const CPlayer_ItemServices = struct {

            };
            pub const CPulseCell_BaseState = struct {

            };
            pub const CPulseCell_BaseValue = struct {

            };
            pub const CPulseGameBlackboard = struct {
                pub const m_strGraphName: i64 = 0x608;
                pub const m_strStateBlob: i64 = 0x610;
            };
            pub const CPulse_InvokeBinding = struct {
                pub const m_FuncName: i64 = 0x30;
                pub const m_nSrcChunk: i64 = 0x44;
                pub const m_nCellIndex: i64 = 0x40;
                pub const m_RegisterMap: i64 = 0x0;
                pub const m_nSrcInstruction: i64 = 0x48;
            };
            pub const C_AttributeContainer = struct {
                pub const m_Item: i64 = 0x50;
                pub const m_ullRegisteredAsItemID: i64 = 0x608;
                pub const m_iExternalItemProviderRegisteredToken: i64 = 0x600;
            };
            pub const C_BaseClientUIEntity = struct {
                pub const m_PanelID: i64 = 0x10B8;
                pub const m_bEnabled: i64 = 0x10A0;
                pub const m_DialogXMLName: i64 = 0x10A8;
                pub const m_PanelClassName: i64 = 0x10B0;
            };
            pub const C_CSGO_PreviewPlayer = struct {
                pub const m_flInitialModelScale: i64 = 0x3728;
                pub const m_animgraphCharacterModeString: i64 = 0x3720;
            };
            pub const C_InfoLadderDismount = struct {

            };
            pub const C_PhysPropClientside = struct {
                pub const m_fDeathTime: i64 = 0x13E4;
                pub const m_nDamageType: i64 = 0x1400;
                pub const m_flTouchDelta: i64 = 0x13E0;
                pub const m_vecDamagePosition: i64 = 0x13E8;
                pub const m_vecDamageDirection: i64 = 0x13F4;
            };
            pub const C_PointValueRemapper = struct {
                pub const m_bEngaged: i64 = 0x660;
                pub const m_bDisabled: i64 = 0x600;
                pub const m_nInputType: i64 = 0x604;
                pub const m_flSnapValue: i64 = 0x64C;
                pub const m_nOutputType: i64 = 0x620;
                pub const m_bDisabledOld: i64 = 0x601;
                pub const m_bFirstUpdate: i64 = 0x661;
                pub const m_nHapticsType: i64 = 0x640;
                pub const m_nRatchetType: i64 = 0x654;
                pub const m_flInputOffset: i64 = 0x65C;
                pub const m_hRemapLineEnd: i64 = 0x60C;
                pub const m_nMomentumType: i64 = 0x644;
                pub const m_bRequiresUseKey: i64 = 0x61C;
                pub const m_bUpdateOnClient: i64 = 0x602;
                pub const m_flPreviousValue: i64 = 0x664;
                pub const m_flRatchetOffset: i64 = 0x658;
                pub const m_hOutputEntities: i64 = 0x628;
                pub const m_hRemapLineStart: i64 = 0x608;
                pub const m_flEngageDistance: i64 = 0x618;
                pub const m_flCurrentMomentum: i64 = 0x650;
                pub const m_flMomentumModifier: i64 = 0x648;
                pub const m_flDisengageDistance: i64 = 0x614;
                pub const m_vecPreviousTestPoint: i64 = 0x66C;
                pub const m_flMaximumChangePerSecond: i64 = 0x610;
                pub const m_flPreviousUpdateTickTime: i64 = 0x668;
            };
            pub const C_TonemapController2 = struct {
                pub const m_flAutoExposureMax: i64 = 0x604;
                pub const m_flAutoExposureMin: i64 = 0x600;
                pub const m_flTonemapEVSmoothingRange: i64 = 0x610;
                pub const m_flExposureAdaptationSpeedUp: i64 = 0x608;
                pub const m_flExposureAdaptationSpeedDown: i64 = 0x60C;
            };
            pub const C_WeaponM4A1Silencer = struct {

            };
            pub const EngineCountdownTimer = struct {
                pub const m_duration: i64 = 0x8;
                pub const m_timescale: i64 = 0x10;
                pub const m_timestamp: i64 = 0xC;
            };
            pub const EntitySpottedState_t = struct {
                pub const m_bSpotted: i64 = 0x8;
                pub const m_bSpottedByMask: i64 = 0xC;
            };
            pub const IClientAlphaProperty = struct {

            };
            pub const PhysicsRagdollPose_t = struct {
                pub const m_hOwner: i64 = 0x20;
                pub const m_RelativeTransforms: i64 = 0x8;
                pub const m_bSetFromDebugHistory: i64 = 0x24;
            };
            pub const CBasePlayerController = struct {
                pub const m_hPawn: i64 = 0x6BC;
                pub const m_bIsHLTV: i64 = 0x6F0;
                pub const m_steamID: i64 = 0x788;
                pub const m_nTickBase: i64 = 0x6B8;
                pub const m_iConnected: i64 = 0x6F4;
                pub const m_hSplitOwner: i64 = 0x6D0;
                pub const m_iDesiredFOV: i64 = 0x794;
                pub const m_iszPlayerName: i64 = 0x6FC;
                pub const m_CommandContext: i64 = 0x608;
                pub const m_bNoClipEnabled: i64 = 0x791;
                pub const m_hPredictedPawn: i64 = 0x6C4;
                pub const m_iMostConnected: i64 = 0x6F8;
                pub const m_nSplitScreenSlot: i64 = 0x6CC;
                pub const m_bKnownTeamMismatch: i64 = 0x6C0;
                pub const m_hSplitScreenPlayers: i64 = 0x6D8;
                pub const m_bIsLocalPlayerController: i64 = 0x790;
                pub const m_nInButtonsWhichAreToggles: i64 = 0x6B0;
            };
            pub const CCSCustomPlayerCamera = struct {
                pub const m_hPawn: i64 = 0x600;
                pub const m_bFollowEyes: i64 = 0x60C;
                pub const m_nCameraMode: i64 = 0x604;
                pub const m_hFollowEntity: i64 = 0x608;
                pub const m_vecCameraOffset: i64 = 0x61C;
                pub const m_vecFollowOffset: i64 = 0x610;
                pub const m_bClipCameraOffset: i64 = 0x628;
                pub const m_flCameraOffsetReturnStrength: i64 = 0x62C;
            };
            pub const CCSGameModeRules_Noop = struct {

            };
            pub const CCSPlayer_BuyServices = struct {
                pub const m_vecSellbackPurchaseEntries: i64 = 0x48;
            };
            pub const CCSPlayer_UseServices = struct {

            };
            pub const CPathWithDynamicNodes = struct {
                pub const m_vecPathNodes: i64 = 0x710;
                pub const m_eDesiredDirection: i64 = 0x750;
                pub const m_bIgnoreParentRotation: i64 = 0x754;
                pub const m_xInitialPathWorldToLocal: i64 = 0x730;
            };
            pub const CPlayer_WaterServices = struct {

            };
            pub const CPulseCell_LimitCount = struct {
                pub const m_nLimitCount: i64 = 0x48;
            };
            pub const C_BaseCombatCharacter = struct {
                pub const m_hMyWearables: i64 = 0x1268;
                pub const m_flWaterWorldZ: i64 = 0x1288;
                pub const m_nWaterWakeMode: i64 = 0x1284;
                pub const m_leftFootAttachment: i64 = 0x1280;
                pub const m_rightFootAttachment: i64 = 0x1281;
                pub const m_flWaterNextTraceTime: i64 = 0x128C;
            };
            pub const C_CS2WeaponModuleBase = struct {

            };
            pub const C_CSWeaponBaseShotgun = struct {

            };
            pub const C_EnvDetailController = struct {
                pub const m_flFadeEndDist: i64 = 0x604;
                pub const m_flFadeStartDist: i64 = 0x600;
            };
            pub const C_EnvLightProbeVolume = struct {
                pub const m_Entity_bEnabled: i64 = 0x719;
                pub const m_Entity_vBoxMaxs: i64 = 0x6DC;
                pub const m_Entity_vBoxMins: i64 = 0x6D0;
                pub const m_Entity_bMoveable: i64 = 0x6E8;
                pub const m_Entity_nPriority: i64 = 0x6F0;
                pub const m_Entity_nHandshake: i64 = 0x6EC;
                pub const m_Entity_bStartDisabled: i64 = 0x6F4;
                pub const m_Entity_nLightProbeSizeX: i64 = 0x6F8;
                pub const m_Entity_nLightProbeSizeY: i64 = 0x6FC;
                pub const m_Entity_nLightProbeSizeZ: i64 = 0x700;
                pub const m_Entity_nLightProbeAtlasX: i64 = 0x704;
                pub const m_Entity_nLightProbeAtlasY: i64 = 0x708;
                pub const m_Entity_nLightProbeAtlasZ: i64 = 0x70C;
                pub const m_Entity_hLightProbeTexture_SDF: i64 = 0x6A0;
                pub const m_Entity_hLightProbeTexture_SH2_DC: i64 = 0x6A8;
                pub const m_Entity_hLightProbeTexture_SH2_L1: i64 = 0x6B0;
                pub const m_Entity_hLightProbeTexture_AmbientCube: i64 = 0x698;
                pub const m_Entity_hLightProbeDirectLightIndicesTexture: i64 = 0x6B8;
                pub const m_Entity_hLightProbeDirectLightScalarsTexture: i64 = 0x6C0;
                pub const m_Entity_hLightProbeDirectLightShadowsTexture: i64 = 0x6C8;
            };
            pub const C_FlashbangProjectile = struct {

            };
            pub const C_HEGrenadeProjectile = struct {

            };
            pub const C_IronSightController = struct {
                pub const m_angViewLast: i64 = 0x90;
                pub const m_flSpeedRatio: i64 = 0xA8;
                pub const m_vecDotCoords: i64 = 0x9C;
                pub const m_angDeltaAverage: i64 = 0x30;
                pub const m_flIronSightAmount: i64 = 0x14;
                pub const m_bIronSightAvailable: i64 = 0x10;
                pub const m_flIronSightAmountBiased: i64 = 0x1C;
                pub const m_flIronSightAmountGained: i64 = 0x18;
                pub const m_flInterpolationLastUpdated: i64 = 0x2C;
                pub const m_flIronSightAmount_Interpolated: i64 = 0x20;
                pub const m_flIronSightAmountBiased_Interpolated: i64 = 0x28;
                pub const m_flIronSightAmountGained_Interpolated: i64 = 0x24;
                pub const m_flFiringInaccuracyExtraWidthMultiplier: i64 = 0xA4;
            };
            pub const C_PointClientUIDialog = struct {
                pub const m_hActivator: i64 = 0x10C8;
                pub const m_bStartEnabled: i64 = 0x10CC;
            };
            pub const C_PointCommentaryNode = struct {
                pub const m_bActive: i64 = 0x1280;
                pub const m_iszTitle: i64 = 0x1298;
                pub const m_flEndTime: i64 = 0x1284;
                pub const m_bWasActive: i64 = 0x1281;
                pub const m_bListenedTo: i64 = 0x12B0;
                pub const m_flStartTime: i64 = 0x1288;
                pub const m_iNodeNumber: i64 = 0x12A8;
                pub const m_iszSpeakers: i64 = 0x12A0;
                pub const m_hViewPosition: i64 = 0x12C0;
                pub const m_sndCommentary: i64 = 0x12B8;
                pub const m_iNodeNumberMax: i64 = 0x12AC;
                pub const m_iszCommentaryFile: i64 = 0x1290;
                pub const m_bRestartAfterRestore: i64 = 0x12C4;
                pub const m_flStartTimeInCommentary: i64 = 0x128C;
            };
            pub const C_PointDeathcamBounds = struct {
                pub const m_vBoxMaxs: i64 = 0x60C;
                pub const m_vBoxMins: i64 = 0x600;
                pub const m_flLerpDistance: i64 = 0x618;
            };
            pub const C_RagdollPropAttached = struct {
                pub const m_vecOffset: i64 = 0x1310;
                pub const m_bHasParent: i64 = 0x1320;
                pub const m_parentTime: i64 = 0x131C;
                pub const m_boneIndexAttached: i64 = 0x12F0;
                pub const m_attachmentPointBoneSpace: i64 = 0x12F8;
                pub const m_ragdollAttachedObjectIndex: i64 = 0x12F4;
                pub const m_attachmentPointRagdollSpace: i64 = 0x1304;
            };
            pub const C_SoundAreaEntityBase = struct {
                pub const m_vPos: i64 = 0x618;
                pub const m_bDisabled: i64 = 0x600;
                pub const m_bWasEnabled: i64 = 0x608;
                pub const m_iszSoundAreaType: i64 = 0x610;
            };
            pub const C_SoundEventBoxEntity = struct {
                pub const m_vecBoxHelpersNetworked: i64 = 0x6C0;
            };
            pub const C_SoundEventBoxHelper = struct {
                pub const m_vMaxs: i64 = 0x60C;
                pub const m_vMins: i64 = 0x600;
            };
            pub const C_SoundEventOBBEntity = struct {
                pub const m_vMaxs: i64 = 0x6CC;
                pub const m_vMins: i64 = 0x6C0;
            };
            pub const WeaponPurchaseCount_t = struct {
                pub const m_nCount: i64 = 0x32;
                pub const m_nItemDefIndex: i64 = 0x30;
            };
            pub const inv_image_light_sun_t = struct {
                pub const angle: i64 = 0xC;
                pub const color: i64 = 0x0;
                pub const brightness: i64 = 0x18;
            };
            pub const CBasePlayerWeaponVData = struct {
                pub const m_iSlot: i64 = 0x4EC;
                pub const m_iFlags: i64 = 0x4C7;
                pub const m_iWeight: i64 = 0x4C8;
                pub const m_iMaxClip1: i64 = 0x4D0;
                pub const m_iMaxClip2: i64 = 0x4D4;
                pub const m_iPosition: i64 = 0x4F0;
                pub const m_flDropSpeed: i64 = 0x4E8;
                pub const m_aShootSounds: i64 = 0x4F8;
                pub const m_szWorldModel: i64 = 0x28;
                pub const m_bAutoSwitchTo: i64 = 0x4CC;
                pub const m_iDefaultClip1: i64 = 0x4D8;
                pub const m_iDefaultClip2: i64 = 0x4DC;
                pub const m_iRumbleEffect: i64 = 0x4E4;
                pub const m_bAllowFlipping: i64 = 0x2C9;
                pub const m_bAutoSwitchFrom: i64 = 0x4CD;
                pub const m_bKeepLoadedAmmo: i64 = 0x4E2;
                pub const m_bLinkedCooldowns: i64 = 0x4C6;
                pub const m_nPrimaryAmmoType: i64 = 0x4CE;
                pub const m_bBuiltRightHanded: i64 = 0x2C8;
                pub const m_sMuzzleAttachment: i64 = 0x2D0;
                pub const m_bTreatAsSingleClip: i64 = 0x4E1;
                pub const m_nSecondaryAmmoType: i64 = 0x4CF;
                pub const m_bReserveAmmoAsClips: i64 = 0x4E0;
                pub const m_bGenerateMuzzleLight: i64 = 0x4C4;
                pub const m_flMuzzleSmokeTimeout: i64 = 0x4BC;
                pub const m_bShouldAnimateInWorld: i64 = 0x4C5;
                pub const m_szBarrelSmokeParticle: i64 = 0x3D8;
                pub const m_szMuzzleFlashParticle: i64 = 0x2F0;
                pub const m_szWorldModelAg2Override: i64 = 0x108;
                pub const m_sToolsOnlyOwnerModelName: i64 = 0x1E8;
                pub const m_nMuzzleSmokeShotThreshold: i64 = 0x4B8;
                pub const m_flMuzzleSmokeDecrementRate: i64 = 0x4C0;
                pub const m_szMuzzleFlashParticleConfig: i64 = 0x3D0;
            };
            pub const CCSPlayer_GlowServices = struct {

            };
            pub const CCSPlayer_ItemServices = struct {
                pub const m_bHasHelmet: i64 = 0x49;
                pub const m_bHasDefuser: i64 = 0x48;
            };
            pub const CCSPlayer_PingServices = struct {
                pub const m_hPlayerPing: i64 = 0x48;
            };
            pub const CHostageRescueZoneShim = struct {

            };
            pub const CInfoDynamicShadowHint = struct {
                pub const m_hLight: i64 = 0x610;
                pub const m_flRange: i64 = 0x604;
                pub const m_bDisabled: i64 = 0x600;
                pub const m_nImportance: i64 = 0x608;
                pub const m_nLightChoice: i64 = 0x60C;
            };
            pub const CPlayer_CameraServices = struct {
                pub const m_audio: i64 = 0xB0;
                pub const m_PlayerFog: i64 = 0x60;
                pub const m_CurrentFog: i64 = 0x148;
                pub const m_hViewEntity: i64 = 0xA4;
                pub const m_flOldPlayerZ: i64 = 0x140;
                pub const m_fOverrideFogEnd: i64 = 0x1EC;
                pub const m_OverrideFogColor: i64 = 0x1BC;
                pub const m_angDemoViewAngles: i64 = 0x208;
                pub const m_bOverrideFogColor: i64 = 0x1B4;
                pub const m_fOverrideFogStart: i64 = 0x1D8;
                pub const m_hOldFogController: i64 = 0x1B0;
                pub const m_hTonemapController: i64 = 0xA8;
                pub const m_vecCsViewPunchAngle: i64 = 0x48;
                pub const m_bOverrideFogStartEnd: i64 = 0x1D0;
                pub const m_hColorCorrectionCtrl: i64 = 0xA0;
                pub const m_PostProcessingVolumes: i64 = 0x128;
                pub const m_nCsViewPunchAngleTick: i64 = 0x54;
                pub const m_flOldPlayerViewOffsetZ: i64 = 0x144;
                pub const m_flCsViewPunchAngleTickRatio: i64 = 0x58;
                pub const m_hActivePostProcessingVolume: i64 = 0x200;
            };
            pub const CPlayer_WeaponServices = struct {
                pub const m_iAmmo: i64 = 0x68;
                pub const m_hMyWeapons: i64 = 0x48;
                pub const m_hLastWeapon: i64 = 0x64;
                pub const m_hActiveWeapon: i64 = 0x60;
            };
            pub const CPulseCell_CursorQueue = struct {
                pub const m_nCursorsAllowedToRunParallel: i64 = 0x128;
            };
            pub const CPulseCell_FireCursors = struct {
                pub const m_Outflows: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0xF8;
                pub const m_bWaitForChildOutflows: i64 = 0xF0;
            };
            pub const CPulseCell_Inflow_Wait = struct {
                pub const m_WakeResume: i64 = 0xD8;
            };
            pub const CPulseCell_RaceCursors = struct {
                pub const m_Outflows: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0xF0;
            };
            pub const CPulseCell_Value_Curve = struct {
                pub const m_Curve: i64 = 0x48;
            };
            pub const CServerOnlyModelEntity = struct {

            };
            pub const C_HostageCarriableProp = struct {

            };
            pub const C_LateUpdatedAnimating = struct {

            };
            pub const C_PostProcessingVolume = struct {
                pub const m_bMaster: i64 = 0x11BC;
                pub const m_flMaxExposure: i64 = 0x11A8;
                pub const m_flMinExposure: i64 = 0x11A4;
                pub const m_hPostSettings: i64 = 0x1190;
                pub const m_flFadeDuration: i64 = 0x1198;
                pub const m_bExposureControl: i64 = 0x11BD;
                pub const m_flMaxLogExposure: i64 = 0x11A0;
                pub const m_flMinLogExposure: i64 = 0x119C;
                pub const m_flExposureFadeSpeedUp: i64 = 0x11B0;
                pub const m_flExposureCompensation: i64 = 0x11AC;
                pub const m_flExposureFadeSpeedDown: i64 = 0x11B4;
                pub const m_flTonemapEVSmoothingRange: i64 = 0x11B8;
            };
            pub const C_PrecipitationBlocker = struct {

            };
            pub const C_SoundEventAABBEntity = struct {
                pub const m_vMaxs: i64 = 0x6CC;
                pub const m_vMins: i64 = 0x6C0;
            };
            pub const C_SoundEventConeEntity = struct {
                pub const m_flAttenMax: i64 = 0x6CC;
                pub const m_flAttenMin: i64 = 0x6C8;
                pub const m_flEmitterAngle: i64 = 0x6C0;
                pub const m_flSweetSpotAngle: i64 = 0x6C4;
                pub const m_iszParameterName: i64 = 0x6D0;
            };
            pub const inv_image_clearcolor_t = struct {
                pub const color: i64 = 0x0;
            };
            pub const inv_image_light_barn_t = struct {
                pub const angle: i64 = 0xC;
                pub const color: i64 = 0x0;
                pub const brightness: i64 = 0x18;
                pub const orbit_distance: i64 = 0x1C;
            };
            pub const inv_image_light_fill_t = struct {
                pub const angle: i64 = 0xC;
                pub const color: i64 = 0x0;
                pub const brightness: i64 = 0x18;
            };
            pub const CBasePulseGraphInstance = struct {

            };
            pub const CCS2PawnGraphController = struct {
                pub const m_moveType: i64 = 0x2F0;
                pub const m_airAction: i64 = 0x458;
                pub const m_bIsWalking: i64 = 0x398;
                pub const m_flinchBody: i64 = 0x530;
                pub const m_flinchHead: i64 = 0x500;
                pub const m_bIsDefusing: i64 = 0x2D8;
                pub const m_flLadderYaw: i64 = 0x428;
                pub const m_flMoveSpeedX: i64 = 0x320;
                pub const m_flMoveSpeedY: i64 = 0x338;
                pub const m_groundAction: i64 = 0x3C8;
                pub const m_flAimYawAngle: i64 = 0x4E8;
                pub const m_flLadderCycle: i64 = 0x410;
                pub const m_flCrouchAmount: i64 = 0x380;
                pub const m_flinchIsOnFire: i64 = 0x560;
                pub const m_leftFootTarget: i64 = 0x488;
                pub const m_flAimPitchAngle: i64 = 0x4D0;
                pub const m_flFlashedAmount: i64 = 0x4B8;
                pub const m_moveDirectionID: i64 = 0x308;
                pub const m_rightFootTarget: i64 = 0x4A0;
                pub const m_flinchBodyRestart: i64 = 0x548;
                pub const m_flinchHeadRestart: i64 = 0x518;
                pub const m_flWeaponDropAmount: i64 = 0x3B0;
                pub const m_flLadderYawBackwards: i64 = 0x440;
                pub const m_flMoveSpeedHorizontal: i64 = 0x350;
                pub const m_flAirHeightAboveGround: i64 = 0x470;
                pub const m_groundActionDirectionID: i64 = 0x3E0;
                pub const m_flGroundTurnAngleOrVelocity: i64 = 0x3F8;
                pub const m_flPreviousMoveSpeedHorizontal: i64 = 0x368;
            };
            pub const CCSCustomHudLayoutState = struct {
                pub const m_playerSlot: i64 = 0x30;
                pub const m_vecHasClasses: i64 = 0x38;
                pub const m_bInputCaptureEnabled: i64 = 0x34;
                pub const m_vecDialogVariableStrings: i64 = 0x50;
            };
            pub const CCSObserver_UseServices = struct {

            };
            pub const CCSPlayer_WaterServices = struct {
                pub const m_flSwimSoundTime: i64 = 0x58;
                pub const m_flWaterJumpTime: i64 = 0x48;
                pub const m_vecWaterJumpVel: i64 = 0x4C;
            };
            pub const CPlayer_AutoaimServices = struct {

            };
            pub const CPulseCell_Inflow_Yield = struct {
                pub const m_UnyieldResume: i64 = 0xD8;
            };
            pub const CPulseCell_PlaySequence = struct {
                pub const m_OnFinished: i64 = 0xF8;
                pub const m_SequenceName: i64 = 0xD8;
                pub const m_PulseAnimEvents: i64 = 0xE0;
            };
            pub const CPulseCell_ReturnValues = struct {

            };
            pub const CPulseCell_Step_EntFire = struct {
                pub const m_Input: i64 = 0x48;
            };
            pub const CSoundOpvarSetBoxEntity = struct {

            };
            pub const C_CSGO_EndOfMatchCamera = struct {

            };
            pub const C_CSGO_TeamPreviewModel = struct {

            };
            pub const C_CSGO_TeamSelectCamera = struct {

            };
            pub const C_ColorCorrectionVolume = struct {
                pub const m_Weight: i64 = 0x119C;
                pub const m_bEnabled: i64 = 0x1190;
                pub const m_MaxWeight: i64 = 0x1194;
                pub const m_FadeDuration: i64 = 0x1198;
                pub const m_LastExitTime: i64 = 0x118C;
                pub const m_LastEnterTime: i64 = 0x1184;
                pub const m_LastExitWeight: i64 = 0x1188;
                pub const m_lookupFilename: i64 = 0x11A0;
                pub const m_LastEnterWeight: i64 = 0x1180;
            };
            pub const C_FuncElectrifiedVolume = struct {
                pub const m_bState: i64 = 0x10A8;
                pub const m_EffectName: i64 = 0x10A0;
                pub const m_nAmbientEffect: i64 = 0x1098;
            };
            pub const C_MapVetoPickController = struct {
                pub const m_nMapId0: i64 = 0x834;
                pub const m_nMapId1: i64 = 0x934;
                pub const m_nMapId2: i64 = 0xA34;
                pub const m_nMapId3: i64 = 0xB34;
                pub const m_nMapId4: i64 = 0xC34;
                pub const m_nMapId5: i64 = 0xD34;
                pub const m_nDraftType: i64 = 0x610;
                pub const m_nAccountIDs: i64 = 0x734;
                pub const m_bDisabledHud: i64 = 0xF44;
                pub const m_nCurrentPhase: i64 = 0xF34;
                pub const m_nStartingSide0: i64 = 0xE34;
                pub const m_nPhaseStartTick: i64 = 0xF38;
                pub const m_nVoteMapIdsList: i64 = 0x718;
                pub const m_nPhaseDurationTicks: i64 = 0xF3C;
                pub const m_nPostDataUpdateTick: i64 = 0xF40;
                pub const m_nTeamWinningCoinToss: i64 = 0x614;
                pub const m_nTeamWithFirstChoice: i64 = 0x618;
            };
            pub const C_SkyCameraVolumeTarget = struct {
                pub const m_hSkyMaterial: i64 = 0x608;
                pub const m_nSkyboxScale: i64 = 0x600;
            };
            pub const C_SoundAreaEntitySphere = struct {
                pub const m_flRadius: i64 = 0x628;
            };
            pub const EntityRenderAttribute_t = struct {
                pub const m_ID: i64 = 0x30;
                pub const m_Values: i64 = 0x34;
            };
            pub const SellbackPurchaseEntry_t = struct {
                pub const m_hItem: i64 = 0x40;
                pub const m_nCost: i64 = 0x34;
                pub const m_unDefIdx: i64 = 0x30;
                pub const m_nPrevArmor: i64 = 0x38;
                pub const m_bPrevHelmet: i64 = 0x3C;
            };
            pub const SignatureOutflow_Resume = struct {

            };
            pub const ViewAngleServerChange_t = struct {
                pub const nType: i64 = 0x30;
                pub const nIndex: i64 = 0x40;
                pub const qAngle: i64 = 0x34;
            };
            pub const WeaponPurchaseTracker_t = struct {
                pub const m_weaponPurchases: i64 = 0x8;
            };
            pub const CBaseAnimGraphController = struct {
                pub const m_hSequence: i64 = 0xB0;
                pub const m_nNotifyState: i64 = 0xCC;
                pub const m_nAnimLoopMode: i64 = 0xBC;
                pub const m_flPlaybackRate: i64 = 0xC0;
                pub const m_flSeqStartTime: i64 = 0xB4;
                pub const m_primaryGraphId: i64 = 0x408;
                pub const m_flSeqFixedCycle: i64 = 0xB8;
                pub const m_flSoundSyncTime: i64 = 0x58;
                pub const m_bSequenceFinished: i64 = 0xD0;
                pub const m_pGraphInstanceAG2: i64 = 0x448;
                pub const m_vecExternalGraphs: i64 = 0x668;
                pub const m_bLastUpdateSkipped: i64 = 0xCF;
                pub const m_nActiveIKChainMask: i64 = 0x5C;
                pub const m_vecExternalClipIds: i64 = 0x428;
                pub const m_hGraphDefinitionAG2: i64 = 0x370;
                pub const m_nAnimationAlgorithm: i64 = 0x18;
                pub const m_nPrevAnimUpdateTick: i64 = 0xD4;
                pub const m_vecExternalGraphIds: i64 = 0x410;
                pub const m_sAnimGraph2Identifier: i64 = 0x440;
                pub const m_vecSecondarySkeletons: i64 = 0x38;
                pub const m_nPrevAnimationAlgorithm: i64 = 0x699;
                pub const m_nNextExternalGraphHandle: i64 = 0x1C;
                pub const m_bNetworkedSequenceChanged: i64 = 0xCE;
                pub const m_SerializePoseRecipeAG2Slots: i64 = 0x378;
                pub const m_vecSecondarySkeletonSlotIDs: i64 = 0x20;
                pub const m_SerializePoseRecipeAG2Dynamic: i64 = 0x3E0;
                pub const m_nSecondarySkeletonMasterCount: i64 = 0x50;
                pub const m_nServerGraphInstanceIteration: i64 = 0x400;
                pub const m_nSerializePoseRecipeVersionAG2: i64 = 0x3FC;
                pub const m_bNetworkedAnimationInputsChanged: i64 = 0xCD;
                pub const m_nSerializePoseRecipeAG2ActiveSlot: i64 = 0x3F8;
                pub const m_nServerSerializationContextIteration: i64 = 0x404;
            };
            pub const CCSPlayer_BulletServices = struct {
                pub const m_totalHitsOnServer: i64 = 0x48;
            };
            pub const CCSPlayer_CameraServices = struct {
                pub const m_flDeathCamTilt: i64 = 0x2B0;
                pub const m_hDeathCamBounds: i64 = 0x2B4;
                pub const m_vClientScopeInaccuracy: i64 = 0x2C0;
                pub const m_bDeathCamBoundsSearched: i64 = 0x2B8;
            };
            pub const CCSPlayer_WeaponServices = struct {
                pub const m_flNextAttack: i64 = 0xD0;
                pub const m_networkAnimTiming: i64 = 0x15C0;
                pub const m_nOldTotalInputHistoryCount: i64 = 0x370;
                pub const m_bBlockInspectUntilNextGraphUpdate: i64 = 0x15D8;
                pub const m_nOldTotalShootPositionHistoryCount: i64 = 0xD4;
            };
            pub const CCitadelSoundOpvarSetOBB = struct {
                pub const m_iszOpvarName: i64 = 0x628;
                pub const m_iszStackName: i64 = 0x618;
                pub const m_nAABBDirection: i64 = 0x660;
                pub const m_iszOperatorName: i64 = 0x620;
                pub const m_vDistanceInnerMaxs: i64 = 0x63C;
                pub const m_vDistanceInnerMins: i64 = 0x630;
                pub const m_vDistanceOuterMaxs: i64 = 0x654;
                pub const m_vDistanceOuterMins: i64 = 0x648;
            };
            pub const CPlayer_MovementServices = struct {
                pub const m_flUpMove: i64 = 0x1C8;
                pub const m_nButtons: i64 = 0x50;
                pub const m_nImpulse: i64 = 0x48;
                pub const m_flLeftMove: i64 = 0x1C4;
                pub const m_flMaxspeed: i64 = 0x1AC;
                pub const m_flCmdUpMove: i64 = 0x1A8;
                pub const m_flCmdLeftMove: i64 = 0x1A4;
                pub const m_flForwardMove: i64 = 0x1C0;
                pub const m_flCmdForwardMove: i64 = 0x1A0;
                pub const m_vecOldViewAngles: i64 = 0x240;
                pub const m_nButtonDoublePressed: i64 = 0x80;
                pub const m_nQueuedButtonDownMask: i64 = 0x70;
                pub const m_nToggleButtonDownMask: i64 = 0x190;
                pub const m_arrForceSubtickMoveWhen: i64 = 0x1B0;
                pub const m_nQueuedButtonChangeMask: i64 = 0x78;
                pub const m_pButtonPressedCmdNumber: i64 = 0x88;
                pub const m_vecLastMovementImpulses: i64 = 0x1CC;
                pub const m_nLastCommandNumberProcessed: i64 = 0x188;
            };
            pub const CPlayer_ObserverServices = struct {
                pub const m_iObserverMode: i64 = 0x48;
                pub const m_hObserverTarget: i64 = 0x4C;
                pub const m_iObserverLastMode: i64 = 0x50;
                pub const m_bForcedObserverMode: i64 = 0x54;
                pub const m_flObserverChaseDistance: i64 = 0x58;
                pub const m_flObserverChaseDistanceCalcTime: i64 = 0x5C;
            };
            pub const CPulseCell_Inflow_Method = struct {
                pub const m_Args: i64 = 0xA0;
                pub const m_bIsPublic: i64 = 0x98;
                pub const m_MethodName: i64 = 0x80;
                pub const m_Description: i64 = 0x90;
                pub const m_ReturnValues: i64 = 0xB0;
            };
            pub const CPulseCell_IntervalTimer = struct {
                pub const m_Completed: i64 = 0xD8;
                pub const m_OnInterval: i64 = 0x120;
            };
            pub const CPulseCell_Step_DebugLog = struct {

            };
            pub const CPulse_OutflowConnection = struct {
                pub const m_nDestChunk: i64 = 0x10;
                pub const m_nInstruction: i64 = 0x14;
                pub const m_SourceOutflowName: i64 = 0x0;
                pub const m_OutflowRegisterMap: i64 = 0x18;
            };
            pub const C_CSGO_TeamPreviewCamera = struct {
                pub const m_nVariant: i64 = 0x688;
            };
            pub const C_EnvVolumetricFogVolume = struct {
                pub const m_bActive: i64 = 0x600;
                pub const m_vBoxMaxs: i64 = 0x610;
                pub const m_vBoxMins: i64 = 0x604;
                pub const m_TintColor: i64 = 0x640;
                pub const m_flStrength: i64 = 0x620;
                pub const m_nFalloffShape: i64 = 0x624;
                pub const m_bStartDisabled: i64 = 0x61C;
                pub const m_fNoiseStrength: i64 = 0x63C;
                pub const m_bIndirectUseLPVs: i64 = 0x61D;
                pub const m_flHeightFogDepth: i64 = 0x62C;
                pub const m_fSunLightStrength: i64 = 0x638;
                pub const m_flFalloffExponent: i64 = 0x628;
                pub const m_bOverrideTintColor: i64 = 0x644;
                pub const m_fHeightFogEdgeWidth: i64 = 0x630;
                pub const m_bOverrideNoiseStrength: i64 = 0x647;
                pub const m_fIndirectLightStrength: i64 = 0x634;
                pub const m_bOverrideSunLightStrength: i64 = 0x646;
                pub const m_bOverrideIndirectLightStrength: i64 = 0x645;
            };
            pub const C_LightDirectionalEntity = struct {

            };
            pub const C_LightEnvironmentEntity = struct {

            };
            pub const C_PhysicsPropMultiplayer = struct {

            };
            pub const C_SmokeGrenadeProjectile = struct {
                pub const m_nRandomSeed: i64 = 0x1368;
                pub const m_vSmokeColor: i64 = 0x136C;
                pub const m_nVoxelUpdate: i64 = 0x13A4;
                pub const m_VoxelFrameData: i64 = 0x1388;
                pub const m_bDidSmokeEffect: i64 = 0x1364;
                pub const m_bSmokeEffectSpawned: i64 = 0x13AA;
                pub const m_nVoxelFrameDataSize: i64 = 0x13A0;
                pub const m_vSmokeDetonationPos: i64 = 0x1378;
                pub const m_nSmokeEffectTickBegin: i64 = 0x1360;
                pub const m_nSmokeLightProbeRegen: i64 = 0x13A8;
                pub const m_bSmokeVolumeDataReceived: i64 = 0x13A9;
            };
            pub const C_SoundEventSphereEntity = struct {
                pub const m_flRadius: i64 = 0x6C0;
            };
            pub const C_SoundOpvarSetOBBEntity = struct {

            };
            pub const C_SoundOpvarSetPointBase = struct {
                pub const m_iOpvarIndex: i64 = 0x618;
                pub const m_bFastRefresh: i64 = 0x61D;
                pub const m_iszOpvarName: i64 = 0x610;
                pub const m_iszStackName: i64 = 0x600;
                pub const m_bUseAutoCompare: i64 = 0x61C;
                pub const m_iszOperatorName: i64 = 0x608;
            };
            pub const C_TextureBasedAnimatable = struct {
                pub const m_bLoop: i64 = 0x1098;
                pub const m_flFPS: i64 = 0x109C;
                pub const m_flStartTime: i64 = 0x10C8;
                pub const m_flStartFrame: i64 = 0x10CC;
                pub const m_hPositionKeys: i64 = 0x10A0;
                pub const m_hRotationKeys: i64 = 0x10A8;
                pub const m_vAnimationBoundsMax: i64 = 0x10BC;
                pub const m_vAnimationBoundsMin: i64 = 0x10B0;
            };
            pub const CompMatPropertyMutator_t = struct {
                pub const m_bEnabled: i64 = 0x0;
                pub const m_nResolution: i64 = 0x300;
                pub const m_vecConditions: i64 = 0x378;
                pub const m_bSplatDebugInfo: i64 = 0x310;
                pub const m_nSetValue_Value: i64 = 0x68;
                pub const m_bIsScratchTarget: i64 = 0x304;
                pub const m_strDrawText_Font: i64 = 0x370;
                pub const m_colDrawText_Color: i64 = 0x368;
                pub const m_bCaptureInRenderDoc: i64 = 0x311;
                pub const m_nMutatorCommandType: i64 = 0x4;
                pub const m_strCompressionFormat: i64 = 0x308;
                pub const m_vecDrawText_Position: i64 = 0x360;
                pub const m_strInitWith_Container: i64 = 0x8;
                pub const m_vecTexGenInstructions: i64 = 0x318;
                pub const m_vecConditionalMutators: i64 = 0x330;
                pub const m_strPopInputQueue_Container: i64 = 0x348;
                pub const m_strDrawText_InputContainerSrc: i64 = 0x350;
                pub const m_strCopyProperty_TargetProperty: i64 = 0x20;
                pub const m_strGenerateTexture_TargetParam: i64 = 0x2F0;
                pub const m_strCopyKeysWithSuffix_FindSuffix: i64 = 0x58;
                pub const m_strCopyProperty_InputContainerSrc: i64 = 0x10;
                pub const m_strDrawText_InputContainerProperty: i64 = 0x358;
                pub const m_strCopyKeysWithSuffix_ReplaceSuffix: i64 = 0x60;
                pub const m_strGenerateTexture_InitialContainer: i64 = 0x2F8;
                pub const m_strRandomRollInputVars_SeedInputVar: i64 = 0x28;
                pub const m_strCopyMatchingKeys_InputContainerSrc: i64 = 0x48;
                pub const m_strCopyProperty_InputContainerProperty: i64 = 0x18;
                pub const m_vecRandomRollInputVars_InputVarsToRoll: i64 = 0x30;
                pub const m_strCopyKeysWithSuffix_InputContainerSrc: i64 = 0x50;
            };
            pub const GeneratedTextureHandle_t = struct {
                pub const m_strBitmapName: i64 = 0x0;
            };
            pub const CCS2UIPawnGraphController = struct {
                pub const m_bCT: i64 = 0x228;
                pub const m_action: i64 = 0x168;
                pub const m_weaponType: i64 = 0x1B0;
                pub const m_weaponState: i64 = 0x1C8;
                pub const m_characterMode: i64 = 0xD8;
                pub const m_nAnimationSeed: i64 = 0xC0;
                pub const m_weaponCategory: i64 = 0x198;
                pub const m_bannerAnimation: i64 = 0x180;
                pub const m_nChickLifeStage: i64 = 0x210;
                pub const m_inspectTurnAngle: i64 = 0x1E0;
                pub const m_nTeamPreviewRandom: i64 = 0x120;
                pub const m_bCharacterModeReset: i64 = 0xF0;
                pub const m_nTeamPreviewVariant: i64 = 0x108;
                pub const m_nTeamPreviewPosition: i64 = 0x138;
                pub const m_endOfMatchCelebration: i64 = 0x150;
                pub const m_nChickSnapshotVariant: i64 = 0x1F8;
            };
            pub const CCS2WeaponGraphController = struct {
                pub const m_action: i64 = 0xC0;
                pub const m_attackType: i64 = 0x210;
                pub const m_weaponType: i64 = 0x120;
                pub const m_reloadStage: i64 = 0x288;
                pub const m_bActionReset: i64 = 0xD8;
                pub const m_flWeaponAmmo: i64 = 0x150;
                pub const m_idleVariation: i64 = 0x1E0;
                pub const m_weaponCategory: i64 = 0x108;
                pub const m_deployVariation: i64 = 0x1F8;
                pub const m_flWeaponAmmoMax: i64 = 0x168;
                pub const m_weaponExtraInfo: i64 = 0x138;
                pub const m_inspectExtraInfo: i64 = 0x270;
                pub const m_inspectVariation: i64 = 0x258;
                pub const m_bWeaponIsSilenced: i64 = 0x198;
                pub const m_flAttackVariation: i64 = 0x240;
                pub const m_attackThrowStrength: i64 = 0x228;
                pub const m_bIsUsingLegacyModel: i64 = 0x1C8;
                pub const m_flWeaponAmmoReserve: i64 = 0x180;
                pub const m_flWeaponIronsightAmount: i64 = 0x1B0;
                pub const m_flWeaponActionSpeedScale: i64 = 0xF0;
            };
            pub const CCSGO_EndOfMatchLineupEnd = struct {

            };
            pub const CCSGameModeRules_ArmsRace = struct {
                pub const m_WeaponSequence: i64 = 0x30;
            };
            pub const CCSPlayer_HostageServices = struct {
                pub const m_hCarriedHostage: i64 = 0x48;
                pub const m_hCarriedHostageProp: i64 = 0x4C;
            };
            pub const CEnvSoundscapeTriggerable = struct {

            };
            pub const CInfoDynamicShadowHintBox = struct {
                pub const m_vBoxMaxs: i64 = 0x624;
                pub const m_vBoxMins: i64 = 0x618;
            };
            pub const CPulseCell_Value_Gradient = struct {
                pub const m_Gradient: i64 = 0x48;
            };
            pub const C_BaseCSGrenadeProjectile = struct {
                pub const m_nBounces: i64 = 0x12C8;
                pub const m_flSpawnTime: i64 = 0x12E8;
                pub const m_vInitialPosition: i64 = 0x12B0;
                pub const m_vInitialVelocity: i64 = 0x12BC;
                pub const flNextTrailLineTime: i64 = 0x12F8;
                pub const vecLastTrailLinePos: i64 = 0x12EC;
                pub const m_bExplodeEffectBegan: i64 = 0x12FC;
                pub const m_nExplodeEffectIndex: i64 = 0x12D0;
                pub const m_bCanCreateGrenadeTrail: i64 = 0x12FD;
                pub const m_vecExplodeEffectOrigin: i64 = 0x12DC;
                pub const m_nExplodeEffectTickBegin: i64 = 0x12D8;
                pub const m_arrTrajectoryTrailPoints: i64 = 0x1310;
                pub const m_nSnapshotTrajectoryEffectIndex: i64 = 0x1300;
                pub const m_flTrajectoryTrailEffectCreationTime: i64 = 0x1340;
                pub const m_hSnapshotTrajectoryParticleSnapshot: i64 = 0x1308;
                pub const m_arrTrajectoryTrailPointCreationTimes: i64 = 0x1328;
            };
            pub const C_PointClientUIWorldPanel = struct {
                pub const m_bLit: i64 = 0x1299;
                pub const m_flDPI: i64 = 0x12A4;
                pub const m_bOpaque: i64 = 0x12E0;
                pub const m_flWidth: i64 = 0x129C;
                pub const m_bNoDepth: i64 = 0x12E1;
                pub const m_flHeight: i64 = 0x12A0;
                pub const m_bGrabbable: i64 = 0x12E6;
                pub const m_bIgnoreInput: i64 = 0x1298;
                pub const m_flDepthOffset: i64 = 0x12B0;
                pub const m_unOrientation: i64 = 0x12C0;
                pub const m_vecCSSClasses: i64 = 0x12C8;
                pub const m_bDisableMipGen: i64 = 0x12E8;
                pub const m_unOwnerContext: i64 = 0x12B4;
                pub const m_bRenderBackface: i64 = 0x12E3;
                pub const m_flWindowUIScale: i64 = 0x12A8;
                pub const m_unVerticalAlign: i64 = 0x12BC;
                pub const m_bCheckCSSClasses: i64 = 0x10D2;
                pub const m_unHorizontalAlign: i64 = 0x12B8;
                pub const m_flInteractDistance: i64 = 0x12AC;
                pub const m_pOffScreenIndicator: i64 = 0x1270;
                pub const m_anchorDeltaTransform: i64 = 0x10E0;
                pub const m_bOnlyRenderToTexture: i64 = 0x12E7;
                pub const m_nExplicitImageLayout: i64 = 0x12EC;
                pub const m_bExcludeFromSaveGames: i64 = 0x12E5;
                pub const m_bUseOffScreenIndicator: i64 = 0x12E4;
                pub const m_bForceRecreateNextUpdate: i64 = 0x10D0;
                pub const m_bIgnoreParentOrientation: i64 = 0x12F0;
                pub const m_bVisibleWhenParentNoDraw: i64 = 0x12E2;
                pub const m_bMoveViewToPlayerNextThink: i64 = 0x10D1;
                pub const m_bFollowPlayerAcrossTeleport: i64 = 0x129A;
                pub const m_bAllowInteractionFromAllSceneWorlds: i64 = 0x12C4;
            };
            pub const C_SoundOpvarSetAABBEntity = struct {

            };
            pub const C_SoundOpvarSetDomeEntity = struct {

            };
            pub const CompMatMutatorCondition_t = struct {
                pub const m_bPassWhenTrue: i64 = 0x20;
                pub const m_nMutatorCondition: i64 = 0x0;
                pub const m_strMutatorConditionContainerName: i64 = 0x8;
                pub const m_strMutatorConditionContainerVarName: i64 = 0x10;
                pub const m_strMutatorConditionContainerVarValue: i64 = 0x18;
            };
            pub const OutflowWithRequirements_t = struct {
                pub const m_Connection: i64 = 0x0;
                pub const m_RequirementNodeIDs: i64 = 0x50;
                pub const m_DestinationFlowNodeID: i64 = 0x48;
                pub const m_nCursorStateBlockIndex: i64 = 0x68;
            };
            pub const SignatureOutflow_Continue = struct {

            };
            pub const CCSObserver_CameraServices = struct {
                pub const m_hPrevPostProcessingVolume: i64 = 0x2B0;
            };
            pub const CCSPlayer_AimPunchServices = struct {
                pub const m_predictableBaseTick: i64 = 0x48;
                pub const m_predictableBaseAngle: i64 = 0x50;
                pub const m_unpredictableBaseTick: i64 = 0xA0;
                pub const m_unpredictableBaseAngle: i64 = 0xA4;
                pub const m_predictableBaseAngleVel: i64 = 0x5C;
                pub const m_predictableBaseTickInterpAmount: i64 = 0x4C;
            };
            pub const CCSPlayer_MovementServices = struct {
                pub const m_vecUp: i64 = 0x674;
                pub const m_bDucked: i64 = 0x408;
                pub const m_vecLeft: i64 = 0x668;
                pub const m_bDucking: i64 = 0x416;
                pub const m_StuckLast: i64 = 0x64C;
                pub const m_flStamina: i64 = 0x694;
                pub const m_LegacyJump: i64 = 0x6B0;
                pub const m_ModernJump: i64 = 0x6C8;
                pub const m_vecForward: i64 = 0x65C;
                pub const m_bWasSurfing: i64 = 0x714;
                pub const m_flDuckSpeed: i64 = 0x410;
                pub const m_nTraceCount: i64 = 0x648;
                pub const m_bDesiresDuck: i64 = 0x415;
                pub const m_bInStuckTest: i64 = 0x43A;
                pub const m_flDuckAmount: i64 = 0x40C;
                pub const m_bDuckOverride: i64 = 0x414;
                pub const m_bSpeedCropped: i64 = 0x650;
                pub const m_nLastJumpTick: i64 = 0x700;
                pub const m_AnimationState: i64 = 0x310;
                pub const m_flLastDuckTime: i64 = 0x420;
                pub const m_flLastJumpFrac: i64 = 0x704;
                pub const m_nOldWaterLevel: i64 = 0x654;
                pub const m_vecWalkWishVel: i64 = 0x7A4;
                pub const m_vecLadderNormal: i64 = 0x3F8;
                pub const m_bJumpApexPending: i64 = 0x70C;
                pub const m_flDuckRootOffset: i64 = 0x418;
                pub const m_flDuckViewOffset: i64 = 0x41C;
                pub const m_flWaterEntryTime: i64 = 0x658;
                pub const m_duckUntilOnGround: i64 = 0x438;
                pub const m_flHeightAtJumpStart: i64 = 0x698;
                pub const m_flLastJumpVelocityZ: i64 = 0x708;
                pub const m_flVelMulAtJumpStart: i64 = 0x6A8;
                pub const m_flStaminaAtJumpStart: i64 = 0x6A4;
                pub const m_flBombPlantViewOffset: i64 = 0x424;
                pub const m_flAccumulatedJumpError: i64 = 0x6AC;
                pub const m_flFrictionStashedSpeed: i64 = 0x690;
                pub const m_flMaxJumpHeightLastJump: i64 = 0x6A0;
                pub const m_flMaxJumpHeightThisJump: i64 = 0x69C;
                pub const m_nLadderSurfacePropIndex: i64 = 0x404;
                pub const m_bHasEverProcessedCommand: i64 = 0xFD0;
                pub const m_bUseFrictionStashedSpeed: i64 = 0x688;
                pub const m_bHasWalkMovedSinceLastJump: i64 = 0x439;
                pub const m_bUsingGroundTopologyOffset: i64 = 0x3F0;
                pub const m_fStashGrenadeParameterWhen: i64 = 0x684;
                pub const m_flTicksSinceLastSurfingDetected: i64 = 0x710;
                pub const m_vecLastPositionAtFullCrouchSpeed: i64 = 0x430;
                pub const m_flUseFrictionStashedSpeedUntilFrac: i64 = 0x68C;
                pub const m_nGameCodeHasMovedPlayerAfterCommand: i64 = 0x680;
                pub const m_flUsingGroundTopologyOffsetTransitionSmoothing: i64 = 0x3F4;
            };
            pub const CPlayer_FlashlightServices = struct {

            };
            pub const CPointOffScreenIndicatorUi = struct {
                pub const m_bHide: i64 = 0x1301;
                pub const m_bBeenEnabled: i64 = 0x1300;
                pub const m_pTargetPanel: i64 = 0x1308;
                pub const m_flSeenTargetTime: i64 = 0x1304;
            };
            pub const CPulseCell_BaseRequirement = struct {

            };
            pub const CPulseCell_Value_RandomInt = struct {

            };
            pub const CPulse_BlackboardReference = struct {
                pub const m_nNodeID: i64 = 0x18;
                pub const m_NodeName: i64 = 0x20;
                pub const m_BlackboardResource: i64 = 0x8;
                pub const m_hBlackboardResource: i64 = 0x0;
            };
            pub const C_MapPreviewParticleSystem = struct {

            };
            pub const C_ShatterGlassShardPhysics = struct {
                pub const m_ShardDesc: i64 = 0x10A0;
            };
            pub const C_SoundOpvarSetPointEntity = struct {

            };
            pub const PulseNodeDynamicOutflows_t = struct {
                pub const m_Outflows: i64 = 0x0;
            };
            pub const PulseSelectorOutflowList_t = struct {
                pub const m_Outflows: i64 = 0x0;
            };
            pub const CBodyComponentBaseAnimGraph = struct {
                pub const m_animationController: i64 = 0x510;
            };
            pub const CCSGameModeRules_Deathmatch = struct {
                pub const m_sDMBonusWeapon: i64 = 0x38;
                pub const m_flDMBonusStartTime: i64 = 0x30;
                pub const m_flDMBonusTimeLength: i64 = 0x34;
            };
            pub const CCompositeMaterialEditorDoc = struct {
                pub const m_Points: i64 = 0x10;
                pub const m_nVersion: i64 = 0x8;
                pub const m_KVthumbnail: i64 = 0x28;
            };
            pub const CDestructiblePartsComponent = struct {
                pub const m_hOwner: i64 = 0x60;
                pub const __m_pChainEntity: i64 = 0x0;
                pub const m_vecDamageTakenByHitGroup: i64 = 0x48;
                pub const m_pAnimGraphDestructibleGraphController: i64 = 0x68;
            };
            pub const CNetworkedSequenceOperation = struct {
                pub const m_flCycle: i64 = 0x10;
                pub const m_flWeight: i64 = 0x14;
                pub const m_hSequence: i64 = 0x8;
                pub const m_flPrevCycle: i64 = 0xC;
                pub const m_bDiscontinuity: i64 = 0x1D;
                pub const m_bSequenceChangeNetworked: i64 = 0x1C;
                pub const m_flPrevCycleFromDiscontinuity: i64 = 0x20;
                pub const m_flPrevCycleForAnimEventDetection: i64 = 0x24;
            };
            pub const CPulseCell_Inflow_GraphHook = struct {
                pub const m_HookName: i64 = 0x80;
            };
            pub const C_CSGO_MapPreviewCameraPath = struct {
                pub const m_bLoop: i64 = 0x608;
                pub const m_flZFar: i64 = 0x600;
                pub const m_flZNear: i64 = 0x604;
                pub const m_flDuration: i64 = 0x60C;
                pub const m_bDofEnabled: i64 = 0x66C;
                pub const m_bVerticalFOV: i64 = 0x609;
                pub const m_flPathLength: i64 = 0x650;
                pub const m_flDofFarCrisp: i64 = 0x678;
                pub const m_bConstantSpeed: i64 = 0x60A;
                pub const m_flDofFarBlurry: i64 = 0x67C;
                pub const m_flDofNearCrisp: i64 = 0x674;
                pub const m_flPathDuration: i64 = 0x654;
                pub const m_flDofNearBlurry: i64 = 0x670;
                pub const m_flDofTiltToGround: i64 = 0x680;
            };
            pub const CCSObserver_MovementServices = struct {

            };
            pub const CCSObserver_ObserverServices = struct {
                pub const m_obsInterpState: i64 = 0x68;
            };
            pub const CCSPlayerBase_CameraServices = struct {
                pub const m_iFOV: i64 = 0x298;
                pub const m_flFOVRate: i64 = 0x2A4;
                pub const m_flFOVTime: i64 = 0x2A0;
                pub const m_iFOVStart: i64 = 0x29C;
                pub const m_hZoomOwner: i64 = 0x2A8;
                pub const m_flLastShotFOV: i64 = 0x2AC;
            };
            pub const CPulseCell_Step_PublicOutput = struct {
                pub const m_OutputIndex: i64 = 0x48;
            };
            pub const CPulseCell_Value_RandomFloat = struct {

            };
            pub const CPulseCell_WaitForObservable = struct {
                pub const m_OnTrue: i64 = 0x168;
                pub const m_Condition: i64 = 0xD8;
            };
            pub const C_CSGO_EndOfMatchLineupStart = struct {

            };
            pub const C_CSGO_TeamPreviewCameraBone = struct {

            };
            pub const C_EnvVolumetricFogController = struct {
                pub const m_bActive: i64 = 0x64C;
                pub const m_vBoxMaxs: i64 = 0x640;
                pub const m_vBoxMins: i64 = 0x634;
                pub const m_TintColor: i64 = 0x604;
                pub const m_bIsMaster: i64 = 0x676;
                pub const m_bFirstTime: i64 = 0x6A8;
                pub const m_fWindSpeed: i64 = 0x698;
                pub const m_fNoiseSpeed: i64 = 0x684;
                pub const m_flFadeInEnd: i64 = 0x618;
                pub const m_flFadeSpeed: i64 = 0x60C;
                pub const m_vNoiseScale: i64 = 0x68C;
                pub const m_flAnisotropy: i64 = 0x608;
                pub const m_flScattering: i64 = 0x600;
                pub const m_nVolumeDepth: i64 = 0x620;
                pub const m_flFadeInStart: i64 = 0x614;
                pub const m_bStartDisabled: i64 = 0x674;
                pub const m_fNoiseStrength: i64 = 0x688;
                pub const m_flDrawDistance: i64 = 0x610;
                pub const m_vWindDirection: i64 = 0x69C;
                pub const m_bEnableIndirect: i64 = 0x675;
                pub const m_flStartAnisoTime: i64 = 0x650;
                pub const m_flStartAnisotropy: i64 = 0x65C;
                pub const m_flStartScattering: i64 = 0x660;
                pub const m_flIndirectStrength: i64 = 0x61C;
                pub const m_flStartScatterTime: i64 = 0x654;
                pub const m_nForceRefreshCount: i64 = 0x680;
                pub const m_flDefaultAnisotropy: i64 = 0x668;
                pub const m_flDefaultScattering: i64 = 0x66C;
                pub const m_flStartDrawDistance: i64 = 0x664;
                pub const m_hFogIndirectTexture: i64 = 0x678;
                pub const m_nIndirectTextureDimX: i64 = 0x628;
                pub const m_nIndirectTextureDimY: i64 = 0x62C;
                pub const m_nIndirectTextureDimZ: i64 = 0x630;
                pub const m_flDefaultDrawDistance: i64 = 0x670;
                pub const m_flStartDrawDistanceTime: i64 = 0x658;
                pub const m_fFirstVolumeSliceThickness: i64 = 0x624;
            };
            pub const C_NetTestBaseCombatCharacter = struct {

            };
            pub const C_SoundAreaEntityOrientedBox = struct {
                pub const m_vMax: i64 = 0x634;
                pub const m_vMin: i64 = 0x628;
            };
            pub const C_SoundEventMultiPointEntity = struct {

            };
            pub const C_SoundEventPathCornerEntity = struct {
                pub const m_vecCornerPairsNetworked: i64 = 0x6C0;
            };
            pub const C_SoundOpvarSetOBBWindEntity = struct {

            };
            pub const VPhysicsCollisionAttribute_t = struct {
                pub const m_nOwnerId: i64 = 0x24;
                pub const m_nEntityId: i64 = 0x20;
                pub const m_nHierarchyId: i64 = 0x28;
                pub const m_nInteractsAs: i64 = 0x8;
                pub const m_nInteractsWith: i64 = 0x10;
                pub const m_nCollisionGroup: i64 = 0x2E;
                pub const m_nDetailLayerMask: i64 = 0x2A;
                pub const m_nInteractsExclude: i64 = 0x18;
                pub const m_nTargetDetailLayer: i64 = 0x2D;
                pub const m_nDetailLayerMaskType: i64 = 0x2C;
                pub const m_nCollisionFunctionMask: i64 = 0x2F;
            };
            pub const CBodyComponentBaseModelEntity = struct {

            };
            pub const CCSPlayer_DamageReactServices = struct {

            };
            pub const CInfoOffscreenPanoramaTexture = struct {
                pub const m_bDisabled: i64 = 0x600;
                pub const m_szPanelType: i64 = 0x610;
                pub const m_nResolutionX: i64 = 0x604;
                pub const m_nResolutionY: i64 = 0x608;
                pub const m_bEnableMipGen: i64 = 0x601;
                pub const m_szTargetsName: i64 = 0x660;
                pub const m_vecCSSClasses: i64 = 0x648;
                pub const m_RenderAttrName: i64 = 0x620;
                pub const m_TargetEntities: i64 = 0x628;
                pub const m_bCheckCSSClasses: i64 = 0x7E0;
                pub const m_szLayoutFileName: i64 = 0x618;
                pub const m_nTargetChangeCount: i64 = 0x640;
                pub const m_AdditionalTargetEntities: i64 = 0x668;
            };
            pub const CPlayerSprayDecalRenderHelper = struct {

            };
            pub const CPulseCell_BaseYieldingInflow = struct {
                pub const m_BaseFlow_WhileActive: i64 = 0x90;
                pub const m_BaseFlow_OnAfterCancel: i64 = 0x48;
            };
            pub const CPulseCell_BooleanSwitchState = struct {
                pub const m_WhenTrue: i64 = 0x168;
                pub const m_Condition: i64 = 0xD8;
                pub const m_WhenFalse: i64 = 0x1B0;
            };
            pub const CPulseCell_IsRequirementValid = struct {

            };
            pub const CPulseCell_LerpCameraSettings = struct {
                pub const m_End: i64 = 0x134;
                pub const m_Start: i64 = 0x124;
                pub const m_flSeconds: i64 = 0x120;
            };
            pub const C_EnvCombinedLightProbeVolume = struct {
                pub const m_Entity_Color: i64 = 0x718;
                pub const m_Entity_bEnabled: i64 = 0x7D1;
                pub const m_Entity_vBoxMaxs: i64 = 0x774;
                pub const m_Entity_vBoxMins: i64 = 0x768;
                pub const m_Entity_bMoveable: i64 = 0x780;
                pub const m_Entity_nPriority: i64 = 0x78C;
                pub const m_Entity_nHandshake: i64 = 0x784;
                pub const m_Entity_flBrightness: i64 = 0x71C;
                pub const m_Entity_bStartDisabled: i64 = 0x790;
                pub const m_Entity_flEdgeFadeDist: i64 = 0x794;
                pub const m_Entity_vEdgeFadeDists: i64 = 0x798;
                pub const m_Entity_hCubemapTexture: i64 = 0x720;
                pub const m_Entity_nLightProbeSizeX: i64 = 0x7A4;
                pub const m_Entity_nLightProbeSizeY: i64 = 0x7A8;
                pub const m_Entity_nLightProbeSizeZ: i64 = 0x7AC;
                pub const m_Entity_nLightProbeAtlasX: i64 = 0x7B0;
                pub const m_Entity_nLightProbeAtlasY: i64 = 0x7B4;
                pub const m_Entity_nLightProbeAtlasZ: i64 = 0x7B8;
                pub const m_Entity_bCustomCubemapTexture: i64 = 0x728;
                pub const m_Entity_nEnvCubeMapArrayIndex: i64 = 0x788;
                pub const m_Entity_hLightProbeTexture_SDF: i64 = 0x738;
                pub const m_Entity_hLightProbeTexture_SH2_DC: i64 = 0x740;
                pub const m_Entity_hLightProbeTexture_SH2_L1: i64 = 0x748;
                pub const m_Entity_hLightProbeTexture_AmbientCube: i64 = 0x730;
                pub const m_Entity_hLightProbeDirectLightIndicesTexture: i64 = 0x750;
                pub const m_Entity_hLightProbeDirectLightScalarsTexture: i64 = 0x758;
                pub const m_Entity_hLightProbeDirectLightShadowsTexture: i64 = 0x760;
            };
            pub const C_PointClientUIWorldTextPanel = struct {
                pub const m_messageText: i64 = 0x1300;
            };
            pub const C_SceneEntity__QueuedEvents_t = struct {
                pub const starttime: i64 = 0x0;
            };
            pub const C_SoundOpvarSetAutoRoomEntity = struct {

            };
            pub const CBodyComponentSkeletonInstance = struct {
                pub const m_skeletonInstance: i64 = 0x80;
            };
            pub const CPulseCell_Inflow_EventHandler = struct {
                pub const m_EventName: i64 = 0x80;
            };
            pub const CPulseCell_Outflow_CycleRandom = struct {
                pub const m_Outputs: i64 = 0x48;
            };
            pub const C_PortraitWorldCallbackHandler = struct {

            };
            pub const CompositeMaterialEditorPoint_t = struct {
                pub const m_flCycle: i64 = 0xE4;
                pub const m_ModelName: i64 = 0x0;
                pub const m_ChildModelName: i64 = 0x100;
                pub const m_nSequenceIndex: i64 = 0xE0;
                pub const m_bEnableChildModel: i64 = 0xF8;
                pub const m_KVModelStateChoices: i64 = 0xE8;
                pub const m_vecCompositeMaterials: i64 = 0x1F8;
                pub const m_vecCompositeMaterialAssemblyProcedures: i64 = 0x1E0;
            };
            pub const CompositeMaterialMatchFilter_t = struct {
                pub const m_bPassWhenTrue: i64 = 0x18;
                pub const m_strMatchValue: i64 = 0x10;
                pub const m_strMatchFilter: i64 = 0x8;
                pub const m_nCompositeMaterialMatchFilterType: i64 = 0x0;
            };
            pub const CPulseCell_Outflow_CycleOrdered = struct {
                pub const m_Outputs: i64 = 0x48;
            };
            pub const C_CSGO_EndOfMatchLineupEndpoint = struct {

            };
            pub const C_CSGO_MapPreviewCameraPathNode = struct {
                pub const m_flFOV: i64 = 0x624;
                pub const m_flEaseIn: i64 = 0x62C;
                pub const m_flEaseOut: i64 = 0x630;
                pub const m_nPathIndex: i64 = 0x608;
                pub const m_flCameraSpeed: i64 = 0x628;
                pub const m_vInTangentLocal: i64 = 0x60C;
                pub const m_vInTangentWorld: i64 = 0x634;
                pub const m_vOutTangentLocal: i64 = 0x618;
                pub const m_vOutTangentWorld: i64 = 0x640;
                pub const m_szParentPathUniqueID: i64 = 0x600;
            };
            pub const C_CSGO_TerroristRushIntroCamera = struct {

            };
            pub const C_CSGO_TerroristTeamIntroCamera = struct {

            };
            pub const C_DynamicPropAlias_dynamic_prop = struct {

            };
            pub const C_SoundOpvarSetPathCornerEntity = struct {

            };
            pub const ServerAuthoritativeWeaponSlot_t = struct {
                pub const unSlot: i64 = 0x32;
                pub const unClass: i64 = 0x30;
                pub const unItemDefIdx: i64 = 0x34;
            };
            pub const CCSGO_RushIntroCharacterPosition = struct {

            };
            pub const CCSGO_RushIntroTerroristPosition = struct {

            };
            pub const CCSPlayer_ActionTrackingServices = struct {
                pub const m_bIsRescuing: i64 = 0x4C;
                pub const m_weaponPurchasesThisMatch: i64 = 0x50;
                pub const m_weaponPurchasesThisRound: i64 = 0xC0;
                pub const m_weaponCarryOverIntoThisRound: i64 = 0x130;
                pub const m_hLastWeaponBeforeC4AutoSwitch: i64 = 0x48;
            };
            pub const CCS_PortraitWorldCallbackHandler = struct {

            };
            pub const CPulseCell_Inflow_BaseEntrypoint = struct {
                pub const m_EntryChunk: i64 = 0x48;
                pub const m_RegisterMap: i64 = 0x50;
            };
            pub const CPulseCell_Outflow_CycleShuffled = struct {
                pub const m_Outputs: i64 = 0x48;
            };
            pub const CPulseCell_WaitForCursorsWithTag = struct {
                pub const m_bTagSelfWhenComplete: i64 = 0x128;
                pub const m_nDesiredKillPriority: i64 = 0x12C;
            };
            pub const C_DynamicPropAlias_cable_dynamic = struct {

            };
            pub const C_RopeKeyframe__CPhysicsDelegate = struct {
                pub const m_pKeyframe: i64 = 0x8;
            };
            pub const CBaseAnimGraphAlias_baseanimating = struct {

            };
            pub const CPlayer_MovementServices_Humanoid = struct {
                pub const m_nStepside: i64 = 0x280;
                pub const m_groundNormal: i64 = 0x260;
                pub const m_surfaceProps: i64 = 0x270;
                pub const m_flFallVelocity: i64 = 0x25C;
                pub const m_flStepSoundTime: i64 = 0x258;
                pub const m_flSurfaceFriction: i64 = 0x26C;
            };
            pub const CPulseCell_InlineNodeSkipSelector = struct {
                pub const m_bAnd: i64 = 0x4C;
                pub const m_FailOutflow: i64 = 0x68;
                pub const m_PassOutflow: i64 = 0x50;
                pub const m_nFlowNodeID: i64 = 0x48;
            };
            pub const CPulseCell_LimitCount__Criteria_t = struct {
                pub const m_bLimitCountPasses: i64 = 0x0;
            };
            pub const C_CSGO_TeamIntroCharacterPosition = struct {

            };
            pub const C_CSGO_TeamIntroTerroristPosition = struct {

            };
            pub const C_EconEntity__AttachedModelData_t = struct {
                pub const m_iModelDisplayFlags: i64 = 0x0;
            };
            pub const CompositeMaterialInputContainer_t = struct {
                pub const m_bEnabled: i64 = 0x0;
                pub const m_strAlias: i64 = 0xF0;
                pub const m_strAttrName: i64 = 0xE8;
                pub const m_bExposeExternally: i64 = 0x118;
                pub const m_strAttrNameForVar: i64 = 0x110;
                pub const m_vecLooseVariables: i64 = 0xF8;
                pub const m_strSpecificContainerMaterial: i64 = 0x8;
                pub const m_nCompositeMaterialInputContainerSourceType: i64 = 0x4;
            };
            pub const CCSPlayerController_DamageServices = struct {
                pub const m_DamageList: i64 = 0x48;
                pub const m_nSendUpdate: i64 = 0x40;
            };
            pub const CEnvSoundscapeAlias_snd_soundscape = struct {

            };
            pub const CPulseCell_BaseLerp__CursorState_t = struct {
                pub const m_EndTime: i64 = 0x4;
                pub const m_StartTime: i64 = 0x0;
            };
            pub const CPulseCell_Inflow_EntOutputHandler = struct {
                pub const m_SourceEntity: i64 = 0x80;
                pub const m_SourceOutput: i64 = 0x90;
                pub const m_ExpectedParamType: i64 = 0xA0;
            };
            pub const CPulseCell_PickBestOutflowSelector = struct {
                pub const m_nCheckType: i64 = 0x48;
                pub const m_OutflowList: i64 = 0x50;
            };
            pub const CPulseCell_Step_CallExternalMethod = struct {
                pub const m_MethodName: i64 = 0xD8;
                pub const m_OnFinished: i64 = 0x108;
                pub const m_ExpectedArgs: i64 = 0xF0;
                pub const m_nAsyncCallMode: i64 = 0x100;
                pub const m_nBlackboardIndex: i64 = 0xE8;
            };
            pub const C_CSGO_EndOfMatchCharacterPosition = struct {

            };
            pub const C_CSGO_TeamSelectCharacterPosition = struct {

            };
            pub const C_CSGO_TeamSelectTerroristPosition = struct {

            };
            pub const C_CSGO_TerroristWingmanIntroCamera = struct {

            };
            pub const CCSGO_WingmanIntroCharacterPosition = struct {

            };
            pub const CCSGO_WingmanIntroTerroristPosition = struct {

            };
            pub const C_CSGO_TeamPreviewCharacterPosition = struct {
                pub const m_xuid: i64 = 0x618;
                pub const m_nRandom: i64 = 0x604;
                pub const m_petItem: i64 = 0x1730;
                pub const m_nOrdinal: i64 = 0x608;
                pub const m_nVariant: i64 = 0x600;
                pub const m_agentItem: i64 = 0x620;
                pub const m_glovesItem: i64 = 0xBD0;
                pub const m_weaponItem: i64 = 0x1180;
                pub const m_sWeaponName: i64 = 0x610;
            };
            pub const AnimGraph2SerializedPoseRecipeSlot_t = struct {
                pub const m_topology: i64 = 0x30;
            };
            pub const CPulseCell_Timeline__TimelineEvent_t = struct {
                pub const m_EventOutflow: i64 = 0x8;
                pub const m_flTimeFromPrevious: i64 = 0x0;
            };
            pub const CPulseCell_WaitForCursorsWithTagBase = struct {
                pub const m_WaitComplete: i64 = 0xE0;
                pub const m_nCursorsAllowedToWait: i64 = 0xD8;
            };
            pub const CompositeMaterialAssemblyProcedure_t = struct {
                pub const m_vecMatchFilters: i64 = 0x18;
                pub const m_vecCompMatIncludes: i64 = 0x0;
                pub const m_vecPropertyMutators: i64 = 0x48;
                pub const m_vecCompositeInputContainers: i64 = 0x30;
            };
            pub const CCSPlayerController_InventoryServices = struct {
                pub const m_rank: i64 = 0x5C;
                pub const m_unMusicID: i64 = 0x58;
                pub const m_vecNetworkableLoadout: i64 = 0x40;
                pub const m_nPersonaDataPublicLevel: i64 = 0x74;
                pub const m_nPersonaDataXpTrailLevel: i64 = 0x84;
                pub const m_nPersonaDataPublicCommendsLeader: i64 = 0x78;
                pub const m_nPersonaDataPublicCommendsTeacher: i64 = 0x7C;
                pub const m_vecServerAuthoritativeWeaponSlots: i64 = 0x88;
                pub const m_nPersonaDataPublicCommendsFriendly: i64 = 0x80;
            };
            pub const C_BaseModelEntity__BodyGroupRequest_t = struct {
                pub const m_nGroup: i64 = 0x10;
                pub const m_uChoice: i64 = 0x14;
                pub const m_uRefCount: i64 = 0x16;
                pub const m_nGroupName: i64 = 0x4;
                pub const m_uRequestID: i64 = 0x0;
                pub const m_sChoiceName: i64 = 0x8;
            };
            pub const C_BaseModelEntity__Emphasized_Phoneme = struct {
                pub const m_bValid: i64 = 0x1E;
                pub const m_flAmount: i64 = 0x18;
                pub const m_bRequired: i64 = 0x1C;
                pub const m_sClassName: i64 = 0x0;
                pub const m_bBasechecked: i64 = 0x1D;
            };
            pub const C_InfoInstructorHintHostageRescueZone = struct {

            };
            pub const CompositeMaterialInputLooseVariable_t = struct {
                pub const m_strName: i64 = 0x0;
                pub const m_strString: i64 = 0x270;
                pub const m_nValueIntW: i64 = 0x54;
                pub const m_nValueIntX: i64 = 0x48;
                pub const m_nValueIntY: i64 = 0x4C;
                pub const m_nValueIntZ: i64 = 0x50;
                pub const m_cValueColor4: i64 = 0x8C;
                pub const m_nTextureType: i64 = 0x268;
                pub const m_bValueBoolean: i64 = 0x44;
                pub const m_flValueFloatW: i64 = 0x80;
                pub const m_flValueFloatX: i64 = 0x5C;
                pub const m_flValueFloatY: i64 = 0x68;
                pub const m_flValueFloatZ: i64 = 0x74;
                pub const m_nVariableType: i64 = 0x40;
                pub const m_bHasFloatBounds: i64 = 0x58;
                pub const m_nValueSystemVar: i64 = 0x90;
                pub const m_bExposeExternally: i64 = 0x8;
                pub const m_flValueFloatW_Max: i64 = 0x88;
                pub const m_flValueFloatW_Min: i64 = 0x84;
                pub const m_flValueFloatX_Max: i64 = 0x64;
                pub const m_flValueFloatX_Min: i64 = 0x60;
                pub const m_flValueFloatY_Max: i64 = 0x70;
                pub const m_flValueFloatY_Min: i64 = 0x6C;
                pub const m_flValueFloatZ_Max: i64 = 0x7C;
                pub const m_flValueFloatZ_Min: i64 = 0x78;
                pub const m_nPanoramaRenderRes: i64 = 0x280;
                pub const m_strExposedValueList: i64 = 0x38;
                pub const m_strResourceMaterial: i64 = 0x98;
                pub const m_strPanoramaPanelPath: i64 = 0x278;
                pub const m_strExposedFriendlyName: i64 = 0x10;
                pub const m_strExposedHiddenWhenTrue: i64 = 0x30;
                pub const m_strExposedVisibleWhenTrue: i64 = 0x28;
                pub const m_strTextureContentAssetPath: i64 = 0x178;
                pub const m_strExposedFriendlyGroupName: i64 = 0x18;
                pub const m_bExposedVariableIsFixedRange: i64 = 0x20;
                pub const m_strTextureRuntimeResourcePath: i64 = 0x180;
                pub const m_strTextureCompilationVtexTemplate: i64 = 0x260;
            };
            pub const CPulseCell_LimitCount__InstanceState_t = struct {
                pub const m_nCurrentCount: i64 = 0x0;
            };
            pub const CPulseCell_PlaySequence__CursorState_t = struct {
                pub const m_hTarget: i64 = 0x0;
            };
            pub const C_CSGO_CounterTerroristRushIntroCamera = struct {

            };
            pub const C_CSGO_CounterTerroristTeamIntroCamera = struct {

            };
            pub const CCSGO_RushIntroCounterTerroristPosition = struct {

            };
            pub const CCSPlayerController_InGameMoneyServices = struct {
                pub const m_iAccount: i64 = 0x40;
                pub const m_iStartAccount: i64 = 0x44;
                pub const m_iTotalCashSpent: i64 = 0x48;
                pub const m_iCashSpentThisRound: i64 = 0x4C;
            };
            pub const CPulseCell_IntervalTimer__CursorState_t = struct {
                pub const m_EndTime: i64 = 0x4;
                pub const m_StartTime: i64 = 0x0;
                pub const m_flWaitInterval: i64 = 0x8;
                pub const m_flWaitIntervalHigh: i64 = 0xC;
                pub const m_bCompleteOnNextWake: i64 = 0x10;
            };
            pub const C_SoundEventEntityAlias_snd_event_point = struct {

            };
            pub const C_CSGO_TeamIntroCounterTerroristPosition = struct {

            };
            pub const C_DynamicPropAlias_prop_dynamic_override = struct {

            };
            pub const CPulseCell_IsRequirementValid__Criteria_t = struct {
                pub const m_bIsValid: i64 = 0x0;
            };
            pub const C_CSGO_CounterTerroristWingmanIntroCamera = struct {

            };
            pub const C_CSGO_TeamSelectCounterTerroristPosition = struct {

            };
            pub const CCSGO_WingmanIntroCounterTerroristPosition = struct {

            };
            pub const CCSPlayerController_ActionTrackingServices = struct {
                pub const m_matchStats: i64 = 0xA8;
                pub const m_perRoundStats: i64 = 0x40;
                pub const m_iNumRoundKills: i64 = 0x128;
                pub const m_flTotalRoundDamageDealt: i64 = 0x130;
                pub const m_iNumRoundKillsHeadshots: i64 = 0x12C;
            };
            pub const CAttributeManager__cached_attribute_float_t = struct {
                pub const flIn: i64 = 0x0;
                pub const flOut: i64 = 0x10;
                pub const iAttribHook: i64 = 0x8;
            };
            pub const CPulseCell_Inflow_ObservableVariableListener = struct {
                pub const m_bSelfReference: i64 = 0x82;
                pub const m_nBlackboardReference: i64 = 0x80;
            };
            pub const CPulseCell_LerpCameraSettings__CursorState_t = struct {
                pub const m_hCamera: i64 = 0x8;
                pub const m_OverlaidEnd: i64 = 0x1C;
                pub const m_OverlaidStart: i64 = 0xC;
            };
            pub const PulseNodeDynamicOutflows_t__DynamicOutflow_t = struct {
                pub const m_OutflowID: i64 = 0x0;
                pub const m_Connection: i64 = 0x8;
            };
            pub const CEnvSoundscapeProxyAlias_snd_soundscape_proxy = struct {

            };
            pub const C_CSGO_PreviewModelAlias_csgo_item_previewmodel = struct {

            };
            pub const CPulseCell_Outflow_CycleOrdered__InstanceState_t = struct {
                pub const m_nNextIndex: i64 = 0x0;
            };
            pub const CPulseCell_Outflow_CycleShuffled__InstanceState_t = struct {
                pub const m_Shuffle: i64 = 0x0;
                pub const m_nNextShuffle: i64 = 0x20;
            };
            pub const C_TonemapController2Alias_env_tonemap_controller2 = struct {

            };
            pub const C_CSGO_PreviewPlayerAlias_csgo_player_previewmodel = struct {

            };
            pub const C_PathParticleRopeAlias_path_particle_rope_clientside = struct {

            };
            pub const CEnvSoundscapeTriggerableAlias_snd_soundscape_triggerable = struct {

            };
            pub const CCSPlayerController_InventoryServices__NetworkedLoadoutSlot_t = struct {
                pub const slot: i64 = 0xA;
                pub const team: i64 = 0x8;
                pub const pItem: i64 = 0x0;
            };
            pub const C_EnvCombinedLightProbeVolumeAlias_func_combined_light_probe_volume = struct {

            };
            pub const P2P_Messages = struct {
                pub const p2p_Ping: i64 = 0x102;
                pub const p2p_Voice: i64 = 0x101;
                pub const p2p_TextMessage: i64 = 0x100;
                pub const p2p_VRAvatarPosition: i64 = 0x103;
                pub const p2p_WatchSynchronization: i64 = 0x104;
                pub const p2p_FightingGame_GameData: i64 = 0x105;
                pub const p2p_FightingGame_Connection: i64 = 0x106;
            };
            pub const InventoryNodeType_t = struct {
                pub const NODE_TYPE_INVALID: i64 = 0x0;
                pub const VIRTUAL_NODE_SCHEMA_PREFAB: i64 = 0x1;
                pub const CONCRETE_NODE_SCHEMA_PREFAB: i64 = 0x5;
                pub const VIRTUAL_NODE_SCHEMA_ITEMDEF: i64 = 0x2;
                pub const VIRTUAL_NODE_SCHEMA_STICKER: i64 = 0x3;
                pub const CONCRETE_NODE_SCHEMA_ITEMDEF: i64 = 0x6;
                pub const CONCRETE_NODE_SCHEMA_STICKER: i64 = 0x7;
                pub const VIRTUAL_NODE_SCHEMA_KEYCHAIN: i64 = 0x4;
                pub const CONCRETE_NODE_SCHEMA_KEYCHAIN: i64 = 0x8;
            };
            pub const PulseMethodCallMode_t = struct {
                pub const ASYNC_FIRE_AND_FORGET: i64 = 0x1;
                pub const SYNC_WAIT_FOR_COMPLETION: i64 = 0x0;
            };
            pub const PulseBestOutflowRules_t = struct {
                pub const SORT_BY_OUTFLOW_INDEX: i64 = 0x1;
                pub const SORT_BY_NUMBER_OF_VALID_CRITERIA: i64 = 0x0;
            };
            pub const PulseCursorWakePriority_t = struct {
                pub const WakeElegantly: i64 = 0x0;
                pub const WakeImmediate: i64 = 0x1;
            };
            pub const PulseCursorCancelPriority_t = struct {
                pub const _None: i64 = 0x0;
                pub const HardCancel: i64 = 0x3;
                pub const SoftCancel: i64 = 0x2;
                pub const CancelOnSucceeded: i64 = 0x1;
            };
            pub const CompMatPropertyMutatorType_t = struct {
                pub const COMP_MAT_PROPERTY_MUTATOR_INIT: i64 = 0x0;
                pub const COMP_MAT_PROPERTY_MUTATOR_DRAW_TEXT: i64 = 0x8;
                pub const COMP_MAT_PROPERTY_MUTATOR_SET_VALUE: i64 = 0x4;
                pub const COMP_MAT_PROPERTY_MUTATOR_COPY_PROPERTY: i64 = 0x3;
                pub const COMP_MAT_PROPERTY_MUTATOR_POP_INPUT_QUEUE: i64 = 0x7;
                pub const COMP_MAT_PROPERTY_MUTATOR_GENERATE_TEXTURE: i64 = 0x5;
                pub const COMP_MAT_PROPERTY_MUTATOR_COPY_MATCHING_KEYS: i64 = 0x1;
                pub const COMP_MAT_PROPERTY_MUTATOR_CONDITIONAL_MUTATORS: i64 = 0x6;
                pub const COMP_MAT_PROPERTY_MUTATOR_COPY_KEYS_WITH_SUFFIX: i64 = 0x2;
                pub const COMP_MAT_PROPERTY_MUTATOR_RANDOM_ROLL_INPUT_VARIABLES: i64 = 0x9;
            };
            pub const CompositeMaterialVarSystemVar_t = struct {
                pub const COMPMATSYSVAR_COMPOSITETIME: i64 = 0x0;
                pub const COMPMATSYSVAR_EMPTY_RESOURCE_SPACER: i64 = 0x1;
            };
            pub const CompositeMaterialMatchFilterType_t = struct {
                pub const MATCH_FILTER_MATERIAL_SHADER: i64 = 0x1;
                pub const MATCH_FILTER_MATERIAL_NAME_SUBSTR: i64 = 0x2;
                pub const MATCH_FILTER_MATERIAL_PROPERTY_EQUALS: i64 = 0x5;
                pub const MATCH_FILTER_MATERIAL_PROPERTY_EXISTS: i64 = 0x4;
                pub const MATCH_FILTER_MATERIAL_ATTRIBUTE_EQUALS: i64 = 0x3;
                pub const MATCH_FILTER_MATERIAL_ATTRIBUTE_EXISTS: i64 = 0x0;
            };
            pub const CompositeMaterialInputTextureType_t = struct {
                pub const INPUT_TEXTURE_TYPE_AO: i64 = 0x6;
                pub const INPUT_TEXTURE_TYPE_COLOR: i64 = 0x2;
                pub const INPUT_TEXTURE_TYPE_MASKS: i64 = 0x3;
                pub const INPUT_TEXTURE_TYPE_DEFAULT: i64 = 0x0;
                pub const INPUT_TEXTURE_TYPE_POSITION: i64 = 0x7;
                pub const INPUT_TEXTURE_TYPE_NORMALMAP: i64 = 0x1;
                pub const INPUT_TEXTURE_TYPE_ROUGHNESS: i64 = 0x4;
                pub const INPUT_TEXTURE_TYPE_PEARLESCENCE_MASK: i64 = 0x5;
            };
            pub const CompMatPropertyMutatorConditionType_t = struct {
                pub const COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_EXISTS: i64 = 0x0;
                pub const COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_VALUE_EQUALS: i64 = 0x2;
                pub const COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_VALUE_EXISTS: i64 = 0x1;
            };
            pub const C_BaseCombatCharacter__WaterWakeMode_t = struct {
                pub const WATER_WAKE_IDLE: i64 = 0x1;
                pub const WATER_WAKE_NONE: i64 = 0x0;
                pub const WATER_WAKE_RUNNING: i64 = 0x3;
                pub const WATER_WAKE_WALKING: i64 = 0x2;
                pub const WATER_WAKE_WATER_OVERHEAD: i64 = 0x4;
            };
            pub const CompositeMaterialInputLooseVariableType_t = struct {
                pub const LOOSE_VARIABLE_TYPE_COLOR4: i64 = 0x9;
                pub const LOOSE_VARIABLE_TYPE_FLOAT1: i64 = 0x5;
                pub const LOOSE_VARIABLE_TYPE_FLOAT2: i64 = 0x6;
                pub const LOOSE_VARIABLE_TYPE_FLOAT3: i64 = 0x7;
                pub const LOOSE_VARIABLE_TYPE_FLOAT4: i64 = 0x8;
                pub const LOOSE_VARIABLE_TYPE_STRING: i64 = 0xA;
                pub const LOOSE_VARIABLE_TYPE_BOOLEAN: i64 = 0x0;
                pub const LOOSE_VARIABLE_TYPE_INTEGER1: i64 = 0x1;
                pub const LOOSE_VARIABLE_TYPE_INTEGER2: i64 = 0x2;
                pub const LOOSE_VARIABLE_TYPE_INTEGER3: i64 = 0x3;
                pub const LOOSE_VARIABLE_TYPE_INTEGER4: i64 = 0x4;
                pub const LOOSE_VARIABLE_TYPE_SYSTEMVAR: i64 = 0xB;
                pub const LOOSE_VARIABLE_TYPE_PANORAMA_RENDER: i64 = 0xE;
                pub const LOOSE_VARIABLE_TYPE_RESOURCE_TEXTURE: i64 = 0xD;
                pub const LOOSE_VARIABLE_TYPE_RESOURCE_MATERIAL: i64 = 0xC;
            };
            pub const CompositeMaterialInputContainerSourceType_t = struct {
                pub const CONTAINER_SOURCE_TYPE_LOOSE_VARIABLES: i64 = 0x3;
                pub const CONTAINER_SOURCE_TYPE_TARGET_MATERIAL: i64 = 0x0;
                pub const CONTAINER_SOURCE_TYPE_SPECIFIC_MATERIAL: i64 = 0x2;
                pub const CONTAINER_SOURCE_TYPE_TARGET_INSTANCE_MATERIAL: i64 = 0x5;
                pub const CONTAINER_SOURCE_TYPE_MATERIAL_FROM_TARGET_ATTR: i64 = 0x1;
                pub const CONTAINER_SOURCE_TYPE_VARIABLE_FROM_TARGET_ATTR: i64 = 0x4;
            };
        };
    };
};
