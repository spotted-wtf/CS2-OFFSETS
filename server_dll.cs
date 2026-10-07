public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class server_dll {
            public static partial class CC4 {
                public const long m_fArmedTime = 0x12CC;
                public const long m_nSpotRules = 0x12F0;
                public const long m_bBombPlanted = 0x12FB;
                public const long m_bStartedArming = 0x12C9;
                public const long m_bIsPlantingViaUse = 0x12D1;
                public const long m_bPlayedArmingBeeps = 0x12F4;
                public const long m_entitySpottedState = 0x12D8;
                public const long m_bBombPlacedAnimation = 0x12D0;
                public const long m_vecLastValidDroppedPosition = 0x12BC;
                public const long m_bDoValidDroppedPositionCheck = 0x12C8;
                public const long m_vecLastValidPlayerHeldPosition = 0x12B0;
            }
            public static partial class CBot {
                public const long m_id = 0x24;
                public const long m_pPlayer = 0x18;
                public const long m_isRunning = 0xC0;
                public const long m_leftSpeed = 0xC8;
                public const long m_bHasSpawned = 0x20;
                public const long m_buttonFlags = 0xD0;
                public const long m_isCrouching = 0xC1;
                public const long m_pController = 0x10;
                public const long m_viewForward = 0xDC;
                public const long m_forwardSpeed = 0xC4;
                public const long m_jumpTimestamp = 0xD8;
                public const long m_verticalSpeed = 0xCC;
                public const long m_postureStackIndex = 0xF8;
            }
            public static partial class CAK47 {

            }
            public static partial class CBeam {
                public const long m_fSpeed = 0x8CC;
                public const long m_fWidth = 0x8B4;
                public const long m_flFrame = 0x8D0;
                public const long m_flDamage = 0x85C;
                public const long m_fEndWidth = 0x8B8;
                public const long m_nBeamType = 0x878;
                public const long m_vecEndPos = 0x8D8;
                public const long m_bTurnedOff = 0x8D4;
                public const long m_fAmplitude = 0x8C4;
                public const long m_fHaloScale = 0x8C0;
                public const long m_flFireTime = 0x858;
                public const long m_hEndEntity = 0x8E4;
                public const long m_nBeamFlags = 0x87C;
                public const long m_nHaloIndex = 0x870;
                public const long m_fFadeLength = 0x8BC;
                public const long m_fStartFrame = 0x8C8;
                public const long m_flFrameRate = 0x850;
                public const long m_nAttachIndex = 0x8A8;
                public const long m_nNumBeamEnts = 0x860;
                public const long m_hAttachEntity = 0x880;
                public const long m_hBaseMaterial = 0x868;
                public const long m_nDissolveType = 0x8E8;
                public const long m_flHDRColorScale = 0x854;
            }
            public static partial class CFish {
                public const long m_x = 0xA48;
                public const long m_y = 0xA4C;
                public const long m_z = 0xA50;
                public const long m_id = 0xA44;
                public const long m_perp = 0xA68;
                public const long m_pool = 0xA40;
                public const long m_angle = 0xA54;
                public const long m_speed = 0xA84;
                public const long m_forward = 0xA5C;
                public const long m_goTimer = 0xAB8;
                public const long m_visible = 0xB30;
                public const long m_calmSpeed = 0xA8C;
                public const long m_moveTimer = 0xAD0;
                public const long m_turnTimer = 0xA98;
                public const long m_avoidRange = 0xA94;
                public const long m_panicSpeed = 0xA90;
                public const long m_panicTimer = 0xAE8;
                public const long m_poolOrigin = 0xA74;
                public const long m_waterLevel = 0xA80;
                public const long m_angleChange = 0xA58;
                public const long m_desiredSpeed = 0xA88;
                public const long m_disperseTimer = 0xB00;
                public const long m_turnClockwise = 0xAB0;
                public const long m_proximityTimer = 0xB18;
            }
            public static partial class CItem {
                public const long m_OnGlovePulled = 0xA98;
                public const long m_OnPlayerTouch = 0xA48;
                public const long m_OnPlayerPickup = 0xA60;
                public const long m_bPhysStartAsleep = 0xAC8;
                public const long m_OnCacheInteraction = 0xA80;
                public const long m_bActivateWhenAtRest = 0xA78;
                public const long m_vOriginalSpawnAngles = 0xABC;
                public const long m_vOriginalSpawnOrigin = 0xAB0;
            }
            public static partial class CTeam {
                public const long m_iScore = 0x4D8;
                public const long m_aPlayers = 0x4C0;
                public const long m_szTeamname = 0x4DC;
                public const long m_aPlayerControllers = 0x4A8;
            }
            public static partial class CBlood {
                public const long m_Color = 0x4C4;
                public const long m_flAmount = 0x4C0;
                public const long m_vecSprayDir = 0x4B4;
                public const long m_vecSprayAngles = 0x4A8;
            }
            public static partial class CCSBot {
                public const long m_name = 0x114;
                public const long m_avoid = 0x5F4;
                public const long m_enemy = 0x5A00;
                public const long m_avgVel = 0x5DCC;
                public const long m_bomber = 0x5C38;
                public const long m_leader = 0x1AC;
                public const long m_aimGoal = 0x59C4;
                public const long m_isRogue = 0x158;
                public const long m_isStuck = 0x5D83;
                public const long m_lookYaw = 0x598C;
                public const long m_wasSafe = 0x184;
                public const long m_aimError = 0x59B8;
                public const long m_aimFocus = 0x59D4;
                public const long m_attacker = 0x5C58;
                public const long m_safeTime = 0x180;
                public const long m_blindFire = 0x18C;
                public const long m_hasJoined = 0x52BC;
                public const long m_lookPitch = 0x5984;
                public const long m_pathIndex = 0x4F00;
                public const long m_stuckSpot = 0x5D88;
                public const long m_waitTimer = 0x4FE8;
                public const long m_zoomTimer = 0x5C88;
                public const long m_alertTimer = 0x1D0;
                public const long m_equipTimer = 0x5C78;
                public const long m_goalEntity = 0x5F0;
                public const long m_hurryTimer = 0x1B8;
                public const long m_isStopping = 0x5FC;
                public const long m_lastOrigin = 0x5DFC;
                public const long m_lookAtDesc = 0x5380;
                public const long m_lookAtSpot = 0x5360;
                public const long m_lookYawVel = 0x5990;
                public const long m_panicTimer = 0x200;
                public const long m_rogueTimer = 0x160;
                public const long m_sneakTimer = 0x1E8;
                public const long m_stillTimer = 0x600;
                public const long m_targetSpot = 0x5994;
                public const long m_taskEntity = 0x5D4;
                public const long m_avgVelCount = 0x5DF8;
                public const long m_avgVelIndex = 0x5DF4;
                public const long m_bIsSleeping = 0x5CC0;
                public const long m_combatRange = 0x154;
                public const long m_desiredTeam = 0x52B8;
                public const long m_eyePosition = 0x108;
                public const long m_isAttacking = 0x5CC;
                public const long m_isFollowing = 0x1A9;
                public const long m_lookUpAngle = 0x5350;
                public const long m_noiseSource = 0x5308;
                public const long m_politeTimer = 0x4F40;
                public const long m_repathTimer = 0x4F08;
                public const long m_wiggleTimer = 0x5D98;
                public const long m_bAllowActive = 0x1A8;
                public const long m_forwardAngle = 0x5354;
                public const long m_goalPosition = 0x5E4;
                public const long m_lastVictimID = 0x5C70;
                public const long m_lookPitchVel = 0x5988;
                public const long m_mustRunTimer = 0x4FD0;
                public const long m_radioSubject = 0x5E14;
                public const long m_diedLastRound = 0x17C;
                public const long m_isOpeningDoor = 0x5CD;
                public const long m_isRapidFiring = 0x5C75;
                public const long m_noisePosition = 0x52F0;
                public const long m_pathLadderEnd = 0x4F84;
                public const long m_radioPosition = 0x5E18;
                public const long m_surpriseTimer = 0x190;
                public const long m_avoidTimestamp = 0x5F8;
                public const long m_isEnemyVisible = 0x5A04;
                public const long m_lookAheadAngle = 0x534C;
                public const long m_noiseBendTimer = 0x5320;
                public const long m_noiseTimestamp = 0x5300;
                public const long m_stateTimestamp = 0x5C8;
                public const long m_stuckJumpTimer = 0x5DB0;
                public const long m_stuckTimestamp = 0x5D84;
                public const long m_targetSpotTime = 0x59D0;
                public const long m_enemyQueueCount = 0x5D81;
                public const long m_enemyQueueIndex = 0x5D80;
                public const long m_followTimestamp = 0x1B0;
                public const long m_isAimingAtEnemy = 0x5C74;
                public const long m_isLastEnemyDead = 0x5A28;
                public const long m_viewSteadyTimer = 0x5520;
                public const long m_aimFocusInterval = 0x59D8;
                public const long m_avoidFriendTimer = 0x4F20;
                public const long m_isFriendInTheWay = 0x4F38;
                public const long m_lookAtSpotAttack = 0x537D;
                public const long m_nearbyEnemyCount = 0x5A2C;
                public const long m_tossGrenadeTimer = 0x5538;
                public const long m_attackedTimestamp = 0x5C5C;
                public const long m_attentionInterval = 0x5C48;
                public const long m_bentNoisePosition = 0x5338;
                public const long m_isAvoidingGrenade = 0x5558;
                public const long m_lastEnemyPosition = 0x5A08;
                public const long m_nearbyFriendCount = 0x5C3C;
                public const long m_visibleEnemyParts = 0x5A05;
                public const long m_voiceEndTimestamp = 0x5E24;
                public const long m_aimFocusNextUpdate = 0x59DC;
                public const long m_approachPointCount = 0x5510;
                public const long m_hostageEscortCount = 0x52B0;
                public const long m_ignoreEnemiesTimer = 0x59E8;
                public const long m_lookAtSpotDuration = 0x5370;
                public const long m_spotCheckTimestamp = 0x5578;
                public const long m_targetSpotVelocity = 0x59A0;
                public const long m_allowAutoFollowTime = 0x1B4;
                public const long m_burnedByFlamesTimer = 0x5C60;
                public const long m_enemyDeathTimestamp = 0x5A20;
                public const long m_fireWeaponTimestamp = 0x5CA0;
                public const long m_isWaitingForHostage = 0x52BD;
                public const long m_lookAtSpotTimestamp = 0x5374;
                public const long m_noiseTravelDistance = 0x52FC;
                public const long m_peripheralTimestamp = 0x5388;
                public const long m_sawEnemySniperTimer = 0x5CC8;
                public const long m_targetSpotPredicted = 0x59AC;
                public const long m_travelDistancePhase = 0x5118;
                public const long m_waitForHostageTimer = 0x52D8;
                public const long m_areaEnteredTimestamp = 0x4F04;
                public const long m_closestVisibleFriend = 0x5C40;
                public const long m_friendDeathTimestamp = 0x5A24;
                public const long m_hasVisitedEnemySpawn = 0x5FD;
                public const long m_isEnemySniperVisible = 0x5CC1;
                public const long m_playerTravelDistance = 0x5018;
                public const long m_enemyQueueAttendIndex = 0x5D82;
                public const long m_isWaitingBehindFriend = 0x4F58;
                public const long m_lastSawEnemyTimestamp = 0x5A14;
                public const long m_bendNoisePositionValid = 0x5344;
                public const long m_checkedHidingSpotCount = 0x5980;
                public const long m_firstSawEnemyTimestamp = 0x5A18;
                public const long m_lastRadioSentTimestamp = 0x5E10;
                public const long m_lookAtSpotClearIfClose = 0x537C;
                public const long m_lookAroundStateTimestamp = 0x5348;
                public const long m_lookAtSpotAngleTolerance = 0x5378;
                public const long m_approachPointViewPosition = 0x5514;
                public const long m_closestVisibleHumanFriend = 0x5C44;
                public const long m_nextCleanupCheckTimestamp = 0x5DC8;
                public const long m_updateTravelDistanceTimer = 0x5000;
                public const long m_inhibitLookAroundTimestamp = 0x5358;
                public const long m_lastRadioRecievedTimestamp = 0x5E0C;
                public const long m_hostageEscortCountTimestamp = 0x52B4;
                public const long m_lastValidReactionQueueFrame = 0x5E30;
                public const long m_lookForWeaponsOnGroundTimer = 0x5CA8;
                public const long m_currentEnemyAcquireTimestamp = 0x5A1C;
                public const long m_inhibitWaitingForHostageTimer = 0x52C0;
                public const long m_bEyeAnglesUnderPathFinderControl = 0x610;
            }
            public static partial class CKnife {
                public const long m_bFirstAttack = 0x1280;
            }
            public static partial class CWorld {

            }
            public static partial class Extent {
                public const long hi = 0xC;
                public const long lo = 0x0;
            }
            public static partial class CBtNode {

            }
            public static partial class CCSTeam {
                public const long m_iClanID = 0x800;
                public const long m_bSurrendered = 0x568;
                public const long m_scoreOvertime = 0x778;
                public const long m_scoreFirstHalf = 0x770;
                public const long m_szClanTeamname = 0x77C;
                public const long m_numMapVictories = 0x76C;
                public const long m_scoreSecondHalf = 0x774;
                public const long m_szTeamFlagImage = 0x804;
                public const long m_szTeamLogoImage = 0x80C;
                public const long m_szTeamMatchStat = 0x569;
                public const long m_iLastUpdateSentAt = 0x818;
                public const long m_flNextResourceTime = 0x814;
                public const long m_nShorthandedRoundBonusStartRound = 0x564;
                public const long m_nLastRecievedShorthandedRoundBonus = 0x560;
            }
            public static partial class CDEagle {

            }
            public static partial class CEnvSky {
                public const long m_bEnabled = 0x884;
                public const long m_nFogType = 0x870;
                public const long m_vTintColor = 0x864;
                public const long m_flFogMaxEnd = 0x880;
                public const long m_flFogMinEnd = 0x878;
                public const long m_hSkyMaterial = 0x850;
                public const long m_flFogMaxStart = 0x87C;
                public const long m_flFogMinStart = 0x874;
                public const long m_bStartDisabled = 0x860;
                public const long m_flBrightnessScale = 0x86C;
                public const long m_vTintColorLightingOnly = 0x868;
                public const long m_hSkyMaterialLightingOnly = 0x858;
            }
            public static partial class CShower {
                public const long m_flSpeed = 0x850;
            }
            public static partial class CSprite {
                public const long m_flFrame = 0x864;
                public const long m_flSpeed = 0x8BC;
                public const long m_flDieTime = 0x868;
                public const long m_flLastTime = 0x894;
                public const long m_flMaxFrame = 0x898;
                public const long m_flDestScale = 0x8A0;
                public const long m_nAttachment = 0x85C;
                public const long m_nBrightness = 0x878;
                public const long m_flStartScale = 0x89C;
                public const long m_nSpriteWidth = 0x8B4;
                public const long m_flSpriteScale = 0x880;
                public const long m_nSpriteHeight = 0x8B8;
                public const long m_flGlowProxySize = 0x88C;
                public const long m_flHDRColorScale = 0x890;
                public const long m_flScaleDuration = 0x884;
                public const long m_hSpriteMaterial = 0x850;
                public const long m_nDestBrightness = 0x8AC;
                public const long m_bWorldSpaceScale = 0x888;
                public const long m_flScaleTimeStart = 0x8A4;
                public const long m_nStartBrightness = 0x8A8;
                public const long m_flSpriteFramerate = 0x860;
                public const long m_hAttachedToEntity = 0x858;
                public const long m_flBrightnessDuration = 0x87C;
                public const long m_flBrightnessTimeStart = 0x8B0;
            }
            public static partial class CBuyZone {
                public const long m_LegacyTeamNum = 0x9C8;
            }
            public static partial class CCSPlace {
                public const long m_name = 0x868;
            }
            public static partial class CChicken {
                public const long m_owner = 0x11AC;
                public const long m_leader = 0x11A8;
                public const long m_fleeFrom = 0x115C;
                public const long m_turnRate = 0x1158;
                public const long m_jumpTimer = 0x11D8;
                public const long m_isOnGround = 0x1128;
                public const long m_reuseTimer = 0x11C0;
                public const long m_repathTimer = 0x3200;
                public const long m_stuckAnchor = 0x1100;
                public const long m_updateTimer = 0x10E8;
                public const long m_vecPathGoal = 0x3298;
                public const long m_startleTimer = 0x1178;
                public const long m_activityTimer = 0x1140;
                public const long m_vFallVelocity = 0x112C;
                public const long m_vocalizeTimer = 0x1190;
                public const long m_flLastJumpTime = 0x11F0;
                public const long m_currentActivity = 0x113C;
                public const long m_desiredActivity = 0x1138;
                public const long m_AttributeManager = 0xCB0;
                public const long m_followMinuteTimer = 0x32A8;
                public const long m_BlockDirectionTimer = 0x32C8;
                public const long m_collisionStuckTimer = 0x1110;
                public const long m_bSpawnDyingParticles = 0x32E2;
                public const long m_moveRateThrottleTimer = 0x1160;
                public const long m_flActiveFollowStartTime = 0x32A4;
            }
            public static partial class CCredits {
                public const long m_flLogoLength = 0x4C4;
                public const long m_OnCreditsDone = 0x4A8;
                public const long m_bRolledOutroCredits = 0x4C0;
            }
            public static partial class CEnvBeam {
                public const long m_life = 0x910;
                public const long m_speed = 0x91C;
                public const long m_active = 0x8F0;
                public const long m_radius = 0x94C;
                public const long m_hFilter = 0x960;
                public const long m_iszDecal = 0x968;
                public const long m_restrike = 0x920;
                public const long m_TouchType = 0x950;
                public const long m_boltWidth = 0x914;
                public const long m_frameStart = 0x930;
                public const long m_iFilterName = 0x958;
                public const long m_iszEndEntity = 0x908;
                public const long m_iszSpriteName = 0x928;
                public const long m_spriteTexture = 0x8F8;
                public const long m_iszStartEntity = 0x900;
                public const long m_noiseAmplitude = 0x918;
                public const long m_vEndPointWorld = 0x934;
                public const long m_OnTouchedByEntity = 0x970;
                public const long m_vEndPointRelative = 0x940;
            }
            public static partial class CEnvFade {
                public const long m_Duration = 0x4AC;
                public const long m_fadeColor = 0x4A8;
                public const long m_OnBeginFade = 0x4B8;
                public const long m_HoldDuration = 0x4B0;
            }
            public static partial class CEnvTilt {
                public const long m_Radius = 0x4AC;
                public const long m_Duration = 0x4A8;
                public const long m_TiltTime = 0x4B0;
                public const long m_stopTime = 0x4B4;
            }
            public static partial class CEnvWind {
                public const long m_EnvWindShared = 0x4A8;
            }
            public static partial class CGameEnd {

            }
            public static partial class CHostage {
                public const long m_vel = 0xBC0;
                public const long m_accel = 0xBFC;
                public const long m_leader = 0xBD4;
                public const long m_bRemove = 0xBBC;
                public const long m_OnRescued = 0xB80;
                public const long m_isRescued = 0xBCC;
                public const long m_isRunning = 0xC08;
                public const long m_jumpTimer = 0xC10;
                public const long m_isAdjusted = 0x2D1C;
                public const long m_lastLeader = 0xBD8;
                public const long m_nSpotRules = 0xBB0;
                public const long m_reuseTimer = 0xBE0;
                public const long m_hasBeenUsed = 0xBF8;
                public const long m_isCrouching = 0xC09;
                public const long m_repathTimer = 0x2C38;
                public const long m_wiggleTimer = 0x2D00;
                public const long m_fLastGrabTime = 0x2D24;
                public const long m_nHostageState = 0xBD0;
                public const long m_vecGrabbedPos = 0x2D34;
                public const long m_OnFirstPickedUp = 0xB50;
                public const long m_flDropStartTime = 0x2D48;
                public const long m_hHostageGrabber = 0x2D20;
                public const long m_jumpedThisFrame = 0xBCD;
                public const long m_inhibitDoorTimer = 0x2C50;
                public const long m_bHandsHaveBeenCut = 0x2D1D;
                public const long m_flGrabSuccessTime = 0x2D44;
                public const long m_flRescueStartTime = 0x2D40;
                public const long m_nPickupEventCount = 0x2D50;
                public const long m_vecSpawnGroundPos = 0x2D54;
                public const long m_OnHostageBeginGrab = 0xB38;
                public const long m_entitySpottedState = 0xB98;
                public const long m_isWaitingForLeader = 0xC28;
                public const long m_OnDroppedNotRescued = 0xB68;
                public const long m_nApproachRewardPayouts = 0x2D4C;
                public const long m_vecHostageResetPosition = 0x2D8C;
                public const long m_nHostageSpawnRandomFactor = 0xBB8;
                public const long m_inhibitObstacleAvoidanceTimer = 0x2CE0;
                public const long m_uiHostageSpawnExclusionGroupMask = 0xBB4;
                public const long m_vecPositionWhenStartedDroppingToGround = 0x2D28;
            }
            public static partial class CInferno {
                public const long m_extent = 0x13A8;
                public const long m_startPos = 0x1408;
                public const long m_fireCount = 0x1190;
                public const long m_BurnNormal = 0xE90;
                public const long m_nMaxFlames = 0x1434;
                public const long m_activeTimer = 0x1420;
                public const long m_damageTimer = 0x13C0;
                public const long m_nInfernoType = 0x1194;
                public const long m_nSpreadCount = 0x1438;
                public const long m_firePositions = 0x850;
                public const long m_nFireLifetime = 0x119C;
                public const long m_bFireIsBurning = 0xE50;
                public const long m_splashVelocity = 0x13F0;
                public const long m_NextSpreadTimer = 0x1458;
                public const long m_damageRampTimer = 0x13D8;
                public const long m_fireSpawnOffset = 0x1430;
                public const long m_BookkeepingTimer = 0x1440;
                public const long m_bInPostEffectTime = 0x11A0;
                public const long m_bWasCreatedInSmoke = 0x11A1;
                public const long m_fireParentPositions = 0xB50;
                public const long m_nSourceItemDefIndex = 0x1470;
                public const long m_nFireEffectTickBegin = 0x1198;
                public const long m_InitialSplashVelocity = 0x13FC;
                public const long m_vecOriginalSpawnLocation = 0x1414;
            }
            public static partial class CInfoFan {
                public const long m_flCurveDistRange = 0x4F0;
                public const long m_fFanForceMaxRadius = 0x4E8;
                public const long m_fFanForceMinRadius = 0x4EC;
                public const long m_FanForceCurveString = 0x4F8;
            }
            public static partial class CMapInfo {
                public const long m_flBombRadius = 0x4AC;
                public const long m_iBuyingStatus = 0x4A8;
                public const long m_iHostageCount = 0x4BC;
                public const long m_bGPUCullSkybox = 0x4C2;
                public const long m_iPetPopulation = 0x4B0;
                public const long m_flEnvRainStrength = 0x4C4;
                public const long m_flEnvWetnessCoverage = 0x4D0;
                public const long m_bUseNormalSpawnsForDM = 0x4B4;
                public const long m_bRainTraceToSkyEnabled = 0x4C1;
                public const long m_flBotMaxVisionDistance = 0x4B8;
                public const long m_flEnvWetnessDryingAmount = 0x4D4;
                public const long m_bFadePlayerVisibilityFarZ = 0x4C0;
                public const long m_flEnvPuddleRippleStrength = 0x4C8;
                public const long m_flEnvPuddleRippleDirection = 0x4CC;
                public const long m_bDisableAutoGeneratedDMSpawns = 0x4B5;
            }
            public static partial class CMessage {
                public const long m_Radius = 0x4B8;
                public const long m_sNoise = 0x4C0;
                public const long m_iszMessage = 0x4A8;
                public const long m_MessageVolume = 0x4B0;
                public const long m_OnShowMessage = 0x4C8;
                public const long m_MessageAttenuation = 0x4B4;
            }
            public static partial class CPhysBox {
                public const long m_OnDamaged = 0x978;
                public const long m_OnAwakened = 0x990;
                public const long m_damageType = 0x928;
                public const long m_OnPlayerUse = 0x9C0;
                public const long m_OnStartTouch = 0x9D8;
                public const long m_iszInteractsAs = 0x960;
                public const long m_OnMotionEnabled = 0x9A8;
                public const long m_nHoverPoseFlags = 0x94E;
                public const long m_bEnableUseOutput = 0x94D;
                public const long m_bNotSolidToWorld = 0x94C;
                public const long m_iszInteractsWith = 0x968;
                public const long m_iszCollisionGroup = 0x958;
                public const long m_angHoverPoseAngles = 0x940;
                public const long m_vHoverPosePosition = 0x934;
                public const long m_iszInteractsExclude = 0x970;
                public const long m_damageToEnableMotion = 0x92C;
                public const long m_flForceToEnableMotion = 0x930;
                public const long m_flTouchOutputPerEntityDelay = 0x950;
            }
            public static partial class CRotDoor {
                public const long m_bSolidBsp = 0xA58;
            }
            public static partial class IRagdoll {

            }
            public static partial class PathCost {
                public const long m_dangerFactor = 0x3C;
                public const long m_flAgentMaxClimb = 0x44;
                public const long m_damagingAreasPenaltyCost = 0x40;
            }
            public static partial class CBaseDoor {
                public const long m_ls = 0x8F8;
                public const long m_OnOpen = 0x9F8;
                public const long m_OnClose = 0x9E0;
                public const long m_bLocked = 0x91A;
                public const long m_bNoNPCs = 0x91C;
                public const long m_flSpeed = 0xA4C;
                public const long m_bIsUsable = 0xA51;
                public const long m_bDoorGroup = 0x919;
                public const long m_isChaining = 0xA50;
                public const long m_ChainTarget = 0x948;
                public const long m_NoiseMoving = 0x928;
                public const long m_OnFullyOpen = 0x9C8;
                public const long m_OnLockedUse = 0xA10;
                public const long m_NoiseArrived = 0x930;
                public const long m_bForceClosed = 0x918;
                public const long m_OnFullyClosed = 0x9B0;
                public const long m_bIgnoreDebris = 0x91B;
                public const long m_flBlockDamage = 0x924;
                public const long m_bLoopMoveSound = 0xA28;
                public const long m_eSpawnPosition = 0x920;
                public const long m_OnBlockedClosing = 0x950;
                public const long m_OnBlockedOpening = 0x968;
                public const long m_NoiseMovingClosed = 0x938;
                public const long m_NoiseArrivedClosed = 0x940;
                public const long m_OnUnblockedClosing = 0x980;
                public const long m_OnUnblockedOpening = 0x998;
                public const long m_angMoveEntitySpace = 0x8E0;
                public const long m_bCreateNavObstacle = 0xA48;
                public const long m_vecMoveDirParentSpace = 0x8EC;
            }
            public static partial class CBaseProp {
                public const long m_iShapeType = 0xA44;
                public const long m_bModelOverrodeBlockLOS = 0xA40;
                public const long m_mPreferredCatchTransform = 0xA50;
                public const long m_bConformToCollisionBounds = 0xA48;
            }
            public static partial class CCSSprite {

            }
            public static partial class CEnvDecal {
                public const long m_flDepth = 0x860;
                public const long m_flWidth = 0x858;
                public const long m_flHeight = 0x85C;
                public const long m_nRenderOrder = 0x864;
                public const long m_hDecalMaterial = 0x850;
                public const long m_bProjectOnWater = 0x86A;
                public const long m_bProjectOnWorld = 0x868;
                public const long m_flDepthSortBias = 0x86C;
                public const long m_bProjectOnCharacters = 0x869;
            }
            public static partial class CEnvLaser {
                public const long m_pSprite = 0x8F8;
                public const long m_firePosition = 0x908;
                public const long m_flStartFrame = 0x914;
                public const long m_iszSpriteName = 0x900;
                public const long m_iszLaserTarget = 0x8F0;
            }
            public static partial class CEnvShake {
                public const long m_Radius = 0x4BC;
                public const long m_Duration = 0x4B8;
                public const long m_maxForce = 0x4CC;
                public const long m_stopTime = 0x4C0;
                public const long m_Amplitude = 0x4B0;
                public const long m_Frequency = 0x4B4;
                public const long m_nextShake = 0x4C4;
                public const long m_currentAmp = 0x4C8;
                public const long m_limitToEntity = 0x4A8;
                public const long m_shakeCallback = 0x4E0;
                public const long m_pShakeController = 0x4D8;
            }
            public static partial class CEnvSpark {
                public const long m_nType = 0x4B4;
                public const long m_OnSpark = 0x4B8;
                public const long m_flDelay = 0x4A8;
                public const long m_nMagnitude = 0x4AC;
                public const long m_nTrailLength = 0x4B0;
            }
            public static partial class CFishPool {
                public const long m_fishes = 0x4D0;
                public const long m_maxRange = 0x4BC;
                public const long m_visTimer = 0x4E8;
                public const long m_fishCount = 0x4B8;
                public const long m_isDormant = 0x4C8;
                public const long m_swimDepth = 0x4C0;
                public const long m_waterLevel = 0x4C4;
            }
            public static partial class CFuncPlat {
                public const long m_sNoise = 0x900;
                public const long m_flSpeed = 0x8F8;
            }
            public static partial class CFuncWall {
                public const long m_nState = 0x850;
            }
            public static partial class CGameText {
                public const long m_textParms = 0x868;
                public const long m_iszMessage = 0x860;
            }
            public static partial class CInfoData {

            }
            public static partial class CItemSoda {

            }
            public static partial class CNavFlags {
                public const long m_Flags = 0x0;
            }
            public static partial class CPathNode {
                public const long m_hPath = 0x4F0;
                public const long m_xWSPrevParent = 0x4D0;
                public const long m_vInTangentLocal = 0x4A8;
                public const long m_vOutTangentLocal = 0x4B4;
                public const long m_strPathNodeParameter = 0x4C8;
                public const long m_strParentPathUniqueID = 0x4C0;
            }
            public static partial class CPushable {

            }
            public static partial class CRangeInt {
                public const long m_pValue = 0x0;
            }
            public static partial class CSimTimer {
                public const long m_flInterval = 0x8;
            }
            public static partial class CSkillInt {
                public const long m_pValue = 0x0;
            }
            public static partial class CTimeline {
                public const long m_bStopped = 0x220;
                public const long m_flValues = 0x10;
                public const long m_flInterval = 0x214;
                public const long m_flFinalValue = 0x218;
                public const long m_nBucketCount = 0x210;
                public const long m_nValueCounts = 0x110;
                public const long m_nCompressionType = 0x21C;
            }
            public static partial class NavHull_t {
                public const long m_nHullIdx = 0x0;
            }
            public static partial class ragdoll_t {
                public const long list = 0x0;
                public const long unused = 0x49;
                public const long boneIndex = 0x30;
                public const long allowStretch = 0x48;
                public const long hierarchyJoints = 0x18;
            }
            public static partial class CBarnLight {
                public const long m_nFog = 0x9D8;
                public const long m_Color = 0x858;
                public const long m_vShear = 0x98C;
                public const long m_flRange = 0x988;
                public const long m_flShape = 0x968;
                public const long m_flSkirt = 0x974;
                public const long m_flSoftX = 0x96C;
                public const long m_flSoftY = 0x970;
                public const long m_bEnabled = 0x850;
                public const long m_StyleEvent = 0x8E0;
                public const long m_flFogScale = 0x9E4;
                public const long m_nColorMode = 0x854;
                public const long m_VisClusters = 0xB18;
                public const long m_flSkirtNear = 0x978;
                public const long m_nFogShadows = 0x9E0;
                public const long m_vSizeParams = 0x97C;
                public const long m_flBrightness = 0x860;
                public const long m_hLightCookie = 0x960;
                public const long m_nBounceLight = 0x9BC;
                public const long m_nCastShadows = 0x9AC;
                public const long m_nDirectLight = 0x868;
                public const long m_flBounceScale = 0x9C0;
                public const long m_flFadeSizeEnd = 0x9EC;
                public const long m_flFogStrength = 0x9DC;
                public const long m_bContactShadow = 0x9B8;
                public const long m_flMinRoughness = 0x9C4;
                public const long m_nShadowMapSize = 0x9B0;
                public const long m_bTransmitAlways = 0xB15;
                public const long m_flFadeSizeStart = 0x9E8;
                public const long m_flLuminaireSize = 0x87C;
                public const long m_nLuminaireShape = 0x878;
                public const long m_nShadowPriority = 0x9B4;
                public const long m_vAlternateColor = 0x9C8;
                public const long m_LightStyleEvents = 0x8B0;
                public const long m_LightStyleString = 0x888;
                public const long m_bPvsModifyEntity = 0xB14;
                public const long m_LightStyleTargets = 0x8C8;
                public const long m_flBrightnessScale = 0x864;
                public const long m_nBakedShadowIndex = 0x86C;
                public const long m_nLightMapUniqueId = 0x874;
                public const long m_flColorTemperature = 0x85C;
                public const long m_nLightPathUniqueId = 0x870;
                public const long m_flShadowFadeSizeEnd = 0x9F4;
                public const long m_bForceShadowsEnabled = 0x9B9;
                public const long m_flLightStyleStartTime = 0x890;
                public const long m_flLuminaireAnisotropy = 0x880;
                public const long m_flShadowFadeSizeStart = 0x9F0;
                public const long m_nPrecomputedSubFrusta = 0xA38;
                public const long m_vPrecomputedOBBAngles = 0xA20;
                public const long m_vPrecomputedOBBExtent = 0xA2C;
                public const long m_vPrecomputedOBBOrigin = 0xA14;
                public const long m_vPrecomputedBoundsMaxs = 0xA08;
                public const long m_vPrecomputedBoundsMins = 0x9FC;
                public const long m_vPrecomputedOBBAngles0 = 0xA48;
                public const long m_vPrecomputedOBBAngles1 = 0xA6C;
                public const long m_vPrecomputedOBBAngles2 = 0xA90;
                public const long m_vPrecomputedOBBAngles3 = 0xAB4;
                public const long m_vPrecomputedOBBAngles4 = 0xAD8;
                public const long m_vPrecomputedOBBAngles5 = 0xAFC;
                public const long m_vPrecomputedOBBExtent0 = 0xA54;
                public const long m_vPrecomputedOBBExtent1 = 0xA78;
                public const long m_vPrecomputedOBBExtent2 = 0xA9C;
                public const long m_vPrecomputedOBBExtent3 = 0xAC0;
                public const long m_vPrecomputedOBBExtent4 = 0xAE4;
                public const long m_vPrecomputedOBBExtent5 = 0xB08;
                public const long m_vPrecomputedOBBOrigin0 = 0xA3C;
                public const long m_vPrecomputedOBBOrigin1 = 0xA60;
                public const long m_vPrecomputedOBBOrigin2 = 0xA84;
                public const long m_vPrecomputedOBBOrigin3 = 0xAA8;
                public const long m_vPrecomputedOBBOrigin4 = 0xACC;
                public const long m_vPrecomputedOBBOrigin5 = 0xAF0;
                public const long m_QueuedLightStyleStrings = 0x898;
                public const long m_bPrecomputedFieldsValid = 0x9F8;
                public const long m_nBakeSpecularToCubemaps = 0x998;
                public const long m_fAlternateColorBrightness = 0x9D4;
                public const long m_vBakeSpecularToCubemapsSize = 0x99C;
                public const long m_flBakeSpecularToCubemapsScale = 0x9A8;
            }
            public static partial class CBaseIssue {
                public const long m_iNumNoVotes = 0x168;
                public const long m_iNumYesVotes = 0x164;
                public const long m_szTypeString = 0x20;
                public const long m_pVoteController = 0x170;
                public const long m_szDetailsString = 0x60;
                public const long m_iNumPotentialVotes = 0x16C;
            }
            public static partial class CBreakable {
                public const long m_OnBreak = 0x8E0;
                public const long m_Material = 0x898;
                public const long m_hBreaker = 0x89C;
                public const long m_Explosion = 0x8A0;
                public const long m_iszPropData = 0x8B8;
                public const long m_OnStartDeath = 0x8C8;
                public const long m_iMinHealthDmg = 0x8B4;
                public const long m_iszSpawnObject = 0x8A8;
                public const long m_OnHealthChanged = 0x8F8;
                public const long m_PerformanceMode = 0x918;
                public const long m_flPressureDelay = 0x8B0;
                public const long m_hPhysicsAttacker = 0x91C;
                public const long m_impactEnergyScale = 0x8C0;
                public const long m_nOverrideBlockLOS = 0x8C4;
                public const long m_CPropDataComponent = 0x858;
                public const long m_flLastPhysicsInfluenceTime = 0x920;
            }
            public static partial class CCashStack {
                public const long m_nCashStackValue = 0x850;
            }
            public static partial class CEnvGlobal {
                public const long m_counter = 0x4D8;
                public const long m_outCounter = 0x4A8;
                public const long m_globalstate = 0x4C8;
                public const long m_triggermode = 0x4D0;
                public const long m_initialstate = 0x4D4;
            }
            public static partial class CEnvSplash {
                public const long m_flScale = 0x4A8;
            }
            public static partial class CFilterLOS {

            }
            public static partial class CFlashbang {

            }
            public static partial class CFogVolume {
                public const long m_fogName = 0x850;
                public const long m_bDisabled = 0x870;
                public const long m_postProcessName = 0x858;
                public const long m_bInFogVolumesList = 0x871;
                public const long m_colorCorrectionName = 0x860;
            }
            public static partial class CFuncBrush {
                public const long m_bSolidBsp = 0x858;
                public const long m_iDisabled = 0x854;
                public const long m_iSolidity = 0x850;
                public const long m_bInvertExclusion = 0x868;
                public const long m_iszExcludedClass = 0x860;
                public const long m_bScriptedMovement = 0x869;
            }
            public static partial class CFuncMover {
                public const long m_flT = 0x884;
                public const long m_OnStop = 0xA68;
                public const long m_OnStart = 0xA20;
                public const long m_flSpeed = 0x9F8;
                public const long m_OnStopped = 0xA80;
                public const long m_bIsMoving = 0x891;
                public const long m_bIsPaused = 0x9D0;
                public const long m_eMoveType = 0x874;
                public const long m_bQueueStop = 0xB21;
                public const long m_eSolidType = 0x890;
                public const long m_hPathMover = 0x858;
                public const long m_bStartAtEnd = 0x939;
                public const long m_hStopAtNode = 0x8BC;
                public const long m_iszPathName = 0x850;
                public const long m_OnNodePassed = 0x958;
                public const long m_bIsReversing = 0x878;
                public const long m_flBeginStopT = 0x8C8;
                public const long m_flStartSpeed = 0x87C;
                public const long m_hFollowMover = 0xABC;
                public const long m_OnMovementEnd = 0x920;
                public const long m_hFollowEntity = 0x9FC;
                public const long m_OnStartForward = 0xA38;
                public const long m_OnStartReverse = 0xA50;
                public const long m_bIgnoreEndNode = 0x870;
                public const long m_bStartedMoving = 0xA99;
                public const long m_flPathLocation = 0x880;
                public const long m_hPrevPathMover = 0x85C;
                public const long m_iszPathNodeEnd = 0x868;
                public const long m_bIsImGuiLogging = 0x9F4;
                public const long m_movementSummary = 0xB00;
                public const long m_vOffsetFromPath = 0xB30;
                public const long m_bQueueStopMoving = 0xB22;
                public const long m_flCurFollowSpeed = 0xA0C;
                public const long m_flFollowDistance = 0xA00;
                public const long m_flStopCurveScale = 0x8AC;
                public const long m_iszPathNodeStart = 0x860;
                public const long m_nTickMovementRan = 0xAFC;
                public const long m_eFollowConstraint = 0xAF0;
                public const long m_flLerpToPositionT = 0x994;
                public const long m_flStartCurveScale = 0x8A8;
                public const long m_nCurrentNodeIndex = 0x888;
                public const long m_eOrientationUpdate = 0x944;
                public const long m_flCurFollowEntityT = 0xA08;
                public const long m_flFollowMoverRatio = 0xAD4;
                public const long m_flFollowMoverSpeed = 0xAF4;
                public const long m_flTimeMovementStop = 0x8B8;
                public const long m_nPreviousNodeIndex = 0x88C;
                public const long m_flPathLocationStart = 0x8C4;
                public const long m_flTimeMovementStart = 0x8B4;
                public const long m_flTransitionSourceT = 0x9A0;
                public const long m_iszFollowEntityName = 0xAC0;
                public const long m_iszLoopForwardSound = 0x8D8;
                public const long m_iszLoopReverseSound = 0x8F0;
                public const long m_iszStopForwardSound = 0x8E0;
                public const long m_iszStopReverseSound = 0x8F8;
                public const long m_bQueueSetupPathMover = 0xB23;
                public const long m_bStartAtClosestPoint = 0x938;
                public const long m_ePathRebuildStrategy = 0xB24;
                public const long m_flFollowMinimumSpeed = 0xA04;
                public const long m_iszStartForwardSound = 0x8D0;
                public const long m_iszStartReverseSound = 0x8E8;
                public const long m_vLerpToNewPosStartWS = 0x984;
                public const long m_bCreateMovableNavMesh = 0x954;
                public const long m_flFollowMoverDistance = 0xAD0;
                public const long m_flFollowMoverVelocity = 0xAF8;
                public const long m_flTimeToReachMaxSpeed = 0x894;
                public const long m_hTransitionSourcePath = 0x99C;
                public const long m_bIsImGuiEntTextLogging = 0x9F5;
                public const long m_eFollowEntityDirection = 0xAB8;
                public const long m_flLerpToPositionDeltaT = 0x998;
                public const long m_flTimeToReachZeroSpeed = 0x89C;
                public const long m_hOrientationFaceEntity = 0xA18;
                public const long m_nDelayedTeleportToNode = 0x9F0;
                public const long m_bNextNodeReturnsCurrent = 0xA98;
                public const long m_flLerpToPositionTargetT = 0x990;
                public const long m_hOrientationMatchEntity = 0x980;
                public const long m_OnLerpToPositionComplete = 0x9B8;
                public const long m_bStopFromBeginStopTarget = 0xB20;
                public const long m_bStoppedDuringTransition = 0x9B0;
                public const long m_eFindFollowMoverStrategy = 0xB28;
                public const long m_iszFollowMoverEntityName = 0xAC8;
                public const long m_flDistanceToReachMaxSpeed = 0x898;
                public const long m_flPathLocationToBeginStop = 0x8C0;
                public const long m_bCreateMovableSurfaceGraph = 0x955;
                public const long m_bDisableDecelerationToStop = 0xB2C;
                public const long m_flDistanceToReachZeroSpeed = 0x8B0;
                public const long m_vecFollowMoverCouplerRange = 0xAE4;
                public const long m_bStartFollowingClosestMover = 0x93A;
                public const long m_flFollowMoverSpringStrength = 0xADC;
                public const long m_iszArriveAtDestinationSound = 0x900;
                public const long m_flTimeStartOrientationChange = 0x948;
                public const long m_qTransitionSourceOrientation = 0x9E0;
                public const long m_strOrientationFaceEntityName = 0xA10;
                public const long m_bFollowConstraintsInitialized = 0xAEC;
                public const long m_eTransitionedToPathNodeAction = 0x9D4;
                public const long m_flTimeToBlendToNewOrientation = 0x94C;
                public const long m_iszOrientationMatchEntityName = 0x978;
                public const long m_flTransitionSourcePathLocation = 0x9A4;
                public const long m_nFollowMoverConstraintPriority = 0xAE0;
                public const long m_flFollowMoverCalculatedDistance = 0xAD8;
                public const long m_iszTransitionSourcePathNodeStart = 0x9A8;
                public const long m_flComputedDistanceToReachMaxSpeed = 0x8A0;
                public const long m_flComputedDistanceToReachZeroSpeed = 0x8A4;
                public const long m_flDurationBlendToNewOrientationRan = 0x950;
                public const long m_bAllowMovableNavMeshDockingOnEntireEntity = 0x956;
                public const long m_flStartFollowingClosestMoverWhenWithinDistance = 0x93C;
                public const long m_flStartFollowingClosestMoverWhenOutsideDistance = 0x940;
            }
            public static partial class CFuncTrain {
                public const long m_hEnemy = 0x900;
                public const long m_flSpeed = 0x918;
                public const long m_activated = 0x8FC;
                public const long m_flBlockDamage = 0x904;
                public const long m_iszLastTarget = 0x910;
                public const long m_hCurrentTarget = 0x8F8;
                public const long m_flNextBlockTime = 0x908;
            }
            public static partial class CFuncWater {
                public const long m_BuoyancyHelper = 0x850;
            }
            public static partial class CGameMoney {
                public const long m_nMoney = 0x890;
                public const long m_OnMoneySpent = 0x860;
                public const long m_strAwardText = 0x898;
                public const long m_OnMoneySpentFail = 0x878;
            }
            public static partial class CGameRules {
                public const long m_bGamePaused = 0xC8;
                public const long m_nQuestPhase = 0xB0;
                public const long m_szQuestName = 0x30;
                public const long __m_pChainEntity = 0x8;
                public const long m_nLastMatchTime = 0xB4;
                public const long m_nPauseStartTick = 0xC4;
                public const long m_nTotalPausedTicks = 0xC0;
                public const long m_nLastMatchTime_MatchID64 = 0xB8;
            }
            public static partial class CGunTarget {
                public const long m_on = 0x8D4;
                public const long m_OnDeath = 0x8E0;
                public const long m_flSpeed = 0x8D0;
                public const long m_hTargetEnt = 0x8D8;
            }
            public static partial class CHEGrenade {

            }
            public static partial class CLogicAuto {
                public const long m_OnNewGame = 0x4D8;
                public const long m_OnLoadGame = 0x4F0;
                public const long m_OnMapSpawn = 0x4A8;
                public const long m_OnVREnabled = 0x568;
                public const long m_globalstate = 0x598;
                public const long m_OnMultiNewMap = 0x538;
                public const long m_OnDemoMapSpawn = 0x4C0;
                public const long m_OnVRNotEnabled = 0x580;
                public const long m_OnBackgroundMap = 0x520;
                public const long m_OnMapTransition = 0x508;
                public const long m_OnMultiNewRound = 0x550;
            }
            public static partial class CLogicCase {
                public const long m_nCase = 0x4A8;
                public const long m_OnCase = 0x5D0;
                public const long m_OnDefault = 0x8D0;
                public const long m_nShuffleCases = 0x5A8;
                public const long m_nLastShuffleCase = 0x5AC;
                public const long m_uchShuffleCaseMap = 0x5B0;
            }
            public static partial class CMathRemap {
                public const long m_flOut1 = 0x4B0;
                public const long m_flOut2 = 0x4B4;
                public const long m_flInMax = 0x4AC;
                public const long m_flInMin = 0x4A8;
                public const long m_OutValue = 0x4C0;
                public const long m_bEnabled = 0x4BC;
                public const long m_flOldInValue = 0x4B8;
                public const long m_OnFellBelowMax = 0x528;
                public const long m_OnFellBelowMin = 0x510;
                public const long m_OnRoseAboveMax = 0x4F8;
                public const long m_OnRoseAboveMin = 0x4E0;
            }
            public static partial class CNavVolume {

            }
            public static partial class COmniLight {
                public const long m_bShowLight = 0xB40;
                public const long m_flInnerAngle = 0xB38;
                public const long m_flOuterAngle = 0xB3C;
            }
            public static partial class CPathMover {
                public const long m_vecMovers = 0x600;
                public const long m_vecSpawners = 0x618;
                public const long m_hMoverRouter = 0x638;
                public const long m_flSampleSpacing = 0x648;
                public const long m_iszMoverRouterName = 0x640;
                public const long m_iszMoverSpawnerName = 0x630;
            }
            public static partial class CPathTrack {
                public const long m_pnext = 0x4A8;
                public const long m_OnPass = 0x4D0;
                public const long m_length = 0x4BC;
                public const long m_altName = 0x4C0;
                public const long m_flSpeed = 0x4B4;
                public const long m_flRadius = 0x4B8;
                public const long m_nIterVal = 0x4C8;
                public const long m_paltpath = 0x4B0;
                public const long m_pprevious = 0x4AC;
                public const long m_eOrientationType = 0x4CC;
            }
            public static partial class CPhysFixed {
                public const long m_sBoneName1 = 0x520;
                public const long m_sBoneName2 = 0x528;
                public const long m_flLinearFrequency = 0x508;
                public const long m_flAngularFrequency = 0x510;
                public const long m_flLinearDampingRatio = 0x50C;
                public const long m_flAngularDampingRatio = 0x514;
                public const long m_bEnableLinearConstraint = 0x518;
                public const long m_bEnableAngularConstraint = 0x519;
            }
            public static partial class CPhysForce {
                public const long m_force = 0x4B8;
                public const long m_forceTime = 0x4BC;
                public const long m_integrator = 0x4C8;
                public const long m_nameAttach = 0x4B0;
                public const long m_pController = 0x4A8;
                public const long m_wasRestored = 0x4C4;
                public const long m_attachedObject = 0x4C0;
            }
            public static partial class CPhysHinge {
                public const long m_hinge = 0x5DC;
                public const long m_soundInfo = 0x510;
                public const long m_bAtMaxLimit = 0x5D9;
                public const long m_bAtMinLimit = 0x5D8;
                public const long m_OnStopMoving = 0x660;
                public const long m_bIsAxisLocal = 0x624;
                public const long m_flAngleSpeed = 0x63C;
                public const long m_OnStartMoving = 0x648;
                public const long m_flMaxRotation = 0x62C;
                public const long m_flMinRotation = 0x628;
                public const long m_hingeFriction = 0x61C;
                public const long m_systemLoadScale = 0x620;
                public const long m_flMotorFrequency = 0x634;
                public const long m_flInitialRotation = 0x630;
                public const long m_flMotorDampingRatio = 0x638;
                public const long m_NotifyMaxLimitReached = 0x5C0;
                public const long m_NotifyMinLimitReached = 0x5A8;
                public const long m_flAngleSpeedThreshold = 0x640;
                public const long m_flLimitsDebugVisRotation = 0x644;
            }
            public static partial class CPhysMotor {
                public const long m_motor = 0x4F0;
                public const long m_spinUp = 0x4C0;
                public const long m_spinDown = 0x4C4;
                public const long m_nameAnchor = 0x4B0;
                public const long m_nameAttach = 0x4A8;
                public const long m_pMotorJoint = 0x4E8;
                public const long m_flTargetSpeed = 0x4D8;
                public const long m_flTorqueScale = 0x4D4;
                public const long m_hAnchorObject = 0x4BC;
                public const long m_flMotorFriction = 0x4C8;
                public const long m_hAttachedObject = 0x4B8;
                public const long m_pFixedWorldBody = 0x4E0;
                public const long m_angularAcceleration = 0x4D0;
                public const long m_additionalAcceleration = 0x4CC;
                public const long m_flSpeedWhenSpinUpOrSpinDownStarted = 0x4DC;
            }
            public static partial class CPlantedC4 {
                public const long m_flC4Blow = 0xA9C;
                public const long m_nBombSite = 0xAA0;
                public const long m_nSpotRules = 0xF50;
                public const long m_bBombDefused = 0xF55;
                public const long m_bBombTicking = 0xA98;
                public const long m_bHasExploded = 0xF54;
                public const long m_hBombDefuser = 0xF74;
                public const long m_OnBombDefused = 0xEE8;
                public const long m_bBeingDefused = 0xF5C;
                public const long m_flTimerLength = 0xF58;
                public const long m_flDefuseLength = 0xF6C;
                public const long m_fLastDefuseTime = 0xF64;
                public const long m_AttributeManager = 0xAB0;
                public const long m_bCannotBeDefused = 0xF30;
                public const long m_bVoiceAlertFired = 0xF7C;
                public const long m_iProgressBarTime = 0xF78;
                public const long m_OnBombBeginDefuse = 0xF00;
                public const long m_bVoiceAlertPlayed = 0xF7D;
                public const long m_flDefuseCountDown = 0xF70;
                public const long m_flNextBotBeepTime = 0xF84;
                public const long m_entitySpottedState = 0xF38;
                public const long m_OnBombDefuseAborted = 0xF18;
                public const long m_angCatchUpToPlayerEye = 0xF8C;
                public const long m_nSourceSoundscapeHash = 0xAA4;
                public const long m_bTrainingPlacedByPlayer = 0xF56;
                public const long m_flLastSpinDetectionTime = 0xF98;
                public const long m_bAbortDetonationBecauseWorldIsFrozen = 0xAA8;
            }
            public static partial class CPointHurt {
                public const long m_flDelay = 0x4B4;
                public const long m_nDamage = 0x4A8;
                public const long m_flRadius = 0x4B0;
                public const long m_strTarget = 0x4B8;
                public const long m_pActivator = 0x4C0;
                public const long m_bitsDamageType = 0x4AC;
            }
            public static partial class CPointPush {
                public const long m_hFilter = 0x4C8;
                public const long m_bEnabled = 0x4A8;
                public const long m_flRadius = 0x4B0;
                public const long m_flMagnitude = 0x4AC;
                public const long m_flInnerRadius = 0x4B4;
                public const long m_iszFilterName = 0x4C0;
                public const long m_flConeOfInfluence = 0x4B8;
            }
            public static partial class CRectLight {
                public const long m_bShowLight = 0xB38;
            }
            public static partial class CRotButton {

            }
            public static partial class CSkyCamera {
                public const long m_pNext = 0x540;
                public const long m_bUseAngles = 0x53C;
                public const long m_skyboxData = 0x4A8;
                public const long m_skyboxSlotToken = 0x538;
            }
            public static partial class CStopwatch {
                public const long m_flInterval = 0xC;
            }
            public static partial class CWeaponAWP {

            }
            public static partial class CWeaponAug {

            }
            public static partial class CWeaponMP7 {

            }
            public static partial class CWeaponMP9 {

            }
            public static partial class CWeaponP90 {

            }
            public static partial class SpawnPoint {
                public const long m_nType = 0x4B0;
                public const long m_bEnabled = 0x4AC;
                public const long m_iPriority = 0x4A8;
            }
            public static partial class lerpdata_t {
                public const long m_hEnt = 0x0;
                public const long m_MoveType = 0x4;
                public const long m_nFXIndex = 0x30;
                public const long m_qStartRot = 0x20;
                public const long m_flStartTime = 0x8;
                public const long m_vecStartOrigin = 0xC;
            }
            public static partial class AmmoIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class CBaseButton {
                public const long m_ls = 0x8E0;
                public const long m_OnIn = 0x978;
                public const long m_OnOut = 0x990;
                public const long m_nState = 0x9A8;
                public const long m_usable = 0x9C4;
                public const long m_bLocked = 0x920;
                public const long m_flSpeed = 0x924;
                public const long m_OnDamaged = 0x930;
                public const long m_OnPressed = 0x948;
                public const long m_bDisabled = 0x921;
                public const long m_bSolidBsp = 0x92C;
                public const long m_fRotating = 0x8DD;
                public const long m_sUseSound = 0x900;
                public const long m_glowEntity = 0x9C0;
                public const long m_OnUseLocked = 0x960;
                public const long m_fStayPushed = 0x8DC;
                public const long m_hConstraint = 0x9AC;
                public const long m_sGlowEntity = 0x9B8;
                public const long m_sLockedSound = 0x908;
                public const long m_szDisplayText = 0x9C8;
                public const long m_sUnlockedSound = 0x910;
                public const long m_flUseLockedTime = 0x928;
                public const long m_bForceNpcExclude = 0x9B4;
                public const long m_hConstraintParent = 0x9B0;
                public const long m_angMoveEntitySpace = 0x8D0;
                public const long m_sOverrideAnticipationName = 0x918;
            }
            public static partial class CBaseEntity {
                public const long m_think = 0x288;
                public const long m_fFlags = 0x388;
                public const long m_pfnUse = 0x2B8;
                public const long m_target = 0x300;
                public const long m_OnUser1 = 0x418;
                public const long m_OnUser2 = 0x430;
                public const long m_OnUser3 = 0x448;
                public const long m_OnUser4 = 0x460;
                public const long m_iEFlags = 0x414;
                public const long m_iHealth = 0x2D0;
                public const long m_MoveType = 0x2F3;
                public const long m_OnKilled = 0x370;
                public const long m_fEffects = 0x3E8;
                public const long m_iTeamNum = 0x344;
                public const long m_pBlocker = 0x490;
                public const long m_pfnTouch = 0x2B0;
                public const long m_lifeState = 0x2D8;
                public const long m_flAnimTime = 0x328;
                public const long m_flFriction = 0x3F4;
                public const long m_iMaxHealth = 0x2D4;
                public const long m_nBloodType = 0x49C;
                public const long m_nWaterType = 0x412;
                public const long m_pCollision = 0x3D8;
                public const long m_pfnBlocked = 0x2C0;
                public const long m_spawnflags = 0x360;
                public const long m_MoveCollide = 0x2F2;
                public const long m_flLocalTime = 0x494;
                public const long m_flTimeScale = 0x400;
                public const long m_iGlobalname = 0x348;
                public const long m_nSlimeTouch = 0x2F7;
                public const long m_nSubclassID = 0x31C;
                public const long m_nWaterTouch = 0x2F6;
                public const long m_pfnMoveDone = 0x2C8;
                public const long m_vecVelocity = 0x398;
                public const long m_bTakesDamage = 0x2E0;
                public const long m_flCreateTime = 0x330;
                public const long m_flElasticity = 0x3F8;
                public const long m_flWaterLevel = 0x404;
                public const long m_hOwnerEntity = 0x3E4;
                public const long m_hDamageFilter = 0x308;
                public const long m_hEffectEntity = 0x3E0;
                public const long m_hGroundEntity = 0x3EC;
                public const long m_isSteadyState = 0x278;
                public const long m_nPlatformType = 0x2F0;
                public const long m_CBodyComponent = 0x30;
                public const long m_bLagCompensate = 0x48D;
                public const long m_flGravityScale = 0x3FC;
                public const long m_flMoveDoneTime = 0x318;
                public const long m_iSentToClients = 0x350;
                public const long m_nLastThinkTick = 0x264;
                public const long m_nNextThinkTick = 0x364;
                public const long m_nPushEnumCount = 0x3D4;
                public const long m_vecAbsVelocity = 0x38C;
                public const long m_vecAngVelocity = 0x480;
                public const long m_aThinkFunctions = 0x248;
                public const long m_iInitialTeamNum = 0x478;
                public const long m_nActualMoveType = 0x2F5;
                public const long m_nSimulationTick = 0x368;
                public const long m_sUniqueHammerID = 0x358;
                public const long m_vecBaseVelocity = 0x3C8;
                public const long m_ResponseContexts = 0x290;
                public const long m_bGravityDisabled = 0x408;
                public const long m_flSimulationTime = 0x32C;
                public const long m_nGroundBodyIndex = 0x3F0;
                public const long m_nTakeDamageFlags = 0x2E8;
                public const long m_lastNetworkChange = 0x280;
                public const long m_bAnimatedEveryTick = 0x409;
                public const long m_bClientSideRagdoll = 0x334;
                public const long m_iszResponseContext = 0x2A8;
                public const long m_bDisableLowViolence = 0x411;
                public const long m_bRestoreInHierarchy = 0x2F8;
                public const long m_flDamageAccumulator = 0x2DC;
                public const long m_iszDamageFilterName = 0x310;
                public const long m_pPulseGraphInstance = 0x4A0;
                public const long m_flActualGravityScale = 0x40C;
                public const long m_flNavIgnoreUntilTime = 0x47C;
                public const long m_iCurrentThinkContext = 0x260;
                public const long m_ubInterpolationFrame = 0x335;
                public const long m_bDisabledContextThinks = 0x268;
                public const long m_nPreviouslySetMoveType = 0x2F4;
                public const long m_vPrevVPhysicsUpdatePos = 0x338;
                public const long m_NetworkTransmitComponent = 0x38;
                public const long m_bGravityActuallyDisabled = 0x410;
                public const long m_flVPhysicsUpdateLocalTime = 0x498;
                public const long m_bNetworkQuantizeOriginAndAngles = 0x48C;
            }
            public static partial class CBaseFilter {
                public const long m_OnFail = 0x4C8;
                public const long m_OnPass = 0x4B0;
                public const long m_bNegated = 0x4A8;
            }
            public static partial class CBaseToggle {
                public const long m_flLip = 0x85C;
                public const long m_flWait = 0x858;
                public const long m_sMaster = 0x8C8;
                public const long m_flHeight = 0x8A0;
                public const long m_vecAngle1 = 0x888;
                public const long m_vecAngle2 = 0x894;
                public const long m_hActivator = 0x8A4;
                public const long m_vecMoveAng = 0x87C;
                public const long m_movementType = 0x8C0;
                public const long m_toggle_state = 0x850;
                public const long m_vecFinalDest = 0x8A8;
                public const long m_vecPosition1 = 0x864;
                public const long m_vecPosition2 = 0x870;
                public const long m_vecFinalAngle = 0x8B4;
                public const long m_flMoveDistance = 0x854;
                public const long m_bAlwaysFireBlockedOutputs = 0x860;
            }
            public static partial class CBombTarget {
                public const long m_bIsBombSiteB = 0xA10;
                public const long m_OnBombDefused = 0x9F8;
                public const long m_OnBombExplode = 0x9C8;
                public const long m_OnBombPlanted = 0x9E0;
                public const long m_szMountTarget = 0xA18;
                public const long m_hInstructorHint = 0xA20;
                public const long m_bBombPlantedHere = 0xA12;
                public const long m_bIsHeistBombTarget = 0xA11;
                public const long m_nBombSiteDesignation = 0xA24;
            }
            public static partial class CEconEntity {
                public const long m_hOldProvidee = 0xEA8;
                public const long m_nFallbackSeed = 0xE9C;
                public const long m_flFallbackWear = 0xEA0;
                public const long m_iOldOwnerClass = 0xEAC;
                public const long m_AttributeManager = 0xA58;
                public const long m_nFallbackPaintKit = 0xE98;
                public const long m_nFallbackStatTrak = 0xEA4;
                public const long m_OriginalOwnerXuidLow = 0xE90;
                public const long m_OriginalOwnerXuidHigh = 0xE94;
            }
            public static partial class CEffectData {
                public const long m_fFlags = 0x63;
                public const long m_nColor = 0x62;
                public const long m_vStart = 0x14;
                public const long m_flScale = 0x40;
                public const long m_hEntity = 0x38;
                public const long m_nHitBox = 0x60;
                public const long m_vAngles = 0x2C;
                public const long m_vNormal = 0x20;
                public const long m_vOrigin = 0x8;
                public const long m_flRadius = 0x48;
                public const long m_nMaterial = 0x5E;
                public const long m_nPenetrate = 0x5C;
                public const long m_flMagnitude = 0x44;
                public const long m_iEffectName = 0x6C;
                public const long m_nDamageType = 0x58;
                public const long m_hOtherEntity = 0x3C;
                public const long m_nEffectIndex = 0x50;
                public const long m_nSurfaceProp = 0x4C;
                public const long m_nAttachmentName = 0x68;
                public const long m_nAttachmentIndex = 0x64;
            }
            public static partial class CEnvCubemap {
                public const long m_Entity_bEnabled = 0x588;
                public const long m_Entity_bMoveable = 0x550;
                public const long m_Entity_nPriority = 0x55C;
                public const long m_Entity_nHandshake = 0x554;
                public const long m_Entity_bDefaultEnvMap = 0x575;
                public const long m_Entity_bIndoorCubeMap = 0x577;
                public const long m_Entity_bStartDisabled = 0x574;
                public const long m_Entity_flDiffuseScale = 0x570;
                public const long m_Entity_flEdgeFadeDist = 0x560;
                public const long m_Entity_vEdgeFadeDists = 0x564;
                public const long m_Entity_hCubemapTexture = 0x528;
                public const long m_Entity_vBoxProjectMaxs = 0x544;
                public const long m_Entity_vBoxProjectMins = 0x538;
                public const long m_Entity_flInfluenceRadius = 0x534;
                public const long m_Entity_bDefaultSpecEnvMap = 0x576;
                public const long m_Entity_bCustomCubemapTexture = 0x530;
                public const long m_Entity_nEnvCubeMapArrayIndex = 0x558;
                public const long m_Entity_bCopyDiffuseFromDefaultCubemap = 0x578;
            }
            public static partial class CEnvHudHint {
                public const long m_iszMessage = 0x4A8;
            }
            public static partial class CFilterName {
                public const long m_iFilterName = 0x4E0;
            }
            public static partial class CFilterTeam {
                public const long m_iFilterTeam = 0x4E0;
            }
            public static partial class CFogTrigger {
                public const long m_fog = 0x9C8;
            }
            public static partial class CFuncLadder {
                public const long m_Dismounts = 0x860;
                public const long m_bDisabled = 0x8A0;
                public const long m_bHasSlack = 0x8A2;
                public const long m_bFakeLadder = 0x8A1;
                public const long m_vecLocalTop = 0x878;
                public const long m_vecLadderDir = 0x850;
                public const long m_flAutoRideSpeed = 0x89C;
                public const long m_surfacePropName = 0x8A8;
                public const long m_OnPlayerGotOnLadder = 0x8B0;
                public const long m_OnPlayerGotOffLadder = 0x8C8;
                public const long m_vecPlayerMountPositionTop = 0x884;
                public const long m_vecPlayerMountPositionBottom = 0x890;
            }
            public static partial class CHandleTest {
                public const long m_Handle = 0x4A8;
                public const long m_bSendHandle = 0x4AC;
            }
            public static partial class CInfoTarget {

            }
            public static partial class CItemKevlar {

            }
            public static partial class CLogicRelay {
                public const long m_OnSpawn = 0x4A8;
                public const long m_OnTrigger = 0x4C0;
                public const long m_bDisabled = 0x4D8;
                public const long m_bTriggerOnce = 0x4DA;
                public const long m_bFastRetrigger = 0x4DB;
                public const long m_bWaitForRefire = 0x4D9;
                public const long m_bPassthoughCaller = 0x4DC;
            }
            public static partial class CModelState {
                public const long m_hModel = 0xA0;
                public const long m_ModelName = 0xA8;
                public const long m_nForceLOD = 0x283;
                public const long m_MeshGroupMask = 0x1E8;
                public const long m_nIdealMotionType = 0x282;
                public const long m_nBodyGroupChoices = 0x238;
                public const long m_nClothUpdateFlags = 0x284;
                public const long m_flRootBoneOffset_x = 0xE8;
                public const long m_flRootBoneOffset_y = 0xEC;
                public const long m_flRootBoneOffset_z = 0xF0;
                public const long m_pVPhysicsAggregate = 0xE0;
                public const long m_bClientClothCreationSuppressed = 0xF5;
                public const long m_nAnimStateNoInterpSerialNumber = 0x1E0;
                public const long m_nRootBoneOffsetResetSerialNumber = 0xF4;
            }
            public static partial class CNullEntity {

            }
            public static partial class CPathCorner {
                public const long m_OnPass = 0x4C8;
                public const long m_flWait = 0x4AC;
                public const long m_flSpeed = 0x4C0;
                public const long m_flRadius = 0x4B0;
                public const long m_bSmoothArrival = 0x4A9;
                public const long m_bExactPositioning = 0x4AA;
                public const long m_bTriggerLocomotionStop = 0x4A8;
                public const long m_flWaypointSuccessRadius = 0x4B8;
                public const long m_flPathEndDistanceFromGoal = 0x4BC;
                public const long m_flWaypointSuccessRadiusWhenBlocked = 0x4B4;
            }
            public static partial class CPathSimple {
                public const long m_pathString = 0x5A0;
                public const long m_bClosedLoop = 0x5A8;
                public const long m_CPathQueryComponent = 0x4B0;
            }
            public static partial class CPhysImpact {
                public const long m_damage = 0x4A8;
                public const long m_distance = 0x4AC;
                public const long m_directionEntityName = 0x4B0;
            }
            public static partial class CPhysLength {
                public const long m_offset = 0x508;
                public const long m_addLength = 0x52C;
                public const long m_minLength = 0x530;
                public const long m_vecAttach = 0x520;
                public const long m_totalLength = 0x534;
            }
            public static partial class CPhysMagnet {
                public const long m_bActive = 0xA98;
                public const long m_flRadius = 0xAA0;
                public const long m_massScale = 0xA70;
                public const long m_forceLimit = 0xA74;
                public const long m_flTotalMass = 0xA9C;
                public const long m_torqueLimit = 0xA78;
                public const long m_OnMagnetAttach = 0xA40;
                public const long m_OnMagnetDetach = 0xA58;
                public const long m_flNextSuckTime = 0xAA4;
                public const long m_bHasHitSomething = 0xA99;
                public const long m_MagnettedEntities = 0xA80;
                public const long m_iMaxObjectsAttached = 0xAA8;
            }
            public static partial class CPhysPulley {
                public const long m_offset = 0x514;
                public const long m_addLength = 0x52C;
                public const long m_gearRatio = 0x530;
                public const long m_position2 = 0x508;
            }
            public static partial class CPhysTorque {
                public const long m_axis = 0x508;
            }
            public static partial class CPlayerPing {
                public const long m_iType = 0x4B8;
                public const long m_bUrgent = 0x4BC;
                public const long m_hPlayer = 0x4B0;
                public const long m_szPlaceName = 0x4BD;
                public const long m_hPingedEntity = 0x4B4;
            }
            public static partial class CPointPulse {

            }
            public static partial class CRangeFloat {
                public const long m_pValue = 0x0;
            }
            public static partial class CRemapFloat {
                public const long m_pValue = 0x0;
            }
            public static partial class CRuleEntity {
                public const long m_iszMaster = 0x850;
            }
            public static partial class CScriptItem {
                public const long m_MoveTypeOverride = 0xAE0;
            }
            public static partial class CSkillFloat {
                public const long m_pValue = 0x0;
            }
            public static partial class CSmoothFunc {
                public const long m_nSmoothDir = 0x18;
                public const long m_flSmoothBias = 0xC;
                public const long m_flSmoothDuration = 0x10;
                public const long m_flSmoothAmplitude = 0x8;
                public const long m_flSmoothRemainingTime = 0x14;
            }
            public static partial class CSoundPatch {
                public const long m_hEnt = 0x50;
                public const long m_pitch = 0x8;
                public const long m_Filter = 0x68;
                public const long m_volume = 0x18;
                public const long m_isPlaying = 0x64;
                public const long m_flLastTime = 0x40;
                public const long m_soundOrigin = 0x58;
                public const long m_iszClassName = 0xA8;
                public const long m_shutdownTime = 0x3C;
                public const long m_soundEntityIndex = 0x54;
                public const long m_iszSoundScriptName = 0x48;
                public const long m_bUpdatedSoundOrigin = 0xA4;
                public const long m_flCloseCaptionDuration = 0xA0;
            }
            public static partial class CTestEffect {
                public const long m_iBeam = 0x4AC;
                public const long m_iLoop = 0x4A8;
                public const long m_pBeam = 0x4B0;
                public const long m_flBeamTime = 0x510;
                public const long m_flStartTime = 0x570;
            }
            public static partial class CTriggerFan {
                public const long m_flForce = 0xA04;
                public const long m_bFalloff = 0xA08;
                public const long m_hInfoFan = 0xA00;
                public const long m_RampTimer = 0xA10;
                public const long m_bRampDown = 0xA81;
                public const long m_vFanEndLS = 0xA40;
                public const long m_flNPCForce = 0xA70;
                public const long m_flRampTime = 0xA74;
                public const long m_iszInfoFan = 0xA58;
                public const long m_vDirection = 0x9D4;
                public const long m_bPushPlayer = 0xA80;
                public const long m_fNoiseSpeed = 0xA7C;
                public const long m_qNoiseDelta = 0x9F0;
                public const long m_vFanOriginLS = 0xA34;
                public const long m_vFanOriginWS = 0xA28;
                public const long m_fNoiseDegrees = 0xA78;
                public const long m_flPlayerForce = 0xA68;
                public const long m_nManagerFanIdx = 0xA84;
                public const long m_bPlayerWindblock = 0xA6C;
                public const long m_flRopeForceScale = 0xA60;
                public const long m_vFanOriginOffset = 0x9C8;
                public const long m_flParticleForceScale = 0xA64;
                public const long m_vNoiseDirectionTarget = 0xA4C;
                public const long m_bPushTowardsInfoTarget = 0x9E0;
                public const long m_bPushAwayFromInfoTarget = 0x9E1;
            }
            public static partial class CWeaponM249 {

            }
            public static partial class CWeaponM4A1 {

            }
            public static partial class CWeaponMag7 {

            }
            public static partial class CWeaponNOVA {

            }
            public static partial class CWeaponP250 {

            }
            public static partial class CWeaponTec9 {

            }
            public static partial class GAME_HEADER {
                public const long m_sComment = 0x0;
                public const long m_sLandmark = 0x10;
                public const long m_sRequiredAddons = 0x18;
                public const long m_nSpawnGroupCount = 0x8;
            }
            public static partial class HullFlags_t {
                public const long m_bHull_Tiny = 0x3;
                public const long m_bHull_Human = 0x0;
                public const long m_bHull_Large = 0x6;
                public const long m_bHull_Small = 0x9;
                public const long m_bHull_Medium = 0x4;
                public const long m_bHull_WideHuman = 0x2;
                public const long m_bHull_MediumTall = 0x8;
                public const long m_bHull_TinyCentered = 0x5;
                public const long m_bHull_LargeCentered = 0x7;
                public const long m_bHull_SmallCentered = 0x1;
            }
            public static partial class SAVE_HEADER {
                public const long m_saveId = 0x0;
                public const long m_version = 0x4;
                public const long m_flSaveTime = 0x50;
                public const long m_nMapVersion = 0xC;
                public const long m_vecWorldOffset = 0x20;
                public const long m_sSpawnGroupName = 0x10;
                public const long m_nConnectionCount = 0x8;
            }
            public static partial class fogparams_t {
                public const long end = 0x28;
                public const long farz = 0x2C;
                public const long blend = 0x65;
                public const long start = 0x24;
                public const long enable = 0x64;
                public const long duration = 0x54;
                public const long exponent = 0x34;
                public const long lerptime = 0x50;
                public const long endLerpTo = 0x48;
                public const long dirPrimary = 0x8;
                public const long m_bPadding = 0x67;
                public const long maxdensity = 0x30;
                public const long scattering = 0x5C;
                public const long m_bPadding2 = 0x66;
                public const long startLerpTo = 0x44;
                public const long colorPrimary = 0x14;
                public const long HDRColorScale = 0x38;
                public const long colorSecondary = 0x18;
                public const long locallightscale = 0x60;
                public const long skyboxFogFactor = 0x3C;
                public const long maxdensityLerpTo = 0x4C;
                public const long blendtobackground = 0x58;
                public const long colorPrimaryLerpTo = 0x1C;
                public const long colorSecondaryLerpTo = 0x20;
                public const long skyboxFogFactorLerpTo = 0x40;
            }
            public static partial class levellist_t {
                public const long m_sMapName = 0x0;
                public const long m_hEntLandmark = 0x10;
                public const long m_sLandmarkName = 0x8;
                public const long m_vecLandmarkAngles = 0x20;
                public const long m_vecLandmarkOrigin = 0x14;
            }
            public static partial class locksound_t {
                public const long flwaitSound = 0x18;
                public const long sLockedSound = 0x8;
                public const long sUnlockedSound = 0x10;
            }
            public static partial class thinkfunc_t {
                public const long m_hFn = 0x8;
                public const long m_think = 0x0;
                public const long m_nContext = 0x10;
                public const long m_nLastThinkTick = 0x18;
                public const long m_nNextThinkTick = 0x14;
            }
            public static partial class CBaseDMStart {
                public const long m_Master = 0x4A8;
            }
            public static partial class CBaseGrenade {
                public const long m_bIsLive = 0xA82;
                public const long m_flDamage = 0xA90;
                public const long m_hThrower = 0xAA8;
                public const long m_DmgRadius = 0xA84;
                public const long m_OnExplode = 0xA68;
                public const long m_bHasWarnedAI = 0xA80;
                public const long m_flNextAttack = 0xAC0;
                public const long m_flWarnAITime = 0xA8C;
                public const long m_ExplosionSound = 0xAA0;
                public const long m_OnPlayerPickup = 0xA50;
                public const long m_flDetonateTime = 0xA88;
                public const long m_iszBounceSound = 0xA98;
                public const long m_bIsSmokeGrenade = 0xA81;
                public const long m_hOriginalThrower = 0xAC4;
                public const long m_bDamageDetonating = 0xA48;
            }
            public static partial class CBaseTrigger {
                public const long m_hFilter = 0x9B0;
                public const long m_bDisabled = 0x9B4;
                public const long m_OnEndTouch = 0x900;
                public const long m_OnTouching = 0x930;
                public const long m_iFilterName = 0x9A8;
                public const long m_OnStartTouch = 0x8D0;
                public const long m_OnEndTouchAll = 0x918;
                public const long m_OnNotTouching = 0x960;
                public const long m_OnStartTouchAll = 0x8E8;
                public const long m_bUseAsyncQueries = 0x9C0;
                public const long m_OnTouchingChanged = 0x978;
                public const long m_hTouchingEntities = 0x990;
                public const long m_OnTouchingEachEntity = 0x948;
            }
            public static partial class CBtActionAim {
                public const long m_AimTimer = 0xA8;
                public const long m_bAcquired = 0xF0;
                public const long m_bDoneAiming = 0x8C;
                public const long m_szAimReadyKey = 0x80;
                public const long m_NextLookTarget = 0x9C;
                public const long m_SniperHoldTimer = 0xC0;
                public const long m_flLerpStartTime = 0x90;
                public const long m_szSensorInputKey = 0x68;
                public const long m_FocusIntervalTimer = 0xD8;
                public const long m_flPenaltyReductionRatio = 0x98;
                public const long m_flZoomCooldownTimestamp = 0x88;
                public const long m_flNextLookTargetLerpTime = 0x94;
            }
            public static partial class CCSGameRules {
                public const long m_iNumCT = 0xD90;
                public const long m_bLogoMap = 0x13D;
                public const long m_bTCantBuy = 0xA4C;
                public const long m_gamePhase = 0x11C;
                public const long m_bCTCantBuy = 0xA4D;
                public const long m_bIsValveDS = 0x13C;
                public const long m_iAccountCT = 0xE80;
                public const long m_iMaxNumCTs = 0xE90;
                public const long m_iRoundTime = 0x100;
                public const long m_MatchDevice = 0x144;
                public const long m_RetakeRules = 0x1140;
                public const long m_bVoteCalled = 0xEF0;
                public const long m_iFreezeTime = 0xFC;
                public const long m_nCTTimeOuts = 0xF4;
                public const long m_bBombDefused = 0xF01;
                public const long m_bBombDropped = 0xA40;
                public const long m_bBombPlanted = 0x95F;
                public const long m_bGameRestart = 0x110;
                public const long m_bNoCTsKilled = 0xEB5;
                public const long m_vMinimapMaxs = 0xCC4;
                public const long m_vMinimapMins = 0xCB8;
                public const long m_CTSpawnPoints = 0xFA8;
                public const long m_bBuyTimeEnded = 0xEF8;
                public const long m_bFreezePeriod = 0xD8;
                public const long m_bIsHltvActive = 0x95E;
                public const long m_bTargetBombed = 0xF00;
                public const long m_bWarmupPeriod = 0xD9;
                public const long m_firstKillTime = 0xEBC;
                public const long m_iNumTerrorist = 0xD8C;
                public const long m_numBestOfMaps = 0xA38;
                public const long m_bCompleteReset = 0xDBD;
                public const long m_bMapHasBuyZone = 0x133;
                public const long m_fAvgPlayerRank = 0xDEC;
                public const long m_firstBloodTime = 0xEC4;
                public const long m_nMatchEndCount = 0x13B8;
                public const long m_nRoundEndCount = 0x140C;
                public const long m_pGameModeRules = 0x1098;
                public const long m_szMatchStatTxt = 0x550;
                public const long m_bFirstConnected = 0xDBC;
                public const long m_bMapHasBombZone = 0xF02;
                public const long m_eRoundEndReason = 0x13D4;
                public const long m_eRoundWinReason = 0xA48;
                public const long m_endMatchOnThink = 0xD89;
                public const long m_fMatchStartTime = 0x104;
                public const long m_fRoundStartTime = 0x108;
                public const long m_flGameStartTime = 0x114;
                public const long m_flLastThinkTime = 0x1024;
                public const long m_hPlayerResource = 0x1138;
                public const long m_iNumSpawnableCT = 0xD98;
                public const long m_iRoundEndLegacy = 0x1408;
                public const long m_iRoundWinStatus = 0xA44;
                public const long m_ullLocalMatchID = 0xCF0;
                public const long m_bCTTimeOutActive = 0xE5;
                public const long m_bHasMatchStarted = 0x148;
                public const long m_bIsDroppingItems = 0x95C;
                public const long m_bIsQuestEligible = 0x95D;
                public const long m_bNoEnemiesKilled = 0xEB6;
                public const long m_bRoundEndNoMusic = 0x1404;
                public const long m_bTeamIntroPeriod = 0x13C4;
                public const long m_fWarmupPeriodEnd = 0xDC;
                public const long m_hostageWasKilled = 0xEE1;
                public const long m_iHostagesRescued = 0xEA8;
                public const long m_iHostagesTouched = 0xEAC;
                public const long m_nOvertimePlaying = 0x128;
                public const long m_nRoundStartCount = 0x1414;
                public const long m_sRoundEndMessage = 0x13F8;
                public const long m_bCanDonateWeapons = 0xEB7;
                public const long m_bLevelInitialized = 0xD7C;
                public const long m_bMapHasBombTarget = 0x131;
                public const long m_bMapHasRescueZone = 0x132;
                public const long m_bTechnicalTimeOut = 0xF8;
                public const long m_flNextRespawnWave = 0xC38;
                public const long m_hostageWasInjured = 0xEE0;
                public const long m_iAccountTerrorist = 0xE7C;
                public const long m_iMaxNumTerrorists = 0xE8C;
                public const long m_iNextCTSpawnPoint = 0xF94;
                public const long m_iUnBalancedRounds = 0xD84;
                public const long m_totalRoundsPlayed = 0x120;
                public const long m_vecMainCTSpawnPos = 0xF50;
                public const long mTeamDMLastThinkTime = 0xE74;
                public const long m_BtGlobalBlackboard = 0x10A0;
                public const long m_bAllowWeaponSwitch = 0x1018;
                public const long m_bAnyHostageReached = 0x130;
                public const long m_bPlayedTeamIntroVO = 0x13CC;
                public const long m_bServerVoteOnReset = 0xEF1;
                public const long m_fWarmupPeriodStart = 0xE0;
                public const long m_flRestartRoundTime = 0x10C;
                public const long m_iHostagesRemaining = 0x12C;
                public const long m_iRoundEndTimerTime = 0x13DC;
                public const long m_iTotalRoundsPlayed = 0xD80;
                public const long m_nEndMatchTiedVotes = 0xDC8;
                public const long m_nLastFreezeEndBeep = 0xEFC;
                public const long m_nMatchInfoShowType = 0xE50;
                public const long m_nNextMapInMapgroup = 0x14C;
                public const long m_nTTeamIntroVariant = 0x13BC;
                public const long m_nTerroristTimeOuts = 0xF0;
                public const long m_bNoTerroristsKilled = 0xEB4;
                public const long m_bSwapTeamsOnRestart = 0xDC0;
                public const long m_fTeamIntroPeriodEnd = 0x13C8;
                public const long m_flVoteCheckThrottle = 0xEF4;
                public const long m_iRoundEndWinnerTeam = 0x13D0;
                public const long m_iSpawnPointCount_CT = 0xE88;
                public const long m_iSpectatorSlotCount = 0x140;
                public const long m_nCTTeamIntroVariant = 0x13C0;
                public const long m_tmNextPeriodicThink = 0xE98;
                public const long m_TeamRespawnWaveTimes = 0xBB8;
                public const long m_TerroristSpawnPoints = 0xFC0;
                public const long m_bIsQueuedMatchmaking = 0x134;
                public const long m_bPickNewTeamsOnReset = 0xDBE;
                public const long m_endMatchOnRoundReset = 0xD88;
                public const long m_flCTTimeOutRemaining = 0xEC;
                public const long m_flLastPerfSampleTime = 0x5420;
                public const long m_iRoundEndPlayerCount = 0x1400;
                public const long m_flIntermissionEndTime = 0xD78;
                public const long m_iRoundEndFunFactData1 = 0x13EC;
                public const long m_iRoundEndFunFactData2 = 0x13F0;
                public const long m_iRoundEndFunFactData3 = 0x13F4;
                public const long m_numSpectatorsCountMax = 0xDFC;
                public const long m_sRoundEndFunFactToken = 0x13E0;
                public const long m_szTournamentEventName = 0x150;
                public const long m_bForceTeamChangeSilent = 0xE18;
                public const long m_bHasHostageBeenTouched = 0xD70;
                public const long m_bMatchWaitingForResume = 0xF9;
                public const long m_flCTSpawnPointUsedTime = 0xF98;
                public const long m_flMatchInfoDecidedTime = 0xE54;
                public const long m_iNumConsecutiveCTLoses = 0xD4C;
                public const long m_iNumSpawnableTerrorist = 0xD94;
                public const long m_iRoundStartRoundNumber = 0x1410;
                public const long m_nEndMatchMapVoteWinner = 0xD48;
                public const long m_nHalloweenMaskListSeed = 0xA3C;
                public const long m_nQueuedMatchmakingMode = 0x138;
                public const long m_nRoundsPlayedThisPhase = 0x124;
                public const long m_nSpawnPointsRandomSeed = 0xDB8;
                public const long m_szTournamentEventStage = 0x350;
                public const long m_CTSpawnPointsMasterList = 0xF60;
                public const long m_bIsUnreservedGameServer = 0xFD8;
                public const long m_bLoadingRoundBackupData = 0xE19;
                public const long m_bScrambleTeamsOnRestart = 0xDBF;
                public const long m_bTerroristTimeOutActive = 0xE4;
                public const long m_bVoiceWonMatchBragFired = 0xE9C;
                public const long m_fAutobalanceDisplayTime = 0xFDC;
                public const long m_flIntermissionStartTime = 0xD74;
                public const long m_numSpectatorsCountMaxTV = 0xE00;
                public const long m_numTotalTournamentDrops = 0xDF8;
                public const long m_arrProhibitedItemIndices = 0x960;
                public const long m_bRoundEndShowTimerDefend = 0x13D8;
                public const long m_iMatchStats_RoundResults = 0xA50;
                public const long m_iNextTerroristSpawnPoint = 0xF9C;
                public const long m_nCTsAliveAtFreezetimeEnd = 0xE10;
                public const long m_nMatchAbortedEarlyReason = 0x1078;
                public const long m_numSpectatorsCountMaxLnk = 0xE04;
                public const long m_timeUntilNextPhaseStarts = 0x118;
                public const long m_fWarmupNextChatNoticeTime = 0xEA0;
                public const long m_flNextHostageAnnouncement = 0xEB0;
                public const long m_iLoserBonusMostRecentTeam = 0xE94;
                public const long m_nTournamentPredictionsPct = 0x950;
                public const long mTeamDMLastWinningTeamNumber = 0xE70;
                public const long m_bPlayAllStepSoundsOnServer = 0x13E;
                public const long m_bRoundTimeWarningTriggered = 0x1019;
                public const long m_fAccumulatedRoundOffDamage = 0x1028;
                public const long m_flCMMItemDropRevealEndTime = 0x958;
                public const long m_iMatchStats_PlayersAlive_T = 0xB40;
                public const long m_iRoundEndFunFactPlayerSlot = 0x13E8;
                public const long m_iSpawnPointCount_Terrorist = 0xE84;
                public const long m_nEndMatchMapGroupVoteTypes = 0xCF8;
                public const long m_szTournamentPredictionsTxt = 0x750;
                public const long m_bSwitchingTeamsAtRoundReset = 0x107D;
                public const long m_flTerroristTimeOutRemaining = 0xE8;
                public const long m_iMatchStats_PlayersAlive_CT = 0xAC8;
                public const long m_phaseChangeAnnouncementTime = 0x101C;
                public const long m_bHasTriggeredRoundStartMusic = 0x107C;
                public const long m_fNextUpdateTeamClanNamesTime = 0x1020;
                public const long m_flCMMItemDropRevealStartTime = 0x954;
                public const long m_flTeamDMLastAnnouncementTime = 0xE78;
                public const long m_nEndMatchMapGroupVoteOptions = 0xD20;
                public const long m_numQueuedMatchmakingAccounts = 0xDE8;
                public const long m_MinimapVerticalSectionHeights = 0xCD0;
                public const long m_arrTeamUniqueKillWeaponsMatch = 0x1330;
                public const long m_flTerroristSpawnPointUsedTime = 0xFA0;
                public const long m_iNumConsecutiveTerroristLoses = 0xD50;
                public const long m_TerroristSpawnPointsMasterList = 0xF78;
                public const long m_arrSelectedHostageSpawnIndices = 0xDA0;
                public const long m_nShorthandedBonusLastEvalRound = 0x102C;
                public const long m_nTerroristsAliveAtFreezetimeEnd = 0xE14;
                public const long m_bNeedToAskPlayersForContinueVote = 0xDE4;
                public const long m_bRespawningAllRespawnablePlayers = 0xF90;
                public const long m_arrTournamentActiveCasterAccounts = 0xA28;
                public const long m_bTeamLastKillUsedUniqueWeaponMatch = 0x1390;
                public const long m_pQueuedMatchmakingReservationString = 0xDF0;
            }
            public static partial class CChangeLevel {
                public const long m_bNoTouch = 0x9F1;
                public const long m_bTouched = 0x9F0;
                public const long m_sMapName = 0x9C8;
                public const long m_bNewChapter = 0x9F2;
                public const long m_OnChangeLevel = 0x9D8;
                public const long m_sLandmarkName = 0x9D0;
                public const long m_bOnChangeLevelFired = 0x9F3;
            }
            public static partial class CDynamicProp {
                public const long m_glowColor = 0xC80;
                public const long m_nGlowTeam = 0xC84;
                public const long m_nGlowRange = 0xC78;
                public const long m_iszIdleAnim = 0xC60;
                public const long m_bUseAnimGraph = 0xBE3;
                public const long m_nGlowRangeMin = 0xC7C;
                public const long m_bStartDisabled = 0xC6D;
                public const long m_bCreateNonSolid = 0xC71;
                public const long m_bIsOverrideProp = 0xC72;
                public const long m_bRandomizeCycle = 0xC6C;
                public const long m_pOutputAnimOver = 0xC00;
                public const long m_OnAnimReachedEnd = 0xC48;
                public const long m_bForceNpcExclude = 0xC6F;
                public const long m_pOutputAnimBegun = 0xBE8;
                public const long m_iInitialGlowState = 0xC74;
                public const long m_nIdleAnimLoopMode = 0xC68;
                public const long m_OnAnimReachedStart = 0xC30;
                public const long m_bCreateNavObstacle = 0xBE0;
                public const long m_bFiredStartEndOutput = 0xC6E;
                public const long m_bGraphControllerEnabled = 0xBD0;
                public const long m_bUseHitboxesForRenderBox = 0xBE2;
                public const long m_pOutputAnimLoopCycleOver = 0xC18;
                public const long m_bCreateMovableSurfaceGraph = 0xC70;
                public const long m_bNavObstacleUpdatesOverridden = 0xBE1;
            }
            public static partial class CEntityFlame {
                public const long m_flSize = 0x4B0;
                public const long m_hAttacker = 0x4C4;
                public const long m_flLifetime = 0x4C0;
                public const long m_bCheapEffect = 0x4AC;
                public const long m_bUseHitboxes = 0x4B4;
                public const long m_hEntAttached = 0x4A8;
                public const long m_iNumHitboxFires = 0x4B8;
                public const long m_flHitboxFireScale = 0x4BC;
                public const long m_iCustomDamageType = 0x4CC;
                public const long m_flDirectDamagePerSecond = 0x4C8;
            }
            public static partial class CEnvBeverage {
                public const long m_nBeverageType = 0x4AC;
                public const long m_CanInDispenser = 0x4A8;
            }
            public static partial class CFilterClass {
                public const long m_iFilterClass = 0x4E0;
            }
            public static partial class CFilterEnemy {
                public const long m_flRadius = 0x4E8;
                public const long m_iszEnemyName = 0x4E0;
                public const long m_flOuterRadius = 0x4EC;
                public const long m_iszPlayerName = 0x4F8;
                public const long m_nMaxSquadmatesPerEnemy = 0x4F0;
            }
            public static partial class CFilterModel {
                public const long m_iFilterModel = 0x4E0;
            }
            public static partial class CFuncMonitor {
                public const long m_bEnabled = 0x88C;
                public const long m_targetCamera = 0x870;
                public const long m_bDraw3DSkybox = 0x88D;
                public const long m_bStartEnabled = 0x88E;
                public const long m_hTargetCamera = 0x888;
                public const long m_bRenderShadows = 0x87C;
                public const long m_brushModelName = 0x880;
                public const long m_nResolutionEnum = 0x878;
                public const long m_bUseUniqueColorTarget = 0x87D;
            }
            public static partial class CFuncPlatRot {
                public const long m_end = 0x908;
                public const long m_start = 0x914;
            }
            public static partial class CFuncRotator {
                public const long m_flSpeed = 0x858;
                public const long m_bQueueStop = 0x9A0;
                public const long m_eSolidType = 0x855;
                public const long m_OnOscillate = 0x8A0;
                public const long m_bIsRotating = 0x854;
                public const long m_eRotateType = 0x850;
                public const long m_flStartSpeed = 0x938;
                public const long m_iszLoopSound = 0x968;
                public const long m_iszStopSound = 0x988;
                public const long m_eRotationAxis = 0x998;
                public const long m_flTargetAngle = 0x990;
                public const long m_iszStartSound = 0x960;
                public const long m_flCurrentAngle = 0x994;
                public const long m_hRotatorTarget = 0x864;
                public const long m_nTickRotateRan = 0x918;
                public const long m_rotationSummary = 0x920;
                public const long m_bStartedRotating = 0x91C;
                public const long m_flMaxYawRotation = 0x958;
                public const long m_flMinYawRotation = 0x954;
                public const long m_strRotatorTarget = 0x868;
                public const long m_OnRotationStarted = 0x870;
                public const long m_qSpawnOrientation = 0x940;
                public const long m_flTimeRotationStop = 0x934;
                public const long m_OnRotationCompleted = 0x888;
                public const long m_flTimeRotationStart = 0x930;
                public const long m_OnOscillateEndArrive = 0x8E8;
                public const long m_OnOscillateEndDepart = 0x900;
                public const long m_bOscillationFromStart = 0x95C;
                public const long m_flTimeToReachMaxSpeed = 0x928;
                public const long m_OnOscillateStartArrive = 0x8B8;
                public const long m_OnOscillateStartDepart = 0x8D0;
                public const long m_flTimeToReachZeroSpeed = 0x92C;
                public const long m_flTimeToCompleteRotation = 0x860;
                public const long m_flRotationDistanceDegrees = 0x85C;
                public const long m_flSpeedDriftFromOverRotate = 0x99C;
                public const long m_bReturningToInitialRotation = 0x950;
            }
            public static partial class CGradientFog {
                public const long m_flFarZ = 0x4C4;
                public const long m_fogColor = 0x4D4;
                public const long m_bIsEnabled = 0x4E1;
                public const long m_flFadeTime = 0x4DC;
                public const long m_flFogStrength = 0x4D8;
                public const long m_bStartDisabled = 0x4E0;
                public const long m_flFogEndHeight = 0x4C0;
                public const long m_flFogMaxOpacity = 0x4C8;
                public const long m_flFogEndDistance = 0x4B4;
                public const long m_flFogStartHeight = 0x4BC;
                public const long m_bHeightFogEnabled = 0x4B8;
                public const long m_flFogStartDistance = 0x4B0;
                public const long m_hGradientFogTexture = 0x4A8;
                public const long m_flFogFalloffExponent = 0x4CC;
                public const long m_flFogVerticalExponent = 0x4D0;
                public const long m_bGradientFogNeedsTextures = 0x4E2;
            }
            public static partial class CHandleDummy {

            }
            public static partial class CHintMessage {
                public const long m_args = 0x8;
                public const long m_duration = 0x20;
                public const long m_hintString = 0x0;
            }
            public static partial class CItemDefuser {
                public const long m_nSpotRules = 0xAF8;
                public const long m_entitySpottedState = 0xAE0;
            }
            public static partial class CItemDogtags {
                public const long m_OwningPlayer = 0xAE0;
                public const long m_KillingPlayer = 0xAE4;
            }
            public static partial class CItemGeneric {
                public const long m_OnPickup = 0xB68;
                public const long m_bUseable = 0xC00;
                public const long m_OnTimeout = 0xB80;
                public const long m_glowColor = 0xBFC;
                public const long m_hPickupFilter = 0xB60;
                public const long m_OnTriggerTouch = 0xBB0;
                public const long m_flPickupRadius = 0xBE8;
                public const long m_hTriggerHelper = 0xC04;
                public const long m_flTriggerRadius = 0xBEC;
                public const long m_bHasPickupRadius = 0xAF5;
                public const long m_OnTriggerEndTouch = 0xBC8;
                public const long m_bHasTriggerRadius = 0xAF4;
                public const long m_flLastPickupCheck = 0xB00;
                public const long m_flPickupRadiusSqr = 0xAF8;
                public const long m_pPickupFilterName = 0xB58;
                public const long m_bGlowWhenInTrigger = 0xBF8;
                public const long m_flTriggerRadiusSqr = 0xAFC;
                public const long m_pPickupSoundEffect = 0xB30;
                public const long m_OnTriggerStartTouch = 0xB98;
                public const long m_pAmbientSoundEffect = 0xB10;
                public const long m_pTimeoutSoundEffect = 0xB48;
                public const long m_pTriggerSoundEffect = 0xBF0;
                public const long m_hSpawnParticleEffect = 0xB08;
                public const long m_pSpawnScriptFunction = 0xB20;
                public const long m_hPickupParticleEffect = 0xB28;
                public const long m_pPickupScriptFunction = 0xB38;
                public const long m_bAutoStartAmbientSound = 0xB18;
                public const long m_bPlayerInTriggerRadius = 0xB05;
                public const long m_hTimeoutParticleEffect = 0xB40;
                public const long m_pTimeoutScriptFunction = 0xB50;
                public const long m_pAllowPickupScriptFunction = 0xBE0;
                public const long m_bPlayerCounterListenerAdded = 0xB04;
            }
            public static partial class CKeepUpright {
                public const long m_bActive = 0x4E0;
                public const long m_nameAttach = 0x4D0;
                public const long m_pController = 0x4C8;
                public const long m_angularLimit = 0x4DC;
                public const long m_localTestAxis = 0x4BC;
                public const long m_worldGoalAxis = 0x4B0;
                public const long m_attachedObject = 0x4D8;
                public const long m_bDampAllRotation = 0x4E1;
            }
            public static partial class CLightEntity {
                public const long m_CLightComponent = 0x850;
            }
            public static partial class CLogicBranch {
                public const long m_OnTrue = 0x4C8;
                public const long m_OnFalse = 0x4E0;
                public const long m_bInValue = 0x4A8;
                public const long m_Listeners = 0x4B0;
            }
            public static partial class CLogicScript {

            }
            public static partial class CMathCounter {
                public const long m_flMax = 0x4AC;
                public const long m_flMin = 0x4A8;
                public const long m_bHitMax = 0x4B1;
                public const long m_bHitMin = 0x4B0;
                public const long m_OnHitMax = 0x510;
                public const long m_OnHitMin = 0x4F8;
                public const long m_OutValue = 0x4B8;
                public const long m_bDisabled = 0x4B2;
                public const long m_OnGetValue = 0x4D8;
                public const long m_OnChangedFromMax = 0x540;
                public const long m_OnChangedFromMin = 0x528;
            }
            public static partial class CMultiSource {
                public const long m_iTotal = 0x5C0;
                public const long m_OnTrigger = 0x5A8;
                public const long m_rgEntities = 0x4A8;
                public const long m_globalstate = 0x5C8;
                public const long m_rgTriggered = 0x528;
            }
            public static partial class CNavPathCost {
                public const long m_bCanFly = 0x11;
                public const long m_bCanSwim = 0x12;
                public const long m_bAllowLadders = 0x10;
                public const long m_flTransitionPenalty = 0x2C;
                public const long m_bSupportsTransitions = 0x2A;
                public const long m_flGroundToWaterMaxHeight = 0x18;
                public const long m_flWaterToGroundMaxHeight = 0x14;
                public const long m_bOptimizeFlySpacePathfinds = 0x28;
                public const long m_flFlyingTransitionTolerance = 0x24;
                public const long m_bStringPullFlySpacePathfinds = 0x29;
                public const long m_flGroundToWaterTransitionDistance = 0x1C;
                public const long m_flWaterToGroundTransitionDistance = 0x20;
            }
            public static partial class CNavWalkable {

            }
            public static partial class CNmAimCSTask {

            }
            public static partial class CPhysicsProp {
                public const long m_bAwake = 0xD09;
                public const long m_OnAwake = 0xC10;
                public const long m_OnAsleep = 0xC28;
                public const long m_CrateType = 0xCD0;
                public const long m_glowColor = 0xCC0;
                public const long m_massScale = 0xC8C;
                public const long m_OnAwakened = 0xBF8;
                public const long m_damageType = 0xC94;
                public const long m_flLastBurn = 0xCA8;
                public const long m_nGlowRange = 0xCB8;
                public const long m_nItemCount = 0xCF8;
                public const long m_OnPlayerUse = 0xC40;
                public const long m_OnOutOfWorld = 0xC58;
                public const long m_strItemClass = 0xCD8;
                public const long m_MotionEnabled = 0xBE0;
                public const long m_buoyancyScale = 0xC90;
                public const long m_nGlowRangeMin = 0xCBC;
                public const long m_OnPlayerPickup = 0xC70;
                public const long m_bForceNavIgnore = 0xC88;
                public const long m_bIsOverrideProp = 0xCA4;
                public const long m_bDroppedByPlayer = 0xCA0;
                public const long m_bEnableUseOutput = 0xCCF;
                public const long m_bForceNpcExclude = 0xC8A;
                public const long m_bHasBeenAwakened = 0xCA3;
                public const long m_bTouchedByPlayer = 0xCA1;
                public const long m_nNavObstacleType = 0xCC8;
                public const long m_bNoNavmeshBlocker = 0xC89;
                public const long m_iInitialGlowState = 0xCB4;
                public const long m_bMuteImpactEffects = 0xCC5;
                public const long m_bForceNavObstacleCut = 0xCCD;
                public const long m_bUpdateNavWhenMoving = 0xCCC;
                public const long m_damageToEnableMotion = 0xC98;
                public const long m_flForceToEnableMotion = 0xC9C;
                public const long m_bAttachedToReferenceFrame = 0xD0A;
                public const long m_bFirstCollisionAfterLaunch = 0xCA2;
                public const long m_bRemovableForAmmoBalancing = 0xD08;
                public const long m_bAcceptDamageFromHeldObjects = 0xCCE;
                public const long m_bShouldAutoConvertBackFromDebris = 0xCC4;
                public const long m_nDynamicContinuousContactBehavior = 0xCAC;
                public const long m_fNextCheckDisableMotionContactsTime = 0xCB0;
            }
            public static partial class CPhysicsWire {
                public const long m_nDensity = 0x4A8;
            }
            public static partial class CPlatTrigger {
                public const long m_pPlatform = 0x850;
            }
            public static partial class CPointCamera {
                public const long m_FOV = 0x4A8;
                public const long m_bIsOn = 0x4FC;
                public const long m_pNext = 0x500;
                public const long m_bNoSky = 0x4CC;
                public const long m_flZFar = 0x4D4;
                public const long m_bActive = 0x4C4;
                public const long m_flZNear = 0x4D8;
                public const long m_FogColor = 0x4B4;
                public const long m_flFogEnd = 0x4BC;
                public const long m_TargetFOV = 0x4F4;
                public const long m_Resolution = 0x4AC;
                public const long m_bFogEnable = 0x4B0;
                public const long m_flFogStart = 0x4B8;
                public const long m_bCanHLTVUse = 0x4DC;
                public const long m_bDofEnabled = 0x4DE;
                public const long m_fBrightness = 0x4D0;
                public const long m_flAspectRatio = 0x4C8;
                public const long m_flDofFarCrisp = 0x4E8;
                public const long m_flDofFarBlurry = 0x4EC;
                public const long m_flDofNearCrisp = 0x4E4;
                public const long m_flDofNearBlurry = 0x4E0;
                public const long m_flFogMaxDensity = 0x4C0;
                public const long m_DegreesPerSecond = 0x4F8;
                public const long m_bAlignWithParent = 0x4DD;
                public const long m_flDofTiltToGround = 0x4F0;
                public const long m_bUseScreenAspectRatio = 0x4C5;
            }
            public static partial class CPointEntity {

            }
            public static partial class CPointOrient {
                public const long m_bActive = 0x4B4;
                public const long m_hTarget = 0x4B0;
                public const long m_nConstraint = 0x4BC;
                public const long m_flMaxTurnRate = 0x4C0;
                public const long m_flLastGameTime = 0x4C4;
                public const long m_nGoalDirection = 0x4B8;
                public const long m_iszSpawnTargetName = 0x4A8;
            }
            public static partial class CPointPrefab {
                public const long m_fixupNames = 0x4C0;
                public const long m_bLoadDynamic = 0x4C1;
                public const long m_targetMapName = 0x4A8;
                public const long m_forceWorldGroupID = 0x4B0;
                public const long m_associatedRelayEntity = 0x4C4;
                public const long m_ProceduralRelaySources = 0x4C8;
                public const long m_associatedRelayTargetName = 0x4B8;
            }
            public static partial class CRR_Response {
                public const long m_Type = 0x0;
                public const long m_Params = 0x160;
                public const long m_Followup = 0x198;
                public const long m_fMatchScore = 0x180;
                public const long m_szMatchingRule = 0xC1;
                public const long m_szResponseName = 0x1;
                public const long m_szWorldContext = 0x190;
                public const long m_recipientFilter = 0x1B4;
                public const long m_szSpeakerContext = 0x188;
                public const long m_bAnyMatchingRulesInCooldown = 0x184;
            }
            public static partial class CRagdollProp {
                public const long m_ragPos = 0xB08;
                public const long m_hKiller = 0xB4C;
                public const long m_ragdoll = 0xA90;
                public const long m_allAsleep = 0xB3C;
                public const long m_massScale = 0xAE4;
                public const long m_ragAngles = 0xB20;
                public const long m_flFadeTime = 0xB5C;
                public const long m_ragEnabled = 0xAF0;
                public const long m_flAwakeTime = 0xB6C;
                public const long m_ragdollMaxs = 0xBB0;
                public const long m_ragdollMins = 0xB98;
                public const long m_bAllowStretch = 0xB89;
                public const long m_buoyancyScale = 0xAE8;
                public const long m_flBlendWeight = 0xB8C;
                public const long m_hDamageEntity = 0xB48;
                public const long m_vecLastOrigin = 0xB60;
                public const long m_bStartDisabled = 0xAE0;
                public const long m_vecNavObstacles = 0xBE0;
                public const long m_hPhysicsAttacker = 0xB50;
                public const long m_nNavObstacleType = 0xB40;
                public const long m_CPropDataComponent = 0xA50;
                public const long m_bHasBeenPhysgunned = 0xB88;
                public const long m_flDefaultFadeScale = 0xB90;
                public const long m_flFadeOutStartTime = 0xB58;
                public const long m_strOriginClassName = 0xB78;
                public const long m_strSourceClassName = 0xB80;
                public const long m_lastUpdateTickCount = 0xB38;
                public const long m_bForceNavObstacleCut = 0xB45;
                public const long m_bUpdateNavWhenMoving = 0xB44;
                public const long m_flLastOriginChangeTime = 0xB70;
                public const long m_bAttachedToReferenceFrame = 0xB46;
                public const long m_bFirstCollisionAfterLaunch = 0xB3D;
                public const long m_flLastPhysicsInfluenceTime = 0xB54;
                public const long m_bShouldDeleteActivationRecord = 0xBC8;
            }
            public static partial class CRevertSaved {
                public const long m_Duration = 0x854;
                public const long m_HoldTime = 0x858;
                public const long m_loadTime = 0x850;
            }
            public static partial class CSceneEntity {
                public const long m_fPitch = 0x53C;
                public const long m_hActor = 0x7E8;
                public const long m_OnStart = 0x5C8;
                public const long m_bPaused = 0x529;
                public const long m_ActorMap = 0x770;
                public const long m_OnPaused = 0x610;
                public const long m_hTarget1 = 0x4F8;
                public const long m_hTarget2 = 0x4FC;
                public const long m_hTarget3 = 0x500;
                public const long m_hTarget4 = 0x504;
                public const long m_hTarget5 = 0x508;
                public const long m_hTarget6 = 0x50C;
                public const long m_hTarget7 = 0x510;
                public const long m_hTarget8 = 0x514;
                public const long m_BusyActor = 0x7F0;
                public const long m_OnResumed = 0x628;
                public const long m_OnCanceled = 0x5F8;
                public const long m_bAutomated = 0x540;
                public const long m_bRestoring = 0x7A4;
                public const long m_hActivator = 0x7EC;
                public const long m_hActorList = 0x560;
                public const long m_iszTarget1 = 0x4B8;
                public const long m_iszTarget2 = 0x4C0;
                public const long m_iszTarget3 = 0x4C8;
                public const long m_iszTarget4 = 0x4D0;
                public const long m_iszTarget5 = 0x4D8;
                public const long m_iszTarget6 = 0x4E0;
                public const long m_iszTarget7 = 0x4E8;
                public const long m_iszTarget8 = 0x4F0;
                public const long m_flFrameTime = 0x534;
                public const long m_ActorClipMap = 0x748;
                public const long m_OnCompletion = 0x5E0;
                public const long m_bInterrupted = 0x7A1;
                public const long m_bMultiplayer = 0x52A;
                public const long m_iszSceneFile = 0x4B0;
                public const long m_iszSoundName = 0x7D8;
                public const long m_ActorGraphMap = 0x720;
                public const long m_AnchorNameMap = 0x6F8;
                public const long m_TargetNameMap = 0x6D0;
                public const long m_bSceneMissing = 0x7A0;
                public const long m_flCurrentTime = 0x530;
                public const long m_hListManagers = 0x7C0;
                public const long m_bAutogenerated = 0x52B;
                public const long m_bIsPlayingBack = 0x528;
                public const long m_bSceneFinished = 0x55A;
                public const long m_hLocatorOrigin = 0x518;
                public const long m_bBreakOnNonIdle = 0x559;
                public const long m_bCompletedEarly = 0x7A2;
                public const long m_bPausedViaInput = 0x554;
                public const long m_hInterruptScene = 0x788;
                public const long m_iszSequenceName = 0x7E0;
                public const long m_nInterruptCount = 0x78C;
                public const long m_nSpeechPriority = 0x550;
                public const long m_responseConcept = 0x790;
                public const long m_bWaitingForActor = 0x556;
                public const long m_flAutomationTime = 0x54C;
                public const long m_hRemoveActorList = 0x578;
                public const long m_nAutomatedAction = 0x544;
                public const long m_responseCriteria = 0x798;
                public const long m_flAutomationDelay = 0x548;
                public const long m_flForceClientTime = 0x52C;
                public const long m_nSceneStringIndex = 0x5C0;
                public const long m_sTargetAttachment = 0x520;
                public const long m_OnPulseRequirement = 0x640;
                public const long m_bRemoveOnCompletion = 0x539;
                public const long m_bWaitingForInterrupt = 0x557;
                public const long m_iPlayerDeathBehavior = 0x7F4;
                public const long m_bPauseAtNextInterrupt = 0x555;
                public const long m_bCancelAtNextInterrupt = 0x538;
                public const long m_hNotifySceneCompletion = 0x7A8;
                public const long m_bInterruptSceneFinished = 0x7A3;
                public const long m_bInterruptedActorsScenes = 0x558;
            }
            public static partial class CSkillDamage {
                public const long m_flDamage = 0x0;
                public const long m_flPhysicsForceDamage = 0x14;
                public const long m_flNPCDamageScalarVsNPC = 0x10;
            }
            public static partial class CTankTrainAI {
                public const long m_hTrain = 0x4A8;
                public const long m_soundPlaying = 0x4B0;
                public const long m_hTargetEntity = 0x4AC;
                public const long m_startSoundName = 0x4C8;
                public const long m_engineSoundName = 0x4D0;
                public const long m_targetEntityName = 0x4E0;
                public const long m_movementSoundName = 0x4D8;
            }
            public static partial class CTestPulseIO {
                public const long m_OnVariantInt = 0x4E0;
                public const long m_OnVariantBool = 0x4C0;
                public const long m_OnVariantVoid = 0x4A8;
                public const long m_TestComponent = 0x590;
                public const long m_OnVariantColor = 0x540;
                public const long m_OnVariantFloat = 0x500;
                public const long m_OnVariantString = 0x520;
                public const long m_OnVariantVector = 0x560;
                public const long m_OnInternalTestInt = 0x5F8;
                public const long m_bAllowEmptyInputs = 0x588;
                public const long m_OnInternalTestBool = 0x5D8;
                public const long m_OnInternalTestVoid = 0x5C0;
                public const long m_OnInternalTestColor = 0x658;
                public const long m_OnInternalTestFloat = 0x618;
                public const long m_OnInternalTestString = 0x638;
                public const long m_OnInternalTestVector = 0x678;
                public const long m_OnInternalTestEntityName = 0x6A0;
                public const long m_OnInternalTestSchemaEnum = 0x6E0;
                public const long m_OnInternalTestFloatString = 0x700;
                public const long m_OnInternalTestEntityHandle = 0x6C0;
                public const long m_OnInternalTestEntityHandleInt = 0x750;
                public const long m_OnInternalTestEntityNameString = 0x728;
                public const long m_OnInternalTestStringStringString = 0x770;
            }
            public static partial class CTimerEntity {
                public const long m_OnTimer = 0x4A8;
                public const long m_bPaused = 0x514;
                public const long m_iDisabled = 0x4F0;
                public const long m_OnTimerLow = 0x4D8;
                public const long m_OnTimerHigh = 0x4C0;
                public const long m_bUpDownState = 0x4FC;
                public const long m_flRefireTime = 0x4F8;
                public const long m_flInitialDelay = 0x4F4;
                public const long m_iUseRandomTime = 0x500;
                public const long m_flRemainingTime = 0x510;
                public const long m_bPauseAfterFiring = 0x504;
                public const long m_flLowerRandomBound = 0x508;
                public const long m_flUpperRandomBound = 0x50C;
            }
            public static partial class CTriggerHurt {
                public const long m_OnHurt = 0xA00;
                public const long m_flDamage = 0x9CC;
                public const long m_bNoDmgForce = 0x9E4;
                public const long m_damageModel = 0x9E0;
                public const long m_flDamageCap = 0x9D0;
                public const long m_thinkAlways = 0x9F4;
                public const long m_OnHurtPlayer = 0xA18;
                public const long m_hurtEntities = 0xA30;
                public const long m_vDamageForce = 0x9E8;
                public const long m_flLastDmgTime = 0x9D4;
                public const long m_hurtThinkPeriod = 0x9F8;
                public const long m_flOriginalDamage = 0x9C8;
                public const long m_bitsDamageInflict = 0x9DC;
                public const long m_flForgivenessDelay = 0x9D8;
            }
            public static partial class CTriggerLook {
                public const long m_b2DFOV = 0x9FA;
                public const long m_OnEndLook = 0xA30;
                public const long m_OnTimeout = 0xA00;
                public const long m_bIsLooking = 0x9F9;
                public const long m_flLookTime = 0x9E8;
                public const long m_OnStartLook = 0xA18;
                public const long m_hLookTarget = 0x9E0;
                public const long m_bUseVelocity = 0x9FB;
                public const long m_bTimeoutFired = 0x9F8;
                public const long m_flFieldOfView = 0x9E4;
                public const long m_bTestOcclusion = 0x9FC;
                public const long m_flLookTimeLast = 0x9F0;
                public const long m_flLookTimeTotal = 0x9EC;
                public const long m_flTimeoutDuration = 0x9F4;
                public const long m_bTestAllVisibleOcclusion = 0x9FD;
            }
            public static partial class CTriggerOnce {

            }
            public static partial class CTriggerPush {
                public const long m_flSpeed = 0x9F8;
                public const long m_PathSimple = 0x9F0;
                public const long m_bUsePathSimple = 0x9E1;
                public const long m_splinePushType = 0x9F4;
                public const long m_iszPathSimpleName = 0x9E8;
                public const long m_angPushEntitySpace = 0x9C8;
                public const long m_bTriggerOnStartTouch = 0x9E0;
                public const long m_vecPushDirEntitySpace = 0x9D4;
            }
            public static partial class CTriggerSave {
                public const long m_minHitPoints = 0x9D0;
                public const long m_fDangerousTimer = 0x9CC;
                public const long m_flRetriggerDelay = 0x9D4;
                public const long m_bForceNewLevelUnit = 0x9C8;
            }
            public static partial class CWaterBullet {

            }
            public static partial class CWeaponBizon {

            }
            public static partial class CWeaponCZ75a {
                public const long m_bMagazineRemoved = 0x12A0;
            }
            public static partial class CWeaponElite {

            }
            public static partial class CWeaponFamas {

            }
            public static partial class CWeaponG3SG1 {

            }
            public static partial class CWeaponGlock {

            }
            public static partial class CWeaponMAC10 {

            }
            public static partial class CWeaponMP5SD {

            }
            public static partial class CWeaponNegev {

            }
            public static partial class CWeaponSG556 {

            }
            public static partial class CWeaponSSG08 {

            }
            public static partial class CWeaponTaser {
                public const long m_fFireTime = 0x12A0;
                public const long m_nLastAttackTick = 0x12A4;
            }
            public static partial class CWeaponUMP45 {

            }
            public static partial class FilterHealth {
                public const long m_iHealthMax = 0x4E8;
                public const long m_iHealthMin = 0x4E4;
                public const long m_bAdrenalineActive = 0x4E0;
            }
            public static partial class INavObstacle {
                public const long m_nId = 0x8;
            }
            public static partial class INavPathCost {
                public const long m_navHull = 0x8;
            }
            public static partial class NavGravity_t {
                public const long m_bDefault = 0xC;
                public const long m_vGravity = 0x0;
            }
            public static partial class CAI_Expresser {
                public const long m_pOuter = 0x98;
                public const long m_voicePitch = 0x70;
                public const long m_ruleCooldowns = 0x38;
                public const long m_flStopTalkTime = 0x60;
                public const long m_conceptCooldowns = 0x10;
                public const long m_flBlockedTalkTime = 0x6C;
                public const long m_flQueuedSpeechTime = 0x68;
                public const long m_nLastSpokenPriority = 0x7C;
                public const long m_bSceneEntityDisabled = 0x7A;
                public const long m_flLastTimeAcceptedSpeak = 0x74;
                public const long m_bAllowSpeakingInterrupts = 0x78;
                public const long m_flStopTalkTimeWithoutDelay = 0x64;
                public const long m_bConsiderSceneInvolvementAsSpeech = 0x79;
            }
            public static partial class CBasePropDoor {
                public const long m_ls = 0xCF0;
                public const long m_OnOpen = 0xE48;
                public const long m_OnClose = 0xE30;
                public const long m_bLocked = 0xCCC;
                public const long m_bNoNPCs = 0xCCD;
                public const long m_flSpeed = 0xD24;
                public const long m_hMaster = 0xD98;
                public const long m_hBlocker = 0xCE8;
                public const long m_SlaveName = 0xD90;
                public const long m_SoundLock = 0xD58;
                public const long m_SoundOpen = 0xD48;
                public const long m_hDoorList = 0xCA8;
                public const long m_OnAjarOpen = 0xE78;
                public const long m_SoundClose = 0xD50;
                public const long m_SoundLatch = 0xD68;
                public const long m_SoundPound = 0xD70;
                public const long m_eDoorState = 0xCC8;
                public const long m_hActivator = 0xD20;
                public const long m_OnFullyOpen = 0xE18;
                public const long m_OnLockedUse = 0xE60;
                public const long m_SoundJiggle = 0xD78;
                public const long m_SoundMoving = 0xD40;
                public const long m_SoundUnlock = 0xD60;
                public const long m_bForceClosed = 0xD10;
                public const long m_closedAngles = 0xCDC;
                public const long m_OnFullyClosed = 0xE00;
                public const long m_bFirstBlocked = 0xCEC;
                public const long m_nHardwareType = 0xCC0;
                public const long m_bNeedsHardware = 0xCC4;
                public const long m_closedPosition = 0xCD0;
                public const long m_SoundLockedAnim = 0xD80;
                public const long m_OnBlockedClosing = 0xDA0;
                public const long m_OnBlockedOpening = 0xDB8;
                public const long m_nPhysicsMaterial = 0xD8C;
                public const long m_numCloseAttempts = 0xD88;
                public const long m_flAutoReturnDelay = 0xCA0;
                public const long m_OnUnblockedClosing = 0xDD0;
                public const long m_OnUnblockedOpening = 0xDE8;
                public const long m_vecLatchWorldPosition = 0xD14;
            }
            public static partial class CCSPlayerPawn {
                public const long m_pBot = 0x1510;
                public const long m_bIsScoped = 0x14CC;
                public const long m_ArmorValue = 0x1524;
                public const long m_EconGloves = 0x1058;
                public const long m_LastHitBox = 0x150C;
                public const long m_bInBuyZone = 0xF61;
                public const long m_bIsWalking = 0x1488;
                public const long m_nSpotRules = 0x14C8;
                public const long m_bInBombZone = 0xF82;
                public const long m_bIsDefusing = 0x14CE;
                public const long m_bIsSpawning = 0x1534;
                public const long m_bLeftHanded = 0x1470;
                public const long m_bResumeZoom = 0x14CD;
                public const long m_iDeathFlags = 0x1540;
                public const long m_iShotsFired = 0x14E8;
                public const long m_strVOPrefix = 0xE68;
                public const long m_angEyeAngles = 0x15C0;
                public const long m_lastLandTime = 0xFD8;
                public const long m_pBuyServices = 0xE38;
                public const long m_bHasDeathInfo = 0x1544;
                public const long m_bWasInBuyZone = 0xF80;
                public const long m_flFlinchStack = 0x14EC;
                public const long m_iPlayerLocked = 0xFE0;
                public const long m_bIsBuyMenuOpen = 0xFA0;
                public const long m_flViewmodelFOV = 0x1484;
                public const long m_iBombSiteIndex = 0x14DC;
                public const long m_nWhichBombZone = 0x14E0;
                public const long m_pRadioServices = 0xE50;
                public const long m_bBotAllowActive = 0x1518;
                public const long m_bHasFemaleVoice = 0xE62;
                public const long m_bInNoDefuseArea = 0x14D8;
                public const long m_flDeathInfoTime = 0x1548;
                public const long m_flEmitSoundTime = 0x14D4;
                public const long m_pBulletServices = 0xE28;
                public const long m_qDeathEyeAngles = 0x1464;
                public const long m_szLastPlaceName = 0xE70;
                public const long m_TouchingBuyZones = 0xF68;
                public const long m_bGunGameImmunity = 0x15B8;
                public const long m_bWaitForNoAttack = 0x1500;
                public const long m_iRetakesOffering = 0xF84;
                public const long m_nLastKillerIndex = 0x14A8;
                public const long m_pHostageServices = 0xE30;
                public const long m_bKilledByHeadshot = 0x1508;
                public const long m_bOnGroundLastTick = 0xFDC;
                public const long m_pAimPunchServices = 0xE48;
                public const long m_bInBombZoneTrigger = 0x14E4;
                public const long m_bIsGrabbingHostage = 0x14CF;
                public const long m_entitySpottedState = 0x14B0;
                public const long m_fLastGivenBombTime = 0x1490;
                public const long m_fMolotovDamageTime = 0x15BC;
                public const long m_flTimeOfLastInjury = 0xFE8;
                public const long m_flVelocityModifier = 0x14F0;
                public const long m_flViewmodelOffsetX = 0x1478;
                public const long m_flViewmodelOffsetY = 0x147C;
                public const long m_flViewmodelOffsetZ = 0x1480;
                public const long m_nCharacterDefIndex = 0xE60;
                public const long m_nEconGlovesChanged = 0x1440;
                public const long m_nRagdollDamageBone = 0xFF4;
                public const long m_vecDeathInfoOrigin = 0x154C;
                public const long m_vecStashedVelocity = 0x159C;
                public const long m_allowAutoFollowTime = 0x14A0;
                public const long m_bInHostageResetZone = 0xF60;
                public const long m_iDisplayHistoryBits = 0x1498;
                public const long m_nLastPickupPriority = 0x151C;
                public const long m_vRagdollDamageForce = 0xFF8;
                public const long m_vecTotalBulletForce = 0x14F4;
                public const long m_GunGameImmunityColor = 0x156C;
                public const long m_bInHostageRescueZone = 0xF81;
                public const long m_bResetArmorNextSpawn = 0x14A4;
                public const long m_bRetakesHasDefuseKit = 0xF8C;
                public const long m_bRetakesMVPLastRound = 0xF8D;
                public const long m_flLandingTimeSeconds = 0xF9C;
                public const long m_flNextSprayDecalTime = 0xFEC;
                public const long m_hActiveMinimapVolume = 0x1460;
                public const long m_iRetakesMVPBoostItem = 0xF90;
                public const long m_iRetakesOfferingCard = 0xF88;
                public const long m_ignoreLadderJumpTime = 0x1504;
                public const long m_pDamageReactServices = 0xE58;
                public const long m_vRagdollServerOrigin = 0x1048;
                public const long m_angStashedShootAngles = 0x1578;
                public const long m_bWasInBombZoneTrigger = 0x14E5;
                public const long m_fLastGivenDefuserTime = 0x148C;
                public const long m_wasNotKilledNaturally = 0x15B1;
                public const long m_bRagdollDamageHeadshot = 0x1044;
                public const long m_flLastAttackedTeammate = 0x149C;
                public const long m_iLastWeaponFireUsercmd = 0x1530;
                public const long m_bWasInHostageRescueZone = 0xF83;
                public const long m_fSwitchedHandednessTime = 0x1474;
                public const long m_pActionTrackingServices = 0xE40;
                public const long m_unCurrentEquipmentValue = 0x1528;
                public const long m_flLastPickupPriorityTime = 0x1520;
                public const long m_vecCurrentMinimapVolumes = 0x1448;
                public const long m_bGrenadeParametersStashed = 0x1574;
                public const long m_grenadeParameterStashTime = 0x1570;
                public const long m_szRagdollDamageWeaponName = 0x1004;
                public const long m_vecPlayerPatchEconIndices = 0x1558;
                public const long m_fImmuneToGunGameDamageTime = 0x15B4;
                public const long m_unRoundStartEquipmentValue = 0x152A;
                public const long m_RetakesMVPBoostExtraUtility = 0xF94;
                public const long m_bNextSprayDecalTimeExpedited = 0xFF0;
                public const long m_iBlockingUseActionInProgress = 0x14D0;
                public const long m_unFreezetimeEndEquipmentValue = 0x152C;
                public const long m_bCommittingSuicideOnTeamChange = 0x15B0;
                public const long m_vecStashedGrenadeThrowPosition = 0x1584;
                public const long m_flHealthShotBoostExpirationTime = 0xF98;
                public const long m_vecStashedGrenadeThrowPawnCenter = 0x1590;
                public const long m_flDealtDamageToEnemyMostRecentTimestamp = 0x1494;
            }
            public static partial class CCSWeaponBase {
                public const long m_donated = 0x1034;
                public const long m_bInReload = 0xFA8;
                public const long m_bStealthy = 0xFC4;
                public const long m_nDropTick = 0x1010;
                public const long m_bBurstMode = 0xF9C;
                public const long m_hPrevOwner = 0x100C;
                public const long m_weaponMode = 0xF70;
                public const long m_bRemoveable = 0xEF8;
                public const long m_bSilencerOn = 0xFBD;
                public const long m_nDeployTick = 0xFAC;
                public const long m_bFireOnEmpty = 0xF50;
                public const long m_iRecoilIndex = 0xF94;
                public const long m_bIsHauledBack = 0xFBC;
                public const long m_bWasOwnedByCT = 0x103C;
                public const long m_fLastShotTime = 0x1038;
                public const long m_flRecoilIndex = 0xF98;
                public const long m_OnPlayerPickup = 0xF58;
                public const long m_bCanBePickedUp = 0xFF8;
                public const long m_iIronSightMode = 0x10B8;
                public const long m_bInspectPending = 0xF08;
                public const long m_flDroppedAtTime = 0xFB4;
                public const long m_flLastShakeTime = 0x10D0;
                public const long m_flWatTickOffset = 0x10C0;
                public const long m_fAccuracyPenalty = 0xF88;
                public const long m_bInspectShouldLoop = 0xF09;
                public const long m_bRequireUseToTouch = 0xEFA;
                public const long m_nextOwnerTouchTime = 0xFFC;
                public const long m_IronSightController = 0x10A0;
                public const long m_bDroppedNearBuyZone = 0xFDC;
                public const long m_flTurningInaccuracy = 0xF84;
                public const long m_iOriginalTeamNumber = 0xFD4;
                public const long m_bWasOwnedByTerrorist = 0x103D;
                public const long m_nextPrevOwnerUseTime = 0x1008;
                public const long m_bReloadHeldSinceStart = 0xFCC;
                public const long m_flAttackHoldStartTime = 0xFB0;
                public const long m_iMostRecentTeamNumber = 0xFD8;
                public const long m_nLastEmptySoundCmdNum = 0xF34;
                public const long m_bInSilentReloadSection = 0xFC5;
                public const long m_flStealthHoldStartTime = 0xFC8;
                public const long m_nextPrevOwnerTouchTime = 0x1000;
                public const long m_flPostponeFireReadyFrac = 0xFA4;
                public const long m_nPostponeFireReadyTicks = 0xFA0;
                public const long m_bPlayerAmmoStockOnPickup = 0xEF9;
                public const long m_bSilentReloadStatCounted = 0xFC6;
                public const long m_bSilentReloadStatPending = 0xFC7;
                public const long m_fAccuracySmoothedForZoom = 0xF90;
                public const long m_flLastAccuracyUpdateTime = 0xF8C;
                public const long m_flTurningInaccuracyDelta = 0xF74;
                public const long m_iWeaponGameplayAnimState = 0xEFC;
                public const long m_flLastLOSTraceFailureTime = 0x10BC;
                public const long m_flWeaponActionPlaybackRate = 0xFD0;
                public const long m_bWasActiveWeaponWhenDropped = 0x1014;
                public const long m_flInspectCancelCompleteTime = 0xF04;
                public const long m_numRemoveUnownedWeaponThink = 0x1040;
                public const long m_flNextAttackRenderTimeOffset = 0xFE0;
                public const long m_flTimeSilencerSwitchComplete = 0xFC0;
                public const long m_vecTurningInaccuracyEyeDirLast = 0xF78;
                public const long m_bUseCanOverrideNextOwnerTouchTime = 0xFF9;
                public const long m_flWeaponGameplayAnimStateTimestamp = 0xF00;
            }
            public static partial class CDamageRecord {
                public const long m_flDamage = 0x64;
                public const long m_iNumHits = 0x6C;
                public const long m_killType = 0x75;
                public const long m_DamagerXuid = 0x50;
                public const long m_PlayerDamager = 0x30;
                public const long m_RecipientXuid = 0x58;
                public const long m_bIsOtherEnemy = 0x74;
                public const long m_PlayerRecipient = 0x34;
                public const long m_flBulletsDamage = 0x60;
                public const long m_iLastBulletUpdate = 0x70;
                public const long m_szPlayerDamagerName = 0x40;
                public const long m_flActualHealthRemoved = 0x68;
                public const long m_szPlayerRecipientName = 0x48;
                public const long m_hPlayerControllerDamager = 0x38;
                public const long m_hPlayerControllerRecipient = 0x3C;
            }
            public static partial class CDebugHistory {
                public const long m_nNpcEvents = 0x3E84E8;
            }
            public static partial class CDecoyGrenade {

            }
            public static partial class CDynamicLight {
                public const long m_On = 0x853;
                public const long m_Flags = 0x851;
                public const long m_Radius = 0x854;
                public const long m_Exponent = 0x858;
                public const long m_InnerAngle = 0x85C;
                public const long m_LightStyle = 0x852;
                public const long m_OuterAngle = 0x860;
                public const long m_SpotRadius = 0x864;
                public const long m_ActualFlags = 0x850;
            }
            public static partial class CEconItemView {
                public const long m_iItemID = 0x48;
                public const long m_iAccountID = 0x58;
                public const long m_iItemIDLow = 0x54;
                public const long m_iItemIDHigh = 0x50;
                public const long m_bInitialized = 0x68;
                public const long m_iEntityLevel = 0x40;
                public const long m_szCustomName = 0x160;
                public const long m_AttributeList = 0x70;
                public const long m_iEntityQuality = 0x3C;
                public const long m_iInventoryPosition = 0x5C;
                public const long m_iItemDefinitionIndex = 0x38;
                public const long m_szCustomNameOverride = 0x201;
                public const long m_szCustomNameOverride2 = 0x2A2;
                public const long m_szCustomNameOverride3 = 0x343;
                public const long m_NetworkedDynamicAttributes = 0xE8;
            }
            public static partial class CEconWearable {
                public const long m_nForceSkin = 0xEB0;
                public const long m_bAlwaysAllow = 0xEB4;
            }
            public static partial class CEnvExplosion {
                public const long m_hInflictor = 0x864;
                public const long m_iMagnitude = 0x850;
                public const long m_iClassIgnore = 0x88C;
                public const long m_bCreateDebris = 0x86D;
                public const long m_flDamageForce = 0x860;
                public const long m_flInnerRadius = 0x85C;
                public const long m_hEntityIgnore = 0x8A0;
                public const long m_iClassIgnore2 = 0x890;
                public const long m_flPlayerDamage = 0x854;
                public const long m_iRadiusOverride = 0x858;
                public const long m_iCustomDamageType = 0x868;
                public const long m_iszCustomSoundName = 0x880;
                public const long m_iszCustomEffectName = 0x878;
                public const long m_iszEntityIgnoreName = 0x898;
                public const long m_bHasCustomDamageType = 0x86C;
                public const long m_bSuppressParticleImpulse = 0x888;
            }
            public static partial class CEnvViewPunch {
                public const long m_flRadius = 0x4A8;
                public const long m_angViewPunch = 0x4AC;
            }
            public static partial class CFuncConveyor {
                public const long m_flSpeed = 0x85C;
                public const long m_flTargetSpeed = 0x878;
                public const long m_flFrictionScale = 0x888;
                public const long m_hConveyorModels = 0x890;
                public const long m_szConveyorModels = 0x850;
                public const long m_angMoveEntitySpace = 0x860;
                public const long m_nTransitionStartTick = 0x87C;
                public const long m_vecMoveDirEntitySpace = 0x86C;
                public const long m_flTransitionStartSpeed = 0x884;
                public const long m_nTransitionDurationTicks = 0x880;
                public const long m_flTransitionDurationSeconds = 0x858;
            }
            public static partial class CFuncRotating {
                public const long m_flSpeed = 0x8A4;
                public const long m_angStart = 0x8EC;
                public const long m_flVolume = 0x8B0;
                public const long m_OnStarted = 0x868;
                public const long m_OnStopped = 0x850;
                public const long m_bReversed = 0x8C8;
                public const long m_flMaxSpeed = 0x8B8;
                public const long m_bAccelDecel = 0x8C9;
                public const long m_NoiseRunning = 0x8C0;
                public const long m_flAttenuation = 0x8AC;
                public const long m_flBlockDamage = 0x8BC;
                public const long m_flFanFriction = 0x8A8;
                public const long m_flTargetSpeed = 0x8B4;
                public const long m_OnReachedStart = 0x880;
                public const long m_bStopAtStartPos = 0x8F8;
                public const long m_prevLocalAngles = 0x8E0;
                public const long m_vecClientAngles = 0x908;
                public const long m_vecClientOrigin = 0x8FC;
                public const long m_localRotationVector = 0x898;
            }
            public static partial class CGlowProperty {
                public const long m_bGlowing = 0x51;
                public const long m_bFlashing = 0x44;
                public const long m_iGlowTeam = 0x34;
                public const long m_iGlowType = 0x30;
                public const long m_fGlowColor = 0x8;
                public const long m_flGlowTime = 0x48;
                public const long m_nGlowRange = 0x38;
                public const long m_nGlowRangeMin = 0x3C;
                public const long m_flGlowStartTime = 0x4C;
                public const long m_glowColorOverride = 0x40;
                public const long m_bEligibleForScreenHighlight = 0x50;
            }
            public static partial class CInfoLandmark {

            }
            public static partial class CLogicCompare {
                public const long m_OnEqualTo = 0x4D0;
                public const long m_flInValue = 0x4A8;
                public const long m_OnLessThan = 0x4B0;
                public const long m_OnNotEqualTo = 0x4F0;
                public const long m_OnGreaterThan = 0x510;
                public const long m_flCompareValue = 0x4AC;
            }
            public static partial class CMarkupVolume {
                public const long m_bDisabled = 0x850;
            }
            public static partial class CNavAttribute {

            }
            public static partial class CNavHullVData {
                public const long m_agentHeight = 0x8;
                public const long m_agentRadius = 0x4;
                public const long m_agentMaxClimb = 0x1C;
                public const long m_agentMaxSlope = 0x20;
                public const long m_bAgentEnabled = 0x0;
                public const long m_agentCrawlHeight = 0x18;
                public const long m_agentShortHeight = 0x10;
                public const long m_agentCrawlEnabled = 0x14;
                public const long m_agentBorderErosion = 0x30;
                public const long m_agentMaxJumpUpDist = 0x2C;
                public const long m_agentMaxJumpDownDist = 0x24;
                public const long m_flowMapNodeMaxRadius = 0x38;
                public const long m_agentShortHeightEnabled = 0xC;
                public const long m_flowMapGenerationEnabled = 0x34;
                public const long m_agentMaxJumpHorizDistBase = 0x28;
            }
            public static partial class CNavSpaceInfo {

            }
            public static partial class CNavVolumeAll {

            }
            public static partial class COrnamentProp {
                public const long m_initialOwner = 0xC90;
            }
            public static partial class CPathKeyFrame {
                public const long m_Angles = 0x4B4;
                public const long m_Origin = 0x4A8;
                public const long m_qAngle = 0x4C0;
                public const long m_iNextKey = 0x4D0;
                public const long m_pNextKey = 0x4DC;
                public const long m_pPrevKey = 0x4E0;
                public const long m_flNextTime = 0x4D8;
                public const long m_flMoveSpeed = 0x4E4;
            }
            public static partial class CPhysThruster {
                public const long m_localOrigin = 0x508;
            }
            public static partial class CPhysicsShake {
                public const long m_force = 0x8;
            }
            public static partial class CRandSimTimer {
                public const long m_flMaxInterval = 0xC;
                public const long m_flMinInterval = 0x8;
            }
            public static partial class CRopeKeyframe {
                public const long m_Slack = 0x868;
                public const long m_Width = 0x86C;
                public const long m_Subdiv = 0x888;
                public const long m_RopeFlags = 0x858;
                public const long m_hEndPoint = 0x89C;
                public const long m_nSegments = 0x874;
                public const long m_RopeLength = 0x88A;
                public const long m_hStartPoint = 0x898;
                public const long m_TextureScale = 0x870;
                public const long m_nChangeCount = 0x889;
                public const long m_fLockedPoints = 0x88C;
                public const long m_flScrollSpeed = 0x890;
                public const long m_iNextLinkName = 0x860;
                public const long m_bEndPointValid = 0x895;
                public const long m_iEndAttachment = 0x8A1;
                public const long m_bStartPointValid = 0x894;
                public const long m_iStartAttachment = 0x8A0;
                public const long m_bCreatedFromMapFile = 0x88D;
                public const long m_strRopeMaterialModel = 0x878;
                public const long m_iRopeMaterialModelIndex = 0x880;
                public const long m_bConstrainBetweenEndpoints = 0x875;
            }
            public static partial class CSmokeGrenade {

            }
            public static partial class CSpotlightEnd {
                public const long m_Radius = 0x854;
                public const long m_flLightScale = 0x850;
                public const long m_vSpotlightDir = 0x858;
                public const long m_vSpotlightOrg = 0x864;
            }
            public static partial class CTriggerBrush {
                public const long m_OnUse = 0x880;
                public const long m_OnEndTouch = 0x868;
                public const long m_OnStartTouch = 0x850;
                public const long m_iInputFilter = 0x898;
                public const long m_iDontMessageParent = 0x89C;
            }
            public static partial class CWeaponSCAR20 {

            }
            public static partial class CWeaponXM1014 {

            }
            public static partial class CodeGenAABB_t {
                public const long m_vMaxBounds = 0xC;
                public const long m_vMinBounds = 0x0;
            }
            public static partial class IntervalTimer {
                public const long m_timestamp = 0x8;
                public const long m_nWorldGroupId = 0xC;
            }
            public static partial class QuestProgress {

            }
            public static partial class audioparams_t {
                public const long localBits = 0x6C;
                public const long localSound = 0x8;
                public const long soundEventHash = 0x74;
                public const long soundscapeIndex = 0x68;
                public const long soundscapeEntityListIndex = 0x70;
            }
            public static partial class dynpitchvol_t {

            }
            public static partial class entitytable_t {
                public const long id = 0x0;
                public const long flags = 0x18;
                public const long bWasSaved = 0x14;
                public const long classname = 0x20;
                public const long edictindex = 0x4;
                public const long entityname = 0x30;
                public const long globalname = 0x28;
                public const long saveentityindex = 0x8;
                public const long landmarkModelSpace = 0x38;
                public const long m_pPrecacheEntityKeys = 0x48;
            }
            public static partial class sky3dparams_t {
                public const long fog = 0x20;
                public const long scale = 0x8;
                public const long origin = 0xC;
                public const long m_nWorldGroupID = 0x88;
                public const long bClip3DSkyBoxNearToWorldFar = 0x18;
                public const long flClip3DSkyBoxNearToWorldFarOffset = 0x1C;
            }
            public static partial class ActorMapping_t {
                public const long m_hEntity = 0x8;
                public const long m_sActorName = 0x0;
            }
            public static partial class AmmoTypeInfo_t {
                public const long m_flMass = 0x28;
                public const long m_nFlags = 0x24;
                public const long m_flSpeed = 0x2C;
                public const long m_nMaxCarry = 0x10;
                public const long m_nSplashSize = 0x1C;
            }
            public static partial class CAttributeList {
                public const long m_pManager = 0x70;
                public const long m_Attributes = 0x8;
            }
            public static partial class CBaseAnimGraph {
                public const long m_vecForce = 0x93C;
                public const long m_nForceBone = 0x948;
                public const long m_RagdollPose = 0x960;
                public const long m_bRagdollEnabled = 0x988;
                public const long m_pChoreoServices = 0x930;
                public const long m_pRagdollControl = 0x958;
                public const long m_bRagdollClientSide = 0x989;
                public const long m_OnLayerCycleUpdated = 0x8F8;
                public const long m_pMainGraphController = 0x8E8;
                public const long m_graphControllerManager = 0x850;
                public const long m_bAnimGraphUpdateEnabled = 0x938;
                public const long m_bAnimationUpdateScheduled = 0x939;
                public const long m_OnExternalChoreoGraphChanged = 0x918;
                public const long m_bShouldUpdateTransformations = 0x98A;
                public const long m_bInitiallyPopulateInterpHistory = 0x8F0;
                public const long m_xParentedRagdollRootInEntitySpace = 0x990;
            }
            public static partial class CBaseCSGrenade {
                public const long m_bRedraw = 0x1280;
                public const long m_fDropTime = 0x1290;
                public const long m_bJumpThrow = 0x1283;
                public const long m_bPinPulled = 0x1282;
                public const long m_fThrowTime = 0x1288;
                public const long m_fPinPullTime = 0x1294;
                public const long m_nNextHoldTick = 0x129C;
                public const long m_bJustPulledPin = 0x1298;
                public const long m_flNextHoldFrac = 0x12A0;
                public const long m_bIsHeldByPlayer = 0x1281;
                public const long m_bThrowAnimating = 0x1284;
                public const long m_flThrowStrength = 0x128C;
                public const long m_hSwitchToWeaponAfterThrow = 0x12A4;
            }
            public static partial class CBasePlatTrain {
                public const long m_volume = 0x8E8;
                public const long m_flTWidth = 0x8EC;
                public const long m_flTLength = 0x8F0;
                public const long m_NoiseMoving = 0x8D0;
                public const long m_NoiseArrived = 0x8D8;
            }
            public static partial class CBodyComponent {
                public const long m_pSceneNode = 0x8;
                public const long __m_pChainEntity = 0x48;
            }
            public static partial class CBreakableProp {
                public const long m_OnBreak = 0xAD0;
                public const long m_hBreaker = 0xB48;
                public const long m_OnStartDeath = 0xAB8;
                public const long m_OnTakeDamage = 0xB08;
                public const long m_iszPuntSound = 0xBB8;
                public const long m_bUsePuntSound = 0xBC0;
                public const long m_explodeDamage = 0xB6C;
                public const long m_explodeRadius = 0xB70;
                public const long m_hLastAttacker = 0xBB4;
                public const long m_iMinHealthDmg = 0xB24;
                public const long m_explosionDelay = 0xB80;
                public const long m_sExplosionType = 0xB78;
                public const long m_OnHealthChanged = 0xAE8;
                public const long m_PerformanceMode = 0xB4C;
                public const long m_flDefBurstScale = 0xB38;
                public const long m_flPressureDelay = 0xB34;
                public const long m_vDefBurstOffset = 0xB3C;
                public const long m_hPhysicsAttacker = 0xBA8;
                public const long m_bOriginalBlockLOS = 0xBC1;
                public const long m_explosionModifier = 0xBA0;
                public const long m_impactEnergyScale = 0xB20;
                public const long m_CPropDataComponent = 0xA78;
                public const long m_flDefaultFadeScale = 0xBB0;
                public const long m_explosionCustomSound = 0xB98;
                public const long m_preferredCarryAngles = 0xB28;
                public const long m_BreakableContentsType = 0xB54;
                public const long m_explosionBuildupSound = 0xB88;
                public const long m_explosionCustomEffect = 0xB90;
                public const long m_bHasBreakPiecesOrCommands = 0xB68;
                public const long m_flPreventDamageBeforeTime = 0xB50;
                public const long m_flLastPhysicsInfluenceTime = 0xBAC;
                public const long m_strBreakableContentsParticleOverride = 0xB60;
                public const long m_strBreakableContentsPropGroupOverride = 0xB58;
            }
            public static partial class CDecalInstance {
                public const long m_Color = 0x60;
                public const long m_nFlags = 0x5C;
                public const long m_flDepth = 0x6C;
                public const long m_flWidth = 0x64;
                public const long m_hEntity = 0x14;
                public const long m_flHeight = 0x68;
                public const long m_vSAxisLS = 0x50;
                public const long m_hMaterial = 0x8;
                public const long m_vNormalLS = 0x38;
                public const long m_vNormalOS = 0x44;
                public const long m_mTransform = 0x70;
                public const long m_nBoneIndex = 0x18;
                public const long m_bIsAdjacent = 0xFE;
                public const long m_flPlaceTime = 0xD8;
                public const long m_sDecalGroup = 0x0;
                public const long m_vPositionLS = 0x20;
                public const long m_vPositionOS = 0x2C;
                public const long m_sSequenceName = 0x10;
                public const long m_flFadeDuration = 0xE0;
                public const long m_nSequenceIndex = 0xFC;
                public const long m_nTriangleIndex = 0x1C;
                public const long m_flFadeStartTime = 0xDC;
                public const long m_flAnimationScale = 0xD0;
                public const long m_mLocalToTriangle = 0xA0;
                public const long m_flBoundingRadiusSqr = 0xF8;
                public const long m_bDoDecalLightmapping = 0xFF;
                public const long m_flAnimationStartTime = 0xD4;
                public const long m_flLightingOriginOffset = 0xE4;
            }
            public static partial class CEntityBlocker {

            }
            public static partial class CEnvCubemapBox {

            }
            public static partial class CEnvCubemapFog {
                public const long m_bActive = 0x4CC;
                public const long m_flLODBias = 0x4C8;
                public const long m_bFirstTime = 0x5A1;
                public const long m_hSkyMaterial = 0x4D8;
                public const long m_iszSkyEntity = 0x4E0;
                public const long m_flEndDistance = 0x4A8;
                public const long m_bStartDisabled = 0x4CD;
                public const long m_flFogHeightEnd = 0x4BC;
                public const long m_nHeightFogType = 0x4E8;
                public const long m_flFogMaxOpacity = 0x4D0;
                public const long m_flStartDistance = 0x4AC;
                public const long m_bHasHeightFogEnd = 0x5A0;
                public const long m_flFogHeightStart = 0x4C0;
                public const long m_flFogHeightWidth = 0x4B8;
                public const long m_nDistanceFogType = 0x4F4;
                public const long m_bHeightFogEnabled = 0x4B4;
                public const long m_hFogCubemapTexture = 0x598;
                public const long m_nCubemapSourceType = 0x4D4;
                public const long m_flFogHeightExponent = 0x4C4;
                public const long m_nFogHeightBlendMode = 0x4EC;
                public const long m_HeightFogCurveString = 0x500;
                public const long m_flFogFalloffExponent = 0x4B0;
                public const long m_DistanceFogCurveString = 0x4F8;
                public const long m_nFogHeightCoordinateSpace = 0x4F0;
            }
            public static partial class CEnvSoundscape {
                public const long m_OnPlay = 0x4A8;
                public const long m_flRadius = 0x4C0;
                public const long m_bDisabled = 0x524;
                public const long m_positionNames = 0x4E0;
                public const long m_soundEventHash = 0x530;
                public const long m_soundEventName = 0x4C8;
                public const long m_soundscapeName = 0x528;
                public const long m_soundscapeIndex = 0x4D4;
                public const long m_hProxySoundscape = 0x520;
                public const long m_bOverrideWithEvent = 0x4D0;
                public const long m_soundscapeEntityListId = 0x4D8;
            }
            public static partial class CEnvWindShared {
                public const long m_iMaxGust = 0x1A;
                public const long m_iMaxWind = 0x12;
                public const long m_iMinGust = 0x18;
                public const long m_iMinWind = 0x10;
                public const long m_location = 0x30;
                public const long m_OnGustEnd = 0x58;
                public const long m_hEntOwner = 0x70;
                public const long m_iWindSeed = 0xC;
                public const long m_windRadius = 0x14;
                public const long m_OnGustStart = 0x40;
                public const long m_flStartTime = 0x8;
                public const long m_flGustDuration = 0x24;
                public const long m_flMaxGustDelay = 0x20;
                public const long m_flMinGustDelay = 0x1C;
                public const long m_iGustDirChange = 0x28;
                public const long m_iInitialWindDir = 0x2A;
                public const long m_flInitialWindSpeed = 0x2C;
            }
            public static partial class CFilterContext {
                public const long m_iFilterContext = 0x4E0;
            }
            public static partial class CFiringModeInt {
                public const long m_nValues = 0x0;
            }
            public static partial class CFogController {
                public const long m_fog = 0x4A8;
                public const long m_bUseAngles = 0x510;
                public const long m_iChangedVariables = 0x514;
            }
            public static partial class CFuncTankTrain {
                public const long m_OnDeath = 0x978;
            }
            public static partial class CFuncTimescale {
                public const long m_isStarted = 0x4B8;
                public const long m_flAcceleration = 0x4AC;
                public const long m_flMinBlendRate = 0x4B0;
                public const long m_flDesiredTimescale = 0x4A8;
                public const long m_flBlendDeltaMultiplier = 0x4B4;
            }
            public static partial class CFuncTrackAuto {

            }
            public static partial class CGameSceneNode {
                public const long m_name = 0xF0;
                public const long m_pChild = 0x40;
                public const long m_pOwner = 0x30;
                public const long m_flScale = 0xC4;
                public const long m_hParent = 0x70;
                public const long m_pParent = 0x38;
                public const long m_bDormant = 0xE7;
                public const long m_vecOrigin = 0x80;
                public const long m_flAbsScale = 0xE0;
                public const long m_angRotation = 0xB8;
                public const long m_nodeToWorld = 0x10;
                public const long m_pNextSibling = 0x48;
                public const long m_vecAbsOrigin = 0xC8;
                public const long m_angAbsRotation = 0xD4;
                public const long m_bBoneMergeFlex = 0x0;
                public const long m_nHierarchyType = 0xEC;
                public const long m_bDirtyHierarchy = 0x0;
                public const long m_nLatchAbsOrigin = 0x0;
                public const long m_flClientLocalScale = 0x108;
                public const long m_nHierarchicalDepth = 0xEB;
                public const long m_bDirtyBoneMergeInfo = 0x0;
                public const long m_hierarchyAttachName = 0x104;
                public const long m_bDebugAbsOriginChanges = 0xE6;
                public const long m_bNetworkedScaleChanged = 0x0;
                public const long m_bNetworkedAnglesChanged = 0x0;
                public const long m_nParentAttachmentOrBone = 0xE4;
                public const long m_bDirtyBoneMergeBoneToRoot = 0x0;
                public const long m_bForceParentToBeNetworked = 0xE8;
                public const long m_bNetworkedPositionChanged = 0x0;
                public const long m_bWillBeCallingPostDataUpdate = 0x0;
                public const long m_nDoNotSetAnimTimeInInvalidatePhysicsCount = 0xED;
            }
            public static partial class CInButtonState {
                public const long m_pButtonStates = 0x8;
            }
            public static partial class CLogicAutosave {
                public const long m_minHitPoints = 0x4AC;
                public const long m_bForceNewLevelUnit = 0x4A8;
                public const long m_minHitPointsToCommit = 0x4B0;
            }
            public static partial class CLogicalEntity {

            }
            public static partial class CMessageEntity {
                public const long m_radius = 0x4A8;
                public const long m_bEnabled = 0x4BA;
                public const long m_drawText = 0x4B8;
                public const long m_messageText = 0x4B0;
                public const long m_bDeveloperOnly = 0x4B9;
            }
            public static partial class CMoverPathNode {
                public const long m_OnPassThrough = 0x540;
                public const long m_OnPassThroughForward = 0x560;
                public const long m_OnPassThroughReverse = 0x580;
                public const long m_OnStartFromOrInSegment = 0x500;
                public const long m_OnStoppedAtOrInSegment = 0x520;
            }
            public static partial class CPathQueryUtil {
                public const long m_bIsClosedLoop = 0x78;
                public const long m_PathToEntityTransform = 0x10;
                public const long m_vecPathSampleDistances = 0x60;
                public const long m_vecPathSamplePositions = 0x30;
                public const long m_vecPathSampleParameters = 0x48;
            }
            public static partial class CPhysExplosion {
                public const long m_radius = 0x4B4;
                public const long m_flDamage = 0x4B0;
                public const long m_flMagnitude = 0x4AC;
                public const long m_flPushScale = 0x4CC;
                public const long m_flInnerRadius = 0x4C8;
                public const long m_OnPushedPlayer = 0x4D8;
                public const long m_bExplodeOnSpawn = 0x4A8;
                public const long m_ignoreEntityName = 0x4C0;
                public const long m_targetEntityName = 0x4B8;
                public const long m_bDisablePushClamp = 0x4D2;
                public const long m_bAffectInvulnerableEnts = 0x4D1;
                public const long m_bConvertToDebrisWhenPossible = 0x4D0;
            }
            public static partial class CPhysicsSpring {
                public const long m_end = 0x4DC;
                public const long m_start = 0x4D0;
                public const long m_flFrequency = 0x4B0;
                public const long m_flRestLength = 0x4B8;
                public const long m_pSpringJoint = 0x4A8;
                public const long m_teleportTick = 0x4E8;
                public const long m_nameAttachEnd = 0x4C8;
                public const long m_flDampingRatio = 0x4B4;
                public const long m_nameAttachStart = 0x4C0;
            }
            public static partial class CPointGiveAmmo {
                public const long m_pActivator = 0x4A8;
            }
            public static partial class CPointTeleport {
                public const long m_vSaveAngles = 0x4B4;
                public const long m_vSaveOrigin = 0x4A8;
                public const long m_bTeleportUseCurrentAngle = 0x4C1;
                public const long m_bTeleportParentedEntities = 0x4C0;
            }
            public static partial class CPointTemplate {
                public const long m_iszWorldName = 0x4A8;
                public const long m_OnEntitySpawned = 0x510;
                public const long m_flTimeoutInterval = 0x4C0;
                public const long m_ScriptCallbackScope = 0x508;
                public const long m_ScriptSpawnCallback = 0x500;
                public const long m_iszEntityFilterName = 0x4B8;
                public const long m_ownerSpawnGroupType = 0x4CC;
                public const long m_SpawnedEntityHandles = 0x4E8;
                public const long m_clientOnlyEntityBehavior = 0x4C8;
                public const long m_createdSpawnGroupHandles = 0x4D0;
                public const long m_iszSource2EntityLumpName = 0x4B0;
                public const long m_bAsynchronouslySpawnEntities = 0x4C4;
            }
            public static partial class CPrecipitation {

            }
            public static partial class CPulseGraphDef {
                public const long m_Vars = 0x80;
                public const long m_Cells = 0x68;
                public const long m_Chunks = 0x50;
                public const long m_CallInfos = 0xE0;
                public const long m_Constants = 0xF8;
                public const long m_DomainValues = 0x110;
                public const long m_TempVarBanks = 0x98;
                public const long m_DomainSubType = 0x18;
                public const long m_ParentMapName = 0x30;
                public const long m_ParentXmlName = 0x40;
                public const long m_PublicOutputs = 0xB0;
                public const long m_InvokeBindings = 0xC8;
                public const long m_DomainIdentifier = 0x8;
                public const long m_OutputConnections = 0x140;
                public const long m_BlackboardReferences = 0x128;
            }
            public static partial class CRagdollMagnet {
                public const long m_axis = 0x4B4;
                public const long m_force = 0x4B0;
                public const long m_radius = 0x4AC;
                public const long m_bDisabled = 0x4A8;
            }
            public static partial class CRandStopwatch {
                public const long m_flMaxInterval = 0x10;
                public const long m_flMinInterval = 0xC;
            }
            public static partial class CResponseQueue {
                public const long m_ExpresserTargets = 0x38;
            }
            public static partial class CRotatorTarget {

            }
            public static partial class CSMatchStats_t {
                public const long m_i1v1Wins = 0xA8;
                public const long m_i1v2Wins = 0xB0;
                public const long m_i1v1Count = 0xA4;
                public const long m_i1v2Count = 0xAC;
                public const long m_iEnemy2Ks = 0x7C;
                public const long m_iEnemy3Ks = 0x70;
                public const long m_iEnemy4Ks = 0x6C;
                public const long m_iEnemy5Ks = 0x68;
                public const long m_iEntryWins = 0xB8;
                public const long m_iEntryCount = 0xB4;
                public const long m_iFlash_Count = 0x8C;
                public const long m_iUtility_Count = 0x80;
                public const long m_iEnemyKnifeKills = 0x74;
                public const long m_iEnemyTaserKills = 0x78;
                public const long m_iFlash_Successes = 0x90;
                public const long m_iUtility_Enemies = 0x88;
                public const long m_nShotsFiredTotal = 0x9C;
                public const long m_iUtility_Successes = 0x84;
                public const long m_nShotsOnTargetTotal = 0xA0;
                public const long m_flHealthPointsDealtTotal = 0x98;
                public const long m_flHealthPointsRemovedTotal = 0x94;
            }
            public static partial class CSoundEnvelope {
                public const long m_rate = 0x8;
                public const long m_target = 0x4;
                public const long m_current = 0x0;
                public const long m_forceupdate = 0xC;
            }
            public static partial class CStopwatchBase {
                public const long m_bIsRunning = 0x8;
            }
            public static partial class CTeamplayRules {

            }
            public static partial class CTriggerImpact {
                public const long m_flNoise = 0x9E4;
                public const long m_flViewkick = 0x9E8;
                public const long m_flMagnitude = 0x9E0;
                public const long m_pOutputForce = 0x9F0;
            }
            public static partial class CTriggerRemove {
                public const long m_OnRemove = 0x9C8;
            }
            public static partial class CTriggerVolume {
                public const long m_hFilter = 0x858;
                public const long m_iFilterName = 0x850;
            }
            public static partial class CWeaponGalilAR {

            }
            public static partial class CWeaponHKP2000 {

            }
            public static partial class CountdownTimer {
                public const long m_duration = 0x8;
                public const long m_timescale = 0x10;
                public const long m_timestamp = 0xC;
                public const long m_nWorldGroupId = 0x14;
            }
            public static partial class IHasAttributes {

            }
            public static partial class ParticleNode_t {
                public const long m_iIndex = 0x4;
                public const long m_hEntity = 0x0;
                public const long m_flStartTime = 0x8;
                public const long m_flEndcapTime = 0x1C;
                public const long m_vecGrowthOrigin = 0x10;
                public const long m_bMarkedForDelete = 0x20;
                public const long m_flGrowthDuration = 0xC;
            }
            public static partial class Relationship_t {
                public const long priority = 0x4;
                public const long disposition = 0x0;
            }
            public static partial class ResponseParams {
                public const long odds = 0x10;
                public const long flags = 0x12;
                public const long m_pFollowup = 0x18;
            }
            public static partial class SceneEventId_t {
                public const long m_Value = 0x0;
            }
            public static partial class SoundCommand_t {
                public const long m_time = 0x8;
                public const long m_value = 0x14;
                public const long m_command = 0x10;
                public const long m_deltaTime = 0xC;
            }
            public static partial class globalentity_t {
                public const long name = 0x0;
                public const long state = 0x4;
                public const long counter = 0x8;
                public const long levelName = 0x2;
            }
            public static partial class hudtextparms_t {
                public const long x = 0xC;
                public const long y = 0x10;
                public const long color1 = 0x0;
                public const long color2 = 0x4;
                public const long effect = 0x8;
                public const long channel = 0x9;
            }
            public static partial class CAmbientGeneric {
                public const long m_dpv = 0x4B4;
                public const long m_radius = 0x4A8;
                public const long m_fActive = 0x518;
                public const long m_fLooping = 0x519;
                public const long m_iszSound = 0x520;
                public const long m_flMaxRadius = 0x4AC;
                public const long m_iSoundLevel = 0x4B0;
                public const long m_hSoundSource = 0x530;
                public const long m_sSourceEntName = 0x528;
                public const long m_nSoundSourceEntIndex = 0x534;
            }
            public static partial class CBasePlayerPawn {
                public const long v_angle = 0xBC8;
                public const long m_fInitHUD = 0xC88;
                public const long m_iHideHUD = 0xBE0;
                public const long m_skybox3d = 0xBE8;
                public const long m_pExpresser = 0xC90;
                public const long m_flDeathTime = 0xC7C;
                public const long m_hController = 0xC98;
                public const long m_pUseServices = 0xB38;
                public const long m_fTimeLastHurt = 0xC78;
                public const long m_pItemServices = 0xB18;
                public const long v_anglePrevious = 0xBD4;
                public const long m_fHltvReplayEnd = 0xCA8;
                public const long m_pWaterServices = 0xB30;
                public const long m_pCameraServices = 0xB48;
                public const long m_pWeaponServices = 0xB10;
                public const long m_fHltvReplayDelay = 0xCA4;
                public const long m_fNextSuicideTime = 0xC80;
                public const long m_pAutoaimServices = 0xB20;
                public const long m_iHltvReplayEntity = 0xCAC;
                public const long m_pMovementServices = 0xB50;
                public const long m_pObserverServices = 0xB28;
                public const long m_sndOpvarLatchData = 0xCB0;
                public const long m_hDefaultController = 0xC9C;
                public const long m_pFlashlightServices = 0xB40;
                public const long m_ServerViewAngleChanges = 0xB60;
            }
            public static partial class CBtActionMoveTo {
                public const long m_RepathTimer = 0xC0;
                public const long m_bComputePath = 0x85;
                public const long m_vecDestination = 0x78;
                public const long m_bAutoLookAdjust = 0x84;
                public const long m_flArrivalEpsilon = 0xD8;
                public const long m_szThreatInputKey = 0x70;
                public const long m_szHidingSpotInputKey = 0x68;
                public const long m_CheckHighPriorityItem = 0xA8;
                public const long m_szDestinationInputKey = 0x60;
                public const long m_flDamagingAreasPenaltyCost = 0x88;
                public const long m_CheckApproximateCornersTimer = 0x90;
                public const long m_flAdditionalArrivalEpsilon2D = 0xDC;
                public const long m_flNearestAreaDistanceThreshold = 0xE4;
                public const long m_flHidingSpotCheckDistanceThreshold = 0xE0;
            }
            public static partial class CBuoyancyHelper {
                public const long m_nFluidType = 0x18;
                public const long m_pController = 0x8;
                public const long m_vecWheelDrag = 0x78;
                public const long m_flFluidDensity = 0x1C;
                public const long m_bNeutrallyBuoyant = 0x2C;
                public const long m_vecWheelFrictionScales = 0x48;
                public const long m_flNeutrallyBuoyantGravity = 0x20;
                public const long m_flNeutrallyBuoyantLinearDamping = 0x24;
                public const long m_flNeutrallyBuoyantAngularDamping = 0x28;
                public const long m_vecFractionOfWheelSubmergedForWheelDrag = 0x60;
                public const long m_vecFractionOfWheelSubmergedForWheelFriction = 0x30;
            }
            public static partial class CCSObserverPawn {

            }
            public static partial class CCSPetPlacement {

            }
            public static partial class CCSRadarElement {
                public const long m_nTeamFilter = 0x4C8;
                public const long m_nElementType = 0x4C0;
                public const long m_nElementColor = 0x4C4;
            }
            public static partial class CCommentaryAuto {
                public const long m_OnCommentaryMidGame = 0x4C0;
                public const long m_OnCommentaryNewGame = 0x4A8;
                public const long m_OnCommentaryMultiplayerSpawn = 0x4D8;
            }
            public static partial class CEntityDissolve {
                public const long m_nMagnitude = 0x87C;
                public const long m_flStartTime = 0x868;
                public const long m_flFadeInStart = 0x850;
                public const long m_nDissolveType = 0x86C;
                public const long m_flFadeInLength = 0x854;
                public const long m_flFadeOutStart = 0x860;
                public const long m_flFadeOutLength = 0x864;
                public const long m_vDissolverOrigin = 0x870;
                public const long m_flFadeOutModelStart = 0x858;
                public const long m_flFadeOutModelLength = 0x85C;
            }
            public static partial class CEntityIdentity {
                public const long m_name = 0x18;
                public const long m_flags = 0x30;
                public const long m_pNext = 0x58;
                public const long m_pPrev = 0x50;
                public const long m_PathIndex = 0x40;
                public const long m_pAttributes = 0x48;
                public const long m_designerName = 0x20;
                public const long m_pNextByClass = 0x68;
                public const long m_pPrevByClass = 0x60;
                public const long m_worldGroupId = 0x38;
                public const long m_fDataObjectTypes = 0x3C;
                public const long m_nameStringTableIndex = 0x14;
            }
            public static partial class CEntityInstance {
                public const long m_pEntity = 0x10;
                public const long m_CScriptComponent = 0x28;
                public const long m_iszPrivateVScripts = 0x8;
            }
            public static partial class CEnvEntityMaker {
                public const long m_iszTemplate = 0x4F0;
                public const long m_vecEntityMaxs = 0x4B4;
                public const long m_vecEntityMins = 0x4A8;
                public const long m_hCurrentBlocker = 0x4C4;
                public const long m_flPostSpawnSpeed = 0x4E4;
                public const long m_hCurrentInstance = 0x4C0;
                public const long m_pOutputOnSpawned = 0x4F8;
                public const long m_vecBlockerOrigin = 0x4C8;
                public const long m_bPostSpawnUseAngles = 0x4E8;
                public const long m_pOutputOnFailedSpawn = 0x510;
                public const long m_angPostSpawnDirection = 0x4D4;
                public const long m_flPostSpawnDirectionVariance = 0x4E0;
            }
            public static partial class CEnvMuzzleFlash {
                public const long m_flScale = 0x4A8;
                public const long m_iszParentAttachment = 0x4B0;
            }
            public static partial class CFilterMultiple {
                public const long m_hFilter = 0x538;
                public const long m_iFilterName = 0x4E8;
                public const long m_nFilterType = 0x4E0;
            }
            public static partial class CFuncMoveLinear {
                public const long m_flSpeed = 0x948;
                public const long m_soundStop = 0x8F8;
                public const long m_soundStart = 0x8F0;
                public const long m_OnFullyOpen = 0x918;
                public const long m_currentSound = 0x900;
                public const long m_OnFullyClosed = 0x930;
                public const long m_flBlockDamage = 0x908;
                public const long m_flStartPosition = 0x90C;
                public const long m_authoredPosition = 0x8D0;
                public const long m_angMoveEntitySpace = 0x8D4;
                public const long m_bCreateNavObstacle = 0x94E;
                public const long m_bCreateMovableNavMesh = 0x94C;
                public const long m_vecMoveDirParentSpace = 0x8E0;
                public const long m_bAllowMovableNavMeshDockingOnEntireEntity = 0x94D;
            }
            public static partial class CFuncNavBlocker {
                public const long m_bDisabled = 0x858;
                public const long m_nBlockedTeamNumber = 0x85C;
            }
            public static partial class CFuncTrackTrain {
                public const long m_dir = 0x8B4;
                public const long m_ppath = 0x850;
                public const long m_OnNext = 0x928;
                public const long m_flBank = 0x8A0;
                public const long m_height = 0x8AC;
                public const long m_length = 0x854;
                public const long m_OnStart = 0x910;
                public const long m_angPrev = 0x864;
                public const long m_flSpeed = 0x870;
                public const long m_flVolume = 0x89C;
                public const long m_maxSpeed = 0x8B0;
                public const long m_oldSpeed = 0x8A4;
                public const long m_vPosPrev = 0x858;
                public const long m_controlMaxs = 0x880;
                public const long m_controlMins = 0x874;
                public const long m_flAccelSpeed = 0x964;
                public const long m_flDecelSpeed = 0x968;
                public const long m_iszSoundMove = 0x8B8;
                public const long m_iszSoundStop = 0x8D0;
                public const long m_lastBlockPos = 0x88C;
                public const long m_bAccelToSpeed = 0x96C;
                public const long m_eVelocityType = 0x8F8;
                public const long m_flBlockDamage = 0x8A8;
                public const long m_iszSoundStart = 0x8C8;
                public const long m_lastBlockTick = 0x898;
                public const long m_strPathTarget = 0x8D8;
                public const long m_flDesiredSpeed = 0x95C;
                public const long m_eOrientationType = 0x8F4;
                public const long m_iszSoundMovePing = 0x8C0;
                public const long m_flNextMPSoundTime = 0x970;
                public const long m_flSpeedChangeTime = 0x960;
                public const long m_bManualSpeedChanges = 0x958;
                public const long m_flMoveSoundMaxPitch = 0x8F0;
                public const long m_flMoveSoundMinPitch = 0x8EC;
                public const long m_flNextMoveSoundTime = 0x8E8;
                public const long m_flMoveSoundMaxDuration = 0x8E4;
                public const long m_flMoveSoundMinDuration = 0x8E0;
                public const long m_OnArrivedAtDestinationNode = 0x940;
            }
            public static partial class CFuncWallToggle {

            }
            public static partial class CGameGibManager {
                public const long m_iLastFrame = 0x4CC;
                public const long m_iMaxPieces = 0x4C8;
                public const long m_bAllowNewGibs = 0x4C0;
                public const long m_iCurrentMaxPieces = 0x4C4;
            }
            public static partial class CGamePlayerZone {
                public const long m_OnPlayerInZone = 0x858;
                public const long m_PlayersInCount = 0x888;
                public const long m_OnPlayerOutZone = 0x870;
                public const long m_PlayersOutCount = 0x8A8;
            }
            public static partial class CGameRulesProxy {

            }
            public static partial class CInfoWorldLayer {
                public const long m_layerName = 0x4C8;
                public const long m_worldName = 0x4C0;
                public const long m_bEntitiesSpawned = 0x4D1;
                public const long m_hLayerSpawnGroup = 0x4D4;
                public const long m_bWorldLayerVisible = 0x4D0;
                public const long m_bCreateAsChildSpawnGroup = 0x4D2;
                public const long m_pOutputOnEntitiesSpawned = 0x4A8;
            }
            public static partial class CLightComponent {
                public const long m_Color = 0x78;
                public const long m_flPhi = 0xA4;
                public const long m_nStyle = 0xD4;
                public const long m_Pattern = 0xD8;
                public const long m_flRange = 0x8C;
                public const long m_flTheta = 0xA0;
                public const long m_SkyColor = 0x190;
                public const long m_bEnabled = 0x140;
                public const long m_bFlicker = 0x141;
                public const long m_flFalloff = 0x90;
                public const long m_nCascades = 0xB0;
                public const long m_flBrightness = 0x80;
                public const long m_hLightCookie = 0xA8;
                public const long m_nBounceLight = 0x128;
                public const long m_nCastShadows = 0xB4;
                public const long m_nDirectLight = 0x124;
                public const long m_nShadowWidth = 0xB8;
                public const long m_bMixedShadows = 0x19D;
                public const long m_flBounceScale = 0x12C;
                public const long m_flFadeMaxDist = 0x134;
                public const long m_flFadeMinDist = 0x130;
                public const long m_nShadowHeight = 0xBC;
                public const long __m_pChainEntity = 0x38;
                public const long m_SecondaryColor = 0x7C;
                public const long m_bRenderDiffuse = 0xC0;
                public const long m_flAttenuation0 = 0x94;
                public const long m_flAttenuation1 = 0x98;
                public const long m_flAttenuation2 = 0x9C;
                public const long m_flMinRoughness = 0x1A8;
                public const long m_flSkyIntensity = 0x194;
                public const long m_flCapsuleLength = 0x1A4;
                public const long m_flNearClipPlane = 0x18C;
                public const long m_nRenderSpecular = 0xC4;
                public const long m_nShadowPriority = 0x110;
                public const long m_SkyAmbientBounce = 0x198;
                public const long m_bPvsModifyEntity = 0x1B8;
                public const long m_flBrightnessMult = 0x88;
                public const long m_nFogLightingMode = 0x184;
                public const long m_bRenderToCubemaps = 0x120;
                public const long m_flBrightnessScale = 0x84;
                public const long m_flOrthoLightWidth = 0xCC;
                public const long m_nBakedShadowIndex = 0x114;
                public const long m_nLightMapUniqueId = 0x11C;
                public const long m_bUseSecondaryColor = 0x19C;
                public const long m_flOrthoLightHeight = 0xD0;
                public const long m_nLightPathUniqueId = 0x118;
                public const long m_bAllowSSTGeneration = 0x121;
                public const long m_bRenderTransmissive = 0xC8;
                public const long m_bUsesBakedShadowing = 0x10C;
                public const long m_flShadowFadeMaxDist = 0x13C;
                public const long m_flShadowFadeMinDist = 0x138;
                public const long m_flLightStyleStartTime = 0x1A0;
                public const long m_flPrecomputedMaxRange = 0x180;
                public const long m_vPrecomputedOBBAngles = 0x168;
                public const long m_vPrecomputedOBBExtent = 0x174;
                public const long m_vPrecomputedOBBOrigin = 0x15C;
                public const long m_vPrecomputedBoundsMaxs = 0x150;
                public const long m_vPrecomputedBoundsMins = 0x144;
                public const long m_bPrecomputedFieldsValid = 0x142;
                public const long m_flFogContributionStength = 0x188;
                public const long m_flShadowCascadeCrossFade = 0xE4;
                public const long m_flShadowCascadeDistance0 = 0xEC;
                public const long m_flShadowCascadeDistance1 = 0xF0;
                public const long m_flShadowCascadeDistance2 = 0xF4;
                public const long m_flShadowCascadeDistance3 = 0xF8;
                public const long m_nShadowCascadeResolution0 = 0xFC;
                public const long m_nShadowCascadeResolution1 = 0x100;
                public const long m_nShadowCascadeResolution2 = 0x104;
                public const long m_nShadowCascadeResolution3 = 0x108;
                public const long m_flShadowCascadeDistanceFade = 0xE8;
                public const long m_nCascadeRenderStaticObjects = 0xE0;
            }
            public static partial class CLogicGameEvent {
                public const long m_iszEventName = 0x4A8;
            }
            public static partial class CLogicProximity {

            }
            public static partial class CMathColorBlend {
                public const long m_flInMax = 0x4AC;
                public const long m_flInMin = 0x4A8;
                public const long m_OutValue = 0x4B8;
                public const long m_OutColor1 = 0x4B0;
                public const long m_OutColor2 = 0x4B4;
            }
            public static partial class CMolotovGrenade {

            }
            public static partial class CMultiplayRules {

            }
            public static partial class CParticleSystem {
                public const long m_bActive = 0xA50;
                public const long m_bFrozen = 0xA51;
                public const long m_bNoRamp = 0xBB2;
                public const long m_bNoSave = 0xBB0;
                public const long m_clrTint = 0xDD4;
                public const long m_nDataCP = 0xDC0;
                public const long m_nTintCP = 0xDD0;
                public const long m_bNoFreeze = 0xBB1;
                public const long m_nStopType = 0xA58;
                public const long m_flStartTime = 0xA68;
                public const long m_bStartActive = 0xBB3;
                public const long m_flPreSimTime = 0xA6C;
                public const long m_iEffectIndex = 0xA60;
                public const long m_iszEffectName = 0xBB8;
                public const long m_strDataString = 0xBA8;
                public const long m_vecDataCPValue = 0xDC4;
                public const long m_hControlPointEnts = 0xAA4;
                public const long m_szSnapshotFileName = 0x850;
                public const long m_bDataStringLocalized = 0xBA4;
                public const long m_iszControlPointNames = 0xBC0;
                public const long m_vServerControlPoints = 0xA70;
                public const long m_flFreezeTransitionDuration = 0xA54;
                public const long m_bAnimateDuringGameplayPause = 0xA5C;
                public const long m_iServerControlPointAssignments = 0xAA0;
            }
            public static partial class CPhysBallSocket {
                public const long m_flSwingLimit = 0x510;
                public const long m_flJointFriction = 0x508;
                public const long m_flMaxTwistAngle = 0x51C;
                public const long m_flMinTwistAngle = 0x518;
                public const long m_bEnableSwingLimit = 0x50C;
                public const long m_bEnableTwistLimit = 0x514;
            }
            public static partial class CPhysConstraint {
                public const long m_hJoint = 0x4A8;
                public const long m_OnBreak = 0x4F0;
                public const long m_hAttach1 = 0x4C0;
                public const long m_hAttach2 = 0x4C4;
                public const long m_breakSound = 0x4D8;
                public const long m_forceLimit = 0x4E0;
                public const long m_nameAttach1 = 0x4B0;
                public const long m_nameAttach2 = 0x4B8;
                public const long m_torqueLimit = 0x4E4;
                public const long m_nameAttachment1 = 0x4C8;
                public const long m_nameAttachment2 = 0x4D0;
                public const long m_minTeleportDistance = 0x4E8;
                public const long m_bSnapObjectPositions = 0x4EC;
                public const long m_bTreatEntity1AsInfiniteMass = 0x4ED;
            }
            public static partial class CPhysicalButton {

            }
            public static partial class CPointWorldText {
                public const long m_Color = 0xAF0;
                public const long m_FontName = 0xA50;
                public const long m_bEnabled = 0xAD0;
                public const long m_flFontSize = 0xAD8;
                public const long m_bFullbright = 0xAD1;
                public const long m_messageText = 0x850;
                public const long m_flDepthOffset = 0xADC;
                public const long m_nReorientMode = 0xAFC;
                public const long m_bDrawBackground = 0xAE0;
                public const long m_nJustifyVertical = 0xAF8;
                public const long m_flWorldUnitsPerPx = 0xAD4;
                public const long m_nJustifyHorizontal = 0xAF4;
                public const long m_flBackgroundWorldToUV = 0xAEC;
                public const long m_BackgroundMaterialName = 0xA90;
                public const long m_flBackgroundBorderWidth = 0xAE4;
                public const long m_flBackgroundBorderHeight = 0xAE8;
            }
            public static partial class CPulseCell_Base {
                public const long m_nEditorNodeID = 0x8;
            }
            public static partial class CPulse_CallInfo {
                public const long m_PortName = 0x0;
                public const long m_nSrcChunk = 0x4C;
                public const long m_RegisterMap = 0x18;
                public const long m_CallMethodID = 0x48;
                public const long m_nEditorNodeID = 0x10;
                public const long m_nBreakDestChunk = 0x54;
                public const long m_nSrcInstruction = 0x50;
                public const long m_nBreakDestInstruction = 0x58;
            }
            public static partial class CRagdollManager {
                public const long m_bCanTakeDamage = 0x4B1;
                public const long m_bSaveImportant = 0x4B0;
                public const long m_iMaxRagdollCount = 0x4AC;
                public const long m_iCurrentMaxRagdollCount = 0x4A8;
            }
            public static partial class CRopeOverlapHit {
                public const long m_hEntity = 0x0;
                public const long m_vecOverlappingLinks = 0x8;
            }
            public static partial class CSceneEventInfo {
                public const long m_nType = 0x3C;
                public const long m_flNext = 0x40;
                public const long m_iLayer = 0x0;
                public const long m_hTarget = 0x6C;
                public const long m_bStarted = 0x75;
                public const long m_flWeight = 0xC;
                public const long m_hAnimClip = 0x20;
                public const long m_hSequence = 0x8;
                public const long m_iPriority = 0x4;
                public const long m_bIsGesture = 0x44;
                public const long m_bClientSide = 0x74;
                public const long m_bHasArrived = 0x38;
                public const long m_flLastCycle = 0x1C;
                public const long m_bShouldRemove = 0x45;
                public const long m_nSceneEventId = 0x70;
                public const long m_sAnimClipSlot = 0x28;
                public const long m_flLastJumpToTime = 0x18;
                public const long m_flLastJumpFromTime = 0x14;
                public const long m_sAnimClipSlotWeight = 0x30;
                public const long m_flLastAccumulatedTime = 0x10;
            }
            public static partial class CSimpleSimTimer {
                public const long m_flNext = 0x0;
                public const long m_nWorldGroupId = 0x4;
            }
            public static partial class CSoundStackSave {
                public const long m_iszStackName = 0x4A8;
            }
            public static partial class CSpriteOriented {

            }
            public static partial class CTakeDamageInfo {
                public const long m_flDamage = 0x44;
                public const long m_hAbility = 0x40;
                public const long m_hAttacker = 0x3C;
                public const long m_iAmmoType = 0x54;
                public const long m_hInflictor = 0x38;
                public const long m_iHitGroupId = 0x78;
                public const long m_bShouldBleed = 0x64;
                public const long m_bShouldSpark = 0x65;
                public const long m_nDamageFlags = 0x70;
                public const long m_iDamageCustom = 0x50;
                public const long m_bStoppedBullet = 0x84;
                public const long m_bitsDamageType = 0x4C;
                public const long m_vecDamageForce = 0x8;
                public const long m_flOriginalDamage = 0x60;
                public const long m_flTotalledDamage = 0x48;
                public const long m_bInTakeDamageFlow = 0x110;
                public const long m_vecDamagePosition = 0x14;
                public const long m_vecDamageDirection = 0x2C;
                public const long m_vecReportedPosition = 0x20;
                public const long m_nNumObjectsPenetrated = 0x7C;
                public const long m_DestructibleHitGroupRequests = 0x100;
                public const long m_flFriendlyFireDamageReductionRatio = 0x80;
            }
            public static partial class CTonemapTrigger {
                public const long m_hTonemapController = 0x9D0;
                public const long m_tonemapControllerName = 0x9C8;
            }
            public static partial class CTriggerGravity {

            }
            public static partial class CTriggerPhysics {
                public const long m_flFrequency = 0x9F0;
                public const long m_linearForce = 0x9EC;
                public const long m_linearLimit = 0x9DC;
                public const long m_pController = 0x9D0;
                public const long m_angularLimit = 0x9E4;
                public const long m_gravityScale = 0x9D8;
                public const long m_linearDamping = 0x9E0;
                public const long m_angularDamping = 0x9E8;
                public const long m_flDampingRatio = 0x9F4;
                public const long m_bCollapseToForcePoint = 0xA04;
                public const long m_vecLinearForcePointAt = 0x9F8;
                public const long m_vecLinearForceDirection = 0xA14;
                public const long m_vecLinearForcePointAtWorld = 0xA08;
                public const long m_bConvertToDebrisWhenPossible = 0xA21;
                public const long m_bForceDirectionIsInLocalSpace = 0xA20;
            }
            public static partial class CVoteController {
                public const long m_nVotesCast = 0x518;
                public const long m_VoteOptions = 0x640;
                public const long m_bIsYesNoVote = 0x4C8;
                public const long m_resetVoteTimer = 0x500;
                public const long m_iOnlyTeamToVote = 0x4AC;
                public const long m_nPotentialVotes = 0x4C4;
                public const long m_potentialIssues = 0x628;
                public const long m_nVoteOptionCount = 0x4B0;
                public const long m_iActiveIssueIndex = 0x4A8;
                public const long m_playerHoldingVote = 0x618;
                public const long m_nHighestCountIndex = 0x620;
                public const long m_acceptingVotesTimer = 0x4D0;
                public const long m_executeCommandTimer = 0x4E8;
                public const long m_playerOverrideForVote = 0x61C;
            }
            public static partial class CWeaponBaseItem {
                public const long m_bRedraw = 0x1281;
                public const long m_bSequenceInProgress = 0x1280;
            }
            public static partial class CWeaponRevolver {

            }
            public static partial class CWeaponSawedoff {

            }
            public static partial class ChickenPathCost {

            }
            public static partial class HostagePathCost {

            }
            public static partial class IChoreoServices {

            }
            public static partial class ParticleIndex_t {
                public const long m_Value = 0x0;
            }
            public static partial class VelocitySampler {
                public const long m_prevSample = 0x0;
                public const long m_fPrevSampleTime = 0xC;
                public const long m_fIdealSampleRate = 0x10;
            }
            public static partial class ActorClipEntry_t {
                public const long m_bLooping = 0x8;
                public const long m_sClipName = 0x0;
            }
            public static partial class ApproachAreaCost {

            }
            public static partial class CBaseModelEntity {
                public const long m_Glow = 0x6A0;
                public const long m_OnIgnite = 0x538;
                public const long m_Collision = 0x5E8;
                public const long m_clrRender = 0x570;
                public const long m_nRenderFX = 0x551;
                public const long m_fadeMaxDist = 0x700;
                public const long m_fadeMinDist = 0x6FC;
                public const long m_flFadeScale = 0x704;
                public const long m_nRenderMode = 0x550;
                public const long m_vecViewOffset = 0x818;
                public const long m_bNoInterpolate = 0x5E2;
                public const long m_nObjectCulling = 0x70C;
                public const long m_CHitboxComponent = 0x4B0;
                public const long m_CRenderComponent = 0x4A8;
                public const long m_bAllowFadeInView = 0x552;
                public const long m_bodyGroupChoices = 0x7F0;
                public const long m_flShadowStrength = 0x708;
                public const long m_pChoreoComponent = 0x4C8;
                public const long m_bRenderToCubemaps = 0x5E0;
                public const long m_bodyGroupRequests = 0x718;
                public const long m_flGlowBackfaceMult = 0x6F8;
                public const long m_bvDisabledHitGroups = 0x848;
                public const long m_flDissolveStartTime = 0x530;
                public const long m_vecRenderAttributes = 0x578;
                public const long m_bodyGroupTotalRequestCount = 0x710;
                public const long m_bExpandRenderBoundsToIncludeCloth = 0x5E1;
                public const long m_pDestructiblePartsSystemComponent = 0x500;
                public const long m_OnDestructibleHitGroupDamageLevelChanged = 0x508;
                public const long m_nDestructiblePartInitialStateDestructed0 = 0x4D0;
                public const long m_nDestructiblePartInitialStateDestructed1 = 0x4D4;
                public const long m_nDestructiblePartInitialStateDestructed2 = 0x4D8;
                public const long m_nDestructiblePartInitialStateDestructed3 = 0x4DC;
                public const long m_nDestructiblePartInitialStateDestructed4 = 0x4E0;
                public const long m_nDestructiblePartInitialStateDestructed0_PartIndex = 0x4E4;
                public const long m_nDestructiblePartInitialStateDestructed1_PartIndex = 0x4E8;
                public const long m_nDestructiblePartInitialStateDestructed2_PartIndex = 0x4EC;
                public const long m_nDestructiblePartInitialStateDestructed3_PartIndex = 0x4F0;
                public const long m_nDestructiblePartInitialStateDestructed4_PartIndex = 0x4F4;
                public const long m_bDestructiblePartInitialStateDestructed0_GenerateBreakpieces = 0x4F8;
                public const long m_bDestructiblePartInitialStateDestructed1_GenerateBreakpieces = 0x4F9;
                public const long m_bDestructiblePartInitialStateDestructed2_GenerateBreakpieces = 0x4FA;
                public const long m_bDestructiblePartInitialStateDestructed3_GenerateBreakpieces = 0x4FB;
                public const long m_bDestructiblePartInitialStateDestructed4_GenerateBreakpieces = 0x4FC;
            }
            public static partial class CBasePlayerVData {
                public const long m_flUseRange = 0x24C;
                public const long m_sModelName = 0x28;
                public const long m_nWaterSpeed = 0x248;
                public const long m_flCrouchTime = 0x254;
                public const long m_flHoldBreathTime = 0x238;
                public const long m_nDrowningDamageMax = 0x244;
                public const long m_flUseAngleTolerance = 0x250;
                public const long m_flArmDamageMultiplier = 0x218;
                public const long m_flLegDamageMultiplier = 0x228;
                public const long m_sModelNameAg2Override = 0x108;
                public const long m_flHeadDamageMultiplier = 0x1E8;
                public const long m_nDrowningDamageInitial = 0x240;
                public const long m_flChestDamageMultiplier = 0x1F8;
                public const long m_flDrowningDamageInterval = 0x23C;
                public const long m_flStomachDamageMultiplier = 0x208;
            }
            public static partial class CBrokenGlassTrap {

            }
            public static partial class CBtNodeComposite {

            }
            public static partial class CBtNodeCondition {
                public const long m_bNegated = 0x58;
            }
            public static partial class CBtNodeDecorator {

            }
            public static partial class CCSGameModeRules {
                public const long __m_pChainEntity = 0x8;
            }
            public static partial class CCSMinimapVolume {
                public const long m_strMinimapName = 0x9C8;
            }
            public static partial class CCSWeaponBaseGun {
                public const long m_zoomLevel = 0x1280;
                public const long m_inPrecache = 0x1294;
                public const long m_bNeedsBoltAction = 0x1295;
                public const long m_silencedModelIndex = 0x1290;
                public const long m_iBurstShotsRemaining = 0x1284;
                public const long m_nRevolverCylinderIdx = 0x1298;
                public const long m_bSkillReloadAvailable = 0x129C;
                public const long m_bSkillBoltLiftedFireKey = 0x129F;
                public const long m_bSkillReloadLiftedReloadKey = 0x129D;
                public const long m_bSkillBoltInterruptAvailable = 0x129E;
            }
            public static partial class CChoreoComponent {
                public const long m_hOwner = 0x30;
                public const long __m_pChainEntity = 0x8;
                public const long m_nNextSceneEventId = 0x70;
                public const long m_flAllowResponsesEndTime = 0x74;
                public const long m_nExernalChoreoGraphCount = 0x34;
                public const long m_sActiveExternalChoreoGraphSlotID = 0x38;
            }
            public static partial class CColorCorrection {
                public const long m_bMaster = 0x4C6;
                public const long m_bEnabled = 0x4C5;
                public const long m_MaxFalloff = 0x4D0;
                public const long m_MinFalloff = 0x4CC;
                public const long m_bExclusive = 0x4C8;
                public const long m_bClientSide = 0x4C7;
                public const long m_flCurWeight = 0x4D4;
                public const long m_flMaxWeight = 0x4C0;
                public const long m_bStartDisabled = 0x4C4;
                public const long m_lookupFilename = 0x6D8;
                public const long m_flFadeInDuration = 0x4A8;
                public const long m_flFadeOutDuration = 0x4AC;
                public const long m_flTimeStartFadeIn = 0x4B8;
                public const long m_netlookupFilename = 0x4D8;
                public const long m_flTimeStartFadeOut = 0x4BC;
                public const long m_flStartFadeInWeight = 0x4B0;
                public const long m_flStartFadeOutWeight = 0x4B4;
            }
            public static partial class CDecalGroupVData {
                public const long m_vecOptions = 0x0;
                public const long m_flTotalProbability = 0x18;
            }
            public static partial class CDecoyProjectile {
                public const long m_fExpireTime = 0xB60;
                public const long m_nDecoyShotTick = 0xB58;
                public const long m_shotsRemaining = 0xB5C;
                public const long m_decoyWeaponDefIndex = 0xB70;
            }
            public static partial class CEntityComponent {

            }
            public static partial class CEnvParticleGlow {
                public const long m_ColorTint = 0xDE4;
                public const long m_flAlphaScale = 0xDD8;
                public const long m_flRadiusScale = 0xDDC;
                public const long m_flSelfIllumScale = 0xDE0;
                public const long m_hTextureOverride = 0xDE8;
            }
            public static partial class CFilterProximity {
                public const long m_flRadius = 0x4E0;
            }
            public static partial class CFiringModeFloat {
                public const long m_flValues = 0x0;
            }
            public static partial class CFootstepControl {
                public const long m_source = 0x9C8;
                public const long m_destination = 0x9D0;
            }
            public static partial class CFuncIllusionary {

            }
            public static partial class CFuncMoverRouter {
                public const long m_hPathMover = 0x4B0;
                public const long m_nMoverIndex = 0x4A8;
                public const long m_iszPathMoverName = 0x4B8;
                public const long m_bRouteToAllMovers = 0x4AC;
            }
            public static partial class CFuncTrackChange {
                public const long m_use = 0x950;
                public const long m_code = 0x948;
                public const long m_train = 0x928;
                public const long m_trackTop = 0x920;
                public const long m_trainName = 0x940;
                public const long m_targetState = 0x94C;
                public const long m_trackBottom = 0x924;
                public const long m_trackTopName = 0x930;
                public const long m_trackBottomName = 0x938;
            }
            public static partial class CFuncVehicleClip {

            }
            public static partial class CGamePlayerEquip {

            }
            public static partial class CHitboxComponent {
                public const long m_flBoundsExpandRadius = 0x14;
            }
            public static partial class CInfoPlayerStart {
                public const long m_bDisabled = 0x4A8;
                public const long m_bIsMaster = 0x4A9;
                public const long m_pPawnSubclass = 0x4B0;
            }
            public static partial class CItemAssaultSuit {

            }
            public static partial class CItem_Healthshot {

            }
            public static partial class CLightSpotEntity {

            }
            public static partial class CLogicBranchList {
                public const long m_OnMixed = 0x578;
                public const long m_OnAllTrue = 0x548;
                public const long m_OnAllFalse = 0x560;
                public const long m_eLastState = 0x540;
                public const long m_LogicBranchList = 0x528;
                public const long m_nLogicBranchNames = 0x4A8;
            }
            public static partial class CLogicNPCCounter {
                public const long m_hSource = 0x668;
                public const long m_bDisabled = 0x67C;
                public const long m_OnFactor_1 = 0x548;
                public const long m_OnFactor_2 = 0x5B8;
                public const long m_OnFactor_3 = 0x628;
                public const long m_OnFactorAll = 0x4D8;
                public const long m_nMaxCount_1 = 0x6AC;
                public const long m_nMaxCount_2 = 0x6D4;
                public const long m_nMaxCount_3 = 0x6FC;
                public const long m_nMinCount_1 = 0x6A8;
                public const long m_nMinCount_2 = 0x6D0;
                public const long m_nMinCount_3 = 0x6F8;
                public const long m_nNPCState_1 = 0x6A0;
                public const long m_nNPCState_2 = 0x6C8;
                public const long m_nNPCState_3 = 0x6F0;
                public const long m_OnMaxCount_1 = 0x530;
                public const long m_OnMaxCount_2 = 0x5A0;
                public const long m_OnMaxCount_3 = 0x610;
                public const long m_OnMinCount_1 = 0x518;
                public const long m_OnMinCount_2 = 0x588;
                public const long m_OnMinCount_3 = 0x5F8;
                public const long m_nMaxCountAll = 0x684;
                public const long m_nMaxFactor_1 = 0x6B4;
                public const long m_nMaxFactor_2 = 0x6DC;
                public const long m_nMaxFactor_3 = 0x704;
                public const long m_nMinCountAll = 0x680;
                public const long m_nMinFactor_1 = 0x6B0;
                public const long m_nMinFactor_2 = 0x6D8;
                public const long m_nMinFactor_3 = 0x700;
                public const long m_OnMaxCountAll = 0x4C0;
                public const long m_OnMinCountAll = 0x4A8;
                public const long m_flDistanceMax = 0x678;
                public const long m_nMaxFactorAll = 0x68C;
                public const long m_nMinFactorAll = 0x688;
                public const long m_bInvertState_1 = 0x6A4;
                public const long m_bInvertState_2 = 0x6CC;
                public const long m_bInvertState_3 = 0x6F4;
                public const long m_flDefaultDist_1 = 0x6BC;
                public const long m_flDefaultDist_2 = 0x6E4;
                public const long m_flDefaultDist_3 = 0x70C;
                public const long m_OnMinPlayerDist_1 = 0x568;
                public const long m_OnMinPlayerDist_2 = 0x5D8;
                public const long m_OnMinPlayerDist_3 = 0x648;
                public const long m_iszNPCClassname_1 = 0x698;
                public const long m_iszNPCClassname_2 = 0x6C0;
                public const long m_iszNPCClassname_3 = 0x6E8;
                public const long m_OnMinPlayerDistAll = 0x4F8;
                public const long m_iszSourceEntityName = 0x670;
            }
            public static partial class CLogicNavigation {
                public const long m_isOn = 0x4B0;
                public const long m_navProperty = 0x4B4;
            }
            public static partial class CMotorController {
                public const long m_axis = 0x10;
                public const long m_speed = 0x8;
                public const long m_maxTorque = 0xC;
                public const long m_inertiaFactor = 0x1C;
            }
            public static partial class CMultiLightProxy {
                public const long m_vecLights = 0x4D0;
                public const long m_flBrightnessDelta = 0x4BC;
                public const long m_bPerformScreenFade = 0x4C0;
                public const long m_iszLightNameFilter = 0x4A8;
                public const long m_flLightRadiusFilter = 0x4B8;
                public const long m_iszLightClassFilter = 0x4B0;
                public const long m_flTargetBrightnessMultiplier = 0x4C4;
                public const long m_flCurrentBrightnessMultiplier = 0x4C8;
            }
            public static partial class CNavVolumeSphere {
                public const long m_vCenter = 0x78;
                public const long m_flRadius = 0x84;
            }
            public static partial class CNavVolumeVector {
                public const long m_bHasBeenPreFiltered = 0x80;
            }
            public static partial class CNmEventConsumer {

            }
            public static partial class CNoiseStreamData {
                public const long m_Stream = 0x0;
            }
            public static partial class CPathCornerCrash {

            }
            public static partial class CPointCameraVFOV {
                public const long m_flVerticalFOV = 0x508;
            }
            public static partial class CPulseExecCursor {

            }
            public static partial class CRenderComponent {
                public const long __m_pChainEntity = 0x10;
                public const long m_bEnableRendering = 0x58;
                public const long m_nSplitscreenFlags = 0x54;
                public const long m_bInterpolationReadyToDraw = 0xA8;
                public const long m_bIsRenderingWithViewModels = 0x50;
            }
            public static partial class CRetakeGameRules {
                public const long m_iBombSite = 0x144;
                public const long m_nMatchSeed = 0x138;
                public const long m_hBombPlanter = 0x148;
                public const long m_bBlockersPresent = 0x13C;
                public const long m_bRoundInProgress = 0x13D;
                public const long m_iFirstSecondHalfRound = 0x140;
            }
            public static partial class CRuleBrushEntity {

            }
            public static partial class CRulePointEntity {
                public const long m_Score = 0x858;
            }
            public static partial class CScriptComponent {
                public const long m_scriptClassName = 0x30;
            }
            public static partial class CSimpleStopwatch {

            }
            public static partial class CSingleplayRules {
                public const long m_bSinglePlayerGameEnding = 0xD0;
            }
            public static partial class CSkyCameraVolume {
                public const long m_hTarget = 0x4D8;
                public const long m_vBoxMaxs = 0x4CC;
                public const long m_vBoxMins = 0x4C0;
                public const long m_nPriority = 0x4DC;
                public const long m_bIsEnabled = 0x4E0;
                public const long m_vBlurOrigin = 0x4E4;
                public const long m_iszTargetName = 0x4F8;
                public const long m_bStartDisabled = 0x4F2;
                public const long m_bSkyboxBlurEffect = 0x4E1;
                public const long m_bSkyboxReceivesWorldCsm = 0x4F0;
                public const long m_bWorldReceivesSkyboxCsm = 0x4F1;
            }
            public static partial class CSkyboxReference {
                public const long m_hSkyCamera = 0x4AC;
                public const long m_worldGroupId = 0x4A8;
            }
            public static partial class CTriggerBuoyancy {
                public const long m_BuoyancyHelper = 0x9C8;
                public const long m_flFluidDensity = 0xAE0;
            }
            public static partial class CTriggerCallback {

            }
            public static partial class CTriggerMultiple {
                public const long m_OnTrigger = 0x9C8;
            }
            public static partial class CTriggerTeleport {
                public const long m_iLandmark = 0x9C8;
                public const long m_bMirrorPlayer = 0x9D1;
                public const long m_bUseLandmarkAngles = 0x9D0;
                public const long m_bCheckDestIfClearForPlayer = 0x9D2;
            }
            public static partial class CWeaponFiveSeven {

            }
            public static partial class FilterDamageType {
                public const long m_iDamageType = 0x4E0;
            }
            public static partial class ResponseFollowup {
                public const long followup_delay = 0x10;
                public const long followup_target = 0x14;
                public const long followup_concept = 0x0;
                public const long followup_contexts = 0x8;
            }
            public static partial class WaterWheelDrag_t {
                public const long m_flWheelDrag = 0x4;
                public const long m_flFractionOfWheelSubmerged = 0x0;
            }
            public static partial class ragdollelement_t {
                public const long m_nHeight = 0x28;
                public const long m_flRadius = 0x24;
                public const long parentIndex = 0x20;
                public const long originParentSpace = 0x0;
            }
            public static partial class CAttributeManager {
                public const long m_hOuter = 0x24;
                public const long m_Providers = 0x8;
                public const long m_ProviderType = 0x2C;
                public const long m_CachedResults = 0x30;
                public const long m_bPreventLoopback = 0x28;
                public const long m_iReapplyProvisionParity = 0x20;
            }
            public static partial class CBasePlayerWeapon {
                public const long m_iClip1 = 0xEC0;
                public const long m_iClip2 = 0xEC4;
                public const long m_OnPlayerUse = 0xED0;
                public const long m_pReserveAmmo = 0xEC8;
                public const long m_nNextPrimaryAttackTick = 0xEB0;
                public const long m_nNextSecondaryAttackTick = 0xEB8;
                public const long m_flNextPrimaryAttackTickRatio = 0xEB4;
                public const long m_flNextSecondaryAttackTickRatio = 0xEBC;
            }
            public static partial class CCSGameRulesProxy {
                public const long m_pGameRules = 0x4A8;
            }
            public static partial class CCSPlayerPawnBase {
                public const long m_iNumSpawns = 0xDF4;
                public const long m_bRespawning = 0xDF0;
                public const long m_iPlayerState = 0xD40;
                public const long m_pPingServices = 0xD30;
                public const long m_blindStartTime = 0xD3C;
                public const long m_blindUntilTime = 0xD38;
                public const long m_flFlashDuration = 0xE04;
                public const long m_flFlashMaxAlpha = 0xE08;
                public const long m_bHasMovedSinceSpawn = 0xDF1;
                public const long m_hOriginalController = 0xE14;
                public const long m_fNextRadarUpdateTime = 0xE00;
                public const long m_iProgressBarDuration = 0xE10;
                public const long m_flProgressBarStartTime = 0xE0C;
                public const long m_CTouchExpansionComponent = 0xCE0;
                public const long m_flIdleTimeSinceLastAction = 0xDFC;
            }
            public static partial class CCSPlayerResource {
                public const long m_bHostageAlive = 0x4A8;
                public const long m_hostageRescueX = 0x508;
                public const long m_hostageRescueY = 0x518;
                public const long m_hostageRescueZ = 0x528;
                public const long m_bombsiteCenterA = 0x4F0;
                public const long m_bombsiteCenterB = 0x4FC;
                public const long m_iHostageEntityIDs = 0x4C0;
                public const long m_foundGoalPositions = 0x539;
                public const long m_bEndMatchNextMapAllVoted = 0x538;
                public const long m_isHostageFollowingSomeone = 0x4B4;
            }
            public static partial class CChoreoInfoTarget {

            }
            public static partial class CCommentarySystem {
                public const long m_vecNodes = 0x48;
                public const long m_bCheatState = 0x1C;
                public const long m_hCurrentNode = 0x38;
                public const long m_iTeleportStage = 0x18;
                public const long m_ModifiedConvars = 0x20;
                public const long m_flNextTeleportTime = 0x14;
                public const long m_hLastCommentaryNode = 0x40;
                public const long m_hActiveCommentaryNode = 0x3C;
                public const long m_bIsFirstSpawnGroupToLoad = 0x1D;
                public const long m_bCommentaryEnabledMidGame = 0x12;
            }
            public static partial class CConstraintAnchor {
                public const long m_massScale = 0xA40;
            }
            public static partial class CDestructiblePart {
                public const long m_DebugName = 0x0;
                public const long m_nHitGroup = 0x8;
                public const long m_DamageLevels = 0x38;
                public const long m_sBodyGroupName = 0x30;
                public const long m_bOnlyDestroyWhenGibbing = 0x28;
                public const long m_bDisableHitGroupWhenDestroyed = 0xC;
                public const long m_nOtherHitgroupsToDestroyWhenFullyDestructed = 0x10;
            }
            public static partial class CEnvEntityIgniter {
                public const long m_flLifetime = 0x4A8;
            }
            public static partial class CFireCrackerBlast {

            }
            public static partial class CFuncShatterglass {
                public const long m_bBroken = 0x8E6;
                public const long m_OnBroken = 0x958;
                public const long m_PanelSize = 0x8C8;
                public const long m_bBreakSilent = 0x8E4;
                public const long m_bStartBroken = 0x8E9;
                public const long m_flInitAtTime = 0x8D8;
                public const long m_iSurfaceType = 0x970;
                public const long m_bGlassInFrame = 0x8E8;
                public const long m_bBreakShardless = 0x8E5;
                public const long m_bGlassNavIgnore = 0x8E7;
                public const long m_flGlassThickness = 0x8DC;
                public const long m_flLastCleanupTime = 0x8D4;
                public const long m_matPanelTransform = 0x850;
                public const long m_iInitialDamageType = 0x8EA;
                public const long m_hMaterialDamageBase = 0x978;
                public const long m_vExtraDamagePositions = 0x928;
                public const long m_vInitialPanelVertices = 0x940;
                public const long m_vecShatterGlassShards = 0x8B0;
                public const long m_flSpawnInvulnerability = 0x8E0;
                public const long m_matPanelTransformWsTemp = 0x880;
                public const long m_vInitialDamagePositions = 0x910;
                public const long m_flLastShatterSoundEmitTime = 0x8D0;
                public const long m_szDamagePositioningEntityName01 = 0x8F0;
                public const long m_szDamagePositioningEntityName02 = 0x8F8;
                public const long m_szDamagePositioningEntityName03 = 0x900;
                public const long m_szDamagePositioningEntityName04 = 0x908;
            }
            public static partial class CFuncVPhysicsClip {
                public const long m_bDisabled = 0x850;
            }
            public static partial class CHintMessageQueue {
                public const long m_messages = 0x8;
                public const long m_tmMessageEnd = 0x0;
                public const long m_pPlayerController = 0x20;
            }
            public static partial class CInfoChoreoAnchor {
                public const long m_vecTargetWarps = 0x4C0;
                public const long m_vecTargetEntries = 0x4A8;
            }
            public static partial class CLightOrthoEntity {

            }
            public static partial class CLogicAchievement {
                public const long m_OnFired = 0x4B8;
                public const long m_bDisabled = 0x4A8;
                public const long m_iszAchievementEventID = 0x4B0;
            }
            public static partial class CModelPointEntity {

            }
            public static partial class CNmSnapWeaponTask {

            }
            public static partial class CPathParticleRope {
                public const long m_flSlack = 0x4DC;
                public const long m_flRadius = 0x4E0;
                public const long m_ColorTint = 0x4E4;
                public const long m_bStartActive = 0x4B0;
                public const long m_iEffectIndex = 0x4F0;
                public const long m_nEffectState = 0x4E8;
                public const long m_iszEffectName = 0x4B8;
                public const long m_PathNodes_Name = 0x4C0;
                public const long m_PathNodes_Color = 0x540;
                public const long m_flParticleSpacing = 0x4D8;
                public const long m_PathNodes_Position = 0x4F8;
                public const long m_PathNodes_TangentIn = 0x510;
                public const long m_flMaxSimulationTime = 0x4B4;
                public const long m_PathNodes_PinEnabled = 0x558;
                public const long m_PathNodes_TangentOut = 0x528;
                public const long m_PathNodes_RadiusScale = 0x570;
            }
            public static partial class CPlayerSprayDecal {
                public const long m_nEntity = 0x894;
                public const long m_nHitbox = 0x898;
                public const long m_nPlayer = 0x890;
                public const long m_nTintID = 0x8A0;
                public const long m_vecLeft = 0x878;
                public const long m_nVersion = 0x8A4;
                public const long m_rtGcTime = 0x85C;
                public const long m_vecStart = 0x86C;
                public const long m_nUniqueID = 0x850;
                public const long m_unTraceID = 0x858;
                public const long m_vecEndPos = 0x860;
                public const long m_vecNormal = 0x884;
                public const long m_ubSignature = 0x8A5;
                public const long m_unAccountID = 0x854;
                public const long m_flCreationTime = 0x89C;
            }
            public static partial class CPlayerVisibility {
                public const long m_bIsEnabled = 0x4B9;
                public const long m_flFadeTime = 0x4B4;
                public const long m_bStartDisabled = 0x4B8;
                public const long m_flVisibilityStrength = 0x4A8;
                public const long m_flFogDistanceMultiplier = 0x4AC;
                public const long m_flFogMaxDensityMultiplier = 0x4B0;
            }
            public static partial class CPointAngleSensor {
                public const long m_bFired = 0x4CC;
                public const long m_TargetDir = 0x500;
                public const long m_bDisabled = 0x4A8;
                public const long m_flDuration = 0x4C0;
                public const long m_nLookAtName = 0x4B0;
                public const long m_flFacingTime = 0x4C8;
                public const long m_hLookAtEntity = 0x4BC;
                public const long m_hTargetEntity = 0x4B8;
                public const long m_OnFacingLookat = 0x4D0;
                public const long m_flDotTolerance = 0x4C4;
                public const long m_FacingPercentage = 0x528;
                public const long m_OnNotFacingLookat = 0x4E8;
            }
            public static partial class CPropDoorRotating {
                public const long m_angGoal = 0xEE4;
                public const long m_vecAxis = 0xE90;
                public const long m_flDistance = 0xE9C;
                public const long m_flAjarAngle = 0xEB0;
                public const long m_eOpenDirection = 0xEA4;
                public const long m_eSpawnPosition = 0xEA0;
                public const long m_hEntityBlocker = 0xF24;
                public const long m_vecBackBoundsMax = 0xF14;
                public const long m_vecBackBoundsMin = 0xF08;
                public const long m_angRotationClosed = 0xEC0;
                public const long m_angRotationOpenBack = 0xED8;
                public const long m_vecForwardBoundsMax = 0xEFC;
                public const long m_vecForwardBoundsMin = 0xEF0;
                public const long m_eCurrentOpenDirection = 0xEA8;
                public const long m_angRotationOpenForward = 0xECC;
                public const long m_eDefaultCheckDirection = 0xEAC;
                public const long m_angRotationAjarDeprecated = 0xEB4;
                public const long m_bAjarDoorShouldntAlwaysOpen = 0xF20;
            }
            public static partial class CRelativeLocation {
                public const long m_Type = 0x18;
                public const long m_hEntity = 0x34;
                public const long m_vWorldSpacePos = 0x28;
                public const long m_vRelativeOffset = 0x1C;
            }
            public static partial class CSPerRoundStats_t {
                public const long m_iKills = 0x30;
                public const long m_iDamage = 0x3C;
                public const long m_iDeaths = 0x34;
                public const long m_iAssists = 0x38;
                public const long m_iLiveTime = 0x4C;
                public const long m_iObjective = 0x54;
                public const long m_iCashEarned = 0x58;
                public const long m_iKillReward = 0x48;
                public const long m_iMoneySaved = 0x44;
                public const long m_iHeadShotKills = 0x50;
                public const long m_iUtilityDamage = 0x5C;
                public const long m_iEnemiesFlashed = 0x60;
                public const long m_iEquipmentValue = 0x40;
            }
            public static partial class CSceneListManager {
                public const long m_hScenes = 0x540;
                public const long m_iszScenes = 0x4C0;
                public const long m_hListManagers = 0x4A8;
            }
            public static partial class CScriptNavBlocker {
                public const long m_vExtent = 0x868;
            }
            public static partial class CScriptedSequence {
                public const long m_iszPlay = 0x4B8;
                public const long m_nMoveTo = 0x4E8;
                public const long m_flRadius = 0x514;
                public const long m_flRepeat = 0x518;
                public const long m_iszEntry = 0x4A8;
                public const long m_bThinking = 0x554;
                public const long m_flAngRate = 0x524;
                public const long m_hNextCine = 0x550;
                public const long m_iszEntity = 0x4D8;
                public const long m_startTime = 0x534;
                public const long m_hTargetEnt = 0x54C;
                public const long m_iszPreIdle = 0x4B0;
                public const long m_savedFlags = 0x540;
                public const long m_bForceSynch = 0x55D;
                public const long m_bSkipFadeIn = 0x6E8;
                public const long m_flMoveSpeed = 0x528;
                public const long m_iszPostIdle = 0x4C0;
                public const long m_nMoveToGait = 0x4EC;
                public const long m_iszSyncGroup = 0x4E0;
                public const long m_OnEndSequence = 0x598;
                public const long m_OnScriptEvent = 0x5F8;
                public const long m_bHighPriority = 0x503;
                public const long m_bIgnoreLookAt = 0x50A;
                public const long m_bIsRepeatable = 0x4FD;
                public const long m_bStartOnSpawn = 0x4FF;
                public const long m_hForcedTarget = 0x558;
                public const long m_iszNextScript = 0x4D0;
                public const long m_saved_effects = 0x53C;
                public const long m_bIgnoreGravity = 0x50B;
                public const long m_bInterruptable = 0x548;
                public const long m_matOtherToMain = 0x6C0;
                public const long m_OnBeginSequence = 0x568;
                public const long m_bIgnoreRotation = 0x510;
                public const long m_bIsPlayingEntry = 0x4F9;
                public const long m_bSynchPostIdles = 0x509;
                public const long m_onDeathBehavior = 0x560;
                public const long m_sequenceStarted = 0x549;
                public const long m_ConflictResponse = 0x564;
                public const long m_OnCancelSequence = 0x5C8;
                public const long m_bContinueOnDeath = 0x505;
                public const long m_bDontRotateOther = 0x4FC;
                public const long m_bIsPlayingAction = 0x4FA;
                public const long m_flMoveInterpTime = 0x520;
                public const long m_bDontAddModifiers = 0x50E;
                public const long m_bIsPlayingPreIdle = 0x4F8;
                public const long m_bDontTeleportAtEnd = 0x502;
                public const long m_bIsPlayingPostIdle = 0x4FB;
                public const long m_bShouldLeaveCorpse = 0x4FE;
                public const long m_nForcedCrouchState = 0x4F4;
                public const long m_OnActionStartOrLoop = 0x580;
                public const long m_bDisallowInterrupts = 0x500;
                public const long m_bLoopActionSequence = 0x507;
                public const long m_nHeldWeaponBehavior = 0x4F0;
                public const long m_savedCollisionGroup = 0x544;
                public const long m_bCanOverrideNPCState = 0x501;
                public const long m_bHideDebugComplaints = 0x504;
                public const long m_bInitiatedSelfDelete = 0x555;
                public const long m_bLoopPreIdleSequence = 0x506;
                public const long m_flPlayAnimFadeInTime = 0x51C;
                public const long m_iPlayerDeathBehavior = 0x6E4;
                public const long m_OnPostIdleEndSequence = 0x5B0;
                public const long m_bDisableNPCCollisions = 0x50C;
                public const long m_bLoopPostIdleSequence = 0x508;
                public const long m_bWaitForBeginSequence = 0x538;
                public const long m_OnCancelFailedSequence = 0x5E0;
                public const long m_hInteractionMainEntity = 0x6E0;
                public const long m_iszModifierToAddOnPlay = 0x4C8;
                public const long m_nNotReadySequenceCount = 0x530;
                public const long m_bEnsureOnNavmeshOnFinish = 0x55F;
                public const long m_bKeepAnimgraphLockedPost = 0x50D;
                public const long m_bDisableAimingWhileMoving = 0x50F;
                public const long m_bDontCancelOtherSequences = 0x55C;
                public const long m_bIsTeleportingDueToMoveTo = 0x556;
                public const long m_bPreventUpdateYawOnFinish = 0x55E;
                public const long m_bPositionRelativeToOtherEntity = 0x54A;
                public const long m_bAllowCustomInterruptConditions = 0x557;
                public const long m_bWaitUntilMoveCompletesToStartAnimation = 0x52C;
            }
            public static partial class CServerOnlyEntity {

            }
            public static partial class CSkeletonInstance {
                public const long m_modelState = 0x120;
                public const long m_nHitboxSet = 0x3BC;
                public const long m_materialGroup = 0x3B8;
                public const long m_bDirtyMotionType = 0x3B2;
                public const long m_bUseParentRenderBounds = 0x3B0;
                public const long m_bForceServerConstraintsEnabled = 0x41C;
                public const long m_bDisableSolidCollisionsForHierarchy = 0x3B1;
                public const long m_bIsGeneratingLatchedParentSpaceState = 0x3B3;
            }
            public static partial class CSoundEventEntity {
                public const long m_hSource = 0x55C;
                public const long m_bStopOnNew = 0x4AA;
                public const long m_bSaveRestore = 0x4AB;
                public const long m_iszSoundName = 0x540;
                public const long m_bStartOnSpawn = 0x4A8;
                public const long m_onGUIDChanged = 0x4C8;
                public const long m_bToLocalPlayer = 0x4A9;
                public const long m_bSavedIsPlaying = 0x4AC;
                public const long m_onSoundFinished = 0x4F8;
                public const long m_iszAttachmentName = 0x4C0;
                public const long m_flClientCullRadius = 0x510;
                public const long m_flSavedElapsedTime = 0x4B0;
                public const long m_iszSourceEntityName = 0x4B8;
                public const long m_nEntityIndexSelection = 0x560;
            }
            public static partial class CSplineConstraint {
                public const long m_pSplineBody = 0x568;
                public const long m_bEnableLimit = 0x573;
                public const long m_hSplineEntity = 0x564;
                public const long m_flJointFriction = 0x580;
                public const long m_flTransitionTime = 0x584;
                public const long m_bFireEventsOnPath = 0x574;
                public const long m_flLinearFrequency = 0x578;
                public const long m_vPreSolveAnchorPos = 0x598;
                public const long m_StartTransitionTime = 0x5A4;
                public const long m_flLinarDampingRatio = 0x57C;
                public const long m_vAnchorOffsetRestore = 0x558;
                public const long m_bEnableAngularConstraint = 0x572;
                public const long m_bEnableLateralConstraint = 0x570;
                public const long m_bEnableVerticalConstraint = 0x571;
                public const long m_vTangentSpaceAnchorAtTransitionStart = 0x5A8;
            }
            public static partial class CTakeDamageResult {
                public const long m_nHealthLost = 0x18;
                public const long m_nDamageFlags = 0x48;
                public const long m_flDamageDealt = 0x20;
                public const long m_nHealthBefore = 0x1C;
                public const long m_bSuppressFlinch = 0x51;
                public const long m_vDamagePosition = 0x28;
                public const long m_pOriginatingInfo = 0x0;
                public const long m_flPreModifiedDamage = 0x24;
                public const long m_nTotalledHealthLost = 0x34;
                public const long m_bWasDamageSuppressed = 0x50;
                public const long m_flTotalledDamageDealt = 0x38;
                public const long m_nOverrideFlinchHitGroup = 0x54;
                public const long m_flNewDamageAccumulatorValue = 0x40;
                public const long m_flTotalledPreModifiedDamage = 0x3C;
                public const long m_DestructibleHitGroupRequests = 0x8;
            }
            public static partial class CTankTargetChange {
                public const long m_newTarget = 0x4A8;
                public const long m_newTargetName = 0x4B8;
            }
            public static partial class CTriggerBombReset {

            }
            public static partial class CTriggerGameEvent {
                public const long m_strTriggerID = 0x9D8;
                public const long m_strEndTouchEventName = 0x9D0;
                public const long m_strStartTouchEventName = 0x9C8;
            }
            public static partial class CTriggerProximity {
                public const long m_fRadius = 0x9D8;
                public const long m_nTouchers = 0x9DC;
                public const long m_hMeasureTarget = 0x9C8;
                public const long m_iszMeasureTarget = 0x9D0;
                public const long m_NearestEntityDistance = 0x9E0;
            }
            public static partial class PhysBlockHeader_t {
                public const long nSaved = 0x0;
                public const long pWorldObject = 0x8;
            }
            public static partial class ResponseContext_t {
                public const long m_iszName = 0x0;
                public const long m_iszValue = 0x8;
                public const long m_fExpirationTime = 0x10;
            }
            public static partial class SPAWNGROUP_HEADER {
                public const long m_sGroupName = 0x0;
                public const long m_vecWorldOffset = 0x10;
                public const long m_sEntityLumpName = 0x8;
                public const long m_bClientSpawnGroup = 0x40;
                public const long m_bSuppressAllEntities = 0x41;
            }
            public static partial class SequenceHistory_t {
                public const long m_hSequence = 0x0;
                public const long m_nSeqLoopMode = 0xC;
                public const long m_flPlaybackRate = 0x10;
                public const long m_flSeqStartTime = 0x4;
                public const long m_flSeqFixedCycle = 0x8;
                public const long m_flCyclesPerSecond = 0x14;
            }
            public static partial class fogplayerparams_t {
                public const long m_hCtrl = 0x8;
                public const long m_NewColor = 0x28;
                public const long m_OldColor = 0x10;
                public const long m_flNewEnd = 0x30;
                public const long m_flOldEnd = 0x18;
                public const long m_flNewFarZ = 0x3C;
                public const long m_flOldFarZ = 0x24;
                public const long m_flNewStart = 0x2C;
                public const long m_flOldStart = 0x14;
                public const long m_flNewMaxDensity = 0x34;
                public const long m_flOldMaxDensity = 0x1C;
                public const long m_flTransitionTime = 0xC;
                public const long m_flNewHDRColorScale = 0x38;
                public const long m_flOldHDRColorScale = 0x20;
            }
            public static partial class modifiedconvars_t {
                public const long pszConvar = 0x0;
                public const long pszOrgValue = 0x100;
                public const long pszCurrentValue = 0x80;
            }
            public static partial class CCSCustomHudLayout {
                public const long m_strLayout = 0x4B8;
                public const long m_bObservable = 0x4C0;
                public const long m_vecPanelIds = 0x6C8;
                public const long m_vecClassNames = 0x6E0;
                public const long m_globalLayoutState = 0x530;
                public const long m_vecPlayerLayoutStates = 0x4C8;
                public const long m_vecDialogVariableNames = 0x6F8;
            }
            public static partial class CCSMinimapBoundary {

            }
            public static partial class CCSWeaponBaseVData {
                public const long m_nPrice = 0x70C;
                public const long m_szName = 0x720;
                public const long m_flRange = 0x830;
                public const long m_nDamage = 0x820;
                public const long m_GearSlot = 0x700;
                public const long m_flSpread = 0x750;
                public const long m_nZoomFOV1 = 0x7F8;
                public const long m_nZoomFOV2 = 0x7FC;
                public const long m_WeaponType = 0x520;
                public const long m_flMaxSpeed = 0x748;
                public const long m_nKillAward = 0x710;
                public const long m_bIsFullAuto = 0x72D;
                public const long m_bIsRevolver = 0x71E;
                public const long m_flCycleTime = 0x738;
                public const long m_flZoomTime0 = 0x800;
                public const long m_flZoomTime1 = 0x804;
                public const long m_flZoomTime2 = 0x808;
                public const long m_nNumBullets = 0x730;
                public const long m_nRecoilSeed = 0x7D4;
                public const long m_nSpreadSeed = 0x7D8;
                public const long m_nZoomLevels = 0x7F4;
                public const long m_szAnimClass = 0x868;
                public const long m_vSmokeColor = 0x85C;
                public const long m_bMeleeWeapon = 0x71C;
                public const long m_flArmorRatio = 0x828;
                public const long m_bHasBurstMode = 0x71D;
                public const long m_eSilencerType = 0x728;
                public const long m_flPenetration = 0x82C;
                public const long m_flRecoilAngle = 0x790;
                public const long m_vecMuzzlePos0 = 0x608;
                public const long m_vecMuzzlePos1 = 0x614;
                public const long m_WeaponCategory = 0x524;
                public const long m_bShowCrosshair = 0x72C;
                public const long m_flIronSightFOV = 0x814;
                public const long m_szAnimSkeleton = 0x528;
                public const long m_flRangeModifier = 0x834;
                public const long m_flThrowVelocity = 0x858;
                public const long m_nBurstShotCount = 0x7CC;
                public const long m_GearSlotPosition = 0x704;
                public const long m_flDeployDuration = 0x7C4;
                public const long m_flInaccuracyFire = 0x780;
                public const long m_flInaccuracyJump = 0x768;
                public const long m_flInaccuracyLand = 0x770;
                public const long m_flInaccuracyMove = 0x788;
                public const long m_nTracerFrequency = 0x7B0;
                public const long m_szTracerParticle = 0x620;
                public const long m_bUnzoomsAfterShot = 0x7F0;
                public const long m_flInaccuracyStand = 0x760;
                public const long m_flRecoilMagnitude = 0x7A0;
                public const long m_DefaultLoadoutSlot = 0x708;
                public const long m_bAllowBurstHolster = 0x7D0;
                public const long m_flInaccuracyCrouch = 0x758;
                public const long m_flInaccuracyLadder = 0x778;
                public const long m_flInaccuracyReload = 0x7C0;
                public const long m_szUseRadioSubtitle = 0x7E8;
                public const long m_flRecoveryTimeStand = 0x844;
                public const long m_bReloadsSingleShells = 0x734;
                public const long m_flHeadshotMultiplier = 0x824;
                public const long m_flInaccuracyJumpApex = 0x7BC;
                public const long m_flIronSightLooseness = 0x81C;
                public const long m_flRecoveryTimeCrouch = 0x840;
                public const long m_flRecoilAngleVariance = 0x798;
                public const long m_bCannotShootUnderwater = 0x71F;
                public const long m_flInaccuracyPitchShift = 0x7E0;
                public const long m_flIronSightPullUpSpeed = 0x80C;
                public const long m_nPrimaryReserveAmmoMax = 0x714;
                public const long m_flAttackMovespeedFactor = 0x7DC;
                public const long m_flInaccuracyJumpInitial = 0x7B8;
                public const long m_flIronSightPivotForward = 0x818;
                public const long m_flIronSightPutDownSpeed = 0x810;
                public const long m_flTimeBetweenBurstShots = 0x744;
                public const long m_bHideViewModelWhenZoomed = 0x7F1;
                public const long m_flRecoveryTimeStandFinal = 0x84C;
                public const long m_nSecondaryReserveAmmoMax = 0x718;
                public const long m_flRecoilMagnitudeVariance = 0x7A8;
                public const long m_flRecoveryTimeCrouchFinal = 0x848;
                public const long m_flCycleTimeWhenInBurstMode = 0x740;
                public const long m_nRecoveryTransitionEndBullet = 0x854;
                public const long m_flFlinchVelocityModifierLarge = 0x838;
                public const long m_flFlinchVelocityModifierSmall = 0x83C;
                public const long m_flInaccuracyAltSoundThreshold = 0x7E4;
                public const long m_nRecoveryTransitionStartBullet = 0x850;
                public const long m_flDisallowAttackAfterReloadStartDuration = 0x7C8;
            }
            public static partial class CCollisionProperty {
                public const long m_vecMaxs = 0x4C;
                public const long m_vecMins = 0x40;
                public const long m_nSolidType = 0x5B;
                public const long m_triggerBloat = 0x5C;
                public const long m_usSolidFlags = 0x5A;
                public const long m_nSurroundType = 0x5D;
                public const long m_CollisionGroup = 0x5E;
                public const long m_nEnablePhysics = 0x5F;
                public const long m_flCapsuleRadius = 0xAC;
                public const long m_vCapsuleCenter1 = 0x94;
                public const long m_vCapsuleCenter2 = 0xA0;
                public const long m_flBoundingRadius = 0x60;
                public const long m_collisionAttribute = 0x10;
                public const long m_vecSurroundingMaxs = 0x7C;
                public const long m_vecSurroundingMins = 0x88;
                public const long m_vecSpecifiedSurroundingMaxs = 0x70;
                public const long m_vecSpecifiedSurroundingMins = 0x64;
            }
            public static partial class CEconItemAttribute {
                public const long m_flValue = 0x34;
                public const long m_bSetBonus = 0x40;
                public const long m_flInitialValue = 0x38;
                public const long m_nRefundableCurrency = 0x3C;
                public const long m_iAttributeDefinitionIndex = 0x30;
            }
            public static partial class CEnableMotionFixup {

            }
            public static partial class CEnvInstructorHint {
                public const long m_Color = 0x4E8;
                public const long m_fRange = 0x4F0;
                public const long m_bStatic = 0x4F7;
                public const long m_iszName = 0x4A8;
                public const long m_iTimeout = 0x4C0;
                public const long m_bAutoStart = 0x511;
                public const long m_iszBinding = 0x508;
                public const long m_iszCaption = 0x4D8;
                public const long m_fIconOffset = 0x4EC;
                public const long m_bNoOffscreen = 0x4F8;
                public const long m_iAlphaOption = 0x4F5;
                public const long m_iPulseOption = 0x4F4;
                public const long m_iShakeOption = 0x4F6;
                public const long m_bForceCaption = 0x4F9;
                public const long m_bSuppressRest = 0x500;
                public const long m_iDisplayLimit = 0x4C4;
                public const long m_iInstanceType = 0x4FC;
                public const long m_iszReplace_Key = 0x4B0;
                public const long m_bLocalPlayerOnly = 0x512;
                public const long m_iszIcon_Onscreen = 0x4C8;
                public const long m_iszIcon_Offscreen = 0x4D0;
                public const long m_bAllowNoDrawTarget = 0x510;
                public const long m_iszActivatorCaption = 0x4E0;
                public const long m_iszHintTargetEntity = 0x4B8;
            }
            public static partial class CExplosionTypeData {
                public const long m_DecalType = 0xF8;
                public const long m_SoundName = 0x0;
                public const long m_bHasForces = 0xF1;
                public const long m_bIsIncindiary = 0xF0;
                public const long m_ParticleEffect = 0x10;
            }
            public static partial class CFilterMassGreater {
                public const long m_fFilterMass = 0x4E0;
            }
            public static partial class CFuncRetakeBarrier {

            }
            public static partial class CFuncTrainControls {

            }
            public static partial class CGenericConstraint {
                public const long m_bAxisNotifiedX = 0x58C;
                public const long m_bAxisNotifiedY = 0x58D;
                public const long m_bAxisNotifiedZ = 0x58E;
                public const long m_flNotifyForceX = 0x568;
                public const long m_flNotifyForceY = 0x56C;
                public const long m_flNotifyForceZ = 0x570;
                public const long m_nLinearMotionX = 0x514;
                public const long m_nLinearMotionY = 0x518;
                public const long m_nLinearMotionZ = 0x51C;
                public const long m_nAngularMotionX = 0x590;
                public const long m_nAngularMotionY = 0x594;
                public const long m_nAngularMotionZ = 0x598;
                public const long m_flBreakAfterTimeX = 0x544;
                public const long m_flBreakAfterTimeY = 0x548;
                public const long m_flBreakAfterTimeZ = 0x54C;
                public const long m_flLinearFrequencyX = 0x520;
                public const long m_flLinearFrequencyY = 0x524;
                public const long m_flLinearFrequencyZ = 0x528;
                public const long m_NotifyForceReachedX = 0x5C0;
                public const long m_NotifyForceReachedY = 0x5D8;
                public const long m_NotifyForceReachedZ = 0x5F0;
                public const long m_flAngularFrequencyX = 0x59C;
                public const long m_flAngularFrequencyY = 0x5A0;
                public const long m_flAngularFrequencyZ = 0x5A4;
                public const long m_flMaxLinearImpulseX = 0x538;
                public const long m_flMaxLinearImpulseY = 0x53C;
                public const long m_flMaxLinearImpulseZ = 0x540;
                public const long m_flMaxAngularImpulseX = 0x5B4;
                public const long m_flMaxAngularImpulseY = 0x5B8;
                public const long m_flMaxAngularImpulseZ = 0x5BC;
                public const long m_flLinearDampingRatioX = 0x52C;
                public const long m_flLinearDampingRatioY = 0x530;
                public const long m_flLinearDampingRatioZ = 0x534;
                public const long m_flNotifyForceMinTimeX = 0x574;
                public const long m_flNotifyForceMinTimeY = 0x578;
                public const long m_flNotifyForceMinTimeZ = 0x57C;
                public const long m_flAngularDampingRatioX = 0x5A8;
                public const long m_flAngularDampingRatioY = 0x5AC;
                public const long m_flAngularDampingRatioZ = 0x5B0;
                public const long m_flNotifyForceLastTimeX = 0x580;
                public const long m_flNotifyForceLastTimeY = 0x584;
                public const long m_flNotifyForceLastTimeZ = 0x588;
                public const long m_flBreakAfterTimeStartTimeX = 0x550;
                public const long m_flBreakAfterTimeStartTimeY = 0x554;
                public const long m_flBreakAfterTimeStartTimeZ = 0x558;
                public const long m_flBreakAfterTimeThresholdX = 0x55C;
                public const long m_flBreakAfterTimeThresholdY = 0x560;
                public const long m_flBreakAfterTimeThresholdZ = 0x564;
                public const long m_bPlaceAnchorsAtConstraintTransform = 0x510;
            }
            public static partial class CHostageRescueZone {

            }
            public static partial class CIncendiaryGrenade {

            }
            public static partial class CInfoVisibilityBox {
                public const long m_nMode = 0x4AC;
                public const long m_bEnabled = 0x4BC;
                public const long m_vBoxSize = 0x4B0;
            }
            public static partial class CLogicLineToEntity {
                public const long m_Line = 0x4A8;
                public const long m_EndEntity = 0x4DC;
                public const long m_SourceName = 0x4D0;
                public const long m_StartEntity = 0x4D8;
            }
            public static partial class CMolotovProjectile {
                public const long m_bDetonated = 0xB58;
                public const long m_stillTimer = 0xB60;
                public const long m_bIsIncGrenade = 0xB40;
            }
            public static partial class CPointEntityFinder {
                public const long m_hEntity = 0x4A8;
                public const long m_hFilter = 0x4B8;
                public const long m_iRefName = 0x4C0;
                public const long m_FindMethod = 0x4CC;
                public const long m_hReference = 0x4C8;
                public const long m_iFilterName = 0x4B0;
                public const long m_OnFoundEntity = 0x4D0;
            }
            public static partial class CPropDataComponent {
                public const long m_flDmgModClub = 0x14;
                public const long m_flDmgModFire = 0x1C;
                public const long m_nInteractions = 0x30;
                public const long m_flDmgModBullet = 0x10;
                public const long m_iszBasePropData = 0x28;
                public const long m_flDmgModExplosive = 0x18;
                public const long m_bSpawnMotionDisabled = 0x34;
                public const long m_nMotionDisabledSpawnFlag = 0x3C;
                public const long m_iszPhysicsDamageTableName = 0x20;
                public const long m_nDisableTakePhysicsDamageSpawnFlag = 0x38;
            }
            public static partial class CPulseCell_Unknown {
                public const long m_UnknownKeys = 0x48;
            }
            public static partial class CPulseServerCursor {
                public const long m_hCaller = 0xEC;
                public const long m_hActivator = 0xE8;
            }
            public static partial class CPulse_ResumePoint {

            }
            public static partial class CRagdollConstraint {
                public const long m_xmax = 0x50C;
                public const long m_xmin = 0x508;
                public const long m_ymax = 0x514;
                public const long m_ymin = 0x510;
                public const long m_zmax = 0x51C;
                public const long m_zmin = 0x518;
                public const long m_xfriction = 0x520;
                public const long m_yfriction = 0x524;
                public const long m_zfriction = 0x528;
            }
            public static partial class CRelativeTransform {
                public const long m_hEntity = 0x50;
                public const long m_transform = 0x10;
                public const long m_transformWS = 0x30;
                public const long m_bTransformIsWorldSpace = 0x0;
            }
            public static partial class CScriptTriggerHurt {
                public const long m_vExtent = 0xA50;
            }
            public static partial class CScriptTriggerOnce {
                public const long m_vExtent = 0x9E0;
            }
            public static partial class CScriptTriggerPush {
                public const long m_vExtent = 0xA00;
            }
            public static partial class CShatterGlassShard {
                public const long m_flArea = 0x6C;
                public const long m_hModel = 0x30;
                public const long m_hParentPanel = 0x3C;
                public const long m_hParentShard = 0x40;
                public const long m_hShardHandle = 0x8;
                public const long m_nOnFrameEdge = 0x70;
                public const long m_vecNeighbors = 0xA0;
                public const long m_bCreatedModel = 0x54;
                public const long m_flLongestEdge = 0x58;
                public const long m_flShortestEdge = 0x5C;
                public const long m_hPhysicsEntity = 0x38;
                public const long m_flLongestAcross = 0x60;
                public const long m_flSumOfAllEdges = 0x68;
                public const long m_flShortestAcross = 0x64;
                public const long m_hEntityHittingMe = 0x9C;
                public const long m_vecPanelVertices = 0x10;
                public const long m_ShatterStressType = 0x44;
                public const long m_vecStressVelocity = 0x48;
                public const long m_bFlaggedForRemoval = 0x96;
                public const long m_nSubShardGeneration = 0x74;
                public const long m_vLocalPanelSpaceOrigin = 0x28;
                public const long m_vecAverageVertPosition = 0x78;
                public const long m_bStressPositionAIsValid = 0x94;
                public const long m_bStressPositionBIsValid = 0x95;
                public const long m_bAverageVertPositionIsValid = 0x80;
                public const long m_flPhysicsEntitySpawnedAtTime = 0x98;
                public const long m_vecPanelSpaceStressPositionA = 0x84;
                public const long m_vecPanelSpaceStressPositionB = 0x8C;
            }
            public static partial class CTriggerLerpObject {
                public const long m_OnDetached = 0xA50;
                public const long m_hLerpTarget = 0x9D0;
                public const long m_iszLerpSound = 0xA10;
                public const long m_OnLerpStarted = 0xA20;
                public const long m_iszLerpEffect = 0xA08;
                public const long m_iszLerpTarget = 0x9C8;
                public const long m_OnLerpFinished = 0xA38;
                public const long m_flLerpDuration = 0x9E4;
                public const long m_bSingleLerpObject = 0x9EA;
                public const long m_vecLerpingObjects = 0x9F0;
                public const long m_bLerpRestoreMoveType = 0x9E9;
                public const long m_bAttachTouchingObject = 0xA18;
                public const long m_hLerpTargetAttachment = 0x9E0;
                public const long m_iszLerpTargetAttachment = 0x9D8;
                public const long m_bAttachedEntityWasParented = 0x9E8;
                public const long m_hEntityToWaitForDisconnect = 0xA1C;
            }
            public static partial class CTriggerSoundscape {
                public const long m_spectators = 0x9D8;
                public const long m_hSoundscape = 0x9C8;
                public const long m_SoundscapeName = 0x9D0;
            }
            public static partial class CWeaponUSPSilencer {

            }
            public static partial class DecalGroupOption_t {
                public const long m_hMaterial = 0x0;
                public const long m_flProbability = 0x10;
                public const long m_sSequenceName = 0x8;
                public const long m_flMaxAngleBetweenNormalAndGravity = 0x1C;
                public const long m_flMinAngleBetweenNormalAndGravity = 0x18;
                public const long m_bEnableAngleBetweenNormalAndGravityRange = 0x14;
            }
            public static partial class DynamicVolumeDef_t {
                public const long m_source = 0x0;
                public const long m_target = 0x4;
                public const long m_nAreaDst = 0x28;
                public const long m_nAreaSrc = 0x24;
                public const long m_nHullIdx = 0x8;
                public const long m_bAttached = 0x2C;
                public const long m_vSourceAnchorPos = 0xC;
                public const long m_vTargetAnchorPos = 0x18;
            }
            public static partial class GameAmmoTypeInfo_t {
                public const long m_nCost = 0x3C;
                public const long m_nBuySize = 0x38;
            }
            public static partial class HUDPanelHasClass_t {
                public const long m_eClassStatus = 0x4;
                public const long m_nPanelIdIndex = 0x0;
                public const long m_nClassNameIndex = 0x2;
            }
            public static partial class IEconItemInterface {

            }
            public static partial class PhysObjectHeader_t {
                public const long bbox = 0x20;
                public const long _type = 0x0;
                public const long sphere = 0x38;
                public const long hEntity = 0x4;
                public const long iCollide = 0x3C;
                public const long fieldName = 0x8;
                public const long modelName = 0x18;
                public const long bSaveObject = 0x10;
            }
            public static partial class QueuedAISearchId_t {
                public const long m_Value = 0x0;
            }
            public static partial class dynpitchvol_base_t {
                public const long vol = 0x4C;
                public const long pitch = 0x3C;
                public const long fadein = 0x1C;
                public const long preset = 0x0;
                public const long spinup = 0xC;
                public const long volrun = 0x14;
                public const long cspinup = 0x34;
                public const long fadeout = 0x20;
                public const long lfofrac = 0x5C;
                public const long lfomult = 0x60;
                public const long lforate = 0x28;
                public const long lfotype = 0x24;
                public const long volfrac = 0x58;
                public const long pitchrun = 0x4;
                public const long spindown = 0x10;
                public const long volstart = 0x18;
                public const long fadeinsav = 0x50;
                public const long lfomodvol = 0x30;
                public const long pitchfrac = 0x48;
                public const long spinupsav = 0x40;
                public const long cspincount = 0x38;
                public const long fadeoutsav = 0x54;
                public const long pitchstart = 0x8;
                public const long lfomodpitch = 0x2C;
                public const long spindownsav = 0x44;
            }
            public static partial class shard_model_desc_t {
                public const long m_solid = 0x20;
                public const long m_nModelID = 0x8;
                public const long m_bHasParent = 0x74;
                public const long m_vecPanelSize = 0x24;
                public const long m_bParentFrozen = 0x75;
                public const long m_hMaterialBase = 0x10;
                public const long m_vecPanelVertices = 0x40;
                public const long m_vecStressPositionA = 0x2C;
                public const long m_vecStressPositionB = 0x34;
                public const long m_flGlassHalfThickness = 0x70;
                public const long m_vInitialPanelVertices = 0x58;
                public const long m_SurfacePropStringToken = 0x78;
                public const long m_hMaterialDamageOverlay = 0x18;
            }
            public static partial class ActiveModelConfig_t {
                public const long m_Name = 0x38;
                public const long m_Handle = 0x30;
                public const long m_AssociatedEntities = 0x40;
                public const long m_AssociatedEntityNames = 0x58;
                public const long m_vecAssociatedEntityCollidesWithHierarchy = 0x70;
                public const long m_vecAssociatedEntityCollidesOutsideHierarchy = 0x80;
            }
            public static partial class CAI_ChangeHintGroup {
                public const long m_flRadius = 0x4C0;
                public const long m_iSearchType = 0x4A8;
                public const long m_strSearchName = 0x4B0;
                public const long m_strNewHintGroup = 0x4B8;
            }
            public static partial class CAttributeContainer {
                public const long m_Item = 0x50;
            }
            public static partial class CBaseClientUIEntity {
                public const long m_PanelID = 0x868;
                public const long m_bEnabled = 0x850;
                public const long m_CustomOutput0 = 0x870;
                public const long m_CustomOutput1 = 0x890;
                public const long m_CustomOutput2 = 0x8B0;
                public const long m_CustomOutput3 = 0x8D0;
                public const long m_CustomOutput4 = 0x8F0;
                public const long m_CustomOutput5 = 0x910;
                public const long m_CustomOutput6 = 0x930;
                public const long m_CustomOutput7 = 0x950;
                public const long m_CustomOutput8 = 0x970;
                public const long m_CustomOutput9 = 0x990;
                public const long m_DialogXMLName = 0x858;
                public const long m_PanelClassName = 0x860;
            }
            public static partial class CBodyComponentPoint {
                public const long m_sceneNode = 0x80;
            }
            public static partial class CCSPlayerController {
                public const long m_iMVPs = 0x940;
                public const long m_iPing = 0x808;
                public const long m_iScore = 0x91C;
                public const long m_szClan = 0x840;
                public const long m_bShowHints = 0x968;
                public const long m_eMvpReason = 0x934;
                public const long m_iPawnArmor = 0x904;
                public const long m_iRoundsWon = 0x924;
                public const long m_nFirstKill = 0x930;
                public const long m_nKillCount = 0x931;
                public const long m_bMvpNoMusic = 0x932;
                public const long m_hPlayerPawn = 0x8EC;
                public const long m_iDraftIndex = 0x8B8;
                public const long m_iMusicKitID = 0x938;
                public const long m_iPawnHealth = 0x900;
                public const long m_iRoundScore = 0x920;
                public const long m_bPawnIsAlive = 0x8FC;
                public const long m_bTeamChanged = 0x834;
                public const long m_bInSwitchTeam = 0x835;
                public const long m_hObserverPawn = 0x8F0;
                public const long m_iCoachingTeam = 0x84C;
                public const long m_iMusicKitMVPs = 0x93C;
                public const long m_unClanId32bit = 0x848;
                public const long m_bPawnHasHelmet = 0x909;
                public const long m_bScoreReported = 0x8CD;
                public const long m_flSmoothedPing = 0x948;
                public const long m_iNextTimeCheck = 0x96C;
                public const long m_nUpdateCounter = 0x944;
                public const long m_bCannotBeKicked = 0x8C8;
                public const long m_bControllingBot = 0x8E0;
                public const long m_bPawnHasDefuser = 0x908;
                public const long m_flForceTeamTime = 0x824;
                public const long m_iPendingTeamNum = 0x820;
                public const long m_pDamageServices = 0x800;
                public const long m_recentKillQueue = 0x928;
                public const long m_unActiveQuestId = 0x87C;
                public const long m_bHasSeenJoinGame = 0x836;
                public const long m_bJustDidTeamKill = 0x970;
                public const long m_iCompetitiveWins = 0x864;
                public const long m_iPawnLifetimeEnd = 0x910;
                public const long m_nPlayerDominated = 0x850;
                public const long m_szCrosshairCodes = 0x818;
                public const long m_bEverPlayedOnTeam = 0x82C;
                public const long m_lastHeldVoteTimer = 0x950;
                public const long m_bPunishForTeamKill = 0x971;
                public const long m_flLastJoinTeamTime = 0x83C;
                public const long m_iCompTeammateColor = 0x828;
                public const long m_iPawnBotDifficulty = 0x914;
                public const long m_iPawnLifetimeStart = 0x90C;
                public const long m_nDisconnectionTick = 0x8D0;
                public const long m_pInventoryServices = 0x7F0;
                public const long m_DesiredObserverMode = 0x8F4;
                public const long m_bEverFullyConnected = 0x8C9;
                public const long m_iCompetitiveRanking = 0x860;
                public const long m_nPlayerDominatingMe = 0x858;
                public const long m_nSuspiciousHitCount = 0x988;
                public const long m_bAttemptedToGetColor = 0x82D;
                public const long m_bJustBecameSpectator = 0x837;
                public const long m_iCompetitiveRankType = 0x868;
                public const long m_nEndMatchNextMapVote = 0x878;
                public const long m_nQuestProgressReason = 0x884;
                public const long m_pInGameMoneyServices = 0x7E8;
                public const long m_rtActiveMissionPeriod = 0x880;
                public const long m_bCanControlObservedBot = 0x8E8;
                public const long m_bGaveTeamDamageWarning = 0x972;
                public const long m_hDesiredObserverTarget = 0x8F8;
                public const long m_nPawnCharacterDefIndex = 0x90A;
                public const long m_unPlayerTvControlFlags = 0x888;
                public const long m_bAbandonAllowsSurrender = 0x8CA;
                public const long m_iTeammatePreferredColor = 0x830;
                public const long m_nNonSuspiciousHitStreak = 0x98C;
                public const long m_pActionTrackingServices = 0x7F8;
                public const long m_uiAbandonRecordedReason = 0x8C0;
                public const long m_nBotsControlledThisRound = 0x8E4;
                public const long m_uiCommunicationMuteFlags = 0x810;
                public const long m_LastTeamDamageWarningTime = 0x980;
                public const long m_bHasCommunicationAbuseMute = 0x80C;
                public const long m_bHasControlledBotThisRound = 0x8E1;
                public const long m_eNetworkDisconnectionReason = 0x8C4;
                public const long m_bFireBulletsSeedSynchronized = 0xA39;
                public const long m_bSwitchTeamsOnNextRoundReset = 0x838;
                public const long m_bAbandonOffersInstantSurrender = 0x8CB;
                public const long m_bGaveTeamDamageWarningThisRound = 0x973;
                public const long m_bRemoveAllItemsOnNextRoundReset = 0x839;
                public const long m_bDisconnection1MinWarningPrinted = 0x8CC;
                public const long m_hOriginalControllerOfCurrentPawn = 0x918;
                public const long m_iCompetitiveRankingPredicted_Tie = 0x874;
                public const long m_iCompetitiveRankingPredicted_Win = 0x86C;
                public const long m_iCompetitiveRankingPredicted_Loss = 0x870;
                public const long m_dblLastReceivedPacketPlatFloatTime = 0x978;
                public const long m_msQueuedModeDisconnectionTimestamp = 0x8BC;
                public const long m_bHasBeenControlledByPlayerThisRound = 0x8E2;
                public const long m_LastTimePlayerWasDisconnectedForPawnsRemove = 0x984;
            }
            public static partial class CCSPlayerLegacyJump {
                public const long m_bOldJumpPressed = 0x10;
                public const long m_flJumpPressedTime = 0x14;
            }
            public static partial class CCSPlayerModernJump {
                public const long m_nLastLandedTick = 0x20;
                public const long m_flLastLandedFrac = 0x24;
                public const long m_flLastLandedVelocityX = 0x28;
                public const long m_flLastLandedVelocityY = 0x2C;
                public const long m_flLastLandedVelocityZ = 0x30;
                public const long m_nLastActualJumpPressTick = 0x10;
                public const long m_nLastUsableJumpPressTick = 0x18;
                public const long m_flLastActualJumpPressFrac = 0x14;
                public const long m_flLastUsableJumpPressFrac = 0x1C;
            }
            public static partial class CEnvSoundscapeProxy {
                public const long m_MainSoundscapeName = 0x538;
            }
            public static partial class CFilterAttributeInt {
                public const long m_sAttributeName = 0x4E0;
            }
            public static partial class CFloatMovingAverage {

            }
            public static partial class CFuncNavObstruction {
                public const long m_bDisabled = 0x868;
                public const long m_bUseAsyncObstacleUpdate = 0x869;
            }
            public static partial class CGameChoreoServices {
                public const long m_hOwner = 0x8;
                public const long m_choreoState = 0x14;
                public const long m_scriptState = 0x10;
                public const long m_hScriptedSequence = 0xC;
                public const long m_flTimeStartedState = 0x18;
            }
            public static partial class CInfoGameEventProxy {
                public const long m_flRange = 0x4B0;
                public const long m_iszEventName = 0x4A8;
            }
            public static partial class CInfoLadderDismount {

            }
            public static partial class CInfoParticleTarget {

            }
            public static partial class CLogicActivityEvent {
                public const long m_hSource = 0x4B8;
                public const long m_flDuration = 0x4AC;
                public const long m_nEventType = 0x4A8;
                public const long m_iszSourceEntityName = 0x4B0;
            }
            public static partial class CLogicCollisionPair {
                public const long m_disabled = 0x4BA;
                public const long m_succeeded = 0x4BB;
                public const long m_nameAttach1 = 0x4A8;
                public const long m_nameAttach2 = 0x4B0;
                public const long m_allowMissing = 0x4BC;
                public const long m_includeHierarchy = 0x4B8;
                public const long m_supportMultipleEntitiesWithSameName = 0x4B9;
            }
            public static partial class CLogicDistanceCheck {
                public const long m_InZone1 = 0x4C0;
                public const long m_InZone2 = 0x4D8;
                public const long m_InZone3 = 0x4F0;
                public const long m_iszEntityA = 0x4A8;
                public const long m_iszEntityB = 0x4B0;
                public const long m_flZone1Distance = 0x4B8;
                public const long m_flZone2Distance = 0x4BC;
            }
            public static partial class CLogicEventListener {
                public const long m_nTeam = 0x4C4;
                public const long m_bIsEnabled = 0x4C0;
                public const long m_OnEventFired = 0x4C8;
                public const long m_strEventName = 0x4B8;
            }
            public static partial class CLogicNPCCounterOBB {

            }
            public static partial class CMarkupSearchHelper {
                public const long m_bActive = 0x26;
                public const long m_navHull = 0x0;
                public const long m_vRefPos = 0x18;
                public const long m_tagString = 0x8;
                public const long m_bRefPosSet = 0x24;
                public const long m_nameString = 0x10;
                public const long m_bUseStepHeight = 0x25;
            }
            public static partial class CMarkupVolumeTagged {
                public const long m_Tags = 0x870;
                public const long m_bIsGroup = 0x888;
                public const long m_GroupNames = 0x858;
                public const long m_bIsInGroup = 0x88C;
                public const long m_bGroupByPrefab = 0x889;
                public const long m_bGroupByVolume = 0x88A;
                public const long m_bGroupOtherGroups = 0x88B;
            }
            public static partial class CMomentaryRotButton {
                public const long m_end = 0xA60;
                public const long m_start = 0xA54;
                public const long m_sNoise = 0xA70;
                public const long m_IdealYaw = 0xA6C;
                public const long m_Position = 0x9D0;
                public const long m_lastUsed = 0xA50;
                public const long m_direction = 0xA7C;
                public const long m_OnFullyOpen = 0xA08;
                public const long m_OnUnpressed = 0x9F0;
                public const long m_returnSpeed = 0xA80;
                public const long m_OnFullyClosed = 0xA20;
                public const long m_bUpdateTarget = 0xA78;
                public const long m_flStartPosition = 0xA84;
                public const long m_OnReachedPosition = 0xA38;
            }
            public static partial class CNavHullPresetVData {
                public const long m_vecNavHulls = 0x0;
            }
            public static partial class CPathQueryComponent {

            }
            public static partial class CPlayer_UseServices {

            }
            public static partial class CPointChildModifier {
                public const long m_bOrphanInsteadOfDeletingChildrenOnRemove = 0x4A8;
            }
            public static partial class CPointClientCommand {

            }
            public static partial class CPointServerCommand {

            }
            public static partial class CPointValueRemapper {
                public const long m_OnEngage = 0x620;
                public const long m_Position = 0x598;
                public const long m_bEngaged = 0x538;
                public const long m_bDisabled = 0x4A8;
                public const long m_nInputType = 0x4AC;
                public const long m_OnDisengage = 0x638;
                public const long m_flSnapValue = 0x524;
                public const long m_nOutputType = 0x4D8;
                public const long m_bFirstUpdate = 0x539;
                public const long m_hUsingPlayer = 0x550;
                public const long m_nHapticsType = 0x518;
                public const long m_nRatchetType = 0x52C;
                public const long m_PositionDelta = 0x5B8;
                public const long m_flInputOffset = 0x534;
                public const long m_hRemapLineEnd = 0x4C4;
                public const long m_nMomentumType = 0x51C;
                public const long m_iszSoundEngage = 0x558;
                public const long m_bRequiresUseKey = 0x4D4;
                public const long m_bUpdateOnClient = 0x4A9;
                public const long m_flPreviousValue = 0x53C;
                public const long m_flRatchetOffset = 0x530;
                public const long m_hOutputEntities = 0x500;
                public const long m_hRemapLineStart = 0x4C0;
                public const long m_flEngageDistance = 0x4D0;
                public const long m_OnReachedValueOne = 0x5F0;
                public const long m_flCurrentMomentum = 0x528;
                public const long m_iszSoundDisengage = 0x560;
                public const long m_OnReachedValueZero = 0x5D8;
                public const long m_flMomentumModifier = 0x520;
                public const long m_iszSoundMovingLoop = 0x578;
                public const long m_flCustomOutputValue = 0x554;
                public const long m_flDisengageDistance = 0x4CC;
                public const long m_iszOutputEntityName = 0x4E0;
                public const long m_iszRemapLineEndName = 0x4B8;
                public const long m_OnReachedValueCustom = 0x608;
                public const long m_iszOutputEntity2Name = 0x4E8;
                public const long m_iszOutputEntity3Name = 0x4F0;
                public const long m_iszOutputEntity4Name = 0x4F8;
                public const long m_vecPreviousTestPoint = 0x544;
                public const long m_iszRemapLineStartName = 0x4B0;
                public const long m_iszSoundReachedValueOne = 0x570;
                public const long m_flMaximumChangePerSecond = 0x4C8;
                public const long m_flPreviousUpdateTickTime = 0x540;
                public const long m_iszSoundReachedValueZero = 0x568;
            }
            public static partial class CPrecipitationVData {
                public const long m_nRTEnvCP = 0x2D4;
                public const long m_szModifier = 0x2E0;
                public const long m_nAttachType = 0x2CC;
                public const long m_snapshotFilter = 0x2EC;
                public const long m_flInnerDistance = 0x2C8;
                public const long m_nRTEnvCPComponent = 0x2D8;
                public const long m_bBatchSameVolumeType = 0x2D0;
                public const long m_nUseSnapshotFromSurfaceGraph = 0x2E8;
                public const long m_szParticlePrecipitationEffect = 0x28;
                public const long m_szParticlePrecipitationPostEffect = 0x1E8;
                public const long m_szParticlePrecipitationPuddleEffect = 0x108;
            }
            public static partial class CPulseCell_BaseFlow {

            }
            public static partial class CPulseCell_BaseLerp {
                public const long m_WakeResume = 0xD8;
            }
            public static partial class CPulseCell_Timeline {
                public const long m_OnFinished = 0xF8;
                public const long m_TimelineEvents = 0xD8;
                public const long m_bWaitForChildOutflows = 0xF0;
            }
            public static partial class CTonemapController2 {
                public const long m_flAutoExposureMax = 0x4AC;
                public const long m_flAutoExposureMin = 0x4A8;
                public const long m_flTonemapEVSmoothingRange = 0x4B8;
                public const long m_flExposureAdaptationSpeedUp = 0x4B0;
                public const long m_flExposureAdaptationSpeedDown = 0x4B4;
            }
            public static partial class CTriggerSndSosOpvar {
                public const long m_bVolIs2D = 0xA10;
                public const long m_flMaxVal = 0x9F4;
                public const long m_flMinVal = 0x9F0;
                public const long m_opvarName = 0x9F8;
                public const long m_stackName = 0xA00;
                public const long m_VecNormPos = 0xD14;
                public const long m_flPosition = 0x9E0;
                public const long m_flCenterSize = 0x9EC;
                public const long m_operatorName = 0xA08;
                public const long m_opvarNameChar = 0xA11;
                public const long m_stackNameChar = 0xB11;
                public const long m_flNormCenterSize = 0xD20;
                public const long m_hTouchingPlayers = 0x9C8;
                public const long m_operatorNameChar = 0xC11;
            }
            public static partial class CWeaponM4A1Silencer {

            }
            public static partial class ConstraintSoundInfo {
                public const long m_vSampler = 0x8;
                public const long m_forwardAxis = 0x40;
                public const long m_soundProfile = 0x20;
                public const long m_bPlayTravelSound = 0x90;
                public const long m_iszTravelSoundFwd = 0x50;
                public const long m_bPlayReversalSound = 0x91;
                public const long m_iszTravelSoundBack = 0x58;
                public const long m_iszReversalSoundLarge = 0x88;
                public const long m_iszReversalSoundSmall = 0x78;
                public const long m_iszReversalSoundMedium = 0x80;
            }
            public static partial class ModelConfigHandle_t {
                public const long m_Value = 0x0;
            }
            public static partial class magnetted_objects_t {
                public const long hEntity = 0x8;
            }
            public static partial class sndopvarlatchdata_t {
                public const long m_vPos = 0x24;
                public const long m_flVal = 0x20;
                public const long m_iszOpvar = 0x18;
                public const long m_iszStack = 0x8;
                public const long m_iszOperator = 0x10;
            }
            public static partial class CBaseCombatCharacter {
                public const long m_eHull = 0xAC8;
                public const long m_nNavHullIdx = 0xACC;
                public const long m_hMyWearables = 0xA48;
                public const long m_movementStats = 0xAD0;
                public const long m_strRelationships = 0xAC0;
                public const long m_vecRelationships = 0xAA8;
                public const long m_impactEnergyScale = 0xA60;
                public const long m_bApplyStressDamage = 0xA64;
                public const long m_bForceServerRagdoll = 0xA40;
                public const long m_bDeathEventsDispatched = 0xA65;
            }
            public static partial class CCSObservableElement {
                public const long m_nTeamFilter = 0x4D0;
                public const long m_hObservableModelEntity = 0x4C8;
                public const long m_hObservableModelEntity2 = 0x4CC;
                public const long m_iszObservableModelEntity = 0x4C0;
            }
            public static partial class CCSPointScriptEntity {

            }
            public static partial class CCSWeaponBaseShotgun {

            }
            public static partial class CCopyRecipientFilter {
                public const long m_Flags = 0x8;
                public const long m_Recipients = 0x10;
                public const long m_slotPlayerExcludedDueToPrediction = 0x30;
            }
            public static partial class CDebugSnapshotData_t {
                public const long m_text = 0x0;
                public const long m_hEntity = 0x100;
                public const long m_children = 0x120;
                public const long m_dataType = 0x8;
                public const long m_userData = 0x10;
                public const long m_drawColor = 0xD8;
                public const long m_userFlags = 0xC;
                public const long m_userShape = 0x40;
                public const long m_userVector = 0x14;
                public const long m_sEntityName = 0x108;
                public const long m_nEntityIndex = 0x110;
                public const long m_userTransform = 0x20;
                public const long m_pStructuredData = 0xF8;
                public const long m_vecDebugOverlayData = 0xE0;
            }
            public static partial class CEnvDetailController {
                public const long m_flFadeEndDist = 0x4AC;
                public const long m_flFadeStartDist = 0x4A8;
            }
            public static partial class CEnvInstructorVRHint {
                public const long m_iszName = 0x4A8;
                public const long m_iTimeout = 0x4B8;
                public const long m_iszCaption = 0x4C0;
                public const long m_iAttachType = 0x4E0;
                public const long m_iszStartSound = 0x4C8;
                public const long m_flHeightOffset = 0x4E4;
                public const long m_iLayoutFileType = 0x4D0;
                public const long m_iszCustomLayoutFile = 0x4D8;
                public const long m_iszHintTargetEntity = 0x4B0;
            }
            public static partial class CEnvLightProbeVolume {
                public const long m_Entity_bEnabled = 0x5C1;
                public const long m_Entity_vBoxMaxs = 0x584;
                public const long m_Entity_vBoxMins = 0x578;
                public const long m_Entity_bMoveable = 0x590;
                public const long m_Entity_nPriority = 0x598;
                public const long m_Entity_nHandshake = 0x594;
                public const long m_Entity_bStartDisabled = 0x59C;
                public const long m_Entity_nLightProbeSizeX = 0x5A0;
                public const long m_Entity_nLightProbeSizeY = 0x5A4;
                public const long m_Entity_nLightProbeSizeZ = 0x5A8;
                public const long m_Entity_nLightProbeAtlasX = 0x5AC;
                public const long m_Entity_nLightProbeAtlasY = 0x5B0;
                public const long m_Entity_nLightProbeAtlasZ = 0x5B4;
                public const long m_Entity_hLightProbeTexture_SDF = 0x548;
                public const long m_Entity_hLightProbeTexture_SH2_DC = 0x550;
                public const long m_Entity_hLightProbeTexture_SH2_L1 = 0x558;
                public const long m_Entity_hLightProbeTexture_AmbientCube = 0x540;
                public const long m_Entity_hLightProbeDirectLightIndicesTexture = 0x560;
                public const long m_Entity_hLightProbeDirectLightScalarsTexture = 0x568;
                public const long m_Entity_hLightProbeDirectLightShadowsTexture = 0x570;
            }
            public static partial class CFlashbangProjectile {
                public const long m_numOpponentsHit = 0xB44;
                public const long m_numTeammatesHit = 0xB45;
                public const long m_flTimeToDetonate = 0xB40;
            }
            public static partial class CFootstepTableHandle {

            }
            public static partial class CFuncPropRespawnZone {

            }
            public static partial class CGameSceneNodeHandle {
                public const long m_name = 0xC;
                public const long m_hOwner = 0x8;
            }
            public static partial class CHEGrenadeProjectile {

            }
            public static partial class CInfoDeathmatchSpawn {

            }
            public static partial class CInfoPlayerTerrorist {

            }
            public static partial class CIronSightController {
                public const long m_flIronSightAmount = 0xC;
                public const long m_bIronSightAvailable = 0x8;
                public const long m_flIronSightAmountBiased = 0x14;
                public const long m_flIronSightAmountGained = 0x10;
            }
            public static partial class CLogicActiveAutosave {
                public const long m_flStartTime = 0x4C0;
                public const long m_flDangerousTime = 0x4C4;
                public const long m_flTimeToTrigger = 0x4BC;
                public const long m_TriggerHitPoints = 0x4B8;
            }
            public static partial class CLogicNPCCounterAABB {
                public const long m_vOuterMaxs = 0x74C;
                public const long m_vOuterMins = 0x740;
                public const long m_vDistanceOuterMaxs = 0x734;
                public const long m_vDistanceOuterMins = 0x728;
            }
            public static partial class CMarkupVolumeWithRef {
                public const long m_bUseRef = 0x898;
                public const long m_flRefDot = 0x8B4;
                public const long m_vRefPosWorldSpace = 0x8A8;
                public const long m_vRefPosEntitySpace = 0x89C;
            }
            public static partial class CNMEventPulseState_t {
                public const long m_eventID = 0x0;
            }
            public static partial class CNavPathCostForTests {

            }
            public static partial class CPhysSlideConstraint {
                public const long m_axisEnd = 0x510;
                public const long m_soundInfo = 0x538;
                public const long m_initialOffset = 0x524;
                public const long m_slideFriction = 0x51C;
                public const long m_bUseEntityPivot = 0x534;
                public const long m_systemLoadScale = 0x520;
                public const long m_flMotorFrequency = 0x52C;
                public const long m_flMotorDampingRatio = 0x530;
                public const long m_bEnableLinearConstraint = 0x528;
                public const long m_bEnableAngularConstraint = 0x529;
            }
            public static partial class CPhysWheelConstraint {
                public const long m_flMaxSteeringAngle = 0x528;
                public const long m_flMinSteeringAngle = 0x524;
                public const long m_flSpinAxisFriction = 0x530;
                public const long m_bEnableSteeringLimit = 0x520;
                public const long m_flMaxSuspensionOffset = 0x51C;
                public const long m_flMinSuspensionOffset = 0x518;
                public const long m_flSuspensionFrequency = 0x508;
                public const long m_hSteeringMimicsEntity = 0x534;
                public const long m_bEnableSuspensionLimit = 0x514;
                public const long m_flSteeringAxisFriction = 0x52C;
                public const long m_flSuspensionDampingRatio = 0x50C;
                public const long m_flSuspensionHeightOffset = 0x510;
            }
            public static partial class CPhysicsEntitySolver {
                public const long m_cancelTime = 0x4CC;
                public const long m_hMovingEntity = 0x4C0;
                public const long m_hPhysicsBlocker = 0x4C4;
                public const long m_separationDuration = 0x4C8;
            }
            public static partial class CPhysicsPropOverride {

            }
            public static partial class CPlayerPawnComponent {
                public const long __m_pChainEntity = 0x8;
                public const long m_pComponentGraphController = 0x30;
            }
            public static partial class CPlayer_ItemServices {

            }
            public static partial class CPointClientUIDialog {
                public const long m_hActivator = 0x9B0;
                public const long m_bStartEnabled = 0x9B4;
            }
            public static partial class CPointCommentaryNode {
                public const long m_bActive = 0xAE8;
                public const long m_iszTitle = 0xAF8;
                public const long m_bDisabled = 0xAA5;
                public const long m_bListenedTo = 0xB10;
                public const long m_flStartTime = 0xAEC;
                public const long m_hViewTarget = 0xA60;
                public const long m_iNodeNumber = 0xB08;
                public const long m_iszSpeakers = 0xB00;
                public const long m_bUnstoppable = 0xA7A;
                public const long m_hViewPosition = 0xA70;
                public const long m_iszViewTarget = 0xA58;
                public const long m_flFinishedTime = 0xA7C;
                public const long m_iNodeNumberMax = 0xB0C;
                public const long m_iszPreCommands = 0xA40;
                public const long m_bUnderCrosshair = 0xA79;
                public const long m_iszPostCommands = 0xA48;
                public const long m_iszViewPosition = 0xA68;
                public const long m_vecFinishAngles = 0xA98;
                public const long m_vecFinishOrigin = 0xA80;
                public const long m_bPreventMovement = 0xA78;
                public const long m_hViewTargetAngles = 0xA64;
                public const long m_iszCommentaryFile = 0xA50;
                public const long m_vecOriginalAngles = 0xA8C;
                public const long m_vecTeleportOrigin = 0xAA8;
                public const long m_hViewPositionMover = 0xA74;
                public const long m_flAbortedPlaybackAt = 0xAB4;
                public const long m_pOnCommentaryStarted = 0xAB8;
                public const long m_pOnCommentaryStopped = 0xAD0;
                public const long m_flStartTimeInCommentary = 0xAF0;
                public const long m_bPreventChangesWhileMoving = 0xAA4;
            }
            public static partial class CPointVelocitySensor {
                public const long m_vecAxis = 0x4AC;
                public const long m_Velocity = 0x4C8;
                public const long m_bEnabled = 0x4B8;
                public const long m_fPrevVelocity = 0x4BC;
                public const long m_flAvgInterval = 0x4C0;
                public const long m_hTargetEntity = 0x4A8;
            }
            public static partial class CPulseCell_BaseState {

            }
            public static partial class CPulseCell_BaseValue {

            }
            public static partial class CPulseGameBlackboard {
                public const long m_strGraphName = 0x4B0;
                public const long m_strStateBlob = 0x4B8;
            }
            public static partial class CPulse_InvokeBinding {
                public const long m_FuncName = 0x30;
                public const long m_nSrcChunk = 0x44;
                public const long m_nCellIndex = 0x40;
                public const long m_RegisterMap = 0x0;
                public const long m_nSrcInstruction = 0x48;
            }
            public static partial class CRagdollPropAttached {
                public const long m_bShouldDetach = 0xC20;
                public const long m_boneIndexAttached = 0xC00;
                public const long m_attachmentPointBoneSpace = 0xC08;
                public const long m_ragdollAttachedObjectIndex = 0xC04;
                public const long m_attachmentPointRagdollSpace = 0xC14;
                public const long m_bShouldDeleteAttachedActivationRecord = 0xC30;
            }
            public static partial class CResponseCriteriaSet {
                public const long m_bOverrideOnAppend = 0x30;
            }
            public static partial class CSoundAreaEntityBase {
                public const long m_vPos = 0x4B8;
                public const long m_bDisabled = 0x4A8;
                public const long m_iszSoundAreaType = 0x4B0;
            }
            public static partial class CSoundEventBoxEntity {
                public const long m_iszBoxEntities = 0x5A0;
                public const long m_vecBoxHelpersNetworked = 0x638;
            }
            public static partial class CSoundEventBoxHelper {
                public const long m_vMaxs = 0x4B4;
                public const long m_vMins = 0x4A8;
            }
            public static partial class CSoundEventOBBEntity {
                public const long m_vMaxs = 0x574;
                public const long m_vMins = 0x568;
            }
            public static partial class CSoundEventParameter {
                public const long m_flFloatValue = 0x4C8;
                public const long m_iszParamName = 0x4C0;
            }
            public static partial class CSoundOpvarSetEntity {
                public const long m_nOpvarType = 0x4D8;
                public const long m_bSetOnSpawn = 0x4F0;
                public const long m_nOpvarIndex = 0x4DC;
                public const long m_flOpvarValue = 0x4E0;
                public const long m_iszOpvarName = 0x4D0;
                public const long m_iszStackName = 0x4C0;
                public const long m_iszOperatorName = 0x4C8;
                public const long m_OpvarValueString = 0x4E8;
            }
            public static partial class CTriggerHostageReset {

            }
            public static partial class CVectorMovingAverage {

            }
            public static partial class EngineCountdownTimer {
                public const long m_duration = 0x8;
                public const long m_timescale = 0x10;
                public const long m_timestamp = 0xC;
            }
            public static partial class EntitySpottedState_t {
                public const long m_bSpotted = 0x8;
                public const long m_bSpottedByMask = 0xC;
            }
            public static partial class PathMoverEntitySpawn {
                public const long hMover = 0x0;
                public const long nSpawnNumber = 0x20;
                public const long vecOtherEntities = 0x8;
            }
            public static partial class PhysicsRagdollPose_t {
                public const long m_hOwner = 0x20;
                public const long m_RelativeTransforms = 0x8;
                public const long m_bSetFromDebugHistory = 0x24;
            }
            public static partial class CBasePlayerController {
                public const long m_hPawn = 0x4E0;
                public const long m_bIsHLTV = 0x510;
                public const long m_steamID = 0x710;
                public const long m_bPredict = 0x5AD;
                public const long m_fLerpTime = 0x5A8;
                public const long m_nTickBase = 0x4B8;
                public const long m_iConnected = 0x514;
                public const long m_bGamePaused = 0x5B5;
                public const long m_hSplitOwner = 0x4F0;
                public const long m_iDesiredFOV = 0x71C;
                public const long m_iszPlayerName = 0x51C;
                public const long m_bIsLowViolence = 0x5B4;
                public const long m_bNoClipEnabled = 0x718;
                public const long m_iMostConnected = 0x518;
                public const long m_bLagCompensation = 0x5AC;
                public const long m_nSplitScreenSlot = 0x4EC;
                public const long m_iIgnoreGlobalChat = 0x6F0;
                public const long m_szNetworkIDString = 0x5A0;
                public const long m_bKnownTeamMismatch = 0x4E4;
                public const long m_hSplitScreenPlayers = 0x4F8;
                public const long m_flLastPlayerTalkTime = 0x6F4;
                public const long m_bHasAnySteadyStateEnts = 0x700;
                public const long m_flLastEntitySteadyState = 0x6F8;
                public const long m_nInButtonsWhichAreToggles = 0x4B0;
                public const long m_nAvailableEntitySteadyState = 0x6FC;
            }
            public static partial class CBreakableStageHelper {
                public const long m_nStageCount = 0xC;
                public const long m_nCurrentStage = 0x8;
            }
            public static partial class CCSCustomPlayerCamera {
                public const long m_hPawn = 0x4A8;
                public const long m_bFollowEyes = 0x4B4;
                public const long m_nCameraMode = 0x4AC;
                public const long m_hFollowEntity = 0x4B0;
                public const long m_vecCameraOffset = 0x4C4;
                public const long m_vecFollowOffset = 0x4B8;
                public const long m_bClipCameraOffset = 0x4D0;
                public const long m_flCameraOffsetReturnStrength = 0x4D4;
            }
            public static partial class CCSGameModeRules_Noop {

            }
            public static partial class CCSPlayer_BuyServices {
                public const long m_vecSellbackPurchaseEntries = 0xD0;
            }
            public static partial class CCSPlayer_UseServices {
                public const long m_flLastUseTimeStamp = 0x4C;
                public const long m_hLastKnownUseEntity = 0x48;
                public const long m_flTimeLastUsedWindow = 0x50;
            }
            public static partial class CDebugDrawHistoryData {
                public const long m_bools = 0x58;
                public const long m_etype = 0x4;
                public const long m_times = 0x38;
                public const long m_colors = 0x18;
                public const long m_hEntity = 0x0;
                public const long m_strings = 0x68;
                public const long m_uint64s = 0x48;
                public const long m_vectors = 0x8;
                public const long m_dimensions = 0x28;
            }
            public static partial class CEmptyGraphController {

            }
            public static partial class CGameScriptedMoveData {
                public const long m_vSrc = 0x18;
                public const long m_vDest = 0x58;
                public const long m_angDst = 0x64;
                public const long m_angSrc = 0x24;
                public const long m_bActive = 0x4C;
                public const long m_bSuccess = 0x4F;
                public const long m_flAngRate = 0x40;
                public const long m_angCurrent = 0x30;
                public const long m_flDuration = 0x44;
                public const long m_flStartTime = 0x48;
                public const long m_hDestEntity = 0x70;
                public const long m_flLockedSpeed = 0x3C;
                public const long m_bTeleportOnEnd = 0x4D;
                public const long m_bIgnoreRotation = 0x4E;
                public const long m_bIgnoreCollisions = 0x54;
                public const long m_nForcedCrouchState = 0x50;
                public const long m_vAccumulatedRootMotion = 0x0;
                public const long m_angAccumulatedRootMotionRotation = 0xC;
            }
            public static partial class CHostageCarriableProp {

            }
            public static partial class CHostageExpresserShim {
                public const long m_pExpresser = 0xB10;
            }
            public static partial class CInfoTargetServerOnly {

            }
            public static partial class CInstancedSceneEntity {
                public const long m_hOwner = 0x800;
                public const long m_hTarget = 0x814;
                public const long m_bHadOwner = 0x804;
                public const long m_flPreDelay = 0x80C;
                public const long m_bIsBackground = 0x810;
                public const long m_flPostSpeakDelay = 0x808;
            }
            public static partial class CLogicGameStateReport {
                public const long m_bDisabled = 0x4A8;
            }
            public static partial class CLogicMeasureMovement {
                public const long m_flScale = 0x4D0;
                public const long m_hTarget = 0x4C8;
                public const long m_nMeasureType = 0x4D4;
                public const long m_hMeasureTarget = 0x4C0;
                public const long m_hTargetReference = 0x4CC;
                public const long m_strMeasureTarget = 0x4A8;
                public const long m_hMeasureReference = 0x4C4;
                public const long m_strTargetReference = 0x4B8;
                public const long m_strMeasureReference = 0x4B0;
            }
            public static partial class CLogicPlayerProxyBase {
                public const long m_hPlayer = 0x510;
                public const long m_PlayerDied = 0x4D8;
                public const long m_PlayerHasAmmo = 0x4A8;
                public const long m_PlayerHasNoAmmo = 0x4C0;
                public const long m_RequestedPlayerHealth = 0x4F0;
            }
            public static partial class CMapSharedEnvironment {
                public const long m_targetMapName = 0x4A8;
            }
            public static partial class CNmEventConsumerCloth {

            }
            public static partial class CNmEventConsumerPulse {

            }
            public static partial class CNmEventConsumerSound {

            }
            public static partial class CPathWithDynamicNodes {
                public const long m_vecPathNodes = 0x5B0;
                public const long m_eDesiredDirection = 0x5F0;
                public const long m_bIgnoreParentRotation = 0x5F4;
                public const long m_xInitialPathWorldToLocal = 0x5D0;
            }
            public static partial class CPlayer_WaterServices {

            }
            public static partial class CPointProximitySensor {
                public const long m_Distance = 0x4B0;
                public const long m_bDisabled = 0x4A8;
                public const long m_hTargetEntity = 0x4AC;
            }
            public static partial class CPostProcessingVolume {
                public const long m_bMaster = 0xA04;
                public const long m_flMaxExposure = 0x9F0;
                public const long m_flMinExposure = 0x9EC;
                public const long m_hPostSettings = 0x9D8;
                public const long m_flFadeDuration = 0x9E0;
                public const long m_bExposureControl = 0xA05;
                public const long m_flMaxLogExposure = 0x9E8;
                public const long m_flMinLogExposure = 0x9E4;
                public const long m_flExposureFadeSpeedUp = 0x9F8;
                public const long m_flExposureCompensation = 0x9F4;
                public const long m_flExposureFadeSpeedDown = 0x9FC;
                public const long m_flTonemapEVSmoothingRange = 0xA00;
            }
            public static partial class CPrecipitationBlocker {

            }
            public static partial class CPulseCell_LimitCount {
                public const long m_nLimitCount = 0x48;
            }
            public static partial class CServerRagdollTrigger {

            }
            public static partial class CSoundEventAABBEntity {
                public const long m_vMaxs = 0x574;
                public const long m_vMins = 0x568;
            }
            public static partial class CSoundEventConeEntity {
                public const long m_flAttenMax = 0x574;
                public const long m_flAttenMin = 0x570;
                public const long m_flEmitterAngle = 0x568;
                public const long m_flSweetSpotAngle = 0x56C;
                public const long m_iszParameterName = 0x578;
            }
            public static partial class CSpriteAlias_env_glow {

            }
            public static partial class CTestPulseIOComponent {
                public const long m_ComponentData = 0x8;
                public const long m_OnComponentTestFunc = 0x10;
            }
            public static partial class PointCameraSettings_t {
                public const long m_flFarCrispDistance = 0x8;
                public const long m_flFarBlurryDistance = 0xC;
                public const long m_flNearCrispDistance = 0x4;
                public const long m_flNearBlurryDistance = 0x0;
            }
            public static partial class PrecipitationFilter_t {
                public const long m_flMaxRadius = 0x0;
            }
            public static partial class WeaponPurchaseCount_t {
                public const long m_nCount = 0x32;
                public const long m_nItemDefIndex = 0x30;
            }
            public static partial class WrappedPhysicsJoint_t {
                public const long m_pJoint = 0x0;
            }
            public static partial class physics_save_sphere_t {
                public const long radius = 0x0;
            }
            public static partial class AutoRoomDoorwayPairs_t {
                public const long vP1 = 0x0;
                public const long vP2 = 0xC;
            }
            public static partial class CAnimGraph2InstancePtr {

            }
            public static partial class CBasePlayerWeaponVData {
                public const long m_iSlot = 0x4EC;
                public const long m_iFlags = 0x4C7;
                public const long m_iWeight = 0x4C8;
                public const long m_iMaxClip1 = 0x4D0;
                public const long m_iMaxClip2 = 0x4D4;
                public const long m_iPosition = 0x4F0;
                public const long m_flDropSpeed = 0x4E8;
                public const long m_aShootSounds = 0x4F8;
                public const long m_szWorldModel = 0x28;
                public const long m_bAutoSwitchTo = 0x4CC;
                public const long m_iDefaultClip1 = 0x4D8;
                public const long m_iDefaultClip2 = 0x4DC;
                public const long m_iRumbleEffect = 0x4E4;
                public const long m_bAllowFlipping = 0x2C9;
                public const long m_bAutoSwitchFrom = 0x4CD;
                public const long m_bKeepLoadedAmmo = 0x4E2;
                public const long m_bLinkedCooldowns = 0x4C6;
                public const long m_nPrimaryAmmoType = 0x4CE;
                public const long m_bBuiltRightHanded = 0x2C8;
                public const long m_sMuzzleAttachment = 0x2D0;
                public const long m_bTreatAsSingleClip = 0x4E1;
                public const long m_nSecondaryAmmoType = 0x4CF;
                public const long m_bReserveAmmoAsClips = 0x4E0;
                public const long m_bGenerateMuzzleLight = 0x4C4;
                public const long m_flMuzzleSmokeTimeout = 0x4BC;
                public const long m_bShouldAnimateInWorld = 0x4C5;
                public const long m_szBarrelSmokeParticle = 0x3D8;
                public const long m_szMuzzleFlashParticle = 0x2F0;
                public const long m_szWorldModelAg2Override = 0x108;
                public const long m_sToolsOnlyOwnerModelName = 0x1E8;
                public const long m_nMuzzleSmokeShotThreshold = 0x4B8;
                public const long m_flMuzzleSmokeDecrementRate = 0x4C0;
                public const long m_szMuzzleFlashParticleConfig = 0x3D0;
            }
            public static partial class CCSPlayer_ItemServices {
                public const long m_bHasHelmet = 0x49;
                public const long m_bHasDefuser = 0x48;
            }
            public static partial class CCSPlayer_PingServices {
                public const long m_hPlayerPing = 0x5C;
                public const long m_flPlayerPingTokens = 0x48;
            }
            public static partial class CColorCorrectionVolume {
                public const long m_Weight = 0x9D0;
                public const long m_MaxWeight = 0x9C8;
                public const long m_FadeDuration = 0x9CC;
                public const long m_LastExitTime = 0xBE0;
                public const long m_LastEnterTime = 0xBD8;
                public const long m_LastExitWeight = 0xBDC;
                public const long m_lookupFilename = 0x9D4;
                public const long m_LastEnterWeight = 0xBD4;
            }
            public static partial class CExternalAnimGraphList {

            }
            public static partial class CFuncElectrifiedVolume {
                public const long m_EffectName = 0x870;
                public const long m_EffectZapName = 0x880;
                public const long m_iszEffectSource = 0x888;
                public const long m_EffectInterpenetrateName = 0x878;
            }
            public static partial class CGameScriptedMoveDef_t {
                public const long m_angDest = 0x10;
                public const long m_flAngRate = 0x20;
                public const long m_flDuration = 0x1C;
                public const long m_flMoveSpeed = 0x24;
                public const long m_hDestEntity = 0xC;
                public const long m_vDestOffset = 0x0;
                public const long m_bAimDisabled = 0x28;
                public const long m_bIgnoreRotation = 0x29;
                public const long m_nForcedCrouchState = 0x2C;
            }
            public static partial class CHostageRescueZoneShim {

            }
            public static partial class CInfoDynamicShadowHint {
                public const long m_hLight = 0x4B8;
                public const long m_flRange = 0x4AC;
                public const long m_bDisabled = 0x4A8;
                public const long m_nImportance = 0x4B0;
                public const long m_nLightChoice = 0x4B4;
            }
            public static partial class CInstructorEventEntity {
                public const long m_iszName = 0x4A8;
                public const long m_hTargetPlayer = 0x4B8;
                public const long m_iszHintTargetEntity = 0x4B0;
            }
            public static partial class CLogicDistanceAutosave {
                public const long m_bCheckCough = 0x4B5;
                public const long m_bThinkDangerous = 0x4B6;
                public const long m_flDangerousTime = 0x4B8;
                public const long m_iszTargetEntity = 0x4A8;
                public const long m_bForceNewLevelUnit = 0x4B4;
                public const long m_flDistanceToPlayer = 0x4B0;
            }
            public static partial class CMapVetoPickController {
                public const long m_nMapId0 = 0x6F8;
                public const long m_nMapId1 = 0x7F8;
                public const long m_nMapId2 = 0x8F8;
                public const long m_nMapId3 = 0x9F8;
                public const long m_nMapId4 = 0xAF8;
                public const long m_nMapId5 = 0xBF8;
                public const long m_nDraftType = 0x4D4;
                public const long m_OnMapPicked = 0xE28;
                public const long m_OnMapVetoed = 0xE08;
                public const long m_nAccountIDs = 0x5F8;
                public const long m_OnSidesPicked = 0xE48;
                public const long m_nCurrentPhase = 0xDF8;
                public const long m_nStartingSide0 = 0xCF8;
                public const long m_bPlayedIntroVcd = 0x4A8;
                public const long m_nPhaseStartTick = 0xDFC;
                public const long m_nVoteMapIdsList = 0x5DC;
                public const long m_OnLevelTransition = 0xE88;
                public const long m_OnNewPhaseStarted = 0xE68;
                public const long m_nPhaseDurationTicks = 0xE00;
                public const long m_nTeamWinningCoinToss = 0x4D8;
                public const long m_nTeamWithFirstChoice = 0x4DC;
                public const long m_bPreMatchDraftStateChanged = 0x4D0;
                public const long m_dblPreMatchDraftSequenceTime = 0x4C8;
                public const long m_bNeedToPlayFiveSecondsRemaining = 0x4A9;
            }
            public static partial class CMovementStatsProperty {
                public const long m_nUseCounter = 0x10;
                public const long m_emaMovementDirection = 0x14;
            }
            public static partial class CMultiplayer_Expresser {
                public const long m_bAllowMultipleScenes = 0xA0;
            }
            public static partial class CNavVolumeMarkupVolume {

            }
            public static partial class CNetworkVelocityVector {
                public const long m_vecX = 0x10;
                public const long m_vecY = 0x18;
                public const long m_vecZ = 0x20;
            }
            public static partial class CNmEventConsumerCamera {

            }
            public static partial class CNmEventConsumerLegacy {

            }
            public static partial class CPhysicsBodyGameMarkup {
                public const long m_Tag = 0x8;
                public const long m_TargetBody = 0x0;
            }
            public static partial class CPlayer_CameraServices {
                public const long m_audio = 0xB0;
                public const long m_PlayerFog = 0x60;
                public const long m_hViewEntity = 0xA4;
                public const long m_flOldPlayerZ = 0x140;
                public const long m_hTonemapController = 0xA8;
                public const long m_vecCsViewPunchAngle = 0x48;
                public const long m_hColorCorrectionCtrl = 0xA0;
                public const long m_PostProcessingVolumes = 0x128;
                public const long m_nCsViewPunchAngleTick = 0x54;
                public const long m_flOldPlayerViewOffsetZ = 0x144;
                public const long m_hTriggerSoundscapeList = 0x160;
                public const long m_flCsViewPunchAngleTickRatio = 0x58;
            }
            public static partial class CPlayer_WeaponServices {
                public const long m_iAmmo = 0x68;
                public const long m_hMyWeapons = 0x48;
                public const long m_hLastWeapon = 0x64;
                public const long m_hActiveWeapon = 0x60;
                public const long m_bPreventWeaponPickup = 0xA8;
            }
            public static partial class CPointGamestatsCounter {
                public const long m_bDisabled = 0x4B0;
                public const long m_strStatisticName = 0x4A8;
            }
            public static partial class CPulseCell_ApplyParent {

            }
            public static partial class CPulseCell_CursorQueue {
                public const long m_nCursorsAllowedToRunParallel = 0x128;
            }
            public static partial class CPulseCell_FireCursors {
                public const long m_Outflows = 0xD8;
                public const long m_OnFinished = 0xF8;
                public const long m_bWaitForChildOutflows = 0xF0;
            }
            public static partial class CPulseCell_Inflow_Wait {
                public const long m_WakeResume = 0xD8;
            }
            public static partial class CPulseCell_RaceCursors {
                public const long m_Outflows = 0xD8;
                public const long m_OnFinished = 0xF0;
            }
            public static partial class CPulseCell_Value_Curve {
                public const long m_Curve = 0x48;
            }
            public static partial class CScriptTriggerMultiple {
                public const long m_vExtent = 0x9E0;
            }
            public static partial class CServerOnlyModelEntity {

            }
            public static partial class CServerOnlyPointEntity {

            }
            public static partial class CSkyCameraVolumeTarget {
                public const long m_hSkyMaterial = 0x4B0;
                public const long m_nSkyboxScale = 0x4A8;
            }
            public static partial class CSoundAreaEntitySphere {
                public const long m_flRadius = 0x4C8;
            }
            public static partial class INavPathCostAreaFilter {

            }
            public static partial class RelationshipOverride_t {
                public const long entity = 0x8;
                public const long classType = 0xC;
            }
            public static partial class globalentitydatabase_t {
                public const long m_list = 0x60;
            }
            public static partial class CAnimGraphControllerPtr {
                public const long m_pController = 0x0;
            }
            public static partial class CBasePulseGraphInstance {

            }
            public static partial class CCS2PawnGraphController {
                public const long m_moveType = 0x5D8;
                public const long m_airAction = 0x740;
                public const long m_bIsWalking = 0x680;
                public const long m_flinchBody = 0x818;
                public const long m_flinchHead = 0x7E8;
                public const long m_bIsDefusing = 0x5C0;
                public const long m_flLadderYaw = 0x710;
                public const long m_flMoveSpeedX = 0x608;
                public const long m_flMoveSpeedY = 0x620;
                public const long m_groundAction = 0x6B0;
                public const long m_flAimYawAngle = 0x7D0;
                public const long m_flLadderCycle = 0x6F8;
                public const long m_flCrouchAmount = 0x668;
                public const long m_flinchIsOnFire = 0x848;
                public const long m_leftFootTarget = 0x770;
                public const long m_flAimPitchAngle = 0x7B8;
                public const long m_flFlashedAmount = 0x7A0;
                public const long m_moveDirectionID = 0x5F0;
                public const long m_rightFootTarget = 0x788;
                public const long m_flinchBodyRestart = 0x830;
                public const long m_flinchHeadRestart = 0x800;
                public const long m_flWeaponDropAmount = 0x698;
                public const long m_flLadderYawBackwards = 0x728;
                public const long m_flMoveSpeedHorizontal = 0x638;
                public const long m_flAirHeightAboveGround = 0x758;
                public const long m_groundActionDirectionID = 0x6C8;
                public const long m_flGroundTurnAngleOrVelocity = 0x6E0;
                public const long m_flPreviousMoveSpeedHorizontal = 0x650;
            }
            public static partial class CCSCustomHudLayoutState {
                public const long m_playerSlot = 0x30;
                public const long m_vecHasClasses = 0x38;
                public const long m_bInputCaptureEnabled = 0x34;
                public const long m_vecDialogVariableStrings = 0x98;
            }
            public static partial class CCSObserver_UseServices {

            }
            public static partial class CCSPlayerAnimationState {
                public const long m_airAction = 0x1B;
                public const long m_actionStartTick = 0x20;
                public const long m_currentMoveType = 0x18;
                public const long m_groundMoveState = 0x19;
                public const long m_flPreviousAimYaw = 0x30;
                public const long m_flTurnOnSpotAngle = 0x2C;
                public const long m_flFootIKOffsetLeft = 0x38;
                public const long m_flFootIKOffsetRight = 0x3C;
                public const long m_groundActionDirection = 0x1A;
                public const long m_plantAndTurnStartTick = 0x28;
                public const long m_bWasOnGroundLastUpdate = 0x1C;
                public const long m_staticAimTimerStartTick = 0x24;
                public const long m_bWasStationaryLastUpdate = 0x1D;
                public const long m_flPreviousHorizontalSpeed = 0x34;
                public const long m_flWeaponDropSmoothDampVelocity = 0x44;
                public const long m_flWeaponDropPercentageDueToMovement = 0x40;
            }
            public static partial class CCSPlayer_RadioServices {
                public const long m_bIgnoreRadio = 0x60;
                public const long m_flRadioTokenSlots = 0x54;
                public const long m_flC4PlantTalkTimer = 0x50;
                public const long m_flDefusingTalkTimer = 0x4C;
                public const long m_flGotHostageTalkTimer = 0x48;
            }
            public static partial class CCSPlayer_WaterServices {
                public const long m_nDrownDmgRate = 0x4C;
                public const long m_AirFinishedTime = 0x50;
                public const long m_flSwimSoundTime = 0x64;
                public const long m_flWaterJumpTime = 0x54;
                public const long m_vecWaterJumpVel = 0x58;
                public const long m_NextDrownDamageTime = 0x48;
            }
            public static partial class CChoreo_GraphController {
                public const long m_eChoreoState = 0xC0;
                public const long m_tChoreoExitWarp = 0xF0;
                public const long m_tChoreoTargetWarp = 0xD8;
            }
            public static partial class CCommentaryViewPosition {

            }
            public static partial class CEnvVolumetricFogVolume {
                public const long m_bActive = 0x4A8;
                public const long m_vBoxMaxs = 0x4B8;
                public const long m_vBoxMins = 0x4AC;
                public const long m_TintColor = 0x4E8;
                public const long m_flStrength = 0x4C8;
                public const long m_nFalloffShape = 0x4CC;
                public const long m_bStartDisabled = 0x4C4;
                public const long m_fNoiseStrength = 0x4E4;
                public const long m_bIndirectUseLPVs = 0x4C5;
                public const long m_flHeightFogDepth = 0x4D4;
                public const long m_fSunLightStrength = 0x4E0;
                public const long m_flFalloffExponent = 0x4D0;
                public const long m_bOverrideTintColor = 0x4EC;
                public const long m_fHeightFogEdgeWidth = 0x4D8;
                public const long m_bOverrideNoiseStrength = 0x4EF;
                public const long m_fIndirectLightStrength = 0x4DC;
                public const long m_bOverrideSunLightStrength = 0x4EE;
                public const long m_bOverrideIndirectLightStrength = 0x4ED;
            }
            public static partial class CInfoSpawnGroupLandmark {

            }
            public static partial class CLightDirectionalEntity {

            }
            public static partial class CLightEnvironmentEntity {

            }
            public static partial class CLogicGameEventListener {
                public const long m_bEnabled = 0x4E0;
                public const long m_OnEventFired = 0x4B8;
                public const long m_bStartDisabled = 0x4E1;
                public const long m_iszGameEventItem = 0x4D8;
                public const long m_iszGameEventName = 0x4D0;
            }
            public static partial class CMarkupVolumeTagged_Nav {
                public const long m_nScopes = 0x890;
            }
            public static partial class CNmEventConsumerContact {

            }
            public static partial class CPathMoverEntitySpawner {
                public const long m_bEnabled = 0x52C;
                public const long m_nSpawnNum = 0x524;
                public const long m_hPathMover = 0x4F4;
                public const long m_nMaxActive = 0x520;
                public const long m_nSpawnIndex = 0x4F0;
                public const long m_vMoverSpawnPos = 0x59C;
                public const long m_flLastSpawnTime = 0x528;
                public const long m_iszPathMoverName = 0x578;
                public const long m_szSpawnTemplates = 0x4B0;
                public const long m_OnTemplateSpawned = 0x548;
                public const long m_vecQueuedRemovals = 0x530;
                public const long m_bRunningDebugThink = 0x5A8;
                public const long m_bPrepopulateOnSpawn = 0x580;
                public const long m_iszPathNodeStartName = 0x588;
                public const long m_szSpawnTemplateCount = 0x4E0;
                public const long m_szSpawnTemplateParams = 0x4D0;
                public const long m_OnTemplateGroupSpawned = 0x560;
                public const long m_eTemplateChoiceStrategy = 0x4A8;
                public const long m_flSpawnFrequencySeconds = 0x4F8;
                public const long m_mapSpawnedMoverTemplates = 0x500;
                public const long m_bDestroyMoverOnArrivedAtEnd = 0x52D;
                public const long m_flSpawnFrequencyDistToNearestMover = 0x4FC;
            }
            public static partial class CPhysicsPropMultiplayer {

            }
            public static partial class CPhysicsPropRespawnable {
                public const long m_vOriginalMaxs = 0xD34;
                public const long m_vOriginalMins = 0xD28;
                public const long m_flRespawnDuration = 0xD40;
                public const long m_vOriginalSpawnAngles = 0xD1C;
                public const long m_vOriginalSpawnOrigin = 0xD10;
            }
            public static partial class CPlayer_AutoaimServices {

            }
            public static partial class CPulseCell_Inflow_Yield {
                public const long m_UnyieldResume = 0xD8;
            }
            public static partial class CPulseCell_PlaySequence {
                public const long m_OnFinished = 0xF8;
                public const long m_SequenceName = 0xD8;
                public const long m_PulseAnimEvents = 0xE0;
            }
            public static partial class CPulseCell_ReturnValues {

            }
            public static partial class CPulseCell_Step_EntFire {
                public const long m_Input = 0x48;
            }
            public static partial class CSmokeGrenadeProjectile {
                public const long m_nRandomSeed = 0xB70;
                public const long m_vSmokeColor = 0xB74;
                public const long m_flLastBounce = 0xBB4;
                public const long m_nVoxelUpdate = 0xBAC;
                public const long m_VoxelFrameData = 0xB90;
                public const long m_bDidSmokeEffect = 0xB6C;
                public const long m_bDidGroundScorch = 0x2E41;
                public const long m_bExplodeFromInferno = 0x2E40;
                public const long m_nVoxelFrameDataSize = 0xBA8;
                public const long m_vSmokeDetonationPos = 0xB80;
                public const long m_fllastSimulationTime = 0xBB8;
                public const long m_nSmokeEffectTickBegin = 0xB68;
                public const long m_nSmokeLightProbeRegen = 0xBB0;
            }
            public static partial class CSoundEventSphereEntity {
                public const long m_flRadius = 0x568;
            }
            public static partial class CSoundOpvarSetBoxEntity {
                public const long m_vInnerMaxs = 0x680;
                public const long m_vInnerMins = 0x674;
                public const long m_vOuterMaxs = 0x698;
                public const long m_vOuterMins = 0x68C;
                public const long m_nBoxDirection = 0x670;
                public const long m_vDistanceInnerMaxs = 0x64C;
                public const long m_vDistanceInnerMins = 0x640;
                public const long m_vDistanceOuterMaxs = 0x664;
                public const long m_vDistanceOuterMins = 0x658;
            }
            public static partial class CSoundOpvarSetOBBEntity {

            }
            public static partial class CSoundOpvarSetPointBase {
                public const long m_hSource = 0x4AC;
                public const long m_bDisabled = 0x4A8;
                public const long m_iOpvarIndex = 0x548;
                public const long m_bFastRefresh = 0x54D;
                public const long m_iszOpvarName = 0x540;
                public const long m_iszStackName = 0x530;
                public const long m_flRefreshTime = 0x52C;
                public const long m_vLastPosition = 0x520;
                public const long m_bUseAutoCompare = 0x54C;
                public const long m_iszOperatorName = 0x538;
                public const long m_iszSourceEntityName = 0x4C8;
            }
            public static partial class CTextureBasedAnimatable {
                public const long m_bLoop = 0x850;
                public const long m_flFPS = 0x854;
                public const long m_flStartTime = 0x880;
                public const long m_flStartFrame = 0x884;
                public const long m_hPositionKeys = 0x858;
                public const long m_hRotationKeys = 0x860;
                public const long m_vAnimationBoundsMax = 0x874;
                public const long m_vAnimationBoundsMin = 0x868;
            }
            public static partial class CTriggerDetectExplosion {
                public const long m_OnDetectedExplosion = 0x9F0;
            }
            public static partial class EntityRenderAttribute_t {
                public const long m_ID = 0x30;
                public const long m_Values = 0x34;
            }
            public static partial class RagdollCreationParams_t {
                public const long m_vForce = 0x0;
                public const long m_nForceBone = 0xC;
                public const long m_nHealthToGrant = 0x14;
                public const long m_bForceCurrentWorldTransform = 0x10;
            }
            public static partial class SellbackPurchaseEntry_t {
                public const long m_hItem = 0x40;
                public const long m_nCost = 0x34;
                public const long m_unDefIdx = 0x30;
                public const long m_nPrevArmor = 0x38;
                public const long m_bPrevHelmet = 0x3C;
            }
            public static partial class SignatureOutflow_Resume {

            }
            public static partial class SoundOpvarTraceResult_t {
                public const long vPos = 0x0;
                public const long bDidHit = 0xC;
                public const long flDistSqrToCenter = 0x10;
            }
            public static partial class SummaryTakeDamageInfo_t {
                public const long info = 0x8;
                public const long result = 0x120;
                public const long hTarget = 0x180;
                public const long nSummarisedCount = 0x0;
            }
            public static partial class ViewAngleServerChange_t {
                public const long nType = 0x30;
                public const long nIndex = 0x40;
                public const long qAngle = 0x34;
            }
            public static partial class WeaponPurchaseTracker_t {
                public const long m_weaponPurchases = 0x8;
            }
            public static partial class ragdollhierarchyjoint_t {
                public const long childIndex = 0x4;
                public const long parentIndex = 0x0;
            }
            public static partial class CAnimGraphControllerBase {
                public const long m_hExternalGraph = 0x4C;
            }
            public static partial class CBaseAnimGraphController {
                public const long m_hSequence = 0x5C;
                public const long m_nNotifyState = 0x78;
                public const long m_nAnimLoopMode = 0x68;
                public const long m_flPlaybackRate = 0x6C;
                public const long m_flSeqStartTime = 0x60;
                public const long m_primaryGraphId = 0x3C8;
                public const long m_flSeqFixedCycle = 0x64;
                public const long m_flSoundSyncTime = 0x54;
                public const long m_bSequenceFinished = 0x7C;
                public const long m_pGraphInstanceAG2 = 0x408;
                public const long m_vecExternalGraphs = 0x628;
                public const long m_bLastUpdateSkipped = 0x7B;
                public const long m_nActiveIKChainMask = 0x58;
                public const long m_vecExternalClipIds = 0x3E8;
                public const long m_hGraphDefinitionAG2 = 0x320;
                public const long m_nAnimationAlgorithm = 0x18;
                public const long m_nPrevAnimUpdateTick = 0x80;
                public const long m_vecExternalGraphIds = 0x3D0;
                public const long m_sAnimGraph2Identifier = 0x400;
                public const long m_vecSecondarySkeletons = 0x38;
                public const long m_nNextExternalGraphHandle = 0x1C;
                public const long m_bNetworkedSequenceChanged = 0x7A;
                public const long m_SerializePoseRecipeAG2Slots = 0x328;
                public const long m_vecSecondarySkeletonSlotIDs = 0x20;
                public const long m_SerializePoseRecipeAG2Dynamic = 0x390;
                public const long m_nSecondarySkeletonMasterCount = 0x50;
                public const long m_nServerGraphInstanceIteration = 0x3C0;
                public const long m_nSerializePoseRecipeVersionAG2 = 0x3AC;
                public const long m_bNetworkedAnimationInputsChanged = 0x79;
                public const long m_nSerializePoseRecipeAG2ActiveSlot = 0x3A8;
                public const long m_nServerSerializationContextIteration = 0x3C4;
            }
            public static partial class CBaseCSGrenadeProjectile {
                public const long m_nBounces = 0xAE8;
                public const long m_nItemIndex = 0xB0E;
                public const long m_flSpawnTime = 0xB08;
                public const long m_vecGrenadeSpin = 0xB20;
                public const long m_unOGSExtraFlags = 0xB0C;
                public const long m_bHasEverHitEnemy = 0xB3C;
                public const long m_vInitialPosition = 0xAD0;
                public const long m_vInitialVelocity = 0xADC;
                public const long m_bDetonationRecorded = 0xB0D;
                public const long m_nExplodeEffectIndex = 0xAF0;
                public const long m_nTicksAtZeroVelocity = 0xB38;
                public const long m_flLastBounceSoundTime = 0xB1C;
                public const long m_vecExplodeEffectOrigin = 0xAFC;
                public const long m_nExplodeEffectTickBegin = 0xAF8;
                public const long m_vecLastHitSurfaceNormal = 0xB2C;
                public const long m_vecOriginalSpawnLocation = 0xB10;
            }
            public static partial class CBtNodeConditionInactive {
                public const long m_SensorInactivityTimer = 0x80;
                public const long m_flRoundStartThresholdSeconds = 0x78;
                public const long m_flSensorInactivityThresholdSeconds = 0x7C;
            }
            public static partial class CCSPlayer_BulletServices {
                public const long m_totalHitsOnServer = 0x48;
            }
            public static partial class CCSPlayer_CameraServices {

            }
            public static partial class CCSPlayer_WeaponServices {
                public const long m_flNextAttack = 0xC0;
                public const long m_hSavedWeapon = 0xC4;
                public const long m_nTimeToMelee = 0xC8;
                public const long m_nTimeToPrimary = 0xD0;
                public const long m_bPickedUpWeapon = 0xDA;
                public const long m_nTimeToSecondary = 0xCC;
                public const long m_bIsBeingGivenItem = 0xD8;
                public const long m_networkAnimTiming = 0x1898;
                public const long m_bDisableAutoDeploy = 0xDB;
                public const long m_nTimeToSniperRifle = 0xD4;
                public const long m_bIsPickingUpItemWithUse = 0xD9;
                public const long m_bIsPickingUpGroundWeapon = 0xDC;
                public const long m_bBlockInspectUntilNextGraphUpdate = 0x18B0;
            }
            public static partial class CCitadelSoundOpvarSetOBB {
                public const long m_iszOpvarName = 0x4B8;
                public const long m_iszStackName = 0x4A8;
                public const long m_nAABBDirection = 0x4F0;
                public const long m_iszOperatorName = 0x4B0;
                public const long m_vDistanceInnerMaxs = 0x4CC;
                public const long m_vDistanceInnerMins = 0x4C0;
                public const long m_vDistanceOuterMaxs = 0x4E4;
                public const long m_vDistanceOuterMins = 0x4D8;
            }
            public static partial class CConstantForceController {
                public const long m_linear = 0xC;
                public const long m_angular = 0x18;
                public const long m_linearSave = 0x24;
                public const long m_angularSave = 0x30;
            }
            public static partial class CEntitySubclassVDataBase {

            }
            public static partial class CGenericLogicPlayerProxy {

            }
            public static partial class CInfoTeleportDestination {

            }
            public static partial class CNavVolumeSphericalShell {
                public const long m_flRadiusInner = 0x88;
            }
            public static partial class CNetworkViewOffsetVector {
                public const long m_vecX = 0x10;
                public const long m_vecY = 0x18;
                public const long m_vecZ = 0x20;
            }
            public static partial class CNmEventConsumerParticle {

            }
            public static partial class CPlayer_MovementServices {
                public const long m_flUpMove = 0x1C8;
                public const long m_nButtons = 0x50;
                public const long m_nImpulse = 0x48;
                public const long m_flLeftMove = 0x1C4;
                public const long m_flMaxspeed = 0x1AC;
                public const long m_flCmdUpMove = 0x1A8;
                public const long m_flCmdLeftMove = 0x1A4;
                public const long m_flForwardMove = 0x1C0;
                public const long m_flCmdForwardMove = 0x1A0;
                public const long m_vecOldViewAngles = 0x240;
                public const long m_nButtonDoublePressed = 0x80;
                public const long m_nQueuedButtonDownMask = 0x70;
                public const long m_nToggleButtonDownMask = 0x190;
                public const long m_arrForceSubtickMoveWhen = 0x1B0;
                public const long m_nQueuedButtonChangeMask = 0x78;
                public const long m_pButtonPressedCmdNumber = 0x88;
                public const long m_vecLastMovementImpulses = 0x1CC;
                public const long m_nLastCommandNumberProcessed = 0x188;
            }
            public static partial class CPlayer_ObserverServices {
                public const long m_iObserverMode = 0x48;
                public const long m_hObserverTarget = 0x4C;
                public const long m_iObserverLastMode = 0x50;
                public const long m_bForcedObserverMode = 0x54;
            }
            public static partial class CPointClientUIWorldPanel {
                public const long m_bLit = 0x9B1;
                public const long m_flDPI = 0x9BC;
                public const long m_bOpaque = 0x9F8;
                public const long m_flWidth = 0x9B4;
                public const long m_bNoDepth = 0x9F9;
                public const long m_flHeight = 0x9B8;
                public const long m_bGrabbable = 0x9FE;
                public const long m_bIgnoreInput = 0x9B0;
                public const long m_flDepthOffset = 0x9C8;
                public const long m_unOrientation = 0x9D8;
                public const long m_vecCSSClasses = 0x9E0;
                public const long m_bDisableMipGen = 0xA00;
                public const long m_unOwnerContext = 0x9CC;
                public const long m_bRenderBackface = 0x9FB;
                public const long m_flWindowUIScale = 0x9C0;
                public const long m_unVerticalAlign = 0x9D4;
                public const long m_unHorizontalAlign = 0x9D0;
                public const long m_flInteractDistance = 0x9C4;
                public const long m_bOnlyRenderToTexture = 0x9FF;
                public const long m_nExplicitImageLayout = 0xA04;
                public const long m_bExcludeFromSaveGames = 0x9FD;
                public const long m_bUseOffScreenIndicator = 0x9FC;
                public const long m_bIgnoreParentOrientation = 0xA08;
                public const long m_bVisibleWhenParentNoDraw = 0x9FA;
                public const long m_bFollowPlayerAcrossTeleport = 0x9B2;
                public const long m_bAllowInteractionFromAllSceneWorlds = 0x9DC;
            }
            public static partial class CPulseCell_Inflow_Method {
                public const long m_Args = 0xA0;
                public const long m_bIsPublic = 0x98;
                public const long m_MethodName = 0x80;
                public const long m_Description = 0x90;
                public const long m_ReturnValues = 0xB0;
            }
            public static partial class CPulseCell_IntervalTimer {
                public const long m_Completed = 0xD8;
                public const long m_OnInterval = 0x120;
            }
            public static partial class CPulseCell_Step_DebugLog {

            }
            public static partial class CPulse_OutflowConnection {
                public const long m_nDestChunk = 0x10;
                public const long m_nInstruction = 0x14;
                public const long m_SourceOutflowName = 0x0;
                public const long m_OutflowRegisterMap = 0x18;
            }
            public static partial class CSAdditionalMatchStats_t {
                public const long m_flTeamDamage = 0x13C;
                public const long m_iNumSuicides = 0x134;
                public const long m_iNumTeamKills = 0x138;
                public const long m_numFirstKills = 0x124;
                public const long m_numClutchKills = 0x128;
                public const long m_numPistolKills = 0x12C;
                public const long m_numSniperKills = 0x130;
                public const long m_numRoundsSurvivedTotal = 0x118;
                public const long m_numRoundsSurvivedStreak = 0x110;
                public const long m_iRoundsWonWithoutPurchase = 0x11C;
                public const long m_maxNumRoundsSurvivedStreak = 0x114;
                public const long m_iRoundsWonWithoutPurchaseTotal = 0x120;
            }
            public static partial class CSoundOpvarSetAABBEntity {

            }
            public static partial class CSoundOpvarSetDomeEntity {
                public const long m_flSize = 0x734;
                public const long m_bDomeMode = 0x740;
                public const long m_nClusterK = 0x748;
                public const long m_arOpenness = 0x658;
                public const long m_bMultiWall = 0x741;
                public const long m_flClusterP = 0x74C;
                public const long m_arNeighbors = 0x670;
                public const long m_arDirections = 0x640;
                public const long m_arClusterSize = 0x6A8;
                public const long m_nClusterIndex = 0x6F0;
                public const long m_nCurrentIndex = 0x688;
                public const long m_flClusterBlend = 0x750;
                public const long m_arClusterDirSum = 0x6D8;
                public const long m_arClusterParent = 0x690;
                public const long m_arClusterWeight = 0x6C0;
                public const long m_nTracesPerFrame = 0x73C;
                public const long m_flLastSmoothTime = 0x730;
                public const long m_flSmoothHalfLife = 0x75C;
                public const long m_nTotalDirections = 0x738;
                public const long m_vLastTraceOrigin = 0x714;
                public const long m_vSmoothedOpenDir = 0x704;
                public const long m_bTraceOriginValid = 0x720;
                public const long m_vClusterDirection = 0x6F8;
                public const long m_flOpennessExponent = 0x754;
                public const long m_flShoulderExponent = 0x758;
                public const long m_flSmoothedOpenness = 0x72C;
                public const long m_flWallTransmission = 0x744;
                public const long m_flClusteredOpenness = 0x6F4;
                public const long m_bDiscontinuityPending = 0x728;
                public const long m_nCatchUpThinksRemaining = 0x724;
                public const long m_nDirWarmupThinksRemaining = 0x710;
            }
            public static partial class CTouchExpansionComponent {

            }
            public static partial class CTriggerDetectBulletFire {
                public const long m_bPlayerFireOnly = 0x9C8;
                public const long m_OnDetectedBulletFire = 0x9D0;
            }
            public static partial class CAI_ExpresserWithFollowup {

            }
            public static partial class CCS2WeaponGraphController {
                public const long m_action = 0xC0;
                public const long m_attackType = 0x210;
                public const long m_weaponType = 0x120;
                public const long m_reloadStage = 0x288;
                public const long m_bActionReset = 0xD8;
                public const long m_flWeaponAmmo = 0x150;
                public const long m_idleVariation = 0x1E0;
                public const long m_weaponCategory = 0x108;
                public const long m_deployVariation = 0x1F8;
                public const long m_flWeaponAmmoMax = 0x168;
                public const long m_weaponExtraInfo = 0x138;
                public const long m_inspectExtraInfo = 0x270;
                public const long m_inspectVariation = 0x258;
                public const long m_bWeaponIsSilenced = 0x198;
                public const long m_flAttackVariation = 0x240;
                public const long m_attackThrowStrength = 0x228;
                public const long m_bIsUsingLegacyModel = 0x1C8;
                public const long m_flWeaponAmmoReserve = 0x180;
                public const long m_flWeaponIronsightAmount = 0x1B0;
                public const long m_flWeaponActionSpeedScale = 0xF0;
            }
            public static partial class CCSGO_EndOfMatchLineupEnd {

            }
            public static partial class CCSGameModeRules_ArmsRace {
                public const long m_WeaponSequence = 0x30;
            }
            public static partial class CCSPlayer_HostageServices {
                public const long m_hCarriedHostage = 0x48;
                public const long m_hCarriedHostageProp = 0x4C;
            }
            public static partial class CEnvSoundscapeTriggerable {

            }
            public static partial class CFuncInteractionLayerClip {
                public const long m_bDisabled = 0x850;
                public const long m_iszInteractsAs = 0x858;
                public const long m_iszInteractsWith = 0x860;
            }
            public static partial class CInfoChoreoAnchorPosition {
                public const long m_hParent = 0x40;
                public const long m_flRadius = 0x38;
                public const long m_qAnglesLS = 0x10;
                public const long m_vOriginLS = 0x0;
                public const long m_nShapeType = 0x44;
                public const long m_vExtentsMax = 0x2C;
                public const long m_vExtentsMin = 0x20;
                public const long m_bOnlyWarpPosition = 0x3C;
            }
            public static partial class CInfoDynamicShadowHintBox {
                public const long m_vBoxMaxs = 0x4CC;
                public const long m_vBoxMins = 0x4C0;
            }
            public static partial class CInfoInstructorHintTarget {

            }
            public static partial class CInfoSpawnGroupLoadUnload {
                public const long m_bAutoActivate = 0x52C;
                public const long m_iszLandmarkName = 0x518;
                public const long m_bUnloadingStarted = 0x52D;
                public const long m_flTimeoutInterval = 0x528;
                public const long m_iszSpawnGroupName = 0x508;
                public const long m_bQueueFinishLoading = 0x52F;
                public const long m_sFixedSpawnGroupName = 0x520;
                public const long m_OnSpawnGroupLoadStarted = 0x4A8;
                public const long m_iszSpawnGroupFilterName = 0x510;
                public const long m_OnSpawnGroupLoadFinished = 0x4C0;
                public const long m_OnSpawnGroupUnloadStarted = 0x4D8;
                public const long m_OnSpawnGroupUnloadFinished = 0x4F0;
                public const long m_bQueueActiveSpawnGroupChange = 0x52E;
            }
            public static partial class CItemGenericTriggerHelper {
                public const long m_hParentItem = 0x850;
            }
            public static partial class CNetworkTransmitComponent {
                public const long m_nTransmitStateOwnedCounter = 0x184;
            }
            public static partial class CNmAimCSNode__CDefinition {
                public const long m_nIsDefusingNodeIdx = 0x24;
                public const long m_nWeaponDropNodeIdx = 0x22;
                public const long m_nWeaponTypeNodeIdx = 0x1E;
                public const long m_nCrouchWeightNodeIdx = 0x26;
                public const long m_nWeaponActionNodeIdx = 0x20;
                public const long m_nVerticalAngleNodeIdx = 0x18;
                public const long m_nWeaponCategoryNodeIdx = 0x1C;
                public const long m_nHorizontalAngleNodeIdx = 0x1A;
                public const long m_flActionBlendTimeSeconds = 0x2C;
                public const long m_flHandIKBlendInTimeSeconds = 0x28;
                public const long m_flPlantingBlendTimeSeconds = 0x30;
            }
            public static partial class CNmEventConsumerBodyGroup {

            }
            public static partial class CPulseCell_Value_Gradient {
                public const long m_Gradient = 0x48;
            }
            public static partial class CShatterGlassShardPhysics {
                public const long m_ShardDesc = 0x858;
                public const long m_nPoolState = 0x8D8;
                public const long m_hParentShard = 0x850;
                public const long m_bTouchedByPlayer = 0x8DC;
            }
            public static partial class CSimpleMarkupVolumeTagged {

            }
            public static partial class CSoundOpvarSetPointEntity {
                public const long m_OnExit = 0x568;
                public const long m_OnEnter = 0x550;
                public const long m_bReloading = 0x5E5;
                public const long m_bAutoDisable = 0x580;
                public const long m_flDistanceMax = 0x5C8;
                public const long m_flDistanceMin = 0x5C4;
                public const long m_flOcclusionMax = 0x5DC;
                public const long m_flOcclusionMin = 0x5D8;
                public const long m_hDynamicEntity = 0x600;
                public const long m_nSimulationMode = 0x5E8;
                public const long m_flDistanceMapMax = 0x5D0;
                public const long m_flDistanceMapMin = 0x5CC;
                public const long m_flOcclusionRadius = 0x5D4;
                public const long m_flValSetOnDisable = 0x5E0;
                public const long m_vPathingDirection = 0x62C;
                public const long m_vPathingSourcePos = 0x614;
                public const long m_bSetValueOnDisable = 0x5E4;
                public const long m_nVisibilitySamples = 0x5EC;
                public const long m_vDynamicProxyPoint = 0x5F0;
                public const long m_nPathingSourceIndex = 0x638;
                public const long m_vPathingListenerPos = 0x620;
                public const long m_iszDynamicEntityName = 0x608;
                public const long m_flDynamicMaximumOcclusion = 0x5FC;
                public const long m_flPathingDistanceNormFactor = 0x610;
            }
            public static partial class DebugDrawBoneTransforms_t {
                public const long vecBones = 0x10;
            }
            public static partial class ExternalAnimGraphHandle_t {
                public const long m_Value = 0x0;
            }
            public static partial class OutflowWithRequirements_t {
                public const long m_Connection = 0x0;
                public const long m_RequirementNodeIDs = 0x50;
                public const long m_DestinationFlowNodeID = 0x48;
                public const long m_nCursorStateBlockIndex = 0x68;
            }
            public static partial class SignatureOutflow_Continue {

            }
            public static partial class WaterWheelFrictionScale_t {
                public const long m_flFrictionScale = 0x4;
                public const long m_flFractionOfWheelSubmerged = 0x0;
            }
            public static partial class CBtActionCombatPositioning {
                public const long m_bCrouching = 0xA0;
                public const long m_ActionTimer = 0x88;
                public const long m_szIsAttackingKey = 0x80;
                public const long m_szSensorInputKey = 0x68;
            }
            public static partial class CCS2ChickenGraphController {
                public const long m_mode = 0x128;
                public const long m_action = 0xC0;
                public const long m_bFlinch = 0x1B8;
                public const long m_bInWater = 0x110;
                public const long m_idlePhase = 0x158;
                public const long m_lifeStage = 0x140;
                public const long m_turnAngle = 0x170;
                public const long m_bActionReset = 0xD8;
                public const long m_lookatTarget = 0x1A0;
                public const long m_actionVariation = 0xF8;
                public const long m_flinchVariation = 0x1D0;
                public const long m_bHasLookatTarget = 0x188;
                public const long m_bHasActionCompletedEvent = 0x1E8;
            }
            public static partial class CCSObserver_CameraServices {

            }
            public static partial class CCSPlayer_AimPunchServices {
                public const long m_predictableBaseTick = 0x48;
                public const long m_predictableBaseAngle = 0x50;
                public const long m_unpredictableBaseTick = 0xA0;
                public const long m_unpredictableBaseAngle = 0xA4;
                public const long m_predictableBaseAngleVel = 0x5C;
                public const long m_predictableBaseTickInterpAmount = 0x4C;
            }
            public static partial class CCSPlayer_MovementServices {
                public const long m_vecUp = 0x674;
                public const long m_bDucked = 0x408;
                public const long m_vecLeft = 0x668;
                public const long m_bDucking = 0x416;
                public const long m_StuckLast = 0x64C;
                public const long m_flStamina = 0x69C;
                public const long m_LegacyJump = 0x6B8;
                public const long m_ModernJump = 0x6D0;
                public const long m_iFootsteps = 0x688;
                public const long m_vecForward = 0x65C;
                public const long m_flDuckSpeed = 0x410;
                public const long m_nTraceCount = 0x648;
                public const long m_bDesiresDuck = 0x415;
                public const long m_bInStuckTest = 0x43A;
                public const long m_flDuckAmount = 0x40C;
                public const long m_bDuckOverride = 0x414;
                public const long m_bSpeedCropped = 0x650;
                public const long m_nLastJumpTick = 0x708;
                public const long m_AnimationState = 0x310;
                public const long m_flLastDuckTime = 0x420;
                public const long m_flLastJumpFrac = 0x70C;
                public const long m_nOldWaterLevel = 0x654;
                public const long m_vecWalkWishVel = 0x7A8;
                public const long m_vecLadderNormal = 0x3F8;
                public const long m_bJumpApexPending = 0x714;
                public const long m_flDuckRootOffset = 0x418;
                public const long m_flDuckViewOffset = 0x41C;
                public const long m_flWaterEntryTime = 0x658;
                public const long m_duckUntilOnGround = 0x438;
                public const long m_bMadeFootstepNoise = 0x684;
                public const long m_flHeightAtJumpStart = 0x6A0;
                public const long m_flLastJumpVelocityZ = 0x710;
                public const long m_flVelMulAtJumpStart = 0x6B0;
                public const long m_flStaminaAtJumpStart = 0x6AC;
                public const long m_flBombPlantViewOffset = 0x424;
                public const long m_flAccumulatedJumpError = 0x6B4;
                public const long m_flFrictionStashedSpeed = 0x698;
                public const long m_flMaxJumpHeightLastJump = 0x6A8;
                public const long m_flMaxJumpHeightThisJump = 0x6A4;
                public const long m_nLadderSurfacePropIndex = 0x404;
                public const long m_bHasEverProcessedCommand = 0xFD0;
                public const long m_bUseFrictionStashedSpeed = 0x690;
                public const long m_bHasWalkMovedSinceLastJump = 0x439;
                public const long m_bUsingGroundTopologyOffset = 0x3F0;
                public const long m_fStashGrenadeParameterWhen = 0x68C;
                public const long m_flTicksSinceLastSurfingDetected = 0x718;
                public const long m_vecLastPositionAtFullCrouchSpeed = 0x430;
                public const long m_flUseFrictionStashedSpeedUntilFrac = 0x694;
                public const long m_nGameCodeHasMovedPlayerAfterCommand = 0x680;
                public const long m_flUsingGroundTopologyOffsetTransitionSmoothing = 0x3F4;
            }
            public static partial class CNavVolumeCalculatedVector {

            }
            public static partial class CNmEventConsumerAttributes {

            }
            public static partial class CPhysicsBodyGameMarkupData {
                public const long m_PhysicsBodyMarkupByBoneName = 0x0;
            }
            public static partial class CPlayerControllerComponent {
                public const long __m_pChainEntity = 0x8;
            }
            public static partial class CPlayer_FlashlightServices {

            }
            public static partial class CPropDoorRotatingBreakable {
                public const long m_bBreakable = 0xF30;
                public const long m_damageStates = 0xF38;
                public const long m_currentDamageState = 0xF34;
                public const long m_isAbleToCloseAreaPortals = 0xF31;
            }
            public static partial class CPulseCell_BaseRequirement {

            }
            public static partial class CPulseCell_Outflow_PlayVCD {
                public const long m_OnPaused = 0x140;
                public const long m_OnResumed = 0x188;
                public const long m_hChoreoScene = 0x138;
                public const long m_OutRequirements = 0x1D0;
            }
            public static partial class CPulseCell_SoundEventStart {
                public const long m_Type = 0x48;
            }
            public static partial class CPulseCell_Value_RandomInt {

            }
            public static partial class CPulse_BlackboardReference {
                public const long m_nNodeID = 0x18;
                public const long m_NodeName = 0x20;
                public const long m_BlackboardResource = 0x8;
                public const long m_hBlackboardResource = 0x0;
            }
            public static partial class CScriptUniformRandomStream {
                public const long m_hScriptScope = 0x8;
                public const long m_nInitialSeed = 0x9C;
            }
            public static partial class CTriggerActiveWeaponDetect {
                public const long m_iszWeaponClassName = 0x9E0;
                public const long m_OnTouchedActiveWeapon = 0x9C8;
            }
            public static partial class FuncMoverMovementSummary_t {
                public const long nTick = 0x18;
                public const long flEndT = 0x4;
                public const long nFlags = 0x14;
                public const long flStartT = 0x0;
                public const long hPathMover = 0x1C;
                public const long nMovementMode = 0x10;
                public const long nStopNodeIndex = 0xC;
                public const long nStartNodeIndex = 0x8;
            }
            public static partial class PulseNodeDynamicOutflows_t {
                public const long m_Outflows = 0x0;
            }
            public static partial class PulseSelectorOutflowList_t {
                public const long m_Outflows = 0x0;
            }
            public static partial class CAnimGraphControllerManager {
                public const long m_controllers = 0x0;
                public const long m_bGraphBindingsCreated = 0x90;
            }
            public static partial class CBodyComponentBaseAnimGraph {
                public const long m_animationController = 0x4E0;
            }
            public static partial class CCSGO_EndOfMatchLineupStart {

            }
            public static partial class CCSGameModeRules_Deathmatch {
                public const long m_sDMBonusWeapon = 0x38;
                public const long m_flDMBonusStartTime = 0x30;
                public const long m_flDMBonusTimeLength = 0x34;
            }
            public static partial class CDestructiblePartsComponent {
                public const long m_hOwner = 0x60;
                public const long __m_pChainEntity = 0x0;
                public const long m_vecDamageTakenByHitGroup = 0x48;
                public const long m_pAnimGraphDestructibleGraphController = 0x68;
            }
            public static partial class CDynamicPropGraphController {
                public const long m_sActionState = 0xC0;
            }
            public static partial class CEnvVolumetricFogController {
                public const long m_bActive = 0x4F4;
                public const long m_vBoxMaxs = 0x4E8;
                public const long m_vBoxMins = 0x4DC;
                public const long m_TintColor = 0x4AC;
                public const long m_bIsMaster = 0x51E;
                public const long m_bFirstTime = 0x550;
                public const long m_fWindSpeed = 0x540;
                public const long m_fNoiseSpeed = 0x52C;
                public const long m_flFadeInEnd = 0x4C0;
                public const long m_flFadeSpeed = 0x4B4;
                public const long m_vNoiseScale = 0x534;
                public const long m_flAnisotropy = 0x4B0;
                public const long m_flScattering = 0x4A8;
                public const long m_nVolumeDepth = 0x4C8;
                public const long m_flFadeInStart = 0x4BC;
                public const long m_bStartDisabled = 0x51C;
                public const long m_fNoiseStrength = 0x530;
                public const long m_flDrawDistance = 0x4B8;
                public const long m_vWindDirection = 0x544;
                public const long m_bEnableIndirect = 0x51D;
                public const long m_flStartAnisoTime = 0x4F8;
                public const long m_flStartAnisotropy = 0x504;
                public const long m_flStartScattering = 0x508;
                public const long m_flIndirectStrength = 0x4C4;
                public const long m_flStartScatterTime = 0x4FC;
                public const long m_nForceRefreshCount = 0x528;
                public const long m_flDefaultAnisotropy = 0x510;
                public const long m_flDefaultScattering = 0x514;
                public const long m_flStartDrawDistance = 0x50C;
                public const long m_hFogIndirectTexture = 0x520;
                public const long m_nIndirectTextureDimX = 0x4D0;
                public const long m_nIndirectTextureDimY = 0x4D4;
                public const long m_nIndirectTextureDimZ = 0x4D8;
                public const long m_flDefaultDrawDistance = 0x518;
                public const long m_flStartDrawDistanceTime = 0x500;
                public const long m_fFirstVolumeSliceThickness = 0x4CC;
            }
            public static partial class CInfoPlayerCounterterrorist {

            }
            public static partial class CMarkupVolumeTagged_NavGame {
                public const long m_nScopes = 0x8B8;
                public const long m_bSplitNavSpace = 0x8BA;
                public const long m_bFloodFillAttribute = 0x8B9;
            }
            public static partial class CNetworkedSequenceOperation {
                public const long m_flCycle = 0x10;
                public const long m_flWeight = 0x14;
                public const long m_hSequence = 0x8;
                public const long m_flPrevCycle = 0xC;
                public const long m_bDiscontinuity = 0x1D;
                public const long m_bSequenceChangeNetworked = 0x1C;
                public const long m_flPrevCycleFromDiscontinuity = 0x20;
                public const long m_flPrevCycleForAnimEventDetection = 0x24;
            }
            public static partial class CPointAngularVelocitySensor {
                public const long m_vecAxis = 0x4D0;
                public const long m_OnEqualTo = 0x560;
                public const long m_OnLessThan = 0x500;
                public const long m_bUseHelper = 0x4DC;
                public const long m_flFireTime = 0x4B8;
                public const long m_flThreshold = 0x4AC;
                public const long m_OnGreaterThan = 0x530;
                public const long m_hTargetEntity = 0x4A8;
                public const long m_flFireInterval = 0x4BC;
                public const long m_AngularVelocity = 0x4E0;
                public const long m_lastOrientation = 0x4C4;
                public const long m_nLastFireResult = 0x4B4;
                public const long m_flLastAngVelocity = 0x4C0;
                public const long m_nLastCompareResult = 0x4B0;
                public const long m_OnLessThanOrEqualTo = 0x518;
                public const long m_OnGreaterThanOrEqualTo = 0x548;
            }
            public static partial class CPulseCell_ApplyEntityFlags {

            }
            public static partial class CPulseCell_Inflow_GraphHook {
                public const long m_HookName = 0x80;
            }
            public static partial class CSAdditionalPerRoundStats_t {
                public const long m_iDinks = 0x14;
                public const long m_nDefuseStarts = 0x1C;
                public const long m_killsWhileBlind = 0x4;
                public const long m_nHostagePickUps = 0x20;
                public const long m_bombCarrierkills = 0x8;
                public const long m_numChickensKilled = 0x0;
                public const long m_numTeammatesFlashed = 0x24;
                public const long m_bBombPlantedAndAlive = 0x19;
                public const long m_bFreshStartThisRound = 0x18;
                public const long m_flBurnDamageInflicted = 0xC;
                public const long m_flBlastDamageInflicted = 0x10;
                public const long m_strAnnotationsWorkshopId = 0x28;
            }
            public static partial class CSoundAreaEntityOrientedBox {
                public const long m_vMax = 0x4D4;
                public const long m_vMin = 0x4C8;
            }
            public static partial class CSoundEventMultiPointEntity {
                public const long m_bPlaying = 0x578;
                public const long m_iCountMax = 0x568;
                public const long m_flDistMaxSqr = 0x570;
                public const long m_flDistanceMax = 0x56C;
                public const long m_flDotProductMax = 0x574;
            }
            public static partial class CSoundEventPathCornerEntity {
                public const long m_iszPathCorner = 0x5A0;
                public const long m_vecCornerPairsNetworked = 0x5C0;
            }
            public static partial class CSoundOpvarSetOBBWindEntity {
                public const long m_vMaxs = 0x55C;
                public const long m_vMins = 0x550;
                public const long m_flWindMax = 0x584;
                public const long m_flWindMin = 0x580;
                public const long m_flWindMapMax = 0x58C;
                public const long m_flWindMapMin = 0x588;
                public const long m_vDistanceMaxs = 0x574;
                public const long m_vDistanceMins = 0x568;
            }
            public static partial class PulseScriptedSequenceData_t {
                public const long m_nMoveTo = 0x28;
                public const long m_nActorID = 0x0;
                public const long m_szSequence = 0x18;
                public const long m_nMoveToGait = 0x2C;
                public const long m_bIgnoreLookAt = 0x37;
                public const long m_szExitSequence = 0x20;
                public const long m_szEntrySequence = 0x10;
                public const long m_szPreIdleSequence = 0x8;
                public const long m_bLoopActionSequence = 0x35;
                public const long m_nHeldWeaponBehavior = 0x30;
                public const long m_bLoopPreIdleSequence = 0x34;
                public const long m_bLoopPostIdleSequence = 0x36;
            }
            public static partial class CCSObserver_MovementServices {

            }
            public static partial class CCSObserver_ObserverServices {

            }
            public static partial class CCSPlayerBase_CameraServices {
                public const long m_iFOV = 0x178;
                public const long m_flFOVRate = 0x184;
                public const long m_flFOVTime = 0x180;
                public const long m_iFOVStart = 0x17C;
                public const long m_hZoomOwner = 0x188;
                public const long m_hLastFogTrigger = 0x1A8;
                public const long m_hTriggerFogList = 0x190;
            }
            public static partial class CDestructiblePartsSystemData {
                public const long m_PartsDataByHitGroup = 0x0;
                public const long m_nMinMaxNumberHitGroupsToDestroyWhenGibbing = 0x28;
            }
            public static partial class CDynamicNavConnectionsVolume {
                public const long m_vecConnections = 0x9E8;
                public const long m_sTransitionType = 0xA00;
                public const long m_flUpdateDistance = 0xA10;
                public const long m_bConnectionsEnabled = 0xA08;
                public const long m_iszConnectionTarget = 0x9E0;
                public const long m_flMaxConnectionDistance = 0xA14;
                public const long m_flTargetAreaSearchRadius = 0xA0C;
            }
            public static partial class CEnvCombinedLightProbeVolume {
                public const long m_Entity_Color = 0x5C0;
                public const long m_Entity_bEnabled = 0x679;
                public const long m_Entity_vBoxMaxs = 0x61C;
                public const long m_Entity_vBoxMins = 0x610;
                public const long m_Entity_bMoveable = 0x628;
                public const long m_Entity_nPriority = 0x634;
                public const long m_Entity_nHandshake = 0x62C;
                public const long m_Entity_flBrightness = 0x5C4;
                public const long m_Entity_bStartDisabled = 0x638;
                public const long m_Entity_flEdgeFadeDist = 0x63C;
                public const long m_Entity_vEdgeFadeDists = 0x640;
                public const long m_Entity_hCubemapTexture = 0x5C8;
                public const long m_Entity_nLightProbeSizeX = 0x64C;
                public const long m_Entity_nLightProbeSizeY = 0x650;
                public const long m_Entity_nLightProbeSizeZ = 0x654;
                public const long m_Entity_nLightProbeAtlasX = 0x658;
                public const long m_Entity_nLightProbeAtlasY = 0x65C;
                public const long m_Entity_nLightProbeAtlasZ = 0x660;
                public const long m_Entity_bCustomCubemapTexture = 0x5D0;
                public const long m_Entity_nEnvCubeMapArrayIndex = 0x630;
                public const long m_Entity_hLightProbeTexture_SDF = 0x5E0;
                public const long m_Entity_hLightProbeTexture_SH2_DC = 0x5E8;
                public const long m_Entity_hLightProbeTexture_SH2_L1 = 0x5F0;
                public const long m_Entity_hLightProbeTexture_AmbientCube = 0x5D8;
                public const long m_Entity_hLightProbeDirectLightIndicesTexture = 0x5F8;
                public const long m_Entity_hLightProbeDirectLightScalarsTexture = 0x600;
                public const long m_Entity_hLightProbeDirectLightShadowsTexture = 0x608;
            }
            public static partial class CNavVolumeBreadthFirstSearch {
                public const long m_vStartPos = 0xA8;
                public const long m_flSearchDist = 0xB4;
            }
            public static partial class CPointBroadcastClientCommand {

            }
            public static partial class CPointClientUIWorldTextPanel {
                public const long m_messageText = 0xA10;
            }
            public static partial class CPulseCell_Step_FollowEntity {
                public const long m_ParamBoneOrAttachName = 0x48;
                public const long m_ParamBoneOrAttachNameChild = 0x50;
            }
            public static partial class CPulseCell_Step_PublicOutput {
                public const long m_OutputIndex = 0x48;
            }
            public static partial class CPulseCell_Value_RandomFloat {

            }
            public static partial class CPulseCell_WaitForObservable {
                public const long m_OnTrue = 0x168;
                public const long m_Condition = 0xD8;
            }
            public static partial class CRopeKeyframeAlias_move_rope {

            }
            public static partial class CSkeletonAnimationController {
                public const long m_pSkeletonInstance = 0x8;
            }
            public static partial class CSoundOpvarSetAutoRoomEntity {
                public const long m_flSize = 0x670;
                public const long m_flSizeSqr = 0x678;
                public const long m_doorwayPairs = 0x658;
                public const long m_traceResults = 0x640;
                public const long m_flHeightTolerance = 0x674;
            }
            public static partial class CTakeDamageSummaryScopeGuard {
                public const long m_vecSummaries = 0x8;
            }
            public static partial class FuncRotatorRotationSummary_t {
                public const long nTick = 0x0;
                public const long nFlags = 0x4;
            }
            public static partial class ISkeletonAnimationController {

            }
            public static partial class SimpleConstraintSoundProfile {
                public const long m_flKeyPointMaxSoundThreshold = 0xC;
                public const long m_flKeyPointMinSoundThreshold = 0x8;
                public const long m_reversalSoundThresholdLarge = 0x18;
                public const long m_reversalSoundThresholdSmall = 0x10;
                public const long m_reversalSoundThresholdMedium = 0x14;
            }
            public static partial class VPhysicsCollisionAttribute_t {
                public const long m_nOwnerId = 0x24;
                public const long m_nEntityId = 0x20;
                public const long m_nHierarchyId = 0x28;
                public const long m_nInteractsAs = 0x8;
                public const long m_nInteractsWith = 0x10;
                public const long m_nCollisionGroup = 0x2E;
                public const long m_nDetailLayerMask = 0x2A;
                public const long m_nInteractsExclude = 0x18;
                public const long m_nTargetDetailLayer = 0x2D;
                public const long m_nDetailLayerMaskType = 0x2C;
                public const long m_nCollisionFunctionMask = 0x2F;
            }
            public static partial class CBodyComponentBaseModelEntity {

            }
            public static partial class CBtActionParachutePositioning {
                public const long m_ActionTimer = 0x58;
            }
            public static partial class CCSPlayer_DamageReactServices {

            }
            public static partial class CDestructiblePart_DamageLevel {
                public const long m_sName = 0x0;
                public const long m_nHealth = 0x14;
                public const long m_nBodyGroupValue = 0x10;
                public const long m_flDeathDestroyTime = 0x3C;
                public const long m_sBreakablePieceName = 0x8;
                public const long m_bShouldDestroyOnDeath = 0x38;
                public const long m_sCustomDeathHandshake = 0x30;
                public const long m_nDamagePassthroughType = 0x28;
                public const long m_flCriticalDamagePercent = 0x24;
                public const long m_nDestructionDeathBehavior = 0x2C;
            }
            public static partial class CInfoOffscreenPanoramaTexture {
                public const long m_bDisabled = 0x4A8;
                public const long m_szPanelType = 0x4B8;
                public const long m_nResolutionX = 0x4AC;
                public const long m_nResolutionY = 0x4B0;
                public const long m_bEnableMipGen = 0x4A9;
                public const long m_szTargetsName = 0x508;
                public const long m_vecCSSClasses = 0x4F0;
                public const long m_RenderAttrName = 0x4C8;
                public const long m_TargetEntities = 0x4D0;
                public const long m_szLayoutFileName = 0x4C0;
                public const long m_nTargetChangeCount = 0x4E8;
                public const long m_AdditionalTargetEntities = 0x510;
            }
            public static partial class CNetworkOriginQuantizedVector {
                public const long m_vecX = 0x10;
                public const long m_vecY = 0x18;
                public const long m_vecZ = 0x20;
            }
            public static partial class CPulseCell_BaseYieldingInflow {
                public const long m_BaseFlow_WhileActive = 0x90;
                public const long m_BaseFlow_OnAfterCancel = 0x48;
            }
            public static partial class CPulseCell_BooleanSwitchState {
                public const long m_WhenTrue = 0x168;
                public const long m_Condition = 0xD8;
                public const long m_WhenFalse = 0x1B0;
            }
            public static partial class CPulseCell_IsRequirementValid {

            }
            public static partial class CPulseCell_LerpCameraSettings {
                public const long m_End = 0x134;
                public const long m_Start = 0x124;
                public const long m_flSeconds = 0x120;
            }
            public static partial class CPulseCell_Outflow_PlayVOLine {
                public const long m_OnFinished = 0xD8;
            }
            public static partial class CTestPulseIOComponent_Derived {

            }
            public static partial class AI_BaseNPC_DebugSnapshotData_t {
                public const long animgraph = 0x70;
                public const long navigator = 0xB8;
                public const long npc_state = 0x8;
                public const long conditions = 0x40;
                public const long anim_events = 0x58;
                public const long current_enemy = 0x10;
                public const long motorServices = 0x108;
                public const long facingServices = 0x140;
                public const long s_current_task = 0x20;
                public const long s_prev_schedule = 0x28;
                public const long s_current_schedule = 0x18;
                public const long s_npc_current_movement = 0x30;
                public const long s_last_task_end_location = 0x38;
            }
            public static partial class CBodyComponentSkeletonInstance {
                public const long m_skeletonInstance = 0x80;
            }
            public static partial class CCSGO_EndOfMatchLineupEndpoint {

            }
            public static partial class CDynamicPropAlias_dynamic_prop {

            }
            public static partial class CFloatExponentialMovingAverage {

            }
            public static partial class CInfoInstructorHintBombTargetA {

            }
            public static partial class CInfoInstructorHintBombTargetB {

            }
            public static partial class CItemDefuserAlias_item_defuser {

            }
            public static partial class CNmSnapWeaponNode__CDefinition {
                public const long m_nWeaponTypeNodeIdx = 0x1C;
                public const long m_nFlashedAmountNodeIdx = 0x18;
                public const long m_nWeaponCategoryNodeIdx = 0x1A;
            }
            public static partial class CPulseCell_ApplyAnimGraphParam {
                public const long m_value = 0xD8;
            }
            public static partial class CPulseCell_Inflow_EventHandler {
                public const long m_EventName = 0x80;
            }
            public static partial class CPulseCell_Outflow_CycleRandom {
                public const long m_Outputs = 0x48;
            }
            public static partial class CPulseCell_Outflow_PlayVCDBase {

            }
            public static partial class CSoundOpvarSetPathCornerEntity {
                public const long m_flDistMaxSqr = 0x660;
                public const long m_flDistMinSqr = 0x65C;
                public const long m_bUseParentedPath = 0x658;
                public const long m_iszPathCornerEntityName = 0x668;
            }
            public static partial class HUDPanelDialogVariableString_t {
                public const long m_bIsSet = 0x18;
                public const long m_sValue = 0x10;
                public const long m_nPanelIdIndex = 0x8;
                public const long m_nDialogVariableIndex = 0xA;
            }
            public static partial class SoundeventBoxHelperNetworked_t {
                public const long vMaxs = 0x24;
                public const long vMins = 0x18;
                public const long qAngles = 0xC;
                public const long vOrigin = 0x0;
            }
            public static partial class CBaseAnimGraphVariationUserData {

            }
            public static partial class CDynamicPropAlias_cable_dynamic {

            }
            public static partial class CNetworkOriginQuantizedVectorWS {
                public const long m_vecX = 0x10;
                public const long m_vecY = 0x18;
                public const long m_vecZ = 0x20;
            }
            public static partial class CPulseCell_Outflow_CycleOrdered {
                public const long m_Outputs = 0x48;
            }
            public static partial class CPulseCell_Outflow_PlaySequence {
                public const long m_ParamSequenceName = 0x138;
            }
            public static partial class CTestPulseIO__FloatStringArgs_t {
                public const long flOutFloat = 0x0;
                public const long strOutString = 0x8;
            }
            public static partial class CTestPulseIO__ThreeStringArgs_t {
                public const long strArg1 = 0x0;
                public const long strArg2 = 0x8;
                public const long strArg3 = 0x10;
            }
            public static partial class CVectorExponentialMovingAverage {

            }
            public static partial class DestructiblePartDamageRequest_t {
                public const long m_hAttacker = 0x1C;
                public const long m_nHitGroup = 0x0;
                public const long m_nDamageType = 0x10;
                public const long m_nDamageLevel = 0x4;
                public const long m_flBreakDamage = 0x14;
                public const long m_nDestroyFlags = 0xC;
                public const long m_nDesiredHealth = 0x8;
                public const long m_flBreakDamageRadius = 0x18;
                public const long m_vWsBreakDamageForce = 0x2C;
                public const long m_vWsBreakDamageOrigin = 0x20;
            }
            public static partial class ServerAuthoritativeWeaponSlot_t {
                public const long unSlot = 0x32;
                public const long unClass = 0x30;
                public const long unItemDefIdx = 0x34;
            }
            public static partial class AI_Navigator_DebugSnapshotData_t {
                public const long waypoints = 0x30;
                public const long goal_location = 0x24;
                public const long s_movement_id = 0x0;
                public const long last_waypoint_pos = 0x18;
                public const long s_goal_source_location = 0x10;
                public const long s_movement_serial_number = 0x8;
                public const long s_arrival_movement_gait_set = 0x48;
            }
            public static partial class CCSGO_RushIntroCharacterPosition {

            }
            public static partial class CCSGO_RushIntroTerroristPosition {

            }
            public static partial class CCSGO_TeamIntroCharacterPosition {

            }
            public static partial class CCSGO_TeamIntroTerroristPosition {

            }
            public static partial class CCSPlayer_ActionTrackingServices {
                public const long m_bIsRescuing = 0x224;
                public const long m_weaponPurchasesThisMatch = 0x228;
                public const long m_weaponPurchasesThisRound = 0x298;
                public const long m_weaponCarryOverIntoThisRound = 0x308;
                public const long m_hLastWeaponBeforeC4AutoSwitch = 0x1F8;
            }
            public static partial class CHostageAlias_info_hostage_spawn {

            }
            public static partial class CMarkupSearch_PathCostAreaFilter {
                public const long m_searchHelper = 0x8;
            }
            public static partial class CPhysHingeAlias_phys_hinge_local {

            }
            public static partial class CPulseCell_Inflow_BaseEntrypoint {
                public const long m_EntryChunk = 0x48;
                public const long m_RegisterMap = 0x50;
            }
            public static partial class CPulseCell_Outflow_CycleShuffled {
                public const long m_Outputs = 0x48;
            }
            public static partial class CPulseCell_Outflow_PlaySceneBase {
                public const long m_Triggers = 0x120;
                public const long m_OnFinished = 0xD8;
            }
            public static partial class CPulseCell_WaitForCursorsWithTag {
                public const long m_bTagSelfWhenComplete = 0x128;
                public const long m_nDesiredKillPriority = 0x12C;
            }
            public static partial class CPulseGraphInstance_ServerEntity {
                public const long m_hOwner = 0x118;
                public const long m_bActivated = 0x11C;
                public const long m_sNameFixupLocal = 0x130;
                public const long m_sNameFixupParent = 0x128;
                public const long m_sNameFixupStaticPrefix = 0x120;
                public const long m_sProceduralWorldNameForRelays = 0x138;
            }
            public static partial class AI_DefaultNPC_DebugSnapshotData_t {
                public const long path_query = 0x40;
                public const long s_npc_tactic_phase = 0x20;
                public const long s_npc_tactic_current = 0x18;
                public const long s_npc_current_ability = 0x8;
                public const long path_queries_speculative = 0x68;
                public const long s_npc_current_held_ability = 0x10;
                public const long tactic_interrupt_conditions = 0x28;
            }
            public static partial class CBaseAnimGraphAlias_baseanimating {

            }
            public static partial class CCSGO_TeamSelectCharacterPosition {

            }
            public static partial class CCSGO_TeamSelectTerroristPosition {

            }
            public static partial class CPlayer_MovementServices_Humanoid {
                public const long m_nStepside = 0x280;
                public const long m_groundNormal = 0x260;
                public const long m_surfaceProps = 0x270;
                public const long m_flFallVelocity = 0x25C;
                public const long m_flStepSoundTime = 0x258;
                public const long m_flSurfaceFriction = 0x26C;
                public const long m_vecSmoothedVelocity = 0x284;
            }
            public static partial class CPulseCell_InlineNodeSkipSelector {
                public const long m_bAnd = 0x4C;
                public const long m_FailOutflow = 0x68;
                public const long m_PassOutflow = 0x50;
                public const long m_nFlowNodeID = 0x48;
            }
            public static partial class CPulseCell_LimitCount__Criteria_t {
                public const long m_bLimitCountPasses = 0x0;
            }
            public static partial class CPulseCell_Outflow_PlayDynamicVCD {

            }
            public static partial class CPulseCell_Step_SetAnimGraphParam {
                public const long m_ParamName = 0x48;
            }
            public static partial class DebugSnapshotBaseStructuredData_t {

            }
            public static partial class CCSGO_TeamPreviewCharacterPosition {
                public const long m_xuid = 0x4C0;
                public const long m_nRandom = 0x4AC;
                public const long m_petItem = 0x1080;
                public const long m_nOrdinal = 0x4B0;
                public const long m_nVariant = 0x4A8;
                public const long m_agentItem = 0x4C8;
                public const long m_glovesItem = 0x8B0;
                public const long m_weaponItem = 0xC98;
                public const long m_sWeaponName = 0x4B8;
            }
            public static partial class CCSPlayerController_DamageServices {
                public const long m_DamageList = 0x48;
                public const long m_nSendUpdate = 0x40;
            }
            public static partial class CEnvSoundscapeAlias_snd_soundscape {

            }
            public static partial class CPulseCell_BaseLerp__CursorState_t {
                public const long m_EndTime = 0x4;
                public const long m_StartTime = 0x0;
            }
            public static partial class CPulseCell_Inflow_EntOutputHandler {
                public const long m_SourceEntity = 0x80;
                public const long m_SourceOutput = 0x90;
                public const long m_ExpectedParamType = 0xA0;
            }
            public static partial class CPulseCell_PickBestOutflowSelector {
                public const long m_nCheckType = 0x48;
                public const long m_OutflowList = 0x50;
            }
            public static partial class CPulseCell_Step_CallExternalMethod {
                public const long m_MethodName = 0xD8;
                public const long m_OnFinished = 0x108;
                public const long m_ExpectedArgs = 0xF0;
                public const long m_nAsyncCallMode = 0x100;
                public const long m_nBlackboardIndex = 0xE8;
            }
            public static partial class CPulseGraphInstance_GameBlackboard {

            }
            public static partial class CCSGO_WingmanIntroCharacterPosition {

            }
            public static partial class CCSGO_WingmanIntroTerroristPosition {

            }
            public static partial class CFuncLadderAlias_func_useableladder {

            }
            public static partial class CFuncMoveLinearAlias_momentary_door {

            }
            public static partial class CPulseCell_ApplyDynamicAttributeInt {

            }
            public static partial class CPulseCell_Outflow_ScriptedSequence {
                public const long m_Triggers = 0x180;
                public const long m_OnFinished = 0x138;
                public const long m_szSyncGroup = 0xD8;
                public const long m_bDontTeleportAtEnd = 0xE5;
                public const long m_bDisallowInterrupts = 0xE6;
                public const long m_vecAdditionalActors = 0x120;
                public const long m_bEnsureOnNavmeshOnFinish = 0xE4;
                public const long m_scriptedSequenceDataMain = 0xE8;
                public const long m_nExpectedNumSequencesInSyncGroup = 0xE0;
            }
            public static partial class CTestPulseIO__EntityHandleIntArgs_t {
                public const long valueB = 0x4;
                public const long handleA = 0x0;
            }
            public static partial class SoundeventPathCornerPairNetworked_t {
                public const long vP1 = 0x0;
                public const long vP2 = 0xC;
                public const long flP1Pct = 0x1C;
                public const long flP2Pct = 0x20;
                public const long flPathLengthSqr = 0x18;
            }
            public static partial class AI_MotorServices_DebugSnapshotData_t {
                public const long motor_path = 0x18;
                public const long active_motor = 0x0;
                public const long desired_speed = 0x8;
                public const long motor_velocity = 0xC;
                public const long ground_entity_debug_name = 0x30;
            }
            public static partial class AnimGraph2SerializedPoseRecipeSlot_t {
                public const long m_topology = 0x30;
            }
            public static partial class CBaseModelEntity__BodyGroupRequest_t {
                public const long m_nGroup = 0x10;
                public const long m_uChoice = 0x14;
                public const long m_uRefCount = 0x16;
                public const long m_nGroupName = 0x4;
                public const long m_uRequestID = 0x0;
                public const long m_sChoiceName = 0x8;
            }
            public static partial class CInfoInstructorHintHostageRescueZone {

            }
            public static partial class CPulseCell_ApplyDynamicAttributeBase {

            }
            public static partial class CPulseCell_Timeline__TimelineEvent_t {
                public const long m_EventOutflow = 0x8;
                public const long m_flTimeFromPrevious = 0x0;
            }
            public static partial class CPulseCell_WaitForCursorsWithTagBase {
                public const long m_WaitComplete = 0xE0;
                public const long m_nCursorsAllowedToWait = 0xD8;
            }
            public static partial class CTestPulseIO__EntityNameStringArgs_t {
                public const long nameA = 0x0;
                public const long strValueB = 0x8;
            }
            public static partial class AI_FacingServices_DebugSnapshotData_t {
                public const long movement_id = 0x40;
                public const long npc_position = 0x0;
                public const long facing_target = 0x18;
                public const long strafing_source = 0x30;
                public const long strafing_enabled = 0x38;
                public const long facing_target_source = 0x10;
                public const long schedule_facing_priority = 0x28;
            }
            public static partial class CCSPlayerController_InventoryServices {
                public const long m_rank = 0x44;
                public const long m_unMusicID = 0x40;
                public const long m_unCurrentLoadoutHash = 0xF90;
                public const long m_nPersonaDataPublicLevel = 0x5C;
                public const long m_nPersonaDataXpTrailLevel = 0x6C;
                public const long m_unEquippedPlayerSprayIDs = 0xF88;
                public const long m_nPersonaDataPublicCommendsLeader = 0x60;
                public const long m_nPersonaDataPublicCommendsTeacher = 0x64;
                public const long m_vecServerAuthoritativeWeaponSlots = 0xF98;
                public const long m_nPersonaDataPublicCommendsFriendly = 0x68;
            }
            public static partial class CPulseCell_ApplyParent__CursorState_t {
                public const long m_hChildEntity = 0x4;
                public const long m_hParentEntity = 0x0;
            }
            public static partial class CNetworkOriginCellCoordQuantizedVector {
                public const long m_vecX = 0x18;
                public const long m_vecY = 0x20;
                public const long m_vecZ = 0x28;
                public const long m_cellX = 0x10;
                public const long m_cellY = 0x12;
                public const long m_cellZ = 0x14;
                public const long m_nOutsideWorld = 0x16;
            }
            public static partial class CPulseCell_ApplyDynamicAttributeString {

            }
            public static partial class CPulseCell_LimitCount__InstanceState_t {
                public const long m_nCurrentCount = 0x0;
            }
            public static partial class CPulseCell_PlaySequence__CursorState_t {
                public const long m_hTarget = 0x0;
            }
            public static partial class CRagdollPropAlias_physics_prop_ragdoll {

            }
            public static partial class CSoundEventEntityAlias_snd_event_point {

            }
            public static partial class AI_BaseNPCAnimGraph_DebugSnapshotData_t {
                public const long ag2_update_id = 0x0;
                public const long e_action_desired = 0x8;
                public const long e_movement_type_desired = 0x28;
                public const long e_action_handshake_restart = 0x10;
                public const long e_movement_handshake_restart = 0x30;
                public const long e_action_handshake_body_authority_current = 0x18;
                public const long e_action_handshake_body_authority_desired = 0x20;
                public const long e_movement_handshake_body_authority_current = 0x38;
                public const long e_movement_handshake_body_authority_desired = 0x40;
            }
            public static partial class CCSGO_RushIntroCounterTerroristPosition {

            }
            public static partial class CCSGO_TeamIntroCounterTerroristPosition {

            }
            public static partial class CCSPlayerController_InGameMoneyServices {
                public const long m_iAccount = 0x48;
                public const long m_iStartAccount = 0x4C;
                public const long m_iTotalCashSpent = 0x50;
                public const long m_iCashSpentThisRound = 0x54;
                public const long m_bReceivesMoneyNextRound = 0x40;
                public const long m_iMoneyEarnedForNextRound = 0x44;
            }
            public static partial class CDynamicPropAlias_prop_dynamic_override {

            }
            public static partial class CPulseCell_ApplyDynamicAttributeEHandle {

            }
            public static partial class CPulseCell_IntervalTimer__CursorState_t {
                public const long m_EndTime = 0x4;
                public const long m_StartTime = 0x0;
                public const long m_flWaitInterval = 0x8;
                public const long m_flWaitIntervalHigh = 0xC;
                public const long m_bCompleteOnNextWake = 0x10;
            }
            public static partial class CCSGO_TeamSelectCounterTerroristPosition {

            }
            public static partial class CNetworkOriginCellCoordQuantizedVectorWS {
                public const long m_vecX = 0x18;
                public const long m_vecY = 0x20;
                public const long m_vecZ = 0x28;
                public const long m_cellX = 0x10;
                public const long m_cellY = 0x12;
                public const long m_cellZ = 0x14;
                public const long m_nOutsideWorld = 0x16;
            }
            public static partial class CPulseCell_Outflow_ListenForAnimgraphTag {
                public const long m_OnEnd = 0x120;
                public const long m_OnStart = 0xD8;
                public const long m_TagName = 0x168;
            }
            public static partial class CPulseCell_Outflow_ListenForEntityOutput {
                public const long m_OnFired = 0xD8;
                public const long m_strEntityOutput = 0x120;
                public const long m_bListenUntilCanceled = 0x128;
            }
            public static partial class CWorldCompositionChunkReferenceElement_t {
                public const long m_strMapToLoad = 0x0;
                public const long m_strLandmarkName = 0x8;
            }
            public static partial class CPulseCell_IsRequirementValid__Criteria_t {
                public const long m_bIsValid = 0x0;
            }
            public static partial class CCSGO_WingmanIntroCounterTerroristPosition {

            }
            public static partial class CCSPlayerController_ActionTrackingServices {
                public const long m_matchStats = 0xC8;
                public const long m_perRoundStats = 0x40;
                public const long m_iNumRoundKills = 0x188;
                public const long m_flTotalRoundDamageDealt = 0x190;
                public const long m_iNumRoundKillsHeadshots = 0x18C;
            }
            public static partial class CPulseCell_ApplyEntityFlags__CursorState_t {
                public const long m_uFlags = 0x4;
                public const long m_hEntity = 0x0;
            }
            public static partial class CAttributeManager__cached_attribute_float_t {
                public const long flIn = 0x0;
                public const long flOut = 0x10;
                public const long iAttribHook = 0x8;
            }
            public static partial class CSceneEntityAlias_logic_choreographed_scene {

            }
            public static partial class AI_GroundRootMotionMotor_DebugSnapshotData_t {
                public const long state = 0x40;
                public const long move_type = 0x58;
                public const long b_has_path = 0x4C;
                public const long vec_events = 0x78;
                public const long f_target_lean = 0x70;
                public const long f_current_lean = 0x6C;
                public const long f_current_speed = 0x54;
                public const long movement_setting_id = 0x28;
                public const long current_movement_gait = 0x20;
                public const long desired_movement_gait = 0x10;
                public const long b_goal_completion_allowed = 0x38;
                public const long current_movement_gait_set = 0x18;
                public const long desired_movement_gait_set = 0x8;
                public const long n_state_active_tick_count = 0x48;
                public const long gait_switch_blocked_reason = 0x30;
                public const long f_remaining_ground_path_length = 0x50;
                public const long f_forward_strafing_angle_actual = 0x60;
                public const long f_forward_strafing_angle_desired = 0x64;
                public const long f_forward_strafing_angle_committed = 0x68;
            }
            public static partial class AI_Navigator_DebugSnapshotData_t__Waypoint_t {
                public const long flags = 0x10;
                public const long nav_type = 0xC;
                public const long position = 0x0;
                public const long is_pathcorner = 0x14;
            }
            public static partial class CBaseModelEntity__OnDamageLevelChangedArgs_t {
                public const long nHitGroup = 0x0;
                public const long nDamageLevel = 0x4;
                public const long nPrevDamageLevel = 0xC;
                public const long nDamageLevelsRemaining = 0x8;
            }
            public static partial class CPulseCell_Inflow_ObservableVariableListener {
                public const long m_bSelfReference = 0x82;
                public const long m_nBlackboardReference = 0x80;
            }
            public static partial class CPulseCell_LerpCameraSettings__CursorState_t {
                public const long m_hCamera = 0x8;
                public const long m_OverlaidEnd = 0x1C;
                public const long m_OverlaidStart = 0xC;
            }
            public static partial class CPulseCell_Outflow_PlayVOLine__CursorState_t {
                public const long m_sceneInstance = 0x0;
            }
            public static partial class PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                public const long m_OutflowID = 0x0;
                public const long m_Connection = 0x8;
            }
            public static partial class CEnvSoundscapeProxyAlias_snd_soundscape_proxy {

            }
            public static partial class CPulseCell_ApplyAnimGraphParam__CursorState_t {
                public const long hEntity = 0x0;
                public const long sParamName = 0x8;
                public const long bApplyToExternalGraphs = 0x10;
            }
            public static partial class AI_DefaultNPC_DebugSnapshotData_t__PathQuery_t {
                public const long m_nMode = 0x10;
                public const long m_nType = 0x18;
                public const long m_nState = 0x20;
                public const long m_nCurrentMovementId = 0x8;
                public const long m_nInitialMovementId = 0x0;
            }
            public static partial class CBaseAnimGraphDestructibleParts_GraphController {

            }
            public static partial class CPulseCell_Outflow_PlaySceneBase__CursorState_t {
                public const long m_mainActor = 0x4;
                public const long m_sceneInstance = 0x0;
                public const long m_cursorIDToEventID = 0x8;
            }
            public static partial class CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                public const long m_nNextIndex = 0x0;
            }
            public static partial class CPulseCell_Outflow_PlayVCD__VCDRequirementInfo_t {
                public const long m_Outflow = 0x8;
                public const long m_nEventID = 0x0;
            }
            public static partial class CTonemapController2Alias_env_tonemap_controller2 {

            }
            public static partial class CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                public const long m_Shuffle = 0x0;
                public const long m_nNextShuffle = 0x20;
            }
            public static partial class CPulseCell_Outflow_ScriptedSequence__CursorState_t {
                public const long m_scriptedSequence = 0x0;
            }
            public static partial class CPulseCell_ApplyDynamicAttributeBase__CursorState_t {
                public const long m_hEntity = 0x0;
                public const long m_szAttributeKey = 0x8;
            }
            public static partial class CPathParticleRopeAlias_path_particle_rope_clientside {

            }
            public static partial class AI_GroundRootMotionMotor_DebugSnapshotData_t__Event_t {
                public const long location = 0x8;
                public const long description = 0x0;
            }
            public static partial class CPulseCell_Outflow_ListenForEntityOutput__CursorState_t {
                public const long m_entity = 0x0;
            }
            public static partial class AI_MotorServices_DebugSnapshotData_t__MotorPathWaypoint_t {
                public const long flags = 0x10;
                public const long nav_type = 0xC;
                public const long position = 0x0;
            }
            public static partial class CEnvSoundscapeTriggerableAlias_snd_soundscape_triggerable {

            }
            public static partial class CCSPlayerController_InventoryServices__NetworkedLoadoutSlot_t {
                public const long slot = 0xA;
                public const long team = 0x8;
                public const long pItem = 0x0;
            }
            public static partial class CEnvCombinedLightProbeVolumeAlias_func_combined_light_probe_volume {

            }
            public static partial class ETeam {
                public const long ET_CT = 0x3;
                public const long ET_Unknown = 0x0;
                public const long ET_Spectator = 0x1;
                public const long ET_Terrorist = 0x2;
            }
            public static partial class ESOMsg {
                public const long k_ESOMsg_Create = 0x15;
                public const long k_ESOMsg_Update = 0x16;
                public const long k_ESOMsg_Destroy = 0x17;
                public const long k_ESOMsg_UpdateMultiple = 0x1A;
                public const long k_ESOMsg_CacheSubscribed = 0x18;
                public const long k_ESOMsg_CacheUnsubscribed = 0x19;
                public const long k_ESOMsg_CacheSubscriptionCheck = 0x1B;
                public const long k_ESOMsg_CacheSubscriptionRefresh = 0x1C;
            }
            public static partial class Hull_t {
                public const long HULL_NONE = 0xB;
                public const long HULL_TINY = 0x3;
                public const long NUM_HULLS = 0xA;
                public const long HULL_HUMAN = 0x0;
                public const long HULL_LARGE = 0x6;
                public const long HULL_SMALL = 0x9;
                public const long HULL_MEDIUM = 0x4;
                public const long HULL_WIDE_HUMAN = 0x2;
                public const long HULL_MEDIUM_TALL = 0x8;
                public const long HULL_TINY_CENTERED = 0x5;
                public const long HULL_LARGE_CENTERED = 0x7;
                public const long HULL_SMALL_CENTERED = 0x1;
            }
            public static partial class Class_T {
                public const long CLASS_DOOR = 0xB;
                public const long CLASS_NONE = 0x0;
                public const long CLASS_PLAYER = 0x1;
                public const long CLASS_WEAPON = 0x5;
                public const long CLASS_PLANTED_C4 = 0xC;
                public const long CLASS_PLAYER_ALLY = 0x2;
                public const long CLASS_C4_FOR_RADAR = 0x3;
                public const long CLASS_HUDMODEL_ARMS = 0x8;
                public const long CLASS_HUDMODEL_ADDON = 0x9;
                public const long CLASS_WATER_SPLASHER = 0x6;
                public const long NUM_CLASSIFY_CLASSES = 0xD;
                public const long CLASS_HUDMODEL_WEAPON = 0x7;
                public const long CLASS_WORLDMODEL_GLOVES = 0xA;
                public const long CLASS_FOOT_CONTACT_SHADOW = 0x4;
            }
            public static partial class Flags_t {
                public const long FL_BOT = 0x10;
                public const long FL_FLY = 0x400;
                public const long FL_CLIENT = 0x80;
                public const long FL_FROZEN = 0x20;
                public const long FL_OBJECT = 0x2000000;
                public const long FL_ONFIRE = 0x8000000;
                public const long FL_DUCKING = 0x2;
                public const long FL_GODMODE = 0x4000;
                public const long FL_GRENADE = 0x100000;
                public const long FL_CONVEYOR = 0x1000000;
                public const long FL_NOTARGET = 0x8000;
                public const long FL_ONGROUND = 0x1;
                public const long FL_AIMTARGET = 0x10000;
                public const long FL_DONTTOUCH = 0x400000;
                public const long FL_WATERJUMP = 0x4;
                public const long FL_ATCONTROLS = 0x40;
                public const long FL_DISSOLVING = 0x10000000;
                public const long FL_FAKECLIENT = 0x100;
                public const long FL_IN_VEHICLE = 0x1000;
                public const long FL_BASEVELOCITY = 0x800000;
                public const long FL_TRANSRAGDOLL = 0x20000000;
                public const long FL_SUPPRESS_SAVE = 0x800;
                public const long FL_UNBLOCKABLE_BY_PLAYER = 0x40000000;
            }
            public static partial class OnFrame {
                public const long ONFRAME_TRUE = 0x1;
                public const long ONFRAME_FALSE = 0x2;
                public const long ONFRAME_UNKNOWN = 0x0;
            }
            public static partial class Touch_t {
                public const long touch_none = 0x0;
                public const long touch_npc_only = 0x2;
                public const long touch_player_only = 0x1;
                public const long touch_player_or_npc = 0x3;
                public const long touch_player_or_npc_or_physicsprop = 0x4;
            }
            public static partial class filter_t {
                public const long FILTER_OR = 0x1;
                public const long FILTER_AND = 0x0;
            }
            public static partial class BloodType {
                public const long _None = -0x1;
                public const long ColorRed = 0x0;
                public const long ColorGreen = 0x2;
                public const long ColorYellow = 0x1;
                public const long ColorRedLVL2 = 0x3;
                public const long ColorRedLVL3 = 0x4;
                public const long ColorRedLVL4 = 0x5;
                public const long ColorRedLVL5 = 0x6;
                public const long ColorRedLVL6 = 0x7;
            }
            public static partial class EGCPetMsg {
                public const long k_EMsgGCAckPetEvent = 0x9EA;
            }
            public static partial class EHitGroup {
                public const long EHG_Gear = 0x8;
                public const long EHG_Head = 0x1;
                public const long EHG_Miss = 0x9;
                public const long EHG_Chest = 0x2;
                public const long EHG_Generic = 0x0;
                public const long EHG_LeftArm = 0x4;
                public const long EHG_LeftLeg = 0x6;
                public const long EHG_Stomach = 0x3;
                public const long EHG_RightArm = 0x5;
                public const long EHG_RightLeg = 0x7;
            }
            public static partial class Materials {
                public const long matWeb = 0x9;
                public const long matNone = 0xA;
                public const long matWood = 0x1;
                public const long matFlesh = 0x3;
                public const long matGlass = 0x0;
                public const long matMetal = 0x2;
                public const long matRocks = 0x8;
                public const long matComputer = 0x6;
                public const long matCeilingTile = 0x5;
                public const long matCinderBlock = 0x4;
                public const long matLastMaterial = 0xB;
                public const long matUnbreakableGlass = 0x7;
            }
            public static partial class QuestType {
                public const long k_EQuestType_Operation = 0x1;
                public const long k_EQuestType_RecurringMission = 0x2;
            }
            public static partial class eRollType {
                public const long ROLL_NONE = -0x1;
                public const long ROLL_STATS = 0x0;
                public const long ROLL_OUTTRO = 0x3;
                public const long ROLL_CREDITS = 0x1;
                public const long ROLL_LATE_JOIN_LOGO = 0x2;
            }
            public static partial class BeamType_t {
                public const long BEAM_ENTS = 0x3;
                public const long BEAM_LASER = 0x6;
                public const long BEAM_POINTS = 0x1;
                public const long BEAM_SPLINE = 0x5;
                public const long BEAM_INVALID = 0x0;
                public const long BEAM_ENTPOINT = 0x2;
                public const long xxBEAM_HOSExxunused = 0x4;
            }
            public static partial class ECsgoGCMsg {
                public const long k_EMsgGC_GlobalGame_Play = 0x23D2;
                public const long k_EMsgGCCStrike15_v2_Base = 0x238C;
                public const long k_EMsgGC_GlobalGame_Subscribe = 0x23D0;
                public const long k_EMsgGCCStrike15_v2_MatchList = 0x23B3;
                public const long k_EMsgGCCStrike15_v2_SetClanId = 0x240D;
                public const long k_EMsgGCCStrike15_v2_GlobalChat = 0x23DC;
                public const long k_EMsgGC_GlobalGame_Unsubscribe = 0x23D1;
                public const long k_EMsgGCCStrike15_ClientDeepStats = 0x23FA;
                public const long k_EMsgGCCStrike15_v2_DraftSummary = 0x23CA;
                public const long k_EMsgGCCStrike15_v2_Party_Invite = 0x23E8;
                public const long k_EMsgGCCStrike15_v2_Party_Search = 0x23E7;
                public const long k_EMsgGCCStrike15_v2_PrivateQueues = 0x23FE;
                public const long k_EMsgGCCStrike15_v2_BetaEnrollment = 0x2401;
                public const long k_EMsgGCCStrike15_v2_GotvSyncPacket = 0x23E0;
                public const long k_EMsgGCCStrike15_v2_Party_Register = 0x23E5;
                public const long k_EMsgGCCStrike15_v2_PlayersProfile = 0x23A8;
                public const long k_EMsgGCCStrike15_v2_WatchInfoUsers = 0x23A6;
                public const long k_EMsgGCCStrike15_v2_ClientPollState = 0x23E4;
                public const long k_EMsgGCCStrike15_v2_MatchmakingStop = 0x238E;
                public const long k_EMsgGCCStrike15_v2_Client2GCTextMsg = 0x23AF;
                public const long k_EMsgGCCStrike15_v2_ClientPerfReport = 0x23F2;
                public const long k_EMsgGCCStrike15_v2_GC2ClientTextMsg = 0x23AE;
                public const long k_EMsgGCCStrike15_v2_MatchmakingStart = 0x238D;
                public const long k_EMsgGCCStrike15_v2_Party_Unregister = 0x23E6;
                public const long k_EMsgGCCStrike15_v2_SetEventFavorite = 0x23F0;
                public const long k_EMsgGCCStrike15_v2_ClientAuthKeyCode = 0x23DF;
                public const long k_EMsgGCCStrike15_v2_SetMyActivityInfo = 0x23C7;
                public const long k_EMsgGCCStrike15_v2_AcknowledgePenalty = 0x23D3;
                public const long k_EMsgGCCStrike15_v2_ClientGCRankUpdate = 0x23EA;
                public const long k_EMsgGCCStrike15_v2_ClientPartyWarning = 0x23EE;
                public const long k_EMsgGCCStrike15_v2_ClientReportPlayer = 0x239F;
                public const long k_EMsgGCCStrike15_v2_ClientReportServer = 0x23A0;
                public const long k_EMsgGCCStrike15_v2_ClientCommendPlayer = 0x23A1;
                public const long k_EMsgGCCStrike15_v2_ClientNetworkConfig = 0x2404;
                public const long k_EMsgGCCStrike15_v2_ClientRequestOffers = 0x23EB;
                public const long k_EMsgGCCStrike15_v2_ClientAccountBalance = 0x23EC;
                public const long k_EMsgGCCStrike15_v2_ClientPartyJoinRelay = 0x23ED;
                public const long k_EMsgGCCStrike15_v2_ClientReportResponse = 0x23A2;
                public const long k_EMsgGCCStrike15_v2_GC2ClientGlobalStats = 0x23D5;
                public const long k_EMsgGCCStrike15_v2_GlobalChat_Subscribe = 0x23DD;
                public const long k_EMsgGCCStrike15_v2_PremierSeasonSummary = 0x2408;
                public const long k_EMsgGCCStrike15_v2_Client2GCStreamUnlock = 0x23D6;
                public const long k_EMsgGCCStrike15_v2_ClientLogonFatalError = 0x23E3;
                public const long k_EMsgGCCStrike15_v2_ClientPlayerDecalSign = 0x23E1;
                public const long k_EMsgGCCStrike15_v2_ClientRequestSouvenir = 0x23F4;
                public const long k_EMsgGCCStrike15_v2_GC2ClientNotifyXPShop = 0x2405;
                public const long k_EMsgGCCStrike15_v2_VolatileShopSubscribe = 0x240C;
                public const long k_EMsgGCCStrike15_v2_AccountPrivacySettings = 0x23C6;
                public const long k_EMsgGCCStrike15_v2_Account_RequestCoPlays = 0x23E9;
                public const long k_EMsgGCCStrike15_v2_ClientRedeemFreeReward = 0x2403;
                public const long k_EMsgGCCStrike15_v2_ClientSubmitSurveyVote = 0x23C0;
                public const long k_EMsgGCCStrike15_v2_GlobalChat_Unsubscribe = 0x23DE;
                public const long k_EMsgGCCStrike15_v2_MatchEndRunRewardDrops = 0x23B0;
                public const long k_EMsgGCCStrike15_v2_RecurringMissionSchema = 0x240A;
                public const long k_EMsgGCCStrike15_v2_ClientToGCRequestTicket = 0x23DA;
                public const long k_EMsgGCCStrike15_v2_FantasyUpdateClientData = 0x23D8;
                public const long k_EMsgGCCStrike15_v2_GC2ClientTournamentInfo = 0x23CF;
                public const long k_EMsgGCCStrike15_v2_GiftsLeaderboardRequest = 0x23BC;
                public const long k_EMsgGCCStrike15_v2_Server2GCClientValidate = 0x23C1;
                public const long k_EMsgGCCStrike15_v2_VolatileItemClaimReward = 0x240B;
                public const long k_EMsgGCCStrike15_StartAgreementSessionInGame = 0x23FB;
                public const long k_EMsgGCCStrike15_v2_Client2GcAckXPShopTracks = 0x2406;
                public const long k_EMsgGCCStrike15_v2_ClientCommendPlayerQuery = 0x23A3;
                public const long k_EMsgGCCStrike15_v2_ClientToGCRequestElevate = 0x23DB;
                public const long k_EMsgGCCStrike15_v2_FantasyRequestClientData = 0x23D7;
                public const long k_EMsgGCCStrike15_v2_GiftsLeaderboardResponse = 0x23BD;
                public const long k_EMsgGCCStrike15_v2_ClientRedeemMissionReward = 0x23F9;
                public const long k_EMsgGCCStrike15_v2_GetEventFavorites_Request = 0x23F1;
                public const long k_EMsgGCCStrike15_v2_MatchmakingClient2GCHello = 0x2395;
                public const long k_EMsgGCCStrike15_v2_MatchmakingGC2ClientHello = 0x2396;
                public const long k_EMsgGCCStrike15_v2_PlayerOverwatchCaseStatus = 0x23AD;
                public const long k_EMsgGCCStrike15_v2_PlayerOverwatchCaseUpdate = 0x23AB;
                public const long k_EMsgGCCStrike15_v2_GC2ServerReservationUpdate = 0x23B6;
                public const long k_EMsgGCCStrike15_v2_GetEventFavorites_Response = 0x23F3;
                public const long k_EMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate = 0x2390;
                public const long k_EMsgGCCStrike15_v2_ClientRequestJoinFriendData = 0x23CB;
                public const long k_EMsgGCCStrike15_v2_ClientRequestJoinServerData = 0x23CC;
                public const long k_EMsgGCCStrike15_v2_ClientRequestPlayersProfile = 0x23A7;
                public const long k_EMsgGCCStrike15_v2_MatchmakingGC2ClientAbandon = 0x2398;
                public const long k_EMsgGCCStrike15_v2_MatchmakingGC2ClientReserve = 0x2393;
                public const long k_EMsgGCCStrike15_v2_Client2GCRequestPrestigeCoin = 0x23D4;
                public const long k_EMsgGCCStrike15_v2_MatchListRequestFullGameInfo = 0x23BB;
                public const long k_EMsgGCCStrike15_v2_MatchmakingClient2ServerPing = 0x238F;
                public const long k_EMsgGCCStrike15_v2_SetPlayerLeaderboardSafeName = 0x2402;
                public const long k_EMsgGCCStrike15_v2_GCToClientSteamdatagramTicket = 0x23D9;
                public const long k_EMsgGCCStrike15_v2_PlayerOverwatchCaseAssignment = 0x23AC;
                public const long k_EMsgGCCStrike15_v2_ClientRequestWatchInfoFriends2 = 0x23B2;
                public const long k_EMsgGCCStrike15_v2_ClientVarValueNotificationInfo = 0x23B8;
                public const long k_EMsgGCCStrike15_v2_ServerVarValueNotificationInfo = 0x23BE;
                public const long k_EMsgGCCStrike15_v2_MatchEndRewardDropsNotification = 0x23B1;
                public const long k_EMsgGCCStrike15_v2_MatchListRequestLiveGameForUser = 0x23C2;
                public const long k_EMsgGCCStrike15_v2_MatchListRequestRecentUserGames = 0x23B5;
                public const long k_EMsgGCCStrike15_v2_MatchListRequestTournamentGames = 0x23BA;
                public const long k_EMsgGCCStrike15_v2_MatchListTournamentOperatorMgmt = 0x23FF;
                public const long k_EMsgGCCStrike15_v2_MatchmakingGC2ClientSearchStats = 0x2407;
                public const long k_EMsgGCCStrike15_v2_RequestRecurringMissionSchedule = 0x2409;
                public const long k_EMsgGCCStrike15_v2_ClientCommendPlayerQueryResponse = 0x23A4;
                public const long k_EMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames = 0x23B4;
                public const long k_EMsgGCCStrike15_v2_MatchmakingOperator2GCBlogUpdate = 0x239D;
                public const long k_EMsgGCCStrike15_v2_ServerNotificationForUserPenalty = 0x239E;
                public const long k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockRequest = 0x23C4;
                public const long k_EMsgGCCStrike15_v2_MatchListUploadTournamentPredictions = 0x23C9;
                public const long k_EMsgGCCStrike15_v2_MatchmakingServerReservationResponse = 0x2392;
                public const long k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockResponse = 0x23C5;
                public const long k_EMsgGCCStrike15_v2_MatchListRequestTournamentPredictions = 0x23C8;
            }
            public static partial class EGCBaseMsg {
                public const long k_EMsgGCError = 0x119D;
                public const long k_EMsgGCInQueue = 0xFA8;
                public const long k_EMsgGCLeaveParty = 0x1199;
                public const long k_EMsgGCConVarUpdated = 0xFA3;
                public const long k_EMsgGCInviteToParty = 0x1195;
                public const long k_EMsgGCKickFromParty = 0x1198;
                public const long k_EMsgGCSystemMessage = 0xFA1;
                public const long k_EMsgGCGameServerInfo = 0x119C;
                public const long k_EMsgGCServerAvailable = 0x119A;
                public const long k_EMsgGCReplicateConVars = 0xFA2;
                public const long k_EMsgGCInvitationCreated = 0x1196;
                public const long k_EMsgGCLANServerAvailable = 0x119F;
                public const long k_EMsgGCPartyInviteResponse = 0x1197;
                public const long k_EMsgGCClientConnectToServer = 0x119B;
                public const long k_EMsgGCReplay_UploadedToYouTube = 0x119E;
            }
            public static partial class EGCItemMsg {
                public const long k_EMsgGCBase = 0x3E8;
                public const long k_EMsgGCCraft = 0x3EA;
                public const long k_EMsgGCDelete = 0x3EC;
                public const long k_EMsgGCNameItem = 0x3EE;
                public const long k_EMsgGCOpenCrate = 0x9E6;
                public const long k_EMsgGCPaintItem = 0x3F1;
                public const long k_EMsgGCSortItems = 0x411;
                public const long k_EMsgGCCollectItem = 0x425;
                public const long k_EMsgGCDeliverGift = 0x40A;
                public const long k_EMsgGCGiftedItems = 0x43B;
                public const long k_EMsgGCMOTDRequest = 0x3F4;
                public const long k_EMsgGCApplySticker = 0x43E;
                public const long k_EMsgGCGiftWrapItem = 0x408;
                public const long k_EMsgGCNameBaseItem = 0x3FB;
                public const long k_EMsgGCPaintKitItem = 0x438;
                public const long k_EMsgGCSetItemStyle = 0x40F;
                public const long k_EMsgGCStatTrakSwap = 0x440;
                public const long k_EMsgGC_ReportAbuse = 0x429;
                public const long k_EMsgGCCasketItemAdd = 0x444;
                public const long k_EMsgGCCraftResponse = 0x3EB;
                public const long k_EMsgGCLookupAccount = 0x413;
                public const long k_EMsgGCRemoveItemName = 0x406;
                public const long k_EMsgGCSaxxyBroadcast = 0x421;
                public const long k_EMsgGCUseItemRequest = 0x401;
                public const long k_EMsgGCApplyEggEssence = 0x436;
                public const long k_EMsgGCRemoveItemPaint = 0x407;
                public const long k_EMsgGCSetItemPosition = 0x3E9;
                public const long k_EMsgGCUnlockItemStyle = 0x43C;
                public const long k_EMsgGCUseItemResponse = 0x402;
                public const long k_EMsgGCApplyStrangePart = 0x431;
                public const long k_EMsgGCItemAcknowledged = 0x43F;
                public const long k_EMsgGCPaintKitBaseItem = 0x439;
                public const long k_EMsgGCRemoveMakersMark = 0x41D;
                public const long k_EMsgGCSetItemPositions = 0x435;
                public const long k_EMsgGCStoreGetUserData = 0x9C4;
                public const long k_EMsgGCUpdateItemSchema = 0x419;
                public const long k_EMsgGCCasketItemExtract = 0x445;
                public const long k_EMsgGCItemPreviewExpire = 0x6A9;
                public const long k_EMsgGCLookupAccountName = 0x415;
                public const long k_EMsgGCPaintItemResponse = 0x3F2;
                public const long k_EMsgGCServerRentalsBase = 0x6A4;
                public const long k_EMsgGCShowItemsPickedUp = 0x42F;
                public const long k_EMsgGCStorePurchaseInit = 0x9CE;
                public const long k_EMsgGCToGCDirtySDOCache = 0x9D4;
                public const long k_EMsgGCUnwrapGiftRequest = 0x40D;
                public const long k_EMsgGCUsedClaimCodeItem = 0x410;
                public const long k_EMsgGCDev_NewItemRequest = 0x7D1;
                public const long k_EMsgGCItemPreviewRequest = 0x6A7;
                public const long k_EMsgGCUnwrapGiftResponse = 0x40E;
                public const long k_EMsgGCApplyPennantUpgrade = 0x434;
                public const long k_EMsgGCConsumableExhausted = 0x42E;
                public const long k_EMsgGCMOTDRequestResponse = 0x3F5;
                public const long k_EMsgGCModifyItemAttribute = 0x443;
                public const long k_EMsgGCRemoveCustomTexture = 0x41B;
                public const long k_EMsgGCStorePurchaseCancel = 0x9CA;
                public const long k_EMsgGCToGCIsTrustedServer = 0x9D7;
                public const long k_EMsgGCUnlockCrateResponse = 0x3F0;
                public const long k_EMsgGCBackpackSortFinished = 0x422;
                public const long k_EMsgGCClientVersionUpdated = 0x9E0;
                public const long k_EMsgGCCustomizeItemTexture = 0x3FF;
                public const long k_EMsgGCDev_PaintKitDropItem = 0x7D3;
                public const long k_EMsgGCGiftWrapItemResponse = 0x409;
                public const long k_EMsgGCNameBaseItemResponse = 0x3FC;
                public const long k_EMsgGCNameItemNotification = 0x42C;
                public const long k_EMsgGCPaintKitItemResponse = 0x43A;
                public const long k_EMsgGCRequestAnnouncements = 0x9DD;
                public const long k_EMsgGCServerVersionUpdated = 0x9DA;
                public const long k_EMsgGC_ReportAbuseResponse = 0x42A;
                public const long k_EMsgGCBannedWordListRequest = 0x9D0;
                public const long k_EMsgGCGoldenWrenchBroadcast = 0x3F3;
                public const long k_EMsgGCLookupAccountResponse = 0x414;
                public const long k_EMsgGCStorePurchaseFinalize = 0x9C8;
                public const long k_EMsgGCStorePurchaseQueryTxn = 0x9CC;
                public const long k_EMsgGCToGCUpdateSQLKeyValue = 0x9D6;
                public const long k_EMsgGCAdjustEquipSlotsManual = 0x9E3;
                public const long k_EMsgGCApplyConsumableEffects = 0x42D;
                public const long k_EMsgGCBannedWordListResponse = 0x9D1;
                public const long k_EMsgGCCasketItemLoadContents = 0x446;
                public const long k_EMsgGCGiftedItems_DEPRECATED = 0x403;
                public const long k_EMsgGCItemPreviewCheckStatus = 0x6A5;
                public const long k_EMsgGCNameEggEssenceResponse = 0x437;
                public const long k_EMsgGCRemoveUniqueCraftIndex = 0x41F;
                public const long k_EMsgGCUnlockCrate_DEPRECATED = 0x3EF;
                public const long k_EMsgGCAdjustEquipSlotsShuffle = 0x9E4;
                public const long k_EMsgGCUnlockItemStyleResponse = 0x43D;
                public const long k_EMsgGCVerifyCacheSubscription = 0x3ED;
                public const long k_EMsgGCDeliverGiftResponseGiver = 0x40B;
                public const long k_EMsgGCRemoveMakersMarkResponse = 0x41E;
                public const long k_EMsgGCRequestPassportItemGrant = 0x9DF;
                public const long k_EMsgGCStoreGetUserDataResponse = 0x9C5;
                public const long k_EMsgGCToGCWebAPIAccountChanged = 0x9DC;
                public const long k_EMsgGCVolatileItemLoadContents = 0x9E8;
                public const long k_EMsgGCClientDisplayNotification = 0x430;
                public const long k_EMsgGCItemPreviewStatusResponse = 0x6A6;
                public const long k_EMsgGCLookupAccountNameResponse = 0x416;
                public const long k_EMsgGCStorePurchaseInitResponse = 0x9CF;
                public const long k_EMsgGCToGCBannedWordListUpdated = 0x9D3;
                public const long k_EMsgGCToGCDirtyMultipleSDOCache = 0x9D5;
                public const long k_EMsgGCAddItemToSocket_DEPRECATED = 0x3F6;
                public const long k_EMsgGCAddSocketToItem_DEPRECATED = 0x3F9;
                public const long k_EMsgGCDev_NewItemRequestResponse = 0x7D2;
                public const long k_EMsgGCItemPreviewRequestResponse = 0x6A8;
                public const long k_EMsgGCAcknowledgeRentalExpiration = 0x9E7;
                public const long k_EMsgGCDeliverGiftResponseReceiver = 0x40C;
                public const long k_EMsgGCRecurringSubscriptionStatus = 0x9E2;
                public const long k_EMsgGCRemoveCustomTextureResponse = 0x41C;
                public const long k_EMsgGCRemoveSocketItem_DEPRECATED = 0x3FD;
                public const long k_EMsgGCStorePurchaseCancelResponse = 0x9CB;
                public const long k_EMsgGCToGCBannedWordListBroadcast = 0x9D2;
                public const long k_EMsgGCToGCBroadcastConsoleCommand = 0x9D9;
                public const long k_EMsgGCToGCIsTrustedServerResponse = 0x9D8;
                public const long k_EMsgGC_IncrementKillCountResponse = 0x433;
                public const long k_EMsgGCCustomizeItemTextureResponse = 0x400;
                public const long k_EMsgGCDev_SchemaReservationRequest = 0x7D4;
                public const long k_EMsgGCItemAcknowledged__DEPRECATED = 0x426;
                public const long k_EMsgGCRequestAnnouncementsResponse = 0x9DE;
                public const long k_EMsgGCServerBrowser_FavoriteServer = 0x641;
                public const long k_EMsgGCStorePurchaseInit_DEPRECATED = 0x9C6;
                public const long k_EMsgGC_IncrementKillCountAttribute = 0x432;
                public const long k_EMsgGCItemCustomizationNotification = 0x442;
                public const long k_EMsgGCItemPreviewExpireNotification = 0x6AA;
                public const long k_EMsgGCServerBrowser_BlacklistServer = 0x642;
                public const long k_EMsgGCStorePurchaseFinalizeResponse = 0x9C9;
                public const long k_EMsgGCStorePurchaseQueryTxnResponse = 0x9CD;
                public const long k_EMsgGC_RevolvingLootList_DEPRECATED = 0x412;
                public const long k_EMsgGCAddSocketToBaseItem_DEPRECATED = 0x3F8;
                public const long k_EMsgGCRemoveUniqueCraftIndexResponse = 0x420;
                public const long k_EMsgGCUserTrackTimePlayedConsecutively = 0x441;
                public const long k_EMsgGCItemPreviewItemBoughtNotification = 0x6AB;
                public const long k_EMsgGCAddItemToSocketResponse_DEPRECATED = 0x3F7;
                public const long k_EMsgGCAddSocketToItemResponse_DEPRECATED = 0x3FA;
                public const long k_EMsgGCRemoveSocketItemResponse_DEPRECATED = 0x3FE;
                public const long k_EMsgGCStorePurchaseInitResponse_DEPRECATED = 0x9C7;
            }
            public static partial class EGCToGCMsg {
                public const long k_EGCToGCMsgRouted = 0x98;
                public const long k_EGCToGCMsgMasterAck = 0x96;
                public const long k_EMsgUpdateSessionIP = 0x9A;
                public const long k_EMsgRequestSessionIP = 0x9B;
                public const long k_EGCToGCMsgRoutedReply = 0x99;
                public const long k_EGCToGCMsgMasterAckResponse = 0x97;
                public const long k_EMsgRequestSessionIPResponse = 0x9C;
                public const long k_EGCToGCMsgMasterStartupComplete = 0x9D;
            }
            public static partial class Explosions {
                public const long expRandom = 0x0;
                public const long expDirected = 0x1;
                public const long expUsePrecise = 0x2;
            }
            public static partial class HitGroup_t {
                public const long HITGROUP_GEAR = 0xA;
                public const long HITGROUP_HEAD = 0x1;
                public const long HITGROUP_NECK = 0x8;
                public const long HITGROUP_CHEST = 0x2;
                public const long HITGROUP_COUNT = 0xC;
                public const long HITGROUP_UNUSED = 0x9;
                public const long HITGROUP_GENERIC = 0x0;
                public const long HITGROUP_INVALID = -0x1;
                public const long HITGROUP_LEFTARM = 0x4;
                public const long HITGROUP_LEFTLEG = 0x6;
                public const long HITGROUP_SPECIAL = 0xB;
                public const long HITGROUP_STOMACH = 0x3;
                public const long HITGROUP_RIGHTARM = 0x5;
                public const long HITGROUP_RIGHTLEG = 0x7;
            }
            public static partial class MoveType_t {
                public const long MOVETYPE_FLY = 0x3;
                public const long MOVETYPE_LAST = 0xB;
                public const long MOVETYPE_NONE = 0x0;
                public const long MOVETYPE_PUSH = 0x6;
                public const long MOVETYPE_WALK = 0x2;
                public const long MOVETYPE_CUSTOM = 0xA;
                public const long MOVETYPE_LADDER = 0x9;
                public const long MOVETYPE_NOCLIP = 0x7;
                public const long MOVETYPE_INVALID = 0xB;
                public const long MOVETYPE_MAX_BITS = 0x5;
                public const long MOVETYPE_OBSERVER = 0x8;
                public const long MOVETYPE_OBSOLETE = 0x1;
                public const long MOVETYPE_VPHYSICS = 0x5;
                public const long MOVETYPE_FLYGRAVITY = 0x4;
            }
            public static partial class NavDirType {
                public const long EAST = 0x1;
                public const long WEST = 0x3;
                public const long NORTH = 0x0;
                public const long SOUTH = 0x2;
                public const long NUM_NAV_DIR_TYPE_DIRECTIONS = 0x4;
            }
            public static partial class NavScope_t {
                public const long eAir = 0x1;
                public const long eCount = 0x2;
                public const long eFirst = 0x0;
                public const long eGround = 0x0;
                public const long eInvalid = 0xFF;
            }
            public static partial class RenderFx_t {
                public const long kRenderFxMax = 0x11;
                public const long kRenderFxNone = 0x0;
                public const long kRenderFxFadeIn = 0xF;
                public const long kRenderFxFadeOut = 0xE;
                public const long kRenderFxFadeFast = 0x6;
                public const long kRenderFxFadeSlow = 0x5;
                public const long kRenderFxPulseFast = 0x2;
                public const long kRenderFxPulseSlow = 0x1;
                public const long kRenderFxSolidFast = 0x8;
                public const long kRenderFxSolidSlow = 0x7;
                public const long kRenderFxStrobeFast = 0xA;
                public const long kRenderFxStrobeSlow = 0x9;
                public const long kRenderFxFlickerFast = 0xD;
                public const long kRenderFxFlickerSlow = 0xC;
                public const long kRenderFxStrobeFaster = 0xB;
                public const long kRenderFxPulseFastWide = 0x4;
                public const long kRenderFxPulseSlowWide = 0x3;
                public const long kRenderFxPulseFastWider = 0x10;
            }
            public static partial class TRAIN_CODE {
                public const long TRAIN_SAFE = 0x0;
                public const long TRAIN_BLOCKING = 0x1;
                public const long TRAIN_FOLLOWING = 0x2;
            }
            public static partial class AmmoFlags_t {
                public const long AMMO_FLAG_MAX = 0x2;
                public const long AMMO_FORCE_DROP_IF_CARRIED = 0x1;
                public const long AMMO_RESERVE_STAYS_WITH_WEAPON = 0x2;
            }
            public static partial class DIALOG_TYPE {
                public const long DIALOG_MSG = 0x0;
                public const long DIALOG_MENU = 0x1;
                public const long DIALOG_TEXT = 0x2;
                public const long DIALOG_ENTRY = 0x3;
                public const long DIALOG_ASKCONNECT = 0x4;
            }
            public static partial class DoorState_t {
                public const long DOOR_STATE_AJAR = 0x4;
                public const long DOOR_STATE_OPEN = 0x2;
                public const long DOOR_STATE_CLOSED = 0x0;
                public const long DOOR_STATE_CLOSING = 0x3;
                public const long DOOR_STATE_OPENING = 0x1;
            }
            public static partial class EWeaponType {
                public const long EWT_C4 = 0x7;
                public const long EWT_Knife = 0x0;
                public const long EWT_Rifle = 0x3;
                public const long EWT_Pistol = 0x1;
                public const long EWT_Grenade = 0x8;
                public const long EWT_Shotgun = 0x4;
                public const long EWT_Unknown = 0xB;
                public const long EWT_Equipment = 0x9;
                public const long EWT_MachineGun = 0x6;
                public const long EWT_SniperRifle = 0x5;
                public const long EWT_StackableItem = 0xA;
                public const long EWT_SubMachineGun = 0x2;
            }
            public static partial class LifeState_t {
                public const long LIFE_DEAD = 0x2;
                public const long LIFE_ALIVE = 0x0;
                public const long LIFE_DYING = 0x1;
                public const long NUM_LIFESTATES = 0x5;
                public const long LIFE_RESPAWNING = 0x4;
                public const long LIFE_RESPAWNABLE = 0x3;
            }
            public static partial class MedalRank_t {
                public const long MEDAL_RANK_GOLD = 0x3;
                public const long MEDAL_RANK_NONE = 0x0;
                public const long MEDAL_RANK_COUNT = 0x4;
                public const long MEDAL_RANK_BRONZE = 0x1;
                public const long MEDAL_RANK_SILVER = 0x2;
            }
            public static partial class SolidType_t {
                public const long SOLID_BSP = 0x1;
                public const long SOLID_OBB = 0x3;
                public const long SOLID_BBOX = 0x2;
                public const long SOLID_LAST = 0x9;
                public const long SOLID_NONE = 0x0;
                public const long SOLID_POINT = 0x5;
                public const long SOLID_SPHERE = 0x4;
                public const long SOLID_CAPSULE = 0x7;
                public const long SOLID_CYLINDER = 0x8;
                public const long SOLID_VPHYSICS = 0x6;
            }
            public static partial class doorCheck_e {
                public const long DOOR_CHECK_FULL = 0x2;
                public const long DOOR_CHECK_FORWARD = 0x0;
                public const long DOOR_CHECK_BACKWARD = 0x1;
            }
            public static partial class gear_slot_t {
                public const long GEAR_SLOT_C4 = 0x4;
                public const long GEAR_SLOT_LAST = 0xC;
                public const long GEAR_SLOT_COUNT = 0xD;
                public const long GEAR_SLOT_FIRST = 0x0;
                public const long GEAR_SLOT_KNIFE = 0x2;
                public const long GEAR_SLOT_RIFLE = 0x0;
                public const long GEAR_SLOT_BOOSTS = 0xB;
                public const long GEAR_SLOT_PISTOL = 0x1;
                public const long GEAR_SLOT_INVALID = -0x1;
                public const long GEAR_SLOT_UTILITY = 0xC;
                public const long GEAR_SLOT_GRENADES = 0x3;
                public const long GEAR_SLOT_RESERVED_SLOT6 = 0x5;
                public const long GEAR_SLOT_RESERVED_SLOT7 = 0x6;
                public const long GEAR_SLOT_RESERVED_SLOT8 = 0x7;
                public const long GEAR_SLOT_RESERVED_SLOT9 = 0x8;
                public const long GEAR_SLOT_RESERVED_SLOT10 = 0x9;
                public const long GEAR_SLOT_RESERVED_SLOT11 = 0xA;
            }
            public static partial class CLC_Messages {
                public const long clc_Move = 0x15;
                public const long clc_VoiceData = 0x16;
                public const long clc_ClientInfo = 0x14;
                public const long clc_Diagnostic = 0x25;
                public const long clc_HltvReplay = 0x24;
                public const long clc_BaselineAck = 0x17;
                public const long clc_CmdKeyValues = 0x22;
                public const long clc_RequestPause = 0x21;
                public const long clc_ServerStatus = 0x1F;
                public const long clc_LoadingProgress = 0x1B;
                public const long clc_RespondCvarValue = 0x19;
                public const long clc_RconServerDetails = 0x23;
                public const long clc_SplitPlayerConnect = 0x1C;
                public const long clc_SplitPlayerDisconnect = 0x1E;
            }
            public static partial class CSWeaponMode {
                public const long Primary_Mode = 0x0;
                public const long Secondary_Mode = 0x1;
                public const long WeaponMode_MAX = 0x2;
            }
            public static partial class CSWeaponType {
                public const long WEAPONTYPE_C4 = 0x7;
                public const long WEAPONTYPE_KNIFE = 0x0;
                public const long WEAPONTYPE_RIFLE = 0x3;
                public const long WEAPONTYPE_TASER = 0x8;
                public const long WEAPONTYPE_PISTOL = 0x1;
                public const long WEAPONTYPE_GRENADE = 0x9;
                public const long WEAPONTYPE_SHOTGUN = 0x4;
                public const long WEAPONTYPE_UNKNOWN = 0xC;
                public const long WEAPONTYPE_EQUIPMENT = 0xA;
                public const long WEAPONTYPE_MACHINEGUN = 0x6;
                public const long WEAPONTYPE_SNIPER_RIFLE = 0x5;
                public const long WEAPONTYPE_STACKABLEITEM = 0xB;
                public const long WEAPONTYPE_SUBMACHINEGUN = 0x2;
            }
            public static partial class DecalFlags_t {
                public const long eAll = 0xFFFFFFFF;
                public const long eNone = 0x0;
                public const long eCannotClear = 0x1;
                public const long eAllButCannotClear = 0xFFFFFFFE;
                public const long eDecalProjectToBackfaces = 0x2;
            }
            public static partial class EGCSystemMsg {
                public const long k_EGCMsgMulti = 0x1;
                public const long k_EGCMsgInvalid = 0x0;
                public const long k_EGCMsgPostAlert = 0x4B;
                public const long k_EGCMsgSendEmail = 0x57;
                public const long k_EGCMsgWGRequest = 0x39;
                public const long k_EGCMsgConCommand = 0x34;
                public const long k_EGCMsgSetOptions = 0xE2;
                public const long k_EGCMsgSystemBase = 0x32;
                public const long k_EGCMsgWGResponse = 0x3A;
                public const long k_EGCMsgGetCommands = 0x4E;
                public const long k_EGCMsgGetLicenses = 0x4C;
                public const long k_EGCMsgStopPlaying = 0x36;
                public const long k_EGCMsgSystemBase2 = 0x1F4;
                public const long k_EGCMsgFindAccounts = 0x4A;
                public const long k_EGCMsgGenericReply = 0xA;
                public const long k_EGCMsgGetUserStats = 0x4D;
                public const long k_EGCMsgMemCachedGet = 0xC8;
                public const long k_EGCMsgMemCachedSet = 0xCA;
                public const long k_EGCMsgMultiplexMsg = 0x61;
                public const long k_EGCMsgPreTestSetup = 0x45;
                public const long k_EGCMsgStartPlaying = 0x35;
                public const long k_EGCMsgGetIPLocation = 0x52;
                public const long k_EGCMsgReportMetrics = 0x218;
                public const long k_EGCMsgUpdateSession = 0x1F7;
                public const long k_EGCMsgAddFreeLicense = 0x50;
                public const long k_EGCMsgAppInfoUpdated = 0x3F;
                public const long k_EGCMsgGetClanDetails = 0x21A;
                public const long k_EGCMsgGetSystemStats = 0x55;
                public const long k_EGCMsgGrantGuestPass = 0x5B;
                public const long k_EGCMsgMemCachedStats = 0xCC;
                public const long k_EGCMsgStopGameserver = 0x38;
                public const long k_EGCMsgCheckFriendship = 0x1F9;
                public const long k_EGCMsgGetPersonaNames = 0x5F;
                public const long k_EGCMsgMemCachedDelete = 0xCB;
                public const long k_EGCMsgSendHTTPRequest = 0x43;
                public const long k_EGCMsgStartGameserver = 0x37;
                public const long k_EGCMsgValidateSession = 0x40;
                public const long k_EGCMsgGetEmailTemplate = 0x59;
                public const long k_EGCMsgWebAPIJobRequest = 0x66;
                public const long k_EGCMsgAppCheersReceived = 0x215;
                public const long k_EGCMsgGetAccountDetails = 0x5D;
                public const long k_EGCMsgInviteUserToLobby = 0x20B;
                public const long k_EGCMsgSendEmailResponse = 0x58;
                public const long k_EGCMsgSystemStatsSchema = 0x54;
                public const long k_EGCMsgAchievementAwarded = 0x33;
                public const long k_EGCMsgDPPartnerMicroTxns = 0x200;
                public const long k_EGCMsgMasterSetDirectory = 0xDC;
                public const long k_EGCMsgSetOptionsResponse = 0xE3;
                public const long k_EGCMsgDirectServiceMethod = 0x213;
                public const long k_EGCMsgGetCommandsResponse = 0x4F;
                public const long k_EGCMsgRecordSupportAction = 0x46;
                public const long k_EGCMsgGetUserStatsResponse = 0x3E;
                public const long k_EGCMsgMemCachedGetResponse = 0xC9;
                public const long k_EGCMsgMultiplexMsgResponse = 0x62;
                public const long k_EGCMsgGetIPLocationResponse = 0x53;
                public const long k_EGCMsgGetPartnerAccountLink = 0x1FB;
                public const long k_EGCMsgReportMetricsResponse = 0x219;
                public const long k_EGCMsgVacVerificationChange = 0x206;
                public const long k_EGCMsgAddFreeLicenseResponse = 0x51;
                public const long k_EGCMsgGetClanDetailsResponse = 0x21B;
                public const long k_EGCMsgGetPurchaseTrustStatus = 0x1F5;
                public const long k_EGCMsgGetSystemStatsResponse = 0x56;
                public const long k_EGCMsgGetUserGameStatsSchema = 0x3B;
                public const long k_EGCMsgGetUserStatsDEPRECATED = 0x3D;
                public const long k_EGCMsgGrantGuestPassResponse = 0x5C;
                public const long k_EGCMsgLookupAccountFromInput = 0x42;
                public const long k_EGCMsgMasterSetWebAPIRouting = 0xDE;
                public const long k_EGCMsgMemCachedStatsResponse = 0xCD;
                public const long k_EGCMsgReceiveInterAppMessage = 0x49;
                public const long k_EGCMsgCheckFriendshipResponse = 0x1FA;
                public const long k_EGCMsgGetPersonaNamesResponse = 0x60;
                public const long k_EGCMsgSendHTTPRequestResponse = 0x44;
                public const long k_EGCMsgValidateSessionResponse = 0x41;
                public const long k_EGCMsgAccountPhoneNumberChange = 0x207;
                public const long k_EGCMsgAppCheersGetAllowedTypes = 0x216;
                public const long k_EGCMsgGCAccountVacStatusChange = 0x1F8;
                public const long k_EGCMsgGetEmailTemplateResponse = 0x5A;
                public const long k_EGCMsgWebAPIRegisterInterfaces = 0x65;
                public const long k_EGCMsgGetAccountDetailsResponse = 0x5E;
                public const long k_EGCMsgMasterSetClientMsgRouting = 0xE0;
                public const long k_EGCMsgDPPartnerMicroTxnsResponse = 0x201;
                public const long k_EGCMsgMasterSetDirectoryResponse = 0xDD;
                public const long k_EGCMsgDirectServiceMethodResponse = 0x214;
                public const long k_EGCMsgGetAccountDetails_DEPRECATED = 0x47;
                public const long k_EGCMsgWebAPIJobRequestHttpResponse = 0x68;
                public const long k_EGCMsgGetPartnerAccountLinkResponse = 0x1FC;
                public const long k_EGCMsgGetPurchaseTrustStatusResponse = 0x1F6;
                public const long k_EGCMsgGetUserGameStatsSchemaResponse = 0x3C;
                public const long k_EGCMsgMasterSetWebAPIRoutingResponse = 0xDF;
                public const long k_EGCMsgWebAPIJobRequestForwardResponse = 0x69;
                public const long k_EGCMsgAppCheersGetAllowedTypesResponse = 0x217;
                public const long k_EGCMsgGetGamePersonalDataEntriesRequest = 0x20E;
                public const long k_EGCMsgMasterSetClientMsgRoutingResponse = 0xE1;
                public const long k_EGCMsgRecurringSubscriptionStatusChange = 0x212;
                public const long k_EGCMsgGetGamePersonalDataEntriesResponse = 0x20F;
                public const long k_EGCMsgGetGamePersonalDataCategoriesRequest = 0x20C;
                public const long k_EGCMsgGetGamePersonalDataCategoriesResponse = 0x20D;
                public const long k_EGCMsgTerminateGamePersonalDataEntriesRequest = 0x210;
                public const long k_EGCMsgTerminateGamePersonalDataEntriesResponse = 0x211;
            }
            public static partial class EKillTypes_t {
                public const long KILL_BURN = 0x4;
                public const long KILL_NONE = 0x0;
                public const long KILL_BLAST = 0x3;
                public const long KILL_SHOCK = 0x6;
                public const long KILL_SLASH = 0x5;
                public const long KILL_DEFAULT = 0x1;
                public const long KILL_HEADSHOT = 0x2;
                public const long KILLTYPE_COUNT = 0x7;
            }
            public static partial class EUnlockStyle {
                public const long k_UnlockStyle_Succeeded = 0x0;
                public const long k_UnlockStyle_Failed_PreReq = 0x1;
                public const long k_UnlockStyle_Failed_CantAfford = 0x2;
                public const long k_UnlockStyle_Failed_CantCommit = 0x3;
                public const long k_UnlockStyle_Failed_CantLockCache = 0x4;
                public const long k_UnlockStyle_Failed_CantAffordAttrib = 0x5;
            }
            public static partial class GLOBALESTATE {
                public const long GLOBAL_ON = 0x1;
                public const long GLOBAL_OFF = 0x0;
                public const long GLOBAL_DEAD = 0x2;
            }
            public static partial class NET_Messages {
                public const long net_NOP = 0x0;
                public const long net_Tick = 0x4;
                public const long net_SetConVar = 0x6;
                public const long net_StringCmd = 0x5;
                public const long net_SignonState = 0x7;
                public const long net_DebugOverlay = 0xF;
                public const long net_SpawnGroup_Load = 0x8;
                public const long net_SplitScreenUser = 0x3;
                public const long net_Disconnect_Legacy = 0x1;
                public const long net_SpawnGroup_Unload = 0xC;
                public const long net_SpawnGroup_LoadCompleted = 0xD;
                public const long net_SpawnGroup_ManifestUpdate = 0x9;
                public const long net_SpawnGroup_SetCreationTick = 0xB;
            }
            public static partial class PrefetchType {
                public const long PFT_SOUND = 0x0;
            }
            public static partial class RenderMode_t {
                public const long kRenderNone = 0x2;
                public const long kRenderNormal = 0x0;
                public const long kRenderModeCount = 0x3;
                public const long kRenderTransAlpha = 0x1;
            }
            public static partial class SVC_Messages {
                public const long svc_Menu = 0x39;
                public const long svc_Print = 0x30;
                public const long svc_Sounds = 0x31;
                public const long svc_SetView = 0x32;
                public const long svc_BSPDecal = 0x35;
                public const long svc_PeerList = 0x3C;
                public const long svc_Prefetch = 0x38;
                public const long svc_SetPause = 0x2B;
                public const long svc_UserCmds = 0x4C;
                public const long svc_ClassInfo = 0x2A;
                public const long svc_StopSound = 0x3B;
                public const long svc_VoiceData = 0x2F;
                public const long svc_VoiceInit = 0x2E;
                public const long svc_HLTVStatus = 0x3E;
                public const long svc_ServerInfo = 0x28;
                public const long svc_SplitScreen = 0x36;
                public const long svc_UserMessage = 0x48;
                public const long svc_CmdKeyValues = 0x34;
                public const long svc_GetCvarValue = 0x3A;
                public const long svc_EncryptedData = 0x4E;
                public const long svc_ServerSteamID = 0x3F;
                public const long svc_FullFrameSplit = 0x46;
                public const long svc_PacketEntities = 0x37;
                public const long svc_PacketReliable = 0x3D;
                public const long svc_NextMsgPredicted = 0x4D;
                public const long svc_Broadcast_Command = 0x4A;
                public const long svc_CreateStringTable = 0x2C;
                public const long svc_RconServerDetails = 0x47;
                public const long svc_UpdateStringTable = 0x2D;
                public const long svc_FlattenedSerializer = 0x29;
                public const long svc_ClearAllStringTables = 0x33;
                public const long svc_HltvFixupOperatorStatus = 0x4B;
            }
            public static partial class ShadowType_t {
                public const long SHADOWS_NONE = 0x0;
                public const long SHADOWS_SIMPLE = 0x1;
            }
            public static partial class ShardSolid_t {
                public const long SHARD_SOLID = 0x0;
                public const long SHARD_DEBRIS = 0x1;
            }
            public static partial class StanceType_t {
                public const long NUM_STANCES = 0x3;
                public const long STANCE_PRONE = 0x2;
                public const long STANCE_CURRENT = -0x1;
                public const long STANCE_DEFAULT = 0x0;
                public const long STANCE_CROUCHING = 0x1;
            }
            public static partial class TOGGLE_STATE {
                public const long DOOR_OPEN = 0x0;
                public const long TS_AT_TOP = 0x0;
                public const long DOOR_CLOSED = 0x1;
                public const long TS_GOING_UP = 0x2;
                public const long DOOR_CLOSING = 0x3;
                public const long DOOR_OPENING = 0x2;
                public const long TS_AT_BOTTOM = 0x1;
                public const long TS_GOING_DOWN = 0x3;
            }
            public static partial class WaterLevel_t {
                public const long WL_Feet = 0x1;
                public const long WL_Chest = 0x4;
                public const long WL_Count = 0x6;
                public const long WL_Knees = 0x2;
                public const long WL_Waist = 0x3;
                public const long WL_NotInWater = 0x0;
                public const long WL_FullyUnderwater = 0x5;
            }
            public static partial class CSPlayerState {
                public const long STATE_ACTIVE = 0x0;
                public const long STATE_DORMANT = 0x8;
                public const long STATE_WELCOME = 0x1;
                public const long STATE_DEATH_ANIM = 0x4;
                public const long NUM_PLAYER_STATES = 0x9;
                public const long STATE_PICKINGTEAM = 0x2;
                public const long STATE_PICKINGCLASS = 0x3;
                public const long STATE_OBSERVER_MODE = 0x6;
                public const long STATE_GUNGAME_RESPAWN = 0x7;
                public const long STATE_DEATH_WAIT_FOR_KEY = 0x5;
            }
            public static partial class DamageTypes_t {
                public const long DMG_ACID = 0x40000;
                public const long DMG_BURN = 0x8;
                public const long DMG_CLUB = 0x80;
                public const long DMG_FALL = 0x20;
                public const long DMG_BLAST = 0x40;
                public const long DMG_CRUSH = 0x1;
                public const long DMG_DROWN = 0x4000;
                public const long DMG_SHOCK = 0x100;
                public const long DMG_SLASH = 0x4;
                public const long DMG_SONIC = 0x200;
                public const long DMG_BULLET = 0x2;
                public const long DMG_POISON = 0x8000;
                public const long DMG_GENERIC = 0x0;
                public const long DMG_VEHICLE = 0x10;
                public const long DMG_BUCKSHOT = 0x800;
                public const long DMG_DISSOLVE = 0x2000;
                public const long DMG_HEADSHOT = 0x80000;
                public const long DMG_RADIATION = 0x10000;
                public const long DMG_ENERGYBEAM = 0x400;
                public const long DMG_DROWNRECOVER = 0x20000;
                public const long DMG_BLAST_SURFACE = 0x1000;
                public const long DMG_LASTGENERICFLAG = 0x40000;
            }
            public static partial class Disposition_t {
                public const long D_ER = 0x0;
                public const long D_FR = 0x2;
                public const long D_HT = 0x1;
                public const long D_LI = 0x3;
                public const long D_NU = 0x4;
                public const long D_FEAR = 0x2;
                public const long D_HATE = 0x1;
                public const long D_LIKE = 0x3;
                public const long D_ERROR = 0x0;
                public const long D_NEUTRAL = 0x4;
            }
            public static partial class EDemoCommands {
                public const long DEM_Max = 0x13;
                public const long DEM_Stop = 0x0;
                public const long DEM_Error = -0x1;
                public const long DEM_Packet = 0x7;
                public const long DEM_UserCmd = 0xC;
                public const long DEM_FileInfo = 0x2;
                public const long DEM_Recovery = 0x12;
                public const long DEM_SaveGame = 0xE;
                public const long DEM_SyncTick = 0x3;
                public const long DEM_ClassInfo = 0x5;
                public const long DEM_ConsoleCmd = 0x9;
                public const long DEM_CustomData = 0xA;
                public const long DEM_FileHeader = 0x1;
                public const long DEM_FullPacket = 0xD;
                public const long DEM_SendTables = 0x4;
                public const long DEM_SpawnGroups = 0xF;
                public const long DEM_IsCompressed = 0x40;
                public const long DEM_SignonPacket = 0x8;
                public const long DEM_StringTables = 0x6;
                public const long DEM_AnimationData = 0x10;
                public const long DEM_AnimationHeader = 0x11;
                public const long DEM_CustomDataCallbacks = 0xB;
            }
            public static partial class FixAngleSet_t {
                public const long _None = 0x0;
                public const long Absolute = 0x1;
                public const long Relative = 0x2;
            }
            public static partial class GrenadeType_t {
                public const long GRENADE_TYPE_FIRE = 0x2;
                public const long GRENADE_TYPE_DECOY = 0x3;
                public const long GRENADE_TYPE_FLASH = 0x1;
                public const long GRENADE_TYPE_SMOKE = 0x4;
                public const long GRENADE_TYPE_TOTAL = 0x5;
                public const long GRENADE_TYPE_EXPLOSIVE = 0x0;
            }
            public static partial class MoveCollide_t {
                public const long MOVECOLLIDE_COUNT = 0x4;
                public const long MOVECOLLIDE_DEFAULT = 0x0;
                public const long MOVECOLLIDE_MAX_BITS = 0x3;
                public const long MOVECOLLIDE_FLY_SLIDE = 0x3;
                public const long MOVECOLLIDE_FLY_BOUNCE = 0x1;
                public const long MOVECOLLIDE_FLY_CUSTOM = 0x2;
            }
            public static partial class SignonState_t {
                public const long SIGNONSTATE_NEW = 0x3;
                public const long SIGNONSTATE_FULL = 0x6;
                public const long SIGNONSTATE_NONE = 0x0;
                public const long SIGNONSTATE_SPAWN = 0x5;
                public const long SIGNONSTATE_PRESPAWN = 0x4;
                public const long SIGNONSTATE_CHALLENGE = 0x1;
                public const long SIGNONSTATE_CONNECTED = 0x2;
                public const long SIGNONSTATE_CHANGELEVEL = 0x7;
            }
            public static partial class WeaponSound_t {
                public const long WEAPON_SOUND_DROP = 0x16;
                public const long WEAPON_SOUND_EMPTY = 0x0;
                public const long WEAPON_SOUND_IMPACT = 0xD;
                public const long WEAPON_SOUND_RELOAD = 0x11;
                public const long WEAPON_SOUND_SINGLE = 0x2;
                public const long WEAPON_SOUND_REFLECT = 0xE;
                public const long WEAPON_SOUND_ZOOM_IN = 0x13;
                public const long WEAPON_SOUND_SPECIAL1 = 0x9;
                public const long WEAPON_SOUND_SPECIAL2 = 0xA;
                public const long WEAPON_SOUND_SPECIAL3 = 0xB;
                public const long WEAPON_SOUND_ZOOM_OUT = 0x14;
                public const long WEAPON_SOUND_MELEE_HIT = 0x5;
                public const long WEAPON_SOUND_NUM_TYPES = 0x18;
                public const long WEAPON_SOUND_RADIO_USE = 0x17;
                public const long WEAPON_SOUND_MELEE_MISS = 0x4;
                public const long WEAPON_SOUND_NEARLYEMPTY = 0xC;
                public const long WEAPON_SOUND_MELEE_HIT_NPC = 0x8;
                public const long WEAPON_SOUND_MOUSE_PRESSED = 0x15;
                public const long WEAPON_SOUND_MELEE_HIT_WORLD = 0x6;
                public const long WEAPON_SOUND_SECONDARY_EMPTY = 0x1;
                public const long WEAPON_SOUND_SINGLE_ACCURATE = 0x12;
                public const long WEAPON_SOUND_MELEE_HIT_PLAYER = 0x7;
                public const long WEAPON_SOUND_SECONDARY_ATTACK = 0x3;
                public const long WEAPON_SOUND_SECONDARY_IMPACT = 0xF;
                public const long WEAPON_SOUND_SECONDARY_REFLECT = 0x10;
            }
            public static partial class AmmoPosition_t {
                public const long AMMO_POSITION_COUNT = 0x2;
                public const long AMMO_POSITION_INVALID = -0x1;
                public const long AMMO_POSITION_PRIMARY = 0x0;
                public const long AMMO_POSITION_SECONDARY = 0x1;
            }
            public static partial class AnimLoopMode_t {
                public const long ANIM_LOOP_MODE_COUNT = 0x3;
                public const long ANIM_LOOP_MODE_INVALID = -0x1;
                public const long ANIM_LOOP_MODE_LOOPING = 0x1;
                public const long ANIM_LOOP_MODE_NOT_LOOPING = 0x0;
                public const long ANIM_LOOP_MODE_USE_SEQUENCE_SETTINGS = 0x2;
            }
            public static partial class CSWeaponNameID {
                public const long WEAPONID_C4 = 0x29;
                public const long WEAPONID_AUG = 0xF;
                public const long WEAPONID_AWP = 0x1C;
                public const long WEAPONID_MP7 = 0x14;
                public const long WEAPONID_MP9 = 0x15;
                public const long WEAPONID_P90 = 0x16;
                public const long WEAPONID_AK47 = 0xA;
                public const long WEAPONID_M249 = 0x20;
                public const long WEAPONID_M4A1 = 0xB;
                public const long WEAPONID_MAG7 = 0x18;
                public const long WEAPONID_NOVA = 0x19;
                public const long WEAPONID_P250 = 0x6;
                public const long WEAPONID_TEC9 = 0x8;
                public const long WEAPONID_BIZON = 0x11;
                public const long WEAPONID_CZ75A = 0x2;
                public const long WEAPONID_DECOY = 0x23;
                public const long WEAPONID_ELITE = 0x3;
                public const long WEAPONID_FAMAS = 0xD;
                public const long WEAPONID_G3SG1 = 0x1E;
                public const long WEAPONID_GLOCK = 0x0;
                public const long WEAPONID_KNIFE = 0x2B;
                public const long WEAPONID_MAC10 = 0x12;
                public const long WEAPONID_MP5SD = 0x13;
                public const long WEAPONID_NEGEV = 0x21;
                public const long WEAPONID_SG556 = 0x10;
                public const long WEAPONID_SSG08 = 0x1D;
                public const long WEAPONID_TASER = 0x22;
                public const long WEAPONID_UMP45 = 0x17;
                public const long WEAPONID_DEAGLE = 0x4;
                public const long WEAPONID_SCAR20 = 0x1F;
                public const long WEAPONID_XM1014 = 0x1B;
                public const long WEAPONID_BAYONET = 0x31;
                public const long WEAPONID_GALILAR = 0xE;
                public const long WEAPONID_HKP2000 = 0x1;
                public const long WEAPONID_KNIFE_T = 0x2C;
                public const long WEAPONID_MOLOTOV = 0x27;
                public const long WEAPONID_UNKNOWN = 0x41;
                public const long WEAPONID_REVOLVER = 0x7;
                public const long WEAPONID_SAWEDOFF = 0x1A;
                public const long WEAPONID_FIVESEVEN = 0x5;
                public const long WEAPONID_FLASHBANG = 0x24;
                public const long WEAPONID_HEGRENADE = 0x25;
                public const long WEAPONID_KNIFE_CSS = 0x2D;
                public const long WEAPONID_KNIFE_GUT = 0x2F;
                public const long WEAPONID_HEALTHSHOT = 0x2A;
                public const long WEAPONID_INCGRENADE = 0x26;
                public const long WEAPONID_KNIFE_CORD = 0x38;
                public const long WEAPONID_KNIFE_FLIP = 0x2E;
                public const long WEAPONID_KNIFE_PUSH = 0x37;
                public const long WEAPONID_KNIFE_CANIS = 0x39;
                public const long WEAPONID_KNIFE_KUKRI = 0x40;
                public const long WEAPONID_KNIFE_URSUS = 0x3A;
                public const long WEAPONID_SMOKEGRENADE = 0x28;
                public const long WEAPONID_USP_SILENCER = 0x9;
                public const long WEAPONID_KNIFE_OUTDOOR = 0x3C;
                public const long WEAPONID_M4A1_SILENCER = 0xC;
                public const long WEAPONID_KNIFE_FALCHION = 0x34;
                public const long WEAPONID_KNIFE_KARAMBIT = 0x30;
                public const long WEAPONID_KNIFE_SKELETON = 0x3F;
                public const long WEAPONID_KNIFE_STILETTO = 0x3D;
                public const long WEAPONID_KNIFE_TACTICAL = 0x33;
                public const long WEAPONID_KNIFE_BUTTERFLY = 0x36;
                public const long WEAPONID_KNIFE_M9_BAYONET = 0x32;
                public const long WEAPONID_KNIFE_WIDOWMAKER = 0x3E;
                public const long WEAPONID_KNIFE_SURVIVAL_BOWIE = 0x35;
                public const long WEAPONID_KNIFE_GYPSY_JACKKNIFE = 0x3B;
            }
            public static partial class EClientUIEvent {
                public const long EClientUIEvent_Invalid = 0x0;
                public const long EClientUIEvent_FireOutput = 0x2;
                public const long EClientUIEvent_DialogFinished = 0x1;
            }
            public static partial class EGCMsgResponse {
                public const long k_EGCMsgResponseOK = 0x0;
                public const long k_EGCMsgLimitExceeded = 0x9;
                public const long k_EGCMsgFailedToCreate = 0x8;
                public const long k_EGCMsgResponseDenied = 0x1;
                public const long k_EGCMsgResponseInvalid = 0x4;
                public const long k_EGCMsgResponseNoMatch = 0x5;
                public const long k_EGCMsgResponseTimeout = 0x3;
                public const long k_EGCMsgCommitUnfinalized = 0xA;
                public const long k_EGCMsgResponseNotLoggedOn = 0x7;
                public const long k_EGCMsgResponseServerError = 0x2;
                public const long k_EGCMsgResponseUnknownError = 0x6;
            }
            public static partial class EInButtonState {
                public const long IN_BUTTON_UP = 0x0;
                public const long IN_BUTTON_DOWN = 0x1;
                public const long IN_BUTTON_DOWN_UP = 0x2;
                public const long IN_BUTTON_UP_DOWN = 0x3;
                public const long IN_BUTTON_UP_DOWN_UP = 0x4;
                public const long IN_BUTTON_STATE_COUNT = 0x8;
                public const long IN_BUTTON_DOWN_UP_DOWN = 0x5;
                public const long IN_BUTTON_DOWN_UP_DOWN_UP = 0x6;
                public const long IN_BUTTON_UP_DOWN_UP_DOWN = 0x7;
            }
            public static partial class ETEProtobufIds {
                public const long TE_DustId = 0x1A4;
                public const long TE_FizzId = 0x19D;
                public const long TE_DecalId = 0x19A;
                public const long TE_SmokeId = 0x1AA;
                public const long TE_ImpactId = 0x1A0;
                public const long TE_SparksId = 0x1A6;
                public const long TE_BubblesId = 0x198;
                public const long TE_BeamEntsId = 0x193;
                public const long TE_BeamRingId = 0x195;
                public const long TE_ExplosionId = 0x1A3;
                public const long TE_BeamPointsId = 0x194;
                public const long TE_GlowSpriteId = 0x19F;
                public const long TE_WorldDecalId = 0x19B;
                public const long TE_BloodStreamId = 0x1A2;
                public const long TE_BubbleTrailId = 0x199;
                public const long TE_LargeFunnelId = 0x1A5;
                public const long TE_MuzzleFlashId = 0x1A1;
                public const long TE_PhysicsPropId = 0x1A7;
                public const long TE_BeamEntPointId = 0x192;
                public const long TE_EnergySplashId = 0x19C;
                public const long TE_ArmorRicochetId = 0x191;
                public const long TE_EffectDispatchId = 0x190;
                public const long TE_ShatterSurfaceId = 0x19E;
            }
            public static partial class InputBitMask_t {
                public const long IN_ALL = -0x1;
                public const long IN_USE = 0x20;
                public const long IN_BACK = 0x10;
                public const long IN_DUCK = 0x4;
                public const long IN_JUMP = 0x2;
                public const long IN_NONE = 0x0;
                public const long IN_ZOOM = 0x400000000;
                public const long IN_SCORE = 0x200000000;
                public const long IN_SPEED = 0x10000;
                public const long IN_ATTACK = 0x1;
                public const long IN_RELOAD = 0x2000;
                public const long IN_ATTACK2 = 0x800;
                public const long IN_FORWARD = 0x8;
                public const long IN_MOVELEFT = 0x200;
                public const long IN_TURNLEFT = 0x80;
                public const long IN_MOVERIGHT = 0x400;
                public const long IN_TURNRIGHT = 0x100;
                public const long IN_USEORRELOAD = 0x100000000;
                public const long IN_JOYAUTOSPRINT = 0x20000;
                public const long IN_LOOK_AT_WEAPON = 0x800000000;
                public const long IN_FIRST_MOD_SPECIFIC_BIT = 0x100000000;
            }
            public static partial class ObserverMode_t {
                public const long OBS_MODE_NONE = 0x0;
                public const long OBS_MODE_CHASE = 0x3;
                public const long OBS_MODE_FIXED = 0x1;
                public const long OBS_MODE_IN_EYE = 0x2;
                public const long OBS_MODE_ROAMING = 0x4;
                public const long NUM_OBSERVER_MODES = 0x5;
            }
            public static partial class RequestPause_t {
                public const long RP_PAUSE = 0x0;
                public const long RP_UNPAUSE = 0x1;
                public const long RP_TOGGLEPAUSE = 0x2;
            }
            public static partial class RumbleEffect_t {
                public const long RUMBLE_357 = 0x2;
                public const long RUMBLE_AR2 = 0x4;
                public const long RUMBLE_SMG1 = 0x3;
                public const long RUMBLE_PISTOL = 0x1;
                public const long RUMBLE_DMG_LOW = 0xF;
                public const long RUMBLE_DMG_MED = 0x10;
                public const long RUMBLE_INVALID = -0x1;
                public const long RUMBLE_DMG_HIGH = 0x11;
                public const long RUMBLE_STOP_ALL = 0x0;
                public const long RUMBLE_FALL_LONG = 0x12;
                public const long RUMBLE_FLAT_BOTH = 0xE;
                public const long RUMBLE_FLAT_LEFT = 0xC;
                public const long RUMBLE_FALL_SHORT = 0x13;
                public const long RUMBLE_FLAT_RIGHT = 0xD;
                public const long NUM_RUMBLE_EFFECTS = 0x19;
                public const long RUMBLE_AIRBOAT_GUN = 0xA;
                public const long RUMBLE_RPG_MISSILE = 0x8;
                public const long RUMBLE_AR2_ALT_FIRE = 0x7;
                public const long RUMBLE_CROWBAR_SWING = 0x9;
                public const long RUMBLE_PHYSCANNON_LOW = 0x16;
                public const long RUMBLE_SHOTGUN_DOUBLE = 0x6;
                public const long RUMBLE_SHOTGUN_SINGLE = 0x5;
                public const long RUMBLE_PHYSCANNON_HIGH = 0x18;
                public const long RUMBLE_PHYSCANNON_OPEN = 0x14;
                public const long RUMBLE_PHYSCANNON_PUNT = 0x15;
                public const long RUMBLE_JEEP_ENGINE_LOOP = 0xB;
                public const long RUMBLE_PHYSCANNON_MEDIUM = 0x17;
            }
            public static partial class ShakeCommand_t {
                public const long SHAKE_STOP = 0x1;
                public const long SHAKE_START = 0x0;
                public const long SHAKE_DURATION = 0x6;
                public const long SHAKE_AMPLITUDE = 0x2;
                public const long SHAKE_FREQUENCY = 0x3;
                public const long SHAKE_START_NORUMBLE = 0x5;
                public const long SHAKE_START_RUMBLEONLY = 0x4;
            }
            public static partial class loadout_slot_t {
                public const long LOADOUT_SLOT_C4 = 0x1;
                public const long LOADOUT_SLOT_PET = 0x39;
                public const long LOADOUT_SLOT_SMG0 = 0x8;
                public const long LOADOUT_SLOT_SMG1 = 0x9;
                public const long LOADOUT_SLOT_SMG2 = 0xA;
                public const long LOADOUT_SLOT_SMG3 = 0xB;
                public const long LOADOUT_SLOT_SMG4 = 0xC;
                public const long LOADOUT_SLOT_SMG5 = 0xD;
                public const long LOADOUT_SLOT_COUNT = 0x3A;
                public const long LOADOUT_SLOT_MELEE = 0x0;
                public const long LOADOUT_SLOT_MISC0 = 0x2F;
                public const long LOADOUT_SLOT_MISC1 = 0x30;
                public const long LOADOUT_SLOT_MISC2 = 0x31;
                public const long LOADOUT_SLOT_MISC3 = 0x32;
                public const long LOADOUT_SLOT_MISC4 = 0x33;
                public const long LOADOUT_SLOT_MISC5 = 0x34;
                public const long LOADOUT_SLOT_MISC6 = 0x35;
                public const long LOADOUT_SLOT_FLAIR0 = 0x37;
                public const long LOADOUT_SLOT_HEAVY0 = 0x14;
                public const long LOADOUT_SLOT_HEAVY1 = 0x15;
                public const long LOADOUT_SLOT_HEAVY2 = 0x16;
                public const long LOADOUT_SLOT_HEAVY3 = 0x17;
                public const long LOADOUT_SLOT_HEAVY4 = 0x18;
                public const long LOADOUT_SLOT_HEAVY5 = 0x19;
                public const long LOADOUT_SLOT_RIFLE0 = 0xE;
                public const long LOADOUT_SLOT_RIFLE1 = 0xF;
                public const long LOADOUT_SLOT_RIFLE2 = 0x10;
                public const long LOADOUT_SLOT_RIFLE3 = 0x11;
                public const long LOADOUT_SLOT_RIFLE4 = 0x12;
                public const long LOADOUT_SLOT_RIFLE5 = 0x13;
                public const long LOADOUT_SLOT_SPRAY0 = 0x38;
                public const long LOADOUT_SLOT_INVALID = -0x1;
                public const long LOADOUT_SLOT_GRENADE0 = 0x1A;
                public const long LOADOUT_SLOT_GRENADE1 = 0x1B;
                public const long LOADOUT_SLOT_GRENADE2 = 0x1C;
                public const long LOADOUT_SLOT_GRENADE3 = 0x1D;
                public const long LOADOUT_SLOT_GRENADE4 = 0x1E;
                public const long LOADOUT_SLOT_GRENADE5 = 0x1F;
                public const long LOADOUT_SLOT_MUSICKIT = 0x36;
                public const long LOADOUT_SLOT_PROMOTED = -0x2;
                public const long LOADOUT_SLOT_EQUIPMENT0 = 0x20;
                public const long LOADOUT_SLOT_EQUIPMENT1 = 0x21;
                public const long LOADOUT_SLOT_EQUIPMENT2 = 0x22;
                public const long LOADOUT_SLOT_EQUIPMENT3 = 0x23;
                public const long LOADOUT_SLOT_EQUIPMENT4 = 0x24;
                public const long LOADOUT_SLOT_EQUIPMENT5 = 0x25;
                public const long LOADOUT_SLOT_SECONDARY0 = 0x2;
                public const long LOADOUT_SLOT_SECONDARY1 = 0x3;
                public const long LOADOUT_SLOT_SECONDARY2 = 0x4;
                public const long LOADOUT_SLOT_SECONDARY3 = 0x5;
                public const long LOADOUT_SLOT_SECONDARY4 = 0x6;
                public const long LOADOUT_SLOT_SECONDARY5 = 0x7;
                public const long LOADOUT_SLOT_CLOTHING_HAT = 0x2B;
                public const long LOADOUT_SLOT_LAST_COSMETIC = 0x29;
                public const long LOADOUT_SLOT_CLOTHING_HANDS = 0x29;
                public const long LOADOUT_SLOT_CLOTHING_TORSO = 0x2D;
                public const long LOADOUT_SLOT_FIRST_COSMETIC = 0x29;
                public const long LOADOUT_SLOT_CLOTHING_EYEWEAR = 0x2A;
                public const long LOADOUT_SLOT_CLOTHING_FACEMASK = 0x28;
                public const long LOADOUT_SLOT_LAST_WHEEL_WEAPON = 0x19;
                public const long LOADOUT_SLOT_CLOTHING_LOWERBODY = 0x2C;
                public const long LOADOUT_SLOT_FIRST_WHEEL_WEAPON = 0x2;
                public const long LOADOUT_SLOT_LAST_ALL_CHARACTER = 0x39;
                public const long LOADOUT_SLOT_LAST_WHEEL_GRENADE = 0x1F;
                public const long LOADOUT_SLOT_CLOTHING_APPEARANCE = 0x2E;
                public const long LOADOUT_SLOT_CLOTHING_CUSTOMHEAD = 0x27;
                public const long LOADOUT_SLOT_FIRST_ALL_CHARACTER = 0x36;
                public const long LOADOUT_SLOT_FIRST_WHEEL_GRENADE = 0x1A;
                public const long LOADOUT_SLOT_LAST_PRIMARY_WEAPON = 0x19;
                public const long LOADOUT_SLOT_FIRST_PRIMARY_WEAPON = 0x8;
                public const long LOADOUT_SLOT_LAST_AUTO_BUY_WEAPON = 0x1;
                public const long LOADOUT_SLOT_LAST_WHEEL_EQUIPMENT = 0x25;
                public const long LOADOUT_SLOT_CLOTHING_CUSTOMPLAYER = 0x26;
                public const long LOADOUT_SLOT_FIRST_AUTO_BUY_WEAPON = 0x0;
                public const long LOADOUT_SLOT_FIRST_WHEEL_EQUIPMENT = 0x20;
            }
            public static partial class C4LightEffect_t {
                public const long eLightEffectNone = 0x0;
                public const long eLightEffectDropped = 0x1;
                public const long eLightEffectThirdPersonHeld = 0x2;
            }
            public static partial class EBaseGameEvents {
                public const long GE_PlaceDecalEvent = 0xC9;
                public const long GE_SosStopSoundEvent = 0xD1;
                public const long GE_SosStartSoundEvent = 0xD0;
                public const long GE_ClothEffectAnimEvent = 0xD6;
                public const long GE_ClearWorldDecalsEvent = 0xCA;
                public const long GE_ClothStiffenAnimEvent = 0xD5;
                public const long GE_SosStopSoundEventHash = 0xD4;
                public const long GE_ClearEntityDecalsEvent = 0xCB;
                public const long GE_SosSetSoundEventParams = 0xD2;
                public const long GE_Source1LegacyGameEvent = 0xCF;
                public const long GE_SosSetLibraryStackFields = 0xD3;
                public const long GE_VDebugGameSessionIDEvent = 0xC8;
                public const long GE_ClearDecalsForEntityEvent = 0xCC;
                public const long GE_Source1LegacyListenEvents = 0xCE;
                public const long GE_Source1LegacyGameEventList = 0xCD;
            }
            public static partial class ECsgoGameEvents {
                public const long GE_FireBulletsId = 0x1C4;
                public const long GE_RadioIconEventId = 0x1C3;
                public const long GE_PlayerAnimEventId = 0x1C2;
                public const long GE_PlayerBulletHitId = 0x1C5;
            }
            public static partial class EntityEffects_t {
                public const long EF_NODRAW = 0x20;
                public const long EF_MAX_BITS = 0xA;
                public const long EF_NOSHADOW = 0x10;
                public const long EF_NORECEIVESHADOW = 0x40;
                public const long EF_PARENT_ANIMATES = 0x200;
                public const long DEPRICATED_EF_NOINTERP = 0x8;
                public const long EF_NODRAW_BUT_TRANSMIT = 0x400;
            }
            public static partial class HierarchyType_t {
                public const long HIERARCHY_BONE = 0x4;
                public const long HIERARCHY_NONE = 0x0;
                public const long HIERARCHY_ABSORIGIN = 0x3;
                public const long HIERARCHY_ATTACHMENT = 0x2;
                public const long HIERARCHY_BONE_MERGE = 0x1;
                public const long HIERARCHY_TYPE_COUNT = 0x5;
            }
            public static partial class ItemFlagTypes_t {
                public const long ITEM_FLAG_NONE = 0x0;
                public const long ITEM_FLAG_EXHAUSTIBLE = 0x10;
                public const long ITEM_FLAG_LIMITINWORLD = 0x8;
                public const long ITEM_FLAG_NOAUTORELOAD = 0x2;
                public const long ITEM_FLAG_NOITEMPICKUP = 0x80;
                public const long ITEM_FLAG_NOAMMOPICKUPS = 0x40;
                public const long ITEM_FLAG_DOHITLOCATIONDMG = 0x20;
                public const long ITEM_FLAG_NOAUTOSWITCHEMPTY = 0x4;
                public const long ITEM_FLAG_CAN_SELECT_WITHOUT_AMMO = 0x1;
            }
            public static partial class NavScopeFlags_t {
                public const long eAir = 0x2;
                public const long eAll = 0x3;
                public const long eNone = 0x0;
                public const long eGround = 0x1;
            }
            public static partial class eSplinePushType {
                public const long k_eSplinePushAway = 0x1;
                public const long k_eSplinePushAlong = 0x0;
                public const long k_eSplinePushTowards = 0x2;
            }
            public static partial class navproperties_t {
                public const long NAV_IGNORE = 0x1;
            }
            public static partial class soundcommands_t {
                public const long SOUNDCTRL_STOP = 0x2;
                public const long SOUNDCTRL_DESTROY = 0x3;
                public const long SOUNDCTRL_FADEOUT = 0x4;
                public const long SOUNDCTRL_CHANGE_PITCH = 0x1;
                public const long SOUNDCTRL_CHANGE_VOLUME = 0x0;
            }
            public static partial class CSWeaponCategory {
                public const long WEAPONCATEGORY_SMG = 0x3;
                public const long WEAPONCATEGORY_COUNT = 0x6;
                public const long WEAPONCATEGORY_HEAVY = 0x5;
                public const long WEAPONCATEGORY_MELEE = 0x1;
                public const long WEAPONCATEGORY_OTHER = 0x0;
                public const long WEAPONCATEGORY_RIFLE = 0x4;
                public const long WEAPONCATEGORY_SECONDARY = 0x2;
            }
            public static partial class ChatIgnoreType_t {
                public const long CHAT_IGNORE_ALL = 0x1;
                public const long CHAT_IGNORE_NONE = 0x0;
                public const long CHAT_IGNORE_TEAM = 0x2;
            }
            public static partial class EChickenActivity {
                public const long Run = 0x3;
                public const long Feed = 0x9;
                public const long Idle = 0x0;
                public const long Land = 0x5;
                public const long Walk = 0x2;
                public const long Glide = 0x4;
                public const long Panic = 0x6;
                public const long Sleep = 0xA;
                public const long Squat = 0x1;
                public const long Trick = 0x7;
                public const long Shoulder = 0xB;
                public const long LowOnFood = 0xC;
                public const long TurnInPlace = 0x8;
            }
            public static partial class EGCBaseClientMsg {
                public const long k_EMsgGCClientHello = 0xFA6;
                public const long k_EMsgGCServerHello = 0xFA7;
                public const long k_EMsgGCClientHelloPW = 0xFAC;
                public const long k_EMsgGCClientHelloR2 = 0xFAD;
                public const long k_EMsgGCClientHelloR3 = 0xFAE;
                public const long k_EMsgGCClientHelloR4 = 0xFAF;
                public const long k_EMsgGCClientWelcome = 0xFA4;
                public const long k_EMsgGCServerWelcome = 0xFA5;
                public const long k_EMsgGCClientHelloPartner = 0xFAB;
                public const long k_EMsgGCClientConnectionStatus = 0xFA9;
                public const long k_EMsgGCServerConnectionStatus = 0xFAA;
            }
            public static partial class EHapticPulseType {
                public const long VR_HAND_HAPTIC_PULSE_LIGHT = 0x0;
                public const long VR_HAND_HAPTIC_PULSE_MEDIUM = 0x1;
                public const long VR_HAND_HAPTIC_PULSE_STRONG = 0x2;
            }
            public static partial class GCProtoBufMsgSrc {
                public const long GCProtoBufMsgSrc_FromGC = 0x3;
                public const long GCProtoBufMsgSrc_FromSystem = 0x1;
                public const long GCProtoBufMsgSrc_FromSteamID = 0x2;
                public const long GCProtoBufMsgSrc_ReplySystem = 0x4;
                public const long GCProtoBufMsgSrc_Unspecified = 0x0;
            }
            public static partial class HoverPoseFlags_t {
                public const long eNone = 0x0;
                public const long eAngles = 0x2;
                public const long ePosition = 0x1;
            }
            public static partial class NavAttributeEnum {
                public const long NAV_MESH_RUN = 0x20;
                public const long NAV_MESH_JUMP = 0x2;
                public const long NAV_MESH_NONE = 0x0;
                public const long NAV_MESH_STOP = 0x10;
                public const long NAV_MESH_WALK = 0x40;
                public const long NAV_MESH_AVOID = 0x80;
                public const long NAV_MESH_STAND = 0x400;
                public const long NAV_MESH_STAIRS = 0x1000;
                public const long NAV_MESH_NON_ZUP = 0x8000;
                public const long NAV_MESH_NO_JUMP = 0x8;
                public const long NAV_MESH_NO_MERGE = 0x2000;
                public const long NAV_MESH_DONT_HIDE = 0x200;
                public const long NAV_MESH_TRANSIENT = 0x100;
                public const long NAV_ATTR_LAST_INDEX = 0x3F;
                public const long NAV_MESH_NO_HOSTAGES = 0x800;
                public const long NAV_MESH_CRAWL_HEIGHT = 0x40000;
                public const long NAV_MESH_OBSTACLE_TOP = 0x4000;
                public const long NAV_MESH_CROUCH_HEIGHT = 0x10000;
                public const long NAV_ATTR_FIRST_GAME_INDEX = 0x13;
                public const long NAV_MESH_NON_ZUP_TRANSITION = 0x20000;
            }
            public static partial class PARTICLE_MESSAGE {
                public const long GAME_PARTICLE_MANAGER_EVENT_CREATE = 0x0;
                public const long GAME_PARTICLE_MANAGER_EVENT_FROZEN = 0xC;
                public const long GAME_PARTICLE_MANAGER_EVENT_UPDATE = 0x1;
                public const long GAME_PARTICLE_MANAGER_EVENT_ADD_FAN = 0x24;
                public const long GAME_PARTICLE_MANAGER_EVENT_DESTROY = 0x7;
                public const long GAME_PARTICLE_MANAGER_EVENT_LATENCY = 0xA;
                public const long GAME_PARTICLE_MANAGER_EVENT_RELEASE = 0x9;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_TEXT = 0x10;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_VDATA = 0x22;
                public const long GAME_PARTICLE_MANAGER_EVENT_CAN_FREEZE = 0x19;
                public const long GAME_PARTICLE_MANAGER_EVENT_REMOVE_FAN = 0x27;
                public const long GAME_PARTICLE_MANAGER_EVENT_UPDATE_ENT = 0x5;
                public const long GAME_PARTICLE_MANAGER_EVENT_UPDATE_FAN = 0x25;
                public const long GAME_PARTICLE_MANAGER_EVENT_SHOULD_DRAW = 0xB;
                public const long GAME_PARTICLE_MANAGER_EVENT_SKIP_TO_TIME = 0x18;
                public const long GAME_PARTICLE_MANAGER_EVENT_DESTROY_NAMED = 0x17;
                public const long GAME_PARTICLE_MANAGER_EVENT_UPDATE_OFFSET = 0x6;
                public const long GAME_PARTICLE_MANAGER_EVENT_UPDATE_FORWARD = 0x2;
                public const long GAME_PARTICLE_MANAGER_EVENT_UPDATE_FALLBACK = 0x4;
                public const long GAME_PARTICLE_MANAGER_EVENT_FREEZE_INVOLVING = 0x1D;
                public const long GAME_PARTICLE_MANAGER_EVENT_UPDATE_TRANSFORM = 0x1B;
                public const long GAME_PARTICLE_MANAGER_EVENT_CREATE_SMOKE_GRID = 0x28;
                public const long GAME_PARTICLE_MANAGER_EVENT_DESTROY_INVOLVING = 0x8;
                public const long GAME_PARTICLE_MANAGER_EVENT_CREATE_PHYSICS_SIM = 0x20;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_CLUSTER_GROWTH = 0x26;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_FOW_PROPERTIES = 0xF;
                public const long GAME_PARTICLE_MANAGER_EVENT_UPDATE_ORIENTATION = 0x3;
                public const long GAME_PARTICLE_MANAGER_EVENT_DESTROY_PHYSICS_SIM = 0x21;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_OVERRIDE_TEXTURE = 0x29;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_SHOULD_CHECK_FOW = 0x11;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_MATERIAL_OVERRIDE = 0x23;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_TEXTURE_ATTRIBUTE = 0x14;
                public const long GAME_PARTICLE_MANAGER_EVENT_UPDATE_ENTITY_POSITION = 0xE;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_CONTROL_POINT_MODEL = 0x12;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_NAMED_VALUE_CONTEXT = 0x1A;
                public const long GAME_PARTICLE_MANAGER_EVENT_CLEAR_MODELLIST_OVERRIDE = 0x1F;
                public const long GAME_PARTICLE_MANAGER_EVENT_FREEZE_TRANSITION_OVERRIDE = 0x1C;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_CONTROL_POINT_SNAPSHOT = 0x13;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_SCENE_OBJECT_GENERIC_FLAG = 0x15;
                public const long GAME_PARTICLE_MANAGER_EVENT_ADD_MODELLIST_OVERRIDE_ELEMENT = 0x1E;
                public const long GAME_PARTICLE_MANAGER_EVENT_CHANGE_CONTROL_POINT_ATTACHMENT = 0xD;
                public const long GAME_PARTICLE_MANAGER_EVENT_SET_SCENE_OBJECT_TINT_AND_DESAT = 0x16;
            }
            public static partial class BrushSolidities_e {
                public const long BRUSHSOLID_NEVER = 0x1;
                public const long BRUSHSOLID_ALWAYS = 0x2;
                public const long BRUSHSOLID_TOGGLE = 0x0;
            }
            public static partial class CanPlaySequence_t {
                public const long CANNOT_PLAY = 0x0;
                public const long CAN_PLAY_NOW = 0x1;
                public const long CAN_PLAY_ENQUEUED = 0x2;
            }
            public static partial class EBaseUserMessages {
                public const long UM_Fade = 0x6A;
                public const long UM_Shake = 0x78;
                public const long UM_HudMsg = 0x6E;
                public const long UM_Rumble = 0x74;
                public const long UM_HudText = 0x6F;
                public const long UM_SayText = 0x75;
                public const long UM_TextMsg = 0x7C;
                public const long UM_HudError = 0x92;
                public const long UM_MAX_BASE = 0xC8;
                public const long UM_ResetHUD = 0x73;
                public const long UM_SayText2 = 0x76;
                public const long UM_ShakeDir = 0x79;
                public const long UM_ShowMenu = 0x86;
                public const long UM_GameTitle = 0x6B;
                public const long UM_SendAudio = 0x82;
                public const long UM_VoiceMask = 0x80;
                public const long UM_AmmoDenied = 0x84;
                public const long UM_CreditsMsg = 0x87;
                public const long UM_ItemPickup = 0x83;
                public const long UM_ScreenTilt = 0x7D;
                public const long UM_WaterShake = 0x7A;
                public const long UM_ColoredText = 0x71;
                public const long UM_UsageReport = 0xA8;
                public const long UM_RequestState = 0x72;
                public const long UM_ExtraUserData = 0xA4;
                public const long UM_AudioParameter = 0x90;
                public const long UM_SayTextChannel = 0x77;
                public const long UM_UserSentBugBug = 0xA7;
                public const long UM_AnimGraphUpdate = 0x95;
                public const long UM_CustomGameEvent = 0x94;
                public const long UM_ParticleManager = 0x91;
                public const long UM_ServerFrameTime = 0x9A;
                public const long UM_AchievementEvent = 0x65;
                public const long UM_CameraTransition = 0x8F;
                public const long UM_CurrentTimescale = 0x68;
                public const long UM_DesiredTimescale = 0x69;
                public const long UM_RequestDllStatus = 0x9C;
                public const long UM_RequestInventory = 0xA0;
                public const long UM_UpdateCssClasses = 0x99;
                public const long UM_DllStatusResponse = 0x9F;
                public const long UM_InventoryResponse = 0xA1;
                public const long UM_RequestDiagnostic = 0xA2;
                public const long UM_RequestUtilAction = 0x9D;
                public const long UM_DiagnosticResponse = 0xA3;
                public const long UM_UtilActionResponse = 0x9E;
                public const long UM_HapticsManagerPulse = 0x96;
                public const long UM_NotifyResponseFound = 0xA5;
                public const long UM_RemoteServerCommand = 0xA9;
                public const long UM_HapticsManagerEffect = 0x97;
                public const long UM_LagCompensationError = 0x9B;
                public const long UM_RemoteServerResponse = 0xAA;
                public const long UM_CloseCaptionPlaceholder = 0x8E;
                public const long UM_PlayResponseConditional = 0xA6;
            }
            public static partial class EntFinderMethod_t {
                public const long ENT_FIND_METHOD_RANDOM = 0x2;
                public const long ENT_FIND_METHOD_NEAREST = 0x0;
                public const long ENT_FIND_METHOD_FARTHEST = 0x1;
            }
            public static partial class GC_BannedWordType {
                public const long GC_BANNED_WORD_ENABLE_WORD = 0x1;
                public const long GC_BANNED_WORD_DISABLE_WORD = 0x0;
            }
            public static partial class PerformanceMode_t {
                public const long PM_NORMAL = 0x0;
                public const long PM_NO_GIBS = 0x1;
            }
            public static partial class ReplayEventType_t {
                public const long REPLAY_EVENT_DEATH = 0x1;
                public const long REPLAY_EVENT_CANCEL = 0x0;
                public const long REPLAY_EVENT_GENERIC = 0x2;
                public const long REPLAY_EVENT_VICTORY = 0x4;
                public const long REPLAY_EVENT_STUCK_NEED_FULL_UPDATE = 0x3;
            }
            public static partial class ScriptedOnDeath_t {
                public const long SS_ONDEATH_RAGDOLL = 0x1;
                public const long SS_ONDEATH_UNDEFINED = 0x0;
                public const long SS_ONDEATH_ANIMATED_DEATH = 0x2;
                public const long SS_ONDEATH_NOT_APPLICABLE = -0x1;
            }
            public static partial class SpawnGroupFlags_t {
                public const long SPAWN_GROUP_SYNCHRONOUS_SPAWN = 0x4;
                public const long SPAWN_GROUP_BLOCK_UNTIL_LOADED = 0x40;
                public const long SPAWN_GROUP_DONT_SPAWN_ENTITIES = 0x2;
                public const long SPAWN_GROUP_LOAD_STREAMING_DATA = 0x80;
                public const long SPAWN_GROUP_CREATE_NEW_SCENE_WORLD = 0x100;
                public const long SPAWN_GROUP_IS_INITIAL_SPAWN_GROUP = 0x8;
                public const long SPAWN_GROUP_LOAD_ENTITIES_FROM_SAVE = 0x1;
                public const long SPAWN_GROUP_CREATE_CLIENT_ONLY_ENTITIES = 0x10;
            }
            public static partial class TakeDamageFlags_t {
                public const long DFLAG_NONE = 0x0;
                public const long DMG_LASTDFLAG = 0x20000;
                public const long DFLAG_NEVER_GIB = 0x40;
                public const long DFLAG_ALWAYS_GIB = 0x20;
                public const long DFLAG_RADIUS_DMG = 0x400;
                public const long DFLAG_FORCE_DEATH = 0x10;
                public const long DFLAG_IGNORE_ARMOR = 0x40000;
                public const long DFLAG_PREVENT_DEATH = 0x8;
                public const long DFLAG_SUPPRESS_EFFECTS = 0x4;
                public const long DFLAG_REMOVE_NO_RAGDOLL = 0x80;
                public const long DFLAG_FORCE_PHYSICS_FORCE = 0x8000;
                public const long DFLAG_SUPPRESS_BREAKABLES = 0x4000;
                public const long DFLAG_SUPPRESS_UTILREMOVE = 0x80000;
                public const long DFLAG_FORCEREDUCEARMOR_DMG = 0x800;
                public const long DFLAG_SUPPRESS_PHYSICS_FORCE = 0x2;
                public const long DFLAG_ALLOW_NON_AUTHORITATIVE = 0x20000;
                public const long DFLAG_SUPPRESS_HEALTH_CHANGES = 0x1;
                public const long DFLAG_ALWAYS_FIRE_DAMAGE_EVENTS = 0x200;
                public const long DFLAG_IGNORE_DESTRUCTIBLE_PARTS = 0x2000;
                public const long DFLAG_SUPPRESS_INTERRUPT_FLINCH = 0x1000;
                public const long DFLAG_SUPPRESS_DAMAGE_MODIFICATION = 0x100;
                public const long DFLAG_SUPPRESS_SCREENSPACE_DAMAGE_FX = 0x10000;
            }
            public static partial class VoiceDataFormat_t {
                public const long VOICEDATA_FORMAT_OPUS = 0x2;
                public const long VOICEDATA_FORMAT_STEAM = 0x0;
                public const long VOICEDATA_FORMAT_ENGINE = 0x1;
            }
            public static partial class BodySectionMutex_t {
                public const long eNone = 0x0;
                public const long eFullBody = 0x3;
                public const long eLowerBody = 0x1;
                public const long eUpperBody = 0x2;
            }
            public static partial class CFuncMover__Move_t {
                public const long MOVE_LOOP = 0x0;
                public const long MOVE_OSCILLATE = 0x1;
                public const long MOVE_STOP_AT_END = 0x2;
            }
            public static partial class ChoreoLookAtMode_t {
                public const long eHead = 0x1;
                public const long eChest = 0x0;
                public const long eInvalid = -0x1;
                public const long eEyesOnly = 0x2;
            }
            public static partial class ChoreoStrafeMode_t {
                public const long ENABLE = 0x1;
                public const long DEFAULT = 0x0;
                public const long DISABLE = 0x2;
            }
            public static partial class CustomCameraMode_t {
                public const long CUSTOM_CAMERA_MODE_DISABLED = 0x0;
                public const long CUSTOM_CAMERA_MODE_CONTROLLED = 0x1;
                public const long CUSTOM_CAMERA_MODE_FOLLOW_POSITION = 0x3;
                public const long CUSTOM_CAMERA_MODE_CONTROLLED_POSITION = 0x2;
            }
            public static partial class DebugOverlayBits_t {
                public const long OVERLAY_BBOX_BIT = 0x4;
                public const long OVERLAY_NAME_BIT = 0x2;
                public const long OVERLAY_RBOX_BIT = 0x40;
                public const long OVERLAY_TEXT_BIT = 0x1;
                public const long OVERLAY_PIVOT_BIT = 0x8;
                public const long OVERLAY_ABSBOX_BIT = 0x20;
                public const long OVERLAY_HITBOX_BIT = 0x4000;
                public const long OVERLAY_PROP_DEBUG = 0x200000000;
                public const long OVERLAY_VIEWOFFSET = 0x800000000;
                public const long OVERLAY_AUTOAIM_BIT = 0x10000;
                public const long OVERLAY_BUDDHA_MODE = 0x40000000;
                public const long OVERLAY_MESSAGE_BIT = 0x10;
                public const long OVERLAY_MINIMAL_TEXT = 0x20000000000;
                public const long OVERLAY_NPC_GOD_MODE = 0x40000000000;
                public const long OVERLAY_NPC_KILL_BIT = 0x10000000;
                public const long OVERLAY_NPC_TASK_BIT = 0x2000000;
                public const long OVERLAY_SKELETON_BIT = 0x800;
                public const long OVERLAY_ACTORNAME_BIT = 0x4000000000;
                public const long OVERLAY_NPC_ROUTE_BIT = 0x80000;
                public const long OVERLAY_JOINT_INFO_BIT = 0x40000;
                public const long OVERLAY_NPC_COMBAT_BIT = 0x1000000;
                public const long OVERLAY_SHOW_BLOCKSLOS = 0x80;
                public const long OVERLAY_ATTACHMENTS_BIT = 0x100;
                public const long OVERLAY_NPC_ENEMIES_BIT = 0x400000;
                public const long OVERLAY_NPC_RELATION_BIT = 0x400000000;
                public const long OVERLAY_NPC_SELECTED_BIT = 0x20000;
                public const long OVERLAY_NPC_VIEWCONE_BIT = 0x8000000;
                public const long OVERLAY_NPC_BODYLOCATIONS = 0x4000000;
                public const long OVERLAY_NPC_TASK_TEXT_BIT = 0x100000000;
                public const long OVERLAY_NPC_CONDITIONS_BIT = 0x800000;
                public const long OVERLAY_TRIGGER_BOUNDS_BIT = 0x2000;
                public const long OVERLAY_NPC_PATH_QUERIES_BIT = 0x100000000000;
                public const long OVERLAY_VISIBILITY_TRACES_BIT = 0x100000;
                public const long OVERLAY_INTERPOLATED_PIVOT_BIT = 0x400;
                public const long OVERLAY_VCOLLIDE_WIREFRAME_BIT = 0x1000000000;
                public const long OVERLAY_INTERPOLATED_HITBOX_BIT = 0x8000;
                public const long OVERLAY_NPC_CONDITIONS_TEXT_BIT = 0x8000000000;
                public const long OVERLAY_NPC_STEERING_REGULATIONS = 0x80000000;
                public const long OVERLAY_INTERPOLATED_SKELETON_BIT = 0x1000;
                public const long OVERLAY_NPC_SCRIPTED_COMMANDS_BIT = 0x2000000000;
                public const long OVERLAY_NPC_ANIM_AI_HANDSHAKES_BIT = 0x80000000000;
                public const long OVERLAY_NPC_ABILITY_RANGE_DEBUG_BIT = 0x10000000000;
                public const long OVERLAY_INTERPOLATED_ATTACHMENTS_BIT = 0x200;
            }
            public static partial class ECsgoSteamUserStat {
                public const long k_ECsgoSteamUserStat_XpEarnedGames = 0x1;
                public const long k_ECsgoSteamUserStat_SurvivedDangerZone = 0x3;
                public const long k_ECsgoSteamUserStat_MatchWinsCompetitive = 0x2;
            }
            public static partial class FuncDoorSpawnPos_t {
                public const long FUNC_DOOR_SPAWN_OPEN = 0x1;
                public const long FUNC_DOOR_SPAWN_CLOSED = 0x0;
            }
            public static partial class GCConnectionStatus {
                public const long GCConnectionStatus_NO_STEAM = 0x4;
                public const long GCConnectionStatus_NO_SESSION = 0x2;
                public const long GCConnectionStatus_HAVE_SESSION = 0x0;
                public const long GCConnectionStatus_GC_GOING_DOWN = 0x1;
                public const long GCConnectionStatus_NO_SESSION_IN_LOGON_QUEUE = 0x3;
            }
            public static partial class PreviewWeaponState {
                public const long ICON = 0x5;
                public const long DROPPED = 0x0;
                public const long INSPECT = 0x4;
                public const long PLANTED = 0x3;
                public const long DEPLOYED = 0x2;
                public const long HOLSTERED = 0x1;
            }
            public static partial class ShatterDamageCause {
                public const long SHATTERDAMAGE_MELEE = 0x1;
                public const long SHATTERDAMAGE_BULLET = 0x0;
                public const long SHATTERDAMAGE_SCRIPT = 0x3;
                public const long SHATTERDAMAGE_THROWN = 0x2;
                public const long SHATTERDAMAGE_EXPLOSIVE = 0x4;
            }
            public static partial class WeaponAttackType_t {
                public const long eCount = 0x2;
                public const long eInvalid = -0x1;
                public const long ePrimary = 0x0;
                public const long eSecondary = 0x1;
            }
            public static partial class ChoreoLookAtSpeed_t {
                public const long eFast = 0x2;
                public const long eSlow = 0x0;
                public const long eMedium = 0x1;
                public const long eInvalid = -0x1;
            }
            public static partial class EBaseClientMessages {
                public const long CM_MAX_BASE = 0x12C;
                public const long CM_RotateAnchor = 0x11D;
                public const long CM_ClientUIEvent = 0x11A;
                public const long CM_CustomGameEvent = 0x118;
                public const long CM_CustomGameEventBounce = 0x119;
                public const long CM_DevPaletteVisibilityChanged = 0x11B;
                public const long CM_WorldUIControllerHasPanelChanged = 0x11C;
            }
            public static partial class EBaseEntityMessages {
                public const long EM_DoSpark = 0x8C;
                public const long EM_FixAngle = 0x8D;
                public const long EM_PlayJingle = 0x88;
                public const long EM_ScreenOverlay = 0x89;
                public const long EM_PropagateForce = 0x8B;
            }
            public static partial class ECSPredictionEvents {
                public const long CSPE_DamageTag = 0x1;
                public const long CSPE_PlayerTeleport = 0x3;
            }
            public static partial class ECommunityItemClass {
                public const long k_ECommunityItemClass_Badge = 0x1;
                public const long k_ECommunityItemClass_Scene = 0x9;
                public const long k_ECommunityItemClass_GameGoo = 0x7;
                public const long k_ECommunityItemClass_Invalid = 0x0;
                public const long k_ECommunityItemClass_Emoticon = 0x4;
                public const long k_ECommunityItemClass_GameCard = 0x2;
                public const long k_ECommunityItemClass_Consumable = 0x6;
                public const long k_ECommunityItemClass_SalienItem = 0xA;
                public const long k_ECommunityItemClass_BoosterPack = 0x5;
                public const long k_ECommunityItemClass_ProfileModifier = 0x8;
                public const long k_ECommunityItemClass_ProfileBackground = 0x3;
            }
            public static partial class EOverrideBlockLOS_t {
                public const long BLOCK_LOS_DEFAULT = 0x0;
                public const long BLOCK_LOS_FORCE_TRUE = 0x2;
                public const long BLOCK_LOS_FORCE_FALSE = 0x1;
            }
            public static partial class ForcedCrouchState_t {
                public const long FORCEDCROUCH_NONE = 0x0;
                public const long FORCEDCROUCH_CROUCHED = 0x1;
                public const long FORCEDCROUCH_UNCROUCHED = 0x2;
            }
            public static partial class PulseNPCCondition_t {
                public const long COND_SEE_PLAYER = 0x1;
                public const long COND_HEAR_PLAYER = 0x3;
                public const long COND_LOST_PLAYER = 0x2;
                public const long COND_PLAYER_PUSHING = 0x4;
                public const long COND_NO_PRIMARY_AMMO = 0x5;
            }
            public static partial class RadiusDmgOverride_t {
                public const long RADIUS_DMG_OVERRIDE_NONE = 0x0;
                public const long RADIUS_DMG_OVERRIDE_POSITION_ONLY = 0x1;
                public const long RADIUS_DMG_OVERRIDE_POSITION_SKIP_TRACES = 0x2;
            }
            public static partial class TrainVelocityType_t {
                public const long TrainVelocity_LinearBlend = 0x1;
                public const long TrainVelocity_EaseInEaseOut = 0x2;
                public const long TrainVelocity_Instantaneous = 0x0;
            }
            public static partial class AnimationAlgorithm_t {
                public const long eNone = 0x0;
                public const long eCount = 0x4;
                public const long eInvalid = -0x1;
                public const long eSequence = 0x1;
                public const long eAnimGraph2 = 0x2;
                public const long eAnimGraph2Secondary = 0x3;
            }
            public static partial class CSWeaponSilencerType {
                public const long WEAPONSILENCER_NONE = 0x0;
                public const long WEAPONSILENCER_DETACHABLE = 0x1;
                public const long WEAPONSILENCER_INTEGRATED = 0x2;
            }
            public static partial class EProtoDebugVisiblity {
                public const long k_EProtoDebugVisibility_GC = 0x5A;
                public const long k_EProtoDebugVisibility_Never = 0x64;
                public const long k_EProtoDebugVisibility_Always = 0x0;
                public const long k_EProtoDebugVisibility_Server = 0x46;
                public const long k_EProtoDebugVisibility_ValveServer = 0x50;
            }
            public static partial class EntityDissolveType_t {
                public const long ENTITY_DISSOLVE_CORE = 0x3;
                public const long ENTITY_DISSOLVE_NORMAL = 0x0;
                public const long ENTITY_DISSOLVE_INVALID = -0x1;
                public const long ENTITY_DISSOLVE_ELECTRICAL = 0x1;
                public const long ENTITY_DISSOLVE_ELECTRICAL_LIGHT = 0x2;
            }
            public static partial class EntityDistanceMode_t {
                public const long eAxisToAxis = 0x2;
                public const long eCenterToCenter = 0x1;
                public const long eOriginToOrigin = 0x0;
            }
            public static partial class GCClientLauncherType {
                public const long GCClientLauncherType_DEFAULT = 0x0;
                public const long GCClientLauncherType_SOURCE2 = 0x3;
                public const long GCClientLauncherType_STEAMCHINA = 0x2;
                public const long GCClientLauncherType_PERFECTWORLD = 0x1;
            }
            public static partial class GameAnimEventIndex_t {
                public const long AE_COUNT = 0x2F;
                public const long AE_EMPTY = 0x0;
                public const long AE_FOOTSTEP = 0xC;
                public const long AE_SV_IKLOCK = 0x16;
                public const long AE_FIRE_INPUT = 0x10;
                public const long AE_PULSE_GRAPH = 0x17;
                public const long AE_CL_EJECT_MAG = 0x2B;
                public const long AE_CL_PLAYSOUND = 0x1;
                public const long AE_CL_STOPSOUND = 0x5;
                public const long AE_SV_PLAYSOUND = 0x4;
                public const long AE_CL_CLOTH_ATTR = 0x11;
                public const long AE_CL_CLOTH_EFFECT = 0x14;
                public const long AE_CL_CLOTH_STIFFEN = 0x13;
                public const long AE_DISABLE_PLATFORM = 0x18;
                public const long AE_BODYGROUP_SET_VALUE = 0xE;
                public const long AE_WPN_COMPLETE_RELOAD = 0x2C;
                public const long AE_CL_PLAYSOUND_LOOPING = 0x6;
                public const long AE_SCRIPT_FIRE_EVENT_01 = 0x1E;
                public const long AE_SCRIPT_FIRE_EVENT_02 = 0x1F;
                public const long AE_SCRIPT_FIRE_EVENT_03 = 0x20;
                public const long AE_SCRIPT_FIRE_EVENT_04 = 0x21;
                public const long AE_SCRIPT_FIRE_EVENT_05 = 0x22;
                public const long AE_SCRIPT_FIRE_EVENT_06 = 0x23;
                public const long AE_SCRIPT_FIRE_EVENT_07 = 0x24;
                public const long AE_SCRIPT_FIRE_EVENT_08 = 0x25;
                public const long AE_SCRIPT_FIRE_EVENT_09 = 0x26;
                public const long AE_SCRIPT_FIRE_EVENT_10 = 0x27;
                public const long AE_CL_PLAYSOUND_POSITION = 0x3;
                public const long AE_VEHICLE_EXIT_FINISHED = 0x1D;
                public const long AE_WEAPON_PERFORM_ATTACK = 0xF;
                public const long AE_WPN_HEALTHSHOT_INJECT = 0x2D;
                public const long AE_CL_CLOTH_GROUND_OFFSET = 0x12;
                public const long AE_GRENADE_THROW_COMPLETE = 0x2E;
                public const long AE_VEHICLE_ENTER_FINISHED = 0x1C;
                public const long AE_CL_PLAYSOUND_ATTACHMENT = 0x2;
                public const long AE_CL_STOP_PARTICLE_EFFECT = 0x8;
                public const long AE_CL_STOP_RAGDOLL_CONTROL = 0xD;
                public const long AE_SV_STOP_PARTICLE_EFFECT = 0xB;
                public const long AE_CL_CREATE_ANIM_SCOPE_PROP = 0x15;
                public const long AE_CL_CREATE_PARTICLE_EFFECT = 0x7;
                public const long AE_DESTRUCTIBLE_PART_DESTROY = 0x1B;
                public const long AE_SV_ATTACH_SILENCER_COMPLETE = 0x29;
                public const long AE_SV_DETACH_SILENCER_COMPLETE = 0x2A;
                public const long AE_CL_CREATE_PARTICLE_EFFECT_CFG = 0x9;
                public const long AE_SV_CREATE_PARTICLE_EFFECT_CFG = 0xA;
                public const long AE_CL_WEAPON_TRANSITION_INTO_HAND = 0x28;
                public const long AE_ENABLE_PLATFORM_PLAYER_FOLLOWS_YAW = 0x19;
                public const long AE_ENABLE_PLATFORM_PLAYER_IGNORES_YAW = 0x1A;
            }
            public static partial class ModifyDamageReturn_t {
                public const long CONTINUE_TO_APPLY_DAMAGE = 0x0;
                public const long ABORT_DO_NOT_APPLY_DAMAGE = 0x1;
            }
            public static partial class MoveMountingAmount_t {
                public const long MOVE_MOUNT_LOW = 0x1;
                public const long MOVE_MOUNT_HIGH = 0x2;
                public const long MOVE_MOUNT_NONE = 0x0;
                public const long MOVE_MOUNT_MAXCOUNT = 0x3;
            }
            public static partial class NPCFollowFormation_t {
                public const long Default = -0x1;
                public const long Sidekick = 0x6;
                public const long WideCircle = 0x1;
                public const long CloseCircle = 0x0;
                public const long MediumCircle = 0x5;
            }
            public static partial class PlayerConnectedState {
                public const long Reserved = 0x5;
                public const long Connected = 0x0;
                public const long Connecting = 0x1;
                public const long Disconnected = 0x4;
                public const long Reconnecting = 0x2;
                public const long Disconnecting = 0x3;
                public const long NeverConnected = -0x1;
            }
            public static partial class PreviewCharacterMode {
                public const long BANNER = 0xA;
                public const long DIORAMA = 0x0;
                public const long INVALID = -0x1;
                public const long WALKING = 0x6;
                public const long BUY_MENU = 0x2;
                public const long MAIN_MENU = 0x1;
                public const long RUSH_INTRO = 0x9;
                public const long TEAM_INTRO = 0x7;
                public const long TEAM_SELECT = 0x3;
                public const long END_OF_MATCH = 0x4;
                public const long WINGMAN_INTRO = 0x8;
                public const long CHICK_SNAPSHOT = 0xB;
                public const long CHICK_VIEWMODEL = 0xC;
                public const long INVENTORY_INSPECT = 0x5;
            }
            public static partial class PulseTraceContents_t {
                public const long SOLID = 0x1;
                public const long STATIC_LEVEL = 0x0;
            }
            public static partial class SceneOnPlayerDeath_t {
                public const long SCENE_ONPLAYERDEATH_CANCEL = 0x1;
                public const long SCENE_ONPLAYERDEATH_DO_NOTHING = 0x0;
            }
            public static partial class WeaponSwitchReason_t {
                public const long eDrawn = 0x0;
                public const long eEquipped = 0x1;
                public const long eUserInitiatedUIKeyPress = 0x3;
                public const long eUserInitiatedSwitchHands = 0x4;
                public const long eUserInitiatedSwitchToLast = 0x2;
            }
            public static partial class vote_create_failed_t {
                public const long VOTE_FAILED_MAX = 0x22;
                public const long VOTE_FAILED_GENERIC = 0x0;
                public const long VOTE_FAILED_REMATCH = 0x20;
                public const long VOTE_FAILED_CONTINUE = 0x21;
                public const long VOTE_FAILED_DISABLED = 0x15;
                public const long VOTE_FAILED_SPECTATOR = 0xE;
                public const long VOTE_FAILED_MATCH_PAUSED = 0x18;
                public const long VOTE_FAILED_MAP_NOT_FOUND = 0x6;
                public const long VOTE_FAILED_NEXTLEVEL_SET = 0x16;
                public const long VOTE_FAILED_NOT_IN_WARMUP = 0x1A;
                public const long VOTE_FAILED_RATE_EXCEEDED = 0x2;
                public const long VOTE_FAILED_CANT_ROUND_END = 0x1F;
                public const long VOTE_FAILED_ISSUE_DISABLED = 0x5;
                public const long VOTE_FAILED_NOT_10_PLAYERS = 0x1B;
                public const long VOTE_FAILED_PLAYERNOTFOUND = 0xB;
                public const long VOTE_FAILED_QUORUM_FAILURE = 0x4;
                public const long VOTE_FAILED_TEAM_CANT_CALL = 0x9;
                public const long VOTE_FAILED_TIMEOUT_ACTIVE = 0x1C;
                public const long VOTE_FAILED_FAILED_RECENTLY = 0x8;
                public const long VOTE_FAILED_MATCH_NOT_PAUSED = 0x19;
                public const long VOTE_FAILED_SWAP_IN_PROGRESS = 0x14;
                public const long VOTE_FAILED_TIMEOUT_INACTIVE = 0x1D;
                public const long VOTE_FAILED_CANNOT_KICK_ADMIN = 0xC;
                public const long VOTE_FAILED_MAP_NAME_REQUIRED = 0x7;
                public const long VOTE_FAILED_TIMEOUT_EXHAUSTED = 0x1E;
                public const long VOTE_FAILED_WAITINGFORPLAYERS = 0xA;
                public const long VOTE_FAILED_FAILED_RECENT_KICK = 0xF;
                public const long VOTE_FAILED_YES_MUST_EXCEED_NO = 0x3;
                public const long VOTE_FAILED_TOO_EARLY_SURRENDER = 0x17;
                public const long VOTE_FAILED_SCRAMBLE_IN_PROGRESS = 0xD;
                public const long VOTE_FAILED_FAILED_RECENT_RESTART = 0x13;
                public const long VOTE_FAILED_TRANSITIONING_PLAYERS = 0x1;
                public const long VOTE_FAILED_FAILED_RECENT_CHANGEMAP = 0x10;
                public const long VOTE_FAILED_FAILED_RECENT_SWAPTEAMS = 0x11;
                public const long VOTE_FAILED_FAILED_RECENT_SCRAMBLETEAMS = 0x12;
            }
            public static partial class EBasePredictionEvents {
                public const long BPE_Teleport = 0x82;
                public const long BPE_Diagnostic = 0x4000;
                public const long BPE_StringCommand = 0x80;
            }
            public static partial class EQueryCvarValueStatus {
                public const long eQueryCvarValueStatus_NotACvar = 0x2;
                public const long eQueryCvarValueStatus_ValueIntact = 0x0;
                public const long eQueryCvarValueStatus_CvarNotFound = 0x1;
                public const long eQueryCvarValueStatus_CvarProtected = 0x3;
            }
            public static partial class EntityPlatformTypes_t {
                public const long ENTITY_NOT_PLATFORM = 0x0;
                public const long ENTITY_PLATFORM_PLAYER_FOLLOWS_YAW = 0x1;
                public const long ENTITY_PLATFORM_PLAYER_IGNORES_YAW = 0x2;
            }
            public static partial class EntitySubclassScope_t {
                public const long SUBCLASS_SCOPE_NONE = -0x1;
                public const long SUBCLASS_SCOPE_COUNT = 0x2;
                public const long SUBCLASS_SCOPE_PRECIPITATION = 0x0;
                public const long SUBCLASS_SCOPE_PLAYER_WEAPONS = 0x1;
            }
            public static partial class ObserverInterpState_t {
                public const long OBSERVER_INTERP_NONE = 0x0;
                public const long OBSERVER_INTERP_SETTLING = 0x3;
                public const long OBSERVER_INTERP_STARTING = 0x1;
                public const long OBSERVER_INTERP_TRAVELING = 0x2;
            }
            public static partial class PreviewEOMCelebration {
                public const long MASK_F = 0x6;
                public const long WALKUP = 0x0;
                public const long INVALID = -0x1;
                public const long STRETCH = 0x4;
                public const long SWAGGER = 0x2;
                public const long DROPDOWN = 0x3;
                public const long GUERILLA = 0x7;
                public const long PUNCHING = 0x1;
                public const long AVA_DEFEAT = 0xC;
                public const long GUERILLA02 = 0x8;
                public const long MAE_DEFEAT = 0xE;
                public const long SCUBA_MALE = 0xB;
                public const long GENDARMERIE = 0x9;
                public const long SWAT_FEMALE = 0x5;
                public const long VYPA_DEFEAT = 0x16;
                public const long SCUBA_FEMALE = 0xA;
                public const long DARRYL_DEFEAT = 0x13;
                public const long DOCTOR_DEFEAT = 0x14;
                public const long MUHLIK_DEFEAT = 0x15;
                public const long RICKSAW_DEFEAT = 0xF;
                public const long CRASSWATER_DEFEAT = 0x12;
                public const long SCUBA_MALE_DEFEAT = 0x11;
                public const long GENDARMERIE_DEFEAT = 0xD;
                public const long SCUBA_FEMALE_DEFEAT = 0x10;
            }
            public static partial class PulseCollisionGroup_t {
                public const long DEFAULT = 0x0;
            }
            public static partial class PulseMethodCallMode_t {
                public const long ASYNC_FIRE_AND_FORGET = 0x1;
                public const long SYNC_WAIT_FOR_COMPLETION = 0x0;
            }
            public static partial class QuestProgress__Reason {
                public const long QUEST_OK = 0x1;
                public const long QUEST_WARMUP = 0x3;
                public const long QUEST_NO_QUEST = 0x7;
                public const long QUEST_WRONG_MAP = 0x9;
                public const long QUEST_REASON_MAX = 0xC;
                public const long QUEST_WRONG_MODE = 0xA;
                public const long QUEST_PLAYER_IS_BOT = 0x8;
                public const long QUEST_NONINITIALIZED = 0x0;
                public const long QUEST_NO_ENTITLEMENT = 0x6;
                public const long QUEST_NONOFFICIAL_SERVER = 0x5;
                public const long QUEST_NOT_ENOUGH_PLAYERS = 0x2;
                public const long QUEST_NOT_CONNECTED_TO_STEAM = 0x4;
                public const long QUEST_NOT_SYNCED_WITH_SERVER = 0xB;
            }
            public static partial class SoundEventStartType_t {
                public const long SOUNDEVENT_START_WORLD = 0x1;
                public const long SOUNDEVENT_START_ENTITY = 0x2;
                public const long SOUNDEVENT_START_PLAYER = 0x0;
            }
            public static partial class TimelineCompression_t {
                public const long TIMELINE_COMPRESSION_SUM = 0x0;
                public const long TIMELINE_COMPRESSION_TOTAL = 0x4;
                public const long TIMELINE_COMPRESSION_AVERAGE = 0x2;
                public const long TIMELINE_COMPRESSION_AVERAGE_BLEND = 0x3;
                public const long TIMELINE_COMPRESSION_COUNT_PER_INTERVAL = 0x1;
            }
            public static partial class Bidirectional_Messages {
                public const long bi_PredictionEvent = 0x13;
                public const long bi_RebroadcastSource = 0x11;
                public const long bi_GameEvent_DEPRECATED = 0x12;
                public const long bi_RebroadcastGameEvent = 0x10;
            }
            public static partial class CFuncRotator__Rotate_t {
                public const long ROTATE_LOOP = 0x0;
                public const long ROTATE_OSCILLATE = 0x1;
                public const long ROTATE_STOP_AT_END = 0x2;
                public const long ROTATE_LOOK_AT_TARGET = 0x3;
                public const long ROTATE_LOOK_AT_TARGET_ONLY_YAW = 0x4;
                public const long ROTATE_LOOK_AT_TARGET_ONLY_PITCH = 0x5;
                public const long ROTATE_RETURN_TO_INITIAL_ORIENTATION = 0x6;
            }
            public static partial class ChoreoScriptedMoveTo_t {
                public const long eWait = 0x0;
                public const long eTeleport = 0x2;
                public const long eWaitFacing = 0x3;
                public const long eMoveWithGait = 0x1;
            }
            public static partial class ECstrike15UserMessages {
                public const long CS_UM_Fade = 0x139;
                public const long CS_UM_SSUI = 0x174;
                public const long CS_UM_Shake = 0x138;
                public const long CS_UM_Train = 0x12F;
                public const long CS_UM_Damage = 0x141;
                public const long CS_UM_Geiger = 0x12E;
                public const long CS_UM_HudMsg = 0x134;
                public const long CS_UM_Rumble = 0x13A;
                public const long CS_UM_BarTime = 0x163;
                public const long CS_UM_HudText = 0x130;
                public const long CS_UM_KillCam = 0x14A;
                public const long CS_UM_HintText = 0x143;
                public const long CS_UM_ItemDrop = 0x167;
                public const long CS_UM_RawAudio = 0x13E;
                public const long CS_UM_ResetHud = 0x135;
                public const long CS_UM_ShowMenu = 0x162;
                public const long CS_UM_VGUIMenu = 0x12D;
                public const long CS_UM_VotePass = 0x15B;
                public const long CS_UM_XRankGet = 0x154;
                public const long CS_UM_XRankUpd = 0x155;
                public const long CS_UM_XpUpdate = 0x16D;
                public const long CS_UM_DeepStats = 0x17D;
                public const long CS_UM_GameTitle = 0x136;
                public const long CS_UM_RadioText = 0x142;
                public const long CS_UM_ReportHit = 0x16C;
                public const long CS_UM_SendAudio = 0x13D;
                public const long CS_UM_ShootInfo = 0x17F;
                public const long CS_UM_VoiceMask = 0x13F;
                public const long CS_UM_VoteSetup = 0x15D;
                public const long CS_UM_VoteStart = 0x15A;
                public const long CS_UM_AmmoDenied = 0x164;
                public const long CS_UM_ClientInfo = 0x153;
                public const long CS_UM_ItemPickup = 0x161;
                public const long CS_UM_VoteFailed = 0x15C;
                public const long CS_UM_AdjustMoney = 0x147;
                public const long CS_UM_KeyHintText = 0x144;
                public const long CS_UM_WeaponSound = 0x171;
                public const long CS_UM_CloseCaption = 0x13B;
                public const long CS_UM_ReloadEffect = 0x146;
                public const long CS_UM_RequestState = 0x140;
                public const long CS_UM_CounterStrafe = 0x181;
                public const long CS_UM_QuestProgress = 0x16E;
                public const long CS_UM_SurvivalStats = 0x175;
                public const long CS_UM_WeaponMagDrop = 0x185;
                public const long CS_UM_CallVoteFailed = 0x159;
                public const long CS_UM_MarkAchievement = 0x165;
                public const long CS_UM_AchievementEvent = 0x14D;
                public const long CS_UM_CurrentRoundOdds = 0x17C;
                public const long CS_UM_CurrentTimescale = 0x14C;
                public const long CS_UM_CustomHudClicked = 0x186;
                public const long CS_UM_DamagePrediction = 0x182;
                public const long CS_UM_DesiredTimescale = 0x14B;
                public const long CS_UM_MatchStatsUpdate = 0x166;
                public const long CS_UM_ServerRankUpdate = 0x160;
                public const long CS_UM_DisconnectToLobby = 0x14F;
                public const long CS_UM_PlayerStatsUpdate = 0x150;
                public const long CS_UM_SendPlayerLoadout = 0x184;
                public const long CS_UM_StopSpectatorMode = 0x149;
                public const long CS_UM_CloseCaptionDirect = 0x13C;
                public const long CS_UM_DisconnectToLobby2 = 0x176;
                public const long CS_UM_MatchEndConditions = 0x14E;
                public const long CS_UM_RoundEndReportData = 0x17B;
                public const long CS_UM_SayText_CSGOLegacy = 0x131;
                public const long CS_UM_TextMsg_CSGOLegacy = 0x133;
                public const long CS_UM_SayText2_CSGOLegacy = 0x132;
                public const long CS_UM_SendPlayerItemDrops = 0x169;
                public const long CS_UM_SendPlayerItemFound = 0x16B;
                public const long CS_UM_ServerRankRevealAll = 0x15E;
                public const long CS_UM_RoundBackupFilenames = 0x16A;
                public const long CS_UM_ScoreLeaderboardData = 0x16F;
                public const long CS_UM_PostRoundDamageReport = 0x178;
                public const long CS_UM_UpdateScreenHealthBar = 0x172;
                public const long CS_UM_EntityOutlineHighlight = 0x173;
                public const long CS_UM_RecurringMissionSchema = 0x183;
                public const long CS_UM_EndOfMatchAllPlayersData = 0x177;
                public const long CS_UM_ProcessSpottedEntityUpdate = 0x145;
                public const long CS_UM_UpdateTeamMoney_CSGOLegacy = 0x148;
                public const long CS_UM_PlayerDecalDigitalSignature = 0x170;
                public const long CS_UM_SendLastKillerDamageToClient = 0x15F;
            }
            public static partial class EHudPanelClassStatus_t {
                public const long k_eHudPanelClassStatus_HasClass = 0x1;
                public const long k_eHudPanelClassStatus_Undefined = -0x1;
                public const long k_eHudPanelClassStatus_DoesNotHaveClass = 0x0;
            }
            public static partial class EntityAttachmentType_t {
                public const long eEyes = 0x2;
                public const long eCenter = 0x1;
                public const long eAbsOrigin = 0x0;
                public const long eAttachment = 0x3;
                public const long eLocalOffset = 0x4;
            }
            public static partial class LatchDirtyPermission_t {
                public const long LATCH_DIRTY_DISALLOW = 0x0;
                public const long LATCH_DIRTY_PREDICTION = 0x3;
                public const long LATCH_DIRTY_FRAMESIMULATE = 0x4;
                public const long LATCH_DIRTY_CLIENT_SIMULATED = 0x2;
                public const long LATCH_DIRTY_PARTICLE_SIMULATE = 0x5;
                public const long LATCH_DIRTY_SERVER_CONTROLLED = 0x1;
            }
            public static partial class RelativeLocationType_t {
                public const long WORLD_SPACE_POSITION = 0x0;
                public const long RELATIVE_TO_ENTITY_YAW_ONLY = 0x2;
                public const long RELATIVE_TO_ENTITY_IN_LOCAL_SPACE = 0x1;
                public const long RELATIVE_TO_ENTITY_IN_WORLD_SPACE = 0x3;
            }
            public static partial class ShatterGlassStressType {
                public const long SHATTERGLASS_BLUNT = 0x0;
                public const long SHATTERGLASS_PULSE = 0x2;
                public const long SHATTERGLASS_BALLISTIC = 0x1;
                public const long SHATTERGLASS_EXPLOSIVE = 0x3;
            }
            public static partial class TrackOrientationType_t {
                public const long TrackOrientation_Fixed = 0x0;
                public const long TrackOrientation_FacePath = 0x1;
                public const long TrackOrientation_FacePathAngles = 0x2;
            }
            public static partial class TrainOrientationType_t {
                public const long TrainOrientation_Fixed = 0x0;
                public const long TrainOrientation_LinearBlend = 0x2;
                public const long TrainOrientation_AtPathTracks = 0x1;
                public const long TrainOrientation_EaseInEaseOut = 0x3;
            }
            public static partial class BreakableContentsType_t {
                public const long BC_EMPTY = 0x1;
                public const long BC_DEFAULT = 0x0;
                public const long BC_PROP_GROUP_OVERRIDE = 0x2;
                public const long BC_PARTICLE_SYSTEM_OVERRIDE = 0x3;
            }
            public static partial class EClientReportingVersion {
                public const long k_EClientReportingVersion_OldVersion = 0x0;
                public const long k_EClientReportingVersion_BetaVersion = 0x1;
                public const long k_EClientReportingVersion_SupportsTrustedMode = 0x2;
            }
            public static partial class ECommunityItemAttribute {
                public const long k_ECommunityItemAttribute_Level = 0x2;
                public const long k_ECommunityItemAttribute_Invalid = 0x0;
                public const long k_ECommunityItemAttribute_CardBorder = 0x1;
                public const long k_ECommunityItemAttribute_ExpiryTime = 0x9;
                public const long k_ECommunityItemAttribute_IssueNumber = 0x3;
                public const long k_ECommunityItemAttribute_TradableTime = 0x4;
                public const long k_ECommunityItemAttribute_StorePackageID = 0x5;
                public const long k_ECommunityItemAttribute_CommunityItemType = 0x7;
                public const long k_ECommunityItemAttribute_CommunityItemAppID = 0x6;
                public const long k_ECommunityItemAttribute_ProfileModiferEnabled = 0x8;
            }
            public static partial class EGCBaseProtoObjectTypes {
                public const long k_EProtoObjectLobbyInvite = 0x3EA;
                public const long k_EProtoObjectPartyInvite = 0x3E9;
            }
            public static partial class ESplitScreenMessageType {
                public const long MSG_SPLITSCREEN_ADDUSER = 0x0;
                public const long MSG_SPLITSCREEN_REMOVEUSER = 0x1;
            }
            public static partial class MoveLinearAuthoredPos_t {
                public const long MOVELINEAR_AUTHORED_AT_OPEN_POSITION = 0x1;
                public const long MOVELINEAR_AUTHORED_AT_START_POSITION = 0x0;
                public const long MOVELINEAR_AUTHORED_AT_CLOSED_POSITION = 0x2;
            }
            public static partial class NavAttributeDynamicType {
                public const long NAV_AREA_DOCK = 0x4000;
                public const long NAV_AREA_NONE = 0x0;
                public const long NAV_AREA_MOVABLE = 0x2000;
                public const long NAV_AREA_BOUNDARY = 0x10000;
                public const long NAV_AREA_NAV_LINK = 0x200;
                public const long NAV_AREA_DEFORMABLE = 0x40000;
                public const long NAV_AREA_HAS_LADDERS = 0x100;
                public const long NAV_AREA_UNDER_WATER = 0x1;
                public const long NAV_AREA_DEFORMABLE_DOCK = 0x80000;
                public const long NAV_AREA_LINK_AUTO_ADJUST = 0x100000;
                public const long NAV_AREA_UNDER_WATER_DEEP = 0x2;
                public const long NAV_AREA_DOCKING_CANDIDATE = 0x8000;
                public const long NAV_AREA_NAV_LINK_TERMINUS = 0x400;
                public const long NAV_AREA_EXTERNALLY_CREATED = 0x4;
                public const long NAV_AREA_SHOULD_BE_DESTROYED = 0x8;
                public const long NAV_AREA_SPLIT_OBS_CONTAINED = 0x40;
                public const long NAV_AREA_SPLIT_BY_OBSTACLE_MGR = 0x20;
                public const long NAV_AREA_CREATED_BY_OBSTACLE_MGR = 0x10;
                public const long NAV_AREA_CONNECTED_TO_NAV_LINK_IN = 0x1000;
                public const long NAV_AREA_SPLIT_OBS_BASE_CONTAINED = 0x80;
                public const long NAV_AREA_CONNECTED_TO_NAV_LINK_OUT = 0x800;
                public const long NAV_AREA_HAS_TACTICAL_SEARCH_ANNOTATIONS = 0x20000;
            }
            public static partial class PointOrientConstraint_t {
                public const long eNone = 0x0;
                public const long ePreserveUpAxis = 0x1;
            }
            public static partial class PulseBestOutflowRules_t {
                public const long SORT_BY_OUTFLOW_INDEX = 0x1;
                public const long SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0;
            }
            public static partial class SaveRestoreTableFlags_t {
                public const long FENTTABLE_NONE = 0x0;
                public const long LEVELMASK_BIT_0 = 0x1;
                public const long LEVELMASK_BIT_1 = 0x2;
                public const long LEVELMASK_BIT_2 = 0x4;
                public const long LEVELMASK_BIT_3 = 0x8;
                public const long LEVELMASK_BIT_4 = 0x10;
                public const long LEVELMASK_BIT_5 = 0x20;
                public const long LEVELMASK_BIT_6 = 0x40;
                public const long LEVELMASK_BIT_7 = 0x80;
                public const long LEVELMASK_BIT_8 = 0x100;
                public const long LEVELMASK_BIT_9 = 0x200;
                public const long FENTTABLE_GLOBAL = 0x10000000;
                public const long FENTTABLE_PLAYER = 0x80000000;
                public const long LEVELMASK_BIT_10 = 0x400;
                public const long LEVELMASK_BIT_11 = 0x800;
                public const long LEVELMASK_BIT_12 = 0x1000;
                public const long LEVELMASK_BIT_13 = 0x2000;
                public const long LEVELMASK_BIT_14 = 0x4000;
                public const long LEVELMASK_BIT_15 = 0x8000;
                public const long FENTTABLE_REMOVED = 0x40000000;
                public const long FENTTABLE_MOVEABLE = 0x20000000;
                public const long FENTTABLE_PLAYERCHILD = 0x8000000;
            }
            public static partial class SurroundingBoundsType_t {
                public const long USE_HITBOXES = 0x2;
                public const long USE_GAME_CODE = 0x4;
                public const long USE_SPECIFIED_BOUNDS = 0x3;
                public const long USE_OBB_COLLISION_BOUNDS = 0x0;
                public const long USE_BEST_COLLISION_BOUNDS = 0x1;
                public const long SURROUNDING_TYPE_BIT_COUNT = 0x3;
                public const long USE_ROTATION_EXPANDED_BOUNDS = 0x5;
                public const long USE_COLLISION_BOUNDS_NEVER_VPHYSICS = 0x7;
                public const long USE_ROTATION_EXPANDED_ORIENTED_BOUNDS = 0x6;
                public const long USE_ROTATION_EXPANDED_SEQUENCE_BOUNDS = 0x8;
            }
            public static partial class WeaponGameplayAnimState {
                public const long WPN_ANIMSTATE_IDLE = 0x32;
                public const long WPN_ANIMSTATE_CHARGE = 0x67;
                public const long WPN_ANIMSTATE_DEPLOY = 0xB;
                public const long WPN_ANIMSTATE_RELOAD = 0x320;
                public const long WPN_ANIMSTATE_DROPPED = 0x1;
                public const long WPN_ANIMSTATE_INSPECT = 0x3E8;
                public const long WPN_ANIMSTATE_C4_PLANT = 0x12C;
                public const long WPN_ANIMSTATE_END_VALID = 0x7D0;
                public const long WPN_ANIMSTATE_HOLSTERED = 0xA;
                public const long WPN_ANIMSTATE_RELOAD_OUTRO = 0x321;
                public const long WPN_ANIMSTATE_GRENADE_READY = 0xC9;
                public const long WPN_ANIMSTATE_GRENADE_THROW = 0xCA;
                public const long WPN_ANIMSTATE_INSPECT_OUTRO = 0x3E9;
                public const long WPN_ANIMSTATE_SHOOT_DRYFIRE = 0x66;
                public const long WPN_ANIMSTATE_SHOOT_PRIMARY = 0x64;
                public const long WPN_ANIMSTATE_UNINITIALIZED = 0x0;
                public const long WPN_ANIMSTATE_SILENCER_APPLY = 0x258;
                public const long WPN_ANIMSTATE_SHOOT_SECONDARY = 0x65;
                public const long WPN_ANIMSTATE_SILENCER_REMOVE = 0x259;
                public const long WPN_ANIMSTATE_GRENADE_PULL_PIN = 0xC8;
                public const long WPN_ANIMSTATE_HEALTHSHOT_INJECT = 0x190;
                public const long WPN_ANIMSTATE_KNIFE_PRIMARY_HIT = 0x1F4;
                public const long WPN_ANIMSTATE_KNIFE_PRIMARY_MISS = 0x1F5;
                public const long WPN_ANIMSTATE_KNIFE_PRIMARY_STAB = 0x1F8;
                public const long WPN_ANIMSTATE_INVENTORY_UI_TUMBLE = 0x5DC;
                public const long WPN_ANIMSTATE_KNIFE_SECONDARY_HIT = 0x1F6;
                public const long WPN_ANIMSTATE_KNIFE_SECONDARY_MISS = 0x1F7;
                public const long WPN_ANIMSTATE_KNIFE_SECONDARY_STAB = 0x1F9;
                public const long WPN_ANIMSTATE_INVENTORY_UI_KEYCHAIN_APPLY = 0x5DD;
            }
            public static partial class AnimGraphDebugDrawType_t {
                public const long _None = 0x0;
                public const long MsPosition = 0x2;
                public const long WsPosition = 0x1;
                public const long MsDirection = 0x4;
                public const long WsDirection = 0x3;
            }
            public static partial class ChoreoLookAtConditions_t {
                public const long DURING_OUTRO = 0x4;
                public const long WHILE_MOVING = 0x1;
                public const long WHILE_ANIMATING = 0x2;
            }
            public static partial class EContributionScoreFlag_t {
                public const long k_EContributionScoreFlag_Bullets = 0x2;
                public const long k_EContributionScoreFlag_Default = 0x0;
                public const long k_EContributionScoreFlag_Objective = 0x1;
            }
            public static partial class ValueRemapperInputType_t {
                public const long InputType_PlayerShootPosition = 0x0;
                public const long InputType_PlayerShootPositionAroundAxis = 0x1;
            }
            public static partial class attributeprovidertypes_t {
                public const long PROVIDER_WEAPON = 0x1;
                public const long PROVIDER_GENERIC = 0x0;
            }
            public static partial class CDebugOverlayFilterType_t {
                public const long NONE = 0x0;
                public const long TEXT = 0x1;
                public const long COUNT = 0x3;
                public const long ENTITY = 0x2;
                public const long AI_TASK = 0x6;
                public const long AI_EVENT = 0x7;
                public const long COMBINED = -0x1;
                public const long AI_SCHEDULE = 0x5;
                public const long AI_PATHFINDING = 0x8;
                public const long TACTICAL_SEARCH = 0x4;
                public const long END_SIM_HISTORY_TYPES = 0x9;
            }
            public static partial class CPhysicsProp__CrateType_t {
                public const long CRATE_TYPE_COUNT = 0x1;
                public const long CRATE_SPECIFIC_ITEM = 0x0;
            }
            public static partial class PulseCursorWakePriority_t {
                public const long WakeElegantly = 0x0;
                public const long WakeImmediate = 0x1;
            }
            public static partial class SVC_Messages_LowFrequency {
                public const long svc_dummy = 0x258;
            }
            public static partial class SubclassVDataChangeType_t {
                public const long SUBCLASS_VDATA_CREATED = 0x0;
                public const long SUBCLASS_VDATA_RELOADED = 0x2;
                public const long SUBCLASS_VDATA_SUBCLASS_CHANGED = 0x1;
            }
            public static partial class ValueRemapperOutputType_t {
                public const long OutputType_RotationX = 0x1;
                public const long OutputType_RotationY = 0x2;
                public const long OutputType_RotationZ = 0x3;
                public const long OutputType_AnimationCycle = 0x0;
            }
            public static partial class DirectionAlongSimplePath_t {
                public const long _None = 0x0;
                public const long TGoesUp = 0x1;
                public const long TGoesDown = 0x2;
            }
            public static partial class ESource2PlayStatsFieldType {
                public const long Source2PlayStats_Bool = 0xB;
                public const long Source2PlayStats_Int8 = 0x8;
                public const long Source2PlayStats_Int16 = 0x7;
                public const long Source2PlayStats_Int32 = 0x6;
                public const long Source2PlayStats_Int64 = 0x5;
                public const long Source2PlayStats_UInt8 = 0x4;
                public const long Source2PlayStats_String = 0xC;
                public const long Source2PlayStats_UInt16 = 0x3;
                public const long Source2PlayStats_UInt32 = 0x2;
                public const long Source2PlayStats_UInt64 = 0x1;
                public const long Source2PlayStats_Float32 = 0xA;
                public const long Source2PlayStats_Float64 = 0x9;
                public const long Source2PlayStats_Invalid = 0x0;
                public const long Source2PlayStats_SteamID = 0x11;
                public const long Source2PlayStats_UTCDateTime = 0xE;
                public const long Source2PlayStats_SteamIDTrustBucket = 0xF;
                public const long Source2PlayStats_LowCardinalityString = 0xD;
                public const long Source2PlayStats_SteamIDTrustBucketMin = 0x10;
            }
            public static partial class PropDoorRotatingSpawnPos_t {
                public const long DOOR_SPAWN_AJAR = 0x3;
                public const long DOOR_SPAWN_CLOSED = 0x0;
                public const long DOOR_SPAWN_OPEN_BACK = 0x2;
                public const long DOOR_SPAWN_OPEN_FORWARD = 0x1;
            }
            public static partial class ScriptedConflictResponse_t {
                public const long SS_CONFLICT_ENQUEUE = 0x0;
                public const long SS_CONFLICT_INTERRUPT = 0x1;
            }
            public static partial class ValueRemapperHapticsType_t {
                public const long HaticsType_None = 0x1;
                public const long HaticsType_Default = 0x0;
            }
            public static partial class ValueRemapperRatchetType_t {
                public const long RatchetType_Absolute = 0x0;
                public const long RatchetType_EachEngage = 0x1;
            }
            public static partial class CSPlayerBlockingUseAction_t {
                public const long k_CSPlayerBlockingUseAction_None = 0x0;
                public const long k_CSPlayerBlockingUseAction_MaxCount = 0x7;
                public const long k_CSPlayerBlockingUseAction_DefusingDefault = 0x1;
                public const long k_CSPlayerBlockingUseAction_DefusingWithKit = 0x2;
                public const long k_CSPlayerBlockingUseAction_HostageDropping = 0x4;
                public const long k_CSPlayerBlockingUseAction_HostageGrabbing = 0x3;
                public const long k_CSPlayerBlockingUseAction_MapLongUseEntity_Place = 0x6;
                public const long k_CSPlayerBlockingUseAction_MapLongUseEntity_Pickup = 0x5;
            }
            public static partial class ENetworkDisconnectionReason {
                public const long NETWORK_DISCONNECT_LOST = 0x4;
                public const long NETWORK_DISCONNECT_KICKED = 0x27;
                public const long NETWORK_DISCONNECT_EXITING = 0x3B;
                public const long NETWORK_DISCONNECT_INVALID = 0x0;
                public const long NETWORK_DISCONNECT_UNUSUAL = 0x54;
                public const long NETWORK_DISCONNECT_USERCMD = 0x2D;
                public const long NETWORK_DISCONNECT_BANADDED = 0x28;
                public const long NETWORK_DISCONNECT_HLTVSTOP = 0x26;
                public const long NETWORK_DISCONNECT_OVERFLOW = 0x5;
                public const long NETWORK_DISCONNECT_SHUTDOWN = 0x1;
                public const long NETWORK_DISCONNECT_TIMEDOUT = 0x1D;
                public const long NETWORK_DISCONNECT_HLTVDIRECT = 0x2A;
                public const long NETWORK_DISCONNECT_KICKED_IDLE = 0x9E;
                public const long NETWORK_DISCONNECT_STEAM_INUSE = 0x7;
                public const long NETWORK_DISCONNECT_STEAM_LOGON = 0x9;
                public const long NETWORK_DISCONNECT_BADDELTATICK = 0x1B;
                public const long NETWORK_DISCONNECT_DISCONNECTED = 0x1E;
                public const long NETWORK_DISCONNECT_HOST_ENDGAME = 0x38;
                public const long NETWORK_DISCONNECT_KICKBANADDED = 0x29;
                public const long NETWORK_DISCONNECT_LEAVINGSPLIT = 0x1F;
                public const long NETWORK_DISCONNECT_LOOPSHUTDOWN = 0x36;
                public const long NETWORK_DISCONNECT_NOMORESPLITS = 0x1C;
                public const long NETWORK_DISCONNECT_NOSPECTATORS = 0x24;
                public const long NETWORK_DISCONNECT_RECONNECTION = 0x35;
                public const long NETWORK_DISCONNECT_REJECT_STEAM = 0x92;
                public const long NETWORK_DISCONNECT_REMOTE_OTHER = 0x51;
                public const long NETWORK_DISCONNECT_STEAM_BANNED = 0x6;
                public const long NETWORK_DISCONNECT_STEAM_TICKET = 0x8;
                public const long NETWORK_DISCONNECT_CLIENT_NO_MAP = 0x40;
                public const long NETWORK_DISCONNECT_REJECT_BANNED = 0x95;
                public const long NETWORK_DISCONNECT_SNAPSHOTERROR = 0x19;
                public const long NETWORK_DISCONNECT_STEAM_DROPPED = 0x10;
                public const long NETWORK_DISCONNECT_HLTVRESTRICTED = 0x23;
                public const long NETWORK_DISCONNECT_INTERNAL_ERROR = 0x55;
                public const long NETWORK_DISCONNECT_KICKED_SUICIDE = 0x9F;
                public const long NETWORK_DISCONNECT_LOOPDEACTIVATE = 0x37;
                public const long NETWORK_DISCONNECT_REJECT_NOLOBBY = 0x81;
                public const long NETWORK_DISCONNECT_REMOTE_TIMEOUT = 0x4F;
                public const long NETWORK_DISCONNECT_HLTVUNAVAILABLE = 0x25;
                public const long NETWORK_DISCONNECT_KICKED_TK_START = 0x97;
                public const long NETWORK_DISCONNECT_KICKED_VOTEDOFF = 0x9D;
                public const long NETWORK_DISCONNECT_REMOTE_BADCRYPT = 0x52;
                public const long NETWORK_DISCONNECT_SERVER_SHUTDOWN = 0x45;
                public const long NETWORK_DISCONNECT_STEAM_DENY_MISC = 0x43;
                public const long NETWORK_DISCONNECT_STEAM_OWNERSHIP = 0x11;
                public const long NETWORK_DISCONNECT_BADRELAYPASSWORD = 0x21;
                public const long NETWORK_DISCONNECT_REJECTED_BY_GAME = 0x2E;
                public const long NETWORK_DISCONNECT_RELIABLEOVERFLOW = 0x1A;
                public const long NETWORK_DISCONNECT_SNAPSHOTOVERFLOW = 0x18;
                public const long NETWORK_DISCONNECT_TICKMSG_OVERFLOW = 0x13;
                public const long NETWORK_DISCONNECT_REJECT_SERVERFULL = 0x87;
                public const long NETWORK_DISCONNECT_STEAM_AUTHINVALID = 0xC;
                public const long NETWORK_DISCONNECT_STEAM_VACBANSTATE = 0xD;
                public const long NETWORK_DISCONNECT_CONNECTION_FAILURE = 0x33;
                public const long NETWORK_DISCONNECT_DISCONNECT_BY_USER = 0x2;
                public const long NETWORK_DISCONNECT_KICKED_TEAMHURTING = 0x9B;
                public const long NETWORK_DISCONNECT_KICKED_TEAMKILLING = 0x96;
                public const long NETWORK_DISCONNECT_LOCALPROBLEM_OTHER = 0x4D;
                public const long NETWORK_DISCONNECT_REJECT_BADPASSWORD = 0x86;
                public const long NETWORK_DISCONNECT_REJECT_HIDDEN_GAME = 0x84;
                public const long NETWORK_DISCONNECT_REJECT_LANRESTRICT = 0x85;
                public const long NETWORK_DISCONNECT_REJECT_NEWPROTOCOL = 0x8E;
                public const long NETWORK_DISCONNECT_REJECT_OLDPROTOCOL = 0x8D;
                public const long NETWORK_DISCONNECT_SOUNDSMSG_OVERFLOW = 0x17;
                public const long NETWORK_DISCONNECT_BAD_SERVER_PASSWORD = 0x31;
                public const long NETWORK_DISCONNECT_KICKED_NOSTEAMLOGIN = 0xA0;
                public const long NETWORK_DISCONNECT_MESSAGE_PARSE_ERROR = 0x2F;
                public const long NETWORK_DISCONNECT_PURESERVER_MISMATCH = 0x2C;
                public const long NETWORK_DISCONNECT_REJECT_BADCHALLENGE = 0x80;
                public const long NETWORK_DISCONNECT_REPLAY_INCOMPATIBLE = 0x47;
                public const long NETWORK_DISCONNECT_SERVERINFO_OVERFLOW = 0x12;
                public const long NETWORK_DISCONNECT_SERVER_INCOMPATIBLE = 0x49;
                public const long NETWORK_DISCONNECT_STEAM_AUTHCANCELLED = 0xA;
                public const long NETWORK_DISCONNECT_TEMPENTMSG_OVERFLOW = 0x16;
                public const long NETWORK_DISCONNECT_BADSPECTATORPASSWORD = 0x22;
                public const long NETWORK_DISCONNECT_CLIENT_DIFFERENT_MAP = 0x41;
                public const long NETWORK_DISCONNECT_CREATE_SERVER_FAILED = 0x3A;
                public const long NETWORK_DISCONNECT_DELTAENTMSG_OVERFLOW = 0x15;
                public const long NETWORK_DISCONNECT_DIFFERENTCLASSTABLES = 0x20;
                public const long NETWORK_DISCONNECT_DISCONNECT_BY_SERVER = 0x3;
                public const long NETWORK_DISCONNECT_KICKED_NOSTEAMTICKET = 0xA1;
                public const long NETWORK_DISCONNECT_REJECT_FAILEDCHANNEL = 0x89;
                public const long NETWORK_DISCONNECT_REJECT_SINGLE_PLAYER = 0x83;
                public const long NETWORK_DISCONNECT_INVALID_MESSAGE_ERROR = 0x30;
                public const long NETWORK_DISCONNECT_KICKED_HOSTAGEKILLING = 0x9C;
                public const long NETWORK_DISCONNECT_KICKED_INSECURECLIENT = 0xA4;
                public const long NETWORK_DISCONNECT_REJECT_BACKGROUND_MAP = 0x82;
                public const long NETWORK_DISCONNECT_REJECT_INVALIDCERTLEN = 0x90;
                public const long NETWORK_DISCONNECT_REMOTE_CERTNOTTRUSTED = 0x53;
                public const long NETWORK_DISCONNECT_SERVER_REQUIRES_STEAM = 0x42;
                public const long NETWORK_DISCONNECT_STEAM_AUTHALREADYUSED = 0xB;
                public const long NETWORK_DISCONNECT_KICKED_INPUTAUTOMATION = 0xA2;
                public const long NETWORK_DISCONNECT_NO_PEER_GROUP_HANDLERS = 0x34;
                public const long NETWORK_DISCONNECT_PURESERVER_CLIENTEXTRA = 0x2B;
                public const long NETWORK_DISCONNECT_REQUEST_HOSTSTATE_IDLE = 0x3C;
                public const long NETWORK_DISCONNECT_CLIENT_CONSISTENCY_FAIL = 0x3E;
                public const long NETWORK_DISCONNECT_KICKED_CONVICTEDACCOUNT = 0x99;
                public const long NETWORK_DISCONNECT_KICKED_UNTRUSTEDACCOUNT = 0x98;
                public const long NETWORK_DISCONNECT_LOCALPROBLEM_MANYRELAYS = 0x4A;
                public const long NETWORK_DISCONNECT_LOOP_LEVELLOAD_ACTIVATE = 0x39;
                public const long NETWORK_DISCONNECT_REJECT_INVALIDKEYLENGTH = 0x8C;
                public const long NETWORK_DISCONNECT_STRINGTABLEMSG_OVERFLOW = 0x14;
                public const long NETWORK_DISCONNECT_CLIENT_UNABLE_TO_CRC_MAP = 0x3F;
                public const long NETWORK_DISCONNECT_CONNECT_REQUEST_TIMEDOUT = 0x48;
                public const long NETWORK_DISCONNECT_REJECT_INVALIDCONNECTION = 0x8F;
                public const long NETWORK_DISCONNECT_STEAM_VAC_CHECK_TIMEDOUT = 0xF;
                public const long NETWORK_DISCONNECT_REJECT_CONNECT_FROM_LOBBY = 0x8A;
                public const long NETWORK_DISCONNECT_REJECT_INVALIDRESERVATION = 0x88;
                public const long NETWORK_DISCONNECT_REJECT_RESERVED_FOR_LOBBY = 0x8B;
                public const long NETWORK_DISCONNECT_REJECT_SERVERAUTHDISABLED = 0x93;
                public const long NETWORK_DISCONNECT_REMOTE_TIMEOUT_CONNECTING = 0x50;
                public const long NETWORK_DISCONNECT_STEAM_DENY_BAD_ANTI_CHEAT = 0x44;
                public const long NETWORK_DISCONNECT_STEAM_LOGGED_IN_ELSEWHERE = 0xE;
                public const long NETWORK_DISCONNECT_DIRECT_CONNECT_RESERVATION = 0x32;
                public const long NETWORK_DISCONNECT_KICKED_COMPETITIVECOOLDOWN = 0x9A;
                public const long NETWORK_DISCONNECT_LOCALPROBLEM_NETWORKCONFIG = 0x4C;
                public const long NETWORK_DISCONNECT_REJECT_INVALIDSTEAMCERTLEN = 0x91;
                public const long NETWORK_DISCONNECT_REQUEST_HOSTSTATE_HLTVRELAY = 0x3D;
                public const long NETWORK_DISCONNECT_KICKED_VACNETABNORMALBEHAVIOR = 0xA3;
                public const long NETWORK_DISCONNECT_REJECT_SERVERCDKEYAUTHINVALID = 0x94;
                public const long NETWORK_DISCONNECT_LOCALPROBLEM_HOSTEDSERVERPRIMARYRELAY = 0x4B;
            }
            public static partial class PulseCursorCancelPriority_t {
                public const long _None = 0x0;
                public const long HardCancel = 0x3;
                public const long SoftCancel = 0x2;
                public const long CancelOnSucceeded = 0x1;
            }
            public static partial class SequenceFinishNotifyState_t {
                public const long eDoNotNotify = 0x0;
                public const long eNotifyTriggered = 0x2;
                public const long eNotifyWhenFinished = 0x1;
            }
            public static partial class ValueRemapperMomentumType_t {
                public const long MomentumType_None = 0x0;
                public const long MomentumType_Friction = 0x1;
                public const long MomentumType_SpringTowardSnapValue = 0x2;
                public const long MomentumType_SpringAwayFromSnapValue = 0x3;
            }
            public static partial class WorldTextPanelOrientation_t {
                public const long WORLDTEXT_ORIENTATION_DEFAULT = 0x0;
                public const long WORLDTEXT_ORIENTATION_FACEUSER = 0x1;
                public const long WORLDTEXT_ORIENTATION_FACEUSER_UPRIGHT = 0x2;
            }
            public static partial class CDebugOverlayCombinedTypes_t {
                public const long ALL = 0x0;
                public const long ANY = 0x1;
                public const long COUNT = 0x2;
            }
            public static partial class CFuncRotator__RotationAxis_t {
                public const long ROTATION_AXIS_YAW = 0x1;
                public const long ROTATION_AXIS_ROLL = 0x3;
                public const long ROTATION_AXIS_PITCH = 0x2;
                public const long ROTATION_AXIS_UNDEFINED = 0x0;
            }
            public static partial class CRR_Response__ResponseEnum_t {
                public const long MAX_RULE_NAME = 0x80;
                public const long MAX_RESPONSE_NAME = 0xC0;
            }
            public static partial class LessonPanelLayoutFileTypes_t {
                public const long LAYOUT_CUSTOM = 0x2;
                public const long LAYOUT_HAND_DEFAULT = 0x0;
                public const long LAYOUT_WORLD_DEFAULT = 0x1;
            }
            public static partial class PointWorldTextReorientMode_t {
                public const long POINT_WORLD_TEXT_REORIENT_NONE = 0x0;
                public const long POINT_WORLD_TEXT_REORIENT_AROUND_UP = 0x1;
            }
            public static partial class CDebugOverlayFilterTextType_t {
                public const long COUNT = 0x3;
                public const long MATCH = 0x1;
                public const long HIERARCHY = 0x2;
                public const long FILTER_TEXT_NONE = 0x0;
            }
            public static partial class CInfoChoreoLocatorShapeType_t {
                public const long LINE = 0x1;
                public const long NONE = 0x4;
                public const long COUNT = 0x3;
                public const long POINT = 0x0;
                public const long RADIUS = 0x2;
            }
            public static partial class ShatterGlassEntityPoolState_t {
                public const long ENTITY_POOL_STATE_IN_USE = 0x2;
                public const long ENTITY_POOL_STATE_INVALID = 0x0;
                public const long ENTITY_POOL_STATE_AVAILABLE = 0x1;
            }
            public static partial class WorldTextPanelVerticalAlign_t {
                public const long WORLDTEXT_VERTICAL_ALIGN_TOP = 0x0;
                public const long WORLDTEXT_VERTICAL_ALIGN_BOTTOM = 0x2;
                public const long WORLDTEXT_VERTICAL_ALIGN_CENTER = 0x1;
            }
            public static partial class CFuncMover__FollowConstraint_t {
                public const long FOLLOW_CONSTRAINT_RATIO = 0x2;
                public const long FOLLOW_CONSTRAINT_SPRING = 0x1;
                public const long FOLLOW_CONSTRAINT_COUPLER = 0x3;
                public const long FOLLOW_CONSTRAINT_DISTANCE = 0x0;
            }
            public static partial class IChoreoServices__ChoreoState_t {
                public const long STATE_PRE_SCRIPT = 0x0;
                public const long STATE_PLAY_SCRIPT = 0x4;
                public const long STATE_WALK_TO_MARK = 0x2;
                public const long STATE_WAIT_FOR_SCRIPT = 0x1;
                public const long STATE_SYNCHRONIZE_SCRIPT = 0x3;
                public const long STATE_PLAY_SCRIPT_POST_IDLE = 0x5;
                public const long STATE_PLAY_SCRIPT_POST_IDLE_DONE = 0x6;
            }
            public static partial class IChoreoServices__ScriptState_t {
                public const long SCRIPT_WAIT = 0x1;
                public const long SCRIPT_CLEANUP = 0x3;
                public const long SCRIPT_PLAYING = 0x0;
                public const long SCRIPT_POST_IDLE = 0x2;
                public const long SCRIPT_MOVE_TO_MARK = 0x4;
            }
            public static partial class PointOrientGoalDirectionType_t {
                public const long eHead = 0x2;
                public const long eCenter = 0x1;
                public const long eForward = 0x3;
                public const long eAbsOrigin = 0x0;
                public const long eEyesForward = 0x4;
            }
            public static partial class BeginDeathLifeStateTransition_t {
                public const long TRANSITION_TO_LIFESTATE_DEAD = 0x1;
                public const long TRANSITION_TO_LIFESTATE_DYING = 0x0;
            }
            public static partial class CFuncMover__OrientationUpdate_t {
                public const long ORIENTATION_FIXED = 0x4;
                public const long ORIENTATION_FACE_ENTITY = 0x8;
                public const long ORIENTATION_FACE_PLAYER = 0x5;
                public const long ORIENTATION_FORWARD_PATH = 0x0;
                public const long ORIENTATION_MATCH_CONTROL_POINT = 0x3;
                public const long ORIENTATION_FORWARD_MOVEMENT_DIRECTION = 0x6;
                public const long ORIENTATION_FORWARD_PATH_AND_FIXED_PITCH = 0x1;
                public const long ORIENTATION_FORWARD_PATH_AND_UP_CONTROL_POINT = 0x2;
                public const long ORIENTATION_FORWARD_MOVEMENT_DIRECTION_AND_UP_CONTROL_POINT = 0x7;
            }
            public static partial class FuncMoverMovementSummaryFlags_t {
                public const long eNone = 0x0;
                public const long eLoopToEnd = 0x40;
                public const long eReversing = 0x8;
                public const long eStopBegin = 0x2;
                public const long eLoopToStart = 0x20;
                public const long eStopComplete = 0x4;
                public const long eMovementBegin = 0x1;
                public const long eEventsDispatched = 0x10;
                public const long eTransitionComplete = 0x80;
                public const long eStoppedDuringTransition = 0x100;
            }
            public static partial class INavObstacle__NavObstacleType_t {
                public const long NAV_OBSTACLE_TYPE_CONN = 0x2;
                public const long NAV_OBSTACLE_TYPE_NONE = 0x0;
                public const long NAV_OBSTACLE_TYPE_AVOID = 0x1;
                public const long NAV_OBSTACLE_TYPE_BLOCK = 0x3;
                public const long NAV_OBSTACLE_TYPE_INVALID = -0x1;
                public const long NAV_OBSTACLE_TYPE_PERMANENT_BLOCK = 0x4;
            }
            public static partial class PointWorldTextJustifyVertical_t {
                public const long POINT_WORLD_TEXT_JUSTIFY_VERTICAL_TOP = 0x2;
                public const long POINT_WORLD_TEXT_JUSTIFY_VERTICAL_BOTTOM = 0x0;
                public const long POINT_WORLD_TEXT_JUSTIFY_VERTICAL_CENTER = 0x1;
            }
            public static partial class PreviewCharacterBannerAnimation {
                public const long INVALID = -0x1;
                public const long BANNER_FIRE = 0x14;
                public const long BANNER_3SHOT_A = 0x8;
                public const long BANNER_3SHOT_B = 0x9;
                public const long BANNER_3SHOT_C = 0xA;
                public const long BANNER_4SHOT_A = 0xC;
                public const long BANNER_4SHOT_B = 0xD;
                public const long BANNER_4SHOT_C = 0xE;
                public const long BANNER_4SHOT_D = 0xF;
                public const long IDLE_OFFSCREEN = 0x0;
                public const long BANNER_AWP_ACE_A = 0x2;
                public const long BANNER_AWP_ACE_B = 0x3;
                public const long BANNER_AWP_ACE_C = 0x4;
                public const long BANNER_AWP_ACE_D = 0x5;
                public const long BANNER_AWP_ACE_E = 0x6;
                public const long BANNER_BOMB_PLANT = 0x11;
                public const long BANNER_AWP_ACE_GUN = 0x1;
                public const long BANNER_PISTOL3SHOT = 0x7;
                public const long BANNER_PISTOL4SHOT = 0xB;
                public const long BANNER_BOMB_BLAST01 = 0x16;
                public const long BANNER_BOMB_BLAST02 = 0x17;
                public const long BANNER_BOMB_BLAST03 = 0x18;
                public const long BANNER_CELEBRATE_01 = 0x19;
                public const long BANNER_CELEBRATE_02 = 0x1A;
                public const long BANNER_CELEBRATE_03 = 0x1B;
                public const long BANNER_CELEBRATE_04 = 0x1C;
                public const long BANNER_BOMB_BLAST_TOSS = 0x15;
                public const long BANNER_BOMB_DEFUSAL_VER1 = 0x12;
                public const long BANNER_BOMB_DEFUSAL_VER2 = 0x13;
                public const long CELEBRATE_STRETCH_NOWEAP_IDLE0 = 0x10;
            }
            public static partial class PropDoorRotatingOpenDirection_e {
                public const long DOOR_ROTATING_OPEN_FORWARD = 0x1;
                public const long DOOR_ROTATING_OPEN_BACKWARD = 0x2;
                public const long DOOR_ROTATING_OPEN_BOTH_WAYS = 0x0;
            }
            public static partial class WorldTextPanelHorizontalAlign_t {
                public const long WORLDTEXT_HORIZONTAL_ALIGN_LEFT = 0x0;
                public const long WORLDTEXT_HORIZONTAL_ALIGN_RIGHT = 0x2;
                public const long WORLDTEXT_HORIZONTAL_ALIGN_CENTER = 0x1;
            }
            public static partial class EGCItemCustomizationNotification {
                public const long k_EGCItemCustomizationNotification_NameItem = 0x3EE;
                public const long k_EGCItemCustomizationNotification_ApplyPatch = 0x442;
                public const long k_EGCItemCustomizationNotification_CasketAdded = 0x3F5;
                public const long k_EGCItemCustomizationNotification_RemovePatch = 0x441;
                public const long k_EGCItemCustomizationNotification_UnlockCrate = 0x3EF;
                public const long k_EGCItemCustomizationNotification_ApplySticker = 0x43E;
                public const long k_EGCItemCustomizationNotification_NameBaseItem = 0x3FB;
                public const long k_EGCItemCustomizationNotification_StatTrakSwap = 0x440;
                public const long k_EGCItemCustomizationNotification_ApplyKeychain = 0x443;
                public const long k_EGCItemCustomizationNotification_CasketInvFull = 0x3F7;
                public const long k_EGCItemCustomizationNotification_CasketRemoved = 0x3F6;
                public const long k_EGCItemCustomizationNotification_CasketTooFull = 0x3F3;
                public const long k_EGCItemCustomizationNotification_RemoveSticker = 0x41D;
                public const long k_EGCItemCustomizationNotification_XRayItemClaim = 0x3F1;
                public const long k_EGCItemCustomizationNotification_CasketContents = 0x3F4;
                public const long k_EGCItemCustomizationNotification_ExtractSticker = 0x41E;
                public const long k_EGCItemCustomizationNotification_GraffitiUnseal = 0x23E1;
                public const long k_EGCItemCustomizationNotification_RemoveItemName = 0x406;
                public const long k_EGCItemCustomizationNotification_RemoveKeychain = 0x444;
                public const long k_EGCItemCustomizationNotification_XRayItemReveal = 0x3F0;
                public const long k_EGCItemCustomizationNotification_XpShopAckTracks = 0x2406;
                public const long k_EGCItemCustomizationNotification_XpShopUseTicket = 0x2405;
                public const long k_EGCItemCustomizationNotification_ActivateFanToken = 0x23DA;
                public const long k_EGCItemCustomizationNotification_GenerateSouvenir = 0x23F4;
                public const long k_EGCItemCustomizationNotification_EncapsulateSticker = 0x41F;
                public const long k_EGCItemCustomizationNotification_ActivateOperationCoin = 0x23DB;
                public const long k_EGCItemCustomizationNotification_ClientRedeemFreeReward = 0x2403;
                public const long k_EGCItemCustomizationNotification_ClientRedeemMissionReward = 0x23F9;
            }
            public static partial class CFuncMover__PathRebuildStrategy_t {
                public const long PATH_REBUILD_DONT_MOVE = 0x0;
                public const long PATH_REBUILD_MAINTAIN_T = 0x1;
                public const long PATH_REBUILD_USE_CURRENT_NODE_T = 0x2;
            }
            public static partial class FuncRotatorRotationSummaryFlags_t {
                public const long eNone = 0x0;
                public const long eRotateBegin = 0x1;
                public const long eOscillateEnd = 0x10;
                public const long eOscillateStart = 0x8;
                public const long eOscillateDepart = 0x40;
                public const long eRotateCompleted = 0x4;
                public const long eEventsDispatched = 0x2;
                public const long eOscillateArrived = 0x20;
            }
            public static partial class PointWorldTextJustifyHorizontal_t {
                public const long POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_LEFT = 0x0;
                public const long POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_RIGHT = 0x2;
                public const long POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_CENTER = 0x1;
            }
            public static partial class TestInputOutputCombinationsEnum_t {
                public const long ONE = 0x1;
                public const long TWO = 0x2;
                public const long ZERO = 0x0;
            }
            public static partial class ECSUsrMsg_DisconnectToLobby_Action {
                public const long k_ECSUsrMsg_DisconnectToLobby_Action_Default = 0x0;
                public const long k_ECSUsrMsg_DisconnectToLobby_Action_GoQueue = 0x1;
            }
            public static partial class PointTemplateOwnerSpawnGroupType_t {
                public const long INSERT_INTO_NEWLY_CREATED_SPAWN_GROUP = 0x2;
                public const long INSERT_INTO_POINT_TEMPLATE_SPAWN_GROUP = 0x0;
                public const long INSERT_INTO_CURRENTLY_ACTIVE_SPAWN_GROUP = 0x1;
            }
            public static partial class CCSPlayerAnimationState__MoveType_t {
                public const long Air = 0x2;
                public const long _None = 0x0;
                public const long Ground = 0x1;
                public const long Ladder = 0x3;
            }
            public static partial class CFuncMover__FollowEntityDirection_t {
                public const long FOLLOW_ENTITY_FORWARD = 0x1;
                public const long FOLLOW_ENTITY_REVERSE = 0x2;
                public const long FOLLOW_ENTITY_BIDIRECTIONAL = 0x0;
            }
            public static partial class ExternalAnimGraphInactiveBehavior_t {
                public const long eNone = 0x0;
                public const long eUnbind = 0x1;
                public const long eUnbindAndDelete = 0x2;
            }
            public static partial class CCSPlayerAnimationState__AirAction_t {
                public const long Jump = 0x1;
                public const long Land = 0x3;
                public const long _None = 0x0;
                public const long StartFall = 0x2;
            }
            public static partial class CCSPlayerAnimationState__Direction_t {
                public const long E = 0x3;
                public const long N = 0x1;
                public const long S = 0x5;
                public const long W = 0x7;
                public const long NE = 0x2;
                public const long NW = 0x8;
                public const long SE = 0x4;
                public const long SW = 0x6;
                public const long _None = 0x0;
            }
            public static partial class CFuncMover__FindFollowMoverStrategy_t {
                public const long FIND_FOLLOW_MOVER_FORWARD_CLOSEST = 0x0;
                public const long FIND_FOLLOW_MOVER_REVERSE_CLOSEST = 0x1;
                public const long FIND_FOLLOW_MOVER_BIDIRECTIONAL_CLOSEST = 0x2;
            }
            public static partial class ChoreoExternalAnimgraphControlState_t {
                public const long eExit = 0x1;
                public const long eNone = 0x0;
                public const long eCount = 0x9;
                public const long eLooping = 0x8;
                public const long eState01 = 0x3;
                public const long eState02 = 0x4;
                public const long eState03 = 0x5;
                public const long eState04 = 0x6;
                public const long eState05 = 0x7;
                public const long eFallbackExit = 0x2;
            }
            public static partial class EDestructiblePartDamagePassThroughType {
                public const long Absorb = 0x1;
                public const long Normal = 0x0;
                public const long InvincibleAbsorb = 0x2;
                public const long InvinciblePassthrough = 0x3;
            }
            public static partial class EDestructiblePartRadiusDamageApplyType {
                public const long PrioritizeClosestPart = 0x1;
                public const long ScaleByExplosionRadius = 0x0;
            }
            public static partial class PointTemplateClientOnlyEntityBehavior_t {
                public const long CREATE_FOR_CLIENTS_WHO_CONNECT_LATER = 0x1;
                public const long CREATE_FOR_CURRENTLY_CONNECTED_CLIENTS_ONLY = 0x0;
            }
            public static partial class CFuncMover__TransitionToPathNodeAction_t {
                public const long TRANSITION_TO_PATH_NODE_ACTION_NONE = 0x0;
                public const long TRANSITION_TO_PATH_NODE_TRANSITIONING = 0x3;
                public const long TRANSITION_TO_PATH_NODE_ACTION_START_FORWARD = 0x1;
                public const long TRANSITION_TO_PATH_NODE_ACTION_START_REVERSE = 0x2;
            }
            public static partial class EDestructibleParts_DestroyParameterFlags {
                public const long _None = 0x0;
                public const long Default = 0x7;
                public const long EnableFlinches = 0x4;
                public const long ForceDamageApply = 0x8;
                public const long ApplyPhysicsForce = 0x40;
                public const long IgnoreHealthCheck = 0x20;
                public const long GenerateBreakpieces = 0x1;
                public const long IgnoreKillEntityFlag = 0x10;
                public const long SetBodyGroupAndCollisionState = 0x2;
            }
            public static partial class CCSPlayerAnimationState__GroundMoveState_t {
                public const long Idle = 0x1;
                public const long Move = 0x3;
                public const long _None = 0x0;
                public const long Start = 0x2;
                public const long TurnOnSpot = 0x4;
                public const long PlantAndTurn = 0x6;
                public const long TurnOnSpotLoop = 0x5;
            }
            public static partial class DestructiblePartDestructionDeathBehavior_t {
                public const long eGib = 0x2;
                public const long eKill = 0x1;
                public const long eRemove = 0x3;
                public const long eDoNotKill = 0x0;
            }
            public static partial class EProceduralRagdollWeightIndexPropagationMethod {
                public const long Bone = 0x0;
                public const long BoneAndChildren = 0x1;
            }
            public static partial class CLogicBranchList__LogicBranchListenerLastState_t {
                public const long LOGIC_BRANCH_LISTENER_MIXED = 0x3;
                public const long LOGIC_BRANCH_LISTENER_ALL_TRUE = 0x1;
                public const long LOGIC_BRANCH_LISTENER_NOT_INIT = 0x0;
                public const long LOGIC_BRANCH_LISTENER_ALL_FALSE = 0x2;
            }
            public static partial class CPathMoverEntitySpawner__TemplateChoiceStrategy_t {
                public const long TEMPLATE_CHOICE_COUNT_RANDOM = 0x2;
                public const long TEMPLATE_CHOICE_WEIGHTED_RANDOM = 0x1;
                public const long TEMPLATE_CHOICE_COUNT_SEQUENTIAL = 0x0;
            }
        }
    }
}
