pub const cs2_dumper = struct {
    pub const schemas = struct {
        pub const server_dll = struct {
            pub const CC4 = struct {
                pub const m_fArmedTime: i64 = 0x12CC;
                pub const m_nSpotRules: i64 = 0x12F0;
                pub const m_bBombPlanted: i64 = 0x12FB;
                pub const m_bStartedArming: i64 = 0x12C9;
                pub const m_bIsPlantingViaUse: i64 = 0x12D1;
                pub const m_bPlayedArmingBeeps: i64 = 0x12F4;
                pub const m_entitySpottedState: i64 = 0x12D8;
                pub const m_bBombPlacedAnimation: i64 = 0x12D0;
                pub const m_vecLastValidDroppedPosition: i64 = 0x12BC;
                pub const m_bDoValidDroppedPositionCheck: i64 = 0x12C8;
                pub const m_vecLastValidPlayerHeldPosition: i64 = 0x12B0;
            };
            pub const CBot = struct {
                pub const m_id: i64 = 0x24;
                pub const m_pPlayer: i64 = 0x18;
                pub const m_isRunning: i64 = 0xC0;
                pub const m_leftSpeed: i64 = 0xC8;
                pub const m_bHasSpawned: i64 = 0x20;
                pub const m_buttonFlags: i64 = 0xD0;
                pub const m_isCrouching: i64 = 0xC1;
                pub const m_pController: i64 = 0x10;
                pub const m_viewForward: i64 = 0xDC;
                pub const m_forwardSpeed: i64 = 0xC4;
                pub const m_jumpTimestamp: i64 = 0xD8;
                pub const m_verticalSpeed: i64 = 0xCC;
                pub const m_postureStackIndex: i64 = 0xF8;
            };
            pub const CAK47 = struct {

            };
            pub const CBeam = struct {
                pub const m_fSpeed: i64 = 0x8CC;
                pub const m_fWidth: i64 = 0x8B4;
                pub const m_flFrame: i64 = 0x8D0;
                pub const m_flDamage: i64 = 0x85C;
                pub const m_fEndWidth: i64 = 0x8B8;
                pub const m_nBeamType: i64 = 0x878;
                pub const m_vecEndPos: i64 = 0x8D8;
                pub const m_bTurnedOff: i64 = 0x8D4;
                pub const m_fAmplitude: i64 = 0x8C4;
                pub const m_fHaloScale: i64 = 0x8C0;
                pub const m_flFireTime: i64 = 0x858;
                pub const m_hEndEntity: i64 = 0x8E4;
                pub const m_nBeamFlags: i64 = 0x87C;
                pub const m_nHaloIndex: i64 = 0x870;
                pub const m_fFadeLength: i64 = 0x8BC;
                pub const m_fStartFrame: i64 = 0x8C8;
                pub const m_flFrameRate: i64 = 0x850;
                pub const m_nAttachIndex: i64 = 0x8A8;
                pub const m_nNumBeamEnts: i64 = 0x860;
                pub const m_hAttachEntity: i64 = 0x880;
                pub const m_hBaseMaterial: i64 = 0x868;
                pub const m_nDissolveType: i64 = 0x8E8;
                pub const m_flHDRColorScale: i64 = 0x854;
            };
            pub const CFish = struct {
                pub const m_x: i64 = 0xA48;
                pub const m_y: i64 = 0xA4C;
                pub const m_z: i64 = 0xA50;
                pub const m_id: i64 = 0xA44;
                pub const m_perp: i64 = 0xA68;
                pub const m_pool: i64 = 0xA40;
                pub const m_angle: i64 = 0xA54;
                pub const m_speed: i64 = 0xA84;
                pub const m_forward: i64 = 0xA5C;
                pub const m_goTimer: i64 = 0xAB8;
                pub const m_visible: i64 = 0xB30;
                pub const m_calmSpeed: i64 = 0xA8C;
                pub const m_moveTimer: i64 = 0xAD0;
                pub const m_turnTimer: i64 = 0xA98;
                pub const m_avoidRange: i64 = 0xA94;
                pub const m_panicSpeed: i64 = 0xA90;
                pub const m_panicTimer: i64 = 0xAE8;
                pub const m_poolOrigin: i64 = 0xA74;
                pub const m_waterLevel: i64 = 0xA80;
                pub const m_angleChange: i64 = 0xA58;
                pub const m_desiredSpeed: i64 = 0xA88;
                pub const m_disperseTimer: i64 = 0xB00;
                pub const m_turnClockwise: i64 = 0xAB0;
                pub const m_proximityTimer: i64 = 0xB18;
            };
            pub const CItem = struct {
                pub const m_OnGlovePulled: i64 = 0xA98;
                pub const m_OnPlayerTouch: i64 = 0xA48;
                pub const m_OnPlayerPickup: i64 = 0xA60;
                pub const m_bPhysStartAsleep: i64 = 0xAC8;
                pub const m_OnCacheInteraction: i64 = 0xA80;
                pub const m_bActivateWhenAtRest: i64 = 0xA78;
                pub const m_vOriginalSpawnAngles: i64 = 0xABC;
                pub const m_vOriginalSpawnOrigin: i64 = 0xAB0;
            };
            pub const CTeam = struct {
                pub const m_iScore: i64 = 0x4D8;
                pub const m_aPlayers: i64 = 0x4C0;
                pub const m_szTeamname: i64 = 0x4DC;
                pub const m_aPlayerControllers: i64 = 0x4A8;
            };
            pub const CBlood = struct {
                pub const m_Color: i64 = 0x4C4;
                pub const m_flAmount: i64 = 0x4C0;
                pub const m_vecSprayDir: i64 = 0x4B4;
                pub const m_vecSprayAngles: i64 = 0x4A8;
            };
            pub const CCSBot = struct {
                pub const m_name: i64 = 0x114;
                pub const m_avoid: i64 = 0x5F4;
                pub const m_enemy: i64 = 0x5A00;
                pub const m_avgVel: i64 = 0x5DCC;
                pub const m_bomber: i64 = 0x5C38;
                pub const m_leader: i64 = 0x1AC;
                pub const m_aimGoal: i64 = 0x59C4;
                pub const m_isRogue: i64 = 0x158;
                pub const m_isStuck: i64 = 0x5D83;
                pub const m_lookYaw: i64 = 0x598C;
                pub const m_wasSafe: i64 = 0x184;
                pub const m_aimError: i64 = 0x59B8;
                pub const m_aimFocus: i64 = 0x59D4;
                pub const m_attacker: i64 = 0x5C58;
                pub const m_safeTime: i64 = 0x180;
                pub const m_blindFire: i64 = 0x18C;
                pub const m_hasJoined: i64 = 0x52BC;
                pub const m_lookPitch: i64 = 0x5984;
                pub const m_pathIndex: i64 = 0x4F00;
                pub const m_stuckSpot: i64 = 0x5D88;
                pub const m_waitTimer: i64 = 0x4FE8;
                pub const m_zoomTimer: i64 = 0x5C88;
                pub const m_alertTimer: i64 = 0x1D0;
                pub const m_equipTimer: i64 = 0x5C78;
                pub const m_goalEntity: i64 = 0x5F0;
                pub const m_hurryTimer: i64 = 0x1B8;
                pub const m_isStopping: i64 = 0x5FC;
                pub const m_lastOrigin: i64 = 0x5DFC;
                pub const m_lookAtDesc: i64 = 0x5380;
                pub const m_lookAtSpot: i64 = 0x5360;
                pub const m_lookYawVel: i64 = 0x5990;
                pub const m_panicTimer: i64 = 0x200;
                pub const m_rogueTimer: i64 = 0x160;
                pub const m_sneakTimer: i64 = 0x1E8;
                pub const m_stillTimer: i64 = 0x600;
                pub const m_targetSpot: i64 = 0x5994;
                pub const m_taskEntity: i64 = 0x5D4;
                pub const m_avgVelCount: i64 = 0x5DF8;
                pub const m_avgVelIndex: i64 = 0x5DF4;
                pub const m_bIsSleeping: i64 = 0x5CC0;
                pub const m_combatRange: i64 = 0x154;
                pub const m_desiredTeam: i64 = 0x52B8;
                pub const m_eyePosition: i64 = 0x108;
                pub const m_isAttacking: i64 = 0x5CC;
                pub const m_isFollowing: i64 = 0x1A9;
                pub const m_lookUpAngle: i64 = 0x5350;
                pub const m_noiseSource: i64 = 0x5308;
                pub const m_politeTimer: i64 = 0x4F40;
                pub const m_repathTimer: i64 = 0x4F08;
                pub const m_wiggleTimer: i64 = 0x5D98;
                pub const m_bAllowActive: i64 = 0x1A8;
                pub const m_forwardAngle: i64 = 0x5354;
                pub const m_goalPosition: i64 = 0x5E4;
                pub const m_lastVictimID: i64 = 0x5C70;
                pub const m_lookPitchVel: i64 = 0x5988;
                pub const m_mustRunTimer: i64 = 0x4FD0;
                pub const m_radioSubject: i64 = 0x5E14;
                pub const m_diedLastRound: i64 = 0x17C;
                pub const m_isOpeningDoor: i64 = 0x5CD;
                pub const m_isRapidFiring: i64 = 0x5C75;
                pub const m_noisePosition: i64 = 0x52F0;
                pub const m_pathLadderEnd: i64 = 0x4F84;
                pub const m_radioPosition: i64 = 0x5E18;
                pub const m_surpriseTimer: i64 = 0x190;
                pub const m_avoidTimestamp: i64 = 0x5F8;
                pub const m_isEnemyVisible: i64 = 0x5A04;
                pub const m_lookAheadAngle: i64 = 0x534C;
                pub const m_noiseBendTimer: i64 = 0x5320;
                pub const m_noiseTimestamp: i64 = 0x5300;
                pub const m_stateTimestamp: i64 = 0x5C8;
                pub const m_stuckJumpTimer: i64 = 0x5DB0;
                pub const m_stuckTimestamp: i64 = 0x5D84;
                pub const m_targetSpotTime: i64 = 0x59D0;
                pub const m_enemyQueueCount: i64 = 0x5D81;
                pub const m_enemyQueueIndex: i64 = 0x5D80;
                pub const m_followTimestamp: i64 = 0x1B0;
                pub const m_isAimingAtEnemy: i64 = 0x5C74;
                pub const m_isLastEnemyDead: i64 = 0x5A28;
                pub const m_viewSteadyTimer: i64 = 0x5520;
                pub const m_aimFocusInterval: i64 = 0x59D8;
                pub const m_avoidFriendTimer: i64 = 0x4F20;
                pub const m_isFriendInTheWay: i64 = 0x4F38;
                pub const m_lookAtSpotAttack: i64 = 0x537D;
                pub const m_nearbyEnemyCount: i64 = 0x5A2C;
                pub const m_tossGrenadeTimer: i64 = 0x5538;
                pub const m_attackedTimestamp: i64 = 0x5C5C;
                pub const m_attentionInterval: i64 = 0x5C48;
                pub const m_bentNoisePosition: i64 = 0x5338;
                pub const m_isAvoidingGrenade: i64 = 0x5558;
                pub const m_lastEnemyPosition: i64 = 0x5A08;
                pub const m_nearbyFriendCount: i64 = 0x5C3C;
                pub const m_visibleEnemyParts: i64 = 0x5A05;
                pub const m_voiceEndTimestamp: i64 = 0x5E24;
                pub const m_aimFocusNextUpdate: i64 = 0x59DC;
                pub const m_approachPointCount: i64 = 0x5510;
                pub const m_hostageEscortCount: i64 = 0x52B0;
                pub const m_ignoreEnemiesTimer: i64 = 0x59E8;
                pub const m_lookAtSpotDuration: i64 = 0x5370;
                pub const m_spotCheckTimestamp: i64 = 0x5578;
                pub const m_targetSpotVelocity: i64 = 0x59A0;
                pub const m_allowAutoFollowTime: i64 = 0x1B4;
                pub const m_burnedByFlamesTimer: i64 = 0x5C60;
                pub const m_enemyDeathTimestamp: i64 = 0x5A20;
                pub const m_fireWeaponTimestamp: i64 = 0x5CA0;
                pub const m_isWaitingForHostage: i64 = 0x52BD;
                pub const m_lookAtSpotTimestamp: i64 = 0x5374;
                pub const m_noiseTravelDistance: i64 = 0x52FC;
                pub const m_peripheralTimestamp: i64 = 0x5388;
                pub const m_sawEnemySniperTimer: i64 = 0x5CC8;
                pub const m_targetSpotPredicted: i64 = 0x59AC;
                pub const m_travelDistancePhase: i64 = 0x5118;
                pub const m_waitForHostageTimer: i64 = 0x52D8;
                pub const m_areaEnteredTimestamp: i64 = 0x4F04;
                pub const m_closestVisibleFriend: i64 = 0x5C40;
                pub const m_friendDeathTimestamp: i64 = 0x5A24;
                pub const m_hasVisitedEnemySpawn: i64 = 0x5FD;
                pub const m_isEnemySniperVisible: i64 = 0x5CC1;
                pub const m_playerTravelDistance: i64 = 0x5018;
                pub const m_enemyQueueAttendIndex: i64 = 0x5D82;
                pub const m_isWaitingBehindFriend: i64 = 0x4F58;
                pub const m_lastSawEnemyTimestamp: i64 = 0x5A14;
                pub const m_bendNoisePositionValid: i64 = 0x5344;
                pub const m_checkedHidingSpotCount: i64 = 0x5980;
                pub const m_firstSawEnemyTimestamp: i64 = 0x5A18;
                pub const m_lastRadioSentTimestamp: i64 = 0x5E10;
                pub const m_lookAtSpotClearIfClose: i64 = 0x537C;
                pub const m_lookAroundStateTimestamp: i64 = 0x5348;
                pub const m_lookAtSpotAngleTolerance: i64 = 0x5378;
                pub const m_approachPointViewPosition: i64 = 0x5514;
                pub const m_closestVisibleHumanFriend: i64 = 0x5C44;
                pub const m_nextCleanupCheckTimestamp: i64 = 0x5DC8;
                pub const m_updateTravelDistanceTimer: i64 = 0x5000;
                pub const m_inhibitLookAroundTimestamp: i64 = 0x5358;
                pub const m_lastRadioRecievedTimestamp: i64 = 0x5E0C;
                pub const m_hostageEscortCountTimestamp: i64 = 0x52B4;
                pub const m_lastValidReactionQueueFrame: i64 = 0x5E30;
                pub const m_lookForWeaponsOnGroundTimer: i64 = 0x5CA8;
                pub const m_currentEnemyAcquireTimestamp: i64 = 0x5A1C;
                pub const m_inhibitWaitingForHostageTimer: i64 = 0x52C0;
                pub const m_bEyeAnglesUnderPathFinderControl: i64 = 0x610;
            };
            pub const CKnife = struct {
                pub const m_bFirstAttack: i64 = 0x1280;
            };
            pub const CWorld = struct {

            };
            pub const Extent = struct {
                pub const hi: i64 = 0xC;
                pub const lo: i64 = 0x0;
            };
            pub const CBtNode = struct {

            };
            pub const CCSTeam = struct {
                pub const m_iClanID: i64 = 0x800;
                pub const m_bSurrendered: i64 = 0x568;
                pub const m_scoreOvertime: i64 = 0x778;
                pub const m_scoreFirstHalf: i64 = 0x770;
                pub const m_szClanTeamname: i64 = 0x77C;
                pub const m_numMapVictories: i64 = 0x76C;
                pub const m_scoreSecondHalf: i64 = 0x774;
                pub const m_szTeamFlagImage: i64 = 0x804;
                pub const m_szTeamLogoImage: i64 = 0x80C;
                pub const m_szTeamMatchStat: i64 = 0x569;
                pub const m_iLastUpdateSentAt: i64 = 0x818;
                pub const m_flNextResourceTime: i64 = 0x814;
                pub const m_nShorthandedRoundBonusStartRound: i64 = 0x564;
                pub const m_nLastRecievedShorthandedRoundBonus: i64 = 0x560;
            };
            pub const CDEagle = struct {

            };
            pub const CEnvSky = struct {
                pub const m_bEnabled: i64 = 0x884;
                pub const m_nFogType: i64 = 0x870;
                pub const m_vTintColor: i64 = 0x864;
                pub const m_flFogMaxEnd: i64 = 0x880;
                pub const m_flFogMinEnd: i64 = 0x878;
                pub const m_hSkyMaterial: i64 = 0x850;
                pub const m_flFogMaxStart: i64 = 0x87C;
                pub const m_flFogMinStart: i64 = 0x874;
                pub const m_bStartDisabled: i64 = 0x860;
                pub const m_flBrightnessScale: i64 = 0x86C;
                pub const m_vTintColorLightingOnly: i64 = 0x868;
                pub const m_hSkyMaterialLightingOnly: i64 = 0x858;
            };
            pub const CShower = struct {
                pub const m_flSpeed: i64 = 0x850;
            };
            pub const CSprite = struct {
                pub const m_flFrame: i64 = 0x864;
                pub const m_flSpeed: i64 = 0x8BC;
                pub const m_flDieTime: i64 = 0x868;
                pub const m_flLastTime: i64 = 0x894;
                pub const m_flMaxFrame: i64 = 0x898;
                pub const m_flDestScale: i64 = 0x8A0;
                pub const m_nAttachment: i64 = 0x85C;
                pub const m_nBrightness: i64 = 0x878;
                pub const m_flStartScale: i64 = 0x89C;
                pub const m_nSpriteWidth: i64 = 0x8B4;
                pub const m_flSpriteScale: i64 = 0x880;
                pub const m_nSpriteHeight: i64 = 0x8B8;
                pub const m_flGlowProxySize: i64 = 0x88C;
                pub const m_flHDRColorScale: i64 = 0x890;
                pub const m_flScaleDuration: i64 = 0x884;
                pub const m_hSpriteMaterial: i64 = 0x850;
                pub const m_nDestBrightness: i64 = 0x8AC;
                pub const m_bWorldSpaceScale: i64 = 0x888;
                pub const m_flScaleTimeStart: i64 = 0x8A4;
                pub const m_nStartBrightness: i64 = 0x8A8;
                pub const m_flSpriteFramerate: i64 = 0x860;
                pub const m_hAttachedToEntity: i64 = 0x858;
                pub const m_flBrightnessDuration: i64 = 0x87C;
                pub const m_flBrightnessTimeStart: i64 = 0x8B0;
            };
            pub const CBuyZone = struct {
                pub const m_LegacyTeamNum: i64 = 0x9C8;
            };
            pub const CCSPlace = struct {
                pub const m_name: i64 = 0x868;
            };
            pub const CChicken = struct {
                pub const m_owner: i64 = 0x11AC;
                pub const m_leader: i64 = 0x11A8;
                pub const m_fleeFrom: i64 = 0x115C;
                pub const m_turnRate: i64 = 0x1158;
                pub const m_jumpTimer: i64 = 0x11D8;
                pub const m_isOnGround: i64 = 0x1128;
                pub const m_reuseTimer: i64 = 0x11C0;
                pub const m_repathTimer: i64 = 0x3200;
                pub const m_stuckAnchor: i64 = 0x1100;
                pub const m_updateTimer: i64 = 0x10E8;
                pub const m_vecPathGoal: i64 = 0x3298;
                pub const m_startleTimer: i64 = 0x1178;
                pub const m_activityTimer: i64 = 0x1140;
                pub const m_vFallVelocity: i64 = 0x112C;
                pub const m_vocalizeTimer: i64 = 0x1190;
                pub const m_flLastJumpTime: i64 = 0x11F0;
                pub const m_currentActivity: i64 = 0x113C;
                pub const m_desiredActivity: i64 = 0x1138;
                pub const m_AttributeManager: i64 = 0xCB0;
                pub const m_followMinuteTimer: i64 = 0x32A8;
                pub const m_BlockDirectionTimer: i64 = 0x32C8;
                pub const m_collisionStuckTimer: i64 = 0x1110;
                pub const m_bSpawnDyingParticles: i64 = 0x32E2;
                pub const m_moveRateThrottleTimer: i64 = 0x1160;
                pub const m_flActiveFollowStartTime: i64 = 0x32A4;
            };
            pub const CCredits = struct {
                pub const m_flLogoLength: i64 = 0x4C4;
                pub const m_OnCreditsDone: i64 = 0x4A8;
                pub const m_bRolledOutroCredits: i64 = 0x4C0;
            };
            pub const CEnvBeam = struct {
                pub const m_life: i64 = 0x910;
                pub const m_speed: i64 = 0x91C;
                pub const m_active: i64 = 0x8F0;
                pub const m_radius: i64 = 0x94C;
                pub const m_hFilter: i64 = 0x960;
                pub const m_iszDecal: i64 = 0x968;
                pub const m_restrike: i64 = 0x920;
                pub const m_TouchType: i64 = 0x950;
                pub const m_boltWidth: i64 = 0x914;
                pub const m_frameStart: i64 = 0x930;
                pub const m_iFilterName: i64 = 0x958;
                pub const m_iszEndEntity: i64 = 0x908;
                pub const m_iszSpriteName: i64 = 0x928;
                pub const m_spriteTexture: i64 = 0x8F8;
                pub const m_iszStartEntity: i64 = 0x900;
                pub const m_noiseAmplitude: i64 = 0x918;
                pub const m_vEndPointWorld: i64 = 0x934;
                pub const m_OnTouchedByEntity: i64 = 0x970;
                pub const m_vEndPointRelative: i64 = 0x940;
            };
            pub const CEnvFade = struct {
                pub const m_Duration: i64 = 0x4AC;
                pub const m_fadeColor: i64 = 0x4A8;
                pub const m_OnBeginFade: i64 = 0x4B8;
                pub const m_HoldDuration: i64 = 0x4B0;
            };
            pub const CEnvTilt = struct {
                pub const m_Radius: i64 = 0x4AC;
                pub const m_Duration: i64 = 0x4A8;
                pub const m_TiltTime: i64 = 0x4B0;
                pub const m_stopTime: i64 = 0x4B4;
            };
            pub const CEnvWind = struct {
                pub const m_EnvWindShared: i64 = 0x4A8;
            };
            pub const CGameEnd = struct {

            };
            pub const CHostage = struct {
                pub const m_vel: i64 = 0xBC0;
                pub const m_accel: i64 = 0xBFC;
                pub const m_leader: i64 = 0xBD4;
                pub const m_bRemove: i64 = 0xBBC;
                pub const m_OnRescued: i64 = 0xB80;
                pub const m_isRescued: i64 = 0xBCC;
                pub const m_isRunning: i64 = 0xC08;
                pub const m_jumpTimer: i64 = 0xC10;
                pub const m_isAdjusted: i64 = 0x2D1C;
                pub const m_lastLeader: i64 = 0xBD8;
                pub const m_nSpotRules: i64 = 0xBB0;
                pub const m_reuseTimer: i64 = 0xBE0;
                pub const m_hasBeenUsed: i64 = 0xBF8;
                pub const m_isCrouching: i64 = 0xC09;
                pub const m_repathTimer: i64 = 0x2C38;
                pub const m_wiggleTimer: i64 = 0x2D00;
                pub const m_fLastGrabTime: i64 = 0x2D24;
                pub const m_nHostageState: i64 = 0xBD0;
                pub const m_vecGrabbedPos: i64 = 0x2D34;
                pub const m_OnFirstPickedUp: i64 = 0xB50;
                pub const m_flDropStartTime: i64 = 0x2D48;
                pub const m_hHostageGrabber: i64 = 0x2D20;
                pub const m_jumpedThisFrame: i64 = 0xBCD;
                pub const m_inhibitDoorTimer: i64 = 0x2C50;
                pub const m_bHandsHaveBeenCut: i64 = 0x2D1D;
                pub const m_flGrabSuccessTime: i64 = 0x2D44;
                pub const m_flRescueStartTime: i64 = 0x2D40;
                pub const m_nPickupEventCount: i64 = 0x2D50;
                pub const m_vecSpawnGroundPos: i64 = 0x2D54;
                pub const m_OnHostageBeginGrab: i64 = 0xB38;
                pub const m_entitySpottedState: i64 = 0xB98;
                pub const m_isWaitingForLeader: i64 = 0xC28;
                pub const m_OnDroppedNotRescued: i64 = 0xB68;
                pub const m_nApproachRewardPayouts: i64 = 0x2D4C;
                pub const m_vecHostageResetPosition: i64 = 0x2D8C;
                pub const m_nHostageSpawnRandomFactor: i64 = 0xBB8;
                pub const m_inhibitObstacleAvoidanceTimer: i64 = 0x2CE0;
                pub const m_uiHostageSpawnExclusionGroupMask: i64 = 0xBB4;
                pub const m_vecPositionWhenStartedDroppingToGround: i64 = 0x2D28;
            };
            pub const CInferno = struct {
                pub const m_extent: i64 = 0x13A8;
                pub const m_startPos: i64 = 0x1408;
                pub const m_fireCount: i64 = 0x1190;
                pub const m_BurnNormal: i64 = 0xE90;
                pub const m_nMaxFlames: i64 = 0x1434;
                pub const m_activeTimer: i64 = 0x1420;
                pub const m_damageTimer: i64 = 0x13C0;
                pub const m_nInfernoType: i64 = 0x1194;
                pub const m_nSpreadCount: i64 = 0x1438;
                pub const m_firePositions: i64 = 0x850;
                pub const m_nFireLifetime: i64 = 0x119C;
                pub const m_bFireIsBurning: i64 = 0xE50;
                pub const m_splashVelocity: i64 = 0x13F0;
                pub const m_NextSpreadTimer: i64 = 0x1458;
                pub const m_damageRampTimer: i64 = 0x13D8;
                pub const m_fireSpawnOffset: i64 = 0x1430;
                pub const m_BookkeepingTimer: i64 = 0x1440;
                pub const m_bInPostEffectTime: i64 = 0x11A0;
                pub const m_bWasCreatedInSmoke: i64 = 0x11A1;
                pub const m_fireParentPositions: i64 = 0xB50;
                pub const m_nSourceItemDefIndex: i64 = 0x1470;
                pub const m_nFireEffectTickBegin: i64 = 0x1198;
                pub const m_InitialSplashVelocity: i64 = 0x13FC;
                pub const m_vecOriginalSpawnLocation: i64 = 0x1414;
            };
            pub const CInfoFan = struct {
                pub const m_flCurveDistRange: i64 = 0x4F0;
                pub const m_fFanForceMaxRadius: i64 = 0x4E8;
                pub const m_fFanForceMinRadius: i64 = 0x4EC;
                pub const m_FanForceCurveString: i64 = 0x4F8;
            };
            pub const CMapInfo = struct {
                pub const m_flBombRadius: i64 = 0x4AC;
                pub const m_iBuyingStatus: i64 = 0x4A8;
                pub const m_iHostageCount: i64 = 0x4BC;
                pub const m_bGPUCullSkybox: i64 = 0x4C2;
                pub const m_iPetPopulation: i64 = 0x4B0;
                pub const m_flEnvRainStrength: i64 = 0x4C4;
                pub const m_flEnvWetnessCoverage: i64 = 0x4D0;
                pub const m_bUseNormalSpawnsForDM: i64 = 0x4B4;
                pub const m_bRainTraceToSkyEnabled: i64 = 0x4C1;
                pub const m_flBotMaxVisionDistance: i64 = 0x4B8;
                pub const m_flEnvWetnessDryingAmount: i64 = 0x4D4;
                pub const m_bFadePlayerVisibilityFarZ: i64 = 0x4C0;
                pub const m_flEnvPuddleRippleStrength: i64 = 0x4C8;
                pub const m_flEnvPuddleRippleDirection: i64 = 0x4CC;
                pub const m_bDisableAutoGeneratedDMSpawns: i64 = 0x4B5;
            };
            pub const CMessage = struct {
                pub const m_Radius: i64 = 0x4B8;
                pub const m_sNoise: i64 = 0x4C0;
                pub const m_iszMessage: i64 = 0x4A8;
                pub const m_MessageVolume: i64 = 0x4B0;
                pub const m_OnShowMessage: i64 = 0x4C8;
                pub const m_MessageAttenuation: i64 = 0x4B4;
            };
            pub const CPhysBox = struct {
                pub const m_OnDamaged: i64 = 0x978;
                pub const m_OnAwakened: i64 = 0x990;
                pub const m_damageType: i64 = 0x928;
                pub const m_OnPlayerUse: i64 = 0x9C0;
                pub const m_OnStartTouch: i64 = 0x9D8;
                pub const m_iszInteractsAs: i64 = 0x960;
                pub const m_OnMotionEnabled: i64 = 0x9A8;
                pub const m_nHoverPoseFlags: i64 = 0x94E;
                pub const m_bEnableUseOutput: i64 = 0x94D;
                pub const m_bNotSolidToWorld: i64 = 0x94C;
                pub const m_iszInteractsWith: i64 = 0x968;
                pub const m_iszCollisionGroup: i64 = 0x958;
                pub const m_angHoverPoseAngles: i64 = 0x940;
                pub const m_vHoverPosePosition: i64 = 0x934;
                pub const m_iszInteractsExclude: i64 = 0x970;
                pub const m_damageToEnableMotion: i64 = 0x92C;
                pub const m_flForceToEnableMotion: i64 = 0x930;
                pub const m_flTouchOutputPerEntityDelay: i64 = 0x950;
            };
            pub const CRotDoor = struct {
                pub const m_bSolidBsp: i64 = 0xA58;
            };
            pub const IRagdoll = struct {

            };
            pub const PathCost = struct {
                pub const m_dangerFactor: i64 = 0x3C;
                pub const m_flAgentMaxClimb: i64 = 0x44;
                pub const m_damagingAreasPenaltyCost: i64 = 0x40;
            };
            pub const CBaseDoor = struct {
                pub const m_ls: i64 = 0x8F8;
                pub const m_OnOpen: i64 = 0x9F8;
                pub const m_OnClose: i64 = 0x9E0;
                pub const m_bLocked: i64 = 0x91A;
                pub const m_bNoNPCs: i64 = 0x91C;
                pub const m_flSpeed: i64 = 0xA4C;
                pub const m_bIsUsable: i64 = 0xA51;
                pub const m_bDoorGroup: i64 = 0x919;
                pub const m_isChaining: i64 = 0xA50;
                pub const m_ChainTarget: i64 = 0x948;
                pub const m_NoiseMoving: i64 = 0x928;
                pub const m_OnFullyOpen: i64 = 0x9C8;
                pub const m_OnLockedUse: i64 = 0xA10;
                pub const m_NoiseArrived: i64 = 0x930;
                pub const m_bForceClosed: i64 = 0x918;
                pub const m_OnFullyClosed: i64 = 0x9B0;
                pub const m_bIgnoreDebris: i64 = 0x91B;
                pub const m_flBlockDamage: i64 = 0x924;
                pub const m_bLoopMoveSound: i64 = 0xA28;
                pub const m_eSpawnPosition: i64 = 0x920;
                pub const m_OnBlockedClosing: i64 = 0x950;
                pub const m_OnBlockedOpening: i64 = 0x968;
                pub const m_NoiseMovingClosed: i64 = 0x938;
                pub const m_NoiseArrivedClosed: i64 = 0x940;
                pub const m_OnUnblockedClosing: i64 = 0x980;
                pub const m_OnUnblockedOpening: i64 = 0x998;
                pub const m_angMoveEntitySpace: i64 = 0x8E0;
                pub const m_bCreateNavObstacle: i64 = 0xA48;
                pub const m_vecMoveDirParentSpace: i64 = 0x8EC;
            };
            pub const CBaseProp = struct {
                pub const m_iShapeType: i64 = 0xA44;
                pub const m_bModelOverrodeBlockLOS: i64 = 0xA40;
                pub const m_mPreferredCatchTransform: i64 = 0xA50;
                pub const m_bConformToCollisionBounds: i64 = 0xA48;
            };
            pub const CCSSprite = struct {

            };
            pub const CEnvDecal = struct {
                pub const m_flDepth: i64 = 0x860;
                pub const m_flWidth: i64 = 0x858;
                pub const m_flHeight: i64 = 0x85C;
                pub const m_nRenderOrder: i64 = 0x864;
                pub const m_hDecalMaterial: i64 = 0x850;
                pub const m_bProjectOnWater: i64 = 0x86A;
                pub const m_bProjectOnWorld: i64 = 0x868;
                pub const m_flDepthSortBias: i64 = 0x86C;
                pub const m_bProjectOnCharacters: i64 = 0x869;
            };
            pub const CEnvLaser = struct {
                pub const m_pSprite: i64 = 0x8F8;
                pub const m_firePosition: i64 = 0x908;
                pub const m_flStartFrame: i64 = 0x914;
                pub const m_iszSpriteName: i64 = 0x900;
                pub const m_iszLaserTarget: i64 = 0x8F0;
            };
            pub const CEnvShake = struct {
                pub const m_Radius: i64 = 0x4BC;
                pub const m_Duration: i64 = 0x4B8;
                pub const m_maxForce: i64 = 0x4CC;
                pub const m_stopTime: i64 = 0x4C0;
                pub const m_Amplitude: i64 = 0x4B0;
                pub const m_Frequency: i64 = 0x4B4;
                pub const m_nextShake: i64 = 0x4C4;
                pub const m_currentAmp: i64 = 0x4C8;
                pub const m_limitToEntity: i64 = 0x4A8;
                pub const m_shakeCallback: i64 = 0x4E0;
                pub const m_pShakeController: i64 = 0x4D8;
            };
            pub const CEnvSpark = struct {
                pub const m_nType: i64 = 0x4B4;
                pub const m_OnSpark: i64 = 0x4B8;
                pub const m_flDelay: i64 = 0x4A8;
                pub const m_nMagnitude: i64 = 0x4AC;
                pub const m_nTrailLength: i64 = 0x4B0;
            };
            pub const CFishPool = struct {
                pub const m_fishes: i64 = 0x4D0;
                pub const m_maxRange: i64 = 0x4BC;
                pub const m_visTimer: i64 = 0x4E8;
                pub const m_fishCount: i64 = 0x4B8;
                pub const m_isDormant: i64 = 0x4C8;
                pub const m_swimDepth: i64 = 0x4C0;
                pub const m_waterLevel: i64 = 0x4C4;
            };
            pub const CFuncPlat = struct {
                pub const m_sNoise: i64 = 0x900;
                pub const m_flSpeed: i64 = 0x8F8;
            };
            pub const CFuncWall = struct {
                pub const m_nState: i64 = 0x850;
            };
            pub const CGameText = struct {
                pub const m_textParms: i64 = 0x868;
                pub const m_iszMessage: i64 = 0x860;
            };
            pub const CInfoData = struct {

            };
            pub const CItemSoda = struct {

            };
            pub const CNavFlags = struct {
                pub const m_Flags: i64 = 0x0;
            };
            pub const CPathNode = struct {
                pub const m_hPath: i64 = 0x4F0;
                pub const m_xWSPrevParent: i64 = 0x4D0;
                pub const m_vInTangentLocal: i64 = 0x4A8;
                pub const m_vOutTangentLocal: i64 = 0x4B4;
                pub const m_strPathNodeParameter: i64 = 0x4C8;
                pub const m_strParentPathUniqueID: i64 = 0x4C0;
            };
            pub const CPushable = struct {

            };
            pub const CRangeInt = struct {
                pub const m_pValue: i64 = 0x0;
            };
            pub const CSimTimer = struct {
                pub const m_flInterval: i64 = 0x8;
            };
            pub const CSkillInt = struct {
                pub const m_pValue: i64 = 0x0;
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
            pub const NavHull_t = struct {
                pub const m_nHullIdx: i64 = 0x0;
            };
            pub const ragdoll_t = struct {
                pub const list: i64 = 0x0;
                pub const unused: i64 = 0x49;
                pub const boneIndex: i64 = 0x30;
                pub const allowStretch: i64 = 0x48;
                pub const hierarchyJoints: i64 = 0x18;
            };
            pub const CBarnLight = struct {
                pub const m_nFog: i64 = 0x9D8;
                pub const m_Color: i64 = 0x858;
                pub const m_vShear: i64 = 0x98C;
                pub const m_flRange: i64 = 0x988;
                pub const m_flShape: i64 = 0x968;
                pub const m_flSkirt: i64 = 0x974;
                pub const m_flSoftX: i64 = 0x96C;
                pub const m_flSoftY: i64 = 0x970;
                pub const m_bEnabled: i64 = 0x850;
                pub const m_StyleEvent: i64 = 0x8E0;
                pub const m_flFogScale: i64 = 0x9E4;
                pub const m_nColorMode: i64 = 0x854;
                pub const m_VisClusters: i64 = 0xB18;
                pub const m_flSkirtNear: i64 = 0x978;
                pub const m_nFogShadows: i64 = 0x9E0;
                pub const m_vSizeParams: i64 = 0x97C;
                pub const m_flBrightness: i64 = 0x860;
                pub const m_hLightCookie: i64 = 0x960;
                pub const m_nBounceLight: i64 = 0x9BC;
                pub const m_nCastShadows: i64 = 0x9AC;
                pub const m_nDirectLight: i64 = 0x868;
                pub const m_flBounceScale: i64 = 0x9C0;
                pub const m_flFadeSizeEnd: i64 = 0x9EC;
                pub const m_flFogStrength: i64 = 0x9DC;
                pub const m_bContactShadow: i64 = 0x9B8;
                pub const m_flMinRoughness: i64 = 0x9C4;
                pub const m_nShadowMapSize: i64 = 0x9B0;
                pub const m_bTransmitAlways: i64 = 0xB15;
                pub const m_flFadeSizeStart: i64 = 0x9E8;
                pub const m_flLuminaireSize: i64 = 0x87C;
                pub const m_nLuminaireShape: i64 = 0x878;
                pub const m_nShadowPriority: i64 = 0x9B4;
                pub const m_vAlternateColor: i64 = 0x9C8;
                pub const m_LightStyleEvents: i64 = 0x8B0;
                pub const m_LightStyleString: i64 = 0x888;
                pub const m_bPvsModifyEntity: i64 = 0xB14;
                pub const m_LightStyleTargets: i64 = 0x8C8;
                pub const m_flBrightnessScale: i64 = 0x864;
                pub const m_nBakedShadowIndex: i64 = 0x86C;
                pub const m_nLightMapUniqueId: i64 = 0x874;
                pub const m_flColorTemperature: i64 = 0x85C;
                pub const m_nLightPathUniqueId: i64 = 0x870;
                pub const m_flShadowFadeSizeEnd: i64 = 0x9F4;
                pub const m_bForceShadowsEnabled: i64 = 0x9B9;
                pub const m_flLightStyleStartTime: i64 = 0x890;
                pub const m_flLuminaireAnisotropy: i64 = 0x880;
                pub const m_flShadowFadeSizeStart: i64 = 0x9F0;
                pub const m_nPrecomputedSubFrusta: i64 = 0xA38;
                pub const m_vPrecomputedOBBAngles: i64 = 0xA20;
                pub const m_vPrecomputedOBBExtent: i64 = 0xA2C;
                pub const m_vPrecomputedOBBOrigin: i64 = 0xA14;
                pub const m_vPrecomputedBoundsMaxs: i64 = 0xA08;
                pub const m_vPrecomputedBoundsMins: i64 = 0x9FC;
                pub const m_vPrecomputedOBBAngles0: i64 = 0xA48;
                pub const m_vPrecomputedOBBAngles1: i64 = 0xA6C;
                pub const m_vPrecomputedOBBAngles2: i64 = 0xA90;
                pub const m_vPrecomputedOBBAngles3: i64 = 0xAB4;
                pub const m_vPrecomputedOBBAngles4: i64 = 0xAD8;
                pub const m_vPrecomputedOBBAngles5: i64 = 0xAFC;
                pub const m_vPrecomputedOBBExtent0: i64 = 0xA54;
                pub const m_vPrecomputedOBBExtent1: i64 = 0xA78;
                pub const m_vPrecomputedOBBExtent2: i64 = 0xA9C;
                pub const m_vPrecomputedOBBExtent3: i64 = 0xAC0;
                pub const m_vPrecomputedOBBExtent4: i64 = 0xAE4;
                pub const m_vPrecomputedOBBExtent5: i64 = 0xB08;
                pub const m_vPrecomputedOBBOrigin0: i64 = 0xA3C;
                pub const m_vPrecomputedOBBOrigin1: i64 = 0xA60;
                pub const m_vPrecomputedOBBOrigin2: i64 = 0xA84;
                pub const m_vPrecomputedOBBOrigin3: i64 = 0xAA8;
                pub const m_vPrecomputedOBBOrigin4: i64 = 0xACC;
                pub const m_vPrecomputedOBBOrigin5: i64 = 0xAF0;
                pub const m_QueuedLightStyleStrings: i64 = 0x898;
                pub const m_bPrecomputedFieldsValid: i64 = 0x9F8;
                pub const m_nBakeSpecularToCubemaps: i64 = 0x998;
                pub const m_fAlternateColorBrightness: i64 = 0x9D4;
                pub const m_vBakeSpecularToCubemapsSize: i64 = 0x99C;
                pub const m_flBakeSpecularToCubemapsScale: i64 = 0x9A8;
            };
            pub const CBaseIssue = struct {
                pub const m_iNumNoVotes: i64 = 0x168;
                pub const m_iNumYesVotes: i64 = 0x164;
                pub const m_szTypeString: i64 = 0x20;
                pub const m_pVoteController: i64 = 0x170;
                pub const m_szDetailsString: i64 = 0x60;
                pub const m_iNumPotentialVotes: i64 = 0x16C;
            };
            pub const CBreakable = struct {
                pub const m_OnBreak: i64 = 0x8E0;
                pub const m_Material: i64 = 0x898;
                pub const m_hBreaker: i64 = 0x89C;
                pub const m_Explosion: i64 = 0x8A0;
                pub const m_iszPropData: i64 = 0x8B8;
                pub const m_OnStartDeath: i64 = 0x8C8;
                pub const m_iMinHealthDmg: i64 = 0x8B4;
                pub const m_iszSpawnObject: i64 = 0x8A8;
                pub const m_OnHealthChanged: i64 = 0x8F8;
                pub const m_PerformanceMode: i64 = 0x918;
                pub const m_flPressureDelay: i64 = 0x8B0;
                pub const m_hPhysicsAttacker: i64 = 0x91C;
                pub const m_impactEnergyScale: i64 = 0x8C0;
                pub const m_nOverrideBlockLOS: i64 = 0x8C4;
                pub const m_CPropDataComponent: i64 = 0x858;
                pub const m_flLastPhysicsInfluenceTime: i64 = 0x920;
            };
            pub const CCashStack = struct {
                pub const m_nCashStackValue: i64 = 0x850;
            };
            pub const CEnvGlobal = struct {
                pub const m_counter: i64 = 0x4D8;
                pub const m_outCounter: i64 = 0x4A8;
                pub const m_globalstate: i64 = 0x4C8;
                pub const m_triggermode: i64 = 0x4D0;
                pub const m_initialstate: i64 = 0x4D4;
            };
            pub const CEnvSplash = struct {
                pub const m_flScale: i64 = 0x4A8;
            };
            pub const CFilterLOS = struct {

            };
            pub const CFlashbang = struct {

            };
            pub const CFogVolume = struct {
                pub const m_fogName: i64 = 0x850;
                pub const m_bDisabled: i64 = 0x870;
                pub const m_postProcessName: i64 = 0x858;
                pub const m_bInFogVolumesList: i64 = 0x871;
                pub const m_colorCorrectionName: i64 = 0x860;
            };
            pub const CFuncBrush = struct {
                pub const m_bSolidBsp: i64 = 0x858;
                pub const m_iDisabled: i64 = 0x854;
                pub const m_iSolidity: i64 = 0x850;
                pub const m_bInvertExclusion: i64 = 0x868;
                pub const m_iszExcludedClass: i64 = 0x860;
                pub const m_bScriptedMovement: i64 = 0x869;
            };
            pub const CFuncMover = struct {
                pub const m_flT: i64 = 0x884;
                pub const m_OnStop: i64 = 0xA68;
                pub const m_OnStart: i64 = 0xA20;
                pub const m_flSpeed: i64 = 0x9F8;
                pub const m_OnStopped: i64 = 0xA80;
                pub const m_bIsMoving: i64 = 0x891;
                pub const m_bIsPaused: i64 = 0x9D0;
                pub const m_eMoveType: i64 = 0x874;
                pub const m_bQueueStop: i64 = 0xB21;
                pub const m_eSolidType: i64 = 0x890;
                pub const m_hPathMover: i64 = 0x858;
                pub const m_bStartAtEnd: i64 = 0x939;
                pub const m_hStopAtNode: i64 = 0x8BC;
                pub const m_iszPathName: i64 = 0x850;
                pub const m_OnNodePassed: i64 = 0x958;
                pub const m_bIsReversing: i64 = 0x878;
                pub const m_flBeginStopT: i64 = 0x8C8;
                pub const m_flStartSpeed: i64 = 0x87C;
                pub const m_hFollowMover: i64 = 0xABC;
                pub const m_OnMovementEnd: i64 = 0x920;
                pub const m_hFollowEntity: i64 = 0x9FC;
                pub const m_OnStartForward: i64 = 0xA38;
                pub const m_OnStartReverse: i64 = 0xA50;
                pub const m_bIgnoreEndNode: i64 = 0x870;
                pub const m_bStartedMoving: i64 = 0xA99;
                pub const m_flPathLocation: i64 = 0x880;
                pub const m_hPrevPathMover: i64 = 0x85C;
                pub const m_iszPathNodeEnd: i64 = 0x868;
                pub const m_bIsImGuiLogging: i64 = 0x9F4;
                pub const m_movementSummary: i64 = 0xB00;
                pub const m_vOffsetFromPath: i64 = 0xB30;
                pub const m_bQueueStopMoving: i64 = 0xB22;
                pub const m_flCurFollowSpeed: i64 = 0xA0C;
                pub const m_flFollowDistance: i64 = 0xA00;
                pub const m_flStopCurveScale: i64 = 0x8AC;
                pub const m_iszPathNodeStart: i64 = 0x860;
                pub const m_nTickMovementRan: i64 = 0xAFC;
                pub const m_eFollowConstraint: i64 = 0xAF0;
                pub const m_flLerpToPositionT: i64 = 0x994;
                pub const m_flStartCurveScale: i64 = 0x8A8;
                pub const m_nCurrentNodeIndex: i64 = 0x888;
                pub const m_eOrientationUpdate: i64 = 0x944;
                pub const m_flCurFollowEntityT: i64 = 0xA08;
                pub const m_flFollowMoverRatio: i64 = 0xAD4;
                pub const m_flFollowMoverSpeed: i64 = 0xAF4;
                pub const m_flTimeMovementStop: i64 = 0x8B8;
                pub const m_nPreviousNodeIndex: i64 = 0x88C;
                pub const m_flPathLocationStart: i64 = 0x8C4;
                pub const m_flTimeMovementStart: i64 = 0x8B4;
                pub const m_flTransitionSourceT: i64 = 0x9A0;
                pub const m_iszFollowEntityName: i64 = 0xAC0;
                pub const m_iszLoopForwardSound: i64 = 0x8D8;
                pub const m_iszLoopReverseSound: i64 = 0x8F0;
                pub const m_iszStopForwardSound: i64 = 0x8E0;
                pub const m_iszStopReverseSound: i64 = 0x8F8;
                pub const m_bQueueSetupPathMover: i64 = 0xB23;
                pub const m_bStartAtClosestPoint: i64 = 0x938;
                pub const m_ePathRebuildStrategy: i64 = 0xB24;
                pub const m_flFollowMinimumSpeed: i64 = 0xA04;
                pub const m_iszStartForwardSound: i64 = 0x8D0;
                pub const m_iszStartReverseSound: i64 = 0x8E8;
                pub const m_vLerpToNewPosStartWS: i64 = 0x984;
                pub const m_bCreateMovableNavMesh: i64 = 0x954;
                pub const m_flFollowMoverDistance: i64 = 0xAD0;
                pub const m_flFollowMoverVelocity: i64 = 0xAF8;
                pub const m_flTimeToReachMaxSpeed: i64 = 0x894;
                pub const m_hTransitionSourcePath: i64 = 0x99C;
                pub const m_bIsImGuiEntTextLogging: i64 = 0x9F5;
                pub const m_eFollowEntityDirection: i64 = 0xAB8;
                pub const m_flLerpToPositionDeltaT: i64 = 0x998;
                pub const m_flTimeToReachZeroSpeed: i64 = 0x89C;
                pub const m_hOrientationFaceEntity: i64 = 0xA18;
                pub const m_nDelayedTeleportToNode: i64 = 0x9F0;
                pub const m_bNextNodeReturnsCurrent: i64 = 0xA98;
                pub const m_flLerpToPositionTargetT: i64 = 0x990;
                pub const m_hOrientationMatchEntity: i64 = 0x980;
                pub const m_OnLerpToPositionComplete: i64 = 0x9B8;
                pub const m_bStopFromBeginStopTarget: i64 = 0xB20;
                pub const m_bStoppedDuringTransition: i64 = 0x9B0;
                pub const m_eFindFollowMoverStrategy: i64 = 0xB28;
                pub const m_iszFollowMoverEntityName: i64 = 0xAC8;
                pub const m_flDistanceToReachMaxSpeed: i64 = 0x898;
                pub const m_flPathLocationToBeginStop: i64 = 0x8C0;
                pub const m_bCreateMovableSurfaceGraph: i64 = 0x955;
                pub const m_bDisableDecelerationToStop: i64 = 0xB2C;
                pub const m_flDistanceToReachZeroSpeed: i64 = 0x8B0;
                pub const m_vecFollowMoverCouplerRange: i64 = 0xAE4;
                pub const m_bStartFollowingClosestMover: i64 = 0x93A;
                pub const m_flFollowMoverSpringStrength: i64 = 0xADC;
                pub const m_iszArriveAtDestinationSound: i64 = 0x900;
                pub const m_flTimeStartOrientationChange: i64 = 0x948;
                pub const m_qTransitionSourceOrientation: i64 = 0x9E0;
                pub const m_strOrientationFaceEntityName: i64 = 0xA10;
                pub const m_bFollowConstraintsInitialized: i64 = 0xAEC;
                pub const m_eTransitionedToPathNodeAction: i64 = 0x9D4;
                pub const m_flTimeToBlendToNewOrientation: i64 = 0x94C;
                pub const m_iszOrientationMatchEntityName: i64 = 0x978;
                pub const m_flTransitionSourcePathLocation: i64 = 0x9A4;
                pub const m_nFollowMoverConstraintPriority: i64 = 0xAE0;
                pub const m_flFollowMoverCalculatedDistance: i64 = 0xAD8;
                pub const m_iszTransitionSourcePathNodeStart: i64 = 0x9A8;
                pub const m_flComputedDistanceToReachMaxSpeed: i64 = 0x8A0;
                pub const m_flComputedDistanceToReachZeroSpeed: i64 = 0x8A4;
                pub const m_flDurationBlendToNewOrientationRan: i64 = 0x950;
                pub const m_bAllowMovableNavMeshDockingOnEntireEntity: i64 = 0x956;
                pub const m_flStartFollowingClosestMoverWhenWithinDistance: i64 = 0x93C;
                pub const m_flStartFollowingClosestMoverWhenOutsideDistance: i64 = 0x940;
            };
            pub const CFuncTrain = struct {
                pub const m_hEnemy: i64 = 0x900;
                pub const m_flSpeed: i64 = 0x918;
                pub const m_activated: i64 = 0x8FC;
                pub const m_flBlockDamage: i64 = 0x904;
                pub const m_iszLastTarget: i64 = 0x910;
                pub const m_hCurrentTarget: i64 = 0x8F8;
                pub const m_flNextBlockTime: i64 = 0x908;
            };
            pub const CFuncWater = struct {
                pub const m_BuoyancyHelper: i64 = 0x850;
            };
            pub const CGameMoney = struct {
                pub const m_nMoney: i64 = 0x890;
                pub const m_OnMoneySpent: i64 = 0x860;
                pub const m_strAwardText: i64 = 0x898;
                pub const m_OnMoneySpentFail: i64 = 0x878;
            };
            pub const CGameRules = struct {
                pub const m_bGamePaused: i64 = 0xC8;
                pub const m_nQuestPhase: i64 = 0xB0;
                pub const m_szQuestName: i64 = 0x30;
                pub const __m_pChainEntity: i64 = 0x8;
                pub const m_nLastMatchTime: i64 = 0xB4;
                pub const m_nPauseStartTick: i64 = 0xC4;
                pub const m_nTotalPausedTicks: i64 = 0xC0;
                pub const m_nLastMatchTime_MatchID64: i64 = 0xB8;
            };
            pub const CGunTarget = struct {
                pub const m_on: i64 = 0x8D4;
                pub const m_OnDeath: i64 = 0x8E0;
                pub const m_flSpeed: i64 = 0x8D0;
                pub const m_hTargetEnt: i64 = 0x8D8;
            };
            pub const CHEGrenade = struct {

            };
            pub const CLogicAuto = struct {
                pub const m_OnNewGame: i64 = 0x4D8;
                pub const m_OnLoadGame: i64 = 0x4F0;
                pub const m_OnMapSpawn: i64 = 0x4A8;
                pub const m_OnVREnabled: i64 = 0x568;
                pub const m_globalstate: i64 = 0x598;
                pub const m_OnMultiNewMap: i64 = 0x538;
                pub const m_OnDemoMapSpawn: i64 = 0x4C0;
                pub const m_OnVRNotEnabled: i64 = 0x580;
                pub const m_OnBackgroundMap: i64 = 0x520;
                pub const m_OnMapTransition: i64 = 0x508;
                pub const m_OnMultiNewRound: i64 = 0x550;
            };
            pub const CLogicCase = struct {
                pub const m_nCase: i64 = 0x4A8;
                pub const m_OnCase: i64 = 0x5D0;
                pub const m_OnDefault: i64 = 0x8D0;
                pub const m_nShuffleCases: i64 = 0x5A8;
                pub const m_nLastShuffleCase: i64 = 0x5AC;
                pub const m_uchShuffleCaseMap: i64 = 0x5B0;
            };
            pub const CMathRemap = struct {
                pub const m_flOut1: i64 = 0x4B0;
                pub const m_flOut2: i64 = 0x4B4;
                pub const m_flInMax: i64 = 0x4AC;
                pub const m_flInMin: i64 = 0x4A8;
                pub const m_OutValue: i64 = 0x4C0;
                pub const m_bEnabled: i64 = 0x4BC;
                pub const m_flOldInValue: i64 = 0x4B8;
                pub const m_OnFellBelowMax: i64 = 0x528;
                pub const m_OnFellBelowMin: i64 = 0x510;
                pub const m_OnRoseAboveMax: i64 = 0x4F8;
                pub const m_OnRoseAboveMin: i64 = 0x4E0;
            };
            pub const CNavVolume = struct {

            };
            pub const COmniLight = struct {
                pub const m_bShowLight: i64 = 0xB40;
                pub const m_flInnerAngle: i64 = 0xB38;
                pub const m_flOuterAngle: i64 = 0xB3C;
            };
            pub const CPathMover = struct {
                pub const m_vecMovers: i64 = 0x600;
                pub const m_vecSpawners: i64 = 0x618;
                pub const m_hMoverRouter: i64 = 0x638;
                pub const m_flSampleSpacing: i64 = 0x648;
                pub const m_iszMoverRouterName: i64 = 0x640;
                pub const m_iszMoverSpawnerName: i64 = 0x630;
            };
            pub const CPathTrack = struct {
                pub const m_pnext: i64 = 0x4A8;
                pub const m_OnPass: i64 = 0x4D0;
                pub const m_length: i64 = 0x4BC;
                pub const m_altName: i64 = 0x4C0;
                pub const m_flSpeed: i64 = 0x4B4;
                pub const m_flRadius: i64 = 0x4B8;
                pub const m_nIterVal: i64 = 0x4C8;
                pub const m_paltpath: i64 = 0x4B0;
                pub const m_pprevious: i64 = 0x4AC;
                pub const m_eOrientationType: i64 = 0x4CC;
            };
            pub const CPhysFixed = struct {
                pub const m_sBoneName1: i64 = 0x520;
                pub const m_sBoneName2: i64 = 0x528;
                pub const m_flLinearFrequency: i64 = 0x508;
                pub const m_flAngularFrequency: i64 = 0x510;
                pub const m_flLinearDampingRatio: i64 = 0x50C;
                pub const m_flAngularDampingRatio: i64 = 0x514;
                pub const m_bEnableLinearConstraint: i64 = 0x518;
                pub const m_bEnableAngularConstraint: i64 = 0x519;
            };
            pub const CPhysForce = struct {
                pub const m_force: i64 = 0x4B8;
                pub const m_forceTime: i64 = 0x4BC;
                pub const m_integrator: i64 = 0x4C8;
                pub const m_nameAttach: i64 = 0x4B0;
                pub const m_pController: i64 = 0x4A8;
                pub const m_wasRestored: i64 = 0x4C4;
                pub const m_attachedObject: i64 = 0x4C0;
            };
            pub const CPhysHinge = struct {
                pub const m_hinge: i64 = 0x5DC;
                pub const m_soundInfo: i64 = 0x510;
                pub const m_bAtMaxLimit: i64 = 0x5D9;
                pub const m_bAtMinLimit: i64 = 0x5D8;
                pub const m_OnStopMoving: i64 = 0x660;
                pub const m_bIsAxisLocal: i64 = 0x624;
                pub const m_flAngleSpeed: i64 = 0x63C;
                pub const m_OnStartMoving: i64 = 0x648;
                pub const m_flMaxRotation: i64 = 0x62C;
                pub const m_flMinRotation: i64 = 0x628;
                pub const m_hingeFriction: i64 = 0x61C;
                pub const m_systemLoadScale: i64 = 0x620;
                pub const m_flMotorFrequency: i64 = 0x634;
                pub const m_flInitialRotation: i64 = 0x630;
                pub const m_flMotorDampingRatio: i64 = 0x638;
                pub const m_NotifyMaxLimitReached: i64 = 0x5C0;
                pub const m_NotifyMinLimitReached: i64 = 0x5A8;
                pub const m_flAngleSpeedThreshold: i64 = 0x640;
                pub const m_flLimitsDebugVisRotation: i64 = 0x644;
            };
            pub const CPhysMotor = struct {
                pub const m_motor: i64 = 0x4F0;
                pub const m_spinUp: i64 = 0x4C0;
                pub const m_spinDown: i64 = 0x4C4;
                pub const m_nameAnchor: i64 = 0x4B0;
                pub const m_nameAttach: i64 = 0x4A8;
                pub const m_pMotorJoint: i64 = 0x4E8;
                pub const m_flTargetSpeed: i64 = 0x4D8;
                pub const m_flTorqueScale: i64 = 0x4D4;
                pub const m_hAnchorObject: i64 = 0x4BC;
                pub const m_flMotorFriction: i64 = 0x4C8;
                pub const m_hAttachedObject: i64 = 0x4B8;
                pub const m_pFixedWorldBody: i64 = 0x4E0;
                pub const m_angularAcceleration: i64 = 0x4D0;
                pub const m_additionalAcceleration: i64 = 0x4CC;
                pub const m_flSpeedWhenSpinUpOrSpinDownStarted: i64 = 0x4DC;
            };
            pub const CPlantedC4 = struct {
                pub const m_flC4Blow: i64 = 0xA9C;
                pub const m_nBombSite: i64 = 0xAA0;
                pub const m_nSpotRules: i64 = 0xF50;
                pub const m_bBombDefused: i64 = 0xF55;
                pub const m_bBombTicking: i64 = 0xA98;
                pub const m_bHasExploded: i64 = 0xF54;
                pub const m_hBombDefuser: i64 = 0xF74;
                pub const m_OnBombDefused: i64 = 0xEE8;
                pub const m_bBeingDefused: i64 = 0xF5C;
                pub const m_flTimerLength: i64 = 0xF58;
                pub const m_flDefuseLength: i64 = 0xF6C;
                pub const m_fLastDefuseTime: i64 = 0xF64;
                pub const m_AttributeManager: i64 = 0xAB0;
                pub const m_bCannotBeDefused: i64 = 0xF30;
                pub const m_bVoiceAlertFired: i64 = 0xF7C;
                pub const m_iProgressBarTime: i64 = 0xF78;
                pub const m_OnBombBeginDefuse: i64 = 0xF00;
                pub const m_bVoiceAlertPlayed: i64 = 0xF7D;
                pub const m_flDefuseCountDown: i64 = 0xF70;
                pub const m_flNextBotBeepTime: i64 = 0xF84;
                pub const m_entitySpottedState: i64 = 0xF38;
                pub const m_OnBombDefuseAborted: i64 = 0xF18;
                pub const m_angCatchUpToPlayerEye: i64 = 0xF8C;
                pub const m_nSourceSoundscapeHash: i64 = 0xAA4;
                pub const m_bTrainingPlacedByPlayer: i64 = 0xF56;
                pub const m_flLastSpinDetectionTime: i64 = 0xF98;
                pub const m_bAbortDetonationBecauseWorldIsFrozen: i64 = 0xAA8;
            };
            pub const CPointHurt = struct {
                pub const m_flDelay: i64 = 0x4B4;
                pub const m_nDamage: i64 = 0x4A8;
                pub const m_flRadius: i64 = 0x4B0;
                pub const m_strTarget: i64 = 0x4B8;
                pub const m_pActivator: i64 = 0x4C0;
                pub const m_bitsDamageType: i64 = 0x4AC;
            };
            pub const CPointPush = struct {
                pub const m_hFilter: i64 = 0x4C8;
                pub const m_bEnabled: i64 = 0x4A8;
                pub const m_flRadius: i64 = 0x4B0;
                pub const m_flMagnitude: i64 = 0x4AC;
                pub const m_flInnerRadius: i64 = 0x4B4;
                pub const m_iszFilterName: i64 = 0x4C0;
                pub const m_flConeOfInfluence: i64 = 0x4B8;
            };
            pub const CRectLight = struct {
                pub const m_bShowLight: i64 = 0xB38;
            };
            pub const CRotButton = struct {

            };
            pub const CSkyCamera = struct {
                pub const m_pNext: i64 = 0x540;
                pub const m_bUseAngles: i64 = 0x53C;
                pub const m_skyboxData: i64 = 0x4A8;
                pub const m_skyboxSlotToken: i64 = 0x538;
            };
            pub const CStopwatch = struct {
                pub const m_flInterval: i64 = 0xC;
            };
            pub const CWeaponAWP = struct {

            };
            pub const CWeaponAug = struct {

            };
            pub const CWeaponMP7 = struct {

            };
            pub const CWeaponMP9 = struct {

            };
            pub const CWeaponP90 = struct {

            };
            pub const SpawnPoint = struct {
                pub const m_nType: i64 = 0x4B0;
                pub const m_bEnabled: i64 = 0x4AC;
                pub const m_iPriority: i64 = 0x4A8;
            };
            pub const lerpdata_t = struct {
                pub const m_hEnt: i64 = 0x0;
                pub const m_MoveType: i64 = 0x4;
                pub const m_nFXIndex: i64 = 0x30;
                pub const m_qStartRot: i64 = 0x20;
                pub const m_flStartTime: i64 = 0x8;
                pub const m_vecStartOrigin: i64 = 0xC;
            };
            pub const AmmoIndex_t = struct {
                pub const m_Value: i64 = 0x0;
            };
            pub const CBaseButton = struct {
                pub const m_ls: i64 = 0x8E0;
                pub const m_OnIn: i64 = 0x978;
                pub const m_OnOut: i64 = 0x990;
                pub const m_nState: i64 = 0x9A8;
                pub const m_usable: i64 = 0x9C4;
                pub const m_bLocked: i64 = 0x920;
                pub const m_flSpeed: i64 = 0x924;
                pub const m_OnDamaged: i64 = 0x930;
                pub const m_OnPressed: i64 = 0x948;
                pub const m_bDisabled: i64 = 0x921;
                pub const m_bSolidBsp: i64 = 0x92C;
                pub const m_fRotating: i64 = 0x8DD;
                pub const m_sUseSound: i64 = 0x900;
                pub const m_glowEntity: i64 = 0x9C0;
                pub const m_OnUseLocked: i64 = 0x960;
                pub const m_fStayPushed: i64 = 0x8DC;
                pub const m_hConstraint: i64 = 0x9AC;
                pub const m_sGlowEntity: i64 = 0x9B8;
                pub const m_sLockedSound: i64 = 0x908;
                pub const m_szDisplayText: i64 = 0x9C8;
                pub const m_sUnlockedSound: i64 = 0x910;
                pub const m_flUseLockedTime: i64 = 0x928;
                pub const m_bForceNpcExclude: i64 = 0x9B4;
                pub const m_hConstraintParent: i64 = 0x9B0;
                pub const m_angMoveEntitySpace: i64 = 0x8D0;
                pub const m_sOverrideAnticipationName: i64 = 0x918;
            };
            pub const CBaseEntity = struct {
                pub const m_think: i64 = 0x288;
                pub const m_fFlags: i64 = 0x388;
                pub const m_pfnUse: i64 = 0x2B8;
                pub const m_target: i64 = 0x300;
                pub const m_OnUser1: i64 = 0x418;
                pub const m_OnUser2: i64 = 0x430;
                pub const m_OnUser3: i64 = 0x448;
                pub const m_OnUser4: i64 = 0x460;
                pub const m_iEFlags: i64 = 0x414;
                pub const m_iHealth: i64 = 0x2D0;
                pub const m_MoveType: i64 = 0x2F3;
                pub const m_OnKilled: i64 = 0x370;
                pub const m_fEffects: i64 = 0x3E8;
                pub const m_iTeamNum: i64 = 0x344;
                pub const m_pBlocker: i64 = 0x490;
                pub const m_pfnTouch: i64 = 0x2B0;
                pub const m_lifeState: i64 = 0x2D8;
                pub const m_flAnimTime: i64 = 0x328;
                pub const m_flFriction: i64 = 0x3F4;
                pub const m_iMaxHealth: i64 = 0x2D4;
                pub const m_nBloodType: i64 = 0x49C;
                pub const m_nWaterType: i64 = 0x412;
                pub const m_pCollision: i64 = 0x3D8;
                pub const m_pfnBlocked: i64 = 0x2C0;
                pub const m_spawnflags: i64 = 0x360;
                pub const m_MoveCollide: i64 = 0x2F2;
                pub const m_flLocalTime: i64 = 0x494;
                pub const m_flTimeScale: i64 = 0x400;
                pub const m_iGlobalname: i64 = 0x348;
                pub const m_nSlimeTouch: i64 = 0x2F7;
                pub const m_nSubclassID: i64 = 0x31C;
                pub const m_nWaterTouch: i64 = 0x2F6;
                pub const m_pfnMoveDone: i64 = 0x2C8;
                pub const m_vecVelocity: i64 = 0x398;
                pub const m_bTakesDamage: i64 = 0x2E0;
                pub const m_flCreateTime: i64 = 0x330;
                pub const m_flElasticity: i64 = 0x3F8;
                pub const m_flWaterLevel: i64 = 0x404;
                pub const m_hOwnerEntity: i64 = 0x3E4;
                pub const m_hDamageFilter: i64 = 0x308;
                pub const m_hEffectEntity: i64 = 0x3E0;
                pub const m_hGroundEntity: i64 = 0x3EC;
                pub const m_isSteadyState: i64 = 0x278;
                pub const m_nPlatformType: i64 = 0x2F0;
                pub const m_CBodyComponent: i64 = 0x30;
                pub const m_bLagCompensate: i64 = 0x48D;
                pub const m_flGravityScale: i64 = 0x3FC;
                pub const m_flMoveDoneTime: i64 = 0x318;
                pub const m_iSentToClients: i64 = 0x350;
                pub const m_nLastThinkTick: i64 = 0x264;
                pub const m_nNextThinkTick: i64 = 0x364;
                pub const m_nPushEnumCount: i64 = 0x3D4;
                pub const m_vecAbsVelocity: i64 = 0x38C;
                pub const m_vecAngVelocity: i64 = 0x480;
                pub const m_aThinkFunctions: i64 = 0x248;
                pub const m_iInitialTeamNum: i64 = 0x478;
                pub const m_nActualMoveType: i64 = 0x2F5;
                pub const m_nSimulationTick: i64 = 0x368;
                pub const m_sUniqueHammerID: i64 = 0x358;
                pub const m_vecBaseVelocity: i64 = 0x3C8;
                pub const m_ResponseContexts: i64 = 0x290;
                pub const m_bGravityDisabled: i64 = 0x408;
                pub const m_flSimulationTime: i64 = 0x32C;
                pub const m_nGroundBodyIndex: i64 = 0x3F0;
                pub const m_nTakeDamageFlags: i64 = 0x2E8;
                pub const m_lastNetworkChange: i64 = 0x280;
                pub const m_bAnimatedEveryTick: i64 = 0x409;
                pub const m_bClientSideRagdoll: i64 = 0x334;
                pub const m_iszResponseContext: i64 = 0x2A8;
                pub const m_bDisableLowViolence: i64 = 0x411;
                pub const m_bRestoreInHierarchy: i64 = 0x2F8;
                pub const m_flDamageAccumulator: i64 = 0x2DC;
                pub const m_iszDamageFilterName: i64 = 0x310;
                pub const m_pPulseGraphInstance: i64 = 0x4A0;
                pub const m_flActualGravityScale: i64 = 0x40C;
                pub const m_flNavIgnoreUntilTime: i64 = 0x47C;
                pub const m_iCurrentThinkContext: i64 = 0x260;
                pub const m_ubInterpolationFrame: i64 = 0x335;
                pub const m_bDisabledContextThinks: i64 = 0x268;
                pub const m_nPreviouslySetMoveType: i64 = 0x2F4;
                pub const m_vPrevVPhysicsUpdatePos: i64 = 0x338;
                pub const m_NetworkTransmitComponent: i64 = 0x38;
                pub const m_bGravityActuallyDisabled: i64 = 0x410;
                pub const m_flVPhysicsUpdateLocalTime: i64 = 0x498;
                pub const m_bNetworkQuantizeOriginAndAngles: i64 = 0x48C;
            };
            pub const CBaseFilter = struct {
                pub const m_OnFail: i64 = 0x4C8;
                pub const m_OnPass: i64 = 0x4B0;
                pub const m_bNegated: i64 = 0x4A8;
            };
            pub const CBaseToggle = struct {
                pub const m_flLip: i64 = 0x85C;
                pub const m_flWait: i64 = 0x858;
                pub const m_sMaster: i64 = 0x8C8;
                pub const m_flHeight: i64 = 0x8A0;
                pub const m_vecAngle1: i64 = 0x888;
                pub const m_vecAngle2: i64 = 0x894;
                pub const m_hActivator: i64 = 0x8A4;
                pub const m_vecMoveAng: i64 = 0x87C;
                pub const m_movementType: i64 = 0x8C0;
                pub const m_toggle_state: i64 = 0x850;
                pub const m_vecFinalDest: i64 = 0x8A8;
                pub const m_vecPosition1: i64 = 0x864;
                pub const m_vecPosition2: i64 = 0x870;
                pub const m_vecFinalAngle: i64 = 0x8B4;
                pub const m_flMoveDistance: i64 = 0x854;
                pub const m_bAlwaysFireBlockedOutputs: i64 = 0x860;
            };
            pub const CBombTarget = struct {
                pub const m_bIsBombSiteB: i64 = 0xA10;
                pub const m_OnBombDefused: i64 = 0x9F8;
                pub const m_OnBombExplode: i64 = 0x9C8;
                pub const m_OnBombPlanted: i64 = 0x9E0;
                pub const m_szMountTarget: i64 = 0xA18;
                pub const m_hInstructorHint: i64 = 0xA20;
                pub const m_bBombPlantedHere: i64 = 0xA12;
                pub const m_bIsHeistBombTarget: i64 = 0xA11;
                pub const m_nBombSiteDesignation: i64 = 0xA24;
            };
            pub const CEconEntity = struct {
                pub const m_hOldProvidee: i64 = 0xEA8;
                pub const m_nFallbackSeed: i64 = 0xE9C;
                pub const m_flFallbackWear: i64 = 0xEA0;
                pub const m_iOldOwnerClass: i64 = 0xEAC;
                pub const m_AttributeManager: i64 = 0xA58;
                pub const m_nFallbackPaintKit: i64 = 0xE98;
                pub const m_nFallbackStatTrak: i64 = 0xEA4;
                pub const m_OriginalOwnerXuidLow: i64 = 0xE90;
                pub const m_OriginalOwnerXuidHigh: i64 = 0xE94;
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
            pub const CEnvCubemap = struct {
                pub const m_Entity_bEnabled: i64 = 0x588;
                pub const m_Entity_bMoveable: i64 = 0x550;
                pub const m_Entity_nPriority: i64 = 0x55C;
                pub const m_Entity_nHandshake: i64 = 0x554;
                pub const m_Entity_bDefaultEnvMap: i64 = 0x575;
                pub const m_Entity_bIndoorCubeMap: i64 = 0x577;
                pub const m_Entity_bStartDisabled: i64 = 0x574;
                pub const m_Entity_flDiffuseScale: i64 = 0x570;
                pub const m_Entity_flEdgeFadeDist: i64 = 0x560;
                pub const m_Entity_vEdgeFadeDists: i64 = 0x564;
                pub const m_Entity_hCubemapTexture: i64 = 0x528;
                pub const m_Entity_vBoxProjectMaxs: i64 = 0x544;
                pub const m_Entity_vBoxProjectMins: i64 = 0x538;
                pub const m_Entity_flInfluenceRadius: i64 = 0x534;
                pub const m_Entity_bDefaultSpecEnvMap: i64 = 0x576;
                pub const m_Entity_bCustomCubemapTexture: i64 = 0x530;
                pub const m_Entity_nEnvCubeMapArrayIndex: i64 = 0x558;
                pub const m_Entity_bCopyDiffuseFromDefaultCubemap: i64 = 0x578;
            };
            pub const CEnvHudHint = struct {
                pub const m_iszMessage: i64 = 0x4A8;
            };
            pub const CFilterName = struct {
                pub const m_iFilterName: i64 = 0x4E0;
            };
            pub const CFilterTeam = struct {
                pub const m_iFilterTeam: i64 = 0x4E0;
            };
            pub const CFogTrigger = struct {
                pub const m_fog: i64 = 0x9C8;
            };
            pub const CFuncLadder = struct {
                pub const m_Dismounts: i64 = 0x860;
                pub const m_bDisabled: i64 = 0x8A0;
                pub const m_bHasSlack: i64 = 0x8A2;
                pub const m_bFakeLadder: i64 = 0x8A1;
                pub const m_vecLocalTop: i64 = 0x878;
                pub const m_vecLadderDir: i64 = 0x850;
                pub const m_flAutoRideSpeed: i64 = 0x89C;
                pub const m_surfacePropName: i64 = 0x8A8;
                pub const m_OnPlayerGotOnLadder: i64 = 0x8B0;
                pub const m_OnPlayerGotOffLadder: i64 = 0x8C8;
                pub const m_vecPlayerMountPositionTop: i64 = 0x884;
                pub const m_vecPlayerMountPositionBottom: i64 = 0x890;
            };
            pub const CHandleTest = struct {
                pub const m_Handle: i64 = 0x4A8;
                pub const m_bSendHandle: i64 = 0x4AC;
            };
            pub const CInfoTarget = struct {

            };
            pub const CItemKevlar = struct {

            };
            pub const CLogicRelay = struct {
                pub const m_OnSpawn: i64 = 0x4A8;
                pub const m_OnTrigger: i64 = 0x4C0;
                pub const m_bDisabled: i64 = 0x4D8;
                pub const m_bTriggerOnce: i64 = 0x4DA;
                pub const m_bFastRetrigger: i64 = 0x4DB;
                pub const m_bWaitForRefire: i64 = 0x4D9;
                pub const m_bPassthoughCaller: i64 = 0x4DC;
            };
            pub const CModelState = struct {
                pub const m_hModel: i64 = 0xA0;
                pub const m_ModelName: i64 = 0xA8;
                pub const m_nForceLOD: i64 = 0x283;
                pub const m_MeshGroupMask: i64 = 0x1E8;
                pub const m_nIdealMotionType: i64 = 0x282;
                pub const m_nBodyGroupChoices: i64 = 0x238;
                pub const m_nClothUpdateFlags: i64 = 0x284;
                pub const m_flRootBoneOffset_x: i64 = 0xE8;
                pub const m_flRootBoneOffset_y: i64 = 0xEC;
                pub const m_flRootBoneOffset_z: i64 = 0xF0;
                pub const m_pVPhysicsAggregate: i64 = 0xE0;
                pub const m_bClientClothCreationSuppressed: i64 = 0xF5;
                pub const m_nAnimStateNoInterpSerialNumber: i64 = 0x1E0;
                pub const m_nRootBoneOffsetResetSerialNumber: i64 = 0xF4;
            };
            pub const CNullEntity = struct {

            };
            pub const CPathCorner = struct {
                pub const m_OnPass: i64 = 0x4C8;
                pub const m_flWait: i64 = 0x4AC;
                pub const m_flSpeed: i64 = 0x4C0;
                pub const m_flRadius: i64 = 0x4B0;
                pub const m_bSmoothArrival: i64 = 0x4A9;
                pub const m_bExactPositioning: i64 = 0x4AA;
                pub const m_bTriggerLocomotionStop: i64 = 0x4A8;
                pub const m_flWaypointSuccessRadius: i64 = 0x4B8;
                pub const m_flPathEndDistanceFromGoal: i64 = 0x4BC;
                pub const m_flWaypointSuccessRadiusWhenBlocked: i64 = 0x4B4;
            };
            pub const CPathSimple = struct {
                pub const m_pathString: i64 = 0x5A0;
                pub const m_bClosedLoop: i64 = 0x5A8;
                pub const m_CPathQueryComponent: i64 = 0x4B0;
            };
            pub const CPhysImpact = struct {
                pub const m_damage: i64 = 0x4A8;
                pub const m_distance: i64 = 0x4AC;
                pub const m_directionEntityName: i64 = 0x4B0;
            };
            pub const CPhysLength = struct {
                pub const m_offset: i64 = 0x508;
                pub const m_addLength: i64 = 0x52C;
                pub const m_minLength: i64 = 0x530;
                pub const m_vecAttach: i64 = 0x520;
                pub const m_totalLength: i64 = 0x534;
            };
            pub const CPhysMagnet = struct {
                pub const m_bActive: i64 = 0xA98;
                pub const m_flRadius: i64 = 0xAA0;
                pub const m_massScale: i64 = 0xA70;
                pub const m_forceLimit: i64 = 0xA74;
                pub const m_flTotalMass: i64 = 0xA9C;
                pub const m_torqueLimit: i64 = 0xA78;
                pub const m_OnMagnetAttach: i64 = 0xA40;
                pub const m_OnMagnetDetach: i64 = 0xA58;
                pub const m_flNextSuckTime: i64 = 0xAA4;
                pub const m_bHasHitSomething: i64 = 0xA99;
                pub const m_MagnettedEntities: i64 = 0xA80;
                pub const m_iMaxObjectsAttached: i64 = 0xAA8;
            };
            pub const CPhysPulley = struct {
                pub const m_offset: i64 = 0x514;
                pub const m_addLength: i64 = 0x52C;
                pub const m_gearRatio: i64 = 0x530;
                pub const m_position2: i64 = 0x508;
            };
            pub const CPhysTorque = struct {
                pub const m_axis: i64 = 0x508;
            };
            pub const CPlayerPing = struct {
                pub const m_iType: i64 = 0x4B8;
                pub const m_bUrgent: i64 = 0x4BC;
                pub const m_hPlayer: i64 = 0x4B0;
                pub const m_szPlaceName: i64 = 0x4BD;
                pub const m_hPingedEntity: i64 = 0x4B4;
            };
            pub const CPointPulse = struct {

            };
            pub const CRangeFloat = struct {
                pub const m_pValue: i64 = 0x0;
            };
            pub const CRemapFloat = struct {
                pub const m_pValue: i64 = 0x0;
            };
            pub const CRuleEntity = struct {
                pub const m_iszMaster: i64 = 0x850;
            };
            pub const CScriptItem = struct {
                pub const m_MoveTypeOverride: i64 = 0xAE0;
            };
            pub const CSkillFloat = struct {
                pub const m_pValue: i64 = 0x0;
            };
            pub const CSmoothFunc = struct {
                pub const m_nSmoothDir: i64 = 0x18;
                pub const m_flSmoothBias: i64 = 0xC;
                pub const m_flSmoothDuration: i64 = 0x10;
                pub const m_flSmoothAmplitude: i64 = 0x8;
                pub const m_flSmoothRemainingTime: i64 = 0x14;
            };
            pub const CSoundPatch = struct {
                pub const m_hEnt: i64 = 0x50;
                pub const m_pitch: i64 = 0x8;
                pub const m_Filter: i64 = 0x68;
                pub const m_volume: i64 = 0x18;
                pub const m_isPlaying: i64 = 0x64;
                pub const m_flLastTime: i64 = 0x40;
                pub const m_soundOrigin: i64 = 0x58;
                pub const m_iszClassName: i64 = 0xA8;
                pub const m_shutdownTime: i64 = 0x3C;
                pub const m_soundEntityIndex: i64 = 0x54;
                pub const m_iszSoundScriptName: i64 = 0x48;
                pub const m_bUpdatedSoundOrigin: i64 = 0xA4;
                pub const m_flCloseCaptionDuration: i64 = 0xA0;
            };
            pub const CTestEffect = struct {
                pub const m_iBeam: i64 = 0x4AC;
                pub const m_iLoop: i64 = 0x4A8;
                pub const m_pBeam: i64 = 0x4B0;
                pub const m_flBeamTime: i64 = 0x510;
                pub const m_flStartTime: i64 = 0x570;
            };
            pub const CTriggerFan = struct {
                pub const m_flForce: i64 = 0xA04;
                pub const m_bFalloff: i64 = 0xA08;
                pub const m_hInfoFan: i64 = 0xA00;
                pub const m_RampTimer: i64 = 0xA10;
                pub const m_bRampDown: i64 = 0xA81;
                pub const m_vFanEndLS: i64 = 0xA40;
                pub const m_flNPCForce: i64 = 0xA70;
                pub const m_flRampTime: i64 = 0xA74;
                pub const m_iszInfoFan: i64 = 0xA58;
                pub const m_vDirection: i64 = 0x9D4;
                pub const m_bPushPlayer: i64 = 0xA80;
                pub const m_fNoiseSpeed: i64 = 0xA7C;
                pub const m_qNoiseDelta: i64 = 0x9F0;
                pub const m_vFanOriginLS: i64 = 0xA34;
                pub const m_vFanOriginWS: i64 = 0xA28;
                pub const m_fNoiseDegrees: i64 = 0xA78;
                pub const m_flPlayerForce: i64 = 0xA68;
                pub const m_nManagerFanIdx: i64 = 0xA84;
                pub const m_bPlayerWindblock: i64 = 0xA6C;
                pub const m_flRopeForceScale: i64 = 0xA60;
                pub const m_vFanOriginOffset: i64 = 0x9C8;
                pub const m_flParticleForceScale: i64 = 0xA64;
                pub const m_vNoiseDirectionTarget: i64 = 0xA4C;
                pub const m_bPushTowardsInfoTarget: i64 = 0x9E0;
                pub const m_bPushAwayFromInfoTarget: i64 = 0x9E1;
            };
            pub const CWeaponM249 = struct {

            };
            pub const CWeaponM4A1 = struct {

            };
            pub const CWeaponMag7 = struct {

            };
            pub const CWeaponNOVA = struct {

            };
            pub const CWeaponP250 = struct {

            };
            pub const CWeaponTec9 = struct {

            };
            pub const GAME_HEADER = struct {
                pub const m_sComment: i64 = 0x0;
                pub const m_sLandmark: i64 = 0x10;
                pub const m_sRequiredAddons: i64 = 0x18;
                pub const m_nSpawnGroupCount: i64 = 0x8;
            };
            pub const HullFlags_t = struct {
                pub const m_bHull_Tiny: i64 = 0x3;
                pub const m_bHull_Human: i64 = 0x0;
                pub const m_bHull_Large: i64 = 0x6;
                pub const m_bHull_Small: i64 = 0x9;
                pub const m_bHull_Medium: i64 = 0x4;
                pub const m_bHull_WideHuman: i64 = 0x2;
                pub const m_bHull_MediumTall: i64 = 0x8;
                pub const m_bHull_TinyCentered: i64 = 0x5;
                pub const m_bHull_LargeCentered: i64 = 0x7;
                pub const m_bHull_SmallCentered: i64 = 0x1;
            };
            pub const SAVE_HEADER = struct {
                pub const m_saveId: i64 = 0x0;
                pub const m_version: i64 = 0x4;
                pub const m_flSaveTime: i64 = 0x50;
                pub const m_nMapVersion: i64 = 0xC;
                pub const m_vecWorldOffset: i64 = 0x20;
                pub const m_sSpawnGroupName: i64 = 0x10;
                pub const m_nConnectionCount: i64 = 0x8;
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
            pub const levellist_t = struct {
                pub const m_sMapName: i64 = 0x0;
                pub const m_hEntLandmark: i64 = 0x10;
                pub const m_sLandmarkName: i64 = 0x8;
                pub const m_vecLandmarkAngles: i64 = 0x20;
                pub const m_vecLandmarkOrigin: i64 = 0x14;
            };
            pub const locksound_t = struct {
                pub const flwaitSound: i64 = 0x18;
                pub const sLockedSound: i64 = 0x8;
                pub const sUnlockedSound: i64 = 0x10;
            };
            pub const thinkfunc_t = struct {
                pub const m_hFn: i64 = 0x8;
                pub const m_think: i64 = 0x0;
                pub const m_nContext: i64 = 0x10;
                pub const m_nLastThinkTick: i64 = 0x18;
                pub const m_nNextThinkTick: i64 = 0x14;
            };
            pub const CBaseDMStart = struct {
                pub const m_Master: i64 = 0x4A8;
            };
            pub const CBaseGrenade = struct {
                pub const m_bIsLive: i64 = 0xA82;
                pub const m_flDamage: i64 = 0xA90;
                pub const m_hThrower: i64 = 0xAA8;
                pub const m_DmgRadius: i64 = 0xA84;
                pub const m_OnExplode: i64 = 0xA68;
                pub const m_bHasWarnedAI: i64 = 0xA80;
                pub const m_flNextAttack: i64 = 0xAC0;
                pub const m_flWarnAITime: i64 = 0xA8C;
                pub const m_ExplosionSound: i64 = 0xAA0;
                pub const m_OnPlayerPickup: i64 = 0xA50;
                pub const m_flDetonateTime: i64 = 0xA88;
                pub const m_iszBounceSound: i64 = 0xA98;
                pub const m_bIsSmokeGrenade: i64 = 0xA81;
                pub const m_hOriginalThrower: i64 = 0xAC4;
                pub const m_bDamageDetonating: i64 = 0xA48;
            };
            pub const CBaseTrigger = struct {
                pub const m_hFilter: i64 = 0x9B0;
                pub const m_bDisabled: i64 = 0x9B4;
                pub const m_OnEndTouch: i64 = 0x900;
                pub const m_OnTouching: i64 = 0x930;
                pub const m_iFilterName: i64 = 0x9A8;
                pub const m_OnStartTouch: i64 = 0x8D0;
                pub const m_OnEndTouchAll: i64 = 0x918;
                pub const m_OnNotTouching: i64 = 0x960;
                pub const m_OnStartTouchAll: i64 = 0x8E8;
                pub const m_bUseAsyncQueries: i64 = 0x9C0;
                pub const m_OnTouchingChanged: i64 = 0x978;
                pub const m_hTouchingEntities: i64 = 0x990;
                pub const m_OnTouchingEachEntity: i64 = 0x948;
            };
            pub const CBtActionAim = struct {
                pub const m_AimTimer: i64 = 0xA8;
                pub const m_bAcquired: i64 = 0xF0;
                pub const m_bDoneAiming: i64 = 0x8C;
                pub const m_szAimReadyKey: i64 = 0x80;
                pub const m_NextLookTarget: i64 = 0x9C;
                pub const m_SniperHoldTimer: i64 = 0xC0;
                pub const m_flLerpStartTime: i64 = 0x90;
                pub const m_szSensorInputKey: i64 = 0x68;
                pub const m_FocusIntervalTimer: i64 = 0xD8;
                pub const m_flPenaltyReductionRatio: i64 = 0x98;
                pub const m_flZoomCooldownTimestamp: i64 = 0x88;
                pub const m_flNextLookTargetLerpTime: i64 = 0x94;
            };
            pub const CCSGameRules = struct {
                pub const m_iNumCT: i64 = 0xD90;
                pub const m_bLogoMap: i64 = 0x13D;
                pub const m_bTCantBuy: i64 = 0xA4C;
                pub const m_gamePhase: i64 = 0x11C;
                pub const m_bCTCantBuy: i64 = 0xA4D;
                pub const m_bIsValveDS: i64 = 0x13C;
                pub const m_iAccountCT: i64 = 0xE80;
                pub const m_iMaxNumCTs: i64 = 0xE90;
                pub const m_iRoundTime: i64 = 0x100;
                pub const m_MatchDevice: i64 = 0x144;
                pub const m_RetakeRules: i64 = 0x1140;
                pub const m_bVoteCalled: i64 = 0xEF0;
                pub const m_iFreezeTime: i64 = 0xFC;
                pub const m_nCTTimeOuts: i64 = 0xF4;
                pub const m_bBombDefused: i64 = 0xF01;
                pub const m_bBombDropped: i64 = 0xA40;
                pub const m_bBombPlanted: i64 = 0x95F;
                pub const m_bGameRestart: i64 = 0x110;
                pub const m_bNoCTsKilled: i64 = 0xEB5;
                pub const m_vMinimapMaxs: i64 = 0xCC4;
                pub const m_vMinimapMins: i64 = 0xCB8;
                pub const m_CTSpawnPoints: i64 = 0xFA8;
                pub const m_bBuyTimeEnded: i64 = 0xEF8;
                pub const m_bFreezePeriod: i64 = 0xD8;
                pub const m_bIsHltvActive: i64 = 0x95E;
                pub const m_bTargetBombed: i64 = 0xF00;
                pub const m_bWarmupPeriod: i64 = 0xD9;
                pub const m_firstKillTime: i64 = 0xEBC;
                pub const m_iNumTerrorist: i64 = 0xD8C;
                pub const m_numBestOfMaps: i64 = 0xA38;
                pub const m_bCompleteReset: i64 = 0xDBD;
                pub const m_bMapHasBuyZone: i64 = 0x133;
                pub const m_fAvgPlayerRank: i64 = 0xDEC;
                pub const m_firstBloodTime: i64 = 0xEC4;
                pub const m_nMatchEndCount: i64 = 0x13B8;
                pub const m_nRoundEndCount: i64 = 0x140C;
                pub const m_pGameModeRules: i64 = 0x1098;
                pub const m_szMatchStatTxt: i64 = 0x550;
                pub const m_bFirstConnected: i64 = 0xDBC;
                pub const m_bMapHasBombZone: i64 = 0xF02;
                pub const m_eRoundEndReason: i64 = 0x13D4;
                pub const m_eRoundWinReason: i64 = 0xA48;
                pub const m_endMatchOnThink: i64 = 0xD89;
                pub const m_fMatchStartTime: i64 = 0x104;
                pub const m_fRoundStartTime: i64 = 0x108;
                pub const m_flGameStartTime: i64 = 0x114;
                pub const m_flLastThinkTime: i64 = 0x1024;
                pub const m_hPlayerResource: i64 = 0x1138;
                pub const m_iNumSpawnableCT: i64 = 0xD98;
                pub const m_iRoundEndLegacy: i64 = 0x1408;
                pub const m_iRoundWinStatus: i64 = 0xA44;
                pub const m_ullLocalMatchID: i64 = 0xCF0;
                pub const m_bCTTimeOutActive: i64 = 0xE5;
                pub const m_bHasMatchStarted: i64 = 0x148;
                pub const m_bIsDroppingItems: i64 = 0x95C;
                pub const m_bIsQuestEligible: i64 = 0x95D;
                pub const m_bNoEnemiesKilled: i64 = 0xEB6;
                pub const m_bRoundEndNoMusic: i64 = 0x1404;
                pub const m_bTeamIntroPeriod: i64 = 0x13C4;
                pub const m_fWarmupPeriodEnd: i64 = 0xDC;
                pub const m_hostageWasKilled: i64 = 0xEE1;
                pub const m_iHostagesRescued: i64 = 0xEA8;
                pub const m_iHostagesTouched: i64 = 0xEAC;
                pub const m_nOvertimePlaying: i64 = 0x128;
                pub const m_nRoundStartCount: i64 = 0x1414;
                pub const m_sRoundEndMessage: i64 = 0x13F8;
                pub const m_bCanDonateWeapons: i64 = 0xEB7;
                pub const m_bLevelInitialized: i64 = 0xD7C;
                pub const m_bMapHasBombTarget: i64 = 0x131;
                pub const m_bMapHasRescueZone: i64 = 0x132;
                pub const m_bTechnicalTimeOut: i64 = 0xF8;
                pub const m_flNextRespawnWave: i64 = 0xC38;
                pub const m_hostageWasInjured: i64 = 0xEE0;
                pub const m_iAccountTerrorist: i64 = 0xE7C;
                pub const m_iMaxNumTerrorists: i64 = 0xE8C;
                pub const m_iNextCTSpawnPoint: i64 = 0xF94;
                pub const m_iUnBalancedRounds: i64 = 0xD84;
                pub const m_totalRoundsPlayed: i64 = 0x120;
                pub const m_vecMainCTSpawnPos: i64 = 0xF50;
                pub const mTeamDMLastThinkTime: i64 = 0xE74;
                pub const m_BtGlobalBlackboard: i64 = 0x10A0;
                pub const m_bAllowWeaponSwitch: i64 = 0x1018;
                pub const m_bAnyHostageReached: i64 = 0x130;
                pub const m_bPlayedTeamIntroVO: i64 = 0x13CC;
                pub const m_bServerVoteOnReset: i64 = 0xEF1;
                pub const m_fWarmupPeriodStart: i64 = 0xE0;
                pub const m_flRestartRoundTime: i64 = 0x10C;
                pub const m_iHostagesRemaining: i64 = 0x12C;
                pub const m_iRoundEndTimerTime: i64 = 0x13DC;
                pub const m_iTotalRoundsPlayed: i64 = 0xD80;
                pub const m_nEndMatchTiedVotes: i64 = 0xDC8;
                pub const m_nLastFreezeEndBeep: i64 = 0xEFC;
                pub const m_nMatchInfoShowType: i64 = 0xE50;
                pub const m_nNextMapInMapgroup: i64 = 0x14C;
                pub const m_nTTeamIntroVariant: i64 = 0x13BC;
                pub const m_nTerroristTimeOuts: i64 = 0xF0;
                pub const m_bNoTerroristsKilled: i64 = 0xEB4;
                pub const m_bSwapTeamsOnRestart: i64 = 0xDC0;
                pub const m_fTeamIntroPeriodEnd: i64 = 0x13C8;
                pub const m_flVoteCheckThrottle: i64 = 0xEF4;
                pub const m_iRoundEndWinnerTeam: i64 = 0x13D0;
                pub const m_iSpawnPointCount_CT: i64 = 0xE88;
                pub const m_iSpectatorSlotCount: i64 = 0x140;
                pub const m_nCTTeamIntroVariant: i64 = 0x13C0;
                pub const m_tmNextPeriodicThink: i64 = 0xE98;
                pub const m_TeamRespawnWaveTimes: i64 = 0xBB8;
                pub const m_TerroristSpawnPoints: i64 = 0xFC0;
                pub const m_bIsQueuedMatchmaking: i64 = 0x134;
                pub const m_bPickNewTeamsOnReset: i64 = 0xDBE;
                pub const m_endMatchOnRoundReset: i64 = 0xD88;
                pub const m_flCTTimeOutRemaining: i64 = 0xEC;
                pub const m_flLastPerfSampleTime: i64 = 0x5420;
                pub const m_iRoundEndPlayerCount: i64 = 0x1400;
                pub const m_flIntermissionEndTime: i64 = 0xD78;
                pub const m_iRoundEndFunFactData1: i64 = 0x13EC;
                pub const m_iRoundEndFunFactData2: i64 = 0x13F0;
                pub const m_iRoundEndFunFactData3: i64 = 0x13F4;
                pub const m_numSpectatorsCountMax: i64 = 0xDFC;
                pub const m_sRoundEndFunFactToken: i64 = 0x13E0;
                pub const m_szTournamentEventName: i64 = 0x150;
                pub const m_bForceTeamChangeSilent: i64 = 0xE18;
                pub const m_bHasHostageBeenTouched: i64 = 0xD70;
                pub const m_bMatchWaitingForResume: i64 = 0xF9;
                pub const m_flCTSpawnPointUsedTime: i64 = 0xF98;
                pub const m_flMatchInfoDecidedTime: i64 = 0xE54;
                pub const m_iNumConsecutiveCTLoses: i64 = 0xD4C;
                pub const m_iNumSpawnableTerrorist: i64 = 0xD94;
                pub const m_iRoundStartRoundNumber: i64 = 0x1410;
                pub const m_nEndMatchMapVoteWinner: i64 = 0xD48;
                pub const m_nHalloweenMaskListSeed: i64 = 0xA3C;
                pub const m_nQueuedMatchmakingMode: i64 = 0x138;
                pub const m_nRoundsPlayedThisPhase: i64 = 0x124;
                pub const m_nSpawnPointsRandomSeed: i64 = 0xDB8;
                pub const m_szTournamentEventStage: i64 = 0x350;
                pub const m_CTSpawnPointsMasterList: i64 = 0xF60;
                pub const m_bIsUnreservedGameServer: i64 = 0xFD8;
                pub const m_bLoadingRoundBackupData: i64 = 0xE19;
                pub const m_bScrambleTeamsOnRestart: i64 = 0xDBF;
                pub const m_bTerroristTimeOutActive: i64 = 0xE4;
                pub const m_bVoiceWonMatchBragFired: i64 = 0xE9C;
                pub const m_fAutobalanceDisplayTime: i64 = 0xFDC;
                pub const m_flIntermissionStartTime: i64 = 0xD74;
                pub const m_numSpectatorsCountMaxTV: i64 = 0xE00;
                pub const m_numTotalTournamentDrops: i64 = 0xDF8;
                pub const m_arrProhibitedItemIndices: i64 = 0x960;
                pub const m_bRoundEndShowTimerDefend: i64 = 0x13D8;
                pub const m_iMatchStats_RoundResults: i64 = 0xA50;
                pub const m_iNextTerroristSpawnPoint: i64 = 0xF9C;
                pub const m_nCTsAliveAtFreezetimeEnd: i64 = 0xE10;
                pub const m_nMatchAbortedEarlyReason: i64 = 0x1078;
                pub const m_numSpectatorsCountMaxLnk: i64 = 0xE04;
                pub const m_timeUntilNextPhaseStarts: i64 = 0x118;
                pub const m_fWarmupNextChatNoticeTime: i64 = 0xEA0;
                pub const m_flNextHostageAnnouncement: i64 = 0xEB0;
                pub const m_iLoserBonusMostRecentTeam: i64 = 0xE94;
                pub const m_nTournamentPredictionsPct: i64 = 0x950;
                pub const mTeamDMLastWinningTeamNumber: i64 = 0xE70;
                pub const m_bPlayAllStepSoundsOnServer: i64 = 0x13E;
                pub const m_bRoundTimeWarningTriggered: i64 = 0x1019;
                pub const m_fAccumulatedRoundOffDamage: i64 = 0x1028;
                pub const m_flCMMItemDropRevealEndTime: i64 = 0x958;
                pub const m_iMatchStats_PlayersAlive_T: i64 = 0xB40;
                pub const m_iRoundEndFunFactPlayerSlot: i64 = 0x13E8;
                pub const m_iSpawnPointCount_Terrorist: i64 = 0xE84;
                pub const m_nEndMatchMapGroupVoteTypes: i64 = 0xCF8;
                pub const m_szTournamentPredictionsTxt: i64 = 0x750;
                pub const m_bSwitchingTeamsAtRoundReset: i64 = 0x107D;
                pub const m_flTerroristTimeOutRemaining: i64 = 0xE8;
                pub const m_iMatchStats_PlayersAlive_CT: i64 = 0xAC8;
                pub const m_phaseChangeAnnouncementTime: i64 = 0x101C;
                pub const m_bHasTriggeredRoundStartMusic: i64 = 0x107C;
                pub const m_fNextUpdateTeamClanNamesTime: i64 = 0x1020;
                pub const m_flCMMItemDropRevealStartTime: i64 = 0x954;
                pub const m_flTeamDMLastAnnouncementTime: i64 = 0xE78;
                pub const m_nEndMatchMapGroupVoteOptions: i64 = 0xD20;
                pub const m_numQueuedMatchmakingAccounts: i64 = 0xDE8;
                pub const m_MinimapVerticalSectionHeights: i64 = 0xCD0;
                pub const m_arrTeamUniqueKillWeaponsMatch: i64 = 0x1330;
                pub const m_flTerroristSpawnPointUsedTime: i64 = 0xFA0;
                pub const m_iNumConsecutiveTerroristLoses: i64 = 0xD50;
                pub const m_TerroristSpawnPointsMasterList: i64 = 0xF78;
                pub const m_arrSelectedHostageSpawnIndices: i64 = 0xDA0;
                pub const m_nShorthandedBonusLastEvalRound: i64 = 0x102C;
                pub const m_nTerroristsAliveAtFreezetimeEnd: i64 = 0xE14;
                pub const m_bNeedToAskPlayersForContinueVote: i64 = 0xDE4;
                pub const m_bRespawningAllRespawnablePlayers: i64 = 0xF90;
                pub const m_arrTournamentActiveCasterAccounts: i64 = 0xA28;
                pub const m_bTeamLastKillUsedUniqueWeaponMatch: i64 = 0x1390;
                pub const m_pQueuedMatchmakingReservationString: i64 = 0xDF0;
            };
            pub const CChangeLevel = struct {
                pub const m_bNoTouch: i64 = 0x9F1;
                pub const m_bTouched: i64 = 0x9F0;
                pub const m_sMapName: i64 = 0x9C8;
                pub const m_bNewChapter: i64 = 0x9F2;
                pub const m_OnChangeLevel: i64 = 0x9D8;
                pub const m_sLandmarkName: i64 = 0x9D0;
                pub const m_bOnChangeLevelFired: i64 = 0x9F3;
            };
            pub const CDynamicProp = struct {
                pub const m_glowColor: i64 = 0xC80;
                pub const m_nGlowTeam: i64 = 0xC84;
                pub const m_nGlowRange: i64 = 0xC78;
                pub const m_iszIdleAnim: i64 = 0xC60;
                pub const m_bUseAnimGraph: i64 = 0xBE3;
                pub const m_nGlowRangeMin: i64 = 0xC7C;
                pub const m_bStartDisabled: i64 = 0xC6D;
                pub const m_bCreateNonSolid: i64 = 0xC71;
                pub const m_bIsOverrideProp: i64 = 0xC72;
                pub const m_bRandomizeCycle: i64 = 0xC6C;
                pub const m_pOutputAnimOver: i64 = 0xC00;
                pub const m_OnAnimReachedEnd: i64 = 0xC48;
                pub const m_bForceNpcExclude: i64 = 0xC6F;
                pub const m_pOutputAnimBegun: i64 = 0xBE8;
                pub const m_iInitialGlowState: i64 = 0xC74;
                pub const m_nIdleAnimLoopMode: i64 = 0xC68;
                pub const m_OnAnimReachedStart: i64 = 0xC30;
                pub const m_bCreateNavObstacle: i64 = 0xBE0;
                pub const m_bFiredStartEndOutput: i64 = 0xC6E;
                pub const m_bGraphControllerEnabled: i64 = 0xBD0;
                pub const m_bUseHitboxesForRenderBox: i64 = 0xBE2;
                pub const m_pOutputAnimLoopCycleOver: i64 = 0xC18;
                pub const m_bCreateMovableSurfaceGraph: i64 = 0xC70;
                pub const m_bNavObstacleUpdatesOverridden: i64 = 0xBE1;
            };
            pub const CEntityFlame = struct {
                pub const m_flSize: i64 = 0x4B0;
                pub const m_hAttacker: i64 = 0x4C4;
                pub const m_flLifetime: i64 = 0x4C0;
                pub const m_bCheapEffect: i64 = 0x4AC;
                pub const m_bUseHitboxes: i64 = 0x4B4;
                pub const m_hEntAttached: i64 = 0x4A8;
                pub const m_iNumHitboxFires: i64 = 0x4B8;
                pub const m_flHitboxFireScale: i64 = 0x4BC;
                pub const m_iCustomDamageType: i64 = 0x4CC;
                pub const m_flDirectDamagePerSecond: i64 = 0x4C8;
            };
            pub const CEnvBeverage = struct {
                pub const m_nBeverageType: i64 = 0x4AC;
                pub const m_CanInDispenser: i64 = 0x4A8;
            };
            pub const CFilterClass = struct {
                pub const m_iFilterClass: i64 = 0x4E0;
            };
            pub const CFilterEnemy = struct {
                pub const m_flRadius: i64 = 0x4E8;
                pub const m_iszEnemyName: i64 = 0x4E0;
                pub const m_flOuterRadius: i64 = 0x4EC;
                pub const m_iszPlayerName: i64 = 0x4F8;
                pub const m_nMaxSquadmatesPerEnemy: i64 = 0x4F0;
            };
            pub const CFilterModel = struct {
                pub const m_iFilterModel: i64 = 0x4E0;
            };
            pub const CFuncMonitor = struct {
                pub const m_bEnabled: i64 = 0x88C;
                pub const m_targetCamera: i64 = 0x870;
                pub const m_bDraw3DSkybox: i64 = 0x88D;
                pub const m_bStartEnabled: i64 = 0x88E;
                pub const m_hTargetCamera: i64 = 0x888;
                pub const m_bRenderShadows: i64 = 0x87C;
                pub const m_brushModelName: i64 = 0x880;
                pub const m_nResolutionEnum: i64 = 0x878;
                pub const m_bUseUniqueColorTarget: i64 = 0x87D;
            };
            pub const CFuncPlatRot = struct {
                pub const m_end: i64 = 0x908;
                pub const m_start: i64 = 0x914;
            };
            pub const CFuncRotator = struct {
                pub const m_flSpeed: i64 = 0x858;
                pub const m_bQueueStop: i64 = 0x9A0;
                pub const m_eSolidType: i64 = 0x855;
                pub const m_OnOscillate: i64 = 0x8A0;
                pub const m_bIsRotating: i64 = 0x854;
                pub const m_eRotateType: i64 = 0x850;
                pub const m_flStartSpeed: i64 = 0x938;
                pub const m_iszLoopSound: i64 = 0x968;
                pub const m_iszStopSound: i64 = 0x988;
                pub const m_eRotationAxis: i64 = 0x998;
                pub const m_flTargetAngle: i64 = 0x990;
                pub const m_iszStartSound: i64 = 0x960;
                pub const m_flCurrentAngle: i64 = 0x994;
                pub const m_hRotatorTarget: i64 = 0x864;
                pub const m_nTickRotateRan: i64 = 0x918;
                pub const m_rotationSummary: i64 = 0x920;
                pub const m_bStartedRotating: i64 = 0x91C;
                pub const m_flMaxYawRotation: i64 = 0x958;
                pub const m_flMinYawRotation: i64 = 0x954;
                pub const m_strRotatorTarget: i64 = 0x868;
                pub const m_OnRotationStarted: i64 = 0x870;
                pub const m_qSpawnOrientation: i64 = 0x940;
                pub const m_flTimeRotationStop: i64 = 0x934;
                pub const m_OnRotationCompleted: i64 = 0x888;
                pub const m_flTimeRotationStart: i64 = 0x930;
                pub const m_OnOscillateEndArrive: i64 = 0x8E8;
                pub const m_OnOscillateEndDepart: i64 = 0x900;
                pub const m_bOscillationFromStart: i64 = 0x95C;
                pub const m_flTimeToReachMaxSpeed: i64 = 0x928;
                pub const m_OnOscillateStartArrive: i64 = 0x8B8;
                pub const m_OnOscillateStartDepart: i64 = 0x8D0;
                pub const m_flTimeToReachZeroSpeed: i64 = 0x92C;
                pub const m_flTimeToCompleteRotation: i64 = 0x860;
                pub const m_flRotationDistanceDegrees: i64 = 0x85C;
                pub const m_flSpeedDriftFromOverRotate: i64 = 0x99C;
                pub const m_bReturningToInitialRotation: i64 = 0x950;
            };
            pub const CGradientFog = struct {
                pub const m_flFarZ: i64 = 0x4C4;
                pub const m_fogColor: i64 = 0x4D4;
                pub const m_bIsEnabled: i64 = 0x4E1;
                pub const m_flFadeTime: i64 = 0x4DC;
                pub const m_flFogStrength: i64 = 0x4D8;
                pub const m_bStartDisabled: i64 = 0x4E0;
                pub const m_flFogEndHeight: i64 = 0x4C0;
                pub const m_flFogMaxOpacity: i64 = 0x4C8;
                pub const m_flFogEndDistance: i64 = 0x4B4;
                pub const m_flFogStartHeight: i64 = 0x4BC;
                pub const m_bHeightFogEnabled: i64 = 0x4B8;
                pub const m_flFogStartDistance: i64 = 0x4B0;
                pub const m_hGradientFogTexture: i64 = 0x4A8;
                pub const m_flFogFalloffExponent: i64 = 0x4CC;
                pub const m_flFogVerticalExponent: i64 = 0x4D0;
                pub const m_bGradientFogNeedsTextures: i64 = 0x4E2;
            };
            pub const CHandleDummy = struct {

            };
            pub const CHintMessage = struct {
                pub const m_args: i64 = 0x8;
                pub const m_duration: i64 = 0x20;
                pub const m_hintString: i64 = 0x0;
            };
            pub const CItemDefuser = struct {
                pub const m_nSpotRules: i64 = 0xAF8;
                pub const m_entitySpottedState: i64 = 0xAE0;
            };
            pub const CItemDogtags = struct {
                pub const m_OwningPlayer: i64 = 0xAE0;
                pub const m_KillingPlayer: i64 = 0xAE4;
            };
            pub const CItemGeneric = struct {
                pub const m_OnPickup: i64 = 0xB68;
                pub const m_bUseable: i64 = 0xC00;
                pub const m_OnTimeout: i64 = 0xB80;
                pub const m_glowColor: i64 = 0xBFC;
                pub const m_hPickupFilter: i64 = 0xB60;
                pub const m_OnTriggerTouch: i64 = 0xBB0;
                pub const m_flPickupRadius: i64 = 0xBE8;
                pub const m_hTriggerHelper: i64 = 0xC04;
                pub const m_flTriggerRadius: i64 = 0xBEC;
                pub const m_bHasPickupRadius: i64 = 0xAF5;
                pub const m_OnTriggerEndTouch: i64 = 0xBC8;
                pub const m_bHasTriggerRadius: i64 = 0xAF4;
                pub const m_flLastPickupCheck: i64 = 0xB00;
                pub const m_flPickupRadiusSqr: i64 = 0xAF8;
                pub const m_pPickupFilterName: i64 = 0xB58;
                pub const m_bGlowWhenInTrigger: i64 = 0xBF8;
                pub const m_flTriggerRadiusSqr: i64 = 0xAFC;
                pub const m_pPickupSoundEffect: i64 = 0xB30;
                pub const m_OnTriggerStartTouch: i64 = 0xB98;
                pub const m_pAmbientSoundEffect: i64 = 0xB10;
                pub const m_pTimeoutSoundEffect: i64 = 0xB48;
                pub const m_pTriggerSoundEffect: i64 = 0xBF0;
                pub const m_hSpawnParticleEffect: i64 = 0xB08;
                pub const m_pSpawnScriptFunction: i64 = 0xB20;
                pub const m_hPickupParticleEffect: i64 = 0xB28;
                pub const m_pPickupScriptFunction: i64 = 0xB38;
                pub const m_bAutoStartAmbientSound: i64 = 0xB18;
                pub const m_bPlayerInTriggerRadius: i64 = 0xB05;
                pub const m_hTimeoutParticleEffect: i64 = 0xB40;
                pub const m_pTimeoutScriptFunction: i64 = 0xB50;
                pub const m_pAllowPickupScriptFunction: i64 = 0xBE0;
                pub const m_bPlayerCounterListenerAdded: i64 = 0xB04;
            };
            pub const CKeepUpright = struct {
                pub const m_bActive: i64 = 0x4E0;
                pub const m_nameAttach: i64 = 0x4D0;
                pub const m_pController: i64 = 0x4C8;
                pub const m_angularLimit: i64 = 0x4DC;
                pub const m_localTestAxis: i64 = 0x4BC;
                pub const m_worldGoalAxis: i64 = 0x4B0;
                pub const m_attachedObject: i64 = 0x4D8;
                pub const m_bDampAllRotation: i64 = 0x4E1;
            };
            pub const CLightEntity = struct {
                pub const m_CLightComponent: i64 = 0x850;
            };
            pub const CLogicBranch = struct {
                pub const m_OnTrue: i64 = 0x4C8;
                pub const m_OnFalse: i64 = 0x4E0;
                pub const m_bInValue: i64 = 0x4A8;
                pub const m_Listeners: i64 = 0x4B0;
            };
            pub const CLogicScript = struct {

            };
            pub const CMathCounter = struct {
                pub const m_flMax: i64 = 0x4AC;
                pub const m_flMin: i64 = 0x4A8;
                pub const m_bHitMax: i64 = 0x4B1;
                pub const m_bHitMin: i64 = 0x4B0;
                pub const m_OnHitMax: i64 = 0x510;
                pub const m_OnHitMin: i64 = 0x4F8;
                pub const m_OutValue: i64 = 0x4B8;
                pub const m_bDisabled: i64 = 0x4B2;
                pub const m_OnGetValue: i64 = 0x4D8;
                pub const m_OnChangedFromMax: i64 = 0x540;
                pub const m_OnChangedFromMin: i64 = 0x528;
            };
            pub const CMultiSource = struct {
                pub const m_iTotal: i64 = 0x5C0;
                pub const m_OnTrigger: i64 = 0x5A8;
                pub const m_rgEntities: i64 = 0x4A8;
                pub const m_globalstate: i64 = 0x5C8;
                pub const m_rgTriggered: i64 = 0x528;
            };
            pub const CNavPathCost = struct {
                pub const m_bCanFly: i64 = 0x11;
                pub const m_bCanSwim: i64 = 0x12;
                pub const m_bAllowLadders: i64 = 0x10;
                pub const m_flTransitionPenalty: i64 = 0x2C;
                pub const m_bSupportsTransitions: i64 = 0x2A;
                pub const m_flGroundToWaterMaxHeight: i64 = 0x18;
                pub const m_flWaterToGroundMaxHeight: i64 = 0x14;
                pub const m_bOptimizeFlySpacePathfinds: i64 = 0x28;
                pub const m_flFlyingTransitionTolerance: i64 = 0x24;
                pub const m_bStringPullFlySpacePathfinds: i64 = 0x29;
                pub const m_flGroundToWaterTransitionDistance: i64 = 0x1C;
                pub const m_flWaterToGroundTransitionDistance: i64 = 0x20;
            };
            pub const CNavWalkable = struct {

            };
            pub const CNmAimCSTask = struct {

            };
            pub const CPhysicsProp = struct {
                pub const m_bAwake: i64 = 0xD09;
                pub const m_OnAwake: i64 = 0xC10;
                pub const m_OnAsleep: i64 = 0xC28;
                pub const m_CrateType: i64 = 0xCD0;
                pub const m_glowColor: i64 = 0xCC0;
                pub const m_massScale: i64 = 0xC8C;
                pub const m_OnAwakened: i64 = 0xBF8;
                pub const m_damageType: i64 = 0xC94;
                pub const m_flLastBurn: i64 = 0xCA8;
                pub const m_nGlowRange: i64 = 0xCB8;
                pub const m_nItemCount: i64 = 0xCF8;
                pub const m_OnPlayerUse: i64 = 0xC40;
                pub const m_OnOutOfWorld: i64 = 0xC58;
                pub const m_strItemClass: i64 = 0xCD8;
                pub const m_MotionEnabled: i64 = 0xBE0;
                pub const m_buoyancyScale: i64 = 0xC90;
                pub const m_nGlowRangeMin: i64 = 0xCBC;
                pub const m_OnPlayerPickup: i64 = 0xC70;
                pub const m_bForceNavIgnore: i64 = 0xC88;
                pub const m_bIsOverrideProp: i64 = 0xCA4;
                pub const m_bDroppedByPlayer: i64 = 0xCA0;
                pub const m_bEnableUseOutput: i64 = 0xCCF;
                pub const m_bForceNpcExclude: i64 = 0xC8A;
                pub const m_bHasBeenAwakened: i64 = 0xCA3;
                pub const m_bTouchedByPlayer: i64 = 0xCA1;
                pub const m_nNavObstacleType: i64 = 0xCC8;
                pub const m_bNoNavmeshBlocker: i64 = 0xC89;
                pub const m_iInitialGlowState: i64 = 0xCB4;
                pub const m_bMuteImpactEffects: i64 = 0xCC5;
                pub const m_bForceNavObstacleCut: i64 = 0xCCD;
                pub const m_bUpdateNavWhenMoving: i64 = 0xCCC;
                pub const m_damageToEnableMotion: i64 = 0xC98;
                pub const m_flForceToEnableMotion: i64 = 0xC9C;
                pub const m_bAttachedToReferenceFrame: i64 = 0xD0A;
                pub const m_bFirstCollisionAfterLaunch: i64 = 0xCA2;
                pub const m_bRemovableForAmmoBalancing: i64 = 0xD08;
                pub const m_bAcceptDamageFromHeldObjects: i64 = 0xCCE;
                pub const m_bShouldAutoConvertBackFromDebris: i64 = 0xCC4;
                pub const m_nDynamicContinuousContactBehavior: i64 = 0xCAC;
                pub const m_fNextCheckDisableMotionContactsTime: i64 = 0xCB0;
            };
            pub const CPhysicsWire = struct {
                pub const m_nDensity: i64 = 0x4A8;
            };
            pub const CPlatTrigger = struct {
                pub const m_pPlatform: i64 = 0x850;
            };
            pub const CPointCamera = struct {
                pub const m_FOV: i64 = 0x4A8;
                pub const m_bIsOn: i64 = 0x4FC;
                pub const m_pNext: i64 = 0x500;
                pub const m_bNoSky: i64 = 0x4CC;
                pub const m_flZFar: i64 = 0x4D4;
                pub const m_bActive: i64 = 0x4C4;
                pub const m_flZNear: i64 = 0x4D8;
                pub const m_FogColor: i64 = 0x4B4;
                pub const m_flFogEnd: i64 = 0x4BC;
                pub const m_TargetFOV: i64 = 0x4F4;
                pub const m_Resolution: i64 = 0x4AC;
                pub const m_bFogEnable: i64 = 0x4B0;
                pub const m_flFogStart: i64 = 0x4B8;
                pub const m_bCanHLTVUse: i64 = 0x4DC;
                pub const m_bDofEnabled: i64 = 0x4DE;
                pub const m_fBrightness: i64 = 0x4D0;
                pub const m_flAspectRatio: i64 = 0x4C8;
                pub const m_flDofFarCrisp: i64 = 0x4E8;
                pub const m_flDofFarBlurry: i64 = 0x4EC;
                pub const m_flDofNearCrisp: i64 = 0x4E4;
                pub const m_flDofNearBlurry: i64 = 0x4E0;
                pub const m_flFogMaxDensity: i64 = 0x4C0;
                pub const m_DegreesPerSecond: i64 = 0x4F8;
                pub const m_bAlignWithParent: i64 = 0x4DD;
                pub const m_flDofTiltToGround: i64 = 0x4F0;
                pub const m_bUseScreenAspectRatio: i64 = 0x4C5;
            };
            pub const CPointEntity = struct {

            };
            pub const CPointOrient = struct {
                pub const m_bActive: i64 = 0x4B4;
                pub const m_hTarget: i64 = 0x4B0;
                pub const m_nConstraint: i64 = 0x4BC;
                pub const m_flMaxTurnRate: i64 = 0x4C0;
                pub const m_flLastGameTime: i64 = 0x4C4;
                pub const m_nGoalDirection: i64 = 0x4B8;
                pub const m_iszSpawnTargetName: i64 = 0x4A8;
            };
            pub const CPointPrefab = struct {
                pub const m_fixupNames: i64 = 0x4C0;
                pub const m_bLoadDynamic: i64 = 0x4C1;
                pub const m_targetMapName: i64 = 0x4A8;
                pub const m_forceWorldGroupID: i64 = 0x4B0;
                pub const m_associatedRelayEntity: i64 = 0x4C4;
                pub const m_ProceduralRelaySources: i64 = 0x4C8;
                pub const m_associatedRelayTargetName: i64 = 0x4B8;
            };
            pub const CRR_Response = struct {
                pub const m_Type: i64 = 0x0;
                pub const m_Params: i64 = 0x160;
                pub const m_Followup: i64 = 0x198;
                pub const m_fMatchScore: i64 = 0x180;
                pub const m_szMatchingRule: i64 = 0xC1;
                pub const m_szResponseName: i64 = 0x1;
                pub const m_szWorldContext: i64 = 0x190;
                pub const m_recipientFilter: i64 = 0x1B4;
                pub const m_szSpeakerContext: i64 = 0x188;
                pub const m_bAnyMatchingRulesInCooldown: i64 = 0x184;
            };
            pub const CRagdollProp = struct {
                pub const m_ragPos: i64 = 0xB08;
                pub const m_hKiller: i64 = 0xB4C;
                pub const m_ragdoll: i64 = 0xA90;
                pub const m_allAsleep: i64 = 0xB3C;
                pub const m_massScale: i64 = 0xAE4;
                pub const m_ragAngles: i64 = 0xB20;
                pub const m_flFadeTime: i64 = 0xB5C;
                pub const m_ragEnabled: i64 = 0xAF0;
                pub const m_flAwakeTime: i64 = 0xB6C;
                pub const m_ragdollMaxs: i64 = 0xBB0;
                pub const m_ragdollMins: i64 = 0xB98;
                pub const m_bAllowStretch: i64 = 0xB89;
                pub const m_buoyancyScale: i64 = 0xAE8;
                pub const m_flBlendWeight: i64 = 0xB8C;
                pub const m_hDamageEntity: i64 = 0xB48;
                pub const m_vecLastOrigin: i64 = 0xB60;
                pub const m_bStartDisabled: i64 = 0xAE0;
                pub const m_vecNavObstacles: i64 = 0xBE0;
                pub const m_hPhysicsAttacker: i64 = 0xB50;
                pub const m_nNavObstacleType: i64 = 0xB40;
                pub const m_CPropDataComponent: i64 = 0xA50;
                pub const m_bHasBeenPhysgunned: i64 = 0xB88;
                pub const m_flDefaultFadeScale: i64 = 0xB90;
                pub const m_flFadeOutStartTime: i64 = 0xB58;
                pub const m_strOriginClassName: i64 = 0xB78;
                pub const m_strSourceClassName: i64 = 0xB80;
                pub const m_lastUpdateTickCount: i64 = 0xB38;
                pub const m_bForceNavObstacleCut: i64 = 0xB45;
                pub const m_bUpdateNavWhenMoving: i64 = 0xB44;
                pub const m_flLastOriginChangeTime: i64 = 0xB70;
                pub const m_bAttachedToReferenceFrame: i64 = 0xB46;
                pub const m_bFirstCollisionAfterLaunch: i64 = 0xB3D;
                pub const m_flLastPhysicsInfluenceTime: i64 = 0xB54;
                pub const m_bShouldDeleteActivationRecord: i64 = 0xBC8;
            };
            pub const CRevertSaved = struct {
                pub const m_Duration: i64 = 0x854;
                pub const m_HoldTime: i64 = 0x858;
                pub const m_loadTime: i64 = 0x850;
            };
            pub const CSceneEntity = struct {
                pub const m_fPitch: i64 = 0x53C;
                pub const m_hActor: i64 = 0x7E8;
                pub const m_OnStart: i64 = 0x5C8;
                pub const m_bPaused: i64 = 0x529;
                pub const m_ActorMap: i64 = 0x770;
                pub const m_OnPaused: i64 = 0x610;
                pub const m_hTarget1: i64 = 0x4F8;
                pub const m_hTarget2: i64 = 0x4FC;
                pub const m_hTarget3: i64 = 0x500;
                pub const m_hTarget4: i64 = 0x504;
                pub const m_hTarget5: i64 = 0x508;
                pub const m_hTarget6: i64 = 0x50C;
                pub const m_hTarget7: i64 = 0x510;
                pub const m_hTarget8: i64 = 0x514;
                pub const m_BusyActor: i64 = 0x7F0;
                pub const m_OnResumed: i64 = 0x628;
                pub const m_OnCanceled: i64 = 0x5F8;
                pub const m_bAutomated: i64 = 0x540;
                pub const m_bRestoring: i64 = 0x7A4;
                pub const m_hActivator: i64 = 0x7EC;
                pub const m_hActorList: i64 = 0x560;
                pub const m_iszTarget1: i64 = 0x4B8;
                pub const m_iszTarget2: i64 = 0x4C0;
                pub const m_iszTarget3: i64 = 0x4C8;
                pub const m_iszTarget4: i64 = 0x4D0;
                pub const m_iszTarget5: i64 = 0x4D8;
                pub const m_iszTarget6: i64 = 0x4E0;
                pub const m_iszTarget7: i64 = 0x4E8;
                pub const m_iszTarget8: i64 = 0x4F0;
                pub const m_flFrameTime: i64 = 0x534;
                pub const m_ActorClipMap: i64 = 0x748;
                pub const m_OnCompletion: i64 = 0x5E0;
                pub const m_bInterrupted: i64 = 0x7A1;
                pub const m_bMultiplayer: i64 = 0x52A;
                pub const m_iszSceneFile: i64 = 0x4B0;
                pub const m_iszSoundName: i64 = 0x7D8;
                pub const m_ActorGraphMap: i64 = 0x720;
                pub const m_AnchorNameMap: i64 = 0x6F8;
                pub const m_TargetNameMap: i64 = 0x6D0;
                pub const m_bSceneMissing: i64 = 0x7A0;
                pub const m_flCurrentTime: i64 = 0x530;
                pub const m_hListManagers: i64 = 0x7C0;
                pub const m_bAutogenerated: i64 = 0x52B;
                pub const m_bIsPlayingBack: i64 = 0x528;
                pub const m_bSceneFinished: i64 = 0x55A;
                pub const m_hLocatorOrigin: i64 = 0x518;
                pub const m_bBreakOnNonIdle: i64 = 0x559;
                pub const m_bCompletedEarly: i64 = 0x7A2;
                pub const m_bPausedViaInput: i64 = 0x554;
                pub const m_hInterruptScene: i64 = 0x788;
                pub const m_iszSequenceName: i64 = 0x7E0;
                pub const m_nInterruptCount: i64 = 0x78C;
                pub const m_nSpeechPriority: i64 = 0x550;
                pub const m_responseConcept: i64 = 0x790;
                pub const m_bWaitingForActor: i64 = 0x556;
                pub const m_flAutomationTime: i64 = 0x54C;
                pub const m_hRemoveActorList: i64 = 0x578;
                pub const m_nAutomatedAction: i64 = 0x544;
                pub const m_responseCriteria: i64 = 0x798;
                pub const m_flAutomationDelay: i64 = 0x548;
                pub const m_flForceClientTime: i64 = 0x52C;
                pub const m_nSceneStringIndex: i64 = 0x5C0;
                pub const m_sTargetAttachment: i64 = 0x520;
                pub const m_OnPulseRequirement: i64 = 0x640;
                pub const m_bRemoveOnCompletion: i64 = 0x539;
                pub const m_bWaitingForInterrupt: i64 = 0x557;
                pub const m_iPlayerDeathBehavior: i64 = 0x7F4;
                pub const m_bPauseAtNextInterrupt: i64 = 0x555;
                pub const m_bCancelAtNextInterrupt: i64 = 0x538;
                pub const m_hNotifySceneCompletion: i64 = 0x7A8;
                pub const m_bInterruptSceneFinished: i64 = 0x7A3;
                pub const m_bInterruptedActorsScenes: i64 = 0x558;
            };
            pub const CSkillDamage = struct {
                pub const m_flDamage: i64 = 0x0;
                pub const m_flPhysicsForceDamage: i64 = 0x14;
                pub const m_flNPCDamageScalarVsNPC: i64 = 0x10;
            };
            pub const CTankTrainAI = struct {
                pub const m_hTrain: i64 = 0x4A8;
                pub const m_soundPlaying: i64 = 0x4B0;
                pub const m_hTargetEntity: i64 = 0x4AC;
                pub const m_startSoundName: i64 = 0x4C8;
                pub const m_engineSoundName: i64 = 0x4D0;
                pub const m_targetEntityName: i64 = 0x4E0;
                pub const m_movementSoundName: i64 = 0x4D8;
            };
            pub const CTestPulseIO = struct {
                pub const m_OnVariantInt: i64 = 0x4E0;
                pub const m_OnVariantBool: i64 = 0x4C0;
                pub const m_OnVariantVoid: i64 = 0x4A8;
                pub const m_TestComponent: i64 = 0x590;
                pub const m_OnVariantColor: i64 = 0x540;
                pub const m_OnVariantFloat: i64 = 0x500;
                pub const m_OnVariantString: i64 = 0x520;
                pub const m_OnVariantVector: i64 = 0x560;
                pub const m_OnInternalTestInt: i64 = 0x5F8;
                pub const m_bAllowEmptyInputs: i64 = 0x588;
                pub const m_OnInternalTestBool: i64 = 0x5D8;
                pub const m_OnInternalTestVoid: i64 = 0x5C0;
                pub const m_OnInternalTestColor: i64 = 0x658;
                pub const m_OnInternalTestFloat: i64 = 0x618;
                pub const m_OnInternalTestString: i64 = 0x638;
                pub const m_OnInternalTestVector: i64 = 0x678;
                pub const m_OnInternalTestEntityName: i64 = 0x6A0;
                pub const m_OnInternalTestSchemaEnum: i64 = 0x6E0;
                pub const m_OnInternalTestFloatString: i64 = 0x700;
                pub const m_OnInternalTestEntityHandle: i64 = 0x6C0;
                pub const m_OnInternalTestEntityHandleInt: i64 = 0x750;
                pub const m_OnInternalTestEntityNameString: i64 = 0x728;
                pub const m_OnInternalTestStringStringString: i64 = 0x770;
            };
            pub const CTimerEntity = struct {
                pub const m_OnTimer: i64 = 0x4A8;
                pub const m_bPaused: i64 = 0x514;
                pub const m_iDisabled: i64 = 0x4F0;
                pub const m_OnTimerLow: i64 = 0x4D8;
                pub const m_OnTimerHigh: i64 = 0x4C0;
                pub const m_bUpDownState: i64 = 0x4FC;
                pub const m_flRefireTime: i64 = 0x4F8;
                pub const m_flInitialDelay: i64 = 0x4F4;
                pub const m_iUseRandomTime: i64 = 0x500;
                pub const m_flRemainingTime: i64 = 0x510;
                pub const m_bPauseAfterFiring: i64 = 0x504;
                pub const m_flLowerRandomBound: i64 = 0x508;
                pub const m_flUpperRandomBound: i64 = 0x50C;
            };
            pub const CTriggerHurt = struct {
                pub const m_OnHurt: i64 = 0xA00;
                pub const m_flDamage: i64 = 0x9CC;
                pub const m_bNoDmgForce: i64 = 0x9E4;
                pub const m_damageModel: i64 = 0x9E0;
                pub const m_flDamageCap: i64 = 0x9D0;
                pub const m_thinkAlways: i64 = 0x9F4;
                pub const m_OnHurtPlayer: i64 = 0xA18;
                pub const m_hurtEntities: i64 = 0xA30;
                pub const m_vDamageForce: i64 = 0x9E8;
                pub const m_flLastDmgTime: i64 = 0x9D4;
                pub const m_hurtThinkPeriod: i64 = 0x9F8;
                pub const m_flOriginalDamage: i64 = 0x9C8;
                pub const m_bitsDamageInflict: i64 = 0x9DC;
                pub const m_flForgivenessDelay: i64 = 0x9D8;
            };
            pub const CTriggerLook = struct {
                pub const m_b2DFOV: i64 = 0x9FA;
                pub const m_OnEndLook: i64 = 0xA30;
                pub const m_OnTimeout: i64 = 0xA00;
                pub const m_bIsLooking: i64 = 0x9F9;
                pub const m_flLookTime: i64 = 0x9E8;
                pub const m_OnStartLook: i64 = 0xA18;
                pub const m_hLookTarget: i64 = 0x9E0;
                pub const m_bUseVelocity: i64 = 0x9FB;
                pub const m_bTimeoutFired: i64 = 0x9F8;
                pub const m_flFieldOfView: i64 = 0x9E4;
                pub const m_bTestOcclusion: i64 = 0x9FC;
                pub const m_flLookTimeLast: i64 = 0x9F0;
                pub const m_flLookTimeTotal: i64 = 0x9EC;
                pub const m_flTimeoutDuration: i64 = 0x9F4;
                pub const m_bTestAllVisibleOcclusion: i64 = 0x9FD;
            };
            pub const CTriggerOnce = struct {

            };
            pub const CTriggerPush = struct {
                pub const m_flSpeed: i64 = 0x9F8;
                pub const m_PathSimple: i64 = 0x9F0;
                pub const m_bUsePathSimple: i64 = 0x9E1;
                pub const m_splinePushType: i64 = 0x9F4;
                pub const m_iszPathSimpleName: i64 = 0x9E8;
                pub const m_angPushEntitySpace: i64 = 0x9C8;
                pub const m_bTriggerOnStartTouch: i64 = 0x9E0;
                pub const m_vecPushDirEntitySpace: i64 = 0x9D4;
            };
            pub const CTriggerSave = struct {
                pub const m_minHitPoints: i64 = 0x9D0;
                pub const m_fDangerousTimer: i64 = 0x9CC;
                pub const m_flRetriggerDelay: i64 = 0x9D4;
                pub const m_bForceNewLevelUnit: i64 = 0x9C8;
            };
            pub const CWaterBullet = struct {

            };
            pub const CWeaponBizon = struct {

            };
            pub const CWeaponCZ75a = struct {
                pub const m_bMagazineRemoved: i64 = 0x12A0;
            };
            pub const CWeaponElite = struct {

            };
            pub const CWeaponFamas = struct {

            };
            pub const CWeaponG3SG1 = struct {

            };
            pub const CWeaponGlock = struct {

            };
            pub const CWeaponMAC10 = struct {

            };
            pub const CWeaponMP5SD = struct {

            };
            pub const CWeaponNegev = struct {

            };
            pub const CWeaponSG556 = struct {

            };
            pub const CWeaponSSG08 = struct {

            };
            pub const CWeaponTaser = struct {
                pub const m_fFireTime: i64 = 0x12A0;
                pub const m_nLastAttackTick: i64 = 0x12A4;
            };
            pub const CWeaponUMP45 = struct {

            };
            pub const FilterHealth = struct {
                pub const m_iHealthMax: i64 = 0x4E8;
                pub const m_iHealthMin: i64 = 0x4E4;
                pub const m_bAdrenalineActive: i64 = 0x4E0;
            };
            pub const INavObstacle = struct {
                pub const m_nId: i64 = 0x8;
            };
            pub const INavPathCost = struct {
                pub const m_navHull: i64 = 0x8;
            };
            pub const NavGravity_t = struct {
                pub const m_bDefault: i64 = 0xC;
                pub const m_vGravity: i64 = 0x0;
            };
            pub const CAI_Expresser = struct {
                pub const m_pOuter: i64 = 0x98;
                pub const m_voicePitch: i64 = 0x70;
                pub const m_ruleCooldowns: i64 = 0x38;
                pub const m_flStopTalkTime: i64 = 0x60;
                pub const m_conceptCooldowns: i64 = 0x10;
                pub const m_flBlockedTalkTime: i64 = 0x6C;
                pub const m_flQueuedSpeechTime: i64 = 0x68;
                pub const m_nLastSpokenPriority: i64 = 0x7C;
                pub const m_bSceneEntityDisabled: i64 = 0x7A;
                pub const m_flLastTimeAcceptedSpeak: i64 = 0x74;
                pub const m_bAllowSpeakingInterrupts: i64 = 0x78;
                pub const m_flStopTalkTimeWithoutDelay: i64 = 0x64;
                pub const m_bConsiderSceneInvolvementAsSpeech: i64 = 0x79;
            };
            pub const CBasePropDoor = struct {
                pub const m_ls: i64 = 0xCF0;
                pub const m_OnOpen: i64 = 0xE48;
                pub const m_OnClose: i64 = 0xE30;
                pub const m_bLocked: i64 = 0xCCC;
                pub const m_bNoNPCs: i64 = 0xCCD;
                pub const m_flSpeed: i64 = 0xD24;
                pub const m_hMaster: i64 = 0xD98;
                pub const m_hBlocker: i64 = 0xCE8;
                pub const m_SlaveName: i64 = 0xD90;
                pub const m_SoundLock: i64 = 0xD58;
                pub const m_SoundOpen: i64 = 0xD48;
                pub const m_hDoorList: i64 = 0xCA8;
                pub const m_OnAjarOpen: i64 = 0xE78;
                pub const m_SoundClose: i64 = 0xD50;
                pub const m_SoundLatch: i64 = 0xD68;
                pub const m_SoundPound: i64 = 0xD70;
                pub const m_eDoorState: i64 = 0xCC8;
                pub const m_hActivator: i64 = 0xD20;
                pub const m_OnFullyOpen: i64 = 0xE18;
                pub const m_OnLockedUse: i64 = 0xE60;
                pub const m_SoundJiggle: i64 = 0xD78;
                pub const m_SoundMoving: i64 = 0xD40;
                pub const m_SoundUnlock: i64 = 0xD60;
                pub const m_bForceClosed: i64 = 0xD10;
                pub const m_closedAngles: i64 = 0xCDC;
                pub const m_OnFullyClosed: i64 = 0xE00;
                pub const m_bFirstBlocked: i64 = 0xCEC;
                pub const m_nHardwareType: i64 = 0xCC0;
                pub const m_bNeedsHardware: i64 = 0xCC4;
                pub const m_closedPosition: i64 = 0xCD0;
                pub const m_SoundLockedAnim: i64 = 0xD80;
                pub const m_OnBlockedClosing: i64 = 0xDA0;
                pub const m_OnBlockedOpening: i64 = 0xDB8;
                pub const m_nPhysicsMaterial: i64 = 0xD8C;
                pub const m_numCloseAttempts: i64 = 0xD88;
                pub const m_flAutoReturnDelay: i64 = 0xCA0;
                pub const m_OnUnblockedClosing: i64 = 0xDD0;
                pub const m_OnUnblockedOpening: i64 = 0xDE8;
                pub const m_vecLatchWorldPosition: i64 = 0xD14;
            };
            pub const CCSPlayerPawn = struct {
                pub const m_pBot: i64 = 0x1510;
                pub const m_bIsScoped: i64 = 0x14CC;
                pub const m_ArmorValue: i64 = 0x1524;
                pub const m_EconGloves: i64 = 0x1058;
                pub const m_LastHitBox: i64 = 0x150C;
                pub const m_bInBuyZone: i64 = 0xF61;
                pub const m_bIsWalking: i64 = 0x1488;
                pub const m_nSpotRules: i64 = 0x14C8;
                pub const m_bInBombZone: i64 = 0xF82;
                pub const m_bIsDefusing: i64 = 0x14CE;
                pub const m_bIsSpawning: i64 = 0x1534;
                pub const m_bLeftHanded: i64 = 0x1470;
                pub const m_bResumeZoom: i64 = 0x14CD;
                pub const m_iDeathFlags: i64 = 0x1540;
                pub const m_iShotsFired: i64 = 0x14E8;
                pub const m_strVOPrefix: i64 = 0xE68;
                pub const m_angEyeAngles: i64 = 0x15C0;
                pub const m_lastLandTime: i64 = 0xFD8;
                pub const m_pBuyServices: i64 = 0xE38;
                pub const m_bHasDeathInfo: i64 = 0x1544;
                pub const m_bWasInBuyZone: i64 = 0xF80;
                pub const m_flFlinchStack: i64 = 0x14EC;
                pub const m_iPlayerLocked: i64 = 0xFE0;
                pub const m_bIsBuyMenuOpen: i64 = 0xFA0;
                pub const m_flViewmodelFOV: i64 = 0x1484;
                pub const m_iBombSiteIndex: i64 = 0x14DC;
                pub const m_nWhichBombZone: i64 = 0x14E0;
                pub const m_pRadioServices: i64 = 0xE50;
                pub const m_bBotAllowActive: i64 = 0x1518;
                pub const m_bHasFemaleVoice: i64 = 0xE62;
                pub const m_bInNoDefuseArea: i64 = 0x14D8;
                pub const m_flDeathInfoTime: i64 = 0x1548;
                pub const m_flEmitSoundTime: i64 = 0x14D4;
                pub const m_pBulletServices: i64 = 0xE28;
                pub const m_qDeathEyeAngles: i64 = 0x1464;
                pub const m_szLastPlaceName: i64 = 0xE70;
                pub const m_TouchingBuyZones: i64 = 0xF68;
                pub const m_bGunGameImmunity: i64 = 0x15B8;
                pub const m_bWaitForNoAttack: i64 = 0x1500;
                pub const m_iRetakesOffering: i64 = 0xF84;
                pub const m_nLastKillerIndex: i64 = 0x14A8;
                pub const m_pHostageServices: i64 = 0xE30;
                pub const m_bKilledByHeadshot: i64 = 0x1508;
                pub const m_bOnGroundLastTick: i64 = 0xFDC;
                pub const m_pAimPunchServices: i64 = 0xE48;
                pub const m_bInBombZoneTrigger: i64 = 0x14E4;
                pub const m_bIsGrabbingHostage: i64 = 0x14CF;
                pub const m_entitySpottedState: i64 = 0x14B0;
                pub const m_fLastGivenBombTime: i64 = 0x1490;
                pub const m_fMolotovDamageTime: i64 = 0x15BC;
                pub const m_flTimeOfLastInjury: i64 = 0xFE8;
                pub const m_flVelocityModifier: i64 = 0x14F0;
                pub const m_flViewmodelOffsetX: i64 = 0x1478;
                pub const m_flViewmodelOffsetY: i64 = 0x147C;
                pub const m_flViewmodelOffsetZ: i64 = 0x1480;
                pub const m_nCharacterDefIndex: i64 = 0xE60;
                pub const m_nEconGlovesChanged: i64 = 0x1440;
                pub const m_nRagdollDamageBone: i64 = 0xFF4;
                pub const m_vecDeathInfoOrigin: i64 = 0x154C;
                pub const m_vecStashedVelocity: i64 = 0x159C;
                pub const m_allowAutoFollowTime: i64 = 0x14A0;
                pub const m_bInHostageResetZone: i64 = 0xF60;
                pub const m_iDisplayHistoryBits: i64 = 0x1498;
                pub const m_nLastPickupPriority: i64 = 0x151C;
                pub const m_vRagdollDamageForce: i64 = 0xFF8;
                pub const m_vecTotalBulletForce: i64 = 0x14F4;
                pub const m_GunGameImmunityColor: i64 = 0x156C;
                pub const m_bInHostageRescueZone: i64 = 0xF81;
                pub const m_bResetArmorNextSpawn: i64 = 0x14A4;
                pub const m_bRetakesHasDefuseKit: i64 = 0xF8C;
                pub const m_bRetakesMVPLastRound: i64 = 0xF8D;
                pub const m_flLandingTimeSeconds: i64 = 0xF9C;
                pub const m_flNextSprayDecalTime: i64 = 0xFEC;
                pub const m_hActiveMinimapVolume: i64 = 0x1460;
                pub const m_iRetakesMVPBoostItem: i64 = 0xF90;
                pub const m_iRetakesOfferingCard: i64 = 0xF88;
                pub const m_ignoreLadderJumpTime: i64 = 0x1504;
                pub const m_pDamageReactServices: i64 = 0xE58;
                pub const m_vRagdollServerOrigin: i64 = 0x1048;
                pub const m_angStashedShootAngles: i64 = 0x1578;
                pub const m_bWasInBombZoneTrigger: i64 = 0x14E5;
                pub const m_fLastGivenDefuserTime: i64 = 0x148C;
                pub const m_wasNotKilledNaturally: i64 = 0x15B1;
                pub const m_bRagdollDamageHeadshot: i64 = 0x1044;
                pub const m_flLastAttackedTeammate: i64 = 0x149C;
                pub const m_iLastWeaponFireUsercmd: i64 = 0x1530;
                pub const m_bWasInHostageRescueZone: i64 = 0xF83;
                pub const m_fSwitchedHandednessTime: i64 = 0x1474;
                pub const m_pActionTrackingServices: i64 = 0xE40;
                pub const m_unCurrentEquipmentValue: i64 = 0x1528;
                pub const m_flLastPickupPriorityTime: i64 = 0x1520;
                pub const m_vecCurrentMinimapVolumes: i64 = 0x1448;
                pub const m_bGrenadeParametersStashed: i64 = 0x1574;
                pub const m_grenadeParameterStashTime: i64 = 0x1570;
                pub const m_szRagdollDamageWeaponName: i64 = 0x1004;
                pub const m_vecPlayerPatchEconIndices: i64 = 0x1558;
                pub const m_fImmuneToGunGameDamageTime: i64 = 0x15B4;
                pub const m_unRoundStartEquipmentValue: i64 = 0x152A;
                pub const m_RetakesMVPBoostExtraUtility: i64 = 0xF94;
                pub const m_bNextSprayDecalTimeExpedited: i64 = 0xFF0;
                pub const m_iBlockingUseActionInProgress: i64 = 0x14D0;
                pub const m_unFreezetimeEndEquipmentValue: i64 = 0x152C;
                pub const m_bCommittingSuicideOnTeamChange: i64 = 0x15B0;
                pub const m_vecStashedGrenadeThrowPosition: i64 = 0x1584;
                pub const m_flHealthShotBoostExpirationTime: i64 = 0xF98;
                pub const m_vecStashedGrenadeThrowPawnCenter: i64 = 0x1590;
                pub const m_flDealtDamageToEnemyMostRecentTimestamp: i64 = 0x1494;
            };
            pub const CCSWeaponBase = struct {
                pub const m_donated: i64 = 0x1034;
                pub const m_bInReload: i64 = 0xFA8;
                pub const m_bStealthy: i64 = 0xFC4;
                pub const m_nDropTick: i64 = 0x1010;
                pub const m_bBurstMode: i64 = 0xF9C;
                pub const m_hPrevOwner: i64 = 0x100C;
                pub const m_weaponMode: i64 = 0xF70;
                pub const m_bRemoveable: i64 = 0xEF8;
                pub const m_bSilencerOn: i64 = 0xFBD;
                pub const m_nDeployTick: i64 = 0xFAC;
                pub const m_bFireOnEmpty: i64 = 0xF50;
                pub const m_iRecoilIndex: i64 = 0xF94;
                pub const m_bIsHauledBack: i64 = 0xFBC;
                pub const m_bWasOwnedByCT: i64 = 0x103C;
                pub const m_fLastShotTime: i64 = 0x1038;
                pub const m_flRecoilIndex: i64 = 0xF98;
                pub const m_OnPlayerPickup: i64 = 0xF58;
                pub const m_bCanBePickedUp: i64 = 0xFF8;
                pub const m_iIronSightMode: i64 = 0x10B8;
                pub const m_bInspectPending: i64 = 0xF08;
                pub const m_flDroppedAtTime: i64 = 0xFB4;
                pub const m_flLastShakeTime: i64 = 0x10D0;
                pub const m_flWatTickOffset: i64 = 0x10C0;
                pub const m_fAccuracyPenalty: i64 = 0xF88;
                pub const m_bInspectShouldLoop: i64 = 0xF09;
                pub const m_bRequireUseToTouch: i64 = 0xEFA;
                pub const m_nextOwnerTouchTime: i64 = 0xFFC;
                pub const m_IronSightController: i64 = 0x10A0;
                pub const m_bDroppedNearBuyZone: i64 = 0xFDC;
                pub const m_flTurningInaccuracy: i64 = 0xF84;
                pub const m_iOriginalTeamNumber: i64 = 0xFD4;
                pub const m_bWasOwnedByTerrorist: i64 = 0x103D;
                pub const m_nextPrevOwnerUseTime: i64 = 0x1008;
                pub const m_bReloadHeldSinceStart: i64 = 0xFCC;
                pub const m_flAttackHoldStartTime: i64 = 0xFB0;
                pub const m_iMostRecentTeamNumber: i64 = 0xFD8;
                pub const m_nLastEmptySoundCmdNum: i64 = 0xF34;
                pub const m_bInSilentReloadSection: i64 = 0xFC5;
                pub const m_flStealthHoldStartTime: i64 = 0xFC8;
                pub const m_nextPrevOwnerTouchTime: i64 = 0x1000;
                pub const m_flPostponeFireReadyFrac: i64 = 0xFA4;
                pub const m_nPostponeFireReadyTicks: i64 = 0xFA0;
                pub const m_bPlayerAmmoStockOnPickup: i64 = 0xEF9;
                pub const m_bSilentReloadStatCounted: i64 = 0xFC6;
                pub const m_bSilentReloadStatPending: i64 = 0xFC7;
                pub const m_fAccuracySmoothedForZoom: i64 = 0xF90;
                pub const m_flLastAccuracyUpdateTime: i64 = 0xF8C;
                pub const m_flTurningInaccuracyDelta: i64 = 0xF74;
                pub const m_iWeaponGameplayAnimState: i64 = 0xEFC;
                pub const m_flLastLOSTraceFailureTime: i64 = 0x10BC;
                pub const m_flWeaponActionPlaybackRate: i64 = 0xFD0;
                pub const m_bWasActiveWeaponWhenDropped: i64 = 0x1014;
                pub const m_flInspectCancelCompleteTime: i64 = 0xF04;
                pub const m_numRemoveUnownedWeaponThink: i64 = 0x1040;
                pub const m_flNextAttackRenderTimeOffset: i64 = 0xFE0;
                pub const m_flTimeSilencerSwitchComplete: i64 = 0xFC0;
                pub const m_vecTurningInaccuracyEyeDirLast: i64 = 0xF78;
                pub const m_bUseCanOverrideNextOwnerTouchTime: i64 = 0xFF9;
                pub const m_flWeaponGameplayAnimStateTimestamp: i64 = 0xF00;
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
            pub const CDebugHistory = struct {
                pub const m_nNpcEvents: i64 = 0x3E84E8;
            };
            pub const CDecoyGrenade = struct {

            };
            pub const CDynamicLight = struct {
                pub const m_On: i64 = 0x853;
                pub const m_Flags: i64 = 0x851;
                pub const m_Radius: i64 = 0x854;
                pub const m_Exponent: i64 = 0x858;
                pub const m_InnerAngle: i64 = 0x85C;
                pub const m_LightStyle: i64 = 0x852;
                pub const m_OuterAngle: i64 = 0x860;
                pub const m_SpotRadius: i64 = 0x864;
                pub const m_ActualFlags: i64 = 0x850;
            };
            pub const CEconItemView = struct {
                pub const m_iItemID: i64 = 0x48;
                pub const m_iAccountID: i64 = 0x58;
                pub const m_iItemIDLow: i64 = 0x54;
                pub const m_iItemIDHigh: i64 = 0x50;
                pub const m_bInitialized: i64 = 0x68;
                pub const m_iEntityLevel: i64 = 0x40;
                pub const m_szCustomName: i64 = 0x160;
                pub const m_AttributeList: i64 = 0x70;
                pub const m_iEntityQuality: i64 = 0x3C;
                pub const m_iInventoryPosition: i64 = 0x5C;
                pub const m_iItemDefinitionIndex: i64 = 0x38;
                pub const m_szCustomNameOverride: i64 = 0x201;
                pub const m_szCustomNameOverride2: i64 = 0x2A2;
                pub const m_szCustomNameOverride3: i64 = 0x343;
                pub const m_NetworkedDynamicAttributes: i64 = 0xE8;
            };
            pub const CEconWearable = struct {
                pub const m_nForceSkin: i64 = 0xEB0;
                pub const m_bAlwaysAllow: i64 = 0xEB4;
            };
            pub const CEnvExplosion = struct {
                pub const m_hInflictor: i64 = 0x864;
                pub const m_iMagnitude: i64 = 0x850;
                pub const m_iClassIgnore: i64 = 0x88C;
                pub const m_bCreateDebris: i64 = 0x86D;
                pub const m_flDamageForce: i64 = 0x860;
                pub const m_flInnerRadius: i64 = 0x85C;
                pub const m_hEntityIgnore: i64 = 0x8A0;
                pub const m_iClassIgnore2: i64 = 0x890;
                pub const m_flPlayerDamage: i64 = 0x854;
                pub const m_iRadiusOverride: i64 = 0x858;
                pub const m_iCustomDamageType: i64 = 0x868;
                pub const m_iszCustomSoundName: i64 = 0x880;
                pub const m_iszCustomEffectName: i64 = 0x878;
                pub const m_iszEntityIgnoreName: i64 = 0x898;
                pub const m_bHasCustomDamageType: i64 = 0x86C;
                pub const m_bSuppressParticleImpulse: i64 = 0x888;
            };
            pub const CEnvViewPunch = struct {
                pub const m_flRadius: i64 = 0x4A8;
                pub const m_angViewPunch: i64 = 0x4AC;
            };
            pub const CFuncConveyor = struct {
                pub const m_flSpeed: i64 = 0x85C;
                pub const m_flTargetSpeed: i64 = 0x878;
                pub const m_flFrictionScale: i64 = 0x888;
                pub const m_hConveyorModels: i64 = 0x890;
                pub const m_szConveyorModels: i64 = 0x850;
                pub const m_angMoveEntitySpace: i64 = 0x860;
                pub const m_nTransitionStartTick: i64 = 0x87C;
                pub const m_vecMoveDirEntitySpace: i64 = 0x86C;
                pub const m_flTransitionStartSpeed: i64 = 0x884;
                pub const m_nTransitionDurationTicks: i64 = 0x880;
                pub const m_flTransitionDurationSeconds: i64 = 0x858;
            };
            pub const CFuncRotating = struct {
                pub const m_flSpeed: i64 = 0x8A4;
                pub const m_angStart: i64 = 0x8EC;
                pub const m_flVolume: i64 = 0x8B0;
                pub const m_OnStarted: i64 = 0x868;
                pub const m_OnStopped: i64 = 0x850;
                pub const m_bReversed: i64 = 0x8C8;
                pub const m_flMaxSpeed: i64 = 0x8B8;
                pub const m_bAccelDecel: i64 = 0x8C9;
                pub const m_NoiseRunning: i64 = 0x8C0;
                pub const m_flAttenuation: i64 = 0x8AC;
                pub const m_flBlockDamage: i64 = 0x8BC;
                pub const m_flFanFriction: i64 = 0x8A8;
                pub const m_flTargetSpeed: i64 = 0x8B4;
                pub const m_OnReachedStart: i64 = 0x880;
                pub const m_bStopAtStartPos: i64 = 0x8F8;
                pub const m_prevLocalAngles: i64 = 0x8E0;
                pub const m_vecClientAngles: i64 = 0x908;
                pub const m_vecClientOrigin: i64 = 0x8FC;
                pub const m_localRotationVector: i64 = 0x898;
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
            pub const CInfoLandmark = struct {

            };
            pub const CLogicCompare = struct {
                pub const m_OnEqualTo: i64 = 0x4D0;
                pub const m_flInValue: i64 = 0x4A8;
                pub const m_OnLessThan: i64 = 0x4B0;
                pub const m_OnNotEqualTo: i64 = 0x4F0;
                pub const m_OnGreaterThan: i64 = 0x510;
                pub const m_flCompareValue: i64 = 0x4AC;
            };
            pub const CMarkupVolume = struct {
                pub const m_bDisabled: i64 = 0x850;
            };
            pub const CNavAttribute = struct {

            };
            pub const CNavHullVData = struct {
                pub const m_agentHeight: i64 = 0x8;
                pub const m_agentRadius: i64 = 0x4;
                pub const m_agentMaxClimb: i64 = 0x1C;
                pub const m_agentMaxSlope: i64 = 0x20;
                pub const m_bAgentEnabled: i64 = 0x0;
                pub const m_agentCrawlHeight: i64 = 0x18;
                pub const m_agentShortHeight: i64 = 0x10;
                pub const m_agentCrawlEnabled: i64 = 0x14;
                pub const m_agentBorderErosion: i64 = 0x30;
                pub const m_agentMaxJumpUpDist: i64 = 0x2C;
                pub const m_agentMaxJumpDownDist: i64 = 0x24;
                pub const m_flowMapNodeMaxRadius: i64 = 0x38;
                pub const m_agentShortHeightEnabled: i64 = 0xC;
                pub const m_flowMapGenerationEnabled: i64 = 0x34;
                pub const m_agentMaxJumpHorizDistBase: i64 = 0x28;
            };
            pub const CNavSpaceInfo = struct {

            };
            pub const CNavVolumeAll = struct {

            };
            pub const COrnamentProp = struct {
                pub const m_initialOwner: i64 = 0xC90;
            };
            pub const CPathKeyFrame = struct {
                pub const m_Angles: i64 = 0x4B4;
                pub const m_Origin: i64 = 0x4A8;
                pub const m_qAngle: i64 = 0x4C0;
                pub const m_iNextKey: i64 = 0x4D0;
                pub const m_pNextKey: i64 = 0x4DC;
                pub const m_pPrevKey: i64 = 0x4E0;
                pub const m_flNextTime: i64 = 0x4D8;
                pub const m_flMoveSpeed: i64 = 0x4E4;
            };
            pub const CPhysThruster = struct {
                pub const m_localOrigin: i64 = 0x508;
            };
            pub const CPhysicsShake = struct {
                pub const m_force: i64 = 0x8;
            };
            pub const CRandSimTimer = struct {
                pub const m_flMaxInterval: i64 = 0xC;
                pub const m_flMinInterval: i64 = 0x8;
            };
            pub const CRopeKeyframe = struct {
                pub const m_Slack: i64 = 0x868;
                pub const m_Width: i64 = 0x86C;
                pub const m_Subdiv: i64 = 0x888;
                pub const m_RopeFlags: i64 = 0x858;
                pub const m_hEndPoint: i64 = 0x89C;
                pub const m_nSegments: i64 = 0x874;
                pub const m_RopeLength: i64 = 0x88A;
                pub const m_hStartPoint: i64 = 0x898;
                pub const m_TextureScale: i64 = 0x870;
                pub const m_nChangeCount: i64 = 0x889;
                pub const m_fLockedPoints: i64 = 0x88C;
                pub const m_flScrollSpeed: i64 = 0x890;
                pub const m_iNextLinkName: i64 = 0x860;
                pub const m_bEndPointValid: i64 = 0x895;
                pub const m_iEndAttachment: i64 = 0x8A1;
                pub const m_bStartPointValid: i64 = 0x894;
                pub const m_iStartAttachment: i64 = 0x8A0;
                pub const m_bCreatedFromMapFile: i64 = 0x88D;
                pub const m_strRopeMaterialModel: i64 = 0x878;
                pub const m_iRopeMaterialModelIndex: i64 = 0x880;
                pub const m_bConstrainBetweenEndpoints: i64 = 0x875;
            };
            pub const CSmokeGrenade = struct {

            };
            pub const CSpotlightEnd = struct {
                pub const m_Radius: i64 = 0x854;
                pub const m_flLightScale: i64 = 0x850;
                pub const m_vSpotlightDir: i64 = 0x858;
                pub const m_vSpotlightOrg: i64 = 0x864;
            };
            pub const CTriggerBrush = struct {
                pub const m_OnUse: i64 = 0x880;
                pub const m_OnEndTouch: i64 = 0x868;
                pub const m_OnStartTouch: i64 = 0x850;
                pub const m_iInputFilter: i64 = 0x898;
                pub const m_iDontMessageParent: i64 = 0x89C;
            };
            pub const CWeaponSCAR20 = struct {

            };
            pub const CWeaponXM1014 = struct {

            };
            pub const CodeGenAABB_t = struct {
                pub const m_vMaxBounds: i64 = 0xC;
                pub const m_vMinBounds: i64 = 0x0;
            };
            pub const IntervalTimer = struct {
                pub const m_timestamp: i64 = 0x8;
                pub const m_nWorldGroupId: i64 = 0xC;
            };
            pub const QuestProgress = struct {

            };
            pub const audioparams_t = struct {
                pub const localBits: i64 = 0x6C;
                pub const localSound: i64 = 0x8;
                pub const soundEventHash: i64 = 0x74;
                pub const soundscapeIndex: i64 = 0x68;
                pub const soundscapeEntityListIndex: i64 = 0x70;
            };
            pub const dynpitchvol_t = struct {

            };
            pub const entitytable_t = struct {
                pub const id: i64 = 0x0;
                pub const flags: i64 = 0x18;
                pub const bWasSaved: i64 = 0x14;
                pub const classname: i64 = 0x20;
                pub const edictindex: i64 = 0x4;
                pub const entityname: i64 = 0x30;
                pub const globalname: i64 = 0x28;
                pub const saveentityindex: i64 = 0x8;
                pub const landmarkModelSpace: i64 = 0x38;
                pub const m_pPrecacheEntityKeys: i64 = 0x48;
            };
            pub const sky3dparams_t = struct {
                pub const fog: i64 = 0x20;
                pub const scale: i64 = 0x8;
                pub const origin: i64 = 0xC;
                pub const m_nWorldGroupID: i64 = 0x88;
                pub const bClip3DSkyBoxNearToWorldFar: i64 = 0x18;
                pub const flClip3DSkyBoxNearToWorldFarOffset: i64 = 0x1C;
            };
            pub const ActorMapping_t = struct {
                pub const m_hEntity: i64 = 0x8;
                pub const m_sActorName: i64 = 0x0;
            };
            pub const AmmoTypeInfo_t = struct {
                pub const m_flMass: i64 = 0x28;
                pub const m_nFlags: i64 = 0x24;
                pub const m_flSpeed: i64 = 0x2C;
                pub const m_nMaxCarry: i64 = 0x10;
                pub const m_nSplashSize: i64 = 0x1C;
            };
            pub const CAttributeList = struct {
                pub const m_pManager: i64 = 0x70;
                pub const m_Attributes: i64 = 0x8;
            };
            pub const CBaseAnimGraph = struct {
                pub const m_vecForce: i64 = 0x93C;
                pub const m_nForceBone: i64 = 0x948;
                pub const m_RagdollPose: i64 = 0x960;
                pub const m_bRagdollEnabled: i64 = 0x988;
                pub const m_pChoreoServices: i64 = 0x930;
                pub const m_pRagdollControl: i64 = 0x958;
                pub const m_bRagdollClientSide: i64 = 0x989;
                pub const m_OnLayerCycleUpdated: i64 = 0x8F8;
                pub const m_pMainGraphController: i64 = 0x8E8;
                pub const m_graphControllerManager: i64 = 0x850;
                pub const m_bAnimGraphUpdateEnabled: i64 = 0x938;
                pub const m_bAnimationUpdateScheduled: i64 = 0x939;
                pub const m_OnExternalChoreoGraphChanged: i64 = 0x918;
                pub const m_bShouldUpdateTransformations: i64 = 0x98A;
                pub const m_bInitiallyPopulateInterpHistory: i64 = 0x8F0;
                pub const m_xParentedRagdollRootInEntitySpace: i64 = 0x990;
            };
            pub const CBaseCSGrenade = struct {
                pub const m_bRedraw: i64 = 0x1280;
                pub const m_fDropTime: i64 = 0x1290;
                pub const m_bJumpThrow: i64 = 0x1283;
                pub const m_bPinPulled: i64 = 0x1282;
                pub const m_fThrowTime: i64 = 0x1288;
                pub const m_fPinPullTime: i64 = 0x1294;
                pub const m_nNextHoldTick: i64 = 0x129C;
                pub const m_bJustPulledPin: i64 = 0x1298;
                pub const m_flNextHoldFrac: i64 = 0x12A0;
                pub const m_bIsHeldByPlayer: i64 = 0x1281;
                pub const m_bThrowAnimating: i64 = 0x1284;
                pub const m_flThrowStrength: i64 = 0x128C;
                pub const m_hSwitchToWeaponAfterThrow: i64 = 0x12A4;
            };
            pub const CBasePlatTrain = struct {
                pub const m_volume: i64 = 0x8E8;
                pub const m_flTWidth: i64 = 0x8EC;
                pub const m_flTLength: i64 = 0x8F0;
                pub const m_NoiseMoving: i64 = 0x8D0;
                pub const m_NoiseArrived: i64 = 0x8D8;
            };
            pub const CBodyComponent = struct {
                pub const m_pSceneNode: i64 = 0x8;
                pub const __m_pChainEntity: i64 = 0x48;
            };
            pub const CBreakableProp = struct {
                pub const m_OnBreak: i64 = 0xAD0;
                pub const m_hBreaker: i64 = 0xB48;
                pub const m_OnStartDeath: i64 = 0xAB8;
                pub const m_OnTakeDamage: i64 = 0xB08;
                pub const m_iszPuntSound: i64 = 0xBB8;
                pub const m_bUsePuntSound: i64 = 0xBC0;
                pub const m_explodeDamage: i64 = 0xB6C;
                pub const m_explodeRadius: i64 = 0xB70;
                pub const m_hLastAttacker: i64 = 0xBB4;
                pub const m_iMinHealthDmg: i64 = 0xB24;
                pub const m_explosionDelay: i64 = 0xB80;
                pub const m_sExplosionType: i64 = 0xB78;
                pub const m_OnHealthChanged: i64 = 0xAE8;
                pub const m_PerformanceMode: i64 = 0xB4C;
                pub const m_flDefBurstScale: i64 = 0xB38;
                pub const m_flPressureDelay: i64 = 0xB34;
                pub const m_vDefBurstOffset: i64 = 0xB3C;
                pub const m_hPhysicsAttacker: i64 = 0xBA8;
                pub const m_bOriginalBlockLOS: i64 = 0xBC1;
                pub const m_explosionModifier: i64 = 0xBA0;
                pub const m_impactEnergyScale: i64 = 0xB20;
                pub const m_CPropDataComponent: i64 = 0xA78;
                pub const m_flDefaultFadeScale: i64 = 0xBB0;
                pub const m_explosionCustomSound: i64 = 0xB98;
                pub const m_preferredCarryAngles: i64 = 0xB28;
                pub const m_BreakableContentsType: i64 = 0xB54;
                pub const m_explosionBuildupSound: i64 = 0xB88;
                pub const m_explosionCustomEffect: i64 = 0xB90;
                pub const m_bHasBreakPiecesOrCommands: i64 = 0xB68;
                pub const m_flPreventDamageBeforeTime: i64 = 0xB50;
                pub const m_flLastPhysicsInfluenceTime: i64 = 0xBAC;
                pub const m_strBreakableContentsParticleOverride: i64 = 0xB60;
                pub const m_strBreakableContentsPropGroupOverride: i64 = 0xB58;
            };
            pub const CDecalInstance = struct {
                pub const m_Color: i64 = 0x60;
                pub const m_nFlags: i64 = 0x5C;
                pub const m_flDepth: i64 = 0x6C;
                pub const m_flWidth: i64 = 0x64;
                pub const m_hEntity: i64 = 0x14;
                pub const m_flHeight: i64 = 0x68;
                pub const m_vSAxisLS: i64 = 0x50;
                pub const m_hMaterial: i64 = 0x8;
                pub const m_vNormalLS: i64 = 0x38;
                pub const m_vNormalOS: i64 = 0x44;
                pub const m_mTransform: i64 = 0x70;
                pub const m_nBoneIndex: i64 = 0x18;
                pub const m_bIsAdjacent: i64 = 0xFE;
                pub const m_flPlaceTime: i64 = 0xD8;
                pub const m_sDecalGroup: i64 = 0x0;
                pub const m_vPositionLS: i64 = 0x20;
                pub const m_vPositionOS: i64 = 0x2C;
                pub const m_sSequenceName: i64 = 0x10;
                pub const m_flFadeDuration: i64 = 0xE0;
                pub const m_nSequenceIndex: i64 = 0xFC;
                pub const m_nTriangleIndex: i64 = 0x1C;
                pub const m_flFadeStartTime: i64 = 0xDC;
                pub const m_flAnimationScale: i64 = 0xD0;
                pub const m_mLocalToTriangle: i64 = 0xA0;
                pub const m_flBoundingRadiusSqr: i64 = 0xF8;
                pub const m_bDoDecalLightmapping: i64 = 0xFF;
                pub const m_flAnimationStartTime: i64 = 0xD4;
                pub const m_flLightingOriginOffset: i64 = 0xE4;
            };
            pub const CEntityBlocker = struct {

            };
            pub const CEnvCubemapBox = struct {

            };
            pub const CEnvCubemapFog = struct {
                pub const m_bActive: i64 = 0x4CC;
                pub const m_flLODBias: i64 = 0x4C8;
                pub const m_bFirstTime: i64 = 0x5A1;
                pub const m_hSkyMaterial: i64 = 0x4D8;
                pub const m_iszSkyEntity: i64 = 0x4E0;
                pub const m_flEndDistance: i64 = 0x4A8;
                pub const m_bStartDisabled: i64 = 0x4CD;
                pub const m_flFogHeightEnd: i64 = 0x4BC;
                pub const m_nHeightFogType: i64 = 0x4E8;
                pub const m_flFogMaxOpacity: i64 = 0x4D0;
                pub const m_flStartDistance: i64 = 0x4AC;
                pub const m_bHasHeightFogEnd: i64 = 0x5A0;
                pub const m_flFogHeightStart: i64 = 0x4C0;
                pub const m_flFogHeightWidth: i64 = 0x4B8;
                pub const m_nDistanceFogType: i64 = 0x4F4;
                pub const m_bHeightFogEnabled: i64 = 0x4B4;
                pub const m_hFogCubemapTexture: i64 = 0x598;
                pub const m_nCubemapSourceType: i64 = 0x4D4;
                pub const m_flFogHeightExponent: i64 = 0x4C4;
                pub const m_nFogHeightBlendMode: i64 = 0x4EC;
                pub const m_HeightFogCurveString: i64 = 0x500;
                pub const m_flFogFalloffExponent: i64 = 0x4B0;
                pub const m_DistanceFogCurveString: i64 = 0x4F8;
                pub const m_nFogHeightCoordinateSpace: i64 = 0x4F0;
            };
            pub const CEnvSoundscape = struct {
                pub const m_OnPlay: i64 = 0x4A8;
                pub const m_flRadius: i64 = 0x4C0;
                pub const m_bDisabled: i64 = 0x524;
                pub const m_positionNames: i64 = 0x4E0;
                pub const m_soundEventHash: i64 = 0x530;
                pub const m_soundEventName: i64 = 0x4C8;
                pub const m_soundscapeName: i64 = 0x528;
                pub const m_soundscapeIndex: i64 = 0x4D4;
                pub const m_hProxySoundscape: i64 = 0x520;
                pub const m_bOverrideWithEvent: i64 = 0x4D0;
                pub const m_soundscapeEntityListId: i64 = 0x4D8;
            };
            pub const CEnvWindShared = struct {
                pub const m_iMaxGust: i64 = 0x1A;
                pub const m_iMaxWind: i64 = 0x12;
                pub const m_iMinGust: i64 = 0x18;
                pub const m_iMinWind: i64 = 0x10;
                pub const m_location: i64 = 0x30;
                pub const m_OnGustEnd: i64 = 0x58;
                pub const m_hEntOwner: i64 = 0x70;
                pub const m_iWindSeed: i64 = 0xC;
                pub const m_windRadius: i64 = 0x14;
                pub const m_OnGustStart: i64 = 0x40;
                pub const m_flStartTime: i64 = 0x8;
                pub const m_flGustDuration: i64 = 0x24;
                pub const m_flMaxGustDelay: i64 = 0x20;
                pub const m_flMinGustDelay: i64 = 0x1C;
                pub const m_iGustDirChange: i64 = 0x28;
                pub const m_iInitialWindDir: i64 = 0x2A;
                pub const m_flInitialWindSpeed: i64 = 0x2C;
            };
            pub const CFilterContext = struct {
                pub const m_iFilterContext: i64 = 0x4E0;
            };
            pub const CFiringModeInt = struct {
                pub const m_nValues: i64 = 0x0;
            };
            pub const CFogController = struct {
                pub const m_fog: i64 = 0x4A8;
                pub const m_bUseAngles: i64 = 0x510;
                pub const m_iChangedVariables: i64 = 0x514;
            };
            pub const CFuncTankTrain = struct {
                pub const m_OnDeath: i64 = 0x978;
            };
            pub const CFuncTimescale = struct {
                pub const m_isStarted: i64 = 0x4B8;
                pub const m_flAcceleration: i64 = 0x4AC;
                pub const m_flMinBlendRate: i64 = 0x4B0;
                pub const m_flDesiredTimescale: i64 = 0x4A8;
                pub const m_flBlendDeltaMultiplier: i64 = 0x4B4;
            };
            pub const CFuncTrackAuto = struct {

            };
            pub const CGameSceneNode = struct {
                pub const m_name: i64 = 0xF0;
                pub const m_pChild: i64 = 0x40;
                pub const m_pOwner: i64 = 0x30;
                pub const m_flScale: i64 = 0xC4;
                pub const m_hParent: i64 = 0x70;
                pub const m_pParent: i64 = 0x38;
                pub const m_bDormant: i64 = 0xE7;
                pub const m_vecOrigin: i64 = 0x80;
                pub const m_flAbsScale: i64 = 0xE0;
                pub const m_angRotation: i64 = 0xB8;
                pub const m_nodeToWorld: i64 = 0x10;
                pub const m_pNextSibling: i64 = 0x48;
                pub const m_vecAbsOrigin: i64 = 0xC8;
                pub const m_angAbsRotation: i64 = 0xD4;
                pub const m_bBoneMergeFlex: i64 = 0x0;
                pub const m_nHierarchyType: i64 = 0xEC;
                pub const m_bDirtyHierarchy: i64 = 0x0;
                pub const m_nLatchAbsOrigin: i64 = 0x0;
                pub const m_flClientLocalScale: i64 = 0x108;
                pub const m_nHierarchicalDepth: i64 = 0xEB;
                pub const m_bDirtyBoneMergeInfo: i64 = 0x0;
                pub const m_hierarchyAttachName: i64 = 0x104;
                pub const m_bDebugAbsOriginChanges: i64 = 0xE6;
                pub const m_bNetworkedScaleChanged: i64 = 0x0;
                pub const m_bNetworkedAnglesChanged: i64 = 0x0;
                pub const m_nParentAttachmentOrBone: i64 = 0xE4;
                pub const m_bDirtyBoneMergeBoneToRoot: i64 = 0x0;
                pub const m_bForceParentToBeNetworked: i64 = 0xE8;
                pub const m_bNetworkedPositionChanged: i64 = 0x0;
                pub const m_bWillBeCallingPostDataUpdate: i64 = 0x0;
                pub const m_nDoNotSetAnimTimeInInvalidatePhysicsCount: i64 = 0xED;
            };
            pub const CInButtonState = struct {
                pub const m_pButtonStates: i64 = 0x8;
            };
            pub const CLogicAutosave = struct {
                pub const m_minHitPoints: i64 = 0x4AC;
                pub const m_bForceNewLevelUnit: i64 = 0x4A8;
                pub const m_minHitPointsToCommit: i64 = 0x4B0;
            };
            pub const CLogicalEntity = struct {

            };
            pub const CMessageEntity = struct {
                pub const m_radius: i64 = 0x4A8;
                pub const m_bEnabled: i64 = 0x4BA;
                pub const m_drawText: i64 = 0x4B8;
                pub const m_messageText: i64 = 0x4B0;
                pub const m_bDeveloperOnly: i64 = 0x4B9;
            };
            pub const CMoverPathNode = struct {
                pub const m_OnPassThrough: i64 = 0x540;
                pub const m_OnPassThroughForward: i64 = 0x560;
                pub const m_OnPassThroughReverse: i64 = 0x580;
                pub const m_OnStartFromOrInSegment: i64 = 0x500;
                pub const m_OnStoppedAtOrInSegment: i64 = 0x520;
            };
            pub const CPathQueryUtil = struct {
                pub const m_bIsClosedLoop: i64 = 0x78;
                pub const m_PathToEntityTransform: i64 = 0x10;
                pub const m_vecPathSampleDistances: i64 = 0x60;
                pub const m_vecPathSamplePositions: i64 = 0x30;
                pub const m_vecPathSampleParameters: i64 = 0x48;
            };
            pub const CPhysExplosion = struct {
                pub const m_radius: i64 = 0x4B4;
                pub const m_flDamage: i64 = 0x4B0;
                pub const m_flMagnitude: i64 = 0x4AC;
                pub const m_flPushScale: i64 = 0x4CC;
                pub const m_flInnerRadius: i64 = 0x4C8;
                pub const m_OnPushedPlayer: i64 = 0x4D8;
                pub const m_bExplodeOnSpawn: i64 = 0x4A8;
                pub const m_ignoreEntityName: i64 = 0x4C0;
                pub const m_targetEntityName: i64 = 0x4B8;
                pub const m_bDisablePushClamp: i64 = 0x4D2;
                pub const m_bAffectInvulnerableEnts: i64 = 0x4D1;
                pub const m_bConvertToDebrisWhenPossible: i64 = 0x4D0;
            };
            pub const CPhysicsSpring = struct {
                pub const m_end: i64 = 0x4DC;
                pub const m_start: i64 = 0x4D0;
                pub const m_flFrequency: i64 = 0x4B0;
                pub const m_flRestLength: i64 = 0x4B8;
                pub const m_pSpringJoint: i64 = 0x4A8;
                pub const m_teleportTick: i64 = 0x4E8;
                pub const m_nameAttachEnd: i64 = 0x4C8;
                pub const m_flDampingRatio: i64 = 0x4B4;
                pub const m_nameAttachStart: i64 = 0x4C0;
            };
            pub const CPointGiveAmmo = struct {
                pub const m_pActivator: i64 = 0x4A8;
            };
            pub const CPointTeleport = struct {
                pub const m_vSaveAngles: i64 = 0x4B4;
                pub const m_vSaveOrigin: i64 = 0x4A8;
                pub const m_bTeleportUseCurrentAngle: i64 = 0x4C1;
                pub const m_bTeleportParentedEntities: i64 = 0x4C0;
            };
            pub const CPointTemplate = struct {
                pub const m_iszWorldName: i64 = 0x4A8;
                pub const m_OnEntitySpawned: i64 = 0x510;
                pub const m_flTimeoutInterval: i64 = 0x4C0;
                pub const m_ScriptCallbackScope: i64 = 0x508;
                pub const m_ScriptSpawnCallback: i64 = 0x500;
                pub const m_iszEntityFilterName: i64 = 0x4B8;
                pub const m_ownerSpawnGroupType: i64 = 0x4CC;
                pub const m_SpawnedEntityHandles: i64 = 0x4E8;
                pub const m_clientOnlyEntityBehavior: i64 = 0x4C8;
                pub const m_createdSpawnGroupHandles: i64 = 0x4D0;
                pub const m_iszSource2EntityLumpName: i64 = 0x4B0;
                pub const m_bAsynchronouslySpawnEntities: i64 = 0x4C4;
            };
            pub const CPrecipitation = struct {

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
            pub const CRagdollMagnet = struct {
                pub const m_axis: i64 = 0x4B4;
                pub const m_force: i64 = 0x4B0;
                pub const m_radius: i64 = 0x4AC;
                pub const m_bDisabled: i64 = 0x4A8;
            };
            pub const CRandStopwatch = struct {
                pub const m_flMaxInterval: i64 = 0x10;
                pub const m_flMinInterval: i64 = 0xC;
            };
            pub const CResponseQueue = struct {
                pub const m_ExpresserTargets: i64 = 0x38;
            };
            pub const CRotatorTarget = struct {

            };
            pub const CSMatchStats_t = struct {
                pub const m_i1v1Wins: i64 = 0xA8;
                pub const m_i1v2Wins: i64 = 0xB0;
                pub const m_i1v1Count: i64 = 0xA4;
                pub const m_i1v2Count: i64 = 0xAC;
                pub const m_iEnemy2Ks: i64 = 0x7C;
                pub const m_iEnemy3Ks: i64 = 0x70;
                pub const m_iEnemy4Ks: i64 = 0x6C;
                pub const m_iEnemy5Ks: i64 = 0x68;
                pub const m_iEntryWins: i64 = 0xB8;
                pub const m_iEntryCount: i64 = 0xB4;
                pub const m_iFlash_Count: i64 = 0x8C;
                pub const m_iUtility_Count: i64 = 0x80;
                pub const m_iEnemyKnifeKills: i64 = 0x74;
                pub const m_iEnemyTaserKills: i64 = 0x78;
                pub const m_iFlash_Successes: i64 = 0x90;
                pub const m_iUtility_Enemies: i64 = 0x88;
                pub const m_nShotsFiredTotal: i64 = 0x9C;
                pub const m_iUtility_Successes: i64 = 0x84;
                pub const m_nShotsOnTargetTotal: i64 = 0xA0;
                pub const m_flHealthPointsDealtTotal: i64 = 0x98;
                pub const m_flHealthPointsRemovedTotal: i64 = 0x94;
            };
            pub const CSoundEnvelope = struct {
                pub const m_rate: i64 = 0x8;
                pub const m_target: i64 = 0x4;
                pub const m_current: i64 = 0x0;
                pub const m_forceupdate: i64 = 0xC;
            };
            pub const CStopwatchBase = struct {
                pub const m_bIsRunning: i64 = 0x8;
            };
            pub const CTeamplayRules = struct {

            };
            pub const CTriggerImpact = struct {
                pub const m_flNoise: i64 = 0x9E4;
                pub const m_flViewkick: i64 = 0x9E8;
                pub const m_flMagnitude: i64 = 0x9E0;
                pub const m_pOutputForce: i64 = 0x9F0;
            };
            pub const CTriggerRemove = struct {
                pub const m_OnRemove: i64 = 0x9C8;
            };
            pub const CTriggerVolume = struct {
                pub const m_hFilter: i64 = 0x858;
                pub const m_iFilterName: i64 = 0x850;
            };
            pub const CWeaponGalilAR = struct {

            };
            pub const CWeaponHKP2000 = struct {

            };
            pub const CountdownTimer = struct {
                pub const m_duration: i64 = 0x8;
                pub const m_timescale: i64 = 0x10;
                pub const m_timestamp: i64 = 0xC;
                pub const m_nWorldGroupId: i64 = 0x14;
            };
            pub const IHasAttributes = struct {

            };
            pub const ParticleNode_t = struct {
                pub const m_iIndex: i64 = 0x4;
                pub const m_hEntity: i64 = 0x0;
                pub const m_flStartTime: i64 = 0x8;
                pub const m_flEndcapTime: i64 = 0x1C;
                pub const m_vecGrowthOrigin: i64 = 0x10;
                pub const m_bMarkedForDelete: i64 = 0x20;
                pub const m_flGrowthDuration: i64 = 0xC;
            };
            pub const Relationship_t = struct {
                pub const priority: i64 = 0x4;
                pub const disposition: i64 = 0x0;
            };
            pub const ResponseParams = struct {
                pub const odds: i64 = 0x10;
                pub const flags: i64 = 0x12;
                pub const m_pFollowup: i64 = 0x18;
            };
            pub const SceneEventId_t = struct {
                pub const m_Value: i64 = 0x0;
            };
            pub const SoundCommand_t = struct {
                pub const m_time: i64 = 0x8;
                pub const m_value: i64 = 0x14;
                pub const m_command: i64 = 0x10;
                pub const m_deltaTime: i64 = 0xC;
            };
            pub const globalentity_t = struct {
                pub const name: i64 = 0x0;
                pub const state: i64 = 0x4;
                pub const counter: i64 = 0x8;
                pub const levelName: i64 = 0x2;
            };
            pub const hudtextparms_t = struct {
                pub const x: i64 = 0xC;
                pub const y: i64 = 0x10;
                pub const color1: i64 = 0x0;
                pub const color2: i64 = 0x4;
                pub const effect: i64 = 0x8;
                pub const channel: i64 = 0x9;
            };
            pub const CAmbientGeneric = struct {
                pub const m_dpv: i64 = 0x4B4;
                pub const m_radius: i64 = 0x4A8;
                pub const m_fActive: i64 = 0x518;
                pub const m_fLooping: i64 = 0x519;
                pub const m_iszSound: i64 = 0x520;
                pub const m_flMaxRadius: i64 = 0x4AC;
                pub const m_iSoundLevel: i64 = 0x4B0;
                pub const m_hSoundSource: i64 = 0x530;
                pub const m_sSourceEntName: i64 = 0x528;
                pub const m_nSoundSourceEntIndex: i64 = 0x534;
            };
            pub const CBasePlayerPawn = struct {
                pub const v_angle: i64 = 0xBC8;
                pub const m_fInitHUD: i64 = 0xC88;
                pub const m_iHideHUD: i64 = 0xBE0;
                pub const m_skybox3d: i64 = 0xBE8;
                pub const m_pExpresser: i64 = 0xC90;
                pub const m_flDeathTime: i64 = 0xC7C;
                pub const m_hController: i64 = 0xC98;
                pub const m_pUseServices: i64 = 0xB38;
                pub const m_fTimeLastHurt: i64 = 0xC78;
                pub const m_pItemServices: i64 = 0xB18;
                pub const v_anglePrevious: i64 = 0xBD4;
                pub const m_fHltvReplayEnd: i64 = 0xCA8;
                pub const m_pWaterServices: i64 = 0xB30;
                pub const m_pCameraServices: i64 = 0xB48;
                pub const m_pWeaponServices: i64 = 0xB10;
                pub const m_fHltvReplayDelay: i64 = 0xCA4;
                pub const m_fNextSuicideTime: i64 = 0xC80;
                pub const m_pAutoaimServices: i64 = 0xB20;
                pub const m_iHltvReplayEntity: i64 = 0xCAC;
                pub const m_pMovementServices: i64 = 0xB50;
                pub const m_pObserverServices: i64 = 0xB28;
                pub const m_sndOpvarLatchData: i64 = 0xCB0;
                pub const m_hDefaultController: i64 = 0xC9C;
                pub const m_pFlashlightServices: i64 = 0xB40;
                pub const m_ServerViewAngleChanges: i64 = 0xB60;
            };
            pub const CBtActionMoveTo = struct {
                pub const m_RepathTimer: i64 = 0xC0;
                pub const m_bComputePath: i64 = 0x85;
                pub const m_vecDestination: i64 = 0x78;
                pub const m_bAutoLookAdjust: i64 = 0x84;
                pub const m_flArrivalEpsilon: i64 = 0xD8;
                pub const m_szThreatInputKey: i64 = 0x70;
                pub const m_szHidingSpotInputKey: i64 = 0x68;
                pub const m_CheckHighPriorityItem: i64 = 0xA8;
                pub const m_szDestinationInputKey: i64 = 0x60;
                pub const m_flDamagingAreasPenaltyCost: i64 = 0x88;
                pub const m_CheckApproximateCornersTimer: i64 = 0x90;
                pub const m_flAdditionalArrivalEpsilon2D: i64 = 0xDC;
                pub const m_flNearestAreaDistanceThreshold: i64 = 0xE4;
                pub const m_flHidingSpotCheckDistanceThreshold: i64 = 0xE0;
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
            pub const CCSObserverPawn = struct {

            };
            pub const CCSPetPlacement = struct {

            };
            pub const CCSRadarElement = struct {
                pub const m_nTeamFilter: i64 = 0x4C8;
                pub const m_nElementType: i64 = 0x4C0;
                pub const m_nElementColor: i64 = 0x4C4;
            };
            pub const CCommentaryAuto = struct {
                pub const m_OnCommentaryMidGame: i64 = 0x4C0;
                pub const m_OnCommentaryNewGame: i64 = 0x4A8;
                pub const m_OnCommentaryMultiplayerSpawn: i64 = 0x4D8;
            };
            pub const CEntityDissolve = struct {
                pub const m_nMagnitude: i64 = 0x87C;
                pub const m_flStartTime: i64 = 0x868;
                pub const m_flFadeInStart: i64 = 0x850;
                pub const m_nDissolveType: i64 = 0x86C;
                pub const m_flFadeInLength: i64 = 0x854;
                pub const m_flFadeOutStart: i64 = 0x860;
                pub const m_flFadeOutLength: i64 = 0x864;
                pub const m_vDissolverOrigin: i64 = 0x870;
                pub const m_flFadeOutModelStart: i64 = 0x858;
                pub const m_flFadeOutModelLength: i64 = 0x85C;
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
            pub const CEnvEntityMaker = struct {
                pub const m_iszTemplate: i64 = 0x4F0;
                pub const m_vecEntityMaxs: i64 = 0x4B4;
                pub const m_vecEntityMins: i64 = 0x4A8;
                pub const m_hCurrentBlocker: i64 = 0x4C4;
                pub const m_flPostSpawnSpeed: i64 = 0x4E4;
                pub const m_hCurrentInstance: i64 = 0x4C0;
                pub const m_pOutputOnSpawned: i64 = 0x4F8;
                pub const m_vecBlockerOrigin: i64 = 0x4C8;
                pub const m_bPostSpawnUseAngles: i64 = 0x4E8;
                pub const m_pOutputOnFailedSpawn: i64 = 0x510;
                pub const m_angPostSpawnDirection: i64 = 0x4D4;
                pub const m_flPostSpawnDirectionVariance: i64 = 0x4E0;
            };
            pub const CEnvMuzzleFlash = struct {
                pub const m_flScale: i64 = 0x4A8;
                pub const m_iszParentAttachment: i64 = 0x4B0;
            };
            pub const CFilterMultiple = struct {
                pub const m_hFilter: i64 = 0x538;
                pub const m_iFilterName: i64 = 0x4E8;
                pub const m_nFilterType: i64 = 0x4E0;
            };
            pub const CFuncMoveLinear = struct {
                pub const m_flSpeed: i64 = 0x948;
                pub const m_soundStop: i64 = 0x8F8;
                pub const m_soundStart: i64 = 0x8F0;
                pub const m_OnFullyOpen: i64 = 0x918;
                pub const m_currentSound: i64 = 0x900;
                pub const m_OnFullyClosed: i64 = 0x930;
                pub const m_flBlockDamage: i64 = 0x908;
                pub const m_flStartPosition: i64 = 0x90C;
                pub const m_authoredPosition: i64 = 0x8D0;
                pub const m_angMoveEntitySpace: i64 = 0x8D4;
                pub const m_bCreateNavObstacle: i64 = 0x94E;
                pub const m_bCreateMovableNavMesh: i64 = 0x94C;
                pub const m_vecMoveDirParentSpace: i64 = 0x8E0;
                pub const m_bAllowMovableNavMeshDockingOnEntireEntity: i64 = 0x94D;
            };
            pub const CFuncNavBlocker = struct {
                pub const m_bDisabled: i64 = 0x858;
                pub const m_nBlockedTeamNumber: i64 = 0x85C;
            };
            pub const CFuncTrackTrain = struct {
                pub const m_dir: i64 = 0x8B4;
                pub const m_ppath: i64 = 0x850;
                pub const m_OnNext: i64 = 0x928;
                pub const m_flBank: i64 = 0x8A0;
                pub const m_height: i64 = 0x8AC;
                pub const m_length: i64 = 0x854;
                pub const m_OnStart: i64 = 0x910;
                pub const m_angPrev: i64 = 0x864;
                pub const m_flSpeed: i64 = 0x870;
                pub const m_flVolume: i64 = 0x89C;
                pub const m_maxSpeed: i64 = 0x8B0;
                pub const m_oldSpeed: i64 = 0x8A4;
                pub const m_vPosPrev: i64 = 0x858;
                pub const m_controlMaxs: i64 = 0x880;
                pub const m_controlMins: i64 = 0x874;
                pub const m_flAccelSpeed: i64 = 0x964;
                pub const m_flDecelSpeed: i64 = 0x968;
                pub const m_iszSoundMove: i64 = 0x8B8;
                pub const m_iszSoundStop: i64 = 0x8D0;
                pub const m_lastBlockPos: i64 = 0x88C;
                pub const m_bAccelToSpeed: i64 = 0x96C;
                pub const m_eVelocityType: i64 = 0x8F8;
                pub const m_flBlockDamage: i64 = 0x8A8;
                pub const m_iszSoundStart: i64 = 0x8C8;
                pub const m_lastBlockTick: i64 = 0x898;
                pub const m_strPathTarget: i64 = 0x8D8;
                pub const m_flDesiredSpeed: i64 = 0x95C;
                pub const m_eOrientationType: i64 = 0x8F4;
                pub const m_iszSoundMovePing: i64 = 0x8C0;
                pub const m_flNextMPSoundTime: i64 = 0x970;
                pub const m_flSpeedChangeTime: i64 = 0x960;
                pub const m_bManualSpeedChanges: i64 = 0x958;
                pub const m_flMoveSoundMaxPitch: i64 = 0x8F0;
                pub const m_flMoveSoundMinPitch: i64 = 0x8EC;
                pub const m_flNextMoveSoundTime: i64 = 0x8E8;
                pub const m_flMoveSoundMaxDuration: i64 = 0x8E4;
                pub const m_flMoveSoundMinDuration: i64 = 0x8E0;
                pub const m_OnArrivedAtDestinationNode: i64 = 0x940;
            };
            pub const CFuncWallToggle = struct {

            };
            pub const CGameGibManager = struct {
                pub const m_iLastFrame: i64 = 0x4CC;
                pub const m_iMaxPieces: i64 = 0x4C8;
                pub const m_bAllowNewGibs: i64 = 0x4C0;
                pub const m_iCurrentMaxPieces: i64 = 0x4C4;
            };
            pub const CGamePlayerZone = struct {
                pub const m_OnPlayerInZone: i64 = 0x858;
                pub const m_PlayersInCount: i64 = 0x888;
                pub const m_OnPlayerOutZone: i64 = 0x870;
                pub const m_PlayersOutCount: i64 = 0x8A8;
            };
            pub const CGameRulesProxy = struct {

            };
            pub const CInfoWorldLayer = struct {
                pub const m_layerName: i64 = 0x4C8;
                pub const m_worldName: i64 = 0x4C0;
                pub const m_bEntitiesSpawned: i64 = 0x4D1;
                pub const m_hLayerSpawnGroup: i64 = 0x4D4;
                pub const m_bWorldLayerVisible: i64 = 0x4D0;
                pub const m_bCreateAsChildSpawnGroup: i64 = 0x4D2;
                pub const m_pOutputOnEntitiesSpawned: i64 = 0x4A8;
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
                pub const m_bPvsModifyEntity: i64 = 0x1B8;
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
            };
            pub const CLogicGameEvent = struct {
                pub const m_iszEventName: i64 = 0x4A8;
            };
            pub const CLogicProximity = struct {

            };
            pub const CMathColorBlend = struct {
                pub const m_flInMax: i64 = 0x4AC;
                pub const m_flInMin: i64 = 0x4A8;
                pub const m_OutValue: i64 = 0x4B8;
                pub const m_OutColor1: i64 = 0x4B0;
                pub const m_OutColor2: i64 = 0x4B4;
            };
            pub const CMolotovGrenade = struct {

            };
            pub const CMultiplayRules = struct {

            };
            pub const CParticleSystem = struct {
                pub const m_bActive: i64 = 0xA50;
                pub const m_bFrozen: i64 = 0xA51;
                pub const m_bNoRamp: i64 = 0xBB2;
                pub const m_bNoSave: i64 = 0xBB0;
                pub const m_clrTint: i64 = 0xDD4;
                pub const m_nDataCP: i64 = 0xDC0;
                pub const m_nTintCP: i64 = 0xDD0;
                pub const m_bNoFreeze: i64 = 0xBB1;
                pub const m_nStopType: i64 = 0xA58;
                pub const m_flStartTime: i64 = 0xA68;
                pub const m_bStartActive: i64 = 0xBB3;
                pub const m_flPreSimTime: i64 = 0xA6C;
                pub const m_iEffectIndex: i64 = 0xA60;
                pub const m_iszEffectName: i64 = 0xBB8;
                pub const m_strDataString: i64 = 0xBA8;
                pub const m_vecDataCPValue: i64 = 0xDC4;
                pub const m_hControlPointEnts: i64 = 0xAA4;
                pub const m_szSnapshotFileName: i64 = 0x850;
                pub const m_bDataStringLocalized: i64 = 0xBA4;
                pub const m_iszControlPointNames: i64 = 0xBC0;
                pub const m_vServerControlPoints: i64 = 0xA70;
                pub const m_flFreezeTransitionDuration: i64 = 0xA54;
                pub const m_bAnimateDuringGameplayPause: i64 = 0xA5C;
                pub const m_iServerControlPointAssignments: i64 = 0xAA0;
            };
            pub const CPhysBallSocket = struct {
                pub const m_flSwingLimit: i64 = 0x510;
                pub const m_flJointFriction: i64 = 0x508;
                pub const m_flMaxTwistAngle: i64 = 0x51C;
                pub const m_flMinTwistAngle: i64 = 0x518;
                pub const m_bEnableSwingLimit: i64 = 0x50C;
                pub const m_bEnableTwistLimit: i64 = 0x514;
            };
            pub const CPhysConstraint = struct {
                pub const m_hJoint: i64 = 0x4A8;
                pub const m_OnBreak: i64 = 0x4F0;
                pub const m_hAttach1: i64 = 0x4C0;
                pub const m_hAttach2: i64 = 0x4C4;
                pub const m_breakSound: i64 = 0x4D8;
                pub const m_forceLimit: i64 = 0x4E0;
                pub const m_nameAttach1: i64 = 0x4B0;
                pub const m_nameAttach2: i64 = 0x4B8;
                pub const m_torqueLimit: i64 = 0x4E4;
                pub const m_nameAttachment1: i64 = 0x4C8;
                pub const m_nameAttachment2: i64 = 0x4D0;
                pub const m_minTeleportDistance: i64 = 0x4E8;
                pub const m_bSnapObjectPositions: i64 = 0x4EC;
                pub const m_bTreatEntity1AsInfiniteMass: i64 = 0x4ED;
            };
            pub const CPhysicalButton = struct {

            };
            pub const CPointWorldText = struct {
                pub const m_Color: i64 = 0xAF0;
                pub const m_FontName: i64 = 0xA50;
                pub const m_bEnabled: i64 = 0xAD0;
                pub const m_flFontSize: i64 = 0xAD8;
                pub const m_bFullbright: i64 = 0xAD1;
                pub const m_messageText: i64 = 0x850;
                pub const m_flDepthOffset: i64 = 0xADC;
                pub const m_nReorientMode: i64 = 0xAFC;
                pub const m_bDrawBackground: i64 = 0xAE0;
                pub const m_nJustifyVertical: i64 = 0xAF8;
                pub const m_flWorldUnitsPerPx: i64 = 0xAD4;
                pub const m_nJustifyHorizontal: i64 = 0xAF4;
                pub const m_flBackgroundWorldToUV: i64 = 0xAEC;
                pub const m_BackgroundMaterialName: i64 = 0xA90;
                pub const m_flBackgroundBorderWidth: i64 = 0xAE4;
                pub const m_flBackgroundBorderHeight: i64 = 0xAE8;
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
                pub const m_bCanTakeDamage: i64 = 0x4B1;
                pub const m_bSaveImportant: i64 = 0x4B0;
                pub const m_iMaxRagdollCount: i64 = 0x4AC;
                pub const m_iCurrentMaxRagdollCount: i64 = 0x4A8;
            };
            pub const CRopeOverlapHit = struct {
                pub const m_hEntity: i64 = 0x0;
                pub const m_vecOverlappingLinks: i64 = 0x8;
            };
            pub const CSceneEventInfo = struct {
                pub const m_nType: i64 = 0x3C;
                pub const m_flNext: i64 = 0x40;
                pub const m_iLayer: i64 = 0x0;
                pub const m_hTarget: i64 = 0x6C;
                pub const m_bStarted: i64 = 0x75;
                pub const m_flWeight: i64 = 0xC;
                pub const m_hAnimClip: i64 = 0x20;
                pub const m_hSequence: i64 = 0x8;
                pub const m_iPriority: i64 = 0x4;
                pub const m_bIsGesture: i64 = 0x44;
                pub const m_bClientSide: i64 = 0x74;
                pub const m_bHasArrived: i64 = 0x38;
                pub const m_flLastCycle: i64 = 0x1C;
                pub const m_bShouldRemove: i64 = 0x45;
                pub const m_nSceneEventId: i64 = 0x70;
                pub const m_sAnimClipSlot: i64 = 0x28;
                pub const m_flLastJumpToTime: i64 = 0x18;
                pub const m_flLastJumpFromTime: i64 = 0x14;
                pub const m_sAnimClipSlotWeight: i64 = 0x30;
                pub const m_flLastAccumulatedTime: i64 = 0x10;
            };
            pub const CSimpleSimTimer = struct {
                pub const m_flNext: i64 = 0x0;
                pub const m_nWorldGroupId: i64 = 0x4;
            };
            pub const CSoundStackSave = struct {
                pub const m_iszStackName: i64 = 0x4A8;
            };
            pub const CSpriteOriented = struct {

            };
            pub const CTakeDamageInfo = struct {
                pub const m_flDamage: i64 = 0x44;
                pub const m_hAbility: i64 = 0x40;
                pub const m_hAttacker: i64 = 0x3C;
                pub const m_iAmmoType: i64 = 0x54;
                pub const m_hInflictor: i64 = 0x38;
                pub const m_iHitGroupId: i64 = 0x78;
                pub const m_bShouldBleed: i64 = 0x64;
                pub const m_bShouldSpark: i64 = 0x65;
                pub const m_nDamageFlags: i64 = 0x70;
                pub const m_iDamageCustom: i64 = 0x50;
                pub const m_bStoppedBullet: i64 = 0x84;
                pub const m_bitsDamageType: i64 = 0x4C;
                pub const m_vecDamageForce: i64 = 0x8;
                pub const m_flOriginalDamage: i64 = 0x60;
                pub const m_flTotalledDamage: i64 = 0x48;
                pub const m_bInTakeDamageFlow: i64 = 0x110;
                pub const m_vecDamagePosition: i64 = 0x14;
                pub const m_vecDamageDirection: i64 = 0x2C;
                pub const m_vecReportedPosition: i64 = 0x20;
                pub const m_nNumObjectsPenetrated: i64 = 0x7C;
                pub const m_DestructibleHitGroupRequests: i64 = 0x100;
                pub const m_flFriendlyFireDamageReductionRatio: i64 = 0x80;
            };
            pub const CTonemapTrigger = struct {
                pub const m_hTonemapController: i64 = 0x9D0;
                pub const m_tonemapControllerName: i64 = 0x9C8;
            };
            pub const CTriggerGravity = struct {

            };
            pub const CTriggerPhysics = struct {
                pub const m_flFrequency: i64 = 0x9F0;
                pub const m_linearForce: i64 = 0x9EC;
                pub const m_linearLimit: i64 = 0x9DC;
                pub const m_pController: i64 = 0x9D0;
                pub const m_angularLimit: i64 = 0x9E4;
                pub const m_gravityScale: i64 = 0x9D8;
                pub const m_linearDamping: i64 = 0x9E0;
                pub const m_angularDamping: i64 = 0x9E8;
                pub const m_flDampingRatio: i64 = 0x9F4;
                pub const m_bCollapseToForcePoint: i64 = 0xA04;
                pub const m_vecLinearForcePointAt: i64 = 0x9F8;
                pub const m_vecLinearForceDirection: i64 = 0xA14;
                pub const m_vecLinearForcePointAtWorld: i64 = 0xA08;
                pub const m_bConvertToDebrisWhenPossible: i64 = 0xA21;
                pub const m_bForceDirectionIsInLocalSpace: i64 = 0xA20;
            };
            pub const CVoteController = struct {
                pub const m_nVotesCast: i64 = 0x518;
                pub const m_VoteOptions: i64 = 0x640;
                pub const m_bIsYesNoVote: i64 = 0x4C8;
                pub const m_resetVoteTimer: i64 = 0x500;
                pub const m_iOnlyTeamToVote: i64 = 0x4AC;
                pub const m_nPotentialVotes: i64 = 0x4C4;
                pub const m_potentialIssues: i64 = 0x628;
                pub const m_nVoteOptionCount: i64 = 0x4B0;
                pub const m_iActiveIssueIndex: i64 = 0x4A8;
                pub const m_playerHoldingVote: i64 = 0x618;
                pub const m_nHighestCountIndex: i64 = 0x620;
                pub const m_acceptingVotesTimer: i64 = 0x4D0;
                pub const m_executeCommandTimer: i64 = 0x4E8;
                pub const m_playerOverrideForVote: i64 = 0x61C;
            };
            pub const CWeaponBaseItem = struct {
                pub const m_bRedraw: i64 = 0x1281;
                pub const m_bSequenceInProgress: i64 = 0x1280;
            };
            pub const CWeaponRevolver = struct {

            };
            pub const CWeaponSawedoff = struct {

            };
            pub const ChickenPathCost = struct {

            };
            pub const HostagePathCost = struct {

            };
            pub const IChoreoServices = struct {

            };
            pub const ParticleIndex_t = struct {
                pub const m_Value: i64 = 0x0;
            };
            pub const VelocitySampler = struct {
                pub const m_prevSample: i64 = 0x0;
                pub const m_fPrevSampleTime: i64 = 0xC;
                pub const m_fIdealSampleRate: i64 = 0x10;
            };
            pub const ActorClipEntry_t = struct {
                pub const m_bLooping: i64 = 0x8;
                pub const m_sClipName: i64 = 0x0;
            };
            pub const ApproachAreaCost = struct {

            };
            pub const CBaseModelEntity = struct {
                pub const m_Glow: i64 = 0x6A0;
                pub const m_OnIgnite: i64 = 0x538;
                pub const m_Collision: i64 = 0x5E8;
                pub const m_clrRender: i64 = 0x570;
                pub const m_nRenderFX: i64 = 0x551;
                pub const m_fadeMaxDist: i64 = 0x700;
                pub const m_fadeMinDist: i64 = 0x6FC;
                pub const m_flFadeScale: i64 = 0x704;
                pub const m_nRenderMode: i64 = 0x550;
                pub const m_vecViewOffset: i64 = 0x818;
                pub const m_bNoInterpolate: i64 = 0x5E2;
                pub const m_nObjectCulling: i64 = 0x70C;
                pub const m_CHitboxComponent: i64 = 0x4B0;
                pub const m_CRenderComponent: i64 = 0x4A8;
                pub const m_bAllowFadeInView: i64 = 0x552;
                pub const m_bodyGroupChoices: i64 = 0x7F0;
                pub const m_flShadowStrength: i64 = 0x708;
                pub const m_pChoreoComponent: i64 = 0x4C8;
                pub const m_bRenderToCubemaps: i64 = 0x5E0;
                pub const m_bodyGroupRequests: i64 = 0x718;
                pub const m_flGlowBackfaceMult: i64 = 0x6F8;
                pub const m_bvDisabledHitGroups: i64 = 0x848;
                pub const m_flDissolveStartTime: i64 = 0x530;
                pub const m_vecRenderAttributes: i64 = 0x578;
                pub const m_bodyGroupTotalRequestCount: i64 = 0x710;
                pub const m_bExpandRenderBoundsToIncludeCloth: i64 = 0x5E1;
                pub const m_pDestructiblePartsSystemComponent: i64 = 0x500;
                pub const m_OnDestructibleHitGroupDamageLevelChanged: i64 = 0x508;
                pub const m_nDestructiblePartInitialStateDestructed0: i64 = 0x4D0;
                pub const m_nDestructiblePartInitialStateDestructed1: i64 = 0x4D4;
                pub const m_nDestructiblePartInitialStateDestructed2: i64 = 0x4D8;
                pub const m_nDestructiblePartInitialStateDestructed3: i64 = 0x4DC;
                pub const m_nDestructiblePartInitialStateDestructed4: i64 = 0x4E0;
                pub const m_nDestructiblePartInitialStateDestructed0_PartIndex: i64 = 0x4E4;
                pub const m_nDestructiblePartInitialStateDestructed1_PartIndex: i64 = 0x4E8;
                pub const m_nDestructiblePartInitialStateDestructed2_PartIndex: i64 = 0x4EC;
                pub const m_nDestructiblePartInitialStateDestructed3_PartIndex: i64 = 0x4F0;
                pub const m_nDestructiblePartInitialStateDestructed4_PartIndex: i64 = 0x4F4;
                pub const m_bDestructiblePartInitialStateDestructed0_GenerateBreakpieces: i64 = 0x4F8;
                pub const m_bDestructiblePartInitialStateDestructed1_GenerateBreakpieces: i64 = 0x4F9;
                pub const m_bDestructiblePartInitialStateDestructed2_GenerateBreakpieces: i64 = 0x4FA;
                pub const m_bDestructiblePartInitialStateDestructed3_GenerateBreakpieces: i64 = 0x4FB;
                pub const m_bDestructiblePartInitialStateDestructed4_GenerateBreakpieces: i64 = 0x4FC;
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
            pub const CBtNodeComposite = struct {

            };
            pub const CBtNodeCondition = struct {
                pub const m_bNegated: i64 = 0x58;
            };
            pub const CBtNodeDecorator = struct {

            };
            pub const CCSGameModeRules = struct {
                pub const __m_pChainEntity: i64 = 0x8;
            };
            pub const CCSMinimapVolume = struct {
                pub const m_strMinimapName: i64 = 0x9C8;
            };
            pub const CCSWeaponBaseGun = struct {
                pub const m_zoomLevel: i64 = 0x1280;
                pub const m_inPrecache: i64 = 0x1294;
                pub const m_bNeedsBoltAction: i64 = 0x1295;
                pub const m_silencedModelIndex: i64 = 0x1290;
                pub const m_iBurstShotsRemaining: i64 = 0x1284;
                pub const m_nRevolverCylinderIdx: i64 = 0x1298;
                pub const m_bSkillReloadAvailable: i64 = 0x129C;
                pub const m_bSkillBoltLiftedFireKey: i64 = 0x129F;
                pub const m_bSkillReloadLiftedReloadKey: i64 = 0x129D;
                pub const m_bSkillBoltInterruptAvailable: i64 = 0x129E;
            };
            pub const CChoreoComponent = struct {
                pub const m_hOwner: i64 = 0x30;
                pub const __m_pChainEntity: i64 = 0x8;
                pub const m_nNextSceneEventId: i64 = 0x70;
                pub const m_flAllowResponsesEndTime: i64 = 0x74;
                pub const m_nExernalChoreoGraphCount: i64 = 0x34;
                pub const m_sActiveExternalChoreoGraphSlotID: i64 = 0x38;
            };
            pub const CColorCorrection = struct {
                pub const m_bMaster: i64 = 0x4C6;
                pub const m_bEnabled: i64 = 0x4C5;
                pub const m_MaxFalloff: i64 = 0x4D0;
                pub const m_MinFalloff: i64 = 0x4CC;
                pub const m_bExclusive: i64 = 0x4C8;
                pub const m_bClientSide: i64 = 0x4C7;
                pub const m_flCurWeight: i64 = 0x4D4;
                pub const m_flMaxWeight: i64 = 0x4C0;
                pub const m_bStartDisabled: i64 = 0x4C4;
                pub const m_lookupFilename: i64 = 0x6D8;
                pub const m_flFadeInDuration: i64 = 0x4A8;
                pub const m_flFadeOutDuration: i64 = 0x4AC;
                pub const m_flTimeStartFadeIn: i64 = 0x4B8;
                pub const m_netlookupFilename: i64 = 0x4D8;
                pub const m_flTimeStartFadeOut: i64 = 0x4BC;
                pub const m_flStartFadeInWeight: i64 = 0x4B0;
                pub const m_flStartFadeOutWeight: i64 = 0x4B4;
            };
            pub const CDecalGroupVData = struct {
                pub const m_vecOptions: i64 = 0x0;
                pub const m_flTotalProbability: i64 = 0x18;
            };
            pub const CDecoyProjectile = struct {
                pub const m_fExpireTime: i64 = 0xB60;
                pub const m_nDecoyShotTick: i64 = 0xB58;
                pub const m_shotsRemaining: i64 = 0xB5C;
                pub const m_decoyWeaponDefIndex: i64 = 0xB70;
            };
            pub const CEntityComponent = struct {

            };
            pub const CEnvParticleGlow = struct {
                pub const m_ColorTint: i64 = 0xDE4;
                pub const m_flAlphaScale: i64 = 0xDD8;
                pub const m_flRadiusScale: i64 = 0xDDC;
                pub const m_flSelfIllumScale: i64 = 0xDE0;
                pub const m_hTextureOverride: i64 = 0xDE8;
            };
            pub const CFilterProximity = struct {
                pub const m_flRadius: i64 = 0x4E0;
            };
            pub const CFiringModeFloat = struct {
                pub const m_flValues: i64 = 0x0;
            };
            pub const CFootstepControl = struct {
                pub const m_source: i64 = 0x9C8;
                pub const m_destination: i64 = 0x9D0;
            };
            pub const CFuncIllusionary = struct {

            };
            pub const CFuncMoverRouter = struct {
                pub const m_hPathMover: i64 = 0x4B0;
                pub const m_nMoverIndex: i64 = 0x4A8;
                pub const m_iszPathMoverName: i64 = 0x4B8;
                pub const m_bRouteToAllMovers: i64 = 0x4AC;
            };
            pub const CFuncTrackChange = struct {
                pub const m_use: i64 = 0x950;
                pub const m_code: i64 = 0x948;
                pub const m_train: i64 = 0x928;
                pub const m_trackTop: i64 = 0x920;
                pub const m_trainName: i64 = 0x940;
                pub const m_targetState: i64 = 0x94C;
                pub const m_trackBottom: i64 = 0x924;
                pub const m_trackTopName: i64 = 0x930;
                pub const m_trackBottomName: i64 = 0x938;
            };
            pub const CFuncVehicleClip = struct {

            };
            pub const CGamePlayerEquip = struct {

            };
            pub const CHitboxComponent = struct {
                pub const m_flBoundsExpandRadius: i64 = 0x14;
            };
            pub const CInfoPlayerStart = struct {
                pub const m_bDisabled: i64 = 0x4A8;
                pub const m_bIsMaster: i64 = 0x4A9;
                pub const m_pPawnSubclass: i64 = 0x4B0;
            };
            pub const CItemAssaultSuit = struct {

            };
            pub const CItem_Healthshot = struct {

            };
            pub const CLightSpotEntity = struct {

            };
            pub const CLogicBranchList = struct {
                pub const m_OnMixed: i64 = 0x578;
                pub const m_OnAllTrue: i64 = 0x548;
                pub const m_OnAllFalse: i64 = 0x560;
                pub const m_eLastState: i64 = 0x540;
                pub const m_LogicBranchList: i64 = 0x528;
                pub const m_nLogicBranchNames: i64 = 0x4A8;
            };
            pub const CLogicNPCCounter = struct {
                pub const m_hSource: i64 = 0x668;
                pub const m_bDisabled: i64 = 0x67C;
                pub const m_OnFactor_1: i64 = 0x548;
                pub const m_OnFactor_2: i64 = 0x5B8;
                pub const m_OnFactor_3: i64 = 0x628;
                pub const m_OnFactorAll: i64 = 0x4D8;
                pub const m_nMaxCount_1: i64 = 0x6AC;
                pub const m_nMaxCount_2: i64 = 0x6D4;
                pub const m_nMaxCount_3: i64 = 0x6FC;
                pub const m_nMinCount_1: i64 = 0x6A8;
                pub const m_nMinCount_2: i64 = 0x6D0;
                pub const m_nMinCount_3: i64 = 0x6F8;
                pub const m_nNPCState_1: i64 = 0x6A0;
                pub const m_nNPCState_2: i64 = 0x6C8;
                pub const m_nNPCState_3: i64 = 0x6F0;
                pub const m_OnMaxCount_1: i64 = 0x530;
                pub const m_OnMaxCount_2: i64 = 0x5A0;
                pub const m_OnMaxCount_3: i64 = 0x610;
                pub const m_OnMinCount_1: i64 = 0x518;
                pub const m_OnMinCount_2: i64 = 0x588;
                pub const m_OnMinCount_3: i64 = 0x5F8;
                pub const m_nMaxCountAll: i64 = 0x684;
                pub const m_nMaxFactor_1: i64 = 0x6B4;
                pub const m_nMaxFactor_2: i64 = 0x6DC;
                pub const m_nMaxFactor_3: i64 = 0x704;
                pub const m_nMinCountAll: i64 = 0x680;
                pub const m_nMinFactor_1: i64 = 0x6B0;
                pub const m_nMinFactor_2: i64 = 0x6D8;
                pub const m_nMinFactor_3: i64 = 0x700;
                pub const m_OnMaxCountAll: i64 = 0x4C0;
                pub const m_OnMinCountAll: i64 = 0x4A8;
                pub const m_flDistanceMax: i64 = 0x678;
                pub const m_nMaxFactorAll: i64 = 0x68C;
                pub const m_nMinFactorAll: i64 = 0x688;
                pub const m_bInvertState_1: i64 = 0x6A4;
                pub const m_bInvertState_2: i64 = 0x6CC;
                pub const m_bInvertState_3: i64 = 0x6F4;
                pub const m_flDefaultDist_1: i64 = 0x6BC;
                pub const m_flDefaultDist_2: i64 = 0x6E4;
                pub const m_flDefaultDist_3: i64 = 0x70C;
                pub const m_OnMinPlayerDist_1: i64 = 0x568;
                pub const m_OnMinPlayerDist_2: i64 = 0x5D8;
                pub const m_OnMinPlayerDist_3: i64 = 0x648;
                pub const m_iszNPCClassname_1: i64 = 0x698;
                pub const m_iszNPCClassname_2: i64 = 0x6C0;
                pub const m_iszNPCClassname_3: i64 = 0x6E8;
                pub const m_OnMinPlayerDistAll: i64 = 0x4F8;
                pub const m_iszSourceEntityName: i64 = 0x670;
            };
            pub const CLogicNavigation = struct {
                pub const m_isOn: i64 = 0x4B0;
                pub const m_navProperty: i64 = 0x4B4;
            };
            pub const CMotorController = struct {
                pub const m_axis: i64 = 0x10;
                pub const m_speed: i64 = 0x8;
                pub const m_maxTorque: i64 = 0xC;
                pub const m_inertiaFactor: i64 = 0x1C;
            };
            pub const CMultiLightProxy = struct {
                pub const m_vecLights: i64 = 0x4D0;
                pub const m_flBrightnessDelta: i64 = 0x4BC;
                pub const m_bPerformScreenFade: i64 = 0x4C0;
                pub const m_iszLightNameFilter: i64 = 0x4A8;
                pub const m_flLightRadiusFilter: i64 = 0x4B8;
                pub const m_iszLightClassFilter: i64 = 0x4B0;
                pub const m_flTargetBrightnessMultiplier: i64 = 0x4C4;
                pub const m_flCurrentBrightnessMultiplier: i64 = 0x4C8;
            };
            pub const CNavVolumeSphere = struct {
                pub const m_vCenter: i64 = 0x78;
                pub const m_flRadius: i64 = 0x84;
            };
            pub const CNavVolumeVector = struct {
                pub const m_bHasBeenPreFiltered: i64 = 0x80;
            };
            pub const CNmEventConsumer = struct {

            };
            pub const CNoiseStreamData = struct {
                pub const m_Stream: i64 = 0x0;
            };
            pub const CPathCornerCrash = struct {

            };
            pub const CPointCameraVFOV = struct {
                pub const m_flVerticalFOV: i64 = 0x508;
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
            pub const CRetakeGameRules = struct {
                pub const m_iBombSite: i64 = 0x144;
                pub const m_nMatchSeed: i64 = 0x138;
                pub const m_hBombPlanter: i64 = 0x148;
                pub const m_bBlockersPresent: i64 = 0x13C;
                pub const m_bRoundInProgress: i64 = 0x13D;
                pub const m_iFirstSecondHalfRound: i64 = 0x140;
            };
            pub const CRuleBrushEntity = struct {

            };
            pub const CRulePointEntity = struct {
                pub const m_Score: i64 = 0x858;
            };
            pub const CScriptComponent = struct {
                pub const m_scriptClassName: i64 = 0x30;
            };
            pub const CSimpleStopwatch = struct {

            };
            pub const CSingleplayRules = struct {
                pub const m_bSinglePlayerGameEnding: i64 = 0xD0;
            };
            pub const CSkyCameraVolume = struct {
                pub const m_hTarget: i64 = 0x4D8;
                pub const m_vBoxMaxs: i64 = 0x4CC;
                pub const m_vBoxMins: i64 = 0x4C0;
                pub const m_nPriority: i64 = 0x4DC;
                pub const m_bIsEnabled: i64 = 0x4E0;
                pub const m_vBlurOrigin: i64 = 0x4E4;
                pub const m_iszTargetName: i64 = 0x4F8;
                pub const m_bStartDisabled: i64 = 0x4F2;
                pub const m_bSkyboxBlurEffect: i64 = 0x4E1;
                pub const m_bSkyboxReceivesWorldCsm: i64 = 0x4F0;
                pub const m_bWorldReceivesSkyboxCsm: i64 = 0x4F1;
            };
            pub const CSkyboxReference = struct {
                pub const m_hSkyCamera: i64 = 0x4AC;
                pub const m_worldGroupId: i64 = 0x4A8;
            };
            pub const CTriggerBuoyancy = struct {
                pub const m_BuoyancyHelper: i64 = 0x9C8;
                pub const m_flFluidDensity: i64 = 0xAE0;
            };
            pub const CTriggerCallback = struct {

            };
            pub const CTriggerMultiple = struct {
                pub const m_OnTrigger: i64 = 0x9C8;
            };
            pub const CTriggerTeleport = struct {
                pub const m_iLandmark: i64 = 0x9C8;
                pub const m_bMirrorPlayer: i64 = 0x9D1;
                pub const m_bUseLandmarkAngles: i64 = 0x9D0;
                pub const m_bCheckDestIfClearForPlayer: i64 = 0x9D2;
            };
            pub const CWeaponFiveSeven = struct {

            };
            pub const FilterDamageType = struct {
                pub const m_iDamageType: i64 = 0x4E0;
            };
            pub const ResponseFollowup = struct {
                pub const followup_delay: i64 = 0x10;
                pub const followup_target: i64 = 0x14;
                pub const followup_concept: i64 = 0x0;
                pub const followup_contexts: i64 = 0x8;
            };
            pub const WaterWheelDrag_t = struct {
                pub const m_flWheelDrag: i64 = 0x4;
                pub const m_flFractionOfWheelSubmerged: i64 = 0x0;
            };
            pub const ragdollelement_t = struct {
                pub const m_nHeight: i64 = 0x28;
                pub const m_flRadius: i64 = 0x24;
                pub const parentIndex: i64 = 0x20;
                pub const originParentSpace: i64 = 0x0;
            };
            pub const CAttributeManager = struct {
                pub const m_hOuter: i64 = 0x24;
                pub const m_Providers: i64 = 0x8;
                pub const m_ProviderType: i64 = 0x2C;
                pub const m_CachedResults: i64 = 0x30;
                pub const m_bPreventLoopback: i64 = 0x28;
                pub const m_iReapplyProvisionParity: i64 = 0x20;
            };
            pub const CBasePlayerWeapon = struct {
                pub const m_iClip1: i64 = 0xEC0;
                pub const m_iClip2: i64 = 0xEC4;
                pub const m_OnPlayerUse: i64 = 0xED0;
                pub const m_pReserveAmmo: i64 = 0xEC8;
                pub const m_nNextPrimaryAttackTick: i64 = 0xEB0;
                pub const m_nNextSecondaryAttackTick: i64 = 0xEB8;
                pub const m_flNextPrimaryAttackTickRatio: i64 = 0xEB4;
                pub const m_flNextSecondaryAttackTickRatio: i64 = 0xEBC;
            };
            pub const CCSGameRulesProxy = struct {
                pub const m_pGameRules: i64 = 0x4A8;
            };
            pub const CCSPlayerPawnBase = struct {
                pub const m_iNumSpawns: i64 = 0xDF4;
                pub const m_bRespawning: i64 = 0xDF0;
                pub const m_iPlayerState: i64 = 0xD40;
                pub const m_pPingServices: i64 = 0xD30;
                pub const m_blindStartTime: i64 = 0xD3C;
                pub const m_blindUntilTime: i64 = 0xD38;
                pub const m_flFlashDuration: i64 = 0xE04;
                pub const m_flFlashMaxAlpha: i64 = 0xE08;
                pub const m_bHasMovedSinceSpawn: i64 = 0xDF1;
                pub const m_hOriginalController: i64 = 0xE14;
                pub const m_fNextRadarUpdateTime: i64 = 0xE00;
                pub const m_iProgressBarDuration: i64 = 0xE10;
                pub const m_flProgressBarStartTime: i64 = 0xE0C;
                pub const m_CTouchExpansionComponent: i64 = 0xCE0;
                pub const m_flIdleTimeSinceLastAction: i64 = 0xDFC;
            };
            pub const CCSPlayerResource = struct {
                pub const m_bHostageAlive: i64 = 0x4A8;
                pub const m_hostageRescueX: i64 = 0x508;
                pub const m_hostageRescueY: i64 = 0x518;
                pub const m_hostageRescueZ: i64 = 0x528;
                pub const m_bombsiteCenterA: i64 = 0x4F0;
                pub const m_bombsiteCenterB: i64 = 0x4FC;
                pub const m_iHostageEntityIDs: i64 = 0x4C0;
                pub const m_foundGoalPositions: i64 = 0x539;
                pub const m_bEndMatchNextMapAllVoted: i64 = 0x538;
                pub const m_isHostageFollowingSomeone: i64 = 0x4B4;
            };
            pub const CChoreoInfoTarget = struct {

            };
            pub const CCommentarySystem = struct {
                pub const m_vecNodes: i64 = 0x48;
                pub const m_bCheatState: i64 = 0x1C;
                pub const m_hCurrentNode: i64 = 0x38;
                pub const m_iTeleportStage: i64 = 0x18;
                pub const m_ModifiedConvars: i64 = 0x20;
                pub const m_flNextTeleportTime: i64 = 0x14;
                pub const m_hLastCommentaryNode: i64 = 0x40;
                pub const m_hActiveCommentaryNode: i64 = 0x3C;
                pub const m_bIsFirstSpawnGroupToLoad: i64 = 0x1D;
                pub const m_bCommentaryEnabledMidGame: i64 = 0x12;
            };
            pub const CConstraintAnchor = struct {
                pub const m_massScale: i64 = 0xA40;
            };
            pub const CDestructiblePart = struct {
                pub const m_DebugName: i64 = 0x0;
                pub const m_nHitGroup: i64 = 0x8;
                pub const m_DamageLevels: i64 = 0x38;
                pub const m_sBodyGroupName: i64 = 0x30;
                pub const m_bOnlyDestroyWhenGibbing: i64 = 0x28;
                pub const m_bDisableHitGroupWhenDestroyed: i64 = 0xC;
                pub const m_nOtherHitgroupsToDestroyWhenFullyDestructed: i64 = 0x10;
            };
            pub const CEnvEntityIgniter = struct {
                pub const m_flLifetime: i64 = 0x4A8;
            };
            pub const CFireCrackerBlast = struct {

            };
            pub const CFuncShatterglass = struct {
                pub const m_bBroken: i64 = 0x8E6;
                pub const m_OnBroken: i64 = 0x958;
                pub const m_PanelSize: i64 = 0x8C8;
                pub const m_bBreakSilent: i64 = 0x8E4;
                pub const m_bStartBroken: i64 = 0x8E9;
                pub const m_flInitAtTime: i64 = 0x8D8;
                pub const m_iSurfaceType: i64 = 0x970;
                pub const m_bGlassInFrame: i64 = 0x8E8;
                pub const m_bBreakShardless: i64 = 0x8E5;
                pub const m_bGlassNavIgnore: i64 = 0x8E7;
                pub const m_flGlassThickness: i64 = 0x8DC;
                pub const m_flLastCleanupTime: i64 = 0x8D4;
                pub const m_matPanelTransform: i64 = 0x850;
                pub const m_iInitialDamageType: i64 = 0x8EA;
                pub const m_hMaterialDamageBase: i64 = 0x978;
                pub const m_vExtraDamagePositions: i64 = 0x928;
                pub const m_vInitialPanelVertices: i64 = 0x940;
                pub const m_vecShatterGlassShards: i64 = 0x8B0;
                pub const m_flSpawnInvulnerability: i64 = 0x8E0;
                pub const m_matPanelTransformWsTemp: i64 = 0x880;
                pub const m_vInitialDamagePositions: i64 = 0x910;
                pub const m_flLastShatterSoundEmitTime: i64 = 0x8D0;
                pub const m_szDamagePositioningEntityName01: i64 = 0x8F0;
                pub const m_szDamagePositioningEntityName02: i64 = 0x8F8;
                pub const m_szDamagePositioningEntityName03: i64 = 0x900;
                pub const m_szDamagePositioningEntityName04: i64 = 0x908;
            };
            pub const CFuncVPhysicsClip = struct {
                pub const m_bDisabled: i64 = 0x850;
            };
            pub const CHintMessageQueue = struct {
                pub const m_messages: i64 = 0x8;
                pub const m_tmMessageEnd: i64 = 0x0;
                pub const m_pPlayerController: i64 = 0x20;
            };
            pub const CInfoChoreoAnchor = struct {
                pub const m_vecTargetWarps: i64 = 0x4C0;
                pub const m_vecTargetEntries: i64 = 0x4A8;
            };
            pub const CLightOrthoEntity = struct {

            };
            pub const CLogicAchievement = struct {
                pub const m_OnFired: i64 = 0x4B8;
                pub const m_bDisabled: i64 = 0x4A8;
                pub const m_iszAchievementEventID: i64 = 0x4B0;
            };
            pub const CModelPointEntity = struct {

            };
            pub const CNmSnapWeaponTask = struct {

            };
            pub const CPathParticleRope = struct {
                pub const m_flSlack: i64 = 0x4DC;
                pub const m_flRadius: i64 = 0x4E0;
                pub const m_ColorTint: i64 = 0x4E4;
                pub const m_bStartActive: i64 = 0x4B0;
                pub const m_iEffectIndex: i64 = 0x4F0;
                pub const m_nEffectState: i64 = 0x4E8;
                pub const m_iszEffectName: i64 = 0x4B8;
                pub const m_PathNodes_Name: i64 = 0x4C0;
                pub const m_PathNodes_Color: i64 = 0x540;
                pub const m_flParticleSpacing: i64 = 0x4D8;
                pub const m_PathNodes_Position: i64 = 0x4F8;
                pub const m_PathNodes_TangentIn: i64 = 0x510;
                pub const m_flMaxSimulationTime: i64 = 0x4B4;
                pub const m_PathNodes_PinEnabled: i64 = 0x558;
                pub const m_PathNodes_TangentOut: i64 = 0x528;
                pub const m_PathNodes_RadiusScale: i64 = 0x570;
            };
            pub const CPlayerSprayDecal = struct {
                pub const m_nEntity: i64 = 0x894;
                pub const m_nHitbox: i64 = 0x898;
                pub const m_nPlayer: i64 = 0x890;
                pub const m_nTintID: i64 = 0x8A0;
                pub const m_vecLeft: i64 = 0x878;
                pub const m_nVersion: i64 = 0x8A4;
                pub const m_rtGcTime: i64 = 0x85C;
                pub const m_vecStart: i64 = 0x86C;
                pub const m_nUniqueID: i64 = 0x850;
                pub const m_unTraceID: i64 = 0x858;
                pub const m_vecEndPos: i64 = 0x860;
                pub const m_vecNormal: i64 = 0x884;
                pub const m_ubSignature: i64 = 0x8A5;
                pub const m_unAccountID: i64 = 0x854;
                pub const m_flCreationTime: i64 = 0x89C;
            };
            pub const CPlayerVisibility = struct {
                pub const m_bIsEnabled: i64 = 0x4B9;
                pub const m_flFadeTime: i64 = 0x4B4;
                pub const m_bStartDisabled: i64 = 0x4B8;
                pub const m_flVisibilityStrength: i64 = 0x4A8;
                pub const m_flFogDistanceMultiplier: i64 = 0x4AC;
                pub const m_flFogMaxDensityMultiplier: i64 = 0x4B0;
            };
            pub const CPointAngleSensor = struct {
                pub const m_bFired: i64 = 0x4CC;
                pub const m_TargetDir: i64 = 0x500;
                pub const m_bDisabled: i64 = 0x4A8;
                pub const m_flDuration: i64 = 0x4C0;
                pub const m_nLookAtName: i64 = 0x4B0;
                pub const m_flFacingTime: i64 = 0x4C8;
                pub const m_hLookAtEntity: i64 = 0x4BC;
                pub const m_hTargetEntity: i64 = 0x4B8;
                pub const m_OnFacingLookat: i64 = 0x4D0;
                pub const m_flDotTolerance: i64 = 0x4C4;
                pub const m_FacingPercentage: i64 = 0x528;
                pub const m_OnNotFacingLookat: i64 = 0x4E8;
            };
            pub const CPropDoorRotating = struct {
                pub const m_angGoal: i64 = 0xEE4;
                pub const m_vecAxis: i64 = 0xE90;
                pub const m_flDistance: i64 = 0xE9C;
                pub const m_flAjarAngle: i64 = 0xEB0;
                pub const m_eOpenDirection: i64 = 0xEA4;
                pub const m_eSpawnPosition: i64 = 0xEA0;
                pub const m_hEntityBlocker: i64 = 0xF24;
                pub const m_vecBackBoundsMax: i64 = 0xF14;
                pub const m_vecBackBoundsMin: i64 = 0xF08;
                pub const m_angRotationClosed: i64 = 0xEC0;
                pub const m_angRotationOpenBack: i64 = 0xED8;
                pub const m_vecForwardBoundsMax: i64 = 0xEFC;
                pub const m_vecForwardBoundsMin: i64 = 0xEF0;
                pub const m_eCurrentOpenDirection: i64 = 0xEA8;
                pub const m_angRotationOpenForward: i64 = 0xECC;
                pub const m_eDefaultCheckDirection: i64 = 0xEAC;
                pub const m_angRotationAjarDeprecated: i64 = 0xEB4;
                pub const m_bAjarDoorShouldntAlwaysOpen: i64 = 0xF20;
            };
            pub const CRelativeLocation = struct {
                pub const m_Type: i64 = 0x18;
                pub const m_hEntity: i64 = 0x34;
                pub const m_vWorldSpacePos: i64 = 0x28;
                pub const m_vRelativeOffset: i64 = 0x1C;
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
            pub const CSceneListManager = struct {
                pub const m_hScenes: i64 = 0x540;
                pub const m_iszScenes: i64 = 0x4C0;
                pub const m_hListManagers: i64 = 0x4A8;
            };
            pub const CScriptNavBlocker = struct {
                pub const m_vExtent: i64 = 0x868;
            };
            pub const CScriptedSequence = struct {
                pub const m_iszPlay: i64 = 0x4B8;
                pub const m_nMoveTo: i64 = 0x4E8;
                pub const m_flRadius: i64 = 0x514;
                pub const m_flRepeat: i64 = 0x518;
                pub const m_iszEntry: i64 = 0x4A8;
                pub const m_bThinking: i64 = 0x554;
                pub const m_flAngRate: i64 = 0x524;
                pub const m_hNextCine: i64 = 0x550;
                pub const m_iszEntity: i64 = 0x4D8;
                pub const m_startTime: i64 = 0x534;
                pub const m_hTargetEnt: i64 = 0x54C;
                pub const m_iszPreIdle: i64 = 0x4B0;
                pub const m_savedFlags: i64 = 0x540;
                pub const m_bForceSynch: i64 = 0x55D;
                pub const m_bSkipFadeIn: i64 = 0x6E8;
                pub const m_flMoveSpeed: i64 = 0x528;
                pub const m_iszPostIdle: i64 = 0x4C0;
                pub const m_nMoveToGait: i64 = 0x4EC;
                pub const m_iszSyncGroup: i64 = 0x4E0;
                pub const m_OnEndSequence: i64 = 0x598;
                pub const m_OnScriptEvent: i64 = 0x5F8;
                pub const m_bHighPriority: i64 = 0x503;
                pub const m_bIgnoreLookAt: i64 = 0x50A;
                pub const m_bIsRepeatable: i64 = 0x4FD;
                pub const m_bStartOnSpawn: i64 = 0x4FF;
                pub const m_hForcedTarget: i64 = 0x558;
                pub const m_iszNextScript: i64 = 0x4D0;
                pub const m_saved_effects: i64 = 0x53C;
                pub const m_bIgnoreGravity: i64 = 0x50B;
                pub const m_bInterruptable: i64 = 0x548;
                pub const m_matOtherToMain: i64 = 0x6C0;
                pub const m_OnBeginSequence: i64 = 0x568;
                pub const m_bIgnoreRotation: i64 = 0x510;
                pub const m_bIsPlayingEntry: i64 = 0x4F9;
                pub const m_bSynchPostIdles: i64 = 0x509;
                pub const m_onDeathBehavior: i64 = 0x560;
                pub const m_sequenceStarted: i64 = 0x549;
                pub const m_ConflictResponse: i64 = 0x564;
                pub const m_OnCancelSequence: i64 = 0x5C8;
                pub const m_bContinueOnDeath: i64 = 0x505;
                pub const m_bDontRotateOther: i64 = 0x4FC;
                pub const m_bIsPlayingAction: i64 = 0x4FA;
                pub const m_flMoveInterpTime: i64 = 0x520;
                pub const m_bDontAddModifiers: i64 = 0x50E;
                pub const m_bIsPlayingPreIdle: i64 = 0x4F8;
                pub const m_bDontTeleportAtEnd: i64 = 0x502;
                pub const m_bIsPlayingPostIdle: i64 = 0x4FB;
                pub const m_bShouldLeaveCorpse: i64 = 0x4FE;
                pub const m_nForcedCrouchState: i64 = 0x4F4;
                pub const m_OnActionStartOrLoop: i64 = 0x580;
                pub const m_bDisallowInterrupts: i64 = 0x500;
                pub const m_bLoopActionSequence: i64 = 0x507;
                pub const m_nHeldWeaponBehavior: i64 = 0x4F0;
                pub const m_savedCollisionGroup: i64 = 0x544;
                pub const m_bCanOverrideNPCState: i64 = 0x501;
                pub const m_bHideDebugComplaints: i64 = 0x504;
                pub const m_bInitiatedSelfDelete: i64 = 0x555;
                pub const m_bLoopPreIdleSequence: i64 = 0x506;
                pub const m_flPlayAnimFadeInTime: i64 = 0x51C;
                pub const m_iPlayerDeathBehavior: i64 = 0x6E4;
                pub const m_OnPostIdleEndSequence: i64 = 0x5B0;
                pub const m_bDisableNPCCollisions: i64 = 0x50C;
                pub const m_bLoopPostIdleSequence: i64 = 0x508;
                pub const m_bWaitForBeginSequence: i64 = 0x538;
                pub const m_OnCancelFailedSequence: i64 = 0x5E0;
                pub const m_hInteractionMainEntity: i64 = 0x6E0;
                pub const m_iszModifierToAddOnPlay: i64 = 0x4C8;
                pub const m_nNotReadySequenceCount: i64 = 0x530;
                pub const m_bEnsureOnNavmeshOnFinish: i64 = 0x55F;
                pub const m_bKeepAnimgraphLockedPost: i64 = 0x50D;
                pub const m_bDisableAimingWhileMoving: i64 = 0x50F;
                pub const m_bDontCancelOtherSequences: i64 = 0x55C;
                pub const m_bIsTeleportingDueToMoveTo: i64 = 0x556;
                pub const m_bPreventUpdateYawOnFinish: i64 = 0x55E;
                pub const m_bPositionRelativeToOtherEntity: i64 = 0x54A;
                pub const m_bAllowCustomInterruptConditions: i64 = 0x557;
                pub const m_bWaitUntilMoveCompletesToStartAnimation: i64 = 0x52C;
            };
            pub const CServerOnlyEntity = struct {

            };
            pub const CSkeletonInstance = struct {
                pub const m_modelState: i64 = 0x120;
                pub const m_nHitboxSet: i64 = 0x3BC;
                pub const m_materialGroup: i64 = 0x3B8;
                pub const m_bDirtyMotionType: i64 = 0x3B2;
                pub const m_bUseParentRenderBounds: i64 = 0x3B0;
                pub const m_bForceServerConstraintsEnabled: i64 = 0x41C;
                pub const m_bDisableSolidCollisionsForHierarchy: i64 = 0x3B1;
                pub const m_bIsGeneratingLatchedParentSpaceState: i64 = 0x3B3;
            };
            pub const CSoundEventEntity = struct {
                pub const m_hSource: i64 = 0x55C;
                pub const m_bStopOnNew: i64 = 0x4AA;
                pub const m_bSaveRestore: i64 = 0x4AB;
                pub const m_iszSoundName: i64 = 0x540;
                pub const m_bStartOnSpawn: i64 = 0x4A8;
                pub const m_onGUIDChanged: i64 = 0x4C8;
                pub const m_bToLocalPlayer: i64 = 0x4A9;
                pub const m_bSavedIsPlaying: i64 = 0x4AC;
                pub const m_onSoundFinished: i64 = 0x4F8;
                pub const m_iszAttachmentName: i64 = 0x4C0;
                pub const m_flClientCullRadius: i64 = 0x510;
                pub const m_flSavedElapsedTime: i64 = 0x4B0;
                pub const m_iszSourceEntityName: i64 = 0x4B8;
                pub const m_nEntityIndexSelection: i64 = 0x560;
            };
            pub const CSplineConstraint = struct {
                pub const m_pSplineBody: i64 = 0x568;
                pub const m_bEnableLimit: i64 = 0x573;
                pub const m_hSplineEntity: i64 = 0x564;
                pub const m_flJointFriction: i64 = 0x580;
                pub const m_flTransitionTime: i64 = 0x584;
                pub const m_bFireEventsOnPath: i64 = 0x574;
                pub const m_flLinearFrequency: i64 = 0x578;
                pub const m_vPreSolveAnchorPos: i64 = 0x598;
                pub const m_StartTransitionTime: i64 = 0x5A4;
                pub const m_flLinarDampingRatio: i64 = 0x57C;
                pub const m_vAnchorOffsetRestore: i64 = 0x558;
                pub const m_bEnableAngularConstraint: i64 = 0x572;
                pub const m_bEnableLateralConstraint: i64 = 0x570;
                pub const m_bEnableVerticalConstraint: i64 = 0x571;
                pub const m_vTangentSpaceAnchorAtTransitionStart: i64 = 0x5A8;
            };
            pub const CTakeDamageResult = struct {
                pub const m_nHealthLost: i64 = 0x18;
                pub const m_nDamageFlags: i64 = 0x48;
                pub const m_flDamageDealt: i64 = 0x20;
                pub const m_nHealthBefore: i64 = 0x1C;
                pub const m_bSuppressFlinch: i64 = 0x51;
                pub const m_vDamagePosition: i64 = 0x28;
                pub const m_pOriginatingInfo: i64 = 0x0;
                pub const m_flPreModifiedDamage: i64 = 0x24;
                pub const m_nTotalledHealthLost: i64 = 0x34;
                pub const m_bWasDamageSuppressed: i64 = 0x50;
                pub const m_flTotalledDamageDealt: i64 = 0x38;
                pub const m_nOverrideFlinchHitGroup: i64 = 0x54;
                pub const m_flNewDamageAccumulatorValue: i64 = 0x40;
                pub const m_flTotalledPreModifiedDamage: i64 = 0x3C;
                pub const m_DestructibleHitGroupRequests: i64 = 0x8;
            };
            pub const CTankTargetChange = struct {
                pub const m_newTarget: i64 = 0x4A8;
                pub const m_newTargetName: i64 = 0x4B8;
            };
            pub const CTriggerBombReset = struct {

            };
            pub const CTriggerGameEvent = struct {
                pub const m_strTriggerID: i64 = 0x9D8;
                pub const m_strEndTouchEventName: i64 = 0x9D0;
                pub const m_strStartTouchEventName: i64 = 0x9C8;
            };
            pub const CTriggerProximity = struct {
                pub const m_fRadius: i64 = 0x9D8;
                pub const m_nTouchers: i64 = 0x9DC;
                pub const m_hMeasureTarget: i64 = 0x9C8;
                pub const m_iszMeasureTarget: i64 = 0x9D0;
                pub const m_NearestEntityDistance: i64 = 0x9E0;
            };
            pub const PhysBlockHeader_t = struct {
                pub const nSaved: i64 = 0x0;
                pub const pWorldObject: i64 = 0x8;
            };
            pub const ResponseContext_t = struct {
                pub const m_iszName: i64 = 0x0;
                pub const m_iszValue: i64 = 0x8;
                pub const m_fExpirationTime: i64 = 0x10;
            };
            pub const SPAWNGROUP_HEADER = struct {
                pub const m_sGroupName: i64 = 0x0;
                pub const m_vecWorldOffset: i64 = 0x10;
                pub const m_sEntityLumpName: i64 = 0x8;
                pub const m_bClientSpawnGroup: i64 = 0x40;
                pub const m_bSuppressAllEntities: i64 = 0x41;
            };
            pub const SequenceHistory_t = struct {
                pub const m_hSequence: i64 = 0x0;
                pub const m_nSeqLoopMode: i64 = 0xC;
                pub const m_flPlaybackRate: i64 = 0x10;
                pub const m_flSeqStartTime: i64 = 0x4;
                pub const m_flSeqFixedCycle: i64 = 0x8;
                pub const m_flCyclesPerSecond: i64 = 0x14;
            };
            pub const fogplayerparams_t = struct {
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
            pub const modifiedconvars_t = struct {
                pub const pszConvar: i64 = 0x0;
                pub const pszOrgValue: i64 = 0x100;
                pub const pszCurrentValue: i64 = 0x80;
            };
            pub const CCSCustomHudLayout = struct {
                pub const m_strLayout: i64 = 0x4B8;
                pub const m_bObservable: i64 = 0x4C0;
                pub const m_vecPanelIds: i64 = 0x6C8;
                pub const m_vecClassNames: i64 = 0x6E0;
                pub const m_globalLayoutState: i64 = 0x530;
                pub const m_vecPlayerLayoutStates: i64 = 0x4C8;
                pub const m_vecDialogVariableNames: i64 = 0x6F8;
            };
            pub const CCSMinimapBoundary = struct {

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
            pub const CEnableMotionFixup = struct {

            };
            pub const CEnvInstructorHint = struct {
                pub const m_Color: i64 = 0x4E8;
                pub const m_fRange: i64 = 0x4F0;
                pub const m_bStatic: i64 = 0x4F7;
                pub const m_iszName: i64 = 0x4A8;
                pub const m_iTimeout: i64 = 0x4C0;
                pub const m_bAutoStart: i64 = 0x511;
                pub const m_iszBinding: i64 = 0x508;
                pub const m_iszCaption: i64 = 0x4D8;
                pub const m_fIconOffset: i64 = 0x4EC;
                pub const m_bNoOffscreen: i64 = 0x4F8;
                pub const m_iAlphaOption: i64 = 0x4F5;
                pub const m_iPulseOption: i64 = 0x4F4;
                pub const m_iShakeOption: i64 = 0x4F6;
                pub const m_bForceCaption: i64 = 0x4F9;
                pub const m_bSuppressRest: i64 = 0x500;
                pub const m_iDisplayLimit: i64 = 0x4C4;
                pub const m_iInstanceType: i64 = 0x4FC;
                pub const m_iszReplace_Key: i64 = 0x4B0;
                pub const m_bLocalPlayerOnly: i64 = 0x512;
                pub const m_iszIcon_Onscreen: i64 = 0x4C8;
                pub const m_iszIcon_Offscreen: i64 = 0x4D0;
                pub const m_bAllowNoDrawTarget: i64 = 0x510;
                pub const m_iszActivatorCaption: i64 = 0x4E0;
                pub const m_iszHintTargetEntity: i64 = 0x4B8;
            };
            pub const CExplosionTypeData = struct {
                pub const m_DecalType: i64 = 0xF8;
                pub const m_SoundName: i64 = 0x0;
                pub const m_bHasForces: i64 = 0xF1;
                pub const m_bIsIncindiary: i64 = 0xF0;
                pub const m_ParticleEffect: i64 = 0x10;
            };
            pub const CFilterMassGreater = struct {
                pub const m_fFilterMass: i64 = 0x4E0;
            };
            pub const CFuncRetakeBarrier = struct {

            };
            pub const CFuncTrainControls = struct {

            };
            pub const CGenericConstraint = struct {
                pub const m_bAxisNotifiedX: i64 = 0x58C;
                pub const m_bAxisNotifiedY: i64 = 0x58D;
                pub const m_bAxisNotifiedZ: i64 = 0x58E;
                pub const m_flNotifyForceX: i64 = 0x568;
                pub const m_flNotifyForceY: i64 = 0x56C;
                pub const m_flNotifyForceZ: i64 = 0x570;
                pub const m_nLinearMotionX: i64 = 0x514;
                pub const m_nLinearMotionY: i64 = 0x518;
                pub const m_nLinearMotionZ: i64 = 0x51C;
                pub const m_nAngularMotionX: i64 = 0x590;
                pub const m_nAngularMotionY: i64 = 0x594;
                pub const m_nAngularMotionZ: i64 = 0x598;
                pub const m_flBreakAfterTimeX: i64 = 0x544;
                pub const m_flBreakAfterTimeY: i64 = 0x548;
                pub const m_flBreakAfterTimeZ: i64 = 0x54C;
                pub const m_flLinearFrequencyX: i64 = 0x520;
                pub const m_flLinearFrequencyY: i64 = 0x524;
                pub const m_flLinearFrequencyZ: i64 = 0x528;
                pub const m_NotifyForceReachedX: i64 = 0x5C0;
                pub const m_NotifyForceReachedY: i64 = 0x5D8;
                pub const m_NotifyForceReachedZ: i64 = 0x5F0;
                pub const m_flAngularFrequencyX: i64 = 0x59C;
                pub const m_flAngularFrequencyY: i64 = 0x5A0;
                pub const m_flAngularFrequencyZ: i64 = 0x5A4;
                pub const m_flMaxLinearImpulseX: i64 = 0x538;
                pub const m_flMaxLinearImpulseY: i64 = 0x53C;
                pub const m_flMaxLinearImpulseZ: i64 = 0x540;
                pub const m_flMaxAngularImpulseX: i64 = 0x5B4;
                pub const m_flMaxAngularImpulseY: i64 = 0x5B8;
                pub const m_flMaxAngularImpulseZ: i64 = 0x5BC;
                pub const m_flLinearDampingRatioX: i64 = 0x52C;
                pub const m_flLinearDampingRatioY: i64 = 0x530;
                pub const m_flLinearDampingRatioZ: i64 = 0x534;
                pub const m_flNotifyForceMinTimeX: i64 = 0x574;
                pub const m_flNotifyForceMinTimeY: i64 = 0x578;
                pub const m_flNotifyForceMinTimeZ: i64 = 0x57C;
                pub const m_flAngularDampingRatioX: i64 = 0x5A8;
                pub const m_flAngularDampingRatioY: i64 = 0x5AC;
                pub const m_flAngularDampingRatioZ: i64 = 0x5B0;
                pub const m_flNotifyForceLastTimeX: i64 = 0x580;
                pub const m_flNotifyForceLastTimeY: i64 = 0x584;
                pub const m_flNotifyForceLastTimeZ: i64 = 0x588;
                pub const m_flBreakAfterTimeStartTimeX: i64 = 0x550;
                pub const m_flBreakAfterTimeStartTimeY: i64 = 0x554;
                pub const m_flBreakAfterTimeStartTimeZ: i64 = 0x558;
                pub const m_flBreakAfterTimeThresholdX: i64 = 0x55C;
                pub const m_flBreakAfterTimeThresholdY: i64 = 0x560;
                pub const m_flBreakAfterTimeThresholdZ: i64 = 0x564;
                pub const m_bPlaceAnchorsAtConstraintTransform: i64 = 0x510;
            };
            pub const CHostageRescueZone = struct {

            };
            pub const CIncendiaryGrenade = struct {

            };
            pub const CInfoVisibilityBox = struct {
                pub const m_nMode: i64 = 0x4AC;
                pub const m_bEnabled: i64 = 0x4BC;
                pub const m_vBoxSize: i64 = 0x4B0;
            };
            pub const CLogicLineToEntity = struct {
                pub const m_Line: i64 = 0x4A8;
                pub const m_EndEntity: i64 = 0x4DC;
                pub const m_SourceName: i64 = 0x4D0;
                pub const m_StartEntity: i64 = 0x4D8;
            };
            pub const CMolotovProjectile = struct {
                pub const m_bDetonated: i64 = 0xB58;
                pub const m_stillTimer: i64 = 0xB60;
                pub const m_bIsIncGrenade: i64 = 0xB40;
            };
            pub const CPointEntityFinder = struct {
                pub const m_hEntity: i64 = 0x4A8;
                pub const m_hFilter: i64 = 0x4B8;
                pub const m_iRefName: i64 = 0x4C0;
                pub const m_FindMethod: i64 = 0x4CC;
                pub const m_hReference: i64 = 0x4C8;
                pub const m_iFilterName: i64 = 0x4B0;
                pub const m_OnFoundEntity: i64 = 0x4D0;
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
            pub const CPulseServerCursor = struct {
                pub const m_hCaller: i64 = 0xEC;
                pub const m_hActivator: i64 = 0xE8;
            };
            pub const CPulse_ResumePoint = struct {

            };
            pub const CRagdollConstraint = struct {
                pub const m_xmax: i64 = 0x50C;
                pub const m_xmin: i64 = 0x508;
                pub const m_ymax: i64 = 0x514;
                pub const m_ymin: i64 = 0x510;
                pub const m_zmax: i64 = 0x51C;
                pub const m_zmin: i64 = 0x518;
                pub const m_xfriction: i64 = 0x520;
                pub const m_yfriction: i64 = 0x524;
                pub const m_zfriction: i64 = 0x528;
            };
            pub const CRelativeTransform = struct {
                pub const m_hEntity: i64 = 0x50;
                pub const m_transform: i64 = 0x10;
                pub const m_transformWS: i64 = 0x30;
                pub const m_bTransformIsWorldSpace: i64 = 0x0;
            };
            pub const CScriptTriggerHurt = struct {
                pub const m_vExtent: i64 = 0xA50;
            };
            pub const CScriptTriggerOnce = struct {
                pub const m_vExtent: i64 = 0x9E0;
            };
            pub const CScriptTriggerPush = struct {
                pub const m_vExtent: i64 = 0xA00;
            };
            pub const CShatterGlassShard = struct {
                pub const m_flArea: i64 = 0x6C;
                pub const m_hModel: i64 = 0x30;
                pub const m_hParentPanel: i64 = 0x3C;
                pub const m_hParentShard: i64 = 0x40;
                pub const m_hShardHandle: i64 = 0x8;
                pub const m_nOnFrameEdge: i64 = 0x70;
                pub const m_vecNeighbors: i64 = 0xA0;
                pub const m_bCreatedModel: i64 = 0x54;
                pub const m_flLongestEdge: i64 = 0x58;
                pub const m_flShortestEdge: i64 = 0x5C;
                pub const m_hPhysicsEntity: i64 = 0x38;
                pub const m_flLongestAcross: i64 = 0x60;
                pub const m_flSumOfAllEdges: i64 = 0x68;
                pub const m_flShortestAcross: i64 = 0x64;
                pub const m_hEntityHittingMe: i64 = 0x9C;
                pub const m_vecPanelVertices: i64 = 0x10;
                pub const m_ShatterStressType: i64 = 0x44;
                pub const m_vecStressVelocity: i64 = 0x48;
                pub const m_bFlaggedForRemoval: i64 = 0x96;
                pub const m_nSubShardGeneration: i64 = 0x74;
                pub const m_vLocalPanelSpaceOrigin: i64 = 0x28;
                pub const m_vecAverageVertPosition: i64 = 0x78;
                pub const m_bStressPositionAIsValid: i64 = 0x94;
                pub const m_bStressPositionBIsValid: i64 = 0x95;
                pub const m_bAverageVertPositionIsValid: i64 = 0x80;
                pub const m_flPhysicsEntitySpawnedAtTime: i64 = 0x98;
                pub const m_vecPanelSpaceStressPositionA: i64 = 0x84;
                pub const m_vecPanelSpaceStressPositionB: i64 = 0x8C;
            };
            pub const CTriggerLerpObject = struct {
                pub const m_OnDetached: i64 = 0xA50;
                pub const m_hLerpTarget: i64 = 0x9D0;
                pub const m_iszLerpSound: i64 = 0xA10;
                pub const m_OnLerpStarted: i64 = 0xA20;
                pub const m_iszLerpEffect: i64 = 0xA08;
                pub const m_iszLerpTarget: i64 = 0x9C8;
                pub const m_OnLerpFinished: i64 = 0xA38;
                pub const m_flLerpDuration: i64 = 0x9E4;
                pub const m_bSingleLerpObject: i64 = 0x9EA;
                pub const m_vecLerpingObjects: i64 = 0x9F0;
                pub const m_bLerpRestoreMoveType: i64 = 0x9E9;
                pub const m_bAttachTouchingObject: i64 = 0xA18;
                pub const m_hLerpTargetAttachment: i64 = 0x9E0;
                pub const m_iszLerpTargetAttachment: i64 = 0x9D8;
                pub const m_bAttachedEntityWasParented: i64 = 0x9E8;
                pub const m_hEntityToWaitForDisconnect: i64 = 0xA1C;
            };
            pub const CTriggerSoundscape = struct {
                pub const m_spectators: i64 = 0x9D8;
                pub const m_hSoundscape: i64 = 0x9C8;
                pub const m_SoundscapeName: i64 = 0x9D0;
            };
            pub const CWeaponUSPSilencer = struct {

            };
            pub const DecalGroupOption_t = struct {
                pub const m_hMaterial: i64 = 0x0;
                pub const m_flProbability: i64 = 0x10;
                pub const m_sSequenceName: i64 = 0x8;
                pub const m_flMaxAngleBetweenNormalAndGravity: i64 = 0x1C;
                pub const m_flMinAngleBetweenNormalAndGravity: i64 = 0x18;
                pub const m_bEnableAngleBetweenNormalAndGravityRange: i64 = 0x14;
            };
            pub const DynamicVolumeDef_t = struct {
                pub const m_source: i64 = 0x0;
                pub const m_target: i64 = 0x4;
                pub const m_nAreaDst: i64 = 0x28;
                pub const m_nAreaSrc: i64 = 0x24;
                pub const m_nHullIdx: i64 = 0x8;
                pub const m_bAttached: i64 = 0x2C;
                pub const m_vSourceAnchorPos: i64 = 0xC;
                pub const m_vTargetAnchorPos: i64 = 0x18;
            };
            pub const GameAmmoTypeInfo_t = struct {
                pub const m_nCost: i64 = 0x3C;
                pub const m_nBuySize: i64 = 0x38;
            };
            pub const HUDPanelHasClass_t = struct {
                pub const m_eClassStatus: i64 = 0x4;
                pub const m_nPanelIdIndex: i64 = 0x0;
                pub const m_nClassNameIndex: i64 = 0x2;
            };
            pub const IEconItemInterface = struct {

            };
            pub const PhysObjectHeader_t = struct {
                pub const bbox: i64 = 0x20;
                pub const _type: i64 = 0x0;
                pub const sphere: i64 = 0x38;
                pub const hEntity: i64 = 0x4;
                pub const iCollide: i64 = 0x3C;
                pub const fieldName: i64 = 0x8;
                pub const modelName: i64 = 0x18;
                pub const bSaveObject: i64 = 0x10;
            };
            pub const QueuedAISearchId_t = struct {
                pub const m_Value: i64 = 0x0;
            };
            pub const dynpitchvol_base_t = struct {
                pub const vol: i64 = 0x4C;
                pub const pitch: i64 = 0x3C;
                pub const fadein: i64 = 0x1C;
                pub const preset: i64 = 0x0;
                pub const spinup: i64 = 0xC;
                pub const volrun: i64 = 0x14;
                pub const cspinup: i64 = 0x34;
                pub const fadeout: i64 = 0x20;
                pub const lfofrac: i64 = 0x5C;
                pub const lfomult: i64 = 0x60;
                pub const lforate: i64 = 0x28;
                pub const lfotype: i64 = 0x24;
                pub const volfrac: i64 = 0x58;
                pub const pitchrun: i64 = 0x4;
                pub const spindown: i64 = 0x10;
                pub const volstart: i64 = 0x18;
                pub const fadeinsav: i64 = 0x50;
                pub const lfomodvol: i64 = 0x30;
                pub const pitchfrac: i64 = 0x48;
                pub const spinupsav: i64 = 0x40;
                pub const cspincount: i64 = 0x38;
                pub const fadeoutsav: i64 = 0x54;
                pub const pitchstart: i64 = 0x8;
                pub const lfomodpitch: i64 = 0x2C;
                pub const spindownsav: i64 = 0x44;
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
                pub const m_vecAssociatedEntityCollidesWithHierarchy: i64 = 0x70;
                pub const m_vecAssociatedEntityCollidesOutsideHierarchy: i64 = 0x80;
            };
            pub const CAI_ChangeHintGroup = struct {
                pub const m_flRadius: i64 = 0x4C0;
                pub const m_iSearchType: i64 = 0x4A8;
                pub const m_strSearchName: i64 = 0x4B0;
                pub const m_strNewHintGroup: i64 = 0x4B8;
            };
            pub const CAttributeContainer = struct {
                pub const m_Item: i64 = 0x50;
            };
            pub const CBaseClientUIEntity = struct {
                pub const m_PanelID: i64 = 0x868;
                pub const m_bEnabled: i64 = 0x850;
                pub const m_CustomOutput0: i64 = 0x870;
                pub const m_CustomOutput1: i64 = 0x890;
                pub const m_CustomOutput2: i64 = 0x8B0;
                pub const m_CustomOutput3: i64 = 0x8D0;
                pub const m_CustomOutput4: i64 = 0x8F0;
                pub const m_CustomOutput5: i64 = 0x910;
                pub const m_CustomOutput6: i64 = 0x930;
                pub const m_CustomOutput7: i64 = 0x950;
                pub const m_CustomOutput8: i64 = 0x970;
                pub const m_CustomOutput9: i64 = 0x990;
                pub const m_DialogXMLName: i64 = 0x858;
                pub const m_PanelClassName: i64 = 0x860;
            };
            pub const CBodyComponentPoint = struct {
                pub const m_sceneNode: i64 = 0x80;
            };
            pub const CCSPlayerController = struct {
                pub const m_iMVPs: i64 = 0x940;
                pub const m_iPing: i64 = 0x808;
                pub const m_iScore: i64 = 0x91C;
                pub const m_szClan: i64 = 0x840;
                pub const m_bShowHints: i64 = 0x968;
                pub const m_eMvpReason: i64 = 0x934;
                pub const m_iPawnArmor: i64 = 0x904;
                pub const m_iRoundsWon: i64 = 0x924;
                pub const m_nFirstKill: i64 = 0x930;
                pub const m_nKillCount: i64 = 0x931;
                pub const m_bMvpNoMusic: i64 = 0x932;
                pub const m_hPlayerPawn: i64 = 0x8EC;
                pub const m_iDraftIndex: i64 = 0x8B8;
                pub const m_iMusicKitID: i64 = 0x938;
                pub const m_iPawnHealth: i64 = 0x900;
                pub const m_iRoundScore: i64 = 0x920;
                pub const m_bPawnIsAlive: i64 = 0x8FC;
                pub const m_bTeamChanged: i64 = 0x834;
                pub const m_bInSwitchTeam: i64 = 0x835;
                pub const m_hObserverPawn: i64 = 0x8F0;
                pub const m_iCoachingTeam: i64 = 0x84C;
                pub const m_iMusicKitMVPs: i64 = 0x93C;
                pub const m_unClanId32bit: i64 = 0x848;
                pub const m_bPawnHasHelmet: i64 = 0x909;
                pub const m_bScoreReported: i64 = 0x8CD;
                pub const m_flSmoothedPing: i64 = 0x948;
                pub const m_iNextTimeCheck: i64 = 0x96C;
                pub const m_nUpdateCounter: i64 = 0x944;
                pub const m_bCannotBeKicked: i64 = 0x8C8;
                pub const m_bControllingBot: i64 = 0x8E0;
                pub const m_bPawnHasDefuser: i64 = 0x908;
                pub const m_flForceTeamTime: i64 = 0x824;
                pub const m_iPendingTeamNum: i64 = 0x820;
                pub const m_pDamageServices: i64 = 0x800;
                pub const m_recentKillQueue: i64 = 0x928;
                pub const m_unActiveQuestId: i64 = 0x87C;
                pub const m_bHasSeenJoinGame: i64 = 0x836;
                pub const m_bJustDidTeamKill: i64 = 0x970;
                pub const m_iCompetitiveWins: i64 = 0x864;
                pub const m_iPawnLifetimeEnd: i64 = 0x910;
                pub const m_nPlayerDominated: i64 = 0x850;
                pub const m_szCrosshairCodes: i64 = 0x818;
                pub const m_bEverPlayedOnTeam: i64 = 0x82C;
                pub const m_lastHeldVoteTimer: i64 = 0x950;
                pub const m_bPunishForTeamKill: i64 = 0x971;
                pub const m_flLastJoinTeamTime: i64 = 0x83C;
                pub const m_iCompTeammateColor: i64 = 0x828;
                pub const m_iPawnBotDifficulty: i64 = 0x914;
                pub const m_iPawnLifetimeStart: i64 = 0x90C;
                pub const m_nDisconnectionTick: i64 = 0x8D0;
                pub const m_pInventoryServices: i64 = 0x7F0;
                pub const m_DesiredObserverMode: i64 = 0x8F4;
                pub const m_bEverFullyConnected: i64 = 0x8C9;
                pub const m_iCompetitiveRanking: i64 = 0x860;
                pub const m_nPlayerDominatingMe: i64 = 0x858;
                pub const m_nSuspiciousHitCount: i64 = 0x988;
                pub const m_bAttemptedToGetColor: i64 = 0x82D;
                pub const m_bJustBecameSpectator: i64 = 0x837;
                pub const m_iCompetitiveRankType: i64 = 0x868;
                pub const m_nEndMatchNextMapVote: i64 = 0x878;
                pub const m_nQuestProgressReason: i64 = 0x884;
                pub const m_pInGameMoneyServices: i64 = 0x7E8;
                pub const m_rtActiveMissionPeriod: i64 = 0x880;
                pub const m_bCanControlObservedBot: i64 = 0x8E8;
                pub const m_bGaveTeamDamageWarning: i64 = 0x972;
                pub const m_hDesiredObserverTarget: i64 = 0x8F8;
                pub const m_nPawnCharacterDefIndex: i64 = 0x90A;
                pub const m_unPlayerTvControlFlags: i64 = 0x888;
                pub const m_bAbandonAllowsSurrender: i64 = 0x8CA;
                pub const m_iTeammatePreferredColor: i64 = 0x830;
                pub const m_nNonSuspiciousHitStreak: i64 = 0x98C;
                pub const m_pActionTrackingServices: i64 = 0x7F8;
                pub const m_uiAbandonRecordedReason: i64 = 0x8C0;
                pub const m_nBotsControlledThisRound: i64 = 0x8E4;
                pub const m_uiCommunicationMuteFlags: i64 = 0x810;
                pub const m_LastTeamDamageWarningTime: i64 = 0x980;
                pub const m_bHasCommunicationAbuseMute: i64 = 0x80C;
                pub const m_bHasControlledBotThisRound: i64 = 0x8E1;
                pub const m_eNetworkDisconnectionReason: i64 = 0x8C4;
                pub const m_bFireBulletsSeedSynchronized: i64 = 0xA39;
                pub const m_bSwitchTeamsOnNextRoundReset: i64 = 0x838;
                pub const m_bAbandonOffersInstantSurrender: i64 = 0x8CB;
                pub const m_bGaveTeamDamageWarningThisRound: i64 = 0x973;
                pub const m_bRemoveAllItemsOnNextRoundReset: i64 = 0x839;
                pub const m_bDisconnection1MinWarningPrinted: i64 = 0x8CC;
                pub const m_hOriginalControllerOfCurrentPawn: i64 = 0x918;
                pub const m_iCompetitiveRankingPredicted_Tie: i64 = 0x874;
                pub const m_iCompetitiveRankingPredicted_Win: i64 = 0x86C;
                pub const m_iCompetitiveRankingPredicted_Loss: i64 = 0x870;
                pub const m_dblLastReceivedPacketPlatFloatTime: i64 = 0x978;
                pub const m_msQueuedModeDisconnectionTimestamp: i64 = 0x8BC;
                pub const m_bHasBeenControlledByPlayerThisRound: i64 = 0x8E2;
                pub const m_LastTimePlayerWasDisconnectedForPawnsRemove: i64 = 0x984;
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
                pub const m_MainSoundscapeName: i64 = 0x538;
            };
            pub const CFilterAttributeInt = struct {
                pub const m_sAttributeName: i64 = 0x4E0;
            };
            pub const CFloatMovingAverage = struct {

            };
            pub const CFuncNavObstruction = struct {
                pub const m_bDisabled: i64 = 0x868;
                pub const m_bUseAsyncObstacleUpdate: i64 = 0x869;
            };
            pub const CGameChoreoServices = struct {
                pub const m_hOwner: i64 = 0x8;
                pub const m_choreoState: i64 = 0x14;
                pub const m_scriptState: i64 = 0x10;
                pub const m_hScriptedSequence: i64 = 0xC;
                pub const m_flTimeStartedState: i64 = 0x18;
            };
            pub const CInfoGameEventProxy = struct {
                pub const m_flRange: i64 = 0x4B0;
                pub const m_iszEventName: i64 = 0x4A8;
            };
            pub const CInfoLadderDismount = struct {

            };
            pub const CInfoParticleTarget = struct {

            };
            pub const CLogicActivityEvent = struct {
                pub const m_hSource: i64 = 0x4B8;
                pub const m_flDuration: i64 = 0x4AC;
                pub const m_nEventType: i64 = 0x4A8;
                pub const m_iszSourceEntityName: i64 = 0x4B0;
            };
            pub const CLogicCollisionPair = struct {
                pub const m_disabled: i64 = 0x4BA;
                pub const m_succeeded: i64 = 0x4BB;
                pub const m_nameAttach1: i64 = 0x4A8;
                pub const m_nameAttach2: i64 = 0x4B0;
                pub const m_allowMissing: i64 = 0x4BC;
                pub const m_includeHierarchy: i64 = 0x4B8;
                pub const m_supportMultipleEntitiesWithSameName: i64 = 0x4B9;
            };
            pub const CLogicDistanceCheck = struct {
                pub const m_InZone1: i64 = 0x4C0;
                pub const m_InZone2: i64 = 0x4D8;
                pub const m_InZone3: i64 = 0x4F0;
                pub const m_iszEntityA: i64 = 0x4A8;
                pub const m_iszEntityB: i64 = 0x4B0;
                pub const m_flZone1Distance: i64 = 0x4B8;
                pub const m_flZone2Distance: i64 = 0x4BC;
            };
            pub const CLogicEventListener = struct {
                pub const m_nTeam: i64 = 0x4C4;
                pub const m_bIsEnabled: i64 = 0x4C0;
                pub const m_OnEventFired: i64 = 0x4C8;
                pub const m_strEventName: i64 = 0x4B8;
            };
            pub const CLogicNPCCounterOBB = struct {

            };
            pub const CMarkupSearchHelper = struct {
                pub const m_bActive: i64 = 0x26;
                pub const m_navHull: i64 = 0x0;
                pub const m_vRefPos: i64 = 0x18;
                pub const m_tagString: i64 = 0x8;
                pub const m_bRefPosSet: i64 = 0x24;
                pub const m_nameString: i64 = 0x10;
                pub const m_bUseStepHeight: i64 = 0x25;
            };
            pub const CMarkupVolumeTagged = struct {
                pub const m_Tags: i64 = 0x870;
                pub const m_bIsGroup: i64 = 0x888;
                pub const m_GroupNames: i64 = 0x858;
                pub const m_bIsInGroup: i64 = 0x88C;
                pub const m_bGroupByPrefab: i64 = 0x889;
                pub const m_bGroupByVolume: i64 = 0x88A;
                pub const m_bGroupOtherGroups: i64 = 0x88B;
            };
            pub const CMomentaryRotButton = struct {
                pub const m_end: i64 = 0xA60;
                pub const m_start: i64 = 0xA54;
                pub const m_sNoise: i64 = 0xA70;
                pub const m_IdealYaw: i64 = 0xA6C;
                pub const m_Position: i64 = 0x9D0;
                pub const m_lastUsed: i64 = 0xA50;
                pub const m_direction: i64 = 0xA7C;
                pub const m_OnFullyOpen: i64 = 0xA08;
                pub const m_OnUnpressed: i64 = 0x9F0;
                pub const m_returnSpeed: i64 = 0xA80;
                pub const m_OnFullyClosed: i64 = 0xA20;
                pub const m_bUpdateTarget: i64 = 0xA78;
                pub const m_flStartPosition: i64 = 0xA84;
                pub const m_OnReachedPosition: i64 = 0xA38;
            };
            pub const CNavHullPresetVData = struct {
                pub const m_vecNavHulls: i64 = 0x0;
            };
            pub const CPathQueryComponent = struct {

            };
            pub const CPlayer_UseServices = struct {

            };
            pub const CPointChildModifier = struct {
                pub const m_bOrphanInsteadOfDeletingChildrenOnRemove: i64 = 0x4A8;
            };
            pub const CPointClientCommand = struct {

            };
            pub const CPointServerCommand = struct {

            };
            pub const CPointValueRemapper = struct {
                pub const m_OnEngage: i64 = 0x620;
                pub const m_Position: i64 = 0x598;
                pub const m_bEngaged: i64 = 0x538;
                pub const m_bDisabled: i64 = 0x4A8;
                pub const m_nInputType: i64 = 0x4AC;
                pub const m_OnDisengage: i64 = 0x638;
                pub const m_flSnapValue: i64 = 0x524;
                pub const m_nOutputType: i64 = 0x4D8;
                pub const m_bFirstUpdate: i64 = 0x539;
                pub const m_hUsingPlayer: i64 = 0x550;
                pub const m_nHapticsType: i64 = 0x518;
                pub const m_nRatchetType: i64 = 0x52C;
                pub const m_PositionDelta: i64 = 0x5B8;
                pub const m_flInputOffset: i64 = 0x534;
                pub const m_hRemapLineEnd: i64 = 0x4C4;
                pub const m_nMomentumType: i64 = 0x51C;
                pub const m_iszSoundEngage: i64 = 0x558;
                pub const m_bRequiresUseKey: i64 = 0x4D4;
                pub const m_bUpdateOnClient: i64 = 0x4A9;
                pub const m_flPreviousValue: i64 = 0x53C;
                pub const m_flRatchetOffset: i64 = 0x530;
                pub const m_hOutputEntities: i64 = 0x500;
                pub const m_hRemapLineStart: i64 = 0x4C0;
                pub const m_flEngageDistance: i64 = 0x4D0;
                pub const m_OnReachedValueOne: i64 = 0x5F0;
                pub const m_flCurrentMomentum: i64 = 0x528;
                pub const m_iszSoundDisengage: i64 = 0x560;
                pub const m_OnReachedValueZero: i64 = 0x5D8;
                pub const m_flMomentumModifier: i64 = 0x520;
                pub const m_iszSoundMovingLoop: i64 = 0x578;
                pub const m_flCustomOutputValue: i64 = 0x554;
                pub const m_flDisengageDistance: i64 = 0x4CC;
                pub const m_iszOutputEntityName: i64 = 0x4E0;
                pub const m_iszRemapLineEndName: i64 = 0x4B8;
                pub const m_OnReachedValueCustom: i64 = 0x608;
                pub const m_iszOutputEntity2Name: i64 = 0x4E8;
                pub const m_iszOutputEntity3Name: i64 = 0x4F0;
                pub const m_iszOutputEntity4Name: i64 = 0x4F8;
                pub const m_vecPreviousTestPoint: i64 = 0x544;
                pub const m_iszRemapLineStartName: i64 = 0x4B0;
                pub const m_iszSoundReachedValueOne: i64 = 0x570;
                pub const m_flMaximumChangePerSecond: i64 = 0x4C8;
                pub const m_flPreviousUpdateTickTime: i64 = 0x540;
                pub const m_iszSoundReachedValueZero: i64 = 0x568;
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
            pub const CTonemapController2 = struct {
                pub const m_flAutoExposureMax: i64 = 0x4AC;
                pub const m_flAutoExposureMin: i64 = 0x4A8;
                pub const m_flTonemapEVSmoothingRange: i64 = 0x4B8;
                pub const m_flExposureAdaptationSpeedUp: i64 = 0x4B0;
                pub const m_flExposureAdaptationSpeedDown: i64 = 0x4B4;
            };
            pub const CTriggerSndSosOpvar = struct {
                pub const m_bVolIs2D: i64 = 0xA10;
                pub const m_flMaxVal: i64 = 0x9F4;
                pub const m_flMinVal: i64 = 0x9F0;
                pub const m_opvarName: i64 = 0x9F8;
                pub const m_stackName: i64 = 0xA00;
                pub const m_VecNormPos: i64 = 0xD14;
                pub const m_flPosition: i64 = 0x9E0;
                pub const m_flCenterSize: i64 = 0x9EC;
                pub const m_operatorName: i64 = 0xA08;
                pub const m_opvarNameChar: i64 = 0xA11;
                pub const m_stackNameChar: i64 = 0xB11;
                pub const m_flNormCenterSize: i64 = 0xD20;
                pub const m_hTouchingPlayers: i64 = 0x9C8;
                pub const m_operatorNameChar: i64 = 0xC11;
            };
            pub const CWeaponM4A1Silencer = struct {

            };
            pub const ConstraintSoundInfo = struct {
                pub const m_vSampler: i64 = 0x8;
                pub const m_forwardAxis: i64 = 0x40;
                pub const m_soundProfile: i64 = 0x20;
                pub const m_bPlayTravelSound: i64 = 0x90;
                pub const m_iszTravelSoundFwd: i64 = 0x50;
                pub const m_bPlayReversalSound: i64 = 0x91;
                pub const m_iszTravelSoundBack: i64 = 0x58;
                pub const m_iszReversalSoundLarge: i64 = 0x88;
                pub const m_iszReversalSoundSmall: i64 = 0x78;
                pub const m_iszReversalSoundMedium: i64 = 0x80;
            };
            pub const ModelConfigHandle_t = struct {
                pub const m_Value: i64 = 0x0;
            };
            pub const magnetted_objects_t = struct {
                pub const hEntity: i64 = 0x8;
            };
            pub const sndopvarlatchdata_t = struct {
                pub const m_vPos: i64 = 0x24;
                pub const m_flVal: i64 = 0x20;
                pub const m_iszOpvar: i64 = 0x18;
                pub const m_iszStack: i64 = 0x8;
                pub const m_iszOperator: i64 = 0x10;
            };
            pub const CBaseCombatCharacter = struct {
                pub const m_eHull: i64 = 0xAC8;
                pub const m_nNavHullIdx: i64 = 0xACC;
                pub const m_hMyWearables: i64 = 0xA48;
                pub const m_movementStats: i64 = 0xAD0;
                pub const m_strRelationships: i64 = 0xAC0;
                pub const m_vecRelationships: i64 = 0xAA8;
                pub const m_impactEnergyScale: i64 = 0xA60;
                pub const m_bApplyStressDamage: i64 = 0xA64;
                pub const m_bForceServerRagdoll: i64 = 0xA40;
                pub const m_bDeathEventsDispatched: i64 = 0xA65;
            };
            pub const CCSObservableElement = struct {
                pub const m_nTeamFilter: i64 = 0x4D0;
                pub const m_hObservableModelEntity: i64 = 0x4C8;
                pub const m_hObservableModelEntity2: i64 = 0x4CC;
                pub const m_iszObservableModelEntity: i64 = 0x4C0;
            };
            pub const CCSPointScriptEntity = struct {

            };
            pub const CCSWeaponBaseShotgun = struct {

            };
            pub const CCopyRecipientFilter = struct {
                pub const m_Flags: i64 = 0x8;
                pub const m_Recipients: i64 = 0x10;
                pub const m_slotPlayerExcludedDueToPrediction: i64 = 0x30;
            };
            pub const CDebugSnapshotData_t = struct {
                pub const m_text: i64 = 0x0;
                pub const m_hEntity: i64 = 0x100;
                pub const m_children: i64 = 0x120;
                pub const m_dataType: i64 = 0x8;
                pub const m_userData: i64 = 0x10;
                pub const m_drawColor: i64 = 0xD8;
                pub const m_userFlags: i64 = 0xC;
                pub const m_userShape: i64 = 0x40;
                pub const m_userVector: i64 = 0x14;
                pub const m_sEntityName: i64 = 0x108;
                pub const m_nEntityIndex: i64 = 0x110;
                pub const m_userTransform: i64 = 0x20;
                pub const m_pStructuredData: i64 = 0xF8;
                pub const m_vecDebugOverlayData: i64 = 0xE0;
            };
            pub const CEnvDetailController = struct {
                pub const m_flFadeEndDist: i64 = 0x4AC;
                pub const m_flFadeStartDist: i64 = 0x4A8;
            };
            pub const CEnvInstructorVRHint = struct {
                pub const m_iszName: i64 = 0x4A8;
                pub const m_iTimeout: i64 = 0x4B8;
                pub const m_iszCaption: i64 = 0x4C0;
                pub const m_iAttachType: i64 = 0x4E0;
                pub const m_iszStartSound: i64 = 0x4C8;
                pub const m_flHeightOffset: i64 = 0x4E4;
                pub const m_iLayoutFileType: i64 = 0x4D0;
                pub const m_iszCustomLayoutFile: i64 = 0x4D8;
                pub const m_iszHintTargetEntity: i64 = 0x4B0;
            };
            pub const CEnvLightProbeVolume = struct {
                pub const m_Entity_bEnabled: i64 = 0x5C1;
                pub const m_Entity_vBoxMaxs: i64 = 0x584;
                pub const m_Entity_vBoxMins: i64 = 0x578;
                pub const m_Entity_bMoveable: i64 = 0x590;
                pub const m_Entity_nPriority: i64 = 0x598;
                pub const m_Entity_nHandshake: i64 = 0x594;
                pub const m_Entity_bStartDisabled: i64 = 0x59C;
                pub const m_Entity_nLightProbeSizeX: i64 = 0x5A0;
                pub const m_Entity_nLightProbeSizeY: i64 = 0x5A4;
                pub const m_Entity_nLightProbeSizeZ: i64 = 0x5A8;
                pub const m_Entity_nLightProbeAtlasX: i64 = 0x5AC;
                pub const m_Entity_nLightProbeAtlasY: i64 = 0x5B0;
                pub const m_Entity_nLightProbeAtlasZ: i64 = 0x5B4;
                pub const m_Entity_hLightProbeTexture_SDF: i64 = 0x548;
                pub const m_Entity_hLightProbeTexture_SH2_DC: i64 = 0x550;
                pub const m_Entity_hLightProbeTexture_SH2_L1: i64 = 0x558;
                pub const m_Entity_hLightProbeTexture_AmbientCube: i64 = 0x540;
                pub const m_Entity_hLightProbeDirectLightIndicesTexture: i64 = 0x560;
                pub const m_Entity_hLightProbeDirectLightScalarsTexture: i64 = 0x568;
                pub const m_Entity_hLightProbeDirectLightShadowsTexture: i64 = 0x570;
            };
            pub const CFlashbangProjectile = struct {
                pub const m_numOpponentsHit: i64 = 0xB44;
                pub const m_numTeammatesHit: i64 = 0xB45;
                pub const m_flTimeToDetonate: i64 = 0xB40;
            };
            pub const CFootstepTableHandle = struct {

            };
            pub const CFuncPropRespawnZone = struct {

            };
            pub const CGameSceneNodeHandle = struct {
                pub const m_name: i64 = 0xC;
                pub const m_hOwner: i64 = 0x8;
            };
            pub const CHEGrenadeProjectile = struct {

            };
            pub const CInfoDeathmatchSpawn = struct {

            };
            pub const CInfoPlayerTerrorist = struct {

            };
            pub const CIronSightController = struct {
                pub const m_flIronSightAmount: i64 = 0xC;
                pub const m_bIronSightAvailable: i64 = 0x8;
                pub const m_flIronSightAmountBiased: i64 = 0x14;
                pub const m_flIronSightAmountGained: i64 = 0x10;
            };
            pub const CLogicActiveAutosave = struct {
                pub const m_flStartTime: i64 = 0x4C0;
                pub const m_flDangerousTime: i64 = 0x4C4;
                pub const m_flTimeToTrigger: i64 = 0x4BC;
                pub const m_TriggerHitPoints: i64 = 0x4B8;
            };
            pub const CLogicNPCCounterAABB = struct {
                pub const m_vOuterMaxs: i64 = 0x74C;
                pub const m_vOuterMins: i64 = 0x740;
                pub const m_vDistanceOuterMaxs: i64 = 0x734;
                pub const m_vDistanceOuterMins: i64 = 0x728;
            };
            pub const CMarkupVolumeWithRef = struct {
                pub const m_bUseRef: i64 = 0x898;
                pub const m_flRefDot: i64 = 0x8B4;
                pub const m_vRefPosWorldSpace: i64 = 0x8A8;
                pub const m_vRefPosEntitySpace: i64 = 0x89C;
            };
            pub const CNMEventPulseState_t = struct {
                pub const m_eventID: i64 = 0x0;
            };
            pub const CNavPathCostForTests = struct {

            };
            pub const CPhysSlideConstraint = struct {
                pub const m_axisEnd: i64 = 0x510;
                pub const m_soundInfo: i64 = 0x538;
                pub const m_initialOffset: i64 = 0x524;
                pub const m_slideFriction: i64 = 0x51C;
                pub const m_bUseEntityPivot: i64 = 0x534;
                pub const m_systemLoadScale: i64 = 0x520;
                pub const m_flMotorFrequency: i64 = 0x52C;
                pub const m_flMotorDampingRatio: i64 = 0x530;
                pub const m_bEnableLinearConstraint: i64 = 0x528;
                pub const m_bEnableAngularConstraint: i64 = 0x529;
            };
            pub const CPhysWheelConstraint = struct {
                pub const m_flMaxSteeringAngle: i64 = 0x528;
                pub const m_flMinSteeringAngle: i64 = 0x524;
                pub const m_flSpinAxisFriction: i64 = 0x530;
                pub const m_bEnableSteeringLimit: i64 = 0x520;
                pub const m_flMaxSuspensionOffset: i64 = 0x51C;
                pub const m_flMinSuspensionOffset: i64 = 0x518;
                pub const m_flSuspensionFrequency: i64 = 0x508;
                pub const m_hSteeringMimicsEntity: i64 = 0x534;
                pub const m_bEnableSuspensionLimit: i64 = 0x514;
                pub const m_flSteeringAxisFriction: i64 = 0x52C;
                pub const m_flSuspensionDampingRatio: i64 = 0x50C;
                pub const m_flSuspensionHeightOffset: i64 = 0x510;
            };
            pub const CPhysicsEntitySolver = struct {
                pub const m_cancelTime: i64 = 0x4CC;
                pub const m_hMovingEntity: i64 = 0x4C0;
                pub const m_hPhysicsBlocker: i64 = 0x4C4;
                pub const m_separationDuration: i64 = 0x4C8;
            };
            pub const CPhysicsPropOverride = struct {

            };
            pub const CPlayerPawnComponent = struct {
                pub const __m_pChainEntity: i64 = 0x8;
                pub const m_pComponentGraphController: i64 = 0x30;
            };
            pub const CPlayer_ItemServices = struct {

            };
            pub const CPointClientUIDialog = struct {
                pub const m_hActivator: i64 = 0x9B0;
                pub const m_bStartEnabled: i64 = 0x9B4;
            };
            pub const CPointCommentaryNode = struct {
                pub const m_bActive: i64 = 0xAE8;
                pub const m_iszTitle: i64 = 0xAF8;
                pub const m_bDisabled: i64 = 0xAA5;
                pub const m_bListenedTo: i64 = 0xB10;
                pub const m_flStartTime: i64 = 0xAEC;
                pub const m_hViewTarget: i64 = 0xA60;
                pub const m_iNodeNumber: i64 = 0xB08;
                pub const m_iszSpeakers: i64 = 0xB00;
                pub const m_bUnstoppable: i64 = 0xA7A;
                pub const m_hViewPosition: i64 = 0xA70;
                pub const m_iszViewTarget: i64 = 0xA58;
                pub const m_flFinishedTime: i64 = 0xA7C;
                pub const m_iNodeNumberMax: i64 = 0xB0C;
                pub const m_iszPreCommands: i64 = 0xA40;
                pub const m_bUnderCrosshair: i64 = 0xA79;
                pub const m_iszPostCommands: i64 = 0xA48;
                pub const m_iszViewPosition: i64 = 0xA68;
                pub const m_vecFinishAngles: i64 = 0xA98;
                pub const m_vecFinishOrigin: i64 = 0xA80;
                pub const m_bPreventMovement: i64 = 0xA78;
                pub const m_hViewTargetAngles: i64 = 0xA64;
                pub const m_iszCommentaryFile: i64 = 0xA50;
                pub const m_vecOriginalAngles: i64 = 0xA8C;
                pub const m_vecTeleportOrigin: i64 = 0xAA8;
                pub const m_hViewPositionMover: i64 = 0xA74;
                pub const m_flAbortedPlaybackAt: i64 = 0xAB4;
                pub const m_pOnCommentaryStarted: i64 = 0xAB8;
                pub const m_pOnCommentaryStopped: i64 = 0xAD0;
                pub const m_flStartTimeInCommentary: i64 = 0xAF0;
                pub const m_bPreventChangesWhileMoving: i64 = 0xAA4;
            };
            pub const CPointVelocitySensor = struct {
                pub const m_vecAxis: i64 = 0x4AC;
                pub const m_Velocity: i64 = 0x4C8;
                pub const m_bEnabled: i64 = 0x4B8;
                pub const m_fPrevVelocity: i64 = 0x4BC;
                pub const m_flAvgInterval: i64 = 0x4C0;
                pub const m_hTargetEntity: i64 = 0x4A8;
            };
            pub const CPulseCell_BaseState = struct {

            };
            pub const CPulseCell_BaseValue = struct {

            };
            pub const CPulseGameBlackboard = struct {
                pub const m_strGraphName: i64 = 0x4B0;
                pub const m_strStateBlob: i64 = 0x4B8;
            };
            pub const CPulse_InvokeBinding = struct {
                pub const m_FuncName: i64 = 0x30;
                pub const m_nSrcChunk: i64 = 0x44;
                pub const m_nCellIndex: i64 = 0x40;
                pub const m_RegisterMap: i64 = 0x0;
                pub const m_nSrcInstruction: i64 = 0x48;
            };
            pub const CRagdollPropAttached = struct {
                pub const m_bShouldDetach: i64 = 0xC20;
                pub const m_boneIndexAttached: i64 = 0xC00;
                pub const m_attachmentPointBoneSpace: i64 = 0xC08;
                pub const m_ragdollAttachedObjectIndex: i64 = 0xC04;
                pub const m_attachmentPointRagdollSpace: i64 = 0xC14;
                pub const m_bShouldDeleteAttachedActivationRecord: i64 = 0xC30;
            };
            pub const CResponseCriteriaSet = struct {
                pub const m_bOverrideOnAppend: i64 = 0x30;
            };
            pub const CSoundAreaEntityBase = struct {
                pub const m_vPos: i64 = 0x4B8;
                pub const m_bDisabled: i64 = 0x4A8;
                pub const m_iszSoundAreaType: i64 = 0x4B0;
            };
            pub const CSoundEventBoxEntity = struct {
                pub const m_iszBoxEntities: i64 = 0x5A0;
                pub const m_vecBoxHelpersNetworked: i64 = 0x638;
            };
            pub const CSoundEventBoxHelper = struct {
                pub const m_vMaxs: i64 = 0x4B4;
                pub const m_vMins: i64 = 0x4A8;
            };
            pub const CSoundEventOBBEntity = struct {
                pub const m_vMaxs: i64 = 0x574;
                pub const m_vMins: i64 = 0x568;
            };
            pub const CSoundEventParameter = struct {
                pub const m_flFloatValue: i64 = 0x4C8;
                pub const m_iszParamName: i64 = 0x4C0;
            };
            pub const CSoundOpvarSetEntity = struct {
                pub const m_nOpvarType: i64 = 0x4D8;
                pub const m_bSetOnSpawn: i64 = 0x4F0;
                pub const m_nOpvarIndex: i64 = 0x4DC;
                pub const m_flOpvarValue: i64 = 0x4E0;
                pub const m_iszOpvarName: i64 = 0x4D0;
                pub const m_iszStackName: i64 = 0x4C0;
                pub const m_iszOperatorName: i64 = 0x4C8;
                pub const m_OpvarValueString: i64 = 0x4E8;
            };
            pub const CTriggerHostageReset = struct {

            };
            pub const CVectorMovingAverage = struct {

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
            pub const PathMoverEntitySpawn = struct {
                pub const hMover: i64 = 0x0;
                pub const nSpawnNumber: i64 = 0x20;
                pub const vecOtherEntities: i64 = 0x8;
            };
            pub const PhysicsRagdollPose_t = struct {
                pub const m_hOwner: i64 = 0x20;
                pub const m_RelativeTransforms: i64 = 0x8;
                pub const m_bSetFromDebugHistory: i64 = 0x24;
            };
            pub const CBasePlayerController = struct {
                pub const m_hPawn: i64 = 0x4E0;
                pub const m_bIsHLTV: i64 = 0x510;
                pub const m_steamID: i64 = 0x710;
                pub const m_bPredict: i64 = 0x5AD;
                pub const m_fLerpTime: i64 = 0x5A8;
                pub const m_nTickBase: i64 = 0x4B8;
                pub const m_iConnected: i64 = 0x514;
                pub const m_bGamePaused: i64 = 0x5B5;
                pub const m_hSplitOwner: i64 = 0x4F0;
                pub const m_iDesiredFOV: i64 = 0x71C;
                pub const m_iszPlayerName: i64 = 0x51C;
                pub const m_bIsLowViolence: i64 = 0x5B4;
                pub const m_bNoClipEnabled: i64 = 0x718;
                pub const m_iMostConnected: i64 = 0x518;
                pub const m_bLagCompensation: i64 = 0x5AC;
                pub const m_nSplitScreenSlot: i64 = 0x4EC;
                pub const m_iIgnoreGlobalChat: i64 = 0x6F0;
                pub const m_szNetworkIDString: i64 = 0x5A0;
                pub const m_bKnownTeamMismatch: i64 = 0x4E4;
                pub const m_hSplitScreenPlayers: i64 = 0x4F8;
                pub const m_flLastPlayerTalkTime: i64 = 0x6F4;
                pub const m_bHasAnySteadyStateEnts: i64 = 0x700;
                pub const m_flLastEntitySteadyState: i64 = 0x6F8;
                pub const m_nInButtonsWhichAreToggles: i64 = 0x4B0;
                pub const m_nAvailableEntitySteadyState: i64 = 0x6FC;
            };
            pub const CBreakableStageHelper = struct {
                pub const m_nStageCount: i64 = 0xC;
                pub const m_nCurrentStage: i64 = 0x8;
            };
            pub const CCSCustomPlayerCamera = struct {
                pub const m_hPawn: i64 = 0x4A8;
                pub const m_bFollowEyes: i64 = 0x4B4;
                pub const m_nCameraMode: i64 = 0x4AC;
                pub const m_hFollowEntity: i64 = 0x4B0;
                pub const m_vecCameraOffset: i64 = 0x4C4;
                pub const m_vecFollowOffset: i64 = 0x4B8;
                pub const m_bClipCameraOffset: i64 = 0x4D0;
                pub const m_flCameraOffsetReturnStrength: i64 = 0x4D4;
            };
            pub const CCSGameModeRules_Noop = struct {

            };
            pub const CCSPlayer_BuyServices = struct {
                pub const m_vecSellbackPurchaseEntries: i64 = 0xD0;
            };
            pub const CCSPlayer_UseServices = struct {
                pub const m_flLastUseTimeStamp: i64 = 0x4C;
                pub const m_hLastKnownUseEntity: i64 = 0x48;
                pub const m_flTimeLastUsedWindow: i64 = 0x50;
            };
            pub const CDebugDrawHistoryData = struct {
                pub const m_bools: i64 = 0x58;
                pub const m_etype: i64 = 0x4;
                pub const m_times: i64 = 0x38;
                pub const m_colors: i64 = 0x18;
                pub const m_hEntity: i64 = 0x0;
                pub const m_strings: i64 = 0x68;
                pub const m_uint64s: i64 = 0x48;
                pub const m_vectors: i64 = 0x8;
                pub const m_dimensions: i64 = 0x28;
            };
            pub const CEmptyGraphController = struct {

            };
            pub const CGameScriptedMoveData = struct {
                pub const m_vSrc: i64 = 0x18;
                pub const m_vDest: i64 = 0x58;
                pub const m_angDst: i64 = 0x64;
                pub const m_angSrc: i64 = 0x24;
                pub const m_bActive: i64 = 0x4C;
                pub const m_bSuccess: i64 = 0x4F;
                pub const m_flAngRate: i64 = 0x40;
                pub const m_angCurrent: i64 = 0x30;
                pub const m_flDuration: i64 = 0x44;
                pub const m_flStartTime: i64 = 0x48;
                pub const m_hDestEntity: i64 = 0x70;
                pub const m_flLockedSpeed: i64 = 0x3C;
                pub const m_bTeleportOnEnd: i64 = 0x4D;
                pub const m_bIgnoreRotation: i64 = 0x4E;
                pub const m_bIgnoreCollisions: i64 = 0x54;
                pub const m_nForcedCrouchState: i64 = 0x50;
                pub const m_vAccumulatedRootMotion: i64 = 0x0;
                pub const m_angAccumulatedRootMotionRotation: i64 = 0xC;
            };
            pub const CHostageCarriableProp = struct {

            };
            pub const CHostageExpresserShim = struct {
                pub const m_pExpresser: i64 = 0xB10;
            };
            pub const CInfoTargetServerOnly = struct {

            };
            pub const CInstancedSceneEntity = struct {
                pub const m_hOwner: i64 = 0x800;
                pub const m_hTarget: i64 = 0x814;
                pub const m_bHadOwner: i64 = 0x804;
                pub const m_flPreDelay: i64 = 0x80C;
                pub const m_bIsBackground: i64 = 0x810;
                pub const m_flPostSpeakDelay: i64 = 0x808;
            };
            pub const CLogicGameStateReport = struct {
                pub const m_bDisabled: i64 = 0x4A8;
            };
            pub const CLogicMeasureMovement = struct {
                pub const m_flScale: i64 = 0x4D0;
                pub const m_hTarget: i64 = 0x4C8;
                pub const m_nMeasureType: i64 = 0x4D4;
                pub const m_hMeasureTarget: i64 = 0x4C0;
                pub const m_hTargetReference: i64 = 0x4CC;
                pub const m_strMeasureTarget: i64 = 0x4A8;
                pub const m_hMeasureReference: i64 = 0x4C4;
                pub const m_strTargetReference: i64 = 0x4B8;
                pub const m_strMeasureReference: i64 = 0x4B0;
            };
            pub const CLogicPlayerProxyBase = struct {
                pub const m_hPlayer: i64 = 0x510;
                pub const m_PlayerDied: i64 = 0x4D8;
                pub const m_PlayerHasAmmo: i64 = 0x4A8;
                pub const m_PlayerHasNoAmmo: i64 = 0x4C0;
                pub const m_RequestedPlayerHealth: i64 = 0x4F0;
            };
            pub const CMapSharedEnvironment = struct {
                pub const m_targetMapName: i64 = 0x4A8;
            };
            pub const CNmEventConsumerCloth = struct {

            };
            pub const CNmEventConsumerPulse = struct {

            };
            pub const CNmEventConsumerSound = struct {

            };
            pub const CPathWithDynamicNodes = struct {
                pub const m_vecPathNodes: i64 = 0x5B0;
                pub const m_eDesiredDirection: i64 = 0x5F0;
                pub const m_bIgnoreParentRotation: i64 = 0x5F4;
                pub const m_xInitialPathWorldToLocal: i64 = 0x5D0;
            };
            pub const CPlayer_WaterServices = struct {

            };
            pub const CPointProximitySensor = struct {
                pub const m_Distance: i64 = 0x4B0;
                pub const m_bDisabled: i64 = 0x4A8;
                pub const m_hTargetEntity: i64 = 0x4AC;
            };
            pub const CPostProcessingVolume = struct {
                pub const m_bMaster: i64 = 0xA04;
                pub const m_flMaxExposure: i64 = 0x9F0;
                pub const m_flMinExposure: i64 = 0x9EC;
                pub const m_hPostSettings: i64 = 0x9D8;
                pub const m_flFadeDuration: i64 = 0x9E0;
                pub const m_bExposureControl: i64 = 0xA05;
                pub const m_flMaxLogExposure: i64 = 0x9E8;
                pub const m_flMinLogExposure: i64 = 0x9E4;
                pub const m_flExposureFadeSpeedUp: i64 = 0x9F8;
                pub const m_flExposureCompensation: i64 = 0x9F4;
                pub const m_flExposureFadeSpeedDown: i64 = 0x9FC;
                pub const m_flTonemapEVSmoothingRange: i64 = 0xA00;
            };
            pub const CPrecipitationBlocker = struct {

            };
            pub const CPulseCell_LimitCount = struct {
                pub const m_nLimitCount: i64 = 0x48;
            };
            pub const CServerRagdollTrigger = struct {

            };
            pub const CSoundEventAABBEntity = struct {
                pub const m_vMaxs: i64 = 0x574;
                pub const m_vMins: i64 = 0x568;
            };
            pub const CSoundEventConeEntity = struct {
                pub const m_flAttenMax: i64 = 0x574;
                pub const m_flAttenMin: i64 = 0x570;
                pub const m_flEmitterAngle: i64 = 0x568;
                pub const m_flSweetSpotAngle: i64 = 0x56C;
                pub const m_iszParameterName: i64 = 0x578;
            };
            pub const CSpriteAlias_env_glow = struct {

            };
            pub const CTestPulseIOComponent = struct {
                pub const m_ComponentData: i64 = 0x8;
                pub const m_OnComponentTestFunc: i64 = 0x10;
            };
            pub const PointCameraSettings_t = struct {
                pub const m_flFarCrispDistance: i64 = 0x8;
                pub const m_flFarBlurryDistance: i64 = 0xC;
                pub const m_flNearCrispDistance: i64 = 0x4;
                pub const m_flNearBlurryDistance: i64 = 0x0;
            };
            pub const PrecipitationFilter_t = struct {
                pub const m_flMaxRadius: i64 = 0x0;
            };
            pub const WeaponPurchaseCount_t = struct {
                pub const m_nCount: i64 = 0x32;
                pub const m_nItemDefIndex: i64 = 0x30;
            };
            pub const WrappedPhysicsJoint_t = struct {
                pub const m_pJoint: i64 = 0x0;
            };
            pub const physics_save_sphere_t = struct {
                pub const radius: i64 = 0x0;
            };
            pub const AutoRoomDoorwayPairs_t = struct {
                pub const vP1: i64 = 0x0;
                pub const vP2: i64 = 0xC;
            };
            pub const CAnimGraph2InstancePtr = struct {

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
            pub const CCSPlayer_ItemServices = struct {
                pub const m_bHasHelmet: i64 = 0x49;
                pub const m_bHasDefuser: i64 = 0x48;
            };
            pub const CCSPlayer_PingServices = struct {
                pub const m_hPlayerPing: i64 = 0x5C;
                pub const m_flPlayerPingTokens: i64 = 0x48;
            };
            pub const CColorCorrectionVolume = struct {
                pub const m_Weight: i64 = 0x9D0;
                pub const m_MaxWeight: i64 = 0x9C8;
                pub const m_FadeDuration: i64 = 0x9CC;
                pub const m_LastExitTime: i64 = 0xBE0;
                pub const m_LastEnterTime: i64 = 0xBD8;
                pub const m_LastExitWeight: i64 = 0xBDC;
                pub const m_lookupFilename: i64 = 0x9D4;
                pub const m_LastEnterWeight: i64 = 0xBD4;
            };
            pub const CExternalAnimGraphList = struct {

            };
            pub const CFuncElectrifiedVolume = struct {
                pub const m_EffectName: i64 = 0x870;
                pub const m_EffectZapName: i64 = 0x880;
                pub const m_iszEffectSource: i64 = 0x888;
                pub const m_EffectInterpenetrateName: i64 = 0x878;
            };
            pub const CGameScriptedMoveDef_t = struct {
                pub const m_angDest: i64 = 0x10;
                pub const m_flAngRate: i64 = 0x20;
                pub const m_flDuration: i64 = 0x1C;
                pub const m_flMoveSpeed: i64 = 0x24;
                pub const m_hDestEntity: i64 = 0xC;
                pub const m_vDestOffset: i64 = 0x0;
                pub const m_bAimDisabled: i64 = 0x28;
                pub const m_bIgnoreRotation: i64 = 0x29;
                pub const m_nForcedCrouchState: i64 = 0x2C;
            };
            pub const CHostageRescueZoneShim = struct {

            };
            pub const CInfoDynamicShadowHint = struct {
                pub const m_hLight: i64 = 0x4B8;
                pub const m_flRange: i64 = 0x4AC;
                pub const m_bDisabled: i64 = 0x4A8;
                pub const m_nImportance: i64 = 0x4B0;
                pub const m_nLightChoice: i64 = 0x4B4;
            };
            pub const CInstructorEventEntity = struct {
                pub const m_iszName: i64 = 0x4A8;
                pub const m_hTargetPlayer: i64 = 0x4B8;
                pub const m_iszHintTargetEntity: i64 = 0x4B0;
            };
            pub const CLogicDistanceAutosave = struct {
                pub const m_bCheckCough: i64 = 0x4B5;
                pub const m_bThinkDangerous: i64 = 0x4B6;
                pub const m_flDangerousTime: i64 = 0x4B8;
                pub const m_iszTargetEntity: i64 = 0x4A8;
                pub const m_bForceNewLevelUnit: i64 = 0x4B4;
                pub const m_flDistanceToPlayer: i64 = 0x4B0;
            };
            pub const CMapVetoPickController = struct {
                pub const m_nMapId0: i64 = 0x6F8;
                pub const m_nMapId1: i64 = 0x7F8;
                pub const m_nMapId2: i64 = 0x8F8;
                pub const m_nMapId3: i64 = 0x9F8;
                pub const m_nMapId4: i64 = 0xAF8;
                pub const m_nMapId5: i64 = 0xBF8;
                pub const m_nDraftType: i64 = 0x4D4;
                pub const m_OnMapPicked: i64 = 0xE28;
                pub const m_OnMapVetoed: i64 = 0xE08;
                pub const m_nAccountIDs: i64 = 0x5F8;
                pub const m_OnSidesPicked: i64 = 0xE48;
                pub const m_nCurrentPhase: i64 = 0xDF8;
                pub const m_nStartingSide0: i64 = 0xCF8;
                pub const m_bPlayedIntroVcd: i64 = 0x4A8;
                pub const m_nPhaseStartTick: i64 = 0xDFC;
                pub const m_nVoteMapIdsList: i64 = 0x5DC;
                pub const m_OnLevelTransition: i64 = 0xE88;
                pub const m_OnNewPhaseStarted: i64 = 0xE68;
                pub const m_nPhaseDurationTicks: i64 = 0xE00;
                pub const m_nTeamWinningCoinToss: i64 = 0x4D8;
                pub const m_nTeamWithFirstChoice: i64 = 0x4DC;
                pub const m_bPreMatchDraftStateChanged: i64 = 0x4D0;
                pub const m_dblPreMatchDraftSequenceTime: i64 = 0x4C8;
                pub const m_bNeedToPlayFiveSecondsRemaining: i64 = 0x4A9;
            };
            pub const CMovementStatsProperty = struct {
                pub const m_nUseCounter: i64 = 0x10;
                pub const m_emaMovementDirection: i64 = 0x14;
            };
            pub const CMultiplayer_Expresser = struct {
                pub const m_bAllowMultipleScenes: i64 = 0xA0;
            };
            pub const CNavVolumeMarkupVolume = struct {

            };
            pub const CNetworkVelocityVector = struct {
                pub const m_vecX: i64 = 0x10;
                pub const m_vecY: i64 = 0x18;
                pub const m_vecZ: i64 = 0x20;
            };
            pub const CNmEventConsumerCamera = struct {

            };
            pub const CNmEventConsumerLegacy = struct {

            };
            pub const CPhysicsBodyGameMarkup = struct {
                pub const m_Tag: i64 = 0x8;
                pub const m_TargetBody: i64 = 0x0;
            };
            pub const CPlayer_CameraServices = struct {
                pub const m_audio: i64 = 0xB0;
                pub const m_PlayerFog: i64 = 0x60;
                pub const m_hViewEntity: i64 = 0xA4;
                pub const m_flOldPlayerZ: i64 = 0x140;
                pub const m_hTonemapController: i64 = 0xA8;
                pub const m_vecCsViewPunchAngle: i64 = 0x48;
                pub const m_hColorCorrectionCtrl: i64 = 0xA0;
                pub const m_PostProcessingVolumes: i64 = 0x128;
                pub const m_nCsViewPunchAngleTick: i64 = 0x54;
                pub const m_flOldPlayerViewOffsetZ: i64 = 0x144;
                pub const m_hTriggerSoundscapeList: i64 = 0x160;
                pub const m_flCsViewPunchAngleTickRatio: i64 = 0x58;
            };
            pub const CPlayer_WeaponServices = struct {
                pub const m_iAmmo: i64 = 0x68;
                pub const m_hMyWeapons: i64 = 0x48;
                pub const m_hLastWeapon: i64 = 0x64;
                pub const m_hActiveWeapon: i64 = 0x60;
                pub const m_bPreventWeaponPickup: i64 = 0xA8;
            };
            pub const CPointGamestatsCounter = struct {
                pub const m_bDisabled: i64 = 0x4B0;
                pub const m_strStatisticName: i64 = 0x4A8;
            };
            pub const CPulseCell_ApplyParent = struct {

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
            pub const CScriptTriggerMultiple = struct {
                pub const m_vExtent: i64 = 0x9E0;
            };
            pub const CServerOnlyModelEntity = struct {

            };
            pub const CServerOnlyPointEntity = struct {

            };
            pub const CSkyCameraVolumeTarget = struct {
                pub const m_hSkyMaterial: i64 = 0x4B0;
                pub const m_nSkyboxScale: i64 = 0x4A8;
            };
            pub const CSoundAreaEntitySphere = struct {
                pub const m_flRadius: i64 = 0x4C8;
            };
            pub const INavPathCostAreaFilter = struct {

            };
            pub const RelationshipOverride_t = struct {
                pub const entity: i64 = 0x8;
                pub const classType: i64 = 0xC;
            };
            pub const globalentitydatabase_t = struct {
                pub const m_list: i64 = 0x60;
            };
            pub const CAnimGraphControllerPtr = struct {
                pub const m_pController: i64 = 0x0;
            };
            pub const CBasePulseGraphInstance = struct {

            };
            pub const CCS2PawnGraphController = struct {
                pub const m_moveType: i64 = 0x5D8;
                pub const m_airAction: i64 = 0x740;
                pub const m_bIsWalking: i64 = 0x680;
                pub const m_flinchBody: i64 = 0x818;
                pub const m_flinchHead: i64 = 0x7E8;
                pub const m_bIsDefusing: i64 = 0x5C0;
                pub const m_flLadderYaw: i64 = 0x710;
                pub const m_flMoveSpeedX: i64 = 0x608;
                pub const m_flMoveSpeedY: i64 = 0x620;
                pub const m_groundAction: i64 = 0x6B0;
                pub const m_flAimYawAngle: i64 = 0x7D0;
                pub const m_flLadderCycle: i64 = 0x6F8;
                pub const m_flCrouchAmount: i64 = 0x668;
                pub const m_flinchIsOnFire: i64 = 0x848;
                pub const m_leftFootTarget: i64 = 0x770;
                pub const m_flAimPitchAngle: i64 = 0x7B8;
                pub const m_flFlashedAmount: i64 = 0x7A0;
                pub const m_moveDirectionID: i64 = 0x5F0;
                pub const m_rightFootTarget: i64 = 0x788;
                pub const m_flinchBodyRestart: i64 = 0x830;
                pub const m_flinchHeadRestart: i64 = 0x800;
                pub const m_flWeaponDropAmount: i64 = 0x698;
                pub const m_flLadderYawBackwards: i64 = 0x728;
                pub const m_flMoveSpeedHorizontal: i64 = 0x638;
                pub const m_flAirHeightAboveGround: i64 = 0x758;
                pub const m_groundActionDirectionID: i64 = 0x6C8;
                pub const m_flGroundTurnAngleOrVelocity: i64 = 0x6E0;
                pub const m_flPreviousMoveSpeedHorizontal: i64 = 0x650;
            };
            pub const CCSCustomHudLayoutState = struct {
                pub const m_playerSlot: i64 = 0x30;
                pub const m_vecHasClasses: i64 = 0x38;
                pub const m_bInputCaptureEnabled: i64 = 0x34;
                pub const m_vecDialogVariableStrings: i64 = 0x98;
            };
            pub const CCSObserver_UseServices = struct {

            };
            pub const CCSPlayerAnimationState = struct {
                pub const m_airAction: i64 = 0x1B;
                pub const m_actionStartTick: i64 = 0x20;
                pub const m_currentMoveType: i64 = 0x18;
                pub const m_groundMoveState: i64 = 0x19;
                pub const m_flPreviousAimYaw: i64 = 0x30;
                pub const m_flTurnOnSpotAngle: i64 = 0x2C;
                pub const m_flFootIKOffsetLeft: i64 = 0x38;
                pub const m_flFootIKOffsetRight: i64 = 0x3C;
                pub const m_groundActionDirection: i64 = 0x1A;
                pub const m_plantAndTurnStartTick: i64 = 0x28;
                pub const m_bWasOnGroundLastUpdate: i64 = 0x1C;
                pub const m_staticAimTimerStartTick: i64 = 0x24;
                pub const m_bWasStationaryLastUpdate: i64 = 0x1D;
                pub const m_flPreviousHorizontalSpeed: i64 = 0x34;
                pub const m_flWeaponDropSmoothDampVelocity: i64 = 0x44;
                pub const m_flWeaponDropPercentageDueToMovement: i64 = 0x40;
            };
            pub const CCSPlayer_RadioServices = struct {
                pub const m_bIgnoreRadio: i64 = 0x60;
                pub const m_flRadioTokenSlots: i64 = 0x54;
                pub const m_flC4PlantTalkTimer: i64 = 0x50;
                pub const m_flDefusingTalkTimer: i64 = 0x4C;
                pub const m_flGotHostageTalkTimer: i64 = 0x48;
            };
            pub const CCSPlayer_WaterServices = struct {
                pub const m_nDrownDmgRate: i64 = 0x4C;
                pub const m_AirFinishedTime: i64 = 0x50;
                pub const m_flSwimSoundTime: i64 = 0x64;
                pub const m_flWaterJumpTime: i64 = 0x54;
                pub const m_vecWaterJumpVel: i64 = 0x58;
                pub const m_NextDrownDamageTime: i64 = 0x48;
            };
            pub const CChoreo_GraphController = struct {
                pub const m_eChoreoState: i64 = 0xC0;
                pub const m_tChoreoExitWarp: i64 = 0xF0;
                pub const m_tChoreoTargetWarp: i64 = 0xD8;
            };
            pub const CCommentaryViewPosition = struct {

            };
            pub const CEnvVolumetricFogVolume = struct {
                pub const m_bActive: i64 = 0x4A8;
                pub const m_vBoxMaxs: i64 = 0x4B8;
                pub const m_vBoxMins: i64 = 0x4AC;
                pub const m_TintColor: i64 = 0x4E8;
                pub const m_flStrength: i64 = 0x4C8;
                pub const m_nFalloffShape: i64 = 0x4CC;
                pub const m_bStartDisabled: i64 = 0x4C4;
                pub const m_fNoiseStrength: i64 = 0x4E4;
                pub const m_bIndirectUseLPVs: i64 = 0x4C5;
                pub const m_flHeightFogDepth: i64 = 0x4D4;
                pub const m_fSunLightStrength: i64 = 0x4E0;
                pub const m_flFalloffExponent: i64 = 0x4D0;
                pub const m_bOverrideTintColor: i64 = 0x4EC;
                pub const m_fHeightFogEdgeWidth: i64 = 0x4D8;
                pub const m_bOverrideNoiseStrength: i64 = 0x4EF;
                pub const m_fIndirectLightStrength: i64 = 0x4DC;
                pub const m_bOverrideSunLightStrength: i64 = 0x4EE;
                pub const m_bOverrideIndirectLightStrength: i64 = 0x4ED;
            };
            pub const CInfoSpawnGroupLandmark = struct {

            };
            pub const CLightDirectionalEntity = struct {

            };
            pub const CLightEnvironmentEntity = struct {

            };
            pub const CLogicGameEventListener = struct {
                pub const m_bEnabled: i64 = 0x4E0;
                pub const m_OnEventFired: i64 = 0x4B8;
                pub const m_bStartDisabled: i64 = 0x4E1;
                pub const m_iszGameEventItem: i64 = 0x4D8;
                pub const m_iszGameEventName: i64 = 0x4D0;
            };
            pub const CMarkupVolumeTagged_Nav = struct {
                pub const m_nScopes: i64 = 0x890;
            };
            pub const CNmEventConsumerContact = struct {

            };
            pub const CPathMoverEntitySpawner = struct {
                pub const m_bEnabled: i64 = 0x52C;
                pub const m_nSpawnNum: i64 = 0x524;
                pub const m_hPathMover: i64 = 0x4F4;
                pub const m_nMaxActive: i64 = 0x520;
                pub const m_nSpawnIndex: i64 = 0x4F0;
                pub const m_vMoverSpawnPos: i64 = 0x59C;
                pub const m_flLastSpawnTime: i64 = 0x528;
                pub const m_iszPathMoverName: i64 = 0x578;
                pub const m_szSpawnTemplates: i64 = 0x4B0;
                pub const m_OnTemplateSpawned: i64 = 0x548;
                pub const m_vecQueuedRemovals: i64 = 0x530;
                pub const m_bRunningDebugThink: i64 = 0x5A8;
                pub const m_bPrepopulateOnSpawn: i64 = 0x580;
                pub const m_iszPathNodeStartName: i64 = 0x588;
                pub const m_szSpawnTemplateCount: i64 = 0x4E0;
                pub const m_szSpawnTemplateParams: i64 = 0x4D0;
                pub const m_OnTemplateGroupSpawned: i64 = 0x560;
                pub const m_eTemplateChoiceStrategy: i64 = 0x4A8;
                pub const m_flSpawnFrequencySeconds: i64 = 0x4F8;
                pub const m_mapSpawnedMoverTemplates: i64 = 0x500;
                pub const m_bDestroyMoverOnArrivedAtEnd: i64 = 0x52D;
                pub const m_flSpawnFrequencyDistToNearestMover: i64 = 0x4FC;
            };
            pub const CPhysicsPropMultiplayer = struct {

            };
            pub const CPhysicsPropRespawnable = struct {
                pub const m_vOriginalMaxs: i64 = 0xD34;
                pub const m_vOriginalMins: i64 = 0xD28;
                pub const m_flRespawnDuration: i64 = 0xD40;
                pub const m_vOriginalSpawnAngles: i64 = 0xD1C;
                pub const m_vOriginalSpawnOrigin: i64 = 0xD10;
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
            pub const CSmokeGrenadeProjectile = struct {
                pub const m_nRandomSeed: i64 = 0xB70;
                pub const m_vSmokeColor: i64 = 0xB74;
                pub const m_flLastBounce: i64 = 0xBB4;
                pub const m_nVoxelUpdate: i64 = 0xBAC;
                pub const m_VoxelFrameData: i64 = 0xB90;
                pub const m_bDidSmokeEffect: i64 = 0xB6C;
                pub const m_bDidGroundScorch: i64 = 0x2E41;
                pub const m_bExplodeFromInferno: i64 = 0x2E40;
                pub const m_nVoxelFrameDataSize: i64 = 0xBA8;
                pub const m_vSmokeDetonationPos: i64 = 0xB80;
                pub const m_fllastSimulationTime: i64 = 0xBB8;
                pub const m_nSmokeEffectTickBegin: i64 = 0xB68;
                pub const m_nSmokeLightProbeRegen: i64 = 0xBB0;
            };
            pub const CSoundEventSphereEntity = struct {
                pub const m_flRadius: i64 = 0x568;
            };
            pub const CSoundOpvarSetBoxEntity = struct {
                pub const m_vInnerMaxs: i64 = 0x680;
                pub const m_vInnerMins: i64 = 0x674;
                pub const m_vOuterMaxs: i64 = 0x698;
                pub const m_vOuterMins: i64 = 0x68C;
                pub const m_nBoxDirection: i64 = 0x670;
                pub const m_vDistanceInnerMaxs: i64 = 0x64C;
                pub const m_vDistanceInnerMins: i64 = 0x640;
                pub const m_vDistanceOuterMaxs: i64 = 0x664;
                pub const m_vDistanceOuterMins: i64 = 0x658;
            };
            pub const CSoundOpvarSetOBBEntity = struct {

            };
            pub const CSoundOpvarSetPointBase = struct {
                pub const m_hSource: i64 = 0x4AC;
                pub const m_bDisabled: i64 = 0x4A8;
                pub const m_iOpvarIndex: i64 = 0x548;
                pub const m_bFastRefresh: i64 = 0x54D;
                pub const m_iszOpvarName: i64 = 0x540;
                pub const m_iszStackName: i64 = 0x530;
                pub const m_flRefreshTime: i64 = 0x52C;
                pub const m_vLastPosition: i64 = 0x520;
                pub const m_bUseAutoCompare: i64 = 0x54C;
                pub const m_iszOperatorName: i64 = 0x538;
                pub const m_iszSourceEntityName: i64 = 0x4C8;
            };
            pub const CTextureBasedAnimatable = struct {
                pub const m_bLoop: i64 = 0x850;
                pub const m_flFPS: i64 = 0x854;
                pub const m_flStartTime: i64 = 0x880;
                pub const m_flStartFrame: i64 = 0x884;
                pub const m_hPositionKeys: i64 = 0x858;
                pub const m_hRotationKeys: i64 = 0x860;
                pub const m_vAnimationBoundsMax: i64 = 0x874;
                pub const m_vAnimationBoundsMin: i64 = 0x868;
            };
            pub const CTriggerDetectExplosion = struct {
                pub const m_OnDetectedExplosion: i64 = 0x9F0;
            };
            pub const EntityRenderAttribute_t = struct {
                pub const m_ID: i64 = 0x30;
                pub const m_Values: i64 = 0x34;
            };
            pub const RagdollCreationParams_t = struct {
                pub const m_vForce: i64 = 0x0;
                pub const m_nForceBone: i64 = 0xC;
                pub const m_nHealthToGrant: i64 = 0x14;
                pub const m_bForceCurrentWorldTransform: i64 = 0x10;
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
            pub const SoundOpvarTraceResult_t = struct {
                pub const vPos: i64 = 0x0;
                pub const bDidHit: i64 = 0xC;
                pub const flDistSqrToCenter: i64 = 0x10;
            };
            pub const SummaryTakeDamageInfo_t = struct {
                pub const info: i64 = 0x8;
                pub const result: i64 = 0x120;
                pub const hTarget: i64 = 0x180;
                pub const nSummarisedCount: i64 = 0x0;
            };
            pub const ViewAngleServerChange_t = struct {
                pub const nType: i64 = 0x30;
                pub const nIndex: i64 = 0x40;
                pub const qAngle: i64 = 0x34;
            };
            pub const WeaponPurchaseTracker_t = struct {
                pub const m_weaponPurchases: i64 = 0x8;
            };
            pub const ragdollhierarchyjoint_t = struct {
                pub const childIndex: i64 = 0x4;
                pub const parentIndex: i64 = 0x0;
            };
            pub const CAnimGraphControllerBase = struct {
                pub const m_hExternalGraph: i64 = 0x4C;
            };
            pub const CBaseAnimGraphController = struct {
                pub const m_hSequence: i64 = 0x5C;
                pub const m_nNotifyState: i64 = 0x78;
                pub const m_nAnimLoopMode: i64 = 0x68;
                pub const m_flPlaybackRate: i64 = 0x6C;
                pub const m_flSeqStartTime: i64 = 0x60;
                pub const m_primaryGraphId: i64 = 0x3C8;
                pub const m_flSeqFixedCycle: i64 = 0x64;
                pub const m_flSoundSyncTime: i64 = 0x54;
                pub const m_bSequenceFinished: i64 = 0x7C;
                pub const m_pGraphInstanceAG2: i64 = 0x408;
                pub const m_vecExternalGraphs: i64 = 0x628;
                pub const m_bLastUpdateSkipped: i64 = 0x7B;
                pub const m_nActiveIKChainMask: i64 = 0x58;
                pub const m_vecExternalClipIds: i64 = 0x3E8;
                pub const m_hGraphDefinitionAG2: i64 = 0x320;
                pub const m_nAnimationAlgorithm: i64 = 0x18;
                pub const m_nPrevAnimUpdateTick: i64 = 0x80;
                pub const m_vecExternalGraphIds: i64 = 0x3D0;
                pub const m_sAnimGraph2Identifier: i64 = 0x400;
                pub const m_vecSecondarySkeletons: i64 = 0x38;
                pub const m_nNextExternalGraphHandle: i64 = 0x1C;
                pub const m_bNetworkedSequenceChanged: i64 = 0x7A;
                pub const m_SerializePoseRecipeAG2Slots: i64 = 0x328;
                pub const m_vecSecondarySkeletonSlotIDs: i64 = 0x20;
                pub const m_SerializePoseRecipeAG2Dynamic: i64 = 0x390;
                pub const m_nSecondarySkeletonMasterCount: i64 = 0x50;
                pub const m_nServerGraphInstanceIteration: i64 = 0x3C0;
                pub const m_nSerializePoseRecipeVersionAG2: i64 = 0x3AC;
                pub const m_bNetworkedAnimationInputsChanged: i64 = 0x79;
                pub const m_nSerializePoseRecipeAG2ActiveSlot: i64 = 0x3A8;
                pub const m_nServerSerializationContextIteration: i64 = 0x3C4;
            };
            pub const CBaseCSGrenadeProjectile = struct {
                pub const m_nBounces: i64 = 0xAE8;
                pub const m_nItemIndex: i64 = 0xB0E;
                pub const m_flSpawnTime: i64 = 0xB08;
                pub const m_vecGrenadeSpin: i64 = 0xB20;
                pub const m_unOGSExtraFlags: i64 = 0xB0C;
                pub const m_bHasEverHitEnemy: i64 = 0xB3C;
                pub const m_vInitialPosition: i64 = 0xAD0;
                pub const m_vInitialVelocity: i64 = 0xADC;
                pub const m_bDetonationRecorded: i64 = 0xB0D;
                pub const m_nExplodeEffectIndex: i64 = 0xAF0;
                pub const m_nTicksAtZeroVelocity: i64 = 0xB38;
                pub const m_flLastBounceSoundTime: i64 = 0xB1C;
                pub const m_vecExplodeEffectOrigin: i64 = 0xAFC;
                pub const m_nExplodeEffectTickBegin: i64 = 0xAF8;
                pub const m_vecLastHitSurfaceNormal: i64 = 0xB2C;
                pub const m_vecOriginalSpawnLocation: i64 = 0xB10;
            };
            pub const CBtNodeConditionInactive = struct {
                pub const m_SensorInactivityTimer: i64 = 0x80;
                pub const m_flRoundStartThresholdSeconds: i64 = 0x78;
                pub const m_flSensorInactivityThresholdSeconds: i64 = 0x7C;
            };
            pub const CCSPlayer_BulletServices = struct {
                pub const m_totalHitsOnServer: i64 = 0x48;
            };
            pub const CCSPlayer_CameraServices = struct {

            };
            pub const CCSPlayer_WeaponServices = struct {
                pub const m_flNextAttack: i64 = 0xC0;
                pub const m_hSavedWeapon: i64 = 0xC4;
                pub const m_nTimeToMelee: i64 = 0xC8;
                pub const m_nTimeToPrimary: i64 = 0xD0;
                pub const m_bPickedUpWeapon: i64 = 0xDA;
                pub const m_nTimeToSecondary: i64 = 0xCC;
                pub const m_bIsBeingGivenItem: i64 = 0xD8;
                pub const m_networkAnimTiming: i64 = 0x1898;
                pub const m_bDisableAutoDeploy: i64 = 0xDB;
                pub const m_nTimeToSniperRifle: i64 = 0xD4;
                pub const m_bIsPickingUpItemWithUse: i64 = 0xD9;
                pub const m_bIsPickingUpGroundWeapon: i64 = 0xDC;
                pub const m_bBlockInspectUntilNextGraphUpdate: i64 = 0x18B0;
            };
            pub const CCitadelSoundOpvarSetOBB = struct {
                pub const m_iszOpvarName: i64 = 0x4B8;
                pub const m_iszStackName: i64 = 0x4A8;
                pub const m_nAABBDirection: i64 = 0x4F0;
                pub const m_iszOperatorName: i64 = 0x4B0;
                pub const m_vDistanceInnerMaxs: i64 = 0x4CC;
                pub const m_vDistanceInnerMins: i64 = 0x4C0;
                pub const m_vDistanceOuterMaxs: i64 = 0x4E4;
                pub const m_vDistanceOuterMins: i64 = 0x4D8;
            };
            pub const CConstantForceController = struct {
                pub const m_linear: i64 = 0xC;
                pub const m_angular: i64 = 0x18;
                pub const m_linearSave: i64 = 0x24;
                pub const m_angularSave: i64 = 0x30;
            };
            pub const CEntitySubclassVDataBase = struct {

            };
            pub const CGenericLogicPlayerProxy = struct {

            };
            pub const CInfoTeleportDestination = struct {

            };
            pub const CNavVolumeSphericalShell = struct {
                pub const m_flRadiusInner: i64 = 0x88;
            };
            pub const CNetworkViewOffsetVector = struct {
                pub const m_vecX: i64 = 0x10;
                pub const m_vecY: i64 = 0x18;
                pub const m_vecZ: i64 = 0x20;
            };
            pub const CNmEventConsumerParticle = struct {

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
            };
            pub const CPointClientUIWorldPanel = struct {
                pub const m_bLit: i64 = 0x9B1;
                pub const m_flDPI: i64 = 0x9BC;
                pub const m_bOpaque: i64 = 0x9F8;
                pub const m_flWidth: i64 = 0x9B4;
                pub const m_bNoDepth: i64 = 0x9F9;
                pub const m_flHeight: i64 = 0x9B8;
                pub const m_bGrabbable: i64 = 0x9FE;
                pub const m_bIgnoreInput: i64 = 0x9B0;
                pub const m_flDepthOffset: i64 = 0x9C8;
                pub const m_unOrientation: i64 = 0x9D8;
                pub const m_vecCSSClasses: i64 = 0x9E0;
                pub const m_bDisableMipGen: i64 = 0xA00;
                pub const m_unOwnerContext: i64 = 0x9CC;
                pub const m_bRenderBackface: i64 = 0x9FB;
                pub const m_flWindowUIScale: i64 = 0x9C0;
                pub const m_unVerticalAlign: i64 = 0x9D4;
                pub const m_unHorizontalAlign: i64 = 0x9D0;
                pub const m_flInteractDistance: i64 = 0x9C4;
                pub const m_bOnlyRenderToTexture: i64 = 0x9FF;
                pub const m_nExplicitImageLayout: i64 = 0xA04;
                pub const m_bExcludeFromSaveGames: i64 = 0x9FD;
                pub const m_bUseOffScreenIndicator: i64 = 0x9FC;
                pub const m_bIgnoreParentOrientation: i64 = 0xA08;
                pub const m_bVisibleWhenParentNoDraw: i64 = 0x9FA;
                pub const m_bFollowPlayerAcrossTeleport: i64 = 0x9B2;
                pub const m_bAllowInteractionFromAllSceneWorlds: i64 = 0x9DC;
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
            pub const CSAdditionalMatchStats_t = struct {
                pub const m_flTeamDamage: i64 = 0x13C;
                pub const m_iNumSuicides: i64 = 0x134;
                pub const m_iNumTeamKills: i64 = 0x138;
                pub const m_numFirstKills: i64 = 0x124;
                pub const m_numClutchKills: i64 = 0x128;
                pub const m_numPistolKills: i64 = 0x12C;
                pub const m_numSniperKills: i64 = 0x130;
                pub const m_numRoundsSurvivedTotal: i64 = 0x118;
                pub const m_numRoundsSurvivedStreak: i64 = 0x110;
                pub const m_iRoundsWonWithoutPurchase: i64 = 0x11C;
                pub const m_maxNumRoundsSurvivedStreak: i64 = 0x114;
                pub const m_iRoundsWonWithoutPurchaseTotal: i64 = 0x120;
            };
            pub const CSoundOpvarSetAABBEntity = struct {

            };
            pub const CSoundOpvarSetDomeEntity = struct {
                pub const m_flSize: i64 = 0x734;
                pub const m_bDomeMode: i64 = 0x740;
                pub const m_nClusterK: i64 = 0x748;
                pub const m_arOpenness: i64 = 0x658;
                pub const m_bMultiWall: i64 = 0x741;
                pub const m_flClusterP: i64 = 0x74C;
                pub const m_arNeighbors: i64 = 0x670;
                pub const m_arDirections: i64 = 0x640;
                pub const m_arClusterSize: i64 = 0x6A8;
                pub const m_nClusterIndex: i64 = 0x6F0;
                pub const m_nCurrentIndex: i64 = 0x688;
                pub const m_flClusterBlend: i64 = 0x750;
                pub const m_arClusterDirSum: i64 = 0x6D8;
                pub const m_arClusterParent: i64 = 0x690;
                pub const m_arClusterWeight: i64 = 0x6C0;
                pub const m_nTracesPerFrame: i64 = 0x73C;
                pub const m_flLastSmoothTime: i64 = 0x730;
                pub const m_flSmoothHalfLife: i64 = 0x75C;
                pub const m_nTotalDirections: i64 = 0x738;
                pub const m_vLastTraceOrigin: i64 = 0x714;
                pub const m_vSmoothedOpenDir: i64 = 0x704;
                pub const m_bTraceOriginValid: i64 = 0x720;
                pub const m_vClusterDirection: i64 = 0x6F8;
                pub const m_flOpennessExponent: i64 = 0x754;
                pub const m_flShoulderExponent: i64 = 0x758;
                pub const m_flSmoothedOpenness: i64 = 0x72C;
                pub const m_flWallTransmission: i64 = 0x744;
                pub const m_flClusteredOpenness: i64 = 0x6F4;
                pub const m_bDiscontinuityPending: i64 = 0x728;
                pub const m_nCatchUpThinksRemaining: i64 = 0x724;
                pub const m_nDirWarmupThinksRemaining: i64 = 0x710;
            };
            pub const CTouchExpansionComponent = struct {

            };
            pub const CTriggerDetectBulletFire = struct {
                pub const m_bPlayerFireOnly: i64 = 0x9C8;
                pub const m_OnDetectedBulletFire: i64 = 0x9D0;
            };
            pub const CAI_ExpresserWithFollowup = struct {

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
            pub const CFuncInteractionLayerClip = struct {
                pub const m_bDisabled: i64 = 0x850;
                pub const m_iszInteractsAs: i64 = 0x858;
                pub const m_iszInteractsWith: i64 = 0x860;
            };
            pub const CInfoChoreoAnchorPosition = struct {
                pub const m_hParent: i64 = 0x40;
                pub const m_flRadius: i64 = 0x38;
                pub const m_qAnglesLS: i64 = 0x10;
                pub const m_vOriginLS: i64 = 0x0;
                pub const m_nShapeType: i64 = 0x44;
                pub const m_vExtentsMax: i64 = 0x2C;
                pub const m_vExtentsMin: i64 = 0x20;
                pub const m_bOnlyWarpPosition: i64 = 0x3C;
            };
            pub const CInfoDynamicShadowHintBox = struct {
                pub const m_vBoxMaxs: i64 = 0x4CC;
                pub const m_vBoxMins: i64 = 0x4C0;
            };
            pub const CInfoInstructorHintTarget = struct {

            };
            pub const CInfoSpawnGroupLoadUnload = struct {
                pub const m_bAutoActivate: i64 = 0x52C;
                pub const m_iszLandmarkName: i64 = 0x518;
                pub const m_bUnloadingStarted: i64 = 0x52D;
                pub const m_flTimeoutInterval: i64 = 0x528;
                pub const m_iszSpawnGroupName: i64 = 0x508;
                pub const m_bQueueFinishLoading: i64 = 0x52F;
                pub const m_sFixedSpawnGroupName: i64 = 0x520;
                pub const m_OnSpawnGroupLoadStarted: i64 = 0x4A8;
                pub const m_iszSpawnGroupFilterName: i64 = 0x510;
                pub const m_OnSpawnGroupLoadFinished: i64 = 0x4C0;
                pub const m_OnSpawnGroupUnloadStarted: i64 = 0x4D8;
                pub const m_OnSpawnGroupUnloadFinished: i64 = 0x4F0;
                pub const m_bQueueActiveSpawnGroupChange: i64 = 0x52E;
            };
            pub const CItemGenericTriggerHelper = struct {
                pub const m_hParentItem: i64 = 0x850;
            };
            pub const CNetworkTransmitComponent = struct {
                pub const m_nTransmitStateOwnedCounter: i64 = 0x184;
            };
            pub const CNmAimCSNode__CDefinition = struct {
                pub const m_nIsDefusingNodeIdx: i64 = 0x24;
                pub const m_nWeaponDropNodeIdx: i64 = 0x22;
                pub const m_nWeaponTypeNodeIdx: i64 = 0x1E;
                pub const m_nCrouchWeightNodeIdx: i64 = 0x26;
                pub const m_nWeaponActionNodeIdx: i64 = 0x20;
                pub const m_nVerticalAngleNodeIdx: i64 = 0x18;
                pub const m_nWeaponCategoryNodeIdx: i64 = 0x1C;
                pub const m_nHorizontalAngleNodeIdx: i64 = 0x1A;
                pub const m_flActionBlendTimeSeconds: i64 = 0x2C;
                pub const m_flHandIKBlendInTimeSeconds: i64 = 0x28;
                pub const m_flPlantingBlendTimeSeconds: i64 = 0x30;
            };
            pub const CNmEventConsumerBodyGroup = struct {

            };
            pub const CPulseCell_Value_Gradient = struct {
                pub const m_Gradient: i64 = 0x48;
            };
            pub const CShatterGlassShardPhysics = struct {
                pub const m_ShardDesc: i64 = 0x858;
                pub const m_nPoolState: i64 = 0x8D8;
                pub const m_hParentShard: i64 = 0x850;
                pub const m_bTouchedByPlayer: i64 = 0x8DC;
            };
            pub const CSimpleMarkupVolumeTagged = struct {

            };
            pub const CSoundOpvarSetPointEntity = struct {
                pub const m_OnExit: i64 = 0x568;
                pub const m_OnEnter: i64 = 0x550;
                pub const m_bReloading: i64 = 0x5E5;
                pub const m_bAutoDisable: i64 = 0x580;
                pub const m_flDistanceMax: i64 = 0x5C8;
                pub const m_flDistanceMin: i64 = 0x5C4;
                pub const m_flOcclusionMax: i64 = 0x5DC;
                pub const m_flOcclusionMin: i64 = 0x5D8;
                pub const m_hDynamicEntity: i64 = 0x600;
                pub const m_nSimulationMode: i64 = 0x5E8;
                pub const m_flDistanceMapMax: i64 = 0x5D0;
                pub const m_flDistanceMapMin: i64 = 0x5CC;
                pub const m_flOcclusionRadius: i64 = 0x5D4;
                pub const m_flValSetOnDisable: i64 = 0x5E0;
                pub const m_vPathingDirection: i64 = 0x62C;
                pub const m_vPathingSourcePos: i64 = 0x614;
                pub const m_bSetValueOnDisable: i64 = 0x5E4;
                pub const m_nVisibilitySamples: i64 = 0x5EC;
                pub const m_vDynamicProxyPoint: i64 = 0x5F0;
                pub const m_nPathingSourceIndex: i64 = 0x638;
                pub const m_vPathingListenerPos: i64 = 0x620;
                pub const m_iszDynamicEntityName: i64 = 0x608;
                pub const m_flDynamicMaximumOcclusion: i64 = 0x5FC;
                pub const m_flPathingDistanceNormFactor: i64 = 0x610;
            };
            pub const DebugDrawBoneTransforms_t = struct {
                pub const vecBones: i64 = 0x10;
            };
            pub const ExternalAnimGraphHandle_t = struct {
                pub const m_Value: i64 = 0x0;
            };
            pub const OutflowWithRequirements_t = struct {
                pub const m_Connection: i64 = 0x0;
                pub const m_RequirementNodeIDs: i64 = 0x50;
                pub const m_DestinationFlowNodeID: i64 = 0x48;
                pub const m_nCursorStateBlockIndex: i64 = 0x68;
            };
            pub const SignatureOutflow_Continue = struct {

            };
            pub const WaterWheelFrictionScale_t = struct {
                pub const m_flFrictionScale: i64 = 0x4;
                pub const m_flFractionOfWheelSubmerged: i64 = 0x0;
            };
            pub const CBtActionCombatPositioning = struct {
                pub const m_bCrouching: i64 = 0xA0;
                pub const m_ActionTimer: i64 = 0x88;
                pub const m_szIsAttackingKey: i64 = 0x80;
                pub const m_szSensorInputKey: i64 = 0x68;
            };
            pub const CCS2ChickenGraphController = struct {
                pub const m_mode: i64 = 0x128;
                pub const m_action: i64 = 0xC0;
                pub const m_bFlinch: i64 = 0x1B8;
                pub const m_bInWater: i64 = 0x110;
                pub const m_idlePhase: i64 = 0x158;
                pub const m_lifeStage: i64 = 0x140;
                pub const m_turnAngle: i64 = 0x170;
                pub const m_bActionReset: i64 = 0xD8;
                pub const m_lookatTarget: i64 = 0x1A0;
                pub const m_actionVariation: i64 = 0xF8;
                pub const m_flinchVariation: i64 = 0x1D0;
                pub const m_bHasLookatTarget: i64 = 0x188;
                pub const m_bHasActionCompletedEvent: i64 = 0x1E8;
            };
            pub const CCSObserver_CameraServices = struct {

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
                pub const m_flStamina: i64 = 0x69C;
                pub const m_LegacyJump: i64 = 0x6B8;
                pub const m_ModernJump: i64 = 0x6D0;
                pub const m_iFootsteps: i64 = 0x688;
                pub const m_vecForward: i64 = 0x65C;
                pub const m_flDuckSpeed: i64 = 0x410;
                pub const m_nTraceCount: i64 = 0x648;
                pub const m_bDesiresDuck: i64 = 0x415;
                pub const m_bInStuckTest: i64 = 0x43A;
                pub const m_flDuckAmount: i64 = 0x40C;
                pub const m_bDuckOverride: i64 = 0x414;
                pub const m_bSpeedCropped: i64 = 0x650;
                pub const m_nLastJumpTick: i64 = 0x708;
                pub const m_AnimationState: i64 = 0x310;
                pub const m_flLastDuckTime: i64 = 0x420;
                pub const m_flLastJumpFrac: i64 = 0x70C;
                pub const m_nOldWaterLevel: i64 = 0x654;
                pub const m_vecWalkWishVel: i64 = 0x7A8;
                pub const m_vecLadderNormal: i64 = 0x3F8;
                pub const m_bJumpApexPending: i64 = 0x714;
                pub const m_flDuckRootOffset: i64 = 0x418;
                pub const m_flDuckViewOffset: i64 = 0x41C;
                pub const m_flWaterEntryTime: i64 = 0x658;
                pub const m_duckUntilOnGround: i64 = 0x438;
                pub const m_bMadeFootstepNoise: i64 = 0x684;
                pub const m_flHeightAtJumpStart: i64 = 0x6A0;
                pub const m_flLastJumpVelocityZ: i64 = 0x710;
                pub const m_flVelMulAtJumpStart: i64 = 0x6B0;
                pub const m_flStaminaAtJumpStart: i64 = 0x6AC;
                pub const m_flBombPlantViewOffset: i64 = 0x424;
                pub const m_flAccumulatedJumpError: i64 = 0x6B4;
                pub const m_flFrictionStashedSpeed: i64 = 0x698;
                pub const m_flMaxJumpHeightLastJump: i64 = 0x6A8;
                pub const m_flMaxJumpHeightThisJump: i64 = 0x6A4;
                pub const m_nLadderSurfacePropIndex: i64 = 0x404;
                pub const m_bHasEverProcessedCommand: i64 = 0xFD0;
                pub const m_bUseFrictionStashedSpeed: i64 = 0x690;
                pub const m_bHasWalkMovedSinceLastJump: i64 = 0x439;
                pub const m_bUsingGroundTopologyOffset: i64 = 0x3F0;
                pub const m_fStashGrenadeParameterWhen: i64 = 0x68C;
                pub const m_flTicksSinceLastSurfingDetected: i64 = 0x718;
                pub const m_vecLastPositionAtFullCrouchSpeed: i64 = 0x430;
                pub const m_flUseFrictionStashedSpeedUntilFrac: i64 = 0x694;
                pub const m_nGameCodeHasMovedPlayerAfterCommand: i64 = 0x680;
                pub const m_flUsingGroundTopologyOffsetTransitionSmoothing: i64 = 0x3F4;
            };
            pub const CNavVolumeCalculatedVector = struct {

            };
            pub const CNmEventConsumerAttributes = struct {

            };
            pub const CPhysicsBodyGameMarkupData = struct {
                pub const m_PhysicsBodyMarkupByBoneName: i64 = 0x0;
            };
            pub const CPlayerControllerComponent = struct {
                pub const __m_pChainEntity: i64 = 0x8;
            };
            pub const CPlayer_FlashlightServices = struct {

            };
            pub const CPropDoorRotatingBreakable = struct {
                pub const m_bBreakable: i64 = 0xF30;
                pub const m_damageStates: i64 = 0xF38;
                pub const m_currentDamageState: i64 = 0xF34;
                pub const m_isAbleToCloseAreaPortals: i64 = 0xF31;
            };
            pub const CPulseCell_BaseRequirement = struct {

            };
            pub const CPulseCell_Outflow_PlayVCD = struct {
                pub const m_OnPaused: i64 = 0x140;
                pub const m_OnResumed: i64 = 0x188;
                pub const m_hChoreoScene: i64 = 0x138;
                pub const m_OutRequirements: i64 = 0x1D0;
            };
            pub const CPulseCell_SoundEventStart = struct {
                pub const m_Type: i64 = 0x48;
            };
            pub const CPulseCell_Value_RandomInt = struct {

            };
            pub const CPulse_BlackboardReference = struct {
                pub const m_nNodeID: i64 = 0x18;
                pub const m_NodeName: i64 = 0x20;
                pub const m_BlackboardResource: i64 = 0x8;
                pub const m_hBlackboardResource: i64 = 0x0;
            };
            pub const CScriptUniformRandomStream = struct {
                pub const m_hScriptScope: i64 = 0x8;
                pub const m_nInitialSeed: i64 = 0x9C;
            };
            pub const CTriggerActiveWeaponDetect = struct {
                pub const m_iszWeaponClassName: i64 = 0x9E0;
                pub const m_OnTouchedActiveWeapon: i64 = 0x9C8;
            };
            pub const FuncMoverMovementSummary_t = struct {
                pub const nTick: i64 = 0x18;
                pub const flEndT: i64 = 0x4;
                pub const nFlags: i64 = 0x14;
                pub const flStartT: i64 = 0x0;
                pub const hPathMover: i64 = 0x1C;
                pub const nMovementMode: i64 = 0x10;
                pub const nStopNodeIndex: i64 = 0xC;
                pub const nStartNodeIndex: i64 = 0x8;
            };
            pub const PulseNodeDynamicOutflows_t = struct {
                pub const m_Outflows: i64 = 0x0;
            };
            pub const PulseSelectorOutflowList_t = struct {
                pub const m_Outflows: i64 = 0x0;
            };
            pub const CAnimGraphControllerManager = struct {
                pub const m_controllers: i64 = 0x0;
                pub const m_bGraphBindingsCreated: i64 = 0x90;
            };
            pub const CBodyComponentBaseAnimGraph = struct {
                pub const m_animationController: i64 = 0x4E0;
            };
            pub const CCSGO_EndOfMatchLineupStart = struct {

            };
            pub const CCSGameModeRules_Deathmatch = struct {
                pub const m_sDMBonusWeapon: i64 = 0x38;
                pub const m_flDMBonusStartTime: i64 = 0x30;
                pub const m_flDMBonusTimeLength: i64 = 0x34;
            };
            pub const CDestructiblePartsComponent = struct {
                pub const m_hOwner: i64 = 0x60;
                pub const __m_pChainEntity: i64 = 0x0;
                pub const m_vecDamageTakenByHitGroup: i64 = 0x48;
                pub const m_pAnimGraphDestructibleGraphController: i64 = 0x68;
            };
            pub const CDynamicPropGraphController = struct {
                pub const m_sActionState: i64 = 0xC0;
            };
            pub const CEnvVolumetricFogController = struct {
                pub const m_bActive: i64 = 0x4F4;
                pub const m_vBoxMaxs: i64 = 0x4E8;
                pub const m_vBoxMins: i64 = 0x4DC;
                pub const m_TintColor: i64 = 0x4AC;
                pub const m_bIsMaster: i64 = 0x51E;
                pub const m_bFirstTime: i64 = 0x550;
                pub const m_fWindSpeed: i64 = 0x540;
                pub const m_fNoiseSpeed: i64 = 0x52C;
                pub const m_flFadeInEnd: i64 = 0x4C0;
                pub const m_flFadeSpeed: i64 = 0x4B4;
                pub const m_vNoiseScale: i64 = 0x534;
                pub const m_flAnisotropy: i64 = 0x4B0;
                pub const m_flScattering: i64 = 0x4A8;
                pub const m_nVolumeDepth: i64 = 0x4C8;
                pub const m_flFadeInStart: i64 = 0x4BC;
                pub const m_bStartDisabled: i64 = 0x51C;
                pub const m_fNoiseStrength: i64 = 0x530;
                pub const m_flDrawDistance: i64 = 0x4B8;
                pub const m_vWindDirection: i64 = 0x544;
                pub const m_bEnableIndirect: i64 = 0x51D;
                pub const m_flStartAnisoTime: i64 = 0x4F8;
                pub const m_flStartAnisotropy: i64 = 0x504;
                pub const m_flStartScattering: i64 = 0x508;
                pub const m_flIndirectStrength: i64 = 0x4C4;
                pub const m_flStartScatterTime: i64 = 0x4FC;
                pub const m_nForceRefreshCount: i64 = 0x528;
                pub const m_flDefaultAnisotropy: i64 = 0x510;
                pub const m_flDefaultScattering: i64 = 0x514;
                pub const m_flStartDrawDistance: i64 = 0x50C;
                pub const m_hFogIndirectTexture: i64 = 0x520;
                pub const m_nIndirectTextureDimX: i64 = 0x4D0;
                pub const m_nIndirectTextureDimY: i64 = 0x4D4;
                pub const m_nIndirectTextureDimZ: i64 = 0x4D8;
                pub const m_flDefaultDrawDistance: i64 = 0x518;
                pub const m_flStartDrawDistanceTime: i64 = 0x500;
                pub const m_fFirstVolumeSliceThickness: i64 = 0x4CC;
            };
            pub const CInfoPlayerCounterterrorist = struct {

            };
            pub const CMarkupVolumeTagged_NavGame = struct {
                pub const m_nScopes: i64 = 0x8B8;
                pub const m_bSplitNavSpace: i64 = 0x8BA;
                pub const m_bFloodFillAttribute: i64 = 0x8B9;
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
            pub const CPointAngularVelocitySensor = struct {
                pub const m_vecAxis: i64 = 0x4D0;
                pub const m_OnEqualTo: i64 = 0x560;
                pub const m_OnLessThan: i64 = 0x500;
                pub const m_bUseHelper: i64 = 0x4DC;
                pub const m_flFireTime: i64 = 0x4B8;
                pub const m_flThreshold: i64 = 0x4AC;
                pub const m_OnGreaterThan: i64 = 0x530;
                pub const m_hTargetEntity: i64 = 0x4A8;
                pub const m_flFireInterval: i64 = 0x4BC;
                pub const m_AngularVelocity: i64 = 0x4E0;
                pub const m_lastOrientation: i64 = 0x4C4;
                pub const m_nLastFireResult: i64 = 0x4B4;
                pub const m_flLastAngVelocity: i64 = 0x4C0;
                pub const m_nLastCompareResult: i64 = 0x4B0;
                pub const m_OnLessThanOrEqualTo: i64 = 0x518;
                pub const m_OnGreaterThanOrEqualTo: i64 = 0x548;
            };
            pub const CPulseCell_ApplyEntityFlags = struct {

            };
            pub const CPulseCell_Inflow_GraphHook = struct {
                pub const m_HookName: i64 = 0x80;
            };
            pub const CSAdditionalPerRoundStats_t = struct {
                pub const m_iDinks: i64 = 0x14;
                pub const m_nDefuseStarts: i64 = 0x1C;
                pub const m_killsWhileBlind: i64 = 0x4;
                pub const m_nHostagePickUps: i64 = 0x20;
                pub const m_bombCarrierkills: i64 = 0x8;
                pub const m_numChickensKilled: i64 = 0x0;
                pub const m_numTeammatesFlashed: i64 = 0x24;
                pub const m_bBombPlantedAndAlive: i64 = 0x19;
                pub const m_bFreshStartThisRound: i64 = 0x18;
                pub const m_flBurnDamageInflicted: i64 = 0xC;
                pub const m_flBlastDamageInflicted: i64 = 0x10;
                pub const m_strAnnotationsWorkshopId: i64 = 0x28;
            };
            pub const CSoundAreaEntityOrientedBox = struct {
                pub const m_vMax: i64 = 0x4D4;
                pub const m_vMin: i64 = 0x4C8;
            };
            pub const CSoundEventMultiPointEntity = struct {
                pub const m_bPlaying: i64 = 0x578;
                pub const m_iCountMax: i64 = 0x568;
                pub const m_flDistMaxSqr: i64 = 0x570;
                pub const m_flDistanceMax: i64 = 0x56C;
                pub const m_flDotProductMax: i64 = 0x574;
            };
            pub const CSoundEventPathCornerEntity = struct {
                pub const m_iszPathCorner: i64 = 0x5A0;
                pub const m_vecCornerPairsNetworked: i64 = 0x5C0;
            };
            pub const CSoundOpvarSetOBBWindEntity = struct {
                pub const m_vMaxs: i64 = 0x55C;
                pub const m_vMins: i64 = 0x550;
                pub const m_flWindMax: i64 = 0x584;
                pub const m_flWindMin: i64 = 0x580;
                pub const m_flWindMapMax: i64 = 0x58C;
                pub const m_flWindMapMin: i64 = 0x588;
                pub const m_vDistanceMaxs: i64 = 0x574;
                pub const m_vDistanceMins: i64 = 0x568;
            };
            pub const PulseScriptedSequenceData_t = struct {
                pub const m_nMoveTo: i64 = 0x28;
                pub const m_nActorID: i64 = 0x0;
                pub const m_szSequence: i64 = 0x18;
                pub const m_nMoveToGait: i64 = 0x2C;
                pub const m_bIgnoreLookAt: i64 = 0x37;
                pub const m_szExitSequence: i64 = 0x20;
                pub const m_szEntrySequence: i64 = 0x10;
                pub const m_szPreIdleSequence: i64 = 0x8;
                pub const m_bLoopActionSequence: i64 = 0x35;
                pub const m_nHeldWeaponBehavior: i64 = 0x30;
                pub const m_bLoopPreIdleSequence: i64 = 0x34;
                pub const m_bLoopPostIdleSequence: i64 = 0x36;
            };
            pub const CCSObserver_MovementServices = struct {

            };
            pub const CCSObserver_ObserverServices = struct {

            };
            pub const CCSPlayerBase_CameraServices = struct {
                pub const m_iFOV: i64 = 0x178;
                pub const m_flFOVRate: i64 = 0x184;
                pub const m_flFOVTime: i64 = 0x180;
                pub const m_iFOVStart: i64 = 0x17C;
                pub const m_hZoomOwner: i64 = 0x188;
                pub const m_hLastFogTrigger: i64 = 0x1A8;
                pub const m_hTriggerFogList: i64 = 0x190;
            };
            pub const CDestructiblePartsSystemData = struct {
                pub const m_PartsDataByHitGroup: i64 = 0x0;
                pub const m_nMinMaxNumberHitGroupsToDestroyWhenGibbing: i64 = 0x28;
            };
            pub const CDynamicNavConnectionsVolume = struct {
                pub const m_vecConnections: i64 = 0x9E8;
                pub const m_sTransitionType: i64 = 0xA00;
                pub const m_flUpdateDistance: i64 = 0xA10;
                pub const m_bConnectionsEnabled: i64 = 0xA08;
                pub const m_iszConnectionTarget: i64 = 0x9E0;
                pub const m_flMaxConnectionDistance: i64 = 0xA14;
                pub const m_flTargetAreaSearchRadius: i64 = 0xA0C;
            };
            pub const CEnvCombinedLightProbeVolume = struct {
                pub const m_Entity_Color: i64 = 0x5C0;
                pub const m_Entity_bEnabled: i64 = 0x679;
                pub const m_Entity_vBoxMaxs: i64 = 0x61C;
                pub const m_Entity_vBoxMins: i64 = 0x610;
                pub const m_Entity_bMoveable: i64 = 0x628;
                pub const m_Entity_nPriority: i64 = 0x634;
                pub const m_Entity_nHandshake: i64 = 0x62C;
                pub const m_Entity_flBrightness: i64 = 0x5C4;
                pub const m_Entity_bStartDisabled: i64 = 0x638;
                pub const m_Entity_flEdgeFadeDist: i64 = 0x63C;
                pub const m_Entity_vEdgeFadeDists: i64 = 0x640;
                pub const m_Entity_hCubemapTexture: i64 = 0x5C8;
                pub const m_Entity_nLightProbeSizeX: i64 = 0x64C;
                pub const m_Entity_nLightProbeSizeY: i64 = 0x650;
                pub const m_Entity_nLightProbeSizeZ: i64 = 0x654;
                pub const m_Entity_nLightProbeAtlasX: i64 = 0x658;
                pub const m_Entity_nLightProbeAtlasY: i64 = 0x65C;
                pub const m_Entity_nLightProbeAtlasZ: i64 = 0x660;
                pub const m_Entity_bCustomCubemapTexture: i64 = 0x5D0;
                pub const m_Entity_nEnvCubeMapArrayIndex: i64 = 0x630;
                pub const m_Entity_hLightProbeTexture_SDF: i64 = 0x5E0;
                pub const m_Entity_hLightProbeTexture_SH2_DC: i64 = 0x5E8;
                pub const m_Entity_hLightProbeTexture_SH2_L1: i64 = 0x5F0;
                pub const m_Entity_hLightProbeTexture_AmbientCube: i64 = 0x5D8;
                pub const m_Entity_hLightProbeDirectLightIndicesTexture: i64 = 0x5F8;
                pub const m_Entity_hLightProbeDirectLightScalarsTexture: i64 = 0x600;
                pub const m_Entity_hLightProbeDirectLightShadowsTexture: i64 = 0x608;
            };
            pub const CNavVolumeBreadthFirstSearch = struct {
                pub const m_vStartPos: i64 = 0xA8;
                pub const m_flSearchDist: i64 = 0xB4;
            };
            pub const CPointBroadcastClientCommand = struct {

            };
            pub const CPointClientUIWorldTextPanel = struct {
                pub const m_messageText: i64 = 0xA10;
            };
            pub const CPulseCell_Step_FollowEntity = struct {
                pub const m_ParamBoneOrAttachName: i64 = 0x48;
                pub const m_ParamBoneOrAttachNameChild: i64 = 0x50;
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
            pub const CRopeKeyframeAlias_move_rope = struct {

            };
            pub const CSkeletonAnimationController = struct {
                pub const m_pSkeletonInstance: i64 = 0x8;
            };
            pub const CSoundOpvarSetAutoRoomEntity = struct {
                pub const m_flSize: i64 = 0x670;
                pub const m_flSizeSqr: i64 = 0x678;
                pub const m_doorwayPairs: i64 = 0x658;
                pub const m_traceResults: i64 = 0x640;
                pub const m_flHeightTolerance: i64 = 0x674;
            };
            pub const CTakeDamageSummaryScopeGuard = struct {
                pub const m_vecSummaries: i64 = 0x8;
            };
            pub const FuncRotatorRotationSummary_t = struct {
                pub const nTick: i64 = 0x0;
                pub const nFlags: i64 = 0x4;
            };
            pub const ISkeletonAnimationController = struct {

            };
            pub const SimpleConstraintSoundProfile = struct {
                pub const m_flKeyPointMaxSoundThreshold: i64 = 0xC;
                pub const m_flKeyPointMinSoundThreshold: i64 = 0x8;
                pub const m_reversalSoundThresholdLarge: i64 = 0x18;
                pub const m_reversalSoundThresholdSmall: i64 = 0x10;
                pub const m_reversalSoundThresholdMedium: i64 = 0x14;
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
            pub const CBtActionParachutePositioning = struct {
                pub const m_ActionTimer: i64 = 0x58;
            };
            pub const CCSPlayer_DamageReactServices = struct {

            };
            pub const CDestructiblePart_DamageLevel = struct {
                pub const m_sName: i64 = 0x0;
                pub const m_nHealth: i64 = 0x14;
                pub const m_nBodyGroupValue: i64 = 0x10;
                pub const m_flDeathDestroyTime: i64 = 0x3C;
                pub const m_sBreakablePieceName: i64 = 0x8;
                pub const m_bShouldDestroyOnDeath: i64 = 0x38;
                pub const m_sCustomDeathHandshake: i64 = 0x30;
                pub const m_nDamagePassthroughType: i64 = 0x28;
                pub const m_flCriticalDamagePercent: i64 = 0x24;
                pub const m_nDestructionDeathBehavior: i64 = 0x2C;
            };
            pub const CInfoOffscreenPanoramaTexture = struct {
                pub const m_bDisabled: i64 = 0x4A8;
                pub const m_szPanelType: i64 = 0x4B8;
                pub const m_nResolutionX: i64 = 0x4AC;
                pub const m_nResolutionY: i64 = 0x4B0;
                pub const m_bEnableMipGen: i64 = 0x4A9;
                pub const m_szTargetsName: i64 = 0x508;
                pub const m_vecCSSClasses: i64 = 0x4F0;
                pub const m_RenderAttrName: i64 = 0x4C8;
                pub const m_TargetEntities: i64 = 0x4D0;
                pub const m_szLayoutFileName: i64 = 0x4C0;
                pub const m_nTargetChangeCount: i64 = 0x4E8;
                pub const m_AdditionalTargetEntities: i64 = 0x510;
            };
            pub const CNetworkOriginQuantizedVector = struct {
                pub const m_vecX: i64 = 0x10;
                pub const m_vecY: i64 = 0x18;
                pub const m_vecZ: i64 = 0x20;
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
            pub const CPulseCell_Outflow_PlayVOLine = struct {
                pub const m_OnFinished: i64 = 0xD8;
            };
            pub const CTestPulseIOComponent_Derived = struct {

            };
            pub const AI_BaseNPC_DebugSnapshotData_t = struct {
                pub const animgraph: i64 = 0x70;
                pub const navigator: i64 = 0xB8;
                pub const npc_state: i64 = 0x8;
                pub const conditions: i64 = 0x40;
                pub const anim_events: i64 = 0x58;
                pub const current_enemy: i64 = 0x10;
                pub const motorServices: i64 = 0x108;
                pub const facingServices: i64 = 0x140;
                pub const s_current_task: i64 = 0x20;
                pub const s_prev_schedule: i64 = 0x28;
                pub const s_current_schedule: i64 = 0x18;
                pub const s_npc_current_movement: i64 = 0x30;
                pub const s_last_task_end_location: i64 = 0x38;
            };
            pub const CBodyComponentSkeletonInstance = struct {
                pub const m_skeletonInstance: i64 = 0x80;
            };
            pub const CCSGO_EndOfMatchLineupEndpoint = struct {

            };
            pub const CDynamicPropAlias_dynamic_prop = struct {

            };
            pub const CFloatExponentialMovingAverage = struct {

            };
            pub const CInfoInstructorHintBombTargetA = struct {

            };
            pub const CInfoInstructorHintBombTargetB = struct {

            };
            pub const CItemDefuserAlias_item_defuser = struct {

            };
            pub const CNmSnapWeaponNode__CDefinition = struct {
                pub const m_nWeaponTypeNodeIdx: i64 = 0x1C;
                pub const m_nFlashedAmountNodeIdx: i64 = 0x18;
                pub const m_nWeaponCategoryNodeIdx: i64 = 0x1A;
            };
            pub const CPulseCell_ApplyAnimGraphParam = struct {
                pub const m_value: i64 = 0xD8;
            };
            pub const CPulseCell_Inflow_EventHandler = struct {
                pub const m_EventName: i64 = 0x80;
            };
            pub const CPulseCell_Outflow_CycleRandom = struct {
                pub const m_Outputs: i64 = 0x48;
            };
            pub const CPulseCell_Outflow_PlayVCDBase = struct {

            };
            pub const CSoundOpvarSetPathCornerEntity = struct {
                pub const m_flDistMaxSqr: i64 = 0x660;
                pub const m_flDistMinSqr: i64 = 0x65C;
                pub const m_bUseParentedPath: i64 = 0x658;
                pub const m_iszPathCornerEntityName: i64 = 0x668;
            };
            pub const HUDPanelDialogVariableString_t = struct {
                pub const m_bIsSet: i64 = 0x18;
                pub const m_sValue: i64 = 0x10;
                pub const m_nPanelIdIndex: i64 = 0x8;
                pub const m_nDialogVariableIndex: i64 = 0xA;
            };
            pub const SoundeventBoxHelperNetworked_t = struct {
                pub const vMaxs: i64 = 0x24;
                pub const vMins: i64 = 0x18;
                pub const qAngles: i64 = 0xC;
                pub const vOrigin: i64 = 0x0;
            };
            pub const CBaseAnimGraphVariationUserData = struct {

            };
            pub const CDynamicPropAlias_cable_dynamic = struct {

            };
            pub const CNetworkOriginQuantizedVectorWS = struct {
                pub const m_vecX: i64 = 0x10;
                pub const m_vecY: i64 = 0x18;
                pub const m_vecZ: i64 = 0x20;
            };
            pub const CPulseCell_Outflow_CycleOrdered = struct {
                pub const m_Outputs: i64 = 0x48;
            };
            pub const CPulseCell_Outflow_PlaySequence = struct {
                pub const m_ParamSequenceName: i64 = 0x138;
            };
            pub const CTestPulseIO__FloatStringArgs_t = struct {
                pub const flOutFloat: i64 = 0x0;
                pub const strOutString: i64 = 0x8;
            };
            pub const CTestPulseIO__ThreeStringArgs_t = struct {
                pub const strArg1: i64 = 0x0;
                pub const strArg2: i64 = 0x8;
                pub const strArg3: i64 = 0x10;
            };
            pub const CVectorExponentialMovingAverage = struct {

            };
            pub const DestructiblePartDamageRequest_t = struct {
                pub const m_hAttacker: i64 = 0x1C;
                pub const m_nHitGroup: i64 = 0x0;
                pub const m_nDamageType: i64 = 0x10;
                pub const m_nDamageLevel: i64 = 0x4;
                pub const m_flBreakDamage: i64 = 0x14;
                pub const m_nDestroyFlags: i64 = 0xC;
                pub const m_nDesiredHealth: i64 = 0x8;
                pub const m_flBreakDamageRadius: i64 = 0x18;
                pub const m_vWsBreakDamageForce: i64 = 0x2C;
                pub const m_vWsBreakDamageOrigin: i64 = 0x20;
            };
            pub const ServerAuthoritativeWeaponSlot_t = struct {
                pub const unSlot: i64 = 0x32;
                pub const unClass: i64 = 0x30;
                pub const unItemDefIdx: i64 = 0x34;
            };
            pub const AI_Navigator_DebugSnapshotData_t = struct {
                pub const waypoints: i64 = 0x30;
                pub const goal_location: i64 = 0x24;
                pub const s_movement_id: i64 = 0x0;
                pub const last_waypoint_pos: i64 = 0x18;
                pub const s_goal_source_location: i64 = 0x10;
                pub const s_movement_serial_number: i64 = 0x8;
                pub const s_arrival_movement_gait_set: i64 = 0x48;
            };
            pub const CCSGO_RushIntroCharacterPosition = struct {

            };
            pub const CCSGO_RushIntroTerroristPosition = struct {

            };
            pub const CCSGO_TeamIntroCharacterPosition = struct {

            };
            pub const CCSGO_TeamIntroTerroristPosition = struct {

            };
            pub const CCSPlayer_ActionTrackingServices = struct {
                pub const m_bIsRescuing: i64 = 0x224;
                pub const m_weaponPurchasesThisMatch: i64 = 0x228;
                pub const m_weaponPurchasesThisRound: i64 = 0x298;
                pub const m_weaponCarryOverIntoThisRound: i64 = 0x308;
                pub const m_hLastWeaponBeforeC4AutoSwitch: i64 = 0x1F8;
            };
            pub const CHostageAlias_info_hostage_spawn = struct {

            };
            pub const CMarkupSearch_PathCostAreaFilter = struct {
                pub const m_searchHelper: i64 = 0x8;
            };
            pub const CPhysHingeAlias_phys_hinge_local = struct {

            };
            pub const CPulseCell_Inflow_BaseEntrypoint = struct {
                pub const m_EntryChunk: i64 = 0x48;
                pub const m_RegisterMap: i64 = 0x50;
            };
            pub const CPulseCell_Outflow_CycleShuffled = struct {
                pub const m_Outputs: i64 = 0x48;
            };
            pub const CPulseCell_Outflow_PlaySceneBase = struct {
                pub const m_Triggers: i64 = 0x120;
                pub const m_OnFinished: i64 = 0xD8;
            };
            pub const CPulseCell_WaitForCursorsWithTag = struct {
                pub const m_bTagSelfWhenComplete: i64 = 0x128;
                pub const m_nDesiredKillPriority: i64 = 0x12C;
            };
            pub const CPulseGraphInstance_ServerEntity = struct {
                pub const m_hOwner: i64 = 0x118;
                pub const m_bActivated: i64 = 0x11C;
                pub const m_sNameFixupLocal: i64 = 0x130;
                pub const m_sNameFixupParent: i64 = 0x128;
                pub const m_sNameFixupStaticPrefix: i64 = 0x120;
                pub const m_sProceduralWorldNameForRelays: i64 = 0x138;
            };
            pub const AI_DefaultNPC_DebugSnapshotData_t = struct {
                pub const path_query: i64 = 0x40;
                pub const s_npc_tactic_phase: i64 = 0x20;
                pub const s_npc_tactic_current: i64 = 0x18;
                pub const s_npc_current_ability: i64 = 0x8;
                pub const path_queries_speculative: i64 = 0x68;
                pub const s_npc_current_held_ability: i64 = 0x10;
                pub const tactic_interrupt_conditions: i64 = 0x28;
            };
            pub const CBaseAnimGraphAlias_baseanimating = struct {

            };
            pub const CCSGO_TeamSelectCharacterPosition = struct {

            };
            pub const CCSGO_TeamSelectTerroristPosition = struct {

            };
            pub const CPlayer_MovementServices_Humanoid = struct {
                pub const m_nStepside: i64 = 0x280;
                pub const m_groundNormal: i64 = 0x260;
                pub const m_surfaceProps: i64 = 0x270;
                pub const m_flFallVelocity: i64 = 0x25C;
                pub const m_flStepSoundTime: i64 = 0x258;
                pub const m_flSurfaceFriction: i64 = 0x26C;
                pub const m_vecSmoothedVelocity: i64 = 0x284;
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
            pub const CPulseCell_Outflow_PlayDynamicVCD = struct {

            };
            pub const CPulseCell_Step_SetAnimGraphParam = struct {
                pub const m_ParamName: i64 = 0x48;
            };
            pub const DebugSnapshotBaseStructuredData_t = struct {

            };
            pub const CCSGO_TeamPreviewCharacterPosition = struct {
                pub const m_xuid: i64 = 0x4C0;
                pub const m_nRandom: i64 = 0x4AC;
                pub const m_petItem: i64 = 0x1080;
                pub const m_nOrdinal: i64 = 0x4B0;
                pub const m_nVariant: i64 = 0x4A8;
                pub const m_agentItem: i64 = 0x4C8;
                pub const m_glovesItem: i64 = 0x8B0;
                pub const m_weaponItem: i64 = 0xC98;
                pub const m_sWeaponName: i64 = 0x4B8;
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
            pub const CPulseGraphInstance_GameBlackboard = struct {

            };
            pub const CCSGO_WingmanIntroCharacterPosition = struct {

            };
            pub const CCSGO_WingmanIntroTerroristPosition = struct {

            };
            pub const CFuncLadderAlias_func_useableladder = struct {

            };
            pub const CFuncMoveLinearAlias_momentary_door = struct {

            };
            pub const CPulseCell_ApplyDynamicAttributeInt = struct {

            };
            pub const CPulseCell_Outflow_ScriptedSequence = struct {
                pub const m_Triggers: i64 = 0x180;
                pub const m_OnFinished: i64 = 0x138;
                pub const m_szSyncGroup: i64 = 0xD8;
                pub const m_bDontTeleportAtEnd: i64 = 0xE5;
                pub const m_bDisallowInterrupts: i64 = 0xE6;
                pub const m_vecAdditionalActors: i64 = 0x120;
                pub const m_bEnsureOnNavmeshOnFinish: i64 = 0xE4;
                pub const m_scriptedSequenceDataMain: i64 = 0xE8;
                pub const m_nExpectedNumSequencesInSyncGroup: i64 = 0xE0;
            };
            pub const CTestPulseIO__EntityHandleIntArgs_t = struct {
                pub const valueB: i64 = 0x4;
                pub const handleA: i64 = 0x0;
            };
            pub const SoundeventPathCornerPairNetworked_t = struct {
                pub const vP1: i64 = 0x0;
                pub const vP2: i64 = 0xC;
                pub const flP1Pct: i64 = 0x1C;
                pub const flP2Pct: i64 = 0x20;
                pub const flPathLengthSqr: i64 = 0x18;
            };
            pub const AI_MotorServices_DebugSnapshotData_t = struct {
                pub const motor_path: i64 = 0x18;
                pub const active_motor: i64 = 0x0;
                pub const desired_speed: i64 = 0x8;
                pub const motor_velocity: i64 = 0xC;
                pub const ground_entity_debug_name: i64 = 0x30;
            };
            pub const AnimGraph2SerializedPoseRecipeSlot_t = struct {
                pub const m_topology: i64 = 0x30;
            };
            pub const CBaseModelEntity__BodyGroupRequest_t = struct {
                pub const m_nGroup: i64 = 0x10;
                pub const m_uChoice: i64 = 0x14;
                pub const m_uRefCount: i64 = 0x16;
                pub const m_nGroupName: i64 = 0x4;
                pub const m_uRequestID: i64 = 0x0;
                pub const m_sChoiceName: i64 = 0x8;
            };
            pub const CInfoInstructorHintHostageRescueZone = struct {

            };
            pub const CPulseCell_ApplyDynamicAttributeBase = struct {

            };
            pub const CPulseCell_Timeline__TimelineEvent_t = struct {
                pub const m_EventOutflow: i64 = 0x8;
                pub const m_flTimeFromPrevious: i64 = 0x0;
            };
            pub const CPulseCell_WaitForCursorsWithTagBase = struct {
                pub const m_WaitComplete: i64 = 0xE0;
                pub const m_nCursorsAllowedToWait: i64 = 0xD8;
            };
            pub const CTestPulseIO__EntityNameStringArgs_t = struct {
                pub const nameA: i64 = 0x0;
                pub const strValueB: i64 = 0x8;
            };
            pub const AI_FacingServices_DebugSnapshotData_t = struct {
                pub const movement_id: i64 = 0x40;
                pub const npc_position: i64 = 0x0;
                pub const facing_target: i64 = 0x18;
                pub const strafing_source: i64 = 0x30;
                pub const strafing_enabled: i64 = 0x38;
                pub const facing_target_source: i64 = 0x10;
                pub const schedule_facing_priority: i64 = 0x28;
            };
            pub const CCSPlayerController_InventoryServices = struct {
                pub const m_rank: i64 = 0x44;
                pub const m_unMusicID: i64 = 0x40;
                pub const m_unCurrentLoadoutHash: i64 = 0xF90;
                pub const m_nPersonaDataPublicLevel: i64 = 0x5C;
                pub const m_nPersonaDataXpTrailLevel: i64 = 0x6C;
                pub const m_unEquippedPlayerSprayIDs: i64 = 0xF88;
                pub const m_nPersonaDataPublicCommendsLeader: i64 = 0x60;
                pub const m_nPersonaDataPublicCommendsTeacher: i64 = 0x64;
                pub const m_vecServerAuthoritativeWeaponSlots: i64 = 0xF98;
                pub const m_nPersonaDataPublicCommendsFriendly: i64 = 0x68;
            };
            pub const CPulseCell_ApplyParent__CursorState_t = struct {
                pub const m_hChildEntity: i64 = 0x4;
                pub const m_hParentEntity: i64 = 0x0;
            };
            pub const CNetworkOriginCellCoordQuantizedVector = struct {
                pub const m_vecX: i64 = 0x18;
                pub const m_vecY: i64 = 0x20;
                pub const m_vecZ: i64 = 0x28;
                pub const m_cellX: i64 = 0x10;
                pub const m_cellY: i64 = 0x12;
                pub const m_cellZ: i64 = 0x14;
                pub const m_nOutsideWorld: i64 = 0x16;
            };
            pub const CPulseCell_ApplyDynamicAttributeString = struct {

            };
            pub const CPulseCell_LimitCount__InstanceState_t = struct {
                pub const m_nCurrentCount: i64 = 0x0;
            };
            pub const CPulseCell_PlaySequence__CursorState_t = struct {
                pub const m_hTarget: i64 = 0x0;
            };
            pub const CRagdollPropAlias_physics_prop_ragdoll = struct {

            };
            pub const CSoundEventEntityAlias_snd_event_point = struct {

            };
            pub const AI_BaseNPCAnimGraph_DebugSnapshotData_t = struct {
                pub const ag2_update_id: i64 = 0x0;
                pub const e_action_desired: i64 = 0x8;
                pub const e_movement_type_desired: i64 = 0x28;
                pub const e_action_handshake_restart: i64 = 0x10;
                pub const e_movement_handshake_restart: i64 = 0x30;
                pub const e_action_handshake_body_authority_current: i64 = 0x18;
                pub const e_action_handshake_body_authority_desired: i64 = 0x20;
                pub const e_movement_handshake_body_authority_current: i64 = 0x38;
                pub const e_movement_handshake_body_authority_desired: i64 = 0x40;
            };
            pub const CCSGO_RushIntroCounterTerroristPosition = struct {

            };
            pub const CCSGO_TeamIntroCounterTerroristPosition = struct {

            };
            pub const CCSPlayerController_InGameMoneyServices = struct {
                pub const m_iAccount: i64 = 0x48;
                pub const m_iStartAccount: i64 = 0x4C;
                pub const m_iTotalCashSpent: i64 = 0x50;
                pub const m_iCashSpentThisRound: i64 = 0x54;
                pub const m_bReceivesMoneyNextRound: i64 = 0x40;
                pub const m_iMoneyEarnedForNextRound: i64 = 0x44;
            };
            pub const CDynamicPropAlias_prop_dynamic_override = struct {

            };
            pub const CPulseCell_ApplyDynamicAttributeEHandle = struct {

            };
            pub const CPulseCell_IntervalTimer__CursorState_t = struct {
                pub const m_EndTime: i64 = 0x4;
                pub const m_StartTime: i64 = 0x0;
                pub const m_flWaitInterval: i64 = 0x8;
                pub const m_flWaitIntervalHigh: i64 = 0xC;
                pub const m_bCompleteOnNextWake: i64 = 0x10;
            };
            pub const CCSGO_TeamSelectCounterTerroristPosition = struct {

            };
            pub const CNetworkOriginCellCoordQuantizedVectorWS = struct {
                pub const m_vecX: i64 = 0x18;
                pub const m_vecY: i64 = 0x20;
                pub const m_vecZ: i64 = 0x28;
                pub const m_cellX: i64 = 0x10;
                pub const m_cellY: i64 = 0x12;
                pub const m_cellZ: i64 = 0x14;
                pub const m_nOutsideWorld: i64 = 0x16;
            };
            pub const CPulseCell_Outflow_ListenForAnimgraphTag = struct {
                pub const m_OnEnd: i64 = 0x120;
                pub const m_OnStart: i64 = 0xD8;
                pub const m_TagName: i64 = 0x168;
            };
            pub const CPulseCell_Outflow_ListenForEntityOutput = struct {
                pub const m_OnFired: i64 = 0xD8;
                pub const m_strEntityOutput: i64 = 0x120;
                pub const m_bListenUntilCanceled: i64 = 0x128;
            };
            pub const CWorldCompositionChunkReferenceElement_t = struct {
                pub const m_strMapToLoad: i64 = 0x0;
                pub const m_strLandmarkName: i64 = 0x8;
            };
            pub const CPulseCell_IsRequirementValid__Criteria_t = struct {
                pub const m_bIsValid: i64 = 0x0;
            };
            pub const CCSGO_WingmanIntroCounterTerroristPosition = struct {

            };
            pub const CCSPlayerController_ActionTrackingServices = struct {
                pub const m_matchStats: i64 = 0xC8;
                pub const m_perRoundStats: i64 = 0x40;
                pub const m_iNumRoundKills: i64 = 0x188;
                pub const m_flTotalRoundDamageDealt: i64 = 0x190;
                pub const m_iNumRoundKillsHeadshots: i64 = 0x18C;
            };
            pub const CPulseCell_ApplyEntityFlags__CursorState_t = struct {
                pub const m_uFlags: i64 = 0x4;
                pub const m_hEntity: i64 = 0x0;
            };
            pub const CAttributeManager__cached_attribute_float_t = struct {
                pub const flIn: i64 = 0x0;
                pub const flOut: i64 = 0x10;
                pub const iAttribHook: i64 = 0x8;
            };
            pub const CSceneEntityAlias_logic_choreographed_scene = struct {

            };
            pub const AI_GroundRootMotionMotor_DebugSnapshotData_t = struct {
                pub const state: i64 = 0x40;
                pub const move_type: i64 = 0x58;
                pub const b_has_path: i64 = 0x4C;
                pub const vec_events: i64 = 0x78;
                pub const f_target_lean: i64 = 0x70;
                pub const f_current_lean: i64 = 0x6C;
                pub const f_current_speed: i64 = 0x54;
                pub const movement_setting_id: i64 = 0x28;
                pub const current_movement_gait: i64 = 0x20;
                pub const desired_movement_gait: i64 = 0x10;
                pub const b_goal_completion_allowed: i64 = 0x38;
                pub const current_movement_gait_set: i64 = 0x18;
                pub const desired_movement_gait_set: i64 = 0x8;
                pub const n_state_active_tick_count: i64 = 0x48;
                pub const gait_switch_blocked_reason: i64 = 0x30;
                pub const f_remaining_ground_path_length: i64 = 0x50;
                pub const f_forward_strafing_angle_actual: i64 = 0x60;
                pub const f_forward_strafing_angle_desired: i64 = 0x64;
                pub const f_forward_strafing_angle_committed: i64 = 0x68;
            };
            pub const AI_Navigator_DebugSnapshotData_t__Waypoint_t = struct {
                pub const flags: i64 = 0x10;
                pub const nav_type: i64 = 0xC;
                pub const position: i64 = 0x0;
                pub const is_pathcorner: i64 = 0x14;
            };
            pub const CBaseModelEntity__OnDamageLevelChangedArgs_t = struct {
                pub const nHitGroup: i64 = 0x0;
                pub const nDamageLevel: i64 = 0x4;
                pub const nPrevDamageLevel: i64 = 0xC;
                pub const nDamageLevelsRemaining: i64 = 0x8;
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
            pub const CPulseCell_Outflow_PlayVOLine__CursorState_t = struct {
                pub const m_sceneInstance: i64 = 0x0;
            };
            pub const PulseNodeDynamicOutflows_t__DynamicOutflow_t = struct {
                pub const m_OutflowID: i64 = 0x0;
                pub const m_Connection: i64 = 0x8;
            };
            pub const CEnvSoundscapeProxyAlias_snd_soundscape_proxy = struct {

            };
            pub const CPulseCell_ApplyAnimGraphParam__CursorState_t = struct {
                pub const hEntity: i64 = 0x0;
                pub const sParamName: i64 = 0x8;
                pub const bApplyToExternalGraphs: i64 = 0x10;
            };
            pub const AI_DefaultNPC_DebugSnapshotData_t__PathQuery_t = struct {
                pub const m_nMode: i64 = 0x10;
                pub const m_nType: i64 = 0x18;
                pub const m_nState: i64 = 0x20;
                pub const m_nCurrentMovementId: i64 = 0x8;
                pub const m_nInitialMovementId: i64 = 0x0;
            };
            pub const CBaseAnimGraphDestructibleParts_GraphController = struct {

            };
            pub const CPulseCell_Outflow_PlaySceneBase__CursorState_t = struct {
                pub const m_mainActor: i64 = 0x4;
                pub const m_sceneInstance: i64 = 0x0;
                pub const m_cursorIDToEventID: i64 = 0x8;
            };
            pub const CPulseCell_Outflow_CycleOrdered__InstanceState_t = struct {
                pub const m_nNextIndex: i64 = 0x0;
            };
            pub const CPulseCell_Outflow_PlayVCD__VCDRequirementInfo_t = struct {
                pub const m_Outflow: i64 = 0x8;
                pub const m_nEventID: i64 = 0x0;
            };
            pub const CTonemapController2Alias_env_tonemap_controller2 = struct {

            };
            pub const CPulseCell_Outflow_CycleShuffled__InstanceState_t = struct {
                pub const m_Shuffle: i64 = 0x0;
                pub const m_nNextShuffle: i64 = 0x20;
            };
            pub const CPulseCell_Outflow_ScriptedSequence__CursorState_t = struct {
                pub const m_scriptedSequence: i64 = 0x0;
            };
            pub const CPulseCell_ApplyDynamicAttributeBase__CursorState_t = struct {
                pub const m_hEntity: i64 = 0x0;
                pub const m_szAttributeKey: i64 = 0x8;
            };
            pub const CPathParticleRopeAlias_path_particle_rope_clientside = struct {

            };
            pub const AI_GroundRootMotionMotor_DebugSnapshotData_t__Event_t = struct {
                pub const location: i64 = 0x8;
                pub const description: i64 = 0x0;
            };
            pub const CPulseCell_Outflow_ListenForEntityOutput__CursorState_t = struct {
                pub const m_entity: i64 = 0x0;
            };
            pub const AI_MotorServices_DebugSnapshotData_t__MotorPathWaypoint_t = struct {
                pub const flags: i64 = 0x10;
                pub const nav_type: i64 = 0xC;
                pub const position: i64 = 0x0;
            };
            pub const CEnvSoundscapeTriggerableAlias_snd_soundscape_triggerable = struct {

            };
            pub const CCSPlayerController_InventoryServices__NetworkedLoadoutSlot_t = struct {
                pub const slot: i64 = 0xA;
                pub const team: i64 = 0x8;
                pub const pItem: i64 = 0x0;
            };
            pub const CEnvCombinedLightProbeVolumeAlias_func_combined_light_probe_volume = struct {

            };
            pub const ETeam = struct {
                pub const ET_CT: i64 = 0x3;
                pub const ET_Unknown: i64 = 0x0;
                pub const ET_Spectator: i64 = 0x1;
                pub const ET_Terrorist: i64 = 0x2;
            };
            pub const ESOMsg = struct {
                pub const k_ESOMsg_Create: i64 = 0x15;
                pub const k_ESOMsg_Update: i64 = 0x16;
                pub const k_ESOMsg_Destroy: i64 = 0x17;
                pub const k_ESOMsg_UpdateMultiple: i64 = 0x1A;
                pub const k_ESOMsg_CacheSubscribed: i64 = 0x18;
                pub const k_ESOMsg_CacheUnsubscribed: i64 = 0x19;
                pub const k_ESOMsg_CacheSubscriptionCheck: i64 = 0x1B;
                pub const k_ESOMsg_CacheSubscriptionRefresh: i64 = 0x1C;
            };
            pub const Hull_t = struct {
                pub const HULL_NONE: i64 = 0xB;
                pub const HULL_TINY: i64 = 0x3;
                pub const NUM_HULLS: i64 = 0xA;
                pub const HULL_HUMAN: i64 = 0x0;
                pub const HULL_LARGE: i64 = 0x6;
                pub const HULL_SMALL: i64 = 0x9;
                pub const HULL_MEDIUM: i64 = 0x4;
                pub const HULL_WIDE_HUMAN: i64 = 0x2;
                pub const HULL_MEDIUM_TALL: i64 = 0x8;
                pub const HULL_TINY_CENTERED: i64 = 0x5;
                pub const HULL_LARGE_CENTERED: i64 = 0x7;
                pub const HULL_SMALL_CENTERED: i64 = 0x1;
            };
            pub const Class_T = struct {
                pub const CLASS_DOOR: i64 = 0xB;
                pub const CLASS_NONE: i64 = 0x0;
                pub const CLASS_PLAYER: i64 = 0x1;
                pub const CLASS_WEAPON: i64 = 0x5;
                pub const CLASS_PLANTED_C4: i64 = 0xC;
                pub const CLASS_PLAYER_ALLY: i64 = 0x2;
                pub const CLASS_C4_FOR_RADAR: i64 = 0x3;
                pub const CLASS_HUDMODEL_ARMS: i64 = 0x8;
                pub const CLASS_HUDMODEL_ADDON: i64 = 0x9;
                pub const CLASS_WATER_SPLASHER: i64 = 0x6;
                pub const NUM_CLASSIFY_CLASSES: i64 = 0xD;
                pub const CLASS_HUDMODEL_WEAPON: i64 = 0x7;
                pub const CLASS_WORLDMODEL_GLOVES: i64 = 0xA;
                pub const CLASS_FOOT_CONTACT_SHADOW: i64 = 0x4;
            };
            pub const Flags_t = struct {
                pub const FL_BOT: i64 = 0x10;
                pub const FL_FLY: i64 = 0x400;
                pub const FL_CLIENT: i64 = 0x80;
                pub const FL_FROZEN: i64 = 0x20;
                pub const FL_OBJECT: i64 = 0x2000000;
                pub const FL_ONFIRE: i64 = 0x8000000;
                pub const FL_DUCKING: i64 = 0x2;
                pub const FL_GODMODE: i64 = 0x4000;
                pub const FL_GRENADE: i64 = 0x100000;
                pub const FL_CONVEYOR: i64 = 0x1000000;
                pub const FL_NOTARGET: i64 = 0x8000;
                pub const FL_ONGROUND: i64 = 0x1;
                pub const FL_AIMTARGET: i64 = 0x10000;
                pub const FL_DONTTOUCH: i64 = 0x400000;
                pub const FL_WATERJUMP: i64 = 0x4;
                pub const FL_ATCONTROLS: i64 = 0x40;
                pub const FL_DISSOLVING: i64 = 0x10000000;
                pub const FL_FAKECLIENT: i64 = 0x100;
                pub const FL_IN_VEHICLE: i64 = 0x1000;
                pub const FL_BASEVELOCITY: i64 = 0x800000;
                pub const FL_TRANSRAGDOLL: i64 = 0x20000000;
                pub const FL_SUPPRESS_SAVE: i64 = 0x800;
                pub const FL_UNBLOCKABLE_BY_PLAYER: i64 = 0x40000000;
            };
            pub const OnFrame = struct {
                pub const ONFRAME_TRUE: i64 = 0x1;
                pub const ONFRAME_FALSE: i64 = 0x2;
                pub const ONFRAME_UNKNOWN: i64 = 0x0;
            };
            pub const Touch_t = struct {
                pub const touch_none: i64 = 0x0;
                pub const touch_npc_only: i64 = 0x2;
                pub const touch_player_only: i64 = 0x1;
                pub const touch_player_or_npc: i64 = 0x3;
                pub const touch_player_or_npc_or_physicsprop: i64 = 0x4;
            };
            pub const filter_t = struct {
                pub const FILTER_OR: i64 = 0x1;
                pub const FILTER_AND: i64 = 0x0;
            };
            pub const BloodType = struct {
                pub const _None: i64 = -0x1;
                pub const ColorRed: i64 = 0x0;
                pub const ColorGreen: i64 = 0x2;
                pub const ColorYellow: i64 = 0x1;
                pub const ColorRedLVL2: i64 = 0x3;
                pub const ColorRedLVL3: i64 = 0x4;
                pub const ColorRedLVL4: i64 = 0x5;
                pub const ColorRedLVL5: i64 = 0x6;
                pub const ColorRedLVL6: i64 = 0x7;
            };
            pub const EGCPetMsg = struct {
                pub const k_EMsgGCAckPetEvent: i64 = 0x9EA;
            };
            pub const EHitGroup = struct {
                pub const EHG_Gear: i64 = 0x8;
                pub const EHG_Head: i64 = 0x1;
                pub const EHG_Miss: i64 = 0x9;
                pub const EHG_Chest: i64 = 0x2;
                pub const EHG_Generic: i64 = 0x0;
                pub const EHG_LeftArm: i64 = 0x4;
                pub const EHG_LeftLeg: i64 = 0x6;
                pub const EHG_Stomach: i64 = 0x3;
                pub const EHG_RightArm: i64 = 0x5;
                pub const EHG_RightLeg: i64 = 0x7;
            };
            pub const Materials = struct {
                pub const matWeb: i64 = 0x9;
                pub const matNone: i64 = 0xA;
                pub const matWood: i64 = 0x1;
                pub const matFlesh: i64 = 0x3;
                pub const matGlass: i64 = 0x0;
                pub const matMetal: i64 = 0x2;
                pub const matRocks: i64 = 0x8;
                pub const matComputer: i64 = 0x6;
                pub const matCeilingTile: i64 = 0x5;
                pub const matCinderBlock: i64 = 0x4;
                pub const matLastMaterial: i64 = 0xB;
                pub const matUnbreakableGlass: i64 = 0x7;
            };
            pub const QuestType = struct {
                pub const k_EQuestType_Operation: i64 = 0x1;
                pub const k_EQuestType_RecurringMission: i64 = 0x2;
            };
            pub const eRollType = struct {
                pub const ROLL_NONE: i64 = -0x1;
                pub const ROLL_STATS: i64 = 0x0;
                pub const ROLL_OUTTRO: i64 = 0x3;
                pub const ROLL_CREDITS: i64 = 0x1;
                pub const ROLL_LATE_JOIN_LOGO: i64 = 0x2;
            };
            pub const BeamType_t = struct {
                pub const BEAM_ENTS: i64 = 0x3;
                pub const BEAM_LASER: i64 = 0x6;
                pub const BEAM_POINTS: i64 = 0x1;
                pub const BEAM_SPLINE: i64 = 0x5;
                pub const BEAM_INVALID: i64 = 0x0;
                pub const BEAM_ENTPOINT: i64 = 0x2;
                pub const xxBEAM_HOSExxunused: i64 = 0x4;
            };
            pub const ECsgoGCMsg = struct {
                pub const k_EMsgGC_GlobalGame_Play: i64 = 0x23D2;
                pub const k_EMsgGCCStrike15_v2_Base: i64 = 0x238C;
                pub const k_EMsgGC_GlobalGame_Subscribe: i64 = 0x23D0;
                pub const k_EMsgGCCStrike15_v2_MatchList: i64 = 0x23B3;
                pub const k_EMsgGCCStrike15_v2_SetClanId: i64 = 0x240D;
                pub const k_EMsgGCCStrike15_v2_GlobalChat: i64 = 0x23DC;
                pub const k_EMsgGC_GlobalGame_Unsubscribe: i64 = 0x23D1;
                pub const k_EMsgGCCStrike15_ClientDeepStats: i64 = 0x23FA;
                pub const k_EMsgGCCStrike15_v2_DraftSummary: i64 = 0x23CA;
                pub const k_EMsgGCCStrike15_v2_Party_Invite: i64 = 0x23E8;
                pub const k_EMsgGCCStrike15_v2_Party_Search: i64 = 0x23E7;
                pub const k_EMsgGCCStrike15_v2_PrivateQueues: i64 = 0x23FE;
                pub const k_EMsgGCCStrike15_v2_BetaEnrollment: i64 = 0x2401;
                pub const k_EMsgGCCStrike15_v2_GotvSyncPacket: i64 = 0x23E0;
                pub const k_EMsgGCCStrike15_v2_Party_Register: i64 = 0x23E5;
                pub const k_EMsgGCCStrike15_v2_PlayersProfile: i64 = 0x23A8;
                pub const k_EMsgGCCStrike15_v2_WatchInfoUsers: i64 = 0x23A6;
                pub const k_EMsgGCCStrike15_v2_ClientPollState: i64 = 0x23E4;
                pub const k_EMsgGCCStrike15_v2_MatchmakingStop: i64 = 0x238E;
                pub const k_EMsgGCCStrike15_v2_Client2GCTextMsg: i64 = 0x23AF;
                pub const k_EMsgGCCStrike15_v2_ClientPerfReport: i64 = 0x23F2;
                pub const k_EMsgGCCStrike15_v2_GC2ClientTextMsg: i64 = 0x23AE;
                pub const k_EMsgGCCStrike15_v2_MatchmakingStart: i64 = 0x238D;
                pub const k_EMsgGCCStrike15_v2_Party_Unregister: i64 = 0x23E6;
                pub const k_EMsgGCCStrike15_v2_SetEventFavorite: i64 = 0x23F0;
                pub const k_EMsgGCCStrike15_v2_ClientAuthKeyCode: i64 = 0x23DF;
                pub const k_EMsgGCCStrike15_v2_SetMyActivityInfo: i64 = 0x23C7;
                pub const k_EMsgGCCStrike15_v2_AcknowledgePenalty: i64 = 0x23D3;
                pub const k_EMsgGCCStrike15_v2_ClientGCRankUpdate: i64 = 0x23EA;
                pub const k_EMsgGCCStrike15_v2_ClientPartyWarning: i64 = 0x23EE;
                pub const k_EMsgGCCStrike15_v2_ClientReportPlayer: i64 = 0x239F;
                pub const k_EMsgGCCStrike15_v2_ClientReportServer: i64 = 0x23A0;
                pub const k_EMsgGCCStrike15_v2_ClientCommendPlayer: i64 = 0x23A1;
                pub const k_EMsgGCCStrike15_v2_ClientNetworkConfig: i64 = 0x2404;
                pub const k_EMsgGCCStrike15_v2_ClientRequestOffers: i64 = 0x23EB;
                pub const k_EMsgGCCStrike15_v2_ClientAccountBalance: i64 = 0x23EC;
                pub const k_EMsgGCCStrike15_v2_ClientPartyJoinRelay: i64 = 0x23ED;
                pub const k_EMsgGCCStrike15_v2_ClientReportResponse: i64 = 0x23A2;
                pub const k_EMsgGCCStrike15_v2_GC2ClientGlobalStats: i64 = 0x23D5;
                pub const k_EMsgGCCStrike15_v2_GlobalChat_Subscribe: i64 = 0x23DD;
                pub const k_EMsgGCCStrike15_v2_PremierSeasonSummary: i64 = 0x2408;
                pub const k_EMsgGCCStrike15_v2_Client2GCStreamUnlock: i64 = 0x23D6;
                pub const k_EMsgGCCStrike15_v2_ClientLogonFatalError: i64 = 0x23E3;
                pub const k_EMsgGCCStrike15_v2_ClientPlayerDecalSign: i64 = 0x23E1;
                pub const k_EMsgGCCStrike15_v2_ClientRequestSouvenir: i64 = 0x23F4;
                pub const k_EMsgGCCStrike15_v2_GC2ClientNotifyXPShop: i64 = 0x2405;
                pub const k_EMsgGCCStrike15_v2_VolatileShopSubscribe: i64 = 0x240C;
                pub const k_EMsgGCCStrike15_v2_AccountPrivacySettings: i64 = 0x23C6;
                pub const k_EMsgGCCStrike15_v2_Account_RequestCoPlays: i64 = 0x23E9;
                pub const k_EMsgGCCStrike15_v2_ClientRedeemFreeReward: i64 = 0x2403;
                pub const k_EMsgGCCStrike15_v2_ClientSubmitSurveyVote: i64 = 0x23C0;
                pub const k_EMsgGCCStrike15_v2_GlobalChat_Unsubscribe: i64 = 0x23DE;
                pub const k_EMsgGCCStrike15_v2_MatchEndRunRewardDrops: i64 = 0x23B0;
                pub const k_EMsgGCCStrike15_v2_RecurringMissionSchema: i64 = 0x240A;
                pub const k_EMsgGCCStrike15_v2_ClientToGCRequestTicket: i64 = 0x23DA;
                pub const k_EMsgGCCStrike15_v2_FantasyUpdateClientData: i64 = 0x23D8;
                pub const k_EMsgGCCStrike15_v2_GC2ClientTournamentInfo: i64 = 0x23CF;
                pub const k_EMsgGCCStrike15_v2_GiftsLeaderboardRequest: i64 = 0x23BC;
                pub const k_EMsgGCCStrike15_v2_Server2GCClientValidate: i64 = 0x23C1;
                pub const k_EMsgGCCStrike15_v2_VolatileItemClaimReward: i64 = 0x240B;
                pub const k_EMsgGCCStrike15_StartAgreementSessionInGame: i64 = 0x23FB;
                pub const k_EMsgGCCStrike15_v2_Client2GcAckXPShopTracks: i64 = 0x2406;
                pub const k_EMsgGCCStrike15_v2_ClientCommendPlayerQuery: i64 = 0x23A3;
                pub const k_EMsgGCCStrike15_v2_ClientToGCRequestElevate: i64 = 0x23DB;
                pub const k_EMsgGCCStrike15_v2_FantasyRequestClientData: i64 = 0x23D7;
                pub const k_EMsgGCCStrike15_v2_GiftsLeaderboardResponse: i64 = 0x23BD;
                pub const k_EMsgGCCStrike15_v2_ClientRedeemMissionReward: i64 = 0x23F9;
                pub const k_EMsgGCCStrike15_v2_GetEventFavorites_Request: i64 = 0x23F1;
                pub const k_EMsgGCCStrike15_v2_MatchmakingClient2GCHello: i64 = 0x2395;
                pub const k_EMsgGCCStrike15_v2_MatchmakingGC2ClientHello: i64 = 0x2396;
                pub const k_EMsgGCCStrike15_v2_PlayerOverwatchCaseStatus: i64 = 0x23AD;
                pub const k_EMsgGCCStrike15_v2_PlayerOverwatchCaseUpdate: i64 = 0x23AB;
                pub const k_EMsgGCCStrike15_v2_GC2ServerReservationUpdate: i64 = 0x23B6;
                pub const k_EMsgGCCStrike15_v2_GetEventFavorites_Response: i64 = 0x23F3;
                pub const k_EMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate: i64 = 0x2390;
                pub const k_EMsgGCCStrike15_v2_ClientRequestJoinFriendData: i64 = 0x23CB;
                pub const k_EMsgGCCStrike15_v2_ClientRequestJoinServerData: i64 = 0x23CC;
                pub const k_EMsgGCCStrike15_v2_ClientRequestPlayersProfile: i64 = 0x23A7;
                pub const k_EMsgGCCStrike15_v2_MatchmakingGC2ClientAbandon: i64 = 0x2398;
                pub const k_EMsgGCCStrike15_v2_MatchmakingGC2ClientReserve: i64 = 0x2393;
                pub const k_EMsgGCCStrike15_v2_Client2GCRequestPrestigeCoin: i64 = 0x23D4;
                pub const k_EMsgGCCStrike15_v2_MatchListRequestFullGameInfo: i64 = 0x23BB;
                pub const k_EMsgGCCStrike15_v2_MatchmakingClient2ServerPing: i64 = 0x238F;
                pub const k_EMsgGCCStrike15_v2_SetPlayerLeaderboardSafeName: i64 = 0x2402;
                pub const k_EMsgGCCStrike15_v2_GCToClientSteamdatagramTicket: i64 = 0x23D9;
                pub const k_EMsgGCCStrike15_v2_PlayerOverwatchCaseAssignment: i64 = 0x23AC;
                pub const k_EMsgGCCStrike15_v2_ClientRequestWatchInfoFriends2: i64 = 0x23B2;
                pub const k_EMsgGCCStrike15_v2_ClientVarValueNotificationInfo: i64 = 0x23B8;
                pub const k_EMsgGCCStrike15_v2_ServerVarValueNotificationInfo: i64 = 0x23BE;
                pub const k_EMsgGCCStrike15_v2_MatchEndRewardDropsNotification: i64 = 0x23B1;
                pub const k_EMsgGCCStrike15_v2_MatchListRequestLiveGameForUser: i64 = 0x23C2;
                pub const k_EMsgGCCStrike15_v2_MatchListRequestRecentUserGames: i64 = 0x23B5;
                pub const k_EMsgGCCStrike15_v2_MatchListRequestTournamentGames: i64 = 0x23BA;
                pub const k_EMsgGCCStrike15_v2_MatchListTournamentOperatorMgmt: i64 = 0x23FF;
                pub const k_EMsgGCCStrike15_v2_MatchmakingGC2ClientSearchStats: i64 = 0x2407;
                pub const k_EMsgGCCStrike15_v2_RequestRecurringMissionSchedule: i64 = 0x2409;
                pub const k_EMsgGCCStrike15_v2_ClientCommendPlayerQueryResponse: i64 = 0x23A4;
                pub const k_EMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames: i64 = 0x23B4;
                pub const k_EMsgGCCStrike15_v2_MatchmakingOperator2GCBlogUpdate: i64 = 0x239D;
                pub const k_EMsgGCCStrike15_v2_ServerNotificationForUserPenalty: i64 = 0x239E;
                pub const k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockRequest: i64 = 0x23C4;
                pub const k_EMsgGCCStrike15_v2_MatchListUploadTournamentPredictions: i64 = 0x23C9;
                pub const k_EMsgGCCStrike15_v2_MatchmakingServerReservationResponse: i64 = 0x2392;
                pub const k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockResponse: i64 = 0x23C5;
                pub const k_EMsgGCCStrike15_v2_MatchListRequestTournamentPredictions: i64 = 0x23C8;
            };
            pub const EGCBaseMsg = struct {
                pub const k_EMsgGCError: i64 = 0x119D;
                pub const k_EMsgGCInQueue: i64 = 0xFA8;
                pub const k_EMsgGCLeaveParty: i64 = 0x1199;
                pub const k_EMsgGCConVarUpdated: i64 = 0xFA3;
                pub const k_EMsgGCInviteToParty: i64 = 0x1195;
                pub const k_EMsgGCKickFromParty: i64 = 0x1198;
                pub const k_EMsgGCSystemMessage: i64 = 0xFA1;
                pub const k_EMsgGCGameServerInfo: i64 = 0x119C;
                pub const k_EMsgGCServerAvailable: i64 = 0x119A;
                pub const k_EMsgGCReplicateConVars: i64 = 0xFA2;
                pub const k_EMsgGCInvitationCreated: i64 = 0x1196;
                pub const k_EMsgGCLANServerAvailable: i64 = 0x119F;
                pub const k_EMsgGCPartyInviteResponse: i64 = 0x1197;
                pub const k_EMsgGCClientConnectToServer: i64 = 0x119B;
                pub const k_EMsgGCReplay_UploadedToYouTube: i64 = 0x119E;
            };
            pub const EGCItemMsg = struct {
                pub const k_EMsgGCBase: i64 = 0x3E8;
                pub const k_EMsgGCCraft: i64 = 0x3EA;
                pub const k_EMsgGCDelete: i64 = 0x3EC;
                pub const k_EMsgGCNameItem: i64 = 0x3EE;
                pub const k_EMsgGCOpenCrate: i64 = 0x9E6;
                pub const k_EMsgGCPaintItem: i64 = 0x3F1;
                pub const k_EMsgGCSortItems: i64 = 0x411;
                pub const k_EMsgGCCollectItem: i64 = 0x425;
                pub const k_EMsgGCDeliverGift: i64 = 0x40A;
                pub const k_EMsgGCGiftedItems: i64 = 0x43B;
                pub const k_EMsgGCMOTDRequest: i64 = 0x3F4;
                pub const k_EMsgGCApplySticker: i64 = 0x43E;
                pub const k_EMsgGCGiftWrapItem: i64 = 0x408;
                pub const k_EMsgGCNameBaseItem: i64 = 0x3FB;
                pub const k_EMsgGCPaintKitItem: i64 = 0x438;
                pub const k_EMsgGCSetItemStyle: i64 = 0x40F;
                pub const k_EMsgGCStatTrakSwap: i64 = 0x440;
                pub const k_EMsgGC_ReportAbuse: i64 = 0x429;
                pub const k_EMsgGCCasketItemAdd: i64 = 0x444;
                pub const k_EMsgGCCraftResponse: i64 = 0x3EB;
                pub const k_EMsgGCLookupAccount: i64 = 0x413;
                pub const k_EMsgGCRemoveItemName: i64 = 0x406;
                pub const k_EMsgGCSaxxyBroadcast: i64 = 0x421;
                pub const k_EMsgGCUseItemRequest: i64 = 0x401;
                pub const k_EMsgGCApplyEggEssence: i64 = 0x436;
                pub const k_EMsgGCRemoveItemPaint: i64 = 0x407;
                pub const k_EMsgGCSetItemPosition: i64 = 0x3E9;
                pub const k_EMsgGCUnlockItemStyle: i64 = 0x43C;
                pub const k_EMsgGCUseItemResponse: i64 = 0x402;
                pub const k_EMsgGCApplyStrangePart: i64 = 0x431;
                pub const k_EMsgGCItemAcknowledged: i64 = 0x43F;
                pub const k_EMsgGCPaintKitBaseItem: i64 = 0x439;
                pub const k_EMsgGCRemoveMakersMark: i64 = 0x41D;
                pub const k_EMsgGCSetItemPositions: i64 = 0x435;
                pub const k_EMsgGCStoreGetUserData: i64 = 0x9C4;
                pub const k_EMsgGCUpdateItemSchema: i64 = 0x419;
                pub const k_EMsgGCCasketItemExtract: i64 = 0x445;
                pub const k_EMsgGCItemPreviewExpire: i64 = 0x6A9;
                pub const k_EMsgGCLookupAccountName: i64 = 0x415;
                pub const k_EMsgGCPaintItemResponse: i64 = 0x3F2;
                pub const k_EMsgGCServerRentalsBase: i64 = 0x6A4;
                pub const k_EMsgGCShowItemsPickedUp: i64 = 0x42F;
                pub const k_EMsgGCStorePurchaseInit: i64 = 0x9CE;
                pub const k_EMsgGCToGCDirtySDOCache: i64 = 0x9D4;
                pub const k_EMsgGCUnwrapGiftRequest: i64 = 0x40D;
                pub const k_EMsgGCUsedClaimCodeItem: i64 = 0x410;
                pub const k_EMsgGCDev_NewItemRequest: i64 = 0x7D1;
                pub const k_EMsgGCItemPreviewRequest: i64 = 0x6A7;
                pub const k_EMsgGCUnwrapGiftResponse: i64 = 0x40E;
                pub const k_EMsgGCApplyPennantUpgrade: i64 = 0x434;
                pub const k_EMsgGCConsumableExhausted: i64 = 0x42E;
                pub const k_EMsgGCMOTDRequestResponse: i64 = 0x3F5;
                pub const k_EMsgGCModifyItemAttribute: i64 = 0x443;
                pub const k_EMsgGCRemoveCustomTexture: i64 = 0x41B;
                pub const k_EMsgGCStorePurchaseCancel: i64 = 0x9CA;
                pub const k_EMsgGCToGCIsTrustedServer: i64 = 0x9D7;
                pub const k_EMsgGCUnlockCrateResponse: i64 = 0x3F0;
                pub const k_EMsgGCBackpackSortFinished: i64 = 0x422;
                pub const k_EMsgGCClientVersionUpdated: i64 = 0x9E0;
                pub const k_EMsgGCCustomizeItemTexture: i64 = 0x3FF;
                pub const k_EMsgGCDev_PaintKitDropItem: i64 = 0x7D3;
                pub const k_EMsgGCGiftWrapItemResponse: i64 = 0x409;
                pub const k_EMsgGCNameBaseItemResponse: i64 = 0x3FC;
                pub const k_EMsgGCNameItemNotification: i64 = 0x42C;
                pub const k_EMsgGCPaintKitItemResponse: i64 = 0x43A;
                pub const k_EMsgGCRequestAnnouncements: i64 = 0x9DD;
                pub const k_EMsgGCServerVersionUpdated: i64 = 0x9DA;
                pub const k_EMsgGC_ReportAbuseResponse: i64 = 0x42A;
                pub const k_EMsgGCBannedWordListRequest: i64 = 0x9D0;
                pub const k_EMsgGCGoldenWrenchBroadcast: i64 = 0x3F3;
                pub const k_EMsgGCLookupAccountResponse: i64 = 0x414;
                pub const k_EMsgGCStorePurchaseFinalize: i64 = 0x9C8;
                pub const k_EMsgGCStorePurchaseQueryTxn: i64 = 0x9CC;
                pub const k_EMsgGCToGCUpdateSQLKeyValue: i64 = 0x9D6;
                pub const k_EMsgGCAdjustEquipSlotsManual: i64 = 0x9E3;
                pub const k_EMsgGCApplyConsumableEffects: i64 = 0x42D;
                pub const k_EMsgGCBannedWordListResponse: i64 = 0x9D1;
                pub const k_EMsgGCCasketItemLoadContents: i64 = 0x446;
                pub const k_EMsgGCGiftedItems_DEPRECATED: i64 = 0x403;
                pub const k_EMsgGCItemPreviewCheckStatus: i64 = 0x6A5;
                pub const k_EMsgGCNameEggEssenceResponse: i64 = 0x437;
                pub const k_EMsgGCRemoveUniqueCraftIndex: i64 = 0x41F;
                pub const k_EMsgGCUnlockCrate_DEPRECATED: i64 = 0x3EF;
                pub const k_EMsgGCAdjustEquipSlotsShuffle: i64 = 0x9E4;
                pub const k_EMsgGCUnlockItemStyleResponse: i64 = 0x43D;
                pub const k_EMsgGCVerifyCacheSubscription: i64 = 0x3ED;
                pub const k_EMsgGCDeliverGiftResponseGiver: i64 = 0x40B;
                pub const k_EMsgGCRemoveMakersMarkResponse: i64 = 0x41E;
                pub const k_EMsgGCRequestPassportItemGrant: i64 = 0x9DF;
                pub const k_EMsgGCStoreGetUserDataResponse: i64 = 0x9C5;
                pub const k_EMsgGCToGCWebAPIAccountChanged: i64 = 0x9DC;
                pub const k_EMsgGCVolatileItemLoadContents: i64 = 0x9E8;
                pub const k_EMsgGCClientDisplayNotification: i64 = 0x430;
                pub const k_EMsgGCItemPreviewStatusResponse: i64 = 0x6A6;
                pub const k_EMsgGCLookupAccountNameResponse: i64 = 0x416;
                pub const k_EMsgGCStorePurchaseInitResponse: i64 = 0x9CF;
                pub const k_EMsgGCToGCBannedWordListUpdated: i64 = 0x9D3;
                pub const k_EMsgGCToGCDirtyMultipleSDOCache: i64 = 0x9D5;
                pub const k_EMsgGCAddItemToSocket_DEPRECATED: i64 = 0x3F6;
                pub const k_EMsgGCAddSocketToItem_DEPRECATED: i64 = 0x3F9;
                pub const k_EMsgGCDev_NewItemRequestResponse: i64 = 0x7D2;
                pub const k_EMsgGCItemPreviewRequestResponse: i64 = 0x6A8;
                pub const k_EMsgGCAcknowledgeRentalExpiration: i64 = 0x9E7;
                pub const k_EMsgGCDeliverGiftResponseReceiver: i64 = 0x40C;
                pub const k_EMsgGCRecurringSubscriptionStatus: i64 = 0x9E2;
                pub const k_EMsgGCRemoveCustomTextureResponse: i64 = 0x41C;
                pub const k_EMsgGCRemoveSocketItem_DEPRECATED: i64 = 0x3FD;
                pub const k_EMsgGCStorePurchaseCancelResponse: i64 = 0x9CB;
                pub const k_EMsgGCToGCBannedWordListBroadcast: i64 = 0x9D2;
                pub const k_EMsgGCToGCBroadcastConsoleCommand: i64 = 0x9D9;
                pub const k_EMsgGCToGCIsTrustedServerResponse: i64 = 0x9D8;
                pub const k_EMsgGC_IncrementKillCountResponse: i64 = 0x433;
                pub const k_EMsgGCCustomizeItemTextureResponse: i64 = 0x400;
                pub const k_EMsgGCDev_SchemaReservationRequest: i64 = 0x7D4;
                pub const k_EMsgGCItemAcknowledged__DEPRECATED: i64 = 0x426;
                pub const k_EMsgGCRequestAnnouncementsResponse: i64 = 0x9DE;
                pub const k_EMsgGCServerBrowser_FavoriteServer: i64 = 0x641;
                pub const k_EMsgGCStorePurchaseInit_DEPRECATED: i64 = 0x9C6;
                pub const k_EMsgGC_IncrementKillCountAttribute: i64 = 0x432;
                pub const k_EMsgGCItemCustomizationNotification: i64 = 0x442;
                pub const k_EMsgGCItemPreviewExpireNotification: i64 = 0x6AA;
                pub const k_EMsgGCServerBrowser_BlacklistServer: i64 = 0x642;
                pub const k_EMsgGCStorePurchaseFinalizeResponse: i64 = 0x9C9;
                pub const k_EMsgGCStorePurchaseQueryTxnResponse: i64 = 0x9CD;
                pub const k_EMsgGC_RevolvingLootList_DEPRECATED: i64 = 0x412;
                pub const k_EMsgGCAddSocketToBaseItem_DEPRECATED: i64 = 0x3F8;
                pub const k_EMsgGCRemoveUniqueCraftIndexResponse: i64 = 0x420;
                pub const k_EMsgGCUserTrackTimePlayedConsecutively: i64 = 0x441;
                pub const k_EMsgGCItemPreviewItemBoughtNotification: i64 = 0x6AB;
                pub const k_EMsgGCAddItemToSocketResponse_DEPRECATED: i64 = 0x3F7;
                pub const k_EMsgGCAddSocketToItemResponse_DEPRECATED: i64 = 0x3FA;
                pub const k_EMsgGCRemoveSocketItemResponse_DEPRECATED: i64 = 0x3FE;
                pub const k_EMsgGCStorePurchaseInitResponse_DEPRECATED: i64 = 0x9C7;
            };
            pub const EGCToGCMsg = struct {
                pub const k_EGCToGCMsgRouted: i64 = 0x98;
                pub const k_EGCToGCMsgMasterAck: i64 = 0x96;
                pub const k_EMsgUpdateSessionIP: i64 = 0x9A;
                pub const k_EMsgRequestSessionIP: i64 = 0x9B;
                pub const k_EGCToGCMsgRoutedReply: i64 = 0x99;
                pub const k_EGCToGCMsgMasterAckResponse: i64 = 0x97;
                pub const k_EMsgRequestSessionIPResponse: i64 = 0x9C;
                pub const k_EGCToGCMsgMasterStartupComplete: i64 = 0x9D;
            };
            pub const Explosions = struct {
                pub const expRandom: i64 = 0x0;
                pub const expDirected: i64 = 0x1;
                pub const expUsePrecise: i64 = 0x2;
            };
            pub const HitGroup_t = struct {
                pub const HITGROUP_GEAR: i64 = 0xA;
                pub const HITGROUP_HEAD: i64 = 0x1;
                pub const HITGROUP_NECK: i64 = 0x8;
                pub const HITGROUP_CHEST: i64 = 0x2;
                pub const HITGROUP_COUNT: i64 = 0xC;
                pub const HITGROUP_UNUSED: i64 = 0x9;
                pub const HITGROUP_GENERIC: i64 = 0x0;
                pub const HITGROUP_INVALID: i64 = -0x1;
                pub const HITGROUP_LEFTARM: i64 = 0x4;
                pub const HITGROUP_LEFTLEG: i64 = 0x6;
                pub const HITGROUP_SPECIAL: i64 = 0xB;
                pub const HITGROUP_STOMACH: i64 = 0x3;
                pub const HITGROUP_RIGHTARM: i64 = 0x5;
                pub const HITGROUP_RIGHTLEG: i64 = 0x7;
            };
            pub const MoveType_t = struct {
                pub const MOVETYPE_FLY: i64 = 0x3;
                pub const MOVETYPE_LAST: i64 = 0xB;
                pub const MOVETYPE_NONE: i64 = 0x0;
                pub const MOVETYPE_PUSH: i64 = 0x6;
                pub const MOVETYPE_WALK: i64 = 0x2;
                pub const MOVETYPE_CUSTOM: i64 = 0xA;
                pub const MOVETYPE_LADDER: i64 = 0x9;
                pub const MOVETYPE_NOCLIP: i64 = 0x7;
                pub const MOVETYPE_INVALID: i64 = 0xB;
                pub const MOVETYPE_MAX_BITS: i64 = 0x5;
                pub const MOVETYPE_OBSERVER: i64 = 0x8;
                pub const MOVETYPE_OBSOLETE: i64 = 0x1;
                pub const MOVETYPE_VPHYSICS: i64 = 0x5;
                pub const MOVETYPE_FLYGRAVITY: i64 = 0x4;
            };
            pub const NavDirType = struct {
                pub const EAST: i64 = 0x1;
                pub const WEST: i64 = 0x3;
                pub const NORTH: i64 = 0x0;
                pub const SOUTH: i64 = 0x2;
                pub const NUM_NAV_DIR_TYPE_DIRECTIONS: i64 = 0x4;
            };
            pub const NavScope_t = struct {
                pub const eAir: i64 = 0x1;
                pub const eCount: i64 = 0x2;
                pub const eFirst: i64 = 0x0;
                pub const eGround: i64 = 0x0;
                pub const eInvalid: i64 = 0xFF;
            };
            pub const RenderFx_t = struct {
                pub const kRenderFxMax: i64 = 0x11;
                pub const kRenderFxNone: i64 = 0x0;
                pub const kRenderFxFadeIn: i64 = 0xF;
                pub const kRenderFxFadeOut: i64 = 0xE;
                pub const kRenderFxFadeFast: i64 = 0x6;
                pub const kRenderFxFadeSlow: i64 = 0x5;
                pub const kRenderFxPulseFast: i64 = 0x2;
                pub const kRenderFxPulseSlow: i64 = 0x1;
                pub const kRenderFxSolidFast: i64 = 0x8;
                pub const kRenderFxSolidSlow: i64 = 0x7;
                pub const kRenderFxStrobeFast: i64 = 0xA;
                pub const kRenderFxStrobeSlow: i64 = 0x9;
                pub const kRenderFxFlickerFast: i64 = 0xD;
                pub const kRenderFxFlickerSlow: i64 = 0xC;
                pub const kRenderFxStrobeFaster: i64 = 0xB;
                pub const kRenderFxPulseFastWide: i64 = 0x4;
                pub const kRenderFxPulseSlowWide: i64 = 0x3;
                pub const kRenderFxPulseFastWider: i64 = 0x10;
            };
            pub const TRAIN_CODE = struct {
                pub const TRAIN_SAFE: i64 = 0x0;
                pub const TRAIN_BLOCKING: i64 = 0x1;
                pub const TRAIN_FOLLOWING: i64 = 0x2;
            };
            pub const AmmoFlags_t = struct {
                pub const AMMO_FLAG_MAX: i64 = 0x2;
                pub const AMMO_FORCE_DROP_IF_CARRIED: i64 = 0x1;
                pub const AMMO_RESERVE_STAYS_WITH_WEAPON: i64 = 0x2;
            };
            pub const DIALOG_TYPE = struct {
                pub const DIALOG_MSG: i64 = 0x0;
                pub const DIALOG_MENU: i64 = 0x1;
                pub const DIALOG_TEXT: i64 = 0x2;
                pub const DIALOG_ENTRY: i64 = 0x3;
                pub const DIALOG_ASKCONNECT: i64 = 0x4;
            };
            pub const DoorState_t = struct {
                pub const DOOR_STATE_AJAR: i64 = 0x4;
                pub const DOOR_STATE_OPEN: i64 = 0x2;
                pub const DOOR_STATE_CLOSED: i64 = 0x0;
                pub const DOOR_STATE_CLOSING: i64 = 0x3;
                pub const DOOR_STATE_OPENING: i64 = 0x1;
            };
            pub const EWeaponType = struct {
                pub const EWT_C4: i64 = 0x7;
                pub const EWT_Knife: i64 = 0x0;
                pub const EWT_Rifle: i64 = 0x3;
                pub const EWT_Pistol: i64 = 0x1;
                pub const EWT_Grenade: i64 = 0x8;
                pub const EWT_Shotgun: i64 = 0x4;
                pub const EWT_Unknown: i64 = 0xB;
                pub const EWT_Equipment: i64 = 0x9;
                pub const EWT_MachineGun: i64 = 0x6;
                pub const EWT_SniperRifle: i64 = 0x5;
                pub const EWT_StackableItem: i64 = 0xA;
                pub const EWT_SubMachineGun: i64 = 0x2;
            };
            pub const LifeState_t = struct {
                pub const LIFE_DEAD: i64 = 0x2;
                pub const LIFE_ALIVE: i64 = 0x0;
                pub const LIFE_DYING: i64 = 0x1;
                pub const NUM_LIFESTATES: i64 = 0x5;
                pub const LIFE_RESPAWNING: i64 = 0x4;
                pub const LIFE_RESPAWNABLE: i64 = 0x3;
            };
            pub const MedalRank_t = struct {
                pub const MEDAL_RANK_GOLD: i64 = 0x3;
                pub const MEDAL_RANK_NONE: i64 = 0x0;
                pub const MEDAL_RANK_COUNT: i64 = 0x4;
                pub const MEDAL_RANK_BRONZE: i64 = 0x1;
                pub const MEDAL_RANK_SILVER: i64 = 0x2;
            };
            pub const SolidType_t = struct {
                pub const SOLID_BSP: i64 = 0x1;
                pub const SOLID_OBB: i64 = 0x3;
                pub const SOLID_BBOX: i64 = 0x2;
                pub const SOLID_LAST: i64 = 0x9;
                pub const SOLID_NONE: i64 = 0x0;
                pub const SOLID_POINT: i64 = 0x5;
                pub const SOLID_SPHERE: i64 = 0x4;
                pub const SOLID_CAPSULE: i64 = 0x7;
                pub const SOLID_CYLINDER: i64 = 0x8;
                pub const SOLID_VPHYSICS: i64 = 0x6;
            };
            pub const doorCheck_e = struct {
                pub const DOOR_CHECK_FULL: i64 = 0x2;
                pub const DOOR_CHECK_FORWARD: i64 = 0x0;
                pub const DOOR_CHECK_BACKWARD: i64 = 0x1;
            };
            pub const gear_slot_t = struct {
                pub const GEAR_SLOT_C4: i64 = 0x4;
                pub const GEAR_SLOT_LAST: i64 = 0xC;
                pub const GEAR_SLOT_COUNT: i64 = 0xD;
                pub const GEAR_SLOT_FIRST: i64 = 0x0;
                pub const GEAR_SLOT_KNIFE: i64 = 0x2;
                pub const GEAR_SLOT_RIFLE: i64 = 0x0;
                pub const GEAR_SLOT_BOOSTS: i64 = 0xB;
                pub const GEAR_SLOT_PISTOL: i64 = 0x1;
                pub const GEAR_SLOT_INVALID: i64 = -0x1;
                pub const GEAR_SLOT_UTILITY: i64 = 0xC;
                pub const GEAR_SLOT_GRENADES: i64 = 0x3;
                pub const GEAR_SLOT_RESERVED_SLOT6: i64 = 0x5;
                pub const GEAR_SLOT_RESERVED_SLOT7: i64 = 0x6;
                pub const GEAR_SLOT_RESERVED_SLOT8: i64 = 0x7;
                pub const GEAR_SLOT_RESERVED_SLOT9: i64 = 0x8;
                pub const GEAR_SLOT_RESERVED_SLOT10: i64 = 0x9;
                pub const GEAR_SLOT_RESERVED_SLOT11: i64 = 0xA;
            };
            pub const CLC_Messages = struct {
                pub const clc_Move: i64 = 0x15;
                pub const clc_VoiceData: i64 = 0x16;
                pub const clc_ClientInfo: i64 = 0x14;
                pub const clc_Diagnostic: i64 = 0x25;
                pub const clc_HltvReplay: i64 = 0x24;
                pub const clc_BaselineAck: i64 = 0x17;
                pub const clc_CmdKeyValues: i64 = 0x22;
                pub const clc_RequestPause: i64 = 0x21;
                pub const clc_ServerStatus: i64 = 0x1F;
                pub const clc_LoadingProgress: i64 = 0x1B;
                pub const clc_RespondCvarValue: i64 = 0x19;
                pub const clc_RconServerDetails: i64 = 0x23;
                pub const clc_SplitPlayerConnect: i64 = 0x1C;
                pub const clc_SplitPlayerDisconnect: i64 = 0x1E;
            };
            pub const CSWeaponMode = struct {
                pub const Primary_Mode: i64 = 0x0;
                pub const Secondary_Mode: i64 = 0x1;
                pub const WeaponMode_MAX: i64 = 0x2;
            };
            pub const CSWeaponType = struct {
                pub const WEAPONTYPE_C4: i64 = 0x7;
                pub const WEAPONTYPE_KNIFE: i64 = 0x0;
                pub const WEAPONTYPE_RIFLE: i64 = 0x3;
                pub const WEAPONTYPE_TASER: i64 = 0x8;
                pub const WEAPONTYPE_PISTOL: i64 = 0x1;
                pub const WEAPONTYPE_GRENADE: i64 = 0x9;
                pub const WEAPONTYPE_SHOTGUN: i64 = 0x4;
                pub const WEAPONTYPE_UNKNOWN: i64 = 0xC;
                pub const WEAPONTYPE_EQUIPMENT: i64 = 0xA;
                pub const WEAPONTYPE_MACHINEGUN: i64 = 0x6;
                pub const WEAPONTYPE_SNIPER_RIFLE: i64 = 0x5;
                pub const WEAPONTYPE_STACKABLEITEM: i64 = 0xB;
                pub const WEAPONTYPE_SUBMACHINEGUN: i64 = 0x2;
            };
            pub const DecalFlags_t = struct {
                pub const eAll: i64 = 0xFFFFFFFF;
                pub const eNone: i64 = 0x0;
                pub const eCannotClear: i64 = 0x1;
                pub const eAllButCannotClear: i64 = 0xFFFFFFFE;
                pub const eDecalProjectToBackfaces: i64 = 0x2;
            };
            pub const EGCSystemMsg = struct {
                pub const k_EGCMsgMulti: i64 = 0x1;
                pub const k_EGCMsgInvalid: i64 = 0x0;
                pub const k_EGCMsgPostAlert: i64 = 0x4B;
                pub const k_EGCMsgSendEmail: i64 = 0x57;
                pub const k_EGCMsgWGRequest: i64 = 0x39;
                pub const k_EGCMsgConCommand: i64 = 0x34;
                pub const k_EGCMsgSetOptions: i64 = 0xE2;
                pub const k_EGCMsgSystemBase: i64 = 0x32;
                pub const k_EGCMsgWGResponse: i64 = 0x3A;
                pub const k_EGCMsgGetCommands: i64 = 0x4E;
                pub const k_EGCMsgGetLicenses: i64 = 0x4C;
                pub const k_EGCMsgStopPlaying: i64 = 0x36;
                pub const k_EGCMsgSystemBase2: i64 = 0x1F4;
                pub const k_EGCMsgFindAccounts: i64 = 0x4A;
                pub const k_EGCMsgGenericReply: i64 = 0xA;
                pub const k_EGCMsgGetUserStats: i64 = 0x4D;
                pub const k_EGCMsgMemCachedGet: i64 = 0xC8;
                pub const k_EGCMsgMemCachedSet: i64 = 0xCA;
                pub const k_EGCMsgMultiplexMsg: i64 = 0x61;
                pub const k_EGCMsgPreTestSetup: i64 = 0x45;
                pub const k_EGCMsgStartPlaying: i64 = 0x35;
                pub const k_EGCMsgGetIPLocation: i64 = 0x52;
                pub const k_EGCMsgReportMetrics: i64 = 0x218;
                pub const k_EGCMsgUpdateSession: i64 = 0x1F7;
                pub const k_EGCMsgAddFreeLicense: i64 = 0x50;
                pub const k_EGCMsgAppInfoUpdated: i64 = 0x3F;
                pub const k_EGCMsgGetClanDetails: i64 = 0x21A;
                pub const k_EGCMsgGetSystemStats: i64 = 0x55;
                pub const k_EGCMsgGrantGuestPass: i64 = 0x5B;
                pub const k_EGCMsgMemCachedStats: i64 = 0xCC;
                pub const k_EGCMsgStopGameserver: i64 = 0x38;
                pub const k_EGCMsgCheckFriendship: i64 = 0x1F9;
                pub const k_EGCMsgGetPersonaNames: i64 = 0x5F;
                pub const k_EGCMsgMemCachedDelete: i64 = 0xCB;
                pub const k_EGCMsgSendHTTPRequest: i64 = 0x43;
                pub const k_EGCMsgStartGameserver: i64 = 0x37;
                pub const k_EGCMsgValidateSession: i64 = 0x40;
                pub const k_EGCMsgGetEmailTemplate: i64 = 0x59;
                pub const k_EGCMsgWebAPIJobRequest: i64 = 0x66;
                pub const k_EGCMsgAppCheersReceived: i64 = 0x215;
                pub const k_EGCMsgGetAccountDetails: i64 = 0x5D;
                pub const k_EGCMsgInviteUserToLobby: i64 = 0x20B;
                pub const k_EGCMsgSendEmailResponse: i64 = 0x58;
                pub const k_EGCMsgSystemStatsSchema: i64 = 0x54;
                pub const k_EGCMsgAchievementAwarded: i64 = 0x33;
                pub const k_EGCMsgDPPartnerMicroTxns: i64 = 0x200;
                pub const k_EGCMsgMasterSetDirectory: i64 = 0xDC;
                pub const k_EGCMsgSetOptionsResponse: i64 = 0xE3;
                pub const k_EGCMsgDirectServiceMethod: i64 = 0x213;
                pub const k_EGCMsgGetCommandsResponse: i64 = 0x4F;
                pub const k_EGCMsgRecordSupportAction: i64 = 0x46;
                pub const k_EGCMsgGetUserStatsResponse: i64 = 0x3E;
                pub const k_EGCMsgMemCachedGetResponse: i64 = 0xC9;
                pub const k_EGCMsgMultiplexMsgResponse: i64 = 0x62;
                pub const k_EGCMsgGetIPLocationResponse: i64 = 0x53;
                pub const k_EGCMsgGetPartnerAccountLink: i64 = 0x1FB;
                pub const k_EGCMsgReportMetricsResponse: i64 = 0x219;
                pub const k_EGCMsgVacVerificationChange: i64 = 0x206;
                pub const k_EGCMsgAddFreeLicenseResponse: i64 = 0x51;
                pub const k_EGCMsgGetClanDetailsResponse: i64 = 0x21B;
                pub const k_EGCMsgGetPurchaseTrustStatus: i64 = 0x1F5;
                pub const k_EGCMsgGetSystemStatsResponse: i64 = 0x56;
                pub const k_EGCMsgGetUserGameStatsSchema: i64 = 0x3B;
                pub const k_EGCMsgGetUserStatsDEPRECATED: i64 = 0x3D;
                pub const k_EGCMsgGrantGuestPassResponse: i64 = 0x5C;
                pub const k_EGCMsgLookupAccountFromInput: i64 = 0x42;
                pub const k_EGCMsgMasterSetWebAPIRouting: i64 = 0xDE;
                pub const k_EGCMsgMemCachedStatsResponse: i64 = 0xCD;
                pub const k_EGCMsgReceiveInterAppMessage: i64 = 0x49;
                pub const k_EGCMsgCheckFriendshipResponse: i64 = 0x1FA;
                pub const k_EGCMsgGetPersonaNamesResponse: i64 = 0x60;
                pub const k_EGCMsgSendHTTPRequestResponse: i64 = 0x44;
                pub const k_EGCMsgValidateSessionResponse: i64 = 0x41;
                pub const k_EGCMsgAccountPhoneNumberChange: i64 = 0x207;
                pub const k_EGCMsgAppCheersGetAllowedTypes: i64 = 0x216;
                pub const k_EGCMsgGCAccountVacStatusChange: i64 = 0x1F8;
                pub const k_EGCMsgGetEmailTemplateResponse: i64 = 0x5A;
                pub const k_EGCMsgWebAPIRegisterInterfaces: i64 = 0x65;
                pub const k_EGCMsgGetAccountDetailsResponse: i64 = 0x5E;
                pub const k_EGCMsgMasterSetClientMsgRouting: i64 = 0xE0;
                pub const k_EGCMsgDPPartnerMicroTxnsResponse: i64 = 0x201;
                pub const k_EGCMsgMasterSetDirectoryResponse: i64 = 0xDD;
                pub const k_EGCMsgDirectServiceMethodResponse: i64 = 0x214;
                pub const k_EGCMsgGetAccountDetails_DEPRECATED: i64 = 0x47;
                pub const k_EGCMsgWebAPIJobRequestHttpResponse: i64 = 0x68;
                pub const k_EGCMsgGetPartnerAccountLinkResponse: i64 = 0x1FC;
                pub const k_EGCMsgGetPurchaseTrustStatusResponse: i64 = 0x1F6;
                pub const k_EGCMsgGetUserGameStatsSchemaResponse: i64 = 0x3C;
                pub const k_EGCMsgMasterSetWebAPIRoutingResponse: i64 = 0xDF;
                pub const k_EGCMsgWebAPIJobRequestForwardResponse: i64 = 0x69;
                pub const k_EGCMsgAppCheersGetAllowedTypesResponse: i64 = 0x217;
                pub const k_EGCMsgGetGamePersonalDataEntriesRequest: i64 = 0x20E;
                pub const k_EGCMsgMasterSetClientMsgRoutingResponse: i64 = 0xE1;
                pub const k_EGCMsgRecurringSubscriptionStatusChange: i64 = 0x212;
                pub const k_EGCMsgGetGamePersonalDataEntriesResponse: i64 = 0x20F;
                pub const k_EGCMsgGetGamePersonalDataCategoriesRequest: i64 = 0x20C;
                pub const k_EGCMsgGetGamePersonalDataCategoriesResponse: i64 = 0x20D;
                pub const k_EGCMsgTerminateGamePersonalDataEntriesRequest: i64 = 0x210;
                pub const k_EGCMsgTerminateGamePersonalDataEntriesResponse: i64 = 0x211;
            };
            pub const EKillTypes_t = struct {
                pub const KILL_BURN: i64 = 0x4;
                pub const KILL_NONE: i64 = 0x0;
                pub const KILL_BLAST: i64 = 0x3;
                pub const KILL_SHOCK: i64 = 0x6;
                pub const KILL_SLASH: i64 = 0x5;
                pub const KILL_DEFAULT: i64 = 0x1;
                pub const KILL_HEADSHOT: i64 = 0x2;
                pub const KILLTYPE_COUNT: i64 = 0x7;
            };
            pub const EUnlockStyle = struct {
                pub const k_UnlockStyle_Succeeded: i64 = 0x0;
                pub const k_UnlockStyle_Failed_PreReq: i64 = 0x1;
                pub const k_UnlockStyle_Failed_CantAfford: i64 = 0x2;
                pub const k_UnlockStyle_Failed_CantCommit: i64 = 0x3;
                pub const k_UnlockStyle_Failed_CantLockCache: i64 = 0x4;
                pub const k_UnlockStyle_Failed_CantAffordAttrib: i64 = 0x5;
            };
            pub const GLOBALESTATE = struct {
                pub const GLOBAL_ON: i64 = 0x1;
                pub const GLOBAL_OFF: i64 = 0x0;
                pub const GLOBAL_DEAD: i64 = 0x2;
            };
            pub const NET_Messages = struct {
                pub const net_NOP: i64 = 0x0;
                pub const net_Tick: i64 = 0x4;
                pub const net_SetConVar: i64 = 0x6;
                pub const net_StringCmd: i64 = 0x5;
                pub const net_SignonState: i64 = 0x7;
                pub const net_DebugOverlay: i64 = 0xF;
                pub const net_SpawnGroup_Load: i64 = 0x8;
                pub const net_SplitScreenUser: i64 = 0x3;
                pub const net_Disconnect_Legacy: i64 = 0x1;
                pub const net_SpawnGroup_Unload: i64 = 0xC;
                pub const net_SpawnGroup_LoadCompleted: i64 = 0xD;
                pub const net_SpawnGroup_ManifestUpdate: i64 = 0x9;
                pub const net_SpawnGroup_SetCreationTick: i64 = 0xB;
            };
            pub const PrefetchType = struct {
                pub const PFT_SOUND: i64 = 0x0;
            };
            pub const RenderMode_t = struct {
                pub const kRenderNone: i64 = 0x2;
                pub const kRenderNormal: i64 = 0x0;
                pub const kRenderModeCount: i64 = 0x3;
                pub const kRenderTransAlpha: i64 = 0x1;
            };
            pub const SVC_Messages = struct {
                pub const svc_Menu: i64 = 0x39;
                pub const svc_Print: i64 = 0x30;
                pub const svc_Sounds: i64 = 0x31;
                pub const svc_SetView: i64 = 0x32;
                pub const svc_BSPDecal: i64 = 0x35;
                pub const svc_PeerList: i64 = 0x3C;
                pub const svc_Prefetch: i64 = 0x38;
                pub const svc_SetPause: i64 = 0x2B;
                pub const svc_UserCmds: i64 = 0x4C;
                pub const svc_ClassInfo: i64 = 0x2A;
                pub const svc_StopSound: i64 = 0x3B;
                pub const svc_VoiceData: i64 = 0x2F;
                pub const svc_VoiceInit: i64 = 0x2E;
                pub const svc_HLTVStatus: i64 = 0x3E;
                pub const svc_ServerInfo: i64 = 0x28;
                pub const svc_SplitScreen: i64 = 0x36;
                pub const svc_UserMessage: i64 = 0x48;
                pub const svc_CmdKeyValues: i64 = 0x34;
                pub const svc_GetCvarValue: i64 = 0x3A;
                pub const svc_EncryptedData: i64 = 0x4E;
                pub const svc_ServerSteamID: i64 = 0x3F;
                pub const svc_FullFrameSplit: i64 = 0x46;
                pub const svc_PacketEntities: i64 = 0x37;
                pub const svc_PacketReliable: i64 = 0x3D;
                pub const svc_NextMsgPredicted: i64 = 0x4D;
                pub const svc_Broadcast_Command: i64 = 0x4A;
                pub const svc_CreateStringTable: i64 = 0x2C;
                pub const svc_RconServerDetails: i64 = 0x47;
                pub const svc_UpdateStringTable: i64 = 0x2D;
                pub const svc_FlattenedSerializer: i64 = 0x29;
                pub const svc_ClearAllStringTables: i64 = 0x33;
                pub const svc_HltvFixupOperatorStatus: i64 = 0x4B;
            };
            pub const ShadowType_t = struct {
                pub const SHADOWS_NONE: i64 = 0x0;
                pub const SHADOWS_SIMPLE: i64 = 0x1;
            };
            pub const ShardSolid_t = struct {
                pub const SHARD_SOLID: i64 = 0x0;
                pub const SHARD_DEBRIS: i64 = 0x1;
            };
            pub const StanceType_t = struct {
                pub const NUM_STANCES: i64 = 0x3;
                pub const STANCE_PRONE: i64 = 0x2;
                pub const STANCE_CURRENT: i64 = -0x1;
                pub const STANCE_DEFAULT: i64 = 0x0;
                pub const STANCE_CROUCHING: i64 = 0x1;
            };
            pub const TOGGLE_STATE = struct {
                pub const DOOR_OPEN: i64 = 0x0;
                pub const TS_AT_TOP: i64 = 0x0;
                pub const DOOR_CLOSED: i64 = 0x1;
                pub const TS_GOING_UP: i64 = 0x2;
                pub const DOOR_CLOSING: i64 = 0x3;
                pub const DOOR_OPENING: i64 = 0x2;
                pub const TS_AT_BOTTOM: i64 = 0x1;
                pub const TS_GOING_DOWN: i64 = 0x3;
            };
            pub const WaterLevel_t = struct {
                pub const WL_Feet: i64 = 0x1;
                pub const WL_Chest: i64 = 0x4;
                pub const WL_Count: i64 = 0x6;
                pub const WL_Knees: i64 = 0x2;
                pub const WL_Waist: i64 = 0x3;
                pub const WL_NotInWater: i64 = 0x0;
                pub const WL_FullyUnderwater: i64 = 0x5;
            };
            pub const CSPlayerState = struct {
                pub const STATE_ACTIVE: i64 = 0x0;
                pub const STATE_DORMANT: i64 = 0x8;
                pub const STATE_WELCOME: i64 = 0x1;
                pub const STATE_DEATH_ANIM: i64 = 0x4;
                pub const NUM_PLAYER_STATES: i64 = 0x9;
                pub const STATE_PICKINGTEAM: i64 = 0x2;
                pub const STATE_PICKINGCLASS: i64 = 0x3;
                pub const STATE_OBSERVER_MODE: i64 = 0x6;
                pub const STATE_GUNGAME_RESPAWN: i64 = 0x7;
                pub const STATE_DEATH_WAIT_FOR_KEY: i64 = 0x5;
            };
            pub const DamageTypes_t = struct {
                pub const DMG_ACID: i64 = 0x40000;
                pub const DMG_BURN: i64 = 0x8;
                pub const DMG_CLUB: i64 = 0x80;
                pub const DMG_FALL: i64 = 0x20;
                pub const DMG_BLAST: i64 = 0x40;
                pub const DMG_CRUSH: i64 = 0x1;
                pub const DMG_DROWN: i64 = 0x4000;
                pub const DMG_SHOCK: i64 = 0x100;
                pub const DMG_SLASH: i64 = 0x4;
                pub const DMG_SONIC: i64 = 0x200;
                pub const DMG_BULLET: i64 = 0x2;
                pub const DMG_POISON: i64 = 0x8000;
                pub const DMG_GENERIC: i64 = 0x0;
                pub const DMG_VEHICLE: i64 = 0x10;
                pub const DMG_BUCKSHOT: i64 = 0x800;
                pub const DMG_DISSOLVE: i64 = 0x2000;
                pub const DMG_HEADSHOT: i64 = 0x80000;
                pub const DMG_RADIATION: i64 = 0x10000;
                pub const DMG_ENERGYBEAM: i64 = 0x400;
                pub const DMG_DROWNRECOVER: i64 = 0x20000;
                pub const DMG_BLAST_SURFACE: i64 = 0x1000;
                pub const DMG_LASTGENERICFLAG: i64 = 0x40000;
            };
            pub const Disposition_t = struct {
                pub const D_ER: i64 = 0x0;
                pub const D_FR: i64 = 0x2;
                pub const D_HT: i64 = 0x1;
                pub const D_LI: i64 = 0x3;
                pub const D_NU: i64 = 0x4;
                pub const D_FEAR: i64 = 0x2;
                pub const D_HATE: i64 = 0x1;
                pub const D_LIKE: i64 = 0x3;
                pub const D_ERROR: i64 = 0x0;
                pub const D_NEUTRAL: i64 = 0x4;
            };
            pub const EDemoCommands = struct {
                pub const DEM_Max: i64 = 0x13;
                pub const DEM_Stop: i64 = 0x0;
                pub const DEM_Error: i64 = -0x1;
                pub const DEM_Packet: i64 = 0x7;
                pub const DEM_UserCmd: i64 = 0xC;
                pub const DEM_FileInfo: i64 = 0x2;
                pub const DEM_Recovery: i64 = 0x12;
                pub const DEM_SaveGame: i64 = 0xE;
                pub const DEM_SyncTick: i64 = 0x3;
                pub const DEM_ClassInfo: i64 = 0x5;
                pub const DEM_ConsoleCmd: i64 = 0x9;
                pub const DEM_CustomData: i64 = 0xA;
                pub const DEM_FileHeader: i64 = 0x1;
                pub const DEM_FullPacket: i64 = 0xD;
                pub const DEM_SendTables: i64 = 0x4;
                pub const DEM_SpawnGroups: i64 = 0xF;
                pub const DEM_IsCompressed: i64 = 0x40;
                pub const DEM_SignonPacket: i64 = 0x8;
                pub const DEM_StringTables: i64 = 0x6;
                pub const DEM_AnimationData: i64 = 0x10;
                pub const DEM_AnimationHeader: i64 = 0x11;
                pub const DEM_CustomDataCallbacks: i64 = 0xB;
            };
            pub const FixAngleSet_t = struct {
                pub const _None: i64 = 0x0;
                pub const Absolute: i64 = 0x1;
                pub const Relative: i64 = 0x2;
            };
            pub const GrenadeType_t = struct {
                pub const GRENADE_TYPE_FIRE: i64 = 0x2;
                pub const GRENADE_TYPE_DECOY: i64 = 0x3;
                pub const GRENADE_TYPE_FLASH: i64 = 0x1;
                pub const GRENADE_TYPE_SMOKE: i64 = 0x4;
                pub const GRENADE_TYPE_TOTAL: i64 = 0x5;
                pub const GRENADE_TYPE_EXPLOSIVE: i64 = 0x0;
            };
            pub const MoveCollide_t = struct {
                pub const MOVECOLLIDE_COUNT: i64 = 0x4;
                pub const MOVECOLLIDE_DEFAULT: i64 = 0x0;
                pub const MOVECOLLIDE_MAX_BITS: i64 = 0x3;
                pub const MOVECOLLIDE_FLY_SLIDE: i64 = 0x3;
                pub const MOVECOLLIDE_FLY_BOUNCE: i64 = 0x1;
                pub const MOVECOLLIDE_FLY_CUSTOM: i64 = 0x2;
            };
            pub const SignonState_t = struct {
                pub const SIGNONSTATE_NEW: i64 = 0x3;
                pub const SIGNONSTATE_FULL: i64 = 0x6;
                pub const SIGNONSTATE_NONE: i64 = 0x0;
                pub const SIGNONSTATE_SPAWN: i64 = 0x5;
                pub const SIGNONSTATE_PRESPAWN: i64 = 0x4;
                pub const SIGNONSTATE_CHALLENGE: i64 = 0x1;
                pub const SIGNONSTATE_CONNECTED: i64 = 0x2;
                pub const SIGNONSTATE_CHANGELEVEL: i64 = 0x7;
            };
            pub const WeaponSound_t = struct {
                pub const WEAPON_SOUND_DROP: i64 = 0x16;
                pub const WEAPON_SOUND_EMPTY: i64 = 0x0;
                pub const WEAPON_SOUND_IMPACT: i64 = 0xD;
                pub const WEAPON_SOUND_RELOAD: i64 = 0x11;
                pub const WEAPON_SOUND_SINGLE: i64 = 0x2;
                pub const WEAPON_SOUND_REFLECT: i64 = 0xE;
                pub const WEAPON_SOUND_ZOOM_IN: i64 = 0x13;
                pub const WEAPON_SOUND_SPECIAL1: i64 = 0x9;
                pub const WEAPON_SOUND_SPECIAL2: i64 = 0xA;
                pub const WEAPON_SOUND_SPECIAL3: i64 = 0xB;
                pub const WEAPON_SOUND_ZOOM_OUT: i64 = 0x14;
                pub const WEAPON_SOUND_MELEE_HIT: i64 = 0x5;
                pub const WEAPON_SOUND_NUM_TYPES: i64 = 0x18;
                pub const WEAPON_SOUND_RADIO_USE: i64 = 0x17;
                pub const WEAPON_SOUND_MELEE_MISS: i64 = 0x4;
                pub const WEAPON_SOUND_NEARLYEMPTY: i64 = 0xC;
                pub const WEAPON_SOUND_MELEE_HIT_NPC: i64 = 0x8;
                pub const WEAPON_SOUND_MOUSE_PRESSED: i64 = 0x15;
                pub const WEAPON_SOUND_MELEE_HIT_WORLD: i64 = 0x6;
                pub const WEAPON_SOUND_SECONDARY_EMPTY: i64 = 0x1;
                pub const WEAPON_SOUND_SINGLE_ACCURATE: i64 = 0x12;
                pub const WEAPON_SOUND_MELEE_HIT_PLAYER: i64 = 0x7;
                pub const WEAPON_SOUND_SECONDARY_ATTACK: i64 = 0x3;
                pub const WEAPON_SOUND_SECONDARY_IMPACT: i64 = 0xF;
                pub const WEAPON_SOUND_SECONDARY_REFLECT: i64 = 0x10;
            };
            pub const AmmoPosition_t = struct {
                pub const AMMO_POSITION_COUNT: i64 = 0x2;
                pub const AMMO_POSITION_INVALID: i64 = -0x1;
                pub const AMMO_POSITION_PRIMARY: i64 = 0x0;
                pub const AMMO_POSITION_SECONDARY: i64 = 0x1;
            };
            pub const AnimLoopMode_t = struct {
                pub const ANIM_LOOP_MODE_COUNT: i64 = 0x3;
                pub const ANIM_LOOP_MODE_INVALID: i64 = -0x1;
                pub const ANIM_LOOP_MODE_LOOPING: i64 = 0x1;
                pub const ANIM_LOOP_MODE_NOT_LOOPING: i64 = 0x0;
                pub const ANIM_LOOP_MODE_USE_SEQUENCE_SETTINGS: i64 = 0x2;
            };
            pub const CSWeaponNameID = struct {
                pub const WEAPONID_C4: i64 = 0x29;
                pub const WEAPONID_AUG: i64 = 0xF;
                pub const WEAPONID_AWP: i64 = 0x1C;
                pub const WEAPONID_MP7: i64 = 0x14;
                pub const WEAPONID_MP9: i64 = 0x15;
                pub const WEAPONID_P90: i64 = 0x16;
                pub const WEAPONID_AK47: i64 = 0xA;
                pub const WEAPONID_M249: i64 = 0x20;
                pub const WEAPONID_M4A1: i64 = 0xB;
                pub const WEAPONID_MAG7: i64 = 0x18;
                pub const WEAPONID_NOVA: i64 = 0x19;
                pub const WEAPONID_P250: i64 = 0x6;
                pub const WEAPONID_TEC9: i64 = 0x8;
                pub const WEAPONID_BIZON: i64 = 0x11;
                pub const WEAPONID_CZ75A: i64 = 0x2;
                pub const WEAPONID_DECOY: i64 = 0x23;
                pub const WEAPONID_ELITE: i64 = 0x3;
                pub const WEAPONID_FAMAS: i64 = 0xD;
                pub const WEAPONID_G3SG1: i64 = 0x1E;
                pub const WEAPONID_GLOCK: i64 = 0x0;
                pub const WEAPONID_KNIFE: i64 = 0x2B;
                pub const WEAPONID_MAC10: i64 = 0x12;
                pub const WEAPONID_MP5SD: i64 = 0x13;
                pub const WEAPONID_NEGEV: i64 = 0x21;
                pub const WEAPONID_SG556: i64 = 0x10;
                pub const WEAPONID_SSG08: i64 = 0x1D;
                pub const WEAPONID_TASER: i64 = 0x22;
                pub const WEAPONID_UMP45: i64 = 0x17;
                pub const WEAPONID_DEAGLE: i64 = 0x4;
                pub const WEAPONID_SCAR20: i64 = 0x1F;
                pub const WEAPONID_XM1014: i64 = 0x1B;
                pub const WEAPONID_BAYONET: i64 = 0x31;
                pub const WEAPONID_GALILAR: i64 = 0xE;
                pub const WEAPONID_HKP2000: i64 = 0x1;
                pub const WEAPONID_KNIFE_T: i64 = 0x2C;
                pub const WEAPONID_MOLOTOV: i64 = 0x27;
                pub const WEAPONID_UNKNOWN: i64 = 0x41;
                pub const WEAPONID_REVOLVER: i64 = 0x7;
                pub const WEAPONID_SAWEDOFF: i64 = 0x1A;
                pub const WEAPONID_FIVESEVEN: i64 = 0x5;
                pub const WEAPONID_FLASHBANG: i64 = 0x24;
                pub const WEAPONID_HEGRENADE: i64 = 0x25;
                pub const WEAPONID_KNIFE_CSS: i64 = 0x2D;
                pub const WEAPONID_KNIFE_GUT: i64 = 0x2F;
                pub const WEAPONID_HEALTHSHOT: i64 = 0x2A;
                pub const WEAPONID_INCGRENADE: i64 = 0x26;
                pub const WEAPONID_KNIFE_CORD: i64 = 0x38;
                pub const WEAPONID_KNIFE_FLIP: i64 = 0x2E;
                pub const WEAPONID_KNIFE_PUSH: i64 = 0x37;
                pub const WEAPONID_KNIFE_CANIS: i64 = 0x39;
                pub const WEAPONID_KNIFE_KUKRI: i64 = 0x40;
                pub const WEAPONID_KNIFE_URSUS: i64 = 0x3A;
                pub const WEAPONID_SMOKEGRENADE: i64 = 0x28;
                pub const WEAPONID_USP_SILENCER: i64 = 0x9;
                pub const WEAPONID_KNIFE_OUTDOOR: i64 = 0x3C;
                pub const WEAPONID_M4A1_SILENCER: i64 = 0xC;
                pub const WEAPONID_KNIFE_FALCHION: i64 = 0x34;
                pub const WEAPONID_KNIFE_KARAMBIT: i64 = 0x30;
                pub const WEAPONID_KNIFE_SKELETON: i64 = 0x3F;
                pub const WEAPONID_KNIFE_STILETTO: i64 = 0x3D;
                pub const WEAPONID_KNIFE_TACTICAL: i64 = 0x33;
                pub const WEAPONID_KNIFE_BUTTERFLY: i64 = 0x36;
                pub const WEAPONID_KNIFE_M9_BAYONET: i64 = 0x32;
                pub const WEAPONID_KNIFE_WIDOWMAKER: i64 = 0x3E;
                pub const WEAPONID_KNIFE_SURVIVAL_BOWIE: i64 = 0x35;
                pub const WEAPONID_KNIFE_GYPSY_JACKKNIFE: i64 = 0x3B;
            };
            pub const EClientUIEvent = struct {
                pub const EClientUIEvent_Invalid: i64 = 0x0;
                pub const EClientUIEvent_FireOutput: i64 = 0x2;
                pub const EClientUIEvent_DialogFinished: i64 = 0x1;
            };
            pub const EGCMsgResponse = struct {
                pub const k_EGCMsgResponseOK: i64 = 0x0;
                pub const k_EGCMsgLimitExceeded: i64 = 0x9;
                pub const k_EGCMsgFailedToCreate: i64 = 0x8;
                pub const k_EGCMsgResponseDenied: i64 = 0x1;
                pub const k_EGCMsgResponseInvalid: i64 = 0x4;
                pub const k_EGCMsgResponseNoMatch: i64 = 0x5;
                pub const k_EGCMsgResponseTimeout: i64 = 0x3;
                pub const k_EGCMsgCommitUnfinalized: i64 = 0xA;
                pub const k_EGCMsgResponseNotLoggedOn: i64 = 0x7;
                pub const k_EGCMsgResponseServerError: i64 = 0x2;
                pub const k_EGCMsgResponseUnknownError: i64 = 0x6;
            };
            pub const EInButtonState = struct {
                pub const IN_BUTTON_UP: i64 = 0x0;
                pub const IN_BUTTON_DOWN: i64 = 0x1;
                pub const IN_BUTTON_DOWN_UP: i64 = 0x2;
                pub const IN_BUTTON_UP_DOWN: i64 = 0x3;
                pub const IN_BUTTON_UP_DOWN_UP: i64 = 0x4;
                pub const IN_BUTTON_STATE_COUNT: i64 = 0x8;
                pub const IN_BUTTON_DOWN_UP_DOWN: i64 = 0x5;
                pub const IN_BUTTON_DOWN_UP_DOWN_UP: i64 = 0x6;
                pub const IN_BUTTON_UP_DOWN_UP_DOWN: i64 = 0x7;
            };
            pub const ETEProtobufIds = struct {
                pub const TE_DustId: i64 = 0x1A4;
                pub const TE_FizzId: i64 = 0x19D;
                pub const TE_DecalId: i64 = 0x19A;
                pub const TE_SmokeId: i64 = 0x1AA;
                pub const TE_ImpactId: i64 = 0x1A0;
                pub const TE_SparksId: i64 = 0x1A6;
                pub const TE_BubblesId: i64 = 0x198;
                pub const TE_BeamEntsId: i64 = 0x193;
                pub const TE_BeamRingId: i64 = 0x195;
                pub const TE_ExplosionId: i64 = 0x1A3;
                pub const TE_BeamPointsId: i64 = 0x194;
                pub const TE_GlowSpriteId: i64 = 0x19F;
                pub const TE_WorldDecalId: i64 = 0x19B;
                pub const TE_BloodStreamId: i64 = 0x1A2;
                pub const TE_BubbleTrailId: i64 = 0x199;
                pub const TE_LargeFunnelId: i64 = 0x1A5;
                pub const TE_MuzzleFlashId: i64 = 0x1A1;
                pub const TE_PhysicsPropId: i64 = 0x1A7;
                pub const TE_BeamEntPointId: i64 = 0x192;
                pub const TE_EnergySplashId: i64 = 0x19C;
                pub const TE_ArmorRicochetId: i64 = 0x191;
                pub const TE_EffectDispatchId: i64 = 0x190;
                pub const TE_ShatterSurfaceId: i64 = 0x19E;
            };
            pub const InputBitMask_t = struct {
                pub const IN_ALL: i64 = -0x1;
                pub const IN_USE: i64 = 0x20;
                pub const IN_BACK: i64 = 0x10;
                pub const IN_DUCK: i64 = 0x4;
                pub const IN_JUMP: i64 = 0x2;
                pub const IN_NONE: i64 = 0x0;
                pub const IN_ZOOM: i64 = 0x400000000;
                pub const IN_SCORE: i64 = 0x200000000;
                pub const IN_SPEED: i64 = 0x10000;
                pub const IN_ATTACK: i64 = 0x1;
                pub const IN_RELOAD: i64 = 0x2000;
                pub const IN_ATTACK2: i64 = 0x800;
                pub const IN_FORWARD: i64 = 0x8;
                pub const IN_MOVELEFT: i64 = 0x200;
                pub const IN_TURNLEFT: i64 = 0x80;
                pub const IN_MOVERIGHT: i64 = 0x400;
                pub const IN_TURNRIGHT: i64 = 0x100;
                pub const IN_USEORRELOAD: i64 = 0x100000000;
                pub const IN_JOYAUTOSPRINT: i64 = 0x20000;
                pub const IN_LOOK_AT_WEAPON: i64 = 0x800000000;
                pub const IN_FIRST_MOD_SPECIFIC_BIT: i64 = 0x100000000;
            };
            pub const ObserverMode_t = struct {
                pub const OBS_MODE_NONE: i64 = 0x0;
                pub const OBS_MODE_CHASE: i64 = 0x3;
                pub const OBS_MODE_FIXED: i64 = 0x1;
                pub const OBS_MODE_IN_EYE: i64 = 0x2;
                pub const OBS_MODE_ROAMING: i64 = 0x4;
                pub const NUM_OBSERVER_MODES: i64 = 0x5;
            };
            pub const RequestPause_t = struct {
                pub const RP_PAUSE: i64 = 0x0;
                pub const RP_UNPAUSE: i64 = 0x1;
                pub const RP_TOGGLEPAUSE: i64 = 0x2;
            };
            pub const RumbleEffect_t = struct {
                pub const RUMBLE_357: i64 = 0x2;
                pub const RUMBLE_AR2: i64 = 0x4;
                pub const RUMBLE_SMG1: i64 = 0x3;
                pub const RUMBLE_PISTOL: i64 = 0x1;
                pub const RUMBLE_DMG_LOW: i64 = 0xF;
                pub const RUMBLE_DMG_MED: i64 = 0x10;
                pub const RUMBLE_INVALID: i64 = -0x1;
                pub const RUMBLE_DMG_HIGH: i64 = 0x11;
                pub const RUMBLE_STOP_ALL: i64 = 0x0;
                pub const RUMBLE_FALL_LONG: i64 = 0x12;
                pub const RUMBLE_FLAT_BOTH: i64 = 0xE;
                pub const RUMBLE_FLAT_LEFT: i64 = 0xC;
                pub const RUMBLE_FALL_SHORT: i64 = 0x13;
                pub const RUMBLE_FLAT_RIGHT: i64 = 0xD;
                pub const NUM_RUMBLE_EFFECTS: i64 = 0x19;
                pub const RUMBLE_AIRBOAT_GUN: i64 = 0xA;
                pub const RUMBLE_RPG_MISSILE: i64 = 0x8;
                pub const RUMBLE_AR2_ALT_FIRE: i64 = 0x7;
                pub const RUMBLE_CROWBAR_SWING: i64 = 0x9;
                pub const RUMBLE_PHYSCANNON_LOW: i64 = 0x16;
                pub const RUMBLE_SHOTGUN_DOUBLE: i64 = 0x6;
                pub const RUMBLE_SHOTGUN_SINGLE: i64 = 0x5;
                pub const RUMBLE_PHYSCANNON_HIGH: i64 = 0x18;
                pub const RUMBLE_PHYSCANNON_OPEN: i64 = 0x14;
                pub const RUMBLE_PHYSCANNON_PUNT: i64 = 0x15;
                pub const RUMBLE_JEEP_ENGINE_LOOP: i64 = 0xB;
                pub const RUMBLE_PHYSCANNON_MEDIUM: i64 = 0x17;
            };
            pub const ShakeCommand_t = struct {
                pub const SHAKE_STOP: i64 = 0x1;
                pub const SHAKE_START: i64 = 0x0;
                pub const SHAKE_DURATION: i64 = 0x6;
                pub const SHAKE_AMPLITUDE: i64 = 0x2;
                pub const SHAKE_FREQUENCY: i64 = 0x3;
                pub const SHAKE_START_NORUMBLE: i64 = 0x5;
                pub const SHAKE_START_RUMBLEONLY: i64 = 0x4;
            };
            pub const loadout_slot_t = struct {
                pub const LOADOUT_SLOT_C4: i64 = 0x1;
                pub const LOADOUT_SLOT_PET: i64 = 0x39;
                pub const LOADOUT_SLOT_SMG0: i64 = 0x8;
                pub const LOADOUT_SLOT_SMG1: i64 = 0x9;
                pub const LOADOUT_SLOT_SMG2: i64 = 0xA;
                pub const LOADOUT_SLOT_SMG3: i64 = 0xB;
                pub const LOADOUT_SLOT_SMG4: i64 = 0xC;
                pub const LOADOUT_SLOT_SMG5: i64 = 0xD;
                pub const LOADOUT_SLOT_COUNT: i64 = 0x3A;
                pub const LOADOUT_SLOT_MELEE: i64 = 0x0;
                pub const LOADOUT_SLOT_MISC0: i64 = 0x2F;
                pub const LOADOUT_SLOT_MISC1: i64 = 0x30;
                pub const LOADOUT_SLOT_MISC2: i64 = 0x31;
                pub const LOADOUT_SLOT_MISC3: i64 = 0x32;
                pub const LOADOUT_SLOT_MISC4: i64 = 0x33;
                pub const LOADOUT_SLOT_MISC5: i64 = 0x34;
                pub const LOADOUT_SLOT_MISC6: i64 = 0x35;
                pub const LOADOUT_SLOT_FLAIR0: i64 = 0x37;
                pub const LOADOUT_SLOT_HEAVY0: i64 = 0x14;
                pub const LOADOUT_SLOT_HEAVY1: i64 = 0x15;
                pub const LOADOUT_SLOT_HEAVY2: i64 = 0x16;
                pub const LOADOUT_SLOT_HEAVY3: i64 = 0x17;
                pub const LOADOUT_SLOT_HEAVY4: i64 = 0x18;
                pub const LOADOUT_SLOT_HEAVY5: i64 = 0x19;
                pub const LOADOUT_SLOT_RIFLE0: i64 = 0xE;
                pub const LOADOUT_SLOT_RIFLE1: i64 = 0xF;
                pub const LOADOUT_SLOT_RIFLE2: i64 = 0x10;
                pub const LOADOUT_SLOT_RIFLE3: i64 = 0x11;
                pub const LOADOUT_SLOT_RIFLE4: i64 = 0x12;
                pub const LOADOUT_SLOT_RIFLE5: i64 = 0x13;
                pub const LOADOUT_SLOT_SPRAY0: i64 = 0x38;
                pub const LOADOUT_SLOT_INVALID: i64 = -0x1;
                pub const LOADOUT_SLOT_GRENADE0: i64 = 0x1A;
                pub const LOADOUT_SLOT_GRENADE1: i64 = 0x1B;
                pub const LOADOUT_SLOT_GRENADE2: i64 = 0x1C;
                pub const LOADOUT_SLOT_GRENADE3: i64 = 0x1D;
                pub const LOADOUT_SLOT_GRENADE4: i64 = 0x1E;
                pub const LOADOUT_SLOT_GRENADE5: i64 = 0x1F;
                pub const LOADOUT_SLOT_MUSICKIT: i64 = 0x36;
                pub const LOADOUT_SLOT_PROMOTED: i64 = -0x2;
                pub const LOADOUT_SLOT_EQUIPMENT0: i64 = 0x20;
                pub const LOADOUT_SLOT_EQUIPMENT1: i64 = 0x21;
                pub const LOADOUT_SLOT_EQUIPMENT2: i64 = 0x22;
                pub const LOADOUT_SLOT_EQUIPMENT3: i64 = 0x23;
                pub const LOADOUT_SLOT_EQUIPMENT4: i64 = 0x24;
                pub const LOADOUT_SLOT_EQUIPMENT5: i64 = 0x25;
                pub const LOADOUT_SLOT_SECONDARY0: i64 = 0x2;
                pub const LOADOUT_SLOT_SECONDARY1: i64 = 0x3;
                pub const LOADOUT_SLOT_SECONDARY2: i64 = 0x4;
                pub const LOADOUT_SLOT_SECONDARY3: i64 = 0x5;
                pub const LOADOUT_SLOT_SECONDARY4: i64 = 0x6;
                pub const LOADOUT_SLOT_SECONDARY5: i64 = 0x7;
                pub const LOADOUT_SLOT_CLOTHING_HAT: i64 = 0x2B;
                pub const LOADOUT_SLOT_LAST_COSMETIC: i64 = 0x29;
                pub const LOADOUT_SLOT_CLOTHING_HANDS: i64 = 0x29;
                pub const LOADOUT_SLOT_CLOTHING_TORSO: i64 = 0x2D;
                pub const LOADOUT_SLOT_FIRST_COSMETIC: i64 = 0x29;
                pub const LOADOUT_SLOT_CLOTHING_EYEWEAR: i64 = 0x2A;
                pub const LOADOUT_SLOT_CLOTHING_FACEMASK: i64 = 0x28;
                pub const LOADOUT_SLOT_LAST_WHEEL_WEAPON: i64 = 0x19;
                pub const LOADOUT_SLOT_CLOTHING_LOWERBODY: i64 = 0x2C;
                pub const LOADOUT_SLOT_FIRST_WHEEL_WEAPON: i64 = 0x2;
                pub const LOADOUT_SLOT_LAST_ALL_CHARACTER: i64 = 0x39;
                pub const LOADOUT_SLOT_LAST_WHEEL_GRENADE: i64 = 0x1F;
                pub const LOADOUT_SLOT_CLOTHING_APPEARANCE: i64 = 0x2E;
                pub const LOADOUT_SLOT_CLOTHING_CUSTOMHEAD: i64 = 0x27;
                pub const LOADOUT_SLOT_FIRST_ALL_CHARACTER: i64 = 0x36;
                pub const LOADOUT_SLOT_FIRST_WHEEL_GRENADE: i64 = 0x1A;
                pub const LOADOUT_SLOT_LAST_PRIMARY_WEAPON: i64 = 0x19;
                pub const LOADOUT_SLOT_FIRST_PRIMARY_WEAPON: i64 = 0x8;
                pub const LOADOUT_SLOT_LAST_AUTO_BUY_WEAPON: i64 = 0x1;
                pub const LOADOUT_SLOT_LAST_WHEEL_EQUIPMENT: i64 = 0x25;
                pub const LOADOUT_SLOT_CLOTHING_CUSTOMPLAYER: i64 = 0x26;
                pub const LOADOUT_SLOT_FIRST_AUTO_BUY_WEAPON: i64 = 0x0;
                pub const LOADOUT_SLOT_FIRST_WHEEL_EQUIPMENT: i64 = 0x20;
            };
            pub const C4LightEffect_t = struct {
                pub const eLightEffectNone: i64 = 0x0;
                pub const eLightEffectDropped: i64 = 0x1;
                pub const eLightEffectThirdPersonHeld: i64 = 0x2;
            };
            pub const EBaseGameEvents = struct {
                pub const GE_PlaceDecalEvent: i64 = 0xC9;
                pub const GE_SosStopSoundEvent: i64 = 0xD1;
                pub const GE_SosStartSoundEvent: i64 = 0xD0;
                pub const GE_ClothEffectAnimEvent: i64 = 0xD6;
                pub const GE_ClearWorldDecalsEvent: i64 = 0xCA;
                pub const GE_ClothStiffenAnimEvent: i64 = 0xD5;
                pub const GE_SosStopSoundEventHash: i64 = 0xD4;
                pub const GE_ClearEntityDecalsEvent: i64 = 0xCB;
                pub const GE_SosSetSoundEventParams: i64 = 0xD2;
                pub const GE_Source1LegacyGameEvent: i64 = 0xCF;
                pub const GE_SosSetLibraryStackFields: i64 = 0xD3;
                pub const GE_VDebugGameSessionIDEvent: i64 = 0xC8;
                pub const GE_ClearDecalsForEntityEvent: i64 = 0xCC;
                pub const GE_Source1LegacyListenEvents: i64 = 0xCE;
                pub const GE_Source1LegacyGameEventList: i64 = 0xCD;
            };
            pub const ECsgoGameEvents = struct {
                pub const GE_FireBulletsId: i64 = 0x1C4;
                pub const GE_RadioIconEventId: i64 = 0x1C3;
                pub const GE_PlayerAnimEventId: i64 = 0x1C2;
                pub const GE_PlayerBulletHitId: i64 = 0x1C5;
            };
            pub const EntityEffects_t = struct {
                pub const EF_NODRAW: i64 = 0x20;
                pub const EF_MAX_BITS: i64 = 0xA;
                pub const EF_NOSHADOW: i64 = 0x10;
                pub const EF_NORECEIVESHADOW: i64 = 0x40;
                pub const EF_PARENT_ANIMATES: i64 = 0x200;
                pub const DEPRICATED_EF_NOINTERP: i64 = 0x8;
                pub const EF_NODRAW_BUT_TRANSMIT: i64 = 0x400;
            };
            pub const HierarchyType_t = struct {
                pub const HIERARCHY_BONE: i64 = 0x4;
                pub const HIERARCHY_NONE: i64 = 0x0;
                pub const HIERARCHY_ABSORIGIN: i64 = 0x3;
                pub const HIERARCHY_ATTACHMENT: i64 = 0x2;
                pub const HIERARCHY_BONE_MERGE: i64 = 0x1;
                pub const HIERARCHY_TYPE_COUNT: i64 = 0x5;
            };
            pub const ItemFlagTypes_t = struct {
                pub const ITEM_FLAG_NONE: i64 = 0x0;
                pub const ITEM_FLAG_EXHAUSTIBLE: i64 = 0x10;
                pub const ITEM_FLAG_LIMITINWORLD: i64 = 0x8;
                pub const ITEM_FLAG_NOAUTORELOAD: i64 = 0x2;
                pub const ITEM_FLAG_NOITEMPICKUP: i64 = 0x80;
                pub const ITEM_FLAG_NOAMMOPICKUPS: i64 = 0x40;
                pub const ITEM_FLAG_DOHITLOCATIONDMG: i64 = 0x20;
                pub const ITEM_FLAG_NOAUTOSWITCHEMPTY: i64 = 0x4;
                pub const ITEM_FLAG_CAN_SELECT_WITHOUT_AMMO: i64 = 0x1;
            };
            pub const NavScopeFlags_t = struct {
                pub const eAir: i64 = 0x2;
                pub const eAll: i64 = 0x3;
                pub const eNone: i64 = 0x0;
                pub const eGround: i64 = 0x1;
            };
            pub const eSplinePushType = struct {
                pub const k_eSplinePushAway: i64 = 0x1;
                pub const k_eSplinePushAlong: i64 = 0x0;
                pub const k_eSplinePushTowards: i64 = 0x2;
            };
            pub const navproperties_t = struct {
                pub const NAV_IGNORE: i64 = 0x1;
            };
            pub const soundcommands_t = struct {
                pub const SOUNDCTRL_STOP: i64 = 0x2;
                pub const SOUNDCTRL_DESTROY: i64 = 0x3;
                pub const SOUNDCTRL_FADEOUT: i64 = 0x4;
                pub const SOUNDCTRL_CHANGE_PITCH: i64 = 0x1;
                pub const SOUNDCTRL_CHANGE_VOLUME: i64 = 0x0;
            };
            pub const CSWeaponCategory = struct {
                pub const WEAPONCATEGORY_SMG: i64 = 0x3;
                pub const WEAPONCATEGORY_COUNT: i64 = 0x6;
                pub const WEAPONCATEGORY_HEAVY: i64 = 0x5;
                pub const WEAPONCATEGORY_MELEE: i64 = 0x1;
                pub const WEAPONCATEGORY_OTHER: i64 = 0x0;
                pub const WEAPONCATEGORY_RIFLE: i64 = 0x4;
                pub const WEAPONCATEGORY_SECONDARY: i64 = 0x2;
            };
            pub const ChatIgnoreType_t = struct {
                pub const CHAT_IGNORE_ALL: i64 = 0x1;
                pub const CHAT_IGNORE_NONE: i64 = 0x0;
                pub const CHAT_IGNORE_TEAM: i64 = 0x2;
            };
            pub const EChickenActivity = struct {
                pub const Run: i64 = 0x3;
                pub const Feed: i64 = 0x9;
                pub const Idle: i64 = 0x0;
                pub const Land: i64 = 0x5;
                pub const Walk: i64 = 0x2;
                pub const Glide: i64 = 0x4;
                pub const Panic: i64 = 0x6;
                pub const Sleep: i64 = 0xA;
                pub const Squat: i64 = 0x1;
                pub const Trick: i64 = 0x7;
                pub const Shoulder: i64 = 0xB;
                pub const LowOnFood: i64 = 0xC;
                pub const TurnInPlace: i64 = 0x8;
            };
            pub const EGCBaseClientMsg = struct {
                pub const k_EMsgGCClientHello: i64 = 0xFA6;
                pub const k_EMsgGCServerHello: i64 = 0xFA7;
                pub const k_EMsgGCClientHelloPW: i64 = 0xFAC;
                pub const k_EMsgGCClientHelloR2: i64 = 0xFAD;
                pub const k_EMsgGCClientHelloR3: i64 = 0xFAE;
                pub const k_EMsgGCClientHelloR4: i64 = 0xFAF;
                pub const k_EMsgGCClientWelcome: i64 = 0xFA4;
                pub const k_EMsgGCServerWelcome: i64 = 0xFA5;
                pub const k_EMsgGCClientHelloPartner: i64 = 0xFAB;
                pub const k_EMsgGCClientConnectionStatus: i64 = 0xFA9;
                pub const k_EMsgGCServerConnectionStatus: i64 = 0xFAA;
            };
            pub const EHapticPulseType = struct {
                pub const VR_HAND_HAPTIC_PULSE_LIGHT: i64 = 0x0;
                pub const VR_HAND_HAPTIC_PULSE_MEDIUM: i64 = 0x1;
                pub const VR_HAND_HAPTIC_PULSE_STRONG: i64 = 0x2;
            };
            pub const GCProtoBufMsgSrc = struct {
                pub const GCProtoBufMsgSrc_FromGC: i64 = 0x3;
                pub const GCProtoBufMsgSrc_FromSystem: i64 = 0x1;
                pub const GCProtoBufMsgSrc_FromSteamID: i64 = 0x2;
                pub const GCProtoBufMsgSrc_ReplySystem: i64 = 0x4;
                pub const GCProtoBufMsgSrc_Unspecified: i64 = 0x0;
            };
            pub const HoverPoseFlags_t = struct {
                pub const eNone: i64 = 0x0;
                pub const eAngles: i64 = 0x2;
                pub const ePosition: i64 = 0x1;
            };
            pub const NavAttributeEnum = struct {
                pub const NAV_MESH_RUN: i64 = 0x20;
                pub const NAV_MESH_JUMP: i64 = 0x2;
                pub const NAV_MESH_NONE: i64 = 0x0;
                pub const NAV_MESH_STOP: i64 = 0x10;
                pub const NAV_MESH_WALK: i64 = 0x40;
                pub const NAV_MESH_AVOID: i64 = 0x80;
                pub const NAV_MESH_STAND: i64 = 0x400;
                pub const NAV_MESH_STAIRS: i64 = 0x1000;
                pub const NAV_MESH_NON_ZUP: i64 = 0x8000;
                pub const NAV_MESH_NO_JUMP: i64 = 0x8;
                pub const NAV_MESH_NO_MERGE: i64 = 0x2000;
                pub const NAV_MESH_DONT_HIDE: i64 = 0x200;
                pub const NAV_MESH_TRANSIENT: i64 = 0x100;
                pub const NAV_ATTR_LAST_INDEX: i64 = 0x3F;
                pub const NAV_MESH_NO_HOSTAGES: i64 = 0x800;
                pub const NAV_MESH_CRAWL_HEIGHT: i64 = 0x40000;
                pub const NAV_MESH_OBSTACLE_TOP: i64 = 0x4000;
                pub const NAV_MESH_CROUCH_HEIGHT: i64 = 0x10000;
                pub const NAV_ATTR_FIRST_GAME_INDEX: i64 = 0x13;
                pub const NAV_MESH_NON_ZUP_TRANSITION: i64 = 0x20000;
            };
            pub const PARTICLE_MESSAGE = struct {
                pub const GAME_PARTICLE_MANAGER_EVENT_CREATE: i64 = 0x0;
                pub const GAME_PARTICLE_MANAGER_EVENT_FROZEN: i64 = 0xC;
                pub const GAME_PARTICLE_MANAGER_EVENT_UPDATE: i64 = 0x1;
                pub const GAME_PARTICLE_MANAGER_EVENT_ADD_FAN: i64 = 0x24;
                pub const GAME_PARTICLE_MANAGER_EVENT_DESTROY: i64 = 0x7;
                pub const GAME_PARTICLE_MANAGER_EVENT_LATENCY: i64 = 0xA;
                pub const GAME_PARTICLE_MANAGER_EVENT_RELEASE: i64 = 0x9;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_TEXT: i64 = 0x10;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_VDATA: i64 = 0x22;
                pub const GAME_PARTICLE_MANAGER_EVENT_CAN_FREEZE: i64 = 0x19;
                pub const GAME_PARTICLE_MANAGER_EVENT_REMOVE_FAN: i64 = 0x27;
                pub const GAME_PARTICLE_MANAGER_EVENT_UPDATE_ENT: i64 = 0x5;
                pub const GAME_PARTICLE_MANAGER_EVENT_UPDATE_FAN: i64 = 0x25;
                pub const GAME_PARTICLE_MANAGER_EVENT_SHOULD_DRAW: i64 = 0xB;
                pub const GAME_PARTICLE_MANAGER_EVENT_SKIP_TO_TIME: i64 = 0x18;
                pub const GAME_PARTICLE_MANAGER_EVENT_DESTROY_NAMED: i64 = 0x17;
                pub const GAME_PARTICLE_MANAGER_EVENT_UPDATE_OFFSET: i64 = 0x6;
                pub const GAME_PARTICLE_MANAGER_EVENT_UPDATE_FORWARD: i64 = 0x2;
                pub const GAME_PARTICLE_MANAGER_EVENT_UPDATE_FALLBACK: i64 = 0x4;
                pub const GAME_PARTICLE_MANAGER_EVENT_FREEZE_INVOLVING: i64 = 0x1D;
                pub const GAME_PARTICLE_MANAGER_EVENT_UPDATE_TRANSFORM: i64 = 0x1B;
                pub const GAME_PARTICLE_MANAGER_EVENT_CREATE_SMOKE_GRID: i64 = 0x28;
                pub const GAME_PARTICLE_MANAGER_EVENT_DESTROY_INVOLVING: i64 = 0x8;
                pub const GAME_PARTICLE_MANAGER_EVENT_CREATE_PHYSICS_SIM: i64 = 0x20;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_CLUSTER_GROWTH: i64 = 0x26;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_FOW_PROPERTIES: i64 = 0xF;
                pub const GAME_PARTICLE_MANAGER_EVENT_UPDATE_ORIENTATION: i64 = 0x3;
                pub const GAME_PARTICLE_MANAGER_EVENT_DESTROY_PHYSICS_SIM: i64 = 0x21;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_OVERRIDE_TEXTURE: i64 = 0x29;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_SHOULD_CHECK_FOW: i64 = 0x11;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_MATERIAL_OVERRIDE: i64 = 0x23;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_TEXTURE_ATTRIBUTE: i64 = 0x14;
                pub const GAME_PARTICLE_MANAGER_EVENT_UPDATE_ENTITY_POSITION: i64 = 0xE;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_CONTROL_POINT_MODEL: i64 = 0x12;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_NAMED_VALUE_CONTEXT: i64 = 0x1A;
                pub const GAME_PARTICLE_MANAGER_EVENT_CLEAR_MODELLIST_OVERRIDE: i64 = 0x1F;
                pub const GAME_PARTICLE_MANAGER_EVENT_FREEZE_TRANSITION_OVERRIDE: i64 = 0x1C;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_CONTROL_POINT_SNAPSHOT: i64 = 0x13;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_SCENE_OBJECT_GENERIC_FLAG: i64 = 0x15;
                pub const GAME_PARTICLE_MANAGER_EVENT_ADD_MODELLIST_OVERRIDE_ELEMENT: i64 = 0x1E;
                pub const GAME_PARTICLE_MANAGER_EVENT_CHANGE_CONTROL_POINT_ATTACHMENT: i64 = 0xD;
                pub const GAME_PARTICLE_MANAGER_EVENT_SET_SCENE_OBJECT_TINT_AND_DESAT: i64 = 0x16;
            };
            pub const BrushSolidities_e = struct {
                pub const BRUSHSOLID_NEVER: i64 = 0x1;
                pub const BRUSHSOLID_ALWAYS: i64 = 0x2;
                pub const BRUSHSOLID_TOGGLE: i64 = 0x0;
            };
            pub const CanPlaySequence_t = struct {
                pub const CANNOT_PLAY: i64 = 0x0;
                pub const CAN_PLAY_NOW: i64 = 0x1;
                pub const CAN_PLAY_ENQUEUED: i64 = 0x2;
            };
            pub const EBaseUserMessages = struct {
                pub const UM_Fade: i64 = 0x6A;
                pub const UM_Shake: i64 = 0x78;
                pub const UM_HudMsg: i64 = 0x6E;
                pub const UM_Rumble: i64 = 0x74;
                pub const UM_HudText: i64 = 0x6F;
                pub const UM_SayText: i64 = 0x75;
                pub const UM_TextMsg: i64 = 0x7C;
                pub const UM_HudError: i64 = 0x92;
                pub const UM_MAX_BASE: i64 = 0xC8;
                pub const UM_ResetHUD: i64 = 0x73;
                pub const UM_SayText2: i64 = 0x76;
                pub const UM_ShakeDir: i64 = 0x79;
                pub const UM_ShowMenu: i64 = 0x86;
                pub const UM_GameTitle: i64 = 0x6B;
                pub const UM_SendAudio: i64 = 0x82;
                pub const UM_VoiceMask: i64 = 0x80;
                pub const UM_AmmoDenied: i64 = 0x84;
                pub const UM_CreditsMsg: i64 = 0x87;
                pub const UM_ItemPickup: i64 = 0x83;
                pub const UM_ScreenTilt: i64 = 0x7D;
                pub const UM_WaterShake: i64 = 0x7A;
                pub const UM_ColoredText: i64 = 0x71;
                pub const UM_UsageReport: i64 = 0xA8;
                pub const UM_RequestState: i64 = 0x72;
                pub const UM_ExtraUserData: i64 = 0xA4;
                pub const UM_AudioParameter: i64 = 0x90;
                pub const UM_SayTextChannel: i64 = 0x77;
                pub const UM_UserSentBugBug: i64 = 0xA7;
                pub const UM_AnimGraphUpdate: i64 = 0x95;
                pub const UM_CustomGameEvent: i64 = 0x94;
                pub const UM_ParticleManager: i64 = 0x91;
                pub const UM_ServerFrameTime: i64 = 0x9A;
                pub const UM_AchievementEvent: i64 = 0x65;
                pub const UM_CameraTransition: i64 = 0x8F;
                pub const UM_CurrentTimescale: i64 = 0x68;
                pub const UM_DesiredTimescale: i64 = 0x69;
                pub const UM_RequestDllStatus: i64 = 0x9C;
                pub const UM_RequestInventory: i64 = 0xA0;
                pub const UM_UpdateCssClasses: i64 = 0x99;
                pub const UM_DllStatusResponse: i64 = 0x9F;
                pub const UM_InventoryResponse: i64 = 0xA1;
                pub const UM_RequestDiagnostic: i64 = 0xA2;
                pub const UM_RequestUtilAction: i64 = 0x9D;
                pub const UM_DiagnosticResponse: i64 = 0xA3;
                pub const UM_UtilActionResponse: i64 = 0x9E;
                pub const UM_HapticsManagerPulse: i64 = 0x96;
                pub const UM_NotifyResponseFound: i64 = 0xA5;
                pub const UM_RemoteServerCommand: i64 = 0xA9;
                pub const UM_HapticsManagerEffect: i64 = 0x97;
                pub const UM_LagCompensationError: i64 = 0x9B;
                pub const UM_RemoteServerResponse: i64 = 0xAA;
                pub const UM_CloseCaptionPlaceholder: i64 = 0x8E;
                pub const UM_PlayResponseConditional: i64 = 0xA6;
            };
            pub const EntFinderMethod_t = struct {
                pub const ENT_FIND_METHOD_RANDOM: i64 = 0x2;
                pub const ENT_FIND_METHOD_NEAREST: i64 = 0x0;
                pub const ENT_FIND_METHOD_FARTHEST: i64 = 0x1;
            };
            pub const GC_BannedWordType = struct {
                pub const GC_BANNED_WORD_ENABLE_WORD: i64 = 0x1;
                pub const GC_BANNED_WORD_DISABLE_WORD: i64 = 0x0;
            };
            pub const PerformanceMode_t = struct {
                pub const PM_NORMAL: i64 = 0x0;
                pub const PM_NO_GIBS: i64 = 0x1;
            };
            pub const ReplayEventType_t = struct {
                pub const REPLAY_EVENT_DEATH: i64 = 0x1;
                pub const REPLAY_EVENT_CANCEL: i64 = 0x0;
                pub const REPLAY_EVENT_GENERIC: i64 = 0x2;
                pub const REPLAY_EVENT_VICTORY: i64 = 0x4;
                pub const REPLAY_EVENT_STUCK_NEED_FULL_UPDATE: i64 = 0x3;
            };
            pub const ScriptedOnDeath_t = struct {
                pub const SS_ONDEATH_RAGDOLL: i64 = 0x1;
                pub const SS_ONDEATH_UNDEFINED: i64 = 0x0;
                pub const SS_ONDEATH_ANIMATED_DEATH: i64 = 0x2;
                pub const SS_ONDEATH_NOT_APPLICABLE: i64 = -0x1;
            };
            pub const SpawnGroupFlags_t = struct {
                pub const SPAWN_GROUP_SYNCHRONOUS_SPAWN: i64 = 0x4;
                pub const SPAWN_GROUP_BLOCK_UNTIL_LOADED: i64 = 0x40;
                pub const SPAWN_GROUP_DONT_SPAWN_ENTITIES: i64 = 0x2;
                pub const SPAWN_GROUP_LOAD_STREAMING_DATA: i64 = 0x80;
                pub const SPAWN_GROUP_CREATE_NEW_SCENE_WORLD: i64 = 0x100;
                pub const SPAWN_GROUP_IS_INITIAL_SPAWN_GROUP: i64 = 0x8;
                pub const SPAWN_GROUP_LOAD_ENTITIES_FROM_SAVE: i64 = 0x1;
                pub const SPAWN_GROUP_CREATE_CLIENT_ONLY_ENTITIES: i64 = 0x10;
            };
            pub const TakeDamageFlags_t = struct {
                pub const DFLAG_NONE: i64 = 0x0;
                pub const DMG_LASTDFLAG: i64 = 0x20000;
                pub const DFLAG_NEVER_GIB: i64 = 0x40;
                pub const DFLAG_ALWAYS_GIB: i64 = 0x20;
                pub const DFLAG_RADIUS_DMG: i64 = 0x400;
                pub const DFLAG_FORCE_DEATH: i64 = 0x10;
                pub const DFLAG_IGNORE_ARMOR: i64 = 0x40000;
                pub const DFLAG_PREVENT_DEATH: i64 = 0x8;
                pub const DFLAG_SUPPRESS_EFFECTS: i64 = 0x4;
                pub const DFLAG_REMOVE_NO_RAGDOLL: i64 = 0x80;
                pub const DFLAG_FORCE_PHYSICS_FORCE: i64 = 0x8000;
                pub const DFLAG_SUPPRESS_BREAKABLES: i64 = 0x4000;
                pub const DFLAG_SUPPRESS_UTILREMOVE: i64 = 0x80000;
                pub const DFLAG_FORCEREDUCEARMOR_DMG: i64 = 0x800;
                pub const DFLAG_SUPPRESS_PHYSICS_FORCE: i64 = 0x2;
                pub const DFLAG_ALLOW_NON_AUTHORITATIVE: i64 = 0x20000;
                pub const DFLAG_SUPPRESS_HEALTH_CHANGES: i64 = 0x1;
                pub const DFLAG_ALWAYS_FIRE_DAMAGE_EVENTS: i64 = 0x200;
                pub const DFLAG_IGNORE_DESTRUCTIBLE_PARTS: i64 = 0x2000;
                pub const DFLAG_SUPPRESS_INTERRUPT_FLINCH: i64 = 0x1000;
                pub const DFLAG_SUPPRESS_DAMAGE_MODIFICATION: i64 = 0x100;
                pub const DFLAG_SUPPRESS_SCREENSPACE_DAMAGE_FX: i64 = 0x10000;
            };
            pub const VoiceDataFormat_t = struct {
                pub const VOICEDATA_FORMAT_OPUS: i64 = 0x2;
                pub const VOICEDATA_FORMAT_STEAM: i64 = 0x0;
                pub const VOICEDATA_FORMAT_ENGINE: i64 = 0x1;
            };
            pub const BodySectionMutex_t = struct {
                pub const eNone: i64 = 0x0;
                pub const eFullBody: i64 = 0x3;
                pub const eLowerBody: i64 = 0x1;
                pub const eUpperBody: i64 = 0x2;
            };
            pub const CFuncMover__Move_t = struct {
                pub const MOVE_LOOP: i64 = 0x0;
                pub const MOVE_OSCILLATE: i64 = 0x1;
                pub const MOVE_STOP_AT_END: i64 = 0x2;
            };
            pub const ChoreoLookAtMode_t = struct {
                pub const eHead: i64 = 0x1;
                pub const eChest: i64 = 0x0;
                pub const eInvalid: i64 = -0x1;
                pub const eEyesOnly: i64 = 0x2;
            };
            pub const ChoreoStrafeMode_t = struct {
                pub const ENABLE: i64 = 0x1;
                pub const DEFAULT: i64 = 0x0;
                pub const DISABLE: i64 = 0x2;
            };
            pub const CustomCameraMode_t = struct {
                pub const CUSTOM_CAMERA_MODE_DISABLED: i64 = 0x0;
                pub const CUSTOM_CAMERA_MODE_CONTROLLED: i64 = 0x1;
                pub const CUSTOM_CAMERA_MODE_FOLLOW_POSITION: i64 = 0x3;
                pub const CUSTOM_CAMERA_MODE_CONTROLLED_POSITION: i64 = 0x2;
            };
            pub const DebugOverlayBits_t = struct {
                pub const OVERLAY_BBOX_BIT: i64 = 0x4;
                pub const OVERLAY_NAME_BIT: i64 = 0x2;
                pub const OVERLAY_RBOX_BIT: i64 = 0x40;
                pub const OVERLAY_TEXT_BIT: i64 = 0x1;
                pub const OVERLAY_PIVOT_BIT: i64 = 0x8;
                pub const OVERLAY_ABSBOX_BIT: i64 = 0x20;
                pub const OVERLAY_HITBOX_BIT: i64 = 0x4000;
                pub const OVERLAY_PROP_DEBUG: i64 = 0x200000000;
                pub const OVERLAY_VIEWOFFSET: i64 = 0x800000000;
                pub const OVERLAY_AUTOAIM_BIT: i64 = 0x10000;
                pub const OVERLAY_BUDDHA_MODE: i64 = 0x40000000;
                pub const OVERLAY_MESSAGE_BIT: i64 = 0x10;
                pub const OVERLAY_MINIMAL_TEXT: i64 = 0x20000000000;
                pub const OVERLAY_NPC_GOD_MODE: i64 = 0x40000000000;
                pub const OVERLAY_NPC_KILL_BIT: i64 = 0x10000000;
                pub const OVERLAY_NPC_TASK_BIT: i64 = 0x2000000;
                pub const OVERLAY_SKELETON_BIT: i64 = 0x800;
                pub const OVERLAY_ACTORNAME_BIT: i64 = 0x4000000000;
                pub const OVERLAY_NPC_ROUTE_BIT: i64 = 0x80000;
                pub const OVERLAY_JOINT_INFO_BIT: i64 = 0x40000;
                pub const OVERLAY_NPC_COMBAT_BIT: i64 = 0x1000000;
                pub const OVERLAY_SHOW_BLOCKSLOS: i64 = 0x80;
                pub const OVERLAY_ATTACHMENTS_BIT: i64 = 0x100;
                pub const OVERLAY_NPC_ENEMIES_BIT: i64 = 0x400000;
                pub const OVERLAY_NPC_RELATION_BIT: i64 = 0x400000000;
                pub const OVERLAY_NPC_SELECTED_BIT: i64 = 0x20000;
                pub const OVERLAY_NPC_VIEWCONE_BIT: i64 = 0x8000000;
                pub const OVERLAY_NPC_BODYLOCATIONS: i64 = 0x4000000;
                pub const OVERLAY_NPC_TASK_TEXT_BIT: i64 = 0x100000000;
                pub const OVERLAY_NPC_CONDITIONS_BIT: i64 = 0x800000;
                pub const OVERLAY_TRIGGER_BOUNDS_BIT: i64 = 0x2000;
                pub const OVERLAY_NPC_PATH_QUERIES_BIT: i64 = 0x100000000000;
                pub const OVERLAY_VISIBILITY_TRACES_BIT: i64 = 0x100000;
                pub const OVERLAY_INTERPOLATED_PIVOT_BIT: i64 = 0x400;
                pub const OVERLAY_VCOLLIDE_WIREFRAME_BIT: i64 = 0x1000000000;
                pub const OVERLAY_INTERPOLATED_HITBOX_BIT: i64 = 0x8000;
                pub const OVERLAY_NPC_CONDITIONS_TEXT_BIT: i64 = 0x8000000000;
                pub const OVERLAY_NPC_STEERING_REGULATIONS: i64 = 0x80000000;
                pub const OVERLAY_INTERPOLATED_SKELETON_BIT: i64 = 0x1000;
                pub const OVERLAY_NPC_SCRIPTED_COMMANDS_BIT: i64 = 0x2000000000;
                pub const OVERLAY_NPC_ANIM_AI_HANDSHAKES_BIT: i64 = 0x80000000000;
                pub const OVERLAY_NPC_ABILITY_RANGE_DEBUG_BIT: i64 = 0x10000000000;
                pub const OVERLAY_INTERPOLATED_ATTACHMENTS_BIT: i64 = 0x200;
            };
            pub const ECsgoSteamUserStat = struct {
                pub const k_ECsgoSteamUserStat_XpEarnedGames: i64 = 0x1;
                pub const k_ECsgoSteamUserStat_SurvivedDangerZone: i64 = 0x3;
                pub const k_ECsgoSteamUserStat_MatchWinsCompetitive: i64 = 0x2;
            };
            pub const FuncDoorSpawnPos_t = struct {
                pub const FUNC_DOOR_SPAWN_OPEN: i64 = 0x1;
                pub const FUNC_DOOR_SPAWN_CLOSED: i64 = 0x0;
            };
            pub const GCConnectionStatus = struct {
                pub const GCConnectionStatus_NO_STEAM: i64 = 0x4;
                pub const GCConnectionStatus_NO_SESSION: i64 = 0x2;
                pub const GCConnectionStatus_HAVE_SESSION: i64 = 0x0;
                pub const GCConnectionStatus_GC_GOING_DOWN: i64 = 0x1;
                pub const GCConnectionStatus_NO_SESSION_IN_LOGON_QUEUE: i64 = 0x3;
            };
            pub const PreviewWeaponState = struct {
                pub const ICON: i64 = 0x5;
                pub const DROPPED: i64 = 0x0;
                pub const INSPECT: i64 = 0x4;
                pub const PLANTED: i64 = 0x3;
                pub const DEPLOYED: i64 = 0x2;
                pub const HOLSTERED: i64 = 0x1;
            };
            pub const ShatterDamageCause = struct {
                pub const SHATTERDAMAGE_MELEE: i64 = 0x1;
                pub const SHATTERDAMAGE_BULLET: i64 = 0x0;
                pub const SHATTERDAMAGE_SCRIPT: i64 = 0x3;
                pub const SHATTERDAMAGE_THROWN: i64 = 0x2;
                pub const SHATTERDAMAGE_EXPLOSIVE: i64 = 0x4;
            };
            pub const WeaponAttackType_t = struct {
                pub const eCount: i64 = 0x2;
                pub const eInvalid: i64 = -0x1;
                pub const ePrimary: i64 = 0x0;
                pub const eSecondary: i64 = 0x1;
            };
            pub const ChoreoLookAtSpeed_t = struct {
                pub const eFast: i64 = 0x2;
                pub const eSlow: i64 = 0x0;
                pub const eMedium: i64 = 0x1;
                pub const eInvalid: i64 = -0x1;
            };
            pub const EBaseClientMessages = struct {
                pub const CM_MAX_BASE: i64 = 0x12C;
                pub const CM_RotateAnchor: i64 = 0x11D;
                pub const CM_ClientUIEvent: i64 = 0x11A;
                pub const CM_CustomGameEvent: i64 = 0x118;
                pub const CM_CustomGameEventBounce: i64 = 0x119;
                pub const CM_DevPaletteVisibilityChanged: i64 = 0x11B;
                pub const CM_WorldUIControllerHasPanelChanged: i64 = 0x11C;
            };
            pub const EBaseEntityMessages = struct {
                pub const EM_DoSpark: i64 = 0x8C;
                pub const EM_FixAngle: i64 = 0x8D;
                pub const EM_PlayJingle: i64 = 0x88;
                pub const EM_ScreenOverlay: i64 = 0x89;
                pub const EM_PropagateForce: i64 = 0x8B;
            };
            pub const ECSPredictionEvents = struct {
                pub const CSPE_DamageTag: i64 = 0x1;
                pub const CSPE_PlayerTeleport: i64 = 0x3;
            };
            pub const ECommunityItemClass = struct {
                pub const k_ECommunityItemClass_Badge: i64 = 0x1;
                pub const k_ECommunityItemClass_Scene: i64 = 0x9;
                pub const k_ECommunityItemClass_GameGoo: i64 = 0x7;
                pub const k_ECommunityItemClass_Invalid: i64 = 0x0;
                pub const k_ECommunityItemClass_Emoticon: i64 = 0x4;
                pub const k_ECommunityItemClass_GameCard: i64 = 0x2;
                pub const k_ECommunityItemClass_Consumable: i64 = 0x6;
                pub const k_ECommunityItemClass_SalienItem: i64 = 0xA;
                pub const k_ECommunityItemClass_BoosterPack: i64 = 0x5;
                pub const k_ECommunityItemClass_ProfileModifier: i64 = 0x8;
                pub const k_ECommunityItemClass_ProfileBackground: i64 = 0x3;
            };
            pub const EOverrideBlockLOS_t = struct {
                pub const BLOCK_LOS_DEFAULT: i64 = 0x0;
                pub const BLOCK_LOS_FORCE_TRUE: i64 = 0x2;
                pub const BLOCK_LOS_FORCE_FALSE: i64 = 0x1;
            };
            pub const ForcedCrouchState_t = struct {
                pub const FORCEDCROUCH_NONE: i64 = 0x0;
                pub const FORCEDCROUCH_CROUCHED: i64 = 0x1;
                pub const FORCEDCROUCH_UNCROUCHED: i64 = 0x2;
            };
            pub const PulseNPCCondition_t = struct {
                pub const COND_SEE_PLAYER: i64 = 0x1;
                pub const COND_HEAR_PLAYER: i64 = 0x3;
                pub const COND_LOST_PLAYER: i64 = 0x2;
                pub const COND_PLAYER_PUSHING: i64 = 0x4;
                pub const COND_NO_PRIMARY_AMMO: i64 = 0x5;
            };
            pub const RadiusDmgOverride_t = struct {
                pub const RADIUS_DMG_OVERRIDE_NONE: i64 = 0x0;
                pub const RADIUS_DMG_OVERRIDE_POSITION_ONLY: i64 = 0x1;
                pub const RADIUS_DMG_OVERRIDE_POSITION_SKIP_TRACES: i64 = 0x2;
            };
            pub const TrainVelocityType_t = struct {
                pub const TrainVelocity_LinearBlend: i64 = 0x1;
                pub const TrainVelocity_EaseInEaseOut: i64 = 0x2;
                pub const TrainVelocity_Instantaneous: i64 = 0x0;
            };
            pub const AnimationAlgorithm_t = struct {
                pub const eNone: i64 = 0x0;
                pub const eCount: i64 = 0x4;
                pub const eInvalid: i64 = -0x1;
                pub const eSequence: i64 = 0x1;
                pub const eAnimGraph2: i64 = 0x2;
                pub const eAnimGraph2Secondary: i64 = 0x3;
            };
            pub const CSWeaponSilencerType = struct {
                pub const WEAPONSILENCER_NONE: i64 = 0x0;
                pub const WEAPONSILENCER_DETACHABLE: i64 = 0x1;
                pub const WEAPONSILENCER_INTEGRATED: i64 = 0x2;
            };
            pub const EProtoDebugVisiblity = struct {
                pub const k_EProtoDebugVisibility_GC: i64 = 0x5A;
                pub const k_EProtoDebugVisibility_Never: i64 = 0x64;
                pub const k_EProtoDebugVisibility_Always: i64 = 0x0;
                pub const k_EProtoDebugVisibility_Server: i64 = 0x46;
                pub const k_EProtoDebugVisibility_ValveServer: i64 = 0x50;
            };
            pub const EntityDissolveType_t = struct {
                pub const ENTITY_DISSOLVE_CORE: i64 = 0x3;
                pub const ENTITY_DISSOLVE_NORMAL: i64 = 0x0;
                pub const ENTITY_DISSOLVE_INVALID: i64 = -0x1;
                pub const ENTITY_DISSOLVE_ELECTRICAL: i64 = 0x1;
                pub const ENTITY_DISSOLVE_ELECTRICAL_LIGHT: i64 = 0x2;
            };
            pub const EntityDistanceMode_t = struct {
                pub const eAxisToAxis: i64 = 0x2;
                pub const eCenterToCenter: i64 = 0x1;
                pub const eOriginToOrigin: i64 = 0x0;
            };
            pub const GCClientLauncherType = struct {
                pub const GCClientLauncherType_DEFAULT: i64 = 0x0;
                pub const GCClientLauncherType_SOURCE2: i64 = 0x3;
                pub const GCClientLauncherType_STEAMCHINA: i64 = 0x2;
                pub const GCClientLauncherType_PERFECTWORLD: i64 = 0x1;
            };
            pub const GameAnimEventIndex_t = struct {
                pub const AE_COUNT: i64 = 0x2F;
                pub const AE_EMPTY: i64 = 0x0;
                pub const AE_FOOTSTEP: i64 = 0xC;
                pub const AE_SV_IKLOCK: i64 = 0x16;
                pub const AE_FIRE_INPUT: i64 = 0x10;
                pub const AE_PULSE_GRAPH: i64 = 0x17;
                pub const AE_CL_EJECT_MAG: i64 = 0x2B;
                pub const AE_CL_PLAYSOUND: i64 = 0x1;
                pub const AE_CL_STOPSOUND: i64 = 0x5;
                pub const AE_SV_PLAYSOUND: i64 = 0x4;
                pub const AE_CL_CLOTH_ATTR: i64 = 0x11;
                pub const AE_CL_CLOTH_EFFECT: i64 = 0x14;
                pub const AE_CL_CLOTH_STIFFEN: i64 = 0x13;
                pub const AE_DISABLE_PLATFORM: i64 = 0x18;
                pub const AE_BODYGROUP_SET_VALUE: i64 = 0xE;
                pub const AE_WPN_COMPLETE_RELOAD: i64 = 0x2C;
                pub const AE_CL_PLAYSOUND_LOOPING: i64 = 0x6;
                pub const AE_SCRIPT_FIRE_EVENT_01: i64 = 0x1E;
                pub const AE_SCRIPT_FIRE_EVENT_02: i64 = 0x1F;
                pub const AE_SCRIPT_FIRE_EVENT_03: i64 = 0x20;
                pub const AE_SCRIPT_FIRE_EVENT_04: i64 = 0x21;
                pub const AE_SCRIPT_FIRE_EVENT_05: i64 = 0x22;
                pub const AE_SCRIPT_FIRE_EVENT_06: i64 = 0x23;
                pub const AE_SCRIPT_FIRE_EVENT_07: i64 = 0x24;
                pub const AE_SCRIPT_FIRE_EVENT_08: i64 = 0x25;
                pub const AE_SCRIPT_FIRE_EVENT_09: i64 = 0x26;
                pub const AE_SCRIPT_FIRE_EVENT_10: i64 = 0x27;
                pub const AE_CL_PLAYSOUND_POSITION: i64 = 0x3;
                pub const AE_VEHICLE_EXIT_FINISHED: i64 = 0x1D;
                pub const AE_WEAPON_PERFORM_ATTACK: i64 = 0xF;
                pub const AE_WPN_HEALTHSHOT_INJECT: i64 = 0x2D;
                pub const AE_CL_CLOTH_GROUND_OFFSET: i64 = 0x12;
                pub const AE_GRENADE_THROW_COMPLETE: i64 = 0x2E;
                pub const AE_VEHICLE_ENTER_FINISHED: i64 = 0x1C;
                pub const AE_CL_PLAYSOUND_ATTACHMENT: i64 = 0x2;
                pub const AE_CL_STOP_PARTICLE_EFFECT: i64 = 0x8;
                pub const AE_CL_STOP_RAGDOLL_CONTROL: i64 = 0xD;
                pub const AE_SV_STOP_PARTICLE_EFFECT: i64 = 0xB;
                pub const AE_CL_CREATE_ANIM_SCOPE_PROP: i64 = 0x15;
                pub const AE_CL_CREATE_PARTICLE_EFFECT: i64 = 0x7;
                pub const AE_DESTRUCTIBLE_PART_DESTROY: i64 = 0x1B;
                pub const AE_SV_ATTACH_SILENCER_COMPLETE: i64 = 0x29;
                pub const AE_SV_DETACH_SILENCER_COMPLETE: i64 = 0x2A;
                pub const AE_CL_CREATE_PARTICLE_EFFECT_CFG: i64 = 0x9;
                pub const AE_SV_CREATE_PARTICLE_EFFECT_CFG: i64 = 0xA;
                pub const AE_CL_WEAPON_TRANSITION_INTO_HAND: i64 = 0x28;
                pub const AE_ENABLE_PLATFORM_PLAYER_FOLLOWS_YAW: i64 = 0x19;
                pub const AE_ENABLE_PLATFORM_PLAYER_IGNORES_YAW: i64 = 0x1A;
            };
            pub const ModifyDamageReturn_t = struct {
                pub const CONTINUE_TO_APPLY_DAMAGE: i64 = 0x0;
                pub const ABORT_DO_NOT_APPLY_DAMAGE: i64 = 0x1;
            };
            pub const MoveMountingAmount_t = struct {
                pub const MOVE_MOUNT_LOW: i64 = 0x1;
                pub const MOVE_MOUNT_HIGH: i64 = 0x2;
                pub const MOVE_MOUNT_NONE: i64 = 0x0;
                pub const MOVE_MOUNT_MAXCOUNT: i64 = 0x3;
            };
            pub const NPCFollowFormation_t = struct {
                pub const Default: i64 = -0x1;
                pub const Sidekick: i64 = 0x6;
                pub const WideCircle: i64 = 0x1;
                pub const CloseCircle: i64 = 0x0;
                pub const MediumCircle: i64 = 0x5;
            };
            pub const PlayerConnectedState = struct {
                pub const Reserved: i64 = 0x5;
                pub const Connected: i64 = 0x0;
                pub const Connecting: i64 = 0x1;
                pub const Disconnected: i64 = 0x4;
                pub const Reconnecting: i64 = 0x2;
                pub const Disconnecting: i64 = 0x3;
                pub const NeverConnected: i64 = -0x1;
            };
            pub const PreviewCharacterMode = struct {
                pub const BANNER: i64 = 0xA;
                pub const DIORAMA: i64 = 0x0;
                pub const INVALID: i64 = -0x1;
                pub const WALKING: i64 = 0x6;
                pub const BUY_MENU: i64 = 0x2;
                pub const MAIN_MENU: i64 = 0x1;
                pub const RUSH_INTRO: i64 = 0x9;
                pub const TEAM_INTRO: i64 = 0x7;
                pub const TEAM_SELECT: i64 = 0x3;
                pub const END_OF_MATCH: i64 = 0x4;
                pub const WINGMAN_INTRO: i64 = 0x8;
                pub const CHICK_SNAPSHOT: i64 = 0xB;
                pub const CHICK_VIEWMODEL: i64 = 0xC;
                pub const INVENTORY_INSPECT: i64 = 0x5;
            };
            pub const PulseTraceContents_t = struct {
                pub const SOLID: i64 = 0x1;
                pub const STATIC_LEVEL: i64 = 0x0;
            };
            pub const SceneOnPlayerDeath_t = struct {
                pub const SCENE_ONPLAYERDEATH_CANCEL: i64 = 0x1;
                pub const SCENE_ONPLAYERDEATH_DO_NOTHING: i64 = 0x0;
            };
            pub const WeaponSwitchReason_t = struct {
                pub const eDrawn: i64 = 0x0;
                pub const eEquipped: i64 = 0x1;
                pub const eUserInitiatedUIKeyPress: i64 = 0x3;
                pub const eUserInitiatedSwitchHands: i64 = 0x4;
                pub const eUserInitiatedSwitchToLast: i64 = 0x2;
            };
            pub const vote_create_failed_t = struct {
                pub const VOTE_FAILED_MAX: i64 = 0x22;
                pub const VOTE_FAILED_GENERIC: i64 = 0x0;
                pub const VOTE_FAILED_REMATCH: i64 = 0x20;
                pub const VOTE_FAILED_CONTINUE: i64 = 0x21;
                pub const VOTE_FAILED_DISABLED: i64 = 0x15;
                pub const VOTE_FAILED_SPECTATOR: i64 = 0xE;
                pub const VOTE_FAILED_MATCH_PAUSED: i64 = 0x18;
                pub const VOTE_FAILED_MAP_NOT_FOUND: i64 = 0x6;
                pub const VOTE_FAILED_NEXTLEVEL_SET: i64 = 0x16;
                pub const VOTE_FAILED_NOT_IN_WARMUP: i64 = 0x1A;
                pub const VOTE_FAILED_RATE_EXCEEDED: i64 = 0x2;
                pub const VOTE_FAILED_CANT_ROUND_END: i64 = 0x1F;
                pub const VOTE_FAILED_ISSUE_DISABLED: i64 = 0x5;
                pub const VOTE_FAILED_NOT_10_PLAYERS: i64 = 0x1B;
                pub const VOTE_FAILED_PLAYERNOTFOUND: i64 = 0xB;
                pub const VOTE_FAILED_QUORUM_FAILURE: i64 = 0x4;
                pub const VOTE_FAILED_TEAM_CANT_CALL: i64 = 0x9;
                pub const VOTE_FAILED_TIMEOUT_ACTIVE: i64 = 0x1C;
                pub const VOTE_FAILED_FAILED_RECENTLY: i64 = 0x8;
                pub const VOTE_FAILED_MATCH_NOT_PAUSED: i64 = 0x19;
                pub const VOTE_FAILED_SWAP_IN_PROGRESS: i64 = 0x14;
                pub const VOTE_FAILED_TIMEOUT_INACTIVE: i64 = 0x1D;
                pub const VOTE_FAILED_CANNOT_KICK_ADMIN: i64 = 0xC;
                pub const VOTE_FAILED_MAP_NAME_REQUIRED: i64 = 0x7;
                pub const VOTE_FAILED_TIMEOUT_EXHAUSTED: i64 = 0x1E;
                pub const VOTE_FAILED_WAITINGFORPLAYERS: i64 = 0xA;
                pub const VOTE_FAILED_FAILED_RECENT_KICK: i64 = 0xF;
                pub const VOTE_FAILED_YES_MUST_EXCEED_NO: i64 = 0x3;
                pub const VOTE_FAILED_TOO_EARLY_SURRENDER: i64 = 0x17;
                pub const VOTE_FAILED_SCRAMBLE_IN_PROGRESS: i64 = 0xD;
                pub const VOTE_FAILED_FAILED_RECENT_RESTART: i64 = 0x13;
                pub const VOTE_FAILED_TRANSITIONING_PLAYERS: i64 = 0x1;
                pub const VOTE_FAILED_FAILED_RECENT_CHANGEMAP: i64 = 0x10;
                pub const VOTE_FAILED_FAILED_RECENT_SWAPTEAMS: i64 = 0x11;
                pub const VOTE_FAILED_FAILED_RECENT_SCRAMBLETEAMS: i64 = 0x12;
            };
            pub const EBasePredictionEvents = struct {
                pub const BPE_Teleport: i64 = 0x82;
                pub const BPE_Diagnostic: i64 = 0x4000;
                pub const BPE_StringCommand: i64 = 0x80;
            };
            pub const EQueryCvarValueStatus = struct {
                pub const eQueryCvarValueStatus_NotACvar: i64 = 0x2;
                pub const eQueryCvarValueStatus_ValueIntact: i64 = 0x0;
                pub const eQueryCvarValueStatus_CvarNotFound: i64 = 0x1;
                pub const eQueryCvarValueStatus_CvarProtected: i64 = 0x3;
            };
            pub const EntityPlatformTypes_t = struct {
                pub const ENTITY_NOT_PLATFORM: i64 = 0x0;
                pub const ENTITY_PLATFORM_PLAYER_FOLLOWS_YAW: i64 = 0x1;
                pub const ENTITY_PLATFORM_PLAYER_IGNORES_YAW: i64 = 0x2;
            };
            pub const EntitySubclassScope_t = struct {
                pub const SUBCLASS_SCOPE_NONE: i64 = -0x1;
                pub const SUBCLASS_SCOPE_COUNT: i64 = 0x2;
                pub const SUBCLASS_SCOPE_PRECIPITATION: i64 = 0x0;
                pub const SUBCLASS_SCOPE_PLAYER_WEAPONS: i64 = 0x1;
            };
            pub const ObserverInterpState_t = struct {
                pub const OBSERVER_INTERP_NONE: i64 = 0x0;
                pub const OBSERVER_INTERP_SETTLING: i64 = 0x3;
                pub const OBSERVER_INTERP_STARTING: i64 = 0x1;
                pub const OBSERVER_INTERP_TRAVELING: i64 = 0x2;
            };
            pub const PreviewEOMCelebration = struct {
                pub const MASK_F: i64 = 0x6;
                pub const WALKUP: i64 = 0x0;
                pub const INVALID: i64 = -0x1;
                pub const STRETCH: i64 = 0x4;
                pub const SWAGGER: i64 = 0x2;
                pub const DROPDOWN: i64 = 0x3;
                pub const GUERILLA: i64 = 0x7;
                pub const PUNCHING: i64 = 0x1;
                pub const AVA_DEFEAT: i64 = 0xC;
                pub const GUERILLA02: i64 = 0x8;
                pub const MAE_DEFEAT: i64 = 0xE;
                pub const SCUBA_MALE: i64 = 0xB;
                pub const GENDARMERIE: i64 = 0x9;
                pub const SWAT_FEMALE: i64 = 0x5;
                pub const VYPA_DEFEAT: i64 = 0x16;
                pub const SCUBA_FEMALE: i64 = 0xA;
                pub const DARRYL_DEFEAT: i64 = 0x13;
                pub const DOCTOR_DEFEAT: i64 = 0x14;
                pub const MUHLIK_DEFEAT: i64 = 0x15;
                pub const RICKSAW_DEFEAT: i64 = 0xF;
                pub const CRASSWATER_DEFEAT: i64 = 0x12;
                pub const SCUBA_MALE_DEFEAT: i64 = 0x11;
                pub const GENDARMERIE_DEFEAT: i64 = 0xD;
                pub const SCUBA_FEMALE_DEFEAT: i64 = 0x10;
            };
            pub const PulseCollisionGroup_t = struct {
                pub const DEFAULT: i64 = 0x0;
            };
            pub const PulseMethodCallMode_t = struct {
                pub const ASYNC_FIRE_AND_FORGET: i64 = 0x1;
                pub const SYNC_WAIT_FOR_COMPLETION: i64 = 0x0;
            };
            pub const QuestProgress__Reason = struct {
                pub const QUEST_OK: i64 = 0x1;
                pub const QUEST_WARMUP: i64 = 0x3;
                pub const QUEST_NO_QUEST: i64 = 0x7;
                pub const QUEST_WRONG_MAP: i64 = 0x9;
                pub const QUEST_REASON_MAX: i64 = 0xC;
                pub const QUEST_WRONG_MODE: i64 = 0xA;
                pub const QUEST_PLAYER_IS_BOT: i64 = 0x8;
                pub const QUEST_NONINITIALIZED: i64 = 0x0;
                pub const QUEST_NO_ENTITLEMENT: i64 = 0x6;
                pub const QUEST_NONOFFICIAL_SERVER: i64 = 0x5;
                pub const QUEST_NOT_ENOUGH_PLAYERS: i64 = 0x2;
                pub const QUEST_NOT_CONNECTED_TO_STEAM: i64 = 0x4;
                pub const QUEST_NOT_SYNCED_WITH_SERVER: i64 = 0xB;
            };
            pub const SoundEventStartType_t = struct {
                pub const SOUNDEVENT_START_WORLD: i64 = 0x1;
                pub const SOUNDEVENT_START_ENTITY: i64 = 0x2;
                pub const SOUNDEVENT_START_PLAYER: i64 = 0x0;
            };
            pub const TimelineCompression_t = struct {
                pub const TIMELINE_COMPRESSION_SUM: i64 = 0x0;
                pub const TIMELINE_COMPRESSION_TOTAL: i64 = 0x4;
                pub const TIMELINE_COMPRESSION_AVERAGE: i64 = 0x2;
                pub const TIMELINE_COMPRESSION_AVERAGE_BLEND: i64 = 0x3;
                pub const TIMELINE_COMPRESSION_COUNT_PER_INTERVAL: i64 = 0x1;
            };
            pub const Bidirectional_Messages = struct {
                pub const bi_PredictionEvent: i64 = 0x13;
                pub const bi_RebroadcastSource: i64 = 0x11;
                pub const bi_GameEvent_DEPRECATED: i64 = 0x12;
                pub const bi_RebroadcastGameEvent: i64 = 0x10;
            };
            pub const CFuncRotator__Rotate_t = struct {
                pub const ROTATE_LOOP: i64 = 0x0;
                pub const ROTATE_OSCILLATE: i64 = 0x1;
                pub const ROTATE_STOP_AT_END: i64 = 0x2;
                pub const ROTATE_LOOK_AT_TARGET: i64 = 0x3;
                pub const ROTATE_LOOK_AT_TARGET_ONLY_YAW: i64 = 0x4;
                pub const ROTATE_LOOK_AT_TARGET_ONLY_PITCH: i64 = 0x5;
                pub const ROTATE_RETURN_TO_INITIAL_ORIENTATION: i64 = 0x6;
            };
            pub const ChoreoScriptedMoveTo_t = struct {
                pub const eWait: i64 = 0x0;
                pub const eTeleport: i64 = 0x2;
                pub const eWaitFacing: i64 = 0x3;
                pub const eMoveWithGait: i64 = 0x1;
            };
            pub const ECstrike15UserMessages = struct {
                pub const CS_UM_Fade: i64 = 0x139;
                pub const CS_UM_SSUI: i64 = 0x174;
                pub const CS_UM_Shake: i64 = 0x138;
                pub const CS_UM_Train: i64 = 0x12F;
                pub const CS_UM_Damage: i64 = 0x141;
                pub const CS_UM_Geiger: i64 = 0x12E;
                pub const CS_UM_HudMsg: i64 = 0x134;
                pub const CS_UM_Rumble: i64 = 0x13A;
                pub const CS_UM_BarTime: i64 = 0x163;
                pub const CS_UM_HudText: i64 = 0x130;
                pub const CS_UM_KillCam: i64 = 0x14A;
                pub const CS_UM_HintText: i64 = 0x143;
                pub const CS_UM_ItemDrop: i64 = 0x167;
                pub const CS_UM_RawAudio: i64 = 0x13E;
                pub const CS_UM_ResetHud: i64 = 0x135;
                pub const CS_UM_ShowMenu: i64 = 0x162;
                pub const CS_UM_VGUIMenu: i64 = 0x12D;
                pub const CS_UM_VotePass: i64 = 0x15B;
                pub const CS_UM_XRankGet: i64 = 0x154;
                pub const CS_UM_XRankUpd: i64 = 0x155;
                pub const CS_UM_XpUpdate: i64 = 0x16D;
                pub const CS_UM_DeepStats: i64 = 0x17D;
                pub const CS_UM_GameTitle: i64 = 0x136;
                pub const CS_UM_RadioText: i64 = 0x142;
                pub const CS_UM_ReportHit: i64 = 0x16C;
                pub const CS_UM_SendAudio: i64 = 0x13D;
                pub const CS_UM_ShootInfo: i64 = 0x17F;
                pub const CS_UM_VoiceMask: i64 = 0x13F;
                pub const CS_UM_VoteSetup: i64 = 0x15D;
                pub const CS_UM_VoteStart: i64 = 0x15A;
                pub const CS_UM_AmmoDenied: i64 = 0x164;
                pub const CS_UM_ClientInfo: i64 = 0x153;
                pub const CS_UM_ItemPickup: i64 = 0x161;
                pub const CS_UM_VoteFailed: i64 = 0x15C;
                pub const CS_UM_AdjustMoney: i64 = 0x147;
                pub const CS_UM_KeyHintText: i64 = 0x144;
                pub const CS_UM_WeaponSound: i64 = 0x171;
                pub const CS_UM_CloseCaption: i64 = 0x13B;
                pub const CS_UM_ReloadEffect: i64 = 0x146;
                pub const CS_UM_RequestState: i64 = 0x140;
                pub const CS_UM_CounterStrafe: i64 = 0x181;
                pub const CS_UM_QuestProgress: i64 = 0x16E;
                pub const CS_UM_SurvivalStats: i64 = 0x175;
                pub const CS_UM_WeaponMagDrop: i64 = 0x185;
                pub const CS_UM_CallVoteFailed: i64 = 0x159;
                pub const CS_UM_MarkAchievement: i64 = 0x165;
                pub const CS_UM_AchievementEvent: i64 = 0x14D;
                pub const CS_UM_CurrentRoundOdds: i64 = 0x17C;
                pub const CS_UM_CurrentTimescale: i64 = 0x14C;
                pub const CS_UM_CustomHudClicked: i64 = 0x186;
                pub const CS_UM_DamagePrediction: i64 = 0x182;
                pub const CS_UM_DesiredTimescale: i64 = 0x14B;
                pub const CS_UM_MatchStatsUpdate: i64 = 0x166;
                pub const CS_UM_ServerRankUpdate: i64 = 0x160;
                pub const CS_UM_DisconnectToLobby: i64 = 0x14F;
                pub const CS_UM_PlayerStatsUpdate: i64 = 0x150;
                pub const CS_UM_SendPlayerLoadout: i64 = 0x184;
                pub const CS_UM_StopSpectatorMode: i64 = 0x149;
                pub const CS_UM_CloseCaptionDirect: i64 = 0x13C;
                pub const CS_UM_DisconnectToLobby2: i64 = 0x176;
                pub const CS_UM_MatchEndConditions: i64 = 0x14E;
                pub const CS_UM_RoundEndReportData: i64 = 0x17B;
                pub const CS_UM_SayText_CSGOLegacy: i64 = 0x131;
                pub const CS_UM_TextMsg_CSGOLegacy: i64 = 0x133;
                pub const CS_UM_SayText2_CSGOLegacy: i64 = 0x132;
                pub const CS_UM_SendPlayerItemDrops: i64 = 0x169;
                pub const CS_UM_SendPlayerItemFound: i64 = 0x16B;
                pub const CS_UM_ServerRankRevealAll: i64 = 0x15E;
                pub const CS_UM_RoundBackupFilenames: i64 = 0x16A;
                pub const CS_UM_ScoreLeaderboardData: i64 = 0x16F;
                pub const CS_UM_PostRoundDamageReport: i64 = 0x178;
                pub const CS_UM_UpdateScreenHealthBar: i64 = 0x172;
                pub const CS_UM_EntityOutlineHighlight: i64 = 0x173;
                pub const CS_UM_RecurringMissionSchema: i64 = 0x183;
                pub const CS_UM_EndOfMatchAllPlayersData: i64 = 0x177;
                pub const CS_UM_ProcessSpottedEntityUpdate: i64 = 0x145;
                pub const CS_UM_UpdateTeamMoney_CSGOLegacy: i64 = 0x148;
                pub const CS_UM_PlayerDecalDigitalSignature: i64 = 0x170;
                pub const CS_UM_SendLastKillerDamageToClient: i64 = 0x15F;
            };
            pub const EHudPanelClassStatus_t = struct {
                pub const k_eHudPanelClassStatus_HasClass: i64 = 0x1;
                pub const k_eHudPanelClassStatus_Undefined: i64 = -0x1;
                pub const k_eHudPanelClassStatus_DoesNotHaveClass: i64 = 0x0;
            };
            pub const EntityAttachmentType_t = struct {
                pub const eEyes: i64 = 0x2;
                pub const eCenter: i64 = 0x1;
                pub const eAbsOrigin: i64 = 0x0;
                pub const eAttachment: i64 = 0x3;
                pub const eLocalOffset: i64 = 0x4;
            };
            pub const LatchDirtyPermission_t = struct {
                pub const LATCH_DIRTY_DISALLOW: i64 = 0x0;
                pub const LATCH_DIRTY_PREDICTION: i64 = 0x3;
                pub const LATCH_DIRTY_FRAMESIMULATE: i64 = 0x4;
                pub const LATCH_DIRTY_CLIENT_SIMULATED: i64 = 0x2;
                pub const LATCH_DIRTY_PARTICLE_SIMULATE: i64 = 0x5;
                pub const LATCH_DIRTY_SERVER_CONTROLLED: i64 = 0x1;
            };
            pub const RelativeLocationType_t = struct {
                pub const WORLD_SPACE_POSITION: i64 = 0x0;
                pub const RELATIVE_TO_ENTITY_YAW_ONLY: i64 = 0x2;
                pub const RELATIVE_TO_ENTITY_IN_LOCAL_SPACE: i64 = 0x1;
                pub const RELATIVE_TO_ENTITY_IN_WORLD_SPACE: i64 = 0x3;
            };
            pub const ShatterGlassStressType = struct {
                pub const SHATTERGLASS_BLUNT: i64 = 0x0;
                pub const SHATTERGLASS_PULSE: i64 = 0x2;
                pub const SHATTERGLASS_BALLISTIC: i64 = 0x1;
                pub const SHATTERGLASS_EXPLOSIVE: i64 = 0x3;
            };
            pub const TrackOrientationType_t = struct {
                pub const TrackOrientation_Fixed: i64 = 0x0;
                pub const TrackOrientation_FacePath: i64 = 0x1;
                pub const TrackOrientation_FacePathAngles: i64 = 0x2;
            };
            pub const TrainOrientationType_t = struct {
                pub const TrainOrientation_Fixed: i64 = 0x0;
                pub const TrainOrientation_LinearBlend: i64 = 0x2;
                pub const TrainOrientation_AtPathTracks: i64 = 0x1;
                pub const TrainOrientation_EaseInEaseOut: i64 = 0x3;
            };
            pub const BreakableContentsType_t = struct {
                pub const BC_EMPTY: i64 = 0x1;
                pub const BC_DEFAULT: i64 = 0x0;
                pub const BC_PROP_GROUP_OVERRIDE: i64 = 0x2;
                pub const BC_PARTICLE_SYSTEM_OVERRIDE: i64 = 0x3;
            };
            pub const EClientReportingVersion = struct {
                pub const k_EClientReportingVersion_OldVersion: i64 = 0x0;
                pub const k_EClientReportingVersion_BetaVersion: i64 = 0x1;
                pub const k_EClientReportingVersion_SupportsTrustedMode: i64 = 0x2;
            };
            pub const ECommunityItemAttribute = struct {
                pub const k_ECommunityItemAttribute_Level: i64 = 0x2;
                pub const k_ECommunityItemAttribute_Invalid: i64 = 0x0;
                pub const k_ECommunityItemAttribute_CardBorder: i64 = 0x1;
                pub const k_ECommunityItemAttribute_ExpiryTime: i64 = 0x9;
                pub const k_ECommunityItemAttribute_IssueNumber: i64 = 0x3;
                pub const k_ECommunityItemAttribute_TradableTime: i64 = 0x4;
                pub const k_ECommunityItemAttribute_StorePackageID: i64 = 0x5;
                pub const k_ECommunityItemAttribute_CommunityItemType: i64 = 0x7;
                pub const k_ECommunityItemAttribute_CommunityItemAppID: i64 = 0x6;
                pub const k_ECommunityItemAttribute_ProfileModiferEnabled: i64 = 0x8;
            };
            pub const EGCBaseProtoObjectTypes = struct {
                pub const k_EProtoObjectLobbyInvite: i64 = 0x3EA;
                pub const k_EProtoObjectPartyInvite: i64 = 0x3E9;
            };
            pub const ESplitScreenMessageType = struct {
                pub const MSG_SPLITSCREEN_ADDUSER: i64 = 0x0;
                pub const MSG_SPLITSCREEN_REMOVEUSER: i64 = 0x1;
            };
            pub const MoveLinearAuthoredPos_t = struct {
                pub const MOVELINEAR_AUTHORED_AT_OPEN_POSITION: i64 = 0x1;
                pub const MOVELINEAR_AUTHORED_AT_START_POSITION: i64 = 0x0;
                pub const MOVELINEAR_AUTHORED_AT_CLOSED_POSITION: i64 = 0x2;
            };
            pub const NavAttributeDynamicType = struct {
                pub const NAV_AREA_DOCK: i64 = 0x4000;
                pub const NAV_AREA_NONE: i64 = 0x0;
                pub const NAV_AREA_MOVABLE: i64 = 0x2000;
                pub const NAV_AREA_BOUNDARY: i64 = 0x10000;
                pub const NAV_AREA_NAV_LINK: i64 = 0x200;
                pub const NAV_AREA_DEFORMABLE: i64 = 0x40000;
                pub const NAV_AREA_HAS_LADDERS: i64 = 0x100;
                pub const NAV_AREA_UNDER_WATER: i64 = 0x1;
                pub const NAV_AREA_DEFORMABLE_DOCK: i64 = 0x80000;
                pub const NAV_AREA_LINK_AUTO_ADJUST: i64 = 0x100000;
                pub const NAV_AREA_UNDER_WATER_DEEP: i64 = 0x2;
                pub const NAV_AREA_DOCKING_CANDIDATE: i64 = 0x8000;
                pub const NAV_AREA_NAV_LINK_TERMINUS: i64 = 0x400;
                pub const NAV_AREA_EXTERNALLY_CREATED: i64 = 0x4;
                pub const NAV_AREA_SHOULD_BE_DESTROYED: i64 = 0x8;
                pub const NAV_AREA_SPLIT_OBS_CONTAINED: i64 = 0x40;
                pub const NAV_AREA_SPLIT_BY_OBSTACLE_MGR: i64 = 0x20;
                pub const NAV_AREA_CREATED_BY_OBSTACLE_MGR: i64 = 0x10;
                pub const NAV_AREA_CONNECTED_TO_NAV_LINK_IN: i64 = 0x1000;
                pub const NAV_AREA_SPLIT_OBS_BASE_CONTAINED: i64 = 0x80;
                pub const NAV_AREA_CONNECTED_TO_NAV_LINK_OUT: i64 = 0x800;
                pub const NAV_AREA_HAS_TACTICAL_SEARCH_ANNOTATIONS: i64 = 0x20000;
            };
            pub const PointOrientConstraint_t = struct {
                pub const eNone: i64 = 0x0;
                pub const ePreserveUpAxis: i64 = 0x1;
            };
            pub const PulseBestOutflowRules_t = struct {
                pub const SORT_BY_OUTFLOW_INDEX: i64 = 0x1;
                pub const SORT_BY_NUMBER_OF_VALID_CRITERIA: i64 = 0x0;
            };
            pub const SaveRestoreTableFlags_t = struct {
                pub const FENTTABLE_NONE: i64 = 0x0;
                pub const LEVELMASK_BIT_0: i64 = 0x1;
                pub const LEVELMASK_BIT_1: i64 = 0x2;
                pub const LEVELMASK_BIT_2: i64 = 0x4;
                pub const LEVELMASK_BIT_3: i64 = 0x8;
                pub const LEVELMASK_BIT_4: i64 = 0x10;
                pub const LEVELMASK_BIT_5: i64 = 0x20;
                pub const LEVELMASK_BIT_6: i64 = 0x40;
                pub const LEVELMASK_BIT_7: i64 = 0x80;
                pub const LEVELMASK_BIT_8: i64 = 0x100;
                pub const LEVELMASK_BIT_9: i64 = 0x200;
                pub const FENTTABLE_GLOBAL: i64 = 0x10000000;
                pub const FENTTABLE_PLAYER: i64 = 0x80000000;
                pub const LEVELMASK_BIT_10: i64 = 0x400;
                pub const LEVELMASK_BIT_11: i64 = 0x800;
                pub const LEVELMASK_BIT_12: i64 = 0x1000;
                pub const LEVELMASK_BIT_13: i64 = 0x2000;
                pub const LEVELMASK_BIT_14: i64 = 0x4000;
                pub const LEVELMASK_BIT_15: i64 = 0x8000;
                pub const FENTTABLE_REMOVED: i64 = 0x40000000;
                pub const FENTTABLE_MOVEABLE: i64 = 0x20000000;
                pub const FENTTABLE_PLAYERCHILD: i64 = 0x8000000;
            };
            pub const SurroundingBoundsType_t = struct {
                pub const USE_HITBOXES: i64 = 0x2;
                pub const USE_GAME_CODE: i64 = 0x4;
                pub const USE_SPECIFIED_BOUNDS: i64 = 0x3;
                pub const USE_OBB_COLLISION_BOUNDS: i64 = 0x0;
                pub const USE_BEST_COLLISION_BOUNDS: i64 = 0x1;
                pub const SURROUNDING_TYPE_BIT_COUNT: i64 = 0x3;
                pub const USE_ROTATION_EXPANDED_BOUNDS: i64 = 0x5;
                pub const USE_COLLISION_BOUNDS_NEVER_VPHYSICS: i64 = 0x7;
                pub const USE_ROTATION_EXPANDED_ORIENTED_BOUNDS: i64 = 0x6;
                pub const USE_ROTATION_EXPANDED_SEQUENCE_BOUNDS: i64 = 0x8;
            };
            pub const WeaponGameplayAnimState = struct {
                pub const WPN_ANIMSTATE_IDLE: i64 = 0x32;
                pub const WPN_ANIMSTATE_CHARGE: i64 = 0x67;
                pub const WPN_ANIMSTATE_DEPLOY: i64 = 0xB;
                pub const WPN_ANIMSTATE_RELOAD: i64 = 0x320;
                pub const WPN_ANIMSTATE_DROPPED: i64 = 0x1;
                pub const WPN_ANIMSTATE_INSPECT: i64 = 0x3E8;
                pub const WPN_ANIMSTATE_C4_PLANT: i64 = 0x12C;
                pub const WPN_ANIMSTATE_END_VALID: i64 = 0x7D0;
                pub const WPN_ANIMSTATE_HOLSTERED: i64 = 0xA;
                pub const WPN_ANIMSTATE_RELOAD_OUTRO: i64 = 0x321;
                pub const WPN_ANIMSTATE_GRENADE_READY: i64 = 0xC9;
                pub const WPN_ANIMSTATE_GRENADE_THROW: i64 = 0xCA;
                pub const WPN_ANIMSTATE_INSPECT_OUTRO: i64 = 0x3E9;
                pub const WPN_ANIMSTATE_SHOOT_DRYFIRE: i64 = 0x66;
                pub const WPN_ANIMSTATE_SHOOT_PRIMARY: i64 = 0x64;
                pub const WPN_ANIMSTATE_UNINITIALIZED: i64 = 0x0;
                pub const WPN_ANIMSTATE_SILENCER_APPLY: i64 = 0x258;
                pub const WPN_ANIMSTATE_SHOOT_SECONDARY: i64 = 0x65;
                pub const WPN_ANIMSTATE_SILENCER_REMOVE: i64 = 0x259;
                pub const WPN_ANIMSTATE_GRENADE_PULL_PIN: i64 = 0xC8;
                pub const WPN_ANIMSTATE_HEALTHSHOT_INJECT: i64 = 0x190;
                pub const WPN_ANIMSTATE_KNIFE_PRIMARY_HIT: i64 = 0x1F4;
                pub const WPN_ANIMSTATE_KNIFE_PRIMARY_MISS: i64 = 0x1F5;
                pub const WPN_ANIMSTATE_KNIFE_PRIMARY_STAB: i64 = 0x1F8;
                pub const WPN_ANIMSTATE_INVENTORY_UI_TUMBLE: i64 = 0x5DC;
                pub const WPN_ANIMSTATE_KNIFE_SECONDARY_HIT: i64 = 0x1F6;
                pub const WPN_ANIMSTATE_KNIFE_SECONDARY_MISS: i64 = 0x1F7;
                pub const WPN_ANIMSTATE_KNIFE_SECONDARY_STAB: i64 = 0x1F9;
                pub const WPN_ANIMSTATE_INVENTORY_UI_KEYCHAIN_APPLY: i64 = 0x5DD;
            };
            pub const AnimGraphDebugDrawType_t = struct {
                pub const _None: i64 = 0x0;
                pub const MsPosition: i64 = 0x2;
                pub const WsPosition: i64 = 0x1;
                pub const MsDirection: i64 = 0x4;
                pub const WsDirection: i64 = 0x3;
            };
            pub const ChoreoLookAtConditions_t = struct {
                pub const DURING_OUTRO: i64 = 0x4;
                pub const WHILE_MOVING: i64 = 0x1;
                pub const WHILE_ANIMATING: i64 = 0x2;
            };
            pub const EContributionScoreFlag_t = struct {
                pub const k_EContributionScoreFlag_Bullets: i64 = 0x2;
                pub const k_EContributionScoreFlag_Default: i64 = 0x0;
                pub const k_EContributionScoreFlag_Objective: i64 = 0x1;
            };
            pub const ValueRemapperInputType_t = struct {
                pub const InputType_PlayerShootPosition: i64 = 0x0;
                pub const InputType_PlayerShootPositionAroundAxis: i64 = 0x1;
            };
            pub const attributeprovidertypes_t = struct {
                pub const PROVIDER_WEAPON: i64 = 0x1;
                pub const PROVIDER_GENERIC: i64 = 0x0;
            };
            pub const CDebugOverlayFilterType_t = struct {
                pub const NONE: i64 = 0x0;
                pub const TEXT: i64 = 0x1;
                pub const COUNT: i64 = 0x3;
                pub const ENTITY: i64 = 0x2;
                pub const AI_TASK: i64 = 0x6;
                pub const AI_EVENT: i64 = 0x7;
                pub const COMBINED: i64 = -0x1;
                pub const AI_SCHEDULE: i64 = 0x5;
                pub const AI_PATHFINDING: i64 = 0x8;
                pub const TACTICAL_SEARCH: i64 = 0x4;
                pub const END_SIM_HISTORY_TYPES: i64 = 0x9;
            };
            pub const CPhysicsProp__CrateType_t = struct {
                pub const CRATE_TYPE_COUNT: i64 = 0x1;
                pub const CRATE_SPECIFIC_ITEM: i64 = 0x0;
            };
            pub const PulseCursorWakePriority_t = struct {
                pub const WakeElegantly: i64 = 0x0;
                pub const WakeImmediate: i64 = 0x1;
            };
            pub const SVC_Messages_LowFrequency = struct {
                pub const svc_dummy: i64 = 0x258;
            };
            pub const SubclassVDataChangeType_t = struct {
                pub const SUBCLASS_VDATA_CREATED: i64 = 0x0;
                pub const SUBCLASS_VDATA_RELOADED: i64 = 0x2;
                pub const SUBCLASS_VDATA_SUBCLASS_CHANGED: i64 = 0x1;
            };
            pub const ValueRemapperOutputType_t = struct {
                pub const OutputType_RotationX: i64 = 0x1;
                pub const OutputType_RotationY: i64 = 0x2;
                pub const OutputType_RotationZ: i64 = 0x3;
                pub const OutputType_AnimationCycle: i64 = 0x0;
            };
            pub const DirectionAlongSimplePath_t = struct {
                pub const _None: i64 = 0x0;
                pub const TGoesUp: i64 = 0x1;
                pub const TGoesDown: i64 = 0x2;
            };
            pub const ESource2PlayStatsFieldType = struct {
                pub const Source2PlayStats_Bool: i64 = 0xB;
                pub const Source2PlayStats_Int8: i64 = 0x8;
                pub const Source2PlayStats_Int16: i64 = 0x7;
                pub const Source2PlayStats_Int32: i64 = 0x6;
                pub const Source2PlayStats_Int64: i64 = 0x5;
                pub const Source2PlayStats_UInt8: i64 = 0x4;
                pub const Source2PlayStats_String: i64 = 0xC;
                pub const Source2PlayStats_UInt16: i64 = 0x3;
                pub const Source2PlayStats_UInt32: i64 = 0x2;
                pub const Source2PlayStats_UInt64: i64 = 0x1;
                pub const Source2PlayStats_Float32: i64 = 0xA;
                pub const Source2PlayStats_Float64: i64 = 0x9;
                pub const Source2PlayStats_Invalid: i64 = 0x0;
                pub const Source2PlayStats_SteamID: i64 = 0x11;
                pub const Source2PlayStats_UTCDateTime: i64 = 0xE;
                pub const Source2PlayStats_SteamIDTrustBucket: i64 = 0xF;
                pub const Source2PlayStats_LowCardinalityString: i64 = 0xD;
                pub const Source2PlayStats_SteamIDTrustBucketMin: i64 = 0x10;
            };
            pub const PropDoorRotatingSpawnPos_t = struct {
                pub const DOOR_SPAWN_AJAR: i64 = 0x3;
                pub const DOOR_SPAWN_CLOSED: i64 = 0x0;
                pub const DOOR_SPAWN_OPEN_BACK: i64 = 0x2;
                pub const DOOR_SPAWN_OPEN_FORWARD: i64 = 0x1;
            };
            pub const ScriptedConflictResponse_t = struct {
                pub const SS_CONFLICT_ENQUEUE: i64 = 0x0;
                pub const SS_CONFLICT_INTERRUPT: i64 = 0x1;
            };
            pub const ValueRemapperHapticsType_t = struct {
                pub const HaticsType_None: i64 = 0x1;
                pub const HaticsType_Default: i64 = 0x0;
            };
            pub const ValueRemapperRatchetType_t = struct {
                pub const RatchetType_Absolute: i64 = 0x0;
                pub const RatchetType_EachEngage: i64 = 0x1;
            };
            pub const CSPlayerBlockingUseAction_t = struct {
                pub const k_CSPlayerBlockingUseAction_None: i64 = 0x0;
                pub const k_CSPlayerBlockingUseAction_MaxCount: i64 = 0x7;
                pub const k_CSPlayerBlockingUseAction_DefusingDefault: i64 = 0x1;
                pub const k_CSPlayerBlockingUseAction_DefusingWithKit: i64 = 0x2;
                pub const k_CSPlayerBlockingUseAction_HostageDropping: i64 = 0x4;
                pub const k_CSPlayerBlockingUseAction_HostageGrabbing: i64 = 0x3;
                pub const k_CSPlayerBlockingUseAction_MapLongUseEntity_Place: i64 = 0x6;
                pub const k_CSPlayerBlockingUseAction_MapLongUseEntity_Pickup: i64 = 0x5;
            };
            pub const ENetworkDisconnectionReason = struct {
                pub const NETWORK_DISCONNECT_LOST: i64 = 0x4;
                pub const NETWORK_DISCONNECT_KICKED: i64 = 0x27;
                pub const NETWORK_DISCONNECT_EXITING: i64 = 0x3B;
                pub const NETWORK_DISCONNECT_INVALID: i64 = 0x0;
                pub const NETWORK_DISCONNECT_UNUSUAL: i64 = 0x54;
                pub const NETWORK_DISCONNECT_USERCMD: i64 = 0x2D;
                pub const NETWORK_DISCONNECT_BANADDED: i64 = 0x28;
                pub const NETWORK_DISCONNECT_HLTVSTOP: i64 = 0x26;
                pub const NETWORK_DISCONNECT_OVERFLOW: i64 = 0x5;
                pub const NETWORK_DISCONNECT_SHUTDOWN: i64 = 0x1;
                pub const NETWORK_DISCONNECT_TIMEDOUT: i64 = 0x1D;
                pub const NETWORK_DISCONNECT_HLTVDIRECT: i64 = 0x2A;
                pub const NETWORK_DISCONNECT_KICKED_IDLE: i64 = 0x9E;
                pub const NETWORK_DISCONNECT_STEAM_INUSE: i64 = 0x7;
                pub const NETWORK_DISCONNECT_STEAM_LOGON: i64 = 0x9;
                pub const NETWORK_DISCONNECT_BADDELTATICK: i64 = 0x1B;
                pub const NETWORK_DISCONNECT_DISCONNECTED: i64 = 0x1E;
                pub const NETWORK_DISCONNECT_HOST_ENDGAME: i64 = 0x38;
                pub const NETWORK_DISCONNECT_KICKBANADDED: i64 = 0x29;
                pub const NETWORK_DISCONNECT_LEAVINGSPLIT: i64 = 0x1F;
                pub const NETWORK_DISCONNECT_LOOPSHUTDOWN: i64 = 0x36;
                pub const NETWORK_DISCONNECT_NOMORESPLITS: i64 = 0x1C;
                pub const NETWORK_DISCONNECT_NOSPECTATORS: i64 = 0x24;
                pub const NETWORK_DISCONNECT_RECONNECTION: i64 = 0x35;
                pub const NETWORK_DISCONNECT_REJECT_STEAM: i64 = 0x92;
                pub const NETWORK_DISCONNECT_REMOTE_OTHER: i64 = 0x51;
                pub const NETWORK_DISCONNECT_STEAM_BANNED: i64 = 0x6;
                pub const NETWORK_DISCONNECT_STEAM_TICKET: i64 = 0x8;
                pub const NETWORK_DISCONNECT_CLIENT_NO_MAP: i64 = 0x40;
                pub const NETWORK_DISCONNECT_REJECT_BANNED: i64 = 0x95;
                pub const NETWORK_DISCONNECT_SNAPSHOTERROR: i64 = 0x19;
                pub const NETWORK_DISCONNECT_STEAM_DROPPED: i64 = 0x10;
                pub const NETWORK_DISCONNECT_HLTVRESTRICTED: i64 = 0x23;
                pub const NETWORK_DISCONNECT_INTERNAL_ERROR: i64 = 0x55;
                pub const NETWORK_DISCONNECT_KICKED_SUICIDE: i64 = 0x9F;
                pub const NETWORK_DISCONNECT_LOOPDEACTIVATE: i64 = 0x37;
                pub const NETWORK_DISCONNECT_REJECT_NOLOBBY: i64 = 0x81;
                pub const NETWORK_DISCONNECT_REMOTE_TIMEOUT: i64 = 0x4F;
                pub const NETWORK_DISCONNECT_HLTVUNAVAILABLE: i64 = 0x25;
                pub const NETWORK_DISCONNECT_KICKED_TK_START: i64 = 0x97;
                pub const NETWORK_DISCONNECT_KICKED_VOTEDOFF: i64 = 0x9D;
                pub const NETWORK_DISCONNECT_REMOTE_BADCRYPT: i64 = 0x52;
                pub const NETWORK_DISCONNECT_SERVER_SHUTDOWN: i64 = 0x45;
                pub const NETWORK_DISCONNECT_STEAM_DENY_MISC: i64 = 0x43;
                pub const NETWORK_DISCONNECT_STEAM_OWNERSHIP: i64 = 0x11;
                pub const NETWORK_DISCONNECT_BADRELAYPASSWORD: i64 = 0x21;
                pub const NETWORK_DISCONNECT_REJECTED_BY_GAME: i64 = 0x2E;
                pub const NETWORK_DISCONNECT_RELIABLEOVERFLOW: i64 = 0x1A;
                pub const NETWORK_DISCONNECT_SNAPSHOTOVERFLOW: i64 = 0x18;
                pub const NETWORK_DISCONNECT_TICKMSG_OVERFLOW: i64 = 0x13;
                pub const NETWORK_DISCONNECT_REJECT_SERVERFULL: i64 = 0x87;
                pub const NETWORK_DISCONNECT_STEAM_AUTHINVALID: i64 = 0xC;
                pub const NETWORK_DISCONNECT_STEAM_VACBANSTATE: i64 = 0xD;
                pub const NETWORK_DISCONNECT_CONNECTION_FAILURE: i64 = 0x33;
                pub const NETWORK_DISCONNECT_DISCONNECT_BY_USER: i64 = 0x2;
                pub const NETWORK_DISCONNECT_KICKED_TEAMHURTING: i64 = 0x9B;
                pub const NETWORK_DISCONNECT_KICKED_TEAMKILLING: i64 = 0x96;
                pub const NETWORK_DISCONNECT_LOCALPROBLEM_OTHER: i64 = 0x4D;
                pub const NETWORK_DISCONNECT_REJECT_BADPASSWORD: i64 = 0x86;
                pub const NETWORK_DISCONNECT_REJECT_HIDDEN_GAME: i64 = 0x84;
                pub const NETWORK_DISCONNECT_REJECT_LANRESTRICT: i64 = 0x85;
                pub const NETWORK_DISCONNECT_REJECT_NEWPROTOCOL: i64 = 0x8E;
                pub const NETWORK_DISCONNECT_REJECT_OLDPROTOCOL: i64 = 0x8D;
                pub const NETWORK_DISCONNECT_SOUNDSMSG_OVERFLOW: i64 = 0x17;
                pub const NETWORK_DISCONNECT_BAD_SERVER_PASSWORD: i64 = 0x31;
                pub const NETWORK_DISCONNECT_KICKED_NOSTEAMLOGIN: i64 = 0xA0;
                pub const NETWORK_DISCONNECT_MESSAGE_PARSE_ERROR: i64 = 0x2F;
                pub const NETWORK_DISCONNECT_PURESERVER_MISMATCH: i64 = 0x2C;
                pub const NETWORK_DISCONNECT_REJECT_BADCHALLENGE: i64 = 0x80;
                pub const NETWORK_DISCONNECT_REPLAY_INCOMPATIBLE: i64 = 0x47;
                pub const NETWORK_DISCONNECT_SERVERINFO_OVERFLOW: i64 = 0x12;
                pub const NETWORK_DISCONNECT_SERVER_INCOMPATIBLE: i64 = 0x49;
                pub const NETWORK_DISCONNECT_STEAM_AUTHCANCELLED: i64 = 0xA;
                pub const NETWORK_DISCONNECT_TEMPENTMSG_OVERFLOW: i64 = 0x16;
                pub const NETWORK_DISCONNECT_BADSPECTATORPASSWORD: i64 = 0x22;
                pub const NETWORK_DISCONNECT_CLIENT_DIFFERENT_MAP: i64 = 0x41;
                pub const NETWORK_DISCONNECT_CREATE_SERVER_FAILED: i64 = 0x3A;
                pub const NETWORK_DISCONNECT_DELTAENTMSG_OVERFLOW: i64 = 0x15;
                pub const NETWORK_DISCONNECT_DIFFERENTCLASSTABLES: i64 = 0x20;
                pub const NETWORK_DISCONNECT_DISCONNECT_BY_SERVER: i64 = 0x3;
                pub const NETWORK_DISCONNECT_KICKED_NOSTEAMTICKET: i64 = 0xA1;
                pub const NETWORK_DISCONNECT_REJECT_FAILEDCHANNEL: i64 = 0x89;
                pub const NETWORK_DISCONNECT_REJECT_SINGLE_PLAYER: i64 = 0x83;
                pub const NETWORK_DISCONNECT_INVALID_MESSAGE_ERROR: i64 = 0x30;
                pub const NETWORK_DISCONNECT_KICKED_HOSTAGEKILLING: i64 = 0x9C;
                pub const NETWORK_DISCONNECT_KICKED_INSECURECLIENT: i64 = 0xA4;
                pub const NETWORK_DISCONNECT_REJECT_BACKGROUND_MAP: i64 = 0x82;
                pub const NETWORK_DISCONNECT_REJECT_INVALIDCERTLEN: i64 = 0x90;
                pub const NETWORK_DISCONNECT_REMOTE_CERTNOTTRUSTED: i64 = 0x53;
                pub const NETWORK_DISCONNECT_SERVER_REQUIRES_STEAM: i64 = 0x42;
                pub const NETWORK_DISCONNECT_STEAM_AUTHALREADYUSED: i64 = 0xB;
                pub const NETWORK_DISCONNECT_KICKED_INPUTAUTOMATION: i64 = 0xA2;
                pub const NETWORK_DISCONNECT_NO_PEER_GROUP_HANDLERS: i64 = 0x34;
                pub const NETWORK_DISCONNECT_PURESERVER_CLIENTEXTRA: i64 = 0x2B;
                pub const NETWORK_DISCONNECT_REQUEST_HOSTSTATE_IDLE: i64 = 0x3C;
                pub const NETWORK_DISCONNECT_CLIENT_CONSISTENCY_FAIL: i64 = 0x3E;
                pub const NETWORK_DISCONNECT_KICKED_CONVICTEDACCOUNT: i64 = 0x99;
                pub const NETWORK_DISCONNECT_KICKED_UNTRUSTEDACCOUNT: i64 = 0x98;
                pub const NETWORK_DISCONNECT_LOCALPROBLEM_MANYRELAYS: i64 = 0x4A;
                pub const NETWORK_DISCONNECT_LOOP_LEVELLOAD_ACTIVATE: i64 = 0x39;
                pub const NETWORK_DISCONNECT_REJECT_INVALIDKEYLENGTH: i64 = 0x8C;
                pub const NETWORK_DISCONNECT_STRINGTABLEMSG_OVERFLOW: i64 = 0x14;
                pub const NETWORK_DISCONNECT_CLIENT_UNABLE_TO_CRC_MAP: i64 = 0x3F;
                pub const NETWORK_DISCONNECT_CONNECT_REQUEST_TIMEDOUT: i64 = 0x48;
                pub const NETWORK_DISCONNECT_REJECT_INVALIDCONNECTION: i64 = 0x8F;
                pub const NETWORK_DISCONNECT_STEAM_VAC_CHECK_TIMEDOUT: i64 = 0xF;
                pub const NETWORK_DISCONNECT_REJECT_CONNECT_FROM_LOBBY: i64 = 0x8A;
                pub const NETWORK_DISCONNECT_REJECT_INVALIDRESERVATION: i64 = 0x88;
                pub const NETWORK_DISCONNECT_REJECT_RESERVED_FOR_LOBBY: i64 = 0x8B;
                pub const NETWORK_DISCONNECT_REJECT_SERVERAUTHDISABLED: i64 = 0x93;
                pub const NETWORK_DISCONNECT_REMOTE_TIMEOUT_CONNECTING: i64 = 0x50;
                pub const NETWORK_DISCONNECT_STEAM_DENY_BAD_ANTI_CHEAT: i64 = 0x44;
                pub const NETWORK_DISCONNECT_STEAM_LOGGED_IN_ELSEWHERE: i64 = 0xE;
                pub const NETWORK_DISCONNECT_DIRECT_CONNECT_RESERVATION: i64 = 0x32;
                pub const NETWORK_DISCONNECT_KICKED_COMPETITIVECOOLDOWN: i64 = 0x9A;
                pub const NETWORK_DISCONNECT_LOCALPROBLEM_NETWORKCONFIG: i64 = 0x4C;
                pub const NETWORK_DISCONNECT_REJECT_INVALIDSTEAMCERTLEN: i64 = 0x91;
                pub const NETWORK_DISCONNECT_REQUEST_HOSTSTATE_HLTVRELAY: i64 = 0x3D;
                pub const NETWORK_DISCONNECT_KICKED_VACNETABNORMALBEHAVIOR: i64 = 0xA3;
                pub const NETWORK_DISCONNECT_REJECT_SERVERCDKEYAUTHINVALID: i64 = 0x94;
                pub const NETWORK_DISCONNECT_LOCALPROBLEM_HOSTEDSERVERPRIMARYRELAY: i64 = 0x4B;
            };
            pub const PulseCursorCancelPriority_t = struct {
                pub const _None: i64 = 0x0;
                pub const HardCancel: i64 = 0x3;
                pub const SoftCancel: i64 = 0x2;
                pub const CancelOnSucceeded: i64 = 0x1;
            };
            pub const SequenceFinishNotifyState_t = struct {
                pub const eDoNotNotify: i64 = 0x0;
                pub const eNotifyTriggered: i64 = 0x2;
                pub const eNotifyWhenFinished: i64 = 0x1;
            };
            pub const ValueRemapperMomentumType_t = struct {
                pub const MomentumType_None: i64 = 0x0;
                pub const MomentumType_Friction: i64 = 0x1;
                pub const MomentumType_SpringTowardSnapValue: i64 = 0x2;
                pub const MomentumType_SpringAwayFromSnapValue: i64 = 0x3;
            };
            pub const WorldTextPanelOrientation_t = struct {
                pub const WORLDTEXT_ORIENTATION_DEFAULT: i64 = 0x0;
                pub const WORLDTEXT_ORIENTATION_FACEUSER: i64 = 0x1;
                pub const WORLDTEXT_ORIENTATION_FACEUSER_UPRIGHT: i64 = 0x2;
            };
            pub const CDebugOverlayCombinedTypes_t = struct {
                pub const ALL: i64 = 0x0;
                pub const ANY: i64 = 0x1;
                pub const COUNT: i64 = 0x2;
            };
            pub const CFuncRotator__RotationAxis_t = struct {
                pub const ROTATION_AXIS_YAW: i64 = 0x1;
                pub const ROTATION_AXIS_ROLL: i64 = 0x3;
                pub const ROTATION_AXIS_PITCH: i64 = 0x2;
                pub const ROTATION_AXIS_UNDEFINED: i64 = 0x0;
            };
            pub const CRR_Response__ResponseEnum_t = struct {
                pub const MAX_RULE_NAME: i64 = 0x80;
                pub const MAX_RESPONSE_NAME: i64 = 0xC0;
            };
            pub const LessonPanelLayoutFileTypes_t = struct {
                pub const LAYOUT_CUSTOM: i64 = 0x2;
                pub const LAYOUT_HAND_DEFAULT: i64 = 0x0;
                pub const LAYOUT_WORLD_DEFAULT: i64 = 0x1;
            };
            pub const PointWorldTextReorientMode_t = struct {
                pub const POINT_WORLD_TEXT_REORIENT_NONE: i64 = 0x0;
                pub const POINT_WORLD_TEXT_REORIENT_AROUND_UP: i64 = 0x1;
            };
            pub const CDebugOverlayFilterTextType_t = struct {
                pub const COUNT: i64 = 0x3;
                pub const MATCH: i64 = 0x1;
                pub const HIERARCHY: i64 = 0x2;
                pub const FILTER_TEXT_NONE: i64 = 0x0;
            };
            pub const CInfoChoreoLocatorShapeType_t = struct {
                pub const LINE: i64 = 0x1;
                pub const NONE: i64 = 0x4;
                pub const COUNT: i64 = 0x3;
                pub const POINT: i64 = 0x0;
                pub const RADIUS: i64 = 0x2;
            };
            pub const ShatterGlassEntityPoolState_t = struct {
                pub const ENTITY_POOL_STATE_IN_USE: i64 = 0x2;
                pub const ENTITY_POOL_STATE_INVALID: i64 = 0x0;
                pub const ENTITY_POOL_STATE_AVAILABLE: i64 = 0x1;
            };
            pub const WorldTextPanelVerticalAlign_t = struct {
                pub const WORLDTEXT_VERTICAL_ALIGN_TOP: i64 = 0x0;
                pub const WORLDTEXT_VERTICAL_ALIGN_BOTTOM: i64 = 0x2;
                pub const WORLDTEXT_VERTICAL_ALIGN_CENTER: i64 = 0x1;
            };
            pub const CFuncMover__FollowConstraint_t = struct {
                pub const FOLLOW_CONSTRAINT_RATIO: i64 = 0x2;
                pub const FOLLOW_CONSTRAINT_SPRING: i64 = 0x1;
                pub const FOLLOW_CONSTRAINT_COUPLER: i64 = 0x3;
                pub const FOLLOW_CONSTRAINT_DISTANCE: i64 = 0x0;
            };
            pub const IChoreoServices__ChoreoState_t = struct {
                pub const STATE_PRE_SCRIPT: i64 = 0x0;
                pub const STATE_PLAY_SCRIPT: i64 = 0x4;
                pub const STATE_WALK_TO_MARK: i64 = 0x2;
                pub const STATE_WAIT_FOR_SCRIPT: i64 = 0x1;
                pub const STATE_SYNCHRONIZE_SCRIPT: i64 = 0x3;
                pub const STATE_PLAY_SCRIPT_POST_IDLE: i64 = 0x5;
                pub const STATE_PLAY_SCRIPT_POST_IDLE_DONE: i64 = 0x6;
            };
            pub const IChoreoServices__ScriptState_t = struct {
                pub const SCRIPT_WAIT: i64 = 0x1;
                pub const SCRIPT_CLEANUP: i64 = 0x3;
                pub const SCRIPT_PLAYING: i64 = 0x0;
                pub const SCRIPT_POST_IDLE: i64 = 0x2;
                pub const SCRIPT_MOVE_TO_MARK: i64 = 0x4;
            };
            pub const PointOrientGoalDirectionType_t = struct {
                pub const eHead: i64 = 0x2;
                pub const eCenter: i64 = 0x1;
                pub const eForward: i64 = 0x3;
                pub const eAbsOrigin: i64 = 0x0;
                pub const eEyesForward: i64 = 0x4;
            };
            pub const BeginDeathLifeStateTransition_t = struct {
                pub const TRANSITION_TO_LIFESTATE_DEAD: i64 = 0x1;
                pub const TRANSITION_TO_LIFESTATE_DYING: i64 = 0x0;
            };
            pub const CFuncMover__OrientationUpdate_t = struct {
                pub const ORIENTATION_FIXED: i64 = 0x4;
                pub const ORIENTATION_FACE_ENTITY: i64 = 0x8;
                pub const ORIENTATION_FACE_PLAYER: i64 = 0x5;
                pub const ORIENTATION_FORWARD_PATH: i64 = 0x0;
                pub const ORIENTATION_MATCH_CONTROL_POINT: i64 = 0x3;
                pub const ORIENTATION_FORWARD_MOVEMENT_DIRECTION: i64 = 0x6;
                pub const ORIENTATION_FORWARD_PATH_AND_FIXED_PITCH: i64 = 0x1;
                pub const ORIENTATION_FORWARD_PATH_AND_UP_CONTROL_POINT: i64 = 0x2;
                pub const ORIENTATION_FORWARD_MOVEMENT_DIRECTION_AND_UP_CONTROL_POINT: i64 = 0x7;
            };
            pub const FuncMoverMovementSummaryFlags_t = struct {
                pub const eNone: i64 = 0x0;
                pub const eLoopToEnd: i64 = 0x40;
                pub const eReversing: i64 = 0x8;
                pub const eStopBegin: i64 = 0x2;
                pub const eLoopToStart: i64 = 0x20;
                pub const eStopComplete: i64 = 0x4;
                pub const eMovementBegin: i64 = 0x1;
                pub const eEventsDispatched: i64 = 0x10;
                pub const eTransitionComplete: i64 = 0x80;
                pub const eStoppedDuringTransition: i64 = 0x100;
            };
            pub const INavObstacle__NavObstacleType_t = struct {
                pub const NAV_OBSTACLE_TYPE_CONN: i64 = 0x2;
                pub const NAV_OBSTACLE_TYPE_NONE: i64 = 0x0;
                pub const NAV_OBSTACLE_TYPE_AVOID: i64 = 0x1;
                pub const NAV_OBSTACLE_TYPE_BLOCK: i64 = 0x3;
                pub const NAV_OBSTACLE_TYPE_INVALID: i64 = -0x1;
                pub const NAV_OBSTACLE_TYPE_PERMANENT_BLOCK: i64 = 0x4;
            };
            pub const PointWorldTextJustifyVertical_t = struct {
                pub const POINT_WORLD_TEXT_JUSTIFY_VERTICAL_TOP: i64 = 0x2;
                pub const POINT_WORLD_TEXT_JUSTIFY_VERTICAL_BOTTOM: i64 = 0x0;
                pub const POINT_WORLD_TEXT_JUSTIFY_VERTICAL_CENTER: i64 = 0x1;
            };
            pub const PreviewCharacterBannerAnimation = struct {
                pub const INVALID: i64 = -0x1;
                pub const BANNER_FIRE: i64 = 0x14;
                pub const BANNER_3SHOT_A: i64 = 0x8;
                pub const BANNER_3SHOT_B: i64 = 0x9;
                pub const BANNER_3SHOT_C: i64 = 0xA;
                pub const BANNER_4SHOT_A: i64 = 0xC;
                pub const BANNER_4SHOT_B: i64 = 0xD;
                pub const BANNER_4SHOT_C: i64 = 0xE;
                pub const BANNER_4SHOT_D: i64 = 0xF;
                pub const IDLE_OFFSCREEN: i64 = 0x0;
                pub const BANNER_AWP_ACE_A: i64 = 0x2;
                pub const BANNER_AWP_ACE_B: i64 = 0x3;
                pub const BANNER_AWP_ACE_C: i64 = 0x4;
                pub const BANNER_AWP_ACE_D: i64 = 0x5;
                pub const BANNER_AWP_ACE_E: i64 = 0x6;
                pub const BANNER_BOMB_PLANT: i64 = 0x11;
                pub const BANNER_AWP_ACE_GUN: i64 = 0x1;
                pub const BANNER_PISTOL3SHOT: i64 = 0x7;
                pub const BANNER_PISTOL4SHOT: i64 = 0xB;
                pub const BANNER_BOMB_BLAST01: i64 = 0x16;
                pub const BANNER_BOMB_BLAST02: i64 = 0x17;
                pub const BANNER_BOMB_BLAST03: i64 = 0x18;
                pub const BANNER_CELEBRATE_01: i64 = 0x19;
                pub const BANNER_CELEBRATE_02: i64 = 0x1A;
                pub const BANNER_CELEBRATE_03: i64 = 0x1B;
                pub const BANNER_CELEBRATE_04: i64 = 0x1C;
                pub const BANNER_BOMB_BLAST_TOSS: i64 = 0x15;
                pub const BANNER_BOMB_DEFUSAL_VER1: i64 = 0x12;
                pub const BANNER_BOMB_DEFUSAL_VER2: i64 = 0x13;
                pub const CELEBRATE_STRETCH_NOWEAP_IDLE0: i64 = 0x10;
            };
            pub const PropDoorRotatingOpenDirection_e = struct {
                pub const DOOR_ROTATING_OPEN_FORWARD: i64 = 0x1;
                pub const DOOR_ROTATING_OPEN_BACKWARD: i64 = 0x2;
                pub const DOOR_ROTATING_OPEN_BOTH_WAYS: i64 = 0x0;
            };
            pub const WorldTextPanelHorizontalAlign_t = struct {
                pub const WORLDTEXT_HORIZONTAL_ALIGN_LEFT: i64 = 0x0;
                pub const WORLDTEXT_HORIZONTAL_ALIGN_RIGHT: i64 = 0x2;
                pub const WORLDTEXT_HORIZONTAL_ALIGN_CENTER: i64 = 0x1;
            };
            pub const EGCItemCustomizationNotification = struct {
                pub const k_EGCItemCustomizationNotification_NameItem: i64 = 0x3EE;
                pub const k_EGCItemCustomizationNotification_ApplyPatch: i64 = 0x442;
                pub const k_EGCItemCustomizationNotification_CasketAdded: i64 = 0x3F5;
                pub const k_EGCItemCustomizationNotification_RemovePatch: i64 = 0x441;
                pub const k_EGCItemCustomizationNotification_UnlockCrate: i64 = 0x3EF;
                pub const k_EGCItemCustomizationNotification_ApplySticker: i64 = 0x43E;
                pub const k_EGCItemCustomizationNotification_NameBaseItem: i64 = 0x3FB;
                pub const k_EGCItemCustomizationNotification_StatTrakSwap: i64 = 0x440;
                pub const k_EGCItemCustomizationNotification_ApplyKeychain: i64 = 0x443;
                pub const k_EGCItemCustomizationNotification_CasketInvFull: i64 = 0x3F7;
                pub const k_EGCItemCustomizationNotification_CasketRemoved: i64 = 0x3F6;
                pub const k_EGCItemCustomizationNotification_CasketTooFull: i64 = 0x3F3;
                pub const k_EGCItemCustomizationNotification_RemoveSticker: i64 = 0x41D;
                pub const k_EGCItemCustomizationNotification_XRayItemClaim: i64 = 0x3F1;
                pub const k_EGCItemCustomizationNotification_CasketContents: i64 = 0x3F4;
                pub const k_EGCItemCustomizationNotification_ExtractSticker: i64 = 0x41E;
                pub const k_EGCItemCustomizationNotification_GraffitiUnseal: i64 = 0x23E1;
                pub const k_EGCItemCustomizationNotification_RemoveItemName: i64 = 0x406;
                pub const k_EGCItemCustomizationNotification_RemoveKeychain: i64 = 0x444;
                pub const k_EGCItemCustomizationNotification_XRayItemReveal: i64 = 0x3F0;
                pub const k_EGCItemCustomizationNotification_XpShopAckTracks: i64 = 0x2406;
                pub const k_EGCItemCustomizationNotification_XpShopUseTicket: i64 = 0x2405;
                pub const k_EGCItemCustomizationNotification_ActivateFanToken: i64 = 0x23DA;
                pub const k_EGCItemCustomizationNotification_GenerateSouvenir: i64 = 0x23F4;
                pub const k_EGCItemCustomizationNotification_EncapsulateSticker: i64 = 0x41F;
                pub const k_EGCItemCustomizationNotification_ActivateOperationCoin: i64 = 0x23DB;
                pub const k_EGCItemCustomizationNotification_ClientRedeemFreeReward: i64 = 0x2403;
                pub const k_EGCItemCustomizationNotification_ClientRedeemMissionReward: i64 = 0x23F9;
            };
            pub const CFuncMover__PathRebuildStrategy_t = struct {
                pub const PATH_REBUILD_DONT_MOVE: i64 = 0x0;
                pub const PATH_REBUILD_MAINTAIN_T: i64 = 0x1;
                pub const PATH_REBUILD_USE_CURRENT_NODE_T: i64 = 0x2;
            };
            pub const FuncRotatorRotationSummaryFlags_t = struct {
                pub const eNone: i64 = 0x0;
                pub const eRotateBegin: i64 = 0x1;
                pub const eOscillateEnd: i64 = 0x10;
                pub const eOscillateStart: i64 = 0x8;
                pub const eOscillateDepart: i64 = 0x40;
                pub const eRotateCompleted: i64 = 0x4;
                pub const eEventsDispatched: i64 = 0x2;
                pub const eOscillateArrived: i64 = 0x20;
            };
            pub const PointWorldTextJustifyHorizontal_t = struct {
                pub const POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_LEFT: i64 = 0x0;
                pub const POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_RIGHT: i64 = 0x2;
                pub const POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_CENTER: i64 = 0x1;
            };
            pub const TestInputOutputCombinationsEnum_t = struct {
                pub const ONE: i64 = 0x1;
                pub const TWO: i64 = 0x2;
                pub const ZERO: i64 = 0x0;
            };
            pub const ECSUsrMsg_DisconnectToLobby_Action = struct {
                pub const k_ECSUsrMsg_DisconnectToLobby_Action_Default: i64 = 0x0;
                pub const k_ECSUsrMsg_DisconnectToLobby_Action_GoQueue: i64 = 0x1;
            };
            pub const PointTemplateOwnerSpawnGroupType_t = struct {
                pub const INSERT_INTO_NEWLY_CREATED_SPAWN_GROUP: i64 = 0x2;
                pub const INSERT_INTO_POINT_TEMPLATE_SPAWN_GROUP: i64 = 0x0;
                pub const INSERT_INTO_CURRENTLY_ACTIVE_SPAWN_GROUP: i64 = 0x1;
            };
            pub const CCSPlayerAnimationState__MoveType_t = struct {
                pub const Air: i64 = 0x2;
                pub const _None: i64 = 0x0;
                pub const Ground: i64 = 0x1;
                pub const Ladder: i64 = 0x3;
            };
            pub const CFuncMover__FollowEntityDirection_t = struct {
                pub const FOLLOW_ENTITY_FORWARD: i64 = 0x1;
                pub const FOLLOW_ENTITY_REVERSE: i64 = 0x2;
                pub const FOLLOW_ENTITY_BIDIRECTIONAL: i64 = 0x0;
            };
            pub const ExternalAnimGraphInactiveBehavior_t = struct {
                pub const eNone: i64 = 0x0;
                pub const eUnbind: i64 = 0x1;
                pub const eUnbindAndDelete: i64 = 0x2;
            };
            pub const CCSPlayerAnimationState__AirAction_t = struct {
                pub const Jump: i64 = 0x1;
                pub const Land: i64 = 0x3;
                pub const _None: i64 = 0x0;
                pub const StartFall: i64 = 0x2;
            };
            pub const CCSPlayerAnimationState__Direction_t = struct {
                pub const E: i64 = 0x3;
                pub const N: i64 = 0x1;
                pub const S: i64 = 0x5;
                pub const W: i64 = 0x7;
                pub const NE: i64 = 0x2;
                pub const NW: i64 = 0x8;
                pub const SE: i64 = 0x4;
                pub const SW: i64 = 0x6;
                pub const _None: i64 = 0x0;
            };
            pub const CFuncMover__FindFollowMoverStrategy_t = struct {
                pub const FIND_FOLLOW_MOVER_FORWARD_CLOSEST: i64 = 0x0;
                pub const FIND_FOLLOW_MOVER_REVERSE_CLOSEST: i64 = 0x1;
                pub const FIND_FOLLOW_MOVER_BIDIRECTIONAL_CLOSEST: i64 = 0x2;
            };
            pub const ChoreoExternalAnimgraphControlState_t = struct {
                pub const eExit: i64 = 0x1;
                pub const eNone: i64 = 0x0;
                pub const eCount: i64 = 0x9;
                pub const eLooping: i64 = 0x8;
                pub const eState01: i64 = 0x3;
                pub const eState02: i64 = 0x4;
                pub const eState03: i64 = 0x5;
                pub const eState04: i64 = 0x6;
                pub const eState05: i64 = 0x7;
                pub const eFallbackExit: i64 = 0x2;
            };
            pub const EDestructiblePartDamagePassThroughType = struct {
                pub const Absorb: i64 = 0x1;
                pub const Normal: i64 = 0x0;
                pub const InvincibleAbsorb: i64 = 0x2;
                pub const InvinciblePassthrough: i64 = 0x3;
            };
            pub const EDestructiblePartRadiusDamageApplyType = struct {
                pub const PrioritizeClosestPart: i64 = 0x1;
                pub const ScaleByExplosionRadius: i64 = 0x0;
            };
            pub const PointTemplateClientOnlyEntityBehavior_t = struct {
                pub const CREATE_FOR_CLIENTS_WHO_CONNECT_LATER: i64 = 0x1;
                pub const CREATE_FOR_CURRENTLY_CONNECTED_CLIENTS_ONLY: i64 = 0x0;
            };
            pub const CFuncMover__TransitionToPathNodeAction_t = struct {
                pub const TRANSITION_TO_PATH_NODE_ACTION_NONE: i64 = 0x0;
                pub const TRANSITION_TO_PATH_NODE_TRANSITIONING: i64 = 0x3;
                pub const TRANSITION_TO_PATH_NODE_ACTION_START_FORWARD: i64 = 0x1;
                pub const TRANSITION_TO_PATH_NODE_ACTION_START_REVERSE: i64 = 0x2;
            };
            pub const EDestructibleParts_DestroyParameterFlags = struct {
                pub const _None: i64 = 0x0;
                pub const Default: i64 = 0x7;
                pub const EnableFlinches: i64 = 0x4;
                pub const ForceDamageApply: i64 = 0x8;
                pub const ApplyPhysicsForce: i64 = 0x40;
                pub const IgnoreHealthCheck: i64 = 0x20;
                pub const GenerateBreakpieces: i64 = 0x1;
                pub const IgnoreKillEntityFlag: i64 = 0x10;
                pub const SetBodyGroupAndCollisionState: i64 = 0x2;
            };
            pub const CCSPlayerAnimationState__GroundMoveState_t = struct {
                pub const Idle: i64 = 0x1;
                pub const Move: i64 = 0x3;
                pub const _None: i64 = 0x0;
                pub const Start: i64 = 0x2;
                pub const TurnOnSpot: i64 = 0x4;
                pub const PlantAndTurn: i64 = 0x6;
                pub const TurnOnSpotLoop: i64 = 0x5;
            };
            pub const DestructiblePartDestructionDeathBehavior_t = struct {
                pub const eGib: i64 = 0x2;
                pub const eKill: i64 = 0x1;
                pub const eRemove: i64 = 0x3;
                pub const eDoNotKill: i64 = 0x0;
            };
            pub const EProceduralRagdollWeightIndexPropagationMethod = struct {
                pub const Bone: i64 = 0x0;
                pub const BoneAndChildren: i64 = 0x1;
            };
            pub const CLogicBranchList__LogicBranchListenerLastState_t = struct {
                pub const LOGIC_BRANCH_LISTENER_MIXED: i64 = 0x3;
                pub const LOGIC_BRANCH_LISTENER_ALL_TRUE: i64 = 0x1;
                pub const LOGIC_BRANCH_LISTENER_NOT_INIT: i64 = 0x0;
                pub const LOGIC_BRANCH_LISTENER_ALL_FALSE: i64 = 0x2;
            };
            pub const CPathMoverEntitySpawner__TemplateChoiceStrategy_t = struct {
                pub const TEMPLATE_CHOICE_COUNT_RANDOM: i64 = 0x2;
                pub const TEMPLATE_CHOICE_WEIGHTED_RANDOM: i64 = 0x1;
                pub const TEMPLATE_CHOICE_COUNT_SEQUENTIAL: i64 = 0x0;
            };
        };
    };
};
