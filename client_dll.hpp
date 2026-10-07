#pragma once
#include <cstddef>
namespace cs2_dumper {
    namespace schemas {
        namespace client_dll {
            namespace C_C4 {
                inline constexpr std::ptrdiff_t m_fArmedTime = 0x1F2C;
                inline constexpr std::ptrdiff_t m_nSpotRules = 0x1F50;
                inline constexpr std::ptrdiff_t m_bBombPlanted = 0x1F5B;
                inline constexpr std::ptrdiff_t m_bStartedArming = 0x1F28;
                inline constexpr std::ptrdiff_t m_bIsPlantingViaUse = 0x1F31;
                inline constexpr std::ptrdiff_t m_bPlayedArmingBeeps = 0x1F54;
                inline constexpr std::ptrdiff_t m_eActiveLightEffect = 0x1F24;
                inline constexpr std::ptrdiff_t m_entitySpottedState = 0x1F38;
                inline constexpr std::ptrdiff_t m_bBombPlacedAnimation = 0x1F30;
                inline constexpr std::ptrdiff_t m_activeLightParticleIndex = 0x1F20;
            }
            namespace C_AK47 {

            }
            namespace C_Beam {
                inline constexpr std::ptrdiff_t m_fSpeed = 0x1134;
                inline constexpr std::ptrdiff_t m_fWidth = 0x111C;
                inline constexpr std::ptrdiff_t m_flFrame = 0x1138;
                inline constexpr std::ptrdiff_t m_flDamage = 0x10A4;
                inline constexpr std::ptrdiff_t m_fEndWidth = 0x1120;
                inline constexpr std::ptrdiff_t m_nBeamType = 0x10E0;
                inline constexpr std::ptrdiff_t m_vecEndPos = 0x1140;
                inline constexpr std::ptrdiff_t m_bTurnedOff = 0x113C;
                inline constexpr std::ptrdiff_t m_fAmplitude = 0x112C;
                inline constexpr std::ptrdiff_t m_fHaloScale = 0x1128;
                inline constexpr std::ptrdiff_t m_flFireTime = 0x10A0;
                inline constexpr std::ptrdiff_t m_hEndEntity = 0x114C;
                inline constexpr std::ptrdiff_t m_nBeamFlags = 0x10E4;
                inline constexpr std::ptrdiff_t m_nHaloIndex = 0x10D8;
                inline constexpr std::ptrdiff_t m_fFadeLength = 0x1124;
                inline constexpr std::ptrdiff_t m_fStartFrame = 0x1130;
                inline constexpr std::ptrdiff_t m_flFrameRate = 0x1098;
                inline constexpr std::ptrdiff_t m_nAttachIndex = 0x1110;
                inline constexpr std::ptrdiff_t m_nNumBeamEnts = 0x10A8;
                inline constexpr std::ptrdiff_t m_hAttachEntity = 0x10E8;
                inline constexpr std::ptrdiff_t m_hBaseMaterial = 0x10D0;
                inline constexpr std::ptrdiff_t m_flHDRColorScale = 0x109C;
                inline constexpr std::ptrdiff_t m_queryHandleHalo = 0x10AC;
            }
            namespace C_Fish {
                inline constexpr std::ptrdiff_t m_x = 0x12EC;
                inline constexpr std::ptrdiff_t m_y = 0x12F0;
                inline constexpr std::ptrdiff_t m_z = 0x12F4;
                inline constexpr std::ptrdiff_t m_pos = 0x1268;
                inline constexpr std::ptrdiff_t m_vel = 0x1274;
                inline constexpr std::ptrdiff_t m_angle = 0x12F8;
                inline constexpr std::ptrdiff_t m_angles = 0x1280;
                inline constexpr std::ptrdiff_t m_buoyancy = 0x1298;
                inline constexpr std::ptrdiff_t m_actualPos = 0x12C0;
                inline constexpr std::ptrdiff_t m_gotUpdate = 0x12E8;
                inline constexpr std::ptrdiff_t m_deathAngle = 0x1294;
                inline constexpr std::ptrdiff_t m_deathDepth = 0x1290;
                inline constexpr std::ptrdiff_t m_poolOrigin = 0x12D8;
                inline constexpr std::ptrdiff_t m_waterLevel = 0x12E4;
                inline constexpr std::ptrdiff_t m_wiggleRate = 0x12BC;
                inline constexpr std::ptrdiff_t m_wigglePhase = 0x12B8;
                inline constexpr std::ptrdiff_t m_wiggleTimer = 0x12A0;
                inline constexpr std::ptrdiff_t m_actualAngles = 0x12CC;
                inline constexpr std::ptrdiff_t m_averageError = 0x1354;
                inline constexpr std::ptrdiff_t m_errorHistory = 0x12FC;
                inline constexpr std::ptrdiff_t m_localLifeState = 0x128C;
                inline constexpr std::ptrdiff_t m_errorHistoryCount = 0x1350;
                inline constexpr std::ptrdiff_t m_errorHistoryIndex = 0x134C;
            }
            namespace C_Item {
                inline constexpr std::ptrdiff_t m_pReticleHintTextName = 0x1918;
            }
            namespace C_Team {
                inline constexpr std::ptrdiff_t m_iScore = 0x630;
                inline constexpr std::ptrdiff_t m_aPlayers = 0x618;
                inline constexpr std::ptrdiff_t m_szTeamname = 0x634;
                inline constexpr std::ptrdiff_t m_aPlayerControllers = 0x600;
            }
            namespace C_Knife {
                inline constexpr std::ptrdiff_t m_bFirstAttack = 0x1F20;
            }
            namespace C_World {

            }
            namespace CInfoFan {
                inline constexpr std::ptrdiff_t m_flCurveDistRange = 0x648;
                inline constexpr std::ptrdiff_t m_fFanForceMaxRadius = 0x640;
                inline constexpr std::ptrdiff_t m_fFanForceMinRadius = 0x644;
                inline constexpr std::ptrdiff_t m_FanForceCurveString = 0x650;
            }
            namespace CMapInfo {
                inline constexpr std::ptrdiff_t m_flBombRadius = 0x604;
                inline constexpr std::ptrdiff_t m_iBuyingStatus = 0x600;
                inline constexpr std::ptrdiff_t m_iHostageCount = 0x614;
                inline constexpr std::ptrdiff_t m_bGPUCullSkybox = 0x61A;
                inline constexpr std::ptrdiff_t m_iPetPopulation = 0x608;
                inline constexpr std::ptrdiff_t m_flEnvRainStrength = 0x61C;
                inline constexpr std::ptrdiff_t m_flEnvWetnessCoverage = 0x628;
                inline constexpr std::ptrdiff_t m_bUseNormalSpawnsForDM = 0x60C;
                inline constexpr std::ptrdiff_t m_bRainTraceToSkyEnabled = 0x619;
                inline constexpr std::ptrdiff_t m_flBotMaxVisionDistance = 0x610;
                inline constexpr std::ptrdiff_t m_flEnvWetnessDryingAmount = 0x62C;
                inline constexpr std::ptrdiff_t m_bFadePlayerVisibilityFarZ = 0x618;
                inline constexpr std::ptrdiff_t m_flEnvPuddleRippleStrength = 0x620;
                inline constexpr std::ptrdiff_t m_flEnvPuddleRippleDirection = 0x624;
                inline constexpr std::ptrdiff_t m_bDisableAutoGeneratedDMSpawns = 0x60D;
            }
            namespace C_CSTeam {
                inline constexpr std::ptrdiff_t m_iClanID = 0x950;
                inline constexpr std::ptrdiff_t m_bSurrendered = 0x8BC;
                inline constexpr std::ptrdiff_t m_scoreOvertime = 0x8C8;
                inline constexpr std::ptrdiff_t m_scoreFirstHalf = 0x8C0;
                inline constexpr std::ptrdiff_t m_szClanTeamname = 0x8CC;
                inline constexpr std::ptrdiff_t m_numMapVictories = 0x8B8;
                inline constexpr std::ptrdiff_t m_scoreSecondHalf = 0x8C4;
                inline constexpr std::ptrdiff_t m_szTeamFlagImage = 0x954;
                inline constexpr std::ptrdiff_t m_szTeamLogoImage = 0x95C;
                inline constexpr std::ptrdiff_t m_szTeamMatchStat = 0x6B8;
            }
            namespace C_DEagle {

            }
            namespace C_EnvSky {
                inline constexpr std::ptrdiff_t m_bEnabled = 0x10CC;
                inline constexpr std::ptrdiff_t m_nFogType = 0x10B8;
                inline constexpr std::ptrdiff_t m_vTintColor = 0x10AC;
                inline constexpr std::ptrdiff_t m_flFogMaxEnd = 0x10C8;
                inline constexpr std::ptrdiff_t m_flFogMinEnd = 0x10C0;
                inline constexpr std::ptrdiff_t m_hSkyMaterial = 0x1098;
                inline constexpr std::ptrdiff_t m_flFogMaxStart = 0x10C4;
                inline constexpr std::ptrdiff_t m_flFogMinStart = 0x10BC;
                inline constexpr std::ptrdiff_t m_bStartDisabled = 0x10A8;
                inline constexpr std::ptrdiff_t m_flBrightnessScale = 0x10B4;
                inline constexpr std::ptrdiff_t m_vTintColorLightingOnly = 0x10B0;
                inline constexpr std::ptrdiff_t m_hSkyMaterialLightingOnly = 0x10A0;
            }
            namespace C_Sprite {
                inline constexpr std::ptrdiff_t m_flFrame = 0x10AC;
                inline constexpr std::ptrdiff_t m_flSpeed = 0x1110;
                inline constexpr std::ptrdiff_t m_flDieTime = 0x10B0;
                inline constexpr std::ptrdiff_t m_flLastTime = 0x10DC;
                inline constexpr std::ptrdiff_t m_flMaxFrame = 0x10E0;
                inline constexpr std::ptrdiff_t m_flDestScale = 0x10E8;
                inline constexpr std::ptrdiff_t m_nAttachment = 0x10A4;
                inline constexpr std::ptrdiff_t m_nBrightness = 0x10C0;
                inline constexpr std::ptrdiff_t m_flStartScale = 0x10E4;
                inline constexpr std::ptrdiff_t m_nSpriteWidth = 0x1108;
                inline constexpr std::ptrdiff_t m_flSpriteScale = 0x10C8;
                inline constexpr std::ptrdiff_t m_nSpriteHeight = 0x110C;
                inline constexpr std::ptrdiff_t m_flGlowProxySize = 0x10D4;
                inline constexpr std::ptrdiff_t m_flHDRColorScale = 0x10D8;
                inline constexpr std::ptrdiff_t m_flScaleDuration = 0x10CC;
                inline constexpr std::ptrdiff_t m_hSpriteMaterial = 0x1098;
                inline constexpr std::ptrdiff_t m_nDestBrightness = 0x10F4;
                inline constexpr std::ptrdiff_t m_bWorldSpaceScale = 0x10D0;
                inline constexpr std::ptrdiff_t m_flScaleTimeStart = 0x10EC;
                inline constexpr std::ptrdiff_t m_nStartBrightness = 0x10F0;
                inline constexpr std::ptrdiff_t m_flSpriteFramerate = 0x10A8;
                inline constexpr std::ptrdiff_t m_hAttachedToEntity = 0x10A0;
                inline constexpr std::ptrdiff_t m_flBrightnessDuration = 0x10C4;
                inline constexpr std::ptrdiff_t m_flBrightnessTimeStart = 0x10F8;
            }
            namespace CBaseProp {
                inline constexpr std::ptrdiff_t m_iShapeType = 0x126C;
                inline constexpr std::ptrdiff_t m_bModelOverrodeBlockLOS = 0x1268;
                inline constexpr std::ptrdiff_t m_mPreferredCatchTransform = 0x1280;
                inline constexpr std::ptrdiff_t m_bConformToCollisionBounds = 0x1270;
            }
            namespace CPathNode {
                inline constexpr std::ptrdiff_t m_hPath = 0x650;
                inline constexpr std::ptrdiff_t m_xWSPrevParent = 0x630;
                inline constexpr std::ptrdiff_t m_vInTangentLocal = 0x600;
                inline constexpr std::ptrdiff_t m_vOutTangentLocal = 0x60C;
                inline constexpr std::ptrdiff_t m_strPathNodeParameter = 0x620;
                inline constexpr std::ptrdiff_t m_strParentPathUniqueID = 0x618;
            }
            namespace CTimeline {
                inline constexpr std::ptrdiff_t m_bStopped = 0x220;
                inline constexpr std::ptrdiff_t m_flValues = 0x10;
                inline constexpr std::ptrdiff_t m_flInterval = 0x214;
                inline constexpr std::ptrdiff_t m_flFinalValue = 0x218;
                inline constexpr std::ptrdiff_t m_nBucketCount = 0x210;
                inline constexpr std::ptrdiff_t m_nValueCounts = 0x110;
                inline constexpr std::ptrdiff_t m_nCompressionType = 0x21C;
            }
            namespace C_Chicken {
                inline constexpr std::ptrdiff_t m_owner = 0x14C4;
                inline constexpr std::ptrdiff_t m_leader = 0x14C0;
                inline constexpr std::ptrdiff_t m_bIsPreviewModel = 0x1AE0;
                inline constexpr std::ptrdiff_t m_AttributeManager = 0x14C8;
                inline constexpr std::ptrdiff_t m_hWaterWakeParticles = 0x1ADC;
                inline constexpr std::ptrdiff_t m_bSpawnDyingParticles = 0x1B68;
                inline constexpr std::ptrdiff_t m_bAttributesInitialized = 0x1AD8;
            }
            namespace C_EnvWind {
                inline constexpr std::ptrdiff_t m_EnvWindShared = 0x600;
            }
            namespace C_Hostage {
                inline constexpr std::ptrdiff_t m_vel = 0x1328;
                inline constexpr std::ptrdiff_t m_isInit = 0x13A8;
                inline constexpr std::ptrdiff_t m_leader = 0x1308;
                inline constexpr std::ptrdiff_t m_lookAt = 0x1380;
                inline constexpr std::ptrdiff_t m_isRescued = 0x1334;
                inline constexpr std::ptrdiff_t m_blinkTimer = 0x1368;
                inline constexpr std::ptrdiff_t m_reuseTimer = 0x1310;
                inline constexpr std::ptrdiff_t m_eyeAttachment = 0x13A9;
                inline constexpr std::ptrdiff_t m_fLastGrabTime = 0x1344;
                inline constexpr std::ptrdiff_t m_nHostageState = 0x1338;
                inline constexpr std::ptrdiff_t m_vecGrabbedPos = 0x1348;
                inline constexpr std::ptrdiff_t m_chestAttachment = 0x13AA;
                inline constexpr std::ptrdiff_t m_flDropStartTime = 0x135C;
                inline constexpr std::ptrdiff_t m_hHostageGrabber = 0x1340;
                inline constexpr std::ptrdiff_t m_jumpedThisFrame = 0x1335;
                inline constexpr std::ptrdiff_t m_lookAroundTimer = 0x1390;
                inline constexpr std::ptrdiff_t m_pPredictionOwner = 0x13B0;
                inline constexpr std::ptrdiff_t m_bHandsHaveBeenCut = 0x133C;
                inline constexpr std::ptrdiff_t m_flGrabSuccessTime = 0x1358;
                inline constexpr std::ptrdiff_t m_flRescueStartTime = 0x1354;
                inline constexpr std::ptrdiff_t m_entitySpottedState = 0x12F0;
                inline constexpr std::ptrdiff_t m_flDeadOrRescuedTime = 0x1360;
                inline constexpr std::ptrdiff_t m_fNewestAlphaThinkTime = 0x13B8;
            }
            namespace C_Inferno {
                inline constexpr std::ptrdiff_t m_blosCheck = 0x8664;
                inline constexpr std::ptrdiff_t m_fireCount = 0x1A48;
                inline constexpr std::ptrdiff_t m_maxBounds = 0x8680;
                inline constexpr std::ptrdiff_t m_minBounds = 0x8674;
                inline constexpr std::ptrdiff_t m_BurnNormal = 0x1748;
                inline constexpr std::ptrdiff_t m_nlosperiod = 0x8668;
                inline constexpr std::ptrdiff_t m_nInfernoType = 0x1A4C;
                inline constexpr std::ptrdiff_t m_drawableCount = 0x8660;
                inline constexpr std::ptrdiff_t m_firePositions = 0x1108;
                inline constexpr std::ptrdiff_t m_lastFireCount = 0x1A58;
                inline constexpr std::ptrdiff_t m_maxFireHeight = 0x8670;
                inline constexpr std::ptrdiff_t m_nFireLifetime = 0x1A50;
                inline constexpr std::ptrdiff_t m_bFireIsBurning = 0x1708;
                inline constexpr std::ptrdiff_t m_maxFireHalfWidth = 0x866C;
                inline constexpr std::ptrdiff_t m_bInPostEffectTime = 0x1A54;
                inline constexpr std::ptrdiff_t m_fireParentPositions = 0x1408;
                inline constexpr std::ptrdiff_t m_nfxFireDamageEffect = 0x10D8;
                inline constexpr std::ptrdiff_t m_flLastGrassBurnThink = 0x868C;
                inline constexpr std::ptrdiff_t m_nFireEffectTickBegin = 0x1A5C;
                inline constexpr std::ptrdiff_t m_hInfernoDecalsSnapshot = 0x1100;
                inline constexpr std::ptrdiff_t m_hInfernoPointsSnapshot = 0x10E0;
                inline constexpr std::ptrdiff_t m_hInfernoFillerPointsSnapshot = 0x10E8;
                inline constexpr std::ptrdiff_t m_hInfernoOutlinePointsSnapshot = 0x10F0;
                inline constexpr std::ptrdiff_t m_hInfernoClimbingOutlinePointsSnapshot = 0x10F8;
            }
            namespace C_PhysBox {

            }
            namespace CCashStack {
                inline constexpr std::ptrdiff_t m_nCashStackValue = 0x1098;
            }
            namespace CFilterLOS {

            }
            namespace CFuncWater {
                inline constexpr std::ptrdiff_t m_BuoyancyHelper = 0x1098;
            }
            namespace C_BaseDoor {
                inline constexpr std::ptrdiff_t m_bIsUsable = 0x1098;
            }
            namespace C_EnvDecal {
                inline constexpr std::ptrdiff_t m_flDepth = 0x10A8;
                inline constexpr std::ptrdiff_t m_flWidth = 0x10A0;
                inline constexpr std::ptrdiff_t m_flHeight = 0x10A4;
                inline constexpr std::ptrdiff_t m_nRenderOrder = 0x10AC;
                inline constexpr std::ptrdiff_t m_hDecalMaterial = 0x1098;
                inline constexpr std::ptrdiff_t m_bProjectOnWater = 0x10B2;
                inline constexpr std::ptrdiff_t m_bProjectOnWorld = 0x10B0;
                inline constexpr std::ptrdiff_t m_flDepthSortBias = 0x10B4;
                inline constexpr std::ptrdiff_t m_bProjectOnCharacters = 0x10B1;
            }
            namespace TimedEvent {
                inline constexpr std::ptrdiff_t m_fNextEvent = 0x4;
                inline constexpr std::ptrdiff_t m_TimeBetweenEvents = 0x0;
            }
            namespace CBaseFilter {
                inline constexpr std::ptrdiff_t m_OnFail = 0x620;
                inline constexpr std::ptrdiff_t m_OnPass = 0x608;
                inline constexpr std::ptrdiff_t m_bNegated = 0x600;
            }
            namespace CBombTarget {
                inline constexpr std::ptrdiff_t m_bBombPlantedHere = 0x1180;
            }
            namespace CEffectData {
                inline constexpr std::ptrdiff_t m_fFlags = 0x63;
                inline constexpr std::ptrdiff_t m_nColor = 0x62;
                inline constexpr std::ptrdiff_t m_vStart = 0x14;
                inline constexpr std::ptrdiff_t m_flScale = 0x40;
                inline constexpr std::ptrdiff_t m_hEntity = 0x38;
                inline constexpr std::ptrdiff_t m_nHitBox = 0x60;
                inline constexpr std::ptrdiff_t m_vAngles = 0x2C;
                inline constexpr std::ptrdiff_t m_vNormal = 0x20;
                inline constexpr std::ptrdiff_t m_vOrigin = 0x8;
                inline constexpr std::ptrdiff_t m_flRadius = 0x48;
                inline constexpr std::ptrdiff_t m_nMaterial = 0x5E;
                inline constexpr std::ptrdiff_t m_nPenetrate = 0x5C;
                inline constexpr std::ptrdiff_t m_flMagnitude = 0x44;
                inline constexpr std::ptrdiff_t m_iEffectName = 0x6C;
                inline constexpr std::ptrdiff_t m_nDamageType = 0x58;
                inline constexpr std::ptrdiff_t m_hOtherEntity = 0x3C;
                inline constexpr std::ptrdiff_t m_nEffectIndex = 0x50;
                inline constexpr std::ptrdiff_t m_nSurfaceProp = 0x4C;
                inline constexpr std::ptrdiff_t m_nAttachmentName = 0x68;
                inline constexpr std::ptrdiff_t m_nAttachmentIndex = 0x64;
            }
            namespace CFilterName {
                inline constexpr std::ptrdiff_t m_iFilterName = 0x638;
            }
            namespace CFilterTeam {
                inline constexpr std::ptrdiff_t m_iFilterTeam = 0x638;
            }
            namespace CInfoTarget {

            }
            namespace CLogicRelay {
                inline constexpr std::ptrdiff_t m_OnSpawn = 0x600;
                inline constexpr std::ptrdiff_t m_OnTrigger = 0x618;
                inline constexpr std::ptrdiff_t m_bDisabled = 0x630;
                inline constexpr std::ptrdiff_t m_bTriggerOnce = 0x632;
                inline constexpr std::ptrdiff_t m_bFastRetrigger = 0x633;
                inline constexpr std::ptrdiff_t m_bWaitForRefire = 0x631;
                inline constexpr std::ptrdiff_t m_bPassthoughCaller = 0x634;
            }
            namespace CModelState {
                inline constexpr std::ptrdiff_t m_hModel = 0xA0;
                inline constexpr std::ptrdiff_t m_ModelName = 0xA8;
                inline constexpr std::ptrdiff_t m_nForceLOD = 0x2A3;
                inline constexpr std::ptrdiff_t m_MeshGroupMask = 0x208;
                inline constexpr std::ptrdiff_t m_nIdealMotionType = 0x2A2;
                inline constexpr std::ptrdiff_t m_nBodyGroupChoices = 0x258;
                inline constexpr std::ptrdiff_t m_nClothUpdateFlags = 0x2A4;
                inline constexpr std::ptrdiff_t m_flRootBoneOffset_x = 0xE8;
                inline constexpr std::ptrdiff_t m_flRootBoneOffset_y = 0xEC;
                inline constexpr std::ptrdiff_t m_flRootBoneOffset_z = 0xF0;
                inline constexpr std::ptrdiff_t m_pVPhysicsAggregate = 0xE0;
                inline constexpr std::ptrdiff_t m_bClientClothCreationSuppressed = 0x110;
                inline constexpr std::ptrdiff_t m_nAnimStateNoInterpSerialNumber = 0x200;
                inline constexpr std::ptrdiff_t m_nRootBoneOffsetResetSerialNumber = 0xF4;
            }
            namespace CPathSimple {
                inline constexpr std::ptrdiff_t m_pathString = 0x700;
                inline constexpr std::ptrdiff_t m_bClosedLoop = 0x708;
                inline constexpr std::ptrdiff_t m_CPathQueryComponent = 0x610;
            }
            namespace CTriggerFan {
                inline constexpr std::ptrdiff_t m_flForce = 0x11B4;
                inline constexpr std::ptrdiff_t m_bFalloff = 0x11B8;
                inline constexpr std::ptrdiff_t m_hInfoFan = 0x11B0;
                inline constexpr std::ptrdiff_t m_RampTimer = 0x11C0;
                inline constexpr std::ptrdiff_t m_vDirection = 0x118C;
                inline constexpr std::ptrdiff_t m_qNoiseDelta = 0x11A0;
                inline constexpr std::ptrdiff_t m_vFanOriginOffset = 0x1180;
                inline constexpr std::ptrdiff_t m_bPushTowardsInfoTarget = 0x1198;
                inline constexpr std::ptrdiff_t m_bPushAwayFromInfoTarget = 0x1199;
            }
            namespace C_BarnLight {
                inline constexpr std::ptrdiff_t m_nFog = 0x1200;
                inline constexpr std::ptrdiff_t m_Color = 0x10A0;
                inline constexpr std::ptrdiff_t m_vShear = 0x11B4;
                inline constexpr std::ptrdiff_t m_flRange = 0x11B0;
                inline constexpr std::ptrdiff_t m_flShape = 0x1190;
                inline constexpr std::ptrdiff_t m_flSkirt = 0x119C;
                inline constexpr std::ptrdiff_t m_flSoftX = 0x1194;
                inline constexpr std::ptrdiff_t m_flSoftY = 0x1198;
                inline constexpr std::ptrdiff_t m_bEnabled = 0x1098;
                inline constexpr std::ptrdiff_t m_StyleEvent = 0x1128;
                inline constexpr std::ptrdiff_t m_flFogScale = 0x120C;
                inline constexpr std::ptrdiff_t m_nColorMode = 0x109C;
                inline constexpr std::ptrdiff_t m_VisClusters = 0x1388;
                inline constexpr std::ptrdiff_t m_flSkirtNear = 0x11A0;
                inline constexpr std::ptrdiff_t m_nFogShadows = 0x1208;
                inline constexpr std::ptrdiff_t m_vSizeParams = 0x11A4;
                inline constexpr std::ptrdiff_t m_flBrightness = 0x10A8;
                inline constexpr std::ptrdiff_t m_hLightCookie = 0x1188;
                inline constexpr std::ptrdiff_t m_nBounceLight = 0x11E4;
                inline constexpr std::ptrdiff_t m_nCastShadows = 0x11D4;
                inline constexpr std::ptrdiff_t m_nDirectLight = 0x10B0;
                inline constexpr std::ptrdiff_t m_flBounceScale = 0x11E8;
                inline constexpr std::ptrdiff_t m_flFadeSizeEnd = 0x1214;
                inline constexpr std::ptrdiff_t m_flFogStrength = 0x1204;
                inline constexpr std::ptrdiff_t m_bContactShadow = 0x11E0;
                inline constexpr std::ptrdiff_t m_flMinRoughness = 0x11EC;
                inline constexpr std::ptrdiff_t m_nShadowMapSize = 0x11D8;
                inline constexpr std::ptrdiff_t m_flFadeSizeStart = 0x1210;
                inline constexpr std::ptrdiff_t m_flLuminaireSize = 0x10C4;
                inline constexpr std::ptrdiff_t m_nLuminaireShape = 0x10C0;
                inline constexpr std::ptrdiff_t m_nShadowPriority = 0x11DC;
                inline constexpr std::ptrdiff_t m_vAlternateColor = 0x11F0;
                inline constexpr std::ptrdiff_t m_LightStyleEvents = 0x10F8;
                inline constexpr std::ptrdiff_t m_LightStyleString = 0x10D0;
                inline constexpr std::ptrdiff_t m_LightStyleTargets = 0x1110;
                inline constexpr std::ptrdiff_t m_bInitialBoneSetup = 0x1380;
                inline constexpr std::ptrdiff_t m_flBrightnessScale = 0x10AC;
                inline constexpr std::ptrdiff_t m_nBakedShadowIndex = 0x10B4;
                inline constexpr std::ptrdiff_t m_nLightMapUniqueId = 0x10BC;
                inline constexpr std::ptrdiff_t m_flColorTemperature = 0x10A4;
                inline constexpr std::ptrdiff_t m_nLightPathUniqueId = 0x10B8;
                inline constexpr std::ptrdiff_t m_flShadowFadeSizeEnd = 0x121C;
                inline constexpr std::ptrdiff_t m_bForceShadowsEnabled = 0x11E1;
                inline constexpr std::ptrdiff_t m_flLightStyleStartTime = 0x10D8;
                inline constexpr std::ptrdiff_t m_flLuminaireAnisotropy = 0x10C8;
                inline constexpr std::ptrdiff_t m_flShadowFadeSizeStart = 0x1218;
                inline constexpr std::ptrdiff_t m_nPrecomputedSubFrusta = 0x1260;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBAngles = 0x1248;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBExtent = 0x1254;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBOrigin = 0x123C;
                inline constexpr std::ptrdiff_t m_vPrecomputedBoundsMaxs = 0x1230;
                inline constexpr std::ptrdiff_t m_vPrecomputedBoundsMins = 0x1224;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBAngles0 = 0x1270;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBAngles1 = 0x1294;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBAngles2 = 0x12B8;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBAngles3 = 0x12DC;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBAngles4 = 0x1300;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBAngles5 = 0x1324;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBExtent0 = 0x127C;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBExtent1 = 0x12A0;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBExtent2 = 0x12C4;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBExtent3 = 0x12E8;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBExtent4 = 0x130C;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBExtent5 = 0x1330;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBOrigin0 = 0x1264;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBOrigin1 = 0x1288;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBOrigin2 = 0x12AC;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBOrigin3 = 0x12D0;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBOrigin4 = 0x12F4;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBOrigin5 = 0x1318;
                inline constexpr std::ptrdiff_t m_QueuedLightStyleStrings = 0x10E0;
                inline constexpr std::ptrdiff_t m_bPrecomputedFieldsValid = 0x1220;
                inline constexpr std::ptrdiff_t m_nBakeSpecularToCubemaps = 0x11C0;
                inline constexpr std::ptrdiff_t m_fAlternateColorBrightness = 0x11FC;
                inline constexpr std::ptrdiff_t m_vBakeSpecularToCubemapsSize = 0x11C4;
                inline constexpr std::ptrdiff_t m_flBakeSpecularToCubemapsScale = 0x11D0;
            }
            namespace C_Breakable {

            }
            namespace C_Flashbang {

            }
            namespace C_FuncBrush {

            }
            namespace C_FuncMover {

            }
            namespace C_GameRules {
                inline constexpr std::ptrdiff_t m_bGamePaused = 0x38;
                inline constexpr std::ptrdiff_t __m_pChainEntity = 0x8;
                inline constexpr std::ptrdiff_t m_nPauseStartTick = 0x34;
                inline constexpr std::ptrdiff_t m_nTotalPausedTicks = 0x30;
            }
            namespace C_HEGrenade {

            }
            namespace C_OmniLight {
                inline constexpr std::ptrdiff_t m_bShowLight = 0x13B0;
                inline constexpr std::ptrdiff_t m_flInnerAngle = 0x13A8;
                inline constexpr std::ptrdiff_t m_flOuterAngle = 0x13AC;
            }
            namespace C_PlantedC4 {
                inline constexpr std::ptrdiff_t m_flC4Blow = 0x12B8;
                inline constexpr std::ptrdiff_t m_nBombSite = 0x128C;
                inline constexpr std::ptrdiff_t m_flNextBeep = 0x12B4;
                inline constexpr std::ptrdiff_t m_flNextGlow = 0x12B0;
                inline constexpr std::ptrdiff_t m_bRadarFlash = 0x1900;
                inline constexpr std::ptrdiff_t m_bBombDefused = 0x12DC;
                inline constexpr std::ptrdiff_t m_bBombTicking = 0x1288;
                inline constexpr std::ptrdiff_t m_bC4Activated = 0x12D0;
                inline constexpr std::ptrdiff_t m_bHasExploded = 0x12BD;
                inline constexpr std::ptrdiff_t m_hBombDefuser = 0x12E0;
                inline constexpr std::ptrdiff_t m_pBombDefuser = 0x1904;
                inline constexpr std::ptrdiff_t m_bBeingDefused = 0x12C4;
                inline constexpr std::ptrdiff_t m_flTimerLength = 0x12C0;
                inline constexpr std::ptrdiff_t m_bTenSecWarning = 0x12D1;
                inline constexpr std::ptrdiff_t m_flDefuseLength = 0x12D4;
                inline constexpr std::ptrdiff_t m_bExplodeWarning = 0x12CC;
                inline constexpr std::ptrdiff_t m_bTriggerWarning = 0x12C8;
                inline constexpr std::ptrdiff_t m_fLastDefuseTime = 0x1908;
                inline constexpr std::ptrdiff_t m_AttributeManager = 0x12E8;
                inline constexpr std::ptrdiff_t m_bCannotBeDefused = 0x12BC;
                inline constexpr std::ptrdiff_t m_pPredictionOwner = 0x1910;
                inline constexpr std::ptrdiff_t m_flDefuseCountDown = 0x12D8;
                inline constexpr std::ptrdiff_t m_entitySpottedState = 0x1298;
                inline constexpr std::ptrdiff_t m_hDefuserMultimeter = 0x18F8;
                inline constexpr std::ptrdiff_t m_flNextRadarFlashTime = 0x18FC;
                inline constexpr std::ptrdiff_t m_nSourceSoundscapeHash = 0x1290;
                inline constexpr std::ptrdiff_t m_vecC4ExplodeSpectateAng = 0x1924;
                inline constexpr std::ptrdiff_t m_vecC4ExplodeSpectatePos = 0x1918;
                inline constexpr std::ptrdiff_t m_flC4ExplodeSpectateDuration = 0x1930;
            }
            namespace C_RectLight {
                inline constexpr std::ptrdiff_t m_bShowLight = 0x13A8;
            }
            namespace C_SkyCamera {
                inline constexpr std::ptrdiff_t m_pNext = 0x698;
                inline constexpr std::ptrdiff_t m_bUseAngles = 0x694;
                inline constexpr std::ptrdiff_t m_skyboxData = 0x600;
                inline constexpr std::ptrdiff_t m_skyboxSlotToken = 0x690;
            }
            namespace C_WeaponAWP {

            }
            namespace C_WeaponAug {

            }
            namespace C_WeaponMP7 {

            }
            namespace C_WeaponMP9 {

            }
            namespace C_WeaponP90 {

            }
            namespace fogparams_t {
                inline constexpr std::ptrdiff_t end = 0x28;
                inline constexpr std::ptrdiff_t farz = 0x2C;
                inline constexpr std::ptrdiff_t blend = 0x65;
                inline constexpr std::ptrdiff_t start = 0x24;
                inline constexpr std::ptrdiff_t enable = 0x64;
                inline constexpr std::ptrdiff_t duration = 0x54;
                inline constexpr std::ptrdiff_t exponent = 0x34;
                inline constexpr std::ptrdiff_t lerptime = 0x50;
                inline constexpr std::ptrdiff_t endLerpTo = 0x48;
                inline constexpr std::ptrdiff_t dirPrimary = 0x8;
                inline constexpr std::ptrdiff_t m_bPadding = 0x67;
                inline constexpr std::ptrdiff_t maxdensity = 0x30;
                inline constexpr std::ptrdiff_t scattering = 0x5C;
                inline constexpr std::ptrdiff_t m_bPadding2 = 0x66;
                inline constexpr std::ptrdiff_t startLerpTo = 0x44;
                inline constexpr std::ptrdiff_t colorPrimary = 0x14;
                inline constexpr std::ptrdiff_t HDRColorScale = 0x38;
                inline constexpr std::ptrdiff_t colorSecondary = 0x18;
                inline constexpr std::ptrdiff_t locallightscale = 0x60;
                inline constexpr std::ptrdiff_t skyboxFogFactor = 0x3C;
                inline constexpr std::ptrdiff_t maxdensityLerpTo = 0x4C;
                inline constexpr std::ptrdiff_t blendtobackground = 0x58;
                inline constexpr std::ptrdiff_t colorPrimaryLerpTo = 0x1C;
                inline constexpr std::ptrdiff_t colorSecondaryLerpTo = 0x20;
                inline constexpr std::ptrdiff_t skyboxFogFactorLerpTo = 0x40;
            }
            namespace CFilterClass {
                inline constexpr std::ptrdiff_t m_iFilterClass = 0x638;
            }
            namespace CFilterModel {
                inline constexpr std::ptrdiff_t m_iFilterModel = 0x638;
            }
            namespace CPointOrient {
                inline constexpr std::ptrdiff_t m_bActive = 0x60C;
                inline constexpr std::ptrdiff_t m_hTarget = 0x608;
                inline constexpr std::ptrdiff_t m_nConstraint = 0x614;
                inline constexpr std::ptrdiff_t m_flMaxTurnRate = 0x618;
                inline constexpr std::ptrdiff_t m_flLastGameTime = 0x61C;
                inline constexpr std::ptrdiff_t m_nGoalDirection = 0x610;
                inline constexpr std::ptrdiff_t m_iszSpawnTargetName = 0x600;
            }
            namespace C_BaseButton {
                inline constexpr std::ptrdiff_t m_usable = 0x109C;
                inline constexpr std::ptrdiff_t m_glowEntity = 0x1098;
                inline constexpr std::ptrdiff_t m_szDisplayText = 0x10A0;
            }
            namespace C_BaseEntity {
                inline constexpr std::ptrdiff_t m_fFlags = 0x3F4;
                inline constexpr std::ptrdiff_t m_hThink = 0x550;
                inline constexpr std::ptrdiff_t m_iEFlags = 0x374;
                inline constexpr std::ptrdiff_t m_iHealth = 0x34C;
                inline constexpr std::ptrdiff_t m_MoveType = 0x525;
                inline constexpr std::ptrdiff_t m_fEffects = 0x52C;
                inline constexpr std::ptrdiff_t m_iTeamNum = 0x3E7;
                inline constexpr std::ptrdiff_t m_ListEntry = 0x3C8;
                inline constexpr std::ptrdiff_t m_Particles = 0x578;
                inline constexpr std::ptrdiff_t m_lifeState = 0x354;
                inline constexpr std::ptrdiff_t m_flAnimTime = 0x3B4;
                inline constexpr std::ptrdiff_t m_flFriction = 0x538;
                inline constexpr std::ptrdiff_t m_iMaxHealth = 0x348;
                inline constexpr std::ptrdiff_t m_nBloodType = 0x5F8;
                inline constexpr std::ptrdiff_t m_nWaterType = 0x378;
                inline constexpr std::ptrdiff_t m_pCollision = 0x340;
                inline constexpr std::ptrdiff_t m_spawnflags = 0x3E8;
                inline constexpr std::ptrdiff_t m_MoveCollide = 0x524;
                inline constexpr std::ptrdiff_t m_flTimeScale = 0x544;
                inline constexpr std::ptrdiff_t m_nSubclassID = 0x380;
                inline constexpr std::ptrdiff_t m_vecVelocity = 0x430;
                inline constexpr std::ptrdiff_t m_bPredictable = 0x569;
                inline constexpr std::ptrdiff_t m_bTakesDamage = 0x355;
                inline constexpr std::ptrdiff_t m_dependencies = 0x5B8;
                inline constexpr std::ptrdiff_t m_flCreateTime = 0x3E0;
                inline constexpr std::ptrdiff_t m_flElasticity = 0x53C;
                inline constexpr std::ptrdiff_t m_flWaterLevel = 0x528;
                inline constexpr std::ptrdiff_t m_hOwnerEntity = 0x520;
                inline constexpr std::ptrdiff_t m_fBBoxVisFlags = 0x560;
                inline constexpr std::ptrdiff_t m_hEffectEntity = 0x51C;
                inline constexpr std::ptrdiff_t m_hGroundEntity = 0x530;
                inline constexpr std::ptrdiff_t m_nCreationTick = 0x5D0;
                inline constexpr std::ptrdiff_t m_nPlatformType = 0x360;
                inline constexpr std::ptrdiff_t m_CBodyComponent = 0x30;
                inline constexpr std::ptrdiff_t m_EntClientFlags = 0x3E4;
                inline constexpr std::ptrdiff_t m_flGravityScale = 0x540;
                inline constexpr std::ptrdiff_t m_hOldMoveParent = 0x574;
                inline constexpr std::ptrdiff_t m_nLastThinkTick = 0x328;
                inline constexpr std::ptrdiff_t m_nNextThinkTick = 0x3EC;
                inline constexpr std::ptrdiff_t m_pGameSceneNode = 0x330;
                inline constexpr std::ptrdiff_t m_vecAbsVelocity = 0x3F8;
                inline constexpr std::ptrdiff_t m_vecAngVelocity = 0x5A8;
                inline constexpr std::ptrdiff_t m_aThinkFunctions = 0x398;
                inline constexpr std::ptrdiff_t m_nActualMoveType = 0x526;
                inline constexpr std::ptrdiff_t m_nSimulationTick = 0x390;
                inline constexpr std::ptrdiff_t m_sUniqueHammerID = 0x5F0;
                inline constexpr std::ptrdiff_t m_tokLayerMatchID = 0x37C;
                inline constexpr std::ptrdiff_t m_vecBaseVelocity = 0x510;
                inline constexpr std::ptrdiff_t m_bAnimTimeChanged = 0x5E1;
                inline constexpr std::ptrdiff_t m_bGravityDisabled = 0x549;
                inline constexpr std::ptrdiff_t m_flSimulationTime = 0x3B8;
                inline constexpr std::ptrdiff_t m_nGroundBodyIndex = 0x534;
                inline constexpr std::ptrdiff_t m_nTakeDamageFlags = 0x358;
                inline constexpr std::ptrdiff_t m_pRenderComponent = 0x338;
                inline constexpr std::ptrdiff_t m_vecServerVelocity = 0x404;
                inline constexpr std::ptrdiff_t m_DataChangeEventRef = 0x5B4;
                inline constexpr std::ptrdiff_t m_bAnimatedEveryTick = 0x548;
                inline constexpr std::ptrdiff_t m_bClientSideRagdoll = 0x3E6;
                inline constexpr std::ptrdiff_t m_flProxyRandomValue = 0x370;
                inline constexpr std::ptrdiff_t m_bPredictionEligible = 0x37A;
                inline constexpr std::ptrdiff_t m_flDamageAccumulator = 0x350;
                inline constexpr std::ptrdiff_t m_flActualGravityScale = 0x564;
                inline constexpr std::ptrdiff_t m_flNavIgnoreUntilTime = 0x54C;
                inline constexpr std::ptrdiff_t m_iCurrentThinkContext = 0x394;
                inline constexpr std::ptrdiff_t m_nNoInterpolationTick = 0x368;
                inline constexpr std::ptrdiff_t m_ubInterpolationFrame = 0x361;
                inline constexpr std::ptrdiff_t m_bRenderWithViewModels = 0x56A;
                inline constexpr std::ptrdiff_t m_bDisabledContextThinks = 0x3B0;
                inline constexpr std::ptrdiff_t m_bSimulationTimeChanged = 0x5E2;
                inline constexpr std::ptrdiff_t m_hSceneObjectController = 0x364;
                inline constexpr std::ptrdiff_t m_nLastPredictableCommand = 0x570;
                inline constexpr std::ptrdiff_t m_NetworkTransmitComponent = 0x38;
                inline constexpr std::ptrdiff_t m_bGravityActuallyDisabled = 0x568;
                inline constexpr std::ptrdiff_t m_nFirstPredictableCommand = 0x56C;
                inline constexpr std::ptrdiff_t m_bApplyLayerMatchIDToModel = 0x37B;
                inline constexpr std::ptrdiff_t m_nSceneObjectOverrideFlags = 0x3BC;
                inline constexpr std::ptrdiff_t m_bInterpolateEvenWithNoModel = 0x379;
                inline constexpr std::ptrdiff_t m_bHasAddedVarsToInterpolation = 0x3BE;
                inline constexpr std::ptrdiff_t m_bHasSuccessfullyInterpolated = 0x3BD;
                inline constexpr std::ptrdiff_t m_nInterpolationLatchDirtyFlags = 0x3C0;
                inline constexpr std::ptrdiff_t m_nVisibilityNoInterpolationTick = 0x36C;
                inline constexpr std::ptrdiff_t m_bRenderEvenWhenNotSuccessfullyInterpolated = 0x3BF;
            }
            namespace C_BaseToggle {

            }
            namespace C_EconEntity {
                inline constexpr std::ptrdiff_t m_iOldTeam = 0x18DC;
                inline constexpr std::ptrdiff_t m_bClientside = 0x18B8;
                inline constexpr std::ptrdiff_t m_hOldProvidee = 0x18F8;
                inline constexpr std::ptrdiff_t m_nFallbackSeed = 0x18AC;
                inline constexpr std::ptrdiff_t m_flFallbackWear = 0x18B0;
                inline constexpr std::ptrdiff_t m_flFlexDelayTime = 0x1278;
                inline constexpr std::ptrdiff_t m_AttributeManager = 0x1290;
                inline constexpr std::ptrdiff_t m_bAttachmentDirty = 0x18E0;
                inline constexpr std::ptrdiff_t m_nFallbackPaintKit = 0x18A8;
                inline constexpr std::ptrdiff_t m_nFallbackStatTrak = 0x18B4;
                inline constexpr std::ptrdiff_t m_vecAttachedModels = 0x1900;
                inline constexpr std::ptrdiff_t m_flFlexDelayedWeight = 0x1280;
                inline constexpr std::ptrdiff_t m_nUnloadedModelIndex = 0x18E4;
                inline constexpr std::ptrdiff_t m_OriginalOwnerXuidLow = 0x18A0;
                inline constexpr std::ptrdiff_t m_hViewmodelAttachment = 0x18D8;
                inline constexpr std::ptrdiff_t m_vecAttachedParticles = 0x18C0;
                inline constexpr std::ptrdiff_t m_OriginalOwnerXuidHigh = 0x18A4;
                inline constexpr std::ptrdiff_t m_bAttributesInitialized = 0x1288;
                inline constexpr std::ptrdiff_t m_bParticleSystemsCreated = 0x18B9;
                inline constexpr std::ptrdiff_t m_iNumOwnerValidationRetries = 0x18E8;
            }
            namespace C_EnvCubemap {
                inline constexpr std::ptrdiff_t m_Entity_bEnabled = 0x6E0;
                inline constexpr std::ptrdiff_t m_Entity_bMoveable = 0x6A8;
                inline constexpr std::ptrdiff_t m_Entity_nPriority = 0x6B4;
                inline constexpr std::ptrdiff_t m_Entity_nHandshake = 0x6AC;
                inline constexpr std::ptrdiff_t m_Entity_bDefaultEnvMap = 0x6CD;
                inline constexpr std::ptrdiff_t m_Entity_bIndoorCubeMap = 0x6CF;
                inline constexpr std::ptrdiff_t m_Entity_bStartDisabled = 0x6CC;
                inline constexpr std::ptrdiff_t m_Entity_flDiffuseScale = 0x6C8;
                inline constexpr std::ptrdiff_t m_Entity_flEdgeFadeDist = 0x6B8;
                inline constexpr std::ptrdiff_t m_Entity_vEdgeFadeDists = 0x6BC;
                inline constexpr std::ptrdiff_t m_Entity_hCubemapTexture = 0x680;
                inline constexpr std::ptrdiff_t m_Entity_vBoxProjectMaxs = 0x69C;
                inline constexpr std::ptrdiff_t m_Entity_vBoxProjectMins = 0x690;
                inline constexpr std::ptrdiff_t m_Entity_flInfluenceRadius = 0x68C;
                inline constexpr std::ptrdiff_t m_Entity_bDefaultSpecEnvMap = 0x6CE;
                inline constexpr std::ptrdiff_t m_Entity_bCustomCubemapTexture = 0x688;
                inline constexpr std::ptrdiff_t m_Entity_nEnvCubeMapArrayIndex = 0x6B0;
                inline constexpr std::ptrdiff_t m_Entity_bCopyDiffuseFromDefaultCubemap = 0x6D0;
            }
            namespace C_FuncLadder {
                inline constexpr std::ptrdiff_t m_Dismounts = 0x10A8;
                inline constexpr std::ptrdiff_t m_bDisabled = 0x10E8;
                inline constexpr std::ptrdiff_t m_bHasSlack = 0x10EA;
                inline constexpr std::ptrdiff_t m_bFakeLadder = 0x10E9;
                inline constexpr std::ptrdiff_t m_vecLocalTop = 0x10C0;
                inline constexpr std::ptrdiff_t m_vecLadderDir = 0x1098;
                inline constexpr std::ptrdiff_t m_flAutoRideSpeed = 0x10E4;
                inline constexpr std::ptrdiff_t m_vecPlayerMountPositionTop = 0x10CC;
                inline constexpr std::ptrdiff_t m_vecPlayerMountPositionBottom = 0x10D8;
            }
            namespace C_HandleTest {
                inline constexpr std::ptrdiff_t m_Handle = 0x600;
                inline constexpr std::ptrdiff_t m_bSendHandle = 0x604;
            }
            namespace C_Multimeter {
                inline constexpr std::ptrdiff_t m_hTargetC4 = 0x1268;
            }
            namespace C_PhysMagnet {
                inline constexpr std::ptrdiff_t m_aAttachedObjects = 0x1280;
                inline constexpr std::ptrdiff_t m_aAttachedObjectsFromServer = 0x1268;
            }
            namespace C_PlayerPing {
                inline constexpr std::ptrdiff_t m_iType = 0x638;
                inline constexpr std::ptrdiff_t m_bUrgent = 0x63C;
                inline constexpr std::ptrdiff_t m_hPlayer = 0x630;
                inline constexpr std::ptrdiff_t m_szPlaceName = 0x63D;
                inline constexpr std::ptrdiff_t m_hPingedEntity = 0x634;
            }
            namespace C_WeaponM249 {

            }
            namespace C_WeaponM4A1 {

            }
            namespace C_WeaponMag7 {

            }
            namespace C_WeaponNOVA {

            }
            namespace C_WeaponP250 {

            }
            namespace C_WeaponTec9 {

            }
            namespace FilterHealth {
                inline constexpr std::ptrdiff_t m_iHealthMax = 0x640;
                inline constexpr std::ptrdiff_t m_iHealthMin = 0x63C;
                inline constexpr std::ptrdiff_t m_bAdrenalineActive = 0x638;
            }
            namespace screenfade_t {
                inline constexpr std::ptrdiff_t End = 0x4;
                inline constexpr std::ptrdiff_t Flags = 0x10;
                inline constexpr std::ptrdiff_t Reset = 0x8;
                inline constexpr std::ptrdiff_t Speed = 0x0;
                inline constexpr std::ptrdiff_t m_Color = 0xC;
            }
            namespace CDamageRecord {
                inline constexpr std::ptrdiff_t m_flDamage = 0x64;
                inline constexpr std::ptrdiff_t m_iNumHits = 0x6C;
                inline constexpr std::ptrdiff_t m_killType = 0x75;
                inline constexpr std::ptrdiff_t m_DamagerXuid = 0x50;
                inline constexpr std::ptrdiff_t m_PlayerDamager = 0x30;
                inline constexpr std::ptrdiff_t m_RecipientXuid = 0x58;
                inline constexpr std::ptrdiff_t m_bIsOtherEnemy = 0x74;
                inline constexpr std::ptrdiff_t m_PlayerRecipient = 0x34;
                inline constexpr std::ptrdiff_t m_flBulletsDamage = 0x60;
                inline constexpr std::ptrdiff_t m_iLastBulletUpdate = 0x70;
                inline constexpr std::ptrdiff_t m_szPlayerDamagerName = 0x40;
                inline constexpr std::ptrdiff_t m_flActualHealthRemoved = 0x68;
                inline constexpr std::ptrdiff_t m_szPlayerRecipientName = 0x48;
                inline constexpr std::ptrdiff_t m_hPlayerControllerDamager = 0x38;
                inline constexpr std::ptrdiff_t m_hPlayerControllerRecipient = 0x3C;
            }
            namespace CGlowProperty {
                inline constexpr std::ptrdiff_t m_bGlowing = 0x51;
                inline constexpr std::ptrdiff_t m_bFlashing = 0x44;
                inline constexpr std::ptrdiff_t m_iGlowTeam = 0x34;
                inline constexpr std::ptrdiff_t m_iGlowType = 0x30;
                inline constexpr std::ptrdiff_t m_fGlowColor = 0x8;
                inline constexpr std::ptrdiff_t m_flGlowTime = 0x48;
                inline constexpr std::ptrdiff_t m_nGlowRange = 0x38;
                inline constexpr std::ptrdiff_t m_nGlowRangeMin = 0x3C;
                inline constexpr std::ptrdiff_t m_flGlowStartTime = 0x4C;
                inline constexpr std::ptrdiff_t m_glowColorOverride = 0x40;
                inline constexpr std::ptrdiff_t m_bEligibleForScreenHighlight = 0x50;
            }
            namespace C_BaseGrenade {
                inline constexpr std::ptrdiff_t m_bIsLive = 0x126A;
                inline constexpr std::ptrdiff_t m_flDamage = 0x1278;
                inline constexpr std::ptrdiff_t m_hThrower = 0x1290;
                inline constexpr std::ptrdiff_t m_DmgRadius = 0x126C;
                inline constexpr std::ptrdiff_t m_bHasWarnedAI = 0x1268;
                inline constexpr std::ptrdiff_t m_flNextAttack = 0x12A8;
                inline constexpr std::ptrdiff_t m_flWarnAITime = 0x1274;
                inline constexpr std::ptrdiff_t m_ExplosionSound = 0x1288;
                inline constexpr std::ptrdiff_t m_flDetonateTime = 0x1270;
                inline constexpr std::ptrdiff_t m_iszBounceSound = 0x1280;
                inline constexpr std::ptrdiff_t m_bIsSmokeGrenade = 0x1269;
                inline constexpr std::ptrdiff_t m_hOriginalThrower = 0x12AC;
            }
            namespace C_BaseTrigger {
                inline constexpr std::ptrdiff_t m_hFilter = 0x1178;
                inline constexpr std::ptrdiff_t m_bDisabled = 0x117C;
                inline constexpr std::ptrdiff_t m_OnEndTouch = 0x10C8;
                inline constexpr std::ptrdiff_t m_OnTouching = 0x10F8;
                inline constexpr std::ptrdiff_t m_iFilterName = 0x1170;
                inline constexpr std::ptrdiff_t m_OnStartTouch = 0x1098;
                inline constexpr std::ptrdiff_t m_OnEndTouchAll = 0x10E0;
                inline constexpr std::ptrdiff_t m_OnNotTouching = 0x1128;
                inline constexpr std::ptrdiff_t m_OnStartTouchAll = 0x10B0;
                inline constexpr std::ptrdiff_t m_OnTouchingChanged = 0x1140;
                inline constexpr std::ptrdiff_t m_hTouchingEntities = 0x1158;
                inline constexpr std::ptrdiff_t m_OnTouchingEachEntity = 0x1110;
            }
            namespace C_CSGameRules {
                inline constexpr std::ptrdiff_t m_bLogoMap = 0xA5;
                inline constexpr std::ptrdiff_t m_bTCantBuy = 0x9B4;
                inline constexpr std::ptrdiff_t m_gamePhase = 0x84;
                inline constexpr std::ptrdiff_t m_bCTCantBuy = 0x9B5;
                inline constexpr std::ptrdiff_t m_bIsValveDS = 0xA4;
                inline constexpr std::ptrdiff_t m_iRoundTime = 0x68;
                inline constexpr std::ptrdiff_t m_MatchDevice = 0xAC;
                inline constexpr std::ptrdiff_t m_RetakeRules = 0xDA0;
                inline constexpr std::ptrdiff_t m_iFreezeTime = 0x64;
                inline constexpr std::ptrdiff_t m_nCTTimeOuts = 0x5C;
                inline constexpr std::ptrdiff_t m_bBombDropped = 0x9A8;
                inline constexpr std::ptrdiff_t m_bBombPlanted = 0x8C7;
                inline constexpr std::ptrdiff_t m_bGameRestart = 0x78;
                inline constexpr std::ptrdiff_t m_vMinimapMaxs = 0xC2C;
                inline constexpr std::ptrdiff_t m_vMinimapMins = 0xC20;
                inline constexpr std::ptrdiff_t m_bFreezePeriod = 0x40;
                inline constexpr std::ptrdiff_t m_bIsHltvActive = 0x8C6;
                inline constexpr std::ptrdiff_t m_bWarmupPeriod = 0x41;
                inline constexpr std::ptrdiff_t m_numBestOfMaps = 0x9A0;
                inline constexpr std::ptrdiff_t m_bMapHasBuyZone = 0x9B;
                inline constexpr std::ptrdiff_t m_nMatchEndCount = 0xEF8;
                inline constexpr std::ptrdiff_t m_nRoundEndCount = 0xF44;
                inline constexpr std::ptrdiff_t m_pGameModeRules = 0xD98;
                inline constexpr std::ptrdiff_t m_szMatchStatTxt = 0x4B8;
                inline constexpr std::ptrdiff_t m_eRoundEndReason = 0xF0C;
                inline constexpr std::ptrdiff_t m_eRoundWinReason = 0x9B0;
                inline constexpr std::ptrdiff_t m_fMatchStartTime = 0x6C;
                inline constexpr std::ptrdiff_t m_fRoundStartTime = 0x70;
                inline constexpr std::ptrdiff_t m_flGameStartTime = 0x7C;
                inline constexpr std::ptrdiff_t m_iRoundEndLegacy = 0xF40;
                inline constexpr std::ptrdiff_t m_iRoundWinStatus = 0x9AC;
                inline constexpr std::ptrdiff_t m_ullLocalMatchID = 0xC58;
                inline constexpr std::ptrdiff_t m_bCTTimeOutActive = 0x4D;
                inline constexpr std::ptrdiff_t m_bHasMatchStarted = 0xB0;
                inline constexpr std::ptrdiff_t m_bIsDroppingItems = 0x8C4;
                inline constexpr std::ptrdiff_t m_bIsQuestEligible = 0x8C5;
                inline constexpr std::ptrdiff_t m_bRoundEndNoMusic = 0xF3C;
                inline constexpr std::ptrdiff_t m_bTeamIntroPeriod = 0xF04;
                inline constexpr std::ptrdiff_t m_fWarmupPeriodEnd = 0x44;
                inline constexpr std::ptrdiff_t m_nOvertimePlaying = 0x90;
                inline constexpr std::ptrdiff_t m_nRoundStartCount = 0xF4C;
                inline constexpr std::ptrdiff_t m_sRoundEndMessage = 0xF30;
                inline constexpr std::ptrdiff_t m_bMapHasBombTarget = 0x99;
                inline constexpr std::ptrdiff_t m_bMapHasRescueZone = 0x9A;
                inline constexpr std::ptrdiff_t m_bTechnicalTimeOut = 0x60;
                inline constexpr std::ptrdiff_t m_flNextRespawnWave = 0xBA0;
                inline constexpr std::ptrdiff_t m_totalRoundsPlayed = 0x88;
                inline constexpr std::ptrdiff_t m_bAnyHostageReached = 0x98;
                inline constexpr std::ptrdiff_t m_fWarmupPeriodStart = 0x48;
                inline constexpr std::ptrdiff_t m_flRestartRoundTime = 0x74;
                inline constexpr std::ptrdiff_t m_iHostagesRemaining = 0x94;
                inline constexpr std::ptrdiff_t m_iRoundEndTimerTime = 0xF14;
                inline constexpr std::ptrdiff_t m_nNextMapInMapgroup = 0xB4;
                inline constexpr std::ptrdiff_t m_nTTeamIntroVariant = 0xEFC;
                inline constexpr std::ptrdiff_t m_nTerroristTimeOuts = 0x58;
                inline constexpr std::ptrdiff_t m_iRoundEndWinnerTeam = 0xF08;
                inline constexpr std::ptrdiff_t m_iSpectatorSlotCount = 0xA8;
                inline constexpr std::ptrdiff_t m_nCTTeamIntroVariant = 0xF00;
                inline constexpr std::ptrdiff_t m_TeamRespawnWaveTimes = 0xB20;
                inline constexpr std::ptrdiff_t m_bIsQueuedMatchmaking = 0x9C;
                inline constexpr std::ptrdiff_t m_flCTTimeOutRemaining = 0x54;
                inline constexpr std::ptrdiff_t m_flLastPerfSampleTime = 0x4F58;
                inline constexpr std::ptrdiff_t m_iRoundEndPlayerCount = 0xF38;
                inline constexpr std::ptrdiff_t m_iRoundEndFunFactData1 = 0xF24;
                inline constexpr std::ptrdiff_t m_iRoundEndFunFactData2 = 0xF28;
                inline constexpr std::ptrdiff_t m_iRoundEndFunFactData3 = 0xF2C;
                inline constexpr std::ptrdiff_t m_sRoundEndFunFactToken = 0xF18;
                inline constexpr std::ptrdiff_t m_szTournamentEventName = 0xB8;
                inline constexpr std::ptrdiff_t m_bMatchWaitingForResume = 0x61;
                inline constexpr std::ptrdiff_t m_iNumConsecutiveCTLoses = 0xCB4;
                inline constexpr std::ptrdiff_t m_iRoundStartRoundNumber = 0xF48;
                inline constexpr std::ptrdiff_t m_nEndMatchMapVoteWinner = 0xCB0;
                inline constexpr std::ptrdiff_t m_nHalloweenMaskListSeed = 0x9A4;
                inline constexpr std::ptrdiff_t m_nQueuedMatchmakingMode = 0xA0;
                inline constexpr std::ptrdiff_t m_nRoundsPlayedThisPhase = 0x8C;
                inline constexpr std::ptrdiff_t m_szTournamentEventStage = 0x2B8;
                inline constexpr std::ptrdiff_t m_bTerroristTimeOutActive = 0x4C;
                inline constexpr std::ptrdiff_t m_arrProhibitedItemIndices = 0x8C8;
                inline constexpr std::ptrdiff_t m_bRoundEndShowTimerDefend = 0xF10;
                inline constexpr std::ptrdiff_t m_iMatchStats_RoundResults = 0x9B8;
                inline constexpr std::ptrdiff_t m_nMatchAbortedEarlyReason = 0xD78;
                inline constexpr std::ptrdiff_t m_timeUntilNextPhaseStarts = 0x80;
                inline constexpr std::ptrdiff_t m_nTournamentPredictionsPct = 0x8B8;
                inline constexpr std::ptrdiff_t m_bPlayAllStepSoundsOnServer = 0xA6;
                inline constexpr std::ptrdiff_t m_flCMMItemDropRevealEndTime = 0x8C0;
                inline constexpr std::ptrdiff_t m_iMatchStats_PlayersAlive_T = 0xAA8;
                inline constexpr std::ptrdiff_t m_iRoundEndFunFactPlayerSlot = 0xF20;
                inline constexpr std::ptrdiff_t m_nEndMatchMapGroupVoteTypes = 0xC60;
                inline constexpr std::ptrdiff_t m_szTournamentPredictionsTxt = 0x6B8;
                inline constexpr std::ptrdiff_t m_bSwitchingTeamsAtRoundReset = 0xD7D;
                inline constexpr std::ptrdiff_t m_flTerroristTimeOutRemaining = 0x50;
                inline constexpr std::ptrdiff_t m_iMatchStats_PlayersAlive_CT = 0xA30;
                inline constexpr std::ptrdiff_t m_bHasTriggeredRoundStartMusic = 0xD7C;
                inline constexpr std::ptrdiff_t m_flCMMItemDropRevealStartTime = 0x8BC;
                inline constexpr std::ptrdiff_t m_nEndMatchMapGroupVoteOptions = 0xC88;
                inline constexpr std::ptrdiff_t m_MinimapVerticalSectionHeights = 0xC38;
                inline constexpr std::ptrdiff_t m_iNumConsecutiveTerroristLoses = 0xCB8;
                inline constexpr std::ptrdiff_t m_arrTournamentActiveCasterAccounts = 0x990;
            }
            namespace C_DynamicProp {
                inline constexpr std::ptrdiff_t m_glowColor = 0x1480;
                inline constexpr std::ptrdiff_t m_nGlowTeam = 0x1484;
                inline constexpr std::ptrdiff_t m_nGlowRange = 0x1478;
                inline constexpr std::ptrdiff_t m_iszIdleAnim = 0x1460;
                inline constexpr std::ptrdiff_t m_bUseAnimGraph = 0x13E2;
                inline constexpr std::ptrdiff_t m_nGlowRangeMin = 0x147C;
                inline constexpr std::ptrdiff_t m_bStartDisabled = 0x146D;
                inline constexpr std::ptrdiff_t m_bCreateNonSolid = 0x1471;
                inline constexpr std::ptrdiff_t m_bIsOverrideProp = 0x1472;
                inline constexpr std::ptrdiff_t m_bRandomizeCycle = 0x146C;
                inline constexpr std::ptrdiff_t m_pOutputAnimOver = 0x1400;
                inline constexpr std::ptrdiff_t m_OnAnimReachedEnd = 0x1448;
                inline constexpr std::ptrdiff_t m_bForceNpcExclude = 0x146F;
                inline constexpr std::ptrdiff_t m_pOutputAnimBegun = 0x13E8;
                inline constexpr std::ptrdiff_t m_iCachedFrameCount = 0x1488;
                inline constexpr std::ptrdiff_t m_iInitialGlowState = 0x1474;
                inline constexpr std::ptrdiff_t m_nIdleAnimLoopMode = 0x1468;
                inline constexpr std::ptrdiff_t m_OnAnimReachedStart = 0x1430;
                inline constexpr std::ptrdiff_t m_vecCachedRenderMaxs = 0x1498;
                inline constexpr std::ptrdiff_t m_vecCachedRenderMins = 0x148C;
                inline constexpr std::ptrdiff_t m_bFiredStartEndOutput = 0x146E;
                inline constexpr std::ptrdiff_t m_bGraphControllerEnabled = 0x13E0;
                inline constexpr std::ptrdiff_t m_bUseHitboxesForRenderBox = 0x13E1;
                inline constexpr std::ptrdiff_t m_pOutputAnimLoopCycleOver = 0x1418;
                inline constexpr std::ptrdiff_t m_bCreateMovableSurfaceGraph = 0x1470;
            }
            namespace C_EntityFlame {
                inline constexpr std::ptrdiff_t m_bCheapEffect = 0x62C;
                inline constexpr std::ptrdiff_t m_hEntAttached = 0x600;
                inline constexpr std::ptrdiff_t m_hOldAttached = 0x628;
            }
            namespace C_FuncMonitor {
                inline constexpr std::ptrdiff_t m_bEnabled = 0x10B4;
                inline constexpr std::ptrdiff_t m_targetCamera = 0x1098;
                inline constexpr std::ptrdiff_t m_bDraw3DSkybox = 0x10B5;
                inline constexpr std::ptrdiff_t m_hTargetCamera = 0x10B0;
                inline constexpr std::ptrdiff_t m_bRenderShadows = 0x10A4;
                inline constexpr std::ptrdiff_t m_brushModelName = 0x10A8;
                inline constexpr std::ptrdiff_t m_nResolutionEnum = 0x10A0;
                inline constexpr std::ptrdiff_t m_bUseUniqueColorTarget = 0x10A5;
            }
            namespace C_GlobalLight {
                inline constexpr std::ptrdiff_t m_WindClothForceHandle = 0xAC0;
            }
            namespace C_GradientFog {
                inline constexpr std::ptrdiff_t m_flFarZ = 0x61C;
                inline constexpr std::ptrdiff_t m_fogColor = 0x62C;
                inline constexpr std::ptrdiff_t m_bIsEnabled = 0x639;
                inline constexpr std::ptrdiff_t m_flFadeTime = 0x634;
                inline constexpr std::ptrdiff_t m_flFogStrength = 0x630;
                inline constexpr std::ptrdiff_t m_bStartDisabled = 0x638;
                inline constexpr std::ptrdiff_t m_flFogEndHeight = 0x618;
                inline constexpr std::ptrdiff_t m_flFogMaxOpacity = 0x620;
                inline constexpr std::ptrdiff_t m_flFogEndDistance = 0x60C;
                inline constexpr std::ptrdiff_t m_flFogStartHeight = 0x614;
                inline constexpr std::ptrdiff_t m_bHeightFogEnabled = 0x610;
                inline constexpr std::ptrdiff_t m_flFogStartDistance = 0x608;
                inline constexpr std::ptrdiff_t m_hGradientFogTexture = 0x600;
                inline constexpr std::ptrdiff_t m_flFogFalloffExponent = 0x624;
                inline constexpr std::ptrdiff_t m_flFogVerticalExponent = 0x628;
                inline constexpr std::ptrdiff_t m_bGradientFogNeedsTextures = 0x63A;
            }
            namespace C_ItemDogtags {
                inline constexpr std::ptrdiff_t m_OwningPlayer = 0x1A18;
                inline constexpr std::ptrdiff_t m_KillingPlayer = 0x1A1C;
            }
            namespace C_LightEntity {
                inline constexpr std::ptrdiff_t m_CLightComponent = 0x1098;
            }
            namespace C_PhysicsProp {
                inline constexpr std::ptrdiff_t m_bAwake = 0x13E0;
            }
            namespace C_PointCamera {
                inline constexpr std::ptrdiff_t m_FOV = 0x600;
                inline constexpr std::ptrdiff_t m_bIsOn = 0x654;
                inline constexpr std::ptrdiff_t m_pNext = 0x658;
                inline constexpr std::ptrdiff_t m_bNoSky = 0x624;
                inline constexpr std::ptrdiff_t m_flZFar = 0x62C;
                inline constexpr std::ptrdiff_t m_bActive = 0x61C;
                inline constexpr std::ptrdiff_t m_flZNear = 0x630;
                inline constexpr std::ptrdiff_t m_FogColor = 0x60C;
                inline constexpr std::ptrdiff_t m_flFogEnd = 0x614;
                inline constexpr std::ptrdiff_t m_TargetFOV = 0x64C;
                inline constexpr std::ptrdiff_t m_Resolution = 0x604;
                inline constexpr std::ptrdiff_t m_bFogEnable = 0x608;
                inline constexpr std::ptrdiff_t m_flFogStart = 0x610;
                inline constexpr std::ptrdiff_t m_bCanHLTVUse = 0x634;
                inline constexpr std::ptrdiff_t m_bDofEnabled = 0x636;
                inline constexpr std::ptrdiff_t m_fBrightness = 0x628;
                inline constexpr std::ptrdiff_t m_flAspectRatio = 0x620;
                inline constexpr std::ptrdiff_t m_flDofFarCrisp = 0x640;
                inline constexpr std::ptrdiff_t m_flDofFarBlurry = 0x644;
                inline constexpr std::ptrdiff_t m_flDofNearCrisp = 0x63C;
                inline constexpr std::ptrdiff_t m_flDofNearBlurry = 0x638;
                inline constexpr std::ptrdiff_t m_flFogMaxDensity = 0x618;
                inline constexpr std::ptrdiff_t m_DegreesPerSecond = 0x650;
                inline constexpr std::ptrdiff_t m_bAlignWithParent = 0x635;
                inline constexpr std::ptrdiff_t m_flDofTiltToGround = 0x648;
                inline constexpr std::ptrdiff_t m_bUseScreenAspectRatio = 0x61D;
            }
            namespace C_PointEntity {

            }
            namespace C_RagdollProp {
                inline constexpr std::ptrdiff_t m_ragPos = 0x1280;
                inline constexpr std::ptrdiff_t m_ragAngles = 0x1298;
                inline constexpr std::ptrdiff_t m_ragEnabled = 0x1268;
                inline constexpr std::ptrdiff_t m_flBlendWeight = 0x12B0;
                inline constexpr std::ptrdiff_t m_hRagdollSource = 0x12B4;
                inline constexpr std::ptrdiff_t m_iEyeAttachment = 0x12B8;
                inline constexpr std::ptrdiff_t m_flBlendWeightCurrent = 0x12BC;
                inline constexpr std::ptrdiff_t m_parentPhysicsBoneIndices = 0x12C0;
                inline constexpr std::ptrdiff_t m_worldSpaceBoneComputationOrder = 0x12D8;
            }
            namespace C_SceneEntity {
                inline constexpr std::ptrdiff_t m_hOwner = 0x618;
                inline constexpr std::ptrdiff_t m_bPaused = 0x609;
                inline constexpr std::ptrdiff_t m_hActorList = 0x620;
                inline constexpr std::ptrdiff_t m_bClientOnly = 0x616;
                inline constexpr std::ptrdiff_t m_bWasPlaying = 0x638;
                inline constexpr std::ptrdiff_t m_QueuedEvents = 0x648;
                inline constexpr std::ptrdiff_t m_bMultiplayer = 0x60A;
                inline constexpr std::ptrdiff_t m_flCurrentTime = 0x660;
                inline constexpr std::ptrdiff_t m_bAutogenerated = 0x60B;
                inline constexpr std::ptrdiff_t m_bIsPlayingBack = 0x608;
                inline constexpr std::ptrdiff_t m_flForceClientTime = 0x610;
                inline constexpr std::ptrdiff_t m_nSceneStringIndex = 0x614;
                inline constexpr std::ptrdiff_t m_bAllRequirementsComplete = 0x60C;
            }
            namespace C_WaterBullet {

            }
            namespace C_WeaponBizon {

            }
            namespace C_WeaponCZ75a {
                inline constexpr std::ptrdiff_t m_bMagazineRemoved = 0x1F50;
            }
            namespace C_WeaponElite {

            }
            namespace C_WeaponFamas {

            }
            namespace C_WeaponG3SG1 {

            }
            namespace C_WeaponGlock {

            }
            namespace C_WeaponMAC10 {

            }
            namespace C_WeaponMP5SD {

            }
            namespace C_WeaponNegev {

            }
            namespace C_WeaponSG556 {

            }
            namespace C_WeaponSSG08 {

            }
            namespace C_WeaponTaser {
                inline constexpr std::ptrdiff_t m_fFireTime = 0x1F50;
                inline constexpr std::ptrdiff_t m_nLastAttackTick = 0x1F54;
            }
            namespace C_WeaponUMP45 {

            }
            namespace IntervalTimer {
                inline constexpr std::ptrdiff_t m_timestamp = 0x8;
                inline constexpr std::ptrdiff_t m_nWorldGroupId = 0xC;
            }
            namespace audioparams_t {
                inline constexpr std::ptrdiff_t localBits = 0x6C;
                inline constexpr std::ptrdiff_t localSound = 0x8;
                inline constexpr std::ptrdiff_t soundEventHash = 0x74;
                inline constexpr std::ptrdiff_t soundscapeIndex = 0x68;
                inline constexpr std::ptrdiff_t soundscapeEntityListIndex = 0x70;
            }
            namespace screenshake_t {
                inline constexpr std::ptrdiff_t angle = 0x20;
                inline constexpr std::ptrdiff_t offset = 0x14;
                inline constexpr std::ptrdiff_t endtime = 0x0;
                inline constexpr std::ptrdiff_t duration = 0x4;
                inline constexpr std::ptrdiff_t amplitude = 0x8;
                inline constexpr std::ptrdiff_t direction = 0x28;
                inline constexpr std::ptrdiff_t frequency = 0xC;
                inline constexpr std::ptrdiff_t nextShake = 0x10;
                inline constexpr std::ptrdiff_t nShakeType = 0x34;
            }
            namespace sky3dparams_t {
                inline constexpr std::ptrdiff_t fog = 0x20;
                inline constexpr std::ptrdiff_t scale = 0x8;
                inline constexpr std::ptrdiff_t origin = 0xC;
                inline constexpr std::ptrdiff_t m_nWorldGroupID = 0x88;
                inline constexpr std::ptrdiff_t bClip3DSkyBoxNearToWorldFar = 0x18;
                inline constexpr std::ptrdiff_t flClip3DSkyBoxNearToWorldFarOffset = 0x1C;
            }
            namespace CAttributeList {
                inline constexpr std::ptrdiff_t m_pManager = 0x70;
                inline constexpr std::ptrdiff_t m_Attributes = 0x8;
            }
            namespace CBaseAnimGraph {
                inline constexpr std::ptrdiff_t m_vecForce = 0x1184;
                inline constexpr std::ptrdiff_t m_nForceBone = 0x1190;
                inline constexpr std::ptrdiff_t m_RagdollPose = 0x11B8;
                inline constexpr std::ptrdiff_t m_bBuiltRagdoll = 0x11A0;
                inline constexpr std::ptrdiff_t m_bRagdollEnabled = 0x1200;
                inline constexpr std::ptrdiff_t m_pRagdollControl = 0x11B0;
                inline constexpr std::ptrdiff_t m_bRagdollClientSide = 0x1201;
                inline constexpr std::ptrdiff_t m_pClientsideRagdoll = 0x1198;
                inline constexpr std::ptrdiff_t m_OnLayerCycleUpdated = 0x1140;
                inline constexpr std::ptrdiff_t m_pMainGraphController = 0x1130;
                inline constexpr std::ptrdiff_t m_graphControllerManager = 0x1098;
                inline constexpr std::ptrdiff_t m_bAnimGraphUpdateEnabled = 0x1180;
                inline constexpr std::ptrdiff_t m_bSuppressAnimEventSounds = 0x113A;
                inline constexpr std::ptrdiff_t m_bAnimationUpdateScheduled = 0x1181;
                inline constexpr std::ptrdiff_t m_OnExternalChoreoGraphChanged = 0x1160;
                inline constexpr std::ptrdiff_t m_bShouldUpdateTransformations = 0x1202;
                inline constexpr std::ptrdiff_t m_bHasAnimatedMaterialAttributes = 0x1210;
                inline constexpr std::ptrdiff_t m_bInitiallyPopulateInterpHistory = 0x1138;
            }
            namespace CBodyComponent {
                inline constexpr std::ptrdiff_t m_pSceneNode = 0x8;
                inline constexpr std::ptrdiff_t __m_pChainEntity = 0x48;
            }
            namespace CEnvSoundscape {
                inline constexpr std::ptrdiff_t m_OnPlay = 0x600;
                inline constexpr std::ptrdiff_t m_flRadius = 0x618;
                inline constexpr std::ptrdiff_t m_bDisabled = 0x67C;
                inline constexpr std::ptrdiff_t m_positionNames = 0x638;
                inline constexpr std::ptrdiff_t m_soundEventHash = 0x688;
                inline constexpr std::ptrdiff_t m_soundEventName = 0x620;
                inline constexpr std::ptrdiff_t m_soundscapeName = 0x680;
                inline constexpr std::ptrdiff_t m_soundscapeIndex = 0x62C;
                inline constexpr std::ptrdiff_t m_hProxySoundscape = 0x678;
                inline constexpr std::ptrdiff_t m_bOverrideWithEvent = 0x628;
                inline constexpr std::ptrdiff_t m_soundscapeEntityListId = 0x630;
            }
            namespace CGameSceneNode {
                inline constexpr std::ptrdiff_t m_name = 0x10C;
                inline constexpr std::ptrdiff_t m_pChild = 0x40;
                inline constexpr std::ptrdiff_t m_pOwner = 0x30;
                inline constexpr std::ptrdiff_t m_flScale = 0xC4;
                inline constexpr std::ptrdiff_t m_hParent = 0x70;
                inline constexpr std::ptrdiff_t m_pParent = 0x38;
                inline constexpr std::ptrdiff_t m_bDormant = 0x103;
                inline constexpr std::ptrdiff_t m_vecOrigin = 0x80;
                inline constexpr std::ptrdiff_t m_flAbsScale = 0xE0;
                inline constexpr std::ptrdiff_t m_angRotation = 0xB8;
                inline constexpr std::ptrdiff_t m_nodeToWorld = 0x10;
                inline constexpr std::ptrdiff_t m_pNextSibling = 0x48;
                inline constexpr std::ptrdiff_t m_vecAbsOrigin = 0xC8;
                inline constexpr std::ptrdiff_t m_angAbsRotation = 0xD4;
                inline constexpr std::ptrdiff_t m_bBoneMergeFlex = 0x0;
                inline constexpr std::ptrdiff_t m_flWrappedScale = 0xFC;
                inline constexpr std::ptrdiff_t m_nHierarchyType = 0x108;
                inline constexpr std::ptrdiff_t m_bDirtyHierarchy = 0x0;
                inline constexpr std::ptrdiff_t m_nLatchAbsOrigin = 0x0;
                inline constexpr std::ptrdiff_t m_flClientLocalScale = 0x124;
                inline constexpr std::ptrdiff_t m_nHierarchicalDepth = 0x107;
                inline constexpr std::ptrdiff_t m_bDirtyBoneMergeInfo = 0x0;
                inline constexpr std::ptrdiff_t m_hierarchyAttachName = 0x120;
                inline constexpr std::ptrdiff_t m_vecWrappedLocalOrigin = 0xE4;
                inline constexpr std::ptrdiff_t m_bDebugAbsOriginChanges = 0x102;
                inline constexpr std::ptrdiff_t m_bNetworkedScaleChanged = 0x0;
                inline constexpr std::ptrdiff_t m_angWrappedLocalRotation = 0xF0;
                inline constexpr std::ptrdiff_t m_bNetworkedAnglesChanged = 0x0;
                inline constexpr std::ptrdiff_t m_nParentAttachmentOrBone = 0x100;
                inline constexpr std::ptrdiff_t m_bDirtyBoneMergeBoneToRoot = 0x0;
                inline constexpr std::ptrdiff_t m_bForceParentToBeNetworked = 0x104;
                inline constexpr std::ptrdiff_t m_bNetworkedPositionChanged = 0x0;
                inline constexpr std::ptrdiff_t m_bWillBeCallingPostDataUpdate = 0x0;
                inline constexpr std::ptrdiff_t m_nDoNotSetAnimTimeInInvalidatePhysicsCount = 0x109;
            }
            namespace CGrenadeTracer {
                inline constexpr std::ptrdiff_t m_nType = 0x10B4;
                inline constexpr std::ptrdiff_t m_flTracerDuration = 0x10B0;
            }
            namespace CLogicalEntity {

            }
            namespace CPointTemplate {
                inline constexpr std::ptrdiff_t m_iszWorldName = 0x600;
                inline constexpr std::ptrdiff_t m_OnEntitySpawned = 0x668;
                inline constexpr std::ptrdiff_t m_flTimeoutInterval = 0x618;
                inline constexpr std::ptrdiff_t m_ScriptCallbackScope = 0x660;
                inline constexpr std::ptrdiff_t m_ScriptSpawnCallback = 0x658;
                inline constexpr std::ptrdiff_t m_iszEntityFilterName = 0x610;
                inline constexpr std::ptrdiff_t m_ownerSpawnGroupType = 0x624;
                inline constexpr std::ptrdiff_t m_SpawnedEntityHandles = 0x640;
                inline constexpr std::ptrdiff_t m_clientOnlyEntityBehavior = 0x620;
                inline constexpr std::ptrdiff_t m_createdSpawnGroupHandles = 0x628;
                inline constexpr std::ptrdiff_t m_iszSource2EntityLumpName = 0x608;
                inline constexpr std::ptrdiff_t m_bAsynchronouslySpawnEntities = 0x61C;
            }
            namespace CPulseGraphDef {
                inline constexpr std::ptrdiff_t m_Vars = 0x80;
                inline constexpr std::ptrdiff_t m_Cells = 0x68;
                inline constexpr std::ptrdiff_t m_Chunks = 0x50;
                inline constexpr std::ptrdiff_t m_CallInfos = 0xE0;
                inline constexpr std::ptrdiff_t m_Constants = 0xF8;
                inline constexpr std::ptrdiff_t m_DomainValues = 0x110;
                inline constexpr std::ptrdiff_t m_TempVarBanks = 0x98;
                inline constexpr std::ptrdiff_t m_DomainSubType = 0x18;
                inline constexpr std::ptrdiff_t m_ParentMapName = 0x30;
                inline constexpr std::ptrdiff_t m_ParentXmlName = 0x40;
                inline constexpr std::ptrdiff_t m_PublicOutputs = 0xB0;
                inline constexpr std::ptrdiff_t m_InvokeBindings = 0xC8;
                inline constexpr std::ptrdiff_t m_DomainIdentifier = 0x8;
                inline constexpr std::ptrdiff_t m_OutputConnections = 0x140;
                inline constexpr std::ptrdiff_t m_BlackboardReferences = 0x128;
            }
            namespace CSMatchStats_t {
                inline constexpr std::ptrdiff_t m_iEnemy3Ks = 0x70;
                inline constexpr std::ptrdiff_t m_iEnemy4Ks = 0x6C;
                inline constexpr std::ptrdiff_t m_iEnemy5Ks = 0x68;
                inline constexpr std::ptrdiff_t m_iEnemyKnifeKills = 0x74;
                inline constexpr std::ptrdiff_t m_iEnemyTaserKills = 0x78;
            }
            namespace CWaterSplasher {

            }
            namespace C_BasePropDoor {
                inline constexpr std::ptrdiff_t m_bLocked = 0x14C5;
                inline constexpr std::ptrdiff_t m_bNoNPCs = 0x14C6;
                inline constexpr std::ptrdiff_t m_hMaster = 0x14E0;
                inline constexpr std::ptrdiff_t m_eDoorState = 0x14C0;
                inline constexpr std::ptrdiff_t m_closedAngles = 0x14D4;
                inline constexpr std::ptrdiff_t m_modelChanged = 0x14C4;
                inline constexpr std::ptrdiff_t m_closedPosition = 0x14C8;
                inline constexpr std::ptrdiff_t m_vWhereToSetLightingOrigin = 0x14E4;
            }
            namespace C_CSPlayerPawn {
                inline constexpr std::ptrdiff_t m_bIsScoped = 0x1EA0;
                inline constexpr std::ptrdiff_t m_ArmorValue = 0x1ECC;
                inline constexpr std::ptrdiff_t m_EconGloves = 0x1770;
                inline constexpr std::ptrdiff_t m_bInBuyZone = 0x15E0;
                inline constexpr std::ptrdiff_t m_bInLanding = 0x15E2;
                inline constexpr std::ptrdiff_t m_bIsWalking = 0x1E80;
                inline constexpr std::ptrdiff_t m_bInBombZone = 0x15E9;
                inline constexpr std::ptrdiff_t m_bIsDefusing = 0x1EA2;
                inline constexpr std::ptrdiff_t m_bLeftHanded = 0x1DB8;
                inline constexpr std::ptrdiff_t m_bPrevHelmet = 0x15CF;
                inline constexpr std::ptrdiff_t m_bResumeZoom = 0x1EA1;
                inline constexpr std::ptrdiff_t m_iIDEntIndex = 0x36CC;
                inline constexpr std::ptrdiff_t m_iShotsFired = 0x1EB4;
                inline constexpr std::ptrdiff_t m_angEyeAngles = 0x35F0;
                inline constexpr std::ptrdiff_t m_bOldIsScoped = 0x1EDC;
                inline constexpr std::ptrdiff_t m_bPrevDefuser = 0x15CE;
                inline constexpr std::ptrdiff_t m_lastLandTime = 0x1D84;
                inline constexpr std::ptrdiff_t m_pBuyServices = 0x1580;
                inline constexpr std::ptrdiff_t m_unWeaponHash = 0x15DC;
                inline constexpr std::ptrdiff_t m_bHasDeathInfo = 0x1EDD;
                inline constexpr std::ptrdiff_t m_flFlinchStack = 0x1EB8;
                inline constexpr std::ptrdiff_t m_hHudModelArms = 0x1DA8;
                inline constexpr std::ptrdiff_t m_nPrevArmorVal = 0x15D0;
                inline constexpr std::ptrdiff_t m_pGlowServices = 0x1588;
                inline constexpr std::ptrdiff_t m_bIsBuyMenuOpen = 0x15EA;
                inline constexpr std::ptrdiff_t m_flViewmodelFOV = 0x1DCC;
                inline constexpr std::ptrdiff_t m_iOldIDEntIndex = 0x36EC;
                inline constexpr std::ptrdiff_t m_nWhichBombZone = 0x1EB0;
                inline constexpr std::ptrdiff_t m_arrOldEyeAngles = 0x3690;
                inline constexpr std::ptrdiff_t m_bHasFemaleVoice = 0x15B0;
                inline constexpr std::ptrdiff_t m_bInNoDefuseArea = 0x1EAC;
                inline constexpr std::ptrdiff_t m_flDeathInfoTime = 0x1EE0;
                inline constexpr std::ptrdiff_t m_flEmitSoundTime = 0x1EA8;
                inline constexpr std::ptrdiff_t m_pBulletServices = 0x1570;
                inline constexpr std::ptrdiff_t m_qDeathEyeAngles = 0x1DAC;
                inline constexpr std::ptrdiff_t m_szLastPlaceName = 0x15BC;
                inline constexpr std::ptrdiff_t m_bGunGameImmunity = 0x3508;
                inline constexpr std::ptrdiff_t m_bWaitForNoAttack = 0x1EC0;
                inline constexpr std::ptrdiff_t m_iRetakesOffering = 0x1758;
                inline constexpr std::ptrdiff_t m_nLastKillerIndex = 0x1ED8;
                inline constexpr std::ptrdiff_t m_pHostageServices = 0x1578;
                inline constexpr std::ptrdiff_t m_bKilledByHeadshot = 0x1EC9;
                inline constexpr std::ptrdiff_t m_bOnGroundLastTick = 0x1D88;
                inline constexpr std::ptrdiff_t m_flOldFallVelocity = 0x15B8;
                inline constexpr std::ptrdiff_t m_holdTargetIDTimer = 0x36F0;
                inline constexpr std::ptrdiff_t m_iTargetItemEntIdx = 0x36E8;
                inline constexpr std::ptrdiff_t m_pAimPunchServices = 0x1598;
                inline constexpr std::ptrdiff_t m_bIsGrabbingHostage = 0x1EA3;
                inline constexpr std::ptrdiff_t m_delayTargetIDTimer = 0x36D0;
                inline constexpr std::ptrdiff_t m_entitySpottedState = 0x1E88;
                inline constexpr std::ptrdiff_t m_fMolotovDamageTime = 0x3510;
                inline constexpr std::ptrdiff_t m_flLandingStartTime = 0x15E4;
                inline constexpr std::ptrdiff_t m_flTimeOfLastInjury = 0x15EC;
                inline constexpr std::ptrdiff_t m_flVelocityModifier = 0x1EBC;
                inline constexpr std::ptrdiff_t m_flViewmodelOffsetX = 0x1DC0;
                inline constexpr std::ptrdiff_t m_flViewmodelOffsetY = 0x1DC4;
                inline constexpr std::ptrdiff_t m_flViewmodelOffsetZ = 0x1DC8;
                inline constexpr std::ptrdiff_t m_nEconGlovesChanged = 0x1D20;
                inline constexpr std::ptrdiff_t m_nRagdollDamageBone = 0x1D24;
                inline constexpr std::ptrdiff_t m_vecBulletHitModels = 0x1E68;
                inline constexpr std::ptrdiff_t m_vecDeathInfoOrigin = 0x1EE4;
                inline constexpr std::ptrdiff_t m_vecStashedVelocity = 0x1F4C;
                inline constexpr std::ptrdiff_t m_vRagdollDamageForce = 0x1D28;
                inline constexpr std::ptrdiff_t m_GunGameImmunityColor = 0x1E18;
                inline constexpr std::ptrdiff_t m_angEyeAnglesVelocity = 0x36C0;
                inline constexpr std::ptrdiff_t m_arrOldEyeAnglesTimes = 0x3680;
                inline constexpr std::ptrdiff_t m_bInHostageRescueZone = 0x15E8;
                inline constexpr std::ptrdiff_t m_bNeedToReApplyGloves = 0x176D;
                inline constexpr std::ptrdiff_t m_bPreviouslyInBuyZone = 0x15E1;
                inline constexpr std::ptrdiff_t m_bRetakesHasDefuseKit = 0x1760;
                inline constexpr std::ptrdiff_t m_bRetakesMVPLastRound = 0x1761;
                inline constexpr std::ptrdiff_t m_flLandingTimeSeconds = 0x15B4;
                inline constexpr std::ptrdiff_t m_flNextSprayDecalTime = 0x15F0;
                inline constexpr std::ptrdiff_t m_hActiveMinimapVolume = 0x1DA4;
                inline constexpr std::ptrdiff_t m_iRetakesMVPBoostItem = 0x1764;
                inline constexpr std::ptrdiff_t m_iRetakesOfferingCard = 0x175C;
                inline constexpr std::ptrdiff_t m_ignoreLadderJumpTime = 0x1EC4;
                inline constexpr std::ptrdiff_t m_nPlayerInfernoBodyFx = 0x357C;
                inline constexpr std::ptrdiff_t m_pDamageReactServices = 0x15A0;
                inline constexpr std::ptrdiff_t m_unPreviousWeaponHash = 0x15D8;
                inline constexpr std::ptrdiff_t m_vRagdollServerOrigin = 0x1D78;
                inline constexpr std::ptrdiff_t m_angStashedShootAngles = 0x1F28;
                inline constexpr std::ptrdiff_t m_bMustSyncRagdollState = 0x1D21;
                inline constexpr std::ptrdiff_t m_flLastFiredWeaponTime = 0x15AC;
                inline constexpr std::ptrdiff_t m_nPrevGrenadeAmmoCount = 0x15D4;
                inline constexpr std::ptrdiff_t m_bRagdollDamageHeadshot = 0x1D74;
                inline constexpr std::ptrdiff_t m_bShouldAutobuyDMWeapons = 0x3500;
                inline constexpr std::ptrdiff_t m_fSwitchedHandednessTime = 0x1DBC;
                inline constexpr std::ptrdiff_t m_pActionTrackingServices = 0x1590;
                inline constexpr std::ptrdiff_t m_unCurrentEquipmentValue = 0x1ED0;
                inline constexpr std::ptrdiff_t m_flInterpolatedInaccuracy = 0x1F58;
                inline constexpr std::ptrdiff_t m_bGrenadeParametersStashed = 0x1F24;
                inline constexpr std::ptrdiff_t m_grenadeParameterStashTime = 0x1F20;
                inline constexpr std::ptrdiff_t m_szRagdollDamageWeaponName = 0x1D34;
                inline constexpr std::ptrdiff_t m_vecPlayerPatchEconIndices = 0x1DD0;
                inline constexpr std::ptrdiff_t m_fImmuneToGunGameDamageTime = 0x3504;
                inline constexpr std::ptrdiff_t m_unRoundStartEquipmentValue = 0x1ED2;
                inline constexpr std::ptrdiff_t m_RetakesMVPBoostExtraUtility = 0x1768;
                inline constexpr std::ptrdiff_t m_iBlockingUseActionInProgress = 0x1EA4;
                inline constexpr std::ptrdiff_t m_unFreezetimeEndEquipmentValue = 0x1ED4;
                inline constexpr std::ptrdiff_t m_fImmuneToGunGameDamageTimeLast = 0x350C;
                inline constexpr std::ptrdiff_t m_vecStashedGrenadeThrowPosition = 0x1F34;
                inline constexpr std::ptrdiff_t m_flHealthShotBoostExpirationTime = 0x15A8;
                inline constexpr std::ptrdiff_t m_vecStashedGrenadeThrowPawnCenter = 0x1F40;
            }
            namespace C_CSWeaponBase {
                inline constexpr std::ptrdiff_t m_donated = 0x1B64;
                inline constexpr std::ptrdiff_t m_bInReload = 0x1A3C;
                inline constexpr std::ptrdiff_t m_bStealthy = 0x1A58;
                inline constexpr std::ptrdiff_t m_bUIWeapon = 0x1B22;
                inline constexpr std::ptrdiff_t m_nDropTick = 0x1B3C;
                inline constexpr std::ptrdiff_t m_bBurstMode = 0x1A2C;
                inline constexpr std::ptrdiff_t m_hPrevOwner = 0x1B38;
                inline constexpr std::ptrdiff_t m_weaponMode = 0x1A00;
                inline constexpr std::ptrdiff_t m_bSilencerOn = 0x1A51;
                inline constexpr std::ptrdiff_t m_nDeployTick = 0x1A40;
                inline constexpr std::ptrdiff_t m_bFireOnEmpty = 0x19E4;
                inline constexpr std::ptrdiff_t m_iRecoilIndex = 0x1A24;
                inline constexpr std::ptrdiff_t m_bIsHauledBack = 0x1A50;
                inline constexpr std::ptrdiff_t m_bWasOwnedByCT = 0x1B6C;
                inline constexpr std::ptrdiff_t m_fLastShotTime = 0x1B68;
                inline constexpr std::ptrdiff_t m_flRecoilIndex = 0x1A28;
                inline constexpr std::ptrdiff_t m_OnPlayerPickup = 0x19E8;
                inline constexpr std::ptrdiff_t m_bCanBePickedUp = 0x1B30;
                inline constexpr std::ptrdiff_t m_iIronSightMode = 0x1C80;
                inline constexpr std::ptrdiff_t m_bInspectPending = 0x19B4;
                inline constexpr std::ptrdiff_t m_bVisualsDataSet = 0x1B21;
                inline constexpr std::ptrdiff_t m_flDroppedAtTime = 0x1A48;
                inline constexpr std::ptrdiff_t m_flLastShakeTime = 0x1D6C;
                inline constexpr std::ptrdiff_t m_flWatTickOffset = 0x1D58;
                inline constexpr std::ptrdiff_t m_fAccuracyPenalty = 0x1A18;
                inline constexpr std::ptrdiff_t m_bInspectShouldLoop = 0x19B5;
                inline constexpr std::ptrdiff_t m_IronSightController = 0x1BD0;
                inline constexpr std::ptrdiff_t m_bDroppedNearBuyZone = 0x1A70;
                inline constexpr std::ptrdiff_t m_flTurningInaccuracy = 0x1A14;
                inline constexpr std::ptrdiff_t m_iOriginalTeamNumber = 0x1A68;
                inline constexpr std::ptrdiff_t m_bWasOwnedByTerrorist = 0x1B6D;
                inline constexpr std::ptrdiff_t m_nextPrevOwnerUseTime = 0x1B34;
                inline constexpr std::ptrdiff_t m_bReloadHeldSinceStart = 0x1A60;
                inline constexpr std::ptrdiff_t m_flAttackHoldStartTime = 0x1A44;
                inline constexpr std::ptrdiff_t m_iMostRecentTeamNumber = 0x1A6C;
                inline constexpr std::ptrdiff_t m_nLastEmptySoundCmdNum = 0x19E0;
                inline constexpr std::ptrdiff_t m_bInSilentReloadSection = 0x1A59;
                inline constexpr std::ptrdiff_t m_flStealthHoldStartTime = 0x1A5C;
                inline constexpr std::ptrdiff_t m_flPostponeFireReadyFrac = 0x1A38;
                inline constexpr std::ptrdiff_t m_nPostponeFireReadyTicks = 0x1A34;
                inline constexpr std::ptrdiff_t m_fAccuracySmoothedForZoom = 0x1A20;
                inline constexpr std::ptrdiff_t m_flLastAccuracyUpdateTime = 0x1A1C;
                inline constexpr std::ptrdiff_t m_flTurningInaccuracyDelta = 0x1A04;
                inline constexpr std::ptrdiff_t m_iWeaponGameplayAnimState = 0x19A8;
                inline constexpr std::ptrdiff_t m_nCustomEconReloadEventId = 0x1B24;
                inline constexpr std::ptrdiff_t m_flLastBurstModeChangeTime = 0x1A30;
                inline constexpr std::ptrdiff_t m_flLastLOSTraceFailureTime = 0x1CF8;
                inline constexpr std::ptrdiff_t m_bClearWeaponIdentifyingUGC = 0x1B20;
                inline constexpr std::ptrdiff_t m_flNextClientFireBulletTime = 0x1B70;
                inline constexpr std::ptrdiff_t m_flWeaponActionPlaybackRate = 0x1A64;
                inline constexpr std::ptrdiff_t m_bWasActiveWeaponWhenDropped = 0x1B40;
                inline constexpr std::ptrdiff_t m_flInspectCancelCompleteTime = 0x19B0;
                inline constexpr std::ptrdiff_t m_flNextAttackRenderTimeOffset = 0x1A74;
                inline constexpr std::ptrdiff_t m_flTimeSilencerSwitchComplete = 0x1A54;
                inline constexpr std::ptrdiff_t m_vecTurningInaccuracyEyeDirLast = 0x1A08;
                inline constexpr std::ptrdiff_t m_flWeaponGameplayAnimStateTimestamp = 0x19AC;
                inline constexpr std::ptrdiff_t m_flNextClientFireBulletTime_Repredict = 0x1B74;
            }
            namespace C_DecoyGrenade {

            }
            namespace C_DynamicLight {
                inline constexpr std::ptrdiff_t m_Flags = 0x1098;
                inline constexpr std::ptrdiff_t m_Radius = 0x109C;
                inline constexpr std::ptrdiff_t m_Exponent = 0x10A0;
                inline constexpr std::ptrdiff_t m_InnerAngle = 0x10A4;
                inline constexpr std::ptrdiff_t m_LightStyle = 0x1099;
                inline constexpr std::ptrdiff_t m_OuterAngle = 0x10A8;
                inline constexpr std::ptrdiff_t m_SpotRadius = 0x10AC;
            }
            namespace C_EconItemView {
                inline constexpr std::ptrdiff_t m_iItemID = 0x1C8;
                inline constexpr std::ptrdiff_t m_iAccountID = 0x1D8;
                inline constexpr std::ptrdiff_t m_iItemIDLow = 0x1D4;
                inline constexpr std::ptrdiff_t m_iItemIDHigh = 0x1D0;
                inline constexpr std::ptrdiff_t m_bDisallowSOC = 0x1E9;
                inline constexpr std::ptrdiff_t m_bInitialized = 0x1E8;
                inline constexpr std::ptrdiff_t m_bIsStoreItem = 0x1EA;
                inline constexpr std::ptrdiff_t m_bIsTradeItem = 0x1EB;
                inline constexpr std::ptrdiff_t m_iEntityLevel = 0x1C0;
                inline constexpr std::ptrdiff_t m_szCustomName = 0x2F8;
                inline constexpr std::ptrdiff_t m_AttributeList = 0x208;
                inline constexpr std::ptrdiff_t m_unClientFlags = 0x1FD;
                inline constexpr std::ptrdiff_t m_iEntityQuality = 0x1BC;
                inline constexpr std::ptrdiff_t m_iEntityQuantity = 0x1EC;
                inline constexpr std::ptrdiff_t m_iOriginOverride = 0x1F8;
                inline constexpr std::ptrdiff_t m_iRarityOverride = 0x1F0;
                inline constexpr std::ptrdiff_t m_ubStyleOverride = 0x1FC;
                inline constexpr std::ptrdiff_t m_bInitializedTags = 0x5A8;
                inline constexpr std::ptrdiff_t m_iQualityOverride = 0x1F4;
                inline constexpr std::ptrdiff_t m_iInventoryPosition = 0x1DC;
                inline constexpr std::ptrdiff_t m_iItemDefinitionIndex = 0x1BA;
                inline constexpr std::ptrdiff_t m_szCustomNameOverride = 0x399;
                inline constexpr std::ptrdiff_t m_szCustomNameOverride2 = 0x43A;
                inline constexpr std::ptrdiff_t m_szCustomNameOverride3 = 0x4DB;
                inline constexpr std::ptrdiff_t m_nInventoryImageRgbaWidth = 0x80;
                inline constexpr std::ptrdiff_t m_bInventoryImageTriedCache = 0x61;
                inline constexpr std::ptrdiff_t m_nInventoryImageRgbaHeight = 0x84;
                inline constexpr std::ptrdiff_t m_NetworkedDynamicAttributes = 0x280;
                inline constexpr std::ptrdiff_t m_szCurrentLoadCachedFileName = 0x88;
                inline constexpr std::ptrdiff_t m_bInventoryImageRgbaRequested = 0x60;
                inline constexpr std::ptrdiff_t m_bRestoreCustomMaterialAfterPrecache = 0x1B8;
            }
            namespace C_EconWearable {
                inline constexpr std::ptrdiff_t m_nForceSkin = 0x1918;
                inline constexpr std::ptrdiff_t m_bAlwaysAllow = 0x191C;
            }
            namespace C_FuncConveyor {
                inline constexpr std::ptrdiff_t m_flTargetSpeed = 0x10AC;
                inline constexpr std::ptrdiff_t m_flFrictionScale = 0x10BC;
                inline constexpr std::ptrdiff_t m_hConveyorModels = 0x10C0;
                inline constexpr std::ptrdiff_t m_nTransitionStartTick = 0x10B0;
                inline constexpr std::ptrdiff_t m_vecMoveDirEntitySpace = 0x10A0;
                inline constexpr std::ptrdiff_t m_flCurrentConveyorSpeed = 0x10DC;
                inline constexpr std::ptrdiff_t m_flTransitionStartSpeed = 0x10B8;
                inline constexpr std::ptrdiff_t m_flCurrentConveyorOffset = 0x10D8;
                inline constexpr std::ptrdiff_t m_nTransitionDurationTicks = 0x10B4;
            }
            namespace C_FuncRotating {

            }
            namespace C_RopeKeyframe {
                inline constexpr std::ptrdiff_t m_Slack = 0x136A;
                inline constexpr std::ptrdiff_t m_Width = 0x1374;
                inline constexpr std::ptrdiff_t m_Subdiv = 0x1366;
                inline constexpr std::ptrdiff_t m_vWindDir = 0x13B8;
                inline constexpr std::ptrdiff_t m_RopeFlags = 0x10D8;
                inline constexpr std::ptrdiff_t m_hEndPoint = 0x1360;
                inline constexpr std::ptrdiff_t m_hMaterial = 0x1388;
                inline constexpr std::ptrdiff_t m_nSegments = 0x1358;
                inline constexpr std::ptrdiff_t m_vColorMod = 0x13C4;
                inline constexpr std::ptrdiff_t m_RopeLength = 0x1368;
                inline constexpr std::ptrdiff_t m_bApplyWind = 0x10A8;
                inline constexpr std::ptrdiff_t m_vecImpulse = 0x1394;
                inline constexpr std::ptrdiff_t m_flCurScroll = 0x10D0;
                inline constexpr std::ptrdiff_t m_hStartPoint = 0x135C;
                inline constexpr std::ptrdiff_t m_TextureScale = 0x136C;
                inline constexpr std::ptrdiff_t m_nChangeCount = 0x1371;
                inline constexpr std::ptrdiff_t m_TextureHeight = 0x1390;
                inline constexpr std::ptrdiff_t m_fLockedPoints = 0x1370;
                inline constexpr std::ptrdiff_t m_flScrollSpeed = 0x10D4;
                inline constexpr std::ptrdiff_t m_iEndAttachment = 0x1365;
                inline constexpr std::ptrdiff_t m_PhysicsDelegate = 0x1378;
                inline constexpr std::ptrdiff_t m_bPhysicsInitted = 0x0;
                inline constexpr std::ptrdiff_t m_bPrevEndPointPos = 0x10B4;
                inline constexpr std::ptrdiff_t m_flTimeToNextGust = 0x13B4;
                inline constexpr std::ptrdiff_t m_iStartAttachment = 0x1364;
                inline constexpr std::ptrdiff_t m_vPrevEndPointPos = 0x10B8;
                inline constexpr std::ptrdiff_t m_bNewDataThisFrame = 0x0;
                inline constexpr std::ptrdiff_t m_fPrevLockedPoints = 0x10AC;
                inline constexpr std::ptrdiff_t m_flCurrentGustTimer = 0x13AC;
                inline constexpr std::ptrdiff_t m_vecPreviousImpulse = 0x13A0;
                inline constexpr std::ptrdiff_t m_flCurrentGustLifetime = 0x13B0;
                inline constexpr std::ptrdiff_t m_LinksTouchingSomething = 0x10A0;
                inline constexpr std::ptrdiff_t m_iForcePointMoveCounter = 0x10B0;
                inline constexpr std::ptrdiff_t m_iRopeMaterialModelIndex = 0x10E0;
                inline constexpr std::ptrdiff_t m_nLinksTouchingSomething = 0x10A4;
                inline constexpr std::ptrdiff_t m_bConstrainBetweenEndpoints = 0x1400;
                inline constexpr std::ptrdiff_t m_vCachedEndPointAttachmentPos = 0x13D0;
                inline constexpr std::ptrdiff_t m_bEndPointAttachmentAnglesDirty = 0x0;
                inline constexpr std::ptrdiff_t m_vCachedEndPointAttachmentAngle = 0x13E8;
                inline constexpr std::ptrdiff_t m_bEndPointAttachmentPositionsDirty = 0x0;
            }
            namespace C_SmokeGrenade {

            }
            namespace C_SpotlightEnd {
                inline constexpr std::ptrdiff_t m_Radius = 0x109C;
                inline constexpr std::ptrdiff_t m_flLightScale = 0x1098;
            }
            namespace C_WeaponSCAR20 {

            }
            namespace C_WeaponXM1014 {

            }
            namespace CountdownTimer {
                inline constexpr std::ptrdiff_t m_duration = 0x8;
                inline constexpr std::ptrdiff_t m_timescale = 0x10;
                inline constexpr std::ptrdiff_t m_timestamp = 0xC;
                inline constexpr std::ptrdiff_t m_nWorldGroupId = 0x14;
            }
            namespace CBuoyancyHelper {
                inline constexpr std::ptrdiff_t m_nFluidType = 0x18;
                inline constexpr std::ptrdiff_t m_pController = 0x8;
                inline constexpr std::ptrdiff_t m_vecWheelDrag = 0x78;
                inline constexpr std::ptrdiff_t m_flFluidDensity = 0x1C;
                inline constexpr std::ptrdiff_t m_bNeutrallyBuoyant = 0x2C;
                inline constexpr std::ptrdiff_t m_vecWheelFrictionScales = 0x48;
                inline constexpr std::ptrdiff_t m_flNeutrallyBuoyantGravity = 0x20;
                inline constexpr std::ptrdiff_t m_flNeutrallyBuoyantLinearDamping = 0x24;
                inline constexpr std::ptrdiff_t m_flNeutrallyBuoyantAngularDamping = 0x28;
                inline constexpr std::ptrdiff_t m_vecFractionOfWheelSubmergedForWheelDrag = 0x60;
                inline constexpr std::ptrdiff_t m_vecFractionOfWheelSubmergedForWheelFriction = 0x30;
            }
            namespace CCSRadarElement {
                inline constexpr std::ptrdiff_t m_nTeamFilter = 0x620;
                inline constexpr std::ptrdiff_t m_nElementType = 0x618;
                inline constexpr std::ptrdiff_t m_nElementColor = 0x61C;
            }
            namespace CEntityIdentity {
                inline constexpr std::ptrdiff_t m_name = 0x18;
                inline constexpr std::ptrdiff_t m_flags = 0x30;
                inline constexpr std::ptrdiff_t m_pNext = 0x58;
                inline constexpr std::ptrdiff_t m_pPrev = 0x50;
                inline constexpr std::ptrdiff_t m_PathIndex = 0x40;
                inline constexpr std::ptrdiff_t m_pAttributes = 0x48;
                inline constexpr std::ptrdiff_t m_designerName = 0x20;
                inline constexpr std::ptrdiff_t m_pNextByClass = 0x68;
                inline constexpr std::ptrdiff_t m_pPrevByClass = 0x60;
                inline constexpr std::ptrdiff_t m_worldGroupId = 0x38;
                inline constexpr std::ptrdiff_t m_fDataObjectTypes = 0x3C;
                inline constexpr std::ptrdiff_t m_nameStringTableIndex = 0x14;
            }
            namespace CEntityInstance {
                inline constexpr std::ptrdiff_t m_pEntity = 0x10;
                inline constexpr std::ptrdiff_t m_CScriptComponent = 0x28;
                inline constexpr std::ptrdiff_t m_iszPrivateVScripts = 0x8;
            }
            namespace CFilterMultiple {
                inline constexpr std::ptrdiff_t m_hFilter = 0x690;
                inline constexpr std::ptrdiff_t m_iFilterName = 0x640;
                inline constexpr std::ptrdiff_t m_nFilterType = 0x638;
            }
            namespace CInfoWorldLayer {
                inline constexpr std::ptrdiff_t m_layerName = 0x620;
                inline constexpr std::ptrdiff_t m_worldName = 0x618;
                inline constexpr std::ptrdiff_t m_bEntitiesSpawned = 0x629;
                inline constexpr std::ptrdiff_t m_hLayerSpawnGroup = 0x62C;
                inline constexpr std::ptrdiff_t m_bWorldLayerVisible = 0x628;
                inline constexpr std::ptrdiff_t m_bCreateAsChildSpawnGroup = 0x62A;
                inline constexpr std::ptrdiff_t m_pOutputOnEntitiesSpawned = 0x600;
                inline constexpr std::ptrdiff_t m_bWorldLayerActuallyVisible = 0x630;
            }
            namespace CLightComponent {
                inline constexpr std::ptrdiff_t m_Color = 0x78;
                inline constexpr std::ptrdiff_t m_flPhi = 0xA4;
                inline constexpr std::ptrdiff_t m_nStyle = 0xD4;
                inline constexpr std::ptrdiff_t m_Pattern = 0xD8;
                inline constexpr std::ptrdiff_t m_flRange = 0x8C;
                inline constexpr std::ptrdiff_t m_flTheta = 0xA0;
                inline constexpr std::ptrdiff_t m_SkyColor = 0x190;
                inline constexpr std::ptrdiff_t m_bEnabled = 0x140;
                inline constexpr std::ptrdiff_t m_bFlicker = 0x141;
                inline constexpr std::ptrdiff_t m_flFalloff = 0x90;
                inline constexpr std::ptrdiff_t m_nCascades = 0xB0;
                inline constexpr std::ptrdiff_t m_flBrightness = 0x80;
                inline constexpr std::ptrdiff_t m_hLightCookie = 0xA8;
                inline constexpr std::ptrdiff_t m_nBounceLight = 0x128;
                inline constexpr std::ptrdiff_t m_nCastShadows = 0xB4;
                inline constexpr std::ptrdiff_t m_nDirectLight = 0x124;
                inline constexpr std::ptrdiff_t m_nShadowWidth = 0xB8;
                inline constexpr std::ptrdiff_t m_bMixedShadows = 0x19D;
                inline constexpr std::ptrdiff_t m_flBounceScale = 0x12C;
                inline constexpr std::ptrdiff_t m_flFadeMaxDist = 0x134;
                inline constexpr std::ptrdiff_t m_flFadeMinDist = 0x130;
                inline constexpr std::ptrdiff_t m_nShadowHeight = 0xBC;
                inline constexpr std::ptrdiff_t __m_pChainEntity = 0x38;
                inline constexpr std::ptrdiff_t m_SecondaryColor = 0x7C;
                inline constexpr std::ptrdiff_t m_bRenderDiffuse = 0xC0;
                inline constexpr std::ptrdiff_t m_flAttenuation0 = 0x94;
                inline constexpr std::ptrdiff_t m_flAttenuation1 = 0x98;
                inline constexpr std::ptrdiff_t m_flAttenuation2 = 0x9C;
                inline constexpr std::ptrdiff_t m_flMinRoughness = 0x1A8;
                inline constexpr std::ptrdiff_t m_flSkyIntensity = 0x194;
                inline constexpr std::ptrdiff_t m_flCapsuleLength = 0x1A4;
                inline constexpr std::ptrdiff_t m_flNearClipPlane = 0x18C;
                inline constexpr std::ptrdiff_t m_nRenderSpecular = 0xC4;
                inline constexpr std::ptrdiff_t m_nShadowPriority = 0x110;
                inline constexpr std::ptrdiff_t m_SkyAmbientBounce = 0x198;
                inline constexpr std::ptrdiff_t m_flBrightnessMult = 0x88;
                inline constexpr std::ptrdiff_t m_nFogLightingMode = 0x184;
                inline constexpr std::ptrdiff_t m_bRenderToCubemaps = 0x120;
                inline constexpr std::ptrdiff_t m_flBrightnessScale = 0x84;
                inline constexpr std::ptrdiff_t m_flOrthoLightWidth = 0xCC;
                inline constexpr std::ptrdiff_t m_nBakedShadowIndex = 0x114;
                inline constexpr std::ptrdiff_t m_nLightMapUniqueId = 0x11C;
                inline constexpr std::ptrdiff_t m_bUseSecondaryColor = 0x19C;
                inline constexpr std::ptrdiff_t m_flOrthoLightHeight = 0xD0;
                inline constexpr std::ptrdiff_t m_nLightPathUniqueId = 0x118;
                inline constexpr std::ptrdiff_t m_bAllowSSTGeneration = 0x121;
                inline constexpr std::ptrdiff_t m_bRenderTransmissive = 0xC8;
                inline constexpr std::ptrdiff_t m_bUsesBakedShadowing = 0x10C;
                inline constexpr std::ptrdiff_t m_flShadowFadeMaxDist = 0x13C;
                inline constexpr std::ptrdiff_t m_flShadowFadeMinDist = 0x138;
                inline constexpr std::ptrdiff_t m_flLightStyleStartTime = 0x1A0;
                inline constexpr std::ptrdiff_t m_flPrecomputedMaxRange = 0x180;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBAngles = 0x168;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBExtent = 0x174;
                inline constexpr std::ptrdiff_t m_vPrecomputedOBBOrigin = 0x15C;
                inline constexpr std::ptrdiff_t m_vPrecomputedBoundsMaxs = 0x150;
                inline constexpr std::ptrdiff_t m_vPrecomputedBoundsMins = 0x144;
                inline constexpr std::ptrdiff_t m_bPrecomputedFieldsValid = 0x142;
                inline constexpr std::ptrdiff_t m_flFogContributionStength = 0x188;
                inline constexpr std::ptrdiff_t m_flShadowCascadeCrossFade = 0xE4;
                inline constexpr std::ptrdiff_t m_flShadowCascadeDistance0 = 0xEC;
                inline constexpr std::ptrdiff_t m_flShadowCascadeDistance1 = 0xF0;
                inline constexpr std::ptrdiff_t m_flShadowCascadeDistance2 = 0xF4;
                inline constexpr std::ptrdiff_t m_flShadowCascadeDistance3 = 0xF8;
                inline constexpr std::ptrdiff_t m_nShadowCascadeResolution0 = 0xFC;
                inline constexpr std::ptrdiff_t m_nShadowCascadeResolution1 = 0x100;
                inline constexpr std::ptrdiff_t m_nShadowCascadeResolution2 = 0x104;
                inline constexpr std::ptrdiff_t m_nShadowCascadeResolution3 = 0x108;
                inline constexpr std::ptrdiff_t m_flShadowCascadeDistanceFade = 0xE8;
                inline constexpr std::ptrdiff_t m_nCascadeRenderStaticObjects = 0xE0;
                inline constexpr std::ptrdiff_t m_bAmbientOcclusionProxyOverride = 0x1AC;
                inline constexpr std::ptrdiff_t m_hAmbientOcclusionProxyPosition0 = 0x1B0;
                inline constexpr std::ptrdiff_t m_hAmbientOcclusionProxyPosition1 = 0x1B4;
                inline constexpr std::ptrdiff_t m_hAmbientOcclusionProxyPosition2 = 0x1B8;
                inline constexpr std::ptrdiff_t m_hAmbientOcclusionProxyPosition3 = 0x1BC;
                inline constexpr std::ptrdiff_t m_flAmbientOcclusionProxyStrength0 = 0x1C0;
                inline constexpr std::ptrdiff_t m_flAmbientOcclusionProxyStrength1 = 0x1C4;
                inline constexpr std::ptrdiff_t m_flAmbientOcclusionProxyStrength2 = 0x1C8;
                inline constexpr std::ptrdiff_t m_flAmbientOcclusionProxyStrength3 = 0x1CC;
                inline constexpr std::ptrdiff_t m_flAmbientOcclusionProxyConeAngle0 = 0x1D4;
                inline constexpr std::ptrdiff_t m_flAmbientOcclusionProxyConeAngle1 = 0x1D8;
                inline constexpr std::ptrdiff_t m_flAmbientOcclusionProxyConeAngle2 = 0x1DC;
                inline constexpr std::ptrdiff_t m_flAmbientOcclusionProxyConeAngle3 = 0x1E0;
                inline constexpr std::ptrdiff_t m_flAmbientOcclusionProxyAmbientStrength = 0x1D0;
            }
            namespace CPulseCell_Base {
                inline constexpr std::ptrdiff_t m_nEditorNodeID = 0x8;
            }
            namespace CPulse_CallInfo {
                inline constexpr std::ptrdiff_t m_PortName = 0x0;
                inline constexpr std::ptrdiff_t m_nSrcChunk = 0x4C;
                inline constexpr std::ptrdiff_t m_RegisterMap = 0x18;
                inline constexpr std::ptrdiff_t m_CallMethodID = 0x48;
                inline constexpr std::ptrdiff_t m_nEditorNodeID = 0x10;
                inline constexpr std::ptrdiff_t m_nBreakDestChunk = 0x54;
                inline constexpr std::ptrdiff_t m_nSrcInstruction = 0x50;
                inline constexpr std::ptrdiff_t m_nBreakDestInstruction = 0x58;
            }
            namespace CRagdollManager {
                inline constexpr std::ptrdiff_t m_iCurrentMaxRagdollCount = 0x600;
            }
            namespace CSpriteOriented {

            }
            namespace C_BaseCSGrenade {
                inline constexpr std::ptrdiff_t m_bRedraw = 0x1F21;
                inline constexpr std::ptrdiff_t m_fDropTime = 0x1FA8;
                inline constexpr std::ptrdiff_t m_bJumpThrow = 0x1F24;
                inline constexpr std::ptrdiff_t m_bPinPulled = 0x1F23;
                inline constexpr std::ptrdiff_t m_fThrowTime = 0x1F28;
                inline constexpr std::ptrdiff_t m_fPinPullTime = 0x1FAC;
                inline constexpr std::ptrdiff_t m_nNextHoldTick = 0x1FB4;
                inline constexpr std::ptrdiff_t m_bJustPulledPin = 0x1FB0;
                inline constexpr std::ptrdiff_t m_flNextHoldFrac = 0x1FB8;
                inline constexpr std::ptrdiff_t m_bIsHeldByPlayer = 0x1F22;
                inline constexpr std::ptrdiff_t m_bThrowAnimating = 0x1F25;
                inline constexpr std::ptrdiff_t m_flThrowStrength = 0x1F30;
                inline constexpr std::ptrdiff_t m_bClientPredictDelete = 0x1F20;
                inline constexpr std::ptrdiff_t m_hSwitchToWeaponAfterThrow = 0x1FBC;
            }
            namespace C_BreakableProp {
                inline constexpr std::ptrdiff_t m_OnBreak = 0x12F8;
                inline constexpr std::ptrdiff_t m_hBreaker = 0x1364;
                inline constexpr std::ptrdiff_t m_OnStartDeath = 0x12E0;
                inline constexpr std::ptrdiff_t m_OnTakeDamage = 0x1330;
                inline constexpr std::ptrdiff_t m_explodeDamage = 0x138C;
                inline constexpr std::ptrdiff_t m_explodeRadius = 0x1390;
                inline constexpr std::ptrdiff_t m_hLastAttacker = 0x13D4;
                inline constexpr std::ptrdiff_t m_iMinHealthDmg = 0x134C;
                inline constexpr std::ptrdiff_t m_explosionDelay = 0x13A0;
                inline constexpr std::ptrdiff_t m_sExplosionType = 0x1398;
                inline constexpr std::ptrdiff_t m_OnHealthChanged = 0x1310;
                inline constexpr std::ptrdiff_t m_PerformanceMode = 0x1368;
                inline constexpr std::ptrdiff_t m_flDefBurstScale = 0x1354;
                inline constexpr std::ptrdiff_t m_flPressureDelay = 0x1350;
                inline constexpr std::ptrdiff_t m_vDefBurstOffset = 0x1358;
                inline constexpr std::ptrdiff_t m_hPhysicsAttacker = 0x13C8;
                inline constexpr std::ptrdiff_t m_explosionModifier = 0x13C0;
                inline constexpr std::ptrdiff_t m_impactEnergyScale = 0x1348;
                inline constexpr std::ptrdiff_t m_CPropDataComponent = 0x12A0;
                inline constexpr std::ptrdiff_t m_flDefaultFadeScale = 0x13D0;
                inline constexpr std::ptrdiff_t m_explosionCustomSound = 0x13B8;
                inline constexpr std::ptrdiff_t m_BreakableContentsType = 0x1370;
                inline constexpr std::ptrdiff_t m_explosionBuildupSound = 0x13A8;
                inline constexpr std::ptrdiff_t m_explosionCustomEffect = 0x13B0;
                inline constexpr std::ptrdiff_t m_bHasBreakPiecesOrCommands = 0x1388;
                inline constexpr std::ptrdiff_t m_flPreventDamageBeforeTime = 0x136C;
                inline constexpr std::ptrdiff_t m_flLastPhysicsInfluenceTime = 0x13CC;
                inline constexpr std::ptrdiff_t m_strBreakableContentsParticleOverride = 0x1380;
                inline constexpr std::ptrdiff_t m_strBreakableContentsPropGroupOverride = 0x1378;
            }
            namespace C_ClientRagdoll {
                inline constexpr std::ptrdiff_t m_bFadeOut = 0x1268;
                inline constexpr std::ptrdiff_t m_bFadingOut = 0x1286;
                inline constexpr std::ptrdiff_t m_bImportant = 0x1269;
                inline constexpr std::ptrdiff_t m_flScaleEnd = 0x1288;
                inline constexpr std::ptrdiff_t m_flEffectTime = 0x126C;
                inline constexpr std::ptrdiff_t m_iMaxFriction = 0x127C;
                inline constexpr std::ptrdiff_t m_iMinFriction = 0x1278;
                inline constexpr std::ptrdiff_t m_flScaleTimeEnd = 0x12D8;
                inline constexpr std::ptrdiff_t m_gibDespawnTime = 0x1270;
                inline constexpr std::ptrdiff_t m_iEyeAttachment = 0x1285;
                inline constexpr std::ptrdiff_t m_bReleaseRagdoll = 0x1284;
                inline constexpr std::ptrdiff_t m_flScaleTimeStart = 0x12B0;
                inline constexpr std::ptrdiff_t m_iCurrentFriction = 0x1274;
                inline constexpr std::ptrdiff_t m_iFrictionAnimState = 0x1280;
            }
            namespace C_EnvCubemapBox {

            }
            namespace C_EnvCubemapFog {
                inline constexpr std::ptrdiff_t m_bActive = 0x624;
                inline constexpr std::ptrdiff_t m_flLODBias = 0x620;
                inline constexpr std::ptrdiff_t m_bFirstTime = 0x6F9;
                inline constexpr std::ptrdiff_t m_hSkyMaterial = 0x630;
                inline constexpr std::ptrdiff_t m_iszSkyEntity = 0x638;
                inline constexpr std::ptrdiff_t m_flEndDistance = 0x600;
                inline constexpr std::ptrdiff_t m_bStartDisabled = 0x625;
                inline constexpr std::ptrdiff_t m_flFogHeightEnd = 0x614;
                inline constexpr std::ptrdiff_t m_nHeightFogType = 0x640;
                inline constexpr std::ptrdiff_t m_flFogMaxOpacity = 0x628;
                inline constexpr std::ptrdiff_t m_flStartDistance = 0x604;
                inline constexpr std::ptrdiff_t m_bHasHeightFogEnd = 0x6F8;
                inline constexpr std::ptrdiff_t m_flFogHeightStart = 0x618;
                inline constexpr std::ptrdiff_t m_flFogHeightWidth = 0x610;
                inline constexpr std::ptrdiff_t m_nDistanceFogType = 0x64C;
                inline constexpr std::ptrdiff_t m_bHeightFogEnabled = 0x60C;
                inline constexpr std::ptrdiff_t m_hFogCubemapTexture = 0x6F0;
                inline constexpr std::ptrdiff_t m_nCubemapSourceType = 0x62C;
                inline constexpr std::ptrdiff_t m_flFogHeightExponent = 0x61C;
                inline constexpr std::ptrdiff_t m_nFogHeightBlendMode = 0x644;
                inline constexpr std::ptrdiff_t m_HeightFogCurveString = 0x658;
                inline constexpr std::ptrdiff_t m_flFogFalloffExponent = 0x608;
                inline constexpr std::ptrdiff_t m_DistanceFogCurveString = 0x650;
                inline constexpr std::ptrdiff_t m_nFogHeightCoordinateSpace = 0x648;
            }
            namespace C_EnvWindShared {
                inline constexpr std::ptrdiff_t m_iMaxGust = 0x1A;
                inline constexpr std::ptrdiff_t m_iMaxWind = 0x12;
                inline constexpr std::ptrdiff_t m_iMinGust = 0x18;
                inline constexpr std::ptrdiff_t m_iMinWind = 0x10;
                inline constexpr std::ptrdiff_t m_location = 0x30;
                inline constexpr std::ptrdiff_t m_hEntOwner = 0x3C;
                inline constexpr std::ptrdiff_t m_iWindSeed = 0xC;
                inline constexpr std::ptrdiff_t m_windRadius = 0x14;
                inline constexpr std::ptrdiff_t m_flStartTime = 0x8;
                inline constexpr std::ptrdiff_t m_flGustDuration = 0x24;
                inline constexpr std::ptrdiff_t m_flMaxGustDelay = 0x20;
                inline constexpr std::ptrdiff_t m_flMinGustDelay = 0x1C;
                inline constexpr std::ptrdiff_t m_iGustDirChange = 0x28;
                inline constexpr std::ptrdiff_t m_iInitialWindDir = 0x2A;
                inline constexpr std::ptrdiff_t m_flInitialWindSpeed = 0x2C;
            }
            namespace C_FogController {
                inline constexpr std::ptrdiff_t m_fog = 0x600;
                inline constexpr std::ptrdiff_t m_bUseAngles = 0x668;
                inline constexpr std::ptrdiff_t m_iChangedVariables = 0x66C;
            }
            namespace C_NametagModule {
                inline constexpr std::ptrdiff_t m_strNametagString = 0x1270;
            }
            namespace C_Precipitation {
                inline constexpr std::ptrdiff_t m_flDensity = 0x1180;
                inline constexpr std::ptrdiff_t m_pParticleDef = 0x1198;
                inline constexpr std::ptrdiff_t m_flParticleInnerDist = 0x1190;
                inline constexpr std::ptrdiff_t m_tParticlePrecipTraceTimer = 0x11AC;
                inline constexpr std::ptrdiff_t m_bParticlePrecipInitialized = 0x11B5;
                inline constexpr std::ptrdiff_t m_bActiveParticlePrecipEmitter = 0x11B4;
                inline constexpr std::ptrdiff_t m_nAvailableSheetSequencesMaxIndex = 0x11B8;
                inline constexpr std::ptrdiff_t m_bHasSimulatedSinceLastSceneObjectUpdate = 0x11B6;
            }
            namespace C_TeamplayRules {

            }
            namespace C_TriggerVolume {

            }
            namespace C_WeaponGalilAR {

            }
            namespace C_WeaponHKP2000 {

            }
            namespace inv_image_map_t {
                inline constexpr std::ptrdiff_t map_name = 0x0;
                inline constexpr std::ptrdiff_t map_rotation = 0x8;
            }
            namespace CBasePlayerVData {
                inline constexpr std::ptrdiff_t m_flUseRange = 0x24C;
                inline constexpr std::ptrdiff_t m_sModelName = 0x28;
                inline constexpr std::ptrdiff_t m_nWaterSpeed = 0x248;
                inline constexpr std::ptrdiff_t m_flCrouchTime = 0x254;
                inline constexpr std::ptrdiff_t m_flHoldBreathTime = 0x238;
                inline constexpr std::ptrdiff_t m_nDrowningDamageMax = 0x244;
                inline constexpr std::ptrdiff_t m_flUseAngleTolerance = 0x250;
                inline constexpr std::ptrdiff_t m_flArmDamageMultiplier = 0x218;
                inline constexpr std::ptrdiff_t m_flLegDamageMultiplier = 0x228;
                inline constexpr std::ptrdiff_t m_sModelNameAg2Override = 0x108;
                inline constexpr std::ptrdiff_t m_flHeadDamageMultiplier = 0x1E8;
                inline constexpr std::ptrdiff_t m_nDrowningDamageInitial = 0x240;
                inline constexpr std::ptrdiff_t m_flChestDamageMultiplier = 0x1F8;
                inline constexpr std::ptrdiff_t m_flDrowningDamageInterval = 0x23C;
                inline constexpr std::ptrdiff_t m_flStomachDamageMultiplier = 0x208;
            }
            namespace CBrokenGlassTrap {

            }
            namespace CCSGameModeRules {
                inline constexpr std::ptrdiff_t __m_pChainEntity = 0x8;
            }
            namespace CCSMinimapVolume {
                inline constexpr std::ptrdiff_t m_strMinimapName = 0x1180;
            }
            namespace CChoreoComponent {
                inline constexpr std::ptrdiff_t m_hOwner = 0x30;
                inline constexpr std::ptrdiff_t __m_pChainEntity = 0x8;
                inline constexpr std::ptrdiff_t m_nNextSceneEventId = 0x70;
                inline constexpr std::ptrdiff_t m_flAllowResponsesEndTime = 0x74;
                inline constexpr std::ptrdiff_t m_nExernalChoreoGraphCount = 0x34;
                inline constexpr std::ptrdiff_t m_sActiveExternalChoreoGraphSlotID = 0x38;
            }
            namespace CEntityComponent {

            }
            namespace CFilterProximity {
                inline constexpr std::ptrdiff_t m_flRadius = 0x638;
            }
            namespace CGlobalLightBase {
                inline constexpr std::ptrdiff_t m_flFOV = 0x80;
                inline constexpr std::ptrdiff_t m_flFarZ = 0x88;
                inline constexpr std::ptrdiff_t m_flNearZ = 0x84;
                inline constexpr std::ptrdiff_t m_hEnvSky = 0x4BC;
                inline constexpr std::ptrdiff_t m_bEnabled = 0x69;
                inline constexpr std::ptrdiff_t m_hEnvWind = 0x4B8;
                inline constexpr std::ptrdiff_t m_flViewFoV = 0xEC;
                inline constexpr std::ptrdiff_t m_vFowColor = 0xC8;
                inline constexpr std::ptrdiff_t m_LightColor = 0x6C;
                inline constexpr std::ptrdiff_t m_ViewAngles = 0xE0;
                inline constexpr std::ptrdiff_t m_ViewOrigin = 0xD4;
                inline constexpr std::ptrdiff_t m_bSpotLight = 0x10;
                inline constexpr std::ptrdiff_t m_WorldPoints = 0xF0;
                inline constexpr std::ptrdiff_t m_flCloudScale = 0x90;
                inline constexpr std::ptrdiff_t m_flLightScale = 0xBC;
                inline constexpr std::ptrdiff_t m_AmbientColor1 = 0x70;
                inline constexpr std::ptrdiff_t m_AmbientColor2 = 0x74;
                inline constexpr std::ptrdiff_t m_AmbientColor3 = 0x78;
                inline constexpr std::ptrdiff_t m_SpecularColor = 0x64;
                inline constexpr std::ptrdiff_t m_flCloud1Speed = 0x94;
                inline constexpr std::ptrdiff_t m_flCloud2Speed = 0x9C;
                inline constexpr std::ptrdiff_t m_flFoWDarkness = 0xC0;
                inline constexpr std::ptrdiff_t m_flGroundScale = 0xB8;
                inline constexpr std::ptrdiff_t m_flSunDistance = 0x7C;
                inline constexpr std::ptrdiff_t m_bEnableShadows = 0x8C;
                inline constexpr std::ptrdiff_t m_bStartDisabled = 0x68;
                inline constexpr std::ptrdiff_t m_ShadowDirection = 0x2C;
                inline constexpr std::ptrdiff_t m_SpotLightAngles = 0x20;
                inline constexpr std::ptrdiff_t m_SpotLightOrigin = 0x14;
                inline constexpr std::ptrdiff_t m_flAmbientScale1 = 0xB0;
                inline constexpr std::ptrdiff_t m_flAmbientScale2 = 0xB4;
                inline constexpr std::ptrdiff_t m_flSpecularPower = 0x5C;
                inline constexpr std::ptrdiff_t m_AmbientDirection = 0x38;
                inline constexpr std::ptrdiff_t m_vFogOffsetLayer0 = 0x4A8;
                inline constexpr std::ptrdiff_t m_vFogOffsetLayer1 = 0x4B0;
                inline constexpr std::ptrdiff_t m_SpecularDirection = 0x44;
                inline constexpr std::ptrdiff_t m_bOldEnableShadows = 0x8D;
                inline constexpr std::ptrdiff_t m_flCloud1Direction = 0x98;
                inline constexpr std::ptrdiff_t m_flCloud2Direction = 0xA0;
                inline constexpr std::ptrdiff_t m_flSpecularIndependence = 0x60;
                inline constexpr std::ptrdiff_t m_bEnableSeparateSkyboxFog = 0xC4;
                inline constexpr std::ptrdiff_t m_InspectorSpecularDirection = 0x50;
                inline constexpr std::ptrdiff_t m_bBackgroundClearNotRequired = 0x8E;
            }
            namespace CHitboxComponent {
                inline constexpr std::ptrdiff_t m_flBoundsExpandRadius = 0x14;
            }
            namespace CNoiseStreamData {
                inline constexpr std::ptrdiff_t m_Stream = 0x0;
            }
            namespace CPulseExecCursor {

            }
            namespace CRenderComponent {
                inline constexpr std::ptrdiff_t __m_pChainEntity = 0x10;
                inline constexpr std::ptrdiff_t m_bEnableRendering = 0x58;
                inline constexpr std::ptrdiff_t m_nSplitscreenFlags = 0x54;
                inline constexpr std::ptrdiff_t m_bInterpolationReadyToDraw = 0xA8;
                inline constexpr std::ptrdiff_t m_bIsRenderingWithViewModels = 0x50;
            }
            namespace CScriptComponent {
                inline constexpr std::ptrdiff_t m_scriptClassName = 0x30;
            }
            namespace CSkyboxReference {
                inline constexpr std::ptrdiff_t m_hSkyCamera = 0x604;
                inline constexpr std::ptrdiff_t m_worldGroupId = 0x600;
            }
            namespace C_BasePlayerPawn {
                inline constexpr std::ptrdiff_t v_angle = 0x13A8;
                inline constexpr std::ptrdiff_t m_iHideHUD = 0x13C0;
                inline constexpr std::ptrdiff_t m_skybox3d = 0x13C8;
                inline constexpr std::ptrdiff_t m_vOldOrigin = 0x14A4;
                inline constexpr std::ptrdiff_t m_flDeathTime = 0x1458;
                inline constexpr std::ptrdiff_t m_hController = 0x14BC;
                inline constexpr std::ptrdiff_t m_pUseServices = 0x1318;
                inline constexpr std::ptrdiff_t m_pItemServices = 0x12F8;
                inline constexpr std::ptrdiff_t v_anglePrevious = 0x13B4;
                inline constexpr std::ptrdiff_t m_pWaterServices = 0x1310;
                inline constexpr std::ptrdiff_t m_pCameraServices = 0x1328;
                inline constexpr std::ptrdiff_t m_pWeaponServices = 0x12F0;
                inline constexpr std::ptrdiff_t m_pAutoaimServices = 0x1300;
                inline constexpr std::ptrdiff_t m_pMovementServices = 0x1330;
                inline constexpr std::ptrdiff_t m_pObserverServices = 0x1308;
                inline constexpr std::ptrdiff_t m_flMouseSensitivity = 0x14A0;
                inline constexpr std::ptrdiff_t m_hDefaultController = 0x14C0;
                inline constexpr std::ptrdiff_t m_vecPredictionError = 0x1460;
                inline constexpr std::ptrdiff_t m_flOldSimulationTime = 0x14B0;
                inline constexpr std::ptrdiff_t m_pFlashlightServices = 0x1320;
                inline constexpr std::ptrdiff_t m_flLastCameraSetupTime = 0x1498;
                inline constexpr std::ptrdiff_t m_flPredictionErrorTime = 0x146C;
                inline constexpr std::ptrdiff_t m_ServerViewAngleChanges = 0x1340;
                inline constexpr std::ptrdiff_t m_flFOVSensitivityAdjust = 0x149C;
                inline constexpr std::ptrdiff_t m_nLastExecutedCommandTick = 0x14B8;
                inline constexpr std::ptrdiff_t m_nLastExecutedCommandNumber = 0x14B4;
                inline constexpr std::ptrdiff_t m_vecLastCameraSetupLocalOrigin = 0x148C;
                inline constexpr std::ptrdiff_t m_bIsSwappingToPredictableController = 0x14C4;
            }
            namespace C_BulletHitModel {
                inline constexpr std::ptrdiff_t m_bIsHit = 0x12A0;
                inline constexpr std::ptrdiff_t m_matLocal = 0x1268;
                inline constexpr std::ptrdiff_t m_iBoneIndex = 0x1298;
                inline constexpr std::ptrdiff_t m_vecStartPos = 0x12A8;
                inline constexpr std::ptrdiff_t m_flTimeCreated = 0x12A4;
                inline constexpr std::ptrdiff_t m_hPlayerParent = 0x129C;
            }
            namespace C_CSObserverPawn {
                inline constexpr std::ptrdiff_t m_hDetectParentChange = 0x1568;
            }
            namespace C_CSPetPlacement {

            }
            namespace C_CommandContext {
                inline constexpr std::ptrdiff_t command_number = 0xA0;
                inline constexpr std::ptrdiff_t needsprocessing = 0x0;
            }
            namespace C_CsmFovOverride {
                inline constexpr std::ptrdiff_t m_cameraName = 0x600;
                inline constexpr std::ptrdiff_t m_flCsmFovOverrideValue = 0x608;
            }
            namespace C_EntityDissolve {
                inline constexpr std::ptrdiff_t m_nMagnitude = 0x10C0;
                inline constexpr std::ptrdiff_t m_flStartTime = 0x10A0;
                inline constexpr std::ptrdiff_t m_bCoreExplode = 0x10D4;
                inline constexpr std::ptrdiff_t m_flFadeInStart = 0x10A4;
                inline constexpr std::ptrdiff_t m_nDissolveType = 0x10BC;
                inline constexpr std::ptrdiff_t m_flFadeInLength = 0x10A8;
                inline constexpr std::ptrdiff_t m_flFadeOutStart = 0x10B4;
                inline constexpr std::ptrdiff_t m_flFadeOutLength = 0x10B8;
                inline constexpr std::ptrdiff_t m_flNextSparkTime = 0x10D0;
                inline constexpr std::ptrdiff_t m_vDissolverOrigin = 0x10C4;
                inline constexpr std::ptrdiff_t m_bLinkedToServerEnt = 0x10D5;
                inline constexpr std::ptrdiff_t m_flFadeOutModelStart = 0x10AC;
                inline constexpr std::ptrdiff_t m_flFadeOutModelLength = 0x10B0;
            }
            namespace C_EnvShakeVolume {
                inline constexpr std::ptrdiff_t m_vBoxMaxs = 0x624;
                inline constexpr std::ptrdiff_t m_vBoxMins = 0x618;
                inline constexpr std::ptrdiff_t m_flAmplitude = 0x630;
                inline constexpr std::ptrdiff_t m_flFrequency = 0x634;
                inline constexpr std::ptrdiff_t m_flRollScale = 0x63C;
                inline constexpr std::ptrdiff_t m_flFalloffDistance = 0x638;
            }
            namespace C_FuncMoveLinear {

            }
            namespace C_FuncTrackTrain {
                inline constexpr std::ptrdiff_t m_flRadius = 0x109C;
                inline constexpr std::ptrdiff_t m_nLongAxis = 0x1098;
                inline constexpr std::ptrdiff_t m_flLineLength = 0x10A0;
            }
            namespace C_GameRulesProxy {

            }
            namespace C_KeychainModule {
                inline constexpr std::ptrdiff_t m_nKeychainSeed = 0x1274;
                inline constexpr std::ptrdiff_t m_nKeychainDefID = 0x1270;
            }
            namespace C_MolotovGrenade {

            }
            namespace C_MultiplayRules {

            }
            namespace C_ParticleSystem {
                inline constexpr std::ptrdiff_t m_bActive = 0x1298;
                inline constexpr std::ptrdiff_t m_bFrozen = 0x1299;
                inline constexpr std::ptrdiff_t m_bNoRamp = 0x13FA;
                inline constexpr std::ptrdiff_t m_bNoSave = 0x13F8;
                inline constexpr std::ptrdiff_t m_clrTint = 0x161C;
                inline constexpr std::ptrdiff_t m_nDataCP = 0x1608;
                inline constexpr std::ptrdiff_t m_nTintCP = 0x1618;
                inline constexpr std::ptrdiff_t m_bNoFreeze = 0x13F9;
                inline constexpr std::ptrdiff_t m_nStopType = 0x12A0;
                inline constexpr std::ptrdiff_t m_bOldActive = 0x1640;
                inline constexpr std::ptrdiff_t m_bOldFrozen = 0x1641;
                inline constexpr std::ptrdiff_t m_flStartTime = 0x12B0;
                inline constexpr std::ptrdiff_t m_bStartActive = 0x13FB;
                inline constexpr std::ptrdiff_t m_flPreSimTime = 0x12B4;
                inline constexpr std::ptrdiff_t m_iEffectIndex = 0x12A8;
                inline constexpr std::ptrdiff_t m_iszEffectName = 0x1400;
                inline constexpr std::ptrdiff_t m_strDataString = 0x13F0;
                inline constexpr std::ptrdiff_t m_vecDataCPValue = 0x160C;
                inline constexpr std::ptrdiff_t m_hControlPointEnts = 0x12EC;
                inline constexpr std::ptrdiff_t m_szSnapshotFileName = 0x1098;
                inline constexpr std::ptrdiff_t m_bDataStringLocalized = 0x13EC;
                inline constexpr std::ptrdiff_t m_iszControlPointNames = 0x1408;
                inline constexpr std::ptrdiff_t m_vServerControlPoints = 0x12B8;
                inline constexpr std::ptrdiff_t m_flFreezeTransitionDuration = 0x129C;
                inline constexpr std::ptrdiff_t m_bAnimateDuringGameplayPause = 0x12A4;
                inline constexpr std::ptrdiff_t m_iServerControlPointAssignments = 0x12E8;
            }
            namespace C_PointWorldText {
                inline constexpr std::ptrdiff_t m_Color = 0x1360;
                inline constexpr std::ptrdiff_t m_FontName = 0x12C0;
                inline constexpr std::ptrdiff_t m_bEnabled = 0x1340;
                inline constexpr std::ptrdiff_t m_flFontSize = 0x1348;
                inline constexpr std::ptrdiff_t m_bFullbright = 0x1341;
                inline constexpr std::ptrdiff_t m_messageText = 0x10C0;
                inline constexpr std::ptrdiff_t m_nTextWidthPx = 0x10B8;
                inline constexpr std::ptrdiff_t m_flDepthOffset = 0x134C;
                inline constexpr std::ptrdiff_t m_nReorientMode = 0x136C;
                inline constexpr std::ptrdiff_t m_nTextHeightPx = 0x10BC;
                inline constexpr std::ptrdiff_t m_bDrawBackground = 0x1350;
                inline constexpr std::ptrdiff_t m_nJustifyVertical = 0x1368;
                inline constexpr std::ptrdiff_t m_flWorldUnitsPerPx = 0x1344;
                inline constexpr std::ptrdiff_t m_nJustifyHorizontal = 0x1364;
                inline constexpr std::ptrdiff_t m_flBackgroundWorldToUV = 0x135C;
                inline constexpr std::ptrdiff_t m_BackgroundMaterialName = 0x1300;
                inline constexpr std::ptrdiff_t m_flBackgroundBorderWidth = 0x1354;
                inline constexpr std::ptrdiff_t m_bForceRecreateNextUpdate = 0x10A0;
                inline constexpr std::ptrdiff_t m_flBackgroundBorderHeight = 0x1358;
            }
            namespace C_StattrakModule {
                inline constexpr std::ptrdiff_t m_bKnife = 0x1270;
            }
            namespace C_TintController {

            }
            namespace C_TriggerPhysics {
                inline constexpr std::ptrdiff_t m_flFrequency = 0x1198;
                inline constexpr std::ptrdiff_t m_linearForce = 0x1194;
                inline constexpr std::ptrdiff_t m_linearLimit = 0x1184;
                inline constexpr std::ptrdiff_t m_angularLimit = 0x118C;
                inline constexpr std::ptrdiff_t m_gravityScale = 0x1180;
                inline constexpr std::ptrdiff_t m_linearDamping = 0x1188;
                inline constexpr std::ptrdiff_t m_angularDamping = 0x1190;
                inline constexpr std::ptrdiff_t m_flDampingRatio = 0x119C;
                inline constexpr std::ptrdiff_t m_bCollapseToForcePoint = 0x11AC;
                inline constexpr std::ptrdiff_t m_vecLinearForcePointAt = 0x11A0;
                inline constexpr std::ptrdiff_t m_vecLinearForceDirection = 0x11BC;
                inline constexpr std::ptrdiff_t m_vecLinearForcePointAtWorld = 0x11B0;
                inline constexpr std::ptrdiff_t m_bConvertToDebrisWhenPossible = 0x11C9;
                inline constexpr std::ptrdiff_t m_bForceDirectionIsInLocalSpace = 0x11C8;
            }
            namespace C_VoteController {
                inline constexpr std::ptrdiff_t m_bTypeDirty = 0x631;
                inline constexpr std::ptrdiff_t m_bVotesDirty = 0x630;
                inline constexpr std::ptrdiff_t m_bIsYesNoVote = 0x632;
                inline constexpr std::ptrdiff_t m_iOnlyTeamToVote = 0x614;
                inline constexpr std::ptrdiff_t m_nPotentialVotes = 0x62C;
                inline constexpr std::ptrdiff_t m_nVoteOptionCount = 0x618;
                inline constexpr std::ptrdiff_t m_iActiveIssueIndex = 0x610;
            }
            namespace C_WeaponBaseItem {
                inline constexpr std::ptrdiff_t m_bRedraw = 0x1F21;
                inline constexpr std::ptrdiff_t m_bSequenceInProgress = 0x1F20;
            }
            namespace C_WeaponRevolver {

            }
            namespace C_WeaponSawedoff {

            }
            namespace FilterDamageType {
                inline constexpr std::ptrdiff_t m_iDamageType = 0x638;
            }
            namespace inv_image_data_t {
                inline constexpr std::ptrdiff_t map = 0x0;
                inline constexpr std::ptrdiff_t item = 0x10;
                inline constexpr std::ptrdiff_t camera = 0x30;
                inline constexpr std::ptrdiff_t light0 = 0xA0;
                inline constexpr std::ptrdiff_t light1 = 0xC0;
                inline constexpr std::ptrdiff_t lightsun = 0x68;
                inline constexpr std::ptrdiff_t lightfill = 0x84;
                inline constexpr std::ptrdiff_t clearcolor = 0xE0;
            }
            namespace inv_image_item_t {
                inline constexpr std::ptrdiff_t angle = 0xC;
                inline constexpr std::ptrdiff_t position = 0x0;
                inline constexpr std::ptrdiff_t pose_sequence = 0x18;
            }
            namespace CAttributeManager {
                inline constexpr std::ptrdiff_t m_hOuter = 0x24;
                inline constexpr std::ptrdiff_t m_Providers = 0x8;
                inline constexpr std::ptrdiff_t m_ProviderType = 0x2C;
                inline constexpr std::ptrdiff_t m_CachedResults = 0x30;
                inline constexpr std::ptrdiff_t m_bPreventLoopback = 0x28;
                inline constexpr std::ptrdiff_t m_iReapplyProvisionParity = 0x20;
            }
            namespace CChoreoInfoTarget {

            }
            namespace CFlashlightEffect {
                inline constexpr std::ptrdiff_t m_bIsOn = 0x10;
                inline constexpr std::ptrdiff_t m_flFov = 0x4C;
                inline constexpr std::ptrdiff_t m_flFarZ = 0x50;
                inline constexpr std::ptrdiff_t m_textureName = 0x70;
                inline constexpr std::ptrdiff_t m_bCastsShadows = 0x58;
                inline constexpr std::ptrdiff_t m_flLinearAtten = 0x54;
                inline constexpr std::ptrdiff_t m_FlashlightTexture = 0x60;
                inline constexpr std::ptrdiff_t m_MuzzleFlashTexture = 0x68;
                inline constexpr std::ptrdiff_t m_bMuzzleFlashEnabled = 0x20;
                inline constexpr std::ptrdiff_t m_vecMuzzleFlashOrigin = 0x40;
                inline constexpr std::ptrdiff_t m_flCurrentPullBackDist = 0x5C;
                inline constexpr std::ptrdiff_t m_flMuzzleFlashBrightness = 0x24;
                inline constexpr std::ptrdiff_t m_quatMuzzleFlashOrientation = 0x30;
            }
            namespace CSPerRoundStats_t {
                inline constexpr std::ptrdiff_t m_iKills = 0x30;
                inline constexpr std::ptrdiff_t m_iDamage = 0x3C;
                inline constexpr std::ptrdiff_t m_iDeaths = 0x34;
                inline constexpr std::ptrdiff_t m_iAssists = 0x38;
                inline constexpr std::ptrdiff_t m_iLiveTime = 0x4C;
                inline constexpr std::ptrdiff_t m_iObjective = 0x54;
                inline constexpr std::ptrdiff_t m_iCashEarned = 0x58;
                inline constexpr std::ptrdiff_t m_iKillReward = 0x48;
                inline constexpr std::ptrdiff_t m_iMoneySaved = 0x44;
                inline constexpr std::ptrdiff_t m_iHeadShotKills = 0x50;
                inline constexpr std::ptrdiff_t m_iUtilityDamage = 0x5C;
                inline constexpr std::ptrdiff_t m_iEnemiesFlashed = 0x60;
                inline constexpr std::ptrdiff_t m_iEquipmentValue = 0x40;
            }
            namespace CSkeletonInstance {
                inline constexpr std::ptrdiff_t m_modelState = 0x140;
                inline constexpr std::ptrdiff_t m_nHitboxSet = 0x3FC;
                inline constexpr std::ptrdiff_t m_materialGroup = 0x3F8;
                inline constexpr std::ptrdiff_t m_bDirtyMotionType = 0x3F2;
                inline constexpr std::ptrdiff_t m_bUseParentRenderBounds = 0x3F0;
                inline constexpr std::ptrdiff_t m_bDisableSolidCollisionsForHierarchy = 0x3F1;
                inline constexpr std::ptrdiff_t m_bIsGeneratingLatchedParentSpaceState = 0x3F3;
            }
            namespace C_BaseModelEntity {
                inline constexpr std::ptrdiff_t m_Glow = 0xDE8;
                inline constexpr std::ptrdiff_t m_Collision = 0xD30;
                inline constexpr std::ptrdiff_t m_clrRender = 0xCA0;
                inline constexpr std::ptrdiff_t m_nRenderFX = 0xC81;
                inline constexpr std::ptrdiff_t m_iOldHealth = 0xC7C;
                inline constexpr std::ptrdiff_t m_fadeMaxDist = 0xE48;
                inline constexpr std::ptrdiff_t m_fadeMinDist = 0xE44;
                inline constexpr std::ptrdiff_t m_flFadeScale = 0xE4C;
                inline constexpr std::ptrdiff_t m_nRenderMode = 0xC80;
                inline constexpr std::ptrdiff_t m_vecViewOffset = 0xF60;
                inline constexpr std::ptrdiff_t m_bNoInterpolate = 0xD2A;
                inline constexpr std::ptrdiff_t m_nObjectCulling = 0xE54;
                inline constexpr std::ptrdiff_t m_CHitboxComponent = 0xB00;
                inline constexpr std::ptrdiff_t m_CRenderComponent = 0xAF8;
                inline constexpr std::ptrdiff_t m_bAllowFadeInView = 0xC82;
                inline constexpr std::ptrdiff_t m_bodyGroupChoices = 0xF38;
                inline constexpr std::ptrdiff_t m_flShadowStrength = 0xE50;
                inline constexpr std::ptrdiff_t m_pChoreoComponent = 0xB18;
                inline constexpr std::ptrdiff_t m_bInitModelEffects = 0xC78;
                inline constexpr std::ptrdiff_t m_bRenderToCubemaps = 0xD28;
                inline constexpr std::ptrdiff_t m_bodyGroupRequests = 0xE60;
                inline constexpr std::ptrdiff_t m_ClientOverrideTint = 0x1048;
                inline constexpr std::ptrdiff_t m_bDoingModelEffects = 0xC79;
                inline constexpr std::ptrdiff_t m_flGlowBackfaceMult = 0xE40;
                inline constexpr std::ptrdiff_t m_bvDisabledHitGroups = 0x1088;
                inline constexpr std::ptrdiff_t m_vecRenderAttributes = 0xCA8;
                inline constexpr std::ptrdiff_t m_pClientAlphaProperty = 0x1040;
                inline constexpr std::ptrdiff_t m_bUseClientOverrideTint = 0x104C;
                inline constexpr std::ptrdiff_t m_nRequiredDecalRtEncoding = 0xE55;
                inline constexpr std::ptrdiff_t m_bodyGroupTotalRequestCount = 0xE58;
                inline constexpr std::ptrdiff_t m_bExpandRenderBoundsToIncludeCloth = 0xD29;
                inline constexpr std::ptrdiff_t m_pDestructiblePartsSystemComponent = 0xB50;
                inline constexpr std::ptrdiff_t m_nDestructiblePartInitialStateDestructed0 = 0xB20;
                inline constexpr std::ptrdiff_t m_nDestructiblePartInitialStateDestructed1 = 0xB24;
                inline constexpr std::ptrdiff_t m_nDestructiblePartInitialStateDestructed2 = 0xB28;
                inline constexpr std::ptrdiff_t m_nDestructiblePartInitialStateDestructed3 = 0xB2C;
                inline constexpr std::ptrdiff_t m_nDestructiblePartInitialStateDestructed4 = 0xB30;
                inline constexpr std::ptrdiff_t m_nDestructiblePartInitialStateDestructed0_PartIndex = 0xB34;
                inline constexpr std::ptrdiff_t m_nDestructiblePartInitialStateDestructed1_PartIndex = 0xB38;
                inline constexpr std::ptrdiff_t m_nDestructiblePartInitialStateDestructed2_PartIndex = 0xB3C;
                inline constexpr std::ptrdiff_t m_nDestructiblePartInitialStateDestructed3_PartIndex = 0xB40;
                inline constexpr std::ptrdiff_t m_nDestructiblePartInitialStateDestructed4_PartIndex = 0xB44;
                inline constexpr std::ptrdiff_t m_bDestructiblePartInitialStateDestructed0_GenerateBreakpieces = 0xB48;
                inline constexpr std::ptrdiff_t m_bDestructiblePartInitialStateDestructed1_GenerateBreakpieces = 0xB49;
                inline constexpr std::ptrdiff_t m_bDestructiblePartInitialStateDestructed2_GenerateBreakpieces = 0xB4A;
                inline constexpr std::ptrdiff_t m_bDestructiblePartInitialStateDestructed3_GenerateBreakpieces = 0xB4B;
                inline constexpr std::ptrdiff_t m_bDestructiblePartInitialStateDestructed4_GenerateBreakpieces = 0xB4C;
            }
            namespace C_CS2HudModelArms {

            }
            namespace C_CS2HudModelBase {

            }
            namespace C_CSWeaponBaseGun {
                inline constexpr std::ptrdiff_t m_zoomLevel = 0x1F20;
                inline constexpr std::ptrdiff_t m_inPrecache = 0x1F3C;
                inline constexpr std::ptrdiff_t m_bNeedsBoltAction = 0x1F3D;
                inline constexpr std::ptrdiff_t m_iSilencerBodygroup = 0x1F28;
                inline constexpr std::ptrdiff_t m_silencedModelIndex = 0x1F38;
                inline constexpr std::ptrdiff_t m_iBurstShotsRemaining = 0x1F24;
                inline constexpr std::ptrdiff_t m_nRevolverCylinderIdx = 0x1F40;
            }
            namespace C_ColorCorrection {
                inline constexpr std::ptrdiff_t m_bMaster = 0x825;
                inline constexpr std::ptrdiff_t m_bEnabled = 0x824;
                inline constexpr std::ptrdiff_t m_bFadingIn = 0x830;
                inline constexpr std::ptrdiff_t m_vecOrigin = 0x600;
                inline constexpr std::ptrdiff_t m_MaxFalloff = 0x610;
                inline constexpr std::ptrdiff_t m_MinFalloff = 0x60C;
                inline constexpr std::ptrdiff_t m_bExclusive = 0x827;
                inline constexpr std::ptrdiff_t m_bClientSide = 0x826;
                inline constexpr std::ptrdiff_t m_flCurWeight = 0x620;
                inline constexpr std::ptrdiff_t m_flMaxWeight = 0x61C;
                inline constexpr std::ptrdiff_t m_flFadeDuration = 0x83C;
                inline constexpr std::ptrdiff_t m_flFadeStartTime = 0x838;
                inline constexpr std::ptrdiff_t m_bEnabledOnClient = 0x828;
                inline constexpr std::ptrdiff_t m_flFadeInDuration = 0x614;
                inline constexpr std::ptrdiff_t m_flFadeOutDuration = 0x618;
                inline constexpr std::ptrdiff_t m_flFadeStartWeight = 0x834;
                inline constexpr std::ptrdiff_t m_netlookupFilename = 0x624;
                inline constexpr std::ptrdiff_t m_flCurWeightOnClient = 0x82C;
            }
            namespace C_DecoyProjectile {
                inline constexpr std::ptrdiff_t m_nDecoyShotTick = 0x1348;
                inline constexpr std::ptrdiff_t m_flTimeParticleEffectSpawn = 0x1370;
                inline constexpr std::ptrdiff_t m_nClientLastKnownDecoyShotTick = 0x134C;
            }
            namespace C_EnvParticleGlow {
                inline constexpr std::ptrdiff_t m_ColorTint = 0x1674;
                inline constexpr std::ptrdiff_t m_flAlphaScale = 0x1668;
                inline constexpr std::ptrdiff_t m_flRadiusScale = 0x166C;
                inline constexpr std::ptrdiff_t m_flSelfIllumScale = 0x1670;
                inline constexpr std::ptrdiff_t m_hTextureOverride = 0x1678;
            }
            namespace C_FootstepControl {
                inline constexpr std::ptrdiff_t m_source = 0x1180;
                inline constexpr std::ptrdiff_t m_destination = 0x1188;
            }
            namespace C_Item_Healthshot {

            }
            namespace C_LightSpotEntity {

            }
            namespace C_LocalTempEntity {
                inline constexpr std::ptrdiff_t x = 0x1274;
                inline constexpr std::ptrdiff_t y = 0x1278;
                inline constexpr std::ptrdiff_t die = 0x126C;
                inline constexpr std::ptrdiff_t flags = 0x1268;
                inline constexpr std::ptrdiff_t hitSound = 0x1284;
                inline constexpr std::ptrdiff_t priority = 0x1288;
                inline constexpr std::ptrdiff_t fadeSpeed = 0x127C;
                inline constexpr std::ptrdiff_t m_flFrame = 0x12C0;
                inline constexpr std::ptrdiff_t tentOffset = 0x128C;
                inline constexpr std::ptrdiff_t m_vecNormal = 0x12A8;
                inline constexpr std::ptrdiff_t bounceFactor = 0x1280;
                inline constexpr std::ptrdiff_t m_flFrameMax = 0x1270;
                inline constexpr std::ptrdiff_t m_flFrameRate = 0x12BC;
                inline constexpr std::ptrdiff_t m_flSpriteScale = 0x12B4;
                inline constexpr std::ptrdiff_t m_nFlickerFrame = 0x12B8;
                inline constexpr std::ptrdiff_t m_pszImpactEffect = 0x12C8;
                inline constexpr std::ptrdiff_t tempent_renderamt = 0x12A4;
                inline constexpr std::ptrdiff_t m_vecPrevAbsOrigin = 0x12F8;
                inline constexpr std::ptrdiff_t m_pszParticleEffect = 0x12D0;
                inline constexpr std::ptrdiff_t m_bParticleCollision = 0x12D8;
                inline constexpr std::ptrdiff_t m_vecTempEntVelocity = 0x12EC;
                inline constexpr std::ptrdiff_t m_iLastCollisionFrame = 0x12DC;
                inline constexpr std::ptrdiff_t m_vLastCollisionOrigin = 0x12E0;
                inline constexpr std::ptrdiff_t m_vecTempEntAngVelocity = 0x1298;
                inline constexpr std::ptrdiff_t m_vecTempEntAcceleration = 0x1304;
            }
            namespace C_PointCameraVFOV {
                inline constexpr std::ptrdiff_t m_flVerticalFOV = 0x660;
            }
            namespace C_RetakeGameRules {
                inline constexpr std::ptrdiff_t m_iBombSite = 0x144;
                inline constexpr std::ptrdiff_t m_nMatchSeed = 0x138;
                inline constexpr std::ptrdiff_t m_hBombPlanter = 0x148;
                inline constexpr std::ptrdiff_t m_bBlockersPresent = 0x13C;
                inline constexpr std::ptrdiff_t m_bRoundInProgress = 0x13D;
                inline constexpr std::ptrdiff_t m_iFirstSecondHalfRound = 0x140;
            }
            namespace C_SingleplayRules {

            }
            namespace C_SkyCameraVolume {
                inline constexpr std::ptrdiff_t m_hTarget = 0x630;
                inline constexpr std::ptrdiff_t m_vBoxMaxs = 0x624;
                inline constexpr std::ptrdiff_t m_vBoxMins = 0x618;
                inline constexpr std::ptrdiff_t m_nPriority = 0x634;
                inline constexpr std::ptrdiff_t m_bIsEnabled = 0x638;
                inline constexpr std::ptrdiff_t m_vBlurOrigin = 0x63C;
                inline constexpr std::ptrdiff_t m_iszTargetName = 0x650;
                inline constexpr std::ptrdiff_t m_bStartDisabled = 0x64A;
                inline constexpr std::ptrdiff_t m_bSkyboxBlurEffect = 0x639;
                inline constexpr std::ptrdiff_t m_bSkyboxReceivesWorldCsm = 0x648;
                inline constexpr std::ptrdiff_t m_bWorldReceivesSkyboxCsm = 0x649;
            }
            namespace C_TriggerBuoyancy {
                inline constexpr std::ptrdiff_t m_BuoyancyHelper = 0x1180;
                inline constexpr std::ptrdiff_t m_flFluidDensity = 0x1298;
            }
            namespace C_TriggerMultiple {

            }
            namespace C_WeaponFiveSeven {

            }
            namespace SequenceHistory_t {
                inline constexpr std::ptrdiff_t m_hSequence = 0x0;
                inline constexpr std::ptrdiff_t m_nSeqLoopMode = 0xC;
                inline constexpr std::ptrdiff_t m_flPlaybackRate = 0x10;
                inline constexpr std::ptrdiff_t m_flSeqStartTime = 0x4;
                inline constexpr std::ptrdiff_t m_flSeqFixedCycle = 0x8;
                inline constexpr std::ptrdiff_t m_flCyclesPerSecond = 0x14;
            }
            namespace CCSCustomHudLayout {
                inline constexpr std::ptrdiff_t m_strLayout = 0x618;
                inline constexpr std::ptrdiff_t m_bObservable = 0x620;
                inline constexpr std::ptrdiff_t m_vecPanelIds = 0x798;
                inline constexpr std::ptrdiff_t m_vecClassNames = 0x7B0;
                inline constexpr std::ptrdiff_t m_globalLayoutState = 0x690;
                inline constexpr std::ptrdiff_t m_vecPlayerLayoutStates = 0x628;
                inline constexpr std::ptrdiff_t m_vecDialogVariableNames = 0x7C8;
            }
            namespace CCSWeaponBaseVData {
                inline constexpr std::ptrdiff_t m_nPrice = 0x70C;
                inline constexpr std::ptrdiff_t m_szName = 0x720;
                inline constexpr std::ptrdiff_t m_flRange = 0x830;
                inline constexpr std::ptrdiff_t m_nDamage = 0x820;
                inline constexpr std::ptrdiff_t m_GearSlot = 0x700;
                inline constexpr std::ptrdiff_t m_flSpread = 0x750;
                inline constexpr std::ptrdiff_t m_nZoomFOV1 = 0x7F8;
                inline constexpr std::ptrdiff_t m_nZoomFOV2 = 0x7FC;
                inline constexpr std::ptrdiff_t m_WeaponType = 0x520;
                inline constexpr std::ptrdiff_t m_flMaxSpeed = 0x748;
                inline constexpr std::ptrdiff_t m_nKillAward = 0x710;
                inline constexpr std::ptrdiff_t m_bIsFullAuto = 0x72D;
                inline constexpr std::ptrdiff_t m_bIsRevolver = 0x71E;
                inline constexpr std::ptrdiff_t m_flCycleTime = 0x738;
                inline constexpr std::ptrdiff_t m_flZoomTime0 = 0x800;
                inline constexpr std::ptrdiff_t m_flZoomTime1 = 0x804;
                inline constexpr std::ptrdiff_t m_flZoomTime2 = 0x808;
                inline constexpr std::ptrdiff_t m_nNumBullets = 0x730;
                inline constexpr std::ptrdiff_t m_nRecoilSeed = 0x7D4;
                inline constexpr std::ptrdiff_t m_nSpreadSeed = 0x7D8;
                inline constexpr std::ptrdiff_t m_nZoomLevels = 0x7F4;
                inline constexpr std::ptrdiff_t m_szAnimClass = 0x868;
                inline constexpr std::ptrdiff_t m_vSmokeColor = 0x85C;
                inline constexpr std::ptrdiff_t m_bMeleeWeapon = 0x71C;
                inline constexpr std::ptrdiff_t m_flArmorRatio = 0x828;
                inline constexpr std::ptrdiff_t m_bHasBurstMode = 0x71D;
                inline constexpr std::ptrdiff_t m_eSilencerType = 0x728;
                inline constexpr std::ptrdiff_t m_flPenetration = 0x82C;
                inline constexpr std::ptrdiff_t m_flRecoilAngle = 0x790;
                inline constexpr std::ptrdiff_t m_vecMuzzlePos0 = 0x608;
                inline constexpr std::ptrdiff_t m_vecMuzzlePos1 = 0x614;
                inline constexpr std::ptrdiff_t m_WeaponCategory = 0x524;
                inline constexpr std::ptrdiff_t m_bShowCrosshair = 0x72C;
                inline constexpr std::ptrdiff_t m_flIronSightFOV = 0x814;
                inline constexpr std::ptrdiff_t m_szAnimSkeleton = 0x528;
                inline constexpr std::ptrdiff_t m_flRangeModifier = 0x834;
                inline constexpr std::ptrdiff_t m_flThrowVelocity = 0x858;
                inline constexpr std::ptrdiff_t m_nBurstShotCount = 0x7CC;
                inline constexpr std::ptrdiff_t m_GearSlotPosition = 0x704;
                inline constexpr std::ptrdiff_t m_flDeployDuration = 0x7C4;
                inline constexpr std::ptrdiff_t m_flInaccuracyFire = 0x780;
                inline constexpr std::ptrdiff_t m_flInaccuracyJump = 0x768;
                inline constexpr std::ptrdiff_t m_flInaccuracyLand = 0x770;
                inline constexpr std::ptrdiff_t m_flInaccuracyMove = 0x788;
                inline constexpr std::ptrdiff_t m_nTracerFrequency = 0x7B0;
                inline constexpr std::ptrdiff_t m_szTracerParticle = 0x620;
                inline constexpr std::ptrdiff_t m_bUnzoomsAfterShot = 0x7F0;
                inline constexpr std::ptrdiff_t m_flInaccuracyStand = 0x760;
                inline constexpr std::ptrdiff_t m_flRecoilMagnitude = 0x7A0;
                inline constexpr std::ptrdiff_t m_DefaultLoadoutSlot = 0x708;
                inline constexpr std::ptrdiff_t m_bAllowBurstHolster = 0x7D0;
                inline constexpr std::ptrdiff_t m_flInaccuracyCrouch = 0x758;
                inline constexpr std::ptrdiff_t m_flInaccuracyLadder = 0x778;
                inline constexpr std::ptrdiff_t m_flInaccuracyReload = 0x7C0;
                inline constexpr std::ptrdiff_t m_szUseRadioSubtitle = 0x7E8;
                inline constexpr std::ptrdiff_t m_flRecoveryTimeStand = 0x844;
                inline constexpr std::ptrdiff_t m_bReloadsSingleShells = 0x734;
                inline constexpr std::ptrdiff_t m_flHeadshotMultiplier = 0x824;
                inline constexpr std::ptrdiff_t m_flInaccuracyJumpApex = 0x7BC;
                inline constexpr std::ptrdiff_t m_flIronSightLooseness = 0x81C;
                inline constexpr std::ptrdiff_t m_flRecoveryTimeCrouch = 0x840;
                inline constexpr std::ptrdiff_t m_flRecoilAngleVariance = 0x798;
                inline constexpr std::ptrdiff_t m_bCannotShootUnderwater = 0x71F;
                inline constexpr std::ptrdiff_t m_flInaccuracyPitchShift = 0x7E0;
                inline constexpr std::ptrdiff_t m_flIronSightPullUpSpeed = 0x80C;
                inline constexpr std::ptrdiff_t m_nPrimaryReserveAmmoMax = 0x714;
                inline constexpr std::ptrdiff_t m_flAttackMovespeedFactor = 0x7DC;
                inline constexpr std::ptrdiff_t m_flInaccuracyJumpInitial = 0x7B8;
                inline constexpr std::ptrdiff_t m_flIronSightPivotForward = 0x818;
                inline constexpr std::ptrdiff_t m_flIronSightPutDownSpeed = 0x810;
                inline constexpr std::ptrdiff_t m_flTimeBetweenBurstShots = 0x744;
                inline constexpr std::ptrdiff_t m_bHideViewModelWhenZoomed = 0x7F1;
                inline constexpr std::ptrdiff_t m_flRecoveryTimeStandFinal = 0x84C;
                inline constexpr std::ptrdiff_t m_nSecondaryReserveAmmoMax = 0x718;
                inline constexpr std::ptrdiff_t m_flRecoilMagnitudeVariance = 0x7A8;
                inline constexpr std::ptrdiff_t m_flRecoveryTimeCrouchFinal = 0x848;
                inline constexpr std::ptrdiff_t m_flCycleTimeWhenInBurstMode = 0x740;
                inline constexpr std::ptrdiff_t m_nRecoveryTransitionEndBullet = 0x854;
                inline constexpr std::ptrdiff_t m_flFlinchVelocityModifierLarge = 0x838;
                inline constexpr std::ptrdiff_t m_flFlinchVelocityModifierSmall = 0x83C;
                inline constexpr std::ptrdiff_t m_flInaccuracyAltSoundThreshold = 0x7E4;
                inline constexpr std::ptrdiff_t m_nRecoveryTransitionStartBullet = 0x850;
                inline constexpr std::ptrdiff_t m_flDisallowAttackAfterReloadStartDuration = 0x7C8;
            }
            namespace CCollisionProperty {
                inline constexpr std::ptrdiff_t m_vecMaxs = 0x4C;
                inline constexpr std::ptrdiff_t m_vecMins = 0x40;
                inline constexpr std::ptrdiff_t m_nSolidType = 0x5B;
                inline constexpr std::ptrdiff_t m_triggerBloat = 0x5C;
                inline constexpr std::ptrdiff_t m_usSolidFlags = 0x5A;
                inline constexpr std::ptrdiff_t m_nSurroundType = 0x5D;
                inline constexpr std::ptrdiff_t m_CollisionGroup = 0x5E;
                inline constexpr std::ptrdiff_t m_nEnablePhysics = 0x5F;
                inline constexpr std::ptrdiff_t m_flCapsuleRadius = 0xAC;
                inline constexpr std::ptrdiff_t m_vCapsuleCenter1 = 0x94;
                inline constexpr std::ptrdiff_t m_vCapsuleCenter2 = 0xA0;
                inline constexpr std::ptrdiff_t m_flBoundingRadius = 0x60;
                inline constexpr std::ptrdiff_t m_collisionAttribute = 0x10;
                inline constexpr std::ptrdiff_t m_vecSurroundingMaxs = 0x7C;
                inline constexpr std::ptrdiff_t m_vecSurroundingMins = 0x88;
                inline constexpr std::ptrdiff_t m_vecSpecifiedSurroundingMaxs = 0x70;
                inline constexpr std::ptrdiff_t m_vecSpecifiedSurroundingMins = 0x64;
            }
            namespace CEconItemAttribute {
                inline constexpr std::ptrdiff_t m_flValue = 0x34;
                inline constexpr std::ptrdiff_t m_bSetBonus = 0x40;
                inline constexpr std::ptrdiff_t m_flInitialValue = 0x38;
                inline constexpr std::ptrdiff_t m_nRefundableCurrency = 0x3C;
                inline constexpr std::ptrdiff_t m_iAttributeDefinitionIndex = 0x30;
            }
            namespace CExplosionTypeData {
                inline constexpr std::ptrdiff_t m_DecalType = 0xF8;
                inline constexpr std::ptrdiff_t m_SoundName = 0x0;
                inline constexpr std::ptrdiff_t m_bHasForces = 0xF1;
                inline constexpr std::ptrdiff_t m_bIsIncindiary = 0xF0;
                inline constexpr std::ptrdiff_t m_ParticleEffect = 0x10;
            }
            namespace CFilterMassGreater {
                inline constexpr std::ptrdiff_t m_fFilterMass = 0x638;
            }
            namespace CFuncRetakeBarrier {

            }
            namespace CHostageRescueZone {

            }
            namespace CInterpolatedValue {
                inline constexpr std::ptrdiff_t m_flEndTime = 0x4;
                inline constexpr std::ptrdiff_t m_flEndValue = 0xC;
                inline constexpr std::ptrdiff_t m_flStartTime = 0x0;
                inline constexpr std::ptrdiff_t m_nInterpType = 0x10;
                inline constexpr std::ptrdiff_t m_flStartValue = 0x8;
            }
            namespace CPropDataComponent {
                inline constexpr std::ptrdiff_t m_flDmgModClub = 0x14;
                inline constexpr std::ptrdiff_t m_flDmgModFire = 0x1C;
                inline constexpr std::ptrdiff_t m_nInteractions = 0x30;
                inline constexpr std::ptrdiff_t m_flDmgModBullet = 0x10;
                inline constexpr std::ptrdiff_t m_iszBasePropData = 0x28;
                inline constexpr std::ptrdiff_t m_flDmgModExplosive = 0x18;
                inline constexpr std::ptrdiff_t m_bSpawnMotionDisabled = 0x34;
                inline constexpr std::ptrdiff_t m_nMotionDisabledSpawnFlag = 0x3C;
                inline constexpr std::ptrdiff_t m_iszPhysicsDamageTableName = 0x20;
                inline constexpr std::ptrdiff_t m_nDisableTakePhysicsDamageSpawnFlag = 0x38;
            }
            namespace CPulseCell_Unknown {
                inline constexpr std::ptrdiff_t m_UnknownKeys = 0x48;
            }
            namespace CPulse_ResumePoint {

            }
            namespace C_BasePlayerWeapon {
                inline constexpr std::ptrdiff_t m_iClip1 = 0x1928;
                inline constexpr std::ptrdiff_t m_iClip2 = 0x192C;
                inline constexpr std::ptrdiff_t m_pReserveAmmo = 0x1930;
                inline constexpr std::ptrdiff_t m_nNextPrimaryAttackTick = 0x1918;
                inline constexpr std::ptrdiff_t m_nNextSecondaryAttackTick = 0x1920;
                inline constexpr std::ptrdiff_t m_flNextPrimaryAttackTickRatio = 0x191C;
                inline constexpr std::ptrdiff_t m_flNextSecondaryAttackTickRatio = 0x1924;
            }
            namespace C_CS2HudModelAddon {

            }
            namespace C_CSGameRulesProxy {
                inline constexpr std::ptrdiff_t m_pGameRules = 0x600;
            }
            namespace C_CSPlayerPawnBase {
                inline constexpr std::ptrdiff_t m_iPlayerState = 0x14E4;
                inline constexpr std::ptrdiff_t m_bFlashBuildUp = 0x1508;
                inline constexpr std::ptrdiff_t m_pPingServices = 0x14D8;
                inline constexpr std::ptrdiff_t m_flLastSmokeAge = 0x1534;
                inline constexpr std::ptrdiff_t m_flFlashBangTime = 0x14FC;
                inline constexpr std::ptrdiff_t m_flFlashDuration = 0x1510;
                inline constexpr std::ptrdiff_t m_flFlashMaxAlpha = 0x150C;
                inline constexpr std::ptrdiff_t m_flClientDeathTime = 0x14F8;
                inline constexpr std::ptrdiff_t m_fNextThinkPushAway = 0x151C;
                inline constexpr std::ptrdiff_t m_bHasMovedSinceSpawn = 0x14E8;
                inline constexpr std::ptrdiff_t m_flFlashOverlayAlpha = 0x1504;
                inline constexpr std::ptrdiff_t m_hOriginalController = 0x1560;
                inline constexpr std::ptrdiff_t m_previousPlayerState = 0x14E0;
                inline constexpr std::ptrdiff_t m_flLastSpawnTimeIndex = 0x14EC;
                inline constexpr std::ptrdiff_t m_iProgressBarDuration = 0x14F0;
                inline constexpr std::ptrdiff_t m_flMusicRoundStartTime = 0x1528;
                inline constexpr std::ptrdiff_t m_flFlashScreenshotAlpha = 0x1500;
                inline constexpr std::ptrdiff_t m_flProgressBarStartTime = 0x14F4;
                inline constexpr std::ptrdiff_t m_vLastSmokeOverlayColor = 0x1538;
                inline constexpr std::ptrdiff_t m_bFlashDspHasBeenCleared = 0x1509;
                inline constexpr std::ptrdiff_t m_flCurrentMusicStartTime = 0x1524;
                inline constexpr std::ptrdiff_t m_flLastSmokeOverlayAlpha = 0x1530;
                inline constexpr std::ptrdiff_t m_bDeferStartMusicOnWarmup = 0x152C;
                inline constexpr std::ptrdiff_t m_nClientHealthFadeParityValue = 0x1518;
                inline constexpr std::ptrdiff_t m_bFlashScreenshotHasBeenGrabbed = 0x150A;
                inline constexpr std::ptrdiff_t m_flClientHealthFadeChangeTimestamp = 0x1514;
            }
            namespace C_CSPlayerResource {
                inline constexpr std::ptrdiff_t m_bHostageAlive = 0x600;
                inline constexpr std::ptrdiff_t m_hostageRescueX = 0x660;
                inline constexpr std::ptrdiff_t m_hostageRescueY = 0x670;
                inline constexpr std::ptrdiff_t m_hostageRescueZ = 0x680;
                inline constexpr std::ptrdiff_t m_bombsiteCenterA = 0x648;
                inline constexpr std::ptrdiff_t m_bombsiteCenterB = 0x654;
                inline constexpr std::ptrdiff_t m_iHostageEntityIDs = 0x618;
                inline constexpr std::ptrdiff_t m_foundGoalPositions = 0x691;
                inline constexpr std::ptrdiff_t m_bEndMatchNextMapAllVoted = 0x690;
                inline constexpr std::ptrdiff_t m_isHostageFollowingSomeone = 0x60C;
            }
            namespace C_FireCrackerBlast {

            }
            namespace C_LightOrthoEntity {

            }
            namespace C_ModelPointEntity {

            }
            namespace C_PathParticleRope {
                inline constexpr std::ptrdiff_t m_flSlack = 0x634;
                inline constexpr std::ptrdiff_t m_flRadius = 0x638;
                inline constexpr std::ptrdiff_t m_ColorTint = 0x63C;
                inline constexpr std::ptrdiff_t m_bStartActive = 0x608;
                inline constexpr std::ptrdiff_t m_iEffectIndex = 0x648;
                inline constexpr std::ptrdiff_t m_nEffectState = 0x640;
                inline constexpr std::ptrdiff_t m_iszEffectName = 0x610;
                inline constexpr std::ptrdiff_t m_PathNodes_Name = 0x618;
                inline constexpr std::ptrdiff_t m_PathNodes_Color = 0x698;
                inline constexpr std::ptrdiff_t m_flParticleSpacing = 0x630;
                inline constexpr std::ptrdiff_t m_PathNodes_Position = 0x650;
                inline constexpr std::ptrdiff_t m_PathNodes_TangentIn = 0x668;
                inline constexpr std::ptrdiff_t m_flMaxSimulationTime = 0x60C;
                inline constexpr std::ptrdiff_t m_PathNodes_PinEnabled = 0x6B0;
                inline constexpr std::ptrdiff_t m_PathNodes_TangentOut = 0x680;
                inline constexpr std::ptrdiff_t m_PathNodes_RadiusScale = 0x6C8;
            }
            namespace C_PlayerSprayDecal {
                inline constexpr std::ptrdiff_t m_nEntity = 0x10DC;
                inline constexpr std::ptrdiff_t m_nHitbox = 0x10E0;
                inline constexpr std::ptrdiff_t m_nPlayer = 0x10D8;
                inline constexpr std::ptrdiff_t m_nTintID = 0x10E8;
                inline constexpr std::ptrdiff_t m_vecLeft = 0x10C0;
                inline constexpr std::ptrdiff_t m_nVersion = 0x10EC;
                inline constexpr std::ptrdiff_t m_rtGcTime = 0x10A4;
                inline constexpr std::ptrdiff_t m_vecStart = 0x10B4;
                inline constexpr std::ptrdiff_t m_nUniqueID = 0x1098;
                inline constexpr std::ptrdiff_t m_unTraceID = 0x10A0;
                inline constexpr std::ptrdiff_t m_vecEndPos = 0x10A8;
                inline constexpr std::ptrdiff_t m_vecNormal = 0x10CC;
                inline constexpr std::ptrdiff_t m_ubSignature = 0x10ED;
                inline constexpr std::ptrdiff_t m_unAccountID = 0x109C;
                inline constexpr std::ptrdiff_t m_flCreationTime = 0x10E4;
                inline constexpr std::ptrdiff_t m_SprayRenderHelper = 0x1178;
            }
            namespace C_PlayerVisibility {
                inline constexpr std::ptrdiff_t m_bIsEnabled = 0x611;
                inline constexpr std::ptrdiff_t m_flFadeTime = 0x60C;
                inline constexpr std::ptrdiff_t m_bStartDisabled = 0x610;
                inline constexpr std::ptrdiff_t m_flVisibilityStrength = 0x600;
                inline constexpr std::ptrdiff_t m_flFogDistanceMultiplier = 0x604;
                inline constexpr std::ptrdiff_t m_flFogMaxDensityMultiplier = 0x608;
            }
            namespace C_PointClientUIHUD {
                inline constexpr std::ptrdiff_t m_flDPI = 0x1254;
                inline constexpr std::ptrdiff_t m_flWidth = 0x124C;
                inline constexpr std::ptrdiff_t m_flHeight = 0x1250;
                inline constexpr std::ptrdiff_t m_bIgnoreInput = 0x1248;
                inline constexpr std::ptrdiff_t m_flDepthOffset = 0x125C;
                inline constexpr std::ptrdiff_t m_unOrientation = 0x126C;
                inline constexpr std::ptrdiff_t m_vecCSSClasses = 0x1278;
                inline constexpr std::ptrdiff_t m_unOwnerContext = 0x1260;
                inline constexpr std::ptrdiff_t m_unVerticalAlign = 0x1268;
                inline constexpr std::ptrdiff_t m_bCheckCSSClasses = 0x10D0;
                inline constexpr std::ptrdiff_t m_unHorizontalAlign = 0x1264;
                inline constexpr std::ptrdiff_t m_flInteractDistance = 0x1258;
                inline constexpr std::ptrdiff_t m_bAllowInteractionFromAllSceneWorlds = 0x1270;
            }
            namespace C_PropDoorRotating {

            }
            namespace C_SoundEventEntity {
                inline constexpr std::ptrdiff_t m_hSource = 0x6B4;
                inline constexpr std::ptrdiff_t m_bStopOnNew = 0x602;
                inline constexpr std::ptrdiff_t m_bSaveRestore = 0x603;
                inline constexpr std::ptrdiff_t m_iszSoundName = 0x698;
                inline constexpr std::ptrdiff_t m_bStartOnSpawn = 0x600;
                inline constexpr std::ptrdiff_t m_onGUIDChanged = 0x620;
                inline constexpr std::ptrdiff_t m_bToLocalPlayer = 0x601;
                inline constexpr std::ptrdiff_t m_bClientSideOnly = 0x0;
                inline constexpr std::ptrdiff_t m_bSavedIsPlaying = 0x604;
                inline constexpr std::ptrdiff_t m_onSoundFinished = 0x650;
                inline constexpr std::ptrdiff_t m_iszAttachmentName = 0x618;
                inline constexpr std::ptrdiff_t m_flClientCullRadius = 0x668;
                inline constexpr std::ptrdiff_t m_flSavedElapsedTime = 0x608;
                inline constexpr std::ptrdiff_t m_iszSourceEntityName = 0x610;
                inline constexpr std::ptrdiff_t m_nEntityIndexSelection = 0x6B8;
            }
            namespace C_WorldModelGloves {

            }
            namespace inv_image_camera_t {
                inline constexpr std::ptrdiff_t zfar = 0x18;
                inline constexpr std::ptrdiff_t angle = 0x0;
                inline constexpr std::ptrdiff_t fov_h = 0xC;
                inline constexpr std::ptrdiff_t fov_v = 0x10;
                inline constexpr std::ptrdiff_t znear = 0x14;
                inline constexpr std::ptrdiff_t target = 0x1C;
                inline constexpr std::ptrdiff_t target_nudge = 0x28;
                inline constexpr std::ptrdiff_t orbit_distance = 0x34;
            }
            namespace shard_model_desc_t {
                inline constexpr std::ptrdiff_t m_solid = 0x20;
                inline constexpr std::ptrdiff_t m_nModelID = 0x8;
                inline constexpr std::ptrdiff_t m_bHasParent = 0x74;
                inline constexpr std::ptrdiff_t m_vecPanelSize = 0x24;
                inline constexpr std::ptrdiff_t m_bParentFrozen = 0x75;
                inline constexpr std::ptrdiff_t m_hMaterialBase = 0x10;
                inline constexpr std::ptrdiff_t m_vecPanelVertices = 0x40;
                inline constexpr std::ptrdiff_t m_vecStressPositionA = 0x2C;
                inline constexpr std::ptrdiff_t m_vecStressPositionB = 0x34;
                inline constexpr std::ptrdiff_t m_flGlassHalfThickness = 0x70;
                inline constexpr std::ptrdiff_t m_vInitialPanelVertices = 0x58;
                inline constexpr std::ptrdiff_t m_SurfacePropStringToken = 0x78;
                inline constexpr std::ptrdiff_t m_hMaterialDamageOverlay = 0x18;
            }
            namespace ActiveModelConfig_t {
                inline constexpr std::ptrdiff_t m_Name = 0x38;
                inline constexpr std::ptrdiff_t m_Handle = 0x30;
                inline constexpr std::ptrdiff_t m_AssociatedEntities = 0x40;
                inline constexpr std::ptrdiff_t m_AssociatedEntityNames = 0x58;
            }
            namespace CBodyComponentPoint {
                inline constexpr std::ptrdiff_t m_sceneNode = 0x80;
            }
            namespace CCSPlayerController {
                inline constexpr std::ptrdiff_t m_iMVPs = 0x970;
                inline constexpr std::ptrdiff_t m_iPing = 0x838;
                inline constexpr std::ptrdiff_t m_iScore = 0x954;
                inline constexpr std::ptrdiff_t m_szClan = 0x868;
                inline constexpr std::ptrdiff_t m_eMvpReason = 0x964;
                inline constexpr std::ptrdiff_t m_iPawnArmor = 0x93C;
                inline constexpr std::ptrdiff_t m_nFirstKill = 0x960;
                inline constexpr std::ptrdiff_t m_nKillCount = 0x961;
                inline constexpr std::ptrdiff_t m_bMvpNoMusic = 0x962;
                inline constexpr std::ptrdiff_t m_hPlayerPawn = 0x92C;
                inline constexpr std::ptrdiff_t m_iDraftIndex = 0x8F8;
                inline constexpr std::ptrdiff_t m_iMusicKitID = 0x968;
                inline constexpr std::ptrdiff_t m_iPawnHealth = 0x938;
                inline constexpr std::ptrdiff_t m_bPawnIsAlive = 0x934;
                inline constexpr std::ptrdiff_t m_hObserverPawn = 0x930;
                inline constexpr std::ptrdiff_t m_iCoachingTeam = 0x888;
                inline constexpr std::ptrdiff_t m_iMusicKitMVPs = 0x96C;
                inline constexpr std::ptrdiff_t m_unClanId32bit = 0x870;
                inline constexpr std::ptrdiff_t m_bPawnHasHelmet = 0x941;
                inline constexpr std::ptrdiff_t m_bScoreReported = 0x90D;
                inline constexpr std::ptrdiff_t m_bCannotBeKicked = 0x908;
                inline constexpr std::ptrdiff_t m_bControllingBot = 0x920;
                inline constexpr std::ptrdiff_t m_bPawnHasDefuser = 0x940;
                inline constexpr std::ptrdiff_t m_flForceTeamTime = 0x854;
                inline constexpr std::ptrdiff_t m_iPendingTeamNum = 0x850;
                inline constexpr std::ptrdiff_t m_pDamageServices = 0x830;
                inline constexpr std::ptrdiff_t m_recentKillQueue = 0x958;
                inline constexpr std::ptrdiff_t m_unActiveQuestId = 0x8BC;
                inline constexpr std::ptrdiff_t m_iCompetitiveWins = 0x8A4;
                inline constexpr std::ptrdiff_t m_iPawnLifetimeEnd = 0x948;
                inline constexpr std::ptrdiff_t m_nPlayerDominated = 0x890;
                inline constexpr std::ptrdiff_t m_szCrosshairCodes = 0x848;
                inline constexpr std::ptrdiff_t m_bEverPlayedOnTeam = 0x85C;
                inline constexpr std::ptrdiff_t m_sSanitizedClanTag = 0x880;
                inline constexpr std::ptrdiff_t m_bIsPlayerNameDirty = 0x974;
                inline constexpr std::ptrdiff_t m_iCompTeammateColor = 0x858;
                inline constexpr std::ptrdiff_t m_iPawnBotDifficulty = 0x94C;
                inline constexpr std::ptrdiff_t m_iPawnLifetimeStart = 0x944;
                inline constexpr std::ptrdiff_t m_nDisconnectionTick = 0x910;
                inline constexpr std::ptrdiff_t m_pInventoryServices = 0x820;
                inline constexpr std::ptrdiff_t m_bEverFullyConnected = 0x909;
                inline constexpr std::ptrdiff_t m_iCompetitiveRanking = 0x8A0;
                inline constexpr std::ptrdiff_t m_nPlayerDominatingMe = 0x898;
                inline constexpr std::ptrdiff_t m_iCompetitiveRankType = 0x8A8;
                inline constexpr std::ptrdiff_t m_nEndMatchNextMapVote = 0x8B8;
                inline constexpr std::ptrdiff_t m_nQuestProgressReason = 0x8C4;
                inline constexpr std::ptrdiff_t m_pInGameMoneyServices = 0x818;
                inline constexpr std::ptrdiff_t m_sSanitizedPlayerName = 0x878;
                inline constexpr std::ptrdiff_t m_rtActiveMissionPeriod = 0x8C0;
                inline constexpr std::ptrdiff_t m_bCanControlObservedBot = 0x928;
                inline constexpr std::ptrdiff_t m_nPawnCharacterDefIndex = 0x942;
                inline constexpr std::ptrdiff_t m_unPlayerTvControlFlags = 0x8C8;
                inline constexpr std::ptrdiff_t m_bAbandonAllowsSurrender = 0x90A;
                inline constexpr std::ptrdiff_t m_pActionTrackingServices = 0x828;
                inline constexpr std::ptrdiff_t m_uiAbandonRecordedReason = 0x900;
                inline constexpr std::ptrdiff_t m_nBotsControlledThisRound = 0x924;
                inline constexpr std::ptrdiff_t m_uiCommunicationMuteFlags = 0x840;
                inline constexpr std::ptrdiff_t m_bHasCommunicationAbuseMute = 0x83C;
                inline constexpr std::ptrdiff_t m_bHasControlledBotThisRound = 0x921;
                inline constexpr std::ptrdiff_t m_eNetworkDisconnectionReason = 0x904;
                inline constexpr std::ptrdiff_t m_flPreviousForceJoinTeamTime = 0x860;
                inline constexpr std::ptrdiff_t m_bFireBulletsSeedSynchronized = 0x97C;
                inline constexpr std::ptrdiff_t m_bAbandonOffersInstantSurrender = 0x90B;
                inline constexpr std::ptrdiff_t m_bDisconnection1MinWarningPrinted = 0x90C;
                inline constexpr std::ptrdiff_t m_hOriginalControllerOfCurrentPawn = 0x950;
                inline constexpr std::ptrdiff_t m_iCompetitiveRankingPredicted_Tie = 0x8B4;
                inline constexpr std::ptrdiff_t m_iCompetitiveRankingPredicted_Win = 0x8AC;
                inline constexpr std::ptrdiff_t m_iCompetitiveRankingPredicted_Loss = 0x8B0;
                inline constexpr std::ptrdiff_t m_msQueuedModeDisconnectionTimestamp = 0x8FC;
                inline constexpr std::ptrdiff_t m_bHasBeenControlledByPlayerThisRound = 0x922;
            }
            namespace CCSPlayerLegacyJump {
                inline constexpr std::ptrdiff_t m_bOldJumpPressed = 0x10;
                inline constexpr std::ptrdiff_t m_flJumpPressedTime = 0x14;
            }
            namespace CCSPlayerModernJump {
                inline constexpr std::ptrdiff_t m_nLastLandedTick = 0x20;
                inline constexpr std::ptrdiff_t m_flLastLandedFrac = 0x24;
                inline constexpr std::ptrdiff_t m_flLastLandedVelocityX = 0x28;
                inline constexpr std::ptrdiff_t m_flLastLandedVelocityY = 0x2C;
                inline constexpr std::ptrdiff_t m_flLastLandedVelocityZ = 0x30;
                inline constexpr std::ptrdiff_t m_nLastActualJumpPressTick = 0x10;
                inline constexpr std::ptrdiff_t m_nLastUsableJumpPressTick = 0x18;
                inline constexpr std::ptrdiff_t m_flLastActualJumpPressFrac = 0x14;
                inline constexpr std::ptrdiff_t m_flLastUsableJumpPressFrac = 0x1C;
            }
            namespace CEnvSoundscapeProxy {
                inline constexpr std::ptrdiff_t m_MainSoundscapeName = 0x690;
            }
            namespace CFilterAttributeInt {
                inline constexpr std::ptrdiff_t m_sAttributeName = 0x638;
            }
            namespace CInfoParticleTarget {

            }
            namespace CInventoryImageData {
                inline constexpr std::ptrdiff_t name = 0x8;
                inline constexpr std::ptrdiff_t m_nNodeType = 0x0;
                inline constexpr std::ptrdiff_t inventory_image_data = 0x10;
            }
            namespace CPathQueryComponent {

            }
            namespace CPlayer_UseServices {

            }
            namespace CPointChildModifier {
                inline constexpr std::ptrdiff_t m_bOrphanInsteadOfDeletingChildrenOnRemove = 0x600;
            }
            namespace CPrecipitationVData {
                inline constexpr std::ptrdiff_t m_nRTEnvCP = 0x2D4;
                inline constexpr std::ptrdiff_t m_szModifier = 0x2E0;
                inline constexpr std::ptrdiff_t m_nAttachType = 0x2CC;
                inline constexpr std::ptrdiff_t m_snapshotFilter = 0x2EC;
                inline constexpr std::ptrdiff_t m_flInnerDistance = 0x2C8;
                inline constexpr std::ptrdiff_t m_nRTEnvCPComponent = 0x2D8;
                inline constexpr std::ptrdiff_t m_bBatchSameVolumeType = 0x2D0;
                inline constexpr std::ptrdiff_t m_nUseSnapshotFromSurfaceGraph = 0x2E8;
                inline constexpr std::ptrdiff_t m_szParticlePrecipitationEffect = 0x28;
                inline constexpr std::ptrdiff_t m_szParticlePrecipitationPostEffect = 0x1E8;
                inline constexpr std::ptrdiff_t m_szParticlePrecipitationPuddleEffect = 0x108;
            }
            namespace CPulseCell_BaseFlow {

            }
            namespace CPulseCell_BaseLerp {
                inline constexpr std::ptrdiff_t m_WakeResume = 0xD8;
            }
            namespace CPulseCell_Timeline {
                inline constexpr std::ptrdiff_t m_OnFinished = 0xF8;
                inline constexpr std::ptrdiff_t m_TimelineEvents = 0xD8;
                inline constexpr std::ptrdiff_t m_bWaitForChildOutflows = 0xF0;
            }
            namespace C_CS2HudModelWeapon {

            }
            namespace C_CSGO_PreviewModel {
                inline constexpr std::ptrdiff_t m_defaultAnim = 0x1268;
                inline constexpr std::ptrdiff_t m_flInitialModelScale = 0x1274;
                inline constexpr std::ptrdiff_t m_sInitialWeaponState = 0x1278;
                inline constexpr std::ptrdiff_t m_nDefaultAnimLoopMode = 0x1270;
            }
            namespace C_CSMinimapBoundary {

            }
            namespace C_EnvWindClientside {
                inline constexpr std::ptrdiff_t m_EnvWindShared = 0x600;
            }
            namespace C_IncendiaryGrenade {

            }
            namespace C_InfoVisibilityBox {
                inline constexpr std::ptrdiff_t m_nMode = 0x604;
                inline constexpr std::ptrdiff_t m_bEnabled = 0x614;
                inline constexpr std::ptrdiff_t m_vBoxSize = 0x608;
            }
            namespace C_MolotovProjectile {
                inline constexpr std::ptrdiff_t m_bIsIncGrenade = 0x1348;
            }
            namespace C_TriggerLerpObject {

            }
            namespace C_WeaponUSPSilencer {

            }
            namespace C_fogplayerparams_t {
                inline constexpr std::ptrdiff_t m_hCtrl = 0x8;
                inline constexpr std::ptrdiff_t m_NewColor = 0x28;
                inline constexpr std::ptrdiff_t m_OldColor = 0x10;
                inline constexpr std::ptrdiff_t m_flNewEnd = 0x30;
                inline constexpr std::ptrdiff_t m_flOldEnd = 0x18;
                inline constexpr std::ptrdiff_t m_flNewFarZ = 0x3C;
                inline constexpr std::ptrdiff_t m_flOldFarZ = 0x24;
                inline constexpr std::ptrdiff_t m_flNewStart = 0x2C;
                inline constexpr std::ptrdiff_t m_flOldStart = 0x14;
                inline constexpr std::ptrdiff_t m_flNewMaxDensity = 0x34;
                inline constexpr std::ptrdiff_t m_flOldMaxDensity = 0x1C;
                inline constexpr std::ptrdiff_t m_flTransitionTime = 0xC;
                inline constexpr std::ptrdiff_t m_flNewHDRColorScale = 0x38;
                inline constexpr std::ptrdiff_t m_flOldHDRColorScale = 0x20;
            }
            namespace CompositeMaterial_t {
                inline constexpr std::ptrdiff_t m_FinalKVs = 0x58;
                inline constexpr std::ptrdiff_t m_TargetKVs = 0x8;
                inline constexpr std::ptrdiff_t m_PreGenerationKVs = 0x18;
                inline constexpr std::ptrdiff_t m_vecGeneratedTextures = 0x80;
            }
            namespace CCSObservableElement {
                inline constexpr std::ptrdiff_t m_nTeamFilter = 0x628;
                inline constexpr std::ptrdiff_t m_hObservableModelEntity = 0x620;
                inline constexpr std::ptrdiff_t m_hObservableModelEntity2 = 0x624;
                inline constexpr std::ptrdiff_t m_iszObservableModelEntity = 0x618;
            }
            namespace CClientAlphaProperty {
                inline constexpr std::ptrdiff_t m_nAlpha = 0x17;
                inline constexpr std::ptrdiff_t m_nRenderFX = 0x0;
                inline constexpr std::ptrdiff_t m_flFadeScale = 0x18;
                inline constexpr std::ptrdiff_t m_nRenderMode = 0x0;
                inline constexpr std::ptrdiff_t m_nDistFadeEnd = 0x12;
                inline constexpr std::ptrdiff_t m_nDesyncOffset = 0x0;
                inline constexpr std::ptrdiff_t m_bAlphaOverride = 0x0;
                inline constexpr std::ptrdiff_t m_nDistFadeStart = 0x10;
                inline constexpr std::ptrdiff_t m_flRenderFxDuration = 0x20;
                inline constexpr std::ptrdiff_t m_flRenderFxStartTime = 0x1C;
                inline constexpr std::ptrdiff_t m_bShadowAlphaOverride = 0x0;
            }
            namespace CGameSceneNodeHandle {
                inline constexpr std::ptrdiff_t m_name = 0xC;
                inline constexpr std::ptrdiff_t m_hOwner = 0x8;
            }
            namespace CPlayer_ItemServices {

            }
            namespace CPulseCell_BaseState {

            }
            namespace CPulseCell_BaseValue {

            }
            namespace CPulseGameBlackboard {
                inline constexpr std::ptrdiff_t m_strGraphName = 0x608;
                inline constexpr std::ptrdiff_t m_strStateBlob = 0x610;
            }
            namespace CPulse_InvokeBinding {
                inline constexpr std::ptrdiff_t m_FuncName = 0x30;
                inline constexpr std::ptrdiff_t m_nSrcChunk = 0x44;
                inline constexpr std::ptrdiff_t m_nCellIndex = 0x40;
                inline constexpr std::ptrdiff_t m_RegisterMap = 0x0;
                inline constexpr std::ptrdiff_t m_nSrcInstruction = 0x48;
            }
            namespace C_AttributeContainer {
                inline constexpr std::ptrdiff_t m_Item = 0x50;
                inline constexpr std::ptrdiff_t m_ullRegisteredAsItemID = 0x608;
                inline constexpr std::ptrdiff_t m_iExternalItemProviderRegisteredToken = 0x600;
            }
            namespace C_BaseClientUIEntity {
                inline constexpr std::ptrdiff_t m_PanelID = 0x10B8;
                inline constexpr std::ptrdiff_t m_bEnabled = 0x10A0;
                inline constexpr std::ptrdiff_t m_DialogXMLName = 0x10A8;
                inline constexpr std::ptrdiff_t m_PanelClassName = 0x10B0;
            }
            namespace C_CSGO_PreviewPlayer {
                inline constexpr std::ptrdiff_t m_flInitialModelScale = 0x3718;
                inline constexpr std::ptrdiff_t m_animgraphCharacterModeString = 0x3710;
            }
            namespace C_InfoLadderDismount {

            }
            namespace C_PhysPropClientside {
                inline constexpr std::ptrdiff_t m_fDeathTime = 0x13E4;
                inline constexpr std::ptrdiff_t m_nDamageType = 0x1400;
                inline constexpr std::ptrdiff_t m_flTouchDelta = 0x13E0;
                inline constexpr std::ptrdiff_t m_vecDamagePosition = 0x13E8;
                inline constexpr std::ptrdiff_t m_vecDamageDirection = 0x13F4;
            }
            namespace C_PointValueRemapper {
                inline constexpr std::ptrdiff_t m_bEngaged = 0x660;
                inline constexpr std::ptrdiff_t m_bDisabled = 0x600;
                inline constexpr std::ptrdiff_t m_nInputType = 0x604;
                inline constexpr std::ptrdiff_t m_flSnapValue = 0x64C;
                inline constexpr std::ptrdiff_t m_nOutputType = 0x620;
                inline constexpr std::ptrdiff_t m_bDisabledOld = 0x601;
                inline constexpr std::ptrdiff_t m_bFirstUpdate = 0x661;
                inline constexpr std::ptrdiff_t m_nHapticsType = 0x640;
                inline constexpr std::ptrdiff_t m_nRatchetType = 0x654;
                inline constexpr std::ptrdiff_t m_flInputOffset = 0x65C;
                inline constexpr std::ptrdiff_t m_hRemapLineEnd = 0x60C;
                inline constexpr std::ptrdiff_t m_nMomentumType = 0x644;
                inline constexpr std::ptrdiff_t m_bRequiresUseKey = 0x61C;
                inline constexpr std::ptrdiff_t m_bUpdateOnClient = 0x602;
                inline constexpr std::ptrdiff_t m_flPreviousValue = 0x664;
                inline constexpr std::ptrdiff_t m_flRatchetOffset = 0x658;
                inline constexpr std::ptrdiff_t m_hOutputEntities = 0x628;
                inline constexpr std::ptrdiff_t m_hRemapLineStart = 0x608;
                inline constexpr std::ptrdiff_t m_flEngageDistance = 0x618;
                inline constexpr std::ptrdiff_t m_flCurrentMomentum = 0x650;
                inline constexpr std::ptrdiff_t m_flMomentumModifier = 0x648;
                inline constexpr std::ptrdiff_t m_flDisengageDistance = 0x614;
                inline constexpr std::ptrdiff_t m_vecPreviousTestPoint = 0x66C;
                inline constexpr std::ptrdiff_t m_flMaximumChangePerSecond = 0x610;
                inline constexpr std::ptrdiff_t m_flPreviousUpdateTickTime = 0x668;
            }
            namespace C_TonemapController2 {
                inline constexpr std::ptrdiff_t m_flAutoExposureMax = 0x604;
                inline constexpr std::ptrdiff_t m_flAutoExposureMin = 0x600;
                inline constexpr std::ptrdiff_t m_flTonemapEVSmoothingRange = 0x610;
                inline constexpr std::ptrdiff_t m_flExposureAdaptationSpeedUp = 0x608;
                inline constexpr std::ptrdiff_t m_flExposureAdaptationSpeedDown = 0x60C;
            }
            namespace C_WeaponM4A1Silencer {

            }
            namespace EngineCountdownTimer {
                inline constexpr std::ptrdiff_t m_duration = 0x8;
                inline constexpr std::ptrdiff_t m_timescale = 0x10;
                inline constexpr std::ptrdiff_t m_timestamp = 0xC;
            }
            namespace EntitySpottedState_t {
                inline constexpr std::ptrdiff_t m_bSpotted = 0x8;
                inline constexpr std::ptrdiff_t m_bSpottedByMask = 0xC;
            }
            namespace IClientAlphaProperty {

            }
            namespace PhysicsRagdollPose_t {
                inline constexpr std::ptrdiff_t m_hOwner = 0x20;
                inline constexpr std::ptrdiff_t m_RelativeTransforms = 0x8;
                inline constexpr std::ptrdiff_t m_bSetFromDebugHistory = 0x24;
            }
            namespace CBasePlayerController {
                inline constexpr std::ptrdiff_t m_hPawn = 0x6BC;
                inline constexpr std::ptrdiff_t m_bIsHLTV = 0x6F0;
                inline constexpr std::ptrdiff_t m_steamID = 0x788;
                inline constexpr std::ptrdiff_t m_nTickBase = 0x6B8;
                inline constexpr std::ptrdiff_t m_iConnected = 0x6F4;
                inline constexpr std::ptrdiff_t m_hSplitOwner = 0x6D0;
                inline constexpr std::ptrdiff_t m_iDesiredFOV = 0x794;
                inline constexpr std::ptrdiff_t m_iszPlayerName = 0x6FC;
                inline constexpr std::ptrdiff_t m_CommandContext = 0x608;
                inline constexpr std::ptrdiff_t m_bNoClipEnabled = 0x791;
                inline constexpr std::ptrdiff_t m_hPredictedPawn = 0x6C4;
                inline constexpr std::ptrdiff_t m_iMostConnected = 0x6F8;
                inline constexpr std::ptrdiff_t m_nSplitScreenSlot = 0x6CC;
                inline constexpr std::ptrdiff_t m_bKnownTeamMismatch = 0x6C0;
                inline constexpr std::ptrdiff_t m_hSplitScreenPlayers = 0x6D8;
                inline constexpr std::ptrdiff_t m_bIsLocalPlayerController = 0x790;
                inline constexpr std::ptrdiff_t m_nInButtonsWhichAreToggles = 0x6B0;
            }
            namespace CCSCustomPlayerCamera {
                inline constexpr std::ptrdiff_t m_hPawn = 0x600;
                inline constexpr std::ptrdiff_t m_bFollowEyes = 0x60C;
                inline constexpr std::ptrdiff_t m_nCameraMode = 0x604;
                inline constexpr std::ptrdiff_t m_hFollowEntity = 0x608;
                inline constexpr std::ptrdiff_t m_vecCameraOffset = 0x61C;
                inline constexpr std::ptrdiff_t m_vecFollowOffset = 0x610;
                inline constexpr std::ptrdiff_t m_bClipCameraOffset = 0x628;
                inline constexpr std::ptrdiff_t m_flCameraOffsetReturnStrength = 0x62C;
            }
            namespace CCSGameModeRules_Noop {

            }
            namespace CCSPlayer_BuyServices {
                inline constexpr std::ptrdiff_t m_vecSellbackPurchaseEntries = 0x48;
            }
            namespace CCSPlayer_UseServices {

            }
            namespace CPathWithDynamicNodes {
                inline constexpr std::ptrdiff_t m_vecPathNodes = 0x710;
                inline constexpr std::ptrdiff_t m_eDesiredDirection = 0x750;
                inline constexpr std::ptrdiff_t m_bIgnoreParentRotation = 0x754;
                inline constexpr std::ptrdiff_t m_xInitialPathWorldToLocal = 0x730;
            }
            namespace CPlayer_WaterServices {

            }
            namespace CPulseCell_LimitCount {
                inline constexpr std::ptrdiff_t m_nLimitCount = 0x48;
            }
            namespace C_BaseCombatCharacter {
                inline constexpr std::ptrdiff_t m_hMyWearables = 0x1268;
                inline constexpr std::ptrdiff_t m_flWaterWorldZ = 0x1288;
                inline constexpr std::ptrdiff_t m_nWaterWakeMode = 0x1284;
                inline constexpr std::ptrdiff_t m_leftFootAttachment = 0x1280;
                inline constexpr std::ptrdiff_t m_rightFootAttachment = 0x1281;
                inline constexpr std::ptrdiff_t m_flWaterNextTraceTime = 0x128C;
            }
            namespace C_CS2WeaponModuleBase {

            }
            namespace C_CSWeaponBaseShotgun {

            }
            namespace C_EnvDetailController {
                inline constexpr std::ptrdiff_t m_flFadeEndDist = 0x604;
                inline constexpr std::ptrdiff_t m_flFadeStartDist = 0x600;
            }
            namespace C_EnvLightProbeVolume {
                inline constexpr std::ptrdiff_t m_Entity_bEnabled = 0x719;
                inline constexpr std::ptrdiff_t m_Entity_vBoxMaxs = 0x6DC;
                inline constexpr std::ptrdiff_t m_Entity_vBoxMins = 0x6D0;
                inline constexpr std::ptrdiff_t m_Entity_bMoveable = 0x6E8;
                inline constexpr std::ptrdiff_t m_Entity_nPriority = 0x6F0;
                inline constexpr std::ptrdiff_t m_Entity_nHandshake = 0x6EC;
                inline constexpr std::ptrdiff_t m_Entity_bStartDisabled = 0x6F4;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeSizeX = 0x6F8;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeSizeY = 0x6FC;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeSizeZ = 0x700;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeAtlasX = 0x704;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeAtlasY = 0x708;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeAtlasZ = 0x70C;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeTexture_SDF = 0x6A0;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeTexture_SH2_DC = 0x6A8;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeTexture_SH2_L1 = 0x6B0;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeTexture_AmbientCube = 0x698;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeDirectLightIndicesTexture = 0x6B8;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeDirectLightScalarsTexture = 0x6C0;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeDirectLightShadowsTexture = 0x6C8;
            }
            namespace C_FlashbangProjectile {

            }
            namespace C_HEGrenadeProjectile {

            }
            namespace C_IronSightController {
                inline constexpr std::ptrdiff_t m_angViewLast = 0x90;
                inline constexpr std::ptrdiff_t m_flSpeedRatio = 0xA8;
                inline constexpr std::ptrdiff_t m_vecDotCoords = 0x9C;
                inline constexpr std::ptrdiff_t m_angDeltaAverage = 0x30;
                inline constexpr std::ptrdiff_t m_flIronSightAmount = 0x14;
                inline constexpr std::ptrdiff_t m_bIronSightAvailable = 0x10;
                inline constexpr std::ptrdiff_t m_flIronSightAmountBiased = 0x1C;
                inline constexpr std::ptrdiff_t m_flIronSightAmountGained = 0x18;
                inline constexpr std::ptrdiff_t m_flInterpolationLastUpdated = 0x2C;
                inline constexpr std::ptrdiff_t m_flIronSightAmount_Interpolated = 0x20;
                inline constexpr std::ptrdiff_t m_flIronSightAmountBiased_Interpolated = 0x28;
                inline constexpr std::ptrdiff_t m_flIronSightAmountGained_Interpolated = 0x24;
                inline constexpr std::ptrdiff_t m_flFiringInaccuracyExtraWidthMultiplier = 0xA4;
            }
            namespace C_PointClientUIDialog {
                inline constexpr std::ptrdiff_t m_hActivator = 0x10C8;
                inline constexpr std::ptrdiff_t m_bStartEnabled = 0x10CC;
            }
            namespace C_PointCommentaryNode {
                inline constexpr std::ptrdiff_t m_bActive = 0x1280;
                inline constexpr std::ptrdiff_t m_iszTitle = 0x1298;
                inline constexpr std::ptrdiff_t m_flEndTime = 0x1284;
                inline constexpr std::ptrdiff_t m_bWasActive = 0x1281;
                inline constexpr std::ptrdiff_t m_bListenedTo = 0x12B0;
                inline constexpr std::ptrdiff_t m_flStartTime = 0x1288;
                inline constexpr std::ptrdiff_t m_iNodeNumber = 0x12A8;
                inline constexpr std::ptrdiff_t m_iszSpeakers = 0x12A0;
                inline constexpr std::ptrdiff_t m_hViewPosition = 0x12C0;
                inline constexpr std::ptrdiff_t m_sndCommentary = 0x12B8;
                inline constexpr std::ptrdiff_t m_iNodeNumberMax = 0x12AC;
                inline constexpr std::ptrdiff_t m_iszCommentaryFile = 0x1290;
                inline constexpr std::ptrdiff_t m_bRestartAfterRestore = 0x12C4;
                inline constexpr std::ptrdiff_t m_flStartTimeInCommentary = 0x128C;
            }
            namespace C_PointDeathcamBounds {
                inline constexpr std::ptrdiff_t m_vBoxMaxs = 0x60C;
                inline constexpr std::ptrdiff_t m_vBoxMins = 0x600;
                inline constexpr std::ptrdiff_t m_flLerpDistance = 0x618;
            }
            namespace C_RagdollPropAttached {
                inline constexpr std::ptrdiff_t m_vecOffset = 0x1310;
                inline constexpr std::ptrdiff_t m_bHasParent = 0x1320;
                inline constexpr std::ptrdiff_t m_parentTime = 0x131C;
                inline constexpr std::ptrdiff_t m_boneIndexAttached = 0x12F0;
                inline constexpr std::ptrdiff_t m_attachmentPointBoneSpace = 0x12F8;
                inline constexpr std::ptrdiff_t m_ragdollAttachedObjectIndex = 0x12F4;
                inline constexpr std::ptrdiff_t m_attachmentPointRagdollSpace = 0x1304;
            }
            namespace C_SoundAreaEntityBase {
                inline constexpr std::ptrdiff_t m_vPos = 0x618;
                inline constexpr std::ptrdiff_t m_bDisabled = 0x600;
                inline constexpr std::ptrdiff_t m_bWasEnabled = 0x608;
                inline constexpr std::ptrdiff_t m_iszSoundAreaType = 0x610;
            }
            namespace C_SoundEventBoxEntity {
                inline constexpr std::ptrdiff_t m_vecBoxHelpersNetworked = 0x6C0;
            }
            namespace C_SoundEventBoxHelper {
                inline constexpr std::ptrdiff_t m_vMaxs = 0x60C;
                inline constexpr std::ptrdiff_t m_vMins = 0x600;
            }
            namespace C_SoundEventOBBEntity {
                inline constexpr std::ptrdiff_t m_vMaxs = 0x6CC;
                inline constexpr std::ptrdiff_t m_vMins = 0x6C0;
            }
            namespace WeaponPurchaseCount_t {
                inline constexpr std::ptrdiff_t m_nCount = 0x32;
                inline constexpr std::ptrdiff_t m_nItemDefIndex = 0x30;
            }
            namespace inv_image_light_sun_t {
                inline constexpr std::ptrdiff_t angle = 0xC;
                inline constexpr std::ptrdiff_t color = 0x0;
                inline constexpr std::ptrdiff_t brightness = 0x18;
            }
            namespace CBasePlayerWeaponVData {
                inline constexpr std::ptrdiff_t m_iSlot = 0x4EC;
                inline constexpr std::ptrdiff_t m_iFlags = 0x4C7;
                inline constexpr std::ptrdiff_t m_iWeight = 0x4C8;
                inline constexpr std::ptrdiff_t m_iMaxClip1 = 0x4D0;
                inline constexpr std::ptrdiff_t m_iMaxClip2 = 0x4D4;
                inline constexpr std::ptrdiff_t m_iPosition = 0x4F0;
                inline constexpr std::ptrdiff_t m_flDropSpeed = 0x4E8;
                inline constexpr std::ptrdiff_t m_aShootSounds = 0x4F8;
                inline constexpr std::ptrdiff_t m_szWorldModel = 0x28;
                inline constexpr std::ptrdiff_t m_bAutoSwitchTo = 0x4CC;
                inline constexpr std::ptrdiff_t m_iDefaultClip1 = 0x4D8;
                inline constexpr std::ptrdiff_t m_iDefaultClip2 = 0x4DC;
                inline constexpr std::ptrdiff_t m_iRumbleEffect = 0x4E4;
                inline constexpr std::ptrdiff_t m_bAllowFlipping = 0x2C9;
                inline constexpr std::ptrdiff_t m_bAutoSwitchFrom = 0x4CD;
                inline constexpr std::ptrdiff_t m_bKeepLoadedAmmo = 0x4E2;
                inline constexpr std::ptrdiff_t m_bLinkedCooldowns = 0x4C6;
                inline constexpr std::ptrdiff_t m_nPrimaryAmmoType = 0x4CE;
                inline constexpr std::ptrdiff_t m_bBuiltRightHanded = 0x2C8;
                inline constexpr std::ptrdiff_t m_sMuzzleAttachment = 0x2D0;
                inline constexpr std::ptrdiff_t m_bTreatAsSingleClip = 0x4E1;
                inline constexpr std::ptrdiff_t m_nSecondaryAmmoType = 0x4CF;
                inline constexpr std::ptrdiff_t m_bReserveAmmoAsClips = 0x4E0;
                inline constexpr std::ptrdiff_t m_bGenerateMuzzleLight = 0x4C4;
                inline constexpr std::ptrdiff_t m_flMuzzleSmokeTimeout = 0x4BC;
                inline constexpr std::ptrdiff_t m_bShouldAnimateInWorld = 0x4C5;
                inline constexpr std::ptrdiff_t m_szBarrelSmokeParticle = 0x3D8;
                inline constexpr std::ptrdiff_t m_szMuzzleFlashParticle = 0x2F0;
                inline constexpr std::ptrdiff_t m_szWorldModelAg2Override = 0x108;
                inline constexpr std::ptrdiff_t m_sToolsOnlyOwnerModelName = 0x1E8;
                inline constexpr std::ptrdiff_t m_nMuzzleSmokeShotThreshold = 0x4B8;
                inline constexpr std::ptrdiff_t m_flMuzzleSmokeDecrementRate = 0x4C0;
                inline constexpr std::ptrdiff_t m_szMuzzleFlashParticleConfig = 0x3D0;
            }
            namespace CCSPlayer_GlowServices {

            }
            namespace CCSPlayer_ItemServices {
                inline constexpr std::ptrdiff_t m_bHasHelmet = 0x49;
                inline constexpr std::ptrdiff_t m_bHasDefuser = 0x48;
            }
            namespace CCSPlayer_PingServices {
                inline constexpr std::ptrdiff_t m_hPlayerPing = 0x48;
            }
            namespace CHostageRescueZoneShim {

            }
            namespace CInfoDynamicShadowHint {
                inline constexpr std::ptrdiff_t m_hLight = 0x610;
                inline constexpr std::ptrdiff_t m_flRange = 0x604;
                inline constexpr std::ptrdiff_t m_bDisabled = 0x600;
                inline constexpr std::ptrdiff_t m_nImportance = 0x608;
                inline constexpr std::ptrdiff_t m_nLightChoice = 0x60C;
            }
            namespace CPlayer_CameraServices {
                inline constexpr std::ptrdiff_t m_audio = 0xB0;
                inline constexpr std::ptrdiff_t m_PlayerFog = 0x60;
                inline constexpr std::ptrdiff_t m_CurrentFog = 0x148;
                inline constexpr std::ptrdiff_t m_hViewEntity = 0xA4;
                inline constexpr std::ptrdiff_t m_flOldPlayerZ = 0x140;
                inline constexpr std::ptrdiff_t m_fOverrideFogEnd = 0x1EC;
                inline constexpr std::ptrdiff_t m_OverrideFogColor = 0x1BC;
                inline constexpr std::ptrdiff_t m_angDemoViewAngles = 0x208;
                inline constexpr std::ptrdiff_t m_bOverrideFogColor = 0x1B4;
                inline constexpr std::ptrdiff_t m_fOverrideFogStart = 0x1D8;
                inline constexpr std::ptrdiff_t m_hOldFogController = 0x1B0;
                inline constexpr std::ptrdiff_t m_hTonemapController = 0xA8;
                inline constexpr std::ptrdiff_t m_vecCsViewPunchAngle = 0x48;
                inline constexpr std::ptrdiff_t m_bOverrideFogStartEnd = 0x1D0;
                inline constexpr std::ptrdiff_t m_hColorCorrectionCtrl = 0xA0;
                inline constexpr std::ptrdiff_t m_PostProcessingVolumes = 0x128;
                inline constexpr std::ptrdiff_t m_nCsViewPunchAngleTick = 0x54;
                inline constexpr std::ptrdiff_t m_flOldPlayerViewOffsetZ = 0x144;
                inline constexpr std::ptrdiff_t m_flCsViewPunchAngleTickRatio = 0x58;
                inline constexpr std::ptrdiff_t m_hActivePostProcessingVolume = 0x200;
            }
            namespace CPlayer_WeaponServices {
                inline constexpr std::ptrdiff_t m_iAmmo = 0x68;
                inline constexpr std::ptrdiff_t m_hMyWeapons = 0x48;
                inline constexpr std::ptrdiff_t m_hLastWeapon = 0x64;
                inline constexpr std::ptrdiff_t m_hActiveWeapon = 0x60;
            }
            namespace CPulseCell_CursorQueue {
                inline constexpr std::ptrdiff_t m_nCursorsAllowedToRunParallel = 0x128;
            }
            namespace CPulseCell_FireCursors {
                inline constexpr std::ptrdiff_t m_Outflows = 0xD8;
                inline constexpr std::ptrdiff_t m_OnFinished = 0xF8;
                inline constexpr std::ptrdiff_t m_bWaitForChildOutflows = 0xF0;
            }
            namespace CPulseCell_Inflow_Wait {
                inline constexpr std::ptrdiff_t m_WakeResume = 0xD8;
            }
            namespace CPulseCell_RaceCursors {
                inline constexpr std::ptrdiff_t m_Outflows = 0xD8;
                inline constexpr std::ptrdiff_t m_OnFinished = 0xF0;
            }
            namespace CPulseCell_Value_Curve {
                inline constexpr std::ptrdiff_t m_Curve = 0x48;
            }
            namespace CServerOnlyModelEntity {

            }
            namespace C_HostageCarriableProp {

            }
            namespace C_LateUpdatedAnimating {

            }
            namespace C_PostProcessingVolume {
                inline constexpr std::ptrdiff_t m_bMaster = 0x11BC;
                inline constexpr std::ptrdiff_t m_flMaxExposure = 0x11A8;
                inline constexpr std::ptrdiff_t m_flMinExposure = 0x11A4;
                inline constexpr std::ptrdiff_t m_hPostSettings = 0x1190;
                inline constexpr std::ptrdiff_t m_flFadeDuration = 0x1198;
                inline constexpr std::ptrdiff_t m_bExposureControl = 0x11BD;
                inline constexpr std::ptrdiff_t m_flMaxLogExposure = 0x11A0;
                inline constexpr std::ptrdiff_t m_flMinLogExposure = 0x119C;
                inline constexpr std::ptrdiff_t m_flExposureFadeSpeedUp = 0x11B0;
                inline constexpr std::ptrdiff_t m_flExposureCompensation = 0x11AC;
                inline constexpr std::ptrdiff_t m_flExposureFadeSpeedDown = 0x11B4;
                inline constexpr std::ptrdiff_t m_flTonemapEVSmoothingRange = 0x11B8;
            }
            namespace C_PrecipitationBlocker {

            }
            namespace C_SoundEventAABBEntity {
                inline constexpr std::ptrdiff_t m_vMaxs = 0x6CC;
                inline constexpr std::ptrdiff_t m_vMins = 0x6C0;
            }
            namespace C_SoundEventConeEntity {
                inline constexpr std::ptrdiff_t m_flAttenMax = 0x6CC;
                inline constexpr std::ptrdiff_t m_flAttenMin = 0x6C8;
                inline constexpr std::ptrdiff_t m_flEmitterAngle = 0x6C0;
                inline constexpr std::ptrdiff_t m_flSweetSpotAngle = 0x6C4;
                inline constexpr std::ptrdiff_t m_iszParameterName = 0x6D0;
            }
            namespace inv_image_clearcolor_t {
                inline constexpr std::ptrdiff_t color = 0x0;
            }
            namespace inv_image_light_barn_t {
                inline constexpr std::ptrdiff_t angle = 0xC;
                inline constexpr std::ptrdiff_t color = 0x0;
                inline constexpr std::ptrdiff_t brightness = 0x18;
                inline constexpr std::ptrdiff_t orbit_distance = 0x1C;
            }
            namespace inv_image_light_fill_t {
                inline constexpr std::ptrdiff_t angle = 0xC;
                inline constexpr std::ptrdiff_t color = 0x0;
                inline constexpr std::ptrdiff_t brightness = 0x18;
            }
            namespace CBasePulseGraphInstance {

            }
            namespace CCS2PawnGraphController {
                inline constexpr std::ptrdiff_t m_moveType = 0x2F0;
                inline constexpr std::ptrdiff_t m_airAction = 0x458;
                inline constexpr std::ptrdiff_t m_bIsWalking = 0x398;
                inline constexpr std::ptrdiff_t m_flinchBody = 0x530;
                inline constexpr std::ptrdiff_t m_flinchHead = 0x500;
                inline constexpr std::ptrdiff_t m_bIsDefusing = 0x2D8;
                inline constexpr std::ptrdiff_t m_flLadderYaw = 0x428;
                inline constexpr std::ptrdiff_t m_flMoveSpeedX = 0x320;
                inline constexpr std::ptrdiff_t m_flMoveSpeedY = 0x338;
                inline constexpr std::ptrdiff_t m_groundAction = 0x3C8;
                inline constexpr std::ptrdiff_t m_flAimYawAngle = 0x4E8;
                inline constexpr std::ptrdiff_t m_flLadderCycle = 0x410;
                inline constexpr std::ptrdiff_t m_flCrouchAmount = 0x380;
                inline constexpr std::ptrdiff_t m_flinchIsOnFire = 0x560;
                inline constexpr std::ptrdiff_t m_leftFootTarget = 0x488;
                inline constexpr std::ptrdiff_t m_flAimPitchAngle = 0x4D0;
                inline constexpr std::ptrdiff_t m_flFlashedAmount = 0x4B8;
                inline constexpr std::ptrdiff_t m_moveDirectionID = 0x308;
                inline constexpr std::ptrdiff_t m_rightFootTarget = 0x4A0;
                inline constexpr std::ptrdiff_t m_flinchBodyRestart = 0x548;
                inline constexpr std::ptrdiff_t m_flinchHeadRestart = 0x518;
                inline constexpr std::ptrdiff_t m_flWeaponDropAmount = 0x3B0;
                inline constexpr std::ptrdiff_t m_flLadderYawBackwards = 0x440;
                inline constexpr std::ptrdiff_t m_flMoveSpeedHorizontal = 0x350;
                inline constexpr std::ptrdiff_t m_flAirHeightAboveGround = 0x470;
                inline constexpr std::ptrdiff_t m_groundActionDirectionID = 0x3E0;
                inline constexpr std::ptrdiff_t m_flGroundTurnAngleOrVelocity = 0x3F8;
                inline constexpr std::ptrdiff_t m_flPreviousMoveSpeedHorizontal = 0x368;
            }
            namespace CCSCustomHudLayoutState {
                inline constexpr std::ptrdiff_t m_playerSlot = 0x30;
                inline constexpr std::ptrdiff_t m_vecHasClasses = 0x38;
                inline constexpr std::ptrdiff_t m_bInputCaptureEnabled = 0x34;
                inline constexpr std::ptrdiff_t m_vecDialogVariableStrings = 0x50;
            }
            namespace CCSObserver_UseServices {

            }
            namespace CCSPlayer_WaterServices {
                inline constexpr std::ptrdiff_t m_flSwimSoundTime = 0x58;
                inline constexpr std::ptrdiff_t m_flWaterJumpTime = 0x48;
                inline constexpr std::ptrdiff_t m_vecWaterJumpVel = 0x4C;
            }
            namespace CPlayer_AutoaimServices {

            }
            namespace CPulseCell_Inflow_Yield {
                inline constexpr std::ptrdiff_t m_UnyieldResume = 0xD8;
            }
            namespace CPulseCell_PlaySequence {
                inline constexpr std::ptrdiff_t m_OnFinished = 0xF8;
                inline constexpr std::ptrdiff_t m_SequenceName = 0xD8;
                inline constexpr std::ptrdiff_t m_PulseAnimEvents = 0xE0;
            }
            namespace CPulseCell_ReturnValues {

            }
            namespace CPulseCell_Step_EntFire {
                inline constexpr std::ptrdiff_t m_Input = 0x48;
            }
            namespace CSoundOpvarSetBoxEntity {

            }
            namespace C_CSGO_EndOfMatchCamera {

            }
            namespace C_CSGO_TeamPreviewModel {

            }
            namespace C_CSGO_TeamSelectCamera {

            }
            namespace C_ColorCorrectionVolume {
                inline constexpr std::ptrdiff_t m_Weight = 0x119C;
                inline constexpr std::ptrdiff_t m_bEnabled = 0x1190;
                inline constexpr std::ptrdiff_t m_MaxWeight = 0x1194;
                inline constexpr std::ptrdiff_t m_FadeDuration = 0x1198;
                inline constexpr std::ptrdiff_t m_LastExitTime = 0x118C;
                inline constexpr std::ptrdiff_t m_LastEnterTime = 0x1184;
                inline constexpr std::ptrdiff_t m_LastExitWeight = 0x1188;
                inline constexpr std::ptrdiff_t m_lookupFilename = 0x11A0;
                inline constexpr std::ptrdiff_t m_LastEnterWeight = 0x1180;
            }
            namespace C_FuncElectrifiedVolume {
                inline constexpr std::ptrdiff_t m_bState = 0x10A8;
                inline constexpr std::ptrdiff_t m_EffectName = 0x10A0;
                inline constexpr std::ptrdiff_t m_nAmbientEffect = 0x1098;
            }
            namespace C_MapVetoPickController {
                inline constexpr std::ptrdiff_t m_nMapId0 = 0x834;
                inline constexpr std::ptrdiff_t m_nMapId1 = 0x934;
                inline constexpr std::ptrdiff_t m_nMapId2 = 0xA34;
                inline constexpr std::ptrdiff_t m_nMapId3 = 0xB34;
                inline constexpr std::ptrdiff_t m_nMapId4 = 0xC34;
                inline constexpr std::ptrdiff_t m_nMapId5 = 0xD34;
                inline constexpr std::ptrdiff_t m_nDraftType = 0x610;
                inline constexpr std::ptrdiff_t m_nAccountIDs = 0x734;
                inline constexpr std::ptrdiff_t m_bDisabledHud = 0xF44;
                inline constexpr std::ptrdiff_t m_nCurrentPhase = 0xF34;
                inline constexpr std::ptrdiff_t m_nStartingSide0 = 0xE34;
                inline constexpr std::ptrdiff_t m_nPhaseStartTick = 0xF38;
                inline constexpr std::ptrdiff_t m_nVoteMapIdsList = 0x718;
                inline constexpr std::ptrdiff_t m_nPhaseDurationTicks = 0xF3C;
                inline constexpr std::ptrdiff_t m_nPostDataUpdateTick = 0xF40;
                inline constexpr std::ptrdiff_t m_nTeamWinningCoinToss = 0x614;
                inline constexpr std::ptrdiff_t m_nTeamWithFirstChoice = 0x618;
            }
            namespace C_SkyCameraVolumeTarget {
                inline constexpr std::ptrdiff_t m_hSkyMaterial = 0x608;
                inline constexpr std::ptrdiff_t m_nSkyboxScale = 0x600;
            }
            namespace C_SoundAreaEntitySphere {
                inline constexpr std::ptrdiff_t m_flRadius = 0x628;
            }
            namespace EntityRenderAttribute_t {
                inline constexpr std::ptrdiff_t m_ID = 0x30;
                inline constexpr std::ptrdiff_t m_Values = 0x34;
            }
            namespace SellbackPurchaseEntry_t {
                inline constexpr std::ptrdiff_t m_hItem = 0x40;
                inline constexpr std::ptrdiff_t m_nCost = 0x34;
                inline constexpr std::ptrdiff_t m_unDefIdx = 0x30;
                inline constexpr std::ptrdiff_t m_nPrevArmor = 0x38;
                inline constexpr std::ptrdiff_t m_bPrevHelmet = 0x3C;
            }
            namespace SignatureOutflow_Resume {

            }
            namespace ViewAngleServerChange_t {
                inline constexpr std::ptrdiff_t nType = 0x30;
                inline constexpr std::ptrdiff_t nIndex = 0x40;
                inline constexpr std::ptrdiff_t qAngle = 0x34;
            }
            namespace WeaponPurchaseTracker_t {
                inline constexpr std::ptrdiff_t m_weaponPurchases = 0x8;
            }
            namespace CBaseAnimGraphController {
                inline constexpr std::ptrdiff_t m_hSequence = 0xB0;
                inline constexpr std::ptrdiff_t m_nNotifyState = 0xCC;
                inline constexpr std::ptrdiff_t m_nAnimLoopMode = 0xBC;
                inline constexpr std::ptrdiff_t m_flPlaybackRate = 0xC0;
                inline constexpr std::ptrdiff_t m_flSeqStartTime = 0xB4;
                inline constexpr std::ptrdiff_t m_primaryGraphId = 0x408;
                inline constexpr std::ptrdiff_t m_flSeqFixedCycle = 0xB8;
                inline constexpr std::ptrdiff_t m_flSoundSyncTime = 0x58;
                inline constexpr std::ptrdiff_t m_bSequenceFinished = 0xD0;
                inline constexpr std::ptrdiff_t m_pGraphInstanceAG2 = 0x448;
                inline constexpr std::ptrdiff_t m_vecExternalGraphs = 0x668;
                inline constexpr std::ptrdiff_t m_bLastUpdateSkipped = 0xCF;
                inline constexpr std::ptrdiff_t m_nActiveIKChainMask = 0x5C;
                inline constexpr std::ptrdiff_t m_vecExternalClipIds = 0x428;
                inline constexpr std::ptrdiff_t m_hGraphDefinitionAG2 = 0x370;
                inline constexpr std::ptrdiff_t m_nAnimationAlgorithm = 0x18;
                inline constexpr std::ptrdiff_t m_nPrevAnimUpdateTick = 0xD4;
                inline constexpr std::ptrdiff_t m_vecExternalGraphIds = 0x410;
                inline constexpr std::ptrdiff_t m_sAnimGraph2Identifier = 0x440;
                inline constexpr std::ptrdiff_t m_vecSecondarySkeletons = 0x38;
                inline constexpr std::ptrdiff_t m_nPrevAnimationAlgorithm = 0x699;
                inline constexpr std::ptrdiff_t m_nNextExternalGraphHandle = 0x1C;
                inline constexpr std::ptrdiff_t m_bNetworkedSequenceChanged = 0xCE;
                inline constexpr std::ptrdiff_t m_SerializePoseRecipeAG2Slots = 0x378;
                inline constexpr std::ptrdiff_t m_vecSecondarySkeletonSlotIDs = 0x20;
                inline constexpr std::ptrdiff_t m_SerializePoseRecipeAG2Dynamic = 0x3E0;
                inline constexpr std::ptrdiff_t m_nSecondarySkeletonMasterCount = 0x50;
                inline constexpr std::ptrdiff_t m_nServerGraphInstanceIteration = 0x400;
                inline constexpr std::ptrdiff_t m_nSerializePoseRecipeVersionAG2 = 0x3FC;
                inline constexpr std::ptrdiff_t m_bNetworkedAnimationInputsChanged = 0xCD;
                inline constexpr std::ptrdiff_t m_nSerializePoseRecipeAG2ActiveSlot = 0x3F8;
                inline constexpr std::ptrdiff_t m_nServerSerializationContextIteration = 0x404;
            }
            namespace CCSPlayer_BulletServices {
                inline constexpr std::ptrdiff_t m_totalHitsOnServer = 0x48;
            }
            namespace CCSPlayer_CameraServices {
                inline constexpr std::ptrdiff_t m_flDeathCamTilt = 0x2B0;
                inline constexpr std::ptrdiff_t m_hDeathCamBounds = 0x2B4;
                inline constexpr std::ptrdiff_t m_vClientScopeInaccuracy = 0x2C0;
                inline constexpr std::ptrdiff_t m_bDeathCamBoundsSearched = 0x2B8;
            }
            namespace CCSPlayer_WeaponServices {
                inline constexpr std::ptrdiff_t m_flNextAttack = 0xD0;
                inline constexpr std::ptrdiff_t m_networkAnimTiming = 0x15C0;
                inline constexpr std::ptrdiff_t m_nOldTotalInputHistoryCount = 0x370;
                inline constexpr std::ptrdiff_t m_bBlockInspectUntilNextGraphUpdate = 0x15D8;
                inline constexpr std::ptrdiff_t m_nOldTotalShootPositionHistoryCount = 0xD4;
            }
            namespace CCitadelSoundOpvarSetOBB {
                inline constexpr std::ptrdiff_t m_iszOpvarName = 0x628;
                inline constexpr std::ptrdiff_t m_iszStackName = 0x618;
                inline constexpr std::ptrdiff_t m_nAABBDirection = 0x660;
                inline constexpr std::ptrdiff_t m_iszOperatorName = 0x620;
                inline constexpr std::ptrdiff_t m_vDistanceInnerMaxs = 0x63C;
                inline constexpr std::ptrdiff_t m_vDistanceInnerMins = 0x630;
                inline constexpr std::ptrdiff_t m_vDistanceOuterMaxs = 0x654;
                inline constexpr std::ptrdiff_t m_vDistanceOuterMins = 0x648;
            }
            namespace CPlayer_MovementServices {
                inline constexpr std::ptrdiff_t m_flUpMove = 0x1C8;
                inline constexpr std::ptrdiff_t m_nButtons = 0x50;
                inline constexpr std::ptrdiff_t m_nImpulse = 0x48;
                inline constexpr std::ptrdiff_t m_flLeftMove = 0x1C4;
                inline constexpr std::ptrdiff_t m_flMaxspeed = 0x1AC;
                inline constexpr std::ptrdiff_t m_flCmdUpMove = 0x1A8;
                inline constexpr std::ptrdiff_t m_flCmdLeftMove = 0x1A4;
                inline constexpr std::ptrdiff_t m_flForwardMove = 0x1C0;
                inline constexpr std::ptrdiff_t m_flCmdForwardMove = 0x1A0;
                inline constexpr std::ptrdiff_t m_vecOldViewAngles = 0x240;
                inline constexpr std::ptrdiff_t m_nButtonDoublePressed = 0x80;
                inline constexpr std::ptrdiff_t m_nQueuedButtonDownMask = 0x70;
                inline constexpr std::ptrdiff_t m_nToggleButtonDownMask = 0x190;
                inline constexpr std::ptrdiff_t m_arrForceSubtickMoveWhen = 0x1B0;
                inline constexpr std::ptrdiff_t m_nQueuedButtonChangeMask = 0x78;
                inline constexpr std::ptrdiff_t m_pButtonPressedCmdNumber = 0x88;
                inline constexpr std::ptrdiff_t m_vecLastMovementImpulses = 0x1CC;
                inline constexpr std::ptrdiff_t m_nLastCommandNumberProcessed = 0x188;
            }
            namespace CPlayer_ObserverServices {
                inline constexpr std::ptrdiff_t m_iObserverMode = 0x48;
                inline constexpr std::ptrdiff_t m_hObserverTarget = 0x4C;
                inline constexpr std::ptrdiff_t m_iObserverLastMode = 0x50;
                inline constexpr std::ptrdiff_t m_bForcedObserverMode = 0x54;
                inline constexpr std::ptrdiff_t m_flObserverChaseDistance = 0x58;
                inline constexpr std::ptrdiff_t m_flObserverChaseDistanceCalcTime = 0x5C;
            }
            namespace CPulseCell_Inflow_Method {
                inline constexpr std::ptrdiff_t m_Args = 0xA0;
                inline constexpr std::ptrdiff_t m_bIsPublic = 0x98;
                inline constexpr std::ptrdiff_t m_MethodName = 0x80;
                inline constexpr std::ptrdiff_t m_Description = 0x90;
                inline constexpr std::ptrdiff_t m_ReturnValues = 0xB0;
            }
            namespace CPulseCell_IntervalTimer {
                inline constexpr std::ptrdiff_t m_Completed = 0xD8;
                inline constexpr std::ptrdiff_t m_OnInterval = 0x120;
            }
            namespace CPulseCell_Step_DebugLog {

            }
            namespace CPulse_OutflowConnection {
                inline constexpr std::ptrdiff_t m_nDestChunk = 0x10;
                inline constexpr std::ptrdiff_t m_nInstruction = 0x14;
                inline constexpr std::ptrdiff_t m_SourceOutflowName = 0x0;
                inline constexpr std::ptrdiff_t m_OutflowRegisterMap = 0x18;
            }
            namespace C_CSGO_TeamPreviewCamera {
                inline constexpr std::ptrdiff_t m_nVariant = 0x688;
            }
            namespace C_EnvVolumetricFogVolume {
                inline constexpr std::ptrdiff_t m_bActive = 0x600;
                inline constexpr std::ptrdiff_t m_vBoxMaxs = 0x610;
                inline constexpr std::ptrdiff_t m_vBoxMins = 0x604;
                inline constexpr std::ptrdiff_t m_TintColor = 0x640;
                inline constexpr std::ptrdiff_t m_flStrength = 0x620;
                inline constexpr std::ptrdiff_t m_nFalloffShape = 0x624;
                inline constexpr std::ptrdiff_t m_bStartDisabled = 0x61C;
                inline constexpr std::ptrdiff_t m_fNoiseStrength = 0x63C;
                inline constexpr std::ptrdiff_t m_bIndirectUseLPVs = 0x61D;
                inline constexpr std::ptrdiff_t m_flHeightFogDepth = 0x62C;
                inline constexpr std::ptrdiff_t m_fSunLightStrength = 0x638;
                inline constexpr std::ptrdiff_t m_flFalloffExponent = 0x628;
                inline constexpr std::ptrdiff_t m_bOverrideTintColor = 0x644;
                inline constexpr std::ptrdiff_t m_fHeightFogEdgeWidth = 0x630;
                inline constexpr std::ptrdiff_t m_bOverrideNoiseStrength = 0x647;
                inline constexpr std::ptrdiff_t m_fIndirectLightStrength = 0x634;
                inline constexpr std::ptrdiff_t m_bOverrideSunLightStrength = 0x646;
                inline constexpr std::ptrdiff_t m_bOverrideIndirectLightStrength = 0x645;
            }
            namespace C_LightDirectionalEntity {

            }
            namespace C_LightEnvironmentEntity {

            }
            namespace C_PhysicsPropMultiplayer {

            }
            namespace C_SmokeGrenadeProjectile {
                inline constexpr std::ptrdiff_t m_nRandomSeed = 0x1368;
                inline constexpr std::ptrdiff_t m_vSmokeColor = 0x136C;
                inline constexpr std::ptrdiff_t m_nVoxelUpdate = 0x13A4;
                inline constexpr std::ptrdiff_t m_VoxelFrameData = 0x1388;
                inline constexpr std::ptrdiff_t m_bDidSmokeEffect = 0x1364;
                inline constexpr std::ptrdiff_t m_bSmokeEffectSpawned = 0x13AA;
                inline constexpr std::ptrdiff_t m_nVoxelFrameDataSize = 0x13A0;
                inline constexpr std::ptrdiff_t m_vSmokeDetonationPos = 0x1378;
                inline constexpr std::ptrdiff_t m_nSmokeEffectTickBegin = 0x1360;
                inline constexpr std::ptrdiff_t m_nSmokeLightProbeRegen = 0x13A8;
                inline constexpr std::ptrdiff_t m_bSmokeVolumeDataReceived = 0x13A9;
            }
            namespace C_SoundEventSphereEntity {
                inline constexpr std::ptrdiff_t m_flRadius = 0x6C0;
            }
            namespace C_SoundOpvarSetOBBEntity {

            }
            namespace C_SoundOpvarSetPointBase {
                inline constexpr std::ptrdiff_t m_iOpvarIndex = 0x618;
                inline constexpr std::ptrdiff_t m_bFastRefresh = 0x61D;
                inline constexpr std::ptrdiff_t m_iszOpvarName = 0x610;
                inline constexpr std::ptrdiff_t m_iszStackName = 0x600;
                inline constexpr std::ptrdiff_t m_bUseAutoCompare = 0x61C;
                inline constexpr std::ptrdiff_t m_iszOperatorName = 0x608;
            }
            namespace C_TextureBasedAnimatable {
                inline constexpr std::ptrdiff_t m_bLoop = 0x1098;
                inline constexpr std::ptrdiff_t m_flFPS = 0x109C;
                inline constexpr std::ptrdiff_t m_flStartTime = 0x10C8;
                inline constexpr std::ptrdiff_t m_flStartFrame = 0x10CC;
                inline constexpr std::ptrdiff_t m_hPositionKeys = 0x10A0;
                inline constexpr std::ptrdiff_t m_hRotationKeys = 0x10A8;
                inline constexpr std::ptrdiff_t m_vAnimationBoundsMax = 0x10BC;
                inline constexpr std::ptrdiff_t m_vAnimationBoundsMin = 0x10B0;
            }
            namespace CompMatPropertyMutator_t {
                inline constexpr std::ptrdiff_t m_bEnabled = 0x0;
                inline constexpr std::ptrdiff_t m_nResolution = 0x300;
                inline constexpr std::ptrdiff_t m_vecConditions = 0x378;
                inline constexpr std::ptrdiff_t m_bSplatDebugInfo = 0x310;
                inline constexpr std::ptrdiff_t m_nSetValue_Value = 0x68;
                inline constexpr std::ptrdiff_t m_bIsScratchTarget = 0x304;
                inline constexpr std::ptrdiff_t m_strDrawText_Font = 0x370;
                inline constexpr std::ptrdiff_t m_colDrawText_Color = 0x368;
                inline constexpr std::ptrdiff_t m_bCaptureInRenderDoc = 0x311;
                inline constexpr std::ptrdiff_t m_nMutatorCommandType = 0x4;
                inline constexpr std::ptrdiff_t m_strCompressionFormat = 0x308;
                inline constexpr std::ptrdiff_t m_vecDrawText_Position = 0x360;
                inline constexpr std::ptrdiff_t m_strInitWith_Container = 0x8;
                inline constexpr std::ptrdiff_t m_vecTexGenInstructions = 0x318;
                inline constexpr std::ptrdiff_t m_vecConditionalMutators = 0x330;
                inline constexpr std::ptrdiff_t m_strPopInputQueue_Container = 0x348;
                inline constexpr std::ptrdiff_t m_strDrawText_InputContainerSrc = 0x350;
                inline constexpr std::ptrdiff_t m_strCopyProperty_TargetProperty = 0x20;
                inline constexpr std::ptrdiff_t m_strGenerateTexture_TargetParam = 0x2F0;
                inline constexpr std::ptrdiff_t m_strCopyKeysWithSuffix_FindSuffix = 0x58;
                inline constexpr std::ptrdiff_t m_strCopyProperty_InputContainerSrc = 0x10;
                inline constexpr std::ptrdiff_t m_strDrawText_InputContainerProperty = 0x358;
                inline constexpr std::ptrdiff_t m_strCopyKeysWithSuffix_ReplaceSuffix = 0x60;
                inline constexpr std::ptrdiff_t m_strGenerateTexture_InitialContainer = 0x2F8;
                inline constexpr std::ptrdiff_t m_strRandomRollInputVars_SeedInputVar = 0x28;
                inline constexpr std::ptrdiff_t m_strCopyMatchingKeys_InputContainerSrc = 0x48;
                inline constexpr std::ptrdiff_t m_strCopyProperty_InputContainerProperty = 0x18;
                inline constexpr std::ptrdiff_t m_vecRandomRollInputVars_InputVarsToRoll = 0x30;
                inline constexpr std::ptrdiff_t m_strCopyKeysWithSuffix_InputContainerSrc = 0x50;
            }
            namespace GeneratedTextureHandle_t {
                inline constexpr std::ptrdiff_t m_strBitmapName = 0x0;
            }
            namespace CCS2UIPawnGraphController {
                inline constexpr std::ptrdiff_t m_bCT = 0x228;
                inline constexpr std::ptrdiff_t m_action = 0x168;
                inline constexpr std::ptrdiff_t m_weaponType = 0x1B0;
                inline constexpr std::ptrdiff_t m_weaponState = 0x1C8;
                inline constexpr std::ptrdiff_t m_characterMode = 0xD8;
                inline constexpr std::ptrdiff_t m_nAnimationSeed = 0xC0;
                inline constexpr std::ptrdiff_t m_weaponCategory = 0x198;
                inline constexpr std::ptrdiff_t m_bannerAnimation = 0x180;
                inline constexpr std::ptrdiff_t m_nChickLifeStage = 0x210;
                inline constexpr std::ptrdiff_t m_inspectTurnAngle = 0x1E0;
                inline constexpr std::ptrdiff_t m_nTeamPreviewRandom = 0x120;
                inline constexpr std::ptrdiff_t m_bCharacterModeReset = 0xF0;
                inline constexpr std::ptrdiff_t m_nTeamPreviewVariant = 0x108;
                inline constexpr std::ptrdiff_t m_nTeamPreviewPosition = 0x138;
                inline constexpr std::ptrdiff_t m_endOfMatchCelebration = 0x150;
                inline constexpr std::ptrdiff_t m_nChickSnapshotVariant = 0x1F8;
            }
            namespace CCS2WeaponGraphController {
                inline constexpr std::ptrdiff_t m_action = 0xC0;
                inline constexpr std::ptrdiff_t m_attackType = 0x210;
                inline constexpr std::ptrdiff_t m_weaponType = 0x120;
                inline constexpr std::ptrdiff_t m_reloadStage = 0x288;
                inline constexpr std::ptrdiff_t m_bActionReset = 0xD8;
                inline constexpr std::ptrdiff_t m_flWeaponAmmo = 0x150;
                inline constexpr std::ptrdiff_t m_idleVariation = 0x1E0;
                inline constexpr std::ptrdiff_t m_weaponCategory = 0x108;
                inline constexpr std::ptrdiff_t m_deployVariation = 0x1F8;
                inline constexpr std::ptrdiff_t m_flWeaponAmmoMax = 0x168;
                inline constexpr std::ptrdiff_t m_weaponExtraInfo = 0x138;
                inline constexpr std::ptrdiff_t m_inspectExtraInfo = 0x270;
                inline constexpr std::ptrdiff_t m_inspectVariation = 0x258;
                inline constexpr std::ptrdiff_t m_bWeaponIsSilenced = 0x198;
                inline constexpr std::ptrdiff_t m_flAttackVariation = 0x240;
                inline constexpr std::ptrdiff_t m_attackThrowStrength = 0x228;
                inline constexpr std::ptrdiff_t m_bIsUsingLegacyModel = 0x1C8;
                inline constexpr std::ptrdiff_t m_flWeaponAmmoReserve = 0x180;
                inline constexpr std::ptrdiff_t m_flWeaponIronsightAmount = 0x1B0;
                inline constexpr std::ptrdiff_t m_flWeaponActionSpeedScale = 0xF0;
            }
            namespace CCSGO_EndOfMatchLineupEnd {

            }
            namespace CCSGameModeRules_ArmsRace {
                inline constexpr std::ptrdiff_t m_WeaponSequence = 0x30;
            }
            namespace CCSPlayer_HostageServices {
                inline constexpr std::ptrdiff_t m_hCarriedHostage = 0x48;
                inline constexpr std::ptrdiff_t m_hCarriedHostageProp = 0x4C;
            }
            namespace CEnvSoundscapeTriggerable {

            }
            namespace CInfoDynamicShadowHintBox {
                inline constexpr std::ptrdiff_t m_vBoxMaxs = 0x624;
                inline constexpr std::ptrdiff_t m_vBoxMins = 0x618;
            }
            namespace CPulseCell_Value_Gradient {
                inline constexpr std::ptrdiff_t m_Gradient = 0x48;
            }
            namespace C_BaseCSGrenadeProjectile {
                inline constexpr std::ptrdiff_t m_nBounces = 0x12C8;
                inline constexpr std::ptrdiff_t m_flSpawnTime = 0x12E8;
                inline constexpr std::ptrdiff_t m_vInitialPosition = 0x12B0;
                inline constexpr std::ptrdiff_t m_vInitialVelocity = 0x12BC;
                inline constexpr std::ptrdiff_t flNextTrailLineTime = 0x12F8;
                inline constexpr std::ptrdiff_t vecLastTrailLinePos = 0x12EC;
                inline constexpr std::ptrdiff_t m_bExplodeEffectBegan = 0x12FC;
                inline constexpr std::ptrdiff_t m_nExplodeEffectIndex = 0x12D0;
                inline constexpr std::ptrdiff_t m_bCanCreateGrenadeTrail = 0x12FD;
                inline constexpr std::ptrdiff_t m_vecExplodeEffectOrigin = 0x12DC;
                inline constexpr std::ptrdiff_t m_nExplodeEffectTickBegin = 0x12D8;
                inline constexpr std::ptrdiff_t m_arrTrajectoryTrailPoints = 0x1310;
                inline constexpr std::ptrdiff_t m_nSnapshotTrajectoryEffectIndex = 0x1300;
                inline constexpr std::ptrdiff_t m_flTrajectoryTrailEffectCreationTime = 0x1340;
                inline constexpr std::ptrdiff_t m_hSnapshotTrajectoryParticleSnapshot = 0x1308;
                inline constexpr std::ptrdiff_t m_arrTrajectoryTrailPointCreationTimes = 0x1328;
            }
            namespace C_PointClientUIWorldPanel {
                inline constexpr std::ptrdiff_t m_bLit = 0x1299;
                inline constexpr std::ptrdiff_t m_flDPI = 0x12A4;
                inline constexpr std::ptrdiff_t m_bOpaque = 0x12E0;
                inline constexpr std::ptrdiff_t m_flWidth = 0x129C;
                inline constexpr std::ptrdiff_t m_bNoDepth = 0x12E1;
                inline constexpr std::ptrdiff_t m_flHeight = 0x12A0;
                inline constexpr std::ptrdiff_t m_bGrabbable = 0x12E6;
                inline constexpr std::ptrdiff_t m_bIgnoreInput = 0x1298;
                inline constexpr std::ptrdiff_t m_flDepthOffset = 0x12B0;
                inline constexpr std::ptrdiff_t m_unOrientation = 0x12C0;
                inline constexpr std::ptrdiff_t m_vecCSSClasses = 0x12C8;
                inline constexpr std::ptrdiff_t m_bDisableMipGen = 0x12E8;
                inline constexpr std::ptrdiff_t m_unOwnerContext = 0x12B4;
                inline constexpr std::ptrdiff_t m_bRenderBackface = 0x12E3;
                inline constexpr std::ptrdiff_t m_flWindowUIScale = 0x12A8;
                inline constexpr std::ptrdiff_t m_unVerticalAlign = 0x12BC;
                inline constexpr std::ptrdiff_t m_bCheckCSSClasses = 0x10D2;
                inline constexpr std::ptrdiff_t m_unHorizontalAlign = 0x12B8;
                inline constexpr std::ptrdiff_t m_flInteractDistance = 0x12AC;
                inline constexpr std::ptrdiff_t m_pOffScreenIndicator = 0x1270;
                inline constexpr std::ptrdiff_t m_anchorDeltaTransform = 0x10E0;
                inline constexpr std::ptrdiff_t m_bOnlyRenderToTexture = 0x12E7;
                inline constexpr std::ptrdiff_t m_nExplicitImageLayout = 0x12EC;
                inline constexpr std::ptrdiff_t m_bExcludeFromSaveGames = 0x12E5;
                inline constexpr std::ptrdiff_t m_bUseOffScreenIndicator = 0x12E4;
                inline constexpr std::ptrdiff_t m_bForceRecreateNextUpdate = 0x10D0;
                inline constexpr std::ptrdiff_t m_bIgnoreParentOrientation = 0x12F0;
                inline constexpr std::ptrdiff_t m_bVisibleWhenParentNoDraw = 0x12E2;
                inline constexpr std::ptrdiff_t m_bMoveViewToPlayerNextThink = 0x10D1;
                inline constexpr std::ptrdiff_t m_bFollowPlayerAcrossTeleport = 0x129A;
                inline constexpr std::ptrdiff_t m_bAllowInteractionFromAllSceneWorlds = 0x12C4;
            }
            namespace C_SoundOpvarSetAABBEntity {

            }
            namespace C_SoundOpvarSetDomeEntity {

            }
            namespace CompMatMutatorCondition_t {
                inline constexpr std::ptrdiff_t m_bPassWhenTrue = 0x20;
                inline constexpr std::ptrdiff_t m_nMutatorCondition = 0x0;
                inline constexpr std::ptrdiff_t m_strMutatorConditionContainerName = 0x8;
                inline constexpr std::ptrdiff_t m_strMutatorConditionContainerVarName = 0x10;
                inline constexpr std::ptrdiff_t m_strMutatorConditionContainerVarValue = 0x18;
            }
            namespace OutflowWithRequirements_t {
                inline constexpr std::ptrdiff_t m_Connection = 0x0;
                inline constexpr std::ptrdiff_t m_RequirementNodeIDs = 0x50;
                inline constexpr std::ptrdiff_t m_DestinationFlowNodeID = 0x48;
                inline constexpr std::ptrdiff_t m_nCursorStateBlockIndex = 0x68;
            }
            namespace SignatureOutflow_Continue {

            }
            namespace CCSObserver_CameraServices {
                inline constexpr std::ptrdiff_t m_hPrevPostProcessingVolume = 0x2B0;
            }
            namespace CCSPlayer_AimPunchServices {
                inline constexpr std::ptrdiff_t m_predictableBaseTick = 0x48;
                inline constexpr std::ptrdiff_t m_predictableBaseAngle = 0x50;
                inline constexpr std::ptrdiff_t m_unpredictableBaseTick = 0xA0;
                inline constexpr std::ptrdiff_t m_unpredictableBaseAngle = 0xA4;
                inline constexpr std::ptrdiff_t m_predictableBaseAngleVel = 0x5C;
                inline constexpr std::ptrdiff_t m_predictableBaseTickInterpAmount = 0x4C;
            }
            namespace CCSPlayer_MovementServices {
                inline constexpr std::ptrdiff_t m_vecUp = 0x674;
                inline constexpr std::ptrdiff_t m_bDucked = 0x408;
                inline constexpr std::ptrdiff_t m_vecLeft = 0x668;
                inline constexpr std::ptrdiff_t m_bDucking = 0x416;
                inline constexpr std::ptrdiff_t m_StuckLast = 0x64C;
                inline constexpr std::ptrdiff_t m_flStamina = 0x694;
                inline constexpr std::ptrdiff_t m_LegacyJump = 0x6B0;
                inline constexpr std::ptrdiff_t m_ModernJump = 0x6C8;
                inline constexpr std::ptrdiff_t m_vecForward = 0x65C;
                inline constexpr std::ptrdiff_t m_bWasSurfing = 0x714;
                inline constexpr std::ptrdiff_t m_flDuckSpeed = 0x410;
                inline constexpr std::ptrdiff_t m_nTraceCount = 0x648;
                inline constexpr std::ptrdiff_t m_bDesiresDuck = 0x415;
                inline constexpr std::ptrdiff_t m_bInStuckTest = 0x43A;
                inline constexpr std::ptrdiff_t m_flDuckAmount = 0x40C;
                inline constexpr std::ptrdiff_t m_bDuckOverride = 0x414;
                inline constexpr std::ptrdiff_t m_bSpeedCropped = 0x650;
                inline constexpr std::ptrdiff_t m_nLastJumpTick = 0x700;
                inline constexpr std::ptrdiff_t m_AnimationState = 0x310;
                inline constexpr std::ptrdiff_t m_flLastDuckTime = 0x420;
                inline constexpr std::ptrdiff_t m_flLastJumpFrac = 0x704;
                inline constexpr std::ptrdiff_t m_nOldWaterLevel = 0x654;
                inline constexpr std::ptrdiff_t m_vecWalkWishVel = 0x7A4;
                inline constexpr std::ptrdiff_t m_vecLadderNormal = 0x3F8;
                inline constexpr std::ptrdiff_t m_bJumpApexPending = 0x70C;
                inline constexpr std::ptrdiff_t m_flDuckRootOffset = 0x418;
                inline constexpr std::ptrdiff_t m_flDuckViewOffset = 0x41C;
                inline constexpr std::ptrdiff_t m_flWaterEntryTime = 0x658;
                inline constexpr std::ptrdiff_t m_duckUntilOnGround = 0x438;
                inline constexpr std::ptrdiff_t m_flHeightAtJumpStart = 0x698;
                inline constexpr std::ptrdiff_t m_flLastJumpVelocityZ = 0x708;
                inline constexpr std::ptrdiff_t m_flVelMulAtJumpStart = 0x6A8;
                inline constexpr std::ptrdiff_t m_flStaminaAtJumpStart = 0x6A4;
                inline constexpr std::ptrdiff_t m_flBombPlantViewOffset = 0x424;
                inline constexpr std::ptrdiff_t m_flAccumulatedJumpError = 0x6AC;
                inline constexpr std::ptrdiff_t m_flFrictionStashedSpeed = 0x690;
                inline constexpr std::ptrdiff_t m_flMaxJumpHeightLastJump = 0x6A0;
                inline constexpr std::ptrdiff_t m_flMaxJumpHeightThisJump = 0x69C;
                inline constexpr std::ptrdiff_t m_nLadderSurfacePropIndex = 0x404;
                inline constexpr std::ptrdiff_t m_bHasEverProcessedCommand = 0xFD0;
                inline constexpr std::ptrdiff_t m_bUseFrictionStashedSpeed = 0x688;
                inline constexpr std::ptrdiff_t m_bHasWalkMovedSinceLastJump = 0x439;
                inline constexpr std::ptrdiff_t m_bUsingGroundTopologyOffset = 0x3F0;
                inline constexpr std::ptrdiff_t m_fStashGrenadeParameterWhen = 0x684;
                inline constexpr std::ptrdiff_t m_flTicksSinceLastSurfingDetected = 0x710;
                inline constexpr std::ptrdiff_t m_vecLastPositionAtFullCrouchSpeed = 0x430;
                inline constexpr std::ptrdiff_t m_flUseFrictionStashedSpeedUntilFrac = 0x68C;
                inline constexpr std::ptrdiff_t m_nGameCodeHasMovedPlayerAfterCommand = 0x680;
                inline constexpr std::ptrdiff_t m_flUsingGroundTopologyOffsetTransitionSmoothing = 0x3F4;
            }
            namespace CPlayer_FlashlightServices {

            }
            namespace CPointOffScreenIndicatorUi {
                inline constexpr std::ptrdiff_t m_bHide = 0x1301;
                inline constexpr std::ptrdiff_t m_bBeenEnabled = 0x1300;
                inline constexpr std::ptrdiff_t m_pTargetPanel = 0x1308;
                inline constexpr std::ptrdiff_t m_flSeenTargetTime = 0x1304;
            }
            namespace CPulseCell_BaseRequirement {

            }
            namespace CPulseCell_Value_RandomInt {

            }
            namespace CPulse_BlackboardReference {
                inline constexpr std::ptrdiff_t m_nNodeID = 0x18;
                inline constexpr std::ptrdiff_t m_NodeName = 0x20;
                inline constexpr std::ptrdiff_t m_BlackboardResource = 0x8;
                inline constexpr std::ptrdiff_t m_hBlackboardResource = 0x0;
            }
            namespace C_MapPreviewParticleSystem {

            }
            namespace C_ShatterGlassShardPhysics {
                inline constexpr std::ptrdiff_t m_ShardDesc = 0x10A0;
            }
            namespace C_SoundOpvarSetPointEntity {

            }
            namespace PulseNodeDynamicOutflows_t {
                inline constexpr std::ptrdiff_t m_Outflows = 0x0;
            }
            namespace PulseSelectorOutflowList_t {
                inline constexpr std::ptrdiff_t m_Outflows = 0x0;
            }
            namespace CBodyComponentBaseAnimGraph {
                inline constexpr std::ptrdiff_t m_animationController = 0x510;
            }
            namespace CCSGameModeRules_Deathmatch {
                inline constexpr std::ptrdiff_t m_sDMBonusWeapon = 0x38;
                inline constexpr std::ptrdiff_t m_flDMBonusStartTime = 0x30;
                inline constexpr std::ptrdiff_t m_flDMBonusTimeLength = 0x34;
            }
            namespace CCompositeMaterialEditorDoc {
                inline constexpr std::ptrdiff_t m_Points = 0x10;
                inline constexpr std::ptrdiff_t m_nVersion = 0x8;
                inline constexpr std::ptrdiff_t m_KVthumbnail = 0x28;
            }
            namespace CDestructiblePartsComponent {
                inline constexpr std::ptrdiff_t m_hOwner = 0x60;
                inline constexpr std::ptrdiff_t __m_pChainEntity = 0x0;
                inline constexpr std::ptrdiff_t m_vecDamageTakenByHitGroup = 0x48;
                inline constexpr std::ptrdiff_t m_pAnimGraphDestructibleGraphController = 0x68;
            }
            namespace CNetworkedSequenceOperation {
                inline constexpr std::ptrdiff_t m_flCycle = 0x10;
                inline constexpr std::ptrdiff_t m_flWeight = 0x14;
                inline constexpr std::ptrdiff_t m_hSequence = 0x8;
                inline constexpr std::ptrdiff_t m_flPrevCycle = 0xC;
                inline constexpr std::ptrdiff_t m_bDiscontinuity = 0x1D;
                inline constexpr std::ptrdiff_t m_bSequenceChangeNetworked = 0x1C;
                inline constexpr std::ptrdiff_t m_flPrevCycleFromDiscontinuity = 0x20;
                inline constexpr std::ptrdiff_t m_flPrevCycleForAnimEventDetection = 0x24;
            }
            namespace CPulseCell_Inflow_GraphHook {
                inline constexpr std::ptrdiff_t m_HookName = 0x80;
            }
            namespace C_CSGO_MapPreviewCameraPath {
                inline constexpr std::ptrdiff_t m_bLoop = 0x608;
                inline constexpr std::ptrdiff_t m_flZFar = 0x600;
                inline constexpr std::ptrdiff_t m_flZNear = 0x604;
                inline constexpr std::ptrdiff_t m_flDuration = 0x60C;
                inline constexpr std::ptrdiff_t m_bDofEnabled = 0x66C;
                inline constexpr std::ptrdiff_t m_bVerticalFOV = 0x609;
                inline constexpr std::ptrdiff_t m_flPathLength = 0x650;
                inline constexpr std::ptrdiff_t m_flDofFarCrisp = 0x678;
                inline constexpr std::ptrdiff_t m_bConstantSpeed = 0x60A;
                inline constexpr std::ptrdiff_t m_flDofFarBlurry = 0x67C;
                inline constexpr std::ptrdiff_t m_flDofNearCrisp = 0x674;
                inline constexpr std::ptrdiff_t m_flPathDuration = 0x654;
                inline constexpr std::ptrdiff_t m_flDofNearBlurry = 0x670;
                inline constexpr std::ptrdiff_t m_flDofTiltToGround = 0x680;
            }
            namespace CCSObserver_MovementServices {

            }
            namespace CCSObserver_ObserverServices {
                inline constexpr std::ptrdiff_t m_obsInterpState = 0x68;
            }
            namespace CCSPlayerBase_CameraServices {
                inline constexpr std::ptrdiff_t m_iFOV = 0x298;
                inline constexpr std::ptrdiff_t m_flFOVRate = 0x2A4;
                inline constexpr std::ptrdiff_t m_flFOVTime = 0x2A0;
                inline constexpr std::ptrdiff_t m_iFOVStart = 0x29C;
                inline constexpr std::ptrdiff_t m_hZoomOwner = 0x2A8;
                inline constexpr std::ptrdiff_t m_flLastShotFOV = 0x2AC;
            }
            namespace CPulseCell_Step_PublicOutput {
                inline constexpr std::ptrdiff_t m_OutputIndex = 0x48;
            }
            namespace CPulseCell_Value_RandomFloat {

            }
            namespace CPulseCell_WaitForObservable {
                inline constexpr std::ptrdiff_t m_OnTrue = 0x168;
                inline constexpr std::ptrdiff_t m_Condition = 0xD8;
            }
            namespace C_CSGO_EndOfMatchLineupStart {

            }
            namespace C_CSGO_TeamPreviewCameraBone {

            }
            namespace C_EnvVolumetricFogController {
                inline constexpr std::ptrdiff_t m_bActive = 0x64C;
                inline constexpr std::ptrdiff_t m_vBoxMaxs = 0x640;
                inline constexpr std::ptrdiff_t m_vBoxMins = 0x634;
                inline constexpr std::ptrdiff_t m_TintColor = 0x604;
                inline constexpr std::ptrdiff_t m_bIsMaster = 0x676;
                inline constexpr std::ptrdiff_t m_bFirstTime = 0x6A8;
                inline constexpr std::ptrdiff_t m_fWindSpeed = 0x698;
                inline constexpr std::ptrdiff_t m_fNoiseSpeed = 0x684;
                inline constexpr std::ptrdiff_t m_flFadeInEnd = 0x618;
                inline constexpr std::ptrdiff_t m_flFadeSpeed = 0x60C;
                inline constexpr std::ptrdiff_t m_vNoiseScale = 0x68C;
                inline constexpr std::ptrdiff_t m_flAnisotropy = 0x608;
                inline constexpr std::ptrdiff_t m_flScattering = 0x600;
                inline constexpr std::ptrdiff_t m_nVolumeDepth = 0x620;
                inline constexpr std::ptrdiff_t m_flFadeInStart = 0x614;
                inline constexpr std::ptrdiff_t m_bStartDisabled = 0x674;
                inline constexpr std::ptrdiff_t m_fNoiseStrength = 0x688;
                inline constexpr std::ptrdiff_t m_flDrawDistance = 0x610;
                inline constexpr std::ptrdiff_t m_vWindDirection = 0x69C;
                inline constexpr std::ptrdiff_t m_bEnableIndirect = 0x675;
                inline constexpr std::ptrdiff_t m_flStartAnisoTime = 0x650;
                inline constexpr std::ptrdiff_t m_flStartAnisotropy = 0x65C;
                inline constexpr std::ptrdiff_t m_flStartScattering = 0x660;
                inline constexpr std::ptrdiff_t m_flIndirectStrength = 0x61C;
                inline constexpr std::ptrdiff_t m_flStartScatterTime = 0x654;
                inline constexpr std::ptrdiff_t m_nForceRefreshCount = 0x680;
                inline constexpr std::ptrdiff_t m_flDefaultAnisotropy = 0x668;
                inline constexpr std::ptrdiff_t m_flDefaultScattering = 0x66C;
                inline constexpr std::ptrdiff_t m_flStartDrawDistance = 0x664;
                inline constexpr std::ptrdiff_t m_hFogIndirectTexture = 0x678;
                inline constexpr std::ptrdiff_t m_nIndirectTextureDimX = 0x628;
                inline constexpr std::ptrdiff_t m_nIndirectTextureDimY = 0x62C;
                inline constexpr std::ptrdiff_t m_nIndirectTextureDimZ = 0x630;
                inline constexpr std::ptrdiff_t m_flDefaultDrawDistance = 0x670;
                inline constexpr std::ptrdiff_t m_flStartDrawDistanceTime = 0x658;
                inline constexpr std::ptrdiff_t m_fFirstVolumeSliceThickness = 0x624;
            }
            namespace C_NetTestBaseCombatCharacter {

            }
            namespace C_SoundAreaEntityOrientedBox {
                inline constexpr std::ptrdiff_t m_vMax = 0x634;
                inline constexpr std::ptrdiff_t m_vMin = 0x628;
            }
            namespace C_SoundEventMultiPointEntity {

            }
            namespace C_SoundEventPathCornerEntity {
                inline constexpr std::ptrdiff_t m_vecCornerPairsNetworked = 0x6C0;
            }
            namespace C_SoundOpvarSetOBBWindEntity {

            }
            namespace VPhysicsCollisionAttribute_t {
                inline constexpr std::ptrdiff_t m_nOwnerId = 0x24;
                inline constexpr std::ptrdiff_t m_nEntityId = 0x20;
                inline constexpr std::ptrdiff_t m_nHierarchyId = 0x28;
                inline constexpr std::ptrdiff_t m_nInteractsAs = 0x8;
                inline constexpr std::ptrdiff_t m_nInteractsWith = 0x10;
                inline constexpr std::ptrdiff_t m_nCollisionGroup = 0x2E;
                inline constexpr std::ptrdiff_t m_nDetailLayerMask = 0x2A;
                inline constexpr std::ptrdiff_t m_nInteractsExclude = 0x18;
                inline constexpr std::ptrdiff_t m_nTargetDetailLayer = 0x2D;
                inline constexpr std::ptrdiff_t m_nDetailLayerMaskType = 0x2C;
                inline constexpr std::ptrdiff_t m_nCollisionFunctionMask = 0x2F;
            }
            namespace CBodyComponentBaseModelEntity {

            }
            namespace CCSPlayer_DamageReactServices {

            }
            namespace CInfoOffscreenPanoramaTexture {
                inline constexpr std::ptrdiff_t m_bDisabled = 0x600;
                inline constexpr std::ptrdiff_t m_szPanelType = 0x610;
                inline constexpr std::ptrdiff_t m_nResolutionX = 0x604;
                inline constexpr std::ptrdiff_t m_nResolutionY = 0x608;
                inline constexpr std::ptrdiff_t m_bEnableMipGen = 0x601;
                inline constexpr std::ptrdiff_t m_szTargetsName = 0x660;
                inline constexpr std::ptrdiff_t m_vecCSSClasses = 0x648;
                inline constexpr std::ptrdiff_t m_RenderAttrName = 0x620;
                inline constexpr std::ptrdiff_t m_TargetEntities = 0x628;
                inline constexpr std::ptrdiff_t m_bCheckCSSClasses = 0x7E0;
                inline constexpr std::ptrdiff_t m_szLayoutFileName = 0x618;
                inline constexpr std::ptrdiff_t m_nTargetChangeCount = 0x640;
                inline constexpr std::ptrdiff_t m_AdditionalTargetEntities = 0x668;
            }
            namespace CPlayerSprayDecalRenderHelper {

            }
            namespace CPulseCell_BaseYieldingInflow {
                inline constexpr std::ptrdiff_t m_BaseFlow_WhileActive = 0x90;
                inline constexpr std::ptrdiff_t m_BaseFlow_OnAfterCancel = 0x48;
            }
            namespace CPulseCell_BooleanSwitchState {
                inline constexpr std::ptrdiff_t m_WhenTrue = 0x168;
                inline constexpr std::ptrdiff_t m_Condition = 0xD8;
                inline constexpr std::ptrdiff_t m_WhenFalse = 0x1B0;
            }
            namespace CPulseCell_IsRequirementValid {

            }
            namespace CPulseCell_LerpCameraSettings {
                inline constexpr std::ptrdiff_t m_End = 0x134;
                inline constexpr std::ptrdiff_t m_Start = 0x124;
                inline constexpr std::ptrdiff_t m_flSeconds = 0x120;
            }
            namespace C_EnvCombinedLightProbeVolume {
                inline constexpr std::ptrdiff_t m_Entity_Color = 0x718;
                inline constexpr std::ptrdiff_t m_Entity_bEnabled = 0x7D1;
                inline constexpr std::ptrdiff_t m_Entity_vBoxMaxs = 0x774;
                inline constexpr std::ptrdiff_t m_Entity_vBoxMins = 0x768;
                inline constexpr std::ptrdiff_t m_Entity_bMoveable = 0x780;
                inline constexpr std::ptrdiff_t m_Entity_nPriority = 0x78C;
                inline constexpr std::ptrdiff_t m_Entity_nHandshake = 0x784;
                inline constexpr std::ptrdiff_t m_Entity_flBrightness = 0x71C;
                inline constexpr std::ptrdiff_t m_Entity_bStartDisabled = 0x790;
                inline constexpr std::ptrdiff_t m_Entity_flEdgeFadeDist = 0x794;
                inline constexpr std::ptrdiff_t m_Entity_vEdgeFadeDists = 0x798;
                inline constexpr std::ptrdiff_t m_Entity_hCubemapTexture = 0x720;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeSizeX = 0x7A4;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeSizeY = 0x7A8;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeSizeZ = 0x7AC;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeAtlasX = 0x7B0;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeAtlasY = 0x7B4;
                inline constexpr std::ptrdiff_t m_Entity_nLightProbeAtlasZ = 0x7B8;
                inline constexpr std::ptrdiff_t m_Entity_bCustomCubemapTexture = 0x728;
                inline constexpr std::ptrdiff_t m_Entity_nEnvCubeMapArrayIndex = 0x788;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeTexture_SDF = 0x738;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeTexture_SH2_DC = 0x740;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeTexture_SH2_L1 = 0x748;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeTexture_AmbientCube = 0x730;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeDirectLightIndicesTexture = 0x750;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeDirectLightScalarsTexture = 0x758;
                inline constexpr std::ptrdiff_t m_Entity_hLightProbeDirectLightShadowsTexture = 0x760;
            }
            namespace C_PointClientUIWorldTextPanel {
                inline constexpr std::ptrdiff_t m_messageText = 0x1300;
            }
            namespace C_SceneEntity__QueuedEvents_t {
                inline constexpr std::ptrdiff_t starttime = 0x0;
            }
            namespace C_SoundOpvarSetAutoRoomEntity {

            }
            namespace CBodyComponentSkeletonInstance {
                inline constexpr std::ptrdiff_t m_skeletonInstance = 0x80;
            }
            namespace CPulseCell_Inflow_EventHandler {
                inline constexpr std::ptrdiff_t m_EventName = 0x80;
            }
            namespace CPulseCell_Outflow_CycleRandom {
                inline constexpr std::ptrdiff_t m_Outputs = 0x48;
            }
            namespace C_PortraitWorldCallbackHandler {

            }
            namespace CompositeMaterialEditorPoint_t {
                inline constexpr std::ptrdiff_t m_flCycle = 0xE4;
                inline constexpr std::ptrdiff_t m_ModelName = 0x0;
                inline constexpr std::ptrdiff_t m_ChildModelName = 0x100;
                inline constexpr std::ptrdiff_t m_nSequenceIndex = 0xE0;
                inline constexpr std::ptrdiff_t m_bEnableChildModel = 0xF8;
                inline constexpr std::ptrdiff_t m_KVModelStateChoices = 0xE8;
                inline constexpr std::ptrdiff_t m_vecCompositeMaterials = 0x1F8;
                inline constexpr std::ptrdiff_t m_vecCompositeMaterialAssemblyProcedures = 0x1E0;
            }
            namespace CompositeMaterialMatchFilter_t {
                inline constexpr std::ptrdiff_t m_bPassWhenTrue = 0x18;
                inline constexpr std::ptrdiff_t m_strMatchValue = 0x10;
                inline constexpr std::ptrdiff_t m_strMatchFilter = 0x8;
                inline constexpr std::ptrdiff_t m_nCompositeMaterialMatchFilterType = 0x0;
            }
            namespace CPulseCell_Outflow_CycleOrdered {
                inline constexpr std::ptrdiff_t m_Outputs = 0x48;
            }
            namespace C_CSGO_EndOfMatchLineupEndpoint {

            }
            namespace C_CSGO_MapPreviewCameraPathNode {
                inline constexpr std::ptrdiff_t m_flFOV = 0x624;
                inline constexpr std::ptrdiff_t m_flEaseIn = 0x62C;
                inline constexpr std::ptrdiff_t m_flEaseOut = 0x630;
                inline constexpr std::ptrdiff_t m_nPathIndex = 0x608;
                inline constexpr std::ptrdiff_t m_flCameraSpeed = 0x628;
                inline constexpr std::ptrdiff_t m_vInTangentLocal = 0x60C;
                inline constexpr std::ptrdiff_t m_vInTangentWorld = 0x634;
                inline constexpr std::ptrdiff_t m_vOutTangentLocal = 0x618;
                inline constexpr std::ptrdiff_t m_vOutTangentWorld = 0x640;
                inline constexpr std::ptrdiff_t m_szParentPathUniqueID = 0x600;
            }
            namespace C_CSGO_TerroristRushIntroCamera {

            }
            namespace C_CSGO_TerroristTeamIntroCamera {

            }
            namespace C_DynamicPropAlias_dynamic_prop {

            }
            namespace C_SoundOpvarSetPathCornerEntity {

            }
            namespace ServerAuthoritativeWeaponSlot_t {
                inline constexpr std::ptrdiff_t unSlot = 0x32;
                inline constexpr std::ptrdiff_t unClass = 0x30;
                inline constexpr std::ptrdiff_t unItemDefIdx = 0x34;
            }
            namespace CCSGO_RushIntroCharacterPosition {

            }
            namespace CCSGO_RushIntroTerroristPosition {

            }
            namespace CCSPlayer_ActionTrackingServices {
                inline constexpr std::ptrdiff_t m_bIsRescuing = 0x4C;
                inline constexpr std::ptrdiff_t m_weaponPurchasesThisMatch = 0x50;
                inline constexpr std::ptrdiff_t m_weaponPurchasesThisRound = 0xC0;
                inline constexpr std::ptrdiff_t m_weaponCarryOverIntoThisRound = 0x130;
                inline constexpr std::ptrdiff_t m_hLastWeaponBeforeC4AutoSwitch = 0x48;
            }
            namespace CCS_PortraitWorldCallbackHandler {

            }
            namespace CPulseCell_Inflow_BaseEntrypoint {
                inline constexpr std::ptrdiff_t m_EntryChunk = 0x48;
                inline constexpr std::ptrdiff_t m_RegisterMap = 0x50;
            }
            namespace CPulseCell_Outflow_CycleShuffled {
                inline constexpr std::ptrdiff_t m_Outputs = 0x48;
            }
            namespace CPulseCell_WaitForCursorsWithTag {
                inline constexpr std::ptrdiff_t m_bTagSelfWhenComplete = 0x128;
                inline constexpr std::ptrdiff_t m_nDesiredKillPriority = 0x12C;
            }
            namespace C_DynamicPropAlias_cable_dynamic {

            }
            namespace C_RopeKeyframe__CPhysicsDelegate {
                inline constexpr std::ptrdiff_t m_pKeyframe = 0x8;
            }
            namespace CBaseAnimGraphAlias_baseanimating {

            }
            namespace CPlayer_MovementServices_Humanoid {
                inline constexpr std::ptrdiff_t m_nStepside = 0x280;
                inline constexpr std::ptrdiff_t m_groundNormal = 0x260;
                inline constexpr std::ptrdiff_t m_surfaceProps = 0x270;
                inline constexpr std::ptrdiff_t m_flFallVelocity = 0x25C;
                inline constexpr std::ptrdiff_t m_flStepSoundTime = 0x258;
                inline constexpr std::ptrdiff_t m_flSurfaceFriction = 0x26C;
            }
            namespace CPulseCell_InlineNodeSkipSelector {
                inline constexpr std::ptrdiff_t m_bAnd = 0x4C;
                inline constexpr std::ptrdiff_t m_FailOutflow = 0x68;
                inline constexpr std::ptrdiff_t m_PassOutflow = 0x50;
                inline constexpr std::ptrdiff_t m_nFlowNodeID = 0x48;
            }
            namespace CPulseCell_LimitCount__Criteria_t {
                inline constexpr std::ptrdiff_t m_bLimitCountPasses = 0x0;
            }
            namespace C_CSGO_TeamIntroCharacterPosition {

            }
            namespace C_CSGO_TeamIntroTerroristPosition {

            }
            namespace C_EconEntity__AttachedModelData_t {
                inline constexpr std::ptrdiff_t m_iModelDisplayFlags = 0x0;
            }
            namespace CompositeMaterialInputContainer_t {
                inline constexpr std::ptrdiff_t m_bEnabled = 0x0;
                inline constexpr std::ptrdiff_t m_strAlias = 0xF0;
                inline constexpr std::ptrdiff_t m_strAttrName = 0xE8;
                inline constexpr std::ptrdiff_t m_bExposeExternally = 0x118;
                inline constexpr std::ptrdiff_t m_strAttrNameForVar = 0x110;
                inline constexpr std::ptrdiff_t m_vecLooseVariables = 0xF8;
                inline constexpr std::ptrdiff_t m_strSpecificContainerMaterial = 0x8;
                inline constexpr std::ptrdiff_t m_nCompositeMaterialInputContainerSourceType = 0x4;
            }
            namespace CCSPlayerController_DamageServices {
                inline constexpr std::ptrdiff_t m_DamageList = 0x48;
                inline constexpr std::ptrdiff_t m_nSendUpdate = 0x40;
            }
            namespace CEnvSoundscapeAlias_snd_soundscape {

            }
            namespace CPulseCell_BaseLerp__CursorState_t {
                inline constexpr std::ptrdiff_t m_EndTime = 0x4;
                inline constexpr std::ptrdiff_t m_StartTime = 0x0;
            }
            namespace CPulseCell_Inflow_EntOutputHandler {
                inline constexpr std::ptrdiff_t m_SourceEntity = 0x80;
                inline constexpr std::ptrdiff_t m_SourceOutput = 0x90;
                inline constexpr std::ptrdiff_t m_ExpectedParamType = 0xA0;
            }
            namespace CPulseCell_PickBestOutflowSelector {
                inline constexpr std::ptrdiff_t m_nCheckType = 0x48;
                inline constexpr std::ptrdiff_t m_OutflowList = 0x50;
            }
            namespace CPulseCell_Step_CallExternalMethod {
                inline constexpr std::ptrdiff_t m_MethodName = 0xD8;
                inline constexpr std::ptrdiff_t m_OnFinished = 0x108;
                inline constexpr std::ptrdiff_t m_ExpectedArgs = 0xF0;
                inline constexpr std::ptrdiff_t m_nAsyncCallMode = 0x100;
                inline constexpr std::ptrdiff_t m_nBlackboardIndex = 0xE8;
            }
            namespace C_CSGO_EndOfMatchCharacterPosition {

            }
            namespace C_CSGO_TeamSelectCharacterPosition {

            }
            namespace C_CSGO_TeamSelectTerroristPosition {

            }
            namespace C_CSGO_TerroristWingmanIntroCamera {

            }
            namespace CCSGO_WingmanIntroCharacterPosition {

            }
            namespace CCSGO_WingmanIntroTerroristPosition {

            }
            namespace C_CSGO_TeamPreviewCharacterPosition {
                inline constexpr std::ptrdiff_t m_xuid = 0x618;
                inline constexpr std::ptrdiff_t m_nRandom = 0x604;
                inline constexpr std::ptrdiff_t m_petItem = 0x1730;
                inline constexpr std::ptrdiff_t m_nOrdinal = 0x608;
                inline constexpr std::ptrdiff_t m_nVariant = 0x600;
                inline constexpr std::ptrdiff_t m_agentItem = 0x620;
                inline constexpr std::ptrdiff_t m_glovesItem = 0xBD0;
                inline constexpr std::ptrdiff_t m_weaponItem = 0x1180;
                inline constexpr std::ptrdiff_t m_sWeaponName = 0x610;
            }
            namespace AnimGraph2SerializedPoseRecipeSlot_t {
                inline constexpr std::ptrdiff_t m_topology = 0x30;
            }
            namespace CPulseCell_Timeline__TimelineEvent_t {
                inline constexpr std::ptrdiff_t m_EventOutflow = 0x8;
                inline constexpr std::ptrdiff_t m_flTimeFromPrevious = 0x0;
            }
            namespace CPulseCell_WaitForCursorsWithTagBase {
                inline constexpr std::ptrdiff_t m_WaitComplete = 0xE0;
                inline constexpr std::ptrdiff_t m_nCursorsAllowedToWait = 0xD8;
            }
            namespace CompositeMaterialAssemblyProcedure_t {
                inline constexpr std::ptrdiff_t m_vecMatchFilters = 0x18;
                inline constexpr std::ptrdiff_t m_vecCompMatIncludes = 0x0;
                inline constexpr std::ptrdiff_t m_vecPropertyMutators = 0x48;
                inline constexpr std::ptrdiff_t m_vecCompositeInputContainers = 0x30;
            }
            namespace CCSPlayerController_InventoryServices {
                inline constexpr std::ptrdiff_t m_rank = 0x5C;
                inline constexpr std::ptrdiff_t m_unMusicID = 0x58;
                inline constexpr std::ptrdiff_t m_vecNetworkableLoadout = 0x40;
                inline constexpr std::ptrdiff_t m_nPersonaDataPublicLevel = 0x74;
                inline constexpr std::ptrdiff_t m_nPersonaDataXpTrailLevel = 0x84;
                inline constexpr std::ptrdiff_t m_nPersonaDataPublicCommendsLeader = 0x78;
                inline constexpr std::ptrdiff_t m_nPersonaDataPublicCommendsTeacher = 0x7C;
                inline constexpr std::ptrdiff_t m_vecServerAuthoritativeWeaponSlots = 0x88;
                inline constexpr std::ptrdiff_t m_nPersonaDataPublicCommendsFriendly = 0x80;
            }
            namespace C_BaseModelEntity__BodyGroupRequest_t {
                inline constexpr std::ptrdiff_t m_nGroup = 0x10;
                inline constexpr std::ptrdiff_t m_uChoice = 0x14;
                inline constexpr std::ptrdiff_t m_uRefCount = 0x16;
                inline constexpr std::ptrdiff_t m_nGroupName = 0x4;
                inline constexpr std::ptrdiff_t m_uRequestID = 0x0;
                inline constexpr std::ptrdiff_t m_sChoiceName = 0x8;
            }
            namespace C_BaseModelEntity__Emphasized_Phoneme {
                inline constexpr std::ptrdiff_t m_bValid = 0x1E;
                inline constexpr std::ptrdiff_t m_flAmount = 0x18;
                inline constexpr std::ptrdiff_t m_bRequired = 0x1C;
                inline constexpr std::ptrdiff_t m_sClassName = 0x0;
                inline constexpr std::ptrdiff_t m_bBasechecked = 0x1D;
            }
            namespace C_InfoInstructorHintHostageRescueZone {

            }
            namespace CompositeMaterialInputLooseVariable_t {
                inline constexpr std::ptrdiff_t m_strName = 0x0;
                inline constexpr std::ptrdiff_t m_strString = 0x270;
                inline constexpr std::ptrdiff_t m_nValueIntW = 0x54;
                inline constexpr std::ptrdiff_t m_nValueIntX = 0x48;
                inline constexpr std::ptrdiff_t m_nValueIntY = 0x4C;
                inline constexpr std::ptrdiff_t m_nValueIntZ = 0x50;
                inline constexpr std::ptrdiff_t m_cValueColor4 = 0x8C;
                inline constexpr std::ptrdiff_t m_nTextureType = 0x268;
                inline constexpr std::ptrdiff_t m_bValueBoolean = 0x44;
                inline constexpr std::ptrdiff_t m_flValueFloatW = 0x80;
                inline constexpr std::ptrdiff_t m_flValueFloatX = 0x5C;
                inline constexpr std::ptrdiff_t m_flValueFloatY = 0x68;
                inline constexpr std::ptrdiff_t m_flValueFloatZ = 0x74;
                inline constexpr std::ptrdiff_t m_nVariableType = 0x40;
                inline constexpr std::ptrdiff_t m_bHasFloatBounds = 0x58;
                inline constexpr std::ptrdiff_t m_nValueSystemVar = 0x90;
                inline constexpr std::ptrdiff_t m_bExposeExternally = 0x8;
                inline constexpr std::ptrdiff_t m_flValueFloatW_Max = 0x88;
                inline constexpr std::ptrdiff_t m_flValueFloatW_Min = 0x84;
                inline constexpr std::ptrdiff_t m_flValueFloatX_Max = 0x64;
                inline constexpr std::ptrdiff_t m_flValueFloatX_Min = 0x60;
                inline constexpr std::ptrdiff_t m_flValueFloatY_Max = 0x70;
                inline constexpr std::ptrdiff_t m_flValueFloatY_Min = 0x6C;
                inline constexpr std::ptrdiff_t m_flValueFloatZ_Max = 0x7C;
                inline constexpr std::ptrdiff_t m_flValueFloatZ_Min = 0x78;
                inline constexpr std::ptrdiff_t m_nPanoramaRenderRes = 0x280;
                inline constexpr std::ptrdiff_t m_strExposedValueList = 0x38;
                inline constexpr std::ptrdiff_t m_strResourceMaterial = 0x98;
                inline constexpr std::ptrdiff_t m_strPanoramaPanelPath = 0x278;
                inline constexpr std::ptrdiff_t m_strExposedFriendlyName = 0x10;
                inline constexpr std::ptrdiff_t m_strExposedHiddenWhenTrue = 0x30;
                inline constexpr std::ptrdiff_t m_strExposedVisibleWhenTrue = 0x28;
                inline constexpr std::ptrdiff_t m_strTextureContentAssetPath = 0x178;
                inline constexpr std::ptrdiff_t m_strExposedFriendlyGroupName = 0x18;
                inline constexpr std::ptrdiff_t m_bExposedVariableIsFixedRange = 0x20;
                inline constexpr std::ptrdiff_t m_strTextureRuntimeResourcePath = 0x180;
                inline constexpr std::ptrdiff_t m_strTextureCompilationVtexTemplate = 0x260;
            }
            namespace CPulseCell_LimitCount__InstanceState_t {
                inline constexpr std::ptrdiff_t m_nCurrentCount = 0x0;
            }
            namespace CPulseCell_PlaySequence__CursorState_t {
                inline constexpr std::ptrdiff_t m_hTarget = 0x0;
            }
            namespace C_CSGO_CounterTerroristRushIntroCamera {

            }
            namespace C_CSGO_CounterTerroristTeamIntroCamera {

            }
            namespace CCSGO_RushIntroCounterTerroristPosition {

            }
            namespace CCSPlayerController_InGameMoneyServices {
                inline constexpr std::ptrdiff_t m_iAccount = 0x40;
                inline constexpr std::ptrdiff_t m_iStartAccount = 0x44;
                inline constexpr std::ptrdiff_t m_iTotalCashSpent = 0x48;
                inline constexpr std::ptrdiff_t m_iCashSpentThisRound = 0x4C;
            }
            namespace CPulseCell_IntervalTimer__CursorState_t {
                inline constexpr std::ptrdiff_t m_EndTime = 0x4;
                inline constexpr std::ptrdiff_t m_StartTime = 0x0;
                inline constexpr std::ptrdiff_t m_flWaitInterval = 0x8;
                inline constexpr std::ptrdiff_t m_flWaitIntervalHigh = 0xC;
                inline constexpr std::ptrdiff_t m_bCompleteOnNextWake = 0x10;
            }
            namespace C_SoundEventEntityAlias_snd_event_point {

            }
            namespace C_CSGO_TeamIntroCounterTerroristPosition {

            }
            namespace C_DynamicPropAlias_prop_dynamic_override {

            }
            namespace CPulseCell_IsRequirementValid__Criteria_t {
                inline constexpr std::ptrdiff_t m_bIsValid = 0x0;
            }
            namespace C_CSGO_CounterTerroristWingmanIntroCamera {

            }
            namespace C_CSGO_TeamSelectCounterTerroristPosition {

            }
            namespace CCSGO_WingmanIntroCounterTerroristPosition {

            }
            namespace CCSPlayerController_ActionTrackingServices {
                inline constexpr std::ptrdiff_t m_matchStats = 0xA8;
                inline constexpr std::ptrdiff_t m_perRoundStats = 0x40;
                inline constexpr std::ptrdiff_t m_iNumRoundKills = 0x128;
                inline constexpr std::ptrdiff_t m_flTotalRoundDamageDealt = 0x130;
                inline constexpr std::ptrdiff_t m_iNumRoundKillsHeadshots = 0x12C;
            }
            namespace CAttributeManager__cached_attribute_float_t {
                inline constexpr std::ptrdiff_t flIn = 0x0;
                inline constexpr std::ptrdiff_t flOut = 0x10;
                inline constexpr std::ptrdiff_t iAttribHook = 0x8;
            }
            namespace CPulseCell_Inflow_ObservableVariableListener {
                inline constexpr std::ptrdiff_t m_bSelfReference = 0x82;
                inline constexpr std::ptrdiff_t m_nBlackboardReference = 0x80;
            }
            namespace CPulseCell_LerpCameraSettings__CursorState_t {
                inline constexpr std::ptrdiff_t m_hCamera = 0x8;
                inline constexpr std::ptrdiff_t m_OverlaidEnd = 0x1C;
                inline constexpr std::ptrdiff_t m_OverlaidStart = 0xC;
            }
            namespace PulseNodeDynamicOutflows_t__DynamicOutflow_t {
                inline constexpr std::ptrdiff_t m_OutflowID = 0x0;
                inline constexpr std::ptrdiff_t m_Connection = 0x8;
            }
            namespace CEnvSoundscapeProxyAlias_snd_soundscape_proxy {

            }
            namespace C_CSGO_PreviewModelAlias_csgo_item_previewmodel {

            }
            namespace CPulseCell_Outflow_CycleOrdered__InstanceState_t {
                inline constexpr std::ptrdiff_t m_nNextIndex = 0x0;
            }
            namespace CPulseCell_Outflow_CycleShuffled__InstanceState_t {
                inline constexpr std::ptrdiff_t m_Shuffle = 0x0;
                inline constexpr std::ptrdiff_t m_nNextShuffle = 0x20;
            }
            namespace C_TonemapController2Alias_env_tonemap_controller2 {

            }
            namespace C_CSGO_PreviewPlayerAlias_csgo_player_previewmodel {

            }
            namespace C_PathParticleRopeAlias_path_particle_rope_clientside {

            }
            namespace CEnvSoundscapeTriggerableAlias_snd_soundscape_triggerable {

            }
            namespace CCSPlayerController_InventoryServices__NetworkedLoadoutSlot_t {
                inline constexpr std::ptrdiff_t slot = 0xA;
                inline constexpr std::ptrdiff_t team = 0x8;
                inline constexpr std::ptrdiff_t pItem = 0x0;
            }
            namespace C_EnvCombinedLightProbeVolumeAlias_func_combined_light_probe_volume {

            }
            namespace P2P_Messages {
                inline constexpr std::ptrdiff_t p2p_Ping = 0x102;
                inline constexpr std::ptrdiff_t p2p_Voice = 0x101;
                inline constexpr std::ptrdiff_t p2p_TextMessage = 0x100;
                inline constexpr std::ptrdiff_t p2p_VRAvatarPosition = 0x103;
                inline constexpr std::ptrdiff_t p2p_WatchSynchronization = 0x104;
                inline constexpr std::ptrdiff_t p2p_FightingGame_GameData = 0x105;
                inline constexpr std::ptrdiff_t p2p_FightingGame_Connection = 0x106;
            }
            namespace InventoryNodeType_t {
                inline constexpr std::ptrdiff_t NODE_TYPE_INVALID = 0x0;
                inline constexpr std::ptrdiff_t VIRTUAL_NODE_SCHEMA_PREFAB = 0x1;
                inline constexpr std::ptrdiff_t CONCRETE_NODE_SCHEMA_PREFAB = 0x5;
                inline constexpr std::ptrdiff_t VIRTUAL_NODE_SCHEMA_ITEMDEF = 0x2;
                inline constexpr std::ptrdiff_t VIRTUAL_NODE_SCHEMA_STICKER = 0x3;
                inline constexpr std::ptrdiff_t CONCRETE_NODE_SCHEMA_ITEMDEF = 0x6;
                inline constexpr std::ptrdiff_t CONCRETE_NODE_SCHEMA_STICKER = 0x7;
                inline constexpr std::ptrdiff_t VIRTUAL_NODE_SCHEMA_KEYCHAIN = 0x4;
                inline constexpr std::ptrdiff_t CONCRETE_NODE_SCHEMA_KEYCHAIN = 0x8;
            }
            namespace PulseMethodCallMode_t {
                inline constexpr std::ptrdiff_t ASYNC_FIRE_AND_FORGET = 0x1;
                inline constexpr std::ptrdiff_t SYNC_WAIT_FOR_COMPLETION = 0x0;
            }
            namespace PulseBestOutflowRules_t {
                inline constexpr std::ptrdiff_t SORT_BY_OUTFLOW_INDEX = 0x1;
                inline constexpr std::ptrdiff_t SORT_BY_NUMBER_OF_VALID_CRITERIA = 0x0;
            }
            namespace PulseCursorWakePriority_t {
                inline constexpr std::ptrdiff_t WakeElegantly = 0x0;
                inline constexpr std::ptrdiff_t WakeImmediate = 0x1;
            }
            namespace PulseCursorCancelPriority_t {
                inline constexpr std::ptrdiff_t _None = 0x0;
                inline constexpr std::ptrdiff_t HardCancel = 0x3;
                inline constexpr std::ptrdiff_t SoftCancel = 0x2;
                inline constexpr std::ptrdiff_t CancelOnSucceeded = 0x1;
            }
            namespace CompMatPropertyMutatorType_t {
                inline constexpr std::ptrdiff_t COMP_MAT_PROPERTY_MUTATOR_INIT = 0x0;
                inline constexpr std::ptrdiff_t COMP_MAT_PROPERTY_MUTATOR_DRAW_TEXT = 0x8;
                inline constexpr std::ptrdiff_t COMP_MAT_PROPERTY_MUTATOR_SET_VALUE = 0x4;
                inline constexpr std::ptrdiff_t COMP_MAT_PROPERTY_MUTATOR_COPY_PROPERTY = 0x3;
                inline constexpr std::ptrdiff_t COMP_MAT_PROPERTY_MUTATOR_POP_INPUT_QUEUE = 0x7;
                inline constexpr std::ptrdiff_t COMP_MAT_PROPERTY_MUTATOR_GENERATE_TEXTURE = 0x5;
                inline constexpr std::ptrdiff_t COMP_MAT_PROPERTY_MUTATOR_COPY_MATCHING_KEYS = 0x1;
                inline constexpr std::ptrdiff_t COMP_MAT_PROPERTY_MUTATOR_CONDITIONAL_MUTATORS = 0x6;
                inline constexpr std::ptrdiff_t COMP_MAT_PROPERTY_MUTATOR_COPY_KEYS_WITH_SUFFIX = 0x2;
                inline constexpr std::ptrdiff_t COMP_MAT_PROPERTY_MUTATOR_RANDOM_ROLL_INPUT_VARIABLES = 0x9;
            }
            namespace CompositeMaterialVarSystemVar_t {
                inline constexpr std::ptrdiff_t COMPMATSYSVAR_COMPOSITETIME = 0x0;
                inline constexpr std::ptrdiff_t COMPMATSYSVAR_EMPTY_RESOURCE_SPACER = 0x1;
            }
            namespace CompositeMaterialMatchFilterType_t {
                inline constexpr std::ptrdiff_t MATCH_FILTER_MATERIAL_SHADER = 0x1;
                inline constexpr std::ptrdiff_t MATCH_FILTER_MATERIAL_NAME_SUBSTR = 0x2;
                inline constexpr std::ptrdiff_t MATCH_FILTER_MATERIAL_PROPERTY_EQUALS = 0x5;
                inline constexpr std::ptrdiff_t MATCH_FILTER_MATERIAL_PROPERTY_EXISTS = 0x4;
                inline constexpr std::ptrdiff_t MATCH_FILTER_MATERIAL_ATTRIBUTE_EQUALS = 0x3;
                inline constexpr std::ptrdiff_t MATCH_FILTER_MATERIAL_ATTRIBUTE_EXISTS = 0x0;
            }
            namespace CompositeMaterialInputTextureType_t {
                inline constexpr std::ptrdiff_t INPUT_TEXTURE_TYPE_AO = 0x6;
                inline constexpr std::ptrdiff_t INPUT_TEXTURE_TYPE_COLOR = 0x2;
                inline constexpr std::ptrdiff_t INPUT_TEXTURE_TYPE_MASKS = 0x3;
                inline constexpr std::ptrdiff_t INPUT_TEXTURE_TYPE_DEFAULT = 0x0;
                inline constexpr std::ptrdiff_t INPUT_TEXTURE_TYPE_POSITION = 0x7;
                inline constexpr std::ptrdiff_t INPUT_TEXTURE_TYPE_NORMALMAP = 0x1;
                inline constexpr std::ptrdiff_t INPUT_TEXTURE_TYPE_ROUGHNESS = 0x4;
                inline constexpr std::ptrdiff_t INPUT_TEXTURE_TYPE_PEARLESCENCE_MASK = 0x5;
            }
            namespace CompMatPropertyMutatorConditionType_t {
                inline constexpr std::ptrdiff_t COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_EXISTS = 0x0;
                inline constexpr std::ptrdiff_t COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_VALUE_EQUALS = 0x2;
                inline constexpr std::ptrdiff_t COMP_MAT_MUTATOR_CONDITION_INPUT_CONTAINER_VALUE_EXISTS = 0x1;
            }
            namespace C_BaseCombatCharacter__WaterWakeMode_t {
                inline constexpr std::ptrdiff_t WATER_WAKE_IDLE = 0x1;
                inline constexpr std::ptrdiff_t WATER_WAKE_NONE = 0x0;
                inline constexpr std::ptrdiff_t WATER_WAKE_RUNNING = 0x3;
                inline constexpr std::ptrdiff_t WATER_WAKE_WALKING = 0x2;
                inline constexpr std::ptrdiff_t WATER_WAKE_WATER_OVERHEAD = 0x4;
            }
            namespace CompositeMaterialInputLooseVariableType_t {
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_COLOR4 = 0x9;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_FLOAT1 = 0x5;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_FLOAT2 = 0x6;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_FLOAT3 = 0x7;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_FLOAT4 = 0x8;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_STRING = 0xA;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_BOOLEAN = 0x0;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_INTEGER1 = 0x1;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_INTEGER2 = 0x2;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_INTEGER3 = 0x3;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_INTEGER4 = 0x4;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_SYSTEMVAR = 0xB;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_PANORAMA_RENDER = 0xE;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_RESOURCE_TEXTURE = 0xD;
                inline constexpr std::ptrdiff_t LOOSE_VARIABLE_TYPE_RESOURCE_MATERIAL = 0xC;
            }
            namespace CompositeMaterialInputContainerSourceType_t {
                inline constexpr std::ptrdiff_t CONTAINER_SOURCE_TYPE_LOOSE_VARIABLES = 0x3;
                inline constexpr std::ptrdiff_t CONTAINER_SOURCE_TYPE_TARGET_MATERIAL = 0x0;
                inline constexpr std::ptrdiff_t CONTAINER_SOURCE_TYPE_SPECIFIC_MATERIAL = 0x2;
                inline constexpr std::ptrdiff_t CONTAINER_SOURCE_TYPE_TARGET_INSTANCE_MATERIAL = 0x5;
                inline constexpr std::ptrdiff_t CONTAINER_SOURCE_TYPE_MATERIAL_FROM_TARGET_ATTR = 0x1;
                inline constexpr std::ptrdiff_t CONTAINER_SOURCE_TYPE_VARIABLE_FROM_TARGET_ATTR = 0x4;
            }
        }
    }
}
