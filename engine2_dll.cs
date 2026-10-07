public static partial class cs2_dumper {
    public static partial class schemas {
        public static partial class engine2_dll {
            public static partial class GameTick_t {
                public const long m_Value = 0x0;
            }
            public static partial class GameTime_t {
                public const long m_Value = 0x0;
            }
            public static partial class EventBugBug_t {

            }
            public static partial class EventSetTime_t {
                public const long m_LoopState = 0x0;
                public const long m_flRealTime = 0x30;
                public const long m_flRenderTime = 0x38;
                public const long m_flTickRemainder = 0x58;
                public const long m_flRenderFrameTime = 0x40;
                public const long m_nClientOutputFrames = 0x28;
                public const long m_flRenderFrameTimeUnscaled = 0x50;
                public const long m_flRenderFrameTimeUnbounded = 0x48;
            }
            public static partial class CEntityIOOutput {

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
            public static partial class EventSimulate_t {
                public const long m_LoopState = 0x0;
                public const long m_bLastTick = 0x29;
                public const long m_bFirstTick = 0x28;
            }
            public static partial class CEntityComponent {

            }
            public static partial class CEntityKeyValues {

            }
            public static partial class CScriptComponent {
                public const long m_scriptClassName = 0x30;
            }
            public static partial class EngineLoopState_t {
                public const long m_nRenderWidth = 0x20;
                public const long m_nRenderHeight = 0x24;
                public const long m_nPlatWindowWidth = 0x18;
                public const long m_nPlatWindowHeight = 0x1C;
            }
            public static partial class CNetworkVarChainer {
                public const long m_PathIndex = 0x20;
            }
            public static partial class EntComponentInfo_t {
                public const long m_pName = 0x0;
                public const long m_nFlags = 0x24;
                public const long m_nRuntimeIndex = 0x20;
                public const long m_pCPPClassname = 0x8;
                public const long m_pBaseClassComponentHelper = 0x58;
                public const long m_pNetworkDataReferencedDescription = 0x10;
                public const long m_pNetworkDataReferencedPtrPropDescription = 0x18;
            }
            public static partial class EventAdvanceTick_t {
                public const long m_nTotalTicks = 0x3C;
                public const long m_nCurrentTick = 0x30;
                public const long m_nTotalTicksThisFrame = 0x38;
                public const long m_nCurrentTickThisFrame = 0x34;
            }
            public static partial class EventAppShutdown_t {
                public const long m_nDummy0 = 0x0;
            }
            public static partial class EventClientOutput_t {
                public const long m_LoopState = 0x0;
                public const long m_flRealTime = 0x2C;
                public const long m_bRenderOnly = 0x34;
                public const long m_flRenderTime = 0x28;
                public const long m_flRenderFrameTimeUnbounded = 0x30;
            }
            public static partial class CEmptyEntityInstance {

            }
            public static partial class EventFrameBoundary_t {
                public const long m_flFrameTime = 0x0;
            }
            public static partial class EventPreDataUpdate_t {
                public const long m_nCount = 0x0;
            }
            public static partial class CEntityAttributeTable {
                public const long m_Names = 0x28;
                public const long m_Attributes = 0x0;
            }
            public static partial class EventBugBugComplete_t {
                public const long m_pPayload = 0x0;
            }
            public static partial class EventClientSimulate_t {

            }
            public static partial class EventModInitialized_t {

            }
            public static partial class EventPostDataUpdate_t {
                public const long m_nCount = 0x0;
            }
            public static partial class CEntityComponentHelper {
                public const long m_flags = 0x8;
                public const long m_pInfo = 0x10;
                public const long m_pNext = 0x20;
                public const long m_nPriority = 0x18;
            }
            public static partial class EventClientPollInput_t {
                public const long m_LoopState = 0x0;
                public const long m_flRealTime = 0x28;
            }
            public static partial class EventClientPreOutput_t {
                public const long m_LoopState = 0x0;
                public const long m_flRealTime = 0x40;
                public const long m_bRenderOnly = 0x44;
                public const long m_flRenderTime = 0x28;
                public const long m_flRenderFrameTime = 0x30;
                public const long m_flRenderFrameTimeUnbounded = 0x38;
            }
            public static partial class EventPostAdvanceTick_t {
                public const long m_nTotalTicks = 0x3C;
                public const long m_nCurrentTick = 0x30;
                public const long m_nTotalTicksThisFrame = 0x38;
                public const long m_nCurrentTickThisFrame = 0x34;
            }
            public static partial class EventClientPostOutput_t {
                public const long m_LoopState = 0x0;
                public const long m_bRenderOnly = 0x38;
                public const long m_flRenderTime = 0x28;
                public const long m_flRenderFrameTime = 0x30;
                public const long m_flRenderFrameTimeUnbounded = 0x34;
            }
            public static partial class CVariantDefaultAllocator {

            }
            public static partial class EventClientAdvanceTick_t {

            }
            public static partial class EventClientPreSimulate_t {

            }
            public static partial class EventServerAdvanceTick_t {

            }
            public static partial class EventServerEndSimulate_t {
                public const long m_bLastTick = 0x0;
            }
            public static partial class EventClientPostSimulate_t {

            }
            public static partial class EventClientProcessInput_t {
                public const long m_LoopState = 0x0;
                public const long m_flRealTime = 0x28;
                public const long m_flTickInterval = 0x2C;
                public const long m_flTickStartTime = 0x30;
            }
            public static partial class EventServerPostSimulate_t {
                public const long m_bLastTickBeforeClientUpdate = 0x30;
            }
            public static partial class EventClientFrameSimulate_t {
                public const long m_LoopState = 0x0;
                public const long m_flRealTime = 0x28;
                public const long m_flFrameTime = 0x2C;
                public const long m_bScheduleSendTickPacket = 0x30;
            }
            public static partial class EventClientPauseSimulate_t {

            }
            public static partial class EventServerBeginSimulate_t {

            }
            public static partial class EventClientPollNetworking_t {
                public const long m_nTickCount = 0x0;
            }
            public static partial class EventServerPollNetworking_t {

            }
            public static partial class EventClientPostAdvanceTick_t {

            }
            public static partial class EventServerPostAdvanceTick_t {
                public const long m_bLastTickBeforeClientUpdate = 0x40;
            }
            public static partial class EventSimpleLoopFrameUpdate_t {
                public const long m_LoopState = 0x0;
                public const long m_flRealTime = 0x28;
                public const long m_flFrameTime = 0x2C;
            }
            public static partial class EventClientProcessGameInput_t {
                public const long m_LoopState = 0x0;
                public const long m_flRealTime = 0x28;
                public const long m_flFrameTime = 0x2C;
            }
            public static partial class EventClientProcessNetworking_t {
                public const long m_nTickCount = 0x0;
            }
            public static partial class EventProfileStorageAvailable_t {
                public const long m_nSplitScreenSlot = 0x0;
            }
            public static partial class EventServerProcessNetworking_t {

            }
            public static partial class EventSplitScreenStateChanged_t {

            }
            public static partial class EntityIOQueuePrioritizedEvent_t {
                public const long m_hCaller = 0x24;
                public const long m_pTarget = 0x10;
                public const long m_paramMap = 0xD0;
                public const long m_flFireTime = 0x4;
                public const long m_hActivator = 0x20;
                public const long m_hEntTarget = 0x28;
                public const long m_targetType = 0x8;
                public const long m_pTargetInput = 0x18;
                public const long m_variantValue = 0x30;
                public const long m_PulseArguments = 0x40;
            }
            public static partial class EventServerEndAsyncPostTickWork_t {

            }
            public static partial class EventServerBeginAsyncPostTickWork_t {
                public const long m_bIsOncePerFrameAsyncWorkPhase = 0x0;
            }
            public static partial class EventClientAdvanceNonRenderedFrame_t {

            }
            public static partial class EventClientPreOutputParallelWithServer_t {

            }
            public static partial class EventClientSceneSystemThreadStateChange_t {
                public const long m_bThreadsActive = 0x0;
            }
            public static partial class EntityDormancyType_t {
                public const long ENTITY_DORMANT = 0x1;
                public const long ENTITY_SUSPENDED = 0x2;
                public const long ENTITY_NOT_DORMANT = 0x0;
            }
            public static partial class EntityIOTargetType_t {
                public const long ENTITY_IO_TARGET_EHANDLE = 0x6;
                public const long ENTITY_IO_TARGET_INVALID = -0x1;
                public const long ENTITY_IO_TARGET_ENTITYNAME = 0x2;
                public const long ENTITY_IO_TARGET_ENTITYNAME_OR_CLASSNAME = 0x7;
            }
        }
    }
}
