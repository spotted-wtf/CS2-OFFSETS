class cs2_dumper:
    class schemas:
        class server_dll:
            class CC4:
                m_fArmedTime = 0x12CC
                m_nSpotRules = 0x12F0
                m_bBombPlanted = 0x12FB
                m_bStartedArming = 0x12C9
                m_bIsPlantingViaUse = 0x12D1
                m_bPlayedArmingBeeps = 0x12F4
                m_entitySpottedState = 0x12D8
                m_bBombPlacedAnimation = 0x12D0
                m_vecLastValidDroppedPosition = 0x12BC
                m_bDoValidDroppedPositionCheck = 0x12C8
                m_vecLastValidPlayerHeldPosition = 0x12B0
            class CBot:
                m_id = 0x24
                m_pPlayer = 0x18
                m_isRunning = 0xC0
                m_leftSpeed = 0xC8
                m_bHasSpawned = 0x20
                m_buttonFlags = 0xD0
                m_isCrouching = 0xC1
                m_pController = 0x10
                m_viewForward = 0xDC
                m_forwardSpeed = 0xC4
                m_jumpTimestamp = 0xD8
                m_verticalSpeed = 0xCC
                m_postureStackIndex = 0xF8
            class CAK47:
                pass
            class CBeam:
                m_fSpeed = 0x8CC
                m_fWidth = 0x8B4
                m_flFrame = 0x8D0
                m_flDamage = 0x85C
                m_fEndWidth = 0x8B8
                m_nBeamType = 0x878
                m_vecEndPos = 0x8D8
                m_bTurnedOff = 0x8D4
                m_fAmplitude = 0x8C4
                m_fHaloScale = 0x8C0
                m_flFireTime = 0x858
                m_hEndEntity = 0x8E4
                m_nBeamFlags = 0x87C
                m_nHaloIndex = 0x870
                m_fFadeLength = 0x8BC
                m_fStartFrame = 0x8C8
                m_flFrameRate = 0x850
                m_nAttachIndex = 0x8A8
                m_nNumBeamEnts = 0x860
                m_hAttachEntity = 0x880
                m_hBaseMaterial = 0x868
                m_nDissolveType = 0x8E8
                m_flHDRColorScale = 0x854
            class CFish:
                m_x = 0xA48
                m_y = 0xA4C
                m_z = 0xA50
                m_id = 0xA44
                m_perp = 0xA68
                m_pool = 0xA40
                m_angle = 0xA54
                m_speed = 0xA84
                m_forward = 0xA5C
                m_goTimer = 0xAB8
                m_visible = 0xB30
                m_calmSpeed = 0xA8C
                m_moveTimer = 0xAD0
                m_turnTimer = 0xA98
                m_avoidRange = 0xA94
                m_panicSpeed = 0xA90
                m_panicTimer = 0xAE8
                m_poolOrigin = 0xA74
                m_waterLevel = 0xA80
                m_angleChange = 0xA58
                m_desiredSpeed = 0xA88
                m_disperseTimer = 0xB00
                m_turnClockwise = 0xAB0
                m_proximityTimer = 0xB18
            class CItem:
                m_OnGlovePulled = 0xA98
                m_OnPlayerTouch = 0xA48
                m_OnPlayerPickup = 0xA60
                m_bPhysStartAsleep = 0xAC8
                m_OnCacheInteraction = 0xA80
                m_bActivateWhenAtRest = 0xA78
                m_vOriginalSpawnAngles = 0xABC
                m_vOriginalSpawnOrigin = 0xAB0
            class CTeam:
                m_iScore = 0x4D8
                m_aPlayers = 0x4C0
                m_szTeamname = 0x4DC
                m_aPlayerControllers = 0x4A8
            class CBlood:
                m_Color = 0x4C4
                m_flAmount = 0x4C0
                m_vecSprayDir = 0x4B4
                m_vecSprayAngles = 0x4A8
            class CCSBot:
                m_name = 0x114
                m_avoid = 0x5F4
                m_enemy = 0x5A00
                m_avgVel = 0x5DCC
                m_bomber = 0x5C38
                m_leader = 0x1AC
                m_aimGoal = 0x59C4
                m_isRogue = 0x158
                m_isStuck = 0x5D83
                m_lookYaw = 0x598C
                m_wasSafe = 0x184
                m_aimError = 0x59B8
                m_aimFocus = 0x59D4
                m_attacker = 0x5C58
                m_safeTime = 0x180
                m_blindFire = 0x18C
                m_hasJoined = 0x52BC
                m_lookPitch = 0x5984
                m_pathIndex = 0x4F00
                m_stuckSpot = 0x5D88
                m_waitTimer = 0x4FE8
                m_zoomTimer = 0x5C88
                m_alertTimer = 0x1D0
                m_equipTimer = 0x5C78
                m_goalEntity = 0x5F0
                m_hurryTimer = 0x1B8
                m_isStopping = 0x5FC
                m_lastOrigin = 0x5DFC
                m_lookAtDesc = 0x5380
                m_lookAtSpot = 0x5360
                m_lookYawVel = 0x5990
                m_panicTimer = 0x200
                m_rogueTimer = 0x160
                m_sneakTimer = 0x1E8
                m_stillTimer = 0x600
                m_targetSpot = 0x5994
                m_taskEntity = 0x5D4
                m_avgVelCount = 0x5DF8
                m_avgVelIndex = 0x5DF4
                m_bIsSleeping = 0x5CC0
                m_combatRange = 0x154
                m_desiredTeam = 0x52B8
                m_eyePosition = 0x108
                m_isAttacking = 0x5CC
                m_isFollowing = 0x1A9
                m_lookUpAngle = 0x5350
                m_noiseSource = 0x5308
                m_politeTimer = 0x4F40
                m_repathTimer = 0x4F08
                m_wiggleTimer = 0x5D98
                m_bAllowActive = 0x1A8
                m_forwardAngle = 0x5354
                m_goalPosition = 0x5E4
                m_lastVictimID = 0x5C70
                m_lookPitchVel = 0x5988
                m_mustRunTimer = 0x4FD0
                m_radioSubject = 0x5E14
                m_diedLastRound = 0x17C
                m_isOpeningDoor = 0x5CD
                m_isRapidFiring = 0x5C75
                m_noisePosition = 0x52F0
                m_pathLadderEnd = 0x4F84
                m_radioPosition = 0x5E18
                m_surpriseTimer = 0x190
                m_avoidTimestamp = 0x5F8
                m_isEnemyVisible = 0x5A04
                m_lookAheadAngle = 0x534C
                m_noiseBendTimer = 0x5320
                m_noiseTimestamp = 0x5300
                m_stateTimestamp = 0x5C8
                m_stuckJumpTimer = 0x5DB0
                m_stuckTimestamp = 0x5D84
                m_targetSpotTime = 0x59D0
                m_enemyQueueCount = 0x5D81
                m_enemyQueueIndex = 0x5D80
                m_followTimestamp = 0x1B0
                m_isAimingAtEnemy = 0x5C74
                m_isLastEnemyDead = 0x5A28
                m_viewSteadyTimer = 0x5520
                m_aimFocusInterval = 0x59D8
                m_avoidFriendTimer = 0x4F20
                m_isFriendInTheWay = 0x4F38
                m_lookAtSpotAttack = 0x537D
                m_nearbyEnemyCount = 0x5A2C
                m_tossGrenadeTimer = 0x5538
                m_attackedTimestamp = 0x5C5C
                m_attentionInterval = 0x5C48
                m_bentNoisePosition = 0x5338
                m_isAvoidingGrenade = 0x5558
                m_lastEnemyPosition = 0x5A08
                m_nearbyFriendCount = 0x5C3C
                m_visibleEnemyParts = 0x5A05
                m_voiceEndTimestamp = 0x5E24
                m_aimFocusNextUpdate = 0x59DC
                m_approachPointCount = 0x5510
                m_hostageEscortCount = 0x52B0
                m_ignoreEnemiesTimer = 0x59E8
                m_lookAtSpotDuration = 0x5370
                m_spotCheckTimestamp = 0x5578
                m_targetSpotVelocity = 0x59A0
                m_allowAutoFollowTime = 0x1B4
                m_burnedByFlamesTimer = 0x5C60
                m_enemyDeathTimestamp = 0x5A20
                m_fireWeaponTimestamp = 0x5CA0
                m_isWaitingForHostage = 0x52BD
                m_lookAtSpotTimestamp = 0x5374
                m_noiseTravelDistance = 0x52FC
                m_peripheralTimestamp = 0x5388
                m_sawEnemySniperTimer = 0x5CC8
                m_targetSpotPredicted = 0x59AC
                m_travelDistancePhase = 0x5118
                m_waitForHostageTimer = 0x52D8
                m_areaEnteredTimestamp = 0x4F04
                m_closestVisibleFriend = 0x5C40
                m_friendDeathTimestamp = 0x5A24
                m_hasVisitedEnemySpawn = 0x5FD
                m_isEnemySniperVisible = 0x5CC1
                m_playerTravelDistance = 0x5018
                m_enemyQueueAttendIndex = 0x5D82
                m_isWaitingBehindFriend = 0x4F58
                m_lastSawEnemyTimestamp = 0x5A14
                m_bendNoisePositionValid = 0x5344
                m_checkedHidingSpotCount = 0x5980
                m_firstSawEnemyTimestamp = 0x5A18
                m_lastRadioSentTimestamp = 0x5E10
                m_lookAtSpotClearIfClose = 0x537C
                m_lookAroundStateTimestamp = 0x5348
                m_lookAtSpotAngleTolerance = 0x5378
                m_approachPointViewPosition = 0x5514
                m_closestVisibleHumanFriend = 0x5C44
                m_nextCleanupCheckTimestamp = 0x5DC8
                m_updateTravelDistanceTimer = 0x5000
                m_inhibitLookAroundTimestamp = 0x5358
                m_lastRadioRecievedTimestamp = 0x5E0C
                m_hostageEscortCountTimestamp = 0x52B4
                m_lastValidReactionQueueFrame = 0x5E30
                m_lookForWeaponsOnGroundTimer = 0x5CA8
                m_currentEnemyAcquireTimestamp = 0x5A1C
                m_inhibitWaitingForHostageTimer = 0x52C0
                m_bEyeAnglesUnderPathFinderControl = 0x610
            class CKnife:
                m_bFirstAttack = 0x1280
            class CWorld:
                pass
            class Extent:
                hi = 0xC
                lo = 0x0
            class CBtNode:
                pass
            class CCSTeam:
                m_iClanID = 0x800
                m_bSurrendered = 0x568
                m_scoreOvertime = 0x778
                m_scoreFirstHalf = 0x770
                m_szClanTeamname = 0x77C
                m_numMapVictories = 0x76C
                m_scoreSecondHalf = 0x774
                m_szTeamFlagImage = 0x804
                m_szTeamLogoImage = 0x80C
                m_szTeamMatchStat = 0x569
                m_iLastUpdateSentAt = 0x818
                m_flNextResourceTime = 0x814
                m_nShorthandedRoundBonusStartRound = 0x564
                m_nLastRecievedShorthandedRoundBonus = 0x560
            class CDEagle:
                pass
            class CEnvSky:
                m_bEnabled = 0x884
                m_nFogType = 0x870
                m_vTintColor = 0x864
                m_flFogMaxEnd = 0x880
                m_flFogMinEnd = 0x878
                m_hSkyMaterial = 0x850
                m_flFogMaxStart = 0x87C
                m_flFogMinStart = 0x874
                m_bStartDisabled = 0x860
                m_flBrightnessScale = 0x86C
                m_vTintColorLightingOnly = 0x868
                m_hSkyMaterialLightingOnly = 0x858
            class CShower:
                m_flSpeed = 0x850
            class CSprite:
                m_flFrame = 0x864
                m_flSpeed = 0x8BC
                m_flDieTime = 0x868
                m_flLastTime = 0x894
                m_flMaxFrame = 0x898
                m_flDestScale = 0x8A0
                m_nAttachment = 0x85C
                m_nBrightness = 0x878
                m_flStartScale = 0x89C
                m_nSpriteWidth = 0x8B4
                m_flSpriteScale = 0x880
                m_nSpriteHeight = 0x8B8
                m_flGlowProxySize = 0x88C
                m_flHDRColorScale = 0x890
                m_flScaleDuration = 0x884
                m_hSpriteMaterial = 0x850
                m_nDestBrightness = 0x8AC
                m_bWorldSpaceScale = 0x888
                m_flScaleTimeStart = 0x8A4
                m_nStartBrightness = 0x8A8
                m_flSpriteFramerate = 0x860
                m_hAttachedToEntity = 0x858
                m_flBrightnessDuration = 0x87C
                m_flBrightnessTimeStart = 0x8B0
            class CBuyZone:
                m_LegacyTeamNum = 0x9C8
            class CCSPlace:
                m_name = 0x868
            class CChicken:
                m_owner = 0x11AC
                m_leader = 0x11A8
                m_fleeFrom = 0x115C
                m_turnRate = 0x1158
                m_jumpTimer = 0x11D8
                m_isOnGround = 0x1128
                m_reuseTimer = 0x11C0
                m_repathTimer = 0x3200
                m_stuckAnchor = 0x1100
                m_updateTimer = 0x10E8
                m_vecPathGoal = 0x3298
                m_startleTimer = 0x1178
                m_activityTimer = 0x1140
                m_vFallVelocity = 0x112C
                m_vocalizeTimer = 0x1190
                m_flLastJumpTime = 0x11F0
                m_currentActivity = 0x113C
                m_desiredActivity = 0x1138
                m_AttributeManager = 0xCB0
                m_followMinuteTimer = 0x32A8
                m_BlockDirectionTimer = 0x32C8
                m_collisionStuckTimer = 0x1110
                m_bSpawnDyingParticles = 0x32E2
                m_moveRateThrottleTimer = 0x1160
                m_flActiveFollowStartTime = 0x32A4
            class CCredits:
                m_flLogoLength = 0x4C4
                m_OnCreditsDone = 0x4A8
                m_bRolledOutroCredits = 0x4C0
            class CEnvBeam:
                m_life = 0x910
                m_speed = 0x91C
                m_active = 0x8F0
                m_radius = 0x94C
                m_hFilter = 0x960
                m_iszDecal = 0x968
                m_restrike = 0x920
                m_TouchType = 0x950
                m_boltWidth = 0x914
                m_frameStart = 0x930
                m_iFilterName = 0x958
                m_iszEndEntity = 0x908
                m_iszSpriteName = 0x928
                m_spriteTexture = 0x8F8
                m_iszStartEntity = 0x900
                m_noiseAmplitude = 0x918
                m_vEndPointWorld = 0x934
                m_OnTouchedByEntity = 0x970
                m_vEndPointRelative = 0x940
            class CEnvFade:
                m_Duration = 0x4AC
                m_fadeColor = 0x4A8
                m_OnBeginFade = 0x4B8
                m_HoldDuration = 0x4B0
            class CEnvTilt:
                m_Radius = 0x4AC
                m_Duration = 0x4A8
                m_TiltTime = 0x4B0
                m_stopTime = 0x4B4
            class CEnvWind:
                m_EnvWindShared = 0x4A8
            class CGameEnd:
                pass
            class CHostage:
                m_vel = 0xBC0
                m_accel = 0xBFC
                m_leader = 0xBD4
                m_bRemove = 0xBBC
                m_OnRescued = 0xB80
                m_isRescued = 0xBCC
                m_isRunning = 0xC08
                m_jumpTimer = 0xC10
                m_isAdjusted = 0x2D1C
                m_lastLeader = 0xBD8
                m_nSpotRules = 0xBB0
                m_reuseTimer = 0xBE0
                m_hasBeenUsed = 0xBF8
                m_isCrouching = 0xC09
                m_repathTimer = 0x2C38
                m_wiggleTimer = 0x2D00
                m_fLastGrabTime = 0x2D24
                m_nHostageState = 0xBD0
                m_vecGrabbedPos = 0x2D34
                m_OnFirstPickedUp = 0xB50
                m_flDropStartTime = 0x2D48
                m_hHostageGrabber = 0x2D20
                m_jumpedThisFrame = 0xBCD
                m_inhibitDoorTimer = 0x2C50
                m_bHandsHaveBeenCut = 0x2D1D
                m_flGrabSuccessTime = 0x2D44
                m_flRescueStartTime = 0x2D40
                m_nPickupEventCount = 0x2D50
                m_vecSpawnGroundPos = 0x2D54
                m_OnHostageBeginGrab = 0xB38
                m_entitySpottedState = 0xB98
                m_isWaitingForLeader = 0xC28
                m_OnDroppedNotRescued = 0xB68
                m_nApproachRewardPayouts = 0x2D4C
                m_vecHostageResetPosition = 0x2D8C
                m_nHostageSpawnRandomFactor = 0xBB8
                m_inhibitObstacleAvoidanceTimer = 0x2CE0
                m_uiHostageSpawnExclusionGroupMask = 0xBB4
                m_vecPositionWhenStartedDroppingToGround = 0x2D28
            class CInferno:
                m_extent = 0x13A8
                m_startPos = 0x1408
                m_fireCount = 0x1190
                m_BurnNormal = 0xE90
                m_nMaxFlames = 0x1434
                m_activeTimer = 0x1420
                m_damageTimer = 0x13C0
                m_nInfernoType = 0x1194
                m_nSpreadCount = 0x1438
                m_firePositions = 0x850
                m_nFireLifetime = 0x119C
                m_bFireIsBurning = 0xE50
                m_splashVelocity = 0x13F0
                m_NextSpreadTimer = 0x1458
                m_damageRampTimer = 0x13D8
                m_fireSpawnOffset = 0x1430
                m_BookkeepingTimer = 0x1440
                m_bInPostEffectTime = 0x11A0
                m_bWasCreatedInSmoke = 0x11A1
                m_fireParentPositions = 0xB50
                m_nSourceItemDefIndex = 0x1470
                m_nFireEffectTickBegin = 0x1198
                m_InitialSplashVelocity = 0x13FC
                m_vecOriginalSpawnLocation = 0x1414
            class CInfoFan:
                m_flCurveDistRange = 0x4F0
                m_fFanForceMaxRadius = 0x4E8
                m_fFanForceMinRadius = 0x4EC
                m_FanForceCurveString = 0x4F8
            class CMapInfo:
                m_flBombRadius = 0x4AC
                m_iBuyingStatus = 0x4A8
                m_iHostageCount = 0x4BC
                m_bGPUCullSkybox = 0x4C2
                m_iPetPopulation = 0x4B0
                m_flEnvRainStrength = 0x4C4
                m_flEnvWetnessCoverage = 0x4D0
                m_bUseNormalSpawnsForDM = 0x4B4
                m_bRainTraceToSkyEnabled = 0x4C1
                m_flBotMaxVisionDistance = 0x4B8
                m_flEnvWetnessDryingAmount = 0x4D4
                m_bFadePlayerVisibilityFarZ = 0x4C0
                m_flEnvPuddleRippleStrength = 0x4C8
                m_flEnvPuddleRippleDirection = 0x4CC
                m_bDisableAutoGeneratedDMSpawns = 0x4B5
            class CMessage:
                m_Radius = 0x4B8
                m_sNoise = 0x4C0
                m_iszMessage = 0x4A8
                m_MessageVolume = 0x4B0
                m_OnShowMessage = 0x4C8
                m_MessageAttenuation = 0x4B4
            class CPhysBox:
                m_OnDamaged = 0x978
                m_OnAwakened = 0x990
                m_damageType = 0x928
                m_OnPlayerUse = 0x9C0
                m_OnStartTouch = 0x9D8
                m_iszInteractsAs = 0x960
                m_OnMotionEnabled = 0x9A8
                m_nHoverPoseFlags = 0x94E
                m_bEnableUseOutput = 0x94D
                m_bNotSolidToWorld = 0x94C
                m_iszInteractsWith = 0x968
                m_iszCollisionGroup = 0x958
                m_angHoverPoseAngles = 0x940
                m_vHoverPosePosition = 0x934
                m_iszInteractsExclude = 0x970
                m_damageToEnableMotion = 0x92C
                m_flForceToEnableMotion = 0x930
                m_flTouchOutputPerEntityDelay = 0x950
            class CRotDoor:
                m_bSolidBsp = 0xA58
            class IRagdoll:
                pass
            class PathCost:
                m_dangerFactor = 0x3C
                m_flAgentMaxClimb = 0x44
                m_damagingAreasPenaltyCost = 0x40
            class CBaseDoor:
                m_ls = 0x8F8
                m_OnOpen = 0x9F8
                m_OnClose = 0x9E0
                m_bLocked = 0x91A
                m_bNoNPCs = 0x91C
                m_flSpeed = 0xA4C
                m_bIsUsable = 0xA51
                m_bDoorGroup = 0x919
                m_isChaining = 0xA50
                m_ChainTarget = 0x948
                m_NoiseMoving = 0x928
                m_OnFullyOpen = 0x9C8
                m_OnLockedUse = 0xA10
                m_NoiseArrived = 0x930
                m_bForceClosed = 0x918
                m_OnFullyClosed = 0x9B0
                m_bIgnoreDebris = 0x91B
                m_flBlockDamage = 0x924
                m_bLoopMoveSound = 0xA28
                m_eSpawnPosition = 0x920
                m_OnBlockedClosing = 0x950
                m_OnBlockedOpening = 0x968
                m_NoiseMovingClosed = 0x938
                m_NoiseArrivedClosed = 0x940
                m_OnUnblockedClosing = 0x980
                m_OnUnblockedOpening = 0x998
                m_angMoveEntitySpace = 0x8E0
                m_bCreateNavObstacle = 0xA48
                m_vecMoveDirParentSpace = 0x8EC
            class CBaseProp:
                m_iShapeType = 0xA44
                m_bModelOverrodeBlockLOS = 0xA40
                m_mPreferredCatchTransform = 0xA50
                m_bConformToCollisionBounds = 0xA48
            class CCSSprite:
                pass
            class CEnvDecal:
                m_flDepth = 0x860
                m_flWidth = 0x858
                m_flHeight = 0x85C
                m_nRenderOrder = 0x864
                m_hDecalMaterial = 0x850
                m_bProjectOnWater = 0x86A
                m_bProjectOnWorld = 0x868
                m_flDepthSortBias = 0x86C
                m_bProjectOnCharacters = 0x869
            class CEnvLaser:
                m_pSprite = 0x8F8
                m_firePosition = 0x908
                m_flStartFrame = 0x914
                m_iszSpriteName = 0x900
                m_iszLaserTarget = 0x8F0
            class CEnvShake:
                m_Radius = 0x4BC
                m_Duration = 0x4B8
                m_maxForce = 0x4CC
                m_stopTime = 0x4C0
                m_Amplitude = 0x4B0
                m_Frequency = 0x4B4
                m_nextShake = 0x4C4
                m_currentAmp = 0x4C8
                m_limitToEntity = 0x4A8
                m_shakeCallback = 0x4E0
                m_pShakeController = 0x4D8
            class CEnvSpark:
                m_nType = 0x4B4
                m_OnSpark = 0x4B8
                m_flDelay = 0x4A8
                m_nMagnitude = 0x4AC
                m_nTrailLength = 0x4B0
            class CFishPool:
                m_fishes = 0x4D0
                m_maxRange = 0x4BC
                m_visTimer = 0x4E8
                m_fishCount = 0x4B8
                m_isDormant = 0x4C8
                m_swimDepth = 0x4C0
                m_waterLevel = 0x4C4
            class CFuncPlat:
                m_sNoise = 0x900
                m_flSpeed = 0x8F8
            class CFuncWall:
                m_nState = 0x850
            class CGameText:
                m_textParms = 0x868
                m_iszMessage = 0x860
            class CInfoData:
                pass
            class CItemSoda:
                pass
            class CNavFlags:
                m_Flags = 0x0
            class CPathNode:
                m_hPath = 0x4F0
                m_xWSPrevParent = 0x4D0
                m_vInTangentLocal = 0x4A8
                m_vOutTangentLocal = 0x4B4
                m_strPathNodeParameter = 0x4C8
                m_strParentPathUniqueID = 0x4C0
            class CPushable:
                pass
            class CRangeInt:
                m_pValue = 0x0
            class CSimTimer:
                m_flInterval = 0x8
            class CSkillInt:
                m_pValue = 0x0
            class CTimeline:
                m_bStopped = 0x220
                m_flValues = 0x10
                m_flInterval = 0x214
                m_flFinalValue = 0x218
                m_nBucketCount = 0x210
                m_nValueCounts = 0x110
                m_nCompressionType = 0x21C
            class NavHull_t:
                m_nHullIdx = 0x0
            class ragdoll_t:
                list = 0x0
                unused = 0x49
                boneIndex = 0x30
                allowStretch = 0x48
                hierarchyJoints = 0x18
            class CBarnLight:
                m_nFog = 0x9D8
                m_Color = 0x858
                m_vShear = 0x98C
                m_flRange = 0x988
                m_flShape = 0x968
                m_flSkirt = 0x974
                m_flSoftX = 0x96C
                m_flSoftY = 0x970
                m_bEnabled = 0x850
                m_StyleEvent = 0x8E0
                m_flFogScale = 0x9E4
                m_nColorMode = 0x854
                m_VisClusters = 0xB18
                m_flSkirtNear = 0x978
                m_nFogShadows = 0x9E0
                m_vSizeParams = 0x97C
                m_flBrightness = 0x860
                m_hLightCookie = 0x960
                m_nBounceLight = 0x9BC
                m_nCastShadows = 0x9AC
                m_nDirectLight = 0x868
                m_flBounceScale = 0x9C0
                m_flFadeSizeEnd = 0x9EC
                m_flFogStrength = 0x9DC
                m_bContactShadow = 0x9B8
                m_flMinRoughness = 0x9C4
                m_nShadowMapSize = 0x9B0
                m_bTransmitAlways = 0xB15
                m_flFadeSizeStart = 0x9E8
                m_flLuminaireSize = 0x87C
                m_nLuminaireShape = 0x878
                m_nShadowPriority = 0x9B4
                m_vAlternateColor = 0x9C8
                m_LightStyleEvents = 0x8B0
                m_LightStyleString = 0x888
                m_bPvsModifyEntity = 0xB14
                m_LightStyleTargets = 0x8C8
                m_flBrightnessScale = 0x864
                m_nBakedShadowIndex = 0x86C
                m_nLightMapUniqueId = 0x874
                m_flColorTemperature = 0x85C
                m_nLightPathUniqueId = 0x870
                m_flShadowFadeSizeEnd = 0x9F4
                m_bForceShadowsEnabled = 0x9B9
                m_flLightStyleStartTime = 0x890
                m_flLuminaireAnisotropy = 0x880
                m_flShadowFadeSizeStart = 0x9F0
                m_nPrecomputedSubFrusta = 0xA38
                m_vPrecomputedOBBAngles = 0xA20
                m_vPrecomputedOBBExtent = 0xA2C
                m_vPrecomputedOBBOrigin = 0xA14
                m_vPrecomputedBoundsMaxs = 0xA08
                m_vPrecomputedBoundsMins = 0x9FC
                m_vPrecomputedOBBAngles0 = 0xA48
                m_vPrecomputedOBBAngles1 = 0xA6C
                m_vPrecomputedOBBAngles2 = 0xA90
                m_vPrecomputedOBBAngles3 = 0xAB4
                m_vPrecomputedOBBAngles4 = 0xAD8
                m_vPrecomputedOBBAngles5 = 0xAFC
                m_vPrecomputedOBBExtent0 = 0xA54
                m_vPrecomputedOBBExtent1 = 0xA78
                m_vPrecomputedOBBExtent2 = 0xA9C
                m_vPrecomputedOBBExtent3 = 0xAC0
                m_vPrecomputedOBBExtent4 = 0xAE4
                m_vPrecomputedOBBExtent5 = 0xB08
                m_vPrecomputedOBBOrigin0 = 0xA3C
                m_vPrecomputedOBBOrigin1 = 0xA60
                m_vPrecomputedOBBOrigin2 = 0xA84
                m_vPrecomputedOBBOrigin3 = 0xAA8
                m_vPrecomputedOBBOrigin4 = 0xACC
                m_vPrecomputedOBBOrigin5 = 0xAF0
                m_QueuedLightStyleStrings = 0x898
                m_bPrecomputedFieldsValid = 0x9F8
                m_nBakeSpecularToCubemaps = 0x998
                m_fAlternateColorBrightness = 0x9D4
                m_vBakeSpecularToCubemapsSize = 0x99C
                m_flBakeSpecularToCubemapsScale = 0x9A8
            class CBaseIssue:
                m_iNumNoVotes = 0x168
                m_iNumYesVotes = 0x164
                m_szTypeString = 0x20
                m_pVoteController = 0x170
                m_szDetailsString = 0x60
                m_iNumPotentialVotes = 0x16C
            class CBreakable:
                m_OnBreak = 0x8E0
                m_Material = 0x898
                m_hBreaker = 0x89C
                m_Explosion = 0x8A0
                m_iszPropData = 0x8B8
                m_OnStartDeath = 0x8C8
                m_iMinHealthDmg = 0x8B4
                m_iszSpawnObject = 0x8A8
                m_OnHealthChanged = 0x8F8
                m_PerformanceMode = 0x918
                m_flPressureDelay = 0x8B0
                m_hPhysicsAttacker = 0x91C
                m_impactEnergyScale = 0x8C0
                m_nOverrideBlockLOS = 0x8C4
                m_CPropDataComponent = 0x858
                m_flLastPhysicsInfluenceTime = 0x920
            class CCashStack:
                m_nCashStackValue = 0x850
            class CEnvGlobal:
                m_counter = 0x4D8
                m_outCounter = 0x4A8
                m_globalstate = 0x4C8
                m_triggermode = 0x4D0
                m_initialstate = 0x4D4
            class CEnvSplash:
                m_flScale = 0x4A8
            class CFilterLOS:
                pass
            class CFlashbang:
                pass
            class CFogVolume:
                m_fogName = 0x850
                m_bDisabled = 0x870
                m_postProcessName = 0x858
                m_bInFogVolumesList = 0x871
                m_colorCorrectionName = 0x860
            class CFuncBrush:
                m_bSolidBsp = 0x858
                m_iDisabled = 0x854
                m_iSolidity = 0x850
                m_bInvertExclusion = 0x868
                m_iszExcludedClass = 0x860
                m_bScriptedMovement = 0x869
            class CFuncMover:
                m_flT = 0x884
                m_OnStop = 0xA68
                m_OnStart = 0xA20
                m_flSpeed = 0x9F8
                m_OnStopped = 0xA80
                m_bIsMoving = 0x891
                m_bIsPaused = 0x9D0
                m_eMoveType = 0x874
                m_bQueueStop = 0xB21
                m_eSolidType = 0x890
                m_hPathMover = 0x858
                m_bStartAtEnd = 0x939
                m_hStopAtNode = 0x8BC
                m_iszPathName = 0x850
                m_OnNodePassed = 0x958
                m_bIsReversing = 0x878
                m_flBeginStopT = 0x8C8
                m_flStartSpeed = 0x87C
                m_hFollowMover = 0xABC
                m_OnMovementEnd = 0x920
                m_hFollowEntity = 0x9FC
                m_OnStartForward = 0xA38
                m_OnStartReverse = 0xA50
                m_bIgnoreEndNode = 0x870
                m_bStartedMoving = 0xA99
                m_flPathLocation = 0x880
                m_hPrevPathMover = 0x85C
                m_iszPathNodeEnd = 0x868
                m_bIsImGuiLogging = 0x9F4
                m_movementSummary = 0xB00
                m_vOffsetFromPath = 0xB30
                m_bQueueStopMoving = 0xB22
                m_flCurFollowSpeed = 0xA0C
                m_flFollowDistance = 0xA00
                m_flStopCurveScale = 0x8AC
                m_iszPathNodeStart = 0x860
                m_nTickMovementRan = 0xAFC
                m_eFollowConstraint = 0xAF0
                m_flLerpToPositionT = 0x994
                m_flStartCurveScale = 0x8A8
                m_nCurrentNodeIndex = 0x888
                m_eOrientationUpdate = 0x944
                m_flCurFollowEntityT = 0xA08
                m_flFollowMoverRatio = 0xAD4
                m_flFollowMoverSpeed = 0xAF4
                m_flTimeMovementStop = 0x8B8
                m_nPreviousNodeIndex = 0x88C
                m_flPathLocationStart = 0x8C4
                m_flTimeMovementStart = 0x8B4
                m_flTransitionSourceT = 0x9A0
                m_iszFollowEntityName = 0xAC0
                m_iszLoopForwardSound = 0x8D8
                m_iszLoopReverseSound = 0x8F0
                m_iszStopForwardSound = 0x8E0
                m_iszStopReverseSound = 0x8F8
                m_bQueueSetupPathMover = 0xB23
                m_bStartAtClosestPoint = 0x938
                m_ePathRebuildStrategy = 0xB24
                m_flFollowMinimumSpeed = 0xA04
                m_iszStartForwardSound = 0x8D0
                m_iszStartReverseSound = 0x8E8
                m_vLerpToNewPosStartWS = 0x984
                m_bCreateMovableNavMesh = 0x954
                m_flFollowMoverDistance = 0xAD0
                m_flFollowMoverVelocity = 0xAF8
                m_flTimeToReachMaxSpeed = 0x894
                m_hTransitionSourcePath = 0x99C
                m_bIsImGuiEntTextLogging = 0x9F5
                m_eFollowEntityDirection = 0xAB8
                m_flLerpToPositionDeltaT = 0x998
                m_flTimeToReachZeroSpeed = 0x89C
                m_hOrientationFaceEntity = 0xA18
                m_nDelayedTeleportToNode = 0x9F0
                m_bNextNodeReturnsCurrent = 0xA98
                m_flLerpToPositionTargetT = 0x990
                m_hOrientationMatchEntity = 0x980
                m_OnLerpToPositionComplete = 0x9B8
                m_bStopFromBeginStopTarget = 0xB20
                m_bStoppedDuringTransition = 0x9B0
                m_eFindFollowMoverStrategy = 0xB28
                m_iszFollowMoverEntityName = 0xAC8
                m_flDistanceToReachMaxSpeed = 0x898
                m_flPathLocationToBeginStop = 0x8C0
                m_bCreateMovableSurfaceGraph = 0x955
                m_bDisableDecelerationToStop = 0xB2C
                m_flDistanceToReachZeroSpeed = 0x8B0
                m_vecFollowMoverCouplerRange = 0xAE4
                m_bStartFollowingClosestMover = 0x93A
                m_flFollowMoverSpringStrength = 0xADC
                m_iszArriveAtDestinationSound = 0x900
                m_flTimeStartOrientationChange = 0x948
                m_qTransitionSourceOrientation = 0x9E0
                m_strOrientationFaceEntityName = 0xA10
                m_bFollowConstraintsInitialized = 0xAEC
                m_eTransitionedToPathNodeAction = 0x9D4
                m_flTimeToBlendToNewOrientation = 0x94C
                m_iszOrientationMatchEntityName = 0x978
                m_flTransitionSourcePathLocation = 0x9A4
                m_nFollowMoverConstraintPriority = 0xAE0
                m_flFollowMoverCalculatedDistance = 0xAD8
                m_iszTransitionSourcePathNodeStart = 0x9A8
                m_flComputedDistanceToReachMaxSpeed = 0x8A0
                m_flComputedDistanceToReachZeroSpeed = 0x8A4
                m_flDurationBlendToNewOrientationRan = 0x950
                m_bAllowMovableNavMeshDockingOnEntireEntity = 0x956
                m_flStartFollowingClosestMoverWhenWithinDistance = 0x93C
                m_flStartFollowingClosestMoverWhenOutsideDistance = 0x940
            class CFuncTrain:
                m_hEnemy = 0x900
                m_flSpeed = 0x918
                m_activated = 0x8FC
                m_flBlockDamage = 0x904
                m_iszLastTarget = 0x910
                m_hCurrentTarget = 0x8F8
                m_flNextBlockTime = 0x908
            class CFuncWater:
                m_BuoyancyHelper = 0x850
            class CGameMoney:
                m_nMoney = 0x890
                m_OnMoneySpent = 0x860
                m_strAwardText = 0x898
                m_OnMoneySpentFail = 0x878
            class CGameRules:
                m_bGamePaused = 0xC8
                m_nQuestPhase = 0xB0
                m_szQuestName = 0x30
                __m_pChainEntity = 0x8
                m_nLastMatchTime = 0xB4
                m_nPauseStartTick = 0xC4
                m_nTotalPausedTicks = 0xC0
                m_nLastMatchTime_MatchID64 = 0xB8
            class CGunTarget:
                m_on = 0x8D4
                m_OnDeath = 0x8E0
                m_flSpeed = 0x8D0
                m_hTargetEnt = 0x8D8
            class CHEGrenade:
                pass
            class CLogicAuto:
                m_OnNewGame = 0x4D8
                m_OnLoadGame = 0x4F0
                m_OnMapSpawn = 0x4A8
                m_OnVREnabled = 0x568
                m_globalstate = 0x598
                m_OnMultiNewMap = 0x538
                m_OnDemoMapSpawn = 0x4C0
                m_OnVRNotEnabled = 0x580
                m_OnBackgroundMap = 0x520
                m_OnMapTransition = 0x508
                m_OnMultiNewRound = 0x550
            class CLogicCase:
                m_nCase = 0x4A8
                m_OnCase = 0x5D0
                m_OnDefault = 0x8D0
                m_nShuffleCases = 0x5A8
                m_nLastShuffleCase = 0x5AC
                m_uchShuffleCaseMap = 0x5B0
            class CMathRemap:
                m_flOut1 = 0x4B0
                m_flOut2 = 0x4B4
                m_flInMax = 0x4AC
                m_flInMin = 0x4A8
                m_OutValue = 0x4C0
                m_bEnabled = 0x4BC
                m_flOldInValue = 0x4B8
                m_OnFellBelowMax = 0x528
                m_OnFellBelowMin = 0x510
                m_OnRoseAboveMax = 0x4F8
                m_OnRoseAboveMin = 0x4E0
            class CNavVolume:
                pass
            class COmniLight:
                m_bShowLight = 0xB40
                m_flInnerAngle = 0xB38
                m_flOuterAngle = 0xB3C
            class CPathMover:
                m_vecMovers = 0x600
                m_vecSpawners = 0x618
                m_hMoverRouter = 0x638
                m_flSampleSpacing = 0x648
                m_iszMoverRouterName = 0x640
                m_iszMoverSpawnerName = 0x630
            class CPathTrack:
                m_pnext = 0x4A8
                m_OnPass = 0x4D0
                m_length = 0x4BC
                m_altName = 0x4C0
                m_flSpeed = 0x4B4
                m_flRadius = 0x4B8
                m_nIterVal = 0x4C8
                m_paltpath = 0x4B0
                m_pprevious = 0x4AC
                m_eOrientationType = 0x4CC
            class CPhysFixed:
                m_sBoneName1 = 0x520
                m_sBoneName2 = 0x528
                m_flLinearFrequency = 0x508
                m_flAngularFrequency = 0x510
                m_flLinearDampingRatio = 0x50C
                m_flAngularDampingRatio = 0x514
                m_bEnableLinearConstraint = 0x518
                m_bEnableAngularConstraint = 0x519
            class CPhysForce:
                m_force = 0x4B8
                m_forceTime = 0x4BC
                m_integrator = 0x4C8
                m_nameAttach = 0x4B0
                m_pController = 0x4A8
                m_wasRestored = 0x4C4
                m_attachedObject = 0x4C0
            class CPhysHinge:
                m_hinge = 0x5DC
                m_soundInfo = 0x510
                m_bAtMaxLimit = 0x5D9
                m_bAtMinLimit = 0x5D8
                m_OnStopMoving = 0x660
                m_bIsAxisLocal = 0x624
                m_flAngleSpeed = 0x63C
                m_OnStartMoving = 0x648
                m_flMaxRotation = 0x62C
                m_flMinRotation = 0x628
                m_hingeFriction = 0x61C
                m_systemLoadScale = 0x620
                m_flMotorFrequency = 0x634
                m_flInitialRotation = 0x630
                m_flMotorDampingRatio = 0x638
                m_NotifyMaxLimitReached = 0x5C0
                m_NotifyMinLimitReached = 0x5A8
                m_flAngleSpeedThreshold = 0x640
                m_flLimitsDebugVisRotation = 0x644
            class CPhysMotor:
                m_motor = 0x4F0
                m_spinUp = 0x4C0
                m_spinDown = 0x4C4
                m_nameAnchor = 0x4B0
                m_nameAttach = 0x4A8
                m_pMotorJoint = 0x4E8
                m_flTargetSpeed = 0x4D8
                m_flTorqueScale = 0x4D4
                m_hAnchorObject = 0x4BC
                m_flMotorFriction = 0x4C8
                m_hAttachedObject = 0x4B8
                m_pFixedWorldBody = 0x4E0
                m_angularAcceleration = 0x4D0
                m_additionalAcceleration = 0x4CC
                m_flSpeedWhenSpinUpOrSpinDownStarted = 0x4DC
            class CPlantedC4:
                m_flC4Blow = 0xA9C
                m_nBombSite = 0xAA0
                m_nSpotRules = 0xF50
                m_bBombDefused = 0xF55
                m_bBombTicking = 0xA98
                m_bHasExploded = 0xF54
                m_hBombDefuser = 0xF74
                m_OnBombDefused = 0xEE8
                m_bBeingDefused = 0xF5C
                m_flTimerLength = 0xF58
                m_flDefuseLength = 0xF6C
                m_fLastDefuseTime = 0xF64
                m_AttributeManager = 0xAB0
                m_bCannotBeDefused = 0xF30
                m_bVoiceAlertFired = 0xF7C
                m_iProgressBarTime = 0xF78
                m_OnBombBeginDefuse = 0xF00
                m_bVoiceAlertPlayed = 0xF7D
                m_flDefuseCountDown = 0xF70
                m_flNextBotBeepTime = 0xF84
                m_entitySpottedState = 0xF38
                m_OnBombDefuseAborted = 0xF18
                m_angCatchUpToPlayerEye = 0xF8C
                m_nSourceSoundscapeHash = 0xAA4
                m_bTrainingPlacedByPlayer = 0xF56
                m_flLastSpinDetectionTime = 0xF98
                m_bAbortDetonationBecauseWorldIsFrozen = 0xAA8
            class CPointHurt:
                m_flDelay = 0x4B4
                m_nDamage = 0x4A8
                m_flRadius = 0x4B0
                m_strTarget = 0x4B8
                m_pActivator = 0x4C0
                m_bitsDamageType = 0x4AC
            class CPointPush:
                m_hFilter = 0x4C8
                m_bEnabled = 0x4A8
                m_flRadius = 0x4B0
                m_flMagnitude = 0x4AC
                m_flInnerRadius = 0x4B4
                m_iszFilterName = 0x4C0
                m_flConeOfInfluence = 0x4B8
            class CRectLight:
                m_bShowLight = 0xB38
            class CRotButton:
                pass
            class CSkyCamera:
                m_pNext = 0x540
                m_bUseAngles = 0x53C
                m_skyboxData = 0x4A8
                m_skyboxSlotToken = 0x538
            class CStopwatch:
                m_flInterval = 0xC
            class CWeaponAWP:
                pass
            class CWeaponAug:
                pass
            class CWeaponMP7:
                pass
            class CWeaponMP9:
                pass
            class CWeaponP90:
                pass
            class SpawnPoint:
                m_nType = 0x4B0
                m_bEnabled = 0x4AC
                m_iPriority = 0x4A8
            class lerpdata_t:
                m_hEnt = 0x0
                m_MoveType = 0x4
                m_nFXIndex = 0x30
                m_qStartRot = 0x20
                m_flStartTime = 0x8
                m_vecStartOrigin = 0xC
            class AmmoIndex_t:
                m_Value = 0x0
            class CBaseButton:
                m_ls = 0x8E0
                m_OnIn = 0x978
                m_OnOut = 0x990
                m_nState = 0x9A8
                m_usable = 0x9C4
                m_bLocked = 0x920
                m_flSpeed = 0x924
                m_OnDamaged = 0x930
                m_OnPressed = 0x948
                m_bDisabled = 0x921
                m_bSolidBsp = 0x92C
                m_fRotating = 0x8DD
                m_sUseSound = 0x900
                m_glowEntity = 0x9C0
                m_OnUseLocked = 0x960
                m_fStayPushed = 0x8DC
                m_hConstraint = 0x9AC
                m_sGlowEntity = 0x9B8
                m_sLockedSound = 0x908
                m_szDisplayText = 0x9C8
                m_sUnlockedSound = 0x910
                m_flUseLockedTime = 0x928
                m_bForceNpcExclude = 0x9B4
                m_hConstraintParent = 0x9B0
                m_angMoveEntitySpace = 0x8D0
                m_sOverrideAnticipationName = 0x918
            class CBaseEntity:
                m_think = 0x288
                m_fFlags = 0x388
                m_pfnUse = 0x2B8
                m_target = 0x300
                m_OnUser1 = 0x418
                m_OnUser2 = 0x430
                m_OnUser3 = 0x448
                m_OnUser4 = 0x460
                m_iEFlags = 0x414
                m_iHealth = 0x2D0
                m_MoveType = 0x2F3
                m_OnKilled = 0x370
                m_fEffects = 0x3E8
                m_iTeamNum = 0x344
                m_pBlocker = 0x490
                m_pfnTouch = 0x2B0
                m_lifeState = 0x2D8
                m_flAnimTime = 0x328
                m_flFriction = 0x3F4
                m_iMaxHealth = 0x2D4
                m_nBloodType = 0x49C
                m_nWaterType = 0x412
                m_pCollision = 0x3D8
                m_pfnBlocked = 0x2C0
                m_spawnflags = 0x360
                m_MoveCollide = 0x2F2
                m_flLocalTime = 0x494
                m_flTimeScale = 0x400
                m_iGlobalname = 0x348
                m_nSlimeTouch = 0x2F7
                m_nSubclassID = 0x31C
                m_nWaterTouch = 0x2F6
                m_pfnMoveDone = 0x2C8
                m_vecVelocity = 0x398
                m_bTakesDamage = 0x2E0
                m_flCreateTime = 0x330
                m_flElasticity = 0x3F8
                m_flWaterLevel = 0x404
                m_hOwnerEntity = 0x3E4
                m_hDamageFilter = 0x308
                m_hEffectEntity = 0x3E0
                m_hGroundEntity = 0x3EC
                m_isSteadyState = 0x278
                m_nPlatformType = 0x2F0
                m_CBodyComponent = 0x30
                m_bLagCompensate = 0x48D
                m_flGravityScale = 0x3FC
                m_flMoveDoneTime = 0x318
                m_iSentToClients = 0x350
                m_nLastThinkTick = 0x264
                m_nNextThinkTick = 0x364
                m_nPushEnumCount = 0x3D4
                m_vecAbsVelocity = 0x38C
                m_vecAngVelocity = 0x480
                m_aThinkFunctions = 0x248
                m_iInitialTeamNum = 0x478
                m_nActualMoveType = 0x2F5
                m_nSimulationTick = 0x368
                m_sUniqueHammerID = 0x358
                m_vecBaseVelocity = 0x3C8
                m_ResponseContexts = 0x290
                m_bGravityDisabled = 0x408
                m_flSimulationTime = 0x32C
                m_nGroundBodyIndex = 0x3F0
                m_nTakeDamageFlags = 0x2E8
                m_lastNetworkChange = 0x280
                m_bAnimatedEveryTick = 0x409
                m_bClientSideRagdoll = 0x334
                m_iszResponseContext = 0x2A8
                m_bDisableLowViolence = 0x411
                m_bRestoreInHierarchy = 0x2F8
                m_flDamageAccumulator = 0x2DC
                m_iszDamageFilterName = 0x310
                m_pPulseGraphInstance = 0x4A0
                m_flActualGravityScale = 0x40C
                m_flNavIgnoreUntilTime = 0x47C
                m_iCurrentThinkContext = 0x260
                m_ubInterpolationFrame = 0x335
                m_bDisabledContextThinks = 0x268
                m_nPreviouslySetMoveType = 0x2F4
                m_vPrevVPhysicsUpdatePos = 0x338
                m_NetworkTransmitComponent = 0x38
                m_bGravityActuallyDisabled = 0x410
                m_flVPhysicsUpdateLocalTime = 0x498
                m_bNetworkQuantizeOriginAndAngles = 0x48C
            class CBaseFilter:
                m_OnFail = 0x4C8
                m_OnPass = 0x4B0
                m_bNegated = 0x4A8
            class CBaseToggle:
                m_flLip = 0x85C
                m_flWait = 0x858
                m_sMaster = 0x8C8
                m_flHeight = 0x8A0
                m_vecAngle1 = 0x888
                m_vecAngle2 = 0x894
                m_hActivator = 0x8A4
                m_vecMoveAng = 0x87C
                m_movementType = 0x8C0
                m_toggle_state = 0x850
                m_vecFinalDest = 0x8A8
                m_vecPosition1 = 0x864
                m_vecPosition2 = 0x870
                m_vecFinalAngle = 0x8B4
                m_flMoveDistance = 0x854
                m_bAlwaysFireBlockedOutputs = 0x860
            class CBombTarget:
                m_bIsBombSiteB = 0xA10
                m_OnBombDefused = 0x9F8
                m_OnBombExplode = 0x9C8
                m_OnBombPlanted = 0x9E0
                m_szMountTarget = 0xA18
                m_hInstructorHint = 0xA20
                m_bBombPlantedHere = 0xA12
                m_bIsHeistBombTarget = 0xA11
                m_nBombSiteDesignation = 0xA24
            class CEconEntity:
                m_hOldProvidee = 0xEA8
                m_nFallbackSeed = 0xE9C
                m_flFallbackWear = 0xEA0
                m_iOldOwnerClass = 0xEAC
                m_AttributeManager = 0xA58
                m_nFallbackPaintKit = 0xE98
                m_nFallbackStatTrak = 0xEA4
                m_OriginalOwnerXuidLow = 0xE90
                m_OriginalOwnerXuidHigh = 0xE94
            class CEffectData:
                m_fFlags = 0x63
                m_nColor = 0x62
                m_vStart = 0x14
                m_flScale = 0x40
                m_hEntity = 0x38
                m_nHitBox = 0x60
                m_vAngles = 0x2C
                m_vNormal = 0x20
                m_vOrigin = 0x8
                m_flRadius = 0x48
                m_nMaterial = 0x5E
                m_nPenetrate = 0x5C
                m_flMagnitude = 0x44
                m_iEffectName = 0x6C
                m_nDamageType = 0x58
                m_hOtherEntity = 0x3C
                m_nEffectIndex = 0x50
                m_nSurfaceProp = 0x4C
                m_nAttachmentName = 0x68
                m_nAttachmentIndex = 0x64
            class CEnvCubemap:
                m_Entity_bEnabled = 0x588
                m_Entity_bMoveable = 0x550
                m_Entity_nPriority = 0x55C
                m_Entity_nHandshake = 0x554
                m_Entity_bDefaultEnvMap = 0x575
                m_Entity_bIndoorCubeMap = 0x577
                m_Entity_bStartDisabled = 0x574
                m_Entity_flDiffuseScale = 0x570
                m_Entity_flEdgeFadeDist = 0x560
                m_Entity_vEdgeFadeDists = 0x564
                m_Entity_hCubemapTexture = 0x528
                m_Entity_vBoxProjectMaxs = 0x544
                m_Entity_vBoxProjectMins = 0x538
                m_Entity_flInfluenceRadius = 0x534
                m_Entity_bDefaultSpecEnvMap = 0x576
                m_Entity_bCustomCubemapTexture = 0x530
                m_Entity_nEnvCubeMapArrayIndex = 0x558
                m_Entity_bCopyDiffuseFromDefaultCubemap = 0x578
            class CEnvHudHint:
                m_iszMessage = 0x4A8
            class CFilterName:
                m_iFilterName = 0x4E0
            class CFilterTeam:
                m_iFilterTeam = 0x4E0
            class CFogTrigger:
                m_fog = 0x9C8
            class CFuncLadder:
                m_Dismounts = 0x860
                m_bDisabled = 0x8A0
                m_bHasSlack = 0x8A2
                m_bFakeLadder = 0x8A1
                m_vecLocalTop = 0x878
                m_vecLadderDir = 0x850
                m_flAutoRideSpeed = 0x89C
                m_surfacePropName = 0x8A8
                m_OnPlayerGotOnLadder = 0x8B0
                m_OnPlayerGotOffLadder = 0x8C8
                m_vecPlayerMountPositionTop = 0x884
                m_vecPlayerMountPositionBottom = 0x890
            class CHandleTest:
                m_Handle = 0x4A8
                m_bSendHandle = 0x4AC
            class CInfoTarget:
                pass
            class CItemKevlar:
                pass
            class CLogicRelay:
                m_OnSpawn = 0x4A8
                m_OnTrigger = 0x4C0
                m_bDisabled = 0x4D8
                m_bTriggerOnce = 0x4DA
                m_bFastRetrigger = 0x4DB
                m_bWaitForRefire = 0x4D9
                m_bPassthoughCaller = 0x4DC
            class CModelState:
                m_hModel = 0xA0
                m_ModelName = 0xA8
                m_nForceLOD = 0x283
                m_MeshGroupMask = 0x1E8
                m_nIdealMotionType = 0x282
                m_nBodyGroupChoices = 0x238
                m_nClothUpdateFlags = 0x284
                m_flRootBoneOffset_x = 0xE8
                m_flRootBoneOffset_y = 0xEC
                m_flRootBoneOffset_z = 0xF0
                m_pVPhysicsAggregate = 0xE0
                m_bClientClothCreationSuppressed = 0xF5
                m_nAnimStateNoInterpSerialNumber = 0x1E0
                m_nRootBoneOffsetResetSerialNumber = 0xF4
            class CNullEntity:
                pass
            class CPathCorner:
                m_OnPass = 0x4C8
                m_flWait = 0x4AC
                m_flSpeed = 0x4C0
                m_flRadius = 0x4B0
                m_bSmoothArrival = 0x4A9
                m_bExactPositioning = 0x4AA
                m_bTriggerLocomotionStop = 0x4A8
                m_flWaypointSuccessRadius = 0x4B8
                m_flPathEndDistanceFromGoal = 0x4BC
                m_flWaypointSuccessRadiusWhenBlocked = 0x4B4
            class CPathSimple:
                m_pathString = 0x5A0
                m_bClosedLoop = 0x5A8
                m_CPathQueryComponent = 0x4B0
            class CPhysImpact:
                m_damage = 0x4A8
                m_distance = 0x4AC
                m_directionEntityName = 0x4B0
            class CPhysLength:
                m_offset = 0x508
                m_addLength = 0x52C
                m_minLength = 0x530
                m_vecAttach = 0x520
                m_totalLength = 0x534
            class CPhysMagnet:
                m_bActive = 0xA98
                m_flRadius = 0xAA0
                m_massScale = 0xA70
                m_forceLimit = 0xA74
                m_flTotalMass = 0xA9C
                m_torqueLimit = 0xA78
                m_OnMagnetAttach = 0xA40
                m_OnMagnetDetach = 0xA58
                m_flNextSuckTime = 0xAA4
                m_bHasHitSomething = 0xA99
                m_MagnettedEntities = 0xA80
                m_iMaxObjectsAttached = 0xAA8
            class CPhysPulley:
                m_offset = 0x514
                m_addLength = 0x52C
                m_gearRatio = 0x530
                m_position2 = 0x508
            class CPhysTorque:
                m_axis = 0x508
            class CPlayerPing:
                m_iType = 0x4B8
                m_bUrgent = 0x4BC
                m_hPlayer = 0x4B0
                m_szPlaceName = 0x4BD
                m_hPingedEntity = 0x4B4
            class CPointPulse:
                pass
            class CRangeFloat:
                m_pValue = 0x0
            class CRemapFloat:
                m_pValue = 0x0
            class CRuleEntity:
                m_iszMaster = 0x850
            class CScriptItem:
                m_MoveTypeOverride = 0xAE0
            class CSkillFloat:
                m_pValue = 0x0
            class CSmoothFunc:
                m_nSmoothDir = 0x18
                m_flSmoothBias = 0xC
                m_flSmoothDuration = 0x10
                m_flSmoothAmplitude = 0x8
                m_flSmoothRemainingTime = 0x14
            class CSoundPatch:
                m_hEnt = 0x50
                m_pitch = 0x8
                m_Filter = 0x68
                m_volume = 0x18
                m_isPlaying = 0x64
                m_flLastTime = 0x40
                m_soundOrigin = 0x58
                m_iszClassName = 0xA8
                m_shutdownTime = 0x3C
                m_soundEntityIndex = 0x54
                m_iszSoundScriptName = 0x48
                m_bUpdatedSoundOrigin = 0xA4
                m_flCloseCaptionDuration = 0xA0
            class CTestEffect:
                m_iBeam = 0x4AC
                m_iLoop = 0x4A8
                m_pBeam = 0x4B0
                m_flBeamTime = 0x510
                m_flStartTime = 0x570
            class CTriggerFan:
                m_flForce = 0xA04
                m_bFalloff = 0xA08
                m_hInfoFan = 0xA00
                m_RampTimer = 0xA10
                m_bRampDown = 0xA81
                m_vFanEndLS = 0xA40
                m_flNPCForce = 0xA70
                m_flRampTime = 0xA74
                m_iszInfoFan = 0xA58
                m_vDirection = 0x9D4
                m_bPushPlayer = 0xA80
                m_fNoiseSpeed = 0xA7C
                m_qNoiseDelta = 0x9F0
                m_vFanOriginLS = 0xA34
                m_vFanOriginWS = 0xA28
                m_fNoiseDegrees = 0xA78
                m_flPlayerForce = 0xA68
                m_nManagerFanIdx = 0xA84
                m_bPlayerWindblock = 0xA6C
                m_flRopeForceScale = 0xA60
                m_vFanOriginOffset = 0x9C8
                m_flParticleForceScale = 0xA64
                m_vNoiseDirectionTarget = 0xA4C
                m_bPushTowardsInfoTarget = 0x9E0
                m_bPushAwayFromInfoTarget = 0x9E1
            class CWeaponM249:
                pass
            class CWeaponM4A1:
                pass
            class CWeaponMag7:
                pass
            class CWeaponNOVA:
                pass
            class CWeaponP250:
                pass
            class CWeaponTec9:
                pass
            class GAME_HEADER:
                m_sComment = 0x0
                m_sLandmark = 0x10
                m_sRequiredAddons = 0x18
                m_nSpawnGroupCount = 0x8
            class HullFlags_t:
                m_bHull_Tiny = 0x3
                m_bHull_Human = 0x0
                m_bHull_Large = 0x6
                m_bHull_Small = 0x9
                m_bHull_Medium = 0x4
                m_bHull_WideHuman = 0x2
                m_bHull_MediumTall = 0x8
                m_bHull_TinyCentered = 0x5
                m_bHull_LargeCentered = 0x7
                m_bHull_SmallCentered = 0x1
            class SAVE_HEADER:
                m_saveId = 0x0
                m_version = 0x4
                m_flSaveTime = 0x50
                m_nMapVersion = 0xC
                m_vecWorldOffset = 0x20
                m_sSpawnGroupName = 0x10
                m_nConnectionCount = 0x8
            class fogparams_t:
                end = 0x28
                farz = 0x2C
                blend = 0x65
                start = 0x24
                enable = 0x64
                duration = 0x54
                exponent = 0x34
                lerptime = 0x50
                endLerpTo = 0x48
                dirPrimary = 0x8
                m_bPadding = 0x67
                maxdensity = 0x30
                scattering = 0x5C
                m_bPadding2 = 0x66
                startLerpTo = 0x44
                colorPrimary = 0x14
                HDRColorScale = 0x38
                colorSecondary = 0x18
                locallightscale = 0x60
                skyboxFogFactor = 0x3C
                maxdensityLerpTo = 0x4C
                blendtobackground = 0x58
                colorPrimaryLerpTo = 0x1C
                colorSecondaryLerpTo = 0x20
                skyboxFogFactorLerpTo = 0x40
            class levellist_t:
                m_sMapName = 0x0
                m_hEntLandmark = 0x10
                m_sLandmarkName = 0x8
                m_vecLandmarkAngles = 0x20
                m_vecLandmarkOrigin = 0x14
            class locksound_t:
                flwaitSound = 0x18
                sLockedSound = 0x8
                sUnlockedSound = 0x10
            class thinkfunc_t:
                m_hFn = 0x8
                m_think = 0x0
                m_nContext = 0x10
                m_nLastThinkTick = 0x18
                m_nNextThinkTick = 0x14
            class CBaseDMStart:
                m_Master = 0x4A8
            class CBaseGrenade:
                m_bIsLive = 0xA82
                m_flDamage = 0xA90
                m_hThrower = 0xAA8
                m_DmgRadius = 0xA84
                m_OnExplode = 0xA68
                m_bHasWarnedAI = 0xA80
                m_flNextAttack = 0xAC0
                m_flWarnAITime = 0xA8C
                m_ExplosionSound = 0xAA0
                m_OnPlayerPickup = 0xA50
                m_flDetonateTime = 0xA88
                m_iszBounceSound = 0xA98
                m_bIsSmokeGrenade = 0xA81
                m_hOriginalThrower = 0xAC4
                m_bDamageDetonating = 0xA48
            class CBaseTrigger:
                m_hFilter = 0x9B0
                m_bDisabled = 0x9B4
                m_OnEndTouch = 0x900
                m_OnTouching = 0x930
                m_iFilterName = 0x9A8
                m_OnStartTouch = 0x8D0
                m_OnEndTouchAll = 0x918
                m_OnNotTouching = 0x960
                m_OnStartTouchAll = 0x8E8
                m_bUseAsyncQueries = 0x9C0
                m_OnTouchingChanged = 0x978
                m_hTouchingEntities = 0x990
                m_OnTouchingEachEntity = 0x948
            class CBtActionAim:
                m_AimTimer = 0xA8
                m_bAcquired = 0xF0
                m_bDoneAiming = 0x8C
                m_szAimReadyKey = 0x80
                m_NextLookTarget = 0x9C
                m_SniperHoldTimer = 0xC0
                m_flLerpStartTime = 0x90
                m_szSensorInputKey = 0x68
                m_FocusIntervalTimer = 0xD8
                m_flPenaltyReductionRatio = 0x98
                m_flZoomCooldownTimestamp = 0x88
                m_flNextLookTargetLerpTime = 0x94
            class CCSGameRules:
                m_iNumCT = 0xD90
                m_bLogoMap = 0x13D
                m_bTCantBuy = 0xA4C
                m_gamePhase = 0x11C
                m_bCTCantBuy = 0xA4D
                m_bIsValveDS = 0x13C
                m_iAccountCT = 0xE80
                m_iMaxNumCTs = 0xE90
                m_iRoundTime = 0x100
                m_MatchDevice = 0x144
                m_RetakeRules = 0x1140
                m_bVoteCalled = 0xEF0
                m_iFreezeTime = 0xFC
                m_nCTTimeOuts = 0xF4
                m_bBombDefused = 0xF01
                m_bBombDropped = 0xA40
                m_bBombPlanted = 0x95F
                m_bGameRestart = 0x110
                m_bNoCTsKilled = 0xEB5
                m_vMinimapMaxs = 0xCC4
                m_vMinimapMins = 0xCB8
                m_CTSpawnPoints = 0xFA8
                m_bBuyTimeEnded = 0xEF8
                m_bFreezePeriod = 0xD8
                m_bIsHltvActive = 0x95E
                m_bTargetBombed = 0xF00
                m_bWarmupPeriod = 0xD9
                m_firstKillTime = 0xEBC
                m_iNumTerrorist = 0xD8C
                m_numBestOfMaps = 0xA38
                m_bCompleteReset = 0xDBD
                m_bMapHasBuyZone = 0x133
                m_fAvgPlayerRank = 0xDEC
                m_firstBloodTime = 0xEC4
                m_nMatchEndCount = 0x13B8
                m_nRoundEndCount = 0x140C
                m_pGameModeRules = 0x1098
                m_szMatchStatTxt = 0x550
                m_bFirstConnected = 0xDBC
                m_bMapHasBombZone = 0xF02
                m_eRoundEndReason = 0x13D4
                m_eRoundWinReason = 0xA48
                m_endMatchOnThink = 0xD89
                m_fMatchStartTime = 0x104
                m_fRoundStartTime = 0x108
                m_flGameStartTime = 0x114
                m_flLastThinkTime = 0x1024
                m_hPlayerResource = 0x1138
                m_iNumSpawnableCT = 0xD98
                m_iRoundEndLegacy = 0x1408
                m_iRoundWinStatus = 0xA44
                m_ullLocalMatchID = 0xCF0
                m_bCTTimeOutActive = 0xE5
                m_bHasMatchStarted = 0x148
                m_bIsDroppingItems = 0x95C
                m_bIsQuestEligible = 0x95D
                m_bNoEnemiesKilled = 0xEB6
                m_bRoundEndNoMusic = 0x1404
                m_bTeamIntroPeriod = 0x13C4
                m_fWarmupPeriodEnd = 0xDC
                m_hostageWasKilled = 0xEE1
                m_iHostagesRescued = 0xEA8
                m_iHostagesTouched = 0xEAC
                m_nOvertimePlaying = 0x128
                m_nRoundStartCount = 0x1414
                m_sRoundEndMessage = 0x13F8
                m_bCanDonateWeapons = 0xEB7
                m_bLevelInitialized = 0xD7C
                m_bMapHasBombTarget = 0x131
                m_bMapHasRescueZone = 0x132
                m_bTechnicalTimeOut = 0xF8
                m_flNextRespawnWave = 0xC38
                m_hostageWasInjured = 0xEE0
                m_iAccountTerrorist = 0xE7C
                m_iMaxNumTerrorists = 0xE8C
                m_iNextCTSpawnPoint = 0xF94
                m_iUnBalancedRounds = 0xD84
                m_totalRoundsPlayed = 0x120
                m_vecMainCTSpawnPos = 0xF50
                mTeamDMLastThinkTime = 0xE74
                m_BtGlobalBlackboard = 0x10A0
                m_bAllowWeaponSwitch = 0x1018
                m_bAnyHostageReached = 0x130
                m_bPlayedTeamIntroVO = 0x13CC
                m_bServerVoteOnReset = 0xEF1
                m_fWarmupPeriodStart = 0xE0
                m_flRestartRoundTime = 0x10C
                m_iHostagesRemaining = 0x12C
                m_iRoundEndTimerTime = 0x13DC
                m_iTotalRoundsPlayed = 0xD80
                m_nEndMatchTiedVotes = 0xDC8
                m_nLastFreezeEndBeep = 0xEFC
                m_nMatchInfoShowType = 0xE50
                m_nNextMapInMapgroup = 0x14C
                m_nTTeamIntroVariant = 0x13BC
                m_nTerroristTimeOuts = 0xF0
                m_bNoTerroristsKilled = 0xEB4
                m_bSwapTeamsOnRestart = 0xDC0
                m_fTeamIntroPeriodEnd = 0x13C8
                m_flVoteCheckThrottle = 0xEF4
                m_iRoundEndWinnerTeam = 0x13D0
                m_iSpawnPointCount_CT = 0xE88
                m_iSpectatorSlotCount = 0x140
                m_nCTTeamIntroVariant = 0x13C0
                m_tmNextPeriodicThink = 0xE98
                m_TeamRespawnWaveTimes = 0xBB8
                m_TerroristSpawnPoints = 0xFC0
                m_bIsQueuedMatchmaking = 0x134
                m_bPickNewTeamsOnReset = 0xDBE
                m_endMatchOnRoundReset = 0xD88
                m_flCTTimeOutRemaining = 0xEC
                m_flLastPerfSampleTime = 0x5420
                m_iRoundEndPlayerCount = 0x1400
                m_flIntermissionEndTime = 0xD78
                m_iRoundEndFunFactData1 = 0x13EC
                m_iRoundEndFunFactData2 = 0x13F0
                m_iRoundEndFunFactData3 = 0x13F4
                m_numSpectatorsCountMax = 0xDFC
                m_sRoundEndFunFactToken = 0x13E0
                m_szTournamentEventName = 0x150
                m_bForceTeamChangeSilent = 0xE18
                m_bHasHostageBeenTouched = 0xD70
                m_bMatchWaitingForResume = 0xF9
                m_flCTSpawnPointUsedTime = 0xF98
                m_flMatchInfoDecidedTime = 0xE54
                m_iNumConsecutiveCTLoses = 0xD4C
                m_iNumSpawnableTerrorist = 0xD94
                m_iRoundStartRoundNumber = 0x1410
                m_nEndMatchMapVoteWinner = 0xD48
                m_nHalloweenMaskListSeed = 0xA3C
                m_nQueuedMatchmakingMode = 0x138
                m_nRoundsPlayedThisPhase = 0x124
                m_nSpawnPointsRandomSeed = 0xDB8
                m_szTournamentEventStage = 0x350
                m_CTSpawnPointsMasterList = 0xF60
                m_bIsUnreservedGameServer = 0xFD8
                m_bLoadingRoundBackupData = 0xE19
                m_bScrambleTeamsOnRestart = 0xDBF
                m_bTerroristTimeOutActive = 0xE4
                m_bVoiceWonMatchBragFired = 0xE9C
                m_fAutobalanceDisplayTime = 0xFDC
                m_flIntermissionStartTime = 0xD74
                m_numSpectatorsCountMaxTV = 0xE00
                m_numTotalTournamentDrops = 0xDF8
                m_arrProhibitedItemIndices = 0x960
                m_bRoundEndShowTimerDefend = 0x13D8
                m_iMatchStats_RoundResults = 0xA50
                m_iNextTerroristSpawnPoint = 0xF9C
                m_nCTsAliveAtFreezetimeEnd = 0xE10
                m_nMatchAbortedEarlyReason = 0x1078
                m_numSpectatorsCountMaxLnk = 0xE04
                m_timeUntilNextPhaseStarts = 0x118
                m_fWarmupNextChatNoticeTime = 0xEA0
                m_flNextHostageAnnouncement = 0xEB0
                m_iLoserBonusMostRecentTeam = 0xE94
                m_nTournamentPredictionsPct = 0x950
                mTeamDMLastWinningTeamNumber = 0xE70
                m_bPlayAllStepSoundsOnServer = 0x13E
                m_bRoundTimeWarningTriggered = 0x1019
                m_fAccumulatedRoundOffDamage = 0x1028
                m_flCMMItemDropRevealEndTime = 0x958
                m_iMatchStats_PlayersAlive_T = 0xB40
                m_iRoundEndFunFactPlayerSlot = 0x13E8
                m_iSpawnPointCount_Terrorist = 0xE84
                m_nEndMatchMapGroupVoteTypes = 0xCF8
                m_szTournamentPredictionsTxt = 0x750
                m_bSwitchingTeamsAtRoundReset = 0x107D
                m_flTerroristTimeOutRemaining = 0xE8
                m_iMatchStats_PlayersAlive_CT = 0xAC8
                m_phaseChangeAnnouncementTime = 0x101C
                m_bHasTriggeredRoundStartMusic = 0x107C
                m_fNextUpdateTeamClanNamesTime = 0x1020
                m_flCMMItemDropRevealStartTime = 0x954
                m_flTeamDMLastAnnouncementTime = 0xE78
                m_nEndMatchMapGroupVoteOptions = 0xD20
                m_numQueuedMatchmakingAccounts = 0xDE8
                m_MinimapVerticalSectionHeights = 0xCD0
                m_arrTeamUniqueKillWeaponsMatch = 0x1330
                m_flTerroristSpawnPointUsedTime = 0xFA0
                m_iNumConsecutiveTerroristLoses = 0xD50
                m_TerroristSpawnPointsMasterList = 0xF78
                m_arrSelectedHostageSpawnIndices = 0xDA0
                m_nShorthandedBonusLastEvalRound = 0x102C
                m_nTerroristsAliveAtFreezetimeEnd = 0xE14
                m_bNeedToAskPlayersForContinueVote = 0xDE4
                m_bRespawningAllRespawnablePlayers = 0xF90
                m_arrTournamentActiveCasterAccounts = 0xA28
                m_bTeamLastKillUsedUniqueWeaponMatch = 0x1390
                m_pQueuedMatchmakingReservationString = 0xDF0
            class CChangeLevel:
                m_bNoTouch = 0x9F1
                m_bTouched = 0x9F0
                m_sMapName = 0x9C8
                m_bNewChapter = 0x9F2
                m_OnChangeLevel = 0x9D8
                m_sLandmarkName = 0x9D0
                m_bOnChangeLevelFired = 0x9F3
            class CDynamicProp:
                m_glowColor = 0xC80
                m_nGlowTeam = 0xC84
                m_nGlowRange = 0xC78
                m_iszIdleAnim = 0xC60
                m_bUseAnimGraph = 0xBE3
                m_nGlowRangeMin = 0xC7C
                m_bStartDisabled = 0xC6D
                m_bCreateNonSolid = 0xC71
                m_bIsOverrideProp = 0xC72
                m_bRandomizeCycle = 0xC6C
                m_pOutputAnimOver = 0xC00
                m_OnAnimReachedEnd = 0xC48
                m_bForceNpcExclude = 0xC6F
                m_pOutputAnimBegun = 0xBE8
                m_iInitialGlowState = 0xC74
                m_nIdleAnimLoopMode = 0xC68
                m_OnAnimReachedStart = 0xC30
                m_bCreateNavObstacle = 0xBE0
                m_bFiredStartEndOutput = 0xC6E
                m_bGraphControllerEnabled = 0xBD0
                m_bUseHitboxesForRenderBox = 0xBE2
                m_pOutputAnimLoopCycleOver = 0xC18
                m_bCreateMovableSurfaceGraph = 0xC70
                m_bNavObstacleUpdatesOverridden = 0xBE1
            class CEntityFlame:
                m_flSize = 0x4B0
                m_hAttacker = 0x4C4
                m_flLifetime = 0x4C0
                m_bCheapEffect = 0x4AC
                m_bUseHitboxes = 0x4B4
                m_hEntAttached = 0x4A8
                m_iNumHitboxFires = 0x4B8
                m_flHitboxFireScale = 0x4BC
                m_iCustomDamageType = 0x4CC
                m_flDirectDamagePerSecond = 0x4C8
            class CEnvBeverage:
                m_nBeverageType = 0x4AC
                m_CanInDispenser = 0x4A8
            class CFilterClass:
                m_iFilterClass = 0x4E0
            class CFilterEnemy:
                m_flRadius = 0x4E8
                m_iszEnemyName = 0x4E0
                m_flOuterRadius = 0x4EC
                m_iszPlayerName = 0x4F8
                m_nMaxSquadmatesPerEnemy = 0x4F0
            class CFilterModel:
                m_iFilterModel = 0x4E0
            class CFuncMonitor:
                m_bEnabled = 0x88C
                m_targetCamera = 0x870
                m_bDraw3DSkybox = 0x88D
                m_bStartEnabled = 0x88E
                m_hTargetCamera = 0x888
                m_bRenderShadows = 0x87C
                m_brushModelName = 0x880
                m_nResolutionEnum = 0x878
                m_bUseUniqueColorTarget = 0x87D
            class CFuncPlatRot:
                m_end = 0x908
                m_start = 0x914
            class CFuncRotator:
                m_flSpeed = 0x858
                m_bQueueStop = 0x9A0
                m_eSolidType = 0x855
                m_OnOscillate = 0x8A0
                m_bIsRotating = 0x854
                m_eRotateType = 0x850
                m_flStartSpeed = 0x938
                m_iszLoopSound = 0x968
                m_iszStopSound = 0x988
                m_eRotationAxis = 0x998
                m_flTargetAngle = 0x990
                m_iszStartSound = 0x960
                m_flCurrentAngle = 0x994
                m_hRotatorTarget = 0x864
                m_nTickRotateRan = 0x918
                m_rotationSummary = 0x920
                m_bStartedRotating = 0x91C
                m_flMaxYawRotation = 0x958
                m_flMinYawRotation = 0x954
                m_strRotatorTarget = 0x868
                m_OnRotationStarted = 0x870
                m_qSpawnOrientation = 0x940
                m_flTimeRotationStop = 0x934
                m_OnRotationCompleted = 0x888
                m_flTimeRotationStart = 0x930
                m_OnOscillateEndArrive = 0x8E8
                m_OnOscillateEndDepart = 0x900
                m_bOscillationFromStart = 0x95C
                m_flTimeToReachMaxSpeed = 0x928
                m_OnOscillateStartArrive = 0x8B8
                m_OnOscillateStartDepart = 0x8D0
                m_flTimeToReachZeroSpeed = 0x92C
                m_flTimeToCompleteRotation = 0x860
                m_flRotationDistanceDegrees = 0x85C
                m_flSpeedDriftFromOverRotate = 0x99C
                m_bReturningToInitialRotation = 0x950
            class CGradientFog:
                m_flFarZ = 0x4C4
                m_fogColor = 0x4D4
                m_bIsEnabled = 0x4E1
                m_flFadeTime = 0x4DC
                m_flFogStrength = 0x4D8
                m_bStartDisabled = 0x4E0
                m_flFogEndHeight = 0x4C0
                m_flFogMaxOpacity = 0x4C8
                m_flFogEndDistance = 0x4B4
                m_flFogStartHeight = 0x4BC
                m_bHeightFogEnabled = 0x4B8
                m_flFogStartDistance = 0x4B0
                m_hGradientFogTexture = 0x4A8
                m_flFogFalloffExponent = 0x4CC
                m_flFogVerticalExponent = 0x4D0
                m_bGradientFogNeedsTextures = 0x4E2
            class CHandleDummy:
                pass
            class CHintMessage:
                m_args = 0x8
                m_duration = 0x20
                m_hintString = 0x0
            class CItemDefuser:
                m_nSpotRules = 0xAF8
                m_entitySpottedState = 0xAE0
            class CItemDogtags:
                m_OwningPlayer = 0xAE0
                m_KillingPlayer = 0xAE4
            class CItemGeneric:
                m_OnPickup = 0xB68
                m_bUseable = 0xC00
                m_OnTimeout = 0xB80
                m_glowColor = 0xBFC
                m_hPickupFilter = 0xB60
                m_OnTriggerTouch = 0xBB0
                m_flPickupRadius = 0xBE8
                m_hTriggerHelper = 0xC04
                m_flTriggerRadius = 0xBEC
                m_bHasPickupRadius = 0xAF5
                m_OnTriggerEndTouch = 0xBC8
                m_bHasTriggerRadius = 0xAF4
                m_flLastPickupCheck = 0xB00
                m_flPickupRadiusSqr = 0xAF8
                m_pPickupFilterName = 0xB58
                m_bGlowWhenInTrigger = 0xBF8
                m_flTriggerRadiusSqr = 0xAFC
                m_pPickupSoundEffect = 0xB30
                m_OnTriggerStartTouch = 0xB98
                m_pAmbientSoundEffect = 0xB10
                m_pTimeoutSoundEffect = 0xB48
                m_pTriggerSoundEffect = 0xBF0
                m_hSpawnParticleEffect = 0xB08
                m_pSpawnScriptFunction = 0xB20
                m_hPickupParticleEffect = 0xB28
                m_pPickupScriptFunction = 0xB38
                m_bAutoStartAmbientSound = 0xB18
                m_bPlayerInTriggerRadius = 0xB05
                m_hTimeoutParticleEffect = 0xB40
                m_pTimeoutScriptFunction = 0xB50
                m_pAllowPickupScriptFunction = 0xBE0
                m_bPlayerCounterListenerAdded = 0xB04
            class CKeepUpright:
                m_bActive = 0x4E0
                m_nameAttach = 0x4D0
                m_pController = 0x4C8
                m_angularLimit = 0x4DC
                m_localTestAxis = 0x4BC
                m_worldGoalAxis = 0x4B0
                m_attachedObject = 0x4D8
                m_bDampAllRotation = 0x4E1
            class CLightEntity:
                m_CLightComponent = 0x850
            class CLogicBranch:
                m_OnTrue = 0x4C8
                m_OnFalse = 0x4E0
                m_bInValue = 0x4A8
                m_Listeners = 0x4B0
            class CLogicScript:
                pass
            class CMathCounter:
                m_flMax = 0x4AC
                m_flMin = 0x4A8
                m_bHitMax = 0x4B1
                m_bHitMin = 0x4B0
                m_OnHitMax = 0x510
                m_OnHitMin = 0x4F8
                m_OutValue = 0x4B8
                m_bDisabled = 0x4B2
                m_OnGetValue = 0x4D8
                m_OnChangedFromMax = 0x540
                m_OnChangedFromMin = 0x528
            class CMultiSource:
                m_iTotal = 0x5C0
                m_OnTrigger = 0x5A8
                m_rgEntities = 0x4A8
                m_globalstate = 0x5C8
                m_rgTriggered = 0x528
            class CNavPathCost:
                m_bCanFly = 0x11
                m_bCanSwim = 0x12
                m_bAllowLadders = 0x10
                m_flTransitionPenalty = 0x2C
                m_bSupportsTransitions = 0x2A
                m_flGroundToWaterMaxHeight = 0x18
                m_flWaterToGroundMaxHeight = 0x14
                m_bOptimizeFlySpacePathfinds = 0x28
                m_flFlyingTransitionTolerance = 0x24
                m_bStringPullFlySpacePathfinds = 0x29
                m_flGroundToWaterTransitionDistance = 0x1C
                m_flWaterToGroundTransitionDistance = 0x20
            class CNavWalkable:
                pass
            class CNmAimCSTask:
                pass
            class CPhysicsProp:
                m_bAwake = 0xD09
                m_OnAwake = 0xC10
                m_OnAsleep = 0xC28
                m_CrateType = 0xCD0
                m_glowColor = 0xCC0
                m_massScale = 0xC8C
                m_OnAwakened = 0xBF8
                m_damageType = 0xC94
                m_flLastBurn = 0xCA8
                m_nGlowRange = 0xCB8
                m_nItemCount = 0xCF8
                m_OnPlayerUse = 0xC40
                m_OnOutOfWorld = 0xC58
                m_strItemClass = 0xCD8
                m_MotionEnabled = 0xBE0
                m_buoyancyScale = 0xC90
                m_nGlowRangeMin = 0xCBC
                m_OnPlayerPickup = 0xC70
                m_bForceNavIgnore = 0xC88
                m_bIsOverrideProp = 0xCA4
                m_bDroppedByPlayer = 0xCA0
                m_bEnableUseOutput = 0xCCF
                m_bForceNpcExclude = 0xC8A
                m_bHasBeenAwakened = 0xCA3
                m_bTouchedByPlayer = 0xCA1
                m_nNavObstacleType = 0xCC8
                m_bNoNavmeshBlocker = 0xC89
                m_iInitialGlowState = 0xCB4
                m_bMuteImpactEffects = 0xCC5
                m_bForceNavObstacleCut = 0xCCD
                m_bUpdateNavWhenMoving = 0xCCC
                m_damageToEnableMotion = 0xC98
                m_flForceToEnableMotion = 0xC9C
                m_bAttachedToReferenceFrame = 0xD0A
                m_bFirstCollisionAfterLaunch = 0xCA2
                m_bRemovableForAmmoBalancing = 0xD08
                m_bAcceptDamageFromHeldObjects = 0xCCE
                m_bShouldAutoConvertBackFromDebris = 0xCC4
                m_nDynamicContinuousContactBehavior = 0xCAC
                m_fNextCheckDisableMotionContactsTime = 0xCB0
            class CPhysicsWire:
                m_nDensity = 0x4A8
            class CPlatTrigger:
                m_pPlatform = 0x850
            class CPointCamera:
                m_FOV = 0x4A8
                m_bIsOn = 0x4FC
                m_pNext = 0x500
                m_bNoSky = 0x4CC
                m_flZFar = 0x4D4
                m_bActive = 0x4C4
                m_flZNear = 0x4D8
                m_FogColor = 0x4B4
                m_flFogEnd = 0x4BC
                m_TargetFOV = 0x4F4
                m_Resolution = 0x4AC
                m_bFogEnable = 0x4B0
                m_flFogStart = 0x4B8
                m_bCanHLTVUse = 0x4DC
                m_bDofEnabled = 0x4DE
                m_fBrightness = 0x4D0
                m_flAspectRatio = 0x4C8
                m_flDofFarCrisp = 0x4E8
                m_flDofFarBlurry = 0x4EC
                m_flDofNearCrisp = 0x4E4
                m_flDofNearBlurry = 0x4E0
                m_flFogMaxDensity = 0x4C0
                m_DegreesPerSecond = 0x4F8
                m_bAlignWithParent = 0x4DD
                m_flDofTiltToGround = 0x4F0
                m_bUseScreenAspectRatio = 0x4C5
            class CPointEntity:
                pass
            class CPointOrient:
                m_bActive = 0x4B4
                m_hTarget = 0x4B0
                m_nConstraint = 0x4BC
                m_flMaxTurnRate = 0x4C0
                m_flLastGameTime = 0x4C4
                m_nGoalDirection = 0x4B8
                m_iszSpawnTargetName = 0x4A8
            class CPointPrefab:
                m_fixupNames = 0x4C0
                m_bLoadDynamic = 0x4C1
                m_targetMapName = 0x4A8
                m_forceWorldGroupID = 0x4B0
                m_associatedRelayEntity = 0x4C4
                m_ProceduralRelaySources = 0x4C8
                m_associatedRelayTargetName = 0x4B8
            class CRR_Response:
                m_Type = 0x0
                m_Params = 0x160
                m_Followup = 0x198
                m_fMatchScore = 0x180
                m_szMatchingRule = 0xC1
                m_szResponseName = 0x1
                m_szWorldContext = 0x190
                m_recipientFilter = 0x1B4
                m_szSpeakerContext = 0x188
                m_bAnyMatchingRulesInCooldown = 0x184
            class CRagdollProp:
                m_ragPos = 0xB08
                m_hKiller = 0xB4C
                m_ragdoll = 0xA90
                m_allAsleep = 0xB3C
                m_massScale = 0xAE4
                m_ragAngles = 0xB20
                m_flFadeTime = 0xB5C
                m_ragEnabled = 0xAF0
                m_flAwakeTime = 0xB6C
                m_ragdollMaxs = 0xBB0
                m_ragdollMins = 0xB98
                m_bAllowStretch = 0xB89
                m_buoyancyScale = 0xAE8
                m_flBlendWeight = 0xB8C
                m_hDamageEntity = 0xB48
                m_vecLastOrigin = 0xB60
                m_bStartDisabled = 0xAE0
                m_vecNavObstacles = 0xBE0
                m_hPhysicsAttacker = 0xB50
                m_nNavObstacleType = 0xB40
                m_CPropDataComponent = 0xA50
                m_bHasBeenPhysgunned = 0xB88
                m_flDefaultFadeScale = 0xB90
                m_flFadeOutStartTime = 0xB58
                m_strOriginClassName = 0xB78
                m_strSourceClassName = 0xB80
                m_lastUpdateTickCount = 0xB38
                m_bForceNavObstacleCut = 0xB45
                m_bUpdateNavWhenMoving = 0xB44
                m_flLastOriginChangeTime = 0xB70
                m_bAttachedToReferenceFrame = 0xB46
                m_bFirstCollisionAfterLaunch = 0xB3D
                m_flLastPhysicsInfluenceTime = 0xB54
                m_bShouldDeleteActivationRecord = 0xBC8
            class CRevertSaved:
                m_Duration = 0x854
                m_HoldTime = 0x858
                m_loadTime = 0x850
            class CSceneEntity:
                m_fPitch = 0x53C
                m_hActor = 0x7E8
                m_OnStart = 0x5C8
                m_bPaused = 0x529
                m_ActorMap = 0x770
                m_OnPaused = 0x610
                m_hTarget1 = 0x4F8
                m_hTarget2 = 0x4FC
                m_hTarget3 = 0x500
                m_hTarget4 = 0x504
                m_hTarget5 = 0x508
                m_hTarget6 = 0x50C
                m_hTarget7 = 0x510
                m_hTarget8 = 0x514
                m_BusyActor = 0x7F0
                m_OnResumed = 0x628
                m_OnCanceled = 0x5F8
                m_bAutomated = 0x540
                m_bRestoring = 0x7A4
                m_hActivator = 0x7EC
                m_hActorList = 0x560
                m_iszTarget1 = 0x4B8
                m_iszTarget2 = 0x4C0
                m_iszTarget3 = 0x4C8
                m_iszTarget4 = 0x4D0
                m_iszTarget5 = 0x4D8
                m_iszTarget6 = 0x4E0
                m_iszTarget7 = 0x4E8
                m_iszTarget8 = 0x4F0
                m_flFrameTime = 0x534
                m_ActorClipMap = 0x748
                m_OnCompletion = 0x5E0
                m_bInterrupted = 0x7A1
                m_bMultiplayer = 0x52A
                m_iszSceneFile = 0x4B0
                m_iszSoundName = 0x7D8
                m_ActorGraphMap = 0x720
                m_AnchorNameMap = 0x6F8
                m_TargetNameMap = 0x6D0
                m_bSceneMissing = 0x7A0
                m_flCurrentTime = 0x530
                m_hListManagers = 0x7C0
                m_bAutogenerated = 0x52B
                m_bIsPlayingBack = 0x528
                m_bSceneFinished = 0x55A
                m_hLocatorOrigin = 0x518
                m_bBreakOnNonIdle = 0x559
                m_bCompletedEarly = 0x7A2
                m_bPausedViaInput = 0x554
                m_hInterruptScene = 0x788
                m_iszSequenceName = 0x7E0
                m_nInterruptCount = 0x78C
                m_nSpeechPriority = 0x550
                m_responseConcept = 0x790
                m_bWaitingForActor = 0x556
                m_flAutomationTime = 0x54C
                m_hRemoveActorList = 0x578
                m_nAutomatedAction = 0x544
                m_responseCriteria = 0x798
                m_flAutomationDelay = 0x548
                m_flForceClientTime = 0x52C
                m_nSceneStringIndex = 0x5C0
                m_sTargetAttachment = 0x520
                m_OnPulseRequirement = 0x640
                m_bRemoveOnCompletion = 0x539
                m_bWaitingForInterrupt = 0x557
                m_iPlayerDeathBehavior = 0x7F4
                m_bPauseAtNextInterrupt = 0x555
                m_bCancelAtNextInterrupt = 0x538
                m_hNotifySceneCompletion = 0x7A8
                m_bInterruptSceneFinished = 0x7A3
                m_bInterruptedActorsScenes = 0x558
            class CSkillDamage:
                m_flDamage = 0x0
                m_flPhysicsForceDamage = 0x14
                m_flNPCDamageScalarVsNPC = 0x10
            class CTankTrainAI:
                m_hTrain = 0x4A8
                m_soundPlaying = 0x4B0
                m_hTargetEntity = 0x4AC
                m_startSoundName = 0x4C8
                m_engineSoundName = 0x4D0
                m_targetEntityName = 0x4E0
                m_movementSoundName = 0x4D8
            class CTestPulseIO:
                m_OnVariantInt = 0x4E0
                m_OnVariantBool = 0x4C0
                m_OnVariantVoid = 0x4A8
                m_TestComponent = 0x590
                m_OnVariantColor = 0x540
                m_OnVariantFloat = 0x500
                m_OnVariantString = 0x520
                m_OnVariantVector = 0x560
                m_OnInternalTestInt = 0x5F8
                m_bAllowEmptyInputs = 0x588
                m_OnInternalTestBool = 0x5D8
                m_OnInternalTestVoid = 0x5C0
                m_OnInternalTestColor = 0x658
                m_OnInternalTestFloat = 0x618
                m_OnInternalTestString = 0x638
                m_OnInternalTestVector = 0x678
                m_OnInternalTestEntityName = 0x6A0
                m_OnInternalTestSchemaEnum = 0x6E0
                m_OnInternalTestFloatString = 0x700
                m_OnInternalTestEntityHandle = 0x6C0
                m_OnInternalTestEntityHandleInt = 0x750
                m_OnInternalTestEntityNameString = 0x728
                m_OnInternalTestStringStringString = 0x770
            class CTimerEntity:
                m_OnTimer = 0x4A8
                m_bPaused = 0x514
                m_iDisabled = 0x4F0
                m_OnTimerLow = 0x4D8
                m_OnTimerHigh = 0x4C0
                m_bUpDownState = 0x4FC
                m_flRefireTime = 0x4F8
                m_flInitialDelay = 0x4F4
                m_iUseRandomTime = 0x500
                m_flRemainingTime = 0x510
                m_bPauseAfterFiring = 0x504
                m_flLowerRandomBound = 0x508
                m_flUpperRandomBound = 0x50C
            class CTriggerHurt:
                m_OnHurt = 0xA00
                m_flDamage = 0x9CC
                m_bNoDmgForce = 0x9E4
                m_damageModel = 0x9E0
                m_flDamageCap = 0x9D0
                m_thinkAlways = 0x9F4
                m_OnHurtPlayer = 0xA18
                m_hurtEntities = 0xA30
                m_vDamageForce = 0x9E8
                m_flLastDmgTime = 0x9D4
                m_hurtThinkPeriod = 0x9F8
                m_flOriginalDamage = 0x9C8
                m_bitsDamageInflict = 0x9DC
                m_flForgivenessDelay = 0x9D8
            class CTriggerLook:
                m_b2DFOV = 0x9FA
                m_OnEndLook = 0xA30
                m_OnTimeout = 0xA00
                m_bIsLooking = 0x9F9
                m_flLookTime = 0x9E8
                m_OnStartLook = 0xA18
                m_hLookTarget = 0x9E0
                m_bUseVelocity = 0x9FB
                m_bTimeoutFired = 0x9F8
                m_flFieldOfView = 0x9E4
                m_bTestOcclusion = 0x9FC
                m_flLookTimeLast = 0x9F0
                m_flLookTimeTotal = 0x9EC
                m_flTimeoutDuration = 0x9F4
                m_bTestAllVisibleOcclusion = 0x9FD
            class CTriggerOnce:
                pass
            class CTriggerPush:
                m_flSpeed = 0x9F8
                m_PathSimple = 0x9F0
                m_bUsePathSimple = 0x9E1
                m_splinePushType = 0x9F4
                m_iszPathSimpleName = 0x9E8
                m_angPushEntitySpace = 0x9C8
                m_bTriggerOnStartTouch = 0x9E0
                m_vecPushDirEntitySpace = 0x9D4
            class CTriggerSave:
                m_minHitPoints = 0x9D0
                m_fDangerousTimer = 0x9CC
                m_flRetriggerDelay = 0x9D4
                m_bForceNewLevelUnit = 0x9C8
            class CWaterBullet:
                pass
            class CWeaponBizon:
                pass
            class CWeaponCZ75a:
                m_bMagazineRemoved = 0x12A0
            class CWeaponElite:
                pass
            class CWeaponFamas:
                pass
            class CWeaponG3SG1:
                pass
            class CWeaponGlock:
                pass
            class CWeaponMAC10:
                pass
            class CWeaponMP5SD:
                pass
            class CWeaponNegev:
                pass
            class CWeaponSG556:
                pass
            class CWeaponSSG08:
                pass
            class CWeaponTaser:
                m_fFireTime = 0x12A0
                m_nLastAttackTick = 0x12A4
            class CWeaponUMP45:
                pass
            class FilterHealth:
                m_iHealthMax = 0x4E8
                m_iHealthMin = 0x4E4
                m_bAdrenalineActive = 0x4E0
            class INavObstacle:
                m_nId = 0x8
            class INavPathCost:
                m_navHull = 0x8
            class NavGravity_t:
                m_bDefault = 0xC
                m_vGravity = 0x0
            class CAI_Expresser:
                m_pOuter = 0x98
                m_voicePitch = 0x70
                m_ruleCooldowns = 0x38
                m_flStopTalkTime = 0x60
                m_conceptCooldowns = 0x10
                m_flBlockedTalkTime = 0x6C
                m_flQueuedSpeechTime = 0x68
                m_nLastSpokenPriority = 0x7C
                m_bSceneEntityDisabled = 0x7A
                m_flLastTimeAcceptedSpeak = 0x74
                m_bAllowSpeakingInterrupts = 0x78
                m_flStopTalkTimeWithoutDelay = 0x64
                m_bConsiderSceneInvolvementAsSpeech = 0x79
            class CBasePropDoor:
                m_ls = 0xCF0
                m_OnOpen = 0xE48
                m_OnClose = 0xE30
                m_bLocked = 0xCCC
                m_bNoNPCs = 0xCCD
                m_flSpeed = 0xD24
                m_hMaster = 0xD98
                m_hBlocker = 0xCE8
                m_SlaveName = 0xD90
                m_SoundLock = 0xD58
                m_SoundOpen = 0xD48
                m_hDoorList = 0xCA8
                m_OnAjarOpen = 0xE78
                m_SoundClose = 0xD50
                m_SoundLatch = 0xD68
                m_SoundPound = 0xD70
                m_eDoorState = 0xCC8
                m_hActivator = 0xD20
                m_OnFullyOpen = 0xE18
                m_OnLockedUse = 0xE60
                m_SoundJiggle = 0xD78
                m_SoundMoving = 0xD40
                m_SoundUnlock = 0xD60
                m_bForceClosed = 0xD10
                m_closedAngles = 0xCDC
                m_OnFullyClosed = 0xE00
                m_bFirstBlocked = 0xCEC
                m_nHardwareType = 0xCC0
                m_bNeedsHardware = 0xCC4
                m_closedPosition = 0xCD0
                m_SoundLockedAnim = 0xD80
                m_OnBlockedClosing = 0xDA0
                m_OnBlockedOpening = 0xDB8
                m_nPhysicsMaterial = 0xD8C
                m_numCloseAttempts = 0xD88
                m_flAutoReturnDelay = 0xCA0
                m_OnUnblockedClosing = 0xDD0
                m_OnUnblockedOpening = 0xDE8
                m_vecLatchWorldPosition = 0xD14
            class CCSPlayerPawn:
                m_pBot = 0x1510
                m_bIsScoped = 0x14CC
                m_ArmorValue = 0x1524
                m_EconGloves = 0x1058
                m_LastHitBox = 0x150C
                m_bInBuyZone = 0xF61
                m_bIsWalking = 0x1488
                m_nSpotRules = 0x14C8
                m_bInBombZone = 0xF82
                m_bIsDefusing = 0x14CE
                m_bIsSpawning = 0x1534
                m_bLeftHanded = 0x1470
                m_bResumeZoom = 0x14CD
                m_iDeathFlags = 0x1540
                m_iShotsFired = 0x14E8
                m_strVOPrefix = 0xE68
                m_angEyeAngles = 0x15C0
                m_lastLandTime = 0xFD8
                m_pBuyServices = 0xE38
                m_bHasDeathInfo = 0x1544
                m_bWasInBuyZone = 0xF80
                m_flFlinchStack = 0x14EC
                m_iPlayerLocked = 0xFE0
                m_bIsBuyMenuOpen = 0xFA0
                m_flViewmodelFOV = 0x1484
                m_iBombSiteIndex = 0x14DC
                m_nWhichBombZone = 0x14E0
                m_pRadioServices = 0xE50
                m_bBotAllowActive = 0x1518
                m_bHasFemaleVoice = 0xE62
                m_bInNoDefuseArea = 0x14D8
                m_flDeathInfoTime = 0x1548
                m_flEmitSoundTime = 0x14D4
                m_pBulletServices = 0xE28
                m_qDeathEyeAngles = 0x1464
                m_szLastPlaceName = 0xE70
                m_TouchingBuyZones = 0xF68
                m_bGunGameImmunity = 0x15B8
                m_bWaitForNoAttack = 0x1500
                m_iRetakesOffering = 0xF84
                m_nLastKillerIndex = 0x14A8
                m_pHostageServices = 0xE30
                m_bKilledByHeadshot = 0x1508
                m_bOnGroundLastTick = 0xFDC
                m_pAimPunchServices = 0xE48
                m_bInBombZoneTrigger = 0x14E4
                m_bIsGrabbingHostage = 0x14CF
                m_entitySpottedState = 0x14B0
                m_fLastGivenBombTime = 0x1490
                m_fMolotovDamageTime = 0x15BC
                m_flTimeOfLastInjury = 0xFE8
                m_flVelocityModifier = 0x14F0
                m_flViewmodelOffsetX = 0x1478
                m_flViewmodelOffsetY = 0x147C
                m_flViewmodelOffsetZ = 0x1480
                m_nCharacterDefIndex = 0xE60
                m_nEconGlovesChanged = 0x1440
                m_nRagdollDamageBone = 0xFF4
                m_vecDeathInfoOrigin = 0x154C
                m_vecStashedVelocity = 0x159C
                m_allowAutoFollowTime = 0x14A0
                m_bInHostageResetZone = 0xF60
                m_iDisplayHistoryBits = 0x1498
                m_nLastPickupPriority = 0x151C
                m_vRagdollDamageForce = 0xFF8
                m_vecTotalBulletForce = 0x14F4
                m_GunGameImmunityColor = 0x156C
                m_bInHostageRescueZone = 0xF81
                m_bResetArmorNextSpawn = 0x14A4
                m_bRetakesHasDefuseKit = 0xF8C
                m_bRetakesMVPLastRound = 0xF8D
                m_flLandingTimeSeconds = 0xF9C
                m_flNextSprayDecalTime = 0xFEC
                m_hActiveMinimapVolume = 0x1460
                m_iRetakesMVPBoostItem = 0xF90
                m_iRetakesOfferingCard = 0xF88
                m_ignoreLadderJumpTime = 0x1504
                m_pDamageReactServices = 0xE58
                m_vRagdollServerOrigin = 0x1048
                m_angStashedShootAngles = 0x1578
                m_bWasInBombZoneTrigger = 0x14E5
                m_fLastGivenDefuserTime = 0x148C
                m_wasNotKilledNaturally = 0x15B1
                m_bRagdollDamageHeadshot = 0x1044
                m_flLastAttackedTeammate = 0x149C
                m_iLastWeaponFireUsercmd = 0x1530
                m_bWasInHostageRescueZone = 0xF83
                m_fSwitchedHandednessTime = 0x1474
                m_pActionTrackingServices = 0xE40
                m_unCurrentEquipmentValue = 0x1528
                m_flLastPickupPriorityTime = 0x1520
                m_vecCurrentMinimapVolumes = 0x1448
                m_bGrenadeParametersStashed = 0x1574
                m_grenadeParameterStashTime = 0x1570
                m_szRagdollDamageWeaponName = 0x1004
                m_vecPlayerPatchEconIndices = 0x1558
                m_fImmuneToGunGameDamageTime = 0x15B4
                m_unRoundStartEquipmentValue = 0x152A
                m_RetakesMVPBoostExtraUtility = 0xF94
                m_bNextSprayDecalTimeExpedited = 0xFF0
                m_iBlockingUseActionInProgress = 0x14D0
                m_unFreezetimeEndEquipmentValue = 0x152C
                m_bCommittingSuicideOnTeamChange = 0x15B0
                m_vecStashedGrenadeThrowPosition = 0x1584
                m_flHealthShotBoostExpirationTime = 0xF98
                m_vecStashedGrenadeThrowPawnCenter = 0x1590
                m_flDealtDamageToEnemyMostRecentTimestamp = 0x1494
            class CCSWeaponBase:
                m_donated = 0x1034
                m_bInReload = 0xFA8
                m_bStealthy = 0xFC4
                m_nDropTick = 0x1010
                m_bBurstMode = 0xF9C
                m_hPrevOwner = 0x100C
                m_weaponMode = 0xF70
                m_bRemoveable = 0xEF8
                m_bSilencerOn = 0xFBD
                m_nDeployTick = 0xFAC
                m_bFireOnEmpty = 0xF50
                m_iRecoilIndex = 0xF94
                m_bIsHauledBack = 0xFBC
                m_bWasOwnedByCT = 0x103C
                m_fLastShotTime = 0x1038
                m_flRecoilIndex = 0xF98
                m_OnPlayerPickup = 0xF58
                m_bCanBePickedUp = 0xFF8
                m_iIronSightMode = 0x10B8
                m_bInspectPending = 0xF08
                m_flDroppedAtTime = 0xFB4
                m_flLastShakeTime = 0x10D0
                m_flWatTickOffset = 0x10C0
                m_fAccuracyPenalty = 0xF88
                m_bInspectShouldLoop = 0xF09
                m_bRequireUseToTouch = 0xEFA
                m_nextOwnerTouchTime = 0xFFC
                m_IronSightController = 0x10A0
                m_bDroppedNearBuyZone = 0xFDC
                m_flTurningInaccuracy = 0xF84
                m_iOriginalTeamNumber = 0xFD4
                m_bWasOwnedByTerrorist = 0x103D
                m_nextPrevOwnerUseTime = 0x1008
                m_bReloadHeldSinceStart = 0xFCC
                m_flAttackHoldStartTime = 0xFB0
                m_iMostRecentTeamNumber = 0xFD8
                m_nLastEmptySoundCmdNum = 0xF34
                m_bInSilentReloadSection = 0xFC5
                m_flStealthHoldStartTime = 0xFC8
                m_nextPrevOwnerTouchTime = 0x1000
                m_flPostponeFireReadyFrac = 0xFA4
                m_nPostponeFireReadyTicks = 0xFA0
                m_bPlayerAmmoStockOnPickup = 0xEF9
                m_bSilentReloadStatCounted = 0xFC6
                m_bSilentReloadStatPending = 0xFC7
                m_fAccuracySmoothedForZoom = 0xF90
                m_flLastAccuracyUpdateTime = 0xF8C
                m_flTurningInaccuracyDelta = 0xF74
                m_iWeaponGameplayAnimState = 0xEFC
                m_flLastLOSTraceFailureTime = 0x10BC
                m_flWeaponActionPlaybackRate = 0xFD0
                m_bWasActiveWeaponWhenDropped = 0x1014
                m_flInspectCancelCompleteTime = 0xF04
                m_numRemoveUnownedWeaponThink = 0x1040
                m_flNextAttackRenderTimeOffset = 0xFE0
                m_flTimeSilencerSwitchComplete = 0xFC0
                m_vecTurningInaccuracyEyeDirLast = 0xF78
                m_bUseCanOverrideNextOwnerTouchTime = 0xFF9
                m_flWeaponGameplayAnimStateTimestamp = 0xF00
            class CDamageRecord:
                m_flDamage = 0x64
                m_iNumHits = 0x6C
                m_killType = 0x75
                m_DamagerXuid = 0x50
                m_PlayerDamager = 0x30
                m_RecipientXuid = 0x58
                m_bIsOtherEnemy = 0x74
                m_PlayerRecipient = 0x34
                m_flBulletsDamage = 0x60
                m_iLastBulletUpdate = 0x70
                m_szPlayerDamagerName = 0x40
                m_flActualHealthRemoved = 0x68
                m_szPlayerRecipientName = 0x48
                m_hPlayerControllerDamager = 0x38
                m_hPlayerControllerRecipient = 0x3C
            class CDebugHistory:
                m_nNpcEvents = 0x3E84E8
            class CDecoyGrenade:
                pass
            class CDynamicLight:
                m_On = 0x853
                m_Flags = 0x851
                m_Radius = 0x854
                m_Exponent = 0x858
                m_InnerAngle = 0x85C
                m_LightStyle = 0x852
                m_OuterAngle = 0x860
                m_SpotRadius = 0x864
                m_ActualFlags = 0x850
            class CEconItemView:
                m_iItemID = 0x48
                m_iAccountID = 0x58
                m_iItemIDLow = 0x54
                m_iItemIDHigh = 0x50
                m_bInitialized = 0x68
                m_iEntityLevel = 0x40
                m_szCustomName = 0x160
                m_AttributeList = 0x70
                m_iEntityQuality = 0x3C
                m_iInventoryPosition = 0x5C
                m_iItemDefinitionIndex = 0x38
                m_szCustomNameOverride = 0x201
                m_szCustomNameOverride2 = 0x2A2
                m_szCustomNameOverride3 = 0x343
                m_NetworkedDynamicAttributes = 0xE8
            class CEconWearable:
                m_nForceSkin = 0xEB0
                m_bAlwaysAllow = 0xEB4
            class CEnvExplosion:
                m_hInflictor = 0x864
                m_iMagnitude = 0x850
                m_iClassIgnore = 0x88C
                m_bCreateDebris = 0x86D
                m_flDamageForce = 0x860
                m_flInnerRadius = 0x85C
                m_hEntityIgnore = 0x8A0
                m_iClassIgnore2 = 0x890
                m_flPlayerDamage = 0x854
                m_iRadiusOverride = 0x858
                m_iCustomDamageType = 0x868
                m_iszCustomSoundName = 0x880
                m_iszCustomEffectName = 0x878
                m_iszEntityIgnoreName = 0x898
                m_bHasCustomDamageType = 0x86C
                m_bSuppressParticleImpulse = 0x888
            class CEnvViewPunch:
                m_flRadius = 0x4A8
                m_angViewPunch = 0x4AC
            class CFuncConveyor:
                m_flSpeed = 0x85C
                m_flTargetSpeed = 0x878
                m_flFrictionScale = 0x888
                m_hConveyorModels = 0x890
                m_szConveyorModels = 0x850
                m_angMoveEntitySpace = 0x860
                m_nTransitionStartTick = 0x87C
                m_vecMoveDirEntitySpace = 0x86C
                m_flTransitionStartSpeed = 0x884
                m_nTransitionDurationTicks = 0x880
                m_flTransitionDurationSeconds = 0x858
            class CFuncRotating:
                m_flSpeed = 0x8A4
                m_angStart = 0x8EC
                m_flVolume = 0x8B0
                m_OnStarted = 0x868
                m_OnStopped = 0x850
                m_bReversed = 0x8C8
                m_flMaxSpeed = 0x8B8
                m_bAccelDecel = 0x8C9
                m_NoiseRunning = 0x8C0
                m_flAttenuation = 0x8AC
                m_flBlockDamage = 0x8BC
                m_flFanFriction = 0x8A8
                m_flTargetSpeed = 0x8B4
                m_OnReachedStart = 0x880
                m_bStopAtStartPos = 0x8F8
                m_prevLocalAngles = 0x8E0
                m_vecClientAngles = 0x908
                m_vecClientOrigin = 0x8FC
                m_localRotationVector = 0x898
            class CGlowProperty:
                m_bGlowing = 0x51
                m_bFlashing = 0x44
                m_iGlowTeam = 0x34
                m_iGlowType = 0x30
                m_fGlowColor = 0x8
                m_flGlowTime = 0x48
                m_nGlowRange = 0x38
                m_nGlowRangeMin = 0x3C
                m_flGlowStartTime = 0x4C
                m_glowColorOverride = 0x40
                m_bEligibleForScreenHighlight = 0x50
            class CInfoLandmark:
                pass
            class CLogicCompare:
                m_OnEqualTo = 0x4D0
                m_flInValue = 0x4A8
                m_OnLessThan = 0x4B0
                m_OnNotEqualTo = 0x4F0
                m_OnGreaterThan = 0x510
                m_flCompareValue = 0x4AC
            class CMarkupVolume:
                m_bDisabled = 0x850
            class CNavAttribute:
                pass
            class CNavHullVData:
                m_agentHeight = 0x8
                m_agentRadius = 0x4
                m_agentMaxClimb = 0x1C
                m_agentMaxSlope = 0x20
                m_bAgentEnabled = 0x0
                m_agentCrawlHeight = 0x18
                m_agentShortHeight = 0x10
                m_agentCrawlEnabled = 0x14
                m_agentBorderErosion = 0x30
                m_agentMaxJumpUpDist = 0x2C
                m_agentMaxJumpDownDist = 0x24
                m_flowMapNodeMaxRadius = 0x38
                m_agentShortHeightEnabled = 0xC
                m_flowMapGenerationEnabled = 0x34
                m_agentMaxJumpHorizDistBase = 0x28
            class CNavSpaceInfo:
                pass
            class CNavVolumeAll:
                pass
            class COrnamentProp:
                m_initialOwner = 0xC90
            class CPathKeyFrame:
                m_Angles = 0x4B4
                m_Origin = 0x4A8
                m_qAngle = 0x4C0
                m_iNextKey = 0x4D0
                m_pNextKey = 0x4DC
                m_pPrevKey = 0x4E0
                m_flNextTime = 0x4D8
                m_flMoveSpeed = 0x4E4
            class CPhysThruster:
                m_localOrigin = 0x508
            class CPhysicsShake:
                m_force = 0x8
            class CRandSimTimer:
                m_flMaxInterval = 0xC
                m_flMinInterval = 0x8
            class CRopeKeyframe:
                m_Slack = 0x868
                m_Width = 0x86C
                m_Subdiv = 0x888
                m_RopeFlags = 0x858
                m_hEndPoint = 0x89C
                m_nSegments = 0x874
                m_RopeLength = 0x88A
                m_hStartPoint = 0x898
                m_TextureScale = 0x870
                m_nChangeCount = 0x889
                m_fLockedPoints = 0x88C
                m_flScrollSpeed = 0x890
                m_iNextLinkName = 0x860
                m_bEndPointValid = 0x895
                m_iEndAttachment = 0x8A1
                m_bStartPointValid = 0x894
                m_iStartAttachment = 0x8A0
                m_bCreatedFromMapFile = 0x88D
                m_strRopeMaterialModel = 0x878
                m_iRopeMaterialModelIndex = 0x880
                m_bConstrainBetweenEndpoints = 0x875
            class CSmokeGrenade:
                pass
            class CSpotlightEnd:
                m_Radius = 0x854
                m_flLightScale = 0x850
                m_vSpotlightDir = 0x858
                m_vSpotlightOrg = 0x864
            class CTriggerBrush:
                m_OnUse = 0x880
                m_OnEndTouch = 0x868
                m_OnStartTouch = 0x850
                m_iInputFilter = 0x898
                m_iDontMessageParent = 0x89C
            class CWeaponSCAR20:
                pass
            class CWeaponXM1014:
                pass
            class CodeGenAABB_t:
                m_vMaxBounds = 0xC
                m_vMinBounds = 0x0
            class IntervalTimer:
                m_timestamp = 0x8
                m_nWorldGroupId = 0xC
            class QuestProgress:
                pass
            class audioparams_t:
                localBits = 0x6C
                localSound = 0x8
                soundEventHash = 0x74
                soundscapeIndex = 0x68
                soundscapeEntityListIndex = 0x70
            class dynpitchvol_t:
                pass
            class entitytable_t:
                id = 0x0
                flags = 0x18
                bWasSaved = 0x14
                classname = 0x20
                edictindex = 0x4
                entityname = 0x30
                globalname = 0x28
                saveentityindex = 0x8
                landmarkModelSpace = 0x38
                m_pPrecacheEntityKeys = 0x48
            class sky3dparams_t:
                fog = 0x20
                scale = 0x8
                origin = 0xC
                m_nWorldGroupID = 0x88
                bClip3DSkyBoxNearToWorldFar = 0x18
                flClip3DSkyBoxNearToWorldFarOffset = 0x1C
            class ActorMapping_t:
                m_hEntity = 0x8
                m_sActorName = 0x0
            class AmmoTypeInfo_t:
                m_flMass = 0x28
                m_nFlags = 0x24
                m_flSpeed = 0x2C
                m_nMaxCarry = 0x10
                m_nSplashSize = 0x1C
            class CAttributeList:
                m_pManager = 0x70
                m_Attributes = 0x8
            class CBaseAnimGraph:
                m_vecForce = 0x93C
                m_nForceBone = 0x948
                m_RagdollPose = 0x960
                m_bRagdollEnabled = 0x988
                m_pChoreoServices = 0x930
                m_pRagdollControl = 0x958
                m_bRagdollClientSide = 0x989
                m_OnLayerCycleUpdated = 0x8F8
                m_pMainGraphController = 0x8E8
                m_graphControllerManager = 0x850
                m_bAnimGraphUpdateEnabled = 0x938
                m_bAnimationUpdateScheduled = 0x939
                m_OnExternalChoreoGraphChanged = 0x918
                m_bShouldUpdateTransformations = 0x98A
                m_bInitiallyPopulateInterpHistory = 0x8F0
                m_xParentedRagdollRootInEntitySpace = 0x990
            class CBaseCSGrenade:
                m_bRedraw = 0x1280
                m_fDropTime = 0x1290
                m_bJumpThrow = 0x1283
                m_bPinPulled = 0x1282
                m_fThrowTime = 0x1288
                m_fPinPullTime = 0x1294
                m_nNextHoldTick = 0x129C
                m_bJustPulledPin = 0x1298
                m_flNextHoldFrac = 0x12A0
                m_bIsHeldByPlayer = 0x1281
                m_bThrowAnimating = 0x1284
                m_flThrowStrength = 0x128C
                m_hSwitchToWeaponAfterThrow = 0x12A4
            class CBasePlatTrain:
                m_volume = 0x8E8
                m_flTWidth = 0x8EC
                m_flTLength = 0x8F0
                m_NoiseMoving = 0x8D0
                m_NoiseArrived = 0x8D8
            class CBodyComponent:
                m_pSceneNode = 0x8
                __m_pChainEntity = 0x48
            class CBreakableProp:
                m_OnBreak = 0xAD0
                m_hBreaker = 0xB48
                m_OnStartDeath = 0xAB8
                m_OnTakeDamage = 0xB08
                m_iszPuntSound = 0xBB8
                m_bUsePuntSound = 0xBC0
                m_explodeDamage = 0xB6C
                m_explodeRadius = 0xB70
                m_hLastAttacker = 0xBB4
                m_iMinHealthDmg = 0xB24
                m_explosionDelay = 0xB80
                m_sExplosionType = 0xB78
                m_OnHealthChanged = 0xAE8
                m_PerformanceMode = 0xB4C
                m_flDefBurstScale = 0xB38
                m_flPressureDelay = 0xB34
                m_vDefBurstOffset = 0xB3C
                m_hPhysicsAttacker = 0xBA8
                m_bOriginalBlockLOS = 0xBC1
                m_explosionModifier = 0xBA0
                m_impactEnergyScale = 0xB20
                m_CPropDataComponent = 0xA78
                m_flDefaultFadeScale = 0xBB0
                m_explosionCustomSound = 0xB98
                m_preferredCarryAngles = 0xB28
                m_BreakableContentsType = 0xB54
                m_explosionBuildupSound = 0xB88
                m_explosionCustomEffect = 0xB90
                m_bHasBreakPiecesOrCommands = 0xB68
                m_flPreventDamageBeforeTime = 0xB50
                m_flLastPhysicsInfluenceTime = 0xBAC
                m_strBreakableContentsParticleOverride = 0xB60
                m_strBreakableContentsPropGroupOverride = 0xB58
            class CDecalInstance:
                m_Color = 0x60
                m_nFlags = 0x5C
                m_flDepth = 0x6C
                m_flWidth = 0x64
                m_hEntity = 0x14
                m_flHeight = 0x68
                m_vSAxisLS = 0x50
                m_hMaterial = 0x8
                m_vNormalLS = 0x38
                m_vNormalOS = 0x44
                m_mTransform = 0x70
                m_nBoneIndex = 0x18
                m_bIsAdjacent = 0xFE
                m_flPlaceTime = 0xD8
                m_sDecalGroup = 0x0
                m_vPositionLS = 0x20
                m_vPositionOS = 0x2C
                m_sSequenceName = 0x10
                m_flFadeDuration = 0xE0
                m_nSequenceIndex = 0xFC
                m_nTriangleIndex = 0x1C
                m_flFadeStartTime = 0xDC
                m_flAnimationScale = 0xD0
                m_mLocalToTriangle = 0xA0
                m_flBoundingRadiusSqr = 0xF8
                m_bDoDecalLightmapping = 0xFF
                m_flAnimationStartTime = 0xD4
                m_flLightingOriginOffset = 0xE4
            class CEntityBlocker:
                pass
            class CEnvCubemapBox:
                pass
            class CEnvCubemapFog:
                m_bActive = 0x4CC
                m_flLODBias = 0x4C8
                m_bFirstTime = 0x5A1
                m_hSkyMaterial = 0x4D8
                m_iszSkyEntity = 0x4E0
                m_flEndDistance = 0x4A8
                m_bStartDisabled = 0x4CD
                m_flFogHeightEnd = 0x4BC
                m_nHeightFogType = 0x4E8
                m_flFogMaxOpacity = 0x4D0
                m_flStartDistance = 0x4AC
                m_bHasHeightFogEnd = 0x5A0
                m_flFogHeightStart = 0x4C0
                m_flFogHeightWidth = 0x4B8
                m_nDistanceFogType = 0x4F4
                m_bHeightFogEnabled = 0x4B4
                m_hFogCubemapTexture = 0x598
                m_nCubemapSourceType = 0x4D4
                m_flFogHeightExponent = 0x4C4
                m_nFogHeightBlendMode = 0x4EC
                m_HeightFogCurveString = 0x500
                m_flFogFalloffExponent = 0x4B0
                m_DistanceFogCurveString = 0x4F8
                m_nFogHeightCoordinateSpace = 0x4F0
            class CEnvSoundscape:
                m_OnPlay = 0x4A8
                m_flRadius = 0x4C0
                m_bDisabled = 0x524
                m_positionNames = 0x4E0
                m_soundEventHash = 0x530
                m_soundEventName = 0x4C8
                m_soundscapeName = 0x528
                m_soundscapeIndex = 0x4D4
                m_hProxySoundscape = 0x520
                m_bOverrideWithEvent = 0x4D0
                m_soundscapeEntityListId = 0x4D8
            class CEnvWindShared:
                m_iMaxGust = 0x1A
                m_iMaxWind = 0x12
                m_iMinGust = 0x18
                m_iMinWind = 0x10
                m_location = 0x30
                m_OnGustEnd = 0x58
                m_hEntOwner = 0x70
                m_iWindSeed = 0xC
                m_windRadius = 0x14
                m_OnGustStart = 0x40
                m_flStartTime = 0x8
                m_flGustDuration = 0x24
                m_flMaxGustDelay = 0x20
                m_flMinGustDelay = 0x1C
                m_iGustDirChange = 0x28
                m_iInitialWindDir = 0x2A
                m_flInitialWindSpeed = 0x2C
            class CFilterContext:
                m_iFilterContext = 0x4E0
            class CFiringModeInt:
                m_nValues = 0x0
            class CFogController:
                m_fog = 0x4A8
                m_bUseAngles = 0x510
                m_iChangedVariables = 0x514
            class CFuncTankTrain:
                m_OnDeath = 0x978
            class CFuncTimescale:
                m_isStarted = 0x4B8
                m_flAcceleration = 0x4AC
                m_flMinBlendRate = 0x4B0
                m_flDesiredTimescale = 0x4A8
                m_flBlendDeltaMultiplier = 0x4B4
            class CFuncTrackAuto:
                pass
            class CGameSceneNode:
                m_name = 0xF0
                m_pChild = 0x40
                m_pOwner = 0x30
                m_flScale = 0xC4
                m_hParent = 0x70
                m_pParent = 0x38
                m_bDormant = 0xE7
                m_vecOrigin = 0x80
                m_flAbsScale = 0xE0
                m_angRotation = 0xB8
                m_nodeToWorld = 0x10
                m_pNextSibling = 0x48
                m_vecAbsOrigin = 0xC8
                m_angAbsRotation = 0xD4
                m_bBoneMergeFlex = 0x0
                m_nHierarchyType = 0xEC
                m_bDirtyHierarchy = 0x0
                m_nLatchAbsOrigin = 0x0
                m_flClientLocalScale = 0x108
                m_nHierarchicalDepth = 0xEB
                m_bDirtyBoneMergeInfo = 0x0
                m_hierarchyAttachName = 0x104
                m_bDebugAbsOriginChanges = 0xE6
                m_bNetworkedScaleChanged = 0x0
                m_bNetworkedAnglesChanged = 0x0
                m_nParentAttachmentOrBone = 0xE4
                m_bDirtyBoneMergeBoneToRoot = 0x0
                m_bForceParentToBeNetworked = 0xE8
                m_bNetworkedPositionChanged = 0x0
                m_bWillBeCallingPostDataUpdate = 0x0
                m_nDoNotSetAnimTimeInInvalidatePhysicsCount = 0xED
            class CInButtonState:
                m_pButtonStates = 0x8
            class CLogicAutosave:
                m_minHitPoints = 0x4AC
                m_bForceNewLevelUnit = 0x4A8
                m_minHitPointsToCommit = 0x4B0
            class CLogicalEntity:
                pass
            class CMessageEntity:
                m_radius = 0x4A8
                m_bEnabled = 0x4BA
                m_drawText = 0x4B8
                m_messageText = 0x4B0
                m_bDeveloperOnly = 0x4B9
            class CMoverPathNode:
                m_OnPassThrough = 0x540
                m_OnPassThroughForward = 0x560
                m_OnPassThroughReverse = 0x580
                m_OnStartFromOrInSegment = 0x500
                m_OnStoppedAtOrInSegment = 0x520
            class CPathQueryUtil:
                m_bIsClosedLoop = 0x78
                m_PathToEntityTransform = 0x10
                m_vecPathSampleDistances = 0x60
                m_vecPathSamplePositions = 0x30
                m_vecPathSampleParameters = 0x48
            class CPhysExplosion:
                m_radius = 0x4B4
                m_flDamage = 0x4B0
                m_flMagnitude = 0x4AC
                m_flPushScale = 0x4CC
                m_flInnerRadius = 0x4C8
                m_OnPushedPlayer = 0x4D8
                m_bExplodeOnSpawn = 0x4A8
                m_ignoreEntityName = 0x4C0
                m_targetEntityName = 0x4B8
                m_bDisablePushClamp = 0x4D2
                m_bAffectInvulnerableEnts = 0x4D1
                m_bConvertToDebrisWhenPossible = 0x4D0
            class CPhysicsSpring:
                m_end = 0x4DC
                m_start = 0x4D0
                m_flFrequency = 0x4B0
                m_flRestLength = 0x4B8
                m_pSpringJoint = 0x4A8
                m_teleportTick = 0x4E8
                m_nameAttachEnd = 0x4C8
                m_flDampingRatio = 0x4B4
                m_nameAttachStart = 0x4C0
            class CPointGiveAmmo:
                m_pActivator = 0x4A8
            class CPointTeleport:
                m_vSaveAngles = 0x4B4
                m_vSaveOrigin = 0x4A8
                m_bTeleportUseCurrentAngle = 0x4C1
                m_bTeleportParentedEntities = 0x4C0
            class CPointTemplate:
                m_iszWorldName = 0x4A8
                m_OnEntitySpawned = 0x510
                m_flTimeoutInterval = 0x4C0
                m_ScriptCallbackScope = 0x508
                m_ScriptSpawnCallback = 0x500
                m_iszEntityFilterName = 0x4B8
                m_ownerSpawnGroupType = 0x4CC
                m_SpawnedEntityHandles = 0x4E8
                m_clientOnlyEntityBehavior = 0x4C8
                m_createdSpawnGroupHandles = 0x4D0
                m_iszSource2EntityLumpName = 0x4B0
                m_bAsynchronouslySpawnEntities = 0x4C4
            class CPrecipitation:
                pass
            class CPulseGraphDef:
                m_Vars = 0x80
                m_Cells = 0x68
                m_Chunks = 0x50
                m_CallInfos = 0xE0
                m_Constants = 0xF8
                m_DomainValues = 0x110
                m_TempVarBanks = 0x98
                m_DomainSubType = 0x18
                m_ParentMapName = 0x30
                m_ParentXmlName = 0x40
                m_PublicOutputs = 0xB0
                m_InvokeBindings = 0xC8
                m_DomainIdentifier = 0x8
                m_OutputConnections = 0x140
                m_BlackboardReferences = 0x128
            class CRagdollMagnet:
                m_axis = 0x4B4
                m_force = 0x4B0
                m_radius = 0x4AC
                m_bDisabled = 0x4A8
            class CRandStopwatch:
                m_flMaxInterval = 0x10
                m_flMinInterval = 0xC
            class CResponseQueue:
                m_ExpresserTargets = 0x38
            class CRotatorTarget:
                pass
            class CSMatchStats_t:
                m_i1v1Wins = 0xA8
                m_i1v2Wins = 0xB0
                m_i1v1Count = 0xA4
                m_i1v2Count = 0xAC
                m_iEnemy2Ks = 0x7C
                m_iEnemy3Ks = 0x70
                m_iEnemy4Ks = 0x6C
                m_iEnemy5Ks = 0x68
                m_iEntryWins = 0xB8
                m_iEntryCount = 0xB4
                m_iFlash_Count = 0x8C
                m_iUtility_Count = 0x80
                m_iEnemyKnifeKills = 0x74
                m_iEnemyTaserKills = 0x78
                m_iFlash_Successes = 0x90
                m_iUtility_Enemies = 0x88
                m_nShotsFiredTotal = 0x9C
                m_iUtility_Successes = 0x84
                m_nShotsOnTargetTotal = 0xA0
                m_flHealthPointsDealtTotal = 0x98
                m_flHealthPointsRemovedTotal = 0x94
            class CSoundEnvelope:
                m_rate = 0x8
                m_target = 0x4
                m_current = 0x0
                m_forceupdate = 0xC
            class CStopwatchBase:
                m_bIsRunning = 0x8
            class CTeamplayRules:
                pass
            class CTriggerImpact:
                m_flNoise = 0x9E4
                m_flViewkick = 0x9E8
                m_flMagnitude = 0x9E0
                m_pOutputForce = 0x9F0
            class CTriggerRemove:
                m_OnRemove = 0x9C8
            class CTriggerVolume:
                m_hFilter = 0x858
                m_iFilterName = 0x850
            class CWeaponGalilAR:
                pass
            class CWeaponHKP2000:
                pass
            class CountdownTimer:
                m_duration = 0x8
                m_timescale = 0x10
                m_timestamp = 0xC
                m_nWorldGroupId = 0x14
            class IHasAttributes:
                pass
            class ParticleNode_t:
                m_iIndex = 0x4
                m_hEntity = 0x0
                m_flStartTime = 0x8
                m_flEndcapTime = 0x1C
                m_vecGrowthOrigin = 0x10
                m_bMarkedForDelete = 0x20
                m_flGrowthDuration = 0xC
            class Relationship_t:
                priority = 0x4
                disposition = 0x0
            class ResponseParams:
                odds = 0x10
                flags = 0x12
                m_pFollowup = 0x18
            class SceneEventId_t:
                m_Value = 0x0
            class SoundCommand_t:
                m_time = 0x8
                m_value = 0x14
                m_command = 0x10
                m_deltaTime = 0xC
            class globalentity_t:
                name = 0x0
                state = 0x4
                counter = 0x8
                levelName = 0x2
            class hudtextparms_t:
                x = 0xC
                y = 0x10
                color1 = 0x0
                color2 = 0x4
                effect = 0x8
                channel = 0x9
            class CAmbientGeneric:
                m_dpv = 0x4B4
                m_radius = 0x4A8
                m_fActive = 0x518
                m_fLooping = 0x519
                m_iszSound = 0x520
                m_flMaxRadius = 0x4AC
                m_iSoundLevel = 0x4B0
                m_hSoundSource = 0x530
                m_sSourceEntName = 0x528
                m_nSoundSourceEntIndex = 0x534
            class CBasePlayerPawn:
                v_angle = 0xBC8
                m_fInitHUD = 0xC88
                m_iHideHUD = 0xBE0
                m_skybox3d = 0xBE8
                m_pExpresser = 0xC90
                m_flDeathTime = 0xC7C
                m_hController = 0xC98
                m_pUseServices = 0xB38
                m_fTimeLastHurt = 0xC78
                m_pItemServices = 0xB18
                v_anglePrevious = 0xBD4
                m_fHltvReplayEnd = 0xCA8
                m_pWaterServices = 0xB30
                m_pCameraServices = 0xB48
                m_pWeaponServices = 0xB10
                m_fHltvReplayDelay = 0xCA4
                m_fNextSuicideTime = 0xC80
                m_pAutoaimServices = 0xB20
                m_iHltvReplayEntity = 0xCAC
                m_pMovementServices = 0xB50
                m_pObserverServices = 0xB28
                m_sndOpvarLatchData = 0xCB0
                m_hDefaultController = 0xC9C
                m_pFlashlightServices = 0xB40
                m_ServerViewAngleChanges = 0xB60
            class CBtActionMoveTo:
                m_RepathTimer = 0xC0
                m_bComputePath = 0x85
                m_vecDestination = 0x78
                m_bAutoLookAdjust = 0x84
                m_flArrivalEpsilon = 0xD8
                m_szThreatInputKey = 0x70
                m_szHidingSpotInputKey = 0x68
                m_CheckHighPriorityItem = 0xA8
                m_szDestinationInputKey = 0x60
                m_flDamagingAreasPenaltyCost = 0x88
                m_CheckApproximateCornersTimer = 0x90
                m_flAdditionalArrivalEpsilon2D = 0xDC
                m_flNearestAreaDistanceThreshold = 0xE4
                m_flHidingSpotCheckDistanceThreshold = 0xE0
            class CBuoyancyHelper:
                m_nFluidType = 0x18
                m_pController = 0x8
                m_vecWheelDrag = 0x78
                m_flFluidDensity = 0x1C
                m_bNeutrallyBuoyant = 0x2C
                m_vecWheelFrictionScales = 0x48
                m_flNeutrallyBuoyantGravity = 0x20
                m_flNeutrallyBuoyantLinearDamping = 0x24
                m_flNeutrallyBuoyantAngularDamping = 0x28
                m_vecFractionOfWheelSubmergedForWheelDrag = 0x60
                m_vecFractionOfWheelSubmergedForWheelFriction = 0x30
            class CCSObserverPawn:
                pass
            class CCSPetPlacement:
                pass
            class CCSRadarElement:
                m_nTeamFilter = 0x4C8
                m_nElementType = 0x4C0
                m_nElementColor = 0x4C4
            class CCommentaryAuto:
                m_OnCommentaryMidGame = 0x4C0
                m_OnCommentaryNewGame = 0x4A8
                m_OnCommentaryMultiplayerSpawn = 0x4D8
            class CEntityDissolve:
                m_nMagnitude = 0x87C
                m_flStartTime = 0x868
                m_flFadeInStart = 0x850
                m_nDissolveType = 0x86C
                m_flFadeInLength = 0x854
                m_flFadeOutStart = 0x860
                m_flFadeOutLength = 0x864
                m_vDissolverOrigin = 0x870
                m_flFadeOutModelStart = 0x858
                m_flFadeOutModelLength = 0x85C
            class CEntityIdentity:
                m_name = 0x18
                m_flags = 0x30
                m_pNext = 0x58
                m_pPrev = 0x50
                m_PathIndex = 0x40
                m_pAttributes = 0x48
                m_designerName = 0x20
                m_pNextByClass = 0x68
                m_pPrevByClass = 0x60
                m_worldGroupId = 0x38
                m_fDataObjectTypes = 0x3C
                m_nameStringTableIndex = 0x14
            class CEntityInstance:
                m_pEntity = 0x10
                m_CScriptComponent = 0x28
                m_iszPrivateVScripts = 0x8
            class CEnvEntityMaker:
                m_iszTemplate = 0x4F0
                m_vecEntityMaxs = 0x4B4
                m_vecEntityMins = 0x4A8
                m_hCurrentBlocker = 0x4C4
                m_flPostSpawnSpeed = 0x4E4
                m_hCurrentInstance = 0x4C0
                m_pOutputOnSpawned = 0x4F8
                m_vecBlockerOrigin = 0x4C8
                m_bPostSpawnUseAngles = 0x4E8
                m_pOutputOnFailedSpawn = 0x510
                m_angPostSpawnDirection = 0x4D4
                m_flPostSpawnDirectionVariance = 0x4E0
            class CEnvMuzzleFlash:
                m_flScale = 0x4A8
                m_iszParentAttachment = 0x4B0
            class CFilterMultiple:
                m_hFilter = 0x538
                m_iFilterName = 0x4E8
                m_nFilterType = 0x4E0
            class CFuncMoveLinear:
                m_flSpeed = 0x948
                m_soundStop = 0x8F8
                m_soundStart = 0x8F0
                m_OnFullyOpen = 0x918
                m_currentSound = 0x900
                m_OnFullyClosed = 0x930
                m_flBlockDamage = 0x908
                m_flStartPosition = 0x90C
                m_authoredPosition = 0x8D0
                m_angMoveEntitySpace = 0x8D4
                m_bCreateNavObstacle = 0x94E
                m_bCreateMovableNavMesh = 0x94C
                m_vecMoveDirParentSpace = 0x8E0
                m_bAllowMovableNavMeshDockingOnEntireEntity = 0x94D
            class CFuncNavBlocker:
                m_bDisabled = 0x858
                m_nBlockedTeamNumber = 0x85C
            class CFuncTrackTrain:
                m_dir = 0x8B4
                m_ppath = 0x850
                m_OnNext = 0x928
                m_flBank = 0x8A0
                m_height = 0x8AC
                m_length = 0x854
                m_OnStart = 0x910
                m_angPrev = 0x864
                m_flSpeed = 0x870
                m_flVolume = 0x89C
                m_maxSpeed = 0x8B0
                m_oldSpeed = 0x8A4
                m_vPosPrev = 0x858
                m_controlMaxs = 0x880
                m_controlMins = 0x874
                m_flAccelSpeed = 0x964
                m_flDecelSpeed = 0x968
                m_iszSoundMove = 0x8B8
                m_iszSoundStop = 0x8D0
                m_lastBlockPos = 0x88C
                m_bAccelToSpeed = 0x96C
                m_eVelocityType = 0x8F8
                m_flBlockDamage = 0x8A8
                m_iszSoundStart = 0x8C8
                m_lastBlockTick = 0x898
                m_strPathTarget = 0x8D8
                m_flDesiredSpeed = 0x95C
                m_eOrientationType = 0x8F4
                m_iszSoundMovePing = 0x8C0
                m_flNextMPSoundTime = 0x970
                m_flSpeedChangeTime = 0x960
                m_bManualSpeedChanges = 0x958
                m_flMoveSoundMaxPitch = 0x8F0
                m_flMoveSoundMinPitch = 0x8EC
                m_flNextMoveSoundTime = 0x8E8
                m_flMoveSoundMaxDuration = 0x8E4
                m_flMoveSoundMinDuration = 0x8E0
                m_OnArrivedAtDestinationNode = 0x940
            class CFuncWallToggle:
                pass
            class CGameGibManager:
                m_iLastFrame = 0x4CC
                m_iMaxPieces = 0x4C8
                m_bAllowNewGibs = 0x4C0
                m_iCurrentMaxPieces = 0x4C4
            class CGamePlayerZone:
                m_OnPlayerInZone = 0x858
                m_PlayersInCount = 0x888
                m_OnPlayerOutZone = 0x870
                m_PlayersOutCount = 0x8A8
            class CGameRulesProxy:
                pass
            class CInfoWorldLayer:
                m_layerName = 0x4C8
                m_worldName = 0x4C0
                m_bEntitiesSpawned = 0x4D1
                m_hLayerSpawnGroup = 0x4D4
                m_bWorldLayerVisible = 0x4D0
                m_bCreateAsChildSpawnGroup = 0x4D2
                m_pOutputOnEntitiesSpawned = 0x4A8
            class CLightComponent:
                m_Color = 0x78
                m_flPhi = 0xA4
                m_nStyle = 0xD4
                m_Pattern = 0xD8
                m_flRange = 0x8C
                m_flTheta = 0xA0
                m_SkyColor = 0x190
                m_bEnabled = 0x140
                m_bFlicker = 0x141
                m_flFalloff = 0x90
                m_nCascades = 0xB0
                m_flBrightness = 0x80
                m_hLightCookie = 0xA8
                m_nBounceLight = 0x128
                m_nCastShadows = 0xB4
                m_nDirectLight = 0x124
                m_nShadowWidth = 0xB8
                m_bMixedShadows = 0x19D
                m_flBounceScale = 0x12C
                m_flFadeMaxDist = 0x134
                m_flFadeMinDist = 0x130
                m_nShadowHeight = 0xBC
                __m_pChainEntity = 0x38
                m_SecondaryColor = 0x7C
                m_bRenderDiffuse = 0xC0
                m_flAttenuation0 = 0x94
                m_flAttenuation1 = 0x98
                m_flAttenuation2 = 0x9C
                m_flMinRoughness = 0x1A8
                m_flSkyIntensity = 0x194
                m_flCapsuleLength = 0x1A4
                m_flNearClipPlane = 0x18C
                m_nRenderSpecular = 0xC4
                m_nShadowPriority = 0x110
                m_SkyAmbientBounce = 0x198
                m_bPvsModifyEntity = 0x1B8
                m_flBrightnessMult = 0x88
                m_nFogLightingMode = 0x184
                m_bRenderToCubemaps = 0x120
                m_flBrightnessScale = 0x84
                m_flOrthoLightWidth = 0xCC
                m_nBakedShadowIndex = 0x114
                m_nLightMapUniqueId = 0x11C
                m_bUseSecondaryColor = 0x19C
                m_flOrthoLightHeight = 0xD0
                m_nLightPathUniqueId = 0x118
                m_bAllowSSTGeneration = 0x121
                m_bRenderTransmissive = 0xC8
                m_bUsesBakedShadowing = 0x10C
                m_flShadowFadeMaxDist = 0x13C
                m_flShadowFadeMinDist = 0x138
                m_flLightStyleStartTime = 0x1A0
                m_flPrecomputedMaxRange = 0x180
                m_vPrecomputedOBBAngles = 0x168
                m_vPrecomputedOBBExtent = 0x174
                m_vPrecomputedOBBOrigin = 0x15C
                m_vPrecomputedBoundsMaxs = 0x150
                m_vPrecomputedBoundsMins = 0x144
                m_bPrecomputedFieldsValid = 0x142
                m_flFogContributionStength = 0x188
                m_flShadowCascadeCrossFade = 0xE4
                m_flShadowCascadeDistance0 = 0xEC
                m_flShadowCascadeDistance1 = 0xF0
                m_flShadowCascadeDistance2 = 0xF4
                m_flShadowCascadeDistance3 = 0xF8
                m_nShadowCascadeResolution0 = 0xFC
                m_nShadowCascadeResolution1 = 0x100
                m_nShadowCascadeResolution2 = 0x104
                m_nShadowCascadeResolution3 = 0x108
                m_flShadowCascadeDistanceFade = 0xE8
                m_nCascadeRenderStaticObjects = 0xE0
            class CLogicGameEvent:
                m_iszEventName = 0x4A8
            class CLogicProximity:
                pass
            class CMathColorBlend:
                m_flInMax = 0x4AC
                m_flInMin = 0x4A8
                m_OutValue = 0x4B8
                m_OutColor1 = 0x4B0
                m_OutColor2 = 0x4B4
            class CMolotovGrenade:
                pass
            class CMultiplayRules:
                pass
            class CParticleSystem:
                m_bActive = 0xA50
                m_bFrozen = 0xA51
                m_bNoRamp = 0xBB2
                m_bNoSave = 0xBB0
                m_clrTint = 0xDD4
                m_nDataCP = 0xDC0
                m_nTintCP = 0xDD0
                m_bNoFreeze = 0xBB1
                m_nStopType = 0xA58
                m_flStartTime = 0xA68
                m_bStartActive = 0xBB3
                m_flPreSimTime = 0xA6C
                m_iEffectIndex = 0xA60
                m_iszEffectName = 0xBB8
                m_strDataString = 0xBA8
                m_vecDataCPValue = 0xDC4
                m_hControlPointEnts = 0xAA4
                m_szSnapshotFileName = 0x850
                m_bDataStringLocalized = 0xBA4
                m_iszControlPointNames = 0xBC0
                m_vServerControlPoints = 0xA70
                m_flFreezeTransitionDuration = 0xA54
                m_bAnimateDuringGameplayPause = 0xA5C
                m_iServerControlPointAssignments = 0xAA0
            class CPhysBallSocket:
                m_flSwingLimit = 0x510
                m_flJointFriction = 0x508
                m_flMaxTwistAngle = 0x51C
                m_flMinTwistAngle = 0x518
                m_bEnableSwingLimit = 0x50C
                m_bEnableTwistLimit = 0x514
            class CPhysConstraint:
                m_hJoint = 0x4A8
                m_OnBreak = 0x4F0
                m_hAttach1 = 0x4C0
                m_hAttach2 = 0x4C4
                m_breakSound = 0x4D8
                m_forceLimit = 0x4E0
                m_nameAttach1 = 0x4B0
                m_nameAttach2 = 0x4B8
                m_torqueLimit = 0x4E4
                m_nameAttachment1 = 0x4C8
                m_nameAttachment2 = 0x4D0
                m_minTeleportDistance = 0x4E8
                m_bSnapObjectPositions = 0x4EC
                m_bTreatEntity1AsInfiniteMass = 0x4ED
            class CPhysicalButton:
                pass
            class CPointWorldText:
                m_Color = 0xAF0
                m_FontName = 0xA50
                m_bEnabled = 0xAD0
                m_flFontSize = 0xAD8
                m_bFullbright = 0xAD1
                m_messageText = 0x850
                m_flDepthOffset = 0xADC
                m_nReorientMode = 0xAFC
                m_bDrawBackground = 0xAE0
                m_nJustifyVertical = 0xAF8
                m_flWorldUnitsPerPx = 0xAD4
                m_nJustifyHorizontal = 0xAF4
                m_flBackgroundWorldToUV = 0xAEC
                m_BackgroundMaterialName = 0xA90
                m_flBackgroundBorderWidth = 0xAE4
                m_flBackgroundBorderHeight = 0xAE8
            class CPulseCell_Base:
                m_nEditorNodeID = 0x8
            class CPulse_CallInfo:
                m_PortName = 0x0
                m_nSrcChunk = 0x4C
                m_RegisterMap = 0x18
                m_CallMethodID = 0x48
                m_nEditorNodeID = 0x10
                m_nBreakDestChunk = 0x54
                m_nSrcInstruction = 0x50
                m_nBreakDestInstruction = 0x58
            class CRagdollManager:
                m_bCanTakeDamage = 0x4B1
                m_bSaveImportant = 0x4B0
                m_iMaxRagdollCount = 0x4AC
                m_iCurrentMaxRagdollCount = 0x4A8
            class CRopeOverlapHit:
                m_hEntity = 0x0
                m_vecOverlappingLinks = 0x8
            class CSceneEventInfo:
                m_nType = 0x3C
                m_flNext = 0x40
                m_iLayer = 0x0
                m_hTarget = 0x6C
                m_bStarted = 0x75
                m_flWeight = 0xC
                m_hAnimClip = 0x20
                m_hSequence = 0x8
                m_iPriority = 0x4
                m_bIsGesture = 0x44
                m_bClientSide = 0x74
                m_bHasArrived = 0x38
                m_flLastCycle = 0x1C
                m_bShouldRemove = 0x45
                m_nSceneEventId = 0x70
                m_sAnimClipSlot = 0x28
                m_flLastJumpToTime = 0x18
                m_flLastJumpFromTime = 0x14
                m_sAnimClipSlotWeight = 0x30
                m_flLastAccumulatedTime = 0x10
            class CSimpleSimTimer:
                m_flNext = 0x0
                m_nWorldGroupId = 0x4
            class CSoundStackSave:
                m_iszStackName = 0x4A8
            class CSpriteOriented:
                pass
            class CTakeDamageInfo:
                m_flDamage = 0x44
                m_hAbility = 0x40
                m_hAttacker = 0x3C
                m_iAmmoType = 0x54
                m_hInflictor = 0x38
                m_iHitGroupId = 0x78
                m_bShouldBleed = 0x64
                m_bShouldSpark = 0x65
                m_nDamageFlags = 0x70
                m_iDamageCustom = 0x50
                m_bStoppedBullet = 0x84
                m_bitsDamageType = 0x4C
                m_vecDamageForce = 0x8
                m_flOriginalDamage = 0x60
                m_flTotalledDamage = 0x48
                m_bInTakeDamageFlow = 0x110
                m_vecDamagePosition = 0x14
                m_vecDamageDirection = 0x2C
                m_vecReportedPosition = 0x20
                m_nNumObjectsPenetrated = 0x7C
                m_DestructibleHitGroupRequests = 0x100
                m_flFriendlyFireDamageReductionRatio = 0x80
            class CTonemapTrigger:
                m_hTonemapController = 0x9D0
                m_tonemapControllerName = 0x9C8
            class CTriggerGravity:
                pass
            class CTriggerPhysics:
                m_flFrequency = 0x9F0
                m_linearForce = 0x9EC
                m_linearLimit = 0x9DC
                m_pController = 0x9D0
                m_angularLimit = 0x9E4
                m_gravityScale = 0x9D8
                m_linearDamping = 0x9E0
                m_angularDamping = 0x9E8
                m_flDampingRatio = 0x9F4
                m_bCollapseToForcePoint = 0xA04
                m_vecLinearForcePointAt = 0x9F8
                m_vecLinearForceDirection = 0xA14
                m_vecLinearForcePointAtWorld = 0xA08
                m_bConvertToDebrisWhenPossible = 0xA21
                m_bForceDirectionIsInLocalSpace = 0xA20
            class CVoteController:
                m_nVotesCast = 0x518
                m_VoteOptions = 0x640
                m_bIsYesNoVote = 0x4C8
                m_resetVoteTimer = 0x500
                m_iOnlyTeamToVote = 0x4AC
                m_nPotentialVotes = 0x4C4
                m_potentialIssues = 0x628
                m_nVoteOptionCount = 0x4B0
                m_iActiveIssueIndex = 0x4A8
                m_playerHoldingVote = 0x618
                m_nHighestCountIndex = 0x620
                m_acceptingVotesTimer = 0x4D0
                m_executeCommandTimer = 0x4E8
                m_playerOverrideForVote = 0x61C
            class CWeaponBaseItem:
                m_bRedraw = 0x1281
                m_bSequenceInProgress = 0x1280
            class CWeaponRevolver:
                pass
            class CWeaponSawedoff:
                pass
            class ChickenPathCost:
                pass
            class HostagePathCost:
                pass
            class IChoreoServices:
                pass
            class ParticleIndex_t:
                m_Value = 0x0
            class VelocitySampler:
                m_prevSample = 0x0
                m_fPrevSampleTime = 0xC
                m_fIdealSampleRate = 0x10
            class ActorClipEntry_t:
                m_bLooping = 0x8
                m_sClipName = 0x0
            class ApproachAreaCost:
                pass
            class CBaseModelEntity:
                m_Glow = 0x6A0
                m_OnIgnite = 0x538
                m_Collision = 0x5E8
                m_clrRender = 0x570
                m_nRenderFX = 0x551
                m_fadeMaxDist = 0x700
                m_fadeMinDist = 0x6FC
                m_flFadeScale = 0x704
                m_nRenderMode = 0x550
                m_vecViewOffset = 0x818
                m_bNoInterpolate = 0x5E2
                m_nObjectCulling = 0x70C
                m_CHitboxComponent = 0x4B0
                m_CRenderComponent = 0x4A8
                m_bAllowFadeInView = 0x552
                m_bodyGroupChoices = 0x7F0
                m_flShadowStrength = 0x708
                m_pChoreoComponent = 0x4C8
                m_bRenderToCubemaps = 0x5E0
                m_bodyGroupRequests = 0x718
                m_flGlowBackfaceMult = 0x6F8
                m_bvDisabledHitGroups = 0x848
                m_flDissolveStartTime = 0x530
                m_vecRenderAttributes = 0x578
                m_bodyGroupTotalRequestCount = 0x710
                m_bExpandRenderBoundsToIncludeCloth = 0x5E1
                m_pDestructiblePartsSystemComponent = 0x500
                m_OnDestructibleHitGroupDamageLevelChanged = 0x508
                m_nDestructiblePartInitialStateDestructed0 = 0x4D0
                m_nDestructiblePartInitialStateDestructed1 = 0x4D4
                m_nDestructiblePartInitialStateDestructed2 = 0x4D8
                m_nDestructiblePartInitialStateDestructed3 = 0x4DC
                m_nDestructiblePartInitialStateDestructed4 = 0x4E0
                m_nDestructiblePartInitialStateDestructed0_PartIndex = 0x4E4
                m_nDestructiblePartInitialStateDestructed1_PartIndex = 0x4E8
                m_nDestructiblePartInitialStateDestructed2_PartIndex = 0x4EC
                m_nDestructiblePartInitialStateDestructed3_PartIndex = 0x4F0
                m_nDestructiblePartInitialStateDestructed4_PartIndex = 0x4F4
                m_bDestructiblePartInitialStateDestructed0_GenerateBreakpieces = 0x4F8
                m_bDestructiblePartInitialStateDestructed1_GenerateBreakpieces = 0x4F9
                m_bDestructiblePartInitialStateDestructed2_GenerateBreakpieces = 0x4FA
                m_bDestructiblePartInitialStateDestructed3_GenerateBreakpieces = 0x4FB
                m_bDestructiblePartInitialStateDestructed4_GenerateBreakpieces = 0x4FC
            class CBasePlayerVData:
                m_flUseRange = 0x24C
                m_sModelName = 0x28
                m_nWaterSpeed = 0x248
                m_flCrouchTime = 0x254
                m_flHoldBreathTime = 0x238
                m_nDrowningDamageMax = 0x244
                m_flUseAngleTolerance = 0x250
                m_flArmDamageMultiplier = 0x218
                m_flLegDamageMultiplier = 0x228
                m_sModelNameAg2Override = 0x108
                m_flHeadDamageMultiplier = 0x1E8
                m_nDrowningDamageInitial = 0x240
                m_flChestDamageMultiplier = 0x1F8
                m_flDrowningDamageInterval = 0x23C
                m_flStomachDamageMultiplier = 0x208
            class CBrokenGlassTrap:
                pass
            class CBtNodeComposite:
                pass
            class CBtNodeCondition:
                m_bNegated = 0x58
            class CBtNodeDecorator:
                pass
            class CCSGameModeRules:
                __m_pChainEntity = 0x8
            class CCSMinimapVolume:
                m_strMinimapName = 0x9C8
            class CCSWeaponBaseGun:
                m_zoomLevel = 0x1280
                m_inPrecache = 0x1294
                m_bNeedsBoltAction = 0x1295
                m_silencedModelIndex = 0x1290
                m_iBurstShotsRemaining = 0x1284
                m_nRevolverCylinderIdx = 0x1298
                m_bSkillReloadAvailable = 0x129C
                m_bSkillBoltLiftedFireKey = 0x129F
                m_bSkillReloadLiftedReloadKey = 0x129D
                m_bSkillBoltInterruptAvailable = 0x129E
            class CChoreoComponent:
                m_hOwner = 0x30
                __m_pChainEntity = 0x8
                m_nNextSceneEventId = 0x70
                m_flAllowResponsesEndTime = 0x74
                m_nExernalChoreoGraphCount = 0x34
                m_sActiveExternalChoreoGraphSlotID = 0x38
            class CColorCorrection:
                m_bMaster = 0x4C6
                m_bEnabled = 0x4C5
                m_MaxFalloff = 0x4D0
                m_MinFalloff = 0x4CC
                m_bExclusive = 0x4C8
                m_bClientSide = 0x4C7
                m_flCurWeight = 0x4D4
                m_flMaxWeight = 0x4C0
                m_bStartDisabled = 0x4C4
                m_lookupFilename = 0x6D8
                m_flFadeInDuration = 0x4A8
                m_flFadeOutDuration = 0x4AC
                m_flTimeStartFadeIn = 0x4B8
                m_netlookupFilename = 0x4D8
                m_flTimeStartFadeOut = 0x4BC
                m_flStartFadeInWeight = 0x4B0
                m_flStartFadeOutWeight = 0x4B4
            class CDecalGroupVData:
                m_vecOptions = 0x0
                m_flTotalProbability = 0x18
            class CDecoyProjectile:
                m_fExpireTime = 0xB60
                m_nDecoyShotTick = 0xB58
                m_shotsRemaining = 0xB5C
                m_decoyWeaponDefIndex = 0xB70
            class CEntityComponent:
                pass
            class CEnvParticleGlow:
                m_ColorTint = 0xDE4
                m_flAlphaScale = 0xDD8
                m_flRadiusScale = 0xDDC
                m_flSelfIllumScale = 0xDE0
                m_hTextureOverride = 0xDE8
            class CFilterProximity:
                m_flRadius = 0x4E0
            class CFiringModeFloat:
                m_flValues = 0x0
            class CFootstepControl:
                m_source = 0x9C8
                m_destination = 0x9D0
            class CFuncIllusionary:
                pass
            class CFuncMoverRouter:
                m_hPathMover = 0x4B0
                m_nMoverIndex = 0x4A8
                m_iszPathMoverName = 0x4B8
                m_bRouteToAllMovers = 0x4AC
            class CFuncTrackChange:
                m_use = 0x950
                m_code = 0x948
                m_train = 0x928
                m_trackTop = 0x920
                m_trainName = 0x940
                m_targetState = 0x94C
                m_trackBottom = 0x924
                m_trackTopName = 0x930
                m_trackBottomName = 0x938
            class CFuncVehicleClip:
                pass
            class CGamePlayerEquip:
                pass
            class CHitboxComponent:
                m_flBoundsExpandRadius = 0x14
            class CInfoPlayerStart:
                m_bDisabled = 0x4A8
                m_bIsMaster = 0x4A9
                m_pPawnSubclass = 0x4B0
            class CItemAssaultSuit:
                pass
            class CItem_Healthshot:
                pass
            class CLightSpotEntity:
                pass
            class CLogicBranchList:
                m_OnMixed = 0x578
                m_OnAllTrue = 0x548
                m_OnAllFalse = 0x560
                m_eLastState = 0x540
                m_LogicBranchList = 0x528
                m_nLogicBranchNames = 0x4A8
            class CLogicNPCCounter:
                m_hSource = 0x668
                m_bDisabled = 0x67C
                m_OnFactor_1 = 0x548
                m_OnFactor_2 = 0x5B8
                m_OnFactor_3 = 0x628
                m_OnFactorAll = 0x4D8
                m_nMaxCount_1 = 0x6AC
                m_nMaxCount_2 = 0x6D4
                m_nMaxCount_3 = 0x6FC
                m_nMinCount_1 = 0x6A8
                m_nMinCount_2 = 0x6D0
                m_nMinCount_3 = 0x6F8
                m_nNPCState_1 = 0x6A0
                m_nNPCState_2 = 0x6C8
                m_nNPCState_3 = 0x6F0
                m_OnMaxCount_1 = 0x530
                m_OnMaxCount_2 = 0x5A0
                m_OnMaxCount_3 = 0x610
                m_OnMinCount_1 = 0x518
                m_OnMinCount_2 = 0x588
                m_OnMinCount_3 = 0x5F8
                m_nMaxCountAll = 0x684
                m_nMaxFactor_1 = 0x6B4
                m_nMaxFactor_2 = 0x6DC
                m_nMaxFactor_3 = 0x704
                m_nMinCountAll = 0x680
                m_nMinFactor_1 = 0x6B0
                m_nMinFactor_2 = 0x6D8
                m_nMinFactor_3 = 0x700
                m_OnMaxCountAll = 0x4C0
                m_OnMinCountAll = 0x4A8
                m_flDistanceMax = 0x678
                m_nMaxFactorAll = 0x68C
                m_nMinFactorAll = 0x688
                m_bInvertState_1 = 0x6A4
                m_bInvertState_2 = 0x6CC
                m_bInvertState_3 = 0x6F4
                m_flDefaultDist_1 = 0x6BC
                m_flDefaultDist_2 = 0x6E4
                m_flDefaultDist_3 = 0x70C
                m_OnMinPlayerDist_1 = 0x568
                m_OnMinPlayerDist_2 = 0x5D8
                m_OnMinPlayerDist_3 = 0x648
                m_iszNPCClassname_1 = 0x698
                m_iszNPCClassname_2 = 0x6C0
                m_iszNPCClassname_3 = 0x6E8
                m_OnMinPlayerDistAll = 0x4F8
                m_iszSourceEntityName = 0x670
            class CLogicNavigation:
                m_isOn = 0x4B0
                m_navProperty = 0x4B4
            class CMotorController:
                m_axis = 0x10
                m_speed = 0x8
                m_maxTorque = 0xC
                m_inertiaFactor = 0x1C
            class CMultiLightProxy:
                m_vecLights = 0x4D0
                m_flBrightnessDelta = 0x4BC
                m_bPerformScreenFade = 0x4C0
                m_iszLightNameFilter = 0x4A8
                m_flLightRadiusFilter = 0x4B8
                m_iszLightClassFilter = 0x4B0
                m_flTargetBrightnessMultiplier = 0x4C4
                m_flCurrentBrightnessMultiplier = 0x4C8
            class CNavVolumeSphere:
                m_vCenter = 0x78
                m_flRadius = 0x84
            class CNavVolumeVector:
                m_bHasBeenPreFiltered = 0x80
            class CNmEventConsumer:
                pass
            class CNoiseStreamData:
                m_Stream = 0x0
            class CPathCornerCrash:
                pass
            class CPointCameraVFOV:
                m_flVerticalFOV = 0x508
            class CPulseExecCursor:
                pass
            class CRenderComponent:
                __m_pChainEntity = 0x10
                m_bEnableRendering = 0x58
                m_nSplitscreenFlags = 0x54
                m_bInterpolationReadyToDraw = 0xA8
                m_bIsRenderingWithViewModels = 0x50
            class CRetakeGameRules:
                m_iBombSite = 0x144
                m_nMatchSeed = 0x138
                m_hBombPlanter = 0x148
                m_bBlockersPresent = 0x13C
                m_bRoundInProgress = 0x13D
                m_iFirstSecondHalfRound = 0x140
            class CRuleBrushEntity:
                pass
            class CRulePointEntity:
                m_Score = 0x858
            class CScriptComponent:
                m_scriptClassName = 0x30
            class CSimpleStopwatch:
                pass
            class CSingleplayRules:
                m_bSinglePlayerGameEnding = 0xD0
            class CSkyCameraVolume:
                m_hTarget = 0x4D8
                m_vBoxMaxs = 0x4CC
                m_vBoxMins = 0x4C0
                m_nPriority = 0x4DC
                m_bIsEnabled = 0x4E0
                m_vBlurOrigin = 0x4E4
                m_iszTargetName = 0x4F8
                m_bStartDisabled = 0x4F2
                m_bSkyboxBlurEffect = 0x4E1
                m_bSkyboxReceivesWorldCsm = 0x4F0
                m_bWorldReceivesSkyboxCsm = 0x4F1
            class CSkyboxReference:
                m_hSkyCamera = 0x4AC
                m_worldGroupId = 0x4A8
            class CTriggerBuoyancy:
                m_BuoyancyHelper = 0x9C8
                m_flFluidDensity = 0xAE0
            class CTriggerCallback:
                pass
            class CTriggerMultiple:
                m_OnTrigger = 0x9C8
            class CTriggerTeleport:
                m_iLandmark = 0x9C8
                m_bMirrorPlayer = 0x9D1
                m_bUseLandmarkAngles = 0x9D0
                m_bCheckDestIfClearForPlayer = 0x9D2
            class CWeaponFiveSeven:
                pass
            class FilterDamageType:
                m_iDamageType = 0x4E0
            class ResponseFollowup:
                followup_delay = 0x10
                followup_target = 0x14
                followup_concept = 0x0
                followup_contexts = 0x8
            class WaterWheelDrag_t:
                m_flWheelDrag = 0x4
                m_flFractionOfWheelSubmerged = 0x0
            class ragdollelement_t:
                m_nHeight = 0x28
                m_flRadius = 0x24
                parentIndex = 0x20
                originParentSpace = 0x0
            class CAttributeManager:
                m_hOuter = 0x24
                m_Providers = 0x8
                m_ProviderType = 0x2C
                m_CachedResults = 0x30
                m_bPreventLoopback = 0x28
                m_iReapplyProvisionParity = 0x20
            class CBasePlayerWeapon:
                m_iClip1 = 0xEC0
                m_iClip2 = 0xEC4
                m_OnPlayerUse = 0xED0
                m_pReserveAmmo = 0xEC8
                m_nNextPrimaryAttackTick = 0xEB0
                m_nNextSecondaryAttackTick = 0xEB8
                m_flNextPrimaryAttackTickRatio = 0xEB4
                m_flNextSecondaryAttackTickRatio = 0xEBC
            class CCSGameRulesProxy:
                m_pGameRules = 0x4A8
            class CCSPlayerPawnBase:
                m_iNumSpawns = 0xDF4
                m_bRespawning = 0xDF0
                m_iPlayerState = 0xD40
                m_pPingServices = 0xD30
                m_blindStartTime = 0xD3C
                m_blindUntilTime = 0xD38
                m_flFlashDuration = 0xE04
                m_flFlashMaxAlpha = 0xE08
                m_bHasMovedSinceSpawn = 0xDF1
                m_hOriginalController = 0xE14
                m_fNextRadarUpdateTime = 0xE00
                m_iProgressBarDuration = 0xE10
                m_flProgressBarStartTime = 0xE0C
                m_CTouchExpansionComponent = 0xCE0
                m_flIdleTimeSinceLastAction = 0xDFC
            class CCSPlayerResource:
                m_bHostageAlive = 0x4A8
                m_hostageRescueX = 0x508
                m_hostageRescueY = 0x518
                m_hostageRescueZ = 0x528
                m_bombsiteCenterA = 0x4F0
                m_bombsiteCenterB = 0x4FC
                m_iHostageEntityIDs = 0x4C0
                m_foundGoalPositions = 0x539
                m_bEndMatchNextMapAllVoted = 0x538
                m_isHostageFollowingSomeone = 0x4B4
            class CChoreoInfoTarget:
                pass
            class CCommentarySystem:
                m_vecNodes = 0x48
                m_bCheatState = 0x1C
                m_hCurrentNode = 0x38
                m_iTeleportStage = 0x18
                m_ModifiedConvars = 0x20
                m_flNextTeleportTime = 0x14
                m_hLastCommentaryNode = 0x40
                m_hActiveCommentaryNode = 0x3C
                m_bIsFirstSpawnGroupToLoad = 0x1D
                m_bCommentaryEnabledMidGame = 0x12
            class CConstraintAnchor:
                m_massScale = 0xA40
            class CDestructiblePart:
                m_DebugName = 0x0
                m_nHitGroup = 0x8
                m_DamageLevels = 0x38
                m_sBodyGroupName = 0x30
                m_bOnlyDestroyWhenGibbing = 0x28
                m_bDisableHitGroupWhenDestroyed = 0xC
                m_nOtherHitgroupsToDestroyWhenFullyDestructed = 0x10
            class CEnvEntityIgniter:
                m_flLifetime = 0x4A8
            class CFireCrackerBlast:
                pass
            class CFuncShatterglass:
                m_bBroken = 0x8E6
                m_OnBroken = 0x958
                m_PanelSize = 0x8C8
                m_bBreakSilent = 0x8E4
                m_bStartBroken = 0x8E9
                m_flInitAtTime = 0x8D8
                m_iSurfaceType = 0x970
                m_bGlassInFrame = 0x8E8
                m_bBreakShardless = 0x8E5
                m_bGlassNavIgnore = 0x8E7
                m_flGlassThickness = 0x8DC
                m_flLastCleanupTime = 0x8D4
                m_matPanelTransform = 0x850
                m_iInitialDamageType = 0x8EA
                m_hMaterialDamageBase = 0x978
                m_vExtraDamagePositions = 0x928
                m_vInitialPanelVertices = 0x940
                m_vecShatterGlassShards = 0x8B0
                m_flSpawnInvulnerability = 0x8E0
                m_matPanelTransformWsTemp = 0x880
                m_vInitialDamagePositions = 0x910
                m_flLastShatterSoundEmitTime = 0x8D0
                m_szDamagePositioningEntityName01 = 0x8F0
                m_szDamagePositioningEntityName02 = 0x8F8
                m_szDamagePositioningEntityName03 = 0x900
                m_szDamagePositioningEntityName04 = 0x908
            class CFuncVPhysicsClip:
                m_bDisabled = 0x850
            class CHintMessageQueue:
                m_messages = 0x8
                m_tmMessageEnd = 0x0
                m_pPlayerController = 0x20
            class CInfoChoreoAnchor:
                m_vecTargetWarps = 0x4C0
                m_vecTargetEntries = 0x4A8
            class CLightOrthoEntity:
                pass
            class CLogicAchievement:
                m_OnFired = 0x4B8
                m_bDisabled = 0x4A8
                m_iszAchievementEventID = 0x4B0
            class CModelPointEntity:
                pass
            class CNmSnapWeaponTask:
                pass
            class CPathParticleRope:
                m_flSlack = 0x4DC
                m_flRadius = 0x4E0
                m_ColorTint = 0x4E4
                m_bStartActive = 0x4B0
                m_iEffectIndex = 0x4F0
                m_nEffectState = 0x4E8
                m_iszEffectName = 0x4B8
                m_PathNodes_Name = 0x4C0
                m_PathNodes_Color = 0x540
                m_flParticleSpacing = 0x4D8
                m_PathNodes_Position = 0x4F8
                m_PathNodes_TangentIn = 0x510
                m_flMaxSimulationTime = 0x4B4
                m_PathNodes_PinEnabled = 0x558
                m_PathNodes_TangentOut = 0x528
                m_PathNodes_RadiusScale = 0x570
            class CPlayerSprayDecal:
                m_nEntity = 0x894
                m_nHitbox = 0x898
                m_nPlayer = 0x890
                m_nTintID = 0x8A0
                m_vecLeft = 0x878
                m_nVersion = 0x8A4
                m_rtGcTime = 0x85C
                m_vecStart = 0x86C
                m_nUniqueID = 0x850
                m_unTraceID = 0x858
                m_vecEndPos = 0x860
                m_vecNormal = 0x884
                m_ubSignature = 0x8A5
                m_unAccountID = 0x854
                m_flCreationTime = 0x89C
            class CPlayerVisibility:
                m_bIsEnabled = 0x4B9
                m_flFadeTime = 0x4B4
                m_bStartDisabled = 0x4B8
                m_flVisibilityStrength = 0x4A8
                m_flFogDistanceMultiplier = 0x4AC
                m_flFogMaxDensityMultiplier = 0x4B0
            class CPointAngleSensor:
                m_bFired = 0x4CC
                m_TargetDir = 0x500
                m_bDisabled = 0x4A8
                m_flDuration = 0x4C0
                m_nLookAtName = 0x4B0
                m_flFacingTime = 0x4C8
                m_hLookAtEntity = 0x4BC
                m_hTargetEntity = 0x4B8
                m_OnFacingLookat = 0x4D0
                m_flDotTolerance = 0x4C4
                m_FacingPercentage = 0x528
                m_OnNotFacingLookat = 0x4E8
            class CPropDoorRotating:
                m_angGoal = 0xEE4
                m_vecAxis = 0xE90
                m_flDistance = 0xE9C
                m_flAjarAngle = 0xEB0
                m_eOpenDirection = 0xEA4
                m_eSpawnPosition = 0xEA0
                m_hEntityBlocker = 0xF24
                m_vecBackBoundsMax = 0xF14
                m_vecBackBoundsMin = 0xF08
                m_angRotationClosed = 0xEC0
                m_angRotationOpenBack = 0xED8
                m_vecForwardBoundsMax = 0xEFC
                m_vecForwardBoundsMin = 0xEF0
                m_eCurrentOpenDirection = 0xEA8
                m_angRotationOpenForward = 0xECC
                m_eDefaultCheckDirection = 0xEAC
                m_angRotationAjarDeprecated = 0xEB4
                m_bAjarDoorShouldntAlwaysOpen = 0xF20
            class CRelativeLocation:
                m_Type = 0x18
                m_hEntity = 0x34
                m_vWorldSpacePos = 0x28
                m_vRelativeOffset = 0x1C
            class CSPerRoundStats_t:
                m_iKills = 0x30
                m_iDamage = 0x3C
                m_iDeaths = 0x34
                m_iAssists = 0x38
                m_iLiveTime = 0x4C
                m_iObjective = 0x54
                m_iCashEarned = 0x58
                m_iKillReward = 0x48
                m_iMoneySaved = 0x44
                m_iHeadShotKills = 0x50
                m_iUtilityDamage = 0x5C
                m_iEnemiesFlashed = 0x60
                m_iEquipmentValue = 0x40
            class CSceneListManager:
                m_hScenes = 0x540
                m_iszScenes = 0x4C0
                m_hListManagers = 0x4A8
            class CScriptNavBlocker:
                m_vExtent = 0x868
            class CScriptedSequence:
                m_iszPlay = 0x4B8
                m_nMoveTo = 0x4E8
                m_flRadius = 0x514
                m_flRepeat = 0x518
                m_iszEntry = 0x4A8
                m_bThinking = 0x554
                m_flAngRate = 0x524
                m_hNextCine = 0x550
                m_iszEntity = 0x4D8
                m_startTime = 0x534
                m_hTargetEnt = 0x54C
                m_iszPreIdle = 0x4B0
                m_savedFlags = 0x540
                m_bForceSynch = 0x55D
                m_bSkipFadeIn = 0x6E8
                m_flMoveSpeed = 0x528
                m_iszPostIdle = 0x4C0
                m_nMoveToGait = 0x4EC
                m_iszSyncGroup = 0x4E0
                m_OnEndSequence = 0x598
                m_OnScriptEvent = 0x5F8
                m_bHighPriority = 0x503
                m_bIgnoreLookAt = 0x50A
                m_bIsRepeatable = 0x4FD
                m_bStartOnSpawn = 0x4FF
                m_hForcedTarget = 0x558
                m_iszNextScript = 0x4D0
                m_saved_effects = 0x53C
                m_bIgnoreGravity = 0x50B
                m_bInterruptable = 0x548
                m_matOtherToMain = 0x6C0
                m_OnBeginSequence = 0x568
                m_bIgnoreRotation = 0x510
                m_bIsPlayingEntry = 0x4F9
                m_bSynchPostIdles = 0x509
                m_onDeathBehavior = 0x560
                m_sequenceStarted = 0x549
                m_ConflictResponse = 0x564
                m_OnCancelSequence = 0x5C8
                m_bContinueOnDeath = 0x505
                m_bDontRotateOther = 0x4FC
                m_bIsPlayingAction = 0x4FA
                m_flMoveInterpTime = 0x520
                m_bDontAddModifiers = 0x50E
                m_bIsPlayingPreIdle = 0x4F8
                m_bDontTeleportAtEnd = 0x502
                m_bIsPlayingPostIdle = 0x4FB
                m_bShouldLeaveCorpse = 0x4FE
                m_nForcedCrouchState = 0x4F4
                m_OnActionStartOrLoop = 0x580
                m_bDisallowInterrupts = 0x500
                m_bLoopActionSequence = 0x507
                m_nHeldWeaponBehavior = 0x4F0
                m_savedCollisionGroup = 0x544
                m_bCanOverrideNPCState = 0x501
                m_bHideDebugComplaints = 0x504
                m_bInitiatedSelfDelete = 0x555
                m_bLoopPreIdleSequence = 0x506
                m_flPlayAnimFadeInTime = 0x51C
                m_iPlayerDeathBehavior = 0x6E4
                m_OnPostIdleEndSequence = 0x5B0
                m_bDisableNPCCollisions = 0x50C
                m_bLoopPostIdleSequence = 0x508
                m_bWaitForBeginSequence = 0x538
                m_OnCancelFailedSequence = 0x5E0
                m_hInteractionMainEntity = 0x6E0
                m_iszModifierToAddOnPlay = 0x4C8
                m_nNotReadySequenceCount = 0x530
                m_bEnsureOnNavmeshOnFinish = 0x55F
                m_bKeepAnimgraphLockedPost = 0x50D
                m_bDisableAimingWhileMoving = 0x50F
                m_bDontCancelOtherSequences = 0x55C
                m_bIsTeleportingDueToMoveTo = 0x556
                m_bPreventUpdateYawOnFinish = 0x55E
                m_bPositionRelativeToOtherEntity = 0x54A
                m_bAllowCustomInterruptConditions = 0x557
                m_bWaitUntilMoveCompletesToStartAnimation = 0x52C
            class CServerOnlyEntity:
                pass
            class CSkeletonInstance:
                m_modelState = 0x120
                m_nHitboxSet = 0x3BC
                m_materialGroup = 0x3B8
                m_bDirtyMotionType = 0x3B2
                m_bUseParentRenderBounds = 0x3B0
                m_bForceServerConstraintsEnabled = 0x41C
                m_bDisableSolidCollisionsForHierarchy = 0x3B1
                m_bIsGeneratingLatchedParentSpaceState = 0x3B3
            class CSoundEventEntity:
                m_hSource = 0x55C
                m_bStopOnNew = 0x4AA
                m_bSaveRestore = 0x4AB
                m_iszSoundName = 0x540
                m_bStartOnSpawn = 0x4A8
                m_onGUIDChanged = 0x4C8
                m_bToLocalPlayer = 0x4A9
                m_bSavedIsPlaying = 0x4AC
                m_onSoundFinished = 0x4F8
                m_iszAttachmentName = 0x4C0
                m_flClientCullRadius = 0x510
                m_flSavedElapsedTime = 0x4B0
                m_iszSourceEntityName = 0x4B8
                m_nEntityIndexSelection = 0x560
            class CSplineConstraint:
                m_pSplineBody = 0x568
                m_bEnableLimit = 0x573
                m_hSplineEntity = 0x564
                m_flJointFriction = 0x580
                m_flTransitionTime = 0x584
                m_bFireEventsOnPath = 0x574
                m_flLinearFrequency = 0x578
                m_vPreSolveAnchorPos = 0x598
                m_StartTransitionTime = 0x5A4
                m_flLinarDampingRatio = 0x57C
                m_vAnchorOffsetRestore = 0x558
                m_bEnableAngularConstraint = 0x572
                m_bEnableLateralConstraint = 0x570
                m_bEnableVerticalConstraint = 0x571
                m_vTangentSpaceAnchorAtTransitionStart = 0x5A8
            class CTakeDamageResult:
                m_nHealthLost = 0x18
                m_nDamageFlags = 0x48
                m_flDamageDealt = 0x20
                m_nHealthBefore = 0x1C
                m_bSuppressFlinch = 0x51
                m_vDamagePosition = 0x28
                m_pOriginatingInfo = 0x0
                m_flPreModifiedDamage = 0x24
                m_nTotalledHealthLost = 0x34
                m_bWasDamageSuppressed = 0x50
                m_flTotalledDamageDealt = 0x38
                m_nOverrideFlinchHitGroup = 0x54
                m_flNewDamageAccumulatorValue = 0x40
                m_flTotalledPreModifiedDamage = 0x3C
                m_DestructibleHitGroupRequests = 0x8
            class CTankTargetChange:
                m_newTarget = 0x4A8
                m_newTargetName = 0x4B8
            class CTriggerBombReset:
                pass
            class CTriggerGameEvent:
                m_strTriggerID = 0x9D8
                m_strEndTouchEventName = 0x9D0
                m_strStartTouchEventName = 0x9C8
            class CTriggerProximity:
                m_fRadius = 0x9D8
                m_nTouchers = 0x9DC
                m_hMeasureTarget = 0x9C8
                m_iszMeasureTarget = 0x9D0
                m_NearestEntityDistance = 0x9E0
            class PhysBlockHeader_t:
                nSaved = 0x0
                pWorldObject = 0x8
            class ResponseContext_t:
                m_iszName = 0x0
                m_iszValue = 0x8
                m_fExpirationTime = 0x10
            class SPAWNGROUP_HEADER:
                m_sGroupName = 0x0
                m_vecWorldOffset = 0x10
                m_sEntityLumpName = 0x8
                m_bClientSpawnGroup = 0x40
                m_bSuppressAllEntities = 0x41
            class SequenceHistory_t:
                m_hSequence = 0x0
                m_nSeqLoopMode = 0xC
                m_flPlaybackRate = 0x10
                m_flSeqStartTime = 0x4
                m_flSeqFixedCycle = 0x8
                m_flCyclesPerSecond = 0x14
            class fogplayerparams_t:
                m_hCtrl = 0x8
                m_NewColor = 0x28
                m_OldColor = 0x10
                m_flNewEnd = 0x30
                m_flOldEnd = 0x18
                m_flNewFarZ = 0x3C
                m_flOldFarZ = 0x24
                m_flNewStart = 0x2C
                m_flOldStart = 0x14
                m_flNewMaxDensity = 0x34
                m_flOldMaxDensity = 0x1C
                m_flTransitionTime = 0xC
                m_flNewHDRColorScale = 0x38
                m_flOldHDRColorScale = 0x20
            class modifiedconvars_t:
                pszConvar = 0x0
                pszOrgValue = 0x100
                pszCurrentValue = 0x80
            class CCSCustomHudLayout:
                m_strLayout = 0x4B8
                m_bObservable = 0x4C0
                m_vecPanelIds = 0x6C8
                m_vecClassNames = 0x6E0
                m_globalLayoutState = 0x530
                m_vecPlayerLayoutStates = 0x4C8
                m_vecDialogVariableNames = 0x6F8
            class CCSMinimapBoundary:
                pass
            class CCSWeaponBaseVData:
                m_nPrice = 0x70C
                m_szName = 0x720
                m_flRange = 0x830
                m_nDamage = 0x820
                m_GearSlot = 0x700
                m_flSpread = 0x750
                m_nZoomFOV1 = 0x7F8
                m_nZoomFOV2 = 0x7FC
                m_WeaponType = 0x520
                m_flMaxSpeed = 0x748
                m_nKillAward = 0x710
                m_bIsFullAuto = 0x72D
                m_bIsRevolver = 0x71E
                m_flCycleTime = 0x738
                m_flZoomTime0 = 0x800
                m_flZoomTime1 = 0x804
                m_flZoomTime2 = 0x808
                m_nNumBullets = 0x730
                m_nRecoilSeed = 0x7D4
                m_nSpreadSeed = 0x7D8
                m_nZoomLevels = 0x7F4
                m_szAnimClass = 0x868
                m_vSmokeColor = 0x85C
                m_bMeleeWeapon = 0x71C
                m_flArmorRatio = 0x828
                m_bHasBurstMode = 0x71D
                m_eSilencerType = 0x728
                m_flPenetration = 0x82C
                m_flRecoilAngle = 0x790
                m_vecMuzzlePos0 = 0x608
                m_vecMuzzlePos1 = 0x614
                m_WeaponCategory = 0x524
                m_bShowCrosshair = 0x72C
                m_flIronSightFOV = 0x814
                m_szAnimSkeleton = 0x528
                m_flRangeModifier = 0x834
                m_flThrowVelocity = 0x858
                m_nBurstShotCount = 0x7CC
                m_GearSlotPosition = 0x704
                m_flDeployDuration = 0x7C4
                m_flInaccuracyFire = 0x780
                m_flInaccuracyJump = 0x768
                m_flInaccuracyLand = 0x770
                m_flInaccuracyMove = 0x788
                m_nTracerFrequency = 0x7B0
                m_szTracerParticle = 0x620
                m_bUnzoomsAfterShot = 0x7F0
                m_flInaccuracyStand = 0x760
                m_flRecoilMagnitude = 0x7A0
                m_DefaultLoadoutSlot = 0x708
                m_bAllowBurstHolster = 0x7D0
                m_flInaccuracyCrouch = 0x758
                m_flInaccuracyLadder = 0x778
                m_flInaccuracyReload = 0x7C0
                m_szUseRadioSubtitle = 0x7E8
                m_flRecoveryTimeStand = 0x844
                m_bReloadsSingleShells = 0x734
                m_flHeadshotMultiplier = 0x824
                m_flInaccuracyJumpApex = 0x7BC
                m_flIronSightLooseness = 0x81C
                m_flRecoveryTimeCrouch = 0x840
                m_flRecoilAngleVariance = 0x798
                m_bCannotShootUnderwater = 0x71F
                m_flInaccuracyPitchShift = 0x7E0
                m_flIronSightPullUpSpeed = 0x80C
                m_nPrimaryReserveAmmoMax = 0x714
                m_flAttackMovespeedFactor = 0x7DC
                m_flInaccuracyJumpInitial = 0x7B8
                m_flIronSightPivotForward = 0x818
                m_flIronSightPutDownSpeed = 0x810
                m_flTimeBetweenBurstShots = 0x744
                m_bHideViewModelWhenZoomed = 0x7F1
                m_flRecoveryTimeStandFinal = 0x84C
                m_nSecondaryReserveAmmoMax = 0x718
                m_flRecoilMagnitudeVariance = 0x7A8
                m_flRecoveryTimeCrouchFinal = 0x848
                m_flCycleTimeWhenInBurstMode = 0x740
                m_nRecoveryTransitionEndBullet = 0x854
                m_flFlinchVelocityModifierLarge = 0x838
                m_flFlinchVelocityModifierSmall = 0x83C
                m_flInaccuracyAltSoundThreshold = 0x7E4
                m_nRecoveryTransitionStartBullet = 0x850
                m_flDisallowAttackAfterReloadStartDuration = 0x7C8
            class CCollisionProperty:
                m_vecMaxs = 0x4C
                m_vecMins = 0x40
                m_nSolidType = 0x5B
                m_triggerBloat = 0x5C
                m_usSolidFlags = 0x5A
                m_nSurroundType = 0x5D
                m_CollisionGroup = 0x5E
                m_nEnablePhysics = 0x5F
                m_flCapsuleRadius = 0xAC
                m_vCapsuleCenter1 = 0x94
                m_vCapsuleCenter2 = 0xA0
                m_flBoundingRadius = 0x60
                m_collisionAttribute = 0x10
                m_vecSurroundingMaxs = 0x7C
                m_vecSurroundingMins = 0x88
                m_vecSpecifiedSurroundingMaxs = 0x70
                m_vecSpecifiedSurroundingMins = 0x64
            class CEconItemAttribute:
                m_flValue = 0x34
                m_bSetBonus = 0x40
                m_flInitialValue = 0x38
                m_nRefundableCurrency = 0x3C
                m_iAttributeDefinitionIndex = 0x30
            class CEnableMotionFixup:
                pass
            class CEnvInstructorHint:
                m_Color = 0x4E8
                m_fRange = 0x4F0
                m_bStatic = 0x4F7
                m_iszName = 0x4A8
                m_iTimeout = 0x4C0
                m_bAutoStart = 0x511
                m_iszBinding = 0x508
                m_iszCaption = 0x4D8
                m_fIconOffset = 0x4EC
                m_bNoOffscreen = 0x4F8
                m_iAlphaOption = 0x4F5
                m_iPulseOption = 0x4F4
                m_iShakeOption = 0x4F6
                m_bForceCaption = 0x4F9
                m_bSuppressRest = 0x500
                m_iDisplayLimit = 0x4C4
                m_iInstanceType = 0x4FC
                m_iszReplace_Key = 0x4B0
                m_bLocalPlayerOnly = 0x512
                m_iszIcon_Onscreen = 0x4C8
                m_iszIcon_Offscreen = 0x4D0
                m_bAllowNoDrawTarget = 0x510
                m_iszActivatorCaption = 0x4E0
                m_iszHintTargetEntity = 0x4B8
            class CExplosionTypeData:
                m_DecalType = 0xF8
                m_SoundName = 0x0
                m_bHasForces = 0xF1
                m_bIsIncindiary = 0xF0
                m_ParticleEffect = 0x10
            class CFilterMassGreater:
                m_fFilterMass = 0x4E0
            class CFuncRetakeBarrier:
                pass
            class CFuncTrainControls:
                pass
            class CGenericConstraint:
                m_bAxisNotifiedX = 0x58C
                m_bAxisNotifiedY = 0x58D
                m_bAxisNotifiedZ = 0x58E
                m_flNotifyForceX = 0x568
                m_flNotifyForceY = 0x56C
                m_flNotifyForceZ = 0x570
                m_nLinearMotionX = 0x514
                m_nLinearMotionY = 0x518
                m_nLinearMotionZ = 0x51C
                m_nAngularMotionX = 0x590
                m_nAngularMotionY = 0x594
                m_nAngularMotionZ = 0x598
                m_flBreakAfterTimeX = 0x544
                m_flBreakAfterTimeY = 0x548
                m_flBreakAfterTimeZ = 0x54C
                m_flLinearFrequencyX = 0x520
                m_flLinearFrequencyY = 0x524
                m_flLinearFrequencyZ = 0x528
                m_NotifyForceReachedX = 0x5C0
                m_NotifyForceReachedY = 0x5D8
                m_NotifyForceReachedZ = 0x5F0
                m_flAngularFrequencyX = 0x59C
                m_flAngularFrequencyY = 0x5A0
                m_flAngularFrequencyZ = 0x5A4
                m_flMaxLinearImpulseX = 0x538
                m_flMaxLinearImpulseY = 0x53C
                m_flMaxLinearImpulseZ = 0x540
                m_flMaxAngularImpulseX = 0x5B4
                m_flMaxAngularImpulseY = 0x5B8
                m_flMaxAngularImpulseZ = 0x5BC
                m_flLinearDampingRatioX = 0x52C
                m_flLinearDampingRatioY = 0x530
                m_flLinearDampingRatioZ = 0x534
                m_flNotifyForceMinTimeX = 0x574
                m_flNotifyForceMinTimeY = 0x578
                m_flNotifyForceMinTimeZ = 0x57C
                m_flAngularDampingRatioX = 0x5A8
                m_flAngularDampingRatioY = 0x5AC
                m_flAngularDampingRatioZ = 0x5B0
                m_flNotifyForceLastTimeX = 0x580
                m_flNotifyForceLastTimeY = 0x584
                m_flNotifyForceLastTimeZ = 0x588
                m_flBreakAfterTimeStartTimeX = 0x550
                m_flBreakAfterTimeStartTimeY = 0x554
                m_flBreakAfterTimeStartTimeZ = 0x558
                m_flBreakAfterTimeThresholdX = 0x55C
                m_flBreakAfterTimeThresholdY = 0x560
                m_flBreakAfterTimeThresholdZ = 0x564
                m_bPlaceAnchorsAtConstraintTransform = 0x510
            class CHostageRescueZone:
                pass
            class CIncendiaryGrenade:
                pass
            class CInfoVisibilityBox:
                m_nMode = 0x4AC
                m_bEnabled = 0x4BC
                m_vBoxSize = 0x4B0
            class CLogicLineToEntity:
                m_Line = 0x4A8
                m_EndEntity = 0x4DC
                m_SourceName = 0x4D0
                m_StartEntity = 0x4D8
            class CMolotovProjectile:
                m_bDetonated = 0xB58
                m_stillTimer = 0xB60
                m_bIsIncGrenade = 0xB40
            class CPointEntityFinder:
                m_hEntity = 0x4A8
                m_hFilter = 0x4B8
                m_iRefName = 0x4C0
                m_FindMethod = 0x4CC
                m_hReference = 0x4C8
                m_iFilterName = 0x4B0
                m_OnFoundEntity = 0x4D0
            class CPropDataComponent:
                m_flDmgModClub = 0x14
                m_flDmgModFire = 0x1C
                m_nInteractions = 0x30
                m_flDmgModBullet = 0x10
                m_iszBasePropData = 0x28
                m_flDmgModExplosive = 0x18
                m_bSpawnMotionDisabled = 0x34
                m_nMotionDisabledSpawnFlag = 0x3C
                m_iszPhysicsDamageTableName = 0x20
                m_nDisableTakePhysicsDamageSpawnFlag = 0x38
            class CPulseCell_Unknown:
                m_UnknownKeys = 0x48
            class CPulseServerCursor:
                m_hCaller = 0xEC
                m_hActivator = 0xE8
            class CPulse_ResumePoint:
                pass
            class CRagdollConstraint:
                m_xmax = 0x50C
                m_xmin = 0x508
                m_ymax = 0x514
                m_ymin = 0x510
                m_zmax = 0x51C
                m_zmin = 0x518
                m_xfriction = 0x520
                m_yfriction = 0x524
                m_zfriction = 0x528
            class CRelativeTransform:
                m_hEntity = 0x50
                m_transform = 0x10
                m_transformWS = 0x30
                m_bTransformIsWorldSpace = 0x0
            class CScriptTriggerHurt:
                m_vExtent = 0xA50
            class CScriptTriggerOnce:
                m_vExtent = 0x9E0
            class CScriptTriggerPush:
                m_vExtent = 0xA00
            class CShatterGlassShard:
                m_flArea = 0x6C
                m_hModel = 0x30
                m_hParentPanel = 0x3C
                m_hParentShard = 0x40
                m_hShardHandle = 0x8
                m_nOnFrameEdge = 0x70
                m_vecNeighbors = 0xA0
                m_bCreatedModel = 0x54
                m_flLongestEdge = 0x58
                m_flShortestEdge = 0x5C
                m_hPhysicsEntity = 0x38
                m_flLongestAcross = 0x60
                m_flSumOfAllEdges = 0x68
                m_flShortestAcross = 0x64
                m_hEntityHittingMe = 0x9C
                m_vecPanelVertices = 0x10
                m_ShatterStressType = 0x44
                m_vecStressVelocity = 0x48
                m_bFlaggedForRemoval = 0x96
                m_nSubShardGeneration = 0x74
                m_vLocalPanelSpaceOrigin = 0x28
                m_vecAverageVertPosition = 0x78
                m_bStressPositionAIsValid = 0x94
                m_bStressPositionBIsValid = 0x95
                m_bAverageVertPositionIsValid = 0x80
                m_flPhysicsEntitySpawnedAtTime = 0x98
                m_vecPanelSpaceStressPositionA = 0x84
                m_vecPanelSpaceStressPositionB = 0x8C
            class CTriggerLerpObject:
                m_OnDetached = 0xA50
                m_hLerpTarget = 0x9D0
                m_iszLerpSound = 0xA10
                m_OnLerpStarted = 0xA20
                m_iszLerpEffect = 0xA08
                m_iszLerpTarget = 0x9C8
                m_OnLerpFinished = 0xA38
                m_flLerpDuration = 0x9E4
                m_bSingleLerpObject = 0x9EA
                m_vecLerpingObjects = 0x9F0
                m_bLerpRestoreMoveType = 0x9E9
                m_bAttachTouchingObject = 0xA18
                m_hLerpTargetAttachment = 0x9E0
                m_iszLerpTargetAttachment = 0x9D8
                m_bAttachedEntityWasParented = 0x9E8
                m_hEntityToWaitForDisconnect = 0xA1C
            class CTriggerSoundscape:
                m_spectators = 0x9D8
                m_hSoundscape = 0x9C8
                m_SoundscapeName = 0x9D0
            class CWeaponUSPSilencer:
                pass
            class DecalGroupOption_t:
                m_hMaterial = 0x0
                m_flProbability = 0x10
                m_sSequenceName = 0x8
                m_flMaxAngleBetweenNormalAndGravity = 0x1C
                m_flMinAngleBetweenNormalAndGravity = 0x18
                m_bEnableAngleBetweenNormalAndGravityRange = 0x14
            class DynamicVolumeDef_t:
                m_source = 0x0
                m_target = 0x4
                m_nAreaDst = 0x28
                m_nAreaSrc = 0x24
                m_nHullIdx = 0x8
                m_bAttached = 0x2C
                m_vSourceAnchorPos = 0xC
                m_vTargetAnchorPos = 0x18
            class GameAmmoTypeInfo_t:
                m_nCost = 0x3C
                m_nBuySize = 0x38
            class HUDPanelHasClass_t:
                m_eClassStatus = 0x4
                m_nPanelIdIndex = 0x0
                m_nClassNameIndex = 0x2
            class IEconItemInterface:
                pass
            class PhysObjectHeader_t:
                bbox = 0x20
                _type = 0x0
                sphere = 0x38
                hEntity = 0x4
                iCollide = 0x3C
                fieldName = 0x8
                modelName = 0x18
                bSaveObject = 0x10
            class QueuedAISearchId_t:
                m_Value = 0x0
            class dynpitchvol_base_t:
                vol = 0x4C
                pitch = 0x3C
                fadein = 0x1C
                preset = 0x0
                spinup = 0xC
                volrun = 0x14
                cspinup = 0x34
                fadeout = 0x20
                lfofrac = 0x5C
                lfomult = 0x60
                lforate = 0x28
                lfotype = 0x24
                volfrac = 0x58
                pitchrun = 0x4
                spindown = 0x10
                volstart = 0x18
                fadeinsav = 0x50
                lfomodvol = 0x30
                pitchfrac = 0x48
                spinupsav = 0x40
                cspincount = 0x38
                fadeoutsav = 0x54
                pitchstart = 0x8
                lfomodpitch = 0x2C
                spindownsav = 0x44
            class shard_model_desc_t:
                m_solid = 0x20
                m_nModelID = 0x8
                m_bHasParent = 0x74
                m_vecPanelSize = 0x24
                m_bParentFrozen = 0x75
                m_hMaterialBase = 0x10
                m_vecPanelVertices = 0x40
                m_vecStressPositionA = 0x2C
                m_vecStressPositionB = 0x34
                m_flGlassHalfThickness = 0x70
                m_vInitialPanelVertices = 0x58
                m_SurfacePropStringToken = 0x78
                m_hMaterialDamageOverlay = 0x18
            class ActiveModelConfig_t:
                m_Name = 0x38
                m_Handle = 0x30
                m_AssociatedEntities = 0x40
                m_AssociatedEntityNames = 0x58
                m_vecAssociatedEntityCollidesWithHierarchy = 0x70
                m_vecAssociatedEntityCollidesOutsideHierarchy = 0x80
            class CAI_ChangeHintGroup:
                m_flRadius = 0x4C0
                m_iSearchType = 0x4A8
                m_strSearchName = 0x4B0
                m_strNewHintGroup = 0x4B8
            class CAttributeContainer:
                m_Item = 0x50
            class CBaseClientUIEntity:
                m_PanelID = 0x868
                m_bEnabled = 0x850
                m_CustomOutput0 = 0x870
                m_CustomOutput1 = 0x890
                m_CustomOutput2 = 0x8B0
                m_CustomOutput3 = 0x8D0
                m_CustomOutput4 = 0x8F0
                m_CustomOutput5 = 0x910
                m_CustomOutput6 = 0x930
                m_CustomOutput7 = 0x950
                m_CustomOutput8 = 0x970
                m_CustomOutput9 = 0x990
                m_DialogXMLName = 0x858
                m_PanelClassName = 0x860
            class CBodyComponentPoint:
                m_sceneNode = 0x80
            class CCSPlayerController:
                m_iMVPs = 0x940
                m_iPing = 0x808
                m_iScore = 0x91C
                m_szClan = 0x840
                m_bShowHints = 0x968
                m_eMvpReason = 0x934
                m_iPawnArmor = 0x904
                m_iRoundsWon = 0x924
                m_nFirstKill = 0x930
                m_nKillCount = 0x931
                m_bMvpNoMusic = 0x932
                m_hPlayerPawn = 0x8EC
                m_iDraftIndex = 0x8B8
                m_iMusicKitID = 0x938
                m_iPawnHealth = 0x900
                m_iRoundScore = 0x920
                m_bPawnIsAlive = 0x8FC
                m_bTeamChanged = 0x834
                m_bInSwitchTeam = 0x835
                m_hObserverPawn = 0x8F0
                m_iCoachingTeam = 0x84C
                m_iMusicKitMVPs = 0x93C
                m_unClanId32bit = 0x848
                m_bPawnHasHelmet = 0x909
                m_bScoreReported = 0x8CD
                m_flSmoothedPing = 0x948
                m_iNextTimeCheck = 0x96C
                m_nUpdateCounter = 0x944
                m_bCannotBeKicked = 0x8C8
                m_bControllingBot = 0x8E0
                m_bPawnHasDefuser = 0x908
                m_flForceTeamTime = 0x824
                m_iPendingTeamNum = 0x820
                m_pDamageServices = 0x800
                m_recentKillQueue = 0x928
                m_unActiveQuestId = 0x87C
                m_bHasSeenJoinGame = 0x836
                m_bJustDidTeamKill = 0x970
                m_iCompetitiveWins = 0x864
                m_iPawnLifetimeEnd = 0x910
                m_nPlayerDominated = 0x850
                m_szCrosshairCodes = 0x818
                m_bEverPlayedOnTeam = 0x82C
                m_lastHeldVoteTimer = 0x950
                m_bPunishForTeamKill = 0x971
                m_flLastJoinTeamTime = 0x83C
                m_iCompTeammateColor = 0x828
                m_iPawnBotDifficulty = 0x914
                m_iPawnLifetimeStart = 0x90C
                m_nDisconnectionTick = 0x8D0
                m_pInventoryServices = 0x7F0
                m_DesiredObserverMode = 0x8F4
                m_bEverFullyConnected = 0x8C9
                m_iCompetitiveRanking = 0x860
                m_nPlayerDominatingMe = 0x858
                m_nSuspiciousHitCount = 0x988
                m_bAttemptedToGetColor = 0x82D
                m_bJustBecameSpectator = 0x837
                m_iCompetitiveRankType = 0x868
                m_nEndMatchNextMapVote = 0x878
                m_nQuestProgressReason = 0x884
                m_pInGameMoneyServices = 0x7E8
                m_rtActiveMissionPeriod = 0x880
                m_bCanControlObservedBot = 0x8E8
                m_bGaveTeamDamageWarning = 0x972
                m_hDesiredObserverTarget = 0x8F8
                m_nPawnCharacterDefIndex = 0x90A
                m_unPlayerTvControlFlags = 0x888
                m_bAbandonAllowsSurrender = 0x8CA
                m_iTeammatePreferredColor = 0x830
                m_nNonSuspiciousHitStreak = 0x98C
                m_pActionTrackingServices = 0x7F8
                m_uiAbandonRecordedReason = 0x8C0
                m_nBotsControlledThisRound = 0x8E4
                m_uiCommunicationMuteFlags = 0x810
                m_LastTeamDamageWarningTime = 0x980
                m_bHasCommunicationAbuseMute = 0x80C
                m_bHasControlledBotThisRound = 0x8E1
                m_eNetworkDisconnectionReason = 0x8C4
                m_bFireBulletsSeedSynchronized = 0xA39
                m_bSwitchTeamsOnNextRoundReset = 0x838
                m_bAbandonOffersInstantSurrender = 0x8CB
                m_bGaveTeamDamageWarningThisRound = 0x973
                m_bRemoveAllItemsOnNextRoundReset = 0x839
                m_bDisconnection1MinWarningPrinted = 0x8CC
                m_hOriginalControllerOfCurrentPawn = 0x918
                m_iCompetitiveRankingPredicted_Tie = 0x874
                m_iCompetitiveRankingPredicted_Win = 0x86C
                m_iCompetitiveRankingPredicted_Loss = 0x870
                m_dblLastReceivedPacketPlatFloatTime = 0x978
                m_msQueuedModeDisconnectionTimestamp = 0x8BC
                m_bHasBeenControlledByPlayerThisRound = 0x8E2
                m_LastTimePlayerWasDisconnectedForPawnsRemove = 0x984
            class CCSPlayerLegacyJump:
                m_bOldJumpPressed = 0x10
                m_flJumpPressedTime = 0x14
            class CCSPlayerModernJump:
                m_nLastLandedTick = 0x20
                m_flLastLandedFrac = 0x24
                m_flLastLandedVelocityX = 0x28
                m_flLastLandedVelocityY = 0x2C
                m_flLastLandedVelocityZ = 0x30
                m_nLastActualJumpPressTick = 0x10
                m_nLastUsableJumpPressTick = 0x18
                m_flLastActualJumpPressFrac = 0x14
                m_flLastUsableJumpPressFrac = 0x1C
            class CEnvSoundscapeProxy:
                m_MainSoundscapeName = 0x538
            class CFilterAttributeInt:
                m_sAttributeName = 0x4E0
            class CFloatMovingAverage:
                pass
            class CFuncNavObstruction:
                m_bDisabled = 0x868
                m_bUseAsyncObstacleUpdate = 0x869
            class CGameChoreoServices:
                m_hOwner = 0x8
                m_choreoState = 0x14
                m_scriptState = 0x10
                m_hScriptedSequence = 0xC
                m_flTimeStartedState = 0x18
            class CInfoGameEventProxy:
                m_flRange = 0x4B0
                m_iszEventName = 0x4A8
            class CInfoLadderDismount:
                pass
            class CInfoParticleTarget:
                pass
            class CLogicActivityEvent:
                m_hSource = 0x4B8
                m_flDuration = 0x4AC
                m_nEventType = 0x4A8
                m_iszSourceEntityName = 0x4B0
            class CLogicCollisionPair:
                m_disabled = 0x4BA
                m_succeeded = 0x4BB
                m_nameAttach1 = 0x4A8
                m_nameAttach2 = 0x4B0
                m_allowMissing = 0x4BC
                m_includeHierarchy = 0x4B8
                m_supportMultipleEntitiesWithSameName = 0x4B9
            class CLogicDistanceCheck:
                m_InZone1 = 0x4C0
                m_InZone2 = 0x4D8
                m_InZone3 = 0x4F0
                m_iszEntityA = 0x4A8
                m_iszEntityB = 0x4B0
                m_flZone1Distance = 0x4B8
                m_flZone2Distance = 0x4BC
            class CLogicEventListener:
                m_nTeam = 0x4C4
                m_bIsEnabled = 0x4C0
                m_OnEventFired = 0x4C8
                m_strEventName = 0x4B8
            class CLogicNPCCounterOBB:
                pass
            class CMarkupSearchHelper:
                m_bActive = 0x26
                m_navHull = 0x0
                m_vRefPos = 0x18
                m_tagString = 0x8
                m_bRefPosSet = 0x24
                m_nameString = 0x10
                m_bUseStepHeight = 0x25
            class CMarkupVolumeTagged:
                m_Tags = 0x870
                m_bIsGroup = 0x888
                m_GroupNames = 0x858
                m_bIsInGroup = 0x88C
                m_bGroupByPrefab = 0x889
                m_bGroupByVolume = 0x88A
                m_bGroupOtherGroups = 0x88B
            class CMomentaryRotButton:
                m_end = 0xA60
                m_start = 0xA54
                m_sNoise = 0xA70
                m_IdealYaw = 0xA6C
                m_Position = 0x9D0
                m_lastUsed = 0xA50
                m_direction = 0xA7C
                m_OnFullyOpen = 0xA08
                m_OnUnpressed = 0x9F0
                m_returnSpeed = 0xA80
                m_OnFullyClosed = 0xA20
                m_bUpdateTarget = 0xA78
                m_flStartPosition = 0xA84
                m_OnReachedPosition = 0xA38
            class CNavHullPresetVData:
                m_vecNavHulls = 0x0
            class CPathQueryComponent:
                pass
            class CPlayer_UseServices:
                pass
            class CPointChildModifier:
                m_bOrphanInsteadOfDeletingChildrenOnRemove = 0x4A8
            class CPointClientCommand:
                pass
            class CPointServerCommand:
                pass
            class CPointValueRemapper:
                m_OnEngage = 0x620
                m_Position = 0x598
                m_bEngaged = 0x538
                m_bDisabled = 0x4A8
                m_nInputType = 0x4AC
                m_OnDisengage = 0x638
                m_flSnapValue = 0x524
                m_nOutputType = 0x4D8
                m_bFirstUpdate = 0x539
                m_hUsingPlayer = 0x550
                m_nHapticsType = 0x518
                m_nRatchetType = 0x52C
                m_PositionDelta = 0x5B8
                m_flInputOffset = 0x534
                m_hRemapLineEnd = 0x4C4
                m_nMomentumType = 0x51C
                m_iszSoundEngage = 0x558
                m_bRequiresUseKey = 0x4D4
                m_bUpdateOnClient = 0x4A9
                m_flPreviousValue = 0x53C
                m_flRatchetOffset = 0x530
                m_hOutputEntities = 0x500
                m_hRemapLineStart = 0x4C0
                m_flEngageDistance = 0x4D0
                m_OnReachedValueOne = 0x5F0
                m_flCurrentMomentum = 0x528
                m_iszSoundDisengage = 0x560
                m_OnReachedValueZero = 0x5D8
                m_flMomentumModifier = 0x520
                m_iszSoundMovingLoop = 0x578
                m_flCustomOutputValue = 0x554
                m_flDisengageDistance = 0x4CC
                m_iszOutputEntityName = 0x4E0
                m_iszRemapLineEndName = 0x4B8
                m_OnReachedValueCustom = 0x608
                m_iszOutputEntity2Name = 0x4E8
                m_iszOutputEntity3Name = 0x4F0
                m_iszOutputEntity4Name = 0x4F8
                m_vecPreviousTestPoint = 0x544
                m_iszRemapLineStartName = 0x4B0
                m_iszSoundReachedValueOne = 0x570
                m_flMaximumChangePerSecond = 0x4C8
                m_flPreviousUpdateTickTime = 0x540
                m_iszSoundReachedValueZero = 0x568
            class CPrecipitationVData:
                m_nRTEnvCP = 0x2D4
                m_szModifier = 0x2E0
                m_nAttachType = 0x2CC
                m_snapshotFilter = 0x2EC
                m_flInnerDistance = 0x2C8
                m_nRTEnvCPComponent = 0x2D8
                m_bBatchSameVolumeType = 0x2D0
                m_nUseSnapshotFromSurfaceGraph = 0x2E8
                m_szParticlePrecipitationEffect = 0x28
                m_szParticlePrecipitationPostEffect = 0x1E8
                m_szParticlePrecipitationPuddleEffect = 0x108
            class CPulseCell_BaseFlow:
                pass
            class CPulseCell_BaseLerp:
                m_WakeResume = 0xD8
            class CPulseCell_Timeline:
                m_OnFinished = 0xF8
                m_TimelineEvents = 0xD8
                m_bWaitForChildOutflows = 0xF0
            class CTonemapController2:
                m_flAutoExposureMax = 0x4AC
                m_flAutoExposureMin = 0x4A8
                m_flTonemapEVSmoothingRange = 0x4B8
                m_flExposureAdaptationSpeedUp = 0x4B0
                m_flExposureAdaptationSpeedDown = 0x4B4
            class CTriggerSndSosOpvar:
                m_bVolIs2D = 0xA10
                m_flMaxVal = 0x9F4
                m_flMinVal = 0x9F0
                m_opvarName = 0x9F8
                m_stackName = 0xA00
                m_VecNormPos = 0xD14
                m_flPosition = 0x9E0
                m_flCenterSize = 0x9EC
                m_operatorName = 0xA08
                m_opvarNameChar = 0xA11
                m_stackNameChar = 0xB11
                m_flNormCenterSize = 0xD20
                m_hTouchingPlayers = 0x9C8
                m_operatorNameChar = 0xC11
            class CWeaponM4A1Silencer:
                pass
            class ConstraintSoundInfo:
                m_vSampler = 0x8
                m_forwardAxis = 0x40
                m_soundProfile = 0x20
                m_bPlayTravelSound = 0x90
                m_iszTravelSoundFwd = 0x50
                m_bPlayReversalSound = 0x91
                m_iszTravelSoundBack = 0x58
                m_iszReversalSoundLarge = 0x88
                m_iszReversalSoundSmall = 0x78
                m_iszReversalSoundMedium = 0x80
            class ModelConfigHandle_t:
                m_Value = 0x0
            class magnetted_objects_t:
                hEntity = 0x8
            class sndopvarlatchdata_t:
                m_vPos = 0x24
                m_flVal = 0x20
                m_iszOpvar = 0x18
                m_iszStack = 0x8
                m_iszOperator = 0x10
            class CBaseCombatCharacter:
                m_eHull = 0xAC8
                m_nNavHullIdx = 0xACC
                m_hMyWearables = 0xA48
                m_movementStats = 0xAD0
                m_strRelationships = 0xAC0
                m_vecRelationships = 0xAA8
                m_impactEnergyScale = 0xA60
                m_bApplyStressDamage = 0xA64
                m_bForceServerRagdoll = 0xA40
                m_bDeathEventsDispatched = 0xA65
            class CCSObservableElement:
                m_nTeamFilter = 0x4D0
                m_hObservableModelEntity = 0x4C8
                m_hObservableModelEntity2 = 0x4CC
                m_iszObservableModelEntity = 0x4C0
            class CCSPointScriptEntity:
                pass
            class CCSWeaponBaseShotgun:
                pass
            class CCopyRecipientFilter:
                m_Flags = 0x8
                m_Recipients = 0x10
                m_slotPlayerExcludedDueToPrediction = 0x30
            class CDebugSnapshotData_t:
                m_text = 0x0
                m_hEntity = 0x100
                m_children = 0x120
                m_dataType = 0x8
                m_userData = 0x10
                m_drawColor = 0xD8
                m_userFlags = 0xC
                m_userShape = 0x40
                m_userVector = 0x14
                m_sEntityName = 0x108
                m_nEntityIndex = 0x110
                m_userTransform = 0x20
                m_pStructuredData = 0xF8
                m_vecDebugOverlayData = 0xE0
            class CEnvDetailController:
                m_flFadeEndDist = 0x4AC
                m_flFadeStartDist = 0x4A8
            class CEnvInstructorVRHint:
                m_iszName = 0x4A8
                m_iTimeout = 0x4B8
                m_iszCaption = 0x4C0
                m_iAttachType = 0x4E0
                m_iszStartSound = 0x4C8
                m_flHeightOffset = 0x4E4
                m_iLayoutFileType = 0x4D0
                m_iszCustomLayoutFile = 0x4D8
                m_iszHintTargetEntity = 0x4B0
            class CEnvLightProbeVolume:
                m_Entity_bEnabled = 0x5C1
                m_Entity_vBoxMaxs = 0x584
                m_Entity_vBoxMins = 0x578
                m_Entity_bMoveable = 0x590
                m_Entity_nPriority = 0x598
                m_Entity_nHandshake = 0x594
                m_Entity_bStartDisabled = 0x59C
                m_Entity_nLightProbeSizeX = 0x5A0
                m_Entity_nLightProbeSizeY = 0x5A4
                m_Entity_nLightProbeSizeZ = 0x5A8
                m_Entity_nLightProbeAtlasX = 0x5AC
                m_Entity_nLightProbeAtlasY = 0x5B0
                m_Entity_nLightProbeAtlasZ = 0x5B4
                m_Entity_hLightProbeTexture_SDF = 0x548
                m_Entity_hLightProbeTexture_SH2_DC = 0x550
                m_Entity_hLightProbeTexture_SH2_L1 = 0x558
                m_Entity_hLightProbeTexture_AmbientCube = 0x540
                m_Entity_hLightProbeDirectLightIndicesTexture = 0x560
                m_Entity_hLightProbeDirectLightScalarsTexture = 0x568
                m_Entity_hLightProbeDirectLightShadowsTexture = 0x570
            class CFlashbangProjectile:
                m_numOpponentsHit = 0xB44
                m_numTeammatesHit = 0xB45
                m_flTimeToDetonate = 0xB40
            class CFootstepTableHandle:
                pass
            class CFuncPropRespawnZone:
                pass
            class CGameSceneNodeHandle:
                m_name = 0xC
                m_hOwner = 0x8
            class CHEGrenadeProjectile:
                pass
            class CInfoDeathmatchSpawn:
                pass
            class CInfoPlayerTerrorist:
                pass
            class CIronSightController:
                m_flIronSightAmount = 0xC
                m_bIronSightAvailable = 0x8
                m_flIronSightAmountBiased = 0x14
                m_flIronSightAmountGained = 0x10
            class CLogicActiveAutosave:
                m_flStartTime = 0x4C0
                m_flDangerousTime = 0x4C4
                m_flTimeToTrigger = 0x4BC
                m_TriggerHitPoints = 0x4B8
            class CLogicNPCCounterAABB:
                m_vOuterMaxs = 0x74C
                m_vOuterMins = 0x740
                m_vDistanceOuterMaxs = 0x734
                m_vDistanceOuterMins = 0x728
            class CMarkupVolumeWithRef:
                m_bUseRef = 0x898
                m_flRefDot = 0x8B4
                m_vRefPosWorldSpace = 0x8A8
                m_vRefPosEntitySpace = 0x89C
            class CNMEventPulseState_t:
                m_eventID = 0x0
            class CNavPathCostForTests:
                pass
            class CPhysSlideConstraint:
                m_axisEnd = 0x510
                m_soundInfo = 0x538
                m_initialOffset = 0x524
                m_slideFriction = 0x51C
                m_bUseEntityPivot = 0x534
                m_systemLoadScale = 0x520
                m_flMotorFrequency = 0x52C
                m_flMotorDampingRatio = 0x530
                m_bEnableLinearConstraint = 0x528
                m_bEnableAngularConstraint = 0x529
            class CPhysWheelConstraint:
                m_flMaxSteeringAngle = 0x528
                m_flMinSteeringAngle = 0x524
                m_flSpinAxisFriction = 0x530
                m_bEnableSteeringLimit = 0x520
                m_flMaxSuspensionOffset = 0x51C
                m_flMinSuspensionOffset = 0x518
                m_flSuspensionFrequency = 0x508
                m_hSteeringMimicsEntity = 0x534
                m_bEnableSuspensionLimit = 0x514
                m_flSteeringAxisFriction = 0x52C
                m_flSuspensionDampingRatio = 0x50C
                m_flSuspensionHeightOffset = 0x510
            class CPhysicsEntitySolver:
                m_cancelTime = 0x4CC
                m_hMovingEntity = 0x4C0
                m_hPhysicsBlocker = 0x4C4
                m_separationDuration = 0x4C8
            class CPhysicsPropOverride:
                pass
            class CPlayerPawnComponent:
                __m_pChainEntity = 0x8
                m_pComponentGraphController = 0x30
            class CPlayer_ItemServices:
                pass
            class CPointClientUIDialog:
                m_hActivator = 0x9B0
                m_bStartEnabled = 0x9B4
            class CPointCommentaryNode:
                m_bActive = 0xAE8
                m_iszTitle = 0xAF8
                m_bDisabled = 0xAA5
                m_bListenedTo = 0xB10
                m_flStartTime = 0xAEC
                m_hViewTarget = 0xA60
                m_iNodeNumber = 0xB08
                m_iszSpeakers = 0xB00
                m_bUnstoppable = 0xA7A
                m_hViewPosition = 0xA70
                m_iszViewTarget = 0xA58
                m_flFinishedTime = 0xA7C
                m_iNodeNumberMax = 0xB0C
                m_iszPreCommands = 0xA40
                m_bUnderCrosshair = 0xA79
                m_iszPostCommands = 0xA48
                m_iszViewPosition = 0xA68
                m_vecFinishAngles = 0xA98
                m_vecFinishOrigin = 0xA80
                m_bPreventMovement = 0xA78
                m_hViewTargetAngles = 0xA64
                m_iszCommentaryFile = 0xA50
                m_vecOriginalAngles = 0xA8C
                m_vecTeleportOrigin = 0xAA8
                m_hViewPositionMover = 0xA74
                m_flAbortedPlaybackAt = 0xAB4
                m_pOnCommentaryStarted = 0xAB8
                m_pOnCommentaryStopped = 0xAD0
                m_flStartTimeInCommentary = 0xAF0
                m_bPreventChangesWhileMoving = 0xAA4
            class CPointVelocitySensor:
                m_vecAxis = 0x4AC
                m_Velocity = 0x4C8
                m_bEnabled = 0x4B8
                m_fPrevVelocity = 0x4BC
                m_flAvgInterval = 0x4C0
                m_hTargetEntity = 0x4A8
            class CPulseCell_BaseState:
                pass
            class CPulseCell_BaseValue:
                pass
            class CPulseGameBlackboard:
                m_strGraphName = 0x4B0
                m_strStateBlob = 0x4B8
            class CPulse_InvokeBinding:
                m_FuncName = 0x30
                m_nSrcChunk = 0x44
                m_nCellIndex = 0x40
                m_RegisterMap = 0x0
                m_nSrcInstruction = 0x48
            class CRagdollPropAttached:
                m_bShouldDetach = 0xC20
                m_boneIndexAttached = 0xC00
                m_attachmentPointBoneSpace = 0xC08
                m_ragdollAttachedObjectIndex = 0xC04
                m_attachmentPointRagdollSpace = 0xC14
                m_bShouldDeleteAttachedActivationRecord = 0xC30
            class CResponseCriteriaSet:
                m_bOverrideOnAppend = 0x30
            class CSoundAreaEntityBase:
                m_vPos = 0x4B8
                m_bDisabled = 0x4A8
                m_iszSoundAreaType = 0x4B0
            class CSoundEventBoxEntity:
                m_iszBoxEntities = 0x5A0
                m_vecBoxHelpersNetworked = 0x638
            class CSoundEventBoxHelper:
                m_vMaxs = 0x4B4
                m_vMins = 0x4A8
            class CSoundEventOBBEntity:
                m_vMaxs = 0x574
                m_vMins = 0x568
            class CSoundEventParameter:
                m_flFloatValue = 0x4C8
                m_iszParamName = 0x4C0
            class CSoundOpvarSetEntity:
                m_nOpvarType = 0x4D8
                m_bSetOnSpawn = 0x4F0
                m_nOpvarIndex = 0x4DC
                m_flOpvarValue = 0x4E0
                m_iszOpvarName = 0x4D0
                m_iszStackName = 0x4C0
                m_iszOperatorName = 0x4C8
                m_OpvarValueString = 0x4E8
            class CTriggerHostageReset:
                pass
            class CVectorMovingAverage:
                pass
            class EngineCountdownTimer:
                m_duration = 0x8
                m_timescale = 0x10
                m_timestamp = 0xC
            class EntitySpottedState_t:
                m_bSpotted = 0x8
                m_bSpottedByMask = 0xC
            class PathMoverEntitySpawn:
                hMover = 0x0
                nSpawnNumber = 0x20
                vecOtherEntities = 0x8
            class PhysicsRagdollPose_t:
                m_hOwner = 0x20
                m_RelativeTransforms = 0x8
                m_bSetFromDebugHistory = 0x24
            class CBasePlayerController:
                m_hPawn = 0x4E0
                m_bIsHLTV = 0x510
                m_steamID = 0x710
                m_bPredict = 0x5AD
                m_fLerpTime = 0x5A8
                m_nTickBase = 0x4B8
                m_iConnected = 0x514
                m_bGamePaused = 0x5B5
                m_hSplitOwner = 0x4F0
                m_iDesiredFOV = 0x71C
                m_iszPlayerName = 0x51C
                m_bIsLowViolence = 0x5B4
                m_bNoClipEnabled = 0x718
                m_iMostConnected = 0x518
                m_bLagCompensation = 0x5AC
                m_nSplitScreenSlot = 0x4EC
                m_iIgnoreGlobalChat = 0x6F0
                m_szNetworkIDString = 0x5A0
                m_bKnownTeamMismatch = 0x4E4
                m_hSplitScreenPlayers = 0x4F8
                m_flLastPlayerTalkTime = 0x6F4
                m_bHasAnySteadyStateEnts = 0x700
                m_flLastEntitySteadyState = 0x6F8
                m_nInButtonsWhichAreToggles = 0x4B0
                m_nAvailableEntitySteadyState = 0x6FC
            class CBreakableStageHelper:
                m_nStageCount = 0xC
                m_nCurrentStage = 0x8
            class CCSCustomPlayerCamera:
                m_hPawn = 0x4A8
                m_bFollowEyes = 0x4B4
                m_nCameraMode = 0x4AC
                m_hFollowEntity = 0x4B0
                m_vecCameraOffset = 0x4C4
                m_vecFollowOffset = 0x4B8
                m_bClipCameraOffset = 0x4D0
                m_flCameraOffsetReturnStrength = 0x4D4
            class CCSGameModeRules_Noop:
                pass
            class CCSPlayer_BuyServices:
                m_vecSellbackPurchaseEntries = 0xD0
            class CCSPlayer_UseServices:
                m_flLastUseTimeStamp = 0x4C
                m_hLastKnownUseEntity = 0x48
                m_flTimeLastUsedWindow = 0x50
            class CDebugDrawHistoryData:
                m_bools = 0x58
                m_etype = 0x4
                m_times = 0x38
                m_colors = 0x18
                m_hEntity = 0x0
                m_strings = 0x68
                m_uint64s = 0x48
                m_vectors = 0x8
                m_dimensions = 0x28
            class CEmptyGraphController:
                pass
            class CGameScriptedMoveData:
                m_vSrc = 0x18
                m_vDest = 0x58
                m_angDst = 0x64
                m_angSrc = 0x24
                m_bActive = 0x4C
                m_bSuccess = 0x4F
                m_flAngRate = 0x40
                m_angCurrent = 0x30
                m_flDuration = 0x44
                m_flStartTime = 0x48
                m_hDestEntity = 0x70
                m_flLockedSpeed = 0x3C
                m_bTeleportOnEnd = 0x4D
                m_bIgnoreRotation = 0x4E
                m_bIgnoreCollisions = 0x54
                m_nForcedCrouchState = 0x50
                m_vAccumulatedRootMotion = 0x0
                m_angAccumulatedRootMotionRotation = 0xC
            class CHostageCarriableProp:
                pass
            class CHostageExpresserShim:
                m_pExpresser = 0xB10
            class CInfoTargetServerOnly:
                pass
            class CInstancedSceneEntity:
                m_hOwner = 0x800
                m_hTarget = 0x814
                m_bHadOwner = 0x804
                m_flPreDelay = 0x80C
                m_bIsBackground = 0x810
                m_flPostSpeakDelay = 0x808
            class CLogicGameStateReport:
                m_bDisabled = 0x4A8
            class CLogicMeasureMovement:
                m_flScale = 0x4D0
                m_hTarget = 0x4C8
                m_nMeasureType = 0x4D4
                m_hMeasureTarget = 0x4C0
                m_hTargetReference = 0x4CC
                m_strMeasureTarget = 0x4A8
                m_hMeasureReference = 0x4C4
                m_strTargetReference = 0x4B8
                m_strMeasureReference = 0x4B0
            class CLogicPlayerProxyBase:
                m_hPlayer = 0x510
                m_PlayerDied = 0x4D8
                m_PlayerHasAmmo = 0x4A8
                m_PlayerHasNoAmmo = 0x4C0
                m_RequestedPlayerHealth = 0x4F0
            class CMapSharedEnvironment:
                m_targetMapName = 0x4A8
            class CNmEventConsumerCloth:
                pass
            class CNmEventConsumerPulse:
                pass
            class CNmEventConsumerSound:
                pass
            class CPathWithDynamicNodes:
                m_vecPathNodes = 0x5B0
                m_eDesiredDirection = 0x5F0
                m_bIgnoreParentRotation = 0x5F4
                m_xInitialPathWorldToLocal = 0x5D0
            class CPlayer_WaterServices:
                pass
            class CPointProximitySensor:
                m_Distance = 0x4B0
                m_bDisabled = 0x4A8
                m_hTargetEntity = 0x4AC
            class CPostProcessingVolume:
                m_bMaster = 0xA04
                m_flMaxExposure = 0x9F0
                m_flMinExposure = 0x9EC
                m_hPostSettings = 0x9D8
                m_flFadeDuration = 0x9E0
                m_bExposureControl = 0xA05
                m_flMaxLogExposure = 0x9E8
                m_flMinLogExposure = 0x9E4
                m_flExposureFadeSpeedUp = 0x9F8
                m_flExposureCompensation = 0x9F4
                m_flExposureFadeSpeedDown = 0x9FC
                m_flTonemapEVSmoothingRange = 0xA00
            class CPrecipitationBlocker:
                pass
            class CPulseCell_LimitCount:
                m_nLimitCount = 0x48
            class CServerRagdollTrigger:
                pass
            class CSoundEventAABBEntity:
                m_vMaxs = 0x574
                m_vMins = 0x568
            class CSoundEventConeEntity:
                m_flAttenMax = 0x574
                m_flAttenMin = 0x570
                m_flEmitterAngle = 0x568
                m_flSweetSpotAngle = 0x56C
                m_iszParameterName = 0x578
            class CSpriteAlias_env_glow:
                pass
            class CTestPulseIOComponent:
                m_ComponentData = 0x8
                m_OnComponentTestFunc = 0x10
            class PointCameraSettings_t:
                m_flFarCrispDistance = 0x8
                m_flFarBlurryDistance = 0xC
                m_flNearCrispDistance = 0x4
                m_flNearBlurryDistance = 0x0
            class PrecipitationFilter_t:
                m_flMaxRadius = 0x0
            class WeaponPurchaseCount_t:
                m_nCount = 0x32
                m_nItemDefIndex = 0x30
            class WrappedPhysicsJoint_t:
                m_pJoint = 0x0
            class physics_save_sphere_t:
                radius = 0x0
            class AutoRoomDoorwayPairs_t:
                vP1 = 0x0
                vP2 = 0xC
            class CAnimGraph2InstancePtr:
                pass
            class CBasePlayerWeaponVData:
                m_iSlot = 0x4EC
                m_iFlags = 0x4C7
                m_iWeight = 0x4C8
                m_iMaxClip1 = 0x4D0
                m_iMaxClip2 = 0x4D4
                m_iPosition = 0x4F0
                m_flDropSpeed = 0x4E8
                m_aShootSounds = 0x4F8
                m_szWorldModel = 0x28
                m_bAutoSwitchTo = 0x4CC
                m_iDefaultClip1 = 0x4D8
                m_iDefaultClip2 = 0x4DC
                m_iRumbleEffect = 0x4E4
                m_bAllowFlipping = 0x2C9
                m_bAutoSwitchFrom = 0x4CD
                m_bKeepLoadedAmmo = 0x4E2
                m_bLinkedCooldowns = 0x4C6
                m_nPrimaryAmmoType = 0x4CE
                m_bBuiltRightHanded = 0x2C8
                m_sMuzzleAttachment = 0x2D0
                m_bTreatAsSingleClip = 0x4E1
                m_nSecondaryAmmoType = 0x4CF
                m_bReserveAmmoAsClips = 0x4E0
                m_bGenerateMuzzleLight = 0x4C4
                m_flMuzzleSmokeTimeout = 0x4BC
                m_bShouldAnimateInWorld = 0x4C5
                m_szBarrelSmokeParticle = 0x3D8
                m_szMuzzleFlashParticle = 0x2F0
                m_szWorldModelAg2Override = 0x108
                m_sToolsOnlyOwnerModelName = 0x1E8
                m_nMuzzleSmokeShotThreshold = 0x4B8
                m_flMuzzleSmokeDecrementRate = 0x4C0
                m_szMuzzleFlashParticleConfig = 0x3D0
            class CCSPlayer_ItemServices:
                m_bHasHelmet = 0x49
                m_bHasDefuser = 0x48
            class CCSPlayer_PingServices:
                m_hPlayerPing = 0x5C
                m_flPlayerPingTokens = 0x48
            class CColorCorrectionVolume:
                m_Weight = 0x9D0
                m_MaxWeight = 0x9C8
                m_FadeDuration = 0x9CC
                m_LastExitTime = 0xBE0
                m_LastEnterTime = 0xBD8
                m_LastExitWeight = 0xBDC
                m_lookupFilename = 0x9D4
                m_LastEnterWeight = 0xBD4
            class CExternalAnimGraphList:
                pass
            class CFuncElectrifiedVolume:
                m_EffectName = 0x870
                m_EffectZapName = 0x880
                m_iszEffectSource = 0x888
                m_EffectInterpenetrateName = 0x878
            class CGameScriptedMoveDef_t:
                m_angDest = 0x10
                m_flAngRate = 0x20
                m_flDuration = 0x1C
                m_flMoveSpeed = 0x24
                m_hDestEntity = 0xC
                m_vDestOffset = 0x0
                m_bAimDisabled = 0x28
                m_bIgnoreRotation = 0x29
                m_nForcedCrouchState = 0x2C
            class CHostageRescueZoneShim:
                pass
            class CInfoDynamicShadowHint:
                m_hLight = 0x4B8
                m_flRange = 0x4AC
                m_bDisabled = 0x4A8
                m_nImportance = 0x4B0
                m_nLightChoice = 0x4B4
            class CInstructorEventEntity:
                m_iszName = 0x4A8
                m_hTargetPlayer = 0x4B8
                m_iszHintTargetEntity = 0x4B0
            class CLogicDistanceAutosave:
                m_bCheckCough = 0x4B5
                m_bThinkDangerous = 0x4B6
                m_flDangerousTime = 0x4B8
                m_iszTargetEntity = 0x4A8
                m_bForceNewLevelUnit = 0x4B4
                m_flDistanceToPlayer = 0x4B0
            class CMapVetoPickController:
                m_nMapId0 = 0x6F8
                m_nMapId1 = 0x7F8
                m_nMapId2 = 0x8F8
                m_nMapId3 = 0x9F8
                m_nMapId4 = 0xAF8
                m_nMapId5 = 0xBF8
                m_nDraftType = 0x4D4
                m_OnMapPicked = 0xE28
                m_OnMapVetoed = 0xE08
                m_nAccountIDs = 0x5F8
                m_OnSidesPicked = 0xE48
                m_nCurrentPhase = 0xDF8
                m_nStartingSide0 = 0xCF8
                m_bPlayedIntroVcd = 0x4A8
                m_nPhaseStartTick = 0xDFC
                m_nVoteMapIdsList = 0x5DC
                m_OnLevelTransition = 0xE88
                m_OnNewPhaseStarted = 0xE68
                m_nPhaseDurationTicks = 0xE00
                m_nTeamWinningCoinToss = 0x4D8
                m_nTeamWithFirstChoice = 0x4DC
                m_bPreMatchDraftStateChanged = 0x4D0
                m_dblPreMatchDraftSequenceTime = 0x4C8
                m_bNeedToPlayFiveSecondsRemaining = 0x4A9
            class CMovementStatsProperty:
                m_nUseCounter = 0x10
                m_emaMovementDirection = 0x14
            class CMultiplayer_Expresser:
                m_bAllowMultipleScenes = 0xA0
            class CNavVolumeMarkupVolume:
                pass
            class CNetworkVelocityVector:
                m_vecX = 0x10
                m_vecY = 0x18
                m_vecZ = 0x20
            class CNmEventConsumerCamera:
                pass
            class CNmEventConsumerLegacy:
                pass
            class CPhysicsBodyGameMarkup:
                m_Tag = 0x8
                m_TargetBody = 0x0
            class CPlayer_CameraServices:
                m_audio = 0xB0
                m_PlayerFog = 0x60
                m_hViewEntity = 0xA4
                m_flOldPlayerZ = 0x140
                m_hTonemapController = 0xA8
                m_vecCsViewPunchAngle = 0x48
                m_hColorCorrectionCtrl = 0xA0
                m_PostProcessingVolumes = 0x128
                m_nCsViewPunchAngleTick = 0x54
                m_flOldPlayerViewOffsetZ = 0x144
                m_hTriggerSoundscapeList = 0x160
                m_flCsViewPunchAngleTickRatio = 0x58
            class CPlayer_WeaponServices:
                m_iAmmo = 0x68
                m_hMyWeapons = 0x48
                m_hLastWeapon = 0x64
                m_hActiveWeapon = 0x60
                m_bPreventWeaponPickup = 0xA8
            class CPointGamestatsCounter:
                m_bDisabled = 0x4B0
                m_strStatisticName = 0x4A8
            class CPulseCell_ApplyParent:
                pass
            class CPulseCell_CursorQueue:
                m_nCursorsAllowedToRunParallel = 0x128
            class CPulseCell_FireCursors:
                m_Outflows = 0xD8
                m_OnFinished = 0xF8
                m_bWaitForChildOutflows = 0xF0
            class CPulseCell_Inflow_Wait:
                m_WakeResume = 0xD8
            class CPulseCell_RaceCursors:
                m_Outflows = 0xD8
                m_OnFinished = 0xF0
            class CPulseCell_Value_Curve:
                m_Curve = 0x48
            class CScriptTriggerMultiple:
                m_vExtent = 0x9E0
            class CServerOnlyModelEntity:
                pass
            class CServerOnlyPointEntity:
                pass
            class CSkyCameraVolumeTarget:
                m_hSkyMaterial = 0x4B0
                m_nSkyboxScale = 0x4A8
            class CSoundAreaEntitySphere:
                m_flRadius = 0x4C8
            class INavPathCostAreaFilter:
                pass
            class RelationshipOverride_t:
                entity = 0x8
                classType = 0xC
            class globalentitydatabase_t:
                m_list = 0x60
            class CAnimGraphControllerPtr:
                m_pController = 0x0
            class CBasePulseGraphInstance:
                pass
            class CCS2PawnGraphController:
                m_moveType = 0x5D8
                m_airAction = 0x740
                m_bIsWalking = 0x680
                m_flinchBody = 0x818
                m_flinchHead = 0x7E8
                m_bIsDefusing = 0x5C0
                m_flLadderYaw = 0x710
                m_flMoveSpeedX = 0x608
                m_flMoveSpeedY = 0x620
                m_groundAction = 0x6B0
                m_flAimYawAngle = 0x7D0
                m_flLadderCycle = 0x6F8
                m_flCrouchAmount = 0x668
                m_flinchIsOnFire = 0x848
                m_leftFootTarget = 0x770
                m_flAimPitchAngle = 0x7B8
                m_flFlashedAmount = 0x7A0
                m_moveDirectionID = 0x5F0
                m_rightFootTarget = 0x788
                m_flinchBodyRestart = 0x830
                m_flinchHeadRestart = 0x800
                m_flWeaponDropAmount = 0x698
                m_flLadderYawBackwards = 0x728
                m_flMoveSpeedHorizontal = 0x638
                m_flAirHeightAboveGround = 0x758
                m_groundActionDirectionID = 0x6C8
                m_flGroundTurnAngleOrVelocity = 0x6E0
                m_flPreviousMoveSpeedHorizontal = 0x650
            class CCSCustomHudLayoutState:
                m_playerSlot = 0x30
                m_vecHasClasses = 0x38
                m_bInputCaptureEnabled = 0x34
                m_vecDialogVariableStrings = 0x98
            class CCSObserver_UseServices:
                pass
            class CCSPlayerAnimationState:
                m_airAction = 0x1B
                m_actionStartTick = 0x20
                m_currentMoveType = 0x18
                m_groundMoveState = 0x19
                m_flPreviousAimYaw = 0x30
                m_flTurnOnSpotAngle = 0x2C
                m_flFootIKOffsetLeft = 0x38
                m_flFootIKOffsetRight = 0x3C
                m_groundActionDirection = 0x1A
                m_plantAndTurnStartTick = 0x28
                m_bWasOnGroundLastUpdate = 0x1C
                m_staticAimTimerStartTick = 0x24
                m_bWasStationaryLastUpdate = 0x1D
                m_flPreviousHorizontalSpeed = 0x34
                m_flWeaponDropSmoothDampVelocity = 0x44
                m_flWeaponDropPercentageDueToMovement = 0x40
            class CCSPlayer_RadioServices:
                m_bIgnoreRadio = 0x60
                m_flRadioTokenSlots = 0x54
                m_flC4PlantTalkTimer = 0x50
                m_flDefusingTalkTimer = 0x4C
                m_flGotHostageTalkTimer = 0x48
            class CCSPlayer_WaterServices:
                m_nDrownDmgRate = 0x4C
                m_AirFinishedTime = 0x50
                m_flSwimSoundTime = 0x64
                m_flWaterJumpTime = 0x54
                m_vecWaterJumpVel = 0x58
                m_NextDrownDamageTime = 0x48
            class CChoreo_GraphController:
                m_eChoreoState = 0xC0
                m_tChoreoExitWarp = 0xF0
                m_tChoreoTargetWarp = 0xD8
            class CCommentaryViewPosition:
                pass
            class CEnvVolumetricFogVolume:
                m_bActive = 0x4A8
                m_vBoxMaxs = 0x4B8
                m_vBoxMins = 0x4AC
                m_TintColor = 0x4E8
                m_flStrength = 0x4C8
                m_nFalloffShape = 0x4CC
                m_bStartDisabled = 0x4C4
                m_fNoiseStrength = 0x4E4
                m_bIndirectUseLPVs = 0x4C5
                m_flHeightFogDepth = 0x4D4
                m_fSunLightStrength = 0x4E0
                m_flFalloffExponent = 0x4D0
                m_bOverrideTintColor = 0x4EC
                m_fHeightFogEdgeWidth = 0x4D8
                m_bOverrideNoiseStrength = 0x4EF
                m_fIndirectLightStrength = 0x4DC
                m_bOverrideSunLightStrength = 0x4EE
                m_bOverrideIndirectLightStrength = 0x4ED
            class CInfoSpawnGroupLandmark:
                pass
            class CLightDirectionalEntity:
                pass
            class CLightEnvironmentEntity:
                pass
            class CLogicGameEventListener:
                m_bEnabled = 0x4E0
                m_OnEventFired = 0x4B8
                m_bStartDisabled = 0x4E1
                m_iszGameEventItem = 0x4D8
                m_iszGameEventName = 0x4D0
            class CMarkupVolumeTagged_Nav:
                m_nScopes = 0x890
            class CNmEventConsumerContact:
                pass
            class CPathMoverEntitySpawner:
                m_bEnabled = 0x52C
                m_nSpawnNum = 0x524
                m_hPathMover = 0x4F4
                m_nMaxActive = 0x520
                m_nSpawnIndex = 0x4F0
                m_vMoverSpawnPos = 0x59C
                m_flLastSpawnTime = 0x528
                m_iszPathMoverName = 0x578
                m_szSpawnTemplates = 0x4B0
                m_OnTemplateSpawned = 0x548
                m_vecQueuedRemovals = 0x530
                m_bRunningDebugThink = 0x5A8
                m_bPrepopulateOnSpawn = 0x580
                m_iszPathNodeStartName = 0x588
                m_szSpawnTemplateCount = 0x4E0
                m_szSpawnTemplateParams = 0x4D0
                m_OnTemplateGroupSpawned = 0x560
                m_eTemplateChoiceStrategy = 0x4A8
                m_flSpawnFrequencySeconds = 0x4F8
                m_mapSpawnedMoverTemplates = 0x500
                m_bDestroyMoverOnArrivedAtEnd = 0x52D
                m_flSpawnFrequencyDistToNearestMover = 0x4FC
            class CPhysicsPropMultiplayer:
                pass
            class CPhysicsPropRespawnable:
                m_vOriginalMaxs = 0xD34
                m_vOriginalMins = 0xD28
                m_flRespawnDuration = 0xD40
                m_vOriginalSpawnAngles = 0xD1C
                m_vOriginalSpawnOrigin = 0xD10
            class CPlayer_AutoaimServices:
                pass
            class CPulseCell_Inflow_Yield:
                m_UnyieldResume = 0xD8
            class CPulseCell_PlaySequence:
                m_OnFinished = 0xF8
                m_SequenceName = 0xD8
                m_PulseAnimEvents = 0xE0
            class CPulseCell_ReturnValues:
                pass
            class CPulseCell_Step_EntFire:
                m_Input = 0x48
            class CSmokeGrenadeProjectile:
                m_nRandomSeed = 0xB70
                m_vSmokeColor = 0xB74
                m_flLastBounce = 0xBB4
                m_nVoxelUpdate = 0xBAC
                m_VoxelFrameData = 0xB90
                m_bDidSmokeEffect = 0xB6C
                m_bDidGroundScorch = 0x2E41
                m_bExplodeFromInferno = 0x2E40
                m_nVoxelFrameDataSize = 0xBA8
                m_vSmokeDetonationPos = 0xB80
                m_fllastSimulationTime = 0xBB8
                m_nSmokeEffectTickBegin = 0xB68
                m_nSmokeLightProbeRegen = 0xBB0
            class CSoundEventSphereEntity:
                m_flRadius = 0x568
            class CSoundOpvarSetBoxEntity:
                m_vInnerMaxs = 0x680
                m_vInnerMins = 0x674
                m_vOuterMaxs = 0x698
                m_vOuterMins = 0x68C
                m_nBoxDirection = 0x670
                m_vDistanceInnerMaxs = 0x64C
                m_vDistanceInnerMins = 0x640
                m_vDistanceOuterMaxs = 0x664
                m_vDistanceOuterMins = 0x658
            class CSoundOpvarSetOBBEntity:
                pass
            class CSoundOpvarSetPointBase:
                m_hSource = 0x4AC
                m_bDisabled = 0x4A8
                m_iOpvarIndex = 0x548
                m_bFastRefresh = 0x54D
                m_iszOpvarName = 0x540
                m_iszStackName = 0x530
                m_flRefreshTime = 0x52C
                m_vLastPosition = 0x520
                m_bUseAutoCompare = 0x54C
                m_iszOperatorName = 0x538
                m_iszSourceEntityName = 0x4C8
            class CTextureBasedAnimatable:
                m_bLoop = 0x850
                m_flFPS = 0x854
                m_flStartTime = 0x880
                m_flStartFrame = 0x884
                m_hPositionKeys = 0x858
                m_hRotationKeys = 0x860
                m_vAnimationBoundsMax = 0x874
                m_vAnimationBoundsMin = 0x868
            class CTriggerDetectExplosion:
                m_OnDetectedExplosion = 0x9F0
            class EntityRenderAttribute_t:
                m_ID = 0x30
                m_Values = 0x34
            class RagdollCreationParams_t:
                m_vForce = 0x0
                m_nForceBone = 0xC
                m_nHealthToGrant = 0x14
                m_bForceCurrentWorldTransform = 0x10
            class SellbackPurchaseEntry_t:
                m_hItem = 0x40
                m_nCost = 0x34
                m_unDefIdx = 0x30
                m_nPrevArmor = 0x38
                m_bPrevHelmet = 0x3C
            class SignatureOutflow_Resume:
                pass
            class SoundOpvarTraceResult_t:
                vPos = 0x0
                bDidHit = 0xC
                flDistSqrToCenter = 0x10
            class SummaryTakeDamageInfo_t:
                info = 0x8
                result = 0x120
                hTarget = 0x180
                nSummarisedCount = 0x0
            class ViewAngleServerChange_t:
                nType = 0x30
                nIndex = 0x40
                qAngle = 0x34
            class WeaponPurchaseTracker_t:
                m_weaponPurchases = 0x8
            class ragdollhierarchyjoint_t:
                childIndex = 0x4
                parentIndex = 0x0
            class CAnimGraphControllerBase:
                m_hExternalGraph = 0x4C
            class CBaseAnimGraphController:
                m_hSequence = 0x5C
                m_nNotifyState = 0x78
                m_nAnimLoopMode = 0x68
                m_flPlaybackRate = 0x6C
                m_flSeqStartTime = 0x60
                m_primaryGraphId = 0x3C8
                m_flSeqFixedCycle = 0x64
                m_flSoundSyncTime = 0x54
                m_bSequenceFinished = 0x7C
                m_pGraphInstanceAG2 = 0x408
                m_vecExternalGraphs = 0x628
                m_bLastUpdateSkipped = 0x7B
                m_nActiveIKChainMask = 0x58
                m_vecExternalClipIds = 0x3E8
                m_hGraphDefinitionAG2 = 0x320
                m_nAnimationAlgorithm = 0x18
                m_nPrevAnimUpdateTick = 0x80
                m_vecExternalGraphIds = 0x3D0
                m_sAnimGraph2Identifier = 0x400
                m_vecSecondarySkeletons = 0x38
                m_nNextExternalGraphHandle = 0x1C
                m_bNetworkedSequenceChanged = 0x7A
                m_SerializePoseRecipeAG2Slots = 0x328
                m_vecSecondarySkeletonSlotIDs = 0x20
                m_SerializePoseRecipeAG2Dynamic = 0x390
                m_nSecondarySkeletonMasterCount = 0x50
                m_nServerGraphInstanceIteration = 0x3C0
                m_nSerializePoseRecipeVersionAG2 = 0x3AC
                m_bNetworkedAnimationInputsChanged = 0x79
                m_nSerializePoseRecipeAG2ActiveSlot = 0x3A8
                m_nServerSerializationContextIteration = 0x3C4
            class CBaseCSGrenadeProjectile:
                m_nBounces = 0xAE8
                m_nItemIndex = 0xB0E
                m_flSpawnTime = 0xB08
                m_vecGrenadeSpin = 0xB20
                m_unOGSExtraFlags = 0xB0C
                m_bHasEverHitEnemy = 0xB3C
                m_vInitialPosition = 0xAD0
                m_vInitialVelocity = 0xADC
                m_bDetonationRecorded = 0xB0D
                m_nExplodeEffectIndex = 0xAF0
                m_nTicksAtZeroVelocity = 0xB38
                m_flLastBounceSoundTime = 0xB1C
                m_vecExplodeEffectOrigin = 0xAFC
                m_nExplodeEffectTickBegin = 0xAF8
                m_vecLastHitSurfaceNormal = 0xB2C
                m_vecOriginalSpawnLocation = 0xB10
            class CBtNodeConditionInactive:
                m_SensorInactivityTimer = 0x80
                m_flRoundStartThresholdSeconds = 0x78
                m_flSensorInactivityThresholdSeconds = 0x7C
            class CCSPlayer_BulletServices:
                m_totalHitsOnServer = 0x48
            class CCSPlayer_CameraServices:
                pass
            class CCSPlayer_WeaponServices:
                m_flNextAttack = 0xC0
                m_hSavedWeapon = 0xC4
                m_nTimeToMelee = 0xC8
                m_nTimeToPrimary = 0xD0
                m_bPickedUpWeapon = 0xDA
                m_nTimeToSecondary = 0xCC
                m_bIsBeingGivenItem = 0xD8
                m_networkAnimTiming = 0x1898
                m_bDisableAutoDeploy = 0xDB
                m_nTimeToSniperRifle = 0xD4
                m_bIsPickingUpItemWithUse = 0xD9
                m_bIsPickingUpGroundWeapon = 0xDC
                m_bBlockInspectUntilNextGraphUpdate = 0x18B0
            class CCitadelSoundOpvarSetOBB:
                m_iszOpvarName = 0x4B8
                m_iszStackName = 0x4A8
                m_nAABBDirection = 0x4F0
                m_iszOperatorName = 0x4B0
                m_vDistanceInnerMaxs = 0x4CC
                m_vDistanceInnerMins = 0x4C0
                m_vDistanceOuterMaxs = 0x4E4
                m_vDistanceOuterMins = 0x4D8
            class CConstantForceController:
                m_linear = 0xC
                m_angular = 0x18
                m_linearSave = 0x24
                m_angularSave = 0x30
            class CEntitySubclassVDataBase:
                pass
            class CGenericLogicPlayerProxy:
                pass
            class CInfoTeleportDestination:
                pass
            class CNavVolumeSphericalShell:
                m_flRadiusInner = 0x88
            class CNetworkViewOffsetVector:
                m_vecX = 0x10
                m_vecY = 0x18
                m_vecZ = 0x20
            class CNmEventConsumerParticle:
                pass
            class CPlayer_MovementServices:
                m_flUpMove = 0x1C8
                m_nButtons = 0x50
                m_nImpulse = 0x48
                m_flLeftMove = 0x1C4
                m_flMaxspeed = 0x1AC
                m_flCmdUpMove = 0x1A8
                m_flCmdLeftMove = 0x1A4
                m_flForwardMove = 0x1C0
                m_flCmdForwardMove = 0x1A0
                m_vecOldViewAngles = 0x240
                m_nButtonDoublePressed = 0x80
                m_nQueuedButtonDownMask = 0x70
                m_nToggleButtonDownMask = 0x190
                m_arrForceSubtickMoveWhen = 0x1B0
                m_nQueuedButtonChangeMask = 0x78
                m_pButtonPressedCmdNumber = 0x88
                m_vecLastMovementImpulses = 0x1CC
                m_nLastCommandNumberProcessed = 0x188
            class CPlayer_ObserverServices:
                m_iObserverMode = 0x48
                m_hObserverTarget = 0x4C
                m_iObserverLastMode = 0x50
                m_bForcedObserverMode = 0x54
            class CPointClientUIWorldPanel:
                m_bLit = 0x9B1
                m_flDPI = 0x9BC
                m_bOpaque = 0x9F8
                m_flWidth = 0x9B4
                m_bNoDepth = 0x9F9
                m_flHeight = 0x9B8
                m_bGrabbable = 0x9FE
                m_bIgnoreInput = 0x9B0
                m_flDepthOffset = 0x9C8
                m_unOrientation = 0x9D8
                m_vecCSSClasses = 0x9E0
                m_bDisableMipGen = 0xA00
                m_unOwnerContext = 0x9CC
                m_bRenderBackface = 0x9FB
                m_flWindowUIScale = 0x9C0
                m_unVerticalAlign = 0x9D4
                m_unHorizontalAlign = 0x9D0
                m_flInteractDistance = 0x9C4
                m_bOnlyRenderToTexture = 0x9FF
                m_nExplicitImageLayout = 0xA04
                m_bExcludeFromSaveGames = 0x9FD
                m_bUseOffScreenIndicator = 0x9FC
                m_bIgnoreParentOrientation = 0xA08
                m_bVisibleWhenParentNoDraw = 0x9FA
                m_bFollowPlayerAcrossTeleport = 0x9B2
                m_bAllowInteractionFromAllSceneWorlds = 0x9DC
            class CPulseCell_Inflow_Method:
                m_Args = 0xA0
                m_bIsPublic = 0x98
                m_MethodName = 0x80
                m_Description = 0x90
                m_ReturnValues = 0xB0
            class CPulseCell_IntervalTimer:
                m_Completed = 0xD8
                m_OnInterval = 0x120
            class CPulseCell_Step_DebugLog:
                pass
            class CPulse_OutflowConnection:
                m_nDestChunk = 0x10
                m_nInstruction = 0x14
                m_SourceOutflowName = 0x0
                m_OutflowRegisterMap = 0x18
            class CSAdditionalMatchStats_t:
                m_flTeamDamage = 0x13C
                m_iNumSuicides = 0x134
                m_iNumTeamKills = 0x138
                m_numFirstKills = 0x124
                m_numClutchKills = 0x128
                m_numPistolKills = 0x12C
                m_numSniperKills = 0x130
                m_numRoundsSurvivedTotal = 0x118
                m_numRoundsSurvivedStreak = 0x110
                m_iRoundsWonWithoutPurchase = 0x11C
                m_maxNumRoundsSurvivedStreak = 0x114
                m_iRoundsWonWithoutPurchaseTotal = 0x120
            class CSoundOpvarSetAABBEntity:
                pass
            class CSoundOpvarSetDomeEntity:
                m_flSize = 0x734
                m_bDomeMode = 0x740
                m_nClusterK = 0x748
                m_arOpenness = 0x658
                m_bMultiWall = 0x741
                m_flClusterP = 0x74C
                m_arNeighbors = 0x670
                m_arDirections = 0x640
                m_arClusterSize = 0x6A8
                m_nClusterIndex = 0x6F0
                m_nCurrentIndex = 0x688
                m_flClusterBlend = 0x750
                m_arClusterDirSum = 0x6D8
                m_arClusterParent = 0x690
                m_arClusterWeight = 0x6C0
                m_nTracesPerFrame = 0x73C
                m_flLastSmoothTime = 0x730
                m_flSmoothHalfLife = 0x75C
                m_nTotalDirections = 0x738
                m_vLastTraceOrigin = 0x714
                m_vSmoothedOpenDir = 0x704
                m_bTraceOriginValid = 0x720
                m_vClusterDirection = 0x6F8
                m_flOpennessExponent = 0x754
                m_flShoulderExponent = 0x758
                m_flSmoothedOpenness = 0x72C
                m_flWallTransmission = 0x744
                m_flClusteredOpenness = 0x6F4
                m_bDiscontinuityPending = 0x728
                m_nCatchUpThinksRemaining = 0x724
                m_nDirWarmupThinksRemaining = 0x710
            class CTouchExpansionComponent:
                pass
            class CTriggerDetectBulletFire:
                m_bPlayerFireOnly = 0x9C8
                m_OnDetectedBulletFire = 0x9D0
            class CAI_ExpresserWithFollowup:
                pass
            class CCS2WeaponGraphController:
                m_action = 0xC0
                m_attackType = 0x210
                m_weaponType = 0x120
                m_reloadStage = 0x288
                m_bActionReset = 0xD8
                m_flWeaponAmmo = 0x150
                m_idleVariation = 0x1E0
                m_weaponCategory = 0x108
                m_deployVariation = 0x1F8
                m_flWeaponAmmoMax = 0x168
                m_weaponExtraInfo = 0x138
                m_inspectExtraInfo = 0x270
                m_inspectVariation = 0x258
                m_bWeaponIsSilenced = 0x198
                m_flAttackVariation = 0x240
                m_attackThrowStrength = 0x228
                m_bIsUsingLegacyModel = 0x1C8
                m_flWeaponAmmoReserve = 0x180
                m_flWeaponIronsightAmount = 0x1B0
                m_flWeaponActionSpeedScale = 0xF0
            class CCSGO_EndOfMatchLineupEnd:
                pass
            class CCSGameModeRules_ArmsRace:
                m_WeaponSequence = 0x30
            class CCSPlayer_HostageServices:
                m_hCarriedHostage = 0x48
                m_hCarriedHostageProp = 0x4C
            class CEnvSoundscapeTriggerable:
                pass
            class CFuncInteractionLayerClip:
                m_bDisabled = 0x850
                m_iszInteractsAs = 0x858
                m_iszInteractsWith = 0x860
            class CInfoChoreoAnchorPosition:
                m_hParent = 0x40
                m_flRadius = 0x38
                m_qAnglesLS = 0x10
                m_vOriginLS = 0x0
                m_nShapeType = 0x44
                m_vExtentsMax = 0x2C
                m_vExtentsMin = 0x20
                m_bOnlyWarpPosition = 0x3C
            class CInfoDynamicShadowHintBox:
                m_vBoxMaxs = 0x4CC
                m_vBoxMins = 0x4C0
            class CInfoInstructorHintTarget:
                pass
            class CInfoSpawnGroupLoadUnload:
                m_bAutoActivate = 0x52C
                m_iszLandmarkName = 0x518
                m_bUnloadingStarted = 0x52D
                m_flTimeoutInterval = 0x528
                m_iszSpawnGroupName = 0x508
                m_bQueueFinishLoading = 0x52F
                m_sFixedSpawnGroupName = 0x520
                m_OnSpawnGroupLoadStarted = 0x4A8
                m_iszSpawnGroupFilterName = 0x510
                m_OnSpawnGroupLoadFinished = 0x4C0
                m_OnSpawnGroupUnloadStarted = 0x4D8
                m_OnSpawnGroupUnloadFinished = 0x4F0
                m_bQueueActiveSpawnGroupChange = 0x52E
            class CItemGenericTriggerHelper:
                m_hParentItem = 0x850
            class CNetworkTransmitComponent:
                m_nTransmitStateOwnedCounter = 0x184
            class CNmAimCSNode__CDefinition:
                m_nIsDefusingNodeIdx = 0x24
                m_nWeaponDropNodeIdx = 0x22
                m_nWeaponTypeNodeIdx = 0x1E
                m_nCrouchWeightNodeIdx = 0x26
                m_nWeaponActionNodeIdx = 0x20
                m_nVerticalAngleNodeIdx = 0x18
                m_nWeaponCategoryNodeIdx = 0x1C
                m_nHorizontalAngleNodeIdx = 0x1A
                m_flActionBlendTimeSeconds = 0x2C
                m_flHandIKBlendInTimeSeconds = 0x28
                m_flPlantingBlendTimeSeconds = 0x30
            class CNmEventConsumerBodyGroup:
                pass
            class CPulseCell_Value_Gradient:
                m_Gradient = 0x48
            class CShatterGlassShardPhysics:
                m_ShardDesc = 0x858
                m_nPoolState = 0x8D8
                m_hParentShard = 0x850
                m_bTouchedByPlayer = 0x8DC
            class CSimpleMarkupVolumeTagged:
                pass
            class CSoundOpvarSetPointEntity:
                m_OnExit = 0x568
                m_OnEnter = 0x550
                m_bReloading = 0x5E5
                m_bAutoDisable = 0x580
                m_flDistanceMax = 0x5C8
                m_flDistanceMin = 0x5C4
                m_flOcclusionMax = 0x5DC
                m_flOcclusionMin = 0x5D8
                m_hDynamicEntity = 0x600
                m_nSimulationMode = 0x5E8
                m_flDistanceMapMax = 0x5D0
                m_flDistanceMapMin = 0x5CC
                m_flOcclusionRadius = 0x5D4
                m_flValSetOnDisable = 0x5E0
                m_vPathingDirection = 0x62C
                m_vPathingSourcePos = 0x614
                m_bSetValueOnDisable = 0x5E4
                m_nVisibilitySamples = 0x5EC
                m_vDynamicProxyPoint = 0x5F0
                m_nPathingSourceIndex = 0x638
                m_vPathingListenerPos = 0x620
                m_iszDynamicEntityName = 0x608
                m_flDynamicMaximumOcclusion = 0x5FC
                m_flPathingDistanceNormFactor = 0x610
            class DebugDrawBoneTransforms_t:
                vecBones = 0x10
            class ExternalAnimGraphHandle_t:
                m_Value = 0x0
            class OutflowWithRequirements_t:
                m_Connection = 0x0
                m_RequirementNodeIDs = 0x50
                m_DestinationFlowNodeID = 0x48
                m_nCursorStateBlockIndex = 0x68
            class SignatureOutflow_Continue:
                pass
            class WaterWheelFrictionScale_t:
                m_flFrictionScale = 0x4
                m_flFractionOfWheelSubmerged = 0x0
            class CBtActionCombatPositioning:
                m_bCrouching = 0xA0
                m_ActionTimer = 0x88
                m_szIsAttackingKey = 0x80
                m_szSensorInputKey = 0x68
            class CCS2ChickenGraphController:
                m_mode = 0x128
                m_action = 0xC0
                m_bFlinch = 0x1B8
                m_bInWater = 0x110
                m_idlePhase = 0x158
                m_lifeStage = 0x140
                m_turnAngle = 0x170
                m_bActionReset = 0xD8
                m_lookatTarget = 0x1A0
                m_actionVariation = 0xF8
                m_flinchVariation = 0x1D0
                m_bHasLookatTarget = 0x188
                m_bHasActionCompletedEvent = 0x1E8
            class CCSObserver_CameraServices:
                pass
            class CCSPlayer_AimPunchServices:
                m_predictableBaseTick = 0x48
                m_predictableBaseAngle = 0x50
                m_unpredictableBaseTick = 0xA0
                m_unpredictableBaseAngle = 0xA4
                m_predictableBaseAngleVel = 0x5C
                m_predictableBaseTickInterpAmount = 0x4C
            class CCSPlayer_MovementServices:
                m_vecUp = 0x674
                m_bDucked = 0x408
                m_vecLeft = 0x668
                m_bDucking = 0x416
                m_StuckLast = 0x64C
                m_flStamina = 0x69C
                m_LegacyJump = 0x6B8
                m_ModernJump = 0x6D0
                m_iFootsteps = 0x688
                m_vecForward = 0x65C
                m_flDuckSpeed = 0x410
                m_nTraceCount = 0x648
                m_bDesiresDuck = 0x415
                m_bInStuckTest = 0x43A
                m_flDuckAmount = 0x40C
                m_bDuckOverride = 0x414
                m_bSpeedCropped = 0x650
                m_nLastJumpTick = 0x708
                m_AnimationState = 0x310
                m_flLastDuckTime = 0x420
                m_flLastJumpFrac = 0x70C
                m_nOldWaterLevel = 0x654
                m_vecWalkWishVel = 0x7A8
                m_vecLadderNormal = 0x3F8
                m_bJumpApexPending = 0x714
                m_flDuckRootOffset = 0x418
                m_flDuckViewOffset = 0x41C
                m_flWaterEntryTime = 0x658
                m_duckUntilOnGround = 0x438
                m_bMadeFootstepNoise = 0x684
                m_flHeightAtJumpStart = 0x6A0
                m_flLastJumpVelocityZ = 0x710
                m_flVelMulAtJumpStart = 0x6B0
                m_flStaminaAtJumpStart = 0x6AC
                m_flBombPlantViewOffset = 0x424
                m_flAccumulatedJumpError = 0x6B4
                m_flFrictionStashedSpeed = 0x698
                m_flMaxJumpHeightLastJump = 0x6A8
                m_flMaxJumpHeightThisJump = 0x6A4
                m_nLadderSurfacePropIndex = 0x404
                m_bHasEverProcessedCommand = 0xFD0
                m_bUseFrictionStashedSpeed = 0x690
                m_bHasWalkMovedSinceLastJump = 0x439
                m_bUsingGroundTopologyOffset = 0x3F0
                m_fStashGrenadeParameterWhen = 0x68C
                m_flTicksSinceLastSurfingDetected = 0x718
                m_vecLastPositionAtFullCrouchSpeed = 0x430
                m_flUseFrictionStashedSpeedUntilFrac = 0x694
                m_nGameCodeHasMovedPlayerAfterCommand = 0x680
                m_flUsingGroundTopologyOffsetTransitionSmoothing = 0x3F4
            class CNavVolumeCalculatedVector:
                pass
            class CNmEventConsumerAttributes:
                pass
            class CPhysicsBodyGameMarkupData:
                m_PhysicsBodyMarkupByBoneName = 0x0
            class CPlayerControllerComponent:
                __m_pChainEntity = 0x8
            class CPlayer_FlashlightServices:
                pass
            class CPropDoorRotatingBreakable:
                m_bBreakable = 0xF30
                m_damageStates = 0xF38
                m_currentDamageState = 0xF34
                m_isAbleToCloseAreaPortals = 0xF31
            class CPulseCell_BaseRequirement:
                pass
            class CPulseCell_Outflow_PlayVCD:
                m_OnPaused = 0x140
                m_OnResumed = 0x188
                m_hChoreoScene = 0x138
                m_OutRequirements = 0x1D0
            class CPulseCell_SoundEventStart:
                m_Type = 0x48
            class CPulseCell_Value_RandomInt:
                pass
            class CPulse_BlackboardReference:
                m_nNodeID = 0x18
                m_NodeName = 0x20
                m_BlackboardResource = 0x8
                m_hBlackboardResource = 0x0
            class CScriptUniformRandomStream:
                m_hScriptScope = 0x8
                m_nInitialSeed = 0x9C
            class CTriggerActiveWeaponDetect:
                m_iszWeaponClassName = 0x9E0
                m_OnTouchedActiveWeapon = 0x9C8
            class FuncMoverMovementSummary_t:
                nTick = 0x18
                flEndT = 0x4
                nFlags = 0x14
                flStartT = 0x0
                hPathMover = 0x1C
                nMovementMode = 0x10
                nStopNodeIndex = 0xC
                nStartNodeIndex = 0x8
            class PulseNodeDynamicOutflows_t:
                m_Outflows = 0x0
            class PulseSelectorOutflowList_t:
                m_Outflows = 0x0
            class CAnimGraphControllerManager:
                m_controllers = 0x0
                m_bGraphBindingsCreated = 0x90
            class CBodyComponentBaseAnimGraph:
                m_animationController = 0x4E0
            class CCSGO_EndOfMatchLineupStart:
                pass
            class CCSGameModeRules_Deathmatch:
                m_sDMBonusWeapon = 0x38
                m_flDMBonusStartTime = 0x30
                m_flDMBonusTimeLength = 0x34
            class CDestructiblePartsComponent:
                m_hOwner = 0x60
                __m_pChainEntity = 0x0
                m_vecDamageTakenByHitGroup = 0x48
                m_pAnimGraphDestructibleGraphController = 0x68
            class CDynamicPropGraphController:
                m_sActionState = 0xC0
            class CEnvVolumetricFogController:
                m_bActive = 0x4F4
                m_vBoxMaxs = 0x4E8
                m_vBoxMins = 0x4DC
                m_TintColor = 0x4AC
                m_bIsMaster = 0x51E
                m_bFirstTime = 0x550
                m_fWindSpeed = 0x540
                m_fNoiseSpeed = 0x52C
                m_flFadeInEnd = 0x4C0
                m_flFadeSpeed = 0x4B4
                m_vNoiseScale = 0x534
                m_flAnisotropy = 0x4B0
                m_flScattering = 0x4A8
                m_nVolumeDepth = 0x4C8
                m_flFadeInStart = 0x4BC
                m_bStartDisabled = 0x51C
                m_fNoiseStrength = 0x530
                m_flDrawDistance = 0x4B8
                m_vWindDirection = 0x544
                m_bEnableIndirect = 0x51D
                m_flStartAnisoTime = 0x4F8
                m_flStartAnisotropy = 0x504
                m_flStartScattering = 0x508
                m_flIndirectStrength = 0x4C4
                m_flStartScatterTime = 0x4FC
                m_nForceRefreshCount = 0x528
                m_flDefaultAnisotropy = 0x510
                m_flDefaultScattering = 0x514
                m_flStartDrawDistance = 0x50C
                m_hFogIndirectTexture = 0x520
                m_nIndirectTextureDimX = 0x4D0
                m_nIndirectTextureDimY = 0x4D4
                m_nIndirectTextureDimZ = 0x4D8
                m_flDefaultDrawDistance = 0x518
                m_flStartDrawDistanceTime = 0x500
                m_fFirstVolumeSliceThickness = 0x4CC
            class CInfoPlayerCounterterrorist:
                pass
            class CMarkupVolumeTagged_NavGame:
                m_nScopes = 0x8B8
                m_bSplitNavSpace = 0x8BA
                m_bFloodFillAttribute = 0x8B9
            class CNetworkedSequenceOperation:
                m_flCycle = 0x10
                m_flWeight = 0x14
                m_hSequence = 0x8
                m_flPrevCycle = 0xC
                m_bDiscontinuity = 0x1D
                m_bSequenceChangeNetworked = 0x1C
                m_flPrevCycleFromDiscontinuity = 0x20
                m_flPrevCycleForAnimEventDetection = 0x24
            class CPointAngularVelocitySensor:
                m_vecAxis = 0x4D0
                m_OnEqualTo = 0x560
                m_OnLessThan = 0x500
                m_bUseHelper = 0x4DC
                m_flFireTime = 0x4B8
                m_flThreshold = 0x4AC
                m_OnGreaterThan = 0x530
                m_hTargetEntity = 0x4A8
                m_flFireInterval = 0x4BC
                m_AngularVelocity = 0x4E0
                m_lastOrientation = 0x4C4
                m_nLastFireResult = 0x4B4
                m_flLastAngVelocity = 0x4C0
                m_nLastCompareResult = 0x4B0
                m_OnLessThanOrEqualTo = 0x518
                m_OnGreaterThanOrEqualTo = 0x548
            class CPulseCell_ApplyEntityFlags:
                pass
            class CPulseCell_Inflow_GraphHook:
                m_HookName = 0x80
            class CSAdditionalPerRoundStats_t:
                m_iDinks = 0x14
                m_nDefuseStarts = 0x1C
                m_killsWhileBlind = 0x4
                m_nHostagePickUps = 0x20
                m_bombCarrierkills = 0x8
                m_numChickensKilled = 0x0
                m_numTeammatesFlashed = 0x24
                m_bBombPlantedAndAlive = 0x19
                m_bFreshStartThisRound = 0x18
                m_flBurnDamageInflicted = 0xC
                m_flBlastDamageInflicted = 0x10
                m_strAnnotationsWorkshopId = 0x28
            class CSoundAreaEntityOrientedBox:
                m_vMax = 0x4D4
                m_vMin = 0x4C8
            class CSoundEventMultiPointEntity:
                m_bPlaying = 0x578
                m_iCountMax = 0x568
                m_flDistMaxSqr = 0x570
                m_flDistanceMax = 0x56C
                m_flDotProductMax = 0x574
            class CSoundEventPathCornerEntity:
                m_iszPathCorner = 0x5A0
                m_vecCornerPairsNetworked = 0x5C0
            class CSoundOpvarSetOBBWindEntity:
                m_vMaxs = 0x55C
                m_vMins = 0x550
                m_flWindMax = 0x584
                m_flWindMin = 0x580
                m_flWindMapMax = 0x58C
                m_flWindMapMin = 0x588
                m_vDistanceMaxs = 0x574
                m_vDistanceMins = 0x568
            class PulseScriptedSequenceData_t:
                m_nMoveTo = 0x28
                m_nActorID = 0x0
                m_szSequence = 0x18
                m_nMoveToGait = 0x2C
                m_bIgnoreLookAt = 0x37
                m_szExitSequence = 0x20
                m_szEntrySequence = 0x10
                m_szPreIdleSequence = 0x8
                m_bLoopActionSequence = 0x35
                m_nHeldWeaponBehavior = 0x30
                m_bLoopPreIdleSequence = 0x34
                m_bLoopPostIdleSequence = 0x36
            class CCSObserver_MovementServices:
                pass
            class CCSObserver_ObserverServices:
                pass
            class CCSPlayerBase_CameraServices:
                m_iFOV = 0x178
                m_flFOVRate = 0x184
                m_flFOVTime = 0x180
                m_iFOVStart = 0x17C
                m_hZoomOwner = 0x188
                m_hLastFogTrigger = 0x1A8
                m_hTriggerFogList = 0x190
            class CDestructiblePartsSystemData:
                m_PartsDataByHitGroup = 0x0
                m_nMinMaxNumberHitGroupsToDestroyWhenGibbing = 0x28
            class CDynamicNavConnectionsVolume:
                m_vecConnections = 0x9E8
                m_sTransitionType = 0xA00
                m_flUpdateDistance = 0xA10
                m_bConnectionsEnabled = 0xA08
                m_iszConnectionTarget = 0x9E0
                m_flMaxConnectionDistance = 0xA14
                m_flTargetAreaSearchRadius = 0xA0C
            class CEnvCombinedLightProbeVolume:
                m_Entity_Color = 0x5C0
                m_Entity_bEnabled = 0x679
                m_Entity_vBoxMaxs = 0x61C
                m_Entity_vBoxMins = 0x610
                m_Entity_bMoveable = 0x628
                m_Entity_nPriority = 0x634
                m_Entity_nHandshake = 0x62C
                m_Entity_flBrightness = 0x5C4
                m_Entity_bStartDisabled = 0x638
                m_Entity_flEdgeFadeDist = 0x63C
                m_Entity_vEdgeFadeDists = 0x640
                m_Entity_hCubemapTexture = 0x5C8
                m_Entity_nLightProbeSizeX = 0x64C
                m_Entity_nLightProbeSizeY = 0x650
                m_Entity_nLightProbeSizeZ = 0x654
                m_Entity_nLightProbeAtlasX = 0x658
                m_Entity_nLightProbeAtlasY = 0x65C
                m_Entity_nLightProbeAtlasZ = 0x660
                m_Entity_bCustomCubemapTexture = 0x5D0
                m_Entity_nEnvCubeMapArrayIndex = 0x630
                m_Entity_hLightProbeTexture_SDF = 0x5E0
                m_Entity_hLightProbeTexture_SH2_DC = 0x5E8
                m_Entity_hLightProbeTexture_SH2_L1 = 0x5F0
                m_Entity_hLightProbeTexture_AmbientCube = 0x5D8
                m_Entity_hLightProbeDirectLightIndicesTexture = 0x5F8
                m_Entity_hLightProbeDirectLightScalarsTexture = 0x600
                m_Entity_hLightProbeDirectLightShadowsTexture = 0x608
            class CNavVolumeBreadthFirstSearch:
                m_vStartPos = 0xA8
                m_flSearchDist = 0xB4
            class CPointBroadcastClientCommand:
                pass
            class CPointClientUIWorldTextPanel:
                m_messageText = 0xA10
            class CPulseCell_Step_FollowEntity:
                m_ParamBoneOrAttachName = 0x48
                m_ParamBoneOrAttachNameChild = 0x50
            class CPulseCell_Step_PublicOutput:
                m_OutputIndex = 0x48
            class CPulseCell_Value_RandomFloat:
                pass
            class CPulseCell_WaitForObservable:
                m_OnTrue = 0x168
                m_Condition = 0xD8
            class CRopeKeyframeAlias_move_rope:
                pass
            class CSkeletonAnimationController:
                m_pSkeletonInstance = 0x8
            class CSoundOpvarSetAutoRoomEntity:
                m_flSize = 0x670
                m_flSizeSqr = 0x678
                m_doorwayPairs = 0x658
                m_traceResults = 0x640
                m_flHeightTolerance = 0x674
            class CTakeDamageSummaryScopeGuard:
                m_vecSummaries = 0x8
            class FuncRotatorRotationSummary_t:
                nTick = 0x0
                nFlags = 0x4
            class ISkeletonAnimationController:
                pass
            class SimpleConstraintSoundProfile:
                m_flKeyPointMaxSoundThreshold = 0xC
                m_flKeyPointMinSoundThreshold = 0x8
                m_reversalSoundThresholdLarge = 0x18
                m_reversalSoundThresholdSmall = 0x10
                m_reversalSoundThresholdMedium = 0x14
            class VPhysicsCollisionAttribute_t:
                m_nOwnerId = 0x24
                m_nEntityId = 0x20
                m_nHierarchyId = 0x28
                m_nInteractsAs = 0x8
                m_nInteractsWith = 0x10
                m_nCollisionGroup = 0x2E
                m_nDetailLayerMask = 0x2A
                m_nInteractsExclude = 0x18
                m_nTargetDetailLayer = 0x2D
                m_nDetailLayerMaskType = 0x2C
                m_nCollisionFunctionMask = 0x2F
            class CBodyComponentBaseModelEntity:
                pass
            class CBtActionParachutePositioning:
                m_ActionTimer = 0x58
            class CCSPlayer_DamageReactServices:
                pass
            class CDestructiblePart_DamageLevel:
                m_sName = 0x0
                m_nHealth = 0x14
                m_nBodyGroupValue = 0x10
                m_flDeathDestroyTime = 0x3C
                m_sBreakablePieceName = 0x8
                m_bShouldDestroyOnDeath = 0x38
                m_sCustomDeathHandshake = 0x30
                m_nDamagePassthroughType = 0x28
                m_flCriticalDamagePercent = 0x24
                m_nDestructionDeathBehavior = 0x2C
            class CInfoOffscreenPanoramaTexture:
                m_bDisabled = 0x4A8
                m_szPanelType = 0x4B8
                m_nResolutionX = 0x4AC
                m_nResolutionY = 0x4B0
                m_bEnableMipGen = 0x4A9
                m_szTargetsName = 0x508
                m_vecCSSClasses = 0x4F0
                m_RenderAttrName = 0x4C8
                m_TargetEntities = 0x4D0
                m_szLayoutFileName = 0x4C0
                m_nTargetChangeCount = 0x4E8
                m_AdditionalTargetEntities = 0x510
            class CNetworkOriginQuantizedVector:
                m_vecX = 0x10
                m_vecY = 0x18
                m_vecZ = 0x20
            class CPulseCell_BaseYieldingInflow:
                m_BaseFlow_WhileActive = 0x90
                m_BaseFlow_OnAfterCancel = 0x48
            class CPulseCell_BooleanSwitchState:
                m_WhenTrue = 0x168
                m_Condition = 0xD8
                m_WhenFalse = 0x1B0
            class CPulseCell_IsRequirementValid:
                pass
            class CPulseCell_LerpCameraSettings:
                m_End = 0x134
                m_Start = 0x124
                m_flSeconds = 0x120
            class CPulseCell_Outflow_PlayVOLine:
                m_OnFinished = 0xD8
            class CTestPulseIOComponent_Derived:
                pass
            class AI_BaseNPC_DebugSnapshotData_t:
                animgraph = 0x70
                navigator = 0xB8
                npc_state = 0x8
                conditions = 0x40
                anim_events = 0x58
                current_enemy = 0x10
                motorServices = 0x108
                facingServices = 0x140
                s_current_task = 0x20
                s_prev_schedule = 0x28
                s_current_schedule = 0x18
                s_npc_current_movement = 0x30
                s_last_task_end_location = 0x38
            class CBodyComponentSkeletonInstance:
                m_skeletonInstance = 0x80
            class CCSGO_EndOfMatchLineupEndpoint:
                pass
            class CDynamicPropAlias_dynamic_prop:
                pass
            class CFloatExponentialMovingAverage:
                pass
            class CInfoInstructorHintBombTargetA:
                pass
            class CInfoInstructorHintBombTargetB:
                pass
            class CItemDefuserAlias_item_defuser:
                pass
            class CNmSnapWeaponNode__CDefinition:
                m_nWeaponTypeNodeIdx = 0x1C
                m_nFlashedAmountNodeIdx = 0x18
                m_nWeaponCategoryNodeIdx = 0x1A
            class CPulseCell_ApplyAnimGraphParam:
                m_value = 0xD8
            class CPulseCell_Inflow_EventHandler:
                m_EventName = 0x80
            class CPulseCell_Outflow_CycleRandom:
                m_Outputs = 0x48
            class CPulseCell_Outflow_PlayVCDBase:
                pass
            class CSoundOpvarSetPathCornerEntity:
                m_flDistMaxSqr = 0x660
                m_flDistMinSqr = 0x65C
                m_bUseParentedPath = 0x658
                m_iszPathCornerEntityName = 0x668
            class HUDPanelDialogVariableString_t:
                m_bIsSet = 0x18
                m_sValue = 0x10
                m_nPanelIdIndex = 0x8
                m_nDialogVariableIndex = 0xA
            class SoundeventBoxHelperNetworked_t:
                vMaxs = 0x24
                vMins = 0x18
                qAngles = 0xC
                vOrigin = 0x0
            class CBaseAnimGraphVariationUserData:
                pass
            class CDynamicPropAlias_cable_dynamic:
                pass
            class CNetworkOriginQuantizedVectorWS:
                m_vecX = 0x10
                m_vecY = 0x18
                m_vecZ = 0x20
            class CPulseCell_Outflow_CycleOrdered:
                m_Outputs = 0x48
            class CPulseCell_Outflow_PlaySequence:
                m_ParamSequenceName = 0x138
            class CTestPulseIO__FloatStringArgs_t:
                flOutFloat = 0x0
                strOutString = 0x8
            class CTestPulseIO__ThreeStringArgs_t:
                strArg1 = 0x0
                strArg2 = 0x8
                strArg3 = 0x10
            class CVectorExponentialMovingAverage:
                pass
            class DestructiblePartDamageRequest_t:
                m_hAttacker = 0x1C
                m_nHitGroup = 0x0
                m_nDamageType = 0x10
                m_nDamageLevel = 0x4
                m_flBreakDamage = 0x14
                m_nDestroyFlags = 0xC
                m_nDesiredHealth = 0x8
                m_flBreakDamageRadius = 0x18
                m_vWsBreakDamageForce = 0x2C
                m_vWsBreakDamageOrigin = 0x20
            class ServerAuthoritativeWeaponSlot_t:
                unSlot = 0x32
                unClass = 0x30
                unItemDefIdx = 0x34
            class AI_Navigator_DebugSnapshotData_t:
                waypoints = 0x30
                goal_location = 0x24
                s_movement_id = 0x0
                last_waypoint_pos = 0x18
                s_goal_source_location = 0x10
                s_movement_serial_number = 0x8
                s_arrival_movement_gait_set = 0x48
            class CCSGO_RushIntroCharacterPosition:
                pass
            class CCSGO_RushIntroTerroristPosition:
                pass
            class CCSGO_TeamIntroCharacterPosition:
                pass
            class CCSGO_TeamIntroTerroristPosition:
                pass
            class CCSPlayer_ActionTrackingServices:
                m_bIsRescuing = 0x224
                m_weaponPurchasesThisMatch = 0x228
                m_weaponPurchasesThisRound = 0x298
                m_weaponCarryOverIntoThisRound = 0x308
                m_hLastWeaponBeforeC4AutoSwitch = 0x1F8
            class CHostageAlias_info_hostage_spawn:
                pass
            class CMarkupSearch_PathCostAreaFilter:
                m_searchHelper = 0x8
            class CPhysHingeAlias_phys_hinge_local:
                pass
            class CPulseCell_Inflow_BaseEntrypoint:
                m_EntryChunk = 0x48
                m_RegisterMap = 0x50
            class CPulseCell_Outflow_CycleShuffled:
                m_Outputs = 0x48
            class CPulseCell_Outflow_PlaySceneBase:
                m_Triggers = 0x120
                m_OnFinished = 0xD8
            class CPulseCell_WaitForCursorsWithTag:
                m_bTagSelfWhenComplete = 0x128
                m_nDesiredKillPriority = 0x12C
            class CPulseGraphInstance_ServerEntity:
                m_hOwner = 0x118
                m_bActivated = 0x11C
                m_sNameFixupLocal = 0x130
                m_sNameFixupParent = 0x128
                m_sNameFixupStaticPrefix = 0x120
                m_sProceduralWorldNameForRelays = 0x138
            class AI_DefaultNPC_DebugSnapshotData_t:
                path_query = 0x40
                s_npc_tactic_phase = 0x20
                s_npc_tactic_current = 0x18
                s_npc_current_ability = 0x8
                path_queries_speculative = 0x68
                s_npc_current_held_ability = 0x10
                tactic_interrupt_conditions = 0x28
            class CBaseAnimGraphAlias_baseanimating:
                pass
            class CCSGO_TeamSelectCharacterPosition:
                pass
            class CCSGO_TeamSelectTerroristPosition:
                pass
            class CPlayer_MovementServices_Humanoid:
                m_nStepside = 0x280
                m_groundNormal = 0x260
                m_surfaceProps = 0x270
                m_flFallVelocity = 0x25C
                m_flStepSoundTime = 0x258
                m_flSurfaceFriction = 0x26C
                m_vecSmoothedVelocity = 0x284
            class CPulseCell_InlineNodeSkipSelector:
                m_bAnd = 0x4C
                m_FailOutflow = 0x68
                m_PassOutflow = 0x50
                m_nFlowNodeID = 0x48
            class CPulseCell_LimitCount__Criteria_t:
                m_bLimitCountPasses = 0x0
            class CPulseCell_Outflow_PlayDynamicVCD:
                pass
            class CPulseCell_Step_SetAnimGraphParam:
                m_ParamName = 0x48
            class DebugSnapshotBaseStructuredData_t:
                pass
            class CCSGO_TeamPreviewCharacterPosition:
                m_xuid = 0x4C0
                m_nRandom = 0x4AC
                m_petItem = 0x1080
                m_nOrdinal = 0x4B0
                m_nVariant = 0x4A8
                m_agentItem = 0x4C8
                m_glovesItem = 0x8B0
                m_weaponItem = 0xC98
                m_sWeaponName = 0x4B8
            class CCSPlayerController_DamageServices:
                m_DamageList = 0x48
                m_nSendUpdate = 0x40
            class CEnvSoundscapeAlias_snd_soundscape:
                pass
            class CPulseCell_BaseLerp__CursorState_t:
                m_EndTime = 0x4
                m_StartTime = 0x0
            class CPulseCell_Inflow_EntOutputHandler:
                m_SourceEntity = 0x80
                m_SourceOutput = 0x90
                m_ExpectedParamType = 0xA0
            class CPulseCell_PickBestOutflowSelector:
                m_nCheckType = 0x48
                m_OutflowList = 0x50
            class CPulseCell_Step_CallExternalMethod:
                m_MethodName = 0xD8
                m_OnFinished = 0x108
                m_ExpectedArgs = 0xF0
                m_nAsyncCallMode = 0x100
                m_nBlackboardIndex = 0xE8
            class CPulseGraphInstance_GameBlackboard:
                pass
            class CCSGO_WingmanIntroCharacterPosition:
                pass
            class CCSGO_WingmanIntroTerroristPosition:
                pass
            class CFuncLadderAlias_func_useableladder:
                pass
            class CFuncMoveLinearAlias_momentary_door:
                pass
            class CPulseCell_ApplyDynamicAttributeInt:
                pass
            class CPulseCell_Outflow_ScriptedSequence:
                m_Triggers = 0x180
                m_OnFinished = 0x138
                m_szSyncGroup = 0xD8
                m_bDontTeleportAtEnd = 0xE5
                m_bDisallowInterrupts = 0xE6
                m_vecAdditionalActors = 0x120
                m_bEnsureOnNavmeshOnFinish = 0xE4
                m_scriptedSequenceDataMain = 0xE8
                m_nExpectedNumSequencesInSyncGroup = 0xE0
            class CTestPulseIO__EntityHandleIntArgs_t:
                valueB = 0x4
                handleA = 0x0
            class SoundeventPathCornerPairNetworked_t:
                vP1 = 0x0
                vP2 = 0xC
                flP1Pct = 0x1C
                flP2Pct = 0x20
                flPathLengthSqr = 0x18
            class AI_MotorServices_DebugSnapshotData_t:
                motor_path = 0x18
                active_motor = 0x0
                desired_speed = 0x8
                motor_velocity = 0xC
                ground_entity_debug_name = 0x30
            class AnimGraph2SerializedPoseRecipeSlot_t:
                m_topology = 0x30
            class CBaseModelEntity__BodyGroupRequest_t:
                m_nGroup = 0x10
                m_uChoice = 0x14
                m_uRefCount = 0x16
                m_nGroupName = 0x4
                m_uRequestID = 0x0
                m_sChoiceName = 0x8
            class CInfoInstructorHintHostageRescueZone:
                pass
            class CPulseCell_ApplyDynamicAttributeBase:
                pass
            class CPulseCell_Timeline__TimelineEvent_t:
                m_EventOutflow = 0x8
                m_flTimeFromPrevious = 0x0
            class CPulseCell_WaitForCursorsWithTagBase:
                m_WaitComplete = 0xE0
                m_nCursorsAllowedToWait = 0xD8
            class CTestPulseIO__EntityNameStringArgs_t:
                nameA = 0x0
                strValueB = 0x8
            class AI_FacingServices_DebugSnapshotData_t:
                movement_id = 0x40
                npc_position = 0x0
                facing_target = 0x18
                strafing_source = 0x30
                strafing_enabled = 0x38
                facing_target_source = 0x10
                schedule_facing_priority = 0x28
            class CCSPlayerController_InventoryServices:
                m_rank = 0x44
                m_unMusicID = 0x40
                m_unCurrentLoadoutHash = 0xF90
                m_nPersonaDataPublicLevel = 0x5C
                m_nPersonaDataXpTrailLevel = 0x6C
                m_unEquippedPlayerSprayIDs = 0xF88
                m_nPersonaDataPublicCommendsLeader = 0x60
                m_nPersonaDataPublicCommendsTeacher = 0x64
                m_vecServerAuthoritativeWeaponSlots = 0xF98
                m_nPersonaDataPublicCommendsFriendly = 0x68
            class CPulseCell_ApplyParent__CursorState_t:
                m_hChildEntity = 0x4
                m_hParentEntity = 0x0
            class CNetworkOriginCellCoordQuantizedVector:
                m_vecX = 0x18
                m_vecY = 0x20
                m_vecZ = 0x28
                m_cellX = 0x10
                m_cellY = 0x12
                m_cellZ = 0x14
                m_nOutsideWorld = 0x16
            class CPulseCell_ApplyDynamicAttributeString:
                pass
            class CPulseCell_LimitCount__InstanceState_t:
                m_nCurrentCount = 0x0
            class CPulseCell_PlaySequence__CursorState_t:
                m_hTarget = 0x0
            class CRagdollPropAlias_physics_prop_ragdoll:
                pass
            class CSoundEventEntityAlias_snd_event_point:
                pass
            class AI_BaseNPCAnimGraph_DebugSnapshotData_t:
                ag2_update_id = 0x0
                e_action_desired = 0x8
                e_movement_type_desired = 0x28
                e_action_handshake_restart = 0x10
                e_movement_handshake_restart = 0x30
                e_action_handshake_body_authority_current = 0x18
                e_action_handshake_body_authority_desired = 0x20
                e_movement_handshake_body_authority_current = 0x38
                e_movement_handshake_body_authority_desired = 0x40
            class CCSGO_RushIntroCounterTerroristPosition:
                pass
            class CCSGO_TeamIntroCounterTerroristPosition:
                pass
            class CCSPlayerController_InGameMoneyServices:
                m_iAccount = 0x48
                m_iStartAccount = 0x4C
                m_iTotalCashSpent = 0x50
                m_iCashSpentThisRound = 0x54
                m_bReceivesMoneyNextRound = 0x40
                m_iMoneyEarnedForNextRound = 0x44
            class CDynamicPropAlias_prop_dynamic_override:
                pass
            class CPulseCell_ApplyDynamicAttributeEHandle:
                pass
            class CPulseCell_IntervalTimer__CursorState_t:
                m_EndTime = 0x4
                m_StartTime = 0x0
                m_flWaitInterval = 0x8
                m_flWaitIntervalHigh = 0xC
                m_bCompleteOnNextWake = 0x10
            class CCSGO_TeamSelectCounterTerroristPosition:
                pass
            class CNetworkOriginCellCoordQuantizedVectorWS:
                m_vecX = 0x18
                m_vecY = 0x20
                m_vecZ = 0x28
                m_cellX = 0x10
                m_cellY = 0x12
                m_cellZ = 0x14
                m_nOutsideWorld = 0x16
            class CPulseCell_Outflow_ListenForAnimgraphTag:
                m_OnEnd = 0x120
                m_OnStart = 0xD8
                m_TagName = 0x168
            class CPulseCell_Outflow_ListenForEntityOutput:
                m_OnFired = 0xD8
                m_strEntityOutput = 0x120
                m_bListenUntilCanceled = 0x128
            class CWorldCompositionChunkReferenceElement_t:
                m_strMapToLoad = 0x0
                m_strLandmarkName = 0x8
            class CPulseCell_IsRequirementValid__Criteria_t:
                m_bIsValid = 0x0
            class CCSGO_WingmanIntroCounterTerroristPosition:
                pass
            class CCSPlayerController_ActionTrackingServices:
                m_matchStats = 0xC8
                m_perRoundStats = 0x40
                m_iNumRoundKills = 0x188
                m_flTotalRoundDamageDealt = 0x190
                m_iNumRoundKillsHeadshots = 0x18C
            class CPulseCell_ApplyEntityFlags__CursorState_t:
                m_uFlags = 0x4
                m_hEntity = 0x0
            class CAttributeManager__cached_attribute_float_t:
                flIn = 0x0
                flOut = 0x10
                iAttribHook = 0x8
            class CSceneEntityAlias_logic_choreographed_scene:
                pass
            class AI_GroundRootMotionMotor_DebugSnapshotData_t:
                state = 0x40
                move_type = 0x58
                b_has_path = 0x4C
                vec_events = 0x78
                f_target_lean = 0x70
                f_current_lean = 0x6C
                f_current_speed = 0x54
                movement_setting_id = 0x28
                current_movement_gait = 0x20
                desired_movement_gait = 0x10
                b_goal_completion_allowed = 0x38
                current_movement_gait_set = 0x18
                desired_movement_gait_set = 0x8
                n_state_active_tick_count = 0x48
                gait_switch_blocked_reason = 0x30
                f_remaining_ground_path_length = 0x50
                f_forward_strafing_angle_actual = 0x60
                f_forward_strafing_angle_desired = 0x64
                f_forward_strafing_angle_committed = 0x68
            class AI_Navigator_DebugSnapshotData_t__Waypoint_t:
                flags = 0x10
                nav_type = 0xC
                position = 0x0
                is_pathcorner = 0x14
            class CBaseModelEntity__OnDamageLevelChangedArgs_t:
                nHitGroup = 0x0
                nDamageLevel = 0x4
                nPrevDamageLevel = 0xC
                nDamageLevelsRemaining = 0x8
            class CPulseCell_Inflow_ObservableVariableListener:
                m_bSelfReference = 0x82
                m_nBlackboardReference = 0x80
            class CPulseCell_LerpCameraSettings__CursorState_t:
                m_hCamera = 0x8
                m_OverlaidEnd = 0x1C
                m_OverlaidStart = 0xC
            class CPulseCell_Outflow_PlayVOLine__CursorState_t:
                m_sceneInstance = 0x0
            class PulseNodeDynamicOutflows_t__DynamicOutflow_t:
                m_OutflowID = 0x0
                m_Connection = 0x8
            class CEnvSoundscapeProxyAlias_snd_soundscape_proxy:
                pass
            class CPulseCell_ApplyAnimGraphParam__CursorState_t:
                hEntity = 0x0
                sParamName = 0x8
                bApplyToExternalGraphs = 0x10
            class AI_DefaultNPC_DebugSnapshotData_t__PathQuery_t:
                m_nMode = 0x10
                m_nType = 0x18
                m_nState = 0x20
                m_nCurrentMovementId = 0x8
                m_nInitialMovementId = 0x0
            class CBaseAnimGraphDestructibleParts_GraphController:
                pass
            class CPulseCell_Outflow_PlaySceneBase__CursorState_t:
                m_mainActor = 0x4
                m_sceneInstance = 0x0
                m_cursorIDToEventID = 0x8
            class CPulseCell_Outflow_CycleOrdered__InstanceState_t:
                m_nNextIndex = 0x0
            class CPulseCell_Outflow_PlayVCD__VCDRequirementInfo_t:
                m_Outflow = 0x8
                m_nEventID = 0x0
            class CTonemapController2Alias_env_tonemap_controller2:
                pass
            class CPulseCell_Outflow_CycleShuffled__InstanceState_t:
                m_Shuffle = 0x0
                m_nNextShuffle = 0x20
            class CPulseCell_Outflow_ScriptedSequence__CursorState_t:
                m_scriptedSequence = 0x0
            class CPulseCell_ApplyDynamicAttributeBase__CursorState_t:
                m_hEntity = 0x0
                m_szAttributeKey = 0x8
            class CPathParticleRopeAlias_path_particle_rope_clientside:
                pass
            class AI_GroundRootMotionMotor_DebugSnapshotData_t__Event_t:
                location = 0x8
                description = 0x0
            class CPulseCell_Outflow_ListenForEntityOutput__CursorState_t:
                m_entity = 0x0
            class AI_MotorServices_DebugSnapshotData_t__MotorPathWaypoint_t:
                flags = 0x10
                nav_type = 0xC
                position = 0x0
            class CEnvSoundscapeTriggerableAlias_snd_soundscape_triggerable:
                pass
            class CCSPlayerController_InventoryServices__NetworkedLoadoutSlot_t:
                slot = 0xA
                team = 0x8
                pItem = 0x0
            class CEnvCombinedLightProbeVolumeAlias_func_combined_light_probe_volume:
                pass
            class ETeam:
                ET_CT = 0x3
                ET_Unknown = 0x0
                ET_Spectator = 0x1
                ET_Terrorist = 0x2
            class ESOMsg:
                k_ESOMsg_Create = 0x15
                k_ESOMsg_Update = 0x16
                k_ESOMsg_Destroy = 0x17
                k_ESOMsg_UpdateMultiple = 0x1A
                k_ESOMsg_CacheSubscribed = 0x18
                k_ESOMsg_CacheUnsubscribed = 0x19
                k_ESOMsg_CacheSubscriptionCheck = 0x1B
                k_ESOMsg_CacheSubscriptionRefresh = 0x1C
            class Hull_t:
                HULL_NONE = 0xB
                HULL_TINY = 0x3
                NUM_HULLS = 0xA
                HULL_HUMAN = 0x0
                HULL_LARGE = 0x6
                HULL_SMALL = 0x9
                HULL_MEDIUM = 0x4
                HULL_WIDE_HUMAN = 0x2
                HULL_MEDIUM_TALL = 0x8
                HULL_TINY_CENTERED = 0x5
                HULL_LARGE_CENTERED = 0x7
                HULL_SMALL_CENTERED = 0x1
            class Class_T:
                CLASS_DOOR = 0xB
                CLASS_NONE = 0x0
                CLASS_PLAYER = 0x1
                CLASS_WEAPON = 0x5
                CLASS_PLANTED_C4 = 0xC
                CLASS_PLAYER_ALLY = 0x2
                CLASS_C4_FOR_RADAR = 0x3
                CLASS_HUDMODEL_ARMS = 0x8
                CLASS_HUDMODEL_ADDON = 0x9
                CLASS_WATER_SPLASHER = 0x6
                NUM_CLASSIFY_CLASSES = 0xD
                CLASS_HUDMODEL_WEAPON = 0x7
                CLASS_WORLDMODEL_GLOVES = 0xA
                CLASS_FOOT_CONTACT_SHADOW = 0x4
            class Flags_t:
                FL_BOT = 0x10
                FL_FLY = 0x400
                FL_CLIENT = 0x80
                FL_FROZEN = 0x20
                FL_OBJECT = 0x2000000
                FL_ONFIRE = 0x8000000
                FL_DUCKING = 0x2
                FL_GODMODE = 0x4000
                FL_GRENADE = 0x100000
                FL_CONVEYOR = 0x1000000
                FL_NOTARGET = 0x8000
                FL_ONGROUND = 0x1
                FL_AIMTARGET = 0x10000
                FL_DONTTOUCH = 0x400000
                FL_WATERJUMP = 0x4
                FL_ATCONTROLS = 0x40
                FL_DISSOLVING = 0x10000000
                FL_FAKECLIENT = 0x100
                FL_IN_VEHICLE = 0x1000
                FL_BASEVELOCITY = 0x800000
                FL_TRANSRAGDOLL = 0x20000000
                FL_SUPPRESS_SAVE = 0x800
                FL_UNBLOCKABLE_BY_PLAYER = 0x40000000
            class OnFrame:
                ONFRAME_TRUE = 0x1
                ONFRAME_FALSE = 0x2
                ONFRAME_UNKNOWN = 0x0
            class Touch_t:
                touch_none = 0x0
                touch_npc_only = 0x2
                touch_player_only = 0x1
                touch_player_or_npc = 0x3
                touch_player_or_npc_or_physicsprop = 0x4
            class filter_t:
                FILTER_OR = 0x1
                FILTER_AND = 0x0
            class BloodType:
                _None = -0x1
                ColorRed = 0x0
                ColorGreen = 0x2
                ColorYellow = 0x1
                ColorRedLVL2 = 0x3
                ColorRedLVL3 = 0x4
                ColorRedLVL4 = 0x5
                ColorRedLVL5 = 0x6
                ColorRedLVL6 = 0x7
            class EGCPetMsg:
                k_EMsgGCAckPetEvent = 0x9EA
            class EHitGroup:
                EHG_Gear = 0x8
                EHG_Head = 0x1
                EHG_Miss = 0x9
                EHG_Chest = 0x2
                EHG_Generic = 0x0
                EHG_LeftArm = 0x4
                EHG_LeftLeg = 0x6
                EHG_Stomach = 0x3
                EHG_RightArm = 0x5
                EHG_RightLeg = 0x7
            class Materials:
                matWeb = 0x9
                matNone = 0xA
                matWood = 0x1
                matFlesh = 0x3
                matGlass = 0x0
                matMetal = 0x2
                matRocks = 0x8
                matComputer = 0x6
                matCeilingTile = 0x5
                matCinderBlock = 0x4
                matLastMaterial = 0xB
                matUnbreakableGlass = 0x7
            class QuestType:
                k_EQuestType_Operation = 0x1
                k_EQuestType_RecurringMission = 0x2
            class eRollType:
                ROLL_NONE = -0x1
                ROLL_STATS = 0x0
                ROLL_OUTTRO = 0x3
                ROLL_CREDITS = 0x1
                ROLL_LATE_JOIN_LOGO = 0x2
            class BeamType_t:
                BEAM_ENTS = 0x3
                BEAM_LASER = 0x6
                BEAM_POINTS = 0x1
                BEAM_SPLINE = 0x5
                BEAM_INVALID = 0x0
                BEAM_ENTPOINT = 0x2
                xxBEAM_HOSExxunused = 0x4
            class ECsgoGCMsg:
                k_EMsgGC_GlobalGame_Play = 0x23D2
                k_EMsgGCCStrike15_v2_Base = 0x238C
                k_EMsgGC_GlobalGame_Subscribe = 0x23D0
                k_EMsgGCCStrike15_v2_MatchList = 0x23B3
                k_EMsgGCCStrike15_v2_SetClanId = 0x240D
                k_EMsgGCCStrike15_v2_GlobalChat = 0x23DC
                k_EMsgGC_GlobalGame_Unsubscribe = 0x23D1
                k_EMsgGCCStrike15_ClientDeepStats = 0x23FA
                k_EMsgGCCStrike15_v2_DraftSummary = 0x23CA
                k_EMsgGCCStrike15_v2_Party_Invite = 0x23E8
                k_EMsgGCCStrike15_v2_Party_Search = 0x23E7
                k_EMsgGCCStrike15_v2_PrivateQueues = 0x23FE
                k_EMsgGCCStrike15_v2_BetaEnrollment = 0x2401
                k_EMsgGCCStrike15_v2_GotvSyncPacket = 0x23E0
                k_EMsgGCCStrike15_v2_Party_Register = 0x23E5
                k_EMsgGCCStrike15_v2_PlayersProfile = 0x23A8
                k_EMsgGCCStrike15_v2_WatchInfoUsers = 0x23A6
                k_EMsgGCCStrike15_v2_ClientPollState = 0x23E4
                k_EMsgGCCStrike15_v2_MatchmakingStop = 0x238E
                k_EMsgGCCStrike15_v2_Client2GCTextMsg = 0x23AF
                k_EMsgGCCStrike15_v2_ClientPerfReport = 0x23F2
                k_EMsgGCCStrike15_v2_GC2ClientTextMsg = 0x23AE
                k_EMsgGCCStrike15_v2_MatchmakingStart = 0x238D
                k_EMsgGCCStrike15_v2_Party_Unregister = 0x23E6
                k_EMsgGCCStrike15_v2_SetEventFavorite = 0x23F0
                k_EMsgGCCStrike15_v2_ClientAuthKeyCode = 0x23DF
                k_EMsgGCCStrike15_v2_SetMyActivityInfo = 0x23C7
                k_EMsgGCCStrike15_v2_AcknowledgePenalty = 0x23D3
                k_EMsgGCCStrike15_v2_ClientGCRankUpdate = 0x23EA
                k_EMsgGCCStrike15_v2_ClientPartyWarning = 0x23EE
                k_EMsgGCCStrike15_v2_ClientReportPlayer = 0x239F
                k_EMsgGCCStrike15_v2_ClientReportServer = 0x23A0
                k_EMsgGCCStrike15_v2_ClientCommendPlayer = 0x23A1
                k_EMsgGCCStrike15_v2_ClientNetworkConfig = 0x2404
                k_EMsgGCCStrike15_v2_ClientRequestOffers = 0x23EB
                k_EMsgGCCStrike15_v2_ClientAccountBalance = 0x23EC
                k_EMsgGCCStrike15_v2_ClientPartyJoinRelay = 0x23ED
                k_EMsgGCCStrike15_v2_ClientReportResponse = 0x23A2
                k_EMsgGCCStrike15_v2_GC2ClientGlobalStats = 0x23D5
                k_EMsgGCCStrike15_v2_GlobalChat_Subscribe = 0x23DD
                k_EMsgGCCStrike15_v2_PremierSeasonSummary = 0x2408
                k_EMsgGCCStrike15_v2_Client2GCStreamUnlock = 0x23D6
                k_EMsgGCCStrike15_v2_ClientLogonFatalError = 0x23E3
                k_EMsgGCCStrike15_v2_ClientPlayerDecalSign = 0x23E1
                k_EMsgGCCStrike15_v2_ClientRequestSouvenir = 0x23F4
                k_EMsgGCCStrike15_v2_GC2ClientNotifyXPShop = 0x2405
                k_EMsgGCCStrike15_v2_VolatileShopSubscribe = 0x240C
                k_EMsgGCCStrike15_v2_AccountPrivacySettings = 0x23C6
                k_EMsgGCCStrike15_v2_Account_RequestCoPlays = 0x23E9
                k_EMsgGCCStrike15_v2_ClientRedeemFreeReward = 0x2403
                k_EMsgGCCStrike15_v2_ClientSubmitSurveyVote = 0x23C0
                k_EMsgGCCStrike15_v2_GlobalChat_Unsubscribe = 0x23DE
                k_EMsgGCCStrike15_v2_MatchEndRunRewardDrops = 0x23B0
                k_EMsgGCCStrike15_v2_RecurringMissionSchema = 0x240A
                k_EMsgGCCStrike15_v2_ClientToGCRequestTicket = 0x23DA
                k_EMsgGCCStrike15_v2_FantasyUpdateClientData = 0x23D8
                k_EMsgGCCStrike15_v2_GC2ClientTournamentInfo = 0x23CF
                k_EMsgGCCStrike15_v2_GiftsLeaderboardRequest = 0x23BC
                k_EMsgGCCStrike15_v2_Server2GCClientValidate = 0x23C1
                k_EMsgGCCStrike15_v2_VolatileItemClaimReward = 0x240B
                k_EMsgGCCStrike15_StartAgreementSessionInGame = 0x23FB
                k_EMsgGCCStrike15_v2_Client2GcAckXPShopTracks = 0x2406
                k_EMsgGCCStrike15_v2_ClientCommendPlayerQuery = 0x23A3
                k_EMsgGCCStrike15_v2_ClientToGCRequestElevate = 0x23DB
                k_EMsgGCCStrike15_v2_FantasyRequestClientData = 0x23D7
                k_EMsgGCCStrike15_v2_GiftsLeaderboardResponse = 0x23BD
                k_EMsgGCCStrike15_v2_ClientRedeemMissionReward = 0x23F9
                k_EMsgGCCStrike15_v2_GetEventFavorites_Request = 0x23F1
                k_EMsgGCCStrike15_v2_MatchmakingClient2GCHello = 0x2395
                k_EMsgGCCStrike15_v2_MatchmakingGC2ClientHello = 0x2396
                k_EMsgGCCStrike15_v2_PlayerOverwatchCaseStatus = 0x23AD
                k_EMsgGCCStrike15_v2_PlayerOverwatchCaseUpdate = 0x23AB
                k_EMsgGCCStrike15_v2_GC2ServerReservationUpdate = 0x23B6
                k_EMsgGCCStrike15_v2_GetEventFavorites_Response = 0x23F3
                k_EMsgGCCStrike15_v2_MatchmakingGC2ClientUpdate = 0x2390
                k_EMsgGCCStrike15_v2_ClientRequestJoinFriendData = 0x23CB
                k_EMsgGCCStrike15_v2_ClientRequestJoinServerData = 0x23CC
                k_EMsgGCCStrike15_v2_ClientRequestPlayersProfile = 0x23A7
                k_EMsgGCCStrike15_v2_MatchmakingGC2ClientAbandon = 0x2398
                k_EMsgGCCStrike15_v2_MatchmakingGC2ClientReserve = 0x2393
                k_EMsgGCCStrike15_v2_Client2GCRequestPrestigeCoin = 0x23D4
                k_EMsgGCCStrike15_v2_MatchListRequestFullGameInfo = 0x23BB
                k_EMsgGCCStrike15_v2_MatchmakingClient2ServerPing = 0x238F
                k_EMsgGCCStrike15_v2_SetPlayerLeaderboardSafeName = 0x2402
                k_EMsgGCCStrike15_v2_GCToClientSteamdatagramTicket = 0x23D9
                k_EMsgGCCStrike15_v2_PlayerOverwatchCaseAssignment = 0x23AC
                k_EMsgGCCStrike15_v2_ClientRequestWatchInfoFriends2 = 0x23B2
                k_EMsgGCCStrike15_v2_ClientVarValueNotificationInfo = 0x23B8
                k_EMsgGCCStrike15_v2_ServerVarValueNotificationInfo = 0x23BE
                k_EMsgGCCStrike15_v2_MatchEndRewardDropsNotification = 0x23B1
                k_EMsgGCCStrike15_v2_MatchListRequestLiveGameForUser = 0x23C2
                k_EMsgGCCStrike15_v2_MatchListRequestRecentUserGames = 0x23B5
                k_EMsgGCCStrike15_v2_MatchListRequestTournamentGames = 0x23BA
                k_EMsgGCCStrike15_v2_MatchListTournamentOperatorMgmt = 0x23FF
                k_EMsgGCCStrike15_v2_MatchmakingGC2ClientSearchStats = 0x2407
                k_EMsgGCCStrike15_v2_RequestRecurringMissionSchedule = 0x2409
                k_EMsgGCCStrike15_v2_ClientCommendPlayerQueryResponse = 0x23A4
                k_EMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames = 0x23B4
                k_EMsgGCCStrike15_v2_MatchmakingOperator2GCBlogUpdate = 0x239D
                k_EMsgGCCStrike15_v2_ServerNotificationForUserPenalty = 0x239E
                k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockRequest = 0x23C4
                k_EMsgGCCStrike15_v2_MatchListUploadTournamentPredictions = 0x23C9
                k_EMsgGCCStrike15_v2_MatchmakingServerReservationResponse = 0x2392
                k_EMsgGCCStrike15_v2_Client2GCEconPreviewDataBlockResponse = 0x23C5
                k_EMsgGCCStrike15_v2_MatchListRequestTournamentPredictions = 0x23C8
            class EGCBaseMsg:
                k_EMsgGCError = 0x119D
                k_EMsgGCInQueue = 0xFA8
                k_EMsgGCLeaveParty = 0x1199
                k_EMsgGCConVarUpdated = 0xFA3
                k_EMsgGCInviteToParty = 0x1195
                k_EMsgGCKickFromParty = 0x1198
                k_EMsgGCSystemMessage = 0xFA1
                k_EMsgGCGameServerInfo = 0x119C
                k_EMsgGCServerAvailable = 0x119A
                k_EMsgGCReplicateConVars = 0xFA2
                k_EMsgGCInvitationCreated = 0x1196
                k_EMsgGCLANServerAvailable = 0x119F
                k_EMsgGCPartyInviteResponse = 0x1197
                k_EMsgGCClientConnectToServer = 0x119B
                k_EMsgGCReplay_UploadedToYouTube = 0x119E
            class EGCItemMsg:
                k_EMsgGCBase = 0x3E8
                k_EMsgGCCraft = 0x3EA
                k_EMsgGCDelete = 0x3EC
                k_EMsgGCNameItem = 0x3EE
                k_EMsgGCOpenCrate = 0x9E6
                k_EMsgGCPaintItem = 0x3F1
                k_EMsgGCSortItems = 0x411
                k_EMsgGCCollectItem = 0x425
                k_EMsgGCDeliverGift = 0x40A
                k_EMsgGCGiftedItems = 0x43B
                k_EMsgGCMOTDRequest = 0x3F4
                k_EMsgGCApplySticker = 0x43E
                k_EMsgGCGiftWrapItem = 0x408
                k_EMsgGCNameBaseItem = 0x3FB
                k_EMsgGCPaintKitItem = 0x438
                k_EMsgGCSetItemStyle = 0x40F
                k_EMsgGCStatTrakSwap = 0x440
                k_EMsgGC_ReportAbuse = 0x429
                k_EMsgGCCasketItemAdd = 0x444
                k_EMsgGCCraftResponse = 0x3EB
                k_EMsgGCLookupAccount = 0x413
                k_EMsgGCRemoveItemName = 0x406
                k_EMsgGCSaxxyBroadcast = 0x421
                k_EMsgGCUseItemRequest = 0x401
                k_EMsgGCApplyEggEssence = 0x436
                k_EMsgGCRemoveItemPaint = 0x407
                k_EMsgGCSetItemPosition = 0x3E9
                k_EMsgGCUnlockItemStyle = 0x43C
                k_EMsgGCUseItemResponse = 0x402
                k_EMsgGCApplyStrangePart = 0x431
                k_EMsgGCItemAcknowledged = 0x43F
                k_EMsgGCPaintKitBaseItem = 0x439
                k_EMsgGCRemoveMakersMark = 0x41D
                k_EMsgGCSetItemPositions = 0x435
                k_EMsgGCStoreGetUserData = 0x9C4
                k_EMsgGCUpdateItemSchema = 0x419
                k_EMsgGCCasketItemExtract = 0x445
                k_EMsgGCItemPreviewExpire = 0x6A9
                k_EMsgGCLookupAccountName = 0x415
                k_EMsgGCPaintItemResponse = 0x3F2
                k_EMsgGCServerRentalsBase = 0x6A4
                k_EMsgGCShowItemsPickedUp = 0x42F
                k_EMsgGCStorePurchaseInit = 0x9CE
                k_EMsgGCToGCDirtySDOCache = 0x9D4
                k_EMsgGCUnwrapGiftRequest = 0x40D
                k_EMsgGCUsedClaimCodeItem = 0x410
                k_EMsgGCDev_NewItemRequest = 0x7D1
                k_EMsgGCItemPreviewRequest = 0x6A7
                k_EMsgGCUnwrapGiftResponse = 0x40E
                k_EMsgGCApplyPennantUpgrade = 0x434
                k_EMsgGCConsumableExhausted = 0x42E
                k_EMsgGCMOTDRequestResponse = 0x3F5
                k_EMsgGCModifyItemAttribute = 0x443
                k_EMsgGCRemoveCustomTexture = 0x41B
                k_EMsgGCStorePurchaseCancel = 0x9CA
                k_EMsgGCToGCIsTrustedServer = 0x9D7
                k_EMsgGCUnlockCrateResponse = 0x3F0
                k_EMsgGCBackpackSortFinished = 0x422
                k_EMsgGCClientVersionUpdated = 0x9E0
                k_EMsgGCCustomizeItemTexture = 0x3FF
                k_EMsgGCDev_PaintKitDropItem = 0x7D3
                k_EMsgGCGiftWrapItemResponse = 0x409
                k_EMsgGCNameBaseItemResponse = 0x3FC
                k_EMsgGCNameItemNotification = 0x42C
                k_EMsgGCPaintKitItemResponse = 0x43A
                k_EMsgGCRequestAnnouncements = 0x9DD
                k_EMsgGCServerVersionUpdated = 0x9DA
                k_EMsgGC_ReportAbuseResponse = 0x42A
                k_EMsgGCBannedWordListRequest = 0x9D0
                k_EMsgGCGoldenWrenchBroadcast = 0x3F3
                k_EMsgGCLookupAccountResponse = 0x414
                k_EMsgGCStorePurchaseFinalize = 0x9C8
                k_EMsgGCStorePurchaseQueryTxn = 0x9CC
                k_EMsgGCToGCUpdateSQLKeyValue = 0x9D6
                k_EMsgGCAdjustEquipSlotsManual = 0x9E3
                k_EMsgGCApplyConsumableEffects = 0x42D
                k_EMsgGCBannedWordListResponse = 0x9D1
                k_EMsgGCCasketItemLoadContents = 0x446
                k_EMsgGCGiftedItems_DEPRECATED = 0x403
                k_EMsgGCItemPreviewCheckStatus = 0x6A5
                k_EMsgGCNameEggEssenceResponse = 0x437
                k_EMsgGCRemoveUniqueCraftIndex = 0x41F
                k_EMsgGCUnlockCrate_DEPRECATED = 0x3EF
                k_EMsgGCAdjustEquipSlotsShuffle = 0x9E4
                k_EMsgGCUnlockItemStyleResponse = 0x43D
                k_EMsgGCVerifyCacheSubscription = 0x3ED
                k_EMsgGCDeliverGiftResponseGiver = 0x40B
                k_EMsgGCRemoveMakersMarkResponse = 0x41E
                k_EMsgGCRequestPassportItemGrant = 0x9DF
                k_EMsgGCStoreGetUserDataResponse = 0x9C5
                k_EMsgGCToGCWebAPIAccountChanged = 0x9DC
                k_EMsgGCVolatileItemLoadContents = 0x9E8
                k_EMsgGCClientDisplayNotification = 0x430
                k_EMsgGCItemPreviewStatusResponse = 0x6A6
                k_EMsgGCLookupAccountNameResponse = 0x416
                k_EMsgGCStorePurchaseInitResponse = 0x9CF
                k_EMsgGCToGCBannedWordListUpdated = 0x9D3
                k_EMsgGCToGCDirtyMultipleSDOCache = 0x9D5
                k_EMsgGCAddItemToSocket_DEPRECATED = 0x3F6
                k_EMsgGCAddSocketToItem_DEPRECATED = 0x3F9
                k_EMsgGCDev_NewItemRequestResponse = 0x7D2
                k_EMsgGCItemPreviewRequestResponse = 0x6A8
                k_EMsgGCAcknowledgeRentalExpiration = 0x9E7
                k_EMsgGCDeliverGiftResponseReceiver = 0x40C
                k_EMsgGCRecurringSubscriptionStatus = 0x9E2
                k_EMsgGCRemoveCustomTextureResponse = 0x41C
                k_EMsgGCRemoveSocketItem_DEPRECATED = 0x3FD
                k_EMsgGCStorePurchaseCancelResponse = 0x9CB
                k_EMsgGCToGCBannedWordListBroadcast = 0x9D2
                k_EMsgGCToGCBroadcastConsoleCommand = 0x9D9
                k_EMsgGCToGCIsTrustedServerResponse = 0x9D8
                k_EMsgGC_IncrementKillCountResponse = 0x433
                k_EMsgGCCustomizeItemTextureResponse = 0x400
                k_EMsgGCDev_SchemaReservationRequest = 0x7D4
                k_EMsgGCItemAcknowledged__DEPRECATED = 0x426
                k_EMsgGCRequestAnnouncementsResponse = 0x9DE
                k_EMsgGCServerBrowser_FavoriteServer = 0x641
                k_EMsgGCStorePurchaseInit_DEPRECATED = 0x9C6
                k_EMsgGC_IncrementKillCountAttribute = 0x432
                k_EMsgGCItemCustomizationNotification = 0x442
                k_EMsgGCItemPreviewExpireNotification = 0x6AA
                k_EMsgGCServerBrowser_BlacklistServer = 0x642
                k_EMsgGCStorePurchaseFinalizeResponse = 0x9C9
                k_EMsgGCStorePurchaseQueryTxnResponse = 0x9CD
                k_EMsgGC_RevolvingLootList_DEPRECATED = 0x412
                k_EMsgGCAddSocketToBaseItem_DEPRECATED = 0x3F8
                k_EMsgGCRemoveUniqueCraftIndexResponse = 0x420
                k_EMsgGCUserTrackTimePlayedConsecutively = 0x441
                k_EMsgGCItemPreviewItemBoughtNotification = 0x6AB
                k_EMsgGCAddItemToSocketResponse_DEPRECATED = 0x3F7
                k_EMsgGCAddSocketToItemResponse_DEPRECATED = 0x3FA
                k_EMsgGCRemoveSocketItemResponse_DEPRECATED = 0x3FE
                k_EMsgGCStorePurchaseInitResponse_DEPRECATED = 0x9C7
            class EGCToGCMsg:
                k_EGCToGCMsgRouted = 0x98
                k_EGCToGCMsgMasterAck = 0x96
                k_EMsgUpdateSessionIP = 0x9A
                k_EMsgRequestSessionIP = 0x9B
                k_EGCToGCMsgRoutedReply = 0x99
                k_EGCToGCMsgMasterAckResponse = 0x97
                k_EMsgRequestSessionIPResponse = 0x9C
                k_EGCToGCMsgMasterStartupComplete = 0x9D
            class Explosions:
                expRandom = 0x0
                expDirected = 0x1
                expUsePrecise = 0x2
            class HitGroup_t:
                HITGROUP_GEAR = 0xA
                HITGROUP_HEAD = 0x1
                HITGROUP_NECK = 0x8
                HITGROUP_CHEST = 0x2
                HITGROUP_COUNT = 0xC
                HITGROUP_UNUSED = 0x9
                HITGROUP_GENERIC = 0x0
                HITGROUP_INVALID = -0x1
                HITGROUP_LEFTARM = 0x4
                HITGROUP_LEFTLEG = 0x6
                HITGROUP_SPECIAL = 0xB
                HITGROUP_STOMACH = 0x3
                HITGROUP_RIGHTARM = 0x5
                HITGROUP_RIGHTLEG = 0x7
            class MoveType_t:
                MOVETYPE_FLY = 0x3
                MOVETYPE_LAST = 0xB
                MOVETYPE_NONE = 0x0
                MOVETYPE_PUSH = 0x6
                MOVETYPE_WALK = 0x2
                MOVETYPE_CUSTOM = 0xA
                MOVETYPE_LADDER = 0x9
                MOVETYPE_NOCLIP = 0x7
                MOVETYPE_INVALID = 0xB
                MOVETYPE_MAX_BITS = 0x5
                MOVETYPE_OBSERVER = 0x8
                MOVETYPE_OBSOLETE = 0x1
                MOVETYPE_VPHYSICS = 0x5
                MOVETYPE_FLYGRAVITY = 0x4
            class NavDirType:
                EAST = 0x1
                WEST = 0x3
                NORTH = 0x0
                SOUTH = 0x2
                NUM_NAV_DIR_TYPE_DIRECTIONS = 0x4
            class NavScope_t:
                eAir = 0x1
                eCount = 0x2
                eFirst = 0x0
                eGround = 0x0
                eInvalid = 0xFF
            class RenderFx_t:
                kRenderFxMax = 0x11
                kRenderFxNone = 0x0
                kRenderFxFadeIn = 0xF
                kRenderFxFadeOut = 0xE
                kRenderFxFadeFast = 0x6
                kRenderFxFadeSlow = 0x5
                kRenderFxPulseFast = 0x2
                kRenderFxPulseSlow = 0x1
                kRenderFxSolidFast = 0x8
                kRenderFxSolidSlow = 0x7
                kRenderFxStrobeFast = 0xA
                kRenderFxStrobeSlow = 0x9
                kRenderFxFlickerFast = 0xD
                kRenderFxFlickerSlow = 0xC
                kRenderFxStrobeFaster = 0xB
                kRenderFxPulseFastWide = 0x4
                kRenderFxPulseSlowWide = 0x3
                kRenderFxPulseFastWider = 0x10
            class TRAIN_CODE:
                TRAIN_SAFE = 0x0
                TRAIN_BLOCKING = 0x1
                TRAIN_FOLLOWING = 0x2
            class AmmoFlags_t:
                AMMO_FLAG_MAX = 0x2
                AMMO_FORCE_DROP_IF_CARRIED = 0x1
                AMMO_RESERVE_STAYS_WITH_WEAPON = 0x2
            class DIALOG_TYPE:
                DIALOG_MSG = 0x0
                DIALOG_MENU = 0x1
                DIALOG_TEXT = 0x2
                DIALOG_ENTRY = 0x3
                DIALOG_ASKCONNECT = 0x4
            class DoorState_t:
                DOOR_STATE_AJAR = 0x4
                DOOR_STATE_OPEN = 0x2
                DOOR_STATE_CLOSED = 0x0
                DOOR_STATE_CLOSING = 0x3
                DOOR_STATE_OPENING = 0x1
            class EWeaponType:
                EWT_C4 = 0x7
                EWT_Knife = 0x0
                EWT_Rifle = 0x3
                EWT_Pistol = 0x1
                EWT_Grenade = 0x8
                EWT_Shotgun = 0x4
                EWT_Unknown = 0xB
                EWT_Equipment = 0x9
                EWT_MachineGun = 0x6
                EWT_SniperRifle = 0x5
                EWT_StackableItem = 0xA
                EWT_SubMachineGun = 0x2
            class LifeState_t:
                LIFE_DEAD = 0x2
                LIFE_ALIVE = 0x0
                LIFE_DYING = 0x1
                NUM_LIFESTATES = 0x5
                LIFE_RESPAWNING = 0x4
                LIFE_RESPAWNABLE = 0x3
            class MedalRank_t:
                MEDAL_RANK_GOLD = 0x3
                MEDAL_RANK_NONE = 0x0
                MEDAL_RANK_COUNT = 0x4
                MEDAL_RANK_BRONZE = 0x1
                MEDAL_RANK_SILVER = 0x2
            class SolidType_t:
                SOLID_BSP = 0x1
                SOLID_OBB = 0x3
                SOLID_BBOX = 0x2
                SOLID_LAST = 0x9
                SOLID_NONE = 0x0
                SOLID_POINT = 0x5
                SOLID_SPHERE = 0x4
                SOLID_CAPSULE = 0x7
                SOLID_CYLINDER = 0x8
                SOLID_VPHYSICS = 0x6
            class doorCheck_e:
                DOOR_CHECK_FULL = 0x2
                DOOR_CHECK_FORWARD = 0x0
                DOOR_CHECK_BACKWARD = 0x1
            class gear_slot_t:
                GEAR_SLOT_C4 = 0x4
                GEAR_SLOT_LAST = 0xC
                GEAR_SLOT_COUNT = 0xD
                GEAR_SLOT_FIRST = 0x0
                GEAR_SLOT_KNIFE = 0x2
                GEAR_SLOT_RIFLE = 0x0
                GEAR_SLOT_BOOSTS = 0xB
                GEAR_SLOT_PISTOL = 0x1
                GEAR_SLOT_INVALID = -0x1
                GEAR_SLOT_UTILITY = 0xC
                GEAR_SLOT_GRENADES = 0x3
                GEAR_SLOT_RESERVED_SLOT6 = 0x5
                GEAR_SLOT_RESERVED_SLOT7 = 0x6
                GEAR_SLOT_RESERVED_SLOT8 = 0x7
                GEAR_SLOT_RESERVED_SLOT9 = 0x8
                GEAR_SLOT_RESERVED_SLOT10 = 0x9
                GEAR_SLOT_RESERVED_SLOT11 = 0xA
            class CLC_Messages:
                clc_Move = 0x15
                clc_VoiceData = 0x16
                clc_ClientInfo = 0x14
                clc_Diagnostic = 0x25
                clc_HltvReplay = 0x24
                clc_BaselineAck = 0x17
                clc_CmdKeyValues = 0x22
                clc_RequestPause = 0x21
                clc_ServerStatus = 0x1F
                clc_LoadingProgress = 0x1B
                clc_RespondCvarValue = 0x19
                clc_RconServerDetails = 0x23
                clc_SplitPlayerConnect = 0x1C
                clc_SplitPlayerDisconnect = 0x1E
            class CSWeaponMode:
                Primary_Mode = 0x0
                Secondary_Mode = 0x1
                WeaponMode_MAX = 0x2
            class CSWeaponType:
                WEAPONTYPE_C4 = 0x7
                WEAPONTYPE_KNIFE = 0x0
                WEAPONTYPE_RIFLE = 0x3
                WEAPONTYPE_TASER = 0x8
                WEAPONTYPE_PISTOL = 0x1
                WEAPONTYPE_GRENADE = 0x9
                WEAPONTYPE_SHOTGUN = 0x4
                WEAPONTYPE_UNKNOWN = 0xC
                WEAPONTYPE_EQUIPMENT = 0xA
                WEAPONTYPE_MACHINEGUN = 0x6
                WEAPONTYPE_SNIPER_RIFLE = 0x5
                WEAPONTYPE_STACKABLEITEM = 0xB
                WEAPONTYPE_SUBMACHINEGUN = 0x2
            class DecalFlags_t:
                eAll = 0xFFFFFFFF
                eNone = 0x0
                eCannotClear = 0x1
                eAllButCannotClear = 0xFFFFFFFE
                eDecalProjectToBackfaces = 0x2
            class EGCSystemMsg:
                k_EGCMsgMulti = 0x1
                k_EGCMsgInvalid = 0x0
                k_EGCMsgPostAlert = 0x4B
                k_EGCMsgSendEmail = 0x57
                k_EGCMsgWGRequest = 0x39
                k_EGCMsgConCommand = 0x34
                k_EGCMsgSetOptions = 0xE2
                k_EGCMsgSystemBase = 0x32
                k_EGCMsgWGResponse = 0x3A
                k_EGCMsgGetCommands = 0x4E
                k_EGCMsgGetLicenses = 0x4C
                k_EGCMsgStopPlaying = 0x36
                k_EGCMsgSystemBase2 = 0x1F4
                k_EGCMsgFindAccounts = 0x4A
                k_EGCMsgGenericReply = 0xA
                k_EGCMsgGetUserStats = 0x4D
                k_EGCMsgMemCachedGet = 0xC8
                k_EGCMsgMemCachedSet = 0xCA
                k_EGCMsgMultiplexMsg = 0x61
                k_EGCMsgPreTestSetup = 0x45
                k_EGCMsgStartPlaying = 0x35
                k_EGCMsgGetIPLocation = 0x52
                k_EGCMsgReportMetrics = 0x218
                k_EGCMsgUpdateSession = 0x1F7
                k_EGCMsgAddFreeLicense = 0x50
                k_EGCMsgAppInfoUpdated = 0x3F
                k_EGCMsgGetClanDetails = 0x21A
                k_EGCMsgGetSystemStats = 0x55
                k_EGCMsgGrantGuestPass = 0x5B
                k_EGCMsgMemCachedStats = 0xCC
                k_EGCMsgStopGameserver = 0x38
                k_EGCMsgCheckFriendship = 0x1F9
                k_EGCMsgGetPersonaNames = 0x5F
                k_EGCMsgMemCachedDelete = 0xCB
                k_EGCMsgSendHTTPRequest = 0x43
                k_EGCMsgStartGameserver = 0x37
                k_EGCMsgValidateSession = 0x40
                k_EGCMsgGetEmailTemplate = 0x59
                k_EGCMsgWebAPIJobRequest = 0x66
                k_EGCMsgAppCheersReceived = 0x215
                k_EGCMsgGetAccountDetails = 0x5D
                k_EGCMsgInviteUserToLobby = 0x20B
                k_EGCMsgSendEmailResponse = 0x58
                k_EGCMsgSystemStatsSchema = 0x54
                k_EGCMsgAchievementAwarded = 0x33
                k_EGCMsgDPPartnerMicroTxns = 0x200
                k_EGCMsgMasterSetDirectory = 0xDC
                k_EGCMsgSetOptionsResponse = 0xE3
                k_EGCMsgDirectServiceMethod = 0x213
                k_EGCMsgGetCommandsResponse = 0x4F
                k_EGCMsgRecordSupportAction = 0x46
                k_EGCMsgGetUserStatsResponse = 0x3E
                k_EGCMsgMemCachedGetResponse = 0xC9
                k_EGCMsgMultiplexMsgResponse = 0x62
                k_EGCMsgGetIPLocationResponse = 0x53
                k_EGCMsgGetPartnerAccountLink = 0x1FB
                k_EGCMsgReportMetricsResponse = 0x219
                k_EGCMsgVacVerificationChange = 0x206
                k_EGCMsgAddFreeLicenseResponse = 0x51
                k_EGCMsgGetClanDetailsResponse = 0x21B
                k_EGCMsgGetPurchaseTrustStatus = 0x1F5
                k_EGCMsgGetSystemStatsResponse = 0x56
                k_EGCMsgGetUserGameStatsSchema = 0x3B
                k_EGCMsgGetUserStatsDEPRECATED = 0x3D
                k_EGCMsgGrantGuestPassResponse = 0x5C
                k_EGCMsgLookupAccountFromInput = 0x42
                k_EGCMsgMasterSetWebAPIRouting = 0xDE
                k_EGCMsgMemCachedStatsResponse = 0xCD
                k_EGCMsgReceiveInterAppMessage = 0x49
                k_EGCMsgCheckFriendshipResponse = 0x1FA
                k_EGCMsgGetPersonaNamesResponse = 0x60
                k_EGCMsgSendHTTPRequestResponse = 0x44
                k_EGCMsgValidateSessionResponse = 0x41
                k_EGCMsgAccountPhoneNumberChange = 0x207
                k_EGCMsgAppCheersGetAllowedTypes = 0x216
                k_EGCMsgGCAccountVacStatusChange = 0x1F8
                k_EGCMsgGetEmailTemplateResponse = 0x5A
                k_EGCMsgWebAPIRegisterInterfaces = 0x65
                k_EGCMsgGetAccountDetailsResponse = 0x5E
                k_EGCMsgMasterSetClientMsgRouting = 0xE0
                k_EGCMsgDPPartnerMicroTxnsResponse = 0x201
                k_EGCMsgMasterSetDirectoryResponse = 0xDD
                k_EGCMsgDirectServiceMethodResponse = 0x214
                k_EGCMsgGetAccountDetails_DEPRECATED = 0x47
                k_EGCMsgWebAPIJobRequestHttpResponse = 0x68
                k_EGCMsgGetPartnerAccountLinkResponse = 0x1FC
                k_EGCMsgGetPurchaseTrustStatusResponse = 0x1F6
                k_EGCMsgGetUserGameStatsSchemaResponse = 0x3C
                k_EGCMsgMasterSetWebAPIRoutingResponse = 0xDF
                k_EGCMsgWebAPIJobRequestForwardResponse = 0x69
                k_EGCMsgAppCheersGetAllowedTypesResponse = 0x217
                k_EGCMsgGetGamePersonalDataEntriesRequest = 0x20E
                k_EGCMsgMasterSetClientMsgRoutingResponse = 0xE1
                k_EGCMsgRecurringSubscriptionStatusChange = 0x212
                k_EGCMsgGetGamePersonalDataEntriesResponse = 0x20F
                k_EGCMsgGetGamePersonalDataCategoriesRequest = 0x20C
                k_EGCMsgGetGamePersonalDataCategoriesResponse = 0x20D
                k_EGCMsgTerminateGamePersonalDataEntriesRequest = 0x210
                k_EGCMsgTerminateGamePersonalDataEntriesResponse = 0x211
            class EKillTypes_t:
                KILL_BURN = 0x4
                KILL_NONE = 0x0
                KILL_BLAST = 0x3
                KILL_SHOCK = 0x6
                KILL_SLASH = 0x5
                KILL_DEFAULT = 0x1
                KILL_HEADSHOT = 0x2
                KILLTYPE_COUNT = 0x7
            class EUnlockStyle:
                k_UnlockStyle_Succeeded = 0x0
                k_UnlockStyle_Failed_PreReq = 0x1
                k_UnlockStyle_Failed_CantAfford = 0x2
                k_UnlockStyle_Failed_CantCommit = 0x3
                k_UnlockStyle_Failed_CantLockCache = 0x4
                k_UnlockStyle_Failed_CantAffordAttrib = 0x5
            class GLOBALESTATE:
                GLOBAL_ON = 0x1
                GLOBAL_OFF = 0x0
                GLOBAL_DEAD = 0x2
            class NET_Messages:
                net_NOP = 0x0
                net_Tick = 0x4
                net_SetConVar = 0x6
                net_StringCmd = 0x5
                net_SignonState = 0x7
                net_DebugOverlay = 0xF
                net_SpawnGroup_Load = 0x8
                net_SplitScreenUser = 0x3
                net_Disconnect_Legacy = 0x1
                net_SpawnGroup_Unload = 0xC
                net_SpawnGroup_LoadCompleted = 0xD
                net_SpawnGroup_ManifestUpdate = 0x9
                net_SpawnGroup_SetCreationTick = 0xB
            class PrefetchType:
                PFT_SOUND = 0x0
            class RenderMode_t:
                kRenderNone = 0x2
                kRenderNormal = 0x0
                kRenderModeCount = 0x3
                kRenderTransAlpha = 0x1
            class SVC_Messages:
                svc_Menu = 0x39
                svc_Print = 0x30
                svc_Sounds = 0x31
                svc_SetView = 0x32
                svc_BSPDecal = 0x35
                svc_PeerList = 0x3C
                svc_Prefetch = 0x38
                svc_SetPause = 0x2B
                svc_UserCmds = 0x4C
                svc_ClassInfo = 0x2A
                svc_StopSound = 0x3B
                svc_VoiceData = 0x2F
                svc_VoiceInit = 0x2E
                svc_HLTVStatus = 0x3E
                svc_ServerInfo = 0x28
                svc_SplitScreen = 0x36
                svc_UserMessage = 0x48
                svc_CmdKeyValues = 0x34
                svc_GetCvarValue = 0x3A
                svc_EncryptedData = 0x4E
                svc_ServerSteamID = 0x3F
                svc_FullFrameSplit = 0x46
                svc_PacketEntities = 0x37
                svc_PacketReliable = 0x3D
                svc_NextMsgPredicted = 0x4D
                svc_Broadcast_Command = 0x4A
                svc_CreateStringTable = 0x2C
                svc_RconServerDetails = 0x47
                svc_UpdateStringTable = 0x2D
                svc_FlattenedSerializer = 0x29
                svc_ClearAllStringTables = 0x33
                svc_HltvFixupOperatorStatus = 0x4B
            class ShadowType_t:
                SHADOWS_NONE = 0x0
                SHADOWS_SIMPLE = 0x1
            class ShardSolid_t:
                SHARD_SOLID = 0x0
                SHARD_DEBRIS = 0x1
            class StanceType_t:
                NUM_STANCES = 0x3
                STANCE_PRONE = 0x2
                STANCE_CURRENT = -0x1
                STANCE_DEFAULT = 0x0
                STANCE_CROUCHING = 0x1
            class TOGGLE_STATE:
                DOOR_OPEN = 0x0
                TS_AT_TOP = 0x0
                DOOR_CLOSED = 0x1
                TS_GOING_UP = 0x2
                DOOR_CLOSING = 0x3
                DOOR_OPENING = 0x2
                TS_AT_BOTTOM = 0x1
                TS_GOING_DOWN = 0x3
            class WaterLevel_t:
                WL_Feet = 0x1
                WL_Chest = 0x4
                WL_Count = 0x6
                WL_Knees = 0x2
                WL_Waist = 0x3
                WL_NotInWater = 0x0
                WL_FullyUnderwater = 0x5
            class CSPlayerState:
                STATE_ACTIVE = 0x0
                STATE_DORMANT = 0x8
                STATE_WELCOME = 0x1
                STATE_DEATH_ANIM = 0x4
                NUM_PLAYER_STATES = 0x9
                STATE_PICKINGTEAM = 0x2
                STATE_PICKINGCLASS = 0x3
                STATE_OBSERVER_MODE = 0x6
                STATE_GUNGAME_RESPAWN = 0x7
                STATE_DEATH_WAIT_FOR_KEY = 0x5
            class DamageTypes_t:
                DMG_ACID = 0x40000
                DMG_BURN = 0x8
                DMG_CLUB = 0x80
                DMG_FALL = 0x20
                DMG_BLAST = 0x40
                DMG_CRUSH = 0x1
                DMG_DROWN = 0x4000
                DMG_SHOCK = 0x100
                DMG_SLASH = 0x4
                DMG_SONIC = 0x200
                DMG_BULLET = 0x2
                DMG_POISON = 0x8000
                DMG_GENERIC = 0x0
                DMG_VEHICLE = 0x10
                DMG_BUCKSHOT = 0x800
                DMG_DISSOLVE = 0x2000
                DMG_HEADSHOT = 0x80000
                DMG_RADIATION = 0x10000
                DMG_ENERGYBEAM = 0x400
                DMG_DROWNRECOVER = 0x20000
                DMG_BLAST_SURFACE = 0x1000
                DMG_LASTGENERICFLAG = 0x40000
            class Disposition_t:
                D_ER = 0x0
                D_FR = 0x2
                D_HT = 0x1
                D_LI = 0x3
                D_NU = 0x4
                D_FEAR = 0x2
                D_HATE = 0x1
                D_LIKE = 0x3
                D_ERROR = 0x0
                D_NEUTRAL = 0x4
            class EDemoCommands:
                DEM_Max = 0x13
                DEM_Stop = 0x0
                DEM_Error = -0x1
                DEM_Packet = 0x7
                DEM_UserCmd = 0xC
                DEM_FileInfo = 0x2
                DEM_Recovery = 0x12
                DEM_SaveGame = 0xE
                DEM_SyncTick = 0x3
                DEM_ClassInfo = 0x5
                DEM_ConsoleCmd = 0x9
                DEM_CustomData = 0xA
                DEM_FileHeader = 0x1
                DEM_FullPacket = 0xD
                DEM_SendTables = 0x4
                DEM_SpawnGroups = 0xF
                DEM_IsCompressed = 0x40
                DEM_SignonPacket = 0x8
                DEM_StringTables = 0x6
                DEM_AnimationData = 0x10
                DEM_AnimationHeader = 0x11
                DEM_CustomDataCallbacks = 0xB
            class FixAngleSet_t:
                _None = 0x0
                Absolute = 0x1
                Relative = 0x2
            class GrenadeType_t:
                GRENADE_TYPE_FIRE = 0x2
                GRENADE_TYPE_DECOY = 0x3
                GRENADE_TYPE_FLASH = 0x1
                GRENADE_TYPE_SMOKE = 0x4
                GRENADE_TYPE_TOTAL = 0x5
                GRENADE_TYPE_EXPLOSIVE = 0x0
            class MoveCollide_t:
                MOVECOLLIDE_COUNT = 0x4
                MOVECOLLIDE_DEFAULT = 0x0
                MOVECOLLIDE_MAX_BITS = 0x3
                MOVECOLLIDE_FLY_SLIDE = 0x3
                MOVECOLLIDE_FLY_BOUNCE = 0x1
                MOVECOLLIDE_FLY_CUSTOM = 0x2
            class SignonState_t:
                SIGNONSTATE_NEW = 0x3
                SIGNONSTATE_FULL = 0x6
                SIGNONSTATE_NONE = 0x0
                SIGNONSTATE_SPAWN = 0x5
                SIGNONSTATE_PRESPAWN = 0x4
                SIGNONSTATE_CHALLENGE = 0x1
                SIGNONSTATE_CONNECTED = 0x2
                SIGNONSTATE_CHANGELEVEL = 0x7
            class WeaponSound_t:
                WEAPON_SOUND_DROP = 0x16
                WEAPON_SOUND_EMPTY = 0x0
                WEAPON_SOUND_IMPACT = 0xD
                WEAPON_SOUND_RELOAD = 0x11
                WEAPON_SOUND_SINGLE = 0x2
                WEAPON_SOUND_REFLECT = 0xE
                WEAPON_SOUND_ZOOM_IN = 0x13
                WEAPON_SOUND_SPECIAL1 = 0x9
                WEAPON_SOUND_SPECIAL2 = 0xA
                WEAPON_SOUND_SPECIAL3 = 0xB
                WEAPON_SOUND_ZOOM_OUT = 0x14
                WEAPON_SOUND_MELEE_HIT = 0x5
                WEAPON_SOUND_NUM_TYPES = 0x18
                WEAPON_SOUND_RADIO_USE = 0x17
                WEAPON_SOUND_MELEE_MISS = 0x4
                WEAPON_SOUND_NEARLYEMPTY = 0xC
                WEAPON_SOUND_MELEE_HIT_NPC = 0x8
                WEAPON_SOUND_MOUSE_PRESSED = 0x15
                WEAPON_SOUND_MELEE_HIT_WORLD = 0x6
                WEAPON_SOUND_SECONDARY_EMPTY = 0x1
                WEAPON_SOUND_SINGLE_ACCURATE = 0x12
                WEAPON_SOUND_MELEE_HIT_PLAYER = 0x7
                WEAPON_SOUND_SECONDARY_ATTACK = 0x3
                WEAPON_SOUND_SECONDARY_IMPACT = 0xF
                WEAPON_SOUND_SECONDARY_REFLECT = 0x10
            class AmmoPosition_t:
                AMMO_POSITION_COUNT = 0x2
                AMMO_POSITION_INVALID = -0x1
                AMMO_POSITION_PRIMARY = 0x0
                AMMO_POSITION_SECONDARY = 0x1
            class AnimLoopMode_t:
                ANIM_LOOP_MODE_COUNT = 0x3
                ANIM_LOOP_MODE_INVALID = -0x1
                ANIM_LOOP_MODE_LOOPING = 0x1
                ANIM_LOOP_MODE_NOT_LOOPING = 0x0
                ANIM_LOOP_MODE_USE_SEQUENCE_SETTINGS = 0x2
            class CSWeaponNameID:
                WEAPONID_C4 = 0x29
                WEAPONID_AUG = 0xF
                WEAPONID_AWP = 0x1C
                WEAPONID_MP7 = 0x14
                WEAPONID_MP9 = 0x15
                WEAPONID_P90 = 0x16
                WEAPONID_AK47 = 0xA
                WEAPONID_M249 = 0x20
                WEAPONID_M4A1 = 0xB
                WEAPONID_MAG7 = 0x18
                WEAPONID_NOVA = 0x19
                WEAPONID_P250 = 0x6
                WEAPONID_TEC9 = 0x8
                WEAPONID_BIZON = 0x11
                WEAPONID_CZ75A = 0x2
                WEAPONID_DECOY = 0x23
                WEAPONID_ELITE = 0x3
                WEAPONID_FAMAS = 0xD
                WEAPONID_G3SG1 = 0x1E
                WEAPONID_GLOCK = 0x0
                WEAPONID_KNIFE = 0x2B
                WEAPONID_MAC10 = 0x12
                WEAPONID_MP5SD = 0x13
                WEAPONID_NEGEV = 0x21
                WEAPONID_SG556 = 0x10
                WEAPONID_SSG08 = 0x1D
                WEAPONID_TASER = 0x22
                WEAPONID_UMP45 = 0x17
                WEAPONID_DEAGLE = 0x4
                WEAPONID_SCAR20 = 0x1F
                WEAPONID_XM1014 = 0x1B
                WEAPONID_BAYONET = 0x31
                WEAPONID_GALILAR = 0xE
                WEAPONID_HKP2000 = 0x1
                WEAPONID_KNIFE_T = 0x2C
                WEAPONID_MOLOTOV = 0x27
                WEAPONID_UNKNOWN = 0x41
                WEAPONID_REVOLVER = 0x7
                WEAPONID_SAWEDOFF = 0x1A
                WEAPONID_FIVESEVEN = 0x5
                WEAPONID_FLASHBANG = 0x24
                WEAPONID_HEGRENADE = 0x25
                WEAPONID_KNIFE_CSS = 0x2D
                WEAPONID_KNIFE_GUT = 0x2F
                WEAPONID_HEALTHSHOT = 0x2A
                WEAPONID_INCGRENADE = 0x26
                WEAPONID_KNIFE_CORD = 0x38
                WEAPONID_KNIFE_FLIP = 0x2E
                WEAPONID_KNIFE_PUSH = 0x37
                WEAPONID_KNIFE_CANIS = 0x39
                WEAPONID_KNIFE_KUKRI = 0x40
                WEAPONID_KNIFE_URSUS = 0x3A
                WEAPONID_SMOKEGRENADE = 0x28
                WEAPONID_USP_SILENCER = 0x9
                WEAPONID_KNIFE_OUTDOOR = 0x3C
                WEAPONID_M4A1_SILENCER = 0xC
                WEAPONID_KNIFE_FALCHION = 0x34
                WEAPONID_KNIFE_KARAMBIT = 0x30
                WEAPONID_KNIFE_SKELETON = 0x3F
                WEAPONID_KNIFE_STILETTO = 0x3D
                WEAPONID_KNIFE_TACTICAL = 0x33
                WEAPONID_KNIFE_BUTTERFLY = 0x36
                WEAPONID_KNIFE_M9_BAYONET = 0x32
                WEAPONID_KNIFE_WIDOWMAKER = 0x3E
                WEAPONID_KNIFE_SURVIVAL_BOWIE = 0x35
                WEAPONID_KNIFE_GYPSY_JACKKNIFE = 0x3B
            class EClientUIEvent:
                EClientUIEvent_Invalid = 0x0
                EClientUIEvent_FireOutput = 0x2
                EClientUIEvent_DialogFinished = 0x1
            class EGCMsgResponse:
                k_EGCMsgResponseOK = 0x0
                k_EGCMsgLimitExceeded = 0x9
                k_EGCMsgFailedToCreate = 0x8
                k_EGCMsgResponseDenied = 0x1
                k_EGCMsgResponseInvalid = 0x4
                k_EGCMsgResponseNoMatch = 0x5
                k_EGCMsgResponseTimeout = 0x3
                k_EGCMsgCommitUnfinalized = 0xA
                k_EGCMsgResponseNotLoggedOn = 0x7
                k_EGCMsgResponseServerError = 0x2
                k_EGCMsgResponseUnknownError = 0x6
            class EInButtonState:
                IN_BUTTON_UP = 0x0
                IN_BUTTON_DOWN = 0x1
                IN_BUTTON_DOWN_UP = 0x2
                IN_BUTTON_UP_DOWN = 0x3
                IN_BUTTON_UP_DOWN_UP = 0x4
                IN_BUTTON_STATE_COUNT = 0x8
                IN_BUTTON_DOWN_UP_DOWN = 0x5
                IN_BUTTON_DOWN_UP_DOWN_UP = 0x6
                IN_BUTTON_UP_DOWN_UP_DOWN = 0x7
            class ETEProtobufIds:
                TE_DustId = 0x1A4
                TE_FizzId = 0x19D
                TE_DecalId = 0x19A
                TE_SmokeId = 0x1AA
                TE_ImpactId = 0x1A0
                TE_SparksId = 0x1A6
                TE_BubblesId = 0x198
                TE_BeamEntsId = 0x193
                TE_BeamRingId = 0x195
                TE_ExplosionId = 0x1A3
                TE_BeamPointsId = 0x194
                TE_GlowSpriteId = 0x19F
                TE_WorldDecalId = 0x19B
                TE_BloodStreamId = 0x1A2
                TE_BubbleTrailId = 0x199
                TE_LargeFunnelId = 0x1A5
                TE_MuzzleFlashId = 0x1A1
                TE_PhysicsPropId = 0x1A7
                TE_BeamEntPointId = 0x192
                TE_EnergySplashId = 0x19C
                TE_ArmorRicochetId = 0x191
                TE_EffectDispatchId = 0x190
                TE_ShatterSurfaceId = 0x19E
            class InputBitMask_t:
                IN_ALL = -0x1
                IN_USE = 0x20
                IN_BACK = 0x10
                IN_DUCK = 0x4
                IN_JUMP = 0x2
                IN_NONE = 0x0
                IN_ZOOM = 0x400000000
                IN_SCORE = 0x200000000
                IN_SPEED = 0x10000
                IN_ATTACK = 0x1
                IN_RELOAD = 0x2000
                IN_ATTACK2 = 0x800
                IN_FORWARD = 0x8
                IN_MOVELEFT = 0x200
                IN_TURNLEFT = 0x80
                IN_MOVERIGHT = 0x400
                IN_TURNRIGHT = 0x100
                IN_USEORRELOAD = 0x100000000
                IN_JOYAUTOSPRINT = 0x20000
                IN_LOOK_AT_WEAPON = 0x800000000
                IN_FIRST_MOD_SPECIFIC_BIT = 0x100000000
            class ObserverMode_t:
                OBS_MODE_NONE = 0x0
                OBS_MODE_CHASE = 0x3
                OBS_MODE_FIXED = 0x1
                OBS_MODE_IN_EYE = 0x2
                OBS_MODE_ROAMING = 0x4
                NUM_OBSERVER_MODES = 0x5
            class RequestPause_t:
                RP_PAUSE = 0x0
                RP_UNPAUSE = 0x1
                RP_TOGGLEPAUSE = 0x2
            class RumbleEffect_t:
                RUMBLE_357 = 0x2
                RUMBLE_AR2 = 0x4
                RUMBLE_SMG1 = 0x3
                RUMBLE_PISTOL = 0x1
                RUMBLE_DMG_LOW = 0xF
                RUMBLE_DMG_MED = 0x10
                RUMBLE_INVALID = -0x1
                RUMBLE_DMG_HIGH = 0x11
                RUMBLE_STOP_ALL = 0x0
                RUMBLE_FALL_LONG = 0x12
                RUMBLE_FLAT_BOTH = 0xE
                RUMBLE_FLAT_LEFT = 0xC
                RUMBLE_FALL_SHORT = 0x13
                RUMBLE_FLAT_RIGHT = 0xD
                NUM_RUMBLE_EFFECTS = 0x19
                RUMBLE_AIRBOAT_GUN = 0xA
                RUMBLE_RPG_MISSILE = 0x8
                RUMBLE_AR2_ALT_FIRE = 0x7
                RUMBLE_CROWBAR_SWING = 0x9
                RUMBLE_PHYSCANNON_LOW = 0x16
                RUMBLE_SHOTGUN_DOUBLE = 0x6
                RUMBLE_SHOTGUN_SINGLE = 0x5
                RUMBLE_PHYSCANNON_HIGH = 0x18
                RUMBLE_PHYSCANNON_OPEN = 0x14
                RUMBLE_PHYSCANNON_PUNT = 0x15
                RUMBLE_JEEP_ENGINE_LOOP = 0xB
                RUMBLE_PHYSCANNON_MEDIUM = 0x17
            class ShakeCommand_t:
                SHAKE_STOP = 0x1
                SHAKE_START = 0x0
                SHAKE_DURATION = 0x6
                SHAKE_AMPLITUDE = 0x2
                SHAKE_FREQUENCY = 0x3
                SHAKE_START_NORUMBLE = 0x5
                SHAKE_START_RUMBLEONLY = 0x4
            class loadout_slot_t:
                LOADOUT_SLOT_C4 = 0x1
                LOADOUT_SLOT_PET = 0x39
                LOADOUT_SLOT_SMG0 = 0x8
                LOADOUT_SLOT_SMG1 = 0x9
                LOADOUT_SLOT_SMG2 = 0xA
                LOADOUT_SLOT_SMG3 = 0xB
                LOADOUT_SLOT_SMG4 = 0xC
                LOADOUT_SLOT_SMG5 = 0xD
                LOADOUT_SLOT_COUNT = 0x3A
                LOADOUT_SLOT_MELEE = 0x0
                LOADOUT_SLOT_MISC0 = 0x2F
                LOADOUT_SLOT_MISC1 = 0x30
                LOADOUT_SLOT_MISC2 = 0x31
                LOADOUT_SLOT_MISC3 = 0x32
                LOADOUT_SLOT_MISC4 = 0x33
                LOADOUT_SLOT_MISC5 = 0x34
                LOADOUT_SLOT_MISC6 = 0x35
                LOADOUT_SLOT_FLAIR0 = 0x37
                LOADOUT_SLOT_HEAVY0 = 0x14
                LOADOUT_SLOT_HEAVY1 = 0x15
                LOADOUT_SLOT_HEAVY2 = 0x16
                LOADOUT_SLOT_HEAVY3 = 0x17
                LOADOUT_SLOT_HEAVY4 = 0x18
                LOADOUT_SLOT_HEAVY5 = 0x19
                LOADOUT_SLOT_RIFLE0 = 0xE
                LOADOUT_SLOT_RIFLE1 = 0xF
                LOADOUT_SLOT_RIFLE2 = 0x10
                LOADOUT_SLOT_RIFLE3 = 0x11
                LOADOUT_SLOT_RIFLE4 = 0x12
                LOADOUT_SLOT_RIFLE5 = 0x13
                LOADOUT_SLOT_SPRAY0 = 0x38
                LOADOUT_SLOT_INVALID = -0x1
                LOADOUT_SLOT_GRENADE0 = 0x1A
                LOADOUT_SLOT_GRENADE1 = 0x1B
                LOADOUT_SLOT_GRENADE2 = 0x1C
                LOADOUT_SLOT_GRENADE3 = 0x1D
                LOADOUT_SLOT_GRENADE4 = 0x1E
                LOADOUT_SLOT_GRENADE5 = 0x1F
                LOADOUT_SLOT_MUSICKIT = 0x36
                LOADOUT_SLOT_PROMOTED = -0x2
                LOADOUT_SLOT_EQUIPMENT0 = 0x20
                LOADOUT_SLOT_EQUIPMENT1 = 0x21
                LOADOUT_SLOT_EQUIPMENT2 = 0x22
                LOADOUT_SLOT_EQUIPMENT3 = 0x23
                LOADOUT_SLOT_EQUIPMENT4 = 0x24
                LOADOUT_SLOT_EQUIPMENT5 = 0x25
                LOADOUT_SLOT_SECONDARY0 = 0x2
                LOADOUT_SLOT_SECONDARY1 = 0x3
                LOADOUT_SLOT_SECONDARY2 = 0x4
                LOADOUT_SLOT_SECONDARY3 = 0x5
                LOADOUT_SLOT_SECONDARY4 = 0x6
                LOADOUT_SLOT_SECONDARY5 = 0x7
                LOADOUT_SLOT_CLOTHING_HAT = 0x2B
                LOADOUT_SLOT_LAST_COSMETIC = 0x29
                LOADOUT_SLOT_CLOTHING_HANDS = 0x29
                LOADOUT_SLOT_CLOTHING_TORSO = 0x2D
                LOADOUT_SLOT_FIRST_COSMETIC = 0x29
                LOADOUT_SLOT_CLOTHING_EYEWEAR = 0x2A
                LOADOUT_SLOT_CLOTHING_FACEMASK = 0x28
                LOADOUT_SLOT_LAST_WHEEL_WEAPON = 0x19
                LOADOUT_SLOT_CLOTHING_LOWERBODY = 0x2C
                LOADOUT_SLOT_FIRST_WHEEL_WEAPON = 0x2
                LOADOUT_SLOT_LAST_ALL_CHARACTER = 0x39
                LOADOUT_SLOT_LAST_WHEEL_GRENADE = 0x1F
                LOADOUT_SLOT_CLOTHING_APPEARANCE = 0x2E
                LOADOUT_SLOT_CLOTHING_CUSTOMHEAD = 0x27
                LOADOUT_SLOT_FIRST_ALL_CHARACTER = 0x36
                LOADOUT_SLOT_FIRST_WHEEL_GRENADE = 0x1A
                LOADOUT_SLOT_LAST_PRIMARY_WEAPON = 0x19
                LOADOUT_SLOT_FIRST_PRIMARY_WEAPON = 0x8
                LOADOUT_SLOT_LAST_AUTO_BUY_WEAPON = 0x1
                LOADOUT_SLOT_LAST_WHEEL_EQUIPMENT = 0x25
                LOADOUT_SLOT_CLOTHING_CUSTOMPLAYER = 0x26
                LOADOUT_SLOT_FIRST_AUTO_BUY_WEAPON = 0x0
                LOADOUT_SLOT_FIRST_WHEEL_EQUIPMENT = 0x20
            class C4LightEffect_t:
                eLightEffectNone = 0x0
                eLightEffectDropped = 0x1
                eLightEffectThirdPersonHeld = 0x2
            class EBaseGameEvents:
                GE_PlaceDecalEvent = 0xC9
                GE_SosStopSoundEvent = 0xD1
                GE_SosStartSoundEvent = 0xD0
                GE_ClothEffectAnimEvent = 0xD6
                GE_ClearWorldDecalsEvent = 0xCA
                GE_ClothStiffenAnimEvent = 0xD5
                GE_SosStopSoundEventHash = 0xD4
                GE_ClearEntityDecalsEvent = 0xCB
                GE_SosSetSoundEventParams = 0xD2
                GE_Source1LegacyGameEvent = 0xCF
                GE_SosSetLibraryStackFields = 0xD3
                GE_VDebugGameSessionIDEvent = 0xC8
                GE_ClearDecalsForEntityEvent = 0xCC
                GE_Source1LegacyListenEvents = 0xCE
                GE_Source1LegacyGameEventList = 0xCD
            class ECsgoGameEvents:
                GE_FireBulletsId = 0x1C4
                GE_RadioIconEventId = 0x1C3
                GE_PlayerAnimEventId = 0x1C2
                GE_PlayerBulletHitId = 0x1C5
            class EntityEffects_t:
                EF_NODRAW = 0x20
                EF_MAX_BITS = 0xA
                EF_NOSHADOW = 0x10
                EF_NORECEIVESHADOW = 0x40
                EF_PARENT_ANIMATES = 0x200
                DEPRICATED_EF_NOINTERP = 0x8
                EF_NODRAW_BUT_TRANSMIT = 0x400
            class HierarchyType_t:
                HIERARCHY_BONE = 0x4
                HIERARCHY_NONE = 0x0
                HIERARCHY_ABSORIGIN = 0x3
                HIERARCHY_ATTACHMENT = 0x2
                HIERARCHY_BONE_MERGE = 0x1
                HIERARCHY_TYPE_COUNT = 0x5
            class ItemFlagTypes_t:
                ITEM_FLAG_NONE = 0x0
                ITEM_FLAG_EXHAUSTIBLE = 0x10
                ITEM_FLAG_LIMITINWORLD = 0x8
                ITEM_FLAG_NOAUTORELOAD = 0x2
                ITEM_FLAG_NOITEMPICKUP = 0x80
                ITEM_FLAG_NOAMMOPICKUPS = 0x40
                ITEM_FLAG_DOHITLOCATIONDMG = 0x20
                ITEM_FLAG_NOAUTOSWITCHEMPTY = 0x4
                ITEM_FLAG_CAN_SELECT_WITHOUT_AMMO = 0x1
            class NavScopeFlags_t:
                eAir = 0x2
                eAll = 0x3
                eNone = 0x0
                eGround = 0x1
            class eSplinePushType:
                k_eSplinePushAway = 0x1
                k_eSplinePushAlong = 0x0
                k_eSplinePushTowards = 0x2
            class navproperties_t:
                NAV_IGNORE = 0x1
            class soundcommands_t:
                SOUNDCTRL_STOP = 0x2
                SOUNDCTRL_DESTROY = 0x3
                SOUNDCTRL_FADEOUT = 0x4
                SOUNDCTRL_CHANGE_PITCH = 0x1
                SOUNDCTRL_CHANGE_VOLUME = 0x0
            class CSWeaponCategory:
                WEAPONCATEGORY_SMG = 0x3
                WEAPONCATEGORY_COUNT = 0x6
                WEAPONCATEGORY_HEAVY = 0x5
                WEAPONCATEGORY_MELEE = 0x1
                WEAPONCATEGORY_OTHER = 0x0
                WEAPONCATEGORY_RIFLE = 0x4
                WEAPONCATEGORY_SECONDARY = 0x2
            class ChatIgnoreType_t:
                CHAT_IGNORE_ALL = 0x1
                CHAT_IGNORE_NONE = 0x0
                CHAT_IGNORE_TEAM = 0x2
            class EChickenActivity:
                Run = 0x3
                Feed = 0x9
                Idle = 0x0
                Land = 0x5
                Walk = 0x2
                Glide = 0x4
                Panic = 0x6
                Sleep = 0xA
                Squat = 0x1
                Trick = 0x7
                Shoulder = 0xB
                LowOnFood = 0xC
                TurnInPlace = 0x8
            class EGCBaseClientMsg:
                k_EMsgGCClientHello = 0xFA6
                k_EMsgGCServerHello = 0xFA7
                k_EMsgGCClientHelloPW = 0xFAC
                k_EMsgGCClientHelloR2 = 0xFAD
                k_EMsgGCClientHelloR3 = 0xFAE
                k_EMsgGCClientHelloR4 = 0xFAF
                k_EMsgGCClientWelcome = 0xFA4
                k_EMsgGCServerWelcome = 0xFA5
                k_EMsgGCClientHelloPartner = 0xFAB
                k_EMsgGCClientConnectionStatus = 0xFA9
                k_EMsgGCServerConnectionStatus = 0xFAA
            class EHapticPulseType:
                VR_HAND_HAPTIC_PULSE_LIGHT = 0x0
                VR_HAND_HAPTIC_PULSE_MEDIUM = 0x1
                VR_HAND_HAPTIC_PULSE_STRONG = 0x2
            class GCProtoBufMsgSrc:
                GCProtoBufMsgSrc_FromGC = 0x3
                GCProtoBufMsgSrc_FromSystem = 0x1
                GCProtoBufMsgSrc_FromSteamID = 0x2
                GCProtoBufMsgSrc_ReplySystem = 0x4
                GCProtoBufMsgSrc_Unspecified = 0x0
            class HoverPoseFlags_t:
                eNone = 0x0
                eAngles = 0x2
                ePosition = 0x1
            class NavAttributeEnum:
                NAV_MESH_RUN = 0x20
                NAV_MESH_JUMP = 0x2
                NAV_MESH_NONE = 0x0
                NAV_MESH_STOP = 0x10
                NAV_MESH_WALK = 0x40
                NAV_MESH_AVOID = 0x80
                NAV_MESH_STAND = 0x400
                NAV_MESH_STAIRS = 0x1000
                NAV_MESH_NON_ZUP = 0x8000
                NAV_MESH_NO_JUMP = 0x8
                NAV_MESH_NO_MERGE = 0x2000
                NAV_MESH_DONT_HIDE = 0x200
                NAV_MESH_TRANSIENT = 0x100
                NAV_ATTR_LAST_INDEX = 0x3F
                NAV_MESH_NO_HOSTAGES = 0x800
                NAV_MESH_CRAWL_HEIGHT = 0x40000
                NAV_MESH_OBSTACLE_TOP = 0x4000
                NAV_MESH_CROUCH_HEIGHT = 0x10000
                NAV_ATTR_FIRST_GAME_INDEX = 0x13
                NAV_MESH_NON_ZUP_TRANSITION = 0x20000
            class PARTICLE_MESSAGE:
                GAME_PARTICLE_MANAGER_EVENT_CREATE = 0x0
                GAME_PARTICLE_MANAGER_EVENT_FROZEN = 0xC
                GAME_PARTICLE_MANAGER_EVENT_UPDATE = 0x1
                GAME_PARTICLE_MANAGER_EVENT_ADD_FAN = 0x24
                GAME_PARTICLE_MANAGER_EVENT_DESTROY = 0x7
                GAME_PARTICLE_MANAGER_EVENT_LATENCY = 0xA
                GAME_PARTICLE_MANAGER_EVENT_RELEASE = 0x9
                GAME_PARTICLE_MANAGER_EVENT_SET_TEXT = 0x10
                GAME_PARTICLE_MANAGER_EVENT_SET_VDATA = 0x22
                GAME_PARTICLE_MANAGER_EVENT_CAN_FREEZE = 0x19
                GAME_PARTICLE_MANAGER_EVENT_REMOVE_FAN = 0x27
                GAME_PARTICLE_MANAGER_EVENT_UPDATE_ENT = 0x5
                GAME_PARTICLE_MANAGER_EVENT_UPDATE_FAN = 0x25
                GAME_PARTICLE_MANAGER_EVENT_SHOULD_DRAW = 0xB
                GAME_PARTICLE_MANAGER_EVENT_SKIP_TO_TIME = 0x18
                GAME_PARTICLE_MANAGER_EVENT_DESTROY_NAMED = 0x17
                GAME_PARTICLE_MANAGER_EVENT_UPDATE_OFFSET = 0x6
                GAME_PARTICLE_MANAGER_EVENT_UPDATE_FORWARD = 0x2
                GAME_PARTICLE_MANAGER_EVENT_UPDATE_FALLBACK = 0x4
                GAME_PARTICLE_MANAGER_EVENT_FREEZE_INVOLVING = 0x1D
                GAME_PARTICLE_MANAGER_EVENT_UPDATE_TRANSFORM = 0x1B
                GAME_PARTICLE_MANAGER_EVENT_CREATE_SMOKE_GRID = 0x28
                GAME_PARTICLE_MANAGER_EVENT_DESTROY_INVOLVING = 0x8
                GAME_PARTICLE_MANAGER_EVENT_CREATE_PHYSICS_SIM = 0x20
                GAME_PARTICLE_MANAGER_EVENT_SET_CLUSTER_GROWTH = 0x26
                GAME_PARTICLE_MANAGER_EVENT_SET_FOW_PROPERTIES = 0xF
                GAME_PARTICLE_MANAGER_EVENT_UPDATE_ORIENTATION = 0x3
                GAME_PARTICLE_MANAGER_EVENT_DESTROY_PHYSICS_SIM = 0x21
                GAME_PARTICLE_MANAGER_EVENT_SET_OVERRIDE_TEXTURE = 0x29
                GAME_PARTICLE_MANAGER_EVENT_SET_SHOULD_CHECK_FOW = 0x11
                GAME_PARTICLE_MANAGER_EVENT_SET_MATERIAL_OVERRIDE = 0x23
                GAME_PARTICLE_MANAGER_EVENT_SET_TEXTURE_ATTRIBUTE = 0x14
                GAME_PARTICLE_MANAGER_EVENT_UPDATE_ENTITY_POSITION = 0xE
                GAME_PARTICLE_MANAGER_EVENT_SET_CONTROL_POINT_MODEL = 0x12
                GAME_PARTICLE_MANAGER_EVENT_SET_NAMED_VALUE_CONTEXT = 0x1A
                GAME_PARTICLE_MANAGER_EVENT_CLEAR_MODELLIST_OVERRIDE = 0x1F
                GAME_PARTICLE_MANAGER_EVENT_FREEZE_TRANSITION_OVERRIDE = 0x1C
                GAME_PARTICLE_MANAGER_EVENT_SET_CONTROL_POINT_SNAPSHOT = 0x13
                GAME_PARTICLE_MANAGER_EVENT_SET_SCENE_OBJECT_GENERIC_FLAG = 0x15
                GAME_PARTICLE_MANAGER_EVENT_ADD_MODELLIST_OVERRIDE_ELEMENT = 0x1E
                GAME_PARTICLE_MANAGER_EVENT_CHANGE_CONTROL_POINT_ATTACHMENT = 0xD
                GAME_PARTICLE_MANAGER_EVENT_SET_SCENE_OBJECT_TINT_AND_DESAT = 0x16
            class BrushSolidities_e:
                BRUSHSOLID_NEVER = 0x1
                BRUSHSOLID_ALWAYS = 0x2
                BRUSHSOLID_TOGGLE = 0x0
            class CanPlaySequence_t:
                CANNOT_PLAY = 0x0
                CAN_PLAY_NOW = 0x1
                CAN_PLAY_ENQUEUED = 0x2
            class EBaseUserMessages:
                UM_Fade = 0x6A
                UM_Shake = 0x78
                UM_HudMsg = 0x6E
                UM_Rumble = 0x74
                UM_HudText = 0x6F
                UM_SayText = 0x75
                UM_TextMsg = 0x7C
                UM_HudError = 0x92
                UM_MAX_BASE = 0xC8
                UM_ResetHUD = 0x73
                UM_SayText2 = 0x76
                UM_ShakeDir = 0x79
                UM_ShowMenu = 0x86
                UM_GameTitle = 0x6B
                UM_SendAudio = 0x82
                UM_VoiceMask = 0x80
                UM_AmmoDenied = 0x84
                UM_CreditsMsg = 0x87
                UM_ItemPickup = 0x83
                UM_ScreenTilt = 0x7D
                UM_WaterShake = 0x7A
                UM_ColoredText = 0x71
                UM_UsageReport = 0xA8
                UM_RequestState = 0x72
                UM_ExtraUserData = 0xA4
                UM_AudioParameter = 0x90
                UM_SayTextChannel = 0x77
                UM_UserSentBugBug = 0xA7
                UM_AnimGraphUpdate = 0x95
                UM_CustomGameEvent = 0x94
                UM_ParticleManager = 0x91
                UM_ServerFrameTime = 0x9A
                UM_AchievementEvent = 0x65
                UM_CameraTransition = 0x8F
                UM_CurrentTimescale = 0x68
                UM_DesiredTimescale = 0x69
                UM_RequestDllStatus = 0x9C
                UM_RequestInventory = 0xA0
                UM_UpdateCssClasses = 0x99
                UM_DllStatusResponse = 0x9F
                UM_InventoryResponse = 0xA1
                UM_RequestDiagnostic = 0xA2
                UM_RequestUtilAction = 0x9D
                UM_DiagnosticResponse = 0xA3
                UM_UtilActionResponse = 0x9E
                UM_HapticsManagerPulse = 0x96
                UM_NotifyResponseFound = 0xA5
                UM_RemoteServerCommand = 0xA9
                UM_HapticsManagerEffect = 0x97
                UM_LagCompensationError = 0x9B
                UM_RemoteServerResponse = 0xAA
                UM_CloseCaptionPlaceholder = 0x8E
                UM_PlayResponseConditional = 0xA6
            class EntFinderMethod_t:
                ENT_FIND_METHOD_RANDOM = 0x2
                ENT_FIND_METHOD_NEAREST = 0x0
                ENT_FIND_METHOD_FARTHEST = 0x1
            class GC_BannedWordType:
                GC_BANNED_WORD_ENABLE_WORD = 0x1
                GC_BANNED_WORD_DISABLE_WORD = 0x0
            class PerformanceMode_t:
                PM_NORMAL = 0x0
                PM_NO_GIBS = 0x1
            class ReplayEventType_t:
                REPLAY_EVENT_DEATH = 0x1
                REPLAY_EVENT_CANCEL = 0x0
                REPLAY_EVENT_GENERIC = 0x2
                REPLAY_EVENT_VICTORY = 0x4
                REPLAY_EVENT_STUCK_NEED_FULL_UPDATE = 0x3
            class ScriptedOnDeath_t:
                SS_ONDEATH_RAGDOLL = 0x1
                SS_ONDEATH_UNDEFINED = 0x0
                SS_ONDEATH_ANIMATED_DEATH = 0x2
                SS_ONDEATH_NOT_APPLICABLE = -0x1
            class SpawnGroupFlags_t:
                SPAWN_GROUP_SYNCHRONOUS_SPAWN = 0x4
                SPAWN_GROUP_BLOCK_UNTIL_LOADED = 0x40
                SPAWN_GROUP_DONT_SPAWN_ENTITIES = 0x2
                SPAWN_GROUP_LOAD_STREAMING_DATA = 0x80
                SPAWN_GROUP_CREATE_NEW_SCENE_WORLD = 0x100
                SPAWN_GROUP_IS_INITIAL_SPAWN_GROUP = 0x8
                SPAWN_GROUP_LOAD_ENTITIES_FROM_SAVE = 0x1
                SPAWN_GROUP_CREATE_CLIENT_ONLY_ENTITIES = 0x10
            class TakeDamageFlags_t:
                DFLAG_NONE = 0x0
                DMG_LASTDFLAG = 0x20000
                DFLAG_NEVER_GIB = 0x40
                DFLAG_ALWAYS_GIB = 0x20
                DFLAG_RADIUS_DMG = 0x400
                DFLAG_FORCE_DEATH = 0x10
                DFLAG_IGNORE_ARMOR = 0x40000
                DFLAG_PREVENT_DEATH = 0x8
                DFLAG_SUPPRESS_EFFECTS = 0x4
                DFLAG_REMOVE_NO_RAGDOLL = 0x80
                DFLAG_FORCE_PHYSICS_FORCE = 0x8000
                DFLAG_SUPPRESS_BREAKABLES = 0x4000
                DFLAG_SUPPRESS_UTILREMOVE = 0x80000
                DFLAG_FORCEREDUCEARMOR_DMG = 0x800
                DFLAG_SUPPRESS_PHYSICS_FORCE = 0x2
                DFLAG_ALLOW_NON_AUTHORITATIVE = 0x20000
                DFLAG_SUPPRESS_HEALTH_CHANGES = 0x1
                DFLAG_ALWAYS_FIRE_DAMAGE_EVENTS = 0x200
                DFLAG_IGNORE_DESTRUCTIBLE_PARTS = 0x2000
                DFLAG_SUPPRESS_INTERRUPT_FLINCH = 0x1000
                DFLAG_SUPPRESS_DAMAGE_MODIFICATION = 0x100
                DFLAG_SUPPRESS_SCREENSPACE_DAMAGE_FX = 0x10000
            class VoiceDataFormat_t:
                VOICEDATA_FORMAT_OPUS = 0x2
                VOICEDATA_FORMAT_STEAM = 0x0
                VOICEDATA_FORMAT_ENGINE = 0x1
            class BodySectionMutex_t:
                eNone = 0x0
                eFullBody = 0x3
                eLowerBody = 0x1
                eUpperBody = 0x2
            class CFuncMover__Move_t:
                MOVE_LOOP = 0x0
                MOVE_OSCILLATE = 0x1
                MOVE_STOP_AT_END = 0x2
            class ChoreoLookAtMode_t:
                eHead = 0x1
                eChest = 0x0
                eInvalid = -0x1
                eEyesOnly = 0x2
            class ChoreoStrafeMode_t:
                ENABLE = 0x1
                DEFAULT = 0x0
                DISABLE = 0x2
            class CustomCameraMode_t:
                CUSTOM_CAMERA_MODE_DISABLED = 0x0
                CUSTOM_CAMERA_MODE_CONTROLLED = 0x1
                CUSTOM_CAMERA_MODE_FOLLOW_POSITION = 0x3
                CUSTOM_CAMERA_MODE_CONTROLLED_POSITION = 0x2
            class DebugOverlayBits_t:
                OVERLAY_BBOX_BIT = 0x4
                OVERLAY_NAME_BIT = 0x2
                OVERLAY_RBOX_BIT = 0x40
                OVERLAY_TEXT_BIT = 0x1
                OVERLAY_PIVOT_BIT = 0x8
                OVERLAY_ABSBOX_BIT = 0x20
                OVERLAY_HITBOX_BIT = 0x4000
                OVERLAY_PROP_DEBUG = 0x200000000
                OVERLAY_VIEWOFFSET = 0x800000000
                OVERLAY_AUTOAIM_BIT = 0x10000
                OVERLAY_BUDDHA_MODE = 0x40000000
                OVERLAY_MESSAGE_BIT = 0x10
                OVERLAY_MINIMAL_TEXT = 0x20000000000
                OVERLAY_NPC_GOD_MODE = 0x40000000000
                OVERLAY_NPC_KILL_BIT = 0x10000000
                OVERLAY_NPC_TASK_BIT = 0x2000000
                OVERLAY_SKELETON_BIT = 0x800
                OVERLAY_ACTORNAME_BIT = 0x4000000000
                OVERLAY_NPC_ROUTE_BIT = 0x80000
                OVERLAY_JOINT_INFO_BIT = 0x40000
                OVERLAY_NPC_COMBAT_BIT = 0x1000000
                OVERLAY_SHOW_BLOCKSLOS = 0x80
                OVERLAY_ATTACHMENTS_BIT = 0x100
                OVERLAY_NPC_ENEMIES_BIT = 0x400000
                OVERLAY_NPC_RELATION_BIT = 0x400000000
                OVERLAY_NPC_SELECTED_BIT = 0x20000
                OVERLAY_NPC_VIEWCONE_BIT = 0x8000000
                OVERLAY_NPC_BODYLOCATIONS = 0x4000000
                OVERLAY_NPC_TASK_TEXT_BIT = 0x100000000
                OVERLAY_NPC_CONDITIONS_BIT = 0x800000
                OVERLAY_TRIGGER_BOUNDS_BIT = 0x2000
                OVERLAY_NPC_PATH_QUERIES_BIT = 0x100000000000
                OVERLAY_VISIBILITY_TRACES_BIT = 0x100000
                OVERLAY_INTERPOLATED_PIVOT_BIT = 0x400
                OVERLAY_VCOLLIDE_WIREFRAME_BIT = 0x1000000000
                OVERLAY_INTERPOLATED_HITBOX_BIT = 0x8000
                OVERLAY_NPC_CONDITIONS_TEXT_BIT = 0x8000000000
                OVERLAY_NPC_STEERING_REGULATIONS = 0x80000000
                OVERLAY_INTERPOLATED_SKELETON_BIT = 0x1000
                OVERLAY_NPC_SCRIPTED_COMMANDS_BIT = 0x2000000000
                OVERLAY_NPC_ANIM_AI_HANDSHAKES_BIT = 0x80000000000
                OVERLAY_NPC_ABILITY_RANGE_DEBUG_BIT = 0x10000000000
                OVERLAY_INTERPOLATED_ATTACHMENTS_BIT = 0x200
            class ECsgoSteamUserStat:
                k_ECsgoSteamUserStat_XpEarnedGames = 0x1
                k_ECsgoSteamUserStat_SurvivedDangerZone = 0x3
                k_ECsgoSteamUserStat_MatchWinsCompetitive = 0x2
            class FuncDoorSpawnPos_t:
                FUNC_DOOR_SPAWN_OPEN = 0x1
                FUNC_DOOR_SPAWN_CLOSED = 0x0
            class GCConnectionStatus:
                GCConnectionStatus_NO_STEAM = 0x4
                GCConnectionStatus_NO_SESSION = 0x2
                GCConnectionStatus_HAVE_SESSION = 0x0
                GCConnectionStatus_GC_GOING_DOWN = 0x1
                GCConnectionStatus_NO_SESSION_IN_LOGON_QUEUE = 0x3
            class PreviewWeaponState:
                ICON = 0x5
                DROPPED = 0x0
                INSPECT = 0x4
                PLANTED = 0x3
                DEPLOYED = 0x2
                HOLSTERED = 0x1
            class ShatterDamageCause:
                SHATTERDAMAGE_MELEE = 0x1
                SHATTERDAMAGE_BULLET = 0x0
                SHATTERDAMAGE_SCRIPT = 0x3
                SHATTERDAMAGE_THROWN = 0x2
                SHATTERDAMAGE_EXPLOSIVE = 0x4
            class WeaponAttackType_t:
                eCount = 0x2
                eInvalid = -0x1
                ePrimary = 0x0
                eSecondary = 0x1
            class ChoreoLookAtSpeed_t:
                eFast = 0x2
                eSlow = 0x0
                eMedium = 0x1
                eInvalid = -0x1
            class EBaseClientMessages:
                CM_MAX_BASE = 0x12C
                CM_RotateAnchor = 0x11D
                CM_ClientUIEvent = 0x11A
                CM_CustomGameEvent = 0x118
                CM_CustomGameEventBounce = 0x119
                CM_DevPaletteVisibilityChanged = 0x11B
                CM_WorldUIControllerHasPanelChanged = 0x11C
            class EBaseEntityMessages:
                EM_DoSpark = 0x8C
                EM_FixAngle = 0x8D
                EM_PlayJingle = 0x88
                EM_ScreenOverlay = 0x89
                EM_PropagateForce = 0x8B
            class ECSPredictionEvents:
                CSPE_DamageTag = 0x1
                CSPE_PlayerTeleport = 0x3
            class ECommunityItemClass:
                k_ECommunityItemClass_Badge = 0x1
                k_ECommunityItemClass_Scene = 0x9
                k_ECommunityItemClass_GameGoo = 0x7
                k_ECommunityItemClass_Invalid = 0x0
                k_ECommunityItemClass_Emoticon = 0x4
                k_ECommunityItemClass_GameCard = 0x2
                k_ECommunityItemClass_Consumable = 0x6
                k_ECommunityItemClass_SalienItem = 0xA
                k_ECommunityItemClass_BoosterPack = 0x5
                k_ECommunityItemClass_ProfileModifier = 0x8
                k_ECommunityItemClass_ProfileBackground = 0x3
            class EOverrideBlockLOS_t:
                BLOCK_LOS_DEFAULT = 0x0
                BLOCK_LOS_FORCE_TRUE = 0x2
                BLOCK_LOS_FORCE_FALSE = 0x1
            class ForcedCrouchState_t:
                FORCEDCROUCH_NONE = 0x0
                FORCEDCROUCH_CROUCHED = 0x1
                FORCEDCROUCH_UNCROUCHED = 0x2
            class PulseNPCCondition_t:
                COND_SEE_PLAYER = 0x1
                COND_HEAR_PLAYER = 0x3
                COND_LOST_PLAYER = 0x2
                COND_PLAYER_PUSHING = 0x4
                COND_NO_PRIMARY_AMMO = 0x5
            class RadiusDmgOverride_t:
                RADIUS_DMG_OVERRIDE_NONE = 0x0
                RADIUS_DMG_OVERRIDE_POSITION_ONLY = 0x1
                RADIUS_DMG_OVERRIDE_POSITION_SKIP_TRACES = 0x2
            class TrainVelocityType_t:
                TrainVelocity_LinearBlend = 0x1
                TrainVelocity_EaseInEaseOut = 0x2
                TrainVelocity_Instantaneous = 0x0
            class AnimationAlgorithm_t:
                eNone = 0x0
                eCount = 0x4
                eInvalid = -0x1
                eSequence = 0x1
                eAnimGraph2 = 0x2
                eAnimGraph2Secondary = 0x3
            class CSWeaponSilencerType:
                WEAPONSILENCER_NONE = 0x0
                WEAPONSILENCER_DETACHABLE = 0x1
                WEAPONSILENCER_INTEGRATED = 0x2
            class EProtoDebugVisiblity:
                k_EProtoDebugVisibility_GC = 0x5A
                k_EProtoDebugVisibility_Never = 0x64
                k_EProtoDebugVisibility_Always = 0x0
                k_EProtoDebugVisibility_Server = 0x46
                k_EProtoDebugVisibility_ValveServer = 0x50
            class EntityDissolveType_t:
                ENTITY_DISSOLVE_CORE = 0x3
                ENTITY_DISSOLVE_NORMAL = 0x0
                ENTITY_DISSOLVE_INVALID = -0x1
                ENTITY_DISSOLVE_ELECTRICAL = 0x1
                ENTITY_DISSOLVE_ELECTRICAL_LIGHT = 0x2
            class EntityDistanceMode_t:
                eAxisToAxis = 0x2
                eCenterToCenter = 0x1
                eOriginToOrigin = 0x0
            class GCClientLauncherType:
                GCClientLauncherType_DEFAULT = 0x0
                GCClientLauncherType_SOURCE2 = 0x3
                GCClientLauncherType_STEAMCHINA = 0x2
                GCClientLauncherType_PERFECTWORLD = 0x1
            class GameAnimEventIndex_t:
                AE_COUNT = 0x2F
                AE_EMPTY = 0x0
                AE_FOOTSTEP = 0xC
                AE_SV_IKLOCK = 0x16
                AE_FIRE_INPUT = 0x10
                AE_PULSE_GRAPH = 0x17
                AE_CL_EJECT_MAG = 0x2B
                AE_CL_PLAYSOUND = 0x1
                AE_CL_STOPSOUND = 0x5
                AE_SV_PLAYSOUND = 0x4
                AE_CL_CLOTH_ATTR = 0x11
                AE_CL_CLOTH_EFFECT = 0x14
                AE_CL_CLOTH_STIFFEN = 0x13
                AE_DISABLE_PLATFORM = 0x18
                AE_BODYGROUP_SET_VALUE = 0xE
                AE_WPN_COMPLETE_RELOAD = 0x2C
                AE_CL_PLAYSOUND_LOOPING = 0x6
                AE_SCRIPT_FIRE_EVENT_01 = 0x1E
                AE_SCRIPT_FIRE_EVENT_02 = 0x1F
                AE_SCRIPT_FIRE_EVENT_03 = 0x20
                AE_SCRIPT_FIRE_EVENT_04 = 0x21
                AE_SCRIPT_FIRE_EVENT_05 = 0x22
                AE_SCRIPT_FIRE_EVENT_06 = 0x23
                AE_SCRIPT_FIRE_EVENT_07 = 0x24
                AE_SCRIPT_FIRE_EVENT_08 = 0x25
                AE_SCRIPT_FIRE_EVENT_09 = 0x26
                AE_SCRIPT_FIRE_EVENT_10 = 0x27
                AE_CL_PLAYSOUND_POSITION = 0x3
                AE_VEHICLE_EXIT_FINISHED = 0x1D
                AE_WEAPON_PERFORM_ATTACK = 0xF
                AE_WPN_HEALTHSHOT_INJECT = 0x2D
                AE_CL_CLOTH_GROUND_OFFSET = 0x12
                AE_GRENADE_THROW_COMPLETE = 0x2E
                AE_VEHICLE_ENTER_FINISHED = 0x1C
                AE_CL_PLAYSOUND_ATTACHMENT = 0x2
                AE_CL_STOP_PARTICLE_EFFECT = 0x8
                AE_CL_STOP_RAGDOLL_CONTROL = 0xD
                AE_SV_STOP_PARTICLE_EFFECT = 0xB
                AE_CL_CREATE_ANIM_SCOPE_PROP = 0x15
                AE_CL_CREATE_PARTICLE_EFFECT = 0x7
                AE_DESTRUCTIBLE_PART_DESTROY = 0x1B
                AE_SV_ATTACH_SILENCER_COMPLETE = 0x29
                AE_SV_DETACH_SILENCER_COMPLETE = 0x2A
                AE_CL_CREATE_PARTICLE_EFFECT_CFG = 0x9
                AE_SV_CREATE_PARTICLE_EFFECT_CFG = 0xA
                AE_CL_WEAPON_TRANSITION_INTO_HAND = 0x28
                AE_ENABLE_PLATFORM_PLAYER_FOLLOWS_YAW = 0x19
                AE_ENABLE_PLATFORM_PLAYER_IGNORES_YAW = 0x1A
            class ModifyDamageReturn_t:
                CONTINUE_TO_APPLY_DAMAGE = 0x0
                ABORT_DO_NOT_APPLY_DAMAGE = 0x1
            class MoveMountingAmount_t:
                MOVE_MOUNT_LOW = 0x1
                MOVE_MOUNT_HIGH = 0x2
                MOVE_MOUNT_NONE = 0x0
                MOVE_MOUNT_MAXCOUNT = 0x3
            class NPCFollowFormation_t:
                Default = -0x1
                Sidekick = 0x6
                WideCircle = 0x1
                CloseCircle = 0x0
                MediumCircle = 0x5
            class PlayerConnectedState:
                Reserved = 0x5
                Connected = 0x0
                Connecting = 0x1
                Disconnected = 0x4
                Reconnecting = 0x2
                Disconnecting = 0x3
                NeverConnected = -0x1
            class PreviewCharacterMode:
                BANNER = 0xA
                DIORAMA = 0x0
                INVALID = -0x1
                WALKING = 0x6
                BUY_MENU = 0x2
                MAIN_MENU = 0x1
                RUSH_INTRO = 0x9
                TEAM_INTRO = 0x7
                TEAM_SELECT = 0x3
                END_OF_MATCH = 0x4
                WINGMAN_INTRO = 0x8
                CHICK_SNAPSHOT = 0xB
                CHICK_VIEWMODEL = 0xC
                INVENTORY_INSPECT = 0x5
            class PulseTraceContents_t:
                SOLID = 0x1
                STATIC_LEVEL = 0x0
            class SceneOnPlayerDeath_t:
                SCENE_ONPLAYERDEATH_CANCEL = 0x1
                SCENE_ONPLAYERDEATH_DO_NOTHING = 0x0
            class WeaponSwitchReason_t:
                eDrawn = 0x0
                eEquipped = 0x1
                eUserInitiatedUIKeyPress = 0x3
                eUserInitiatedSwitchHands = 0x4
                eUserInitiatedSwitchToLast = 0x2
            class vote_create_failed_t:
                VOTE_FAILED_MAX = 0x22
                VOTE_FAILED_GENERIC = 0x0
                VOTE_FAILED_REMATCH = 0x20
                VOTE_FAILED_CONTINUE = 0x21
                VOTE_FAILED_DISABLED = 0x15
                VOTE_FAILED_SPECTATOR = 0xE
                VOTE_FAILED_MATCH_PAUSED = 0x18
                VOTE_FAILED_MAP_NOT_FOUND = 0x6
                VOTE_FAILED_NEXTLEVEL_SET = 0x16
                VOTE_FAILED_NOT_IN_WARMUP = 0x1A
                VOTE_FAILED_RATE_EXCEEDED = 0x2
                VOTE_FAILED_CANT_ROUND_END = 0x1F
                VOTE_FAILED_ISSUE_DISABLED = 0x5
                VOTE_FAILED_NOT_10_PLAYERS = 0x1B
                VOTE_FAILED_PLAYERNOTFOUND = 0xB
                VOTE_FAILED_QUORUM_FAILURE = 0x4
                VOTE_FAILED_TEAM_CANT_CALL = 0x9
                VOTE_FAILED_TIMEOUT_ACTIVE = 0x1C
                VOTE_FAILED_FAILED_RECENTLY = 0x8
                VOTE_FAILED_MATCH_NOT_PAUSED = 0x19
                VOTE_FAILED_SWAP_IN_PROGRESS = 0x14
                VOTE_FAILED_TIMEOUT_INACTIVE = 0x1D
                VOTE_FAILED_CANNOT_KICK_ADMIN = 0xC
                VOTE_FAILED_MAP_NAME_REQUIRED = 0x7
                VOTE_FAILED_TIMEOUT_EXHAUSTED = 0x1E
                VOTE_FAILED_WAITINGFORPLAYERS = 0xA
                VOTE_FAILED_FAILED_RECENT_KICK = 0xF
                VOTE_FAILED_YES_MUST_EXCEED_NO = 0x3
                VOTE_FAILED_TOO_EARLY_SURRENDER = 0x17
                VOTE_FAILED_SCRAMBLE_IN_PROGRESS = 0xD
                VOTE_FAILED_FAILED_RECENT_RESTART = 0x13
                VOTE_FAILED_TRANSITIONING_PLAYERS = 0x1
                VOTE_FAILED_FAILED_RECENT_CHANGEMAP = 0x10
                VOTE_FAILED_FAILED_RECENT_SWAPTEAMS = 0x11
                VOTE_FAILED_FAILED_RECENT_SCRAMBLETEAMS = 0x12
            class EBasePredictionEvents:
                BPE_Teleport = 0x82
                BPE_Diagnostic = 0x4000
                BPE_StringCommand = 0x80
            class EQueryCvarValueStatus:
                eQueryCvarValueStatus_NotACvar = 0x2
                eQueryCvarValueStatus_ValueIntact = 0x0
                eQueryCvarValueStatus_CvarNotFound = 0x1
                eQueryCvarValueStatus_CvarProtected = 0x3
            class EntityPlatformTypes_t:
                ENTITY_NOT_PLATFORM = 0x0
                ENTITY_PLATFORM_PLAYER_FOLLOWS_YAW = 0x1
                ENTITY_PLATFORM_PLAYER_IGNORES_YAW = 0x2
            class EntitySubclassScope_t:
                SUBCLASS_SCOPE_NONE = -0x1
                SUBCLASS_SCOPE_COUNT = 0x2
                SUBCLASS_SCOPE_PRECIPITATION = 0x0
                SUBCLASS_SCOPE_PLAYER_WEAPONS = 0x1
            class ObserverInterpState_t:
                OBSERVER_INTERP_NONE = 0x0
                OBSERVER_INTERP_SETTLING = 0x3
                OBSERVER_INTERP_STARTING = 0x1
                OBSERVER_INTERP_TRAVELING = 0x2
            class PreviewEOMCelebration:
                MASK_F = 0x6
                WALKUP = 0x0
                INVALID = -0x1
                STRETCH = 0x4
                SWAGGER = 0x2
                DROPDOWN = 0x3
                GUERILLA = 0x7
                PUNCHING = 0x1
                AVA_DEFEAT = 0xC
                GUERILLA02 = 0x8
                MAE_DEFEAT = 0xE
                SCUBA_MALE = 0xB
                GENDARMERIE = 0x9
                SWAT_FEMALE = 0x5
                VYPA_DEFEAT = 0x16
                SCUBA_FEMALE = 0xA
                DARRYL_DEFEAT = 0x13
                DOCTOR_DEFEAT = 0x14
                MUHLIK_DEFEAT = 0x15
                RICKSAW_DEFEAT = 0xF
                CRASSWATER_DEFEAT = 0x12
                SCUBA_MALE_DEFEAT = 0x11
                GENDARMERIE_DEFEAT = 0xD
                SCUBA_FEMALE_DEFEAT = 0x10
            class PulseCollisionGroup_t:
                DEFAULT = 0x0
            class PulseMethodCallMode_t:
                ASYNC_FIRE_AND_FORGET = 0x1
                SYNC_WAIT_FOR_COMPLETION = 0x0
            class QuestProgress__Reason:
                QUEST_OK = 0x1
                QUEST_WARMUP = 0x3
                QUEST_NO_QUEST = 0x7
                QUEST_WRONG_MAP = 0x9
                QUEST_REASON_MAX = 0xC
                QUEST_WRONG_MODE = 0xA
                QUEST_PLAYER_IS_BOT = 0x8
                QUEST_NONINITIALIZED = 0x0
                QUEST_NO_ENTITLEMENT = 0x6
                QUEST_NONOFFICIAL_SERVER = 0x5
                QUEST_NOT_ENOUGH_PLAYERS = 0x2
                QUEST_NOT_CONNECTED_TO_STEAM = 0x4
                QUEST_NOT_SYNCED_WITH_SERVER = 0xB
            class SoundEventStartType_t:
                SOUNDEVENT_START_WORLD = 0x1
                SOUNDEVENT_START_ENTITY = 0x2
                SOUNDEVENT_START_PLAYER = 0x0
            class TimelineCompression_t:
                TIMELINE_COMPRESSION_SUM = 0x0
                TIMELINE_COMPRESSION_TOTAL = 0x4
                TIMELINE_COMPRESSION_AVERAGE = 0x2
                TIMELINE_COMPRESSION_AVERAGE_BLEND = 0x3
                TIMELINE_COMPRESSION_COUNT_PER_INTERVAL = 0x1
            class Bidirectional_Messages:
                bi_PredictionEvent = 0x13
                bi_RebroadcastSource = 0x11
                bi_GameEvent_DEPRECATED = 0x12
                bi_RebroadcastGameEvent = 0x10
            class CFuncRotator__Rotate_t:
                ROTATE_LOOP = 0x0
                ROTATE_OSCILLATE = 0x1
                ROTATE_STOP_AT_END = 0x2
                ROTATE_LOOK_AT_TARGET = 0x3
                ROTATE_LOOK_AT_TARGET_ONLY_YAW = 0x4
                ROTATE_LOOK_AT_TARGET_ONLY_PITCH = 0x5
                ROTATE_RETURN_TO_INITIAL_ORIENTATION = 0x6
            class ChoreoScriptedMoveTo_t:
                eWait = 0x0
                eTeleport = 0x2
                eWaitFacing = 0x3
                eMoveWithGait = 0x1
            class ECstrike15UserMessages:
                CS_UM_Fade = 0x139
                CS_UM_SSUI = 0x174
                CS_UM_Shake = 0x138
                CS_UM_Train = 0x12F
                CS_UM_Damage = 0x141
                CS_UM_Geiger = 0x12E
                CS_UM_HudMsg = 0x134
                CS_UM_Rumble = 0x13A
                CS_UM_BarTime = 0x163
                CS_UM_HudText = 0x130
                CS_UM_KillCam = 0x14A
                CS_UM_HintText = 0x143
                CS_UM_ItemDrop = 0x167
                CS_UM_RawAudio = 0x13E
                CS_UM_ResetHud = 0x135
                CS_UM_ShowMenu = 0x162
                CS_UM_VGUIMenu = 0x12D
                CS_UM_VotePass = 0x15B
                CS_UM_XRankGet = 0x154
                CS_UM_XRankUpd = 0x155
                CS_UM_XpUpdate = 0x16D
                CS_UM_DeepStats = 0x17D
                CS_UM_GameTitle = 0x136
                CS_UM_RadioText = 0x142
                CS_UM_ReportHit = 0x16C
                CS_UM_SendAudio = 0x13D
                CS_UM_ShootInfo = 0x17F
                CS_UM_VoiceMask = 0x13F
                CS_UM_VoteSetup = 0x15D
                CS_UM_VoteStart = 0x15A
                CS_UM_AmmoDenied = 0x164
                CS_UM_ClientInfo = 0x153
                CS_UM_ItemPickup = 0x161
                CS_UM_VoteFailed = 0x15C
                CS_UM_AdjustMoney = 0x147
                CS_UM_KeyHintText = 0x144
                CS_UM_WeaponSound = 0x171
                CS_UM_CloseCaption = 0x13B
                CS_UM_ReloadEffect = 0x146
                CS_UM_RequestState = 0x140
                CS_UM_CounterStrafe = 0x181
                CS_UM_QuestProgress = 0x16E
                CS_UM_SurvivalStats = 0x175
                CS_UM_WeaponMagDrop = 0x185
                CS_UM_CallVoteFailed = 0x159
                CS_UM_MarkAchievement = 0x165
                CS_UM_AchievementEvent = 0x14D
                CS_UM_CurrentRoundOdds = 0x17C
                CS_UM_CurrentTimescale = 0x14C
                CS_UM_CustomHudClicked = 0x186
                CS_UM_DamagePrediction = 0x182
                CS_UM_DesiredTimescale = 0x14B
                CS_UM_MatchStatsUpdate = 0x166
                CS_UM_ServerRankUpdate = 0x160
                CS_UM_DisconnectToLobby = 0x14F
                CS_UM_PlayerStatsUpdate = 0x150
                CS_UM_SendPlayerLoadout = 0x184
                CS_UM_StopSpectatorMode = 0x149
                CS_UM_CloseCaptionDirect = 0x13C
                CS_UM_DisconnectToLobby2 = 0x176
                CS_UM_MatchEndConditions = 0x14E
                CS_UM_RoundEndReportData = 0x17B
                CS_UM_SayText_CSGOLegacy = 0x131
                CS_UM_TextMsg_CSGOLegacy = 0x133
                CS_UM_SayText2_CSGOLegacy = 0x132
                CS_UM_SendPlayerItemDrops = 0x169
                CS_UM_SendPlayerItemFound = 0x16B
                CS_UM_ServerRankRevealAll = 0x15E
                CS_UM_RoundBackupFilenames = 0x16A
                CS_UM_ScoreLeaderboardData = 0x16F
                CS_UM_PostRoundDamageReport = 0x178
                CS_UM_UpdateScreenHealthBar = 0x172
                CS_UM_EntityOutlineHighlight = 0x173
                CS_UM_RecurringMissionSchema = 0x183
                CS_UM_EndOfMatchAllPlayersData = 0x177
                CS_UM_ProcessSpottedEntityUpdate = 0x145
                CS_UM_UpdateTeamMoney_CSGOLegacy = 0x148
                CS_UM_PlayerDecalDigitalSignature = 0x170
                CS_UM_SendLastKillerDamageToClient = 0x15F
            class EHudPanelClassStatus_t:
                k_eHudPanelClassStatus_HasClass = 0x1
                k_eHudPanelClassStatus_Undefined = -0x1
                k_eHudPanelClassStatus_DoesNotHaveClass = 0x0
            class EntityAttachmentType_t:
                eEyes = 0x2
                eCenter = 0x1
                eAbsOrigin = 0x0
                eAttachment = 0x3
                eLocalOffset = 0x4
            class LatchDirtyPermission_t:
                LATCH_DIRTY_DISALLOW = 0x0
                LATCH_DIRTY_PREDICTION = 0x3
                LATCH_DIRTY_FRAMESIMULATE = 0x4
                LATCH_DIRTY_CLIENT_SIMULATED = 0x2
                LATCH_DIRTY_PARTICLE_SIMULATE = 0x5
                LATCH_DIRTY_SERVER_CONTROLLED = 0x1
            class RelativeLocationType_t:
                WORLD_SPACE_POSITION = 0x0
                RELATIVE_TO_ENTITY_YAW_ONLY = 0x2
                RELATIVE_TO_ENTITY_IN_LOCAL_SPACE = 0x1
                RELATIVE_TO_ENTITY_IN_WORLD_SPACE = 0x3
            class ShatterGlassStressType:
                SHATTERGLASS_BLUNT = 0x0
                SHATTERGLASS_PULSE = 0x2
                SHATTERGLASS_BALLISTIC = 0x1
                SHATTERGLASS_EXPLOSIVE = 0x3
            class TrackOrientationType_t:
                TrackOrientation_Fixed = 0x0
                TrackOrientation_FacePath = 0x1
                TrackOrientation_FacePathAngles = 0x2
            class TrainOrientationType_t:
                TrainOrientation_Fixed = 0x0
                TrainOrientation_LinearBlend = 0x2
                TrainOrientation_AtPathTracks = 0x1
                TrainOrientation_EaseInEaseOut = 0x3
            class BreakableContentsType_t:
                BC_EMPTY = 0x1
                BC_DEFAULT = 0x0
                BC_PROP_GROUP_OVERRIDE = 0x2
                BC_PARTICLE_SYSTEM_OVERRIDE = 0x3
            class EClientReportingVersion:
                k_EClientReportingVersion_OldVersion = 0x0
                k_EClientReportingVersion_BetaVersion = 0x1
                k_EClientReportingVersion_SupportsTrustedMode = 0x2
            class ECommunityItemAttribute:
                k_ECommunityItemAttribute_Level = 0x2
                k_ECommunityItemAttribute_Invalid = 0x0
                k_ECommunityItemAttribute_CardBorder = 0x1
                k_ECommunityItemAttribute_ExpiryTime = 0x9
                k_ECommunityItemAttribute_IssueNumber = 0x3
                k_ECommunityItemAttribute_TradableTime = 0x4
                k_ECommunityItemAttribute_StorePackageID = 0x5
                k_ECommunityItemAttribute_CommunityItemType = 0x7
                k_ECommunityItemAttribute_CommunityItemAppID = 0x6
                k_ECommunityItemAttribute_ProfileModiferEnabled = 0x8
            class EGCBaseProtoObjectTypes:
                k_EProtoObjectLobbyInvite = 0x3EA
                k_EProtoObjectPartyInvite = 0x3E9
            class ESplitScreenMessageType:
                MSG_SPLITSCREEN_ADDUSER = 0x0
                MSG_SPLITSCREEN_REMOVEUSER = 0x1
            class MoveLinearAuthoredPos_t:
                MOVELINEAR_AUTHORED_AT_OPEN_POSITION = 0x1
                MOVELINEAR_AUTHORED_AT_START_POSITION = 0x0
                MOVELINEAR_AUTHORED_AT_CLOSED_POSITION = 0x2
            class NavAttributeDynamicType:
                NAV_AREA_DOCK = 0x4000
                NAV_AREA_NONE = 0x0
                NAV_AREA_MOVABLE = 0x2000
                NAV_AREA_BOUNDARY = 0x10000
                NAV_AREA_NAV_LINK = 0x200
                NAV_AREA_DEFORMABLE = 0x40000
                NAV_AREA_HAS_LADDERS = 0x100
                NAV_AREA_UNDER_WATER = 0x1
                NAV_AREA_DEFORMABLE_DOCK = 0x80000
                NAV_AREA_LINK_AUTO_ADJUST = 0x100000
                NAV_AREA_UNDER_WATER_DEEP = 0x2
                NAV_AREA_DOCKING_CANDIDATE = 0x8000
                NAV_AREA_NAV_LINK_TERMINUS = 0x400
                NAV_AREA_EXTERNALLY_CREATED = 0x4
                NAV_AREA_SHOULD_BE_DESTROYED = 0x8
                NAV_AREA_SPLIT_OBS_CONTAINED = 0x40
                NAV_AREA_SPLIT_BY_OBSTACLE_MGR = 0x20
                NAV_AREA_CREATED_BY_OBSTACLE_MGR = 0x10
                NAV_AREA_CONNECTED_TO_NAV_LINK_IN = 0x1000
                NAV_AREA_SPLIT_OBS_BASE_CONTAINED = 0x80
                NAV_AREA_CONNECTED_TO_NAV_LINK_OUT = 0x800
                NAV_AREA_HAS_TACTICAL_SEARCH_ANNOTATIONS = 0x20000
            class PointOrientConstraint_t:
                eNone = 0x0
                ePreserveUpAxis = 0x1
            class PulseBestOutflowRules_t:
                SORT_BY_OUTFLOW_INDEX = 0x1
                SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0
            class SaveRestoreTableFlags_t:
                FENTTABLE_NONE = 0x0
                LEVELMASK_BIT_0 = 0x1
                LEVELMASK_BIT_1 = 0x2
                LEVELMASK_BIT_2 = 0x4
                LEVELMASK_BIT_3 = 0x8
                LEVELMASK_BIT_4 = 0x10
                LEVELMASK_BIT_5 = 0x20
                LEVELMASK_BIT_6 = 0x40
                LEVELMASK_BIT_7 = 0x80
                LEVELMASK_BIT_8 = 0x100
                LEVELMASK_BIT_9 = 0x200
                FENTTABLE_GLOBAL = 0x10000000
                FENTTABLE_PLAYER = 0x80000000
                LEVELMASK_BIT_10 = 0x400
                LEVELMASK_BIT_11 = 0x800
                LEVELMASK_BIT_12 = 0x1000
                LEVELMASK_BIT_13 = 0x2000
                LEVELMASK_BIT_14 = 0x4000
                LEVELMASK_BIT_15 = 0x8000
                FENTTABLE_REMOVED = 0x40000000
                FENTTABLE_MOVEABLE = 0x20000000
                FENTTABLE_PLAYERCHILD = 0x8000000
            class SurroundingBoundsType_t:
                USE_HITBOXES = 0x2
                USE_GAME_CODE = 0x4
                USE_SPECIFIED_BOUNDS = 0x3
                USE_OBB_COLLISION_BOUNDS = 0x0
                USE_BEST_COLLISION_BOUNDS = 0x1
                SURROUNDING_TYPE_BIT_COUNT = 0x3
                USE_ROTATION_EXPANDED_BOUNDS = 0x5
                USE_COLLISION_BOUNDS_NEVER_VPHYSICS = 0x7
                USE_ROTATION_EXPANDED_ORIENTED_BOUNDS = 0x6
                USE_ROTATION_EXPANDED_SEQUENCE_BOUNDS = 0x8
            class WeaponGameplayAnimState:
                WPN_ANIMSTATE_IDLE = 0x32
                WPN_ANIMSTATE_CHARGE = 0x67
                WPN_ANIMSTATE_DEPLOY = 0xB
                WPN_ANIMSTATE_RELOAD = 0x320
                WPN_ANIMSTATE_DROPPED = 0x1
                WPN_ANIMSTATE_INSPECT = 0x3E8
                WPN_ANIMSTATE_C4_PLANT = 0x12C
                WPN_ANIMSTATE_END_VALID = 0x7D0
                WPN_ANIMSTATE_HOLSTERED = 0xA
                WPN_ANIMSTATE_RELOAD_OUTRO = 0x321
                WPN_ANIMSTATE_GRENADE_READY = 0xC9
                WPN_ANIMSTATE_GRENADE_THROW = 0xCA
                WPN_ANIMSTATE_INSPECT_OUTRO = 0x3E9
                WPN_ANIMSTATE_SHOOT_DRYFIRE = 0x66
                WPN_ANIMSTATE_SHOOT_PRIMARY = 0x64
                WPN_ANIMSTATE_UNINITIALIZED = 0x0
                WPN_ANIMSTATE_SILENCER_APPLY = 0x258
                WPN_ANIMSTATE_SHOOT_SECONDARY = 0x65
                WPN_ANIMSTATE_SILENCER_REMOVE = 0x259
                WPN_ANIMSTATE_GRENADE_PULL_PIN = 0xC8
                WPN_ANIMSTATE_HEALTHSHOT_INJECT = 0x190
                WPN_ANIMSTATE_KNIFE_PRIMARY_HIT = 0x1F4
                WPN_ANIMSTATE_KNIFE_PRIMARY_MISS = 0x1F5
                WPN_ANIMSTATE_KNIFE_PRIMARY_STAB = 0x1F8
                WPN_ANIMSTATE_INVENTORY_UI_TUMBLE = 0x5DC
                WPN_ANIMSTATE_KNIFE_SECONDARY_HIT = 0x1F6
                WPN_ANIMSTATE_KNIFE_SECONDARY_MISS = 0x1F7
                WPN_ANIMSTATE_KNIFE_SECONDARY_STAB = 0x1F9
                WPN_ANIMSTATE_INVENTORY_UI_KEYCHAIN_APPLY = 0x5DD
            class AnimGraphDebugDrawType_t:
                _None = 0x0
                MsPosition = 0x2
                WsPosition = 0x1
                MsDirection = 0x4
                WsDirection = 0x3
            class ChoreoLookAtConditions_t:
                DURING_OUTRO = 0x4
                WHILE_MOVING = 0x1
                WHILE_ANIMATING = 0x2
            class EContributionScoreFlag_t:
                k_EContributionScoreFlag_Bullets = 0x2
                k_EContributionScoreFlag_Default = 0x0
                k_EContributionScoreFlag_Objective = 0x1
            class ValueRemapperInputType_t:
                InputType_PlayerShootPosition = 0x0
                InputType_PlayerShootPositionAroundAxis = 0x1
            class attributeprovidertypes_t:
                PROVIDER_WEAPON = 0x1
                PROVIDER_GENERIC = 0x0
            class CDebugOverlayFilterType_t:
                NONE = 0x0
                TEXT = 0x1
                COUNT = 0x3
                ENTITY = 0x2
                AI_TASK = 0x6
                AI_EVENT = 0x7
                COMBINED = -0x1
                AI_SCHEDULE = 0x5
                AI_PATHFINDING = 0x8
                TACTICAL_SEARCH = 0x4
                END_SIM_HISTORY_TYPES = 0x9
            class CPhysicsProp__CrateType_t:
                CRATE_TYPE_COUNT = 0x1
                CRATE_SPECIFIC_ITEM = 0x0
            class PulseCursorWakePriority_t:
                WakeElegantly = 0x0
                WakeImmediate = 0x1
            class SVC_Messages_LowFrequency:
                svc_dummy = 0x258
            class SubclassVDataChangeType_t:
                SUBCLASS_VDATA_CREATED = 0x0
                SUBCLASS_VDATA_RELOADED = 0x2
                SUBCLASS_VDATA_SUBCLASS_CHANGED = 0x1
            class ValueRemapperOutputType_t:
                OutputType_RotationX = 0x1
                OutputType_RotationY = 0x2
                OutputType_RotationZ = 0x3
                OutputType_AnimationCycle = 0x0
            class DirectionAlongSimplePath_t:
                _None = 0x0
                TGoesUp = 0x1
                TGoesDown = 0x2
            class ESource2PlayStatsFieldType:
                Source2PlayStats_Bool = 0xB
                Source2PlayStats_Int8 = 0x8
                Source2PlayStats_Int16 = 0x7
                Source2PlayStats_Int32 = 0x6
                Source2PlayStats_Int64 = 0x5
                Source2PlayStats_UInt8 = 0x4
                Source2PlayStats_String = 0xC
                Source2PlayStats_UInt16 = 0x3
                Source2PlayStats_UInt32 = 0x2
                Source2PlayStats_UInt64 = 0x1
                Source2PlayStats_Float32 = 0xA
                Source2PlayStats_Float64 = 0x9
                Source2PlayStats_Invalid = 0x0
                Source2PlayStats_SteamID = 0x11
                Source2PlayStats_UTCDateTime = 0xE
                Source2PlayStats_SteamIDTrustBucket = 0xF
                Source2PlayStats_LowCardinalityString = 0xD
                Source2PlayStats_SteamIDTrustBucketMin = 0x10
            class PropDoorRotatingSpawnPos_t:
                DOOR_SPAWN_AJAR = 0x3
                DOOR_SPAWN_CLOSED = 0x0
                DOOR_SPAWN_OPEN_BACK = 0x2
                DOOR_SPAWN_OPEN_FORWARD = 0x1
            class ScriptedConflictResponse_t:
                SS_CONFLICT_ENQUEUE = 0x0
                SS_CONFLICT_INTERRUPT = 0x1
            class ValueRemapperHapticsType_t:
                HaticsType_None = 0x1
                HaticsType_Default = 0x0
            class ValueRemapperRatchetType_t:
                RatchetType_Absolute = 0x0
                RatchetType_EachEngage = 0x1
            class CSPlayerBlockingUseAction_t:
                k_CSPlayerBlockingUseAction_None = 0x0
                k_CSPlayerBlockingUseAction_MaxCount = 0x7
                k_CSPlayerBlockingUseAction_DefusingDefault = 0x1
                k_CSPlayerBlockingUseAction_DefusingWithKit = 0x2
                k_CSPlayerBlockingUseAction_HostageDropping = 0x4
                k_CSPlayerBlockingUseAction_HostageGrabbing = 0x3
                k_CSPlayerBlockingUseAction_MapLongUseEntity_Place = 0x6
                k_CSPlayerBlockingUseAction_MapLongUseEntity_Pickup = 0x5
            class ENetworkDisconnectionReason:
                NETWORK_DISCONNECT_LOST = 0x4
                NETWORK_DISCONNECT_KICKED = 0x27
                NETWORK_DISCONNECT_EXITING = 0x3B
                NETWORK_DISCONNECT_INVALID = 0x0
                NETWORK_DISCONNECT_UNUSUAL = 0x54
                NETWORK_DISCONNECT_USERCMD = 0x2D
                NETWORK_DISCONNECT_BANADDED = 0x28
                NETWORK_DISCONNECT_HLTVSTOP = 0x26
                NETWORK_DISCONNECT_OVERFLOW = 0x5
                NETWORK_DISCONNECT_SHUTDOWN = 0x1
                NETWORK_DISCONNECT_TIMEDOUT = 0x1D
                NETWORK_DISCONNECT_HLTVDIRECT = 0x2A
                NETWORK_DISCONNECT_KICKED_IDLE = 0x9E
                NETWORK_DISCONNECT_STEAM_INUSE = 0x7
                NETWORK_DISCONNECT_STEAM_LOGON = 0x9
                NETWORK_DISCONNECT_BADDELTATICK = 0x1B
                NETWORK_DISCONNECT_DISCONNECTED = 0x1E
                NETWORK_DISCONNECT_HOST_ENDGAME = 0x38
                NETWORK_DISCONNECT_KICKBANADDED = 0x29
                NETWORK_DISCONNECT_LEAVINGSPLIT = 0x1F
                NETWORK_DISCONNECT_LOOPSHUTDOWN = 0x36
                NETWORK_DISCONNECT_NOMORESPLITS = 0x1C
                NETWORK_DISCONNECT_NOSPECTATORS = 0x24
                NETWORK_DISCONNECT_RECONNECTION = 0x35
                NETWORK_DISCONNECT_REJECT_STEAM = 0x92
                NETWORK_DISCONNECT_REMOTE_OTHER = 0x51
                NETWORK_DISCONNECT_STEAM_BANNED = 0x6
                NETWORK_DISCONNECT_STEAM_TICKET = 0x8
                NETWORK_DISCONNECT_CLIENT_NO_MAP = 0x40
                NETWORK_DISCONNECT_REJECT_BANNED = 0x95
                NETWORK_DISCONNECT_SNAPSHOTERROR = 0x19
                NETWORK_DISCONNECT_STEAM_DROPPED = 0x10
                NETWORK_DISCONNECT_HLTVRESTRICTED = 0x23
                NETWORK_DISCONNECT_INTERNAL_ERROR = 0x55
                NETWORK_DISCONNECT_KICKED_SUICIDE = 0x9F
                NETWORK_DISCONNECT_LOOPDEACTIVATE = 0x37
                NETWORK_DISCONNECT_REJECT_NOLOBBY = 0x81
                NETWORK_DISCONNECT_REMOTE_TIMEOUT = 0x4F
                NETWORK_DISCONNECT_HLTVUNAVAILABLE = 0x25
                NETWORK_DISCONNECT_KICKED_TK_START = 0x97
                NETWORK_DISCONNECT_KICKED_VOTEDOFF = 0x9D
                NETWORK_DISCONNECT_REMOTE_BADCRYPT = 0x52
                NETWORK_DISCONNECT_SERVER_SHUTDOWN = 0x45
                NETWORK_DISCONNECT_STEAM_DENY_MISC = 0x43
                NETWORK_DISCONNECT_STEAM_OWNERSHIP = 0x11
                NETWORK_DISCONNECT_BADRELAYPASSWORD = 0x21
                NETWORK_DISCONNECT_REJECTED_BY_GAME = 0x2E
                NETWORK_DISCONNECT_RELIABLEOVERFLOW = 0x1A
                NETWORK_DISCONNECT_SNAPSHOTOVERFLOW = 0x18
                NETWORK_DISCONNECT_TICKMSG_OVERFLOW = 0x13
                NETWORK_DISCONNECT_REJECT_SERVERFULL = 0x87
                NETWORK_DISCONNECT_STEAM_AUTHINVALID = 0xC
                NETWORK_DISCONNECT_STEAM_VACBANSTATE = 0xD
                NETWORK_DISCONNECT_CONNECTION_FAILURE = 0x33
                NETWORK_DISCONNECT_DISCONNECT_BY_USER = 0x2
                NETWORK_DISCONNECT_KICKED_TEAMHURTING = 0x9B
                NETWORK_DISCONNECT_KICKED_TEAMKILLING = 0x96
                NETWORK_DISCONNECT_LOCALPROBLEM_OTHER = 0x4D
                NETWORK_DISCONNECT_REJECT_BADPASSWORD = 0x86
                NETWORK_DISCONNECT_REJECT_HIDDEN_GAME = 0x84
                NETWORK_DISCONNECT_REJECT_LANRESTRICT = 0x85
                NETWORK_DISCONNECT_REJECT_NEWPROTOCOL = 0x8E
                NETWORK_DISCONNECT_REJECT_OLDPROTOCOL = 0x8D
                NETWORK_DISCONNECT_SOUNDSMSG_OVERFLOW = 0x17
                NETWORK_DISCONNECT_BAD_SERVER_PASSWORD = 0x31
                NETWORK_DISCONNECT_KICKED_NOSTEAMLOGIN = 0xA0
                NETWORK_DISCONNECT_MESSAGE_PARSE_ERROR = 0x2F
                NETWORK_DISCONNECT_PURESERVER_MISMATCH = 0x2C
                NETWORK_DISCONNECT_REJECT_BADCHALLENGE = 0x80
                NETWORK_DISCONNECT_REPLAY_INCOMPATIBLE = 0x47
                NETWORK_DISCONNECT_SERVERINFO_OVERFLOW = 0x12
                NETWORK_DISCONNECT_SERVER_INCOMPATIBLE = 0x49
                NETWORK_DISCONNECT_STEAM_AUTHCANCELLED = 0xA
                NETWORK_DISCONNECT_TEMPENTMSG_OVERFLOW = 0x16
                NETWORK_DISCONNECT_BADSPECTATORPASSWORD = 0x22
                NETWORK_DISCONNECT_CLIENT_DIFFERENT_MAP = 0x41
                NETWORK_DISCONNECT_CREATE_SERVER_FAILED = 0x3A
                NETWORK_DISCONNECT_DELTAENTMSG_OVERFLOW = 0x15
                NETWORK_DISCONNECT_DIFFERENTCLASSTABLES = 0x20
                NETWORK_DISCONNECT_DISCONNECT_BY_SERVER = 0x3
                NETWORK_DISCONNECT_KICKED_NOSTEAMTICKET = 0xA1
                NETWORK_DISCONNECT_REJECT_FAILEDCHANNEL = 0x89
                NETWORK_DISCONNECT_REJECT_SINGLE_PLAYER = 0x83
                NETWORK_DISCONNECT_INVALID_MESSAGE_ERROR = 0x30
                NETWORK_DISCONNECT_KICKED_HOSTAGEKILLING = 0x9C
                NETWORK_DISCONNECT_KICKED_INSECURECLIENT = 0xA4
                NETWORK_DISCONNECT_REJECT_BACKGROUND_MAP = 0x82
                NETWORK_DISCONNECT_REJECT_INVALIDCERTLEN = 0x90
                NETWORK_DISCONNECT_REMOTE_CERTNOTTRUSTED = 0x53
                NETWORK_DISCONNECT_SERVER_REQUIRES_STEAM = 0x42
                NETWORK_DISCONNECT_STEAM_AUTHALREADYUSED = 0xB
                NETWORK_DISCONNECT_KICKED_INPUTAUTOMATION = 0xA2
                NETWORK_DISCONNECT_NO_PEER_GROUP_HANDLERS = 0x34
                NETWORK_DISCONNECT_PURESERVER_CLIENTEXTRA = 0x2B
                NETWORK_DISCONNECT_REQUEST_HOSTSTATE_IDLE = 0x3C
                NETWORK_DISCONNECT_CLIENT_CONSISTENCY_FAIL = 0x3E
                NETWORK_DISCONNECT_KICKED_CONVICTEDACCOUNT = 0x99
                NETWORK_DISCONNECT_KICKED_UNTRUSTEDACCOUNT = 0x98
                NETWORK_DISCONNECT_LOCALPROBLEM_MANYRELAYS = 0x4A
                NETWORK_DISCONNECT_LOOP_LEVELLOAD_ACTIVATE = 0x39
                NETWORK_DISCONNECT_REJECT_INVALIDKEYLENGTH = 0x8C
                NETWORK_DISCONNECT_STRINGTABLEMSG_OVERFLOW = 0x14
                NETWORK_DISCONNECT_CLIENT_UNABLE_TO_CRC_MAP = 0x3F
                NETWORK_DISCONNECT_CONNECT_REQUEST_TIMEDOUT = 0x48
                NETWORK_DISCONNECT_REJECT_INVALIDCONNECTION = 0x8F
                NETWORK_DISCONNECT_STEAM_VAC_CHECK_TIMEDOUT = 0xF
                NETWORK_DISCONNECT_REJECT_CONNECT_FROM_LOBBY = 0x8A
                NETWORK_DISCONNECT_REJECT_INVALIDRESERVATION = 0x88
                NETWORK_DISCONNECT_REJECT_RESERVED_FOR_LOBBY = 0x8B
                NETWORK_DISCONNECT_REJECT_SERVERAUTHDISABLED = 0x93
                NETWORK_DISCONNECT_REMOTE_TIMEOUT_CONNECTING = 0x50
                NETWORK_DISCONNECT_STEAM_DENY_BAD_ANTI_CHEAT = 0x44
                NETWORK_DISCONNECT_STEAM_LOGGED_IN_ELSEWHERE = 0xE
                NETWORK_DISCONNECT_DIRECT_CONNECT_RESERVATION = 0x32
                NETWORK_DISCONNECT_KICKED_COMPETITIVECOOLDOWN = 0x9A
                NETWORK_DISCONNECT_LOCALPROBLEM_NETWORKCONFIG = 0x4C
                NETWORK_DISCONNECT_REJECT_INVALIDSTEAMCERTLEN = 0x91
                NETWORK_DISCONNECT_REQUEST_HOSTSTATE_HLTVRELAY = 0x3D
                NETWORK_DISCONNECT_KICKED_VACNETABNORMALBEHAVIOR = 0xA3
                NETWORK_DISCONNECT_REJECT_SERVERCDKEYAUTHINVALID = 0x94
                NETWORK_DISCONNECT_LOCALPROBLEM_HOSTEDSERVERPRIMARYRELAY = 0x4B
            class PulseCursorCancelPriority_t:
                _None = 0x0
                HardCancel = 0x3
                SoftCancel = 0x2
                CancelOnSucceeded = 0x1
            class SequenceFinishNotifyState_t:
                eDoNotNotify = 0x0
                eNotifyTriggered = 0x2
                eNotifyWhenFinished = 0x1
            class ValueRemapperMomentumType_t:
                MomentumType_None = 0x0
                MomentumType_Friction = 0x1
                MomentumType_SpringTowardSnapValue = 0x2
                MomentumType_SpringAwayFromSnapValue = 0x3
            class WorldTextPanelOrientation_t:
                WORLDTEXT_ORIENTATION_DEFAULT = 0x0
                WORLDTEXT_ORIENTATION_FACEUSER = 0x1
                WORLDTEXT_ORIENTATION_FACEUSER_UPRIGHT = 0x2
            class CDebugOverlayCombinedTypes_t:
                ALL = 0x0
                ANY = 0x1
                COUNT = 0x2
            class CFuncRotator__RotationAxis_t:
                ROTATION_AXIS_YAW = 0x1
                ROTATION_AXIS_ROLL = 0x3
                ROTATION_AXIS_PITCH = 0x2
                ROTATION_AXIS_UNDEFINED = 0x0
            class CRR_Response__ResponseEnum_t:
                MAX_RULE_NAME = 0x80
                MAX_RESPONSE_NAME = 0xC0
            class LessonPanelLayoutFileTypes_t:
                LAYOUT_CUSTOM = 0x2
                LAYOUT_HAND_DEFAULT = 0x0
                LAYOUT_WORLD_DEFAULT = 0x1
            class PointWorldTextReorientMode_t:
                POINT_WORLD_TEXT_REORIENT_NONE = 0x0
                POINT_WORLD_TEXT_REORIENT_AROUND_UP = 0x1
            class CDebugOverlayFilterTextType_t:
                COUNT = 0x3
                MATCH = 0x1
                HIERARCHY = 0x2
                FILTER_TEXT_NONE = 0x0
            class CInfoChoreoLocatorShapeType_t:
                LINE = 0x1
                NONE = 0x4
                COUNT = 0x3
                POINT = 0x0
                RADIUS = 0x2
            class ShatterGlassEntityPoolState_t:
                ENTITY_POOL_STATE_IN_USE = 0x2
                ENTITY_POOL_STATE_INVALID = 0x0
                ENTITY_POOL_STATE_AVAILABLE = 0x1
            class WorldTextPanelVerticalAlign_t:
                WORLDTEXT_VERTICAL_ALIGN_TOP = 0x0
                WORLDTEXT_VERTICAL_ALIGN_BOTTOM = 0x2
                WORLDTEXT_VERTICAL_ALIGN_CENTER = 0x1
            class CFuncMover__FollowConstraint_t:
                FOLLOW_CONSTRAINT_RATIO = 0x2
                FOLLOW_CONSTRAINT_SPRING = 0x1
                FOLLOW_CONSTRAINT_COUPLER = 0x3
                FOLLOW_CONSTRAINT_DISTANCE = 0x0
            class IChoreoServices__ChoreoState_t:
                STATE_PRE_SCRIPT = 0x0
                STATE_PLAY_SCRIPT = 0x4
                STATE_WALK_TO_MARK = 0x2
                STATE_WAIT_FOR_SCRIPT = 0x1
                STATE_SYNCHRONIZE_SCRIPT = 0x3
                STATE_PLAY_SCRIPT_POST_IDLE = 0x5
                STATE_PLAY_SCRIPT_POST_IDLE_DONE = 0x6
            class IChoreoServices__ScriptState_t:
                SCRIPT_WAIT = 0x1
                SCRIPT_CLEANUP = 0x3
                SCRIPT_PLAYING = 0x0
                SCRIPT_POST_IDLE = 0x2
                SCRIPT_MOVE_TO_MARK = 0x4
            class PointOrientGoalDirectionType_t:
                eHead = 0x2
                eCenter = 0x1
                eForward = 0x3
                eAbsOrigin = 0x0
                eEyesForward = 0x4
            class BeginDeathLifeStateTransition_t:
                TRANSITION_TO_LIFESTATE_DEAD = 0x1
                TRANSITION_TO_LIFESTATE_DYING = 0x0
            class CFuncMover__OrientationUpdate_t:
                ORIENTATION_FIXED = 0x4
                ORIENTATION_FACE_ENTITY = 0x8
                ORIENTATION_FACE_PLAYER = 0x5
                ORIENTATION_FORWARD_PATH = 0x0
                ORIENTATION_MATCH_CONTROL_POINT = 0x3
                ORIENTATION_FORWARD_MOVEMENT_DIRECTION = 0x6
                ORIENTATION_FORWARD_PATH_AND_FIXED_PITCH = 0x1
                ORIENTATION_FORWARD_PATH_AND_UP_CONTROL_POINT = 0x2
                ORIENTATION_FORWARD_MOVEMENT_DIRECTION_AND_UP_CONTROL_POINT = 0x7
            class FuncMoverMovementSummaryFlags_t:
                eNone = 0x0
                eLoopToEnd = 0x40
                eReversing = 0x8
                eStopBegin = 0x2
                eLoopToStart = 0x20
                eStopComplete = 0x4
                eMovementBegin = 0x1
                eEventsDispatched = 0x10
                eTransitionComplete = 0x80
                eStoppedDuringTransition = 0x100
            class INavObstacle__NavObstacleType_t:
                NAV_OBSTACLE_TYPE_CONN = 0x2
                NAV_OBSTACLE_TYPE_NONE = 0x0
                NAV_OBSTACLE_TYPE_AVOID = 0x1
                NAV_OBSTACLE_TYPE_BLOCK = 0x3
                NAV_OBSTACLE_TYPE_INVALID = -0x1
                NAV_OBSTACLE_TYPE_PERMANENT_BLOCK = 0x4
            class PointWorldTextJustifyVertical_t:
                POINT_WORLD_TEXT_JUSTIFY_VERTICAL_TOP = 0x2
                POINT_WORLD_TEXT_JUSTIFY_VERTICAL_BOTTOM = 0x0
                POINT_WORLD_TEXT_JUSTIFY_VERTICAL_CENTER = 0x1
            class PreviewCharacterBannerAnimation:
                INVALID = -0x1
                BANNER_FIRE = 0x14
                BANNER_3SHOT_A = 0x8
                BANNER_3SHOT_B = 0x9
                BANNER_3SHOT_C = 0xA
                BANNER_4SHOT_A = 0xC
                BANNER_4SHOT_B = 0xD
                BANNER_4SHOT_C = 0xE
                BANNER_4SHOT_D = 0xF
                IDLE_OFFSCREEN = 0x0
                BANNER_AWP_ACE_A = 0x2
                BANNER_AWP_ACE_B = 0x3
                BANNER_AWP_ACE_C = 0x4
                BANNER_AWP_ACE_D = 0x5
                BANNER_AWP_ACE_E = 0x6
                BANNER_BOMB_PLANT = 0x11
                BANNER_AWP_ACE_GUN = 0x1
                BANNER_PISTOL3SHOT = 0x7
                BANNER_PISTOL4SHOT = 0xB
                BANNER_BOMB_BLAST01 = 0x16
                BANNER_BOMB_BLAST02 = 0x17
                BANNER_BOMB_BLAST03 = 0x18
                BANNER_CELEBRATE_01 = 0x19
                BANNER_CELEBRATE_02 = 0x1A
                BANNER_CELEBRATE_03 = 0x1B
                BANNER_CELEBRATE_04 = 0x1C
                BANNER_BOMB_BLAST_TOSS = 0x15
                BANNER_BOMB_DEFUSAL_VER1 = 0x12
                BANNER_BOMB_DEFUSAL_VER2 = 0x13
                CELEBRATE_STRETCH_NOWEAP_IDLE0 = 0x10
            class PropDoorRotatingOpenDirection_e:
                DOOR_ROTATING_OPEN_FORWARD = 0x1
                DOOR_ROTATING_OPEN_BACKWARD = 0x2
                DOOR_ROTATING_OPEN_BOTH_WAYS = 0x0
            class WorldTextPanelHorizontalAlign_t:
                WORLDTEXT_HORIZONTAL_ALIGN_LEFT = 0x0
                WORLDTEXT_HORIZONTAL_ALIGN_RIGHT = 0x2
                WORLDTEXT_HORIZONTAL_ALIGN_CENTER = 0x1
            class EGCItemCustomizationNotification:
                k_EGCItemCustomizationNotification_NameItem = 0x3EE
                k_EGCItemCustomizationNotification_ApplyPatch = 0x442
                k_EGCItemCustomizationNotification_CasketAdded = 0x3F5
                k_EGCItemCustomizationNotification_RemovePatch = 0x441
                k_EGCItemCustomizationNotification_UnlockCrate = 0x3EF
                k_EGCItemCustomizationNotification_ApplySticker = 0x43E
                k_EGCItemCustomizationNotification_NameBaseItem = 0x3FB
                k_EGCItemCustomizationNotification_StatTrakSwap = 0x440
                k_EGCItemCustomizationNotification_ApplyKeychain = 0x443
                k_EGCItemCustomizationNotification_CasketInvFull = 0x3F7
                k_EGCItemCustomizationNotification_CasketRemoved = 0x3F6
                k_EGCItemCustomizationNotification_CasketTooFull = 0x3F3
                k_EGCItemCustomizationNotification_RemoveSticker = 0x41D
                k_EGCItemCustomizationNotification_XRayItemClaim = 0x3F1
                k_EGCItemCustomizationNotification_CasketContents = 0x3F4
                k_EGCItemCustomizationNotification_ExtractSticker = 0x41E
                k_EGCItemCustomizationNotification_GraffitiUnseal = 0x23E1
                k_EGCItemCustomizationNotification_RemoveItemName = 0x406
                k_EGCItemCustomizationNotification_RemoveKeychain = 0x444
                k_EGCItemCustomizationNotification_XRayItemReveal = 0x3F0
                k_EGCItemCustomizationNotification_XpShopAckTracks = 0x2406
                k_EGCItemCustomizationNotification_XpShopUseTicket = 0x2405
                k_EGCItemCustomizationNotification_ActivateFanToken = 0x23DA
                k_EGCItemCustomizationNotification_GenerateSouvenir = 0x23F4
                k_EGCItemCustomizationNotification_EncapsulateSticker = 0x41F
                k_EGCItemCustomizationNotification_ActivateOperationCoin = 0x23DB
                k_EGCItemCustomizationNotification_ClientRedeemFreeReward = 0x2403
                k_EGCItemCustomizationNotification_ClientRedeemMissionReward = 0x23F9
            class CFuncMover__PathRebuildStrategy_t:
                PATH_REBUILD_DONT_MOVE = 0x0
                PATH_REBUILD_MAINTAIN_T = 0x1
                PATH_REBUILD_USE_CURRENT_NODE_T = 0x2
            class FuncRotatorRotationSummaryFlags_t:
                eNone = 0x0
                eRotateBegin = 0x1
                eOscillateEnd = 0x10
                eOscillateStart = 0x8
                eOscillateDepart = 0x40
                eRotateCompleted = 0x4
                eEventsDispatched = 0x2
                eOscillateArrived = 0x20
            class PointWorldTextJustifyHorizontal_t:
                POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_LEFT = 0x0
                POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_RIGHT = 0x2
                POINT_WORLD_TEXT_JUSTIFY_HORIZONTAL_CENTER = 0x1
            class TestInputOutputCombinationsEnum_t:
                ONE = 0x1
                TWO = 0x2
                ZERO = 0x0
            class ECSUsrMsg_DisconnectToLobby_Action:
                k_ECSUsrMsg_DisconnectToLobby_Action_Default = 0x0
                k_ECSUsrMsg_DisconnectToLobby_Action_GoQueue = 0x1
            class PointTemplateOwnerSpawnGroupType_t:
                INSERT_INTO_NEWLY_CREATED_SPAWN_GROUP = 0x2
                INSERT_INTO_POINT_TEMPLATE_SPAWN_GROUP = 0x0
                INSERT_INTO_CURRENTLY_ACTIVE_SPAWN_GROUP = 0x1
            class CCSPlayerAnimationState__MoveType_t:
                Air = 0x2
                _None = 0x0
                Ground = 0x1
                Ladder = 0x3
            class CFuncMover__FollowEntityDirection_t:
                FOLLOW_ENTITY_FORWARD = 0x1
                FOLLOW_ENTITY_REVERSE = 0x2
                FOLLOW_ENTITY_BIDIRECTIONAL = 0x0
            class ExternalAnimGraphInactiveBehavior_t:
                eNone = 0x0
                eUnbind = 0x1
                eUnbindAndDelete = 0x2
            class CCSPlayerAnimationState__AirAction_t:
                Jump = 0x1
                Land = 0x3
                _None = 0x0
                StartFall = 0x2
            class CCSPlayerAnimationState__Direction_t:
                E = 0x3
                N = 0x1
                S = 0x5
                W = 0x7
                NE = 0x2
                NW = 0x8
                SE = 0x4
                SW = 0x6
                _None = 0x0
            class CFuncMover__FindFollowMoverStrategy_t:
                FIND_FOLLOW_MOVER_FORWARD_CLOSEST = 0x0
                FIND_FOLLOW_MOVER_REVERSE_CLOSEST = 0x1
                FIND_FOLLOW_MOVER_BIDIRECTIONAL_CLOSEST = 0x2
            class ChoreoExternalAnimgraphControlState_t:
                eExit = 0x1
                eNone = 0x0
                eCount = 0x9
                eLooping = 0x8
                eState01 = 0x3
                eState02 = 0x4
                eState03 = 0x5
                eState04 = 0x6
                eState05 = 0x7
                eFallbackExit = 0x2
            class EDestructiblePartDamagePassThroughType:
                Absorb = 0x1
                Normal = 0x0
                InvincibleAbsorb = 0x2
                InvinciblePassthrough = 0x3
            class EDestructiblePartRadiusDamageApplyType:
                PrioritizeClosestPart = 0x1
                ScaleByExplosionRadius = 0x0
            class PointTemplateClientOnlyEntityBehavior_t:
                CREATE_FOR_CLIENTS_WHO_CONNECT_LATER = 0x1
                CREATE_FOR_CURRENTLY_CONNECTED_CLIENTS_ONLY = 0x0
            class CFuncMover__TransitionToPathNodeAction_t:
                TRANSITION_TO_PATH_NODE_ACTION_NONE = 0x0
                TRANSITION_TO_PATH_NODE_TRANSITIONING = 0x3
                TRANSITION_TO_PATH_NODE_ACTION_START_FORWARD = 0x1
                TRANSITION_TO_PATH_NODE_ACTION_START_REVERSE = 0x2
            class EDestructibleParts_DestroyParameterFlags:
                _None = 0x0
                Default = 0x7
                EnableFlinches = 0x4
                ForceDamageApply = 0x8
                ApplyPhysicsForce = 0x40
                IgnoreHealthCheck = 0x20
                GenerateBreakpieces = 0x1
                IgnoreKillEntityFlag = 0x10
                SetBodyGroupAndCollisionState = 0x2
            class CCSPlayerAnimationState__GroundMoveState_t:
                Idle = 0x1
                Move = 0x3
                _None = 0x0
                Start = 0x2
                TurnOnSpot = 0x4
                PlantAndTurn = 0x6
                TurnOnSpotLoop = 0x5
            class DestructiblePartDestructionDeathBehavior_t:
                eGib = 0x2
                eKill = 0x1
                eRemove = 0x3
                eDoNotKill = 0x0
            class EProceduralRagdollWeightIndexPropagationMethod:
                Bone = 0x0
                BoneAndChildren = 0x1
            class CLogicBranchList__LogicBranchListenerLastState_t:
                LOGIC_BRANCH_LISTENER_MIXED = 0x3
                LOGIC_BRANCH_LISTENER_ALL_TRUE = 0x1
                LOGIC_BRANCH_LISTENER_NOT_INIT = 0x0
                LOGIC_BRANCH_LISTENER_ALL_FALSE = 0x2
            class CPathMoverEntitySpawner__TemplateChoiceStrategy_t:
                TEMPLATE_CHOICE_COUNT_RANDOM = 0x2
                TEMPLATE_CHOICE_WEIGHTED_RANDOM = 0x1
                TEMPLATE_CHOICE_COUNT_SEQUENTIAL = 0x0
