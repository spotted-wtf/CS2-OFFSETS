export namespace cs2_dumper {
    export namespace schemas {
        export namespace server_dll {
            export namespace CC4 {
                export const m_fArmedTime = 0x12CC;
                export const m_nSpotRules = 0x12F0;
                export const m_bBombPlanted = 0x12FB;
                export const m_bStartedArming = 0x12C9;
                export const m_bIsPlantingViaUse = 0x12D1;
                export const m_bPlayedArmingBeeps = 0x12F4;
                export const m_entitySpottedState = 0x12D8;
                export const m_bBombPlacedAnimation = 0x12D0;
                export const m_vecLastValidDroppedPosition = 0x12BC;
                export const m_bDoValidDroppedPositionCheck = 0x12C8;
                export const m_vecLastValidPlayerHeldPosition = 0x12B0;
            }
            export namespace CBot {
                export const m_id = 0x24;
                export const m_pPlayer = 0x18;
                export const m_isRunning = 0xC0;
                export const m_leftSpeed = 0xC8;
                export const m_bHasSpawned = 0x20;
                export const m_buttonFlags = 0xD0;
                export const m_isCrouching = 0xC1;
                export const m_pController = 0x10;
                export const m_viewForward = 0xDC;
                export const m_forwardSpeed = 0xC4;
                export const m_jumpTimestamp = 0xD8;
                export const m_verticalSpeed = 0xCC;
                export const m_postureStackIndex = 0xF8;
            }
            export namespace CAK47 {

            }
            export namespace CBeam {
                export const m_fSpeed = 0x8CC;
                export const m_fWidth = 0x8B4;
                export const m_flFrame = 0x8D0;
                export const m_flDamage = 0x85C;
                export const m_fEndWidth = 0x8B8;
                export const m_nBeamType = 0x878;
                export const m_vecEndPos = 0x8D8;
                export const m_bTurnedOff = 0x8D4;
                export const m_fAmplitude = 0x8C4;
                export const m_fHaloScale = 0x8C0;
                export const m_flFireTime = 0x858;
                export const m_hEndEntity = 0x8E4;
                export const m_nBeamFlags = 0x87C;
                export const m_nHaloIndex = 0x870;
                export const m_fFadeLength = 0x8BC;
                export const m_fStartFrame = 0x8C8;
                export const m_flFrameRate = 0x850;
                export const m_nAttachIndex = 0x8A8;
                export const m_nNumBeamEnts = 0x860;
                export const m_hAttachEntity = 0x880;
                export const m_hBaseMaterial = 0x868;
                export const m_nDissolveType = 0x8E8;
                export const m_flHDRColorScale = 0x854;
            }
            export namespace CFish {
                export const m_x = 0xA48;
                export const m_y = 0xA4C;
                export const m_z = 0xA50;
                export const m_id = 0xA44;
                export const m_perp = 0xA68;
                export const m_pool = 0xA40;
                export const m_angle = 0xA54;
                export const m_speed = 0xA84;
                export const m_forward = 0xA5C;
                export const m_goTimer = 0xAB8;
                export const m_visible = 0xB30;
                export const m_calmSpeed = 0xA8C;
                export const m_moveTimer = 0xAD0;
                export const m_turnTimer = 0xA98;
                export const m_avoidRange = 0xA94;
                export const m_panicSpeed = 0xA90;
                export const m_panicTimer = 0xAE8;
                export const m_poolOrigin = 0xA74;
                export const m_waterLevel = 0xA80;
                export const m_angleChange = 0xA58;
                export const m_desiredSpeed = 0xA88;
                export const m_disperseTimer = 0xB00;
                export const m_turnClockwise = 0xAB0;
                export const m_proximityTimer = 0xB18;
            }
            export namespace CItem {
                export const m_OnGlovePulled = 0xA98;
                export const m_OnPlayerTouch = 0xA48;
                export const m_OnPlayerPickup = 0xA60;
                export const m_bPhysStartAsleep = 0xAC8;
                export const m_OnCacheInteraction = 0xA80;
                export const m_bActivateWhenAtRest = 0xA78;
                export const m_vOriginalSpawnAngles = 0xABC;
                export const m_vOriginalSpawnOrigin = 0xAB0;
            }
            export namespace CTeam {
                export const m_iScore = 0x4D8;
                export const m_aPlayers = 0x4C0;
                export const m_szTeamname = 0x4DC;
                export const m_aPlayerControllers = 0x4A8;
            }
            export namespace CBlood {
                export const m_Color = 0x4C4;
                export const m_flAmount = 0x4C0;
                export const m_vecSprayDir = 0x4B4;
                export const m_vecSprayAngles = 0x4A8;
            }
            export namespace CCSBot {
                export const m_name = 0x114;
                export const m_avoid = 0x5F4;
                export const m_enemy = 0x5A00;
                export const m_avgVel = 0x5DCC;
                export const m_bomber = 0x5C38;
                export const m_leader = 0x1AC;
                export const m_aimGoal = 0x59C4;
                export const m_isRogue = 0x158;
                export const m_isStuck = 0x5D83;
                export const m_lookYaw = 0x598C;
                export const m_wasSafe = 0x184;
                export const m_aimError = 0x59B8;
                export const m_aimFocus = 0x59D4;
                export const m_attacker = 0x5C58;
                export const m_safeTime = 0x180;
                export const m_blindFire = 0x18C;
                export const m_hasJoined = 0x52BC;
                export const m_lookPitch = 0x5984;
                export const m_pathIndex = 0x4F00;
                export const m_stuckSpot = 0x5D88;
                export const m_waitTimer = 0x4FE8;
                export const m_zoomTimer = 0x5C88;
                export const m_alertTimer = 0x1D0;
                export const m_equipTimer = 0x5C78;
                export const m_goalEntity = 0x5F0;
                export const m_hurryTimer = 0x1B8;
                export const m_isStopping = 0x5FC;
                export const m_lastOrigin = 0x5DFC;
                export const m_lookAtDesc = 0x5380;
                export const m_lookAtSpot = 0x5360;
                export const m_lookYawVel = 0x5990;
                export const m_panicTimer = 0x200;
                export const m_rogueTimer = 0x160;
                export const m_sneakTimer = 0x1E8;
                export const m_stillTimer = 0x600;
                export const m_targetSpot = 0x5994;
                export const m_taskEntity = 0x5D4;
                export const m_avgVelCount = 0x5DF8;
                export const m_avgVelIndex = 0x5DF4;
                export const m_bIsSleeping = 0x5CC0;
                export const m_combatRange = 0x154;
                export const m_desiredTeam = 0x52B8;
                export const m_eyePosition = 0x108;
                export const m_isAttacking = 0x5CC;
                export const m_isFollowing = 0x1A9;
                export const m_lookUpAngle = 0x5350;
                export const m_noiseSource = 0x5308;
                export const m_politeTimer = 0x4F40;
                export const m_repathTimer = 0x4F08;
                export const m_wiggleTimer = 0x5D98;
                export const m_bAllowActive = 0x1A8;
                export const m_forwardAngle = 0x5354;
                export const m_goalPosition = 0x5E4;
                export const m_lastVictimID = 0x5C70;
                export const m_lookPitchVel = 0x5988;
                export const m_mustRunTimer = 0x4FD0;
                export const m_radioSubject = 0x5E14;
                export const m_diedLastRound = 0x17C;
                export const m_isOpeningDoor = 0x5CD;
                export const m_isRapidFiring = 0x5C75;
                export const m_noisePosition = 0x52F0;
                export const m_pathLadderEnd = 0x4F84;
                export const m_radioPosition = 0x5E18;
                export const m_surpriseTimer = 0x190;
                export const m_avoidTimestamp = 0x5F8;
                export const m_isEnemyVisible = 0x5A04;
                export const m_lookAheadAngle = 0x534C;
                export const m_noiseBendTimer = 0x5320;
                export const m_noiseTimestamp = 0x5300;
                export const m_stateTimestamp = 0x5C8;
                export const m_stuckJumpTimer = 0x5DB0;
                export const m_stuckTimestamp = 0x5D84;
                export const m_targetSpotTime = 0x59D0;
                export const m_enemyQueueCount = 0x5D81;
                export const m_enemyQueueIndex = 0x5D80;
                export const m_followTimestamp = 0x1B0;
                export const m_isAimingAtEnemy = 0x5C74;
                export const m_isLastEnemyDead = 0x5A28;
                export const m_viewSteadyTimer = 0x5520;
                export const m_aimFocusInterval = 0x59D8;
                export const m_avoidFriendTimer = 0x4F20;
                export const m_isFriendInTheWay = 0x4F38;
                export const m_lookAtSpotAttack = 0x537D;
                export const m_nearbyEnemyCount = 0x5A2C;
                export const m_tossGrenadeTimer = 0x5538;
                export const m_attackedTimestamp = 0x5C5C;
                export const m_attentionInterval = 0x5C48;
                export const m_bentNoisePosition = 0x5338;
                export const m_isAvoidingGrenade = 0x5558;
                export const m_lastEnemyPosition = 0x5A08;
                export const m_nearbyFriendCount = 0x5C3C;
                export const m_visibleEnemyParts = 0x5A05;
                export const m_voiceEndTimestamp = 0x5E24;
                export const m_aimFocusNextUpdate = 0x59DC;
                export const m_approachPointCount = 0x5510;
                export const m_hostageEscortCount = 0x52B0;
                export const m_ignoreEnemiesTimer = 0x59E8;
                export const m_lookAtSpotDuration = 0x5370;
                export const m_spotCheckTimestamp = 0x5578;
                export const m_targetSpotVelocity = 0x59A0;
                export const m_allowAutoFollowTime = 0x1B4;
                export const m_burnedByFlamesTimer = 0x5C60;
                export const m_enemyDeathTimestamp = 0x5A20;
                export const m_fireWeaponTimestamp = 0x5CA0;
                export const m_isWaitingForHostage = 0x52BD;
                export const m_lookAtSpotTimestamp = 0x5374;
                export const m_noiseTravelDistance = 0x52FC;
                export const m_peripheralTimestamp = 0x5388;
                export const m_sawEnemySniperTimer = 0x5CC8;
                export const m_targetSpotPredicted = 0x59AC;
                export const m_travelDistancePhase = 0x5118;
                export const m_waitForHostageTimer = 0x52D8;
                export const m_areaEnteredTimestamp = 0x4F04;
                export const m_closestVisibleFriend = 0x5C40;
                export const m_friendDeathTimestamp = 0x5A24;
                export const m_hasVisitedEnemySpawn = 0x5FD;
                export const m_isEnemySniperVisible = 0x5CC1;
                export const m_playerTravelDistance = 0x5018;
                export const m_enemyQueueAttendIndex = 0x5D82;
                export const m_isWaitingBehindFriend = 0x4F58;
                export const m_lastSawEnemyTimestamp = 0x5A14;
                export const m_bendNoisePositionValid = 0x5344;
                export const m_checkedHidingSpotCount = 0x5980;
                export const m_firstSawEnemyTimestamp = 0x5A18;
                export const m_lastRadioSentTimestamp = 0x5E10;
                export const m_lookAtSpotClearIfClose = 0x537C;
                export const m_lookAroundStateTimestamp = 0x5348;
                export const m_lookAtSpotAngleTolerance = 0x5378;
                export const m_approachPointViewPosition = 0x5514;
                export const m_closestVisibleHumanFriend = 0x5C44;
                export const m_nextCleanupCheckTimestamp = 0x5DC8;
                export const m_updateTravelDistanceTimer = 0x5000;
                export const m_inhibitLookAroundTimestamp = 0x5358;
                export const m_lastRadioRecievedTimestamp = 0x5E0C;
                export const m_hostageEscortCountTimestamp = 0x52B4;
                export const m_lastValidReactionQueueFrame = 0x5E30;
                export const m_lookForWeaponsOnGroundTimer = 0x5CA8;
                export const m_currentEnemyAcquireTimestamp = 0x5A1C;
                export const m_inhibitWaitingForHostageTimer = 0x52C0;
                export const m_bEyeAnglesUnderPathFinderControl = 0x610;
            }
            export namespace CKnife {
                export const m_bFirstAttack = 0x1280;
            }
            export namespace CWorld {

            }
            export namespace Extent {
                export const hi = 0xC;
                export const lo = 0x0;
            }
            export namespace CBtNode {

            }
            export namespace CCSTeam {
                export const m_iClanID = 0x800;
                export const m_bSurrendered = 0x568;
                export const m_scoreOvertime = 0x778;
                export const m_scoreFirstHalf = 0x770;
                export const m_szClanTeamname = 0x77C;
                export const m_numMapVictories = 0x76C;
                export const m_scoreSecondHalf = 0x774;
                export const m_szTeamFlagImage = 0x804;
                export const m_szTeamLogoImage = 0x80C;
                export const m_szTeamMatchStat = 0x569;
                export const m_iLastUpdateSentAt = 0x818;
                export const m_flNextResourceTime = 0x814;
                export const m_nShorthandedRoundBonusStartRound = 0x564;
                export const m_nLastRecievedShorthandedRoundBonus = 0x560;
            }
            export namespace CDEagle {

            }
            export namespace CEnvSky {
                export const m_bEnabled = 0x884;
                export const m_nFogType = 0x870;
                export const m_vTintColor = 0x864;
                export const m_flFogMaxEnd = 0x880;
                export const m_flFogMinEnd = 0x878;
                export const m_hSkyMaterial = 0x850;
                export const m_flFogMaxStart = 0x87C;
                export const m_flFogMinStart = 0x874;
                export const m_bStartDisabled = 0x860;
                export const m_flBrightnessScale = 0x86C;
                export const m_vTintColorLightingOnly = 0x868;
                export const m_hSkyMaterialLightingOnly = 0x858;
            }
            export namespace CShower {
                export const m_flSpeed = 0x850;
            }
            export namespace CSprite {
                export const m_flFrame = 0x864;
                export const m_flSpeed = 0x8BC;
                export const m_flDieTime = 0x868;
                export const m_flLastTime = 0x894;
                export const m_flMaxFrame = 0x898;
                export const m_flDestScale = 0x8A0;
                export const m_nAttachment = 0x85C;
                export const m_nBrightness = 0x878;
                export const m_flStartScale = 0x89C;
                export const m_nSpriteWidth = 0x8B4;
                export const m_flSpriteScale = 0x880;
                export const m_nSpriteHeight = 0x8B8;
                export const m_flGlowProxySize = 0x88C;
                export const m_flHDRColorScale = 0x890;
                export const m_flScaleDuration = 0x884;
                export const m_hSpriteMaterial = 0x850;
                export const m_nDestBrightness = 0x8AC;
                export const m_bWorldSpaceScale = 0x888;
                export const m_flScaleTimeStart = 0x8A4;
                export const m_nStartBrightness = 0x8A8;
                export const m_flSpriteFramerate = 0x860;
                export const m_hAttachedToEntity = 0x858;
                export const m_flBrightnessDuration = 0x87C;
                export const m_flBrightnessTimeStart = 0x8B0;
            }
            export namespace CBuyZone {
                export const m_LegacyTeamNum = 0x9C8;
            }
            export namespace CCSPlace {
                export const m_name = 0x868;
            }
            export namespace CChicken {
                export const m_owner = 0x11AC;
                export const m_leader = 0x11A8;
                export const m_fleeFrom = 0x115C;
                export const m_turnRate = 0x1158;
                export const m_jumpTimer = 0x11D8;
                export const m_isOnGround = 0x1128;
                export const m_reuseTimer = 0x11C0;
                export const m_repathTimer = 0x3200;
                export const m_stuckAnchor = 0x1100;
                export const m_updateTimer = 0x10E8;
                export const m_vecPathGoal = 0x3298;
                export const m_startleTimer = 0x1178;
                export const m_activityTimer = 0x1140;
                export const m_vFallVelocity = 0x112C;
                export const m_vocalizeTimer = 0x1190;
                export const m_flLastJumpTime = 0x11F0;
                export const m_currentActivity = 0x113C;
                export const m_desiredActivity = 0x1138;
                export const m_AttributeManager = 0xCB0;
                export const m_followMinuteTimer = 0x32A8;
                export const m_BlockDirectionTimer = 0x32C8;
                export const m_collisionStuckTimer = 0x1110;
                export const m_bSpawnDyingParticles = 0x32E2;
                export const m_moveRateThrottleTimer = 0x1160;
                export const m_flActiveFollowStartTime = 0x32A4;
            }
            export namespace CCredits {
                export const m_flLogoLength = 0x4C4;
                export const m_OnCreditsDone = 0x4A8;
                export const m_bRolledOutroCredits = 0x4C0;
            }
            export namespace CEnvBeam {
                export const m_life = 0x910;
                export const m_speed = 0x91C;
                export const m_active = 0x8F0;
                export const m_radius = 0x94C;
                export const m_hFilter = 0x960;
                export const m_iszDecal = 0x968;
                export const m_restrike = 0x920;
                export const m_TouchType = 0x950;
                export const m_boltWidth = 0x914;
                export const m_frameStart = 0x930;
                export const m_iFilterName = 0x958;
                export const m_iszEndEntity = 0x908;
                export const m_iszSpriteName = 0x928;
                export const m_spriteTexture = 0x8F8;
                export const m_iszStartEntity = 0x900;
                export const m_noiseAmplitude = 0x918;
                export const m_vEndPointWorld = 0x934;
                export const m_OnTouchedByEntity = 0x970;
                export const m_vEndPointRelative = 0x940;
            }
            export namespace CEnvFade {
                export const m_Duration = 0x4AC;
                export const m_fadeColor = 0x4A8;
                export const m_OnBeginFade = 0x4B8;
                export const m_HoldDuration = 0x4B0;
            }
            export namespace CEnvTilt {
                export const m_Radius = 0x4AC;
                export const m_Duration = 0x4A8;
                export const m_TiltTime = 0x4B0;
                export const m_stopTime = 0x4B4;
            }
            export namespace CEnvWind {
                export const m_EnvWindShared = 0x4A8;
            }
            export namespace CGameEnd {

            }
            export namespace CHostage {
                export const m_vel = 0xBC0;
                export const m_accel = 0xBFC;
                export const m_leader = 0xBD4;
                export const m_bRemove = 0xBBC;
                export const m_OnRescued = 0xB80;
                export const m_isRescued = 0xBCC;
                export const m_isRunning = 0xC08;
                export const m_jumpTimer = 0xC10;
                export const m_isAdjusted = 0x2D1C;
                export const m_lastLeader = 0xBD8;
                export const m_nSpotRules = 0xBB0;
                export const m_reuseTimer = 0xBE0;
                export const m_hasBeenUsed = 0xBF8;
                export const m_isCrouching = 0xC09;
                export const m_repathTimer = 0x2C38;
                export const m_wiggleTimer = 0x2D00;
                export const m_fLastGrabTime = 0x2D24;
                export const m_nHostageState = 0xBD0;
                export const m_vecGrabbedPos = 0x2D34;
                export const m_OnFirstPickedUp = 0xB50;
                export const m_flDropStartTime = 0x2D48;
                export const m_hHostageGrabber = 0x2D20;
                export const m_jumpedThisFrame = 0xBCD;
                export const m_inhibitDoorTimer = 0x2C50;
                export const m_bHandsHaveBeenCut = 0x2D1D;
                export const m_flGrabSuccessTime = 0x2D44;
                export const m_flRescueStartTime = 0x2D40;
                export const m_nPickupEventCount = 0x2D50;
                export const m_vecSpawnGroundPos = 0x2D54;
                export const m_OnHostageBeginGrab = 0xB38;
                export const m_entitySpottedState = 0xB98;
                export const m_isWaitingForLeader = 0xC28;
                export const m_OnDroppedNotRescued = 0xB68;
                export const m_nApproachRewardPayouts = 0x2D4C;
                export const m_vecHostageResetPosition = 0x2D8C;
                export const m_nHostageSpawnRandomFactor = 0xBB8;
                export const m_inhibitObstacleAvoidanceTimer = 0x2CE0;
                export const m_uiHostageSpawnExclusionGroupMask = 0xBB4;
                export const m_vecPositionWhenStartedDroppingToGround = 0x2D28;
            }
            export namespace CInferno {
                export const m_extent = 0x13A8;
                export const m_startPos = 0x1408;
                export const m_fireCount = 0x1190;
                export const m_BurnNormal = 0xE90;
                export const m_nMaxFlames = 0x1434;
                export const m_activeTimer = 0x1420;
                export const m_damageTimer = 0x13C0;
                export const m_nInfernoType = 0x1194;
                export const m_nSpreadCount = 0x1438;
                export const m_firePositions = 0x850;
                export const m_nFireLifetime = 0x119C;
                export const m_bFireIsBurning = 0xE50;
                export const m_splashVelocity = 0x13F0;
                export const m_NextSpreadTimer = 0x1458;
                export const m_damageRampTimer = 0x13D8;
                export const m_fireSpawnOffset = 0x1430;
                export const m_BookkeepingTimer = 0x1440;
                export const m_bInPostEffectTime = 0x11A0;
                export const m_bWasCreatedInSmoke = 0x11A1;
                export const m_fireParentPositions = 0xB50;
                export const m_nSourceItemDefIndex = 0x1470;
                export const m_nFireEffectTickBegin = 0x1198;
                export const m_InitialSplashVelocity = 0x13FC;
                export const m_vecOriginalSpawnLocation = 0x1414;
            }
            export namespace CInfoFan {
                export const m_flCurveDistRange = 0x4F0;
                export const m_fFanForceMaxRadius = 0x4E8;
                export const m_fFanForceMinRadius = 0x4EC;
                export const m_FanForceCurveString = 0x4F8;
            }
            export namespace CMapInfo {
                export const m_flBombRadius = 0x4AC;
                export const m_iBuyingStatus = 0x4A8;
                export const m_iHostageCount = 0x4BC;
                export const m_bGPUCullSkybox = 0x4C2;
                export const m_iPetPopulation = 0x4B0;
                export const m_flEnvRainStrength = 0x4C4;
                export const m_flEnvWetnessCoverage = 0x4D0;
                export const m_bUseNormalSpawnsForDM = 0x4B4;
                export const m_bRainTraceToSkyEnabled = 0x4C1;
                export const m_flBotMaxVisionDistance = 0x4B8;
                export const m_flEnvWetnessDryingAmount = 0x4D4;
                export const m_bFadePlayerVisibilityFarZ = 0x4C0;
                export const m_flEnvPuddleRippleStrength = 0x4C8;
                export const m_flEnvPuddleRippleDirection = 0x4CC;
                export const m_bDisableAutoGeneratedDMSpawns = 0x4B5;
            }
            export namespace CMessage {
                export const m_Radius = 0x4B8;
                export const m_sNoise = 0x4C0;
                export const m_iszMessage = 0x4A8;
                export const m_MessageVolume = 0x4B0;
                export const m_OnShowMessage = 0x4C8;
                export const m_MessageAttenuation = 0x4B4;
            }
            export namespace CPhysBox {
                export const m_OnDamaged = 0x978;
                export const m_OnAwakened = 0x990;
                export const m_damageType = 0x928;
                export const m_OnPlayerUse = 0x9C0;
                export const m_OnStartTouch = 0x9D8;
                export const m_iszInteractsAs = 0x960;
                export const m_OnMotionEnabled = 0x9A8;
                export const m_nHoverPoseFlags = 0x94E;
                export const m_bEnableUseOutput = 0x94D;
                export const m_bNotSolidToWorld = 0x94C;
                export const m_iszInteractsWith = 0x968;
                export const m_iszCollisionGroup = 0x958;
                export const m_angHoverPoseAngles = 0x940;
                export const m_vHoverPosePosition = 0x934;
                export const m_iszInteractsExclude = 0x970;
                export const m_damageToEnableMotion = 0x92C;
                export const m_flForceToEnableMotion = 0x930;
                export const m_flTouchOutputPerEntityDelay = 0x950;
            }
            export namespace CRotDoor {
                export const m_bSolidBsp = 0xA58;
            }
            export namespace IRagdoll {

            }
            export namespace PathCost {
                export const m_dangerFactor = 0x3C;
                export const m_flAgentMaxClimb = 0x44;
                export const m_damagingAreasPenaltyCost = 0x40;
            }
            export namespace CBaseDoor {
                export const m_ls = 0x8F8;
                export const m_OnOpen = 0x9F8;
                export const m_OnClose = 0x9E0;
                export const m_bLocked = 0x91A;
                export const m_bNoNPCs = 0x91C;
                export const m_flSpeed = 0xA4C;
                export const m_bIsUsable = 0xA51;
                export const m_bDoorGroup = 0x919;
                export const m_isChaining = 0xA50;
                export const m_ChainTarget = 0x948;
                export const m_NoiseMoving = 0x928;
                export const m_OnFullyOpen = 0x9C8;
                export const m_OnLockedUse = 0xA10;
                export const m_NoiseArrived = 0x930;
                export const m_bForceClosed = 0x918;
                export const m_OnFullyClosed = 0x9B0;
                export const m_bIgnoreDebris = 0x91B;
                export const m_flBlockDamage = 0x924;
                export const m_bLoopMoveSound = 0xA28;
                export const m_eSpawnPosition = 0x920;
                export const m_OnBlockedClosing = 0x950;
                export const m_OnBlockedOpening = 0x968;
                export const m_NoiseMovingClosed = 0x938;
                export const m_NoiseArrivedClosed = 0x940;
                export const m_OnUnblockedClosing = 0x980;
                export const m_OnUnblockedOpening = 0x998;
                export const m_angMoveEntitySpace = 0x8E0;
                export const m_bCreateNavObstacle = 0xA48;
                export const m_vecMoveDirParentSpace = 0x8EC;
            }
            export namespace CBaseProp {
                export const m_iShapeType = 0xA44;
                export const m_bModelOverrodeBlockLOS = 0xA40;
                export const m_mPreferredCatchTransform = 0xA50;
                export const m_bConformToCollisionBounds = 0xA48;
            }
            export namespace CCSSprite {

            }
            export namespace CEnvDecal {
                export const m_flDepth = 0x860;
                export const m_flWidth = 0x858;
                export const m_flHeight = 0x85C;
                export const m_nRenderOrder = 0x864;
                export const m_hDecalMaterial = 0x850;
                export const m_bProjectOnWater = 0x86A;
                export const m_bProjectOnWorld = 0x868;
                export const m_flDepthSortBias = 0x86C;
                export const m_bProjectOnCharacters = 0x869;
            }
            export namespace CEnvLaser {
                export const m_pSprite = 0x8F8;
                export const m_firePosition = 0x908;
                export const m_flStartFrame = 0x914;
                export const m_iszSpriteName = 0x900;
                export const m_iszLaserTarget = 0x8F0;
            }
            export namespace CEnvShake {
                export const m_Radius = 0x4BC;
                export const m_Duration = 0x4B8;
                export const m_maxForce = 0x4CC;
                export const m_stopTime = 0x4C0;
                export const m_Amplitude = 0x4B0;
                export const m_Frequency = 0x4B4;
                export const m_nextShake = 0x4C4;
                export const m_currentAmp = 0x4C8;
                export const m_limitToEntity = 0x4A8;
                export const m_shakeCallback = 0x4E0;
                export const m_pShakeController = 0x4D8;
            }
            export namespace CEnvSpark {
                export const m_nType = 0x4B4;
                export const m_OnSpark = 0x4B8;
                export const m_flDelay = 0x4A8;
                export const m_nMagnitude = 0x4AC;
                export const m_nTrailLength = 0x4B0;
            }
            export namespace CFishPool {
                export const m_fishes = 0x4D0;
                export const m_maxRange = 0x4BC;
                export const m_visTimer = 0x4E8;
                export const m_fishCount = 0x4B8;
                export const m_isDormant = 0x4C8;
                export const m_swimDepth = 0x4C0;
                export const m_waterLevel = 0x4C4;
            }
            export namespace CFuncPlat {
                export const m_sNoise = 0x900;
                export const m_flSpeed = 0x8F8;
            }
            export namespace CFuncWall {
                export const m_nState = 0x850;
            }
            export namespace CGameText {
                export const m_textParms = 0x868;
                export const m_iszMessage = 0x860;
            }
            export namespace CInfoData {

            }
            export namespace CItemSoda {

            }
            export namespace CNavFlags {
                export const m_Flags = 0x0;
            }
            export namespace CPathNode {
                export const m_hPath = 0x4F0;
                export const m_xWSPrevParent = 0x4D0;
                export const m_vInTangentLocal = 0x4A8;
                export const m_vOutTangentLocal = 0x4B4;
                export const m_strPathNodeParameter = 0x4C8;
                export const m_strParentPathUniqueID = 0x4C0;
            }
            export namespace CPushable {

            }
            export namespace CRangeInt {
                export const m_pValue = 0x0;
            }
            export namespace CSimTimer {
                export const m_flInterval = 0x8;
            }
            export namespace CSkillInt {
                export const m_pValue = 0x0;
            }
            export namespace CTimeline {
                export const m_bStopped = 0x220;
                export const m_flValues = 0x10;
                export const m_flInterval = 0x214;
                export const m_flFinalValue = 0x218;
                export const m_nBucketCount = 0x210;
                export const m_nValueCounts = 0x110;
                export const m_nCompressionType = 0x21C;
            }
            export namespace NavHull_t {
                export const m_nHullIdx = 0x0;
            }
            export namespace ragdoll_t {
                export const list = 0x0;
                export const unused = 0x49;
                export const boneIndex = 0x30;
                export const allowStretch = 0x48;
                export const hierarchyJoints = 0x18;
            }
            export namespace CBarnLight {
                export const m_nFog = 0x9D8;
                export const m_Color = 0x858;
                export const m_vShear = 0x98C;
                export const m_flRange = 0x988;
                export const m_flShape = 0x968;
                export const m_flSkirt = 0x974;
                export const m_flSoftX = 0x96C;
                export const m_flSoftY = 0x970;
                export const m_bEnabled = 0x850;
                export const m_StyleEvent = 0x8E0;
                export const m_flFogScale = 0x9E4;
                export const m_nColorMode = 0x854;
                export const m_VisClusters = 0xB18;
                export const m_flSkirtNear = 0x978;
                export const m_nFogShadows = 0x9E0;
                export const m_vSizeParams = 0x97C;
                export const m_flBrightness = 0x860;
                export const m_hLightCookie = 0x960;
                export const m_nBounceLight = 0x9BC;
                export const m_nCastShadows = 0x9AC;
                export const m_nDirectLight = 0x868;
                export const m_flBounceScale = 0x9C0;
                export const m_flFadeSizeEnd = 0x9EC;
                export const m_flFogStrength = 0x9DC;
                export const m_bContactShadow = 0x9B8;
                export const m_flMinRoughness = 0x9C4;
                export const m_nShadowMapSize = 0x9B0;
                export const m_bTransmitAlways = 0xB15;
                export const m_flFadeSizeStart = 0x9E8;
                export const m_flLuminaireSize = 0x87C;
                export const m_nLuminaireShape = 0x878;
                export const m_nShadowPriority = 0x9B4;
                export const m_vAlternateColor = 0x9C8;
                export const m_LightStyleEvents = 0x8B0;
                export const m_LightStyleString = 0x888;
                export const m_bPvsModifyEntity = 0xB14;
                export const m_LightStyleTargets = 0x8C8;
                export const m_flBrightnessScale = 0x864;
                export const m_nBakedShadowIndex = 0x86C;
                export const m_nLightMapUniqueId = 0x874;
                export const m_flColorTemperature = 0x85C;
                export const m_nLightPathUniqueId = 0x870;
                export const m_flShadowFadeSizeEnd = 0x9F4;
                export const m_bForceShadowsEnabled = 0x9B9;
                export const m_flLightStyleStartTime = 0x890;
                export const m_flLuminaireAnisotropy = 0x880;
                export const m_flShadowFadeSizeStart = 0x9F0;
                export const m_nPrecomputedSubFrusta = 0xA38;
                export const m_vPrecomputedOBBAngles = 0xA20;
                export const m_vPrecomputedOBBExtent = 0xA2C;
                export const m_vPrecomputedOBBOrigin = 0xA14;
                export const m_vPrecomputedBoundsMaxs = 0xA08;
                export const m_vPrecomputedBoundsMins = 0x9FC;
                export const m_vPrecomputedOBBAngles0 = 0xA48;
                export const m_vPrecomputedOBBAngles1 = 0xA6C;
                export const m_vPrecomputedOBBAngles2 = 0xA90;
                export const m_vPrecomputedOBBAngles3 = 0xAB4;
                export const m_vPrecomputedOBBAngles4 = 0xAD8;
                export const m_vPrecomputedOBBAngles5 = 0xAFC;
                export const m_vPrecomputedOBBExtent0 = 0xA54;
                export const m_vPrecomputedOBBExtent1 = 0xA78;
                export const m_vPrecomputedOBBExtent2 = 0xA9C;
                export const m_vPrecomputedOBBExtent3 = 0xAC0;
                export const m_vPrecomputedOBBExtent4 = 0xAE4;
                export const m_vPrecomputedOBBExtent5 = 0xB08;
                export const m_vPrecomputedOBBOrigin0 = 0xA3C;
                export const m_vPrecomputedOBBOrigin1 = 0xA60;
                export const m_vPrecomputedOBBOrigin2 = 0xA84;
                export const m_vPrecomputedOBBOrigin3 = 0xAA8;
                export const m_vPrecomputedOBBOrigin4 = 0xACC;
                export const m_vPrecomputedOBBOrigin5 = 0xAF0;
                export const m_QueuedLightStyleStrings = 0x898;
                export const m_bPrecomputedFieldsValid = 0x9F8;
                export const m_nBakeSpecularToCubemaps = 0x998;
                export const m_fAlternateColorBrightness = 0x9D4;
                export const m_vBakeSpecularToCubemapsSize = 0x99C;
                export const m_flBakeSpecularToCubemapsScale = 0x9A8;
            }
            export namespace CBaseIssue {
                export const m_iNumNoVotes = 0x168;
                export const m_iNumYesVotes = 0x164;
                export const m_szTypeString = 0x20;
                export const m_pVoteController = 0x170;
                export const m_szDetailsString = 0x60;
                export const m_iNumPotentialVotes = 0x16C;
            }
            export namespace CBreakable {
                export const m_OnBreak = 0x8E0;
                export const m_Material = 0x898;
                export const m_hBreaker = 0x89C;
                export const m_Explosion = 0x8A0;
                export const m_iszPropData = 0x8B8;
                export const m_OnStartDeath = 0x8C8;
                export const m_iMinHealthDmg = 0x8B4;
                export const m_iszSpawnObject = 0x8A8;
                export const m_OnHealthChanged = 0x8F8;
                export const m_PerformanceMode = 0x918;
                export const m_flPressureDelay = 0x8B0;
                export const m_hPhysicsAttacker = 0x91C;
                export const m_impactEnergyScale = 0x8C0;
                export const m_nOverrideBlockLOS = 0x8C4;
                export const m_CPropDataComponent = 0x858;
                export const m_flLastPhysicsInfluenceTime = 0x920;
            }
            export namespace CCashStack {
                export const m_nCashStackValue = 0x850;
            }
            export namespace CEnvGlobal {
                export const m_counter = 0x4D8;
                export const m_outCounter = 0x4A8;
                export const m_globalstate = 0x4C8;
                export const m_triggermode = 0x4D0;
                export const m_initialstate = 0x4D4;
            }
            export namespace CEnvSplash {
                export const m_flScale = 0x4A8;
            }
            export namespace CFilterLOS {

            }
            export namespace CFlashbang {

            }
            export namespace CFogVolume {
                export const m_fogName = 0x850;
                export const m_bDisabled = 0x870;
                export const m_postProcessName = 0x858;
                export const m_bInFogVolumesList = 0x871;
                export const m_colorCorrectionName = 0x860;
            }
            export namespace CFuncBrush {
                export const m_bSolidBsp = 0x858;
                export const m_iDisabled = 0x854;
                export const m_iSolidity = 0x850;
                export const m_bInvertExclusion = 0x868;
                export const m_iszExcludedClass = 0x860;
                export const m_bScriptedMovement = 0x869;
            }
            export namespace CFuncMover {
                export const m_flT = 0x884;
                export const m_OnStop = 0xA68;
                export const m_OnStart = 0xA20;
                export const m_flSpeed = 0x9F8;
                export const m_OnStopped = 0xA80;
                export const m_bIsMoving = 0x891;
                export const m_bIsPaused = 0x9D0;
                export const m_eMoveType = 0x874;
                export const m_bQueueStop = 0xB21;
                export const m_eSolidType = 0x890;
                export const m_hPathMover = 0x858;
                export const m_bStartAtEnd = 0x939;
                export const m_hStopAtNode = 0x8BC;
                export const m_iszPathName = 0x850;
                export const m_OnNodePassed = 0x958;
                export const m_bIsReversing = 0x878;
                export const m_flBeginStopT = 0x8C8;
                export const m_flStartSpeed = 0x87C;
                export const m_hFollowMover = 0xABC;
                export const m_OnMovementEnd = 0x920;
                export const m_hFollowEntity = 0x9FC;
                export const m_OnStartForward = 0xA38;
                export const m_OnStartReverse = 0xA50;
                export const m_bIgnoreEndNode = 0x870;
                export const m_bStartedMoving = 0xA99;
                export const m_flPathLocation = 0x880;
                export const m_hPrevPathMover = 0x85C;
                export const m_iszPathNodeEnd = 0x868;
                export const m_bIsImGuiLogging = 0x9F4;
                export const m_movementSummary = 0xB00;
                export const m_vOffsetFromPath = 0xB30;
                export const m_bQueueStopMoving = 0xB22;
                export const m_flCurFollowSpeed = 0xA0C;
                export const m_flFollowDistance = 0xA00;
                export const m_flStopCurveScale = 0x8AC;
                export const m_iszPathNodeStart = 0x860;
                export const m_nTickMovementRan = 0xAFC;
                export const m_eFollowConstraint = 0xAF0;
                export const m_flLerpToPositionT = 0x994;
                export const m_flStartCurveScale = 0x8A8;
                export const m_nCurrentNodeIndex = 0x888;
                export const m_eOrientationUpdate = 0x944;
                export const m_flCurFollowEntityT = 0xA08;
                export const m_flFollowMoverRatio = 0xAD4;
                export const m_flFollowMoverSpeed = 0xAF4;
                export const m_flTimeMovementStop = 0x8B8;
                export const m_nPreviousNodeIndex = 0x88C;
                export const m_flPathLocationStart = 0x8C4;
                export const m_flTimeMovementStart = 0x8B4;
                export const m_flTransitionSourceT = 0x9A0;
                export const m_iszFollowEntityName = 0xAC0;
                export const m_iszLoopForwardSound = 0x8D8;
                export const m_iszLoopReverseSound = 0x8F0;
                export const m_iszStopForwardSound = 0x8E0;
                export const m_iszStopReverseSound = 0x8F8;
                export const m_bQueueSetupPathMover = 0xB23;
                export const m_bStartAtClosestPoint = 0x938;
                export const m_ePathRebuildStrategy = 0xB24;
                export const m_flFollowMinimumSpeed = 0xA04;
                export const m_iszStartForwardSound = 0x8D0;
                export const m_iszStartReverseSound = 0x8E8;
                export const m_vLerpToNewPosStartWS = 0x984;
                export const m_bCreateMovableNavMesh = 0x954;
                export const m_flFollowMoverDistance = 0xAD0;
                export const m_flFollowMoverVelocity = 0xAF8;
                export const m_flTimeToReachMaxSpeed = 0x894;
                export const m_hTransitionSourcePath = 0x99C;
                export const m_bIsImGuiEntTextLogging = 0x9F5;
                export const m_eFollowEntityDirection = 0xAB8;
                export const m_flLerpToPositionDeltaT = 0x998;
                export const m_flTimeToReachZeroSpeed = 0x89C;
                export const m_hOrientationFaceEntity = 0xA18;
                export const m_nDelayedTeleportToNode = 0x9F0;
                export const m_bNextNodeReturnsCurrent = 0xA98;
                export const m_flLerpToPositionTargetT = 0x990;
                export const m_hOrientationMatchEntity = 0x980;
                export const m_OnLerpToPositionComplete = 0x9B8;
                export const m_bStopFromBeginStopTarget = 0xB20;
                export const m_bStoppedDuringTransition = 0x9B0;
                export const m_eFindFollowMoverStrategy = 0xB28;
                export const m_iszFollowMoverEntityName = 0xAC8;
                export const m_flDistanceToReachMaxSpeed = 0x898;
                export const m_flPathLocationToBeginStop = 0x8C0;
                export const m_bCreateMovableSurfaceGraph = 0x955;
                export const m_bDisableDecelerationToStop = 0xB2C;
                export const m_flDistanceToReachZeroSpeed = 0x8B0;
                export const m_vecFollowMoverCouplerRange = 0xAE4;
                export const m_bStartFollowingClosestMover = 0x93A;
                export const m_flFollowMoverSpringStrength = 0xADC;
                export const m_iszArriveAtDestinationSound = 0x900;
                export const m_flTimeStartOrientationChange = 0x948;
                export const m_qTransitionSourceOrientation = 0x9E0;
                export const m_strOrientationFaceEntityName = 0xA10;
                export const m_bFollowConstraintsInitialized = 0xAEC;
                export const m_eTransitionedToPathNodeAction = 0x9D4;
                export const m_flTimeToBlendToNewOrientation = 0x94C;
                export const m_iszOrientationMatchEntityName = 0x978;
                export const m_flTransitionSourcePathLocation = 0x9A4;
                export const m_nFollowMoverConstraintPriority = 0xAE0;
                export const m_flFollowMoverCalculatedDistance = 0xAD8;
                export const m_iszTransitionSourcePathNodeStart = 0x9A8;
                export const m_flComputedDistanceToReachMaxSpeed = 0x8A0;
                export const m_flComputedDistanceToReachZeroSpeed = 0x8A4;
                export const m_flDurationBlendToNewOrientationRan = 0x950;
                export const m_bAllowMovableNavMeshDockingOnEntireEntity = 0x956;
                export const m_flStartFollowingClosestMoverWhenWithinDistance = 0x93C;
                export const m_flStartFollowingClosestMoverWhenOutsideDistance = 0x940;
            }
            export namespace CFuncTrain {
                export const m_hEnemy = 0x900;
                export const m_flSpeed = 0x918;
                export const m_activated = 0x8FC;
                export const m_flBlockDamage = 0x904;
                export const m_iszLastTarget = 0x910;
                export const m_hCurrentTarget = 0x8F8;
                export const m_flNextBlockTime = 0x908;
            }
            export namespace CFuncWater {
                export const m_BuoyancyHelper = 0x850;
            }
            export namespace CGameMoney {
                export const m_nMoney = 0x890;
                export const m_OnMoneySpent = 0x860;
                export const m_strAwardText = 0x898;
                export const m_OnMoneySpentFail = 0x878;
            }
            export namespace CGameRules {
                export const m_bGamePaused = 0xC8;
                export const m_nQuestPhase = 0xB0;
                export const m_szQuestName = 0x30;
                export const __m_pChainEntity = 0x8;
                export const m_nLastMatchTime = 0xB4;
                export const m_nPauseStartTick = 0xC4;
                export const m_nTotalPausedTicks = 0xC0;
                export const m_nLastMatchTime_MatchID64 = 0xB8;
            }
            export namespace CGunTarget {
                export const m_on = 0x8D4;
                export const m_OnDeath = 0x8E0;
                export const m_flSpeed = 0x8D0;
                export const m_hTargetEnt = 0x8D8;
            }
            export namespace CHEGrenade {

            }
            export namespace CLogicAuto {
                export const m_OnNewGame = 0x4D8;
                export const m_OnLoadGame = 0x4F0;
                export const m_OnMapSpawn = 0x4A8;
                export const m_OnVREnabled = 0x568;
                export const m_globalstate = 0x598;
                export const m_OnMultiNewMap = 0x538;
                export const m_OnDemoMapSpawn = 0x4C0;
                export const m_OnVRNotEnabled = 0x580;
                export const m_OnBackgroundMap = 0x520;
                export const m_OnMapTransition = 0x508;
                export const m_OnMultiNewRound = 0x550;
            }
            export namespace CLogicCase {
                export const m_nCase = 0x4A8;
                export const m_OnCase = 0x5D0;
                export const m_OnDefault = 0x8D0;
                export const m_nShuffleCases = 0x5A8;
                export const m_nLastShuffleCase = 0x5AC;
                export const m_uchShuffleCaseMap = 0x5B0;
            }
            export namespace CMathRemap {
                export const m_flOut1 = 0x4B0;
                export const m_flOut2 = 0x4B4;
                export const m_flInMax = 0x4AC;
                export const m_flInMin = 0x4A8;
                export const m_OutValue = 0x4C0;
                export const m_bEnabled = 0x4BC;
                export const m_flOldInValue = 0x4B8;
                export const m_OnFellBelowMax = 0x528;
                export const m_OnFellBelowMin = 0x510;
                export const m_OnRoseAboveMax = 0x4F8;
                export const m_OnRoseAboveMin = 0x4E0;
            }
            export namespace CNavVolume {

            }
            export namespace COmniLight {
                export const m_bShowLight = 0xB40;
                export const m_flInnerAngle = 0xB38;
                export const m_flOuterAngle = 0xB3C;
            }
            export namespace CPathMover {
                export const m_vecMovers = 0x600;
                export const m_vecSpawners = 0x618;
                export const m_hMoverRouter = 0x638;
                export const m_flSampleSpacing = 0x648;
                export const m_iszMoverRouterName = 0x640;
                export const m_iszMoverSpawnerName = 0x630;
            }
            export namespace CPathTrack {
                export const m_pnext = 0x4A8;
                export const m_OnPass = 0x4D0;
                export const m_length = 0x4BC;
                export const m_altName = 0x4C0;
                export const m_flSpeed = 0x4B4;
                export const m_flRadius = 0x4B8;
                export const m_nIterVal = 0x4C8;
                export const m_paltpath = 0x4B0;
                export const m_pprevious = 0x4AC;
                export const m_eOrientationType = 0x4CC;
            }
            export namespace CPhysFixed {
                export const m_sBoneName1 = 0x520;
                export const m_sBoneName2 = 0x528;
                export const m_flLinearFrequency = 0x508;
                export const m_flAngularFrequency = 0x510;
                export const m_flLinearDampingRatio = 0x50C;
                export const m_flAngularDampingRatio = 0x514;
                export const m_bEnableLinearConstraint = 0x518;
                export const m_bEnableAngularConstraint = 0x519;
            }
            export namespace CPhysForce {
                export const m_force = 0x4B8;
                export const m_forceTime = 0x4BC;
                export const m_integrator = 0x4C8;
                export const m_nameAttach = 0x4B0;
                export const m_pController = 0x4A8;
                export const m_wasRestored = 0x4C4;
                export const m_attachedObject = 0x4C0;
            }
            export namespace CPhysHinge {
                export const m_hinge = 0x5DC;
                export const m_soundInfo = 0x510;
                export const m_bAtMaxLimit = 0x5D9;
                export const m_bAtMinLimit = 0x5D8;
                export const m_OnStopMoving = 0x660;
                export const m_bIsAxisLocal = 0x624;
                export const m_flAngleSpeed = 0x63C;
                export const m_OnStartMoving = 0x648;
                export const m_flMaxRotation = 0x62C;
                export const m_flMinRotation = 0x628;
                export const m_hingeFriction = 0x61C;
                export const m_systemLoadScale = 0x620;
                export const m_flMotorFrequency = 0x634;
                export const m_flInitialRotation = 0x630;
                export const m_flMotorDampingRatio = 0x638;
                export const m_NotifyMaxLimitReached = 0x5C0;
                export const m_NotifyMinLimitReached = 0x5A8;
                export const m_flAngleSpeedThreshold = 0x640;
                export const m_flLimitsDebugVisRotation = 0x644;
            }
            export namespace CPhysMotor {
                export const m_motor = 0x4F0;
                export const m_spinUp = 0x4C0;
                export const m_spinDown = 0x4C4;
                export const m_nameAnchor = 0x4B0;
                export const m_nameAttach = 0x4A8;
                export const m_pMotorJoint = 0x4E8;
                export const m_flTargetSpeed = 0x4D8;
                export const m_flTorqueScale = 0x4D4;
                export const m_hAnchorObject = 0x4BC;
                export const m_flMotorFriction = 0x4C8;
                export const m_hAttachedObject = 0x4B8;
                export const m_pFixedWorldBody = 0x4E0;
                export const m_angularAcceleration = 0x4D0;
                export const m_additionalAcceleration = 0x4CC;
                export const m_flSpeedWhenSpinUpOrSpinDownStarted = 0x4DC;
            }
            export namespace CPlantedC4 {
                export const m_flC4Blow = 0xA9C;
                export const m_nBombSite = 0xAA0;
                export const m_nSpotRules = 0xF50;
                export const m_bBombDefused = 0xF55;
                export const m_bBombTicking = 0xA98;
                export const m_bHasExploded = 0xF54;
                export const m_hBombDefuser = 0xF74;
                export const m_OnBombDefused = 0xEE8;
                export const m_bBeingDefused = 0xF5C;
                export const m_flTimerLength = 0xF58;
                export const m_flDefuseLength = 0xF6C;
                export const m_fLastDefuseTime = 0xF64;
                export const m_AttributeManager = 0xAB0;
                export const m_bCannotBeDefused = 0xF30;
                export const m_bVoiceAlertFired = 0xF7C;
                export const m_iProgressBarTime = 0xF78;
                export const m_OnBombBeginDefuse = 0xF00;
                export const m_bVoiceAlertPlayed = 0xF7D;
                export const m_flDefuseCountDown = 0xF70;
                export const m_flNextBotBeepTime = 0xF84;
                export const m_entitySpottedState = 0xF38;
                export const m_OnBombDefuseAborted = 0xF18;
                export const m_angCatchUpToPlayerEye = 0xF8C;
                export const m_nSourceSoundscapeHash = 0xAA4;
                export const m_bTrainingPlacedByPlayer = 0xF56;
                export const m_flLastSpinDetectionTime = 0xF98;
                export const m_bAbortDetonationBecauseWorldIsFrozen = 0xAA8;
            }
            export namespace CPointHurt {
                export const m_flDelay = 0x4B4;
                export const m_nDamage = 0x4A8;
                export const m_flRadius = 0x4B0;
                export const m_strTarget = 0x4B8;
                export const m_pActivator = 0x4C0;
                export const m_bitsDamageType = 0x4AC;
            }
            export namespace CPointPush {
                export const m_hFilter = 0x4C8;
                export const m_bEnabled = 0x4A8;
                export const m_flRadius = 0x4B0;
                export const m_flMagnitude = 0x4AC;
                export const m_flInnerRadius = 0x4B4;
                export const m_iszFilterName = 0x4C0;
                export const m_flConeOfInfluence = 0x4B8;
            }
            export namespace CRectLight {
                export const m_bShowLight = 0xB38;
            }
            export namespace CRotButton {

            }
            export namespace CSkyCamera {
                export const m_pNext = 0x540;
                export const m_bUseAngles = 0x53C;
                export const m_skyboxData = 0x4A8;
                export const m_skyboxSlotToken = 0x538;
            }
            export namespace CStopwatch {
                export const m_flInterval = 0xC;
            }
            export namespace CWeaponAWP {

            }
            export namespace CWeaponAug {

            }
            export namespace CWeaponMP7 {

            }
            export namespace CWeaponMP9 {

            }
            export namespace CWeaponP90 {

            }
            export namespace SpawnPoint {
                export const m_nType = 0x4B0;
                export const m_bEnabled = 0x4AC;
                export const m_iPriority = 0x4A8;
            }
            export namespace lerpdata_t {
                export const m_hEnt = 0x0;
                export const m_MoveType = 0x4;
                export const m_nFXIndex = 0x30;
                export const m_qStartRot = 0x20;
                export const m_flStartTime = 0x8;
                export const m_vecStartOrigin = 0xC;
            }
            export namespace AmmoIndex_t {
                export const m_Value = 0x0;
            }
            export namespace CBaseButton {
                export const m_ls = 0x8E0;
                export const m_OnIn = 0x978;
                export const m_OnOut = 0x990;
                export const m_nState = 0x9A8;
                export const m_usable = 0x9C4;
                export const m_bLocked = 0x920;
                export const m_flSpeed = 0x924;
                export const m_OnDamaged = 0x930;
                export const m_OnPressed = 0x948;
                export const m_bDisabled = 0x921;
                export const m_bSolidBsp = 0x92C;
                export const m_fRotating = 0x8DD;
                export const m_sUseSound = 0x900;
                export const m_glowEntity = 0x9C0;
                export const m_OnUseLocked = 0x960;
                export const m_fStayPushed = 0x8DC;
                export const m_hConstraint = 0x9AC;
                export const m_sGlowEntity = 0x9B8;
                export const m_sLockedSound = 0x908;
                export const m_szDisplayText = 0x9C8;
                export const m_sUnlockedSound = 0x910;
                export const m_flUseLockedTime = 0x928;
                export const m_bForceNpcExclude = 0x9B4;
                export const m_hConstraintParent = 0x9B0;
                export const m_angMoveEntitySpace = 0x8D0;
                export const m_sOverrideAnticipationName = 0x918;
            }
            export namespace CBaseEntity {
                export const m_think = 0x288;
                export const m_fFlags = 0x388;
                export const m_pfnUse = 0x2B8;
                export const m_target = 0x300;
                export const m_OnUser1 = 0x418;
                export const m_OnUser2 = 0x430;
                export const m_OnUser3 = 0x448;
                export const m_OnUser4 = 0x460;
                export const m_iEFlags = 0x414;
                export const m_iHealth = 0x2D0;
                export const m_MoveType = 0x2F3;
                export const m_OnKilled = 0x370;
                export const m_fEffects = 0x3E8;
                export const m_iTeamNum = 0x344;
                export const m_pBlocker = 0x490;
                export const m_pfnTouch = 0x2B0;
                export const m_lifeState = 0x2D8;
                export const m_flAnimTime = 0x328;
                export const m_flFriction = 0x3F4;
                export const m_iMaxHealth = 0x2D4;
                export const m_nBloodType = 0x49C;
                export const m_nWaterType = 0x412;
                export const m_pCollision = 0x3D8;
                export const m_pfnBlocked = 0x2C0;
                export const m_spawnflags = 0x360;
                export const m_MoveCollide = 0x2F2;
                export const m_flLocalTime = 0x494;
                export const m_flTimeScale = 0x400;
                export const m_iGlobalname = 0x348;
                export const m_nSlimeTouch = 0x2F7;
                export const m_nSubclassID = 0x31C;
                export const m_nWaterTouch = 0x2F6;
                export const m_pfnMoveDone = 0x2C8;
                export const m_vecVelocity = 0x398;
                export const m_bTakesDamage = 0x2E0;
                export const m_flCreateTime = 0x330;
                export const m_flElasticity = 0x3F8;
                export const m_flWaterLevel = 0x404;
                export const m_hOwnerEntity = 0x3E4;
                export const m_hDamageFilter = 0x308;
                export const m_hEffectEntity = 0x3E0;
                export const m_hGroundEntity = 0x3EC;
                export const m_isSteadyState = 0x278;
                export const m_nPlatformType = 0x2F0;
                export const m_CBodyComponent = 0x30;
                export const m_bLagCompensate = 0x48D;
                export const m_flGravityScale = 0x3FC;
                export const m_flMoveDoneTime = 0x318;
                export const m_iSentToClients = 0x350;
                export const m_nLastThinkTick = 0x264;
                export const m_nNextThinkTick = 0x364;
                export const m_nPushEnumCount = 0x3D4;
                export const m_vecAbsVelocity = 0x38C;
                export const m_vecAngVelocity = 0x480;
                export const m_aThinkFunctions = 0x248;
                export const m_iInitialTeamNum = 0x478;
                export const m_nActualMoveType = 0x2F5;
                export const m_nSimulationTick = 0x368;
                export const m_sUniqueHammerID = 0x358;
                export const m_vecBaseVelocity = 0x3C8;
                export const m_ResponseContexts = 0x290;
                export const m_bGravityDisabled = 0x408;
                export const m_flSimulationTime = 0x32C;
                export const m_nGroundBodyIndex = 0x3F0;
                export const m_nTakeDamageFlags = 0x2E8;
                export const m_lastNetworkChange = 0x280;
                export const m_bAnimatedEveryTick = 0x409;
                export const m_bClientSideRagdoll = 0x334;
                export const m_iszResponseContext = 0x2A8;
                export const m_bDisableLowViolence = 0x411;
                export const m_bRestoreInHierarchy = 0x2F8;
                export const m_flDamageAccumulator = 0x2DC;
                export const m_iszDamageFilterName = 0x310;
                export const m_pPulseGraphInstance = 0x4A0;
                export const m_flActualGravityScale = 0x40C;
                export const m_flNavIgnoreUntilTime = 0x47C;
                export const m_iCurrentThinkContext = 0x260;
                export const m_ubInterpolationFrame = 0x335;
                export const m_bDisabledContextThinks = 0x268;
                export const m_nPreviouslySetMoveType = 0x2F4;
                export const m_vPrevVPhysicsUpdatePos = 0x338;
                export const m_NetworkTransmitComponent = 0x38;
                export const m_bGravityActuallyDisabled = 0x410;
                export const m_flVPhysicsUpdateLocalTime = 0x498;
                export const m_bNetworkQuantizeOriginAndAngles = 0x48C;
            }
            export namespace CBaseFilter {
                export const m_OnFail = 0x4C8;
                export const m_OnPass = 0x4B0;
                export const m_bNegated = 0x4A8;
            }
            export namespace CBaseToggle {
                export const m_flLip = 0x85C;
                export const m_flWait = 0x858;
                export const m_sMaster = 0x8C8;
                export const m_flHeight = 0x8A0;
                export const m_vecAngle1 = 0x888;
                export const m_vecAngle2 = 0x894;
                export const m_hActivator = 0x8A4;
                export const m_vecMoveAng = 0x87C;
                export const m_movementType = 0x8C0;
                export const m_toggle_state = 0x850;
                export const m_vecFinalDest = 0x8A8;
                export const m_vecPosition1 = 0x864;
                export const m_vecPosition2 = 0x870;
                export const m_vecFinalAngle = 0x8B4;
                export const m_flMoveDistance = 0x854;
                export const m_bAlwaysFireBlockedOutputs = 0x860;
            }
            export namespace CBombTarget {
                export const m_bIsBombSiteB = 0xA10;
                export const m_OnBombDefused = 0x9F8;
                export const m_OnBombExplode = 0x9C8;
                export const m_OnBombPlanted = 0x9E0;
                export const m_szMountTarget = 0xA18;
                export const m_hInstructorHint = 0xA20;
                export const m_bBombPlantedHere = 0xA12;
                export const m_bIsHeistBombTarget = 0xA11;
                export const m_nBombSiteDesignation = 0xA24;
            }
            export namespace CEconEntity {
                export const m_hOldProvidee = 0xEA8;
                export const m_nFallbackSeed = 0xE9C;
                export const m_flFallbackWear = 0xEA0;
                export const m_iOldOwnerClass = 0xEAC;
                export const m_AttributeManager = 0xA58;
                export const m_nFallbackPaintKit = 0xE98;
                export const m_nFallbackStatTrak = 0xEA4;
                export const m_OriginalOwnerXuidLow = 0xE90;
                export const m_OriginalOwnerXuidHigh = 0xE94;
            }
            export namespace CEffectData {
                export const m_fFlags = 0x63;
                export const m_nColor = 0x62;
                export const m_vStart = 0x14;
                export const m_flScale = 0x40;
                export const m_hEntity = 0x38;
                export const m_nHitBox = 0x60;
                export const m_vAngles = 0x2C;
                export const m_vNormal = 0x20;
                export const m_vOrigin = 0x8;
                export const m_flRadius = 0x48;
                export const m_nMaterial = 0x5E;
                export const m_nPenetrate = 0x5C;
                export const m_flMagnitude = 0x44;
                export const m_iEffectName = 0x6C;
                export const m_nDamageType = 0x58;
                export const m_hOtherEntity = 0x3C;
                export const m_nEffectIndex = 0x50;
                export const m_nSurfaceProp = 0x4C;
                export const m_nAttachmentName = 0x68;
                export const m_nAttachmentIndex = 0x64;
            }
            export namespace CEnvCubemap {
                export const m_Entity_bEnabled = 0x588;
                export const m_Entity_bMoveable = 0x550;
                export const m_Entity_nPriority = 0x55C;
                export const m_Entity_nHandshake = 0x554;
                export const m_Entity_bDefaultEnvMap = 0x575;
                export const m_Entity_bIndoorCubeMap = 0x577;
                export const m_Entity_bStartDisabled = 0x574;
                export const m_Entity_flDiffuseScale = 0x570;
                export const m_Entity_flEdgeFadeDist = 0x560;
                export const m_Entity_vEdgeFadeDists = 0x564;
                export const m_Entity_hCubemapTexture = 0x528;
                export const m_Entity_vBoxProjectMaxs = 0x544;
                export const m_Entity_vBoxProjectMins = 0x538;
                export const m_Entity_flInfluenceRadius = 0x534;
                export const m_Entity_bDefaultSpecEnvMap = 0x576;
                export const m_Entity_bCustomCubemapTexture = 0x530;
                export const m_Entity_nEnvCubeMapArrayIndex = 0x558;
                export const m_Entity_bCopyDiffuseFromDefaultCubemap = 0x578;
            }
            export namespace CEnvHudHint {
                export const m_iszMessage = 0x4A8;
            }
            export namespace CFilterName {
                export const m_iFilterName = 0x4E0;
            }
            export namespace CFilterTeam {
                export const m_iFilterTeam = 0x4E0;
            }
            export namespace CFogTrigger {
                export const m_fog = 0x9C8;
            }
            export namespace CFuncLadder {
                export const m_Dismounts = 0x860;
                export const m_bDisabled = 0x8A0;
                export const m_bHasSlack = 0x8A2;
                export const m_bFakeLadder = 0x8A1;
                export const m_vecLocalTop = 0x878;
                export const m_vecLadderDir = 0x850;
                export const m_flAutoRideSpeed = 0x89C;
                export const m_surfacePropName = 0x8A8;
                export const m_OnPlayerGotOnLadder = 0x8B0;
                export const m_OnPlayerGotOffLadder = 0x8C8;
                export const m_vecPlayerMountPositionTop = 0x884;
                export const m_vecPlayerMountPositionBottom = 0x890;
            }
            export namespace CHandleTest {
                export const m_Handle = 0x4A8;
                export const m_bSendHandle = 0x4AC;
            }
            export namespace CInfoTarget {

            }
            export namespace CItemKevlar {

            }
            export namespace CLogicRelay {
                export const m_OnSpawn = 0x4A8;
                export const m_OnTrigger = 0x4C0;
                export const m_bDisabled = 0x4D8;
                export const m_bTriggerOnce = 0x4DA;
                export const m_bFastRetrigger = 0x4DB;
                export const m_bWaitForRefire = 0x4D9;
                export const m_bPassthoughCaller = 0x4DC;
            }
            export namespace CModelState {
                export const m_hModel = 0xA0;
                export const m_ModelName = 0xA8;
                export const m_nForceLOD = 0x283;
                export const m_MeshGroupMask = 0x1E8;
                export const m_nIdealMotionType = 0x282;
                export const m_nBodyGroupChoices = 0x238;
                export const m_nClothUpdateFlags = 0x284;
                export const m_flRootBoneOffset_x = 0xE8;
                export const m_flRootBoneOffset_y = 0xEC;
                export const m_flRootBoneOffset_z = 0xF0;
                export const m_pVPhysicsAggregate = 0xE0;
                export const m_bClientClothCreationSuppressed = 0xF5;
                export const m_nAnimStateNoInterpSerialNumber = 0x1E0;
                export const m_nRootBoneOffsetResetSerialNumber = 0xF4;
            }
            export namespace CNullEntity {

            }
            export namespace CPathCorner {
                export const m_OnPass = 0x4C8;
                export const m_flWait = 0x4AC;
                export const m_flSpeed = 0x4C0;
                export const m_flRadius = 0x4B0;
                export const m_bSmoothArrival = 0x4A9;
                export const m_bExactPositioning = 0x4AA;
                export const m_bTriggerLocomotionStop = 0x4A8;
                export const m_flWaypointSuccessRadius = 0x4B8;
                export const m_flPathEndDistanceFromGoal = 0x4BC;
                export const m_flWaypointSuccessRadiusWhenBlocked = 0x4B4;
            }
            export namespace CPathSimple {
                export const m_pathString = 0x5A0;
                export const m_bClosedLoop = 0x5A8;
                export const m_CPathQueryComponent = 0x4B0;
            }
            export namespace CPhysImpact {
                export const m_damage = 0x4A8;
                export const m_distance = 0x4AC;
                export const m_directionEntityName = 0x4B0;
            }
            export namespace CPhysLength {
                export const m_offset = 0x508;
                export const m_addLength = 0x52C;
                export const m_minLength = 0x530;
                export const m_vecAttach = 0x520;
                export const m_totalLength = 0x534;
            }
            export namespace CPhysMagnet {
                export const m_bActive = 0xA98;
                export const m_flRadius = 0xAA0;
                export const m_massScale = 0xA70;
                export const m_forceLimit = 0xA74;
                export const m_flTotalMass = 0xA9C;
                export const m_torqueLimit = 0xA78;
                export const m_OnMagnetAttach = 0xA40;
                export const m_OnMagnetDetach = 0xA58;
                export const m_flNextSuckTime = 0xAA4;
                export const m_bHasHitSomething = 0xA99;
                export const m_MagnettedEntities = 0xA80;
                export const m_iMaxObjectsAttached = 0xAA8;
            }
            export namespace CPhysPulley {
                export const m_offset = 0x514;
                export const m_addLength = 0x52C;
                export const m_gearRatio = 0x530;
                export const m_position2 = 0x508;
            }
            export namespace CPhysTorque {
                export const m_axis = 0x508;
            }
            export namespace CPlayerPing {
                export const m_iType = 0x4B8;
                export const m_bUrgent = 0x4BC;
                export const m_hPlayer = 0x4B0;
                export const m_szPlaceName = 0x4BD;
                export const m_hPingedEntity = 0x4B4;
            }
            export namespace CPointPulse {

            }
            export namespace CRangeFloat {
                export const m_pValue = 0x0;
            }
            export namespace CRemapFloat {
                export const m_pValue = 0x0;
            }
            export namespace CRuleEntity {
                export const m_iszMaster = 0x850;
            }
            export namespace CScriptItem {
                export const m_MoveTypeOverride = 0xAE0;
            }
            export namespace CSkillFloat {
                export const m_pValue = 0x0;
            }
            export namespace CSmoothFunc {
                export const m_nSmoothDir = 0x18;
                export const m_flSmoothBias = 0xC;
                export const m_flSmoothDuration = 0x10;
                export const m_flSmoothAmplitude = 0x8;
                export const m_flSmoothRemainingTime = 0x14;
            }
            export namespace CSoundPatch {
                export const m_hEnt = 0x50;
                export const m_pitch = 0x8;
                export const m_Filter = 0x68;
                export const m_volume = 0x18;
                export const m_isPlaying = 0x64;
                export const m_flLastTime = 0x40;
                export const m_soundOrigin = 0x58;
                export const m_iszClassName = 0xA8;
                export const m_shutdownTime = 0x3C;
                export const m_soundEntityIndex = 0x54;
                export const m_iszSoundScriptName = 0x48;
                export const m_bUpdatedSoundOrigin = 0xA4;
                export const m_flCloseCaptionDuration = 0xA0;
            }
            export namespace CTestEffect {
                export const m_iBeam = 0x4AC;
                export const m_iLoop = 0x4A8;
                export const m_pBeam = 0x4B0;
                export const m_flBeamTime = 0x510;
                export const m_flStartTime = 0x570;
            }
            export namespace CTriggerFan {
                export const m_flForce = 0xA04;
                export const m_bFalloff = 0xA08;
                export const m_hInfoFan = 0xA00;
                export const m_RampTimer = 0xA10;
                export const m_bRampDown = 0xA81;
                export const m_vFanEndLS = 0xA40;
                export const m_flNPCForce = 0xA70;
                export const m_flRampTime = 0xA74;
                export const m_iszInfoFan = 0xA58;
                export const m_vDirection = 0x9D4;
                export const m_bPushPlayer = 0xA80;
                export const m_fNoiseSpeed = 0xA7C;
                export const m_qNoiseDelta = 0x9F0;
                export const m_vFanOriginLS = 0xA34;
                export const m_vFanOriginWS = 0xA28;
                export const m_fNoiseDegrees = 0xA78;
                export const m_flPlayerForce = 0xA68;
                export const m_nManagerFanIdx = 0xA84;
                export const m_bPlayerWindblock = 0xA6C;
                export const m_flRopeForceScale = 0xA60;
                export const m_vFanOriginOffset = 0x9C8;
                export const m_flParticleForceScale = 0xA64;
                export const m_vNoiseDirectionTarget = 0xA4C;
                export const m_bPushTowardsInfoTarget = 0x9E0;
                export const m_bPushAwayFromInfoTarget = 0x9E1;
            }
            export namespace CWeaponM249 {

            }
            export namespace CWeaponM4A1 {

            }
            export namespace CWeaponMag7 {

            }
            export namespace CWeaponNOVA {

            }
            export namespace CWeaponP250 {

            }
            export namespace CWeaponTec9 {

            }
            export namespace GAME_HEADER {
                export const m_sComment = 0x0;
                export const m_sLandmark = 0x10;
                export const m_sRequiredAddons = 0x18;
                export const m_nSpawnGroupCount = 0x8;
            }
            export namespace HullFlags_t {
                export const m_bHull_Tiny = 0x3;
                export const m_bHull_Human = 0x0;
                export const m_bHull_Large = 0x6;
                export const m_bHull_Small = 0x9;
                export const m_bHull_Medium = 0x4;
                export const m_bHull_WideHuman = 0x2;
                export const m_bHull_MediumTall = 0x8;
                export const m_bHull_TinyCentered = 0x5;
                export const m_bHull_LargeCentered = 0x7;
                export const m_bHull_SmallCentered = 0x1;
            }
            export namespace SAVE_HEADER {
                export const m_saveId = 0x0;
                export const m_version = 0x4;
                export const m_flSaveTime = 0x50;
                export const m_nMapVersion = 0xC;
                export const m_vecWorldOffset = 0x20;
                export const m_sSpawnGroupName = 0x10;
                export const m_nConnectionCount = 0x8;
            }
            export namespace fogparams_t {
                export const end = 0x28;
                export const farz = 0x2C;
                export const blend = 0x65;
                export const start = 0x24;
                export const enable = 0x64;
                export const duration = 0x54;
                export const exponent = 0x34;
                export const lerptime = 0x50;
                export const endLerpTo = 0x48;
                export const dirPrimary = 0x8;
                export const m_bPadding = 0x67;
                export const maxdensity = 0x30;
                export const scattering = 0x5C;
                export const m_bPadding2 = 0x66;
                export const startLerpTo = 0x44;
                export const colorPrimary = 0x14;
                export const HDRColorScale = 0x38;
                export const colorSecondary = 0x18;
                export const locallightscale = 0x60;
                export const skyboxFogFactor = 0x3C;
                export const maxdensityLerpTo = 0x4C;
                export const blendtobackground = 0x58;
                export const colorPrimaryLerpTo = 0x1C;
                export const colorSecondaryLerpTo = 0x20;
                export const skyboxFogFactorLerpTo = 0x40;
            }
            export namespace levellist_t {
                export const m_sMapName = 0x0;
                export const m_hEntLandmark = 0x10;
                export const m_sLandmarkName = 0x8;
                export const m_vecLandmarkAngles = 0x20;
                export const m_vecLandmarkOrigin = 0x14;
            }
            export namespace locksound_t {
                export const flwaitSound = 0x18;
                export const sLockedSound = 0x8;
                export const sUnlockedSound = 0x10;
            }
            export namespace thinkfunc_t {
                export const m_hFn = 0x8;
                export const m_think = 0x0;
                export const m_nContext = 0x10;
                export const m_nLastThinkTick = 0x18;
                export const m_nNextThinkTick = 0x14;
            }
            export namespace CBaseDMStart {
                export const m_Master = 0x4A8;
            }
            export namespace CBaseGrenade {
                export const m_bIsLive = 0xA82;
                export const m_flDamage = 0xA90;
                export const m_hThrower = 0xAA8;
                export const m_DmgRadius = 0xA84;
                export const m_OnExplode = 0xA68;
                export const m_bHasWarnedAI = 0xA80;
                export const m_flNextAttack = 0xAC0;
                export const m_flWarnAITime = 0xA8C;
                export const m_ExplosionSound = 0xAA0;
                export const m_OnPlayerPickup = 0xA50;
                export const m_flDetonateTime = 0xA88;
                export const m_iszBounceSound = 0xA98;
                export const m_bIsSmokeGrenade = 0xA81;
                export const m_hOriginalThrower = 0xAC4;
                export const m_bDamageDetonating = 0xA48;
            }
            export namespace CBaseTrigger {
                export const m_hFilter = 0x9B0;
                export const m_bDisabled = 0x9B4;
                export const m_OnEndTouch = 0x900;
                export const m_OnTouching = 0x930;
                export const m_iFilterName = 0x9A8;
                export const m_OnStartTouch = 0x8D0;
                export const m_OnEndTouchAll = 0x918;
                export const m_OnNotTouching = 0x960;
                export const m_OnStartTouchAll = 0x8E8;
                export const m_bUseAsyncQueries = 0x9C0;
                export const m_OnTouchingChanged = 0x978;
                export const m_hTouchingEntities = 0x990;
                export const m_OnTouchingEachEntity = 0x948;
            }
            export namespace CBtActionAim {
                export const m_AimTimer = 0xA8;
                export const m_bAcquired = 0xF0;
                export const m_bDoneAiming = 0x8C;
                export const m_szAimReadyKey = 0x80;
                export const m_NextLookTarget = 0x9C;
                export const m_SniperHoldTimer = 0xC0;
                export const m_flLerpStartTime = 0x90;
                export const m_szSensorInputKey = 0x68;
                export const m_FocusIntervalTimer = 0xD8;
                export const m_flPenaltyReductionRatio = 0x98;
                export const m_flZoomCooldownTimestamp = 0x88;
                export const m_flNextLookTargetLerpTime = 0x94;
            }
            export namespace CCSGameRules {
                export const m_iNumCT = 0xD90;
                export const m_bLogoMap = 0x13D;
                export const m_bTCantBuy = 0xA4C;
                export const m_gamePhase = 0x11C;
                export const m_bCTCantBuy = 0xA4D;
                export const m_bIsValveDS = 0x13C;
                export const m_iAccountCT = 0xE80;
                export const m_iMaxNumCTs = 0xE90;
                export const m_iRoundTime = 0x100;
                export const m_MatchDevice = 0x144;
                export const m_RetakeRules = 0x1140;
                export const m_bVoteCalled = 0xEF0;
                export const m_iFreezeTime = 0xFC;
                export const m_nCTTimeOuts = 0xF4;
                export const m_bBombDefused = 0xF01;
                export const m_bBombDropped = 0xA40;
                export const m_bBombPlanted = 0x95F;
                export const m_bGameRestart = 0x110;
                export const m_bNoCTsKilled = 0xEB5;
                export const m_vMinimapMaxs = 0xCC4;
                export const m_vMinimapMins = 0xCB8;
                export const m_CTSpawnPoints = 0xFA8;
                export const m_bBuyTimeEnded = 0xEF8;
                export const m_bFreezePeriod = 0xD8;
                export const m_bIsHltvActive = 0x95E;
                export const m_bTargetBombed = 0xF00;
                export const m_bWarmupPeriod = 0xD9;
                export const m_firstKillTime = 0xEBC;
                export const m_iNumTerrorist = 0xD8C;
                export const m_numBestOfMaps = 0xA38;
                export const m_bCompleteReset = 0xDBD;
                export const m_bMapHasBuyZone = 0x133;
                export const m_fAvgPlayerRank = 0xDEC;
                export const m_firstBloodTime = 0xEC4;
                export const m_nMatchEndCount = 0x13B8;
                export const m_nRoundEndCount = 0x140C;
                export const m_pGameModeRules = 0x1098;
                export const m_szMatchStatTxt = 0x550;
                export const m_bFirstConnected = 0xDBC;
                export const m_bMapHasBombZone = 0xF02;
                export const m_eRoundEndReason = 0x13D4;
                export const m_eRoundWinReason = 0xA48;
                export const m_endMatchOnThink = 0xD89;
                export const m_fMatchStartTime = 0x104;
                export const m_fRoundStartTime = 0x108;
                export const m_flGameStartTime = 0x114;
                export const m_flLastThinkTime = 0x1024;
                export const m_hPlayerResource = 0x1138;
                export const m_iNumSpawnableCT = 0xD98;
                export const m_iRoundEndLegacy = 0x1408;
                export const m_iRoundWinStatus = 0xA44;
                export const m_ullLocalMatchID = 0xCF0;
                export const m_bCTTimeOutActive = 0xE5;
                export const m_bHasMatchStarted = 0x148;
                export const m_bIsDroppingItems = 0x95C;
                export const m_bIsQuestEligible = 0x95D;
                export const m_bNoEnemiesKilled = 0xEB6;
                export const m_bRoundEndNoMusic = 0x1404;
                export const m_bTeamIntroPeriod = 0x13C4;
                export const m_fWarmupPeriodEnd = 0xDC;
                export const m_hostageWasKilled = 0xEE1;
                export const m_iHostagesRescued = 0xEA8;
                export const m_iHostagesTouched = 0xEAC;
                export const m_nOvertimePlaying = 0x128;
                export const m_nRoundStartCount = 0x1414;
                export const m_sRoundEndMessage = 0x13F8;
                export const m_bCanDonateWeapons = 0xEB7;
                export const m_bLevelInitialized = 0xD7C;
                export const m_bMapHasBombTarget = 0x131;
                export const m_bMapHasRescueZone = 0x132;
                export const m_bTechnicalTimeOut = 0xF8;
                export const m_flNextRespawnWave = 0xC38;
                export const m_hostageWasInjured = 0xEE0;
                export const m_iAccountTerrorist = 0xE7C;
                export const m_iMaxNumTerrorists = 0xE8C;
                export const m_iNextCTSpawnPoint = 0xF94;
                export const m_iUnBalancedRounds = 0xD84;
                export const m_totalRoundsPlayed = 0x120;
                export const m_vecMainCTSpawnPos = 0xF50;
                export const mTeamDMLastThinkTime = 0xE74;
                export const m_BtGlobalBlackboard = 0x10A0;
                export const m_bAllowWeaponSwitch = 0x1018;
                export const m_bAnyHostageReached = 0x130;
                export const m_bPlayedTeamIntroVO = 0x13CC;
                export const m_bServerVoteOnReset = 0xEF1;
                export const m_fWarmupPeriodStart = 0xE0;
                export const m_flRestartRoundTime = 0x10C;
                export const m_iHostagesRemaining = 0x12C;
                export const m_iRoundEndTimerTime = 0x13DC;
                export const m_iTotalRoundsPlayed = 0xD80;
                export const m_nEndMatchTiedVotes = 0xDC8;
                export const m_nLastFreezeEndBeep = 0xEFC;
                export const m_nMatchInfoShowType = 0xE50;
                export const m_nNextMapInMapgroup = 0x14C;
                export const m_nTTeamIntroVariant = 0x13BC;
                export const m_nTerroristTimeOuts = 0xF0;
                export const m_bNoTerroristsKilled = 0xEB4;
                export const m_bSwapTeamsOnRestart = 0xDC0;
                export const m_fTeamIntroPeriodEnd = 0x13C8;
                export const m_flVoteCheckThrottle = 0xEF4;
                export const m_iRoundEndWinnerTeam = 0x13D0;
                export const m_iSpawnPointCount_CT = 0xE88;
                export const m_iSpectatorSlotCount = 0x140;
                export const m_nCTTeamIntroVariant = 0x13C0;
                export const m_tmNextPeriodicThink = 0xE98;
                export const m_TeamRespawnWaveTimes = 0xBB8;
                export const m_TerroristSpawnPoints = 0xFC0;
                export const m_bIsQueuedMatchmaking = 0x134;
                export const m_bPickNewTeamsOnReset = 0xDBE;
                export const m_endMatchOnRoundReset = 0xD88;
                export const m_flCTTimeOutRemaining = 0xEC;
                export const m_flLastPerfSampleTime = 0x5420;
                export const m_iRoundEndPlayerCount = 0x1400;
                export const m_flIntermissionEndTime = 0xD78;
                export const m_iRoundEndFunFactData1 = 0x13EC;
                export const m_iRoundEndFunFactData2 = 0x13F0;
                export const m_iRoundEndFunFactData3 = 0x13F4;
                export const m_numSpectatorsCountMax = 0xDFC;
                export const m_sRoundEndFunFactToken = 0x13E0;
                export const m_szTournamentEventName = 0x150;
                export const m_bForceTeamChangeSilent = 0xE18;
                export const m_bHasHostageBeenTouched = 0xD70;
                export const m_bMatchWaitingForResume = 0xF9;
                export const m_flCTSpawnPointUsedTime = 0xF98;
                export const m_flMatchInfoDecidedTime = 0xE54;
                export const m_iNumConsecutiveCTLoses = 0xD4C;
                export const m_iNumSpawnableTerrorist = 0xD94;
                export const m_iRoundStartRoundNumber = 0x1410;
                export const m_nEndMatchMapVoteWinner = 0xD48;
                export const m_nHalloweenMaskListSeed = 0xA3C;
                export const m_nQueuedMatchmakingMode = 0x138;
                export const m_nRoundsPlayedThisPhase = 0x124;
                export const m_nSpawnPointsRandomSeed = 0xDB8;
                export const m_szTournamentEventStage = 0x350;
                export const m_CTSpawnPointsMasterList = 0xF60;
                export const m_bIsUnreservedGameServer = 0xFD8;
                export const m_bLoadingRoundBackupData = 0xE19;
                export const m_bScrambleTeamsOnRestart = 0xDBF;
                export const m_bTerroristTimeOutActive = 0xE4;
                export const m_bVoiceWonMatchBragFired = 0xE9C;
                export const m_fAutobalanceDisplayTime = 0xFDC;
                export const m_flIntermissionStartTime = 0xD74;
                export const m_numSpectatorsCountMaxTV = 0xE00;
                export const m_numTotalTournamentDrops = 0xDF8;
                export const m_arrProhibitedItemIndices = 0x960;
                export const m_bRoundEndShowTimerDefend = 0x13D8;
                export const m_iMatchStats_RoundResults = 0xA50;
                export const m_iNextTerroristSpawnPoint = 0xF9C;
                export const m_nCTsAliveAtFreezetimeEnd = 0xE10;
                export const m_nMatchAbortedEarlyReason = 0x1078;
                export const m_numSpectatorsCountMaxLnk = 0xE04;
                export const m_timeUntilNextPhaseStarts = 0x118;
                export const m_fWarmupNextChatNoticeTime = 0xEA0;
                export const m_flNextHostageAnnouncement = 0xEB0;
                export const m_iLoserBonusMostRecentTeam = 0xE94;
                export const m_nTournamentPredictionsPct = 0x950;
                export const mTeamDMLastWinningTeamNumber = 0xE70;
                export const m_bPlayAllStepSoundsOnServer = 0x13E;
                export const m_bRoundTimeWarningTriggered = 0x1019;
                export const m_fAccumulatedRoundOffDamage = 0x1028;
                export const m_flCMMItemDropRevealEndTime = 0x958;
                export const m_iMatchStats_PlayersAlive_T = 0xB40;
                export const m_iRoundEndFunFactPlayerSlot = 0x13E8;
                export const m_iSpawnPointCount_Terrorist = 0xE84;
                export const m_nEndMatchMapGroupVoteTypes = 0xCF8;
                export const m_szTournamentPredictionsTxt = 0x750;
                export const m_bSwitchingTeamsAtRoundReset = 0x107D;
                export const m_flTerroristTimeOutRemaining = 0xE8;
                export const m_iMatchStats_PlayersAlive_CT = 0xAC8;
                export const m_phaseChangeAnnouncementTime = 0x101C;
                export const m_bHasTriggeredRoundStartMusic = 0x107C;
                export const m_fNextUpdateTeamClanNamesTime = 0x1020;
                export const m_flCMMItemDropRevealStartTime = 0x954;
                export const m_flTeamDMLastAnnouncementTime = 0xE78;
                export const m_nEndMatchMapGroupVoteOptions = 0xD20;
                export const m_numQueuedMatchmakingAccounts = 0xDE8;
                export const m_MinimapVerticalSectionHeights = 0xCD0;
                export const m_arrTeamUniqueKillWeaponsMatch = 0x1330;
                export const m_flTerroristSpawnPointUsedTime = 0xFA0;
                export const m_iNumConsecutiveTerroristLoses = 0xD50;
                export const m_TerroristSpawnPointsMasterList = 0xF78;
                export const m_arrSelectedHostageSpawnIndices = 0xDA0;
                export const m_nShorthandedBonusLastEvalRound = 0x102C;
                export const m_nTerroristsAliveAtFreezetimeEnd = 0xE14;
                export const m_bNeedToAskPlayersForContinueVote = 0xDE4;
                export const m_bRespawningAllRespawnablePlayers = 0xF90;
                export const m_arrTournamentActiveCasterAccounts = 0xA28;
                export const m_bTeamLastKillUsedUniqueWeaponMatch = 0x1390;
                export const m_pQueuedMatchmakingReservationString = 0xDF0;
            }
            export namespace CChangeLevel {
                export const m_bNoTouch = 0x9F1;
                export const m_bTouched = 0x9F0;
                export const m_sMapName = 0x9C8;
                export const m_bNewChapter = 0x9F2;
                export const m_OnChangeLevel = 0x9D8;
                export const m_sLandmarkName = 0x9D0;
                export const m_bOnChangeLevelFired = 0x9F3;
            }
            export namespace CDynamicProp {
                export const m_glowColor = 0xC80;
                export const m_nGlowTeam = 0xC84;
                export const m_nGlowRange = 0xC78;
                export const m_iszIdleAnim = 0xC60;
                export const m_bUseAnimGraph = 0xBE3;
                export const m_nGlowRangeMin = 0xC7C;
                export const m_bStartDisabled = 0xC6D;
                export const m_bCreateNonSolid = 0xC71;
                export const m_bIsOverrideProp = 0xC72;
                export const m_bRandomizeCycle = 0xC6C;
                export const m_pOutputAnimOver = 0xC00;
                export const m_OnAnimReachedEnd = 0xC48;
                export const m_bForceNpcExclude = 0xC6F;
                export const m_pOutputAnimBegun = 0xBE8;
                export const m_iInitialGlowState = 0xC74;
                export const m_nIdleAnimLoopMode = 0xC68;
                export const m_OnAnimReachedStart = 0xC30;
                export const m_bCreateNavObstacle = 0xBE0;
                export const m_bFiredStartEndOutput = 0xC6E;
                export const m_bGraphControllerEnabled = 0xBD0;
                export const m_bUseHitboxesForRenderBox = 0xBE2;
                export const m_pOutputAnimLoopCycleOver = 0xC18;
                export const m_bCreateMovableSurfaceGraph = 0xC70;
                export const m_bNavObstacleUpdatesOverridden = 0xBE1;
            }
            export namespace CEntityFlame {
                export const m_flSize = 0x4B0;
                export const m_hAttacker = 0x4C4;
                export const m_flLifetime = 0x4C0;
                export const m_bCheapEffect = 0x4AC;
                export const m_bUseHitboxes = 0x4B4;
                export const m_hEntAttached = 0x4A8;
                export const m_iNumHitboxFires = 0x4B8;
                export const m_flHitboxFireScale = 0x4BC;
                export const m_iCustomDamageType = 0x4CC;
                export const m_flDirectDamagePerSecond = 0x4C8;
            }
            export namespace CEnvBeverage {
                export const m_nBeverageType = 0x4AC;
                export const m_CanInDispenser = 0x4A8;
            }
            export namespace CFilterClass {
                export const m_iFilterClass = 0x4E0;
            }
            export namespace CFilterEnemy {
                export const m_flRadius = 0x4E8;
                export const m_iszEnemyName = 0x4E0;
                export const m_flOuterRadius = 0x4EC;
                export const m_iszPlayerName = 0x4F8;
                export const m_nMaxSquadmatesPerEnemy = 0x4F0;
            }
            export namespace CFilterModel {
                export const m_iFilterModel = 0x4E0;
            }
            export namespace CFuncMonitor {
                export const m_bEnabled = 0x88C;
                export const m_targetCamera = 0x870;
                export const m_bDraw3DSkybox = 0x88D;
                export const m_bStartEnabled = 0x88E;
                export const m_hTargetCamera = 0x888;
                export const m_bRenderShadows = 0x87C;
                export const m_brushModelName = 0x880;
                export const m_nResolutionEnum = 0x878;
                export const m_bUseUniqueColorTarget = 0x87D;
            }
            export namespace CFuncPlatRot {
                export const m_end = 0x908;
                export const m_start = 0x914;
            }
            export namespace CFuncRotator {
                export const m_flSpeed = 0x858;
                export const m_bQueueStop = 0x9A0;
                export const m_eSolidType = 0x855;
                export const m_OnOscillate = 0x8A0;
                export const m_bIsRotating = 0x854;
                export const m_eRotateType = 0x850;
                export const m_flStartSpeed = 0x938;
                export const m_iszLoopSound = 0x968;
                export const m_iszStopSound = 0x988;
                export const m_eRotationAxis = 0x998;
                export const m_flTargetAngle = 0x990;
                export const m_iszStartSound = 0x960;
                export const m_flCurrentAngle = 0x994;
                export const m_hRotatorTarget = 0x864;
                export const m_nTickRotateRan = 0x918;
                export const m_rotationSummary = 0x920;
                export const m_bStartedRotating = 0x91C;
                export const m_flMaxYawRotation = 0x958;
                export const m_flMinYawRotation = 0x954;
                export const m_strRotatorTarget = 0x868;
                export const m_OnRotationStarted = 0x870;
                export const m_qSpawnOrientation = 0x940;
                export const m_flTimeRotationStop = 0x934;
                export const m_OnRotationCompleted = 0x888;
                export const m_flTimeRotationStart = 0x930;
                export const m_OnOscillateEndArrive = 0x8E8;
                export const m_OnOscillateEndDepart = 0x900;
                export const m_bOscillationFromStart = 0x95C;
                export const m_flTimeToReachMaxSpeed = 0x928;
                export const m_OnOscillateStartArrive = 0x8B8;
                export const m_OnOscillateStartDepart = 0x8D0;
                export const m_flTimeToReachZeroSpeed = 0x92C;
                export const m_flTimeToCompleteRotation = 0x860;
                export const m_flRotationDistanceDegrees = 0x85C;
                export const m_flSpeedDriftFromOverRotate = 0x99C;
                export const m_bReturningToInitialRotation = 0x950;
            }
            export namespace CGradientFog {
                export const m_flFarZ = 0x4C4;
                export const m_fogColor = 0x4D4;
                export const m_bIsEnabled = 0x4E1;
                export const m_flFadeTime = 0x4DC;
                export const m_flFogStrength = 0x4D8;
                export const m_bStartDisabled = 0x4E0;
                export const m_flFogEndHeight = 0x4C0;
                export const m_flFogMaxOpacity = 0x4C8;
                export const m_flFogEndDistance = 0x4B4;
                export const m_flFogStartHeight = 0x4BC;
                export const m_bHeightFogEnabled = 0x4B8;
                export const m_flFogStartDistance = 0x4B0;
                export const m_hGradientFogTexture = 0x4A8;
                export const m_flFogFalloffExponent = 0x4CC;
                export const m_flFogVerticalExponent = 0x4D0;
                export const m_bGradientFogNeedsTextures = 0x4E2;
            }
            export namespace CHandleDummy {

            }
            export namespace CHintMessage {
                export const m_args = 0x8;
                export const m_duration = 0x20;
                export const m_hintString = 0x0;
            }
            export namespace CItemDefuser {
                export const m_nSpotRules = 0xAF8;
                export const m_entitySpottedState = 0xAE0;
            }
            export namespace CItemDogtags {
                export const m_OwningPlayer = 0xAE0;
                export const m_KillingPlayer = 0xAE4;
            }
            export namespace CItemGeneric {
                export const m_OnPickup = 0xB68;
                export const m_bUseable = 0xC00;
                export const m_OnTimeout = 0xB80;
                export const m_glowColor = 0xBFC;
                export const m_hPickupFilter = 0xB60;
                export const m_OnTriggerTouch = 0xBB0;
                export const m_flPickupRadius = 0xBE8;
                export const m_hTriggerHelper = 0xC04;
                export const m_flTriggerRadius = 0xBEC;
                export const m_bHasPickupRadius = 0xAF5;
                export const m_OnTriggerEndTouch = 0xBC8;
                export const m_bHasTriggerRadius = 0xAF4;
                export const m_flLastPickupCheck = 0xB00;
                export const m_flPickupRadiusSqr = 0xAF8;
                export const m_pPickupFilterName = 0xB58;
                export const m_bGlowWhenInTrigger = 0xBF8;
                export const m_flTriggerRadiusSqr = 0xAFC;
                export const m_pPickupSoundEffect = 0xB30;
                export const m_OnTriggerStartTouch = 0xB98;
                export const m_pAmbientSoundEffect = 0xB10;
                export const m_pTimeoutSoundEffect = 0xB48;
                export const m_pTriggerSoundEffect = 0xBF0;
                export const m_hSpawnParticleEffect = 0xB08;
                export const m_pSpawnScriptFunction = 0xB20;
                export const m_hPickupParticleEffect = 0xB28;
                export const m_pPickupScriptFunction = 0xB38;
                export const m_bAutoStartAmbientSound = 0xB18;
                export const m_bPlayerInTriggerRadius = 0xB05;
                export const m_hTimeoutParticleEffect = 0xB40;
                export const m_pTimeoutScriptFunction = 0xB50;
                export const m_pAllowPickupScriptFunction = 0xBE0;
                export const m_bPlayerCounterListenerAdded = 0xB04;
            }
            export namespace CKeepUpright {
                export const m_bActive = 0x4E0;
                export const m_nameAttach = 0x4D0;
                export const m_pController = 0x4C8;
                export const m_angularLimit = 0x4DC;
                export const m_localTestAxis = 0x4BC;
                export const m_worldGoalAxis = 0x4B0;
                export const m_attachedObject = 0x4D8;
                export const m_bDampAllRotation = 0x4E1;
            }
            export namespace CLightEntity {
                export const m_CLightComponent = 0x850;
            }
            export namespace CLogicBranch {
                export const m_OnTrue = 0x4C8;
                export const m_OnFalse = 0x4E0;
                export const m_bInValue = 0x4A8;
                export const m_Listeners = 0x4B0;
            }
            export namespace CLogicScript {

            }
            export namespace CMathCounter {
                export const m_flMax = 0x4AC;
                export const m_flMin = 0x4A8;
                export const m_bHitMax = 0x4B1;
                export const m_bHitMin = 0x4B0;
                export const m_OnHitMax = 0x510;
                export const m_OnHitMin = 0x4F8;
                export const m_OutValue = 0x4B8;
                export const m_bDisabled = 0x4B2;
                export const m_OnGetValue = 0x4D8;
                export const m_OnChangedFromMax = 0x540;
                export const m_OnChangedFromMin = 0x528;
            }
            export namespace CMultiSource {
                export const m_iTotal = 0x5C0;
                export const m_OnTrigger = 0x5A8;
                export const m_rgEntities = 0x4A8;
                export const m_globalstate = 0x5C8;
                export const m_rgTriggered = 0x528;
            }
            export namespace CNavPathCost {
                export const m_bCanFly = 0x11;
                export const m_bCanSwim = 0x12;
                export const m_bAllowLadders = 0x10;
                export const m_flTransitionPenalty = 0x2C;
                export const m_bSupportsTransitions = 0x2A;
                export const m_flGroundToWaterMaxHeight = 0x18;
                export const m_flWaterToGroundMaxHeight = 0x14;
                export const m_bOptimizeFlySpacePathfinds = 0x28;
                export const m_flFlyingTransitionTolerance = 0x24;
                export const m_bStringPullFlySpacePathfinds = 0x29;
                export const m_flGroundToWaterTransitionDistance = 0x1C;
                export const m_flWaterToGroundTransitionDistance = 0x20;
            }
            export namespace CNavWalkable {

            }
            export namespace CNmAimCSTask {

            }
            export namespace CPhysicsProp {
                export const m_bAwake = 0xD09;
                export const m_OnAwake = 0xC10;
                export const m_OnAsleep = 0xC28;
                export const m_CrateType = 0xCD0;
                export const m_glowColor = 0xCC0;
                export const m_massScale = 0xC8C;
                export const m_OnAwakened = 0xBF8;
                export const m_damageType = 0xC94;
                export const m_flLastBurn = 0xCA8;
                export const m_nGlowRange = 0xCB8;
                export const m_nItemCount = 0xCF8;
                export const m_OnPlayerUse = 0xC40;
                export const m_OnOutOfWorld = 0xC58;
                export const m_strItemClass = 0xCD8;
                export const m_MotionEnabled = 0xBE0;
                export const m_buoyancyScale = 0xC90;
                export const m_nGlowRangeMin = 0xCBC;
                export const m_OnPlayerPickup = 0xC70;
                export const m_bForceNavIgnore = 0xC88;
                export const m_bIsOverrideProp = 0xCA4;
                export const m_bDroppedByPlayer = 0xCA0;
                export const m_bEnableUseOutput = 0xCCF;
                export const m_bForceNpcExclude = 0xC8A;
                export const m_bHasBeenAwakened = 0xCA3;
                export const m_bTouchedByPlayer = 0xCA1;
                export const m_nNavObstacleType = 0xCC8;
                export const m_bNoNavmeshBlocker = 0xC89;
                export const m_iInitialGlowState = 0xCB4;
                export const m_bMuteImpactEffects = 0xCC5;
                export const m_bForceNavObstacleCut = 0xCCD;
                export const m_bUpdateNavWhenMoving = 0xCCC;
                export const m_damageToEnableMotion = 0xC98;
                export const m_flForceToEnableMotion = 0xC9C;
                export const m_bAttachedToReferenceFrame = 0xD0A;
                export const m_bFirstCollisionAfterLaunch = 0xCA2;
                export const m_bRemovableForAmmoBalancing = 0xD08;
                export const m_bAcceptDamageFromHeldObjects = 0xCCE;
                export const m_bShouldAutoConvertBackFromDebris = 0xCC4;
                export const m_nDynamicContinuousContactBehavior = 0xCAC;
                export const m_fNextCheckDisableMotionContactsTime = 0xCB0;
            }
            export namespace CPhysicsWire {
                export const m_nDensity = 0x4A8;
            }
            export namespace CPlatTrigger {
                export const m_pPlatform = 0x850;
            }
            export namespace CPointCamera {
                export const m_FOV = 0x4A8;
                export const m_bIsOn = 0x4FC;
                export const m_pNext = 0x500;
                export const m_bNoSky = 0x4CC;
                export const m_flZFar = 0x4D4;
                export const m_bActive = 0x4C4;
                export const m_flZNear = 0x4D8;
                export const m_FogColor = 0x4B4;
                export const m_flFogEnd = 0x4BC;
                export const m_TargetFOV = 0x4F4;
                export const m_Resolution = 0x4AC;
                export const m_bFogEnable = 0x4B0;
                export const m_flFogStart = 0x4B8;
                export const m_bCanHLTVUse = 0x4DC;
                export const m_bDofEnabled = 0x4DE;
                export const m_fBrightness = 0x4D0;
                export const m_flAspectRatio = 0x4C8;
                export const m_flDofFarCrisp = 0x4E8;
                export const m_flDofFarBlurry = 0x4EC;
                export const m_flDofNearCrisp = 0x4E4;
                export const m_flDofNearBlurry = 0x4E0;
                export const m_flFogMaxDensity = 0x4C0;
                export const m_DegreesPerSecond = 0x4F8;
                export const m_bAlignWithParent = 0x4DD;
                export const m_flDofTiltToGround = 0x4F0;
                export const m_bUseScreenAspectRatio = 0x4C5;
            }
            export namespace CPointEntity {

            }
            export namespace CPointOrient {
                export const m_bActive = 0x4B4;
                export const m_hTarget = 0x4B0;
                export const m_nConstraint = 0x4BC;
                export const m_flMaxTurnRate = 0x4C0;
                export const m_flLastGameTime = 0x4C4;
                export const m_nGoalDirection = 0x4B8;
                export const m_iszSpawnTargetName = 0x4A8;
            }
            export namespace CPointPrefab {
                export const m_fixupNames = 0x4C0;
                export const m_bLoadDynamic = 0x4C1;
                export const m_targetMapName = 0x4A8;
                export const m_forceWorldGroupID = 0x4B0;
                export const m_associatedRelayEntity = 0x4C4;
                export const m_ProceduralRelaySources = 0x4C8;
                export const m_associatedRelayTargetName = 0x4B8;
            }
            export namespace CRR_Response {
                export const m_Type = 0x0;
                export const m_Params = 0x160;
                export const m_Followup = 0x198;
                export const m_fMatchScore = 0x180;
                export const m_szMatchingRule = 0xC1;
                export const m_szResponseName = 0x1;
                export const m_szWorldContext = 0x190;
                export const m_recipientFilter = 0x1B4;
                export const m_szSpeakerContext = 0x188;
                export const m_bAnyMatchingRulesInCooldown = 0x184;
            }
            export namespace CRagdollProp {
                export const m_ragPos = 0xB08;
                export const m_hKiller = 0xB4C;
                export const m_ragdoll = 0xA90;
                export const m_allAsleep = 0xB3C;
                export const m_massScale = 0xAE4;
                export const m_ragAngles = 0xB20;
                export const m_flFadeTime = 0xB5C;
                export const m_ragEnabled = 0xAF0;
                export const m_flAwakeTime = 0xB6C;
                export const m_ragdollMaxs = 0xBB0;
                export const m_ragdollMins = 0xB98;
                export const m_bAllowStretch = 0xB89;
                export const m_buoyancyScale = 0xAE8;
                export const m_flBlendWeight = 0xB8C;
                export const m_hDamageEntity = 0xB48;
                export const m_vecLastOrigin = 0xB60;
                export const m_bStartDisabled = 0xAE0;
                export const m_vecNavObstacles = 0xBE0;
                export const m_hPhysicsAttacker = 0xB50;
                export const m_nNavObstacleType = 0xB40;
                export const m_CPropDataComponent = 0xA50;
                export const m_bHasBeenPhysgunned = 0xB88;
                export const m_flDefaultFadeScale = 0xB90;
                export const m_flFadeOutStartTime = 0xB58;
                export const m_strOriginClassName = 0xB78;
                export const m_strSourceClassName = 0xB80;
                export const m_lastUpdateTickCount = 0xB38;
                export const m_bForceNavObstacleCut = 0xB45;
                export const m_bUpdateNavWhenMoving = 0xB44;
                export const m_flLastOriginChangeTime = 0xB70;
                export const m_bAttachedToReferenceFrame = 0xB46;
                export const m_bFirstCollisionAfterLaunch = 0xB3D;
                export const m_flLastPhysicsInfluenceTime = 0xB54;
                export const m_bShouldDeleteActivationRecord = 0xBC8;
            }
            export namespace CRevertSaved {
                export const m_Duration = 0x854;
                export const m_HoldTime = 0x858;
                export const m_loadTime = 0x850;
            }
            export namespace CSceneEntity {
                export const m_fPitch = 0x53C;
                export const m_hActor = 0x7E8;
                export const m_OnStart = 0x5C8;
                export const m_bPaused = 0x529;
                export const m_ActorMap = 0x770;
                export const m_OnPaused = 0x610;
                export const m_hTarget1 = 0x4F8;
                export const m_hTarget2 = 0x4FC;
                export const m_hTarget3 = 0x500;
                export const m_hTarget4 = 0x504;
                export const m_hTarget5 = 0x508;
                export const m_hTarget6 = 0x50C;
                export const m_hTarget7 = 0x510;
                export const m_hTarget8 = 0x514;
                export const m_BusyActor = 0x7F0;
                export const m_OnResumed = 0x628;
                export const m_OnCanceled = 0x5F8;
                export const m_bAutomated = 0x540;
                export const m_bRestoring = 0x7A4;
                export const m_hActivator = 0x7EC;
                export const m_hActorList = 0x560;
                export const m_iszTarget1 = 0x4B8;
                export const m_iszTarget2 = 0x4C0;
                export const m_iszTarget3 = 0x4C8;
                export const m_iszTarget4 = 0x4D0;
                export const m_iszTarget5 = 0x4D8;
                export const m_iszTarget6 = 0x4E0;
                export const m_iszTarget7 = 0x4E8;
                export const m_iszTarget8 = 0x4F0;
                export const m_flFrameTime = 0x534;
                export const m_ActorClipMap = 0x748;
                export const m_OnCompletion = 0x5E0;
                export const m_bInterrupted = 0x7A1;
                export const m_bMultiplayer = 0x52A;
                export const m_iszSceneFile = 0x4B0;
                export const m_iszSoundName = 0x7D8;
                export const m_ActorGraphMap = 0x720;
                export const m_AnchorNameMap = 0x6F8;
                export const m_TargetNameMap = 0x6D0;
                export const m_bSceneMissing = 0x7A0;
                export const m_flCurrentTime = 0x530;
                export const m_hListManagers = 0x7C0;
                export const m_bAutogenerated = 0x52B;
                export const m_bIsPlayingBack = 0x528;
                export const m_bSceneFinished = 0x55A;
                export const m_hLocatorOrigin = 0x518;
                export const m_bBreakOnNonIdle = 0x559;
                export const m_bCompletedEarly = 0x7A2;
                export const m_bPausedViaInput = 0x554;
                export const m_hInterruptScene = 0x788;
                export const m_iszSequenceName = 0x7E0;
                export const m_nInterruptCount = 0x78C;
                export const m_nSpeechPriority = 0x550;
                export const m_responseConcept = 0x790;
                export const m_bWaitingForActor = 0x556;
                export const m_flAutomationTime = 0x54C;
                export const m_hRemoveActorList = 0x578;
                export const m_nAutomatedAction = 0x544;
                export const m_responseCriteria = 0x798;
                export const m_flAutomationDelay = 0x548;
                export const m_flForceClientTime = 0x52C;
                export const m_nSceneStringIndex = 0x5C0;
                export const m_sTargetAttachment = 0x520;
                export const m_OnPulseRequirement = 0x640;
                export const m_bRemoveOnCompletion = 0x539;
                export const m_bWaitingForInterrupt = 0x557;
                export const m_iPlayerDeathBehavior = 0x7F4;
                export const m_bPauseAtNextInterrupt = 0x555;
                export const m_bCancelAtNextInterrupt = 0x538;
                export const m_hNotifySceneCompletion = 0x7A8;
                export const m_bInterruptSceneFinished = 0x7A3;
                export const m_bInterruptedActorsScenes = 0x558;
            }
            export namespace CSkillDamage {
                export const m_flDamage = 0x0;
                export const m_flPhysicsForceDamage = 0x14;
                export const m_flNPCDamageScalarVsNPC = 0x10;
            }
            export namespace CTankTrainAI {
                export const m_hTrain = 0x4A8;
                export const m_soundPlaying = 0x4B0;
                export const m_hTargetEntity = 0x4AC;
                export const m_startSoundName = 0x4C8;
                export const m_engineSoundName = 0x4D0;
                export const m_targetEntityName = 0x4E0;
                export const m_movementSoundName = 0x4D8;
            }
            export namespace CTestPulseIO {
                export const m_OnVariantInt = 0x4E0;
                export const m_OnVariantBool = 0x4C0;
                export const m_OnVariantVoid = 0x4A8;
                export const m_TestComponent = 0x590;
                export const m_OnVariantColor = 0x540;
                export const m_OnVariantFloat = 0x500;
                export const m_OnVariantString = 0x520;
                export const m_OnVariantVector = 0x560;
                export const m_OnInternalTestInt = 0x5F8;
                export const m_bAllowEmptyInputs = 0x588;
                export const m_OnInternalTestBool = 0x5D8;
                export const m_OnInternalTestVoid = 0x5C0;
                export const m_OnInternalTestColor = 0x658;
                export const m_OnInternalTestFloat = 0x618;
                export const m_OnInternalTestString = 0x638;
                export const m_OnInternalTestVector = 0x678;
                export const m_OnInternalTestEntityName = 0x6A0;
                export const m_OnInternalTestSchemaEnum = 0x6E0;
                export const m_OnInternalTestFloatString = 0x700;
                export const m_OnInternalTestEntityHandle = 0x6C0;
                export const m_OnInternalTestEntityHandleInt = 0x750;
                export const m_OnInternalTestEntityNameString = 0x728;
                export const m_OnInternalTestStringStringString = 0x770;
            }
            export namespace CTimerEntity {
                export const m_OnTimer = 0x4A8;
                export const m_bPaused = 0x514;
                export const m_iDisabled = 0x4F0;
                export const m_OnTimerLow = 0x4D8;
                export const m_OnTimerHigh = 0x4C0;
                export const m_bUpDownState = 0x4FC;
                export const m_flRefireTime = 0x4F8;
                export const m_flInitialDelay = 0x4F4;
                export const m_iUseRandomTime = 0x500;
                export const m_flRemainingTime = 0x510;
                export const m_bPauseAfterFiring = 0x504;
                export const m_flLowerRandomBound = 0x508;
                export const m_flUpperRandomBound = 0x50C;
            }
            export namespace CTriggerHurt {
                export const m_OnHurt = 0xA00;
                export const m_flDamage = 0x9CC;
                export const m_bNoDmgForce = 0x9E4;
                export const m_damageModel = 0x9E0;
                export const m_flDamageCap = 0x9D0;
                export const m_thinkAlways = 0x9F4;
                export const m_OnHurtPlayer = 0xA18;
                export const m_hurtEntities = 0xA30;
                export const m_vDamageForce = 0x9E8;
                export const m_flLastDmgTime = 0x9D4;
                export const m_hurtThinkPeriod = 0x9F8;
                export const m_flOriginalDamage = 0x9C8;
                export const m_bitsDamageInflict = 0x9DC;
                export const m_flForgivenessDelay = 0x9D8;
            }
            export namespace CTriggerLook {
                export const m_b2DFOV = 0x9FA;
                export const m_OnEndLook = 0xA30;
                export const m_OnTimeout = 0xA00;
                export const m_bIsLooking = 0x9F9;
                export const m_flLookTime = 0x9E8;
                export const m_OnStartLook = 0xA18;
                export const m_hLookTarget = 0x9E0;
                export const m_bUseVelocity = 0x9FB;
                export const m_bTimeoutFired = 0x9F8;
                export const m_flFieldOfView = 0x9E4;
                export const m_bTestOcclusion = 0x9FC;
                export const m_flLookTimeLast = 0x9F0;
                export const m_flLookTimeTotal = 0x9EC;
                export const m_flTimeoutDuration = 0x9F4;
                export const m_bTestAllVisibleOcclusion = 0x9FD;
            }
            export namespace CTriggerOnce {

            }
            export namespace CTriggerPush {
                export const m_flSpeed = 0x9F8;
                export const m_PathSimple = 0x9F0;
                export const m_bUsePathSimple = 0x9E1;
                export const m_splinePushType = 0x9F4;
                export const m_iszPathSimpleName = 0x9E8;
                export const m_angPushEntitySpace = 0x9C8;
                export const m_bTriggerOnStartTouch = 0x9E0;
                export const m_vecPushDirEntitySpace = 0x9D4;
            }
            export namespace CTriggerSave {
                export const m_minHitPoints = 0x9D0;
                export const m_fDangerousTimer = 0x9CC;
                export const m_flRetriggerDelay = 0x9D4;
                export const m_bForceNewLevelUnit = 0x9C8;
            }
            export namespace CWaterBullet {

            }
            export namespace CWeaponBizon {

            }
            export namespace CWeaponCZ75a {
                export const m_bMagazineRemoved = 0x12A0;
            }
            export namespace CWeaponElite {

            }
            export namespace CWeaponFamas {

            }
            export namespace CWeaponG3SG1 {

            }
            export namespace CWeaponGlock {

            }
            export namespace CWeaponMAC10 {

            }
            export namespace CWeaponMP5SD {

            }
            export namespace CWeaponNegev {

            }
            export namespace CWeaponSG556 {

            }
            export namespace CWeaponSSG08 {

            }
            export namespace CWeaponTaser {
                export const m_fFireTime = 0x12A0;
                export const m_nLastAttackTick = 0x12A4;
            }
            export namespace CWeaponUMP45 {

            }
            export namespace FilterHealth {
                export const m_iHealthMax = 0x4E8;
                export const m_iHealthMin = 0x4E4;
                export const m_bAdrenalineActive = 0x4E0;
            }
            export namespace INavObstacle {
                export const m_nId = 0x8;
            }
            export namespace INavPathCost {
                export const m_navHull = 0x8;
            }
            export namespace NavGravity_t {
                export const m_bDefault = 0xC;
                export const m_vGravity = 0x0;
            }
            export namespace CAI_Expresser {
                export const m_pOuter = 0x98;
                export const m_voicePitch = 0x70;
                export const m_ruleCooldowns = 0x38;
                export const m_flStopTalkTime = 0x60;
                export const m_conceptCooldowns = 0x10;
                export const m_flBlockedTalkTime = 0x6C;
                export const m_flQueuedSpeechTime = 0x68;
                export const m_nLastSpokenPriority = 0x7C;
                export const m_bSceneEntityDisabled = 0x7A;
                export const m_flLastTimeAcceptedSpeak = 0x74;
                export const m_bAllowSpeakingInterrupts = 0x78;
                export const m_flStopTalkTimeWithoutDelay = 0x64;
                export const m_bConsiderSceneInvolvementAsSpeech = 0x79;
            }
            export namespace CBasePropDoor {
                export const m_ls = 0xCF0;
                export const m_OnOpen = 0xE48;
                export const m_OnClose = 0xE30;
                export const m_bLocked = 0xCCC;
                export const m_bNoNPCs = 0xCCD;
                export const m_flSpeed = 0xD24;
                export const m_hMaster = 0xD98;
                export const m_hBlocker = 0xCE8;
                export const m_SlaveName = 0xD90;
                export const m_SoundLock = 0xD58;
                export const m_SoundOpen = 0xD48;
                export const m_hDoorList = 0xCA8;
                export const m_OnAjarOpen = 0xE78;
                export const m_SoundClose = 0xD50;
                export const m_SoundLatch = 0xD68;
                export const m_SoundPound = 0xD70;
                export const m_eDoorState = 0xCC8;
                export const m_hActivator = 0xD20;
                export const m_OnFullyOpen = 0xE18;
                export const m_OnLockedUse = 0xE60;
                export const m_SoundJiggle = 0xD78;
                export const m_SoundMoving = 0xD40;
                export const m_SoundUnlock = 0xD60;
                export const m_bForceClosed = 0xD10;
                export const m_closedAngles = 0xCDC;
                export const m_OnFullyClosed = 0xE00;
                export const m_bFirstBlocked = 0xCEC;
                export const m_nHardwareType = 0xCC0;
                export const m_bNeedsHardware = 0xCC4;
                export const m_closedPosition = 0xCD0;
                export const m_SoundLockedAnim = 0xD80;
                export const m_OnBlockedClosing = 0xDA0;
                export const m_OnBlockedOpening = 0xDB8;
                export const m_nPhysicsMaterial = 0xD8C;
                export const m_numCloseAttempts = 0xD88;
                export const m_flAutoReturnDelay = 0xCA0;
                export const m_OnUnblockedClosing = 0xDD0;
                export const m_OnUnblockedOpening = 0xDE8;
                export const m_vecLatchWorldPosition = 0xD14;
            }
            export namespace CCSPlayerPawn {
                export const m_pBot = 0x1510;
                export const m_bIsScoped = 0x14CC;
                export const m_ArmorValue = 0x1524;
                export const m_EconGloves = 0x1058;
                export const m_LastHitBox = 0x150C;
                export const m_bInBuyZone = 0xF61;
                export const m_bIsWalking = 0x1488;
                export const m_nSpotRules = 0x14C8;
                export const m_bInBombZone = 0xF82;
                export const m_bIsDefusing = 0x14CE;
                export const m_bIsSpawning = 0x1534;
                export const m_bLeftHanded = 0x1470;
                export const m_bResumeZoom = 0x14CD;
                export const m_iDeathFlags = 0x1540;
                export const m_iShotsFired = 0x14E8;
                export const m_strVOPrefix = 0xE68;
                export const m_angEyeAngles = 0x15C0;
                export const m_lastLandTime = 0xFD8;
                export const m_pBuyServices = 0xE38;
                export const m_bHasDeathInfo = 0x1544;
                export const m_bWasInBuyZone = 0xF80;
                export const m_flFlinchStack = 0x14EC;
                export const m_iPlayerLocked = 0xFE0;
                export const m_bIsBuyMenuOpen = 0xFA0;
                export const m_flViewmodelFOV = 0x1484;
                export const m_iBombSiteIndex = 0x14DC;
                export const m_nWhichBombZone = 0x14E0;
                export const m_pRadioServices = 0xE50;
                export const m_bBotAllowActive = 0x1518;
                export const m_bHasFemaleVoice = 0xE62;
                export const m_bInNoDefuseArea = 0x14D8;
                export const m_flDeathInfoTime = 0x1548;
                export const m_flEmitSoundTime = 0x14D4;
                export const m_pBulletServices = 0xE28;
                export const m_qDeathEyeAngles = 0x1464;
                export const m_szLastPlaceName = 0xE70;
                export const m_TouchingBuyZones = 0xF68;
                export const m_bGunGameImmunity = 0x15B8;
                export const m_bWaitForNoAttack = 0x1500;
                export const m_iRetakesOffering = 0xF84;
                export const m_nLastKillerIndex = 0x14A8;
                export const m_pHostageServices = 0xE30;
                export const m_bKilledByHeadshot = 0x1508;
                export const m_bOnGroundLastTick = 0xFDC;
                export const m_pAimPunchServices = 0xE48;
                export const m_bInBombZoneTrigger = 0x14E4;
                export const m_bIsGrabbingHostage = 0x14CF;
                export const m_entitySpottedState = 0x14B0;
                export const m_fLastGivenBombTime = 0x1490;
                export const m_fMolotovDamageTime = 0x15BC;
                export const m_flTimeOfLastInjury = 0xFE8;
                export const m_flVelocityModifier = 0x14F0;
                export const m_flViewmodelOffsetX = 0x1478;
                export const m_flViewmodelOffsetY = 0x147C;
                export const m_flViewmodelOffsetZ = 0x1480;
                export const m_nCharacterDefIndex = 0xE60;
                export const m_nEconGlovesChanged = 0x1440;
                export const m_nRagdollDamageBone = 0xFF4;
                export const m_vecDeathInfoOrigin = 0x154C;
                export const m_vecStashedVelocity = 0x159C;
                export const m_allowAutoFollowTime = 0x14A0;
                export const m_bInHostageResetZone = 0xF60;
                export const m_iDisplayHistoryBits = 0x1498;
                export const m_nLastPickupPriority = 0x151C;
                export const m_vRagdollDamageForce = 0xFF8;
                export const m_vecTotalBulletForce = 0x14F4;
                export const m_GunGameImmunityColor = 0x156C;
                export const m_bInHostageRescueZone = 0xF81;
                export const m_bResetArmorNextSpawn = 0x14A4;
                export const m_bRetakesHasDefuseKit = 0xF8C;
                export const m_bRetakesMVPLastRound = 0xF8D;
                export const m_flLandingTimeSeconds = 0xF9C;
                export const m_flNextSprayDecalTime = 0xFEC;
                export const m_hActiveMinimapVolume = 0x1460;
                export const m_iRetakesMVPBoostItem = 0xF90;
                export const m_iRetakesOfferingCard = 0xF88;
                export const m_ignoreLadderJumpTime = 0x1504;
                export const m_pDamageReactServices = 0xE58;
                export const m_vRagdollServerOrigin = 0x1048;
                export const m_angStashedShootAngles = 0x1578;
                export const m_bWasInBombZoneTrigger = 0x14E5;
                export const m_fLastGivenDefuserTime = 0x148C;
                export const m_wasNotKilledNaturally = 0x15B1;
                export const m_bRagdollDamageHeadshot = 0x1044;
                export const m_flLastAttackedTeammate = 0x149C;
                export const m_iLastWeaponFireUsercmd = 0x1530;
                export const m_bWasInHostageRescueZone = 0xF83;
                export const m_fSwitchedHandednessTime = 0x1474;
                export const m_pActionTrackingServices = 0xE40;
                export const m_unCurrentEquipmentValue = 0x1528;
                export const m_flLastPickupPriorityTime = 0x1520;
                export const m_vecCurrentMinimapVolumes = 0x1448;
                export const m_bGrenadeParametersStashed = 0x1574;
                export const m_grenadeParameterStashTime = 0x1570;
                export const m_szRagdollDamageWeaponName = 0x1004;
                export const m_vecPlayerPatchEconIndices = 0x1558;
                export const m_fImmuneToGunGameDamageTime = 0x15B4;
                export const m_unRoundStartEquipmentValue = 0x152A;
                export const m_RetakesMVPBoostExtraUtility = 0xF94;
                export const m_bNextSprayDecalTimeExpedited = 0xFF0;
                export const m_iBlockingUseActionInProgress = 0x14D0;
                export const m_unFreezetimeEndEquipmentValue = 0x152C;
                export const m_bCommittingSuicideOnTeamChange = 0x15B0;
                export const m_vecStashedGrenadeThrowPosition = 0x1584;
                export const m_flHealthShotBoostExpirationTime = 0xF98;
                export const m_vecStashedGrenadeThrowPawnCenter = 0x1590;
                export const m_flDealtDamageToEnemyMostRecentTimestamp = 0x1494;
            }
            export namespace CCSWeaponBase {
                export const m_donated = 0x1034;
                export const m_bInReload = 0xFA8;
                export const m_bStealthy = 0xFC4;
                export const m_nDropTick = 0x1010;
                export const m_bBurstMode = 0xF9C;
                export const m_hPrevOwner = 0x100C;
                export const m_weaponMode = 0xF70;
                export const m_bRemoveable = 0xEF8;
                export const m_bSilencerOn = 0xFBD;
                export const m_nDeployTick = 0xFAC;
                export const m_bFireOnEmpty = 0xF50;
                export const m_iRecoilIndex = 0xF94;
                export const m_bIsHauledBack = 0xFBC;
                export const m_bWasOwnedByCT = 0x103C;
                export const m_fLastShotTime = 0x1038;
                export const m_flRecoilIndex = 0xF98;
                export const m_OnPlayerPickup = 0xF58;
                export const m_bCanBePickedUp = 0xFF8;
                export const m_iIronSightMode = 0x10B8;
                export const m_bInspectPending = 0xF08;
                export const m_flDroppedAtTime = 0xFB4;
                export const m_flLastShakeTime = 0x10D0;
                export const m_flWatTickOffset = 0x10C0;
                export const m_fAccuracyPenalty = 0xF88;
                export const m_bInspectShouldLoop = 0xF09;
                export const m_bRequireUseToTouch = 0xEFA;
                export const m_nextOwnerTouchTime = 0xFFC;
                export const m_IronSightController = 0x10A0;
                export const m_bDroppedNearBuyZone = 0xFDC;
                export const m_flTurningInaccuracy = 0xF84;
                export const m_iOriginalTeamNumber = 0xFD4;
                export const m_bWasOwnedByTerrorist = 0x103D;
                export const m_nextPrevOwnerUseTime = 0x1008;
                export const m_bReloadHeldSinceStart = 0xFCC;
                export const m_flAttackHoldStartTime = 0xFB0;
                export const m_iMostRecentTeamNumber = 0xFD8;
                export const m_nLastEmptySoundCmdNum = 0xF34;
                export const m_bInSilentReloadSection = 0xFC5;
                export const m_flStealthHoldStartTime = 0xFC8;
                export const m_nextPrevOwnerTouchTime = 0x1000;
                export const m_flPostponeFireReadyFrac = 0xFA4;
                export const m_nPostponeFireReadyTicks = 0xFA0;
                export const m_bPlayerAmmoStockOnPickup = 0xEF9;
                export const m_bSilentReloadStatCounted = 0xFC6;
                export const m_bSilentReloadStatPending = 0xFC7;
                export const m_fAccuracySmoothedForZoom = 0xF90;
                export const m_flLastAccuracyUpdateTime = 0xF8C;
                export const m_flTurningInaccuracyDelta = 0xF74;
                export const m_iWeaponGameplayAnimState = 0xEFC;
                export const m_flLastLOSTraceFailureTime = 0x10BC;
                export const m_flWeaponActionPlaybackRate = 0xFD0;
                export const m_bWasActiveWeaponWhenDropped = 0x1014;
                export const m_flInspectCancelCompleteTime = 0xF04;
                export const m_numRemoveUnownedWeaponThink = 0x1040;
                export const m_flNextAttackRenderTimeOffset = 0xFE0;
                export const m_flTimeSilencerSwitchComplete = 0xFC0;
                export const m_vecTurningInaccuracyEyeDirLast = 0xF78;
                export const m_bUseCanOverrideNextOwnerTouchTime = 0xFF9;
                export const m_flWeaponGameplayAnimStateTimestamp = 0xF00;
            }
            export namespace CDamageRecord {
                export const m_flDamage = 0x64;
                export const m_iNumHits = 0x6C;
                export const m_killType = 0x75;
                export const m_DamagerXuid = 0x50;
                export const m_PlayerDamager = 0x30;
                export const m_RecipientXuid = 0x58;
                export const m_bIsOtherEnemy = 0x74;
                export const m_PlayerRecipient = 0x34;
                export const m_flBulletsDamage = 0x60;
                export const m_iLastBulletUpdate = 0x70;
                export const m_szPlayerDamagerName = 0x40;
                export const m_flActualHealthRemoved = 0x68;
                export const m_szPlayerRecipientName = 0x48;
                export const m_hPlayerControllerDamager = 0x38;
                export const m_hPlayerControllerRecipient = 0x3C;
            }
            export namespace CDebugHistory {
                export const m_nNpcEvents = 0x3E84E8;
            }
            export namespace CDecoyGrenade {

            }
            export namespace CDynamicLight {
                export const m_On = 0x853;
                export const m_Flags = 0x851;
                export const m_Radius = 0x854;
                export const m_Exponent = 0x858;
                export const m_InnerAngle = 0x85C;
                export const m_LightStyle = 0x852;
                export const m_OuterAngle = 0x860;
                export const m_SpotRadius = 0x864;
                export const m_ActualFlags = 0x850;
            }
            export namespace CEconItemView {
                export const m_iItemID = 0x48;
                export const m_iAccountID = 0x58;
                export const m_iItemIDLow = 0x54;
                export const m_iItemIDHigh = 0x50;
                export const m_bInitialized = 0x68;
                export const m_iEntityLevel = 0x40;
                export const m_szCustomName = 0x160;
                export const m_AttributeList = 0x70;
                export const m_iEntityQuality = 0x3C;
                export const m_iInventoryPosition = 0x5C;
                export const m_iItemDefinitionIndex = 0x38;
                export const m_szCustomNameOverride = 0x201;
                export const m_szCustomNameOverride2 = 0x2A2;
                export const m_szCustomNameOverride3 = 0x343;
                export const m_NetworkedDynamicAttributes = 0xE8;
            }
            export namespace CEconWearable {
                export const m_nForceSkin = 0xEB0;
                export const m_bAlwaysAllow = 0xEB4;
            }
            export namespace CEnvExplosion {
                export const m_hInflictor = 0x864;
                export const m_iMagnitude = 0x850;
                export const m_iClassIgnore = 0x88C;
                export const m_bCreateDebris = 0x86D;
                export const m_flDamageForce = 0x860;
                export const m_flInnerRadius = 0x85C;
                export const m_hEntityIgnore = 0x8A0;
                export const m_iClassIgnore2 = 0x890;
                export const m_flPlayerDamage = 0x854;
                export const m_iRadiusOverride = 0x858;
                export const m_iCustomDamageType = 0x868;
                export const m_iszCustomSoundName = 0x880;
                export const m_iszCustomEffectName = 0x878;
                export const m_iszEntityIgnoreName = 0x898;
                export const m_bHasCustomDamageType = 0x86C;
                export const m_bSuppressParticleImpulse = 0x888;
            }
            export namespace CEnvViewPunch {
                export const m_flRadius = 0x4A8;
                export const m_angViewPunch = 0x4AC;
            }
            export namespace CFuncConveyor {
                export const m_flSpeed = 0x85C;
                export const m_flTargetSpeed = 0x878;
                export const m_flFrictionScale = 0x888;
                export const m_hConveyorModels = 0x890;
                export const m_szConveyorModels = 0x850;
                export const m_angMoveEntitySpace = 0x860;
                export const m_nTransitionStartTick = 0x87C;
                export const m_vecMoveDirEntitySpace = 0x86C;
                export const m_flTransitionStartSpeed = 0x884;
                export const m_nTransitionDurationTicks = 0x880;
                export const m_flTransitionDurationSeconds = 0x858;
            }
            export namespace CFuncRotating {
                export const m_flSpeed = 0x8A4;
                export const m_angStart = 0x8EC;
                export const m_flVolume = 0x8B0;
                export const m_OnStarted = 0x868;
                export const m_OnStopped = 0x850;
                export const m_bReversed = 0x8C8;
                export const m_flMaxSpeed = 0x8B8;
                export const m_bAccelDecel = 0x8C9;
                export const m_NoiseRunning = 0x8C0;
                export const m_flAttenuation = 0x8AC;
                export const m_flBlockDamage = 0x8BC;
                export const m_flFanFriction = 0x8A8;
                export const m_flTargetSpeed = 0x8B4;
                export const m_OnReachedStart = 0x880;
                export const m_bStopAtStartPos = 0x8F8;
                export const m_prevLocalAngles = 0x8E0;
                export const m_vecClientAngles = 0x908;
                export const m_vecClientOrigin = 0x8FC;
                export const m_localRotationVector = 0x898;
            }
            export namespace CGlowProperty {
                export const m_bGlowing = 0x51;
                export const m_bFlashing = 0x44;
                export const m_iGlowTeam = 0x34;
                export const m_iGlowType = 0x30;
                export const m_fGlowColor = 0x8;
                export const m_flGlowTime = 0x48;
                export const m_nGlowRange = 0x38;
                export const m_nGlowRangeMin = 0x3C;
                export const m_flGlowStartTime = 0x4C;
                export const m_glowColorOverride = 0x40;
                export const m_bEligibleForScreenHighlight = 0x50;
            }
            export namespace CInfoLandmark {

            }
            export namespace CLogicCompare {
                export const m_OnEqualTo = 0x4D0;
                export const m_flInValue = 0x4A8;
                export const m_OnLessThan = 0x4B0;
                export const m_OnNotEqualTo = 0x4F0;
                export const m_OnGreaterThan = 0x510;
                export const m_flCompareValue = 0x4AC;
            }
            export namespace CMarkupVolume {
                export const m_bDisabled = 0x850;
            }
            export namespace CNavAttribute {

            }
            export namespace CNavHullVData {
                export const m_agentHeight = 0x8;
                export const m_agentRadius = 0x4;
                export const m_agentMaxClimb = 0x1C;
                export const m_agentMaxSlope = 0x20;
                export const m_bAgentEnabled = 0x0;
                export const m_agentCrawlHeight = 0x18;
                export const m_agentShortHeight = 0x10;
                export const m_agentCrawlEnabled = 0x14;
                export const m_agentBorderErosion = 0x30;
                export const m_agentMaxJumpUpDist = 0x2C;
                export const m_agentMaxJumpDownDist = 0x24;
                export const m_flowMapNodeMaxRadius = 0x38;
                export const m_agentShortHeightEnabled = 0xC;
                export const m_flowMapGenerationEnabled = 0x34;
                export const m_agentMaxJumpHorizDistBase = 0x28;
            }
            export namespace CNavSpaceInfo {

            }
            export namespace CNavVolumeAll {

            }
            export namespace COrnamentProp {
                export const m_initialOwner = 0xC90;
            }
            export namespace CPathKeyFrame {
                export const m_Angles = 0x4B4;
                export const m_Origin = 0x4A8;
                export const m_qAngle = 0x4C0;
                export const m_iNextKey = 0x4D0;
                export const m_pNextKey = 0x4DC;
                export const m_pPrevKey = 0x4E0;
                export const m_flNextTime = 0x4D8;
                export const m_flMoveSpeed = 0x4E4;
            }
            export namespace CPhysThruster {
                export const m_localOrigin = 0x508;
            }
            export namespace CPhysicsShake {
                export const m_force = 0x8;
            }
            export namespace CRandSimTimer {
                export const m_flMaxInterval = 0xC;
                export const m_flMinInterval = 0x8;
            }
            export namespace CRopeKeyframe {
                export const m_Slack = 0x868;
                export const m_Width = 0x86C;
                export const m_Subdiv = 0x888;
                export const m_RopeFlags = 0x858;
                export const m_hEndPoint = 0x89C;
                export const m_nSegments = 0x874;
                export const m_RopeLength = 0x88A;
                export const m_hStartPoint = 0x898;
                export const m_TextureScale = 0x870;
                export const m_nChangeCount = 0x889;
                export const m_fLockedPoints = 0x88C;
                export const m_flScrollSpeed = 0x890;
                export const m_iNextLinkName = 0x860;
                export const m_bEndPointValid = 0x895;
                export const m_iEndAttachment = 0x8A1;
                export const m_bStartPointValid = 0x894;
                export const m_iStartAttachment = 0x8A0;
                export const m_bCreatedFromMapFile = 0x88D;
                export const m_strRopeMaterialModel = 0x878;
                export const m_iRopeMaterialModelIndex = 0x880;
                export const m_bConstrainBetweenEndpoints = 0x875;
            }
            export namespace CSmokeGrenade {

            }
            export namespace CSpotlightEnd {
                export const m_Radius = 0x854;
                export const m_flLightScale = 0x850;
                export const m_vSpotlightDir = 0x858;
                export const m_vSpotlightOrg = 0x864;
            }
            export namespace CTriggerBrush {
                export const m_OnUse = 0x880;
                export const m_OnEndTouch = 0x868;
                export const m_OnStartTouch = 0x850;
                export const m_iInputFilter = 0x898;
                export const m_iDontMessageParent = 0x89C;
            }
            export namespace CWeaponSCAR20 {

            }
            export namespace CWeaponXM1014 {

            }
            export namespace CodeGenAABB_t {
                export const m_vMaxBounds = 0xC;
                export const m_vMinBounds = 0x0;
            }
            export namespace IntervalTimer {
                export const m_timestamp = 0x8;
                export const m_nWorldGroupId = 0xC;
            }
            export namespace QuestProgress {

            }
            export namespace audioparams_t {
                export const localBits = 0x6C;
                export const localSound = 0x8;
                export const soundEventHash = 0x74;
                export const soundscapeIndex = 0x68;
                export const soundscapeEntityListIndex = 0x70;
            }
            export namespace dynpitchvol_t {

            }
            export namespace entitytable_t {
                export const id = 0x0;
                export const flags = 0x18;
                export const bWasSaved = 0x14;
                export const classname = 0x20;
                export const edictindex = 0x4;
                export const entityname = 0x30;
                export const globalname = 0x28;
                export const saveentityindex = 0x8;
                export const landmarkModelSpace = 0x38;
                export const m_pPrecacheEntityKeys = 0x48;
            }
            export namespace sky3dparams_t {
                export const fog = 0x20;
                export const scale = 0x8;
                export const origin = 0xC;
                export const m_nWorldGroupID = 0x88;
                export const bClip3DSkyBoxNearToWorldFar = 0x18;
                export const flClip3DSkyBoxNearToWorldFarOffset = 0x1C;
            }
            export namespace ActorMapping_t {
                export const m_hEntity = 0x8;
                export const m_sActorName = 0x0;
            }
            export namespace AmmoTypeInfo_t {
                export const m_flMass = 0x28;
                export const m_nFlags = 0x24;
                export const m_flSpeed = 0x2C;
                export const m_nMaxCarry = 0x10;
                export const m_nSplashSize = 0x1C;
            }
            export namespace CAttributeList {
                export const m_pManager = 0x70;
                export const m_Attributes = 0x8;
            }
            export namespace CBaseAnimGraph {
                export const m_vecForce = 0x93C;
                export const m_nForceBone = 0x948;
                export const m_RagdollPose = 0x960;
                export const m_bRagdollEnabled = 0x988;
                export const m_pChoreoServices = 0x930;
                export const m_pRagdollControl = 0x958;
                export const m_bRagdollClientSide = 0x989;
                export const m_OnLayerCycleUpdated = 0x8F8;
                export const m_pMainGraphController = 0x8E8;
                export const m_graphControllerManager = 0x850;
                export const m_bAnimGraphUpdateEnabled = 0x938;
                export const m_bAnimationUpdateScheduled = 0x939;
                export const m_OnExternalChoreoGraphChanged = 0x918;
                export const m_bShouldUpdateTransformations = 0x98A;
                export const m_bInitiallyPopulateInterpHistory = 0x8F0;
                export const m_xParentedRagdollRootInEntitySpace = 0x990;
            }
            export namespace CBaseCSGrenade {
                export const m_bRedraw = 0x1280;
                export const m_fDropTime = 0x1290;
                export const m_bJumpThrow = 0x1283;
                export const m_bPinPulled = 0x1282;
                export const m_fThrowTime = 0x1288;
                export const m_fPinPullTime = 0x1294;
                export const m_nNextHoldTick = 0x129C;
                export const m_bJustPulledPin = 0x1298;
                export const m_flNextHoldFrac = 0x12A0;
                export const m_bIsHeldByPlayer = 0x1281;
                export const m_bThrowAnimating = 0x1284;
                export const m_flThrowStrength = 0x128C;
                export const m_hSwitchToWeaponAfterThrow = 0x12A4;
            }
            export namespace CBasePlatTrain {
                export const m_volume = 0x8E8;
                export const m_flTWidth = 0x8EC;
                export const m_flTLength = 0x8F0;
                export const m_NoiseMoving = 0x8D0;
                export const m_NoiseArrived = 0x8D8;
            }
            export namespace CBodyComponent {
                export const m_pSceneNode = 0x8;
                export const __m_pChainEntity = 0x48;
            }
            export namespace CBreakableProp {
                export const m_OnBreak = 0xAD0;
                export const m_hBreaker = 0xB48;
                export const m_OnStartDeath = 0xAB8;
                export const m_OnTakeDamage = 0xB08;
                export const m_iszPuntSound = 0xBB8;
                export const m_bUsePuntSound = 0xBC0;
                export const m_explodeDamage = 0xB6C;
                export const m_explodeRadius = 0xB70;
                export const m_hLastAttacker = 0xBB4;
                export const m_iMinHealthDmg = 0xB24;
                export const m_explosionDelay = 0xB80;
                export const m_sExplosionType = 0xB78;
                export const m_OnHealthChanged = 0xAE8;
                export const m_PerformanceMode = 0xB4C;
                export const m_flDefBurstScale = 0xB38;
                export const m_flPressureDelay = 0xB34;
                export const m_vDefBurstOffset = 0xB3C;
                export const m_hPhysicsAttacker = 0xBA8;
                export const m_bOriginalBlockLOS = 0xBC1;
                export const m_explosionModifier = 0xBA0;
                export const m_impactEnergyScale = 0xB20;
                export const m_CPropDataComponent = 0xA78;
                export const m_flDefaultFadeScale = 0xBB0;
                export const m_explosionCustomSound = 0xB98;
                export const m_preferredCarryAngles = 0xB28;
                export const m_BreakableContentsType = 0xB54;
                export const m_explosionBuildupSound = 0xB88;
                export const m_explosionCustomEffect = 0xB90;
                export const m_bHasBreakPiecesOrCommands = 0xB68;
                export const m_flPreventDamageBeforeTime = 0xB50;
                export const m_flLastPhysicsInfluenceTime = 0xBAC;
                export const m_strBreakableContentsParticleOverride = 0xB60;
                export const m_strBreakableContentsPropGroupOverride = 0xB58;
            }
            export namespace CDecalInstance {
                export const m_Color = 0x60;
                export const m_nFlags = 0x5C;
                export const m_flDepth = 0x6C;
                export const m_flWidth = 0x64;
                export const m_hEntity = 0x14;
                export const m_flHeight = 0x68;
                export const m_vSAxisLS = 0x50;
                export const m_hMaterial = 0x8;
                export const m_vNormalLS = 0x38;
                export const m_vNormalOS = 0x44;
                export const m_mTransform = 0x70;
                export const m_nBoneIndex = 0x18;
                export const m_bIsAdjacent = 0xFE;
                export const m_flPlaceTime = 0xD8;
                export const m_sDecalGroup = 0x0;
                export const m_vPositionLS = 0x20;
                export const m_vPositionOS = 0x2C;
                export const m_sSequenceName = 0x10;
                export const m_flFadeDuration = 0xE0;
                export const m_nSequenceIndex = 0xFC;
                export const m_nTriangleIndex = 0x1C;
                export const m_flFadeStartTime = 0xDC;
                export const m_flAnimationScale = 0xD0;
                export const m_mLocalToTriangle = 0xA0;
                export const m_flBoundingRadiusSqr = 0xF8;
                export const m_bDoDecalLightmapping = 0xFF;
                export const m_flAnimationStartTime = 0xD4;
                export const m_flLightingOriginOffset = 0xE4;
            }
            export namespace CEntityBlocker {

            }
            export namespace CEnvCubemapBox {

            }
            export namespace CEnvCubemapFog {
                export const m_bActive = 0x4CC;
                export const m_flLODBias = 0x4C8;
                export const m_bFirstTime = 0x5A1;
                export const m_hSkyMaterial = 0x4D8;
                export const m_iszSkyEntity = 0x4E0;
                export const m_flEndDistance = 0x4A8;
                export const m_bStartDisabled = 0x4CD;
                export const m_flFogHeightEnd = 0x4BC;
                export const m_nHeightFogType = 0x4E8;
                export const m_flFogMaxOpacity = 0x4D0;
                export const m_flStartDistance = 0x4AC;
                export const m_bHasHeightFogEnd = 0x5A0;
                export const m_flFogHeightStart = 0x4C0;
                export const m_flFogHeightWidth = 0x4B8;
                export const m_nDistanceFogType = 0x4F4;
                export const m_bHeightFogEnabled = 0x4B4;
                export const m_hFogCubemapTexture = 0x598;
                export const m_nCubemapSourceType = 0x4D4;
                export const m_flFogHeightExponent = 0x4C4;
                export const m_nFogHeightBlendMode = 0x4EC;
                export const m_HeightFogCurveString = 0x500;
                export const m_flFogFalloffExponent = 0x4B0;
                export const m_DistanceFogCurveString = 0x4F8;
                export const m_nFogHeightCoordinateSpace = 0x4F0;
            }
            export namespace CEnvSoundscape {
                export const m_OnPlay = 0x4A8;
                export const m_flRadius = 0x4C0;
                export const m_bDisabled = 0x524;
                export const m_positionNames = 0x4E0;
                export const m_soundEventHash = 0x530;
                export const m_soundEventName = 0x4C8;
                export const m_soundscapeName = 0x528;
                export const m_soundscapeIndex = 0x4D4;
                export const m_hProxySoundscape = 0x520;
                export const m_bOverrideWithEvent = 0x4D0;
                export const m_soundscapeEntityListId = 0x4D8;
            }
            export namespace CEnvWindShared {
                export const m_iMaxGust = 0x1A;
                export const m_iMaxWind = 0x12;
                export const m_iMinGust = 0x18;
                export const m_iMinWind = 0x10;
                export const m_location = 0x30;
                export const m_OnGustEnd = 0x58;
                export const m_hEntOwner = 0x70;
                export const m_iWindSeed = 0xC;
                export const m_windRadius = 0x14;
                export const m_OnGustStart = 0x40;
                export const m_flStartTime = 0x8;
                export const m_flGustDuration = 0x24;
                export const m_flMaxGustDelay = 0x20;
                export const m_flMinGustDelay = 0x1C;
                export const m_iGustDirChange = 0x28;
                export const m_iInitialWindDir = 0x2A;
                export const m_flInitialWindSpeed = 0x2C;
            }
            export namespace CFilterContext {
                export const m_iFilterContext = 0x4E0;
            }
            export namespace CFiringModeInt {
                export const m_nValues = 0x0;
            }
            export namespace CFogController {
                export const m_fog = 0x4A8;
                export const m_bUseAngles = 0x510;
                export const m_iChangedVariables = 0x514;
            }
            export namespace CFuncTankTrain {
                export const m_OnDeath = 0x978;
            }
            export namespace CFuncTimescale {
                export const m_isStarted = 0x4B8;
                export const m_flAcceleration = 0x4AC;
                export const m_flMinBlendRate = 0x4B0;
                export const m_flDesiredTimescale = 0x4A8;
                export const m_flBlendDeltaMultiplier = 0x4B4;
            }
            export namespace CFuncTrackAuto {

            }
            export namespace CGameSceneNode {
                export const m_name = 0xF0;
                export const m_pChild = 0x40;
                export const m_pOwner = 0x30;
                export const m_flScale = 0xC4;
                export const m_hParent = 0x70;
                export const m_pParent = 0x38;
                export const m_bDormant = 0xE7;
                export const m_vecOrigin = 0x80;
                export const m_flAbsScale = 0xE0;
                export const m_angRotation = 0xB8;
                export const m_nodeToWorld = 0x10;
                export const m_pNextSibling = 0x48;
                export const m_vecAbsOrigin = 0xC8;
                export const m_angAbsRotation = 0xD4;
                export const m_bBoneMergeFlex = 0x0;
                export const m_nHierarchyType = 0xEC;
                export const m_bDirtyHierarchy = 0x0;
                export const m_nLatchAbsOrigin = 0x0;
                export const m_flClientLocalScale = 0x108;
                export const m_nHierarchicalDepth = 0xEB;
                export const m_bDirtyBoneMergeInfo = 0x0;
                export const m_hierarchyAttachName = 0x104;
                export const m_bDebugAbsOriginChanges = 0xE6;
                export const m_bNetworkedScaleChanged = 0x0;
                export const m_bNetworkedAnglesChanged = 0x0;
                export const m_nParentAttachmentOrBone = 0xE4;
                export const m_bDirtyBoneMergeBoneToRoot = 0x0;
                export const m_bForceParentToBeNetworked = 0xE8;
                export const m_bNetworkedPositionChanged = 0x0;
                export const m_bWillBeCallingPostDataUpdate = 0x0;
                export const m_nDoNotSetAnimTimeInInvalidatePhysicsCount = 0xED;
            }
            export namespace CInButtonState {
                export const m_pButtonStates = 0x8;
            }
            export namespace CLogicAutosave {
                export const m_minHitPoints = 0x4AC;
                export const m_bForceNewLevelUnit = 0x4A8;
                export const m_minHitPointsToCommit = 0x4B0;
            }
            export namespace CLogicalEntity {

            }
            export namespace CMessageEntity {
                export const m_radius = 0x4A8;
                export const m_bEnabled = 0x4BA;
                export const m_drawText = 0x4B8;
                export const m_messageText = 0x4B0;
                export const m_bDeveloperOnly = 0x4B9;
            }
            export namespace CMoverPathNode {
                export const m_OnPassThrough = 0x540;
                export const m_OnPassThroughForward = 0x560;
                export const m_OnPassThroughReverse = 0x580;
                export const m_OnStartFromOrInSegment = 0x500;
                export const m_OnStoppedAtOrInSegment = 0x520;
            }
            export namespace CPathQueryUtil {
                export const m_bIsClosedLoop = 0x78;
                export const m_PathToEntityTransform = 0x10;
                export const m_vecPathSampleDistances = 0x60;
                export const m_vecPathSamplePositions = 0x30;
                export const m_vecPathSampleParameters = 0x48;
            }
            export namespace CPhysExplosion {
                export const m_radius = 0x4B4;
                export const m_flDamage = 0x4B0;
                export const m_flMagnitude = 0x4AC;
                export const m_flPushScale = 0x4CC;
                export const m_flInnerRadius = 0x4C8;
                export const m_OnPushedPlayer = 0x4D8;
                export const m_bExplodeOnSpawn = 0x4A8;
                export const m_ignoreEntityName = 0x4C0;
                export const m_targetEntityName = 0x4B8;
                export const m_bDisablePushClamp = 0x4D2;
                export const m_bAffectInvulnerableEnts = 0x4D1;
                export const m_bConvertToDebrisWhenPossible = 0x4D0;
            }
            export namespace CPhysicsSpring {
                export const m_end = 0x4DC;
                export const m_start = 0x4D0;
                export const m_flFrequency = 0x4B0;
                export const m_flRestLength = 0x4B8;
                export const m_pSpringJoint = 0x4A8;
                export const m_teleportTick = 0x4E8;
                export const m_nameAttachEnd = 0x4C8;
                export const m_flDampingRatio = 0x4B4;
                export const m_nameAttachStart = 0x4C0;
            }
            export namespace CPointGiveAmmo {
                export const m_pActivator = 0x4A8;
            }
            export namespace CPointTeleport {
                export const m_vSaveAngles = 0x4B4;
                export const m_vSaveOrigin = 0x4A8;
                export const m_bTeleportUseCurrentAngle = 0x4C1;
                export const m_bTeleportParentedEntities = 0x4C0;
            }
            export namespace CPointTemplate {
                export const m_iszWorldName = 0x4A8;
                export const m_OnEntitySpawned = 0x510;
                export const m_flTimeoutInterval = 0x4C0;
                export const m_ScriptCallbackScope = 0x508;
                export const m_ScriptSpawnCallback = 0x500;
                export const m_iszEntityFilterName = 0x4B8;
                export const m_ownerSpawnGroupType = 0x4CC;
                export const m_SpawnedEntityHandles = 0x4E8;
                export const m_clientOnlyEntityBehavior = 0x4C8;
                export const m_createdSpawnGroupHandles = 0x4D0;
                export const m_iszSource2EntityLumpName = 0x4B0;
                export const m_bAsynchronouslySpawnEntities = 0x4C4;
            }
            export namespace CPrecipitation {

            }
            export namespace CPulseGraphDef {
                export const m_Vars = 0x80;
                export const m_Cells = 0x68;
                export const m_Chunks = 0x50;
                export const m_CallInfos = 0xE0;
                export const m_Constants = 0xF8;
                export const m_DomainValues = 0x110;
                export const m_TempVarBanks = 0x98;
                export const m_DomainSubType = 0x18;
                export const m_ParentMapName = 0x30;
                export const m_ParentXmlName = 0x40;
                export const m_PublicOutputs = 0xB0;
                export const m_InvokeBindings = 0xC8;
                export const m_DomainIdentifier = 0x8;
                export const m_OutputConnections = 0x140;
                export const m_BlackboardReferences = 0x128;
            }
            export namespace CRagdollMagnet {
                export const m_axis = 0x4B4;
                export const m_force = 0x4B0;
                export const m_radius = 0x4AC;
                export const m_bDisabled = 0x4A8;
            }
            export namespace CRandStopwatch {
                export const m_flMaxInterval = 0x10;
                export const m_flMinInterval = 0xC;
            }
            export namespace CResponseQueue {
                export const m_ExpresserTargets = 0x38;
            }
            export namespace CRotatorTarget {

            }
            export namespace CSMatchStats_t {
                export const m_i1v1Wins = 0xA8;
                export const m_i1v2Wins = 0xB0;
                export const m_i1v1Count = 0xA4;
                export const m_i1v2Count = 0xAC;
                export const m_iEnemy2Ks = 0x7C;
                export const m_iEnemy3Ks = 0x70;
                export const m_iEnemy4Ks = 0x6C;
                export const m_iEnemy5Ks = 0x68;
                export const m_iEntryWins = 0xB8;
                export const m_iEntryCount = 0xB4;
                export const m_iFlash_Count = 0x8C;
                export const m_iUtility_Count = 0x80;
                export const m_iEnemyKnifeKills = 0x74;
                export const m_iEnemyTaserKills = 0x78;
                export const m_iFlash_Successes = 0x90;
                export const m_iUtility_Enemies = 0x88;
                export const m_nShotsFiredTotal = 0x9C;
                export const m_iUtility_Successes = 0x84;
                export const m_nShotsOnTargetTotal = 0xA0;
                export const m_flHealthPointsDealtTotal = 0x98;
                export const m_flHealthPointsRemovedTotal = 0x94;
            }
            export namespace CSoundEnvelope {
                export const m_rate = 0x8;
                export const m_target = 0x4;
                export const m_current = 0x0;
                export const m_forceupdate = 0xC;
            }
            export namespace CStopwatchBase {
                export const m_bIsRunning = 0x8;
            }
            export namespace CTeamplayRules {

            }
            export namespace CTriggerImpact {
                export const m_flNoise = 0x9E4;
                export const m_flViewkick = 0x9E8;
                export const m_flMagnitude = 0x9E0;
                export const m_pOutputForce = 0x9F0;
            }
            export namespace CTriggerRemove {
                export const m_OnRemove = 0x9C8;
            }
            export namespace CTriggerVolume {
                export const m_hFilter = 0x858;
                export const m_iFilterName = 0x850;
            }
            export namespace CWeaponGalilAR {

            }
            export namespace CWeaponHKP2000 {

            }
            export namespace CountdownTimer {
                export const m_duration = 0x8;
                export const m_timescale = 0x10;
                export const m_timestamp = 0xC;
                export const m_nWorldGroupId = 0x14;
            }
            export namespace IHasAttributes {

            }
            export namespace ParticleNode_t {
                export const m_iIndex = 0x4;
                export const m_hEntity = 0x0;
                export const m_flStartTime = 0x8;
                export const m_flEndcapTime = 0x1C;
                export const m_vecGrowthOrigin = 0x10;
                export const m_bMarkedForDelete = 0x20;
                export const m_flGrowthDuration = 0xC;
            }
            export namespace Relationship_t {
                export const priority = 0x4;
                export const disposition = 0x0;
            }
            export namespace ResponseParams {
                export const odds = 0x10;
                export const flags = 0x12;
                export const m_pFollowup = 0x18;
            }
            export namespace SceneEventId_t {
                export const m_Value = 0x0;
            }
            export namespace SoundCommand_t {
                export const m_time = 0x8;
                export const m_value = 0x14;
                export const m_command = 0x10;
                export const m_deltaTime = 0xC;
            }
            export namespace globalentity_t {
                export const name = 0x0;
                export const state = 0x4;
                export const counter = 0x8;
                export const levelName = 0x2;
            }
            export namespace hudtextparms_t {
                export const x = 0xC;
                export const y = 0x10;
                export const color1 = 0x0;
                export const color2 = 0x4;
                export const effect = 0x8;
                export const channel = 0x9;
            }
            export namespace CAmbientGeneric {
                export const m_dpv = 0x4B4;
                export const m_radius = 0x4A8;
                export const m_fActive = 0x518;
                export const m_fLooping = 0x519;
                export const m_iszSound = 0x520;
                export const m_flMaxRadius = 0x4AC;
                export const m_iSoundLevel = 0x4B0;
                export const m_hSoundSource = 0x530;
                export const m_sSourceEntName = 0x528;
                export const m_nSoundSourceEntIndex = 0x534;
            }
            export namespace CBasePlayerPawn {
                export const v_angle = 0xBC8;
                export const m_fInitHUD = 0xC88;
                export const m_iHideHUD = 0xBE0;
                export const m_skybox3d = 0xBE8;
                export const m_pExpresser = 0xC90;
                export const m_flDeathTime = 0xC7C;
                export const m_hController = 0xC98;
                export const m_pUseServices = 0xB38;
                export const m_fTimeLastHurt = 0xC78;
                export const m_pItemServices = 0xB18;
                export const v_anglePrevious = 0xBD4;
                export const m_fHltvReplayEnd = 0xCA8;
                export const m_pWaterServices = 0xB30;
                export const m_pCameraServices = 0xB48;
                export const m_pWeaponServices = 0xB10;
                export const m_fHltvReplayDelay = 0xCA4;
                export const m_fNextSuicideTime = 0xC80;
                export const m_pAutoaimServices = 0xB20;
                export const m_iHltvReplayEntity = 0xCAC;
                export const m_pMovementServices = 0xB50;
                export const m_pObserverServices = 0xB28;
                export const m_sndOpvarLatchData = 0xCB0;
                export const m_hDefaultController = 0xC9C;
                export const m_pFlashlightServices = 0xB40;
                export const m_ServerViewAngleChanges = 0xB60;
            }
            export namespace CBtActionMoveTo {
                export const m_RepathTimer = 0xC0;
                export const m_bComputePath = 0x85;
                export const m_vecDestination = 0x78;
                export const m_bAutoLookAdjust = 0x84;
                export const m_flArrivalEpsilon = 0xD8;
                export const m_szThreatInputKey = 0x70;
                export const m_szHidingSpotInputKey = 0x68;
                export const m_CheckHighPriorityItem = 0xA8;
                export const m_szDestinationInputKey = 0x60;
                export const m_flDamagingAreasPenaltyCost = 0x88;
                export const m_CheckApproximateCornersTimer = 0x90;
                export const m_flAdditionalArrivalEpsilon2D = 0xDC;
                export const m_flNearestAreaDistanceThreshold = 0xE4;
                export const m_flHidingSpotCheckDistanceThreshold = 0xE0;
            }
            export namespace CBuoyancyHelper {
                export const m_nFluidType = 0x18;
                export const m_pController = 0x8;
                export const m_vecWheelDrag = 0x78;
                export const m_flFluidDensity = 0x1C;
                export const m_bNeutrallyBuoyant = 0x2C;
                export const m_vecWheelFrictionScales = 0x48;
                export const m_flNeutrallyBuoyantGravity = 0x20;
                export const m_flNeutrallyBuoyantLinearDamping = 0x24;
                export const m_flNeutrallyBuoyantAngularDamping = 0x28;
                export const m_vecFractionOfWheelSubmergedForWheelDrag = 0x60;
                export const m_vecFractionOfWheelSubmergedForWheelFriction = 0x30;
            }
            export namespace CCSObserverPawn {

            }
            export namespace CCSPetPlacement {

            }
            export namespace CCSRadarElement {
                export const m_nTeamFilter = 0x4C8;
                export const m_nElementType = 0x4C0;
                export const m_nElementColor = 0x4C4;
            }
            export namespace CCommentaryAuto {
                export const m_OnCommentaryMidGame = 0x4C0;
                export const m_OnCommentaryNewGame = 0x4A8;
                export const m_OnCommentaryMultiplayerSpawn = 0x4D8;
            }
            export namespace CEntityDissolve {
                export const m_nMagnitude = 0x87C;
                export const m_flStartTime = 0x868;
                export const m_flFadeInStart = 0x850;
                export const m_nDissolveType = 0x86C;
                export const m_flFadeInLength = 0x854;
                export const m_flFadeOutStart = 0x860;
                export const m_flFadeOutLength = 0x864;
                export const m_vDissolverOrigin = 0x870;
                export const m_flFadeOutModelStart = 0x858;
                export const m_flFadeOutModelLength = 0x85C;
            }
            export namespace CEntityIdentity {
                export const m_name = 0x18;
                export const m_flags = 0x30;
                export const m_pNext = 0x58;
                export const m_pPrev = 0x50;
                export const m_PathIndex = 0x40;
                export const m_pAttributes = 0x48;
                export const m_designerName = 0x20;
                export const m_pNextByClass = 0x68;
                export const m_pPrevByClass = 0x60;
                export const m_worldGroupId = 0x38;
                export const m_fDataObjectTypes = 0x3C;
                export const m_nameStringTableIndex = 0x14;
            }
            export namespace CEntityInstance {
                export const m_pEntity = 0x10;
                export const m_CScriptComponent = 0x28;
                export const m_iszPrivateVScripts = 0x8;
            }
            export namespace CEnvEntityMaker {
                export const m_iszTemplate = 0x4F0;
                export const m_vecEntityMaxs = 0x4B4;
                export const m_vecEntityMins = 0x4A8;
                export const m_hCurrentBlocker = 0x4C4;
                export const m_flPostSpawnSpeed = 0x4E4;
                export const m_hCurrentInstance = 0x4C0;
                export const m_pOutputOnSpawned = 0x4F8;
                export const m_vecBlockerOrigin = 0x4C8;
                export const m_bPostSpawnUseAngles = 0x4E8;
                export const m_pOutputOnFailedSpawn = 0x510;
                export const m_angPostSpawnDirection = 0x4D4;
                export const m_flPostSpawnDirectionVariance = 0x4E0;
            }
            export namespace CEnvMuzzleFlash {
                export const m_flScale = 0x4A8;
                export const m_iszParentAttachment = 0x4B0;
            }
            export namespace CFilterMultiple {
                export const m_hFilter = 0x538;
                export const m_iFilterName = 0x4E8;
                export const m_nFilterType = 0x4E0;
            }
            export namespace CFuncMoveLinear {
                export const m_flSpeed = 0x948;
                export const m_soundStop = 0x8F8;
                export const m_soundStart = 0x8F0;
                export const m_OnFullyOpen = 0x918;
                export const m_currentSound = 0x900;
                export const m_OnFullyClosed = 0x930;
                export const m_flBlockDamage = 0x908;
                export const m_flStartPosition = 0x90C;
                export const m_authoredPosition = 0x8D0;
                export const m_angMoveEntitySpace = 0x8D4;
                export const m_bCreateNavObstacle = 0x94E;
                export const m_bCreateMovableNavMesh = 0x94C;
                export const m_vecMoveDirParentSpace = 0x8E0;
                export const m_bAllowMovableNavMeshDockingOnEntireEntity = 0x94D;
            }
            export namespace CFuncNavBlocker {
                export const m_bDisabled = 0x858;
                export const m_nBlockedTeamNumber = 0x85C;
            }
            export namespace CFuncTrackTrain {
                export const m_dir = 0x8B4;
                export const m_ppath = 0x850;
                export const m_OnNext = 0x928;
                export const m_flBank = 0x8A0;
                export const m_height = 0x8AC;
                export const m_length = 0x854;
                export const m_OnStart = 0x910;
                export const m_angPrev = 0x864;
                export const m_flSpeed = 0x870;
                export const m_flVolume = 0x89C;
                export const m_maxSpeed = 0x8B0;
                export const m_oldSpeed = 0x8A4;
                export const m_vPosPrev = 0x858;
                export const m_controlMaxs = 0x880;
                export const m_controlMins = 0x874;
                export const m_flAccelSpeed = 0x964;
                export const m_flDecelSpeed = 0x968;
                export const m_iszSoundMove = 0x8B8;
                export const m_iszSoundStop = 0x8D0;
                export const m_lastBlockPos = 0x88C;
                export const m_bAccelToSpeed = 0x96C;
                export const m_eVelocityType = 0x8F8;
                export const m_flBlockDamage = 0x8A8;
                export const m_iszSoundStart = 0x8C8;
                export const m_lastBlockTick = 0x898;
                export const m_strPathTarget = 0x8D8;
                export const m_flDesiredSpeed = 0x95C;
                export const m_eOrientationType = 0x8F4;
                export const m_iszSoundMovePing = 0x8C0;
                export const m_flNextMPSoundTime = 0x970;
                export const m_flSpeedChangeTime = 0x960;
                export const m_bManualSpeedChanges = 0x958;
                export const m_flMoveSoundMaxPitch = 0x8F0;
                export const m_flMoveSoundMinPitch = 0x8EC;
                export const m_flNextMoveSoundTime = 0x8E8;
                export const m_flMoveSoundMaxDuration = 0x8E4;
                export const m_flMoveSoundMinDuration = 0x8E0;
                export const m_OnArrivedAtDestinationNode = 0x940;
            }
            export namespace CFuncWallToggle {

            }
            export namespace CGameGibManager {
                export const m_iLastFrame = 0x4CC;
                export const m_iMaxPieces = 0x4C8;
                export const m_bAllowNewGibs = 0x4C0;
                export const m_iCurrentMaxPieces = 0x4C4;
            }
            export namespace CGamePlayerZone {
                export const m_OnPlayerInZone = 0x858;
                export const m_PlayersInCount = 0x888;
                export const m_OnPlayerOutZone = 0x870;
                export const m_PlayersOutCount = 0x8A8;
            }
            export namespace CGameRulesProxy {

            }
            export namespace CInfoWorldLayer {
                export const m_layerName = 0x4C8;
                export const m_worldName = 0x4C0;
                export const m_bEntitiesSpawned = 0x4D1;
                export const m_hLayerSpawnGroup = 0x4D4;
                export const m_bWorldLayerVisible = 0x4D0;
                export const m_bCreateAsChildSpawnGroup = 0x4D2;
                export const m_pOutputOnEntitiesSpawned = 0x4A8;
            }
            export namespace CLightComponent {
                export const m_Color = 0x78;
                export const m_flPhi = 0xA4;
                export const m_nStyle = 0xD4;
                export const m_Pattern = 0xD8;
                export const m_flRange = 0x8C;
                export const m_flTheta = 0xA0;
                export const m_SkyColor = 0x190;
                export const m_bEnabled = 0x140;
                export const m_bFlicker = 0x141;
                export const m_flFalloff = 0x90;
                export const m_nCascades = 0xB0;
                export const m_flBrightness = 0x80;
                export const m_hLightCookie = 0xA8;
                export const m_nBounceLight = 0x128;
                export const m_nCastShadows = 0xB4;
                export const m_nDirectLight = 0x124;
                export const m_nShadowWidth = 0xB8;
                export const m_bMixedShadows = 0x19D;
                export const m_flBounceScale = 0x12C;
                export const m_flFadeMaxDist = 0x134;
                export const m_flFadeMinDist = 0x130;
                export const m_nShadowHeight = 0xBC;
                export const __m_pChainEntity = 0x38;
                export const m_SecondaryColor = 0x7C;
                export const m_bRenderDiffuse = 0xC0;
                export const m_flAttenuation0 = 0x94;
                export const m_flAttenuation1 = 0x98;
                export const m_flAttenuation2 = 0x9C;
                export const m_flMinRoughness = 0x1A8;
                export const m_flSkyIntensity = 0x194;
                export const m_flCapsuleLength = 0x1A4;
                export const m_flNearClipPlane = 0x18C;
                export const m_nRenderSpecular = 0xC4;
                export const m_nShadowPriority = 0x110;
                export const m_SkyAmbientBounce = 0x198;
                export const m_bPvsModifyEntity = 0x1B8;
                export const m_flBrightnessMult = 0x88;
                export const m_nFogLightingMode = 0x184;
                export const m_bRenderToCubemaps = 0x120;
                export const m_flBrightnessScale = 0x84;
                export const m_flOrthoLightWidth = 0xCC;
                export const m_nBakedShadowIndex = 0x114;
                export const m_nLightMapUniqueId = 0x11C;
                export const m_bUseSecondaryColor = 0x19C;
                export const m_flOrthoLightHeight = 0xD0;
                export const m_nLightPathUniqueId = 0x118;
                export const m_bAllowSSTGeneration = 0x121;
                export const m_bRenderTransmissive = 0xC8;
                export const m_bUsesBakedShadowing = 0x10C;
                export const m_flShadowFadeMaxDist = 0x13C;
                export const m_flShadowFadeMinDist = 0x138;
                export const m_flLightStyleStartTime = 0x1A0;
                export const m_flPrecomputedMaxRange = 0x180;
                export const m_vPrecomputedOBBAngles = 0x168;
                export const m_vPrecomputedOBBExtent = 0x174;
                export const m_vPrecomputedOBBOrigin = 0x15C;
                export const m_vPrecomputedBoundsMaxs = 0x150;
                export const m_vPrecomputedBoundsMins = 0x144;
                export const m_bPrecomputedFieldsValid = 0x142;
                export const m_flFogContributionStength = 0x188;
                export const m_flShadowCascadeCrossFade = 0xE4;
                export const m_flShadowCascadeDistance0 = 0xEC;
                export const m_flShadowCascadeDistance1 = 0xF0;
                export const m_flShadowCascadeDistance2 = 0xF4;
                export const m_flShadowCascadeDistance3 = 0xF8;
                export const m_nShadowCascadeResolution0 = 0xFC;
                export const m_nShadowCascadeResolution1 = 0x100;
                export const m_nShadowCascadeResolution2 = 0x104;
                export const m_nShadowCascadeResolution3 = 0x108;
                export const m_flShadowCascadeDistanceFade = 0xE8;
                export const m_nCascadeRenderStaticObjects = 0xE0;
            }
            export namespace CLogicGameEvent {
                export const m_iszEventName = 0x4A8;
            }
            export namespace CLogicProximity {

            }
            export namespace CMathColorBlend {
                export const m_flInMax = 0x4AC;
                export const m_flInMin = 0x4A8;
                export const m_OutValue = 0x4B8;
                export const m_OutColor1 = 0x4B0;
                export const m_OutColor2 = 0x4B4;
            }
            export namespace CMolotovGrenade {

            }
            export namespace CMultiplayRules {

            }
            export namespace CParticleSystem {
                export const m_bActive = 0xA50;
                export const m_bFrozen = 0xA51;
                export const m_bNoRamp = 0xBB2;
                export const m_bNoSave = 0xBB0;
                export const m_clrTint = 0xDD4;
                export const m_nDataCP = 0xDC0;
                export const m_nTintCP = 0xDD0;
                export const m_bNoFreeze = 0xBB1;
                export const m_nStopType = 0xA58;
                export const m_flStartTime = 0xA68;
                export const m_bStartActive = 0xBB3;
                export const m_flPreSimTime = 0xA6C;
                export const m_iEffectIndex = 0xA60;
                export const m_iszEffectName = 0xBB8;
                export const m_strDataString = 0xBA8;
                export const m_vecDataCPValue = 0xDC4;
                export const m_hControlPointEnts = 0xAA4;
                export const m_szSnapshotFileName = 0x850;
                export const m_bDataStringLocalized = 0xBA4;
                export const m_iszControlPointNames = 0xBC0;
                export const m_vServerControlPoints = 0xA70;
                export const m_flFreezeTransitionDuration = 0xA54;
                export const m_bAnimateDuringGameplayPause = 0xA5C;
                export const m_iServerControlPointAssignments = 0xAA0;
            }
            export namespace CPhysBallSocket {
                export const m_flSwingLimit = 0x510;
                export const m_flJointFriction = 0x508;
                export const m_flMaxTwistAngle = 0x51C;
                export const m_flMinTwistAngle = 0x518;
                export const m_bEnableSwingLimit = 0x50C;
                export const m_bEnableTwistLimit = 0x514;
            }
            export namespace CPhysConstraint {
                export const m_hJoint = 0x4A8;
                export const m_OnBreak = 0x4F0;
                export const m_hAttach1 = 0x4C0;
                export const m_hAttach2 = 0x4C4;
                export const m_breakSound = 0x4D8;
                export const m_forceLimit = 0x4E0;
                export const m_nameAttach1 = 0x4B0;
                export const m_nameAttach2 = 0x4B8;
                export const m_torqueLimit = 0x4E4;
                export const m_nameAttachment1 = 0x4C8;
                export const m_nameAttachment2 = 0x4D0;
                export const m_minTeleportDistance = 0x4E8;
                export const m_bSnapObjectPositions = 0x4EC;
                export const m_bTreatEntity1AsInfiniteMass = 0x4ED;
            }
            export namespace CPhysicalButton {

            }
            export namespace CPointWorldText {
                export const m_Color = 0xAF0;
                export const m_FontName = 0xA50;
                export const m_bEnabled = 0xAD0;
                export const m_flFontSize = 0xAD8;
                export const m_bFullbright = 0xAD1;
                export const m_messageText = 0x850;
                export const m_flDepthOffset = 0xADC;
                export const m_nReorientMode = 0xAFC;
                export const m_bDrawBackground = 0xAE0;
                export const m_nJustifyVertical = 0xAF8;
                export const m_flWorldUnitsPerPx = 0xAD4;
                export const m_nJustifyHorizontal = 0xAF4;
                export const m_flBackgroundWorldToUV = 0xAEC;
                export const m_BackgroundMaterialName = 0xA90;
                export const m_flBackgroundBorderWidth = 0xAE4;
                export const m_flBackgroundBorderHeight = 0xAE8;
            }
            export namespace CPulseCell_Base {
                export const m_nEditorNodeID = 0x8;
            }
            export namespace CPulse_CallInfo {
                export const m_PortName = 0x0;
                export const m_nSrcChunk = 0x4C;
                export const m_RegisterMap = 0x18;
                export const m_CallMethodID = 0x48;
                export const m_nEditorNodeID = 0x10;
                export const m_nBreakDestChunk = 0x54;
                export const m_nSrcInstruction = 0x50;
                export const m_nBreakDestInstruction = 0x58;
            }
            export namespace CRagdollManager {
                export const m_bCanTakeDamage = 0x4B1;
                export const m_bSaveImportant = 0x4B0;
                export const m_iMaxRagdollCount = 0x4AC;
                export const m_iCurrentMaxRagdollCount = 0x4A8;
            }
            export namespace CRopeOverlapHit {
                export const m_hEntity = 0x0;
                export const m_vecOverlappingLinks = 0x8;
            }
            export namespace CSceneEventInfo {
                export const m_nType = 0x3C;
                export const m_flNext = 0x40;
                export const m_iLayer = 0x0;
                export const m_hTarget = 0x6C;
                export const m_bStarted = 0x75;
                export const m_flWeight = 0xC;
                export const m_hAnimClip = 0x20;
                export const m_hSequence = 0x8;
                export const m_iPriority = 0x4;
                export const m_bIsGesture = 0x44;
                export const m_bClientSide = 0x74;
                export const m_bHasArrived = 0x38;
                export const m_flLastCycle = 0x1C;
                export const m_bShouldRemove = 0x45;
                export const m_nSceneEventId = 0x70;
                export const m_sAnimClipSlot = 0x28;
                export const m_flLastJumpToTime = 0x18;
                export const m_flLastJumpFromTime = 0x14;
                export const m_sAnimClipSlotWeight = 0x30;
                export const m_flLastAccumulatedTime = 0x10;
            }
            export namespace CSimpleSimTimer {
                export const m_flNext = 0x0;
                export const m_nWorldGroupId = 0x4;
            }
            export namespace CSoundStackSave {
                export const m_iszStackName = 0x4A8;
            }
            export namespace CSpriteOriented {

            }
            export namespace CTakeDamageInfo {
                export const m_flDamage = 0x44;
                export const m_hAbility = 0x40;
                export const m_hAttacker = 0x3C;
                export const m_iAmmoType = 0x54;
                export const m_hInflictor = 0x38;
                export const m_iHitGroupId = 0x78;
                export const m_bShouldBleed = 0x64;
                export const m_bShouldSpark = 0x65;
                export const m_nDamageFlags = 0x70;
                export const m_iDamageCustom = 0x50;
                export const m_bStoppedBullet = 0x84;
                export const m_bitsDamageType = 0x4C;
                export const m_vecDamageForce = 0x8;
                export const m_flOriginalDamage = 0x60;
                export const m_flTotalledDamage = 0x48;
                export const m_bInTakeDamageFlow = 0x110;
                export const m_vecDamagePosition = 0x14;
                export const m_vecDamageDirection = 0x2C;
                export const m_vecReportedPosition = 0x20;
                export const m_nNumObjectsPenetrated = 0x7C;
                export const m_DestructibleHitGroupRequests = 0x100;
                export const m_flFriendlyFireDamageReductionRatio = 0x80;
            }
            export namespace CTonemapTrigger {
                export const m_hTonemapController = 0x9D0;
                export const m_tonemapControllerName = 0x9C8;
            }
            export namespace CTriggerGravity {

            }
            export namespace CTriggerPhysics {
                export const m_flFrequency = 0x9F0;
                export const m_linearForce = 0x9EC;
                export const m_linearLimit = 0x9DC;
                export const m_pController = 0x9D0;
                export const m_angularLimit = 0x9E4;
                export const m_gravityScale = 0x9D8;
                export const m_linearDamping = 0x9E0;
                export const m_angularDamping = 0x9E8;
                export const m_flDampingRatio = 0x9F4;
                export const m_bCollapseToForcePoint = 0xA04;
                export const m_vecLinearForcePointAt = 0x9F8;
                export const m_vecLinearForceDirection = 0xA14;
                export const m_vecLinearForcePointAtWorld = 0xA08;
                export const m_bConvertToDebrisWhenPossible = 0xA21;
                export const m_bForceDirectionIsInLocalSpace = 0xA20;
            }
            export namespace CVoteController {
                export const m_nVotesCast = 0x518;
                export const m_VoteOptions = 0x640;
                export const m_bIsYesNoVote = 0x4C8;
                export const m_resetVoteTimer = 0x500;
                export const m_iOnlyTeamToVote = 0x4AC;
                export const m_nPotentialVotes = 0x4C4;
                export const m_potentialIssues = 0x628;
                export const m_nVoteOptionCount = 0x4B0;
                export const m_iActiveIssueIndex = 0x4A8;
                export const m_playerHoldingVote = 0x618;
                export const m_nHighestCountIndex = 0x620;
                export const m_acceptingVotesTimer = 0x4D0;
                export const m_executeCommandTimer = 0x4E8;
                export const m_playerOverrideForVote = 0x61C;
            }
            export namespace CWeaponBaseItem {
                export const m_bRedraw = 0x1281;
                export const m_bSequenceInProgress = 0x1280;
            }
            export namespace CWeaponRevolver {

            }
            export namespace CWeaponSawedoff {

            }
            export namespace ChickenPathCost {

            }
            export namespace HostagePathCost {

            }
            export namespace IChoreoServices {

            }
            export namespace ParticleIndex_t {
                export const m_Value = 0x0;
            }
            export namespace VelocitySampler {
                export const m_prevSample = 0x0;
                export const m_fPrevSampleTime = 0xC;
                export const m_fIdealSampleRate = 0x10;
            }
            export namespace ActorClipEntry_t {
                export const m_bLooping = 0x8;
                export const m_sClipName = 0x0;
            }
            export namespace ApproachAreaCost {

            }
            export namespace CBaseModelEntity {
                export const m_Glow = 0x6A0;
                export const m_OnIgnite = 0x538;
                export const m_Collision = 0x5E8;
                export const m_clrRender = 0x570;
                export const m_nRenderFX = 0x551;
                export const m_fadeMaxDist = 0x700;
                export const m_fadeMinDist = 0x6FC;
                export const m_flFadeScale = 0x704;
                export const m_nRenderMode = 0x550;
                export const m_vecViewOffset = 0x818;
                export const m_bNoInterpolate = 0x5E2;
                export const m_nObjectCulling = 0x70C;
                export const m_CHitboxComponent = 0x4B0;
                export const m_CRenderComponent = 0x4A8;
                export const m_bAllowFadeInView = 0x552;
                export const m_bodyGroupChoices = 0x7F0;
                export const m_flShadowStrength = 0x708;
                export const m_pChoreoComponent = 0x4C8;
                export const m_bRenderToCubemaps = 0x5E0;
                export const m_bodyGroupRequests = 0x718;
                export const m_flGlowBackfaceMult = 0x6F8;
                export const m_bvDisabledHitGroups = 0x848;
                export const m_flDissolveStartTime = 0x530;
                export const m_vecRenderAttributes = 0x578;
                export const m_bodyGroupTotalRequestCount = 0x710;
                export const m_bExpandRenderBoundsToIncludeCloth = 0x5E1;
                export const m_pDestructiblePartsSystemComponent = 0x500;
                export const m_OnDestructibleHitGroupDamageLevelChanged = 0x508;
                export const m_nDestructiblePartInitialStateDestructed0 = 0x4D0;
                export const m_nDestructiblePartInitialStateDestructed1 = 0x4D4;
                export const m_nDestructiblePartInitialStateDestructed2 = 0x4D8;
                export const m_nDestructiblePartInitialStateDestructed3 = 0x4DC;
                export const m_nDestructiblePartInitialStateDestructed4 = 0x4E0;
                export const m_nDestructiblePartInitialStateDestructed0_PartIndex = 0x4E4;
                export const m_nDestructiblePartInitialStateDestructed1_PartIndex = 0x4E8;
                export const m_nDestructiblePartInitialStateDestructed2_PartIndex = 0x4EC;
                export const m_nDestructiblePartInitialStateDestructed3_PartIndex = 0x4F0;
                export const m_nDestructiblePartInitialStateDestructed4_PartIndex = 0x4F4;
                export const m_bDestructiblePartInitialStateDestructed0_GenerateBreakpieces = 0x4F8;
                export const m_bDestructiblePartInitialStateDestructed1_GenerateBreakpieces = 0x4F9;
                export const m_bDestructiblePartInitialStateDestructed2_GenerateBreakpieces = 0x4FA;
                export const m_bDestructiblePartInitialStateDestructed3_GenerateBreakpieces = 0x4FB;
                export const m_bDestructiblePartInitialStateDestructed4_GenerateBreakpieces = 0x4FC;
            }
            export namespace CBasePlayerVData {
                export const m_flUseRange = 0x24C;
                export const m_sModelName = 0x28;
                export const m_nWaterSpeed = 0x248;
                export const m_flCrouchTime = 0x254;
                export const m_flHoldBreathTime = 0x238;
                export const m_nDrowningDamageMax = 0x244;
                export const m_flUseAngleTolerance = 0x250;
                export const m_flArmDamageMultiplier = 0x218;
                export const m_flLegDamageMultiplier = 0x228;
                export const m_sModelNameAg2Override = 0x108;
                export const m_flHeadDamageMultiplier = 0x1E8;
                export const m_nDrowningDamageInitial = 0x240;
                export const m_flChestDamageMultiplier = 0x1F8;
                export const m_flDrowningDamageInterval = 0x23C;
                export const m_flStomachDamageMultiplier = 0x208;
            }
            export namespace CBrokenGlassTrap {

            }
            export namespace CBtNodeComposite {

            }
            export namespace CBtNodeCondition {
                export const m_bNegated = 0x58;
            }
            export namespace CBtNodeDecorator {

            }
            export namespace CCSGameModeRules {
                export const __m_pChainEntity = 0x8;
            }
            export namespace CCSMinimapVolume {
                export const m_strMinimapName = 0x9C8;
            }
            export namespace CCSWeaponBaseGun {
                export const m_zoomLevel = 0x1280;
                export const m_inPrecache = 0x1294;
                export const m_bNeedsBoltAction = 0x1295;
                export const m_silencedModelIndex = 0x1290;
                export const m_iBurstShotsRemaining = 0x1284;
                export const m_nRevolverCylinderIdx = 0x1298;
                export const m_bSkillReloadAvailable = 0x129C;
                export const m_bSkillBoltLiftedFireKey = 0x129F;
                export const m_bSkillReloadLiftedReloadKey = 0x129D;
                export const m_bSkillBoltInterruptAvailable = 0x129E;
            }
            export namespace CChoreoComponent {
                export const m_hOwner = 0x30;
                export const __m_pChainEntity = 0x8;
                export const m_nNextSceneEventId = 0x70;
                export const m_flAllowResponsesEndTime = 0x74;
                export const m_nExernalChoreoGraphCount = 0x34;
                export const m_sActiveExternalChoreoGraphSlotID = 0x38;
            }
            export namespace CColorCorrection {
                export const m_bMaster = 0x4C6;
                export const m_bEnabled = 0x4C5;
                export const m_MaxFalloff = 0x4D0;
                export const m_MinFalloff = 0x4CC;
                export const m_bExclusive = 0x4C8;
                export const m_bClientSide = 0x4C7;
                export const m_flCurWeight = 0x4D4;
                export const m_flMaxWeight = 0x4C0;
                export const m_bStartDisabled = 0x4C4;
                export const m_lookupFilename = 0x6D8;
                export const m_flFadeInDuration = 0x4A8;
                export const m_flFadeOutDuration = 0x4AC;
                export const m_flTimeStartFadeIn = 0x4B8;
                export const m_netlookupFilename = 0x4D8;
                export const m_flTimeStartFadeOut = 0x4BC;
                export const m_flStartFadeInWeight = 0x4B0;
                export const m_flStartFadeOutWeight = 0x4B4;
            }
            export namespace CDecalGroupVData {
                export const m_vecOptions = 0x0;
                export const m_flTotalProbability = 0x18;
            }
            export namespace CDecoyProjectile {
                export const m_fExpireTime = 0xB60;
                export const m_nDecoyShotTick = 0xB58;
                export const m_shotsRemaining = 0xB5C;
                export const m_decoyWeaponDefIndex = 0xB70;
            }
            export namespace CEntityComponent {

            }
            export namespace CEnvParticleGlow {
                export const m_ColorTint = 0xDE4;
                export const m_flAlphaScale = 0xDD8;
                export const m_flRadiusScale = 0xDDC;
                export const m_flSelfIllumScale = 0xDE0;
                export const m_hTextureOverride = 0xDE8;
            }
            export namespace CFilterProximity {
                export const m_flRadius = 0x4E0;
            }
            export namespace CFiringModeFloat {
                export const m_flValues = 0x0;
            }
            export namespace CFootstepControl {
                export const m_source = 0x9C8;
                export const m_destination = 0x9D0;
            }
            export namespace CFuncIllusionary {

            }
            export namespace CFuncMoverRouter {
                export const m_hPathMover = 0x4B0;
                export const m_nMoverIndex = 0x4A8;
                export const m_iszPathMoverName = 0x4B8;
                export const m_bRouteToAllMovers = 0x4AC;
            }
            export namespace CFuncTrackChange {
                export const m_use = 0x950;
                export const m_code = 0x948;
                export const m_train = 0x928;
                export const m_trackTop = 0x920;
                export const m_trainName = 0x940;
                export const m_targetState = 0x94C;
                export const m_trackBottom = 0x924;
                export const m_trackTopName = 0x930;
                export const m_trackBottomName = 0x938;
            }
            export namespace CFuncVehicleClip {

            }
            export namespace CGamePlayerEquip {

            }
            export namespace CHitboxComponent {
                export const m_flBoundsExpandRadius = 0x14;
            }
            export namespace CInfoPlayerStart {
                export const m_bDisabled = 0x4A8;
                export const m_bIsMaster = 0x4A9;
                export const m_pPawnSubclass = 0x4B0;
            }
            export namespace CItemAssaultSuit {

            }
            export namespace CItem_Healthshot {

            }
            export namespace CLightSpotEntity {

            }
            export namespace CLogicBranchList {
                export const m_OnMixed = 0x578;
                export const m_OnAllTrue = 0x548;
                export const m_OnAllFalse = 0x560;
                export const m_eLastState = 0x540;
                export const m_LogicBranchList = 0x528;
                export const m_nLogicBranchNames = 0x4A8;
            }
            export namespace CLogicNPCCounter {
                export const m_hSource = 0x668;
                export const m_bDisabled = 0x67C;
                export const m_OnFactor_1 = 0x548;
                export const m_OnFactor_2 = 0x5B8;
                export const m_OnFactor_3 = 0x628;
                export const m_OnFactorAll = 0x4D8;
                export const m_nMaxCount_1 = 0x6AC;
                export const m_nMaxCount_2 = 0x6D4;
                export const m_nMaxCount_3 = 0x6FC;
                export const m_nMinCount_1 = 0x6A8;
                export const m_nMinCount_2 = 0x6D0;
                export const m_nMinCount_3 = 0x6F8;
                export const m_nNPCState_1 = 0x6A0;
                export const m_nNPCState_2 = 0x6C8;
                export const m_nNPCState_3 = 0x6F0;
                export const m_OnMaxCount_1 = 0x530;
                export const m_OnMaxCount_2 = 0x5A0;
                export const m_OnMaxCount_3 = 0x610;
                export const m_OnMinCount_1 = 0x518;
                export const m_OnMinCount_2 = 0x588;
                export const m_OnMinCount_3 = 0x5F8;
                export const m_nMaxCountAll = 0x684;
                export const m_nMaxFactor_1 = 0x6B4;
                export const m_nMaxFactor_2 = 0x6DC;
                export const m_nMaxFactor_3 = 0x704;
                export const m_nMinCountAll = 0x680;
                export const m_nMinFactor_1 = 0x6B0;
                export const m_nMinFactor_2 = 0x6D8;
                export const m_nMinFactor_3 = 0x700;
                export const m_OnMaxCountAll = 0x4C0;
                export const m_OnMinCountAll = 0x4A8;
                export const m_flDistanceMax = 0x678;
                export const m_nMaxFactorAll = 0x68C;
                export const m_nMinFactorAll = 0x688;
                export const m_bInvertState_1 = 0x6A4;
                export const m_bInvertState_2 = 0x6CC;
                export const m_bInvertState_3 = 0x6F4;
                export const m_flDefaultDist_1 = 0x6BC;
                export const m_flDefaultDist_2 = 0x6E4;
                export const m_flDefaultDist_3 = 0x70C;
                export const m_OnMinPlayerDist_1 = 0x568;
                export const m_OnMinPlayerDist_2 = 0x5D8;
                export const m_OnMinPlayerDist_3 = 0x648;
                export const m_iszNPCClassname_1 = 0x698;
                export const m_iszNPCClassname_2 = 0x6C0;
                export const m_iszNPCClassname_3 = 0x6E8;
                export const m_OnMinPlayerDistAll = 0x4F8;
                export const m_iszSourceEntityName = 0x670;
            }
            export namespace CLogicNavigation {
                export const m_isOn = 0x4B0;
                export const m_navProperty = 0x4B4;
            }
            export namespace CMotorController {
                export const m_axis = 0x10;
                export const m_speed = 0x8;
                export const m_maxTorque = 0xC;
                export const m_inertiaFactor = 0x1C;
            }
            export namespace CMultiLightProxy {
                export const m_vecLights = 0x4D0;
                export const m_flBrightnessDelta = 0x4BC;
                export const m_bPerformScreenFade = 0x4C0;
                export const m_iszLightNameFilter = 0x4A8;
                export const m_flLightRadiusFilter = 0x4B8;
                export const m_iszLightClassFilter = 0x4B0;
                export const m_flTargetBrightnessMultiplier = 0x4C4;
                export const m_flCurrentBrightnessMultiplier = 0x4C8;
            }
            export namespace CNavVolumeSphere {
                export const m_vCenter = 0x78;
                export const m_flRadius = 0x84;
            }
            export namespace CNavVolumeVector {
                export const m_bHasBeenPreFiltered = 0x80;
            }
            export namespace CNmEventConsumer {

            }
            export namespace CNoiseStreamData {
                export const m_Stream = 0x0;
            }
            export namespace CPathCornerCrash {

            }
            export namespace CPointCameraVFOV {
                export const m_flVerticalFOV = 0x508;
            }
            export namespace CPulseExecCursor {

            }
            export namespace CRenderComponent {
                export const __m_pChainEntity = 0x10;
                export const m_bEnableRendering = 0x58;
                export const m_nSplitscreenFlags = 0x54;
                export const m_bInterpolationReadyToDraw = 0xA8;
                export const m_bIsRenderingWithViewModels = 0x50;
            }
            export namespace CRetakeGameRules {
                export const m_iBombSite = 0x144;
                export const m_nMatchSeed = 0x138;
                export const m_hBombPlanter = 0x148;
                export const m_bBlockersPresent = 0x13C;
                export const m_bRoundInProgress = 0x13D;
                export const m_iFirstSecondHalfRound = 0x140;
            }
            export namespace CRuleBrushEntity {

            }
            export namespace CRulePointEntity {
                export const m_Score = 0x858;
            }
            export namespace CScriptComponent {
                export const m_scriptClassName = 0x30;
            }
            export namespace CSimpleStopwatch {

            }
            export namespace CSingleplayRules {
                export const m_bSinglePlayerGameEnding = 0xD0;
            }
            export namespace CSkyCameraVolume {
                export const m_hTarget = 0x4D8;
                export const m_vBoxMaxs = 0x4CC;
                export const m_vBoxMins = 0x4C0;
                export const m_nPriority = 0x4DC;
                export const m_bIsEnabled = 0x4E0;
                export const m_vBlurOrigin = 0x4E4;
                export const m_iszTargetName = 0x4F8;
                export const m_bStartDisabled = 0x4F2;
                export const m_bSkyboxBlurEffect = 0x4E1;
                export const m_bSkyboxReceivesWorldCsm = 0x4F0;
                export const m_bWorldReceivesSkyboxCsm = 0x4F1;
            }
            export namespace CSkyboxReference {
                export const m_hSkyCamera = 0x4AC;
                export const m_worldGroupId = 0x4A8;
            }
            export namespace CTriggerBuoyancy {
                export const m_BuoyancyHelper = 0x9C8;
                export const m_flFluidDensity = 0xAE0;
            }
            export namespace CTriggerCallback {

            }
            export namespace CTriggerMultiple {
                export const m_OnTrigger = 0x9C8;
            }
            export namespace CTriggerTeleport {
                export const m_iLandmark = 0x9C8;
                export const m_bMirrorPlayer = 0x9D1;
                export const m_bUseLandmarkAngles = 0x9D0;
                export const m_bCheckDestIfClearForPlayer = 0x9D2;
            }
            export namespace CWeaponFiveSeven {

            }
            export namespace FilterDamageType {
                export const m_iDamageType = 0x4E0;
            }
            export namespace ResponseFollowup {
                export const followup_delay = 0x10;
                export const followup_target = 0x14;
                export const followup_concept = 0x0;
                export const followup_contexts = 0x8;
            }
            export namespace WaterWheelDrag_t {
                export const m_flWheelDrag = 0x4;
                export const m_flFractionOfWheelSubmerged = 0x0;
            }
            export namespace ragdollelement_t {
                export const m_nHeight = 0x28;
                export const m_flRadius = 0x24;
                export const parentIndex = 0x20;
                export const originParentSpace = 0x0;
            }
            export namespace CAttributeManager {
                export const m_hOuter = 0x24;
                export const m_Providers = 0x8;
                export const m_ProviderType = 0x2C;
                export const m_CachedResults = 0x30;
                export const m_bPreventLoopback = 0x28;
                export const m_iReapplyProvisionParity = 0x20;
            }
            export namespace CBasePlayerWeapon {
                export const m_iClip1 = 0xEC0;
                export const m_iClip2 = 0xEC4;
                export const m_OnPlayerUse = 0xED0;
                export const m_pReserveAmmo = 0xEC8;
                export const m_nNextPrimaryAttackTick = 0xEB0;
                export const m_nNextSecondaryAttackTick = 0xEB8;
                export const m_flNextPrimaryAttackTickRatio = 0xEB4;
                export const m_flNextSecondaryAttackTickRatio = 0xEBC;
            }
            export namespace CCSGameRulesProxy {
                export const m_pGameRules = 0x4A8;
            }
            export namespace CCSPlayerPawnBase {
                export const m_iNumSpawns = 0xDF4;
                export const m_bRespawning = 0xDF0;
                export const m_iPlayerState = 0xD40;
                export const m_pPingServices = 0xD30;
                export const m_blindStartTime = 0xD3C;
                export const m_blindUntilTime = 0xD38;
                export const m_flFlashDuration = 0xE04;
                export const m_flFlashMaxAlpha = 0xE08;
                export const m_bHasMovedSinceSpawn = 0xDF1;
                export const m_hOriginalController = 0xE14;
                export const m_fNextRadarUpdateTime = 0xE00;
                export const m_iProgressBarDuration = 0xE10;
                export const m_flProgressBarStartTime = 0xE0C;
                export const m_CTouchExpansionComponent = 0xCE0;
                export const m_flIdleTimeSinceLastAction = 0xDFC;
            }
            export namespace CCSPlayerResource {
                export const m_bHostageAlive = 0x4A8;
                export const m_hostageRescueX = 0x508;
                export const m_hostageRescueY = 0x518;
                export const m_hostageRescueZ = 0x528;
                export const m_bombsiteCenterA = 0x4F0;
                export const m_bombsiteCenterB = 0x4FC;
                export const m_iHostageEntityIDs = 0x4C0;
                export const m_foundGoalPositions = 0x539;
                export const m_bEndMatchNextMapAllVoted = 0x538;
                export const m_isHostageFollowingSomeone = 0x4B4;
            }
            export namespace CChoreoInfoTarget {

            }
            export namespace CCommentarySystem {
                export const m_vecNodes = 0x48;
                export const m_bCheatState = 0x1C;
                export const m_hCurrentNode = 0x38;
                export const m_iTeleportStage = 0x18;
                export const m_ModifiedConvars = 0x20;
                export const m_flNextTeleportTime = 0x14;
                export const m_hLastCommentaryNode = 0x40;
                export const m_hActiveCommentaryNode = 0x3C;
                export const m_bIsFirstSpawnGroupToLoad = 0x1D;
                export const m_bCommentaryEnabledMidGame = 0x12;
            }
            export namespace CConstraintAnchor {
                export const m_massScale = 0xA40;
            }
            export namespace CDestructiblePart {
                export const m_DebugName = 0x0;
                export const m_nHitGroup = 0x8;
                export const m_DamageLevels = 0x38;
                export const m_sBodyGroupName = 0x30;
                export const m_bOnlyDestroyWhenGibbing = 0x28;
                export const m_bDisableHitGroupWhenDestroyed = 0xC;
                export const m_nOtherHitgroupsToDestroyWhenFullyDestructed = 0x10;
            }
            export namespace CEnvEntityIgniter {
                export const m_flLifetime = 0x4A8;
            }
            export namespace CFireCrackerBlast {

            }
            export namespace CFuncShatterglass {
                export const m_bBroken = 0x8E6;
                export const m_OnBroken = 0x958;
                export const m_PanelSize = 0x8C8;
                export const m_bBreakSilent = 0x8E4;
                export const m_bStartBroken = 0x8E9;
                export const m_flInitAtTime = 0x8D8;
                export const m_iSurfaceType = 0x970;
                export const m_bGlassInFrame = 0x8E8;
                export const m_bBreakShardless = 0x8E5;
                export const m_bGlassNavIgnore = 0x8E7;
                export const m_flGlassThickness = 0x8DC;
                export const m_flLastCleanupTime = 0x8D4;
                export const m_matPanelTransform = 0x850;
                export const m_iInitialDamageType = 0x8EA;
                export const m_hMaterialDamageBase = 0x978;
                export const m_vExtraDamagePositions = 0x928;
                export const m_vInitialPanelVertices = 0x940;
                export const m_vecShatterGlassShards = 0x8B0;
                export const m_flSpawnInvulnerability = 0x8E0;
                export const m_matPanelTransformWsTemp = 0x880;
                export const m_vInitialDamagePositions = 0x910;
                export const m_flLastShatterSoundEmitTime = 0x8D0;
                export const m_szDamagePositioningEntityName01 = 0x8F0;
                export const m_szDamagePositioningEntityName02 = 0x8F8;
                export const m_szDamagePositioningEntityName03 = 0x900;
                export const m_szDamagePositioningEntityName04 = 0x908;
            }
            export namespace CFuncVPhysicsClip {
                export const m_bDisabled = 0x850;
            }
            export namespace CHintMessageQueue {
                export const m_messages = 0x8;
                export const m_tmMessageEnd = 0x0;
                export const m_pPlayerController = 0x20;
            }
            export namespace CInfoChoreoAnchor {
                export const m_vecTargetWarps = 0x4C0;
                export const m_vecTargetEntries = 0x4A8;
            }
            export namespace CLightOrthoEntity {

            }
            export namespace CLogicAchievement {
                export const m_OnFired = 0x4B8;
                export const m_bDisabled = 0x4A8;
                export const m_iszAchievementEventID = 0x4B0;
            }
            export namespace CModelPointEntity {

            }
            export namespace CNmSnapWeaponTask {

            }
            export namespace CPathParticleRope {
                export const m_flSlack = 0x4DC;
                export const m_flRadius = 0x4E0;
                export const m_ColorTint = 0x4E4;
                export const m_bStartActive = 0x4B0;
                export const m_iEffectIndex = 0x4F0;
                export const m_nEffectState = 0x4E8;
                export const m_iszEffectName = 0x4B8;
                export const m_PathNodes_Name = 0x4C0;
                export const m_PathNodes_Color = 0x540;
                export const m_flParticleSpacing = 0x4D8;
                export const m_PathNodes_Position = 0x4F8;
                export const m_PathNodes_TangentIn = 0x510;
                export const m_flMaxSimulationTime = 0x4B4;
                export const m_PathNodes_PinEnabled = 0x558;
                export const m_PathNodes_TangentOut = 0x528;
                export const m_PathNodes_RadiusScale = 0x570;
            }
            export namespace CPlayerSprayDecal {
                export const m_nEntity = 0x894;
                export const m_nHitbox = 0x898;
                export const m_nPlayer = 0x890;
                export const m_nTintID = 0x8A0;
                export const m_vecLeft = 0x878;
                export const m_nVersion = 0x8A4;
                export const m_rtGcTime = 0x85C;
                export const m_vecStart = 0x86C;
                export const m_nUniqueID = 0x850;
                export const m_unTraceID = 0x858;
                export const m_vecEndPos = 0x860;
                export const m_vecNormal = 0x884;
                export const m_ubSignature = 0x8A5;
                export const m_unAccountID = 0x854;
                export const m_flCreationTime = 0x89C;
            }
            export namespace CPlayerVisibility {
                export const m_bIsEnabled = 0x4B9;
                export const m_flFadeTime = 0x4B4;
                export const m_bStartDisabled = 0x4B8;
                export const m_flVisibilityStrength = 0x4A8;
                export const m_flFogDistanceMultiplier = 0x4AC;
                export const m_flFogMaxDensityMultiplier = 0x4B0;
            }
            export namespace CPointAngleSensor {
                export const m_bFired = 0x4CC;
                export const m_TargetDir = 0x500;
                export const m_bDisabled = 0x4A8;
                export const m_flDuration = 0x4C0;
                export const m_nLookAtName = 0x4B0;
                export const m_flFacingTime = 0x4C8;
                export const m_hLookAtEntity = 0x4BC;
                export const m_hTargetEntity = 0x4B8;
                export const m_OnFacingLookat = 0x4D0;
                export const m_flDotTolerance = 0x4C4;
                export const m_FacingPercentage = 0x528;
                export const m_OnNotFacingLookat = 0x4E8;
            }
            export namespace CPropDoorRotating {
                export const m_angGoal = 0xEE4;
                export const m_vecAxis = 0xE90;
                export const m_flDistance = 0xE9C;
                export const m_flAjarAngle = 0xEB0;
                export const m_eOpenDirection = 0xEA4;
                export const m_eSpawnPosition = 0xEA0;
                export const m_hEntityBlocker = 0xF24;
                export const m_vecBackBoundsMax = 0xF14;
                export const m_vecBackBoundsMin = 0xF08;
                export const m_angRotationClosed = 0xEC0;
                export const m_angRotationOpenBack = 0xED8;
                export const m_vecForwardBoundsMax = 0xEFC;
                export const m_vecForwardBoundsMin = 0xEF0;
                export const m_eCurrentOpenDirection = 0xEA8;
                export const m_angRotationOpenForward = 0xECC;
                export const m_eDefaultCheckDirection = 0xEAC;
                export const m_angRotationAjarDeprecated = 0xEB4;
                export const m_bAjarDoorShouldntAlwaysOpen = 0xF20;
            }
            export namespace CRelativeLocation {
                export const m_Type = 0x18;
                export const m_hEntity = 0x34;
                export const m_vWorldSpacePos = 0x28;
                export const m_vRelativeOffset = 0x1C;
            }
            export namespace CSPerRoundStats_t {
                export const m_iKills = 0x30;
                export const m_iDamage = 0x3C;
                export const m_iDeaths = 0x34;
                export const m_iAssists = 0x38;
                export const m_iLiveTime = 0x4C;
                export const m_iObjective = 0x54;
                export const m_iCashEarned = 0x58;
                export const m_iKillReward = 0x48;
                export const m_iMoneySaved = 0x44;
                export const m_iHeadShotKills = 0x50;
                export const m_iUtilityDamage = 0x5C;
                export const m_iEnemiesFlashed = 0x60;
                export const m_iEquipmentValue = 0x40;
            }
            export namespace CSceneListManager {
                export const m_hScenes = 0x540;
                export const m_iszScenes = 0x4C0;
                export const m_hListManagers = 0x4A8;
            }
            export namespace CScriptNavBlocker {
                export const m_vExtent = 0x868;
            }
            export namespace CScriptedSequence {
                export const m_iszPlay = 0x4B8;
                export const m_nMoveTo = 0x4E8;
                export const m_flRadius = 0x514;
                export const m_flRepeat = 0x518;
                export const m_iszEntry = 0x4A8;
                export const m_bThinking = 0x554;
                export const m_flAngRate = 0x524;
                export const m_hNextCine = 0x550;
                export const m_iszEntity = 0x4D8;
                export const m_startTime = 0x534;
                export const m_hTargetEnt = 0x54C;
                export const m_iszPreIdle = 0x4B0;
                export const m_savedFlags = 0x540;
                export const m_bForceSynch = 0x55D;
                export const m_bSkipFadeIn = 0x6E8;
                export const m_flMoveSpeed = 0x528;
                export const m_iszPostIdle = 0x4C0;
                export const m_nMoveToGait = 0x4EC;
                export const m_iszSyncGroup = 0x4E0;
                export const m_OnEndSequence = 0x598;
                export const m_OnScriptEvent = 0x5F8;
                export const m_bHighPriority = 0x503;
                export const m_bIgnoreLookAt = 0x50A;
                export const m_bIsRepeatable = 0x4FD;
                export const m_bStartOnSpawn = 0x4FF;
                export const m_hForcedTarget = 0x558;
                export const m_iszNextScript = 0x4D0;
                export const m_saved_effects = 0x53C;
                export const m_bIgnoreGravity = 0x50B;
                export const m_bInterruptable = 0x548;
                export const m_matOtherToMain = 0x6C0;
                export const m_OnBeginSequence = 0x568;
                export const m_bIgnoreRotation = 0x510;
                export const m_bIsPlayingEntry = 0x4F9;
                export const m_bSynchPostIdles = 0x509;
                export const m_onDeathBehavior = 0x560;
                export const m_sequenceStarted = 0x549;
                export const m_ConflictResponse = 0x564;
                export const m_OnCancelSequence = 0x5C8;
                export const m_bContinueOnDeath = 0x505;
                export const m_bDontRotateOther = 0x4FC;
                export const m_bIsPlayingAction = 0x4FA;
                export const m_flMoveInterpTime = 0x520;
                export const m_bDontAddModifiers = 0x50E;
                export const m_bIsPlayingPreIdle = 0x4F8;
                export const m_bDontTeleportAtEnd = 0x502;
                export const m_bIsPlayingPostIdle = 0x4FB;
                export const m_bShouldLeaveCorpse = 0x4FE;
                export const m_nForcedCrouchState = 0x4F4;
                export const m_OnActionStartOrLoop = 0x580;
                export const m_bDisallowInterrupts = 0x500;
                export const m_bLoopActionSequence = 0x507;
                export const m_nHeldWeaponBehavior = 0x4F0;
                export const m_savedCollisionGroup = 0x544;
                export const m_bCanOverrideNPCState = 0x501;
                export const m_bHideDebugComplaints = 0x504;
                export const m_bInitiatedSelfDelete = 0x555;
                export const m_bLoopPreIdleSequence = 0x506;
                export const m_flPlayAnimFadeInTime = 0x51C;
                export const m_iPlayerDeathBehavior = 0x6E4;
                export const m_OnPostIdleEndSequence = 0x5B0;
                export const m_bDisableNPCCollisions = 0x50C;
                export const m_bLoopPostIdleSequence = 0x508;
                export const m_bWaitForBeginSequence = 0x538;
                export const m_OnCancelFailedSequence = 0x5E0;
                export const m_hInteractionMainEntity = 0x6E0;
                export const m_iszModifierToAddOnPlay = 0x4C8;
                export const m_nNotReadySequenceCount = 0x530;
                export const m_bEnsureOnNavmeshOnFinish = 0x55F;
                export const m_bKeepAnimgraphLockedPost = 0x50D;
                export const m_bDisableAimingWhileMoving = 0x50F;
                export const m_bDontCancelOtherSequences = 0x55C;
                export const m_bIsTeleportingDueToMoveTo = 0x556;
                export const m_bPreventUpdateYawOnFinish = 0x55E;
                export const m_bPositionRelativeToOtherEntity = 0x54A;
                export const m_bAllowCustomInterruptConditions = 0x557;
                export const m_bWaitUntilMoveCompletesToStartAnimation = 0x52C;
            }
            export namespace CServerOnlyEntity {

            }
            export namespace CSkeletonInstance {
                export const m_modelState = 0x120;
                export const m_nHitboxSet = 0x3BC;
                export const m_materialGroup = 0x3B8;
                export const m_bDirtyMotionType = 0x3B2;
                export const m_bUseParentRenderBounds = 0x3B0;
                export const m_bForceServerConstraintsEnabled = 0x41C;
                export const m_bDisableSolidCollisionsForHierarchy = 0x3B1;
                export const m_bIsGeneratingLatchedParentSpaceState = 0x3B3;
            }
            export namespace CSoundEventEntity {
                export const m_hSource = 0x55C;
                export const m_bStopOnNew = 0x4AA;
                export const m_bSaveRestore = 0x4AB;
                export const m_iszSoundName = 0x540;
                export const m_bStartOnSpawn = 0x4A8;
                export const m_onGUIDChanged = 0x4C8;
                export const m_bToLocalPlayer = 0x4A9;
                export const m_bSavedIsPlaying = 0x4AC;
                export const m_onSoundFinished = 0x4F8;
                export const m_iszAttachmentName = 0x4C0;
                export const m_flClientCullRadius = 0x510;
                export const m_flSavedElapsedTime = 0x4B0;
                export const m_iszSourceEntityName = 0x4B8;
                export const m_nEntityIndexSelection = 0x560;
            }
            export namespace CSplineConstraint {
                export const m_pSplineBody = 0x568;
                export const m_bEnableLimit = 0x573;
                export const m_hSplineEntity = 0x564;
                export const m_flJointFriction = 0x580;
                export const m_flTransitionTime = 0x584;
                export const m_bFireEventsOnPath = 0x574;
                export const m_flLinearFrequency = 0x578;
                export const m_vPreSolveAnchorPos = 0x598;
                export const m_StartTransitionTime = 0x5A4;
                export const m_flLinarDampingRatio = 0x57C;
                export const m_vAnchorOffsetRestore = 0x558;
                export const m_bEnableAngularConstraint = 0x572;
                export const m_bEnableLateralConstraint = 0x570;
                export const m_bEnableVerticalConstraint = 0x571;
                export const m_vTangentSpaceAnchorAtTransitionStart = 0x5A8;
            }
            export namespace CTakeDamageResult {
                export const m_nHealthLost = 0x18;
                export const m_nDamageFlags = 0x48;
                export const m_flDamageDealt = 0x20;
                export const m_nHealthBefore = 0x1C;
                export const m_bSuppressFlinch = 0x51;
                export const m_vDamagePosition = 0x28;
                export const m_pOriginatingInfo = 0x0;
                export const m_flPreModifiedDamage = 0x24;
                export const m_nTotalledHealthLost = 0x34;
                export const m_bWasDamageSuppressed = 0x50;
                export const m_flTotalledDamageDealt = 0x38;
                export const m_nOverrideFlinchHitGroup = 0x54;
                export const m_flNewDamageAccumulatorValue = 0x40;
                export const m_flTotalledPreModifiedDamage = 0x3C;
                export const m_DestructibleHitGroupRequests = 0x8;
            }
            export namespace CTankTargetChange {
                export const m_newTarget = 0x4A8;
                export const m_newTargetName = 0x4B8;
            }
            export namespace CTriggerBombReset {

            }
            export namespace CTriggerGameEvent {
                export const m_strTriggerID = 0x9D8;
                export const m_strEndTouchEventName = 0x9D0;
                export const m_strStartTouchEventName = 0x9C8;
            }
            export namespace CTriggerProximity {
                export const m_fRadius = 0x9D8;
                export const m_nTouchers = 0x9DC;
                export const m_hMeasureTarget = 0x9C8;
                export const m_iszMeasureTarget = 0x9D0;
                export const m_NearestEntityDistance = 0x9E0;
            }
            export namespace PhysBlockHeader_t {
                export const nSaved = 0x0;
                export const pWorldObject = 0x8;
            }
            export namespace ResponseContext_t {
                export const m_iszName = 0x0;
                export const m_iszValue = 0x8;
                export const m_fExpirationTime = 0x10;
            }
            export namespace SPAWNGROUP_HEADER {
                export const m_sGroupName = 0x0;
                export const m_vecWorldOffset = 0x10;
                export const m_sEntityLumpName = 0x8;
                export const m_bClientSpawnGroup = 0x40;
                export const m_bSuppressAllEntities = 0x41;
            }
            export namespace SequenceHistory_t {
                export const m_hSequence = 0x0;
                export const m_nSeqLoopMode = 0xC;
                export const m_flPlaybackRate = 0x10;
                export const m_flSeqStartTime = 0x4;
                export const m_flSeqFixedCycle = 0x8;
                export const m_flCyclesPerSecond = 0x14;
            }
            export namespace fogplayerparams_t {
                export const m_hCtrl = 0x8;
                export const m_NewColor = 0x28;
                export const m_OldColor = 0x10;
                export const m_flNewEnd = 0x30;
                export const m_flOldEnd = 0x18;
                export const m_flNewFarZ = 0x3C;
                export const m_flOldFarZ = 0x24;
                export const m_flNewStart = 0x2C;
                export const m_flOldStart = 0x14;
                export const m_flNewMaxDensity = 0x34;
                export const m_flOldMaxDensity = 0x1C;
                export const m_flTransitionTime = 0xC;
                export const m_flNewHDRColorScale = 0x38;
                export const m_flOldHDRColorScale = 0x20;
            }
            export namespace modifiedconvars_t {
                export const pszConvar = 0x0;
                export const pszOrgValue = 0x100;
                export const pszCurrentValue = 0x80;
            }
            export namespace CCSCustomHudLayout {
                export const m_strLayout = 0x4B8;
                export const m_bObservable = 0x4C0;
                export const m_vecPanelIds = 0x6C8;
                export const m_vecClassNames = 0x6E0;
                export const m_globalLayoutState = 0x530;
                export const m_vecPlayerLayoutStates = 0x4C8;
                export const m_vecDialogVariableNames = 0x6F8;
            }
            export namespace CCSMinimapBoundary {

            }
            export namespace CCSWeaponBaseVData {
                export const m_nPrice = 0x70C;
                export const m_szName = 0x720;
                export const m_flRange = 0x830;
                export const m_nDamage = 0x820;
                export const m_GearSlot = 0x700;
                export const m_flSpread = 0x750;
                export const m_nZoomFOV1 = 0x7F8;
                export const m_nZoomFOV2 = 0x7FC;
                export const m_WeaponType = 0x520;
                export const m_flMaxSpeed = 0x748;
                export const m_nKillAward = 0x710;
                export const m_bIsFullAuto = 0x72D;
                export const m_bIsRevolver = 0x71E;
                export const m_flCycleTime = 0x738;
                export const m_flZoomTime0 = 0x800;
                export const m_flZoomTime1 = 0x804;
                export const m_flZoomTime2 = 0x808;
                export const m_nNumBullets = 0x730;
                export const m_nRecoilSeed = 0x7D4;
                export const m_nSpreadSeed = 0x7D8;
                export const m_nZoomLevels = 0x7F4;
                export const m_szAnimClass = 0x868;
                export const m_vSmokeColor = 0x85C;
                export const m_bMeleeWeapon = 0x71C;
                export const m_flArmorRatio = 0x828;
                export const m_bHasBurstMode = 0x71D;
                export const m_eSilencerType = 0x728;
                export const m_flPenetration = 0x82C;
                export const m_flRecoilAngle = 0x790;
                export const m_vecMuzzlePos0 = 0x608;
                export const m_vecMuzzlePos1 = 0x614;
                export const m_WeaponCategory = 0x524;
                export const m_bShowCrosshair = 0x72C;
                export const m_flIronSightFOV = 0x814;
                export const m_szAnimSkeleton = 0x528;
                export const m_flRangeModifier = 0x834;
                export const m_flThrowVelocity = 0x858;
                export const m_nBurstShotCount = 0x7CC;
                export const m_GearSlotPosition = 0x704;
                export const m_flDeployDuration = 0x7C4;
                export const m_flInaccuracyFire = 0x780;
                export const m_flInaccuracyJump = 0x768;
                export const m_flInaccuracyLand = 0x770;
                export const m_flInaccuracyMove = 0x788;
                export const m_nTracerFrequency = 0x7B0;
                export const m_szTracerParticle = 0x620;
                export const m_bUnzoomsAfterShot = 0x7F0;
                export const m_flInaccuracyStand = 0x760;
                export const m_flRecoilMagnitude = 0x7A0;
                export const m_DefaultLoadoutSlot = 0x708;
                export const m_bAllowBurstHolster = 0x7D0;
                export const m_flInaccuracyCrouch = 0x758;
                export const m_flInaccuracyLadder = 0x778;
                export const m_flInaccuracyReload = 0x7C0;
                export const m_szUseRadioSubtitle = 0x7E8;
                export const m_flRecoveryTimeStand = 0x844;
                export const m_bReloadsSingleShells = 0x734;
                export const m_flHeadshotMultiplier = 0x824;
                export const m_flInaccuracyJumpApex = 0x7BC;
                export const m_flIronSightLooseness = 0x81C;
                export const m_flRecoveryTimeCrouch = 0x840;
                export const m_flRecoilAngleVariance = 0x798;
                export const m_bCannotShootUnderwater = 0x71F;
                export const m_flInaccuracyPitchShift = 0x7E0;
                export const m_flIronSightPullUpSpeed = 0x80C;
                export const m_nPrimaryReserveAmmoMax = 0x714;
                export const m_flAttackMovespeedFactor = 0x7DC;
                export const m_flInaccuracyJumpInitial = 0x7B8;
                export const m_flIronSightPivotForward = 0x818;
                export const m_flIronSightPutDownSpeed = 0x810;
                export const m_flTimeBetweenBurstShots = 0x744;
                export const m_bHideViewModelWhenZoomed = 0x7F1;
                export const m_flRecoveryTimeStandFinal = 0x84C;
                export const m_nSecondaryReserveAmmoMax = 0x718;
                export const m_flRecoilMagnitudeVariance = 0x7A8;
                export const m_flRecoveryTimeCrouchFinal = 0x848;
                export const m_flCycleTimeWhenInBurstMode = 0x740;
                export const m_nRecoveryTransitionEndBullet = 0x854;
                export const m_flFlinchVelocityModifierLarge = 0x838;
                export const m_flFlinchVelocityModifierSmall = 0x83C;
                export const m_flInaccuracyAltSoundThreshold = 0x7E4;
                export const m_nRecoveryTransitionStartBullet = 0x850;
                export const m_flDisallowAttackAfterReloadStartDuration = 0x7C8;
            }
            export namespace CCollisionProperty {
                export const m_vecMaxs = 0x4C;
                export const m_vecMins = 0x40;
                export const m_nSolidType = 0x5B;
                export const m_triggerBloat = 0x5C;
                export const m_usSolidFlags = 0x5A;
                export const m_nSurroundType = 0x5D;
                export const m_CollisionGroup = 0x5E;
                export const m_nEnablePhysics = 0x5F;
                export const m_flCapsuleRadius = 0xAC;
                export const m_vCapsuleCenter1 = 0x94;
                export const m_vCapsuleCenter2 = 0xA0;
                export const m_flBoundingRadius = 0x60;
                export const m_collisionAttribute = 0x10;
                export const m_vecSurroundingMaxs = 0x7C;
                export const m_vecSurroundingMins = 0x88;
                export const m_vecSpecifiedSurroundingMaxs = 0x70;
                export const m_vecSpecifiedSurroundingMins = 0x64;
            }
            export namespace CEconItemAttribute {
                export const m_flValue = 0x34;
                export const m_bSetBonus = 0x40;
                export const m_flInitialValue = 0x38;
                export const m_nRefundableCurrency = 0x3C;
                export const m_iAttributeDefinitionIndex = 0x30;
            }
            export namespace CEnableMotionFixup {

            }
            export namespace CEnvInstructorHint {
                export const m_Color = 0x4E8;
                export const m_fRange = 0x4F0;
                export const m_bStatic = 0x4F7;
                export const m_iszName = 0x4A8;
                export const m_iTimeout = 0x4C0;
                export const m_bAutoStart = 0x511;
                export const m_iszBinding = 0x508;
                export const m_iszCaption = 0x4D8;
                export const m_fIconOffset = 0x4EC;
                export const m_bNoOffscreen = 0x4F8;
                export const m_iAlphaOption = 0x4F5;
                export const m_iPulseOption = 0x4F4;
                export const m_iShakeOption = 0x4F6;
                export const m_bForceCaption = 0x4F9;
                export const m_bSuppressRest = 0x500;
                export const m_iDisplayLimit = 0x4C4;
                export const m_iInstanceType = 0x4FC;
                export const m_iszReplace_Key = 0x4B0;
                export const m_bLocalPlayerOnly = 0x512;
                export const m_iszIcon_Onscreen = 0x4C8;
                export const m_iszIcon_Offscreen = 0x4D0;
                export const m_bAllowNoDrawTarget = 0x510;
                export const m_iszActivatorCaption = 0x4E0;
                export const m_iszHintTargetEntity = 0x4B8;
            }
            export namespace CExplosionTypeData {
                export const m_DecalType = 0xF8;
                export const m_SoundName = 0x0;
                export const m_bHasForces = 0xF1;
                export const m_bIsIncindiary = 0xF0;
                export const m_ParticleEffect = 0x10;
            }
            export namespace CFilterMassGreater {
                export const m_fFilterMass = 0x4E0;
            }
            export namespace CFuncRetakeBarrier {

            }
            export namespace CFuncTrainControls {

            }
            export namespace CGenericConstraint {
                export const m_bAxisNotifiedX = 0x58C;
                export const m_bAxisNotifiedY = 0x58D;
                export const m_bAxisNotifiedZ = 0x58E;
                export const m_flNotifyForceX = 0x568;
                export const m_flNotifyForceY = 0x56C;
                export const m_flNotifyForceZ = 0x570;
                export const m_nLinearMotionX = 0x514;
                export const m_nLinearMotionY = 0x518;
                export const m_nLinearMotionZ = 0x51C;
                export const m_nAngularMotionX = 0x590;
                export const m_nAngularMotionY = 0x594;
                export const m_nAngularMotionZ = 0x598;
                export const m_flBreakAfterTimeX = 0x544;
                export const m_flBreakAfterTimeY = 0x548;
                export const m_flBreakAfterTimeZ = 0x54C;
                export const m_flLinearFrequencyX = 0x520;
                export const m_flLinearFrequencyY = 0x524;
                export const m_flLinearFrequencyZ = 0x528;
                export const m_NotifyForceReachedX = 0x5C0;
                export const m_NotifyForceReachedY = 0x5D8;
                export const m_NotifyForceReachedZ = 0x5F0;
                export const m_flAngularFrequencyX = 0x59C;
                export const m_flAngularFrequencyY = 0x5A0;
                export const m_flAngularFrequencyZ = 0x5A4;
                export const m_flMaxLinearImpulseX = 0x538;
                export const m_flMaxLinearImpulseY = 0x53C;
                export const m_flMaxLinearImpulseZ = 0x540;
                export const m_flMaxAngularImpulseX = 0x5B4;
                export const m_flMaxAngularImpulseY = 0x5B8;
                export const m_flMaxAngularImpulseZ = 0x5BC;
                export const m_flLinearDampingRatioX = 0x52C;
                export const m_flLinearDampingRatioY = 0x530;
                export const m_flLinearDampingRatioZ = 0x534;
                export const m_flNotifyForceMinTimeX = 0x574;
                export const m_flNotifyForceMinTimeY = 0x578;
                export const m_flNotifyForceMinTimeZ = 0x57C;
                export const m_flAngularDampingRatioX = 0x5A8;
                export const m_flAngularDampingRatioY = 0x5AC;
                export const m_flAngularDampingRatioZ = 0x5B0;
                export const m_flNotifyForceLastTimeX = 0x580;
                export const m_flNotifyForceLastTimeY = 0x584;
                export const m_flNotifyForceLastTimeZ = 0x588;
                export const m_flBreakAfterTimeStartTimeX = 0x550;
                export const m_flBreakAfterTimeStartTimeY = 0x554;
                export const m_flBreakAfterTimeStartTimeZ = 0x558;
                export const m_flBreakAfterTimeThresholdX = 0x55C;
                export const m_flBreakAfterTimeThresholdY = 0x560;
                export const m_flBreakAfterTimeThresholdZ = 0x564;
                export const m_bPlaceAnchorsAtConstraintTransform = 0x510;
            }
            export namespace CHostageRescueZone {

            }
            export namespace CIncendiaryGrenade {

            }
            export namespace CInfoVisibilityBox {
                export const m_nMode = 0x4AC;
                export const m_bEnabled = 0x4BC;
                export const m_vBoxSize = 0x4B0;
            }
            export namespace CLogicLineToEntity {
                export const m_Line = 0x4A8;
                export const m_EndEntity = 0x4DC;
                export const m_SourceName = 0x4D0;
                export const m_StartEntity = 0x4D8;
            }
            export namespace CMolotovProjectile {
                export const m_bDetonated = 0xB58;
                export const m_stillTimer = 0xB60;
                export const m_bIsIncGrenade = 0xB40;
            }
            export namespace CPointEntityFinder {
                export const m_hEntity = 0x4A8;
                export const m_hFilter = 0x4B8;
                export const m_iRefName = 0x4C0;
                export const m_FindMethod = 0x4CC;
                export const m_hReference = 0x4C8;
                export const m_iFilterName = 0x4B0;
                export const m_OnFoundEntity = 0x4D0;
            }
            export namespace CPropDataComponent {
                export const m_flDmgModClub = 0x14;
                export const m_flDmgModFire = 0x1C;
                export const m_nInteractions = 0x30;
                export const m_flDmgModBullet = 0x10;
                export const m_iszBasePropData = 0x28;
                export const m_flDmgModExplosive = 0x18;
                export const m_bSpawnMotionDisabled = 0x34;
                export const m_nMotionDisabledSpawnFlag = 0x3C;
                export const m_iszPhysicsDamageTableName = 0x20;
                export const m_nDisableTakePhysicsDamageSpawnFlag = 0x38;
            }
            export namespace CPulseCell_Unknown {
                export const m_UnknownKeys = 0x48;
            }
            export namespace CPulseServerCursor {
                export const m_hCaller = 0xEC;
                export const m_hActivator = 0xE8;
            }
            export namespace CPulse_ResumePoint {

            }
            export namespace CRagdollConstraint {
                export const m_xmax = 0x50C;
                export const m_xmin = 0x508;
                export const m_ymax = 0x514;
                export const m_ymin = 0x510;
                export const m_zmax = 0x51C;
                export const m_zmin = 0x518;
                export const m_xfriction = 0x520;
                export const m_yfriction = 0x524;
                export const m_zfriction = 0x528;
            }
            export namespace CRelativeTransform {
                export const m_hEntity = 0x50;
                export const m_transform = 0x10;
                export const m_transformWS = 0x30;
                export const m_bTransformIsWorldSpace = 0x0;
            }
            export namespace CScriptTriggerHurt {
                export const m_vExtent = 0xA50;
            }
            export namespace CScriptTriggerOnce {
                export const m_vExtent = 0x9E0;
            }
            export namespace CScriptTriggerPush {
                export const m_vExtent = 0xA00;
            }
            export namespace CShatterGlassShard {
                export const m_flArea = 0x6C;
                export const m_hModel = 0x30;
                export const m_hParentPanel = 0x3C;
                export const m_hParentShard = 0x40;
                export const m_hShardHandle = 0x8;
                export const m_nOnFrameEdge = 0x70;
                export const m_vecNeighbors = 0xA0;
                export const m_bCreatedModel = 0x54;
                export const m_flLongestEdge = 0x58;
                export const m_flShortestEdge = 0x5C;
                export const m_hPhysicsEntity = 0x38;
                export const m_flLongestAcross = 0x60;
                export const m_flSumOfAllEdges = 0x68;
                export const m_flShortestAcross = 0x64;
                export const m_hEntityHittingMe = 0x9C;
                export const m_vecPanelVertices = 0x10;
                export const m_ShatterStressType = 0x44;
                export const m_vecStressVelocity = 0x48;
                export const m_bFlaggedForRemoval = 0x96;
                export const m_nSubShardGeneration = 0x74;
                export const m_vLocalPanelSpaceOrigin = 0x28;
                export const m_vecAverageVertPosition = 0x78;
                export const m_bStressPositionAIsValid = 0x94;
                export const m_bStressPositionBIsValid = 0x95;
                export const m_bAverageVertPositionIsValid = 0x80;
                export const m_flPhysicsEntitySpawnedAtTime = 0x98;
                export const m_vecPanelSpaceStressPositionA = 0x84;
                export const m_vecPanelSpaceStressPositionB = 0x8C;
            }
            export namespace CTriggerLerpObject {
                export const m_OnDetached = 0xA50;
                export const m_hLerpTarget = 0x9D0;
                export const m_iszLerpSound = 0xA10;
                export const m_OnLerpStarted = 0xA20;
                export const m_iszLerpEffect = 0xA08;
                export const m_iszLerpTarget = 0x9C8;
                export const m_OnLerpFinished = 0xA38;
                export const m_flLerpDuration = 0x9E4;
                export const m_bSingleLerpObject = 0x9EA;
                export const m_vecLerpingObjects = 0x9F0;
                export const m_bLerpRestoreMoveType = 0x9E9;
                export const m_bAttachTouchingObject = 0xA18;
                export const m_hLerpTargetAttachment = 0x9E0;
                export const m_iszLerpTargetAttachment = 0x9D8;
                export const m_bAttachedEntityWasParented = 0x9E8;
                export const m_hEntityToWaitForDisconnect = 0xA1C;
            }
            export namespace CTriggerSoundscape {
                export const m_spectators = 0x9D8;
                export const m_hSoundscape = 0x9C8;
                export const m_SoundscapeName = 0x9D0;
            }
            export namespace CWeaponUSPSilencer {

            }
            export namespace DecalGroupOption_t {
                export const m_hMaterial = 0x0;
                export const m_flProbability = 0x10;
                export const m_sSequenceName = 0x8;
                export const m_flMaxAngleBetweenNormalAndGravity = 0x1C;
                export const m_flMinAngleBetweenNormalAndGravity = 0x18;
                export const m_bEnableAngleBetweenNormalAndGravityRange = 0x14;
            }
            export namespace DynamicVolumeDef_t {
                export const m_source = 0x0;
                export const m_target = 0x4;
                export const m_nAreaDst = 0x28;
                export const m_nAreaSrc = 0x24;
                export const m_nHullIdx = 0x8;
                export const m_bAttached = 0x2C;
                export const m_vSourceAnchorPos = 0xC;
                export const m_vTargetAnchorPos = 0x18;
            }
            export namespace GameAmmoTypeInfo_t {
                export const m_nCost = 0x3C;
                export const m_nBuySize = 0x38;
            }
            export namespace HUDPanelHasClass_t {
                export const m_eClassStatus = 0x4;
                export const m_nPanelIdIndex = 0x0;
                export const m_nClassNameIndex = 0x2;
            }
            export namespace IEconItemInterface {

            }
            export namespace PhysObjectHeader_t {
                export const bbox = 0x20;
                export const _type = 0x0;
                export const sphere = 0x38;
                export const hEntity = 0x4;
                export const iCollide = 0x3C;
                export const fieldName = 0x8;
                export const modelName = 0x18;
                export const bSaveObject = 0x10;
            }
            export namespace QueuedAISearchId_t {
                export const m_Value = 0x0;
            }
            export namespace dynpitchvol_base_t {
                export const vol = 0x4C;
                export const pitch = 0x3C;
                export const fadein = 0x1C;
                export const preset = 0x0;
                export const spinup = 0xC;
                export const volrun = 0x14;
                export const cspinup = 0x34;
                export const fadeout = 0x20;
                export const lfofrac = 0x5C;
                export const lfomult = 0x60;
                export const lforate = 0x28;
                export const lfotype = 0x24;
                export const volfrac = 0x58;
                export const pitchrun = 0x4;
                export const spindown = 0x10;
                export const volstart = 0x18;
                export const fadeinsav = 0x50;
                export const lfomodvol = 0x30;
                export const pitchfrac = 0x48;
                export const spinupsav = 0x40;
                export const cspincount = 0x38;
                export const fadeoutsav = 0x54;
                export const pitchstart = 0x8;
                export const lfomodpitch = 0x2C;
                export const spindownsav = 0x44;
            }
            export namespace shard_model_desc_t {
                export const m_solid = 0x20;
                export const m_nModelID = 0x8;
                export const m_bHasParent = 0x74;
                export const m_vecPanelSize = 0x24;
                export const m_bParentFrozen = 0x75;
                export const m_hMaterialBase = 0x10;
                export const m_vecPanelVertices = 0x40;
                export const m_vecStressPositionA = 0x2C;
                export const m_vecStressPositionB = 0x34;
                export const m_flGlassHalfThickness = 0x70;
                export const m_vInitialPanelVertices = 0x58;
                export const m_SurfacePropStringToken = 0x78;
                export const m_hMaterialDamageOverlay = 0x18;
            }
            export namespace ActiveModelConfig_t {
                export const m_Name = 0x38;
                export const m_Handle = 0x30;
                export const m_AssociatedEntities = 0x40;
                export const m_AssociatedEntityNames = 0x58;
                export const m_vecAssociatedEntityCollidesWithHierarchy = 0x70;
                export const m_vecAssociatedEntityCollidesOutsideHierarchy = 0x80;
            }
            export namespace CAI_ChangeHintGroup {
                export const m_flRadius = 0x4C0;
                export const m_iSearchType = 0x4A8;
                export const m_strSearchName = 0x4B0;
                export const m_strNewHintGroup = 0x4B8;
            }
            export namespace CAttributeContainer {
                export const m_Item = 0x50;
            }
            export namespace CBaseClientUIEntity {
                export const m_PanelID = 0x868;
                export const m_bEnabled = 0x850;
                export const m_CustomOutput0 = 0x870;
                export const m_CustomOutput1 = 0x890;
                export const m_CustomOutput2 = 0x8B0;
                export const m_CustomOutput3 = 0x8D0;
                export const m_CustomOutput4 = 0x8F0;
                export const m_CustomOutput5 = 0x910;
                export const m_CustomOutput6 = 0x930;
                export const m_CustomOutput7 = 0x950;
                export const m_CustomOutput8 = 0x970;
                export const m_CustomOutput9 = 0x990;
                export const m_DialogXMLName = 0x858;
                export const m_PanelClassName = 0x860;
            }
            export namespace CBodyComponentPoint {
                export const m_sceneNode = 0x80;
            }
            export namespace CCSPlayerController {
                export const m_iMVPs = 0x940;
                export const m_iPing = 0x808;
                export const m_iScore = 0x91C;
                export const m_szClan = 0x840;
                export const m_bShowHints = 0x968;
                export const m_eMvpReason = 0x934;
                export const m_iPawnArmor = 0x904;
                export const m_iRoundsWon = 0x924;
                export const m_nFirstKill = 0x930;
                export const m_nKillCount = 0x931;
                export const m_bMvpNoMusic = 0x932;
                export const m_hPlayerPawn = 0x8EC;
                export const m_iDraftIndex = 0x8B8;
                export const m_iMusicKitID = 0x938;
                export const m_iPawnHealth = 0x900;
                export const m_iRoundScore = 0x920;
                export const m_bPawnIsAlive = 0x8FC;
                export const m_bTeamChanged = 0x834;
                export const m_bInSwitchTeam = 0x835;
                export const m_hObserverPawn = 0x8F0;
                export const m_iCoachingTeam = 0x84C;
                export const m_iMusicKitMVPs = 0x93C;
                export const m_unClanId32bit = 0x848;
                export const m_bPawnHasHelmet = 0x909;
                export const m_bScoreReported = 0x8CD;
                export const m_flSmoothedPing = 0x948;
                export const m_iNextTimeCheck = 0x96C;
                export const m_nUpdateCounter = 0x944;
                export const m_bCannotBeKicked = 0x8C8;
                export const m_bControllingBot = 0x8E0;
                export const m_bPawnHasDefuser = 0x908;
                export const m_flForceTeamTime = 0x824;
                export const m_iPendingTeamNum = 0x820;
                export const m_pDamageServices = 0x800;
                export const m_recentKillQueue = 0x928;
                export const m_unActiveQuestId = 0x87C;
                export const m_bHasSeenJoinGame = 0x836;
                export const m_bJustDidTeamKill = 0x970;
                export const m_iCompetitiveWins = 0x864;
                export const m_iPawnLifetimeEnd = 0x910;
                export const m_nPlayerDominated = 0x850;
                export const m_szCrosshairCodes = 0x818;
                export const m_bEverPlayedOnTeam = 0x82C;
                export const m_lastHeldVoteTimer = 0x950;
                export const m_bPunishForTeamKill = 0x971;
                export const m_flLastJoinTeamTime = 0x83C;
                export const m_iCompTeammateColor = 0x828;
                export const m_iPawnBotDifficulty = 0x914;
                export const m_iPawnLifetimeStart = 0x90C;
                export const m_nDisconnectionTick = 0x8D0;
                export const m_pInventoryServices = 0x7F0;
                export const m_DesiredObserverMode = 0x8F4;
                export const m_bEverFullyConnected = 0x8C9;
                export const m_iCompetitiveRanking = 0x860;
                export const m_nPlayerDominatingMe = 0x858;
                export const m_nSuspiciousHitCount = 0x988;
                export const m_bAttemptedToGetColor = 0x82D;
                export const m_bJustBecameSpectator = 0x837;
                export const m_iCompetitiveRankType = 0x868;
                export const m_nEndMatchNextMapVote = 0x878;
                export const m_nQuestProgressReason = 0x884;
                export const m_pInGameMoneyServices = 0x7E8;
                export const m_rtActiveMissionPeriod = 0x880;
                export const m_bCanControlObservedBot = 0x8E8;
                export const m_bGaveTeamDamageWarning = 0x972;
                export const m_hDesiredObserverTarget = 0x8F8;
                export const m_nPawnCharacterDefIndex = 0x90A;
                export const m_unPlayerTvControlFlags = 0x888;
                export const m_bAbandonAllowsSurrender = 0x8CA;
                export const m_iTeammatePreferredColor = 0x830;
                export const m_nNonSuspiciousHitStreak = 0x98C;
                export const m_pActionTrackingServices = 0x7F8;
                export const m_uiAbandonRecordedReason = 0x8C0;
                export const m_nBotsControlledThisRound = 0x8E4;
                export const m_uiCommunicationMuteFlags = 0x810;
                export const m_LastTeamDamageWarningTime = 0x980;
                export const m_bHasCommunicationAbuseMute = 0x80C;
                export const m_bHasControlledBotThisRound = 0x8E1;
                export const m_eNetworkDisconnectionReason = 0x8C4;
                export const m_bFireBulletsSeedSynchronized = 0xA39;
                export const m_bSwitchTeamsOnNextRoundReset = 0x838;
                export const m_bAbandonOffersInstantSurrender = 0x8CB;
                export const m_bGaveTeamDamageWarningThisRound = 0x973;
                export const m_bRemoveAllItemsOnNextRoundReset = 0x839;
                export const m_bDisconnection1MinWarningPrinted = 0x8CC;
                export const m_hOriginalControllerOfCurrentPawn = 0x918;
                export const m_iCompetitiveRankingPredicted_Tie = 0x874;
                export const m_iCompetitiveRankingPredicted_Win = 0x86C;
                export const m_iCompetitiveRankingPredicted_Loss = 0x870;
                export const m_dblLastReceivedPacketPlatFloatTime = 0x978;
                export const m_msQueuedModeDisconnectionTimestamp = 0x8BC;
                export const m_bHasBeenControlledByPlayerThisRound = 0x8E2;
                export const m_LastTimePlayerWasDisconnectedForPawnsRemove = 0x984;
            }
            export namespace CCSPlayerLegacyJump {
                export const m_bOldJumpPressed = 0x10;
                export const m_flJumpPressedTime = 0x14;
            }
            export namespace CCSPlayerModernJump {
                export const m_nLastLandedTick = 0x20;
                export const m_flLastLandedFrac = 0x24;
                export const m_flLastLandedVelocityX = 0x28;
                export const m_flLastLandedVelocityY = 0x2C;
                export const m_flLastLandedVelocityZ = 0x30;
                export const m_nLastActualJumpPressTick = 0x10;
                export const m_nLastUsableJumpPressTick = 0x18;
                export const m_flLastActualJumpPressFrac = 0x14;
                export const m_flLastUsableJumpPressFrac = 0x1C;
            }
            export namespace CEnvSoundscapeProxy {
                export const m_MainSoundscapeName = 0x538;
            }
            export namespace CFilterAttributeInt {
                export const m_sAttributeName = 0x4E0;
            }
            export namespace CFloatMovingAverage {

            }
            export namespace CFuncNavObstruction {
                export const m_bDisabled = 0x868;
                export const m_bUseAsyncObstacleUpdate = 0x869;
            }
            export namespace CGameChoreoServices {
                export const m_hOwner = 0x8;
                export const m_choreoState = 0x14;
                export const m_scriptState = 0x10;
                export const m_hScriptedSequence = 0xC;
                export const m_flTimeStartedState = 0x18;
            }
            export namespace CInfoGameEventProxy {
                export const m_flRange = 0x4B0;
                export const m_iszEventName = 0x4A8;
            }
            export namespace CInfoLadderDismount {

            }
            export namespace CInfoParticleTarget {

            }
            export namespace CLogicActivityEvent {
                export const m_hSource = 0x4B8;
                export const m_flDuration = 0x4AC;
                export const m_nEventType = 0x4A8;
                export const m_iszSourceEntityName = 0x4B0;
            }
            export namespace CLogicCollisionPair {
                export const m_disabled = 0x4BA;
                export const m_succeeded = 0x4BB;
                export const m_nameAttach1 = 0x4A8;
                export const m_nameAttach2 = 0x4B0;
                export const m_allowMissing = 0x4BC;
                export const m_includeHierarchy = 0x4B8;
                export const m_supportMultipleEntitiesWithSameName = 0x4B9;
            }
            export namespace CLogicDistanceCheck {
                export const m_InZone1 = 0x4C0;
                export const m_InZone2 = 0x4D8;
                export const m_InZone3 = 0x4F0;
                export const m_iszEntityA = 0x4A8;
                export const m_iszEntityB = 0x4B0;
                export const m_flZone1Distance = 0x4B8;
                export const m_flZone2Distance = 0x4BC;
            }
            export namespace CLogicEventListener {
                export const m_nTeam = 0x4C4;
                export const m_bIsEnabled = 0x4C0;
                export const m_OnEventFired = 0x4C8;
                export const m_strEventName = 0x4B8;
            }
            export namespace CLogicNPCCounterOBB {

            }
            export namespace CMarkupSearchHelper {
                export const m_bActive = 0x26;
                export const m_navHull = 0x0;
                export const m_vRefPos = 0x18;
                export const m_tagString = 0x8;
                export const m_bRefPosSet = 0x24;
                export const m_nameString = 0x10;
                export const m_bUseStepHeight = 0x25;
            }
            export namespace CMarkupVolumeTagged {
                export const m_Tags = 0x870;
                export const m_bIsGroup = 0x888;
                export const m_GroupNames = 0x858;
                export const m_bIsInGroup = 0x88C;
                export const m_bGroupByPrefab = 0x889;
                export const m_bGroupByVolume = 0x88A;
                export const m_bGroupOtherGroups = 0x88B;
            }
            export namespace CMomentaryRotButton {
                export const m_end = 0xA60;
                export const m_start = 0xA54;
                export const m_sNoise = 0xA70;
                export const m_IdealYaw = 0xA6C;
                export const m_Position = 0x9D0;
                export const m_lastUsed = 0xA50;
                export const m_direction = 0xA7C;
                export const m_OnFullyOpen = 0xA08;
                export const m_OnUnpressed = 0x9F0;
                export const m_returnSpeed = 0xA80;
                export const m_OnFullyClosed = 0xA20;
                export const m_bUpdateTarget = 0xA78;
                export const m_flStartPosition = 0xA84;
                export const m_OnReachedPosition = 0xA38;
            }
            export namespace CNavHullPresetVData {
                export const m_vecNavHulls = 0x0;
            }
            export namespace CPathQueryComponent {

            }
            export namespace CPlayer_UseServices {

            }
            export namespace CPointChildModifier {
                export const m_bOrphanInsteadOfDeletingChildrenOnRemove = 0x4A8;
            }
            export namespace CPointClientCommand {

            }
            export namespace CPointServerCommand {

            }
            export namespace CPointValueRemapper {
                export const m_OnEngage = 0x620;
                export const m_Position = 0x598;
                export const m_bEngaged = 0x538;
                export const m_bDisabled = 0x4A8;
                export const m_nInputType = 0x4AC;
                export const m_OnDisengage = 0x638;
                export const m_flSnapValue = 0x524;
                export const m_nOutputType = 0x4D8;
                export const m_bFirstUpdate = 0x539;
                export const m_hUsingPlayer = 0x550;
                export const m_nHapticsType = 0x518;
                export const m_nRatchetType = 0x52C;
                export const m_PositionDelta = 0x5B8;
                export const m_flInputOffset = 0x534;
                export const m_hRemapLineEnd = 0x4C4;
                export const m_nMomentumType = 0x51C;
                export const m_iszSoundEngage = 0x558;
                export const m_bRequiresUseKey = 0x4D4;
                export const m_bUpdateOnClient = 0x4A9;
                export const m_flPreviousValue = 0x53C;
                export const m_flRatchetOffset = 0x530;
                export const m_hOutputEntities = 0x500;
                export const m_hRemapLineStart = 0x4C0;
                export const m_flEngageDistance = 0x4D0;
                export const m_OnReachedValueOne = 0x5F0;
                export const m_flCurrentMomentum = 0x528;
                export const m_iszSoundDisengage = 0x560;
                export const m_OnReachedValueZero = 0x5D8;
                export const m_flMomentumModifier = 0x520;
                export const m_iszSoundMovingLoop = 0x578;
                export const m_flCustomOutputValue = 0x554;
                export const m_flDisengageDistance = 0x4CC;
                export const m_iszOutputEntityName = 0x4E0;
                export const m_iszRemapLineEndName = 0x4B8;
                export const m_OnReachedValueCustom = 0x608;
                export const m_iszOutputEntity2Name = 0x4E8;
                export const m_iszOutputEntity3Name = 0x4F0;
                export const m_iszOutputEntity4Name = 0x4F8;
                export const m_vecPreviousTestPoint = 0x544;
                export const m_iszRemapLineStartName = 0x4B0;
                export const m_iszSoundReachedValueOne = 0x570;
                export const m_flMaximumChangePerSecond = 0x4C8;
                export const m_flPreviousUpdateTickTime = 0x540;
                export const m_iszSoundReachedValueZero = 0x568;
            }
            export namespace CPrecipitationVData {
                export const m_nRTEnvCP = 0x2D4;
                export const m_szModifier = 0x2E0;
                export const m_nAttachType = 0x2CC;
                export const m_snapshotFilter = 0x2EC;
                export const m_flInnerDistance = 0x2C8;
                export const m_nRTEnvCPComponent = 0x2D8;
                export const m_bBatchSameVolumeType = 0x2D0;
                export const m_nUseSnapshotFromSurfaceGraph = 0x2E8;
                export const m_szParticlePrecipitationEffect = 0x28;
                export const m_szParticlePrecipitationPostEffect = 0x1E8;
                export const m_szParticlePrecipitationPuddleEffect = 0x108;
            }
            export namespace CPulseCell_BaseFlow {

            }
            export namespace CPulseCell_BaseLerp {
                export const m_WakeResume = 0xD8;
            }
            export namespace CPulseCell_Timeline {
                export const m_OnFinished = 0xF8;
                export const m_TimelineEvents = 0xD8;
                export const m_bWaitForChildOutflows = 0xF0;
            }
            export namespace CTonemapController2 {
                export const m_flAutoExposureMax = 0x4AC;
                export const m_flAutoExposureMin = 0x4A8;
                export const m_flTonemapEVSmoothingRange = 0x4B8;
                export const m_flExposureAdaptationSpeedUp = 0x4B0;
                export const m_flExposureAdaptationSpeedDown = 0x4B4;
            }
            export namespace CTriggerSndSosOpvar {
                export const m_bVolIs2D = 0xA10;
                export const m_flMaxVal = 0x9F4;
                export const m_flMinVal = 0x9F0;
                export const m_opvarName = 0x9F8;
                export const m_stackName = 0xA00;
                export const m_VecNormPos = 0xD14;
                export const m_flPosition = 0x9E0;
                export const m_flCenterSize = 0x9EC;
                export const m_operatorName = 0xA08;
                export const m_opvarNameChar = 0xA11;
                export const m_stackNameChar = 0xB11;
                export const m_flNormCenterSize = 0xD20;
                export const m_hTouchingPlayers = 0x9C8;
                export const m_operatorNameChar = 0xC11;
            }
            export namespace CWeaponM4A1Silencer {

            }
            export namespace ConstraintSoundInfo {
                export const m_vSampler = 0x8;
                export const m_forwardAxis = 0x40;
                export const m_soundProfile = 0x20;
                export const m_bPlayTravelSound = 0x90;
                export const m_iszTravelSoundFwd = 0x50;
                export const m_bPlayReversalSound = 0x91;
                export const m_iszTravelSoundBack = 0x58;
                export const m_iszReversalSoundLarge = 0x88;
                export const m_iszReversalSoundSmall = 0x78;
                export const m_iszReversalSoundMedium = 0x80;
            }
            export namespace ModelConfigHandle_t {
                export const m_Value = 0x0;
            }
            export namespace magnetted_objects_t {
                export const hEntity = 0x8;
            }
            export namespace sndopvarlatchdata_t {
                export const m_vPos = 0x24;
                export const m_flVal = 0x20;
                export const m_iszOpvar = 0x18;
                export const m_iszStack = 0x8;
                export const m_iszOperator = 0x10;
            }
            export namespace CBaseCombatCharacter {
                export const m_eHull = 0xAC8;
                export const m_nNavHullIdx = 0xACC;
                export const m_hMyWearables = 0xA48;
                export const m_movementStats = 0xAD0;
                export const m_strRelationships = 0xAC0;
                export const m_vecRelationships = 0xAA8;
                export const m_impactEnergyScale = 0xA60;
                export const m_bApplyStressDamage = 0xA64;
                export const m_bForceServerRagdoll = 0xA40;
                export const m_bDeathEventsDispatched = 0xA65;
            }
            export namespace CCSObservableElement {
                export const m_nTeamFilter = 0x4D0;
                export const m_hObservableModelEntity = 0x4C8;
                export const m_hObservableModelEntity2 = 0x4CC;
                export const m_iszObservableModelEntity = 0x4C0;
            }
            export namespace CCSPointScriptEntity {

            }
            export namespace CCSWeaponBaseShotgun {

            }
            export namespace CCopyRecipientFilter {
                export const m_Flags = 0x8;
                export const m_Recipients = 0x10;
                export const m_slotPlayerExcludedDueToPrediction = 0x30;
            }
            export namespace CDebugSnapshotData_t {
                export const m_text = 0x0;
                export const m_hEntity = 0x100;
                export const m_children = 0x120;
                export const m_dataType = 0x8;
                export const m_userData = 0x10;
                export const m_drawColor = 0xD8;
                export const m_userFlags = 0xC;
                export const m_userShape = 0x40;
                export const m_userVector = 0x14;
                export const m_sEntityName = 0x108;
                export const m_nEntityIndex = 0x110;
                export const m_userTransform = 0x20;
                export const m_pStructuredData = 0xF8;
                export const m_vecDebugOverlayData = 0xE0;
            }
            export namespace CEnvDetailController {
                export const m_flFadeEndDist = 0x4AC;
                export const m_flFadeStartDist = 0x4A8;
            }
            export namespace CEnvInstructorVRHint {
                export const m_iszName = 0x4A8;
                export const m_iTimeout = 0x4B8;
                export const m_iszCaption = 0x4C0;
                export const m_iAttachType = 0x4E0;
                export const m_iszStartSound = 0x4C8;
                export const m_flHeightOffset = 0x4E4;
                export const m_iLayoutFileType = 0x4D0;
                export const m_iszCustomLayoutFile = 0x4D8;
                export const m_iszHintTargetEntity = 0x4B0;
            }
            export namespace CEnvLightProbeVolume {
                export const m_Entity_bEnabled = 0x5C1;
                export const m_Entity_vBoxMaxs = 0x584;
                export const m_Entity_vBoxMins = 0x578;
                export const m_Entity_bMoveable = 0x590;
                export const m_Entity_nPriority = 0x598;
                export const m_Entity_nHandshake = 0x594;
                export const m_Entity_bStartDisabled = 0x59C;
                export const m_Entity_nLightProbeSizeX = 0x5A0;
                export const m_Entity_nLightProbeSizeY = 0x5A4;
                export const m_Entity_nLightProbeSizeZ = 0x5A8;
                export const m_Entity_nLightProbeAtlasX = 0x5AC;
                export const m_Entity_nLightProbeAtlasY = 0x5B0;
                export const m_Entity_nLightProbeAtlasZ = 0x5B4;
                export const m_Entity_hLightProbeTexture_SDF = 0x548;
                export const m_Entity_hLightProbeTexture_SH2_DC = 0x550;
                export const m_Entity_hLightProbeTexture_SH2_L1 = 0x558;
                export const m_Entity_hLightProbeTexture_AmbientCube = 0x540;
                export const m_Entity_hLightProbeDirectLightIndicesTexture = 0x560;
                export const m_Entity_hLightProbeDirectLightScalarsTexture = 0x568;
                export const m_Entity_hLightProbeDirectLightShadowsTexture = 0x570;
            }
            export namespace CFlashbangProjectile {
                export const m_numOpponentsHit = 0xB44;
                export const m_numTeammatesHit = 0xB45;
                export const m_flTimeToDetonate = 0xB40;
            }
            export namespace CFootstepTableHandle {

            }
            export namespace CFuncPropRespawnZone {

            }
            export namespace CGameSceneNodeHandle {
                export const m_name = 0xC;
                export const m_hOwner = 0x8;
            }
            export namespace CHEGrenadeProjectile {

            }
            export namespace CInfoDeathmatchSpawn {

            }
            export namespace CInfoPlayerTerrorist {

            }
            export namespace CIronSightController {
                export const m_flIronSightAmount = 0xC;
                export const m_bIronSightAvailable = 0x8;
                export const m_flIronSightAmountBiased = 0x14;
                export const m_flIronSightAmountGained = 0x10;
            }
            export namespace CLogicActiveAutosave {
                export const m_flStartTime = 0x4C0;
                export const m_flDangerousTime = 0x4C4;
                export const m_flTimeToTrigger = 0x4BC;
                export const m_TriggerHitPoints = 0x4B8;
            }
            export namespace CLogicNPCCounterAABB {
                export const m_vOuterMaxs = 0x74C;
                export const m_vOuterMins = 0x740;
                export const m_vDistanceOuterMaxs = 0x734;
                export const m_vDistanceOuterMins = 0x728;
            }
            export namespace CMarkupVolumeWithRef {
                export const m_bUseRef = 0x898;
                export const m_flRefDot = 0x8B4;
                export const m_vRefPosWorldSpace = 0x8A8;
                export const m_vRefPosEntitySpace = 0x89C;
            }
            export namespace CNMEventPulseState_t {
                export const m_eventID = 0x0;
            }
            export namespace CNavPathCostForTests {

            }
            export namespace CPhysSlideConstraint {
                export const m_axisEnd = 0x510;
                export const m_soundInfo = 0x538;
                export const m_initialOffset = 0x524;
                export const m_slideFriction = 0x51C;
                export const m_bUseEntityPivot = 0x534;
                export const m_systemLoadScale = 0x520;
                export const m_flMotorFrequency = 0x52C;
                export const m_flMotorDampingRatio = 0x530;
                export const m_bEnableLinearConstraint = 0x528;
                export const m_bEnableAngularConstraint = 0x529;
            }
            export namespace CPhysWheelConstraint {
                export const m_flMaxSteeringAngle = 0x528;
                export const m_flMinSteeringAngle = 0x524;
                export const m_flSpinAxisFriction = 0x530;
                export const m_bEnableSteeringLimit = 0x520;
                export const m_flMaxSuspensionOffset = 0x51C;
                export const m_flMinSuspensionOffset = 0x518;
                export const m_flSuspensionFrequency = 0x508;
                export const m_hSteeringMimicsEntity = 0x534;
                export const m_bEnableSuspensionLimit = 0x514;
                export const m_flSteeringAxisFriction = 0x52C;
                export const m_flSuspensionDampingRatio = 0x50C;
                export const m_flSuspensionHeightOffset = 0x510;
            }
            export namespace CPhysicsEntitySolver {
                export const m_cancelTime = 0x4CC;
                export const m_hMovingEntity = 0x4C0;
                export const m_hPhysicsBlocker = 0x4C4;
                export const m_separationDuration = 0x4C8;
            }
            export namespace CPhysicsPropOverride {

            }
            export namespace CPlayerPawnComponent {
                export const __m_pChainEntity = 0x8;
                export const m_pComponentGraphController = 0x30;
            }
            export namespace CPlayer_ItemServices {

            }
            export namespace CPointClientUIDialog {
                export const m_hActivator = 0x9B0;
                export const m_bStartEnabled = 0x9B4;
            }
            export namespace CPointCommentaryNode {
                export const m_bActive = 0xAE8;
                export const m_iszTitle = 0xAF8;
                export const m_bDisabled = 0xAA5;
                export const m_bListenedTo = 0xB10;
                export const m_flStartTime = 0xAEC;
                export const m_hViewTarget = 0xA60;
                export const m_iNodeNumber = 0xB08;
                export const m_iszSpeakers = 0xB00;
                export const m_bUnstoppable = 0xA7A;
                export const m_hViewPosition = 0xA70;
                export const m_iszViewTarget = 0xA58;
                export const m_flFinishedTime = 0xA7C;
                export const m_iNodeNumberMax = 0xB0C;
                export const m_iszPreCommands = 0xA40;
                export const m_bUnderCrosshair = 0xA79;
                export const m_iszPostCommands = 0xA48;
                export const m_iszViewPosition = 0xA68;
                export const m_vecFinishAngles = 0xA98;
                export const m_vecFinishOrigin = 0xA80;
                export const m_bPreventMovement = 0xA78;
                export const m_hViewTargetAngles = 0xA64;
                export const m_iszCommentaryFile = 0xA50;
                export const m_vecOriginalAngles = 0xA8C;
                export const m_vecTeleportOrigin = 0xAA8;
                export const m_hViewPositionMover = 0xA74;
                export const m_flAbortedPlaybackAt = 0xAB4;
                export const m_pOnCommentaryStarted = 0xAB8;
                export const m_pOnCommentaryStopped = 0xAD0;
                export const m_flStartTimeInCommentary = 0xAF0;
                export const m_bPreventChangesWhileMoving = 0xAA4;
            }
            export namespace CPointVelocitySensor {
                export const m_vecAxis = 0x4AC;
                export const m_Velocity = 0x4C8;
                export const m_bEnabled = 0x4B8;
                export const m_fPrevVelocity = 0x4BC;
                export const m_flAvgInterval = 0x4C0;
                export const m_hTargetEntity = 0x4A8;
            }
            export namespace CPulseCell_BaseState {

            }
            export namespace CPulseCell_BaseValue {

            }
            export namespace CPulseGameBlackboard {
                export const m_strGraphName = 0x4B0;
                export const m_strStateBlob = 0x4B8;
            }
            export namespace CPulse_InvokeBinding {
                export const m_FuncName = 0x30;
                export const m_nSrcChunk = 0x44;
                export const m_nCellIndex = 0x40;
                export const m_RegisterMap = 0x0;
                export const m_nSrcInstruction = 0x48;
            }
            export namespace CRagdollPropAttached {
                export const m_bShouldDetach = 0xC20;
                export const m_boneIndexAttached = 0xC00;
                export const m_attachmentPointBoneSpace = 0xC08;
                export const m_ragdollAttachedObjectIndex = 0xC04;
                export const m_attachmentPointRagdollSpace = 0xC14;
                export const m_bShouldDeleteAttachedActivationRecord = 0xC30;
            }
            export namespace CResponseCriteriaSet {
                export const m_bOverrideOnAppend = 0x30;
            }
            export namespace CSoundAreaEntityBase {
                export const m_vPos = 0x4B8;
                export const m_bDisabled = 0x4A8;
                export const m_iszSoundAreaType = 0x4B0;
            }
            export namespace CSoundEventBoxEntity {
                export const m_iszBoxEntities = 0x5A0;
                export const m_vecBoxHelpersNetworked = 0x638;
            }
            export namespace CSoundEventBoxHelper {
                export const m_vMaxs = 0x4B4;
                export const m_vMins = 0x4A8;
            }
            export namespace CSoundEventOBBEntity {
                export const m_vMaxs = 0x574;
                export const m_vMins = 0x568;
            }
            export namespace CSoundEventParameter {
                export const m_flFloatValue = 0x4C8;
                export const m_iszParamName = 0x4C0;
            }
            export namespace CSoundOpvarSetEntity {
                export const m_nOpvarType = 0x4D8;
                export const m_bSetOnSpawn = 0x4F0;
                export const m_nOpvarIndex = 0x4DC;
                export const m_flOpvarValue = 0x4E0;
                export const m_iszOpvarName = 0x4D0;
                export const m_iszStackName = 0x4C0;
                export const m_iszOperatorName = 0x4C8;
                export const m_OpvarValueString = 0x4E8;
            }
            export namespace CTriggerHostageReset {

            }
            export namespace CVectorMovingAverage {

            }
            export namespace EngineCountdownTimer {
                export const m_duration = 0x8;
                export const m_timescale = 0x10;
                export const m_timestamp = 0xC;
            }
            export namespace EntitySpottedState_t {
                export const m_bSpotted = 0x8;
                export const m_bSpottedByMask = 0xC;
            }
            export namespace PathMoverEntitySpawn {
                export const hMover = 0x0;
                export const nSpawnNumber = 0x20;
                export const vecOtherEntities = 0x8;
            }
            export namespace PhysicsRagdollPose_t {
                export const m_hOwner = 0x20;
                export const m_RelativeTransforms = 0x8;
                export const m_bSetFromDebugHistory = 0x24;
            }
            export namespace CBasePlayerController {
                export const m_hPawn = 0x4E0;
                export const m_bIsHLTV = 0x510;
                export const m_steamID = 0x710;
                export const m_bPredict = 0x5AD;
                export const m_fLerpTime = 0x5A8;
                export const m_nTickBase = 0x4B8;
                export const m_iConnected = 0x514;
                export const m_bGamePaused = 0x5B5;
                export const m_hSplitOwner = 0x4F0;
                export const m_iDesiredFOV = 0x71C;
                export const m_iszPlayerName = 0x51C;
                export const m_bIsLowViolence = 0x5B4;
                export const m_bNoClipEnabled = 0x718;
                export const m_iMostConnected = 0x518;
                export const m_bLagCompensation = 0x5AC;
                export const m_nSplitScreenSlot = 0x4EC;
                export const m_iIgnoreGlobalChat = 0x6F0;
                export const m_szNetworkIDString = 0x5A0;
                export const m_bKnownTeamMismatch = 0x4E4;
                export const m_hSplitScreenPlayers = 0x4F8;
                export const m_flLastPlayerTalkTime = 0x6F4;
                export const m_bHasAnySteadyStateEnts = 0x700;
                export const m_flLastEntitySteadyState = 0x6F8;
                export const m_nInButtonsWhichAreToggles = 0x4B0;
                export const m_nAvailableEntitySteadyState = 0x6FC;
            }
            export namespace CBreakableStageHelper {
                export const m_nStageCount = 0xC;
                export const m_nCurrentStage = 0x8;
            }
            export namespace CCSCustomPlayerCamera {
                export const m_hPawn = 0x4A8;
                export const m_bFollowEyes = 0x4B4;
                export const m_nCameraMode = 0x4AC;
                export const m_hFollowEntity = 0x4B0;
                export const m_vecCameraOffset = 0x4C4;
                export const m_vecFollowOffset = 0x4B8;
                export const m_bClipCameraOffset = 0x4D0;
                export const m_flCameraOffsetReturnStrength = 0x4D4;
            }
            export namespace CCSGameModeRules_Noop {

            }
            export namespace CCSPlayer_BuyServices {
                export const m_vecSellbackPurchaseEntries = 0xD0;
            }
            export namespace CCSPlayer_UseServices {
                export const m_flLastUseTimeStamp = 0x4C;
                export const m_hLastKnownUseEntity = 0x48;
                export const m_flTimeLastUsedWindow = 0x50;
            }
            export namespace CDebugDrawHistoryData {
                export const m_bools = 0x58;
                export const m_etype = 0x4;
                export const m_times = 0x38;
                export const m_colors = 0x18;
                export const m_hEntity = 0x0;
                export const m_strings = 0x68;
                export const m_uint64s = 0x48;
                export const m_vectors = 0x8;
                export const m_dimensions = 0x28;
            }
            export namespace CEmptyGraphController {

            }
            export namespace CGameScriptedMoveData {
                export const m_vSrc = 0x18;
                export const m_vDest = 0x58;
                export const m_angDst = 0x64;
                export const m_angSrc = 0x24;
                export const m_bActive = 0x4C;
                export const m_bSuccess = 0x4F;
                export const m_flAngRate = 0x40;
                export const m_angCurrent = 0x30;
                export const m_flDuration = 0x44;
                export const m_flStartTime = 0x48;
                export const m_hDestEntity = 0x70;
                export const m_flLockedSpeed = 0x3C;
                export const m_bTeleportOnEnd = 0x4D;
                export const m_bIgnoreRotation = 0x4E;
                export const m_bIgnoreCollisions = 0x54;
                export const m_nForcedCrouchState = 0x50;
                export const m_vAccumulatedRootMotion = 0x0;
                export const m_angAccumulatedRootMotionRotation = 0xC;
            }
            export namespace CHostageCarriableProp {

            }
            export namespace CHostageExpresserShim {
                export const m_pExpresser = 0xB10;
            }
            export namespace CInfoTargetServerOnly {

            }
            export namespace CInstancedSceneEntity {
                export const m_hOwner = 0x800;
                export const m_hTarget = 0x814;
                export const m_bHadOwner = 0x804;
                export const m_flPreDelay = 0x80C;
                export const m_bIsBackground = 0x810;
                export const m_flPostSpeakDelay = 0x808;
            }
            export namespace CLogicGameStateReport {
                export const m_bDisabled = 0x4A8;
            }
            export namespace CLogicMeasureMovement {
                export const m_flScale = 0x4D0;
                export const m_hTarget = 0x4C8;
                export const m_nMeasureType = 0x4D4;
                export const m_hMeasureTarget = 0x4C0;
                export const m_hTargetReference = 0x4CC;
                export const m_strMeasureTarget = 0x4A8;
                export const m_hMeasureReference = 0x4C4;
                export const m_strTargetReference = 0x4B8;
                export const m_strMeasureReference = 0x4B0;
            }
            export namespace CLogicPlayerProxyBase {
                export const m_hPlayer = 0x510;
                export const m_PlayerDied = 0x4D8;
                export const m_PlayerHasAmmo = 0x4A8;
                export const m_PlayerHasNoAmmo = 0x4C0;
                export const m_RequestedPlayerHealth = 0x4F0;
            }
            export namespace CMapSharedEnvironment {
                export const m_targetMapName = 0x4A8;
            }
            export namespace CNmEventConsumerCloth {

            }
            export namespace CNmEventConsumerPulse {

            }
            export namespace CNmEventConsumerSound {

            }
            export namespace CPathWithDynamicNodes {
                export const m_vecPathNodes = 0x5B0;
                export const m_eDesiredDirection = 0x5F0;
                export const m_bIgnoreParentRotation = 0x5F4;
                export const m_xInitialPathWorldToLocal = 0x5D0;
            }
            export namespace CPlayer_WaterServices {

            }
            export namespace CPointProximitySensor {
                export const m_Distance = 0x4B0;
                export const m_bDisabled = 0x4A8;
                export const m_hTargetEntity = 0x4AC;
            }
            export namespace CPostProcessingVolume {
                export const m_bMaster = 0xA04;
                export const m_flMaxExposure = 0x9F0;
                export const m_flMinExposure = 0x9EC;
                export const m_hPostSettings = 0x9D8;
                export const m_flFadeDuration = 0x9E0;
                export const m_bExposureControl = 0xA05;
                export const m_flMaxLogExposure = 0x9E8;
                export const m_flMinLogExposure = 0x9E4;
                export const m_flExposureFadeSpeedUp = 0x9F8;
                export const m_flExposureCompensation = 0x9F4;
                export const m_flExposureFadeSpeedDown = 0x9FC;
                export const m_flTonemapEVSmoothingRange = 0xA00;
            }
            export namespace CPrecipitationBlocker {

            }
            export namespace CPulseCell_LimitCount {
                export const m_nLimitCount = 0x48;
            }
            export namespace CServerRagdollTrigger {

            }
            export namespace CSoundEventAABBEntity {
                export const m_vMaxs = 0x574;
                export const m_vMins = 0x568;
            }
            export namespace CSoundEventConeEntity {
                export const m_flAttenMax = 0x574;
                export const m_flAttenMin = 0x570;
                export const m_flEmitterAngle = 0x568;
                export const m_flSweetSpotAngle = 0x56C;
                export const m_iszParameterName = 0x578;
            }
            export namespace CSpriteAlias_env_glow {

            }
            export namespace CTestPulseIOComponent {
                export const m_ComponentData = 0x8;
                export const m_OnComponentTestFunc = 0x10;
            }
            export namespace PointCameraSettings_t {
                export const m_flFarCrispDistance = 0x8;
                export const m_flFarBlurryDistance = 0xC;
                export const m_flNearCrispDistance = 0x4;
                export const m_flNearBlurryDistance = 0x0;
            }
            export namespace PrecipitationFilter_t {
                export const m_flMaxRadius = 0x0;
            }
            export namespace WeaponPurchaseCount_t {
                export const m_nCount = 0x32;
                export const m_nItemDefIndex = 0x30;
            }
            export namespace WrappedPhysicsJoint_t {
                export const m_pJoint = 0x0;
            }
            export namespace physics_save_sphere_t {
                export const radius = 0x0;
            }
            export namespace AutoRoomDoorwayPairs_t {
                export const vP1 = 0x0;
                export const vP2 = 0xC;
            }
            export namespace CAnimGraph2InstancePtr {

            }
            export namespace CBasePlayerWeaponVData {
                export const m_iSlot = 0x4EC;
                export const m_iFlags = 0x4C7;
                export const m_iWeight = 0x4C8;
                export const m_iMaxClip1 = 0x4D0;
                export const m_iMaxClip2 = 0x4D4;
                export const m_iPosition = 0x4F0;
                export const m_flDropSpeed = 0x4E8;
                export const m_aShootSounds = 0x4F8;
                export const m_szWorldModel = 0x28;
                export const m_bAutoSwitchTo = 0x4CC;
                export const m_iDefaultClip1 = 0x4D8;
                export const m_iDefaultClip2 = 0x4DC;
                export const m_iRumbleEffect = 0x4E4;
                export const m_bAllowFlipping = 0x2C9;
                export const m_bAutoSwitchFrom = 0x4CD;
                export const m_bKeepLoadedAmmo = 0x4E2;
                export const m_bLinkedCooldowns = 0x4C6;
                export const m_nPrimaryAmmoType = 0x4CE;
                export const m_bBuiltRightHanded = 0x2C8;
                export const m_sMuzzleAttachment = 0x2D0;
                export const m_bTreatAsSingleClip = 0x4E1;
                export const m_nSecondaryAmmoType = 0x4CF;
                export const m_bReserveAmmoAsClips = 0x4E0;
                export const m_bGenerateMuzzleLight = 0x4C4;
                export const m_flMuzzleSmokeTimeout = 0x4BC;
                export const m_bShouldAnimateInWorld = 0x4C5;
                export const m_szBarrelSmokeParticle = 0x3D8;
                export const m_szMuzzleFlashParticle = 0x2F0;
                export const m_szWorldModelAg2Override = 0x108;
                export const m_sToolsOnlyOwnerModelName = 0x1E8;
                export const m_nMuzzleSmokeShotThreshold = 0x4B8;
                export const m_flMuzzleSmokeDecrementRate = 0x4C0;
                export const m_szMuzzleFlashParticleConfig = 0x3D0;
            }
            export namespace CCSPlayer_ItemServices {
                export const m_bHasHelmet = 0x49;
                export const m_bHasDefuser = 0x48;
            }
            export namespace CCSPlayer_PingServices {
                export const m_hPlayerPing = 0x5C;
                export const m_flPlayerPingTokens = 0x48;
            }
            export namespace CColorCorrectionVolume {
                export const m_Weight = 0x9D0;
                export const m_MaxWeight = 0x9C8;
                export const m_FadeDuration = 0x9CC;
                export const m_LastExitTime = 0xBE0;
                export const m_LastEnterTime = 0xBD8;
                export const m_LastExitWeight = 0xBDC;
                export const m_lookupFilename = 0x9D4;
                export const m_LastEnterWeight = 0xBD4;
            }
            export namespace CExternalAnimGraphList {

            }
            export namespace CFuncElectrifiedVolume {
                export const m_EffectName = 0x870;
                export const m_EffectZapName = 0x880;
                export const m_iszEffectSource = 0x888;
                export const m_EffectInterpenetrateName = 0x878;
            }
            export namespace CGameScriptedMoveDef_t {
                export const m_angDest = 0x10;
                export const m_flAngRate = 0x20;
                export const m_flDuration = 0x1C;
                export const m_flMoveSpeed = 0x24;
                export const m_hDestEntity = 0xC;
                export const m_vDestOffset = 0x0;
                export const m_bAimDisabled = 0x28;
                export const m_bIgnoreRotation = 0x29;
                export const m_nForcedCrouchState = 0x2C;
            }
            export namespace CHostageRescueZoneShim {

            }
            export namespace CInfoDynamicShadowHint {
                export const m_hLight = 0x4B8;
                export const m_flRange = 0x4AC;
                export const m_bDisabled = 0x4A8;
                export const m_nImportance = 0x4B0;
                export const m_nLightChoice = 0x4B4;
            }
            export namespace CInstructorEventEntity {
                export const m_iszName = 0x4A8;
                export const m_hTargetPlayer = 0x4B8;
                export const m_iszHintTargetEntity = 0x4B0;
            }
            export namespace CLogicDistanceAutosave {
                export const m_bCheckCough = 0x4B5;
                export const m_bThinkDangerous = 0x4B6;
                export const m_flDangerousTime = 0x4B8;
                export const m_iszTargetEntity = 0x4A8;
                export const m_bForceNewLevelUnit = 0x4B4;
                export const m_flDistanceToPlayer = 0x4B0;
            }
            export namespace CMapVetoPickController {
                export const m_nMapId0 = 0x6F8;
                export const m_nMapId1 = 0x7F8;
                export const m_nMapId2 = 0x8F8;
                export const m_nMapId3 = 0x9F8;
                export const m_nMapId4 = 0xAF8;
                export const m_nMapId5 = 0xBF8;
                export const m_nDraftType = 0x4D4;
                export const m_OnMapPicked = 0xE28;
                export const m_OnMapVetoed = 0xE08;
                export const m_nAccountIDs = 0x5F8;
                export const m_OnSidesPicked = 0xE48;
                export const m_nCurrentPhase = 0xDF8;
                export const m_nStartingSide0 = 0xCF8;
                export const m_bPlayedIntroVcd = 0x4A8;
                export const m_nPhaseStartTick = 0xDFC;
                export const m_nVoteMapIdsList = 0x5DC;
                export const m_OnLevelTransition = 0xE88;
                export const m_OnNewPhaseStarted = 0xE68;
                export const m_nPhaseDurationTicks = 0xE00;
                export const m_nTeamWinningCoinToss = 0x4D8;
                export const m_nTeamWithFirstChoice = 0x4DC;
                export const m_bPreMatchDraftStateChanged = 0x4D0;
                export const m_dblPreMatchDraftSequenceTime = 0x4C8;
                export const m_bNeedToPlayFiveSecondsRemaining = 0x4A9;
            }
            export namespace CMovementStatsProperty {
                export const m_nUseCounter = 0x10;
                export const m_emaMovementDirection = 0x14;
            }
            export namespace CMultiplayer_Expresser {
                export const m_bAllowMultipleScenes = 0xA0;
            }
            export namespace CNavVolumeMarkupVolume {

            }
            export namespace CNetworkVelocityVector {
                export const m_vecX = 0x10;
                export const m_vecY = 0x18;
                export const m_vecZ = 0x20;
            }
            export namespace CNmEventConsumerCamera {

            }
            export namespace CNmEventConsumerLegacy {

            }
            export namespace CPhysicsBodyGameMarkup {
                export const m_Tag = 0x8;
                export const m_TargetBody = 0x0;
            }
            export namespace CPlayer_CameraServices {
                export const m_audio = 0xB0;
                export const m_PlayerFog = 0x60;
                export const m_hViewEntity = 0xA4;
                export const m_flOldPlayerZ = 0x140;
                export const m_hTonemapController = 0xA8;
                export const m_vecCsViewPunchAngle = 0x48;
                export const m_hColorCorrectionCtrl = 0xA0;
                export const m_PostProcessingVolumes = 0x128;
                export const m_nCsViewPunchAngleTick = 0x54;
                export const m_flOldPlayerViewOffsetZ = 0x144;
                export const m_hTriggerSoundscapeList = 0x160;
                export const m_flCsViewPunchAngleTickRatio = 0x58;
            }
            export namespace CPlayer_WeaponServices {
                export const m_iAmmo = 0x68;
                export const m_hMyWeapons = 0x48;
                export const m_hLastWeapon = 0x64;
                export const m_hActiveWeapon = 0x60;
                export const m_bPreventWeaponPickup = 0xA8;
            }
            export namespace CPointGamestatsCounter {
                export const m_bDisabled = 0x4B0;
                export const m_strStatisticName = 0x4A8;
            }
            export namespace CPulseCell_ApplyParent {

            }
            export namespace CPulseCell_CursorQueue {
                export const m_nCursorsAllowedToRunParallel = 0x128;
            }
            export namespace CPulseCell_FireCursors {
                export const m_Outflows = 0xD8;
                export const m_OnFinished = 0xF8;
                export const m_bWaitForChildOutflows = 0xF0;
            }
            export namespace CPulseCell_Inflow_Wait {
                export const m_WakeResume = 0xD8;
            }
            export namespace CPulseCell_RaceCursors {
                export const m_Outflows = 0xD8;
                export const m_OnFinished = 0xF0;
            }
            export namespace CPulseCell_Value_Curve {
                export const m_Curve = 0x48;
            }
            export namespace CScriptTriggerMultiple {
                export const m_vExtent = 0x9E0;
            }
            export namespace CServerOnlyModelEntity {

            }
            export namespace CServerOnlyPointEntity {

            }
            export namespace CSkyCameraVolumeTarget {
                export const m_hSkyMaterial = 0x4B0;
                export const m_nSkyboxScale = 0x4A8;
            }
            export namespace CSoundAreaEntitySphere {
                export const m_flRadius = 0x4C8;
            }
            export namespace INavPathCostAreaFilter {

            }
            export namespace RelationshipOverride_t {
                export const entity = 0x8;
                export const classType = 0xC;
            }
            export namespace globalentitydatabase_t {
                export const m_list = 0x60;
            }
            export namespace CAnimGraphControllerPtr {
                export const m_pController = 0x0;
            }
            export namespace CBasePulseGraphInstance {

            }
            export namespace CCS2PawnGraphController {
                export const m_moveType = 0x5D8;
                export const m_airAction = 0x740;
                export const m_bIsWalking = 0x680;
                export const m_flinchBody = 0x818;
                export const m_flinchHead = 0x7E8;
                export const m_bIsDefusing = 0x5C0;
                export const m_flLadderYaw = 0x710;
                export const m_flMoveSpeedX = 0x608;
                export const m_flMoveSpeedY = 0x620;
                export const m_groundAction = 0x6B0;
                export const m_flAimYawAngle = 0x7D0;
                export const m_flLadderCycle = 0x6F8;
                export const m_flCrouchAmount = 0x668;
                export const m_flinchIsOnFire = 0x848;
                export const m_leftFootTarget = 0x770;
                export const m_flAimPitchAngle = 0x7B8;
                export const m_flFlashedAmount = 0x7A0;
                export const m_moveDirectionID = 0x5F0;
                export const m_rightFootTarget = 0x788;
                export const m_flinchBodyRestart = 0x830;
                export const m_flinchHeadRestart = 0x800;
                export const m_flWeaponDropAmount = 0x698;
                export const m_flLadderYawBackwards = 0x728;
                export const m_flMoveSpeedHorizontal = 0x638;
                export const m_flAirHeightAboveGround = 0x758;
                export const m_groundActionDirectionID = 0x6C8;
                export const m_flGroundTurnAngleOrVelocity = 0x6E0;
                export const m_flPreviousMoveSpeedHorizontal = 0x650;
            }
            export namespace CCSCustomHudLayoutState {
                export const m_playerSlot = 0x30;
                export const m_vecHasClasses = 0x38;
                export const m_bInputCaptureEnabled = 0x34;
                export const m_vecDialogVariableStrings = 0x98;
            }
            export namespace CCSObserver_UseServices {

            }
            export namespace CCSPlayerAnimationState {
                export const m_airAction = 0x1B;
                export const m_actionStartTick = 0x20;
                export const m_currentMoveType = 0x18;
                export const m_groundMoveState = 0x19;
                export const m_flPreviousAimYaw = 0x30;
                export const m_flTurnOnSpotAngle = 0x2C;
                export const m_flFootIKOffsetLeft = 0x38;
                export const m_flFootIKOffsetRight = 0x3C;
                export const m_groundActionDirection = 0x1A;
                export const m_plantAndTurnStartTick = 0x28;
                export const m_bWasOnGroundLastUpdate = 0x1C;
                export const m_staticAimTimerStartTick = 0x24;
                export const m_bWasStationaryLastUpdate = 0x1D;
                export const m_flPreviousHorizontalSpeed = 0x34;
                export const m_flWeaponDropSmoothDampVelocity = 0x44;
                export const m_flWeaponDropPercentageDueToMovement = 0x40;
            }
            export namespace CCSPlayer_RadioServices {
                export const m_bIgnoreRadio = 0x60;
                export const m_flRadioTokenSlots = 0x54;
                export const m_flC4PlantTalkTimer = 0x50;
                export const m_flDefusingTalkTimer = 0x4C;
                export const m_flGotHostageTalkTimer = 0x48;
            }
            export namespace CCSPlayer_WaterServices {
                export const m_nDrownDmgRate = 0x4C;
                export const m_AirFinishedTime = 0x50;
                export const m_flSwimSoundTime = 0x64;
                export const m_flWaterJumpTime = 0x54;
                export const m_vecWaterJumpVel = 0x58;
                export const m_NextDrownDamageTime = 0x48;
            }
            export namespace CChoreo_GraphController {
                export const m_eChoreoState = 0xC0;
                export const m_tChoreoExitWarp = 0xF0;
                export const m_tChoreoTargetWarp = 0xD8;
            }
            export namespace CCommentaryViewPosition {

            }
            export namespace CEnvVolumetricFogVolume {
                export const m_bActive = 0x4A8;
                export const m_vBoxMaxs = 0x4B8;
                export const m_vBoxMins = 0x4AC;
                export const m_TintColor = 0x4E8;
                export const m_flStrength = 0x4C8;
                export const m_nFalloffShape = 0x4CC;
                export const m_bStartDisabled = 0x4C4;
                export const m_fNoiseStrength = 0x4E4;
                export const m_bIndirectUseLPVs = 0x4C5;
                export const m_flHeightFogDepth = 0x4D4;
                export const m_fSunLightStrength = 0x4E0;
                export const m_flFalloffExponent = 0x4D0;
                export const m_bOverrideTintColor = 0x4EC;
                export const m_fHeightFogEdgeWidth = 0x4D8;
                export const m_bOverrideNoiseStrength = 0x4EF;
                export const m_fIndirectLightStrength = 0x4DC;
                export const m_bOverrideSunLightStrength = 0x4EE;
                export const m_bOverrideIndirectLightStrength = 0x4ED;
            }
            export namespace CInfoSpawnGroupLandmark {

            }
            export namespace CLightDirectionalEntity {

            }
            export namespace CLightEnvironmentEntity {

            }
            export namespace CLogicGameEventListener {
                export const m_bEnabled = 0x4E0;
                export const m_OnEventFired = 0x4B8;
                export const m_bStartDisabled = 0x4E1;
                export const m_iszGameEventItem = 0x4D8;
                export const m_iszGameEventName = 0x4D0;
            }
            export namespace CMarkupVolumeTagged_Nav {
                export const m_nScopes = 0x890;
            }
            export namespace CNmEventConsumerContact {

            }
            export namespace CPathMoverEntitySpawner {
                export const m_bEnabled = 0x52C;
                export const m_nSpawnNum = 0x524;
                export const m_hPathMover = 0x4F4;
                export const m_nMaxActive = 0x520;
                export const m_nSpawnIndex = 0x4F0;
                export const m_vMoverSpawnPos = 0x59C;
                export const m_flLastSpawnTime = 0x528;
                export const m_iszPathMoverName = 0x578;
                export const m_szSpawnTemplates = 0x4B0;
                export const m_OnTemplateSpawned = 0x548;
                export const m_vecQueuedRemovals = 0x530;
                export const m_bRunningDebugThink = 0x5A8;
                export const m_bPrepopulateOnSpawn = 0x580;
                export const m_iszPathNodeStartName = 0x588;
                export const m_szSpawnTemplateCount = 0x4E0;
                export const m_szSpawnTemplateParams = 0x4D0;
                export const m_OnTemplateGroupSpawned = 0x560;
                export const m_eTemplateChoiceStrategy = 0x4A8;
                export const m_flSpawnFrequencySeconds = 0x4F8;
                export const m_mapSpawnedMoverTemplates = 0x500;
                export const m_bDestroyMoverOnArrivedAtEnd = 0x52D;
                export const m_flSpawnFrequencyDistToNearestMover = 0x4FC;
            }
            export namespace CPhysicsPropMultiplayer {

            }
            export namespace CPhysicsPropRespawnable {
                export const m_vOriginalMaxs = 0xD34;
                export const m_vOriginalMins = 0xD28;
                export const m_flRespawnDuration = 0xD40;
                export const m_vOriginalSpawnAngles = 0xD1C;
                export const m_vOriginalSpawnOrigin = 0xD10;
            }
            export namespace CPlayer_AutoaimServices {

            }
            export namespace CPulseCell_Inflow_Yield {
                export const m_UnyieldResume = 0xD8;
            }
            export namespace CPulseCell_PlaySequence {
                export const m_OnFinished = 0xF8;
                export const m_SequenceName = 0xD8;
                export const m_PulseAnimEvents = 0xE0;
            }
            export namespace CPulseCell_ReturnValues {

            }
            export namespace CPulseCell_Step_EntFire {
                export const m_Input = 0x48;
            }
            export namespace CSmokeGrenadeProjectile {
                export const m_nRandomSeed = 0xB70;
                export const m_vSmokeColor = 0xB74;
                export const m_flLastBounce = 0xBB4;
                export const m_nVoxelUpdate = 0xBAC;
                export const m_VoxelFrameData = 0xB90;
                export const m_bDidSmokeEffect = 0xB6C;
                export const m_bDidGroundScorch = 0x2E41;
                export const m_bExplodeFromInferno = 0x2E40;
                export const m_nVoxelFrameDataSize = 0xBA8;
                export const m_vSmokeDetonationPos = 0xB80;
                export const m_fllastSimulationTime = 0xBB8;
                export const m_nSmokeEffectTickBegin = 0xB68;
                export const m_nSmokeLightProbeRegen = 0xBB0;
            }
            export namespace CSoundEventSphereEntity {
                export const m_flRadius = 0x568;
            }
            export namespace CSoundOpvarSetBoxEntity {
                export const m_vInnerMaxs = 0x680;
                export const m_vInnerMins = 0x674;
                export const m_vOuterMaxs = 0x698;
                export const m_vOuterMins = 0x68C;
                export const m_nBoxDirection = 0x670;
                export const m_vDistanceInnerMaxs = 0x64C;
                export const m_vDistanceInnerMins = 0x640;
                export const m_vDistanceOuterMaxs = 0x664;
                export const m_vDistanceOuterMins = 0x658;
            }
            export namespace CSoundOpvarSetOBBEntity {

            }
            export namespace CSoundOpvarSetPointBase {
                export const m_hSource = 0x4AC;
                export const m_bDisabled = 0x4A8;
                export const m_iOpvarIndex = 0x548;
                export const m_bFastRefresh = 0x54D;
                export const m_iszOpvarName = 0x540;
                export const m_iszStackName = 0x530;
                export const m_flRefreshTime = 0x52C;
                export const m_vLastPosition = 0x520;
                export const m_bUseAutoCompare = 0x54C;
                export const m_iszOperatorName = 0x538;
                export const m_iszSourceEntityName = 0x4C8;
            }
            export namespace CTextureBasedAnimatable {
                export const m_bLoop = 0x850;
                export const m_flFPS = 0x854;
                export const m_flStartTime = 0x880;
                export const m_flStartFrame = 0x884;
                export const m_hPositionKeys = 0x858;
                export const m_hRotationKeys = 0x860;
                export const m_vAnimationBoundsMax = 0x874;
                export const m_vAnimationBoundsMin = 0x868;
            }
            export namespace CTriggerDetectExplosion {
                export const m_OnDetectedExplosion = 0x9F0;
            }
            export namespace EntityRenderAttribute_t {
                export const m_ID = 0x30;
                export const m_Values = 0x34;
            }
            export namespace RagdollCreationParams_t {
                export const m_vForce = 0x0;
                export const m_nForceBone = 0xC;
                export const m_nHealthToGrant = 0x14;
                export const m_bForceCurrentWorldTransform = 0x10;
            }
            export namespace SellbackPurchaseEntry_t {
                export const m_hItem = 0x40;
                export const m_nCost = 0x34;
                export const m_unDefIdx = 0x30;
                export const m_nPrevArmor = 0x38;
                export const m_bPrevHelmet = 0x3C;
            }
            export namespace SignatureOutflow_Resume {

            }
            export namespace SoundOpvarTraceResult_t {
                export const vPos = 0x0;
                export const bDidHit = 0xC;
                export const flDistSqrToCenter = 0x10;
            }
            export namespace SummaryTakeDamageInfo_t {
                export const info = 0x8;
                export const result = 0x120;
                export const hTarget = 0x180;
                export const nSummarisedCount = 0x0;
            }
            export namespace ViewAngleServerChange_t {
                export const nType = 0x30;
                export const nIndex = 0x40;
                export const qAngle = 0x34;
            }
            export namespace WeaponPurchaseTracker_t {
                export const m_weaponPurchases = 0x8;
            }
            export namespace ragdollhierarchyjoint_t {
                export const childIndex = 0x4;
                export const parentIndex = 0x0;
            }
            export namespace CAnimGraphControllerBase {
                export const m_hExternalGraph = 0x4C;
            }
            export namespace CBaseAnimGraphController {
                export const m_hSequence = 0x5C;
                export const m_nNotifyState = 0x78;
                export const m_nAnimLoopMode = 0x68;
                export const m_flPlaybackRate = 0x6C;
                export const m_flSeqStartTime = 0x60;
                export const m_primaryGraphId = 0x3C8;
                export const m_flSeqFixedCycle = 0x64;
                export const m_flSoundSyncTime = 0x54;
                export const m_bSequenceFinished = 0x7C;
                export const m_pGraphInstanceAG2 = 0x408;
                export const m_vecExternalGraphs = 0x628;
                export const m_bLastUpdateSkipped = 0x7B;
                export const m_nActiveIKChainMask = 0x58;
                export const m_vecExternalClipIds = 0x3E8;
                export const m_hGraphDefinitionAG2 = 0x320;
                export const m_nAnimationAlgorithm = 0x18;
                export const m_nPrevAnimUpdateTick = 0x80;
                export const m_vecExternalGraphIds = 0x3D0;
                export const m_sAnimGraph2Identifier = 0x400;
                export const m_vecSecondarySkeletons = 0x38;
                export const m_nNextExternalGraphHandle = 0x1C;
                export const m_bNetworkedSequenceChanged = 0x7A;
                export const m_SerializePoseRecipeAG2Slots = 0x328;
                export const m_vecSecondarySkeletonSlotIDs = 0x20;
                export const m_SerializePoseRecipeAG2Dynamic = 0x390;
                export const m_nSecondarySkeletonMasterCount = 0x50;
                export const m_nServerGraphInstanceIteration = 0x3C0;
                export const m_nSerializePoseRecipeVersionAG2 = 0x3AC;
                export const m_bNetworkedAnimationInputsChanged = 0x79;
                export const m_nSerializePoseRecipeAG2ActiveSlot = 0x3A8;
                export const m_nServerSerializationContextIteration = 0x3C4;
            }
            export namespace CBaseCSGrenadeProjectile {
                export const m_nBounces = 0xAE8;
                export const m_nItemIndex = 0xB0E;
                export const m_flSpawnTime = 0xB08;
                export const m_vecGrenadeSpin = 0xB20;
                export const m_unOGSExtraFlags = 0xB0C;
                export const m_bHasEverHitEnemy = 0xB3C;
                export const m_vInitialPosition = 0xAD0;
                export const m_vInitialVelocity = 0xADC;
                export const m_bDetonationRecorded = 0xB0D;
                export const m_nExplodeEffectIndex = 0xAF0;
                export const m_nTicksAtZeroVelocity = 0xB38;
                export const m_flLastBounceSoundTime = 0xB1C;
                export const m_vecExplodeEffectOrigin = 0xAFC;
                export const m_nExplodeEffectTickBegin = 0xAF8;
                export const m_vecLastHitSurfaceNormal = 0xB2C;
                export const m_vecOriginalSpawnLocation = 0xB10;
            }
            export namespace CBtNodeConditionInactive {
                export const m_SensorInactivityTimer = 0x80;
                export const m_flRoundStartThresholdSeconds = 0x78;
                export const m_flSensorInactivityThresholdSeconds = 0x7C;
            }
            export namespace CCSPlayer_BulletServices {
                export const m_totalHitsOnServer = 0x48;
            }
            export namespace CCSPlayer_CameraServices {

            }
            export namespace CCSPlayer_WeaponServices {
                export const m_flNextAttack = 0xC0;
                export const m_hSavedWeapon = 0xC4;
                export const m_nTimeToMelee = 0xC8;
                export const m_nTimeToPrimary = 0xD0;
                export const m_bPickedUpWeapon = 0xDA;
                export const m_nTimeToSecondary = 0xCC;
                export const m_bIsBeingGivenItem = 0xD8;
                export const m_networkAnimTiming = 0x1898;
                export const m_bDisableAutoDeploy = 0xDB;
                export const m_nTimeToSniperRifle = 0xD4;
                export const m_bIsPickingUpItemWithUse = 0xD9;
                export const m_bIsPickingUpGroundWeapon = 0xDC;
                export const m_bBlockInspectUntilNextGraphUpdate = 0x18B0;
            }
            export namespace CCitadelSoundOpvarSetOBB {
                export const m_iszOpvarName = 0x4B8;
                export const m_iszStackName = 0x4A8;
                export const m_nAABBDirection = 0x4F0;
                export const m_iszOperatorName = 0x4B0;
                export const m_vDistanceInnerMaxs = 0x4CC;
                export const m_vDistanceInnerMins = 0x4C0;
                export const m_vDistanceOuterMaxs = 0x4E4;
                export const m_vDistanceOuterMins = 0x4D8;
            }
            export namespace CConstantForceController {
                export const m_linear = 0xC;
                export const m_angular = 0x18;
                export const m_linearSave = 0x24;
                export const m_angularSave = 0x30;
            }
            export namespace CEntitySubclassVDataBase {

            }
            export namespace CGenericLogicPlayerProxy {

            }
            export namespace CInfoTeleportDestination {

            }
            export namespace CNavVolumeSphericalShell {
                export const m_flRadiusInner = 0x88;
            }
            export namespace CNetworkViewOffsetVector {
                export const m_vecX = 0x10;
                export const m_vecY = 0x18;
                export const m_vecZ = 0x20;
            }
            export namespace CNmEventConsumerParticle {

            }
            export namespace CPlayer_MovementServices {
                export const m_flUpMove = 0x1C8;
                export const m_nButtons = 0x50;
                export const m_nImpulse = 0x48;
                export const m_flLeftMove = 0x1C4;
                export const m_flMaxspeed = 0x1AC;
                export const m_flCmdUpMove = 0x1A8;
                export const m_flCmdLeftMove = 0x1A4;
                export const m_flForwardMove = 0x1C0;
                export const m_flCmdForwardMove = 0x1A0;
                export const m_vecOldViewAngles = 0x240;
                export const m_nButtonDoublePressed = 0x80;
                export const m_nQueuedButtonDownMask = 0x70;
                export const m_nToggleButtonDownMask = 0x190;
                export const m_arrForceSubtickMoveWhen = 0x1B0;
                export const m_nQueuedButtonChangeMask = 0x78;
                export const m_pButtonPressedCmdNumber = 0x88;
                export const m_vecLastMovementImpulses = 0x1CC;
                export const m_nLastCommandNumberProcessed = 0x188;
            }
            export namespace CPlayer_ObserverServices {
                export const m_iObserverMode = 0x48;
                export const m_hObserverTarget = 0x4C;
                export const m_iObserverLastMode = 0x50;
                export const m_bForcedObserverMode = 0x54;
            }
            export namespace CPointClientUIWorldPanel {
                export const m_bLit = 0x9B1;
                export const m_flDPI = 0x9BC;
                export const m_bOpaque = 0x9F8;
                export const m_flWidth = 0x9B4;
                export const m_bNoDepth = 0x9F9;
                export const m_flHeight = 0x9B8;
                export const m_bGrabbable = 0x9FE;
                export const m_bIgnoreInput = 0x9B0;
                export const m_flDepthOffset = 0x9C8;
                export const m_unOrientation = 0x9D8;
                export const m_vecCSSClasses = 0x9E0;
                export const m_bDisableMipGen = 0xA00;
                export const m_unOwnerContext = 0x9CC;
                export const m_bRenderBackface = 0x9FB;
                export const m_flWindowUIScale = 0x9C0;
                export const m_unVerticalAlign = 0x9D4;
                export const m_unHorizontalAlign = 0x9D0;
                export const m_flInteractDistance = 0x9C4;
                export const m_bOnlyRenderToTexture = 0x9FF;
                export const m_nExplicitImageLayout = 0xA04;
                export const m_bExcludeFromSaveGames = 0x9FD;
                export const m_bUseOffScreenIndicator = 0x9FC;
                export const m_bIgnoreParentOrientation = 0xA08;
                export const m_bVisibleWhenParentNoDraw = 0x9FA;
                export const m_bFollowPlayerAcrossTeleport = 0x9B2;
                export const m_bAllowInteractionFromAllSceneWorlds = 0x9DC;
            }
            export namespace CPulseCell_Inflow_Method {
                export const m_Args = 0xA0;
                export const m_bIsPublic = 0x98;
                export const m_MethodName = 0x80;
                export const m_Description = 0x90;
                export const m_ReturnValues = 0xB0;
            }
            export namespace CPulseCell_IntervalTimer {
                export const m_Completed = 0xD8;
                export const m_OnInterval = 0x120;
            }
            export namespace CPulseCell_Step_DebugLog {

            }
            export namespace CPulse_OutflowConnection {
                export const m_nDestChunk = 0x10;
                export const m_nInstruction = 0x14;
                export const m_SourceOutflowName = 0x0;
                export const m_OutflowRegisterMap = 0x18;
            }
            export namespace CSAdditionalMatchStats_t {
                export const m_flTeamDamage = 0x13C;
                export const m_iNumSuicides = 0x134;
                export const m_iNumTeamKills = 0x138;
                export const m_numFirstKills = 0x124;
                export const m_numClutchKills = 0x128;
                export const m_numPistolKills = 0x12C;
                export const m_numSniperKills = 0x130;
                export const m_numRoundsSurvivedTotal = 0x118;
                export const m_numRoundsSurvivedStreak = 0x110;
                export const m_iRoundsWonWithoutPurchase = 0x11C;
                export const m_maxNumRoundsSurvivedStreak = 0x114;
                export const m_iRoundsWonWithoutPurchaseTotal = 0x120;
            }
            export namespace CSoundOpvarSetAABBEntity {

            }
            export namespace CSoundOpvarSetDomeEntity {
                export const m_flSize = 0x734;
                export const m_bDomeMode = 0x740;
                export const m_nClusterK = 0x748;
                export const m_arOpenness = 0x658;
                export const m_bMultiWall = 0x741;
                export const m_flClusterP = 0x74C;
                export const m_arNeighbors = 0x670;
                export const m_arDirections = 0x640;
                export const m_arClusterSize = 0x6A8;
                export const m_nClusterIndex = 0x6F0;
                export const m_nCurrentIndex = 0x688;
                export const m_flClusterBlend = 0x750;
                export const m_arClusterDirSum = 0x6D8;
                export const m_arClusterParent = 0x690;
                export const m_arClusterWeight = 0x6C0;
                export const m_nTracesPerFrame = 0x73C;
                export const m_flLastSmoothTime = 0x730;
                export const m_flSmoothHalfLife = 0x75C;
                export const m_nTotalDirections = 0x738;
                export const m_vLastTraceOrigin = 0x714;
                export const m_vSmoothedOpenDir = 0x704;
                export const m_bTraceOriginValid = 0x720;
                export const m_vClusterDirection = 0x6F8;
                export const m_flOpennessExponent = 0x754;
                export const m_flShoulderExponent = 0x758;
                export const m_flSmoothedOpenness = 0x72C;
                export const m_flWallTransmission = 0x744;
                export const m_flClusteredOpenness = 0x6F4;
                export const m_bDiscontinuityPending = 0x728;
                export const m_nCatchUpThinksRemaining = 0x724;
                export const m_nDirWarmupThinksRemaining = 0x710;
            }
            export namespace CTouchExpansionComponent {

            }
            export namespace CTriggerDetectBulletFire {
                export const m_bPlayerFireOnly = 0x9C8;
                export const m_OnDetectedBulletFire = 0x9D0;
            }
            export namespace CAI_ExpresserWithFollowup {

            }
            export namespace CCS2WeaponGraphController {
                export const m_action = 0xC0;
                export const m_attackType = 0x210;
                export const m_weaponType = 0x120;
                export const m_reloadStage = 0x288;
                export const m_bActionReset = 0xD8;
                export const m_flWeaponAmmo = 0x150;
                export const m_idleVariation = 0x1E0;
                export const m_weaponCategory = 0x108;
                export const m_deployVariation = 0x1F8;
                export const m_flWeaponAmmoMax = 0x168;
                export const m_weaponExtraInfo = 0x138;
                export const m_inspectExtraInfo = 0x270;
                export const m_inspectVariation = 0x258;
                export const m_bWeaponIsSilenced = 0x198;
                export const m_flAttackVariation = 0x240;
                export const m_attackThrowStrength = 0x228;
                export const m_bIsUsingLegacyModel = 0x1C8;
                export const m_flWeaponAmmoReserve = 0x180;
                export const m_flWeaponIronsightAmount = 0x1B0;
                export const m_flWeaponActionSpeedScale = 0xF0;
            }
            export namespace CCSGO_EndOfMatchLineupEnd {

            }
            export namespace CCSGameModeRules_ArmsRace {
                export const m_WeaponSequence = 0x30;
            }
            export namespace CCSPlayer_HostageServices {
                export const m_hCarriedHostage = 0x48;
                export const m_hCarriedHostageProp = 0x4C;
            }
            export namespace CEnvSoundscapeTriggerable {

            }
            export namespace CFuncInteractionLayerClip {
                export const m_bDisabled = 0x850;
                export const m_iszInteractsAs = 0x858;
                export const m_iszInteractsWith = 0x860;
            }
            export namespace CInfoChoreoAnchorPosition {
                export const m_hParent = 0x40;
                export const m_flRadius = 0x38;
                export const m_qAnglesLS = 0x10;
                export const m_vOriginLS = 0x0;
                export const m_nShapeType = 0x44;
                export const m_vExtentsMax = 0x2C;
                export const m_vExtentsMin = 0x20;
                export const m_bOnlyWarpPosition = 0x3C;
            }
            export namespace CInfoDynamicShadowHintBox {
                export const m_vBoxMaxs = 0x4CC;
                export const m_vBoxMins = 0x4C0;
            }
            export namespace CInfoInstructorHintTarget {

            }
            export namespace CInfoSpawnGroupLoadUnload {
                export const m_bAutoActivate = 0x52C;
                export const m_iszLandmarkName = 0x518;
                export const m_bUnloadingStarted = 0x52D;
                export const m_flTimeoutInterval = 0x528;
                export const m_iszSpawnGroupName = 0x508;
                export const m_bQueueFinishLoading = 0x52F;
                export const m_sFixedSpawnGroupName = 0x520;
                export const m_OnSpawnGroupLoadStarted = 0x4A8;
                export const m_iszSpawnGroupFilterName = 0x510;
                export const m_OnSpawnGroupLoadFinished = 0x4C0;
                export const m_OnSpawnGroupUnloadStarted = 0x4D8;
                export const m_OnSpawnGroupUnloadFinished = 0x4F0;
                export const m_bQueueActiveSpawnGroupChange = 0x52E;
            }
            export namespace CItemGenericTriggerHelper {
                export const m_hParentItem = 0x850;
            }
            export namespace CNetworkTransmitComponent {
                export const m_nTransmitStateOwnedCounter = 0x184;
            }
            export namespace CNmAimCSNode__CDefinition {
                export const m_nIsDefusingNodeIdx = 0x24;
                export const m_nWeaponDropNodeIdx = 0x22;
                export const m_nWeaponTypeNodeIdx = 0x1E;
                export const m_nCrouchWeightNodeIdx = 0x26;
                export const m_nWeaponActionNodeIdx = 0x20;
                export const m_nVerticalAngleNodeIdx = 0x18;
                export const m_nWeaponCategoryNodeIdx = 0x1C;
                export const m_nHorizontalAngleNodeIdx = 0x1A;
                export const m_flActionBlendTimeSeconds = 0x2C;
                export const m_flHandIKBlendInTimeSeconds = 0x28;
                export const m_flPlantingBlendTimeSeconds = 0x30;
            }
            export namespace CNmEventConsumerBodyGroup {

            }
            export namespace CPulseCell_Value_Gradient {
                export const m_Gradient = 0x48;
            }
            export namespace CShatterGlassShardPhysics {
                export const m_ShardDesc = 0x858;
                export const m_nPoolState = 0x8D8;
                export const m_hParentShard = 0x850;
                export const m_bTouchedByPlayer = 0x8DC;
            }
            export namespace CSimpleMarkupVolumeTagged {

            }
            export namespace CSoundOpvarSetPointEntity {
                export const m_OnExit = 0x568;
                export const m_OnEnter = 0x550;
                export const m_bReloading = 0x5E5;
                export const m_bAutoDisable = 0x580;
                export const m_flDistanceMax = 0x5C8;
                export const m_flDistanceMin = 0x5C4;
                export const m_flOcclusionMax = 0x5DC;
                export const m_flOcclusionMin = 0x5D8;
                export const m_hDynamicEntity = 0x600;
                export const m_nSimulationMode = 0x5E8;
                export const m_flDistanceMapMax = 0x5D0;
                export const m_flDistanceMapMin = 0x5CC;
                export const m_flOcclusionRadius = 0x5D4;
                export const m_flValSetOnDisable = 0x5E0;
                export const m_vPathingDirection = 0x62C;
                export const m_vPathingSourcePos = 0x614;
                export const m_bSetValueOnDisable = 0x5E4;
                export const m_nVisibilitySamples = 0x5EC;
                export const m_vDynamicProxyPoint = 0x5F0;
                export const m_nPathingSourceIndex = 0x638;
                export const m_vPathingListenerPos = 0x620;
                export const m_iszDynamicEntityName = 0x608;
                export const m_flDynamicMaximumOcclusion = 0x5FC;
                export const m_flPathingDistanceNormFactor = 0x610;
            }
            export namespace DebugDrawBoneTransforms_t {
                export const vecBones = 0x10;
            }
            export namespace ExternalAnimGraphHandle_t {
                export const m_Value = 0x0;
            }
            export namespace OutflowWithRequirements_t {
                export const m_Connection = 0x0;
                export const m_RequirementNodeIDs = 0x50;
                export const m_DestinationFlowNodeID = 0x48;
                export const m_nCursorStateBlockIndex = 0x68;
            }
            export namespace SignatureOutflow_Continue {

            }
            export namespace WaterWheelFrictionScale_t {
                export const m_flFrictionScale = 0x4;
                export const m_flFractionOfWheelSubmerged = 0x0;
            }
            export namespace CBtActionCombatPositioning {
                export const m_bCrouching = 0xA0;
                export const m_ActionTimer = 0x88;
                export const m_szIsAttackingKey = 0x80;
                export const m_szSensorInputKey = 0x68;
            }
            export namespace CCS2ChickenGraphController {
                export const m_mode = 0x128;
                export const m_action = 0xC0;
                export const m_bFlinch = 0x1B8;
                export const m_bInWater = 0x110;
                export const m_idlePhase = 0x158;
                export const m_lifeStage = 0x140;
                export const m_turnAngle = 0x170;
                export const m_bActionReset = 0xD8;
                export const m_lookatTarget = 0x1A0;
                export const m_actionVariation = 0xF8;
                export const m_flinchVariation = 0x1D0;
                export const m_bHasLookatTarget = 0x188;
                export const m_bHasActionCompletedEvent = 0x1E8;
            }
            export namespace CCSObserver_CameraServices {

            }
            export namespace CCSPlayer_AimPunchServices {
                export const m_predictableBaseTick = 0x48;
                export const m_predictableBaseAngle = 0x50;
                export const m_unpredictableBaseTick = 0xA0;
                export const m_unpredictableBaseAngle = 0xA4;
                export const m_predictableBaseAngleVel = 0x5C;
                export const m_predictableBaseTickInterpAmount = 0x4C;
            }
            export namespace CCSPlayer_MovementServices {
                export const m_vecUp = 0x674;
                export const m_bDucked = 0x408;
                export const m_vecLeft = 0x668;
                export const m_bDucking = 0x416;
                export const m_StuckLast = 0x64C;
                export const m_flStamina = 0x69C;
                export const m_LegacyJump = 0x6B8;
                export const m_ModernJump = 0x6D0;
                export const m_iFootsteps = 0x688;
                export const m_vecForward = 0x65C;
                export const m_flDuckSpeed = 0x410;
                export const m_nTraceCount = 0x648;
                export const m_bDesiresDuck = 0x415;
                export const m_bInStuckTest = 0x43A;
                export const m_flDuckAmount = 0x40C;
                export const m_bDuckOverride = 0x414;
                export const m_bSpeedCropped = 0x650;
                export const m_nLastJumpTick = 0x708;
                export const m_AnimationState = 0x310;
                export const m_flLastDuckTime = 0x420;
                export const m_flLastJumpFrac = 0x70C;
                export const m_nOldWaterLevel = 0x654;
                export const m_vecWalkWishVel = 0x7A8;
                export const m_vecLadderNormal = 0x3F8;
                export const m_bJumpApexPending = 0x714;
                export const m_flDuckRootOffset = 0x418;
                export const m_flDuckViewOffset = 0x41C;
                export const m_flWaterEntryTime = 0x658;
                export const m_duckUntilOnGround = 0x438;
                export const m_bMadeFootstepNoise = 0x684;
                export const m_flHeightAtJumpStart = 0x6A0;
                export const m_flLastJumpVelocityZ = 0x710;
                export const m_flVelMulAtJumpStart = 0x6B0;
                export const m_flStaminaAtJumpStart = 0x6AC;
                export const m_flBombPlantViewOffset = 0x424;
                export const m_flAccumulatedJumpError = 0x6B4;
                export const m_flFrictionStashedSpeed = 0x698;
                export const m_flMaxJumpHeightLastJump = 0x6A8;
                export const m_flMaxJumpHeightThisJump = 0x6A4;
                export const m_nLadderSurfacePropIndex = 0x404;
                export const m_bHasEverProcessedCommand = 0xFD0;
                export const m_bUseFrictionStashedSpeed = 0x690;
                export const m_bHasWalkMovedSinceLastJump = 0x439;
                export const m_bUsingGroundTopologyOffset = 0x3F0;
                export const m_fStashGrenadeParameterWhen = 0x68C;
                export const m_flTicksSinceLastSurfingDetected = 0x718;
                export const m_vecLastPositionAtFullCrouchSpeed = 0x430;
                export const m_flUseFrictionStashedSpeedUntilFrac = 0x694;
                export const m_nGameCodeHasMovedPlayerAfterCommand = 0x680;
                export const m_flUsingGroundTopologyOffsetTransitionSmoothing = 0x3F4;
            }
            export namespace CNavVolumeCalculatedVector {

            }
            export namespace CNmEventConsumerAttributes {

            }
            export namespace CPhysicsBodyGameMarkupData {
                export const m_PhysicsBodyMarkupByBoneName = 0x0;
            }
            export namespace CPlayerControllerComponent {
                export const __m_pChainEntity = 0x8;
            }
            export namespace CPlayer_FlashlightServices {

            }
            export namespace CPropDoorRotatingBreakable {
                export const m_bBreakable = 0xF30;
                export const m_damageStates = 0xF38;
                export const m_currentDamageState = 0xF34;
                export const m_isAbleToCloseAreaPortals = 0xF31;
            }
            export namespace CPulseCell_BaseRequirement {

            }
            export namespace CPulseCell_Outflow_PlayVCD {
                export const m_OnPaused = 0x140;
                export const m_OnResumed = 0x188;
                export const m_hChoreoScene = 0x138;
                export const m_OutRequirements = 0x1D0;
            }
            export namespace CPulseCell_SoundEventStart {
                export const m_Type = 0x48;
            }
            export namespace CPulseCell_Value_RandomInt {

            }
            export namespace CPulse_BlackboardReference {
                export const m_nNodeID = 0x18;
                export const m_NodeName = 0x20;
                export const m_BlackboardResource = 0x8;
                export const m_hBlackboardResource = 0x0;
            }
            export namespace CScriptUniformRandomStream {
                export const m_hScriptScope = 0x8;
                export const m_nInitialSeed = 0x9C;
            }
            export namespace CTriggerActiveWeaponDetect {
                export const m_iszWeaponClassName = 0x9E0;
                export const m_OnTouchedActiveWeapon = 0x9C8;
            }
            export namespace FuncMoverMovementSummary_t {
                export const nTick = 0x18;
                export const flEndT = 0x4;
                export const nFlags = 0x14;
                export const flStartT = 0x0;
                export const hPathMover = 0x1C;
                export const nMovementMode = 0x10;
                export const nStopNodeIndex = 0xC;
                export const nStartNodeIndex = 0x8;
            }
            export namespace PulseNodeDynamicOutflows_t {
                export const m_Outflows = 0x0;
            }
            export namespace PulseSelectorOutflowList_t {
                export const m_Outflows = 0x0;
            }
            export namespace CAnimGraphControllerManager {
                export const m_controllers = 0x0;
                export const m_bGraphBindingsCreated = 0x90;
            }
            export namespace CBodyComponentBaseAnimGraph {
                export const m_animationController = 0x4E0;
            }
            export namespace CCSGO_EndOfMatchLineupStart {

            }
            export namespace CCSGameModeRules_Deathmatch {
                export const m_sDMBonusWeapon = 0x38;
                export const m_flDMBonusStartTime = 0x30;
                export const m_flDMBonusTimeLength = 0x34;
            }
            export namespace CDestructiblePartsComponent {
                export const m_hOwner = 0x60;
                export const __m_pChainEntity = 0x0;
                export const m_vecDamageTakenByHitGroup = 0x48;
                export const m_pAnimGraphDestructibleGraphController = 0x68;
            }
            export namespace CDynamicPropGraphController {
                export const m_sActionState = 0xC0;
            }
            export namespace CEnvVolumetricFogController {
                export const m_bActive = 0x4F4;
                export const m_vBoxMaxs = 0x4E8;
                export const m_vBoxMins = 0x4DC;
                export const m_TintColor = 0x4AC;
                export const m_bIsMaster = 0x51E;
                export const m_bFirstTime = 0x550;
                export const m_fWindSpeed = 0x540;
                export const m_fNoiseSpeed = 0x52C;
                export const m_flFadeInEnd = 0x4C0;
                export const m_flFadeSpeed = 0x4B4;
                export const m_vNoiseScale = 0x534;
                export const m_flAnisotropy = 0x4B0;
                export const m_flScattering = 0x4A8;
                export const m_nVolumeDepth = 0x4C8;
                export const m_flFadeInStart = 0x4BC;
                export const m_bStartDisabled = 0x51C;
                export const m_fNoiseStrength = 0x530;
                export const m_flDrawDistance = 0x4B8;
                export const m_vWindDirection = 0x544;
                export const m_bEnableIndirect = 0x51D;
                export const m_flStartAnisoTime = 0x4F8;
                export const m_flStartAnisotropy = 0x504;
                export const m_flStartScattering = 0x508;
                export const m_flIndirectStrength = 0x4C4;
                export const m_flStartScatterTime = 0x4FC;
                export const m_nForceRefreshCount = 0x528;
                export const m_flDefaultAnisotropy = 0x510;
                export const m_flDefaultScattering = 0x514;
                export const m_flStartDrawDistance = 0x50C;
                export const m_hFogIndirectTexture = 0x520;
                export const m_nIndirectTextureDimX = 0x4D0;
                export const m_nIndirectTextureDimY = 0x4D4;
                export const m_nIndirectTextureDimZ = 0x4D8;
                export const m_flDefaultDrawDistance = 0x518;
                export const m_flStartDrawDistanceTime = 0x500;
                export const m_fFirstVolumeSliceThickness = 0x4CC;
            }
            export namespace CInfoPlayerCounterterrorist {

            }
            export namespace CMarkupVolumeTagged_NavGame {
                export const m_nScopes = 0x8B8;
                export const m_bSplitNavSpace = 0x8BA;
                export const m_bFloodFillAttribute = 0x8B9;
            }
            export namespace CNetworkedSequenceOperation {
                export const m_flCycle = 0x10;
                export const m_flWeight = 0x14;
                export const m_hSequence = 0x8;
                export const m_flPrevCycle = 0xC;
                export const m_bDiscontinuity = 0x1D;
                export const m_bSequenceChangeNetworked = 0x1C;
                export const m_flPrevCycleFromDiscontinuity = 0x20;
                export const m_flPrevCycleForAnimEventDetection = 0x24;
            }
            export namespace CPointAngularVelocitySensor {
                export const m_vecAxis = 0x4D0;
                export const m_OnEqualTo = 0x560;
                export const m_OnLessThan = 0x500;
                export const m_bUseHelper = 0x4DC;
                export const m_flFireTime = 0x4B8;
                export const m_flThreshold = 0x4AC;
                export const m_OnGreaterThan = 0x530;
                export const m_hTargetEntity = 0x4A8;
                export const m_flFireInterval = 0x4BC;
                export const m_AngularVelocity = 0x4E0;
                export const m_lastOrientation = 0x4C4;
                export const m_nLastFireResult = 0x4B4;
                export const m_flLastAngVelocity = 0x4C0;
                export const m_nLastCompareResult = 0x4B0;
                export const m_OnLessThanOrEqualTo = 0x518;
                export const m_OnGreaterThanOrEqualTo = 0x548;
            }
            export namespace CPulseCell_ApplyEntityFlags {

            }
            export namespace CPulseCell_Inflow_GraphHook {
                export const m_HookName = 0x80;
            }
            export namespace CSAdditionalPerRoundStats_t {
                export const m_iDinks = 0x14;
                export const m_nDefuseStarts = 0x1C;
                export const m_killsWhileBlind = 0x4;
                export const m_nHostagePickUps = 0x20;
                export const m_bombCarrierkills = 0x8;
                export const m_numChickensKilled = 0x0;
                export const m_numTeammatesFlashed = 0x24;
                export const m_bBombPlantedAndAlive = 0x19;
                export const m_bFreshStartThisRound = 0x18;
                export const m_flBurnDamageInflicted = 0xC;
                export const m_flBlastDamageInflicted = 0x10;
                export const m_strAnnotationsWorkshopId = 0x28;
            }
            export namespace CSoundAreaEntityOrientedBox {
                export const m_vMax = 0x4D4;
                export const m_vMin = 0x4C8;
            }
            export namespace CSoundEventMultiPointEntity {
                export const m_bPlaying = 0x578;
                export const m_iCountMax = 0x568;
                export const m_flDistMaxSqr = 0x570;
                export const m_flDistanceMax = 0x56C;
                export const m_flDotProductMax = 0x574;
            }
            export namespace CSoundEventPathCornerEntity {
                export const m_iszPathCorner = 0x5A0;
                export const m_vecCornerPairsNetworked = 0x5C0;
            }
            export namespace CSoundOpvarSetOBBWindEntity {
                export const m_vMaxs = 0x55C;
                export const m_vMins = 0x550;
                export const m_flWindMax = 0x584;
                export const m_flWindMin = 0x580;
                export const m_flWindMapMax = 0x58C;
                export const m_flWindMapMin = 0x588;
                export const m_vDistanceMaxs = 0x574;
                export const m_vDistanceMins = 0x568;
            }
            export namespace PulseScriptedSequenceData_t {
                export const m_nMoveTo = 0x28;
                export const m_nActorID = 0x0;
                export const m_szSequence = 0x18;
                export const m_nMoveToGait = 0x2C;
                export const m_bIgnoreLookAt = 0x37;
                export const m_szExitSequence = 0x20;
                export const m_szEntrySequence = 0x10;
                export const m_szPreIdleSequence = 0x8;
                export const m_bLoopActionSequence = 0x35;
                export const m_nHeldWeaponBehavior = 0x30;
                export const m_bLoopPreIdleSequence = 0x34;
                export const m_bLoopPostIdleSequence = 0x36;
            }
            export namespace CCSObserver_MovementServices {

            }
            export namespace CCSObserver_ObserverServices {

            }
            export namespace CCSPlayerBase_CameraServices {
                export const m_iFOV = 0x178;
                export const m_flFOVRate = 0x184;
                export const m_flFOVTime = 0x180;
                export const m_iFOVStart = 0x17C;
                export const m_hZoomOwner = 0x188;
                export const m_hLastFogTrigger = 0x1A8;
                export const m_hTriggerFogList = 0x190;
            }
            export namespace CDestructiblePartsSystemData {
                export const m_PartsDataByHitGroup = 0x0;
                export const m_nMinMaxNumberHitGroupsToDestroyWhenGibbing = 0x28;
            }
            export namespace CDynamicNavConnectionsVolume {
                export const m_vecConnections = 0x9E8;
                export const m_sTransitionType = 0xA00;
                export const m_flUpdateDistance = 0xA10;
                export const m_bConnectionsEnabled = 0xA08;
                export const m_iszConnectionTarget = 0x9E0;
                export const m_flMaxConnectionDistance = 0xA14;
                export const m_flTargetAreaSearchRadius = 0xA0C;
            }
            export namespace CEnvCombinedLightProbeVolume {
                export const m_Entity_Color = 0x5C0;
                export const m_Entity_bEnabled = 0x679;
                export const m_Entity_vBoxMaxs = 0x61C;
                export const m_Entity_vBoxMins = 0x610;
                export const m_Entity_bMoveable = 0x628;
                export const m_Entity_nPriority = 0x634;
                export const m_Entity_nHandshake = 0x62C;
                export const m_Entity_flBrightness = 0x5C4;
                export const m_Entity_bStartDisabled = 0x638;
                export const m_Entity_flEdgeFadeDist = 0x63C;
                export const m_Entity_vEdgeFadeDists = 0x640;
                export const m_Entity_hCubemapTexture = 0x5C8;
                export const m_Entity_nLightProbeSizeX = 0x64C;
                export const m_Entity_nLightProbeSizeY = 0x650;
                export const m_Entity_nLightProbeSizeZ = 0x654;
                export const m_Entity_nLightProbeAtlasX = 0x658;
                export const m_Entity_nLightProbeAtlasY = 0x65C;
                export const m_Entity_nLightProbeAtlasZ = 0x660;
                export const m_Entity_bCustomCubemapTexture = 0x5D0;
                export const m_Entity_nEnvCubeMapArrayIndex = 0x630;
                export const m_Entity_hLightProbeTexture_SDF = 0x5E0;
                export const m_Entity_hLightProbeTexture_SH2_DC = 0x5E8;
                export const m_Entity_hLightProbeTexture_SH2_L1 = 0x5F0;
                export const m_Entity_hLightProbeTexture_AmbientCube = 0x5D8;
                export const m_Entity_hLightProbeDirectLightIndicesTexture = 0x5F8;
                export const m_Entity_hLightProbeDirectLightScalarsTexture = 0x600;
                export const m_Entity_hLightProbeDirectLightShadowsTexture = 0x608;
            }
            export namespace CNavVolumeBreadthFirstSearch {
                export const m_vStartPos = 0xA8;
                export const m_flSearchDist = 0xB4;
            }
            export namespace CPointBroadcastClientCommand {

            }
            export namespace CPointClientUIWorldTextPanel {
                export const m_messageText = 0xA10;
            }
            export namespace CPulseCell_Step_FollowEntity {
                export const m_ParamBoneOrAttachName = 0x48;
                export const m_ParamBoneOrAttachNameChild = 0x50;
            }
            export namespace CPulseCell_Step_PublicOutput {
                export const m_OutputIndex = 0x48;
            }
            export namespace CPulseCell_Value_RandomFloat {

            }
            export namespace CPulseCell_WaitForObservable {
                export const m_OnTrue = 0x168;
                export const m_Condition = 0xD8;
            }
            export namespace CRopeKeyframeAlias_move_rope {

            }
            export namespace CSkeletonAnimationController {
                export const m_pSkeletonInstance = 0x8;
            }
            export namespace CSoundOpvarSetAutoRoomEntity {
                export const m_flSize = 0x670;
                export const m_flSizeSqr = 0x678;
                export const m_doorwayPairs = 0x658;
                export const m_traceResults = 0x640;
                export const m_flHeightTolerance = 0x674;
            }
            export namespace CTakeDamageSummaryScopeGuard {
                export const m_vecSummaries = 0x8;
            }
            export namespace FuncRotatorRotationSummary_t {
                export const nTick = 0x0;
                export const nFlags = 0x4;
            }
            export namespace ISkeletonAnimationController {

            }
            export namespace SimpleConstraintSoundProfile {
                export const m_flKeyPointMaxSoundThreshold = 0xC;
                export const m_flKeyPointMinSoundThreshold = 0x8;
                export const m_reversalSoundThresholdLarge = 0x18;
                export const m_reversalSoundThresholdSmall = 0x10;
                export const m_reversalSoundThresholdMedium = 0x14;
            }
            export namespace VPhysicsCollisionAttribute_t {
                export const m_nOwnerId = 0x24;
                export const m_nEntityId = 0x20;
                export const m_nHierarchyId = 0x28;
                export const m_nInteractsAs = 0x8;
                export const m_nInteractsWith = 0x10;
                export const m_nCollisionGroup = 0x2E;
                export const m_nDetailLayerMask = 0x2A;
                export const m_nInteractsExclude = 0x18;
                export const m_nTargetDetailLayer = 0x2D;
                export const m_nDetailLayerMaskType = 0x2C;
                export const m_nCollisionFunctionMask = 0x2F;
            }
            export namespace CBodyComponentBaseModelEntity {

            }
            export namespace CBtActionParachutePositioning {
                export const m_ActionTimer = 0x58;
            }
            export namespace CCSPlayer_DamageReactServices {

            }
            export namespace CDestructiblePart_DamageLevel {
                export const m_sName = 0x0;
                export const m_nHealth = 0x14;
                export const m_nBodyGroupValue = 0x10;
                export const m_flDeathDestroyTime = 0x3C;
                export const m_sBreakablePieceName = 0x8;
                export const m_bShouldDestroyOnDeath = 0x38;
                export const m_sCustomDeathHandshake = 0x30;
                export const m_nDamagePassthroughType = 0x28;
                export const m_flCriticalDamagePercent = 0x24;
                export const m_nDestructionDeathBehavior = 0x2C;
            }
            export namespace CInfoOffscreenPanoramaTexture {
                export const m_bDisabled = 0x4A8;
                export const m_szPanelType = 0x4B8;
                export const m_nResolutionX = 0x4AC;
                export const m_nResolutionY = 0x4B0;
                export const m_bEnableMipGen = 0x4A9;
                export const m_szTargetsName = 0x508;
                export const m_vecCSSClasses = 0x4F0;
                export const m_RenderAttrName = 0x4C8;
                export const m_TargetEntities = 0x4D0;
                export const m_szLayoutFileName = 0x4C0;
                export const m_nTargetChangeCount = 0x4E8;
                export const m_AdditionalTargetEntities = 0x510;
            }
            export namespace CNetworkOriginQuantizedVector {
                export const m_vecX = 0x10;
                export const m_vecY = 0x18;
                export const m_vecZ = 0x20;
            }
            export namespace CPulseCell_BaseYieldingInflow {
                export const m_BaseFlow_WhileActive = 0x90;
                export const m_BaseFlow_OnAfterCancel = 0x48;
            }
            export namespace CPulseCell_BooleanSwitchState {
                export const m_WhenTrue = 0x168;
                export const m_Condition = 0xD8;
                export const m_WhenFalse = 0x1B0;
            }
            export namespace CPulseCell_IsRequirementValid {

            }
            export namespace CPulseCell_LerpCameraSettings {
                export const m_End = 0x134;
                export const m_Start = 0x124;
                export const m_flSeconds = 0x120;
            }
            export namespace CPulseCell_Outflow_PlayVOLine {
                export const m_OnFinished = 0xD8;
            }
            export namespace CTestPulseIOComponent_Derived {

            }
            export namespace AI_BaseNPC_DebugSnapshotData_t {
                export const animgraph = 0x70;
                export const navigator = 0xB8;
                export const npc_state = 0x8;
                export const conditions = 0x40;
                export const anim_events = 0x58;
                export const current_enemy = 0x10;
                export const motorServices = 0x108;
                export const facingServices = 0x140;
                export const s_current_task = 0x20;
                export const s_prev_schedule = 0x28;
                export const s_current_schedule = 0x18;
                export const s_npc_current_movement = 0x30;
                export const s_last_task_end_location = 0x38;
            }
            export namespace CBodyComponentSkeletonInstance {
                export const m_skeletonInstance = 0x80;
            }
            export namespace CCSGO_EndOfMatchLineupEndpoint {

            }
            export namespace CDynamicPropAlias_dynamic_prop {

            }
            export namespace CFloatExponentialMovingAverage {

            }
            export namespace CInfoInstructorHintBombTargetA {

            }
            export namespace CInfoInstructorHintBombTargetB {

            }
            export namespace CItemDefuserAlias_item_defuser {

            }
            export namespace CNmSnapWeaponNode__CDefinition {
                export const m_nWeaponTypeNodeIdx = 0x1C;
                export const m_nFlashedAmountNodeIdx = 0x18;
                export const m_nWeaponCategoryNodeIdx = 0x1A;
            }
            export namespace CPulseCell_ApplyAnimGraphParam {
                export const m_value = 0xD8;
            }
            export namespace CPulseCell_Inflow_EventHandler {
                export const m_EventName = 0x80;
            }
            export namespace CPulseCell_Outflow_CycleRandom {
                export const m_Outputs = 0x48;
            }
            export namespace CPulseCell_Outflow_PlayVCDBase {

            }
            export namespace CSoundOpvarSetPathCornerEntity {
                export const m_flDistMaxSqr = 0x660;
                export const m_flDistMinSqr = 0x65C;
                export const m_bUseParentedPath = 0x658;
                export const m_iszPathCornerEntityName = 0x668;
            }
            export namespace HUDPanelDialogVariableString_t {
                export const m_bIsSet = 0x18;
                export const m_sValue = 0x10;
                export const m_nPanelIdIndex = 0x8;
                export const m_nDialogVariableIndex = 0xA;
            }
            export namespace SoundeventBoxHelperNetworked_t {
                export const vMaxs = 0x24;
                export const vMins = 0x18;
                export const qAngles = 0xC;
                export const vOrigin = 0x0;
            }
            export namespace CBaseAnimGraphVariationUserData {

            }
            export namespace CDynamicPropAlias_cable_dynamic {

            }
            export namespace CNetworkOriginQuantizedVectorWS {
                export const m_vecX = 0x10;
                export const m_vecY = 0x18;
                export const m_vecZ = 0x20;
            }
            export namespace CPulseCell_Outflow_CycleOrdered {
                export const m_Outputs = 0x48;
            }
            export namespace CPulseCell_Outflow_PlaySequence {
                export const m_ParamSequenceName = 0x138;
            }
            export namespace CTestPulseIO__FloatStringArgs_t {
                export const flOutFloat = 0x0;
                export const strOutString = 0x8;
            }
            export namespace CTestPulseIO__ThreeStringArgs_t {
                export const strArg1 = 0x0;
                export const strArg2 = 0x8;
                export const strArg3 = 0x10;
            }
            export namespace CVectorExponentialMovingAverage {

            }
            export namespace DestructiblePartDamageRequest_t {
                export const m_hAttacker = 0x1C;
                export const m_nHitGroup = 0x0;
                export const m_nDamageType = 0x10;
                export const m_nDamageLevel = 0x4;
                export const m_flBreakDamage = 0x14;
                export const m_nDestroyFlags = 0xC;
                export const m_nDesiredHealth = 0x8;
                export const m_flBreakDamageRadius = 0x18;
                export const m_vWsBreakDamageForce = 0x2C;
                export const m_vWsBreakDamageOrigin = 0x20;
            }
            export namespace ServerAuthoritativeWeaponSlot_t {
                export const unSlot = 0x32;
                export const unClass = 0x30;
                export const unItemDefIdx = 0x34;
            }
            export namespace AI_Navigator_DebugSnapshotData_t {
                export const waypoints = 0x30;
                export const goal_location = 0x24;
                export const s_movement_id = 0x0;
                export const last_waypoint_pos = 0x18;
                export const s_goal_source_location = 0x10;
                export const s_movement_serial_number = 0x8;
                export const s_arrival_movement_gait_set = 0x48;
            }
            export namespace CCSGO_RushIntroCharacterPosition {

            }
            export namespace CCSGO_RushIntroTerroristPosition {

            }
            export namespace CCSGO_TeamIntroCharacterPosition {

            }
            export namespace CCSGO_TeamIntroTerroristPosition {

            }
            export namespace CCSPlayer_ActionTrackingServices {
                export const m_bIsRescuing = 0x224;
                export const m_weaponPurchasesThisMatch = 0x228;
                export const m_weaponPurchasesThisRound = 0x298;
                export const m_weaponCarryOverIntoThisRound = 0x308;
                export const m_hLastWeaponBeforeC4AutoSwitch = 0x1F8;
            }
            export namespace CHostageAlias_info_hostage_spawn {

            }
            export namespace CMarkupSearch_PathCostAreaFilter {
                export const m_searchHelper = 0x8;
            }
            export namespace CPhysHingeAlias_phys_hinge_local {

            }
            export namespace CPulseCell_Inflow_BaseEntrypoint {
                export const m_EntryChunk = 0x48;
                export const m_RegisterMap = 0x50;
            }
            export namespace CPulseCell_Outflow_CycleShuffled {
                export const m_Outputs = 0x48;
            }
            export namespace CPulseCell_Outflow_PlaySceneBase {
                export const m_Triggers = 0x120;
                export const m_OnFinished = 0xD8;
            }
            export namespace CPulseCell_WaitForCursorsWithTag {
                export const m_bTagSelfWhenComplete = 0x128;
                export const m_nDesiredKillPriority = 0x12C;
            }
            export namespace CPulseGraphInstance_ServerEntity {
                export const m_hOwner = 0x118;
                export const m_bActivated = 0x11C;
                export const m_sNameFixupLocal = 0x130;
                export const m_sNameFixupParent = 0x128;
                export const m_sNameFixupStaticPrefix = 0x120;
                export const m_sProceduralWorldNameForRelays = 0x138;
            }
            export namespace AI_DefaultNPC_DebugSnapshotData_t {
                export const path_query = 0x40;
                export const s_npc_tactic_phase = 0x20;
                export const s_npc_tactic_current = 0x18;
                export const s_npc_current_ability = 0x8;
                export const path_queries_speculative = 0x68;
                export const s_npc_current_held_ability = 0x10;
                export const tactic_interrupt_conditions = 0x28;
            }
            export namespace CBaseAnimGraphAlias_baseanimating {

            }
            export namespace CCSGO_TeamSelectCharacterPosition {

            }
            export namespace CCSGO_TeamSelectTerroristPosition {

            }
            export namespace CPlayer_MovementServices_Humanoid {
                export const m_nStepside = 0x280;
                export const m_groundNormal = 0x260;
                export const m_surfaceProps = 0x270;
                export const m_flFallVelocity = 0x25C;
                export const m_flStepSoundTime = 0x258;
                export const m_flSurfaceFriction = 0x26C;
                export const m_vecSmoothedVelocity = 0x284;
            }
            export namespace CPulseCell_InlineNodeSkipSelector {
                export const m_bAnd = 0x4C;
                export const m_FailOutflow = 0x68;
                export const m_PassOutflow = 0x50;
                export const m_nFlowNodeID = 0x48;
            }
            export namespace CPulseCell_LimitCount__Criteria_t {
                export const m_bLimitCountPasses = 0x0;
            }
            export namespace CPulseCell_Outflow_PlayDynamicVCD {

            }
            export namespace CPulseCell_Step_SetAnimGraphParam {
                export const m_ParamName = 0x48;
            }
            export namespace DebugSnapshotBaseStructuredData_t {

            }
            export namespace CCSGO_TeamPreviewCharacterPosition {
                export const m_xuid = 0x4C0;
                export const m_nRandom = 0x4AC;
                export const m_petItem = 0x1080;
                export const m_nOrdinal = 0x4B0;
                export const m_nVariant = 0x4A8;
                export const m_agentItem = 0x4C8;
                export const m_glovesItem = 0x8B0;
                export const m_weaponItem = 0xC98;
                export const m_sWeaponName = 0x4B8;
            }
            export namespace CCSPlayerController_DamageServices {
                export const m_DamageList = 0x48;
                export const m_nSendUpdate = 0x40;
            }
            export namespace CEnvSoundscapeAlias_snd_soundscape {

            }
            export namespace CPulseCell_BaseLerp__CursorState_t {
                export const m_EndTime = 0x4;
                export const m_StartTime = 0x0;
            }
            export namespace CPulseCell_Inflow_EntOutputHandler {
                export const m_SourceEntity = 0x80;
                export const m_SourceOutput = 0x90;
                export const m_ExpectedParamType = 0xA0;
            }
            export namespace CPulseCell_PickBestOutflowSelector {
                export const m_nCheckType = 0x48;
                export const m_OutflowList = 0x50;
            }
            export namespace CPulseCell_Step_CallExternalMethod {
                export const m_MethodName = 0xD8;
                export const m_OnFinished = 0x108;
                export const m_ExpectedArgs = 0xF0;
                export const m_nAsyncCallMode = 0x100;
                export const m_nBlackboardIndex = 0xE8;
            }
            export namespace CPulseGraphInstance_GameBlackboard {

            }
            export namespace CCSGO_WingmanIntroCharacterPosition {

            }
            export namespace CCSGO_WingmanIntroTerroristPosition {

            }
            export namespace CFuncLadderAlias_func_useableladder {

            }
            export namespace CFuncMoveLinearAlias_momentary_door {

            }
            export namespace CPulseCell_ApplyDynamicAttributeInt {

            }
            export namespace CPulseCell_Outflow_ScriptedSequence {
                export const m_Triggers = 0x180;
                export const m_OnFinished = 0x138;
                export const m_szSyncGroup = 0xD8;
                export const m_bDontTeleportAtEnd = 0xE5;
                export const m_bDisallowInterrupts = 0xE6;
                export const m_vecAdditionalActors = 0x120;
                export const m_bEnsureOnNavmeshOnFinish = 0xE4;
                export const m_scriptedSequenceDataMain = 0xE8;
                export const m_nExpectedNumSequencesInSyncGroup = 0xE0;
            }
            export namespace CTestPulseIO__EntityHandleIntArgs_t {
                export const valueB = 0x4;
                export const handleA = 0x0;
            }
            export namespace SoundeventPathCornerPairNetworked_t {
                export const vP1 = 0x0;
                export const vP2 = 0xC;
                export const flP1Pct = 0x1C;
                export const flP2Pct = 0x20;
                export const flPathLengthSqr = 0x18;
            }
            export namespace AI_MotorServices_DebugSnapshotData_t {
                export const motor_path = 0x18;
                export const active_motor = 0x0;
                export const desired_speed = 0x8;
                export const motor_velocity = 0xC;
                export const ground_entity_debug_name = 0x30;
            }
            export namespace AnimGraph2SerializedPoseRecipeSlot_t {
                export const m_topology = 0x30;
            }
            export namespace CBaseModelEntity__BodyGroupRequest_t {
                export const m_nGroup = 0x10;
                export const m_uChoice = 0x14;
                export const m_uRefCount = 0x16;
                export const m_nGroupName = 0x4;
                export const m_uRequestID = 0x0;
                export const m_sChoiceName = 0x8;
            }
            export namespace CInfoInstructorHintHostageRescueZone {

            }
            export namespace CPulseCell_ApplyDynamicAttributeBase {

            }
            export namespace CPulseCell_Timeline__TimelineEvent_t {
                export const m_EventOutflow = 0x8;
                export const m_flTimeFromPrevious = 0x0;
            }
            export namespace CPulseCell_WaitForCursorsWithTagBase {
                export const m_WaitComplete = 0xE0;
                export const m_nCursorsAllowedToWait = 0xD8;
            }
            export namespace CTestPulseIO__EntityNameStringArgs_t {
                export const nameA = 0x0;
                export const strValueB = 0x8;
            }
            export namespace AI_FacingServices_DebugSnapshotData_t {
                export const movement_id = 0x40;
                export const npc_position = 0x0;
                export const facing_target = 0x18;
                export const strafing_source = 0x30;
                export const strafing_enabled = 0x38;
                export const facing_target_source = 0x10;
                export const schedule_facing_priority = 0x28;
            }
            export namespace CCSPlayerController_InventoryServices {
                export const m_rank = 0x44;
                export const m_unMusicID = 0x40;
                export const m_unCurrentLoadoutHash = 0xF90;
                export const m_nPersonaDataPublicLevel = 0x5C;
                export const m_nPersonaDataXpTrailLevel = 0x6C;
                export const m_unEquippedPlayerSprayIDs = 0xF88;
                export const m_nPersonaDataPublicCommendsLeader = 0x60;
                export const m_nPersonaDataPublicCommendsTeacher = 0x64;
                export const m_vecServerAuthoritativeWeaponSlots = 0xF98;
                export const m_nPersonaDataPublicCommendsFriendly = 0x68;
            }
            export namespace CPulseCell_ApplyParent__CursorState_t {
                export const m_hChildEntity = 0x4;
                export const m_hParentEntity = 0x0;
            }
            export namespace CNetworkOriginCellCoordQuantizedVector {
                export const m_vecX = 0x18;
                export const m_vecY = 0x20;
                export const m_vecZ = 0x28;
                export const m_cellX = 0x10;
                export const m_cellY = 0x12;
                export const m_cellZ = 0x14;
                export const m_nOutsideWorld = 0x16;
            }
            export namespace CPulseCell_ApplyDynamicAttributeString {

            }
            export namespace CPulseCell_LimitCount__InstanceState_t {
                export const m_nCurrentCount = 0x0;
            }
            export namespace CPulseCell_PlaySequence__CursorState_t {
                export const m_hTarget = 0x0;
            }
            export namespace CRagdollPropAlias_physics_prop_ragdoll {

            }
            export namespace CSoundEventEntityAlias_snd_event_point {

            }
            export namespace AI_BaseNPCAnimGraph_DebugSnapshotData_t {
                export const ag2_update_id = 0x0;
                export const e_action_desired = 0x8;
                export const e_movement_type_desired = 0x28;
                export const e_action_handshake_restart = 0x10;
                export const e_movement_handshake_restart = 0x30;
                export const e_action_handshake_body_authority_current = 0x18;
                export const e_action_handshake_body_authority_desired = 0x20;
                export const e_movement_handshake_body_authority_current = 0x38;
                export const e_movement_handshake_body_authority_desired = 0x40;
            }
            export namespace CCSGO_RushIntroCounterTerroristPosition {

            }
            export namespace CCSGO_TeamIntroCounterTerroristPosition {

            }
            export namespace CCSPlayerController_InGameMoneyServices {
                export const m_iAccount = 0x48;
                export const m_iStartAccount = 0x4C;
                export const m_iTotalCashSpent = 0x50;
                export const m_iCashSpentThisRound = 0x54;
                export const m_bReceivesMoneyNextRound = 0x40;
                export const m_iMoneyEarnedForNextRound = 0x44;
            }
            export namespace CDynamicPropAlias_prop_dynamic_override {

            }
            export namespace CPulseCell_ApplyDynamicAttributeEHandle {

            }
            export namespace CPulseCell_IntervalTimer__CursorState_t {
                export const m_EndTime = 0x4;
                export const m_StartTime = 0x0;
                export const m_flWaitInterval = 0x8;
                export const m_flWaitIntervalHigh = 0xC;
                export const m_bCompleteOnNextWake = 0x10;
            }
            export namespace CCSGO_TeamSelectCounterTerroristPosition {

            }
            export namespace CNetworkOriginCellCoordQuantizedVectorWS {
                export const m_vecX = 0x18;
                export const m_vecY = 0x20;
                export const m_vecZ = 0x28;
                export const m_cellX = 0x10;
                export const m_cellY = 0x12;
                export const m_cellZ = 0x14;
                export const m_nOutsideWorld = 0x16;
            }
            export namespace CPulseCell_Outflow_ListenForAnimgraphTag {
                export const m_OnEnd = 0x120;
                export const m_OnStart = 0xD8;
                export const m_TagName = 0x168;
            }
            export namespace CPulseCell_Outflow_ListenForEntityOutput {
                export const m_OnFired = 0xD8;
                export const m_strEntityOutput = 0x120;
                export const m_bListenUntilCanceled = 0x128;
            }
            export namespace CWorldCompositionChunkReferenceElement_t {
                export const m_strMapToLoad = 0x0;
                export const m_strLandmarkName = 0x8;
            }
            export namespace CPulseCell_IsRequirementValid__Criteria_t {
                export const m_bIsValid = 0x0;
            }
            export namespace CCSGO_WingmanIntroCounterTerroristPosition {

            }
            export namespace CCSPlayerController_ActionTrackingServices {
                export const m_matchStats = 0xC8;
                export const m_perRoundStats = 0x40;
                export const m_iNumRoundKills = 0x188;
                export const m_flTotalRoundDamageDealt = 0x190;
                export const m_iNumRoundKillsHeadshots = 0x18C;
            }
            export namespace CPulseCell_ApplyEntityFlags__CursorState_t {
                export const m_uFlags = 0x4;
                export const m_hEntity = 0x0;
            }
            export namespace CAttributeManager__cached_attribute_float_t {
                export const flIn = 0x0;
                export const flOut = 0x10;
                export const iAttribHook = 0x8;
            }
            export namespace CSceneEntityAlias_logic_choreographed_scene {

            }
            export namespace AI_GroundRootMotionMotor_DebugSnapshotData_t {
                export const state = 0x40;
                export const move_type = 0x58;
                export const b_has_path = 0x4C;
                export const vec_events = 0x78;
                export const f_target_lean = 0x70;
                export const f_current_lean = 0x6C;
                export const f_current_speed = 0x54;
                export const movement_setting_id = 0x28;
                export const current_movement_gait = 0x20;
                export const desired_movement_gait = 0x10;
                export const b_goal_completion_allowed = 0x38;
                export const current_movement_gait_set = 0x18;
                export const desired_movement_gait_set = 0x8;
                export const n_state_active_tick_count = 0x48;
                export const gait_switch_blocked_reason = 0x30;
                export const f_remaining_ground_path_length = 0x50;
                export const f_forward_strafing_angle_actual = 0x60;
                export const f_forward_strafing_angle_desired = 0x64;
                export const f_forward_strafing_angle_committed = 0x68;
            }
            export namespace AI_Navigator_DebugSnapshotData_t__Waypoint_t {
                export const flags = 0x10;
                export const nav_type = 0xC;
                export const position = 0x0;
                export const is_pathcorner = 0x14;
            }
            export namespace CBaseModelEntity__OnDamageLevelChangedArgs_t {
                export const nHitGroup = 0x0;
                export const nDamageLevel = 0x4;
                export const nPrevDamageLevel = 0xC;
                export const nDamageLevelsRemaining = 0x8;
            }
            export namespace CPulseCell_Inflow_ObservableVariableListener {
                export const m_bSelfReference = 0x82;
                export const m_nBlackboardReference = 0x80;
            }
            export namespace CPulseCell_LerpCameraSettings__CursorState_t {
                export const m_hCamera = 0x8;
                export const m_OverlaidEnd = 0x1C;
                export const m_OverlaidStart = 0xC;
            }
            export namespace CPulseCell_Outflow_PlayVOLine__CursorState_t {
                export const m_sceneInstance = 0x0;
            }
            export namespace PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                export const m_OutflowID = 0x0;
                export const m_Connection = 0x8;
            }
            export namespace CEnvSoundscapeProxyAlias_snd_soundscape_proxy {

            }
            export namespace CPulseCell_ApplyAnimGraphParam__CursorState_t {
                export const hEntity = 0x0;
                export const sParamName = 0x8;
                export const bApplyToExternalGraphs = 0x10;
            }
            export namespace AI_DefaultNPC_DebugSnapshotData_t__PathQuery_t {
                export const m_nMode = 0x10;
                export const m_nType = 0x18;
                export const m_nState = 0x20;
                export const m_nCurrentMovementId = 0x8;
                export const m_nInitialMovementId = 0x0;
            }
            export namespace CBaseAnimGraphDestructibleParts_GraphController {

            }
            export namespace CPulseCell_Outflow_PlaySceneBase__CursorState_t {
                export const m_mainActor = 0x4;
                export const m_sceneInstance = 0x0;
                export const m_cursorIDToEventID = 0x8;
            }
            export namespace CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                export const m_nNextIndex = 0x0;
            }
            export namespace CPulseCell_Outflow_PlayVCD__VCDRequirementInfo_t {
                export const m_Outflow = 0x8;
                export const m_nEventID = 0x0;
            }
            export namespace CTonemapController2Alias_env_tonemap_controller2 {

            }
            export namespace CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                export const m_Shuffle = 0x0;
                export const m_nNextShuffle = 0x20;
            }
            export namespace CPulseCell_Outflow_ScriptedSequence__CursorState_t {
                export const m_scriptedSequence = 0x0;
            }
            export namespace CPulseCell_ApplyDynamicAttributeBase__CursorState_t {
                export const m_hEntity = 0x0;
                export const m_szAttributeKey = 0x8;
            }
            export namespace CPathParticleRopeAlias_path_particle_rope_clientside {

            }
            export namespace AI_GroundRootMotionMotor_DebugSnapshotData_t__Event_t {
                export const location = 0x8;
                export const description = 0x0;
            }
            export namespace CPulseCell_Outflow_ListenForEntityOutput__CursorState_t {
                export const m_entity = 0x0;
            }
            export namespace AI_MotorServices_DebugSnapshotData_t__MotorPathWaypoint_t {
                export const flags = 0x10;
                export const nav_type = 0xC;
                export const position = 0x0;
            }
            export namespace CEnvSoundscapeTriggerableAlias_snd_soundscape_triggerable {

            }
            export namespace CCSPlayerController_InventoryServices__NetworkedLoadoutSlot_t {
                export const slot = 0xA;
                export const team = 0x8;
                export const pItem = 0x0;
            }
            export namespace CEnvCombinedLightProbeVolumeAlias_func_combined_light_probe_volume {

            }
            export namespace ETeam {
                export const ET_CT = 0x3;
                export const ET_Unknown = 0x0;
                export const ET_Spectator = 0x1;
                export const ET_Terrorist = 0x2;
            }
            export namespace ESOMsg {
                export const k_ESOMsg_Create = 0x15;
                export const k_ESOMsg_Update = 0x16;
                export const k_ESOMsg_Destroy = 0x17;
                export const k_ESOMsg_UpdateMultiple = 0x1A;
                export const k_ESOMsg_CacheSubscribed = 0x18;
                export const k_ESOMsg_CacheUnsubscribed = 0x19;
                export const k_ESOMsg_CacheSubscriptionCheck = 0x1B;
                export const k_ESOMsg_CacheSubscriptionRefresh = 0x1C;
            }
            export namespace Hull_t {
                export const HULL_NONE = 0xB;
                export const HULL_TINY = 0x3;
                export const NUM_HULLS = 0xA;
                export const HULL_HUMAN = 0x0;
                export const HULL_LARGE = 0x6;
                export const HULL_SMALL = 0x9;
                export const HULL_MEDIUM = 0x4;
                export const HULL_WIDE_HUMAN = 0x2;
                export const HULL_MEDIUM_TALL = 0x8;
                export const HULL_TINY_CENTERED = 0x5;
                export const HULL_LARGE_CENTERED = 0x7;
                export const HULL_SMALL_CENTERED = 0x1;
            }
            export namespace Class_T {
                export const CLASS_DOOR = 0xB;
                export const CLASS_NONE = 0x0;
                export const CLASS_PLAYER = 0x1;
                export const CLASS_WEAPON = 0x5;
                export const CLASS_PLANTED_C4 = 0xC;
                export const CLASS_PLAYER_ALLY = 0x2;
                export const CLASS_C4_FOR_RADAR = 0x3;
                export const CLASS_HUDMODEL_ARMS = 0x8;
                export const CLASS_HUDMODEL_ADDON = 0x9;
                export const CLASS_WATER_SPLASHER = 0x6;
                export const NUM_CLASSIFY_CLASSES = 0xD;
                export const CLASS_HUDMODEL_WEAPON = 0x7;
                export const CLASS_WORLDMODEL_GLOVES = 0xA;
                export const CLASS_FOOT_CONTACT_SHADOW = 0x4;
            }
            export namespace Flags_t {
                export const FL_BOT = 0x10;
                export const FL_FLY = 0x400;
                export const FL_CLIENT = 0x80;
                export const FL_FROZEN = 0x20;
                export const FL_OBJECT = 0x2000000;
                export const FL_ONFIRE = 0x8000000;
                export const FL_DUCKING = 0x2;
                export const FL_GODMODE = 0x4000;
                export const FL_GRENADE = 0x100000;
                export const FL_CONVEYOR = 0x1000000;
                export const FL_NOTARGET = 0x8000;
                export const FL_ONGROUND = 0x1;
                export const FL_AIMTARGET = 0x10000;
                export const FL_DONTTOUCH = 0x400000;
                export const FL_WATERJUMP = 0x4;
                export const FL_ATCONTROLS = 0x40;
                export const FL_DISSOLVING = 0x10000000;
                export const FL_FAKECLIENT = 0x100;
                export const FL_IN_VEHICLE = 0x1000;
                export const FL_BASEVELOCITY = 0x800000;
                export const FL_TRANSRAGDOLL = 0x20000000;
                export const FL_SUPPRESS_SAVE = 0x800;
                export const FL_UNBLOCKABLE_BY_PLAYER = 0x40000000;
            }
            export namespace OnFrame {
                export const ONFRAME_TRUE = 0x1;
                export const ONFRAME_FALSE = 0x2;
                export const ONFRAME_UNKNOWN = 0x0;
            }
            export namespace Touch_t {
                export const touch_none = 0x0;
                export const touch_npc_only = 0x2;
                export const touch_player_only = 0x1;
                export const touch_player_or_npc = 0x3;
                export const touch_player_or_npc_or_physicsprop = 0x4;
            }
            export namespace filter_t {
                export const FILTER_OR = 0x1;
                export const FILTER_AND = 0x0;
            }
            export namespace BloodType {
                export const _None = -0x1;
                export const ColorRed = 0x0;
                export const ColorGreen = 0x2;
                export const ColorYellow = 0x1;
                export const ColorRedLVL2 = 0x3;
                export const ColorRedLVL3 = 0x4;
                export const ColorRedLVL4 = 0x5;
                export const ColorRedLVL5 = 0x6;
                export const ColorRedLVL6 = 0x7;
            }
            export namespace EGCPetMsg {
                export const k_EMsgGCAckPetEvent = 0x9EA;
            }
            export namespace EHitGroup {
                export const EHG_Gear = 0x8;
                export const EHG_Head = 0x1;
                export const EHG_Miss = 0x9;
                export const EHG_Chest = 0x2;
                export const EHG_Generic = 0x0;
                export const EHG_LeftArm = 0x4;
                export const EHG_LeftLeg = 0x6;
                export const EHG_Stomach = 0x3;
                export const EHG_RightArm = 0x5;
                export const EHG_RightLeg = 0x7;
            }
            export namespace Materials {
                export const matWeb = 0x9;
                export const matNone = 0xA;
                export const matWood = 0x1;
                export const matFlesh = 0x3;
                export const matGlass = 0x0;
                export const matMetal = 0x2;
                export const matRocks = 0x8;
                export const matComputer = 0x6;
                export const matCeilingTile = 0x5;
                export const matCinderBlock = 0x4;
                export const matLastMaterial = 0xB;
                export const matUnbreakableGlass = 0x7;
            }
            export namespace QuestType {
                export const k_EQuestType_Operation = 0x1;
                export const k_EQuestType_RecurringMission = 0x2;
            }
            export namespace eRollType {
                export const ROLL_NONE = -0x1;
                export const ROLL_STATS = 0x0;
                export const ROLL_OUTTRO = 0x3;
                export const ROLL_CREDITS = 0x1;
                export const ROLL_LATE_JOIN_LOGO = 0x2;
            }
            export namespace BeamType_t {
                export const BEAM_ENTS = 0x3;
                export const BEAM_LASER = 0x6;
                export const BEAM_POINTS = 0x1;
                export const BEAM_SPLINE = 0x5;
                export const BEAM_INVALID = 0x0;
                export const BEAM_ENTPOINT = 0x2;
                export const xxBEAM_HOSExxunused = 0x4;
            }
            export namespace ECsgoGCMsg {
                export const k_EMsgGC_GlobalGame_Play = 0x23D2;
                export const k_EMsgGCCStrike15_v2_Base = 0x238C;
                export const k_EMsgGC_GlobalGame_Subscribe = 0x23D0;
                export const k_EMsgGCCStrike15_v2_MatchList = 0x23B3;
                export const k_EMsgGCCStrike15_v2_SetClanId = 0x240D;
                export const k_EMsgGCCStrike15_v2_GlobalChat = 0x23DC;
                export const k_EMsgGC_GlobalGame_Unsubscribe = 0x23D1;
                export const k_EMsgGCCStrike15_ClientDeepStats = 0x23FA;
                export const k_EMsgGCCStrike15_v2_DraftSummary = 0x23CA;
                export const k_EMsgGCCStrike15_v2_Party_Invite = 0x23E8;
                export const k_EMsgGCCStrike15_v2_Party_Search = 0x23E7;
                export const k_EMsgGCCStrike15_v2_PrivateQueues = 0x23FE;
                export const k_EMsgGCCStrike15_v2_BetaEnrollment = 0x2401;
                export const k_EMsgGCCStrike15_v2_GotvSyncPacket = 0x23E0;
                export const k_EMsgGCCStrike15_v2_Party_Register = 0x23E5;
                export const k_EMsgGCCStrike15_v2_PlayersProfile = 0x23A8;
                export const k_EMsgGCCStrike15_v2_WatchInfoUsers = 0x23A6;
                export const k_EMsgGCCStrike15_v2_ClientPollState = 0x23E4;
                export const k_EMsgGCCStrike15_v2_MatchmakingStop = 0x238E;
                export const k_EMsgGCCStrike15_v2_Client2GCTextMsg = 0x23AF;
                export const k_EMsgGCCStrike15_v2_ClientPerfReport = 0x23F2;
                export const k_EMsgGCCStrike15_v2_GC2ClientTextMsg = 0x23AE;
                export const k_EMsgGCCStrike15_v2_MatchmakingStart = 0x238D;
                export const k_EMsgGCCStrike15_v2_Party_Unregister = 0x23E6;
                export const k_EMsgGCCStrike15_v2_SetEventFavorite = 0x23F0;
                export const k_EMsgGCCStrike15_v2_ClientAuthKeyCode = 0x23DF;
                export const k_EMsgGCCStrike15_v2_SetMyActivityInfo = 0x23C7;
                export const k_EMsgGCCStrike15_v2_AcknowledgePenalty = 0x23D3;
                export const k_EMsgGCCStrike15_v2_ClientGCRankUpdate = 0x23EA;
                export const k_EMsgGCCStrike15_v2_ClientPartyWarning = 0x23EE;
                export const k_EMsgGCCStrike15_v2_ClientReportPlayer = 0x239F;
                export const k_EMsgGCCStrike15_v2_ClientReportServer = 0x23A0;
                export const k_EMsgGCCStrike15_v2_ClientCommendPlayer = 0x23A1;
                export const k_EMsgGCCStrike15_v2_ClientNetworkConfig = 0x2404;
                export const k_EMsgGCCStrike15_v2_ClientRequestOffers = 0x23EB;
                export const k_EMsgGCCStrike15_v2_ClientAccountBalance = 0x23EC;
                export const k_EMsgGCCStrike15_v2_ClientPartyJoinRelay = 0x23ED;
                export const k_EMsgGCCStrike15_v2_ClientReportResponse = 0x23A2;
                export const k_EMsgGCCStrike15_v2_GC2ClientGlobalStats = 0x23D5;
                export const k_EMsgGCCStrike15_v2_GlobalChat_Subscribe = 0x23DD;
                export const k_EMsgGCCStrike15_v2_PremierSeasonSummary = 0x2408;
                export const k_EMsgGCCStrike15_v2_Client2GCStreamUnlock = 0x23D6;
                export const k_EMsgGCCStrike15_v2_ClientLogonFatalError = 0x23E3;
                export const k_EMsgGCCStrike15_v2_ClientPlayerDecalSign = 0x23E1;
                export const k_EMsgGCCStrike15_v2_ClientRequestSouvenir = 0x23F4;
                export const k_EMsgGCCStrike15_v2_GC2ClientNotifyXPShop = 0x2405;
                export const k_EMsgGCCStrike15_v2_VolatileShopSubscribe = 0x240C;
                export const k_EMsgGCCStrike15_v2_AccountPrivacySettings = 0x23C6;
                export const k_EMsgGCCStrike15_v2_Account_RequestCoPlays = 0x23E9;
                export const k_EMsgGCCStrike15_v2_ClientRedeemFreeReward = 0x2403;
                export const k_EMsgGCCStrike15_v2_ClientSubmitSurveyVote = 0x23C0;
                export const k_EMsgGCCStrike15_v2_GlobalChat_Unsubscribe = 0x23DE;
                export const k_EMsgGCCStrike15_v2_MatchEndRunRewardDrops = 0x23B0;
                export const k_EMsgGCCStrike15_v2_RecurringMissionSchema = 0x240A;
                export const k_EMsgGCCStrike15_v2_ClientToGCRequestTicket = 0x23DA;
                export const k_EMsgGCCStrike15_v2_FantasyUpdateClientData = 0x23D8;
                export const k_EMsgGCCStrike15_v2_GC2ClientTournamentInfo = 0x23CF;
                export const k_EMsgGCCStrike15_v2_GiftsLeaderboardRequest = 0x23BC;
                export const k_EMsgGCCStrike15_v2_Server2GCClientValidate = 0x23C1;
                export const k_EMsgGCCStrike15_v2_VolatileItemClaimReward = 0x240B;
                export const k_EMsgGCCStrike15_StartAgreementSessionInGame = 0x23FB;
                export const k_EMsgGCCStrike15_v2_Client2GcAckXPShopTracks = 0x2406;
                export const k_EMsgGCCStrike15_v2_ClientCommendPlayerQuery = 0x23A3;
                export const k_EMsgGCCStrike15_v2_ClientToGCRequestElevate = 0x23DB;
                export const k_EMsgGCCStrike15_v2_FantasyRequestClientData = 0x23D7;
                export const k_EMsgGCCStrike15_v2_GiftsLeaderboardResponse = 0x23BD;
                export const k_EMsgGCCStrike15_v2_ClientRedeemMissionReward = 0x23F9;
                export const k_EMsgGCCStrike15_v2_GetEventFavorites_Request = 0x23F1;
                export const k_EMsgGCCStrike15_v2_MatchmakingClient2GCHello = 0x2395;
                export const k_EMsgGCCStrike15_v2_MatchmakingGC2ClientHello = 0x2396;
                export const k_EMsgGCCStrike15_v2_PlayerOverwatchCaseStatus = 0x23AD;
                export const k_EMsgGCCStrike15_v2_PlayerOverwatchCaseUpdate = 0x23AB;
                export const k_EMsgGCCStrike15_v2_GC2ServerReservationUpdate = 0x23B6;
                export const k_EMsgGCCStrike15_v2_GetEventFavorites_Response = 0x23F3;
                export const k_EMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate = 0x2390;
                export const k_EMsgGCCStrike15_v2_ClientRequestJoinFriendData = 0x23CB;
                export const k_EMsgGCCStrike15_v2_ClientRequestJoinServerData = 0x23CC;
                export const k_EMsgGCCStrike15_v2_ClientRequestPlayersProfile = 0x23A7;
                export const k_EMsgGCCStrike15_v2_MatchmakingGC2ClientAbandon = 0x2398;
                export const k_EMsgGCCStrike15_v2_MatchmakingGC2ClientReserve = 0x2393;
                export const k_EMsgGCCStrike15_v2_Client2GCRequestPrestigeCoin = 0x23D4;
                export const k_EMsgGCCStrike15_v2_MatchListRequestFullGameInfo = 0x23BB;
                export const k_EMsgGCCStrike15_v2_MatchmakingClient2ServerPing = 0x238F;
                export const k_EMsgGCCStrike15_v2_SetPlayerLeaderboardSafeName = 0x2402;
                export const k_EMsgGCCStrike15_v2_GCToClientSteamdatagramTicket = 0x23D9;
                export const k_EMsgGCCStrike15_v2_PlayerOverwatchCaseAssignment = 0x23AC;
                export const k_EMsgGCCStrike15_v2_ClientRequestWatchInfoFriends2 = 0x23B2;
                export const k_EMsgGCCStrike15_v2_ClientVarValueNotificationInfo = 0x23B8;
                export const k_EMsgGCCStrike15_v2_ServerVarValueNotificationInfo = 0x23BE;
                export const k_EMsgGCCStrike15_v2_MatchEndRewardDropsNotification = 0x23B1;
                export const k_EMsgGCCStrike15_v2_MatchListRequestLiveGameForUser = 0x23C2;
                export const k_EMsgGCCStrike15_v2_MatchListRequestRecentUserGames = 0x23B5;
                export const k_EMsgGCCStrike15_v2_MatchListRequestTournamentGames = 0x23BA;
                export const k_EMsgGCCStrike15_v2_MatchListTournamentOperatorMgmt = 0x23FF;
                export const k_EMsgGCCStrike15_v2_MatchmakingGC2ClientSearchStats = 0x2407;
                export const k_EMsgGCCStrike15_v2_RequestRecurringMissionSchedule = 0x2409;
                export const k_EMsgGCCStrike15_v2_ClientCommendPlayerQueryResponse = 0x23A4;
                export const k_EMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames = 0x23B4;
                export const k_EMsgGCCStrike15_v2_MatchmakingOperator2GCBlogUpdate = 0x239D;
                export const k_EMsgGCCStrike15_v2_ServerNotificationForUserPenalty = 0x239E;
                export const k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockRequest = 0x23C4;
                export const k_EMsgGCCStrike15_v2_MatchListUploadTournamentPredictions = 0x23C9;
                export const k_EMsgGCCStrike15_v2_MatchmakingServerReservationResponse = 0x2392;
                export const k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockResponse = 0x23C5;
                export const k_EMsgGCCStrike15_v2_MatchListRequestTournamentPredictions = 0x23C8;
            }
            export namespace EGCBaseMsg {
                export const k_EMsgGCError = 0x119D;
                export const k_EMsgGCInQueue = 0xFA8;
                export const k_EMsgGCLeaveParty = 0x1199;
                export const k_EMsgGCConVarUpdated = 0xFA3;
                export const k_EMsgGCInviteToParty = 0x1195;
                export const k_EMsgGCKickFromParty = 0x1198;
                export const k_EMsgGCSystemMessage = 0xFA1;
                export const k_EMsgGCGameServerInfo = 0x119C;
                export const k_EMsgGCServerAvailable = 0x119A;
                export const k_EMsgGCReplicateConVars = 0xFA2;
                export const k_EMsgGCInvitationCreated = 0x1196;
                export const k_EMsgGCLANServerAvailable = 0x119F;
                export const k_EMsgGCPartyInviteResponse = 0x1197;
                export const k_EMsgGCClientConnectToServer = 0x119B;
                export const k_EMsgGCReplay_UploadedToYouTube = 0x119E;
            }
            export namespace EGCItemMsg {
                export const k_EMsgGCBase = 0x3E8;
                export const k_EMsgGCCraft = 0x3EA;
                export const k_EMsgGCDelete = 0x3EC;
                export const k_EMsgGCNameItem = 0x3EE;
                export const k_EMsgGCOpenCrate = 0x9E6;
                export const k_EMsgGCPaintItem = 0x3F1;
                export const k_EMsgGCSortItems = 0x411;
                export const k_EMsgGCCollectItem = 0x425;
                export const k_EMsgGCDeliverGift = 0x40A;
                export const k_EMsgGCGiftedItems = 0x43B;
                export const k_EMsgGCMOTDRequest = 0x3F4;
                export const k_EMsgGCApplySticker = 0x43E;
                export const k_EMsgGCGiftWrapItem = 0x408;
                export const k_EMsgGCNameBaseItem = 0x3FB;
                export const k_EMsgGCPaintKitItem = 0x438;
                export const k_EMsgGCSetItemStyle = 0x40F;
                export const k_EMsgGCStatTrakSwap = 0x440;
                export const k_EMsgGC_ReportAbuse = 0x429;
                export const k_EMsgGCCasketItemAdd = 0x444;
                export const k_EMsgGCCraftResponse = 0x3EB;
                export const k_EMsgGCLookupAccount = 0x413;
                export const k_EMsgGCRemoveItemName = 0x406;
                export const k_EMsgGCSaxxyBroadcast = 0x421;
                export const k_EMsgGCUseItemRequest = 0x401;
                export const k_EMsgGCApplyEggEssence = 0x436;
                export const k_EMsgGCRemoveItemPaint = 0x407;
                export const k_EMsgGCSetItemPosition = 0x3E9;
                export const k_EMsgGCUnlockItemStyle = 0x43C;
                export const k_EMsgGCUseItemResponse = 0x402;
                export const k_EMsgGCApplyStrangePart = 0x431;
                export const k_EMsgGCItemAcknowledged = 0x43F;
                export const k_EMsgGCPaintKitBaseItem = 0x439;
                export const k_EMsgGCRemoveMakersMark = 0x41D;
                export const k_EMsgGCSetItemPositions = 0x435;
                export const k_EMsgGCStoreGetUserData = 0x9C4;
                export const k_EMsgGCUpdateItemSchema = 0x419;
                export const k_EMsgGCCasketItemExtract = 0x445;
                export const k_EMsgGCItemPreviewExpire = 0x6A9;
                export const k_EMsgGCLookupAccountName = 0x415;
                export const k_EMsgGCPaintItemResponse = 0x3F2;
                export const k_EMsgGCServerRentalsBase = 0x6A4;
                export const k_EMsgGCShowItemsPickedUp = 0x42F;
                export const k_EMsgGCStorePurchaseInit = 0x9CE;
                export const k_EMsgGCToGCDirtySDOCache = 0x9D4;
                export const k_EMsgGCUnwrapGiftRequest = 0x40D;
                export const k_EMsgGCUsedClaimCodeItem = 0x410;
                export const k_EMsgGCDev_NewItemRequest = 0x7D1;
                export const k_EMsgGCItemPreviewRequest = 0x6A7;
                export const k_EMsgGCUnwrapGiftResponse = 0x40E;
                export const k_EMsgGCApplyPennantUpgrade = 0x434;
                export const k_EMsgGCConsumableExhausted = 0x42E;
                export const k_EMsgGCMOTDRequestResponse = 0x3F5;
                export const k_EMsgGCModifyItemAttribute = 0x443;
                export const k_EMsgGCRemoveCustomTexture = 0x41B;
                export const k_EMsgGCStorePurchaseCancel = 0x9CA;
                export const k_EMsgGCToGCIsTrustedServer = 0x9D7;
                export const k_EMsgGCUnlockCrateResponse = 0x3F0;
                export const k_EMsgGCBackpackSortFinished = 0x422;
                export const k_EMsgGCClientVersionUpdated = 0x9E0;
                export const k_EMsgGCCustomizeItemTexture = 0x3FF;
                export const k_EMsgGCDev_PaintKitDropItem = 0x7D3;
                export const k_EMsgGCGiftWrapItemResponse = 0x409;
                export const k_EMsgGCNameBaseItemResponse = 0x3FC;
                export const k_EMsgGCNameItemNotification = 0x42C;
                export const k_EMsgGCPaintKitItemResponse = 0x43A;
                export const k_EMsgGCRequestAnnouncements = 0x9DD;
                export const k_EMsgGCServerVersionUpdated = 0x9DA;
                export const k_EMsgGC_ReportAbuseResponse = 0x42A;
                export const k_EMsgGCBannedWordListRequest = 0x9D0;
                export const k_EMsgGCGoldenWrenchBroadcast = 0x3F3;
                export const k_EMsgGCLookupAccountResponse = 0x414;
                export const k_EMsgGCStorePurchaseFinalize = 0x9C8;
                export const k_EMsgGCStorePurchaseQueryTxn = 0x9CC;
                export const k_EMsgGCToGCUpdateSQLKeyValue = 0x9D6;
                export const k_EMsgGCAdjustEquipSlotsManual = 0x9E3;
                export const k_EMsgGCApplyConsumableEffects = 0x42D;
                export const k_EMsgGCBannedWordListResponse = 0x9D1;
                export const k_EMsgGCCasketItemLoadContents = 0x446;
                export const k_EMsgGCGiftedItems_DEPRECATED = 0x403;
                export const k_EMsgGCItemPreviewCheckStatus = 0x6A5;
                export const k_EMsgGCNameEggEssenceResponse = 0x437;
                export const k_EMsgGCRemoveUniqueCraftIndex = 0x41F;
                export const k_EMsgGCUnlockCrate_DEPRECATED = 0x3EF;
                export const k_EMsgGCAdjustEquipSlotsShuffle = 0x9E4;
                export const k_EMsgGCUnlockItemStyleResponse = 0x43D;
                export const k_EMsgGCVerifyCacheSubscription = 0x3ED;
                export const k_EMsgGCDeliverGiftResponseGiver = 0x40B;
                export const k_EMsgGCRemoveMakersMarkResponse = 0x41E;
                export const k_EMsgGCRequestPassportItemGrant = 0x9DF;
                export const k_EMsgGCStoreGetUserDataResponse = 0x9C5;
                export const k_EMsgGCToGCWebAPIAccountChanged = 0x9DC;
                export const k_EMsgGCVolatileItemLoadContents = 0x9E8;
                export const k_EMsgGCClientDisplayNotification = 0x430;
                export const k_EMsgGCItemPreviewStatusResponse = 0x6A6;
                export const k_EMsgGCLookupAccountNameResponse = 0x416;
                export const k_EMsgGCStorePurchaseInitResponse = 0x9CF;
                export const k_EMsgGCToGCBannedWordListUpdated = 0x9D3;
                export const k_EMsgGCToGCDirtyMultipleSDOCache = 0x9D5;
                export const k_EMsgGCAddItemToSocket_DEPRECATED = 0x3F6;
                export const k_EMsgGCAddSocketToItem_DEPRECATED = 0x3F9;
                export const k_EMsgGCDev_NewItemRequestResponse = 0x7D2;
                export const k_EMsgGCItemPreviewRequestResponse = 0x6A8;
                export const k_EMsgGCAcknowledgeRentalExpiration = 0x9E7;
                export const k_EMsgGCDeliverGiftResponseReceiver = 0x40C;
                export const k_EMsgGCRecurringSubscriptionStatus = 0x9E2;
                export const k_EMsgGCRemoveCustomTextureResponse = 0x41C;
                export const k_EMsgGCRemoveSocketItem_DEPRECATED = 0x3FD;
                export const k_EMsgGCStorePurchaseCancelResponse = 0x9CB;
                export const k_EMsgGCToGCBannedWordListBroadcast = 0x9D2;
                export const k_EMsgGCToGCBroadcastConsoleCommand = 0x9D9;
                export const k_EMsgGCToGCIsTrustedServerResponse = 0x9D8;
                export const k_EMsgGC_IncrementKillCountResponse = 0x433;
                export const k_EMsgGCCustomizeItemTextureResponse = 0x400;
                export const k_EMsgGCDev_SchemaReservationRequest = 0x7D4;
                export const k_EMsgGCItemAcknowledged__DEPRECATED = 0x426;
                export const k_EMsgGCRequestAnnouncementsResponse = 0x9DE;
                export const k_EMsgGCServerBrowser_FavoriteServer = 0x641;
                export const k_EMsgGCStorePurchaseInit_DEPRECATED = 0x9C6;
                export const k_EMsgGC_IncrementKillCountAttribute = 0x432;
                export const k_EMsgGCItemCustomizationNotification = 0x442;
                export const k_EMsgGCItemPreviewExpireNotification = 0x6AA;
                export const k_EMsgGCServerBrowser_BlacklistServer = 0x642;
                export const k_EMsgGCStorePurchaseFinalizeResponse = 0x9C9;
                export const k_EMsgGCStorePurchaseQueryTxnResponse = 0x9CD;
                export const k_EMsgGC_RevolvingLootList_DEPRECATED = 0x412;
                export const k_EMsgGCAddSocketToBaseItem_DEPRECATED = 0x3F8;
                export const k_EMsgGCRemoveUniqueCraftIndexResponse = 0x420;
                export const k_EMsgGCUserTrackTimePlayedConsecutively = 0x441;
                export const k_EMsgGCItemPreviewItemBoughtNotification = 0x6AB;
                export const k_EMsgGCAddItemToSocketResponse_DEPRECATED = 0x3F7;
                export const k_EMsgGCAddSocketToItemResponse_DEPRECATED = 0x3FA;
                export const k_EMsgGCRemoveSocketItemResponse_DEPRECATED = 0x3FE;
                export const k_EMsgGCStorePurchaseInitResponse_DEPRECATED = 0x9C7;
            }
            export namespace EGCToGCMsg {
                export const k_EGCToGCMsgRouted = 0x98;
                export const k_EGCToGCMsgMasterAck = 0x96;
                export const k_EMsgUpdateSessionIP = 0x9A;
                export const k_EMsgRequestSessionIP = 0x9B;
                export const k_EGCToGCMsgRoutedReply = 0x99;
                export const k_EGCToGCMsgMasterAckResponse = 0x97;
                export const k_EMsgRequestSessionIPResponse = 0x9C;
                export const k_EGCToGCMsgMasterStartupComplete = 0x9D;
            }
            export namespace Explosions {
                export const expRandom = 0x0;
                export const expDirected = 0x1;
                export const expUsePrecise = 0x2;
            }
            export namespace HitGroup_t {
                export const HITGROUP_GEAR = 0xA;
                export const HITGROUP_HEAD = 0x1;
                export const HITGROUP_NECK = 0x8;
                export const HITGROUP_CHEST = 0x2;
                export const HITGROUP_COUNT = 0xC;
                export const HITGROUP_UNUSED = 0x9;
                export const HITGROUP_GENERIC = 0x0;
                export const HITGROUP_INVALID = -0x1;
                export const HITGROUP_LEFTARM = 0x4;
                export const HITGROUP_LEFTLEG = 0x6;
                export const HITGROUP_SPECIAL = 0xB;
                export const HITGROUP_STOMACH = 0x3;
                export const HITGROUP_RIGHTARM = 0x5;
                export const HITGROUP_RIGHTLEG = 0x7;
            }
            export namespace MoveType_t {
                export const MOVETYPE_FLY = 0x3;
                export const MOVETYPE_LAST = 0xB;
                export const MOVETYPE_NONE = 0x0;
                export const MOVETYPE_PUSH = 0x6;
                export const MOVETYPE_WALK = 0x2;
                export const MOVETYPE_CUSTOM = 0xA;
                export const MOVETYPE_LADDER = 0x9;
                export const MOVETYPE_NOCLIP = 0x7;
                export const MOVETYPE_INVALID = 0xB;
                export const MOVETYPE_MAX_BITS = 0x5;
                export const MOVETYPE_OBSERVER = 0x8;
                export const MOVETYPE_OBSOLETE = 0x1;
                export const MOVETYPE_VPHYSICS = 0x5;
                export const MOVETYPE_FLYGRAVITY = 0x4;
            }
            export namespace NavDirType {
                export const EAST = 0x1;
                export const WEST = 0x3;
                export const NORTH = 0x0;
                export const SOUTH = 0x2;
                export const NUM_NAV_DIR_TYPE_DIRECTIONS = 0x4;
            }
            export namespace NavScope_t {
                export const eAir = 0x1;
                export const eCount = 0x2;
                export const eFirst = 0x0;
                export const eGround = 0x0;
                export const eInvalid = 0xFF;
            }
            export namespace RenderFx_t {
                export const kRenderFxMax = 0x11;
                export const kRenderFxNone = 0x0;
                export const kRenderFxFadeIn = 0xF;
                export const kRenderFxFadeOut = 0xE;
                export const kRenderFxFadeFast = 0x6;
                export const kRenderFxFadeSlow = 0x5;
                export const kRenderFxPulseFast = 0x2;
                export const kRenderFxPulseSlow = 0x1;
                export const kRenderFxSolidFast = 0x8;
                export const kRenderFxSolidSlow = 0x7;
                export const kRenderFxStrobeFast = 0xA;
                export const kRenderFxStrobeSlow = 0x9;
                export const kRenderFxFlickerFast = 0xD;
                export const kRenderFxFlickerSlow = 0xC;
                export const kRenderFxStrobeFaster = 0xB;
                export const kRenderFxPulseFastWide = 0x4;
                export const kRenderFxPulseSlowWide = 0x3;
                export const kRenderFxPulseFastWider = 0x10;
            }
            export namespace TRAIN_CODE {
                export const TRAIN_SAFE = 0x0;
                export const TRAIN_BLOCKING = 0x1;
                export const TRAIN_FOLLOWING = 0x2;
            }
            export namespace AmmoFlags_t {
                export const AMMO_FLAG_MAX = 0x2;
                export const AMMO_FORCE_DROP_IF_CARRIED = 0x1;
                export const AMMO_RESERVE_STAYS_WITH_WEAPON = 0x2;
            }
            export namespace DIALOG_TYPE {
                export const DIALOG_MSG = 0x0;
                export const DIALOG_MENU = 0x1;
                export const DIALOG_TEXT = 0x2;
                export const DIALOG_ENTRY = 0x3;
                export const DIALOG_ASKCONNECT = 0x4;
            }
            export namespace DoorState_t {
                export const DOOR_STATE_AJAR = 0x4;
                export const DOOR_STATE_OPEN = 0x2;
                export const DOOR_STATE_CLOSED = 0x0;
                export const DOOR_STATE_CLOSING = 0x3;
                export const DOOR_STATE_OPENING = 0x1;
            }
            export namespace EWeaponType {
                export const EWT_C4 = 0x7;
                export const EWT_Knife = 0x0;
                export const EWT_Rifle = 0x3;
                export const EWT_Pistol = 0x1;
                export const EWT_Grenade = 0x8;
                export const EWT_Shotgun = 0x4;
                export const EWT_Unknown = 0xB;
                export const EWT_Equipment = 0x9;
                export const EWT_MachineGun = 0x6;
                export const EWT_SniperRifle = 0x5;
                export const EWT_StackableItem = 0xA;
                export const EWT_SubMachineGun = 0x2;
            }
            export namespace LifeState_t {
                export const LIFE_DEAD = 0x2;
                export const LIFE_ALIVE = 0x0;
                export const LIFE_DYING = 0x1;
                export const NUM_LIFESTATES = 0x5;
                export const LIFE_RESPAWNING = 0x4;
                export const LIFE_RESPAWNABLE = 0x3;
            }
            export namespace MedalRank_t {
                export const MEDAL_RANK_GOLD = 0x3;
                export const MEDAL_RANK_NONE = 0x0;
                export const MEDAL_RANK_COUNT = 0x4;
                export const MEDAL_RANK_BRONZE = 0x1;
                export const MEDAL_RANK_SILVER = 0x2;
            }
            export namespace SolidType_t {
                export const SOLID_BSP = 0x1;
                export const SOLID_OBB = 0x3;
                export const SOLID_BBOX = 0x2;
                export const SOLID_LAST = 0x9;
                export const SOLID_NONE = 0x0;
                export const SOLID_POINT = 0x5;
                export const SOLID_SPHERE = 0x4;
                export const SOLID_CAPSULE = 0x7;
                export const SOLID_CYLINDER = 0x8;
                export const SOLID_VPHYSICS = 0x6;
            }
            export namespace doorCheck_e {
                export const DOOR_CHECK_FULL = 0x2;
                export const DOOR_CHECK_FORWARD = 0x0;
                export const DOOR_CHECK_BACKWARD = 0x1;
            }
            export namespace gear_slot_t {
                export const GEAR_SLOT_C4 = 0x4;
                export const GEAR_SLOT_LAST = 0xC;
                export const GEAR_SLOT_COUNT = 0xD;
                export const GEAR_SLOT_FIRST = 0x0;
                export const GEAR_SLOT_KNIFE = 0x2;
                export const GEAR_SLOT_RIFLE = 0x0;
                export const GEAR_SLOT_BOOSTS = 0xB;
                export const GEAR_SLOT_PISTOL = 0x1;
                export const GEAR_SLOT_INVALID = -0x1;
                export const GEAR_SLOT_UTILITY = 0xC;
                export const GEAR_SLOT_GRENADES = 0x3;
                export const GEAR_SLOT_RESERVED_SLOT6 = 0x5;
                export const GEAR_SLOT_RESERVED_SLOT7 = 0x6;
                export const GEAR_SLOT_RESERVED_SLOT8 = 0x7;
                export const GEAR_SLOT_RESERVED_SLOT9 = 0x8;
                export const GEAR_SLOT_RESERVED_SLOT10 = 0x9;
                export const GEAR_SLOT_RESERVED_SLOT11 = 0xA;
            }
            export namespace CLC_Messages {
                export const clc_Move = 0x15;
                export const clc_VoiceData = 0x16;
                export const clc_ClientInfo = 0x14;
                export const clc_Diagnostic = 0x25;
                export const clc_HltvReplay = 0x24;
                export const clc_BaselineAck = 0x17;
                export const clc_CmdKeyValues = 0x22;
                export const clc_RequestPause = 0x21;
                export const clc_ServerStatus = 0x1F;
                export const clc_LoadingProgress = 0x1B;
                export const clc_RespondCvarValue = 0x19;
                export const clc_RconServerDetails = 0x23;
                export const clc_SplitPlayerConnect = 0x1C;
                export const clc_SplitPlayerDisconnect = 0x1E;
            }
            export namespace CSWeaponMode {
                export const Primary_Mode = 0x0;
                export const Secondary_Mode = 0x1;
                export const WeaponMode_MAX = 0x2;
            }
            export namespace CSWeaponType {
                export const WEAPONTYPE_C4 = 0x7;
                export const WEAPONTYPE_KNIFE = 0x0;
                export const WEAPONTYPE_RIFLE = 0x3;
                export const WEAPONTYPE_TASER = 0x8;
                export const WEAPONTYPE_PISTOL = 0x1;
                export const WEAPONTYPE_GRENADE = 0x9;
                export const WEAPONTYPE_SHOTGUN = 0x4;
                export const WEAPONTYPE_UNKNOWN = 0xC;
                export const WEAPONTYPE_EQUIPMENT = 0xA;
                export const WEAPONTYPE_MACHINEGUN = 0x6;
                export const WEAPONTYPE_SNIPER_RIFLE = 0x5;
                export const WEAPONTYPE_STACKABLEITEM = 0xB;
                export const WEAPONTYPE_SUBMACHINEGUN = 0x2;
            }
            export namespace DecalFlags_t {
                export const eAll = 0xFFFFFFFF;
                export const eNone = 0x0;
                export const eCannotClear = 0x1;
                export const eAllButCannotClear = 0xFFFFFFFE;
                export const eDecalProjectToBackfaces = 0x2;
            }
            export namespace EGCSystemMsg {
                export const k_EGCMsgMulti = 0x1;
                export const k_EGCMsgInvalid = 0x0;
                export const k_EGCMsgPostAlert = 0x4B;
                export const k_EGCMsgSendEmail = 0x57;
                export const k_EGCMsgWGRequest = 0x39;
                export const k_EGCMsgConCommand = 0x34;
                export const k_EGCMsgSetOptions = 0xE2;
                export const k_EGCMsgSystemBase = 0x32;
                export const k_EGCMsgWGResponse = 0x3A;
                export const k_EGCMsgGetCommands = 0x4E;
                export const k_EGCMsgGetLicenses = 0x4C;
                export const k_EGCMsgStopPlaying = 0x36;
                export const k_EGCMsgSystemBase2 = 0x1F4;
                export const k_EGCMsgFindAccounts = 0x4A;
                export const k_EGCMsgGenericReply = 0xA;
                export const k_EGCMsgGetUserStats = 0x4D;
                export const k_EGCMsgMemCachedGet = 0xC8;
                export const k_EGCMsgMemCachedSet = 0xCA;
                export const k_EGCMsgMultiplexMsg = 0x61;
                export const k_EGCMsgPreTestSetup = 0x45;
                export const k_EGCMsgStartPlaying = 0x35;
                export const k_EGCMsgGetIPLocation = 0x52;
                export const k_EGCMsgReportMetrics = 0x218;
                export const k_EGCMsgUpdateSession = 0x1F7;
                export const k_EGCMsgAddFreeLicense = 0x50;
                export const k_EGCMsgAppInfoUpdated = 0x3F;
                export const k_EGCMsgGetClanDetails = 0x21A;
                export const k_EGCMsgGetSystemStats = 0x55;
                export const k_EGCMsgGrantGuestPass = 0x5B;
                export const k_EGCMsgMemCachedStats = 0xCC;
                export const k_EGCMsgStopGameserver = 0x38;
                export const k_EGCMsgCheckFriendship = 0x1F9;
                export const k_EGCMsgGetPersonaNames = 0x5F;
                export const k_EGCMsgMemCachedDelete = 0xCB;
                export const k_EGCMsgSendHTTPRequest = 0x43;
                export const k_EGCMsgStartGameserver = 0x37;
                export const k_EGCMsgValidateSession = 0x40;
                export const k_EGCMsgGetEmailTemplate = 0x59;
                export const k_EGCMsgWebAPIJobRequest = 0x66;
                export const k_EGCMsgAppCheersReceived = 0x215;
                export const k_EGCMsgGetAccountDetails = 0x5D;
                export const k_EGCMsgInviteUserToLobby = 0x20B;
                export const k_EGCMsgSendEmailResponse = 0x58;
                export const k_EGCMsgSystemStatsSchema = 0x54;
                export const k_EGCMsgAchievementAwarded = 0x33;
                export const k_EGCMsgDPPartnerMicroTxns = 0x200;
                export const k_EGCMsgMasterSetDirectory = 0xDC;
                export const k_EGCMsgSetOptionsResponse = 0xE3;
                export const k_EGCMsgDirectServiceMethod = 0x213;
                export const k_EGCMsgGetCommandsResponse = 0x4F;
                export const k_EGCMsgRecordSupportAction = 0x46;
                export const k_EGCMsgGetUserStatsResponse = 0x3E;
                export const k_EGCMsgMemCachedGetResponse = 0xC9;
                export const k_EGCMsgMultiplexMsgResponse = 0x62;
                export const k_EGCMsgGetIPLocationResponse = 0x53;
                export const k_EGCMsgGetPartnerAccountLink = 0x1FB;
                export const k_EGCMsgReportMetricsResponse = 0x219;
                export const k_EGCMsgVacVerificationChange = 0x206;
                export const k_EGCMsgAddFreeLicenseResponse = 0x51;
                export const k_EGCMsgGetClanDetailsResponse = 0x21B;
                export const k_EGCMsgGetPurchaseTrustStatus = 0x1F5;
                export const k_EGCMsgGetSystemStatsResponse = 0x56;
                export const k_EGCMsgGetUserGameStatsSchema = 0x3B;
                export const k_EGCMsgGetUserStatsDEPRECATED = 0x3D;
                export const k_EGCMsgGrantGuestPassResponse = 0x5C;
                export const k_EGCMsgLookupAccountFromInput = 0x42;
                export const k_EGCMsgMasterSetWebAPIRouting = 0xDE;
                export const k_EGCMsgMemCachedStatsResponse = 0xCD;
                export const k_EGCMsgReceiveInterAppMessage = 0x49;
                export const k_EGCMsgCheckFriendshipResponse = 0x1FA;
                export const k_EGCMsgGetPersonaNamesResponse = 0x60;
                export const k_EGCMsgSendHTTPRequestResponse = 0x44;
                export const k_EGCMsgValidateSessionResponse = 0x41;
                export const k_EGCMsgAccountPhoneNumberChange = 0x207;
                export const k_EGCMsgAppCheersGetAllowedTypes = 0x216;
                export const k_EGCMsgGCAccountVacStatusChange = 0x1F8;
                export const k_EGCMsgGetEmailTemplateResponse = 0x5A;
                export const k_EGCMsgWebAPIRegisterInterfaces = 0x65;
                export const k_EGCMsgGetAccountDetailsResponse = 0x5E;
                export const k_EGCMsgMasterSetClientMsgRouting = 0xE0;
                export const k_EGCMsgDPPartnerMicroTxnsResponse = 0x201;
                export const k_EGCMsgMasterSetDirectoryResponse = 0xDD;
                export const k_EGCMsgDirectServiceMethodResponse = 0x214;
                export const k_EGCMsgGetAccountDetails_DEPRECATED = 0x47;
                export const k_EGCMsgWebAPIJobRequestHttpResponse = 0x68;
                export const k_EGCMsgGetPartnerAccountLinkResponse = 0x1FC;
                export const k_EGCMsgGetPurchaseTrustStatusResponse = 0x1F6;
                export const k_EGCMsgGetUserGameStatsSchemaResponse = 0x3C;
                export const k_EGCMsgMasterSetWebAPIRoutingResponse = 0xDF;
                export const k_EGCMsgWebAPIJobRequestForwardResponse = 0x69;
                export const k_EGCMsgAppCheersGetAllowedTypesResponse = 0x217;
                export const k_EGCMsgGetGamePersonalDataEntriesRequest = 0x20E;
                export const k_EGCMsgMasterSetClientMsgRoutingResponse = 0xE1;
                export const k_EGCMsgRecurringSubscriptionStatusChange = 0x212;
                export const k_EGCMsgGetGamePersonalDataEntriesResponse = 0x20F;
                export const k_EGCMsgGetGamePersonalDataCategoriesRequest = 0x20C;
                export const k_EGCMsgGetGamePersonalDataCategoriesResponse = 0x20D;
                export const k_EGCMsgTerminateGamePersonalDataEntriesRequest = 0x210;
                export const k_EGCMsgTerminateGamePersonalDataEntriesResponse = 0x211;
            }
            export namespace EKillTypes_t {
                export const KILL_BURN = 0x4;
                export const KILL_NONE = 0x0;
                export const KILL_BLAST = 0x3;
                export const KILL_SHOCK = 0x6;
                export const KILL_SLASH = 0x5;
                export const KILL_DEFAULT = 0x1;
                export const KILL_HEADSHOT = 0x2;
                export const KILLTYPE_COUNT = 0x7;
            }
            export namespace EUnlockStyle {
                export const k_UnlockStyle_Succeeded = 0x0;
                export const k_UnlockStyle_Failed_PreReq = 0x1;
                export const k_UnlockStyle_Failed_CantAfford = 0x2;
                export const k_UnlockStyle_Failed_CantCommit = 0x3;
                export const k_UnlockStyle_Failed_CantLockCache = 0x4;
                export const k_UnlockStyle_Failed_CantAffordAttrib = 0x5;
            }
            export namespace GLOBALESTATE {
                export const GLOBAL_ON = 0x1;
                export const GLOBAL_OFF = 0x0;
                export const GLOBAL_DEAD = 0x2;
            }
            export namespace NET_Messages {
                export const net_NOP = 0x0;
                export const net_Tick = 0x4;
                export const net_SetConVar = 0x6;
                export const net_StringCmd = 0x5;
                export const net_SignonState = 0x7;
                export const net_DebugOverlay = 0xF;
                export const net_SpawnGroup_Load = 0x8;
                export const net_SplitScreenUser = 0x3;
                export const net_Disconnect_Legacy = 0x1;
                export const net_SpawnGroup_Unload = 0xC;
                export const net_SpawnGroup_LoadCompleted = 0xD;
                export const net_SpawnGroup_ManifestUpdate = 0x9;
                export const net_SpawnGroup_SetCreationTick = 0xB;
            }
            export namespace PrefetchType {
                export const PFT_SOUND = 0x0;
            }
            export namespace RenderMode_t {
                export const kRenderNone = 0x2;
                export const kRenderNormal = 0x0;
                export const kRenderModeCount = 0x3;
                export const kRenderTransAlpha = 0x1;
            }
            export namespace SVC_Messages {
                export const svc_Menu = 0x39;
                export const svc_Print = 0x30;
                export const svc_Sounds = 0x31;
                export const svc_SetView = 0x32;
                export const svc_BSPDecal = 0x35;
                export const svc_PeerList = 0x3C;
                export const svc_Prefetch = 0x38;
                export const svc_SetPause = 0x2B;
                export const svc_UserCmds = 0x4C;
                export const svc_ClassInfo = 0x2A;
                export const svc_StopSound = 0x3B;
                export const svc_VoiceData = 0x2F;
                export const svc_VoiceInit = 0x2E;
                export const svc_HLTVStatus = 0x3E;
                export const svc_ServerInfo = 0x28;
                export const svc_SplitScreen = 0x36;
                export const svc_UserMessage = 0x48;
                export const svc_CmdKeyValues = 0x34;
                export const svc_GetCvarValue = 0x3A;
                export const svc_EncryptedData = 0x4E;
                export const svc_ServerSteamID = 0x3F;
                export const svc_FullFrameSplit = 0x46;
                export const svc_PacketEntities = 0x37;
                export const svc_PacketReliable = 0x3D;
                export const svc_NextMsgPredicted = 0x4D;
                export const svc_Broadcast_Command = 0x4A;
                export const svc_CreateStringTable = 0x2C;
                export const svc_RconServerDetails = 0x47;
                export const svc_UpdateStringTable = 0x2D;
                export const svc_FlattenedSerializer = 0x29;
                export const svc_ClearAllStringTables = 0x33;
                export const svc_HltvFixupOperatorStatus = 0x4B;
            }
            export namespace ShadowType_t {
                export const SHADOWS_NONE = 0x0;
                export const SHADOWS_SIMPLE = 0x1;
            }
            export namespace ShardSolid_t {
                export const SHARD_SOLID = 0x0;
                export const SHARD_DEBRIS = 0x1;
            }
            export namespace StanceType_t {
                export const NUM_STANCES = 0x3;
                export const STANCE_PRONE = 0x2;
                export const STANCE_CURRENT = -0x1;
                export const STANCE_DEFAULT = 0x0;
                export const STANCE_CROUCHING = 0x1;
            }
            export namespace TOGGLE_STATE {
                export const DOOR_OPEN = 0x0;
                export const TS_AT_TOP = 0x0;
                export const DOOR_CLOSED = 0x1;
                export const TS_GOING_UP = 0x2;
                export const DOOR_CLOSING = 0x3;
                export const DOOR_OPENING = 0x2;
                export const TS_AT_BOTTOM = 0x1;
                export const TS_GOING_DOWN = 0x3;
            }
            export namespace WaterLevel_t {
                export const WL_Feet = 0x1;
                export const WL_Chest = 0x4;
                export const WL_Count = 0x6;
                export const WL_Knees = 0x2;
                export const WL_Waist = 0x3;
                export const WL_NotInWater = 0x0;
                export const WL_FullyUnderwater = 0x5;
            }
            export namespace CSPlayerState {
                export const STATE_ACTIVE = 0x0;
                export const STATE_DORMANT = 0x8;
                export const STATE_WELCOME = 0x1;
                export const STATE_DEATH_ANIM = 0x4;
                export const NUM_PLAYER_STATES = 0x9;
                export const STATE_PICKINGTEAM = 0x2;
                export const STATE_PICKINGCLASS = 0x3;
                export const STATE_OBSERVER_MODE = 0x6;
                export const STATE_GUNGAME_RESPAWN = 0x7;
                export const STATE_DEATH_WAIT_FOR_KEY = 0x5;
            }
            export namespace DamageTypes_t {
                export const DMG_ACID = 0x40000;
                export const DMG_BURN = 0x8;
                export const DMG_CLUB = 0x80;
                export const DMG_FALL = 0x20;
                export const DMG_BLAST = 0x40;
                export const DMG_CRUSH = 0x1;
                export const DMG_DROWN = 0x4000;
                export const DMG_SHOCK = 0x100;
                export const DMG_SLASH = 0x4;
                export const DMG_SONIC = 0x200;
                export const DMG_BULLET = 0x2;
                export const DMG_POISON = 0x8000;
                export const DMG_GENERIC = 0x0;
                export const DMG_VEHICLE = 0x10;
                export const DMG_BUCKSHOT = 0x800;
                export const DMG_DISSOLVE = 0x2000;
                export const DMG_HEADSHOT = 0x80000;
                export const DMG_RADIATION = 0x10000;
                export const DMG_ENERGYBEAM = 0x400;
                export const DMG_DROWNRECOVER = 0x20000;
                export const DMG_BLAST_SURFACE = 0x1000;
                export const DMG_LASTGENERICFLAG = 0x40000;
            }
            export namespace Disposition_t {
                export const D_ER = 0x0;
                export const D_FR = 0x2;
                export const D_HT = 0x1;
                export const D_LI = 0x3;
                export const D_NU = 0x4;
                export const D_FEAR = 0x2;
                export const D_HATE = 0x1;
                export const D_LIKE = 0x3;
                export const D_ERROR = 0x0;
                export const D_NEUTRAL = 0x4;
            }
            export namespace EDemoCommands {
                export const DEM_Max = 0x13;
                export const DEM_Stop = 0x0;
                export const DEM_Error = -0x1;
                export const DEM_Packet = 0x7;
                export const DEM_UserCmd = 0xC;
                export const DEM_FileInfo = 0x2;
                export const DEM_Recovery = 0x12;
                export const DEM_SaveGame = 0xE;
                export const DEM_SyncTick = 0x3;
                export const DEM_ClassInfo = 0x5;
                export const DEM_ConsoleCmd = 0x9;
                export const DEM_CustomData = 0xA;
                export const DEM_FileHeader = 0x1;
                export const DEM_FullPacket = 0xD;
                export const DEM_SendTables = 0x4;
                export const DEM_SpawnGroups = 0xF;
                export const DEM_IsCompressed = 0x40;
                export const DEM_SignonPacket = 0x8;
                export const DEM_StringTables = 0x6;
                export const DEM_AnimationData = 0x10;
                export const DEM_AnimationHeader = 0x11;
                export const DEM_CustomDataCallbacks = 0xB;
            }
            export namespace FixAngleSet_t {
                export const _None = 0x0;
                export const Absolute = 0x1;
                export const Relative = 0x2;
            }
            export namespace GrenadeType_t {
                export const GRENADE_TYPE_FIRE = 0x2;
                export const GRENADE_TYPE_DECOY = 0x3;
                export const GRENADE_TYPE_FLASH = 0x1;
                export const GRENADE_TYPE_SMOKE = 0x4;
                export const GRENADE_TYPE_TOTAL = 0x5;
                export const GRENADE_TYPE_EXPLOSIVE = 0x0;
            }
            export namespace MoveCollide_t {
                export const MOVECOLLIDE_COUNT = 0x4;
                export const MOVECOLLIDE_DEFAULT = 0x0;
                export const MOVECOLLIDE_MAX_BITS = 0x3;
                export const MOVECOLLIDE_FLY_SLIDE = 0x3;
                export const MOVECOLLIDE_FLY_BOUNCE = 0x1;
                export const MOVECOLLIDE_FLY_CUSTOM = 0x2;
            }
            export namespace SignonState_t {
                export const SIGNONSTATE_NEW = 0x3;
                export const SIGNONSTATE_FULL = 0x6;
                export const SIGNONSTATE_NONE = 0x0;
                export const SIGNONSTATE_SPAWN = 0x5;
                export const SIGNONSTATE_PRESPAWN = 0x4;
                export const SIGNONSTATE_CHALLENGE = 0x1;
                export const SIGNONSTATE_CONNECTED = 0x2;
                export const SIGNONSTATE_CHANGELEVEL = 0x7;
            }
            export namespace WeaponSound_t {
                export const WEAPON_SOUND_DROP = 0x16;
                export const WEAPON_SOUND_EMPTY = 0x0;
                export const WEAPON_SOUND_IMPACT = 0xD;
                export const WEAPON_SOUND_RELOAD = 0x11;
                export const WEAPON_SOUND_SINGLE = 0x2;
                export const WEAPON_SOUND_REFLECT = 0xE;
                export const WEAPON_SOUND_ZOOM_IN = 0x13;
                export const WEAPON_SOUND_SPECIAL1 = 0x9;
                export const WEAPON_SOUND_SPECIAL2 = 0xA;
                export const WEAPON_SOUND_SPECIAL3 = 0xB;
                export const WEAPON_SOUND_ZOOM_OUT = 0x14;
                export const WEAPON_SOUND_MELEE_HIT = 0x5;
                export const WEAPON_SOUND_NUM_TYPES = 0x18;
                export const WEAPON_SOUND_RADIO_USE = 0x17;
                export const WEAPON_SOUND_MELEE_MISS = 0x4;
                export const WEAPON_SOUND_NEARLYEMPTY = 0xC;
                export const WEAPON_SOUND_MELEE_HIT_NPC = 0x8;
                export const WEAPON_SOUND_MOUSE_PRESSED = 0x15;
                export const WEAPON_SOUND_MELEE_HIT_WORLD = 0x6;
                export const WEAPON_SOUND_SECONDARY_EMPTY = 0x1;
                export const WEAPON_SOUND_SINGLE_ACCURATE = 0x12;
                export const WEAPON_SOUND_MELEE_HIT_PLAYER = 0x7;
                export const WEAPON_SOUND_SECONDARY_ATTACK = 0x3;
                export const WEAPON_SOUND_SECONDARY_IMPACT = 0xF;
                export const WEAPON_SOUND_SECONDARY_REFLECT = 0x10;
            }
            export namespace AmmoPosition_t {
                export const AMMO_POSITION_COUNT = 0x2;
                export const AMMO_POSITION_INVALID = -0x1;
                export const AMMO_POSITION_PRIMARY = 0x0;
                export const AMMO_POSITION_SECONDARY = 0x1;
            }
            export namespace AnimLoopMode_t {
                export const ANIM_LOOP_MODE_COUNT = 0x3;
                export const ANIM_LOOP_MODE_INVALID = -0x1;
                export const ANIM_LOOP_MODE_LOOPING = 0x1;
                export const ANIM_LOOP_MODE_NOT_LOOPING = 0x0;
                export const ANIM_LOOP_MODE_USE_SEQUENCE_SETTINGS = 0x2;
            }
            export namespace CSWeaponNameID {
                export const WEAPONID_C4 = 0x29;
                export const WEAPONID_AUG = 0xF;
                export const WEAPONID_AWP = 0x1C;
                export const WEAPONID_MP7 = 0x14;
                export const WEAPONID_MP9 = 0x15;
                export const WEAPONID_P90 = 0x16;
                export const WEAPONID_AK47 = 0xA;
                export const WEAPONID_M249 = 0x20;
                export const WEAPONID_M4A1 = 0xB;
                export const WEAPONID_MAG7 = 0x18;
                export const WEAPONID_NOVA = 0x19;
                export const WEAPONID_P250 = 0x6;
                export const WEAPONID_TEC9 = 0x8;
                export const WEAPONID_BIZON = 0x11;
                export const WEAPONID_CZ75A = 0x2;
                export const WEAPONID_DECOY = 0x23;
                export const WEAPONID_ELITE = 0x3;
                export const WEAPONID_FAMAS = 0xD;
                export const WEAPONID_G3SG1 = 0x1E;
                export const WEAPONID_GLOCK = 0x0;
                export const WEAPONID_KNIFE = 0x2B;
                export const WEAPONID_MAC10 = 0x12;
                export const WEAPONID_MP5SD = 0x13;
                export const WEAPONID_NEGEV = 0x21;
                export const WEAPONID_SG556 = 0x10;
                export const WEAPONID_SSG08 = 0x1D;
                export const WEAPONID_TASER = 0x22;
                export const WEAPONID_UMP45 = 0x17;
                export const WEAPONID_DEAGLE = 0x4;
                export const WEAPONID_SCAR20 = 0x1F;
                export const WEAPONID_XM1014 = 0x1B;
                export const WEAPONID_BAYONET = 0x31;
                export const WEAPONID_GALILAR = 0xE;
                export const WEAPONID_HKP2000 = 0x1;
                export const WEAPONID_KNIFE_T = 0x2C;
                export const WEAPONID_MOLOTOV = 0x27;
                export const WEAPONID_UNKNOWN = 0x41;
                export const WEAPONID_REVOLVER = 0x7;
                export const WEAPONID_SAWEDOFF = 0x1A;
                export const WEAPONID_FIVESEVEN = 0x5;
                export const WEAPONID_FLASHBANG = 0x24;
                export const WEAPONID_HEGRENADE = 0x25;
                export const WEAPONID_KNIFE_CSS = 0x2D;
                export const WEAPONID_KNIFE_GUT = 0x2F;
                export const WEAPONID_HEALTHSHOT = 0x2A;
                export const WEAPONID_INCGRENADE = 0x26;
                export const WEAPONID_KNIFE_CORD = 0x38;
                export const WEAPONID_KNIFE_FLIP = 0x2E;
                export const WEAPONID_KNIFE_PUSH = 0x37;
                export const WEAPONID_KNIFE_CANIS = 0x39;
                export const WEAPONID_KNIFE_KUKRI = 0x40;
                export const WEAPONID_KNIFE_URSUS = 0x3A;
                export const WEAPONID_SMOKEGRENADE = 0x28;
                export const WEAPONID_USP_SILENCER = 0x9;
                export const WEAPONID_KNIFE_OUTDOOR = 0x3C;
                export const WEAPONID_M4A1_SILENCER = 0xC;
                export const WEAPONID_KNIFE_FALCHION = 0x34;
                export const WEAPONID_KNIFE_KARAMBIT = 0x30;
                export const WEAPONID_KNIFE_SKELETON = 0x3F;
                export const WEAPONID_KNIFE_STILETTO = 0x3D;
                export const WEAPONID_KNIFE_TACTICAL = 0x33;
                export const WEAPONID_KNIFE_BUTTERFLY = 0x36;
                export const WEAPONID_KNIFE_M9_BAYONET = 0x32;
                export const WEAPONID_KNIFE_WIDOWMAKER = 0x3E;
                export const WEAPONID_KNIFE_SURVIVAL_BOWIE = 0x35;
                export const WEAPONID_KNIFE_GYPSY_JACKKNIFE = 0x3B;
            }
            export namespace EClientUIEvent {
                export const EClientUIEvent_Invalid = 0x0;
                export const EClientUIEvent_FireOutput = 0x2;
                export const EClientUIEvent_DialogFinished = 0x1;
            }
            export namespace EGCMsgResponse {
                export const k_EGCMsgResponseOK = 0x0;
                export const k_EGCMsgLimitExceeded = 0x9;
                export const k_EGCMsgFailedToCreate = 0x8;
                export const k_EGCMsgResponseDenied = 0x1;
                export const k_EGCMsgResponseInvalid = 0x4;
                export const k_EGCMsgResponseNoMatch = 0x5;
                export const k_EGCMsgResponseTimeout = 0x3;
                export const k_EGCMsgCommitUnfinalized = 0xA;
                export const k_EGCMsgResponseNotLoggedOn = 0x7;
                export const k_EGCMsgResponseServerError = 0x2;
                export const k_EGCMsgResponseUnknownError = 0x6;
            }
            export namespace EInButtonState {
                export const IN_BUTTON_UP = 0x0;
                export const IN_BUTTON_DOWN = 0x1;
                export const IN_BUTTON_DOWN_UP = 0x2;
                export const IN_BUTTON_UP_DOWN = 0x3;
                export const IN_BUTTON_UP_DOWN_UP = 0x4;
                export const IN_BUTTON_STATE_COUNT = 0x8;
                export const IN_BUTTON_DOWN_UP_DOWN = 0x5;
                export const IN_BUTTON_DOWN_UP_DOWN_UP = 0x6;
                export const IN_BUTTON_UP_DOWN_UP_DOWN = 0x7;
            }
            export namespace ETEProtobufIds {
                export const TE_DustId = 0x1A4;
                export const TE_FizzId = 0x19D;
                export const TE_DecalId = 0x19A;
                export const TE_SmokeId = 0x1AA;
                export const TE_ImpactId = 0x1A0;
                export const TE_SparksId = 0x1A6;
                export const TE_BubblesId = 0x198;
                export const TE_BeamEntsId = 0x193;
                export const TE_BeamRingId = 0x195;
                export const TE_ExplosionId = 0x1A3;
                export const TE_BeamPointsId = 0x194;
                export const TE_GlowSpriteId = 0x19F;
                export const TE_WorldDecalId = 0x19B;
                export const TE_BloodStreamId = 0x1A2;
                export const TE_BubbleTrailId = 0x199;
                export const TE_LargeFunnelId = 0x1A5;
                export const TE_MuzzleFlashId = 0x1A1;
                export const TE_PhysicsPropId = 0x1A7;
                export const TE_BeamEntPointId = 0x192;
                export const TE_EnergySplashId = 0x19C;
                export const TE_ArmorRicochetId = 0x191;
                export const TE_EffectDispatchId = 0x190;
                export const TE_ShatterSurfaceId = 0x19E;
            }
            export namespace InputBitMask_t {
                export const IN_ALL = -0x1;
                export const IN_USE = 0x20;
                export const IN_BACK = 0x10;
                export const IN_DUCK = 0x4;
                export const IN_JUMP = 0x2;
                export const IN_NONE = 0x0;
                export const IN_ZOOM = 0x400000000;
                export const IN_SCORE = 0x200000000;
                export const IN_SPEED = 0x10000;
                export const IN_ATTACK = 0x1;
                export const IN_RELOAD = 0x2000;
                export const IN_ATTACK2 = 0x800;
                export const IN_FORWARD = 0x8;
                export const IN_MOVELEFT = 0x200;
                export const IN_TURNLEFT = 0x80;
                export const IN_MOVERIGHT = 0x400;
                export const IN_TURNRIGHT = 0x100;
                export const IN_USEORRELOAD = 0x100000000;
                export const IN_JOYAUTOSPRINT = 0x20000;
                export const IN_LOOK_AT_WEAPON = 0x800000000;
                export const IN_FIRST_MOD_SPECIFIC_BIT = 0x100000000;
            }
            export namespace ObserverMode_t {
                export const OBS_MODE_NONE = 0x0;
                export const OBS_MODE_CHASE = 0x3;
                export const OBS_MODE_FIXED = 0x1;
                export const OBS_MODE_IN_EYE = 0x2;
                export const OBS_MODE_ROAMING = 0x4;
                export const NUM_OBSERVER_MODES = 0x5;
            }
            export namespace RequestPause_t {
                export const RP_PAUSE = 0x0;
                export const RP_UNPAUSE = 0x1;
                export const RP_TOGGLEPAUSE = 0x2;
            }
            export namespace RumbleEffect_t {
                export const RUMBLE_357 = 0x2;
                export const RUMBLE_AR2 = 0x4;
                export const RUMBLE_SMG1 = 0x3;
                export const RUMBLE_PISTOL = 0x1;
                export const RUMBLE_DMG_LOW = 0xF;
                export const RUMBLE_DMG_MED = 0x10;
                export const RUMBLE_INVALID = -0x1;
                export const RUMBLE_DMG_HIGH = 0x11;
                export const RUMBLE_STOP_ALL = 0x0;
                export const RUMBLE_FALL_LONG = 0x12;
                export const RUMBLE_FLAT_BOTH = 0xE;
                export const RUMBLE_FLAT_LEFT = 0xC;
                export const RUMBLE_FALL_SHORT = 0x13;
                export const RUMBLE_FLAT_RIGHT = 0xD;
                export const NUM_RUMBLE_EFFECTS = 0x19;
                export const RUMBLE_AIRBOAT_GUN = 0xA;
                export const RUMBLE_RPG_MISSILE = 0x8;
                export const RUMBLE_AR2_ALT_FIRE = 0x7;
                export const RUMBLE_CROWBAR_SWING = 0x9;
                export const RUMBLE_PHYSCANNON_LOW = 0x16;
                export const RUMBLE_SHOTGUN_DOUBLE = 0x6;
                export const RUMBLE_SHOTGUN_SINGLE = 0x5;
                export const RUMBLE_PHYSCANNON_HIGH = 0x18;
                export const RUMBLE_PHYSCANNON_OPEN = 0x14;
                export const RUMBLE_PHYSCANNON_PUNT = 0x15;
                export const RUMBLE_JEEP_ENGINE_LOOP = 0xB;
                export const RUMBLE_PHYSCANNON_MEDIUM = 0x17;
            }
            export namespace ShakeCommand_t {
                export const SHAKE_STOP = 0x1;
                export const SHAKE_START = 0x0;
                export const SHAKE_DURATION = 0x6;
                export const SHAKE_AMPLITUDE = 0x2;
                export const SHAKE_FREQUENCY = 0x3;
                export const SHAKE_START_NORUMBLE = 0x5;
                export const SHAKE_START_RUMBLEONLY = 0x4;
            }
            export namespace loadout_slot_t {
                export const LOADOUT_SLOT_C4 = 0x1;
                export const LOADOUT_SLOT_PET = 0x39;
                export const LOADOUT_SLOT_SMG0 = 0x8;
                export const LOADOUT_SLOT_SMG1 = 0x9;
                export const LOADOUT_SLOT_SMG2 = 0xA;
                export const LOADOUT_SLOT_SMG3 = 0xB;
                export const LOADOUT_SLOT_SMG4 = 0xC;
                export const LOADOUT_SLOT_SMG5 = 0xD;
                export const LOADOUT_SLOT_COUNT = 0x3A;
                export const LOADOUT_SLOT_MELEE = 0x0;
                export const LOADOUT_SLOT_MISC0 = 0x2F;
                export const LOADOUT_SLOT_MISC1 = 0x30;
                export const LOADOUT_SLOT_MISC2 = 0x31;
                export const LOADOUT_SLOT_MISC3 = 0x32;
                export const LOADOUT_SLOT_MISC4 = 0x33;
                export const LOADOUT_SLOT_MISC5 = 0x34;
                export const LOADOUT_SLOT_MISC6 = 0x35;
                export const LOADOUT_SLOT_FLAIR0 = 0x37;
                export const LOADOUT_SLOT_HEAVY0 = 0x14;
                export const LOADOUT_SLOT_HEAVY1 = 0x15;
                export const LOADOUT_SLOT_HEAVY2 = 0x16;
                export const LOADOUT_SLOT_HEAVY3 = 0x17;
                export const LOADOUT_SLOT_HEAVY4 = 0x18;
                export const LOADOUT_SLOT_HEAVY5 = 0x19;
                export const LOADOUT_SLOT_RIFLE0 = 0xE;
                export const LOADOUT_SLOT_RIFLE1 = 0xF;
                export const LOADOUT_SLOT_RIFLE2 = 0x10;
                export const LOADOUT_SLOT_RIFLE3 = 0x11;
                export const LOADOUT_SLOT_RIFLE4 = 0x12;
                export const LOADOUT_SLOT_RIFLE5 = 0x13;
                export const LOADOUT_SLOT_SPRAY0 = 0x38;
                export const LOADOUT_SLOT_INVALID = -0x1;
                export const LOADOUT_SLOT_GRENADE0 = 0x1A;
                export const LOADOUT_SLOT_GRENADE1 = 0x1B;
                export const LOADOUT_SLOT_GRENADE2 = 0x1C;
                export const LOADOUT_SLOT_GRENADE3 = 0x1D;
                export const LOADOUT_SLOT_GRENADE4 = 0x1E;
                export const LOADOUT_SLOT_GRENADE5 = 0x1F;
                export const LOADOUT_SLOT_MUSICKIT = 0x36;
                export const LOADOUT_SLOT_PROMOTED = -0x2;
                export const LOADOUT_SLOT_EQUIPMENT0 = 0x20;
                export const LOADOUT_SLOT_EQUIPMENT1 = 0x21;
                export const LOADOUT_SLOT_EQUIPMENT2 = 0x22;
                export const LOADOUT_SLOT_EQUIPMENT3 = 0x23;
                export const LOADOUT_SLOT_EQUIPMENT4 = 0x24;
                export const LOADOUT_SLOT_EQUIPMENT5 = 0x25;
                export const LOADOUT_SLOT_SECONDARY0 = 0x2;
                export const LOADOUT_SLOT_SECONDARY1 = 0x3;
                export const LOADOUT_SLOT_SECONDARY2 = 0x4;
                export const LOADOUT_SLOT_SECONDARY3 = 0x5;
                export const LOADOUT_SLOT_SECONDARY4 = 0x6;
                export const LOADOUT_SLOT_SECONDARY5 = 0x7;
                export const LOADOUT_SLOT_CLOTHING_HAT = 0x2B;
                export const LOADOUT_SLOT_LAST_COSMETIC = 0x29;
                export const LOADOUT_SLOT_CLOTHING_HANDS = 0x29;
                export const LOADOUT_SLOT_CLOTHING_TORSO = 0x2D;
                export const LOADOUT_SLOT_FIRST_COSMETIC = 0x29;
                export const LOADOUT_SLOT_CLOTHING_EYEWEAR = 0x2A;
                export const LOADOUT_SLOT_CLOTHING_FACEMASK = 0x28;
                export const LOADOUT_SLOT_LAST_WHEEL_WEAPON = 0x19;
                export const LOADOUT_SLOT_CLOTHING_LOWERBODY = 0x2C;
                export const LOADOUT_SLOT_FIRST_WHEEL_WEAPON = 0x2;
                export const LOADOUT_SLOT_LAST_ALL_CHARACTER = 0x39;
                export const LOADOUT_SLOT_LAST_WHEEL_GRENADE = 0x1F;
                export const LOADOUT_SLOT_CLOTHING_APPEARANCE = 0x2E;
                export const LOADOUT_SLOT_CLOTHING_CUSTOMHEAD = 0x27;
                export const LOADOUT_SLOT_FIRST_ALL_CHARACTER = 0x36;
                export const LOADOUT_SLOT_FIRST_WHEEL_GRENADE = 0x1A;
                export const LOADOUT_SLOT_LAST_PRIMARY_WEAPON = 0x19;
                export const LOADOUT_SLOT_FIRST_PRIMARY_WEAPON = 0x8;
                export const LOADOUT_SLOT_LAST_AUTO_BUY_WEAPON = 0x1;
                export const LOADOUT_SLOT_LAST_WHEEL_EQUIPMENT = 0x25;
                export const LOADOUT_SLOT_CLOTHING_CUSTOMPLAYER = 0x26;
                export const LOADOUT_SLOT_FIRST_AUTO_BUY_WEAPON = 0x0;
                export const LOADOUT_SLOT_FIRST_WHEEL_EQUIPMENT = 0x20;
            }
            export namespace C4LightEffect_t {
                export const eLightEffectNone = 0x0;
                export const eLightEffectDropped = 0x1;
                export const eLightEffectThirdPersonHeld = 0x2;
            }
            export namespace EBaseGameEvents {
                export const GE_PlaceDecalEvent = 0xC9;
                export const GE_SosStopSoundEvent = 0xD1;
                export const GE_SosStartSoundEvent = 0xD0;
                export const GE_ClothEffectAnimEvent = 0xD6;
                export const GE_ClearWorldDecalsEvent = 0xCA;
                export const GE_ClothStiffenAnimEvent = 0xD5;
                export const GE_SosStopSoundEventHash = 0xD4;
                export const GE_ClearEntityDecalsEvent = 0xCB;
                export const GE_SosSetSoundEventParams = 0xD2;
                export const GE_Source1LegacyGameEvent = 0xCF;
                export const GE_SosSetLibraryStackFields = 0xD3;
                export const GE_VDebugGameSessionIDEvent = 0xC8;
                export const GE_ClearDecalsForEntityEvent = 0xCC;
                export const GE_Source1LegacyListenEvents = 0xCE;
                export const GE_Source1LegacyGameEventList = 0xCD;
            }
            export namespace ECsgoGameEvents {
                export const GE_FireBulletsId = 0x1C4;
                export const GE_RadioIconEventId = 0x1C3;
                export const GE_PlayerAnimEventId = 0x1C2;
                export const GE_PlayerBulletHitId = 0x1C5;
            }
            export namespace EntityEffects_t {
                export const EF_NODRAW = 0x20;
                export const EF_MAX_BITS = 0xA;
                export const EF_NOSHADOW = 0x10;
                export const EF_NORECEIVESHADOW = 0x40;
                export const EF_PARENT_ANIMATES = 0x200;
                export const DEPRICATED_EF_NOINTERP = 0x8;
                export const EF_NODRAW_BUT_TRANSMIT = 0x400;
            }
            export namespace HierarchyType_t {
                export const HIERARCHY_BONE = 0x4;
                export const HIERARCHY_NONE = 0x0;
                export const HIERARCHY_ABSORIGIN = 0x3;
                export const HIERARCHY_ATTACHMENT = 0x2;
                export const HIERARCHY_BONE_MERGE = 0x1;
                export const HIERARCHY_TYPE_COUNT = 0x5;
            }
            export namespace ItemFlagTypes_t {
                export const ITEM_FLAG_NONE = 0x0;
                export const ITEM_FLAG_EXHAUSTIBLE = 0x10;
                export const ITEM_FLAG_LIMITINWORLD = 0x8;
                export const ITEM_FLAG_NOAUTORELOAD = 0x2;
                export const ITEM_FLAG_NOITEMPICKUP = 0x80;
                export const ITEM_FLAG_NOAMMOPICKUPS = 0x40;
                export const ITEM_FLAG_DOHITLOCATIONDMG = 0x20;
                export const ITEM_FLAG_NOAUTOSWITCHEMPTY = 0x4;
                export const ITEM_FLAG_CAN_SELECT_WITHOUT_AMMO = 0x1;
            }
            export namespace NavScopeFlags_t {
                export const eAir = 0x2;
                export const eAll = 0x3;
                export const eNone = 0x0;
                export const eGround = 0x1;
            }
            export namespace eSplinePushType {
                export const k_eSplinePushAway = 0x1;
                export const k_eSplinePushAlong = 0x0;
                export const k_eSplinePushTowards = 0x2;
            }
            export namespace navproperties_t {
                export const NAV_IGNORE = 0x1;
            }
            export namespace soundcommands_t {
                export const SOUNDCTRL_STOP = 0x2;
                export const SOUNDCTRL_DESTROY = 0x3;
                export const SOUNDCTRL_FADEOUT = 0x4;
                export const SOUNDCTRL_CHANGE_PITCH = 0x1;
                export const SOUNDCTRL_CHANGE_VOLUME = 0x0;
            }
            export namespace CSWeaponCategory {
                export const WEAPONCATEGORY_SMG = 0x3;
                export const WEAPONCATEGORY_COUNT = 0x6;
                export const WEAPONCATEGORY_HEAVY = 0x5;
                export const WEAPONCATEGORY_MELEE = 0x1;
                export const WEAPONCATEGORY_OTHER = 0x0;
                export const WEAPONCATEGORY_RIFLE = 0x4;
                export const WEAPONCATEGORY_SECONDARY = 0x2;
            }
            export namespace ChatIgnoreType_t {
                export const CHAT_IGNORE_ALL = 0x1;
                export const CHAT_IGNORE_NONE = 0x0;
                export const CHAT_IGNORE_TEAM = 0x2;
            }
            export namespace EChickenActivity {
                export const Run = 0x3;
                export const Feed = 0x9;
                export const Idle = 0x0;
                export const Land = 0x5;
                export const Walk = 0x2;
                export const Glide = 0x4;
                export const Panic = 0x6;
                export const Sleep = 0xA;
                export const Squat = 0x1;
                export const Trick = 0x7;
                export const Shoulder = 0xB;
                export const LowOnFood = 0xC;
                export const TurnInPlace = 0x8;
            }
            export namespace EGCBaseClientMsg {
                export const k_EMsgGCClientHello = 0xFA6;
                export const k_EMsgGCServerHello = 0xFA7;
                export const k_EMsgGCClientHelloPW = 0xFAC;
                export const k_EMsgGCClientHelloR2 = 0xFAD;
                export const k_EMsgGCClientHelloR3 = 0xFAE;
                export const k_EMsgGCClientHelloR4 = 0xFAF;
                export const k_EMsgGCClientWelcome = 0xFA4;
                export const k_EMsgGCServerWelcome = 0xFA5;
                export const k_EMsgGCClientHelloPartner = 0xFAB;
                export const k_EMsgGCClientConnectionStatus = 0xFA9;
                export const k_EMsgGCServerConnectionStatus = 0xFAA;
            }
            export namespace EHapticPulseType {
                export const VR_HAND_HAPTIC_PULSE_LIGHT = 0x0;
                export const VR_HAND_HAPTIC_PULSE_MEDIUM = 0x1;
                export const VR_HAND_HAPTIC_PULSE_STRONG = 0x2;
            }
            export namespace GCProtoBufMsgSrc {
                export const GCProtoBufMsgSrc_FromGC = 0x3;
                export const GCProtoBufMsgSrc_FromSystem = 0x1;
                export const GCProtoBufMsgSrc_FromSteamID = 0x2;
                export const GCProtoBufMsgSrc_ReplySystem = 0x4;
                export const GCProtoBufMsgSrc_Unspecified = 0x0;
            }
            export namespace HoverPoseFlags_t {
                export const eNone = 0x0;
                export const eAngles = 0x2;
                export const ePosition = 0x1;
            }
            export namespace NavAttributeEnum {
                export const NAV_MESH_RUN = 0x20;
                export const NAV_MESH_JUMP = 0x2;
                export const NAV_MESH_NONE = 0x0;
                export const NAV_MESH_STOP = 0x10;
                export const NAV_MESH_WALK = 0x40;
                export const NAV_MESH_AVOID = 0x80;
                export const NAV_MESH_STAND = 0x400;
                export const NAV_MESH_STAIRS = 0x1000;
                export const NAV_MESH_NON_ZUP = 0x8000;
                export const NAV_MESH_NO_JUMP = 0x8;
                export const NAV_MESH_NO_MERGE = 0x2000;
                export const NAV_MESH_DONT_HIDE = 0x200;
                export const NAV_MESH_TRANSIENT = 0x100;
                export const NAV_ATTR_LAST_INDEX = 0x3F;
                export const NAV_MESH_NO_HOSTAGES = 0x800;
                export const NAV_MESH_CRAWL_HEIGHT = 0x40000;
                export const NAV_MESH_OBSTACLE_TOP = 0x4000;
                export const NAV_MESH_CROUCH_HEIGHT = 0x10000;
                export const NAV_ATTR_FIRST_GAME_INDEX = 0x13;
                export const NAV_MESH_NON_ZUP_TRANSITION = 0x20000;
            }
            export namespace PARTICLE_MESSAGE {
                export const GAME_PARTICLE_MANAGER_EVENT_CREATE = 0x0;
                export const GAME_PARTICLE_MANAGER_EVENT_FROZEN = 0xC;
                export const GAME_PARTICLE_MANAGER_EVENT_UPDATE = 0x1;
                export const GAME_PARTICLE_MANAGER_EVENT_ADD_FAN = 0x24;
                export const GAME_PARTICLE_MANAGER_EVENT_DESTROY = 0x7;
                export const GAME_PARTICLE_MANAGER_EVENT_LATENCY = 0xA;
                export const GAME_PARTICLE_MANAGER_EVENT_RELEASE = 0x9;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_TEXT = 0x10;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_VDATA = 0x22;
                export const GAME_PARTICLE_MANAGER_EVENT_CAN_FREEZE = 0x19;
                export const GAME_PARTICLE_MANAGER_EVENT_REMOVE_FAN = 0x27;
                export const GAME_PARTICLE_MANAGER_EVENT_UPDATE_ENT = 0x5;
                export const GAME_PARTICLE_MANAGER_EVENT_UPDATE_FAN = 0x25;
                export const GAME_PARTICLE_MANAGER_EVENT_SHOULD_DRAW = 0xB;
                export const GAME_PARTICLE_MANAGER_EVENT_SKIP_TO_TIME = 0x18;
                export const GAME_PARTICLE_MANAGER_EVENT_DESTROY_NAMED = 0x17;
                export const GAME_PARTICLE_MANAGER_EVENT_UPDATE_OFFSET = 0x6;
                export const GAME_PARTICLE_MANAGER_EVENT_UPDATE_FORWARD = 0x2;
                export const GAME_PARTICLE_MANAGER_EVENT_UPDATE_FALLBACK = 0x4;
                export const GAME_PARTICLE_MANAGER_EVENT_FREEZE_INVOLVING = 0x1D;
                export const GAME_PARTICLE_MANAGER_EVENT_UPDATE_TRANSFORM = 0x1B;
                export const GAME_PARTICLE_MANAGER_EVENT_CREATE_SMOKE_GRID = 0x28;
                export const GAME_PARTICLE_MANAGER_EVENT_DESTROY_INVOLVING = 0x8;
                export const GAME_PARTICLE_MANAGER_EVENT_CREATE_PHYSICS_SIM = 0x20;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_CLUSTER_GROWTH = 0x26;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_FOW_PROPERTIES = 0xF;
                export const GAME_PARTICLE_MANAGER_EVENT_UPDATE_ORIENTATION = 0x3;
                export const GAME_PARTICLE_MANAGER_EVENT_DESTROY_PHYSICS_SIM = 0x21;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_OVERRIDE_TEXTURE = 0x29;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_SHOULD_CHECK_FOW = 0x11;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_MATERIAL_OVERRIDE = 0x23;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_TEXTURE_ATTRIBUTE = 0x14;
                export const GAME_PARTICLE_MANAGER_EVENT_UPDATE_ENTITY_POSITION = 0xE;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_CONTROL_POINT_MODEL = 0x12;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_NAMED_VALUE_CONTEXT = 0x1A;
                export const GAME_PARTICLE_MANAGER_EVENT_CLEAR_MODELLIST_OVERRIDE = 0x1F;
                export const GAME_PARTICLE_MANAGER_EVENT_FREEZE_TRANSITION_OVERRIDE = 0x1C;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_CONTROL_POINT_SNAPSHOT = 0x13;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_SCENE_OBJECT_GENERIC_FLAG = 0x15;
                export const GAME_PARTICLE_MANAGER_EVENT_ADD_MODELLIST_OVERRIDE_ELEMENT = 0x1E;
                export const GAME_PARTICLE_MANAGER_EVENT_CHANGE_CONTROL_POINT_ATTACHMENT = 0xD;
                export const GAME_PARTICLE_MANAGER_EVENT_SET_SCENE_OBJECT_TINT_AND_DESAT = 0x16;
            }
            export namespace BrushSolidities_e {
                export const BRUSHSOLID_NEVER = 0x1;
                export const BRUSHSOLID_ALWAYS = 0x2;
                export const BRUSHSOLID_TOGGLE = 0x0;
            }
            export namespace CanPlaySequence_t {
                export const CANNOT_PLAY = 0x0;
                export const CAN_PLAY_NOW = 0x1;
                export const CAN_PLAY_ENQUEUED = 0x2;
            }
            export namespace EBaseUserMessages {
                export const UM_Fade = 0x6A;
                export const UM_Shake = 0x78;
                export const UM_HudMsg = 0x6E;
                export const UM_Rumble = 0x74;
                export const UM_HudText = 0x6F;
                export const UM_SayText = 0x75;
                export const UM_TextMsg = 0x7C;
                export const UM_HudError = 0x92;
                export const UM_MAX_BASE = 0xC8;
                export const UM_ResetHUD = 0x73;
                export const UM_SayText2 = 0x76;
                export const UM_ShakeDir = 0x79;
                export const UM_ShowMenu = 0x86;
                export const UM_GameTitle = 0x6B;
                export const UM_SendAudio = 0x82;
                export const UM_VoiceMask = 0x80;
                export const UM_AmmoDenied = 0x84;
                export const UM_CreditsMsg = 0x87;
                export const UM_ItemPickup = 0x83;
                export const UM_ScreenTilt = 0x7D;
                export const UM_WaterShake = 0x7A;
                export const UM_ColoredText = 0x71;
                export const UM_UsageReport = 0xA8;
                export const UM_RequestState = 0x72;
                export const UM_ExtraUserData = 0xA4;
                export const UM_AudioParameter = 0x90;
                export const UM_SayTextChannel = 0x77;
                export const UM_UserSentBugBug = 0xA7;
                export const UM_AnimGraphUpdate = 0x95;
                export const UM_CustomGameEvent = 0x94;
                export const UM_ParticleManager = 0x91;
                export const UM_ServerFrameTime = 0x9A;
                export const UM_AchievementEvent = 0x65;
                export const UM_CameraTransition = 0x8F;
                export const UM_CurrentTimescale = 0x68;
                export const UM_DesiredTimescale = 0x69;
                export const UM_RequestDllStatus = 0x9C;
                export const UM_RequestInventory = 0xA0;
                export const UM_UpdateCssClasses = 0x99;
                export const UM_DllStatusResponse = 0x9F;
                export const UM_InventoryResponse = 0xA1;
                export const UM_RequestDiagnostic = 0xA2;
                export const UM_RequestUtilAction = 0x9D;
                export const UM_DiagnosticResponse = 0xA3;
                export const UM_UtilActionResponse = 0x9E;
                export const UM_HapticsManagerPulse = 0x96;
                export const UM_NotifyResponseFound = 0xA5;
                export const UM_RemoteServerCommand = 0xA9;
                export const UM_HapticsManagerEffect = 0x97;
                export const UM_LagCompensationError = 0x9B;
                export const UM_RemoteServerResponse = 0xAA;
                export const UM_CloseCaptionPlaceholder = 0x8E;
                export const UM_PlayResponseConditional = 0xA6;
            }
            export namespace EntFinderMethod_t {
                export const ENT_FIND_METHOD_RANDOM = 0x2;
                export const ENT_FIND_METHOD_NEAREST = 0x0;
                export const ENT_FIND_METHOD_FARTHEST = 0x1;
            }
            export namespace GC_BannedWordType {
                export const GC_BANNED_WORD_ENABLE_WORD = 0x1;
                export const GC_BANNED_WORD_DISABLE_WORD = 0x0;
            }
            export namespace PerformanceMode_t {
                export const PM_NORMAL = 0x0;
                export const PM_NO_GIBS = 0x1;
            }
            export namespace ReplayEventType_t {
                export const REPLAY_EVENT_DEATH = 0x1;
                export const REPLAY_EVENT_CANCEL = 0x0;
                export const REPLAY_EVENT_GENERIC = 0x2;
                export const REPLAY_EVENT_VICTORY = 0x4;
                export const REPLAY_EVENT_STUCK_NEED_FULL_UPDATE = 0x3;
            }
            export namespace ScriptedOnDeath_t {
                export const SS_ONDEATH_RAGDOLL = 0x1;
                export const SS_ONDEATH_UNDEFINED = 0x0;
                export const SS_ONDEATH_ANIMATED_DEATH = 0x2;
                export const SS_ONDEATH_NOT_APPLICABLE = -0x1;
            }
            export namespace SpawnGroupFlags_t {
                export const SPAWN_GROUP_SYNCHRONOUS_SPAWN = 0x4;
                export const SPAWN_GROUP_BLOCK_UNTIL_LOADED = 0x40;
                export const SPAWN_GROUP_DONT_SPAWN_ENTITIES = 0x2;
                export const SPAWN_GROUP_LOAD_STREAMING_DATA = 0x80;
                export const SPAWN_GROUP_CREATE_NEW_SCENE_WORLD = 0x100;
                export const SPAWN_GROUP_IS_INITIAL_SPAWN_GROUP = 0x8;
                export const SPAWN_GROUP_LOAD_ENTITIES_FROM_SAVE = 0x1;
                export const SPAWN_GROUP_CREATE_CLIENT_ONLY_ENTITIES = 0x10;
            }
            export namespace TakeDamageFlags_t {
                export const DFLAG_NONE = 0x0;
                export const DMG_LASTDFLAG = 0x20000;
                export const DFLAG_NEVER_GIB = 0x40;
                export const DFLAG_ALWAYS_GIB = 0x20;
                export const DFLAG_RADIUS_DMG = 0x400;
                export const DFLAG_FORCE_DEATH = 0x10;
                export const DFLAG_IGNORE_ARMOR = 0x40000;
                export const DFLAG_PREVENT_DEATH = 0x8;
                export const DFLAG_SUPPRESS_EFFECTS = 0x4;
                export const DFLAG_REMOVE_NO_RAGDOLL = 0x80;
                export const DFLAG_FORCE_PHYSICS_FORCE = 0x8000;
                export const DFLAG_SUPPRESS_BREAKABLES = 0x4000;
                export const DFLAG_SUPPRESS_UTILREMOVE = 0x80000;
                export const DFLAG_FORCEREDUCEARMOR_DMG = 0x800;
                export const DFLAG_SUPPRESS_PHYSICS_FORCE = 0x2;
                export const DFLAG_ALLOW_NON_AUTHORITATIVE = 0x20000;
                export const DFLAG_SUPPRESS_HEALTH_CHANGES = 0x1;
                export const DFLAG_ALWAYS_FIRE_DAMAGE_EVENTS = 0x200;
                export const DFLAG_IGNORE_DESTRUCTIBLE_PARTS = 0x2000;
                export const DFLAG_SUPPRESS_INTERRUPT_FLINCH = 0x1000;
                export const DFLAG_SUPPRESS_DAMAGE_MODIFICATION = 0x100;
                export const DFLAG_SUPPRESS_SCREENSPACE_DAMAGE_FX = 0x10000;
            }
            export namespace VoiceDataFormat_t {
                export const VOICEDATA_FORMAT_OPUS = 0x2;
                export const VOICEDATA_FORMAT_STEAM = 0x0;
                export const VOICEDATA_FORMAT_ENGINE = 0x1;
            }
            export namespace BodySectionMutex_t {
                export const eNone = 0x0;
                export const eFullBody = 0x3;
                export const eLowerBody = 0x1;
                export const eUpperBody = 0x2;
            }
            export namespace CFuncMover__Move_t {
                export const MOVE_LOOP = 0x0;
                export const MOVE_OSCILLATE = 0x1;
                export const MOVE_STOP_AT_END = 0x2;
            }
            export namespace ChoreoLookAtMode_t {
                export const eHead = 0x1;
                export const eChest = 0x0;
                export const eInvalid = -0x1;
                export const eEyesOnly = 0x2;
            }
            export namespace ChoreoStrafeMode_t {
                export const ENABLE = 0x1;
                export const DEFAULT = 0x0;
                export const DISABLE = 0x2;
            }
            export namespace CustomCameraMode_t {
                export const CUSTOM_CAMERA_MODE_DISABLED = 0x0;
                export const CUSTOM_CAMERA_MODE_CONTROLLED = 0x1;
                export const CUSTOM_CAMERA_MODE_FOLLOW_POSITION = 0x3;
                export const CUSTOM_CAMERA_MODE_CONTROLLED_POSITION = 0x2;
            }
            export namespace DebugOverlayBits_t {
                export const OVERLAY_BBOX_BIT = 0x4;
                export const OVERLAY_NAME_BIT = 0x2;
                export const OVERLAY_RBOX_BIT = 0x40;
                export const OVERLAY_TEXT_BIT = 0x1;
                export const OVERLAY_PIVOT_BIT = 0x8;
                export const OVERLAY_ABSBOX_BIT = 0x20;
                export const OVERLAY_HITBOX_BIT = 0x4000;
                export const OVERLAY_PROP_DEBUG = 0x200000000;
                export const OVERLAY_VIEWOFFSET = 0x800000000;
                export const OVERLAY_AUTOAIM_BIT = 0x10000;
                export const OVERLAY_BUDDHA_MODE = 0x40000000;
                export const OVERLAY_MESSAGE_BIT = 0x10;
                export const OVERLAY_MINIMAL_TEXT = 0x20000000000;
                export const OVERLAY_NPC_GOD_MODE = 0x40000000000;
                export const OVERLAY_NPC_KILL_BIT = 0x10000000;
                export const OVERLAY_NPC_TASK_BIT = 0x2000000;
                export const OVERLAY_SKELETON_BIT = 0x800;
                export const OVERLAY_ACTORNAME_BIT = 0x4000000000;
                export const OVERLAY_NPC_ROUTE_BIT = 0x80000;
                export const OVERLAY_JOINT_INFO_BIT = 0x40000;
                export const OVERLAY_NPC_COMBAT_BIT = 0x1000000;
                export const OVERLAY_SHOW_BLOCKSLOS = 0x80;
                export const OVERLAY_ATTACHMENTS_BIT = 0x100;
                export const OVERLAY_NPC_ENEMIES_BIT = 0x400000;
                export const OVERLAY_NPC_RELATION_BIT = 0x400000000;
                export const OVERLAY_NPC_SELECTED_BIT = 0x20000;
                export const OVERLAY_NPC_VIEWCONE_BIT = 0x8000000;
                export const OVERLAY_NPC_BODYLOCATIONS = 0x4000000;
                export const OVERLAY_NPC_TASK_TEXT_BIT = 0x100000000;
                export const OVERLAY_NPC_CONDITIONS_BIT = 0x800000;
                export const OVERLAY_TRIGGER_BOUNDS_BIT = 0x2000;
                export const OVERLAY_NPC_PATH_QUERIES_BIT = 0x100000000000;
                export const OVERLAY_VISIBILITY_TRACES_BIT = 0x100000;
                export const OVERLAY_INTERPOLATED_PIVOT_BIT = 0x400;
                export const OVERLAY_VCOLLIDE_WIREFRAME_BIT = 0x1000000000;
                export const OVERLAY_INTERPOLATED_HITBOX_BIT = 0x8000;
                export const OVERLAY_NPC_CONDITIONS_TEXT_BIT = 0x8000000000;
                export const OVERLAY_NPC_STEERING_REGULATIONS = 0x80000000;
                export const OVERLAY_INTERPOLATED_SKELETON_BIT = 0x1000;
                export const OVERLAY_NPC_SCRIPTED_COMMANDS_BIT = 0x2000000000;
                export const OVERLAY_NPC_ANIM_AI_HANDSHAKES_BIT = 0x80000000000;
                export const OVERLAY_NPC_ABILITY_RANGE_DEBUG_BIT = 0x10000000000;
                export const OVERLAY_INTERPOLATED_ATTACHMENTS_BIT = 0x200;
            }
            export namespace ECsgoSteamUserStat {
                export const k_ECsgoSteamUserStat_XpEarnedGames = 0x1;
                export const k_ECsgoSteamUserStat_SurvivedDangerZone = 0x3;
                export const k_ECsgoSteamUserStat_MatchWinsCompetitive = 0x2;
            }
            export namespace FuncDoorSpawnPos_t {
                export const FUNC_DOOR_SPAWN_OPEN = 0x1;
                export const FUNC_DOOR_SPAWN_CLOSED = 0x0;
            }
            export namespace GCConnectionStatus {
                export const GCConnectionStatus_NO_STEAM = 0x4;
                export const GCConnectionStatus_NO_SESSION = 0x2;
                export const GCConnectionStatus_HAVE_SESSION = 0x0;
                export const GCConnectionStatus_GC_GOING_DOWN = 0x1;
                export const GCConnectionStatus_NO_SESSION_IN_LOGON_QUEUE = 0x3;
            }
            export namespace PreviewWeaponState {
                export const ICON = 0x5;
                export const DROPPED = 0x0;
                export const INSPECT = 0x4;
                export const PLANTED = 0x3;
                export const DEPLOYED = 0x2;
                export const HOLSTERED = 0x1;
            }
            export namespace ShatterDamageCause {
                export const SHATTERDAMAGE_MELEE = 0x1;
                export const SHATTERDAMAGE_BULLET = 0x0;
                export const SHATTERDAMAGE_SCRIPT = 0x3;
                export const SHATTERDAMAGE_THROWN = 0x2;
                export const SHATTERDAMAGE_EXPLOSIVE = 0x4;
            }
            export namespace WeaponAttackType_t {
                export const eCount = 0x2;
                export const eInvalid = -0x1;
                export const ePrimary = 0x0;
                export const eSecondary = 0x1;
            }
            export namespace ChoreoLookAtSpeed_t {
                export const eFast = 0x2;
                export const eSlow = 0x0;
                export const eMedium = 0x1;
                export const eInvalid = -0x1;
            }
            export namespace EBaseClientMessages {
                export const CM_MAX_BASE = 0x12C;
                export const CM_RotateAnchor = 0x11D;
                export const CM_ClientUIEvent = 0x11A;
                export const CM_CustomGameEvent = 0x118;
                export const CM_CustomGameEventBounce = 0x119;
                export const CM_DevPaletteVisibilityChanged = 0x11B;
                export const CM_WorldUIControllerHasPanelChanged = 0x11C;
            }
            export namespace EBaseEntityMessages {
                export const EM_DoSpark = 0x8C;
                export const EM_FixAngle = 0x8D;
                export const EM_PlayJingle = 0x88;
                export const EM_ScreenOverlay = 0x89;
                export const EM_PropagateForce = 0x8B;
            }
            export namespace ECSPredictionEvents {
                export const CSPE_DamageTag = 0x1;
                export const CSPE_PlayerTeleport = 0x3;
            }
            export namespace ECommunityItemClass {
                export const k_ECommunityItemClass_Badge = 0x1;
                export const k_ECommunityItemClass_Scene = 0x9;
                export const k_ECommunityItemClass_GameGoo = 0x7;
                export const k_ECommunityItemClass_Invalid = 0x0;
                export const k_ECommunityItemClass_Emoticon = 0x4;
                export const k_ECommunityItemClass_GameCard = 0x2;
                export const k_ECommunityItemClass_Consumable = 0x6;
                export const k_ECommunityItemClass_SalienItem = 0xA;
                export const k_ECommunityItemClass_BoosterPack = 0x5;
                export const k_ECommunityItemClass_ProfileModifier = 0x8;
                export const k_ECommunityItemClass_ProfileBackground = 0x3;
            }
            export namespace EOverrideBlockLOS_t {
                export const BLOCK_LOS_DEFAULT = 0x0;
                export const BLOCK_LOS_FORCE_TRUE = 0x2;
                export const BLOCK_LOS_FORCE_FALSE = 0x1;
            }
            export namespace ForcedCrouchState_t {
                export const FORCEDCROUCH_NONE = 0x0;
                export const FORCEDCROUCH_CROUCHED = 0x1;
                export const FORCEDCROUCH_UNCROUCHED = 0x2;
            }
            export namespace PulseNPCCondition_t {
                export const COND_SEE_PLAYER = 0x1;
                export const COND_HEAR_PLAYER = 0x3;
                export const COND_LOST_PLAYER = 0x2;
                export const COND_PLAYER_PUSHING = 0x4;
                export const COND_NO_PRIMARY_AMMO = 0x5;
            }
            export namespace RadiusDmgOverride_t {
                export const RADIUS_DMG_OVERRIDE_NONE = 0x0;
                export const RADIUS_DMG_OVERRIDE_POSITION_ONLY = 0x1;
                export const RADIUS_DMG_OVERRIDE_POSITION_SKIP_TRACES = 0x2;
            }
            export namespace TrainVelocityType_t {
                export const TrainVelocity_LinearBlend = 0x1;
                export const TrainVelocity_EaseInEaseOut = 0x2;
                export const TrainVelocity_Instantaneous = 0x0;
            }
            export namespace AnimationAlgorithm_t {
                export const eNone = 0x0;
                export const eCount = 0x4;
                export const eInvalid = -0x1;
                export const eSequence = 0x1;
                export const eAnimGraph2 = 0x2;
                export const eAnimGraph2Secondary = 0x3;
            }
            export namespace CSWeaponSilencerType {
                export const WEAPONSILENCER_NONE = 0x0;
                export const WEAPONSILENCER_DETACHABLE = 0x1;
                export const WEAPONSILENCER_INTEGRATED = 0x2;
            }
            export namespace EProtoDebugVisiblity {
                export const k_EProtoDebugVisibility_GC = 0x5A;
                export const k_EProtoDebugVisibility_Never = 0x64;
                export const k_EProtoDebugVisibility_Always = 0x0;
                export const k_EProtoDebugVisibility_Server = 0x46;
                export const k_EProtoDebugVisibility_ValveServer = 0x50;
            }
            export namespace EntityDissolveType_t {
                export const ENTITY_DISSOLVE_CORE = 0x3;
                export const ENTITY_DISSOLVE_NORMAL = 0x0;
                export const ENTITY_DISSOLVE_INVALID = -0x1;
                export const ENTITY_DISSOLVE_ELECTRICAL = 0x1;
                export const ENTITY_DISSOLVE_ELECTRICAL_LIGHT = 0x2;
            }
            export namespace EntityDistanceMode_t {
                export const eAxisToAxis = 0x2;
                export const eCenterToCenter = 0x1;
                export const eOriginToOrigin = 0x0;
            }
            export namespace GCClientLauncherType {
                export const GCClientLauncherType_DEFAULT = 0x0;
                export const GCClientLauncherType_SOURCE2 = 0x3;
                export const GCClientLauncherType_STEAMCHINA = 0x2;
                export const GCClientLauncherType_PERFECTWORLD = 0x1;
            }
            export namespace GameAnimEventIndex_t {
                export const AE_COUNT = 0x2F;
                export const AE_EMPTY = 0x0;
                export const AE_FOOTSTEP = 0xC;
                export const AE_SV_IKLOCK = 0x16;
                export const AE_FIRE_INPUT = 0x10;
                export const AE_PULSE_GRAPH = 0x17;
                export const AE_CL_EJECT_MAG = 0x2B;
                export const AE_CL_PLAYSOUND = 0x1;
                export const AE_CL_STOPSOUND = 0x5;
                export const AE_SV_PLAYSOUND = 0x4;
                export const AE_CL_CLOTH_ATTR = 0x11;
                export const AE_CL_CLOTH_EFFECT = 0x14;
                export const AE_CL_CLOTH_STIFFEN = 0x13;
                export const AE_DISABLE_PLATFORM = 0x18;
                export const AE_BODYGROUP_SET_VALUE = 0xE;
                export const AE_WPN_COMPLETE_RELOAD = 0x2C;
                export const AE_CL_PLAYSOUND_LOOPING = 0x6;
                export const AE_SCRIPT_FIRE_EVENT_01 = 0x1E;
                export const AE_SCRIPT_FIRE_EVENT_02 = 0x1F;
                export const AE_SCRIPT_FIRE_EVENT_03 = 0x20;
                export const AE_SCRIPT_FIRE_EVENT_04 = 0x21;
                export const AE_SCRIPT_FIRE_EVENT_05 = 0x22;
                export const AE_SCRIPT_FIRE_EVENT_06 = 0x23;
                export const AE_SCRIPT_FIRE_EVENT_07 = 0x24;
                export const AE_SCRIPT_FIRE_EVENT_08 = 0x25;
                export const AE_SCRIPT_FIRE_EVENT_09 = 0x26;
                export const AE_SCRIPT_FIRE_EVENT_10 = 0x27;
                export const AE_CL_PLAYSOUND_POSITION = 0x3;
                export const AE_VEHICLE_EXIT_FINISHED = 0x1D;
                export const AE_WEAPON_PERFORM_ATTACK = 0xF;
                export const AE_WPN_HEALTHSHOT_INJECT = 0x2D;
                export const AE_CL_CLOTH_GROUND_OFFSET = 0x12;
                export const AE_GRENADE_THROW_COMPLETE = 0x2E;
                export const AE_VEHICLE_ENTER_FINISHED = 0x1C;
                export const AE_CL_PLAYSOUND_ATTACHMENT = 0x2;
                export const AE_CL_STOP_PARTICLE_EFFECT = 0x8;
                export const AE_CL_STOP_RAGDOLL_CONTROL = 0xD;
                export const AE_SV_STOP_PARTICLE_EFFECT = 0xB;
                export const AE_CL_CREATE_ANIM_SCOPE_PROP = 0x15;
                export const AE_CL_CREATE_PARTICLE_EFFECT = 0x7;
                export const AE_DESTRUCTIBLE_PART_DESTROY = 0x1B;
                export const AE_SV_ATTACH_SILENCER_COMPLETE = 0x29;
                export const AE_SV_DETACH_SILENCER_COMPLETE = 0x2A;
                export const AE_CL_CREATE_PARTICLE_EFFECT_CFG = 0x9;
                export const AE_SV_CREATE_PARTICLE_EFFECT_CFG = 0xA;
                export const AE_CL_WEAPON_TRANSITION_INTO_HAND = 0x28;
                export const AE_ENABLE_PLATFORM_PLAYER_FOLLOWS_YAW = 0x19;
                export const AE_ENABLE_PLATFORM_PLAYER_IGNORES_YAW = 0x1A;
            }
            export namespace ModifyDamageReturn_t {
                export const CONTINUE_TO_APPLY_DAMAGE = 0x0;
                export const ABORT_DO_NOT_APPLY_DAMAGE = 0x1;
            }
            export namespace MoveMountingAmount_t {
                export const MOVE_MOUNT_LOW = 0x1;
                export const MOVE_MOUNT_HIGH = 0x2;
                export const MOVE_MOUNT_NONE = 0x0;
                export const MOVE_MOUNT_MAXCOUNT = 0x3;
            }
            export namespace NPCFollowFormation_t {
                export const Default = -0x1;
                export const Sidekick = 0x6;
                export const WideCircle = 0x1;
                export const CloseCircle = 0x0;
                export const MediumCircle = 0x5;
            }
            export namespace PlayerConnectedState {
                export const Reserved = 0x5;
                export const Connected = 0x0;
                export const Connecting = 0x1;
                export const Disconnected = 0x4;
                export const Reconnecting = 0x2;
                export const Disconnecting = 0x3;
                export const NeverConnected = -0x1;
            }
            export namespace PreviewCharacterMode {
                export const BANNER = 0xA;
                export const DIORAMA = 0x0;
                export const INVALID = -0x1;
                export const WALKING = 0x6;
                export const BUY_MENU = 0x2;
                export const MAIN_MENU = 0x1;
                export const RUSH_INTRO = 0x9;
                export const TEAM_INTRO = 0x7;
                export const TEAM_SELECT = 0x3;
                export const END_OF_MATCH = 0x4;
                export const WINGMAN_INTRO = 0x8;
                export const CHICK_SNAPSHOT = 0xB;
                export const CHICK_VIEWMODEL = 0xC;
                export const INVENTORY_INSPECT = 0x5;
            }
            export namespace PulseTraceContents_t {
                export const SOLID = 0x1;
                export const STATIC_LEVEL = 0x0;
            }
            export namespace SceneOnPlayerDeath_t {
                export const SCENE_ONPLAYERDEATH_CANCEL = 0x1;
                export const SCENE_ONPLAYERDEATH_DO_NOTHING = 0x0;
            }
            export namespace WeaponSwitchReason_t {
                export const eDrawn = 0x0;
                export const eEquipped = 0x1;
                export const eUserInitiatedUIKeyPress = 0x3;
                export const eUserInitiatedSwitchHands = 0x4;
                export const eUserInitiatedSwitchToLast = 0x2;
            }
            export namespace vote_create_failed_t {
                export const VOTE_FAILED_MAX = 0x22;
                export const VOTE_FAILED_GENERIC = 0x0;
                export const VOTE_FAILED_REMATCH = 0x20;
                export const VOTE_FAILED_CONTINUE = 0x21;
                export const VOTE_FAILED_DISABLED = 0x15;
                export const VOTE_FAILED_SPECTATOR = 0xE;
                export const VOTE_FAILED_MATCH_PAUSED = 0x18;
                export const VOTE_FAILED_MAP_NOT_FOUND = 0x6;
                export const VOTE_FAILED_NEXTLEVEL_SET = 0x16;
                export const VOTE_FAILED_NOT_IN_WARMUP = 0x1A;
                export const VOTE_FAILED_RATE_EXCEEDED = 0x2;
                export const VOTE_FAILED_CANT_ROUND_END = 0x1F;
                export const VOTE_FAILED_ISSUE_DISABLED = 0x5;
                export const VOTE_FAILED_NOT_10_PLAYERS = 0x1B;
                export const VOTE_FAILED_PLAYERNOTFOUND = 0xB;
                export const VOTE_FAILED_QUORUM_FAILURE = 0x4;
                export const VOTE_FAILED_TEAM_CANT_CALL = 0x9;
                export const VOTE_FAILED_TIMEOUT_ACTIVE = 0x1C;
                export const VOTE_FAILED_FAILED_RECENTLY = 0x8;
                export const VOTE_FAILED_MATCH_NOT_PAUSED = 0x19;
                export const VOTE_FAILED_SWAP_IN_PROGRESS = 0x14;
                export const VOTE_FAILED_TIMEOUT_INACTIVE = 0x1D;
                export const VOTE_FAILED_CANNOT_KICK_ADMIN = 0xC;
                export const VOTE_FAILED_MAP_NAME_REQUIRED = 0x7;
                export const VOTE_FAILED_TIMEOUT_EXHAUSTED = 0x1E;
                export const VOTE_FAILED_WAITINGFORPLAYERS = 0xA;
                export const VOTE_FAILED_FAILED_RECENT_KICK = 0xF;
                export const VOTE_FAILED_YES_MUST_EXCEED_NO = 0x3;
                export const VOTE_FAILED_TOO_EARLY_SURRENDER = 0x17;
                export const VOTE_FAILED_SCRAMBLE_IN_PROGRESS = 0xD;
                export const VOTE_FAILED_FAILED_RECENT_RESTART = 0x13;
                export const VOTE_FAILED_TRANSITIONING_PLAYERS = 0x1;
                export const VOTE_FAILED_FAILED_RECENT_CHANGEMAP = 0x10;
                export const VOTE_FAILED_FAILED_RECENT_SWAPTEAMS = 0x11;
                export const VOTE_FAILED_FAILED_RECENT_SCRAMBLETEAMS = 0x12;
            }
            export namespace EBasePredictionEvents {
                export const BPE_Teleport = 0x82;
                export const BPE_Diagnostic = 0x4000;
                export const BPE_StringCommand = 0x80;
            }
            export namespace EQueryCvarValueStatus {
                export const eQueryCvarValueStatus_NotACvar = 0x2;
                export const eQueryCvarValueStatus_ValueIntact = 0x0;
                export const eQueryCvarValueStatus_CvarNotFound = 0x1;
                export const eQueryCvarValueStatus_CvarProtected = 0x3;
            }
            export namespace EntityPlatformTypes_t {
                export const ENTITY_NOT_PLATFORM = 0x0;
                export const ENTITY_PLATFORM_PLAYER_FOLLOWS_YAW = 0x1;
                export const ENTITY_PLATFORM_PLAYER_IGNORES_YAW = 0x2;
            }
            export namespace EntitySubclassScope_t {
                export const SUBCLASS_SCOPE_NONE = -0x1;
                export const SUBCLASS_SCOPE_COUNT = 0x2;
                export const SUBCLASS_SCOPE_PRECIPITATION = 0x0;
                export const SUBCLASS_SCOPE_PLAYER_WEAPONS = 0x1;
            }
            export namespace ObserverInterpState_t {
                export const OBSERVER_INTERP_NONE = 0x0;
                export const OBSERVER_INTERP_SETTLING = 0x3;
                export const OBSERVER_INTERP_STARTING = 0x1;
                export const OBSERVER_INTERP_TRAVELING = 0x2;
            }
            export namespace PreviewEOMCelebration {
                export const MASK_F = 0x6;
                export const WALKUP = 0x0;
                export const INVALID = -0x1;
                export const STRETCH = 0x4;
                export const SWAGGER = 0x2;
                export const DROPDOWN = 0x3;
                export const GUERILLA = 0x7;
                export const PUNCHING = 0x1;
                export const AVA_DEFEAT = 0xC;
                export const GUERILLA02 = 0x8;
                export const MAE_DEFEAT = 0xE;
                export const SCUBA_MALE = 0xB;
                export const GENDARMERIE = 0x9;
                export const SWAT_FEMALE = 0x5;
                export const VYPA_DEFEAT = 0x16;
                export const SCUBA_FEMALE = 0xA;
                export const DARRYL_DEFEAT = 0x13;
                export const DOCTOR_DEFEAT = 0x14;
                export const MUHLIK_DEFEAT = 0x15;
                export const RICKSAW_DEFEAT = 0xF;
                export const CRASSWATER_DEFEAT = 0x12;
                export const SCUBA_MALE_DEFEAT = 0x11;
                export const GENDARMERIE_DEFEAT = 0xD;
                export const SCUBA_FEMALE_DEFEAT = 0x10;
            }
            export namespace PulseCollisionGroup_t {
                export const DEFAULT = 0x0;
            }
            export namespace PulseMethodCallMode_t {
                export const ASYNC_FIRE_AND_FORGET = 0x1;
                export const SYNC_WAIT_FOR_COMPLETION = 0x0;
            }
            export namespace QuestProgress__Reason {
                export const QUEST_OK = 0x1;
                export const QUEST_WARMUP = 0x3;
                export const QUEST_NO_QUEST = 0x7;
                export const QUEST_WRONG_MAP = 0x9;
                export const QUEST_REASON_MAX = 0xC;
                export const QUEST_WRONG_MODE = 0xA;
                export const QUEST_PLAYER_IS_BOT = 0x8;
                export const QUEST_NONINITIALIZED = 0x0;
                export const QUEST_NO_ENTITLEMENT = 0x6;
                export const QUEST_NONOFFICIAL_SERVER = 0x5;
                export const QUEST_NOT_ENOUGH_PLAYERS = 0x2;
                export const QUEST_NOT_CONNECTED_TO_STEAM = 0x4;
                export const QUEST_NOT_SYNCED_WITH_SERVER = 0xB;
            }
            export namespace SoundEventStartType_t {
                export const SOUNDEVENT_START_WORLD = 0x1;
                export const SOUNDEVENT_START_ENTITY = 0x2;
                export const SOUNDEVENT_START_PLAYER = 0x0;
            }
            export namespace TimelineCompression_t {
                export const TIMELINE_COMPRESSION_SUM = 0x0;
                export const TIMELINE_COMPRESSION_TOTAL = 0x4;
                export const TIMELINE_COMPRESSION_AVERAGE = 0x2;
                export const TIMELINE_COMPRESSION_AVERAGE_BLEND = 0x3;
                export const TIMELINE_COMPRESSION_COUNT_PER_INTERVAL = 0x1;
            }
            export namespace Bidirectional_Messages {
                export const bi_PredictionEvent = 0x13;
                export const bi_RebroadcastSource = 0x11;
                export const bi_GameEvent_DEPRECATED = 0x12;
                export const bi_RebroadcastGameEvent = 0x10;
            }
            export namespace CFuncRotator__Rotate_t {
                export const ROTATE_LOOP = 0x0;
                export const ROTATE_OSCILLATE = 0x1;
                export const ROTATE_STOP_AT_END = 0x2;
                export const ROTATE_LOOK_AT_TARGET = 0x3;
                export const ROTATE_LOOK_AT_TARGET_ONLY_YAW = 0x4;
                export const ROTATE_LOOK_AT_TARGET_ONLY_PITCH = 0x5;
                export const ROTATE_RETURN_TO_INITIAL_ORIENTATION = 0x6;
            }
            export namespace ChoreoScriptedMoveTo_t {
                export const eWait = 0x0;
                export const eTeleport = 0x2;
                export const eWaitFacing = 0x3;
                export const eMoveWithGait = 0x1;
            }
            export namespace ECstrike15UserMessages {
                export const CS_UM_Fade = 0x139;
                export const CS_UM_SSUI = 0x174;
                export const CS_UM_Shake = 0x138;
                export const CS_UM_Train = 0x12F;
                export const CS_UM_Damage = 0x141;
                export const CS_UM_Geiger = 0x12E;
                export const CS_UM_HudMsg = 0x134;
                export const CS_UM_Rumble = 0x13A;
                export const CS_UM_BarTime = 0x163;
                export const CS_UM_HudText = 0x130;
                export const CS_UM_KillCam = 0x14A;
                export const CS_UM_HintText = 0x143;
                export const CS_UM_ItemDrop = 0x167;
                export const CS_UM_RawAudio = 0x13E;
                export const CS_UM_ResetHud = 0x135;
                export const CS_UM_ShowMenu = 0x162;
                export const CS_UM_VGUIMenu = 0x12D;
                export const CS_UM_VotePass = 0x15B;
                export const CS_UM_XRankGet = 0x154;
                export const CS_UM_XRankUpd = 0x155;
                export const CS_UM_XpUpdate = 0x16D;
                export const CS_UM_DeepStats = 0x17D;
                export const CS_UM_GameTitle = 0x136;
                export const CS_UM_RadioText = 0x142;
                export const CS_UM_ReportHit = 0x16C;
                export const CS_UM_SendAudio = 0x13D;
                export const CS_UM_ShootInfo = 0x17F;
                export const CS_UM_VoiceMask = 0x13F;
                export const CS_UM_VoteSetup = 0x15D;
                export const CS_UM_VoteStart = 0x15A;
                export const CS_UM_AmmoDenied = 0x164;
                export const CS_UM_ClientInfo = 0x153;
                export const CS_UM_ItemPickup = 0x161;
                export const CS_UM_VoteFailed = 0x15C;
                export const CS_UM_AdjustMoney = 0x147;
                export const CS_UM_KeyHintText = 0x144;
                export const CS_UM_WeaponSound = 0x171;
                export const CS_UM_CloseCaption = 0x13B;
                export const CS_UM_ReloadEffect = 0x146;
                export const CS_UM_RequestState = 0x140;
                export const CS_UM_CounterStrafe = 0x181;
                export const CS_UM_QuestProgress = 0x16E;
                export const CS_UM_SurvivalStats = 0x175;
                export const CS_UM_WeaponMagDrop = 0x185;
                export const CS_UM_CallVoteFailed = 0x159;
                export const CS_UM_MarkAchievement = 0x165;
                export const CS_UM_AchievementEvent = 0x14D;
                export const CS_UM_CurrentRoundOdds = 0x17C;
                export const CS_UM_CurrentTimescale = 0x14C;
                export const CS_UM_CustomHudClicked = 0x186;
                export const CS_UM_DamagePrediction = 0x182;
                export const CS_UM_DesiredTimescale = 0x14B;
                export const CS_UM_MatchStatsUpdate = 0x166;
                export const CS_UM_ServerRankUpdate = 0x160;
                export const CS_UM_DisconnectToLobby = 0x14F;
                export const CS_UM_PlayerStatsUpdate = 0x150;
                export const CS_UM_SendPlayerLoadout = 0x184;
                export const CS_UM_StopSpectatorMode = 0x149;
                export const CS_UM_CloseCaptionDirect = 0x13C;
                export const CS_UM_DisconnectToLobby2 = 0x176;
                export const CS_UM_MatchEndConditions = 0x14E;
                export const CS_UM_RoundEndReportData = 0x17B;
                export const CS_UM_SayText_CSGOLegacy = 0x131;
                export const CS_UM_TextMsg_CSGOLegacy = 0x133;
                export const CS_UM_SayText2_CSGOLegacy = 0x132;
                export const CS_UM_SendPlayerItemDrops = 0x169;
                export const CS_UM_SendPlayerItemFound = 0x16B;
                export const CS_UM_ServerRankRevealAll = 0x15E;
                export const CS_UM_RoundBackupFilenames = 0x16A;
                export const CS_UM_ScoreLeaderboardData = 0x16F;
                export const CS_UM_PostRoundDamageReport = 0x178;
                export const CS_UM_UpdateScreenHealthBar = 0x172;
                export const CS_UM_EntityOutlineHighlight = 0x173;
                export const CS_UM_RecurringMissionSchema = 0x183;
                export const CS_UM_EndOfMatchAllPlayersData = 0x177;
                export const CS_UM_ProcessSpottedEntityUpdate = 0x145;
                export const CS_UM_UpdateTeamMoney_CSGOLegacy = 0x148;
                export const CS_UM_PlayerDecalDigitalSignature = 0x170;
                export const CS_UM_SendLastKillerDamageToClient = 0x15F;
            }
            export namespace EHudPanelClassStatus_t {
                export const k_eHudPanelClassStatus_HasClass = 0x1;
                export const k_eHudPanelClassStatus_Undefined = -0x1;
                export const k_eHudPanelClassStatus_DoesNotHaveClass = 0x0;
            }
            export namespace EntityAttachmentType_t {
                export const eEyes = 0x2;
                export const eCenter = 0x1;
                export const eAbsOrigin = 0x0;
                export const eAttachment = 0x3;
                export const eLocalOffset = 0x4;
            }
            export namespace LatchDirtyPermission_t {
                export const LATCH_DIRTY_DISALLOW = 0x0;
                export const LATCH_DIRTY_PREDICTION = 0x3;
                export const LATCH_DIRTY_FRAMESIMULATE = 0x4;
                export const LATCH_DIRTY_CLIENT_SIMULATED = 0x2;
                export const LATCH_DIRTY_PARTICLE_SIMULATE = 0x5;
                export const LATCH_DIRTY_SERVER_CONTROLLED = 0x1;
            }
            export namespace RelativeLocationType_t {
                export const WORLD_SPACE_POSITION = 0x0;
                export const RELATIVE_TO_ENTITY_YAW_ONLY = 0x2;
                export const RELATIVE_TO_ENTITY_IN_LOCAL_SPACE = 0x1;
                export const RELATIVE_TO_ENTITY_IN_WORLD_SPACE = 0x3;
            }
            export namespace ShatterGlassStressType {
                export const SHATTERGLASS_BLUNT = 0x0;
                export const SHATTERGLASS_PULSE = 0x2;
                export const SHATTERGLASS_BALLISTIC = 0x1;
                export const SHATTERGLASS_EXPLOSIVE = 0x3;
            }
            export namespace TrackOrientationType_t {
                export const TrackOrientation_Fixed = 0x0;
                export const TrackOrientation_FacePath = 0x1;
                export const TrackOrientation_FacePathAngles = 0x2;
            }
            export namespace TrainOrientationType_t {
                export const TrainOrientation_Fixed = 0x0;
                export const TrainOrientation_LinearBlend = 0x2;
                export const TrainOrientation_AtPathTracks = 0x1;
                export const TrainOrientation_EaseInEaseOut = 0x3;
            }
            export namespace BreakableContentsType_t {
                export const BC_EMPTY = 0x1;
                export const BC_DEFAULT = 0x0;
                export const BC_PROP_GROUP_OVERRIDE = 0x2;
                export const BC_PARTICLE_SYSTEM_OVERRIDE = 0x3;
            }
            export namespace EClientReportingVersion {
                export const k_EClientReportingVersion_OldVersion = 0x0;
                export const k_EClientReportingVersion_BetaVersion = 0x1;
                export const k_EClientReportingVersion_SupportsTrustedMode = 0x2;
            }
            export namespace ECommunityItemAttribute {
                export const k_ECommunityItemAttribute_Level = 0x2;
                export const k_ECommunityItemAttribute_Invalid = 0x0;
                export const k_ECommunityItemAttribute_CardBorder = 0x1;
                export const k_ECommunityItemAttribute_ExpiryTime = 0x9;
                export const k_ECommunityItemAttribute_IssueNumber = 0x3;
                export const k_ECommunityItemAttribute_TradableTime = 0x4;
                export const k_ECommunityItemAttribute_StorePackageID = 0x5;
                export const k_ECommunityItemAttribute_CommunityItemType = 0x7;
                export const k_ECommunityItemAttribute_CommunityItemAppID = 0x6;
                export const k_ECommunityItemAttribute_ProfileModiferEnabled = 0x8;
            }
            export namespace EGCBaseProtoObjectTypes {
                export const k_EProtoObjectLobbyInvite = 0x3EA;
                export const k_EProtoObjectPartyInvite = 0x3E9;
            }
            export namespace ESplitScreenMessageType {
                export const MSG_SPLITSCREEN_ADDUSER = 0x0;
                export const MSG_SPLITSCREEN_REMOVEUSER = 0x1;
            }
            export namespace MoveLinearAuthoredPos_t {
                export const MOVELINEAR_AUTHORED_AT_OPEN_POSITION = 0x1;
                export const MOVELINEAR_AUTHORED_AT_START_POSITION = 0x0;
                export const MOVELINEAR_AUTHORED_AT_CLOSED_POSITION = 0x2;
            }
            export namespace NavAttributeDynamicType {
                export const NAV_AREA_DOCK = 0x4000;
                export const NAV_AREA_NONE = 0x0;
                export const NAV_AREA_MOVABLE = 0x2000;
                export const NAV_AREA_BOUNDARY = 0x10000;
                export const NAV_AREA_NAV_LINK = 0x200;
                export const NAV_AREA_DEFORMABLE = 0x40000;
                export const NAV_AREA_HAS_LADDERS = 0x100;
                export const NAV_AREA_UNDER_WATER = 0x1;
                export const NAV_AREA_DEFORMABLE_DOCK = 0x80000;
                export const NAV_AREA_LINK_AUTO_ADJUST = 0x100000;
                export const NAV_AREA_UNDER_WATER_DEEP = 0x2;
                export const NAV_AREA_DOCKING_CANDIDATE = 0x8000;
                export const NAV_AREA_NAV_LINK_TERMINUS = 0x400;
                export const NAV_AREA_EXTERNALLY_CREATED = 0x4;
                export const NAV_AREA_SHOULD_BE_DESTROYED = 0x8;
                export const NAV_AREA_SPLIT_OBS_CONTAINED = 0x40;
                export const NAV_AREA_SPLIT_BY_OBSTACLE_MGR = 0x20;
                export const NAV_AREA_CREATED_BY_OBSTACLE_MGR = 0x10;
                export const NAV_AREA_CONNECTED_TO_NAV_LINK_IN = 0x1000;
                export const NAV_AREA_SPLIT_OBS_BASE_CONTAINED = 0x80;
                export const NAV_AREA_CONNECTED_TO_NAV_LINK_OUT = 0x800;
                export const NAV_AREA_HAS_TACTICAL_SEARCH_ANNOTATIONS = 0x20000;
            }
            export namespace PointOrientConstraint_t {
                export const eNone = 0x0;
                export const ePreserveUpAxis = 0x1;
            }
            export namespace PulseBestOutflowRules_t {
                export const SORT_BY_OUTFLOW_INDEX = 0x1;
                export const SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0;
            }
            export namespace SaveRestoreTableFlags_t {
                export const FENTTABLE_NONE = 0x0;
                export const LEVELMASK_BIT_0 = 0x1;
                export const LEVELMASK_BIT_1 = 0x2;
                export const LEVELMASK_BIT_2 = 0x4;
                export const LEVELMASK_BIT_3 = 0x8;
                export const LEVELMASK_BIT_4 = 0x10;
                export const LEVELMASK_BIT_5 = 0x20;
                export const LEVELMASK_BIT_6 = 0x40;
                export const LEVELMASK_BIT_7 = 0x80;
                export const LEVELMASK_BIT_8 = 0x100;
                export const LEVELMASK_BIT_9 = 0x200;
                export const FENTTABLE_GLOBAL = 0x10000000;
                export const FENTTABLE_PLAYER = 0x80000000;
                export const LEVELMASK_BIT_10 = 0x400;
                export const LEVELMASK_BIT_11 = 0x800;
                export const LEVELMASK_BIT_12 = 0x1000;
                export const LEVELMASK_BIT_13 = 0x2000;
                export const LEVELMASK_BIT_14 = 0x4000;
                export const LEVELMASK_BIT_15 = 0x8000;
                export const FENTTABLE_REMOVED = 0x40000000;
                export const FENTTABLE_MOVEABLE = 0x20000000;
                export const FENTTABLE_PLAYERCHILD = 0x8000000;
            }
            export namespace SurroundingBoundsType_t {
                export const USE_HITBOXES = 0x2;
                export const USE_GAME_CODE = 0x4;
                export const USE_SPECIFIED_BOUNDS = 0x3;
                export const USE_OBB_COLLISION_BOUNDS = 0x0;
                export const USE_BEST_COLLISION_BOUNDS = 0x1;
                export const SURROUNDING_TYPE_BIT_COUNT = 0x3;
                export const USE_ROTATION_EXPANDED_BOUNDS = 0x5;
                export const USE_COLLISION_BOUNDS_NEVER_VPHYSICS = 0x7;
                export const USE_ROTATION_EXPANDED_ORIENTED_BOUNDS = 0x6;
                export const USE_ROTATION_EXPANDED_SEQUENCE_BOUNDS = 0x8;
            }
            export namespace WeaponGameplayAnimState {
                export const WPN_ANIMSTATE_IDLE = 0x32;
                export const WPN_ANIMSTATE_CHARGE = 0x67;
                export const WPN_ANIMSTATE_DEPLOY = 0xB;
                export const WPN_ANIMSTATE_RELOAD = 0x320;
                export const WPN_ANIMSTATE_DROPPED = 0x1;
                export const WPN_ANIMSTATE_INSPECT = 0x3E8;
                export const WPN_ANIMSTATE_C4_PLANT = 0x12C;
                export const WPN_ANIMSTATE_END_VALID = 0x7D0;
                export const WPN_ANIMSTATE_HOLSTERED = 0xA;
                export const WPN_ANIMSTATE_RELOAD_OUTRO = 0x321;
                export const WPN_ANIMSTATE_GRENADE_READY = 0xC9;
                export const WPN_ANIMSTATE_GRENADE_THROW = 0xCA;
                export const WPN_ANIMSTATE_INSPECT_OUTRO = 0x3E9;
                export const WPN_ANIMSTATE_SHOOT_DRYFIRE = 0x66;
                export const WPN_ANIMSTATE_SHOOT_PRIMARY = 0x64;
                export const WPN_ANIMSTATE_UNINITIALIZED = 0x0;
                export const WPN_ANIMSTATE_SILENCER_APPLY = 0x258;
                export const WPN_ANIMSTATE_SHOOT_SECONDARY = 0x65;
                export const WPN_ANIMSTATE_SILENCER_REMOVE = 0x259;
                export const WPN_ANIMSTATE_GRENADE_PULL_PIN = 0xC8;
                export const WPN_ANIMSTATE_HEALTHSHOT_INJECT = 0x190;
                export const WPN_ANIMSTATE_KNIFE_PRIMARY_HIT = 0x1F4;
                export const WPN_ANIMSTATE_KNIFE_PRIMARY_MISS = 0x1F5;
                export const WPN_ANIMSTATE_KNIFE_PRIMARY_STAB = 0x1F8;
                export const WPN_ANIMSTATE_INVENTORY_UI_TUMBLE = 0x5DC;
                export const WPN_ANIMSTATE_KNIFE_SECONDARY_HIT = 0x1F6;
                export const WPN_ANIMSTATE_KNIFE_SECONDARY_MISS = 0x1F7;
                export const WPN_ANIMSTATE_KNIFE_SECONDARY_STAB = 0x1F9;
                export const WPN_ANIMSTATE_INVENTORY_UI_KEYCHAIN_APPLY = 0x5DD;
            }
            export namespace AnimGraphDebugDrawType_t {
                export const _None = 0x0;
                export const MsPosition = 0x2;
                export const WsPosition = 0x1;
                export const MsDirection = 0x4;
                export const WsDirection = 0x3;
            }
            export namespace ChoreoLookAtConditions_t {
                export const DURING_OUTRO = 0x4;
                export const WHILE_MOVING = 0x1;
                export const WHILE_ANIMATING = 0x2;
            }
            export namespace EContributionScoreFlag_t {
                export const k_EContributionScoreFlag_Bullets = 0x2;
                export const k_EContributionScoreFlag_Default = 0x0;
                export const k_EContributionScoreFlag_Objective = 0x1;
            }
            export namespace ValueRemapperInputType_t {
                export const InputType_PlayerShootPosition = 0x0;
                export const InputType_PlayerShootPositionAroundAxis = 0x1;
            }
            export namespace attributeprovidertypes_t {
                export const PROVIDER_WEAPON = 0x1;
                export const PROVIDER_GENERIC = 0x0;
            }
            export namespace CDebugOverlayFilterType_t {
                export const NONE = 0x0;
                export const TEXT = 0x1;
                export const COUNT = 0x3;
                export const ENTITY = 0x2;
                export const AI_TASK = 0x6;
                export const AI_EVENT = 0x7;
                export const COMBINED = -0x1;
                export const AI_SCHEDULE = 0x5;
                export const AI_PATHFINDING = 0x8;
                export const TACTICAL_SEARCH = 0x4;
                export const END_SIM_HISTORY_TYPES = 0x9;
            }
            export namespace CPhysicsProp__CrateType_t {
                export const CRATE_TYPE_COUNT = 0x1;
                export const CRATE_SPECIFIC_ITEM = 0x0;
            }
            export namespace PulseCursorWakePriority_t {
                export const WakeElegantly = 0x0;
                export const WakeImmediate = 0x1;
            }
            export namespace SVC_Messages_LowFrequency {
                export const svc_dummy = 0x258;
            }
            export namespace SubclassVDataChangeType_t {
                export const SUBCLASS_VDATA_CREATED = 0x0;
                export const SUBCLASS_VDATA_RELOADED = 0x2;
                export const SUBCLASS_VDATA_SUBCLASS_CHANGED = 0x1;
            }
            export namespace ValueRemapperOutputType_t {
                export const OutputType_RotationX = 0x1;
                export const OutputType_RotationY = 0x2;
                export const OutputType_RotationZ = 0x3;
                export const OutputType_AnimationCycle = 0x0;
            }
            export namespace DirectionAlongSimplePath_t {
                export const _None = 0x0;
                export const TGoesUp = 0x1;
                export const TGoesDown = 0x2;
            }
            export namespace ESource2PlayStatsFieldType {
                export const Source2PlayStats_Bool = 0xB;
                export const Source2PlayStats_Int8 = 0x8;
                export const Source2PlayStats_Int16 = 0x7;
                export const Source2PlayStats_Int32 = 0x6;
                export const Source2PlayStats_Int64 = 0x5;
                export const Source2PlayStats_UInt8 = 0x4;
                export const Source2PlayStats_String = 0xC;
                export const Source2PlayStats_UInt16 = 0x3;
                export const Source2PlayStats_UInt32 = 0x2;
                export const Source2PlayStats_UInt64 = 0x1;
                export const Source2PlayStats_Float32 = 0xA;
                export const Source2PlayStats_Float64 = 0x9;
                export const Source2PlayStats_Invalid = 0x0;
                export const Source2PlayStats_SteamID = 0x11;
                export const Source2PlayStats_UTCDateTime = 0xE;
                export const Source2PlayStats_SteamIDTrustBucket = 0xF;
                export const Source2PlayStats_LowCardinalityString = 0xD;
                export const Source2PlayStats_SteamIDTrustBucketMin = 0x10;
            }
            export namespace PropDoorRotatingSpawnPos_t {
                export const DOOR_SPAWN_AJAR = 0x3;
                export const DOOR_SPAWN_CLOSED = 0x0;
                export const DOOR_SPAWN_OPEN_BACK = 0x2;
                export const DOOR_SPAWN_OPEN_FORWARD = 0x1;
            }
            export namespace ScriptedConflictResponse_t {
                export const SS_CONFLICT_ENQUEUE = 0x0;
                export const SS_CONFLICT_INTERRUPT = 0x1;
            }
            export namespace ValueRemapperHapticsType_t {
                export const HaticsType_None = 0x1;
                export const HaticsType_Default = 0x0;
            }
            export namespace ValueRemapperRatchetType_t {
                export const RatchetType_Absolute = 0x0;
                export const RatchetType_EachEngage = 0x1;
            }
            export namespace CSPlayerBlockingUseAction_t {
                export const k_CSPlayerBlockingUseAction_None = 0x0;
                export const k_CSPlayerBlockingUseAction_MaxCount = 0x7;
                export const k_CSPlayerBlockingUseAction_DefusingDefault = 0x1;
                export const k_CSPlayerBlockingUseAction_DefusingWithKit = 0x2;
                export const k_CSPlayerBlockingUseAction_HostageDropping = 0x4;
                export const k_CSPlayerBlockingUseAction_HostageGrabbing = 0x3;
                export const k_CSPlayerBlockingUseAction_MapLongUseEntity_Place = 0x6;
                export const k_CSPlayerBlockingUseAction_MapLongUseEntity_Pickup = 0x5;
            }
            export namespace ENetworkDisconnectionReason {
                export const NETWORK_DISCONNECT_LOST = 0x4;
                export const NETWORK_DISCONNECT_KICKED = 0x27;
                export const NETWORK_DISCONNECT_EXITING = 0x3B;
                export const NETWORK_DISCONNECT_INVALID = 0x0;
                export const NETWORK_DISCONNECT_UNUSUAL = 0x54;
                export const NETWORK_DISCONNECT_USERCMD = 0x2D;
                export const NETWORK_DISCONNECT_BANADDED = 0x28;
                export const NETWORK_DISCONNECT_HLTVSTOP = 0x26;
                export const NETWORK_DISCONNECT_OVERFLOW = 0x5;
                export const NETWORK_DISCONNECT_SHUTDOWN = 0x1;
                export const NETWORK_DISCONNECT_TIMEDOUT = 0x1D;
                export const NETWORK_DISCONNECT_HLTVDIRECT = 0x2A;
                export const NETWORK_DISCONNECT_KICKED_IDLE = 0x9E;
                export const NETWORK_DISCONNECT_STEAM_INUSE = 0x7;
                export const NETWORK_DISCONNECT_STEAM_LOGON = 0x9;
                export const NETWORK_DISCONNECT_BADDELTATICK = 0x1B;
                export const NETWORK_DISCONNECT_DISCONNECTED = 0x1E;
                export const NETWORK_DISCONNECT_HOST_ENDGAME = 0x38;
                export const NETWORK_DISCONNECT_KICKBANADDED = 0x29;
                export const NETWORK_DISCONNECT_LEAVINGSPLIT = 0x1F;
                export const NETWORK_DISCONNECT_LOOPSHUTDOWN = 0x36;
                export const NETWORK_DISCONNECT_NOMORESPLITS = 0x1C;
                export const NETWORK_DISCONNECT_NOSPECTATORS = 0x24;
                export const NETWORK_DISCONNECT_RECONNECTION = 0x35;
                export const NETWORK_DISCONNECT_REJECT_STEAM = 0x92;
                export const NETWORK_DISCONNECT_REMOTE_OTHER = 0x51;
                export const NETWORK_DISCONNECT_STEAM_BANNED = 0x6;
                export const NETWORK_DISCONNECT_STEAM_TICKET = 0x8;
                export const NETWORK_DISCONNECT_CLIENT_NO_MAP = 0x40;
                export const NETWORK_DISCONNECT_REJECT_BANNED = 0x95;
                export const NETWORK_DISCONNECT_SNAPSHOTERROR = 0x19;
                export const NETWORK_DISCONNECT_STEAM_DROPPED = 0x10;
                export const NETWORK_DISCONNECT_HLTVRESTRICTED = 0x23;
                export const NETWORK_DISCONNECT_INTERNAL_ERROR = 0x55;
                export const NETWORK_DISCONNECT_KICKED_SUICIDE = 0x9F;
                export const NETWORK_DISCONNECT_LOOPDEACTIVATE = 0x37;
                export const NETWORK_DISCONNECT_REJECT_NOLOBBY = 0x81;
                export const NETWORK_DISCONNECT_REMOTE_TIMEOUT = 0x4F;
                export const NETWORK_DISCONNECT_HLTVUNAVAILABLE = 0x25;
                export const NETWORK_DISCONNECT_KICKED_TK_START = 0x97;
                export const NETWORK_DISCONNECT_KICKED_VOTEDOFF = 0x9D;
                export const NETWORK_DISCONNECT_REMOTE_BADCRYPT = 0x52;
                export const NETWORK_DISCONNECT_SERVER_SHUTDOWN = 0x45;
                export const NETWORK_DISCONNECT_STEAM_DENY_MISC = 0x43;
                export const NETWORK_DISCONNECT_STEAM_OWNERSHIP = 0x11;
                export const NETWORK_DISCONNECT_BADRELAYPASSWORD = 0x21;
                export const NETWORK_DISCONNECT_REJECTED_BY_GAME = 0x2E;
                export const NETWORK_DISCONNECT_RELIABLEOVERFLOW = 0x1A;
                export const NETWORK_DISCONNECT_SNAPSHOTOVERFLOW = 0x18;
                export const NETWORK_DISCONNECT_TICKMSG_OVERFLOW = 0x13;
                export const NETWORK_DISCONNECT_REJECT_SERVERFULL = 0x87;
                export const NETWORK_DISCONNECT_STEAM_AUTHINVALID = 0xC;
                export const NETWORK_DISCONNECT_STEAM_VACBANSTATE = 0xD;
                export const NETWORK_DISCONNECT_CONNECTION_FAILURE = 0x33;
                export const NETWORK_DISCONNECT_DISCONNECT_BY_USER = 0x2;
                export const NETWORK_DISCONNECT_KICKED_TEAMHURTING = 0x9B;
                export const NETWORK_DISCONNECT_KICKED_TEAMKILLING = 0x96;
                export const NETWORK_DISCONNECT_LOCALPROBLEM_OTHER = 0x4D;
                export const NETWORK_DISCONNECT_REJECT_BADPASSWORD = 0x86;
                export const NETWORK_DISCONNECT_REJECT_HIDDEN_GAME = 0x84;
                export const NETWORK_DISCONNECT_REJECT_LANRESTRICT = 0x85;
                export const NETWORK_DISCONNECT_REJECT_NEWPROTOCOL = 0x8E;
                export const NETWORK_DISCONNECT_REJECT_OLDPROTOCOL = 0x8D;
                export const NETWORK_DISCONNECT_SOUNDSMSG_OVERFLOW = 0x17;
                export const NETWORK_DISCONNECT_BAD_SERVER_PASSWORD = 0x31;
                export const NETWORK_DISCONNECT_KICKED_NOSTEAMLOGIN = 0xA0;
                export const NETWORK_DISCONNECT_MESSAGE_PARSE_ERROR = 0x2F;
                export const NETWORK_DISCONNECT_PURESERVER_MISMATCH = 0x2C;
                export const NETWORK_DISCONNECT_REJECT_BADCHALLENGE = 0x80;
                export const NETWORK_DISCONNECT_REPLAY_INCOMPATIBLE = 0x47;
                export const NETWORK_DISCONNECT_SERVERINFO_OVERFLOW = 0x12;
                export const NETWORK_DISCONNECT_SERVER_INCOMPATIBLE = 0x49;
                export const NETWORK_DISCONNECT_STEAM_AUTHCANCELLED = 0xA;
                export const NETWORK_DISCONNECT_TEMPENTMSG_OVERFLOW = 0x16;
                export const NETWORK_DISCONNECT_BADSPECTATORPASSWORD = 0x22;
                export const NETWORK_DISCONNECT_CLIENT_DIFFERENT_MAP = 0x41;
                export const NETWORK_DISCONNECT_CREATE_SERVER_FAILED = 0x3A;
                export const NETWORK_DISCONNECT_DELTAENTMSG_OVERFLOW = 0x15;
                export const NETWORK_DISCONNECT_DIFFERENTCLASSTABLES = 0x20;
                export const NETWORK_DISCONNECT_DISCONNECT_BY_SERVER = 0x3;
                export const NETWORK_DISCONNECT_KICKED_NOSTEAMTICKET = 0xA1;
                export const NETWORK_DISCONNECT_REJECT_FAILEDCHANNEL = 0x89;
                export const NETWORK_DISCONNECT_REJECT_SINGLE_PLAYER = 0x83;
                export const NETWORK_DISCONNECT_INVALID_MESSAGE_ERROR = 0x30;
                export const NETWORK_DISCONNECT_KICKED_HOSTAGEKILLING = 0x9C;
                export const NETWORK_DISCONNECT_KICKED_INSECURECLIENT = 0xA4;
                export const NETWORK_DISCONNECT_REJECT_BACKGROUND_MAP = 0x82;
                export const NETWORK_DISCONNECT_REJECT_INVALIDCERTLEN = 0x90;
                export const NETWORK_DISCONNECT_REMOTE_CERTNOTTRUSTED = 0x53;
                export const NETWORK_DISCONNECT_SERVER_REQUIRES_STEAM = 0x42;
                export const NETWORK_DISCONNECT_STEAM_AUTHALREADYUSED = 0xB;
                export const NETWORK_DISCONNECT_KICKED_INPUTAUTOMATION = 0xA2;
                export const NETWORK_DISCONNECT_NO_PEER_GROUP_HANDLERS = 0x34;
                export const NETWORK_DISCONNECT_PURESERVER_CLIENTEXTRA = 0x2B;
                export const NETWORK_DISCONNECT_REQUEST_HOSTSTATE_IDLE = 0x3C;
                export const NETWORK_DISCONNECT_CLIENT_CONSISTENCY_FAIL = 0x3E;
                export const NETWORK_DISCONNECT_KICKED_CONVICTEDACCOUNT = 0x99;
                export const NETWORK_DISCONNECT_KICKED_UNTRUSTEDACCOUNT = 0x98;
                export const NETWORK_DISCONNECT_LOCALPROBLEM_MANYRELAYS = 0x4A;
                export const NETWORK_DISCONNECT_LOOP_LEVELLOAD_ACTIVATE = 0x39;
                export const NETWORK_DISCONNECT_REJECT_INVALIDKEYLENGTH = 0x8C;
                export const NETWORK_DISCONNECT_STRINGTABLEMSG_OVERFLOW = 0x14;
                export const NETWORK_DISCONNECT_CLIENT_UNABLE_TO_CRC_MAP = 0x3F;
                export const NETWORK_DISCONNECT_CONNECT_REQUEST_TIMEDOUT = 0x48;
                export const NETWORK_DISCONNECT_REJECT_INVALIDCONNECTION = 0x8F;
                export const NETWORK_DISCONNECT_STEAM_VAC_CHECK_TIMEDOUT = 0xF;
                export const NETWORK_DISCONNECT_REJECT_CONNECT_FROM_LOBBY = 0x8A;
                export const NETWORK_DISCONNECT_REJECT_INVALIDRESERVATION = 0x88;
                export const NETWORK_DISCONNECT_REJECT_RESERVED_FOR_LOBBY = 0x8B;
                export const NETWORK_DISCONNECT_REJECT_SERVERAUTHDISABLED = 0x93;
                export const NETWORK_DISCONNECT_REMOTE_TIMEOUT_CONNECTING = 0x50;
                export const NETWORK_DISCONNECT_STEAM_DENY_BAD_ANTI_CHEAT = 0x44;
                export const NETWORK_DISCONNECT_STEAM_LOGGED_IN_ELSEWHERE = 0xE;
                export const NETWORK_DISCONNECT_DIRECT_CONNECT_RESERVATION = 0x32;
                export const NETWORK_DISCONNECT_KICKED_COMPETITIVECOOLDOWN = 0x9A;
                export const NETWORK_DISCONNECT_LOCALPROBLEM_NETWORKCONFIG = 0x4C;
                export const NETWORK_DISCONNECT_REJECT_INVALIDSTEAMCERTLEN = 0x91;
                export const NETWORK_DISCONNECT_REQUEST_HOSTSTATE_HLTVRELAY = 0x3D;
                export const NETWORK_DISCONNECT_KICKED_VACNETABNORMALBEHAVIOR = 0xA3;
                export const NETWORK_DISCONNECT_REJECT_SERVERCDKEYAUTHINVALID = 0x94;
                export const NETWORK_DISCONNECT_LOCALPROBLEM_HOSTEDSERVERPRIMARYRELAY = 0x4B;
            }
            export namespace PulseCursorCancelPriority_t {
                export const _None = 0x0;
                export const HardCancel = 0x3;
                export const SoftCancel = 0x2;
                export const CancelOnSucceeded = 0x1;
            }
            export namespace SequenceFinishNotifyState_t {
                export const eDoNotNotify = 0x0;
                export const eNotifyTriggered = 0x2;
                export const eNotifyWhenFinished = 0x1;
            }
            export namespace ValueRemapperMomentumType_t {
                export const MomentumType_None = 0x0;
                export const MomentumType_Friction = 0x1;
                export const MomentumType_SpringTowardSnapValue = 0x2;
                export const MomentumType_SpringAwayFromSnapValue = 0x3;
            }
            export namespace WorldTextPanelOrientation_t {
                export const WORLDTEXT_ORIENTATION_DEFAULT = 0x0;
                export const WORLDTEXT_ORIENTATION_FACEUSER = 0x1;
                export const WORLDTEXT_ORIENTATION_FACEUSER_UPRIGHT = 0x2;
            }
            export namespace CDebugOverlayCombinedTypes_t {
                export const ALL = 0x0;
                export const ANY = 0x1;
                export const COUNT = 0x2;
            }
            export namespace CFuncRotator__RotationAxis_t {
                export const ROTATION_AXIS_YAW = 0x1;
                export const ROTATION_AXIS_ROLL = 0x3;
                export const ROTATION_AXIS_PITCH = 0x2;
                export const ROTATION_AXIS_UNDEFINED = 0x0;
            }
            export namespace CRR_Response__ResponseEnum_t {
                export const MAX_RULE_NAME = 0x80;
                export const MAX_RESPONSE_NAME = 0xC0;
            }
            export namespace LessonPanelLayoutFileTypes_t {
                export const LAYOUT_CUSTOM = 0x2;
                export const LAYOUT_HAND_DEFAULT = 0x0;
                export const LAYOUT_WORLD_DEFAULT = 0x1;
            }
            export namespace PointWorldTextReorientMode_t {
                export const POINT_WORLD_TEXT_REORIENT_NONE = 0x0;
                export const POINT_WORLD_TEXT_REORIENT_AROUND_UP = 0x1;
            }
            export namespace CDebugOverlayFilterTextType_t {
                export const COUNT = 0x3;
                export const MATCH = 0x1;
                export const HIERARCHY = 0x2;
                export const FILTER_TEXT_NONE = 0x0;
            }
            export namespace CInfoChoreoLocatorShapeType_t {
                export const LINE = 0x1;
                export const NONE = 0x4;
                export const COUNT = 0x3;
                export const POINT = 0x0;
                export const RADIUS = 0x2;
            }
            export namespace ShatterGlassEntityPoolState_t {
                export const ENTITY_POOL_STATE_IN_USE = 0x2;
                export const ENTITY_POOL_STATE_INVALID = 0x0;
                export const ENTITY_POOL_STATE_AVAILABLE = 0x1;
            }
            export namespace WorldTextPanelVerticalAlign_t {
                export const WORLDTEXT_VERTICAL_ALIGN_TOP = 0x0;
                export const WORLDTEXT_VERTICAL_ALIGN_BOTTOM = 0x2;
                export const WORLDTEXT_VERTICAL_ALIGN_CENTER = 0x1;
            }
            export namespace CFuncMover__FollowConstraint_t {
                export const FOLLOW_CONSTRAINT_RATIO = 0x2;
                export const FOLLOW_CONSTRAINT_SPRING = 0x1;
                export const FOLLOW_CONSTRAINT_COUPLER = 0x3;
                export const FOLLOW_CONSTRAINT_DISTANCE = 0x0;
            }
            export namespace IChoreoServices__ChoreoState_t {
                export const STATE_PRE_SCRIPT = 0x0;
                export const STATE_PLAY_SCRIPT = 0x4;
                export const STATE_WALK_TO_MARK = 0x2;
                export const STATE_WAIT_FOR_SCRIPT = 0x1;
                export const STATE_SYNCHRONIZE_SCRIPT = 0x3;
                export const STATE_PLAY_SCRIPT_POST_IDLE = 0x5;
                export const STATE_PLAY_SCRIPT_POST_IDLE_DONE = 0x6;
            }
            export namespace IChoreoServices__ScriptState_t {
                export const SCRIPT_WAIT = 0x1;
                export const SCRIPT_CLEANUP = 0x3;
                export const SCRIPT_PLAYING = 0x0;
                export const SCRIPT_POST_IDLE = 0x2;
                export const SCRIPT_MOVE_TO_MARK = 0x4;
            }
            export namespace PointOrientGoalDirectionType_t {
                export const eHead = 0x2;
                export const eCenter = 0x1;
                export const eForward = 0x3;
                export const eAbsOrigin = 0x0;
                export const eEyesForward = 0x4;
            }
            export namespace BeginDeathLifeStateTransition_t {
                export const TRANSITION_TO_LIFESTATE_DEAD = 0x1;
                export const TRANSITION_TO_LIFESTATE_DYING = 0x0;
            }
            export namespace CFuncMover__OrientationUpdate_t {
                export const ORIENTATION_FIXED = 0x4;
                export const ORIENTATION_FACE_ENTITY = 0x8;
                export const ORIENTATION_FACE_PLAYER = 0x5;
                export const ORIENTATION_FORWARD_PATH = 0x0;
                export const ORIENTATION_MATCH_CONTROL_POINT = 0x3;
                export const ORIENTATION_FORWARD_MOVEMENT_DIRECTION = 0x6;
                export const ORIENTATION_FORWARD_PATH_AND_FIXED_PITCH = 0x1;
                export const ORIENTATION_FORWARD_PATH_AND_UP_CONTROL_POINT = 0x2;
                export const ORIENTATION_FORWARD_MOVEMENT_DIRECTION_AND_UP_CONTROL_POINT = 0x7;
            }
            export namespace FuncMoverMovementSummaryFlags_t {
                export const eNone = 0x0;
                export const eLoopToEnd = 0x40;
                export const eReversing = 0x8;
                export const eStopBegin = 0x2;
                export const eLoopToStart = 0x20;
                export const eStopComplete = 0x4;
                export const eMovementBegin = 0x1;
                export const eEventsDispatched = 0x10;
                export const eTransitionComplete = 0x80;
                export const eStoppedDuringTransition = 0x100;
            }
            export namespace INavObstacle__NavObstacleType_t {
                export const NAV_OBSTACLE_TYPE_CONN = 0x2;
                export const NAV_OBSTACLE_TYPE_NONE = 0x0;
                export const NAV_OBSTACLE_TYPE_AVOID = 0x1;
                export const NAV_OBSTACLE_TYPE_BLOCK = 0x3;
                export const NAV_OBSTACLE_TYPE_INVALID = -0x1;
                export const NAV_OBSTACLE_TYPE_PERMANENT_BLOCK = 0x4;
            }
            export namespace PointWorldTextJustifyVertical_t {
                export const POINT_WORLD_TEXT_JUSTIFY_VERTICAL_TOP = 0x2;
                export const POINT_WORLD_TEXT_JUSTIFY_VERTICAL_BOTTOM = 0x0;
                export const POINT_WORLD_TEXT_JUSTIFY_VERTICAL_CENTER = 0x1;
            }
            export namespace PreviewCharacterBannerAnimation {
                export const INVALID = -0x1;
                export const BANNER_FIRE = 0x14;
                export const BANNER_3SHOT_A = 0x8;
                export const BANNER_3SHOT_B = 0x9;
                export const BANNER_3SHOT_C = 0xA;
                export const BANNER_4SHOT_A = 0xC;
                export const BANNER_4SHOT_B = 0xD;
                export const BANNER_4SHOT_C = 0xE;
                export const BANNER_4SHOT_D = 0xF;
                export const IDLE_OFFSCREEN = 0x0;
                export const BANNER_AWP_ACE_A = 0x2;
                export const BANNER_AWP_ACE_B = 0x3;
                export const BANNER_AWP_ACE_C = 0x4;
                export const BANNER_AWP_ACE_D = 0x5;
                export const BANNER_AWP_ACE_E = 0x6;
                export const BANNER_BOMB_PLANT = 0x11;
                export const BANNER_AWP_ACE_GUN = 0x1;
                export const BANNER_PISTOL3SHOT = 0x7;
                export const BANNER_PISTOL4SHOT = 0xB;
                export const BANNER_BOMB_BLAST01 = 0x16;
                export const BANNER_BOMB_BLAST02 = 0x17;
                export const BANNER_BOMB_BLAST03 = 0x18;
                export const BANNER_CELEBRATE_01 = 0x19;
                export const BANNER_CELEBRATE_02 = 0x1A;
                export const BANNER_CELEBRATE_03 = 0x1B;
                export const BANNER_CELEBRATE_04 = 0x1C;
                export const BANNER_BOMB_BLAST_TOSS = 0x15;
                export const BANNER_BOMB_DEFUSAL_VER1 = 0x12;
                export const BANNER_BOMB_DEFUSAL_VER2 = 0x13;
                export const CELEBRATE_STRETCH_NOWEAP_IDLE0 = 0x10;
            }
            export namespace PropDoorRotatingOpenDirection_e {
                export const DOOR_ROTATING_OPEN_FORWARD = 0x1;
                export const DOOR_ROTATING_OPEN_BACKWARD = 0x2;
                export const DOOR_ROTATING_OPEN_BOTH_WAYS = 0x0;
            }
            export namespace WorldTextPanelHorizontalAlign_t {
                export const WORLDTEXT_HORIZONTAL_ALIGN_LEFT = 0x0;
                export const WORLDTEXT_HORIZONTAL_ALIGN_RIGHT = 0x2;
                export const WORLDTEXT_HORIZONTAL_ALIGN_CENTER = 0x1;
            }
            export namespace EGCItemCustomizationNotification {
                export const k_EGCItemCustomizationNotification_NameItem = 0x3EE;
                export const k_EGCItemCustomizationNotification_ApplyPatch = 0x442;
                export const k_EGCItemCustomizationNotification_CasketAdded = 0x3F5;
                export const k_EGCItemCustomizationNotification_RemovePatch = 0x441;
                export const k_EGCItemCustomizationNotification_UnlockCrate = 0x3EF;
                export const k_EGCItemCustomizationNotification_ApplySticker = 0x43E;
                export const k_EGCItemCustomizationNotification_NameBaseItem = 0x3FB;
                export const k_EGCItemCustomizationNotification_StatTrakSwap = 0x440;
                export const k_EGCItemCustomizationNotification_ApplyKeychain = 0x443;
                export const k_EGCItemCustomizationNotification_CasketInvFull = 0x3F7;
                export const k_EGCItemCustomizationNotification_CasketRemoved = 0x3F6;
                export const k_EGCItemCustomizationNotification_CasketTooFull = 0x3F3;
                export const k_EGCItemCustomizationNotification_RemoveSticker = 0x41D;
                export const k_EGCItemCustomizationNotification_XRayItemClaim = 0x3F1;
                export const k_EGCItemCustomizationNotification_CasketContents = 0x3F4;
                export const k_EGCItemCustomizationNotification_ExtractSticker = 0x41E;
                export const k_EGCItemCustomizationNotification_GraffitiUnseal = 0x23E1;
                export const k_EGCItemCustomizationNotification_RemoveItemName = 0x406;
                export const k_EGCItemCustomizationNotification_RemoveKeychain = 0x444;
                export const k_EGCItemCustomizationNotification_XRayItemReveal = 0x3F0;
                export const k_EGCItemCustomizationNotification_XpShopAckTracks = 0x2406;
                export const k_EGCItemCustomizationNotification_XpShopUseTicket = 0x2405;
                export const k_EGCItemCustomizationNotification_ActivateFanToken = 0x23DA;
                export const k_EGCItemCustomizationNotification_GenerateSouvenir = 0x23F4;
                export const k_EGCItemCustomizationNotification_EncapsulateSticker = 0x41F;
                export const k_EGCItemCustomizationNotification_ActivateOperationCoin = 0x23DB;
                export const k_EGCItemCustomizationNotification_ClientRedeemFreeReward = 0x2403;
                export const k_EGCItemCustomizationNotification_ClientRedeemMissionReward = 0x23F9;
            }
            export namespace CFuncMover__PathRebuildStrategy_t {
                export const PATH_REBUILD_DONT_MOVE = 0x0;
                export const PATH_REBUILD_MAINTAIN_T = 0x1;
                export const PATH_REBUILD_USE_CURRENT_NODE_T = 0x2;
            }
            export namespace FuncRotatorRotationSummaryFlags_t {
                export const eNone = 0x0;
                export const eRotateBegin = 0x1;
                export const eOscillateEnd = 0x10;
                export const eOscillateStart = 0x8;
                export const eOscillateDepart = 0x40;
                export const eRotateCompleted = 0x4;
                export const eEventsDispatched = 0x2;
                export const eOscillateArrived = 0x20;
            }
            export namespace PointWorldTextJustifyHorizontal_t {
                export const POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_LEFT = 0x0;
                export const POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_RIGHT = 0x2;
                export const POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_CENTER = 0x1;
            }
            export namespace TestInputOutputCombinationsEnum_t {
                export const ONE = 0x1;
                export const TWO = 0x2;
                export const ZERO = 0x0;
            }
            export namespace ECSUsrMsg_DisconnectToLobby_Action {
                export const k_ECSUsrMsg_DisconnectToLobby_Action_Default = 0x0;
                export const k_ECSUsrMsg_DisconnectToLobby_Action_GoQueue = 0x1;
            }
            export namespace PointTemplateOwnerSpawnGroupType_t {
                export const INSERT_INTO_NEWLY_CREATED_SPAWN_GROUP = 0x2;
                export const INSERT_INTO_POINT_TEMPLATE_SPAWN_GROUP = 0x0;
                export const INSERT_INTO_CURRENTLY_ACTIVE_SPAWN_GROUP = 0x1;
            }
            export namespace CCSPlayerAnimationState__MoveType_t {
                export const Air = 0x2;
                export const _None = 0x0;
                export const Ground = 0x1;
                export const Ladder = 0x3;
            }
            export namespace CFuncMover__FollowEntityDirection_t {
                export const FOLLOW_ENTITY_FORWARD = 0x1;
                export const FOLLOW_ENTITY_REVERSE = 0x2;
                export const FOLLOW_ENTITY_BIDIRECTIONAL = 0x0;
            }
            export namespace ExternalAnimGraphInactiveBehavior_t {
                export const eNone = 0x0;
                export const eUnbind = 0x1;
                export const eUnbindAndDelete = 0x2;
            }
            export namespace CCSPlayerAnimationState__AirAction_t {
                export const Jump = 0x1;
                export const Land = 0x3;
                export const _None = 0x0;
                export const StartFall = 0x2;
            }
            export namespace CCSPlayerAnimationState__Direction_t {
                export const E = 0x3;
                export const N = 0x1;
                export const S = 0x5;
                export const W = 0x7;
                export const NE = 0x2;
                export const NW = 0x8;
                export const SE = 0x4;
                export const SW = 0x6;
                export const _None = 0x0;
            }
            export namespace CFuncMover__FindFollowMoverStrategy_t {
                export const FIND_FOLLOW_MOVER_FORWARD_CLOSEST = 0x0;
                export const FIND_FOLLOW_MOVER_REVERSE_CLOSEST = 0x1;
                export const FIND_FOLLOW_MOVER_BIDIRECTIONAL_CLOSEST = 0x2;
            }
            export namespace ChoreoExternalAnimgraphControlState_t {
                export const eExit = 0x1;
                export const eNone = 0x0;
                export const eCount = 0x9;
                export const eLooping = 0x8;
                export const eState01 = 0x3;
                export const eState02 = 0x4;
                export const eState03 = 0x5;
                export const eState04 = 0x6;
                export const eState05 = 0x7;
                export const eFallbackExit = 0x2;
            }
            export namespace EDestructiblePartDamagePassThroughType {
                export const Absorb = 0x1;
                export const Normal = 0x0;
                export const InvincibleAbsorb = 0x2;
                export const InvinciblePassthrough = 0x3;
            }
            export namespace EDestructiblePartRadiusDamageApplyType {
                export const PrioritizeClosestPart = 0x1;
                export const ScaleByExplosionRadius = 0x0;
            }
            export namespace PointTemplateClientOnlyEntityBehavior_t {
                export const CREATE_FOR_CLIENTS_WHO_CONNECT_LATER = 0x1;
                export const CREATE_FOR_CURRENTLY_CONNECTED_CLIENTS_ONLY = 0x0;
            }
            export namespace CFuncMover__TransitionToPathNodeAction_t {
                export const TRANSITION_TO_PATH_NODE_ACTION_NONE = 0x0;
                export const TRANSITION_TO_PATH_NODE_TRANSITIONING = 0x3;
                export const TRANSITION_TO_PATH_NODE_ACTION_START_FORWARD = 0x1;
                export const TRANSITION_TO_PATH_NODE_ACTION_START_REVERSE = 0x2;
            }
            export namespace EDestructibleParts_DestroyParameterFlags {
                export const _None = 0x0;
                export const Default = 0x7;
                export const EnableFlinches = 0x4;
                export const ForceDamageApply = 0x8;
                export const ApplyPhysicsForce = 0x40;
                export const IgnoreHealthCheck = 0x20;
                export const GenerateBreakpieces = 0x1;
                export const IgnoreKillEntityFlag = 0x10;
                export const SetBodyGroupAndCollisionState = 0x2;
            }
            export namespace CCSPlayerAnimationState__GroundMoveState_t {
                export const Idle = 0x1;
                export const Move = 0x3;
                export const _None = 0x0;
                export const Start = 0x2;
                export const TurnOnSpot = 0x4;
                export const PlantAndTurn = 0x6;
                export const TurnOnSpotLoop = 0x5;
            }
            export namespace DestructiblePartDestructionDeathBehavior_t {
                export const eGib = 0x2;
                export const eKill = 0x1;
                export const eRemove = 0x3;
                export const eDoNotKill = 0x0;
            }
            export namespace EProceduralRagdollWeightIndexPropagationMethod {
                export const Bone = 0x0;
                export const BoneAndChildren = 0x1;
            }
            export namespace CLogicBranchList__LogicBranchListenerLastState_t {
                export const LOGIC_BRANCH_LISTENER_MIXED = 0x3;
                export const LOGIC_BRANCH_LISTENER_ALL_TRUE = 0x1;
                export const LOGIC_BRANCH_LISTENER_NOT_INIT = 0x0;
                export const LOGIC_BRANCH_LISTENER_ALL_FALSE = 0x2;
            }
            export namespace CPathMoverEntitySpawner__TemplateChoiceStrategy_t {
                export const TEMPLATE_CHOICE_COUNT_RANDOM = 0x2;
                export const TEMPLATE_CHOICE_WEIGHTED_RANDOM = 0x1;
                export const TEMPLATE_CHOICE_COUNT_SEQUENTIAL = 0x0;
            }
        }
    }
}
